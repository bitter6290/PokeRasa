using UnityEngine;

[CreateAssetMenu(fileName = "DoorTile", menuName = "ScriptableObjects/DoorTile", order = 1)]
public class DoorTile : UnityEngine.Tilemaps.Tile, IDoor
{
    public float frameTime;
    public float FrameTime => frameTime;

    public Texture2D animFrames;
    public Texture2D AnimFrames => animFrames;

    public Vector2Int dimensions;
    public Vector2Int Dimensions => dimensions;

    public AudioClip sound;
    public AudioClip Sound => sound;
}

