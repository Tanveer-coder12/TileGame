using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : LEVELMANAGER
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    public SpriteRenderer sp;


   public void Start()
    {

        LevelCompletePanel.SetActive(false);
        sp = Tile.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                TileCount += 1;
                GameObject Tiles = Instantiate(Tile, new Vector3(TileTransPos.position.x + newXpos, TileTransPos.position.y + newYpos, TileTransPos.position.z), Quaternion.identity);
                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));
                newXpos += sp.bounds.size.x;
            }
            newXpos = 0;
            newYpos -= sp.bounds.size.y;
        }


    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1f;
    }
}





