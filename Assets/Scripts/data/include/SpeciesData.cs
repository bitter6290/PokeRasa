using System;

public readonly struct SpeciesData
{
    public readonly SpeciesID id;

    public readonly string speciesName;

    public readonly byte type1;
    public readonly byte type2;

    public readonly byte baseHP;
    public readonly byte baseAttack;
    public readonly byte baseDefense;
    public readonly byte baseSpAtk;
    public readonly byte baseSpDef;
    public readonly byte baseSpeed;

    public readonly short evYield;

    public readonly EvolutionData[] evolution;
    public readonly byte xpClass;
    public readonly byte xpYield;

    public readonly LearnsetMove[] learnset;

    public readonly string cryLocation;

    public readonly string graphicsLocation;
    public readonly byte backSpriteHeight;

    public readonly Ability[] abilities;

    public SpeciesData(SpeciesID id, string speciesName, byte type1, byte type2, byte baseHP, byte baseAttack,
        byte baseDefense, byte baseSpAtk, byte baseSpDef, byte baseSpeed, short evYield, EvolutionData[] evolution,
        byte xpClass, byte xpYield, LearnsetMove[] learnset, Ability[] abilities, string cryLocation, string graphicsLocation, byte backSpriteHeight)
    {
        this.id = id;
        this.speciesName = speciesName;
        this.type1 = type1;
        this.type2 = type2;
        this.baseHP = baseHP;
        this.baseAttack = baseAttack;
        this.baseDefense = baseDefense;
        this.baseSpAtk = baseSpAtk;
        this.baseSpDef = baseSpDef;
        this.baseSpeed = baseSpeed;
        this.evYield = evYield;
        this.evolution = evolution;
        this.xpClass = xpClass;
        this.xpYield = xpYield;
        this.learnset = learnset;
        this.cryLocation = cryLocation;
        this.graphicsLocation = graphicsLocation;
        this.backSpriteHeight = backSpriteHeight;
        if (abilities.Length != 3)
        {
            throw new Exception("Wrong number of abilities for " + speciesName);
        }
        this.abilities = abilities;
    }
}