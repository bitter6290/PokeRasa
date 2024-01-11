using UnityEngine;
public static class StaticTextures
{
    public static readonly Texture2D box = Resources.Load<Texture2D>("Sprites/Box");
    public static Sprite Box(int size) => Sprite.Create(box, new(0, 0, 4 * size, 4 * size), StaticValues.defPivot, 4);
}