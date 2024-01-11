using UnityEngine;

[System.Serializable]
public class WarpTrigger : IIntPosition
{
    public enum TriggerType
    {
        WalkOn,
        WalkNorthFrom,
        WalkEastFrom,
        WalkWestFrom,
        WalkSouthFrom
    }
    public Vector2Int pos;
    public MapData destination;
    public Vector2Int destinationPos;
    public bool active;
    public TriggerType triggerType;

    public Vector2Int Pos
    {
        get => pos;
        set => pos = value;
    }
}