#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class MapCreateWindow : EditorWindow
{
	public MapHelper helper;
	private ProjectData projectData => helper.projectData;

    int width = 20;
    int height = 20;
    new string name = "";

	public void OnGUI()
	{
		GUILayout.Label("Create New Map", EditorStyles.boldLabel);
		width = EditorGUILayout.IntField("Width:", width);
		height = EditorGUILayout.IntField("Height:", height);
		name = EditorGUILayout.TextField("Name:", name);
		if (GUILayout.Button("Cancel")) Close();
		if (GUILayout.Button("Create"))
		{
            MapData data = CreateInstance<MapData>();
            data.height = height;
            data.width = width;
            data.name = name;
			int freeIds = projectData.freeMapIDs.Count;
			if (freeIds > 0)
			{
				data.index = projectData.freeMapIDs[freeIds - 1];
				projectData.freeMapIDs.RemoveAt(freeIds - 1);
			}
            else
            {
                data.index = projectData.nextMapID++;
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