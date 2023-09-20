using UnityEngine;
using System.Collections;

public delegate void ObjectScript(Player p);

public class TileTrigger
{
    public Vector2Int pos;
    public ObjectScript script;
    public bool active;
}