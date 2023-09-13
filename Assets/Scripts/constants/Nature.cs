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
    public static float NatureEffect(this Nature nature, int stat)
    {
        int loweredStat = (int)nature % 5;
        int raisedStat = (int)nature / 5;
        if (loweredStat == raisedStat || (stat != loweredStat && stat != raisedStat)) { return 1.0F; }
        else if (stat == loweredStat) { return 0.9F; }
        else if (stat == raisedStat) { return 1.1F; }
        return 1.0F;
    }
}