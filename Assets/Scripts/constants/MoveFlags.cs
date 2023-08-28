public static class MoveFlags
{
    public const int none = 0;
    public const int highCrit = 1 << 0;
    public const int effectOnSelfOnly = 1 << 1;
    public const int hitFlyingMon = 1 << 2;
    public const int hitDiggingMon = 1 << 3;
    public const int alwaysHitsInRain = 1 << 4;
    public const int alwaysHitsInSnow = 1 << 5;
    public const int alwaysHitsMinimized = 1 << 6;
    public const int halfPowerInBadWeather = 1 << 7;
    public const int mimicBypass = 1 << 8;
    public const int cannotMimic = 1 << 9;
}