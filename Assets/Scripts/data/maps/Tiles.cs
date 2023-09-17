using System.Collections.Generic;
using UnityEngine.Tilemaps;
using static CollisionID;
using static AnimatedTiles;

public static class Tiles
{
    public static IndexedTile empty = IndexedTile.Create(TileID.NoTile, "primary_00", 0, 31);
    public static IndexedTile grassTile1 = IndexedTile.Create(TileID.GrassTile1, "primary_02", 2, 31);
    public static IndexedTile grassTile2 = IndexedTile.Create(TileID.GrassTile2, "primary_02", 3, 31);
    public static IndexedTile[] TileTable = new IndexedTile[]
    {
        empty,
        grassTile1,
        grassTile2,
        water0NW,
        water0NE,
        water0SW,
        water0SE,
    };

    //Collision tiles
    public static CollisionTile CollisionImpassable = CollisionTile.Create(Impassable, 0, 3);
    public static CollisionTile Collision1 = CollisionTile.Create(Level1, 1, 3);
    public static CollisionTile Collision2 = CollisionTile.Create(Level2, 2, 3);
    public static CollisionTile Collision3 = CollisionTile.Create(Level3, 3, 3);
    public static CollisionTile Collision4 = CollisionTile.Create(Level4, 0, 2);
    public static CollisionTile Collision5 = CollisionTile.Create(Level5, 1, 2);
    public static CollisionTile Collision6 = CollisionTile.Create(Level6, 2, 2);
    public static CollisionTile Collision7 = CollisionTile.Create(Level7, 3, 2);
    public static CollisionTile Collision8 = CollisionTile.Create(Level8, 0, 1);
    public static CollisionTile Collision9 = CollisionTile.Create(Level9, 1, 1);
    public static CollisionTile CollisionChange = CollisionTile.Create(Change, 2, 1);
    public static CollisionTile CollisionBridge = CollisionTile.Create(Bridge, 3, 1);
    public static CollisionTile CollisionSurf = CollisionTile.Create(Surf, 0, 0);
    public static CollisionTile[] CollisionTileTable = new CollisionTile[]
    {
        CollisionImpassable,
        Collision1,
        Collision2,
        Collision3,
        Collision4,
        Collision5,
        Collision6,
        Collision7,
        Collision8,
        Collision9,
        CollisionChange,
        CollisionBridge,
        CollisionSurf
    };
}