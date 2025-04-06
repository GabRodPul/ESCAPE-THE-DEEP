using GRPU.Extensions;
using UnityEngine;

public class WallsSpritesScroll : MonoBehaviour
{
#if true
    Rigidbody2D _rb;
    float _startY = 8.2f;

    void Start()
    {
        _rb = this.GetOrAddComponent<Rigidbody2D>();
        _rb.gravityScale = 0.5f;
    }

    void Update()
    {
        if ( transform.position.y >= _startY )
        {
            Debug.Log( transform.position.y );
            transform.position = transform.position.WithY( _startY );
        }
    }
#else
    SpriteRenderer  _sprRnd;
    Material        _mat;

    void Start()
    {
        _sprRnd = GetComponent<SpriteRenderer>();

        // Clone material
        //_mat    = new Material( _sprRnd.material );
        //_sprRnd.material = _mat;
        _mat = _sprRnd.material;
    }

    void Update()
    {
        //_mat.mainTextureOffset += Physics2D.gravity * Time.deltaTime;
        _mat.SetTextureOffset("_MainTex", Physics2D.gravity * Time.deltaTime);
        Debug.Log($"[{typeof(WallsSpritesScroll).Name}]: _mat.mainTextureOffset = {_mat.mainTextureOffset}" );
    }
#endif
}
