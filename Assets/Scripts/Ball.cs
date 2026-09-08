using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float SpeedOfBall = 5f;

    private Rigidbody2D rb;
    private bool FirstTouch = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // First movement: straight down
        rb.linearVelocity = Vector2.down * SpeedOfBall;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Only react to the FIRST collision with the Paddle
        if (!FirstTouch && collision.gameObject.CompareTag("Paddle"))
        {
            FirstTouch = true;

            // Move diagonally upward
            rb.linearVelocity =
                new Vector2(1f, 1f).normalized * SpeedOfBall;
        }
    }

    private void FixedUpdate()
    {
        // Keep ball speed constant
        rb.linearVelocity =
            rb.linearVelocity.normalized * SpeedOfBall;
    }
}
