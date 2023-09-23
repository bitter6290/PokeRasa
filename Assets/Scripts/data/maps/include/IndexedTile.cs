using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class IndexedTile : Tile, IIndexedObject, IBehaviourObject
{
    public static Matrix4x4 flipXMatrix = new Matrix4x4 { m00 = -1, m11 = 1, m22 = 1, m33 = 1 };
    public static Matrix4x4 flipYMatrix = new Matrix4x4 { m00 = 1, m11 = -1, m22 = 1, m33 = 1 };

    public TileID tileID;
    public int Index => (int)tileID;
    public TileBehaviour tileBehaviour;
    public TileBehaviour Behaviour => tileBehaviour;

    public static IndexedTile Create(TileID id, string path, int x, int y, TileBehaviour behaviour = TileBehaviour.None, bool flipX = false, bool flipY = false)
    {
        IndexedTile indexedTile = CreateInstance<IndexedTile>();
        if (indexedTile == null) Debug.Log("I am null");
        indexedTile.sprite = Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(tileSize * x, tileSize * y, tileSize, tileSize), new Vector2(0.5F, 0.5F), tileSize * 2);
        indexedTile.tileID = id;
        indexedTile.tileBehaviour = behaviour;
        if (flipX) indexedTile.transform *= flipXMatrix;
        if (flipY) indexedTile.transform *= flipYMatrix;
        return indexedTile;
    }
}