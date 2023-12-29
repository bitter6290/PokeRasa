using System.Collections;
using UnityEngine;

public abstract class MapScripts : ScriptableObject
{
    public abstract void BeforeLoad(Player p); /*
                   * Executes* before* chars are unloaded; use this script to 
                   * preserve chars which would otherwise be unloaded
                   */
    public abstract void OnLoad(Player p); /*
                   * Executes after chars are loaded; use this script to
                   * make changes to tile triggers, signposts and chars
                   */
}