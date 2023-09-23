using UnityEngine;
public static class CharGraphics
{

    static Sprite SpriteFromTexture16x32(string path, int x)
        => Sprite.Create(Resources.Load<Texture2D>("Sprites/Characters/" + path),
        new Rect(16 * x, 0, 16, 32), new Vector2(0.5F, 0.25F), 16);
    public static HumanoidGraphics HumanoidFromStandardImage(string path) => new()
    {
        stillNorth = SpriteFromTexture16x32(path, 1),
        walkNorthL = SpriteFromTexture16x32(path, 6),
        walkNorthR = SpriteFromTexture16x32(path, 5),
        stillSouth = SpriteFromTexture16x32(path, 0),
        walkSouthL = SpriteFromTexture16x32(path, 3),
        walkSouthR = SpriteFromTexture16x32(path, 4),
        stillWest = SpriteFromTexture16x32(path, 2),
        walkWestL = SpriteFromTexture16x32(path, 8),
        walkWestR = SpriteFromTexture16x32(path, 7),
        stillEast = SpriteFromTexture16x32(path, 2),
        walkEastL = SpriteFromTexture16x32(path, 8),
        walkEastR = SpriteFromTexture16x32(path, 7),
        flipOnWalkEast = true
    };
    public static HumanoidGraphics brendanWalk = HumanoidFromStandardImage("brendan_walk");
    public static HumanoidGraphics mayWalk = HumanoidFromStandardImage("may_walk");


    public static HumanoidGraphics[] humanoidGraphicsTable = new HumanoidGraphics[]
    {
        brendanWalk,
        mayWalk,
    };
}