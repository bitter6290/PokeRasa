public enum TrainerFlag
{
    MayTest,
    Count,
}

public static class TrainerFlagUtils
{
    public static void Set(this TrainerFlag flag, Player p) => p.trainerFlags[(int)flag] = true;
    public static bool Get(this TrainerFlag flag, Player p) => p.trainerFlags[(int)flag];
}

