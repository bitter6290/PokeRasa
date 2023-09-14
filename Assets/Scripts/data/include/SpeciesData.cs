using System;

public struct SpeciesData
{
    public const int Genderless = 255;

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
    public static SpeciesData Unown(string path, int backSpriteHeight) => new()
    {
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

    public static SpeciesData Mega(SpeciesData baseSpecies,
    int baseAttack, int baseDefense, int baseSpAtk, int baseSpDef, int baseSpeed,
    int backSpriteHeight, PokedexData pokedexData, Ability ability,
     Type type1 = Type.Typeless, Type type2 = Type.Typeless,
     string cry = "", string graphics = "", string name = "") => new()
     {
         speciesName = name == "" ? "Mega " + baseSpecies.speciesName : name,
         type1 = type1 == Type.Typeless ? baseSpecies.type1 : type1,
         type2 = type2 == Type.Typeless ? baseSpecies.type2 : type2,
         baseHP = baseSpecies.baseHP,
         baseAttack = baseAttack,
         baseDefense = baseDefense,
         baseSpAtk = baseSpAtk,
         baseSpDef = baseSpDef,
         baseSpeed = baseSpeed,
         evYield = baseSpecies.evYield,
         evolution = baseSpecies.evolution,
         xpClass = baseSpecies.xpClass,
         xpYield = baseSpecies.xpYield,
         learnset = baseSpecies.learnset,
         malePercent = baseSpecies.malePercent,
         eggGroup1 = baseSpecies.eggGroup1,
         eggGroup2 = baseSpecies.eggGroup2,
         eggCycles = baseSpecies.eggCycles,
         catchRate = baseSpecies.catchRate,
         baseFriendship = baseSpecies.baseFriendship,
         cryLocation = cry == "" ? "mega_" + baseSpecies.cryLocation : cry,
         graphicsLocation = graphics == "" ? baseSpecies.graphicsLocation + "/mega" : graphics,
         backSpriteHeight = backSpriteHeight,
         pokedexData = pokedexData,
         abilities = new Ability[3]
         {
                 ability,
                 ability,
                 ability,
         }
     };
}