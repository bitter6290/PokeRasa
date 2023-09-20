using UnityEngine;

public class HumanoidCharData : CharData
{
    public HumanoidGraphics graphics;
    public override void Load(Player p)
    {
        GameObject charObject = new();
        HumanoidChar newChar = charObject.AddComponent<HumanoidChar>();
        newChar.pos = pos;
        newChar.graphics = graphics;
        newChar.facing = Direction.S;
        newChar.charObject = charObject;
        newChar.charData = this;
        newChar.charRenderer = charObject.AddComponent<SpriteRenderer>();
        newChar.charRenderer.sprite = graphics.stillSouth;
        newChar.active = true;
        newChar.AlignObject();
        p.loadedChars.Add(CharID, newChar);
    }
}