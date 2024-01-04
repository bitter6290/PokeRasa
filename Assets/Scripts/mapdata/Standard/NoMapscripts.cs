namespace Scripts.General
{
    public class NoMapscripts : MapScripts
    {
        public static void DoNothing() { return; }
        public override void BeforeLoad(Player p) => DoNothing();
        public override void OnLoad(Player p) => DoNothing();
    }
}