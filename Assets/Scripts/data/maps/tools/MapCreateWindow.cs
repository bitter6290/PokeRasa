#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class MapCreateWindow : EditorWindow
{
    public MapHelper helper;
    private ProjectData ProjectData => helper.projectData;

    int width = 20;
    int height = 20;
    new string name = "";
    Tileset tileset;

    public void OnGUI()
	{
		GUILayout.Label("Create New Map", EditorStyles.boldLabel);
        width = EditorGUILayout.IntField("Width:", width);
		height = EditorGUILayout.IntField("Height:", height);
		name = EditorGUILayout.TextField("Name:", name);
		tileset = (Tileset)EditorGUILayout.ObjectField("Tileset", tileset, typeof(Tileset), false);
		if (GUILayout.Button("Cancel")) Close();
		if (GUILayout.Button("Create") && tileset)
		{
			MapData data = CreateInstance<MapData>();
			data.height = height;
			data.width = width;
			data.name = name;
			data.tileset = tileset;
			int freeIds = ProjectData.freeMapIDs.Count;
			if (freeIds > 0)
			{
				data.index = ProjectData.freeMapIDs[freeIds - 1];
				ProjectData.freeMapIDs.RemoveAt(freeIds - 1);
			}
			else
			{
				data.index = ProjectData.nextMapID++;
			}
			AssetDatabase.CreateAsset(data,
				"Assets/Maps/" + data.name + ".asset");
			helper.mapData = data;
			helper.forceOpen();
			MapReader.CreateNewMapV1(helper);
			helper.WriteMap();
			AssetDatabase.SaveAssets();
			helper.mapData = AssetDatabase.LoadAssetAtPath<MapData>(
				"Assets/Maps/" + data.name + ".asset");
			Close();
		}

	}

}


#endif