using System.Collections;

namespace Scripts.Gym1
{
    public class CutTrainer : CharScripts
    {
        public override IEnumerator OnInteract(Player p, LoadedChar c)
        {
            c.FaceAndLock();
            if (TrainerFlag.CutTrainer.Get())
            {
                yield return p.DoAnnouncements(new(){"You can use that HM on your Pokémon, but you'll have to beat Macie before you use it outside of battle."});
            }
            c.free = true;
        }
        public override IEnumerator OnSee(Player p, LoadedChar c) => ScriptUtils.TrainerSeeSingle(p, c, Team.cutTrainerTeam,
            new() {"Lights... Camera... Action!"}, false, false);
        public override IEnumerator OnWin(Player p, LoadedChar c)
        {
            yield return p.DoAnnouncements(new(){"Cut!", "OK, you can have this."});
            yield return p.GetItem(ItemID.TMCase, 1);
            yield return p.DoAnnouncements(new(){"You can have this, too."});
            yield return p.GetHM(TMID.HM_Cut);
            TMID.SwordsDance.Set(); //Testing
            p.state = PlayerState.Free;
            TrainerFlag.CutTrainer.Set();
            c.doMove = false;
            c.free = true;
            p.locked = false;
        }
        public override bool SeeCheck(Player p) => !TrainerFlag.CutTrainer.Get();
        public override void GetMovement(LoadedChar c) {}
        public override bool LoadCheck(Player p) => true;
    }
}
