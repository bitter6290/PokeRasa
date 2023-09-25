using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class IndexedTile : Tile, IIndexedObject, IBehaviourObject
{
    public static Vector2 centerV2 = new(0.5F, 0.5F);
    public static Matrix4x4 flipXMatrix = new Matrix4x4 { m00 = -1, m11 = 1, m22 = 1, m33 = 1 };
    public static Matrix4x4 flipYMatrix = new Matrix4x4 { m00 = 1, m11 = -1, m22 = 1, m33 = 1 };

    public TileID tileID;
    public int Index => (int)tileID;
    public TileBehaviour tileBehaviour;
    public TileBehaviour Behaviour => tileBehaviour;

    public static IndexedTile Create(TileID id, string path, int x, int y, TileBehaviour behaviour = TileBehaviour.None, bool flipX = false, bool flipY = false)
    {
        IndexedTile indexedTile = CreateInstance<IndexedTile>();
        indexedTile.sprite = Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(tileSize * x, tileSize * y, tileSize, tileSize), centerV2, tileSize * 2);
        indexedTile.tileID = id;
        indexedTile.tileBehaviour = behaviour;
        if (flipX) indexedTile.transform *= flipXMatrix;
        if (flipY) indexedTile.transform *= flipYMatrix;
        return indexedTile;
    }
    public static IndexedTile Large(TileID id, string path, Rect rect, TileBehaviour behaviour = TileBehaviour.None, bool flipX = false, bool flipY = false, Vector2? pivot = null)
    {
        pivot ??= centerV2;
        IndexedTile indexedTile = CreateInstance<IndexedTile>();
        indexedTile.sprite = Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(tileSize * rect.x, tileSize * rect.y, tileSize * rect.width, tileSize * rect.height), (Vector2)pivot, tileSize * 2);
        indexedTile.tileID = id;
        indexedTile.tileBehaviour = behaviour;
        if (flipX) indexedTile.transform *= flipXMatrix;
        if (flipY) indexedTile.transform *= flipYMatrix;
        return indexedTile;
    }
}