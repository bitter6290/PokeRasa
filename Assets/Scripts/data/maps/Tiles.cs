using System.Collections.Generic;
using UnityEngine.Tilemaps;
using static CollisionID;
using static AnimatedTiles;
using id = TileID;

public static class Tiles
{
    public static IndexedTile empty = IndexedTile.Create(id.noTile, "primary_00", 0, 31);
    //Flat grass
    public static IndexedTile grassTile1 = IndexedTile.Create(id.grassTile1, "primary_02", 2, 31);
    public static IndexedTile grassTile2 = IndexedTile.Create(id.grassTile2, "primary_02", 3, 31);
    //Animated water tiles would be here
    //Mountain/rock surface tiles
    public static IndexedTile mountainNWNE = IndexedTile.Create(id.mountainNWNE, "primary_03", 1, 27);
    public static IndexedTile mountainNWSW = IndexedTile.Create(id.mountainNWSW, "primary_03", 0, 26);
    public static IndexedTile mountainNWSE = IndexedTile.Create(id.mountainNWSE, "primary_03", 1, 26);
    public static IndexedTile mountainNCNW = IndexedTile.Create(id.mountainNCNW, "primary_03", 2, 27);
    public static IndexedTile mountainNCNE = IndexedTile.Create(id.mountainNCNE, "primary_03", 3, 27);
    public static IndexedTile mountainNCSW = IndexedTile.Create(id.mountainNCSW, "primary_03", 2, 26);
    public static IndexedTile mountainNCSE = IndexedTile.Create(id.mountainNCSE, "primary_03", 3, 26);
    public static IndexedTile mountainNENW = IndexedTile.Create(id.mountainNENW, "primary_03", 4, 27);
    public static IndexedTile mountainNESW = IndexedTile.Create(id.mountainNESW, "primary_03", 4, 26);
    public static IndexedTile mountainNESE = IndexedTile.Create(id.mountainNESE, "primary_03", 5, 26);
    public static IndexedTile mountainCWNW = IndexedTile.Create(id.mountainCWNW, "primary_03", 0, 25);
    public static IndexedTile mountainCWNE = IndexedTile.Create(id.mountainCWNE, "primary_03", 1, 25);
    public static IndexedTile mountainCWSW = IndexedTile.Create(id.mountainCWSW, "primary_03", 0, 24);
    public static IndexedTile mountainCWSE = IndexedTile.Create(id.mountainCWSE, "primary_03", 1, 24);
    public static IndexedTile mountainCCNW = IndexedTile.Create(id.mountainCCNW, "primary_03", 2, 25);
    public static IndexedTile mountainCCNE = IndexedTile.Create(id.mountainCCNE, "primary_03", 3, 25);
    public static IndexedTile mountainCCSW = IndexedTile.Create(id.mountainCCSW, "primary_03", 2, 24);
    public static IndexedTile mountainCCSE = IndexedTile.Create(id.mountainCCSE, "primary_03", 3, 24);
    public static IndexedTile mountainCENW = IndexedTile.Create(id.mountainCENW, "primary_03", 4, 25);
    public static IndexedTile mountainCENE = IndexedTile.Create(id.mountainCENE, "primary_03", 5, 25);
    public static IndexedTile mountainCESW = IndexedTile.Create(id.mountainCESW, "primary_03", 4, 24);
    public static IndexedTile mountainCESE = IndexedTile.Create(id.mountainCESE, "primary_03", 5, 24);
    public static IndexedTile mountainSWNW = IndexedTile.Create(id.mountainSWNW, "primary_03", 0, 23);
    public static IndexedTile mountainSWNE = IndexedTile.Create(id.mountainSWNE, "primary_03", 1, 23);
    public static IndexedTile mountainSWSW = IndexedTile.Create(id.mountainSWSW, "primary_03", 0, 22);
    public static IndexedTile mountainSWSE = IndexedTile.Create(id.mountainSWSE, "primary_03", 1, 22);
    public static IndexedTile mountainSCNW = IndexedTile.Create(id.mountainSCNW, "primary_03", 2, 23);
    public static IndexedTile mountainSCNE = IndexedTile.Create(id.mountainSCNE, "primary_03", 3, 23);
    public static IndexedTile mountainSCSW = IndexedTile.Create(id.mountainSCSW, "primary_03", 2, 22);
    public static IndexedTile mountainSCSE = IndexedTile.Create(id.mountainSCSE, "primary_03", 3, 22);
    public static IndexedTile mountainSENW = IndexedTile.Create(id.mountainSENW, "primary_03", 4, 23);
    public static IndexedTile mountainSENE = IndexedTile.Create(id.mountainSENE, "primary_03", 5, 23);
    public static IndexedTile mountainSESW = IndexedTile.Create(id.mountainSESW, "primary_03", 4, 22);
    public static IndexedTile mountainSESE = IndexedTile.Create(id.mountainSESE, "primary_03", 5, 22);

    public static TileBase[] TileTable = new TileBase[]
    {
        empty,
        grassTile1,
        grassTile2,
        water0NW,
        water0NE,
        water0SW,
        water0SE,
        mountainNWNE,
        mountainNWSW,
        mountainNWSE,
        mountainNCNW,
        mountainNCNE,
        mountainNCSW,
        mountainNCSE,
        mountainNENW,
        mountainNESW,
        mountainNESE,
        mountainCWNW,
        mountainCWNE,
        mountainCWSW,
        mountainCWSE,
        mountainCCNW,
        mountainCCNE,
        mountainCCSW,
        mountainCCSE,
        mountainCENW,
        mountainCENE,
        mountainCESW,
        mountainCESE,
        mountainSWNW,
        mountainSWNE,
        mountainSWSW,
        mountainSWSE,
        mountainSCNW,
        mountainSCNE,
        mountainSCSW,
        mountainSCSE,
        mountainSENW,
        mountainSENE,
        mountainSESW,
        mountainSESE,
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