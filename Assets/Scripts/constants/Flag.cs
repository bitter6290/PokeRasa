using System;
public enum Flag
{
    Count,
}

public static class FlagUtils
{
    public static void Set(this Flag flag, Player p) => p.storyFlags[(int)flag] = true;
    public static bool Get(this Flag flag, Player p) => p.storyFlags[(int)flag];
}

