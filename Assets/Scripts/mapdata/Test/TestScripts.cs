using System;
using System.Collections;
using UnityEngine;

namespace Scripts.Test
{
    public class May : CharScripts
    {
        public override IEnumerator OnInteract(Player p, LoadedChar c)
        {
            c.FaceAndLock();
            if (TrainerFlag.MayTest.Get(p))
            {
                yield return p.DoAnnouncements(new()
            { "I shouldn't be fighting with baby Pokémon anyway..."});
            }
            else
            {
                yield return p.DoAnnouncements(new()
            { "Hello!"});
            }
            c.free = true;
        }
        public override IEnumerator OnSee(Player p, LoadedChar c)
        {
            Debug.Log(TrainerFlag.MayTest.Get(p));
            if (!TrainerFlag.MayTest.Get(p))
            {
                yield return ScriptUtils.TrainerSeeSingle(
                    p, c, Team.mayTestTeam, new() { "Boo!" });
            }
        }
        public override IEnumerator OnWin(Player p, LoadedChar c)
        {
            yield return p.DoAnnouncements(new() { "Somehow you won..." });
            p.state = PlayerState.Free;
            TrainerFlag.MayTest.Set(p);
            c.doMove = false;
            c.free = true;
        }
        public override bool SeeCheck(Player p) => !TrainerFlag.MayTest.Get(p);
        public override void GetMovement(LoadedChar c)
        {
            c.Actions.Enqueue(c.TryWalkNorth);
            c.Actions.Enqueue(() => c.Pause(1.0F));
        }
    }
}