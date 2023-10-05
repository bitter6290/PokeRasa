// Battle config

#define ALL_GET_FULL_EXP // Comment to use pre-gen 6 experience distribution
#define FRIENDSHIP_RAISES_EXP // Comment to get rid of the boost to XP gain
// with high friendship


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static System.Math;
using static Ability;
using static BerryEffect;
using static ItemID;
using static MoveFlags;
using static MoveEffect;

public class Battle : MonoBehaviour
{
    private const int TurnOver = 63;
    private const int NoMons = 63;
    private const int HandleMega = 127;

    public Player player;

    public bool wildBattle;
    public int escapeAttempts;

    public Pokemon[] OpponentPokemon = new Pokemon[6];
    public Pokemon[] PlayerPokemon = new Pokemon[6];
    public Pokemon[] Party(int index) => index < 3 ?
        OpponentPokemon : PlayerPokemon;

    public int faintedMons(int index)
    {
        int count = 0;
        foreach (Pokemon p in Party(index))
        {
            if (p.exists && p.fainted) count++;
        }
        return count;
    }

    public BattleState state;
    public int currentPlayerMon = 4;

    public string OpponentName = "Error 401";

    public TextMeshProUGUI Announcer;

    public MaskManager[] maskManager;
    public MenuManager menuManager;
    public HealthBarManager[] healthBarManager;
    public XPController xpController;

    public AbilityPopupController[] abilityControllers = new AbilityPopupController[6];

    public SpriteRenderer[] spriteRenderer;
    public Transform[] spriteTransform;

    public AudioSource audioSource0;
    public AudioSource audioSource1;

    public bool[] megaEvolveOnMove = new bool[6];
    public bool hasPlayerMegaEvolved = false;
    public bool hasOpponentMegaEvolved = false;
    private int monToMega = 0;

    public bool menuOpen = false;

    public bool[] healingWish = new bool[6];

    public int textSpeed = 25;
    public float persistenceTime = 1.5F;

    public bool partyBackButtonInactive;
    public int switchingMon;
    public int switchingTarget;
    public bool choseSwitchMon;

    public int turnsElapsed;

    public bool pursuitHitsOnSwitch;

    public bool followMeActive;

    public List<string> announcementLog = new();

    private int singleMovePower; //used for Magnitude

    public bool continueMultiHitMove;

    public bool consumeItems = true;

    public bool doStatAnim = true;

    public ItemID flungItem = ItemID.None;

    public MoveID lastMoveUsed = MoveID.None;

    public int currentMovingMon;

    private bool doRound = false;

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

    public bool mudSport;
    public int mudSportTimer;

    public bool waterSport;
    public int waterSportTimer;

    public bool snatch;
    public int snatchingMon;

    public bool[,] playerFacedOpponent = new bool[6, 6];

    public Queue<(int wishHP, int turn, int slot, string wisher)> wishes = new();
    public Queue<FutureSightStruct> futureSight = new();
    public bool[] isFutureSightTargeted = new bool[6];

    public Queue<(int source, int target, Ability ability)> abilityEffects = new();

    public bool[] doAbilityEffect = new bool[6];

    public bool oneAnnouncementDone; //Used for Perish Song

    public System.Random random = new();

    public BattlePokemon[] PokemonOnField;

    private bool PlayerHasMonsInBack
    {
        get
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
    }

    private bool OpponentLost
    {
        get
        {
            for (int i = 0; i < 6; i++)
                if (!OpponentPokemon[i].fainted) return false;
            return true;
        }
    }

    public Side[] Sides = new Side[2];

    public BattleType battleType;


    public MoveID[] Moves = new MoveID[6];
    public int[] SwitchTargets = new int[6];
    public int[] Targets = new int[6];
    public int[] MoveNums = new int[6];

    public Sprite[] playerMonIcons = new Sprite[6];
    public Sprite[] playerMonIcons2 = new Sprite[6]; 

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

    public bool MoveImprisoned(MoveID move, int user)
    {
        for (int i = GetSide(user) * 3; i < GetSide(user) * 3 + 3; i++)
        {
            BattlePokemon checkedMon = PokemonOnField[i];
            if (checkedMon.imprisoned)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (checkedMon.GetMove(j) == move) return true;
                }
            }
        }
        return false;
    }

    public bool AllOthersDone(int index)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].done || i == index) continue;
            return false;
        }
        return true;
    }

    public List<int>[] GetNeighbors => new List<int>[6]
    {
        new(){ 1 },
        new(){ 0 , 2 },
        GetNeighbors[0],
        new(){ 4 },
        new() { 3 , 5 },
        GetNeighbors[3]
    };

    public bool SharesType(int a, int b)
    {
        BattlePokemon MonA = PokemonOnField[a];
        Type[] TypesToCheck = MonA.hasType3 ?
            new Type[] { MonA.Type1, MonA.Type2, MonA.Type3 } :
            new Type[] { MonA.Type1, MonA.Type2 };
        foreach (Type t in TypesToCheck)
        {
            if (PokemonOnField[b].HasType(t)) return true;
        }
        return false;
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
        ? ItemID.None : PokemonOnField[index].item;

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

    private int GetEffectiveWeightMovePower(int index) =>
        WeightMovePower(GetEffectiveWeight(index));

    private int GetEffectiveWeight(int index)
    {
        int weight = PokemonOnField[index].EffectiveWeight;
        if (HasAbility(index, LightMetal)) weight >>= 1;
        else if (HasAbility(index, HeavyMetal)) weight <<= 1;
        return weight;
    }


    private static int RelativeWeightMovePower(float ratio) => ratio switch
    {
        <= 0.2F => 120,
        <= 0.25F => 100,
        < 0.3334F => 80,
        <= 0.5F => 60,
        _ => 40,
    };

    private int GetRelativeWeightMovePower(int attacker, int defender)
        => RelativeWeightMovePower(
            ((float)GetEffectiveWeight(defender)) / GetEffectiveWeight(attacker));

    private static int HighSpeedMovePower(float ratio) => ratio switch
    {
        0 => 40,
        <= 0.25F => 150,
        < 0.3334F => 120,
        <= 0.5F => 80,
        <= 1.0F => 60,
        _ => 40
    };

    private int GetHighSpeedMovePower(int attacker, int defender)
        => HighSpeedMovePower(((float)GetSpeed(attacker)) / GetSpeed(defender));

    private static int ReversalPower(int HP, int maxHP) => (HP * 48 / maxHP switch
    {
        < 2 => 200,
        < 5 => 150,
        < 10 => 100,
        < 17 => 80,
        < 33 => 40,
        _ => 20,
    });

    private int LowSpeedMovePower(int attacker, int defender)
    {
        int basePower = 25 * GetSpeed(defender) / GetSpeed(attacker) + 1;
        return Min(150, basePower);
    }

    public bool AbilityOnSide(Ability ability, int side)
    {
        for (int i = side * 3; i < (side * 3) + 3; i++)
            if (EffectiveAbility(i) == ability) return true;
        return false;
    }

    public bool AbilityOnField(Ability ability)
    {
        for (int i = 0; i < 6; i++)
            if (EffectiveAbility(i) == ability) return true;
        return false;
    }

    private bool AbilitiesSuppressed =>
        PokemonOnField[0].ability == NeutralizingGas
        || PokemonOnField[1].ability == NeutralizingGas
        || PokemonOnField[2].ability == NeutralizingGas
        || PokemonOnField[3].ability == NeutralizingGas
        || PokemonOnField[4].ability == NeutralizingGas
        || PokemonOnField[5].ability == NeutralizingGas;

    public bool FlowerGiftOnSide(int side)
    {
        for (int i = side * 3; i < (side * 3) + 3; i++)
            if (HasAbility(i, FlowerGift) && IsWeatherAffected(i, Weather.Sun))
                return true;
        return false;
    }

    public bool UproarOnField =>
        PokemonOnField[0].uproar
        || PokemonOnField[1].uproar
        || PokemonOnField[2].uproar
        || PokemonOnField[3].uproar
        || PokemonOnField[4].uproar
        || PokemonOnField[5].uproar;

    public bool MakesContact(int attacker, MoveID move) =>
        !HasAbility(attacker, LongReach) && move.HasFlag(makesContact);

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
            RealEffectiveness(attacker.index, defender.index, effectiveType1, move)
            : RealEffectiveness(attacker.index, defender.index, effectiveType1, move)
            * RealEffectiveness(attacker.index, defender.index, effectiveType2, move);
        if (defender.hasType3)
        {
            effectiveness *= RealEffectiveness(attacker.index, defender.index, defender.Type3, move);
        }
        if (effectiveType1 == Type.Flying && effectiveType2 == Type.Flying
            && defender.roosting)
            return RealEffectiveness(attacker.index, defender.index, Type.Normal, move);
        return effectiveness;
    }

    public bool IsImmune(BattlePokemon attacker, BattlePokemon defender, MoveID move)
        => GetTypeEffectiveness(attacker, defender, move) == 0;

    public float RealEffectiveness(int attacker, int defender, Type defenderType, MoveID move)
    {
        Type moveType = GetEffectiveType(move, attacker);
        if (moveType == Type.Ground)
        {
            if (!IsGrounded(defender)) return 0.0F;
            else if (IsGrounded(defender) && defenderType == Type.Flying) return 1.0F;
        }
        if (defenderType == Type.Flying && PokemonOnField[defender].roosting) return 1.0F;
        if (defenderType == Type.Ghost && moveType is Type.Normal or Type.Fighting
            && PokemonOnField[defender].identified
            && !PokemonOnField[defender].identifiedByMiracleEye) return 1.0F;
        if (defenderType == Type.Dark && moveType == Type.Psychic
            && PokemonOnField[defender].identified
            && PokemonOnField[defender].identifiedByMiracleEye) return 1.0F;
        return TypeUtils.Effectiveness(moveType, defenderType);
    }

    public bool IsGrounded(int index)
    {
        if (gravity ||
            PokemonOnField[index].smackDown ||
            PokemonOnField[index].ingrained) return true;
        if (HasAbility(index, Levitate) ||
            PokemonOnField[index].magnetRise ||
            PokemonOnField[index].telekinesis) return false;
        if (PokemonOnField[index].roosting) return true;
        if (PokemonOnField[index].HasType(Type.Flying)) return false;
        return true;
    }

    public bool HasAbility(int index, Ability ability)
    {
        if (ability.Unchangeable()) return PokemonOnField[index].ability == ability;
        return !AbilitiesSuppressed && !PokemonOnField[index].abilitySuppressed
            && PokemonOnField[index].ability == ability;
    }

    public Ability EffectiveAbility(int index)
    {
        if (PokemonOnField[index].ability.Unchangeable()) return PokemonOnField[index].ability;
        return AbilitiesSuppressed || PokemonOnField[index].abilitySuppressed ?
            Ability.None : PokemonOnField[index].ability;
    }

    public bool HasMoldBreaker(int index)
        => EffectiveAbility(index) is MoldBreaker or Teravolt or Turboblaze
        || (HasAbility(index, MyceliumMight) && GetMove(index).power == 0);

    public Type GetEffectiveType(MoveID move, int index)
    {
        Type effectiveType = move.Data().type;
        switch (move.Data().effect)
        {
            case HiddenPower:
                effectiveType = PokemonOnField[index].PokemonData.hiddenPowerType;
                break;
            case WeatherBall:
                effectiveType = weather switch
                {
                    Weather.Sun => Type.Fire,
                    Weather.Rain => Type.Water,
                    Weather.Sand => Type.Ground,
                    Weather.Snow => Type.Ice,
                    _ => Type.Normal,
                };
                break;
            case NaturalGift:
                switch (EffectiveItem(index))
                {
                    case ChilanBerry:
                        return Type.Normal;
                    case CheriBerry:
                    case BlukBerry:
                    case WatmelBerry:
                    case OccaBerry:
                        return Type.Fire;
                    case ChestoBerry:
                    case NanabBerry:
                    case DurinBerry:
                    case PasshoBerry:
                        return Type.Water;
                    case PechaBerry:
                    case WepearBerry:
                    case BelueBerry:
                    case WacanBerry:
                        return Type.Electric;
                    case RawstBerry:
                    case PinapBerry:
                    case RindoBerry:
                    case LiechiBerry:
                        return Type.Grass;
                    case AspearBerry:
                    case PomegBerry:
                    case YacheBerry:
                    case GanlonBerry:
                        return Type.Ice;
                    case LeppaBerry:
                    case KelpsyBerry:
                    case ChopleBerry:
                    case SalacBerry:
                        return Type.Fighting;
                    case OranBerry:
                    case QualotBerry:
                    case KebiaBerry:
                    case PetayaBerry:
                        return Type.Poison;
                    case PersimBerry:
                    case HondewBerry:
                    case ShucaBerry:
                    case ApicotBerry:
                        return Type.Ground;
                    case LumBerry:
                    case GrepaBerry:
                    case CobaBerry:
                    case LansatBerry:
                        return Type.Flying;
                    case SitrusBerry:
                    case TamatoBerry:
                    case PayapaBerry:
                    case StarfBerry:
                        return Type.Psychic;
                    case FigyBerry:
                    case CornnBerry:
                    case TangaBerry:
                    case EnigmaBerry:
                        return Type.Bug;
                    case WikiBerry:
                    case MagostBerry:
                    case ChartiBerry:
                    case MicleBerry:
                        return Type.Rock;
                    case MagoBerry:
                    case RabutaBerry:
                    case KasibBerry:
                    case CustapBerry:
                        return Type.Ghost;
                    case AguavBerry:
                    case NomelBerry:
                    case HabanBerry:
                    case JabocaBerry:
                        return Type.Dragon;
                    case IapapaBerry:
                    case SpelonBerry:
                    case ColburBerry:
                    case RowapBerry:
                    case MarangaBerry:
                        return Type.Dark;
                    case RazzBerry:
                    case PamtreBerry:
                    case BabiriBerry:
                        return Type.Steel;
                    case RoseliBerry:
                    case KeeBerry:
                        return Type.Fairy;
                    default:
                        break;
                }
                break;
            case Judgement:
                return EffectiveItem(index).PlateType();
            default: break;
        }
        switch (EffectiveAbility(index))
        {
            case Aerilate when effectiveType == Type.Normal:
                PokemonOnField[index].gotAteBoost = true;
                effectiveType = Type.Flying;
                break;
            case Refrigerate when effectiveType == Type.Normal:
                PokemonOnField[index].gotAteBoost = true;
                effectiveType = Type.Ice;
                break;
            case Galvanize when effectiveType == Type.Normal:
                PokemonOnField[index].gotAteBoost = true;
                effectiveType = Type.Electric;
                break;
            case Pixilate when effectiveType == Type.Normal:
                PokemonOnField[index].gotAteBoost = true;
                effectiveType = Type.Fairy;
                break;
            case LiquidVoice when move.HasFlag(soundMove):
                effectiveType = Type.Water;
                break;
            case Normalize:
                effectiveType = Type.Normal;
                break;

        }
        return effectiveType;
    }

    public int GetAttack(int index, bool crit)
    {
        int attack = crit && PokemonOnField[index].attackStage < 0 ?
            PokemonOnField[index].BaseAttack : PokemonOnField[index].attack;
        attack = (int)(attack * EffectiveAbility(index) switch
        {
            HugePower or PurePower => 2,
            Hustle => 1.5,
            GorillaTactics => 1.5,
            _ => 1,
        });
        if (FlowerGiftOnSide(index / 3)) attack += attack >> 1;
        return attack;
    }

    public int GetDefenseRaw(int index, bool crit)
    {
        int defense = crit && PokemonOnField[index].defenseStage > 0 ?
            PokemonOnField[index].BaseDefense : PokemonOnField[index].defense;
        defense = (int)(defense * EffectiveAbility(index) switch
        {
            GrassPelt when EffectiveTerrain(index) == Terrain.Grassy => 1.5F,
            _ => 1,
        });;
        return defense;
    }

    public int GetDefense(int index, bool crit)
    {
        return wonderRoom ? GetSpDefRaw(index, crit) : GetDefenseRaw(index, crit);
    }

    public int GetSpAtk(int index, bool crit)
    {
        int spAtk = crit && PokemonOnField[index].spAtkStage < 0 ?
            PokemonOnField[index].BaseSpAtk : PokemonOnField[index].spAtk;
        spAtk = (int)(spAtk * EffectiveAbility(index) switch
        {
            Defeatist when PokemonOnField[index].HealthProportion < 0.5F => 0.5F,
            _ => 1,
        });
        return spAtk;
    }

    public int GetSpDefRaw(int index, bool crit)
    {
        int spDef = crit && PokemonOnField[index].spDefStage < 0 ?
            PokemonOnField[index].BaseSpDef : PokemonOnField[index].spDef;
        if (FlowerGiftOnSide(index / 3)) spDef += spDef >> 1;
        return spDef;
    }

    public int GetSpdef(int index, bool crit)
    {
        return wonderRoom ? GetDefenseRaw(index, crit) : GetSpDefRaw(index, crit);
    }

    public int GetSpeed(int index)
    {
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
        if (Sides[index / 3].tailwind) speed <<= 1;
        if (trickRoom) speed = 10000 - speed;
        if (HasAbility(index, Stall)) speed -= 32768;
        if (HasAbility(index, MyceliumMight) && GetMove(index).power == 0) speed -= 32768;
        return speed;
    }

    private int GetPriority(int index)
    {
        int priority = GetMove(index).priority;
        switch (EffectiveAbility(index))
        {
            case GaleWings when (PokemonOnField[index].AtFullHealth &&
                    GetEffectiveType(Moves[index], index) == Type.Flying): priority++;
                break;
            case Prankster when (GetMove(index).power == 0): priority++; break;
            case Triage when Moves[index].TriageAffected(): priority += 3; break;
        }
        if (PokemonOnField[index].custapPriorityBoost)
        {
            priority++;
            PokemonOnField[index].custapPriorityBoost = false;
        }
        if (GetMove(index).effect == MoveEffect.Round && doRound)
        {
            priority += 20;
        }
        return priority;
    }

    private int FindNextToMove()
    {
        const int megaPriority = 29;
        const int itemPriority = 30;
        const int switchPriority = 31;
        int currentPriority = -127;
        int currentSpeed = 0;
        int currentMove = TurnOver;

        List<int> speedTieList = new();
        for (int i = 0; i < 6; i++)
        {
            if (megaEvolveOnMove[i])
            {
                currentPriority = megaPriority;
                currentMove = HandleMega;
            }
        }
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
                        speedTieList = new() { i };
                        Debug.Log("Index " + i + " has speed " + currentSpeed);
                    }
                    if (GetSpeed(i) > currentSpeed)
                    {
                        currentSpeed = GetSpeed(i);
                        currentMove = i;
                        speedTieList = new() { i };
                        Debug.Log("Index " + i + " has speed " + currentSpeed);
                    }
                    else if (GetSpeed(i) == currentSpeed)
                    {
                        speedTieList.Add(i);
                    }
                }
                else if (Moves[i] == MoveID.UseItem)
                {
                    if (currentPriority < itemPriority)
                    {
                        currentPriority = itemPriority;
                        currentSpeed = GetSpeed(i);
                        currentMove = i;
                        speedTieList = new() { i };
                    }
                }
                else if (megaEvolveOnMove[i])
                {
                    if (currentPriority < megaPriority)
                    {
                        currentPriority = megaPriority;
                        currentSpeed = GetSpeed(i);
                        currentMove = HandleMega;
                        monToMega = i;
                        speedTieList = new() { i };
                    }
                    else if (currentPriority == megaPriority
                        && GetSpeed(i) > currentSpeed)
                    {
                        currentSpeed = GetSpeed(i);
                        monToMega = i;
                        speedTieList = new() { i };
                    }
                    else if (currentPriority == megaPriority
                        && GetSpeed(i) == currentSpeed)
                    {
                        speedTieList.Add(i);
                    }
                }
                else if (GetPriority(i) > currentPriority)
                {
                    currentPriority = GetPriority(i);
                    currentSpeed = GetSpeed(i);
                    currentMove = i;
                    speedTieList = new() { i };
                    Debug.Log("Index " + i + " has priority " + currentPriority
                        + " and speed " + currentSpeed);
                }
                else if (GetPriority(i) == currentPriority
                    && GetSpeed(i) > currentSpeed)
                {
                    currentSpeed = GetSpeed(i);
                    currentMove = i;
                    speedTieList = new() { i };
                    Debug.Log("Index " + i + " has speed " + currentSpeed);
                }
                else if (GetPriority(i) == currentPriority
                    && GetSpeed(i) == currentSpeed)
                {
                    speedTieList.Add(i);
                }
            }
        }
        pursuitHitsOnSwitch = false;
        if (currentPriority == switchPriority)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Moves[i] > MoveID.StandardCount) continue;
                if (GetMove(i).effect == Pursuit && Targets[i] == currentMove)
                {
                    pursuitHitsOnSwitch = true;
                    return i;

                }
            }
        }
        if (speedTieList.Count > 1) currentMove = speedTieList[random.Next() % speedTieList.Count];
        return currentMove;
    }

    private float GetAccuracy(MoveID move, int attacker, int defender)
    {
        if (move.Data().effect == OHKO)
        {
            int levelDifference = PokemonOnField[attacker].PokemonData.level
                - PokemonOnField[defender].PokemonData.level;
            if (levelDifference < 0) return 0;
            if (move == MoveID.SheerCold && !PokemonOnField[attacker].HasType(Type.Ice))
                return (20 + levelDifference) / 100.0F;
            else return (30 + levelDifference) / 100.0F;
        }
        float result = move.Data().accuracy
            * BattlePokemon.StageToModifierAccEva(PokemonOnField[attacker].accuracyStage)
            / BattlePokemon.StageToModifierAccEva(PokemonOnField[defender].evasionStage)
            / 100.0F
            * GetAttackerAbilityAccuracyModifier(attacker)
            * GetDefenderAbilityAccuracyModifier(defender, attacker, move);
        if (gravity) result *= 5.0F / 3.0F;
        if (AbilityOnSide(VictoryStar, attacker / 3)) result *= 11.0F / 10.0F;
        if (PokemonOnField[attacker].micleAccBoost)
        {
            result *= 1.2F;
            PokemonOnField[attacker].micleAccBoost = false;
        }
        return result;
    }

    private float GetAttackerAbilityAccuracyModifier(int index)
    {
        return PokemonOnField[index].ability switch
        {
            CompoundEyes => 1.3F,
            Hustle => 0.8F,
            _ => 1.0F,
        };
    }

    private float GetDefenderAbilityAccuracyModifier(int defender, int attacker, MoveID move)
    {
        return PokemonOnField[defender].ability switch
        {
            SandVeil when IsWeatherAffected(defender, Weather.Sand) => 0.8F,
            SnowCloak when IsWeatherAffected(defender, Weather.Snow) => 0.8F,
            WonderSkin when move.Data().power == 0 && !HasMoldBreaker(attacker) => 0.5F,
            _ => 1.0F,
        };
    }

    public float GetCritChance(int attacker, MoveID move)
    {
        int stage = PokemonOnField[attacker].critStage;
        if (move.HasFlag(highCrit)) stage++;
        if (HasAbility(attacker, SuperLuck)) stage++;
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
        int roll = 100 - (random.Next() & 15);
        int effectivePower = powerOverride == null ? move.Data().power : (int)powerOverride;
        if (powerOverride != null) Debug.Log(effectivePower);
        Type effectiveType = move.Data().type;
        effectiveType = GetEffectiveType(move, attacker.index);
        if (move.HasFlag(halfPowerInBadWeather)
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
            case WeightPower:
                effectivePower = GetEffectiveWeightMovePower(defender.index);
                break;
            case RelativeWeightPower:
                effectivePower = GetRelativeWeightMovePower(attacker.index, defender.index);
                break;
            case LowSpeedPower:
                effectivePower = LowSpeedMovePower(attacker.index, defender.index);
                break;
            case HighSpeedPower:
                effectivePower = GetHighSpeedMovePower(attacker.index, defender.index);
                break;
            case HealthPower:
                effectivePower = (int)(move.Data().power
                    * (float)attacker.PokemonData.HP / attacker.PokemonData.hpMax);
                break;
            case Return:
                effectivePower = (attacker.PokemonData.friendship / 5) << 1;
                break;
            case Frustration:
                effectivePower = ((255 - attacker.PokemonData.friendship) / 5) << 1;
                break;
            case Rollout:
                effectivePower <<= (attacker.rolloutIntensity + (attacker.usedDefenseCurl ? 1 : 0));
                break;
            case FuryCutter:
                effectivePower <<= (attacker.furyCutterIntensity);
                break;
            case HiddenPower:
                effectiveType = attacker.PokemonData.hiddenPowerType;
                break;
            case Reversal:
                effectivePower = ReversalPower(attacker.PokemonData.HP, attacker.PokemonData.hpMax);
                break;
            case TargetHealthPower:
                effectivePower = 1 + (int)(move.Data().power * defender.HealthProportion);
                break;
            case TargetStatPower:
                effectivePower = 60 + Min(defender.SumOfStages, 140);
                break;
            case TrumpCard:
                effectivePower = attacker.GetPP(MoveNums[attacker.index] - 1) switch
                {
                    3 => 50,
                    2 => 60,
                    1 => 80,
                    0 => 200,
                    _ => 40,
                };
                break;
            case Payback when defender.done && Moves[defender.index] != MoveID.Switch:
            case Assurance when defender.damagedThisTurn:
            case Facade when attacker.PokemonData.status != Status.None:
            case Revenge when attacker.damagedByMon[defender.index]:
            case SmellingSalts
                when defender.PokemonData.status == Status.Paralysis && !defender.hasSubstitute:
            case WakeUpSlap
                when defender.PokemonData.status == Status.Sleep && !defender.hasSubstitute:
            case WeatherBall when !(this.weather is Weather.None or Weather.StrongWinds):
            case Brine when defender.PokemonData.HP << 1 < defender.PokemonData.hpMax:
            case Pursuit when pursuitHitsOnSwitch:
            case Venoshock when defender.PokemonData.status is Status.Poison or Status.ToxicPoison:
            case MoveEffect.Round when doRound:
                effectivePower <<= 1;
                break;
            case KnockOff when Item.CanBeStolen(defender.item):
                effectivePower += effectivePower << 1;
                break;
            case NaturalGift:
                effectivePower = EffectiveItem(attacker.index) switch
                {
                    CheriBerry or ChestoBerry or PechaBerry or RawstBerry
                    or AspearBerry or LeppaBerry or OranBerry or PersimBerry
                    or LumBerry or SitrusBerry or FigyBerry or WikiBerry
                    or MagoBerry or AguavBerry or IapapaBerry or RazzBerry
                    or OccaBerry or PasshoBerry or WacanBerry or RindoBerry
                    or YacheBerry or ChopleBerry or KebiaBerry or ShucaBerry
                    or CobaBerry or PayapaBerry or TangaBerry or ChartiBerry
                    or PayapaBerry or TangaBerry or ChartiBerry or KasibBerry
                    or HabanBerry or ColburBerry or BabiriBerry or ChilanBerry
                    or RoseliBerry => 80,
                    BlukBerry or NanabBerry or WepearBerry or PinapBerry
                    or PomegBerry or KelpsyBerry or QualotBerry or HondewBerry
                    or GrepaBerry or TamatoBerry or CornnBerry or MagostBerry
                    or RabutaBerry or NomelBerry or SpelonBerry or PamtreBerry => 90,
                    WatmelBerry or DurinBerry or BelueBerry or LiechiBerry
                    or GanlonBerry or SalacBerry or PetayaBerry or ApicotBerry
                    or LansatBerry or StarfBerry or EnigmaBerry or MicleBerry
                    or CustapBerry or JabocaBerry or RowapBerry or KeeBerry
                    or MarangaBerry => 100,
                    _ => 0,
                };
                break;
            default: break;
        }
        switch (EffectiveAbility(attacker.index))
        {
            case Technician when effectivePower <= 60:
                effectivePower += effectivePower >> 1;
                break;
        }
        if (attacker.meFirst) effectivePower += effectivePower >> 1;
        if (attacker.gotAteBoost) effectivePower += effectivePower / 5;
        if (move.Data().type == Type.Electric && attacker.charged)
        {
            effectivePower <<= 1;
            attacker.charged = false;
        }
        if ((move.Data().type == Type.Dark && AbilityOnField(DarkAura)) ||
                (move.Data().type == Type.Fairy && AbilityOnField(FairyAura)))
            if (AbilityOnField(AuraBreak)) effectivePower -= effectivePower >> 2;
            else effectivePower += effectivePower / 3;
        effectivePower = Max(1, effectivePower);
        float critical = isCritical ? CritModifier(attacker.index) : 1.0F;
        float stab = attacker.HasType(effectiveType) ? StabModifier(attacker.index) : 1.0F;
        float multitarget = isMultiTarget ? 0.75F : 1.0F;
        float helpingHand = Mathf.Pow(1.5f, attacker.helpingHand);
        float effectiveAttack = move.Data().physical ?
            GetAttack(attacker.index, isCritical) : GetSpAtk(attacker.index, isCritical);
        if (move.Data().effect == FoulPlay) effectiveAttack = GetAttack(defender.index, isCritical);
        float effectiveDefense = (move.Data().physical || move.Data().effect == Psyshock) ?
            GetDefense(defender.index, isCritical) : GetSpdef(defender.index, isCritical);
        float attackOverDefense = effectiveAttack / effectiveDefense;

        float burn = move.Data().physical && attacker.PokemonData.status == Status.Burn
                ? HasAbility(attacker.index, Guts)
                ? 1.5F : 0.5F
            : 1.0F;
        float screen = (Sides[side].auroraVeil
            || (move.Data().physical
            ? (Sides[side].reflect)
                : Sides[side].lightScreen))
            ? 0.5F : 1.0F;
        if (move.Data().effect == BreakScreens) screen = 1.0F;
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && move.HasFlag(hitDiggingMon))
            || (defender.invulnerability == Invulnerability.Fly
            && move.HasFlag(hitFlyingMon))
            ? 2.0F : 1.0F;
        float weather = effectiveType switch
        {
            Type.Fire when IsWeatherAffected(defender.index, Weather.Sun) => 1.5F,
            Type.Fire when IsWeatherAffected(defender.index, Weather.Rain) => 0.5F,
            Type.Water when IsWeatherAffected(defender.index, Weather.Rain) => 1.5F,
            Type.Water when IsWeatherAffected(defender.index, Weather.Sun) => 0.5F,
            _ => 1.0F,
        };
        float sport = effectiveType switch
        {
            Type.Electric when mudSport => 1.0F / 3.0F,
            Type.Fire when waterSport => 1.0F / 3.0F,
            _ => 1.0F,
        };
        float effectiveTypeModifier = GetTypeEffectiveness(attacker, defender, move);
        if (effectiveTypeModifier < 1 && HasAbility(attacker.index, TintedLens))
        {
            effectiveTypeModifier *= 2.0F;
        }
        if (effectiveTypeModifier > 1 &&
            (EffectiveAbility(defender.index) is Filter or SolidRock
            && !HasMoldBreaker(attacker.index))
            || HasAbility(defender.index, PrismArmor))
        {
            effectiveTypeModifier *= 0.75F;
        }
        if (defender.gotReducingBerryEffect)
        {
            effectiveTypeModifier *= 0.5F;
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
            * effectiveTypeModifier * helpingHand * weather
            * stab * multitarget * critical * burn * screen * sport
            * AttackerAbilityModifier(attacker, defender, move)
            * DefenderAbilityModifier(defender, GetEffectiveType(move, attacker.index), move)
            * invulnerabiltyBonus * roll / 100);
        Debug.Log(result);
        return Max(1, result);
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

    public int FutureSightDamageCalc(FutureSightStruct data)
    {
        BattlePokemon defender = PokemonOnField[data.target];
        int effectiveSpAtk = (int)Floor(data.spAtk *
            (data.critical && data.spAtkStage < 0
            ? 1 : (2 + data.spAtkStage) / 2.0F));
        float attackOverDefense = effectiveSpAtk /
            (data.critical && defender.spDefStage > 0
            ? defender.PokemonData.spDef : defender.spDef);
        float critical = data.critical ?
            data.user.onField
            && HasAbility(data.user.lastIndex, Sniper)
            ? 2.25F : 1.5F : 1.0F;
        float screen = (Sides[defender.side ? 1 : 0].lightScreen
            || Sides[defender.side ? 1 : 0].auroraVeil) ? 0.5F : 1.0F;
        int effectivePower = 120;
        float effectiveTypeModifier = GetEffectivenessForFutureSight(data.type, defender);
        int roll = 100 - (random.Next() & 15);
        float sport = data.type switch
        {
            Type.Electric when mudSport => 1.0F / 3.0F,
            Type.Fire when waterSport => 1.0F / 3.0F,
            _ => 1.0F,
        };
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && data.move.HasFlag(hitDiggingMon))
            || (defender.invulnerability == Invulnerability.Fly
            && data.move.HasFlag(hitFlyingMon))
            ? 2.0F : 1.0F;
        return (int)Floor(((((2.0F * data.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier * sport
            * (data.stab ? 1.5 : 1.0) * critical * screen
            * DefenderAbilityModifier(defender, data.type, data.move)
            * (data.user.onField
                ? AttackerAbilityModifier(PokemonOnField[data.user.lastIndex], defender, data.move) : 1.0F)
            * invulnerabiltyBonus * roll / 100);
    }

    private float AttackerAbilityModifier(BattlePokemon attacker, BattlePokemon defender, MoveID move)
    {
        return EffectiveAbility(attacker.index) switch
        {
            FlashFire when attacker.flashFire && move.Data().type == Type.Fire
                => 1.5F,
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
            SolarPower when IsWeatherAffected(attacker.index, Weather.Sun) => 1.5F,
            ToxicBoost when move.Data().physical && attacker.PokemonData.status is
                Status.Poison or Status.ToxicPoison => 1.5F,
            FlareBoost when !move.Data().physical && attacker.PokemonData.status is
                Status.Burn => 1.5F,
            IronFist when move.HasFlag(punchMove) => 1.2F,
            Sharpness when move.HasFlag(sharpnessBoosted) => 1.5F,
            MegaLauncher when move.HasFlag(megaLauncherBoosted) => 1.5F,
            StrongJaw when move is MoveID.Bite or MoveID.Crunch or MoveID.FireFang
            or MoveID.HyperFang or MoveID.IceFang or MoveID.PoisonFang or MoveID.ThunderFang
            // or MoveID.FishiousRend or MoveID.PsychicFangs or MoveID.JawLock
            => 1.5F,
            ToughClaws when MakesContact(attacker.index, move) => 1.3F,
            Reckless when move.Data().effect.HasRecoil() => 1.2F,
            Analytic when AllOthersDone(attacker.index) => 1.3F,
            SandForce when IsWeatherAffected(attacker.index, Weather.Sand) &&
                (GetEffectiveType(move, attacker.index)
                is Type.Steel or Type.Rock or Type.Ground) => 1.3F,
            PunkRock when move.HasFlag(soundMove) => 1.3F,
            SupremeOverlord => 1.0F + 0.1F * faintedMons(attacker.index),
            _ => 1.0F,
        };
    }

    private float DefenderAbilityModifier(BattlePokemon defender, Type effectiveType, MoveID move)
    {
        return EffectiveAbility(defender.index) switch
        {
            Multiscale or ShadowShield when defender.AtFullHealth => 0.5F,
            ThickFat when effectiveType is Type.Fire or Type.Ice => 0.5F,
            Heatproof when effectiveType == Type.Fire => 0.5F,
            FurCoat when move.Data().physical => 0.5F,
            IceScales when !move.Data().physical => 0.5F,
            PunkRock when move.HasFlag(soundMove) => 0.5F,
            Fluffy => (move.Data().physical ? 0.5F : 1.0F) *
                    (effectiveType == Type.Fire ? 2.0F : 1.0F),
            DrySkin when effectiveType == Type.Fire => 1.25F,
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
        if ((PokemonOnField[defender].protect
            || (PokemonOnField[defender].wideGuard && (move.Data().targets & Target.Spread) != 0))
             && move.Data().effect != Feint)
        {
            PokemonOnField[defender].wasProtected = true;
            return false;
        }
        switch (PokemonOnField[defender].invulnerability)
        {
            case Invulnerability.Fly when !move.HasFlag(hitFlyingMon):
                PokemonOnField[defender].isMissed = true;
                return false;
            case Invulnerability.Dig when !move.HasFlag(hitDiggingMon):
                PokemonOnField[defender].isMissed = true;
                return false;
            case Invulnerability.Dive:
                PokemonOnField[defender].isMissed = true;
                return false;
            default: break;
        }
        if (GetMove(attacker).accuracy == Move.AlwaysHit)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (move.HasFlag(alwaysHitsInRain) && IsWeatherAffected(defender, Weather.Rain))
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (move.HasFlag(alwaysHitsMinimized)
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
            if (!PokemonOnField[i].exists) continue;
            BattlePokemon target = PokemonOnField[i];
            if (target.isTarget)
            {
                switch (EffectiveAbility(i))
                {
                    case VoltAbsorb:
                        if (GetEffectiveType(move, attacker) == Type.Electric
                            && !HasMoldBreaker(attacker))
                        {
                            target.abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case WaterAbsorb or DrySkin:
                        if (GetEffectiveType(move, attacker) == Type.Electric
                            && !HasMoldBreaker(attacker))
                        {
                            target.abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case SapSipper:
                        if (GetEffectiveType(move, attacker) == Type.Grass
                            && !HasMoldBreaker(attacker))
                        {
                            target.abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case EarthEater:
                        if (GetEffectiveType(move, attacker) == Type.Ground
                            && !HasMoldBreaker(attacker))
                        {
                            target.abilityHealed25 = true;
                            continue;
                        }
                        break;
                    case FlashFire:
                        if (move.Data().type == Type.Fire
                            && !HasMoldBreaker(attacker))
                        {
                            abilityEffects.Enqueue((i, i, FlashFire));
                            continue;
                        }
                        break;
                    case WonderGuard:
                        if (GetTypeEffectiveness(PokemonOnField[attacker], target, move) <= 1
                            && !HasMoldBreaker(attacker))
                        {
                            abilityEffects.Enqueue((i, i, WonderGuard));
                            continue;
                        }
                        break;
                    case Soundproof:
                        if (move.HasFlag(soundMove) && !HasMoldBreaker(attacker))
                        {
                            abilityEffects.Enqueue((i, i, Soundproof));
                            continue;
                        }
                        break;
                    case Bulletproof:
                        if (move.HasFlag(bulletMove) && !HasMoldBreaker(attacker))
                        {
                            abilityEffects.Enqueue((i, i, Bulletproof));
                            continue;
                        }
                        break;
                    case Overcoat:
                        if (move.HasFlag(powderMove) && !HasMoldBreaker(attacker))
                        {
                            abilityEffects.Enqueue((i, i, Overcoat));
                            continue;
                        }
                        break;
                    case Dazzling or QueenlyMajesty when GetPriority(attacker) > 0:
                        abilityEffects.Enqueue((i, i, EffectiveAbility(i)));
                        continue;
                    default:
                        break;
                };
                switch (move.Data().effect)
                {
                    case DreamEater when target.PokemonData.status != Status.Sleep:
                    case Endeavor when
                            PokemonOnField[attacker].PokemonData.HP > target.PokemonData.HP:
                    case SuckerPunch when
                            Moves[i].Data().power == 0 || target.done:
                    case Synchronoise when !SharesType(attacker, i):
                        target.isHit = false;
                        target.isTarget = false; //Make ExecuteMove announce move failure
                        break;
                    default:
                        if ((IsImmune(PokemonOnField[attacker], target, move)
                            && move.Data().power > 0)
                            || (move == MoveID.ThunderWave
                            && target.HasType(Type.Ground))
                            || (move == MoveID.SheerCold
                            && target.HasType(Type.Ice))
                            || (move.Data().power == 0
                            && HasAbility(attacker, Prankster)
                            && target.HasType(Type.Dark)))
                        {
                            target.isUnaffected = true;
                        }
                        else
                        {
                            hitAnyone |= TryToHit(attacker, i, move);
                            target.isTarget = false;
                        }

                        break;
                }
            }
        }
        return hitAnyone;
    }

    public IEnumerator GainExp(int partyIndex, int amount)
    {
        Pokemon mon = PlayerPokemon[partyIndex];
        yield return Announce(mon.monName + " gained "
            + amount + " Exp. points!");
        if (mon.onField && battleType == BattleType.Single)
        {
            yield return xpController.GainXP(amount);
        }
        else
        {
            mon.xp += amount;
            while (XP.LevelToXP(mon.level, mon.SpeciesData.xpClass) < mon.xp && mon.level < PokemonConst.maxLevel)
            {
                mon.LevelUp();
                yield return Announce(mon.monName + " grew to level " + mon.level + "!");
            }
        }
    }

    public IEnumerator HandleXPOnFaint(int partyIndex)
    {
        Pokemon pokemon = OpponentPokemon[partyIndex];
#if !(ALL_GET_FULL_EXP)
        int participatingMons = 0;
        for (int i = 0; i < 6; i++)
        {
            if (playerFacedOpponent[i, partyIndex] && !PlayerPokemon[i].fainted) participatingMons++;
        }
#endif
        for (int i = 0; i < 6; i++)
        {
            if (playerFacedOpponent[i, partyIndex] && !PlayerPokemon[i].fainted)
            {
                float baseFactor = (pokemon.SpeciesData.xpYield * pokemon.level) / 5.0F;
#if !ALL_GET_FULL_EXP
                float participantFactor = 1.0F / participatingMons;
#endif
                float allLevelFactor = Mathf.Pow(
                    (2.0F * pokemon.level + 10)
                    / (pokemon.level + PlayerPokemon[i].level + 10.0F),
                    2.5F);
#if FRIENDSHIP_RAISES_EXP
                float friendshipFactor = PlayerPokemon[i].friendship >= 220 ? 1.2F : 1.0F;
#endif

                //Add Lucky Egg effect, traded mon effect, Exp Power effect, delayed evolution effect

                int xpGain = (int)(baseFactor * allLevelFactor
#if !ALL_GET_FULL_EXP
                    * participantFactor
#endif
#if FRIENDSHIP_RAISES_EXP
                    * friendshipFactor
#endif
                    );
                yield return GainExp(i, xpGain);
            }

        }
    }

    private void CheckForFollowMe(int index)
    {
        bool ragePowderOK = !HasAbility(index, Overcoat)
            && !PokemonOnField[index].HasType(Type.Grass);
        if (followMeActive)
        {
            for (int i = 3 * (index / 3); i < (3 * (index / 3)) + 3; i++)
            {
                if (PokemonOnField[i].followMe
                    && Target.CanTarget(index, i, Moves[index])
                    && (!PokemonOnField[i].wasRagePowder || ragePowderOK))
                {
                    Targets[index] = i;
                }
            }
        }
    }

    private void GetCrits(int attacker, MoveID move)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                if (EffectiveAbility(i) is BattleArmor or ShellArmor
                    || Sides[i / 3].luckyChant)
                {
                    continue;
                }
                if ((HasAbility(attacker, Merciless) &&
                        PokemonOnField[i].PokemonData.status is Status.Poison or
                        Status.ToxicPoison) ||
                        move.Data().effect == AlwaysCrit)
                    PokemonOnField[i].isCrit = true;
                if (random.NextDouble() < GetCritChance(attacker, move))
                    PokemonOnField[i].isCrit = true;
            }
        }
    }

    private void CheckReducingAndRetaliatingBerries(int attacker)
    {
        Type effectiveType = GetEffectiveType(Moves[attacker], attacker);
        for (int i = 0; i < 6; i++)
        {
            if (i == attacker) continue;
            if (PokemonOnField[i].isHit)
            {
                if (EffectiveItem(i).BerryEffect()
                    == effectiveType.GetReducingBerry())
                {
                    if ((GetTypeEffectiveness(PokemonOnField[attacker],
                            PokemonOnField[i], Moves[attacker]) > 1
                        || effectiveType == Type.Normal))
                    {
                        PokemonOnField[i].eatenBerry = PokemonOnField[i].item;
                        UseUpItem(i);
                        PokemonOnField[i].gotReducingBerryEffect = true;
                    }
                }
                else if (EffectiveItem(i).BerryEffect()
                    == ((GetMove(attacker).physical) ? OnPhysHurt125 : OnSpecHurt125))
                {
                    PokemonOnField[i].eatenBerry = PokemonOnField[i].item;
                    UseUpItem(i);
                    PokemonOnField[i].ateRetaliationBerry = true;
                }
            }
        }
    }

    public bool IsTrapped(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        int otherSide = 1 - (index / 3);
        if (mon.HasType(Type.Ghost)) return false;
        if (mon.trapped || IsGrounded(index) && AbilityOnSide(ArenaTrap, otherSide) ||
            AbilityOnSide(ShadowTag, otherSide) ||
            mon.HasType(Type.Steel) && AbilityOnSide(MagnetPull, otherSide) ||
            mon.ingrained || mon.getsContinuousDamage) return true;
        return false;
    }

    public void TryToFlinch(int index, int attacker)
    {
        if (HasMoldBreaker(attacker)
            || (EffectiveAbility(index) != InnerFocus))
            PokemonOnField[index].flinched = true;
    }

    private void UseUpItem(int index)
    {
        if (!consumeItems)
        {
            PokemonOnField[index].PokemonData.newItem = ItemID.None;
            PokemonOnField[index].PokemonData.itemChanged = true;
        }
        else
        {
            PokemonOnField[index].PokemonData.item = ItemID.None;
        }
    }

    private void GetMoveEffects(int attacker, MoveID move)
    {
        //Debug.Log(move.Data().targets);
        switch (move.HasFlag(effectOnSelfOnly))
        {
            case false:
                for (int i = 0; i < 6; i++)
                {
                    BattlePokemon target = PokemonOnField[i];
                    if (target.isHit)
                    {
                        if (i != attacker)
                        {
                            if (target.hasSubstitute
                                && !move.HasFlag(soundMove)
                                && !HasAbility(attacker, Infiltrator)) continue;
                            if (HasAbility(i, ShieldDust) && move.Data().power > 0
                                && move.Data().effect.IsShieldDustAffected()) continue;
                        }
                        switch (move.Data().effect)
                        {
                            case ForcedSwitch when HasAbility(i, SuctionCups):
                                abilityEffects.Enqueue((i, i, SuctionCups));
                                break;
                            case ForcedSwitch when target.ingrained:
                            case PerishSong when HasAbility(i, Soundproof):
                            case Yawn when target.yawnNextTurn
                                || target.yawnThisTurn || target.PokemonData.status != Status.None
                                || UproarOnField && !HasAbility(i, Soundproof):
                            case Wish when target.healBlocked:
                            case Captivate when !OppositeGenders(attacker, i):
                            case SkillSwap or SuppressAbility or WorrySeed or SimpleBeam or
                                Entrainment when
                                target.ability.Unchangeable():
                            case WorrySeed or SimpleBeam when HasAbility(i, Truant):
                            case RolePlay or SkillSwap when
                                PokemonOnField[attacker].ability.Unchangeable():
                                continue;
                            case FutureSight:
                                target.gotMoveEffect = !isFutureSightTargeted[i];
                                target.isHit = false;
                                break;
                            case Sleep:
                            case Rest:
                                if (UproarOnField && !HasAbility(i, Soundproof)) continue;
                                goto case TriAttack;
                            case Burn:
                                if (target.HasType(Type.Fire)) continue;
                                goto case TriAttack;
                            case Paralyze:
                                if (target.HasType(Type.Electric)) continue;
                                goto case TriAttack;
                            case Poison:
                            case Toxic:
                                if (target.HasType(Type.Poison)) continue;
                                goto case TriAttack;
                            case Telekinesis when target.telekinesis || target.ingrained || target.smackDown ||
                                    target.PokemonData.getSpecies is SpeciesID.GengarMega or
                                    SpeciesID.Diglett or SpeciesID.Dugtrio
                                    //or SpeciesID.Sandygast or SpeciesID.Palossand
                                    : continue;
                            case TriAttack:
                                if (target.PokemonData.status != Status.None) continue;
                                goto default;
                            default:
                                if (random.NextDouble() * 100.0F
                                    <= move.Data().effectChance * (HasAbility(attacker, SereneGrace) ? 2 : 1))
                                {
                                    //Debug.Log(i + "got effect");
                                    target.gotMoveEffect = true;
                                }

                                break;
                        }
                    }
                }
                if ((move.Data().targets & Target.Self) != 0)
                {
                    if (move.Data().effect == Swallow
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
        BattlePokemon attackingMon = PokemonOnField[attacker];
        for (int defender = 0; defender < 6; defender++)
        {
            if (PokemonOnField[defender].isHit)
            {
                switch (EffectiveAbility(attacker))
                {
                    case Stench:
                        if (random.NextDouble() < 0.1F)
                        {
                            TryToFlinch(defender, attacker);
                        }
                        break;
                    default:
                        break;
                }
                switch (EffectiveAbility(defender))
                {
                    case Static when MakesContact(attacker, move) &&
                            !(attackingMon.HasType(Type.Electric) ||
                            HasAbility(attacker, Limber)):
                    case PoisonPoint when MakesContact(attacker, move) &&
                        !(attackingMon.HasType(Type.Poison) || attackingMon.HasType(Type.Steel) ||
                            HasAbility(attacker, Immunity)):
                    case FlameBody when MakesContact(attacker, move) &&
                            !(attackingMon.HasType(Type.Fire) ||
                            HasAbility(attacker, WaterVeil)):
                        if (random.NextDouble() < 1F / 3F)
                        {
                            abilityEffects.Enqueue((defender, attacker, EffectiveAbility(defender)));
                        }
                        break;
                    case RoughSkin or IronBarbs when MakesContact(attacker, move):
                    case Mummy when MakesContact(attacker, move) &&
                        !EffectiveAbility(defender).Unchangeable():
                    case Gooey when MakesContact(attacker, move):
                        abilityEffects.Enqueue((defender, attacker, EffectiveAbility(defender)));
                        break;
                    case Justified when GetEffectiveType(move, attacker) == Type.Dark:
                    case Rattled when GetEffectiveType(move, attacker) is
                            Type.Dark or Type.Ghost or Type.Bug:
                    case WeakArmor when move.Data().physical:
                    case SteamEngine when GetEffectiveType(move, attacker) is
                            Type.Water or Type.Fire:
                    case ToxicDebris when move.Data().physical &&
                            Sides[1 - defender / 3].toxicSpikes < 2:
                    case Stamina:
                        abilityEffects.Enqueue((defender, defender, EffectiveAbility(defender)));
                        break;
                }

            }
        }
    }

    public bool showFailure => Moves[currentMovingMon].Data().power == 0;

    public IEnumerator DoWeatherTransformations()
    {
        for (int i = 0; i < 6; i++)
        {
            switch (EffectiveAbility(i))
            {
                case FlowerGift when PokemonOnField[i].PokemonData.species == SpeciesID.Cherrim:
                    if (IsWeatherAffected(i, Weather.Sun))
                    {
                        //Add transformation animation
                        PokemonOnField[i].PokemonData.temporarySpecies = SpeciesID.CherrimSunshine;
                        PokemonOnField[i].PokemonData.transformed = true;
                    }
                    else PokemonOnField[i].PokemonData.transformed = false;
                    break;
                case Forecast when PokemonOnField[i].PokemonData.species == SpeciesID.Castform:
                    if (IsWeatherAffected(i, Weather.Sun))
                    {
                        //Add transformation animation
                        PokemonOnField[i].PokemonData.temporarySpecies = SpeciesID.CastformSunny;
                        PokemonOnField[i].PokemonData.transformed = true;
                    }
                    else if (IsWeatherAffected(i, Weather.Rain))
                    {
                        //Add transformation animation
                        PokemonOnField[i].PokemonData.temporarySpecies = SpeciesID.CastformRainy;
                        PokemonOnField[i].PokemonData.transformed = true;
                    }
                    else if (IsWeatherAffected(i, Weather.Snow))
                    {
                        //Add transformation animation
                        PokemonOnField[i].PokemonData.temporarySpecies = SpeciesID.CastformSnowy;
                        PokemonOnField[i].PokemonData.transformed = true;
                    }
                    else PokemonOnField[i].PokemonData.transformed = false;
                    break;
            }
        }
        yield break;
    }

    private IEnumerator HandleAbilityEffects()
    {
        while(abilityEffects.Count > 0)
        {
            (int source, int target, Ability ability) data = abilityEffects.Dequeue();
            if (PokemonOnField[data.target].PokemonData.fainted) continue;
            switch (data.ability)
            {
                case Static:
                    yield return AbilityPopupStart(data.source);
                    yield return BattleEffect.GetParalysis(this, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case PoisonPoint:
                    yield return AbilityPopupStart(data.source);
                    yield return BattleEffect.GetPoison(this, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case FlameBody:
                    yield return AbilityPopupStart(data.source);
                    yield return BattleEffect.GetBurn(this, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case RoughSkin:
                case IronBarbs:
                    yield return AbilityPopupStart(data.source);
                    PokemonOnField[data.target].DoProportionalDamage(0.125F);
                    yield return Announce(MonNameWithPrefix(data.target, true) + " was hurt by"
                        + EffectiveAbility(data.source).Name() + "!");
                    yield return AbilityPopupEnd(data.source);
                    yield return ProcessFaintingSingle(data.target);
                    break;
                case Mummy:
                    yield return AbilityPopupStart(data.source);
                    yield return AbilityPopupStart(data.target);
                    yield return abilityControllers[data.target].ChangeAbility("Mummy");
                    yield return Announce(MonNameWithPrefix(data.target, true)
                       + " acquired Mummy!");
                    PokemonOnField[data.target].ability = Mummy;
                    yield return AbilityPopupEnd(data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case Gooey:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatDown(this, data.target, Stat.Speed, 1, data.source);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case FlashFire:
                    yield return AbilityPopupStart(data.source);
                    PokemonOnField[data.target].flashFire = true;
                    yield return Announce("Flash Fire powered up "
                        + MonNameWithPrefix(data.target, false) + "'s Fire-type moves!");
                    yield return AbilityPopupEnd(data.source);
                    break;
                case WonderGuard:
                case Soundproof:
                case Bulletproof:
                case Overcoat:
                case Dazzling:
                case QueenlyMajesty:
                    yield return AbilityPopupStart(data.source);
                    yield return Announce("It doesn't affect "
                        + MonNameWithPrefix(data.target, false) + "...");
                    yield return AbilityPopupEnd(data.source);
                    break;
                case SuctionCups:
                    yield return AbilityPopupStart(data.source);
                    yield return Announce(MonNameWithPrefix(data.target, true)
                        + " wasn't affected because of Suction Cups!");
                    yield return AbilityPopupEnd(data.source);
                    break;
                case Justified:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatUp(this, data.target, Stat.Attack, 1, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case Rattled:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatUp(this, data.target, Stat.Speed, 1, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case Stamina:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatUp(this, data.target, Stat.Defense, 1, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case WeakArmor:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatDown(this, data.target, Stat.Defense, 1, data.target);
                    doStatAnim = true;
                    yield return BattleEffect.StatUp(this, data.target, Stat.Speed, 1, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case SteamEngine:
                    yield return AbilityPopupStart(data.source);
                    doStatAnim = true;
                    yield return BattleEffect.StatUp(this, data.target, Stat.Speed, 6, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
                case ToxicDebris:
                    yield return AbilityPopupStart(data.source);
                    yield return BattleEffect.ToxicSpikes(this, data.target);
                    yield return AbilityPopupEnd(data.source);
                    break;
            }
        }
    }

    private IEnumerator ProcessHits(int attacker, MoveID move, bool isMultiTarget,
        bool parentalBond = false, int? powerOverride = null)
    {
        for (int i = 0; i < 6; i++)
        {
            BattlePokemon defendingMon = PokemonOnField[i];
            BattlePokemon attackingMon = PokemonOnField[attacker];
            if (defendingMon.isHit)
            {
                Debug.Log("Processing hit on " + i);
                int damage;
                switch (move.Data().effect)
                {
                    case OHKO:
                        damage = 65535; break;
                    case Direct20:
                        damage = 20; break;
                    case Direct40:
                        damage = 40; break;
                    case DirectLevel:
                        damage = attackingMon.PokemonData.level; break;
                    case Counter:
                        damage = attackingMon.damageTaken << 1; break;
                    case MetalBurst:
                        damage = attackingMon.damageTaken
                            + (attackingMon.damageTaken >> 1); break;
                    case Psywave:
                        damage = Max(1, attackingMon.PokemonData.level
                            * (50 + (random.Next() % 100)) / 100);
                        break;
                    case SuperFang:
                        damage = defendingMon.PokemonData.HP >> 1;
                        break;
                    case BideHit:
                        damage = attackingMon.bideDamage * 2;
                        break;
                    case SpitUp:
                        damage = DamageCalc(attackingMon, defendingMon,
                            move, isMultiTarget, defendingMon.isCrit, GetSide(i),
                            100 * attackingMon.stockpile);
                        break;
                    case Magnitude:
                    case Present:
                        Debug.Log(singleMovePower);
                        damage = DamageCalc(attackingMon, defendingMon,
                            move, isMultiTarget, defendingMon.isCrit, GetSide(i),
                            singleMovePower);
                        break;
                    case Fling:
                        damage = DamageCalc(attackingMon, defendingMon,
                            move, isMultiTarget, defendingMon.isCrit, GetSide(i),
                            EffectiveItem(attacker).Data().flingPower);
                        break;
                    case Endeavor:
                        damage = PokemonOnField[i].PokemonData.HP
                            - PokemonOnField[attacker].PokemonData.HP;
                        break;
                    default:
                        damage = DamageCalc(attackingMon, defendingMon,
                            move, isMultiTarget, defendingMon.isCrit, GetSide(i),
                            powerOverride); break;
                }
                if (parentalBond) damage >>= 1;
                Debug.Log(defendingMon.PokemonData.HP + " HP, " + damage + " damage");
                if (defendingMon.hasSubstitute && !Moves[attacker].HasFlag(soundMove)
                    && !HasAbility(attacker, Infiltrator))
                {
                    if (damage >= defendingMon.substituteHP)
                    {
                        attackingMon.moveDamageDone = defendingMon.substituteHP;
                        defendingMon.substituteHP = 0;
                        yield return BattleEffect.SubstituteFaded(this, i);
                    }
                    else
                    {
                        defendingMon.substituteHP -= damage;
                        attackingMon.moveDamageDone = damage;
                    }
                }
                else
                {
                    defendingMon.damagedThisTurn = true;
                    defendingMon.focused = false;
                    defendingMon.damagedByMon[attacker] = true;
                    if (damage >= defendingMon.PokemonData.HP)
                    {
                        if (move.Data().effect == FalseSwipe)
                        {
                            attackingMon.moveDamageDone = defendingMon.PokemonData.HP - 1;
                            defendingMon.PokemonData.HP = 1;
                        }
                        else if (HasAbility(i, Sturdy)
                                && defendingMon.PokemonData.HP == defendingMon.PokemonData.hpMax
                                && !HasMoldBreaker(attacker))
                        {
                            attackingMon.moveDamageDone = defendingMon.PokemonData.HP - 1;
                            defendingMon.PokemonData.HP = 1;
                            abilityEffects.Enqueue((i, i, Sturdy));
                        }
                        else if (defendingMon.endure)
                        {
                            attackingMon.moveDamageDone = defendingMon.PokemonData.HP - 1;
                            defendingMon.PokemonData.HP = 1;
                            defendingMon.enduredHit = true;
                        }
                        //Todo: Add focus sash effect as else if
                        else
                        {
                            attackingMon.moveDamageDone = defendingMon.PokemonData.HP;
                            defendingMon.PokemonData.HP = 0;
                            defendingMon.PokemonData.fainted = true;
                            if (defendingMon.destinyBond)
                            {
                                attackingMon.gotDestinyBondHit = true;
                                attackingMon.destinyBondAttacker = MonNameWithPrefix(i, true);
                            }
                            if (defendingMon.grudge)
                            {
                                attackingMon.gotGrudgeEffect = true;
                            }
                        }
                    }
                    else
                    {
                        defendingMon.PokemonData.HP -= damage;
                        attackingMon.moveDamageDone += damage;
                        if (defendingMon.biding) defendingMon.bideDamage += damage;
                        defendingMon.damageTaken = damage;
                        defendingMon.damageWasPhysical = move.Data().physical;
                        defendingMon.lastDamageDoer = attacker;
                        if (defendingMon.isEnraged)
                        {
                            doStatAnim = true;
                            yield return BattleEffect.StatUp(this, i, Stat.Attack, 1, i);
                        }
                        if (move.HasFlag(extraFlinch10) &&
                          random.NextDouble() < 0.10 && !HasAbility(i, ShieldDust))
                            TryToFlinch(i, attacker);
                    }
                }
            }
        }
    }

    private IEnumerator ProcessFainting(bool fromMove = false, int attacker = 0)
    {
        for (int i = 0; i < 6; i++)
        {
            yield return ProcessFaintingSingle(i, fromMove, attacker);
        }
    }

    private IEnumerator ProcessFaintingSingle(int index, bool fromMove = false, int attacker = 0)
    {
        if (PokemonOnField[index].exists && PokemonOnField[index].PokemonData.fainted)
        {
            int partyIndex = PokemonOnField[index].partyIndex;
            LeaveFieldCleanup(index);
            yield return BattleEffect.Faint(this, index);
            Moves[index] = MoveID.None;
            yield return HandleXPOnFaint(partyIndex);
            if (OpponentLost)
            {
                StartCoroutine(EndBattle());
                yield break;
            }
            yield return AbilityEffectsOnFaint(index);
            if (fromMove) yield return AbilityEffectsForAttackerOnFaint(attacker)
;        }
    }

    private IEnumerator AbilityEffectsOnFaint(int index)
    {
        yield break;
    }

    private IEnumerator AbilityEffectsForAttackerOnFaint(int index)
    {
        switch (EffectiveAbility(index))
        {
            case Moxie:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, index);
                yield break;
        }
    }

    private IEnumerator ProcessDestinyBondAndGrudge(int index)

    {
        BattlePokemon mon = PokemonOnField[index];
        if (mon.gotDestinyBondHit)
        {
            yield return Announce(mon.destinyBondAttacker
                + " took its attacker down with it!");
            mon.PokemonData.HP = 0;
            mon.PokemonData.fainted = true;
            yield return ProcessFaintingSingle(index);
        }
        if (mon.gotGrudgeEffect)
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + "'s " + mon.lastMoveUsed.Data().name
                + " lost all its PP due to the grudge!");
            yield return BattleEffect.DrainPP(this, index, mon.GetPP(mon.lastMoveSlot - 1), false);
            yield return CheckLeppaBerry(index, mon.lastMoveSlot);
            mon.gotGrudgeEffect = false;
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
            PokemonOnField[i].gotReducingBerryEffect = false;
            PokemonOnField[i].ateRetaliationBerry = false;
        }
    }

    private bool CheckSelfTargetingMoveAnim(int attacker, MoveEffect moveEffect)
    {
        switch (moveEffect)
        {
            case AttackUp1:
            case AttackUp2:
                return PokemonOnField[attacker].attackStage < 6;
            case DefenseUp1:
            case DefenseUp2:
                return PokemonOnField[attacker].defenseStage < 6;
            case SpAtkUp1:
            case SpAtkUp2:
            case SpAtkUp3:
                return PokemonOnField[attacker].spAtkStage < 6;
            case SpDefUp2:
                return PokemonOnField[attacker].spDefStage < 6;
            case SpeedUp1:
            case SpeedUp2:
                return PokemonOnField[attacker].speedStage < 6;
            case EvasionUp1:
            case EvasionUp2:
                return PokemonOnField[attacker].evasionStage < 6;
            case Growth:
                return PokemonOnField[attacker].attackStage < 6 ||
                    PokemonOnField[attacker].spAtkStage < 6;
            case Heal50:
            case HealWeather:
                return !PokemonOnField[attacker].AtFullHealth;
            default:
                return true;
        }
    }

    public IEnumerator SwitchMove(int index)
    {
        partyBackButtonInactive = true;
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
        yield return BattleEffect.VoluntarySwitch(this, 3, switchingTarget, true, true);
        yield return EntryAbilityCheck(3);
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
        }
        if (!PokemonOnField[index].PokemonData.fainted && HasAbility(index, Regenerator))
            PokemonOnField[index].PokemonData.HP += PokemonOnField[index].PokemonData.hpMax / 3;
        if (!PokemonOnField[index].PokemonData.fainted && HasAbility(index, NaturalCure))
            PokemonOnField[index].PokemonData.status = Status.None;
        PokemonOnField[index].PokemonData.onField = false;
        if (snatchingMon == index) snatch = false;
    }

    private bool CheckBerryCondition(int index, bool tookMoveDamage)
    {
        switch (EffectiveItem(index).BerryEffect())
        {
            case At50Restore10HP:
            case At50Restore25:
                return PokemonOnField[index].HealthProportion <= 0.5F;
            case At25Restore33Bitter:
            case At25Restore33Dry:
            case At25Restore33Sour:
            case At25Restore33Spicy:
            case At25Restore33Sweet:
            case At25RaiseAttack:
            case At25RaiseDefense:
            case At25RaiseSpAtk:
            case At25RaiseSpDef:
            case At25RaiseSpeed:
            case At25RaiseCrit:
            case At25RaiseRandom2:
            case At25RaiseAccuracy20:
            case At25GetPriority:
                return HasAbility(index, Gluttony) ?
                    PokemonOnField[index].HealthProportion <= 0.5 :
                    PokemonOnField[index].HealthProportion <= 0.25;
            case OnSERestore25:
                return PokemonOnField[index].gotSuperEffectiveHit;
            case CureParalysis:
                return PokemonOnField[index].PokemonData.status == Status.Paralysis;
            case CureSleep:
                return PokemonOnField[index].PokemonData.status == Status.Sleep;
            case CurePoison:
                return PokemonOnField[index].PokemonData.status is
                    Status.Poison or Status.ToxicPoison;
            case CureBurn:
                return PokemonOnField[index].PokemonData.status == Status.Burn;
            case CureFreeze:
                return PokemonOnField[index].PokemonData.status == Status.Freeze;
            case CureConfusion:
                return PokemonOnField[index].confused;
            case CureStatus:
                return PokemonOnField[index].PokemonData.status != Status.None
                    || PokemonOnField[index].confused;
            case OnPhysHurt125:
            case OnPhysRaiseDefense:
                return PokemonOnField[index].damageWasPhysical && tookMoveDamage;
            case OnSpecHurt125:
            case OnSpecRaiseSpDef:
                return !PokemonOnField[index].damageWasPhysical && tookMoveDamage;
            default:
                return false;
        }
    }

    private IEnumerator DoBerryEffect(int index, BerryEffect effect)
    {
        switch (effect)
        {
            case CureParalysis:
                yield return BattleEffect.HealParalysis(this, index);
                yield break;
            case CureSleep:
                yield return BattleEffect.WakeUp(this, index);
                yield break;
            case CurePoison:
                yield return BattleEffect.HealPoison(this, index);
                yield break;
            case CureBurn:
                yield return BattleEffect.HealBurn(this, index);
                yield break;
            case CureFreeze:
                PokemonOnField[index].PokemonData.status = Status.None;
                yield return ThawedOut(index);
                yield break;
            case CureConfusion:
                PokemonOnField[index].confused = false;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is no longer confused!");
                yield break;
            case CureStatus:
                if (!PokemonOnField[index].confused)
                {
                    yield return BattleEffect.HealStatus(this, index);
                    yield break;
                }
                goto case CureConfusion;
            case At50Restore10HP:
                yield return BattleEffect.Heal(this, index, 10);
                yield break;
            case At50Restore25:
            case OnSERestore25:
                yield return BattleEffect.Heal(this, index,
                    PokemonOnField[index].PokemonData.hpMax >> 2);
                yield break;
            case At25Restore33Spicy:
                yield return PinchBerry(index, Stat.Attack);
                yield break;
            case At25Restore33Dry:
                yield return PinchBerry(index, Stat.SpAtk);
                yield break;
            case At25Restore33Sweet:
                yield return PinchBerry(index, Stat.Speed);
                yield break;
            case At25Restore33Bitter:
                yield return PinchBerry(index, Stat.SpDef);
                yield break;
            case At25Restore33Sour:
                yield return PinchBerry(index, Stat.Defense);
                yield break;
            case At25RaiseAttack:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, index);
                yield break;
            case At25RaiseDefense:
            case OnPhysRaiseDefense:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                yield break;
            case At25RaiseSpAtk:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, index);
                yield break;
            case At25RaiseSpDef:
            case OnSpecRaiseSpDef:
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, index);
                yield break;
            case At25RaiseSpeed:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, index);
                yield break;
            case At25RaiseCrit:
                yield return BattleEffect.StatUp(this, index, Stat.CritRate, 2, index);
                yield break;
            case At25RaiseRandom2:
                yield return BattleEffect.StatUp(this, index,
                    (Stat)(int)((random.NextDouble() * 6) + 1), 2, index);
                yield break;
            case OnPhysHurt125:
            case OnSpecHurt125:
                PokemonOnField[PokemonOnField[index].lastDamageDoer].DoProportionalDamage(0.125F);
                yield return Announce(MonNameWithPrefix(PokemonOnField[index].lastDamageDoer, true) +
                    " was hurt by the " + EffectiveItem(index).Data().itemName + "!");
                yield return ProcessFaintingSingle(PokemonOnField[index].lastDamageDoer);
                yield break;
            case At25RaiseAccuracy20:
                PokemonOnField[index].micleAccBoost = true;
                yield break;
            case At25GetPriority:
                PokemonOnField[index].custapPriorityBoost = true;
                yield break;
            default:
                yield break;
        }
    }

    private IEnumerator PinchBerry(int index, Stat stat)
    {
        yield return BattleEffect.Heal(this, index,
    PokemonOnField[index].PokemonData.hpMax / 3);
        if (PokemonOnField[index].HatesStat(stat))
            yield return BattleEffect.Confuse(this, index);
    }

    private IEnumerator ProcessBerries(int index, bool tookDamage)
    {
        if (CheckBerryCondition(index, tookDamage))
        {
            yield return BattleAnim.UseItem(this, index);
            PokemonOnField[index].eatenBerry = EffectiveItem(index);
            UseUpItem(index);
            yield return DoBerryEffect(index, PokemonOnField[index].eatenBerry.BerryEffect());
        }
        else yield break;
    }

    private IEnumerator TryMove(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        if (Moves[index] == MoveID.Switch)
        {
            yield return BattleEffect.VoluntarySwitch(this, index, SwitchTargets[index], true, false);
            yield return EntryAbilityCheck(index);
            DoNextMove();
            yield break;
        }
        Debug.Log(GetMove(index).name);
        bool goAhead = true;
        mon.invulnerability = Invulnerability.None;
        mon.destinyBond = false;
        mon.grudge = false;
        if (GetMove(index).effect == FocusPunchWindup)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index);
            DoNextMove();
            yield break;
        }
        switch (mon.PokemonData.status)
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
                    if (GetMove(index).effect != Snore) goAhead = false;
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
                    mon.PokemonData.status = Status.None;
                }
                break;
        }
        if (goAhead && mon.flinched)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " flinched!");
            goAhead = false;
            if (HasAbility(index, Steadfast))
            {
                yield return AbilityPopupStart(index);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, index);
                yield return AbilityPopupEnd(index);
            }
        }
        if (goAhead && mon.confused)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " is confused!");
            if (random.NextDouble() < 1.0F / 3.0F)
            {
                yield return HurtByConfusion(index);
                goAhead = false;
            }
        }
        if (goAhead && mon.infatuated)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " is infatuated!");
            yield return BattleAnim.Infatuated(this, index);
            if (random.NextDouble() < 1.0F / 2.0F)
            {
                yield return Announce(MonNameWithPrefix(index, true) + " is immobilized by love!");
                goAhead = false;
            }
        }
        if (GetMove(index).effect == SelfDestruct)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != index && HasAbility(i, Damp))
                {
                    yield return AbilityPopupStart(i);
                    yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                        + GetMove(index).name + "!");
                    yield return AbilityPopupEnd(i);
                }
            }
        }
        if (goAhead && !mon.dontCheckPP)
        {
            if (mon.GetPP(MoveNums[index] - 1) <= 0)
            {
                yield return NoPP(index);
                if (Moves[index] != MoveID.Struggle)
                {
                    goAhead = false;
                }
            }
        }
        if (goAhead && mon.taunted && GetMove(index).power == 0)
        {
            goAhead = false;
            yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                + GetMove(index).name + " after the taunt!");
        }
        if (goAhead && gravity && Moves[index].HasFlag(gravityDisabled))
        {
            goAhead = false;
            yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                + GetMove(index).name + " under the intense gravity!");
        }
        if (goAhead && Moves[index].HasFlag(usesProtectCounter))
        {
            float successChance = 1.0f;
            for (int i = 0; i < mon.protectCounter; i++) { successChance /= 3.0f; }
            if (random.NextDouble() > successChance)
            {
                goAhead = false;
                mon.protectCounter = 0;
            }
            else { mon.protectCounter++; }
        }
        else if (goAhead && Moves[index].HasFlag(incrementsProtectCounter)) mon.protectCounter++;
        else mon.protectCounter = 0;
        if (goAhead)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index);
        }
        else
        {
            mon.thrashing = false;
            mon.done = true;
            if (GetMove(index).type == Type.Electric && mon.charged)
                mon.charged = false;
        }
        DoNextMove();
    }

    private IEnumerator FullParalysis(int index)
    {
        yield return BattleAnim.ShowParalysis(this, index);
        yield return Announce(MonNameWithPrefix(index, true) + " is paralyzed! It can't move!");
    }

    public IEnumerator CheckLeppaBerry(int index, int moveNum)
    {
        BattlePokemon mon = PokemonOnField[index];
        if (mon.GetPP(moveNum) == 0 &&
            EffectiveItem(index).BerryEffect() == At0PPRestore10PP)
        {
            yield return BattleAnim.UseItem(this, index);
            yield return Announce(MonNameWithPrefix(index, true) + "'s Leppa Berry restored "
                + mon.GetMove(moveNum - 1).Data().name + "'s PP!");
            switch (moveNum)
            {
                case 1: mon.PokemonData.pp1 = Min(10, mon.PokemonData.maxPp1); break;
                case 2: mon.PokemonData.pp2 = Min(10, mon.PokemonData.maxPp2); break;
                case 3: mon.PokemonData.pp3 = Min(10, mon.PokemonData.maxPp3); break;
                case 4: mon.PokemonData.pp4 = Min(10, mon.PokemonData.maxPp4); break;
            }
            mon.eatenBerry = mon.item;
            UseUpItem(index);
        }
    }

    private int GetRandomOpponentMon(bool side)
    {
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
        if (!HasAbility(index, MagicGuard))
        {
            if (IsGrounded(index))
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
                            yield return ProcessFaintingSingle(index);
                            yield break;
                        }
                        break;
                    case 0:
                    default:
                        break;
                }
                switch (Sides[GetSide(index)].toxicSpikes)
                {
                    case 1:
                        yield return HandleToxicSpikes(index, false);
                        break;
                    case 2:
                        yield return HandleToxicSpikes(index, true);
                        break;
                    case 0:
                    default:
                        break;
                }
            }
            if (Sides[GetSide(index)].stealthRock)
            {
                yield return Announce("Pointed stones dug into "
                    + MonNameWithPrefix(index, false) + "!");
                float effectiveness =
                    PokemonOnField[index].Type1 == PokemonOnField[index].Type2 ?
                    TypeUtils.Effectiveness(Type.Rock, PokemonOnField[index].Type1) :
                    (TypeUtils.Effectiveness(Type.Rock, PokemonOnField[index].Type1) *
                    TypeUtils.Effectiveness(Type.Rock, PokemonOnField[index].Type2));
                PokemonOnField[index].DoProportionalDamage(0.125F * effectiveness);
                if (PokemonOnField[index].PokemonData.fainted)
                {
                    yield return ProcessFaintingSingle(index);
                    yield break;
                }
            }
        }
    }

    public IEnumerator HandleToxicSpikes(int index, bool bad)
    {
        if (PokemonOnField[index].HasType(Type.Poison))
        {
            yield return Announce(MonNameWithPrefix(
                index, true) + " sucked up the toxic spikes!");
            Sides[GetSide(index)].toxicSpikes = 0;
        }
        else if (!PokemonOnField[index].HasType(Type.Steel)
            && EffectiveAbility(index) is not Immunity or Comatose)
        {
            yield return bad ? BattleEffect.GetBadPoison(this, index)
                : BattleEffect.GetPoison(this, index);
        }
    }

    public IEnumerator EntryAbilityCheck(int index)
    {
        Debug.Log(PokemonOnField[index].ability);
        doAbilityEffect[index] = false;
        switch (EffectiveAbility(index))
        {
            case Drizzle:
                yield return AbilityPopupStart(index);
                yield return BattleEffect.StartWeather(this, Weather.Rain, 5);
                yield return AbilityPopupEnd(index);
                break;
            case Drought:
                yield return AbilityPopupStart(index);
                yield return BattleEffect.StartWeather(this, Weather.Sun, 5);
                yield return AbilityPopupEnd(index);
                break;
            case SandStream:
                yield return AbilityPopupStart(index);
                yield return BattleEffect.StartWeather(this, Weather.Sand, 5);
                yield return AbilityPopupEnd(index);
                break;
            case SnowWarning:
                yield return AbilityPopupStart(index);
                yield return BattleEffect.StartWeather(this, Weather.Snow, 5);
                yield return AbilityPopupEnd(index);
                break;
            case Intimidate:
                //Todo: double/multi battle effect
                yield return AbilityPopupStart(index);
                for (int i = 3 * (1 - (index / 3)); i < 3 * (2 - (index / 3)); i++)
                {
                    if (PokemonOnField[i].exists)
                    {
                        doStatAnim = true;
                        if (EffectiveAbility(i) is
                            Oblivious or OwnTempo or InnerFocus
                            or Scrappy)
                        {
                            yield return AbilityPopupStart(i);
                            yield return Announce(MonNameWithPrefix(i, true)
                            + "'s attack wasn't lowered because of "
                            + EffectiveAbility(i).Name() + "!");
                            yield return AbilityPopupEnd(i);
                        }
                        else { yield return BattleEffect.StatDown(this, i, Stat.Attack, 1, index); }
                    }
                }
                yield return AbilityPopupEnd(index);
                break;
            case Trace:
                for (int i = 0; i < 3; i++)
                {
                    Debug.Log(3 * (1 - (index / 3)) + i);
                    if (PokemonOnField[3 * (1 - (index / 3)) + i].exists)
                    {
                        yield return AbilityPopupStart(index);
                        yield return new WaitForSeconds(0.2F);
                        yield return abilityControllers[index].ChangeAbility(
                            EffectiveAbility(i).Name());
                        PokemonOnField[index].ability = EffectiveAbility(i);
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " traced the foe's "
                            + EffectiveAbility(i).Name()
                            + "!");
                        yield return AbilityPopupEnd(index);
                        yield return EntryAbilityCheck(index);
                        break;
                    }
                }
                yield return AbilityPopupEnd(index);
                break;
            case Frisk:
                int c = 3 - (index / 3);
                for (int i = c; i < c + 3; i++)
                {
                    if (PokemonOnField[i].item != ItemID.None)
                    {
                        yield return AbilityPopupStart(index);
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " frisked " + MonNameWithPrefix(i, false)
                            + " and found its " + PokemonOnField[i].item.Data().itemName + "!");
                    }
                }
                yield return AbilityPopupEnd(index);
                break;

        }
    }

    public IEnumerator HealingWishEffect(int index)
    {
        if (PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return BattleEffect.HealStatus(this, index);
        }
        if (!PokemonOnField[index].AtFullHealth)
        {
            yield return BattleEffect.Heal(this, index, PokemonOnField[index].PokemonData.hpMax);
        }
        healingWish[index] = false;
    }

    public IEnumerator MonEntersField(int index)
    {
        PokemonOnField[index].turnOnField = 0;
        yield return EntryHazardDamage(index);
        if (healingWish[index] && !(PokemonOnField[index].AtFullHealth &&
            PokemonOnField[index].PokemonData.status == Status.None))
        {
            yield return HealingWishEffect(index);
        }
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

    private IEnumerator ExecuteMove(int index, bool parentalBond = false)
    {
        bool isMultiTarget = false;
        oneAnnouncementDone = false;
        bool targetsAnyone = false;
        currentMovingMon = index;
        bool checkParentalBond = false;

        BattlePokemon user = PokemonOnField[index];

        Debug.Log("Executing for " + index);

        if (EffectiveAbility(index) is Protean or Libero &&
            !user.HasType(GetMove(index).type))
        {
            yield return AbilityPopupStart(index);
            yield return BattleEffect.BecomeType(this, index, GetMove(index).type);
            yield return AbilityPopupEnd(index);
        }

        if (MoveNums[index] > 0) user.usedMove[MoveNums[index] - 1] = true;
        user.moveUsedThisTurn = Moves[index];
        if (!Moves[index].HasFlag(mimicBypass)) user.lastMoveUsed = Moves[index];
        user.isEnraged = GetMove(index).effect == Rage;
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
                        user.transformedMon.pp1 -= pressureAffected ? 2 : 1; break;
                    case 2:
                        user.transformedMon.pp2 -= pressureAffected ? 2 : 1; break;
                    case 3:
                        user.transformedMon.pp3 -= pressureAffected ? 2 : 1; break;
                    case 4:
                        user.transformedMon.pp4 -= pressureAffected ? 2 : 1; break;
                }
            }
            else
            {
                switch (MoveNums[index])
                {
                    case 1:
                        user.PokemonData.pp1 -= pressureAffected ? 2 : 1; break;
                    case 2:
                        user.PokemonData.pp2 -= pressureAffected ? 2 : 1; break;
                    case 3:
                        user.PokemonData.pp3 -= pressureAffected ? 2 : 1; break;
                    case 4:
                        user.PokemonData.pp4 -= pressureAffected ? 2 : 1; break;
                }
            }
        }
        if (user.GetPP(MoveNums[index] - 1) == 0
          && user.encored
          && Moves[index] == user.encoredMove)
            user.encored = false;
        if (GetMove(index).effect == FocusPunchWindup)
        {
            Moves[index] = MoveID.FocusPunchAttack;
            PokemonOnField[index].focused = true;
            yield return Announce(MonNameWithPrefix(index, true) + " is tightening its focus!");
            yield break;
        }

        yield return Announce(user.PokemonData.monName + " used " + GetMove(index).name + "!");
        lastMoveUsed = Moves[index];

        if (GetMove(index).effect == NaturePower)
        {
            Moves[index] = battleTerrain switch
            {
                BattleTerrain.Building or BattleTerrain.Gym => MoveID.TriAttack,
                BattleTerrain.Cave => MoveID.PowerGem,
                BattleTerrain.Sand or BattleTerrain.Rock
                    => MoveID.EarthPower,
                BattleTerrain.Water => MoveID.HydroPump,
                BattleTerrain.Snow or BattleTerrain.Ice
                    => MoveID.IceBeam,
                BattleTerrain.Bridge or BattleTerrain.Sky
                    => MoveID.AirSlash,
                BattleTerrain.Grass or BattleTerrain.Woods
                    or BattleTerrain.Flowers
                    => MoveID.EnergyBall,
                BattleTerrain.Volcano => MoveID.LavaPlume,
                BattleTerrain.Marsh => MoveID.MudBomb,
                BattleTerrain.BurialGround => MoveID.ShadowBall,
                BattleTerrain.UltraSpace => MoveID.Psyshock,
                BattleTerrain.Space => MoveID.DracoMeteor,
                _ => MoveID.None
            };
            Moves[index] = terrain switch
            {
                Terrain.Electric => MoveID.Thunderbolt,
                Terrain.Misty => MoveID.None, //MoveID.Moonblast,
                Terrain.Grassy => MoveID.EnergyBall,
                Terrain.Psychic => MoveID.Psychic,
                _ => Moves[index]
            };
            yield return Announce("Nature Power became " + GetMove(index).name + "!");
        }

        CheckForFollowMe(index);

        switch (GetMove(index).effect)
        {
            case MirrorMove:
                user.dontCheckPP = true;
                Moves[index] = user.lastTargetedMove;
                yield return ExecuteMove(index);
                yield break;
            case Metronome:
                user.dontCheckPP = true;
                yield return DoMoveAnimation(index, Moves[index]);
                Moves[index] = (MoveID)(random.Next() % (int)MoveID.Count); //Todo: Add double or multi-battle functionality (targeting)
                yield return ExecuteMove(index);
                yield break;
            case Assist:
                user.dontCheckPP = true;
                yield return DoMoveAnimation(index, Moves[index]);
                Moves[index] = GetAssistMove(index);
                yield return ExecuteMove(index);
                yield break;
            case Sketch:
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
            case Curse:
                if (!user.HasType(Type.Ghost))
                {
                    if (user.attackStage < 6 || user.defenseStage < 6
                        || user.speedStage > -6)
                    {
                        yield return BattleAnim.AttackerAnims(this, index, MoveID.NonGhostCurse, 0);
                    }
                    yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, index);
                    yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, index);
                    doStatAnim = true;
                    yield return BattleEffect.StatDown(this, index, Stat.Speed, 1, index);
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                break;
            case Fling when EffectiveItem(index).Data().flingPower == 0
                || user.item.MegaStoneUser() == user.PokemonData.species:
            case Snore
            when (user.PokemonData.status != Status.Sleep && !HasAbility(index, Comatose)):
            case FakeOut when user.turnOnField > 1:
            case SpitUp when user.stockpile == 0:
            case Swallow when user.stockpile == 0 || user.AtFullHealth:
            case NaturalGift when EffectiveItem(index).Data().type != ItemType.Berry:
            case MeFirst when PokemonOnField[Targets[index]].done:
            case MeFirst when Moves[Targets[index]].Data().effect == MeFirst:
            case Copycat when (lastMoveUsed.HasFlag(cannotMimic)):
            case LastResort when !user.CanUseLastResort:
            case AfterYou when PokemonOnField[Targets[index]].done:
                yield return Announce(BattleText.MoveFailed);
                user.done = true;
                MoveCleanup();
                yield break;
            case Fling:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " flung its " + user.item.Data().itemName + "!");
                break;
            case MeFirst:
                user.dontCheckPP = true;
                user.meFirst = true;
                Moves[index] = Moves[Targets[index]];
                yield return ExecuteMove(index);
                yield break;
            case Copycat:
                user.dontCheckPP = true;
                Moves[index] = lastMoveUsed;
                yield return ExecuteMove(index);
                yield break;
            case FocusPunchAttack when !user.focused:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " lost its focus and couldn't move!");
                user.done = true;
                MoveCleanup();
                yield break;
            case SleepTalk:
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
                            Targets[index] = (3 - index);
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
            case Magnitude:
                (int magnitude, int power) = random.NextDouble() switch
                {
                    < 0.05 => (4, 10),
                    < 0.15 => (5, 30),
                    < 0.35 => (6, 50),
                    < 0.65 => (7, 70),
                    < 0.85 => (8, 90),
                    < 0.95 => (9, 110),
                    _ => (10, 150),
                };
                yield return Announce("Magnitude " + magnitude + "!");
                singleMovePower = power;
                break;
            case Present:
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
            case AfterYou:
                yield return Announce(MonNameWithPrefix(Targets[index], true) +
                    " took the kind offer!");
                user.done = true;
                MoveCleanup();
                StartCoroutine(TryMove(Targets[index]));
                yield break;
            default: break;
        }
        if (GetMove(index).targets == Target.Field)
        {
            yield return DoFieldEffect(index, Moves[index]);
            user.done = true;
            MoveCleanup();
            yield break;
        }
        switch (GetMove(index).effect)
        {
            case Counter:
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
            case MetalBurst:
                if (PokemonOnField[user.lastDamageDoer].exists
                    && PokemonOnField[user.lastDamageDoer].done
                    && PokemonOnField[index].damageTaken > 0)
                    {
                        PokemonOnField[user.lastDamageDoer].isTarget = true;
                    }
                break;
            case Thrash:
                PokemonOnField[GetRandomOpponentMon(index > 2)].isTarget = true;
                //Debug.Log("Handling thrash effect");
                if (!user.thrashing)
                {
                    user.thrashing = true;
                    user.lockedInMove = Moves[index];
                    user.thrashingTimer = 0;
                }
                break;
            case Uproar:
                PokemonOnField[GetRandomOpponentMon(index > 2)].isTarget = true;
                if (!user.uproar)
                {
                    user.uproar = true;
                    user.lockedInMove = Moves[index];
                    user.uproarTimer = 0;
                }
                break;
            case SelfDestruct:
                user.PokemonData.HP = 0;
                user.PokemonData.fainted = true;
                goto default;
            case Teleport:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    else
                    {
                        yield return DoMoveAnimation(index, Moves[index]);
                        yield return SwitchMove(index);
                    }
                }
                else
                { //Todo: double and multi functionality
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.done = true;
                        yield break;

                    }
                    yield return DoMoveAnimation(index, Moves[index]);
                    LeaveFieldCleanup(index);
                    yield return BattleEffect.VoluntarySwitch(this, 0, nextMon, false, true);
                    yield return EntryAbilityCheck(0);
                }
                yield break;
            case BatonPass:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    else
                    {
                        partyBackButtonInactive = true;
                        switchingMon = index;
                        choseSwitchMon = false;
                        yield return DoMoveAnimation(index, Moves[index]);
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
                    yield return DoMoveAnimation(index, Moves[index]);
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
                        lastMoveUsed = MoveID.None;
                        break;
                    default:
                        yield return Announce("Error 103");
                        break;
                }
                break;
            case Recharge:
                user.lockedInNextTurn = true;
                user.lockedInMove = MoveID.Recharge;
                goto default;
            case MoveEffect.Transform:
                yield return BattleEffect.TransformMon(this, index, Targets[index]);
                CleanStatSwaps(user);
                user.done = true;
                MoveCleanup();
                yield break;
            case ChargingAttack:
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
                    case MoveID.Dive:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.DiveAttack;
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " hid underwater!");
                        break;
                    case MoveID.Bounce:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BounceAttack;
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " sprang up!");
                        break;
                    case MoveID.ShadowForce:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.ShadowForceAttack;
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " vanished instantly!");
                        break;
                    default:
                        break;
                }
                if (GoToHit) { goto default; }
                break;
            case BeatUp:
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
                            yield return ProcessHits(index, Moves[index], isMultiTarget,
                                powerOverride: (5 + (party[i].SpeciesData.baseAttack / 10)));
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
                        if (GetMove(index).effect is not Direct40 or Direct20 or
                            DirectLevel or Endeavor or PainSplit or OHKO)
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
                    if (PokemonOnField[i].gotMoveEffect) targetsAnyone = true;
                    if (PokemonOnField[i].abilityHealed25)
                    {
                        yield return BattleEffect.Heal(this, i,
                            PokemonOnField[i].PokemonData.hpMax >> 2);
                        yield return Announce(MonNameWithPrefix(i, true) +
                            " was healed by " + EffectiveAbility(i).Name() + "!");
                        targetsAnyone = true;
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                        yield return ProcessBerries(i, true);
                }
                if (!targetsAnyone)
                {
                    yield return Announce(BattleText.MoveFailed);
                }
                yield return ProcessFainting();
                yield return ProcessDestinyBondAndGrudge(index);
                break;
            case MultiHit2to5 or MultiHit2 or Twineedle or TripleHit:
                {
                    if (hitAnyone)
                    {
                        int hits;
                        switch (GetMove(index).effect)
                        {
                            case MultiHit2to5:
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
                            case TripleHit:
                                hits = 3;
                                break;
                            case MultiHit2:
                            case Twineedle:
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
                            CheckReducingAndRetaliatingBerries(index);
                            yield return DoMoveAnimation(index, Moves[index]);
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].gotReducingBerryEffect)
                                {
                                    yield return BattleAnim.UseItem(this, j);
                                    yield return Announce("The "
                                        + PokemonOnField[j].eatenBerry.Data().itemName
                                        + " weakened the damage to "
                                        + MonNameWithPrefix(j, false) + "!");
                                }
                                if (PokemonOnField[j].ateRetaliationBerry)
                                {
                                    PokemonOnField[index].DoProportionalDamage(0.125F);
                                    yield return new WaitForSeconds(1.0F);
                                    yield return Announce(MonNameWithPrefix(index, true)
                                        + " was hurt by the "
                                        + PokemonOnField[j].eatenBerry.Data().itemName + "!");
                                    yield return ProcessFaintingSingle(index);
                                }
                            }
                            yield return HandleHitFlashes(index);
                            if (GetMove(index).effect == TripleHit)
                            {
                                yield return ProcessHits(index, Moves[index], isMultiTarget,
                                powerOverride: (GetMove(index).power * (i + 1)));
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
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].isHit)
                                    yield return ProcessBerries(j, true);
                                else if (PokemonOnField[j].gotMoveEffect)
                                    yield return ProcessBerries(j, false);
                            }
                            CleanForMultiHitMoves();
                            yield return HandleAbilityEffects();
                            if (pokemonLeft == false || !continueMultiHitMove)
                            {
                                hits = i + 1;
                                break;
                            }
                            if (GetMove(index).effect == TripleHit
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
                        BattlePokemon target = PokemonOnField[i];
                        if (target.isHit)
                        {
                            float effectiveness = GetTypeEffectiveness(user, target, Moves[index]);
                            yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                            targetsAnyone = true;
                        }
                        if (target.isMissed)
                        {
                            yield return Announce(target.PokemonData.monName + BattleText.AvoidedAttack);
                            targetsAnyone = true;
                        }
                        if (target.wasProtected)
                        {
                            yield return Announce(target.PokemonData.monName + " protected itself!");
                            targetsAnyone = true;
                        }
                        if (target.gotMoveEffect)
                        {
                            targetsAnyone = true;
                        }
                        if (target.abilityHealed25)
                        {
                            yield return BattleEffect.Heal(this, i,
                                target.PokemonData.hpMax >> 2);
                            yield return Announce(MonNameWithPrefix(i, true) +
                                " was healed by " + EffectiveAbility(i).Name() + "!");
                            targetsAnyone = true;
                        }
                    }
                    if (!targetsAnyone)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    yield return ProcessFainting(true, index);
                    yield return ProcessDestinyBondAndGrudge(index);
                    break;
                }
            default:
                {
                    if (Moves[index].Data().power > 0) checkParentalBond = true;
                    GetCrits(index, Moves[index]);
                    GetMoveEffects(index, Moves[index]);
                    GetAbilityEffects(index, Moves[index]);
                    CheckReducingAndRetaliatingBerries(index);
                    if (GetMove(index).power == 0) { CleanForNonDamagingMoves(); }
                    if (hitAnyone &&
                        !(Moves[index].HasFlag(snatchAffected)
                        && snatch))
                    { yield return DoMoveAnimation(index, Moves[index]); }
                    yield return HandleHitFlashes(index);
                    yield return ProcessHits(index, Moves[index], isMultiTarget, parentalBond);
                    for (int i = 0; i < 6; i++)
                    {
                        if (PokemonOnField[i].gotReducingBerryEffect)
                        {
                            yield return BattleAnim.UseItem(this, i);
                            yield return Announce("The "
                                + PokemonOnField[i].eatenBerry.Data().itemName
                                + " weakened the damage to "
                                + MonNameWithPrefix(i, false) + "!");
                        }
                        if (PokemonOnField[i].ateRetaliationBerry)
                        {
                            PokemonOnField[index].DoProportionalDamage(0.125F);
                            yield return new WaitForSeconds(1.0F);
                            yield return Announce(MonNameWithPrefix(index, true)
                                + " was hurt by the "
                                + PokemonOnField[i].eatenBerry.Data().itemName + "!");
                            yield return ProcessFaintingSingle(index);
                        }
                    }
                    targetsAnyone = false;
                    for (int i = 0; i < 6; i++)
                    {
                        BattlePokemon target = PokemonOnField[i];
                        if (target.isHit)
                        {
                            targetsAnyone = true;
                            if (GetMove(index).effect == OHKO)
                            {
                                yield return Announce(BattleText.OHKO);
                            }
                            else if (GetMove(index).effect is not
                                (Direct20 or Direct40
                                or DirectLevel or Counter
                                or Endeavor or OHKO
                                or BideHit or Psywave
                                or SuperFang or MetalBurst))
                            {
                                float effectiveness = GetTypeEffectiveness(user, target, Moves[index]);
                                yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                            }
                        }
                        if (target.isMissed)
                        {
                            targetsAnyone = true;
                            yield return Announce(MonNameWithPrefix(i, true) + BattleText.AvoidedAttack);
                        }
                        if (target.isUnaffected)
                        {
                            targetsAnyone = true;
                            yield return Announce(BattleText.NoEffect + MonNameWithPrefix(i, false) + "...");
                        }
                        if (target.gotMoveEffect)
                        {
                            targetsAnyone = true;
                        }
                        if (target.abilityHealed25)
                        {
                            yield return BattleEffect.Heal(this, i,
                                target.PokemonData.hpMax >> 2);
                            yield return Announce(MonNameWithPrefix(i, true) +
                                " was healed by " + NameTable.Ability[
                                    (int)target.ability] + "!");
                            targetsAnyone = true;
                        }
                        if (target.isCrit)
                        {
                            if (battleType == BattleType.Single)
                            {
                                yield return Announce(BattleText.CriticalHit);
                            }
                        }

                    }
                    for (int i = 0; i < 6; i++)
                    {
                        if (PokemonOnField[i].isHit)
                            yield return ProcessBerries(i, true);
                        else if (PokemonOnField[i].gotMoveEffect)
                            yield return ProcessBerries(i, false);
                    }
                    yield return HandleAbilityEffects();
                    if (!targetsAnyone)
                    {
                        yield return Announce(BattleText.MoveFailed);
                    }
                    if (!hitAnyone)
                    {
                        user.thrashing = false;
                        user.uproar = false;
                        user.lockedInNextTurn = false;
                    }
                    yield return ProcessFainting(true, index);
                    yield return ProcessDestinyBondAndGrudge(index);
                    yield return HandleMoveEffect(index);
                    break;
                }
        }

        switch (GetMove(index).effect)
        {
            case Recoil33 when !HasAbility(index, RockHead):
                user.DoNonMoveDamage(Max(1, user.moveDamageDone / 3));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case VoltTackle when !HasAbility(index, RockHead):
            case Recoil25 when !HasAbility(index, RockHead):
            case FlareBlitz when !HasAbility(index, RockHead):
                user.DoNonMoveDamage(Max(1, user.moveDamageDone / 4));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Recoil25Max when !HasAbility(index, RockHead):
                user.DoProportionalDamage(0.25F);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Fling:
                UseUpItem(index);
                break;
            case Thrash:
                user.thrashingTimer++;
                if (user.thrashingTimer == 3
                    || user.thrashingTimer == 2
                    && random.NextDouble() > 0.5)
                {
                    yield return BattleEffect.Confuse(this, index);
                    user.thrashing = false;
                }
                break;
            case Uproar:
                user.uproarTimer++;
                if (user.uproarTimer == 3)
                {
                    yield return Announce("The uproar calmed down!");
                    user.uproar = false;
                }
                else yield return Announce(MonNameWithPrefix(index, true)
                    + " is making an uproar!");
                break;
            case Crash50Max when user.moveDamageDone == 0 &&
                    !HasAbility(index, RockHead):
                user.DoProportionalDamage(0.5F);
                yield return Announce(MonNameWithPrefix(index, true) + " kept going and crashed!");
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case SelfDestruct or Memento:
                yield return ProcessFaintingSingle(index);
                break;
            case SpitUp:
                if (user.stockpileDef > 0 || user.stockpileSpDef > 0)
                    yield return Announce("The stockpiled effect wore off!");
                user.defenseStage = Max(-6, user.defenseStage - user.stockpileDef);
                user.spDefStage = Max(-6, user.spDefStage - user.stockpileSpDef);
                user.stockpileDef = 0;
                user.stockpileSpDef = 0;
                user.stockpile = 0;
                break;
            default:
                break;
        }
        if (GetMove(index).effect == FuryCutter && user.moveDamageDone > 0)
        {
            if (user.furyCutterIntensity < 3) user.furyCutterIntensity++;
        }
        else user.furyCutterIntensity = 0;
        for (int i = 0; i < 6; i++)
        {
            yield return HandleAbilityEffects();
        }
        if (!user.dontCheckPP) CheckLeppaBerry(index, MoveNums[index]);
        if (!parentalBond && checkParentalBond && HasAbility(index, ParentalBond))
        {
            user.dontCheckPP = true;
            yield return ExecuteMove(index, true);
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
        flungItem = ItemID.None;
        for (int i = 0; i < 6; i++)
        {
            BattlePokemon mon = PokemonOnField[i];
            mon.isHit = false;
            mon.isTarget = false;
            mon.isMissed = false;
            mon.isCrit = false;
            mon.isUnaffected = false;
            mon.gotMoveEffect = false;
            mon.moveDamageDone = 0;
            mon.gotAbilityEffectSelf = false;
            mon.abilityHealed25 = false;
            mon.wasProtected = false;
            mon.gotAteBoost = false;
            mon.gotReducingBerryEffect = false;
            mon.ateRetaliationBerry = false;
            mon.meFirst = false;
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
                doStatAnim = true;
                yield return DoMoveEffect(i, Moves[index], index);
            }
        }
    }

    private MoveID GetAssistMove(int index)
    {
        Pokemon[] party = index < 3 ? OpponentPokemon : PlayerPokemon;
        List<MoveID> possibleMoves = new();
        for (int i = 0; i < 6; i++)
        {
            if (party[i] == PokemonOnField[index].PokemonData || !party[i].exists) continue;
            for (int j = 0; j < 4; j++)
            {
                if (party[i].MoveIDs[j] is not MoveID.Counter or MoveID.DestinyBond
                    or MoveID.Protect or MoveID.Detect or MoveID.Endure or MoveID.Dig
                    or MoveID.Fly or MoveID.FocusPunch or MoveID.FollowMe or MoveID.Mimic
                    or MoveID.HelpingHand or MoveID.Metronome or MoveID.MirrorCoat
                    or MoveID.MirrorMove or MoveID.Sketch or MoveID.SleepTalk
                    or MoveID.Thief or MoveID.Transform or MoveID.Trick
                    or MoveID.Whirlwind or MoveID.Roar or MoveID.NaturePower
                    ) possibleMoves.Add(party[i].MoveIDs[j]);
            }
        }
        if (possibleMoves.Count == 0) return MoveID.None;
        else return possibleMoves[(int)(random.NextDouble() * possibleMoves.Count)];
    }

    private IEnumerator DoMoveEffect(int index, MoveID move, int attacker)
    {
        if (move.HasFlag(snatchAffected) && snatch)
        {
            yield return Announce(MonNameWithPrefix(snatchingMon, true)
                + " snatched " + MonNameWithPrefix(attacker, false)
                + "'s move!");
            yield return BattleAnim.AttackerAnims(this, snatchingMon, move, 0);
            index = snatchingMon;
            attacker = snatchingMon;
        }
        if (move.HasFlag(magicBounceAffected) &&
            (PokemonOnField[index].magicCoat
             || (HasAbility(index, MagicBounce) && !HasMoldBreaker(attacker))))
        {
            //yield return BattleAnim.MagicCoatActivates(this, index);
            yield return Announce(MonNameWithPrefix(index, true) + " bounced back the move!");
            int swap = attacker;
            attacker = index;
            index = swap;
        }
        MoveEffect effect = move.Data().effect;
        if (effect == Fling) effect =
                EffectiveItem(attacker).Data().flingEffect;
        switch (effect)
        {
            case Burn:
            case FlareBlitz:
                yield return BattleEffect.GetBurn(this, index);
                break;
            case VoltTackle:
            case Paralyze:
                yield return BattleEffect.GetParalysis(this, index);
                break;
            case Poison:
            case Twineedle:
                yield return BattleEffect.GetPoison(this, index);
                break;
            case Toxic:
                yield return BattleEffect.GetBadPoison(this, index);
                break;
            case Freeze:
                yield return BattleEffect.GetFreeze(this, index);
                break;
            case Sleep:
                yield return BattleEffect.FallAsleep(this, index);
                break;
            case Confuse:
                yield return BattleEffect.Confuse(this, index);
                break;
            case Swagger:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 2, attacker);
                goto case Confuse;
            case Flatter:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                goto case Confuse;
            case TriAttack:
                yield return BattleEffect.TriAttack(this, index);
                break;
            case SmellingSalts:
                yield return BattleEffect.HealParalysis(this, index);
                break;
            case WakeUpSlap:
                yield return BattleEffect.WakeUp(this, index);
                break;
            case LeechSeed:
                yield return BattleEffect.GetLeechSeed(this, index, attacker);
                break;
            case Nightmare:
                yield return BattleEffect.GetNightmare(this, index);
                break;
            case Spite:
                yield return BattleEffect.DrainPP(this, index, 4);
                yield return CheckLeppaBerry(index, PokemonOnField[index].lastMoveSlot);
                break;
            case Yawn:
                PokemonOnField[index].yawnNextTurn = true;
                yield return Announce(MonNameWithPrefix(index, true) + " grew drowsy!");
                break;
            case Taunt:
                yield return BattleEffect.GetTaunted(this, index);
                break;
            case Torment:
                yield return BattleEffect.Torment(this, index);
                break;
            case Embargo:
                yield return BattleEffect.Embargo(this, index);
                break;
            case Disable:
                yield return BattleEffect.Disable(this, index);
                break;
            case Encore:
                yield return BattleEffect.GetEncored(this, index);
                break;
            case SuppressAbility:
                yield return BattleEffect.SuppressAbility(this, index);
                break;
            case Trap:
                yield return BattleEffect.StartTrapping(this, attacker, index);
                break;
            case HealBlock:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " can no longer heal!");
                PokemonOnField[index].healBlocked = true;
                PokemonOnField[index].healBlockTimer = 5;
                break;
            case Trick:
                yield return BattleEffect.SwitchItems(this, attacker, index);
                break;
            case RolePlay:
                yield return BattleEffect.RolePlay(this, attacker, index);
                break;
            case SkillSwap:
                yield return BattleEffect.SkillSwap(this, attacker, index);
                break;
            case Entrainment:
                yield return BattleEffect.Entrainment(this, attacker, index);
                break;
            case WorrySeed:
                yield return BattleEffect.WorrySeed(this, index);
                break;
            case SimpleBeam:
                yield return BattleEffect.SimpleBeam(this, index);
                break;
            case Imprison:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " sealed any moves its target shares with it!");
                PokemonOnField[index].imprisoned = true;
                break;
            case SecretPower:
                if (terrain != Terrain.None) switch (terrain)
                    {
                        case Terrain.Electric:
                            yield return BattleEffect.GetParalysis(this, index);
                            break;
                        case Terrain.Psychic:
                            yield return BattleEffect.StatDown(this, index, Stat.Speed,
                                1, attacker);
                            break;
                        case Terrain.Misty:
                            yield return BattleEffect.StatDown(this, index, Stat.SpAtk,
                                1, attacker);
                            break;
                        case Terrain.Grassy:
                            yield return BattleEffect.FallAsleep(this, index);
                            break;
                    }
                else switch (battleTerrain)
                    {
                        case BattleTerrain.Building:
                        case BattleTerrain.Gym:
                            yield return BattleEffect.GetParalysis(this, index);
                            break;
                        case BattleTerrain.Cave:
                        case BattleTerrain.Space:
                        case BattleTerrain.BurialGround:
                            TryToFlinch(index, attacker);
                            break;
                        case BattleTerrain.Sand:
                        case BattleTerrain.Rock:
                            yield return BattleEffect.StatDown(this, index, Stat.Accuracy,
                                1, attacker);
                            break;
                        case BattleTerrain.Water:
                            yield return BattleEffect.StatDown(this, index, Stat.Attack,
                                1, attacker);
                            break;
                        case BattleTerrain.Ice:
                        case BattleTerrain.Snow:
                            yield return BattleEffect.GetFreeze(this, index);
                            break;
                        case BattleTerrain.Grass:
                        case BattleTerrain.Woods:
                        case BattleTerrain.Flowers:
                            yield return BattleEffect.FallAsleep(this, index);
                            break;
                        case BattleTerrain.Volcano:
                            yield return BattleEffect.GetBurn(this, index);
                            break;
                        case BattleTerrain.Marsh:
                        case BattleTerrain.Sky:
                        case BattleTerrain.Bridge:
                            yield return BattleEffect.StatDown(this, index, Stat.Speed,
                                1, attacker);
                            break;
                        case BattleTerrain.UltraSpace:
                            yield return BattleEffect.StatDown(this, index, Stat.Defense,
                                1, attacker);
                            break;
                    }
                break;
            case BreakScreens:
                yield return BattleEffect.BreakScreens(this, index);
                break;
            case Defog:
                yield return BattleEffect.Defog(this, attacker, index);
                break;
            case AttackUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                break;
            case AttackUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 2, attacker);
                break;
            case DefenseUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                break;
            case DefenseUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 2, attacker);
                break;
            case SpAtkUp1:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                break;
            case SpAtkUp2:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 2, attacker);
                break;
            case SpAtkUp3:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 3, attacker);
                break;
            case SpDefUp2:
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 2, attacker);
                break;
            case SpeedUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                break;
            case SpeedUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 2, attacker);
                break;
            case EvasionUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Evasion, 1, attacker);
                break;
            case EvasionUp2:
                yield return BattleEffect.StatUp(this, index, Stat.Evasion, 2, attacker);
                break;
            case CritRateUp2:
                yield return BattleEffect.StatUp(this, index, Stat.CritRate, 2, attacker);
                break;
            case AttackDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 1, attacker);
                break;
            case AttackDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 2, attacker);
                break;
            case DefenseDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 1, attacker);
                break;
            case DefenseDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 2, attacker);
                break;
            case SpAtkDown1:
                yield return BattleEffect.StatDown(this, index, Stat.SpAtk, 1, attacker);
                break;
            case SpAtkDown2:
            case Captivate:
                yield return BattleEffect.StatDown(this, index, Stat.SpAtk, 2, attacker);
                break;
            case SpDefDown1:
                yield return BattleEffect.StatDown(this, index, Stat.SpDef, 1, attacker);
                break;
            case SpDefDown2:
                yield return BattleEffect.StatDown(this, index, Stat.SpDef, 2, attacker);
                break;
            case SpeedDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Speed, 1, attacker);
                break;
            case SpeedDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Speed, 2, attacker);
                break;
            case AccuracyDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Accuracy, 1, attacker);
                break;
            case EvasionDown2:
                yield return BattleEffect.StatDown(this, index, Stat.Evasion, 2, attacker);
                break;
            case Growth:
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
            case AllUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                break;
            case BellyDrum:
                yield return BattleEffect.BellyDrum(this, index);
                break;
            case Acupressure:
                List<Stat> possibleStats = new();
                for (int i = 1; i < (int)Stat.CritRate; i++)
                {
                    if (PokemonOnField[index].GetStatStage((Stat)i) > 6)
                    {
                        possibleStats.Add((Stat)i);
                    }
                }
                if (possibleStats.Count == 0) break;
                yield return BattleEffect.StatUp(this, index,
                    possibleStats[(int)(random.NextDouble() * possibleStats.Count)],
                    2, index);
                break;
            case RapidSpin:
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                yield return BattleEffect.RemoveHazards(this, index);
                break;
            case AttackDefenseUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                break;
            case AttackSpeedUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                break;
            case AttackAccuracyUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Accuracy, 1, attacker);
                break;
            case DefenseSpDefUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker);
                break;
            case SpAtkSpDefUp1:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker);
                break;
            case AttackDefenseDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 1, index);
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 1, index);
                break;
            case DefenseSpDefDown1:
                yield return BattleEffect.StatDown(this, index, Stat.Defense, 1, attacker);
                yield return BattleEffect.StatDown(this, index, Stat.SpDef, 1, attacker);
                break;
            case AttackDefAccUp1:
                yield return BattleEffect.StatUp(this, index, Stat.Attack, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Defense, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Accuracy, 1, attacker);
                break;
            case SpAtkSpDefSpeedUp1:
                yield return BattleEffect.StatUp(this, index, Stat.SpAtk, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, attacker);
                yield return BattleEffect.StatUp(this, index, Stat.Speed, 1, attacker);
                break;
            case SwitchHit:
                if (PokemonOnField[index].player)
                {
                    if (PlayerHasMonsInBack)
                        yield return SwitchMove(index);
                }
                else
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        PokemonOnField[index].done = true;
                        break;
                    }
                    yield return DoMoveAnimation(index, Moves[index]);
                    LeaveFieldCleanup(index);
                    yield return BattleEffect.VoluntarySwitch(this, 0, nextMon, true, true);
                    yield return EntryAbilityCheck(0);
                }
                break;
            case Minimize:
                PokemonOnField[index].minimized = true;
                goto case EvasionUp2;
            case DefenseCurl:
                PokemonOnField[index].usedDefenseCurl = true;
                goto case DefenseUp1;
            case Autotomize:
                yield return Announce(MonNameWithPrefix(index, true) + " became nimble!");
                PokemonOnField[index].autotomized = true;
                goto case SpeedUp2;
            case Charge:
                if (!PokemonOnField[index].charged)
                {
                    PokemonOnField[index].charged = true;
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " began charging power!");
                }
                yield return BattleEffect.StatUp(this, index, Stat.SpDef, 1, index);
                break;
            case MoveEffect.Round:
                doRound = true;
                break;
            case Flinch:
            case Snore:
            case FakeOut:
                TryToFlinch(index, attacker);
                break;
            case FlameBurst:
                int announceFlameBurst = 0;
                foreach (int i in GetNeighbors[index])
                {
                    if (PokemonOnField[i].exists)
                    {
                        PokemonOnField[i].DoProportionalDamage(0.0625F);
                        announceFlameBurst = 1;
                    }
                }
                if (announceFlameBurst > 0) Announce("The flames damaged "
                    + MonNameWithPrefix(index, false) + "'s partner"
                    + (announceFlameBurst > 1 ? "s!" : "!"));
                break;
            case Stockpile:
                yield return BattleEffect.Stockpile(this, index);
                break;
            case Swallow:
                yield return BattleEffect.Swallow(this, index);
                break;
            case Memento:
                yield return BattleEffect.StatDown(this, index, Stat.Attack, 2, attacker);
                yield return BattleEffect.StatDown(this, index, Stat.SpAtk, 2, attacker);
                PokemonOnField[attacker].PokemonData.HP = 0;
                PokemonOnField[attacker].PokemonData.fainted = true;
                break;
            case MindReader:
                yield return BattleEffect.GetMindReader(this, attacker, index);
                break;
            case Foresight:
                yield return BattleEffect.Identify(this, index, false);
                break;
            case MiracleEye:
                yield return BattleEffect.Identify(this, index, true);
                break;
            case Telekinesis:
                yield return Announce(MonNameWithPrefix(index, true) + " was hurled into the air!");
                PokemonOnField[index].telekinesis = true;
                PokemonOnField[index].telekinesisTimer = 3;
                break;
            case Substitute:
                yield return BattleEffect.MakeSubstitute(this, index);
                break;
            case PainSplit:
                yield return BattleEffect.PainSplit(this, index, attacker);
                break;
            case PsychoShift:
                yield return BattleEffect.PsychoShift(this, index, attacker);
                break;
            case Pluck:
                if (PokemonOnField[index].item.Data().type == ItemType.Berry)
                {
                    yield return BattleAnim.UseItem(this, attacker);
                    yield return Announce(MonNameWithPrefix(attacker, true) +
                        " stole and ate " + MonNameWithPrefix(index, false) + "'s " +
                        EffectiveItem(index).Data().itemName + "!");
                    yield return DoBerryEffect(attacker, PokemonOnField[index].item.BerryEffect());
                    UseUpItem(index);
                }
                break;
            case FutureSight:
                yield return BattleEffect.GetFutureSight(this, index, attacker);
                break;
            case Feint:
                if (PokemonOnField[index].protect || PokemonOnField[index].wideGuard)
                {
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " fell for the feint!");
                    PokemonOnField[index].protect = false;
                    PokemonOnField[index].wideGuard = false;
                }
                break;
            case DestinyBond:
                PokemonOnField[index].destinyBond = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is trying to take its attacker down with it!");
                break;
            case Grudge:
                PokemonOnField[index].grudge = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " wants its target to bear a grudge!");
                break;
            case Thief:
                yield return BattleEffect.Thief(this, attacker, index);
                break;
            case KnockOff:
                yield return BattleEffect.KnockOff(this, attacker, index);
                break;
            case SmackDown:
                yield return Announce(MonNameWithPrefix(index, true) +
                    " fell straight down!");
                PokemonOnField[index].smackDown = true;
                break;
            case Absorb50:
            case DreamEater:
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
            case Rollout:
                if (PokemonOnField[index].rolloutIntensity < 4
                    && PokemonOnField[index].moveDamageDone > 0)
                {
                    PokemonOnField[index].lockedInNextTurn = true;
                    PokemonOnField[index].lockedInMove
                        = PokemonOnField[index].moveUsedThisTurn;
                    PokemonOnField[index].rolloutIntensity++;
                }
                break;
            case Uproar:
                yield return BattleEffect.StartUproar(this, index);
                break;
            case PayDay:
                if (!payDay)
                {
                    payDay = true;
                    yield return Announce("Coins were scattered everywhere!");
                }
                break;
            case PsychUp:
                yield return BattleEffect.PsychUp(this, attacker, index);
                break;
            case HeartSwap:
                yield return BattleEffect.HeartSwap(this, attacker, index);
                break;
            case PowerSwap:
                int targetAttack = PokemonOnField[index].attackStage;
                int targetSpAtk = PokemonOnField[index].spAtkStage;
                PokemonOnField[index].attackStage = PokemonOnField[attacker].attackStage;
                PokemonOnField[index].spAtkStage = PokemonOnField[attacker].spAtkStage;
                PokemonOnField[attacker].attackStage = targetAttack;
                PokemonOnField[attacker].spAtkStage = targetSpAtk;
                yield return Announce(MonNameWithPrefix(attacker, true)
                    + " swapped all changes to its Attack and Sp. Attack with its target!");
                break;
            case GuardSwap:
                int targetDefense = PokemonOnField[index].defenseStage;
                int targetSpDef = PokemonOnField[index].spDefStage;
                PokemonOnField[index].defenseStage = PokemonOnField[attacker].defenseStage;
                PokemonOnField[index].spDefStage = PokemonOnField[attacker].spDefStage;
                PokemonOnField[attacker].defenseStage = targetDefense;
                PokemonOnField[attacker].spDefStage = targetSpDef;
                yield return Announce(MonNameWithPrefix(attacker, true)
                    + " swapped all changes to its Defense and Sp. Defense with its target!");
                break;
            case GuardSplit:
                yield return BattleEffect.GuardSplit(this, index, attacker);
                break;
            case PowerSplit:
                yield return BattleEffect.PowerSplit(this, index, attacker);
                break;
            case Curse:
                yield return BattleEffect.GhostCurse(this, attacker, index);
                yield return ProcessFaintingSingle(attacker);
                break;
            case ForcedSwitch:
                yield return BattleEffect.ForcedSwitch(this, index);
                break;
            case Rest:
                yield return BattleEffect.Rest(this, index);
                break;
            case Snatch:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " waits for a target to make a move!");
                snatch = true;
                snatchingMon = index;
                break;
            case Mimic:
                yield return BattleEffect.DoMimic(this, attacker, index);
                break;
            case Conversion:
                yield return BattleEffect.Conversion(this, index);
                break;
            case Conversion2:
                yield return BattleEffect.Conversion2(this, index, Targets[index]);
                break;
            case Camouflage:
                yield return BattleEffect.Camouflage(this, index);
                break;
            case Recycle:
                yield return BattleEffect.Recycle(this, index);
                break;
            case PowerTrick:
                if (PokemonOnField[index].powerTrick)
                    PokemonOnField[index].powerTrickSuppressed
                        = !PokemonOnField[index].powerTrickSuppressed;
                PokemonOnField[index].powerTrick = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " swapped its Attack and Defense stats!");
                break;
            case Protect:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " protected itself!");
                PokemonOnField[index].protect = true;
                break;
            case WideGuard:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " protected its team!");
                for (int i = 3 * (index / 3); i < (3 * (index / 3)) + 3; i++)
                    PokemonOnField[index].wideGuard = true;
                break;
            case Endure:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " braced itself!");
                break;
            case Ingrain:
                yield return BattleEffect.Ingrain(this, index);
                break;
            case AquaRing:
                yield return BattleEffect.StartAquaRing(this, index);
                break;
            case MagnetRise:
                PokemonOnField[index].magnetRise = true;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " levitated with electromagnetism!");
                break;
            case Roost:
                PokemonOnField[index].roosting = true;
                goto case Heal50;
            case Heal50:
                yield return BattleEffect.Heal(this, index, PokemonOnField[index].PokemonData.hpMax >> 1);
                break;
            case HealWeather:
                yield return BattleEffect.Heal(this, index, weather switch
                {
                    Weather.Sun => (PokemonOnField[index].PokemonData.hpMax << 1) / 3,
                    Weather.None => PokemonOnField[index].PokemonData.hpMax >> 1,
                    _ => PokemonOnField[index].PokemonData.hpMax >> 2,
                });
                break;
            case Wish:
                yield return BattleEffect.MakeWish(this, index);
                break;
            case HealStatus:
                yield return BattleEffect.HealStatus(this, index);
                break;
            case HealingWish:
                healingWish[index] = true;
                PokemonOnField[index].PokemonData.HP = 0;
                PokemonOnField[index].PokemonData.fainted = true;
                yield return ProcessFaintingSingle(index);
                break;
            case PerishSong:
                BattleEffect.GetPerishSong(this, index);
                if (!oneAnnouncementDone)
                {
                    yield return Announce("All Pokémon that heard the song will faint in three turns!");
                }
                break;
            case Attract:
                yield return BattleEffect.Infatuate(this, index, attacker);
                break;
            case MoveEffect.ContinuousDamage:
                yield return BattleEffect.GetContinuousDamage(this, attacker, index, Moves[attacker]);
                break;
            case FollowMe:
                PokemonOnField[index].followMe = true;
                followMeActive = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became the center of attention!");
                break;
            case RagePowder:
                PokemonOnField[index].wasRagePowder = true;
                goto case FollowMe;
            case HelpingHand:
                yield return BattleEffect.HelpingHand(this, attacker, index);
                break;
            case MagicCoat:
                yield return Announce(MonNameWithPrefix(index, true) + " shrouded itself with Magic Coat!");
                PokemonOnField[index].magicCoat = true;
                break;
            case OHKO:
            case Hit:
            default:
                break;
        }
    }

    private IEnumerator DoFieldEffect(int index, MoveID move)
    {
        MoveEffect effect = move.Data().effect;
        if (move.HasFlag(snatchAffected) && snatch)
        {
            yield return Announce(MonNameWithPrefix(snatchingMon, true)
                + " snatched " + MonNameWithPrefix(index, false)
                + "'s move!");
            yield return BattleAnim.AttackerAnims(this, snatchingMon, move, 0);
            index = snatchingMon;
        }
        for (int i = (1 - index / 3) * 3; i < (2 - index / 3) * 3; i++)
        {
            if (move.HasFlag(magicBounceAffected))
            {
                if (PokemonOnField[i].magicCoat
                    || (HasAbility(i, MagicBounce) && !HasAbility(index, MoldBreaker)))
                {
                    //yield return BattleAnim.MagicCoatActivates(this, index);
                    yield return Announce(MonNameWithPrefix(i, true) + " bounced back the move!");
                    index = i;
                    break;
                }
            }
        }
        switch (effect)
        {
            case Mist:
                yield return BattleEffect.StartMist(this, index / 3);
                break;
            case LuckyChant:
                yield return BattleEffect.LuckyChant(this, index / 3);
                break;
            case LightScreen:
                yield return BattleEffect.StartLightScreen(this, index / 3);
                break;
            case Reflect:
                yield return BattleEffect.StartReflect(this, index / 3);
                break;
            case Tailwind:
                yield return BattleEffect.Tailwind(this, index / 3);
                break;
            case Haze:
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
            case HealBell:
                yield return BattleEffect.HealBell(this, index);
                break;
            case Spikes:
                yield return BattleEffect.Spikes(this, index);
                break;
            case ToxicSpikes:
                yield return BattleEffect.ToxicSpikes(this, index);
                break;
            case StealthRock:
                yield return BattleEffect.StealthRock(this, index);
                break;
            case Safeguard:
                yield return BattleEffect.StartSafeguard(this, index);
                break;
            case MudSport:
                yield return Announce("Electricity's power was weakened!");
                mudSport = true;
                mudSportTimer = 5;
                break;
            case WaterSport:
                yield return Announce("Fire's power was weakened!");
                waterSport = true;
                waterSportTimer = 5;
                break;
            case Gravity:
                yield return BattleEffect.Gravity(this);
                break;
            case TrickRoom:
                yield return BattleEffect.StartTrickRoom(this, index);
                break;
            case WonderRoom:
                yield return BattleEffect.StartWonderRoom(this, index);
                break;
            case MagicRoom:
                yield return BattleEffect.StartMagicRoom(this, index);
                break;
            case Hit:
            default:
                yield break;
        }
    }

    public void CleanStatSwaps(BattlePokemon mon)
    {
        mon.powerTrick = false;
        mon.powerTrickSuppressed = false;
        mon.overrideAttacks = false;
        mon.overrideDefenses = false;
    }

    public void DoNextMove()
    {
        int index = FindNextToMove();
        if (index == TurnOver)
        {
            StartCoroutine(EndTurn());
        }
        else if (index == HandleMega)
        {
            for (int i = 0; i < 6; i++)
                if (megaEvolveOnMove[i])
                {
                    StartCoroutine(DoMegaEvolution(i));
                    return;
                }
        }
        else
        {
            StartCoroutine(TryMove(index));
        }
    }

    public IEnumerator EndTurn()
    {
        if (weather != Weather.None)
        {
            yield return BattleEffect.WeatherContinues(this);
        }
        for (int i = 0; i < 6; i++)
        {
            if (!PokemonOnField[i].exists) continue;
            BattlePokemon mon = PokemonOnField[i];
            switch (EffectiveAbility(i))
            {
                case DrySkin or SolarPower when IsWeatherAffected(i, Weather.Sun):
                    yield return AbilityPopupStart(i);
                    mon.DoProportionalDamage(0.125F);
                    yield return Announce(MonNameWithPrefix(i, true) + " is hurt by" +
                        NameTable.Ability[(int)EffectiveAbility(i)] + "!");
                    yield return AbilityPopupEnd(i);
                    yield return ProcessFaintingSingle(i);
                    break;
                case DrySkin when IsWeatherAffected(i, Weather.Rain):
                    if (!mon.AtFullHealth)
                    {
                        yield return AbilityPopupStart(i);
                        yield return BattleEffect.Heal(this, i, mon.PokemonData.hpMax << 3);
                        yield return Announce(MonNameWithPrefix(i, true) + " is healed by Dry Skin!");
                        yield return AbilityPopupEnd(i);
                    }
                    break;
                case RainDish when IsWeatherAffected(i, Weather.Rain):
                case IceBody when IsWeatherAffected(i, Weather.Snow):
                    if (!mon.AtFullHealth)
                    {
                        yield return AbilityPopupStart(i);
                        yield return BattleEffect.Heal(this, i, mon.PokemonData.hpMax << 4);
                        yield return Announce(MonNameWithPrefix(i, true) + " is healed by"
                            + NameTable.Ability[(int)EffectiveAbility(i)] + "!");
                        yield return AbilityPopupEnd(i);
                    }
                    break;
                default:
                    break;
            }
            if (!HasAbility(i, MagicGuard))
            {
                switch (mon.PokemonData.status)
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
                if (mon.PokemonData.fainted) { continue; }
                if (IsWeatherAffected(i, Weather.Sand) &&
                    !mon.HasType(Type.Ground) && !mon.HasType(Type.Steel) &&
                    !mon.HasType(Type.Rock) &&
                    EffectiveAbility(i) is not SandForce or SandRush or
                    SandVeil or Overcoat)
                {
                    mon.DoProportionalDamage(mon.PokemonData.hpMax << 4);
                    yield return DoHitFlash(i);
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " is buffeted by the sandstorm!");
                }
                yield return ProcessFaintingSingle(i);
                if (mon.PokemonData.fainted) { continue; }
                if (mon.perishSong)
                {
                    yield return BattleEffect.DoPerishSong(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (mon.PokemonData.fainted) { continue; }
                if (mon.getsContinuousDamage)
                {
                    yield return BattleEffect.DoContinuousDamage(this, i, mon.continuousDamageType);
                }
                yield return ProcessFaintingSingle(i);
                if (mon.PokemonData.fainted) { continue; }
                if (mon.nightmare)
                {
                    yield return BattleEffect.DoNightmare(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (mon.PokemonData.fainted) { continue; }
                if (mon.seeded)
                {
                    yield return BattleEffect.DoLeechSeed(this, i);
                }
                yield return ProcessFainting();
                if (mon.PokemonData.fainted) { continue; }
                if (mon.cursed)
                {
                    yield return BattleEffect.DoCurse(this, i);
                }
                yield return ProcessFaintingSingle(i);
                if (mon.PokemonData.fainted) { continue; }
            }
            if (mon.ingrained && !mon.AtFullHealth && !mon.healBlocked)
            {
                //Todo: yield return BattleAnim.IngrainHeal(this, i);
                yield return BattleEffect.Heal(this, i,
                    Max(1, mon.PokemonData.hpMax >> 4));
                yield return Announce(MonNameWithPrefix(i, true)
                    + " absorbed nutrients with its roots!");
            }
            if (mon.hasAquaRing && !mon.AtFullHealth && !mon.healBlocked)
            {
                //Todo: yield return BattleAnim.AquaRingHeal(this, i);
                yield return BattleEffect.Heal(this, i,
                    Max(1, mon.PokemonData.hpMax >> 4));
                yield return Announce("Aqua Ring restored " +
                    MonNameWithPrefix(i, false) + "'s HP!");
            }
            if (mon.encored)
            {
                if (mon.encoreTimer-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true) + "'s encore ended!");
                    mon.encored = false;
                }
            }
            if (mon.taunted)
            {
                if (mon.tauntTimer-- <= 0)
                {
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " shook off the taunt!");
                    mon.taunted = false;
                }
            }
            if (mon.embargoed)
            {
                if (mon.embargoTimer-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " can use items again!");
                    mon.embargoed = false;
                }
            }
            if (mon.healBlocked)
            {
                if (mon.healBlockTimer-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " is cured of its heal block!");
                    mon.healBlocked = false;
                }
            }
            if (mon.telekinesis)
            {
                if (mon.telekinesisTimer-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " was freed from the telekinesis!");
                    mon.telekinesis = false;
                }
            }
            if (mon.yawnThisTurn && mon.PokemonData.status == Status.None
                && !UproarOnField)
            {
                yield return BattleEffect.FallAsleep(this, i);
            }
            mon.yawnThisTurn = mon.yawnNextTurn;
            mon.yawnNextTurn = false;
            if (mon.ability == SpeedBoost)
            {
                yield return AbilityPopupStart(i);
                yield return BattleEffect.StatUp(this, i, Stat.Speed, 1, i);
                yield return AbilityPopupEnd(i);
            }
        }
        while (wishes.Count > 0)
            if (wishes.Peek().turn == turnsElapsed) yield return BattleEffect.GetWish(this);
            else break;
        while (futureSight.Count > 0)
            if (futureSight.Peek().turn == turnsElapsed)
            {
                yield return BattleEffect.FutureSightAttack(this);
                yield return ProcessFainting();
            }
            else break;
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
            if (Sides[i].tailwind)
            {
                Sides[i].tailwindTurns--;
                if (Sides[i].tailwindTurns <= 0)
                {
                    Sides[i].tailwind = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's"
                        + " tailwind wore off!");
                }
            }
            if (Sides[i].luckyChant)
            {
                Sides[i].luckyChantTurns--;
                if (Sides[i].luckyChantTurns <= 0)
                {
                    Sides[i].luckyChant = false;
                    yield return Announce(i == 0 ? "The foes'" : "Your team's"
                        + " Lucky Chant wore off!");
                }
            }
        }
        if (mudSport)
            if (mudSportTimer-- <= 1)
            {
                yield return Announce("The effects of Mud Sport wore off!");
                mudSport = false;
            }
        if (waterSport)
            if (waterSportTimer-- <= 1)
            {
                yield return Announce("The effects of Water Sport wore off!");
                waterSport = false;
            }
        if (gravity)
            if (gravityTimer-- <= 1)
            {
                yield return Announce("Gravity returned to normal!");
                gravity = false;
            }
        if (trickRoom)
            if (trickRoomTimer-- <= 1)
            {
                yield return Announce("The twisted dimensions returned to normal!");
                trickRoom = false;
            }
        turnsElapsed++;
        yield return StartTurn();
    }

    public IEnumerator DoFieldTargetingMove(int index, MoveID move)
    {
        yield return null;
    }

    public IEnumerator StartTurn()
    {
        state = BattleState.Announcement;
        partyBackButtonInactive = false;
        followMeActive = false;
        snatch = false;
        doRound = false;
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
                        yield return BringToField(OpponentPokemon[nextMon], nextMon, 0, false);
                        doAbilityEffect[0] = true;
                    }
                }
                if (!PokemonOnField[3].exists)
                {
                    partyBackButtonInactive = true;
                    switchingMon = 3;
                    choseSwitchMon = false;
                    menuManager.currentPartyMon = 1;
                    menuManager.menuMode = MenuMode.Party;
                    state = BattleState.PlayerInput;
                    while (!choseSwitchMon)
                    {
                        yield return new WaitForSeconds(0.05F);
                    }
                    yield return BattleEffect.VoluntarySwitch(this, 3, switchingTarget, true, false);
                    doAbilityEffect[3] = true;
                }
                break;
        }

        yield return DoEntryAbilitiesAtStartOfTurn();
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
                currentMon.wideGuard = false;
                currentMon.endure = false;
                currentMon.magicCoat = false;
                currentMon.moveUsedLastTurn = currentMon.moveUsedThisTurn;
                currentMon.moveUsedThisTurn = MoveID.None;
                currentMon.damagedThisTurn = false;

                currentMon.helpingHand = 0;
                currentMon.followMe = false;
                currentMon.wasRagePowder = false;
                currentMon.roosting = false;

                currentMon.damagedByMon = new bool[6];

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
            if (currentMon.exists && !currentMon.player && !currentMon.choseMove)
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

    public IEnumerator AbilityPopupStart(int index) =>
        ScriptUtils.Wait(0.2F).Join(abilityControllers[index].Summon(PokemonOnField[index].PokemonData.monName,
            NameTable.Ability[(int)PokemonOnField[index].ability]).Join(ScriptUtils.Wait(0.3F)));

    public IEnumerator AbilityPopupEnd(int index) => abilityControllers[index].Dismiss();

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
        gravity = false;
        gravityTimer = 0;
        announcementLog = new();
        MoveNums = new int[6];
        Targets = new int[6];
        SwitchTargets = new int[6];
        playerFacedOpponent = new bool[6, 6];
        wishes = new();
        futureSight = new();
        turnsElapsed = 0;
        doAbilityEffect = new bool[6];
        menuOpen = false;
        PokemonOnField = new BattlePokemon[6]
        {
            BattlePokemon.MakeEmptyBattleMon(false,0,this),
            BattlePokemon.MakeEmptyBattleMon(false,1,this),
            BattlePokemon.MakeEmptyBattleMon(false,2,this),
            BattlePokemon.MakeEmptyBattleMon(true,0,this),
            BattlePokemon.MakeEmptyBattleMon(true,1,this),
            BattlePokemon.MakeEmptyBattleMon(true,2,this),
        };
        Sides = new Side[2]
        {
            new(false, this),
            new(true, this),
        };
        for (int i = 0; i < 6; i++)
        {
            playerMonIcons[i] = Sprite.Create(
                Resources.Load<Texture2D>("Sprites/Pokemon/"
                + Species.SpeciesTable[(int)PlayerPokemon[i].species].graphicsLocation
                + "/icon"), new Rect(0.0F, 32.0F, 32.0F, 32.0F), new Vector2(0.5F, 0.5F),
                64);
            playerMonIcons2[i] = Sprite.Create(
                Resources.Load<Texture2D>("Sprites/Pokemon/"
                + Species.SpeciesTable[(int)PlayerPokemon[i].species].graphicsLocation
                + "/icon"), new Rect(0.0F, 0.0F, 32.0F, 32.0F), new Vector2(0.5F, 0.5F),
                64);
            PlayerPokemon[i].itemChanged = false;
            OpponentPokemon[i].itemChanged = false;
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
            if (wildBattle)
            {
                PokemonOnField[0] = new BattlePokemon(OpponentPokemon[0], false, 0, false, this);
                yield return Announce("A wild " + PokemonOnField[0].PokemonData.monName + " appeared!");
            }
            else
                yield return BringToField(OpponentPokemon[0], 0, 0, false);
            yield return BringToField(PlayerPokemon[firstMon], firstMon, 3, true);
            doAbilityEffect[0] = true;
            doAbilityEffect[3] = true;
            yield return DoEntryAbilitiesAtStartOfTurn();
        }
        StartCoroutine(StartTurn());
        yield break;
    }

    public IEnumerator BringToField(Pokemon pokemonData, int partyIndex, int index, bool player)
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
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index > 2, index % 3, false, this);
                    break;
                case true:
                    yield return Announce("Go! " + pokemonData.monName + "!");
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index > 2, index % 3, true, this);
                    break;
            }
            healthBarManager[index].SnapHealth(pokemonData.HP);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            audioSource0.panStereo = player ? -0.5F : 0.5F;
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            yield return MonEntersField(index);
        }
    }

    public IEnumerator DoEntryAbilitiesAtStartOfTurn()
    {
        Debug.Log("Entry abilities");
        while(true)
        {
            List<int> speedTieList = new();
            int speed = int.MinValue;
            for (int i = 0; i < 6; i++)
            {
                if (doAbilityEffect[i])
                {
                    if(GetSpeed(i) > speed)
                    {
                        Debug.Log("Replace " + i);
                        speedTieList = new() { i };
                    }
                    else if (GetSpeed(i) == speed)
                    {
                        Debug.Log("Add " + i);
                        speedTieList.Add(i);
                    }
                }
            }
            Debug.Log(speedTieList.Count);
            if (speedTieList.Count == 0) break;
            else if (speedTieList.Count == 1) yield return EntryAbilityCheck(speedTieList[0]);
            else yield return EntryAbilityCheck(speedTieList.GetRandom());
        }
    }

    public void HandleFacing(int index)
    {
        if (index < 3)
        {
            for (int i = 3; i < 6; i++)
            {
                if (PokemonOnField[i].exists)
                    playerFacedOpponent[PokemonOnField[i].partyIndex, PokemonOnField[index].partyIndex] = true;
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                if (PokemonOnField[i].exists)
                    playerFacedOpponent[PokemonOnField[index].partyIndex, PokemonOnField[i].partyIndex] = true;
            }
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
        Debug.Log(CanMegaEvolve(index));
        if (CanMegaEvolve(index)) megaEvolveOnMove[index] = true;
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
        if (index < 3)
        {
            Debug.Log("Has Opponent evolved: " + hasOpponentMegaEvolved);
            Debug.Log("Opponent's mega stone user: " + EffectiveItem(index).MegaStoneUser());
        }
        if (index > 2 && hasPlayerMegaEvolved) return false;
        if (index < 3 && hasOpponentMegaEvolved) return false;
        if (EffectiveItem(index).MegaStoneUser() == PokemonOnField[index].PokemonData.getSpecies) return true;
        //else if PokemonOnField[index].PokemonData.species == SpeciesID.Rayquaza
        //  && PokemonOnField[index].PokemonData.HasMove(MoveID.DragonAscent) return true;
        else return false;
    }

    public IEnumerator DoMegaEvolution(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        //Todo: Add mega animation
        StartCoroutine(BattleAnim.MegaEvolution(this, index)); //0.00 - 3.90
        yield return new WaitForSeconds(1.8F); //1.80
        megaEvolveOnMove[index] = false;
        if (index > 2) hasPlayerMegaEvolved = true;
        else hasOpponentMegaEvolved = true;
        mon.PokemonData.temporarySpecies =
            mon.PokemonData.species == SpeciesID.Rayquaza ?
            SpeciesID.RayquazaMega :
            (SpeciesID)EffectiveItem(index).Data().ItemSubdata[1];
        CleanStatSwaps(mon);
        mon.PokemonData.transformed = true;
        mon.PokemonData.CalculateStats();
        yield return new WaitForSeconds(1.8F); //3.60
        BattleAnim.Cry(mon.PokemonData.getSpecies, audioSource0);
        yield return new WaitForSeconds(1.0F); //4.60
        yield return Announce(MonNameWithPrefix(index, true) + " has Mega Evolved into "
            + mon.PokemonData.SpeciesData.speciesName + "!");
        mon.ability = mon.PokemonData.SpeciesData.abilities[0];
        yield return EntryAbilityCheck(index);
        megaEvolveOnMove[index] = false;
        DoNextMove();
    }

    public IEnumerator TryToRun()
    {
        state = BattleState.Announcement;
        int playerSpeed = PokemonOnField[3].PokemonData.speed;
        int opponentSpeed = PokemonOnField[0].PokemonData.speed;
        if (HasAbility(3, RunAway) ||
            playerSpeed > opponentSpeed ||
            (random.Next() & 255) < ((playerSpeed * 128 / opponentSpeed + 30 * escapeAttempts) & 255))
        {
            yield return Announce("Got away safely!");
            yield return EndBattle();
        }
        else
        {
            yield return Announce("Can't escape!");
            menuManager.CleanForTurnStart();
            PokemonOnField[3].done = true; PokemonOnField[4].done = true; PokemonOnField[5].done = true;
            DoNextMove();
        }
    }

    public IEnumerator EndBattle()
    {
        if (wildBattle)
            player.StartCoroutine(player.WildBattleWon());
        else
        {
            yield return Announce("Defeated " + OpponentName + "!");
            player.StartCoroutine(player.TrainerBattleWon());
        }
        yield break;
    }

    public void Start()
    {
        audioSource0 = gameObject.AddComponent<AudioSource>();
        audioSource1 = gameObject.AddComponent<AudioSource>();
    }
}