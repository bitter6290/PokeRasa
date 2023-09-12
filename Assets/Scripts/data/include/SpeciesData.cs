using System;

public struct SpeciesData
{
    public const byte Genderless = 255;
    public SpeciesID id;

    public string speciesName;

    public byte type1;
    public byte type2;

    public byte baseHP;
    public byte baseAttack;
    public byte baseDefense;
    public byte baseSpAtk;
    public byte baseSpDef;
    public byte baseSpeed;

    public short evYield;

    public EvolutionData[] evolution;
    public XPClass xpClass;
    public int xpYield;

    public LearnsetMove[] learnset;

    public byte malePercent;

    public byte eggCycles;
    public EggGroup eggGroup1;
    public EggGroup eggGroup2;

    public byte catchRate;
    public byte baseFriendship;

    public string cryLocation;

    public string graphicsLocation;
    public int backSpriteHeight;

    //Todo: add egg groups

    public PokedexData pokedexData;

    public Ability[] abilities;

    //Unown constructor
    public static SpeciesData Unown(SpeciesID id, string path, int backSpriteHeight) => new()
    {
        id = id,
        speciesName = "Unown",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 48,
        baseAttack = 72,
        baseDefense = 48,
        baseSpAtk = 72,
        baseSpDef = 48,
        baseSpeed = 48,
        evYield = EvYield.Attack + EvYield.SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 118,
        learnset = Learnset.EmptyLearnset,
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 40,
        catchRate = 225,
        baseFriendship = 50,
        cryLocation = "unown",
        graphicsLocation = path,
        backSpriteHeight = backSpriteHeight,
        pokedexData = Pokedex.Unown, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
}