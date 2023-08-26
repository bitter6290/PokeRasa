using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Convert;
using static System.Math;

[Serializable]
public class BattlePokemon
{
    public Pokemon PokemonData;

    public sbyte attackStage = 0;
    public sbyte defenseStage = 0;
    public sbyte spAtkStage = 0;
    public sbyte spDefStage = 0;
    public sbyte speedStage = 0;
    public sbyte evasionStage = 0;
    public sbyte accuracyStage = 0;
    public byte critStage = 0;

    public ushort attack;
    public ushort defense;
    public ushort spAtk;
    public ushort spDef;
    public ushort speed;

    public bool side;
    public int position;

    public bool exists;
    public bool player;

    public bool done = true;

    public bool isTarget = false;
    public bool isHit = false;
    public bool isMissed = false;
    public bool isUnaffected = false;
    public bool isCrit = false;
    public bool gotMoveEffect = false;

    public bool confused = false;
    public byte confusionCounter = 0;

    public bool getsContinuousDamage = false;
    public ContinuousDamage continuousDamageType = ContinuousDamage.None;
    public int continuousDamageSource = 0;
    public int continuousDamageTimer = 0;

    public bool thrashing = false;
    public byte thrashingTimer;
    public bool lockedInNextTurn = false;
    public MoveID lockedInMove;
    public Invulnerability invulnerability;
    public bool dontCheckPP = false;

    public bool rechargeNextTurn = false;

    public bool choseMove = false;

    public MoveID lastMoveUsed = MoveID.None;

    public bool flinched = false;

    public bool usedDefenseCurl = false;
    public bool minimized = false;

    public bool protect = false;
    public byte protectCounter = 0;

    public int toxicCounter = 0;

    public int moveDamageDone = 0;
    public int damageTaken = 0;
    public bool damageWasPhysical = false;
    public int lastDamageDoer = 0;

    public bool disabled = false;
    public MoveID disable = 0;
    public int disableTimer = 0;
    public int lastUsedMove = 0;

    public bool gotAbilityEffect = false;

    public bool biding = false;
    public int bideDamage = 0;

    public Ability ability;
    public ushort item;

    public bool hasType3 = false;
    public byte Type3 = Type.Typeless;

    public BattlePokemon(Pokemon pokemonData, bool side, int position, bool player, bool exists = true)
    {
        this.PokemonData = pokemonData;
        attack = PokemonData.attack;
        defense = PokemonData.defense;
        spAtk = PokemonData.spAtk;
        spDef = PokemonData.spDef;
        speed = PokemonData.speed;
        this.exists = exists;
        this.side = side;
        this.position = position;
        this.player = player;
        ability = Species.SpeciesTable[(int)pokemonData.species].abilities[pokemonData.whichAbility];
    }

    public MoveID GetMove(int index)
    {
        switch (index)
        {
            case 1:
                return PokemonData.move1;
            case 2:
                return PokemonData.move2;
            case 3:
                return PokemonData.move3;
            case 4:
                return PokemonData.move4;
            default:
                return MoveID.None;
        }
    }

    public bool HasType(byte type)
    {
        return Type1 == type
            || Type2 == type
            || (hasType3 && Type3 == type);
    }

    public byte Type1 => PokemonData.SpeciesData.type1;

    public byte Type2 => PokemonData.SpeciesData.type2;

    public static float StageToModifierNormal(sbyte stage)
    {
        return stage < 0 ? 2.0F / (2 - stage) : (2 + stage) / 2.0F;
    }

    public static float StageToModifierAccEva(sbyte stage)
    {
        return stage < 0 ? 3.0F / (3 - stage) : (3 + stage) / 3.0F;
    }

    public void CalculateStats()
    {
        attack = ToUInt16(PokemonData.attack * StageToModifierNormal(attackStage));
        defense = ToUInt16(PokemonData.defense * StageToModifierNormal(defenseStage));
        spAtk = ToUInt16(PokemonData.spAtk * StageToModifierNormal(spAtkStage));
        spDef = ToUInt16(PokemonData.spDef * StageToModifierNormal(spDefStage));
        speed = ToUInt16(PokemonData.speed * StageToModifierNormal(speedStage));
    }

    public static BattlePokemon MakeEmptyBattleMon(bool side, int position)
    {
        Pokemon emptyMon = Pokemon.MakeEmptyMon;
        return new BattlePokemon(emptyMon, side, position, false, false);
    }

    public int RaiseStat(byte statID, int amount)
    {
        switch (statID)
        {
            case StatID.Attack:
                if (attackStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - attackStage, amount);
                    attackStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.Defense:
                if (defenseStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - defenseStage, amount);
                    defenseStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.SpAtk:
                if (spAtkStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - spAtkStage, amount);
                    spAtkStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.SpDef:
                if (spDefStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - spDefStage, amount);
                    spDefStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.Speed:
                if (speedStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - speedStage, amount);
                    speedStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.Accuracy:
                if (accuracyStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - accuracyStage, amount);
                    accuracyStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.Evasion:
                if (evasionStage == 6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 - evasionStage, amount);
                    evasionStage += raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            default:
                return 0;
        }
    }

    public int LowerStat(byte statID, int amount)
    {
        switch (statID)
        {
            case StatID.Attack:
                if (attackStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte loweredStages = (sbyte)Min(attackStage + 6, amount);
                    attackStage -= loweredStages;
                    CalculateStats();
                    return loweredStages;
                }
            case StatID.Defense:
                if (defenseStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte loweredStages = (sbyte)Min(defenseStage + 6, amount);
                    defenseStage -= loweredStages;
                    CalculateStats();
                    return loweredStages;
                }
            case StatID.SpAtk:
                if (spAtkStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte loweredStages = (sbyte)Min(spAtkStage + 6, amount);
                    spAtkStage -= loweredStages;
                    CalculateStats();
                    return loweredStages;
                }
            case StatID.SpDef:
                if (spDefStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte loweredStages = (sbyte)Min(spDefStage + 6, amount);
                    spDefStage -= loweredStages;
                    CalculateStats();
                    return loweredStages;
                }
            case StatID.Speed:
                if (speedStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte loweredStages = (sbyte)Min(speedStage + 6, amount);
                    speedStage -= loweredStages;
                    CalculateStats();
                    return loweredStages;
                }
            case StatID.Accuracy:
                if (accuracyStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 + accuracyStage, amount);
                    accuracyStage -= raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            case StatID.Evasion:
                if (evasionStage == -6)
                {
                    return 0;
                }
                else
                {
                    sbyte raisedStages = (sbyte)Min(6 + evasionStage, amount);
                    evasionStage -= raisedStages;
                    CalculateStats();
                    return raisedStages;
                }
            default:
                return 0;
        }
    }

}
