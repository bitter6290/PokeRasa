using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MapData", menuName = "ScriptableObjects/MapData", order = 1)]
public class MapData : ScriptableObject
{
    public int index;

    [SerializeField]
    private string mapTiles;
    public int height;
    public int width;
    public Connection[] connection = new Connection[0];

    public TileTrigger[] triggers = new TileTrigger[0];
    public TileTrigger[] signposts = new TileTrigger[0];
    public HumanoidCharData[] humanoidChars = new HumanoidCharData[0];
    public WildDataset[] grassData = new WildDataset[9];

    public string mapScripts = "None";
    public ObjectScript BeforeLoad => AllScripts.MapScripts[mapScripts].BeforeLoad; /*
                   * Executes *before* chars are unloaded; use this script to 
                   * preserve chars which would otherwise be unloaded
                   */
    public ObjectScript OnLoad => AllScripts.MapScripts[mapScripts].OnLoad;     /*
                   * Executes after chars are loaded; use this script to
                   * make changes to tile triggers, signposts and chars
                   */
    public string MapTiles => mapTiles;
    public void WriteMapTiles(string newTiles)
    {
        mapTiles = newTiles;
    }

    internal static T LoadAssetAtPath<T>(string v) => throw new NotImplementedException();
}