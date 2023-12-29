using UnityEngine;

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

    public static Vector2Int Vector(this Direction dir) => dir switch
    {
        Direction.N => Vector2Int.up,
        Direction.S => Vector2Int.down,
        Direction.W => Vector2Int.left,
        Direction.E => Vector2Int.right,
        _ => throw new System.Exception("Called .Vector on an invalid direction")
    };
}