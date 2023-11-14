using System;
using UnityEngine;

public class MapData : ScriptableObject
{
    public int index;
    public string id;

    [SerializeField]
    private string mapTiles;
    public Tileset tileset;
    public int height;
    public int width;
    public Connection[] connection = new Connection[0];

    public TileTrigger[] triggers = new TileTrigger[0];
    public TileTrigger[] signposts = new TileTrigger[0];
    public (CharData data, Vector2Int pos)[] chars = new (CharData data, Vector2Int pos)[0];
    public WildDataset[] grassData = new WildDataset[9];

    public (CharData, Vector2Int) CharFromId(string id)
    {
        foreach ((CharData data, Vector2Int pos) in chars){
            if (data.id == id) return (data, pos);
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