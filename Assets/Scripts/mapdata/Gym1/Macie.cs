using System.Collections;

namespace Scripts.Gym1
{
    public class Macie : CharScripts
    {
        public override bool LoadCheck(Player p) => true;
        public override bool SeeCheck(Player p) => false;
        public override IEnumerator OnInteract(Player p, LoadedChar c)
        {
            c.FaceAndLock();
            if (FlagUtils.Get(Flag.CanUseCut))
            {
                yield return p.DoAnnouncements(new() {"Be careful with the trees around here.", "Some of them aren't trees at all!"});
            }
            else
            {
                yield return p.DoAnnouncements(new() {"Aha!","Wait, no. Greetings! I'm Macie and I'm the Gym Leader in town.","We're still working on renovations, but I guess you need my badge. Fine! Let's battle!"});
                p.StartCoroutine(p.StartSingleTrainerBattle(c, Team.macieTeam));
            }
        }
        public override void GetMovement(LoadedChar c) {}
        public override IEnumerator OnWin(Player p, LoadedChar c)
        {
            yield return p.DoAnnouncements(new() {"Whew! What a fight.","You win, so you can have this."});
            FlagUtils.Set(Flag.CanUseCut);
            yield return p.FaceSouth();
            yield return p.DoAnnouncements(new(){"Got the Grove Badge!"});
        }
        public override IEnumerator OnSee(Player p, LoadedChar c) => ScriptUtils.DoNothing();
    }
}