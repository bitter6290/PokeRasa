#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class OpenMapWindow : EditorWindow
{
    public MapHelper helper;
    private MapData mapData;

    public void OnGUI()
    {
        GUILayout.Label("Add Character", EditorStyles.boldLabel);
        mapData = (MapData)EditorGUILayout.ObjectField("Map", mapData, typeof(MapData), false);
        if (GUILayout.Button("Cancel")) { Close(); }
        if (GUILayout.Button("Open") && mapData)
        {
            helper.TryToOpenMap(mapData);
            Close();
        }

    }

}


#endif