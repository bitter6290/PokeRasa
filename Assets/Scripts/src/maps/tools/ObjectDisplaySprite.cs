using UnityEngine;
public static class ObjectDisplaySprite
{
    public static readonly Sprite triggerSprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Map Maker/Trigger"), new(0, 0, 15, 15), Vector2.zero, 15);
    public static readonly Sprite signpostSprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Map Maker/Signpost"), new(0, 0, 15, 15), Vector2.zero, 15);
    public static readonly Sprite warpSprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Map Maker/Warp"), new(0, 0, 15, 15), Vector2.zero, 15);
}