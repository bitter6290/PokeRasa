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

    public ObjectScript OnInteract = p => ScriptUtils.DoNothing(p);
    public ObjectScript OnSee = p => ScriptUtils.DoNothing(p);

    public ObjectMovement GetMovement;

    public abstract void Load(Player p);
}