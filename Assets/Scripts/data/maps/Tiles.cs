using System.Collections.Generic;
using UnityEngine.Tilemaps;
using static CollisionID;
using static AnimatedTiles;
using id = TileID;

public static class Tiles
{
    public static IndexedTile noTile = IndexedTile.Create(id.noTile, "primary_00", 0, 31);
    //Flat grass
    public static IndexedTile grass1 = IndexedTile.Create(id.grass1, "primary_02", 2, 31);
    public static IndexedTile grass2 = IndexedTile.Create(id.grass2, "primary_02", 3, 31);
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
    //Small tree
    public static IndexedTile smallTree0L = IndexedTile.Create(id.smallTree0L, "primary_02", 6, 28);
    public static IndexedTile smallTree0R = IndexedTile.Create(id.smallTree0R, "primary_02", 6, 28, flipX: true);
    public static IndexedTile smallTree1L = IndexedTile.Create(id.smallTree1L, "primary_02", 6, 29);
    public static IndexedTile smallTree1R = IndexedTile.Create(id.smallTree1R, "primary_02", 6, 29, flipX: true);
    public static IndexedTile smallTree2L = IndexedTile.Create(id.smallTree2L, "primary_02", 6, 30);
    public static IndexedTile smallTree2R = IndexedTile.Create(id.smallTree2R, "primary_02", 6, 30, flipX: true);
    public static IndexedTile smallTree3L = IndexedTile.Create(id.smallTree3L, "primary_02", 6, 31);
    public static IndexedTile smallTree3R = IndexedTile.Create(id.smallTree3R, "primary_02", 7, 31);
    //Grass edges (ledges)
    public static IndexedTile grassEdgeNWNW = IndexedTile.Create(id.grassEdgeNWNW, "primary_03", 12, 25);
    public static IndexedTile grassEdgeNWNE = IndexedTile.Create(id.grassEdgeNWNE, "primary_03", 13, 25);
    public static IndexedTile grassEdgeNWSW = IndexedTile.Create(id.grassEdgeNWSW, "primary_03", 12, 24);
    public static IndexedTile grassEdgeSWNW = IndexedTile.Create(id.grassEdgeSWNW, "primary_03", 12, 23);
    public static IndexedTile grassEdgeSWSW = IndexedTile.Create(id.grassEdgeSWSW, "primary_03", 12, 22);
    public static IndexedTile grassEdgeNENW = IndexedTile.Create(id.grassEdgeNENW, "primary_03", 15, 25);
    public static IndexedTile grassEdgeNENE = IndexedTile.Create(id.grassEdgeNENE, "primary_03", 14, 25);
    public static IndexedTile grassEdgeNESE = IndexedTile.Create(id.grassEdgeNESE, "primary_03", 15, 24);
    public static IndexedTile grassEdgeSENE = IndexedTile.Create(id.grassEdgeSENE, "primary_03", 15, 23);
    public static IndexedTile grassEdgeSESE = IndexedTile.Create(id.grassEdgeSESE, "primary_03", 15, 22);
    public static IndexedTile grassTopEdgeL = IndexedTile.Create(id.grassTopEdgeL, "primary_03", 14, 21);
    public static IndexedTile grassTopEdgeR = IndexedTile.Create(id.grassTopEdgeR, "primary_03", 15, 21);
    public static IndexedTile grassTopCornerLL = IndexedTile.Create(id.grassTopCornerLL, "primary_03", 0, 28);
    public static IndexedTile grassTopCornerLR = IndexedTile.Create(id.grassTopCornerLR, "primary_03", 1, 28);
    public static IndexedTile grassTopCornerRL = IndexedTile.Create(id.grassTopCornerRL, "primary_03", 2, 28);
    public static IndexedTile grassTopCornerRR = IndexedTile.Create(id.grassTopCornerRR, "primary_03", 3, 28);
    //Large trees
    public static IndexedTile largeTree0A = IndexedTile.Create(id.largeTree0A, "primary_02", 8, 28);
    public static IndexedTile largeTree0B = IndexedTile.Create(id.largeTree0B, "primary_02", 9, 28);
    public static IndexedTile largeTree0C = IndexedTile.Create(id.largeTree0C, "primary_02", 9, 28, flipX: true);
    public static IndexedTile largeTree0D = IndexedTile.Create(id.largeTree0D, "primary_02", 11, 28);
    public static IndexedTile largeTree1A = IndexedTile.Create(id.largeTree1A, "primary_02", 8, 29);
    public static IndexedTile largeTree1B = IndexedTile.Create(id.largeTree1B, "primary_02", 9, 29);
    public static IndexedTile largeTree1C = IndexedTile.Create(id.largeTree1C, "primary_02", 9, 29, flipX: true);
    public static IndexedTile largeTree1D = IndexedTile.Create(id.largeTree1D, "primary_02", 11, 29);
    public static IndexedTile largeTree2A = IndexedTile.Create(id.largeTree2A, "primary_02", 8, 30);
    public static IndexedTile largeTree2B = IndexedTile.Create(id.largeTree2B, "primary_02", 9, 30);
    public static IndexedTile largeTree2C = IndexedTile.Create(id.largeTree2C, "primary_02", 9, 30, flipX: true);
    public static IndexedTile largeTree2D = IndexedTile.Create(id.largeTree2D, "primary_02", 11, 30);
    public static IndexedTile largeTree3A = IndexedTile.Create(id.largeTree3A, "primary_02", 8, 31);
    public static IndexedTile largeTree3B = IndexedTile.Create(id.largeTree3B, "primary_02", 9, 31);
    public static IndexedTile largeTree3C = IndexedTile.Create(id.largeTree3C, "primary_02", 9, 31, flipX: true);
    public static IndexedTile largeTree3D = IndexedTile.Create(id.largeTree3D, "primary_02", 11, 31);
    public static IndexedTile largeTreeTopA = IndexedTile.Create(id.largeTreeTopA, "primary_02", 12, 19);
    public static IndexedTile largeTreeTopB = IndexedTile.Create(id.largeTreeTopB, "primary_02", 13, 19);
    //Pond water
    public static IndexedTile pondWaterLight = IndexedTile.Create(id.pondWaterLight, "primary_00", 14, 14);
    public static IndexedTile pondWaterDark = IndexedTile.Create(id.pondWaterDark, "primary_00", 14, 15);
    //Tall grass
    public static IndexedTile tallGrassNW = IndexedTile.Create(id.tallGrassNW, "primary_02", 0, 30);
    public static IndexedTile tallGrassNE = IndexedTile.Create(id.tallGrassNE, "primary_02", 1, 30);
    public static IndexedTile tallGrassSW = IndexedTile.Create(id.tallGrassSW, "primary_02", 0, 29, behaviour: TileBehaviour.StartGrassAnimation);
    public static IndexedTile tallGrassSE = IndexedTile.Create(id.tallGrassSE, "primary_02", 1, 29);



    public static TileBase[] TileTable = new TileBase[]
    {
        noTile,
        grass1,
        grass2,
        //Animated water
        water0NW,
        water0NE,
        water0SW,
        water0SE,
        //Mountains
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
        //Small trees
        smallTree0L,
        smallTree0R,
        smallTree1L,
        smallTree1R,
        smallTree2L,
        smallTree2R,
        smallTree3L,
        smallTree3R,
        //Grass edges
        grassEdgeNWNW,
        grassEdgeNWNE,
        grassEdgeNWSW,
        grassEdgeSWNW,
        grassEdgeSWSW,
        grassEdgeNENW,
        grassEdgeNENE,
        grassEdgeNESE,
        grassEdgeSENE,
        grassEdgeSESE,
        grassTopEdgeL,
        grassTopEdgeR,
        grassTopCornerLL,
        grassTopCornerLR,
        grassTopCornerRL,
        grassTopCornerRR,
        //Large trees
        largeTree0A,
        largeTree0B,
        largeTree0C,
        largeTree0D,
        largeTree1A,
        largeTree1B,
        largeTree1C,
        largeTree1D,
        largeTree2A,
        largeTree2B,
        largeTree2C,
        largeTree2D,
        largeTree3A,
        largeTree3B,
        largeTree3C,
        largeTree3D,
        largeTreeTopA,
        largeTreeTopB,
        //Pond water
        pondWaterLight,
        pondWaterDark,
        //Tall grass
        tallGrassNW,
        tallGrassNE,
        tallGrassSW,
        tallGrassSE,
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