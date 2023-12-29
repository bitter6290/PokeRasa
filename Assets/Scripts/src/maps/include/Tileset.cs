using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Tileset", menuName = "ScriptableObjects/Tileset", order = 1)]
public class Tileset : ScriptableObject
{
    public string tilePath;
    public List<TileBase> Tiles;
    public TileBase defaultSW;
    public TileBase defaultSE;
    public TileBase defaultNW;
    public TileBase defaultNE;
}

