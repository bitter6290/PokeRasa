#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.EventSystems;
using static ObjectDisplaySprite;

[ExecuteInEditMode]
public class ObjectDisplay : MonoBehaviour, IPointerClickHandler
{
    public enum Mode
    {
        Trigger,
        Signpost,
        Warp,
        Char
    }

    private static readonly Color translucent = new(1, 1, 1, 160f / 255f);

    public Mode mode;
    public int index;

    public MapHelper mapHelper;

    public IIntPosition Target => mode switch
    {
        Mode.Trigger => mapHelper.OpenMap.triggers[index],
        Mode.Signpost => mapHelper.OpenMap.signposts[index],
        Mode.Warp => mapHelper.OpenMap.warps[index],
        Mode.Char => mapHelper.OpenMap.chars[index],
        _ => throw new System.Exception("ObjectDisplay " + name + " has bad Mode")
    };

    public Vector2Int Pos => Target.Pos;

    public SpriteRenderer sprite;

    public void Render()
    {
        transform.position = new(Target.Pos.x + (mode is Mode.Char ? 0.5f : 0), Target.Pos.y + (mode is Mode.Char ? 0.5f : 0), 0);
        sprite.sortingOrder = 0;
        switch (mode)
        {
            case Mode.Trigger:
                sprite.sprite = triggerSprite;
                sprite.color = translucent;
                break;
            case Mode.Signpost:
                sprite.sprite = signpostSprite;
                sprite.color = translucent;
                break;
            case Mode.Warp:
                sprite.sprite = warpSprite;
                sprite.color = translucent;
                break;
            case Mode.Char:
                sprite.sprite = ((MapChar)Target).data.DefaultSprite;
                sprite.color = Color.white;
                break;
        }
    }

    public void Reposition(Vector2Int value)
    {
        Target.Pos = value;
        Render();
    }

    public static ObjectDisplay Create(MapHelper mapHelper, Mode mode, int index)
    {
        GameObject thisObject = new();
        ObjectDisplay display = thisObject.AddComponent<ObjectDisplay>();
        display.mapHelper = mapHelper;
        display.mode = mode;
        display.index = index;
        display.sprite = thisObject.AddComponent<SpriteRenderer>();
        Debug.Log(mode);
        Debug.Log(index);
        display.Render();
        return display;
    }

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log(Target.Pos);
    }
}

#endif