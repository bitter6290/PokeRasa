[System.Flags]
public enum MoveFlags
{
    none = 0,
    highCrit = 1 << 0,
    effectOnSelfOnly = 1 << 1,
    hitFlyingMon = 1 << 2,
    hitDiggingMon = 1 << 3,
    alwaysHitsInRain = 1 << 4,
    alwaysHitsInSnow = 1 << 5,
    alwaysHitsMinimized = 1 << 6,
    halfPowerInBadWeather = 1 << 7,
    mimicBypass = 1 << 8,
    cannotMimic = 1 << 9,
    makesContact = 1 << 10,
    usesProtectCounter = 1 << 11,
    soundMove = 1 << 12,
    powderMove = 1 << 13,
    bulletMove = 1 << 14,
    megaLauncherBoosted = 1 << 15,
    magicBounceAffected = 1 << 16,
    snatchAffected = 1 << 17,
    sharpnessBoosted = 1 << 18,
    gravityDisabled = 1 << 19,
    healBlockAffected = 1 << 20,
    extraFlinch10 = 1 << 21,
    punchMove = 1 << 22,
    incrementsProtectCounter = 1 << 23,
    windMove = 1 << 24,
    danceMove = 1 << 25,
}