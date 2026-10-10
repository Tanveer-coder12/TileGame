using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : LEVELMANAGER
{
  
       

    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    public SpriteRenderer sp;
   
    void Start()
    {
        LevelCompletePanel.SetActive(false);
        sp = Tile.GetComponent<SpriteRenderer>();
        for (int i = 2; i > 0; i--)//8
        {
            for (int j = 3; j > 0; j--)//8
            {
               TileCount += 1;//here we get total 36 tiles
                GameObject Tiles = Instantiate(Tile, new Vector3(TileTransPos.position.x + newXpos, TileTransPos.position.y + newYpos, TileTransPos.position.z), Quaternion.identity);

                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));

                newXpos += sp.bounds.size.x;
            }
            newXpos = 0;
            newYpos -= 1;
        }
       
    }
    
   
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Exit()
    {
        Application.Quit();
    }
   
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    

    }

