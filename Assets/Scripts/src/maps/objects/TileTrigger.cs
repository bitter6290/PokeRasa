using UnityEngine;

[System.Serializable]
public class TileTrigger : IIntPosition
{
    public Vector2Int pos;
    public TriggerScript script;
    public bool active;

    public Vector2Int Pos
    {
        get => pos;
        set => pos = value;
    }
}