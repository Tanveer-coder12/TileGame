using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject TilesPrefab;
    public Transform TileTranformPos;
    public int TileTranformCount = 5;
    public Ball balls;

    public SpriteRenderer sr;


    void Start()
    {
        sr = TilesPrefab.GetComponent<SpriteRenderer>();
        float TilesizeX = sr.bounds.size.x;
        float TilesizeY = sr.bounds.size.y;
        float nextrow = TileTranformPos.position.y;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Vector3 position = new Vector3(TileTranformPos.position.x + (TilesizeX * j), nextrow, TileTranformPos.position.z);
                GameObject Tiles = Instantiate(TilesPrefab, position, Quaternion.identity);
                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));
                balls.GetComponent<Ball>().number.Add(balls.n);

            }
            nextrow -= TilesizeY;
        }
    }
}
