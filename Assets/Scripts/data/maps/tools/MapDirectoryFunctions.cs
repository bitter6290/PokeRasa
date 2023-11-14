#if UNITY_EDITOR
using UnityEditor;
using static UnityEditor.AssetDatabase;

public static class MapDirectoryUtils
{
    static MapDirectory directory => LoadAssetAtPath<MapDirectory>("Assets/Maps/Directory.asset");

    [MenuItem("Services/Update Map Directory")]
    public static void CreateMapDirectory()
    {
        MapDirectory maps = directory;
        maps.maps = new();
        foreach (string guid in FindAssets("t:MapData"))
        {
            maps.maps.Add(LoadAssetAtPath<MapData>(GUIDToAssetPath(guid)));
        }
        SaveAssets();
    }
}

#endif