using System;
using System.Collections;

namespace Scripts.Test2
{
    public class Test2MartTrigger : TriggerScript
    {
        private static ItemID[] items = new ItemID[]
        {
            ItemID.PokeBall,
            ItemID.Potion,
            ItemID.Venusaurite,
            ItemID.GrassiumZ
        };
        public override IEnumerator OnTrigger(Player p) => ScriptUtils.MartScript(p, items);
    }
}