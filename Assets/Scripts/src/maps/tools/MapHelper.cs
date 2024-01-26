#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;
using System.Collections;
using static UnityEngine.GraphicsBuffer;
using System;

[ExecuteInEditMode]
public class MapHelper : MapManager
{
    public Tilemap collisionMap;
    public Tilemap wildDataMap;

    public ProjectData projectData;

    [HideInInspector]
    public bool open;
    public void ForceOpen(MapData map) { open = true; openMap = map; }
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
    public List<TileBase> missingTiles;

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
            while (true)
            {
                missingTiles = new();
                MapWriter writer = new(this);
                if (writer.Write(false)) return true;
                else if (EditorUtility.DisplayDialog("Missing tiles detected",
                    "Some tiles in the scene are missing from the tileset, add them before saving?", "Yes", "No"))
                {
                    foreach (TileBase tile in missingTiles)
                    {
                        openMap.tileset.Tiles.Add(tile);
                    }
                }
                else if (EditorUtility.DisplayDialog("Save anyway?", "Save anyway? Missing tiles will not be saved.", "Yes", "No"))
                {
                    writer.Write(true);
                    return true;
                }
                else return false;
            }
        }
    }

    public new void ReadMap()
    {
        if (open && !CheckUnsaved()) return;
        var openMapWindow = ScriptableObject.CreateInstance<OpenMapWindow>();
        openMapWindow.helper = this;
        openMapWindow.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
        openMapWindow.ShowPopup();
    }
    public void TryToOpenMap(MapData mapData)
    {
        if (mapData == null)
        {
            EditorUtility.DisplayDialog("No map selected", "No map was selected!","OK");
            return;
        }
        if (mapData == openMap)
        {
            EditorUtility.DisplayDialog("Map already open", "Can't open map, selected map is already open.", "OK");
            return;
        }
        else
        {
            openMap = mapData;
            open = true;
            if (mapData.MapTiles.Length == 0)
            {
                MapReader.CreateNewMapV1(this);
            }
            else
            {
                MapReader.ReadForEditingV1(this);
            }
            ShowObjects();
        }
    }

    public bool CheckUnsaved()
    {
        return EditorUtility.DisplayDialog("Map is not saved", "Map is not saved. Save now?", "Yes", "No")
            ? WriteMap()
            : EditorUtility.DisplayDialog("Discard unsaved work?", "Really discard unsaved work?", "Yes", "Cancel");
    }

    public void CloseMap(bool saved = false)
    {
        if (open && !saved && !CheckUnsaved())
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
        if (open && !CheckUnsaved()) return;
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

    public void MapEditWindow()
    {
        var mapEditWindow = ScriptableObject.CreateInstance<MapEditWindow>();
        mapEditWindow.helper = this;
        mapEditWindow.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
        mapEditWindow.ShowPopup();
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
        for (int i = 0; i < openMap.triggers.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Trigger, i));
        for (int i = 0; i < openMap.signposts.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Signpost, i));
        for (int i = 0; i < openMap.warps.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Warp, i));
        for (int i = 0; i < openMap.chars.Count; i++)
            objectDisplays.Add(ObjectDisplay.Create(this, ObjectDisplay.Mode.Char, i));
    }

    public void ToggleObjects()
    {
        objectsEnabled = !objectsEnabled;
        foreach (ObjectDisplay obj in objectDisplays) obj.gameObject.SetActive(objectsEnabled);
    }

    public void NewChar()
    {
        if (!open) return;
        var newCharWindow = ScriptableObject.CreateInstance<NewCharWindow>();
        newCharWindow.helper = this;
        newCharWindow.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
        newCharWindow.ShowPopup();
    }
}
#endif