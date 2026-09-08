using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float TilesPrefab;
    public List<Transform> TileTranformPos = new List<Transform>();

    void Start()
    {
        for (int i = 0; i < TileTranformPos.Count; i++)
        {

            // Do something
        }
    }
}
