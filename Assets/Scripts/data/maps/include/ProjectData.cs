#if UNITY_EDITOR
using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public class ProjectData
{
    public int nextMapID = 0;
    public List<int> freeMapIDs = new();
}
#endif