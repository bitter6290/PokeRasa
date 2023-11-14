using System;
using System.Collections;
using UnityEngine;

public abstract class TriggerScript : ScriptableObject
{
    public abstract IEnumerator OnTrigger(Player p);
}