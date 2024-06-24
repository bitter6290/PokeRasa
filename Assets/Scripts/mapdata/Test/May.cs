using System.Collections;
using UnityEngine;

namespace Scripts.Test
{
    public class May : CharScripts
    {
        public override bool LoadCheck(Player p) => true;
        public override IEnumerator OnInteract(Player p, LoadedChar c)
        {
            c.FaceAndLock();
            if (TrainerFlag.MayTest.Get())
            {
                yield return p.DoAnnouncements(new()
            { "I wish TMs were invented already..."});
            }
            c.free = true;
        }
        public override IEnumerator OnSee(Player p, LoadedChar c)
        {
            Debug.Log(TrainerFlag.MayTest.Get());
            if (!TrainerFlag.MayTest.Get())
            {
                yield return ScriptUtils.TrainerSeeSingle(
                    p, c, Team.mayTestTeam, new() { "Boo!", "Have you been to Paldea?" }, teraEnabled: true);
            }
        }
        public override IEnumerator OnWin(Player p, LoadedChar c)
        {
            yield return p.DoAnnouncements(new() { "Somehow you won..." });
            p.state = PlayerState.Free;
            TrainerFlag.MayTest.Set();
            c.doMove = false;
            c.free = true;
            p.locked = false;
        }
        public override bool SeeCheck(Player p) => !TrainerFlag.MayTest.Get();
        public override void GetMovement(LoadedChar c)
        {
            c.Actions.Enqueue(c.TryWalkNorth);
            c.Actions.Enqueue(() => c.Pause(1.0F));
        }
    }
}