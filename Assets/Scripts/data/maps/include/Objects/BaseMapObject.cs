using System.Collections;
using UnityEngine;

public delegate IEnumerator ObjectScript(Player p);

public class BaseMapObject
{
    public Vector2Int pos;
}