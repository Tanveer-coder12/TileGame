using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            Destroy(collision.gameObject);
        }
    }

}
