using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using static Battle;
using static BattleText;

public static class BattleEffect
{
    public static System.Random random = new();
    public static IEnumerator StatUp(Battle battle, int index, Stat statID, int amount, int attacker, bool checkContrary = true)
    {
        if (battle.HasAbility(index, Ability.Contrary) && checkContrary)
        {
            yield return StatDown(battle, index, statID, amount, attacker, false);
            yield break;
        }
        if (battle.HasAbility(index, Ability.Simple))
        {
            amount <<= 1;
        }
        int stagesRaised = battle.PokemonOnField[index].RaiseStat(statID, amount);
        switch (stagesRaised)
        {
            case 0:
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + CantGoHigher);
                break;
            case 1:
                if (battle.doStatAnim) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRose);
                break;
            case 2:
                if (battle.doStatAnim) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseSharply);
                break;
            default:
                if (battle.doStatAnim) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseDrastically);
                break;
        }
        if (stagesRaised > 0) battle.doStatAnim = false;
    }

    public static IEnumerator StatDown(Battle battle, int index, Stat statID, int amount, int attacker, bool checkContrary = true, bool checkSide = true)
    {
        switch (battle.EffectiveAbility(index))
        {
            case Ability.Contrary when checkContrary:
                yield return StatUp(battle, index, statID, amount, attacker, false);
                yield break;
            case Ability.Simple: amount <<= 1; break;
            case Ability.WhiteSmoke or Ability.ClearBody:
            case Ability.KeenEye when statID == Stat.Accuracy:
            case Ability.HyperCutter when statID == Stat.Attack:
            case Ability.BigPecks when statID == Stat.Defense:
                if ((!checkSide || GetSide(attacker) != GetSide(index)) &&
                        !battle.HasMoldBreaker(attacker))
                {
                    yield return battle.AbilityPopupStart(index);
                    yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                        "'s stats weren't lowered!");
                    yield return battle.AbilityPopupEnd(index);
                    yield break;
                }
                else break;
        }
        if ((!checkSide || GetSide(attacker) != GetSide(index))
            && battle.Sides[GetSide(index)].mist)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                " is protected by Mist!");
            yield break;
        }
        
        int stagesLowered = battle.PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + CantGoLower);
                break;
            case 1:
                if (battle.doStatAnim) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFell);
                break;
            case 2:
                if (battle.doStatAnim) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellSharply);
                break;
            default:
                if (battle.doStatAnim) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellDrastically);
                break;
        }
        if (stagesLowered > 0) battle.doStatAnim = false;
        if ((!checkSide || GetSide(attacker) != GetSide(index)) &&
            battle.HasAbility(index, Ability.Defiant))
        {
            battle.doStatAnim = true;
            yield return battle.AbilityPopupStart(index);
            yield return StatUp(battle, index, Stat.Attack, 2, attacker);
            yield return battle.AbilityPopupEnd(index);
        }
        if ((!checkSide || GetSide(attacker) != GetSide(index))
            && battle.HasAbility(index, Ability.Competitive))
        {
            battle.doStatAnim = true;
            yield return battle.AbilityPopupStart(index);
            yield return StatUp(battle, index, Stat.SpAtk, 2, attacker);
            yield return battle.AbilityPopupEnd(index);
        }

    }

    public static IEnumerator GetBurn(Battle battle, int index)
    {
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
            {
                yield return battle.Announce(MoveFailed);
                yield break;
            }
        }
        if (battle.PokemonOnField[index].HasType(Type.Fire))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowBurn(battle, index);
            battle.PokemonOnField[index].PokemonData.status = Status.Burn;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was burned!");
        }
    }
    public static IEnumerator GetParalysis(Battle battle, int index)
    {
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
            {
                yield return battle.Announce(MoveFailed);
                yield break;
            }
        }
        else if (battle.PokemonOnField[index].HasType(Type.Electric))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else if (battle.HasAbility(index, Ability.Limber))
        {
            yield return battle.AbilityPopupStart(index);
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
            yield return battle.AbilityPopupEnd(index);
        }
        else
        {
            yield return BattleAnim.ShowParalysis(battle, index);
            battle.PokemonOnField[index].PokemonData.status = Status.Paralysis;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was paralyzed!");
        }
    }
    public static IEnumerator HealParalysis(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status == Status.Paralysis)
        {
            battle.PokemonOnField[index].PokemonData.status = Status.None;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " was cured of its paralysis!");
        }
    }
    public static IEnumerator HealBurn(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status == Status.Burn)
        {
            battle.PokemonOnField[index].PokemonData.status = Status.None;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " was cured of its burn!");
        }
    }
    public static IEnumerator HealPoison(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status is Status.Poison or Status.ToxicPoison)
        {
            battle.PokemonOnField[index].PokemonData.status = Status.None;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " is no longer poisoned!");
        }
    }
    public static IEnumerator TriAttack(Battle battle, int index)
    {
        var random = new System.Random();
        switch (random.Next() % 3)
        {
            case 0:
                yield return GetBurn(battle, index);
                break;
            case 1:
                yield return GetParalysis(battle, index);
                break;
            case 2:
                yield return GetFreeze(battle, index);
                break;
            default:
                break;
        }
    }
    public static IEnumerator GetPoison(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
            {
                yield return battle.Announce(MoveFailed);
            }
            yield break;
        }
        else if ((target.HasType(Type.Poison)
            || target.HasType(Type.Steel)))
        {
            if (battle.ShowFailure)
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
            yield break;
        }
        else if (battle.EffectiveAbility(index) == Ability.Immunity)
        {
            yield return battle.AbilityPopupStart(index);
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
            yield return battle.AbilityPopupEnd(index);
        }
        else
        {
            yield return BattleAnim.ShowPoison(battle, index);
            target.PokemonData.status = Status.Poison;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was poisoned!");
        }
    }
    public static IEnumerator GetBadPoison(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(MoveFailed);
            yield break;
        }
        else if ((target.HasType(Type.Poison)
    || target.HasType(Type.Steel)))
        {
            if (battle.ShowFailure)
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
            yield break;
        }
        else if (battle.EffectiveAbility(index) == Ability.Immunity)
        {
            if (battle.ShowFailure)
            {
                yield return battle.AbilityPopupStart(index);
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
                yield return battle.AbilityPopupEnd(index);
            }
        }
        else
        {
            yield return BattleAnim.ShowToxicPoison(battle, index);
            target.PokemonData.status = Status.ToxicPoison;
            target.toxicCounter = 0;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was badly poisoned!");
        }
    }
    public static IEnumerator GetFreeze(Battle battle, int index)
    {
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(MoveFailed);
            yield break;
        }
        else if (battle.HasAbility(index, Ability.MagmaArmor))
        {
            if (battle.ShowFailure)
            {
                yield return battle.AbilityPopupStart(index);
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
                yield return battle.AbilityPopupEnd(index);
            }
            yield break;
        }
        else if (battle.PokemonOnField[index].HasType(Type.Ice))
        {
            if (battle.ShowFailure)
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
            yield break;
        }
        else
        {
            yield return BattleAnim.ShowFreeze(battle, index);
            battle.PokemonOnField[index].PokemonData.status = Status.Freeze;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was frozen solid!");
        }
    }
    public static IEnumerator FallAsleep(Battle battle, int index)
    {
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(MoveFailed);
            yield break;
        }
        else if (battle.EffectiveAbility(index) is Ability.Insomnia or Ability.VitalSpirit)
        {
            if (battle.ShowFailure)
            {
                yield return battle.AbilityPopupStart(index);
                yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
                yield return battle.AbilityPopupEnd(index);
            }
        }
        else if (battle.UproarOnField)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " is protected by the uproar!");
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.status = Status.Sleep;
            battle.PokemonOnField[index].PokemonData.sleepTurns = 1 + (random.Next() % 3);
            if (battle.HasAbility(index, Ability.EarlyBird))
                battle.PokemonOnField[index].PokemonData.sleepTurns >>= 1;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " fell asleep!");
        }
    }

    public static IEnumerator BurnHurt(Battle battle, int index)
    {
        yield return BattleAnim.ShowBurn(battle, index);
        yield return battle.PokemonOnField[index].DoProportionalDamage(0.0625F);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by its burn!");
    }

    public static IEnumerator PoisonHurt(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        int poisonDamage = target.PokemonData.hpMax >> 3;
        if (battle.HasAbility(index, Ability.PoisonHeal))
        {
            yield return battle.AbilityPopupStart(index);
            yield return Heal(battle, index, target.PokemonData.hpMax >> 3);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return battle.AbilityPopupEnd(index);
            yield break;
        }
        yield return BattleAnim.ShowPoison(battle, index);
        yield return battle.PokemonOnField[index].DoProportionalDamage(0.125F);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public static IEnumerator ToxicPoisonHurt(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (battle.HasAbility(index, Ability.PoisonHeal))
        {
            yield return battle.AbilityPopupStart(index);
            yield return Heal(battle, index, target.PokemonData.hpMax >> 3);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return battle.AbilityPopupEnd(index);
            yield break;
        }
        yield return BattleAnim.ShowPoison(battle, index);
        target.toxicCounter++;
        yield return target.DoProportionalDamage(0.0625F * target.toxicCounter);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public static IEnumerator WakeUp(Battle battle, int index)
    {
        battle.PokemonOnField[index].PokemonData.status = Status.None;
        battle.PokemonOnField[index].nightmare = false;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + WokeUp);
    }

    public static IEnumerator Confuse(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].confused)
        {
            if (battle.ShowFailure)
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is already confused! ");
            yield break;
        }
        if (battle.HasAbility(index, Ability.OwnTempo))
        {
            if (battle.ShowFailure)
            {
                yield return battle.AbilityPopupStart(index);
                yield return battle.Announce("It doesn't affect "
                    + battle.MonNameWithPrefix(index, false) + "...");
                yield return battle.AbilityPopupEnd(index);
            }
            yield break;
        }
        battle.PokemonOnField[index].confused = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " became confused!");
    }

    public static IEnumerator Disable(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (target.disabled
            || target.lastMoveUsed is MoveID.None or MoveID.Struggle)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        target.disabled = true;
        target.disabledMove = target.lastMoveUsed;
        target.disableTimer = 4;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "'s "
            + Move.MoveTable[(int)target.lastMoveUsed].name
            + " was disabled!");
    }

    public static IEnumerator StartMist(Battle battle, int side)
    {
        if (battle.Sides[side].mist)
        {
            yield break;
        }
        else
        {
            battle.Sides[side].mist = true;
            battle.Sides[side].mistTurns = 5;
        }
    }

    public static IEnumerator Heal(Battle battle, int index, int amount,
        bool overrideBlock = false)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (target.healBlocked) yield break;
        if (target.PokemonData.HP < target.PokemonData.hpMax)
        {
            yield return BattleAnim.Heal(battle, index);
            if (target.PokemonData.HP + amount > target.PokemonData.hpMax)
            {
                yield return Battle.DoDamage(target.PokemonData, target.PokemonData.HP - target.PokemonData.hpMax);
            }
            else
            {
                yield return Battle.DoDamage(target.PokemonData, -1 * amount);
            }
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }
    }

    public static IEnumerator Faint(Battle battle, int index)
    {
        string faintedMonName = battle.MonNameWithPrefix(index, true);
        yield return BattleAnim.Faint(battle, index);
        battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, battle);
        yield return null;
        battle.spriteRenderer[index].maskInteraction = SpriteMaskInteraction.None;
        yield return battle.Announce(faintedMonName + " fainted!");
    }

    public static IEnumerator StartTrapping(Battle battle, int attacker, int index)
    {
        if (battle.PokemonOnField[index].trapped)
        {
            yield break;
        }
        battle.PokemonOnField[index].trapped = true;
        battle.PokemonOnField[index].trappingSlot = attacker;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " can no longer escape!");
    }

    public static IEnumerator GetContinuousDamage(Battle battle, int attacker, int index, MoveID move)
    {
        BattlePokemon target = battle.PokemonOnField[index];
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
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was wrapped by "
                    + battle.MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Bind:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Bind;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " is squeezed by " +
                    battle.MonNameWithPrefix(target.continuousDamageSource, false) + "'s Bind!");
                break;
            case MoveID.FireSpin:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.FireSpin;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.Clamp:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Clamp;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was clamped by " +
                    battle.MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Whirlpool:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Whirlpool;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.SandTomb:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.SandTomb;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was trapped by Sand Tomb!");
                break;
            case MoveID.MagmaStorm:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.MagmaStorm;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " was trapped in the swirling magma!");
                break;
            case MoveID.Infestation:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Infestation;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
                    " has been inflicted by " +
                    battle.MonNameWithPrefix(attacker, false) + "'s Infestation!");
                break;
            default:
                yield return battle.Announce("Error 111");
                yield break;
        }
        target.continuousDamageTimer = 4 + (random.Next() & 1);

    }

    public static IEnumerator VoluntarySwitch(Battle battle, int index, int partyIndex, bool doAnnouncement, bool fromMove)
    {
        if (index < 3)
        {

            battle.LeaveFieldCleanup(index);
            if (battle.PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " came back to "
                        + battle.OpponentName + "!");
                else
                    yield return battle.Announce(battle.OpponentName + " withdrew " + battle.MonNameWithPrefix(index, false) + "!");
            }
            battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, battle);
            yield return battle.Announce(battle.OpponentName + " sent out "
                + battle.OpponentPokemon[partyIndex].monName + "!");
            battle.PokemonOnField[index] = new BattlePokemon(
                battle.OpponentPokemon[partyIndex], index, false, battle);
            battle.PokemonOnField[index].partyIndex = partyIndex;
            battle.HandleFacing(index);
            battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + battle.PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return battle.MonEntersField(index);
        }
        else
        {
            if (battle.PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " came back to "
                        + battle.player.name + "!");
                else
                    yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "! Come back!");
            }
            battle.LeaveFieldCleanup(index);
            battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, battle);
            yield return battle.Announce("Go! " + battle.PlayerPokemon[partyIndex].monName + "!");
            battle.PokemonOnField[index] = new BattlePokemon(
                            battle.PlayerPokemon[partyIndex], index, true, battle);
            battle.PokemonOnField[index].partyIndex = partyIndex;
            battle.HandleFacing(index);
            battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + battle.PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return battle.MonEntersField(index);
        }
    }

    public static void LeaveField(Battle battle, int index)
    {
        battle.LeaveFieldCleanup(index);
        battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, battle);
    }

    public static IEnumerator BatonPass(Battle battle, int index, int partyIndex)
    {
        BatonPassStruct passedData = battle.PokemonOnField[index].MakeBatonPassStruct();
        yield return VoluntarySwitch(battle, index, partyIndex, false, true);
        battle.PokemonOnField[index].ApplyBatonPassStruct(passedData);
        yield return battle.EntryAbilityCheck(index);
    }

    public static IEnumerator HeartSwap(Battle battle, int user, int target)
    {
        StatStruct targetData = battle.PokemonOnField[target].MakeStatStruct();
        battle.PokemonOnField[target].ApplyStatStruct(battle.PokemonOnField[user].MakeStatStruct());
        battle.PokemonOnField[user].ApplyStatStruct(targetData);
        yield return battle.Announce(battle.MonNameWithPrefix(user, true) +
            " swapped stat changes with its target!");
    }

    public static IEnumerator ForcedSwitch(Battle battle, int index)
    {
        var random = new System.Random();
        switch (battle.battleType) //Todo: Implement Multi Battle functionality
        {
            case BattleType.Single:
            default:
                List<Pokemon> RemainingPokemon = new();
                Pokemon[] PokemonArray = index < 3 ? battle.OpponentPokemon : battle.PlayerPokemon;
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonArray[i] == battle.PokemonOnField[index].PokemonData) continue;
                    if (PokemonArray[i].exists
                            && !PokemonArray[i].fainted)
                    {
                        RemainingPokemon.Add(battle.OpponentPokemon[i]);
                    }
                }
                if (RemainingPokemon.Count == 0)
                {
                    if (battle.ShowFailure)
                        yield return battle.Announce(MoveFailed);
                }
                else
                {
                    int partyIndex = random.Next() % RemainingPokemon.Count;
                    battle.LeaveFieldCleanup(index);
                    battle.PokemonOnField[index] = new BattlePokemon(
                        RemainingPokemon[partyIndex],
                        index, index > 2, battle)
                    {
                        done = true,
                        partyIndex = partyIndex
                    };
                    battle.HandleFacing(index);
                    yield return battle.Announce(battle.PokemonOnField[index].PokemonData.monName
                        + " was dragged out!");
                }
                break;

        }
    }

    public static IEnumerator MakeSubstitute(Battle battle, int index)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (user.PokemonData.HP
            < user.PokemonData.hpMax >> 2)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " doesn't have enough HP left to make a substitute!");
            yield break;
        }
        else
        {
            user.hasSubstitute = true;
            user.substituteHP
                = user.PokemonData.hpMax >> 2;
            user.PokemonData.HP
                -= user.substituteHP;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
    + " cut its own HP to make a substitute!");
        }
    }

    public static IEnumerator SubstituteFaded(Battle battle, int index)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + "'s substitute faded!");
        battle.PokemonOnField[index].hasSubstitute = false;
    }

    public static IEnumerator DoContinuousDamage(Battle battle, int index, ContinuousDamage type)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        int damage = 0;
        switch (type)
        {
            case ContinuousDamage.Wrap:
                //yield return BattleAnim.Wrap(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Wrap!");
                break;
            case ContinuousDamage.Bind:
                //yield return BattleAnim.Bind(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Bind!");
                break;
            case ContinuousDamage.FireSpin:
                //yield return BattleAnim.FireSpin(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Fire Spin!");
                break;
            case ContinuousDamage.Clamp:
                //yield return BattleAnim.Clamp(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Clamp!");
                break;
            case ContinuousDamage.Whirlpool:
                //yield return BattleAnim.Whirlpool(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Whirlpool!");
                break;
            case ContinuousDamage.SandTomb:
                //yield return BattleAnim.SandTomb(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Sand Tomb!");
                break;
            case ContinuousDamage.MagmaStorm:
                //yield return BattleAnim.MagmaStorm(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by the swirling magma!");
                break;
            case ContinuousDamage.Infestation:
                //yield return BattleAnim.Infestation(battle, index);
                damage = target.PokemonData.hpMax >> 3;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " is hurt by Infestation!");
                break;
            default:
                yield return battle.Announce("Error 112");
                break;
        }
        if (damage > target.PokemonData.HP)
        {
            yield return battle.DoFatalDamage(index);
            target.PokemonData.fainted = true;
        }
        else
        {
            yield return target.DoNonMoveDamage(damage);
        }
    }
    public static IEnumerator StartWeather(Battle battle, Weather weather, int turns)
    {
        battle.weather = weather;
        battle.weatherTimer = turns;
        switch (weather)
        {
            case Weather.Sun:
                yield return battle.Announce(SunStart);
                break;
            case Weather.Rain:
                yield return battle.Announce(RainStart);
                break;
            case Weather.Sand:
                yield return battle.Announce(SandStart);
                break;
            case Weather.Snow:
                yield return battle.Announce(SnowStart);
                break;
        }
        yield return battle.DoWeatherTransformations();
    }
    public static IEnumerator WeatherContinues(Battle battle)
    {
        if (battle.weather == Weather.None)
        {
            yield break;
        }
        if (battle.weatherTimer == 0)
        {
            switch (battle.weather)
            {
                case Weather.Sun:
                    yield return battle.Announce(SunEnd);
                    break;
                case Weather.Rain:
                    yield return battle.Announce(RainEnd);
                    break;
                case Weather.Sand:
                    yield return battle.Announce(SandEnd);
                    break;
                case Weather.Snow:
                    yield return battle.Announce(SnowEnd);
                    break;
            }
            battle.weather = Weather.None;
            yield return battle.DoWeatherTransformations();
        }
        else
        {
            switch (battle.weather)
            {
                case Weather.Sun:
                    yield return battle.Announce(SunContinue);
                    break;
                case Weather.Rain:
                    yield return battle.Announce(RainContinue);
                    break;
                case Weather.Sand:
                    yield return battle.Announce(SandContinue);
                    break;
                case Weather.Snow:
                    yield return battle.Announce(SnowContinue);
                    break;
            }
            battle.weatherTimer--;
        }
    }
    public static IEnumerator Rest(Battle battle, int index)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (battle.Sides[index < 3 ? 0 : 1].safeguard
            || battle.UproarOnField)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        if (user.PokemonData.HP
            < user.PokemonData.hpMax
            && user.PokemonData.status != Status.Sleep)
        {
            user.PokemonData.status = Status.Sleep;
            user.PokemonData.sleepTurns = 2;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " slept and became healthy!");
            yield return Heal(battle, index,
                user.PokemonData.hpMax);
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }
    }

    public static IEnumerator GetLeechSeed(Battle battle, int index, int attacker)
    {
        if (battle.PokemonOnField[index].seeded)
        {
            yield break;
        }
        else
        {
            battle.PokemonOnField[index].seeded = true;
            battle.PokemonOnField[index].seedingSlot = attacker;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was seeded!");
        }
    }

    public static IEnumerator TransformMon(Battle battle, int index, int target)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (user.isTransformed || battle.PokemonOnField[target].isTransformed)
        {
            yield return battle.Announce(MoveFailed);
        }
        else
        {
            //BattleAnim.TransformMon(Battle battle, int index, int target)
            yield return AnimUtils.Fade(battle.spriteRenderer[index], 0.0F, 0.5F);
            user.isTransformed = true;
            user.transformedMon = battle.PokemonOnField[target].PokemonData.Clone() as Pokemon;
            user.transformedMon.SetTransformPP();
            user.ability = battle.PokemonOnField[target].ability;
            user.ApplyStatStruct(
                battle.PokemonOnField[target].MakeStatStruct()
                );
            yield return new WaitForSeconds(0.5F);
            yield return AnimUtils.Fade(battle.spriteRenderer[index], 1.0F, 0.5F);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " transformed into " + battle.MonNameWithPrefix(target, false));
            yield return battle.EntryAbilityCheck(index);
        }
    }

    public static IEnumerator StartReflect(Battle battle, int side)
    {
        if (battle.Sides[side].reflect)
        {
            yield break;
        }
        else
        {
            battle.Sides[side].reflect = true;
            battle.Sides[side].reflectTurns = 5;
            yield return battle.Announce("Reflect raised " + (side == 1 ? "your team's " : "the opponents' ") + "Defense!");
        }
    }

    public static IEnumerator StartLightScreen(Battle battle, int side)
    {
        if (battle.Sides[side].lightScreen)
        {
            yield break;
        }
        else
        {
            battle.Sides[side].lightScreen = true;
            battle.Sides[side].lightScreenTurns = 5;
            yield return battle.Announce("Light Screen raised " + (side == 1 ? "your team's " : "the opponents' ") + "Special Defense!");
        }
    }

    public static IEnumerator PainSplit(Battle battle, int target, int attacker)
    {
        if (battle.PokemonOnField[attacker].PokemonData.HP
            > battle.PokemonOnField[target].PokemonData.HP)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        int newHP = (battle.PokemonOnField[attacker].PokemonData.HP + battle.PokemonOnField[target].PokemonData.HP) >> 1;
        yield return Battle.DoDamage(battle.PokemonOnField[target].PokemonData, battle.PokemonOnField[target].PokemonData.HP - newHP);
        yield return Battle.DoDamage(battle.PokemonOnField[attacker].PokemonData, battle.PokemonOnField[attacker].PokemonData.HP - newHP);
        yield return new WaitForSeconds(0.5F);
        yield return battle.Announce("The battlers shared their pain!");
    }

    public static IEnumerator DoLeechSeed(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (!battle.PokemonOnField[target.seedingSlot].exists) yield break;
        //yield return BattleAnim.LeechSeed(battle, index, target.seedingSlot);
        int healthAmount = target.PokemonData.hpMax >> 3;
        target.DoNonMoveDamage(healthAmount);
        if (battle.HasAbility(index, Ability.LiquidOoze))
        {
            yield return battle.AbilityPopupStart(index);
            battle.PokemonOnField[target.seedingSlot].DoNonMoveDamage(healthAmount);
            yield return new WaitForSeconds(0.5F);
            yield return battle.Announce(battle.MonNameWithPrefix(target.seedingSlot, true)
                + " sucked up the liquid ooze!");
            yield return battle.AbilityPopupEnd(index);
        }
        else
        {
            yield return Heal(battle, battle.PokemonOnField[index].seedingSlot, healthAmount);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + "'s health was sapped by Leech Seed!");
        }
    }

    public static IEnumerator DoMimic(Battle battle, int index, int target)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (((Move.MoveTable[(int)battle.PokemonOnField[target].lastMoveUsed].moveFlags & MoveFlags.cannotMimic) != 0)
            || battle.PokemonOnField[index].PokemonData.HasMove(battle.PokemonOnField[target].lastMoveUsed))
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        user.mimicking = true;
        user.mimicSlot = battle.MoveNums[index];
        user.mimicMove = battle.PokemonOnField[target].lastMoveUsed;
        user.mimicMaxPP = Move.MoveTable[(int)user.mimicMove].pp;
        user.mimicPP = user.mimicMaxPP;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " mimicked " + Move.MoveTable[(int)user.mimicMove].name + "!");
    }

    public static IEnumerator Conversion(Battle battle, int index)
    {
        Type newType = Move.MoveTable[(int)battle.PokemonOnField[index].GetMove(0)].type;
        battle.PokemonOnField[index].newType1 = newType;
        battle.PokemonOnField[index].newType2 = newType;
        battle.PokemonOnField[index].typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    public static IEnumerator Camouflage(Battle battle, int index)
    {
        Type newType = battle.terrain switch
        {
            Terrain.Electric => Type.Electric,
            Terrain.Grassy => Type.Grass,
            Terrain.Misty => Type.Fairy,
            Terrain.Psychic => Type.Psychic,
            _ => battle.battleTerrain switch
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
        battle.PokemonOnField[index].newType1 = newType;
        battle.PokemonOnField[index].newType2 = newType;
        battle.PokemonOnField[index].typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    public static IEnumerator BecomeType(Battle battle, int index, Type type)
    {
        battle.PokemonOnField[index].newType1 = type;
        battle.PokemonOnField[index].newType2 = type;
        battle.PokemonOnField[index].hasType3 = false;
        battle.PokemonOnField[index].typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)type] + " type!");
    }

    public static IEnumerator Haze(Battle battle)
    {
        for (int i = 0; i < 6; i++)
        {
            battle.PokemonOnField[i].ApplyStatStruct(
                new()
                {
                    critRate = battle.PokemonOnField[i].critStage
                }
            );
        }
        yield return battle.Announce("All stat changes were reversed!");
    }

    public static IEnumerator CreateTerrain(Battle battle, Terrain terrain, bool extend)
    {
        //Todo: Add terrain animation
        battle.terrain = terrain;
        battle.terrainTimer = extend ? 8 : 5;
        yield return battle.Announce(
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

    public static IEnumerator RemoveTerrain(Battle battle)
    {
        //Todo: Add terrain removal animation
        if (battle.terrain == Terrain.None) yield break;
        yield return battle.Announce(
            battle.terrain switch
            {
                Terrain.Grassy => "The grass disappeared from the battlefield!",
                Terrain.Psychic => "The weirdness disappeared from the battlefield!",
                Terrain.Misty => "The mist receded from the battlefield!",
                Terrain.Electric => "The electricity disappeared from the battlefield!",
                _ => "Error: Removing invalid terrain"
            }
        );
        battle.terrain = Terrain.None;
    }

    public static IEnumerator StartSafeguard(Battle battle, int index)
    {
        int side = index < 3 ? 0 : 1;
        battle.Sides[side].safeguard = true;
        battle.Sides[side].safeguardTurns = 5;
        yield return battle.Announce(side == 1 ? "Your" : "The opponent's"
            + " team became cloaked in a mystical veil!");
    }

    public static void GetPerishSong(Battle battle, int index)
    {
        battle.PokemonOnField[index].perishSong = true;
        battle.PokemonOnField[index].perishCounter = 3;
    }

    public static IEnumerator DoPerishSong(Battle battle, int index)
    {
        battle.PokemonOnField[index].perishCounter--;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + "'s perish counter fell to "
            + battle.PokemonOnField[index].perishCounter + "!");
        if (battle.PokemonOnField[index].perishCounter <= 0)
        {
            yield return battle.DoFatalDamage(index);
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
    }

    public static IEnumerator Infatuate(Battle battle, int index, int attacker)
    {
        if (battle.OppositeGenders(index, attacker) && !battle.PokemonOnField[index].infatuated)
        {
            if (battle.HasAbility(index, Ability.Oblivious))
            {
                if (battle.ShowFailure)
                {
                    yield return battle.AbilityPopupStart(index);
                    yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                        + " is protected by Oblivious!");
                    yield return battle.AbilityPopupEnd(index);
                }
            }
            else
            {
                battle.PokemonOnField[index].infatuated = true;
                battle.PokemonOnField[index].infatuationTarget = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + " became infatuated!");
            }
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }

    }

    public static IEnumerator CureStatusHealBell(Battle battle, Pokemon mon)
    {
        switch (mon.status)
        {
            case Status.Burn:
                yield return battle.Announce(mon.monName + " was cured of its burn!");
                goto default;
            case Status.Paralysis:
                yield return battle.Announce(mon.monName + " was cured of its paralysis!");
                goto default;
            case Status.Sleep:
                yield return battle.Announce(mon.monName + " woke up!");
                goto default;
            case Status.Poison:
            case Status.ToxicPoison:
                yield return battle.Announce(mon.monName + " was cured of its poisoning!");
                goto default;
            case Status.Freeze:
                yield return battle.Announce(mon.monName + " thawed out!");
                goto default;
            default:
                mon.status = Status.None;
                break;
        }
    }

    public static IEnumerator HealBell(Battle battle, int index)
    {
        yield return battle.Announce("A bell chimed!");
        if (index < 3)
        {
            for (int i = 0; i < 6; i++)
            {
                if (battle.OpponentPokemon[i].exists
                    && battle.OpponentPokemon[i].SpeciesData.abilities[battle.OpponentPokemon[i].whichAbility] != Ability.Soundproof
                    )
                {
                    yield return CureStatusHealBell(battle, battle.OpponentPokemon[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                if (battle.PlayerPokemon[i].exists
                    && battle.PlayerPokemon[i].SpeciesData.abilities[battle.PlayerPokemon[i].whichAbility] != Ability.Soundproof
                    )
                {
                    yield return CureStatusHealBell(battle, battle.PlayerPokemon[i]);
                }
            }
        }
    }

    public static IEnumerator Thief(Battle battle, int attacker, int defender)
    {
        if (battle.PokemonOnField[attacker].PokemonData.item == ItemID.None
            && Item.CanBeStolen(battle.PokemonOnField[defender].PokemonData.item)
            && !battle.HasAbility(defender, Ability.StickyHold))
        {
            battle.PokemonOnField[attacker].PokemonData.newItem = battle.PokemonOnField[defender].PokemonData.item;
            battle.PokemonOnField[defender].PokemonData.newItem = ItemID.None;
            battle.PokemonOnField[defender].PokemonData.itemChanged = true;
            battle.PokemonOnField[attacker].PokemonData.itemChanged = true;
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
                + " stole " + battle.MonNameWithPrefix(defender, false) + "'s "
                + Item.ItemTable[(int)battle.PokemonOnField[attacker].PokemonData.item].itemName + "!");
        }
    }


    public static IEnumerator SwitchItems(Battle battle, int attacker, int defender)
    {
        if (battle.HasAbility(defender, Ability.StickyHold))
        {
            if (battle.ShowFailure)
            {
                yield return battle.AbilityPopupStart(defender);
                yield return battle.Announce(MoveFailed);
                yield return battle.AbilityPopupEnd(defender);
            }
            yield break;
        }
        if (battle.PokemonOnField[attacker].PokemonData.item == ItemID.None
        && Item.CanBeStolen(battle.PokemonOnField[defender].Item)
        && Item.CanBeStolen(battle.PokemonOnField[attacker].Item)
        && !battle.HasAbility(defender, Ability.StickyHold))
        {
            ItemID attackerItem = battle.PokemonOnField[attacker].Item;
            battle.PokemonOnField[attacker].PokemonData.newItem = battle.PokemonOnField[defender].Item;
            battle.PokemonOnField[defender].PokemonData.newItem = attackerItem;
            battle.PokemonOnField[defender].PokemonData.itemChanged = true;
            battle.PokemonOnField[attacker].PokemonData.itemChanged = true;
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
                + " switched items with " + battle.MonNameWithPrefix(defender, false) + "!");
            yield return battle.Announce(battle.MonNameWithPrefix(defender, true)
                + " obtained one " + battle.PokemonOnField[defender].Item.Data().itemName + "!");
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
    + " obtained one " + battle.PokemonOnField[attacker].Item.Data().itemName + "!");
        }
    }

    public static IEnumerator Bestow(Battle battle, int attacker, int defender)
    {
        BattlePokemon user = battle.PokemonOnField[attacker];
        BattlePokemon target = battle.PokemonOnField[defender];
        if (user.Item == ItemID.None || target.Item != ItemID.None)
            yield return battle.Announce(MoveFailed);
        //Todo: add other failure conditions
        if (user.Item.Data().type == ItemType.Plate && user.PokemonData.SpeciesData.speciesName == "Arceus")
        {
            yield return battle.Announce(MoveFailed);
        }
        else
        {
            target.PokemonData.newItem = user.Item;
            user.PokemonData.newItem = ItemID.None;
            target.PokemonData.itemChanged = true;
            user.PokemonData.itemChanged = true;
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
                + " gave " + battle.MonNameWithPrefix(defender, false) + " its "
                + target.Item.Data().itemName + "!");
        }
    }
    public static IEnumerator KnockOff(Battle battle, int attacker, int defender)
    {
        if (Item.CanBeStolen(battle.PokemonOnField[defender].PokemonData.item)
            && !battle.HasAbility(defender, Ability.StickyHold))
        {
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
                + " knocked off " + battle.MonNameWithPrefix(defender, false)
                + "'s " + battle.PokemonOnField[defender].Item.Data().itemName + "!");
            battle.PokemonOnField[defender].PokemonData.newItem = ItemID.None;
            battle.PokemonOnField[defender].PokemonData.itemChanged = true;
        }
    }

    public static IEnumerator GhostCurse(Battle battle, int attacker, int defender)
    {
        battle.PokemonOnField[attacker].DoNonMoveDamage(battle.PokemonOnField[attacker].PokemonData.hpMax >> 1);
        battle.PokemonOnField[defender].cursed = true;
        yield return battle.Announce(battle.MonNameWithPrefix(attacker, true) + " cut its own HP to put a curse on "
            + battle.MonNameWithPrefix(defender, false) + "!");
    }

    public static IEnumerator DoCurse(Battle battle, int index)
    {
        battle.PokemonOnField[index].DoNonMoveDamage(battle.PokemonOnField[index].PokemonData.hpMax >> 2);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Curse!");
    }

    public static IEnumerator Spikes(Battle battle, int index)
    {
        if (battle.Sides[GetSide(5 - index)].spikes < 3)
        {
            battle.Sides[GetSide(5 - index)].spikes++;
            yield return battle.Announce("Spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }
    }

    public static IEnumerator ToxicSpikes(Battle battle, int index)
    {
        if (battle.Sides[GetSide(5 - index)].toxicSpikes < 2)
        {
            battle.Sides[GetSide(5 - index)].toxicSpikes++;
            yield return battle.Announce("Toxic spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }
    }

    public static IEnumerator PsychUp(Battle battle, int user, int target)
    {
        battle.PokemonOnField[user].ApplyStatStruct(battle.PokemonOnField[target].MakeStatStruct());
        yield return battle.Announce(battle.MonNameWithPrefix(user, true)
            + " copied " + battle.MonNameWithPrefix(target, false)
            + "'s stat changes!");
    }

    public static IEnumerator DrainPP(Battle battle, int index, int amount, bool announce = true)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        bool worked = true;
        switch (target.lastMoveSlot)
        {
            case 1: target.PokemonData.pp1 = Max(0, target.PokemonData.pp1 - amount); break;
            case 2: target.PokemonData.pp2 = Max(0, target.PokemonData.pp2 - amount); break;
            case 3: target.PokemonData.pp3 = Max(0, target.PokemonData.pp3 - amount); break;
            case 4: target.PokemonData.pp4 = Max(0, target.PokemonData.pp4 - amount); break;
            default: worked = false; break;
        }
        if (announce && worked) yield return battle.Announce("It reduced the PP of " + battle.MonNameWithPrefix(index, false)
            + "'s " + battle.GetMove(index).name + " by 4!");
        else yield return battle.Announce(MoveFailed);
    }

    public static IEnumerator GetNightmare(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.Sleep || battle.PokemonOnField[index].nightmare)
            yield return battle.Announce(MoveFailed);
        else
        {
            battle.PokemonOnField[index].nightmare = true;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " began having a nightmare!");
        }
    }

    public static IEnumerator DoNightmare(Battle battle, int index)
    {
        battle.PokemonOnField[index].DoNonMoveDamage(battle.PokemonOnField[index].PokemonData.hpMax >> 2);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is locked in a nightmare!");
    }

    public static IEnumerator GetMindReader(Battle battle, int user, int target)
    {
        battle.PokemonOnField[user].usedMindReader = true;
        battle.PokemonOnField[user].mindReaderTarget = target;
        yield return battle.Announce(battle.MonNameWithPrefix(user, true) + " took aim at "
            + battle.MonNameWithPrefix(target, false) + "!");
    }

    public static IEnumerator BellyDrum(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.HP * 2 > battle.PokemonOnField[index].PokemonData.hpMax)
        {
            if (battle.PokemonOnField[index].attackStage == 6)
            {
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s Attack won't go any higher!");
                yield break;
            }
            battle.PokemonOnField[index].DoNonMoveDamage(battle.PokemonOnField[index].PokemonData.hpMax >> 1);
            yield return BattleAnim.StatUp(battle, index);
            battle.PokemonOnField[index].attackStage = 6;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " cut its own HP to maximize its Attack!");
        }
        else
        {
            yield return battle.Announce(MoveFailed);
        }
    }

    public static IEnumerator RemoveHazards(Battle battle, int index)
    {
        Side side = battle.Sides[index / 3];
        string teamText = (index > 2 ? "your" : "the opponent's") + "team!";
        if (side.spikes > 0)
        {
            yield return battle.Announce(SpikesDisappeared + teamText);
            side.spikes = 0;
        }
        if (side.toxicSpikes > 0)
        {
            yield return battle.Announce(ToxicSpikesDisappeared + teamText);
            side.toxicSpikes = 0;
        }
        if (side.stealthRock)
        {
            yield return battle.Announce(StealthRockDisappeared + teamText);
            side.stealthRock = false;
        }
        if (side.stickyWeb)
        {
            yield return battle.Announce(StickyWebDisappeared + teamText);
            side.stickyWeb = false;
        }
    }

    public static IEnumerator Identify(Battle battle, int index, bool miracleEye)
    {
        battle.PokemonOnField[index].identified = true;
        battle.PokemonOnField[index].identifiedByMiracleEye = miracleEye;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was identified!");
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

    public static IEnumerator Conversion2(Battle battle, int index, int target)
    {
        var random = new System.Random();
        List<Type> possibleTypes = new();
        foreach (Type i in GetConversion2Types(Move.MoveTable[(int)battle.PokemonOnField[target].lastMoveUsed].type))
            if (!battle.PokemonOnField[index].HasType(i)) possibleTypes.Add(i);
        if (possibleTypes.Count == 0)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        int whichType = random.Next() % possibleTypes.Count;
        battle.PokemonOnField[index].newType1 = possibleTypes[whichType];
        battle.PokemonOnField[index].newType2 = possibleTypes[whichType];
        battle.PokemonOnField[index].typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " transformed into the "
            + TypeUtils.typeName[(int)possibleTypes[whichType]] + " type!");
    }

    public static IEnumerator GetFutureSight(Battle battle, int target, int user)
    {
        var random = new System.Random();
        FutureSightStruct futureSightData = new()
        {
            turn = battle.turnsElapsed + 2,
            target = target,
            user = battle.PokemonOnField[user].PokemonData,
            spAtk = battle.PokemonOnField[user].PokemonData.spAtk,
            spAtkStage = battle.PokemonOnField[user].spAtkStage,
            level = battle.PokemonOnField[user].PokemonData.level,
            stab = battle.PokemonOnField[user].HasType(battle.GetMove(user).type),
            critical = random.NextDouble() < battle.GetCritChance(user, battle.Moves[user]),
            type = battle.GetEffectiveType(battle.Moves[user], user),
            move = battle.Moves[user],
        };
        battle.isFutureSightTargeted[target] = true;
        battle.futureSight.Enqueue(futureSightData);
        yield return battle.Announce(battle.MonNameWithPrefix(user, true) + " foresaw an attack!");
    }

    public static IEnumerator FutureSightAttack(Battle battle)
    {
        FutureSightStruct data = battle.futureSight.Dequeue();
        battle.isFutureSightTargeted[data.target] = false;
        BattlePokemon targetMon = battle.PokemonOnField[data.target];
        yield return battle.Announce(battle.MonNameWithPrefix(data.target, true) + " took the "
            + data.move.Data().name + " attack!");
        float effectiveness = battle.GetEffectivenessForFutureSight(data.type, targetMon);
        if (effectiveness > 0)
        {
            int damage = battle.FutureSightDamageCalc(data);
            if (damage > targetMon.PokemonData.HP)
            {
                if (targetMon.ability == Ability.Sturdy && targetMon.AtFullHealth
                    && !(battle.HasAbility(data.user.lastIndex, Ability.MoldBreaker)
                    && data.user.onField))
                {
                    targetMon.gotAbilityEffectSelf = true;
                    targetMon.affectingAbilitySelf = Ability.Sturdy;
                    yield return battle.DoSturdyDamage(data.target);
                }
                else if (targetMon.endure && data.user.onField)
                {
                    yield return battle.DoSturdyDamage(data.target);
                }
                else
                {
                    yield return battle.DoFatalDamage(data.target);
                    targetMon.PokemonData.fainted = true;
                }
            }
            else
            {
                yield return Battle.DoDamage(targetMon.PokemonData, damage);
            }
        }
        yield return battle.AnnounceTypeEffectiveness(effectiveness, false, data.target);
    }

    public static IEnumerator GetEncored(Battle battle, int target)
    {
        BattlePokemon targetMon = battle.PokemonOnField[target];
        if (targetMon.encored || targetMon.lastMoveUsed == MoveID.None)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        targetMon.encored = true;
        targetMon.encoreTimer = 3;
        targetMon.encoredMove = targetMon.lastMoveUsed;
        if (!targetMon.done) battle.Moves[target] = targetMon.encoredMove;
        yield return battle.Announce(battle.MonNameWithPrefix(target, true)
            + " received an encore!");
    }

    public static IEnumerator StartUproar(Battle battle, int index)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " caused an uproar!");
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].exists
                && battle.PokemonOnField[i].PokemonData.status == Status.Sleep)
            {
                yield return WakeUp(battle, i);
            }
        }
    }

    public static IEnumerator Stockpile(Battle battle, int index)
    {
        BattlePokemon mon = battle.PokemonOnField[index];
        if (mon.stockpile >= 3) yield break;
        mon.stockpile++;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " stockpiled " + mon.stockpile + "!");
        if (mon.defenseStage < 6) mon.stockpileDef++;
        if (mon.spDefStage < 6) mon.stockpileSpDef++;
        yield return StatUp(battle, index, Stat.Defense, 1, index);
        yield return StatUp(battle, index, Stat.SpDef, 1, index, false);
    }

    public static IEnumerator Swallow(Battle battle, int index)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        switch (user.stockpile)
        {
            case 1: yield return Heal(battle, index, user.PokemonData.hpMax >> 2); break;
            case 2: yield return Heal(battle, index, user.PokemonData.hpMax >> 1); break;
            case 3: yield return Heal(battle, index, user.PokemonData.hpMax); break;
            default: yield break;
        }
        if (user.stockpileDef > 0 || user.stockpileSpDef > 0)
            yield return battle.Announce("The stockpiled effect wore off!");
        user.defenseStage = Max(-6, user.defenseStage - user.stockpileDef);
        user.spDefStage = Max(-6, user.spDefStage - user.stockpileSpDef);
        user.stockpileDef = 0;
        user.stockpileSpDef = 0;
        user.stockpile = 0;
    }

    public static IEnumerator Torment(Battle battle, int index)
    {
        battle.PokemonOnField[index].tormented = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " was subjected to torment!");
    }

    public static IEnumerator MakeWish(Battle battle, int index)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " made a wish!");
        battle.wishes.Enqueue((battle.PokemonOnField[index].PokemonData.hpMax >> 1,
            battle.turnsElapsed + 1, index, battle.MonNameWithPrefix(index, true)));
    }

    public static IEnumerator GetWish(Battle battle)
    {
        (int wishHP, int, int slot, string wisher) wishStruct = battle.wishes.Dequeue();
        if (battle.PokemonOnField[wishStruct.slot].exists && !battle.PokemonOnField[wishStruct.slot].AtFullHealth)
        {
            yield return battle.Announce(wishStruct.wisher + "'s wish came true!");
            yield return Heal(battle, wishStruct.slot, wishStruct.wishHP);
        }
    }

    public static IEnumerator GetTaunted(Battle battle, int index)
    {
        battle.PokemonOnField[index].taunted = true;
        battle.PokemonOnField[index].tauntTimer
            = battle.PokemonOnField[index].done ? 4 : 3;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " fell for the taunt!");
    }

    public static IEnumerator RolePlay(Battle battle, int user, int target)
    {
        yield return battle.AbilityPopupStart(user);
        battle.PokemonOnField[user].ability = battle.PokemonOnField[target].ability;
        yield return battle.abilityControllers[user].ChangeAbility(
            battle.PokemonOnField[user].ability.Name());
        yield return battle.Announce(battle.MonNameWithPrefix(user, true)
            + " copied " + battle.MonNameWithPrefix(target, false) + "'s "
            + battle.PokemonOnField[user].ability.Name() + "!");
        yield return battle.AbilityPopupEnd(user);
        yield return battle.EntryAbilityCheck(user);
    }

    public static IEnumerator SkillSwap(Battle battle, int user, int target)
    {
        battle.StartCoroutine(battle.AbilityPopupStart(user));
        yield return battle.AbilityPopupStart(target);
        (battle.PokemonOnField[target].ability, battle.PokemonOnField[user].ability) =
            (battle.PokemonOnField[user].ability, battle.PokemonOnField[target].ability);
        battle.StartCoroutine(battle.abilityControllers[user].ChangeAbility(
            battle.PokemonOnField[user].ability.Name()));
        yield return battle.abilityControllers[target].ChangeAbility(
            battle.PokemonOnField[target].ability.Name());
        yield return battle.Announce(battle.MonNameWithPrefix(user, true)
           + " swapped Abilities with its target!");
        battle.StartCoroutine(battle.AbilityPopupEnd(user));
        yield return battle.AbilityPopupEnd(target);
        if (battle.GetSpeed(user) > battle.GetSpeed(target)
            || (battle.GetSpeed(user) == battle.GetSpeed(target)
            && (battle.random.Next() & 1) == 1))
        {
            yield return battle.EntryAbilityCheck(user);
            yield return battle.EntryAbilityCheck(target);
        }
        else
        {
            yield return battle.EntryAbilityCheck(target);
            yield return battle.EntryAbilityCheck(user);
        }
    }

    public static IEnumerator Entrainment(Battle battle, int user, int target)
    {
        yield return battle.AbilityPopupStart(target);
        battle.PokemonOnField[target].ability = battle.PokemonOnField[user].ability;
        yield return battle.abilityControllers[target].ChangeAbility(
            battle.PokemonOnField[target].ability.Name());
        yield return battle.Announce(battle.MonNameWithPrefix(target, true) +
            " acquired " + battle.PokemonOnField[target].ability.Name() + "!");
        yield return battle.AbilityPopupEnd(target);
        yield return battle.EntryAbilityCheck(user);
    }

    public static IEnumerator HelpingHand(Battle battle, int user, int target)
    {
        battle.PokemonOnField[target].helpingHand++;
        yield return battle.Announce(battle.MonNameWithPrefix(user, true)
            + " is ready to help " + battle.MonNameWithPrefix(target, false) + "!");
    }

    public static IEnumerator Ingrain(Battle battle, int index)
    {
        battle.PokemonOnField[index].ingrained = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " planted its roots!");
    }

    public static IEnumerator StartAquaRing(Battle battle, int index)
    {
        battle.PokemonOnField[index].hasAquaRing = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " surrounded itself with a veil of water!");
    }

    public static IEnumerator Recycle(Battle battle, int index)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (user.Item != ItemID.None || user.eatenBerry == ItemID.None)
        {
            yield return battle.Announce(MoveFailed);
            yield break;
        }
        else
        {
            if (battle.consumeItems)
            {
                user.PokemonData.item = user.eatenBerry;
            }
            else
            {
                user.PokemonData.newItem = user.eatenBerry;
                user.PokemonData.itemChanged = true;
            }
            user.eatenBerry = ItemID.None;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " found one " + user.Item.Data().itemName + "!");
        }
    }

    public static IEnumerator BreakScreens(Battle battle, int index)
    {
        Side side = battle.Sides[GetSide(index)];
        string sideText = index < 3 ? "The foes'" : "Your team's";
        if (side.lightScreen)
        {
            side.lightScreen = false;
            yield return battle.Announce(sideText + " Light Screen wore off!");
        }
        if (side.reflect)
        {
            side.reflect = false;
            yield return battle.Announce(sideText + " Reflect wore off!");
        }
    }

    public static IEnumerator HealStatus(Battle battle, int index)
    {
        switch (battle.PokemonOnField[index].PokemonData.status)
        {
            case Status.Paralysis:
                yield return HealParalysis(battle, index);
                break;
            case Status.Burn:
                yield return HealBurn(battle, index);
                break;
            case Status.Poison:
            case Status.ToxicPoison:
                yield return HealPoison(battle, index);
                break;
            case Status.Sleep:
                yield return WakeUp(battle, index);
                break;
            default: break;
        }
    }

    public static IEnumerator Gravity(Battle battle)
    {
        yield return battle.Announce("Gravity intensified!");
        battle.gravity = true;
        battle.gravityTimer = 5;
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].lockedInNextTurn &&
                battle.PokemonOnField[i].lockedInMove is MoveID.Fly or MoveID.Bounce)
            {
                battle.PokemonOnField[i].lockedInNextTurn = false;
                battle.PokemonOnField[i].invulnerability = Invulnerability.None;
            }
            if (battle.Moves[i] is MoveID.FlyAttack or MoveID.BounceAttack)
            {

            }
        }
    }

    public static IEnumerator Tailwind(Battle battle, int side)
    {
        battle.Sides[side].tailwind = true;
        battle.Sides[side].tailwindTurns = 4;
        yield return battle.Announce("A tailwind blew from behind "
            + (side == 0 ? "the foes'" : "your") + " team!");
    }

    public static IEnumerator Embargo(Battle battle, int index)
    {
        battle.PokemonOnField[index].embargoed = true;
        battle.PokemonOnField[index].embargoTimer = 5;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " can't use items anymore!");
    }

    public static IEnumerator PsychoShift(Battle battle, int index, int attacker)
    {
        Pokemon user = battle.PokemonOnField[attacker].PokemonData;
        Pokemon target = battle.PokemonOnField[index].PokemonData;
        if (target.status != Status.None) yield break;
        if (user.status == Status.None) yield break;
        yield return user.status switch
        {
            Status.Burn => GetBurn(battle, index),
            Status.Paralysis => GetParalysis(battle, index),
            Status.Poison => GetPoison(battle, index),
            Status.ToxicPoison => GetBadPoison(battle, index),
            Status.Sleep => FallAsleep(battle, index),
            Status.Freeze => GetFreeze(battle, index), // Impossible, but no reason not to implement
            _ => ScriptUtils.DoNothing()
        };
        yield return HealStatus(battle, attacker);
    }

    public static IEnumerator SuppressAbility(Battle battle, int index)
    {
        battle.PokemonOnField[index].abilitySuppressed = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + "'s ability was suppressed!");
    }

    public static IEnumerator LuckyChant(Battle battle, int side)
    {
        battle.Sides[side].luckyChant = true;
        battle.Sides[side].luckyChantTurns = 5;
        yield return battle.Announce(side == 0 ? "The foes are" : "Your team is" +
            " protected from critical hits!");
    }

    public static IEnumerator WorrySeed(Battle battle, int index)
    {
        yield return battle.AbilityPopupStart(index);
        yield return battle.abilityControllers[index].ChangeAbility(NameTable.Ability[(int)Ability.Insomnia]);
        battle.PokemonOnField[index].ability = Ability.Insomnia;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
            " acquired Insomnia!");
        yield return battle.AbilityPopupEnd(index);
    }

    public static IEnumerator SimpleBeam(Battle battle, int index)
    {
        yield return battle.AbilityPopupStart(index);
        yield return battle.abilityControllers[index].ChangeAbility(NameTable.Ability[(int)Ability.Simple]);
        battle.PokemonOnField[index].ability = Ability.Simple;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) +
            " acquired Simple!");
        yield return battle.AbilityPopupEnd(index);
    }

    public static IEnumerator Defog(Battle battle, int attacker, int target) //Todo: add Sticky Web and Terrain clearing effects
    {
        foreach (Side i in battle.Sides)
        {
            string sideText = (i.whichSide ? "your" : "the opponent's") + " team!";
            if (i.spikes > 0)
            {
                yield return battle.Announce(SpikesDisappeared + sideText);
                i.spikes = 0;
            }
            if (i.toxicSpikes > 0)
            {
                yield return battle.Announce(ToxicSpikesDisappeared + sideText);
                i.toxicSpikes = 0;
            }
            if (i.stealthRock)
            {
                yield return battle.Announce(StealthRockDisappeared + sideText);
                i.stealthRock = false;
            }
            if (i.stickyWeb)
            {
                yield return battle.Announce(StickyWebDisappeared + sideText);
                i.stickyWeb = false;
            }
            if (i.lightScreen)
            {
                yield return battle.Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Light Screen disappeared!");
                i.lightScreen = false;
            }
            if (i.reflect)
            {
                yield return battle.Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Reflect wore off!");
                i.reflect = false;
            }
            if (i.safeguard)
            {
                yield return battle.Announce((i.whichSide ? "Your team's" : "The foes'") +
                    " Safeguard wore off!");
                i.safeguard = false;
            }
            if (i.mist)
            {
                yield return battle.Announce("The mist surrounding "
                    + (i.whichSide ? "your" : "the opponent's") + " team disappeared!");
                i.mist = false;
            }
        }
        if (battle.Sides[GetSide(target)].auroraVeil)
        {
            yield return battle.Announce(target < 3 ? "The foes'" : "Your team's" +
                " Aurora Veil wore off!");
            battle.Sides[GetSide(target)].auroraVeil = false;
        }
        yield return StatDown(battle, target, Stat.Evasion, 1, attacker);
    }

    public static IEnumerator StartTrickRoom(Battle battle, int index)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " twisted the dimensions!");
        battle.trickRoom = true;
        battle.trickRoomTimer = 5;
    }

    public static IEnumerator StartWonderRoom(Battle battle)
    {
        yield return battle.Announce("It created a bizarre area in which" +
            " Defense and Sp. Defense are swapped!");
        battle.wonderRoom = true;
        battle.wonderRoomTimer = 5;
    }

    public static IEnumerator StartMagicRoom(Battle battle)
    {
        yield return battle.Announce("It created a bizarre area in which" +
            " held items lose their effects!");
        battle.magicRoom = true;
        battle.magicRoomTimer = 5;
    }

    public static IEnumerator StealthRock(Battle battle, int index)
    {
        yield return battle.Announce("Pointed stones float in the air around "
            + (index < 3 ? "your" : "the opponent's") + " team!");
        battle.Sides[(5 - index) / 3].stealthRock = true;
    }

    public static IEnumerator StickyWeb(Battle battle, int index)
    {
        yield return battle.Announce("A sticky web spreads out under " +
            (index < 3 ? "your" : "the opponent's") + " team!");
        battle.Sides[(5 - index) / 3].stealthRock = true;
    }

    public static IEnumerator GuardSplit(Battle battle, int index, int attacker)
    {
        BattlePokemon user = battle.PokemonOnField[attacker];
        BattlePokemon target = battle.PokemonOnField[index];
        int newDef = (user.BaseDefense + target.BaseDefense) >> 1;
        int newSpDef = (user.BaseSpDef + target.BaseSpDef) >> 1;
        user.overrideDefenses = true;
        target.overrideDefenses = true;
        user.defenseOverride = newDef;
        target.defenseOverride = newDef;
        user.spDefOverride = newSpDef;
        target.spDefOverride = newSpDef;
        yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
            + " shared its guard with the target!");
    }

    public static IEnumerator PowerSplit(Battle battle, int index, int attacker)
    {
        BattlePokemon user = battle.PokemonOnField[attacker];
        BattlePokemon target = battle.PokemonOnField[index];
        int newAtk = (user.BaseAttack + target.BaseAttack) >> 1;
        int newSpAtk = (user.BaseSpAtk + target.BaseSpAtk) >> 1;
        user.overrideAttacks = true;
        target.overrideAttacks = true;
        user.attackOverride = newAtk;
        target.attackOverride = newAtk;
        user.spAtkOverride = newSpAtk;
        target.spAtkOverride = newSpAtk;
        yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
            + " shared its power with the target!");
    }

    public static IEnumerator AllySwitch(Battle battle, int index, int attacker)
    {
        (battle.PokemonOnField[attacker], battle.PokemonOnField[index]) =
            (battle.PokemonOnField[index], battle.PokemonOnField[attacker]);
        battle.PokemonOnField[index].index = index;
        battle.PokemonOnField[attacker].index = attacker;
        yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
            + " and " + battle.MonNameWithPrefix(index, false)
            + " switched places!");
    }

    public static IEnumerator ReflectType(Battle battle, int user, int target)
    {
        BattlePokemon attacker = battle.PokemonOnField[user];
        BattlePokemon defender = battle.PokemonOnField[target];
        attacker.newType1 = defender.Type1;
        attacker.newType2 = defender.Type2;
        if (defender.hasType3)
        {
            attacker.Type3 = defender.Type3;
            attacker.hasType3 = true;
        }
        attacker.typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(user, true) +
            "'s type changed to match " + battle.MonNameWithPrefix(target, false) +
            "'s!");
    }

    public static IEnumerator MakeRainbow(Battle battle, int index)
    {
        yield return battle.Announce("A rainbow appeared over " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        battle.Sides[GetSide(index)].rainbow = true;
        battle.Sides[GetSide(index)].rainbowTurns = 4;
    }
    public static IEnumerator MakeSwamp(Battle battle, int index)
    {
        yield return battle.Announce("A swamp appeared around " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        battle.Sides[GetSide(index)].swamp = true;
        battle.Sides[GetSide(index)].swampTurns = 4;
    }
    public static IEnumerator MakeBurningField(Battle battle, int index)
    {
        yield return battle.Announce("A burning field surrounds " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        battle.Sides[GetSide(index)].burningField = true;
        battle.Sides[GetSide(index)].burningFieldTurns = 4;
    }

    public static IEnumerator AddType3(Battle battle, int index, Type type)
    {
        yield return battle.Announce("The " + type.Name() + " type was added to " +
            battle.MonNameWithPrefix(index, false) + "!");
        battle.PokemonOnField[index].Type3 = type;
        battle.PokemonOnField[index].hasType3 = true;
    }
}