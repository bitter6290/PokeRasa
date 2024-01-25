using System.Collections;

namespace Scripts.General
{
    public class InertChar : CharScripts
    {
        public override bool LoadCheck(Player _) => true;
        public override IEnumerator OnInteract(Player _, LoadedChar __) => ScriptUtils.DoNothing();
        public override IEnumerator OnSee(Player _, LoadedChar __) => ScriptUtils.DoNothing();
        public override IEnumerator OnWin(Player _, LoadedChar __) => ScriptUtils.DoNothing();
        public override bool SeeCheck(Player _) => false;
        public override void GetMovement(LoadedChar c)
        {
            return;
        }
    }
}