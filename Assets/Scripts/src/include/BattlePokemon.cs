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

    public int attack;
    public int defense;
    public int spAtk;
    public int spDef;
    public int speed;

    public bool side;
    public int position;
    public int index;

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
    public MoveID disabledMove = 0;
    public int disableTimer = 0;

    public bool gotAbilityEffect = false;

    public bool seeded = false;
    public int seedingSlot = 0;

    public bool biding = false;
    public int bideDamage = 0;

    public bool hasSubstitute = false;
    public int substituteHP = 0;

    public bool isEnraged = false;

    public bool isTransformed = false;
    public Pokemon transformedMon = Pokemon.MakeEmptyMon;

    public Ability ability;
    public int item;

    public byte newType1 = Type.Typeless;
    public byte newType2 = Type.Typeless;
    public bool typesOverriden = false;

    public bool hasType3 = false;
    public byte Type3 = Type.Typeless;

    public bool mimicking = false;
    public int mimicSlot = 0;
    public MoveID mimicMove = MoveID.None;
    public byte mimicPP = 0;
    public byte mimicMaxPP = 0;

    public MoveID lastTargetedMove = MoveID.None;

    public BattlePokemon(Pokemon pokemonData, bool side, int position, bool player, bool exists = true)
    {
        pokemonData.onField = true;
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

    public SpeciesID apparentSpecies => isTransformed ? transformedMon.species : PokemonData.species;

    public MoveID GetMove(int index)
    {
        return mimicking && (index == mimicSlot - 1) ?
            mimicMove : isTransformed ? transformedMon.MoveIDs[index] : PokemonData.MoveIDs[index];
    }

    public byte GetPP(int index)
    {
        return mimicking && (index == mimicSlot - 1) ?
            mimicPP : isTransformed ? transformedMon.PP[index] : PokemonData.PP[index];
    }

    public byte GetMaxPP(int index)
    {
        return mimicking && (index == mimicSlot - 1) ?
            mimicMaxPP : isTransformed ? (byte)5 : index switch
            {
                0 => PokemonData.maxPp1,
                1 => PokemonData.maxPp2,
                2 => PokemonData.maxPp3,
                3 => PokemonData.maxPp4,
                _ => (byte)0
            };
    }

    public bool HasType(byte type)
    {
        return Type1 == type
            || Type2 == type
            || (hasType3 && Type3 == type);
    }

    public byte Type1 => isTransformed ? transformedMon.SpeciesData.type1 : typesOverriden ? newType1 : PokemonData.SpeciesData.type1;

    public byte Type2 => isTransformed ? transformedMon.SpeciesData.type2 : typesOverriden ? newType2 : PokemonData.SpeciesData.type2;

    public static float StageToModifierNormal(sbyte stage)
    {
        return stage < 0 ? 2.0F / (2 - stage) : (2 + stage) / 2.0F;
    }

    public static float StageToModifierAccEva(sbyte stage)
    {
        return stage < 0 ? 3.0F / (3 - stage) : (3 + stage) / 3.0F;
    }

    private int BaseAttack => isTransformed ? transformedMon.attack : PokemonData.attack;
    private int BaseDefense => isTransformed ? transformedMon.defense : PokemonData.defense;
    private int BaseSpAtk => isTransformed ? transformedMon.spAtk : PokemonData.spAtk;
    private int BaseSpDef => isTransformed ? transformedMon.spDef : PokemonData.spDef;
    private int BaseSpeed => isTransformed ? transformedMon.speed : PokemonData.speed;

    public void CalculateStats()
    {
        attack = (int)(BaseAttack * StageToModifierNormal(attackStage));
        defense = (int)(BaseDefense * StageToModifierNormal(defenseStage));
        spAtk = (int)(BaseSpAtk * StageToModifierNormal(spAtkStage));
        spDef = (int)(BaseSpDef * StageToModifierNormal(spDefStage));
        speed = (int)(BaseSpeed * StageToModifierNormal(speedStage));
    }

    public static BattlePokemon MakeEmptyBattleMon(bool side, int position)
    {
        Pokemon emptyMon = Pokemon.MakeEmptyMon;
        return new BattlePokemon(emptyMon, side, position, false, false);
    }

    public void CopyStatChanges(BattlePokemon monIn)
    {
        attackStage = monIn.attackStage;
        defenseStage = monIn.defenseStage;
        spAtkStage = monIn.spAtkStage;
        spDefStage = monIn.spDefStage;
        speedStage = monIn.speedStage;
        accuracyStage = monIn.accuracyStage;
        evasionStage = monIn.evasionStage;
        critStage = monIn.critStage;
        CalculateStats();
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
