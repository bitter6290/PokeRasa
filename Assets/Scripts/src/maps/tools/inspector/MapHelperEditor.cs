#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapHelper))]
public class MapHelperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MapHelper mapHelper = (MapHelper)target;

        if (GUILayout.Button("Create Map"))
        {
            mapHelper.CreateMap();
        }
        if (GUILayout.Button("Open Map"))
        {
            mapHelper.ReadMap();
        }
        if (GUILayout.Button("Save Map"))
        {
            mapHelper.WriteMap();
        }
        if (GUILayout.Button("Close Map"))
        {
            mapHelper.CloseMap();
        }
        if (GUILayout.Button("Save and Close Map"))
        {
            mapHelper.SaveAndCloseMap();
        }
        if (GUILayout.Button("Update Connections"))
        {
            mapHelper.UpdateConnections();
        }
        if (GUILayout.Button("Reflect Connections"))
        {
            mapHelper.ReflectConnections();
        }
        if (GUILayout.Button("Sync Tiles"))
        {
            mapHelper.SyncTilesets();
        }
        if (GUILayout.Button("New Trigger"))
        {
            mapHelper.map.triggers.Add(new());
            mapHelper.ShowObjects();
        }
        if (GUILayout.Button("New Signpost"))
        {
            mapHelper.map.signposts.Add(new());
            mapHelper.ShowObjects();
        }
        if (GUILayout.Button("Update Objects"))
        {
            mapHelper.ShowObjects();
        }
        mapHelper.collisionMap.gameObject.SetActive(GUILayout.Toggle(mapHelper.collisionMap.isActiveAndEnabled, "Show Collision"));
        mapHelper.wildDataMap.gameObject.SetActive(GUILayout.Toggle(mapHelper.wildDataMap.isActiveAndEnabled, "Show Encounters"));
        if (GUILayout.Button("Toggle Objects"))
        {
            mapHelper.ToggleObjects();
        }
    }

    public void OnSceneGUI()
    {
        MapHelper mapHelper = (MapHelper)target;
        Event e = Event.current;
        Camera camera;
        Vector3Int cellCoords;
        Vector2Int finalCoords;
        if (e != null)
        {
            switch (e.type)
            {
                case EventType.KeyDown when e.modifiers is EventModifiers.None:
                    switch (e.keyCode)
                    {
                        case KeyCode.C: mapHelper.collisionMap.gameObject.SetActive(!mapHelper.collisionMap.gameObject.activeSelf); e.Use(); break;
                        case KeyCode.W: mapHelper.wildDataMap.gameObject.SetActive(!mapHelper.wildDataMap.gameObject.activeSelf); e.Use(); break;
                        case KeyCode.O: mapHelper.ToggleObjects(); e.Use(); break;
                    }
                    break;
                case EventType.MouseDown when !mapHelper.draggingObject && mapHelper.objectsEnabled:
                    camera = SceneView.currentDrawingSceneView.camera;
                    cellCoords = mapHelper.collisionMap.WorldToCell(camera.ScreenToWorldPoint(new(2 * e.mousePosition.x, camera.pixelHeight - 2 * e.mousePosition.y)));
                    finalCoords = new(cellCoords.x, cellCoords.y);
                    foreach (ObjectDisplay display in mapHelper.objectDisplays)
                    {
                        if (display.Pos == finalCoords)
                        {
                            mapHelper.draggingObject = true;
                            mapHelper.clickedObjectDisplay = display;
                            e.Use();
                            break;
                        }
                    }
                    break;
                case EventType.MouseDrag when mapHelper.draggingObject && mapHelper.objectsEnabled:
                    camera = SceneView.currentDrawingSceneView.camera;
                    cellCoords = mapHelper.collisionMap.WorldToCell(camera.ScreenToWorldPoint(new(2 * e.mousePosition.x, camera.pixelHeight - 2 * e.mousePosition.y)));
                    finalCoords = new(cellCoords.x, cellCoords.y);
                    mapHelper.clickedObjectDisplay.Reposition(finalCoords);
                    break;
                case EventType.MouseUp when mapHelper.objectsEnabled:
                    mapHelper.draggingObject = false;
                    break;
                default: break;
            }
        }
    }
}
#endif