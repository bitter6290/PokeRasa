#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using static ObjectDisplay.Mode;

public class ObjectEditWindow : EditorWindow
{
    public ObjectDisplay @object;

    private bool showDelete = false;

    public void OnGUI()
    {
        GUILayout.Label("Edit Object", EditorStyles.boldLabel);
        if (@object != null)
        {
            switch (@object.mode)
            {
                case Trigger or Signpost:
                    {
                        TileTrigger target = (TileTrigger)@object.Target;
                        target.pos = EditorGUILayout.Vector2IntField("Position", target.pos);
                        target.script = (TriggerScript)EditorGUILayout.ObjectField("Script", target.script, typeof(TriggerScript), false);
                        break;
                    }
                case Warp:
                    {
                        WarpTrigger target = (WarpTrigger)@object.Target;
                        target.pos = EditorGUILayout.Vector2IntField("Position", target.pos);
                        target.destination = (MapData)EditorGUILayout.ObjectField("Destination map", target.destination, typeof(MapData), false);
                        target.destinationPos = EditorGUILayout.Vector2IntField("Destination position", target.destinationPos);
                        target.triggerType = (WarpTrigger.TriggerType)EditorGUILayout.EnumPopup(target.triggerType);
                        break;
                    }
                case Char:
                    {
                        MapChar target = (MapChar)@object.Target;
                        target.pos = EditorGUILayout.Vector2IntField("Position", target.pos);
                        target.data = (CharData)EditorGUILayout.ObjectField("Character data", target.data, typeof(CharData), false);
                        if (target.data != null)
                        {
                            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                            var editor = Editor.CreateEditor(target.data);
                            editor.OnInspectorGUI();
                        }
                        break;
                    }
            }
        }
        if (GUILayout.Button("Close")) { @object.mapHelper.ShowObjects(); Close(); }
        showDelete = GUILayout.Toggle(showDelete, "Show Delete button");
        if (showDelete && GUILayout.Button("Delete"))
        {
            switch (@object.mode)
            {
                case Trigger:
                    @object.mapHelper.OpenMap.triggers.Remove((TileTrigger)@object.Target);
                    break;
                case Signpost:
                    @object.mapHelper.OpenMap.signposts.Remove((TileTrigger)@object.Target);
                    break;
                case Warp:
                    @object.mapHelper.OpenMap.warps.Remove((WarpTrigger)@object.Target);
                    break;
                case Char:
                    @object.mapHelper.OpenMap.chars.Remove((MapChar)@object.Target);
                    break;
            }
            @object.mapHelper.ShowObjects();
            Close();
        }
    }

}


#endif