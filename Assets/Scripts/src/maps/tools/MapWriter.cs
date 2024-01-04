﻿#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class MapWriter
{
    public ushort version = 1;
    public MapHelper mapHelper;

    public MapWriter(MapHelper mapManager)
    {
        mapHelper = mapManager;
    }

    public void Write()
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        Tilemap collision = mapHelper.collisionMap;
        Tilemap wildData = mapHelper.wildDataMap;
        Tileset currentTiles = mapHelper.map.tileset;
        List<byte> data = new()
        {
            (byte)(version & 255),
            (byte)(version >> 8),
        };
        for (int x = 0; x < mapHelper.map.width; x++)
        {
            for (int y = 0; y < mapHelper.map.height; y++)
            {
                ushort tile1SW = level1.HasTile(new Vector3Int(2 * x, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level1.GetTile(new Vector3Int(2 * x, 2 * y))) : (ushort)0;
                ushort tile2SW = level2.HasTile(new Vector3Int(2 * x, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level2.GetTile(new Vector3Int(2 * x, 2 * y))) : (ushort)0;
                ushort tile3SW = level3.HasTile(new Vector3Int(2 * x, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level3.GetTile(new Vector3Int(2 * x, 2 * y))) : (ushort)0;
                ushort tile1SE = level1.HasTile(new Vector3Int(2 * x + 1, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level1.GetTile(new Vector3Int(2 * x + 1, 2 * y))) : (ushort)0;
                ushort tile2SE = level2.HasTile(new Vector3Int(2 * x + 1, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level2.GetTile(new Vector3Int(2 * x + 1, 2 * y))) : (ushort)0;
                ushort tile3SE = level3.HasTile(new Vector3Int(2 * x + 1, 2 * y))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level3.GetTile(new Vector3Int(2 * x + 1, 2 * y))) : (ushort)0;
                ushort tile1NW = level1.HasTile(new Vector3Int(2 * x, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level1.GetTile(new Vector3Int(2 * x, 2 * y + 1))) : (ushort)0;
                ushort tile2NW = level2.HasTile(new Vector3Int(2 * x, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level2.GetTile(new Vector3Int(2 * x, 2 * y + 1))) : (ushort)0;
                ushort tile3NW = level3.HasTile(new Vector3Int(2 * x, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level3.GetTile(new Vector3Int(2 * x, 2 * y + 1))) : (ushort)0;
                ushort tile1NE = level1.HasTile(new Vector3Int(2 * x + 1, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level1.GetTile(new Vector3Int(2 * x + 1, 2 * y + 1))) : (ushort)0;
                ushort tile2NE = level2.HasTile(new Vector3Int(2 * x + 1, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level2.GetTile(new Vector3Int(2 * x + 1, 2 * y + 1))) : (ushort)0;
                ushort tile3NE = level3.HasTile(new Vector3Int(2 * x + 1, 2 * y + 1))
                    ? (ushort)currentTiles.Tiles.FindIndex(a => a == level3.GetTile(new Vector3Int(2 * x + 1, 2 * y + 1))) : (ushort)0;
                byte collisionByte = collision.HasTile(new Vector3Int(x, y))
                    ? (byte)((CollisionTile)collision.GetTile(new Vector3Int(x, y))).collisionID : (byte)0;
                byte wildDataByte = wildData.HasTile(new Vector3Int(x, y))
                    ? (byte)((CollisionTile)wildData.GetTile(new Vector3Int(x, y))).collisionID : (byte)0;
                List<byte> tileData = new() {
                    (byte)(tile1SW & 255), (byte)(tile1SW >> 16), (byte)(tile2SW & 255), (byte)(tile2SW >> 16), (byte)(tile3SW & 255), (byte)(tile3SW >> 16),
                    (byte)(tile1SE & 255), (byte)(tile1SE >> 16), (byte)(tile2SE & 255), (byte)(tile2SE >> 16), (byte)(tile3SE & 255), (byte)(tile3SE >> 16),
                    (byte)(tile1NW & 255), (byte)(tile1NW >> 16), (byte)(tile2NW & 255), (byte)(tile2NW >> 16), (byte)(tile3NW & 255), (byte)(tile3NW >> 16),
                    (byte)(tile1NE & 255), (byte)(tile1NE >> 16), (byte)(tile2NE & 255), (byte)(tile2NE >> 16), (byte)(tile3NE & 255), (byte)(tile3NE >> 16),
                    collisionByte, wildDataByte
                };
                if (tileData.Count != 26) Debug.Log(tileData.Count);
                data.AddRange(tileData);
            }
        }
        string outString = System.Convert.ToBase64String(data.ToArray()).Replace("AA", "@").Replace("@@", "?");
        mapHelper.map.WriteMapTiles(outString);
        AssetDatabase.SaveAssets();
        Debug.Log("Saved successfully");
        AssetDatabase.Refresh();
    }
}
#endif