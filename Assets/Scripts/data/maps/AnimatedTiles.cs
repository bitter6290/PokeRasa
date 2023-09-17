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
            SpriteFromTexture8x8("WaterAnims/0",x,y),
            SpriteFromTexture8x8("WaterAnims/1",x,y),
            SpriteFromTexture8x8("WaterAnims/2",x,y),
            SpriteFromTexture8x8("WaterAnims/3",x,y),
            SpriteFromTexture8x8("WaterAnims/4",x,y),
            SpriteFromTexture8x8("WaterAnims/5",x,y),
            SpriteFromTexture8x8("WaterAnims/6",x,y),
            SpriteFromTexture8x8("WaterAnims/7",x,y),
        };
    public static Sprite[] water0NWSprites = SpriteFromWaterAnims(0, 14);
    public static Sprite[] water0NESprites = SpriteFromWaterAnims(1, 14);
    public static Sprite[] water0SWSprites = SpriteFromWaterAnims(0, 13);
    public static Sprite[] water0SESprites = SpriteFromWaterAnims(1, 13);

    public static AITile water0NW = AITile.Create(id.Water0NW, water0NWSprites, 0.2F);
    public static AITile water0NE = AITile.Create(id.Water0NE, water0NESprites, 0.2F);
    public static AITile water0SW = AITile.Create(id.Water0SW, water0SWSprites, 0.2F);
    public static AITile water0SE = AITile.Create(id.Water0SE, water0SESprites, 0.2F);
}