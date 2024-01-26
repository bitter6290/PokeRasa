#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class NewCharWindow : EditorWindow
{
    public MapHelper helper;
    private CharData charData;

    public void OnGUI()
    {
        GUILayout.Label("Add Character", EditorStyles.boldLabel);
        charData = (CharData)EditorGUILayout.ObjectField("Character Data", charData, typeof(CharData), false);
        if (GUILayout.Button("Cancel")) Close();
        if (GUILayout.Button("Create") && charData)
        {
            MapChar mapChar = new();
            mapChar.data = charData;
            helper.OpenMap.chars.Add(mapChar);
            helper.ShowObjects();
        }

    }

}


#endif