using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Target
{
    public const int None = 0;
    public const int Opponent = 1 << 0; //Can hit an opponent
    public const int Ally = 1 << 1; //Can hit an ally
    public const int Self = 1 << 2; //Only affects the user, or affects everyone
    public const int Ranged = 1 << 3; //Can hit accross the field in a triple battle
    public const int Spread = 1 << 4; //Targets all possible mons, not just one
    public const int All = 1 << 5; //Targets every mon
    public const int Field = 1 << 6; //Affects the field and doesn't use targeting

    public const int Single = Opponent + Ally;
    public const int Surrounding = Opponent + Ally + Spread;
}