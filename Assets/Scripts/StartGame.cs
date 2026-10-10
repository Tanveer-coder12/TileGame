using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

  
    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("Level1");   
    }
}
