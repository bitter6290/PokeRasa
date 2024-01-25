using System;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace Metatiles
{
    [Serializable]
    public struct MapTile
    {
        public TileBase level1;
        public TileBase level2;
        public TileBase level3;
    }
    [Serializable]
    public struct FullTile
    {
        public MapTile nwTile;
        public MapTile neTile;
        public MapTile swTile;
        public MapTile seTile;
        public MapTile GetTile(Vector2Int pos) => ((pos.x + 200) % 2, (pos.y + 200) % 2) switch
        {
            (0, 0) => swTile,
            (0, 1) => nwTile,
            (1, 0) => seTile,
            _ => neTile
        };
    }
}