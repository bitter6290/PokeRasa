// Battle config

#define ALL_GET_FULL_EXP // Comment to use pre-gen 6 experience distribution
#define FRIENDSHIP_RAISES_EXP // Comment to get rid of the friendship boost to XP gain
#define LOW_LEVEL_CATCH_BONUS // This is an early-game boost in SwSh and SV,
//                               comment to get rid of it or change the formula
//                               to customize


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
using static Stat;
using static Weather;
using System.Linq;

public partial class Battle : MonoBehaviour
{
    private const int TurnOver = 63;
    private const int NoMons = 63;
    private const int HandleMega = 127;
    private const int NullInt = (1 << 30) - 1;
    private const int ReturnFalse = 63;

    private const int None = 0;

    private enum BallThrowOutcome
    {
        Shake0,
        Shake1,
        Shake2,
        Shake3,
        Capture,
        Critical
    }

    public enum BattleType
    {
        Single,
        Double,
        Multi,
        Triple,
    }

    public enum Protection
    {
        None,
        Protect,
        KingsShield,
        SpikyShield,
        BanefulBunker,
        MaxGuard
    }

    private enum GMaxContinuousDamage
    {
        None,
        VineLash,
        Wildfire,
        Cannonade
    }

    public Player player;

    public bool wildBattle;
    private int escapeAttempts;

    public Pokemon[] opponentPokemon = new Pokemon[6];
    public Pokemon[] playerPokemon = new Pokemon[6];
    private Pokemon[] Party(int index) => index < 3 ?
        opponentPokemon : playerPokemon;

    private int FaintedMons(int index)
    {
        int count = 0;
        foreach (Pokemon p in Party(index))
        {
            if (p.exists && p.fainted) count++;
        }
        return count;
    }

    private static readonly List<int> playerIndices = new() { 3, 4, 5 };
    private static readonly List<int> opponentIndices = new() { 0, 1, 2 };
    private static List<int> SameSideIndices(int index) =>
        index < 3 ? opponentIndices : playerIndices;
    private static List<int> OppositeSideIndices(int index) =>
        index < 3 ? playerIndices : opponentIndices;

    public BattleState state;
    public int currentPlayerMon = 4;

    public string opponentName = "Error 401";
    public int prizeMoney = 0;

    public TextMeshProUGUI announcer;

    public MaskManager[] maskManager;
    public MenuManager menuManager;
    public HealthBarManager[] healthBarManager;
    public XPController xpController;

    [SerializeField]
    private AbilityPopupController[] abilityControllers = new AbilityPopupController[6];

    public SpriteRenderer[] spriteRenderer;
    [SerializeField]
    private Transform[] spriteTransform;

    public AudioSource audioSource0;
    public AudioSource audioSource1;

    public bool[] megaEvolveOnMove = new bool[6];
    private bool hasPlayerMegaEvolved = false;
    private bool hasOpponentMegaEvolved = false;
    private int monToMega = 0;

    public bool[] usingZMove = new bool[6];
    private bool hasPlayerUsedZMove = false;
    private bool hasOpponentUsedZMove = false;

    public bool menuOpen = false;

    private readonly bool[] healingWish = new bool[6];

    private readonly bool[] zPowerHeal = new bool[6];

    public int textSpeed = 25;
    public float persistenceTime = 1.5F;

    public int switchingMon;
    public int switchingTarget;
    public bool choseSwitchMon;

    private Ability lastFaintedAbility;
    private int lastFaintedIndex;

    public BattlePokemon[] PokemonOnField;

    private int turnsElapsed;

    private bool pursuitHitsOnSwitch;

    private bool followMeActive;

    private List<string> announcementLog = new();

    private int singleMovePower; //used for Magnitude

    private bool continueMultiHitMove;

    public bool consumeItems = true;

    private bool doStatAnim = true;

    private MoveID lastMoveUsed = MoveID.None;

    private int currentMovingMon;

    private bool doRound = false;

    private bool moveCausedFainting = false;

    private bool didAnyoneProtect = false;

    private bool sheerForceBoosted = false;

    // Field varibles

    private bool payDay;
    private bool happyHour;

    private Weather weather;
    private int weatherTimer;
    private Terrain terrain;
    private int terrainTimer;

    public BattleTerrain battleTerrain;

    public bool gravity;
    private int gravityTimer;

    private bool wonderRoom;
    private int wonderRoomTimer;

    private bool magicRoom;
    private int magicRoomTimer;

    private bool trickRoom;
    private int trickRoomTimer;

    private bool mudSport;
    private int mudSportTimer;

    private bool waterSport;
    private int waterSportTimer;

    private bool snatch;
    private int snatchingMon;

    private bool echoedVoiceUsed;
    private int echoedVoiceIntensity;

    private bool ionDeluge;

    private bool fairyLockNext;
    private bool fairyLockNow;

    private bool[,] playerFacedOpponent = new bool[6, 6];

    private Queue<(int wishHP, int turn, int slot, string wisher)> wishes = new();
    private Queue<FutureSightStruct> futureSight = new();
    private bool[] isFutureSightTargeted = new bool[6];

    private Queue<(int source, int target, Ability ability)> abilityEffects = new();

    private bool[] doAbilityEffect = new bool[6];

    private bool oneAnnouncementDone; //Used for Perish Song

    private System.Random random = new();

    private int DoublesPartner(int index) => index switch
    {
        0 => 1,
        1 => 0,
        3 => 4,
        4 => 3,
        _ => throw new System.Exception("Passed bad argument to Battle.DobulesPartner")
    };


    private bool PlayerHasMonsInBack
    {
        get
        {
            for (int i = 0; i < 6; i++)
            {
                if (!playerPokemon[i].onField && !playerPokemon[i].fainted)
                {
                    return true;
                }
            }
            return false;
        }
    }

    private bool AlliesWillPledge(int index)
    {
        Pledge userPledge = PledgeFromMove(Moves[index]);
        foreach (int i in SameSideIndices(index))
        {
            if (i != index && !PokemonOnField[i].done &&
                PledgeFromMove(Moves[i]) is not Pledge.None
                && PledgeFromMove(Moves[i]) != userPledge)
            {
                return true;
            }
        }
        return false;
    }

    private bool OpponentLost
    {
        get
        {
            for (int i = 0; i < 6; i++)
                if (!opponentPokemon[i].fainted && opponentPokemon[i].exists) return false;
            return true;
        }
    }

    private Side[] Sides = new Side[2];

    public BattleType battleType;


    public MoveID[] Moves = new MoveID[6];
    public int[] SwitchTargets = new int[6];
    public int[] Targets = new int[6];
    public int[] MoveNums = new int[6];

    public ItemID[] itemToUse = new ItemID[6];
    public int[] itemTarget = new int[6];

    public Sprite[] playerMonIcons = new Sprite[6];
    public Sprite[] playerMonIcons2 = new Sprite[6];

    public string MonNameWithPrefix(int index, bool capitalized)
    {
        return wildBattle && index < 3
            ? (capitalized ? "The wild " : "the wild ")
                + PokemonOnField[index].pokemon.MonName
            : index < 3
                ? (capitalized ? "The foe's " : "the foe's ")
                            + PokemonOnField[index].pokemon.MonName
                : PokemonOnField[index].pokemon.MonName;
    }

    private bool OppositeGenders(int indexA, int indexB)
    {
        return PokemonOnField[indexA].pokemon.gender switch
        {
            Gender.Male => PokemonOnField[indexB].pokemon.gender == Gender.Female,
            Gender.Female => PokemonOnField[indexB].pokemon.gender == Gender.Male,
            _ => false
        };
    }

    public bool MoveImprisoned(MoveID move, int user)
    {
        int baseNum = user > 2 ? 0 : 3;
        for (int i = baseNum; i < baseNum + 3; i++)
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

    public bool HitsSubstitute(int attacker, int defender, MoveID move)
    {
        if (!PokemonOnField[defender].hasSubstitute) return false;
        if (move.Data().moveFlags.HasFlag(soundMove)) return false;
        if (HasAbility(attacker, Infiltrator)) return false;
        return true;
    }

    public bool CanStatus(int index, Status status, int attacker = NoMons, bool breakSub = false)
    {
        if (PokemonOnField[index].pokemon.status is not Status.None) return false;
        if (Sides[index < 3 ? 0 : 1].safeguard) return false;
        switch (EffectiveAbility(index))
        {
            case Comatose:
            case PurifyingSalt when !HasMoldBreaker(attacker):
                return false;
            case LeafGuard when IsSunAffected(index) && !HasMoldBreaker(attacker):
                return false;
            default: break;
        }
        if (PokemonOnField[index].HasType(Type.Grass) && AbilityOnSide(FlowerVeil, index < 3 ? 0 : 1))
        {
            if (attacker < 3 != index < 3 && attacker != NoMons)
                if (!HasMoldBreaker(attacker)) return false;
        }
        if (IsTerrainAffected(index, Terrain.Misty)) return false;
        if (PokemonOnField[index].hasSubstitute) return false;
        switch (status)
        {
            case Status.Poison or Status.ToxicPoison:
                if ((PokemonOnField[index].HasType(Type.Poison) || PokemonOnField[index].HasType(Type.Steel))
                    && (attacker is NoMons || !HasAbility(attacker, Corrosion)))
                    return false;
                if (HasAbility(index, Immunity) || AbilityOnSide(PastelVeil, index < 3 ? 0 : 1))
                {
                    if (attacker == NoMons) return false;
                    else if (!HasMoldBreaker(attacker)) return false;
                }
                return true;
            case Status.Paralysis:
                if (PokemonOnField[index].HasType(Type.Electric)) return false;
                if (HasAbility(index, Limber))
                {
                    if (attacker == NoMons) return false;
                    else if (!HasMoldBreaker(attacker)) return false;
                }
                return true;
            case Status.Burn:
                if (PokemonOnField[index].HasType(Type.Fire)) return false;
                if (EffectiveAbility(index) is WaterVeil or WaterBubble or ThermalExchange)
                {
                    if (attacker == NoMons) return false;
                    else if (!HasMoldBreaker(attacker)) return false;
                }
                return true;
            case Status.Sleep:
                if (UproarOnField && !HasAbility(index, Soundproof)) return false;
                if (IsTerrainAffected(index, Terrain.Electric)) return false;
                if (EffectiveAbility(index) is Insomnia or VitalSpirit ||
                    AbilityOnSide(SweetVeil, index < 3 ? 0 : 1))
                {
                    if (attacker == NoMons) return false;
                    else if (!HasMoldBreaker(attacker)) return false;
                }
                return true;
            case Status.Freeze:
                if (IsSunAffected(index)) return false;
                if (PokemonOnField[index].HasType(Type.Ice)) return false;
                if (EffectiveAbility(index) is MagmaArmor)
                {
                    if (attacker == NoMons) return false;
                    else if (!HasMoldBreaker(attacker)) return false;
                }
                return true;
            default:
                return false;
        }
    }

    private bool CanInfatuate(int attacker, int defender) =>
        OppositeGenders(attacker, defender) &&
        ((!HasAbility(defender, Oblivious) && !AbilityOnSide(AromaVeil, defender / 3))
            || HasMoldBreaker(attacker));

    private bool AllOthersDone(int index)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].done || i == index) continue;
            return false;
        }
        return true;
    }

    private int GetOppositeMon(int index) => index < 3 ? index + 3 : index - 3;

    private int[][] GetNeighbors = new int[][]
    {
        new[] { 1 },
        new[] { 0 , 2 },
        new[] { 1 },
        new[] { 4 },
        new[] { 3 , 5 },
        new[] { 4 }
    };

    private int[][] GetMonAndNeighbors = new int[][]
    {
        new[] {0, 1 },
        new[] {0,1,2 },
        new[] {1,2 },
        new[] {3,4 },
        new[] {3,4,5 },
        new[] {4,5 }
    };

    private int[] GetAdjacentOpponents(int index) => GetMonAndNeighbors[GetOppositeMon(index)];

    private bool SharesType(int a, int b)
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

    private MoveData GetMove(int index) => Moves[index].Data();

    private static int GetSide(int index) => index / 3;

    private float StabModifier(int index) => HasAbility(index, Adaptability) ? 2.0F : 1.5F;
    private float CritModifier(int index) => HasAbility(index, Sniper) ? 2.25F : 1.5F;

    private bool HasItem(int index, ItemID item)
        => !HasAbility(index, Klutz) && !magicRoom
            && PokemonOnField[index].pokemon.item == item;

    private ItemID EffectiveItem(int index)
        => PokemonOnField[index].ability == Klutz || magicRoom
        ? ItemID.None : PokemonOnField[index].Item;

    private Terrain EffectiveTerrain(int index)
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

    private List<int> PriorityForRedirection
    {
        get
        {
            List<(int index, int speed, int turnsWithAbility)> list = new();
            int added = 0;
            for (int i = 0; i < 6; i++)
            {
                if (EffectiveAbility(i) is not LightningRod or StormDrain) continue;
                if (PokemonOnField[i].exists)
                {
                    list.Add((i, GetSpeed(i), PokemonOnField[i].timeWithAbility));
                    added++;
                }
            }
            if (added == 0) return new List<int>();
            else if (added == 1) return new List<int>() { list[0].index };
            else return list.OrderBy(t => t.speed).ThenByDescending(t => t.turnsWithAbility).Select(t => t.index).ToList();
        }
    }

    private bool ItemIsChangeable(int index)
    {
        ItemID item = PokemonOnField[index].Item;
        if (item is None || (item.Data() is HoldToTransform &&
            PokemonOnField[index].pokemon.species == (item.Data() as HoldToTransform).transformedSpecies) ||
            HasAbility(index, StickyHold))
            return false;
        if (ItemUtils.CanBeStolen(item))
            return true;
        return false;
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

    private static int ReversalPower(int HP, int maxHP) => HP * 48 / maxHP switch
    {
        < 2 => 200,
        < 5 => 150,
        < 10 => 100,
        < 17 => 80,
        < 33 => 40,
        _ => 20,
    };

    public bool IsChoiced(int index) => HasAbility(index, GorillaTactics) ||
        EffectiveItem(index).HeldEffect() is HeldEffect.ChoiceItem;

    private int LowSpeedMovePower(int attacker, int defender)
    {
        int basePower = 25 * GetSpeed(defender) / GetSpeed(attacker) + 1;
        return Min(150, basePower);
    }

    private bool AbilityOnSide(Ability ability, int side)
    {
        for (int i = side * 3; i < (side * 3) + 3; i++)
            if (HasAbility(i, ability)) return true;
        return false;
    }

    private bool Unnerved(int index)
    {
        int baseNum = index < 3 ? 3 : 0;
        for (int i = baseNum; i < baseNum + 3; i++)
        {
            if (EffectiveAbility(i) is Unnerve or AsOneGlastrier or AsOneSpectrier) return true;
        }
        return false;
    }

    private bool AbilityOnField(Ability ability)
    {
        for (int i = 0; i < 6; i++)
            if (HasAbility(i, ability)) return true;
        return false;
    }

    private bool OtherMonHasAbility(int index, Ability ability)
    {
        for (int i = 0; i < 6; i++)
        {
            if (i == index) continue;
            if (HasAbility(i, ability)) return true;
        }
        return false;
    }

    private bool FlowerGiftOnSide(int side)
    {
        for (int i = side * 3; i < (side * 3) + 3; i++)
            if (HasAbility(i, FlowerGift) && IsSunAffected(i))
                return true;
        return false;
    }

    private bool UproarOnField =>
        PokemonOnField[0].uproar
        || PokemonOnField[1].uproar
        || PokemonOnField[2].uproar
        || PokemonOnField[3].uproar
        || PokemonOnField[4].uproar
        || PokemonOnField[5].uproar;

    private bool MakesContact(int attacker, MoveID move) =>
        !HasAbility(attacker, LongReach) && move.Data().moveFlags.HasFlag(makesContact);

    private bool IsWeatherAffected(int index, Weather weather)
    {
        if (this.weather != weather) return false;
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (EffectiveAbility(i) is CloudNine or AirLock)
            {
                result = false;
            }
        }
        if (weather is Sun or Rain &&
            EffectiveItem(index).HeldEffect() == HeldEffect.ProtectFromWeather)
            result = false;
        return result;
    }

    private bool IsSunAffected(int index)
    {
        if (weather is not Sun or ExtremeSun) return false;
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (EffectiveAbility(i) is CloudNine or AirLock)
            {
                result = false;
            }
        }
        if (EffectiveItem(index).HeldEffect() == HeldEffect.ProtectFromWeather)
            result = false;
        return result;
    }

    private bool IsRainAffected(int index)
    {
        if (weather is not Rain or HeavyRain) return false;
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (EffectiveAbility(i) is CloudNine or AirLock)
            {
                result = false;
            }
        }
        if (EffectiveItem(index).HeldEffect() == HeldEffect.ProtectFromWeather)
            result = false;
        return result;
    }

    private bool IsTerrainAffected(int index, Terrain terrain)
    {
        if (this.terrain != terrain) return false;
        return IsGrounded(index);
    }

    private float GetTypeEffectiveness(BattlePokemon attacker, BattlePokemon defender, MoveID move)
    {
        if (defender.AtFullHealth && HasAbility(defender.index, TeraShell) && !HasMoldBreaker(attacker.index)) return 0.5F;
        Type effectiveType1 = defender.Type1;
        Type effectiveType2 = defender.Type2;
        float effectiveness = (effectiveType1 == effectiveType2) ?
            RealEffectiveness(attacker.index, defender.index, effectiveType1, move)
            : RealEffectiveness(attacker.index, defender.index, effectiveType1, move)
            * RealEffectiveness(attacker.index, defender.index, effectiveType2, move);
        if (defender.hasType3)
            effectiveness *= RealEffectiveness(attacker.index, defender.index, defender.Type3, move);
        if (defender.IsMonotype(Type.Flying) && defender.roosting)
            return RealEffectiveness(attacker.index, defender.index, Type.Normal, move);
        if (defender.tarShot && move.Data().type is Type.Fire) effectiveness *= 2;
        return effectiveness;
    }

    private bool IsImmune(BattlePokemon attacker, BattlePokemon defender, MoveID move)
        => GetTypeEffectiveness(attacker, defender, move) == 0;

    private float RealEffectiveness(int attacker, int defender, Type defenderType, MoveID move)
    {
        Type moveType = GetEffectiveType(move, attacker);
        if (move.Data().effect is FlyingPress)
            return RealEffectiveness(attacker, defender, defenderType, moveType) *
                RealEffectiveness(attacker, defender, defenderType, Type.Flying);
        if (moveType == Type.Ground)
        {
            if (!IsGrounded(defender)) return move.Data().effect is ThousandArrows ?
                    1.0F : 0.0F;
            else if (IsGrounded(defender) && defenderType == Type.Flying) return 1.0F;
        }
        if (defenderType == Type.Flying && PokemonOnField[defender].roosting) return 1.0F;
        if (defenderType == Type.Ghost && moveType is Type.Normal or Type.Fighting &&
            ((PokemonOnField[defender].identified &&
                !PokemonOnField[defender].identifiedByMiracleEye) ||
            EffectiveAbility(attacker) is Scrappy or MindsEye)) return 1.0F;
        if (defenderType == Type.Dark && moveType == Type.Psychic &&
            PokemonOnField[defender].identified &&
            PokemonOnField[defender].identifiedByMiracleEye) return 1.0F;
        if (defenderType == Type.Water && move.Data().effect is FreezeDry) return 2.0F;
        return TypeUtils.Effectiveness(moveType, defenderType);
    }

    private float RealEffectiveness(int attacker, int defender, Type defenderType, Type moveType)
    {
        if (moveType == Type.Ground)
        {
            if (!IsGrounded(defender, attacker)) return 0.0F;
            else if (IsGrounded(defender, attacker) && defenderType == Type.Flying) return 1.0F;
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

    private bool IsGrounded(int index, int attacker = 63)
    {
        if (gravity ||
            PokemonOnField[index].smackDown ||
            PokemonOnField[index].ingrained) return true;
        if ((HasAbility(index, Levitate) && !HasMoldBreaker(attacker)) ||
            PokemonOnField[index].magnetRise ||
            PokemonOnField[index].telekinesis) return false;
        if (PokemonOnField[index].roosting) return true;
        if (PokemonOnField[index].HasType(Type.Flying)) return false;
        return true;
    }

    private bool MonSuppressesAbilities(int index) =>
        PokemonOnField[index].ability is NeutralizingGas && MonIsActive(index);

    private bool AbilitiesSuppressed =>
        MonSuppressesAbilities(0) ||
            MonSuppressesAbilities(1) ||
            MonSuppressesAbilities(2) ||
            MonSuppressesAbilities(3) ||
            MonSuppressesAbilities(4) ||
            MonSuppressesAbilities(5);

    private bool HasAbility(int index, Ability ability)
    {
        return ability.Unsuppressable()
            ? PokemonOnField[index].ability == ability
            : !PokemonOnField[index].abilitySuppressed
               && PokemonOnField[index].ability == ability
               && !AbilitiesSuppressed;
    }

    private Ability EffectiveAbility(int index) =>
        PokemonOnField[index].ability.Unsuppressable() ||
        !(AbilitiesSuppressed || PokemonOnField[index].abilitySuppressed) ?
            PokemonOnField[index].ability : None;

    private bool HasMoldBreaker(int index)
    {
        if (index is ReturnFalse) return false;
        if (currentMovingMon == index)
        {
            if (HasAbility(index, MyceliumMight) && GetMove(index).power == 0) return true;
            if (GetMove(index).effect is IgnoreAbility or PhotonGeyser or ZMoveIgnoreAbility
                or LightThatBurnsTheSky or ClangorousSoulblaze) return true;
        }
        return EffectiveAbility(index) is MoldBreaker or Teravolt or Turboblaze;
    }

    private bool IsPhysical(int attacker, int defender, int moveSlot)
    {
        switch (PokemonOnField[attacker].GetMove(moveSlot).Data().effect)
        {
            case PhotonGeyser or LightThatBurnsTheSky:
                return PokemonOnField[attacker].Attack > PokemonOnField[attacker].SpAtk;
            default:
                return PokemonOnField[attacker].GetMove(moveSlot).Data().physical;
        }
    }

    public Type GetEffectiveType(MoveID move, int index)
    {
        Type effectiveType = move.Data().type;
        switch (move.Data().effect)
        {
            case HiddenPower:
                effectiveType = PokemonOnField[index].pokemon.hiddenPowerType;
                break;
            case WeatherBall:
                effectiveType = weather switch
                {
                    Sun or ExtremeSun => IsSunAffected(index) ? Type.Fire : Type.Normal,
                    Rain or HeavyRain => IsRainAffected(index) ? Type.Water : Type.Normal,
                    Sand => Type.Rock,
                    Snow => Type.Ice,
                    _ => Type.Normal,
                };
                break;
            case RevelationDance:
                effectiveType = PokemonOnField[index].Type1;
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
            case MultiAttack:
                effectiveType = EffectiveItem(index) switch
                {
                    FightingMemory => Type.Fighting,
                    FlyingMemory => Type.Flying,
                    PoisonMemory => Type.Poison,
                    GroundMemory => Type.Ground,
                    RockMemory => Type.Rock,
                    BugMemory => Type.Bug,
                    GhostMemory => Type.Ghost,
                    SteelMemory => Type.Steel,
                    FireMemory => Type.Fire,
                    WaterMemory => Type.Water,
                    GrassMemory => Type.Grass,
                    ElectricMemory => Type.Electric,
                    PsychicMemory => Type.Psychic,
                    IceMemory => Type.Ice,
                    DragonMemory => Type.Dragon,
                    DarkMemory => Type.Dark,
                    FairyMemory => Type.Fairy,
                    _ => Type.Normal
                };
                break;
            case Judgement when EffectiveItem(index).Data().type is not
                    ItemType.ZCrystalGeneric or ItemType.ZCrystalSpecific or
                    ItemType.ZCrystalMoveSpecific:
                effectiveType = EffectiveItem(index).PlateType(); break;
            case TechnoBlast:
                effectiveType = EffectiveItem(index) switch
                {
                    ShockDrive => Type.Electric,
                    BurnDrive => Type.Fire,
                    ChillDrive => Type.Ice,
                    DouseDrive => Type.Water,
                    _ => Type.Normal
                }; break;
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
            case LiquidVoice when move.Data().moveFlags.HasFlag(soundMove):
                effectiveType = Type.Water;
                break;
            case Normalize:
                effectiveType = Type.Normal;
                break;

        }
        if (ionDeluge && effectiveType is Type.Normal)
            effectiveType = Type.Electric;
        if (PokemonOnField[index].electrify)
            effectiveType = Type.Electric;
        return effectiveType;
    }

    private float SupremeOverlordBoost(int index)
    {
        int numerator = 10;
        foreach (Pokemon mon in index < 3 ? opponentPokemon : playerPokemon)
        {
            if (mon.exists & mon.fainted) numerator++;
        }
        return numerator / 10.0F;
    }


    private int GetAttack(int index, bool crit, bool useItem = true, bool ignoreStage = false)
    {
        int attack = ignoreStage || (crit && PokemonOnField[index].attackStage < 0) ?
            PokemonOnField[index].BaseAttack : PokemonOnField[index].Attack;
        attack = (int)(attack * EffectiveAbility(index) switch
        {
            HugePower or PurePower => 2F,
            Hustle => 1.5F,
            GorillaTactics => 1.5F,
            Guts when PokemonOnField[index].pokemon.status is not Status.None => 1.5F,
            Defeatist when PokemonOnField[index].HealthProportion < 0.5F => 0.5F,
            SupremeOverlord => SupremeOverlordBoost(index),
            SlowStart when PokemonOnField[index].turnOnField < 5 => 0.5F,
            _ => 1F,
        });
        if (FlowerGiftOnSide(index / 3)) attack += attack >> 1;
        if (useItem && HasItem(index, ChoiceBand)) attack += attack >> 1;
        if (OtherMonHasAbility(index, VesselOfRuin)) attack = attack >> 1 + attack >> 2;
        if (PokemonOnField[index].protoQuarkStat is Attack && GetsProtoBoost(index)) { attack = (int)(attack * 1.3F); Debug.Log("Attack proto boost"); }
        return attack;
    }

    private int GetDefenseRaw(int index, bool crit, bool ignoreStage = false)
    {
        int defense = ignoreStage ||
            (crit && PokemonOnField[index].defenseStage > 0) ?
            PokemonOnField[index].BaseDefense : PokemonOnField[index].Defense;
        defense = (int)(defense * EffectiveAbility(index) switch
        {
            GrassPelt when EffectiveTerrain(index) == Terrain.Grassy => 1.5F,
            MarvelScale when PokemonOnField[index].pokemon.status is not Status.None => 1.5,
            _ => 1,
        });
        if (OtherMonHasAbility(index, SwordOfRuin)) defense = defense >> 1 + defense >> 2;
        if (PokemonOnField[index].protoQuarkStat is Defense && GetsProtoBoost(index)) defense = (int)(defense * 1.3F);
        return defense;
    }

    private int GetDefense(int index, bool crit, bool ignoreStage)
    {
        return wonderRoom ? GetSpDefRaw(index, crit, ignoreStage) :
            GetDefenseRaw(index, crit, ignoreStage);
    }

    private int GetSpAtk(int index, bool crit, bool useItem = true, bool ignoreStage = false)
    {
        int spAtk = ignoreStage || (crit && PokemonOnField[index].spAtkStage < 0) ?
            PokemonOnField[index].BaseSpAtk : PokemonOnField[index].SpAtk;
        spAtk = (int)(spAtk * EffectiveAbility(index) switch
        {
            Plus when AbilityOnSide(Minus, index / 3) => 1.5F,
            Minus when AbilityOnSide(Plus, index / 3) => 1.5F,
            Defeatist when PokemonOnField[index].HealthProportion < 0.5F => 0.5F,
            SupremeOverlord => SupremeOverlordBoost(index),
            _ => 1,
        });
        if (useItem && HasItem(index, ChoiceSpecs)) spAtk += spAtk >> 1;
        if (OtherMonHasAbility(index, TabletsOfRuin)) spAtk = spAtk >> 1 + spAtk >> 2;
        if (PokemonOnField[index].protoQuarkStat is SpAtk && GetsProtoBoost(index)) spAtk = (int)(spAtk * 1.3F);
        return spAtk;
    }

    private int GetSpDefRaw(int index, bool crit, bool ignoreStage = false)
    {
        int spDef = ignoreStage ||
            (crit && PokemonOnField[index].spDefStage < 0) ?
            PokemonOnField[index].BaseSpDef : PokemonOnField[index].SpDef;
        if (FlowerGiftOnSide(index / 3)) spDef += spDef >> 1;
        if (OtherMonHasAbility(index, BeadsOfRuin)) spDef = spDef >> 1 + spDef >> 2;
        if (PokemonOnField[index].protoQuarkStat is SpDef && GetsProtoBoost(index)) spDef = (int)(spDef * 1.3F);
        return spDef;
    }

    private int GetSpdef(int index, bool crit, bool ignoreStage = false)
    {
        return wonderRoom ? GetDefenseRaw(index, crit, ignoreStage) : GetSpDefRaw(index, crit, ignoreStage);
    }

    private int GetSpeed(int index, bool useItem = true, bool ignoreStage = false)
    {
        int speed = ignoreStage ? PokemonOnField[index].BaseSpeed : PokemonOnField[index].Speed;
        if (PokemonOnField[index].pokemon.status == Status.Paralysis && !HasAbility(index, QuickFeet))
        {
            speed >>= 1;
        }
        speed += EffectiveAbility(index) switch
        {
            SwiftSwim when IsRainAffected(index) => speed,
            Chlorophyll when IsSunAffected(index) => speed,
            SandRush when IsWeatherAffected(index, Sand) => speed,
            SlushRush when IsWeatherAffected(index, Snow) => speed,
            Unburden when PokemonOnField[index].unburdened => speed,
            SurgeSurfer when IsTerrainAffected(index, Terrain.Electric) => speed,
            QuickFeet when PokemonOnField[index].pokemon.status is not Status.None => speed >> 1,
            SlowStart when PokemonOnField[index].turnOnField < 5 => -speed >> 1,
            _ => 0,
        };
        if (PokemonOnField[index].protoQuarkStat is Speed && GetsProtoBoost(index)) speed += speed >> 1;
        if (useItem && HasItem(index, ChoiceScarf)) speed += speed >> 1;
        if (Sides[index / 3].tailwind) speed <<= 1;
        if (Sides[index / 3].swamp) speed >>= 2;
        if (trickRoom) speed = 10000 - speed;
        if (HasAbility(index, Stall)) speed -= 32768;
        if (HasAbility(index, MyceliumMight) && GetMove(index).power == 0) speed -= 32768;
        return speed;
    }

    private int GetPriority(int index)
    {
        int priority = GetMove(index).priority;
        if (PokemonOnField[index].goingNext) priority += 50;
        else if (PokemonOnField[index].quashed) priority -= 50;
        switch (EffectiveAbility(index))
        {
            case GaleWings when PokemonOnField[index].AtFullHealth &&
                    GetEffectiveType(Moves[index], index) == Type.Flying:
                priority++;
                break;
            case Prankster when GetMove(index).power == 0: priority++; break;
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
                    Debug.Log("Use item");
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
                else if (PokemonOnField[i].goingNext) return i;
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
        if (speedTieList.Count > 1)
        {
            if (currentMove == HandleMega) monToMega = speedTieList[random.Next() % speedTieList.Count];
            else currentMove = speedTieList[random.Next() % speedTieList.Count];
        }
        return currentMove;
    }

    private IEnumerator UseItem(int itemSlot, int itemTarget)
    {
        bool player = itemSlot > 2;
        ItemID item = itemToUse[itemSlot];
        yield return Announce((player ? "U" : opponentName + " u") +
            "sed " + item.Data().itemName + "!");
        Pokemon target = player ? playerPokemon[itemTarget] : opponentPokemon[itemTarget];
        int targetBP = NoMons;
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].pokemon == target)
            {
                targetBP = i;
                break;
            }
        }
        switch (item.Data().type)
        {
            case ItemType.PokeBall:
                yield return UseBall(item);
                break;
            case ItemType.Medicine:
                switch (item.BattleEffect())
                {
                    case BattleEffect.Heal:
                        if (targetBP is not NoMons)
                        {
                            int startHP = target.hp;
                            yield return Heal(targetBP, item.BattleEffectIntensity());
                            yield return Announce(target.MonName + " was healed by " + (target.hp - startHP) + " points.");
                        }
                        else
                        {
                            int amountHealed = Min(target.hpMax - target.hp, item.BattleEffectIntensity());
                            target.hp += amountHealed;
                            yield return Announce(target.MonName + " was healed by " + amountHealed + " points.");
                        }
                        break;
                }
                break;
            default:
                break;
        }
        yield break;
    }

    private IEnumerator CatchFail(GameObject ballObject, int targetMon)
    {
        //Todo: breaking out anim
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/CatchFail"));
        Destroy(ballObject);
        PokemonOnField[targetMon].exists = true;
        yield return new WaitForSeconds(0.5f);
        audioSource0.PlayOneShot(PokemonOnField[0].pokemon.SpeciesData.Cry);
        //Todo: entry anim
        yield return new WaitForSeconds(1.0f);
    }

    private IEnumerator UseBall(ItemID ball)
    {
        const int noTarget = 63;
        const int tooManyTargets = 64;

        IEnumerator CheckBallFetch()
        {
            if (HasAbility(3, BallFetch))
            {
                yield return PopupAnnounce(3, MonNameWithPrefix(3, true) + " caught the ball and brought it back!");
                player.AddItem(ball);
            }
        }

        player.UseItem(ball);
        if (!wildBattle)
        {
            //Todo: block anim
            yield return Announce(opponentName + " blocked the ball!");
            yield return Announce("Don't be a thief!");
            yield break;
        }
        int targetMon = noTarget;
        for (int i = 0; i < 3; i++)
        {
            if (PokemonOnField[i].exists)
            {
                if (targetMon == noTarget) targetMon = i;
                else targetMon = tooManyTargets;
            }
        }
        if (targetMon == tooManyTargets)
        {
            //Todo: miss anim
            yield return Announce("You missed the Pokémon!");
            yield return Announce("There are too many targets to aim properly...");
            yield break;
        }
        //Todo: ball throw anim
        PokemonOnField[targetMon].exists = false;
        GameObject ballObject = new("Ball");
        ballObject.transform.parent = spriteTransform[targetMon];
        ballObject.transform.localPosition = new(0, -0.3f);
        ballObject.transform.localScale = StaticValues.defPivot;
        SpriteRenderer renderer = ballObject.AddComponent<SpriteRenderer>();
        renderer.sprite = Resources.Load<Sprite>("Sprites/Battle/baton_pass_ball");
        yield return new WaitForSeconds(1.0f);
        switch (TryToCatch(PokemonOnField[targetMon], PokemonOnField[3], ball.BallCatchType()))
        {
            case BallThrowOutcome.Shake0:
                yield return CatchFail(ballObject, targetMon);
                yield return Announce("Oh no! The Pokémon broke free!");
                yield return CheckBallFetch();
                break;
            case BallThrowOutcome.Shake1:
                yield return BallShake(ballObject.transform);
                yield return CatchFail(ballObject, targetMon);
                yield return Announce("Aww! It appeared to be caught!");
                yield return CheckBallFetch();
                break;
            case BallThrowOutcome.Shake2:
                yield return BallShake(ballObject.transform);
                yield return BallShake(ballObject.transform);
                yield return CatchFail(ballObject, targetMon);
                yield return Announce("Aargh! Almost had it!");
                yield return CheckBallFetch();
                break;
            case BallThrowOutcome.Shake3:
                yield return BallShake(ballObject.transform);
                yield return BallShake(ballObject.transform);
                yield return BallShake(ballObject.transform);
                yield return CatchFail(ballObject, targetMon);
                yield return Announce("Shoot! It was so close, too!");
                yield return CheckBallFetch();
                break;
            case BallThrowOutcome.Capture:
                yield return BallShake(ballObject.transform);
                yield return BallShake(ballObject.transform);
                yield return BallShake(ballObject.transform);
                yield return BallCatch(ballObject.transform, renderer);
                yield return Announce(PokemonOnField[targetMon].pokemon.SpeciesData.speciesName + " was caught!");
                //Todo: name mon
                player.CatchMon(PokemonOnField[targetMon].pokemon);
                yield return EndBattle();
                yield break;
        }
    }

    private float GetAccuracy(MoveID move, int attacker, int defender)
    {
        if (HasAbility(defender, WonderSkin) && move.Data().power == 0 &&
            move.Data().accuracy > 50) return 0.5F;
        if (move.Data().effect == OHKO)
        {
            int levelDifference = PokemonOnField[attacker].pokemon.level
                - PokemonOnField[defender].pokemon.level;
            if (levelDifference < 0) return 0;
            if (move == MoveID.SheerCold && !PokemonOnField[attacker].HasType(Type.Ice))
                return (20 + levelDifference) / 100.0F;
            else return (30 + levelDifference) / 100.0F;
        }
        float result = move.Data().accuracy
            * BattlePokemon.StageToModifierAccEva(PokemonOnField[attacker].accuracyStage)
            / (move.Data().effect == IgnoreDefenseStage ||
                EffectiveAbility(attacker) is MindsEye or KeenEye or Illuminate
                ? 1.0F :
                BattlePokemon.StageToModifierAccEva(PokemonOnField[defender].evasionStage))
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
        return EffectiveAbility(index) switch
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
            SandVeil when IsWeatherAffected(defender, Sand) && !HasMoldBreaker(attacker) => 0.8F,
            SnowCloak when IsWeatherAffected(defender, Snow) && !HasMoldBreaker(attacker) => 0.8F,
            TangledFeet when PokemonOnField[defender].confused => 0.5F,
            _ => 1.0F,
        };
    }

    private float GetCritChance(int attacker, MoveID move)
    {
        int stage = PokemonOnField[attacker].critStage;
        if (move.Data().moveFlags.HasFlag(highCrit)) stage++;
        if (HasAbility(attacker, SuperLuck)) stage++;
        return stage switch
        {
            0 => 1.0F / 24.0F,
            1 => 0.125F,
            2 => 0.5F,
            _ => 1.0F,
        };
    }

    private int DamageCalc(BattlePokemon attacker, BattlePokemon defender, MoveID move,
        bool isMultiTarget, bool isCritical, int side, int powerOverride = NullInt)
    {
        int roll = 100 - (random.Next() & 15);
        int effectivePower = powerOverride == NullInt ? move.Data().power : powerOverride;
        bool flipPhysicalSpecial = move.Data().effect is PhotonGeyser or LightThatBurnsTheSky
            & attacker.Attack > attacker.SpAtk;
        if (powerOverride != NullInt) Debug.Log(effectivePower);
        Type effectiveType = GetEffectiveType(move, attacker.index);
        if (move.Data().moveFlags.HasFlag(halfPowerInBadWeather)
            && (IsRainAffected(attacker.index)
            || IsWeatherAffected(attacker.index, Sand)
            || IsWeatherAffected(attacker.index, HeavyRain)))
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
            case EchoedVoice:
                effectivePower *= echoedVoiceIntensity + 1;
                break;
            case HighSpeedPower:
                effectivePower = GetHighSpeedMovePower(attacker.index, defender.index);
                break;
            case HealthPower:
                effectivePower = (int)(move.Data().power
                    * (float)attacker.pokemon.hp / attacker.pokemon.hpMax);
                break;
            case Return:
                effectivePower = (attacker.pokemon.friendship / 5) << 1;
                break;
            case Frustration:
                effectivePower = ((255 - attacker.pokemon.friendship) / 5) << 1;
                break;
            case Rollout:
                effectivePower <<= attacker.rolloutIntensity + (attacker.usedDefenseCurl ? 1 : 0);
                break;
            case FuryCutter:
                effectivePower <<= attacker.furyCutterIntensity;
                break;
            case HiddenPower:
                effectiveType = attacker.pokemon.hiddenPowerType;
                break;
            case Reversal:
                effectivePower = ReversalPower(attacker.pokemon.hp, attacker.pokemon.hpMax);
                break;
            case TargetHealthPower:
                effectivePower = 1 + (int)(move.Data().power * defender.HealthProportion);
                break;
            case TargetStatPower:
                effectivePower = 60 + Min(20 * defender.SumOfStages, 140);
                break;
            case UserStatPower:
                effectivePower *= 1 + attacker.SumOfStages;
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
            case ZMove:
                effectivePower = attacker.zMoveBase.Data().zMovePower;
                break;
            case Payback when defender.done && Moves[defender.index] != MoveID.Switch:
            case Assurance when defender.damagedThisTurn:
            case Facade when attacker.pokemon.status != Status.None:
            case Revenge when attacker.damagedByMon[defender.index]:
            case StompingTantrum when attacker.moveFailedLastTurn:
            case SmellingSalts
                when defender.pokemon.status == Status.Paralysis && !defender.hasSubstitute:
            case WakeUpSlap
                when (defender.pokemon.status == Status.Sleep || HasAbility(defender.index, Comatose)) && !defender.hasSubstitute:
            case WeatherBall when this.weather is not (None or StrongWinds):
            case Brine when defender.pokemon.hp << 1 < defender.pokemon.hpMax:
            case Pursuit when pursuitHitsOnSwitch:
            case BoltBeak when defender.done:
            case Venoshock when defender.pokemon.status is Status.Poison or Status.ToxicPoison:
            case Hex when defender.pokemon.status is not Status.None || HasAbility(defender.index, Comatose):
            case MoveEffect.Round when doRound:
            case Acrobatics when attacker.Item is None:
            case DynamaxCannon when defender.dynamaxed:
            case Retaliate when Sides[attacker.Side ? 1 : 0].retaliateNow
                    || Sides[attacker.Side ? 1 : 0].retaliateNext:
            case FusionBolt when lastMoveUsed.Data().effect == FusionFlare:
            case FusionFlare when lastMoveUsed.Data().effect == FusionBolt:
                effectivePower <<= 1;
                break;
            case KnockOff when ItemIsChangeable(defender.index):
                effectivePower += effectivePower >> 1;
                break;
            case NaturalGift:
                effectivePower = EffectiveItem(attacker.index) switch
                {
                    > MarangaBerry or < CheriBerry => 0,
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
        if (move is MoveID.Bulldoze or MoveID.Earthquake or MoveID.Magnitude &&
            IsTerrainAffected(defender.index, Terrain.Grassy)) effectivePower >>= 1;
        effectivePower = Max(1, effectivePower);
        float critical = isCritical ? CritModifier(attacker.index) : 1.0F;
        float stab = attacker.HasType(effectiveType) ? StabModifier(attacker.index) : 1.0F;
        if (move is MoveID.RainbowPledge or MoveID.SwampPledge or MoveID.BurningFieldPledge)
            stab = StabModifier(attacker.index);
        float multitarget = isMultiTarget ? 0.75F : 1.0F;
        float helpingHand = Mathf.Pow(1.5f, attacker.helpingHand);
        float effectiveAttack = (move.Data().physical ^ flipPhysicalSpecial) ?
            GetAttack(attacker.index, isCritical) : GetSpAtk(attacker.index, isCritical);
        if (move.Data().effect == FoulPlay) effectiveAttack = GetAttack(defender.index, isCritical);
        float effectiveDefense = ((move.Data().physical || move.Data().effect == Psyshock)
            ^ flipPhysicalSpecial) ?
            GetDefense(defender.index, isCritical, move.Data().effect == IgnoreDefenseStage) :
            GetSpdef(defender.index, isCritical);
        float attackOverDefense = effectiveAttack / effectiveDefense;
        float burn = move.Data().physical && attacker.pokemon.status == Status.Burn
                && !HasAbility(attacker.index, Guts)
                ? 0.5F : 1.0F;
        float screen = (Sides[side].auroraVeil
            || (move.Data().physical
            ? Sides[side].reflect
                : Sides[side].lightScreen))
            ? 0.5F : 1.0F;
        if (move.Data().effect == MoveEffect.BreakScreens) screen = 1.0F;
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && move.Data().moveFlags.HasFlag(hitDiggingMon))
            || (defender.invulnerability == Invulnerability.Fly
            && move.Data().moveFlags.HasFlag(hitFlyingMon))
            ? 2.0F : 1.0F;
        float weather = effectiveType switch
        {
            Type.Fire when IsSunAffected(defender.index) => 1.5F,
            Type.Fire when IsRainAffected(defender.index) => 0.5F,
            Type.Water when IsRainAffected(defender.index) => 1.5F,
            Type.Water when IsSunAffected(defender.index) => 0.5F,
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
            && !HasMoldBreaker(attacker.index)
            || HasAbility(defender.index, PrismArmor)))
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

        int result = (int)Floor(((((2.0F * attacker.pokemon.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier * helpingHand * weather
            * stab * multitarget * critical * burn * screen * sport
            * (defender.protected75 ? 0.25F : 1.0F)
            * AttackerAbilityModifier(attacker, defender, move, GetEffectiveType(move, attacker.index))
            * DefenderAbilityModifier(defender, GetEffectiveType(move, attacker.index), move, attacker.index)
            * GetAttackerPartnerAbilityModifiers(attacker.index)
            * GetDefenderPartnerAbilityModifiers(defender.index, attacker.index)
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

    private float EffectivenessForAnticipation(Type type, int attacker, int defender, Type defenderType)
    {
        if (HasAbility(attacker, Normalize)) type = Type.Normal;
        if (type == Type.Ground)
        {
            if (!IsGrounded(defender)) return 0.0F;
            else if (IsGrounded(defender) && defenderType == Type.Flying) return 1.0F;
        }
        if (defenderType == Type.Ghost && type is Type.Normal or Type.Fighting
            && (PokemonOnField[defender].identified || HasAbility(attacker, Scrappy))) return 1.0F;
        return TypeUtils.Effectiveness(type, defenderType);
    }

    private float GetEffectivenessWithoutAttacker(Type type, BattlePokemon defender)
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

    private float GetEffectivenessForAnticipation(Type type, int attacker, int defender)
    {
        Type type1 = PokemonOnField[defender].Type1;
        Type type2 = PokemonOnField[defender].Type2;
        float effectiveness = (type1 == type2) ?
            EffectivenessForAnticipation(type, attacker, defender, type1)
            : EffectivenessForAnticipation(type, attacker, defender, type1)
            * EffectivenessForAnticipation(type, attacker, defender, type2);
        if (PokemonOnField[defender].hasType3)
            effectiveness *= EffectivenessForAnticipation(type, attacker, defender, PokemonOnField[defender].Type3);
        return effectiveness;
    }

    private int FutureSightDamageCalc(FutureSightStruct data)
    {
        BattlePokemon defender = PokemonOnField[data.target];
        int effectiveSpAtk = (int)Floor(data.spAtk *
            (data.critical && data.spAtkStage < 0
            ? 1 : (2 + data.spAtkStage) / 2.0F));
        float attackOverDefense = effectiveSpAtk /
            (data.critical && defender.spDefStage > 0
            ? defender.pokemon.spDef : defender.SpDef);
        float critical = data.critical ?
            data.user.onField
            && HasAbility(data.user.lastIndex, Sniper)
            ? 2.25F : 1.5F : 1.0F;
        float screen = (Sides[defender.Side ? 1 : 0].lightScreen
            || Sides[defender.Side ? 1 : 0].auroraVeil) ? 0.5F : 1.0F;
        int effectivePower = 120;
        float effectiveTypeModifier = GetEffectivenessWithoutAttacker(data.type, defender);
        int roll = 100 - (random.Next() & 15);
        float sport = data.type switch
        {
            Type.Electric when mudSport => 1.0F / 3.0F,
            Type.Fire when waterSport => 1.0F / 3.0F,
            _ => 1.0F,
        };
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && data.move.Data().moveFlags.HasFlag(hitDiggingMon))
            || (defender.invulnerability == Invulnerability.Fly
            && data.move.Data().moveFlags.HasFlag(hitFlyingMon))
            ? 2.0F : 1.0F;
        return (int)Floor(((((2.0F * data.level / 5) + 2)
            * effectivePower * attackOverDefense / 50) + 2)
            * effectiveTypeModifier * sport
            * (data.stab ? 1.5 : 1.0) * critical * screen
            * DefenderAbilityModifier(defender, data.type, data.move,
                data.user.onField ? data.user.lastIndex : ReturnFalse)
            * (data.user.onField
                ? AttackerAbilityModifier(PokemonOnField[data.user.lastIndex],
                defender, data.move, GetEffectiveType(data.move, data.user.lastIndex)) : 1.0F)
            * GetDefenderPartnerAbilityModifiers(defender.index, data.move, data.type)
            * (data.user.onField ? GetAttackerPartnerAbilityModifiers(data.user.lastIndex) : 1.0F)
            * invulnerabiltyBonus * roll / 100);
    }

    private float AttackerAbilityModifier(BattlePokemon attacker, BattlePokemon defender, MoveID move, Type effectiveType)
    {
        return EffectiveAbility(attacker.index) switch
        {
            FlashFire when attacker.flashFire && move.Data().type == Type.Fire
                => 1.5F,
            Overgrow when effectiveType is Type.Grass
                    && attacker.pokemon.hp * 3 <= attacker.pokemon.hpMax
                    => 1.5F,
            Blaze when effectiveType is Type.Fire
                    && attacker.pokemon.hp * 3 <= attacker.pokemon.hpMax
                    => 1.5F,
            Torrent when effectiveType is Type.Water
                    && attacker.pokemon.hp * 3 <= attacker.pokemon.hpMax
                    => 1.5F,
            Swarm when effectiveType is Type.Bug
                    && attacker.pokemon.hp * 3 <= attacker.pokemon.hpMax
                    => 1.5F,
            RockyPayload when effectiveType is Type.Rock => 1.5F,
            Neuroforce when GetTypeEffectiveness(attacker, defender, move) > 1 => 1.25F,
            Steelworker or SteelySpirit when effectiveType is Type.Steel => 1.5F,
            SolarPower when IsSunAffected(attacker.index) => 1.5F,
            WaterBubble when effectiveType is Type.Water => 2.0F,
            Transistor when effectiveType is Type.Electric => 1.3F, //Gen 9 nerf
            DragonsMaw when effectiveType is Type.Dragon => 1.5F, //Not nerfed
            ToxicBoost when move.Data().physical && attacker.pokemon.status is
                Status.Poison or Status.ToxicPoison => 1.5F,
            FlareBoost when !move.Data().physical && attacker.pokemon.status is
                Status.Burn => 1.5F,
            IronFist when move.Data().moveFlags.HasFlag(punchMove) => 1.2F,
            Sharpness when move.Data().moveFlags.HasFlag(sharpnessBoosted) => 1.5F,
            MegaLauncher when move.Data().moveFlags.HasFlag(megaLauncherBoosted) => 1.5F,
            StrongJaw when move is MoveID.Bite or MoveID.Crunch or MoveID.FireFang
            or MoveID.HyperFang or MoveID.IceFang or MoveID.PoisonFang or MoveID.ThunderFang
            or MoveID.PsychicFangs
            // or MoveID.FishiousRend or MoveID.JawLock
            => 1.5F,
            ToughClaws when MakesContact(attacker.index, move) => 1.3F,
            Reckless when move.Data().effect.HasRecoil() => 1.2F,
            Analytic when AllOthersDone(attacker.index) => 1.3F,
            SandForce when IsWeatherAffected(attacker.index, Sand) &&
                (GetEffectiveType(move, attacker.index)
                is Type.Steel or Type.Rock or Type.Ground) => 1.3F,
            PunkRock when move.Data().moveFlags.HasFlag(soundMove) => 1.3F,
            SupremeOverlord => 1.0F + 0.1F * FaintedMons(attacker.index),
            Rivalry when OppositeGenders(attacker.index, defender.index) => 1.25F,
            Rivalry when attacker.pokemon.gender == defender.pokemon.gender
                && attacker.pokemon.gender is not Gender.Genderless => 0.75F,
            Stakeout when defender.turnOnField is 0 => 2.0F,
            SheerForce when sheerForceBoosted => 1.3F,
            _ => 1.0F,
        };
    }

    private float DefenderAbilityModifier(BattlePokemon defender, Type effectiveType, MoveID move, int attacker)
    {
        Ability defAbility = EffectiveAbility(defender.index);
        return EffectiveAbility(defender.index) switch
        {
            Multiscale when defender.AtFullHealth && !HasMoldBreaker(attacker) => 0.5F,
            ShadowShield when defender.AtFullHealth => 0.5F,
            ThickFat when effectiveType is Type.Fire or Type.Ice && !HasMoldBreaker(attacker) => 0.5F,
            Heatproof when effectiveType == Type.Fire && !HasMoldBreaker(attacker) => 0.5F,
            FurCoat when move.Data().physical && !HasMoldBreaker(attacker) => 0.5F,
            IceScales when !move.Data().physical && !HasMoldBreaker(attacker) => 0.5F,
            PunkRock when move.Data().moveFlags.HasFlag(soundMove) && !HasMoldBreaker(attacker) => 0.5F,
            Fluffy when !HasMoldBreaker(attacker) => (move.Data().physical ? 0.5F : 1.0F) *
                    (effectiveType == Type.Fire ? 2.0F : 1.0F),
            DrySkin when effectiveType == Type.Fire && !HasMoldBreaker(attacker) => 1.25F,
            PurifyingSalt when effectiveType == Type.Ghost && !HasMoldBreaker(attacker) => 0.5F,
            WaterBubble when effectiveType == Type.Fire && !HasMoldBreaker(attacker) => 0.5F,
            _ => 1.0F,
        };
    }

    private float GetAttackerPartnerAbilityModifiers(int attacker)
    {
        float modifier = 1.0F;
        for (int i = attacker < 3 ? 0 : 3; i < (attacker < 3 ? 3 : 6); i++)
        {
            if (i == attacker) continue;
            if (MonIsActive(i))
            {
                modifier *= AttackerPartnerAbilityModifier(i, GetEffectiveType(Moves[attacker], attacker), Moves[attacker]);
            }
        }
        return modifier;
    }

    private float AttackerPartnerAbilityModifier(int partner, Type effectiveType, MoveID move)
    {
        return EffectiveAbility(partner) switch
        {
            SteelySpirit when effectiveType is Type.Steel => 1.5F,
            Battery when !move.Data().physical => 1.3F,
            PowerSpot => 1.3F,
            _ => 1.0F
        };
    }

    private float GetDefenderPartnerAbilityModifiers(int defender, int attacker)
    {
        float modifier = 1.0F;
        for (int i = defender < 3 ? 0 : 3; i < (defender < 3 ? 3 : 6); i++)
        {
            if (i == defender) continue;
            if (PokemonOnField[i].exists && !PokemonOnField[i].pokemon.fainted)
            {
                modifier *= DefenderPartnerAbilityModifier(i, GetEffectiveType(Moves[attacker], attacker), Moves[attacker]);
            }
        }
        return modifier;
    }

    private float GetDefenderPartnerAbilityModifiers(int defender, MoveID move, Type type)
    {
        float modifier = 1.0F;
        for (int i = defender < 3 ? 0 : 3; i < (defender < 3 ? 3 : 6); i++)
        {
            if (i == defender) continue;
            if (PokemonOnField[i].exists && !PokemonOnField[i].pokemon.fainted)
            {
                modifier *= DefenderPartnerAbilityModifier(i, type, move);
            }
        }
        return modifier;
    }

    private float DefenderPartnerAbilityModifier(int partner, Type effectiveType, MoveID move)
    {
        return EffectiveAbility(partner) switch
        {
            FriendGuard => 0.75F,
            _ => 1.0F
        };
    }

    private bool GetTargets(int attacker, MoveID move) //returns whether move is multi-target
    {
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
                    Debug.Log("3 is a target");
                }
                else if (attacker == 3)
                {
                    PokemonOnField[0].isTarget = true;
                    PokemonOnField[0].lastTargetedMove = move;
                    Debug.Log("0 is a target");
                }
            }
            return false;
        }
        else if (battleType == BattleType.Double)
        {
            if ((targetData & Target.Spread) == 0)
            {
                if (EffectiveAbility(attacker) is not Stalwart or PropellorTail &&
                    move.Data().effect is not SnipeShot)
                    CheckForRedirection(attacker);
                PokemonOnField[Targets[attacker]].isTarget = true;
                targets = 1;
            }
            else
            {
                if ((targetData & Target.Ally) != 0)
                {
                    for (int i = attacker / 3 * 3; i < attacker / 3 * 3 + 3; i++)
                    {
                        if (PokemonOnField[i].exists &&
                            (i != attacker || (targetData & Target.Self) != 0))
                        {
                            PokemonOnField[i].isTarget = true;
                            targets++;
                        }
                    }
                }
                if ((targetData & Target.Opponent) != 0)
                {
                    for (int i = (1 - attacker / 3) * 3; i < (1 - attacker / 3) * 3 + 3; i++)
                    {
                        if (PokemonOnField[i].exists &&
                            (i != attacker || (targetData & Target.Self) != 0))
                        {
                            PokemonOnField[i].isTarget = true;
                            targets++;
                        }
                    }
                }
            }
        }
        return targets > 1;
    }

    private bool TryToHit(int attacker, int defender, MoveID move)
    {
        if ((PokemonOnField[defender].protection != Protection.None ||
            (Sides[GetSide(defender)].wideGuard && (move.Data().targets & Target.Spread) != 0) ||
            (Sides[GetSide(defender)].quickGuard && GetPriority(attacker) > 0) ||
            (Sides[GetSide(defender)].matBlock && move.Data().power > 0 &&
            attacker != defender) ||
            (Sides[GetSide(defender)].craftyShield && move.Data().power == 0)) &&
            move.Data().effect is not Feint or HyperspaceFury &&
            !(HasAbility(attacker, UnseenFist) && move.Data().moveFlags.HasFlag(makesContact)
                && PokemonOnField[defender].protection is not Protection.MaxGuard))
        {
            if (move.Data().effect is ZMove or GuardianOfAlola or GenesisSupernova or
                SplinteredStormshards or ZMoveIgnoreAbility or LightThatBurnsTheSky)
            {
                PokemonOnField[defender].isHit = true;
                PokemonOnField[defender].protected75 = true;
            }
            else
                PokemonOnField[defender].wasProtected = true;
            return false;
        }
        switch (PokemonOnField[defender].invulnerability)
        {
            case Invulnerability.Fly when !move.Data().moveFlags.HasFlag(hitFlyingMon):
                PokemonOnField[defender].isMissed = true;
                return false;
            case Invulnerability.Dig when !move.Data().moveFlags.HasFlag(hitDiggingMon):
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
        if (Moves[attacker] is MoveID.Toxic && PokemonOnField[attacker].HasType(Type.Poison))
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (move.Data().moveFlags.HasFlag(alwaysHitsInRain) && IsRainAffected(defender))
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (move.Data().moveFlags.HasFlag(alwaysHitsMinimized)
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
            if (!MonIsActive(i)) continue;
            BattlePokemon target = PokemonOnField[i];
            if (target.isTarget)
            {
                if (!HasMoldBreaker(attacker))
                {
                    Ability ability = EffectiveAbility(i);
                    switch (ability)
                    {
                        case VoltAbsorb or LightningRod or MotorDrive when
                            GetEffectiveType(move, attacker) == Type.Electric:
                        case WaterAbsorb or StormDrain when
                            GetEffectiveType(move, attacker) == Type.Water:
                        case SapSipper when
                            GetEffectiveType(move, attacker) == Type.Grass:
                        case EarthEater when
                            GetEffectiveType(move, attacker) == Type.Ground:
                        case GoodAsGold when GetMove(attacker).power == 0:
                        case FlashFire or WellBakedBody when GetEffectiveType(move, attacker) == Type.Fire:
                        case WonderGuard when
                            GetTypeEffectiveness(PokemonOnField[attacker], target, move) <= 1:
                        case Soundproof when move.Data().moveFlags.HasFlag(soundMove):
                        case Bulletproof when move.Data().moveFlags.HasFlag(bulletMove):
                        case Overcoat when move.Data().moveFlags.HasFlag(powderMove):
                        case WindRider when move.Data().moveFlags.HasFlag(windMove):
                        case Telepathy when GetMove(attacker).power > 0 && attacker / 3 == i / 3:
                        case Dazzling or QueenlyMajesty when GetPriority(attacker) > 0:
                        case Disguise when PokemonOnField[i].ApparentSpecies is SpeciesID.MimikyuBase:
                        case Sturdy when move.Data().effect is OHKO:
                            abilityEffects.Enqueue((i, i, ability));
                            continue;
                        case Limber or PurifyingSalt when move.Data().effect is Paralyze:
                        case WaterVeil or PurifyingSalt when move.Data().effect is Burn:
                        case PastelVeil or PurifyingSalt when move.Data().effect is Poison or Toxic:
                        case Insomnia or VitalSpirit or SweetVeil or PurifyingSalt when move.Data().effect is Sleep:
                        case OwnTempo when move.Data().effect is MoveEffect.Confuse:
                            if (move.Data().power == 0)
                            {
                                abilityEffects.Enqueue((i, i, ability));
                                continue;
                            }
                            else break;
                        default:
                            break;
                    }
                    if (move.Data().effect is Taunt or Torment or Encore or MoveEffect.Disable or HealBlock)
                    {
                        int aromaVeilUser = NoMons;
                        for (int j = i / 3; j < i / 3 + 3; j++)
                        {
                            if (HasAbility(j, AromaVeil))
                            {
                                aromaVeilUser = j;
                                break;
                            }
                        }
                        if (aromaVeilUser != NoMons)
                        {
                            abilityEffects.Enqueue((aromaVeilUser, i, AromaVeil));
                            continue;
                        }
                    }
                };
                switch (move.Data().effect)
                {
                    case DreamEater when target.pokemon.status != Status.Sleep && !HasAbility(i, Comatose):
                    case Endeavor when
                            PokemonOnField[attacker].pokemon.hp > target.pokemon.hp:
                    case SuckerPunch when
                            Moves[i].Data().power == 0 || target.done:
                    case Quash when target.quashed:
                    case Trap when target.trapped:
                    case FairyLock when fairyLockNext:
                    case Synchronoise when !SharesType(attacker, i):
                    case VenomDrench when target.pokemon.status is not (Status.Poison or Status.ToxicPoison):
                    case BurnUp when !PokemonOnField[attacker].HasType(Type.Fire):
                    case Purify when target.pokemon.status is Status.None:
                    case Encore when target.encored:
                    case MoveEffect.Disable when target.disabled:
                    case Taunt when target.taunted:
                    case Quash when target.quashed ||
                        target.done:
                        target.isHit = false;
                        Debug.Log("Can't target " + i);
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
                            Debug.Log("Tried to hit " + i);
                            target.isTarget = false;
                        }

                        break;
                }
            }
        }
        return hitAnyone;
    }

    private IEnumerator GainExp(int partyIndex, int amount)
    {
        Pokemon mon = playerPokemon[partyIndex];
        yield return Announce(mon.MonName + " gained "
            + amount + " Exp. points!");
        if (mon.onField && battleType == BattleType.Single)
        {
            yield return xpController.GainXP(amount);
        }
        else
        {
            mon.xp += amount;
            while (XP.LevelToXP(mon.level + 1, mon.SpeciesData.xpClass) < mon.xp && mon.level < PokemonConst.maxLevel)
            {
                mon.LevelUp();
                yield return Announce(mon.MonName + " grew to level " + mon.level + "!");
                yield return mon.CheckLevelUpMoves(Announce, player, announcer.transform, 1.2F, new(-500, 100));
            }
        }
    }

    private IEnumerator HandleXPOnFaint(int partyIndex)
    {
        Pokemon pokemon = opponentPokemon[partyIndex];
#if !ALL_GET_FULL_EXP
        int participatingMons = 0;
        for (int i = 0; i < 6; i++)
        {
            if (playerFacedOpponent[i, partyIndex] && !PlayerPokemon[i].fainted) participatingMons++;
        }
#endif
        for (int i = 0; i < 6; i++)
        {
            if (playerFacedOpponent[i, partyIndex] && !playerPokemon[i].fainted)
            {
                float baseFactor = pokemon.SpeciesData.xpYield * pokemon.level / 5.0F;
#if !ALL_GET_FULL_EXP
                float participantFactor = 1.0F / participatingMons;
#endif
                float allLevelFactor = Mathf.Pow(
                    (2.0F * pokemon.level + 10)
                    / (pokemon.level + playerPokemon[i].level + 10.0F),
                    2.5F);
#if FRIENDSHIP_RAISES_EXP
                float friendshipFactor = playerPokemon[i].friendship >= 220 ? 1.2F : 1.0F;
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
            foreach (int i in OppositeSideIndices(index))
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

    private void CheckForRedirection(int index)
    {
        bool ragePowderOK = !HasAbility(index, Overcoat)
            && !PokemonOnField[index].HasType(Type.Grass);
        if (followMeActive)
        {
            foreach (int i in OppositeSideIndices(index))
            {
                if (PokemonOnField[i].followMe
                    && Target.CanTarget(index, i, Moves[index])
                    && (!PokemonOnField[i].wasRagePowder || ragePowderOK))
                {
                    Targets[index] = i;
                    return;
                }
            }
        }
        foreach (int i in PriorityForRedirection)
        {
            if (!Target.CanTarget(index, i, Moves[index]))
            {
                continue;
            }
            switch (EffectiveAbility(i))
            {
                case LightningRod when GetEffectiveType(Moves[index], index) is Type.Electric:
                case StormDrain when GetEffectiveType(Moves[index], index) is Type.Water:
                    Targets[index] = i;
                    return;
            }
        }

    }

    private void GetCrits(int attacker, MoveID move)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                if ((EffectiveAbility(i) is BattleArmor or ShellArmor &&
                        !HasMoldBreaker(attacker))
                    || Sides[i / 3].luckyChant)
                {
                    continue;
                }
                if ((HasAbility(attacker, Merciless) &&
                        PokemonOnField[i].pokemon.status is Status.Poison or
                        Status.ToxicPoison) ||
                        move.Data().effect == AlwaysCrit)
                {
                    PokemonOnField[i].isCrit = true;
                    continue;
                }
                if (PokemonOnField[attacker].laserFocusNow)
                {
                    PokemonOnField[i].isCrit = true;
                    continue;
                }
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
                    if (GetTypeEffectiveness(PokemonOnField[attacker],
                            PokemonOnField[i], Moves[attacker]) > 1
                        || effectiveType == Type.Normal)
                    {
                        PokemonOnField[i].eatenBerry = PokemonOnField[i].Item;
                        UseUpItem(i);
                        PokemonOnField[i].gotReducingBerryEffect = true;
                        PokemonOnField[i].pokemon.canBelch = true;
                    }
                }
                else if (EffectiveItem(i).BerryEffect()
                    == (GetMove(attacker).physical ? OnPhysHurt125 : OnSpecHurt125))
                {
                    PokemonOnField[i].eatenBerry = PokemonOnField[i].Item;
                    UseUpItem(i);
                    PokemonOnField[i].ateRetaliationBerry = true;
                    PokemonOnField[i].pokemon.canBelch = true;
                }
            }
        }
    }

    private IEnumerator CheckSymbiosis(int index)
    {
        if (PokemonOnField[index].Item is not None) yield break;
        foreach (int i in GetNeighbors[index])
        {
            if (MonIsActive(i) && HasAbility(i, Symbiosis) &&
                EffectiveItem(i) is not None && ItemIsChangeable(i))
            {
                yield return PopupDo(i, DoBestow(i, index));
                yield break;
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
            mon.ingrained || mon.partialTrapped || fairyLockNow) return true;
        return false;
    }

    private void TryToFlinch(int index, int attacker)
    {
        if (HasMoldBreaker(attacker)
            || (EffectiveAbility(index) != InnerFocus))
            PokemonOnField[index].flinched = true;
    }

    private void UseUpItem(int index)
    {
        if (!consumeItems)
        {
            PokemonOnField[index].pokemon.newItem = None;
            PokemonOnField[index].pokemon.itemChanged = true;
        }
        else
        {
            PokemonOnField[index].pokemon.item = None;
        }
        if (HasAbility(index, Unburden)) PokemonOnField[index].unburdened = true;
    }

    private void GetMoveEffects(int attacker, MoveID move)
    {
        //Debug.Log(move.Data().targets);
        switch (move.Data().moveFlags.HasFlag(effectOnSelfOnly))
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
                                && !move.Data().moveFlags.HasFlag(soundMove)
                                && !HasAbility(attacker, Infiltrator)) continue;
                            if (HasAbility(i, ShieldDust) && move.Data().power > 0
                                && move.Data().effect.IsShieldDustAffected()) continue;
                        }
                        switch (move.Data().effect)
                        {
                            case MoveEffect.ForcedSwitch when HasAbility(i, SuctionCups) || HasAbility(i, GuardDog):
                                if (move.Data().power == 0) abilityEffects.Enqueue((i, i, PokemonOnField[i].ability));
                                continue;
                            case MoveEffect.ForcedSwitch when target.ingrained:
                            case PerishSong when HasAbility(i, Soundproof):
                            case Teatime when EffectiveItem(i).BerryEffect() is None:
                            case DestinyBond when PokemonOnField[attacker].cannotUseDestinyBondAgain:
                            case Yawn when target.yawnNextTurn
                                || target.yawnThisTurn || target.pokemon.status != Status.None
                                || UproarOnField && !HasAbility(i, Soundproof)
                                || EffectiveAbility(i) is Insomnia or VitalSpirit or Comatose:
                            case Wish when target.healBlocked:
                            case Captivate when !OppositeGenders(attacker, i):
                            case SkillSwap or WorrySeed or SimpleBeam or Entrainment when
                                target.ability.Unchangeable():
                            case MoveEffect.SuppressAbility when target.ability.Unsuppressable():
                            case SkillSwap or RolePlay when target.ability.Uncopiable():
                            case WorrySeed or SimpleBeam when HasAbility(i, Truant):
                            case RolePlay or SkillSwap when
                                PokemonOnField[attacker].ability.Unchangeable():
                            case Incinerate or KnockOff or Trick or Thief when
                                !ItemIsChangeable(i):
                            case Thief when PokemonOnField[attacker].Item != None:
                            case Bestow when PokemonOnField[attacker].Item == None:
                            case Bestow when PokemonOnField[i].Item != None:
                            case Bestow when !ItemIsChangeable(attacker):
                            case MoveEffect.ReflectType when target.IsTypeless:
                            case Nightmare when target.pokemon.status is not Status.Sleep && !HasAbility(i, Comatose):
                            case Rototiller when (!target.HasType(Type.Grass) || !IsGrounded(i, attacker) ||
                                target.invulnerability is not Invulnerability.None):
                            case TrickOrTreat when target.HasType(Type.Ghost):
                            case ForestsCurse when target.HasType(Type.Grass):
                            case MagneticFlux or GearUp when
                                EffectiveAbility(i) is not Plus or Minus:
                            case Instruct when !target.done || target.lockedInNextTurn ||
                                target.GetPP(target.lastMoveSlot) < 1 || target.lastMoveUsed is
                                MoveID.Instruct or MoveID.Bide or MoveID.FocusPunchAttack or
                                //Add Beak Blast and Shell Trap
                                MoveID.Transform or MoveID.Sketch or MoveID.Mimic or
                                MoveID.KingsShield or MoveID.Struggle or MoveID.Metronome or
                                MoveID.MirrorMove ||
                                GetMove(i).effect is ZMove or SplinteredStormshards or
                                GenesisSupernova:
                            case FlowerShield when !target.HasType(Type.Grass):
                            case MoveEffect.Confuse when HasAbility(i, OwnTempo):
                                continue;
                            case FutureSight:
                                target.gotMoveEffect = !isFutureSightTargeted[i];
                                target.isHit = false;
                                break;
                            case Burn when !CanStatus(i, Status.Burn, attacker):
                            case Paralyze when !CanStatus(i, Status.Paralysis, attacker):
                            case Poison or Toxic when !CanStatus(i, Status.Poison, attacker):
                            case Sleep or MoveEffect.Rest when
                                !CanStatus(i, Status.Sleep, attacker):
                            case Soak when PokemonOnField[i].IsMonotype(Type.Water):
                            case MagicPowder when PokemonOnField[i].IsMonotype(Type.Psychic):
                            case Freeze when !CanStatus(i, Status.Freeze, attacker):
                                continue;
                            case Telekinesis when target.telekinesis || target.ingrained || target.smackDown ||
                                    target.pokemon.GetSpecies is SpeciesID.GengarMega or
                                    SpeciesID.Diglett or SpeciesID.Dugtrio
                                    or SpeciesID.Sandygast or SpeciesID.Palossand:
                            case JawLock when target.trapped || PokemonOnField[attacker].trapped:
                            case StuffCheeks when target.Item.BerryEffect() is None:
                            case NoRetreat when target.usedNoRetreat:
                                continue;
                            case MoveEffect.TriAttack:
                                if (target.pokemon.status != Status.None) continue;
                                goto default;
                            default:
                                if (random.NextDouble() * 100.0F
                                    <= move.Data().effectChance * (HasAbility(attacker, SereneGrace) ? 2 : 1)
                                    * (Sides[GetSide(attacker)].rainbow ? 2 : 1))
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
                        Debug.Log("No stockpile!");
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
        for (int defender = 0; defender < 6; defender++)
        {
            if (defender == attacker) continue;
            if (PokemonOnField[defender].isHit)
            {
                Ability attackerAbility = EffectiveAbility(attacker);
                switch (attackerAbility)
                {
                    case Stench:
                        if (random.Next(10) is 0)
                        {
                            TryToFlinch(defender, attacker);
                        }
                        break;
                    case PoisonTouch when CanStatus(defender, Status.Poison, attacker) && MakesContact(attacker, move):
                    case ToxicChain when CanStatus(defender, Status.ToxicPoison, attacker):
                        if (random.Next(10) < 3)
                        {
                            abilityEffects.Enqueue((attacker, defender, attackerAbility));
                        }
                        break;
                    case Magician when PokemonOnField[attacker].Item is None && ItemIsChangeable(defender):
                        abilityEffects.Enqueue((attacker, defender, attackerAbility));
                        break;
                    default:
                        break;
                }
                if (!HasMoldBreaker(attacker))
                {
                    Ability defenderAbility = EffectiveAbility(defender);
                    switch (defenderAbility)
                    {
                        case Static when MakesContact(attacker, move) && CanStatus(attacker, Status.Paralysis):
                        case CursedBody when MakesContact(attacker, move) && CanDisable(attacker):
                        case PoisonPoint when MakesContact(attacker, move) && CanStatus(attacker, Status.Poison):
                        case FlameBody when MakesContact(attacker, move) && CanStatus(attacker, Status.Burn):
                        case EffectSpore when MakesContact(attacker, move) &&
                          !PokemonOnField[attacker].HasType(Type.Grass) && !HasAbility(attacker, Overcoat):
                        case CuteCharm when MakesContact(attacker, move) && CanInfatuate(attacker, defender):
                            if (random.Next(10) < 3)
                            {
                                abilityEffects.Enqueue((defender, attacker, defenderAbility));
                            }
                            break;
                        case RoughSkin or IronBarbs when MakesContact(attacker, move) &
                            !HasAbility(attacker, MagicGuard):
                        case Pickpocket when MakesContact(attacker, move) && PokemonOnField[defender].Item is None
                            && ItemIsChangeable(attacker):
                        case Mummy or LingeringAroma or WanderingSpirit when MakesContact(attacker, move) &&
                            !EffectiveAbility(defender).Unchangeable() &&
                            EffectiveAbility(defender) != defenderAbility:
                        case PerishBody when !PokemonOnField[attacker].perishSong && MakesContact(attacker, move):
                        case Gooey or TanglingHair when MakesContact(attacker, move):
                            abilityEffects.Enqueue((defender, attacker, defenderAbility));
                            break;
                        case Justified when GetEffectiveType(move, attacker) is Type.Dark && !HitsSubstitute(attacker, defender, move):
                        case WaterCompaction when GetEffectiveType(move, attacker) is Type.Water && !HitsSubstitute(attacker, defender, move):
                        case ThermalExchange when GetEffectiveType(move, attacker) is Type.Fire && !HitsSubstitute(attacker, defender, move):
                        case Rattled when GetEffectiveType(move, attacker) is
                                Type.Dark or Type.Ghost or Type.Bug && !HitsSubstitute(attacker, defender, move):
                        case WeakArmor when move.Data().physical:
                        case SteamEngine when GetEffectiveType(move, attacker) is
                                Type.Water or Type.Fire:
                        case AngerPoint when PokemonOnField[defender].isCrit:
                        case ToxicDebris when move.Data().physical &&
                                Sides[1 - defender / 3].toxicSpikes < 2:
                        case ColorChange when move.Data().power > 0 && !PokemonOnField[defender].IsMonotype(move.Data().type):
                        case Stamina or SandSpit or SeedSower when move.Data().power > 0:
                            abilityEffects.Enqueue((defender, defender, defenderAbility));
                            break;
                        case WindPower when move.Data().moveFlags.HasFlag(windMove):
                        case Electromorphosis when IsPhysical(attacker, defender, MoveNums[attacker]):
                            abilityEffects.Enqueue((attacker, defender, defenderAbility));
                            break;

                    }
                }

            }
        }
    }

    private bool ShowFailure => Moves[currentMovingMon].Data().power == 0;

    private IEnumerator CheckWeatherAbilities()
    {
        for (int i = 0; i < 6; i++)
        {
            switch (EffectiveAbility(i))
            {
                case FlowerGift when PokemonOnField[i].pokemon.species == SpeciesID.Cherrim:
                    if (IsSunAffected(i) && !PokemonOnField[i].pokemon.transformed)
                    {
                        if (!PokemonOnField[i].pokemon.transformed)
                            yield return Transform(i, SpeciesID.CherrimSunshine);
                    }
                    else if (PokemonOnField[i].ApparentSpecies is SpeciesID.CherrimSunshine)
                        yield return Transform(i, SpeciesID.Cherrim);
                    break;
                case Forecast when PokemonOnField[i].pokemon.species == SpeciesID.Castform:
                    if (IsSunAffected(i))
                    {
                        if (PokemonOnField[i].ApparentSpecies is not SpeciesID.CastformSunny)
                            yield return Transform(i, SpeciesID.CastformSunny);
                    }
                    else if (IsRainAffected(i))
                    {
                        if (PokemonOnField[i].ApparentSpecies is not SpeciesID.CastformRainy)
                            yield return Transform(i, SpeciesID.CastformRainy);
                    }
                    else if (IsWeatherAffected(i, Snow))
                    {
                        if (PokemonOnField[i].ApparentSpecies is not SpeciesID.CastformSnowy)
                            yield return Transform(i, SpeciesID.CastformSnowy);
                    }
                    else if (PokemonOnField[i].ApparentSpecies is not SpeciesID.Castform)
                    {
                        yield return Transform(i, untransform: true);
                    }
                    break;
                case Protosynthesis or OrichalcumPulse:
                    yield return CheckProtosynthesis(i);
                    break;
            }
        }
        yield break;
    }

    private IEnumerator HandleAbilityEffects()
    {
        while (abilityEffects.Count() > 0)
        {
            (int source, int target, Ability ability) = abilityEffects.Dequeue();
            if (!MonIsActive(target)) continue;
            switch (ability)
            {
                case Static:
                    yield return PopupDo(source, GetParalysis(target));
                    break;
                case PoisonPoint:
                case PoisonTouch:
                    yield return PopupDo(source, GetPoison(target));
                    break;
                case ToxicChain:
                    yield return PopupDo(source, GetBadPoison(target));
                    break;
                case FlameBody:
                    yield return PopupDo(source, GetBurn(target));
                    break;
                case CursedBody:
                    yield return PopupDo(source, Disable(target));
                    break;
                case Magician:
                case Pickpocket:
                    yield return PopupDo(source, DoThief(source, target));
                    break;
                case EffectSpore:
                    switch (random.Next(3))
                    {
                        case 0:
                            if (CanStatus(target, Status.Poison))
                                yield return PopupDo(source, GetPoison(target));
                            break;
                        case 1:
                            if (CanStatus(target, Status.Paralysis))
                                yield return PopupDo(source, GetParalysis(target));
                            break;
                        case 2:
                            if (CanStatus(target, Status.Sleep))
                                yield return PopupDo(source, FallAsleep(target));
                            break;
                    }
                    break;
                case CuteCharm:
                    yield return PopupDo(source, Infatuate(target, source));
                    break;
                case RoughSkin:
                case IronBarbs:
                    yield return AbilityPopupStart(source);
                    yield return PokemonOnField[target].DoProportionalDamage(0.125F);
                    yield return Announce(MonNameWithPrefix(target, true) + " was hurt by"
                        + EffectiveAbility(source).Name() + "!");
                    yield return AbilityPopupEnd(source);
                    yield return ProcessFaintingSingle(target);
                    break;
                case Mummy or LingeringAroma:
                    yield return PopupDo(source, ChangeAbility(target, ability));
                    break;
                case WanderingSpirit:
                    yield return DoSkillSwap(source, target);
                    break;
                case AngerPoint:
                    doStatAnim = true;
                    yield return PopupDo(target, StatUp(target, Attack, 12, target));
                    break;
                case ColorChange:
                    yield return PopupDo(target, BecomeType(target, PokemonOnField[target].lastTargetedMove.Data().type));
                    break;
                case Gooey:
                case TanglingHair:
                    doStatAnim = true;
                    yield return PopupDo(source, StatDown(target, Speed, 1, source));
                    break;
                case FlashFire:
                    yield return AbilityPopupStart(source);
                    PokemonOnField[target].flashFire = true;
                    yield return Announce("Flash Fire powered up "
                        + MonNameWithPrefix(target, false) + "'s Fire-type moves!");
                    yield return AbilityPopupEnd(source);
                    break;
                case Synchronize:
                    yield return AbilityPopupStart(source);
                    yield return PokemonOnField[source].pokemon.status switch
                    {
                        Status.Burn => GetBurn(target),
                        Status.Paralysis => GetParalysis(target),
                        Status.Poison => GetPoison(target),
                        Status.ToxicPoison => GetBadPoison(target),
                        _ => null
                    };
                    yield return AbilityPopupEnd(source);
                    break;
                case WonderGuard:
                case Soundproof:
                case Bulletproof:
                case Overcoat:
                case Dazzling:
                case QueenlyMajesty:
                case Limber:
                case Insomnia:
                case Immunity:
                case GoodAsGold:
                case Telepathy:
                case SuctionCups:
                case GuardDog:
                    yield return PopupAnnounce(source, "It doesn't affect "
                        + MonNameWithPrefix(target, false) + "...");
                    break;
                case Disguise:
                    yield return AbilityPopupStart(target);
                    yield return Transform(target, SpeciesID.MimikyuBusted);
                    yield return Announce(MonNameWithPrefix(target, true) + "'s disguise was broken!");
                    yield return AbilityPopupEnd(target);
                    break;
                case VoltAbsorb:
                case WaterAbsorb:
                case EarthEater:
                    yield return PopupDo(target, Heal(target, PokemonOnField[target].pokemon.hp >> 2));
                    break;
                case Justified:
                case WindRider:
                case SapSipper:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, Attack, 1, target));
                    break;
                case Rattled:
                case MotorDrive:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, Speed, 1, target));
                    break;
                case Stamina:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, Defense, 1, target));
                    break;
                case WaterCompaction:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, Defense, 2, target));
                    break;
                case StormDrain:
                case LightningRod:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, SpAtk, 1, target));
                    break;
                case SandSpit:
                    yield return PopupDo(source, StartWeather(Sand, 5)); //Need smooth rock effect
                    break;
                case WeakArmor:
                    yield return AbilityPopupStart(source);
                    doStatAnim = true;
                    yield return StatDown(target, Defense, 1, target);
                    doStatAnim = true;
                    yield return StatUp(target, Speed, 1, target);
                    yield return AbilityPopupEnd(source);
                    break;
                case WellBakedBody:
                    doStatAnim = true;
                    yield return PopupDo(target, StatUp(target, Defense, 2, target));
                    break;
                case SteamEngine:
                    doStatAnim = true;
                    yield return PopupDo(source, StatUp(target, Speed, 6, target));
                    break;
                case ToxicDebris:
                    yield return PopupDo(source, DoToxicSpikes(target));
                    break;
                case WindPower:
                case Electromorphosis:
                    yield return PopupAnnounce(target, "Being hit by " + GetMove(source).name + " charged " +
                        MonNameWithPrefix(target, false) + " with power!");
                    PokemonOnField[target].charged = true;
                    break;
                case SeedSower:
                    yield return PopupDo(source, CreateTerrain(Terrain.Grassy, false)); //Todo: terrain extender check
                    break;
                case PerishBody:
                    PokemonOnField[target].perishSong = true;
                    PokemonOnField[target].perishCounter = 3;
                    PokemonOnField[source].perishSong = true;
                    PokemonOnField[source].perishCounter = 3;
                    yield return PopupAnnounce(source, "Both Pokémon will faint in 3 turns!");
                    break;
                case CottonDown:
                    yield return AbilityPopupStart(source);
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == source || !MonIsActive(i)) continue;
                        yield return StatDown(i, Speed, 1, source);
                    }
                    yield return AbilityPopupEnd(source);
                    break;
            }
        }
    }

    private IEnumerator ProcessHits(int attacker, MoveID move, bool isMultiTarget,
        bool parentalBond = false, int powerOverride = NullInt)
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
                        damage = attackingMon.pokemon.level; break;
                    case FinalGambit:
                        damage = attackingMon.pokemon.hp; break;
                    case Counter:
                        damage = attackingMon.damageTaken << 1; break;
                    case MetalBurst:
                        damage = attackingMon.damageTaken
                            + (attackingMon.damageTaken >> 1); break;
                    case Psywave:
                        damage = Max(1, attackingMon.pokemon.level
                            * (50 + (random.Next() % 100)) / 100);
                        break;
                    case SuperFang:
                        damage = defendingMon.pokemon.hp >> 1;
                        break;
                    case GuardianOfAlola:
                        damage = defendingMon.pokemon.hp >> 1;
                        damage += damage >> 1;
                        if (defendingMon.protected75) damage >>= 2;
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
                        damage = PokemonOnField[i].pokemon.hp
                            - PokemonOnField[attacker].pokemon.hp;
                        break;
                    default:
                        damage = DamageCalc(attackingMon, defendingMon,
                            move, isMultiTarget, defendingMon.isCrit, GetSide(i),
                            powerOverride); break;
                }
                if (parentalBond) damage >>= 1;
                Debug.Log(defendingMon.pokemon.hp + " HP, " + damage + " damage");
                if (defendingMon.hasSubstitute && !Moves[attacker].Data().moveFlags.HasFlag(soundMove)
                    && !HasAbility(attacker, Infiltrator))
                {
                    if (damage >= defendingMon.substituteHP)
                    {
                        attackingMon.moveDamageDone = defendingMon.substituteHP;
                        defendingMon.substituteHP = 0;
                        yield return SubstituteFaded(i);
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
                    if (damage >= defendingMon.pokemon.hp)
                    {
                        if (move.Data().effect == FalseSwipe)
                        {
                            attackingMon.moveDamageDone = defendingMon.pokemon.hp - 1;
                            yield return DoSturdyDamage(i);
                        }
                        else if (HasAbility(i, Sturdy)
                                && defendingMon.AtFullHealth
                                && !HasMoldBreaker(attacker))
                        {
                            attackingMon.moveDamageDone = defendingMon.pokemon.hp - 1;
                            yield return DoSturdyDamage(i);
                            abilityEffects.Enqueue((i, i, Sturdy));
                        }
                        else if (defendingMon.endure)
                        {
                            attackingMon.moveDamageDone = defendingMon.pokemon.hp - 1;
                            yield return DoSturdyDamage(i);
                            defendingMon.enduredHit = true;
                        }
                        //Todo: Add focus sash effect as else if
                        else
                        {
                            attackingMon.moveDamageDone += defendingMon.pokemon.hp;
                            defendingMon.damageTaken = defendingMon.pokemon.hp;
                            yield return DoFatalDamage(i);
                            defendingMon.pokemon.fainted = true;
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
                        yield return DoDamage(defendingMon.pokemon, damage);
                        attackingMon.moveDamageDone += damage;
                        if (defendingMon.biding) defendingMon.bideDamage += damage;
                        defendingMon.damageTaken = damage;
                        defendingMon.damageWasPhysical = move.Data().physical;
                        defendingMon.lastDamageDoer = attacker;
                        if (defendingMon.isEnraged)
                        {
                            doStatAnim = true;
                            yield return StatUp(i, Attack, 1, i);
                        }
                        if (move.Data().moveFlags.HasFlag(extraFlinch10) &&
                          random.NextDouble() < 0.10 && !HasAbility(i, ShieldDust))
                            TryToFlinch(i, attacker);
                    }
                }
            }
        }
    }

    private IEnumerator HandleItemEffectsOnHit(MoveID move, int attacker)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit && EffectiveItem(i).HeldEffect() is
                HeldEffect.ActivateOnAttack)
                yield return DoItemEffectOnHit(i, move, attacker);
        }
    }

    private IEnumerator DoItemEffectOnHit(int index, MoveID move, int attacker)
    {
        switch (EffectiveItem(index))
        {
            case AbsorbBulb when GetEffectiveType(move, attacker) is Type.Water:
                yield return UseItemAnim(index);
                doStatAnim = true;
                yield return StatUp(index, SpAtk, 1, index);
                UseUpItem(index);
                yield return CheckSymbiosis(index);
                break;
            case LuminousMoss when GetEffectiveType(move, attacker) is Type.Water:
                yield return UseItemAnim(index);
                doStatAnim = true;
                yield return StatUp(index, SpDef, 1, index);
                UseUpItem(index);
                yield return CheckSymbiosis(index);
                break;
            case CellBattery when GetEffectiveType(move, attacker) is Type.Electric:
            case Snowball when GetEffectiveType(move, attacker) is Type.Ice:
                yield return UseItemAnim(index);
                doStatAnim = true;
                yield return StatUp(index, Attack, 1, index);
                UseUpItem(index);
                yield return CheckSymbiosis(index);
                break;
            case WeaknessPolicy when
                GetTypeEffectiveness(PokemonOnField[attacker], PokemonOnField[index], move) > 1:
                yield return UseItemAnim(index);
                doStatAnim = true;
                yield return StatUp(index, Attack, 2, index);
                yield return StatUp(index, SpAtk, 2, index);
                UseUpItem(index);
                yield return CheckSymbiosis(index);
                break;
        }
    }

    private BallThrowOutcome TryToCatch(BattlePokemon mon, BattlePokemon playerMon, BallCatchType ball)
    {
        if (ball is BallCatchType.Master or BallCatchType.Park) return BallThrowOutcome.Capture;
        if (ball is BallCatchType.NotBall)
        {
            Debug.Log("Tried to use a non-Pokéball item as a Pokéball");
            return BallThrowOutcome.Shake0;
        }
        float chance = (float)(3 * mon.pokemon.hpMax - 2 * mon.pokemon.hp) / (3 * mon.pokemon.hpMax);
        chance *= ball switch
        {
            BallCatchType.Normal => 1,
            BallCatchType.Master => 1,
            BallCatchType.Fast => mon.pokemon.SpeciesData.baseSpeed >= 100 ? 4 : 1,
            BallCatchType.Level => playerMon.pokemon.level / mon.pokemon.level switch
            {
                0 => 1,
                1 => 2,
                2 => 4,
                3 => 4,
                _ => 8
            },
            BallCatchType.Lure => 1, //Todo: fishing
            BallCatchType.Heavy => 1,
            BallCatchType.Love => (mon.pokemon.species == playerMon.pokemon.species &&
                OppositeGenders(playerMon.index, mon.index)) ? 8 : 1,
            BallCatchType.Moon => mon.pokemon.species is SpeciesID.NidoranF or
                SpeciesID.Nidorina or SpeciesID.Nidoqueen or SpeciesID.NidoranM or
                SpeciesID.Nidorino or SpeciesID.Nidoking or SpeciesID.Cleffa or
                SpeciesID.Clefairy or SpeciesID.Clefable or SpeciesID.Igglybuff or
                SpeciesID.Jigglypuff or SpeciesID.Wigglytuff or SpeciesID.Skitty or
                SpeciesID.Delcatty or SpeciesID.Munna or SpeciesID.Musharna ? 4 : 1,
            BallCatchType.Net => (mon.HasType(Type.Water) || mon.HasType(Type.Bug)) ? 3.5f : 1,
            BallCatchType.Dive => 1, //Todo: water
            BallCatchType.Nest => mon.pokemon.level < 30 ?
                ((41 - mon.pokemon.level) / 10) : 1,
            BallCatchType.Repeat => 1, //Todo: check player catch flags
            BallCatchType.Timer => Min(4, 1 + turnsElapsed * 0.3f),
            BallCatchType.Dusk => TimeUtils.timeOfDay is TimeOfDay.Night ? 3 : 1, //Todo: caves too
            BallCatchType.Quick => turnsElapsed is 0 ? 5 : 1,
            _ => 1,
        };
        chance *= mon.pokemon.status switch
        {
            Status.Sleep or Status.Freeze => 2.5F,
            Status.Poison or Status.ToxicPoison or Status.Burn or Status.Paralysis => 1.5F,
            _ or Status.None => 1.0F
        };
        int catchRate = mon.pokemon.SpeciesData.catchRate;
        if (ball is BallCatchType.Heavy) catchRate += mon.pokemon.SpeciesData.pokedexData.weight switch
        {
            < 100000 => -20,
            < 200000 => 0,
            < 300000 => 20,
            _ => 30
        };
        chance *= catchRate;
#if LOW_LEVEL_CATCH_BONUS
        if (mon.pokemon.level < 13)
        {
            chance *= (36 - 2 * mon.pokemon.level) / 20F;
        }
#endif
        //Todo: critical capture
        Debug.Log(chance);
        int shakeChance = (int)(65536 / Mathf.Pow(255f / chance, 3f / 16f));
        Debug.Log(shakeChance);
        Debug.Log(random.Next() & 65535);
        if ((random.Next() & 65535) > shakeChance) return BallThrowOutcome.Shake0;
        if ((random.Next() & 65535) > shakeChance) return BallThrowOutcome.Shake1;
        if ((random.Next() & 65535) > shakeChance) return BallThrowOutcome.Shake2;
        if ((random.Next() & 65535) > shakeChance) return BallThrowOutcome.Shake3;
        return BallThrowOutcome.Capture;

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
        if (PokemonOnField[index].exists && PokemonOnField[index].pokemon.fainted)
        {
            Pokemon mon = PokemonOnField[index].pokemon;
            BattlePokemon battleMon = PokemonOnField[index];
            lastFaintedAbility = PokemonOnField[index].ability;
            lastFaintedIndex = index;
            Sides[GetSide(index)].retaliateNext = true;
            int partyIndex = PokemonOnField[index].partyIndex;
            yield return ExitAbilityCheck(index);
            LeaveFieldCleanup(index);
            yield return Faint(index);
            Moves[index] = MoveID.None;
            yield return HandleXPOnFaint(partyIndex);
            if (PokemonOnField[index + (index < 3 ? 3 : -3)].pokemon.level
                - mon.level >= 30)
                mon.AddFriendship(-5, -5, -10);
            else mon.AddFriendship(-1, -1, -1);
            if (OpponentLost)
            {
                yield return EndBattle();
            }
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].exists && !PokemonOnField[i].pokemon.fainted)
                    yield return AbilityEffectsOnFaint(index);
            }
            if (!AbilitiesSuppressed) switch (battleMon.ability)
                {
                    case Aftermath when fromMove && MakesContact(attacker, Moves[attacker]):
                        yield return DoDamage(PokemonOnField[attacker].pokemon,
                            PokemonOnField[attacker].pokemon.hpMax >> 2);
                        yield return ProcessFaintingSingle(attacker);
                        break;
                    case InnardsOut when fromMove:
                        yield return DoDamage(PokemonOnField[attacker].pokemon,
                            battleMon.damageTaken);
                        yield return ProcessFaintingSingle(attacker);
                        break;
                }
            if (fromMove && MonIsActive(attacker))
            {
                yield return AbilityEffectsForAttackerOnFaint(attacker);
                moveCausedFainting = true;
            }
        }
    }

    private IEnumerator AbilityEffectsOnFaint(int index)
    {
        switch (EffectiveAbility(index))
        {
            case SoulHeart:
                doStatAnim = true;
                yield return PopupDo(index, StatUp(index, SpAtk, 1, index));
                yield break;
            case Receiver or PowerOfAlchemy when index == DoublesPartner(lastFaintedIndex):
                yield return ChangeAbility(index, lastFaintedAbility);
                yield break;
            default: yield break;
        }
    }

    private IEnumerator AbilityEffectsForAttackerOnFaint(int index)
    {
        switch (EffectiveAbility(index))
        {
            case Moxie:
            case ChillingNeigh:
            case AsOneGlastrier:
                doStatAnim = true;
                yield return PopupDo(index, StatUp(index, Attack, 1, index));
                yield break;
            case GrimNeigh:
            case AsOneSpectrier:
                doStatAnim = true;
                yield return PopupDo(index, StatUp(index, SpAtk, 1, index));
                yield break;
            case BeastBoost:
                doStatAnim = true;
                yield return PopupDo(index, StatUp(index, GetTopStat(index, false), 1, index));
                yield break;
            case BattleBond when !PokemonOnField[index].pokemon.activatedAbilities.Contains(BattleBond):
                doStatAnim = true;
                PokemonOnField[index].pokemon.activatedAbilities.Add(BattleBond);
                yield return AbilityPopupStart(index);
                yield return StatUp(index, Attack, 1, index);
                yield return StatUp(index, SpAtk, 1, index);
                yield return StatUp(index, Speed, 1, index);
                yield return AbilityPopupEnd(index);
                break;
        }
    }

    private IEnumerator ProcessDestinyBondAndGrudge(int index)

    {
        BattlePokemon mon = PokemonOnField[index];
        if (mon.gotDestinyBondHit)
        {
            yield return Announce(mon.destinyBondAttacker
                + " took its attacker down with it!");
            yield return DoFatalDamage(index);
            mon.pokemon.fainted = true;
            yield return ProcessFaintingSingle(index);
        }
        if (mon.gotGrudgeEffect)
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + "'s " + mon.lastMoveUsed.Data().name
                + " lost all its PP due to the grudge!");
            yield return DrainPP(index, mon.GetPP(mon.lastMoveSlot - 1), false);
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
        return moveEffect switch
        {
            AttackUp1 or AttackUp2 => PokemonOnField[attacker].attackStage < 6,
            DefenseUp1 or DefenseUp2 => PokemonOnField[attacker].defenseStage < 6,
            SpAtkUp1 or SpAtkUp2 or SpAtkUp3 => PokemonOnField[attacker].spAtkStage < 6,
            SpDefUp1 or SpDefUp2 => PokemonOnField[attacker].spDefStage < 6,
            SpeedUp1 or SpeedUp2 => PokemonOnField[attacker].speedStage < 6,
            EvasionUp1 or EvasionUp2 => PokemonOnField[attacker].evasionStage < 6,
            Growth => PokemonOnField[attacker].attackStage < 6 ||
                          PokemonOnField[attacker].spAtkStage < 6,
            Heal50 or HealWeather or HealPulse or ShoreUp =>
                !PokemonOnField[attacker].AtFullHealth,
            StuffCheeks => PokemonOnField[attacker].Item.BerryEffect() is not None,
            Substitute => PokemonOnField[attacker].HealthProportion > 0.25 && PokemonOnField[attacker].pokemon.hpMax >= 4,
            _ => true,
        };
    }

    private IEnumerator SwitchMove(int index)
    {
        switchingMon = index;
        choseSwitchMon = false;
        menuManager.currentPartyMon = 1;
        menuManager.PartyMenu(MenuManager.PartyScreenReason.SwitchingMove);
        state = BattleState.PlayerInput;
        while (!choseSwitchMon)
        {
            yield return new WaitForSeconds(0.1F);
        }
        yield return ExitAbilityCheck(index);
        LeaveFieldCleanup(index);
        yield return VoluntarySwitch(3, switchingTarget, true, true);
        yield return EntryAbilityCheck(3);
    }

    private void LeaveFieldCleanup(int index, bool removeTrapping = true)
    {
        if (removeTrapping)
        {
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].partialTrappingSource == index)
                    PokemonOnField[i].partialTrapped = false;
                if (PokemonOnField[i].trappingSlot == index)
                    PokemonOnField[i].trapped = false;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].infatuationTarget == index)
                PokemonOnField[i].infatuated = false;
        }
        if (PokemonOnField[index].skyDropping)
        {
            PokemonOnField[PokemonOnField[index].skyDropTarget].beingSkyDropped = false;
            PokemonOnField[PokemonOnField[index].skyDropTarget].invulnerability = 0;
        }
        if (!PokemonOnField[index].pokemon.fainted && HasAbility(index, Regenerator))
            PokemonOnField[index].pokemon.hp += PokemonOnField[index].pokemon.hpMax / 3;
        if (!PokemonOnField[index].pokemon.fainted && HasAbility(index, NaturalCure))
            PokemonOnField[index].pokemon.status = Status.None;
        PokemonOnField[index].pokemon.switchedOut = true;
        PokemonOnField[index].pokemon.onField = false;
        if (snatchingMon == index) snatch = false;
    }

    private bool CheckBerryCondition(int index, bool tookMoveDamage)
    {
        if (Unnerved(index)) return false;
        return EffectiveItem(index).BerryEffect() switch
        {
            At50Restore10HP or At50Restore25 => PokemonOnField[index].HealthProportion <= 0.5F,
            At25Restore33Bitter or At25Restore33Dry or At25Restore33Sour or
                At25Restore33Spicy or At25Restore33Sweet or At25RaiseAttack or
                At25RaiseDefense or At25RaiseSpAtk or At25RaiseSpDef or
                At25RaiseSpeed or At25RaiseCrit or At25RaiseRandom2 or
                At25RaiseAccuracy20 or At25GetPriority =>
                    HasAbility(index, Gluttony) ?
                        PokemonOnField[index].HealthProportion <= 0.5 :
                        PokemonOnField[index].HealthProportion <= 0.25,
            OnSERestore25 => PokemonOnField[index].gotSuperEffectiveHit,
            CureParalysis => PokemonOnField[index].pokemon.status == Status.Paralysis,
            CureSleep => PokemonOnField[index].pokemon.status == Status.Sleep,
            CurePoison => PokemonOnField[index].pokemon.status is
                Status.Poison or Status.ToxicPoison,
            BerryEffect.CureBurn => PokemonOnField[index].pokemon.status == Status.Burn,
            CureFreeze => PokemonOnField[index].pokemon.status == Status.Freeze,
            CureConfusion => PokemonOnField[index].confused,
            CureStatus => PokemonOnField[index].pokemon.status != Status.None
                || PokemonOnField[index].confused,
            OnPhysHurt125 or OnPhysRaiseDefense => PokemonOnField[index].damageWasPhysical && tookMoveDamage,
            OnSpecHurt125 or OnSpecRaiseSpDef => !PokemonOnField[index].damageWasPhysical && tookMoveDamage,
            _ => false,
        };
    }

    private IEnumerator DoBerryEffect(int index, BerryEffect effect, bool ignoreRipen = false)
    {
        switch (effect)
        {
            case CureParalysis:
                yield return HealParalysis(index);
                yield break;
            case CureSleep:
                yield return WakeUp(index);
                yield break;
            case CurePoison:
                yield return HealPoison(index);
                yield break;
            case BerryEffect.CureBurn:
                yield return HealBurn(index);
                yield break;
            case CureFreeze:
                PokemonOnField[index].pokemon.status = Status.None;
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
                    yield return HealStatus(index);
                    yield break;
                }
                goto case CureConfusion;
            case At50Restore10HP:
                yield return Heal(index, 10);
                break;
            case At50Restore25:
            case OnSERestore25:
                yield return Heal(index,
                    PokemonOnField[index].pokemon.hpMax >> 2);
                break;
            case At25Restore33Spicy:
                yield return PinchBerry(index, Attack);
                break;
            case At25Restore33Dry:
                yield return PinchBerry(index, SpAtk);
                break;
            case At25Restore33Sweet:
                yield return PinchBerry(index, Speed);
                break;
            case At25Restore33Bitter:
                yield return PinchBerry(index, SpDef);
                break;
            case At25Restore33Sour:
                yield return PinchBerry(index, Defense);
                break;
            case At25RaiseAttack:
                yield return StatUp(index, Attack, 1, index);
                break;
            case At25RaiseDefense:
            case OnPhysRaiseDefense:
                yield return StatUp(index, Defense, 1, index);
                break;
            case At25RaiseSpAtk:
                yield return StatUp(index, SpAtk, 1, index);
                break;
            case At25RaiseSpDef:
            case OnSpecRaiseSpDef:
                yield return StatUp(index, SpDef, 1, index);
                break;
            case At25RaiseSpeed:
                yield return StatUp(index, Speed, 1, index);
                break;
            case At25RaiseCrit:
                yield return StatUp(index, CritRate, 2, index);
                yield break;
            case At25RaiseRandom2:
                yield return StatUp(index,
                    (Stat)(random.Next(5) + 1), 2, index);
                break;
            case OnPhysHurt125:
            case OnSpecHurt125:
                if (HasAbility(PokemonOnField[index].lastDamageDoer, MagicGuard)) yield break;
                yield return PokemonOnField[PokemonOnField[index].lastDamageDoer].DoProportionalDamage(0.125F);
                yield return Announce(MonNameWithPrefix(PokemonOnField[index].lastDamageDoer, true) +
                    " was hurt by the " + EffectiveItem(index).Data().itemName + "!");
                yield return ProcessFaintingSingle(PokemonOnField[index].lastDamageDoer);
                break;
            case At25RaiseAccuracy20:
                PokemonOnField[index].micleAccBoost = true;
                yield break;
            case At25GetPriority:
                PokemonOnField[index].custapPriorityBoost = true;
                yield break;
            default:
                yield break;
        }
        if (HasAbility(index, Ripen) && !ignoreRipen)
            yield return PopupDo(index, DoBerryEffect(index, effect, true));
        else if (HasAbility(index, CheekPouch) && !PokemonOnField[index].AtFullHealth)
            yield return PopupDo(index, Heal(index, PokemonOnField[index].pokemon.hpMax / 3));
        else if (HasAbility(index, CudChew) && PokemonOnField[index].turnsToCudChew is 0)
        {
            PokemonOnField[index].turnsToCudChew = 2;
            PokemonOnField[index].cudChewEffect = effect;
        }
    }

    private IEnumerator PinchBerry(int index, Stat stat)
    {
        yield return Heal(index,
    PokemonOnField[index].pokemon.hpMax / 3);
        if (PokemonOnField[index].HatesStat(stat))
            yield return Confuse(index);
    }

    private IEnumerator ProcessBerries(int index, bool tookDamage)
    {
        if (CheckBerryCondition(index, tookDamage))
        {
            yield return UseItemAnim(index);
            PokemonOnField[index].eatenBerry = EffectiveItem(index);
            UseUpItem(index);
            PokemonOnField[index].pokemon.canBelch = true;
            yield return DoBerryEffect(index, PokemonOnField[index].eatenBerry.BerryEffect());
            yield return CheckSymbiosis(index);
        }
        else yield break;
    }

    private IEnumerator MonUsed(int index) => Announce(MonNameWithPrefix(index, true) +
        " used " + GetMove(index).name + "!");

    private IEnumerator TryMove(int index, bool doNextMove = true, bool dancer = false)
    {
        BattlePokemon mon = PokemonOnField[index];
        mon.goingNext = false;
        mon.beakBlast = false;
        if (Moves[index] == MoveID.UseItem)
        {
            currentMovingMon = NoMons;
            yield return UseItem(index, itemTarget[index]);
            mon.done = true;
            DoNextMove();
            yield break;
        }
        if (Moves[index] == MoveID.Switch)
        {
            currentMovingMon = NoMons;
            yield return ExitAbilityCheck(index);
            yield return VoluntarySwitch(index, SwitchTargets[index], true, false);
            yield return EntryAbilityCheck(index);
            DoNextMove();
            yield break;
        }
        Debug.Log(GetMove(index).name);
        bool goAhead = true;
        if (!mon.beingSkyDropped) mon.invulnerability = Invulnerability.None;
        mon.cannotUseDestinyBondAgain = mon.destinyBond;
        mon.destinyBond = false;
        mon.grudge = false;
        if (GetMove(index).effect is FocusPunchWindup or BeakBlastWindup || Moves[index] is MoveID.Recharge)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index);
            if (doNextMove) DoNextMove();
            yield break;
        }
        switch (mon.pokemon.status)
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
                if (TryWakeUp(index)) yield return WakeUp(index);
                else
                {
                    yield return MonAsleep(index);
                    if (GetMove(index).effect != Snore) goAhead = false;
                }
                break;
            case Status.Freeze:
                if (random.NextDouble() < 0.8
                    && GetMove(index).type != Type.Fire
                    && Moves[index] != MoveID.Scald)
                {
                    yield return MonFrozen(index);
                    goAhead = false;
                }
                else
                {
                    yield return ThawedOut(index);
                }
                break;
        }
        if (goAhead && mon.beingSkyDropped)
        {
            Debug.Log("Can't move because of Sky Drop");
            yield return Announce(BattleText.MoveFailed);
            goAhead = false;
        }
        if (goAhead && mon.flinched)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " flinched!");
            goAhead = false;
            if (HasAbility(index, Steadfast))
            {
                yield return AbilityPopupStart(index);
                yield return StatUp(index, Speed, 1, index);
                yield return AbilityPopupEnd(index);
            }
        }
        if (goAhead && HasAbility(index, Truant) && mon.truantThisTurn)
        {
            goAhead = false;
            yield return AbilityPopupStart(index);
            yield return Announce(MonNameWithPrefix(index, true) + " is loafing around!");
            yield return AbilityPopupEnd(index);
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
        if (goAhead && mon.powdered && GetEffectiveType(Moves[index], index) is Type.Fire)
        {
            UsePP(index);
            yield return MonUsed(index);
            if (!HasAbility(index, MagicGuard)) yield return mon.DoProportionalDamage(0.25F);
            yield return Announce("When the flame touched the powder, it exploded!");
        }
        if (goAhead && mon.throatChop && Moves[index].Data().moveFlags.HasFlag(soundMove))
        {
            yield return Announce(MonNameWithPrefix(index, true) +
                " can't use " + GetMove(index).name + " after Throat Chop!");
            goAhead = false;
        }
        if (goAhead && mon.infatuated)
        {
            yield return Announce(MonNameWithPrefix(index, true) + " is infatuated!");
            yield return Infatuated(index);
            if (random.NextDouble() < 1.0F / 2.0F)
            {
                yield return Announce(MonNameWithPrefix(index, true) + " is immobilized by love!");
                goAhead = false;
            }
        }
        if (GetMove(index).effect == SelfDestruct || Moves[index] is MoveID.MindBlown)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != index && HasAbility(i, Damp) && !HasMoldBreaker(index))
                {
                    yield return AbilityPopupStart(i);
                    yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                        + GetMove(index).name + "!");
                    mon.moveFailedThisTurn = true;
                    yield return AbilityPopupEnd(i);
                    break;
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
        if (goAhead && gravity && Moves[index].Data().moveFlags.HasFlag(gravityDisabled))
        {
            goAhead = false;
            yield return Announce(MonNameWithPrefix(index, true) + " can't use "
                + GetMove(index).name + " under the intense gravity!");
        }
        if (goAhead && Moves[index].Data().moveFlags.HasFlag(usesProtectCounter))
        {
            float successChance = 1.0f;
            for (int i = 0; i < mon.protectCounter; i++) { successChance /= 3.0f; }
            if (random.NextDouble() > successChance)
            {
                goAhead = false;
                mon.protectCounter = 0;
                Debug.Log("Protect fail condition");
                yield return MonUsed(index);
                yield return Announce(BattleText.MoveFailed);
                mon.moveFailedThisTurn = true;
            }
            else { mon.protectCounter++; }
        }
        else if (goAhead && Moves[index].Data().moveFlags.HasFlag(incrementsProtectCounter)) mon.protectCounter++;
        else mon.protectCounter = 0;
        if (goAhead && GetEffectiveType(Moves[index], index) is Type.Fire && weather is HeavyRain)
        {
            Debug.Log("Heavy rain fail condition");
            yield return MonUsed(index);
            yield return Announce("The Fire-type attack fizzled out in the heavy rain!");
            goAhead = false;
            mon.moveFailedThisTurn = true;
        }
        else if (goAhead && GetEffectiveType(Moves[index], index) is Type.Water && weather is ExtremeSun)
        {
            Debug.Log("Extreme sun fail condition");
            yield return MonUsed(index);
            yield return Announce("The Water-type attack evaporated in the harsh sunlight!");
            goAhead = false;
            mon.moveFailedThisTurn = true;
        }
        if (goAhead)
        {
            Debug.Log("Executing");
            yield return ExecuteMove(index, false, dancer);
        }
        else
        {
            mon.thrashing = false;
            mon.done = true;
            if (!mon.beingSkyDropped)
                mon.moveFailedThisTurn = true;
            if (GetMove(index).type == Type.Electric && mon.charged)
                mon.charged = false;
            if (PokemonOnField[Targets[index]].beingSkyDropped && GetMove(index).effect == SkyDropHit)
            {
                PokemonOnField[index].skyDropping = false;
                PokemonOnField[Targets[index]].beingSkyDropped = false;
                PokemonOnField[Targets[index]].invulnerability = Invulnerability.None;
            }
        }
        if (doNextMove) DoNextMove();
    }

    private IEnumerator FullParalysis(int index)
    {
        yield return ShowParalysis(index);
        yield return Announce(MonNameWithPrefix(index, true) + " is paralyzed! It can't move!");
    }

    private IEnumerator CheckLeppaBerry(int index, int moveNum)
    {
        BattlePokemon mon = PokemonOnField[index];
        if (mon.GetPP(moveNum - 1) == 0 &&
            EffectiveItem(index).BerryEffect() == At0PPRestore10PP)
        {
            yield return UseItemAnim(index);
            yield return Announce(MonNameWithPrefix(index, true) + "'s Leppa Berry restored "
                + mon.GetMove(moveNum - 1).Data().name + "'s PP!");
            switch (moveNum)
            {
                case 1: mon.pokemon.pp1 = Min(10, mon.pokemon.maxPp1); break;
                case 2: mon.pokemon.pp2 = Min(10, mon.pokemon.maxPp2); break;
                case 3: mon.pokemon.pp3 = Min(10, mon.pokemon.maxPp3); break;
                case 4: mon.pokemon.pp4 = Min(10, mon.pokemon.maxPp4); break;
            }
            mon.eatenBerry = mon.Item;
            UseUpItem(index);
            yield return CheckSymbiosis(index);
            PokemonOnField[index].pokemon.canBelch = true;
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
        if (PokemonOnField[index].pokemon.status != Status.Sleep
            || PokemonOnField[index].pokemon.sleepTurns <= 0) { return true; }
        else
        {
            PokemonOnField[index].pokemon.sleepTurns--;
            return false;
        }
    }

    private IEnumerator ResolveHazards(int index)
    {
        if (!HasAbility(index, MagicGuard))
        {
            if (IsGrounded(index))
            {
                switch (Sides[GetSide(index)].spikes)
                {
                    case 1:
                        yield return PokemonOnField[index].DoProportionalDamage(0.125F);
                        goto case 4;
                    case 2:
                        yield return PokemonOnField[index].DoProportionalDamage(1.0F / 6.0F);
                        goto case 4;
                    case 3:
                        yield return PokemonOnField[index].DoProportionalDamage(0.25F);
                        goto case 4;
                    case 4:
                        yield return Announce(MonNameWithPrefix(index, true) + " was hurt by spikes!");
                        if (PokemonOnField[index].pokemon.fainted)
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
                yield return PokemonOnField[index].DoProportionalDamage(0.125F * effectiveness);
                if (PokemonOnField[index].pokemon.fainted)
                {
                    yield return ProcessFaintingSingle(index);
                    yield break;
                }
            }
        }
        if (IsGrounded(index) && Sides[GetSide(index)].stickyWeb)
        {
            yield return Announce(MonNameWithPrefix(index, true) +
                " was caught in a Sticky Web!");
            yield return StatDown(index, Speed, 1,
                index, checkSide: false);
        }
    }

    private Pledge PledgeFromMove(MoveID move) => move switch
    {
        MoveID.GrassPledge => Pledge.Grass,
        MoveID.FirePledge => Pledge.Fire,
        MoveID.WaterPledge => Pledge.Water,
        _ => Pledge.None
    };


    private (bool, MoveID) GetPledge(int index)
    {
        Pledge user = PledgeFromMove(Moves[index]);
        Pledge previous = Sides[GetSide(index)].currentPledge;
        return user switch
        {
            Pledge.Water => previous switch
            {
                Pledge.Fire => (true, MoveID.RainbowPledge),
                Pledge.Grass => (true, MoveID.SwampPledge),
                _ => (false, Moves[index])
            },
            Pledge.Fire => previous switch
            {
                Pledge.Water => (true, MoveID.RainbowPledge),
                Pledge.Grass => (true, MoveID.BurningFieldPledge),
                _ => (false, Moves[index]),
            },
            Pledge.Grass => previous switch
            {
                Pledge.Water => (true, MoveID.SwampPledge),
                Pledge.Fire => (true, MoveID.BurningFieldPledge),
                _ => (false, Moves[index]),
            },
            _ => (false, Moves[index])
        };
    }

    private IEnumerator HandleToxicSpikes(int index, bool bad)
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
            yield return bad ? GetBadPoison(index)
                : GetPoison(index);
        }
    }

    private IEnumerator EntryAbilityCheck(int index)
    {
        Debug.Log(PokemonOnField[index].ability);
        doAbilityEffect[index] = false;
        Ability ability = EffectiveAbility(index);
        switch (ability)
        {
            case Drizzle when weather is not Rain or StrongWinds or HeavyRain or ExtremeSun:
                yield return PopupDo(index, StartWeather(Rain, 5));
                break;
            case Drought or OrichalcumPulse:
                bool weatherChanged = true;
                if (weather is not Sun or StrongWinds or HeavyRain or ExtremeSun)
                {
                    yield return AbilityPopupStart(index);
                    yield return StartWeather(Sun, 5);
                }
                else weatherChanged = false;
                if (ability is OrichalcumPulse && weather is Sun)
                {
                    if (!weatherChanged) yield return AbilityPopupStart(index);
                    PokemonOnField[index].protoQuarkStat = Attack;
                    yield return Announce(MonNameWithPrefix(index, true) +
                        (weatherChanged
                            ? " turned the sunlight harsh, sending"
                            : "used the harsh sunlight to send")
                        + " its ancient pulse into a frenzy!");
                }
                yield return AbilityPopupEnd(index);
                break;
            case SandStream when weather is not Sand or StrongWinds or HeavyRain or ExtremeSun:
                yield return PopupDo(index, StartWeather(Sand, 5));
                break;
            case SnowWarning when weather is not Snow or StrongWinds or HeavyRain or ExtremeSun:
                yield return PopupDo(index, StartWeather(Snow, 5));
                break;
            case PrimoridialSea when weather is not HeavyRain:
                yield return PopupDo(index, StartWeather(HeavyRain, -1));
                break;
            case DesolateLand when weather is not ExtremeSun:
                yield return PopupDo(index, StartWeather(ExtremeSun, -1));
                break;
            case DeltaStream when weather is not StrongWinds:
                yield return PopupDo(index, StartWeather(StrongWinds, -1));
                break;
            case WindRider when Sides[index / 3].tailwind:
                yield return PopupDo(index, StatUp(index, Attack, 1, index));
                break;
            case ElectricSurge or HadronEngine:
                bool terrainChanged = true;
                if (terrain is not Terrain.Electric)
                {
                    yield return AbilityPopupStart(index);
                    yield return CreateTerrain(Terrain.Electric, false); //Add terrain extender
                }
                else terrainChanged = false;
                if (ability is HadronEngine)
                {
                    if (!terrainChanged) yield return AbilityPopupStart(index);
                    PokemonOnField[index].protoQuarkStat = SpAtk;
                    yield return Announce(MonNameWithPrefix(index, true) + (terrainChanged
                            ? " turned the ground into Electric Terrain, energizing"
                            : " used the Electric Terrain to energize")
                        + " its futuristic engine!");
                }
                yield return AbilityPopupEnd(index);
                break;
            case GrassySurge when terrain is not Terrain.Grassy:
            case PsychicSurge when terrain is not Terrain.Psychic:
            case MistySurge when terrain is not Terrain.Misty:
                yield return PopupDo(index, CreateTerrain(ability switch
                {
                    GrassySurge => Terrain.Grassy,
                    PsychicSurge => Terrain.Psychic,
                    MistySurge => Terrain.Misty,
                    _ => (Terrain)255 //Make error
                }, false)); //Terrain extender again
                break;
            case Intimidate:
                yield return DoIntimidate(index);
                break;
            case SupersweetSyrup:
                yield return DoSupersweetSyrup(index);
                break;
            case Trace:
                yield return DoTrace(index);
                break;
            case Frisk:
                int c = 3 - (index / 3);
                for (int i = c; i < c + 3; i++)
                {
                    if (PokemonOnField[i].Item != ItemID.None)
                    {
                        yield return AbilityPopupStart(index);
                        yield return Announce(MonNameWithPrefix(index, true)
                            + " frisked " + MonNameWithPrefix(i, false)
                            + " and found its " + PokemonOnField[i].Item.Data().itemName + "!");
                    }
                }
                yield return AbilityPopupEnd(index);
                break;
            case Anticipation when GetAnticipation(index):
                yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + "'s Anticipation made it shudder!");
                break;
            case Forewarn:
                (MoveID forewarnMove, int forewarnIndex) = GetForewarnMove(index);
                if (forewarnMove is not MoveID.None)
                {
                    yield return PopupAnnounce(index, "Forewarn alerted " +
                        MonNameWithPrefix(index, false) + " to the " +
                        MonNameWithPrefix(forewarnIndex, false) + "'s " +
                        forewarnMove.Data().name + "!");
                }
                break;
            case Unnerve:
                yield return PopupAnnounce(index, (index > 2 ? "The foe's" : "Your") + " team is too nervous to eat berries!");
                break;
            case Protosynthesis:
                yield return CheckProtosynthesis(index);
                break;
            case QuarkDrive:
                yield return CheckQuarkDrive(index);
                break;
            case Mimicry:
                yield return CheckMimicry(index);
                break;
            case WaterBubble when PokemonOnField[index].pokemon.status is Status.Burn:
                yield return PopupDo(index, HealBurn(index));
                break;
            case MoldBreaker:
                yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + " breaks the mold!");
                break;
            case NeutralizingGas:
                yield return PopupAnnounce(index, "A neutralizing gas fills the area!");
                break;
            case IntrepidSword when !PokemonOnField[index].pokemon.activatedAbilities.Contains(IntrepidSword):
                PokemonOnField[index].pokemon.activatedAbilities.Add(IntrepidSword);
                yield return PopupDo(index, StatUp(index, Attack, 1, index));
                break;
            case DauntlessShield when !PokemonOnField[index].pokemon.activatedAbilities.Contains(DauntlessShield):
                PokemonOnField[index].pokemon.activatedAbilities.Add(DauntlessShield);
                yield return PopupDo(index, StatUp(index, Defense, 1, index));
                break;
            case ScreenCleaner:
                foreach (Side side in Sides)
                {
                    if (side.lightScreen || side.reflect || side.auroraVeil)
                    {
                        yield return AbilityPopupStart(index);
                        yield return DoBreakScreens(0);
                        yield return DoBreakScreens(3);
                        yield return AbilityPopupEnd(index);
                    }
                }
                break;
            case Schooling when PokemonOnField[index].ApparentSpecies is SpeciesID.Wishiwashi
              && PokemonOnField[index].pokemon.hp << 2 >= PokemonOnField[index].pokemon.hpMax
              && PokemonOnField[index].pokemon.level >= 20:
                yield return PopupDo(index, Transform(index, SpeciesID.WishiwashiSchool));
                break;
            case Download:
                int totalDefense = 0;
                int totalSpDef = 0;
                for (int i = index / 3; i < index / 3 + 3; i++)
                {
                    if (!MonIsActive(i)) continue;
                    totalDefense += PokemonOnField[i].Defense;
                    totalSpDef += PokemonOnField[i].SpDef;
                }
                if (totalDefense is 0) break;
                yield return StatUp(index, totalDefense < totalSpDef ? Attack : SpAtk, 1, index);
                break;
            case SlowStart:
                yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + " can't get it going!");
                break;
            case TeraformZero:
                if (weather != None || terrain != Terrain.None)
                {
                    yield return AbilityPopupStart(index);
                    if (weather != None) yield return WeatherEnds();
                    if (terrain != Terrain.None) yield return RemoveTerrain();
                    yield return AbilityPopupEnd(index);
                }
                break;
            case VesselOfRuin:
            case SwordOfRuin:
            case TabletsOfRuin:
            case BeadsOfRuin:
                yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + "'s " +
                    ability.Name() + " lowers the " + ability switch
                    {
                        VesselOfRuin => "Attack",
                        SwordOfRuin => "Defense",
                        TabletsOfRuin => "Sp. Atk",
                        BeadsOfRuin => "Sp. Def",
                        _ => "???"
                    } + " of all surrounding Pokémon!");
                break;
            case Hospitality when battleType is BattleType.Double:
                int partner = DoublesPartner(index);
                if (!MonIsActive(partner) || PokemonOnField[partner].AtFullHealth) break;
                yield return AbilityPopupStart(index);
                yield return Heal(DoublesPartner(index), PokemonOnField[partner].pokemon.hpMax >> 2);
                yield return Announce(MonNameWithPrefix(partner, true) + " drank down all the matcha that "
                    + PokemonOnField[index].pokemon.MonName + " made!");
                yield return AbilityPopupEnd(index);
                break;
            case ZenMode:
                yield return CheckZenMode(index); //Should Zen Mode activate here?
                break;
            case Costar when MonIsActive(DoublesPartner(index)):
                yield return PopupDo(index, PsychUp(index, DoublesPartner(index)));
                break;
            case Imposter:
                int oppositeIndex = GetOppositeMon(index);
                if (!MonIsActive(oppositeIndex) || PokemonOnField[oppositeIndex].isTransformed
                    || PokemonOnField[oppositeIndex].illusionActive || PokemonOnField[oppositeIndex].hasSubstitute)
                    break;
                yield return TransformByMove(index, oppositeIndex);
                break;
        }
    }

    private bool MonIsActive(int index) => PokemonOnField[index].exists && !PokemonOnField[index].pokemon.fainted;

    private IEnumerator PopupAnnounce(int index, string announcement)
    {
        yield return AbilityPopupStart(index);
        yield return Announce(announcement);
        yield return AbilityPopupEnd(index);
    }

    private IEnumerator PopupDo(int index, IEnumerator task)
    {
        yield return AbilityPopupStart(index);
        yield return task;
        yield return AbilityPopupEnd(index);
    }

    private IEnumerator HealingWishEffect(int index)
    {
        if (PokemonOnField[index].pokemon.status != Status.None)
        {
            yield return HealStatus(index);
        }
        if (!PokemonOnField[index].AtFullHealth)
        {
            yield return Heal(index, PokemonOnField[index].pokemon.hpMax);
        }
        healingWish[index] = false;
    }

    private IEnumerator MonEntersField(int index)
    {
        PokemonOnField[index].turnOnField = 0;
        yield return ResolveHazards(index);
        if (healingWish[index] && !(PokemonOnField[index].AtFullHealth &&
            PokemonOnField[index].pokemon.status == Status.None))
        {
            healingWish[index] = false;
            yield return HealingWishEffect(index);
        }
        else if (zPowerHeal[index])
        {
            yield return Heal(index, PokemonOnField[index].pokemon.hpMax);
            zPowerHeal[index] = false;
        }
    }

    private void UsePP(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        bool pressureAffected = false;
        for (int i = 0; i < 6; i++)
        {
            if (i == index) continue;
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
                    user.pokemon.pp1 -= pressureAffected ? 2 : 1; break;
                case 2:
                    user.pokemon.pp2 -= pressureAffected ? 2 : 1; break;
                case 3:
                    user.pokemon.pp3 -= pressureAffected ? 2 : 1; break;
                case 4:
                    user.pokemon.pp4 -= pressureAffected ? 2 : 1; break;
            }
        }
    }

    private IEnumerator MonAsleep(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.IsAsleep);
    }

    private IEnumerator MonFrozen(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.FrozenSolid);
    }

    private IEnumerator ThawedOut(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.ThawedOut);
        PokemonOnField[index].pokemon.status = Status.None;
    }

    private IEnumerator NoPP(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.NoPP);
    }

    private IEnumerator HurtByConfusion(int index)
    {
        int damage = DamageCalc(PokemonOnField[index], PokemonOnField[index], MoveID.ConfusionHit, false, false, GetSide(index));
        yield return DefenderAnims(index, MoveID.Pound, 0);
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Neutral Hit"));
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        if (damage >= PokemonOnField[index].pokemon.hp)
        {
            yield return DoDamage(PokemonOnField[index].pokemon, PokemonOnField[index].pokemon.hp);
            PokemonOnField[index].pokemon.fainted = true;
        }
        else
        {
            yield return DoDamage(PokemonOnField[index].pokemon, damage);
        }
        yield return DoHitFlash(index);
        yield return Announce(MonNameWithPrefix(index, true) + " hurt itself in confusion!");
        yield return ProcessFainting();
    }

    private IEnumerator ExecuteMove(int index, bool parentalBond = false, bool dancer = false)
    {
        bool isMultiTarget = false;
        oneAnnouncementDone = false;
        currentMovingMon = index;
        bool checkParentalBond = false;
        moveCausedFainting = false;
        didAnyoneProtect = false;
        sheerForceBoosted = HasAbility(index, SheerForce) &&
            (Moves[index].Data().moveFlags.HasFlag(effectOnSelfOnly) ?
            Moves[index].Data().effect.IsSheerForceAffectedSelfOnly() :
            Moves[index].Data().effect.IsSheerForceAffectedNotSelfOnly()) &&
            Moves[index].Data().power > 0;

        BattlePokemon user = PokemonOnField[index];

        Debug.Log("Executing for " + index);

        if (EffectiveAbility(index) is Protean or Libero &&
            !user.HasType(GetMove(index).type))
        {
            yield return AbilityPopupStart(index);
            yield return BecomeType(index, GetMove(index).type);
            yield return AbilityPopupEnd(index);
        }

        if (MoveNums[index] > 0) user.usedMove[MoveNums[index] - 1] = true;
        user.moveUsedThisTurn = Moves[index];
        if (!Moves[index].Data().moveFlags.HasFlag(mimicBypass)) user.lastMoveUsed = Moves[index];
        user.isEnraged = GetMove(index).effect == Rage;
        if (!user.dontCheckPP)
        {
            user.lastMoveSlot = MoveNums[index];
            UsePP(index);
        }
        if (user.GetPP(MoveNums[index] - 1) == 0
          && user.encored
          && Moves[index] == user.encoredMove)
            user.encored = false;
        if (GetMove(index).effect == FocusPunchWindup)
        {
            Moves[index] = MoveID.FocusPunchAttack;
            user.focused = true;
            user.dontCheckPP = true;
            yield return Announce(MonNameWithPrefix(index, true) + " is tightening its focus!");
            yield break;
        }
        else if (GetMove(index).effect == BeakBlastWindup)
        {
            Moves[index] = MoveID.BeakBlastAttack;
            user.beakBlast = true;
            user.dontCheckPP = true;
            yield return Announce(MonNameWithPrefix(index, true) + " started heating up its beak!");
            yield break;
        }
        else if (GetMove(index).effect == ShellTrapSet)
        {
            Moves[index] = MoveID.ShellTrapAttack;
            user.shellTrap = true;
            user.shellTrapWorks = false;
            user.dontCheckPP = true;
            yield return Announce(MonNameWithPrefix(index, true) + " is setting a shell trap!");
            yield break;
        }
        if (HasAbility(index, StanceChange))
        {
            yield return DoStanceChange(index);
        }
        if (usingZMove[index])
        {
            //Todo: Z-move animations
            yield return Announce(MonNameWithPrefix(index, true) +
                " surrounded itself with its Z-Power!");
            if (index < 3) hasOpponentUsedZMove = true;
            else hasPlayerUsedZMove = true;
            if (GetMove(index).power == 0)
                yield return DoZMoveEffect(index, GetMove(index).zMoveEffect);
            else
            {
                if (user.zMoveBase.Data().effect is WeatherBall &&
                    !user.zMoveBase.Data().physical)
                    Moves[index] = weather switch
                    {
                        Sun => MoveID.InfernoOverdriveSpecial,
                        Rain => MoveID.HydroVortexSpecial,
                        Sand => MoveID.TectonicRageSpecial,
                        Snow => MoveID.SubzeroSlammerSpecial,
                        _ => MoveID.BreakneckBlitzSpecial
                    };
                yield return Announce(MonNameWithPrefix(index, true) +
                    " unleashes its full-force Z-Move!");
            }
        }

        if (GetMove(index).effect is PollenPuff &&
            index / 3 == Targets[index] / 3)
        {
            Moves[index] = MoveID.PollenPuffHeal;
        }

        yield return Announce(user.pokemon.MonName + " used " + GetMove(index).name + "!");
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
            case MoveEffect.Pledge when Sides[GetSide(index)].currentPledge != Pledge.None:
                bool announceCombinedMove;
                (announceCombinedMove, Moves[index]) = GetPledge(index);
                if (announceCombinedMove)
                {
                    yield return Announce("The two moves have combined into one!");
                }
                break;
            case MoveEffect.Pledge when AlliesWillPledge(index):
                yield return Announce(MonNameWithPrefix(index, true) +
                    " waits for its partner's move!");
                Sides[GetSide(index)].currentPledge = Moves[index] switch
                {
                    MoveID.GrassPledge => Pledge.Grass,
                    MoveID.FirePledge => Pledge.Fire,
                    MoveID.WaterPledge => Pledge.Water,
                    _ => Pledge.None,
                };
                user.done = true;
                MoveCleanup();
                yield break;
            case MirrorMove:
                yield return DoMoveAnimation(index, MoveID.MirrorMove);
                user.dontCheckPP = true;
                Moves[index] = user.lastTargetedMove;
                yield return ExecuteMove(index);
                yield break;
            case Metronome:
                yield return DoMoveAnimation(index, MoveID.Metronome);
                user.dontCheckPP = true;
                Moves[index] = (MoveID)(random.Next() % (int)MoveID.Count); //Todo: Add double or multi-battle functionality (targeting)
                yield return ExecuteMove(index);
                yield break;
            case Assist:
                yield return DoMoveAnimation(index, MoveID.Assist);
                user.dontCheckPP = true;
                Moves[index] = GetAssistMove(index);
                yield return ExecuteMove(index);
                yield break;
            case Sketch:
                {
                    MoveID targetMove = PokemonOnField[Targets[index]].lastMoveUsed;
                    if (targetMove == MoveID.None)
                    {
                        Debug.Log("No sketch!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                        user.done = true;
                        MoveCleanup();
                        yield break;
                    }
                    else
                    {
                        yield return DoMoveAnimation(index, MoveID.Sketch);
                        user.pokemon.AddMove(MoveNums[index], targetMove);
                        yield return Announce(MonNameWithPrefix(index, true) + " sketched " + MonNameWithPrefix(Targets[index], false) + "'s "
                            + targetMove.Data().name + "!");
                        user.done = true;
                        MoveCleanup();
                        yield break;
                    }
                }
            case EchoedVoice:
                echoedVoiceUsed = true;
                break;
            case Curse:
                if (!user.HasType(Type.Ghost))
                {
                    if (user.attackStage < 6 || user.defenseStage < 6
                        || user.speedStage > -6)
                    {
                        yield return AttackerAnims(index, MoveID.NonGhostCurse, 0);
                    }
                    yield return StatUp(index, Attack, 1, index);
                    yield return StatUp(index, Defense, 1, index);
                    doStatAnim = true;
                    yield return StatDown(index, Speed, 1, index);
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                break;
            case Fling when EffectiveItem(index).Data().flingPower == 0
                || user.Item.MegaStoneUser() == user.pokemon.species:
            case Snore
                when user.pokemon.status != Status.Sleep && !HasAbility(index, Comatose):
            case FakeOut or FirstImpression when user.turnOnField > 1:
            case SpitUp when user.stockpile == 0:
            case MoveEffect.Swallow when user.stockpile == 0 || user.AtFullHealth:
            case NaturalGift when EffectiveItem(index).Data().type != ItemType.Berry:
            case Copycat when lastMoveUsed.Data().moveFlags.HasFlag(cannotMimic):
            case LastResort when !user.CanUseLastResort:
            case MoveEffect.AllySwitch when battleType == BattleType.Single ||
                Sides[GetSide(index)].allySwitchUsed:
            case ShellTrapAttack when !user.shellTrapWorks:
            case Belch when !user.pokemon.canBelch:
                Debug.Log("Move can't be used!");
                yield return Announce(BattleText.MoveFailed);
                user.moveFailedThisTurn = true;
                user.done = true;
                MoveCleanup();
                yield break;
            case Fling:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " flung its " + user.Item.Data().itemName + "!");
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
                if (user.pokemon.status != Status.Sleep && !HasAbility(index, Comatose))
                {
                    Debug.Log("No sleep talk!");
                    yield return Announce(BattleText.MoveFailed);
                    user.moveFailedThisTurn = true;
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
                            Targets[index] = 3 - index;
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
                        Debug.Log("No possible moves!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
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
                    //Todo: yield return PresentHeal(attacker, target)
                    yield return Heal(Targets[index],
                        PokemonOnField[Targets[index]].pokemon.hpMax >> 2);
                    yield return Announce(MonNameWithPrefix(Targets[index], true) +
                        " regained health!");
                    user.done = true;
                    MoveCleanup();
                    yield break;
                }
                else singleMovePower = presentPower;
                break;
            case AfterYou:
                if (PokemonOnField[Targets[index]].exists)
                {
                    yield return Announce(MonNameWithPrefix(Targets[index], true) +
                        " took the kind offer!");
                    user.done = true;
                    MoveCleanup();
                    yield return (TryMove(Targets[index]));
                }
                else
                {
                    user.done = true;
                    MoveCleanup();
                }
                yield break;
            case Instruct:
                int target = Targets[index];
                yield return Announce(MonNameWithPrefix(target, true) +
                    " used the move instructed by " + MonNameWithPrefix(index, false) + "!");
                bool storedDone = PokemonOnField[target].done;
                MoveID storedMove = Moves[target];
                int storedSlot = MoveNums[target];
                Moves[target] = PokemonOnField[target].lastMoveUsed;
                MoveNums[target] = PokemonOnField[target].lastMoveSlot;
                PokemonOnField[target].done = false;
                yield return TryMove(Targets[index]);
                Moves[target] = storedMove;
                MoveNums[target] = storedSlot;
                PokemonOnField[target].done = storedDone;
                user.done = true;
                MoveCleanup();
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
        if (Moves[index] is MoveID.DarkVoid & user.pokemon.GetSpecies != SpeciesID.Darkrai) //Todo: add Hyperspace Fury/Hoopa Unbound effect
        {
            Debug.Log("No dark void!");
            yield return Announce(BattleText.MoveFailed);
            user.moveFailedThisTurn = true;
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
            case SelfDestruct or FinalGambit:
                yield return DoFatalDamage(index);
                user.pokemon.fainted = true;
                goto default;
            case Teleport:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack)
                    {
                        Debug.Log("No mons!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
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
                        Debug.Log("No mons!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                        user.done = true;
                        yield break;

                    }
                    yield return DoMoveAnimation(index, Moves[index]);
                    yield return ExitAbilityCheck(index);
                    LeaveFieldCleanup(index);
                    yield return VoluntarySwitch(0, nextMon, false, true);
                    yield return EntryAbilityCheck(0);
                }
                yield break;
            case MoveEffect.BatonPass:
                if (user.player)
                {
                    if (!PlayerHasMonsInBack)
                    {
                        Debug.Log("No mons!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                    }
                    else
                    {
                        switchingMon = index;
                        choseSwitchMon = false;
                        yield return DoMoveAnimation(index, Moves[index]);
                        menuManager.currentPartyMon = 1;
                        menuManager.PartyMenu(MenuManager.PartyScreenReason.SwitchingMove);
                        state = BattleState.PlayerInput;
                        while (!choseSwitchMon)
                        {
                            yield return new WaitForSeconds(0.1F);
                        }
                        yield return ExitAbilityCheck(index);
                        LeaveFieldCleanup(index, false);
                        yield return BatonPass(3, switchingTarget);
                    }
                }
                else
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        Debug.Log("No mons!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                        user.done = true;
                        yield break;

                    }
                    yield return DoMoveAnimation(index, Moves[index]);
                    yield return ExitAbilityCheck(index);
                    LeaveFieldCleanup(index, false);
                    yield return BatonPass(0, nextMon);
                }
                yield break;
            default:
                isMultiTarget = GetTargets(index, Moves[index]); break;
        }
        bool hitAnyone = GetHits(index, Moves[index])
            || ((GetMove(index).targets & Target.Self) != 0
            && CheckSelfTargetingMoveAnim(index, GetMove(index).effect));
        bool targetsAnyone;
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
                    case MoveID.Celebrate:
                        yield return Announce("Congratulations, " + player.name);
                        break;
                    case MoveID.HoldHands:
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
                yield return TransformByMove(index, Targets[index]);
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
                        if (IsSunAffected(index))
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
                    case MoveID.SolarBlade:
                        yield return Announce(MonNameWithPrefix(index, true) + " absorbed light!");
                        if (IsSunAffected(index))
                        {
                            Moves[index] = MoveID.SolarBladeAttack;
                            GoToHit = true;
                            break;
                        }
                        else
                        {
                            user.lockedInNextTurn = true;
                            user.lockedInMove = MoveID.SolarBladeAttack;
                            break;
                        }
                    case MoveID.SkyAttack:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.SkyAttackAttack;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " became cloaked in a harsh light!");
                        break;
                    case MoveID.SkullBash:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.SkullBashAttack;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " lowered its head!");
                        yield return StatUp(index, Defense, 1, index);
                        break;
                    case MoveID.Bide:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BideMiddle;
                        user.bideDamage = 0;
                        user.biding = true;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " began storing energy!");
                        break;
                    case MoveID.BideMiddle:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BideAttack;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " is storing energy!");
                        break;
                    case MoveID.Dive:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.DiveAttack;
                        user.invulnerability = Invulnerability.Dive;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " hid underwater!");
                        break;
                    case MoveID.Bounce:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.BounceAttack;
                        user.invulnerability = Invulnerability.Fly;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " sprang up!");
                        break;
                    case MoveID.ShadowForce:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.ShadowForceAttack;
                        user.invulnerability = Invulnerability.Disappearing;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " vanished instantly!");
                        break;
                    case MoveID.FreezeShock:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.FreezeShockAttack;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " became cloaked in a freezing light!");
                        break;
                    case MoveID.IceBurn:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.IceBurnAttack;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " became cloaked in a freezing light!");
                        break;
                    case MoveID.PhantomForce:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.PhantomForceAttack;
                        user.invulnerability = Invulnerability.Disappearing;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " vanished instantly!");
                        break;
                    case MoveID.Geomancy:
                        user.lockedInNextTurn = true;
                        user.lockedInMove = MoveID.GeomancyExecution;
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " is absorbing power!");
                        break;
                    default:
                        break;
                }
                if (GoToHit) { goto default; }
                break;

            case SkyDrop:
                BattlePokemon skyDropTarget = PokemonOnField[Targets[index]];
                if (!skyDropTarget.isHit)
                {

                }
                else
                {
                    user.lockedInNextTurn = true;
                    user.lockedInMove = MoveID.SkyDropAttack;
                    user.invulnerability = Invulnerability.SkyDrop;
                    skyDropTarget.invulnerability = Invulnerability.SkyDrop;
                    skyDropTarget.beingSkyDropped = true;
                    yield return Announce(MonNameWithPrefix(index, true) + " took "
                        + MonNameWithPrefix(Targets[index], false) + " into the sky!");
                }
                break;
            case BeatUp:
                targetsAnyone = false;
                if (hitAnyone)
                {
                    int hits = 0;
                    Pokemon[] party = index < 3 ? opponentPokemon : playerPokemon; //Todo: Add multi battle functionality

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
                                powerOverride: 5 + (party[i].SpeciesData.baseAttack / 10));
                            bool pokemonLeft = false;
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].pokemon.hp > 0 && PokemonOnField[j].isHit)
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
                        Debug.Log("No hits!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                        break;
                    }
                    yield return Announce("Hit " + hits + (hits == 1 ? " time!" : " times!"));
                }

                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        if (PokemonOnField[i].protected75)
                        {
                            yield return Announce(MonNameWithPrefix(index, true) +
                                " couldn't protect itself fully and got hurt!");
                        }
                        float effectiveness = GetTypeEffectiveness(user, PokemonOnField[i], Moves[index]);
                        if (GetMove(index).effect is not Direct40 or Direct20 or
                            DirectLevel or Endeavor or MoveEffect.PainSplit or OHKO)
                            yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].isMissed)
                    {
                        yield return Announce(PokemonOnField[i].pokemon.MonName + BattleText.AvoidedAttack);
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].wasProtected)
                    {
                        yield return Announce(PokemonOnField[i].pokemon.MonName + " protected itself!");
                        didAnyoneProtect = true;
                        if (MakesContact(index, Moves[index]))
                        {
                            yield return DoProtectEffect(i, index);
                        }
                        targetsAnyone = true;
                    }
                    if (PokemonOnField[i].gotMoveEffect) targetsAnyone = true;
                }
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        yield return ProcessBerries(i, true);
                        yield return DoItemEffectOnHit(i, Moves[index], index);
                    }
                }
                if (!targetsAnyone && abilityEffects.Count() is 0)
                {
                    Debug.Log("Targets nobody!");
                    yield return Announce(BattleText.MoveFailed);
                    user.moveFailedThisTurn = true;
                }
                yield return ProcessFainting();
                yield return ProcessDestinyBondAndGrudge(index);
                break;
            case MultiHit2to5 or MultiHit2 or Twineedle or TripleHit
                or DoubleIronBash or DragonDarts:
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
                                    hits = random.NextDouble() switch
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
                            case DoubleIronBash:
                            case DragonDarts:
                                hits = 2;
                                break;
                            default:
                                hits = 0;
                                break;
                        }
                        List<int> dragonDartsEligible = new();
                        if (GetMove(index).effect is DragonDarts
                            && battleType is not BattleType.Single
                            && Targets[index] / 3 != index / 3
                            && !followMeActive)
                        {
                            foreach (int i in OppositeSideIndices(index))
                            {
                                if (MonIsActive(i)
                                    && PokemonOnField[i].protection
                                        is Protection.None
                                    && PokemonOnField[i].invulnerability
                                        is Invulnerability.None
                                    && (GetTypeEffectiveness(PokemonOnField[index],
                                        PokemonOnField[i], Moves[index]) >
                                        (HasAbility(i, WonderGuard) ? 1 : 0)))
                                    dragonDartsEligible.Add(i);
                            }
                        }
                        for (int i = 0; i < hits; i++)
                        {
                            continueMultiHitMove = true;
                            if (GetMove(index).effect is DragonDarts
                                && battleType is not BattleType.Single
                                && Targets[index] / 3 != index / 3
                                && !followMeActive)
                            {
                                foreach (int j in OppositeSideIndices(index))
                                {
                                    PokemonOnField[j].isTarget = j ==
                                        dragonDartsEligible[dragonDartsEligible.Count is 2 ? i : 0];
                                }
                                break;
                            }
                            GetCrits(index, Moves[index]);
                            GetMoveEffects(index, Moves[index]);
                            GetAbilityEffects(index, Moves[index]);
                            CheckReducingAndRetaliatingBerries(index);
                            yield return DoMoveAnimation(index, Moves[index]);
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].gotReducingBerryEffect)
                                {
                                    yield return UseItemAnim(j);
                                    yield return Announce("The "
                                        + PokemonOnField[j].eatenBerry.Data().itemName
                                        + " weakened the damage to "
                                        + MonNameWithPrefix(j, false) + "!");
                                    yield return CheckSymbiosis(j);
                                }
                                if (PokemonOnField[j].ateRetaliationBerry && !HasAbility(index, MagicGuard))
                                {
                                    yield return PokemonOnField[index].DoProportionalDamage(0.125F);
                                    yield return Announce(MonNameWithPrefix(index, true)
                                        + " was hurt by the "
                                        + PokemonOnField[j].eatenBerry.Data().itemName + "!");
                                    yield return ProcessFaintingSingle(index);
                                    yield return CheckSymbiosis(j);
                                }
                            }
                            yield return HandleHitFlashes(index);
                            if (GetMove(index).effect == TripleHit)
                            {
                                yield return ProcessHits(index, Moves[index], isMultiTarget,
                                powerOverride: GetMove(index).power * (i + 1));
                            }
                            else { yield return ProcessHits(index, Moves[index], isMultiTarget); }
                            bool pokemonLeft = false;
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].pokemon.hp > 0 && PokemonOnField[j].isHit)
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
                            if (!sheerForceBoosted)
                                yield return HandleMoveEffect(index);
                            for (int j = 0; j < 6; j++)
                            {
                                if (PokemonOnField[j].isHit)
                                {
                                    yield return ProcessBerries(j, true);
                                    yield return DoItemEffectOnHit(j, Moves[index], index);
                                }
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
                            yield return Announce(target.pokemon.MonName + BattleText.AvoidedAttack);
                            targetsAnyone = true;
                        }
                        if (target.wasProtected)
                        {
                            yield return Announce(target.pokemon.MonName + " protected itself!");
                            if (MakesContact(index, Moves[index]))
                            {
                                yield return DoProtectEffect(i, index);
                            }
                            didAnyoneProtect = true;
                            targetsAnyone = true;
                        }
                        if (target.gotMoveEffect)
                        {
                            targetsAnyone = true;
                        }
                    }
                    if (!targetsAnyone)
                    {
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                    }
                    if (!hitAnyone && !didAnyoneProtect)
                        user.moveFailedThisTurn = true;
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
                    if (hitAnyone && GetMove(index).effect is SpectralThief)
                    {
                        yield return Announce(MonNameWithPrefix(index, true) +
                            " stole the target's boosted stats!");
                        StatStruct targetStats = PokemonOnField[Targets[index]].MakeStatStruct();
                        user.ApplyStatStruct(
                            user.MakeStatStruct().StealBuffs(
                                targetStats));
                        PokemonOnField[Targets[index]].ApplyStatStruct(
                            targetStats.RemoveBuffs());
                    }
                    if (hitAnyone &&
                        !(Moves[index].Data().moveFlags.HasFlag(snatchAffected)
                        && snatch))
                        yield return DoMoveAnimation(index, Moves[index]);
                    if (GetMove(index).effect != SkyDropHit || IsGrounded(Targets[index], index))
                    {
                        yield return HandleHitFlashes(index);
                        yield return ProcessHits(index, Moves[index], isMultiTarget, parentalBond);
                        for (int i = 0; i < 6; i++)
                        {
                            if (PokemonOnField[i].gotReducingBerryEffect)
                            {
                                yield return UseItemAnim(i);
                                yield return Announce("The "
                                    + PokemonOnField[i].eatenBerry.Data().itemName
                                    + " weakened the damage to "
                                    + MonNameWithPrefix(i, false) + "!");
                            }
                            if (PokemonOnField[i].ateRetaliationBerry & !HasAbility(index, MagicGuard))
                            {
                                yield return PokemonOnField[index].DoProportionalDamage(0.125F);
                                yield return new WaitForSeconds(1.0F);
                                yield return Announce(MonNameWithPrefix(index, true)
                                    + " was hurt by the "
                                    + PokemonOnField[i].eatenBerry.Data().itemName + "!");
                                yield return ProcessFaintingSingle(index);
                            }
                        }
                    }
                    targetsAnyone = false;
                    for (int i = 0; i < 6; i++)
                    {
                        BattlePokemon target = PokemonOnField[i];
                        if (target.beingSkyDropped && GetMove(index).effect == SkyDropHit)
                        {
                            target.beingSkyDropped = false;
                            target.invulnerability = Invulnerability.None;
                        }
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
                        if (target.wasProtected)
                        {
                            yield return Announce(target.pokemon.MonName + " protected itself!");
                            if (MakesContact(index, Moves[index]))
                            {
                                yield return DoProtectEffect(i, index);
                            }
                            didAnyoneProtect = true;
                            targetsAnyone = true;
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
                        {
                            yield return ProcessBerries(i, true);
                            yield return DoItemEffectOnHit(i, Moves[index], index);
                        }
                        else if (PokemonOnField[i].gotMoveEffect)
                            yield return ProcessBerries(i, false);
                    }
                    yield return HandleAbilityEffects();
                    if (!targetsAnyone)
                    {
                        Debug.Log("No targets!");
                        yield return Announce(BattleText.MoveFailed);
                        user.moveFailedThisTurn = true;
                    }
                    if (!hitAnyone)
                    {
                        user.thrashing = false;
                        user.uproar = false;
                        user.lockedInNextTurn = false;
                        if (!didAnyoneProtect) user.moveFailedThisTurn = true;
                        else user.moveFailedThisTurn = false;
                    }
                    yield return ProcessFainting(true, index);
                    yield return ProcessDestinyBondAndGrudge(index);
                    if (!sheerForceBoosted)
                        yield return HandleMoveEffect(index);
                    break;
                }
        }
        if (GetEffectiveType(Moves[index], index) is Type.Fire ||
            Moves[index] is MoveID.Scald)
        {
            foreach (BattlePokemon mon in PokemonOnField)
            {
                if (mon.isHit && !mon.pokemon.fainted && mon.pokemon.status is Status.Freeze)
                {
                    yield return ThawedOut(mon.index);
                }
            }
        }

        switch (GetMove(index).effect)
        {
            case Recoil50 when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
                yield return user.DoNonMoveDamage(Max(1, user.moveDamageDone / 2));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Recoil33 when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
                yield return user.DoNonMoveDamage(Max(1, user.moveDamageDone / 3));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case VoltTackle when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
            case Recoil25 when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
            case FlareBlitz when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
                yield return user.DoNonMoveDamage(Max(1, user.moveDamageDone / 4));
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Recoil25Max when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
                yield return user.DoProportionalDamage(0.25F);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Recoil50Max when EffectiveAbility(index) is not RockHead or MagicGuard
                && user.moveDamageDone > 0:
                yield return user.DoProportionalDamage(0.5F);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case Fling:
            case NaturalGift when EffectiveItem(index).Data().type is ItemType.Berry:
                UseUpItem(index);
                yield return CheckSymbiosis(index);
                break;
            case Thrash:
                user.thrashingTimer++;
                if (user.thrashingTimer == 3
                    || user.thrashingTimer == 2
                    && random.NextDouble() > 0.5)
                {
                    yield return Confuse(index);
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
                    EffectiveAbility(index) is not RockHead or MagicGuard:
                yield return user.DoProportionalDamage(0.5F);
                yield return Announce(MonNameWithPrefix(index, true) + " kept going and crashed!");
                yield return ProcessFaintingSingle(index);
                yield return ProcessBerries(index, false);
                break;
            case SelfDestruct or Memento or FinalGambit:
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
            case FellStinger when moveCausedFainting:
                yield return StatUp(index, Attack, 3, index);
                break;
            default:
                break;
        }
        if (GetMove(index).effect == FuryCutter && user.moveDamageDone > 0)
        {
            if (user.furyCutterIntensity < 3) user.furyCutterIntensity++;
        }
        else user.furyCutterIntensity = 0;
        yield return HandleAbilityEffects();
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit && Moves[index].Data().moveFlags.HasFlag(makesContact) &&
                PokemonOnField[i].beakBlast)
                yield return GetBurn(index);
            if (PokemonOnField[i].isHit && Moves[index].Data().physical &&
                PokemonOnField[i].shellTrap)
            {
                PokemonOnField[i].shellTrapWorks = true;
                PokemonOnField[i].goingNext = true;
            }
        }
        if (!user.dontCheckPP) yield return CheckLeppaBerry(index, MoveNums[index]);
        if (!parentalBond && checkParentalBond && HasAbility(index, ParentalBond))
        {
            user.dontCheckPP = true;
            yield return ExecuteMove(index, true);
        }
        user.done = true;
        MoveCleanup();
    }

    private IEnumerator CheckDancer(int index)
    {
        for (int i = 0; i < 6; i++)
        {
            if (i == index || !HasAbility(i, Dancer)) continue;
            (MoveID move, bool wasDone) = (Moves[i], PokemonOnField[i].done);
            Moves[i] = Moves[index];
            PokemonOnField[i].done = false;
            yield return TryMove(i, false);

        }
    }

    private IEnumerator DoMoveAnimation(int attacker, MoveID move)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit || (PokemonOnField[i].gotMoveEffect && i != attacker))
            {
                StartCoroutine(DefenderAnims(i, move, attacker));
            }
        }
        yield return AttackerAnims(attacker, move, Targets[attacker]);
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

    public IEnumerator DoDamage(Pokemon mon, int damage)
    {
        int initialHP = mon.hp;
        bool wasAbove50 = (mon.hp << 1) >= mon.hpMax;
        float duration = Mathf.Pow(Mathf.Abs(damage), 0.33F) / 5;
        float baseTime = Time.time;
        damage = Mathf.Min(damage, mon.hp);
        while (Time.time < baseTime + duration)
        {
            float progress = (Time.time - baseTime) / duration;
            mon.hp = initialHP - (int)(damage * progress);
            yield return null;
        }
        if (mon.onField) foreach (BattlePokemon battleMon in PokemonOnField)
            {
                if (battleMon.pokemon == mon)
                {
                    if (wasAbove50 && (mon.hp << 1) < mon.hpMax && mon.hp > 0)
                    {
                        int index = battleMon.index;
                        switch (EffectiveAbility(index))
                        {
                            case AngerShell:
                                doStatAnim = true;
                                yield return AbilityPopupStart(index);
                                yield return StatUp(index, Attack, 1, index);
                                yield return StatUp(index, SpAtk, 1, index);
                                yield return StatUp(index, Speed, 1, index);
                                doStatAnim = true;
                                yield return StatDown(index, Defense, 1, index);
                                yield return StatDown(index, SpDef, 1, index);
                                yield return AbilityPopupEnd(index);
                                break;
                            case Berserk:
                                doStatAnim = true;
                                yield return PopupDo(index, StatUp(index, SpAtk, 1, index));
                                break;
                        }
                    }
                    break;
                }
            }
        mon.hp = initialHP - damage;
        if (mon.hp == 0) mon.fainted = true;
    }

    private IEnumerator DoFatalDamage(int index) =>
        DoDamage(PokemonOnField[index].pokemon, PokemonOnField[index].pokemon.hp);

    private IEnumerator DoSturdyDamage(int index) =>
        DoDamage(PokemonOnField[index].pokemon, PokemonOnField[index].pokemon.hp - 1);

    private IEnumerator DoHitFlash(int index)
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

    private Type MimicryType => terrain switch
    {
        Terrain.Grassy => Type.Grass,
        Terrain.Misty => Type.Fairy,
        Terrain.Electric => Type.Electric,
        Terrain.Psychic => Type.Psychic,
        _ => Type.Normal
    };

    private IEnumerator CheckMimicry(int index)
    {
        if (terrain is Terrain.None && PokemonOnField[index].typesOverriden)
        {
            yield return Announce(MonNameWithPrefix(index, true) +
                " returned to its original type!");
            PokemonOnField[index].typesOverriden = false;
        }
        else if (!PokemonOnField[index].IsMonotype(MimicryType))
        {
            yield return BecomeType(index, MimicryType);
        }
    }

    private IEnumerator CheckTerrainAbilities()
    {
        for (int i = 0; i < 6; i++)
        {
            switch (EffectiveAbility(i))
            {
                case Mimicry:
                    yield return CheckMimicry(i);
                    break;
                case QuarkDrive or HadronEngine:
                    yield return CheckQuarkDrive(i);
                    break;
            }
        }
    }

    private IEnumerator CheckQuarkDrive(int index) //Only call this when the mon has quark drive
    {
        if (PokemonOnField[index].boosterEnergy) yield break;
        if (terrain is Terrain.Electric)
        {
            PokemonOnField[index].protoQuarkStat = HasAbility(index, HadronEngine) ? SpAtk : GetTopStat(index, true);
            yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + "'s " +
                PokemonOnField[index].protoQuarkStat.Name() + " is heightened!");
        }
        else if (HasAbility(index, QuarkDrive))
        {
            yield return CheckBoosterEnergy(index);
        }
    }

    private IEnumerator CheckProtosynthesis(int index) //See above
    {
        if (PokemonOnField[index].boosterEnergy) yield break;
        if (IsSunAffected(index))
        {
            PokemonOnField[index].protoQuarkStat = HasAbility(index, OrichalcumPulse) ? Attack : GetTopStat(index, true);
            yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + "'s " +
                PokemonOnField[index].protoQuarkStat.Name() + " is heightened!");
        }
        else if (HasAbility(index, Protosynthesis))
        {
            yield return CheckBoosterEnergy(index);
        }
    }

    private bool GetsProtoBoost(int index)
    {
        if (HasAbility(index, Protosynthesis)) return
            (IsSunAffected(index) || PokemonOnField[index].boosterEnergy);
        if (HasAbility(index, OrichalcumPulse)) return IsSunAffected(index);
        if (HasAbility(index, QuarkDrive)) return
            (terrain is Terrain.Electric || PokemonOnField[index].boosterEnergy);
        if (HasAbility(index, HadronEngine)) return terrain is Terrain.Electric;
        return false;
    }

    private IEnumerator CheckBoosterEnergy(int index)
    {
        bool doBoosterEnergy = false;
        if (EffectiveAbility(index) is Protosynthesis or OrichalcumPulse && HasItem(index, BoosterEnergy))
            doBoosterEnergy = !IsSunAffected(index);
        if (EffectiveAbility(index) is QuarkDrive or HadronEngine && HasItem(index, BoosterEnergy))
            doBoosterEnergy = terrain is not Terrain.Electric;
        if (doBoosterEnergy)
        {
            yield return UseItemAnim(index);
            UseUpItem(index);
            PokemonOnField[index].protoQuarkStat = GetTopStat(index, true);
            PokemonOnField[index].boosterEnergy = true;
            yield return Announce(MonNameWithPrefix(index, true) + " used its Booster Energy to activate its "
                + EffectiveAbility(index).Name() + "!");
            yield return PopupAnnounce(index, MonNameWithPrefix(index, true) + "'s " +
                PokemonOnField[index].protoQuarkStat.Name() + " is heightened!");
            yield return CheckSymbiosis(index);
        }
    }

    private void MoveCleanup()
    {
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
            mon.wasProtected = false;
            mon.protected75 = false;
            mon.gotAteBoost = false;
            mon.gotReducingBerryEffect = false;
            mon.ateRetaliationBerry = false;
            mon.meFirst = false;
        }
    }

    private IEnumerator AnnounceTypeEffectiveness(float effectiveness, bool isMultiTarget, int index)
    {
        if (effectiveness > 1)
        {

            yield return Announce(isMultiTarget ? BattleText.SuperEffectiveOn + PokemonOnField[index].pokemon.MonName + "!"
                : BattleText.SuperEffective);
        }
        else if (effectiveness == 0)
        {
            yield return Announce(BattleText.NoEffect + MonNameWithPrefix(index, false) + "...");
        }
        else if (effectiveness < 1)
        {
            yield return Announce(isMultiTarget ? BattleText.NotVeryEffectiveOn + PokemonOnField[index].pokemon.MonName + "..."
                : BattleText.NotVeryEffective);
        }
    }

    private IEnumerator HandleMoveEffect(int index)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].gotMoveEffect && !PokemonOnField[i].pokemon.fainted)
            {
                Debug.Log("Index " + i + " gets effect");
                doStatAnim = true;
                yield return DoMoveEffect(i, Moves[index], index);
            }
        }
    }

    private MoveID GetAssistMove(int index)
    {
        Pokemon[] party = index < 3 ? opponentPokemon : playerPokemon;
        List<MoveID> possibleMoves = new();
        for (int i = 0; i < 6; i++)
        {
            if (party[i] == PokemonOnField[index].pokemon || !party[i].exists) continue;
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

    private IEnumerator AnnounceProtect(int index) => Announce(MonNameWithPrefix(index, true)
                    + " protected itself!");

    private IEnumerator DoMoveEffect(int index, MoveID move, int attacker)
    {
        IEnumerator Omniboost()
        {
            yield return StatUp(index, Attack, 1, attacker);
            yield return StatUp(index, Defense, 1, attacker);
            yield return StatUp(index, SpAtk, 1, attacker);
            yield return StatUp(index, SpDef, 1, attacker);
            yield return StatUp(index, Speed, 1, attacker);
        }
        if (move.Data().moveFlags.HasFlag(snatchAffected) && snatch)
        {
            yield return Announce(MonNameWithPrefix(snatchingMon, true)
                + " snatched " + MonNameWithPrefix(attacker, false)
                + "'s move!");
            yield return AttackerAnims(snatchingMon, move, 0);
            index = snatchingMon;
            attacker = snatchingMon;
        }
        if (move.Data().moveFlags.HasFlag(magicBounceAffected) &&
            (PokemonOnField[index].magicCoat
             || (HasAbility(index, MagicBounce) && !HasMoldBreaker(attacker))))
        {
            //yield return MagicCoatActivates(index);
            yield return Announce(MonNameWithPrefix(index, true) + " bounced back the move!");
            (index, attacker) = (attacker, index);
        }
        MoveEffect effect = move.Data().effect;
        if (effect == Fling)
        {
            effect = EffectiveItem(attacker).Data().flingEffect;
            if (EffectiveItem(attacker).Data().type is ItemType.Berry)
            {
                yield return DoBerryEffect(index, EffectiveItem(attacker).BerryEffect());
            }
        }
        switch (effect)
        {
            case Burn:
            case FlareBlitz:
                yield return GetBurn(index);
                if (HasAbility(index, Synchronize) && CanStatus(attacker, Status.Burn, index, breakSub: true))
                    abilityEffects.Enqueue((index, attacker, Synchronize));
                break;
            case VoltTackle:
            case Paralyze:
                yield return GetParalysis(index);
                if (HasAbility(index, Synchronize) && CanStatus(attacker, Status.Paralysis, index, breakSub: true))
                    abilityEffects.Enqueue((index, attacker, Synchronize));
                break;
            case Poison:
            case Twineedle:
                yield return GetPoison(index, attacker: attacker);
                if (HasAbility(index, Synchronize) && CanStatus(attacker, Status.Poison, index, breakSub: true))
                    abilityEffects.Enqueue((index, attacker, Synchronize));
                break;
            case Toxic:
                yield return GetBadPoison(index);
                if (HasAbility(index, Synchronize) && CanStatus(attacker, Status.ToxicPoison, index, breakSub: true))
                    abilityEffects.Enqueue((index, attacker, Synchronize));
                break;
            case Freeze:
            case FreezeDry:
                yield return GetFreeze(index);
                break;
            case Sleep:
                yield return FallAsleep(index, attacker: attacker);
                break;
            case MoveEffect.Confuse:
                yield return Confuse(index);
                break;
            case Swagger:
                yield return StatUp(index, Attack, 2, attacker);
                goto case MoveEffect.Confuse;
            case Flatter:
                yield return StatUp(index, SpAtk, 1, attacker);
                goto case MoveEffect.Confuse;
            case MoveEffect.TriAttack:
                yield return TriAttack(index);
                break;
            case SmellingSalts:
                yield return HealParalysis(index);
                break;
            case MoveEffect.CureBurn:
                yield return HealBurn(index);
                break;
            case WakeUpSlap:
                yield return WakeUp(index);
                break;
            case LeechSeed:
                yield return GetLeechSeed(index, attacker);
                break;
            case Nightmare:
                yield return GetNightmare(index);
                break;
            case Spite:
                yield return DrainPP(index, 4);
                yield return CheckLeppaBerry(index, PokemonOnField[index].lastMoveSlot);
                break;
            case Yawn:
                PokemonOnField[index].yawnNextTurn = true;
                yield return Announce(MonNameWithPrefix(index, true) + " grew drowsy!");
                break;
            case Taunt:
                yield return GetTaunted(index);
                break;
            case Torment:
                yield return DoTorment(index);
                break;
            case MoveEffect.Embargo:
                yield return Embargo(index);
                break;
            case MoveEffect.Disable:
                yield return Disable(index);
                break;
            case Encore:
                yield return GetEncored(index);
                break;
            case Quash:
                yield return Announce(MonNameWithPrefix(index, true) +
                    "'s move was postponed!");
                PokemonOnField[index].quashed = true;
                break;
            case Instruct:
                PokemonOnField[index].done = false;
                PokemonOnField[index].goingNext = true;
                break;
            case CoreEnforcer:
                if (PokemonOnField[index].done) goto case MoveEffect.SuppressAbility;
                else break;
            case MoveEffect.SuppressAbility:
                yield return SuppressAbility(index);
                break;
            case Trap:
                yield return StartTrapping(attacker, index);
                break;
            case JawLock:
                PokemonOnField[index].trapped = true;
                PokemonOnField[index].trappingSlot = attacker;
                PokemonOnField[attacker].trapped = true;
                PokemonOnField[attacker].trappingSlot = index;
                yield return Announce(MonNameWithPrefix(attacker, true)
                    + " locked its jaws around " + MonNameWithPrefix(index, false) + "!");
                break;
            case ToxicThread:
                yield return GetPoison(index, false, attacker: attacker);
                goto case SpeedDown1;
            case HealBlock:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " can no longer heal!");
                PokemonOnField[index].healBlocked = true;
                PokemonOnField[index].healBlockTimer = 5;
                break;
            case Trick:
                yield return SwitchItems(attacker, index);
                break;
            case Bestow:
                yield return DoBestow(attacker, index);
                break;
            case RolePlay:
                yield return DoRolePlay(attacker, index);
                break;
            case SkillSwap:
                yield return DoSkillSwap(attacker, index);
                break;
            case Entrainment:
                yield return PopupDo(attacker, ChangeAbility(index, PokemonOnField[attacker].ability));
                break;
            case WorrySeed:
                yield return ChangeAbility(index, Insomnia);
                break;
            case SimpleBeam:
                yield return ChangeAbility(index, Simple);
                break;
            case Imprison:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " sealed any moves its target shares with it!");
                PokemonOnField[index].imprisoned = true;
                break;
            case Electrify:
                yield return Announce(MonNameWithPrefix(index, true) +
                    "'s moves have become electrified!");
                PokemonOnField[index].electrify = true;
                break;
            case SecretPower:
                if (terrain != Terrain.None) switch (terrain)
                    {
                        case Terrain.Electric:
                            yield return GetParalysis(index);
                            break;
                        case Terrain.Psychic:
                            yield return StatDown(index, Speed,
                                1, attacker);
                            break;
                        case Terrain.Misty:
                            yield return StatDown(index, SpAtk,
                                1, attacker);
                            break;
                        case Terrain.Grassy:
                            yield return FallAsleep(index, attacker);
                            break;
                    }
                else switch (battleTerrain)
                    {
                        case BattleTerrain.Building:
                        case BattleTerrain.Gym:
                            yield return GetParalysis(index);
                            break;
                        case BattleTerrain.Cave:
                        case BattleTerrain.Space:
                        case BattleTerrain.BurialGround:
                            TryToFlinch(index, attacker);
                            break;
                        case BattleTerrain.Sand:
                        case BattleTerrain.Rock:
                            yield return StatDown(index, Accuracy,
                                1, attacker);
                            break;
                        case BattleTerrain.Water:
                            yield return StatDown(index, Attack,
                                1, attacker);
                            break;
                        case BattleTerrain.Ice:
                        case BattleTerrain.Snow:
                            yield return GetFreeze(index);
                            break;
                        case BattleTerrain.Grass:
                        case BattleTerrain.Woods:
                        case BattleTerrain.Flowers:
                            yield return FallAsleep(index, attacker);
                            break;
                        case BattleTerrain.Volcano:
                            yield return GetBurn(index);
                            break;
                        case BattleTerrain.Marsh:
                        case BattleTerrain.Sky:
                        case BattleTerrain.Bridge:
                            yield return StatDown(index, Speed,
                                1, attacker);
                            break;
                        case BattleTerrain.UltraSpace:
                            yield return StatDown(index, Defense,
                                1, attacker);
                            break;
                    }
                break;
            case MoveEffect.BreakScreens:
                yield return DoBreakScreens(index);
                break;
            case Defog:
                yield return DoDefog(attacker, index);
                break;
            case LightScreen:
                if (!Sides[index / 3].lightScreen)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartLightScreen(index / 3);
                }
                break;
            case Reflect:
                if (!Sides[index / 3].reflect)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartReflect(index / 3);
                }
                break;
            case Haze:
                yield return DoHaze();
                break;
            case MoveEffect.HealBell:
                yield return HealBell(index);
                break;
            case AttackUp1:
                yield return StatUp(index, Attack, 1, attacker);
                break;
            case AttackUp2:
                yield return StatUp(index, Attack, 2, attacker);
                break;
            case FlowerShield:
            case DefenseUp1:
                yield return StatUp(index, Defense, 1, attacker);
                break;
            case DiamondStorm:
                int stages = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (random.NextDouble() < 0.5) stages++;
                }
                if (stages > 0) yield return StatUp(index, Defense, stages, attacker);
                break;
            case DefenseUp2:
                yield return StatUp(index, Defense, 2, attacker);
                break;
            case DefenseUp3:
                yield return StatUp(index, Defense, 3, attacker);
                break;
            case SpAtkUp1:
                yield return StatUp(index, SpAtk, 1, attacker);
                break;
            case SpAtkUp2:
                yield return StatUp(index, SpAtk, 2, attacker);
                break;
            case SpAtkUp3:
                yield return StatUp(index, SpAtk, 3, attacker);
                break;
            case SpDefUp1:
                yield return StatUp(index, SpDef, 1, attacker);
                break;
            case SpDefUp2:
                yield return StatUp(index, SpDef, 2, attacker);
                break;
            case SpeedUp1:
                yield return StatUp(index, Speed, 1, attacker);
                break;
            case SpeedUp2:
                yield return StatUp(index, Speed, 2, attacker);
                break;
            case EvasionUp1:
                yield return StatUp(index, Evasion, 1, attacker);
                break;
            case EvasionUp2:
                yield return StatUp(index, Evasion, 2, attacker);
                break;
            case CritRateUp2:
                yield return StatUp(index, CritRate, 2, attacker);
                break;
            case AttackDown1:
                yield return StatDown(index, Attack, 1, attacker);
                break;
            case AttackDown2:
                yield return StatDown(index, Attack, 2, attacker);
                break;
            case DefenseDown1:
                yield return StatDown(index, Defense, 1, attacker);
                break;
            case DefenseDown2:
                yield return StatDown(index, Defense, 2, attacker);
                break;
            case SpAtkDown1:
                yield return StatDown(index, SpAtk, 1, attacker);
                break;
            case SpAtkDown2:
            case Captivate:
                yield return StatDown(index, SpAtk, 2, attacker);
                break;
            case SpDefDown1:
                yield return StatDown(index, SpDef, 1, attacker);
                break;
            case SpDefDown2:
                yield return StatDown(index, SpDef, 2, attacker);
                break;
            case SpeedDown1:
                yield return StatDown(index, Speed, 1, attacker);
                break;
            case SpeedDown2:
                yield return StatDown(index, Speed, 2, attacker);
                break;
            case AccuracyDown1:
                yield return StatDown(index, Accuracy, 1, attacker);
                break;
            case EvasionDown2:
                yield return StatDown(index, Evasion, 2, attacker);
                break;
            case VenomDrench:
                yield return StatDown(index, Attack, 1, attacker);
                yield return StatDown(index, SpAtk, 1, attacker);
                yield return StatDown(index, Speed, 1, attacker);
                break;
            case Growth:
                switch (weather)
                {
                    case Sun:
                        yield return StatUp(index, Attack, 2, attacker);
                        yield return StatUp(index, SpAtk, 2, attacker);
                        break;
                    default:
                        yield return StatUp(index, Attack, 1, attacker);
                        yield return StatUp(index, SpAtk, 1, attacker);
                        break;
                }
                break;
            case ClangorousSoulblaze:
                if (PokemonOnField[index].moveDamageDone > 0) goto case AllUp1;
                else break;
            case AllUp1:
                yield return Omniboost();
                break;
            case AllUp2:
                yield return StatUp(index, Attack, 2, attacker);
                yield return StatUp(index, Defense, 2, attacker);
                yield return StatUp(index, SpAtk, 2, attacker);
                yield return StatUp(index, SpDef, 2, attacker);
                yield return StatUp(index, Speed, 2, attacker);
                break;
            case NoRetreat:
                yield return Omniboost();
                PokemonOnField[index].usedNoRetreat = true;
                yield return StartTrapping(index, index);
                break;
            case BellyDrum:
                yield return DoBellyDrum(index);
                break;
            case TarShot:
                yield return StatDown(index, Speed, 1, attacker);
                if (!PokemonOnField[index].tarShot)
                {
                    PokemonOnField[index].tarShot = true;
                    yield return Announce(MonNameWithPrefix(index, true) + " is covered in sticky tar!");
                }
                break;
            case Acupressure:
                List<Stat> possibleStats = new();
                for (int i = 1; i < (int)CritRate; i++)
                {
                    if (PokemonOnField[index].GetStatStage((Stat)i) > 6)
                    {
                        possibleStats.Add((Stat)i);
                    }
                }
                if (possibleStats.Count == 0) break;
                yield return StatUp(index,
                    possibleStats[(int)(random.NextDouble() * possibleStats.Count)],
                    2, index);
                break;
            case RapidSpin:
                yield return StatUp(index, Speed, 1, attacker);
                yield return RemoveHazards(index);
                break;
            case AttackDefenseUp1:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, Defense, 1, attacker);
                break;
            case AttackSpAtkUp1:
            case Rototiller:
            case GearUp:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, SpAtk, 1, attacker);
                break;
            case AttackSpeedUp1:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, Speed, 1, attacker);
                break;
            case AttackAccuracyUp1:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, Accuracy, 1, attacker);
                break;
            case DefenseSpDefUp1:
            case MagneticFlux:
                yield return StatUp(index, Defense, 1, attacker);
                yield return StatUp(index, SpDef, 1, attacker);
                break;
            case SpAtkSpDefUp1:
                yield return StatUp(index, SpAtk, 1, attacker);
                yield return StatUp(index, SpDef, 1, attacker);
                break;
            case AttackDefenseDown1:
                yield return StatDown(index, Attack, 1, index);
                yield return StatDown(index, Defense, 1, index);
                break;
            case AttackSpAtkDown1:
                yield return StatDown(index, Attack, 1, index);
                yield return StatDown(index, SpAtk, 1, index);
                break;
            case DefenseSpDefDown1:
                yield return StatDown(index, Defense, 1, attacker);
                yield return StatDown(index, SpDef, 1, attacker);
                break;
            case AttackUp1SpeedUp2:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, Speed, 2, attacker);
                break;
            case AttackDefAccUp1:
                yield return StatUp(index, Attack, 1, attacker);
                yield return StatUp(index, Defense, 1, attacker);
                yield return StatUp(index, Accuracy, 1, attacker);
                break;
            case SpAtkSpDefSpeedUp1:
                yield return StatUp(index, SpAtk, 1, attacker);
                yield return StatUp(index, SpDef, 1, attacker);
                yield return StatUp(index, Speed, 1, attacker);
                break;
            case DefSpDefSpeedDown1:
                yield return StatDown(index, Defense, 1, attacker);
                yield return StatDown(index, SpDef, 1, attacker);
                yield return StatDown(index, Speed, 1, attacker);
                break;
            case SpAtkSpDefSpeedUp2:
                yield return StatUp(index, SpAtk, 2, attacker);
                yield return StatUp(index, SpDef, 2, attacker);
                yield return StatUp(index, Speed, 2, attacker);
                break;
            case ShellSmash:
                yield return StatDown(index, Defense, 1, attacker);
                yield return StatDown(index, SpDef, 1, attacker);
                doStatAnim = true;
                yield return StatUp(index, Attack, 2, attacker);
                yield return StatUp(index, SpAtk, 2, attacker);
                yield return StatUp(index, Speed, 2, attacker);
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
                    yield return VoluntarySwitch(index, nextMon, true, true);
                    yield return EntryAbilityCheck(index);
                }
                break;
            case Minimize:
                PokemonOnField[index].minimized = true;
                goto case EvasionUp2;
            case DefenseCurl:
                PokemonOnField[index].usedDefenseCurl = true;
                goto case DefenseUp1;
            case ClearStats:
                PokemonOnField[index].ApplyStatStruct(new());
                yield return Announce(MonNameWithPrefix(index, true) + "'s stat changes were removed!");
                break;
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
                yield return StatUp(index, SpDef, 1, index);
                break;
            case MoveEffect.Round:
                doRound = true;
                break;
            case Flinch:
            case Snore:
            case FakeOut:
            case DoubleIronBash:
                TryToFlinch(index, attacker);
                break;
            case FlameBurst:
                int announceFlameBurst = 0;
                foreach (int i in GetNeighbors[index])
                {
                    if (MonIsActive(i) && !HasAbility(i, MagicGuard))
                    {
                        yield return PokemonOnField[i].DoProportionalDamage(0.0625F);
                        announceFlameBurst++;
                    }
                }
                if (announceFlameBurst > 0) yield return Announce("The flames damaged "
                    + MonNameWithPrefix(index, false) + "'s partner"
                    + (announceFlameBurst > 1 ? "s!" : "!"));
                break;
            case ThroatChop:
                PokemonOnField[index].throatChop = true;
                PokemonOnField[index].throatChopTurns = 2;
                break;
            case Stockpile:
                yield return DoStockpile(index);
                break;
            case Powder:
                yield return Announce(MonNameWithPrefix(index, true) + " is covered in powder!");
                PokemonOnField[index].powdered = true;
                break;
            case Swallow:
                yield return DoSwallow(index);
                break;
            case Memento:
                yield return StatDown(index, Attack, 2, attacker);
                yield return StatDown(index, SpAtk, 2, attacker);
                yield return DoFatalDamage(index);
                PokemonOnField[attacker].pokemon.fainted = true;
                break;
            case PartingShot:
                yield return StatDown(index, Attack, 1, attacker);
                yield return StatDown(index, SpAtk, 1, attacker);
                index = attacker;
                goto case SwitchHit;
            case MindReader:
                yield return GetMindReader(attacker, index);
                break;
            case LaserFocus:
                yield return Announce(MonNameWithPrefix(index, true) + " concentrated intensely!");
                PokemonOnField[index].laserFocusNext = true;
                break;
            case Foresight:
                yield return DoIdentify(index, false);
                break;
            case MiracleEye:
                yield return DoIdentify(index, true);
                break;
            case Telekinesis:
                yield return Announce(MonNameWithPrefix(index, true) + " was hurled into the air!");
                PokemonOnField[index].telekinesis = true;
                PokemonOnField[index].telekinesisTimer = 3;
                break;
            case Substitute:
                yield return MakeSubstitute(index);
                break;
            case PainSplit:
                yield return DoPainSplit(index, attacker);
                break;
            case PsychoShift:
                yield return DoPsychoShift(index, attacker);
                break;
            case Pluck:
                if (PokemonOnField[index].Item.Data().type == ItemType.Berry)
                {
                    yield return UseItemAnim(attacker);
                    yield return Announce(MonNameWithPrefix(attacker, true) +
                        " stole and ate " + MonNameWithPrefix(index, false) + "'s " +
                        PokemonOnField[index].Item.Data().itemName + "!");
                    yield return DoBerryEffect(attacker, PokemonOnField[index].Item.BerryEffect());
                    UseUpItem(index);
                    PokemonOnField[attacker].pokemon.canBelch = true;
                    yield return CheckSymbiosis(index);
                }
                break;
            case Incinerate:
                if (PokemonOnField[index].Item.Data().type == ItemType.Berry)
                {
                    yield return Announce(MonNameWithPrefix(attacker, true)
                       + " incinerated " + MonNameWithPrefix(index, false) + "'s "
                       + PokemonOnField[index].Item.Data().itemName + "!");
                    UseUpItem(index);

                    yield return CheckSymbiosis(index);
                }
                break;
            case FutureSight:
                yield return GetFutureSight(index, attacker);
                break;
            case Feint:
            case HyperspaceFury:
                if (PokemonOnField[index].Protect ||
                    Sides[GetSide(index)].wideGuard ||
                    Sides[GetSide(index)].quickGuard ||
                    Sides[GetSide(index)].matBlock ||
                    Sides[GetSide(index)].craftyShield)
                {
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " fell for the feint!");
                    if (PokemonOnField[index].protection is not Protection.MaxGuard)
                    {
                        PokemonOnField[index].protection = Protection.None;
                    }
                    Sides[GetSide(index)].wideGuard = false;
                    Sides[GetSide(index)].quickGuard = false;
                    Sides[GetSide(index)].matBlock = false;
                    Sides[GetSide(index)].craftyShield = false;
                }
                if (GetMove(index).effect is HyperspaceFury)
                {
                    index = attacker;
                    goto case DefenseDown1;
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
                yield return DoThief(attacker, index);
                break;
            case KnockOff:
                yield return DoKnockOff(attacker, index);
                break;
            case SmackDown:
            case ThousandArrows:
                yield return Announce(MonNameWithPrefix(index, true) +
                    " fell straight down!");
                PokemonOnField[index].smackDown = true;
                break;
            case Absorb50:
            case DreamEater:
                if (PokemonOnField[index].moveDamageDone == 0) break;
                bool doAnnouncement50 = !PokemonOnField[index].AtFullHealth;
                yield return Heal(index,
                    Max(1, PokemonOnField[index].moveDamageDone / 2));
                if (doAnnouncement50)
                {
                    if (battleType == BattleType.Single)
                    {
                        yield return Announce(MonNameWithPrefix(3 - index, true)
                            + BattleText.Absorb);
                    }
                }
                break;
            case Absorb75:
                if (PokemonOnField[index].moveDamageDone == 0) break;
                bool doAnnouncement75 = !PokemonOnField[index].AtFullHealth;
                yield return Heal(index,
                    Max(1, 3 * PokemonOnField[index].moveDamageDone / 4));
                if (doAnnouncement75)
                {
                    if (battleType == BattleType.Single)
                    {
                        yield return Announce(MonNameWithPrefix(3 - index, true)
                            + BattleText.Absorb);
                    }
                }
                break;
            case Absorb100:
                if (PokemonOnField[index].moveDamageDone == 0) break;
                bool doAnnouncement100 = !PokemonOnField[index].AtFullHealth;
                yield return Heal(index,
                    Max(1, PokemonOnField[index].moveDamageDone));
                if (doAnnouncement100)
                {
                    if (battleType == BattleType.Single)
                    {
                        yield return Announce(MonNameWithPrefix(3 - index, true)
                            + BattleText.Absorb);
                    }
                }
                break;
            case BurnUp:
                yield return Announce(MonNameWithPrefix(index, true) +
                    " burned itself out!");
                if (PokemonOnField[attacker].Type1 is Type.Fire)
                {
                    PokemonOnField[attacker].newType1 = Type.Typeless;
                    PokemonOnField[attacker].newType2 = PokemonOnField[attacker].Type2;
                    PokemonOnField[attacker].typesOverriden = true;
                }
                if (PokemonOnField[attacker].Type2 is Type.Fire)
                {
                    PokemonOnField[attacker].newType2 = Type.Typeless;
                    PokemonOnField[attacker].newType1 = PokemonOnField[attacker].Type1;
                    PokemonOnField[attacker].typesOverriden = true;
                }
                if (PokemonOnField[attacker].Type3 is Type.Fire)
                {
                    PokemonOnField[attacker].Type3 = Type.Typeless;
                    PokemonOnField[attacker].hasType3 = false;
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
                yield return StartUproar(index);
                break;
            case GenesisSupernova:
                yield return CreateTerrain(Terrain.Psychic, false);
                break;
            case SplinteredStormshards:
                yield return RemoveTerrain();
                break;
            case PayDay:
                if (!payDay)
                {
                    payDay = true;
                    yield return Announce("Coins were scattered everywhere!");
                }
                else if (ShowFailure)
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case HappyHour:
                if (!happyHour)
                {
                    happyHour = true;
                    yield return Announce("Everyone is caught up in the happy atmosphere!");
                }
                else if (ShowFailure)
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MoveEffect.PsychUp:
                yield return PsychUp(attacker, index);
                break;
            case MoveEffect.HeartSwap:
                yield return HeartSwap(attacker, index);
                break;
            case TopsyTurvy:
                PokemonOnField[index].InvertStatStages();
                yield return Announce(MonNameWithPrefix(index, true) +
                    "'s stat stages were all reversed!");
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
            case MoveEffect.GuardSplit:
                yield return GuardSplit(index, attacker);
                break;
            case MoveEffect.PowerSplit:
                yield return PowerSplit(index, attacker);
                break;
            case SpeedSwap:
                PokemonOnField[attacker].speedOverride = PokemonOnField[index].BaseSpeed;
                PokemonOnField[index].speedOverride = PokemonOnField[attacker].BaseSpeed;
                PokemonOnField[attacker].overrideSpeed = true;
                PokemonOnField[index].overrideSpeed = true;
                yield return Announce(MonNameWithPrefix(attacker, true) +
                    " swapped speed with its target!");
                break;
            case StrengthSap:
                int sappedAmount = PokemonOnField[index].Attack;
                yield return StatDown(index, Attack, 1, attacker);
                yield return Heal(attacker, sappedAmount);
                break;
            case Curse:
                yield return GhostCurse(attacker, index);
                yield return ProcessFaintingSingle(attacker);
                break;
            case MoveEffect.ForcedSwitch:
                yield return ForcedSwitch(index);
                break;
            case MoveEffect.Rest:
                yield return Rest(index);
                break;
            case Snatch:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " waits for a target to make a move!");
                snatch = true;
                snatchingMon = index;
                break;
            case Mimic:
                yield return DoMimic(attacker, index);
                break;
            case MoveEffect.Conversion:
                yield return Conversion(index);
                break;
            case MoveEffect.Conversion2:
                yield return Conversion2(index, Targets[index]);
                break;
            case MoveEffect.Camouflage:
                yield return Camouflage(index);
                break;
            case MoveEffect.ReflectType:
                yield return ReflectType(attacker, index);
                break;
            case Soak:
                yield return BecomeType(index, Type.Water);
                break;
            case MagicPowder:
                yield return BecomeType(index, Type.Psychic);
                break;
            case TrickOrTreat:
                yield return AddType3(index, Type.Ghost);
                break;
            case ForestsCurse:
                yield return AddType3(index, Type.Grass);
                break;
            case Recycle:
                yield return DoRecycle(index);
                break;
            case StuffCheeks:
                yield return DoStuffCheeks(index);
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
                yield return AnnounceProtect(index);
                PokemonOnField[index].protection = Protection.Protect;
                break;
            case WideGuard:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " protected its team!");
                Sides[GetSide(index)].wideGuard = true;
                break;
            case QuickGuard:
                yield return AnnounceProtect(index);
                Sides[GetSide(index)].quickGuard = true;
                break;
            case KingsShield:
                yield return AnnounceProtect(index);
                PokemonOnField[index].protection = Protection.KingsShield;
                break;
            case SpikyShield:
                yield return AnnounceProtect(index);
                PokemonOnField[index].protection = Protection.SpikyShield;
                break;
            case BanefulBunker:
                yield return AnnounceProtect(index);
                PokemonOnField[index].protection = Protection.BanefulBunker;
                break;
            case MatBlock:
                yield return Announce(MonNameWithPrefix(index, true) +
                   "intends to flip up a mat and block incoming attacks!");
                Sides[GetSide(index)].matBlock = true;
                break;
            case CraftyShield:
                yield return "Crafty Shield protected " +
                    (index > 2 ? "your" : "the opponent's") + " team!";
                Sides[GetSide(index)].craftyShield = true;
                break;
            case MaxGuard:
                yield return AnnounceProtect(index);
                PokemonOnField[index].protection = Protection.MaxGuard;
                break;
            case MoveEffect.AllySwitch:
                yield return AllySwitch(index, attacker);
                break;
            case Endure:
                yield return Announce(MonNameWithPrefix(index, true)
                    + " braced itself!");
                break;
            case MoveEffect.Ingrain:
                yield return Ingrain(index);
                break;
            case AquaRing:
                yield return StartAquaRing(index);
                break;
            case MagnetRise:
                PokemonOnField[index].magnetRise = true;
                PokemonOnField[index].magnetRiseTimer = 5;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " levitated with electromagnetism!");
                break;
            case Roost:
                PokemonOnField[index].roosting = true;
                goto case Heal50;
            case Heal50:
                yield return Heal(index, PokemonOnField[index].pokemon.hpMax >> 1);
                break;
            case HealPulse:
                yield return Heal(index, (PokemonOnField[index].pokemon.hpMax >> 1)
                    + (HasAbility(attacker, MegaLauncher) ? PokemonOnField[index].pokemon.hpMax >> 2 : 0));
                break;
            case HealWeather:
                yield return Heal(index, weather switch
                {
                    Sun => (PokemonOnField[index].pokemon.hpMax << 1) / 3,
                    None => PokemonOnField[index].pokemon.hpMax >> 1,
                    _ => PokemonOnField[index].pokemon.hpMax >> 2,
                });
                break;
            case ShoreUp:
                yield return Heal(index, weather switch
                {
                    Sand => (PokemonOnField[index].pokemon.hpMax << 1) / 3,
                    _ => PokemonOnField[index].pokemon.hpMax >> 1
                });
                break;
            case FloralHealing:
                yield return Heal(index, terrain switch
                {
                    Terrain.Grassy => (PokemonOnField[index].pokemon.hpMax << 1) / 3,
                    _ => PokemonOnField[index].pokemon.hpMax >> 1
                });
                break;
            case Wish:
                yield return MakeWish(index);
                break;
            case MoveEffect.HealStatus:
                yield return HealStatus(index);
                break;
            case Purify:
                yield return HealStatus(index);
                yield return Heal(attacker,
                    PokemonOnField[attacker].pokemon.hpMax >> 1);
                break;
            case HealingWish:
                healingWish[index] = true;
                yield return DoFatalDamage(index);
                PokemonOnField[index].pokemon.fainted = true;
                yield return ProcessFaintingSingle(index);
                break;
            case PerishSong:
                GetPerishSong(index);
                if (!oneAnnouncementDone)
                {
                    yield return Announce("All Pokémon that heard the song will faint in three turns!");
                }
                break;
            case Teatime:
                if (EffectiveItem(index).Data().type is not ItemType.Berry) yield break;
                yield return UseItemAnim(index);
                yield return DoBerryEffect(index, EffectiveItem(index).BerryEffect());
                UseUpItem(index);
                break;
            case Attract when CanInfatuate(attacker, index):
                yield return Infatuate(index, attacker);
                break;
            case MoveEffect.ContinuousDamage:
                yield return GetContinuousDamage(attacker, index, Moves[attacker]);
                break;
            case FollowMe:
                PokemonOnField[index].followMe = true;
                followMeActive = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became the center of attention!");
                break;
            case Spotlight:
                PokemonOnField[index].spotlight = true;
                followMeActive = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became the center of attention!");
                break;
            case RagePowder:
                PokemonOnField[index].wasRagePowder = true;
                goto case FollowMe;
            case MoveEffect.HelpingHand:
                yield return HelpingHand(attacker, index);
                break;
            case MagicCoat:
                yield return Announce(MonNameWithPrefix(index, true) + " shrouded itself with Magic Coat!");
                PokemonOnField[index].magicCoat = true;
                break;
            case Rainbow:
                yield return MakeRainbow(index);
                break;
            case Swamp:
                yield return MakeSwamp(index);
                break;
            case BurningField:
                yield return MakeBurningField(index);
                break;
            case MaxMove:
                {
                    IEnumerator LowerOpponentStats(Stat stat)
                    {
                        foreach (int i in GetAdjacentOpponents(attacker))
                        {
                            if (MonIsActive(i)) yield return StatDown(i, stat, 1, attacker);
                        }
                    }
                    IEnumerator RaiseFriendlyStats(Stat stat)
                    {
                        foreach (int i in GetMonAndNeighbors[attacker])
                        {
                            if (MonIsActive(i)) yield return StatUp(i, stat, 1, attacker);
                        }
                    }
                    yield return Moves[index] switch
                    {
                        MoveID.MaxFlare when weather is not Sun
                        or ExtremeSun or HeavyRain or StrongWinds
                        => StartWeather(Sun, 5), //Todo: Weather rocks
                        MoveID.MaxFlutterby => LowerOpponentStats(SpAtk),
                        MoveID.MaxLightning => CreateTerrain(Terrain.Electric, false), //Todo: Terrain extender
                        MoveID.MaxStrike => LowerOpponentStats(Speed),
                        MoveID.MaxKnuckle => RaiseFriendlyStats(Attack),
                        MoveID.MaxPhantasm => LowerOpponentStats(Defense),
                        MoveID.MaxHailstorm when weather is not Snow
                        or ExtremeSun or HeavyRain or StrongWinds
                        => StartWeather(Snow, 5), //Todo: weather rocks
                        MoveID.MaxOoze => RaiseFriendlyStats(SpAtk),
                        MoveID.MaxGeyser when weather is not Rain
                        or ExtremeSun or HeavyRain or StrongWinds
                        => StartWeather(Rain, 5), //Todo: weather rocks
                        MoveID.MaxAirstream => RaiseFriendlyStats(Speed),
                        MoveID.MaxStarfall => CreateTerrain(Terrain.Misty, false), //Todo: Terrain extender
                        MoveID.MaxWyrmwind => LowerOpponentStats(Attack),
                        MoveID.MaxMindstorm => CreateTerrain(Terrain.Psychic, false), //Todo: Terrain extender
                        MoveID.MaxRockfall when weather is not Sand
                        or ExtremeSun or HeavyRain or StrongWinds
                        => StartWeather(Sand, 5), //Todo: weather rocks
                        MoveID.MaxQuake => RaiseFriendlyStats(SpDef),
                        MoveID.MaxDarkness => LowerOpponentStats(SpDef),
                        MoveID.MaxOvergrowth => CreateTerrain(Terrain.Grassy, false), //Todo: terrain extender
                        MoveID.MaxSteelspike => RaiseFriendlyStats(Defense),
                        _ => throw new System.Exception("Wrong move has max move tag")
                    };
                    break;
                }
            case OHKO:
            case Hit:
            default:
                break;
        }
    }

    private IEnumerator DoProtectEffect(int protector, int attacker)
    {
        switch (PokemonOnField[protector].protection)
        {
            case Protection.KingsShield:
                yield return StatDown(attacker, Attack, 1, protector);
                break;
            case Protection.SpikyShield when !HasAbility(attacker, MagicGuard):
                yield return PokemonOnField[attacker].DoProportionalDamage(0.125F);
                yield return Announce(MonNameWithPrefix(attacker, true) +
                    " was hurt by Spiky Shield!");
                yield return ProcessFaintingSingle(attacker);
                break;
            case Protection.BanefulBunker:
                yield return GetPoison(attacker);
                break;
            default: yield break;
        }
    }

    private IEnumerator DoZMoveEffect(int index, ZMoveEffect effect)
    {
        BattlePokemon mon = PokemonOnField[index];
        if (index < 3) hasOpponentUsedZMove = true;
        else hasPlayerUsedZMove = true;
        doStatAnim = true;
        switch (effect)
        {
            case ZMoveEffect.None:
                break;
            case ZMoveEffect.AttackUp1:
                yield return StatUp(index, Attack, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.AttackUp2:
                yield return StatUp(index, Attack, 2, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.AttackUp3:
                yield return StatUp(index, Attack, 3, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.DefenseUp1:
                yield return StatUp(index, Defense, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpAtkUp1:
                yield return StatUp(index, SpAtk, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpAtkUp2:
                yield return StatUp(index, SpAtk, 2, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpDefUp1:
                yield return StatUp(index, SpDef, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpDefUp2:
                yield return StatUp(index, SpDef, 2, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpeedUp1:
                yield return StatUp(index, Speed, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.SpeedUp2:
                yield return StatUp(index, Speed, 2, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.AccuracyUp1:
                yield return StatUp(index, Accuracy, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.EvasionUp1:
                yield return StatUp(index, Evasion, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.CritRateUp2:
                yield return StatUp(index, CritRate, 2, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.AllUp1:
                yield return StatUp(index, Attack, 1, index, false, false);
                yield return StatUp(index, Defense, 1, index, false, false);
                yield return StatUp(index, SpAtk, 1, index, false, false);
                yield return StatUp(index, SpDef, 1, index, false, false);
                yield return StatUp(index, Speed, 1, index, false, false);
                doStatAnim = true;
                break;
            case ZMoveEffect.NormalizeDebuffs:
                mon.attackStage = Max(0, mon.attackStage);
                mon.defenseStage = Max(0, mon.defenseStage);
                mon.spAtkStage = Max(0, mon.spAtkStage);
                mon.spDefStage = Max(0, mon.spDefStage);
                mon.speedStage = Max(0, mon.speedStage);
                mon.accuracyStage = Max(0, mon.accuracyStage);
                mon.evasionStage = Max(0, mon.evasionStage);
                yield return Announce(MonNameWithPrefix(index, true) +
                    "'s lowered stats were returned to normal!");
                break;
            case ZMoveEffect.FollowMe:
                PokemonOnField[index].followMe = true;
                followMeActive = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became the center of attention!");
                break;
            case ZMoveEffect.Heal100:
                yield return Heal(index,
                    PokemonOnField[index].pokemon.hpMax, true);
                break;
            case ZMoveEffect.HealSwitchedMon100:
                zPowerHeal[index] = true;
                break;
            case ZMoveEffect.Curse:
                if (mon.HasType(Type.Ghost))
                    goto case ZMoveEffect.Heal100;
                else
                    goto case ZMoveEffect.AttackUp1;
        }
    }

    private IEnumerator DoFieldEffect(int index, MoveID move)
    {
        MoveEffect effect = move.Data().effect;
        if (move.Data().moveFlags.HasFlag(snatchAffected) && snatch)
        {
            yield return Announce(MonNameWithPrefix(snatchingMon, true)
                + " snatched " + MonNameWithPrefix(index, false)
                + "'s move!");
            index = snatchingMon;
        }
        for (int i = (1 - index / 3) * 3; i < (2 - index / 3) * 3; i++)
        {
            if (move.Data().moveFlags.HasFlag(magicBounceAffected))
            {
                if (PokemonOnField[i].magicCoat
                    || (HasAbility(i, MagicBounce) && !HasAbility(index, MoldBreaker)))
                {
                    //yield return MagicCoatActivates(index);
                    yield return Announce(MonNameWithPrefix(i, true) + " bounced back the move!");
                    index = i;
                    break;
                }
            }
        }
        switch (effect)
        {
            case Mist:
                if (!Sides[index / 3].mist)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartMist(index / 3);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MoveEffect.LuckyChant:
                if (!Sides[index / 3].luckyChant)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return LuckyChant(index / 3);
                }
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case LightScreen:
                if (!Sides[index / 3].lightScreen)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartLightScreen(index / 3);
                }
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case Reflect:
                if (!Sides[index / 3].reflect)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartReflect(index / 3);
                }
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case AuroraVeil:
                if (IsWeatherAffected(index, Snow) && !Sides[index / 3].auroraVeil)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartAuroraVeil(index / 3);
                }
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MoveEffect.Tailwind:
                if (!Sides[index / 3].tailwind)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Tailwind(index / 3);
                    for (int i = index / 3; i < index / 3 + 3; i++)
                    {
                        if (HasAbility(i, WindRider))
                        {
                            yield return PopupDo(index, StatUp(i, Attack, 1, i));
                        }
                    }
                }
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case Haze:
                yield return AttackerAnims(index, move, 0);
                yield return DoHaze();
                break;
            case MoveEffect.Weather:
                switch (weather)
                {
                    case HeavyRain:
                        yield return Announce("There is no relief from the heavy rain!");
                        PokemonOnField[index].moveFailedThisTurn = true;
                        break;
                    case ExtremeSun:
                        yield return Announce("The extremely harsh sunlight wasn't lessened at all!");
                        PokemonOnField[index].moveFailedThisTurn = true;
                        break;
                    case StrongWinds:
                        yield return Announce("The mysterious air current blows on regardless!");
                        PokemonOnField[index].moveFailedThisTurn = true;
                        break;
                    default:
                        switch (Moves[index])
                        {
                            //Todo: weather rocks
                            case MoveID.SunnyDay:
                                if (weather is not Sun)
                                {
                                    yield return AttackerAnims(index, move, 0);
                                    yield return StartWeather(Sun, 5);
                                }
                                else
                                {
                                    yield return Announce(BattleText.MoveFailed);
                                    PokemonOnField[index].moveFailedThisTurn = true;
                                }
                                break;
                            case MoveID.RainDance:
                                if (weather is not Rain)
                                {
                                    yield return AttackerAnims(index, move, 0);
                                    yield return StartWeather(Rain, 5);
                                }
                                else
                                {
                                    yield return Announce(BattleText.MoveFailed);
                                    PokemonOnField[index].moveFailedThisTurn = true;
                                }
                                break;
                            case MoveID.Sandstorm:
                                if (weather is not Sand)
                                {
                                    yield return AttackerAnims(index, move, 0);
                                    yield return StartWeather(Sand, 5);
                                }
                                else
                                {
                                    yield return Announce(BattleText.MoveFailed);
                                    PokemonOnField[index].moveFailedThisTurn = true;
                                }
                                break;
                            case MoveID.Hail:
                                if (weather is not Snow)
                                {
                                    yield return AttackerAnims(index, move, 0);
                                    yield return StartWeather(Snow, 5);
                                }
                                else
                                {
                                    yield return Announce(BattleText.MoveFailed);
                                    PokemonOnField[index].moveFailedThisTurn = true;
                                }
                                break;
                        }
                        break;
                }
                break;
            case ElectricTerrain:
                if (terrain is not Terrain.Electric)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return CreateTerrain(Terrain.Electric, false); //Todo: terrain extender
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case GrassyTerrain:
                if (terrain is not Terrain.Grassy)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return CreateTerrain(Terrain.Grassy, false); //Todo: terrain extender
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MistyTerrain:
                if (terrain is not Terrain.Misty)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return CreateTerrain(Terrain.Misty, false); //Todo: terrain extender
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case PsychicTerrain:
                if (terrain is not Terrain.Psychic)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return CreateTerrain(Terrain.Psychic, false); //Todo: terrain extender
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MoveEffect.HealBell:
                yield return AttackerAnims(index, move, 0);
                yield return HealBell(index);
                break;
            case Spikes:
                if (Sides[1 - index / 3].spikes < 3)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return DoSpikes(index);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case ToxicSpikes:
                if (Sides[1 - index / 3].toxicSpikes < 2)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return DoToxicSpikes(index);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case StealthRock:
                if (!Sides[1 - index / 3].stealthRock)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return DoStealthRock(index);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case StickyWeb:
                if (!Sides[1 - index / 3].stickyWeb)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return DoStickyWeb(index);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case CourtChange:
                yield return AttackerAnims(index, move, 0);
                (Sides[0], Sides[1]) = (Sides[1], Sides[0]);
                Sides[0].whichSide = false; Sides[1].whichSide = true;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " swapped the battle effects affecting each side!");
                (Sides[0].quickGuard, Sides[1].quickGuard) = (Sides[1].quickGuard, Sides[0].quickGuard);
                (Sides[0].wideGuard, Sides[1].wideGuard) = (Sides[1].wideGuard, Sides[0].wideGuard);
                (Sides[0].craftyShield, Sides[1].craftyShield) = (Sides[1].craftyShield, Sides[0].craftyShield);
                break;
            case Safeguard:
                if (!Sides[index / 3].safeguard)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return StartSafeguard(index);
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case IonDeluge:
                if (!ionDeluge)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Announce("A deluge of ions showers the battlefield!");
                    ionDeluge = true;
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MudSport:
                if (!mudSport)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Announce("Electricity's power was weakened!");
                    mudSport = true;
                    mudSportTimer = 5;
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case WaterSport:
                if (!waterSport)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Announce("Fire's power was weakened!");
                    waterSport = true;
                    waterSportTimer = 5;
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case MoveEffect.Gravity:
                if (!gravity)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Gravity();
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case FairyLock:
                if (!fairyLockNext)
                {
                    yield return AttackerAnims(index, move, 0);
                    yield return Announce("Nobody will be able to run away during the next turn!");
                    fairyLockNext = true;
                }
                else
                {
                    yield return Announce(BattleText.MoveFailed);
                    PokemonOnField[index].moveFailedThisTurn = true;
                }
                break;
            case TrickRoom:
                yield return AttackerAnims(index, move, 0);
                yield return StartTrickRoom(index);
                break;
            case WonderRoom:
                yield return AttackerAnims(index, move, 0);
                yield return StartWonderRoom();
                break;
            case MagicRoom:
                yield return AttackerAnims(index, move, 0);
                yield return StartMagicRoom();
                break;
            default:
                yield break;
        }
    }

    private void CleanStatSwaps(BattlePokemon mon)
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
            StartCoroutine(DoMegaEvolution(monToMega));
            return;
        }
        else
        {
            StartCoroutine(TryMove(index));
        }
    }

    private IEnumerator EndTurnAbilityCheck(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        switch (EffectiveAbility(index))
        {
            case DrySkin or SolarPower when IsSunAffected(index):
                yield return AbilityPopupStart(index);
                yield return mon.DoProportionalDamage(0.125F);
                yield return Announce(MonNameWithPrefix(index, true) + " is hurt by" +
                    NameTable.Ability[(int)EffectiveAbility(index)] + "!");
                yield return AbilityPopupEnd(index);
                yield return ProcessFaintingSingle(index);
                yield return CheckBerryCondition(index, false);
                break;
            case DrySkin when IsRainAffected(index):
                if (!mon.AtFullHealth)
                {
                    yield return AbilityPopupStart(index);
                    yield return Heal(index, mon.pokemon.hpMax << 3);
                    yield return Announce(MonNameWithPrefix(index, true) + " is healed by Dry Skin!");
                    yield return AbilityPopupEnd(index);
                }
                break;
            case RainDish when IsRainAffected(index):
            case IceBody when IsWeatherAffected(index, Snow):
                if (!mon.AtFullHealth)
                {
                    yield return AbilityPopupStart(index);
                    yield return Heal(index, mon.pokemon.hpMax << 4);
                    yield return Announce(MonNameWithPrefix(index, true) + " is healed by"
                        + NameTable.Ability[(int)EffectiveAbility(index)] + "!");
                    yield return AbilityPopupEnd(index);
                }
                break;
            case ShedSkin when random.Next(3) is 0:
            case Hydration when IsRainAffected(index):
                if (mon.pokemon.status != Status.None)
                    yield return PopupDo(index, HealStatus(index));
                break;
            case Healer:
                foreach (int i in GetNeighbors[index])
                {
                    if (!MonIsActive(i) || PokemonOnField[i].pokemon.status is Status.None) continue;
                    if (random.Next(10) < 3) yield return PopupDo(index, HealStatus(i));
                }
                break;
            case BadDreams:
                foreach (int i in GetAdjacentOpponents(index))
                {
                    if (!MonIsActive(i) || (PokemonOnField[i].pokemon.status is not Status.Sleep && !HasAbility(i, Comatose))) continue;
                    yield return PopupDo(index, DoDamage(PokemonOnField[i].pokemon, PokemonOnField[i].pokemon.hpMax >> 3));
                }
                yield return ProcessFainting();
                break;
            case SpeedBoost:
                yield return PopupDo(index, StatUp(index, Speed, 1, index));
                break;
            case Schooling:
                if (mon.ApparentSpecies is SpeciesID.WishiwashiSchool &&
                    mon.pokemon.hp << 2 < mon.pokemon.hpMax)
                    yield return PopupDo(index, Transform(index, SpeciesID.Wishiwashi));
                else if (mon.ApparentSpecies is SpeciesID.Wishiwashi &&
                    mon.pokemon.hp << 2 >= mon.pokemon.hpMax &&
                    mon.pokemon.level >= 20)
                    yield return PopupDo(index, Transform(index, SpeciesID.WishiwashiSchool));
                break;
            case Moody:
                yield return AbilityPopupStart(index);
                int raisedStat = random.Next(5) + 1;
                int loweredStat = random.Next(4) + 1;
                if (loweredStat == raisedStat) loweredStat = 5;
                yield return StatUp(index, (Stat)raisedStat, 2, index);
                yield return StatDown(index, (Stat)loweredStat, 1, index);
                yield return AbilityPopupEnd(index);
                break;
            case Harvest when PokemonOnField[index].eatenBerry is not ItemID.None &&
                    (IsSunAffected(index) || random.Next(2) is 0):
                yield return PopupDo(index, DoRecycle(index));
                break;
            case ZenMode:
                yield return CheckZenMode(index);
                break;
            case PowerConstruct when PokemonOnField[index].ApparentSpecies is not SpeciesID.ZygardeComplete:
                int originalHPMax = PokemonOnField[index].pokemon.hpMax;
                yield return AbilityPopupStart(index);
                yield return Announce("You sense the presence of many!");
                yield return Transform(index, SpeciesID.ZygardeComplete);
                yield return DoDamage(PokemonOnField[index].pokemon,
                    PokemonOnField[index].pokemon.hpMax - originalHPMax); //Heal based on HP gained
                yield return AbilityPopupEnd(index);
                break;
            case CudChew:
                if (mon.turnsToCudChew-- == 1)
                {
                    yield return PopupDo(index, DoBerryEffect(index, mon.cudChewEffect, true));
                }
                break;
            default:
                break;
        }
    }

    private IEnumerator CheckZenMode(int index) //Todo: Galarian forms
    {
        BattlePokemon mon = PokemonOnField[index];
        switch (mon.pokemon.GetSpecies)
        {
            case SpeciesID.Darmanitan:
                if (mon.pokemon.hp << 1 < mon.pokemon.hpMax)
                    yield return Transform(index, SpeciesID.DarmanitanZen);
                break;
            case SpeciesID.DarmanitanZen:
                if (mon.pokemon.hp << 1 >= mon.pokemon.hpMax)
                    yield return Transform(index, SpeciesID.Darmanitan);
                break;
            default: break;
        }
    }

    private IEnumerator EndTurn()
    {
        if (weather != None)
        {
            yield return WeatherContinues();
        }
        if (terrain != Terrain.None)
        {
            if (--terrainTimer <= 0) yield return RemoveTerrain();
        }
        for (int i = 0; i < 6; i++)
        {
            if (!PokemonOnField[i].exists) continue;
            BattlePokemon mon = PokemonOnField[i];
            yield return EndTurnAbilityCheck(i);
            if (mon.pokemon.fainted) continue;
            if (!HasAbility(i, MagicGuard))
            {
                switch (mon.pokemon.status)
                {
                    case Status.Burn:
                        yield return BurnHurt(i);
                        break;
                    case Status.Poison:
                        yield return PoisonHurt(i);
                        break;
                    case Status.ToxicPoison:
                        yield return ToxicPoisonHurt(i);
                        break;
                }
                yield return ProcessFaintingSingle(i);
                if (mon.pokemon.fainted) { continue; }
                if (IsWeatherAffected(i, Sand) &&
                    !mon.HasType(Type.Ground) && !mon.HasType(Type.Steel) &&
                    !mon.HasType(Type.Rock) &&
                    EffectiveAbility(i) is not SandForce or SandRush or
                    SandVeil or Overcoat)
                {
                    yield return mon.DoProportionalDamage(mon.pokemon.hpMax << 4);
                    yield return DoHitFlash(i);
                    yield return Announce(MonNameWithPrefix(i, true)
                        + " is buffeted by the sandstorm!");
                }
                yield return ProcessFaintingSingle(i);
                if (mon.pokemon.fainted) { continue; }
                if (mon.perishSong)
                {
                    yield return DoPerishSong(i);
                }
                yield return ProcessFaintingSingle(i);
                if (mon.pokemon.fainted) { continue; }
                if (mon.partialTrapped)
                {
                    yield return DoContinuousDamage(i, mon.partialTrappingType);
                }
                yield return ProcessFaintingSingle(i);
                yield return CheckBerryCondition(i, false);
                if (mon.pokemon.fainted) { continue; }
                if (mon.nightmare)
                {
                    yield return DoNightmare(i);
                }
                yield return ProcessFaintingSingle(i);
                yield return CheckBerryCondition(i, false);
                if (mon.pokemon.fainted) { continue; }
                if (mon.seeded)
                {
                    yield return DoLeechSeed(i);
                }
                yield return ProcessFainting();
                yield return CheckBerryCondition(i, false);
                if (mon.pokemon.fainted) { continue; }
                if (mon.cursed)
                {
                    yield return DoCurse(i);
                }
                yield return ProcessFaintingSingle(i);
                yield return CheckBerryCondition(i, false);
                if (mon.pokemon.fainted) { continue; }
            }
            if (mon.ingrained && !mon.AtFullHealth && !mon.healBlocked)
            {
                //Todo: yield return IngrainHeal(i);
                yield return Heal(i,
                    Max(1, mon.pokemon.hpMax >> 4));
                yield return Announce(MonNameWithPrefix(i, true)
                    + " absorbed nutrients with its roots!");
            }
            if (IsTerrainAffected(i, Terrain.Grassy) &&
                !mon.AtFullHealth && !mon.healBlocked)
            {
                yield return Heal(i,
                    Max(1, mon.pokemon.hpMax >> 4));
                yield return Announce(MonNameWithPrefix(i, true) +
                    " is healed by the Grassy Terrain!");
            }
            if (mon.hasAquaRing && !mon.AtFullHealth && !mon.healBlocked)
            {
                //Todo: yield return AquaRingHeal(i);
                yield return Heal(i,
                    Max(1, mon.pokemon.hpMax >> 4));
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
            if (mon.magnetRise)
            {
                if (mon.magnetRiseTimer-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true)
                        + "'s Magnet Rise wore off!");
                    mon.magnetRise = false;
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
            if (mon.throatChop)
            {
                if (mon.throatChopTurns-- <= 1)
                {
                    yield return Announce(MonNameWithPrefix(i, true) +
                        " is freed from Throat Chop!");
                    mon.throatChop = false;
                }
            }
            if (mon.yawnThisTurn && mon.pokemon.status == Status.None
                && !UproarOnField)
            {
                yield return FallAsleep(i);
                yield return CheckBerryCondition(i, false);
            }
            mon.yawnThisTurn = mon.yawnNextTurn;
            mon.yawnNextTurn = false;
            switch (EffectiveItem(i).HeldEffect())
            {
                case HeldEffect.Leftovers when !mon.healBlocked:
                    yield return UseItemAnim(i);
                    yield return Heal(i, mon.pokemon.hpMax >> 4);
                    yield return Announce(MonNameWithPrefix(i, true) + " healed some HP using its Leftovers!");
                    break;
                case HeldEffect.ToxicOrb when CanStatus(i, Status.ToxicPoison, i): //Pass i as attacker to handle Corrosion
                    yield return UseItemAnim(i);
                    yield return GetBadPoison(i);
                    break;
                case HeldEffect.FlameOrb when CanStatus(i, Status.Burn):
                    yield return UseItemAnim(i);
                    yield return GetBurn(i);
                    break;
                default:
                    break;
            }
        }
        while (wishes.Count > 0)
            if (wishes.Peek().turn == turnsElapsed) yield return GetWish();
            else break;
        while (futureSight.Count > 0)
            if (futureSight.Peek().turn == turnsElapsed)
            {
                sheerForceBoosted = false;
                yield return FutureSightAttack();
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
            if (Sides[i].burningField)
            {
                Sides[i].burningFieldTurns--;
                if (Sides[i].burningFieldTurns <= 0)
                {
                    Sides[i].burningField = false;
                    yield return Announce("The burning field around "
                        + (i == 0 ? "the foe's Pokémon" : "your Pokémon")
                        + " wore off!");
                }
                else
                {
                    foreach (BattlePokemon mon in Sides[i].Mons)
                    {
                        if (mon.exists && !mon.HasType(Type.Fire) &&
                            !HasAbility(mon.index, MagicGuard))
                        {
                            yield return mon.DoProportionalDamage(0.125F);
                            yield return Announce(MonNameWithPrefix(mon.index, true)
                                + " is hurt by the burning field!");
                            yield return ProcessFaintingSingle(mon.index);
                        }
                    }
                }
            }
            if (Sides[i].rainbow)
            {
                Sides[i].rainbowTurns--;
                if (Sides[i].rainbowTurns <= 0)
                {
                    Sides[i].rainbow = false;
                    yield return Announce("The rainbow above " +
                        (i == 0 ? "the foes'" : "your") +
                        " Pokémon disappeared!");
                }
            }
            if (Sides[i].swamp)
            {
                Sides[i].swampTurns--;
                if (Sides[i].swampTurns <= 0)
                {
                    Sides[i].swamp = false;
                    yield return Announce("The swamp around " +
                        (i == 0 ? "the foes'" : "your") +
                        " Pokémon disappeared!");
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
        if (wonderRoom)
            if (wonderRoomTimer-- <= 1)
            {
                yield return Announce("The effects of Wonder Room wore off!");
                wonderRoom = false;
            }
        if (magicRoom)
            if (magicRoomTimer-- <= 1)
            {
                yield return Announce("The effects of Magic Room wore off!");
                magicRoom = false;
            }
        turnsElapsed++;
        yield return StartTurn();
    }

    private Stat GetTopStat(int index, bool useStatStages)
    {
        Stat currentStat = Attack;
        int highestStat = GetAttack(index, false, false, !useStatStages);
        int testingStat = GetDefense(index, false, !useStatStages);
        if (testingStat > highestStat)
        {
            highestStat = testingStat;
            currentStat = Defense;
        }
        testingStat = GetSpAtk(index, false, false, !useStatStages);
        if (testingStat > highestStat)
        {
            highestStat = testingStat;
            currentStat = SpAtk;
        }
        testingStat = GetSpdef(index, false, !useStatStages);
        if (testingStat > highestStat)
        {
            highestStat = testingStat;
            currentStat = SpDef;
        }
        testingStat = GetSpeed(index, false, !useStatStages);
        if (testingStat > highestStat)
        {
            currentStat = Speed;
        }
        return currentStat;
    }

    private IEnumerator StartTurn()
    {
        state = BattleState.Announcement;
        menuManager.GoToAnnounce();
        followMeActive = false;
        snatch = false;
        doRound = false;
        ionDeluge = false;
        fairyLockNow = fairyLockNext;
        fairyLockNext = false;

        if (echoedVoiceUsed)
        { if (echoedVoiceIntensity < 4) echoedVoiceIntensity++; }
        else echoedVoiceIntensity = 0;
        echoedVoiceUsed = false;

        switch (battleType)
        {
            case BattleType.Single:
                if (!PokemonOnField[0].exists)
                {
                    int nextMon = GetNextOpponentMonSingle();
                    if (nextMon == NoMons)
                    {
                        yield return EndBattle();
                        yield break;
                    }
                    else
                    {
                        yield return BringToField(opponentPokemon[nextMon], nextMon, 0, false);
                        doAbilityEffect[0] = true;
                    }
                }
                if (!PokemonOnField[3].exists)
                {
                    switchingMon = 3;
                    choseSwitchMon = false;
                    menuManager.currentPartyMon = 1;
                    menuManager.PartyMenu(MenuManager.PartyScreenReason.SwitchingMove);
                    state = BattleState.PlayerInput;
                    while (!choseSwitchMon)
                    {
                        yield return new WaitForSeconds(0.05F);
                    }
                    yield return VoluntarySwitch(3, switchingTarget, true, false);
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
                currentMon.protection = Protection.None;
                currentMon.endure = false;
                currentMon.magicCoat = false;
                currentMon.moveUsedLastTurn = currentMon.moveUsedThisTurn;
                currentMon.moveUsedThisTurn = MoveID.None;
                currentMon.damagedThisTurn = false;

                currentMon.helpingHand = 0;
                currentMon.followMe = false;
                currentMon.wasRagePowder = false;
                currentMon.spotlight = false;
                currentMon.roosting = false;
                currentMon.quashed = false;
                currentMon.goingNext = false;

                currentMon.moveFailedLastTurn = currentMon.moveFailedThisTurn;
                currentMon.moveFailedThisTurn = false;

                currentMon.beakBlast = false;

                (currentMon.laserFocusNow, currentMon.laserFocusNext) =
                    (currentMon.laserFocusNext, false);

                currentMon.damagedByMon = new bool[6];

                currentMon.flinched = false;

                currentMon.electrify = false;

                currentMon.turnOnField++;
                currentMon.timeWithAbility++;

                if (HasAbility(i, Truant))
                {
                    currentMon.truantThisTurn = currentMon.truantNextTurn;
                    currentMon.truantNextTurn = !currentMon.truantNextTurn;
                }
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
        foreach (Side side in Sides)
        {
            side.wideGuard = false;
            side.quickGuard = false;
            side.matBlock = false;
            side.craftyShield = false;
            side.retaliateNow = side.retaliateNext;
            side.retaliateNext = false;
            side.currentPledge = Pledge.None;
        }
        if (!menuManager.GetNextPokemon())
        {
            menuManager.MainMenu();
            menuManager.megaEvolving = false;
            menuManager.usingZMove = false;
            state = BattleState.PlayerInput;
        }
        else
        {
            DoNextMove();
        }
    }

    private IEnumerator AbilityPopupStart(int index) =>
        ScriptUtils.Wait(0.2F).Join(abilityControllers[index].Summon(PokemonOnField[index].pokemon.MonName,
            NameTable.Ability[(int)PokemonOnField[index].ability]).Join(ScriptUtils.Wait(0.3F)));

    private IEnumerator AbilityPopupEnd(int index) => abilityControllers[index].Dismiss();

    private int GetNextOpponentMonSingle()
    {
        for (int i = 0; i < 6; i++)
        {
            if (opponentPokemon[i].fainted == false && opponentPokemon[i].exists && !opponentPokemon[i].onField)
            {
                return i;
            }
        }
        return NoMons;
    }

    public IEnumerator StartBattle()
    {
        payDay = false;
        happyHour = false;
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
        isFutureSightTargeted = new bool[6];
        turnsElapsed = 0;
        doAbilityEffect = new bool[6];
        menuOpen = false;
        hasPlayerMegaEvolved = false;
        hasOpponentMegaEvolved = false;
        hasPlayerUsedZMove = false;
        hasOpponentUsedZMove = false;
        menuManager.GoToAnnounce();
        PokemonOnField = new BattlePokemon[6]
        {
            BattlePokemon.MakeEmptyBattleMon(0,this),
            BattlePokemon.MakeEmptyBattleMon(1,this),
            BattlePokemon.MakeEmptyBattleMon(2,this),
            BattlePokemon.MakeEmptyBattleMon(3,this),
            BattlePokemon.MakeEmptyBattleMon(4,this),
            BattlePokemon.MakeEmptyBattleMon(5,this),
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
                + Species.SpeciesTable[(int)playerPokemon[i].species].graphicsLocation
                + "/icon"), new Rect(0.0F, 32.0F, 32.0F, 32.0F), StaticValues.defPivot,
                64);
            playerMonIcons2[i] = Sprite.Create(
                Resources.Load<Texture2D>("Sprites/Pokemon/"
                + Species.SpeciesTable[(int)playerPokemon[i].species].graphicsLocation
                + "/icon"), new Rect(0.0F, 0.0F, 32.0F, 32.0F), StaticValues.defPivot,
                64);
            playerPokemon[i].itemChanged = false;
            playerPokemon[i].canBelch = false;
            playerPokemon[i].switchedOut = false;
            playerPokemon[i].activatedAbilities = new();
        }
        if (battleType == BattleType.Single)
        {
            int firstMon = 0;
            for (int i = 0; i < 6; i++)
            {
                if (!playerPokemon[i].fainted)
                {
                    firstMon = i;
                    break;
                }
            }
            if (wildBattle)
            {
                PokemonOnField[0] = new BattlePokemon(opponentPokemon[0], 0, false, this);
                yield return Announce("A wild " + PokemonOnField[0].pokemon.MonName + " appeared!");
            }
            else
                yield return BringToField(opponentPokemon[0], 0, 0, false);
            yield return BringToField(playerPokemon[firstMon], firstMon, 3, true);
            doAbilityEffect[0] = true;
            doAbilityEffect[3] = true;
            yield return DoEntryAbilitiesAtStartOfTurn();
        }
        StartCoroutine(StartTurn());
        yield break;
    }

    private IEnumerator BringToField(Pokemon pokemonData, int partyIndex, int index, bool player)
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
                    yield return Announce(opponentName + " sent out " + pokemonData.MonName + "!");
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index, false, this);
                    break;
                case true:
                    yield return Announce("Go! " + pokemonData.MonName + "!");
                    PokemonOnField[index] = new BattlePokemon(pokemonData, index, true, this);
                    break;
            }
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].pokemon.SpeciesData.cryLocation));
            audioSource0.panStereo = player ? -0.5F : 0.5F;
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            yield return MonEntersField(index);
        }
    }

    private IEnumerator DoEntryAbilitiesAtStartOfTurn()
    {
        Debug.Log("Entry abilities");
        while (true)
        {
            List<int> speedTieList = new();
            int speed = int.MinValue;
            for (int i = 0; i < 6; i++)
            {
                if (doAbilityEffect[i])
                {
                    if (GetSpeed(i) > speed)
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

    private IEnumerator ExitAbilityCheck(int index) //This may change the mon's ability to None, cache their ability if it needs to be read later
    {
        if (PokemonOnField[index].ability is NeutralizingGas)
        {
            PokemonOnField[index].ability = None;
            if (!AbilitiesSuppressed)
            {
                yield return Announce("The effects of the neutralizing gas wore off!");
                List<int> speedList = new();
                for (int i = 0; i < 6; i++)
                {
                    if (i == index) continue;
                    if (MonIsActive(i)) speedList.Add(i);
                }
                foreach (int i in speedList.OrderByDescending(i => GetSpeed(i, true)).ThenBy(_ => random.Next()))
                    yield return EntryAbilityCheck(i);
            }
        }
        switch (EffectiveAbility(index))
        {
            case PrimoridialSea:
                PokemonOnField[index].ability = None;
                if (weather is HeavyRain && !AbilityOnField(PrimoridialSea)) yield return WeatherEnds();
                break;
            case DesolateLand:
                PokemonOnField[index].ability = None;
                if (weather is ExtremeSun && !AbilityOnField(DesolateLand)) yield return WeatherEnds();
                break;
            case DeltaStream:
                PokemonOnField[index].ability = None;
                if (weather is StrongWinds && !AbilityOnField(DeltaStream)) yield return WeatherEnds();
                break;
            case Schooling when !PokemonOnField[index].pokemon.fainted &&
              PokemonOnField[index].ApparentSpecies is SpeciesID.WishiwashiSchool:
                yield return Transform(index, SpeciesID.Wishiwashi);
                break;
        }
    }

    private void HandleFacing(int index)
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
            BattlePokemon mon = PokemonOnField[index];
            MoveID moveid = mon.GetMove(move - 1);
            if (usingZMove[index] &&
                moveid.Data().power > 0)
            {
                mon.zMoveBase = moveid;
                Moves[index] = mon.pokemon.CurrentItem.ZMoveResult(
                    moveid.Data().physical);
            }
            else Moves[index] = moveid;
            MoveNums[index] = move;
            if (battleType == BattleType.Single) Targets[index] = 3 - index;
            return true;
        }
        else return false;
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
        return PokemonOnField[index].pokemon.move1;
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
            announcer.text = announcement[..i];
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
        announcer.text = "";
    }

    private bool MegaEvolutionLockedIn(bool side)
    {
        for (int i = side ? 3 : 0; i < (side ? 6 : 3); i++)
        {
            if (PokemonOnField[i].choseMove && megaEvolveOnMove[i]) return true;
        }
        return false;
    }

    public bool CanMegaEvolve(int index)
    {
        if (index < 3)
        {
            Debug.Log("Has Opponent evolved: " + hasOpponentMegaEvolved);
            Debug.Log("Opponent's mega stone's user: " + EffectiveItem(index).MegaStoneUser());
        }
        if (index > 2 && (hasPlayerMegaEvolved || MegaEvolutionLockedIn(true)))
            return false;
        if (index < 3 && (hasOpponentMegaEvolved || MegaEvolutionLockedIn(false)))
            return false;
        if (EffectiveItem(index).MegaStoneUser() == PokemonOnField[index].pokemon.GetSpecies) return true;
        else if (PokemonOnField[index].pokemon.species == SpeciesID.Rayquaza
                && PokemonOnField[index].pokemon.HasMove(MoveID.DragonAscent)
                && EffectiveItem(index).Data().type is not
                ItemType.ZCrystalGeneric or ItemType.ZCrystalSpecific or
                ItemType.ZCrystalMoveSpecific)
            return true;
        else return false;
    }

    private IEnumerator DoMegaEvolution(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        //Todo: Add mega animation
        StartCoroutine(MegaEvolution(index)); //0.00 - 3.90
        yield return new WaitForSeconds(1.8F); //1.80
        megaEvolveOnMove[index] = false;
        if (index > 2) hasPlayerMegaEvolved = true;
        else hasOpponentMegaEvolved = true;
        mon.pokemon.temporarySpecies =
            mon.pokemon.species == SpeciesID.Rayquaza ?
            SpeciesID.RayquazaMega :
            (SpeciesID)EffectiveItem(index).Data().ItemSubdata[1];
        CleanStatSwaps(mon);
        mon.pokemon.transformed = true;
        yield return new WaitForSeconds(1.8F); //3.60
        Cry(mon.pokemon.GetSpecies, audioSource0);
        yield return new WaitForSeconds(1.0F); //4.60
        yield return Announce(MonNameWithPrefix(index, true) + " has Mega Evolved into "
            + mon.pokemon.SpeciesData.speciesName + "!");
        if (mon.ability != mon.pokemon.SpeciesData.abilities[0])
        {
            mon.ability = mon.pokemon.SpeciesData.abilities[0];
            mon.timeWithAbility = 0;
        }
        yield return EntryAbilityCheck(index);
        megaEvolveOnMove[index] = false;
        DoNextMove();
    }

    public bool CanUseZMove(int index, int moveSlot)
    {
        if (moveSlot < 0) return false;
        Pokemon mon = PokemonOnField[index].pokemon;
        if (mon.PP[moveSlot] < 1) return false;
        if (index > 2 && (hasPlayerUsedZMove ||
            usingZMove[3] || usingZMove[4] || usingZMove[5]))
            return false;
        if (index < 3 && (hasOpponentUsedZMove ||
            usingZMove[0] || usingZMove[1] || usingZMove[2]))
            return false;
        if (mon.MoveIDs[moveSlot].Data().type == mon.CurrentItem.ZMoveType())
            return true;
        if (mon.MoveIDs[moveSlot] == mon.CurrentItem.ZMoveBase())
        {
            if (mon.species == mon.CurrentItem.ZMoveUser()) return true;
            if (mon.CurrentItem.Data().type is ItemType.ZCrystalMultipleSpecies)
            {
                Debug.Log("Checking Z-Move users");
                ZCrystalMultipleSpecies item = (ZCrystalMultipleSpecies)mon.CurrentItem.Data();
                foreach (SpeciesID species in item.users)
                {
                    if (mon.GetSpecies == species) return true;
                    else Debug.Log(mon.GetSpecies.Data().speciesName + " is not " + species.Data().speciesName);
                }
            }
        }
        return false;
    }

    public IEnumerator TryToRun()
    {
        state = BattleState.Announcement;
        menuManager.GoToAnnounce();
        int playerSpeed = PokemonOnField[3].pokemon.speed;
        int opponentSpeed = PokemonOnField[0].pokemon.speed;
        if (HasAbility(3, RunAway) ||
            playerSpeed > opponentSpeed ||
            (random.Next() & 255) < ((playerSpeed * 128 / opponentSpeed + 30 * escapeAttempts) & 255))
        {
            yield return Announce("Got away safely!");
            yield return EndBattle();
            yield break;
        }
        else
        {
            yield return Announce("Can't escape!");
            escapeAttempts++;
            menuManager.CleanForTurnStart();
            PokemonOnField[3].done = true; PokemonOnField[4].done = true; PokemonOnField[5].done = true;
            DoNextMove();
        }
    }

    private void EndBattleAbilityCheck(Pokemon mon)
    {
        switch (mon.GetAbility)
        {
            case HoneyGather when mon.item is None && random.Next(20) < (mon.level + 9) / 10:
                mon.item = Honey;
                return;
            default: return;
        }
    }

    private IEnumerator EndBattle()
    {
        for (int i = 0; i < 6; i++) LeaveFieldCleanup(i);
        foreach (Pokemon mon in player.Party) if (mon.exists) EndBattleAbilityCheck(mon);
        if (wildBattle)
        {
            player.StartCoroutine(player.WildBattleWon());
            while (true) yield return null;
        }
        else
        {
            yield return Announce("Defeated " + opponentName + "!");
            yield return Announce(player.name + " got $" + prizeMoney + " for winning!");
            player.money += prizeMoney;
            player.StartCoroutine(player.TrainerBattleWon());
            while (true) yield return null;
        }
    }

    private int losingPrizeMoney
    {
        get
        {
            int topLevel = 1;
            foreach (Pokemon mon in player.Party)
            {
                if (!mon.exists) continue;
                if (mon.level > topLevel) topLevel = mon.level;
            }
            int multiplier = 8;
            //Todo: badge formula
            return topLevel * multiplier;
        }
    }

    private IEnumerator LostBattle()
    {
        yield return Announce(player.playerName + " has no more Pokémon that can fight!");
        int losingMoney = losingPrizeMoney;
        yield return Announce("Paid out $" + losingMoney + " to the winner...");
        player.money -= losingMoney;
        yield return Announce("... ...");
        yield return Announce(player.playerName + " blacked out!");
        //Todo: player portion of script
    }

    private void Start()
    {
        audioSource0 = gameObject.AddComponent<AudioSource>();
        audioSource1 = gameObject.AddComponent<AudioSource>();
    }
}