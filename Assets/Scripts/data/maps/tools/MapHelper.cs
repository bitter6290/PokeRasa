using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class MapHelper : MapManager
{
    public Tilemap collisionMap;
    public Tilemap wildDataMap;

    public void WriteMap()
    {
        MapWriter writer = new(this);
        writer.Write();
    }

    public void ReadMap()
    {
        MapReader reader = new();
        reader.ReadForEditing(this);
    }

    public void SyncTilesets()
    {
        foreach (IndexedTile i in Tiles.TileTable)
        {
            if (i.index == TileID.NoTile) continue;
            IndexedTile test = AssetDatabase.LoadAssetAtPath<IndexedTile>(
                "Assets/Generated Palletes/General/tile_" + (int)i.index + ".asset"
            );
            if (test == null)
                AssetDatabase.CreateAsset(i,
                    "Assets/Generated Palettes/General/tile_" + (int)i.index + ".asset");
            else
            {
                test.sprite = i.sprite;
                test.index = i.index;
            }
            AssetDatabase.SaveAssets();
        }
        foreach (CollisionTile i in Tiles.CollisionTileTable)
        {
            CollisionTile test = AssetDatabase.LoadAssetAtPath<CollisionTile>(
                "Assets/Generated Palletes/Collision/tile_" + (int)i.collisionID + ".asset"
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