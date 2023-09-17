using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class AnimatedIndexedTile : AnimatedTile, IndexedObject
{
    public TileID tileID;
    public int Index => (int)tileID;

    public static AnimatedIndexedTile Create(TileID id, Sprite[] sprites, float speed)
    {
        AnimatedIndexedTile tile = CreateInstance<AnimatedIndexedTile>();
        tile.m_AnimatedSprites = sprites;
        tile.tileID = id;
        tile.m_MaxSpeed = speed;
        tile.m_MinSpeed = speed;
        return tile;
    }
}