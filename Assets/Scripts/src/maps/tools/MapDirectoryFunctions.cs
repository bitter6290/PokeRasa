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
        foreach (string guid in FindAssets("t:MapData"))
        {
            maps.maps.Add(LoadAssetAtPath<MapData>(GUIDToAssetPath(guid)));
        }
        SaveAssets();
    }
}

#endif