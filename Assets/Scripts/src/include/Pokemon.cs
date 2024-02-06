using static System.Math;
using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[Serializable]
public class Pokemon : ICloneable
{
    public SpeciesID species;


    public string name = string.Empty;
    public string MonName => name == string.Empty ? species.Data().speciesName : name;

    public Gender gender;

    public int xp;
    public int level;
    public int CurrentLevelXP => XP.LevelToXP(level, SpeciesData.xpClass);
    public int NextLevelXP => XP.LevelToXP(level + 1, SpeciesData.xpClass);
    public float LevelProgress => level >= PokemonConst.maxLevel ? 0 :
            (float)(xp - CurrentLevelXP) / (NextLevelXP - CurrentLevelXP);

    private int ivHP;
    private int ivAttack;
    private int ivDefense;
    private int ivSpAtk;
    private int ivSpDef;
    private int ivSpeed;

    public int evHP;
    public int evAttack;
    public int evDefense;
    public int evSpAtk;
    public int evSpDef;
    public int evSpeed;
    public int totalEv;

    private Nature nature;
    public Nature Nature => nature;
    public int whichAbility;

    public int hpMax => CalculateHPMax();
    public int attack => CalculateStat(Stat.Attack, SpeciesData.baseAttack, ivAttack, evAttack);
    public int defense => CalculateStat(Stat.Defense, SpeciesData.baseDefense, ivDefense, evDefense);
    public int spAtk => CalculateStat(Stat.SpAtk, SpeciesData.baseSpAtk, ivSpAtk, evSpAtk);
    public int spDef => CalculateStat(Stat.SpDef, SpeciesData.baseSpDef, ivSpDef, evSpDef);
    public int speed => CalculateStat(Stat.Speed, SpeciesData.baseSpeed, ivSpeed, evSpeed);

    public MoveID move1;
    public int pp1Level;
    public int maxPp1 => move1.Data().pp + pp1Level * move1.Data().pp / 5;
    public int pp1;
    public MoveID move2;
    public int pp2Level;
    public int maxPp2 => move2.Data().pp + pp1Level * move1.Data().pp / 5;
    public int pp2;
    public MoveID move3;
    public int pp3Level;
    public int maxPp3 => move3.Data().pp + pp1Level * move1.Data().pp / 5;
    public int pp3;
    public MoveID move4;
    public int pp4Level;
    public int maxPp4 => move4.Data().pp + pp1Level * move1.Data().pp / 5;
    public int pp4;

    public bool switchedOut;

    public bool fellBelow50;

    public int hp;
    public Status status;
    public int sleepTurns;

    public bool fainted;

    public bool exists;

    public ItemID item;
    public bool itemChanged;
    public ItemID newItem;

    [NonSerialized]
    public List<Ability> activatedAbilities = new();

    [NonSerialized]
    public bool canBelch;

    public ItemID CurrentItem => itemChanged ? newItem : item;

    public bool onField = false;
    public int lastIndex = 0;

    public bool transformed;
    public SpeciesID temporarySpecies;

    [NonSerialized]
    public bool illusionActive;
    [NonSerialized]
    public Pokemon illusionPokemon;



    public byte friendship; //Friendship is implemented at the Gen 7 standard by default

    public Type hiddenPowerType;

    public bool gainedLevel;

    public bool gMaxFactor;

    public int id;

    public bool egg;

    [NonSerialized]
    public bool makeShedinja = false;

    [NonSerialized]
    public bool shouldEvolve;
    [NonSerialized]
    public SpeciesID destinationSpecies;

    public bool UsesFemaleSprites => SpeciesData.genderDifferences && gender == Gender.Female;

    private ref int PPLevel(int slot)
    {
        switch (slot)
        {
            case 1: return ref pp1Level;
            case 2: return ref pp2Level;
            case 3: return ref pp3Level;
            case 4: return ref pp4Level;
            default: throw new Exception("Passed bad arguemnt to Pokemon.ppLevel");
        }
    }


    public SpeciesData SpeciesData => Species.SpeciesTable[transformed ?
        (int)temporarySpecies : (int)species];

    public SpeciesID GetSpecies => transformed ? temporarySpecies : species;

    public MoveID[] MoveIDs => new MoveID[4]
    {
        move1,
        move2,
        move3,
        move4
    };

    public int[] PP => new int[4]
    {
        pp1,
        pp2,
        pp3,
        pp4
    };

    public void UsePP(int index, int amount)
    {
        switch (index)
        {
            case 0: pp1 -= amount; break;
            case 1: pp2 -= amount; break;
            case 2: pp3 -= amount; break;
            case 3: pp4 -= amount; break;
            default: throw new Exception("Passed bad index to UsePP");
        }
    }

    public bool HasMove(MoveID move) => move1 == move || move2 == move || move3 == move || move4 == move;

    public Ability GetAbility => SpeciesData.abilities[whichAbility];

    public void SetTransformPP()
    {
        pp1 = 5;
        pp2 = 5;
        pp3 = 5;
        pp4 = 5;
    }

    public void SetEvIv(EvIvSpread spread)
    {
        ivHP = spread.ivHP;
        ivAttack = spread.ivAttack;
        ivDefense = spread.ivDefense;
        ivSpAtk = spread.ivSpAtk;
        ivSpDef = spread.ivSpDef;
        ivSpeed = spread.ivSpeed;

        evHP = spread.evHP;
        evAttack = spread.evAttack;
        evDefense = spread.evDefense;
        evSpAtk = spread.evSpAtk;
        evSpDef = spread.evSpDef;
        evSpeed = spread.evSpeed;
    }

    public void SetNature(Nature nature) => this.nature = nature;

    public void AbilityCapsule()
    {
        whichAbility = whichAbility switch
        {
            0 => 1,
            1 => 0,
            2 => 2,
            _ => whichAbility
        };
    }

    public void RestoreHP()
    {
        fainted = false;
        hp = hpMax;
    }

    public void RestorePP(byte slots) //bit 0 for slot 1, bit 1 for slot 2, etc
    {
        if ((slots & 1) != 0) pp1 = maxPp1;
        if ((slots & 2) != 0) pp2 = maxPp2;
        if ((slots & 4) != 0) pp3 = maxPp3;
        if ((slots & 8) != 0) pp4 = maxPp4;
    }

    public void FullHeal()
    {
        RestoreHP();
        RestorePP(0b1111);
        status = Status.None;
    }

    private int CalculateHPMax()
    {
        return (((2 * SpeciesData.baseHP) + ivHP + (evHP >> 2)) * level / 100 + level + 10);
    }


    private int CalculateStat(Stat stat, int baseStat, int statIv, int statEv)
    {
        return (int)Floor((((2 * baseStat) + statIv + (statEv >> 2)) * level / 100 + 5) * NatureUtils.NatureEffect(nature, stat));
    }

    public void CheckTransformation()
    {
        if (item.Data() is HoldToTransform)
        {
            HoldToTransform thisItem = (HoldToTransform)item.Data();
            if (species == thisItem.baseSpecies)
            {
                species = thisItem.transformedSpecies;
            }
        }
        else if (species is SpeciesID.Arceus && item.Data() is PlateItem)
        {
            species = ((PlateItem)item.Data()).destinationSpecies;
        }
    }

    public void CheckTransformationEnd(ItemID item)
    {
        if (item.Data() is HoldToTransform)
        {
            HoldToTransform thisItem = (HoldToTransform)item.Data();
            if (species == thisItem.transformedSpecies)
            {
                species = thisItem.baseSpecies;
            }
        }
        else if (item.Data() is PlateItem)
        {
            PlateItem thisItem = (PlateItem)item.Data();
            if (species == thisItem.destinationSpecies)
            {
                species = SpeciesID.Arceus;
            }
        }
    }

    public bool AddFriendship(int upTo100, int upTo200, int at200OrUp)
    {
        byte oldFriendship = friendship;
        friendship = (byte)Max(0, Min(255, friendship + (friendship switch
        {
            < 100 => upTo100,
            < 200 => upTo200,
            _ => at200OrUp
        })));
        return friendship != oldFriendship;
    }

    public bool AddFriendship(int amount) => AddFriendship(amount, amount, amount);

    public bool ShouldLevelUp()
    {
        return level < PokemonConst.maxLevel && xp > NextLevelXP;
    }
    public void CheckEvolution()
    {
        if (shouldEvolve) return;
        foreach (EvolutionData data in SpeciesData.evolution)
        {
            if (CheckEvolutionMethod(data.Method, data.Data))
            {
                (shouldEvolve, destinationSpecies) =
                    (true, data.Destination);
                return;
            }
        }
        (shouldEvolve, destinationSpecies) = (false, SpeciesID.Missingno);
    }

    public bool UsePPUp(int slot)
    {
        ref int ppLevel = ref PPLevel(slot);
        if (ppLevel > 2) return false;
        ppLevel++; return true;
    }

    public bool CheckEvolutionMethod(EvolutionMethod method, int data)
    {

        switch (method)
        {
            case EvolutionMethod.LevelUp:
                return level >= data;
            case EvolutionMethod.LevelUpWithMove when HasMove((MoveID)data):
            case EvolutionMethod.LevelUpMaleOnly when gender is Gender.Male:
            case EvolutionMethod.LevelUpFemaleOnly when gender is Gender.Female:
            case EvolutionMethod.LevelUpOddID when (id & 1) is 1:
            case EvolutionMethod.LevelUpEvenID when (id & 1) is 0:
            case EvolutionMethod.LevelUpHighAttack when attack > defense:
            case EvolutionMethod.LevelUpHighDefense when defense > attack:
            case EvolutionMethod.LevelUpEqualAttackDefense when defense == attack:
            case EvolutionMethod.LevelUpDay when TimeUtils.timeOfDay is TimeOfDay.Day:
            case EvolutionMethod.LevelUpNight when TimeUtils.timeOfDay is TimeOfDay.Night:
            case EvolutionMethod.LevelUpEvening when TimeUtils.timeOfDay is TimeOfDay.Evening:
                goto case EvolutionMethod.LevelUp;
            case EvolutionMethod.LevelUpMakeShedinja:
                makeShedinja = level >= data;
                return makeShedinja;
            case EvolutionMethod.Friendship:
                return friendship >= data;
            case EvolutionMethod.FriendshipDay when TimeUtils.timeOfDay is TimeOfDay.Day:
            case EvolutionMethod.FriendshipNight when TimeUtils.timeOfDay is TimeOfDay.Night:
                goto case EvolutionMethod.Friendship;
            default:
            case EvolutionMethod.Never:
                return false;
        }
    }
    public void LevelUp()
    {
        int maxHpBefore = hpMax;
        level++;
        hp += hpMax - maxHpBefore;
        AddFriendship(5, 4, 3);
        CheckEvolution();
    }
    public int Moves
        => move2 == MoveID.None ? 1 : move3 == MoveID.None ? 2 : move4 == MoveID.None ? 3 : 4;
    public void AddMove(int slot, MoveID move)
    {
        switch (slot)
        {
            case 1:
                move1 = move;
                pp1Level = 0;
                pp1 = maxPp1;
                break;
            case 2:
                move2 = move;
                pp2Level = 0;
                pp2 = maxPp2;
                break;
            case 3:
                move3 = move;
                pp3Level = 0;
                pp3 = maxPp3;
                break;
            case 4:
                move4 = move;
                pp4Level = 0;
                pp4 = maxPp4;
                break;
        }
    }
    public Pokemon(SpeciesID thisSpecies, Gender Gender, int Level,
        int IvHP, int IvAttack, int IvDefense, int IvSpAtk, int IvSpDef, int IvSpeed,
        int EvHP, int EvAttack, int EvDefense, int EvSpAtk, int EvSpDef, int EvSpeed,
        Nature thisNature, MoveID Move1, MoveID Move2, MoveID Move3, MoveID Move4,
        int WhichAbility, byte Friendship, ItemID Item, Type HiddenPowerType, bool Exists = true)
    {
        species = thisSpecies;
        gender = Gender;

        level = Level;

        ivHP = IvHP;
        ivAttack = IvAttack;
        ivDefense = IvDefense;
        ivSpAtk = IvSpAtk;
        ivSpDef = IvSpDef;
        ivSpeed = IvSpeed;

        evHP = EvHP;
        evAttack = EvAttack;
        evDefense = EvDefense;
        evSpAtk = EvSpAtk;
        evSpDef = EvSpDef;
        evSpeed = EvSpeed;
        totalEv = evHP + evAttack + evDefense + evSpAtk + evSpDef + evSpeed;

        nature = thisNature;
        whichAbility = WhichAbility;

        xp = XP.LevelToXP(level, SpeciesData.xpClass);

        move1 = Move1;
        move2 = Move2;
        move3 = Move3;
        move4 = Move4;

        pp1 = maxPp1;
        pp2 = maxPp2;
        pp3 = maxPp3;
        pp4 = maxPp4;

        hp = hpMax;
        status = Status.None;
        sleepTurns = 0;

        var random = new System.Random();
        id = random.Next();

        hiddenPowerType = HiddenPowerType;

        fainted = false;

        transformed = false;
        temporarySpecies = species;

        friendship = Friendship;
        item = Item;

        exists = Exists;
    }


    public IEnumerator CheckLevelUpMoves(FAnnounce Announce, Player p, Transform baseTransform, float menuScale, Vector2 menuPos)
    {
        foreach (LearnsetMove move in SpeciesData.learnset)
        {
            if (move.level != level) continue; //Learnsets should be ordered by level, but this is a failsafe
            if (Moves < 4)
            {
                AddMove(Moves + 1, move.move);
                yield return Announce(MonName + " learned " + move.move.Data().name + "!");
            }
            else
            {
                DataStore<int> whichMove = new();
                DataStore<int> binaryStore = new();
                IEnumerator BinaryChoice() => ChoiceMenu.DoChoiceMenu(p,
                        ScriptUtils.binaryChoice, 0, binaryStore,
                        baseTransform, menuPos, Vector2.zero, menuScale: menuScale);
                IEnumerator WantsToLearn()
                {
                    yield return Announce(MonName + " wants to learn " + move.move.Data().name + ".");
                    yield return Announce("However, " + MonName + " already knows four moves.");
                    yield return Announce("Should a move be forgotten in order to learn " + move.move.Data().name + "?");
                    yield return BinaryChoice();
                    if (binaryStore.Data == 0) yield return GiveUpOn();
                    else yield return DoMoveReplaceScreen();
                }
                IEnumerator GiveUpOn()
                {
                    yield return Announce("Give up on learning " + move.move.Data().name + "?");
                    yield return BinaryChoice();
                    if (binaryStore.Data == 0) yield return WantsToLearn();
                    else yield return Announce(MonName + " gave up on learning " + move.move.Data().name + ".");
                }
                IEnumerator DoMoveReplaceScreen()
                {
                    yield return MoveReplaceScreen.DoMoveReplaceScreen(p, this, whichMove, move.move);
                    if (whichMove.Data == 4) yield return GiveUpOn();
                    else yield return Forget();
                }
                IEnumerator Forget()
                {
                    yield return Announce("Really forget "
                        + MoveIDs[whichMove.Data].Data().name + "?");
                    yield return BinaryChoice();
                    if (binaryStore.Data == 0) yield return WantsToLearn();
                    else yield return LearnedMove();
                }
                IEnumerator LearnedMove()
                {
                    yield return Announce("1... 2... 3... And...");
                    yield return Announce("Done!");
                    yield return Announce(MonName + " forgot "
                        + MoveIDs[whichMove.Data].Data().name + " and learned "
                        + move.move.Data().name + "!");
                    AddMove(whichMove.Data + 1, move.move);
                }
                yield return WantsToLearn();
            }
        }
    }

    public static Pokemon WildPokemon(SpeciesID species, int level)
    {
        var random = new System.Random();
        int IvHP = random.Next() & 31;
        int IvAttack = random.Next() & 31;
        int IvDefense = random.Next() & 31;
        int IvSpAtk = random.Next() & 31;
        int IvSpDef = random.Next() & 31;
        int IvSpeed = random.Next() & 31;

        int personality = random.Next();
        Gender gender = Species.SpeciesTable[(int)species].malePercent == SpeciesData.Genderless
            ? Gender.Genderless
            : personality % 100 > Species.SpeciesTable[(int)species].malePercent
            ? Gender.Female : Gender.Male;
        Nature Nature = (Nature)((personality >> 1) % 25);

        MoveID[] Moves = Learnset.GetMoves(Species.SpeciesTable[(int)species].learnset, level);

        return new Pokemon(species, gender, level, IvHP, IvAttack, IvDefense, IvSpAtk, IvSpDef, IvSpeed,
            0, 0, 0, 0, 0, 0,
            Nature, Moves[0], Moves[1], Moves[2], Moves[3], (int)Floor(random.NextDouble() * 2),
            Species.SpeciesTable[(int)species].baseFriendship, ItemID.None, (Type)(random.Next() % 18));
    }
    public static Pokemon EmptyMon = new
        (SpeciesID.Missingno, Gender.Genderless, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Nature.Serious, MoveID.None, MoveID.None, MoveID.None, MoveID.None, 0, 0, ItemID.None, Type.Normal, false);
    public object Clone() => MemberwiseClone() as Pokemon;
}

public static class PokemonUtils
{
    public static void HealAll(this Pokemon[] party)
    {
        foreach (Pokemon mon in party)
        {
            mon.FullHeal();
        }
    }
}