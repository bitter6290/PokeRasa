using System.Collections;
using System.Collections.Generic;
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

    public string OpponentName = "Null";

    public TextMeshProUGUI Announcer;

    public MaskManager[] maskManager;
    public MenuManager menuManager;

    public SpriteRenderer[] spriteRenderer;
    public Transform[] spriteTransform;

    public AudioSource audioSource;

    public bool[] megaEvolveOnMove = new bool[6];
    public bool hasPlayerMegaEvolved = false;
    public bool hasOpponentMegaEvolved = false;

    public int textSpeed = 25;
    public float persistenceTime = 1.5F;

    private int currentIndex;

    // Field varibles

    public bool payDay;

    public Weather weather;
    public byte weatherTimer;
    public Terrain terrain;
    public byte terrainTimer;

    public BattlePokemon[] PokemonOnField = new BattlePokemon[6]
    {
        BattlePokemon.MakeEmptyBattleMon(false,0),
        BattlePokemon.MakeEmptyBattleMon(false,1),
        BattlePokemon.MakeEmptyBattleMon(false,2),
        BattlePokemon.MakeEmptyBattleMon(true,0),
        BattlePokemon.MakeEmptyBattleMon(true,1),
        BattlePokemon.MakeEmptyBattleMon(true,2),
    };
    Side[] Sides = new Side[2];
    public byte battleType;


    MoveID[] Moves = new MoveID[6];
    byte[] Targets = new byte[6];
    byte[] MoveNums = new byte[6];

    public string MonNameWithPrefix(int index, bool capitalized)
    {
        if (wildBattle && index < 3) { return (capitalized ? "The wild " : "the wild ") + PokemonOnField[index].PokemonData.monName; }
        else if (index < 3) { return (capitalized ? "The foe's " : "the foe's ") + PokemonOnField[index].PokemonData.monName; }
        else { return PokemonOnField[index].PokemonData.monName; }
    }

    private bool AbilitiesSuppressed()
    {
        bool result = false;
        for (int i = 0; i < 6; i++) {
            if (PokemonOnField[i].ability == Ability.NeutralizingGas)
            {
                result = true;
            }
        }
        return result;
    }

    public bool IsWeatherAffected(int index, Weather weather)
    {
        if (this.weather != weather) { return false; }
        bool result = true;
        for (int i = 0; i < 6; i++)
        {
            if (HasAbility(i, Ability.CloudNine))
            {
                result = false;
            }
        }
        return result;
    }

    private ushort GetSpeed(int index)
    {
        PokemonOnField[index].CalculateStats();
        ushort speed = PokemonOnField[index].speed;
        if (PokemonOnField[index].PokemonData.status == Status.Paralysis)
        {
            speed >>= 1;
        }
        return speed;
    }

    private bool HasAbility(int index, ushort ability)
    {
        return !AbilitiesSuppressed() && PokemonOnField[index].ability == ability;
    }

    private int FindNextToMove()
    {
        sbyte currentPriority = -127;
        ushort currentSpeed = 0;
        int currentMove = TurnOver;
        for (int i = 0; i < 6; i++)
        {
            if (!PokemonOnField[i].done)
            {
                if (Move.MoveTable[(int)Moves[i]].priority > currentPriority)
                {
                    currentPriority = Move.MoveTable[(int)Moves[i]].priority;
                    currentSpeed = GetSpeed(i);
                    currentMove = i;
                    Debug.Log("Index " + i + " has priority " + currentPriority + " and speed " + currentSpeed);
                }
                else if (Move.MoveTable[(int)Moves[i]].priority == currentPriority && PokemonOnField[i].speed > currentSpeed)
                {
                    currentSpeed = GetSpeed(i);
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
            / 100.0F;
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

    public static ushort DamageCalc(BattlePokemon attacker, BattlePokemon defender, MoveID move, bool isMultiTarget, bool isCritical, Battle battle)
    {
        var random = new System.Random();
        int roll = 100 - random.Next() % 16;
        float critical = isCritical ? 1.5F : 1.0F;
        float stab = (Move.MoveTable[(int)move].type == attacker.PokemonData.SpeciesData.type1
            || Move.MoveTable[(int)move].type == attacker.PokemonData.SpeciesData.type2)
            ? 1.5F : 1.0F;
        float multitarget = isMultiTarget ? 0.75F : 1.0F;
        float attackOverDefense = Move.MoveTable[(int)move].physical
            ? (isCritical && attacker.attackStage < 0 ? attacker.PokemonData.attack : attacker.attack)
            / (float)(isCritical && defender.defenseStage > 0 ? defender.PokemonData.defense : defender.defense)
            : (isCritical && attacker.spAtkStage < 0 ? attacker.PokemonData.spAtk : attacker.spAtk)
            / (float)(isCritical && defender.spDefStage > 0 ? defender.PokemonData.spDef : defender.spDef);
        float burn = Move.MoveTable[(int)move].physical && attacker.PokemonData.status == Status.Burn
            ? attacker.ability == Ability.Guts && !battle.AbilitiesSuppressed() ? 1.5F : 0.5F
            : 1.0F;
        float invulnerabiltyBonus = (defender.invulnerability == Invulnerability.Dig
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitDiggingMon) == 0)
            || (defender.invulnerability == Invulnerability.Fly
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitFlyingMon) == 0)
            ? 2.0F : 1.0F;
        /*
        Debug.Log("Attack/Defense: " + attackOverDefense);
        Debug.Log("Stab: " + stab);
        Debug.Log("Typing: " + Type.GetTypeEffectiveness(move, defender.PokemonData));
        Debug.Log("Part 1: " + (2.0F * attacker.PokemonData.level / 5));
        Debug.Log("Part 2: " + (((2.0F * attacker.PokemonData.level / 5) + 2)
            * Move.MoveTable[(int)move].power * attackOverDefense / 50) + 2);
        Debug.Log("Roll: " + roll);
        */

        ushort result = (ushort)Floor(((((2.0F * attacker.PokemonData.level / 5) + 2)
            * Move.MoveTable[(int)move].power * attackOverDefense / 50) + 2)
            * Type.GetTypeEffectiveness(move, defender.PokemonData)
            * stab * multitarget * critical * burn * invulnerabiltyBonus * roll / 100);
        Debug.Log(result);
        return (result < 1) ? (ushort)1 : result;
    }

    private bool GetTargets(int attacker, int defender, MoveID move) //returns whether move is multi-target
    {
        bool isMultiTarget = false;
        byte targetData = Move.MoveTable[(int)move].targets;
        byte targets = 0;
        if(battleType == BattleType.Single)
        {
            if((targetData & TargetID.Opponent) != 0)
            {
                if (attacker == 0)
                {
                    PokemonOnField[3].isTarget = true;
                    //Debug.Log("3 is a target");
                    targets = 1;
                }
                else if (attacker == 3)
                {
                    PokemonOnField[0].isTarget = true;
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
        if (Move.MoveTable[(int)move].accuracy == Move.AlwaysHit)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (PokemonOnField[defender].invulnerability == Invulnerability.Fly
            && (Move.MoveTable[(int)move].moveFlags & MoveFlags.hitFlyingMon) == 0)
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
        if ((Move.MoveTable[(int)Moves[attacker]].moveFlags
            & MoveFlags.alwaysHitsInRain) != 0)
        {
            PokemonOnField[defender].isHit = true;
            return true;
        }
        if (GetAccuracy(move, attacker, defender) > random.NextDouble()){
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
                if(Type.IsImmune(move, PokemonOnField[i].PokemonData) && Move.MoveTable[(int)move].power > 0)
                {
                    PokemonOnField[i].isUnaffected = true;
                }
                else
                {
                    hitAnyone = hitAnyone || TryToHit(attacker, i, move);
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
                if (random.NextDouble() < GetCritChance(attacker, move)){
                    PokemonOnField[i].isCrit = true;
                }
            }
        }
    }

    private void GetMoveEffects(int attacker, MoveID move)
    {
        //Debug.Log(Move.MoveTable[(int)move].targets);
        var random = new System.Random();
        switch ((Move.MoveTable[(int)move].moveFlags & MoveFlags.effectOnSelfOnly) != 0) {
            case false:
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonOnField[i].isHit)
                    {
                        if (random.NextDouble() <= Move.MoveTable[(int)move].effectChance / 100.0F)
                        {
                            //Debug.Log(i + "got effect");
                            PokemonOnField[i].gotMoveEffect = true;
                        }
                        else
                        {
                            //Debug.Log(i + "didn't get effect");
                        }
                    }
                }
                if ((Move.MoveTable[(int)move].targets & TargetID.Self) != 0)
                {
                    PokemonOnField[attacker].gotMoveEffect = true;
                }
                break;
            case true:
                if (random.NextDouble() <= Move.MoveTable[(int)move].effectChance / 100.0F)
                {
                    //Debug.Log(i + "got effect");
                    PokemonOnField[attacker].gotMoveEffect = true;
                }
                break;
        }
    }

    private void ProcessHits(int attacker, MoveID move, bool isMultiTarget)
    {
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                Debug.Log("Processing hit on " + i);
                ushort damage;
                switch (Move.MoveTable[(int)move].effect)
                {
                    case MoveEffect.OHKO:
                        damage = 65535; break;
                    case MoveEffect.Direct20:
                        damage = 20; break;
                    case MoveEffect.DirectLevel:
                        damage = PokemonOnField[attacker].PokemonData.level; break;
                    case MoveEffect.Counter:
                        damage = (ushort)(PokemonOnField[attacker].damageTaken << 1); break;
                    default:
                        damage = DamageCalc(PokemonOnField[attacker], PokemonOnField[i], move, isMultiTarget, PokemonOnField[i].isCrit, this); break;
                }
                Debug.Log(PokemonOnField[i].PokemonData.HP + " HP, " + damage + " damage");
                if (damage >= PokemonOnField[i].PokemonData.HP)
                {
                    PokemonOnField[attacker].moveDamageDone += PokemonOnField[i].PokemonData.HP;
                    PokemonOnField[i].PokemonData.HP = 0;
                    PokemonOnField[i].PokemonData.fainted = true;
                }
                else
                {
                    PokemonOnField[i].PokemonData.HP -= damage;
                    PokemonOnField[attacker].moveDamageDone += damage;
                    PokemonOnField[i].damageTaken = damage;
                    PokemonOnField[i].damageWasPhysical = Move.MoveTable[(int)move].physical;
                    PokemonOnField[i].lastDamageDoer = attacker;
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
            yield return BattleEffect.Faint(this, index);
            LeaveFieldCleanup(index);
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

    private bool GetNonDamageMoveSuccess(int attacker, MoveEffect moveEffect)
    {
        switch (moveEffect)
        {
            default:
                return true;
        }
    }

    private void LeaveFieldCleanup(int index)
    {
        for(int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].continuousDamageSource == index)
            {
                PokemonOnField[i].getsContinuousDamage = false;
            }
        }
    }

    private IEnumerator TryMove(int index)
    {
        Debug.Log(Move.MoveTable[(int)Moves[index]].name);
        var random = new System.Random();
        bool goAhead = true;
        PokemonOnField[index].invulnerability = Invulnerability.None;
        if (PokemonOnField[index].PokemonData.status == Status.Paralysis)
        {
            Debug.Log("Checking para");
            if (random.NextDouble() < 0.25F)
            {
                yield return FullParalysis(index);
                Debug.Log("Full para");
                goAhead = false;
            }
        }
        else if (PokemonOnField[index].PokemonData.status == Status.Sleep)
        {
            if (TryWakeUp(index))
            {
                yield return WokeUp(index);
                PokemonOnField[index].PokemonData.status = Status.None;
            }
            else
            {
                yield return MonAsleep(index);
                goAhead = false;
            }
        }
        else if (PokemonOnField[index].PokemonData.status == Status.Freeze)
        {
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
        if (goAhead && !PokemonOnField[index].dontCheckPP)
        {
            switch (MoveNums[index])
            {
                case 1:
                    if (PokemonOnField[index].PokemonData.pp1 < 1)
                    {
                        yield return NoPP(index, 0);
                        goAhead = false;
                    }
                    break;
                case 2:
                    if (PokemonOnField[index].PokemonData.pp2 < 1)
                    {
                        yield return NoPP(index, 1);
                        goAhead = false;
                    }
                    break;
                case 3:
                    if (PokemonOnField[index].PokemonData.pp3 < 1)
                    {
                        yield return NoPP(index, 2);
                        goAhead = false;
                    }
                    break;
                case 4:
                    if (PokemonOnField[index].PokemonData.pp4 < 1)
                    {
                        yield return NoPP(index, 3);
                        goAhead = false;
                    }
                    break;
            }
        }
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
        yield return Announce(MonNameWithPrefix(index, true) + "is paralyzed! It can't move!");
    }

    private int GetRandomOpponentMon(bool side)
    {
        var random = new System.Random();
        int added = side ? 0 : 3;
        int output = random.Next() % 3;
        while (!PokemonOnField[added + output].exists)
        {
            output = (output + (random.Next() % 2) + 1) % 3;
        }
        return added + output;
    }

    private bool TryWakeUp(int index)
    {
        if (PokemonOnField[index].PokemonData.status != Status.Sleep) { return true; }
        var random = new System.Random();
        float wakeChance;
        switch(PokemonOnField[index].PokemonData.sleepTurns)
        {
            case 0:
                wakeChance = 0;
                break;
            case 1:
                wakeChance = 1.0F / 3.0F;
                break;
            case 2:
                wakeChance = 0.5F;
                break;
            default:
                wakeChance = 1;
                break;
        }
        PokemonOnField[index].PokemonData.sleepTurns++;
        return wakeChance >= random.NextDouble();
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

    public IEnumerator NoPP(int index, int moveIndex)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.NoPP);
    }

    public IEnumerator IsConfused(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + BattleText.IsConfused);
    }

    public IEnumerator HurtByConfusion(int index)
    {
        int damage = DamageCalc(PokemonOnField[index], PokemonOnField[index], MoveID.ConfusionHit, false, false, this);
        yield return BattleAnim.DefenderAnims(this, index, MoveID.Pound);
        audioSource.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Neutral Hit"));
        if (damage >= PokemonOnField[index].PokemonData.HP)
        {
            PokemonOnField[index].PokemonData.HP = 0;
            PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            PokemonOnField[index].PokemonData.HP -= (ushort)damage;
        }
        yield return DoHitFlash(index);
        yield return ProcessFainting();
    }

    IEnumerator ExecuteMove(int index)
    {
        var random = new System.Random();
        bool isMultiTarget = false;

        Debug.Log("Executing for " + index);

        PokemonOnField[index].lastMoveUsed = Moves[index];
        if (!PokemonOnField[index].dontCheckPP)
        {
            switch (MoveNums[index])
            {
                case 1:
                    PokemonOnField[index].PokemonData.pp1 -= 1;
                    break;
                case 2:
                    PokemonOnField[index].PokemonData.pp2 -= 1;
                    break;
                case 3:
                    PokemonOnField[index].PokemonData.pp3 -= 1;
                    break;
                case 4:
                    PokemonOnField[index].PokemonData.pp4 -= 1;
                    break;
            }
        }
        yield return Announce(PokemonOnField[index].PokemonData.monName + " used " + Move.MoveTable[(int)Moves[index]].name + "!");
        switch (Move.MoveTable[(int)Moves[index]].effect)
        {
            case MoveEffect.Counter:
                if (Moves[index] == MoveID.Counter && PokemonOnField[index].damageWasPhysical)
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
            default:
                isMultiTarget = GetTargets(index, 0, Moves[index]); break;
        }
        bool hitAnyone = GetHits(index, Moves[index]) || GetNonDamageMoveSuccess(index, Move.MoveTable[(int)Moves[index]].effect);
        if (Move.MoveTable[(int)Moves[index]].effect == MoveEffect.ChargingAttack)
        {
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
                default:
                    break;
            }
        }
        else if (Move.MoveTable[(int)Moves[index]].effect is MoveEffect.MultiHit2to5 or MoveEffect.MultiHit2)
        {
            if (hitAnyone)
            {
                int hits;
                switch (Move.MoveTable[(int)Moves[index]].effect)
                {
                    case MoveEffect.MultiHit2to5:
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
                        break;
                    case MoveEffect.MultiHit2:
                        hits = 2;
                        break;
                    default:
                        hits = 0;
                        break;
            }
                bool[] gotHit = new bool[6];
                for (int i = 0; i < hits; i++)
                {

                }
                for (int i = 0; i < hits; i++)
                {
                    GetCrits(index, Moves[index]);
                    GetMoveEffects(index, Moves[index]);
                    yield return DoMoveAnimation(index, Moves[index]);
                    yield return HandleHitFlashes(index);
                    ProcessHits(index, Moves[index], isMultiTarget);
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
                    if (pokemonLeft == false) { break; }
                }
                yield return Announce("Hit " + hits + " times!");
            }
            bool targetsAnyone = false;

            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].isHit)
                {
                    float effectiveness = Type.GetTypeEffectiveness(Moves[index], PokemonOnField[i].PokemonData);
                    yield return AnnounceTypeEffectiveness(effectiveness, isMultiTarget, i);
                    targetsAnyone = true;
                }
                if (PokemonOnField[i].isMissed)
                {
                    yield return Announce(PokemonOnField[i].PokemonData.monName + BattleText.AvoidedAttack);
                    targetsAnyone = true;
                }
                if (PokemonOnField[i].gotMoveEffect)
                {
                    targetsAnyone = true;
                }
            }
            if (!targetsAnyone)
            {
                yield return Announce(BattleText.MoveFailed);
            }
            yield return ProcessFainting();
        }
        else
        {
            GetCrits(index, Moves[index]);
            GetMoveEffects(index, Moves[index]);
            if (Move.MoveTable[(int)Moves[index]].power == 0) { CleanForNonDamagingMoves(); }
            if (hitAnyone) { yield return DoMoveAnimation(index, Moves[index]); }
            yield return HandleHitFlashes(index);
            ProcessHits(index, Moves[index], isMultiTarget);
            bool targetsAnyone = false;
            for (int i = 0; i < 6; i++)
            {
                if (PokemonOnField[i].isHit)
                {
                    targetsAnyone = true;
                    if (Move.MoveTable[(int)Moves[index]].effect == MoveEffect.OHKO)
                    {
                        yield return Announce(BattleText.OHKO);
                    }
                    else if (Move.MoveTable[(int)Moves[index]].effect is not
                        (MoveEffect.Direct20 or MoveEffect.DirectLevel
                        or MoveEffect.Counter))
                    {
                        float effectiveness = Type.GetTypeEffectiveness(Moves[index], PokemonOnField[i].PokemonData);
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
                    yield return Announce(BattleText.NoEffect + MonNameWithPrefix(i, false));
                }
                if (PokemonOnField[i].gotMoveEffect)
                {
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
        }

        switch (Move.MoveTable[(int)Moves[index]].effect)
        {
            case MoveEffect.Recoil33:
                PokemonOnField[index].PokemonData.HP -= (ushort)Max(1, PokemonOnField[index].moveDamageDone / 3);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25:
                PokemonOnField[index].PokemonData.HP -= (ushort)Max(1, PokemonOnField[index].moveDamageDone / 4);
                yield return Announce(MonNameWithPrefix(index, true) + BattleText.Recoil);
                yield return ProcessFaintingSingle(index);
                break;
            case MoveEffect.Recoil25Max:
                PokemonOnField[index].PokemonData.HP -= (ushort)Max(1, PokemonOnField[index].moveDamageDone / 4);
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
            case MoveEffect.Crash50 when PokemonOnField[index].moveDamageDone == 0:
                if (PokemonOnField[index].PokemonData.hpMax >> 1 > PokemonOnField[index].PokemonData.HP)
                {
                    PokemonOnField[index].PokemonData.HP = 0;
                    PokemonOnField[index].PokemonData.fainted = true;
                }
                else
                {
                    PokemonOnField[index].PokemonData.HP -=
                        (ushort)(PokemonOnField[index].PokemonData.hpMax >> 1);
                }
                yield return Announce(MonNameWithPrefix(index, true) + " kept going and crashed!");
                yield return ProcessFaintingSingle(index);
                break;
            default:
                break;
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
                StartCoroutine(BattleAnim.DefenderAnims(this, i, move));
            }
        }
        yield return BattleAnim.AttackerAnims(this, attacker, move);
    }

    private IEnumerator HandleHitFlashes(int index)
    {
        bool doWait = false;
        float effectiveness = 0.0F;
        for(int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].isHit)
            {
                float thisEff = Type.GetTypeEffectiveness(Moves[index], PokemonOnField[i].PokemonData);
                effectiveness = thisEff > effectiveness ? thisEff : effectiveness;
                doWait = true;
                StartCoroutine(DoHitFlash(i));
            }
        }
        if(effectiveness > 0)
        {
            AudioClip hitSound;
            if(effectiveness < 1)
            {
                hitSound = Resources.Load<AudioClip>("Sound/Battle SFX/Weak Hit");
            }
            else if(effectiveness == 1)
            {
                hitSound = Resources.Load<AudioClip>("Sound/Battle SFX/Neutral Hit");
            }
            else
            {
                hitSound = Resources.Load<AudioClip>("Sound/Battle SFX/Strong Hit");
            }
            audioSource.PlayOneShot(hitSound);
        }
        yield return doWait ? new WaitForSeconds(0.6F) : null;
    }

    public IEnumerator DoHitFlash(int index)
    {
        Color off = new Color(1, 1, 1, 0);
        Color on = new Color(1, 1, 1, 1);
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
        for(int i = 0; i < 6; i++)
        {
            PokemonOnField[i].isHit = false;
            PokemonOnField[i].isTarget = false;
            PokemonOnField[i].isMissed = false;
            PokemonOnField[i].isCrit = false;
            PokemonOnField[i].isUnaffected = false;
            PokemonOnField[i].gotMoveEffect = false;
            PokemonOnField[i].moveDamageDone = 0;
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
        for(int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].gotMoveEffect)
            {
                Debug.Log("Index " + i + " gets effect");
                yield return DoMoveEffect(i, Move.MoveTable[(int)Moves[index]].effect, index);
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
            case MoveEffect.AttackUp1:
                yield return BattleEffect.StatUp(this, index, StatID.Attack, 1);
                break;
            case MoveEffect.AttackUp2:
                yield return BattleEffect.StatUp(this, index, StatID.Attack, 2);
                break;
            case MoveEffect.DefenseUp1:
                yield return BattleEffect.StatUp(this, index, StatID.Defense, 1);
                break;
            case MoveEffect.SpeedUp2:
                yield return BattleEffect.StatUp(this, index, StatID.Speed, 2);
                break;
            case MoveEffect.EvasionUp1:
                yield return BattleEffect.StatUp(this, index, StatID.Evasion, 1);
                break;
            case MoveEffect.AttackDown1:
                yield return BattleEffect.StatDown(this, index, StatID.Attack, 1);
                break;
            case MoveEffect.DefenseDown1:
                yield return BattleEffect.StatDown(this, index, StatID.Defense, 1);
                break;
            case MoveEffect.DefenseDown2:
                yield return BattleEffect.StatDown(this, index, StatID.Defense, 2);
                break;
            case MoveEffect.SpDefDown1:
                yield return BattleEffect.StatDown(this, index, StatID.SpDef, 1);
                break;
            case MoveEffect.SpeedDown1:
                yield return BattleEffect.StatDown(this, index, StatID.Speed, 1);
                break;
            case MoveEffect.AccuracyDown1:
                yield return BattleEffect.StatDown(this, index, StatID.Accuracy, 1);
                break;
            case MoveEffect.Growth:
                switch (weather)
                {
                    case Weather.Sun:
                        yield return BattleEffect.StatUp(this, index, StatID.Attack, 2);
                        yield return BattleEffect.StatUp(this, index, StatID.SpAtk, 2);
                        break;
                    default:
                        yield return BattleEffect.StatUp(this, index, StatID.Attack, 1);
                        yield return BattleEffect.StatUp(this, index, StatID.SpAtk, 1);
                        break;
                }
                break;
            case MoveEffect.Flinch:
                PokemonOnField[index].flinched = true;
                break;
            case MoveEffect.Absorb50:
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
            case MoveEffect.PayDay:
                if (!payDay)
                {
                    payDay = true;
                    yield return Announce("Coins were scattered everywhere!");
                }
                break;
            case MoveEffect.Heal50:
                yield return BattleEffect.Heal(this, index, PokemonOnField[index].PokemonData.hpMax >> 1);
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

    public void DoNextMove()
    {
        int index = FindNextToMove();
        if(index == TurnOver)
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
        for(int i = 0; i < 6; i++)
        {
            Debug.Log(i);
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
            if (PokemonOnField[i].getsContinuousDamage)
            {
                yield return BattleEffect.DoContinuousDamage(this, i, PokemonOnField[i].continuousDamageType);
            }
            yield return ProcessFaintingSingle(i);
        }
        yield return StartTurn();
    }

    public IEnumerator DoFieldTargetingMove(int index, MoveID move)
    {
        yield return null;
    }

    public IEnumerator StartTurn()
    {
        state = BattleState.Announcement;
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
                && ! PokemonOnField[i].choseMove)
            { Moves[i] = ChooseAIMove(i); }
        }
        if (!menuManager.GetNextPokemon())
        {
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
            if (OpponentPokemon[i].fainted == false && OpponentPokemon[i].exists == true)
            {
                return i;
            }
        }
        return NoMons;
    }

    public void StartBattle()
    {
        if (battleType == BattleType.Single)
        {
            int firstMon = 0;
            for (int i = 0; i < 6; i++)
            {
                if (!PlayerPokemon[i].fainted) {
                    firstMon = i;
                    break;
                }
            }
            PokemonOnField[3] = new BattlePokemon(PlayerPokemon[firstMon], false, 0, true);
            PokemonOnField[0] = new BattlePokemon(OpponentPokemon[0], true, 0, false);
        }
        payDay = false;
        StartCoroutine(StartTurn());
    }

    public IEnumerator BringToField(Pokemon pokemonData, int index, bool player)
    {
        if (PokemonOnField[index].exists)
        {
            yield return null;

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
        }
    }

    public bool TryAddMove(int index, int move)
    {
        switch (move)
        {
            case 1:
                if (PokemonOnField[index].PokemonData.pp1 > 0)
                {
                    Moves[index] = PokemonOnField[index].PokemonData.move1;
                    MoveNums[index] = 1;
                    return true;
                }
                else { return false; }
            case 2:
                if (PokemonOnField[index].PokemonData.pp2 > 0)
                {
                    Moves[index] = PokemonOnField[index].PokemonData.move2;
                    MoveNums[index] = 2;
                    return true;
                }
                else { return false; }
            case 3:
                if (PokemonOnField[index].PokemonData.pp3 > 0)
                {
                    Moves[index] = PokemonOnField[index].PokemonData.move3;
                    MoveNums[index] = 3;
                    return true;
                }
                else { return false; }
            case 4:
                if (PokemonOnField[index].PokemonData.pp4 > 0)
                {
                    Moves[index] = PokemonOnField[index].PokemonData.move4;
                    MoveNums[index] = 4;
                    return true;
                }
                else { return false; }
            default: { return false; }
        }
    }

    private MoveID ChooseAIMove(int index)
    {
        var random = new System.Random();
        if (wildBattle)
        {
            int whichMove = random.Next() % (PokemonOnField[index].PokemonData.Moves() + 1);
            MoveNums[index] = (byte)whichMove;
            return PokemonOnField[index].GetMove(whichMove);
        }
        return PokemonOnField[index].PokemonData.move1;
    }

    public IEnumerator Announce(string announcement)
    {
        float targetTime;
        for (int i = 1; i <= announcement.Length; i++)
        {
            Announcer.text = announcement.Substring(0, i);
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
        return Item.ItemTable[PokemonOnField[index].item].type == ItemType.MegaStone
            && Item.ItemTable[PokemonOnField[index].item].itemData.originalSpecies
            == PokemonOnField[index].PokemonData.species;
    }

    public IEnumerator EndBattle()
    {
        yield return null;
    }
}