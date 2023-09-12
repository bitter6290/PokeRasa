using Unity.VisualScripting;

public static class Species
{
    public static SpeciesData Missingno = new()
    {
        id = SpeciesID.Missingno,
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
        id = SpeciesID.Bulbasaur,
        speciesName = "Bulbasaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 49,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Ivysaur,
        speciesName = "Ivysaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 63,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = EvYield.SpAtk + EvYield.SpDef,
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
        id = SpeciesID.Venusaur,
        speciesName = "Venusaur",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 83,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 2 * EvYield.SpAtk + EvYield.SpDef,
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
        id = SpeciesID.Charmander,
        speciesName = "Charmander",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Charmeleon,
        speciesName = "Charmeleon",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = EvYield.Speed + EvYield.SpAtk,
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
        id = SpeciesID.Charizard,
        speciesName = "Charizard",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Squirtle,
        speciesName = "Squirtle",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 44,
        baseAttack = 48,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 64,
        baseSpeed = 43,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Wartortle,
        speciesName = "Wartortle",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 59,
        baseAttack = 63,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 58,
        evYield = EvYield.Defense + EvYield.SpDef,
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
        id = SpeciesID.Blastoise,
        speciesName = "Blastoise",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 79,
        baseAttack = 83,
        baseDefense = 100,
        baseSpAtk = 85,
        baseSpDef = 105,
        baseSpeed = 78,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Caterpie,
        speciesName = "Caterpie",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 45,
        evYield = EvYield.HP,
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
        id = SpeciesID.Metapod,
        speciesName = "Metapod",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 20,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 30,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Butterfree,
        speciesName = "Butterfree",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 70,
        evYield = 2 * EvYield.SpAtk + EvYield.SpDef,
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
        id = SpeciesID.Weedle,
        speciesName = "Weedle",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 50,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Kakuna,
        speciesName = "Kakuna",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 25,
        baseDefense = 50,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 35,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Beedrill,
        speciesName = "Beedrill",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 40,
        baseSpAtk = 45,
        baseSpDef = 80,
        baseSpeed = 75,
        evYield = 2 * EvYield.Attack + EvYield.SpDef,
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
        id = SpeciesID.Pidgey,
        speciesName = "Pidgey",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 56,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Pidgeotto,
        speciesName = "Pidgeotto",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 63,
        baseAttack = 60,
        baseDefense = 55,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 71,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Pidgeot,
        speciesName = "Pidgeot",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 83,
        baseAttack = 80,
        baseDefense = 75,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 91,
        evYield = 3 * EvYield.Speed,
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
        id = SpeciesID.Rattata,
        speciesName = "Rattata",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 30,
        baseAttack = 56,
        baseDefense = 35,
        baseSpAtk = 25,
        baseSpDef = 35,
        baseSpeed = 72,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Raticate,
        speciesName = "Raticate",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 81,
        baseDefense = 60,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 97,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Spearow,
        speciesName = "Spearow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 31,
        baseSpDef = 31,
        baseSpeed = 70,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Fearow,
        speciesName = "Fearow",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 65,
        baseSpAtk = 61,
        baseSpDef = 61,
        baseSpeed = 100,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Ekans,
        speciesName = "Ekans",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 35,
        baseAttack = 60,
        baseDefense = 44,
        baseSpAtk = 40,
        baseSpDef = 54,
        baseSpeed = 55,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Arbok,
        speciesName = "Arbok",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 69,
        baseSpAtk = 65,
        baseSpDef = 79,
        baseSpeed = 80,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Pikachu,
        speciesName = "Pikachu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 35,
        baseAttack = 55,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Raichu,
        speciesName = "Raichu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 55,
        baseSpAtk = 90,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = 3 * EvYield.Speed,
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
        id = SpeciesID.Sandshrew,
        speciesName = "Sandshrew",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Sandslash,
        speciesName = "Sandslash",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 110,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.NidoranF,
        speciesName = "Nidoran",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 55,
        baseAttack = 47,
        baseDefense = 52,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 41,
        evYield = EvYield.HP,
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
        id = SpeciesID.Nidorina,
        speciesName = "Nidorina",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 62,
        baseDefense = 67,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 56,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Nidoqueen,
        speciesName = "Nidoqueen",
        type1 = Type.Poison,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 82,
        baseDefense = 87,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 76,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.NidoranM,
        speciesName = "Nidoran",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 46,
        baseAttack = 57,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 50,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Nidorino,
        speciesName = "Nidorino",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 61,
        baseAttack = 72,
        baseDefense = 57,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Nidoking,
        speciesName = "Nidoking",
        type1 = Type.Poison,
        type2 = Type.Ground,
        baseHP = 81,
        baseAttack = 92,
        baseDefense = 77,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 85,
        evYield = 3 * EvYield.Attack,
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
        id = SpeciesID.Clefairy,
        speciesName = "Clefairy",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 70,
        baseAttack = 45,
        baseDefense = 48,
        baseSpAtk = 60,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Clefable,
        speciesName = "Clefable",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 95,
        baseAttack = 70,
        baseDefense = 73,
        baseSpAtk = 85,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.Vulpix,
        speciesName = "Vulpix",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 38,
        baseAttack = 41,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Ninetales,
        speciesName = "Ninetales",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 73,
        baseAttack = 76,
        baseDefense = 75,
        baseSpAtk = 81,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = EvYield.Speed + EvYield.SpDef,
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
        id = SpeciesID.Jigglypuff,
        speciesName = "Jigglypuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 115,
        baseAttack = 45,
        baseDefense = 20,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 20,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Wigglytuff,
        speciesName = "Wigglytuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 140,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 75,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.Zubat,
        speciesName = "Zubat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 30,
        baseSpDef = 40,
        baseSpeed = 55,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Golbat,
        speciesName = "Golbat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Oddish,
        speciesName = "Oddish",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 55,
        baseSpAtk = 75,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Gloom,
        speciesName = "Gloom",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Vileplume,
        speciesName = "Vileplume",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 85,
        baseSpAtk = 100,
        baseSpDef = 90,
        baseSpeed = 50,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Paras,
        speciesName = "Paras",
        type1 = Type.Bug,
        type2 = Type.Grass,
        baseHP = 35,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 25,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Parasect,
        speciesName = "Parasect",
        type1 = Type.Bug,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * EvYield.Attack + EvYield.Defense,
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
        id = SpeciesID.Venonat,
        speciesName = "Venonat",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Venomoth,
        speciesName = "Venomoth",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = EvYield.Speed + EvYield.SpAtk,
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
        id = SpeciesID.Diglett,
        speciesName = "Diglett",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 10,
        baseAttack = 55,
        baseDefense = 25,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Dugtrio,
        speciesName = "Dugtrio",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 35,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 120,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Meowth,
        speciesName = "Meowth",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Persian,
        speciesName = "Persian",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 65,
        baseAttack = 70,
        baseDefense = 60,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 115,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Psyduck,
        speciesName = "Psyduck",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 50,
        baseAttack = 52,
        baseDefense = 48,
        baseSpAtk = 65,
        baseSpDef = 50,
        baseSpeed = 55,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Golduck,
        speciesName = "Golduck",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 78,
        baseSpAtk = 95,
        baseSpDef = 80,
        baseSpeed = 85,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Mankey,
        speciesName = "Mankey",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Primeape,
        speciesName = "Primeape",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 65,
        baseAttack = 105,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Growlithe,
        speciesName = "Growlithe",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 50,
        baseSpeed = 60,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Arcanine,
        speciesName = "Arcanine",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 90,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Poliwag,
        speciesName = "Poliwag",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Poliwhirl,
        speciesName = "Poliwhirl",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Poliwrath,
        speciesName = "Poliwrath",
        type1 = Type.Water,
        type2 = Type.Fighting,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 70,
        baseSpDef = 90,
        baseSpeed = 70,
        evYield = 3 * EvYield.Defense,
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
        id = SpeciesID.Abra,
        speciesName = "Abra",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 25,
        baseAttack = 20,
        baseDefense = 15,
        baseSpAtk = 105,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Kadabra,
        speciesName = "Kadabra",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 105,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Alakazam,
        speciesName = "Alakazam",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 55,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 135,
        baseSpDef = 85,
        baseSpeed = 120,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Machop,
        speciesName = "Machop",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Machoke,
        speciesName = "Machoke",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Machamp,
        speciesName = "Machamp",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 85,
        baseSpeed = 55,
        evYield = 3 * EvYield.Attack,
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
        id = SpeciesID.Bellsprout,
        speciesName = "Bellsprout",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Weepinbell,
        speciesName = "Weepinbell",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Victreebel,
        speciesName = "Victreebel",
        type1 = Type.Grass,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 3 * EvYield.Attack,
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
        id = SpeciesID.Tentacool,
        speciesName = "Tentacool",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 35,
        baseSpAtk = 50,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Tentacruel,
        speciesName = "Tentacruel",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 70,
        baseDefense = 65,
        baseSpAtk = 80,
        baseSpDef = 120,
        baseSpeed = 100,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Geodude,
        speciesName = "Geodude",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 100,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 20,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Graveler,
        speciesName = "Graveler",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 115,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Golem,
        speciesName = "Golem",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 80,
        baseAttack = 110,
        baseDefense = 130,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = 3 * EvYield.Defense,
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
        id = SpeciesID.Ponyta,
        speciesName = "Ponyta",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 55,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 90,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Rapidash,
        speciesName = "Rapidash",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Slowpoke,
        speciesName = "Slowpoke",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 90,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 15,
        evYield = EvYield.HP,
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
        id = SpeciesID.Slowbro,
        speciesName = "Slowbro",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 110,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Magnemite,
        speciesName = "Magnemite",
        type1 = Type.Electric,
        type2 = Type.Steel,
        baseHP = 25,
        baseAttack = 35,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Magneton,
        speciesName = "Magneton",
        type1 = Type.Electric,
        type2 = Type.Steel,
        baseHP = 50,
        baseAttack = 60,
        baseDefense = 95,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Farfetchd,
        speciesName = "Farfetchd",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 52,
        baseAttack = 65,
        baseDefense = 55,
        baseSpAtk = 58,
        baseSpDef = 62,
        baseSpeed = 60,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Doduo,
        speciesName = "Doduo",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 35,
        baseAttack = 85,
        baseDefense = 45,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 75,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Dodrio,
        speciesName = "Dodrio",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 110,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 100,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Seel,
        speciesName = "Seel",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 70,
        baseSpeed = 45,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Dewgong,
        speciesName = "Dewgong",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 90,
        baseAttack = 70,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 95,
        baseSpeed = 70,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Grimer,
        speciesName = "Grimer",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 25,
        evYield = EvYield.HP,
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
        id = SpeciesID.Muk,
        speciesName = "Muk",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 105,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 65,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = EvYield.HP + EvYield.Attack,
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
        id = SpeciesID.Shellder,
        speciesName = "Shellder",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 65,
        baseDefense = 100,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 40,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Cloyster,
        speciesName = "Cloyster",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 180,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Gastly,
        speciesName = "Gastly",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 30,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 100,
        baseSpDef = 35,
        baseSpeed = 80,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Haunter,
        speciesName = "Haunter",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 115,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Gengar,
        speciesName = "Gengar",
        type1 = Type.Ghost,
        type2 = Type.Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 75,
        baseSpeed = 110,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Onix,
        speciesName = "Onix",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 35,
        baseAttack = 45,
        baseDefense = 160,
        baseSpAtk = 30,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Drowzee,
        speciesName = "Drowzee",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 48,
        baseDefense = 45,
        baseSpAtk = 43,
        baseSpDef = 90,
        baseSpeed = 42,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Hypno,
        speciesName = "Hypno",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 85,
        baseAttack = 73,
        baseDefense = 70,
        baseSpAtk = 73,
        baseSpDef = 115,
        baseSpeed = 67,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Krabby,
        speciesName = "Krabby",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 105,
        baseDefense = 90,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 50,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Kingler,
        speciesName = "Kingler",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 130,
        baseDefense = 115,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Voltorb,
        speciesName = "Voltorb",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 100,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Electrode,
        speciesName = "Electrode",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 140,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Exeggcute,
        speciesName = "Exeggcute",
        type1 = Type.Grass,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Exeggutor,
        speciesName = "Exeggutor",
        type1 = Type.Grass,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Cubone,
        speciesName = "Cubone",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 35,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Marowak,
        speciesName = "Marowak",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 110,
        baseSpAtk = 50,
        baseSpDef = 80,
        baseSpeed = 45,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Hitmonlee,
        speciesName = "Hitmonlee",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 120,
        baseDefense = 53,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 87,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Hitmonchan,
        speciesName = "Hitmonchan",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 105,
        baseDefense = 79,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 76,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Lickitung,
        speciesName = "Lickitung",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 55,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 30,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Koffing,
        speciesName = "Koffing",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Weezing,
        speciesName = "Weezing",
        type1 = Type.Poison,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 120,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 60,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Rhyhorn,
        speciesName = "Rhyhorn",
        type1 = Type.Ground,
        type2 = Type.Rock,
        baseHP = 80,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 25,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Rhydon,
        speciesName = "Rhydon",
        type1 = Type.Ground,
        type2 = Type.Rock,
        baseHP = 105,
        baseAttack = 130,
        baseDefense = 120,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Chansey,
        speciesName = "Chansey",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 250,
        baseAttack = 5,
        baseDefense = 5,
        baseSpAtk = 35,
        baseSpDef = 105,
        baseSpeed = 50,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Tangela,
        speciesName = "Tangela",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 65,
        baseAttack = 55,
        baseDefense = 115,
        baseSpAtk = 100,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Kangaskhan,
        speciesName = "Kangaskhan",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 105,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 90,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Horsea,
        speciesName = "Horsea",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 70,
        baseSpDef = 25,
        baseSpeed = 60,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Seadra,
        speciesName = "Seadra",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 55,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 45,
        baseSpeed = 85,
        evYield = EvYield.Defense + EvYield.SpAtk,
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
        id = SpeciesID.Goldeen,
        speciesName = "Goldeen",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 45,
        baseAttack = 67,
        baseDefense = 60,
        baseSpAtk = 35,
        baseSpDef = 50,
        baseSpeed = 63,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Seaking,
        speciesName = "Seaking",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 80,
        baseAttack = 92,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 68,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Staryu,
        speciesName = "Staryu",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Starmie,
        speciesName = "Starmie",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 60,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 115,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.MrMime,
        speciesName = "Mr. Mime",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 120,
        baseSpeed = 90,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Scyther,
        speciesName = "Scyther",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Jynx,
        speciesName = "Jynx",
        type1 = Type.Ice,
        type2 = Type.Psychic,
        baseHP = 65,
        baseAttack = 50,
        baseDefense = 35,
        baseSpAtk = 115,
        baseSpDef = 95,
        baseSpeed = 95,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Electabuzz,
        speciesName = "Electabuzz",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 65,
        baseAttack = 83,
        baseDefense = 57,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 105,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Magmar,
        speciesName = "Magmar",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 57,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 93,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Pinsir,
        speciesName = "Pinsir",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 65,
        baseAttack = 125,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 70,
        baseSpeed = 85,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Tauros,
        speciesName = "Tauros",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 110,
        evYield = EvYield.Attack + EvYield.Speed,
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
        id = SpeciesID.Magikarp,
        speciesName = "Magikarp",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 55,
        baseSpAtk = 15,
        baseSpDef = 20,
        baseSpeed = 80,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Gyarados,
        speciesName = "Gyarados",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 95,
        baseAttack = 125,
        baseDefense = 79,
        baseSpAtk = 60,
        baseSpDef = 100,
        baseSpeed = 81,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Lapras,
        speciesName = "Lapras",
        type1 = Type.Water,
        type2 = Type.Ice,
        baseHP = 130,
        baseAttack = 85,
        baseDefense = 80,
        baseSpAtk = 85,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Ditto,
        speciesName = "Ditto",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 48,
        baseAttack = 48,
        baseDefense = 48,
        baseSpAtk = 48,
        baseSpDef = 48,
        baseSpeed = 48,
        evYield = EvYield.HP,
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
        id = SpeciesID.Eevee,
        speciesName = "Eevee",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Vaporeon,
        speciesName = "Vaporeon",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 130,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 65,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Jolteon,
        speciesName = "Jolteon",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 130,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Flareon,
        speciesName = "Flareon",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 65,
        baseAttack = 130,
        baseDefense = 60,
        baseSpAtk = 95,
        baseSpDef = 110,
        baseSpeed = 65,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Porygon,
        speciesName = "Porygon",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 65,
        baseAttack = 60,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Omanyte,
        speciesName = "Omanyte",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 35,
        baseAttack = 40,
        baseDefense = 100,
        baseSpAtk = 90,
        baseSpDef = 55,
        baseSpeed = 35,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Omastar,
        speciesName = "Omastar",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 70,
        baseAttack = 60,
        baseDefense = 125,
        baseSpAtk = 115,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Kabuto,
        speciesName = "Kabuto",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 30,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 55,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Kabutops,
        speciesName = "Kabutops",
        type1 = Type.Rock,
        type2 = Type.Water,
        baseHP = 60,
        baseAttack = 115,
        baseDefense = 105,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 80,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Aerodactyl,
        speciesName = "Aerodactyl",
        type1 = Type.Rock,
        type2 = Type.Flying,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 130,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Snorlax,
        speciesName = "Snorlax",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 160,
        baseAttack = 110,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Articuno,
        speciesName = "Articuno",
        type1 = Type.Ice,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 125,
        baseSpeed = 85,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Zapdos,
        speciesName = "Zapdos",
        type1 = Type.Electric,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 90,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 90,
        baseSpeed = 100,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Moltres,
        speciesName = "Moltres",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 90,
        baseAttack = 100,
        baseDefense = 90,
        baseSpAtk = 125,
        baseSpDef = 85,
        baseSpeed = 90,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Dratini,
        speciesName = "Dratini",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 41,
        baseAttack = 64,
        baseDefense = 45,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Dragonair,
        speciesName = "Dragonair",
        type1 = Type.Dragon,
        type2 = Type.Dragon,
        baseHP = 61,
        baseAttack = 84,
        baseDefense = 65,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Dragonite,
        speciesName = "Dragonite",
        type1 = Type.Dragon,
        type2 = Type.Flying,
        baseHP = 91,
        baseAttack = 134,
        baseDefense = 95,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 3 * EvYield.Attack,
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
        id = SpeciesID.Mewtwo,
        speciesName = "Mewtwo",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 106,
        baseAttack = 110,
        baseDefense = 90,
        baseSpAtk = 154,
        baseSpDef = 90,
        baseSpeed = 130,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Mew,
        speciesName = "Mew",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.Chikorita,
        speciesName = "Chikorita",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 65,
        baseSpAtk = 49,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Bayleef,
        speciesName = "Bayleef",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 80,
        baseSpAtk = 63,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = EvYield.Defense + EvYield.SpDef,
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
        id = SpeciesID.Meganium,
        speciesName = "Meganium",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 100,
        baseSpAtk = 83,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = EvYield.Defense + 2 * EvYield.SpDef,
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
        id = SpeciesID.Cyndaquil,
        speciesName = "Cyndaquil",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Quilava,
        speciesName = "Quilava",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = EvYield.Speed + EvYield.SpAtk,
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
        id = SpeciesID.Typhlosion,
        speciesName = "Typhlosion",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Totodile,
        speciesName = "Totodile",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 64,
        baseSpAtk = 44,
        baseSpDef = 48,
        baseSpeed = 43,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Croconaw,
        speciesName = "Croconaw",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 59,
        baseSpDef = 63,
        baseSpeed = 58,
        evYield = EvYield.Attack + EvYield.Defense,
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
        id = SpeciesID.Feraligatr,
        speciesName = "Feraligatr",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 85,
        baseAttack = 105,
        baseDefense = 100,
        baseSpAtk = 79,
        baseSpDef = 83,
        baseSpeed = 78,
        evYield = 2 * EvYield.Attack + EvYield.Defense,
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
        id = SpeciesID.Sentret,
        speciesName = "Sentret",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 35,
        baseAttack = 46,
        baseDefense = 34,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 20,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Furret,
        speciesName = "Furret",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 85,
        baseAttack = 76,
        baseDefense = 64,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Hoothoot,
        speciesName = "Hoothoot",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 36,
        baseSpDef = 56,
        baseSpeed = 50,
        evYield = EvYield.HP,
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
        id = SpeciesID.Noctowl,
        speciesName = "Noctowl",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 76,
        baseSpDef = 96,
        baseSpeed = 70,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Ledyba,
        speciesName = "Ledyba",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 20,
        baseDefense = 30,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 55,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Ledian,
        speciesName = "Ledian",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 35,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 110,
        baseSpeed = 85,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Spinarak,
        speciesName = "Spinarak",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Ariados,
        speciesName = "Ariados",
        type1 = Type.Bug,
        type2 = Type.Poison,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Crobat,
        speciesName = "Crobat",
        type1 = Type.Poison,
        type2 = Type.Flying,
        baseHP = 85,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 130,
        evYield = 3 * EvYield.Speed,
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
        id = SpeciesID.Chinchou,
        speciesName = "Chinchou",
        type1 = Type.Water,
        type2 = Type.Electric,
        baseHP = 75,
        baseAttack = 38,
        baseDefense = 38,
        baseSpAtk = 56,
        baseSpDef = 56,
        baseSpeed = 67,
        evYield = EvYield.HP,
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
        id = SpeciesID.Lanturn,
        speciesName = "Lanturn",
        type1 = Type.Water,
        type2 = Type.Electric,
        baseHP = 125,
        baseAttack = 58,
        baseDefense = 58,
        baseSpAtk = 76,
        baseSpDef = 76,
        baseSpeed = 67,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Pichu,
        speciesName = "Pichu",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 20,
        baseAttack = 40,
        baseDefense = 15,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 60,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Cleffa,
        speciesName = "Cleffa",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 50,
        baseAttack = 25,
        baseDefense = 28,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 15,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Igglybuff,
        speciesName = "Igglybuff",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 40,
        baseSpDef = 20,
        baseSpeed = 15,
        evYield = EvYield.HP,
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
        id = SpeciesID.Togepi,
        speciesName = "Togepi",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 35,
        baseAttack = 20,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 65,
        baseSpeed = 20,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Togetic,
        speciesName = "Togetic",
        type1 = Type.Normal,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 85,
        baseSpAtk = 80,
        baseSpDef = 105,
        baseSpeed = 40,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Natu,
        speciesName = "Natu",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Xatu,
        speciesName = "Xatu",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = EvYield.Speed + EvYield.SpAtk,
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
        id = SpeciesID.Mareep,
        speciesName = "Mareep",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Flaaffy,
        speciesName = "Flaaffy",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 70,
        baseAttack = 55,
        baseDefense = 55,
        baseSpAtk = 80,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Ampharos,
        speciesName = "Ampharos",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 115,
        baseSpDef = 90,
        baseSpeed = 55,
        evYield = 3 * EvYield.SpAtk,
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
        id = SpeciesID.Bellossom,
        speciesName = "Bellossom",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Marill,
        speciesName = "Marill",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 70,
        baseAttack = 20,
        baseDefense = 50,
        baseSpAtk = 20,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Azumarill,
        speciesName = "Azumarill",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 80,
        baseSpAtk = 50,
        baseSpDef = 80,
        baseSpeed = 50,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.Sudowoodo,
        speciesName = "Sudowoodo",
        type1 = Type.Rock,
        type2 = Type.Rock,
        baseHP = 70,
        baseAttack = 100,
        baseDefense = 115,
        baseSpAtk = 30,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Politoed,
        speciesName = "Politoed",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Hoppip,
        speciesName = "Hoppip",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Skiploom,
        speciesName = "Skiploom",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = 2 * EvYield.Speed,
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
        id = SpeciesID.Jumpluff,
        speciesName = "Jumpluff",
        type1 = Type.Grass,
        type2 = Type.Flying,
        baseHP = 75,
        baseAttack = 55,
        baseDefense = 70,
        baseSpAtk = 55,
        baseSpDef = 85,
        baseSpeed = 110,
        evYield = 3 * EvYield.Speed,
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
        id = SpeciesID.Aipom,
        speciesName = "Aipom",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Sunkern,
        speciesName = "Sunkern",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 30,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 30,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Sunflora,
        speciesName = "Sunflora",
        type1 = Type.Grass,
        type2 = Type.Grass,
        baseHP = 75,
        baseAttack = 75,
        baseDefense = 55,
        baseSpAtk = 105,
        baseSpDef = 85,
        baseSpeed = 30,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Yanma,
        speciesName = "Yanma",
        type1 = Type.Bug,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 75,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Wooper,
        speciesName = "Wooper",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 45,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = EvYield.HP,
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
        id = SpeciesID.Quagsire,
        speciesName = "Quagsire",
        type1 = Type.Water,
        type2 = Type.Ground,
        baseHP = 95,
        baseAttack = 85,
        baseDefense = 85,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Espeon,
        speciesName = "Espeon",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 95,
        baseSpeed = 110,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Umbreon,
        speciesName = "Umbreon",
        type1 = Type.Dark,
        type2 = Type.Dark,
        baseHP = 95,
        baseAttack = 65,
        baseDefense = 110,
        baseSpAtk = 60,
        baseSpDef = 130,
        baseSpeed = 65,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Murkrow,
        speciesName = "Murkrow",
        type1 = Type.Dark,
        type2 = Type.Flying,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 42,
        baseSpAtk = 85,
        baseSpDef = 42,
        baseSpeed = 91,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Slowking,
        speciesName = "Slowking",
        type1 = Type.Water,
        type2 = Type.Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Misdreavus,
        speciesName = "Misdreavus",
        type1 = Type.Ghost,
        type2 = Type.Ghost,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 85,
        baseSpDef = 85,
        baseSpeed = 85,
        evYield = EvYield.SpDef,
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
        id = SpeciesID.Unown,
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
        id = SpeciesID.Wobbuffet,
        speciesName = "Wobbuffet",
        type1 = Type.Psychic,
        type2 = Type.Psychic,
        baseHP = 190,
        baseAttack = 33,
        baseDefense = 58,
        baseSpAtk = 33,
        baseSpDef = 58,
        baseSpeed = 33,
        evYield = 2 * EvYield.HP,
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
        id = SpeciesID.Girafarig,
        speciesName = "Girafarig",
        type1 = Type.Normal,
        type2 = Type.Psychic,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 65,
        baseSpAtk = 90,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Pineco,
        speciesName = "Pineco",
        type1 = Type.Bug,
        type2 = Type.Bug,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 90,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 15,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Forretress,
        speciesName = "Forretress",
        type1 = Type.Bug,
        type2 = Type.Steel,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 140,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Dunsparce,
        speciesName = "Dunsparce",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 100,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = EvYield.HP,
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
        id = SpeciesID.Gligar,
        speciesName = "Gligar",
        type1 = Type.Ground,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 105,
        baseSpAtk = 35,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = EvYield.Defense,
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
        id = SpeciesID.Steelix,
        speciesName = "Steelix",
        type1 = Type.Steel,
        type2 = Type.Ground,
        baseHP = 75,
        baseAttack = 85,
        baseDefense = 200,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Snubbull,
        speciesName = "Snubbull",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Granbull,
        speciesName = "Granbull",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Qwilfish,
        speciesName = "Qwilfish",
        type1 = Type.Water,
        type2 = Type.Poison,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 75,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Scizor,
        speciesName = "Scizor",
        type1 = Type.Bug,
        type2 = Type.Steel,
        baseHP = 70,
        baseAttack = 130,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Shuckle,
        speciesName = "Shuckle",
        type1 = Type.Bug,
        type2 = Type.Rock,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 230,
        baseSpAtk = 10,
        baseSpDef = 230,
        baseSpeed = 5,
        evYield = EvYield.Defense + EvYield.SpDef,
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
        id = SpeciesID.Heracross,
        speciesName = "Heracross",
        type1 = Type.Bug,
        type2 = Type.Fighting,
        baseHP = 80,
        baseAttack = 125,
        baseDefense = 75,
        baseSpAtk = 40,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Sneasel,
        speciesName = "Sneasel",
        type1 = Type.Dark,
        type2 = Type.Ice,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 55,
        baseSpAtk = 35,
        baseSpDef = 75,
        baseSpeed = 115,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Teddiursa,
        speciesName = "Teddiursa",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Ursaring,
        speciesName = "Ursaring",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 75,
        baseSpAtk = 75,
        baseSpDef = 75,
        baseSpeed = 55,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Slugma,
        speciesName = "Slugma",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 70,
        baseSpDef = 40,
        baseSpeed = 20,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Magcargo,
        speciesName = "Magcargo",
        type1 = Type.Fire,
        type2 = Type.Rock,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 120,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Swinub,
        speciesName = "Swinub",
        type1 = Type.Ice,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 50,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Piloswine,
        speciesName = "Piloswine",
        type1 = Type.Ice,
        type2 = Type.Ground,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = EvYield.HP + EvYield.Attack,
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
        id = SpeciesID.Corsola,
        speciesName = "Corsola",
        type1 = Type.Water,
        type2 = Type.Rock,
        baseHP = 55,
        baseAttack = 55,
        baseDefense = 85,
        baseSpAtk = 65,
        baseSpDef = 85,
        baseSpeed = 35,
        evYield = EvYield.Defense + EvYield.SpDef,
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
        id = SpeciesID.Remoraid,
        speciesName = "Remoraid",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 35,
        baseAttack = 65,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 35,
        baseSpeed = 65,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Octillery,
        speciesName = "Octillery",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 75,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 105,
        baseSpDef = 75,
        baseSpeed = 45,
        evYield = EvYield.Attack + EvYield.SpAtk,
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
        id = SpeciesID.Delibird,
        speciesName = "Delibird",
        type1 = Type.Ice,
        type2 = Type.Flying,
        baseHP = 45,
        baseAttack = 55,
        baseDefense = 45,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Mantine,
        speciesName = "Mantine",
        type1 = Type.Water,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 140,
        baseSpeed = 70,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Skarmory,
        speciesName = "Skarmory",
        type1 = Type.Steel,
        type2 = Type.Flying,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 140,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Houndour,
        speciesName = "Houndour",
        type1 = Type.Dark,
        type2 = Type.Fire,
        baseHP = 45,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 80,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Houndoom,
        speciesName = "Houndoom",
        type1 = Type.Dark,
        type2 = Type.Fire,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 110,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Kingdra,
        speciesName = "Kingdra",
        type1 = Type.Water,
        type2 = Type.Dragon,
        baseHP = 75,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = EvYield.Attack + EvYield.SpAtk + EvYield.SpDef,
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
        id = SpeciesID.Phanpy,
        speciesName = "Phanpy",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 40,
        evYield = EvYield.HP,
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
        id = SpeciesID.Donphan,
        speciesName = "Donphan",
        type1 = Type.Ground,
        type2 = Type.Ground,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 120,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = EvYield.Attack + EvYield.Defense,
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
        id = SpeciesID.Porygon2,
        speciesName = "Porygon2",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 85,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 105,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * EvYield.SpAtk,
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
        id = SpeciesID.Stantler,
        speciesName = "Stantler",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 73,
        baseAttack = 95,
        baseDefense = 62,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Smeargle,
        speciesName = "Smeargle",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 55,
        baseAttack = 20,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Tyrogue,
        speciesName = "Tyrogue",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Hitmontop,
        speciesName = "Hitmontop",
        type1 = Type.Fighting,
        type2 = Type.Fighting,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 70,
        evYield = 2 * EvYield.SpDef,
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
        id = SpeciesID.Smoochum,
        speciesName = "Smoochum",
        type1 = Type.Ice,
        type2 = Type.Psychic,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = EvYield.SpAtk,
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
        id = SpeciesID.Elekid,
        speciesName = "Elekid",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 45,
        baseAttack = 63,
        baseDefense = 37,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Magby,
        speciesName = "Magby",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 45,
        baseAttack = 75,
        baseDefense = 37,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 83,
        evYield = EvYield.Speed,
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
        id = SpeciesID.Miltank,
        speciesName = "Miltank",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 95,
        baseAttack = 80,
        baseDefense = 105,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 100,
        evYield = 2 * EvYield.Defense,
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
        id = SpeciesID.Blissey,
        speciesName = "Blissey",
        type1 = Type.Normal,
        type2 = Type.Normal,
        baseHP = 255,
        baseAttack = 10,
        baseDefense = 10,
        baseSpAtk = 75,
        baseSpDef = 135,
        baseSpeed = 55,
        evYield = 3 * EvYield.HP,
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
        id = SpeciesID.Raikou,
        speciesName = "Raikou",
        type1 = Type.Electric,
        type2 = Type.Electric,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 75,
        baseSpAtk = 115,
        baseSpDef = 100,
        baseSpeed = 115,
        evYield = 2 * EvYield.Speed + EvYield.SpAtk,
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
        id = SpeciesID.Entei,
        speciesName = "Entei",
        type1 = Type.Fire,
        type2 = Type.Fire,
        baseHP = 115,
        baseAttack = 115,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 100,
        evYield = EvYield.HP + 2 * EvYield.Attack,
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
        id = SpeciesID.Suicune,
        speciesName = "Suicune",
        type1 = Type.Water,
        type2 = Type.Water,
        baseHP = 100,
        baseAttack = 75,
        baseDefense = 115,
        baseSpAtk = 90,
        baseSpDef = 115,
        baseSpeed = 85,
        evYield = EvYield.Defense + 2 * EvYield.SpDef,
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
        id = SpeciesID.Larvitar,
        speciesName = "Larvitar",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 50,
        baseAttack = 64,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 50,
        baseSpeed = 41,
        evYield = EvYield.Attack,
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
        id = SpeciesID.Pupitar,
        speciesName = "Pupitar",
        type1 = Type.Rock,
        type2 = Type.Ground,
        baseHP = 70,
        baseAttack = 84,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 51,
        evYield = 2 * EvYield.Attack,
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
        id = SpeciesID.Tyranitar,
        speciesName = "Tyranitar",
        type1 = Type.Rock,
        type2 = Type.Dark,
        baseHP = 100,
        baseAttack = 134,
        baseDefense = 110,
        baseSpAtk = 95,
        baseSpDef = 100,
        baseSpeed = 61,
        evYield = 3 * EvYield.Attack,
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
        id = SpeciesID.Lugia,
        speciesName = "Lugia",
        type1 = Type.Psychic,
        type2 = Type.Flying,
        baseHP = 106,
        baseAttack = 90,
        baseDefense = 130,
        baseSpAtk = 90,
        baseSpDef = 154,
        baseSpeed = 110,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.HoOh,
        speciesName = "Ho Oh",
        type1 = Type.Fire,
        type2 = Type.Flying,
        baseHP = 106,
        baseAttack = 130,
        baseDefense = 90,
        baseSpAtk = 110,
        baseSpDef = 154,
        baseSpeed = 90,
        evYield = 3 * EvYield.SpDef,
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
        id = SpeciesID.Celebi,
        speciesName = "Celebi",
        type1 = Type.Psychic,
        type2 = Type.Grass,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * EvYield.HP,
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

    //Forms

    public static SpeciesData Unown_B
        = SpeciesData.Unown(SpeciesID.Unown_B, "unown/b", 9);
    public static SpeciesData Unown_C
        = SpeciesData.Unown(SpeciesID.Unown_C, "unown/c", 6);
    public static SpeciesData Unown_D
        = SpeciesData.Unown(SpeciesID.Unown_D, "unown/d", 8);
    public static SpeciesData Unown_E
        = SpeciesData.Unown(SpeciesID.Unown_E, "unown/e", 10);
    public static SpeciesData Unown_F
        = SpeciesData.Unown(SpeciesID.Unown_F, "unown/f", 10);
    public static SpeciesData Unown_G
        = SpeciesData.Unown(SpeciesID.Unown_G, "unown/g", 5);
    public static SpeciesData Unown_H
        = SpeciesData.Unown(SpeciesID.Unown_H, "unown/h", 8);
    public static SpeciesData Unown_I
        = SpeciesData.Unown(SpeciesID.Unown_I, "unown/i", 7);
    public static SpeciesData Unown_J
        = SpeciesData.Unown(SpeciesID.Unown_J, "unown/j", 9);
    public static SpeciesData Unown_K
        = SpeciesData.Unown(SpeciesID.Unown_K, "unown/k", 7);
    public static SpeciesData Unown_L
        = SpeciesData.Unown(SpeciesID.Unown_L, "unown/l", 10);
    public static SpeciesData Unown_M
        = SpeciesData.Unown(SpeciesID.Unown_M, "unown/m", 13);
    public static SpeciesData Unown_N
        = SpeciesData.Unown(SpeciesID.Unown_N, "unown/n", 13);
    public static SpeciesData Unown_O
        = SpeciesData.Unown(SpeciesID.Unown_O, "unown/o", 8);
    public static SpeciesData Unown_P
        = SpeciesData.Unown(SpeciesID.Unown_P, "unown/p", 10);
    public static SpeciesData Unown_Q
        = SpeciesData.Unown(SpeciesID.Unown_Q, "unown/q", 15);
    public static SpeciesData Unown_R
        = SpeciesData.Unown(SpeciesID.Unown_R, "unown/r", 12);
    public static SpeciesData Unown_S
        = SpeciesData.Unown(SpeciesID.Unown_S, "unown/s", 4);
    public static SpeciesData Unown_T
        = SpeciesData.Unown(SpeciesID.Unown_T, "unown/t", 13);
    public static SpeciesData Unown_U
        = SpeciesData.Unown(SpeciesID.Unown_U, "unown/u", 13);
    public static SpeciesData Unown_V
        = SpeciesData.Unown(SpeciesID.Unown_V, "unown/v", 11);
    public static SpeciesData Unown_W
        = SpeciesData.Unown(SpeciesID.Unown_W, "unown/w", 13);
    public static SpeciesData Unown_X
        = SpeciesData.Unown(SpeciesID.Unown_X, "unown/x", 15);
    public static SpeciesData Unown_Y
        = SpeciesData.Unown(SpeciesID.Unown_Y, "unown/y", 10);
    public static SpeciesData Unown_Z
        = SpeciesData.Unown(SpeciesID.Unown_Z, "unown/z", 10);


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
    };
}