#if UNITY_EDITOR
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

    public bool Write(bool overrideMissing)
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        Tilemap collision = mapHelper.collisionMap;
        Tilemap wildData = mapHelper.wildDataMap;
        Tileset currentTiles = mapHelper.OpenMap.tileset;

        List<byte> data = new()
        {
            (byte)(version & 255),
            (byte)(version >> 8),
        };
        bool ok = true;
        int GetIndex(Tilemap map, Vector3Int location)
        {
            TileBase currentTile = map.GetTile(location);
            int index = currentTiles.Tiles.FindIndex(a => a == currentTile);
            if (index is -1)
            {
                index = 0;
                ok = false;
                Debug.Log("Unfamiliar tile at " + location + " on tilemap " + map);
                if (!mapHelper.missingTiles.Contains(currentTile))
                    mapHelper.missingTiles.Add(currentTile);
            }
            return index;
        }
        for (int x = 0; x < mapHelper.OpenMap.width; x++)
        {
            for (int y = 0; y < mapHelper.OpenMap.height; y++)
            {
                Vector3Int swTile = new(2 * x, 2 * y);
                ushort tile1SW = level1.HasTile(swTile)
                    ? (ushort)GetIndex(level1, swTile) : (ushort)0;
                ushort tile2SW = level2.HasTile(swTile)
                    ? (ushort)GetIndex(level2, swTile) : (ushort)0;
                ushort tile3SW = level3.HasTile(swTile)
                    ? (ushort)GetIndex(level3, swTile) : (ushort)0;
                Vector3Int seTile = swTile + Vector3Int.right;
                ushort tile1SE = level1.HasTile(seTile)
                    ? (ushort)GetIndex(level1, seTile) : (ushort)0;
                ushort tile2SE = level2.HasTile(seTile)
                    ? (ushort)GetIndex(level2, seTile) : (ushort)0;
                ushort tile3SE = level3.HasTile(seTile)
                    ? (ushort)GetIndex(level3, seTile) : (ushort)0;
                Vector3Int nwTile = swTile + Vector3Int.up;
                ushort tile1NW = level1.HasTile(nwTile)
                    ? (ushort)GetIndex(level1, nwTile) : (ushort)0;
                ushort tile2NW = level2.HasTile(nwTile)
                    ? (ushort)GetIndex(level2, nwTile) : (ushort)0;
                ushort tile3NW = level3.HasTile(nwTile)
                    ? (ushort)GetIndex(level3, nwTile) : (ushort)0;
                Vector3Int neTile = seTile + Vector3Int.up;
                ushort tile1NE = level1.HasTile(neTile)
                    ? (ushort)GetIndex(level1, neTile) : (ushort)0;
                ushort tile2NE = level2.HasTile(neTile)
                    ? (ushort)GetIndex(level2, neTile) : (ushort)0;
                ushort tile3NE = level3.HasTile(neTile)
                    ? (ushort)GetIndex(level3, neTile) : (ushort)0;
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
        if (ok || overrideMissing)
        {
            string outString = Convert.ToBase64String(data.ToArray()).Replace("AA", "@").Replace("@@", "?").Replace("?@A", "&").Replace("?@", "^");
            mapHelper.OpenMap.WriteMapTiles(outString);
            EditorUtility.SetDirty(mapHelper.OpenMap);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        Debug.Log(ok ? "Saved successfully" : overrideMissing ?
            "Some tiles are missing, saved anyway" : "Missing tiles, did not save");
        return ok;
    }
}
#endif