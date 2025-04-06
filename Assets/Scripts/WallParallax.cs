using UnityEngine;

public class WallParallax : MonoBehaviour
{
    float   _speed, _sprHeight;
    Vector2 _start;

    void Start()
    {
        _start      = transform.position;
        _sprHeight = GetComponent<SpriteRenderer>()
            .bounds
            .size
            .x;

        _speed = Physics2D.gravity.y / 2;
    }

    void Update()
    {
        transform.position
            = _start
            + ( Vector2.down * transform.position.y * _speed );

        _start += Vector2.right 
                * _sprHeight 
                * Mathf.Abs( transform.position.y );
    }
}
