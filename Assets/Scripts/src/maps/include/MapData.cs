using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;

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

    public List<TileTrigger> triggers = new();
    public List<TileTrigger> signposts = new();
    public List<WarpTrigger> warps = new();
    public List<MapChar> chars = new();
    public WildDataset[] grassData = new WildDataset[9];

    public Metatiles.FourTiles boundary;

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