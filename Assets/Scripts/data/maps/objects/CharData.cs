using UnityEngine;

public delegate void ObjectMovement(LoadedChar loadedChar);
public delegate bool SeeCondition(Player p);

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

    public CharScript OnInteract = (p, c) => { return; };
    public SeeCondition SeeCheck = p => { return false; };
    public CharScript OnSee = (p, c) => { return; };
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