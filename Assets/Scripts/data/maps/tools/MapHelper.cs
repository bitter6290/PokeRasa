using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class MapHelper : MapManager
{
    public Tilemap collisionMap;
    public Tilemap wildDataMap;

    private bool open;

    private MapID openMap;

    public new MapData mapData => Map.MapTable[(int)openMap];

    public void WriteMap()
    {
        if (!open)
        {
            EditorUtility.DisplayDialog("No map open",
                "Cannot write to a nonexistent map, open a map before editing.", "OK");
            return;
        }
        else
        {
            MapWriter writer = new(this);
            writer.Write();
        }
    }

    new public void ReadMap()
    {
        if (mapID == MapID.None)
        {
            EditorUtility.DisplayDialog("No map selected",
                "No map is selected, select one with the drop-down menu before loading.", "OK");
            return;
        }
        if (open)
            if (!EditorUtility.DisplayDialog("Map is not saved",
                "Map is not saved. Really discard unsaved work?", "Yes", "Cancel"))
                return;
        if (!File.Exists("Assets/Resources/Maps/" + Map.MapTable[(int)mapID].path + ".pokemap"))
        {
            if (!EditorUtility.DisplayDialog("Create new map",
                "Map has no map file yet, create new map?", "Yes", "Cancel"))
                return;
            openMap = mapID;
            open = true;
            MapReader.CreateNewMap(this);
        }
        else
        {
            openMap = mapID;
            open = true;
            MapReader.ReadForEditing(this);
        }
    }

    public void CloseMap(bool saved = false)
    {
        if (open && !saved)
            if (!EditorUtility.DisplayDialog("Map is not saved",
                "Map is not saved. Really discard unsaved work?", "Yes", "Cancel"))
                return;
        level1.ClearAllTiles();
        level2.ClearAllTiles();
        level3.ClearAllTiles();
        collisionMap.ClearAllTiles();
        wildDataMap.ClearAllTiles();
        openMap = MapID.None;
        open = false;
    }

    public void SaveAndCloseMap()
    {
        WriteMap();
        CloseMap(true);
    }

    public void SyncTilesets()
    {
        foreach (IndexedTile i in Tiles.TileTable)
        {
            if (i.index == TileID.NoTile) continue;
            IndexedTile test = AssetDatabase.LoadAssetAtPath<IndexedTile>(
                "Assets/Generated Palettes/General/tile_" + (int)i.index + ".asset"
            );
            if (test == null)
                AssetDatabase.CreateAsset(i,
                    "Assets/Generated Palettes/General/tile_" + (int)i.index + ".asset");
            AssetDatabase.SaveAssets();
        }
        foreach (CollisionTile i in Tiles.CollisionTileTable)
        {
            CollisionTile test = AssetDatabase.LoadAssetAtPath<CollisionTile>(
                "Assets/Generated Palettes/Collision/tile_" + (int)i.collisionID + ".asset"
            );
            if (test == null)
                AssetDatabase.CreateAsset(i,
                    "Assets/Generated Palettes/Collision/tile_" + (int)i.collisionID + ".asset");
            AssetDatabase.SaveAssets();
        }
    }
}