using static System.Math;

public static class XP
{
    public static int ErraticXP(int level)
    {
        return level switch
        {
            < 50 => level * level * level * (100 - level) / 50,
            < 68 => level * level * level * (150 - level) / 100,
            < 98 => level * level * level * ((1911 - 10 * level) / 3) / 500,
            _ => level * level * level * (160 - level) / 100,
        };
    }
    public static int FastXP(int level)
    {
        return 4 * level * level * level / 5;
    }
    public static int MediumFastXP(int level)
    {
        return level * level * level;
    }
    public static int MediumSlowXP(int level)
    {
        return Max(0, (int)(level * (100 + (level * ((level * 1.2F) - 15)))) - 140);
    }
    public static int SlowXP(int level)
    {
        return 5 * level * level * level / 4;
    }
    public static int FluctuatingXP(int level)
    {
        return level switch
        {
            >= 36 => level * level * level * ((level / 2) + 32) / 50,
            >= 15 => level * level * level * (level + 14) / 50,
            _ => level * level * level * (((level + 1) / 3) + 24) / 50
        };
    }
    public static int LevelToXP(int level, XPClass XPClass)
    {
        switch (XPClass)
        {
            case XPClass.Erratic: return ErraticXP(level);
            case XPClass.Fast: return FastXP(level);
            case XPClass.MediumFast: return MediumFastXP(level);
            case XPClass.MediumSlow: return MediumSlowXP(level);
            case XPClass.Slow: return SlowXP(level);
            case XPClass.Fluctuating: return FluctuatingXP(level);
        }
        return 0;
    }
}