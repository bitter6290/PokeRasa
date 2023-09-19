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
    public const int makesContact = 1 << 10;
    public const int usesProtectCounter = 1 << 11;
    public const int soundMove = 1 << 12;
    public const int powderMove = 1 << 13;
    public const int bulletMove = 1 << 14;
    public const int megaLauncherBoosted = 1 << 15;
    public const int magicBounceAffected = 1 << 16;
    public const int snatchAffected = 1 << 17;
    public const int sharpnessBoosted = 1 << 18;
    public const int gravityDisabled = 1 << 19;
}