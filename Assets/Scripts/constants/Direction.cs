public enum Direction
{
    N,
    W,
    S,
    E,
}

public static class DirectionUtils
{
    public static Direction Opposite(this Direction dir) => dir switch
    {
        Direction.N => Direction.S,
        Direction.S => Direction.N,
        Direction.W => Direction.E,
        Direction.E => Direction.W,
        _ => throw new System.Exception("Invalid direction to invert")
    };
}