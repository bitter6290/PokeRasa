using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Natures
{
    public const byte Hardy     = 0;
    public const byte Lonely    = 1;
    public const byte Brave     = 2;
    public const byte Adamant   = 3;
    public const byte Naughty   = 4;
    public const byte Bold      = 5;
    public const byte Docile    = 6;
    public const byte Relaxed   = 7;
    public const byte Impish    = 8;
    public const byte Lax       = 9;
    public const byte Timid     = 10;
    public const byte Hasty     = 11;
    public const byte Serious   = 12;
    public const byte Jolly     = 13;
    public const byte Naive     = 14;
    public const byte Modest    = 15;
    public const byte Mild      = 16;
    public const byte Quiet     = 17;
    public const byte Bashful   = 18;
    public const byte Rash      = 19;
    public const byte Calm      = 20;
    public const byte Gently    = 21;
    public const byte Sassy     = 22;
    public const byte Careful   = 23;
    public const byte Quirky    = 24;

    public static float NatureEffect(byte nature, byte stat)
    {
        int loweredStat = nature % 5;
        int raisedStat = nature / 5;
        if (loweredStat == raisedStat || (stat != loweredStat && stat != raisedStat)) { return 1.0F; }
        else if (stat == loweredStat) { return 0.9F; }
        else if (stat == raisedStat) { return 1.1F; }
        return 1.0F;
    }
}