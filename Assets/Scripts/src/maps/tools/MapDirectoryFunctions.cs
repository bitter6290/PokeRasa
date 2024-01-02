#if UNITY_EDITOR
using UnityEditor;
using static UnityEditor.AssetDatabase;

public static class MapDirectoryUtils
{
    public static MapDirectory Directory => LoadAssetAtPath<MapDirectory>("Assets/Maps/Directory.asset");

    [MenuItem("Services/Update Map Directory")]
    public static void CreateMapDirectory()
    {
        MapDirectory maps = Directory;
        maps.maps = new();
        int i = 0;
        foreach (string guid in FindAssets("t:MapData"))
        {
            MapData mapData = (LoadAssetAtPath<MapData>(GUIDToAssetPath(guid)));
            maps.maps.Add(mapData);
            mapData.index = i++;
        }
        SaveAssets();
    }
}

#endif