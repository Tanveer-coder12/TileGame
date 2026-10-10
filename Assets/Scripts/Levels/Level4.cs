using UnityEngine;

public class Level4 : LEVELMANAGER
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    public SpriteRenderer sp;

    public GameObject GameOverPanel;
    float n = 0;

    void Start()
    {

        GameOverPanel.SetActive(false);

        sp = Tile.GetComponent<SpriteRenderer>();

        for (int i = 3; i > 0; i--)//8
        {
            for (int j = 8; j > 0; j--)//8
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



}
