using static System.Convert;
using static System.Math;

public static class XP
{
    public static int ErraticXP(byte level)
    {
        if(level >= 50)
        {
            if (level < 68) { return ToInt32(level * level * level * (150 - level) / 100); }
            else if (level < 98) { return ToInt32(level * level * level * ((1911 - 10 * level) / 3) / 500); }
            return ToInt32(level * level * level * (160 - level) / 100);
        }
        return ToInt32(level * level * level * (100 - level) / 50);
    }
    public static int FastXP(byte level)
    {
        return ToInt32(4 * level * level * level / 5);
    }
    public static int MediumFastXP (byte level)
    {
        return ToInt32(level * level * level);
    }
    public static int MediumSlowXP (byte level)
    {
        return ToInt32(Max(0,level * (100 + level * ((6 * level) / 5 - 15)) - 140));
    }
    public static int SlowXP (byte level)
    {
        return ToInt32(5 * level * level * level / 4);
    }
    public static int FluctuatingXP (byte level)
    {
        if (level >= 15)
        {
            if (level < 36) { return ToInt32(level * level * level * (level + 14) / 50); }
            return ToInt32(level * level * level * (level / 2 + 32) / 50);
        }
        return ToInt32(level * level * level * ((level + 1) / 3 + 24) / 50);
    }
    public static int LevelToXP(byte level, byte XPClass)
    {
        switch (XPClass)
        {
            case XPClassID.Erratic: return ErraticXP(level);
            case XPClassID.Fast: return FastXP(level);
            case XPClassID.MediumFast: return MediumFastXP(level);
            case XPClassID.MediumSlow: return MediumSlowXP(level);
            case XPClassID.Slow: return SlowXP(level);
            case XPClassID.Fluctuating: return FluctuatingXP(level);
        }
        return 0;
    }
}