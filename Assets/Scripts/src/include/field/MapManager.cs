using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    public MapID mapID;
    public Tilemap level1;
    public Tilemap level2;
    public Tilemap level3;

    public byte[,] collision;
    public byte[,] wildData;

    public MapData mapData => Map.MapTable[(int)mapID];

    public void ReadMap() =>
        MapReader.ReadForPlaytime(this);

    public void ReadAndReposition(Player p, int newXPos, int newYPos)
    {
        ReadMap();
        p.xPos = newXPos;
        p.yPos = newYPos;
    }

    public void ClearMap()
    {
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
    }
}