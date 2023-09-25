using UnityEngine;
using id = TileID;
using AITile = AnimatedIndexedTile;

public static class AnimatedTiles
{
    static Sprite SpriteFromTexture8x8(string path, int x, int y)
    => Sprite.Create(Resources.Load<Texture2D>("Tilesets/" + path),
            new Rect(8 * x, 8 * y, 8, 8), new Vector2(0.5F, 0.5F), 16);

    static Sprite[] SpriteFromWaterAnims(int x, int y)
    => new Sprite[8]
        {
            SpriteFromTexture8x8("Anims/Water/0",x,y),
            SpriteFromTexture8x8("Anims/Water/1",x,y),
            SpriteFromTexture8x8("Anims/Water/2",x,y),
            SpriteFromTexture8x8("Anims/Water/3",x,y),
            SpriteFromTexture8x8("Anims/Water/4",x,y),
            SpriteFromTexture8x8("Anims/Water/5",x,y),
            SpriteFromTexture8x8("Anims/Water/6",x,y),
            SpriteFromTexture8x8("Anims/Water/7",x,y),
        };
    public static Sprite[] waterNormalASprites = SpriteFromWaterAnims(0, 3);
    public static Sprite[] waterNormalBSprites = SpriteFromWaterAnims(1, 3);
    public static Sprite[] waterDarkASprites = SpriteFromWaterAnims(0, 2);
    public static Sprite[] waterDarkBSprites = SpriteFromWaterAnims(1, 2);

    public static Sprite[] shallowWaterASprites = SpriteFromWaterAnims(0, 6);
    public static Sprite[] shallowWaterBSprites = SpriteFromWaterAnims(1, 6);
    public static Sprite[] shallowWaterNWSprites = SpriteFromWaterAnims(0, 5);
    public static Sprite[] shallowWaterNESprites = SpriteFromWaterAnims(1, 5);
    public static Sprite[] shallowWaterSWSprites = SpriteFromWaterAnims(0, 4);
    public static Sprite[] shallowWaterSESprites = SpriteFromWaterAnims(1, 4);

    public static AITile waterNormalA = AITile.Create(id.waterNormalA, waterNormalASprites, 5F);
    public static AITile waterNormalB = AITile.Create(id.waterNormalB, waterNormalBSprites, 5F);
    public static AITile waterDarkA = AITile.Create(id.waterDarkA, waterDarkASprites, 5F);
    public static AITile waterDarkB = AITile.Create(id.waterDarkB, waterDarkBSprites, 5F);
    public static AITile shallowWaterA = AITile.Create(id.shallowWaterA, shallowWaterASprites, 5F);
    public static AITile shallowWaterB = AITile.Create(id.shallowWaterB, shallowWaterBSprites, 5F);
    public static AITile shallowWaterNW = AITile.Create(id.shallowWaterNW, shallowWaterNWSprites, 5F);
    public static AITile shallowWaterNE = AITile.Create(id.shallowWaterNE, shallowWaterNESprites, 5F);
    public static AITile shallowWaterSW = AITile.Create(id.shallowWaterSW, shallowWaterSWSprites, 5F);
    public static AITile shallowWaterSE = AITile.Create(id.shallowWaterSE, shallowWaterSESprites, 5F);
}