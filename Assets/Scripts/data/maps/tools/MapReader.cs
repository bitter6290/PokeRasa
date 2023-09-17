using System.IO;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapReader
{
    public void ReadForPlaytime(MapManager manager)
    {

    }
    public void ReadForEditing(MapHelper mapHelper)
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        Tilemap collision = mapHelper.collisionMap;
        Tilemap wildData = mapHelper.wildDataMap;
        string path = Application.dataPath + "/Resources/Maps/" + mapHelper.mapData.path + ".pokemap";
        StreamReader reader = File.OpenText(path);
        string inString = reader.ReadToEnd().Replace("?","AAAA").Replace("@","AA");
        Debug.Log(inString.Length);
        byte[] data = System.Convert.FromBase64String(inString);
        for (int x = 0; x < mapHelper.mapData.width; x++)
        {
            for (int y = 0; y < mapHelper.mapData.height; y++)
            {
                int offset = (x * mapHelper.mapData.height + y) * 26 + 2;
                level1.SetTile(new Vector3Int(2 * x, 2 * y),
                    Tiles.TileTable[data[offset] + (data[offset + 1] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y),
                    Tiles.TileTable[data[offset + 2] + (data[offset + 3] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y),
                    Tiles.TileTable[data[offset + 4] + (data[offset + 5] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    Tiles.TileTable[data[offset + 6] + (data[offset + 7] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    Tiles.TileTable[data[offset + 8] + (data[offset + 9] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    Tiles.TileTable[data[offset + 10] + (data[offset + 11] * 256)]);
                level1.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    Tiles.TileTable[data[offset + 12] + (data[offset + 13] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    Tiles.TileTable[data[offset + 14] + (data[offset + 15] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    Tiles.TileTable[data[offset + 16] + (data[offset + 17] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    Tiles.TileTable[data[offset + 18] + (data[offset + 19] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    Tiles.TileTable[data[offset + 20] + (data[offset + 21] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    Tiles.TileTable[data[offset + 22] + (data[offset + 23] * 256)]);
                collision.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[data[offset + 24]]);
                wildData.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[data[offset + 25]]);

            }
        }
        Debug.Log("Loaded successfully");
    }
}