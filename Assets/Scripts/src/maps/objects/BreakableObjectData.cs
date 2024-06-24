using UnityEngine;
[CreateAssetMenu(fileName = "Object", menuName = "ScriptableObjects/Breakable Object", order = 2)]
public class BreakableObjectData : CharData
{
    public BreakableObjectType type;
    public override LoadedChar Load(Player p, MapData map, Vector2Int pos)
    {
        foreach (string i in p.loadedChars.Keys) if (id == i) return null;
        GameObject charObject = new();
        BreakableObject newChar = charObject.AddComponent<BreakableObject>();
        newChar.currentMap = map;
        newChar.currentMap = p.currentMap;
        newChar.facing = Direction.S;
        newChar.charObject = charObject;
        newChar.charData = this;
        newChar.charRenderer = charObject.AddComponent<SpriteRenderer>();
        newChar.type = type;
        newChar.AdoptSprites();
        newChar.charRenderer.sprite = newChar.sprites[0];
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
    public override Sprite DefaultSprite
    {
        get
        {
            return type switch
            {
                BreakableObjectType.Rock => Sprite.Create(Resources.Load<Texture2D>("Sprites/Characters/Inanimate/rock"),
                    new(0,0,16,16), StaticValues.defPivot),
                BreakableObjectType.Tree => Sprite.Create(Resources.Load<Texture2D>("Sprites/Characters/Inanimate/tree"),
                    new(0,0,16,16), StaticValues.defPivot),
                _ => null
            };
        }
    }
    #endif
}