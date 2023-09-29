using UnityEngine;

[System.Serializable]
public class TileTrigger
{
    public Vector2Int pos;
    public ScriptDomain scriptDomain;
    public string scriptName;
    public ObjectScript script => AllScripts.ObjectScripts[scriptDomain][scriptName];
    public bool active;
}