using static MoveID;
public static class Learnset
{
    public static LearnsetMove[] EmptyLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, None)
    };
    public static LearnsetMove[] BulbasaurLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, Pound),
        new LearnsetMove(5, CometPunch)
    };
    public static LearnsetMove[] IvysaurLearnset = new LearnsetMove[]
    {
        new LearnsetMove(0, Teleport)
    };
    public static LearnsetMove[] CharmanderLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, DoubleSlap),
        new LearnsetMove(2, KarateChop),
        new LearnsetMove(3, SwordsDance),
        new LearnsetMove(4, Growl),
    };
    public static LearnsetMove[] VenusaurLearnset = new LearnsetMove[]
    {
        //new(0, PetalBlizzard),
        //new(1, PetalBlizzard),
        new(1, PetalDance),
        new(1, Tackle),
        new(1, Growl),
        new(1, VineWhip),
        new(1, Growth),
        new(9, LeechSeed),
        new(12, RazorLeaf),
        new(15, PoisonPowder),
        new(15, SleepPowder),
        //new(20, SeedBomb),
        new(25, TakeDown),
        new(30, SweetScent),
        new(37, Synthesis),
        //new(44, WorrySeed),
        new(51, DoubleEdge),
        new(58, SolarBeam),
    };

    public static MoveID[] GetMoves(LearnsetMove[] Learnset, int Level)
    {
        MoveID[] result = new MoveID[4]
        {
            None,
            None,
            None,
            None
        };
        int i = 0;
        while (i < Learnset.Length)
        {
            if (Learnset[i].level == 0) continue;
            if (Learnset[i].level > Level) break;
            result[i & 3] = Learnset[i].move;
            i++;
        };
        return result;
    }
}
