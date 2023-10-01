using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Tileset", menuName = "ScriptableObjects/Tileset", order = 1)]
public class Tileset : ScriptableObject
{
    public string tilePath;
    public List<Tile> Tiles;
    public Tile[,] defaultTiles = new Tile[2,2];
}

