using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Device;
using static System.Math;
using static Ability;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Battle : MonoBehaviour
{
    private const int TurnOver = 63;
    private const int NoMons = 63;

    public bool wildBattle;
    public Pokemon[] OpponentPokemon = new Pokemon[6];
    public Pokemon[] PlayerPokemon = new Pokemon[6];

    public BattleState state;
    public int currentPlayerMon = 4;

    public string OpponentName = "Error 401";

    public TextMeshProUGUI Announcer;

    public MaskManager[] maskManager;
    public MenuManager menuManager;
    public HealthBarManager[] healthBarManager;

    public SpriteRenderer[] spriteRenderer;
    public Transform[] spriteTransform;

    public AudioSource audioSource0;
    public AudioSource audioSource1;

    public bool[] megaEvolveOnMove = new bool[6];
    public bool hasPlayerMegaEvolved = false;
    public bool hasOpponentMegaEvolved = false;

    public int textSpeed = 25;
    public float persistenceTime = 1.5F;

    public bool switchDuringTurn;
    public int switchingMon;
    public int switchingTarget;
    public bool choseSwitchMon;

    public int turnsElapsed;

    public bool pursuitHitsOnSwitch;

    public bool followMeActive;

    public List<string> announcementLog = new();

    private int singleMovePower; //used for Magnitude

    public bool continueMultiHitMove;

    private int currentIndex;

    // Field varibles

    public bool payDay;

    public Weather weather;
    public int weatherTimer;
    public Terrain terrain;
    public int terrainTimer;

    public BattleTerrain battleTerrain;

    public bool gravity;
    public int gravityTimer;

    public bool wonderRoom;
    public int wonderRoomTimer;

    public bool magicRoom;
    public int magicRoomTimer;

    public bool trickRoom;
    public int trickRoomTimer;

    public Queue<(int wishHP, int turn, int slot, string wisher)> wishes = new();

    public bool oneAnnouncementDone; //Used for Perish Song

    public BattlePokemon[] PokemonOnField = new BattlePokemon[6]
    {
        BattlePokemon.MakeEmptyBattleMon(false,0),
        BattlePokemon.MakeEmptyBattleMon(false,1),
        BattlePokemon.MakeEmptyBattleMon(false,2),
        BattlePokemon.MakeEmptyBattleMon(true,0),
        BattlePokemon.MakeEmptyBattleMon(true,1),
        BattlePokemon.MakeEmptyBattleMon(true,2),
    };

    private bool PlayerHasMonsInBack()
    {
        for (int i = 0; i < 6; i++)
        {
            if (!PlayerPokemon[i].onField && !PlayerPokemon[i].fainted)
            {
                return true;
            }
        }
        return false;
    }

    public Side[] Sides = new Side[2]
    {
        new(false),
        new(true),
    };

    public BattleType battleType;


    public MoveID[] Moves = new MoveID[6];
    public int[] SwitchTargets = new int[6];
    public int[] Targets = new int[6];
    public int[] MoveNums = new int[6];

    public Sprite[] playerMonIcons = new Sprite[6];

    public string MonNameWithPrefix(int index, bool capitalized)
    {
        return wildBattle && index < 3
            ? (capitalized ? "The wild " : "the wild ")
                + PokemonOnField[index].PokemonData.monName
            : index < 3
                ? (capitalized ? "The foe's " : "the foe's ")
                            + PokemonOnField[index].PokemonData.monName
                : PokemonOnField[index].PokemonData.monName;
    }

    public bool OppositeGenders(int indexA, int indexB)
    {
        return PokemonOnField[indexA].PokemonData.gender switch
        {
            Gender.Male => PokemonOnField[indexB].PokemonData.gender == Gender.Female,
            Gender.Female => PokemonOnField[indexB].PokemonData.gender == Gender.Male,
            _ => false
        };
    }

    public MoveData GetMove(int index) => Moves[index].Data();

    public int GetSide(int index) => index < 3 ? 0 : 1;

    private float StabModifier(int index) => HasAbility(index, Adaptability) ? 2.0F : 1.5F;
    private float CritModifier(int index) => HasAbility(index, Sniper) ? 2.25F : 1.5F;

    public bool HasItem(int index, ItemID item)
        => !HasAbility(index, Klutz) && !magicRoom
            && PokemonOnField[index].PokemonData.item == item;

    public ItemID EffectiveItem(int index)
        => PokemonOnField[index].ability == Klutz || magicRoom
        ? ItemID.None : PokemonOnField[index].PokemonData.item;

    public Terrain EffectiveTerrain(int index)
        => IsGrounded(index) ? terrain : Terrain.None;

    private static int WeightMovePower(int weight) => weight switch
    {
        < 10000 => 20,
        < 25000 => 40,
        < 50000 => 60,
        < 100000 => 80,
        < 200000 => 100,
        _ => 120
    };

    private static int ReversalPower(int HP, int maxHP) => (int)(HP * 48 / maxHP switch
    {
        < 2 => 200,
        < 5 => 150,
        < 10 => 100,
        < 17 => 80,
        < 33 => 40,
        _ => 20,
    });

    public bool AbilityOnSide(Ability ability, int side)
    {
        for (int i = side * 3; i < (side * 3) + 3; i++)
        {
            if (PokemonOnField[i].ability == ability)
            {
                return true;
            }
        }
        return false;
    }

    private bool AbilitiesSuppressed =>
        PokemonOnField[0].ability == NeutralizingGas
        || PokemonOnField[1].ability == NeutralizingGas
        || PokemonOnField[2].ability == NeutralizingGas
        || PokemonOnField[3].ability == NeutralizingGas
        || PokemonOnField[4].ability == NeutralizingGas
        || PokemonOnField[5].ability == NeutralizingGas;

    public bool Uproar =>
        PokemonOnField[0].uproar
        || PokemonOnField[1].uproar
        || PokemonOnField[2].uproar
        || PokemonOnField[3].uproar
        || PokemonOnField[4].uproar
        || PokemonOnField[5].uproar;


    public bool IsWeatherAffected(int index, Weather weather)
    {
        if (this.weather != weather) { return false; }
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (EffectiveAbility(i) is CloudNine or AirLock)
            {
                result = false;
            }
        }
        return result;
    }

    public float GetTypeEffectiveness(BattlePokemon attacker, BattlePokemon defender, MoveID move)
    {
        Type effectiveType1 = defender.Type1;
        Type effectiveType2 = defender.Type2;
        float effectiveness = (effectiveType1 == effectiveType2) ?
            realEffectiveness(attacker.index, defender.index, effectiveType1, move)
            : realEffectiveness(attacker.index, defender.index, effectiveType1, move)
            * realEffectiveness(attacker.index, defender.index, effectiveType2, move);
        if (defender.hasType3)
        {
            effectiveness *= realEffectiveness(attacker.index, defender.index, defender.Type3, move);
        }
        return effectiveness;
    }

    public bool IsImmune(BattlePokemon attacker, BattlePokemon defender, MoveID move)
        => GetTypeEffectiveness(attacker, defender, move) == 0;

    public float realEffectiveness(int attacker, int defender, Type defenderType, MoveID move)
    {
        Type moveType = GetEffectiveType(move, attacker);
        if (moveType == Type.Ground)
        {
            if (!IsGrounded(defender)) return 0.0F;
            else if (IsGrounded(defender) && defenderType == Type.Flying) return 1.0F;
        }
        if (defenderType == Type.Ghost && moveType is Type.Normal or Type.Fighting
            && PokemonOnField[defender].identified) return 1.0F;
        return TypeUtils.Effectiveness(moveType, defenderType);
    }

    public bool IsGrounded(int index)
    {
        if (gravity) return true;
        if (PokemonOnField[index].HasType(Type.Flying)
            || HasAbility(index, Levitate)) //Todo: add other sources of non-grounding
        { return false; }
        return true;
    }

    public bool HasAbility(int index, Ability ability)
    {
        return !AbilitiesSuppressed && PokemonOnField[index].ability == ability;
    }

    public Ability EffectiveAbility(int index)
    {
        return AbilitiesSuppressed ? None : PokemonOnField[index].ability;
    }

    public Type GetEffectiveType(MoveID move, int index)
    {
        Type effectiveType = move.Data().type;
        switch (move.Data().effect)
        {
            case MoveEffect.HiddenPower:
                effectiveType = PokemonOnField[index].PokemonData.hiddenPowerType;
                break;
            default: break;
        }
        switch (EffectiveAbility(index))
        {
            case Aerilate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Flying;
                }
                break;
            case Refrigerate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Ice;
                }
                break;
            case Galvanize:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Electric;
                }
                break;
            case Pixilate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Fairy;
                }
                break;
            case LiquidVoice:
                if ((move.Data().moveFlags & MoveFlags.soundMove) != 0)
                {
                    effectiveType = Type.Water;
                }
                break;
            case Normalize:
                effectiveType = Type.Normal;
                break;

        }
        return effectiveType;
    }

    private int GetSpeed(int index)
    {
        PokemonOnField[index].CalculateStats();
        int speed = PokemonOnField[index].speed;
        if (PokemonOnField[index].PokemonData.status == Status.Paralysis)
        {
            speed >>= 1;
        }
        switch (PokemonOnField[index].ability)
        {
            case SwiftSwim:
                if (IsWeatherAffected(index, Weather.Rain)) { speed <<= 1; }
                break;
            case Chlorophyll:
                if (IsWeatherAffected(index, Weather.Sun)) { speed <<= 1; }
                break;
            case SandRush:
                if (IsWeatherAffected(index, Weather.Sand)) { speed <<= 1; }
                break;
            case SlushRush:
                if (IsWeatherAffected(index, Weather.Snow)) { speed <<= 1; }
                break;
            default: break;
        }
        if (trickRoom) speed = 10000 - speed;
        if (HasAbility(index, Stall)) speed -= 32768;
        return speed;
    }

    private int GetPriority(int index)
    {
        int priority = GetMove(index).priority;
        switch (EffectiveAbility(index))
        {
            case GaleWings:
                if (PokemonOnField[index].AtFullHealth && GetMove(index).type == Type.Flying) priority += 1;
                break;
            case Prankster:
                if (GetMove(index).power == 0) priority += 1;
                break;
        }
        return priority;
    }

    private int FindNextToMove()
    {
        const int switchPriority = 31;
        int currentPriority = -127;
        int currentSpeed = 0;
        int currentMove = TurnOver;
        for (int i = 0; i < 6; i++)
        {
            if (!PokemonOnField[i].done)
            {
                if (Moves[i] == MoveID.Switch)
                {
                    if (currentPriority < switchPriority)
                    {
                        currentPriority = switchPriority;
                        currentSpeed = GetSpeed(i);
                        currentMove = i;
                        Debug.Log("Index " + i + " has speed " + currentSpeed);
                    }
                    if (PokemonOnField[i].speed > currentSpeed)
                    {
                        currentSpeed = GetSpeed(i);
                        currentMove = i;
                        Debug.Log("Index " + i + " has speed " + currentSpeed);
                    }
                }
                else if (GetPriority(i) > currentPriority)
                {
                    currentPriority = GetPriority(i);
                    currentSpeed = GetSpeed(i);
                    currentMove = i;
                    Debug.Log("Index " + i + " has priority " + currentPriority
                        + " and speed " + currentSpeed);
                }
                else if (GetPriority(i) == currentPriority
                    && GetSpeed(i) > currentSpeed)
                {
                    currentSpeed = GetSpeed(i);
                    currentMove = i;
                    Debug.Log("Index " + i + " has speed " + currentSpeed);
                }
            }
        }
        pursuitHitsOnSwitch = false;
        if (currentPriority == switchPriority)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Moves[i] > MoveID.StandardCount) continue;
                if (GetMove(i).effect == MoveEffect.Pursuit && Targets[i] == currentMove) return i;
            }
        }
        return currentMove;
    }

    private float GetAccuracy(MoveID move, int attacker, int defender)
    {
        return move.Data().accuracy
            * BattlePokemon.StageToModifierAccEva(PokemonOnField[attacker].accuracyStage)
            / BattlePokemon.StageToModifierAccEva(PokemonOnField[defender].evasionStage)
            / 100.0F
            * GetAttackerAccuracyModifier(attacker)
            * GetDefenderAccuracyModifier(defender);
    }

    private float GetAttackerAccuracyModifier(int index)
    {
        return PokemonOnField[index].ability switch
        {
            CompoundEyes => 1.3F,
            Hustle => 0.8F,
            _ => 1.0F,
        };
    }

    private float GetDefenderAccuracyModifier(int index)
    {
        return PokemonOnField[index].ability switch
        {
            SandVeil => IsWeatherAffected(index, Weather.Sand)
                                ? 0.8F : 1.0F,
            _ => 1.0F,
        };
    }

    public float GetCritChance(int attacker, MoveID move)
    {
        int stage = PokemonOnField[attacker].critStage;
        if ((move.Data().moveFlags & MoveFlags.highCrit) != 0)
        {
            stage += 1;
        }
        return stage switch
        {
            0 => 1.0F / 24.0F,
            1 => 0.125F,
            2 => 0.5F,
            _ => 1.0F,
        };
    }

    public int DamageCalc(BattlePokemon attacker, BattlePokemon defender, MoveID move, bool isMultiTarget, bool isCritical, int side, int? powerOverride = null)
    {
        var random = new System.Random();
        int roll = 100 - (random.Next() & 15);
        int effectivePower = powerOverride == null ? move.Data().power : (int)powerOverride;
        if (powerOverride != null) Debug.Log(effectivePower);
        Type effectiveType = move.Data().type;
        if ((move.Data().moveFlags & MoveFlags.halfPowerInBadWeather) != 0
            && (IsWeatherAffected(attacker.index, Weather.Rain)
            || IsWeatherAffected(attacker.index, Weather.Sand)))
        {
            effectivePower >>= 1;
        }
        switch (EffectiveTerrain(defender.index))
        {
            case Terrain.Electric when move.Data().type == Type.Electric:
            case Terrain.Psychic when move.Data().type == Type.Psychic:
            case Terrain.Grassy when move.Data().type == Type.Grass:
                effectivePower += 3 * effectivePower / 10;
                break;
        }
        switch (move.Data().effect)
        {
            case MoveEffect.WeightPower:
                effectivePower = WeightMovePower(defender.PokemonData.SpeciesData.pokedexData.weight);
                break;
            case MoveEffect.Return:
                effectivePower = (attacker.PokemonData.friendship / 5) << 1;
                break;
            case MoveEffect.Frustration:
                effectivePower = ((255 - attacker.PokemonData.friendship) / 5) << 1;
                break;
            case MoveEffect.Rollout:
                effectivePower <<= (attacker.rolloutIntensity + (attacker.usedDefenseCurl ? 1 : 0));
                break;
            case MoveEffect.FuryCutter:
                effectivePower <<= (attacker.furyCutterIntensity);
                break;
            case MoveEffect.HiddenPower:
                effectiveType = attacker.PokemonData.hiddenPowerType;
                break;
            case MoveEffect.Reversal:
                effectivePower = ReversalPower(attacker.PokemonData.HP, attacker.PokemonData.hpMax);
                break;
            case MoveEffect.Facade when attacker.PokemonData.status != Status.None:
                effectivePower <<= 1;
                break;
            case MoveEffect.SmellingSalts
            when defender.PokemonData.status == Status.Paralysis && !defender.hasSubstitute:
                effectivePower <<= 1;
                break;
            default: break;
        }
        switch (EffectiveAbility(attacker.index))
        {
            case Technician when effectivePower <= 60:
                effectivePower += effectivePower >> 1;
                break;
            case LiquidVoice when (move.Data().moveFlags & MoveFlags.soundMove) != 0:
                effectiveType = Type.Water;
                break;
            case Aerilate when effectiveType == Type.Normal:
                effectiveType = Type.Flying;
                effectivePower += effectivePower / 5;
                break;
            case Refrigerate when effectiveType == Type.Normal:
                effectiveType = Type.Ice;
                effectivePower += effectivePower / 5;
                break;
            case Galvanize when effectiveType == Type.Normal:
                effectiveType = Type.Electric;
                effectivePower += effectivePower / 5;
                break;
            case Pixilate when effectiveType == Type.Normal:
                effectiveType = Type.Fairy;
                effectivePower += effectivePower / 5;
                break;
            case Normalize:
                effectiveType = Type.Normal;
                break;
            default:
                break;
        }
        if (move.Data().type == Type.Electric && attacker.charged)
        {
            effectivePower <<= 1;
            attacker.charged = false;
        }
        float critical = isCritical ? CritModifier(attacker.index) : 1.0F;
        float stab = attacker.HasType(effectiveType) ? StabModifier(attacker.index) : 1.0F;
        float multitarget = isMultiTarget ? 0.75F : 1.0F;
        float helpingHand = Mathf.Pow(1.5f, attacker.helpingHand);
        float attackOverDefense;
        if (move.Data().physical)
        {
            if (isCritical && attacker.attackStage < 0 || HasAbility(defender.index, Unaware))
            {
                attackOverDefense = (float)((attacker.PokemonData.attack)
                / (float)(isCritical && defender.defenseStage > 0 || HasAbility(attacker.index, Unaware)
                    ? defender.PokemonData.defense : defender.defense));
            }
            else
            {
                attackOverDefense = (float)((attacker.attack)
                / (float)(isCritical && defender.defenseStage > 0 || HasAbility(attacker.index, Unaware)
                    ? defender.PokemonData.defense : defender.defense));
            }
        }
        else
        {
            if (isCritical && attacker.spAtkStage < 0 || HasAbility(defender.index, Unaware))
            {
                attackOverDefense = (float)((attacker.PokemonData.spAtk)
                / (float)(isCritical && defender.spDefStage > 0 || HasAbility(attacker.index, Unaware)
                    ? defender.PokemonData.spDef : defender.spDef));
            }
            else
            {
                attackOverDefense = (float)((attacker.spAtk)
                / (float)(isCritical && defender.spDefStage > 0 || HasAbility(attacker.index, Unaware)
                    ? defender.PokemonData.spDef : defender.spDef));
            }
        }

        float burn = move.Data().physical && attacker.PokemonData.status == Status.Burn
                ? HasAbility(attacker.index, Guts)
                ? 1.5F : 0.5F
            : 1.0F;
        float screen = (Sides[side].auroraVeil
            || (move.Data().physical
            ? Sides[side].reflect : Sides[side].lightScreen))
            ? 0.5F : 1.0F;
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && (move.Data().moveFlags & MoveFlags.hitDiggingMon) != 0)
            || (defender.invulnerability == Invulnerability.Fly
            && (move.Data().moveFlags & MoveFlags.hitFlyingMon) != 0)
            ? 2.0F : 1.0F;
        float effectiveTypeModifier = GetTypeEffectiveness(attacker, defender, move);
        if (effectiveTypeModifier < 1 && HasAbility(attacker.index, TintedLens))
        {
            effectiveTypeModifier *= 2.0F;
        }
        if (effectiveTypeModifier > 1 && EffectiveAbility(defender.index) is Filter or SolidRock)
        {
            effectiveTypeModifier *= 0.75F;
        }
        /*
        Debug.Log("Attack/Defense: " + attackOverDefense);
        Debug.Log("Stab: " + stab);
        Debug.Log("Typing: " + Type.GetTypeEffectiveness(move, defender.PokemonData));
        Debug.Log("Part 1: " + (2.0F * attacker.PokemonData.level / 5));
        Debug.Log("Part 2: " + (((2.0F * attacker.PokemonData.level / 5) + 2)
            * move.Data().power * attackOverDefense / 50) + 2);
        Debug.Log("Roll: " + roll);
        */

        int result = (int)Floor(((((2.0F * attacker.PokemonData.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier * helpingHand
            * stab * multitarget * critical * burn * screen
            * AttackerAbilityModifier(attacker, move)
            * DefenderAbilityModifier(defender, move)
            * invulnerabiltyBonus * roll / 100);
        Debug.Log(result);
        return (result < 1) ? 1 : result;
    }

    private float EffectivenessWithoutAttacker(Type type, int defender, Type defenderType)
    {
        if (type == Type.Ground)
        {
            if (!IsGrounded(defender)) return 0.0F;
            else if (IsGrounded(defender) && defenderType == Type.Flying) return 1.0F;
        }
        if (defenderType == Type.Ghost && type is Type.Normal or Type.Fighting
            && PokemonOnField[defender].identified) return 1.0F;
        return TypeUtils.Effectiveness(type, defenderType);
    }

    public float GetEffectivenessForFutureSight(Type type, BattlePokemon defender)
    {
        Type effectiveType1 = defender.Type1;
        Type effectiveType2 = defender.Type2;
        float effectiveness = (effectiveType1 == effectiveType2) ?
            EffectivenessWithoutAttacker(type, defender.index, effectiveType1)
            : EffectivenessWithoutAttacker(type, defender.index, effectiveType1)
            * EffectivenessWithoutAttacker(type, defender.index, effectiveType2);
        if (defender.hasType3)
        {
            effectiveness *= EffectivenessWithoutAttacker(type, defender.index, defender.Type3);
        }
        return effectiveness;
    }

    public int FutureSightDamageCalc(BattlePokemon defender)
    {
        (int spAtk, int stage, int level, bool stab, bool critical) futureSightData
            = defender.futureSightData;
        var random = new System.Random();
        int effectiveSpAtk = (int)Floor(futureSightData.spAtk *
            (futureSightData.critical && futureSightData.stage < 0
            ? 1 : (2 + futureSightData.stage) / 2.0F));
        float attackOverDefense = effectiveSpAtk /
            (futureSightData.critical && defender.spDefStage > 0
            ? defender.PokemonData.spDef : defender.spDef);
        float critical = futureSightData.critical ?
            defender.futureSightUserOnField
            && HasAbility(defender.futureSightUser, Sniper)
            ? 2.25F : 1.5F : 1.0F;
        float screen = (Sides[defender.side ? 1 : 0].lightScreen
            || Sides[defender.side ? 1 : 0].auroraVeil) ? 0.5F : 1.0F;
        int effectivePower = 120;
        float effectiveTypeModifier = GetEffectivenessForFutureSight(defender.futureSightType, defender);
        int roll = 100 - (random.Next() & 15);
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && (defender.futureSightMove.Data().moveFlags & MoveFlags.hitDiggingMon) != 0)
            || (defender.invulnerability == Invulnerability.Fly
            && (defender.futureSightMove.Data().moveFlags & MoveFlags.hitFlyingMon) != 0)
            ? 2.0F : 1.0F;
        return (int)Floor(((((2.0F * futureSightData.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier
            * (futureSightData.stab ? 1.5 : 1.0) * critical * screen
            * DefenderAbilityModifier(defender, defender.futureSightMove)
            * (defender.futureSightUserOnField
                ? AttackerAbilityModifier(PokemonOnField[defender.futureSightUser], defender.futureSightMove) : 1.0F)
            * invulnerabiltyBonus * roll / 100);
    }

    private float AttackerAbilityModifier(BattlePokemon attacker, MoveID move)
    {
        return EffectiveAbility(attacker.index) switch
        {
            FlashFire =>
                    attacker.flashFire
                    && move.Data().type == Type.Fire
                    ? 1.5F : 1.0F,
            Overgrow =>
                    move.Data().type == Type.Grass
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Blaze =>
                    move.Data().type == Type.Fire
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Torrent =>
                    move.Data().type == Type.Water
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Swarm =>
                    move.Data().type == Type.Bug
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            SolarPower =>
                    weather == Weather.Sun ? 1.5F : 1.0F,
            Hustle =>
                    move.Data().physical ? 1.5F : 1.0F,
            _ => 1.0F,
        };
    }

    private float DefenderAbilityModifier(BattlePokemon defender, MoveID move)
    {
        return EffectiveAbility(defender.index) switch
        {
            Multiscale or ShadowShield =>
                    defender.PokemonData.HP == defender.PokemonData.hpMax ? 0.5F : 1.0F,
            _ => 1.0F,

        };
    }

    private bool GetTargets(int attacker, int defender, MoveID move) //returns whether move is multi-target
    {
        bool isMultiTarget = false;
        int targetData = move.Data().targets;
        int targets = 0;
        if (targetData == Target.All)
        {
            for (int i = 0; i < 6; i++) { PokemonOnField[i].isTarget = PokemonOnField[i].exists; }
            return battleType != BattleType.Single;
        }
        if (battleType == BattleType.Single)
        {
            if ((targetData & Target.Opponent) != 0)
            {
                if (attacker == 0)
                {
                    PokemonOnField[3].isTarget = true;
                    PokemonOnField[3].lastTargetedMove = move;
                    //Debug.Log("3 is a target");
                    targets = 1;
                }
                else if (attacker == 3)
                {
                    PokemonOnField[0].isTarget = true;
                    PokemonOnField[0].lastTargetedMove = move;
                    //Debug.Log("0 is a target");
                    targets = 1;
                }
            }
            return false;
        }
        if (targets > 1) { isMultiTarget = true; }
        return isMultiTarget;
    }

    private bool TryToHit(int attacker, int defender, MoveID move)
    {
        var random = new System.Random();
        if (PokemonOnField[defender].protect)
        {
            PokemonOnField[defender].wasProtected = true;
            return false;
        }
        if (PokemonOnField[defender].invulnerability == Invulnerability.Fly
            && (GetMove(attacker).moveFlags & MoveFlags.hitFlyingMon) == 0)
        {
            PokemonOnField[defender].isMissed = true;
            return false;
        }
        if (PokemonOnField[defender].invulnerability == Invulnerability.Dig
            && (move.Data().moveFlags & MoveFlags.hitDiggingMon) == 0)
        {
            PokemonOnField[defender].isMissed = true;
            return false;
        }
        if (GetMove(attacker).accuracy == Move.AlwaysHit)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if ((GetMove(attacker).moveFlags
            & MoveFlags.alwaysHitsInRain) != 0)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if ((GetMove(attacker).moveFlags
            & MoveFlags.alwaysHitsMinimized) != 0
            && PokemonOnField[defender].minimized)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (GetAccuracy(move, attacker, defender) > random.NextDouble()
            || HasAbility(attacker, NoGuard)
            || HasAbility(defender, NoGuard)
            || (PokemonOnField[attacker].hasMindReader
            && PokemonOnField[attacker].mindReaderTarget == defender))
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        else
        {
            PokemonOnField[defender].isMissed = true;
            return false;
        }
    }

    private bool GetHits(int attacker, MoveID move)
    {
        bool hitAnyone = false;
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isTarget)
            {
                switch (EffectiveAbility(i))
                {
                    case VoltAbsorb:
                        if (move.Data().type == Type.Electric
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case WaterAbsorb:
                        if (move.Data().type == Type.Water
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case FlashFire:
                        if (move.Data().type == Type.Fire
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = FlashFire;
                            continue;
                        }
                        break;
                    case WonderGuard:
                        if (GetTypeEffectiveness(PokemonOnField[attacker], PokemonOnField[i], move) <= 1
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = WonderGuard;
                            continue;
                        }
                        break;
                    case Soundproof:
                        if ((move.Data().moveFlags & MoveFlags.soundMove) != 0
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Soundproof;
                            continue;
                        }
                        break;
                    case Bulletproof:
                        if ((move.Data().moveFlags & MoveFlags.bulletMove) != 0
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Bulletproof;
                            continue;
                        }
                        break;
                    case DrySkin:
                        if ((move.Data().type == Type.Water)
                            && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    default:
                        break;
                };
                if (move.Data().effect == MoveEffect.DreamEater
                    && PokemonOnField[i].PokemonData.status != Status.Sleep)
                {
                    PokemonOnField[i].isHit = false;
                    PokemonOnField[i].isTarget = false; //Make ExecuteMove announce move failure
                }
                else if ((IsImmune(PokemonOnField[attacker], PokemonOnField[i], move)
                    && move.Data().power > 0)
                    || (move == MoveID.ThunderWave
                    && PokemonOnField[i].HasType(Type.Ground)))
                {
                    PokemonOnField[i].isUnaffected = true;
                }
                else
                {
                    hitAnyone |= TryToHit(attacker, i, move);
                    PokemonOnField[i].isTarget = false;
                }
            }
        }
        return hitAnyone;
    }

    private void CheckForFollowMe(int index)
    {
        if (followMeActive)
        {
            for (int i = 3 * (index / 3); i < 3 * (index / 3) + 3; i++)
            {
                if (PokemonOnField[i].followMe
                    && Target.CanTarget(index, i, Moves[index]))
                    Targets[index] = i;
            }
        }
    }

    private void GetCrits(int attacker, MoveID move)
    {
        var random = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                if (PokemonOnField[i].ability is BattleArmor or ShellArmor)
                {
                    continue;
                }
                if (random.NextDouble() < GetCritChance(attacker, move))
                {
                    PokemonOnField[i].isCrit = true;
                }
            }
        }
    }

    private void GetMoveEffects(int attacker, MoveID move)
    {
        //Debug.Log(move.Data().targets);
        var random = new System.Random();
        switch ((move.Data().moveFlags & MoveFlags.effectOnSelfOnly) != 0)
        {
            case false:
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        if (PokemonOnField[i].hasSubstitute
                            && (move.Data().moveFlags & MoveFlags.soundMove) == 0
                            && !HasAbility(attacker, Infiltrator)) continue;
                        switch (move.Data().effect)
                        {
                            case MoveEffect.ForcedSwitch when HasAbility(i, SuctionCups):
                                PokemonOnField[i].gotAbilityEffect = true;
                                PokemonOnField[i].affectingAbility = SuctionCups;
                                break;
                            case MoveEffect.PerishSong when HasAbility(i, Soundproof):
                                continue;
                            case MoveEffect.FutureSight:
                                PokemonOnField[i].gotMoveEffect = true;
                                PokemonOnField[i].isHit = false;
                                break;
                            case MoveEffect.Sleep:
                                if (Uproar && !HasAbility(i, Soundproof)) continue;
                                goto case MoveEffect.TriAttack;
                            case MoveEffect.Burn:
                                if (PokemonOnField[i].HasType(Type.Fire)) continue;
                                goto case MoveEffect.TriAttack;
                            case MoveEffect.Paralyze:
                                if (PokemonOnField[i].HasType(Type.Electric)) continue;
                                goto case MoveEffect.TriAttack;
                            case MoveEffect.Poison:
                            case MoveEffect.Toxic:
                                if (PokemonOnField[i].HasType(Type.Poison)) continue;
                                goto case MoveEffect.TriAttack;
                            case MoveEffect.TriAttack:
                                if (PokemonOnField[i].PokemonData.status != Status.None) continue;
                                goto default;
                            default:
                                if (random.NextDouble() * 100.0F
                                    <= move.Data().effectChance * (HasAbility(attacker, SereneGrace) ? 2 : 1))
                                {
                                    //Debug.Log(i + "got effect");
                                    PokemonOnField[i].gotMoveEffect = true;
                                }

                                break;
                        }
                    }
                }
                if ((move.Data().targets & Target.Self) != 0)
                {
                    if (move.Data().effect == MoveEffect.Swallow
                        && PokemonOnField[attacker].stockpile == 0)
                    {
                        PokemonOnField[attacker].isTarget = false;
                        PokemonOnField[attacker].isHit = false; //Show move as failing
                    }
                    else PokemonOnField[attacker].gotMoveEffect = true;
                }
                break;
            case true:
                if (random.NextDouble() * 100.0F
                    <= move.Data().effectChance * (HasAbility(attacker, SereneGrace) ? 2 : 1))
                {
                    //Debug.Log(i + "got effect");
                    PokemonOnField[attacker].gotMoveEffect = true;
                }
                break;
        }
    }

    private void GetAbilityEffects(int attacker, MoveID move)
    {
        var random = new System.Random();
        for (int defender = 0; defender < 6; defender++)
        {
            if (PokemonOnField[defender].isHit)
            {
                switch (EffectiveAbility(attacker))
                {
                    case Stench:
                        if (random.NextDouble() < 0.1F)
                        {
                            PokemonOnField[defender].flinched = true;
                        }
                        break;
                    default:
                        break;
                }
                switch (EffectiveAbility(defender))
                {
                    case Static:
                        if (random.NextDouble() < 1F / 3F && (move.Data().moveFlags & MoveFlags.makesContact) != 0)
                        {
                            PokemonOnField[attacker].gotAbilityEffect = true;
                            PokemonOnField[attacker].affectingAbility = Static;
                        }
                        break;
                    case RoughSkin:
                        if ((move.Data().moveFlags & MoveFlags.makesContact) != 0)
                        {
                            PokemonOnField[attacker].gotAbilityEffect = true;
                            PokemonOnField[attacker].affectingAbility = RoughSkin;
                        }
                        break;
                }

            }
        }
    }

    private IEnumerator DoAbilityEffects(int index)
    {
        if (!PokemonOnField[index].gotAbilityEffect)
        {
            yield break;
        }
        else
        {
            switch (PokemonOnField[index].affectingAbility)
            {
                case Static:
                    yield return BattleEffect.GetParalysis(this, index);
                    break;
                case RoughSkin:
                    PokemonOnField[index].DoProportionalDamage(0.125F);
                    yield return Announce(MonNameWithPrefix(index, true) + " was hurt by Rough Skin!");
                    yield return ProcessFaintingSingle(index);
                    break;
                case FlashFire:
                    PokemonOnField[index].flashFire = true;
                    yield return Announce("Flash Fire powered up "
                        + MonNameWithPrefix(index, false) + "'s Fire-type moves!");
                    break;
                case WonderGuard:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Wonder Guard!");
                    break;
                case Soundproof:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Soundproof!");
                    break;
                case Bulletproof:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Bulletproof!");
                    break;
                case SuctionCups:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " wasn't affected because of Suction Cups!");
                    break;
            }
        }
    }

    private IEnumerator ProcessHits(int attacker, MoveID move, bool isMultiTarget, int? powerOverride = null)
    {
        var random = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                Debug.Log("Processing hit on " + i);
                int damage;
                switch (move.Data().effect)
                {
                    case MoveEffect.OHKO:
                        damage = 65535; break;
                    case MoveEffect.Direct20:
                        damage = 20; break;
                    case MoveEffect.Direct40:
                        damage = 40; break;
                    case MoveEffect.DirectLevel:
                        damage = PokemonOnField[attacker].PokemonData.level; break;
                    case MoveEffect.Counter:
                        damage = PokemonOnField[attacker].damageTaken << 1; break;
                    case MoveEffect.Psywave:
                        damage = Max(1, PokemonOnField[attacker].PokemonData.level
                            * (50 + (random.Next() % 100)) / 100);
                        break;
                    case MoveEffect.SuperFang:
                        damage = PokemonOnField[i].PokemonData.HP >> 1;
                        break;
                    case MoveEffect.BideHit:
                        damage = PokemonOnField[attacker].bideDamage * 2;
                        break;
                    case MoveEffect.SpitUp:
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i],
                            move, isMultiTarget, PokemonOnField[i].isCrit, GetSide(i),
                            100 * PokemonOnField[attacker].stockpile);
                        break;
                    case MoveEffect.Magnitude:
                    case MoveEffect.Present:
                        Debug.Log(singleMovePower);
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i],
                            move, isMultiTarget, PokemonOnField[i].isCrit, GetSide(i),
                            singleMovePower);
                        break;
                    default:
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i],
                            move, isMultiTarget, PokemonOnField[i].isCrit, GetSide(i),
                            powerOverride); break;
                }
                switch (PokemonOnField[i].ability)
                {
                    case VoltAbsorb:
                        if (move.Data().type == Type.Electric)
                        {
                            yield return BattleEffect.Heal(this, i,
                                PokemonOnField[i].PokemonData.hpMax << 2);
                            yield return Announce(MonNameWithPrefix(i, true)
                                + " was healed by Volt Absorb!");
                            continueMultiHitMove = false;
                            continue;
                        }
                        break;
                    case WaterAbsorb:
                        if (move.Data().type == Type.Water)
                        {
                            yield return BattleEffect.Heal(this, i,
                                PokemonOnField[i].PokemonData.hpMax << 2);
                            yield return Announce(MonNameWithPrefix(i, true)
                                + " was healed by Water Absorb!");
                            continueMultiHitMove = false;
                            continue;
                        }
                        break;
                }
                Debug.Log(PokemonOnField[i].PokemonData.HP + " HP, " + damage + " damage");
                if (PokemonOnField[i].hasSubstitute && (GetMove(attacker).moveFlags & MoveFlags.soundMove) == 0)
                {
                    if (damage >= PokemonOnField[i].substituteHP)
                    {
                        PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].substituteHP;
                        PokemonOnField[i].substituteHP = 0;
                        yield return BattleEffect.SubstituteFaded(this, i);
                    }
                    else
                    {
                        PokemonOnField[i].substituteHP -= damage;
                        PokemonOnField[attacker].moveDamageDone = damage;
                    }
                }
                else
                {
                    PokemonOnField[i].focused = false;
                    if (damage >= PokemonOnField[i].PokemonData.HP)
                    {
                        if (move.Data().effect == MoveEffect.FalseSwipe)
                        {
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP - 1;
                            PokemonOnField[i].PokemonData.HP = 1;
                        }
                        else if (HasAbility(i, Sturdy)
                                && PokemonOnField[i].PokemonData.HP == PokemonOnField[i].PokemonData.hpMax
                                && !HasAbility(attacker, MoldBreaker))
                        {
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP - 1;
                            PokemonOnField[i].PokemonData.HP = 1;
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Sturdy;
                        }
                        else if (PokemonOnField[i].endure)
                        {
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP - 1;
                            PokemonOnField[i].PokemonData.HP = 1;
                            PokemonOnField[i].enduredHit = true;
                        }
                        //Todo: Add focus sash effect as else if
                        else
                        {
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP;
                            PokemonOnField[i].PokemonData.HP = 0;
                            PokemonOnField[i].PokemonData.fainted = true;
                            if (PokemonOnField[i].destinyBond)
                            {
                                PokemonOnField[attacker].gotDestinyBondHit = true;
                                PokemonOnField[attacker].destinyBondAttacker = MonNameWithPrefix(i, true);
                            }
                        }
                    }
                    else
                    {
                        PokemonOnField[i].PokemonData.HP -= damage;
                        PokemonOnField[attacker].moveDamageDone += damage;
                        if (PokemonOnField[i].biding) PokemonOnField[i].bideDamage += damage;
                        PokemonOnField[i].damageTaken = damage;
                        PokemonOnField[i].damageWasPhysical = move.Data().physical;
                        PokemonOnField[i].lastDamageDoer = attacker;
                        if (PokemonOnField[i].isEnraged) yield return BattleEffect.StatUp(this, i, Stat.Attack, 1, i);
                    }
                }
            }
        }
    }

    private IEnumerator ProcessFainting()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return ProcessFaintingSingle(i);
        }
    }

    private IEnumerator ProcessFaintingSingle(int index)
    {
        if (PokemonOnField[index].exists && PokemonOnField[index].PokemonData.fainted)
        {
            LeaveFieldCleanup(index);
            yield return BattleEffect.Faint(this, index);
            Moves[index] = MoveID.None;
        }
    }

    private IEnumerator ProcessDestinyBond(int index)

    {
        if (PokemonOnField[index].gotDestinyBondHit)
        {
            yield return Announce(PokemonOnField[index].destinyBondAttacker
                + " took its attacker down with it!");
            PokemonOnField[index].PokemonData.HP = 0;
            PokemonOnField[index].PokemonData.fainted = true;
            yield return ProcessFaintingSingle(index);
        }
    }
    private void CleanForNonDamagingMoves()
    {
        for (int i = 0; i < 6; i++)
        {
            PokemonOnField[i].isHit = false;
            PokemonOnField[i].isCrit = false;
        }
    }

    private void CleanForMultiHitMoves()
    {
        for (int i = 0; i < 6; i++)
        {
            PokemonOnField[i].isCrit = false;
        }
    }

    private bool CheckSelfTargetingMoveAnim(int attacker, MoveEffect moveEffect)
    {
        switch (moveEffect)
        {
            case MoveEffect.AttackUp1:
            case MoveEffect.AttackUp2:
                return PokemonOnField[attacker].attackStage < 6;
            case MoveEffect.DefenseUp1:
            case MoveEffect.DefenseUp2:
                return PokemonOnField[attacker].defenseStage < 6;
            case MoveEffect.SpDefUp2:
                return PokemonOnField[attacker].spDefStage < 6;
            case MoveEffect.SpeedUp2:
                return PokemonOnField[attacker].speedStage < 6;
            case MoveEffect.EvasionUp1:
            case MoveEffect.EvasionUp2:
                return PokemonOnField[attacker].evasionStage < 6;
            case MoveEffect.Growth:
                return PokemonOnField[attacker].attackStage < 6 ||
                    PokemonOnField[attacker].spAtkStage < 6;
            case MoveEffect.Heal50:
                return !PokemonOnField[attacker].AtFullHealth;
            default:
                return true;
        }
    }

    public IEnumerator SwitchMove(int index)
    {
        switchDuringTurn = true;
        switchingMon = index;
        choseSwitchMon = false;
        menuManager.currentPartyMon = 1;
        menuManager.menuMode = MenuMode.Party;
        state = BattleState.PlayerInput;
        while (!choseSwitchMon)
        {
            yield return new WaitForSeconds(0.1F);
        }
        LeaveFieldCleanup(index);
        yield return BattleEffect.VoluntarySwitch(this, 3, switchingTarget);
    }

    public void LeaveFieldCleanup(int index, bool removeTrapping = true)
    {
        if (removeTrapping)
        {
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].continuousDamageSource == index)
                    PokemonOnField[i].getsContinuousDamage = false;
                if (PokemonOnField[i].trappingSlot == index)
                    PokemonOnField[i].trapped = false;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].infatuationTarget == index)
                PokemonOnField[i].infatuated = false;
            if (PokemonOnField[i].futureSightUser == index)
                PokemonOnField[i].futureSightUserOnField = false;
        }
        if (!PokemonOnField[index].PokemonData.fainted && HasAbility(index, Regenerator))
            PokemonOnField[index].PokemonData.HP += PokemonOnField[index].PokemonData.hpMax / 3;
        PokemonOnField[index].PokemonData.onField = false;
    }

    private IEnumerator TryMove(int index)
    {
        if (Moves[index] == MoveID.Switch)
        {
            yield return BattleEffect.VoluntarySwitch(this, index, SwitchTargets[index]);
            DoNextMove();
            yield break;
        }
        Debug.Log(GetMove(index).name);
        var random = new System.Random();
        bool goAhead = true;
        PokemonOnField[index].invulnerability = Invulnerability.None;
        PokemonOnField[index].destinyBond = false;
        if (GetMove(index).effect == MoveEffect.FocusPunchWindup)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index);
            DoNextMove();
            yield break;
        }
        switch (PokemonOnField[index].PokemonData.status)
        {
            case Status.Paralysis:
                //Debug.Log("Checking para");
                if (random.NextDouble() < 0.25F)
                {
                    yield return FullParalysis(index);
                    //Debug.Log("Full para");
                    goAhead = false;
                }
                break;
            case Status.Sleep:
                if (TryWakeUp(index)) yield return BattleEffect.WakeUp(this, index);
                else
                {
                    yield return MonAsleep(index);
                    if (GetMove(index).effect != MoveEffect.Snore) goAhead = false;
                }
                break;
            case Status.Freeze:
                if (random.NextDouble() < 0.8)
                {
                    yield return MonFrozen(index);
                    goAhead = false;
                }
                else
                {
                    yield return ThawedOut(index);
                    PokemonOnField[index].PokemonData.status = Status.None;
                }
                break;
        }
        if (goAhead && PokemonOnField[index].flinched)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " flinched!");
            goAhead = false;
        }
        if (goAhead && PokemonOnField[index].confused)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " is confused!");
            if (random.NextDouble() < 1.0F / 3.0F)
            {
                yield return HurtByConfusion(index);
                goAhead = false;
            }
        }
        if (goAhead && PokemonOnField[index].infatuated)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " is infatuated!");
            yield return BattleAnim.Infatuated(this, index);
            if (random.NextDouble() < 1.0F / 2.0F)
            {
                yield return Announce(MonNameWithPrefix(index, true) + " is immobilized by love!");
                goAhead = false;
            }
        }
        if (GetMove(index).effect == MoveEffect.SelfDestruct)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != index && HasAbility(i, Damp))
                {
                    //Ability popup
                    yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                        + GetMove(index).name + "!");
                }
            }
        }
        if (goAhead && !PokemonOnField[index].dontCheckPP)
        {
            if (PokemonOnField[index].GetPP(MoveNums[index] - 1) <= 0)
            {
                yield return NoPP(index);
                if (Moves[index] != MoveID.Struggle)
                {
                    goAhead = false;
                }
            }
        }
        if (goAhead && PokemonOnField[index].taunted && GetMove(index).power == 0)
        {
            goAhead = false;
            yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                + GetMove(index).name + " after the taunt!");
        }
        if (goAhead && (GetMove(index).moveFlags & MoveFlags.usesProtectCounter) != 0)
        {
            float successChance = 1.0f;
            for (int i = 0; i < PokemonOnField[index].protectCounter; i++) { successChance /= 3.0f; }
            if (random.NextDouble() > successChance)
            {
                goAhead = false;
                PokemonOnField[index].protectCounter = 0;
            }
            else { PokemonOnField[index].protectCounter++; }
        }
        else { PokemonOnField[index].protectCounter = 0; }
        if (goAhead)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index);
        }
        else
        {
            PokemonOnField[index].thrashing = false;
            PokemonOnField[index].done = true;
            if (GetMove(index).type == Type.Electric && PokemonOnField[index].charged)
                PokemonOnField[index].charged = false;
        }
        DoNextMove();
    }

    private IEnumerator FullParalysis(int index)
    {
        yield return BattleAnim.ShowParalysis(this, index);
        yield return Announce(MonNameWithPrefix(index, true) + " is paralyzed! It can't move!");
    }

    private int GetRandomOpponentMon(bool side)
    {
        var random = new System.Random();
        int added = side ? 0 : 3;
        int output = random.Next() % 3;
        while (!PokemonOnField[added + output].exists)
        {
            output = (output + (random.Next() & 1) + 1) % 3;
        }
        return added + output;
    }

    private bool TryWakeUp(int index)
    {
        if (PokemonOnField[index].PokemonData.status != Status.Sleep
            || PokemonOnField[index].PokemonData.sleepTurns <= 0) { return true; }
        else
        {
            PokemonOnField[index].PokemonData.sleepTurns--;
            return false;
        }
    }

    public IEnumerator EntryHazardDamage(int index)
    {
        if (IsGrounded(index) && !HasAbility(index, MagicGuard))
        {
            switch (Sides[GetSide(index)].spikes)
            {
                case 1:
                    PokemonOnField[index].DoProportionalDamage(0.125F);
                    goto case 4;
                case 2:
                    PokemonOnField[index].DoProportionalDamage(1.0F / 6.0F);
                    goto case 4;
                case 3:
                    PokemonOnField[index].DoProportionalDamage(0.25F);
                    goto case 4;
                case 4:
                    yield return Announce(MonNameWithPrefix(index, true) + " was hurt by spikes!");
                    if (PokemonOnField[index].PokemonData.fainted)
                    {
                        ProcessFaintingSingle(index);
                        yield break;
                    }
                    break;
                case 0:
                default:
                    break;
            }
        }
    }

    public IEnumerator EntryAbilityCheck(int index)
    {
        Debug.Log(PokemonOnField[index].ability);
        switch (PokemonOnField[index].ability)
        {
            case Drizzle:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Rain, 5);
                break;
            case Drought:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Sun, 5);
                break;
            case SandStream:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Sand, 5);
                break;
            case SnowWarning:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Snow, 5);
                break;
            case Intimidate:
                //Todo: double/multi battle effect
                //Ability popup
                for (int i = 3 * (1 - (index / 3)); i < 3 * (2 - (index / 3)); i++)
                {
                    if (PokemonOnField[i].exists)
                    {
                        yield return PokemonOnField[i].ability is
                            Oblivious or OwnTempo or InnerFocus
                            or Scrappy
                            ? Announce(MonNameWithPrefix(i, true)
                            + "'s attack wasn't lowered because of "
                            + NameTable.Ability[(int)PokemonOnField[i].ability])
                            : BattleEffect.StatDown(this, i, Stat.Attack, 1, index);
                    }
                }
                break;
            case Trace:
                for (int i = 0; i < 3; i++)
                {
                    Debug.Log(3 * (1 - (index / 3)) + i);
                    if (PokemonOnField[3 * (1 - (index / 3)) + i].exists)
                    {
                        //Ability popup, with text changing to the new ability
                        PokemonOnField[index].ability = PokemonOnField[i].ability;
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " traced the foe's "
                            + NameTable.Ability[(int)PokemonOnField[i].ability]
                            + "!");
                        break;
                    }
                }
                break;

        }
    }

    public IEnumerator MonEntersField(int index)
    {
        PokemonOnField[index].turnOnField = 0;
        yield return EntryHazardDamage(index);
        yield return EntryAbilityCheck(index);
    }

    public IEnumerator MonAsleep(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.IsAsleep);
    }

    public IEnumerator MonFrozen(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.FrozenSolid);
    }

    public IEnumerator ThawedOut(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.ThawedOut);
    }

    public IEnumerator NoPP(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.NoPP);
    }

    public IEnumerator IsConfused(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.IsConfused);
    }

    public IEnumerator HurtByConfusion(int index)
    {
        int damage = DamageCalc(PokemonOnField[index], PokemonOnField[index], MoveID.ConfusionHit, false, false, GetSide(index));
        yield return BattleAnim.DefenderAnims(this, index, MoveID.Pound, 0);
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Neutral Hit"));
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        if (damage >= PokemonOnField[index].PokemonData.HP)
        {
            PokemonOnField[index].PokemonData.HP = 0;
            PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            PokemonOnField[index].PokemonData.HP -= damage;
        }
        yield return DoHitFlash(index);
        yield return Announce(MonNameWithPrefix(index, true) + " hurt itself in confusion!");
        yield return ProcessFainting();
    }

    private IEnumerator ExecuteMove(int index)
    {
        var random = new System.Random();
        bool isMultiTarget = false;
        oneAnnouncementDone = false;
        bool targetsAnyone = false;

        BattlePokemon user = PokemonOnField[index];

        Debug.Log("Executing for " + index);

        user.moveUsedThisTurn = Moves[index];
        if ((GetMove(index).moveFlags & MoveFlags.mimicBypass) == 0) user.lastMoveUsed = Moves[index];
        user.isEnraged = GetMove(index).effect == MoveEffect.Rage;
        if (!user.dontCheckPP)
        {
            bool pressureAffected = false;
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].isTarget && HasAbility(i, Pressure)) pressureAffected = true;
            }
            user.lastMoveSlot = MoveNums[index];
            if (user.isTransformed)
            {
                switch (MoveNums[index])
                {
                    case 1:
                        user.transformedMon.pp1 -= (pressureAffected ? 2 : 1); break;
                    case 2:
                        user.transformedMon.pp2 -= (pressureAffected ? 2 : 1); break;
                    case 3:
                        user.transformedMon.pp3 -= (pressureAffected ? 2 : 1); break;
                    case 4:
                        user.transformedMon.pp4 -= (pressureAffected ? 2 : 1); break;
                }
            }
            else
            {
                switch (MoveNums[index])
                {
                    case 1:
                        user.PokemonData.pp1 -= (pressureAffected ? 2 : 1); break;
                    case 2:
                        user.PokemonData.pp2 -= (pressureAffected ? 2 : 1); break;
                    case 3:
                        user.PokemonData.pp3 -= (pressureAffected ? 2 : 1); break;
                    case 4:
                        user.PokemonData.pp4 -= (pressureAffected ? 2 : 1); break;
                }
            }
        }
        if (user.GetPP(MoveNums[index]) == 0
          && user.encored
          && Moves[index] == user.encoredMove)
            user.encored = false;
        if (GetMove(index).effect == MoveEffect.FocusPunchWindup)
        {
            Moves[index] = MoveID.FocusPunchAttack;
            PokemonOnField[index].focused = true;
            yield return Announce(MonNameWithPrefix(index, true) + " is tightening its focus!");
            yield break;
        }

        yield return Announce(user.PokemonData.monName + " used " + GetMove(index).name + "!");

        if (GetMove(index).effect == MoveEffect.NaturePower)
        {
            Moves[index] = battleTerrain switch
            {
                BattleTerrain.Building or BattleTerrain.Gym => MoveID.TriAttack,
                BattleTerrain.Cave => MoveID.None, //MoveID.PowerGem,
                BattleTerrain.Sand or BattleTerrain.Rock
                    => MoveID.None, //MoveID.EarthPower,
                BattleTerrain.Water => MoveID.HydroPump,
                BattleTerrain.Snow or BattleTerrain.Ice
                    => MoveID.IceBeam,
                BattleTerrain.Bridge or BattleTerrain.Sky
                    => MoveID.None, //MoveID.AirSlash,
                BattleTerrain.Grass or BattleTerrain.Woods
                    or BattleTerrain.Flowers
                    => MoveID.None, //MoveID.EnergyBall,
                BattleTerrain.Volcano => MoveID.None, //MoveID.LavaPlume,
                BattleTerrain.Marsh => MoveID.None, //MoveID.MudBomb,
                BattleTerrain.BurialGround => MoveID.ShadowBall,
                BattleTerrain.UltraSpace => MoveID.None, //MoveID.Psyshock,
                BattleTerrain.Space => MoveID.None, //MoveID.DracoMeteor,
                _ => MoveID.None
            };
            Moves[index] = terrain switch
            {
                Terrain.Electric => MoveID.Thunderbolt,
                Terrain.Misty => MoveID.None, //MoveID.Moonblast,
                Terrain.Grassy => MoveID.None, //MoveID.EnergyBall,
                Terrain.Psychic => MoveID.Psychic,
                _ => Moves[index]
            };
            yield return Announce("Nature Power became " + GetMove(index).name + "!");
        }

        CheckForFollowMe(index);

        switch (GetMove(index).effect)
        {
            case MoveEffect.MirrorMove:
                user.dontCheckPP = true;
                Moves[index] = user.lastTargetedMove;
                yield return ExecuteMove(index);
                yield break;
            case MoveEffect.Metronome:
                user.dontCheckPP = true;
                Moves[index] = (MoveID)(random.Next() % (int)MoveID.Count); //Todo: Add double or multi-battle functionality (targeting)
                yield return ExecuteMove(index);
                yield break;
            case MoveEffect.Sketch:
                {
                    MoveID targetMove = PokemonOnField[Targets[index]].lastMoveUsed;
                    if (targetMove == MoveID.None)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.done = true;
                        MoveCleanup();
                        yield break;
                    }
                    else
                    {
                        yield return DoMoveAnimation(index, Moves[index]);
                        user.PokemonData.AddMove(MoveNums[index], targetMove);
                        yield return Announce(MonNameWithPrefix(index, true) + " sketched " + MonNameWithPrefix(Targets[index], false) + "'s "
                            + targetMove.Data().name + "!");
                        user.done = true;
                        MoveCleanup();
                        yield break;
                    }
                }
            case MoveEffect.Curse:
                if (!user.HasType(Type.Ghost))
                {
                    if (user.attackStage < 6 || user.defenseStage < 6
                        || user.speedStage > -6)
                    {
                        yield return BattleAnim.AttackerAnims(this, index, MoveID.NonGhostCurse, 0);
                    }
                    yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, index);
                    yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                    yield return BattleEffect.StatDown(this, index, Stat.Speed, 1, index);
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                break;
            case MoveEffect.Snore
            when (user.PokemonData.status != Status.Sleep && !HasAbility(index, Comatose)):
            case MoveEffect.FakeOut when user.turnOnField > 1:
            case MoveEffect.SpitUp when user.stockpile == 0:
            case MoveEffect.Swallow when user.stockpile == 0 || user.AtFullHealth:
                yield return Announce(BattleText.MoveFailed);
                user.done = true;
                MoveCleanup();
                yield break;
            case MoveEffect.FocusPunchAttack when !user.focused:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " lost its focus and couldn't move!");
                user.done = true;
                MoveCleanup();
                yield break;
            case MoveEffect.SleepTalk:
                if (user.PokemonData.status != Status.Sleep && !HasAbility(index, Comatose))
                {
                    yield return Announce(BattleText.MoveFailed);
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                else
                {
                    int move1 = MoveNums[index] == 1 ? 2 : 1;
                    int move2 = MoveNums[index] <= 2 ? 3 : 2;
                    int move3 = MoveNums[index] == 4 ? 3 : 4;
                    switch (battleType)
                    {
                        case BattleType.Single:
                            Targets[index] = (int)(3 - index);
                            break; //Todo: add double/multi battle functionality
                    }
                    List<int> possibleMoves = new();
                    if (user.GetPP(move1) > 0
                        && user.GetMove(move1) != MoveID.None)
                    {
                        possibleMoves.Add(move1);
                    }
                    if (user.GetPP(move2) > 0
                        && user.GetMove(move2) != MoveID.None)
                    {
                        possibleMoves.Add(move2);
                    }
                    if (user.GetPP(move3) > 0
                        && user.GetMove(move3) != MoveID.None)
                    {
                        possibleMoves.Add(move3);
                    }
                    if (possibleMoves.Count == 0)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.done = true;
                        MoveCleanup();
                        yield break;
                    }
                    else
                    {
                        int whichMove = random.Next() % possibleMoves.Count;
                        Moves[index] = user.GetMove(possibleMoves[whichMove]);
                        MoveNums[index] = possibleMoves[whichMove];
                        yield return ExecuteMove(index);
                        yield break;
                    }
                }
            case MoveEffect.Magnitude:
                (int magnitude, int power) magnitudeData = random.NextDouble() switch
                {
                    < 0.05 => (4, 10),
                    < 0.15 => (5, 30),
                    < 0.35 => (6, 50),
                    < 0.65 => (7, 70),
                    < 0.85 => (8, 90),
                    < 0.95 => (9, 110),
                    _ => (10, 150),
                };
                yield return Announce("Magnitude " + magnitudeData.magnitude + "!");
                singleMovePower = magnitudeData.power;
                break;
            case MoveEffect.Present:
                int presentPower = random.NextDouble() switch
                {
                    < 0.1 => 120,
                    < 0.4 => 80,
                    < 0.8 => 40,
                    _ => 0,
                };
                if (presentPower == 0)
                {
                    //Todo: yield return BattleAnim.PresentHeal(this, attacker, target)
                    yield return BattleEffect.Heal(this, Targets[index],
                        PokemonOnField[Targets[index]].PokemonData.hpMax >> 2);
                    yield return Announce(MonNameWithPrefix(Targets[index], true) +
                        " regained health!");
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                else singleMovePower = presentPower;
                break;
            default: break;
        }
        if (GetMove(index).targets == Target.Field)
        {
            yield return DoFieldEffect(index, GetMove(index).effect);
            user.done = true;
            MoveCleanup();
            yield break;
        }
        switch (GetMove(index).effect)
        {
            case MoveEffect.Counter:
                if (Moves[index] == (user.damageWasPhysical ?
                    MoveID.Counter : MoveID.MirrorCoat))
                {
                    //Debug.Log("Confirm Counter should work");
                    if (PokemonOnField[user.lastDamageDoer].exists)
                    {
                        PokemonOnField[user.lastDamageDoer].isTarget = true;
                    }
                }
                break;
            case MoveEffect.Thrash:
                PokemonOnField[GetRandomOpponentMon(index > 2)].isTarget = true;
                //Debug.Log("Handling thrash effect");
                if (!user.thrashing)
                {
                    user.thrashing = true;
                    user.lockedInMove = Moves[index];
                    user.thrashingTimer = 0;
                }
                break;
            case MoveEffect.Uproar:
                PokemonOnField[GetRandomOpponentMon(index > 2)].isTarget = true;
                if (!user.uproar)
                {
                    user.uproar = true;
                    user.lockedInMove = Moves[index];
                    user.uproarTimer = 0;
                }
                break;
            case MoveEffect.SelfDestruct:
                user.PokemonData.HP = 0;
                user.PokemonData.fainted = true;
                goto default;
            case MoveEffect.Teleport:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack())
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    else
                    {
                        yield return BattleAnim.AttackerAnims(this, index, MoveID.Teleport, 0);
                        yield return SwitchMove(index);
                    }
                }
                else
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.done = true;
                        yield break;

                    }
                    yield return BattleAnim.AttackerAnims(this, index, MoveID.Teleport, 0);
                    LeaveFieldCleanup(index);
                    yield return BattleEffect.VoluntarySwitch(this, 0, nextMon);
                }
                yield break;
            case MoveEffect.BatonPass:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack())
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    else
                    {
                        switchDuringTurn = true;
                        switchingMon = index;
                        choseSwitchMon = false;
                        yield return BattleAnim.AttackerAnims(this, index, MoveID.BatonPass, 0);
                        menuManager.currentPartyMon = 1;
                        menuManager.menuMode = MenuMode.Party;
                        state = BattleState.PlayerInput;
                        while (!choseSwitchMon)
                        {
                            yield return new WaitForSeconds(0.1F);
                        }
                        LeaveFieldCleanup(index, false);
                        yield return BattleEffect.BatonPass(this, 3, switchingTarget);
                    }
                }
                else
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.done = true;
                        yield break;

                    }
                    yield return BattleAnim.AttackerAnims(this, index, MoveID.BatonPass, 0);
                    LeaveFieldCleanup(index, false);
                    yield return BattleEffect.BatonPass(this, 0, nextMon);
                }
                yield break;
            default:
                isMultiTarget = GetTargets(index, 0, Moves[index]); break;
        }
        bool hitAnyone = GetHits(index, Moves[index])
            || ((GetMove(index).targets & Target.Self) != 0
            && CheckSelfTargetingMoveAnim(index, GetMove(index).effect));
        switch (GetMove(index).effect)
        {
            case MoveEffect.None:
                switch (Moves[index])
                {
                    case MoveID.Splash:
                        yield return Announce("But nothing happened!");
                        break;
                    case MoveID.Recharge:
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " must recharge!");
                        break;
                    default:
                        yield return Announce("Error 103");
                        break;
                }
                break;
            case MoveEffect.Recharge:
                user.lockedInNextTurn = true;
                user.lockedInMove = MoveID.Recharge;
                goto default;
            case MoveEffect.Transform:
                switch (battleType)
                {
                    case BattleType.Single:
                        yield return BattleEffect.TransformMon(this, index, index - 3);
                        break;
                }
                break;
            case MoveEffect.ChargingAttack:
                bool GoToHit = false;
                switch (Moves[index])
                {
                    case MoveID.RazorWind:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.RazorWindAttack;
                        break;
                    case MoveID.Fly:
                        user.lockedInNextTurn = true;
                        user.invulnerability = Invulnerability.Fly;
                        user.lockedInMove = MoveID.FlyAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " flew up high!");
                        break;
                    case MoveID.Dig:
                        user.lockedInNextTurn = true;
                        user.invulnerability = Invulnerability.Dig;
                        user.lockedInMove = MoveID.DigAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " dug under the ground!");
                        break;
                    case MoveID.SolarBeam:
                        yield return Announce(MonNameWithPrefix(index, true) + " absorbed light!");
                        if (weather == Weather.Sun)
                        {
                            Moves[index] = MoveID.SolarBeamAttack;
                            GoToHit = true;
                            break;
                        }
                        else
                        {
                            user.lockedInNextTurn = true;
                            user.lockedInMove = MoveID.SolarBeamAttack;
                            break;
                        }
                    case MoveID.SkyAttack:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.SkyAttackAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " became cloaked in a harsh light!");
                        break;
                    case MoveID.SkullBash:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.SkullBashAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " lowered its head!");
                        yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                        break;
                    case MoveID.Bide:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BideMiddle;
                        user.bideDamage = 0;
                        user.biding = true;
                        yield return Announce(MonNameWithPrefix(index, true) + " began storing energy!");
                        break;
                    case MoveID.BideMiddle:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BideAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " is storing energy!");
                        break;
                    default:
                        break;
                }
                if (GoToHit) { goto default; }
                break;
            case MoveEffect.BeatUp:
                targetsAnyone = false;
                if (hitAnyone)
                {
                    int hits = 0;
                    Pokemon[] party = index < 3 ? OpponentPokemon : PlayerPokemon; //Todo: Add multi battle functionality

                    for (int i = 0; i < 6; i++)
                    {
                        if (party[i].exists && !party[i].fainted && party[i].status == Status.None)
                        {
                            continueMultiHitMove = true;
                            hits++;
                            GetCrits(index, Moves[index]);
                            GetMoveEffects(index, Moves[index]);
                            GetAbilityEffects(index, Moves[index]);
                            yield return DoMoveAnimation(index, Moves[index]);
                            yield return HandleHitFlashes(index);
                            yield return ProcessHits(index, Moves[index], isMultiTarget, (int)(5 + (party[i].SpeciesData.baseAttack / 10)));
                            bool pokemonLeft = false;
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].PokemonData.HP > 0 && PokemonOnField[j].isHit)
                                {
                                    pokemonLeft = true;
                                }
                                if (PokemonOnField[j].isCrit)
                                {
                                    if (battleType == BattleType.Single)
                                    {
                                        yield return Announce(BattleText.CriticalHit);
                                    }
                                }
                            }
                            CleanForMultiHitMoves();
                            if (pokemonLeft == false || !continueMultiHitMove) break;
                        }
                    }
                    if (hits == 0)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        break;
                    }
                    yield return Announce("Hit " + hits + (hits == 1 ? " time!" : " times!"));
                }

                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        float effectiveness = GetTypeEffectiveness(user, PokemonOnField[i], Moves[index]);
                        yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].isMissed)
                    {
                        yield return Announce(PokemonOnField[i].PokemonData.monName + BattleText.AvoidedAttack);
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].wasProtected)
                    {
                        yield return Announce(PokemonOnField[i].PokemonData.monName + " protected itself!");
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].abilityHealed25)
                    {
                        yield return BattleEffect.Heal(this, i,
                            PokemonOnField[i].PokemonData.hpMax >> 2);
                        yield return Announce(MonNameWithPrefix(i, true) +
                            " was healed by " + NameTable.Ability[
                                (int)PokemonOnField[i].ability] + "!");
                        targetsAnyone = true;
                    }
                }
                if (!targetsAnyone)
                {
                    yield return Announce(BattleText.MoveFailed);
                }
                yield return ProcessFainting();
                yield return ProcessDestinyBond(index);
                break;
            case MoveEffect.MultiHit2to5 or MoveEffect.MultiHit2 or MoveEffect.Twineedle or MoveEffect.TripleHit:
                {
                    if (hitAnyone)
                    {
                        int hits;
                        switch (GetMove(index).effect)
                        {
                            case MoveEffect.MultiHit2to5:
                                if (HasAbility(index, SkillLink))
                                {
                                    hits = 5;
                                }
                                else
                                {
                                    hits = (random.NextDouble()) switch
                                    {
                                        < 0.35 => 2,
                                        < 0.70 => 3,
                                        < 0.85 => 4,
                                        < 1.00 => 5,
                                        _ => 2,
                                    };
                                }

                                break;
                            case MoveEffect.TripleHit:
                                hits = 3;
                                break;
                            case MoveEffect.MultiHit2:
                            case MoveEffect.Twineedle:
                                hits = 2;
                                break;
                            default:
                                hits = 0;
                                break;
                        }
                        for (int i = 0; i < hits; i++)
                        {
                            continueMultiHitMove = true;
                            GetCrits(index, Moves[index]);
                            GetMoveEffects(index, Moves[index]);
                            GetAbilityEffects(index, Moves[index]);
                            yield return DoMoveAnimation(index, Moves[index]);
                            yield return HandleHitFlashes(index);
                            if (GetMove(index).effect == MoveEffect.TripleHit)
                            {
                                yield return ProcessHits(index, Moves[index], isMultiTarget,
                                (int)(GetMove(index).power * (i + 1)));
                            }
                            else { yield return ProcessHits(index, Moves[index], isMultiTarget); }
                            bool pokemonLeft = false;
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].PokemonData.HP > 0 && PokemonOnField[j].isHit)
                                {
                                    pokemonLeft = true;
                                }
                                if (PokemonOnField[j].isCrit)
                                {
                                    if (battleType == BattleType.Single)
                                    {
                                        yield return Announce(BattleText.CriticalHit);
                                    }
                                }
                            }
                            yield return HandleMoveEffect(index);
                            CleanForMultiHitMoves();
                            if (pokemonLeft == false || !continueMultiHitMove)
                            {
                                hits = i + 1;
                                break;
                            }
                            if (GetMove(index).effect == MoveEffect.TripleHit
                                && random.NextDouble() > GetAccuracy(Moves[index], index, Targets[index])
                                && !HasAbility(index, SkillLink))
                            {
                                hits = i + 1;
                                break;
                            }
                        }
                        yield return Announce("Hit " + hits + (hits == 1 ? " time!" : " times!"));
                    }
                    targetsAnyone = false;

                    for (int i = 0; i < 6; i++)
                    {
                        if (PokemonOnField[i].isHit)
                        {
                            float effectiveness = GetTypeEffectiveness(user, PokemonOnField[i], Moves[index]);
                            yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].isMissed)
                        {
                            yield return Announce(PokemonOnField[i].PokemonData.monName + BattleText.AvoidedAttack);
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].wasProtected)
                        {
                            yield return Announce(PokemonOnField[i].PokemonData.monName + " protected itself!");
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].gotMoveEffect)
                        {
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].abilityHealed25)
                        {
                            yield return BattleEffect.Heal(this, i,
                                PokemonOnField[i].PokemonData.hpMax >> 2);
                            yield return Announce(MonNameWithPrefix(i, true) +
                                " was healed by " + NameTable.Ability[
                                    (int)PokemonOnField[i].ability] + "!");
                            targetsAnyone = true;
                        }
                    }
                    if (!targetsAnyone)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    yield return ProcessFainting();
                    yield return ProcessDestinyBond(index);
                    break;
                }
            default:
                {
                    GetCrits(index, Moves[index]);
                    GetMoveEffects(index, Moves[index]);
                    GetAbilityEffects(index, Moves[index]);
                    if (GetMove(index).power == 0) { CleanForNonDamagingMoves(); }
                    if (hitAnyone) { yield return DoMoveAnimation(index, Moves[index]); }
                    yield return HandleHitFlashes(index);
                    yield return ProcessHits(index, Moves[index], isMultiTarget);
                    targetsAnyone = false;
                    for (int i = 0; i < 6; i++)
                    {
                        if (PokemonOnField[i].isHit)
                        {
                            targetsAnyone = true;
                            if (GetMove(index).effect == MoveEffect.OHKO)
                            {
                                yield return Announce(BattleText.OHKO);
                            }
                            else if (GetMove(index).effect is not
                                (MoveEffect.Direct20 or MoveEffect.DirectLevel
                                or MoveEffect.Counter))
                            {
                                float effectiveness = GetTypeEffectiveness(user, PokemonOnField[i], Moves[index]);
                                yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                            }
                        }
                        if (PokemonOnField[i].isMissed)
                        {
                            targetsAnyone = true;
                            yield return Announce(MonNameWithPrefix(i, true) + BattleText.AvoidedAttack);
                        }
                        if (PokemonOnField[i].isUnaffected)
                        {
                            targetsAnyone = true;
                            yield return Announce(BattleText.NoEffect + MonNameWithPrefix(i, false) + "...");
                        }
                        if (PokemonOnField[i].gotMoveEffect)
                        {
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].abilityHealed25)
                        {
                            yield return BattleEffect.Heal(this, i,
                                PokemonOnField[i].PokemonData.hpMax >> 2);
                            yield return Announce(MonNameWithPrefix(i, true) +
                                " was healed by " + NameTable.Ability[
                                    (int)PokemonOnField[i].ability] + "!");
                            targetsAnyone = true;
                        }
                        if (PokemonOnField[i].isCrit)
                        {
                            if (battleType == BattleType.Single)
                            {
                                yield return Announce(BattleText.CriticalHit);
                            }
                        }

                    }
                    if (!targetsAnyone)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    if (!hitAnyone)
                    {
                        user.thrashing = false;
                        user.uproar = false;
                    }
                    yield return ProcessFainting();
                    yield return ProcessDestinyBond(index);
                    yield return HandleMoveEffect(index);
                    break;
                }
        }

        switch (GetMove(index).effect)
        {
            case MoveEffect.Recoil33:
                user.DoNonMoveDamage(Max(1, user.moveDamageDone / 3));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25:
                user.DoNonMoveDamage(Max(1, user.moveDamageDone / 4));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25Max:
                user.DoProportionalDamage(0.25F);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Thrash:
                user.thrashingTimer++;
                if (user.thrashingTimer == 3
                    || user.thrashingTimer == 2
                    && random.NextDouble() > 0.5)
                {
                    yield return BattleEffect.Confuse(this, index);
                    user.thrashing = false;
                }
                break;
            case MoveEffect.Uproar:
                user.uproarTimer++;
                if (user.uproarTimer == 3)
                {
                    yield return Announce("The uproar calmed down!");
                    user.uproar = false;
                }
                else yield return Announce(MonNameWithPrefix(index, true)
                    + " is making an uproar!");
                break;
            case MoveEffect.Crash50Max when user.moveDamageDone == 0:
                user.DoProportionalDamage(0.5F);
                yield return Announce(MonNameWithPrefix(index, true) + " kept going and crashed!");
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.SelfDestruct or MoveEffect.Memento:
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.SpitUp:
                yield return Announce("The stockpiled effect wore off!");
                user.defenseStage = Max(-6, user.defenseStage - user.stockpile);
                user.spDefStage = Max(-6, user.spDefStage - user.stockpile);
                user.stockpile = 0;
                break;
            default:
                break;
        }
        if (GetMove(index).effect == MoveEffect.FuryCutter && user.moveDamageDone > 0)
        {
            if (user.furyCutterIntensity < 3) user.furyCutterIntensity++;
        }
        else user.furyCutterIntensity = 0;
        for (int i = 0; i < 6; i++)
        {
            yield return DoAbilityEffects(i);
        }
        user.done = true;
        MoveCleanup();
    }

    public IEnumerator DoMoveAnimation(int attacker, MoveID move)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit || (PokemonOnField[i].gotMoveEffect && i != attacker))
            {
                StartCoroutine(BattleAnim.DefenderAnims(this, i, move, attacker));
            }
        }
        yield return BattleAnim.AttackerAnims(this, attacker, move, Targets[attacker]);
    }

    private IEnumerator HandleHitFlashes(int index)
    {
        bool doWait = false;
        float effectiveness = 0.0F;
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                float thisEff = GetTypeEffectiveness(PokemonOnField[index], PokemonOnField[i], Moves[index]);
                effectiveness = thisEff > effectiveness ? thisEff : effectiveness;
                doWait = true;
                StartCoroutine(DoHitFlash(i));
                if (effectiveness > 0)
                {
                    AudioClip hitSound = effectiveness < 1
                    ? Resources.Load<AudioClip>("Sound/Battle SFX/Weak Hit")
                    : effectiveness == 1
                        ? Resources.Load<AudioClip>("Sound/Battle SFX/Neutral Hit")
                    : Resources.Load<AudioClip>("Sound/Battle SFX/Strong Hit");
                    audioSource0.PlayOneShot(hitSound);
                    audioSource0.panStereo = i > 3 ? 0.5F : -0.5F;
                }
            }
        }
        yield return doWait ? new WaitForSeconds(0.6F) : null;
    }

    public IEnumerator DoHitFlash(int index)
    {
        Color off = new(1, 1, 1, 0);
        Color on = new(1, 1, 1, 1);
        spriteRenderer[index].color = off;
        yield return new WaitForSeconds(0.15F);
        spriteRenderer[index].color = on;
        yield return new WaitForSeconds(0.15F);
        spriteRenderer[index].color = off;
        yield return new WaitForSeconds(0.15F);
        spriteRenderer[index].color = on;
        yield return new WaitForSeconds(0.15F);
    }

    public void MoveCleanup()
    {
        for (int i = 0; i < 6; i++)
        {
            PokemonOnField[i].isHit = false;
            PokemonOnField[i].isTarget = false;
            PokemonOnField[i].isMissed = false;
            PokemonOnField[i].isCrit = false;
            PokemonOnField[i].isUnaffected = false;
            PokemonOnField[i].gotMoveEffect = false;
            PokemonOnField[i].moveDamageDone = 0;
            PokemonOnField[i].gotAbilityEffect = false;
            PokemonOnField[i].abilityHealed25 = false;
            PokemonOnField[i].wasProtected = false;
        }
    }

    public IEnumerator AnnounceTypeEffectiveness(float effectiveness, bool isMultiTarget, int index)
    {
        if (effectiveness > 1)
        {

            yield return Announce(isMultiTarget ? BattleText.SuperEffectiveOn + PokemonOnField[index].PokemonData.monName + "!"
                : BattleText.SuperEffective);
        }
        else if (effectiveness == 0)
        {
            yield return Announce(BattleText.NoEffect + MonNameWithPrefix(index, false) + "...");
        }
        else if (effectiveness < 1)
        {
            yield return Announce(isMultiTarget ? BattleText.NotVeryEffectiveOn + PokemonOnField[index].PokemonData.monName + "..."
                : BattleText.NotVeryEffective);
        }
    }

    private IEnumerator HandleMoveEffect(int index)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].gotMoveEffect && !PokemonOnField[i].PokemonData.fainted)
            {
                Debug.Log("Index " + i + " gets effect");
                yield return DoMoveEffect(i, GetMove(index).effect, index);
            }
        }
    }

    private IEnumerator DoMoveEffect(int index, MoveEffect effect, int attacker)
    {
        switch (effect)
        {
            case MoveEffect.Burn:
                yield return BattleEffect.GetBurn(this, index);
                break;
            case MoveEffect.Paralyze:
                yield return BattleEffect.GetParalysis(this, index);
                break;
            case MoveEffect.Poison:
            case MoveEffect.Twineedle:
                yield return BattleEffect.GetPoison(this, index);
                break;
            case MoveEffect.Toxic:
                yield return BattleEffect.GetBadPoison(this, index);
                break;
            case MoveEffect.Freeze:
                yield return BattleEffect.GetFreeze(this, index);
                break;
            case MoveEffect.Sleep:
                yield return BattleEffect.FallAsleep(this, index);
                break;
            case MoveEffect.Confuse:
                yield return BattleEffect.Confuse(this, index);
                break;
            case MoveEffect.Swagger:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 2, attacker);
                goto case MoveEffect.Confuse;
            case MoveEffect.Flatter:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                goto case MoveEffect.Confuse;
            case MoveEffect.TriAttack:
                yield return BattleEffect.TriAttack(this, index);
                break;
            case MoveEffect.SmellingSalts:
                yield return BattleEffect.HealParalysis(this, index);
                break;
            case MoveEffect.LeechSeed:
                yield return BattleEffect.GetLeechSeed(this, index, attacker);
                break;
            case MoveEffect.Nightmare:
                yield return BattleEffect.GetNightmare(this, index);
                break;
            case MoveEffect.Spite:
                yield return BattleEffect.DrainPP(this, index, 4);
                break;
            case MoveEffect.Taunt:
                yield return BattleEffect.GetTaunted(this, index);
                break;
            case MoveEffect.Torment:
                yield return BattleEffect.Torment(this, index);
                break;
            case MoveEffect.Disable:
                yield return BattleEffect.Disable(this, index);
                break;
            case MoveEffect.Encore:
                yield return BattleEffect.GetEncored(this, index);
                break;
            case MoveEffect.Trap:
                yield return BattleEffect.StartTrapping(this, attacker, index);
                break;
            case MoveEffect.Trick:
                yield return BattleEffect.SwitchItems(this, attacker, index);
                break;
            case MoveEffect.RolePlay:
                yield return BattleEffect.RolePlay(this, attacker, index);
                break;
            case MoveEffect.AttackUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                break;
            case MoveEffect.AttackUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 2, attacker);
                break;
            case MoveEffect.DefenseUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                break;
            case MoveEffect.DefenseUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 2, attacker);
                break;
            case MoveEffect.SpeedUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 2, attacker);
                break;
            case MoveEffect.EvasionUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Evasion, 1, attacker);
                break;
            case MoveEffect.EvasionUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Evasion, 2, attacker);
                break;
            case MoveEffect.CritRateUp2:
                yield return BattleEffect.StatUp(this, index, Stat.CritRate, 2, attacker);
                break;
            case MoveEffect.AttackDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 1, attacker);
                break;
            case MoveEffect.AttackDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 2, attacker);
                break;
            case MoveEffect.DefenseDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 1, attacker);
                break;
            case MoveEffect.DefenseDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 2, attacker);
                break;
            case MoveEffect.SpDefDown1:
                yield return BattleEffect.StatDown(this, index, Stat.SpDef, 1, attacker);
                break;
            case MoveEffect.SpeedDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Speed, 1, attacker);
                break;
            case MoveEffect.SpeedDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Speed, 2, attacker);
                break;
            case MoveEffect.AccuracyDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Accuracy, 1, attacker);
                break;
            case MoveEffect.EvasionDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Evasion, 2, attacker);
                break;
            case MoveEffect.Growth:
                switch (weather)
                {
                    case Weather.Sun:
                        yield return BattleEffect.StatUp(this, index, Stat.Attack, 2, attacker);
                        yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 2, attacker);
                        break;
                    default:
                        yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                        yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                        break;
                }
                break;
            case MoveEffect.AllUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker, true);
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker, true);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker, true);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker, true);
                break;
            case MoveEffect.BellyDrum:
                yield return BattleEffect.BellyDrum(this, index);
                break;
            case MoveEffect.RapidSpin:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                yield return BattleEffect.RemoveHazards(this, index);
                break;
            case MoveEffect.Minimize:
                PokemonOnField[index].minimized = true;
                goto case MoveEffect.EvasionUp2;
            case MoveEffect.DefenseCurl:
                PokemonOnField[index].usedDefenseCurl = true;
                goto case MoveEffect.DefenseUp1;
            case MoveEffect.Charge:
                if (!PokemonOnField[index].charged)
                {
                    PokemonOnField[index].charged = true;
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " began charging power!");
                }
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, index);
                break;
            case MoveEffect.Flinch:
            case MoveEffect.Snore:
            case MoveEffect.FakeOut:
                PokemonOnField[index].flinched = true;
                break;
            case MoveEffect.Stockpile:
                yield return BattleEffect.Stockpile(this, index);
                break;
            case MoveEffect.Swallow:
                yield return BattleEffect.Swallow(this, index);
                break;
            case MoveEffect.Memento:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 2, attacker);
                yield return BattleEffect.StatDown(this, index, Stat.SpAtk, 2, attacker, false);
                PokemonOnField[attacker].PokemonData.HP = 0;
                PokemonOnField[attacker].PokemonData.fainted = true;
                break;
            case MoveEffect.MindReader:
                yield return BattleEffect.GetMindReader(this, attacker, index);
                break;
            case MoveEffect.Foresight:
                yield return BattleEffect.Identify(this, index);
                break;
            case MoveEffect.Substitute:
                yield return BattleEffect.MakeSubstitute(this, index);
                break;
            case MoveEffect.PainSplit:
                yield return BattleEffect.PainSplit(this, index, attacker);
                break;
            case MoveEffect.FutureSight:
                yield return BattleEffect.GetFutureSight(this, index, attacker);
                break;
            case MoveEffect.DestinyBond:
                PokemonOnField[index].destinyBond = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is trying to take its attacker down with it!");
                break;
            case MoveEffect.Thief:
                yield return BattleEffect.Thief(this, attacker, index);
                break;
            case MoveEffect.Absorb50:
            case MoveEffect.DreamEater:
                if (PokemonOnField[index].moveDamageDone == 0) break;
                bool doAnnouncement = !PokemonOnField[index].AtFullHealth;
                yield return BattleEffect.Heal(this, index,
                    Max(1, PokemonOnField[index].moveDamageDone / 2));
                if (doAnnouncement)
                {
                    if (battleType == BattleType.Single)
                    {
                        yield return Announce(MonNameWithPrefix(3 - index, true)
                            + BattleText.Absorb);
                    }
                }
                break;
            case MoveEffect.Rollout:
                if (PokemonOnField[index].rolloutIntensity < 4
                    && PokemonOnField[index].moveDamageDone > 0)
                {
                    PokemonOnField[index].lockedInNextTurn = true;
                    PokemonOnField[index].lockedInMove
                        = PokemonOnField[index].moveUsedThisTurn;
                    PokemonOnField[index].rolloutIntensity++;
                }
                break;
            case MoveEffect.Uproar:
                yield return BattleEffect.StartUproar(this, index);
                break;
            case MoveEffect.PayDay:
                if (!payDay)
                {
                    payDay = true;
                    yield return Announce("Coins were scattered everywhere!");
                }
                break;
            case MoveEffect.PsychUp:
                yield return BattleEffect.PsychUp(this, attacker, index);
                break;
            case MoveEffect.Curse:
                yield return BattleEffect.GhostCurse(this, attacker, index);
                ProcessFaintingSingle(attacker);
                break;
            case MoveEffect.ForcedSwitch:
                yield return BattleEffect.ForcedSwitch(this, index);
                break;
            case MoveEffect.Rest:
                yield return BattleEffect.Rest(this, index);
                break;
            case MoveEffect.Mimic:
                yield return BattleEffect.DoMimic(this, attacker, index);
                break;
            case MoveEffect.Conversion:
                yield return BattleEffect.Conversion(this, index);
                break;
            case MoveEffect.Conversion2:
                yield return BattleEffect.Conversion2(this, index, Targets[index]);
                break;
            case MoveEffect.Protect:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " protected itself!");
                PokemonOnField[index].protect = true;
                break;
            case MoveEffect.Endure:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " braced itself!");
                break;
            case MoveEffect.Heal50:
                yield return BattleEffect.Heal(this, index, PokemonOnField[index].PokemonData.hpMax >> 1);
                break;
            case MoveEffect.HealWeather:
                yield return BattleEffect.Heal(this, index, weather switch
                {
                    Weather.Sun => (PokemonOnField[index].PokemonData.hpMax << 1) / 3,
                    Weather.None => PokemonOnField[index].PokemonData.hpMax >> 1,
                    _ => PokemonOnField[index].PokemonData.hpMax >> 2,
                });
                break;
            case MoveEffect.Wish:
                yield return BattleEffect.MakeWish(this, index);
                break;
            case MoveEffect.PerishSong:
                BattleEffect.GetPerishSong(this, index);
                if (!oneAnnouncementDone)
                {
                    yield return Announce("All Pokémon that heard the song will faint in three turns!");
                }
                break;
            case MoveEffect.Attract:
                yield return BattleEffect.Infatuate(this, index, attacker);
                break;
            case MoveEffect.ContinuousDamage:
                yield return BattleEffect.GetContinuousDamage(this, attacker, index, Moves[attacker]);
                break;
            case MoveEffect.FollowMe:
                PokemonOnField[index].followMe = true;
                followMeActive = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became the center of attention!");
                break;
            case MoveEffect.HelpingHand:
                yield return BattleEffect.HelpingHand(this, attacker, index);
                break;
            case MoveEffect.OHKO:
            case MoveEffect.Hit:
            default:
                yield return null;
                break;
        }
    }

    private IEnumerator DoFieldEffect(int index, MoveEffect effect)
    {
        switch (effect)
        {
            case MoveEffect.Mist:
                yield return BattleEffect.StartMist(this, index / 3);
                break;
            case MoveEffect.LightScreen:
                yield return BattleEffect.StartLightScreen(this, index / 3, index);
                break;
            case MoveEffect.Reflect:
                yield return BattleEffect.StartReflect(this, index / 3, index);
                break;
            case MoveEffect.Haze:
                yield return BattleEffect.Haze(this);
                break;
            case MoveEffect.Weather:
                switch (Moves[index])
                {
                    //Todo: weather rocks
                    case MoveID.SunnyDay:
                        yield return BattleEffect.StartWeather(this, Weather.Sun, 5);
                        break;

                    case MoveID.RainDance:
                        yield return BattleEffect.StartWeather(this, Weather.Rain, 5);
                        break;
                    case MoveID.Sandstorm:
                        yield return BattleEffect.StartWeather(this, Weather.Sand, 5);
                        break;
                    case MoveID.Hail:
                        yield return BattleEffect.StartWeather(this, Weather.Snow, 5);
                        break;
                }
                break;
            case MoveEffect.HealBell:
                yield return BattleEffect.HealBell(this, index);
                break;
            case MoveEffect.Spikes:
                yield return BattleEffect.Spikes(this, index);
                break;
            case MoveEffect.Safeguard:
                yield return BattleEffect.StartSafeguard(this, index);
                break;
            case MoveEffect.Hit:
            default:
                yield break;
        }
    }

    public void DoNextMove()
    {
        int index = FindNextToMove();
        if (index == TurnOver)
        {
            StartCoroutine(EndTurn());
        }
        else
        {
            StartCoroutine(TryMove(index));
        }
    }

    public IEnumerator EndTurn()
    {
        for (int i = 0; i < 6; i++)
        {
            switch (EffectiveAbility(i))
            {
                case SolarPower:
                    if (weather == Weather.Sun)
                    {
                        PokemonOnField[i].DoProportionalDamage(0.125F);
                        yield return Announce(MonNameWithPrefix(i, true) + " is hurt by Solar Power!");
                        ProcessFaintingSingle(i);
                    }
                    break;
                case DrySkin:
                    switch (weather)
                    {
                        case Weather.Sun:
                            PokemonOnField[i].DoProportionalDamage(0.125F);
                            yield return Announce(MonNameWithPrefix(i, true) + " is hurt by Dry Skin!");
                            break;
                        case Weather.Rain:
                            if (!PokemonOnField[i].AtFullHealth)
                            {
                                yield return BattleEffect.Heal(this, i, PokemonOnField[i].PokemonData.hpMax << 3);
                                yield return Announce(MonNameWithPrefix(i, true) + " is healed by Dry Skin!");
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (!HasAbility(i, MagicGuard))
            {
                switch (PokemonOnField[i].PokemonData.status)
                {
                    case Status.Burn:
                        yield return BattleEffect.BurnHurt(this, i);
                        break;
                    case Status.Poison:
                        yield return BattleEffect.PoisonHurt(this, i);
                        break;
                    case Status.ToxicPoison:
                        yield return BattleEffect.ToxicPoisonHurt(this, i);
                        break;
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].perishSong)
                {
                    yield return BattleEffect.DoPerishSong(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].getsContinuousDamage)
                {
                    yield return BattleEffect.DoContinuousDamage(this, i, PokemonOnField[i].continuousDamageType);
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].nightmare)
                {
                    yield return BattleEffect.DoNightmare(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].seeded)
                {
                    yield return BattleEffect.DoLeechSeed(this, i);
                }
                yield return ProcessFainting();
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].cursed)
                {
                    yield return BattleEffect.DoCurse(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].futureSight)
                {
                    if (PokemonOnField[i].futureSightTimer-- <= 1)
                        yield return BattleEffect.FutureSightAttack(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (PokemonOnField[i].PokemonData.fainted) { continue; }
                if (PokemonOnField[i].encored)
                {
                    if (PokemonOnField[i].encoreTimer-- <= 1)
                    {
                        yield return Announce(MonNameWithPrefix(i, true) + "'s encore ended!");
                        PokemonOnField[i].encored = false;
                    }
                }
                if (PokemonOnField[i].taunted)
                {
                    if (PokemonOnField[i].tauntTimer-- <= 0)
                    {
                        yield return Announce(MonNameWithPrefix(i, true)
                            + " shook off the taunt!");
                        PokemonOnField[i].taunted = false;
                    }
                }
            }
            if (PokemonOnField[i].ability == SpeedBoost)
            {
                yield return BattleEffect.StatUp(this, i, Stat.Speed, 1, i);
            }
        }
        if (wishes.Count > 0)
            if (wishes.Peek().turn == turnsElapsed) yield return BattleEffect.GetWish(this);
        for (int i = 0; i < 2; i++)
        {
            if (Sides[i].lightScreen)
            {
                Sides[i].lightScreenTurns--;
                if (Sides[i].lightScreenTurns <= 0)
                {
                    Sides[i].lightScreen = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's"
                        + " Light Screen wore off!");
                }
            }
            if (Sides[i].reflect)
            {
                Sides[i].reflectTurns--;
                if (Sides[i].reflectTurns <= 0)
                {
                    Sides[i].reflect = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's"
                        + " Reflect wore off!");
                }
            }
            if (Sides[i].mist)
            {
                Sides[i].mistTurns--;
                if (Sides[i].mistTurns <= 0)
                {
                    Sides[i].mist = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's"
                        + " Mist wore off!");
                }
            }
            if (Sides[i].safeguard)
            {
                Sides[i].safeguardTurns--;
                if (Sides[i].safeguardTurns <= 0)
                {
                    Sides[i].safeguard = false;
                    yield return Announce("The mystical veil surrounding "
                        + (i == 0 ? "the foes'" : "your") + " team wore off!");
                }
            }
        }
        if (weather != Weather.None)
        {
            BattleEffect.WeatherContinues(this);
        }
        turnsElapsed++;
        yield return StartTurn();
    }

    public IEnumerator DoFieldTargetingMove(int index, MoveID move)
    {
        yield return null;
    }

    public IEnumerator StartTurnEffects()
    {
        for (int i = 0; i < 6; i++)
        {
            if (megaEvolveOnMove[i])
            {
                yield return DoMegaEvolution(i);
            }
        }
        DoNextMove();
    }

    public IEnumerator StartTurn()
    {
        state = BattleState.Announcement;
        switchDuringTurn = false;
        followMeActive = false;
        switch (battleType)
        {
            case BattleType.Single:
                if (!PokemonOnField[0].exists)
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        StartCoroutine(EndBattle());
                        yield break;
                    }
                    else
                    {
                        yield return BringToField(OpponentPokemon[nextMon], 0, false);
                    }
                }
                if (!PokemonOnField[3].exists)
                {
                    switchDuringTurn = true;
                    switchingMon = 3;
                    choseSwitchMon = false;
                    menuManager.currentPartyMon = 1;
                    menuManager.menuMode = MenuMode.Party;
                    state = BattleState.PlayerInput;
                    while (!choseSwitchMon)
                    {
                        yield return new WaitForSeconds(0.05F);
                    }
                    yield return BattleEffect.VoluntarySwitch(this, 3, switchingTarget);
                }
                break;
        }
        for (int i = 0; i < 6; i++)
        {
            BattlePokemon currentMon = PokemonOnField[i];
            //Debug.Log("Index " + i + " exists: " + PokemonOnField[i].exists);
            if (currentMon.exists)
            {
                currentMon.done = false;
                currentMon.isTarget = false;
                currentMon.isHit = false;
                currentMon.isMissed = false;
                currentMon.isUnaffected = false;
                currentMon.choseMove = false;
                currentMon.dontCheckPP = false;
                currentMon.damageTaken = 0;
                currentMon.protect = false;
                currentMon.endure = false;
                currentMon.moveUsedLastTurn = currentMon.moveUsedThisTurn;
                currentMon.moveUsedThisTurn = MoveID.None;

                currentMon.helpingHand = 0;
                currentMon.followMe = false;

                currentMon.flinched = false;

                currentMon.turnOnField++;
            }
            else
            {
                currentMon.done = true;
            }

            if (currentMon.lockedInNextTurn)
            {
                currentMon.lockedInNextTurn = false;
                currentMon.choseMove = true;
                Moves[i] = currentMon.lockedInMove;
                currentMon.dontCheckPP = true;
            }
            else
            {
                currentMon.rolloutIntensity = 0; //Reset if Rollout ended or was interrupted
            }
            currentMon.hasMindReader = currentMon.usedMindReader;
            currentMon.usedMindReader = false;
            if (currentMon.thrashing || currentMon.uproar)
            {
                Moves[i] = currentMon.lockedInMove;
                currentMon.dontCheckPP = true;
                currentMon.choseMove = true;
            }
            if (currentMon.exists && !currentMon.player
                && !currentMon.choseMove)
            { ChooseAIMove(i); }
        }
        if (!menuManager.GetNextPokemon())
        {
            menuManager.menuMode = MenuMode.Main;
            menuManager.megaEvolving = false;
            state = BattleState.PlayerInput;
        }
        else
        {
            DoNextMove();
        }
    }

    private int GetNextOpponentMonSingle()
    {
        for (int i = 0; i < 6; i++)
        {
            if (OpponentPokemon[i].fainted == false && OpponentPokemon[i].exists && !OpponentPokemon[i].onField)
            {
                return i;
            }
        }
        return NoMons;
    }

    public IEnumerator StartBattle()
    {
        payDay = false;
        trickRoom = false;
        trickRoomTimer = 0;
        magicRoom = false;
        magicRoomTimer = 0;
        wonderRoom = false;
        wonderRoomTimer = 0;
        announcementLog = new();
        MoveNums = new int[6];
        Targets = new int[6];
        wishes = new();
        turnsElapsed = 0;
        for (int i = 0; i < 6; i++)
        {
            playerMonIcons[i] = Sprite.Create(
                Resources.Load<Texture2D>("Sprites/Pokemon/"
                + Species.SpeciesTable[(int)PlayerPokemon[i].species].graphicsLocation
                + "/icon"), new Rect(0.0F, 32.0F, 32.0F, 32.0F), new Vector2(0.5F, 0.5F),
                64);
        }
        if (battleType == BattleType.Single)
        {
            int firstMon = 0;
            for (int i = 0; i < 6; i++)
            {
                if (!PlayerPokemon[i].fainted)
                {
                    firstMon = i;
                    break;
                }
            }
            yield return BringToField(OpponentPokemon[0], 0, false);
            yield return BringToField(PlayerPokemon[firstMon], 3, true);
        }
        StartCoroutine(StartTurn());
        yield break;
    }

    public IEnumerator BringToField(Pokemon pokemonData, int index, bool player)
    {
        if (PokemonOnField[index].exists)
        {
            yield break;
        }
        else
        {
            switch (player)
            {
                case false:
                    yield return Announce(OpponentName + " sent out " + pokemonData.monName + "!");
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index > 2, index % 3, false);
                    break;
                case true:
                    yield return Announce("Go! " + pokemonData.monName + "!");
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index > 2, index % 3, true);
                    break;
            }
            healthBarManager[index].SnapHealth(pokemonData.HP);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            audioSource0.panStereo = player ? -0.5F : 0.5F;
            yield return MonEntersField(index);
        }
    }

    public bool TryAddMove(int index, int move)
    {
        Debug.Log(index);
        if (PokemonOnField[index].GetPP(move - 1) > 0)
        {
            Moves[index] = PokemonOnField[index].GetMove(move - 1);
            MoveNums[index] = move;
            if (battleType == BattleType.Single) Targets[index] = (3 - index);
            return true;
        }
        else { return false; }
    }

    private MoveID ChooseAIMove(int index)
    {
        var random = new System.Random();
        //if (wildBattle)
        //{
        (MoveID move, int moveNum) move = GetWildMove(index);
        MoveNums[index] = move.moveNum;
        Moves[index] = move.move;
        //}
        return PokemonOnField[index].PokemonData.move1;
    }

    private (MoveID, int) GetWildMove(int index)
    {
        var random = new System.Random();
        List<(MoveID, int)> possibleMoves = new();
        for (int i = 1; i <= 4; i++)
        {
            MoveID tryMove = PokemonOnField[index].GetMove(i - 1);
            if (PokemonOnField[index].CanUseMove(i - 1) == MoveSelectOutcome.Success)
                possibleMoves.Add((tryMove, i));
        }
        switch (battleType)
        {
            case BattleType.Single:
                Targets[index] = 3;
                break;
        }
        if (possibleMoves.Count == 0)
        {
            PokemonOnField[index].dontCheckPP = true;
            return (MoveID.Struggle, 1);
        }
        else
        {
            return possibleMoves[random.Next() % possibleMoves.Count];
        }
    }

    public IEnumerator Announce(string announcement)
    {
        announcementLog.Add(announcement);
        float targetTime;
        for (int i = 1; i <= announcement.Length; i++)
        {
            Announcer.text = announcement[..i];
            targetTime = Time.time + 1.0F / textSpeed;
            while (Time.time < targetTime)
            {
                if (Input.GetKey(KeyCode.Return))
                { i = Min(i + 1, announcement.Length - 1); }
                yield return null;
            }
        }
        targetTime = Time.time + persistenceTime;
        while (Time.time < targetTime)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            { break; }
            yield return null;
        }
        Announcer.text = "";
    }

    public IEnumerator MoveFailed(int index)
    {
        PokemonOnField[index].done = true;
        MoveCleanup();
        yield return Announce(BattleText.MoveFailed);
    }

    public bool CanMegaEvolve(int index)
    {
        //Appears to be broken, but I haven't figured out why yet
        if (index > 2 && hasPlayerMegaEvolved) return false;
        if (index < 3 && hasOpponentMegaEvolved) return false;
        if (PokemonOnField[index].item.megaStoneUser() == PokemonOnField[index].PokemonData.getSpecies) return true;
        else return false;
    }

    public IEnumerator DoMegaEvolution(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        //Todo: Add mega animation
        megaEvolveOnMove[index] = false;
        if (index > 2) hasPlayerMegaEvolved = true;
        else hasOpponentMegaEvolved = true;
        mon.PokemonData.temporarySpecies =
            (SpeciesID)Item.ItemTable[(int)mon.PokemonData.item].ItemSubdata[1];
        mon.PokemonData.transformed = true;
        mon.PokemonData.CalculateStats();
        yield return Announce(MonNameWithPrefix(index, true) + " has Mega Evolved into "
            + mon.PokemonData.SpeciesData.speciesName + "!");
        mon.ability = mon.PokemonData.SpeciesData.abilities[0];
        yield return EntryAbilityCheck(index);
        hasPlayerMegaEvolved = true;
    }

    public IEnumerator EndBattle()
    {
        yield return null;
    }

    public void Start()
    {
        audioSource0 = gameObject.AddComponent<AudioSource>();
        audioSource1 = gameObject.AddComponent<AudioSource>();
    }
}