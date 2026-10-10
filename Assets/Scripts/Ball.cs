using UnityEngine;

public class Ball : MonoBehaviour
{

    public float SpeedOfBall = 5f;

    private Rigidbody2D rb;
    private bool FirstTouch = false;


    public int n = 0;


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
            rb.linearVelocity = new Vector2(1f, 1f).normalized * SpeedOfBall;
        }
        if (collision.gameObject.tag == "Tiles")
        {
            Destroy(collision.gameObject);




        }
    }

    private void FixedUpdate()
    {
        // Keep ball speed constant
        rb.linearVelocity =
            rb.linearVelocity.normalized * SpeedOfBall;
        Vector2 velocity = rb.linearVelocity;

        if (Mathf.Abs(velocity.x) < 1f)
        {
            if (velocity.x >= 0)
            {
                velocity.x = 1f;
            }
            else
            {
                velocity.x = -1f;
            }
        }

        if (Mathf.Abs(velocity.y) < 1f)
        {
            if (velocity.y >= 0)
            {
                velocity.y = 1f;
            }
            else
            {
                velocity.y = -1f;
            }
        }

        rb.linearVelocity = velocity.normalized * SpeedOfBall;


    }


}
