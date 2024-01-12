public enum Stat
{
    HP,
    Attack,
    Defense,
    SpAtk,
    SpDef,
    Speed,

    Accuracy,
    Evasion,

    CritRate,
}

public static class StatUtils
{
    public static string Name(this Stat stat) => NameTable.Stat[(int)stat];
}