using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Tile;
    float newYpos = 0;
    float newXpos = 0;
    public float padding;
    void Start()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize - padding;
        float width = height * cam.aspect - padding;

        //Debug.Log("Camera Width: " + width + ", Camera Height: " + height);
        SpriteRenderer sr = Tile.GetComponent<SpriteRenderer>();

        float tileWidth = sr.bounds.size.x;
        float tileHeight = sr.bounds.size.y;

        int TileCount = Mathf.FloorToInt(width / tileWidth);
        for (int i = 0; i <= TileCount; i++)
        {
            for (int j = 0; j <= TileCount; j++)
            {
                Vector3 tilePosition = new Vector3(-(width / 2) + newXpos, (height / 2) + newYpos, 0);
                newXpos += tileWidth;

                Instantiate(Tile, tilePosition, Quaternion.identity);
            }
            newYpos -= tileHeight;
            newXpos = 0;

        }

    }
}
