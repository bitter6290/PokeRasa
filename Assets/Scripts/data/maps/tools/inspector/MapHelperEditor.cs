#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapHelper))]
public class MapHelperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapHelper mapHelper = (MapHelper)target;

        if (GUILayout.Button("Create Map"))
        {
            mapHelper.CreateMap();
        }
        if (GUILayout.Button("Open Map"))
        {
            mapHelper.ReadMap();
        }
        if (GUILayout.Button("Save Map"))
        {
            mapHelper.WriteMap();
        }
        if (GUILayout.Button("Close Map"))
        {
            mapHelper.CloseMap();
        }
        if (GUILayout.Button("Save and Close Map"))
        {
            mapHelper.SaveAndCloseMap();
        }
        if (GUILayout.Button("Sync Tiles"))
        {
            mapHelper.SyncTilesets();
        }
    }
}
#endif