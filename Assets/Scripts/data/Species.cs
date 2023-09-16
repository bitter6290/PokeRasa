using Unity.VisualScripting;
using static EvYield;

public static class Species
{
    public static SpeciesData Missingno = new()
    {
        speciesName = "Missingno",
        type1 = Type.Typeless,
        type2 = Type.Typeless,
        baseHP = 0,
        baseAttack = 0,
        baseDefense = 0,
        baseSpAtk = 0,
        baseSpDef = 0,
        baseSpeed = 0,
        evYield = 0,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 0,
        learnset = Learnset.EmptyLearnset,
        cryLocation = "pikachu",
        graphicsLocation = "circled_question_mark",
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur,
        abilities = new Ability[3]
        {
            Ability.None,
            Ability.None,
            Ability.None,
        }
    };
    public static SpeciesData Bulbasaur = new()
    {
        speciesName = "Bulbasaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 49,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Bulbasaur,
        xpClass = XPClass.MediumSlow,
        xpYield = 64,
        learnset = Learnset.BulbasaurLearnset,
        catchRate = 45,
        baseFriendship = 70,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        malePercent = 87,
        cryLocation = "bulbasaur",
        graphicsLocation = "bulbasaur",
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur,
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Chlorophyll,
        }
    };
    public static SpeciesData Ivysaur = new()
    {
        speciesName = "Ivysaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 63,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = SpAtk + SpDef,
        evolution = Evolution.Ivysaur,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "ivysaur", //Verify
        graphicsLocation = "ivysaur", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Chlorophyll,
        },
    };
    public static SpeciesData Venusaur = new()
    {
        speciesName = "Venusaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 83,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 2 * SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 236,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "venusaur", //Verify
        graphicsLocation = "venusaur", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Chlorophyll,
        },
    };
    public static SpeciesData Charmander = new()
    {
        speciesName = "Charmander",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Charmander,
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "charmander", //Verify
        graphicsLocation = "charmander", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SolarPower,
        },
    };
    public static SpeciesData Charmeleon = new()
    {
        speciesName = "Charmeleon",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = Speed + SpAtk,
        evolution = Evolution.Charmeleon,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "charmeleon", //Verify
        graphicsLocation = "charmeleon", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SolarPower,
        },
    };
    public static SpeciesData Charizard = new()
    {
        speciesName = "Charizard",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 240,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "charizard", //Verify
        graphicsLocation = "charizard", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SolarPower,
        },
    };
    public static SpeciesData Squirtle = new()
    {
        speciesName = "Squirtle",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 44,
        baseAttack = 48,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 64,
        baseSpeed = 43,
        evYield = Defense,
        evolution = Evolution.Squirtle,
        xpClass = XPClass.MediumSlow,
        xpYield = 63,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "squirtle", //Verify
        graphicsLocation = "squirtle", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.RainDish,
        },
    };
    public static SpeciesData Wartortle = new()
    {
        speciesName = "Wartortle",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 59,
        baseAttack = 63,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 58,
        evYield = Defense + SpDef,
        evolution = Evolution.Wartortle,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "wartortle", //Verify
        graphicsLocation = "wartortle", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.RainDish,
        },
    };
    public static SpeciesData Blastoise = new()
    {
        speciesName = "Blastoise",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 79,
        baseAttack = 83,
        baseDefense = 100,
        baseSpAtk = 85,
        baseSpDef = 105,
        baseSpeed = 78,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "blastoise", //Verify
        graphicsLocation = "blastoise", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.RainDish,
        },
    };
    public static SpeciesData Caterpie = new()
    {
        speciesName = "Caterpie",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 45,
        evYield = HP,
        evolution = Evolution.Caterpie,
        xpClass = XPClass.MediumFast,
        xpYield = 39,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "caterpie", //Verify
        graphicsLocation = "caterpie", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShieldDust,
            Ability.ShieldDust,
            Ability.RunAway,
        },
    };
    public static SpeciesData Metapod = new()
    {
        speciesName = "Metapod",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 20,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.Metapod,
        xpClass = XPClass.MediumFast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "metapod", //Verify
        graphicsLocation = "metapod", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.ShedSkin,
        },
    };
    public static SpeciesData Butterfree = new()
    {
        speciesName = "Butterfree",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 70,
        evYield = 2 * SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 178,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "butterfree", //Verify
        graphicsLocation = "butterfree", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CompoundEyes,
            Ability.CompoundEyes,
            Ability.TintedLens,
        },
    };
    public static SpeciesData Weedle = new()
    {
        speciesName = "Weedle",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 50,
        evYield = Speed,
        evolution = Evolution.Weedle,
        xpClass = XPClass.MediumFast,
        xpYield = 39,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "weedle", //Verify
        graphicsLocation = "weedle", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShieldDust,
            Ability.ShieldDust,
            Ability.RunAway,
        },
    };
    public static SpeciesData Kakuna = new()
    {
        speciesName = "Kakuna",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 25,
        baseDefense = 50,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 35,
        evYield = 2 * Defense,
        evolution = Evolution.Kakuna,
        xpClass = XPClass.MediumFast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "kakuna", //Verify
        graphicsLocation = "kakuna", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.ShedSkin,
        },
    };
    public static SpeciesData Beedrill = new()
    {
        speciesName = "Beedrill",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 40,
        baseSpAtk = 45,
        baseSpDef = 80,
        baseSpeed = 75,
        evYield = 2 * Attack + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 178,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "beedrill", //Verify
        graphicsLocation = "beedrill", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Swarm,
            Ability.Sniper,
        },
    };
    public static SpeciesData Pidgey = new()
    {
        speciesName = "Pidgey",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 56,
        evYield = Speed,
        evolution = Evolution.Pidgey,
        xpClass = XPClass.MediumSlow,
        xpYield = 50,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "pidgey", //Verify
        graphicsLocation = "pidgey", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.TangledFeet,
            Ability.BigPecks,
        },
    };
    public static SpeciesData Pidgeotto = new()
    {
        speciesName = "Pidgeotto",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 63,
        baseAttack = 60,
        baseDefense = 55,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 71,
        evYield = 2 * Speed,
        evolution = Evolution.Pidgeotto,
        xpClass = XPClass.MediumSlow,
        xpYield = 122,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "pidgeotto", //Verify
        graphicsLocation = "pidgeotto", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.TangledFeet,
            Ability.BigPecks,
        },
    };
    public static SpeciesData Pidgeot = new()
    {
        speciesName = "Pidgeot",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 83,
        baseAttack = 80,
        baseDefense = 75,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 91,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 216,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "pidgeot", //Verify
        graphicsLocation = "pidgeot", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.TangledFeet,
            Ability.BigPecks,
        },
    };
    public static SpeciesData Rattata = new()
    {
        speciesName = "Rattata",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 30,
        baseAttack = 56,
        baseDefense = 35,
        baseSpAtk = 25,
        baseSpDef = 35,
        baseSpeed = 72,
        evYield = Speed,
        evolution = Evolution.Rattata,
        xpClass = XPClass.MediumFast,
        xpYield = 51,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "rattata", //Verify
        graphicsLocation = "rattata", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.Guts,
            Ability.Hustle,
        },
    };
    public static SpeciesData Raticate = new()
    {
        speciesName = "Raticate",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 81,
        baseDefense = 60,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 97,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 145,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 127,
        baseFriendship = 70,
        cryLocation = "raticate", //Verify
        graphicsLocation = "raticate", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.Guts,
            Ability.Hustle,
        },
    };
    public static SpeciesData Spearow = new()
    {
        speciesName = "Spearow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 31,
        baseSpDef = 31,
        baseSpeed = 70,
        evYield = Speed,
        evolution = Evolution.Spearow,
        xpYield = 52,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "spearow", //Verify
        graphicsLocation = "spearow", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.KeenEye,
            Ability.Sniper,
        },
    };
    public static SpeciesData Fearow = new()
    {
        speciesName = "Fearow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 65,
        baseSpAtk = 61,
        baseSpDef = 61,
        baseSpeed = 100,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 155,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "fearow", //Verify
        graphicsLocation = "fearow", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.KeenEye,
            Ability.Sniper,
        },
    };
    public static SpeciesData Ekans = new()
    {
        speciesName = "Ekans",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 35,
        baseAttack = 60,
        baseDefense = 44,
        baseSpAtk = 40,
        baseSpDef = 54,
        baseSpeed = 55,
        evYield = Attack,
        evolution = Evolution.Ekans,
        xpClass = XPClass.MediumFast,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "ekans", //Verify
        graphicsLocation = "ekans", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.ShedSkin,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Arbok = new()
    {
        speciesName = "Arbok",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 69,
        baseSpAtk = 65,
        baseSpDef = 79,
        baseSpeed = 80,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 157,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "arbok", //Verify
        graphicsLocation = "arbok", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.ShedSkin,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Pikachu = new()
    {
        speciesName = "Pikachu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 35,
        baseAttack = 55,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Pikachu,
        xpClass = XPClass.MediumFast,
        xpYield = 112,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "pikachu", //Verify
        graphicsLocation = "pikachu", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.LightningRod,
        },
    };
    public static SpeciesData Raichu = new()
    {
        speciesName = "Raichu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 55,
        baseSpAtk = 90,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 218,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "raichu", //Verify
        graphicsLocation = "raichu", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.LightningRod,
        },
    };
    public static SpeciesData Sandshrew = new()
    {
        speciesName = "Sandshrew",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "sandshrew", //Verify
        graphicsLocation = "sandshrew", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SandVeil,
            Ability.SandVeil,
            Ability.SandRush,
        },
    };
    public static SpeciesData Sandslash = new()
    {
        speciesName = "Sandslash",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 110,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "sandslash", //Verify
        graphicsLocation = "sandslash", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SandVeil,
            Ability.SandVeil,
            Ability.SandRush,
        },
    };
    public static SpeciesData NidoranF = new()
    {
        speciesName = "Nidoran",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 55,
        baseAttack = 47,
        baseDefense = 52,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 41,
        evYield = HP,
        evolution = Evolution.NidoranF,
        xpClass = XPClass.MediumSlow,
        xpYield = 55,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 70,
        cryLocation = "nidoran_f", //Verify
        graphicsLocation = "nidoran_f", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.PoisonPoint,
            Ability.Rivalry,
            Ability.Hustle,
        },

    };
    public static SpeciesData Nidorina = new()
    {
        speciesName = "Nidorina",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 62,
        baseDefense = 67,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 56,
        evYield = 2 * HP,
        evolution = Evolution.Nidorina,
        xpClass = XPClass.MediumSlow,
        xpYield = 128,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "nidorina", //Verify
        graphicsLocation = "nidorina", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Rivalry,
                Ability.Hustle,
        },
    };
    public static SpeciesData Nidoqueen = new()
    {
        speciesName = "Nidoqueen",
        type1 = Type.Poison,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 82,
        baseDefense = 87,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 76,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 227,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "nidoqueen", //Verify
        graphicsLocation = "nidoqueen", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Rivalry,
                Ability.SheerForce,
        },
    };
    public static SpeciesData NidoranM = new()
    {
        speciesName = "Nidoran",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 46,
        baseAttack = 57,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.NidoranM,
        xpClass = XPClass.MediumSlow,
        xpYield = 55,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 70,
        cryLocation = "nidoran_m", //Verify
        graphicsLocation = "nidoran_m", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Rivalry,
                Ability.Hustle,
        },
    };
    public static SpeciesData Nidorino = new()
    {
        speciesName = "Nidorino",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 61,
        baseAttack = 72,
        baseDefense = 57,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.Nidorino,
        xpClass = XPClass.MediumSlow,
        xpYield = 128,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "nidorino", //Verify
        graphicsLocation = "nidorino", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Rivalry,
                Ability.Hustle,
        },
    };
    public static SpeciesData Nidoking = new()
    {
        speciesName = "Nidoking",
        type1 = Type.Poison,
        type2 = Type.Ground,
        baseHP = 81,
        baseAttack = 92,
        baseDefense = 77,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 85,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 227,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "nidoking", //Verify
        graphicsLocation = "nidoking", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Rivalry,
                Ability.SheerForce,
        },
    };
    public static SpeciesData Clefairy = new()
    {
        speciesName = "Clefairy",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 70,
        baseAttack = 45,
        baseDefense = 48,
        baseSpAtk = 60,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * HP,
        evolution = Evolution.Clefairy,
        xpClass = XPClass.Fast,
        xpYield = 113,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 150,
        baseFriendship = 140,
        cryLocation = "clefairy", //Verify
        graphicsLocation = "clefairy", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.CuteCharm,
                Ability.MagicGuard,
                Ability.FriendGuard,
        },
    };
    public static SpeciesData Clefable = new()
    {
        speciesName = "Clefable",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 95,
        baseAttack = 70,
        baseDefense = 73,
        baseSpAtk = 85,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 217,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 25,
        baseFriendship = 140,
        cryLocation = "clefable", //Verify
        graphicsLocation = "clefable", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.CuteCharm,
                Ability.MagicGuard,
                Ability.Unaware,
        },
    };
    public static SpeciesData Vulpix = new()
    {
        speciesName = "Vulpix",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 38,
        baseAttack = 41,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Vulpix,
        xpClass = XPClass.MediumFast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "vulpix", //Verify
        graphicsLocation = "vulpix", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.FlashFire,
                Ability.FlashFire,
                Ability.Drought,
        },
    };
    public static SpeciesData Ninetales = new()
    {
        speciesName = "Ninetales",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 73,
        baseAttack = 76,
        baseDefense = 75,
        baseSpAtk = 81,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = Speed + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 177,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "ninetales", //Verify
        graphicsLocation = "ninetales", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.FlashFire,
                Ability.FlashFire,
                Ability.Drought,
        },
    };
    public static SpeciesData Jigglypuff = new()
    {
        speciesName = "Jigglypuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 115,
        baseAttack = 45,
        baseDefense = 20,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 20,
        evYield = 2 * HP,
        evolution = Evolution.Jigglypuff,
        xpClass = XPClass.Fast,
        xpYield = 95,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 170,
        baseFriendship = 70,
        cryLocation = "jigglypuff", //Verify
        graphicsLocation = "jigglypuff", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.CuteCharm,
                Ability.Competitive,
                Ability.FriendGuard,
        },
    };
    public static SpeciesData Wigglytuff = new()
    {
        speciesName = "Wigglytuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 140,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 75,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 196,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 50,
        baseFriendship = 70,
        cryLocation = "wigglytuff", //Verify
        graphicsLocation = "wigglytuff", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.CuteCharm,
                Ability.Competitive,
                Ability.Frisk,
        },
    };
    public static SpeciesData Zubat = new()
    {
        speciesName = "Zubat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 30,
        baseSpDef = 40,
        baseSpeed = 55,
        evYield = Speed,
        evolution = Evolution.Zubat,
        xpClass = XPClass.MediumFast,
        xpYield = 49,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "zubat", //Verify
        graphicsLocation = "zubat", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.InnerFocus,
                Ability.InnerFocus,
                Ability.Infiltrator,
        },
    };
    public static SpeciesData Golbat = new()
    {
        speciesName = "Golbat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "golbat", //Verify
        graphicsLocation = "golbat", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.InnerFocus,
                Ability.InnerFocus,
                Ability.Infiltrator,
        },
    };
    public static SpeciesData Oddish = new()
    {
        speciesName = "Oddish",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 55,
        baseSpAtk = 75,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = SpAtk,
        evolution = Evolution.Oddish,
        xpClass = XPClass.MediumSlow,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "oddish", //Verify
        graphicsLocation = "oddish", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.RunAway,
        },
    };
    public static SpeciesData Gloom = new()
    {
        speciesName = "Gloom",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = 2 * SpAtk,
        evolution = Evolution.Gloom,
        xpClass = XPClass.MediumSlow,
        xpYield = 138,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "gloom", //Verify
        graphicsLocation = "gloom", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Stench,
        },
    };
    public static SpeciesData Vileplume = new()
    {
        speciesName = "Vileplume",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 85,
        baseSpAtk = 100,
        baseSpDef = 90,
        baseSpeed = 50,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 221,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "vileplume", //Verify
        graphicsLocation = "vileplume", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.EffectSpore,
        },
    };
    public static SpeciesData Paras = new()
    {
        speciesName = "Paras",
        type1 = Type.Bug,
        type2 = Type.Grass,
        baseHP = 35,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 25,
        evYield = Attack,
        evolution = Evolution.Paras,
        xpClass = XPClass.MediumFast,
        xpYield = 57,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "paras", //Verify
        graphicsLocation = "paras", //Verify
        backSpriteHeight = 18,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.EffectSpore,
                Ability.DrySkin,
                Ability.Damp,
        },
    };
    public static SpeciesData Parasect = new()
    {
        speciesName = "Parasect",
        type1 = Type.Bug,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Attack + Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "parasect", //Verify
        graphicsLocation = "parasect", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.EffectSpore,
                Ability.DrySkin,
                Ability.Damp,
        },
    };
    public static SpeciesData Venonat = new()
    {
        speciesName = "Venonat",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Venonat,
        xpClass = XPClass.MediumFast,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "venonat", //Verify
        graphicsLocation = "venonat", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.CompoundEyes,
                Ability.TintedLens,
                Ability.RunAway,
        },
    };
    public static SpeciesData Venomoth = new()
    {
        speciesName = "Venomoth",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "venomoth", //Verify
        graphicsLocation = "venomoth", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ShieldDust,
                Ability.TintedLens,
                Ability.WonderSkin,
        },
    };
    public static SpeciesData Diglett = new()
    {
        speciesName = "Diglett",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 10,
        baseAttack = 55,
        baseDefense = 25,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.Diglett,
        xpClass = XPClass.MediumFast,
        xpYield = 53,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "diglett", //Verify
        graphicsLocation = "diglett", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SandVeil,
                Ability.ArenaTrap,
                Ability.SandForce,
        },
    };
    public static SpeciesData Dugtrio = new()
    {
        speciesName = "Dugtrio",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 35,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 120,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 149,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 50,
        baseFriendship = 70,
        cryLocation = "dugtrio", //Verify
        graphicsLocation = "dugtrio", //Verify
        backSpriteHeight = 17,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SandVeil,
                Ability.ArenaTrap,
                Ability.SandForce,
        },
    };
    public static SpeciesData Meowth = new()
    {
        speciesName = "Meowth",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Meowth,
        xpClass = XPClass.MediumFast,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "meowth", //Verify
        graphicsLocation = "meowth", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Pickup,
                Ability.Technician,
                Ability.Unnerve,
        },
    };
    public static SpeciesData Persian = new()
    {
        speciesName = "Persian",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 65,
        baseAttack = 70,
        baseDefense = 60,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 154,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "persian", //Verify
        graphicsLocation = "persian", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Limber,
                Ability.Technician,
                Ability.Unnerve,
        },
    };
    public static SpeciesData Psyduck = new()
    {
        speciesName = "Psyduck",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 50,
        baseAttack = 52,
        baseDefense = 48,
        baseSpAtk = 65,
        baseSpDef = 50,
        baseSpeed = 55,
        evYield = SpAtk,
        evolution = Evolution.Psyduck,
        xpClass = XPClass.MediumFast,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "psyduck", //Verify
        graphicsLocation = "psyduck", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Damp,
                Ability.CloudNine,
                Ability.SwiftSwim,
        },
    };
    public static SpeciesData Golduck = new()
    {
        speciesName = "Golduck",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 78,
        baseSpAtk = 95,
        baseSpDef = 80,
        baseSpeed = 85,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "golduck", //Verify
        graphicsLocation = "golduck", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Damp,
                Ability.CloudNine,
                Ability.SwiftSwim,
        },
    };
    public static SpeciesData Mankey = new()
    {
        speciesName = "Mankey",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = Attack,
        evolution = Evolution.Mankey,
        xpClass = XPClass.MediumFast,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "mankey", //Verify
        graphicsLocation = "mankey", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.VitalSpirit,
                Ability.AngerPoint,
                Ability.Defiant,
        },
    };
    public static SpeciesData Primeape = new()
    {
        speciesName = "Primeape",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 65,
        baseAttack = 105,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "primeape", //Verify
        graphicsLocation = "primeape", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.VitalSpirit,
                Ability.AngerPoint,
                Ability.Defiant,
        },
    };
    public static SpeciesData Growlithe = new()
    {
        speciesName = "Growlithe",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 50,
        baseSpeed = 60,
        evYield = Attack,
        evolution = Evolution.Growlithe,
        xpClass = XPClass.Slow,
        xpYield = 70,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "growlithe", //Verify
        graphicsLocation = "growlithe", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Intimidate,
                Ability.FlashFire,
                Ability.Justified,
        },
    };
    public static SpeciesData Arcanine = new()
    {
        speciesName = "Arcanine",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 90,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 194,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "arcanine", //Verify
        graphicsLocation = "arcanine", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Intimidate,
                Ability.FlashFire,
                Ability.Justified,
        },
    };
    public static SpeciesData Poliwag = new()
    {
        speciesName = "Poliwag",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Poliwag,
        xpClass = XPClass.MediumSlow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "poliwag", //Verify
        graphicsLocation = "poliwag", //Verify
        backSpriteHeight = 18,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.WaterAbsorb,
                Ability.Damp,
                Ability.SwiftSwim,
        },
    };
    public static SpeciesData Poliwhirl = new()
    {
        speciesName = "Poliwhirl",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Poliwhirl,
        xpClass = XPClass.MediumSlow,
        xpYield = 135,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "poliwhirl", //Verify
        graphicsLocation = "poliwhirl", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.WaterAbsorb,
                Ability.Damp,
                Ability.SwiftSwim,
        },
    };
    public static SpeciesData Poliwrath = new()
    {
        speciesName = "Poliwrath",
        type1 = Type.Water,
        type2 = Type.Fighting,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 70,
        baseSpDef = 90,
        baseSpeed = 70,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 230,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "poliwrath", //Verify
        graphicsLocation = "poliwrath", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.WaterAbsorb,
                Ability.Damp,
                Ability.SwiftSwim,
        },
    };
    public static SpeciesData Abra = new()
    {
        speciesName = "Abra",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 25,
        baseAttack = 20,
        baseDefense = 15,
        baseSpAtk = 105,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = SpAtk,
        evolution = Evolution.Abra,
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "abra", //Verify
        graphicsLocation = "abra", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Synchronize,
                Ability.InnerFocus,
                Ability.MagicGuard,
        },
    };
    public static SpeciesData Kadabra = new()
    {
        speciesName = "Kadabra",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 105,
        evYield = 2 * SpAtk,
        evolution = Evolution.Kadabra,
        xpClass = XPClass.MediumSlow,
        xpYield = 140,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 100,
        baseFriendship = 70,
        cryLocation = "kadabra", //Verify
        graphicsLocation = "kadabra", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Synchronize,
                Ability.InnerFocus,
                Ability.MagicGuard,
        },
    };
    public static SpeciesData Alakazam = new()
    {
        speciesName = "Alakazam",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 55,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 135,
        baseSpDef = 85,
        baseSpeed = 120,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 225,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 50,
        baseFriendship = 70,
        cryLocation = "alakazam", //Verify
        graphicsLocation = "alakazam", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Synchronize,
                Ability.InnerFocus,
                Ability.MagicGuard,
        },
    };
    public static SpeciesData Machop = new()
    {
        speciesName = "Machop",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Machop,
        xpClass = XPClass.MediumSlow,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 180,
        baseFriendship = 70,
        cryLocation = "machop", //Verify
        graphicsLocation = "machop", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Guts,
                Ability.NoGuard,
                Ability.Steadfast,
        },
    };
    public static SpeciesData Machoke = new()
    {
        speciesName = "Machoke",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.Machoke,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "machoke", //Verify
        graphicsLocation = "machoke", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Guts,
                Ability.NoGuard,
                Ability.Steadfast,
        },
    };
    public static SpeciesData Machamp = new()
    {
        speciesName = "Machamp",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 85,
        baseSpeed = 55,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 227,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "machamp", //Verify
        graphicsLocation = "machamp", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Guts,
                Ability.NoGuard,
                Ability.Steadfast,
        },
    };
    public static SpeciesData Bellsprout = new()
    {
        speciesName = "Bellsprout",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Bellsprout,
        xpClass = XPClass.MediumSlow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "bellsprout", //Verify
        graphicsLocation = "bellsprout", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Gluttony,
        },
    };
    public static SpeciesData Weepinbell = new()
    {
        speciesName = "Weepinbell",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.Weepinbell,
        xpClass = XPClass.MediumSlow,
        xpYield = 137,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "weepinbell", //Verify
        graphicsLocation = "weepinbell", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Gluttony,
        },
    };
    public static SpeciesData Victreebel = new()
    {
        speciesName = "Victreebel",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 221,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "victreebel", //Verify
        graphicsLocation = "victreebel", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Gluttony,
        },
    };
    public static SpeciesData Tentacool = new()
    {
        speciesName = "Tentacool",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 35,
        baseSpAtk = 50,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = SpDef,
        evolution = Evolution.Tentacool,
        xpClass = XPClass.Slow,
        xpYield = 67,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "tentacool", //Verify
        graphicsLocation = "tentacool", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ClearBody,
                Ability.LiquidOoze,
                Ability.RainDish,
        },
    };
    public static SpeciesData Tentacruel = new()
    {
        speciesName = "Tentacruel",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 70,
        baseDefense = 65,
        baseSpAtk = 80,
        baseSpDef = 120,
        baseSpeed = 100,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 180,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "tentacruel", //Verify
        graphicsLocation = "tentacruel", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ClearBody,
                Ability.LiquidOoze,
                Ability.RainDish,
        },
    };
    public static SpeciesData Geodude = new()
    {
        speciesName = "Geodude",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 100,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 20,
        evYield = Defense,
        evolution = Evolution.Geodude,
        xpClass = XPClass.MediumSlow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "geodude", //Verify
        graphicsLocation = "geodude", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.Sturdy,
                Ability.SandVeil,
        },
    };
    public static SpeciesData Graveler = new()
    {
        speciesName = "Graveler",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 115,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = 2 * Defense,
        evolution = Evolution.Graveler,
        xpClass = XPClass.MediumSlow,
        xpYield = 137,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "graveler", //Verify
        graphicsLocation = "graveler", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.Sturdy,
                Ability.SandVeil,
        },
    };
    public static SpeciesData Golem = new()
    {
        speciesName = "Golem",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 80,
        baseAttack = 110,
        baseDefense = 130,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 223,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "golem", //Verify
        graphicsLocation = "golem", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.Sturdy,
                Ability.SandVeil,
        },
    };
    public static SpeciesData Ponyta = new()
    {
        speciesName = "Ponyta",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 55,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Ponyta,
        xpClass = XPClass.MediumFast,
        xpYield = 82,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "ponyta", //Verify
        graphicsLocation = "ponyta", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RunAway,
                Ability.FlashFire,
                Ability.FlameBody,
        },
    };
    public static SpeciesData Rapidash = new()
    {
        speciesName = "Rapidash",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "rapidash", //Verify
        graphicsLocation = "rapidash", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RunAway,
                Ability.FlashFire,
                Ability.FlameBody,
        },
    };
    public static SpeciesData Slowpoke = new()
    {
        speciesName = "Slowpoke",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 90,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Slowpoke,
        xpClass = XPClass.MediumFast,
        xpYield = 63,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "slowpoke", //Verify
        graphicsLocation = "slowpoke", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Oblivious,
                Ability.OwnTempo,
                Ability.Regenerator,
        },
    };
    public static SpeciesData Slowbro = new()
    {
        speciesName = "Slowbro",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 110,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "slowbro", //Verify
        graphicsLocation = "slowbro", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Oblivious,
                Ability.OwnTempo,
                Ability.Regenerator,
        },
    };
    public static SpeciesData Magnemite = new()
    {
        speciesName = "Magnemite",
        type1 = Type.Electric,
        type2 = Type.Steel,
        baseHP = 25,
        baseAttack = 35,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Magnemite,
        xpClass = XPClass.MediumFast,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "magnemite", //Verify
        graphicsLocation = "magnemite", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.MagnetPull,
                Ability.Sturdy,
                Ability.Analytic,
        },
    };
    public static SpeciesData Magneton = new()
    {
        speciesName = "Magneton",
        type1 = Type.Electric,
        type2 = Type.Steel,
        baseHP = 50,
        baseAttack = 60,
        baseDefense = 95,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "magneton", //Verify
        graphicsLocation = "magneton", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.MagnetPull,
                Ability.Sturdy,
                Ability.Analytic,
        },
    };
    public static SpeciesData Farfetchd = new()
    {
        speciesName = "Farfetchd",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 52,
        baseAttack = 65,
        baseDefense = 55,
        baseSpAtk = 58,
        baseSpDef = 62,
        baseSpeed = 60,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 132,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "farfetchd", //Verify
        graphicsLocation = "farfetchd", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.KeenEye,
                Ability.InnerFocus,
                Ability.Defiant,
        },
    };
    public static SpeciesData Doduo = new()
    {
        speciesName = "Doduo",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 35,
        baseAttack = 85,
        baseDefense = 45,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 75,
        evYield = Attack,
        evolution = Evolution.Doduo,
        xpClass = XPClass.MediumFast,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "doduo", //Verify
        graphicsLocation = "doduo", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RunAway,
                Ability.EarlyBird,
                Ability.TangledFeet,
        },
    };
    public static SpeciesData Dodrio = new()
    {
        speciesName = "Dodrio",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 110,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 100,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 165,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "dodrio", //Verify
        graphicsLocation = "dodrio", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RunAway,
                Ability.EarlyBird,
                Ability.TangledFeet,
        },
    };
    public static SpeciesData Seel = new()
    {
        speciesName = "Seel",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 70,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Seel,
        xpClass = XPClass.MediumFast,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "seel", //Verify
        graphicsLocation = "seel", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ThickFat,
                Ability.Hydration,
                Ability.IceBody,
        },
    };
    public static SpeciesData Dewgong = new()
    {
        speciesName = "Dewgong",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 90,
        baseAttack = 70,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 95,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 166,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "dewgong", //Verify
        graphicsLocation = "dewgong", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ThickFat,
                Ability.Hydration,
                Ability.IceBody,
        },
    };
    public static SpeciesData Grimer = new()
    {
        speciesName = "Grimer",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.Grimer,
        xpClass = XPClass.MediumFast,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "grimer", //Verify
        graphicsLocation = "grimer", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Stench,
                Ability.StickyHold,
                Ability.PoisonTouch,
        },
    };
    public static SpeciesData Muk = new()
    {
        speciesName = "Muk",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 105,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 65,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = HP + Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "muk", //Verify
        graphicsLocation = "muk", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Stench,
                Ability.StickyHold,
                Ability.PoisonTouch,
        },
    };
    public static SpeciesData Shellder = new()
    {
        speciesName = "Shellder",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 65,
        baseDefense = 100,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Shellder,
        xpClass = XPClass.Slow,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "shellder", //Verify
        graphicsLocation = "shellder", //Verify
        backSpriteHeight = 21,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ShellArmor,
                Ability.SkillLink,
                Ability.Overcoat,
        },
    };
    public static SpeciesData Cloyster = new()
    {
        speciesName = "Cloyster",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 180,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "cloyster", //Verify
        graphicsLocation = "cloyster", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ShellArmor,
                Ability.SkillLink,
                Ability.Overcoat,
        },
    };
    public static SpeciesData Gastly = new()
    {
        speciesName = "Gastly",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 30,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 100,
        baseSpDef = 35,
        baseSpeed = 80,
        evYield = SpAtk,
        evolution = Evolution.Gastly,
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "gastly", //Verify
        graphicsLocation = "gastly", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Levitate,
                Ability.Levitate,
                Ability.Levitate,
        },
    };
    public static SpeciesData Haunter = new()
    {
        speciesName = "Haunter",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 115,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.Haunter,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "haunter", //Verify
        graphicsLocation = "haunter", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Levitate,
                Ability.Levitate,
                Ability.Levitate,
        },
    };
    public static SpeciesData Gengar = new()
    {
        speciesName = "Gengar",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 75,
        baseSpeed = 110,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 225,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "gengar", //Verify
        graphicsLocation = "gengar", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Levitate,
                Ability.Levitate,
                Ability.Levitate,
        },
    };
    public static SpeciesData Onix = new()
    {
        speciesName = "Onix",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 35,
        baseAttack = 45,
        baseDefense = 160,
        baseSpAtk = 30,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = Defense,
        evolution = Evolution.Onix,
        xpClass = XPClass.MediumFast,
        xpYield = 77,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "onix", //Verify
        graphicsLocation = "onix", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.Sturdy,
                Ability.WeakArmor,
        },
    };
    public static SpeciesData Drowzee = new()
    {
        speciesName = "Drowzee",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 48,
        baseDefense = 45,
        baseSpAtk = 43,
        baseSpDef = 90,
        baseSpeed = 42,
        evYield = SpDef,
        evolution = Evolution.Drowzee,
        xpClass = XPClass.MediumFast,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "drowzee", //Verify
        graphicsLocation = "drowzee", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.Forewarn,
            Ability.InnerFocus,
        },
    };
    public static SpeciesData Hypno = new()
    {
        speciesName = "Hypno",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 85,
        baseAttack = 73,
        baseDefense = 70,
        baseSpAtk = 73,
        baseSpDef = 115,
        baseSpeed = 67,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 169,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "hypno", //Verify
        graphicsLocation = "hypno", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Insomnia,
                Ability.Forewarn,
                Ability.InnerFocus,
        },
    };
    public static SpeciesData Krabby = new()
    {
        speciesName = "Krabby",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 105,
        baseDefense = 90,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Krabby,
        xpClass = XPClass.MediumFast,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "krabby", //Verify
        graphicsLocation = "krabby", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.HyperCutter,
                Ability.ShellArmor,
                Ability.SheerForce,
        },
    };
    public static SpeciesData Kingler = new()
    {
        speciesName = "Kingler",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 130,
        baseDefense = 115,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 166,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "kingler", //Verify
        graphicsLocation = "kingler", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.HyperCutter,
                Ability.ShellArmor,
                Ability.SheerForce,
        },
    };
    public static SpeciesData Voltorb = new()
    {
        speciesName = "Voltorb",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 100,
        evYield = Speed,
        evolution = Evolution.Voltorb,
        xpClass = XPClass.MediumFast,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "voltorb", //Verify
        graphicsLocation = "voltorb", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Soundproof,
                Ability.Static,
                Ability.Aftermath,
        },
    };
    public static SpeciesData Electrode = new()
    {
        speciesName = "Electrode",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 140,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "electrode", //Verify
        graphicsLocation = "electrode", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Soundproof,
                Ability.Static,
                Ability.Aftermath,
        },
    };
    public static SpeciesData Exeggcute = new()
    {
        speciesName = "Exeggcute",
        type1 = Type.Grass,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Exeggcute,
        xpClass = XPClass.Slow,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "exeggcute", //Verify
        graphicsLocation = "exeggcute", //Verify
        backSpriteHeight = 18,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Harvest,
        },
    };
    public static SpeciesData Exeggutor = new()
    {
        speciesName = "Exeggutor",
        type1 = Type.Grass,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 186,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "exeggutor", //Verify
        graphicsLocation = "exeggutor", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.Chlorophyll,
                Ability.Harvest,
        },
    };
    public static SpeciesData Cubone = new()
    {
        speciesName = "Cubone",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Cubone,
        xpClass = XPClass.MediumFast,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "cubone", //Verify
        graphicsLocation = "cubone", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.LightningRod,
                Ability.BattleArmor,
        },
    };
    public static SpeciesData Marowak = new()
    {
        speciesName = "Marowak",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 110,
        baseSpAtk = 50,
        baseSpDef = 80,
        baseSpeed = 45,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 149,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "marowak", //Verify
        graphicsLocation = "marowak", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.LightningRod,
                Ability.BattleArmor,
        },
    };
    public static SpeciesData Hitmonlee = new()
    {
        speciesName = "Hitmonlee",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 120,
        baseDefense = 53,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 87,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "hitmonlee", //Verify
        graphicsLocation = "hitmonlee", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Limber,
                Ability.Reckless,
                Ability.Unburden,
        },
    };
    public static SpeciesData Hitmonchan = new()
    {
        speciesName = "Hitmonchan",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 105,
        baseDefense = 79,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 76,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "hitmonchan", //Verify
        graphicsLocation = "hitmonchan", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.KeenEye,
                Ability.IronFist,
                Ability.InnerFocus,
        },
    };
    public static SpeciesData Lickitung = new()
    {
        speciesName = "Lickitung",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 55,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 30,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 77,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "lickitung", //Verify
        graphicsLocation = "lickitung", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.OwnTempo,
                Ability.Oblivious,
                Ability.CloudNine,
        },
    };
    public static SpeciesData Koffing = new()
    {
        speciesName = "Koffing",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Koffing,
        xpClass = XPClass.MediumFast,
        xpYield = 68,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "koffing", //Verify
        graphicsLocation = "koffing", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Levitate,
                Ability.NeutralizingGas,
                Ability.Stench,
        },
    };
    public static SpeciesData Weezing = new()
    {
        speciesName = "Weezing",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 120,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 60,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "weezing", //Verify
        graphicsLocation = "weezing", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Levitate,
                Ability.NeutralizingGas,
                Ability.Stench,
        },
    };
    public static SpeciesData Rhyhorn = new()
    {
        speciesName = "Rhyhorn",
        type1 = Type.Ground,
        type2 = Type.Rock,
        baseHP = 80,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 25,
        evYield = Defense,
        evolution = Evolution.Rhyhorn,
        xpClass = XPClass.Slow,
        xpYield = 69,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "rhyhorn", //Verify
        graphicsLocation = "rhyhorn", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.LightningRod,
                Ability.RockHead,
                Ability.Reckless,
        },
    };
    public static SpeciesData Rhydon = new()
    {
        speciesName = "Rhydon",
        type1 = Type.Ground,
        type2 = Type.Rock,
        baseHP = 105,
        baseAttack = 130,
        baseDefense = 120,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 170,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "rhydon", //Verify
        graphicsLocation = "rhydon", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.LightningRod,
                Ability.RockHead,
                Ability.Reckless,
        },
    };
    public static SpeciesData Chansey = new()
    {
        speciesName = "Chansey",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 250,
        baseAttack = 5,
        baseDefense = 5,
        baseSpAtk = 35,
        baseSpDef = 105,
        baseSpeed = 50,
        evYield = 2 * HP,
        evolution = Evolution.Chansey,
        xpClass = XPClass.Fast,
        xpYield = 395,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 40,
        catchRate = 30,
        baseFriendship = 140,
        cryLocation = "chansey", //Verify
        graphicsLocation = "chansey", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.NaturalCure,
                Ability.SereneGrace,
                Ability.Healer,
        },
    };
    public static SpeciesData Tangela = new()
    {
        speciesName = "Tangela",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 65,
        baseAttack = 55,
        baseDefense = 115,
        baseSpAtk = 100,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 87,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "tangela", //Verify
        graphicsLocation = "tangela", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Chlorophyll,
                Ability.LeafGuard,
                Ability.Regenerator,
        },
    };
    public static SpeciesData Kangaskhan = new()
    {
        speciesName = "Kangaskhan",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 105,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 90,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "kangaskhan", //Verify
        graphicsLocation = "kangaskhan", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.EarlyBird,
                Ability.Scrappy,
                Ability.InnerFocus,
        },
    };
    public static SpeciesData Horsea = new()
    {
        speciesName = "Horsea",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 70,
        baseSpDef = 25,
        baseSpeed = 60,
        evYield = SpAtk,
        evolution = Evolution.Horsea,
        xpClass = XPClass.MediumFast,
        xpYield = 59,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "horsea", //Verify
        graphicsLocation = "horsea", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.Sniper,
                Ability.Damp,
        },
    };
    public static SpeciesData Seadra = new()
    {
        speciesName = "Seadra",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 45,
        baseSpeed = 85,
        evYield = Defense + SpAtk,
        evolution = Evolution.Seadra,
        xpClass = XPClass.MediumFast,
        xpYield = 154,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "seadra", //Verify
        graphicsLocation = "seadra", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.PoisonPoint,
                Ability.Sniper,
                Ability.Damp,
        },
    };
    public static SpeciesData Goldeen = new()
    {
        speciesName = "Goldeen",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 45,
        baseAttack = 67,
        baseDefense = 60,
        baseSpAtk = 35,
        baseSpDef = 50,
        baseSpeed = 63,
        evYield = Attack,
        evolution = Evolution.Goldeen,
        xpClass = XPClass.MediumFast,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "goldeen", //Verify
        graphicsLocation = "goldeen", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.WaterVeil,
                Ability.LightningRod,
        },
    };
    public static SpeciesData Seaking = new()
    {
        speciesName = "Seaking",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 80,
        baseAttack = 92,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 68,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "seaking", //Verify
        graphicsLocation = "seaking", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.WaterVeil,
                Ability.LightningRod,
        },
    };
    public static SpeciesData Staryu = new()
    {
        speciesName = "Staryu",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Staryu,
        xpClass = XPClass.Slow,
        xpYield = 68,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "staryu", //Verify
        graphicsLocation = "staryu", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Illuminate,
                Ability.NaturalCure,
                Ability.Analytic,
        },
    };
    public static SpeciesData Starmie = new()
    {
        speciesName = "Starmie",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 182,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "starmie", //Verify
        graphicsLocation = "starmie", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Illuminate,
                Ability.NaturalCure,
                Ability.Analytic,
        },
    };
    public static SpeciesData MrMime = new()
    {
        speciesName = "Mr. Mime",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 120,
        baseSpeed = 90,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "mr_mime", //Verify
        graphicsLocation = "mr_mime", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Soundproof,
                Ability.Filter,
                Ability.Technician,
        },
    };
    public static SpeciesData Scyther = new()
    {
        speciesName = "Scyther",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = Attack,
        evolution = Evolution.Scyther,
        xpClass = XPClass.MediumFast,
        xpYield = 100,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "scyther", //Verify
        graphicsLocation = "scyther", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Swarm,
                Ability.Technician,
                Ability.Steadfast,
        },
    };
    public static SpeciesData Jynx = new()
    {
        speciesName = "Jynx",
        type1 = Type.Ice,
        type2 = Type.Psychic,
        baseHP = 65,
        baseAttack = 50,
        baseDefense = 35,
        baseSpAtk = 115,
        baseSpDef = 95,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "jynx", //Verify
        graphicsLocation = "jynx", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Oblivious,
                Ability.Forewarn,
                Ability.DrySkin,
        },
    };
    public static SpeciesData Electabuzz = new()
    {
        speciesName = "Electabuzz",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 65,
        baseAttack = 83,
        baseDefense = 57,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "electabuzz", //Verify
        graphicsLocation = "electabuzz", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Static,
                Ability.Static,
                Ability.VitalSpirit,
        },
    };
    public static SpeciesData Magmar = new()
    {
        speciesName = "Magmar",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 57,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 93,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "magmar", //Verify
        graphicsLocation = "magmar", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.FlameBody,
                Ability.FlameBody,
                Ability.VitalSpirit,
        },
    };
    public static SpeciesData Pinsir = new()
    {
        speciesName = "Pinsir",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 65,
        baseAttack = 125,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 70,
        baseSpeed = 85,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "pinsir", //Verify
        graphicsLocation = "pinsir", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.HyperCutter,
                Ability.MoldBreaker,
                Ability.Moxie,
        },
    };
    public static SpeciesData Tauros = new()
    {
        speciesName = "Tauros",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 110,
        evYield = Attack + Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "tauros", //Verify
        graphicsLocation = "tauros", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Intimidate,
                Ability.AngerPoint,
                Ability.SheerForce,
        },
    };
    public static SpeciesData Magikarp = new()
    {
        speciesName = "Magikarp",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 55,
        baseSpAtk = 15,
        baseSpDef = 20,
        baseSpeed = 80,
        evYield = Speed,
        evolution = Evolution.Magikarp,
        xpClass = XPClass.Slow,
        xpYield = 40,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 5,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "magikarp", //Verify
        graphicsLocation = "magikarp", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.SwiftSwim,
                Ability.Rattled,
        },
    };
    public static SpeciesData Gyarados = new()
    {
        speciesName = "Gyarados",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 95,
        baseAttack = 125,
        baseDefense = 79,
        baseSpAtk = 60,
        baseSpDef = 100,
        baseSpeed = 81,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 189,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 5,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "gyarados", //Verify
        graphicsLocation = "gyarados", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Intimidate,
                Ability.Intimidate,
                Ability.Moxie,
        },
    };
    public static SpeciesData Lapras = new()
    {
        speciesName = "Lapras",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 130,
        baseAttack = 85,
        baseDefense = 80,
        baseSpAtk = 85,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 187,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "lapras", //Verify
        graphicsLocation = "lapras", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.WaterAbsorb,
                Ability.ShellArmor,
                Ability.Hydration,
        },
    };
    public static SpeciesData Ditto = new()
    {
        speciesName = "Ditto",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 48,
        baseAttack = 48,
        baseDefense = 48,
        baseSpAtk = 48,
        baseSpDef = 48,
        baseSpeed = 48,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 101,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Ditto,
        eggGroup2 = EggGroup.Ditto,
        eggCycles = 20,
        catchRate = 35,
        baseFriendship = 70,
        cryLocation = "ditto", //Verify
        graphicsLocation = "ditto", //Verify
        backSpriteHeight = 17,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Limber,
                Ability.Limber,
                Ability.Imposter,
        },
    };
    public static SpeciesData Eevee = new()
    {
        speciesName = "Eevee",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.Eevee,
        xpClass = XPClass.MediumFast,
        xpYield = 65,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "eevee", //Verify
        graphicsLocation = "eevee", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RunAway,
                Ability.Adaptability,
                Ability.Anticipation,
        },
    };
    public static SpeciesData Vaporeon = new()
    {
        speciesName = "Vaporeon",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 130,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 65,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "vaporeon", //Verify
        graphicsLocation = "vaporeon", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.WaterAbsorb,
                Ability.WaterAbsorb,
                Ability.Hydration,
        },
    };
    public static SpeciesData Jolteon = new()
    {
        speciesName = "Jolteon",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 130,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "jolteon", //Verify
        graphicsLocation = "jolteon", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.VoltAbsorb,
                Ability.VoltAbsorb,
                Ability.QuickFeet,
        },
    };
    public static SpeciesData Flareon = new()
    {
        speciesName = "Flareon",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 130,
        baseDefense = 60,
        baseSpAtk = 95,
        baseSpDef = 110,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "flareon", //Verify
        graphicsLocation = "flareon", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.FlashFire,
                Ability.FlashFire,
                Ability.Guts,
        },
    };
    public static SpeciesData Porygon = new()
    {
        speciesName = "Porygon",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 65,
        baseAttack = 60,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 79,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "porygon", //Verify
        graphicsLocation = "porygon", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Trace,
                Ability.Download,
                Ability.Analytic,
        },
    };
    public static SpeciesData Omanyte = new()
    {
        speciesName = "Omanyte",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 35,
        baseAttack = 40,
        baseDefense = 100,
        baseSpAtk = 90,
        baseSpDef = 55,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Omanyte,
        xpClass = XPClass.MediumFast,
        xpYield = 71,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "omanyte", //Verify
        graphicsLocation = "omanyte", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.ShellArmor,
                Ability.WeakArmor,
        },
    };
    public static SpeciesData Omastar = new()
    {
        speciesName = "Omastar",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 70,
        baseAttack = 60,
        baseDefense = 125,
        baseSpAtk = 115,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "omastar", //Verify
        graphicsLocation = "omastar", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.ShellArmor,
                Ability.WeakArmor,
        },
    };
    public static SpeciesData Kabuto = new()
    {
        speciesName = "Kabuto",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 55,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = Defense,
        evolution = Evolution.Kabuto,
        xpClass = XPClass.MediumFast,
        xpYield = 71,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "kabuto", //Verify
        graphicsLocation = "kabuto", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.BattleArmor,
                Ability.WeakArmor,
        },
    };
    public static SpeciesData Kabutops = new()
    {
        speciesName = "Kabutops",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 60,
        baseAttack = 115,
        baseDefense = 105,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 80,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "kabutops", //Verify
        graphicsLocation = "kabutops", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.SwiftSwim,
                Ability.BattleArmor,
                Ability.WeakArmor,
        },
    };
    public static SpeciesData Aerodactyl = new()
    {
        speciesName = "Aerodactyl",
        type1 = Type.Rock,
        type2 = Type.Flying,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 130,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 180,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "aerodactyl", //Verify
        graphicsLocation = "aerodactyl", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.RockHead,
                Ability.Pressure,
                Ability.Unnerve,
        },
    };
    public static SpeciesData Snorlax = new()
    {
        speciesName = "Snorlax",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 160,
        baseAttack = 110,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 189,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 40,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "snorlax", //Verify
        graphicsLocation = "snorlax", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Immunity,
                Ability.ThickFat,
                Ability.Gluttony,
        },
    };
    public static SpeciesData Articuno = new()
    {
        speciesName = "Articuno",
        type1 = Type.Ice,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 125,
        baseSpeed = 85,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "articuno", //Verify
        graphicsLocation = "articuno", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Pressure,
                Ability.Pressure,
                Ability.SnowCloak,
        },
    };
    public static SpeciesData Zapdos = new()
    {
        speciesName = "Zapdos",
        type1 = Type.Electric,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 90,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 90,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "zapdos", //Verify
        graphicsLocation = "zapdos", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Pressure,
                Ability.Pressure,
                Ability.LightningRod,
        },
    };
    public static SpeciesData Moltres = new()
    {
        speciesName = "Moltres",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 100,
        baseDefense = 90,
        baseSpAtk = 125,
        baseSpDef = 85,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "moltres", //Verify
        graphicsLocation = "moltres", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Pressure,
                Ability.Pressure,
                Ability.FlameBody,
        },
    };
    public static SpeciesData Dratini = new()
    {
        speciesName = "Dratini",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 41,
        baseAttack = 64,
        baseDefense = 45,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Dratini,
        xpClass = XPClass.Slow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "dratini", //Verify
        graphicsLocation = "dratini", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ShedSkin,
                Ability.ShedSkin,
                Ability.MarvelScale,
        },
    };
    public static SpeciesData Dragonair = new()
    {
        speciesName = "Dragonair",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 61,
        baseAttack = 84,
        baseDefense = 65,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.Dragonair,
        xpClass = XPClass.Slow,
        xpYield = 147,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "dragonair", //Verify
        graphicsLocation = "dragonair", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.ShedSkin,
                Ability.ShedSkin,
                Ability.MarvelScale,
        },
    };
    public static SpeciesData Dragonite = new()
    {
        speciesName = "Dragonite",
        type1 = Type.Dragon,
        type2 = Type.Flying,
        baseHP = 91,
        baseAttack = 134,
        baseDefense = 95,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "dragonite", //Verify
        graphicsLocation = "dragonite", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.InnerFocus,
                Ability.InnerFocus,
                Ability.Multiscale,
        },
    };
    public static SpeciesData Mewtwo = new()
    {
        speciesName = "Mewtwo",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 106,
        baseAttack = 110,
        baseDefense = 90,
        baseSpAtk = 154,
        baseSpDef = 90,
        baseSpeed = 130,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 306,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "mewtwo", //Verify
        graphicsLocation = "mewtwo", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Pressure,
                Ability.Pressure,
                Ability.Unnerve,
        },
    };
    public static SpeciesData Mew = new()
    {
        speciesName = "Mew",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 45,
        baseFriendship = 100,
        cryLocation = "mew", //Verify
        graphicsLocation = "mew", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
                Ability.Synchronize,
                Ability.Synchronize,
                Ability.Synchronize,
        },
    };
    public static SpeciesData Chikorita = new()
    {
        speciesName = "Chikorita",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 65,
        baseSpAtk = 49,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Chikorita,
        xpClass = XPClass.MediumSlow,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "chikorita", //Verify
        graphicsLocation = "chikorita", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
    {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.LeafGuard,
    },
    };
    public static SpeciesData Bayleef = new()
    {
        speciesName = "Bayleef",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 80,
        baseSpAtk = 63,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = Defense + SpDef,
        evolution = Evolution.Bayleef,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "bayleef", //Verify
        graphicsLocation = "bayleef", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.LeafGuard,
        },
    };
    public static SpeciesData Meganium = new()
    {
        speciesName = "Meganium",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 100,
        baseSpAtk = 83,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 236,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "meganium", //Verify
        graphicsLocation = "meganium", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.LeafGuard,
        },
    };
    public static SpeciesData Cyndaquil = new()
    {
        speciesName = "Cyndaquil",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Cyndaquil,
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "cyndaquil", //Verify
        graphicsLocation = "cyndaquil", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.FlashFire,
        },
    };
    public static SpeciesData Quilava = new()
    {
        speciesName = "Quilava",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = Speed + SpAtk,
        evolution = Evolution.Quilava,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "quilava", //Verify
        graphicsLocation = "quilava", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.FlashFire,
        },
    };
    public static SpeciesData Typhlosion = new()
    {
        speciesName = "Typhlosion",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 240,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "typhlosion", //Verify
        graphicsLocation = "typhlosion", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.FlashFire,
        },
    };
    public static SpeciesData Totodile = new()
    {
        speciesName = "Totodile",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 64,
        baseSpAtk = 44,
        baseSpDef = 48,
        baseSpeed = 43,
        evYield = Attack,
        evolution = Evolution.Totodile,
        xpClass = XPClass.MediumSlow,
        xpYield = 63,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "totodile", //Verify
        graphicsLocation = "totodile", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Croconaw = new()
    {
        speciesName = "Croconaw",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 59,
        baseSpDef = 63,
        baseSpeed = 58,
        evYield = Attack + Defense,
        evolution = Evolution.Croconaw,
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "croconaw", //Verify
        graphicsLocation = "croconaw", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Feraligatr = new()
    {
        speciesName = "Feraligatr",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 85,
        baseAttack = 105,
        baseDefense = 100,
        baseSpAtk = 79,
        baseSpDef = 83,
        baseSpeed = 78,
        evYield = 2 * Attack + Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "feraligatr", //Verify
        graphicsLocation = "feraligatr", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Sentret = new()
    {
        speciesName = "Sentret",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 35,
        baseAttack = 46,
        baseDefense = 34,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 20,
        evYield = Attack,
        evolution = Evolution.Sentret,
        xpClass = XPClass.MediumFast,
        xpYield = 43,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "sentret", //Verify
        graphicsLocation = "sentret", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.KeenEye,
            Ability.Frisk,
        },
    };
    public static SpeciesData Furret = new()
    {
        speciesName = "Furret",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 85,
        baseAttack = 76,
        baseDefense = 64,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 145,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "furret", //Verify
        graphicsLocation = "furret", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.KeenEye,
            Ability.Frisk,
        },
    };
    public static SpeciesData Hoothoot = new()
    {
        speciesName = "Hoothoot",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 36,
        baseSpDef = 56,
        baseSpeed = 50,
        evYield = HP,
        evolution = Evolution.Hoothoot,
        xpClass = XPClass.MediumFast,
        xpYield = 52,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "hoothoot", //Verify
        graphicsLocation = "hoothoot", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.KeenEye,
            Ability.TintedLens,
        },
    };
    public static SpeciesData Noctowl = new()
    {
        speciesName = "Noctowl",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 76,
        baseSpDef = 96,
        baseSpeed = 70,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "noctowl", //Verify
        graphicsLocation = "noctowl", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.KeenEye,
            Ability.TintedLens,
        },
    };
    public static SpeciesData Ledyba = new()
    {
        speciesName = "Ledyba",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 20,
        baseDefense = 30,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.Ledyba,
        xpClass = XPClass.Fast,
        xpYield = 53,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "ledyba", //Verify
        graphicsLocation = "ledyba", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.EarlyBird,
            Ability.Rattled,
        },
    };
    public static SpeciesData Ledian = new()
    {
        speciesName = "Ledian",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 35,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 110,
        baseSpeed = 85,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 137,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "ledian", //Verify
        graphicsLocation = "ledian", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.EarlyBird,
            Ability.IronFist,
        },
    };
    public static SpeciesData Spinarak = new()
    {
        speciesName = "Spinarak",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Attack,
        evolution = Evolution.Spinarak,
        xpClass = XPClass.Fast,
        xpYield = 50,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "spinarak", //Verify
        graphicsLocation = "spinarak", //Verify
        backSpriteHeight = 16,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Insomnia,
            Ability.Sniper,
        },
    };
    public static SpeciesData Ariados = new()
    {
        speciesName = "Ariados",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 140,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "ariados", //Verify
        graphicsLocation = "ariados", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Insomnia,
            Ability.Sniper,
        },
    };
    public static SpeciesData Crobat = new()
    {
        speciesName = "Crobat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 85,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 130,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 241,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "crobat", //Verify
        graphicsLocation = "crobat", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.InnerFocus,
            Ability.InnerFocus,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Chinchou = new()
    {
        speciesName = "Chinchou",
        type1 = Type.Water,
        type2 = Type.Electric,
        baseHP = 75,
        baseAttack = 38,
        baseDefense = 38,
        baseSpAtk = 56,
        baseSpDef = 56,
        baseSpeed = 67,
        evYield = HP,
        evolution = Evolution.Chinchou,
        xpClass = XPClass.Slow,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "chinchou", //Verify
        graphicsLocation = "chinchou", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.VoltAbsorb,
            Ability.Illuminate,
            Ability.WaterAbsorb,
        },
    };
    public static SpeciesData Lanturn = new()
    {
        speciesName = "Lanturn",
        type1 = Type.Water,
        type2 = Type.Electric,
        baseHP = 125,
        baseAttack = 58,
        baseDefense = 58,
        baseSpAtk = 76,
        baseSpDef = 76,
        baseSpeed = 67,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "lanturn", //Verify
        graphicsLocation = "lanturn", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.VoltAbsorb,
            Ability.Illuminate,
            Ability.WaterAbsorb,
        },
    };

    public static SpeciesData Pichu = new()
    {
        speciesName = "Pichu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 20,
        baseAttack = 40,
        baseDefense = 15,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.Pichu,
        xpClass = XPClass.MediumFast,
        xpYield = 41,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "pichu", //Verify
        graphicsLocation = "pichu", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.LightningRod,
        },
    };

    public static SpeciesData Cleffa = new()
    {
        speciesName = "Cleffa",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 50,
        baseAttack = 25,
        baseDefense = 28,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 15,
        evYield = SpDef,
        evolution = Evolution.Cleffa,
        xpClass = XPClass.Fast,
        xpYield = 44,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 150,
        baseFriendship = 140,
        cryLocation = "cleffa", //Verify
        graphicsLocation = "cleffa", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CuteCharm,
            Ability.MagicGuard,
            Ability.FriendGuard,
        },
    };
    public static SpeciesData Igglybuff = new()
    {
        speciesName = "Igglybuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 40,
        baseSpDef = 20,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Igglybuff,
        xpClass = XPClass.Fast,
        xpYield = 42,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 170,
        baseFriendship = 70,
        cryLocation = "igglybuff", //Verify
        graphicsLocation = "igglybuff", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CuteCharm,
            Ability.Competitive,
            Ability.FriendGuard,
        },
    };
    public static SpeciesData Togepi = new()
    {
        speciesName = "Togepi",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 35,
        baseAttack = 20,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 65,
        baseSpeed = 20,
        evYield = SpDef,
        evolution = Evolution.Togepi,
        xpClass = XPClass.Fast,
        xpYield = 49,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "togepi", //Verify
        graphicsLocation = "togepi", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Hustle,
            Ability.SereneGrace,
            Ability.SuperLuck,
        },
    };
    public static SpeciesData Togetic = new()
    {
        speciesName = "Togetic",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 85,
        baseSpAtk = 80,
        baseSpDef = 105,
        baseSpeed = 40,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "togetic", //Verify
        graphicsLocation = "togetic", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Hustle,
            Ability.SereneGrace,
            Ability.SuperLuck,
        },
    };
    public static SpeciesData Natu = new()
    {
        speciesName = "Natu",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = SpAtk,
        evolution = Evolution.Natu,
        xpClass = XPClass.MediumFast,
        xpYield = 64,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "natu", //Verify
        graphicsLocation = "natu", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.EarlyBird,
            Ability.MagicBounce,
        },
    };
    public static SpeciesData Xatu = new()
    {
        speciesName = "Xatu",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 165,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "xatu", //Verify
        graphicsLocation = "xatu", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.EarlyBird,
            Ability.MagicBounce,
        },
    };
    public static SpeciesData Mareep = new()
    {
        speciesName = "Mareep",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.Mareep,
        xpClass = XPClass.MediumSlow,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 70,
        cryLocation = "mareep", //Verify
        graphicsLocation = "mareep", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.Plus,
        },
    };
    public static SpeciesData Flaaffy = new()
    {
        speciesName = "Flaaffy",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 70,
        baseAttack = 55,
        baseDefense = 55,
        baseSpAtk = 80,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * SpAtk,
        evolution = Evolution.Flaaffy,
        xpClass = XPClass.MediumSlow,
        xpYield = 128,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "flaaffy", //Verify
        graphicsLocation = "flaaffy", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.Plus,
        },
    };
    public static SpeciesData Ampharos = new()
    {
        speciesName = "Ampharos",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 115,
        baseSpDef = 90,
        baseSpeed = 55,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 230,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "ampharos", //Verify
        graphicsLocation = "ampharos", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.Plus,
        },
    };
    public static SpeciesData Bellossom = new()
    {
        speciesName = "Bellossom",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 221,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "bellossom", //Verify
        graphicsLocation = "bellossom", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.Chlorophyll,
            Ability.Healer,
        },
    };
    public static SpeciesData Marill = new()
    {
        speciesName = "Marill",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 70,
        baseAttack = 20,
        baseDefense = 50,
        baseSpAtk = 20,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = 2 * HP,
        evolution = Evolution.Marill,
        xpClass = XPClass.Fast,
        xpYield = 88,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "marill", //Verify
        graphicsLocation = "marill", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.HugePower,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Azumarill = new()
    {
        speciesName = "Azumarill",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 80,
        baseSpAtk = 50,
        baseSpDef = 80,
        baseSpeed = 50,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 189,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "azumarill", //Verify
        graphicsLocation = "azumarill", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.HugePower,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Sudowoodo = new()
    {
        speciesName = "Sudowoodo",
        type1 = Type.Rock,
        type2 = Type.Rock,
        baseHP = 70,
        baseAttack = 100,
        baseDefense = 115,
        baseSpAtk = 30,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 144,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 65,
        baseFriendship = 70,
        cryLocation = "sudowoodo", //Verify
        graphicsLocation = "sudowoodo", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.RockHead,
            Ability.Rattled,
        },
    };
    public static SpeciesData Politoed = new()
    {
        speciesName = "Politoed",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 225,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "politoed", //Verify
        graphicsLocation = "politoed", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.WaterAbsorb,
            Ability.Damp,
            Ability.Drizzle,
        },
    };
    public static SpeciesData Hoppip = new()
    {
        speciesName = "Hoppip",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = SpDef,
        evolution = Evolution.Hoppip,
        xpClass = XPClass.MediumSlow,
        xpYield = 50,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "hoppip", //Verify
        graphicsLocation = "hoppip", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.LeafGuard,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Skiploom = new()
    {
        speciesName = "Skiploom",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = 2 * Speed,
        evolution = Evolution.Skiploom,
        xpClass = XPClass.MediumSlow,
        xpYield = 119,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "skiploom", //Verify
        graphicsLocation = "skiploom", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.LeafGuard,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Jumpluff = new()
    {
        speciesName = "Jumpluff",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 75,
        baseAttack = 55,
        baseDefense = 70,
        baseSpAtk = 55,
        baseSpDef = 85,
        baseSpeed = 110,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 207,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "jumpluff", //Verify
        graphicsLocation = "jumpluff", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.LeafGuard,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Aipom = new()
    {
        speciesName = "Aipom",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "aipom", //Verify
        graphicsLocation = "aipom", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.Pickup,
            Ability.SkillLink,
        },
    };
    public static SpeciesData Sunkern = new()
    {
        speciesName = "Sunkern",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 30,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 30,
        evYield = SpAtk,
        evolution = Evolution.Sunkern,
        xpClass = XPClass.MediumSlow,
        xpYield = 36,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 70,
        cryLocation = "sunkern", //Verify
        graphicsLocation = "sunkern", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.SolarPower,
            Ability.EarlyBird,
        },
    };
    public static SpeciesData Sunflora = new()
    {
        speciesName = "Sunflora",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 75,
        baseAttack = 75,
        baseDefense = 55,
        baseSpAtk = 105,
        baseSpDef = 85,
        baseSpeed = 30,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 149,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "sunflora", //Verify
        graphicsLocation = "sunflora", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.SolarPower,
            Ability.EarlyBird,
        },
    };
    public static SpeciesData Yanma = new()
    {
        speciesName = "Yanma",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 75,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 78,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "yanma", //Verify
        graphicsLocation = "yanma", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SpeedBoost,
            Ability.CompoundEyes,
            Ability.Frisk,
        },
    };
    public static SpeciesData Wooper = new()
    {
        speciesName = "Wooper",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 45,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Wooper,
        xpClass = XPClass.MediumFast,
        xpYield = 42,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "wooper", //Verify
        graphicsLocation = "wooper", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Damp,
            Ability.WaterAbsorb,
            Ability.Unaware,
        },
    };
    public static SpeciesData Quagsire = new()
    {
        speciesName = "Quagsire",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 95,
        baseAttack = 85,
        baseDefense = 85,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 151,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "quagsire", //Verify
        graphicsLocation = "quagsire", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Damp,
            Ability.WaterAbsorb,
            Ability.Unaware,
        },
    };
    public static SpeciesData Espeon = new()
    {
        speciesName = "Espeon",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 95,
        baseSpeed = 110,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "espeon", //Verify
        graphicsLocation = "espeon", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.Synchronize,
            Ability.MagicBounce,
        },
    };
    public static SpeciesData Umbreon = new()
    {
        speciesName = "Umbreon",
        type1 = Type.Dark,
        type2 = Type.Dark,
        baseHP = 95,
        baseAttack = 65,
        baseDefense = 110,
        baseSpAtk = 60,
        baseSpDef = 130,
        baseSpeed = 65,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 184,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "umbreon", //Verify
        graphicsLocation = "umbreon", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.Synchronize,
            Ability.InnerFocus,
        },
    };
    public static SpeciesData Murkrow = new()
    {
        speciesName = "Murkrow",
        type1 = Type.Dark,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 42,
        baseSpAtk = 85,
        baseSpDef = 42,
        baseSpeed = 91,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 81,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 35,
        cryLocation = "murkrow", //Verify
        graphicsLocation = "murkrow", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.SuperLuck,
            Ability.Prankster,
        },
    };
    public static SpeciesData Slowking = new()
    {
        speciesName = "Slowking",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 70,
        baseFriendship = 70,
        cryLocation = "slowking", //Verify
        graphicsLocation = "slowking", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.OwnTempo,
            Ability.Regenerator,
        },
    };
    public static SpeciesData Misdreavus = new()
    {
        speciesName = "Misdreavus",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 85,
        baseSpDef = 85,
        baseSpeed = 85,
        evYield = SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 87,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "misdreavus", //Verify
        graphicsLocation = "misdreavus", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Unown = new()
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
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 118,
        learnset = Learnset.EmptyLearnset,
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 40,
        catchRate = 225,
        baseFriendship = 50,
        cryLocation = "unown",
        graphicsLocation = "unown", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Wobbuffet = new()
    {
        speciesName = "Wobbuffet",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 190,
        baseAttack = 33,
        baseDefense = 58,
        baseSpAtk = 33,
        baseSpDef = 58,
        baseSpeed = 33,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "wobbuffet", //Verify
        graphicsLocation = "wobbuffet", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShadowTag,
            Ability.ShadowTag,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Girafarig = new()
    {
        speciesName = "Girafarig",
        type1 = Type.Normal,
        type2 = Type.Psychic,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 65,
        baseSpAtk = 90,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "girafarig", //Verify
        graphicsLocation = "girafarig", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.InnerFocus,
            Ability.EarlyBird,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Pineco = new()
    {
        speciesName = "Pineco",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 90,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 15,
        evYield = Defense,
        evolution = Evolution.Pineco,
        xpClass = XPClass.MediumFast,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "pineco", //Verify
        graphicsLocation = "pineco", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.Sturdy,
            Ability.Overcoat,
        },
    };
    public static SpeciesData Forretress = new()
    {
        speciesName = "Forretress",
        type1 = Type.Bug,
        type2 = Type.Steel,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 140,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "forretress", //Verify
        graphicsLocation = "forretress", //Verify
        backSpriteHeight = 16,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.Sturdy,
            Ability.Overcoat,
        },
    };
    public static SpeciesData Dunsparce = new()
    {
        speciesName = "Dunsparce",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 100,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 145,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "dunsparce", //Verify
        graphicsLocation = "dunsparce", //Verify
        backSpriteHeight = 17,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SereneGrace,
            Ability.RunAway,
            Ability.Rattled,
        },
    };
    public static SpeciesData Gligar = new()
    {
        speciesName = "Gligar",
        type1 = Type.Ground,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 105,
        baseSpAtk = 35,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 86,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "gligar", //Verify
        graphicsLocation = "gligar", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.HyperCutter,
            Ability.SandVeil,
            Ability.Immunity,
        },
    };
    public static SpeciesData Steelix = new()
    {
        speciesName = "Steelix",
        type1 = Type.Steel,
        type2 = Type.Ground,
        baseHP = 75,
        baseAttack = 85,
        baseDefense = 200,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 179,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 25,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "steelix", //Verify
        graphicsLocation = "steelix", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RockHead,
            Ability.Sturdy,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Snubbull = new()
    {
        speciesName = "Snubbull",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Attack,
        evolution = Evolution.Snubbull,
        xpClass = XPClass.Fast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "snubbull", //Verify
        graphicsLocation = "snubbull", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.RunAway,
            Ability.Rattled,
        },
    };
    public static SpeciesData Granbull = new()
    {
        speciesName = "Granbull",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "granbull", //Verify
        graphicsLocation = "granbull", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.QuickFeet,
            Ability.Rattled,
        },
    };
    public static SpeciesData Qwilfish = new()
    {
        speciesName = "Qwilfish",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 75,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 88,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "qwilfish", //Verify
        graphicsLocation = "qwilfish", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.PoisonPoint,
            Ability.SwiftSwim,
            Ability.Intimidate,
        },
    };
    public static SpeciesData Scizor = new()
    {
        speciesName = "Scizor",
        type1 = Type.Bug,
        type2 = Type.Steel,
        baseHP = 70,
        baseAttack = 130,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 25,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "scizor", //Verify
        graphicsLocation = "scizor", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Technician,
            Ability.LightMetal,
        },
    };
    public static SpeciesData Shuckle = new()
    {
        speciesName = "Shuckle",
        type1 = Type.Bug,
        type2 = Type.Rock,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 230,
        baseSpAtk = 10,
        baseSpDef = 230,
        baseSpeed = 5,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 177,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "shuckle", //Verify
        graphicsLocation = "shuckle", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.Gluttony,
            Ability.Contrary,
        },
    };
    public static SpeciesData Heracross = new()
    {
        speciesName = "Heracross",
        type1 = Type.Bug,
        type2 = Type.Fighting,
        baseHP = 80,
        baseAttack = 125,
        baseDefense = 75,
        baseSpAtk = 40,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "heracross", //Verify
        graphicsLocation = "heracross", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Guts,
            Ability.Moxie,
        },
    };
    public static SpeciesData Sneasel = new()
    {
        speciesName = "Sneasel",
        type1 = Type.Dark,
        type2 = Type.Ice,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 55,
        baseSpAtk = 35,
        baseSpDef = 75,
        baseSpeed = 115,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 86,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 35,
        cryLocation = "sneasel", //Verify
        graphicsLocation = "sneasel", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.InnerFocus,
            Ability.KeenEye,
            Ability.Pickpocket,
        },
    };
    public static SpeciesData Teddiursa = new()
    {
        speciesName = "Teddiursa",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Teddiursa,
        xpClass = XPClass.MediumFast,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "teddiursa", //Verify
        graphicsLocation = "teddiursa", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pickup,
            Ability.QuickFeet,
            Ability.HoneyGather,
        },
    };
    public static SpeciesData Ursaring = new()
    {
        speciesName = "Ursaring",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 75,
        baseSpAtk = 75,
        baseSpDef = 75,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "ursaring", //Verify
        graphicsLocation = "ursaring", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Guts,
            Ability.QuickFeet,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Slugma = new()
    {
        speciesName = "Slugma",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 70,
        baseSpDef = 40,
        baseSpeed = 20,
        evYield = SpAtk,
        evolution = Evolution.Slugma,
        xpClass = XPClass.MediumFast,
        xpYield = 50,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "slugma", //Verify
        graphicsLocation = "slugma", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.MagmaArmor,
            Ability.FlameBody,
            Ability.WeakArmor,
        },
    };
    public static SpeciesData Magcargo = new()
    {
        speciesName = "Magcargo",
        type1 = Type.Fire,
        type2 = Type.Rock,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 120,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 151,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "magcargo", //Verify
        graphicsLocation = "magcargo", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.MagmaArmor,
            Ability.FlameBody,
            Ability.WeakArmor,
        },
    };
    public static SpeciesData Swinub = new()
    {
        speciesName = "Swinub",
        type1 = Type.Ice,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Swinub,
        xpClass = XPClass.Slow,
        xpYield = 50,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "swinub", //Verify
        graphicsLocation = "swinub", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.SnowCloak,
            Ability.ThickFat,
        },
    };
    public static SpeciesData Piloswine = new()
    {
        speciesName = "Piloswine",
        type1 = Type.Ice,
        type2 = Type.Ground,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = HP + Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 158,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "piloswine", //Verify
        graphicsLocation = "piloswine", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.SnowCloak,
            Ability.ThickFat,
        },
    };
    public static SpeciesData Corsola = new()
    {
        speciesName = "Corsola",
        type1 = Type.Water,
        type2 = Type.Rock,
        baseHP = 55,
        baseAttack = 55,
        baseDefense = 85,
        baseSpAtk = 65,
        baseSpDef = 85,
        baseSpeed = 35,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 144,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "corsola", //Verify
        graphicsLocation = "corsola", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Hustle,
            Ability.NaturalCure,
            Ability.Regenerator,
        },
    };
    public static SpeciesData Remoraid = new()
    {
        speciesName = "Remoraid",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 35,
        baseAttack = 65,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 35,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Remoraid,
        xpClass = XPClass.MediumFast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "remoraid", //Verify
        graphicsLocation = "remoraid", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Hustle,
            Ability.Sniper,
            Ability.Moody,
        },
    };
    public static SpeciesData Octillery = new()
    {
        speciesName = "Octillery",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 75,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 105,
        baseSpDef = 75,
        baseSpeed = 45,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 168,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "octillery", //Verify
        graphicsLocation = "octillery", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SuctionCups,
            Ability.Sniper,
            Ability.Moody,
        },
    };
    public static SpeciesData Delibird = new()
    {
        speciesName = "Delibird",
        type1 = Type.Ice,
        type2 = Type.Flying,
        baseHP = 45,
        baseAttack = 55,
        baseDefense = 45,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 116,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "delibird", //Verify
        graphicsLocation = "delibird", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.VitalSpirit,
            Ability.Hustle,
            Ability.Insomnia,
        },
    };
    public static SpeciesData Mantine = new()
    {
        speciesName = "Mantine",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 140,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 170,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 25,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "mantine", //Verify
        graphicsLocation = "mantine", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.WaterAbsorb,
            Ability.WaterVeil,
        },
    };
    public static SpeciesData Skarmory = new()
    {
        speciesName = "Skarmory",
        type1 = Type.Steel,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 140,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 25,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "skarmory", //Verify
        graphicsLocation = "skarmory", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.Sturdy,
            Ability.WeakArmor,
        },
    };
    public static SpeciesData Houndour = new()
    {
        speciesName = "Houndour",
        type1 = Type.Dark,
        type2 = Type.Fire,
        baseHP = 45,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 80,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Houndour,
        xpClass = XPClass.Slow,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 35,
        cryLocation = "houndour", //Verify
        graphicsLocation = "houndour", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.EarlyBird,
            Ability.FlashFire,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Houndoom = new()
    {
        speciesName = "Houndoom",
        type1 = Type.Dark,
        type2 = Type.Fire,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 110,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "houndoom", //Verify
        graphicsLocation = "houndoom", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.EarlyBird,
            Ability.FlashFire,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Kingdra = new()
    {
        speciesName = "Kingdra",
        type1 = Type.Water,
        type2 = Type.Dragon,
        baseHP = 75,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = Attack + SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 243,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "kingdra", //Verify
        graphicsLocation = "kingdra", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.Sniper,
            Ability.Damp,
        },
    };
    public static SpeciesData Phanpy = new()
    {
        speciesName = "Phanpy",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 40,
        evYield = HP,
        evolution = Evolution.Phanpy,
        xpClass = XPClass.MediumFast,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "phanpy", //Verify
        graphicsLocation = "phanpy", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pickup,
            Ability.Pickup,
            Ability.SandVeil,
        },
    };
    public static SpeciesData Donphan = new()
    {
        speciesName = "Donphan",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 120,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "donphan", //Verify
        graphicsLocation = "donphan", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.Sturdy,
            Ability.SandVeil,
        },
    };
    public static SpeciesData Porygon2 = new()
    {
        speciesName = "Porygon2",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 85,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 105,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 180,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "porygon2", //Verify
        graphicsLocation = "porygon2", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Trace,
            Ability.Download,
            Ability.Analytic,
        },
    };
    public static SpeciesData Stantler = new()
    {
        speciesName = "Stantler",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 73,
        baseAttack = 95,
        baseDefense = 62,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "stantler", //Verify
        graphicsLocation = "stantler", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.Frisk,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Smeargle = new()
    {
        speciesName = "Smeargle",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 20,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 88,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "smeargle", //Verify
        graphicsLocation = "smeargle", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.OwnTempo,
            Ability.Technician,
            Ability.Moody,
        },
    };
    public static SpeciesData Tyrogue = new()
    {
        speciesName = "Tyrogue",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Tyrogue,
        xpClass = XPClass.MediumFast,
        xpYield = 42,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "tyrogue", //Verify
        graphicsLocation = "tyrogue", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Guts,
            Ability.Steadfast,
            Ability.VitalSpirit,
        },
    };
    public static SpeciesData Hitmontop = new()
    {
        speciesName = "Hitmontop",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "hitmontop", //Verify
        graphicsLocation = "hitmontop", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.Technician,
            Ability.Steadfast,
        },
    };
    public static SpeciesData Smoochum = new()
    {
        speciesName = "Smoochum",
        type1 = Type.Ice,
        type2 = Type.Psychic,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Smoochum,
        xpClass = XPClass.MediumFast,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "smoochum", //Verify
        graphicsLocation = "smoochum", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.Forewarn,
            Ability.Hydration,
        },
    };
    public static SpeciesData Elekid = new()
    {
        speciesName = "Elekid",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 45,
        baseAttack = 63,
        baseDefense = 37,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.Elekid,
        xpClass = XPClass.MediumFast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "elekid", //Verify
        graphicsLocation = "elekid", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.Static,
            Ability.VitalSpirit,
        },
    };
    public static SpeciesData Magby = new()
    {
        speciesName = "Magby",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 45,
        baseAttack = 75,
        baseDefense = 37,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 83,
        evYield = Speed,
        evolution = Evolution.Magby,
        xpClass = XPClass.MediumFast,
        xpYield = 73,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "magby", //Verify
        graphicsLocation = "magby", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.FlameBody,
            Ability.FlameBody,
            Ability.VitalSpirit,
        },
    };
    public static SpeciesData Miltank = new()
    {
        speciesName = "Miltank",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 95,
        baseAttack = 80,
        baseDefense = 105,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 100,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "miltank", //Verify
        graphicsLocation = "miltank", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.Scrappy,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Blissey = new()
    {
        speciesName = "Blissey",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 255,
        baseAttack = 10,
        baseDefense = 10,
        baseSpAtk = 75,
        baseSpDef = 135,
        baseSpeed = 55,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.Fast,
        xpYield = 608,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 40,
        catchRate = 30,
        baseFriendship = 140,
        cryLocation = "blissey", //Verify
        graphicsLocation = "blissey", //Verify
        backSpriteHeight = 16,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.NaturalCure,
            Ability.SereneGrace,
            Ability.Healer,
        },
    };
    public static SpeciesData Raikou = new()
    {
        speciesName = "Raikou",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 75,
        baseSpAtk = 115,
        baseSpDef = 100,
        baseSpeed = 115,
        evYield = 2 * Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "raikou", //Verify
        graphicsLocation = "raikou", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.VoltAbsorb,
        },
    };
    public static SpeciesData Entei = new()
    {
        speciesName = "Entei",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 115,
        baseAttack = 115,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 100,
        evYield = HP + 2 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "entei", //Verify
        graphicsLocation = "entei", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.FlashFire,
        },
    };
    public static SpeciesData Suicune = new()
    {
        speciesName = "Suicune",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 100,
        baseAttack = 75,
        baseDefense = 115,
        baseSpAtk = 90,
        baseSpDef = 115,
        baseSpeed = 85,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "suicune", //Verify
        graphicsLocation = "suicune", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.WaterAbsorb,
        },
    };
    public static SpeciesData Larvitar = new()
    {
        speciesName = "Larvitar",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 64,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 50,
        baseSpeed = 41,
        evYield = Attack,
        evolution = Evolution.Larvitar,
        xpClass = XPClass.Slow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "larvitar", //Verify
        graphicsLocation = "larvitar", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Guts,
            Ability.Guts,
            Ability.SandVeil,
        },
    };
    public static SpeciesData Pupitar = new()
    {
        speciesName = "Pupitar",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 70,
        baseAttack = 84,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 51,
        evYield = 2 * Attack,
        evolution = Evolution.Pupitar,
        xpClass = XPClass.Slow,
        xpYield = 144,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "pupitar", //Verify
        graphicsLocation = "pupitar", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.ShedSkin,
        },
    };
    public static SpeciesData Tyranitar = new()
    {
        speciesName = "Tyranitar",
        type1 = Type.Rock,
        type2 = Type.Dark,
        baseHP = 100,
        baseAttack = 134,
        baseDefense = 110,
        baseSpAtk = 95,
        baseSpDef = 100,
        baseSpeed = 61,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "tyranitar", //Verify
        graphicsLocation = "tyranitar", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SandStream,
            Ability.SandStream,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Lugia = new()
    {
        speciesName = "Lugia",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 106,
        baseAttack = 90,
        baseDefense = 130,
        baseSpAtk = 90,
        baseSpDef = 154,
        baseSpeed = 110,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 306,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "lugia", //Verify
        graphicsLocation = "lugia", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.Multiscale,
        },
    };
    public static SpeciesData HoOh = new()
    {
        speciesName = "Ho Oh",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 106,
        baseAttack = 130,
        baseDefense = 90,
        baseSpAtk = 110,
        baseSpDef = 154,
        baseSpeed = 90,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = XPClass.Slow,
        xpYield = 306,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "ho oh", //Verify
        graphicsLocation = "ho oh", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.Regenerator,
        },

    };
    public static SpeciesData Celebi = new()
    {
        speciesName = "Celebi",
        type1 = Type.Psychic,
        type2 = Type.Grass,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = XPClass.MediumSlow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 45,
        baseFriendship = 100,
        cryLocation = "celebi", //Verify
        graphicsLocation = "celebi", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.NaturalCure,
            Ability.NaturalCure,
            Ability.NaturalCure,
        },
    };

    public static SpeciesData Treecko = new()
    {
        speciesName = "Treecko",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 70,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "treecko", //Verify
        graphicsLocation = "treecko", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Unburden,
        },
    };
    public static SpeciesData Grovyle = new()
    {
        speciesName = "Grovyle",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 95,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "grovyle", //Verify
        graphicsLocation = "grovyle", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Unburden,
        },
    };
    public static SpeciesData Sceptile = new()
    {
        speciesName = "Sceptile",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 65,
        baseSpAtk = 105,
        baseSpDef = 85,
        baseSpeed = 120,
        evYield = 3 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "sceptile", //Verify
        graphicsLocation = "sceptile", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Overgrow,
            Ability.Overgrow,
            Ability.Unburden,
        },
    };
    public static SpeciesData Torchic = new()
    {
        speciesName = "Torchic",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 45,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 70,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "torchic", //Verify
        graphicsLocation = "torchic", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SpeedBoost,
        },
    };
    public static SpeciesData Combusken = new()
    {
        speciesName = "Combusken",
        type1 = Type.Fire,
        type2 = Type.Fighting,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 60,
        baseSpAtk = 85,
        baseSpDef = 60,
        baseSpeed = 55,
        evYield = Attack + SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "combusken", //Verify
        graphicsLocation = "combusken", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SpeedBoost,
        },
    };
    public static SpeciesData Blaziken = new()
    {
        speciesName = "Blaziken",
        type1 = Type.Fire,
        type2 = Type.Fighting,
        baseHP = 80,
        baseAttack = 120,
        baseDefense = 70,
        baseSpAtk = 110,
        baseSpDef = 70,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "blaziken", //Verify
        graphicsLocation = "blaziken", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Blaze,
            Ability.Blaze,
            Ability.SpeedBoost,
        },
    };
    public static SpeciesData Mudkip = new()
    {
        speciesName = "Mudkip",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "mudkip", //Verify
        graphicsLocation = "mudkip", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.Damp,
        },
    };
    public static SpeciesData Marshtomp = new()
    {
        speciesName = "Marshtomp",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 50,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "marshtomp", //Verify
        graphicsLocation = "marshtomp", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.Damp,
        },
    };
    public static SpeciesData Swampert = new()
    {
        speciesName = "Swampert",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 100,
        baseAttack = 110,
        baseDefense = 90,
        baseSpAtk = 85,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 241,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "swampert", //Verify
        graphicsLocation = "swampert", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Torrent,
            Ability.Torrent,
            Ability.Damp,
        },
    };
    public static SpeciesData Poochyena = new()
    {
        speciesName = "Poochyena",
        type1 = Type.Dark,
        type2 = Type.Dark,
        baseHP = 35,
        baseAttack = 55,
        baseDefense = 35,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "poochyena", //Verify
        graphicsLocation = "poochyena", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RunAway,
            Ability.QuickFeet,
            Ability.Rattled,
        },
    };
    public static SpeciesData Mightyena = new()
    {
        speciesName = "Mightyena",
        type1 = Type.Dark,
        type2 = Type.Dark,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 147,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 127,
        baseFriendship = 70,
        cryLocation = "mightyena", //Verify
        graphicsLocation = "mightyena", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.QuickFeet,
            Ability.Moxie,
        },
    };
    public static SpeciesData Zigzagoon = new()
    {
        speciesName = "Zigzagoon",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 38,
        baseAttack = 30,
        baseDefense = 41,
        baseSpAtk = 30,
        baseSpDef = 41,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "zigzagoon", //Verify
        graphicsLocation = "zigzagoon", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pickup,
            Ability.Gluttony,
            Ability.QuickFeet,
        },
    };
    public static SpeciesData Linoone = new()
    {
        speciesName = "Linoone",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 78,
        baseAttack = 70,
        baseDefense = 61,
        baseSpAtk = 50,
        baseSpDef = 61,
        baseSpeed = 100,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 147,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "linoone", //Verify
        graphicsLocation = "linoone", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pickup,
            Ability.Gluttony,
            Ability.QuickFeet,
        },
    };
    public static SpeciesData Wurmple = new()
    {
        speciesName = "Wurmple",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 45,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 20,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "wurmple", //Verify
        graphicsLocation = "wurmple", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShieldDust,
            Ability.ShieldDust,
            Ability.RunAway,
        },
    };
    public static SpeciesData Silcoon = new()
    {
        speciesName = "Silcoon",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 35,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "silcoon", //Verify
        graphicsLocation = "silcoon", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.ShedSkin,
        },
    };
    public static SpeciesData Beautifly = new()
    {
        speciesName = "Beautifly",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 90,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = 3 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 178,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "beautifly", //Verify
        graphicsLocation = "beautifly", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Swarm,
            Ability.Swarm,
            Ability.Rivalry,
        },
    };
    public static SpeciesData Cascoon = new()
    {
        speciesName = "Cascoon",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 35,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 72,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "cascoon", //Verify
        graphicsLocation = "cascoon", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.ShedSkin,
        },
    };
    public static SpeciesData Dustox = new()
    {
        speciesName = "Dustox",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 90,
        baseSpeed = 65,
        evYield = 3 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "dustox", //Verify
        graphicsLocation = "dustox", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShieldDust,
            Ability.ShieldDust,
            Ability.CompoundEyes,
        },
    };
    public static SpeciesData Lotad = new()
    {
        speciesName = "Lotad",
        type1 = Type.Water,
        type2 = Type.Grass,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 30,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 44,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "lotad", //Verify
        graphicsLocation = "lotad", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.RainDish,
            Ability.OwnTempo,
        },
    };
    public static SpeciesData Lombre = new()
    {
        speciesName = "Lombre",
        type1 = Type.Water,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 50,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 119,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "lombre", //Verify
        graphicsLocation = "lombre", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.RainDish,
            Ability.OwnTempo,
        },
    };
    public static SpeciesData Ludicolo = new()
    {
        speciesName = "Ludicolo",
        type1 = Type.Water,
        type2 = Type.Grass,
        baseHP = 80,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = 3 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 216,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "ludicolo", //Verify
        graphicsLocation = "ludicolo", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.RainDish,
            Ability.OwnTempo,
        },
    };
    public static SpeciesData Seedot = new()
    {
        speciesName = "Seedot",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 44,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "seedot", //Verify
        graphicsLocation = "seedot", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.EarlyBird,
            Ability.Pickpocket,
        },
    };
    public static SpeciesData Nuzleaf = new()
    {
        speciesName = "Nuzleaf",
        type1 = Type.Grass,
        type2 = Type.Dark,
        baseHP = 70,
        baseAttack = 70,
        baseDefense = 40,
        baseSpAtk = 60,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 119,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "nuzleaf", //Verify
        graphicsLocation = "nuzleaf", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.EarlyBird,
            Ability.Pickpocket,
        },
    };
    public static SpeciesData Shiftry = new()
    {
        speciesName = "Shiftry",
        type1 = Type.Grass,
        type2 = Type.Dark,
        baseHP = 90,
        baseAttack = 100,
        baseDefense = 60,
        baseSpAtk = 90,
        baseSpDef = 60,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 216,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "shiftry", //Verify
        graphicsLocation = "shiftry", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.EarlyBird,
            Ability.Pickpocket,
        },
    };
    public static SpeciesData Taillow = new()
    {
        speciesName = "Taillow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 55,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 54,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "taillow", //Verify
        graphicsLocation = "taillow", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Guts,
            Ability.Guts,
            Ability.Scrappy,
        },
    };
    public static SpeciesData Swellow = new()
    {
        speciesName = "Swellow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 60,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 125,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "swellow", //Verify
        graphicsLocation = "swellow", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Guts,
            Ability.Guts,
            Ability.Scrappy,
        },
    };
    public static SpeciesData Wingull = new()
    {
        speciesName = "Wingull",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 55,
        baseSpDef = 30,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 54,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "wingull", //Verify
        graphicsLocation = "wingull", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.Hydration,
            Ability.RainDish,
        },
    };
    public static SpeciesData Pelipper = new()
    {
        speciesName = "Pelipper",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 100,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 65,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 154,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "pelipper", //Verify
        graphicsLocation = "pelipper", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.Drizzle,
            Ability.RainDish,
        },
    };
    public static SpeciesData Ralts = new()
    {
        speciesName = "Ralts",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 28,
        baseAttack = 25,
        baseDefense = 25,
        baseSpAtk = 45,
        baseSpDef = 35,
        baseSpeed = 40,
        evYield = SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 40,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 35,
        cryLocation = "ralts", //Verify
        graphicsLocation = "ralts", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.Trace,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Kirlia = new()
    {
        speciesName = "Kirlia",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 38,
        baseAttack = 35,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = 2 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 97,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 35,
        cryLocation = "kirlia", //Verify
        graphicsLocation = "kirlia", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.Trace,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Gardevoir = new()
    {
        speciesName = "Gardevoir",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 68,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 125,
        baseSpDef = 115,
        baseSpeed = 80,
        evYield = 3 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 233,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "gardevoir", //Verify
        graphicsLocation = "gardevoir", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Synchronize,
            Ability.Trace,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Surskit = new()
    {
        speciesName = "Surskit",
        type1 = Type.Bug,
        type2 = Type.Water,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 32,
        baseSpAtk = 50,
        baseSpDef = 52,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 54,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "surskit", //Verify
        graphicsLocation = "surskit", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.SwiftSwim,
            Ability.RainDish,
        },
    };
    public static SpeciesData Masquerain = new()
    {
        speciesName = "Masquerain",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 70,
        baseAttack = 60,
        baseDefense = 62,
        baseSpAtk = 80,
        baseSpDef = 82,
        baseSpeed = 60,
        evYield = SpAtk + SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "masquerain", //Verify
        graphicsLocation = "masquerain", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.Intimidate,
            Ability.Unnerve,
        },
    };
    public static SpeciesData Shroomish = new()
    {
        speciesName = "Shroomish",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 60,
        baseSpeed = 35,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 59,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "shroomish", //Verify
        graphicsLocation = "shroomish", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.EffectSpore,
            Ability.PoisonHeal,
            Ability.QuickFeet,
        },
    };
    public static SpeciesData Breloom = new()
    {
        speciesName = "Breloom",
        type1 = Type.Grass,
        type2 = Type.Fighting,
        baseHP = 60,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 15,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "breloom", //Verify
        graphicsLocation = "breloom", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.EffectSpore,
            Ability.PoisonHeal,
            Ability.Technician,
        },
    };
    public static SpeciesData Slakoth = new()
    {
        speciesName = "Slakoth",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 30,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "slakoth", //Verify
        graphicsLocation = "slakoth", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Truant,
            Ability.Truant,
            Ability.Truant,
        },
    };
    public static SpeciesData Vigoroth = new()
    {
        speciesName = "Vigoroth",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 154,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "vigoroth", //Verify
        graphicsLocation = "vigoroth", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.VitalSpirit,
            Ability.VitalSpirit,
            Ability.VitalSpirit,
        },
    };
    public static SpeciesData Slaking = new()
    {
        speciesName = "Slaking",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 150,
        baseAttack = 160,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 65,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 252,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "slaking", //Verify
        graphicsLocation = "slaking", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Truant,
            Ability.Truant,
            Ability.Truant,
        },
    };
    public static SpeciesData Nincada = new()
    {
        speciesName = "Nincada",
        type1 = Type.Bug,
        type2 = Type.Ground,
        baseHP = 31,
        baseAttack = 45,
        baseDefense = 90,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 53,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "nincada", //Verify
        graphicsLocation = "nincada", //Verify
        backSpriteHeight = 18,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CompoundEyes,
            Ability.CompoundEyes,
            Ability.RunAway,
        },
    };
    public static SpeciesData Ninjask = new()
    {
        speciesName = "Ninjask",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 61,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 160,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 160,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "ninjask", //Verify
        graphicsLocation = "ninjask", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SpeedBoost,
            Ability.SpeedBoost,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Shedinja = new()
    {
        speciesName = "Shedinja",
        type1 = Type.Bug,
        type2 = Type.Ghost,
        baseHP = 1,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 83,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "shedinja", //Verify
        graphicsLocation = "shedinja", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.WonderGuard,
            Ability.WonderGuard,
            Ability.WonderGuard,
        },
    };
    public static SpeciesData Whismur = new()
    {
        speciesName = "Whismur",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 64,
        baseAttack = 51,
        baseDefense = 23,
        baseSpAtk = 51,
        baseSpDef = 23,
        baseSpeed = 28,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 48,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "whismur", //Verify
        graphicsLocation = "whismur", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Soundproof,
            Ability.Soundproof,
            Ability.Rattled,
        },
    };
    public static SpeciesData Loudred = new()
    {
        speciesName = "Loudred",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 84,
        baseAttack = 71,
        baseDefense = 43,
        baseSpAtk = 71,
        baseSpDef = 43,
        baseSpeed = 48,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 126,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "loudred", //Verify
        graphicsLocation = "loudred", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Soundproof,
            Ability.Soundproof,
            Ability.Scrappy,
        },
    };
    public static SpeciesData Exploud = new()
    {
        speciesName = "Exploud",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 104,
        baseAttack = 91,
        baseDefense = 63,
        baseSpAtk = 91,
        baseSpDef = 63,
        baseSpeed = 68,
        evYield = 3 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 221,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "exploud", //Verify
        graphicsLocation = "exploud", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Soundproof,
            Ability.Soundproof,
            Ability.Scrappy,
        },
    };
    public static SpeciesData Makuhita = new()
    {
        speciesName = "Makuhita",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 72,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 47,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 180,
        baseFriendship = 70,
        cryLocation = "makuhita", //Verify
        graphicsLocation = "makuhita", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.Guts,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Hariyama = new()
    {
        speciesName = "Hariyama",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 144,
        baseAttack = 120,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 166,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "hariyama", //Verify
        graphicsLocation = "hariyama", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.Guts,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Azurill = new()
    {
        speciesName = "Azurill",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 50,
        baseAttack = 20,
        baseDefense = 40,
        baseSpAtk = 20,
        baseSpDef = 40,
        baseSpeed = 20,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 38,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 150,
        baseFriendship = 70,
        cryLocation = "azurill", //Verify
        graphicsLocation = "azurill", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.HugePower,
            Ability.SapSipper,
        },
    };
    public static SpeciesData Nosepass = new()
    {
        speciesName = "Nosepass",
        type1 = Type.Rock,
        type2 = Type.Rock,
        baseHP = 30,
        baseAttack = 45,
        baseDefense = 135,
        baseSpAtk = 45,
        baseSpDef = 90,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 75,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "nosepass", //Verify
        graphicsLocation = "nosepass", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.MagnetPull,
            Ability.SandForce,
        },
    };
    public static SpeciesData Skitty = new()
    {
        speciesName = "Skitty",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 50,
        baseAttack = 45,
        baseDefense = 45,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 50,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 52,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "skitty", //Verify
        graphicsLocation = "skitty", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CuteCharm,
            Ability.Normalize,
            Ability.WonderSkin,
        },
    };
    public static SpeciesData Delcatty = new()
    {
        speciesName = "Delcatty",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 70,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 70,
        evYield = HP + Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 140,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 15,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "delcatty", //Verify
        graphicsLocation = "delcatty", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.CuteCharm,
            Ability.Normalize,
            Ability.WonderSkin,
        },
    };
    public static SpeciesData Sableye = new()
    {
        speciesName = "Sableye",
        type1 = Type.Dark,
        type2 = Type.Ghost,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 133,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "sableye", //Verify
        graphicsLocation = "sableye", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.KeenEye,
            Ability.Stall,
            Ability.Prankster,
        },
    };
    public static SpeciesData Mawile = new()
    {
        speciesName = "Mawile",
        type1 = Type.Steel,
        type2 = Type.Steel,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 133,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "mawile", //Verify
        graphicsLocation = "mawile", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.HyperCutter,
            Ability.Intimidate,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Aron = new()
    {
        speciesName = "Aron",
        type1 = Type.Steel,
        type2 = Type.Rock,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 100,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 35,
        catchRate = 180,
        baseFriendship = 35,
        cryLocation = "aron", //Verify
        graphicsLocation = "aron", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.RockHead,
            Ability.HeavyMetal,
        },
    };
    public static SpeciesData Lairon = new()
    {
        speciesName = "Lairon",
        type1 = Type.Steel,
        type2 = Type.Rock,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 140,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 151,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 35,
        catchRate = 90,
        baseFriendship = 35,
        cryLocation = "lairon", //Verify
        graphicsLocation = "lairon", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.RockHead,
            Ability.HeavyMetal,
        },
    };
    public static SpeciesData Aggron = new()
    {
        speciesName = "Aggron",
        type1 = Type.Steel,
        type2 = Type.Rock,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 180,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = 3 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "aggron", //Verify
        graphicsLocation = "aggron", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Sturdy,
            Ability.RockHead,
            Ability.HeavyMetal,
        },
    };
    public static SpeciesData Meditite = new()
    {
        speciesName = "Meditite",
        type1 = Type.Fighting,
        type2 = Type.Psychic,
        baseHP = 30,
        baseAttack = 40,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 56,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 180,
        baseFriendship = 70,
        cryLocation = "meditite", //Verify
        graphicsLocation = "meditite", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.PurePower,
            Ability.PurePower,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Medicham = new()
    {
        speciesName = "Medicham",
        type1 = Type.Fighting,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 80,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 144,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "medicham", //Verify
        graphicsLocation = "medicham", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.PurePower,
            Ability.PurePower,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Electrike = new()
    {
        speciesName = "Electrike",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 40,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 59,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "electrike", //Verify
        graphicsLocation = "electrike", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.LightningRod,
            Ability.Minus,
        },
    };
    public static SpeciesData Manectric = new()
    {
        speciesName = "Manectric",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 70,
        baseAttack = 75,
        baseDefense = 60,
        baseSpAtk = 105,
        baseSpDef = 60,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 166,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "manectric", //Verify
        graphicsLocation = "manectric", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Static,
            Ability.LightningRod,
            Ability.Minus,
        },
    };
    public static SpeciesData Plusle = new()
    {
        speciesName = "Plusle",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "plusle", //Verify
        graphicsLocation = "plusle", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Plus,
            Ability.Plus,
            Ability.LightningRod,
        },
    };
    public static SpeciesData Minun = new()
    {
        speciesName = "Minun",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 142,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "minun", //Verify
        graphicsLocation = "minun", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Minus,
            Ability.Minus,
            Ability.VoltAbsorb,
        },
    };
    public static SpeciesData Volbeat = new()
    {
        speciesName = "Volbeat",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 65,
        baseAttack = 73,
        baseDefense = 55,
        baseSpAtk = 47,
        baseSpDef = 75,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 151,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 15,
        catchRate = 150,
        baseFriendship = 70,
        cryLocation = "volbeat", //Verify
        graphicsLocation = "volbeat", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Illuminate,
            Ability.Swarm,
            Ability.Prankster,
        },
    };
    public static SpeciesData Illumise = new()
    {
        speciesName = "Illumise",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 65,
        baseAttack = 47,
        baseDefense = 55,
        baseSpAtk = 73,
        baseSpDef = 75,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 151,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 15,
        catchRate = 150,
        baseFriendship = 70,
        cryLocation = "illumise", //Verify
        graphicsLocation = "illumise", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.TintedLens,
            Ability.Prankster,
        },
    };
    public static SpeciesData Roselia = new()
    {
        speciesName = "Roselia",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 50,
        baseAttack = 60,
        baseDefense = 45,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = 2 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 140,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 150,
        baseFriendship = 70,
        cryLocation = "roselia", //Verify
        graphicsLocation = "roselia", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.NaturalCure,
            Ability.PoisonPoint,
            Ability.LeafGuard,
        },
    };
    public static SpeciesData Gulpin = new()
    {
        speciesName = "Gulpin",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 43,
        baseDefense = 53,
        baseSpAtk = 43,
        baseSpDef = 53,
        baseSpeed = 40,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "gulpin", //Verify
        graphicsLocation = "gulpin", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.LiquidOoze,
            Ability.StickyHold,
            Ability.Gluttony,
        },
    };
    public static SpeciesData Swalot = new()
    {
        speciesName = "Swalot",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 100,
        baseAttack = 73,
        baseDefense = 83,
        baseSpAtk = 73,
        baseSpDef = 83,
        baseSpeed = 55,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "swalot", //Verify
        graphicsLocation = "swalot", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.LiquidOoze,
            Ability.StickyHold,
            Ability.Gluttony,
        },
    };
    public static SpeciesData Carvanha = new()
    {
        speciesName = "Carvanha",
        type1 = Type.Water,
        type2 = Type.Dark,
        baseHP = 45,
        baseAttack = 90,
        baseDefense = 20,
        baseSpAtk = 65,
        baseSpDef = 20,
        baseSpeed = 65,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 35,
        cryLocation = "carvanha", //Verify
        graphicsLocation = "carvanha", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RoughSkin,
            Ability.RoughSkin,
            Ability.SpeedBoost,
        },
    };
    public static SpeciesData Sharpedo = new()
    {
        speciesName = "Sharpedo",
        type1 = Type.Water,
        type2 = Type.Dark,
        baseHP = 70,
        baseAttack = 120,
        baseDefense = 40,
        baseSpAtk = 95,
        baseSpDef = 40,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 35,
        cryLocation = "sharpedo", //Verify
        graphicsLocation = "sharpedo", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RoughSkin,
            Ability.RoughSkin,
            Ability.SpeedBoost,
        },
    };
    public static SpeciesData Wailmer = new()
    {
        speciesName = "Wailmer",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 130,
        baseAttack = 70,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 35,
        baseSpeed = 60,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 80,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 40,
        catchRate = 125,
        baseFriendship = 70,
        cryLocation = "wailmer", //Verify
        graphicsLocation = "wailmer", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.WaterVeil,
            Ability.Oblivious,
            Ability.Pressure,
        },
    };
    public static SpeciesData Wailord = new()
    {
        speciesName = "Wailord",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 170,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 90,
        baseSpDef = 45,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 40,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "wailord", //Verify
        graphicsLocation = "wailord", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.WaterVeil,
            Ability.Oblivious,
            Ability.Pressure,
        },
    };
    public static SpeciesData Numel = new()
    {
        speciesName = "Numel",
        type1 = Type.Fire,
        type2 = Type.Ground,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 61,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "numel", //Verify
        graphicsLocation = "numel", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.Simple,
            Ability.OwnTempo,
        },
    };
    public static SpeciesData Camerupt = new()
    {
        speciesName = "Camerupt",
        type1 = Type.Fire,
        type2 = Type.Ground,
        baseHP = 70,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 105,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = Attack + SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 150,
        baseFriendship = 70,
        cryLocation = "camerupt", //Verify
        graphicsLocation = "camerupt", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.MagmaArmor,
            Ability.SolidRock,
            Ability.AngerPoint,
        },
    };
    public static SpeciesData Torkoal = new()
    {
        speciesName = "Torkoal",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 140,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 20,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 165,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "torkoal", //Verify
        graphicsLocation = "torkoal", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.WhiteSmoke,
            Ability.Drought,
            Ability.ShellArmor,
        },
    };
    public static SpeciesData Spoink = new()
    {
        speciesName = "Spoink",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 25,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 66,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "spoink", //Verify
        graphicsLocation = "spoink", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.OwnTempo,
            Ability.Gluttony,
        },
    };
    public static SpeciesData Grumpig = new()
    {
        speciesName = "Grumpig",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 80,
        baseAttack = 45,
        baseDefense = 65,
        baseSpAtk = 90,
        baseSpDef = 110,
        baseSpeed = 80,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 165,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "grumpig", //Verify
        graphicsLocation = "grumpig", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.OwnTempo,
            Ability.Gluttony,
        },
    };
    public static SpeciesData Spinda = new()
    {
        speciesName = "Spinda",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 60,
        evYield = SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 126,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "spinda", //Verify
        graphicsLocation = "spinda", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.OwnTempo,
            Ability.TangledFeet,
            Ability.Contrary,
        },
    };
    public static SpeciesData Trapinch = new()
    {
        speciesName = "Trapinch",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 45,
        baseAttack = 100,
        baseDefense = 45,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 10,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "trapinch", //Verify
        graphicsLocation = "trapinch", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.HyperCutter,
            Ability.ArenaTrap,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Vibrava = new()
    {
        speciesName = "Vibrava",
        type1 = Type.Ground,
        type2 = Type.Dragon,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 70,
        evYield = Attack + Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 119,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "vibrava", //Verify
        graphicsLocation = "vibrava", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Flygon = new()
    {
        speciesName = "Flygon",
        type1 = Type.Ground,
        type2 = Type.Dragon,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 80,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = Attack + 2 * Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 234,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "flygon", //Verify
        graphicsLocation = "flygon", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Cacnea = new()
    {
        speciesName = "Cacnea",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 40,
        baseSpAtk = 85,
        baseSpDef = 40,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 67,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 35,
        cryLocation = "cacnea", //Verify
        graphicsLocation = "cacnea", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SandVeil,
            Ability.SandVeil,
            Ability.WaterAbsorb,
        },
    };
    public static SpeciesData Cacturne = new()
    {
        speciesName = "Cacturne",
        type1 = Type.Grass,
        type2 = Type.Dark,
        baseHP = 70,
        baseAttack = 115,
        baseDefense = 60,
        baseSpAtk = 115,
        baseSpDef = 60,
        baseSpeed = 55,
        evYield = Attack + SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 166,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 35,
        cryLocation = "cacturne", //Verify
        graphicsLocation = "cacturne", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SandVeil,
            Ability.SandVeil,
            Ability.WaterAbsorb,
        },
    };
    public static SpeciesData Swablu = new()
    {
        speciesName = "Swablu",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 45,
        baseAttack = 40,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 75,
        baseSpeed = 50,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "swablu", //Verify
        graphicsLocation = "swablu", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.NaturalCure,
            Ability.NaturalCure,
            Ability.CloudNine,
        },
    };
    public static SpeciesData Altaria = new()
    {
        speciesName = "Altaria",
        type1 = Type.Dragon,
        type2 = Type.Flying,
        baseHP = 75,
        baseAttack = 70,
        baseDefense = 90,
        baseSpAtk = 70,
        baseSpDef = 105,
        baseSpeed = 80,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 172,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "altaria", //Verify
        graphicsLocation = "altaria", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.NaturalCure,
            Ability.NaturalCure,
            Ability.CloudNine,
        },
    };
    public static SpeciesData Zangoose = new()
    {
        speciesName = "Zangoose",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 73,
        baseAttack = 115,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 90,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 160,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "zangoose", //Verify
        graphicsLocation = "zangoose", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Immunity,
            Ability.Immunity,
            Ability.ToxicBoost,
        },
    };
    public static SpeciesData Seviper = new()
    {
        speciesName = "Seviper",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 73,
        baseAttack = 100,
        baseDefense = 60,
        baseSpAtk = 100,
        baseSpDef = 60,
        baseSpeed = 65,
        evYield = Attack + SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 160,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "seviper", //Verify
        graphicsLocation = "seviper", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShedSkin,
            Ability.ShedSkin,
            Ability.Infiltrator,
        },
    };
    public static SpeciesData Lunatone = new()
    {
        speciesName = "Lunatone",
        type1 = Type.Rock,
        type2 = Type.Psychic,
        baseHP = 70,
        baseAttack = 55,
        baseDefense = 65,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 70,
        evYield = 2 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "lunatone", //Verify
        graphicsLocation = "lunatone", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Solrock = new()
    {
        speciesName = "Solrock",
        type1 = Type.Rock,
        type2 = Type.Psychic,
        baseHP = 70,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "solrock", //Verify
        graphicsLocation = "solrock", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Barboach = new()
    {
        speciesName = "Barboach",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 48,
        baseDefense = 43,
        baseSpAtk = 46,
        baseSpDef = 41,
        baseSpeed = 60,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "barboach", //Verify
        graphicsLocation = "barboach", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.Anticipation,
            Ability.Hydration,
        },
    };
    public static SpeciesData Whiscash = new()
    {
        speciesName = "Whiscash",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 110,
        baseAttack = 78,
        baseDefense = 73,
        baseSpAtk = 76,
        baseSpDef = 71,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 164,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "whiscash", //Verify
        graphicsLocation = "whiscash", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Oblivious,
            Ability.Anticipation,
            Ability.Hydration,
        },
    };
    public static SpeciesData Corphish = new()
    {
        speciesName = "Corphish",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 43,
        baseAttack = 80,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 62,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 15,
        catchRate = 205,
        baseFriendship = 70,
        cryLocation = "corphish", //Verify
        graphicsLocation = "corphish", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.HyperCutter,
            Ability.ShellArmor,
            Ability.Adaptability,
        },
    };
    public static SpeciesData Crawdaunt = new()
    {
        speciesName = "Crawdaunt",
        type1 = Type.Water,
        type2 = Type.Dark,
        baseHP = 63,
        baseAttack = 120,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 55,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fluctuating,
        xpYield = 164,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 15,
        catchRate = 155,
        baseFriendship = 70,
        cryLocation = "crawdaunt", //Verify
        graphicsLocation = "crawdaunt", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.HyperCutter,
            Ability.ShellArmor,
            Ability.Adaptability,
        },
    };
    public static SpeciesData Baltoy = new()
    {
        speciesName = "Baltoy",
        type1 = Type.Ground,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "baltoy", //Verify
        graphicsLocation = "baltoy", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Claydol = new()
    {
        speciesName = "Claydol",
        type1 = Type.Ground,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 70,
        baseDefense = 105,
        baseSpAtk = 70,
        baseSpDef = 120,
        baseSpeed = 75,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 175,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "claydol", //Verify
        graphicsLocation = "claydol", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Lileep = new()
    {
        speciesName = "Lileep",
        type1 = Type.Rock,
        type2 = Type.Grass,
        baseHP = 66,
        baseAttack = 41,
        baseDefense = 77,
        baseSpAtk = 61,
        baseSpDef = 87,
        baseSpeed = 23,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 71,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "lileep", //Verify
        graphicsLocation = "lileep", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SuctionCups,
            Ability.SuctionCups,
            Ability.StormDrain,
        },
    };
    public static SpeciesData Cradily = new()
    {
        speciesName = "Cradily",
        type1 = Type.Rock,
        type2 = Type.Grass,
        baseHP = 86,
        baseAttack = 81,
        baseDefense = 97,
        baseSpAtk = 81,
        baseSpDef = 107,
        baseSpeed = 43,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "cradily", //Verify
        graphicsLocation = "cradily", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SuctionCups,
            Ability.SuctionCups,
            Ability.StormDrain,
        },
    };
    public static SpeciesData Anorith = new()
    {
        speciesName = "Anorith",
        type1 = Type.Rock,
        type2 = Type.Bug,
        baseHP = 45,
        baseAttack = 95,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 71,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "anorith", //Verify
        graphicsLocation = "anorith", //Verify
        backSpriteHeight = 19,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.BattleArmor,
            Ability.BattleArmor,
            Ability.SwiftSwim,
        },
    };
    public static SpeciesData Armaldo = new()
    {
        speciesName = "Armaldo",
        type1 = Type.Rock,
        type2 = Type.Bug,
        baseHP = 75,
        baseAttack = 125,
        baseDefense = 100,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 173,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water3,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "armaldo", //Verify
        graphicsLocation = "armaldo", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.BattleArmor,
            Ability.BattleArmor,
            Ability.SwiftSwim,
        },
    };
    public static SpeciesData Feebas = new()
    {
        speciesName = "Feebas",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 20,
        baseAttack = 15,
        baseDefense = 20,
        baseSpAtk = 10,
        baseSpDef = 55,
        baseSpeed = 80,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 40,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "feebas", //Verify
        graphicsLocation = "feebas", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.Oblivious,
            Ability.Adaptability,
        },
    };
    public static SpeciesData Milotic = new()
    {
        speciesName = "Milotic",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 95,
        baseAttack = 60,
        baseDefense = 79,
        baseSpAtk = 100,
        baseSpDef = 125,
        baseSpeed = 81,
        evYield = 2 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 189,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "milotic", //Verify
        graphicsLocation = "milotic", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.MarvelScale,
            Ability.Competitive,
            Ability.CuteCharm,
        },
    };

    public static SpeciesData Castform = SpeciesData.Castform(
        Type.Normal, "castform/normal", 0);

    public static SpeciesData Kecleon = new()
    {
        speciesName = "Kecleon",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 120,
        baseSpeed = 40,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 154,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "kecleon", //Verify
        graphicsLocation = "kecleon", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ColorChange,
            Ability.ColorChange,
            Ability.Protean,
        },
    };
    public static SpeciesData Shuppet = new()
    {
        speciesName = "Shuppet",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 44,
        baseAttack = 75,
        baseDefense = 35,
        baseSpAtk = 63,
        baseSpDef = 33,
        baseSpeed = 45,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 59,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 225,
        baseFriendship = 35,
        cryLocation = "shuppet", //Verify
        graphicsLocation = "shuppet", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.Frisk,
            Ability.CursedBody,
        },
    };
    public static SpeciesData Banette = new()
    {
        speciesName = "Banette",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 64,
        baseAttack = 115,
        baseDefense = 65,
        baseSpAtk = 83,
        baseSpDef = 63,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "banette", //Verify
        graphicsLocation = "banette", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Insomnia,
            Ability.Frisk,
            Ability.CursedBody,
        },
    };
    public static SpeciesData Duskull = new()
    {
        speciesName = "Duskull",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 20,
        baseAttack = 40,
        baseDefense = 90,
        baseSpAtk = 30,
        baseSpDef = 90,
        baseSpeed = 25,
        evYield = SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 59,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 190,
        baseFriendship = 35,
        cryLocation = "duskull", //Verify
        graphicsLocation = "duskull", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Frisk,
        },
    };
    public static SpeciesData Dusclops = new()
    {
        speciesName = "Dusclops",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 40,
        baseAttack = 70,
        baseDefense = 130,
        baseSpAtk = 60,
        baseSpDef = 130,
        baseSpeed = 25,
        evYield = Defense + SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 90,
        baseFriendship = 35,
        cryLocation = "dusclops", //Verify
        graphicsLocation = "dusclops", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.Pressure,
            Ability.Frisk,
        },
    };
    public static SpeciesData Tropius = new()
    {
        speciesName = "Tropius",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 99,
        baseAttack = 68,
        baseDefense = 83,
        baseSpAtk = 72,
        baseSpDef = 87,
        baseSpeed = 51,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 161,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 25,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "tropius", //Verify
        graphicsLocation = "tropius", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Chlorophyll,
            Ability.SolarPower,
            Ability.Harvest,
        },
    };
    public static SpeciesData Chimecho = new()
    {
        speciesName = "Chimecho",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 65,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = SpAtk + SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 159,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "chimecho", //Verify
        graphicsLocation = "chimecho", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Absol = new()
    {
        speciesName = "Absol",
        type1 = Type.Dark,
        type2 = Type.Dark,
        baseHP = 65,
        baseAttack = 130,
        baseDefense = 60,
        baseSpAtk = 75,
        baseSpDef = 60,
        baseSpeed = 75,
        evYield = 2 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 163,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 25,
        catchRate = 30,
        baseFriendship = 35,
        cryLocation = "absol", //Verify
        graphicsLocation = "absol", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Pressure,
            Ability.SuperLuck,
            Ability.Justified,
        },
    };
    public static SpeciesData Wynaut = new()
    {
        speciesName = "Wynaut",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 23,
        baseDefense = 48,
        baseSpAtk = 23,
        baseSpDef = 48,
        baseSpeed = 23,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 52,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 20,
        catchRate = 125,
        baseFriendship = 70,
        cryLocation = "wynaut", //Verify
        graphicsLocation = "wynaut", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShadowTag,
            Ability.ShadowTag,
            Ability.Telepathy,
        },
    };
    public static SpeciesData Snorunt = new()
    {
        speciesName = "Snorunt",
        type1 = Type.Ice,
        type2 = Type.Ice,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "snorunt", //Verify
        graphicsLocation = "snorunt", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.InnerFocus,
            Ability.IceBody,
            Ability.Moody,
        },
    };
    public static SpeciesData Glalie = new()
    {
        speciesName = "Glalie",
        type1 = Type.Ice,
        type2 = Type.Ice,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 80,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumFast,
        xpYield = 168,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "glalie", //Verify
        graphicsLocation = "glalie", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.InnerFocus,
            Ability.IceBody,
            Ability.Moody,
        },
    };
    public static SpeciesData Spheal = new()
    {
        speciesName = "Spheal",
        type1 = Type.Ice,
        type2 = Type.Water,
        baseHP = 70,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 50,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 58,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "spheal", //Verify
        graphicsLocation = "spheal", //Verify
        backSpriteHeight = 15,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.IceBody,
            Ability.Oblivious,
        },
    };
    public static SpeciesData Sealeo = new()
    {
        speciesName = "Sealeo",
        type1 = Type.Ice,
        type2 = Type.Water,
        baseHP = 90,
        baseAttack = 60,
        baseDefense = 70,
        baseSpAtk = 75,
        baseSpDef = 70,
        baseSpeed = 45,
        evYield = 2 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 144,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "sealeo", //Verify
        graphicsLocation = "sealeo", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.IceBody,
            Ability.Oblivious,
        },
    };
    public static SpeciesData Walrein = new()
    {
        speciesName = "Walrein",
        type1 = Type.Ice,
        type2 = Type.Water,
        baseHP = 110,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 65,
        evYield = 3 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.MediumSlow,
        xpYield = 239,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "walrein", //Verify
        graphicsLocation = "walrein", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ThickFat,
            Ability.IceBody,
            Ability.Oblivious,
        },
    };
    public static SpeciesData Clamperl = new()
    {
        speciesName = "Clamperl",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 35,
        baseAttack = 64,
        baseDefense = 85,
        baseSpAtk = 74,
        baseSpDef = 55,
        baseSpeed = 32,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 69,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "clamperl", //Verify
        graphicsLocation = "clamperl", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ShellArmor,
            Ability.ShellArmor,
            Ability.Rattled,
        },
    };
    public static SpeciesData Huntail = new()
    {
        speciesName = "Huntail",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 104,
        baseDefense = 105,
        baseSpAtk = 94,
        baseSpDef = 75,
        baseSpeed = 52,
        evYield = Attack + Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 170,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "huntail", //Verify
        graphicsLocation = "huntail", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.SwiftSwim,
            Ability.WaterVeil,
        },
    };
    public static SpeciesData Gorebyss = new()
    {
        speciesName = "Gorebyss",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 84,
        baseDefense = 105,
        baseSpAtk = 114,
        baseSpDef = 75,
        baseSpeed = 52,
        evYield = 2 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Erratic,
        xpYield = 170,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water1,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "gorebyss", //Verify
        graphicsLocation = "gorebyss", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.SwiftSwim,
            Ability.Hydration,
        },
    };
    public static SpeciesData Relicanth = new()
    {
        speciesName = "Relicanth",
        type1 = Type.Water,
        type2 = Type.Rock,
        baseHP = 100,
        baseAttack = 90,
        baseDefense = 130,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = HP + Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 170,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 40,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "relicanth", //Verify
        graphicsLocation = "relicanth", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.RockHead,
            Ability.Sturdy,
        },
    };
    public static SpeciesData Luvdisc = new()
    {
        speciesName = "Luvdisc",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 43,
        baseAttack = 30,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 65,
        baseSpeed = 97,
        evYield = Speed,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Fast,
        xpYield = 116,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "luvdisc", //Verify
        graphicsLocation = "luvdisc", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SwiftSwim,
            Ability.SwiftSwim,
            Ability.Hydration,
        },
    };
    public static SpeciesData Bagon = new()
    {
        speciesName = "Bagon",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 45,
        baseAttack = 75,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 30,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Dragon,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "bagon", //Verify
        graphicsLocation = "bagon", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RockHead,
            Ability.RockHead,
            Ability.SheerForce,
        },
    };
    public static SpeciesData Shelgon = new()
    {
        speciesName = "Shelgon",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 100,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 147,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Dragon,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "shelgon", //Verify
        graphicsLocation = "shelgon", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.RockHead,
            Ability.RockHead,
            Ability.Overcoat,
        },
    };
    public static SpeciesData Salamence = new()
    {
        speciesName = "Salamence",
        type1 = Type.Dragon,
        type2 = Type.Flying,
        baseHP = 95,
        baseAttack = 135,
        baseDefense = 80,
        baseSpAtk = 110,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = 3 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Dragon,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "salamence", //Verify
        graphicsLocation = "salamence", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Intimidate,
            Ability.Intimidate,
            Ability.Moxie,
        },
    };
    public static SpeciesData Beldum = new()
    {
        speciesName = "Beldum",
        type1 = Type.Steel,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 55,
        baseDefense = 80,
        baseSpAtk = 35,
        baseSpDef = 60,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 60,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 40,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "beldum", //Verify
        graphicsLocation = "beldum", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.LightMetal,
        },
    };
    public static SpeciesData Metang = new()
    {
        speciesName = "Metang",
        type1 = Type.Steel,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 75,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 50,
        evYield = 2 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 147,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 40,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "metang", //Verify
        graphicsLocation = "metang", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.LightMetal,
        },
    };
    public static SpeciesData Metagross = new()
    {
        speciesName = "Metagross",
        type1 = Type.Steel,
        type2 = Type.Psychic,
        baseHP = 80,
        baseAttack = 135,
        baseDefense = 130,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 70,
        evYield = 3 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 40,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "metagross", //Verify
        graphicsLocation = "metagross", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.LightMetal,
        },
    };
    public static SpeciesData Regirock = new()
    {
        speciesName = "Regirock",
        type1 = Type.Rock,
        type2 = Type.Rock,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 200,
        baseSpAtk = 50,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = 3 * Defense,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "regirock", //Verify
        graphicsLocation = "regirock", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.Sturdy,
        },
    };
    public static SpeciesData Regice = new()
    {
        speciesName = "Regice",
        type1 = Type.Ice,
        type2 = Type.Ice,
        baseHP = 80,
        baseAttack = 50,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 200,
        baseSpeed = 50,
        evYield = 3 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "regice", //Verify
        graphicsLocation = "regice", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.IceBody,
        },
    };
    public static SpeciesData Registeel = new()
    {
        speciesName = "Registeel",
        type1 = Type.Steel,
        type2 = Type.Steel,
        baseHP = 80,
        baseAttack = 75,
        baseDefense = 150,
        baseSpAtk = 75,
        baseSpDef = 150,
        baseSpeed = 50,
        evYield = 2 * Defense + SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 261,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "registeel", //Verify
        graphicsLocation = "registeel", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.ClearBody,
            Ability.ClearBody,
            Ability.LightMetal,
        },
    };
    public static SpeciesData Latias = new()
    {
        speciesName = "Latias",
        type1 = Type.Dragon,
        type2 = Type.Psychic,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 110,
        baseSpDef = 130,
        baseSpeed = 110,
        evYield = 3 * SpDef,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 90,
        cryLocation = "latias", //Verify
        graphicsLocation = "latias", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Latios = new()
    {
        speciesName = "Latios",
        type1 = Type.Dragon,
        type2 = Type.Psychic,
        baseHP = 80,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 130,
        baseSpDef = 110,
        baseSpeed = 110,
        evYield = 3 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 90,
        cryLocation = "latios", //Verify
        graphicsLocation = "latios", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Levitate,
            Ability.Levitate,
            Ability.Levitate,
        },
    };
    public static SpeciesData Kyogre = new()
    {
        speciesName = "Kyogre",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 90,
        baseSpAtk = 150,
        baseSpDef = 140,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 302,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "kyogre", //Verify
        graphicsLocation = "kyogre", //Verify
        backSpriteHeight = 18,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Drizzle,
            Ability.Drizzle,
            Ability.Drizzle,
        },
    };
    public static SpeciesData Groudon = new()
    {
        speciesName = "Groudon",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 100,
        baseAttack = 150,
        baseDefense = 140,
        baseSpAtk = 100,
        baseSpDef = 90,
        baseSpeed = 90,
        evYield = 3 * Attack,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 302,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "groudon", //Verify
        graphicsLocation = "groudon", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.Drought,
            Ability.Drought,
            Ability.Drought,
        },
    };
    public static SpeciesData Rayquaza = new()
    {
        speciesName = "Rayquaza",
        type1 = Type.Dragon,
        type2 = Type.Flying,
        baseHP = 105,
        baseAttack = 150,
        baseDefense = 90,
        baseSpAtk = 150,
        baseSpDef = 90,
        baseSpeed = 95,
        evYield = 2 * Attack + SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 306,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 45,
        baseFriendship = 0,
        cryLocation = "rayquaza", //Verify
        graphicsLocation = "rayquaza", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.AirLock,
            Ability.AirLock,
            Ability.AirLock,
        },
    };
    public static SpeciesData Jirachi = new()
    {
        speciesName = "Jirachi",
        type1 = Type.Steel,
        type2 = Type.Psychic,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None, //Not done
        xpClass = XPClass.Slow,
        xpYield = 270,
        learnset = Learnset.EmptyLearnset, //Not done
        malePercent = SpeciesData.Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 100,
        cryLocation = "jirachi", //Verify
        graphicsLocation = "jirachi", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Ability.SereneGrace,
            Ability.SereneGrace,
            Ability.SereneGrace,
        },
    };

    public static SpeciesData Deoxys =
        SpeciesData.Deoxys(
            baseHP: 50,
            baseAttack: 150,
            baseDefense: 50,
            baseSpAtk: 150,
            baseSpDef: 50,
            baseSpeed: 150,
            evYield: Attack + Speed + SpAtk,
            graphics: "deoxys",
            backSpriteHeight: 6
        );




    //Forms

    //Megas

    public static SpeciesData VenusaurMega = SpeciesData.Mega(
        baseSpecies: Venusaur,
        baseAttack: 100,
        baseDefense: 123,
        baseSpAtk: 122,
        baseSpDef: 120,
        baseSpeed: 80,
        backSpriteHeight: 8,
        pokedexData: Pokedex.Venusaur, //Not done
        ability: Ability.ThickFat
    );

    public static SpeciesData CharizardMegaX = SpeciesData.Mega(
        baseSpecies: Charizard,
        name: "Mega Charizard X",
        type1: Type.Fire,
        type2: Type.Dragon,
        baseAttack: 130,
        baseDefense: 111,
        baseSpAtk: 130,
        baseSpDef: 85,
        baseSpeed: 100,
        cry: "mega_charizard_x",
        graphics: "charizard/mega_x",
        backSpriteHeight: 1,
        pokedexData: Pokedex.Charizard, //Not done
        ability: Ability.ToughClaws
    );

    public static SpeciesData CharizardMegaY= SpeciesData.Mega(
        baseSpecies: Charizard,
        name: "Mega Charizard Y",
        baseAttack: 104,
        baseDefense: 78,
        baseSpAtk: 159,
        baseSpDef: 115,
        baseSpeed: 100,
        cry: "mega_charizard_y",
        graphics: "charizard/mega_y",
        backSpriteHeight: 1,
        pokedexData: Pokedex.Charizard, //Not done
        ability: Ability.Drought
    );

    public static SpeciesData BlastoiseMega = SpeciesData.Mega(
        baseSpecies: Blastoise,
        baseAttack: 103,
        baseDefense: 120,
        baseSpAtk: 135,
        baseSpDef: 115,
        baseSpeed: 78,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Blastoise, //Not done
        ability: Ability.MegaLauncher
    );

    public static SpeciesData BeedrillMega = SpeciesData.Mega(
        baseSpecies: Beedrill,
        baseAttack: 150,
        baseDefense: 40,
        baseSpAtk: 15,
        baseSpDef: 80,
        baseSpeed: 145,
        backSpriteHeight: 5,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Adaptability
    );

    public static SpeciesData PidgeotMega = SpeciesData.Mega(
        baseSpecies: Pidgeot,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 121,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.NoGuard
    );

    public static SpeciesData AlakazamMega = SpeciesData.Mega(
        baseSpecies: Alakazam,
        baseAttack: 50,
        baseDefense: 65,
        baseSpAtk: 175,
        baseSpDef: 95,
        baseSpeed: 150,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Trace
    );

    public static SpeciesData SlowbroMega = SpeciesData.Mega(
        baseSpecies: Slowbro,
        baseAttack: 75,
        baseDefense: 180,
        baseSpAtk: 130,
        baseSpDef: 80,
        baseSpeed: 30,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.ShellArmor
    );

    public static SpeciesData GengarMega = SpeciesData.Mega(
        baseSpecies: Gengar,
        baseAttack: 65,
        baseDefense: 80,
        baseSpAtk: 170,
        baseSpDef: 95,
        baseSpeed: 130,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.ShadowTag
    );

    public static SpeciesData KangaskhanMega = SpeciesData.Mega(
        baseSpecies: Kangaskhan,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 100,
        baseSpeed: 100,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.ParentalBond
    );

    public static SpeciesData PinsirMega = SpeciesData.Mega(
        baseSpecies: Pinsir,
        type2: Type.Flying,
        baseAttack: 155,
        baseDefense: 120,
        baseSpAtk: 65,
        baseSpDef: 90,
        baseSpeed: 105,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Aerilate
    );

    public static SpeciesData GyaradosMega = SpeciesData.Mega(
        baseSpecies: Gyarados,
        type2: Type.Dark,
        baseAttack: 155,
        baseDefense: 109,
        baseSpAtk: 70,
        baseSpDef: 130,
        baseSpeed: 81,
        backSpriteHeight: 2,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.MoldBreaker
    );

    public static SpeciesData AerodactylMega = SpeciesData.Mega(
        baseSpecies: Aerodactyl,
        baseAttack: 135,
        baseDefense: 85,
        baseSpAtk: 70,
        baseSpDef: 95,
        baseSpeed: 150,
        backSpriteHeight: 8,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.ToughClaws
    );

    public static SpeciesData MewtwoMegaX = SpeciesData.Mega(
        baseSpecies: Mewtwo,
        name: "Mega Mewtwo X",
        type2: Type.Fighting,
        baseAttack: 190,
        baseDefense: 100,
        baseSpAtk: 154,
        baseSpDef: 100,
        baseSpeed: 130,
        backSpriteHeight: 1,
        cry: "mega_mewtwo_x",
        graphics: "mewtwo/mega_x",
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Steadfast
     );

    public static SpeciesData MewtwoMegaY = SpeciesData.Mega(
        baseSpecies: Mewtwo,
        name: "Mega Mewtwo Y",
        baseAttack: 150,
        baseDefense: 70,
        baseSpAtk: 194,
        baseSpDef: 120,
        baseSpeed: 140,
        backSpriteHeight: 2,
        cry: "mega_mewtwo_y",
        graphics: "mewtwo/mega_y",
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Insomnia
    );

    public static SpeciesData AmpharosMega = SpeciesData.Mega(
        baseSpecies: Ampharos,
        type2: Type.Dragon,
        baseAttack: 95,
        baseDefense: 105,
        baseSpAtk: 165,
        baseSpDef: 110,
        baseSpeed: 45,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.MoldBreaker
    );

    public static SpeciesData SteelixMega = SpeciesData.Mega(
        baseSpecies: Steelix,
        baseAttack: 125,
        baseDefense: 230,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 30,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done,
        ability: Ability.SandForce
    );

    public static SpeciesData ScizorMega = SpeciesData.Mega(
        baseSpecies: Scizor,
        baseAttack: 150,
        baseDefense: 140,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 75,
        backSpriteHeight: 4,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.Technician
    );

    public static SpeciesData HeracrossMega = SpeciesData.Mega(
        baseSpecies: Heracross,
        baseAttack: 185,
        baseDefense: 115,
        baseSpAtk: 40,
        baseSpDef: 105,
        baseSpeed: 75,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.SkillLink
    );

    public static SpeciesData HoundoomMega = SpeciesData.Mega(
        baseSpecies: Houndoom,
        baseAttack: 90,
        baseDefense: 90,
        baseSpAtk: 140,
        baseSpDef: 90,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.SolarPower
    );

    public static SpeciesData TyranitarMega = SpeciesData.Mega(
        baseSpecies: Tyranitar,
        baseAttack: 164,
        baseDefense: 150,
        baseSpAtk: 95,
        baseSpDef: 120,
        baseSpeed: 71,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Ability.SandStream
    );

    //Unown forms

    public static SpeciesData Unown_B
        = SpeciesData.Unown("unown/b", 9);
    public static SpeciesData Unown_C
        = SpeciesData.Unown("unown/c", 6);
    public static SpeciesData Unown_D
        = SpeciesData.Unown("unown/d", 8);
    public static SpeciesData Unown_E
        = SpeciesData.Unown("unown/e", 10);
    public static SpeciesData Unown_F
        = SpeciesData.Unown("unown/f", 10);
    public static SpeciesData Unown_G
        = SpeciesData.Unown("unown/g", 5);
    public static SpeciesData Unown_H
        = SpeciesData.Unown("unown/h", 8);
    public static SpeciesData Unown_I
        = SpeciesData.Unown("unown/i", 7);
    public static SpeciesData Unown_J
        = SpeciesData.Unown("unown/j", 9);
    public static SpeciesData Unown_K
        = SpeciesData.Unown("unown/k", 7);
    public static SpeciesData Unown_L
        = SpeciesData.Unown("unown/l", 10);
    public static SpeciesData Unown_M
        = SpeciesData.Unown("unown/m", 13);
    public static SpeciesData Unown_N
        = SpeciesData.Unown("unown/n", 13);
    public static SpeciesData Unown_O
        = SpeciesData.Unown("unown/o", 8);
    public static SpeciesData Unown_P
        = SpeciesData.Unown("unown/p", 10);
    public static SpeciesData Unown_Q
        = SpeciesData.Unown("unown/q", 15);
    public static SpeciesData Unown_R
        = SpeciesData.Unown("unown/r", 12);
    public static SpeciesData Unown_S
        = SpeciesData.Unown("unown/s", 4);
    public static SpeciesData Unown_T
        = SpeciesData.Unown("unown/t", 13);
    public static SpeciesData Unown_U
        = SpeciesData.Unown("unown/u", 13);
    public static SpeciesData Unown_V
        = SpeciesData.Unown("unown/v", 11);
    public static SpeciesData Unown_W
        = SpeciesData.Unown("unown/w", 13);
    public static SpeciesData Unown_X
        = SpeciesData.Unown("unown/x", 15);
    public static SpeciesData Unown_Y
        = SpeciesData.Unown("unown/y", 10);
    public static SpeciesData Unown_Z
        = SpeciesData.Unown("unown/z", 10);

    //Castform forms

    public static SpeciesData CastformSunny =
        SpeciesData.Castform(Type.Fire, "castform/sunny", 0);
    public static SpeciesData CastformRainy =
        SpeciesData.Castform(Type.Water, "castform/rainy", 0);
    public static SpeciesData CastformSnowy =
        SpeciesData.Castform(Type.Ice, "castform/snowy", 0);

    //Deoxys forms

    public static SpeciesData DeoxysAttack =
        SpeciesData.Deoxys(
            baseHP: 50,
            baseAttack: 180,
            baseDefense: 20,
            baseSpAtk: 180,
            baseSpDef: 20,
            baseSpeed: 150,
            evYield: Attack * 2 + SpAtk,
            graphics: "deoxys/attack",
            backSpriteHeight: 1
        );

    public static SpeciesData DeoxysDefense =
        SpeciesData.Deoxys(
            baseHP: 50,
            baseAttack: 70,
            baseDefense: 160,
            baseSpAtk: 70,
            baseSpDef: 160,
            baseSpeed: 90,
            evYield: Defense * 2 + SpDef,
            graphics: "deoxys/defense",
            backSpriteHeight: 8
        );

    public static SpeciesData DeoxysSpeed =
        SpeciesData.Deoxys(
            baseHP: 50,
            baseAttack: 95,
            baseDefense: 90,
            baseSpAtk: 95,
            baseSpDef: 90,
            baseSpeed: 180,
            evYield: Speed * 3,
            graphics: "deoxys/speed",
            backSpriteHeight: 0
        );

    public static SpeciesData[] SpeciesTable = new SpeciesData[(int)SpeciesID.Count] {
        Missingno,
        Bulbasaur,
        Ivysaur,
        Venusaur,
        Charmander,
        Charmeleon,
        Charizard,
        Squirtle,
        Wartortle,
        Blastoise,
        Caterpie,
        Metapod,
        Butterfree,
        Weedle,
        Kakuna,
        Beedrill,
        Pidgey,
        Pidgeotto,
        Pidgeot,
        Rattata,
        Raticate,
        Spearow,
        Fearow,
        Ekans,
        Arbok,
        Pikachu,
        Raichu,
        Sandshrew,
        Sandslash,
        NidoranF,
        Nidorina,
        Nidoqueen,
        NidoranM,
        Nidorino,
        Nidoking,
        Clefairy,
        Clefable,
        Vulpix,
        Ninetales,
        Jigglypuff,
        Wigglytuff,
        Zubat,
        Golbat,
        Oddish,
        Gloom,
        Vileplume,
        Paras,
        Parasect,
        Venonat,
        Venomoth,
        Diglett,
        Dugtrio,
        Meowth,
        Persian,
        Psyduck,
        Golduck,
        Mankey,
        Primeape,
        Growlithe,
        Arcanine,
        Poliwag,
        Poliwhirl,
        Poliwrath,
        Abra,
        Kadabra,
        Alakazam,
        Machop,
        Machoke,
        Machamp,
        Bellsprout,
        Weepinbell,
        Victreebel,
        Tentacool,
        Tentacruel,
        Geodude,
        Graveler,
        Golem,
        Ponyta,
        Rapidash,
        Slowpoke,
        Slowbro,
        Magnemite,
        Magneton,
        Farfetchd,
        Doduo,
        Dodrio,
        Seel,
        Dewgong,
        Grimer,
        Muk,
        Shellder,
        Cloyster,
        Gastly,
        Haunter,
        Gengar,
        Onix,
        Drowzee,
        Hypno,
        Krabby,
        Kingler,
        Voltorb,
        Electrode,
        Exeggcute,
        Exeggutor,
        Cubone,
        Marowak,
        Hitmonlee,
        Hitmonchan,
        Lickitung,
        Koffing,
        Weezing,
        Rhyhorn,
        Rhydon,
        Chansey,
        Tangela,
        Kangaskhan,
        Horsea,
        Seadra,
        Goldeen,
        Seaking,
        Staryu,
        Starmie,
        MrMime,
        Scyther,
        Jynx,
        Electabuzz,
        Magmar,
        Pinsir,
        Tauros,
        Magikarp,
        Gyarados,
        Lapras,
        Ditto,
        Eevee,
        Vaporeon,
        Jolteon,
        Flareon,
        Porygon,
        Omanyte,
        Omastar,
        Kabuto,
        Kabutops,
        Aerodactyl,
        Snorlax,
        Articuno,
        Zapdos,
        Moltres,
        Dratini,
        Dragonair,
        Dragonite,
        Mewtwo,
        Mew,

        //Gen 2
        Chikorita,
        Bayleef,
        Meganium,
        Cyndaquil,
        Quilava,
        Typhlosion,
        Totodile,
        Croconaw,
        Feraligatr,
        Sentret,
        Furret,
        Hoothoot,
        Noctowl,
        Ledyba,
        Ledian,
        Spinarak,
        Ariados,
        Crobat,
        Chinchou,
        Lanturn,
        Pichu,
        Cleffa,
        Igglybuff,
        Togepi,
        Togetic,
        Natu,
        Xatu,
        Mareep,
        Flaaffy,
        Ampharos,
        Bellossom,
        Marill,
        Azumarill,
        Sudowoodo,
        Politoed,
        Hoppip,
        Skiploom,
        Jumpluff,
        Aipom,
        Sunkern,
        Sunflora,
        Yanma,
        Wooper,
        Quagsire,
        Espeon,
        Umbreon,
        Murkrow,
        Slowking,
        Misdreavus,
        Unown,
        Wobbuffet,
        Girafarig,
        Pineco,
        Forretress,
        Dunsparce,
        Gligar,
        Steelix,
        Snubbull,
        Granbull,
        Qwilfish,
        Scizor,
        Shuckle,
        Heracross,
        Sneasel,
        Teddiursa,
        Ursaring,
        Slugma,
        Magcargo,
        Swinub,
        Piloswine,
        Corsola,
        Remoraid,
        Octillery,
        Delibird,
        Mantine,
        Skarmory,
        Houndour,
        Houndoom,
        Kingdra,
        Phanpy,
        Donphan,
        Porygon2,
        Stantler,
        Smeargle,
        Tyrogue,
        Hitmontop,
        Smoochum,
        Elekid,
        Magby,
        Miltank,
        Blissey,
        Raikou,
        Entei,
        Suicune,
        Larvitar,
        Pupitar,
        Tyranitar,
        Lugia,
        HoOh,
        Celebi,

        //Gen 3
        Treecko,
        Grovyle,
        Sceptile,
        Torchic,
        Combusken,
        Blaziken,
        Mudkip,
        Marshtomp,
        Swampert,
        Poochyena,
        Mightyena,
        Zigzagoon,
        Linoone,
        Wurmple,
        Silcoon,
        Beautifly,
        Cascoon,
        Dustox,
        Lotad,
        Lombre,
        Ludicolo,
        Seedot,
        Nuzleaf,
        Shiftry,
        Taillow,
        Swellow,
        Wingull,
        Pelipper,
        Ralts,
        Kirlia,
        Gardevoir,
        Surskit,
        Masquerain,
        Shroomish,
        Breloom,
        Slakoth,
        Vigoroth,
        Slaking,
        Nincada,
        Ninjask,
        Shedinja,
        Whismur,
        Loudred,
        Exploud,
        Makuhita,
        Hariyama,
        Azurill,
        Nosepass,
        Skitty,
        Delcatty,
        Sableye,
        Mawile,
        Aron,
        Lairon,
        Aggron,
        Meditite,
        Medicham,
        Electrike,
        Manectric,
        Plusle,
        Minun,
        Volbeat,
        Illumise,
        Roselia,
        Gulpin,
        Swalot,
        Carvanha,
        Sharpedo,
        Wailmer,
        Wailord,
        Numel,
        Camerupt,
        Torkoal,
        Spoink,
        Grumpig,
        Spinda,
        Trapinch,
        Vibrava,
        Flygon,
        Cacnea,
        Cacturne,
        Swablu,
        Altaria,
        Zangoose,
        Seviper,
        Lunatone,
        Solrock,
        Barboach,
        Whiscash,
        Corphish,
        Crawdaunt,
        Baltoy,
        Claydol,
        Lileep,
        Cradily,
        Anorith,
        Armaldo,
        Feebas,
        Milotic,
        Castform,
        Kecleon,
        Shuppet,
        Banette,
        Duskull,
        Dusclops,
        Tropius,
        Chimecho,
        Absol,
        Wynaut,
        Snorunt,
        Glalie,
        Spheal,
        Sealeo,
        Walrein,
        Clamperl,
        Huntail,
        Gorebyss,
        Relicanth,
        Luvdisc,
        Bagon,
        Shelgon,
        Salamence,
        Beldum,
        Metang,
        Metagross,
        Regirock,
        Regice,
        Registeel,
        Latias,
        Latios,
        Kyogre,
        Groudon,
        Rayquaza,
        Jirachi,
        Deoxys,

        //Forms

        Unown_B,
        Unown_C,
        Unown_D,
        Unown_E,
        Unown_F,
        Unown_G,
        Unown_H,
        Unown_I,
        Unown_J,
        Unown_K,
        Unown_L,
        Unown_M,
        Unown_N,
        Unown_O,
        Unown_P,
        Unown_Q,
        Unown_R,
        Unown_S,
        Unown_T,
        Unown_U,
        Unown_V,
        Unown_W,
        Unown_X,
        Unown_Y,
        Unown_Z,

        CastformSunny,
        CastformRainy,
        CastformSnowy,

        DeoxysAttack,
        DeoxysDefense,
        DeoxysSpeed,

        //Megas

        VenusaurMega,
        CharizardMegaX,
        CharizardMegaY,
        BlastoiseMega,
        BeedrillMega,
        PidgeotMega,
        AlakazamMega,
        SlowbroMega,
        GengarMega,
        KangaskhanMega,
        PinsirMega,
        GyaradosMega,
        AerodactylMega,
        MewtwoMegaX,
        MewtwoMegaY,
        AmpharosMega,
        SteelixMega,
        ScizorMega,
        HeracrossMega,
        HoundoomMega,
        TyranitarMega,
    };
}