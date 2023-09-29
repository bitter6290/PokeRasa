using UnityEngine;

[System.Serializable]
public class HumanoidCharData : CharData
{
    public HumanoidGraphicsID graphics;

    public override void Load(Player p, MapData map)
    {
        foreach (int i in p.loadedChars.Keys) if (CharID == i) return;
        GameObject charObject = new();
        HumanoidChar newChar = charObject.AddComponent<HumanoidChar>();
        newChar.currentMap = map;
        newChar.pos = pos;
        newChar.currentMap = p.currentMap;
        newChar.graphics = CharGraphics.humanoidGraphicsTable[(int)graphics];
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
        newChar.AlignObject();
        newChar.UpdateCollision();
        Debug.Log(CharID);
        Object.DontDestroyOnLoad(newChar);
        Object.DontDestroyOnLoad(charObject);
        p.loadedChars.Add(CharID, newChar);
    }
}