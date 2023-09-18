using System.Collections;

public delegate IEnumerator TriggerScript(Player p);
public struct TileTrigger
{
    public MapID map;
    public int x;
    public int y;
    public byte index;
    public TriggerScript script;
}