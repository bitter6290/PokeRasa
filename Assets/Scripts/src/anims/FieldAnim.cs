using System.Collections;
using UnityEngine;
using static AnimUtils;

public static class FieldAnim
{
    public static IEnumerator ExclamBubble(GameObject g) //Duration 1.00
    {
        GameObject bubbleObject = new();
        AudioSource audio = bubbleObject.AddComponent<AudioSource>();
        audio.PlayOneShot(Resources.Load<AudioClip>("Sound/Field SFX/Pin"));
        bubbleObject.transform.parent = g.transform;
        bubbleObject.transform.localPosition = new Vector3(0, 0.5F, -1);
        SpriteRenderer bubble = bubbleObject.AddComponent<SpriteRenderer>();
        bubble.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Field/exclam"),
            new Rect(0, 0, 16, 16), StaticValues.defPivot, 16);
        yield return Slide(bubbleObject.transform, new Vector2(0.0F, 0.5F), 0.2F); //0.20
        yield return Fall(bubbleObject.transform, 16.7F, new Vector2(0.0F, 2.5F), 0.3F); //0.50
        yield return new WaitForSeconds(0.5F); //1.00
        Object.Destroy(bubbleObject);
    }
}