public readonly struct LearnsetMove
{
    public readonly byte level;
    public readonly MoveID move;
    public LearnsetMove(byte Level, MoveID Move)
    {
        level = Level;
        move = Move;
    }
}