using System;
using UnityEngine;
using static TimeOfDay;

public class TODShading : MonoBehaviour
{
    [SerializeField]
    private GameObject spriteObject;
    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    private bool active = true;

    private static Color morningColor = new(1, 1, 140F / 255F, 20F / 255F);
    private static Color dayColor = new(1, 1, 1, 0);
    private static Color eveningColor = new(105F / 255F, 75F / 255F, 60F / 255F, 70F / 255F);
    private static Color nightColor = new(0, 0, 48F / 255F, 128F / 255F);

    public bool Initialized => spriteObject != null;

    public static TODShading Initialize(Player p)
    {
        Debug.Log("TODShading init");
        GameObject spObj = new("TODSprite");
        TODShading todShading = spObj.AddComponent<TODShading>();

        spObj.transform.parent = p.transform;
        spObj.transform.localScale = new(1000, 1000, 1000);
        spObj.transform.position = new(0, 0, -20);
        todShading.spriteObject = spObj;
        todShading.sprite = spObj.AddComponent<SpriteRenderer>();
        todShading.sprite.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Box"), new Rect(0, 0, 4, 4), new Vector2(0.5F, 0.5F), 4);
        todShading.sprite.color = new(0, 0, 0, 0);
        todShading.sprite.sortingOrder = 9;
        return todShading;
    }

    public void Disable()
    {
        spriteObject.SetActive(false);
        active = false;
    }

    public void Enable()
    {
        spriteObject.SetActive(true);
        active = true;
    }
    public void Update()
    {
        if (!active)
        { sprite.color = new(0, 0, 0, 0); return; }
        sprite.color = TimeUtils.timeOfDay switch
        {
            Morning => morningColor,
            Day => dayColor,
            Evening => eveningColor,
            Night => nightColor,
            _ => dayColor
        };
    }
}