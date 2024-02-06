using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using static BattleText;
using static Ability;
using System;

public partial class Battle
{
    private IEnumerator StatUp(int index, Stat statID,
        int amount, int attacker, bool checkContrary = true, bool checkSimple = true,
        bool checkOpportunist = true)
    {
        if (HasAbility(index, Contrary) && checkContrary
            && !HasMoldBreaker(index))
        {
            yield return StatDown(index, statID, amount, attacker, false);
            yield break;
        }
        if (checkOpportunist)
            foreach (int i in GetAdjacentOpponents(index)) //Judgment call,
                                                           //but distant opponents usually don't interact
            {
                if (HasAbility(i, Opportunist))
                    yield return StatUp(i, statID, amount, i, checkOpportunist: false);
            }
        if (HasAbility(index, Simple) && checkSimple)
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
                if (doStatAnim) yield return StatUpAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRose);
                break;
            case 2:
                if (doStatAnim) yield return StatUpAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseSharply);
                break;
            default:
                if (doStatAnim) yield return StatUpAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatRoseDrastically);
                break;
        }
        if (stagesRaised > 0) { PokemonOnField[index].statsRoseThisTurn = true; doStatAnim = false; }
    }

    private IEnumerator StatDown(int index, Stat statID,
        int amount, int attacker, bool checkContrary = true, bool checkSide = true, bool checkMirrorArmor = true)
    {
        switch (EffectiveAbility(index))
        {
            case Contrary when checkContrary:
                yield return StatUp(index, statID, amount, attacker, false);
                yield break;
            case MirrorArmor when checkMirrorArmor && attacker != index:
                yield return PopupDo(index, StatDown(attacker, statID, amount, index, checkMirrorArmor: false));
                yield break;
            case Simple: amount <<= 1; break;
            case WhiteSmoke or ClearBody or FullMetalBody:
            case KeenEye or Illuminate or MindsEye when statID == Stat.Accuracy:
            case HyperCutter when statID == Stat.Attack:
            case BigPecks when statID == Stat.Defense:
                if ((!checkSide || GetSideNumber(attacker) != GetSideNumber(index)) &&
                        (!HasMoldBreaker(attacker) || HasAbility(index, FullMetalBody)))
                {
                    yield return AbilityPopupStart(index);
                    yield return Announce(MonNameWithPrefix(index, true) +
                        "'s stats weren't lowered!");
                    yield return AbilityPopupEnd(index);
                    yield break;
                }
                else break;
        }
        if ((!checkSide || GetSideNumber(attacker) != GetSideNumber(index))
            && Sides[GetSideNumber(index)].mist)
        {
            yield return Announce(MonNameWithPrefix(index, true) +
                " is protected by Mist!");
            yield break;
        }
        if ((!checkSide || GetSideNumber(attacker) != GetSideNumber(index)))
        {
            if (Sides[GetSideNumber(index)].mist)
            {
                yield return Announce(MonNameWithPrefix(index, true) +
                    " is protected by Mist!");
                yield break;
            }
            if (PokemonOnField[index].HasType(Type.Grass) && !HasMoldBreaker(attacker))
            {
                int flowerVeilUser = NoMons;
                for (int i = 0; i < 3; i++)
                {
                    if (HasAbility(GetSideNumber(index) * 3 + i, FlowerVeil))
                    {
                        flowerVeilUser = GetSideNumber(index) * 3 + 1;
                        break;
                    }
                }
                if (flowerVeilUser != NoMons)
                {
                    yield return AbilityPopupStart(flowerVeilUser);
                    yield return Announce(MonNameWithPrefix(index, true) +
                        "'s stats weren't lowered!");
                    yield return AbilityPopupEnd(flowerVeilUser);
                    yield break;
                }
            }
        }
        int stagesLowered = PokemonOnField[index].LowerStat(statID, amount);
        switch (stagesLowered)
        {
            case 0:
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + CantGoLower);
                break;
            case 1:
                if (doStatAnim) yield return StatDownAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFell);
                break;
            case 2:
                if (doStatAnim) yield return StatDownAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellSharply);
                break;
            default:
                if (doStatAnim) yield return StatDownAnim(index);
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s " + NameTable.Stat[(int)statID] + StatFellDrastically);
                break;
        }
        if (stagesLowered > 0) { PokemonOnField[index].statsDroppedThisTurn = true; doStatAnim = false; }
        if ((!checkSide || GetSideNumber(attacker) != GetSideNumber(index)) &&
            HasAbility(index, Defiant))
        {
            doStatAnim = true;
            yield return AbilityPopupStart(index);
            yield return StatUp(index, Stat.Attack, 2, attacker);
            yield return AbilityPopupEnd(index);
        }
        if ((!checkSide || GetSideNumber(attacker) != GetSideNumber(index))
            && HasAbility(index, Competitive))
        {
            doStatAnim = true;
            yield return AbilityPopupStart(index);
            yield return StatUp(index, Stat.SpAtk, 2, attacker);
            yield return AbilityPopupEnd(index);
        }

    }

    private IEnumerator GetBurn(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].pokemon.status != Status.None)
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
            PokemonOnField[index].pokemon.status = Status.Burn;
            yield return Announce(MonNameWithPrefix(index, true) + " was burned!");
        }
    }
    private IEnumerator GetParalysis(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].pokemon.status != Status.None)
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
        else if (HasAbility(index, Limber))
        {
            yield return AbilityPopupStart(index);
            yield return Announce("It doesn't affect " + MonNameWithPrefix(index, false));
            yield return AbilityPopupEnd(index);
        }
        else
        {
            yield return ShowParalysis(index);
            PokemonOnField[index].pokemon.status = Status.Paralysis;
            yield return Announce(MonNameWithPrefix(index, true) + " was paralyzed!");
        }
    }
    private IEnumerator HealParalysis(int index)
    {
        if (PokemonOnField[index].pokemon.status == Status.Paralysis)
        {
            PokemonOnField[index].pokemon.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " was cured of its paralysis!");
        }
    }
    private IEnumerator HealBurn(int index)
    {
        if (PokemonOnField[index].pokemon.status == Status.Burn)
        {
            PokemonOnField[index].pokemon.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " was cured of its burn!");
        }
    }
    private IEnumerator HealPoison(int index)
    {
        if (PokemonOnField[index].pokemon.status is Status.Poison or Status.ToxicPoison)
        {
            PokemonOnField[index].pokemon.status = Status.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " is no longer poisoned!");
        }
    }
    private IEnumerator DoTriAttack(int index, int attacker)
    {
        var random = new System.Random();
        switch (random.Next() % 3)
        {
            case 0 when CanStatus(index, Status.Burn, attacker):
                yield return GetBurn(index);
                break;
            case 1 when CanStatus(index, Status.Paralysis, attacker):
                yield return GetParalysis(index);
                break;
            case 2 when CanStatus(index, Status.Freeze, attacker):
                yield return GetFreeze(index);
                break;
            default:
                break;
        }
    }
    private IEnumerator DoDireClaw(int index, int attacker)
    {
        var random = new System.Random();
        switch (random.Next() % 3)
        {
            case 0 when CanStatus(index, Status.Poison, attacker):
                yield return GetPoison(index, false, attacker);
                break;
            case 1 when CanStatus(index, Status.Paralysis, attacker):
                yield return GetParalysis(index);
                break;
            case 2 when CanStatus(index, Status.Sleep, attacker):
                yield return FallAsleep(index);
                break;
            default:
                break;
        }
    }
    private IEnumerator GetPoison(int index, bool announceFailure = true, int attacker = ReturnFalse)
    {
        BattlePokemon target = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure && announceFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.pokemon.status != Status.None)
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
        else if (EffectiveAbility(index) is Immunity && !HasMoldBreaker(attacker))
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
            if (attacker < 6)
            {
                if (HasAbility(attacker, PoisonPuppeteer) && !PokemonOnField[index].confused) yield return Confuse(index);
            }
            yield return ShowPoison(index);
            target.pokemon.status = Status.Poison;
            yield return Announce(MonNameWithPrefix(index, true) + " was poisoned!");
        }
    }
    private IEnumerator GetBadPoison(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (target.pokemon.status != Status.None)
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
        else if (EffectiveAbility(index) == Immunity)
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
            target.pokemon.status = Status.ToxicPoison;
            target.toxicCounter = 0;
            yield return Announce(MonNameWithPrefix(index, true) + " was badly poisoned!");
        }
    }
    private IEnumerator GetFreeze(int index)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        else if (PokemonOnField[index].pokemon.status != Status.None)
        {
            if (ShowFailure)
                yield return Announce(MoveFailed);
            yield break;
        }
        else if (HasAbility(index, MagmaArmor))
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
            PokemonOnField[index].pokemon.status = Status.Freeze;
            yield return Announce(MonNameWithPrefix(index, true) + " was frozen solid!");
        }
    }
    private IEnumerator FallAsleep(int index, int attacker = 63)
    {
        if (Sides[index < 3 ? 0 : 1].safeguard)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true) + Safeguard);
            yield break;
        }
        if (PokemonOnField[index].pokemon.status != Status.None)
        {
            if (ShowFailure)
                yield return Announce(MoveFailed);
            yield break;
        }
        else if (EffectiveAbility(index) is Insomnia or VitalSpirit
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
            PokemonOnField[index].pokemon.status = Status.Sleep;
            PokemonOnField[index].pokemon.sleepTurns = 1 + (random.Next() % 3);
            if (HasAbility(index, EarlyBird))
                PokemonOnField[index].pokemon.sleepTurns >>= 1;
            yield return Announce(MonNameWithPrefix(index, true) + " fell asleep!");
        }
    }

    private IEnumerator InflictStatus(int index, Status status, int attacker)
    {
        if (!CanStatus(index, status)) yield break;
        yield return status switch
        {
            Status.Burn => GetBurn(index),
            Status.Paralysis => GetParalysis(index),
            Status.Poison => GetPoison(index, false, attacker),
            Status.ToxicPoison => GetBadPoison(index),
            Status.Sleep => FallAsleep(index, attacker),
            Status.Freeze => GetFreeze(index),
            _ => null
        };
    }

    private IEnumerator BurnHurt(int index)
    {
        yield return ShowBurn(index);
        yield return PokemonOnField[index].DoProportionalDamage(0.0625F);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by its burn!");
    }

    private IEnumerator PoisonHurt(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        int poisonDamage = target.pokemon.hpMax >> 3;
        if (HasAbility(index, PoisonHeal))
        {
            yield return AbilityPopupStart(index);
            yield return Heal(index, target.pokemon.hpMax >> 3);
            yield return Announce(MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return AbilityPopupEnd(index);
            yield break;
        }
        yield return ShowPoison(index);
        yield return PokemonOnField[index].DoProportionalDamage(0.125F);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    private IEnumerator ToxicPoisonHurt(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (HasAbility(index, PoisonHeal))
        {
            yield return AbilityPopupStart(index);
            yield return Heal(index, target.pokemon.hpMax >> 3);
            yield return Announce(MonNameWithPrefix(index, true) + " is healed by Poison Heal!");
            yield return AbilityPopupEnd(index);
            yield break;
        }
        yield return ShowPoison(index);
        target.toxicCounter++;
        yield return target.DoProportionalDamage(0.0625F * target.toxicCounter);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by poison!");
    }

    private IEnumerator WakeUp(int index)
    {
        PokemonOnField[index].pokemon.status = Status.None;
        PokemonOnField[index].nightmare = false;
        yield return Announce(MonNameWithPrefix(index, true) + WokeUp);
    }

    private IEnumerator Confuse(int index)
    {
        if (PokemonOnField[index].confused)
        {
            if (ShowFailure)
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is already confused! ");
            yield break;
        }
        if (HasAbility(index, OwnTempo))
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

    private bool CanDisable(int index) => (!PokemonOnField[index].disabled &&
        PokemonOnField[index].lastMoveUsed is not MoveID.None or MoveID.Struggle);

    private IEnumerator Disable(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (!CanDisable(index))
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

    private IEnumerator StartMist(int side)
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

    private IEnumerator Heal(int index, int amount,
        bool overrideBlock = false)
    {
        BattlePokemon target = PokemonOnField[index];
        if (target.healBlocked && !overrideBlock) yield break;
        if (target.pokemon.hp < target.pokemon.hpMax)
        {
            yield return Heal(index);
            if (target.pokemon.hp + amount > target.pokemon.hpMax)
            {
                yield return DoDamage(target.pokemon, target.pokemon.hp - target.pokemon.hpMax);
            }
            else
            {
                yield return DoDamage(target.pokemon, -1 * amount);
            }
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    private IEnumerator Faint(int index)
    {
        string faintedMonName = MonNameWithPrefix(index, true);
        yield return FaintAnim(index);
        PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
        yield return null;
        spriteRenderer[index].maskInteraction = SpriteMaskInteraction.None;
        yield return Announce(faintedMonName + " fainted!");
    }

    private IEnumerator StartTrapping(int attacker, int index)
    {
        if (PokemonOnField[index].trapped)
        {
            yield break;
        }
        PokemonOnField[index].trapped = true;
        PokemonOnField[index].trappingSlot = attacker;
        yield return Announce(MonNameWithPrefix(index, true) + " can no longer escape!");
    }

    private IEnumerator GetContinuousDamage(int attacker, int index, MoveID move)
    {
        BattlePokemon target = PokemonOnField[index];
        if (target.partialTrapped)
        {
            yield break;
        }
        switch (move)
        {
            case MoveID.Wrap:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Wrap;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was wrapped by "
                    + MonNameWithPrefix(target.partialTrappingSource, false) + "!");
                break;
            case MoveID.Bind:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Bind;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " is squeezed by " +
                    MonNameWithPrefix(target.partialTrappingSource, false) + "'s Bind!");
                break;
            case MoveID.FireSpin:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.FireSpin;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.Clamp:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Clamp;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was clamped by " +
                    MonNameWithPrefix(target.partialTrappingSource, false) + "!");
                break;
            case MoveID.Whirlpool:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Whirlpool;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the vortex!");
                break;
            case MoveID.SandTomb:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.SandTomb;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped by Sand Tomb!");
                break;
            case MoveID.MagmaStorm:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.MagmaStorm;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " was trapped in the swirling magma!");
                break;
            case MoveID.Infestation:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Infestation;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " has been inflicted by " +
                    MonNameWithPrefix(attacker, false) + "'s Infestation!");
                break;
            case MoveID.Octolock:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.Octolock;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " can no longer escape because of Octolock!");
                break;
            case MoveID.SnapTrap:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.SnapTrap;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(index, true) +
                    " got trapped by a snap trap!");
                break;
            case MoveID.ThunderCage:
                target.partialTrapped = true;
                target.partialTrappingType = PartialTrapping.ThunderCage;
                target.partialTrappingSource = attacker;
                yield return Announce(MonNameWithPrefix(attacker, true) +
                    " trapped " + MonNameWithPrefix(index, false) + "!");
                break;
            default:
                yield return Announce("Error 111");
                yield break;
        }
        target.partialTrappingTimer = 4 + (random.Next() & 1);

    }

    private IEnumerator GetGMaxDamage(GMaxContinuousDamage damageType, Side side)
    {
        side.gMaxContinuousDamage = damageType;
        side.gMaxDamageTurns = 4;
        yield return Announce(side.whichSide ? "Your" : "The opposing"
            + " Pokémon " + damageType switch
        {
            GMaxContinuousDamage.Wildfire => "were surrounded by fire!",
            GMaxContinuousDamage.Cannonade => "got caught in the vortex of water!",
            GMaxContinuousDamage.VineLash => "became trapped with vines!",
            GMaxContinuousDamage.Volcalith => "became surrounded with rocks!",
            _ => "Invalid G-Max damage"

        });
    }

    private IEnumerator VoluntarySwitch(int index, int partyIndex, bool doAnnouncement, bool fromMove)
    {
        if (index < 3)
        {
            yield return ExitAbilityCheck(index);
            if (PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return Announce(MonNameWithPrefix(index, true) + " came back to "
                        + opponentName + "!");
                else
                    yield return Announce(opponentName + " withdrew " + MonNameWithPrefix(index, false) + "!");
            }
            LeaveField(index);
            yield return Announce(opponentName + " sent out "
                + opponentPokemon[partyIndex].MonName + "!");
            PokemonOnField[index] = new(opponentPokemon[partyIndex], index, false, this);
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].pokemon.SpeciesData.cryLocation));
            yield return MonEntersField(index);
        }
        else
        {
            yield return ExitAbilityCheck(index);
            if (PokemonOnField[index].exists && doAnnouncement)
            {
                if (fromMove)
                    yield return Announce(MonNameWithPrefix(index, true) + " came back to "
                        + player.name + "!");
                else
                    yield return Announce(MonNameWithPrefix(index, true) + "! Come back!");
            }
            LeaveField(index);
            yield return Announce("Go! " + playerPokemon[partyIndex].MonName + "!");
            PokemonOnField[index] = new(playerPokemon[partyIndex], index, true, this);
            PokemonOnField[index].partyIndex = partyIndex;
            HandleFacing(index);
            audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Cries/"
                + PokemonOnField[index].pokemon.SpeciesData.cryLocation));
            yield return MonEntersField(index);
        }
    }

    private void LeaveField(int index)
    {
        LeaveFieldCleanup(index);
        PokemonOnField[index] = BattlePokemon.MakeEmptyBattleMon(index, this);
    }

    private IEnumerator BatonPass(int index, int partyIndex)
    {
        BatonPassStruct passedData = PokemonOnField[index].MakeBatonPassStruct();
        yield return VoluntarySwitch(index, partyIndex, false, true);
        PokemonOnField[index].ApplyBatonPassStruct(passedData);
        yield return EntryAbilityCheck(index);
    }

    private IEnumerator HeartSwap(int user, int target)
    {
        StatStruct targetData = PokemonOnField[target].MakeStatStruct();
        PokemonOnField[target].ApplyStatStruct(PokemonOnField[user].MakeStatStruct());
        PokemonOnField[user].ApplyStatStruct(targetData);
        yield return Announce(MonNameWithPrefix(user, true) +
            " swapped stat changes with its target!");
    }

    private IEnumerator ForcedSwitch(int index)
    {
        switch (battleType) //Todo: Implement Multi Battle functionality
        {
            case BattleType.Single:
            default:
                List<int> RemainingIndices = new();
                Pokemon[] PokemonArray = index < 3 ? opponentPokemon : playerPokemon;
                for (int i = 0; i < 6; i++)
                {
                    if (PokemonArray[i] == PokemonOnField[index].pokemon) continue;
                    if (PokemonArray[i].exists
                            && !PokemonArray[i].fainted)
                    {
                        RemainingIndices.Add(i);
                    }
                }
                if (RemainingIndices.Count == 0)
                {
                    if (ShowFailure)
                        yield return Announce(MoveFailed);
                }
                else
                {
                    int partyIndex = RemainingIndices.GetRandom();
                    yield return ExitAbilityCheck(index);
                    LeaveFieldCleanup(index);
                    PokemonOnField[index] = new BattlePokemon(
                        PokemonArray[partyIndex],
                        index, index > 2, this)
                    {
                        done = true,
                        partyIndex = partyIndex
                    };
                    HandleFacing(index);
                    yield return Announce(PokemonOnField[index].pokemon.MonName
                        + " was dragged out!");
                }
                break;

        }
    }

    private IEnumerator MakeSubstitute(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        if (user.pokemon.hp
            < user.pokemon.hpMax >> 2)
        {
            yield return Announce(MonNameWithPrefix(index, true)
                + " doesn't have enough HP left to make a substitute!");
            yield break;
        }
        else
        {
            user.hasSubstitute = true;
            user.substituteHP
                = user.pokemon.hpMax >> 2;
            user.pokemon.hp
                -= user.substituteHP;
            yield return Announce(MonNameWithPrefix(index, true)
    + " cut its own HP to make a substitute!");
        }
    }

    private IEnumerator SubstituteFaded(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s substitute faded!");
        PokemonOnField[index].hasSubstitute = false;
    }

    private IEnumerator CheckContinuousDamage(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (!target.partialTrapped || (HasAbility(index, MagicGuard) &&
            target.partialTrappingType != PartialTrapping.Octolock)) yield break;
        int damage = 0;
        PartialTrapping type = target.partialTrappingType;
        switch (type)
        {
            case PartialTrapping.Wrap:
                //yield return WrapAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true) + " is hurt by Wrap!");
                break;
            case PartialTrapping.Bind:
                //yield return BindAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Bind!");
                break;
            case PartialTrapping.FireSpin:
                //yield return FireSpinAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Fire Spin!");
                break;
            case PartialTrapping.Clamp:
                //yield return ClampAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Clamp!");
                break;
            case PartialTrapping.Whirlpool:
                //yield return WhirlpoolAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Whirlpool!");
                break;
            case PartialTrapping.SandTomb:
                //yield return SandTombAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Sand Tomb!");
                break;
            case PartialTrapping.MagmaStorm:
                //yield return MagmaStormAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by the swirling magma!");
                break;
            case PartialTrapping.Infestation:
                //yield return InfestationAnim(index);
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Infestation!");
                break;
            case PartialTrapping.Octolock:
                //yield return OctolockAnim(index);
                doStatAnim = true;
                yield return StatDown(index, Stat.Defense, 1, target.partialTrappingSource);
                yield return StatDown(index, Stat.SpDef, 1, target.partialTrappingSource);
                break;
            case PartialTrapping.SnapTrap:
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Snap Trap!");
                break;
            case PartialTrapping.ThunderCage:
                damage = target.pokemon.hpMax >> 3;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " is hurt by Thunder Cage!");
                break;
            default:
                yield return Announce("Error 112");
                break;
        }
        if (type is PartialTrapping.Octolock) yield break;
        else if (damage > target.pokemon.hp)
        {
            yield return DoFatalDamage(index);
            target.pokemon.fainted = true;
        }
        else
        {
            yield return target.DoNonMoveDamage(damage);
            yield return ProcessBerries(index, false);
        }
    }
    private IEnumerator StartWeather(Weather weather, int turns)
    {
        if ((this.weather is Weather.HeavyRain or Weather.ExtremeSun or Weather.StrongWinds &&
            weather is not Weather.HeavyRain or Weather.ExtremeSun or Weather.StrongWinds) ||
            this.weather == weather) yield break;
        this.weather = weather;
        weatherTimer = turns;
        yield return Announce(weather switch
        {
            Weather.Sun => SunStart,
            Weather.Rain => RainStart,
            Weather.Sand => SandStart,
            Weather.Snow => SnowStart,
            Weather.HeavyRain => HeavyRainStart,
            Weather.ExtremeSun => ExtremeSunStart,
            Weather.StrongWinds => StrongWindsStart,
            _ => "Error 402a: Invalid weather starts"
        });
        yield return CheckWeatherAbilities();
    }
    private IEnumerator WeatherContinues()
    {
        if (weather == Weather.None)
        {
            yield break;
        }
        if (weatherTimer == 0)
        {
            yield return WeatherEnds();
        }
        else
        {
            yield return Announce(weather switch
            {
                Weather.Sun or Weather.ExtremeSun => SunContinue,
                Weather.Rain or Weather.HeavyRain => RainContinue,
                Weather.Sand => SandContinue,
                Weather.Snow => SnowContinue,
                Weather.StrongWinds => StrongWindsContinue,
                _ => "Error 402c: Invalid weather continues"
            });
            weatherTimer--;
        }
    }
    private IEnumerator WeatherEnds()
    {
        yield return Announce(weather switch
        {
            Weather.Sun => SunEnd,
            Weather.Rain => RainEnd,
            Weather.Sand => SandEnd,
            Weather.Snow => SnowEnd,
            Weather.HeavyRain => HeavyRainEnd,
            Weather.ExtremeSun => ExtremeSunEnd,
            Weather.StrongWinds => StrongWindsEnd,
            _ => "Error 402b: Invalid weather ends"
        });
        weather = Weather.None;
        yield return CheckWeatherAbilities();
    }
    private IEnumerator Rest(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        if (Sides[index < 3 ? 0 : 1].safeguard
            || UproarOnField)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        if (user.pokemon.hp
            < user.pokemon.hpMax
            && user.pokemon.status != Status.Sleep)
        {
            user.pokemon.status = Status.Sleep;
            user.pokemon.sleepTurns = 2;
            yield return Announce(MonNameWithPrefix(index, true)
                + " slept and became healthy!");
            yield return Heal(index,
                user.pokemon.hpMax);
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    private IEnumerator GetLeechSeed(int index, int attacker)
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

    private IEnumerator TransformByMove(int index, int target)
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
            user.transformedMon = PokemonOnField[target].pokemon.Clone() as Pokemon;
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

    private IEnumerator StartReflect(int side)
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

    private IEnumerator StartLightScreen(int side)
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

    private IEnumerable StartAuroraVeil(int index)
    {
        int side = index / 3;
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

    private IEnumerator DoPainSplit(int target, int attacker)
    {
        if (PokemonOnField[attacker].pokemon.hp
            > PokemonOnField[target].pokemon.hp)
        {
            yield return Announce(MoveFailed);
            yield break;
        }
        int newHP = (PokemonOnField[attacker].pokemon.hp + PokemonOnField[target].pokemon.hp) >> 1;
        yield return DoDamage(PokemonOnField[target].pokemon, PokemonOnField[target].pokemon.hp - newHP);
        yield return DoDamage(PokemonOnField[attacker].pokemon, PokemonOnField[attacker].pokemon.hp - newHP);
        yield return new WaitForSeconds(0.5F);
        yield return Announce("The battlers shared their pain!");
    }

    private IEnumerator CheckLeechSeed(int index)
    {
        BattlePokemon target = PokemonOnField[index];
        if (!target.seeded || HasAbility(index, MagicGuard)
            || !PokemonOnField[target.seedingSlot].exists) yield break;
        //yield return LeechSeedAnim(index, target.seedingSlot);
        int healthAmount = target.pokemon.hpMax >> 3;
        yield return DoDamage(index, healthAmount);
        if (HasAbility(index, LiquidOoze))
        {
            yield return AbilityPopupStart(index);
            yield return DoDamage(target.seedingSlot, healthAmount);
            yield return new WaitForSeconds(0.5F);
            yield return Announce(MonNameWithPrefix(target.seedingSlot, true)
                + " sucked up the liquid ooze!");
            yield return AbilityPopupEnd(index);
            yield return ProcessFaintingSingle(target.seedingSlot);
            yield return ProcessBerries(target.seedingSlot, false);
        }
        else
        {
            yield return Heal(PokemonOnField[index].seedingSlot, healthAmount);
            yield return Announce(MonNameWithPrefix(index, true)
                + "'s health was sapped by Leech Seed!");
        }
        yield return ProcessFaintingSingle(index);
        yield return ProcessBerries(index, false);
    }

    private IEnumerator DoMimic(int index, int target)
    {
        BattlePokemon user = PokemonOnField[index];
        if (((Move.MoveTable[(int)PokemonOnField[target].lastMoveUsed].moveFlags & MoveFlags.cannotMimic) != 0)
            || PokemonOnField[index].pokemon.HasMove(PokemonOnField[target].lastMoveUsed))
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

    private IEnumerator Conversion(int index)
    {
        Type newType = Move.MoveTable[(int)PokemonOnField[index].GetMove(0)].type;
        PokemonOnField[index].newType1 = newType;
        PokemonOnField[index].newType2 = newType;
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)newType] + " type!");
    }

    private IEnumerator Camouflage(int index)
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

    private IEnumerator BecomeType(int index, Type type)
    {
        PokemonOnField[index].newType1 = type;
        PokemonOnField[index].newType2 = type;
        PokemonOnField[index].hasType3 = false;
        PokemonOnField[index].typesOverriden = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " became the " + TypeUtils.typeName[(int)type] + " type!");
    }

    private IEnumerator DoHaze()
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

    private IEnumerator CreateTerrain(Terrain terrain, bool extend)
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
        yield return CheckTerrainAbilities();
    }

    private IEnumerator RemoveTerrain()
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

    private IEnumerator StartSafeguard(int index)
    {
        int side = index < 3 ? 0 : 1;
        Sides[side].safeguard = true;
        Sides[side].safeguardTurns = 5;
        yield return Announce(side == 1 ? "Your" : "The opponent's"
            + " team became cloaked in a mystical veil!");
    }

    private void GetPerishSong(int index)
    {
        PokemonOnField[index].perishSong = true;
        PokemonOnField[index].perishCounter = 3;
    }

    private IEnumerator CheckPerishSong(int index)
    {
        if (!PokemonOnField[index].perishSong || HasAbility(index, MagicGuard)) yield break;
        PokemonOnField[index].perishCounter--;
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s perish counter fell to "
            + PokemonOnField[index].perishCounter + "!");
        if (PokemonOnField[index].perishCounter <= 0)
        {
            yield return DoFatalDamage(index);
            PokemonOnField[index].pokemon.fainted = true;
            yield return ProcessFaintingSingle(index);
        }
    }

    private IEnumerator Infatuate(int index, int attacker)
    {
        if (OppositeGenders(index, attacker) && !PokemonOnField[index].infatuated)
        {
            if (HasAbility(index, Oblivious))
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

    private IEnumerator CureStatusHealBell(Pokemon mon)
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

    private IEnumerator HealBell(int index)
    {
        yield return Announce("A bell chimed!");
        if (index < 3)
        {
            for (int i = 0; i < 6; i++)
            {
                if (opponentPokemon[i].exists
                    && opponentPokemon[i].SpeciesData.abilities[opponentPokemon[i].whichAbility] != Soundproof
                    )
                {
                    yield return CureStatusHealBell(opponentPokemon[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                if (playerPokemon[i].exists
                    && playerPokemon[i].SpeciesData.abilities[playerPokemon[i].whichAbility] != Soundproof
                    )
                {
                    yield return CureStatusHealBell(playerPokemon[i]);
                }
            }
        }
    }

    private IEnumerator DoThief(int attacker, int defender)
    {
        if (PokemonOnField[attacker].pokemon.item == ItemID.None
            && ItemUtils.CanBeStolen(PokemonOnField[defender].pokemon.item)
            && !HasAbility(defender, StickyHold))
        {
            PokemonOnField[attacker].pokemon.newItem = PokemonOnField[defender].pokemon.item;
            PokemonOnField[defender].pokemon.newItem = ItemID.None;
            PokemonOnField[defender].pokemon.itemChanged = true;
            PokemonOnField[attacker].pokemon.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " stole " + MonNameWithPrefix(defender, false) + "'s "
                + Item.ItemTable[(int)PokemonOnField[attacker].pokemon.item].itemName + "!");
        }
    }


    private IEnumerator SwitchItems(int attacker, int defender)
    {
        if (HasAbility(defender, StickyHold))
        {
            if (ShowFailure)
            {
                yield return AbilityPopupStart(defender);
                yield return Announce(MoveFailed);
                yield return AbilityPopupEnd(defender);
            }
            yield break;
        }
        if (PokemonOnField[attacker].pokemon.item == ItemID.None
        && ItemUtils.CanBeStolen(PokemonOnField[defender].Item)
        && ItemUtils.CanBeStolen(PokemonOnField[attacker].Item)
        && !HasAbility(defender, StickyHold))
        {
            ItemID attackerItem = PokemonOnField[attacker].Item;
            PokemonOnField[attacker].pokemon.newItem = PokemonOnField[defender].Item;
            PokemonOnField[defender].pokemon.newItem = attackerItem;
            PokemonOnField[defender].pokemon.itemChanged = true;
            PokemonOnField[attacker].pokemon.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " switched items with " + MonNameWithPrefix(defender, false) + "!");
            yield return Announce(MonNameWithPrefix(defender, true)
                + " obtained one " + PokemonOnField[defender].Item.Data().itemName + "!");
            yield return Announce(MonNameWithPrefix(attacker, true)
    + " obtained one " + PokemonOnField[attacker].Item.Data().itemName + "!");
        }
    }

    private IEnumerator DoBestow(int attacker, int defender)
    {
        BattlePokemon user = PokemonOnField[attacker];
        BattlePokemon target = PokemonOnField[defender];
        if (user.Item == ItemID.None || target.Item != ItemID.None)
            yield return Announce(MoveFailed);
        //Todo: add other failure conditions
        if (user.Item.Data().type == ItemType.Plate && user.pokemon.SpeciesData.speciesName == "Arceus")
        {
            yield return Announce(MoveFailed);
        }
        else
        {
            target.pokemon.newItem = user.Item;
            user.pokemon.newItem = ItemID.None;
            target.pokemon.itemChanged = true;
            user.pokemon.itemChanged = true;
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " gave " + MonNameWithPrefix(defender, false) + " its "
                + target.Item.Data().itemName + "!");
        }
    }
    private IEnumerator DoKnockOff(int attacker, int defender)
    {
        if (ItemIsChangeable(defender))
        {
            yield return Announce(MonNameWithPrefix(attacker, true)
                + " knocked off " + MonNameWithPrefix(defender, false)
                + "'s " + PokemonOnField[defender].Item.Data().itemName + "!");
            PokemonOnField[defender].pokemon.newItem = ItemID.None;
            PokemonOnField[defender].pokemon.itemChanged = true;
        }
    }

    private IEnumerator GhostCurse(int attacker, int defender)
    {
        yield return DoDamage(PokemonOnField[attacker].pokemon, PokemonOnField[attacker].pokemon.hpMax >> 1);
        PokemonOnField[defender].cursed = true;
        yield return Announce(MonNameWithPrefix(attacker, true) + " cut its own HP to put a curse on "
            + MonNameWithPrefix(defender, false) + "!");
    }

    private IEnumerator DoCurse(int index)
    {
        PokemonOnField[index].DoNonMoveDamage(PokemonOnField[index].pokemon.hpMax >> 2);
        yield return Announce(MonNameWithPrefix(index, true) + " is hurt by Curse!");
    }

    private IEnumerator DoSpikes(int index)
    {
        Side targetSide = GetOppositeSide(index);
        if (targetSide.spikes < 3)
        {
            targetSide.spikes++;
            yield return Announce("Spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else if (ShowFailure)
        {
            yield return Announce(MoveFailed);
        }
    }

    private IEnumerator DoToxicSpikes(int index)
    {
        if (Sides[GetSideNumber(5 - index)].toxicSpikes < 2)
        {
            Sides[GetSideNumber(5 - index)].toxicSpikes++;
            yield return Announce("Toxic spikes littered the ground around " +
                (index < 3 ? "your Pokémon!" : "the opponent's Pokémon!"));
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    private IEnumerator PsychUp(int user, int target)
    {
        PokemonOnField[user].ApplyStatStruct(PokemonOnField[target].MakeStatStruct());
        yield return Announce(MonNameWithPrefix(user, true)
            + " copied " + MonNameWithPrefix(target, false)
            + "'s stat changes!");
    }

    private IEnumerator DrainPP(int index, int amount, bool announce = true)
    {
        BattlePokemon target = PokemonOnField[index];
        bool worked = true;
        switch (target.lastMoveSlot)
        {
            case 1: target.pokemon.pp1 = Max(0, target.pokemon.pp1 - amount); break;
            case 2: target.pokemon.pp2 = Max(0, target.pokemon.pp2 - amount); break;
            case 3: target.pokemon.pp3 = Max(0, target.pokemon.pp3 - amount); break;
            case 4: target.pokemon.pp4 = Max(0, target.pokemon.pp4 - amount); break;
            default: worked = false; break;
        }
        if (announce && worked) yield return Announce("It reduced the PP of " + MonNameWithPrefix(index, false)
            + "'s " + GetMove(index).name + " by 4!");
        else yield return Announce(MoveFailed);
    }

    private IEnumerator GetNightmare(int index)
    {
        if (PokemonOnField[index].pokemon.status != Status.Sleep || PokemonOnField[index].nightmare)
            yield return Announce(MoveFailed);
        else
        {
            PokemonOnField[index].nightmare = true;
            yield return Announce(MonNameWithPrefix(index, true) + " began having a nightmare!");
        }
    }

    private IEnumerator CheckNightmare(int index)
    {
        if (!PokemonOnField[index].nightmare || HasAbility(index, MagicGuard)) yield break;
        if (PokemonOnField[index].pokemon.status != Status.Sleep) { PokemonOnField[index].nightmare = false; yield break; }
        yield return DoDamage(PokemonOnField[index].pokemon, PokemonOnField[index].pokemon.hpMax >> 2);
        yield return Announce(MonNameWithPrefix(index, true) + " is locked in a nightmare!");
        yield return ProcessFaintingSingle(index);
        yield return ProcessBerries(index, false);
    }

    private IEnumerator GetMindReader(int user, int target)
    {
        PokemonOnField[user].usedMindReader = true;
        PokemonOnField[user].mindReaderTarget = target;
        yield return Announce(MonNameWithPrefix(user, true) + " took aim at "
            + MonNameWithPrefix(target, false) + "!");
    }

    private IEnumerator DoBellyDrum(int index)
    {
        if (PokemonOnField[index].pokemon.hp * 2 > PokemonOnField[index].pokemon.hpMax)
        {
            if (PokemonOnField[index].attackStage == 6)
            {
                yield return Announce(MonNameWithPrefix(index, true)
                    + "'s Attack won't go any higher!");
                yield break;
            }
            yield return DoDamage(PokemonOnField[index].pokemon,
                PokemonOnField[index].pokemon.hpMax >> 1);
            yield return StatUpAnim(index);
            PokemonOnField[index].attackStage = 6;
            yield return Announce(MonNameWithPrefix(index, true)
                + " cut its own HP to maximize its Attack!");
        }
        else
        {
            yield return Announce(MoveFailed);
        }
    }

    private IEnumerator DoClangorousSoul(int index)
    {
        yield return StatUp(index, Stat.Attack, 1, index);
        yield return StatUp(index, Stat.Defense, 1, index);
        yield return StatUp(index, Stat.SpAtk, 1, index);
        yield return StatUp(index, Stat.SpDef, 1, index);
        yield return StatUp(index, Stat.Speed, 1, index);
        yield return DoDamage(PokemonOnField[index].pokemon,
            PokemonOnField[index].pokemon.hpMax / 3);
    }

    private IEnumerator RemoveHazards(int index)
    {
        Side side = Sides[index / 3];
        string teamText = (index > 2 ? "your" : "the opponent's") + " team!";
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
        if (side.steelsurge)
        {
            yield return Announce("The steel spikes disappeared from around " + teamText);
            side.steelsurge = false;
        }
        if (side.stickyWeb)
        {
            yield return Announce(StickyWebDisappeared + teamText);
            side.stickyWeb = false;
        }
    }

    private IEnumerator DoIdentify(int index, bool miracleEye)
    {
        PokemonOnField[index].identified = true;
        PokemonOnField[index].identifiedByMiracleEye = miracleEye;
        yield return Announce(MonNameWithPrefix(index, true) + " was identified!");
    }

    private static List<Type> GetConversion2Types(Type type)
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

    private IEnumerator Conversion2(int index, int target)
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

    private IEnumerator GetFutureSight(int target, int user)
    {
        var random = new System.Random();
        FutureSightStruct futureSightData = new()
        {
            turn = turnsElapsed + 2,
            target = target,
            user = PokemonOnField[user].pokemon,
            spAtk = PokemonOnField[user].pokemon.spAtk,
            spAtkStage = PokemonOnField[user].spAtkStage,
            level = PokemonOnField[user].pokemon.level,
            stab = PokemonOnField[user].HasType(GetMove(user).type),
            critical = random.NextDouble() < GetCritChance(user, Moves[user]),
            type = GetEffectiveType(Moves[user], user),
            move = Moves[user],
        };
        isFutureSightTargeted[target] = true;
        futureSight.Enqueue(futureSightData);
        yield return Announce(MonNameWithPrefix(user, true) + " foresaw an attack!");
    }

    private IEnumerator FutureSightAttack()
    {
        FutureSightStruct data = futureSight.Dequeue();
        isFutureSightTargeted[data.target] = false;
        BattlePokemon targetMon = PokemonOnField[data.target];
        yield return Announce(MonNameWithPrefix(data.target, true) + " took the "
            + data.move.Data().name + " attack!");
        float effectiveness = GetEffectivenessWithoutAttacker(data.type, targetMon);
        if (effectiveness > 0)
        {
            int damage = FutureSightDamageCalc(data);
            if (damage > targetMon.pokemon.hp)
            {
                if (targetMon.ability == Sturdy && targetMon.AtFullHealth
                    && !(HasAbility(data.user.lastIndex, MoldBreaker)
                    && data.user.onField))
                {
                    targetMon.gotAbilityEffectSelf = true;
                    targetMon.affectingAbilitySelf = Sturdy;
                    yield return DoSturdyDamage(data.target);
                }
                else if (targetMon.endure && data.user.onField)
                {
                    yield return DoSturdyDamage(data.target);
                }
                else
                {
                    yield return DoFatalDamage(data.target);
                    targetMon.pokemon.fainted = true;
                }
            }
            else
            {
                yield return DoDamage(targetMon.pokemon, damage);
            }
        }
        yield return AnnounceTypeEffectiveness(effectiveness, false, data.target);
    }

    private IEnumerator GetEncored(int target)
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

    private IEnumerator StartUproar(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true) + " caused an uproar!");
        for (int i = 0; i < 6; i++)
        {
            if (PokemonOnField[i].exists
                && PokemonOnField[i].pokemon.status == Status.Sleep)
            {
                yield return WakeUp(i);
            }
        }
    }

    private IEnumerator DoStockpile(int index)
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

    private IEnumerator DoSwallow(int index)
    {
        BattlePokemon user = PokemonOnField[index];
        switch (user.stockpile)
        {
            case 1: yield return Heal(index, user.pokemon.hpMax >> 2); break;
            case 2: yield return Heal(index, user.pokemon.hpMax >> 1); break;
            case 3: yield return Heal(index, user.pokemon.hpMax); break;
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

    private IEnumerator DoTorment(int index)
    {
        PokemonOnField[index].tormented = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " was subjected to torment!");
    }

    private IEnumerator MakeWish(int index)
    {
        yield return Announce(MonNameWithPrefix(index, true)
            + " made a wish!");
        wishes.Enqueue((PokemonOnField[index].pokemon.hpMax >> 1,
            turnsElapsed + 1, index, MonNameWithPrefix(index, true)));
    }

    private IEnumerator GetWish()
    {
        (int wishHP, int, int slot, string wisher) wishStruct = wishes.Dequeue();
        if (PokemonOnField[wishStruct.slot].exists && !PokemonOnField[wishStruct.slot].AtFullHealth)
        {
            yield return Announce(wishStruct.wisher + "'s wish came true!");
            yield return Heal(wishStruct.slot, wishStruct.wishHP);
        }
    }

    private IEnumerator GetTaunted(int index)
    {
        PokemonOnField[index].taunted = true;
        PokemonOnField[index].tauntTimer
            = PokemonOnField[index].done ? 4 : 3;
        yield return Announce(MonNameWithPrefix(index, true)
            + " fell for the taunt!");
    }

    private IEnumerator DoRolePlay(int user, int target)
    {
        yield return AbilityPopupStart(user);
        yield return abilityControllers[user].ChangeAbility(
            PokemonOnField[target].ability.Name());
        yield return Announce(MonNameWithPrefix(user, true)
            + " copied " + MonNameWithPrefix(target, false) + "'s "
            + PokemonOnField[target].ability.Name() + "!");
        yield return AbilityPopupEnd(user);
        yield return ExitAbilityCheck(user);
        PokemonOnField[user].ability = PokemonOnField[target].ability;
        yield return EntryAbilityCheck(user);
    }

    private IEnumerator DoSkillSwap(int user, int target)
    {
        StartCoroutine(AbilityPopupStart(user));
        yield return AbilityPopupStart(target);
        (PokemonOnField[target].ability, PokemonOnField[user].ability) =
            (PokemonOnField[user].ability, PokemonOnField[target].ability);
        StartCoroutine(abilityControllers[user].ChangeAbility(
            PokemonOnField[target].ability.Name()));
        yield return abilityControllers[target].ChangeAbility(
            PokemonOnField[user].ability.Name());
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

    private IEnumerator HelpingHand(int user, int target)
    {
        PokemonOnField[target].helpingHand++;
        yield return Announce(MonNameWithPrefix(user, true)
            + " is ready to help " + MonNameWithPrefix(target, false) + "!");
    }

    private IEnumerator Ingrain(int index)
    {
        PokemonOnField[index].ingrained = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " planted its roots!");
    }

    private IEnumerator StartAquaRing(int index)
    {
        PokemonOnField[index].hasAquaRing = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + " surrounded itself with a veil of water!");
    }

    private IEnumerator DoRecycle(int index)
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
                user.pokemon.item = user.eatenBerry;
            }
            else
            {
                user.pokemon.newItem = user.eatenBerry;
                user.pokemon.itemChanged = true;
            }
            user.eatenBerry = ItemID.None;
            yield return Announce(MonNameWithPrefix(index, true)
                + " found one " + user.Item.Data().itemName + "!");
        }
    }

    private IEnumerator DoBreakScreens(int index)
    {
        Side side = Sides[GetSideNumber(index)];
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

    private IEnumerator CureStatus(int index)
    {
        switch (PokemonOnField[index].pokemon.status)
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

    private IEnumerator Gravity()
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

    private IEnumerator Tailwind(int side)
    {
        Sides[side].tailwind = true;
        Sides[side].tailwindTurns = 4;
        yield return Announce("A tailwind blew from behind "
            + (side == 0 ? "the foes'" : "your") + " team!");
    }

    private IEnumerator Embargo(int index)
    {
        PokemonOnField[index].embargoed = true;
        PokemonOnField[index].embargoTimer = 5;
        yield return Announce(MonNameWithPrefix(index, true)
            + " can't use items anymore!");
    }

    private IEnumerator DoPsychoShift(int index, int attacker)
    {
        Pokemon user = PokemonOnField[attacker].pokemon;
        Pokemon target = PokemonOnField[index].pokemon;
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
        yield return CureStatus(attacker);
    }

    private IEnumerator SuppressAbility(int index)
    {
        PokemonOnField[index].abilitySuppressed = true;
        yield return Announce(MonNameWithPrefix(index, true)
            + "'s ability was suppressed!");
    }

    private IEnumerator LuckyChant(int side)
    {
        Sides[side].luckyChant = true;
        Sides[side].luckyChantTurns = 5;
        yield return Announce(side == 0 ? "The foes are" : "Your team is" +
            " protected from critical hits!");
    }

    private IEnumerator ChangeAbility(int index, Ability ability)
    {
        yield return AbilityPopupStart(index);
        yield return abilityControllers[index].ChangeAbility(ability.Name());
        PokemonOnField[index].ability = ability;
        yield return Announce(MonNameWithPrefix(index, true) +
            " acquired " + ability.Name() + "!");
        yield return AbilityPopupEnd(index);
    }

    private IEnumerator DoDefog(int attacker, int target, bool doEvasionDrop) //Todo: add Sticky Web and Terrain clearing effects
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
            if (i.steelsurge)
            {
                yield return Announce("The steel spikes disappeared from around " + sideText);
                i.steelsurge = false;
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
        if (Sides[GetSideNumber(target)].auroraVeil)
        {
            yield return Announce(target < 3 ? "The foes'" : "Your team's" +
                " Aurora Veil wore off!");
            Sides[GetSideNumber(target)].auroraVeil = false;
        }
        yield return StatDown(target, Stat.Evasion, 1, attacker);
    }

    private IEnumerator StartTrickRoom(int index)
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

    private IEnumerator StartWonderRoom()
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

    private IEnumerator StartMagicRoom()
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

    private IEnumerator DoStealthRock(int index)
    {
        yield return Announce("Pointed stones float in the air around "
            + (index < 3 ? "your" : "the opponent's") + " team!");
        GetOppositeSide(index).stealthRock = true;
    }

    private IEnumerator DoSteelsurge(int index)
    {
        yield return Announce("Steel splinters litter the field around "
            + (index < 3 ? "your" : "the opponent's") + " team!");
        GetOppositeSide(index).steelsurge = true;
    }

    private IEnumerator DoStickyWeb(int index)
    {
        yield return Announce("A sticky web spreads out under " +
            (index < 3 ? "your" : "the opponent's") + " team!");
        Sides[(5 - index) / 3].stealthRock = true;
    }

    private IEnumerator GuardSplit(int index, int attacker)
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

    private IEnumerator PowerSplit(int index, int attacker)
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

    private IEnumerator AllySwitch(int index, int attacker)
    {
        (PokemonOnField[attacker], PokemonOnField[index]) =
            (PokemonOnField[index], PokemonOnField[attacker]);
        PokemonOnField[index].index = index;
        PokemonOnField[attacker].index = attacker;
        yield return Announce(MonNameWithPrefix(attacker, true)
            + " and " + MonNameWithPrefix(index, false)
            + " switched places!");
    }

    private IEnumerator ReflectType(int user, int target)
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

    private bool GetAnticipation(int index)
    {
        int baseNum = index > 2 ? 0 : 3;
        for (int i = baseNum; i < baseNum + 3; i++)
        {
            foreach (MoveID move in PokemonOnField[i].pokemon.MoveIDs)
            {
                MoveData data = move.Data();
                if (data.effect is MoveEffect.OHKO or MoveEffect.SelfDestruct) return true;
                if (GetEffectivenessForAnticipation(data.type, i, index) > 1) return true;
            }
        }
        return false;
    }

    private (MoveID, int) GetForewarnMove(int index)
    {
        int baseNum = index > 2 ? 0 : 3;
        MoveID topMove = MoveID.None;
        int topPower = 0;
        int indexToReturn = NoMons;
        int ties = 0;
        for (int i = baseNum; i < baseNum + 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                MoveID currentMove = PokemonOnField[i].GetMove(j);
                int currentPower = currentMove.ForewarnPower();
                if (currentPower == 0) continue;
                if (currentPower > topPower)
                {
                    topMove = currentMove;
                    topPower = currentPower;
                    indexToReturn = i;
                    ties = 1;
                }
                else if (currentPower == topPower)
                {
                    if (random.Next(++ties) is 0)
                    {
                        topMove = currentMove;
                        topPower = currentPower;
                        indexToReturn = i;
                    }
                }
            }
        }
        return (topMove, indexToReturn);
    }

    private IEnumerator MakeRainbow(int index)
    {
        yield return Announce("A rainbow appeared over " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSideNumber(index)].rainbow = true;
        Sides[GetSideNumber(index)].rainbowTurns = 4;
    }
    private IEnumerator MakeSwamp(int index)
    {
        yield return Announce("A swamp appeared around " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSideNumber(index)].swamp = true;
        Sides[GetSideNumber(index)].swampTurns = 4;
    }
    private IEnumerator MakeBurningField(int index)
    {
        yield return Announce("A burning field surrounds " +
            (index > 2 ? "your" : "the foe's" + " Pokémon!"));
        Sides[GetSideNumber(index)].burningField = true;
        Sides[GetSideNumber(index)].burningFieldTurns = 4;
    }

    private IEnumerator AddType3(int index, Type type)
    {
        yield return Announce("The " + type.Name() + " type was added to " +
            MonNameWithPrefix(index, false) + "!");
        PokemonOnField[index].Type3 = type;
        PokemonOnField[index].hasType3 = true;
    }

    private IEnumerator DoStanceChange(int index)
    {
        if (PokemonOnField[index].ApparentSpecies is SpeciesID.AegislashShield &&
    Moves[index].Data().power > 0)
        {
            yield return Transform(index, SpeciesID.AegislashBlade);
        }
        else if (PokemonOnField[index].ApparentSpecies is SpeciesID.AegislashBlade &&
            Moves[index] is MoveID.KingsShield)
        {
            yield return Transform(index, SpeciesID.AegislashShield);
        }
    }

    private IEnumerator DoTrace(int index)
    {
        int baseNum = index < 3 ? 3 : 0;
        for (int i = 0; i < 3; i++)
        {
            if (PokemonOnField[baseNum + i].exists)
            {
                yield return AbilityPopupStart(index);
                yield return new WaitForSeconds(0.2F);
                yield return abilityControllers[index].ChangeAbility(
                    EffectiveAbility(baseNum + i).Name());
                PokemonOnField[index].ability = EffectiveAbility(i);
                PokemonOnField[index].timeWithAbility = 0;
                yield return Announce(MonNameWithPrefix(index, true)
                    + " traced the foe's "
                    + EffectiveAbility(baseNum + i).Name()
                    + "!");
                yield return AbilityPopupEnd(index);
                yield return EntryAbilityCheck(index);
                break;
            }
        }
    }

    private IEnumerator DoIntimidate(int index)
    {
        yield return AbilityPopupStart(index);
        foreach (int i in GetAdjacentOpponents(index))
        {
            if (MonIsActive(i))
            {
                doStatAnim = true;
                if (HasAbility(i, GuardDog))
                {
                    yield return PopupDo(i, StatUp(i, Stat.Attack, 1, index, false, false));
                }
                else if (EffectiveAbility(i) is
                    Oblivious or OwnTempo or InnerFocus
                    or Scrappy)
                {
                    yield return AbilityPopupStart(i);
                    yield return Announce(MonNameWithPrefix(i, true)
                    + "'s attack wasn't lowered because of "
                    + EffectiveAbility(i).Name() + "!");
                    yield return AbilityPopupEnd(i);
                }
                else { yield return StatDown(i, Stat.Attack, 1, index); }
            }
        }
        yield return AbilityPopupEnd(index);
    }

    private IEnumerator DoSupersweetSyrup(int index)
    {
        yield return AbilityPopupStart(index);
        foreach (int i in GetAdjacentOpponents(index))
        {
            if (MonIsActive(i))
            {
                doStatAnim = true;
                yield return StatDown(i, Stat.Evasion, 1, index);
            }
        }
        yield return AbilityPopupEnd(index);
    }

    private IEnumerator DoStuffCheeks(int index)
    {
        BerryEffect effect = PokemonOnField[index].Item.BerryEffect();
        if (effect is None) yield break;
        UseUpItem(index);
        yield return DoBerryEffect(index, effect, false);
        yield return StatUp(index, Stat.Defense, 2, index);
    }

    private IEnumerator ScatterCoins(int amount, bool player)
    {
        yield return Announce("Coins were scattered everywhere!");
        scatteredCoins += amount;
        scatteredCoins = Min(scatteredCoins, 99999);
    }
}