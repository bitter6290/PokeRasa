using System;

public struct SpeciesData
{
    public const int Genderless = 255;
    public SpeciesID id;

    public string speciesName;

    public Type type1;
    public Type type2;

    public int baseHP;
    public int baseAttack;
    public int baseDefense;
    public int baseSpAtk;
    public int baseSpDef;
    public int baseSpeed;

    public short evYield;

    public EvolutionData[] evolution;
    public XPClass xpClass;
    public int xpYield;

    public LearnsetMove[] learnset;

    public int malePercent;

    public int eggCycles;
    public EggGroup eggGroup1;
    public EggGroup eggGroup2;

    public int catchRate;
    public int baseFriendship;

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

    public static SpeciesData Mega(SpeciesData baseData) => new()
    {
        speciesName = "Mega " + baseData.speciesName,
        baseHP = baseData.baseHP,
        evYield = baseData.evYield,
        evolution = baseData.evolution,
        xpClass = baseData.xpClass,
        learnset = baseData.learnset,
        malePercent = baseData.malePercent,
        eggGroup1 = baseData.eggGroup1,
        eggGroup2 = baseData.eggGroup2,
        eggCycles = baseData.eggCycles,
        catchRate = baseData.catchRate,
        baseFriendship = baseData.baseFriendship,
    };
}