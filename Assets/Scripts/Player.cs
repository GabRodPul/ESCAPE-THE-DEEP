using UnityEngine;
using GRPU.Extensions;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float gravityScale = 1f;
    public Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetOrAddComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // float inputHorizontal = Input.GetAxis("Horizontal");
        // rb.linearVelocity 
        //     = rb.linearVelocity.WithX(inputHorizontal * speed);

        rb.linearVelocity
            = new Vector2( Input.GetAxis( "Horizontal" ), Input.GetAxis( "Vertical" ) )
            * speed;
    }

    void OnCollisionEnter2D( Collision2D other )
    {
        if ( other.gameObject.layer == Layers.Hazard )
            GameManager.Instance.GameOver();
    }
}
