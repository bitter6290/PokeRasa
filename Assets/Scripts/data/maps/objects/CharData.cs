using System;
using UnityEngine;

public delegate void ObjectMovement(LoadedChar loadedChar);
public delegate bool SeeCondition(Player p);

public abstract class CharData : ScriptableObject
{
    public int index;
    public MapData map;
    public int CharID => index + (map.index << 16);

    public Vector2Int pos;

    public MapData[] mapsToLoad;

    public bool loadedByDefault = true;
    public bool hasCollision = true;
    public bool hasSeeScript = false;
    public int sightRadius;

    public CharScripts charScripts;

    public CharScript OnInteract => charScripts.OnInteract;
    public SeeCondition SeeCheck => charScripts.SeeCheck;
    public CharScript OnSee => charScripts.OnSee;
    public CharScript OnWin => charScripts.OnWin;

    public ObjectMovement GetMovement => charScripts.GetMovement;

    public bool IsLoaded(Player p)
    {
        foreach (int i in p.loadedChars.Keys) if (CharID == i) return true;
        return false;
    }

    public abstract void Load(Player p, MapData map);
}