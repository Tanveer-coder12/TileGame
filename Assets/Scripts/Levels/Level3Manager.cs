using UnityEngine;

public class Level3Manager : MonoBehaviour
{
    public GameObject Tile;
    public Transform TileTransPos;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    float n = 0;

    public SpriteRenderer sp;
    void Start()
    {
        sp = Tile.GetComponent<SpriteRenderer>();
        for (int i = 8; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                GameObject Tiles = Instantiate(Tile, new Vector3(TileTransPos.position.x + newXpos, TileTransPos.position.y + newYpos, TileTransPos.position.z), Quaternion.identity);
                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));
                newXpos += sp.bounds.size.x;
            }
            newYpos -= sp.bounds.size.y;
            newXpos = 0;
            n += sp.bounds.size.x / 2;
            newXpos = n;

        }

    }
}
