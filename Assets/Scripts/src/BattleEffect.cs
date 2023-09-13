using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static System.Math;

public static class BattleEffect
{
    public static System.Random random = new();
    public static IEnumerator StatUp(Battle battle, int index, Stat statID, int amount, int attacker, bool doAnimation = true, bool checkContrary = true)
    {
        if (battle.HasAbility(index, Ability.Contrary) && checkContrary)
        {
            yield return StatDown(battle, index, statID, amount, attacker, doAnimation, false);
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
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.CantGoHigher);
                break;
            case 1:
                if (doAnimation) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatRose);
                break;
            case 2:
                if (doAnimation) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatRoseSharply);
                break;
            default:
                if (doAnimation) yield return BattleAnim.StatUp(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatRoseDrastically);
                break;
        }
    }

    public static IEnumerator StatDown(Battle battle, int index, Stat statID, int amount, int attacker, bool doAnimation = true, bool checkContrary = true)
    {
        if (battle.HasAbility(index, Ability.Contrary) && checkContrary)
        {
            yield return StatUp(battle, index, statID, amount, attacker, doAnimation, false);
            yield break;
        }
        if (battle.HasAbility(index, Ability.Simple))
        {
            amount <<= 1;
        }
        if (battle.GetSide(attacker) != battle.GetSide(index)
            && battle.Sides[battle.GetSide(index)].mist)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is protected by Mist!");
            yield break;
        }
        else if (battle.GetSide(attacker) != battle.GetSide(index)
            && battle.EffectiveAbility(index) is
            Ability.WhiteSmoke or Ability.ClearBody)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "'s stats weren't lowered because of "
               + NameTable.Ability[(int)battle.EffectiveAbility(index)]);
            yield break;
        }
        else if (statID == Stat.Attack)
        {

        }
        int stagesLowered = battle.PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.CantGoLower);
                break;
            case 1:
                if (doAnimation) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatFell);
                break;
            case 2:
                if (doAnimation) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatFellSharply);
                break;
            default:
                if (doAnimation) yield return BattleAnim.StatDown(battle, index);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + BattleText.StatFellDrastically);
                break;
        }
        if (battle.GetSide(attacker) != battle.GetSide(index) && battle.HasAbility(index, Ability.Defiant))
        { yield return StatUp(battle, index, Stat.Attack, 2, attacker); }
        if (battle.GetSide(attacker) != battle.GetSide(index) && battle.HasAbility(index, Ability.Competitive))
        { yield return StatUp(battle, index, Stat.SpAtk, 2, attacker); }
    }

    public static IEnumerator GetBurn(Battle battle, int index)
    {
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
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
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        else if (battle.PokemonOnField[index].HasType(Type.Electric))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else if (battle.HasAbility(index, Ability.Limber))
        {
            //Add ability popup
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowParalysis(battle, index);
            battle.PokemonOnField[index].PokemonData.status = Status.Paralysis;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was paralyzed!");
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
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        else if (battle.PokemonOnField[index].HasType(Type.Poison)
            || battle.PokemonOnField[index].HasType(Type.Steel))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else if (battle.EffectiveAbility(index) == Ability.Immunity)
        {
            //Add ability popup
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
        }
        else
        {
            yield return BattleAnim.ShowPoison(battle, index);
            battle.PokemonOnField[index].PokemonData.status = Status.Poison;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was poisoned!");
        }
    }
    public static IEnumerator GetBadPoison(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (battle.Sides[index < 3 ? 0 : 1].safeguard)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (target.PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        else if (target.HasType(Type.Poison)
    || target.HasType(Type.Steel))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else if (battle.EffectiveAbility(index) == Ability.Immunity)
        {
            //Add ability popup
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
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
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        if (battle.PokemonOnField[index].HasType(Type.Ice))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
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
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.Safeguard);
            yield break;
        }
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        else if (battle.EffectiveAbility(index) is Ability.Insomnia or Ability.VitalSpirit)
        {
            //Add ability popup
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false) + "...");
        }
        else if (battle.Uproar)
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " is protected by the uproar!");
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.status = Status.Sleep;
            battle.PokemonOnField[index].PokemonData.sleepTurns = 1 + (random.Next() % 3);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " fell asleep!");
        }
    }

    public static IEnumerator BurnHurt(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        yield return BattleAnim.ShowBurn(battle, index);
        int burnDamage = target.PokemonData.hpMax >> 4;
        if (burnDamage > target.PokemonData.HP)
        {
            target.PokemonData.HP = 0;
            target.PokemonData.fainted = true;
        }
        else
        {
            target.PokemonData.HP -= burnDamage;
        }
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by its burn!");
    }

    public static IEnumerator PoisonHurt(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        int poisonDamage = target.PokemonData.hpMax >> 3;
        if (battle.HasAbility(index, Ability.PoisonHeal))
        {
            Heal(battle, index, poisonDamage);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield break;
        }
        yield return BattleAnim.ShowPoison(battle, index);
        if (poisonDamage > target.PokemonData.HP)
        {
            target.PokemonData.HP = 0;
            target.PokemonData.fainted = true;
        }
        else
        {
            target.PokemonData.HP -= poisonDamage;
        }
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public static IEnumerator ToxicPoisonHurt(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (battle.HasAbility(index, Ability.PoisonHeal))
        {
            Heal(battle, index, target.PokemonData.hpMax >> 3);
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield break;
        }
        yield return BattleAnim.ShowPoison(battle, index);
        target.toxicCounter++;
        int toxicDamage = (target.PokemonData.hpMax >> 4) * target.toxicCounter;
        if (toxicDamage > target.PokemonData.HP)
        {
            target.PokemonData.HP = 0;
            target.PokemonData.fainted = true;
        }
        else
        {
            target.PokemonData.HP -= toxicDamage;
        }
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public static IEnumerator WakeUp(Battle battle, int index)
    {
        battle.PokemonOnField[index].PokemonData.status = Status.None;
        battle.PokemonOnField[index].nightmare = false;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + BattleText.WokeUp);
    }

    public static IEnumerator Confuse(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].confused) { yield break; }
        battle.PokemonOnField[index].confused = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " became confused!");
    }

    public static IEnumerator Disable(Battle battle, int index)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (target.disabled
            || target.lastMoveUsed is MoveID.None or MoveID.Struggle)
        {
            yield return battle.Announce(BattleText.MoveFailed);
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

    public static IEnumerator Heal(Battle battle, int index, int amount)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        if (target.PokemonData.HP < target.PokemonData.hpMax)
        {
            yield return BattleAnim.Heal(battle, index);
            if (target.PokemonData.HP + amount > target.PokemonData.hpMax)
            {
                target.PokemonData.HP = target.PokemonData.hpMax;
            }
            else
            {
                target.PokemonData.HP += amount;
            }
        }
        else
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
    }

    public static IEnumerator Faint(Battle battle, int index)
    {
        string faintedMonName = battle.MonNameWithPrefix(index, true);
        yield return BattleAnim.Faint(battle, index);
        battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index > 2, index % 3);
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
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was wrapped by "
                    + battle.MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Bind:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Bind;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is squeezed by "
                    + battle.MonNameWithPrefix(target.continuousDamageSource, false)
                    + "'s Bind!");
                break;
            case MoveID.FireSpin:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.FireSpin;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was trapped in the vortex!");
                break;
            case MoveID.Clamp:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Clamp;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was clamped by "
                    + battle.MonNameWithPrefix(target.continuousDamageSource, false) + "!");
                break;
            case MoveID.Whirlpool:
                target.getsContinuousDamage = true;
                target.continuousDamageType = ContinuousDamage.Whirlpool;
                target.continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was trapped in the vortex!");
                break;
            default:
                yield return battle.Announce("Error 111");
                yield break;
        }
        target.continuousDamageTimer = 4 + (random.Next() & 1);

    }

    public static IEnumerator VoluntarySwitch(Battle battle, int index, int partyIndex)
    {
        if (index < 3)
        {

            battle.LeaveFieldCleanup(index);
            yield return battle.Announce(battle.OpponentName + " withdrew " + battle.MonNameWithPrefix(index, false) + "!");
            battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(false, index);
            yield return battle.Announce(battle.OpponentName + " sent out "
                + battle.OpponentPokemon[partyIndex].monName + "!");
            battle.PokemonOnField[index] = new BattlePokemon(
                battle.OpponentPokemon[partyIndex], index > 2, index % 3, false);
            battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + battle.PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return battle.MonEntersField(index);
        }
        else
        {
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "! Come back!");
            battle.LeaveFieldCleanup(index);
            battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(true, index - 3);
            yield return battle.Announce("Go! " + battle.PlayerPokemon[partyIndex].monName + "!");
            battle.PokemonOnField[index] = new BattlePokemon(
                            battle.PlayerPokemon[partyIndex], index > 2, index % 3, true);
            battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + battle.PokemonOnField[index].PokemonData.SpeciesData.cryLocation));
            yield return battle.MonEntersField(index);
        }
    }

    public static IEnumerator BatonPass(Battle battle, int index, int partyIndex)
    {
        BatonPassStruct passedData = battle.PokemonOnField[index].MakeBatonPassStruct();
        yield return VoluntarySwitch(battle, index, partyIndex);
        battle.PokemonOnField[index].ApplyBatonPassStruct(passedData);
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
                    if (PokemonArray[i] == battle.PokemonOnField[index].PokemonData) { continue; }
                    if (PokemonArray[i].exists
                            && !PokemonArray[i].fainted)
                    {
                        RemainingPokemon.Add(battle.OpponentPokemon[i]);
                    }
                }
                if (RemainingPokemon.Count == 0)
                {
                    yield return battle.Announce(BattleText.MoveFailed);
                }
                else
                {
                    battle.LeaveFieldCleanup(index);
                    battle.PokemonOnField[index] = new BattlePokemon(
                        RemainingPokemon[random.Next() % RemainingPokemon.Count],
                        index > 2, index % 3, index > 2)
                    {
                        done = true
                    };
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
                damage = target.PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Wrap!");
                break;
            case ContinuousDamage.Bind:
                //yield return BattleAnim.Bind(battle, index);
                damage = target.PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Bind!");
                break;
            case ContinuousDamage.FireSpin:
                //yield return BattleAnim.FireSpin(battle, index);
                damage = target.PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Fire Spin!");
                break;
            case ContinuousDamage.Clamp:
                //yield return BattleAnim.Clamp(battle, index);
                damage = target.PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Clamp!");
                break;
            case ContinuousDamage.Whirlpool:
                //yield return BattleAnim.Whirlpool(battle, index);
                damage = target.PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by Whirlpool!");
                break;
            default:
                yield return battle.Announce("Error 112");
                break;
        }
        if (damage > target.PokemonData.HP)
        {
            target.PokemonData.HP = 0;
            target.PokemonData.fainted = true;
        }
        else
        {
            target.PokemonData.HP -= damage;
        }
    }
    public static IEnumerator StartWeather(Battle battle, Weather weather, int turns)
    {
        battle.weather = weather;
        battle.weatherTimer = turns;
        switch (weather)
        {
            case Weather.Sun:
                yield return battle.Announce(BattleText.SunStart);
                break;
            case Weather.Rain:
                yield return battle.Announce(BattleText.RainStart);
                break;
            case Weather.Sand:
                yield return battle.Announce(BattleText.SandStart);
                break;
            case Weather.Snow:
                yield return battle.Announce(BattleText.SnowStart);
                break;
        }
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
                    yield return battle.Announce(BattleText.SunEnd);
                    break;
                case Weather.Rain:
                    yield return battle.Announce(BattleText.RainEnd);
                    break;
                case Weather.Sand:
                    yield return battle.Announce(BattleText.SandEnd);
                    break;
                case Weather.Snow:
                    yield return battle.Announce(BattleText.SnowEnd);
                    break;
            }
            battle.weather = Weather.None;
        }
        else
        {
            switch (battle.weather)
            {
                case Weather.Sun:
                    yield return battle.Announce(BattleText.SunContinue);
                    break;
                case Weather.Rain:
                    yield return battle.Announce(BattleText.RainContinue);
                    break;
                case Weather.Sand:
                    yield return battle.Announce(BattleText.SandContinue);
                    break;
                case Weather.Snow:
                    yield return battle.Announce(BattleText.SnowContinue);
                    break;
            }
            battle.weatherTimer--;
        }
    }
    public static IEnumerator Rest(Battle battle, int index)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if (battle.Sides[index < 3 ? 0 : 1].safeguard
            || battle.Uproar)
        {
            yield return battle.Announce(BattleText.MoveFailed);
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
            yield return battle.Announce(BattleText.MoveFailed);
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
            yield return battle.Announce(BattleText.MoveFailed);
        }
        else
        {
            //BattleAnim.TransformMon(Battle battle, int index, int target)
            user.isTransformed = true;
            user.transformedMon = battle.PokemonOnField[target].PokemonData.Clone() as Pokemon;
            user.transformedMon.SetTransformPP();
            user.ability = battle.PokemonOnField[target].ability;
            user.ApplyStatStruct(
                battle.PokemonOnField[target].MakeStatStruct()
                );
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " transformed into " + battle.MonNameWithPrefix(target, false));
            yield return battle.EntryAbilityCheck(index);
        }
    }

    public static IEnumerator StartReflect(Battle battle, int side, int index)
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

    public static IEnumerator StartLightScreen(Battle battle, int side, int index)
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
        if (battle.PokemonOnField[attacker].PokemonData.HP > battle.PokemonOnField[target].PokemonData.HP)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        int newHP = (battle.PokemonOnField[attacker].PokemonData.HP + battle.PokemonOnField[target].PokemonData.HP) >> 1;
        battle.PokemonOnField[attacker].PokemonData.HP = newHP;
        battle.PokemonOnField[target].PokemonData.HP = newHP;
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
        yield return Heal(battle, battle.PokemonOnField[index].seedingSlot, healthAmount);
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "'s health was sapped by Leech Seed!");
    }

    public static IEnumerator DoMimic(Battle battle, int index, int target)
    {
        BattlePokemon user = battle.PokemonOnField[index];
        if ((Move.MoveTable[(int)battle.PokemonOnField[target].lastMoveUsed].moveFlags & MoveFlags.cannotMimic) != 0)
        {
            yield return battle.Announce(BattleText.MoveFailed);
            yield break;
        }
        user.mimicking = true;
        user.mimicSlot = battle.MoveNums[index];
        user.mimicMove = battle.PokemonOnField[target].lastMoveUsed;
        user.mimicMaxPP = Move.MoveTable[(int)user.mimicMove].pp;
        user.mimicPP = user.mimicMaxPP;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " mimicked " + Move.MoveTable[(int)user.mimicMove].name + "!");
    }

    public static IEnumerator Conversion(Battle battle, int index)
    {
        Type newType = Move.MoveTable[(int)battle.PokemonOnField[index].GetMove(0)].type;
        battle.PokemonOnField[index].newType1 = newType;
        battle.PokemonOnField[index].newType2 = newType;
        battle.PokemonOnField[index].typesOverriden = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    public static IEnumerator Haze(Battle battle)
    {
        for (int i = 0; i < 6; i++)
        {
            battle.PokemonOnField[i].attackStage = 0;
            battle.PokemonOnField[i].defenseStage = 0;
            battle.PokemonOnField[i].spAtkStage = 0;
            battle.PokemonOnField[i].spDefStage = 0;
            battle.PokemonOnField[i].speedStage = 0;
            battle.PokemonOnField[i].accuracyStage = 0;
            battle.PokemonOnField[i].evasionStage = 0;
            battle.PokemonOnField[i].critStage = 0;
        }
        yield return battle.Announce("All stat changes were reversed!");
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
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + "'s perish counter fell to " + battle.PokemonOnField[index].perishCounter + "!");
        if (battle.PokemonOnField[index].perishCounter <= 0)
        {
            battle.PokemonOnField[index].PokemonData.HP = 0;
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
    }

    public static IEnumerator Infatuate(Battle battle, int index, int attacker)
    {
        if (battle.OppositeGenders(index, attacker) && !battle.PokemonOnField[index].infatuated)
        {
            if (battle.HasAbility(index, Ability.Oblivious))
            {
                //Ability popup
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is protected by Oblivious!");
            }
            else
            {
                battle.PokemonOnField[index].infatuated = true;
                battle.PokemonOnField[index].infatuationTarget = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " became infatuated!");
            }
        }
        else
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }

    }

    public static IEnumerator CureStatusHealBell(Battle battle, Pokemon mon)
    {
        switch (mon.status)
        {
            case Status.Burn:
                yield return battle.Announce(mon.monName + " was cured of its burn!");
                goto case Status.None;
            case Status.Paralysis:
                yield return battle.Announce(mon.monName + " was cured of its paralysis!");
                goto case Status.None;
            case Status.Sleep:
                yield return battle.Announce(mon.monName + " woke up!");
                goto case Status.None;
            case Status.Poison:
            case Status.ToxicPoison:
                yield return battle.Announce(mon.monName + " was cured of its poisoning!");
                goto case Status.None;
            case Status.Freeze:
                yield return battle.Announce(mon.monName + " thawed out!");
                goto case Status.None;
            case Status.None:
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
            battle.PokemonOnField[attacker].PokemonData.item = battle.PokemonOnField[defender].PokemonData.item;
            battle.PokemonOnField[defender].PokemonData.item = ItemID.None;
            yield return battle.Announce(battle.MonNameWithPrefix(attacker, true)
                + " stole " + battle.MonNameWithPrefix(defender, false) + "'s "
                + Item.ItemTable[(int)battle.PokemonOnField[attacker].PokemonData.item].itemName + "!");
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
        if (battle.Sides[battle.GetSide(5 - index)].spikes < 3)
        {
            battle.Sides[battle.GetSide(5 - index)].spikes++;
            yield return battle.Announce("Spikes littered the ground around " + (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
    }

    public static IEnumerator PsychUp(Battle battle, int user, int target)
    {
        battle.PokemonOnField[user].ApplyStatStruct(battle.PokemonOnField[target].MakeStatStruct());
        yield return battle.Announce(battle.MonNameWithPrefix(user, true)
            + " copied " + battle.MonNameWithPrefix(target, false)
            + "'s stat changes!");
    }

    public static IEnumerator DrainPP(Battle battle, int index, int amount)
    {
        BattlePokemon target = battle.PokemonOnField[index];
        bool worked = true;
        switch (target.lastMoveSlot)
        {
            case 1: target.PokemonData.pp1 = (int)Max(0, target.PokemonData.pp1 - amount); break;
            case 2: target.PokemonData.pp2 = (int)Max(0, target.PokemonData.pp2 - amount); break;
            case 3: target.PokemonData.pp3 = (int)Max(0, target.PokemonData.pp3 - amount); break;
            case 4: target.PokemonData.pp4 = (int)Max(0, target.PokemonData.pp4 - amount); break;
            default: worked = false; break;
        }
        if (worked) yield return battle.Announce("It reduced the PP of " + battle.MonNameWithPrefix(index, false)
            + "'s " + battle.GetMove(index).name + " by 4!");
        else yield return battle.Announce(BattleText.MoveFailed);
    }

    public static IEnumerator GetNightmare(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.Sleep || battle.PokemonOnField[index].nightmare)
            yield return battle.Announce(BattleText.MoveFailed);
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
            yield return battle.Announce(BattleText.MoveFailed);
        }
    }

    public static IEnumerator RemoveHazards(Battle battle, int index)
    {
        Side side = battle.Sides[index / 3];
        string teamText = index > 2 ? "your Pokémon!" : "the opponent's Pokémon!";
        if (side.spikes > 0)
        {
            yield return battle.Announce("The spikes disappeared from around " + teamText);
            side.spikes = 0;
        }
    }

    public static IEnumerator Identify(Battle battle, int index)
    {
        battle.PokemonOnField[index].identified = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was identified!");
    }

    public static List<Type> GetConversion2Types(Type type)
    {
        switch (type)
        {
            case Type.Normal:
                return new List<Type>() { Type.Rock, Type.Steel, Type.Ghost };
            case Type.Fire:
                return new List<Type>() { Type.Water, Type.Fire, Type.Rock, Type.Dragon };
            case Type.Water:
                return new List<Type>() { Type.Grass, Type.Water, Type.Dragon };
            case Type.Grass:
                return new List<Type>() { Type.Fire, Type.Grass, Type.Bug, Type.Flying, Type.Poison, Type.Steel, Type.Dragon };
            case Type.Electric:
                return new List<Type>() { Type.Electric, Type.Grass, Type.Dragon, Type.Ground };
            case Type.Ice:
                return new List<Type>() { Type.Fire, Type.Water, Type.Ice, Type.Steel };
            case Type.Ground:
                return new List<Type>() { Type.Grass, Type.Bug, Type.Flying };
            case Type.Rock:
                return new List<Type>() { Type.Ground, Type.Fighting, Type.Steel };
            case Type.Fighting:
                return new List<Type>() { Type.Psychic, Type.Flying, Type.Bug, Type.Fairy, Type.Ghost, Type.Poison };
            case Type.Flying:
                return new List<Type>() { Type.Rock, Type.Electric, Type.Steel };
            case Type.Bug:
                return new List<Type>() { Type.Fire, Type.Flying, Type.Steel, Type.Poison, Type.Fairy, Type.Fighting, Type.Ghost };
            case Type.Poison:
                return new List<Type>() { Type.Ground, Type.Rock, Type.Poison, Type.Steel, Type.Ghost };
            case Type.Psychic:
                return new List<Type>() { Type.Psychic, Type.Dark, Type.Steel };
            case Type.Ghost:
                return new List<Type>() { Type.Dark, Type.Normal };
            case Type.Dragon:
                return new List<Type>() { Type.Steel, Type.Fairy };
            case Type.Dark:
                return new List<Type>() { Type.Fighting, Type.Dark, Type.Fairy };
            case Type.Steel:
                return new List<Type>() { Type.Fire, Type.Water, Type.Electric, Type.Steel };
            case Type.Fairy:
                return new List<Type>() { Type.Steel, Type.Poison, Type.Fire };
            default: return new List<Type>();
        }
    }

    public static IEnumerator Conversion2(Battle battle, int index, int target)
    {
        var random = new System.Random();
        List<Type> possibleTypes = new();
        foreach (Type i in GetConversion2Types(Move.MoveTable[(int)battle.PokemonOnField[target].lastMoveUsed].type))
            if (!battle.PokemonOnField[index].HasType(i)) possibleTypes.Add(i);
        if (possibleTypes.Count == 0)
        {
            yield return battle.Announce(BattleText.MoveFailed);
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
        (int spAtk, int stage, int level, bool stab, bool critical) futureSightData = new()
        {
            level = battle.PokemonOnField[user].PokemonData.level,
            spAtk = battle.PokemonOnField[user].PokemonData.spAtk,
            stage = battle.PokemonOnField[user].spAtkStage,
            stab = battle.PokemonOnField[user].HasType(battle.GetMove(user).type),
            critical = random.NextDouble() < battle.GetCritChance(user, battle.Moves[user]),
        };
        battle.PokemonOnField[target].futureSight = true;
        battle.PokemonOnField[target].futureSightUser = user;
        battle.PokemonOnField[target].futureSightData = futureSightData;
        battle.PokemonOnField[target].futureSightTimer = 3;
        battle.PokemonOnField[target].futureSightType = battle.GetEffectiveType(battle.Moves[user], user);
        battle.PokemonOnField[target].futureSightMove = battle.Moves[user];
        yield return battle.Announce(battle.MonNameWithPrefix(user, true) + " foresaw an attack!");
    }

    public static IEnumerator FutureSightAttack(Battle battle, int target)
    {
        BattlePokemon targetMon = battle.PokemonOnField[target];
        yield return battle.Announce(battle.MonNameWithPrefix(target, true) + " took the Future Sight attack!");
        float effectiveness = battle.GetEffectivenessForFutureSight(targetMon.futureSightType, targetMon);
        int damage = battle.FutureSightDamageCalc(targetMon);
        if (damage > targetMon.PokemonData.HP)
        {
            if (targetMon.ability == Ability.Sturdy && targetMon.AtFullHealth
                && !battle.HasAbility(targetMon.futureSightUser, Ability.MoldBreaker))
            {
                targetMon.PokemonData.HP = 1;
            }
            else if (targetMon.endure && targetMon.futureSightUserOnField)
            {
                targetMon.PokemonData.HP = 1;
            }
            else
            {
                battle.PokemonOnField[target].PokemonData.HP = 0;
                battle.PokemonOnField[target].PokemonData.fainted = true;
            }
        }
        else
        {
            targetMon.PokemonData.HP -= damage;
        }
        yield return battle.AnnounceTypeEffectiveness(effectiveness, false, target);
    }

    public static IEnumerator GetEncored(Battle battle, int target)
    {
        BattlePokemon targetMon = battle.PokemonOnField[target];
        if (targetMon.encored || targetMon.lastMoveUsed == MoveID.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
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
        BattlePokemon user = battle.PokemonOnField[index];
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
        if (battle.PokemonOnField[index].stockpile >= 3) yield break;
        battle.PokemonOnField[index].stockpile++;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true)
            + " stockpiled " + battle.PokemonOnField[index].stockpile + "!");
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
        yield return battle.Announce("The stockpiled effect wore off!");
        user.defenseStage = Max(-6, user.defenseStage - user.stockpile);
        user.spDefStage = Max(-6, user.spDefStage - user.stockpile);
        user.stockpile = 0;
    }
}