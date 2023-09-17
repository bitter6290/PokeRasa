using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class IndexedTile : Tile, IndexedObject
{
    public TileID tileID;

    public int Index => (int)tileID;

    public static IndexedTile Create(TileID id, string path, int x, int y)
    {
        IndexedTile indexedTile = CreateInstance<IndexedTile>();
        if (indexedTile == null) Debug.Log("I am null");
        indexedTile.sprite = Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(tileSize * x, tileSize * y, tileSize, tileSize), new Vector2(0.5F, 0.5F), tileSize * 2);
        indexedTile.tileID = id;
        return indexedTile;
    }
}