using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapHelper))]
public class MapHelperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapHelper mapHelper = (MapHelper)target;
        if(GUILayout.Button("Open Map"))
        {
            mapHelper.ReadMap();
        }
        if(GUILayout.Button("Save Map"))
        {
            mapHelper.WriteMap();
        }
        if(GUILayout.Button("Sync Tiles"))
        {
            mapHelper.SyncTilesets();
        }
    }
}