public enum TrainerFlag
{
    MayTest,
    CutTrainer,
    Count,
}

public static class TrainerFlagUtils
{
    
    public static void Set(this TrainerFlag flag) => Player.player.trainerFlags[(int)flag] = true;
    public static bool Get(this TrainerFlag flag) => Player.player.trainerFlags[(int)flag];
}

