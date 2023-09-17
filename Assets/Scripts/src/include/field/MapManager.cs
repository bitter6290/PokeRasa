using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    public MapID mapID;
    public Tilemap level1;
    public Tilemap level2;
    public Tilemap level3;

    public int[,] collision;
    public int[,] wildData;

    public MapData mapData => Map.MapTable[(int)mapID];
}