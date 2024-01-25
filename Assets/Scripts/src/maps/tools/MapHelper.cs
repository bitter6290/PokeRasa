#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

[ExecuteInEditMode]
public class MapHelper : MapManager
{
    public Tilemap collisionMap;
    public Tilemap wildDataMap;

    public ProjectData projectData;

    [HideInInspector]
    public bool open;
    public void ForceOpen() => open = true;
    public void ForceClose() => open = false;

    [HideInInspector]
    [SerializeField]
    private MapData openMap;
    public MapData OpenMap => openMap;

    [HideInInspector]
    public List<ObjectDisplay> objectDisplays = new();

    [HideInInspector]
    public GameObject objectDisplayParent;

    [HideInInspector]
    public bool draggingObject;
    [HideInInspector]
    public ObjectDisplay clickedObjectDisplay;

    [HideInInspector]
    public bool objectsEnabled = true;

    public bool WriteMap()
    {
        if (!open)
        {
            EditorUtility.DisplayDialog("No map open",
                "Cannot write to a nonexistent map, open a map before editing.", "OK");
            return false; ;
        }
        else
        {
            MapWriter writer = new(this);
            return writer.Write();
        }
    }

    public new void ReadMap()
    {
        if (map == null)
        {
            EditorUtility.DisplayDialog("No map selected",
                "No map is selected, select one with the drop-down menu before loading.", "OK");
            return;
        }
        if (open)
        {
            if (!EditorUtility.DisplayDialog("Map is not saved",
                "Map is not saved. Really discard unsaved work?", "Yes", "Cancel"))
                return;
        }
        if (map.MapTiles.Length == 0)
        {
            MapReader.CreateNewMapV1(this);
        }
        else
        {
            openMap = map;
            open = true;
            MapReader.ReadForEditingV1(this);
            ShowObjects();
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
        FlushObjects();
        openMap = null;
        open = false;
    }

    public void SaveAndCloseMap()
    {
        if (WriteMap())
        {
            CloseMap(true);
        }
    }

    public void CreateMap()
    {
        if (open)
        {
            if (!EditorUtility.DisplayDialog("Map is not saved",
                "Map is not saved. Really discard unsaved work?", "Yes", "Cancel"))
                return;
        }
        var CreateMapPopup = ScriptableObject.CreateInstance<MapCreateWindow>();
        CreateMapPopup.helper = this;
        CreateMapPopup.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
        CreateMapPopup.ShowPopup();
    }

    public void CopyMap()
    {
        if (!open)
        {
            EditorUtility.DisplayDialog("No map open",
                "Cannot copy to a nonexistent map, open a map first.", "OK");
        }
        var CopyMapPopup = ScriptableObject.CreateInstance<MapCopyWindow>();
        CopyMapPopup.helper = this;
        CopyMapPopup.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
        CopyMapPopup.ShowPopup();
    }

    public void UpdateConnections()
    {
        MapReader.ClearConnections(this);
        MapReader.RenderNeighborsForEditingV1(this);
    }

    public void ReflectConnections()
    {
        Debug.Log("Reflecting connections");
        foreach (Connection i in openMap.connection)
        {
            bool alreadyDone = false;
            for (int j = 0; j < i.map.connection.Length; j++)
            {
                if (i.map.connection[j].map == openMap)
                {
                    alreadyDone = true;
                    i.map.connection[j].direction = i.direction.Opposite();
                    i.map.connection[j].offset = -i.offset;
                }
            }
            if (!alreadyDone)
            {
                Connection[] newConnections = new Connection[i.map.connection.Length + 1];
                i.map.connection.CopyTo(newConnections, 0);
                newConnections[i.map.connection.Length] = new(openMap, i.direction.Opposite(), -i.offset);
                i.map.connection = newConnections;
            }
        }
        AssetDatabase.SaveAssets();
        Debug.Log("Done");
    }

    public void FlushObjects()
    {
        foreach (ObjectDisplay obj in objectDisplays) DestroyImmediate(obj.gameObject);
        objectDisplays = new();
        foreach (ObjectDisplay obj in FindObjectsByType<ObjectDisplay>(FindObjectsSortMode.None)) DestroyImmediate(obj.gameObject);
    }

    public void ShowObjects()
    {
        FlushObjects();
        for (int i = 0; i < map.triggers.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Trigger, i));
        for (int i = 0; i < map.signposts.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Signpost, i));
        for (int i = 0; i < map.warps.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Warp, i));
        for (int i = 0; i < map.chars.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Char, i));
    }

    public void ToggleObjects()
    {
        objectsEnabled = !objectsEnabled;
        foreach (ObjectDisplay obj in objectDisplays) obj.gameObject.SetActive(objectsEnabled);
    }

    public void SyncTilesets()
    {
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
        AssetDatabase.Refresh();
    }
}
#endif