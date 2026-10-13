using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : LEVELMANAGER
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    public SpriteRenderer sp;


    float n = 0;

    void Start()
    {

        audioSource.Play();
        LevelCompletePanel.SetActive(false);
        sp = Tile.GetComponent<SpriteRenderer>();
        for (int i = 0; i <8; i++)//8
        {
            for (int j = 0; j <=i; j++)//8
            {
                TileCount += 1;//here we get total 36 tiles

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
        SceneManager.LoadScene("Level4");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }



}
