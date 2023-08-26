using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattleEffect
{
    public static System.Random random = new();
    public static IEnumerator StatUp(Battle battle, int index, byte statID, int amount)
    {
        int stagesRaised = battle.PokemonOnField[index].RaiseStat(statID, amount);
        switch (stagesRaised)
        {
            case 0:
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.CantGoHigher);
                break;
            case 1:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.Rose);
                break;
            case 2:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.RoseSharply);
                break;
            default:
                yield return BattleAnim.StatUp(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.RoseDrastically);
                break;
        }
    }

    public static IEnumerator StatDown(Battle battle, int index, byte statID, int amount)
    {
        int stagesLowered = battle.PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.CantGoLower);
                break;
            case 1:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.Fell);
                break;
            case 2:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.FellSharply);
                break;
            default:
                yield return BattleAnim.StatDown(battle.audioSource, battle.maskManager[index]);
                yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                    + "'s " + StatID.statName[statID] + BattleText.FellDrastically);
                break;
        }
    }

    public static IEnumerator GetBurn(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
        if (battle.PokemonOnField[index].HasType(Type.Fire))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowBurn(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Burn;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was burned!");
        }
    }
    public static IEnumerator GetParalysis(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
        if (battle.PokemonOnField[index].HasType(Type.Electric))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowParalysis(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Paralysis;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was paralyzed!");
        }
    }
    public static IEnumerator GetPoison(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
        if (battle.PokemonOnField[index].HasType(Type.Poison)
            || battle.PokemonOnField[index].HasType(Type.Steel))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowPoison(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Poison;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was poisoned!");
        }
    }
    public static IEnumerator GetBadPoison(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
        if (battle.PokemonOnField[index].HasType(Type.Poison)
    || battle.PokemonOnField[index].HasType(Type.Steel))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowToxicPoison(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.ToxicPoison;
            battle.PokemonOnField[index].toxicCounter = 0;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was badly poisoned!");
        }
    }
    public static IEnumerator GetFreeze(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].PokemonData.status != Status.None)
        {
            yield return null;
        }
        if (battle.PokemonOnField[index].HasType(Type.Ice))
        {
            yield return battle.Announce("It doesn't affect " + battle.MonNameWithPrefix(index, false));
        }
        else
        {
            yield return BattleAnim.ShowFreeze(battle.maskManager[index]);
            battle.PokemonOnField[index].PokemonData.status = Status.Freeze;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was frozen solid!");
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
            battle.PokemonOnField[index].PokemonData.sleepTurns = (byte)(1 + (random.Next() % 3));
            yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " fell asleep!");
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
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by its burn!");
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
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
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
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    public static IEnumerator Confuse(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].confused) { yield break; }
        battle.PokemonOnField[index].confused = true;
        yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " became confused!");
    }

    public static IEnumerator Disable(Battle battle, int index)
    {
        if (battle.PokemonOnField[index].disabled)
        {
            yield break;
        }
        if (battle.PokemonOnField[index].lastMoveUsed is MoveID.None or MoveID.Struggle)
        {

        }
        battle.PokemonOnField[index].disabled = true;
        battle.PokemonOnField[index].disable = battle.PokemonOnField[index].lastMoveUsed;
        battle.PokemonOnField[index].disableTimer = 4;
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

    public static IEnumerator GetContinuousDamage(Battle battle, int attacker, int index, MoveID move)
    {
        if (battle.PokemonOnField[index].getsContinuousDamage)
        {
            yield break;
        }
        switch (move)
        {
            case MoveID.Wrap:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.Wrap;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was wrapped by "
                    + battle.MonNameWithPrefix(battle.PokemonOnField[index].continuousDamageSource, false) + "!");
                break;
            case MoveID.Bind:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.Bind;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " is squeezed by "
                    + battle.MonNameWithPrefix(battle.PokemonOnField[index].continuousDamageSource, false)
                    + "'s Bind!");
                break;
            case MoveID.FireSpin:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.FireSpin;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was trapped in the vortex!");
                break;
            case MoveID.Clamp:
                battle.PokemonOnField[index].getsContinuousDamage = true;
                battle.PokemonOnField[index].continuousDamageType = ContinuousDamage.Clamp;
                battle.PokemonOnField[index].continuousDamageSource = attacker;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was clamped by "
                    + battle.MonNameWithPrefix(battle.PokemonOnField[index].continuousDamageSource, false) + "!");
                break;
            default:
                yield return battle.Announce("Error 301");
                break;
        }

    }

    public static IEnumerator DoContinuousDamage(Battle battle, int index, ContinuousDamage type)
    {
        int damage = 0;
        switch (type)
        {
            case ContinuousDamage.Wrap:
                //yield return BattleAnim.Wrap(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Wrap!");
                break;
            case ContinuousDamage.Bind:
                //yield return BattleAnim.Bind(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Bind!");
                break;
            case ContinuousDamage.FireSpin:
                //yield return BattleAnim.FireSpin(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Fire Spin!");
                break;
            case ContinuousDamage.Clamp:
                //yield return BattleAnim.FireSpin(battle, index);
                damage = battle.PokemonOnField[index].PokemonData.hpMax >> 4;
                yield return battle.Announce(battle.MonNameWithPrefix(index, true) + " was hurt by Clamp!");
                break;
            default:
                yield return battle.Announce("Error 302");
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
    public static IEnumerator Rest(Battle battle, int index) {
        if (battle.PokemonOnField[index].PokemonData.HP
            < battle.PokemonOnField[index].PokemonData.hpMax)
        {
            battle.PokemonOnField[index].PokemonData.status = Status.Sleep;
            battle.PokemonOnField[index].PokemonData.sleepTurns = 2;
            yield return battle.Announce(battle.MonNameWithPrefix(index, true)
                + " rested and became healthy!");
            yield return Heal(battle, index,
                battle.PokemonOnField[index].PokemonData.hpMax);
        }
        else
        {
            yield return battle.Announce(BattleText.MoveFailed);
        }
    }
}
