#if UNITY_EDITOR
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
        if (!File.Exists("Assets/StreamingAssets/Maps/" + Map.MapTable[(int)mapID].path + ".pokemap"))
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
        foreach (TileBase i in Tiles.TileTable)
        {
            IndexedTile tile = i as IndexedTile;
            if (tile == null)
            {
                AnimatedIndexedTile animTile = i as AnimatedIndexedTile;
                if (animTile == null || animTile.Index == (int)TileID.noTile) continue;
                else
                {
                    AnimatedIndexedTile animTest = AssetDatabase.LoadAssetAtPath<AnimatedIndexedTile>(
                        "Assets/Generated Palettes/General/tile_" + animTile.Index + ".asset"
                    );
                    if (animTest == null)
                    {
                        if (File.Exists("Assets/Generated Palettes/General/tile_" + animTile.Index + ".asset"))
                        { File.Delete("Assets/Generated Palettes/General/tile_" + animTile.Index + ".asset"); }
                        AssetDatabase.CreateAsset(i,
                            "Assets/Generated Palettes/General/tile_" + animTile.Index + ".asset");
                    }
                    else
                    {
                        animTest.m_AnimatedSprites = animTile.m_AnimatedSprites;
                        animTest.m_MaxSpeed = animTile.m_MaxSpeed;
                        animTest.m_MinSpeed = animTile.m_MinSpeed;
                        animTest.tileID = animTile.tileID;
                    }
                }

            }
            else
            {
                if (tile.Index == (int)TileID.noTile) continue;
                IndexedTile test = AssetDatabase.LoadAssetAtPath<IndexedTile>(
                    "Assets/Generated Palettes/General/tile_" + tile.Index + ".asset"
                );
                if (test == null)
                {
                    if (File.Exists("Assets/Generated Palettes/General/tile_" + tile.Index + ".asset"))
                    { File.Delete("Assets/Generated Palettes/General/tile_" + tile.Index + ".asset"); }
                    AssetDatabase.CreateAsset(i,
                        "Assets/Generated Palettes/General/tile_" + tile.Index + ".asset");
                }
                else
                {
                    test.sprite = tile.sprite;
                    test.tileID = tile.tileID;
                }
            }
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
            else
            {
                test.sprite = i.sprite;
                test.collisionID = i.collisionID;
            }
            AssetDatabase.SaveAssets();
        }
    }
}
#endif