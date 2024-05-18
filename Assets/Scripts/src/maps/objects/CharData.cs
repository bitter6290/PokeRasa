using UnityEngine;

public delegate void ObjectMovement(LoadedChar loadedChar);
public delegate bool SeeCondition(Player p);

public abstract class CharData : ScriptableObject
{
    public string id;

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
        foreach (string i in p.loadedChars.Keys) if (id == i) return true;
        return false;
    }

    public abstract LoadedChar Load(Player p, MapData map, Vector2Int pos);
#if UNITY_EDITOR
    public abstract Sprite DefaultSprite { get; }
#endif
}