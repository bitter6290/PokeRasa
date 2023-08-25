public static class Learnset
{
    public static LearnsetMove[] EmptyLearnset = new LearnsetMove[]
    {
        new LearnsetMove(0, MoveID.None)
    };
    public static LearnsetMove[] BulbusaurLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, MoveID.Pound),
        new LearnsetMove(5, MoveID.CometPunch)
    };
    public static LearnsetMove[] IvysaurLearnset = new LearnsetMove[]
    {
        new LearnsetMove(0, MoveID.Teleport)
    };
    public static LearnsetMove[] CharmanderLearnset = new LearnsetMove[]
    {
        new LearnsetMove(1, MoveID.DoubleSlap),
        new LearnsetMove(2, MoveID.KarateChop),
        new LearnsetMove(3, MoveID.SwordsDance),
        new LearnsetMove(4, MoveID.Growl),
    };

    public static MoveID[] GetMoves(LearnsetMove[] Learnset, byte Level)
    {
        MoveID[] result = new MoveID[4]
        {
            MoveID.None,
            MoveID.None,
            MoveID.None,
            MoveID.None
        };
        int i = 0;
        while (i < Learnset.Length){
            if (Learnset[i].level > Level) { break; }
            result[i % 4] = Learnset[i].move;
            i++;
        };
        return result;
    }
}
