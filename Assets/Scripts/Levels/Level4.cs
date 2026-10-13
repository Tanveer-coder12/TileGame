using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : LEVELMANAGER
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    public SpriteRenderer sp;

   
    float n = 0;

    public void Start()
    {
        audioSource.Play();
        LevelCompletePanel.SetActive(false);
        sp = Tile.GetComponent<SpriteRenderer>();
        for (int i = 8; i > 0; i--)//8
        {
            for (int j = i; j > 0; j--)//8
            {
                TileCount += 1;//here we get total 36 tiles

                GameObject Tiles = Instantiate(Tile, new Vector3(TileTransPos.position.x + newXpos, TileTransPos.position.y + newYpos, TileTransPos.position.z), Quaternion.identity);

                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));

                newXpos += sp.bounds.size.x;
            }
            newXpos = 0;

            n += sp.bounds.size.x / 2f;

            newXpos = n;

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
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1f;
    }

}
