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
    public int partyIndex;

    public int attackStage = 0;
    public int defenseStage = 0;
    public int spAtkStage = 0;
    public int spDefStage = 0;
    public int speedStage = 0;
    public int evasionStage = 0;
    public int accuracyStage = 0;
    public int critStage = 0;

    public int attack => (int)(BaseAttack * StageToModifierNormal(attackStage));
    public int defense => (int)(BaseDefense * StageToModifierNormal(defenseStage));
    public int spAtk => (int)(BaseSpAtk * StageToModifierNormal(spAtkStage));
    public int spDef => (int)(BaseSpDef * StageToModifierNormal(spDefStage));
    public int speed => (int)(BaseSpeed * StageToModifierNormal(speedStage));

    public bool side;
    public int position;
    public int index;

    public int turnOnField;

    public bool exists;
    public bool player;

    public bool done = true;

    //Reset after every move
    public bool isTarget = false;
    public bool isHit = false;
    public bool isMissed = false;
    public bool isUnaffected = false;
    public bool isCrit = false;
    public bool gotMoveEffect = false;
    public bool abilityHealed25 = false;
    public bool abilityActivated = false;
    public bool wasProtected = false;
    public bool enduredHit = false;
    public bool gotSuperEffectiveHit = false;

    public bool roosting = false;

    public bool confused = false;
    public int confusionCounter = 0;

    public bool getsContinuousDamage = false;
    public ContinuousDamage continuousDamageType = ContinuousDamage.None;
    public int continuousDamageSource = 0;
    public int continuousDamageTimer = 0;

    public bool trapped = false;
    public int trappingSlot = 0;

    public bool thrashing = false;
    public int thrashingTimer;
    public bool lockedInNextTurn = false;
    public MoveID lockedInMove;
    public Invulnerability invulnerability;
    public bool dontCheckPP = false;

    public bool choseMove = false;

    public bool flinched = false;

    public bool usedDefenseCurl = false;
    public bool minimized = false;

    public bool charged = false;

    public int toxicCounter = 0;

    public int moveDamageDone = 0;
    public int damageTaken = 0;
    public bool damageWasPhysical = false;
    public int lastDamageDoer = 0;
    public bool damagedThisTurn;

    public bool disabled = false;
    public MoveID disabledMove = 0;
    public int disableTimer = 0;

    public bool uproar = false;
    public int uproarTimer = 0;

    public bool gotAbilityEffectSelf = false;
    public Ability affectingAbilitySelf = Ability.None;
    public bool gotAbilityEffectOpponent = false;
    public Ability affectingAbilityOpponent = Ability.None;
    public int abilityEffectSource = 0;

    public bool seeded = false;
    public int seedingSlot = 0;

    public bool focused = false;

    public bool biding = false;
    public int bideDamage = 0;

    public int rolloutIntensity = 0;

    public bool flashFire = false;

    public bool usedMindReader = false;
    public bool hasMindReader = false;
    public int mindReaderTarget = 0;

    public bool hasSubstitute = false;
    public int substituteHP = 0;

    public bool isEnraged = false;

    public bool perishSong = false;
    public int perishCounter = 0;

    public bool followMe = false;

    public int helpingHand = 0;

    public bool isTransformed = false;
    public Pokemon transformedMon = Pokemon.MakeEmptyMon;

    public Ability ability;

    public bool endure = false;
    public bool protect = false;
    public int protectCounter = 0;

    public bool magicCoat = false;

    public bool infatuated = false;
    public int infatuationTarget = 0;

    public bool taunted = false;
    public int tauntTimer = 0;

    public bool tormented = false;

    public bool cursed = false;

    public bool nightmare = false;

    public bool identified = false;
    public bool identifiedByMiracleEye = false;

    public bool usedLockOn = false;
    public bool hasLockOn = false;
    public int lockOnTarget = 0;

    public bool destinyBond = false;
    public bool gotDestinyBondHit = false;
    public string destinyBondAttacker = "";

    public bool encored = false;
    public int encoreTimer = 0;
    public MoveID encoredMove = MoveID.None;

    public int furyCutterIntensity = 0;

    public Type newType1 = Type.Typeless;
    public Type newType2 = Type.Typeless;
    public bool typesOverriden = false;

    public ItemID eatenBerry = ItemID.None;

    public bool gotReducingBerryEffect = false;
    public bool ateRetaliationBerry = false;
    public bool micleAccBoost = false;
    public bool custapPriorityBoost = false;

    public int stockpile = 0;
    public int stockpileDef = 0;
    public int stockpileSpDef = 0;

    public bool hasType3 = false;
    public Type Type3 = Type.Typeless;

    public bool abilitySuppressed = false;

    public bool mimicking = false;
    public int mimicSlot = 0;
    public MoveID mimicMove = MoveID.None;
    public int mimicPP = 0;
    public int mimicMaxPP = 0;

    public bool yawnNextTurn = false;
    public bool yawnThisTurn = false;

    public bool gotAteBoost = false; //Check for Aerilate, Pixilate, etc... 20% boost

    public bool ingrained = false;
    public bool hasAquaRing = false;

    public bool imprisoned = false;

    public bool magnetRise = false;

    public bool grudge = false;
    public bool gotGrudgeEffect = false;

    public bool snatch = false;

    public bool embargoed = false;
    public int embargoTimer = 0;

    public bool healBlocked = false;
    public int healBlockTimer = 0;

    public bool powerTrick = false;
    public bool powerTrickSuppressed = false;
    public bool PowerTrickActive => powerTrick && !powerTrickSuppressed;

    public bool[] damagedByMon = new bool[6];

    public MoveID moveUsedLastTurn = MoveID.None;
    public MoveID moveUsedThisTurn = MoveID.None;
    public MoveID lastMoveUsed = MoveID.None;
    public int lastMoveSlot = 0;

    public bool meFirst = false;

    public bool[] usedMove = new bool[4];

    public bool HatesStat(Stat stat) => PokemonData.Nature.NatureEffect(stat) < 1;

    public Battle battle;

    public MoveID lastTargetedMove = MoveID.None;

    public ItemID baseItem => PokemonData.itemChanged ? PokemonData.newItem : PokemonData.item;
    public ItemID item => embargoed ?
            (baseItem.Data().type is ItemType.MegaStone ? baseItem : ItemID.None)
            : baseItem;

    public bool CanUseLastResort =>
        PokemonData.Moves == 1 ? false :
        UsedNoneOrLastResort(0) && UsedNoneOrLastResort(1) &&
        UsedNoneOrLastResort(2) && UsedNoneOrLastResort(3);

    public bool UsedNoneOrLastResort(int i)
        => (GetMove(i) is MoveID.None or MoveID.LastResort) || usedMove[i];

    public int SumOfStages =>
        Max(0, attackStage)
        + Max(0, defenseStage)
        + Max(0, spAtkStage)
        + Max(0, spDefStage)
        + Max(0, speedStage)
        + Max(0, evasionStage)
        + Max(0, accuracyStage);

    public BattlePokemon(Pokemon pokemonData, bool side, int position, bool player, Battle battle, bool exists = true)
    {
        pokemonData.onField = true;
        PokemonData = pokemonData;
        this.exists = exists;
        this.side = side;
        this.position = position;
        this.player = player;
        ability = Species.SpeciesTable[(int)pokemonData.species].abilities[pokemonData.whichAbility];
        this.battle = battle;
        pokemonData.lastIndex = index;
    }

    public SpeciesID apparentSpecies => isTransformed ? transformedMon.species : PokemonData.getSpecies;

    public bool AtFullHealth => PokemonData.HP == PokemonData.hpMax;
    public float HealthProportion => (float)PokemonData.HP / PokemonData.hpMax;

    public MoveID GetMove(int index)
    {
        return mimicking && (index == mimicSlot - 1) ?
                mimicMove
            : isTransformed
                ? transformedMon.MoveIDs[index]
            : PokemonData.MoveIDs[index];
    }

    public int GetStatStage(Stat stat)
    {
        return stat switch
        {
            Stat.Attack => attackStage,
            Stat.Defense => defenseStage,
            Stat.SpAtk => spAtkStage,
            Stat.SpDef => spDefStage,
            Stat.Speed => speedStage,
            Stat.Accuracy => accuracyStage,
            Stat.Evasion => evasionStage,
            _ => 0
        };
    }

    public MoveSelectOutcome CanUseMove(int move)
    {
        if (GetMove(move) == MoveID.None)
            return MoveSelectOutcome.NoMove;
        if (disabled && GetMove(move) == disabledMove)
            return MoveSelectOutcome.Disabled;
        if (encored && GetMove(move) != encoredMove)
            return MoveSelectOutcome.Encored;
        if (tormented && GetMove(move) == moveUsedLastTurn)
            return MoveSelectOutcome.Tormented;
        if (GetPP(move) <= 0)
            return MoveSelectOutcome.LowPP;
        if (taunted && GetMove(move).Data().power == 0)
            return MoveSelectOutcome.Taunted;
        if (battle.MoveImprisoned(GetMove(move), index))
            return MoveSelectOutcome.Imprisoned;
        if (battle.gravity &&
            (GetMove(move).Data().moveFlags & MoveFlags.gravityDisabled) != 0)
            return MoveSelectOutcome.Gravity;
        if (healBlocked &&
            (GetMove(move).Data().moveFlags & MoveFlags.healBlockAffected) != 0)
            return MoveSelectOutcome.HealBlock;
        return MoveSelectOutcome.Success;
    }

    public bool CanUseAnyMove => CanUseMove(0) == MoveSelectOutcome.Success
        || CanUseMove(1) == MoveSelectOutcome.Success
        || CanUseMove(2) == MoveSelectOutcome.Success
        || CanUseMove(3) == MoveSelectOutcome.Success;

    public void DoNonMoveDamage(int damage)
    {
        if (damage > PokemonData.HP)
        {
            PokemonData.fainted = true;
            PokemonData.HP = 0;
        }
        else
        {
            PokemonData.HP -= damage;
            damagedThisTurn = true;
        }
    }

    public void DoProportionalDamage(float proportion) => DoNonMoveDamage((int)(PokemonData.hpMax * proportion));

    public int GetPP(int index)
    {
        return mimicking && (index == mimicSlot - 1)
                ? mimicPP
            : isTransformed
                ? transformedMon.PP[index]
            : PokemonData.PP[index];
    }

    public int GetMaxPP(int index)
    {
        return mimicking && (index == mimicSlot - 1) ?
            mimicMaxPP : isTransformed ? (int)5 : index switch
            {
                0 => PokemonData.maxPp1,
                1 => PokemonData.maxPp2,
                2 => PokemonData.maxPp3,
                3 => PokemonData.maxPp4,
                _ => (int)0
            };
    }

    public bool HasType(Type type)
    {
        return Type1 == type
            || Type2 == type
            || (hasType3 && Type3 == type);
    }

    public Type Type1 => typesOverriden
                            ? newType1
                        : isTransformed
                            ? transformedMon.SpeciesData.type1
                        : PokemonData.SpeciesData.type1;

    public Type Type2 => typesOverriden
                            ? newType2
                        : isTransformed
                            ? transformedMon.SpeciesData.type2
                        : PokemonData.SpeciesData.type2;

    public static float StageToModifierNormal(int stage)
    {
        return stage < 0 ? 2.0F / (2 - stage) : (2 + stage) / 2.0F;
    }

    public static float StageToModifierAccEva(int stage)
    {
        return stage < 0 ? 3.0F / (3 - stage) : (3 + stage) / 3.0F;
    }

    private int BaseAttackRaw => isTransformed ? transformedMon.attack : PokemonData.attack;
    private int BaseDefenseRaw => isTransformed ? transformedMon.defense : PokemonData.defense;

    public int BaseAttack => PowerTrickActive ? BaseDefenseRaw : BaseAttackRaw;
    public int BaseDefense => PowerTrickActive ? BaseAttackRaw : BaseDefenseRaw;
    public int BaseSpAtk => isTransformed ? transformedMon.spAtk : PokemonData.spAtk;
    public int BaseSpDef => isTransformed ? transformedMon.spDef : PokemonData.spDef;
    public int BaseSpeed => isTransformed ? transformedMon.speed : PokemonData.speed;

    public static BattlePokemon MakeEmptyBattleMon(bool side, int position, Battle battle)
    {
        Pokemon emptyMon = Pokemon.MakeEmptyMon;
        return new BattlePokemon(emptyMon, side, position, false, battle, false);
    }

    public StatStruct MakeStatStruct()
    {
        return new StatStruct()
        {
            attack = attackStage,
            defense = defenseStage,
            spAtk = spAtkStage,
            spDef = spDefStage,
            speed = speedStage,
            accuracy = accuracyStage,
            evasion = evasionStage,
            critRatio = critStage,
        };
    }

    public void ApplyStatStruct(StatStruct statStruct)
    {
        attackStage = statStruct.attack;
        defenseStage = statStruct.defense;
        spAtkStage = statStruct.spAtk;
        spDefStage = statStruct.spDef;
        speedStage = statStruct.speed;
        accuracyStage = statStruct.accuracy;
        evasionStage = statStruct.evasion;
        critStage = statStruct.critRatio;
    }

    public BatonPassStruct MakeBatonPassStruct()
    {
        return new BatonPassStruct()
        {
            statStruct = MakeStatStruct(),
            substitute = hasSubstitute,
            substituteHP = substituteHP,
            seeded = seeded,
            seedingSlot = seedingSlot,
            trapped = trapped,
            trappingSlot = trappingSlot,
            cursed = cursed
        };
    }

    public void ApplyBatonPassStruct(BatonPassStruct batonPassStruct)
    {
        ApplyStatStruct(batonPassStruct.statStruct);
        hasSubstitute = batonPassStruct.substitute;
        substituteHP = batonPassStruct.substituteHP;
        seeded = batonPassStruct.seeded;
        seedingSlot = batonPassStruct.seedingSlot;
        trapped = batonPassStruct.trapped;
        trappingSlot = batonPassStruct.trappingSlot;
        cursed = batonPassStruct.cursed;
    }

    public int RaiseStat(Stat statID, int amount)
    {
        switch (statID)
        {
            case Stat.Attack:
                if (attackStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - attackStage, amount);
                    attackStage += raisedStages;
                    return raisedStages;
                }
            case Stat.Defense:
                if (defenseStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - defenseStage, amount);
                    defenseStage += raisedStages;
                    return raisedStages;
                }
            case Stat.SpAtk:
                if (spAtkStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - spAtkStage, amount);
                    spAtkStage += raisedStages;
                    return raisedStages;
                }
            case Stat.SpDef:
                if (spDefStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - spDefStage, amount);
                    spDefStage += raisedStages;
                    return raisedStages;
                }
            case Stat.Speed:
                if (speedStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - speedStage, amount);
                    speedStage += raisedStages;
                    return raisedStages;
                }
            case Stat.Accuracy:
                if (accuracyStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - accuracyStage, amount);
                    accuracyStage += raisedStages;
                    return raisedStages;
                }
            case Stat.Evasion:
                if (evasionStage == 6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 - evasionStage, amount);
                    evasionStage += raisedStages;
                    return raisedStages;
                }
            default:
                return 0;
        }
    }

    public int LowerStat(Stat statID, int amount)
    {
        switch (statID)
        {
            case Stat.Attack:
                if (attackStage == -6)
                {
                    return 0;
                }
                else
                {
                    int loweredStages = (int)Min(attackStage + 6, amount);
                    attackStage -= loweredStages;
                    return loweredStages;
                }
            case Stat.Defense:
                if (defenseStage == -6)
                {
                    return 0;
                }
                else
                {
                    int loweredStages = (int)Min(defenseStage + 6, amount);
                    defenseStage -= loweredStages;
                    return loweredStages;
                }
            case Stat.SpAtk:
                if (spAtkStage == -6)
                {
                    return 0;
                }
                else
                {
                    int loweredStages = (int)Min(spAtkStage + 6, amount);
                    spAtkStage -= loweredStages;
                    return loweredStages;
                }
            case Stat.SpDef:
                if (spDefStage == -6)
                {
                    return 0;
                }
                else
                {
                    int loweredStages = (int)Min(spDefStage + 6, amount);
                    spDefStage -= loweredStages;
                    return loweredStages;
                }
            case Stat.Speed:
                if (speedStage == -6)
                {
                    return 0;
                }
                else
                {
                    int loweredStages = (int)Min(speedStage + 6, amount);
                    speedStage -= loweredStages;
                    return loweredStages;
                }
            case Stat.Accuracy:
                if (accuracyStage == -6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 + accuracyStage, amount);
                    accuracyStage -= raisedStages;
                    return raisedStages;
                }
            case Stat.Evasion:
                if (evasionStage == -6)
                {
                    return 0;
                }
                else
                {
                    int raisedStages = (int)Min(6 + evasionStage, amount);
                    evasionStage -= raisedStages;
                    return raisedStages;
                }
            default:
                return 0;
        }
    }
}
