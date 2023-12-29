using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "MapDirectory", menuName = "ScriptableObjects/MapDirectory")]
public class MapDirectory : ScriptableObject
{
    public List<MapData> maps;
}