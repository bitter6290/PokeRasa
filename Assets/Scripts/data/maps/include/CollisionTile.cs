using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "CollisionTile", menuName = "ScriptableObjects/CollisionTile", order = 1)]
public class CollisionTile : Tile
{
    public CollisionID collisionID;

    public static CollisionTile Create(CollisionID id, int x, int y)
    {
        CollisionTile collisionTile = ScriptableObject.CreateInstance<CollisionTile>();
        collisionTile.sprite = Sprite.Create(
            Resources.Load<Texture2D>("Tilesets/Collision"), new Rect(
                TileConfig.tileSize * 2 * x, TileConfig.tileSize * 2 * y,
                TileConfig.tileSize * 2, TileConfig.tileSize * 2
                ), new Vector2(0.5F, 0.5F), TileConfig.tileSize * 2);
        collisionTile.collisionID = id;
        return collisionTile;
    }
}