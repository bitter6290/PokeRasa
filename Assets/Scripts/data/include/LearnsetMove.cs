public readonly struct LearnsetMove
{
    public readonly byte level;
    public readonly ushort move;
    public LearnsetMove(byte Level, ushort Move)
    {
        level = Level;
        move = Move;
    }
}