using static System.Math;

public struct StatStruct
{
    public int attack;
    public int defense;
    public int spAtk;
    public int spDef;
    public int speed;
    public int accuracy;
    public int evasion;
    public int critRate;
}
public static class StatStructUtils
{
    public static StatStruct RemoveBuffs(this StatStruct a)
    {
        return new()
        {
            attack = Min(a.attack, 0),
            defense = Min(a.defense, 0),
            spAtk = Min(a.spAtk, 0),
            spDef = Min(a.spDef, 0),
            speed = Min(a.speed, 0),
            accuracy = Min(a.accuracy, 0),
            evasion = Min(a.evasion, 0)
        };
    }
    public static StatStruct StealBuffs(this StatStruct stealing, StatStruct stolen)
    {
        return new()
        {
            attack = Min(6, stealing.attack + Max(0, stolen.attack)),
            defense = Min(6, stealing.defense + Max(0, stolen.defense)),
            spAtk = Min(6, stealing.spAtk + Max(0, stolen.spAtk)),
            spDef = Min(6, stealing.spDef + Max(0, stolen.spDef)),
            speed = Min(6, stealing.speed + Max(0, stolen.speed)),
            accuracy = Min(6, stealing.accuracy + Max(0, stolen.accuracy)),
            evasion = Min(6, stealing.evasion + Max(0, stolen.evasion)),
        };
    }
}