using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Nature
{
    Hardy,
    Lonely,
    Brave,
    Adamant,
    Naughty,
    Bold,
    Docile,
    Relaxed,
    Impish,
    Lax,
    Timid,
    Hasty,
    Serious,
    Jolly,
    Naive,
    Modest,
    Mild,
    Quiet,
    Bashful,
    Rash,
    Calm,
    Gentle,
    Sassy,
    Careful,
    Quirky,

    Any = 63
}

public static class NatureUtils
{
    public static float NatureEffect(this Nature nature, Stat stat)
    {
        int statNum = stat switch
        {
            Stat.Attack => 0,
            Stat.Defense => 1,
            Stat.Speed => 2,
            Stat.SpAtk => 3,
            Stat.SpDef => 4,
            _ => throw new Exception("Invalid stat for nature calculation")
        };
        int loweredStat = (int)nature % 5;
        int raisedStat = (int)nature / 5;
        if (loweredStat == raisedStat || (statNum != loweredStat && statNum != raisedStat)) { return 1.0F; }
        else if (statNum == loweredStat) { return 0.9F; }
        else if (statNum == raisedStat) { return 1.1F; }
        return 1.0F;
    }
}