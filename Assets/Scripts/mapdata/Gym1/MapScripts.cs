using System;

namespace Scripts.Gym1
{
    public class Gym1Scripts : MapScripts
    {
        public override void BeforeLoad(Player p) => ScriptUtils.DoNothing();
        public override void OnLoad(Player p) => p.StartCoroutine(p.GetChar("cuttrainer").FaceSouth());
    }
}