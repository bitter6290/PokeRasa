using System;
using UnityEngine;

public delegate void ObjectMovement(LoadedChar loadedChar);
public delegate bool SeeCondition(Player p);

public abstract class CharData
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

    public ScriptDomain scriptDomain;

    public CharScript OnInteract => AllScripts.CharScripts[scriptDomain][index].OnInteract;
    public SeeCondition SeeCheck => AllScripts.CharScripts[scriptDomain][index].SeeCheck;
    public CharScript OnSee => AllScripts.CharScripts[scriptDomain][index].OnSee;
    public CharScript OnWin => AllScripts.CharScripts[scriptDomain][index].OnWin;

    public ObjectMovement GetMovement => AllScripts.CharScripts[scriptDomain][index].GetMovement;

    public bool IsLoaded(Player p)
    {
        foreach (int i in p.loadedChars.Keys) if (CharID == i) return true;
        return false;
    }

    public abstract void Load(Player p, MapData map);
}