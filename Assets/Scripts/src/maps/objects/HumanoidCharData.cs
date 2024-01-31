using UnityEngine;
using static CharGraphics;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Humanoid Character", order = 2)]
public class HumanoidCharData : CharData
{
    public Texture2D graphics;

    public override LoadedChar Load(Player p, MapData map, Vector2Int pos)
    {
        foreach (string i in p.loadedChars.Keys) if (id == i) return null;
        GameObject charObject = new();
        HumanoidChar newChar = charObject.AddComponent<HumanoidChar>();
        newChar.currentMap = map;
        newChar.currentMap = p.currentMap;
        newChar.graphics = HumanoidFromStandardImage(graphics);
        newChar.facing = Direction.S;
        newChar.charObject = charObject;
        newChar.charData = this;
        newChar.charRenderer = charObject.AddComponent<SpriteRenderer>();
        newChar.charRenderer.sprite = newChar.graphics.stillSouth;
        newChar.active = loadedByDefault;
        newChar.hasCollision = hasCollision;
        newChar.free = true;
        newChar.available = true;
        newChar.Actions = new();
        newChar.p = p;
        newChar.pos = pos;
        newChar.AlignObject();
        newChar.UpdateCollision();
        Debug.Log(id);
        Object.DontDestroyOnLoad(newChar);
        Object.DontDestroyOnLoad(charObject);
        p.loadedChars.Add(id, (map, newChar));
        return newChar;
    }
#if UNITY_EDITOR
    public override Sprite DefaultSprite => HumanoidFromStandardImage(graphics).stillSouth;
#endif
}