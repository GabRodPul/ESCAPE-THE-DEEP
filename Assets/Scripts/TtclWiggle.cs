using System.Linq;
using GRPU.Extensions;
using UnityEngine;

public class TtclWiggle : MonoBehaviour
{

    (float min, float max)[] _r = {
        (-18.331f, 14.764f),
        (-28.728f, 30.481f),
        (-21.228f, 34.951f),
        (-15.808f, 10.998f)
    };

    Transform[] _children;

    float[] _startT;

    void Start()
    {
        _children = transform.GetComponentsInChildren<SpriteRenderer>()
            .Select( c => c.transform )
            .ToArray();

        UnityEngine.Assertions.Assert.AreEqual(_r.Length, _children.Length);
        float t = Time.time;
        _startT = new float[_children.Length]
            .Select( _ => t )
            .ToArray();
    }

    void Update()
    {
        for ( int i = 0; i < _children.Length; i++ )
        {
            if ( i >= _children.Length )
                Debug.Break();

            //_children[i].eulerAngles = 
            //    transform.eulerAngles.WithZ(Mathf.SmoothDamp(
            //        _rbounds[i].min,
            //        _rbounds[i].max,
            //        Time.time - _startT[i] // transform.eulerAngles.z
            //    ));

            var g = Physics2D.gravity;
            _children[i].eulerAngles =
                transform.eulerAngles.WithZ(Mathf.Lerp(
                    _r[i].min,
                    _r[i].max,
                    Time.time - _startT[i] // transform.eulerAngles.z
                ) );                

            if ( Mathf.Approximately( transform.eulerAngles.z, _r[i].max ) )
            {
                _startT[i] = Time.time;
                _r[i] = (_r[i].max, _r[i].min);
            }
        }
    }
}
