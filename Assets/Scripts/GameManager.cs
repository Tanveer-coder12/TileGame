using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject TilesPrefab;
    //public Transform TileTranformPos;
    public int TileTranformCount = 5;
    public Ball balls;

    public SpriteRenderer sr;

    float nextrow;
    public float Padding;
    void Start()
    {
        sr = TilesPrefab.GetComponent<SpriteRenderer>();
        float TilesizeX = sr.bounds.size.x;
        float TilesizeY = sr.bounds.size.y;

        Vector2 screensize = Camera.main.ScreenToWorldPoint(new Vector2(UnityEngine.Screen.width, UnityEngine.Screen.height));

        float ScreenSizeX = -screensize.x;
        float ScreenSizeY = screensize.y;
        // float nextrow = ScreenSizeY;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject Tiles = Instantiate(TilesPrefab, new Vector3(ScreenSizeX + TilesizeX + j, ScreenSizeY + nextrow, 0), Quaternion.identity);

                Tiles.GetComponent<Tile>().initTile(Random.Range(0, 5));


            }

            nextrow -= TilesizeY;
        }
    }
}
