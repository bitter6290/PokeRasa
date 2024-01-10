using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using static BattleText;

public partial class Battle
{
    public IEnumerator StatUp(int index, Stat statID,
        int amount, int attacker, bool checkContrary = true, bool checkSimple = true)
    {
        if (HasAbility(index, Ability.Contrary) && checkContrary
            && !HasMoldBreaker(index))
        {
            yield return StatDown(index, statID, amount, attacker, false);
            yield break;
        }
        if (HasAbility(index, Ability.Simple) && checkSimple)
        {
            amount <<= 1;
        }
        int stagesRaised = PokemonOnField[index].RaiseStat(statID, amount);
        switch (stagesRaised)
        {
            case 0:
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + CantGoHigher);
                break;
            case 1:
                if (doStatAnim) yield return StatUp(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRose);
                break;
            case 2:
                if (doStatAnim) yield return StatUp(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseSharply);
                break;
            default:
                if (doStatAnim) yield return StatUp(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseDrastically);
                break;
        }
        if (stagesRaised > 0) doStatAnim = false;
    }

    public IEnumerator StatDown(int index, Stat statID,
        int amount, int attacker, bool checkContrary = true, bool checkSide = true)
    {
        switch (EffectiveAbility(index))
        {
            case Ability.Contrary when checkContrary:
                yield return StatUp(index, statID, amount, attacker, false);
                yield break;
            case Ability.Simple: amount <<= 1; break;
            case Ability.WhiteSmoke or Ability.ClearBody:
            case Ability.KeenEye when statID == Stat.Accuracy:
            case Ability.HyperCutter when statID == Stat.Attack:
            case Ability.BigPecks when statID == Stat.Defense:
                if ((!checkSide || GetSide(attacker) != GetSide(index)) &&
                        !HasMoldBreaker(attacker))
                {
                    yield return AbilityPopupStart(index);
                    yield return Announce(MonNameWithPrefix(index, true) +
                        "'s stats weren't lowered!");
                    yield return AbilityPopupEnd(index);
                    yield break;
                }
                else break;
        }
        if ((!checkSide || GetSide(attacker) != GetSide(index))
            && Sides[GetSide(index)].mist)
        {
            yield return Announce(MonNameWithPrefix(index, true) +
                " is protected by Mist!");
            yield break;
        }
        int stagesLowered = PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + CantGoLower);
                break;
            case 1:
                if (doStatAnim) yield return StatDown(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFell);
                break;
            case 2:
                if (doStatAnim) yield return StatDown(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellSharply);
                break;
            default:
                if (doStatAnim) yield return StatDown(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellDrastically);
                break;
        }
        if (stagesLowered > 0) doStatAnim = false;
        if ((!checkSide || GetSide(attacker) != GetSide(index)) &&
            HasAbility(index, Ability.Defiant))
        {
            doStatAnim = true;
            yield return AbilityPopupStart(index);
            yield return StatUp(index, Stat.Attack, 2, attacker);
            yield return AbilityPopupEnd(index);
        }
        if ((!checkSide || GetSide(attacker) != GetSide(index))
            && HasAbility(index, Ability.Competitive))
        {
            doStatAnim = true;
            yield return AbilityPopupStart(index);
            yield return StatUp(index, Stat.SpAtk, 2, attacker);
            yield return AbilityPopupEnd(index);
        }

    }

    public IEnumerator GetBurn(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (ShowFailure)
            {
                yield return Announce(MoveFailed);
                yield break;
            }
        }
        if (PokemonOnField[index].HasType(Type.Fire))
        {
            yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
        }
        else
        {
            yield return ShowBurn(index);
            PokemonOnField[index].PokemonData.status = Status.Burn;
            yield return Announce(MonNameWithPrefix(index, true) + " was burned!");
        }
    }
    public IEnumerator GetParalysis(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (ShowFailure)
            {
                yield return Announce(MoveFailed);
                yield break;
            }
        }
        else if (PokemonOnField[index].HasType(Type.Electric))
        {
            yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
        }
        else if (HasAbility(index, Ability.Limber))
        {
            yield return AbilityPopupStart(index);
            yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
            yield return AbilityPopupEnd(index);
        }
        else
        {
            yield return ShowParalysis(index);
            PokemonOnField[index].PokemonData.status = Status.Paralysis;
            yield return Announce(MonNameWithPrefix(index, true) + " was paralyzed!");
        }
    }
    public IEnumerator HealParalysis(int index)
    {
        if (PokemonOnField[index].PokemonData.status == Status.Paralysis)
        {
            PokemonOnField[index].PokemonData.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " was cured of its paralysis!");
        }
    }
    public IEnumerator HealBurn(int index)
    {
        if (PokemonOnField[index].PokemonData.status == Status.Burn)
        {
            PokemonOnField[index].PokemonData.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " was cured of its burn!");
        }
    }
    public IEnumerator HealPoison(int index)
    {
        if (PokemonOnField[index].PokemonData.status is Status.Poison or Status.ToxicPoison)
        {
            PokemonOnField[index].PokemonData.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " is no longer poisoned!");
        }
    }
    public IEnumerator TriAttack(int index)
    {
        var random = new System.Random();
        switch (random.Next() % 3)
        {
            case 0:
                yield return GetBurn(index);
                break;
            case 1:
                yield return GetParalysis(index);
                break;
            case 2:
                yield return GetFreeze(index);
                break;
            default:
                break;
        }
    }
    public IEnumerator GetPoison(int index, bool announceFailure = true, int attacker = 63)
    {
        BattlePokemon target = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure && announceFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.PokemonData.status != Status.None)
        {
            if (ShowFailure && announceFailure)
            {
                yield return Announce(MoveFailed);
            }
            yield break;
        }
        else if ((target.HasType(Type.Poison)
            || target.HasType(Type.Steel)))
        {
            if (ShowFailure && announceFailure)
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
            yield break;
        }
        else if (EffectiveAbility(index) is Ability.Immunity && !HasMoldBreaker(attacker))
        {
            if (announceFailure)
            {
                yield return AbilityPopupStart(index);
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false) + "...");
                yield return AbilityPopupEnd(index);
            }
        }
        else
        {
            yield return ShowPoison(index);
            target.PokemonData.status = Status.Poison;
            yield return Announce(MonNameWithPrefix(index, true) + " was poisoned!");
        }
    }
    public IEnumerator GetBadPoison(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.PokemonData.status != Status.None)
        {
            if (ShowFailure)
                yield return Announce(MoveFailed);
            yield break;
        }
        else if ((target.HasType(Type.Poison)
    || target.HasType(Type.Steel)))
        {
            if (ShowFailure)
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
            yield break;
        }
        else if (EffectiveAbility(index) == Ability.Immunity)
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(index);
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false) + "...");
                yield return AbilityPopupEnd(index);
            }
        }
        else
        {
            yield return ShowToxicPoison(index);
            target.PokemonData.status = Status.ToxicPoison;
            target.toxicCounter = 0;
            yield return Announce(MonNameWithPrefix(index, true) + " was badly poisoned!");
        }
    }
    public IEnumerator GetFreeze(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (ShowFailure)
                yield return Announce(MoveFailed);
            yield break;
        }
        else if (HasAbility(index, Ability.MagmaArmor))
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(index);
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false) + "...");
                yield return AbilityPopupEnd(index);
            }
            yield break;
        }
        else if (PokemonOnField[index].HasType(Type.Ice))
        {
            if (ShowFailure)
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
            yield break;
        }
        else
        {
            yield return ShowFreeze(index);
            PokemonOnField[index].PokemonData.status = Status.Freeze;
            yield return Announce(MonNameWithPrefix(index, true) + " was frozen solid!");
        }
    }
    public IEnumerator FallAsleep(int index, int attacker = 63)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (ShowFailure)
                yield return Announce(MoveFailed);
            yield break;
        }
        else if (EffectiveAbility(index) is Ability.Insomnia or Ability.VitalSpirit
            && !HasMoldBreaker(attacker))
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(index);
                yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false) + "...");
                yield return AbilityPopupEnd(index);
            }
        }
        else if (UproarOnField)
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + " is protected by the uproar!");
        }
        else
        {
            PokemonOnField[index].PokemonData.status = Status.Sleep;
            PokemonOnField[index].PokemonData.sleepTurns = 1 + (random.Next() % 3);
            if (HasAbility(index, Ability.EarlyBird))
                PokemonOnField[index].PokemonData.sleepTurns >>= 1;
            yield return Announce(MonNameWithPrefix(index, true) + " fell asleep!");
        }
    }

    public IEnumerator BurnHurt(int index)
    {
        yield return ShowBurn(index);
        yield return PokemonOnField[index].DoProportionalDamage(0.0625F);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by its burn!");
    }

    public IEnumerator PoisonHurt(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        int poisonDamage = target.PokemonData.hpMax >> 3;
        if (HasAbility(index, Ability.PoisonHeal))
        {
            yield return AbilityPopupStart(index);
            yield return Heal(index, target.PokemonData.hpMax >> 3);
            yield return Announce(MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return AbilityPopupEnd(index);
            yield break;
        }
        yield return ShowPoison(index);
        yield return PokemonOnField[index].DoProportionalDamage(0.125F);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public IEnumerator ToxicPoisonHurt(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (HasAbility(index, Ability.PoisonHeal))
        {
            yield return AbilityPopupStart(index);
            yield return Heal(index, target.PokemonData.hpMax >> 3);
            yield return Announce(MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return AbilityPopupEnd(index);
            yield break;
        }
        yield return ShowPoison(index);
        target.toxicCounter++;
        yield return target.DoProportionalDamage(0.0625F * target.toxicCounter);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public IEnumerator WakeUp(int index)
    {
        PokemonOnField[index].PokemonData.status = Status.None;
        PokemonOnField[index].nightmare = false;
        yield return Announce(MonNameWithPrefix(index, true) + WokeUp);
    }

    public IEnumerator Confuse(int index)
    {
        if (PokemonOnField[index].confused)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is already confused! ");
            yield break;
        }
        if (HasAbility(index, Ability.OwnTempo))
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(index);
                yield return Announce("It doesn't affect "
                    + MonNameWithPrefix(index, false) + "...");
                yield return AbilityPopupEnd(index);
            }
            yield break;
        }
        PokemonOnField[index].confused = true;
        yield return Announce(MonNameWithPrefix(index, true) + " became confused!");
    }

    public IEnumerator Disable(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (target.disabled
            || target.lastMoveUsed is MoveID.None or MoveID.Struggle)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        target.disabled = true;
        target.disabledMove = target.lastMoveUsed;
        target.disableTimer = 4;
        yield return Announce(MonNameWithPrefix(index, true) + "'s "
            + Move.MoveTable[(int)target.lastMoveUsed].name
            + " was disabled!");
    }

    public IEnumerator StartMist(int side)
    {
        if (Sides[side].mist)
        {
            yield break;
        }
        else
        {
            Sides[side].mist = true;
            Sides[side].mistTurns = 5;
        }
    }

    public IEnumerator Heal(int index, int amount,
        bool overrideBlock = false)
    {
        BattlePokemon target = PokemonOnField[index];
        if (target.healBlocked && !overrideBlock) yield break;
        if (target.PokemonData.hp < target.PokemonData.hpMax)
        {
            yield return Heal(index);
            if (target.PokemonData.hp + amount > target.PokemonData.hpMax)
            {
                yield return DoDamage(target.PokemonData, target.PokemonData.hp - target.PokemonData.hpMax);
            }
            else
            {
                yield return DoDamage(target.PokemonData, -1 * amount);
            }
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    public IEnumerator Faint(int index)
    {
        string faintedMonName = MonNameWithPrefix(index, true);
        yield return FaintAnim(index);
        PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
        yield return null;
        spriteRenderer[index].maskInteraction = SpriteMaskInteraction.None;
        yield return Announce(faintedMonName + " fainted!");
    }

    public IEnumerator StartTrapping(int attacker, int index)
    {
        if (PokemonOnField[index].trapped)
        {
            yield break;
        }
        PokemonOnField[index].trapped = true;
        PokemonOnField[index].trappingSlot = attacker;
        yield return Announce(MonNameWithPrefix(index, true) + " can no longer escape!");
    }

    public IEnumerator GetContinuousDamage(int attacker, int index, MoveID move)
    {
        BattlePokemon target = PokemonOnField[index];
        if (target.getsContinuousDamage)
        {
            yield break;
        }
        switch (move)
        {
            case MoveID.Wrap:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Wrap;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was wrapped by "
                    + MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Bind:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Bind;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " is squeezed by " +
                    MonNameWithPrefix(target.continuousDamageSource, false) + "'s Bind!");
                break;
            case MoveID.FireSpin:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.FireSpin;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.Clamp:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Clamp;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was clamped by " +
                    MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Whirlpool:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Whirlpool;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.SandTomb:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.SandTomb;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped by Sand Tomb!");
                break;
            case MoveID.MagmaStorm:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.MagmaStorm;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the swirling magma!");
                break;
            case MoveID.Infestation:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Infestation;
                target.continuousDamageSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " has been inflicted by " +
                    MonNameWithPrefix(attacker, false) + "'s Infestation!");
                break;
            default:
                yield return Announce("Error 111");
                yield break;
        }
        target.continuousDamageTimer = 4 + (random.Next() & 1);

    }

    public IEnumerator VoluntarySwitch(int index, int partyIndex, bool doAnnouncement, bool fromMove)
    {
        if (index < 3)
        {

            LeaveFieldCleanup(index);
            if (PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return Announce(MonNameWithPrefix(index, true) + " came back to "
                        + OpponentName + "!");
                else
                    yield return Announce(OpponentName + " withdrew " + MonNameWithPrefix(index, false) + "!");
            }
            PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
            yield return Announce(OpponentName + " sent out "
                + OpponentPokemon[partyIndex].MonName + "!");
            PokemonOnField[index] = new BattlePokemon(
                OpponentPokemon[partyIndex], index, false, this);
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return MonEntersField(index);
        }
        else
        {
            if (PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return Announce(MonNameWithPrefix(index, true) + " came back to "
                        + player.name + "!");
                else
                    yield return Announce(MonNameWithPrefix(index, true) + "! Come back!");
            }
            LeaveFieldCleanup(index);
            PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
            yield return Announce("Go! " + PlayerPokemon[partyIndex].MonName + "!");
            PokemonOnField[index] = new BattlePokemon(
                            PlayerPokemon[partyIndex], index, true, this);
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return MonEntersField(index);
        }
    }

    public void LeaveField(int index)
    {
        LeaveFieldCleanup(index);
        PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
    }

    public IEnumerator BatonPass(int index, int partyIndex)
    {
        BatonPassStruct passedData = PokemonOnField[index].MakeBatonPassStruct();
        yield return VoluntarySwitch(index, partyIndex, false, true);
        PokemonOnField[index].ApplyBatonPassStruct(passedData);
        yield return EntryAbilityCheck(index);
    }

    public IEnumerator HeartSwap(int user, int target)
    {
        StatStruct targetData = PokemonOnField[target].MakeStatStruct();
        PokemonOnField[target].ApplyStatStruct(PokemonOnField[user].MakeStatStruct());
        PokemonOnField[user].ApplyStatStruct(targetData);
        yield return Announce(MonNameWithPrefix(user, true) +
            " swapped stat changes with its target!");
    }

    public IEnumerator ForcedSwitch(int index)
    {
        var random = new System.Random();
        switch (battleType) //Todo: Implement Multi Battle functionality
        {
            case BattleType.Single:
            default:
                List<Pokemon> RemainingPokemon = new();
                Pokemon[] PokemonArray = index < 3 ? OpponentPokemon : PlayerPokemon;
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonArray[i] == PokemonOnField[index].PokemonData) continue;
                    if (PokemonArray[i].exists
                            && !PokemonArray[i].fainted)
                    {
                        RemainingPokemon.Add(OpponentPokemon[i]);
                    }
                }
                if (RemainingPokemon.Count == 0)
                {
                    if (ShowFailure)
                        yield return Announce(MoveFailed);
                }
                else
                {
                    int partyIndex = random.Next() % RemainingPokemon.Count;
                    LeaveFieldCleanup(index);
                    PokemonOnField[index] = new BattlePokemon(
                        RemainingPokemon[partyIndex],
                        index, index > 2, this)
                    {
                        done = true,
                        partyIndex = partyIndex
                    };
                    HandleFacing(index);
                    yield return Announce(PokemonOnField[index].PokemonData.MonName
                        + " was dragged out!");
                }
                break;

        }
    }

    public IEnumerator MakeSubstitute(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        if (user.PokemonData.hp
            < user.PokemonData.hpMax >> 2)
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + " doesn't have enough HP left to make a substitute!");
            yield break;
        }
        else
        {
            user.hasSubstitute = true;
            user.substituteHP
                = user.PokemonData.hpMax >> 2;
            user.PokemonData.hp
                -= user.substituteHP;
            yield return Announce(MonNameWithPrefix(index, true)
    + " cut its own HP to make a substitute!");
        }
    }

    public IEnumerator SubstituteFaded(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s substitute faded!");
        PokemonOnField[index].hasSubstitute = false;
    }

    public IEnumerator DoContinuousDamage(int index, ContinuousDamage type)
    {
        BattlePokemon target = PokemonOnField[index];
        int damage = 0;
        switch (type)
        {
            case ContinuousDamage.Wrap:
                //yield return Wrap(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true) + " is hurt by Wrap!");
                break;
            case ContinuousDamage.Bind:
                //yield return Bind(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Bind!");
                break;
            case ContinuousDamage.FireSpin:
                //yield return FireSpin(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Fire Spin!");
                break;
            case ContinuousDamage.Clamp:
                //yield return Clamp(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Clamp!");
                break;
            case ContinuousDamage.Whirlpool:
                //yield return Whirlpool(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Whirlpool!");
                break;
            case ContinuousDamage.SandTomb:
                //yield return SandTomb(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Sand Tomb!");
                break;
            case ContinuousDamage.MagmaStorm:
                //yield return MagmaStorm(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by the swirling magma!");
                break;
            case ContinuousDamage.Infestation:
                //yield return Infestation(index);
                damage = target.PokemonData.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Infestation!");
                break;
            default:
                yield return Announce("Error 112");
                break;
        }
        if (damage > target.PokemonData.hp)
        {
            yield return DoFatalDamage(index);
            target.PokemonData.fainted = true;
        }
        else
        {
            yield return target.DoNonMoveDamage(damage);
        }
    }
    public IEnumerator StartWeather(Weather weather, int turns)
    {
        this.weather = weather;
        weatherTimer = turns;
        switch (weather)
        {
            case Weather.Sun:
                yield return Announce(SunStart);
                break;
            case Weather.Rain:
                yield return Announce(RainStart);
                break;
            case Weather.Sand:
                yield return Announce(SandStart);
                break;
            case Weather.Snow:
                yield return Announce(SnowStart);
                break;
        }
        yield return DoWeatherTransformations();
    }
    public IEnumerator WeatherContinues()
    {
        if (weather == Weather.None)
        {
            yield break;
        }
        if (weatherTimer == 0)
        {
            switch (weather)
            {
                case Weather.Sun:
                    yield return Announce(SunEnd);
                    break;
                case Weather.Rain:
                    yield return Announce(RainEnd);
                    break;
                case Weather.Sand:
                    yield return Announce(SandEnd);
                    break;
                case Weather.Snow:
                    yield return Announce(SnowEnd);
                    break;
            }
            weather = Weather.None;
            yield return DoWeatherTransformations();
        }
        else
        {
            switch (weather)
            {
                case Weather.Sun:
                    yield return Announce(SunContinue);
                    break;
                case Weather.Rain:
                    yield return Announce(RainContinue);
                    break;
                case Weather.Sand:
                    yield return Announce(SandContinue);
                    break;
                case Weather.Snow:
                    yield return Announce(SnowContinue);
                    break;
            }
            weatherTimer--;
        }
    }
    public IEnumerator Rest(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard
            || UproarOnField)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        if (user.PokemonData.hp
            < user.PokemonData.hpMax
            && user.PokemonData.status != Status.Sleep)
        {
            user.PokemonData.status = Status.Sleep;
            user.PokemonData.sleepTurns = 2;
            yield return Announce(MonNameWithPrefix(index, true)
                + " slept and became healthy!");
            yield return Heal(index,
                user.PokemonData.hpMax);
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    public IEnumerator GetLeechSeed(int index, int attacker)
    {
        if (PokemonOnField[index].seeded)
        {
            yield break;
        }
        else
        {
            PokemonOnField[index].seeded = true;
            PokemonOnField[index].seedingSlot = attacker;
            yield return Announce(MonNameWithPrefix(index, true) + " was seeded!");
        }
    }

    public IEnumerator TransformMon(int index, int target)
    {
        BattlePokemon user = PokemonOnField[index];
        if (user.isTransformed || PokemonOnField[target].isTransformed)
        {
            yield return Announce(MoveFailed);
        }
        else
        {
            //TransformMon(int index, int target)
            yield return AnimUtils.Fade(spriteRenderer[index], 0.0F, 0.5F);
            user.isTransformed = true;
            user.transformedMon = PokemonOnField[target].PokemonData.Clone() as Pokemon;
            user.transformedMon.SetTransformPP();
            user.ability = PokemonOnField[target].ability;
            user.ApplyStatStruct(
                PokemonOnField[target].MakeStatStruct()
                );
            yield return new WaitForSeconds(0.5F);
            yield return AnimUtils.Fade(spriteRenderer[index], 1.0F, 0.5F);
            yield return Announce(MonNameWithPrefix(index, true)
                + " transformed into " + MonNameWithPrefix(target, false));
            yield return EntryAbilityCheck(index);
        }
    }

    public IEnumerator StartReflect(int side)
    {
        if (Sides[side].reflect)
        {
            yield break;
        }
        else
        {
            Sides[side].reflect = true;
            Sides[side].reflectTurns = 5; //Todo: light clay
            yield return Announce("Reflect raised " + (side == 1 ? "your team's " : "the opponents' ") + "Defense!");
        }
    }

    public IEnumerator StartLightScreen(int side)
    {
        if (Sides[side].lightScreen)
        {
            yield break;
        }
        else
        {
            Sides[side].lightScreen = true;
            Sides[side].lightScreenTurns = 5; //Todo: light clay
            yield return Announce("Light Screen raised " + (side == 1 ? "your team's " : "the opponents' ") + "Special Defense!");
        }
    }

    public IEnumerable StartAuroraVeil(int side)
    {
        if (Sides[side].auroraVeil)
        {
            yield break;
        }
        else
        {
            Sides[side].auroraVeil = true;
            Sides[side].auroraVeilTurns = 5; //Todo: light clay
            yield return Announce("Aurora Veil raised " + (side == 1 ? "your team's " : "the opponents' ") +
                "Defense and Special Defense!");
        }
    }

    public IEnumerator PainSplit(int target, int attacker)
    {
        if (PokemonOnField[attacker].PokemonData.hp
            > PokemonOnField[target].PokemonData.hp)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        int newHP = (PokemonOnField[attacker].PokemonData.hp + PokemonOnField[target].PokemonData.hp) >> 1;
        yield return DoDamage(PokemonOnField[target].PokemonData, PokemonOnField[target].PokemonData.hp - newHP);
        yield return DoDamage(PokemonOnField[attacker].PokemonData, PokemonOnField[attacker].PokemonData.hp - newHP);
        yield return new WaitForSeconds(0.5F);
        yield return Announce("The battlers shared their pain!");
    }

    public IEnumerator DoLeechSeed(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (!PokemonOnField[target.seedingSlot].exists) yield break;
        //yield return LeechSeed(index, target.seedingSlot);
        int healthAmount = target.PokemonData.hpMax >> 3;
        target.DoNonMoveDamage(healthAmount);
        if (HasAbility(index, Ability.LiquidOoze))
        {
            yield return AbilityPopupStart(index);
            PokemonOnField[target.seedingSlot].DoNonMoveDamage(healthAmount);
            yield return new WaitForSeconds(0.5F);
            yield return Announce(MonNameWithPrefix(target.seedingSlot, true)
                + " sucked up the liquid ooze!");
            yield return AbilityPopupEnd(index);
        }
        else
        {
            yield return Heal(PokemonOnField[index].seedingSlot, healthAmount);
            yield return Announce(MonNameWithPrefix(index, true)
                + "'s health was sapped by Leech Seed!");
        }
    }

    public IEnumerator DoMimic(int index, int target)
    {
        BattlePokemon user = PokemonOnField[index];
        if (((Move.MoveTable[(int)PokemonOnField[target].lastMoveUsed].moveFlags & MoveFlags.cannotMimic) != 0)
            || PokemonOnField[index].PokemonData.HasMove(PokemonOnField[target].lastMoveUsed))
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        user.mimicking = true;
        user.mimicSlot = MoveNums[index];
        user.mimicMove = PokemonOnField[target].lastMoveUsed;
        user.mimicMaxPP = Move.MoveTable[(int)user.mimicMove].pp;
        user.mimicPP = user.mimicMaxPP;
        yield return Announce(MonNameWithPrefix(index, true)
            + " mimicked " + Move.MoveTable[(int)user.mimicMove].name + "!");
    }

    public IEnumerator Conversion(int index)
    {
        Type newType = Move.MoveTable[(int)PokemonOnField[index].GetMove(0)].type;
        PokemonOnField[index].newType1 = newType;
        PokemonOnField[index].newType2 = newType;
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    public IEnumerator Camouflage(int index)
    {
        Type newType = terrain switch
        {
            Terrain.Electric => Type.Electric,
            Terrain.Grassy => Type.Grass,
            Terrain.Misty => Type.Fairy,
            Terrain.Psychic => Type.Psychic,
            _ => battleTerrain switch
            {
                BattleTerrain.Building or BattleTerrain.Gym or BattleTerrain.Bridge
                    => Type.Normal,
                BattleTerrain.Cave => Type.Rock,
                BattleTerrain.Sand or BattleTerrain.Rock or BattleTerrain.Marsh
                    => Type.Ground,
                BattleTerrain.Water => Type.Water,
                BattleTerrain.Snow or BattleTerrain.Ice => Type.Ice,
                BattleTerrain.Grass or BattleTerrain.Woods or BattleTerrain.Flowers
                    => Type.Grass,
                BattleTerrain.Volcano => Type.Fire,
                BattleTerrain.Sky => Type.Flying,
                BattleTerrain.BurialGround => Type.Ghost,
                BattleTerrain.UltraSpace => Type.Psychic,
                BattleTerrain.Space => Type.Dragon,
                _ => Type.Normal,
            }
        };
        PokemonOnField[index].newType1 = newType;
        PokemonOnField[index].newType2 = newType;
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    public IEnumerator BecomeType(int index, Type type)
    {
        PokemonOnField[index].newType1 = type;
        PokemonOnField[index].newType2 = type;
        PokemonOnField[index].hasType3 = false;
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)type] + " type!");
    }

    public IEnumerator Haze()
    {
        for (int i = 0; i < 6; i++)
        {
            PokemonOnField[i].ApplyStatStruct(
                new()
                {
                    critRate = PokemonOnField[i].critStage
                }
            );
        }
        yield return Announce("All stat changes were reversed!");
    }

    public IEnumerator CreateTerrain(Terrain terrain, bool extend)
    {
        //Todo: Add terrain animation
        this.terrain = terrain;
        terrainTimer = extend ? 8 : 5;
        yield return Announce(
            terrain switch
            {
                Terrain.Grassy => "Grass grew to cover the battlefield!",
                Terrain.Psychic => "The battlefield got weird!",
                Terrain.Misty => "The battlefield grew shrouded in mist!",
                Terrain.Electric => "Electricity covers the battlefield!",
                _ => "Error: Tried to create invalid terrain"
            }
        );
    }

    public IEnumerator RemoveTerrain()
    {
        //Todo: Add terrain removal animation
        if (terrain == Terrain.None) yield break;
        yield return Announce(
            terrain switch
            {
                Terrain.Grassy => "The grass disappeared from the battlefield!",
                Terrain.Psychic => "The weirdness disappeared from the battlefield!",
                Terrain.Misty => "The mist receded from the battlefield!",
                Terrain.Electric => "The electricity disappeared from the battlefield!",
                _ => "Error: Removing invalid terrain"
            }
        );
        terrain = Terrain.None;
    }

    public IEnumerator StartSafeguard(int index)
    {
        int side = index < 3 ? 0 : 1;
        Sides[side].safeguard = true;
        Sides[side].safeguardTurns = 5;
        yield return Announce(side == 1 ? "Your" : "The opponent's"
            + " team became cloaked in a mystical veil!");
    }

    public void GetPerishSong(int index)
    {
        PokemonOnField[index].perishSong = true;
        PokemonOnField[index].perishCounter = 3;
    }

    public IEnumerator DoPerishSong(int index)
    {
        PokemonOnField[index].perishCounter--;
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s perish counter fell to "
            + PokemonOnField[index].perishCounter + "!");
        if (PokemonOnField[index].perishCounter <= 0)
        {
            yield return DoFatalDamage(index);
            PokemonOnField[index].PokemonData.fainted = true;
        }
    }

    public IEnumerator Infatuate(int index, int attacker)
    {
        if (OppositeGenders(index, attacker) && !PokemonOnField[index].infatuated)
        {
            if (HasAbility(index, Ability.Oblivious))
            {
                if (ShowFailure)
                {
                    yield return AbilityPopupStart(index);
                    yield return Announce(MonNameWithPrefix(index, true)
                        + " is protected by Oblivious!");
                    yield return AbilityPopupEnd(index);
                }
            }
            else
            {
                PokemonOnField[index].infatuated = true;
                PokemonOnField[index].infatuationTarget = attacker;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " became infatuated!");
            }
        }
        else
        {
            yield return Announce(MoveFailed);
        }

    }

    public IEnumerator CureStatusHealBell(Pokemon mon)
    {
        switch (mon.status)
        {
            case Status.Burn:
                yield return Announce(mon.MonName + " was cured of its burn!");
                goto default;
            case Status.Paralysis:
                yield return Announce(mon.MonName + " was cured of its paralysis!");
                goto default;
            case Status.Sleep:
                yield return Announce(mon.MonName + " woke up!");
                goto default;
            case Status.Poison:
            case Status.ToxicPoison:
                yield return Announce(mon.MonName + " was cured of its poisoning!");
                goto default;
            case Status.Freeze:
                yield return Announce(mon.MonName + " thawed out!");
                goto default;
            default:
                mon.status = Status.None;
                break;
        }
    }

    public IEnumerator HealBell(int index)
    {
        yield return Announce("A bell chimed!");
        if (index < 3)
        {
            for (int i = 0; i < 6; i++)
            {
                if (OpponentPokemon[i].exists
                    && OpponentPokemon[i].SpeciesData.abilities[OpponentPokemon[i].whichAbility] != Ability.Soundproof
                    )
                {
                    yield return CureStatusHealBell(OpponentPokemon[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                if (PlayerPokemon[i].exists
                    && PlayerPokemon[i].SpeciesData.abilities[PlayerPokemon[i].whichAbility] != Ability.Soundproof
                    )
                {
                    yield return CureStatusHealBell(PlayerPokemon[i]);
                }
            }
        }
    }

    public IEnumerator Thief(int attacker, int defender)
    {
        if (PokemonOnField[attacker].PokemonData.item == ItemID.None
            && ItemUtils.CanBeStolen(PokemonOnField[defender].PokemonData.item)
            && !HasAbility(defender, Ability.StickyHold))
        {
            PokemonOnField[attacker].PokemonData.newItem = PokemonOnField[defender].PokemonData.item;
            PokemonOnField[defender].PokemonData.newItem = ItemID.None;
            PokemonOnField[defender].PokemonData.itemChanged = true;
            PokemonOnField[attacker].PokemonData.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " stole " + MonNameWithPrefix(defender, false) + "'s "
                + Item.ItemTable[(int)PokemonOnField[attacker].PokemonData.item].itemName + "!");
        }
    }


    public IEnumerator SwitchItems(int attacker, int defender)
    {
        if (HasAbility(defender, Ability.StickyHold))
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(defender);
                yield return Announce(MoveFailed);
                yield return AbilityPopupEnd(defender);
            }
            yield break;
        }
        if (PokemonOnField[attacker].PokemonData.item == ItemID.None
        && ItemUtils.CanBeStolen(PokemonOnField[defender].Item)
        && ItemUtils.CanBeStolen(PokemonOnField[attacker].Item)
        && !HasAbility(defender, Ability.StickyHold))
        {
            ItemID attackerItem = PokemonOnField[attacker].Item;
            PokemonOnField[attacker].PokemonData.newItem = PokemonOnField[defender].Item;
            PokemonOnField[defender].PokemonData.newItem = attackerItem;
            PokemonOnField[defender].PokemonData.itemChanged = true;
            PokemonOnField[attacker].PokemonData.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " switched items with " + MonNameWithPrefix(defender, false) + "!");
            yield return Announce(MonNameWithPrefix(defender, true)
                + " obtained one " + PokemonOnField[defender].Item.Data().itemName + "!");
            yield return Announce(MonNameWithPrefix(attacker, true)
    + " obtained one " + PokemonOnField[attacker].Item.Data().itemName + "!");
        }
    }

    public IEnumerator Bestow(int attacker, int defender)
    {
        BattlePokemon user = PokemonOnField[attacker];
        BattlePokemon target = PokemonOnField[defender];
        if (user.Item == ItemID.None || target.Item != ItemID.None)
            yield return Announce(MoveFailed);
        //Todo: add other failure conditions
        if (user.Item.Data().type == ItemType.Plate && user.PokemonData.SpeciesData.speciesName == "Arceus")
        {
            yield return Announce(MoveFailed);
        }
        else
        {
            target.PokemonData.newItem = user.Item;
            user.PokemonData.newItem = ItemID.None;
            target.PokemonData.itemChanged = true;
            user.PokemonData.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " gave " + MonNameWithPrefix(defender, false) + " its "
                + target.Item.Data().itemName + "!");
        }
    }
    public IEnumerator KnockOff(int attacker, int defender)
    {
        if (ItemUtils.CanBeStolen(PokemonOnField[defender].PokemonData.item)
            && !HasAbility(defender, Ability.StickyHold))
        {
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " knocked off " + MonNameWithPrefix(defender, false)
                + "'s " + PokemonOnField[defender].Item.Data().itemName + "!");
            PokemonOnField[defender].PokemonData.newItem = ItemID.None;
            PokemonOnField[defender].PokemonData.itemChanged = true;
        }
    }

    public IEnumerator GhostCurse(int attacker, int defender)
    {
        PokemonOnField[attacker].DoNonMoveDamage(PokemonOnField[attacker].PokemonData.hpMax >> 1);
        PokemonOnField[defender].cursed = true;
        yield return Announce(MonNameWithPrefix(attacker, true) + " cut its own HP to put a curse on "
            + MonNameWithPrefix(defender, false) + "!");
    }

    public IEnumerator DoCurse(int index)
    {
        PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax >> 2);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by Curse!");
    }

    public IEnumerator Spikes(int index)
    {
        if (Sides[GetSide(5 - index)].spikes < 3)
        {
            Sides[GetSide(5 - index)].spikes++;
            yield return Announce("Spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    public IEnumerator ToxicSpikes(int index)
    {
        if (Sides[GetSide(5 - index)].toxicSpikes < 2)
        {
            Sides[GetSide(5 - index)].toxicSpikes++;
            yield return Announce("Toxic spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    public IEnumerator PsychUp(int user, int target)
    {
        PokemonOnField[user].ApplyStatStruct(PokemonOnField[target].MakeStatStruct());
        yield return Announce(MonNameWithPrefix(user, true)
            + " copied " + MonNameWithPrefix(target, false)
            + "'s stat changes!");
    }

    public IEnumerator DrainPP(int index, int amount, bool announce = true)
    {
        BattlePokemon target = PokemonOnField[index];
        bool worked = true;
        switch (target.lastMoveSlot)
        {
            case 1: target.PokemonData.pp1 = Max(0, target.PokemonData.pp1 - amount); break;
            case 2: target.PokemonData.pp2 = Max(0, target.PokemonData.pp2 - amount); break;
            case 3: target.PokemonData.pp3 = Max(0, target.PokemonData.pp3 - amount); break;
            case 4: target.PokemonData.pp4 = Max(0, target.PokemonData.pp4 - amount); break;
            default: worked = false; break;
        }
        if (announce && worked) yield return Announce("It reduced the PP of " + MonNameWithPrefix(index, false)
            + "'s " + GetMove(index).name + " by 4!");
        else yield return Announce(MoveFailed);
    }

    public IEnumerator GetNightmare(int index)
    {
        if (PokemonOnField[index].PokemonData.status != Status.Sleep || PokemonOnField[index].nightmare)
            yield return Announce(MoveFailed);
        else
        {
            PokemonOnField[index].nightmare = true;
            yield return Announce(MonNameWithPrefix(index, true) + " began having a nightmare!");
        }
    }

    public IEnumerator DoNightmare(int index)
    {
        PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax >> 2);
        yield return Announce(MonNameWithPrefix(index, true) + " is locked in a nightmare!");
    }

    public IEnumerator GetMindReader(int user, int target)
    {
        PokemonOnField[user].usedMindReader = true;
        PokemonOnField[user].mindReaderTarget = target;
        yield return Announce(MonNameWithPrefix(user, true) + " took aim at "
            + MonNameWithPrefix(target, false) + "!");
    }

    public IEnumerator BellyDrum(int index)
    {
        if (PokemonOnField[index].PokemonData.hp * 2 > PokemonOnField[index].PokemonData.hpMax)
        {
            if (PokemonOnField[index].attackStage == 6)
            {
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s Attack won't go any higher!");
                yield break;
            }
            PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].PokemonData.hpMax >> 1);
            yield return StatUp(index);
            PokemonOnField[index].attackStage = 6;
            yield return Announce(MonNameWithPrefix(index, true)
                + " cut its own HP to maximize its Attack!");
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    public IEnumerator RemoveHazards(int index)
    {
        Side side = Sides[index / 3];
        string teamText = (index > 2 ? "your" : "the opponent's") + "team!";
        if (side.spikes > 0)
        {
            yield return Announce(SpikesDisappeared + teamText);
            side.spikes = 0;
        }
        if (side.toxicSpikes > 0)
        {
            yield return Announce(ToxicSpikesDisappeared + teamText);
            side.toxicSpikes = 0;
        }
        if (side.stealthRock)
        {
            yield return Announce(StealthRockDisappeared + teamText);
            side.stealthRock = false;
        }
        if (side.stickyWeb)
        {
            yield return Announce(StickyWebDisappeared + teamText);
            side.stickyWeb = false;
        }
    }

    public IEnumerator Identify(int index, bool miracleEye)
    {
        PokemonOnField[index].identified = true;
        PokemonOnField[index].identifiedByMiracleEye = miracleEye;
        yield return Announce(MonNameWithPrefix(index, true) + " was identified!");
    }

    public static List<Type> GetConversion2Types(Type type)
    {
        return type switch
        {
            Type.Normal => new List<Type>() { Type.Rock, Type.Steel, Type.Ghost },
            Type.Fire => new List<Type>() { Type.Water, Type.Fire, Type.Rock, Type.Dragon },
            Type.Water => new List<Type>() { Type.Grass, Type.Water, Type.Dragon },
            Type.Grass => new List<Type>() { Type.Fire, Type.Grass, Type.Bug, Type.Flying, Type.Poison, Type.Steel, Type.Dragon },
            Type.Electric => new List<Type>() { Type.Electric, Type.Grass, Type.Dragon, Type.Ground },
            Type.Ice => new List<Type>() { Type.Fire, Type.Water, Type.Ice, Type.Steel },
            Type.Ground => new List<Type>() { Type.Grass, Type.Bug, Type.Flying },
            Type.Rock => new List<Type>() { Type.Ground, Type.Fighting, Type.Steel },
            Type.Fighting => new List<Type>() { Type.Psychic, Type.Flying, Type.Bug, Type.Fairy, Type.Ghost, Type.Poison },
            Type.Flying => new List<Type>() { Type.Rock, Type.Electric, Type.Steel },
            Type.Bug => new List<Type>() { Type.Fire, Type.Flying, Type.Steel, Type.Poison, Type.Fairy, Type.Fighting, Type.Ghost },
            Type.Poison => new List<Type>() { Type.Ground, Type.Rock, Type.Poison, Type.Steel, Type.Ghost },
            Type.Psychic => new List<Type>() { Type.Psychic, Type.Dark, Type.Steel },
            Type.Ghost => new List<Type>() { Type.Dark, Type.Normal },
            Type.Dragon => new List<Type>() { Type.Steel, Type.Fairy },
            Type.Dark => new List<Type>() { Type.Fighting, Type.Dark, Type.Fairy },
            Type.Steel => new List<Type>() { Type.Fire, Type.Water, Type.Electric, Type.Steel },
            Type.Fairy => new List<Type>() { Type.Steel, Type.Poison, Type.Fire },
            _ => new List<Type>(),
        };
    }

    public IEnumerator Conversion2(int index, int target)
    {
        var random = new System.Random();
        List<Type> possibleTypes = new();
        foreach (Type i in GetConversion2Types(Move.MoveTable[(int)PokemonOnField[target].lastMoveUsed].type))
            if (!PokemonOnField[index].HasType(i)) possibleTypes.Add(i);
        if (possibleTypes.Count == 0)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        int whichType = random.Next() % possibleTypes.Count;
        PokemonOnField[index].newType1 = possibleTypes[whichType];
        PokemonOnField[index].newType2 = possibleTypes[whichType];
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true) + " transformed into the "
            + TypeUtils.typeName[(int)possibleTypes[whichType]] + " type!");
    }

    public IEnumerator GetFutureSight(int target, int user)
    {
        var random = new System.Random();
        FutureSightStruct futureSightData = new()
        {
            turn = turnsElapsed + 2,
            target = target,
            user = PokemonOnField[user].PokemonData,
            spAtk = PokemonOnField[user].PokemonData.spAtk,
            spAtkStage = PokemonOnField[user].spAtkStage,
            level = PokemonOnField[user].PokemonData.level,
            stab = PokemonOnField[user].HasType(GetMove(user).type),
            critical = random.NextDouble() < GetCritChance(user, Moves[user]),
            type = GetEffectiveType(Moves[user], user),
            move = Moves[user],
        };
        isFutureSightTargeted[target] = true;
        futureSight.Enqueue(futureSightData);
        yield return Announce(MonNameWithPrefix(user, true) + " foresaw an attack!");
    }

    public IEnumerator FutureSightAttack()
    {
        FutureSightStruct data = futureSight.Dequeue();
        isFutureSightTargeted[data.target] = false;
        BattlePokemon targetMon = PokemonOnField[data.target];
        yield return Announce(MonNameWithPrefix(data.target, true) + " took the "
            + data.move.Data().name + " attack!");
        float effectiveness = GetEffectivenessForFutureSight(data.type, targetMon);
        if (effectiveness > 0)
        {
            int damage = FutureSightDamageCalc(data);
            if (damage > targetMon.PokemonData.hp)
            {
                if (targetMon.ability == Ability.Sturdy && targetMon.AtFullHealth
                    && !(HasAbility(data.user.lastIndex, Ability.MoldBreaker)
                    && data.user.onField))
                {
                    targetMon.gotAbilityEffectSelf = true;
                    targetMon.affectingAbilitySelf = Ability.Sturdy;
                    yield return DoSturdyDamage(data.target);
                }
                else if (targetMon.endure && data.user.onField)
                {
                    yield return DoSturdyDamage(data.target);
                }
                else
                {
                    yield return DoFatalDamage(data.target);
                    targetMon.PokemonData.fainted = true;
                }
            }
            else
            {
                yield return DoDamage(targetMon.PokemonData, damage);
            }
        }
        yield return AnnounceTypeEffectiveness(effectiveness, false, data.target);
    }

    public IEnumerator GetEncored(int target)
    {
        BattlePokemon targetMon = PokemonOnField[target];
        if (targetMon.encored || targetMon.lastMoveUsed == MoveID.None)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        targetMon.encored = true;
        targetMon.encoreTimer = 3;
        targetMon.encoredMove = targetMon.lastMoveUsed;
        if (!targetMon.done) Moves[target] = targetMon.encoredMove;
        yield return Announce(MonNameWithPrefix(target, true)
            + " received an encore!");
    }

    public IEnumerator StartUproar(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + " caused an uproar!");
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].exists
                && PokemonOnField[i].PokemonData.status == Status.Sleep)
            {
                yield return WakeUp(i);
            }
        }
    }

    public IEnumerator Stockpile(int index)
    {
        BattlePokemon mon = PokemonOnField[index];
        if (mon.stockpile >= 3) yield break;
        mon.stockpile++;
        yield return Announce(MonNameWithPrefix(index, true)
            + " stockpiled " + mon.stockpile + "!");
        if (mon.defenseStage < 6) mon.stockpileDef++;
        if (mon.spDefStage < 6) mon.stockpileSpDef++;
        yield return StatUp(index, Stat.Defense, 1, index);
        yield return StatUp(index, Stat.SpDef, 1, index, false);
    }

    public IEnumerator Swallow(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        switch (user.stockpile)
        {
            case 1: yield return Heal(index, user.PokemonData.hpMax >> 2); break;
            case 2: yield return Heal(index, user.PokemonData.hpMax >> 1); break;
            case 3: yield return Heal(index, user.PokemonData.hpMax); break;
            default: yield break;
        }
        if (user.stockpileDef > 0 || user.stockpileSpDef > 0)
            yield return Announce("The stockpiled effect wore off!");
        user.defenseStage = Max(-6, user.defenseStage - user.stockpileDef);
        user.spDefStage = Max(-6, user.spDefStage - user.stockpileSpDef);
        user.stockpileDef = 0;
        user.stockpileSpDef = 0;
        user.stockpile = 0;
    }

    public IEnumerator Torment(int index)
    {
        PokemonOnField[index].tormented = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " was subjected to torment!");
    }

    public IEnumerator MakeWish(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true)
            + " made a wish!");
        wishes.Enqueue((PokemonOnField[index].PokemonData.hpMax >> 1,
            turnsElapsed + 1, index, MonNameWithPrefix(index, true)));
    }

    public IEnumerator GetWish()
    {
        (int wishHP, int, int slot, string wisher) wishStruct = wishes.Dequeue();
        if (PokemonOnField[wishStruct.slot].exists && !PokemonOnField[wishStruct.slot].AtFullHealth)
        {
            yield return Announce(wishStruct.wisher + "'s wish came true!");
            yield return Heal(wishStruct.slot, wishStruct.wishHP);
        }
    }

    public IEnumerator GetTaunted(int index)
    {
        PokemonOnField[index].taunted = true;
        PokemonOnField[index].tauntTimer
            = PokemonOnField[index].done ? 4 : 3;
        yield return Announce(MonNameWithPrefix(index, true)
            + " fell for the taunt!");
    }

    public IEnumerator RolePlay(int user, int target)
    {
        yield return AbilityPopupStart(user);
        PokemonOnField[user].ability = PokemonOnField[target].ability;
        yield return abilityControllers[user].ChangeAbility(
            PokemonOnField[user].ability.Name());
        yield return Announce(MonNameWithPrefix(user, true)
            + " copied " + MonNameWithPrefix(target, false) + "'s "
            + PokemonOnField[user].ability.Name() + "!");
        yield return AbilityPopupEnd(user);
        yield return EntryAbilityCheck(user);
    }

    public IEnumerator SkillSwap(int user, int target)
    {
        StartCoroutine(AbilityPopupStart(user));
        yield return AbilityPopupStart(target);
        (PokemonOnField[target].ability, PokemonOnField[user].ability) =
            (PokemonOnField[user].ability, PokemonOnField[target].ability);
        StartCoroutine(abilityControllers[user].ChangeAbility(
            PokemonOnField[user].ability.Name()));
        yield return abilityControllers[target].ChangeAbility(
            PokemonOnField[target].ability.Name());
        yield return Announce(MonNameWithPrefix(user, true)
           + " swapped Abilities with its target!");
        StartCoroutine(AbilityPopupEnd(user));
        yield return AbilityPopupEnd(target);
        if (GetSpeed(user) > GetSpeed(target)
            || (GetSpeed(user) == GetSpeed(target)
            && (random.Next() & 1) == 1))
        {
            yield return EntryAbilityCheck(user);
            yield return EntryAbilityCheck(target);
        }
        else
        {
            yield return EntryAbilityCheck(target);
            yield return EntryAbilityCheck(user);
        }
    }

    public IEnumerator Entrainment(int user, int target)
    {
        yield return AbilityPopupStart(target);
        PokemonOnField[target].ability = PokemonOnField[user].ability;
        yield return abilityControllers[target].ChangeAbility(
            PokemonOnField[target].ability.Name());
        yield return Announce(MonNameWithPrefix(target, true) +
            " acquired " + PokemonOnField[target].ability.Name() + "!");
        yield return AbilityPopupEnd(target);
        yield return EntryAbilityCheck(user);
    }

    public IEnumerator HelpingHand(int user, int target)
    {
        PokemonOnField[target].helpingHand++;
        yield return Announce(MonNameWithPrefix(user, true)
            + " is ready to help " + MonNameWithPrefix(target, false) + "!");
    }

    public IEnumerator Ingrain(int index)
    {
        PokemonOnField[index].ingrained = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " planted its roots!");
    }

    public IEnumerator StartAquaRing(int index)
    {
        PokemonOnField[index].hasAquaRing = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " surrounded itself with a veil of water!");
    }

    public IEnumerator Recycle(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        if (user.Item != ItemID.None || user.eatenBerry == ItemID.None)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        else
        {
            if (consumeItems)
            {
                user.PokemonData.item = user.eatenBerry;
            }
            else
            {
                user.PokemonData.newItem = user.eatenBerry;
                user.PokemonData.itemChanged = true;
            }
            user.eatenBerry = ItemID.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " found one " + user.Item.Data().itemName + "!");
        }
    }

    public IEnumerator BreakScreens(int index)
    {
        Side side = Sides[GetSide(index)];
        string sideText = index < 3 ? "The foes'" : "Your team's";
        if (side.lightScreen)
        {
            side.lightScreen = false;
            yield return Announce(sideText + " Light Screen wore off!");
        }
        if (side.reflect)
        {
            side.reflect = false;
            yield return Announce(sideText + " Reflect wore off!");
        }
    }

    public IEnumerator HealStatus(int index)
    {
        switch (PokemonOnField[index].PokemonData.status)
        {
            case Status.Paralysis:
                yield return HealParalysis(index);
                break;
            case Status.Burn:
                yield return HealBurn(index);
                break;
            case Status.Poison:
            case Status.ToxicPoison:
                yield return HealPoison(index);
                break;
            case Status.Sleep:
                yield return WakeUp(index);
                break;
            default: break;
        }
    }

    public IEnumerator Gravity()
    {
        yield return Announce("Gravity intensified!");
        gravity = true;
        gravityTimer = 5;
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].lockedInNextTurn &&
                PokemonOnField[i].lockedInMove is MoveID.Fly or MoveID.Bounce)
            {
                PokemonOnField[i].lockedInNextTurn = false;
                PokemonOnField[i].invulnerability = Invulnerability.None;
            }
            if (Moves[i] is MoveID.FlyAttack or MoveID.BounceAttack)
            {

            }
        }
    }

    public IEnumerator Tailwind(int side)
    {
        Sides[side].tailwind = true;
        Sides[side].tailwindTurns = 4;
        yield return Announce("A tailwind blew from behind "
            + (side == 0 ? "the foes'" : "your") + " team!");
    }

    public IEnumerator Embargo(int index)
    {
        PokemonOnField[index].embargoed = true;
        PokemonOnField[index].embargoTimer = 5;
        yield return Announce(MonNameWithPrefix(index, true)
            + " can't use items anymore!");
    }

    public IEnumerator PsychoShift(int index, int attacker)
    {
        Pokemon user = PokemonOnField[attacker].PokemonData;
        Pokemon target = PokemonOnField[index].PokemonData;
        if (target.status != Status.None) yield break;
        if (user.status == Status.None) yield break;
        yield return user.status switch
        {
            Status.Burn => GetBurn(index),
            Status.Paralysis => GetParalysis(index),
            Status.Poison => GetPoison(index),
            Status.ToxicPoison => GetBadPoison(index),
            Status.Sleep => FallAsleep(index),
            Status.Freeze => GetFreeze(index), // Impossible, but no reason not to implement
            _ => ScriptUtils.DoNothing()
        };
        yield return HealStatus(attacker);
    }

    public IEnumerator SuppressAbility(int index)
    {
        PokemonOnField[index].abilitySuppressed = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s ability was suppressed!");
    }

    public IEnumerator LuckyChant(int side)
    {
        Sides[side].luckyChant = true;
        Sides[side].luckyChantTurns = 5;
        yield return Announce(side == 0 ? "The foes are" : "Your team is" +
            " protected from critical hits!");
    }

    public IEnumerator WorrySeed(int index)
    {
        yield return AbilityPopupStart(index);
        yield return abilityControllers[index].ChangeAbility(NameTable.Ability[(int)Ability.Insomnia]);
        PokemonOnField[index].ability = Ability.Insomnia;
        yield return Announce(MonNameWithPrefix(index, true) +
            " acquired Insomnia!");
        yield return AbilityPopupEnd(index);
    }

    public IEnumerator SimpleBeam(int index)
    {
        yield return AbilityPopupStart(index);
        yield return abilityControllers[index].ChangeAbility(NameTable.Ability[(int)Ability.Simple]);
        PokemonOnField[index].ability = Ability.Simple;
        yield return Announce(MonNameWithPrefix(index, true) +
            " acquired Simple!");
        yield return AbilityPopupEnd(index);
    }

    public IEnumerator Defog(int attacker, int target) //Todo: add Sticky Web and Terrain clearing effects
    {
        foreach (Side i in Sides)
        {
            string sideText = (i.whichSide ? "your" : "the opponent's") + " team!";
            if (i.spikes > 0)
            {
                yield return Announce(SpikesDisappeared + sideText);
                i.spikes = 0;
            }
            if (i.toxicSpikes > 0)
            {
                yield return Announce(ToxicSpikesDisappeared + sideText);
                i.toxicSpikes = 0;
            }
            if (i.stealthRock)
            {
                yield return Announce(StealthRockDisappeared + sideText);
                i.stealthRock = false;
            }
            if (i.stickyWeb)
            {
                yield return Announce(StickyWebDisappeared + sideText);
                i.stickyWeb = false;
            }
            if (i.lightScreen)
            {
                yield return Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Light Screen disappeared!");
                i.lightScreen = false;
            }
            if (i.reflect)
            {
                yield return Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Reflect wore off!");
                i.reflect = false;
            }
            if (i.safeguard)
            {
                yield return Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Safeguard wore off!");
                i.safeguard = false;
            }
            if (i.mist)
            {
                yield return Announce("The mist surrounding "
                    + (i.whichSide ? "your" : "the opponent's") + " team disappeared!");
                i.mist = false;
            }
        }
        if (Sides[GetSide(target)].auroraVeil)
        {
            yield return Announce(target < 3 ? "The foes'" : "Your team's" +
                " Aurora Veil wore off!");
            Sides[GetSide(target)].auroraVeil = false;
        }
        yield return StatDown(target, Stat.Evasion, 1, attacker);
    }

    public IEnumerator StartTrickRoom(int index)
    {
        if (trickRoom)
        {
            yield return Announce("The twisted dimensions returned to normal!");
            trickRoom = false;
            trickRoomTimer = 0;
        }
        else
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + " twisted the dimensions!");
            trickRoom = true;
            trickRoomTimer = 5;
        }
    }

    public IEnumerator StartWonderRoom()
    {
        if (wonderRoom)
        {
            yield return Announce("The effects of Wonder Room wore off!");
            wonderRoom = false;
            wonderRoomTimer = 0;
        }
        else
        {
            yield return Announce("It created a bizarre area in which" +
                " Defense and Sp. Defense are swapped!");
            wonderRoom = true;
            wonderRoomTimer = 5;
        }
    }

    public IEnumerator StartMagicRoom()
    {
        if (magicRoom)
        {
            yield return Announce("The effects of Magic Room wore off!");
            magicRoom = false;
            magicRoomTimer = 0;
        }
        else
        {
            yield return Announce("It created a bizarre area in which" +
                " held items lose their effects!");
            magicRoom = true;
            magicRoomTimer = 5;
        }
    }

    public IEnumerator StealthRock(int index)
    {
        yield return Announce("Pointed stones float in the air around "
            + (index < 3 ? "your" : "the opponent's") + " team!");
        Sides[(5 - index) / 3].stealthRock = true;
    }

    public IEnumerator StickyWeb(int index)
    {
        yield return Announce("A sticky web spreads out under " +
            (index < 3 ? "your" : "the opponent's") + " team!");
        Sides[(5 - index) / 3].stealthRock = true;
    }

    public IEnumerator GuardSplit(int index, int attacker)
    {
        BattlePokemon user = PokemonOnField[attacker];
        BattlePokemon target = PokemonOnField[index];
        int newDef = (user.BaseDefense + target.BaseDefense) >> 1;
        int newSpDef = (user.BaseSpDef + target.BaseSpDef) >> 1;
        user.overrideDefenses = true;
        target.overrideDefenses = true;
        user.defenseOverride = newDef;
        target.defenseOverride = newDef;
        user.spDefOverride = newSpDef;
        target.spDefOverride = newSpDef;
        yield return Announce(MonNameWithPrefix(attacker, true)
            + " shared its guard with the target!");
    }

    public IEnumerator PowerSplit(int index, int attacker)
    {
        BattlePokemon user = PokemonOnField[attacker];
        BattlePokemon target = PokemonOnField[index];
        int newAtk = (user.BaseAttack + target.BaseAttack) >> 1;
        int newSpAtk = (user.BaseSpAtk + target.BaseSpAtk) >> 1;
        user.overrideAttacks = true;
        target.overrideAttacks = true;
        user.attackOverride = newAtk;
        target.attackOverride = newAtk;
        user.spAtkOverride = newSpAtk;
        target.spAtkOverride = newSpAtk;
        yield return Announce(MonNameWithPrefix(attacker, true)
            + " shared its power with the target!");
    }

    public IEnumerator AllySwitch(int index, int attacker)
    {
        (PokemonOnField[attacker], PokemonOnField[index]) =
            (PokemonOnField[index], PokemonOnField[attacker]);
        PokemonOnField[index].index = index;
        PokemonOnField[attacker].index = attacker;
        yield return Announce(MonNameWithPrefix(attacker, true)
            + " and " + MonNameWithPrefix(index, false)
            + " switched places!");
    }

    public IEnumerator ReflectType(int user, int target)
    {
        BattlePokemon attacker = PokemonOnField[user];
        BattlePokemon defender = PokemonOnField[target];
        attacker.newType1 = defender.Type1;
        attacker.newType2 = defender.Type2;
        if (defender.hasType3)
        {
            attacker.Type3 = defender.Type3;
            attacker.hasType3 = true;
        }
        attacker.typesOverriden = true;
        yield return Announce(MonNameWithPrefix(user, true) +
            "'s type changed to match " + MonNameWithPrefix(target, false) +
            "'s!");
    }

    public IEnumerator MakeRainbow(int index)
    {
        yield return Announce("A rainbow appeared over " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSide(index)].rainbow = true;
        Sides[GetSide(index)].rainbowTurns = 4;
    }
    public IEnumerator MakeSwamp(int index)
    {
        yield return Announce("A swamp appeared around " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSide(index)].swamp = true;
        Sides[GetSide(index)].swampTurns = 4;
    }
    public IEnumerator MakeBurningField(int index)
    {
        yield return Announce("A burning field surrounds " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSide(index)].burningField = true;
        Sides[GetSide(index)].burningFieldTurns = 4;
    }

    public IEnumerator AddType3(int index, Type type)
    {
        yield return Announce("The " + type.Name() + " type was added to " +
            MonNameWithPrefix(index, false) + "!");
        PokemonOnField[index].Type3 = type;
        PokemonOnField[index].hasType3 = true;
    }
}