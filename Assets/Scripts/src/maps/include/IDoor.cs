using UnityEngine;
public interface IDoor
{
    public Texture2D AnimFrames { get; }
    public float FrameTime { get; }
    public Vector2Int Dimensions { get; }
}
