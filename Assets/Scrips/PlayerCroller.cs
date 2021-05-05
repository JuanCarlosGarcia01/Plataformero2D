using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCroller : MonoBehaviour
{

    public float runSpeed = 2;

    public float jumpSpeed = 3;

    public bool SaltoMejorado = false;
    public float caida = 0.5f;
    public float Bajo = 1f;
    public SpriteRenderer spriteRenderer;

    bool enElSuelo;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (Input.GetKey("up") || Input.GetKey("w") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        if (SaltoMejorado)
        {
            if (rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up* Physics2D.gravity.y * (caida)* Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("w"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (Bajo) * Time.deltaTime;
            }
        }
    }
}
