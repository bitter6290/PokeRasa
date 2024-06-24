using TMPro;

public enum Flag
{
    //One-time items
    TestPotion,
    //Key items
    Key_Pokedex,
    Key_RunningShoes,
    Key_TMCase,
    //HM permission
    CanUseCut,
    CanUseRockSmash,

    Count,

    KeyItemStart = Key_Pokedex,
    KeyItemEnd = CanUseCut,

}

public static class FlagUtils
{
    public static void Set(this Flag flag) => Player.player.storyFlags[(int)flag] = true;
    public static bool Get(this Flag flag) => Player.player.storyFlags[(int)flag];
    public static ItemID FlagToKeyItem(this Flag flag) => flag switch
    {
        Flag.Key_TMCase => ItemID.TMCase,
        _ => ItemID.None
    };
}

