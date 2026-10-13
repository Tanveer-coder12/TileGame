using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{

    public AudioClip ad;
    private void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = ad;
        audioSource.Play();         
    }
    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("Level1");
    }
}
