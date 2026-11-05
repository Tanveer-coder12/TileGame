using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    private void Start()
    {
        GameOverPanel.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject, 1f);
            GameOverPanel.SetActive(true);
        }
    }

}