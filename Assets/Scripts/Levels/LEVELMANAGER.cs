using Unity.VisualScripting;
using UnityEngine;

public class LEVELMANAGER : MonoBehaviour
{
    public int TileCount = 0;

    public void TileCountFunc()
    {
        TileCount -= 1;
        if (TileCount <= 0)
        {
            Debug.Log("Level Complete");
            // You can add code here to load the next level or show a level complete UI
        }
    }
}
