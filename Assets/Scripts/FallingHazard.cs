using UnityEngine;
using GRPU.Extensions;

public class FallingHazard : MonoBehaviour
{
    Rigidbody2D _rb;

    void Start()
    {
        _rb = this.GetOrAddComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch ( other.gameObject.layer )
        {
            case Layers.TheVoid:
                // Return to Pool
                gameObject.SetActive( false );
                return;
        }
    }
}
