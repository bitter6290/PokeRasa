#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class MapCopyWindow : EditorWindow
{
    public MapHelper helper;

    private MapData mapData = null;

    public void OnGUI()
    {
        GUILayout.Label("Copy Map Layout");

        mapData = (MapData)EditorGUILayout.ObjectField("Template Map", mapData, typeof(MapData), false);

        bool canGo = true;

        if (mapData == null)
        {
            GUILayout.Label("No map selected!");
            canGo = false;
        }
        else if (mapData == helper.map)
        {
            GUILayout.Label("Map is already open!");
            canGo = false;
        }
        else if (mapData.height != helper.map.height)
        {
            GUILayout.Label("Heights do not match (" + mapData.height + ", " + helper.map.height + ")");
            canGo = false;
        }
        else if (mapData.width != helper.map.width)
        {
            GUILayout.Label("Widths do not match (" + mapData.width + ", " + helper.map.width + ")");
            canGo = false;
        }
        else if (mapData.tileset != helper.map.tileset)
        {
            GUILayout.Label("Warning: will change tileset");
        }
        else GUILayout.Label("Good to go");
        if (GUILayout.Button("Copy layout") && canGo)
        {
            helper.map.WriteMapTiles(mapData.MapTiles);
            helper.ForceClose();
            helper.ReadMap();
        }
    }

}

#endif