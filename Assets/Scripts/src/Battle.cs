using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static System.Math;

public class Battle : MonoBehaviour
{
    private const int TurnOver = 63;
    private const int NoMons = 63;

    public bool wildBattle;
    public Pokemon[] OpponentPokemon = new Pokemon[6];
    public Pokemon[] PlayerPokemon = new Pokemon[6];

    public byte state;
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

    public List<string> announcementLog = new();

    private byte singleMovePower; //used for Magnitude

    public bool continueMultiHitMove;

    private int currentIndex;

    // Field varibles

    public bool payDay;

    public Weather weather;
    public byte weatherTimer;
    public Terrain terrain;
    public byte terrainTimer;

    public bool gravity;
    public byte gravityTimer;

    public bool wonderRoom;
    public byte wonderRoomTimer;

    public bool magicRoom;
    public byte magicRoomTimer;

    public bool trickRoom;
    public byte trickRoomTimer;

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
    public byte[] SwitchTargets = new byte[6];
    public byte[] Targets = new byte[6];
    public byte[] MoveNums = new byte[6];

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

    private MoveData GetMove(int index)
    {
        return Move.MoveTable[(int)Moves[index]];
    }

    public int GetSide(int index)
    {
        return index < 3 ? 0 : 1;
    }

    public bool HasItem(int index, ItemID item)
    {
        return PokemonOnField[index].ability == Ability.Klutz || magicRoom ? false : PokemonOnField[index].PokemonData.item == item;
    }


    private static byte WeightMovePower(int weight)
    {
        return weight switch
        {
            < 10000 => 20,
            < 25000 => 40,
            < 50000 => 60,
            < 100000 => 80,
            < 200000 => 100,
            _ => 120
        };
    }

    private static byte ReversalPower(int HP, int maxHP)
    {
        return (byte)(HP * 48 / maxHP switch
        {
            < 2 => 200,
            < 5 => 150,
            < 10 => 100,
            < 17 => 80,
            < 33 => 40,
            _ => 20,
        });
    }

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
        PokemonOnField[0].ability == Ability.NeutralizingGas
        || PokemonOnField[1].ability == Ability.NeutralizingGas
        || PokemonOnField[2].ability == Ability.NeutralizingGas
        || PokemonOnField[3].ability == Ability.NeutralizingGas
        || PokemonOnField[4].ability == Ability.NeutralizingGas
        || PokemonOnField[5].ability == Ability.NeutralizingGas;

    public bool IsWeatherAffected(int index, Weather weather)
    {
        if (this.weather != weather) { return false; }
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (EffectiveAbility(i) is Ability.CloudNine or Ability.AirLock)
            {
                result = false;
            }
        }
        return result;
    }

    public float GetTypeEffectiveness(byte type, BattlePokemon defender)
    {
        byte effectiveType1 = defender.Type1;
        byte effectiveType2 = defender.Type2;
        if (type == Type.Ground)
        {
            if (IsGrounded(defender.index))
            {
                effectiveType1 = effectiveType1 == Type.Flying ? Type.Normal : effectiveType1;
                effectiveType2 = effectiveType2 == Type.Flying ? Type.Normal : effectiveType2;
            }
            else
            {
                return 0.0F;
            }
        }
        float effectiveness = (effectiveType1 == effectiveType2) ?
            Type.Effectiveness(type, effectiveType1)
            : Type.Effectiveness(type, effectiveType1)
            * Type.Effectiveness(type, effectiveType2);
        if (defender.hasType3)
        {
            effectiveness *= Type.Effectiveness(type, defender.Type3);
        }
        return effectiveness;
    }

    public bool IsImmune(byte type, BattlePokemon defender)
    {
        return GetTypeEffectiveness(type, defender) == 0;
    }

    public bool IsGrounded(int index)
    {
        if (gravity) { return true; }
        if (PokemonOnField[index].HasType(Type.Flying)
            || HasAbility(index, Ability.Levitate)) //Todo: add other sources of non-grounding
        { return false; }
        return true;
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
            case Ability.SwiftSwim:
                if (IsWeatherAffected(index, Weather.Rain)) { speed <<= 1; }
                break;
            case Ability.Chlorophyll:
                if (IsWeatherAffected(index, Weather.Sun)) { speed <<= 1; }
                break;
            case Ability.SandRush:
                if (IsWeatherAffected(index, Weather.Sand)) { speed <<= 1; }
                break;
            case Ability.SlushRush:
                if (IsWeatherAffected(index, Weather.Snow)) { speed <<= 1; }
                break;
            default: break;
        }
        return speed;
    }

    public bool HasAbility(int index, Ability ability)
    {
        return !AbilitiesSuppressed && PokemonOnField[index].ability == ability;
    }

    public Ability EffectiveAbility(int index)
    {
        return AbilitiesSuppressed ? Ability.None : PokemonOnField[index].ability;
    }

    public byte GetEffectiveType(MoveID move, int index)
    {
        byte effectiveType = Move.MoveTable[(int)move].type;
        switch (EffectiveAbility(index))
        {
            case Ability.Aerilate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Flying;
                }
                break;
            case Ability.Refrigerate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Ice;
                }
                break;
            case Ability.Galvanize:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Electric;
                }
                break;
            case Ability.Pixilate:
                if (effectiveType == Type.Normal)
                {
                    effectiveType = Type.Fairy;
                }
                break;
            case Ability.Normalize:
                effectiveType = Type.Normal;
                break;

        }
        return effectiveType;
    }

    private int FindNextToMove()
    {
        sbyte currentPriority = -127;
        int currentSpeed = 0;
        int currentMove = TurnOver;
        for (int i = 0; i < 6; i++)
        {
            if (!PokemonOnField[i].done)
            {
                if (Moves[i] == MoveID.Switch)
                {
                    return i;
                }
                if (Move.MoveTable[(int)Moves[i]].priority > currentPriority)
                {
                    currentPriority = Move.MoveTable[(int)Moves[i]].priority;
                    currentSpeed = HasAbility(i, Ability.Stall) ? GetSpeed(i) - 16384 : GetSpeed(i);
                    currentMove = i;
                    Debug.Log("Index " + i + " has priority " + currentPriority
                        + " and speed " + currentSpeed);
                }
                else if (Move.MoveTable[(int)Moves[i]].priority == currentPriority
                    && PokemonOnField[i].speed > currentSpeed)
                {
                    currentSpeed = HasAbility(i, Ability.Stall) ? GetSpeed(i) - 16384 : GetSpeed(i);
                    currentMove = i;
                    Debug.Log("Index " + i + " has speed " + currentSpeed);
                }
            }
        }
        return currentMove;
    }

    private float GetAccuracy(MoveID move, int attacker, int defender)
    {
        return Move.MoveTable[(int)move].accuracy
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
            Ability.CompoundEyes => 1.3F,
            Ability.Hustle => 0.8F,
            _ => 1.0F,
        };
    }

    private float GetDefenderAccuracyModifier(int index)
    {
        return PokemonOnField[index].ability switch
        {
            Ability.SandVeil => IsWeatherAffected(index, Weather.Sand)
                                ? 0.8F : 1.0F,
            _ => 1.0F,
        };
    }

    private float GetCritChance(int attacker, MoveID move)
    {
        byte stage = PokemonOnField[attacker].critStage;
        if ((Move.MoveTable[(int)move].moveFlags & MoveFlags.highCrit) != 0)
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

    public int DamageCalc(BattlePokemon attacker, BattlePokemon defender, MoveID move, bool isMultiTarget, bool isCritical, int side, byte? powerOverride = null)
    {
        var random = new System.Random();
        int roll = 100 - (random.Next() & 15);
        int effectivePower = powerOverride == null ? Move.MoveTable[(int)move].power : (int)powerOverride;
        byte effectiveType = Move.MoveTable[(int)move].type;
        if ((Move.MoveTable[(int)move].moveFlags & MoveFlags.halfPowerInBadWeather) != 0
            && (IsWeatherAffected(attacker.index, Weather.Rain)
            || IsWeatherAffected(attacker.index, Weather.Sand)))
        {
            effectivePower >>= 1;
        }
        switch (Move.MoveTable[(int)move].effect)
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
            default: break;
        }
        if (HasAbility(attacker.index, Ability.Technician) && effectivePower <= 60)
        {
            effectivePower += (byte)(effectivePower >> 1);
        }
        if (effectiveType == Type.Normal)
        {
            switch (EffectiveAbility(attacker.index))
            {
                case Ability.Aerilate:
                    effectiveType = Type.Flying;
                    effectivePower += effectivePower / 5;
                    break;
                case Ability.Refrigerate:
                    effectiveType = Type.Ice;
                    effectivePower += effectivePower / 5;
                    break;
                case Ability.Galvanize:
                    effectiveType = Type.Electric;
                    effectivePower += effectivePower / 5;
                    break;
                case Ability.Pixilate:
                    effectiveType = Type.Fairy;
                    effectivePower += effectivePower / 5;
                    break;
                default:
                    break;
            }
        }
        if (HasAbility(attacker.index, Ability.Normalize))
        {
            effectiveType = Type.Normal;
        }
        float critical = isCritical ? HasAbility(attacker.index, Ability.Sniper) ? 2.25F : 1.5F : 1.0F;
        float stab = attacker.HasType(effectiveType)
            ? HasAbility(attacker.index, Ability.Adaptability) ? 2.0F : 1.5F : 1.0F;
        float multitarget = isMultiTarget ? 0.75F : 1.0F;
        float attackOverDefense = Move.MoveTable[(int)move].physical
            ? (isCritical && attacker.attackStage < 0 || HasAbility(defender.index, Ability.Unaware)
                    ? attacker.PokemonData.attack : attacker.attack)
                / (float)(isCritical && defender.defenseStage > 0 || HasAbility(attacker.index, Ability.Unaware)
                    ? defender.PokemonData.defense : defender.defense)
            : (isCritical && attacker.spAtkStage < 0 || HasAbility(defender.index, Ability.Unaware)
                    ? attacker.PokemonData.spAtk : attacker.spAtk)
                / (float)(isCritical && defender.spDefStage > 0 || HasAbility(attacker.index, Ability.Unaware)
                    ? defender.PokemonData.spDef : defender.spDef);
        float burn = Move.MoveTable[(int)move].physical && attacker.PokemonData.status == Status.Burn
                ? HasAbility(attacker.index, Ability.Guts)
                ? 1.5F : 0.5F
            : 1.0F;
        float screen = (Sides[side].auroraVeil
            || (Move.MoveTable[(int)move].physical
            ? Sides[side].reflect : Sides[side].lightScreen))
            ? 0.5F : 1.0F;
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitDiggingMon) == 0)
            || (defender.invulnerability == Invulnerability.Fly
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitFlyingMon) == 0)
            ? 2.0F : 1.0F;
        float effectiveTypeModifier = GetTypeEffectiveness(effectiveType, defender);
        if (effectiveTypeModifier < 1 && HasAbility(attacker.index, Ability.TintedLens))
        {
            effectiveTypeModifier *= 2.0F;
        }
        if (effectiveTypeModifier > 1 && EffectiveAbility(defender.index) is Ability.Filter or Ability.SolidRock)
        {
            effectiveTypeModifier *= 0.75F;
        }
        /*
        Debug.Log("Attack/Defense: " + attackOverDefense);
        Debug.Log("Stab: " + stab);
        Debug.Log("Typing: " + Type.GetTypeEffectiveness(move, defender.PokemonData));
        Debug.Log("Part 1: " + (2.0F * attacker.PokemonData.level / 5));
        Debug.Log("Part 2: " + (((2.0F * attacker.PokemonData.level / 5) + 2)
            * Move.MoveTable[(int)move].power * attackOverDefense / 50) + 2);
        Debug.Log("Roll: " + roll);
        */

        int result = (int)Floor(((((2.0F * attacker.PokemonData.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier
            * stab * multitarget * critical * burn * screen
            * AttackerAbilityModifier(attacker, move)
            * DefenderAbilityModifier(defender, move)
            * invulnerabiltyBonus * roll / 100);
        Debug.Log(result);
        return (result < 1) ? 1 : result;
    }

    private float AttackerAbilityModifier(BattlePokemon attacker, MoveID move)
    {
        return EffectiveAbility(attacker.index) switch
        {
            Ability.FlashFire =>
                    attacker.flashFire
                    && Move.MoveTable[(int)move].type == Type.Fire
                    ? 1.5F : 1.0F,
            Ability.Overgrow =>
                    Move.MoveTable[(int)move].type == Type.Grass
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Ability.Blaze =>
                    Move.MoveTable[(int)move].type == Type.Fire
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Ability.Torrent =>
                    Move.MoveTable[(int)move].type == Type.Water
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Ability.Swarm =>
                    Move.MoveTable[(int)move].type == Type.Bug
                    && attacker.PokemonData.HP * 3 <= attacker.PokemonData.hpMax
                    ? 1.5F : 1.0F,
            Ability.SolarPower =>
                    weather == Weather.Sun ? 1.5F : 1.0F,
            Ability.Hustle =>
                    Move.MoveTable[(int)move].physical ? 1.5F : 1.0F,
            _ => 1.0F,
        };
    }

    private float DefenderAbilityModifier(BattlePokemon defender, MoveID move)
    {
        return EffectiveAbility(defender.index) switch
        {
            Ability.Multiscale or Ability.ShadowShield =>
                    defender.PokemonData.HP == defender.PokemonData.hpMax ? 0.5F : 1.0F,
            _ => 1.0F,

        };
    }

    private bool GetTargets(int attacker, int defender, MoveID move) //returns whether move is multi-target
    {
        bool isMultiTarget = false;
        byte targetData = Move.MoveTable[(int)move].targets;
        byte targets = 0;
        if (targetData == TargetID.All)
        {
            for (int i = 0; i < 6; i++) { PokemonOnField[i].isTarget = PokemonOnField[i].exists; }
            return battleType != BattleType.Single;
        }
        if (battleType == BattleType.Single)
        {
            if ((targetData & TargetID.Opponent) != 0)
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
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitDiggingMon) == 0)
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
            || HasAbility(attacker, Ability.NoGuard)
            || HasAbility(defender, Ability.NoGuard))
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
                    case Ability.VoltAbsorb:
                        if (Move.MoveTable[(int)move].type == Type.Electric
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case Ability.WaterAbsorb:
                        if (Move.MoveTable[(int)move].type == Type.Water
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case Ability.FlashFire:
                        if (Move.MoveTable[(int)move].type == Type.Fire
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Ability.FlashFire;
                            continue;
                        }
                        break;
                    case Ability.WonderGuard:
                        if (GetTypeEffectiveness(GetEffectiveType(move, attacker), PokemonOnField[i]) <= 1
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Ability.WonderGuard;
                            continue;
                        }
                        break;
                    case Ability.Soundproof:
                        if ((Move.MoveTable[(int)move].moveFlags & MoveFlags.soundMove) != 0
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Ability.Soundproof;
                            continue;
                        }
                        break;
                    case Ability.Bulletproof:
                        if ((Move.MoveTable[(int)move].moveFlags & MoveFlags.bulletMove) != 0
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Ability.Bulletproof;
                            continue;
                        }
                        break;
                    case Ability.DrySkin:
                        if ((Move.MoveTable[(int)move].type == Type.Water)
                            && !HasAbility(attacker, Ability.MoldBreaker))
                        {
                            PokemonOnField[i].abilityHealed25 = true;
                            continue;
                        }
                        break;
                    default:
                        break;
                };
                if (Move.MoveTable[(int)move].effect == MoveEffect.DreamEater
                    && PokemonOnField[i].PokemonData.status != Status.Sleep)
                {
                    PokemonOnField[i].isHit = false;
                    PokemonOnField[i].isTarget = false; //Make ExecuteMove announce move failure
                }
                else if ((IsImmune(GetEffectiveType(Moves[attacker], attacker), PokemonOnField[i])
                    && Move.MoveTable[(int)move].power > 0)
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

    private void GetCrits(int attacker, MoveID move)
    {
        var random = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                if (PokemonOnField[i].ability is Ability.BattleArmor or Ability.ShellArmor)
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
        //Debug.Log(Move.MoveTable[(int)move].targets);
        var random = new System.Random();
        switch ((Move.MoveTable[(int)move].moveFlags & MoveFlags.effectOnSelfOnly) != 0)
        {
            case false:
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        if (Move.MoveTable[(int)move].effect == MoveEffect.ForcedSwitch
                            && HasAbility(i, Ability.SuctionCups))
                        {
                            PokemonOnField[i].gotAbilityEffect = true;
                            PokemonOnField[i].affectingAbility = Ability.SuctionCups;
                        }
                        else if (Move.MoveTable[(int)move].effect == MoveEffect.PerishSong
                            && HasAbility(i, Ability.Soundproof))
                        {
                            continue;
                        }
                        else if (random.NextDouble() <= Move.MoveTable[(int)move].effectChance * (HasAbility(attacker, Ability.SereneGrace) ? 2 : 1) / 100.0F)
                        {
                            //Debug.Log(i + "got effect");
                            PokemonOnField[i].gotMoveEffect = true;
                        }
                    }
                }
                if ((Move.MoveTable[(int)move].targets & TargetID.Self) != 0)
                {
                    PokemonOnField[attacker].gotMoveEffect = true;
                }
                break;
            case true:
                if (random.NextDouble() <= Move.MoveTable[(int)move].effectChance * (HasAbility(attacker, Ability.SereneGrace) ? 2 : 1) / 100.0F)
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
                    case Ability.Stench:
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
                    case Ability.Static:
                        if (random.NextDouble() < 1F / 3F && (Move.MoveTable[(int)move].moveFlags & MoveFlags.makesContact) != 0)
                        {
                            PokemonOnField[attacker].gotAbilityEffect = true;
                            PokemonOnField[attacker].affectingAbility = Ability.Static;
                        }
                        break;
                    case Ability.RoughSkin:
                        if ((Move.MoveTable[(int)move].moveFlags & MoveFlags.makesContact) != 0)
                        {
                            PokemonOnField[attacker].gotAbilityEffect = true;
                            PokemonOnField[attacker].affectingAbility = Ability.RoughSkin;
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
                case Ability.Static:
                    yield return BattleEffect.GetParalysis(this, index);
                    break;
                case Ability.RoughSkin:
                    PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax >> 3);
                    yield return Announce(MonNameWithPrefix(index, true) + " was hurt by Rough Skin!");
                    ProcessFaintingSingle(index);
                    break;
                case Ability.FlashFire:
                    PokemonOnField[index].flashFire = true;
                    yield return Announce("Flash Fire powered up "
                        + MonNameWithPrefix(index, false) + "'s Fire-type moves!");
                    break;
                case Ability.WonderGuard:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Wonder Guard!");
                    break;
                case Ability.Soundproof:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Soundproof!");
                    break;
                case Ability.Bulletproof:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Bulletproof!");
                    break;
                case Ability.SuctionCups:
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " wasn't affected because of Suction Cups!");
                    break;
            }
        }
    }

    private IEnumerator ProcessHits(int attacker, MoveID move, bool isMultiTarget, byte? powerOverride = null)
    {
        var random = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                Debug.Log("Processing hit on " + i);
                int damage;
                switch (Move.MoveTable[(int)move].effect)
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
                    case MoveEffect.Magnitude:
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i], move, isMultiTarget, PokemonOnField[i].isCrit, GetSide(i),
                            singleMovePower);
                        break;
                    default:
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i], move, isMultiTarget, PokemonOnField[i].isCrit, GetSide(i),
                            powerOverride); break;
                }
                switch (PokemonOnField[i].ability)
                {
                    case Ability.VoltAbsorb:
                        if (Move.MoveTable[(int)move].type == Type.Electric)
                        {
                            yield return BattleEffect.Heal(this, i,
                                PokemonOnField[i].PokemonData.hpMax << 2);
                            yield return Announce(MonNameWithPrefix(i, true)
                                + " was healed by Volt Absorb!");
                            continueMultiHitMove = false;
                            continue;
                        }
                        break;
                    case Ability.WaterAbsorb:
                        if (Move.MoveTable[(int)move].type == Type.Water)
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
                    if (damage >= PokemonOnField[i].PokemonData.HP)
                    {
                        if ((HasAbility(i, Ability.Sturdy) &&
                                PokemonOnField[i].PokemonData.HP == PokemonOnField[i].PokemonData.hpMax)
                            || Move.MoveTable[(int)move].effect == MoveEffect.FalseSwipe)
                        {
                            PokemonOnField[i].PokemonData.HP = 1;
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP - 1;
                        }
                        //Todo: Add focus sash effect as else if
                        else
                        {
                            PokemonOnField[attacker].moveDamageDone = PokemonOnField[i].PokemonData.HP;
                            PokemonOnField[i].PokemonData.HP = 0;
                            PokemonOnField[i].PokemonData.fainted = true;
                        }
                    }
                    else
                    {
                        PokemonOnField[i].PokemonData.HP -= damage;
                        PokemonOnField[attacker].moveDamageDone += damage;
                        if (PokemonOnField[i].biding) { PokemonOnField[i].bideDamage += damage; }
                        PokemonOnField[i].damageTaken = damage;
                        PokemonOnField[i].damageWasPhysical = Move.MoveTable[(int)move].physical;
                        PokemonOnField[i].lastDamageDoer = attacker;
                        if (PokemonOnField[i].isEnraged)
                        {
                            yield return BattleEffect.StatUp(this, i, Stat.Attack, 1, i);
                        }
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
                return PokemonOnField[attacker].PokemonData.HP
                    < PokemonOnField[attacker].PokemonData.hpMax;
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
                {
                    PokemonOnField[i].getsContinuousDamage = false;
                }
                if (PokemonOnField[i].trappingSlot == index)
                {
                    PokemonOnField[i].trapped = false;
                }
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].infatuationTarget == index)
            {
                PokemonOnField[i].infatuated = false;
            }
        }
        if (!PokemonOnField[index].PokemonData.fainted && HasAbility(index, Ability.Regenerator))
        { PokemonOnField[index].PokemonData.HP += PokemonOnField[index].PokemonData.hpMax / 3; }
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
                if (TryWakeUp(index))
                {
                    yield return WokeUp(index);
                    PokemonOnField[index].PokemonData.status = Status.None;
                }
                else
                {
                    yield return MonAsleep(index);
                    if (GetMove(index).effect != MoveEffect.Snore) { goAhead = false; }
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
        if (Moves[index] is MoveID.SelfDestruct or MoveID.Explosion)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != index && HasAbility(i, Ability.Damp))
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
        if (goAhead && (GetMove(index).moveFlags & MoveFlags.usesProtectCounter) != 0)
        {
            float successChance = 1.0f;
            for (int i = 0; i < PokemonOnField[index].protectCounter; i++) { successChance /= 3.0f; }
            if (random.NextDouble() < successChance)
            {
                goAhead = false;
                PokemonOnField[index].protectCounter = 0;
            }
            else { PokemonOnField[index].protectCounter++; }
        }
        else { PokemonOnField[index].protectCounter = 0; }
        if (goAhead)
        {
            yield return ExecuteMove(index);
            Debug.Log("Executing");
        }
        else
        {
            PokemonOnField[index].thrashing = false;
            PokemonOnField[index].done = true;
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

    public IEnumerator MonEntersField(int index)
    {
        if (IsGrounded(index) && !HasAbility(index, Ability.MagicGuard))
        {
            switch (Sides[GetSide(index)].spikes)
            {
                case 1:
                    PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax / 8);
                    goto case 4;
                case 2:
                    PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax / 6);
                    goto case 4;
                case 3:
                    PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax / 4);
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
        Debug.Log(PokemonOnField[index].ability);
        switch (PokemonOnField[index].ability)
        {
            case Ability.Drizzle:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Rain, 5);
                break;
            case Ability.Drought:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Sun, 5);
                break;
            case Ability.SandStream:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Sand, 5);
                break;
            case Ability.SnowWarning:
                //Ability popup
                yield return BattleEffect.StartWeather(this, Weather.Snow, 5);
                break;
            case Ability.Intimidate:
                //Todo: double/multi battle effect
                //Ability popup
                for (int i = 3 * (1 - (index / 3)); i < 3 * (2 - (index / 3)); i++)
                {
                    if (PokemonOnField[i].exists)
                    {
                        yield return PokemonOnField[i].ability is
                            Ability.Oblivious or Ability.OwnTempo or Ability.InnerFocus
                            or Ability.Scrappy
                            ? Announce(MonNameWithPrefix(i, true)
                            + "'s attack wasn't lowered because of "
                            + NameTable.Ability[(int)PokemonOnField[i].ability])
                            : BattleEffect.StatDown(this, i, Stat.Attack, 1, index);
                    }
                }
                break;
            case Ability.Trace:
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

    public IEnumerator MonAsleep(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.IsAsleep);
    }

    public IEnumerator WokeUp(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.WokeUp);
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

        Debug.Log("Executing for " + index);

        PokemonOnField[index].moveUsedThisTurn = Moves[index];
        if ((GetMove(index).moveFlags & MoveFlags.mimicBypass) == 0) PokemonOnField[index].lastMoveUsed = Moves[index];
        if (GetMove(index).effect == MoveEffect.Rage) PokemonOnField[index].isEnraged = true;
        else PokemonOnField[index].isEnraged = false;
        if (!PokemonOnField[index].dontCheckPP)
        {
            bool pressureAffected = false;
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].isTarget && HasAbility(i, Ability.Pressure)) pressureAffected = true;
            }
            PokemonOnField[index].lastMoveSlot = MoveNums[index];
            if (PokemonOnField[index].isTransformed)
            {
                switch (MoveNums[index])
                {
                    case 1:
                        PokemonOnField[index].transformedMon.pp1 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 2:
                        PokemonOnField[index].transformedMon.pp2 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 3:
                        PokemonOnField[index].transformedMon.pp3 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 4:
                        PokemonOnField[index].transformedMon.pp4 -= (byte)(pressureAffected ? 2 : 1); break;
                }
            }
            else
            {
                switch (MoveNums[index])
                {
                    case 1:
                        PokemonOnField[index].PokemonData.pp1 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 2:
                        PokemonOnField[index].PokemonData.pp2 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 3:
                        PokemonOnField[index].PokemonData.pp3 -= (byte)(pressureAffected ? 2 : 1); break;
                    case 4:
                        PokemonOnField[index].PokemonData.pp4 -= (byte)(pressureAffected ? 2 : 1); break;
                }
            }
        }
        yield return Announce(PokemonOnField[index].PokemonData.monName + " used " + GetMove(index).name + "!");

        switch (GetMove(index).effect)
        {
            case MoveEffect.MirrorMove:
                PokemonOnField[index].dontCheckPP = true;
                Moves[index] = PokemonOnField[index].lastTargetedMove;
                yield return ExecuteMove(index);
                yield break;
            case MoveEffect.Metronome:
                PokemonOnField[index].dontCheckPP = true;
                Moves[index] = (MoveID)(random.Next() % (int)MoveID.Count); //Todo: Add double or multi-battle functionality (targeting)
                yield return ExecuteMove(index);
                yield break;
            case MoveEffect.Sketch:
                {
                    MoveID targetMove = PokemonOnField[Targets[index]].lastMoveUsed;
                    if (targetMove == MoveID.None)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        PokemonOnField[index].done = true;
                        MoveCleanup();
                        yield break;
                    }
                    else
                    {
                        yield return DoMoveAnimation(index, Moves[index]);
                        PokemonOnField[index].PokemonData.AddMove(MoveNums[index], targetMove);
                        yield return Announce(MonNameWithPrefix(index, true) + " sketched " + MonNameWithPrefix(Targets[index], false) + "'s "
                            + Move.MoveTable[(int)targetMove].name + "!");
                        PokemonOnField[index].done = true;
                        MoveCleanup();
                        yield break;
                    }
                }
            case MoveEffect.Curse:
                if (!PokemonOnField[index].HasType(Type.Ghost))
                {
                    if (PokemonOnField[index].attackStage < 6 || PokemonOnField[index].defenseStage < 6
                        || PokemonOnField[index].speedStage > -6)
                    {
                        yield return BattleAnim.AttackerAnims(this, index, MoveID.NonGhostCurse, 0);
                    }
                    yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, index);
                    yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                    yield return BattleEffect.StatDown(this, index, Stat.Speed, 1, index);
                    PokemonOnField[index].done = true;
                    MoveCleanup();
                    yield break;
                }
                break;
            case MoveEffect.Snore:
                if (PokemonOnField[index].PokemonData.status != Status.Sleep && !HasAbility(index, Ability.Comatose))
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].done = true;
                    MoveCleanup();
                    yield break;
                }
                break;
            case MoveEffect.SleepTalk:
                if (PokemonOnField[index].PokemonData.status != Status.Sleep && !HasAbility(index, Ability.Comatose))
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].done = true;
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
                            Targets[index] = (byte)(3 - index);
                            break; //Todo: add double/multi battle functionality
                    }
                    List<int> possibleMoves = new List<int>();
                    if (PokemonOnField[index].GetPP(move1) > 0
                        && PokemonOnField[index].GetMove(move1) != MoveID.None)
                    {
                        possibleMoves.Add(move1);
                    }
                    if (PokemonOnField[index].GetPP(move2) > 0
                        && PokemonOnField[index].GetMove(move2) != MoveID.None)
                    {
                        possibleMoves.Add(move2);
                    }
                    if (PokemonOnField[index].GetPP(move3) > 0
                        && PokemonOnField[index].GetMove(move3) != MoveID.None)
                    {
                        possibleMoves.Add(move3);
                    }
                    if (possibleMoves.Count == 0)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        PokemonOnField[index].done = true;
                        MoveCleanup();
                        yield break;
                    }
                    else
                    {
                        int whichMove = random.Next() % possibleMoves.Count;
                        Moves[index] = PokemonOnField[index].GetMove(possibleMoves[whichMove]);
                        MoveNums[index] = (byte)possibleMoves[whichMove];
                        yield return ExecuteMove(index);
                        yield break;
                    }
                }
            case MoveEffect.Magnitude:
                (int magnitude, byte power) magnitudeData = random.NextDouble() switch
                {
                    < 0.05 => (4, 10),
                    < 0.15 => (5, 30),
                    < 0.35 => (6, 50),
                    < 0.65 => (7, 70),
                    < 0.85 => (8, 90),
                    < 0.95 => (9, 110),
                    _ => (10, 150),
                };
                yield return Announce("Magnitude " + magnitudeData.magnitude);
                singleMovePower = magnitudeData.power;
                break;
        }
        if (GetMove(index).targets == TargetID.Field)
        {
            yield return DoFieldEffect(index, GetMove(index).effect);
            PokemonOnField[index].done = true;
            MoveCleanup();
            yield break;
        }
        switch (GetMove(index).effect)
        {
            case MoveEffect.Counter:
                if (Moves[index] == (PokemonOnField[index].damageWasPhysical ?
                    MoveID.Counter : MoveID.MirrorCoat))
                {
                    //Debug.Log("Confirm Counter should work");
                    if (PokemonOnField[PokemonOnField[index].lastDamageDoer].exists)
                    {
                        PokemonOnField[PokemonOnField[index].lastDamageDoer].isTarget = true;
                    }
                }
                break;
            case MoveEffect.Thrash:
                PokemonOnField[GetRandomOpponentMon(index > 2)].isTarget = true;
                //Debug.Log("Handling thrash effect");
                if (!PokemonOnField[index].thrashing)
                {
                    PokemonOnField[index].thrashing = true;
                    PokemonOnField[index].lockedInMove = Moves[index];
                    PokemonOnField[index].thrashingTimer = 0;
                }
                break;
            case MoveEffect.SelfDestruct:
                PokemonOnField[index].PokemonData.HP = 0;
                PokemonOnField[index].PokemonData.fainted = true;
                goto default;
            case MoveEffect.Teleport:
                if (PokemonOnField[index].player)
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
                        PokemonOnField[index].done = true;
                        yield break;

                    }
                    yield return BattleAnim.AttackerAnims(this, index, MoveID.Teleport, 0);
                    LeaveFieldCleanup(index);
                    yield return BattleEffect.VoluntarySwitch(this, 0, nextMon);
                }
                yield break;
            case MoveEffect.BatonPass:
                if (PokemonOnField[index].player)
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
                        PokemonOnField[index].done = true;
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
            || ((GetMove(index).targets & TargetID.Self) != 0
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
                PokemonOnField[index].rechargeNextTurn = true;
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
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].lockedInMove = MoveID.RazorWindAttack;
                        break;
                    case MoveID.Fly:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].invulnerability = Invulnerability.Fly;
                        PokemonOnField[index].lockedInMove = MoveID.FlyAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " flew up high!");
                        break;
                    case MoveID.Dig:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].invulnerability = Invulnerability.Dig;
                        PokemonOnField[index].lockedInMove = MoveID.DigAttack;
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
                            PokemonOnField[index].lockedInNextTurn = true;
                            PokemonOnField[index].lockedInMove = MoveID.SolarBeamAttack;
                            break;
                        }
                    case MoveID.SkyAttack:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].lockedInMove = MoveID.SkyAttackAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " became cloaked in a harsh light!");
                        break;
                    case MoveID.SkullBash:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].lockedInMove = MoveID.SkullBashAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " lowered its head!");
                        yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                        break;
                    case MoveID.Bide:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].lockedInMove = MoveID.BideMiddle;
                        PokemonOnField[index].bideDamage = 0;
                        PokemonOnField[index].biding = true;
                        yield return Announce(MonNameWithPrefix(index, true) + " began storing energy!");
                        break;
                    case MoveID.BideMiddle:
                        PokemonOnField[index].lockedInNextTurn = true;
                        PokemonOnField[index].lockedInMove = MoveID.BideAttack;
                        yield return Announce(MonNameWithPrefix(index, true) + " is storing energy!");
                        break;
                    default:
                        break;
                }
                if (GoToHit) { goto default; }
                break;
            case MoveEffect.MultiHit2to5 or MoveEffect.MultiHit2 or MoveEffect.Twineedle or MoveEffect.TripleHit:
                {
                    if (hitAnyone)
                    {
                        int hits;
                        switch (GetMove(index).effect)
                        {
                            case MoveEffect.MultiHit2to5:
                                if (HasAbility(index, Ability.SkillLink))
                                {
                                    hits = 5;
                                }
                                else
                                {
                                    switch (random.Next() % 20)
                                    {
                                        case int n when n is >= 0 and < 7:
                                            hits = 2;
                                            break;
                                        case int n when n is >= 7 and < 14:
                                            hits = 3;
                                            break;
                                        case int n when n is >= 14 and < 17:
                                            hits = 4;
                                            break;
                                        case int n when n is >= 17 and < 20:
                                            hits = 5;
                                            break;
                                        default:
                                            hits = 2;
                                            break;
                                    }
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
                                (byte)(GetMove(index).power * (i + 1)));
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
                                && !HasAbility(index, Ability.SkillLink))
                            {
                                hits = i + 1;
                                break;
                            }
                        }
                        yield return Announce("Hit " + hits + (hits == 1 ? " time!" : " times!"));
                    }
                    bool targetsAnyone = false;

                    for (int i = 0; i < 6; i++)
                    {
                        if (PokemonOnField[i].isHit)
                        {
                            float effectiveness = GetTypeEffectiveness(GetEffectiveType(Moves[index], index), PokemonOnField[i]);
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
                    bool targetsAnyone = false;
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
                                float effectiveness = GetTypeEffectiveness(GetEffectiveType(Moves[index], index), PokemonOnField[i]);
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
                        PokemonOnField[index].thrashing = false;
                    }
                    yield return ProcessFainting();
                    yield return HandleMoveEffect(index);
                    break;
                }
        }

        switch (GetMove(index).effect)
        {
            case MoveEffect.Recoil33:
                PokemonOnField[index].DoNonMoveDamage(Max(1,PokemonOnField[index].moveDamageDone / 3));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25:
                PokemonOnField[index].DoNonMoveDamage(Max(1, PokemonOnField[index].moveDamageDone / 4));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25Max:
                PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax >> 2);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Thrash:
                PokemonOnField[index].thrashingTimer++;
                if (PokemonOnField[index].thrashingTimer == 3
                    || PokemonOnField[index].thrashingTimer == 2
                    && random.NextDouble() > 0.5)
                {
                    yield return BattleEffect.Confuse(this, index);
                    PokemonOnField[index].thrashing = false;
                }
                break;
            case MoveEffect.Crash50Max when PokemonOnField[index].moveDamageDone == 0:
                if (PokemonOnField[index].PokemonData.hpMax >> 1 > PokemonOnField[index].PokemonData.HP)
                {
                    PokemonOnField[index].PokemonData.HP = 0;
                    PokemonOnField[index].PokemonData.fainted = true;
                }
                else
                {
                    PokemonOnField[index].PokemonData.HP -=
                        PokemonOnField[index].PokemonData.hpMax >> 1;
                }
                yield return Announce(MonNameWithPrefix(index, true) + " kept going and crashed!");
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.SelfDestruct:
                yield return ProcessFaintingSingle(index);
                break;
            default:
                break;
        }
        if (GetMove(index).effect == MoveEffect.FuryCutter && PokemonOnField[index].moveDamageDone > 0)
        {
            if (PokemonOnField[index].furyCutterIntensity < 3) PokemonOnField[index].furyCutterIntensity++;
        }
        else PokemonOnField[index].furyCutterIntensity = 0;
        for (int i = 0; i < 6; i++)
        {
            yield return DoAbilityEffects(i);
        }
        PokemonOnField[index].done = true;
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
                float thisEff = GetTypeEffectiveness(GetEffectiveType(Moves[index], index), PokemonOnField[i]);
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
            case MoveEffect.TriAttack:
                yield return BattleEffect.TriAttack(this, index);
                break;
            case MoveEffect.LeechSeed:
                yield return BattleEffect.GetLeechSeed(this, index, attacker);
                break;
            case MoveEffect.Spite:
                yield return BattleEffect.DrainPP(this, index, 4);
                break;
            case MoveEffect.Disable:
                yield return BattleEffect.Disable(this, index);
                break;
            case MoveEffect.Trap:
                yield return BattleEffect.StartTrapping(this, attacker, index);
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
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                break;
            case MoveEffect.Minimize:
                PokemonOnField[index].minimized = true;
                goto case MoveEffect.EvasionUp2;
            case MoveEffect.DefenseCurl:
                PokemonOnField[index].usedDefenseCurl = true;
                goto case MoveEffect.DefenseUp1;
            case MoveEffect.Flinch:
            case MoveEffect.Snore:
                PokemonOnField[index].flinched = true;
                break;
            case MoveEffect.Substitute:
                yield return BattleEffect.MakeSubstitute(this, index);
                break;
            case MoveEffect.PainSplit:
                yield return BattleEffect.PainSplit(this, index, attacker);
                break;
            case MoveEffect.Thief:
                yield return BattleEffect.Thief(this, attacker, index);
                break;
            case MoveEffect.Absorb50:
            case MoveEffect.DreamEater:
                if (PokemonOnField[index].moveDamageDone == 0) { break; }
                bool doAnnouncement = PokemonOnField[index].PokemonData.HP == PokemonOnField[index].PokemonData.hpMax
                    ? false : true;
                yield return BattleEffect.Heal(this, index, Max(1, PokemonOnField[index].moveDamageDone / 2));
                if (doAnnouncement)
                {
                    if (battleType == BattleType.Single)
                    {
                        yield return Announce(MonNameWithPrefix(3 - index, true) + BattleText.Absorb);
                    }
                }
                break;
            case MoveEffect.Rollout:
                if (PokemonOnField[index].rolloutIntensity < 4 && PokemonOnField[index].moveDamageDone > 0)
                {
                    PokemonOnField[index].lockedInNextTurn = true;
                    PokemonOnField[index].lockedInMove = PokemonOnField[index].moveUsedThisTurn;
                    PokemonOnField[index].rolloutIntensity++;
                }
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
            case MoveEffect.Protect:
                yield return Announce(MonNameWithPrefix(index, true) + " protected itself!");
                PokemonOnField[index].protect = true;
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
                case Ability.SolarPower:
                    if (weather == Weather.Sun)
                    {
                        PokemonOnField[i].PokemonData.HP -= PokemonOnField[i].PokemonData.hpMax << 3;
                        yield return Announce(MonNameWithPrefix(i, true) + " is hurt by Solar Power!");
                    }
                    break;
                case Ability.DrySkin:
                    switch (weather)
                    {
                        case Weather.Sun:
                            PokemonOnField[i].PokemonData.HP -= PokemonOnField[i].PokemonData.hpMax << 3;
                            yield return Announce(MonNameWithPrefix(i, true) + " is hurt by Dry Skin!");
                            break;
                        case Weather.Rain:
                            yield return BattleEffect.Heal(this, i, PokemonOnField[i].PokemonData.hpMax << 3);
                            yield return Announce(MonNameWithPrefix(i, true) + " is healed by Dry Skin!");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (!HasAbility(i, Ability.MagicGuard))
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
            }
            if (PokemonOnField[i].ability == Ability.SpeedBoost)
            {
                yield return BattleEffect.StatUp(this, i, Stat.Speed, 1, i);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (Sides[i].lightScreen)
            {
                Sides[i].lightScreenTurns--;
                if (Sides[i].lightScreenTurns <= 0)
                {
                    Sides[i].lightScreen = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's" + " Light Screen wore off!");
                }
            }
            if (Sides[i].reflect)
            {
                Sides[i].reflectTurns--;
                if (Sides[i].reflectTurns <= 0)
                {
                    Sides[i].reflect = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's" + " Reflect wore off!");
                }
            }
            if (Sides[i].mist)
            {
                Sides[i].mistTurns--;
                if (Sides[i].mistTurns <= 0)
                {
                    Sides[i].mist = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's" + " Mist wore off!");
                }
            }
            if (Sides[i].safeguard)
            {
                Sides[i].safeguardTurns--;
                if (Sides[i].safeguardTurns <= 0)
                {
                    Sides[i].safeguard = false;
                    yield return Announce("The mystical veil surrounding " + (i == 0 ? "the foes'" : "your") + " team wore off!");
                }
            }
        }
        if (weather != Weather.None)
        {
            BattleEffect.WeatherContinues(this);
        }
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
                    menuManager.menuMode = MenuMode.Party;
                    state = BattleState.PlayerInput;
                    while (!choseSwitchMon)
                    {
                        yield return new WaitForSeconds(0.2F);
                    }
                    yield return BattleEffect.VoluntarySwitch(this, 3, switchingTarget);
                }
                break;
        }
        for (int i = 0; i < 6; i++)
        {
            //Debug.Log("Index " + i + " exists: " + PokemonOnField[i].exists);
            if (PokemonOnField[i].exists)
            {
                PokemonOnField[i].done = false;
                PokemonOnField[i].isTarget = false;
                PokemonOnField[i].isHit = false;
                PokemonOnField[i].isMissed = false;
                PokemonOnField[i].isUnaffected = false;
                PokemonOnField[i].choseMove = false;
                PokemonOnField[i].dontCheckPP = false;
                PokemonOnField[i].damageTaken = 0;
                PokemonOnField[i].protect = false;
                PokemonOnField[i].moveUsedThisTurn = MoveID.None;

                PokemonOnField[i].flinched = false;
            }
            else
            {
                PokemonOnField[i].done = true;
            }

            if (PokemonOnField[i].lockedInNextTurn)
            {
                PokemonOnField[i].lockedInNextTurn = false;
                PokemonOnField[i].choseMove = true;
                Moves[i] = PokemonOnField[i].lockedInMove;
                PokemonOnField[i].dontCheckPP = true;
            }
            else
            {
                PokemonOnField[i].rolloutIntensity = 0; //Reset if Rollout ended or was interrupted
            }
            if (PokemonOnField[i].thrashing)
            {
                Moves[i] = PokemonOnField[i].lockedInMove;
                PokemonOnField[i].dontCheckPP = true;
                PokemonOnField[i].choseMove = true;
            }
            if (PokemonOnField[i].rechargeNextTurn)
            {
                PokemonOnField[i].rechargeNextTurn = false;
                PokemonOnField[i].choseMove = true;
                Moves[i] = MoveID.Recharge;
                PokemonOnField[i].dontCheckPP = true;
            }
            if (PokemonOnField[i].exists && !PokemonOnField[i].player
                && !PokemonOnField[i].choseMove)
            { ChooseAIMove(i); }
        }
        if (!menuManager.GetNextPokemon())
        {
            menuManager.menuMode = MenuMode.Main;
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
        if (PokemonOnField[index].GetPP(move - 1) > 0)
        {
            Moves[index] = PokemonOnField[index].GetMove(move - 1);
            MoveNums[index] = (byte)move;
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
        MoveNums[index] = (byte)move.moveNum;
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
            if (tryMove == MoveID.None
                || tryMove == PokemonOnField[index].disabledMove
                || PokemonOnField[index].GetPP(i - 1) <= 0)
            {
                continue;
            }
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

    public bool CanMegaEvolve(int index)
    {
        //Appears to be broken, but I haven't figured out why yet!
        return (index >= 3 || !hasOpponentMegaEvolved) && (index < 3 || !hasPlayerMegaEvolved)
            && Item.ItemTable[PokemonOnField[index].item].type == ItemType.MegaStone
            && Item.ItemTable[PokemonOnField[index].item].ItemSubdata[0]
            == (int)PokemonOnField[index].PokemonData.species;
    }

    public IEnumerator DoMegaEvolution(int index)
    {
        //Todo: Add mega animation
        PokemonOnField[index].PokemonData.temporarySpecies =
            (SpeciesID)Item.ItemTable[(int)PokemonOnField[index].PokemonData.item].ItemSubdata[1];
        yield return Announce(MonNameWithPrefix(index, true) + " has Mega Evolved into "
            + Species.SpeciesTable[(int)PokemonOnField[index].PokemonData.temporarySpecies].speciesName + "!");
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