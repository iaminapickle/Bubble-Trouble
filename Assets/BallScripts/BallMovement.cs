using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float x_vel;
    [SerializeField] private float bounciness;
    private Vector2 prev_vel;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * x_vel, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            Vector2 vel = transform.right * prev_vel.x + transform.up * bounciness;
            rb.AddForce(vel, ForceMode2D.Impulse);
        }

        else if (col.gameObject.tag == "Wall")
        {
            prev_vel.x *= -1;
            rb.velocity = prev_vel;
        }
    }

    void FixedUpdate()
    {
        prev_vel = rb.velocity;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
