using System.Collections;
using UnityEngine;

public static class TriggeredTileAnim
{
    private static readonly Texture2D tallGrassShake = Resources.Load<Texture2D>("Tilesets/Anims/Effects/tall_grass");
    public static IEnumerator TallGrassShake(Vector2Int pos, LoadedChar c)
    {
        GameObject grassAnim = new();
        grassAnim.transform.position = new(pos.x, pos.y);
        SpriteRenderer renderer = grassAnim.AddComponent<SpriteRenderer>();
        renderer.sortingOrder = -2;
        for (int i = 1; i <= 4; i++)
        {
            renderer.sprite = Sprite.Create(tallGrassShake, new Rect(16 * i, 0, 16, 16), Vector2.zero, 16);
            yield return new WaitForSeconds(0.2F);
        }
        renderer.sprite = Sprite.Create(tallGrassShake, new Rect(0, 0, 16, 16), Vector2.zero, 16);
        while (c.pos == pos)
        {
            yield return null;
        }
        Object.Destroy(grassAnim);
    }
    public static IEnumerator WaitAndDestroy(float time, GameObject @object)
    {
        yield return new WaitForSeconds(time);
        Object.Destroy(@object);
    }
    public static IEnumerator DoDoorAnim(Player p, Vector2Int pos, IDoor door, float persistenceTime) //Should go from top to bottom
    {
        GameObject doorAnim = new();
        doorAnim.transform.position = new(pos.x, pos.y);
        SpriteRenderer renderer = doorAnim.AddComponent<SpriteRenderer>();
        renderer.sortingOrder = -2;
        int i = door.AnimFrames.height;
        while (i > 0)
        {
            i -= door.Dimensions.y;
            renderer.sprite = Sprite.Create(door.AnimFrames, new(0, i,
                door.Dimensions.x, door.Dimensions.y), Vector2.zero, 16);
            yield return new WaitForSeconds(door.FrameTime);
        }
        p.StartCoroutine(WaitAndDestroy(persistenceTime, doorAnim));
    }
    public static IEnumerator DoBackwardsDoorAnim(Vector2Int pos, IDoor door, float waitTime) //Should go from bottom to top
    {
        GameObject doorAnim = new();
        doorAnim.transform.position = new(pos.x, pos.y);
        SpriteRenderer renderer = doorAnim.AddComponent<SpriteRenderer>();
        renderer.sortingOrder = -2;
        int i = 0;
        renderer.sprite = Sprite.Create(door.AnimFrames,
            new(0, 0, door.Dimensions.x, door.Dimensions.y), Vector2.zero, 16);
        yield return new WaitForSeconds(waitTime);
        while (i < door.AnimFrames.height)
        {
            renderer.sprite = Sprite.Create(door.AnimFrames, new(0, i,
                door.Dimensions.x, door.Dimensions.y), Vector2.zero, 16);
            yield return new WaitForSeconds(door.FrameTime);
            i += door.Dimensions.y;
        }
        Object.Destroy(doorAnim);
    }
}