using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject GameOverPanel;

    public static UIManager Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        GameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
