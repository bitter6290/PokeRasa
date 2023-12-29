#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileImportWindow : EditorWindow
{
    private Tileset tileset;

    public void OnGUI()
    {
        GUILayout.Label("Add tiles to tileset", EditorStyles.boldLabel);
        tileset = (Tileset)EditorGUILayout.ObjectField("Tileset", tileset, typeof(Tileset), false);
        if (GUILayout.Button("Cancel")) Close();
        if (GUILayout.Button("Import") && tileset)
        {
            foreach (string guid in Selection.assetGUIDs)
            {
                TileBase tile = AssetDatabase.LoadAssetAtPath<TileBase>(AssetDatabase.GUIDToAssetPath(guid));
                if (!tileset.Tiles.Contains(tile)) tileset.Tiles.Add(tile);
            }
            Close();
        }

    }
    [MenuItem("Assets/Add to Tileset")]
    public static void AddToTileset()
    {
        var TileWindow = CreateInstance<TileImportWindow>();
        TileWindow.position = new Rect(Screen.width / 6, Screen.height / 6, Screen.width / 3, Screen.width / 3);
        TileWindow.ShowPopup();
    }

    [MenuItem("Assets/Add To Tileset", true)]
    public static bool SelectedAreTiles()
    {
        foreach (string guid in Selection.assetGUIDs)
        {
            if (!AssetDatabase.LoadAssetAtPath<TileBase>(AssetDatabase.GUIDToAssetPath(guid))) return false;
        }
        return true;
    }
}


#endif