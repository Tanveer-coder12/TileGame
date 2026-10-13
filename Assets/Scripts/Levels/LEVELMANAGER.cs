using Unity.VisualScripting;
using UnityEngine;

public class LEVELMANAGER : MonoBehaviour
{
    public int TileCount = 0;
    public GameObject LevelCompletePanel;

    public AudioSource audioSource;

    public void TileCountFunc()
    {
        TileCount -= 1;
        if (TileCount <= 0)
        {
            LevelCompletePanel.SetActive(true);
        }
    }
}
