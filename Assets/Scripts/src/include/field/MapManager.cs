using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
#if UNITY_EDITOR
    [System.NonSerialized]
#endif
    public MapData map;
    public Tilemap level1;
    public Tilemap level2;
    public Tilemap level3;

    public byte[,] collision;
    public byte[,] wildData;

    public Dictionary<MapData, byte[,]> borderingCollision;


    public void ReadMap() =>
        MapReader.ReadForPlaytimeV1(this);

    public void ReadAndReposition(Player p, Vector2Int newPos)
    {
        ReadMap();
        p.pos = newPos;
    }

    public void ClearMap()
    {
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
    }
}