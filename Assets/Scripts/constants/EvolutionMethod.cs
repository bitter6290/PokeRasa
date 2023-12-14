using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EvolutionMethod
{
    LevelUp,
    EvolutionItem,
    ItemFemaleOnly,
    ItemMaleOnly,
    Trade,
    TradeItem,
    TradeForMon,
    Friendship,
    FriendshipDay,
    FriendshipNight,
    LevelUpHighAttack,
    LevelUpHighDefense,
    LevelUpEqualAttackDefense,
    LevelUpOddID,
    LevelUpEvenID,
    LevelUpMagneticField,
    LevelUpMaxBeauty,
    LevelUpWithMove,
    LevelUpWithItemDay, //Happiny
    LevelUpWithItemNight,
    LevelUpWithMonInParty, //Mantyke
    LevelUpWithDarkInParty,
    LevelUpMakeShedinja, //Nincada
    LevelUpMaleOnly,
    LevelUpFemaleOnly,
    LevelUpsideDown, //Inkay, don't know how to implement this
    LevelUpDay,
    LevelUpEvening,
    LevelUpNight,
    LevelUpRain,

    Incidental, //Shedinja

    Never,
}