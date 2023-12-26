using UnityEngine;
using static StaticValues;
public static class StatusSprite
{
    private static Texture2D statusTexture = Resources.Load<Texture2D>("Sprites/Battle/status");
    public static Sprite noStatus = Sprite.Create(statusTexture, new(0, 40, 24, 8), defPivot);
    public static Sprite poison = Sprite.Create(statusTexture, new(0, 32, 24, 8), defPivot);
    public static Sprite paralysis = Sprite.Create(statusTexture, new(0, 24, 24, 8), defPivot);
    public static Sprite sleep = Sprite.Create(statusTexture, new(0, 16, 24, 8), defPivot);
    public static Sprite freeze = Sprite.Create(statusTexture, new(0, 8, 24, 8), defPivot);
    public static Sprite burn = Sprite.Create(statusTexture, new(0, 0, 24, 8), defPivot);

    public static Sprite ToSprite(this Status status) => status switch
    {
        Status.Paralysis => paralysis,
        Status.Poison or Status.ToxicPoison => poison,
        Status.Sleep => sleep,
        Status.Freeze => freeze,
        Status.Burn => burn,
        _ => noStatus
    };
}