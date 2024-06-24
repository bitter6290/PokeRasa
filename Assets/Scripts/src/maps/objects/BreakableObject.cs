using UnityEngine;
using System.Collections;

public class BreakableObject : LoadedChar
{
    public Sprite[] sprites = new Sprite[4];
    public BreakableObjectType type;
    public void AdoptSprites()
    {
        Texture2D texture = type switch
        {
            BreakableObjectType.Rock => Resources.Load<Texture2D>("Sprites/Characters/Inanimate/rock"),
            BreakableObjectType.Tree => Resources.Load<Texture2D>("Sprites/Characters/Inanimate/tree"),
            _ => null
        };
        for (int i = 0; i < 4; i++)
        {
            sprites[i] = Sprite.Create(texture, new(i * 16, 0, 16, 16), StaticValues.defPivot);
        }
    }

    public override IEnumerator WalkNorth()
    {
        charRenderer.sprite = sprites[1];
        yield return new WaitForSeconds(0.2F);
        charRenderer.sprite = sprites[2];
        yield return new WaitForSeconds(0.2F);
        charRenderer.sprite = sprites[3];
        yield return new WaitForSeconds(0.2F);
        StartCoroutine(Unload());
    }
}