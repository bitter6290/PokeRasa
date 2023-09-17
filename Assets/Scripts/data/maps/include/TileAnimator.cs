using UnityEngine;
using UnityEngine.Tilemaps;

public class TileAnimator : MonoBehaviour
{
    public AnimatedIndexedTile tile;
    private int frameNumber = 0;

    private float lastTime;

    public TileAnimator(AnimatedIndexedTile tile)
    {
        this.tile = tile;
    }

    public void Update()
    {
        if(Time.time > lastTime + tile.secondsPerFrame)
        {
            frameNumber = (frameNumber + 1) % tile.sprites.Length;
            tile.sprite = tile.sprites[frameNumber];
            lastTime = Time.time;
        }
    }
}