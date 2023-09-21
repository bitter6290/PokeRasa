using UnityEngine;

public delegate void ObjectMovement(LoadedChar loadedChar);

public abstract class CharData
{
    public int index;
    public MapID mapID;
    public int CharID => index + ((int)mapID << 16);

    public Vector2Int pos;

    public MapID[] mapsToLoad;

    public bool loadedByDefault = true;
    public bool hasCollision = true;
    public bool hasSeeScript = false;
    public int sightRadius;

    public CharScript OnInteract = (p, c) => ScriptUtils.DoNothing(p);
    public CharScript OnSee = (p, c) => ScriptUtils.DoNothing(p);
    public CharScript OnWin = (p, c) =>
    {
        p.state = PlayerState.Free;
    };

    public ObjectMovement GetMovement;

    public bool IsLoaded(Player p)
    {
        foreach (int i in p.loadedChars.Keys) if (CharID == i) return true;
        return false;
    }

    public abstract void Load(Player p);
}