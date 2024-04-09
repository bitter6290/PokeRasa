public enum Status : byte
{
    None,
    Paralysis,
    Sleep,
    Poison,
    ToxicPoison,
    Burn,
    Freeze,
}

public static class StatusUtils
{
    public static string HealString(this Status status)
    {
        return status switch
        {
            Status.Burn => " was healed of its burn.",
            Status.Poison or Status.ToxicPoison => " was cured of its poisoning.",
            Status.Paralysis => " was cured of its paralysis.",
            Status.Freeze => " was thawed out.",
            Status.Sleep => " woke up!",
            _ => " Invalid Status"
        };
    }
}