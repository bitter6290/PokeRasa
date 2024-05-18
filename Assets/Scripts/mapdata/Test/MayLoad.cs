using System.Collections;

namespace Scripts.Test
{
    public class MayLoad : TriggerScript
    {
        public override IEnumerator OnTrigger(Player p)
            => p.DoAnnouncements(new() { "Testing 1", "Testing 2" });
    }
}