using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TargetID
{
    public const byte Opponent = 1 >> 0;
    public const byte Ally = 1 << 1;
    public const byte Self = 1 << 2;
    public const byte Ranged = 1 << 3;
    public const byte Spread = 1 << 4;
    public const byte Field = 1 << 5;
}