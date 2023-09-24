using System.Collections;
using UnityEngine;

public static class TriggeredTileAnim
{
    private static Texture2D tallGrassShake = Resources.Load<Texture2D>("Tilesets/Anims/Effects/tall_grass");
    public static IEnumerator TallGrassShake(Vector2Int pos, LoadedChar c)
    {
        GameObject grassAnim = new();
        grassAnim.transform.position = new(pos.x,pos.y);
        SpriteRenderer renderer = grassAnim.AddComponent<SpriteRenderer>();
        renderer.sortingOrder = -2;
        for (int i = 1; i <= 4; i++)
        {
            renderer.sprite = Sprite.Create(tallGrassShake, new Rect(16 * i, 0, 16, 16), Vector2.zero, 16);
            yield return new WaitForSeconds(0.2F);
        }
        renderer.sprite = Sprite.Create(tallGrassShake, new Rect(0, 0, 16, 16), Vector2.zero, 16);
        while(c.pos == pos)
        {
            yield return null;
        }
        Object.Destroy(grassAnim);
    }
}