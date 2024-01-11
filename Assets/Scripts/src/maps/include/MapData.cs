using System;
using UnityEngine;

public class MapData : ScriptableObject
{
    public int index;
    public string id;

    [HideInInspector]
    [SerializeField]
    private string mapTiles;
    public Tileset tileset;
    public int height;
    public int width;
    public Connection[] connection = new Connection[0];

    public TODShading.ShadingBehaviour shading;

    public TileTrigger[] triggers = new TileTrigger[0];
    public TileTrigger[] signposts = new TileTrigger[0];
    public WarpTrigger[] warps = new WarpTrigger[0];
    public MapChar[] chars = new MapChar[0];
    public WildDataset[] grassData = new WildDataset[9];

    public (CharData, Vector2Int) CharFromId(string id)
    {
        foreach (MapChar charData in chars)
        {
            if (charData.data.id == id) return (charData.data, charData.pos);
        }
        return (null, Vector2Int.zero);
    }

    public void LoadCharFromId(string id, Player p)
    {
        (CharData chara, Vector2Int pos) = CharFromId(id);
        chara.Load(p, this, pos);
    }

    public MapScripts mapScripts;

    public string MapTiles => mapTiles;
    public void WriteMapTiles(string newTiles)
    {
        mapTiles = newTiles;
    }
}

[Serializable]
public struct MapChar : IIntPosition
{
    public CharData data;
    public Vector2Int pos;

    public Vector2Int Pos
    {
        readonly get => pos;
        set => pos = value;
    }
}