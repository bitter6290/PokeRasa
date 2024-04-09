using static MoveID;
public static class Learnset
{
    public static LearnsetMove[] EmptyLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, Splash), //Make sure things work
    };
    public static LearnsetMove[] BulbasaurLearnset = new LearnsetMove[]
    {
        new(1, Tackle),
        new(1, Growl),
        new(3, VineWhip),
        new(6, Growth),
        new(9, LeechSeed),
        new(12, RazorLeaf),
        new(15, PoisonPowder),
        new(15, SleepPowder),
        new(18, SeedBomb),
        new(21, TakeDown),
        new(24, SweetScent),
        new(27, Synthesis),
        new(30, WorrySeed),
        new(33, PowerWhip),
        new(36, SolarBeam)
    };
    public static LearnsetMove[] IvysaurLearnset = new LearnsetMove[]
    {
        new(0, Teleport)
    };
    public static LearnsetMove[] CharmanderLearnset = new LearnsetMove[]
    {
        new(1, DoubleSlap),
        new(2, KarateChop),
        new(3, SwordsDance),
        new(4, Growl),
    };
    public static LearnsetMove[] VenusaurLearnset = new LearnsetMove[]
    {
        new(0, PetalBlizzard),
        new(1, PetalBlizzard),
        new(1, PetalDance),
        new(1, Tackle),
        new(1, Growl),
        new(1, VineWhip),
        new(1, Growth),
        new(9, LeechSeed),
        new(12, RazorLeaf),
        new(15, PoisonPowder),
        new(15, SleepPowder),
        new(20, SeedBomb),
        new(25, TakeDown),
        new(30, SweetScent),
        new(37, Synthesis),
        new(44, WorrySeed),
        new(51, DoubleEdge),
        new(58, SolarBeam),
    };

    public static MoveID[] GetMoves(LearnsetMove[] learnset, int level)
    {
        MoveID[] result = new MoveID[4]
        {
            None,
            None,
            None,
            None
        };
        int i = 0;
        while (i < learnset.Length)
        {
            if (learnset[i].level == 0) continue;
            if (learnset[i].level > level) break;
            result[i & 3] = learnset[i].move;
            i++;
        };
        return result;
    }
}
