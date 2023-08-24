using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattleEffect
{
    public static IEnumerator StatUp(Battle battle, int index, byte statID, int amount)
    {
        int stagesRaised = battle.PokemonOnField[index].RaiseStat(statID, amount);
        switch (stagesRaised)
        {
            case 0:
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.CantGoHigher, battle);
                break;
            case 1:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.Rose, battle);
                break;
            case 2:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.RoseSharply, battle);
                break;
            default:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.RoseDrastically, battle);
                break;
        }
    }

    public static IEnumerator StatDown(Battle battle, int index, byte statID, int amount)
    {
        int stagesLowered = battle.PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.CantGoLower, battle);
                break;
            case 1:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.Fell, battle);
                break;
            case 2:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.FellSharply, battle);
                break;
            default:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.FellDrastically, battle);
                break;
        }
    }

    public static IEnumerator GetBurn(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        if (battle.PokemonOnField[index].PokemonData.SpeciesData().type1 == Type.Fire
            || battle.PokemonOnField[index].PokemonData.SpeciesData().type2 == Type.Fire)
        {
            yield return Battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false), battle);
        }
        else
        {
            yield return BattleAnim.ShowBurn(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Burn;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was burned!", battle);
        }
    }
    public static IEnumerator GetParalysis(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        else
        {
            yield return BattleAnim.ShowParalysis(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Paralysis;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was paralyzed!", battle);
        }
    }
    public static IEnumerator GetPoison(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        else
        {
            yield return BattleAnim.ShowPoison(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Poison;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was poisoned!", battle);
        }
    }
    public static IEnumerator GetBadPoison(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        else
        {
            yield return BattleAnim.ShowToxicPoison(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.ToxicPoison;
            battle.PokemonOnField[index].toxicCounter = 0;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was badly poisoned!", battle);
        }
    }
    public static IEnumerator GetFreeze(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        else
        {
            yield return BattleAnim.ShowFreeze(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Freeze;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was frozen solid!", battle);
        }
    }
    public static IEnumerator FallAsleep(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.status = Status.Sleep;
            battle.PokemonOnField[index].PokemonData.sleepTurns = 0;
            yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " fell asleep!", battle);
        }
    }

    public static IEnumerator BurnHurt(Battle battle, int index)
    {
        yield return BattleAnim.ShowBurn(battle.maskManager[index]);
        int burnDamage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
        if (burnDamage > battle.PokemonOnField[index].PokemonData.HP)
        {
            battle.PokemonOnField[index].PokemonData.HP = 0;
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.HP -= (ushort)burnDamage;
        }
        yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by its burn!", battle);
    }

    public static IEnumerator PoisonHurt(Battle battle, int index)
    {
        yield return BattleAnim.ShowPoison(battle.maskManager[index]);
        int poisonDamage = battle.PokemonOnField[index].PokemonData.hpMax >> 3;
        if (poisonDamage > battle.PokemonOnField[index].PokemonData.HP)
        {
            battle.PokemonOnField[index].PokemonData.HP = 0;
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.HP -= (ushort)poisonDamage;
        }
        yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!", battle);
    }

    public static IEnumerator ToxicPoisonHurt(Battle battle, int index)
    {
        yield return BattleAnim.ShowPoison(battle.maskManager[index]);
        battle.PokemonOnField[index].toxicCounter++;
        int toxicDamage = (battle.PokemonOnField[index].PokemonData.hpMax >> 4) * battle.PokemonOnField[index].toxicCounter;
        if (toxicDamage > battle.PokemonOnField[index].PokemonData.HP)
        {
            battle.PokemonOnField[index].PokemonData.HP = 0;
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.HP -= (ushort)toxicDamage;
        }
        yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!", battle);
    }

    public static IEnumerator Confuse (Battle battle, int index)
    {
        if (battle.PokemonOnField[index].confused) { yield break; }
        battle.PokemonOnField[index].confused = true;
        yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " became confused!", battle);
    }

    public static IEnumerator Heal(Battle battle, int index, int amount)
    {
        if (battle.PokemonOnField[index].PokemonData.HP < battle.PokemonOnField[index].PokemonData.hpMax)
        {
            yield return BattleAnim.Heal(battle, index);
            if (battle.PokemonOnField[index].PokemonData.HP + amount > battle.PokemonOnField[index].PokemonData.hpMax)
            {
                battle.PokemonOnField[index].PokemonData.HP = battle.PokemonOnField[index].PokemonData.hpMax;
            }
            else
            {
                battle.PokemonOnField[index].PokemonData.HP += (ushort)amount;
            }
        }
        else
        {
            yield return null;
        }
    }

    public static IEnumerator Faint(Battle battle, int index)
    {
        string faintedMonName = battle.MonNameWithPrefix(index, true);
        yield return BattleAnim.Faint(battle, index);
        battle.PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index > 2, index % 3);
        yield return null;
        battle.spriteRenderer[index].maskInteraction = SpriteMaskInteraction.None;
        yield return Battle.Announce(faintedMonName + " fainted!", battle);
    }

    public static IEnumerator GetContinuousDamage(Battle battle, int attacker, int index, ushort move)
    {
        if (battle.PokemonOnField[index].getsContinuousDamage)
        {
            yield break;
        }
        switch(move)
        {
            case MoveID.Wrap:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.Wrap;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was wrapped by "
                    + battle.MonNameWithPrefix(battle.PokemonOnField[index].continuousDamageSource, false), battle);
                break;
            case MoveID.Bind:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.Bind;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " is squeezed by "
                    + battle.MonNameWithPrefix(battle.PokemonOnField[index].continuousDamageSource, false)
                    + "'s Bind!", battle);
                break;
        }

    }

    public static IEnumerator DoContinuousDamage(Battle battle, int index, ContinuousDamage type)
    {
        int damage = 0;
        switch(type)
        {
            case ContinuousDamage.None:
                yield return Battle.Announce("Error 11", battle);
                break;
            case ContinuousDamage.Wrap:
                //yield return BattleAnim.Wrap(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Wrap!", battle);
                break;
            case ContinuousDamage.Bind:
                //yield return BattleAnim.Bind(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return Battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Bind!", battle);
                break;
        }
        if (damage > battle.PokemonOnField[index].PokemonData.HP)
        {
            battle.PokemonOnField[index].PokemonData.HP = 0;
            battle.PokemonOnField[index].PokemonData.fainted = true;
        }
        else
        {
            battle.PokemonOnField[index].PokemonData.HP -= (ushort)damage;
        }
    }
    public static IEnumerator StartWeather(Battle battle, Weather weather, byte turns)
    {
        battle.weather = weather;
        battle.weatherTimer = turns;
        switch (weather)
        {
            case Weather.Sun:
                yield return Battle.Announce(BattleText.SunStart, battle);
                break;
            case Weather.Rain:
                yield return Battle.Announce(BattleText.RainStart, battle);
                break;
            case Weather.Sand:
                yield return Battle.Announce(BattleText.SandStart, battle);
                break;
            case Weather.Snow:
                yield return Battle.Announce(BattleText.SnowStart, battle);
                break;
        }
    }
    public static IEnumerator WeatherContinues(Battle battle)
    {
        if(battle.weather == Weather.None)
        {
            yield break;
        }
        if(battle.weatherTimer == 0)
        {
            switch (battle.weather)
            {
                case Weather.Sun:
                    yield return Battle.Announce(BattleText.SunEnd, battle);
                    break;
                case Weather.Rain:
                    yield return Battle.Announce(BattleText.RainEnd, battle);
                    break;
                case Weather.Sand:
                    yield return Battle.Announce(BattleText.SandEnd, battle);
                    break;
                case Weather.Snow:
                    yield return Battle.Announce(BattleText.SnowEnd, battle);
                    break;
            }
            battle.weather = Weather.None;
        }
        else
        {
            switch (battle.weather)
            {
                case Weather.Sun:
                    yield return Battle.Announce(BattleText.SunContinue, battle);
                    break;
                case Weather.Rain:
                    yield return Battle.Announce(BattleText.RainContinue, battle);
                    break;
                case Weather.Sand:
                    yield return Battle.Announce(BattleText.SandContinue, battle);
                    break;
                case Weather.Snow:
                    yield return Battle.Announce(BattleText.SnowContinue, battle);
                    break;
            }
            battle.weatherTimer--;
        }
    }
}
