using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public List<Sprite> TileSprites;
    public SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }
    public void initTile(int number)
    {
        if (number == 0)
        {
            sr.sprite = TileSprites[0];

        }
        if (number == 1)
        {
            sr.sprite = TileSprites[1];

        }
        if (number == 2)
        {
            sr.sprite = TileSprites[2];
        }
        if (number == 3)
        {
            sr.sprite = TileSprites[3];

        }
        if (number == 4)
        {
            sr.sprite = TileSprites[4];
        }
    }
}

