using System.Collections;
using UnityEngine;
public abstract class CharScripts : ScriptableObject
{
    public abstract IEnumerator OnInteract(Player p, LoadedChar c);
    public abstract IEnumerator OnSee(Player p, LoadedChar c);
    public abstract IEnumerator OnWin(Player p, LoadedChar c);
    public abstract bool SeeCheck(Player p);
    public abstract void GetMovement(LoadedChar c);
}