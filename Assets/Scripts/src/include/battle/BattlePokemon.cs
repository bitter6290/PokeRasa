using System;
using System.Collections;
using static System.Math;

public partial class Battle
{
#if UNITY_EDITOR
    [Serializable]
#endif
    public class BattlePokemon
    {
        public Pokemon pokemon;
        public int partyIndex;

        public int attackStage = 0;
        public int defenseStage = 0;
        public int spAtkStage = 0;
        public int spDefStage = 0;
        public int speedStage = 0;
        public int evasionStage = 0;
        public int accuracyStage = 0;
        public int critStage = 0;

        public int Attack => (int)(BaseAttack * StageToModifierNormal(attackStage));
        public int Defense => (int)(BaseDefense * StageToModifierNormal(defenseStage));
        public int SpAtk => (int)(BaseSpAtk * StageToModifierNormal(spAtkStage));
        public int SpDef => (int)(BaseSpDef * StageToModifierNormal(spDefStage));
        public int Speed => (int)(BaseSpeed * StageToModifierNormal(speedStage));

        public bool overrideAttacks;
        public int attackOverride;
        public int spAtkOverride;


        public bool overrideDefenses;
        public int defenseOverride;
        public int spDefOverride;

        public bool overrideSpeed;
        public int speedOverride;

        public bool Side => index >= 3;
        public int Position => index % 3;
        public int index;

        public int turnOnField;

        public bool truantThisTurn;
        public bool truantNextTurn;

        public bool exists;
        public bool player;

        public Stat protoQuarkStat;
        public bool boosterEnergy;

        public bool done = true;

        //Reset after every move
        public bool isTarget = false;
        public bool isHit = false;
        public bool isMissed = false;
        public bool isUnaffected = false;
        public bool isCrit = false;
        public bool gotMoveEffect = false;
        public bool abilityActivated = false;
        public bool wasProtected = false;
        public bool protected75 = false;
        public bool enduredHit = false;
        public bool gotSuperEffectiveHit = false;

        public bool roosting = false;

        public bool confused = false;
        public int confusionCounter = 0;

        public bool partialTrapped = false;
        public PartialTrapping partialTrappingType = PartialTrapping.None;
        public int partialTrappingSource = 0;
        public int partialTrappingTimer = 0;

        public bool trapped = false;
        public int trappingSlot = 0;

        public bool usedNoRetreat = false; //Doesn't handle trapping, but
                                           //prevents No Retreat from being
                                           //used twice. No Retreat can still
                                           //be used once when trapped.
        public bool thrashing = false;
        public int thrashingTimer;
        public bool lockedInNextTurn = false;
        public MoveID lockedInMove;
        public Invulnerability invulnerability;
        public bool beingSkyDropped = false;
        public bool skyDropping = false;
        public int skyDropTarget = 0;
        public bool dontCheckPP = false;

        public bool choseMove = false;

        public bool flinched = false;

        public bool usedDefenseCurl = false;
        public bool minimized = false;
        public bool autotomized = false;

        public bool charged = false;

        public int toxicCounter = 0;

        public int moveDamageDone = 0;
        public int damageTaken = 0;
        public bool damageWasPhysical = false;
        public int lastDamageDoer = 0;
        public bool damagedThisTurn;

        public bool disabled = false;
        public MoveID disabledMove = 0;
        public int disableTimer = 0;

        public bool uproar = false;
        public int uproarTimer = 0;

        public bool gotAbilityEffectSelf = false;
        public Ability affectingAbilitySelf = Ability.None;
        public bool gotAbilityEffectOpponent = false;
        public Ability affectingAbilityOpponent = Ability.None;
        public int abilityEffectSource = 0;

        public bool seeded = false;
        public int seedingSlot = 0;

        public bool focused = false;

        public bool biding = false;
        public int bideDamage = 0;

        public int rolloutIntensity = 0;

        public bool flashFire = false;
        public bool unburdened = false;

        public bool usedMindReader = false;
        public bool hasMindReader = false;
        public int mindReaderTarget = 0;

        public bool hasSubstitute = false;
        public int substituteHP = 0;

        public bool isEnraged = false;

        public bool perishSong = false;
        public int perishCounter = 0;

        public bool followMe = false;
        public bool wasRagePowder = false;
        public bool spotlight = false;

        public int helpingHand = 0;

        public bool isTransformed = false;
        public Pokemon transformedMon = Pokemon.EmptyMon;

        public bool illusionActive = false;
        public SpeciesID illusionSpecies = SpeciesID.Missingno;

        public Ability ability;
        public int timeWithAbility = 0;

        public bool endure = false;
        public Protection protection = Protection.None;
        public int protectCounter = 0;
        public bool Protect => protection != Protection.None;

        public bool magicCoat = false;

        public bool infatuated = false;
        public int infatuationTarget = 0;

        public bool beakBlast = false;

        public bool shellTrap = false;
        public bool shellTrapWorks = false;

        public bool taunted = false;
        public int tauntTimer = 0;

        public bool dynamaxed = false;
        public int dynamaxTurns = 0;

        public bool tormented = false;

        public bool cursed = false;

        public bool moveFailedThisTurn = false;
        public bool moveFailedLastTurn = false;

        public bool nightmare = false;

        public bool identified = false;
        public bool identifiedByMiracleEye = false;

        public bool laserFocusNow = false;
        public bool laserFocusNext = false;

        public bool destinyBond = false;
        public bool cannotUseDestinyBondAgain = false;
        public bool gotDestinyBondHit = false;
        public string destinyBondAttacker = string.Empty;

        public bool encored = false;
        public int encoreTimer = 0;
        public MoveID encoredMove = MoveID.None;

        public bool throatChop = false;
        public int throatChopTurns = 0;

        public int furyCutterIntensity = 0;

        public Type newType1 = Type.Typeless;
        public Type newType2 = Type.Typeless;
        public bool typesOverriden = false;

        public ItemID eatenBerry = ItemID.None;

        public bool gotReducingBerryEffect = false;
        public bool ateRetaliationBerry = false;
        public bool micleAccBoost = false;
        public bool custapPriorityBoost = false;

        public int stockpile = 0;
        public int stockpileDef = 0;
        public int stockpileSpDef = 0;

        public bool hasType3 = false;
        public Type Type3 = Type.Typeless;

        public bool abilitySuppressed = false;

        public bool mimicking = false;
        public int mimicSlot = 0;
        public MoveID mimicMove = MoveID.None;
        public int mimicPP = 0;
        public int mimicMaxPP = 0;

        public bool yawnNextTurn = false;
        public bool yawnThisTurn = false;

        public bool gotAteBoost = false; //Check for Aerilate, Pixilate, etc... 20% boost

        public bool ingrained = false;
        public bool hasAquaRing = false;

        public bool imprisoned = false;

        public bool magnetRise = false;
        public int magnetRiseTimer = 0;
        public bool telekinesis = false;
        public int telekinesisTimer = 0;

        public bool smackDown = false;

        public bool powdered = false;

        public bool tarShot = false;

        public bool grudge = false;
        public bool gotGrudgeEffect = false;

        public bool snatch = false;

        public bool embargoed = false;
        public int embargoTimer = 0;

        public bool healBlocked = false;
        public int healBlockTimer = 0;

        public bool powerTrick = false;
        public bool powerTrickSuppressed = false;
        public bool PowerTrickActive => powerTrick && !powerTrickSuppressed;

        public bool[] damagedByMon = new bool[6];

        public MoveID moveUsedLastTurn = MoveID.None;
        public MoveID moveUsedThisTurn = MoveID.None;
        public MoveID lastMoveUsed = MoveID.None;
        public int lastMoveSlot = 0;

        public bool quashed = false;

        public bool goingNext = false;

        public bool meFirst = false;

        public bool[] usedMove = new bool[4];

        public bool electrify = false;

        public byte turnsToCudChew;
        public BerryEffect cudChewEffect;

        public MoveID zMoveBase;

        public Battle battle;

        public MoveID lastTargetedMove = MoveID.None;

        public ItemID BaseItem => pokemon.itemChanged ? pokemon.newItem : pokemon.item;
        public ItemID Item => embargoed ?
                (BaseItem.Data().type is ItemType.MegaStone ? BaseItem : ItemID.None)
                : BaseItem;

        public bool HatesStat(Stat stat) => pokemon.Nature.NatureEffect(stat) < 1;

        public int EffectiveWeight => Max(100, pokemon.SpeciesData.pokedexData.weight -
            (autotomized ? 100000 : 0));

        public bool CanUseLastResort =>
            pokemon.Moves != 1 && UsedNoneOrLastResort(0) && UsedNoneOrLastResort(1) &&
            UsedNoneOrLastResort(2) && UsedNoneOrLastResort(3);

        public bool UsedNoneOrLastResort(int i)
            => (GetMove(i) is MoveID.None or MoveID.LastResort) || usedMove[i];

        public int SumOfStages =>
            Max(0, attackStage)
            + Max(0, defenseStage)
            + Max(0, spAtkStage)
            + Max(0, spDefStage)
            + Max(0, speedStage)
            + Max(0, evasionStage)
            + Max(0, accuracyStage);

        public BattlePokemon(Pokemon pokemonData, int index, bool player, Battle battle, bool exists = true)
        {
            battle.player.seenFlags[(int)pokemonData.species] = true;
            pokemonData.onField = true;
            pokemon = pokemonData;
            this.exists = exists;
            this.index = index;
            this.player = player;
            ability = Species.SpeciesTable[(int)pokemonData.species].abilities[pokemonData.whichAbility];
            this.battle = battle;
            pokemonData.lastIndex = index;
        }

        public SpeciesID ApparentSpecies =>
            pokemon.illusionActive ? pokemon.illusionPokemon.species :
            isTransformed ? transformedMon.species :
            pokemon.GetSpecies;

        public int ApparentLevel => pokemon.illusionActive ? pokemon.illusionPokemon.level :
            pokemon.level;

        public string ApparentName => pokemon.illusionActive ? pokemon.illusionPokemon.MonName :
            pokemon.MonName;

        public Gender ApparentGender => pokemon.illusionActive ? pokemon.illusionPokemon.gender :
            pokemon.gender;

        public bool AtFullHealth => pokemon.hp == pokemon.hpMax;
        public float HealthProportion => (float)pokemon.hp / pokemon.hpMax;

        public MoveID GetMoveRaw(int index)
        {
            return mimicking && (index == mimicSlot - 1) ?
                    mimicMove
                : isTransformed
                    ? transformedMon.MoveIDs[index]
                : pokemon.MoveIDs[index];
        }

        public MoveID GetMove(int index)
        {
            return dynamaxed ? GetMoveRaw(index).MaxMove(pokemon) : GetMoveRaw(index);
        }

        public int GetStatStage(Stat stat)
        {
            return stat switch
            {
                Stat.Attack => attackStage,
                Stat.Defense => defenseStage,
                Stat.SpAtk => spAtkStage,
                Stat.SpDef => spDefStage,
                Stat.Speed => speedStage,
                Stat.Accuracy => accuracyStage,
                Stat.Evasion => evasionStage,
                _ => 0
            };
        }

        public MoveSelectOutcome CanUseMove(int move)
        {
            if (GetMove(move) == MoveID.None)
                return MoveSelectOutcome.NoMove;
            if (disabled && GetMove(move) == disabledMove)
                return MoveSelectOutcome.Disabled;
            if (encored && GetMove(move) != encoredMove)
                return MoveSelectOutcome.Encored;
            if (tormented && GetMove(move) == moveUsedLastTurn)
                return MoveSelectOutcome.Tormented;
            if (GetPP(move) <= 0)
                return MoveSelectOutcome.LowPP;
            if (taunted && GetMove(move).Data().power == 0)
                return MoveSelectOutcome.Taunted;
            if (battle.MoveImprisoned(GetMove(move), index))
                return MoveSelectOutcome.Imprisoned;
            if (battle.gravity &&
                (GetMove(move).Data().moveFlags & MoveFlags.gravityDisabled) != 0)
                return MoveSelectOutcome.Gravity;
            if (healBlocked &&
                (GetMove(move).Data().moveFlags & MoveFlags.healBlockAffected) != 0)
                return MoveSelectOutcome.HealBlock;
            if (battle.IsChoiced(index) &&
                lastMoveUsed != MoveID.None && lastMoveUsed != GetMove(move) && pokemon.HasMove(lastMoveUsed))
                return MoveSelectOutcome.Choiced;
            return MoveSelectOutcome.Success;
        }

        public bool CanUseAnyMove => CanUseMove(0) == MoveSelectOutcome.Success
            || CanUseMove(1) == MoveSelectOutcome.Success
            || CanUseMove(2) == MoveSelectOutcome.Success
            || CanUseMove(3) == MoveSelectOutcome.Success;

        public IEnumerator DoNonMoveDamage(int damage)
        {
            if (damage > pokemon.hp)
            {
                pokemon.fainted = true;
                yield return battle.DoDamage(pokemon, pokemon.hp);
            }
            else
            {
                yield return battle.DoDamage(pokemon, damage);
                damagedThisTurn = true;
            }
        }

        public IEnumerator DoProportionalDamage(float proportion) => DoNonMoveDamage(Max(1, (int)(pokemon.hpMax * proportion)));

        public int GetPP(int index)
        {
            return mimicking && (index == mimicSlot - 1)
                    ? mimicPP
                : isTransformed
                    ? transformedMon.PP[index]
                : pokemon.PP[index];
        }

        public void UsePP(int index, int amount = 1)
        {
            if (mimicking && (index == mimicSlot - 1))
            {
                mimicPP -= amount;
            }
            else if (isTransformed)
            {
                transformedMon.UsePP(index, amount);
            }
            else
            {
                pokemon.UsePP(index, amount);
            }
        }

        public int GetMaxPP(int index)
        {
            return mimicking && (index == mimicSlot - 1) ?
                mimicMaxPP : isTransformed ? 5 : index switch
                {
                    0 => pokemon.maxPp1,
                    1 => pokemon.maxPp2,
                    2 => pokemon.maxPp3,
                    3 => pokemon.maxPp4,
                    _ => 0
                };
        }

        public bool HasType(Type type)
        {
            return Type1 == type
                || Type2 == type
                || (hasType3 && Type3 == type);
        }

        public bool IsMonotype(Type type) =>
            Type1 == type && Type2 == type && (Type3 == type || !hasType3);

        public bool IsTypeless =>
            Type1 == Type.Typeless && Type2 == Type.Typeless &&
            (!hasType3 || Type3 == Type.Typeless);

        public Type Type1 => typesOverriden
                                ? newType1
                            : isTransformed
                                ? transformedMon.SpeciesData.type1
                            : pokemon.SpeciesData.type1;

        public Type Type2 => typesOverriden
                                ? newType2
                            : isTransformed
                                ? transformedMon.SpeciesData.type2
                            : pokemon.SpeciesData.type2;

        public static float StageToModifierNormal(int stage)
        {
            return stage < 0 ? 2.0F / (2 - stage) : (2 + stage) / 2.0F;
        }

        public static float StageToModifierAccEva(int stage)
        {
            return stage < 0 ? 3.0F / (3 - stage) : (3 + stage) / 3.0F;
        }

        private int BaseAttackRaw => isTransformed ? transformedMon.attack : pokemon.attack;
        private int BaseDefenseRaw => isTransformed ? transformedMon.defense : pokemon.defense;

        private int BaseSpAtkRaw => isTransformed ? transformedMon.spAtk : pokemon.spAtk;
        private int BaseSpDefRaw => isTransformed ? transformedMon.spDef : pokemon.spDef;

        private int BaseSpeedRaw => isTransformed ? transformedMon.speed : pokemon.speed;

        public int BaseAttack
        {
            get
            {
                if (overrideAttacks) return attackOverride;
                else if (PowerTrickActive) return BaseDefenseRaw;
                else return BaseAttackRaw;
            }
        }
        public int BaseDefense
        {
            get
            {
                if (overrideDefenses) return defenseOverride;
                else if (PowerTrickActive) return BaseAttackRaw;
                else return BaseDefenseRaw;
            }
        }
        public int BaseSpAtk => overrideAttacks ? spAtkOverride : BaseSpAtkRaw;
        public int BaseSpDef => overrideDefenses ? spDefOverride : BaseSpDefRaw;

        public int BaseSpeed => overrideSpeed ? speedOverride : BaseSpeedRaw;

        public static BattlePokemon MakeEmptyBattleMon(int index, Battle battle)
        {
            Pokemon emptyMon = Pokemon.EmptyMon;
            return new BattlePokemon(emptyMon, index, false, battle, false);
        }

        public StatStruct MakeStatStruct()
        {
            return new StatStruct()
            {
                attack = attackStage,
                defense = defenseStage,
                spAtk = spAtkStage,
                spDef = spDefStage,
                speed = speedStage,
                accuracy = accuracyStage,
                evasion = evasionStage,
                critRate = critStage,
            };
        }

        public void ApplyStatStruct(StatStruct statStruct)
        {
            attackStage = statStruct.attack;
            defenseStage = statStruct.defense;
            spAtkStage = statStruct.spAtk;
            spDefStage = statStruct.spDef;
            speedStage = statStruct.speed;
            accuracyStage = statStruct.accuracy;
            evasionStage = statStruct.evasion;
            critStage = statStruct.critRate;
        }

        public void InvertStatStages()
        {
            attackStage = -attackStage;
            defenseStage = -defenseStage;
            spAtkStage = -spAtkStage;
            spDefStage = -spDefStage;
            speedStage = -speedStage;
            accuracyStage = -accuracyStage;
            evasionStage = -evasionStage;
        }

        public BatonPassStruct MakeBatonPassStruct()
        {
            return new BatonPassStruct()
            {
                statStruct = MakeStatStruct(),
                substitute = hasSubstitute,
                substituteHP = substituteHP,
                seeded = seeded,
                seedingSlot = seedingSlot,
                trapped = trapped,
                trappingSlot = trappingSlot,
                cursed = cursed
            };
        }

        public void ApplyBatonPassStruct(BatonPassStruct batonPassStruct)
        {
            ApplyStatStruct(batonPassStruct.statStruct);
            hasSubstitute = batonPassStruct.substitute;
            substituteHP = batonPassStruct.substituteHP;
            seeded = batonPassStruct.seeded;
            seedingSlot = batonPassStruct.seedingSlot;
            trapped = batonPassStruct.trapped;
            trappingSlot = batonPassStruct.trappingSlot;
            cursed = batonPassStruct.cursed;
        }

        public int RaiseStat(Stat statID, int amount)
        {
            switch (statID)
            {
                case Stat.Attack:
                    if (attackStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - attackStage, amount);
                        attackStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.Defense:
                    if (defenseStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - defenseStage, amount);
                        defenseStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.SpAtk:
                    if (spAtkStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - spAtkStage, amount);
                        spAtkStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.SpDef:
                    if (spDefStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - spDefStage, amount);
                        spDefStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.Speed:
                    if (speedStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - speedStage, amount);
                        speedStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.Accuracy:
                    if (accuracyStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - accuracyStage, amount);
                        accuracyStage += raisedStages;
                        return raisedStages;
                    }
                case Stat.Evasion:
                    if (evasionStage == 6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 - evasionStage, amount);
                        evasionStage += raisedStages;
                        return raisedStages;
                    }
                default:
                    return 0;
            }
        }

        public int LowerStat(Stat statID, int amount)
        {
            switch (statID)
            {
                case Stat.Attack:
                    if (attackStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int loweredStages = Min(attackStage + 6, amount);
                        attackStage -= loweredStages;
                        return loweredStages;
                    }
                case Stat.Defense:
                    if (defenseStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int loweredStages = Min(defenseStage + 6, amount);
                        defenseStage -= loweredStages;
                        return loweredStages;
                    }
                case Stat.SpAtk:
                    if (spAtkStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int loweredStages = Min(spAtkStage + 6, amount);
                        spAtkStage -= loweredStages;
                        return loweredStages;
                    }
                case Stat.SpDef:
                    if (spDefStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int loweredStages = Min(spDefStage + 6, amount);
                        spDefStage -= loweredStages;
                        return loweredStages;
                    }
                case Stat.Speed:
                    if (speedStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int loweredStages = Min(speedStage + 6, amount);
                        speedStage -= loweredStages;
                        return loweredStages;
                    }
                case Stat.Accuracy:
                    if (accuracyStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 + accuracyStage, amount);
                        accuracyStage -= raisedStages;
                        return raisedStages;
                    }
                case Stat.Evasion:
                    if (evasionStage == -6)
                    {
                        return 0;
                    }
                    else
                    {
                        int raisedStages = Min(6 + evasionStage, amount);
                        evasionStage -= raisedStages;
                        return raisedStages;
                    }
                default:
                    return 0;
            }
        }
    }
}
