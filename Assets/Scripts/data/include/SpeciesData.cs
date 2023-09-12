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
    public byte backSpriteHeight;

    //Todo: add egg groups

    public PokedexData pokedexData;

    public Ability[] abilities;
}