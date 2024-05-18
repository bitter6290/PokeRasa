using System.Collections;

namespace Scripts.Test
{
    public class Announcement : TriggerScript
    {
        public override IEnumerator OnTrigger(Player p)
            => p.DoAnnouncements(new() { "Testing 1", "Testing 2" });
    }
}