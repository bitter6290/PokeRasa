using static System.Math;
using static System.Convert;
using System;

[Serializable]
public class Pokemon
{
    public SpeciesID species;


    public string monName;
    public bool gender;

    public int xp;
    public byte level;
    public int currentLevelXP;
    public int nextLevelXP;
    public byte levelProgress;

    private readonly byte ivHP;
    private readonly byte ivAttack;
    private readonly byte ivDefense;
    private byte ivSpAtk;
    private byte ivSpDef;
    private byte ivSpeed;

    public byte evHP;
    public byte evAttack;
    public byte evDefense;
    public byte evSpAtk;
    public byte evSpDef;
    public byte evSpeed;
    public ushort totalEv;

    private byte nature;
    public byte whichAbility;

    public ushort hpMax;
    public ushort attack;
    public ushort defense;
    public ushort spAtk;
    public ushort spDef;
    public ushort speed;

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

    public ushort HP;
    public byte status;
    public byte sleepTurns;

    public bool fainted;

    public bool exists;

    public ushort item;

    public bool transformed;
    public SpeciesID temporarySpecies;

    public SpeciesData SpeciesData => Species.SpeciesTable[transformed ?
        (int)temporarySpecies : (int)species];

    private ushort CalculateHP()
    {
        return ToUInt16(((2 * SpeciesData.baseHP) + ivHP + (evHP >> 2)) * level / 100 + level + 10);
    }
    private ushort CalculateStat(byte statID, byte baseStat, byte statIv, byte statEv)
    {
        return ToUInt16(Floor((((2 * baseStat) + statIv + (statEv >> 2)) * level / 100 + 5) * Natures.NatureEffect(nature, statID)));
    }
    public void CalculateStats()
    {
        hpMax = CalculateHP();
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
    public bool CheckEvolutionMethod(byte method, int data)
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
    public Pokemon(SpeciesID thisSpecies, bool Gender, byte Level,
        byte IvHP, byte IvAttack, byte IvDefense, byte IvSpAtk, byte IvSpDef, byte IvSpeed,
        byte EvHP, byte EvAttack, byte EvDefense, byte EvSpAtk, byte EvSpDef, byte EvSpeed,
        byte thisNature, MoveID Move1, MoveID Move2, MoveID Move3, MoveID Move4,
        byte WhichAbility, ushort Item, bool Exists = true)
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
        totalEv = (ushort)(evHP + evAttack + evDefense + evSpAtk + evSpDef + evSpeed);

        nature = thisNature;
        whichAbility = WhichAbility;

        xp = XP.LevelToXP(level, SpeciesData.xpClass);

        hpMax = ToUInt16(((2 * SpeciesData.baseHP) + ivHP) * level / 100 + level + 10);
        attack = ToUInt16(Floor((((2 * SpeciesData.baseAttack) + ivAttack + (evHP >> 2)) * level / 100 + 5) * Natures.NatureEffect(nature, 0)));
        defense = ToUInt16(Floor((((2 * SpeciesData.baseDefense) + ivDefense) * level / 100 + 5) * Natures.NatureEffect(nature, 1)));
        spAtk = ToUInt16(Floor((((2 * SpeciesData.baseSpAtk) + ivSpAtk) * level / 100 + 5) * Natures.NatureEffect(nature, 3)));
        spDef = ToUInt16(Floor((((2 * SpeciesData.baseSpDef) + ivSpDef) * level / 100 + 5) * Natures.NatureEffect(nature, 4)));
        speed = ToUInt16(Floor((((2 * SpeciesData.baseSpeed) + ivSpeed) * level / 100 + 5) * Natures.NatureEffect(nature, 2)));

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

        fainted = false;

        transformed = false;
        temporarySpecies = species;

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
        bool Gender = personality % 2 == 1 ? true : false;
        byte Nature = (byte)((personality >> 1) % 25);

        MoveID[] Moves = Learnset.GetMoves(Species.SpeciesTable[(int)species].learnset, level);

        return new Pokemon(species, Gender, level, IvHP, IvAttack, IvDefense, IvSpAtk, IvSpDef, IvSpeed, 0, 0, 0, 0, 0, 0, Nature, Moves[0], Moves[1], Moves[2], Moves[3], (byte)Floor(random.NextDouble() * 2), ItemID.None);
    }
    public static Pokemon MakeEmptyMon => new
        (SpeciesID.Missingno, false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Natures.Serious, MoveID.None, MoveID.None, MoveID.None, MoveID.None, 0, ItemID.None, false);
}