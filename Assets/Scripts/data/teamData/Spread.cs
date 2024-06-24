public static class Spread
{
    public static EvIvSpread random = new()
    {
        real = false,
    };

    public static EvIvSpread attackHP128 = new()
    {
        ivHP = 31,
        ivAttack = 31,
        ivDefense = 15,
        ivSpAtk = 0,
        ivSpDef = 15,
        ivSpeed = 15,
        evAttack = 128,
        evHP = 128
    };

    public static EvIvSpread spAtkHP128 = new()
    {
        ivHP = 31,
        ivAttack = 0,
        ivDefense = 15,
        ivSpAtk = 31,
        ivSpDef = 15,
        ivSpeed = 15,
        evSpAtk = 128,
        evHP = 128,
    };

    public static EvIvSpread atkSpeed128 = new()
    {
        ivHP = 15,
        ivAttack = 31,
        ivDefense = 15,
        ivSpAtk = 0,
        ivSpDef = 15,
        ivSpeed = 15,
        evAttack = 128,
        evSpeed = 128
    };

    public static EvIvSpread spAtkSpeed128 = new()
    {
        ivHP = 15,
        ivAttack = 0,
        ivDefense = 15,
        ivSpAtk = 31,
        ivSpDef = 15,
        ivSpeed = 15,
        evSpAtk = 128,
        evSpeed = 128
    };
}