using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float jumpspeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        jump();
    }

    private void Update()
    {
        if (rb.velocity.y > 0)
            sr.flipY = false;
        else
            sr.flipY = true;

    }

    void jump()
    {
        rb.AddForce(new Vector2(0, jumpspeed));
    }
}
