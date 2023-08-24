public static class StatID
{
    public const byte HP = 0;
    public const byte Attack = 1;
    public const byte Defense = 2;
    public const byte SpAtk = 3;
    public const byte SpDef = 4;
    public const byte Speed = 5;

    public const byte Accuracy = 6;
    public const byte Evasion = 7;
    public const byte CritRate = 8;

    public static string[] statName = new string[8]
    {
        "HP",
        "Attack",
        "Defense",
        "Special Attack",
        "Special Defense",
        "Speed",
        "accuracy",
        "evasion",
    };
}