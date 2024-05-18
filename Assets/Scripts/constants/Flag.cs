public enum Flag
{
    //One-time items
    TestPotion,
    //Key items
    Key_Pokedex,
    Key_RunningShoes,
    //HM flags
    HM_Cut,
    HM_RockSmash,
    HM_Surf,

    Count,

    KeyItemStart = Key_Pokedex,
    HMStart = HM_Cut,

}

public static class FlagUtils
{
    public static void Set(this Flag flag, Player p) => p.storyFlags[(int)flag] = true;
    public static bool Get(this Flag flag, Player p) => p.storyFlags[(int)flag];
}

