using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public struct TileData
{
    public Tile tile;
    public TileID tileID;
    public static TileData StaticTileData(TileID id, string path, int x, int y)
    {
        Sprite sprite = sprite = Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(tileSize * x, tileSize * y, tileSize, tileSize), new Vector2(0.5F, 0.5F), tileSize * 2);
        Tile tile = ScriptableObject.CreateInstance<Tile>();
        tile.sprite = sprite;
        return new TileData
        {
            tile = tile,
            tileID = id,
        };
    }
    public static TileData EmptyTileData => new()
    {
        tile = ScriptableObject.CreateInstance<Tile>(),
        tileID = TileID.NoTile,
    };
}