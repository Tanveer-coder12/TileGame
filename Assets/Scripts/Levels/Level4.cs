using UnityEngine;

public class Level4 : MonoBehaviour
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;

    public SpriteRenderer sp;
    void Start()
    {
        sp = Tile.GetComponent<SpriteRenderer>();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject Tiles = Instantiate(Tile, new Vector3(TileTransPos.position.x + newXpos, TileTransPos.position.y + newYpos, TileTransPos.position.z), Quaternion.identity);
                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));
                newXpos += sp.bounds.size.x;
            }
            newXpos = 0;
            newYpos -= sp.bounds.size.y;
        }

    }
}
