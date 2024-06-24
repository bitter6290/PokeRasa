using System.Collections;

namespace Scripts.General
{
    public class RockSmashRock : CharScripts
    {
        public override bool LoadCheck(Player _) => true;
        public override IEnumerator OnInteract(Player p, LoadedChar chara)
        {
            const int noMons = 63;
            yield return p.announcer.AnnouncementUp();
            yield return p.announcer.Announce("This rock looks like it can be broken!");
            if (p.storyFlags[(int)Flag.CanUseRockSmash])
            {
                int smashingMon = noMons;
                for (int i = 0; i < 6; i++)
                {
                    if (p.Party[i].exists && p.Party[i].HasMove(MoveID.RockSmash))
                    {
                        smashingMon = i;
                        break;
                    }
                }
                if (smashingMon != noMons)
                {
                    yield return p.announcer.Announce("Would you like to use Rock Smash?");
                    DataStore<int> store = new();
                    yield return p.DoChoiceMenu(store, ScriptUtils.binaryChoice, 0);
                    if (store == 1)
                    {
                        yield return p.announcer.Announce(p.Party[smashingMon].MonName + " used Rock Smash!");
                        yield return p.announcer.AnnouncementDown();
                        yield return chara.Break;
                        yield break;
                    }
                }
            }
            yield return p.announcer.AnnouncementDown();
        }
        public override IEnumerator OnSee(Player _, LoadedChar __) => ScriptUtils.DoNothing();
        public override IEnumerator OnWin(Player _, LoadedChar __) => ScriptUtils.DoNothing();
        public override bool SeeCheck(Player _) => false;
        public override void GetMovement(LoadedChar c)
        {
            return;
        }
    }
}