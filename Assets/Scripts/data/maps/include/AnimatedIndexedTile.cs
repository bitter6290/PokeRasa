using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class AnimatedIndexedTile : IndexedTile
{
    public Sprite[] sprites;
    public float secondsPerFrame;
    public static AnimatedIndexedTile Create(TileID id, Sprite[] sprites, float secondsPerFrame)
    {
        AnimatedIndexedTile tile = CreateInstance<AnimatedIndexedTile>();
        tile.gameObject = new();
        TileAnimator animator = tile.gameObject.AddComponent<TileAnimator>();
        animator.tile = tile;
        tile.sprites = sprites;
        tile.index = id;
        tile.secondsPerFrame = secondsPerFrame;
        tile.sprite = sprites[0];
        return tile;
    }
}