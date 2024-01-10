using UnityEngine;
using System.Collections;

namespace Scripts.General
{
    public class PCScripts : TriggerScript
    {
        public override IEnumerator OnTrigger(Player p) => p.DoBox();
    }
}