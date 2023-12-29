using System.IO;
using UnityEngine;
using UnityEngine.Tilemaps;

public static class MapReader
{
    public static void ReadForPlaytimeV1(MapManager manager)
    {
        Tilemap level1 = manager.level1;
        Tilemap level2 = manager.level2;
        Tilemap level3 = manager.level3;
        string inString = manager.mapData.MapTiles.Replace("?", "AAAA").Replace("@", "AA");
        Debug.Log(inString.Length);
        byte[] data = System.Convert.FromBase64String(inString);
        manager.collision = new byte[manager.mapData.width, manager.mapData.height];
        manager.wildData = new byte[manager.mapData.width, manager.mapData.height];
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
        manager.borderingCollision = new();
        Tileset currentTiles = manager.mapData.tileset;
        for (int x = 0; x < manager.mapData.width; x++)
        {
            for (int y = 0; y < manager.mapData.height; y++)
            {
                int offset = (x * manager.mapData.height + y) * 26 + 2;
                level1.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset] + (data[offset + 1] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset + 2] + (data[offset + 3] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset + 4] + (data[offset + 5] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 6] + (data[offset + 7] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 8] + (data[offset + 9] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 10] + (data[offset + 11] * 256)]);
                level1.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 12] + (data[offset + 13] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 14] + (data[offset + 15] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 16] + (data[offset + 17] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 18] + (data[offset + 19] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 20] + (data[offset + 21] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 22] + (data[offset + 23] * 256)]);
                manager.collision[x, y] = data[offset + 24];
                manager.wildData[x, y] = data[offset + 25];
            }
        }
        if (manager.mapData.connection.Length != 0)
        {
            foreach (Connection i in manager.mapData.connection)
            {
                MapData connectedMap = i.map;
                string connectionString = connectedMap.MapTiles.Replace("?", "AAAA").Replace("@", "AA");
                byte[] connectionData = System.Convert.FromBase64String(connectionString);
                byte[,] connectingCollision = new byte[connectedMap.width, connectedMap.height];
                currentTiles = i.map.tileset;
                switch (i.direction)
                {
                    case Direction.N:
                        for (int x = 0; x < connectedMap.width; x++)
                        {
                            for (int y = 0; y < connectedMap.height; y++)
                            {
                                int offset = (x * connectedMap.height + y) * 26 + 2;
                                level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * manager.mapData.height)),
                                    currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                                connectingCollision[x, y] = connectionData[offset + 24];
                            }
                        }
                        break;
                    case Direction.S:
                        for (int x = 0; x < connectedMap.width; x++)
                        {
                            for (int y = 0; y < connectedMap.height; y++)
                            {
                                int offset = (x * connectedMap.height + y) * 26 + 2;
                                level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                                level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                                level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                                level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                    currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                                connectingCollision[x, y] = connectionData[offset + 24];
                            }
                        }
                        break;
                    case Direction.E:
                        for (int x = 0; x < connectedMap.width; x++)
                        {
                            for (int y = 0; y < connectedMap.height; y++)
                            {
                                int offset = (x * connectedMap.height + y) * 26 + 2;
                                level1.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x + (2 * manager.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                                connectingCollision[x, y] = connectionData[offset + 24];
                            }
                        }
                        break;
                    case Direction.W:
                        for (int x = 0; x < connectedMap.width; x++)
                        {
                            for (int y = 0; y < connectedMap.height; y++)
                            {
                                int offset = (x * connectedMap.height + y) * 26 + 2;
                                level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                    currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                                level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                                level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                                level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                    currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                                connectingCollision[x, y] = connectionData[offset + 24];
                            }
                        }
                        break;
                }
                manager.borderingCollision.Add(i.map, connectingCollision);
            }
        }
        Debug.Log("Loaded successfully");
    }
#if UNITY_EDITOR
    public static void RenderNeighborsForEditingV1(MapHelper mapHelper)
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        foreach (Connection i in mapHelper.mapData.connection)
        {
            MapData connectedMap = i.map;
            string connectionString = connectedMap.MapTiles.Replace("?", "AAAA").Replace("@", "AA");
            byte[] connectionData = System.Convert.FromBase64String(connectionString);
            Tileset currentTiles = i.map.tileset;
            switch (i.direction)
            {
                case Direction.N:
                    for (int x = 0; x < connectedMap.width; x++)
                    {
                        for (int y = 0; y < connectedMap.height; y++)
                        {
                            int offset = (x * connectedMap.height + y) * 26 + 2;
                            level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 + (2 * mapHelper.mapData.height)),
                                currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                        }
                    }
                    break;
                case Direction.S:
                    for (int x = 0; x < connectedMap.width; x++)
                    {
                        for (int y = 0; y < connectedMap.height; y++)
                        {
                            int offset = (x * connectedMap.height + y) * 26 + 2;
                            level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset), 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                            level1.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                            level2.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                            level3.SetTile(new Vector3Int(2 * (x + i.offset) + 1, 2 * y + 1 - (2 * connectedMap.height)),
                                currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                        }
                    }
                    break;
                case Direction.E:
                    for (int x = 0; x < connectedMap.width; x++)
                    {
                        for (int y = 0; y < connectedMap.height; y++)
                        {
                            int offset = (x * connectedMap.height + y) * 26 + 2;
                            level1.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x + (2 * mapHelper.mapData.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                        }
                    }
                    break;
                case Direction.W:
                    for (int x = 0; x < connectedMap.width; x++)
                    {
                        for (int y = 0; y < connectedMap.height; y++)
                        {
                            int offset = (x * connectedMap.height + y) * 26 + 2;
                            level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset] + (connectionData[offset + 1] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 2] + (connectionData[offset + 3] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 4] + (connectionData[offset + 5] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 6] + (connectionData[offset + 7] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 8] + (connectionData[offset + 9] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset)),
                                currentTiles.Tiles[connectionData[offset + 10] + (connectionData[offset + 11] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 12] + (connectionData[offset + 13] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 14] + (connectionData[offset + 15] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width), 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 16] + (connectionData[offset + 17] * 256)]);
                            level1.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 18] + (connectionData[offset + 19] * 256)]);
                            level2.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 20] + (connectionData[offset + 21] * 256)]);
                            level3.SetTile(new Vector3Int(2 * x - (2 * connectedMap.width) + 1, 2 * (y + i.offset) + 1),
                                currentTiles.Tiles[connectionData[offset + 22] + (connectionData[offset + 23] * 256)]);
                        }
                    }
                    break;
            }
        }
    }

    public static void ClearConnections(MapHelper mapHelper)
    {
        for (int x = mapHelper.level1.cellBounds.min.x; x < mapHelper.level1.cellBounds.max.x; x++)
        {
            for (int y = mapHelper.level1.cellBounds.min.y; y < mapHelper.level1.cellBounds.max.y; y++)
            {
                if (x >= 0 && x < mapHelper.mapData.width * 2 && y >= 0 && y < mapHelper.mapData.height * 2) continue;
                mapHelper.level1.SetTile(new Vector3Int(x, y, 0), null);
                mapHelper.level2.SetTile(new Vector3Int(x, y, 0), null);
                mapHelper.level3.SetTile(new Vector3Int(x, y, 0), null);
            }
        }
    }

    public static void ReadForEditingV1(MapHelper mapHelper)
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        Tilemap collision = mapHelper.collisionMap;
        Tilemap wildData = mapHelper.wildDataMap;
        string inString = mapHelper.mapData.MapTiles.Replace("?", "AAAA").Replace("@", "AA");
        Debug.Log(inString.Length);
        byte[] data = System.Convert.FromBase64String(inString);
        Tileset currentTiles = mapHelper.mapData.tileset;
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
        collision.ClearAllTiles();
        wildData.ClearAllTiles();
        for (int x = 0; x < mapHelper.mapData.width; x++)
        {
            for (int y = 0; y < mapHelper.mapData.height; y++)
            {
                int offset = (x * mapHelper.mapData.height + y) * 26 + 2;
                level1.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset] + (data[offset + 1] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset + 2] + (data[offset + 3] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.Tiles[data[offset + 4] + (data[offset + 5] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 6] + (data[offset + 7] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 8] + (data[offset + 9] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.Tiles[data[offset + 10] + (data[offset + 11] * 256)]);
                level1.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 12] + (data[offset + 13] * 256)]);
                level2.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 14] + (data[offset + 15] * 256)]);
                level3.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 16] + (data[offset + 17] * 256)]);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 18] + (data[offset + 19] * 256)]);
                level2.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 20] + (data[offset + 21] * 256)]);
                level3.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.Tiles[data[offset + 22] + (data[offset + 23] * 256)]);
                collision.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[data[offset + 24]]);
                wildData.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[data[offset + 25]]);

            }
        }
        RenderNeighborsForEditingV1(mapHelper);
        Debug.Log("Loaded successfully");
    }

    public static void CreateNewMapV1(MapHelper mapHelper)
    {
        Tilemap level1 = mapHelper.level1;
        Tilemap level2 = mapHelper.level2;
        Tilemap level3 = mapHelper.level3;
        Tilemap collision = mapHelper.collisionMap;
        Tilemap wildData = mapHelper.wildDataMap;
        Tileset currentTiles = mapHelper.mapData.tileset;
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
        collision.ClearAllTiles();
        wildData.ClearAllTiles();
        for (int x = 0; x < mapHelper.mapData.width; x++)
        {
            for (int y = 0; y < mapHelper.mapData.height; y++)
            {
                int offset = (x * mapHelper.mapData.height + y) * 26 + 2;
                level1.SetTile(new Vector3Int(2 * x, 2 * y),
                    currentTiles.defaultSW);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y),
                    currentTiles.defaultSE);
                level1.SetTile(new Vector3Int(2 * x, 2 * y + 1),
                    currentTiles.defaultNW);
                level1.SetTile(new Vector3Int(2 * x + 1, 2 * y + 1),
                    currentTiles.defaultNE);
                collision.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[(int)CollisionID.Level3]);
                wildData.SetTile(new Vector3Int(x, y),
                    Tiles.CollisionTileTable[(int)CollisionID.Impassable]);

            }
        }
        RenderNeighborsForEditingV1(mapHelper);
        Debug.Log("Created map successfully");
    }
#endif
}