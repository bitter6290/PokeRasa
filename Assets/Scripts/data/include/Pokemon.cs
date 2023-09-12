using static System.Math;
using static System.Convert;
using System;

[Serializable]
public class Pokemon : ICloneable
{
    public SpeciesID species;


    public string monName;
    public Gender gender;

    public int xp;
    public byte level;
    public int currentLevelXP;
    public int nextLevelXP;
    public byte levelProgress;

    private byte ivHP;
    private byte ivAttack;
    private byte ivDefense;
    private byte ivSpAtk;
    private byte ivSpDef;
    private byte ivSpeed;

    public byte evHP;
    public byte evAttack;
    public byte evDefense;
    public byte evSpAtk;
    public byte evSpDef;
    public byte evSpeed;
    public int totalEv;

    private byte nature;
    public byte whichAbility;

    public int hpMax;
    public int attack;
    public int defense;
    public int spAtk;
    public int spDef;
    public int speed;

    public MoveID move1;
    public byte maxPp1;
    public byte pp1;
    public MoveID move2;
    public byte maxPp2;
    public byte pp2;
    public MoveID move3;
    public byte maxPp3;
    public byte pp3;
    public MoveID move4;
    public byte maxPp4;
    public byte pp4;

    public int HP;
    public Status status;
    public byte sleepTurns;

    public bool fainted;

    public bool exists;

    public ItemID item;

    public bool onField = false;

    public bool transformed;
    public SpeciesID temporarySpecies;

    public byte friendship;

    public byte hiddenPowerType;



    public SpeciesData SpeciesData => Species.SpeciesTable[transformed ?
        (int)temporarySpecies : (int)species];

    public MoveID[] MoveIDs => new MoveID[4]
    {
        move1,
        move2,
        move3,
        move4
    };

    public byte[] PP => new byte[4]
    {
        pp1,
        pp2,
        pp3,
        pp4
    };

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
        CalculateStats();
    }

    public void SetNature(byte nature) => this.nature = nature;

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

    private int CalculateHPMax()
    {
        return (((2 * SpeciesData.baseHP) + ivHP + (evHP >> 2)) * level / 100 + level + 10);
    }

    private int CalculateStat(byte statID, byte baseStat, byte statIv, byte statEv)
    {
        return (int)Floor((((2 * baseStat) + statIv + (statEv >> 2)) * level / 100 + 5) * Nature.NatureEffect(nature, statID));
    }

    public void CalculateStats()
    {
        hpMax = CalculateHPMax();
        attack = CalculateStat(0, SpeciesData.baseAttack, ivAttack, evAttack);
        defense = CalculateStat(1, SpeciesData.baseDefense, ivDefense, evDefense);
        spAtk = CalculateStat(3, SpeciesData.baseSpAtk, ivSpAtk, evSpAtk);
        spDef = CalculateStat(4, SpeciesData.baseSpDef, ivSpDef, evSpDef);
        speed = CalculateStat(2, SpeciesData.baseSpeed, ivSpeed, evSpeed);
    }

    public bool ShouldLevelUp()
    {
        return level < PokemonConst.maxLevel && xp > nextLevelXP;
    }
    public (bool, SpeciesID) ShouldEvolve()
    {
        for (int i = 0; i < SpeciesData.evolution.Length; i++)
        {
            if (CheckEvolutionMethod(SpeciesData.evolution[i].Method, SpeciesData.evolution[i].Data))
            {
                return (true, SpeciesData.evolution[i].Destination);
            }
        }
        return (false, SpeciesID.Missingno);
    }
    public bool CheckEvolutionMethod(EvolutionMethod method, int data)
    {
        switch (method)
        {
            case EvolutionMethod.LevelUp:
                return level >= data;
            default:
            case EvolutionMethod.Never:
                return false;
        }
    }
    public void LevelUp()
    {
        level += 1;
        currentLevelXP = nextLevelXP;
        GetNextLevel();
        CalculateStats();
    }
    public void GetXP(int amount)
    {
        xp = xp + amount;
        while (ShouldLevelUp())
        {
            LevelUp();
        }
    }
    public void GetNextLevel()
    {
        nextLevelXP = XP.LevelToXP(ToByte(level + 1), SpeciesData.xpClass);
    }
    public byte GetLevelProgress()
    {
        return level >= PokemonConst.maxLevel ? ToByte(0) : ToByte((xp - XP.LevelToXP(level, SpeciesData.xpClass)) * 8 / (nextLevelXP - XP.LevelToXP(level, SpeciesData.xpClass)));
    }
    public int Moves()
    {
        return move2 == MoveID.None ? 1 : move3 == MoveID.None ? 2 : move4 == MoveID.None ? 3 : 4;
    }
    public void AddMove(int slot, MoveID move)
    {
        switch (slot)
        {
            case 1:
                move1 = move;
                maxPp1 = Move.MoveTable[(int)move].pp;
                pp1 = maxPp1;
                break;
            case 2:
                move2 = move;
                maxPp2 = Move.MoveTable[(int)move].pp;
                pp2 = maxPp2;
                break;
            case 3:
                move3 = move;
                maxPp3 = Move.MoveTable[(int)move].pp;
                pp3 = maxPp3;
                break;
            case 4:
                move4 = move;
                maxPp4 = Move.MoveTable[(int)move].pp;
                pp4 = maxPp4;
                break;
        }
    }
    public Pokemon(SpeciesID thisSpecies, Gender Gender, byte Level,
        byte IvHP, byte IvAttack, byte IvDefense, byte IvSpAtk, byte IvSpDef, byte IvSpeed,
        byte EvHP, byte EvAttack, byte EvDefense, byte EvSpAtk, byte EvSpDef, byte EvSpeed,
        byte thisNature, MoveID Move1, MoveID Move2, MoveID Move3, MoveID Move4,
        byte WhichAbility, byte Friendship, ItemID Item, byte HiddenPowerType, bool Exists = true)
    {
        species = thisSpecies;
        gender = Gender;

        monName = SpeciesData.speciesName;

        level = Level;
        currentLevelXP = XP.LevelToXP(level, SpeciesData.xpClass);
        nextLevelXP = level >= PokemonConst.maxLevel ? 0 : XP.LevelToXP(ToByte(level + 1), SpeciesData.xpClass);
        levelProgress = 0;

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

        hpMax = ToUInt16(((2 * SpeciesData.baseHP) + ivHP) * level / 100 + level + 10);
        attack = ToUInt16(Floor((((2 * SpeciesData.baseAttack) + ivAttack + (evHP >> 2)) * level / 100 + 5) * Nature.NatureEffect(nature, 0)));
        defense = ToUInt16(Floor((((2 * SpeciesData.baseDefense) + ivDefense) * level / 100 + 5) * Nature.NatureEffect(nature, 1)));
        spAtk = ToUInt16(Floor((((2 * SpeciesData.baseSpAtk) + ivSpAtk) * level / 100 + 5) * Nature.NatureEffect(nature, 3)));
        spDef = ToUInt16(Floor((((2 * SpeciesData.baseSpDef) + ivSpDef) * level / 100 + 5) * Nature.NatureEffect(nature, 4)));
        speed = ToUInt16(Floor((((2 * SpeciesData.baseSpeed) + ivSpeed) * level / 100 + 5) * Nature.NatureEffect(nature, 2)));

        move1 = Move1;
        move2 = Move2;
        move3 = Move3;
        move4 = Move4;

        maxPp1 = Move.MoveTable[(int)move1].pp;
        pp1 = maxPp1;
        maxPp2 = Move.MoveTable[(int)move2].pp;
        pp2 = maxPp2;
        maxPp3 = Move.MoveTable[(int)move3].pp;
        pp3 = maxPp3;
        maxPp4 = Move.MoveTable[(int)move4].pp;
        pp4 = maxPp4;

        HP = hpMax;
        status = Status.None;
        sleepTurns = 0;

        hiddenPowerType = HiddenPowerType;

        fainted = false;

        transformed = false;
        temporarySpecies = species;

        friendship = Friendship;
        item = Item;

        exists = Exists;
    }
    public static Pokemon WildPokemon(SpeciesID species, byte level)
    {
        var random = new System.Random();
        byte[] ivBytes = new byte[6];
        random.NextBytes(ivBytes);
        byte IvHP = (byte)(ivBytes[0] >> 3);
        byte IvAttack = (byte)(ivBytes[1] >> 3);
        byte IvDefense = (byte)(ivBytes[2] >> 3);
        byte IvSpAtk = (byte)(ivBytes[3] >> 3);
        byte IvSpDef = (byte)(ivBytes[4] >> 3);
        byte IvSpeed = (byte)(ivBytes[5] >> 3);

        int personality = random.Next();
        Gender gender = Species.SpeciesTable[(int)species].malePercent == SpeciesData.Genderless
            ? Gender.Genderless
            : personality % 100 > Species.SpeciesTable[(int)species].malePercent
            ? Gender.Female : Gender.Male;
        byte Nature = (byte)((personality >> 1) % 25);

        MoveID[] Moves = Learnset.GetMoves(Species.SpeciesTable[(int)species].learnset, level);

        return new Pokemon(species, gender, level, IvHP, IvAttack, IvDefense, IvSpAtk, IvSpDef, IvSpeed,
            0, 0, 0, 0, 0, 0,
            Nature, Moves[0], Moves[1], Moves[2], Moves[3], (byte)Floor(random.NextDouble() * 2),
            Species.SpeciesTable[(int)species].baseFriendship, ItemID.None, (byte)(random.Next() % 18));
    }
    public static Pokemon MakeEmptyMon => new
        (SpeciesID.Missingno, Gender.Genderless, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Nature.Serious, MoveID.None, MoveID.None, MoveID.None, MoveID.None, 0, 0, ItemID.None, Type.Normal, false);
    public object Clone() => MemberwiseClone() as Pokemon;
}