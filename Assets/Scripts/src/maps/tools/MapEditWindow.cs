#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class MapEditWindow : EditorWindow
{
    public MapHelper helper;

    private Vector2 scrollPos;

    public void OnGUI()
    {
        MapData mapData = helper.OpenMap;
        GUILayout.Label("Edit Map Data");
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        if (mapData != null)
        {
            var editor = Editor.CreateEditor(mapData);
            editor.OnInspectorGUI();
        }
        EditorGUILayout.EndScrollView();
        if (GUILayout.Button("Close")) Close();
    }
}


#endif