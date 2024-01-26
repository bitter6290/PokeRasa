#if UNITY_EDITOR
using System;
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
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        if (GUILayout.Button("Edit Map Data"))
        {
            mapHelper.MapEditWindow();
        }
        if (GUILayout.Button("Update Connections"))
        {
            mapHelper.UpdateConnections();
        }
        if (GUILayout.Button("Reflect Connections"))
        {
            mapHelper.ReflectConnections();
        }
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        if (GUILayout.Button("New Trigger"))
        {
            mapHelper.OpenMap.triggers.Add(new());
            mapHelper.ShowObjects();
        }
        if (GUILayout.Button("New Signpost"))
        {
            mapHelper.OpenMap.signposts.Add(new());
            mapHelper.ShowObjects();
        }
        if (GUILayout.Button("New Warp"))
        {
            mapHelper.OpenMap.warps.Add(new());
            mapHelper.ShowObjects();
        }
        if (GUILayout.Button("New Object"))
        {
            var newObjectWindow = CreateInstance<NewCharWindow>();
            newObjectWindow.helper = mapHelper;
            newObjectWindow.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
            newObjectWindow.ShowPopup();
        }
        if (GUILayout.Button("Update Objects"))
        {
            mapHelper.ShowObjects();
        }
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
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
                            switch (e.button)
                            {
                                case 0:
                                    mapHelper.draggingObject = true;
                                    mapHelper.clickedObjectDisplay = display;
                                    e.Use();
                                    return;
                                case 1:
                                    var editObjectPopup = CreateInstance<ObjectEditWindow>();
                                    editObjectPopup.@object = display;
                                    editObjectPopup.position = new Rect(Screen.width / 6, Screen.height / 6, 2 * Screen.width / 3, 2 * Screen.width / 3);
                                    editObjectPopup.ShowPopup();
                                    e.Use();
                                    return;
                            }
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