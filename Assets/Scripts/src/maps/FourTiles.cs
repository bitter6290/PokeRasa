using UnityEngine;
namespace Metatiles
{
    [CreateAssetMenu(fileName = "NewFourTiles.asset",menuName = "ScriptableObjects/FourTiles")]
    public class FourTiles : ScriptableObject
    {
        public FullTile nwTile;
        public FullTile neTile;
        public FullTile swTile;
        public FullTile seTile;
        public MapTile GetTile(Vector2Int pos) => (((pos.x + 200) / 2 % 2, (pos.y + 200) / 2 % 2) switch
        {
            (0, 0) => swTile,
            (0, 1) => nwTile,
            (1, 0) => seTile,
            _ => neTile //Satisfy the compiler
        }).GetTile(pos);
    }
}