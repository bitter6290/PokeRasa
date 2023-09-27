using Unity.VisualScripting;
using static EvYield;
using static Ability;
using static Type;
using static SpeciesData;
using static XPClass;
using static Learnset;

public static class Species
{
    public static SpeciesData Missingno = new()
    {
        speciesName = "Missingno",
        type1 = Typeless,
        type2 = Typeless,
        baseHP = 0,
        baseAttack = 0,
        baseDefense = 0,
        baseSpAtk = 0,
        baseSpDef = 0,
        baseSpeed = 0,
        evYield = 0,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 0,
        learnset = EmptyLearnset,
        cryLocation = "pikachu",
        graphicsLocation = "circled_question_mark",
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur,
        abilities = new Ability[3]
        {
            None,
            None,
            None,
        }
    };
    public static SpeciesData Bulbasaur = new()
    {
        speciesName = "Bulbasaur",
        type1 = Grass,
        type2 = Poison,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 49,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Bulbasaur,
        xpClass = MediumSlow,
        xpYield = 64,
        learnset = BulbasaurLearnset,
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
            Overgrow,
            Overgrow,
            Chlorophyll,
        }
    };
    public static SpeciesData Ivysaur = new()
    {
        speciesName = "Ivysaur",
        type1 = Grass,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 63,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = SpAtk + SpDef,
        evolution = Evolution.Ivysaur,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            Chlorophyll,
        },
    };
    public static SpeciesData Venusaur = new()
    {
        speciesName = "Venusaur",
        type1 = Grass,
        type2 = Poison,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 83,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 2 * SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 236,
        learnset = VenusaurLearnset,
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
            Overgrow,
            Overgrow,
            Chlorophyll,
        },
    };
    public static SpeciesData Charmander = new()
    {
        speciesName = "Charmander",
        type1 = Fire,
        type2 = Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Charmander,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SolarPower,
        },
    };
    public static SpeciesData Charmeleon = new()
    {
        speciesName = "Charmeleon",
        type1 = Fire,
        type2 = Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = Speed + SpAtk,
        evolution = Evolution.Charmeleon,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SolarPower,
        },
    };
    public static SpeciesData Charizard = new()
    {
        speciesName = "Charizard",
        type1 = Fire,
        type2 = Flying,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 240,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SolarPower,
        },
    };
    public static SpeciesData Squirtle = new()
    {
        speciesName = "Squirtle",
        type1 = Water,
        type2 = Water,
        baseHP = 44,
        baseAttack = 48,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 64,
        baseSpeed = 43,
        evYield = Defense,
        evolution = Evolution.Squirtle,
        xpClass = MediumSlow,
        xpYield = 63,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            RainDish,
        },
    };
    public static SpeciesData Wartortle = new()
    {
        speciesName = "Wartortle",
        type1 = Water,
        type2 = Water,
        baseHP = 59,
        baseAttack = 63,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 58,
        evYield = Defense + SpDef,
        evolution = Evolution.Wartortle,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            RainDish,
        },
    };
    public static SpeciesData Blastoise = new()
    {
        speciesName = "Blastoise",
        type1 = Water,
        type2 = Water,
        baseHP = 79,
        baseAttack = 83,
        baseDefense = 100,
        baseSpAtk = 85,
        baseSpDef = 105,
        baseSpeed = 78,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            RainDish,
        },
    };
    public static SpeciesData Caterpie = new()
    {
        speciesName = "Caterpie",
        type1 = Bug,
        type2 = Bug,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 45,
        evYield = HP,
        evolution = Evolution.Caterpie,
        xpClass = MediumFast,
        xpYield = 39,
        learnset = EmptyLearnset, //Not done
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
            ShieldDust,
            ShieldDust,
            RunAway,
        },
    };
    public static SpeciesData Metapod = new()
    {
        speciesName = "Metapod",
        type1 = Bug,
        type2 = Bug,
        baseHP = 50,
        baseAttack = 20,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.Metapod,
        xpClass = MediumFast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            ShedSkin,
        },
    };
    public static SpeciesData Butterfree = new()
    {
        speciesName = "Butterfree",
        type1 = Bug,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 90,
        baseSpDef = 80,
        baseSpeed = 70,
        evYield = 2 * SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 178,
        learnset = EmptyLearnset, //Not done
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
            CompoundEyes,
            CompoundEyes,
            TintedLens,
        },
    };
    public static SpeciesData Weedle = new()
    {
        speciesName = "Weedle",
        type1 = Bug,
        type2 = Poison,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 20,
        baseSpDef = 20,
        baseSpeed = 50,
        evYield = Speed,
        evolution = Evolution.Weedle,
        xpClass = MediumFast,
        xpYield = 39,
        learnset = EmptyLearnset, //Not done
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
            ShieldDust,
            ShieldDust,
            RunAway,
        },
    };
    public static SpeciesData Kakuna = new()
    {
        speciesName = "Kakuna",
        type1 = Bug,
        type2 = Poison,
        baseHP = 45,
        baseAttack = 25,
        baseDefense = 50,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 35,
        evYield = 2 * Defense,
        evolution = Evolution.Kakuna,
        xpClass = MediumFast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            ShedSkin,
        },
    };
    public static SpeciesData Beedrill = new()
    {
        speciesName = "Beedrill",
        type1 = Bug,
        type2 = Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 40,
        baseSpAtk = 45,
        baseSpDef = 80,
        baseSpeed = 75,
        evYield = 2 * Attack + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 178,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Swarm,
            Sniper,
        },
    };
    public static SpeciesData Pidgey = new()
    {
        speciesName = "Pidgey",
        type1 = Normal,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 56,
        evYield = Speed,
        evolution = Evolution.Pidgey,
        xpClass = MediumSlow,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            TangledFeet,
            BigPecks,
        },
    };
    public static SpeciesData Pidgeotto = new()
    {
        speciesName = "Pidgeotto",
        type1 = Normal,
        type2 = Flying,
        baseHP = 63,
        baseAttack = 60,
        baseDefense = 55,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 71,
        evYield = 2 * Speed,
        evolution = Evolution.Pidgeotto,
        xpClass = MediumSlow,
        xpYield = 122,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            TangledFeet,
            BigPecks,
        },
    };
    public static SpeciesData Pidgeot = new()
    {
        speciesName = "Pidgeot",
        type1 = Normal,
        type2 = Flying,
        baseHP = 83,
        baseAttack = 80,
        baseDefense = 75,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 101,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 216,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            TangledFeet,
            BigPecks,
        },
    };
    public static SpeciesData Rattata = new()
    {
        speciesName = "Rattata",
        type1 = Normal,
        type2 = Normal,
        baseHP = 30,
        baseAttack = 56,
        baseDefense = 35,
        baseSpAtk = 25,
        baseSpDef = 35,
        baseSpeed = 72,
        evYield = Speed,
        evolution = Evolution.Rattata,
        xpClass = MediumFast,
        xpYield = 51,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            Guts,
            Hustle,
        },
    };
    public static SpeciesData Raticate = new()
    {
        speciesName = "Raticate",
        type1 = Normal,
        type2 = Normal,
        baseHP = 55,
        baseAttack = 81,
        baseDefense = 60,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 97,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 145,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            Guts,
            Hustle,
        },
    };
    public static SpeciesData Spearow = new()
    {
        speciesName = "Spearow",
        type1 = Normal,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 31,
        baseSpDef = 31,
        baseSpeed = 70,
        evYield = Speed,
        evolution = Evolution.Spearow,
        xpYield = 52,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            KeenEye,
            Sniper,
        },
    };
    public static SpeciesData Fearow = new()
    {
        speciesName = "Fearow",
        type1 = Normal,
        type2 = Flying,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 65,
        baseSpAtk = 61,
        baseSpDef = 61,
        baseSpeed = 100,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 155,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            KeenEye,
            Sniper,
        },
    };
    public static SpeciesData Ekans = new()
    {
        speciesName = "Ekans",
        type1 = Poison,
        type2 = Poison,
        baseHP = 35,
        baseAttack = 60,
        baseDefense = 44,
        baseSpAtk = 40,
        baseSpDef = 54,
        baseSpeed = 55,
        evYield = Attack,
        evolution = Evolution.Ekans,
        xpClass = MediumFast,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            ShedSkin,
            Unnerve,
        },
    };
    public static SpeciesData Arbok = new()
    {
        speciesName = "Arbok",
        type1 = Poison,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 95,
        baseDefense = 69,
        baseSpAtk = 65,
        baseSpDef = 79,
        baseSpeed = 80,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 157,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            ShedSkin,
            Unnerve,
        },
    };
    public static SpeciesData Pikachu = new()
    {
        speciesName = "Pikachu",
        type1 = Electric,
        type2 = Electric,
        baseHP = 35,
        baseAttack = 55,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Pikachu,
        xpClass = MediumFast,
        xpYield = 112,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            LightningRod,
        },
    };
    public static SpeciesData Raichu = new()
    {
        speciesName = "Raichu",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 55,
        baseSpAtk = 90,
        baseSpDef = 80,
        baseSpeed = 110,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 218,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            LightningRod,
        },
    };
    public static SpeciesData Sandshrew = new()
    {
        speciesName = "Sandshrew",
        type1 = Ground,
        type2 = Ground,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Sandshrew,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            SandVeil,
            SandRush,
        },
    };
    public static SpeciesData Sandslash = new()
    {
        speciesName = "Sandslash",
        type1 = Ground,
        type2 = Ground,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 110,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            SandVeil,
            SandRush,
        },
    };
    public static SpeciesData NidoranF = new()
    {
        speciesName = "Nidoran",
        type1 = Poison,
        type2 = Poison,
        baseHP = 55,
        baseAttack = 47,
        baseDefense = 52,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 41,
        evYield = HP,
        evolution = Evolution.NidoranF,
        xpClass = MediumSlow,
        xpYield = 55,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            Hustle,
        },

    };
    public static SpeciesData Nidorina = new()
    {
        speciesName = "Nidorina",
        type1 = Poison,
        type2 = Poison,
        baseHP = 70,
        baseAttack = 62,
        baseDefense = 67,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 56,
        evYield = 2 * HP,
        evolution = Evolution.Nidorina,
        xpClass = MediumSlow,
        xpYield = 128,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            Hustle,
        },
    };
    public static SpeciesData Nidoqueen = new()
    {
        speciesName = "Nidoqueen",
        type1 = Poison,
        type2 = Ground,
        baseHP = 90,
        baseAttack = 92,
        baseDefense = 87,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 76,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 227,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            SheerForce,
        },
    };
    public static SpeciesData NidoranM = new()
    {
        speciesName = "Nidoran",
        type1 = Poison,
        type2 = Poison,
        baseHP = 46,
        baseAttack = 57,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.NidoranM,
        xpClass = MediumSlow,
        xpYield = 55,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            Hustle,
        },
    };
    public static SpeciesData Nidorino = new()
    {
        speciesName = "Nidorino",
        type1 = Poison,
        type2 = Poison,
        baseHP = 61,
        baseAttack = 72,
        baseDefense = 57,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.Nidorino,
        xpClass = MediumSlow,
        xpYield = 128,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            Hustle,
        },
    };
    public static SpeciesData Nidoking = new()
    {
        speciesName = "Nidoking",
        type1 = Poison,
        type2 = Ground,
        baseHP = 81,
        baseAttack = 102,
        baseDefense = 77,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 85,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 227,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Rivalry,
            SheerForce,
        },
    };
    public static SpeciesData Clefairy = new()
    {
        speciesName = "Clefairy",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 70,
        baseAttack = 45,
        baseDefense = 48,
        baseSpAtk = 60,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * HP,
        evolution = Evolution.Clefairy,
        xpClass = Fast,
        xpYield = 113,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            MagicGuard,
            FriendGuard,
        },
    };
    public static SpeciesData Clefable = new()
    {
        speciesName = "Clefable",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 95,
        baseAttack = 70,
        baseDefense = 73,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 217,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            MagicGuard,
            Unaware,
        },
    };
    public static SpeciesData Vulpix = new()
    {
        speciesName = "Vulpix",
        type1 = Fire,
        type2 = Fire,
        baseHP = 38,
        baseAttack = 41,
        baseDefense = 40,
        baseSpAtk = 50,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Vulpix,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            FlashFire,
            FlashFire,
            Drought,
        },
    };
    public static SpeciesData Ninetales = new()
    {
        speciesName = "Ninetales",
        type1 = Fire,
        type2 = Fire,
        baseHP = 73,
        baseAttack = 76,
        baseDefense = 75,
        baseSpAtk = 81,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = Speed + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 177,
        learnset = EmptyLearnset, //Not done
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
            FlashFire,
            FlashFire,
            Drought,
        },
    };
    public static SpeciesData Jigglypuff = new()
    {
        speciesName = "Jigglypuff",
        type1 = Normal,
        type2 = Fairy,
        baseHP = 115,
        baseAttack = 45,
        baseDefense = 20,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 20,
        evYield = 2 * HP,
        evolution = Evolution.Jigglypuff,
        xpClass = Fast,
        xpYield = 95,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            Competitive,
            FriendGuard,
        },
    };
    public static SpeciesData Wigglytuff = new()
    {
        speciesName = "Wigglytuff",
        type1 = Normal,
        type2 = Fairy,
        baseHP = 140,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 85,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 196,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            Competitive,
            Frisk,
        },
    };
    public static SpeciesData Zubat = new()
    {
        speciesName = "Zubat",
        type1 = Poison,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 30,
        baseSpDef = 40,
        baseSpeed = 55,
        evYield = Speed,
        evolution = Evolution.Zubat,
        xpClass = MediumFast,
        xpYield = 49,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            InnerFocus,
            Infiltrator,
        },
    };
    public static SpeciesData Golbat = new()
    {
        speciesName = "Golbat",
        type1 = Poison,
        type2 = Flying,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Golbat,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            InnerFocus,
            Infiltrator,
        },
    };
    public static SpeciesData Oddish = new()
    {
        speciesName = "Oddish",
        type1 = Grass,
        type2 = Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 55,
        baseSpAtk = 75,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = SpAtk,
        evolution = Evolution.Oddish,
        xpClass = MediumSlow,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            RunAway,
        },
    };
    public static SpeciesData Gloom = new()
    {
        speciesName = "Gloom",
        type1 = Grass,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = 2 * SpAtk,
        evolution = Evolution.Gloom,
        xpClass = MediumSlow,
        xpYield = 138,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Stench,
        },
    };
    public static SpeciesData Vileplume = new()
    {
        speciesName = "Vileplume",
        type1 = Grass,
        type2 = Poison,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 85,
        baseSpAtk = 110,
        baseSpDef = 90,
        baseSpeed = 50,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 221,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            EffectSpore,
        },
    };
    public static SpeciesData Paras = new()
    {
        speciesName = "Paras",
        type1 = Bug,
        type2 = Grass,
        baseHP = 35,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 25,
        evYield = Attack,
        evolution = Evolution.Paras,
        xpClass = MediumFast,
        xpYield = 57,
        learnset = EmptyLearnset, //Not done
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
            EffectSpore,
            DrySkin,
            Damp,
        },
    };
    public static SpeciesData Parasect = new()
    {
        speciesName = "Parasect",
        type1 = Bug,
        type2 = Grass,
        baseHP = 60,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Attack + Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            EffectSpore,
            DrySkin,
            Damp,
        },
    };
    public static SpeciesData Venonat = new()
    {
        speciesName = "Venonat",
        type1 = Bug,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Venonat,
        xpClass = MediumFast,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            CompoundEyes,
            TintedLens,
            RunAway,
        },
    };
    public static SpeciesData Venomoth = new()
    {
        speciesName = "Venomoth",
        type1 = Bug,
        type2 = Poison,
        baseHP = 70,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            ShieldDust,
            TintedLens,
            WonderSkin,
        },
    };
    public static SpeciesData Diglett = new()
    {
        speciesName = "Diglett",
        type1 = Ground,
        type2 = Ground,
        baseHP = 10,
        baseAttack = 55,
        baseDefense = 25,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.Diglett,
        xpClass = MediumFast,
        xpYield = 53,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            ArenaTrap,
            SandForce,
        },
    };
    public static SpeciesData Dugtrio = new()
    {
        speciesName = "Dugtrio",
        type1 = Ground,
        type2 = Ground,
        baseHP = 35,
        baseAttack = 100,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 120,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 149,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            ArenaTrap,
            SandForce,
        },
    };
    public static SpeciesData Meowth = new()
    {
        speciesName = "Meowth",
        type1 = Normal,
        type2 = Normal,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Meowth,
        xpClass = MediumFast,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
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
            Pickup,
            Technician,
            Unnerve,
        },
    };
    public static SpeciesData Persian = new()
    {
        speciesName = "Persian",
        type1 = Normal,
        type2 = Normal,
        baseHP = 65,
        baseAttack = 70,
        baseDefense = 60,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
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
            Limber,
            Technician,
            Unnerve,
        },
    };
    public static SpeciesData Psyduck = new()
    {
        speciesName = "Psyduck",
        type1 = Water,
        type2 = Water,
        baseHP = 50,
        baseAttack = 52,
        baseDefense = 48,
        baseSpAtk = 65,
        baseSpDef = 50,
        baseSpeed = 55,
        evYield = SpAtk,
        evolution = Evolution.Psyduck,
        xpClass = MediumFast,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            Damp,
            CloudNine,
            SwiftSwim,
        },
    };
    public static SpeciesData Golduck = new()
    {
        speciesName = "Golduck",
        type1 = Water,
        type2 = Water,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 78,
        baseSpAtk = 95,
        baseSpDef = 80,
        baseSpeed = 85,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Damp,
            CloudNine,
            SwiftSwim,
        },
    };
    public static SpeciesData Mankey = new()
    {
        speciesName = "Mankey",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = Attack,
        evolution = Evolution.Mankey,
        xpClass = MediumFast,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            VitalSpirit,
            AngerPoint,
            Defiant,
        },
    };
    public static SpeciesData Primeape = new()
    {
        speciesName = "Primeape",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 65,
        baseAttack = 105,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            VitalSpirit,
            AngerPoint,
            Defiant,
        },
    };
    public static SpeciesData Growlithe = new()
    {
        speciesName = "Growlithe",
        type1 = Fire,
        type2 = Fire,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 50,
        baseSpeed = 60,
        evYield = Attack,
        evolution = Evolution.Growlithe,
        xpClass = Slow,
        xpYield = 70,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            FlashFire,
            Justified,
        },
    };
    public static SpeciesData Arcanine = new()
    {
        speciesName = "Arcanine",
        type1 = Fire,
        type2 = Fire,
        baseHP = 90,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 194,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            FlashFire,
            Justified,
        },
    };
    public static SpeciesData Poliwag = new()
    {
        speciesName = "Poliwag",
        type1 = Water,
        type2 = Water,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Poliwag,
        xpClass = MediumSlow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            Damp,
            SwiftSwim,
        },
    };
    public static SpeciesData Poliwhirl = new()
    {
        speciesName = "Poliwhirl",
        type1 = Water,
        type2 = Water,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Poliwhirl,
        xpClass = MediumSlow,
        xpYield = 135,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            Damp,
            SwiftSwim,
        },
    };
    public static SpeciesData Poliwrath = new()
    {
        speciesName = "Poliwrath",
        type1 = Water,
        type2 = Fighting,
        baseHP = 90,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 70,
        baseSpDef = 90,
        baseSpeed = 70,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 230,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            Damp,
            SwiftSwim,
        },
    };
    public static SpeciesData Abra = new()
    {
        speciesName = "Abra",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 25,
        baseAttack = 20,
        baseDefense = 15,
        baseSpAtk = 105,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = SpAtk,
        evolution = Evolution.Abra,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            InnerFocus,
            MagicGuard,
        },
    };
    public static SpeciesData Kadabra = new()
    {
        speciesName = "Kadabra",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 40,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 105,
        evYield = 2 * SpAtk,
        evolution = Evolution.Kadabra,
        xpClass = MediumSlow,
        xpYield = 140,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            InnerFocus,
            MagicGuard,
        },
    };
    public static SpeciesData Alakazam = new()
    {
        speciesName = "Alakazam",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 55,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 135,
        baseSpDef = 95,
        baseSpeed = 120,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 225,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            InnerFocus,
            MagicGuard,
        },
    };
    public static SpeciesData Machop = new()
    {
        speciesName = "Machop",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Machop,
        xpClass = MediumSlow,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            NoGuard,
            Steadfast,
        },
    };
    public static SpeciesData Machoke = new()
    {
        speciesName = "Machoke",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.Machoke,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            NoGuard,
            Steadfast,
        },
    };
    public static SpeciesData Machamp = new()
    {
        speciesName = "Machamp",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 65,
        baseSpDef = 85,
        baseSpeed = 55,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 227,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            NoGuard,
            Steadfast,
        },
    };
    public static SpeciesData Bellsprout = new()
    {
        speciesName = "Bellsprout",
        type1 = Grass,
        type2 = Poison,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Bellsprout,
        xpClass = MediumSlow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        },
    };
    public static SpeciesData Weepinbell = new()
    {
        speciesName = "Weepinbell",
        type1 = Grass,
        type2 = Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.Weepinbell,
        xpClass = MediumSlow,
        xpYield = 137,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        },
    };
    public static SpeciesData Victreebel = new()
    {
        speciesName = "Victreebel",
        type1 = Grass,
        type2 = Poison,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 221,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        },
    };
    public static SpeciesData Tentacool = new()
    {
        speciesName = "Tentacool",
        type1 = Water,
        type2 = Poison,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 35,
        baseSpAtk = 50,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = SpDef,
        evolution = Evolution.Tentacool,
        xpClass = Slow,
        xpYield = 67,
        learnset = EmptyLearnset, //Not done
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
            ClearBody,
            LiquidOoze,
            RainDish,
        },
    };
    public static SpeciesData Tentacruel = new()
    {
        speciesName = "Tentacruel",
        type1 = Water,
        type2 = Poison,
        baseHP = 80,
        baseAttack = 70,
        baseDefense = 65,
        baseSpAtk = 80,
        baseSpDef = 120,
        baseSpeed = 100,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 180,
        learnset = EmptyLearnset, //Not done
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
            ClearBody,
            LiquidOoze,
            RainDish,
        },
    };
    public static SpeciesData Geodude = new()
    {
        speciesName = "Geodude",
        type1 = Rock,
        type2 = Ground,
        baseHP = 40,
        baseAttack = 80,
        baseDefense = 100,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 20,
        evYield = Defense,
        evolution = Evolution.Geodude,
        xpClass = MediumSlow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Sturdy,
            SandVeil,
        },
    };
    public static SpeciesData Graveler = new()
    {
        speciesName = "Graveler",
        type1 = Rock,
        type2 = Ground,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 115,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = 2 * Defense,
        evolution = Evolution.Graveler,
        xpClass = MediumSlow,
        xpYield = 137,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Sturdy,
            SandVeil,
        },
    };
    public static SpeciesData Golem = new()
    {
        speciesName = "Golem",
        type1 = Rock,
        type2 = Ground,
        baseHP = 80,
        baseAttack = 120,
        baseDefense = 130,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 223,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Sturdy,
            SandVeil,
        },
    };
    public static SpeciesData Ponyta = new()
    {
        speciesName = "Ponyta",
        type1 = Fire,
        type2 = Fire,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 55,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 90,
        evYield = Speed,
        evolution = Evolution.Ponyta,
        xpClass = MediumFast,
        xpYield = 82,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            FlashFire,
            FlameBody,
        },
    };
    public static SpeciesData Rapidash = new()
    {
        speciesName = "Rapidash",
        type1 = Fire,
        type2 = Fire,
        baseHP = 65,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            FlashFire,
            FlameBody,
        },
    };
    public static SpeciesData Slowpoke = new()
    {
        speciesName = "Slowpoke",
        type1 = Water,
        type2 = Psychic,
        baseHP = 90,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Slowpoke,
        xpClass = MediumFast,
        xpYield = 63,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            OwnTempo,
            Regenerator,
        },
    };
    public static SpeciesData Slowbro = new()
    {
        speciesName = "Slowbro",
        type1 = Water,
        type2 = Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 110,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            OwnTempo,
            Regenerator,
        },
    };
    public static SpeciesData Magnemite = new()
    {
        speciesName = "Magnemite",
        type1 = Electric,
        type2 = Steel,
        baseHP = 25,
        baseAttack = 35,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 55,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Magnemite,
        xpClass = MediumFast,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            MagnetPull,
            Sturdy,
            Analytic,
        },
    };
    public static SpeciesData Magneton = new()
    {
        speciesName = "Magneton",
        type1 = Electric,
        type2 = Steel,
        baseHP = 50,
        baseAttack = 60,
        baseDefense = 95,
        baseSpAtk = 120,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * SpAtk,
        evolution = Evolution.Magneton,
        xpClass = MediumFast,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            MagnetPull,
            Sturdy,
            Analytic,
        },
    };
    public static SpeciesData Farfetchd = new()
    {
        speciesName = "Farfetchd",
        type1 = Normal,
        type2 = Flying,
        baseHP = 52,
        baseAttack = 90,
        baseDefense = 55,
        baseSpAtk = 58,
        baseSpDef = 62,
        baseSpeed = 60,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 132,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            InnerFocus,
            Defiant,
        },
    };
    public static SpeciesData Doduo = new()
    {
        speciesName = "Doduo",
        type1 = Normal,
        type2 = Flying,
        baseHP = 35,
        baseAttack = 85,
        baseDefense = 45,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 75,
        evYield = Attack,
        evolution = Evolution.Doduo,
        xpClass = MediumFast,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            EarlyBird,
            TangledFeet,
        },
    };
    public static SpeciesData Dodrio = new()
    {
        speciesName = "Dodrio",
        type1 = Normal,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 110,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 110,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 165,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            EarlyBird,
            TangledFeet,
        },
    };
    public static SpeciesData Seel = new()
    {
        speciesName = "Seel",
        type1 = Water,
        type2 = Water,
        baseHP = 65,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 45,
        baseSpDef = 70,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Seel,
        xpClass = MediumFast,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            Hydration,
            IceBody,
        },
    };
    public static SpeciesData Dewgong = new()
    {
        speciesName = "Dewgong",
        type1 = Water,
        type2 = Ice,
        baseHP = 90,
        baseAttack = 70,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 95,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            Hydration,
            IceBody,
        },
    };
    public static SpeciesData Grimer = new()
    {
        speciesName = "Grimer",
        type1 = Poison,
        type2 = Poison,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.Grimer,
        xpClass = MediumFast,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
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
            Stench,
            StickyHold,
            PoisonTouch,
        },
    };
    public static SpeciesData Muk = new()
    {
        speciesName = "Muk",
        type1 = Poison,
        type2 = Poison,
        baseHP = 105,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 65,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = HP + Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Stench,
            StickyHold,
            PoisonTouch,
        },
    };
    public static SpeciesData Shellder = new()
    {
        speciesName = "Shellder",
        type1 = Water,
        type2 = Water,
        baseHP = 30,
        baseAttack = 65,
        baseDefense = 100,
        baseSpAtk = 45,
        baseSpDef = 25,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Shellder,
        xpClass = Slow,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            ShellArmor,
            SkillLink,
            Overcoat,
        },
    };
    public static SpeciesData Cloyster = new()
    {
        speciesName = "Cloyster",
        type1 = Water,
        type2 = Ice,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 180,
        baseSpAtk = 85,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            ShellArmor,
            SkillLink,
            Overcoat,
        },
    };
    public static SpeciesData Gastly = new()
    {
        speciesName = "Gastly",
        type1 = Ghost,
        type2 = Poison,
        baseHP = 30,
        baseAttack = 35,
        baseDefense = 30,
        baseSpAtk = 100,
        baseSpDef = 35,
        baseSpeed = 80,
        evYield = SpAtk,
        evolution = Evolution.Gastly,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Haunter = new()
    {
        speciesName = "Haunter",
        type1 = Ghost,
        type2 = Poison,
        baseHP = 45,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 115,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.Haunter,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Gengar = new()
    {
        speciesName = "Gengar",
        type1 = Ghost,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 75,
        baseSpeed = 110,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 225,
        learnset = EmptyLearnset, //Not done
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
            CursedBody,
            CursedBody,
            CursedBody,
        },
    };
    public static SpeciesData Onix = new()
    {
        speciesName = "Onix",
        type1 = Rock,
        type2 = Ground,
        baseHP = 35,
        baseAttack = 45,
        baseDefense = 160,
        baseSpAtk = 30,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = Defense,
        evolution = Evolution.Onix,
        xpClass = MediumFast,
        xpYield = 77,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Sturdy,
            WeakArmor,
        },
    };
    public static SpeciesData Drowzee = new()
    {
        speciesName = "Drowzee",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 48,
        baseDefense = 45,
        baseSpAtk = 43,
        baseSpDef = 90,
        baseSpeed = 42,
        evYield = SpDef,
        evolution = Evolution.Drowzee,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            Forewarn,
            InnerFocus,
        },
    };
    public static SpeciesData Hypno = new()
    {
        speciesName = "Hypno",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 85,
        baseAttack = 73,
        baseDefense = 70,
        baseSpAtk = 73,
        baseSpDef = 115,
        baseSpeed = 67,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 169,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            Forewarn,
            InnerFocus,
        },
    };
    public static SpeciesData Krabby = new()
    {
        speciesName = "Krabby",
        type1 = Water,
        type2 = Water,
        baseHP = 30,
        baseAttack = 105,
        baseDefense = 90,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Krabby,
        xpClass = MediumFast,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            ShellArmor,
            SheerForce,
        },
    };
    public static SpeciesData Kingler = new()
    {
        speciesName = "Kingler",
        type1 = Water,
        type2 = Water,
        baseHP = 55,
        baseAttack = 130,
        baseDefense = 115,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            ShellArmor,
            SheerForce,
        },
    };
    public static SpeciesData Voltorb = new()
    {
        speciesName = "Voltorb",
        type1 = Electric,
        type2 = Electric,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 100,
        evYield = Speed,
        evolution = Evolution.Voltorb,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Soundproof,
            Static,
            Aftermath,
        },
    };
    public static SpeciesData Electrode = new()
    {
        speciesName = "Electrode",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 150,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Soundproof,
            Static,
            Aftermath,
        },
    };
    public static SpeciesData Exeggcute = new()
    {
        speciesName = "Exeggcute",
        type1 = Grass,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Exeggcute,
        xpClass = Slow,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Harvest,
        },
    };
    public static SpeciesData Exeggutor = new()
    {
        speciesName = "Exeggutor",
        type1 = Grass,
        type2 = Psychic,
        baseHP = 95,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 75,
        baseSpeed = 55,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 186,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Harvest,
        },
    };
    public static SpeciesData Cubone = new()
    {
        speciesName = "Cubone",
        type1 = Ground,
        type2 = Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Cubone,
        xpClass = MediumFast,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            LightningRod,
            BattleArmor,
        },
    };
    public static SpeciesData Marowak = new()
    {
        speciesName = "Marowak",
        type1 = Ground,
        type2 = Ground,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 110,
        baseSpAtk = 50,
        baseSpDef = 80,
        baseSpeed = 45,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 149,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            LightningRod,
            BattleArmor,
        },
    };
    public static SpeciesData Hitmonlee = new()
    {
        speciesName = "Hitmonlee",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 50,
        baseAttack = 120,
        baseDefense = 53,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 87,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Limber,
            Reckless,
            Unburden,
        },
    };
    public static SpeciesData Hitmonchan = new()
    {
        speciesName = "Hitmonchan",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 50,
        baseAttack = 105,
        baseDefense = 79,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 76,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            IronFist,
            InnerFocus,
        },
    };
    public static SpeciesData Lickitung = new()
    {
        speciesName = "Lickitung",
        type1 = Normal,
        type2 = Normal,
        baseHP = 90,
        baseAttack = 55,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 30,
        evYield = 2 * HP,
        evolution = Evolution.Lickitung,
        xpClass = MediumFast,
        xpYield = 77,
        learnset = EmptyLearnset, //Not done
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
            OwnTempo,
            Oblivious,
            CloudNine,
        },
    };
    public static SpeciesData Koffing = new()
    {
        speciesName = "Koffing",
        type1 = Poison,
        type2 = Poison,
        baseHP = 40,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 60,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Koffing,
        xpClass = MediumFast,
        xpYield = 68,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            NeutralizingGas,
            Stench,
        },
    };
    public static SpeciesData Weezing = new()
    {
        speciesName = "Weezing",
        type1 = Poison,
        type2 = Poison,
        baseHP = 65,
        baseAttack = 90,
        baseDefense = 120,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 60,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            NeutralizingGas,
            Stench,
        },
    };
    public static SpeciesData Rhyhorn = new()
    {
        speciesName = "Rhyhorn",
        type1 = Ground,
        type2 = Rock,
        baseHP = 80,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 25,
        evYield = Defense,
        evolution = Evolution.Rhyhorn,
        xpClass = Slow,
        xpYield = 69,
        learnset = EmptyLearnset, //Not done
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
            LightningRod,
            RockHead,
            Reckless,
        },
    };
    public static SpeciesData Rhydon = new()
    {
        speciesName = "Rhydon",
        type1 = Ground,
        type2 = Rock,
        baseHP = 105,
        baseAttack = 130,
        baseDefense = 120,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 40,
        evYield = 2 * Attack,
        evolution = Evolution.Rhydon,
        xpClass = Slow,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
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
            LightningRod,
            RockHead,
            Reckless,
        },
    };
    public static SpeciesData Chansey = new()
    {
        speciesName = "Chansey",
        type1 = Normal,
        type2 = Normal,
        baseHP = 250,
        baseAttack = 5,
        baseDefense = 5,
        baseSpAtk = 35,
        baseSpDef = 105,
        baseSpeed = 50,
        evYield = 2 * HP,
        evolution = Evolution.Chansey,
        xpClass = Fast,
        xpYield = 395,
        learnset = EmptyLearnset, //Not done
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
            NaturalCure,
            SereneGrace,
            Healer,
        },
    };
    public static SpeciesData Tangela = new()
    {
        speciesName = "Tangela",
        type1 = Grass,
        type2 = Grass,
        baseHP = 65,
        baseAttack = 55,
        baseDefense = 115,
        baseSpAtk = 100,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = Defense,
        evolution = Evolution.Tangela,
        xpClass = MediumFast,
        xpYield = 87,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            LeafGuard,
            Regenerator,
        },
    };
    public static SpeciesData Kangaskhan = new()
    {
        speciesName = "Kangaskhan",
        type1 = Normal,
        type2 = Normal,
        baseHP = 105,
        baseAttack = 95,
        baseDefense = 80,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 90,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            EarlyBird,
            Scrappy,
            InnerFocus,
        },
    };
    public static SpeciesData Horsea = new()
    {
        speciesName = "Horsea",
        type1 = Water,
        type2 = Water,
        baseHP = 30,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 70,
        baseSpDef = 25,
        baseSpeed = 60,
        evYield = SpAtk,
        evolution = Evolution.Horsea,
        xpClass = MediumFast,
        xpYield = 59,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            Sniper,
            Damp,
        },
    };
    public static SpeciesData Seadra = new()
    {
        speciesName = "Seadra",
        type1 = Water,
        type2 = Water,
        baseHP = 55,
        baseAttack = 65,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 45,
        baseSpeed = 85,
        evYield = Defense + SpAtk,
        evolution = Evolution.Seadra,
        xpClass = MediumFast,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            Sniper,
            Damp,
        },
    };
    public static SpeciesData Goldeen = new()
    {
        speciesName = "Goldeen",
        type1 = Water,
        type2 = Water,
        baseHP = 45,
        baseAttack = 67,
        baseDefense = 60,
        baseSpAtk = 35,
        baseSpDef = 50,
        baseSpeed = 63,
        evYield = Attack,
        evolution = Evolution.Goldeen,
        xpClass = MediumFast,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            WaterVeil,
            LightningRod,
        },
    };
    public static SpeciesData Seaking = new()
    {
        speciesName = "Seaking",
        type1 = Water,
        type2 = Water,
        baseHP = 80,
        baseAttack = 92,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 80,
        baseSpeed = 68,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            WaterVeil,
            LightningRod,
        },
    };
    public static SpeciesData Staryu = new()
    {
        speciesName = "Staryu",
        type1 = Water,
        type2 = Water,
        baseHP = 30,
        baseAttack = 45,
        baseDefense = 55,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Staryu,
        xpClass = Slow,
        xpYield = 68,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Illuminate,
            NaturalCure,
            Analytic,
        },
    };
    public static SpeciesData Starmie = new()
    {
        speciesName = "Starmie",
        type1 = Water,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 182,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Illuminate,
            NaturalCure,
            Analytic,
        },
    };
    public static SpeciesData MrMime = new()
    {
        speciesName = "Mr. Mime",
        type1 = Psychic,
        type2 = Fairy,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 65,
        baseSpAtk = 100,
        baseSpDef = 120,
        baseSpeed = 90,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            Soundproof,
            Filter,
            Technician,
        },
    };
    public static SpeciesData Scyther = new()
    {
        speciesName = "Scyther",
        type1 = Bug,
        type2 = Flying,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 80,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 105,
        evYield = Attack,
        evolution = Evolution.Scyther,
        xpClass = MediumFast,
        xpYield = 100,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Technician,
            Steadfast,
        },
    };
    public static SpeciesData Jynx = new()
    {
        speciesName = "Jynx",
        type1 = Ice,
        type2 = Psychic,
        baseHP = 65,
        baseAttack = 50,
        baseDefense = 35,
        baseSpAtk = 115,
        baseSpDef = 95,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            Forewarn,
            DrySkin,
        },
    };
    public static SpeciesData Electabuzz = new()
    {
        speciesName = "Electabuzz",
        type1 = Electric,
        type2 = Electric,
        baseHP = 65,
        baseAttack = 83,
        baseDefense = 57,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.Electabuzz,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            VitalSpirit,
        },
    };
    public static SpeciesData Magmar = new()
    {
        speciesName = "Magmar",
        type1 = Fire,
        type2 = Fire,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 57,
        baseSpAtk = 100,
        baseSpDef = 85,
        baseSpeed = 93,
        evYield = 2 * SpAtk,
        evolution = Evolution.Magmar,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            FlameBody,
            FlameBody,
            VitalSpirit,
        },
    };
    public static SpeciesData Pinsir = new()
    {
        speciesName = "Pinsir",
        type1 = Bug,
        type2 = Bug,
        baseHP = 65,
        baseAttack = 125,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 70,
        baseSpeed = 85,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            MoldBreaker,
            Moxie,
        },
    };
    public static SpeciesData Tauros = new()
    {
        speciesName = "Tauros",
        type1 = Normal,
        type2 = Normal,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 95,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 110,
        evYield = Attack + Speed,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            AngerPoint,
            SheerForce,
        },
    };
    public static SpeciesData Magikarp = new()
    {
        speciesName = "Magikarp",
        type1 = Water,
        type2 = Water,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 55,
        baseSpAtk = 15,
        baseSpDef = 20,
        baseSpeed = 80,
        evYield = Speed,
        evolution = Evolution.Magikarp,
        xpClass = Slow,
        xpYield = 40,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            SwiftSwim,
            Rattled,
        },
    };
    public static SpeciesData Gyarados = new()
    {
        speciesName = "Gyarados",
        type1 = Water,
        type2 = Flying,
        baseHP = 95,
        baseAttack = 125,
        baseDefense = 79,
        baseSpAtk = 60,
        baseSpDef = 100,
        baseSpeed = 81,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 189,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            Intimidate,
            Moxie,
        },
    };
    public static SpeciesData Lapras = new()
    {
        speciesName = "Lapras",
        type1 = Water,
        type2 = Ice,
        baseHP = 130,
        baseAttack = 85,
        baseDefense = 80,
        baseSpAtk = 85,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 187,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            ShellArmor,
            Hydration,
        },
    };
    public static SpeciesData Ditto = new()
    {
        speciesName = "Ditto",
        type1 = Normal,
        type2 = Normal,
        baseHP = 48,
        baseAttack = 48,
        baseDefense = 48,
        baseSpAtk = 48,
        baseSpDef = 48,
        baseSpeed = 48,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 101,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Limber,
            Limber,
            Imposter,
        },
    };
    public static SpeciesData Eevee = new()
    {
        speciesName = "Eevee",
        type1 = Normal,
        type2 = Normal,
        baseHP = 55,
        baseAttack = 55,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.Eevee,
        xpClass = MediumFast,
        xpYield = 65,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            Adaptability,
            Anticipation,
        },
    };
    public static SpeciesData Vaporeon = new()
    {
        speciesName = "Vaporeon",
        type1 = Water,
        type2 = Water,
        baseHP = 130,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 65,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            WaterAbsorb,
            Hydration,
        },
    };
    public static SpeciesData Jolteon = new()
    {
        speciesName = "Jolteon",
        type1 = Electric,
        type2 = Electric,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 110,
        baseSpDef = 95,
        baseSpeed = 130,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            VoltAbsorb,
            VoltAbsorb,
            QuickFeet,
        },
    };
    public static SpeciesData Flareon = new()
    {
        speciesName = "Flareon",
        type1 = Fire,
        type2 = Fire,
        baseHP = 65,
        baseAttack = 130,
        baseDefense = 60,
        baseSpAtk = 95,
        baseSpDef = 110,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            FlashFire,
            FlashFire,
            Guts,
        },
    };
    public static SpeciesData Porygon = new()
    {
        speciesName = "Porygon",
        type1 = Normal,
        type2 = Normal,
        baseHP = 65,
        baseAttack = 60,
        baseDefense = 70,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 79,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Trace,
            Download,
            Analytic,
        },
    };
    public static SpeciesData Omanyte = new()
    {
        speciesName = "Omanyte",
        type1 = Rock,
        type2 = Water,
        baseHP = 35,
        baseAttack = 40,
        baseDefense = 100,
        baseSpAtk = 90,
        baseSpDef = 55,
        baseSpeed = 35,
        evYield = Defense,
        evolution = Evolution.Omanyte,
        xpClass = MediumFast,
        xpYield = 71,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            ShellArmor,
            WeakArmor,
        },
    };
    public static SpeciesData Omastar = new()
    {
        speciesName = "Omastar",
        type1 = Rock,
        type2 = Water,
        baseHP = 70,
        baseAttack = 60,
        baseDefense = 125,
        baseSpAtk = 115,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            ShellArmor,
            WeakArmor,
        },
    };
    public static SpeciesData Kabuto = new()
    {
        speciesName = "Kabuto",
        type1 = Rock,
        type2 = Water,
        baseHP = 30,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 55,
        baseSpDef = 45,
        baseSpeed = 55,
        evYield = Defense,
        evolution = Evolution.Kabuto,
        xpClass = MediumFast,
        xpYield = 71,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            BattleArmor,
            WeakArmor,
        },
    };
    public static SpeciesData Kabutops = new()
    {
        speciesName = "Kabutops",
        type1 = Rock,
        type2 = Water,
        baseHP = 60,
        baseAttack = 115,
        baseDefense = 105,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 80,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            BattleArmor,
            WeakArmor,
        },
    };
    public static SpeciesData Aerodactyl = new()
    {
        speciesName = "Aerodactyl",
        type1 = Rock,
        type2 = Flying,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 65,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 130,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 180,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Pressure,
            Unnerve,
        },
    };
    public static SpeciesData Snorlax = new()
    {
        speciesName = "Snorlax",
        type1 = Normal,
        type2 = Normal,
        baseHP = 160,
        baseAttack = 110,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 189,
        learnset = EmptyLearnset, //Not done
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
            Immunity,
            ThickFat,
            Gluttony,
        },
    };
    public static SpeciesData Articuno = new()
    {
        speciesName = "Articuno",
        type1 = Ice,
        type2 = Flying,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 125,
        baseSpeed = 85,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            SnowCloak,
        },
    };
    public static SpeciesData Zapdos = new()
    {
        speciesName = "Zapdos",
        type1 = Electric,
        type2 = Flying,
        baseHP = 90,
        baseAttack = 90,
        baseDefense = 85,
        baseSpAtk = 125,
        baseSpDef = 90,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            Static,
        },
    };
    public static SpeciesData Moltres = new()
    {
        speciesName = "Moltres",
        type1 = Fire,
        type2 = Flying,
        baseHP = 90,
        baseAttack = 100,
        baseDefense = 90,
        baseSpAtk = 125,
        baseSpDef = 85,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            FlameBody,
        },
    };
    public static SpeciesData Dratini = new()
    {
        speciesName = "Dratini",
        type1 = Dragon,
        type2 = Dragon,
        baseHP = 41,
        baseAttack = 64,
        baseDefense = 45,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Dratini,
        xpClass = Slow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            MarvelScale,
        },
    };
    public static SpeciesData Dragonair = new()
    {
        speciesName = "Dragonair",
        type1 = Dragon,
        type2 = Dragon,
        baseHP = 61,
        baseAttack = 84,
        baseDefense = 65,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.Dragonair,
        xpClass = Slow,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            MarvelScale,
        },
    };
    public static SpeciesData Dragonite = new()
    {
        speciesName = "Dragonite",
        type1 = Dragon,
        type2 = Flying,
        baseHP = 91,
        baseAttack = 134,
        baseDefense = 95,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            InnerFocus,
            Multiscale,
        },
    };
    public static SpeciesData Mewtwo = new()
    {
        speciesName = "Mewtwo",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 106,
        baseAttack = 110,
        baseDefense = 90,
        baseSpAtk = 154,
        baseSpDef = 90,
        baseSpeed = 130,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 306,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            Unnerve,
        },
    };
    public static SpeciesData Mew = new()
    {
        speciesName = "Mew",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Synchronize,
            Synchronize,
            Synchronize,
        },
    };
    public static SpeciesData Chikorita = new()
    {
        speciesName = "Chikorita",
        type1 = Grass,
        type2 = Grass,
        baseHP = 45,
        baseAttack = 49,
        baseDefense = 65,
        baseSpAtk = 49,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = SpDef,
        evolution = Evolution.Chikorita,
        xpClass = MediumSlow,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            LeafGuard,
    },
    };
    public static SpeciesData Bayleef = new()
    {
        speciesName = "Bayleef",
        type1 = Grass,
        type2 = Grass,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 80,
        baseSpAtk = 63,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = Defense + SpDef,
        evolution = Evolution.Bayleef,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            LeafGuard,
        },
    };
    public static SpeciesData Meganium = new()
    {
        speciesName = "Meganium",
        type1 = Grass,
        type2 = Grass,
        baseHP = 80,
        baseAttack = 82,
        baseDefense = 100,
        baseSpAtk = 83,
        baseSpDef = 100,
        baseSpeed = 80,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 236,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            LeafGuard,
        },
    };
    public static SpeciesData Cyndaquil = new()
    {
        speciesName = "Cyndaquil",
        type1 = Fire,
        type2 = Fire,
        baseHP = 39,
        baseAttack = 52,
        baseDefense = 43,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Cyndaquil,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            FlashFire,
        },
    };
    public static SpeciesData Quilava = new()
    {
        speciesName = "Quilava",
        type1 = Fire,
        type2 = Fire,
        baseHP = 58,
        baseAttack = 64,
        baseDefense = 58,
        baseSpAtk = 80,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = Speed + SpAtk,
        evolution = Evolution.Quilava,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            FlashFire,
        },
    };
    public static SpeciesData Typhlosion = new()
    {
        speciesName = "Typhlosion",
        type1 = Fire,
        type2 = Fire,
        baseHP = 78,
        baseAttack = 84,
        baseDefense = 78,
        baseSpAtk = 109,
        baseSpDef = 85,
        baseSpeed = 100,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 240,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            FlashFire,
        },
    };
    public static SpeciesData Totodile = new()
    {
        speciesName = "Totodile",
        type1 = Water,
        type2 = Water,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 64,
        baseSpAtk = 44,
        baseSpDef = 48,
        baseSpeed = 43,
        evYield = Attack,
        evolution = Evolution.Totodile,
        xpClass = MediumSlow,
        xpYield = 63,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            SheerForce,
        },
    };
    public static SpeciesData Croconaw = new()
    {
        speciesName = "Croconaw",
        type1 = Water,
        type2 = Water,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 59,
        baseSpDef = 63,
        baseSpeed = 58,
        evYield = Attack + Defense,
        evolution = Evolution.Croconaw,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            SheerForce,
        },
    };
    public static SpeciesData Feraligatr = new()
    {
        speciesName = "Feraligatr",
        type1 = Water,
        type2 = Water,
        baseHP = 85,
        baseAttack = 105,
        baseDefense = 100,
        baseSpAtk = 79,
        baseSpDef = 83,
        baseSpeed = 78,
        evYield = 2 * Attack + Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            SheerForce,
        },
    };
    public static SpeciesData Sentret = new()
    {
        speciesName = "Sentret",
        type1 = Normal,
        type2 = Normal,
        baseHP = 35,
        baseAttack = 46,
        baseDefense = 34,
        baseSpAtk = 35,
        baseSpDef = 45,
        baseSpeed = 20,
        evYield = Attack,
        evolution = Evolution.Sentret,
        xpClass = MediumFast,
        xpYield = 43,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            KeenEye,
            Frisk,
        },
    };
    public static SpeciesData Furret = new()
    {
        speciesName = "Furret",
        type1 = Normal,
        type2 = Normal,
        baseHP = 85,
        baseAttack = 76,
        baseDefense = 64,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 145,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            KeenEye,
            Frisk,
        },
    };
    public static SpeciesData Hoothoot = new()
    {
        speciesName = "Hoothoot",
        type1 = Normal,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 36,
        baseSpDef = 56,
        baseSpeed = 50,
        evYield = HP,
        evolution = Evolution.Hoothoot,
        xpClass = MediumFast,
        xpYield = 52,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            KeenEye,
            TintedLens,
        },
    };
    public static SpeciesData Noctowl = new()
    {
        speciesName = "Noctowl",
        type1 = Normal,
        type2 = Flying,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 86,
        baseSpDef = 96,
        baseSpeed = 70,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            KeenEye,
            TintedLens,
        },
    };
    public static SpeciesData Ledyba = new()
    {
        speciesName = "Ledyba",
        type1 = Bug,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 20,
        baseDefense = 30,
        baseSpAtk = 40,
        baseSpDef = 80,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.Ledyba,
        xpClass = Fast,
        xpYield = 53,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            EarlyBird,
            Rattled,
        },
    };
    public static SpeciesData Ledian = new()
    {
        speciesName = "Ledian",
        type1 = Bug,
        type2 = Flying,
        baseHP = 55,
        baseAttack = 35,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 110,
        baseSpeed = 85,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 137,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            EarlyBird,
            IronFist,
        },
    };
    public static SpeciesData Spinarak = new()
    {
        speciesName = "Spinarak",
        type1 = Bug,
        type2 = Poison,
        baseHP = 40,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Attack,
        evolution = Evolution.Spinarak,
        xpClass = Fast,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Insomnia,
            Sniper,
        },
    };
    public static SpeciesData Ariados = new()
    {
        speciesName = "Ariados",
        type1 = Bug,
        type2 = Poison,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 40,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 140,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Insomnia,
            Sniper,
        },
    };
    public static SpeciesData Crobat = new()
    {
        speciesName = "Crobat",
        type1 = Poison,
        type2 = Flying,
        baseHP = 85,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 130,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 241,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            InnerFocus,
            Infiltrator,
        },
    };
    public static SpeciesData Chinchou = new()
    {
        speciesName = "Chinchou",
        type1 = Water,
        type2 = Electric,
        baseHP = 75,
        baseAttack = 38,
        baseDefense = 38,
        baseSpAtk = 56,
        baseSpDef = 56,
        baseSpeed = 67,
        evYield = HP,
        evolution = Evolution.Chinchou,
        xpClass = Slow,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            VoltAbsorb,
            Illuminate,
            WaterAbsorb,
        },
    };
    public static SpeciesData Lanturn = new()
    {
        speciesName = "Lanturn",
        type1 = Water,
        type2 = Electric,
        baseHP = 125,
        baseAttack = 58,
        baseDefense = 58,
        baseSpAtk = 76,
        baseSpDef = 76,
        baseSpeed = 67,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            VoltAbsorb,
            Illuminate,
            WaterAbsorb,
        },
    };

    public static SpeciesData Pichu = new()
    {
        speciesName = "Pichu",
        type1 = Electric,
        type2 = Electric,
        baseHP = 20,
        baseAttack = 40,
        baseDefense = 15,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.Pichu,
        xpClass = MediumFast,
        xpYield = 41,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            LightningRod,
        },
    };

    public static SpeciesData Cleffa = new()
    {
        speciesName = "Cleffa",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 50,
        baseAttack = 25,
        baseDefense = 28,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 15,
        evYield = SpDef,
        evolution = Evolution.Cleffa,
        xpClass = Fast,
        xpYield = 44,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            MagicGuard,
            FriendGuard,
        },
    };
    public static SpeciesData Igglybuff = new()
    {
        speciesName = "Igglybuff",
        type1 = Normal,
        type2 = Fairy,
        baseHP = 90,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 40,
        baseSpDef = 20,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Igglybuff,
        xpClass = Fast,
        xpYield = 42,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            Competitive,
            FriendGuard,
        },
    };
    public static SpeciesData Togepi = new()
    {
        speciesName = "Togepi",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 35,
        baseAttack = 20,
        baseDefense = 65,
        baseSpAtk = 40,
        baseSpDef = 65,
        baseSpeed = 20,
        evYield = SpDef,
        evolution = Evolution.Togepi,
        xpClass = Fast,
        xpYield = 49,
        learnset = EmptyLearnset, //Not done
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
            Hustle,
            SereneGrace,
            SuperLuck,
        },
    };
    public static SpeciesData Togetic = new()
    {
        speciesName = "Togetic",
        type1 = Fairy,
        type2 = Flying,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 85,
        baseSpAtk = 80,
        baseSpDef = 105,
        baseSpeed = 40,
        evYield = 2 * SpDef,
        evolution = Evolution.Togetic,
        xpClass = Fast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Hustle,
            SereneGrace,
            SuperLuck,
        },
    };
    public static SpeciesData Natu = new()
    {
        speciesName = "Natu",
        type1 = Psychic,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 45,
        baseSpeed = 70,
        evYield = SpAtk,
        evolution = Evolution.Natu,
        xpClass = MediumFast,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            EarlyBird,
            MagicBounce,
        },
    };
    public static SpeciesData Xatu = new()
    {
        speciesName = "Xatu",
        type1 = Psychic,
        type2 = Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 70,
        baseSpAtk = 95,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 165,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            EarlyBird,
            MagicBounce,
        },
    };
    public static SpeciesData Mareep = new()
    {
        speciesName = "Mareep",
        type1 = Electric,
        type2 = Electric,
        baseHP = 55,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.Mareep,
        xpClass = MediumSlow,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            Plus,
        },
    };
    public static SpeciesData Flaaffy = new()
    {
        speciesName = "Flaaffy",
        type1 = Electric,
        type2 = Electric,
        baseHP = 70,
        baseAttack = 55,
        baseDefense = 55,
        baseSpAtk = 80,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * SpAtk,
        evolution = Evolution.Flaaffy,
        xpClass = MediumSlow,
        xpYield = 128,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            Plus,
        },
    };
    public static SpeciesData Ampharos = new()
    {
        speciesName = "Ampharos",
        type1 = Electric,
        type2 = Electric,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 85,
        baseSpAtk = 115,
        baseSpDef = 90,
        baseSpeed = 55,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 230,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            Plus,
        },
    };
    public static SpeciesData Bellossom = new()
    {
        speciesName = "Bellossom",
        type1 = Grass,
        type2 = Grass,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 95,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 221,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            Chlorophyll,
            Healer,
        },
    };
    public static SpeciesData Marill = new()
    {
        speciesName = "Marill",
        type1 = Water,
        type2 = Fairy,
        baseHP = 70,
        baseAttack = 20,
        baseDefense = 50,
        baseSpAtk = 20,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = 2 * HP,
        evolution = Evolution.Marill,
        xpClass = Fast,
        xpYield = 88,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            HugePower,
            SapSipper,
        },
    };
    public static SpeciesData Azumarill = new()
    {
        speciesName = "Azumarill",
        type1 = Water,
        type2 = Fairy,
        baseHP = 100,
        baseAttack = 50,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 80,
        baseSpeed = 50,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 189,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            HugePower,
            SapSipper,
        },
    };
    public static SpeciesData Sudowoodo = new()
    {
        speciesName = "Sudowoodo",
        type1 = Rock,
        type2 = Rock,
        baseHP = 70,
        baseAttack = 100,
        baseDefense = 115,
        baseSpAtk = 30,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            RockHead,
            Rattled,
        },
    };
    public static SpeciesData Politoed = new()
    {
        speciesName = "Politoed",
        type1 = Water,
        type2 = Water,
        baseHP = 90,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 225,
        learnset = EmptyLearnset, //Not done
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
            WaterAbsorb,
            Damp,
            Drizzle,
        },
    };
    public static SpeciesData Hoppip = new()
    {
        speciesName = "Hoppip",
        type1 = Grass,
        type2 = Flying,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = SpDef,
        evolution = Evolution.Hoppip,
        xpClass = MediumSlow,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        },
    };
    public static SpeciesData Skiploom = new()
    {
        speciesName = "Skiploom",
        type1 = Grass,
        type2 = Flying,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 80,
        evYield = 2 * Speed,
        evolution = Evolution.Skiploom,
        xpClass = MediumSlow,
        xpYield = 119,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        },
    };
    public static SpeciesData Jumpluff = new()
    {
        speciesName = "Jumpluff",
        type1 = Grass,
        type2 = Flying,
        baseHP = 75,
        baseAttack = 55,
        baseDefense = 70,
        baseSpAtk = 55,
        baseSpDef = 95,
        baseSpeed = 110,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 207,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        },
    };
    public static SpeciesData Aipom = new()
    {
        speciesName = "Aipom",
        type1 = Normal,
        type2 = Normal,
        baseHP = 55,
        baseAttack = 70,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Aipom,
        xpClass = Fast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            Pickup,
            SkillLink,
        },
    };
    public static SpeciesData Sunkern = new()
    {
        speciesName = "Sunkern",
        type1 = Grass,
        type2 = Grass,
        baseHP = 30,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 30,
        evYield = SpAtk,
        evolution = Evolution.Sunkern,
        xpClass = MediumSlow,
        xpYield = 36,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            SolarPower,
            EarlyBird,
        },
    };
    public static SpeciesData Sunflora = new()
    {
        speciesName = "Sunflora",
        type1 = Grass,
        type2 = Grass,
        baseHP = 75,
        baseAttack = 75,
        baseDefense = 55,
        baseSpAtk = 105,
        baseSpDef = 85,
        baseSpeed = 30,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 149,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            SolarPower,
            EarlyBird,
        },
    };
    public static SpeciesData Yanma = new()
    {
        speciesName = "Yanma",
        type1 = Bug,
        type2 = Flying,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 75,
        baseSpDef = 45,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.Yanma,
        xpClass = MediumFast,
        xpYield = 78,
        learnset = EmptyLearnset, //Not done
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
            SpeedBoost,
            CompoundEyes,
            Frisk,
        },
    };
    public static SpeciesData Wooper = new()
    {
        speciesName = "Wooper",
        type1 = Water,
        type2 = Ground,
        baseHP = 55,
        baseAttack = 45,
        baseDefense = 45,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = HP,
        evolution = Evolution.Wooper,
        xpClass = MediumFast,
        xpYield = 42,
        learnset = EmptyLearnset, //Not done
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
            Damp,
            WaterAbsorb,
            Unaware,
        },
    };
    public static SpeciesData Quagsire = new()
    {
        speciesName = "Quagsire",
        type1 = Water,
        type2 = Ground,
        baseHP = 95,
        baseAttack = 85,
        baseDefense = 85,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 35,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 151,
        learnset = EmptyLearnset, //Not done
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
            Damp,
            WaterAbsorb,
            Unaware,
        },
    };
    public static SpeciesData Espeon = new()
    {
        speciesName = "Espeon",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 65,
        baseAttack = 65,
        baseDefense = 60,
        baseSpAtk = 130,
        baseSpDef = 95,
        baseSpeed = 110,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            Synchronize,
            MagicBounce,
        },
    };
    public static SpeciesData Umbreon = new()
    {
        speciesName = "Umbreon",
        type1 = Dark,
        type2 = Dark,
        baseHP = 95,
        baseAttack = 65,
        baseDefense = 110,
        baseSpAtk = 60,
        baseSpDef = 130,
        baseSpeed = 65,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
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
            Synchronize,
            Synchronize,
            InnerFocus,
        },
    };
    public static SpeciesData Murkrow = new()
    {
        speciesName = "Murkrow",
        type1 = Dark,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 42,
        baseSpAtk = 85,
        baseSpDef = 42,
        baseSpeed = 91,
        evYield = Speed,
        evolution = Evolution.Murkrow,
        xpClass = MediumSlow,
        xpYield = 81,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            SuperLuck,
            Prankster,
        },
    };
    public static SpeciesData Slowking = new()
    {
        speciesName = "Slowking",
        type1 = Water,
        type2 = Psychic,
        baseHP = 95,
        baseAttack = 75,
        baseDefense = 80,
        baseSpAtk = 100,
        baseSpDef = 110,
        baseSpeed = 30,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            OwnTempo,
            Regenerator,
        },
    };
    public static SpeciesData Misdreavus = new()
    {
        speciesName = "Misdreavus",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 85,
        baseSpDef = 85,
        baseSpeed = 85,
        evYield = SpDef,
        evolution = Evolution.Misdreavus,
        xpClass = Fast,
        xpYield = 87,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Unown = new()
    {
        speciesName = "Unown",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 48,
        baseAttack = 72,
        baseDefense = 48,
        baseSpAtk = 72,
        baseSpDef = 48,
        baseSpeed = 48,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 118,
        learnset = EmptyLearnset,
        malePercent = Genderless,
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Wobbuffet = new()
    {
        speciesName = "Wobbuffet",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 190,
        baseAttack = 33,
        baseDefense = 58,
        baseSpAtk = 33,
        baseSpDef = 58,
        baseSpeed = 33,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            ShadowTag,
            ShadowTag,
            Telepathy,
        },
    };
    public static SpeciesData Girafarig = new()
    {
        speciesName = "Girafarig",
        type1 = Normal,
        type2 = Psychic,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 65,
        baseSpAtk = 90,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            EarlyBird,
            SapSipper,
        },
    };
    public static SpeciesData Pineco = new()
    {
        speciesName = "Pineco",
        type1 = Bug,
        type2 = Bug,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 90,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 15,
        evYield = Defense,
        evolution = Evolution.Pineco,
        xpClass = MediumFast,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            Sturdy,
            Overcoat,
        },
    };
    public static SpeciesData Forretress = new()
    {
        speciesName = "Forretress",
        type1 = Bug,
        type2 = Steel,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 140,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            Sturdy,
            Overcoat,
        },
    };
    public static SpeciesData Dunsparce = new()
    {
        speciesName = "Dunsparce",
        type1 = Normal,
        type2 = Normal,
        baseHP = 100,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 45,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 145,
        learnset = EmptyLearnset, //Not done
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
            SereneGrace,
            RunAway,
            Rattled,
        },
    };
    public static SpeciesData Gligar = new()
    {
        speciesName = "Gligar",
        type1 = Ground,
        type2 = Flying,
        baseHP = 65,
        baseAttack = 75,
        baseDefense = 105,
        baseSpAtk = 35,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = Defense,
        evolution = Evolution.Gligar,
        xpClass = MediumSlow,
        xpYield = 86,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            SandVeil,
            Immunity,
        },
    };
    public static SpeciesData Steelix = new()
    {
        speciesName = "Steelix",
        type1 = Steel,
        type2 = Ground,
        baseHP = 75,
        baseAttack = 85,
        baseDefense = 200,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 179,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            Sturdy,
            SheerForce,
        },
    };
    public static SpeciesData Snubbull = new()
    {
        speciesName = "Snubbull",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Attack,
        evolution = Evolution.Snubbull,
        xpClass = Fast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            RunAway,
            Rattled,
        },
    };
    public static SpeciesData Granbull = new()
    {
        speciesName = "Granbull",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            QuickFeet,
            Rattled,
        },
    };
    public static SpeciesData Qwilfish = new()
    {
        speciesName = "Qwilfish",
        type1 = Water,
        type2 = Poison,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 85,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 88,
        learnset = EmptyLearnset, //Not done
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
            PoisonPoint,
            SwiftSwim,
            Intimidate,
        },
    };
    public static SpeciesData Scizor = new()
    {
        speciesName = "Scizor",
        type1 = Bug,
        type2 = Steel,
        baseHP = 70,
        baseAttack = 130,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Technician,
            LightMetal,
        },
    };
    public static SpeciesData Shuckle = new()
    {
        speciesName = "Shuckle",
        type1 = Bug,
        type2 = Rock,
        baseHP = 20,
        baseAttack = 10,
        baseDefense = 230,
        baseSpAtk = 10,
        baseSpDef = 230,
        baseSpeed = 5,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 177,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            Gluttony,
            Contrary,
        },
    };
    public static SpeciesData Heracross = new()
    {
        speciesName = "Heracross",
        type1 = Bug,
        type2 = Fighting,
        baseHP = 80,
        baseAttack = 125,
        baseDefense = 75,
        baseSpAtk = 40,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Guts,
            Moxie,
        },
    };
    public static SpeciesData Sneasel = new()
    {
        speciesName = "Sneasel",
        type1 = Dark,
        type2 = Ice,
        baseHP = 55,
        baseAttack = 95,
        baseDefense = 55,
        baseSpAtk = 35,
        baseSpDef = 75,
        baseSpeed = 115,
        evYield = Speed,
        evolution = Evolution.Sneasel,
        xpClass = MediumSlow,
        xpYield = 86,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            KeenEye,
            Pickpocket,
        },
    };
    public static SpeciesData Teddiursa = new()
    {
        speciesName = "Teddiursa",
        type1 = Normal,
        type2 = Normal,
        baseHP = 60,
        baseAttack = 80,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Teddiursa,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            Pickup,
            QuickFeet,
            HoneyGather,
        },
    };
    public static SpeciesData Ursaring = new()
    {
        speciesName = "Ursaring",
        type1 = Normal,
        type2 = Normal,
        baseHP = 90,
        baseAttack = 130,
        baseDefense = 75,
        baseSpAtk = 75,
        baseSpDef = 75,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            QuickFeet,
            Unnerve,
        },
    };
    public static SpeciesData Slugma = new()
    {
        speciesName = "Slugma",
        type1 = Fire,
        type2 = Fire,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 40,
        baseSpAtk = 70,
        baseSpDef = 40,
        baseSpeed = 20,
        evYield = SpAtk,
        evolution = Evolution.Slugma,
        xpClass = MediumFast,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
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
            MagmaArmor,
            FlameBody,
            WeakArmor,
        },
    };
    public static SpeciesData Magcargo = new()
    {
        speciesName = "Magcargo",
        type1 = Fire,
        type2 = Rock,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 120,
        baseSpAtk = 90,
        baseSpDef = 80,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 151,
        learnset = EmptyLearnset, //Not done
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
            MagmaArmor,
            FlameBody,
            WeakArmor,
        },
    };
    public static SpeciesData Swinub = new()
    {
        speciesName = "Swinub",
        type1 = Ice,
        type2 = Ground,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Swinub,
        xpClass = Slow,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            SnowCloak,
            ThickFat,
        },
    };
    public static SpeciesData Piloswine = new()
    {
        speciesName = "Piloswine",
        type1 = Ice,
        type2 = Ground,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = HP + Attack,
        evolution = Evolution.Piloswine,
        xpClass = Slow,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            SnowCloak,
            ThickFat,
        },
    };
    public static SpeciesData Corsola = new()
    {
        speciesName = "Corsola",
        type1 = Water,
        type2 = Rock,
        baseHP = 65,
        baseAttack = 55,
        baseDefense = 95,
        baseSpAtk = 65,
        baseSpDef = 95,
        baseSpeed = 35,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
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
            Hustle,
            NaturalCure,
            Regenerator,
        },
    };
    public static SpeciesData Remoraid = new()
    {
        speciesName = "Remoraid",
        type1 = Water,
        type2 = Water,
        baseHP = 35,
        baseAttack = 65,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 35,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Remoraid,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            Hustle,
            Sniper,
            Moody,
        },
    };
    public static SpeciesData Octillery = new()
    {
        speciesName = "Octillery",
        type1 = Water,
        type2 = Water,
        baseHP = 75,
        baseAttack = 105,
        baseDefense = 75,
        baseSpAtk = 105,
        baseSpDef = 75,
        baseSpeed = 45,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 168,
        learnset = EmptyLearnset, //Not done
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
            SuctionCups,
            Sniper,
            Moody,
        },
    };
    public static SpeciesData Delibird = new()
    {
        speciesName = "Delibird",
        type1 = Ice,
        type2 = Flying,
        baseHP = 45,
        baseAttack = 55,
        baseDefense = 45,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 116,
        learnset = EmptyLearnset, //Not done
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
            VitalSpirit,
            Hustle,
            Insomnia,
        },
    };
    public static SpeciesData Mantine = new()
    {
        speciesName = "Mantine",
        type1 = Water,
        type2 = Flying,
        baseHP = 85,
        baseAttack = 40,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 140,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            WaterAbsorb,
            WaterVeil,
        },
    };
    public static SpeciesData Skarmory = new()
    {
        speciesName = "Skarmory",
        type1 = Steel,
        type2 = Flying,
        baseHP = 65,
        baseAttack = 80,
        baseDefense = 140,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            Sturdy,
            WeakArmor,
        },
    };
    public static SpeciesData Houndour = new()
    {
        speciesName = "Houndour",
        type1 = Dark,
        type2 = Fire,
        baseHP = 45,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 80,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Houndour,
        xpClass = Slow,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            EarlyBird,
            FlashFire,
            Unnerve,
        },
    };
    public static SpeciesData Houndoom = new()
    {
        speciesName = "Houndoom",
        type1 = Dark,
        type2 = Fire,
        baseHP = 75,
        baseAttack = 90,
        baseDefense = 50,
        baseSpAtk = 110,
        baseSpDef = 80,
        baseSpeed = 95,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            EarlyBird,
            FlashFire,
            Unnerve,
        },
    };
    public static SpeciesData Kingdra = new()
    {
        speciesName = "Kingdra",
        type1 = Water,
        type2 = Dragon,
        baseHP = 75,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 95,
        baseSpeed = 85,
        evYield = Attack + SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 243,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            Sniper,
            Damp,
        },
    };
    public static SpeciesData Phanpy = new()
    {
        speciesName = "Phanpy",
        type1 = Ground,
        type2 = Ground,
        baseHP = 90,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 40,
        evYield = HP,
        evolution = Evolution.Phanpy,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            Pickup,
            Pickup,
            SandVeil,
        },
    };
    public static SpeciesData Donphan = new()
    {
        speciesName = "Donphan",
        type1 = Ground,
        type2 = Ground,
        baseHP = 90,
        baseAttack = 120,
        baseDefense = 120,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            Sturdy,
            SandVeil,
        },
    };
    public static SpeciesData Porygon2 = new()
    {
        speciesName = "Porygon2",
        type1 = Normal,
        type2 = Normal,
        baseHP = 85,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 105,
        baseSpDef = 95,
        baseSpeed = 60,
        evYield = 2 * SpAtk,
        evolution = Evolution.Porygon2,
        xpClass = MediumFast,
        xpYield = 180,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Trace,
            Download,
            Analytic,
        },
    };
    public static SpeciesData Stantler = new()
    {
        speciesName = "Stantler",
        type1 = Normal,
        type2 = Normal,
        baseHP = 73,
        baseAttack = 95,
        baseDefense = 62,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            Frisk,
            SapSipper,
        },
    };
    public static SpeciesData Smeargle = new()
    {
        speciesName = "Smeargle",
        type1 = Normal,
        type2 = Normal,
        baseHP = 55,
        baseAttack = 20,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 45,
        baseSpeed = 75,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 88,
        learnset = EmptyLearnset, //Not done
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
            OwnTempo,
            Technician,
            Moody,
        },
    };
    public static SpeciesData Tyrogue = new()
    {
        speciesName = "Tyrogue",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 35,
        baseAttack = 35,
        baseDefense = 35,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Tyrogue,
        xpClass = MediumFast,
        xpYield = 42,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            Steadfast,
            VitalSpirit,
        },
    };
    public static SpeciesData Hitmontop = new()
    {
        speciesName = "Hitmontop",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 50,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 35,
        baseSpDef = 110,
        baseSpeed = 70,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            Technician,
            Steadfast,
        },
    };
    public static SpeciesData Smoochum = new()
    {
        speciesName = "Smoochum",
        type1 = Ice,
        type2 = Psychic,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 15,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 65,
        evYield = SpAtk,
        evolution = Evolution.Smoochum,
        xpClass = MediumFast,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            Forewarn,
            Hydration,
        },
    };
    public static SpeciesData Elekid = new()
    {
        speciesName = "Elekid",
        type1 = Electric,
        type2 = Electric,
        baseHP = 45,
        baseAttack = 63,
        baseDefense = 37,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.Elekid,
        xpClass = MediumFast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            Static,
            Static,
            VitalSpirit,
        },
    };
    public static SpeciesData Magby = new()
    {
        speciesName = "Magby",
        type1 = Fire,
        type2 = Fire,
        baseHP = 45,
        baseAttack = 75,
        baseDefense = 37,
        baseSpAtk = 70,
        baseSpDef = 55,
        baseSpeed = 83,
        evYield = Speed,
        evolution = Evolution.Magby,
        xpClass = MediumFast,
        xpYield = 73,
        learnset = EmptyLearnset, //Not done
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
            FlameBody,
            FlameBody,
            VitalSpirit,
        },
    };
    public static SpeciesData Miltank = new()
    {
        speciesName = "Miltank",
        type1 = Normal,
        type2 = Normal,
        baseHP = 95,
        baseAttack = 80,
        baseDefense = 105,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 100,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            Scrappy,
            SapSipper,
        },
    };
    public static SpeciesData Blissey = new()
    {
        speciesName = "Blissey",
        type1 = Normal,
        type2 = Normal,
        baseHP = 255,
        baseAttack = 10,
        baseDefense = 10,
        baseSpAtk = 75,
        baseSpDef = 135,
        baseSpeed = 55,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 608,
        learnset = EmptyLearnset, //Not done
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
            NaturalCure,
            SereneGrace,
            Healer,
        },
    };
    public static SpeciesData Raikou = new()
    {
        speciesName = "Raikou",
        type1 = Electric,
        type2 = Electric,
        baseHP = 90,
        baseAttack = 85,
        baseDefense = 75,
        baseSpAtk = 115,
        baseSpDef = 100,
        baseSpeed = 115,
        evYield = 2 * Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            InnerFocus,
        },
    };
    public static SpeciesData Entei = new()
    {
        speciesName = "Entei",
        type1 = Fire,
        type2 = Fire,
        baseHP = 115,
        baseAttack = 115,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 75,
        baseSpeed = 100,
        evYield = HP + 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            InnerFocus,
        },
    };
    public static SpeciesData Suicune = new()
    {
        speciesName = "Suicune",
        type1 = Water,
        type2 = Water,
        baseHP = 100,
        baseAttack = 75,
        baseDefense = 115,
        baseSpAtk = 90,
        baseSpDef = 115,
        baseSpeed = 85,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            InnerFocus,
        },
    };
    public static SpeciesData Larvitar = new()
    {
        speciesName = "Larvitar",
        type1 = Rock,
        type2 = Ground,
        baseHP = 50,
        baseAttack = 64,
        baseDefense = 50,
        baseSpAtk = 45,
        baseSpDef = 50,
        baseSpeed = 41,
        evYield = Attack,
        evolution = Evolution.Larvitar,
        xpClass = Slow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            Guts,
            SandVeil,
        },
    };
    public static SpeciesData Pupitar = new()
    {
        speciesName = "Pupitar",
        type1 = Rock,
        type2 = Ground,
        baseHP = 70,
        baseAttack = 84,
        baseDefense = 70,
        baseSpAtk = 65,
        baseSpDef = 70,
        baseSpeed = 51,
        evYield = 2 * Attack,
        evolution = Evolution.Pupitar,
        xpClass = Slow,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            ShedSkin,
        },
    };
    public static SpeciesData Tyranitar = new()
    {
        speciesName = "Tyranitar",
        type1 = Rock,
        type2 = Dark,
        baseHP = 100,
        baseAttack = 134,
        baseDefense = 110,
        baseSpAtk = 95,
        baseSpDef = 100,
        baseSpeed = 61,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
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
            SandStream,
            SandStream,
            Unnerve,
        },
    };
    public static SpeciesData Lugia = new()
    {
        speciesName = "Lugia",
        type1 = Psychic,
        type2 = Flying,
        baseHP = 106,
        baseAttack = 90,
        baseDefense = 130,
        baseSpAtk = 90,
        baseSpDef = 154,
        baseSpeed = 110,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 306,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Pressure,
            Pressure,
            Multiscale,
        },
    };
    public static SpeciesData HoOh = new()
    {
        speciesName = "Ho Oh",
        type1 = Fire,
        type2 = Flying,
        baseHP = 106,
        baseAttack = 130,
        baseDefense = 90,
        baseSpAtk = 110,
        baseSpDef = 154,
        baseSpeed = 90,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 306,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "ho_oh", //Verify
        graphicsLocation = "ho_oh", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pressure,
            Pressure,
            Regenerator,
        },

    };
    public static SpeciesData Celebi = new()
    {
        speciesName = "Celebi",
        type1 = Psychic,
        type2 = Grass,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            NaturalCure,
            NaturalCure,
            NaturalCure,
        },
    };

    public static SpeciesData Treecko = new()
    {
        speciesName = "Treecko",
        type1 = Grass,
        type2 = Grass,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 70,
        evYield = Speed,
        evolution = Evolution.Treecko,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            Unburden,
        },
    };
    public static SpeciesData Grovyle = new()
    {
        speciesName = "Grovyle",
        type1 = Grass,
        type2 = Grass,
        baseHP = 50,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 85,
        baseSpDef = 65,
        baseSpeed = 95,
        evYield = 2 * Speed,
        evolution = Evolution.Grovyle,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            Unburden,
        },
    };
    public static SpeciesData Sceptile = new()
    {
        speciesName = "Sceptile",
        type1 = Grass,
        type2 = Grass,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 65,
        baseSpAtk = 105,
        baseSpDef = 85,
        baseSpeed = 120,
        evYield = 3 * Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            Overgrow,
            Overgrow,
            Unburden,
        },
    };
    public static SpeciesData Torchic = new()
    {
        speciesName = "Torchic",
        type1 = Fire,
        type2 = Fire,
        baseHP = 45,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 70,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Torchic,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SpeedBoost,
        },
    };
    public static SpeciesData Combusken = new()
    {
        speciesName = "Combusken",
        type1 = Fire,
        type2 = Fighting,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 60,
        baseSpAtk = 85,
        baseSpDef = 60,
        baseSpeed = 55,
        evYield = Attack + SpAtk,
        evolution = Evolution.Combusken,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SpeedBoost,
        },
    };
    public static SpeciesData Blaziken = new()
    {
        speciesName = "Blaziken",
        type1 = Fire,
        type2 = Fighting,
        baseHP = 80,
        baseAttack = 120,
        baseDefense = 70,
        baseSpAtk = 110,
        baseSpDef = 70,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            Blaze,
            Blaze,
            SpeedBoost,
        },
    };
    public static SpeciesData Mudkip = new()
    {
        speciesName = "Mudkip",
        type1 = Water,
        type2 = Water,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Mudkip,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            Damp,
        },
    };
    public static SpeciesData Marshtomp = new()
    {
        speciesName = "Marshtomp",
        type1 = Water,
        type2 = Ground,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 50,
        evYield = 2 * Attack,
        evolution = Evolution.Marshtomp,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            Damp,
        },
    };
    public static SpeciesData Swampert = new()
    {
        speciesName = "Swampert",
        type1 = Water,
        type2 = Ground,
        baseHP = 100,
        baseAttack = 110,
        baseDefense = 90,
        baseSpAtk = 85,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 241,
        learnset = EmptyLearnset, //Not done
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
            Torrent,
            Torrent,
            Damp,
        },
    };
    public static SpeciesData Poochyena = new()
    {
        speciesName = "Poochyena",
        type1 = Dark,
        type2 = Dark,
        baseHP = 35,
        baseAttack = 55,
        baseDefense = 35,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Poochyena,
        xpClass = MediumFast,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            RunAway,
            QuickFeet,
            Rattled,
        },
    };
    public static SpeciesData Mightyena = new()
    {
        speciesName = "Mightyena",
        type1 = Dark,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            QuickFeet,
            Moxie,
        },
    };
    public static SpeciesData Zigzagoon = new()
    {
        speciesName = "Zigzagoon",
        type1 = Normal,
        type2 = Normal,
        baseHP = 38,
        baseAttack = 30,
        baseDefense = 41,
        baseSpAtk = 30,
        baseSpDef = 41,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.Zigzagoon,
        xpClass = MediumFast,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            Pickup,
            Gluttony,
            QuickFeet,
        },
    };
    public static SpeciesData Linoone = new()
    {
        speciesName = "Linoone",
        type1 = Normal,
        type2 = Normal,
        baseHP = 78,
        baseAttack = 70,
        baseDefense = 61,
        baseSpAtk = 50,
        baseSpDef = 61,
        baseSpeed = 100,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
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
            Pickup,
            Gluttony,
            QuickFeet,
        },
    };
    public static SpeciesData Wurmple = new()
    {
        speciesName = "Wurmple",
        type1 = Bug,
        type2 = Bug,
        baseHP = 45,
        baseAttack = 45,
        baseDefense = 35,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 20,
        evYield = HP,
        evolution = Evolution.Wurmple,
        xpClass = MediumFast,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            ShieldDust,
            ShieldDust,
            RunAway,
        },
    };
    public static SpeciesData Silcoon = new()
    {
        speciesName = "Silcoon",
        type1 = Bug,
        type2 = Bug,
        baseHP = 50,
        baseAttack = 35,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = 2 * Defense,
        evolution = Evolution.Silcoon,
        xpClass = MediumFast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            ShedSkin,
        },
    };
    public static SpeciesData Beautifly = new()
    {
        speciesName = "Beautifly",
        type1 = Bug,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 100,
        baseSpDef = 50,
        baseSpeed = 65,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 178,
        learnset = EmptyLearnset, //Not done
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
            Swarm,
            Swarm,
            Rivalry,
        },
    };
    public static SpeciesData Cascoon = new()
    {
        speciesName = "Cascoon",
        type1 = Bug,
        type2 = Bug,
        baseHP = 50,
        baseAttack = 35,
        baseDefense = 55,
        baseSpAtk = 25,
        baseSpDef = 25,
        baseSpeed = 15,
        evYield = 2 * Defense,
        evolution = Evolution.Cascoon,
        xpClass = MediumFast,
        xpYield = 72,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            ShedSkin,
        },
    };
    public static SpeciesData Dustox = new()
    {
        speciesName = "Dustox",
        type1 = Bug,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 90,
        baseSpeed = 65,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            ShieldDust,
            ShieldDust,
            CompoundEyes,
        },
    };
    public static SpeciesData Lotad = new()
    {
        speciesName = "Lotad",
        type1 = Water,
        type2 = Grass,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 30,
        evYield = SpDef,
        evolution = Evolution.Lotad,
        xpClass = MediumSlow,
        xpYield = 44,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            RainDish,
            OwnTempo,
        },
    };
    public static SpeciesData Lombre = new()
    {
        speciesName = "Lombre",
        type1 = Water,
        type2 = Grass,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 50,
        evYield = 2 * SpDef,
        evolution = Evolution.Lombre,
        xpClass = MediumSlow,
        xpYield = 119,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            RainDish,
            OwnTempo,
        },
    };
    public static SpeciesData Ludicolo = new()
    {
        speciesName = "Ludicolo",
        type1 = Water,
        type2 = Grass,
        baseHP = 80,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 90,
        baseSpDef = 100,
        baseSpeed = 70,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 216,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            RainDish,
            OwnTempo,
        },
    };
    public static SpeciesData Seedot = new()
    {
        speciesName = "Seedot",
        type1 = Grass,
        type2 = Grass,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.Seedot,
        xpClass = MediumSlow,
        xpYield = 44,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        },
    };
    public static SpeciesData Nuzleaf = new()
    {
        speciesName = "Nuzleaf",
        type1 = Grass,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 70,
        baseDefense = 40,
        baseSpAtk = 60,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = 2 * Attack,
        evolution = Evolution.Nuzleaf,
        xpClass = MediumSlow,
        xpYield = 119,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        },
    };
    public static SpeciesData Shiftry = new()
    {
        speciesName = "Shiftry",
        type1 = Grass,
        type2 = Dark,
        baseHP = 90,
        baseAttack = 100,
        baseDefense = 60,
        baseSpAtk = 90,
        baseSpDef = 60,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 216,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        },
    };
    public static SpeciesData Taillow = new()
    {
        speciesName = "Taillow",
        type1 = Normal,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 55,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Taillow,
        xpClass = MediumSlow,
        xpYield = 54,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            Guts,
            Scrappy,
        },
    };
    public static SpeciesData Swellow = new()
    {
        speciesName = "Swellow",
        type1 = Normal,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 60,
        baseSpAtk = 75,
        baseSpDef = 50,
        baseSpeed = 125,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Guts,
            Guts,
            Scrappy,
        },
    };
    public static SpeciesData Wingull = new()
    {
        speciesName = "Wingull",
        type1 = Water,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 30,
        baseSpAtk = 55,
        baseSpDef = 30,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Wingull,
        xpClass = MediumFast,
        xpYield = 54,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            Hydration,
            RainDish,
        },
    };
    public static SpeciesData Pelipper = new()
    {
        speciesName = "Pelipper",
        type1 = Water,
        type2 = Flying,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 70,
        baseSpeed = 65,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            Drizzle,
            RainDish,
        },
    };
    public static SpeciesData Ralts = new()
    {
        speciesName = "Ralts",
        type1 = Psychic,
        type2 = Fairy,
        baseHP = 28,
        baseAttack = 25,
        baseDefense = 25,
        baseSpAtk = 45,
        baseSpDef = 35,
        baseSpeed = 40,
        evYield = SpAtk,
        evolution = Evolution.Ralts,
        xpClass = Slow,
        xpYield = 40,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
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
            Synchronize,
            Trace,
            Telepathy,
        },
    };
    public static SpeciesData Kirlia = new()
    {
        speciesName = "Kirlia",
        type1 = Psychic,
        type2 = Fairy,
        baseHP = 38,
        baseAttack = 35,
        baseDefense = 35,
        baseSpAtk = 65,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = 2 * SpAtk,
        evolution = Evolution.Kirlia,
        xpClass = Slow,
        xpYield = 97,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
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
            Synchronize,
            Trace,
            Telepathy,
        },
    };
    public static SpeciesData Gardevoir = new()
    {
        speciesName = "Gardevoir",
        type1 = Psychic,
        type2 = Fairy,
        baseHP = 68,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 125,
        baseSpDef = 115,
        baseSpeed = 80,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 233,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
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
            Synchronize,
            Trace,
            Telepathy,
        },
    };
    public static SpeciesData Surskit = new()
    {
        speciesName = "Surskit",
        type1 = Bug,
        type2 = Water,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 32,
        baseSpAtk = 50,
        baseSpDef = 52,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Surskit,
        xpClass = MediumFast,
        xpYield = 54,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            SwiftSwim,
            RainDish,
        },
    };
    public static SpeciesData Masquerain = new()
    {
        speciesName = "Masquerain",
        type1 = Bug,
        type2 = Flying,
        baseHP = 70,
        baseAttack = 60,
        baseDefense = 62,
        baseSpAtk = 100,
        baseSpDef = 82,
        baseSpeed = 80,
        evYield = SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            Intimidate,
            Unnerve,
        },
    };
    public static SpeciesData Shroomish = new()
    {
        speciesName = "Shroomish",
        type1 = Grass,
        type2 = Grass,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 60,
        baseSpeed = 35,
        evYield = HP,
        evolution = Evolution.Shroomish,
        xpClass = Fluctuating,
        xpYield = 59,
        learnset = EmptyLearnset, //Not done
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
            EffectSpore,
            PoisonHeal,
            QuickFeet,
        },
    };
    public static SpeciesData Breloom = new()
    {
        speciesName = "Breloom",
        type1 = Grass,
        type2 = Fighting,
        baseHP = 60,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            EffectSpore,
            PoisonHeal,
            Technician,
        },
    };
    public static SpeciesData Slakoth = new()
    {
        speciesName = "Slakoth",
        type1 = Normal,
        type2 = Normal,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 30,
        evYield = HP,
        evolution = Evolution.Slakoth,
        xpClass = Slow,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            Truant,
            Truant,
            Truant,
        },
    };
    public static SpeciesData Vigoroth = new()
    {
        speciesName = "Vigoroth",
        type1 = Normal,
        type2 = Normal,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = 2 * Speed,
        evolution = Evolution.Vigoroth,
        xpClass = Slow,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
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
            VitalSpirit,
            VitalSpirit,
            VitalSpirit,
        },
    };
    public static SpeciesData Slaking = new()
    {
        speciesName = "Slaking",
        type1 = Normal,
        type2 = Normal,
        baseHP = 150,
        baseAttack = 160,
        baseDefense = 100,
        baseSpAtk = 95,
        baseSpDef = 65,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 252,
        learnset = EmptyLearnset, //Not done
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
            Truant,
            Truant,
            Truant,
        },
    };
    public static SpeciesData Nincada = new()
    {
        speciesName = "Nincada",
        type1 = Bug,
        type2 = Ground,
        baseHP = 31,
        baseAttack = 45,
        baseDefense = 90,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = Defense,
        evolution = Evolution.Nincada,
        xpClass = Erratic,
        xpYield = 53,
        learnset = EmptyLearnset, //Not done
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
            CompoundEyes,
            CompoundEyes,
            RunAway,
        },
    };
    public static SpeciesData Ninjask = new()
    {
        speciesName = "Ninjask",
        type1 = Bug,
        type2 = Flying,
        baseHP = 61,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 160,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 160,
        learnset = EmptyLearnset, //Not done
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
            SpeedBoost,
            SpeedBoost,
            Infiltrator,
        },
    };
    public static SpeciesData Shedinja = new()
    {
        speciesName = "Shedinja",
        type1 = Bug,
        type2 = Ghost,
        baseHP = 1,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 40,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 83,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            WonderGuard,
            WonderGuard,
            WonderGuard,
        },
    };
    public static SpeciesData Whismur = new()
    {
        speciesName = "Whismur",
        type1 = Normal,
        type2 = Normal,
        baseHP = 64,
        baseAttack = 51,
        baseDefense = 23,
        baseSpAtk = 51,
        baseSpDef = 23,
        baseSpeed = 28,
        evYield = HP,
        evolution = Evolution.Whismur,
        xpClass = MediumSlow,
        xpYield = 48,
        learnset = EmptyLearnset, //Not done
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
            Soundproof,
            Soundproof,
            Rattled,
        },
    };
    public static SpeciesData Loudred = new()
    {
        speciesName = "Loudred",
        type1 = Normal,
        type2 = Normal,
        baseHP = 84,
        baseAttack = 71,
        baseDefense = 43,
        baseSpAtk = 71,
        baseSpDef = 43,
        baseSpeed = 48,
        evYield = 2 * HP,
        evolution = Evolution.Loudred,
        xpClass = MediumSlow,
        xpYield = 126,
        learnset = EmptyLearnset, //Not done
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
            Soundproof,
            Soundproof,
            Scrappy,
        },
    };
    public static SpeciesData Exploud = new()
    {
        speciesName = "Exploud",
        type1 = Normal,
        type2 = Normal,
        baseHP = 104,
        baseAttack = 91,
        baseDefense = 63,
        baseSpAtk = 91,
        baseSpDef = 73,
        baseSpeed = 68,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 221,
        learnset = EmptyLearnset, //Not done
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
            Soundproof,
            Soundproof,
            Scrappy,
        },
    };
    public static SpeciesData Makuhita = new()
    {
        speciesName = "Makuhita",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 72,
        baseAttack = 60,
        baseDefense = 30,
        baseSpAtk = 20,
        baseSpDef = 30,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.Makuhita,
        xpClass = Fluctuating,
        xpYield = 47,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            Guts,
            SheerForce,
        },
    };
    public static SpeciesData Hariyama = new()
    {
        speciesName = "Hariyama",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 144,
        baseAttack = 120,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            Guts,
            SheerForce,
        },
    };
    public static SpeciesData Azurill = new()
    {
        speciesName = "Azurill",
        type1 = Normal,
        type2 = Fairy,
        baseHP = 50,
        baseAttack = 20,
        baseDefense = 40,
        baseSpAtk = 20,
        baseSpDef = 40,
        baseSpeed = 20,
        evYield = HP,
        evolution = Evolution.Azurill,
        xpClass = Fast,
        xpYield = 38,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            HugePower,
            SapSipper,
        },
    };
    public static SpeciesData Nosepass = new()
    {
        speciesName = "Nosepass",
        type1 = Rock,
        type2 = Rock,
        baseHP = 30,
        baseAttack = 45,
        baseDefense = 135,
        baseSpAtk = 45,
        baseSpDef = 90,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.Nosepass, //Not done
        xpClass = MediumFast,
        xpYield = 75,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            MagnetPull,
            SandForce,
        },
    };
    public static SpeciesData Skitty = new()
    {
        speciesName = "Skitty",
        type1 = Normal,
        type2 = Normal,
        baseHP = 50,
        baseAttack = 45,
        baseDefense = 45,
        baseSpAtk = 35,
        baseSpDef = 35,
        baseSpeed = 50,
        evYield = Speed,
        evolution = Evolution.Skitty,
        xpClass = Fast,
        xpYield = 52,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            Normalize,
            WonderSkin,
        },
    };
    public static SpeciesData Delcatty = new()
    {
        speciesName = "Delcatty",
        type1 = Normal,
        type2 = Normal,
        baseHP = 70,
        baseAttack = 65,
        baseDefense = 65,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 90,
        evYield = HP + Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 140,
        learnset = EmptyLearnset, //Not done
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
            CuteCharm,
            Normalize,
            WonderSkin,
        },
    };
    public static SpeciesData Sableye = new()
    {
        speciesName = "Sableye",
        type1 = Dark,
        type2 = Ghost,
        baseHP = 50,
        baseAttack = 75,
        baseDefense = 75,
        baseSpAtk = 65,
        baseSpDef = 65,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 133,
        learnset = EmptyLearnset, //Not done
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
            KeenEye,
            Stall,
            Prankster,
        },
    };
    public static SpeciesData Mawile = new()
    {
        speciesName = "Mawile",
        type1 = Steel,
        type2 = Fairy,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 50,
        evYield = Attack + Defense,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 133,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            Intimidate,
            SheerForce,
        },
    };
    public static SpeciesData Aron = new()
    {
        speciesName = "Aron",
        type1 = Steel,
        type2 = Rock,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 100,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.Aron,
        xpClass = Slow,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            RockHead,
            HeavyMetal,
        },
    };
    public static SpeciesData Lairon = new()
    {
        speciesName = "Lairon",
        type1 = Steel,
        type2 = Rock,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 140,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 40,
        evYield = 2 * Defense,
        evolution = Evolution.Lairon,
        xpClass = Slow,
        xpYield = 151,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            RockHead,
            HeavyMetal,
        },
    };
    public static SpeciesData Aggron = new()
    {
        speciesName = "Aggron",
        type1 = Steel,
        type2 = Rock,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 180,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 50,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            Sturdy,
            RockHead,
            HeavyMetal,
        },
    };
    public static SpeciesData Meditite = new()
    {
        speciesName = "Meditite",
        type1 = Fighting,
        type2 = Psychic,
        baseHP = 30,
        baseAttack = 40,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 55,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.Meditite,
        xpClass = MediumFast,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
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
            PurePower,
            PurePower,
            Telepathy,
        },
    };
    public static SpeciesData Medicham = new()
    {
        speciesName = "Medicham",
        type1 = Fighting,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 75,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 80,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
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
            PurePower,
            PurePower,
            Telepathy,
        },
    };
    public static SpeciesData Electrike = new()
    {
        speciesName = "Electrike",
        type1 = Electric,
        type2 = Electric,
        baseHP = 40,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 40,
        baseSpeed = 65,
        evYield = Speed,
        evolution = Evolution.Electrike,
        xpClass = Slow,
        xpYield = 59,
        learnset = EmptyLearnset, //Not done
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
            Static,
            LightningRod,
            Minus,
        },
    };
    public static SpeciesData Manectric = new()
    {
        speciesName = "Manectric",
        type1 = Electric,
        type2 = Electric,
        baseHP = 70,
        baseAttack = 75,
        baseDefense = 60,
        baseSpAtk = 105,
        baseSpDef = 60,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
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
            Static,
            LightningRod,
            Minus,
        },
    };
    public static SpeciesData Plusle = new()
    {
        speciesName = "Plusle",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 50,
        baseDefense = 40,
        baseSpAtk = 85,
        baseSpDef = 75,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Plus,
            Plus,
            LightningRod,
        },
    };
    public static SpeciesData Minun = new()
    {
        speciesName = "Minun",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
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
            Minus,
            Minus,
            VoltAbsorb,
        },
    };
    public static SpeciesData Volbeat = new()
    {
        speciesName = "Volbeat",
        type1 = Bug,
        type2 = Bug,
        baseHP = 65,
        baseAttack = 73,
        baseDefense = 75,
        baseSpAtk = 47,
        baseSpDef = 85,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 151,
        learnset = EmptyLearnset, //Not done
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
            Illuminate,
            Swarm,
            Prankster,
        },
    };
    public static SpeciesData Illumise = new()
    {
        speciesName = "Illumise",
        type1 = Bug,
        type2 = Bug,
        baseHP = 65,
        baseAttack = 47,
        baseDefense = 75,
        baseSpAtk = 73,
        baseSpDef = 85,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 151,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            TintedLens,
            Prankster,
        },
    };
    public static SpeciesData Roselia = new()
    {
        speciesName = "Roselia",
        type1 = Grass,
        type2 = Poison,
        baseHP = 50,
        baseAttack = 60,
        baseDefense = 45,
        baseSpAtk = 100,
        baseSpDef = 80,
        baseSpeed = 65,
        evYield = 2 * SpAtk,
        evolution = Evolution.Roselia, //Not done
        xpClass = MediumSlow,
        xpYield = 140,
        learnset = EmptyLearnset, //Not done
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
            NaturalCure,
            PoisonPoint,
            LeafGuard,
        },
    };
    public static SpeciesData Gulpin = new()
    {
        speciesName = "Gulpin",
        type1 = Poison,
        type2 = Poison,
        baseHP = 70,
        baseAttack = 43,
        baseDefense = 53,
        baseSpAtk = 43,
        baseSpDef = 53,
        baseSpeed = 40,
        evYield = HP,
        evolution = Evolution.Gulpin,
        xpClass = Fluctuating,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            LiquidOoze,
            StickyHold,
            Gluttony,
        },
    };
    public static SpeciesData Swalot = new()
    {
        speciesName = "Swalot",
        type1 = Poison,
        type2 = Poison,
        baseHP = 100,
        baseAttack = 73,
        baseDefense = 83,
        baseSpAtk = 73,
        baseSpDef = 83,
        baseSpeed = 55,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
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
            LiquidOoze,
            StickyHold,
            Gluttony,
        },
    };
    public static SpeciesData Carvanha = new()
    {
        speciesName = "Carvanha",
        type1 = Water,
        type2 = Dark,
        baseHP = 45,
        baseAttack = 90,
        baseDefense = 20,
        baseSpAtk = 65,
        baseSpDef = 20,
        baseSpeed = 65,
        evYield = Attack,
        evolution = Evolution.Carvanha,
        xpClass = Slow,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            RoughSkin,
            RoughSkin,
            SpeedBoost,
        },
    };
    public static SpeciesData Sharpedo = new()
    {
        speciesName = "Sharpedo",
        type1 = Water,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 120,
        baseDefense = 40,
        baseSpAtk = 95,
        baseSpDef = 40,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            RoughSkin,
            RoughSkin,
            SpeedBoost,
        },
    };
    public static SpeciesData Wailmer = new()
    {
        speciesName = "Wailmer",
        type1 = Water,
        type2 = Water,
        baseHP = 130,
        baseAttack = 70,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 35,
        baseSpeed = 60,
        evYield = HP,
        evolution = Evolution.Wailmer,
        xpClass = Fluctuating,
        xpYield = 80,
        learnset = EmptyLearnset, //Not done
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
            WaterVeil,
            Oblivious,
            Pressure,
        },
    };
    public static SpeciesData Wailord = new()
    {
        speciesName = "Wailord",
        type1 = Water,
        type2 = Water,
        baseHP = 170,
        baseAttack = 90,
        baseDefense = 45,
        baseSpAtk = 90,
        baseSpDef = 45,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
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
            WaterVeil,
            Oblivious,
            Pressure,
        },
    };
    public static SpeciesData Numel = new()
    {
        speciesName = "Numel",
        type1 = Fire,
        type2 = Ground,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 40,
        baseSpAtk = 65,
        baseSpDef = 45,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.Numel,
        xpClass = MediumFast,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            Simple,
            OwnTempo,
        },
    };
    public static SpeciesData Camerupt = new()
    {
        speciesName = "Camerupt",
        type1 = Fire,
        type2 = Ground,
        baseHP = 70,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 105,
        baseSpDef = 75,
        baseSpeed = 40,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            MagmaArmor,
            SolidRock,
            AngerPoint,
        },
    };
    public static SpeciesData Torkoal = new()
    {
        speciesName = "Torkoal",
        type1 = Fire,
        type2 = Fire,
        baseHP = 70,
        baseAttack = 85,
        baseDefense = 140,
        baseSpAtk = 85,
        baseSpDef = 70,
        baseSpeed = 20,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 165,
        learnset = EmptyLearnset, //Not done
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
            WhiteSmoke,
            Drought,
            ShellArmor,
        },
    };
    public static SpeciesData Spoink = new()
    {
        speciesName = "Spoink",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 25,
        baseDefense = 35,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 60,
        evYield = SpDef,
        evolution = Evolution.Spoink,
        xpClass = Fast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            OwnTempo,
            Gluttony,
        },
    };
    public static SpeciesData Grumpig = new()
    {
        speciesName = "Grumpig",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 80,
        baseAttack = 45,
        baseDefense = 65,
        baseSpAtk = 90,
        baseSpDef = 110,
        baseSpeed = 80,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 165,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            OwnTempo,
            Gluttony,
        },
    };
    public static SpeciesData Spinda = new()
    {
        speciesName = "Spinda",
        type1 = Normal,
        type2 = Normal,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 60,
        evYield = SpAtk,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 126,
        learnset = EmptyLearnset, //Not done
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
            OwnTempo,
            TangledFeet,
            Contrary,
        },
    };
    public static SpeciesData Trapinch = new()
    {
        speciesName = "Trapinch",
        type1 = Ground,
        type2 = Ground,
        baseHP = 45,
        baseAttack = 100,
        baseDefense = 45,
        baseSpAtk = 45,
        baseSpDef = 45,
        baseSpeed = 10,
        evYield = Attack,
        evolution = Evolution.Trapinch,
        xpClass = MediumSlow,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "trapinch", //Verify
        graphicsLocation = "trapinch", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            HyperCutter,
            ArenaTrap,
            SheerForce,
        },
    };
    public static SpeciesData Vibrava = new()
    {
        speciesName = "Vibrava",
        type1 = Ground,
        type2 = Dragon,
        baseHP = 50,
        baseAttack = 70,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 70,
        evYield = Attack + Speed,
        evolution = Evolution.Vibrava,
        xpClass = MediumSlow,
        xpYield = 119,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "vibrava", //Verify
        graphicsLocation = "vibrava", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Flygon = new()
    {
        speciesName = "Flygon",
        type1 = Ground,
        type2 = Dragon,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 80,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = Attack + 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 234,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "flygon", //Verify
        graphicsLocation = "flygon", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Cacnea = new()
    {
        speciesName = "Cacnea",
        type1 = Grass,
        type2 = Grass,
        baseHP = 50,
        baseAttack = 85,
        baseDefense = 40,
        baseSpAtk = 85,
        baseSpDef = 40,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.Cacnea,
        xpClass = MediumSlow,
        xpYield = 67,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            SandVeil,
            WaterAbsorb,
        },
    };
    public static SpeciesData Cacturne = new()
    {
        speciesName = "Cacturne",
        type1 = Grass,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 115,
        baseDefense = 60,
        baseSpAtk = 115,
        baseSpDef = 60,
        baseSpeed = 55,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
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
            SandVeil,
            SandVeil,
            WaterAbsorb,
        },
    };
    public static SpeciesData Swablu = new()
    {
        speciesName = "Swablu",
        type1 = Normal,
        type2 = Flying,
        baseHP = 45,
        baseAttack = 40,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 75,
        baseSpeed = 50,
        evYield = SpDef,
        evolution = Evolution.Swablu,
        xpClass = Erratic,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            NaturalCure,
            NaturalCure,
            CloudNine,
        },
    };
    public static SpeciesData Altaria = new()
    {
        speciesName = "Altaria",
        type1 = Dragon,
        type2 = Flying,
        baseHP = 75,
        baseAttack = 70,
        baseDefense = 90,
        baseSpAtk = 70,
        baseSpDef = 105,
        baseSpeed = 80,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
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
            NaturalCure,
            NaturalCure,
            CloudNine,
        },
    };
    public static SpeciesData Zangoose = new()
    {
        speciesName = "Zangoose",
        type1 = Normal,
        type2 = Normal,
        baseHP = 73,
        baseAttack = 115,
        baseDefense = 60,
        baseSpAtk = 60,
        baseSpDef = 60,
        baseSpeed = 90,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 160,
        learnset = EmptyLearnset, //Not done
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
            Immunity,
            Immunity,
            ToxicBoost,
        },
    };
    public static SpeciesData Seviper = new()
    {
        speciesName = "Seviper",
        type1 = Poison,
        type2 = Poison,
        baseHP = 73,
        baseAttack = 100,
        baseDefense = 60,
        baseSpAtk = 100,
        baseSpDef = 60,
        baseSpeed = 65,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 160,
        learnset = EmptyLearnset, //Not done
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
            ShedSkin,
            ShedSkin,
            Infiltrator,
        },
    };
    public static SpeciesData Lunatone = new()
    {
        speciesName = "Lunatone",
        type1 = Rock,
        type2 = Psychic,
        baseHP = 90,
        baseAttack = 55,
        baseDefense = 65,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 70,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Solrock = new()
    {
        speciesName = "Solrock",
        type1 = Rock,
        type2 = Psychic,
        baseHP = 90,
        baseAttack = 95,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 70,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Barboach = new()
    {
        speciesName = "Barboach",
        type1 = Water,
        type2 = Ground,
        baseHP = 50,
        baseAttack = 48,
        baseDefense = 43,
        baseSpAtk = 46,
        baseSpDef = 41,
        baseSpeed = 60,
        evYield = HP,
        evolution = Evolution.Barboach,
        xpClass = MediumFast,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            Anticipation,
            Hydration,
        },
    };
    public static SpeciesData Whiscash = new()
    {
        speciesName = "Whiscash",
        type1 = Water,
        type2 = Ground,
        baseHP = 110,
        baseAttack = 78,
        baseDefense = 73,
        baseSpAtk = 76,
        baseSpDef = 71,
        baseSpeed = 60,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 164,
        learnset = EmptyLearnset, //Not done
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
            Oblivious,
            Anticipation,
            Hydration,
        },
    };
    public static SpeciesData Corphish = new()
    {
        speciesName = "Corphish",
        type1 = Water,
        type2 = Water,
        baseHP = 43,
        baseAttack = 80,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 35,
        baseSpeed = 35,
        evYield = Attack,
        evolution = Evolution.Corphish,
        xpClass = Fluctuating,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            ShellArmor,
            Adaptability,
        },
    };
    public static SpeciesData Crawdaunt = new()
    {
        speciesName = "Crawdaunt",
        type1 = Water,
        type2 = Dark,
        baseHP = 63,
        baseAttack = 120,
        baseDefense = 85,
        baseSpAtk = 90,
        baseSpDef = 55,
        baseSpeed = 55,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 164,
        learnset = EmptyLearnset, //Not done
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
            HyperCutter,
            ShellArmor,
            Adaptability,
        },
    };
    public static SpeciesData Baltoy = new()
    {
        speciesName = "Baltoy",
        type1 = Ground,
        type2 = Psychic,
        baseHP = 40,
        baseAttack = 40,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = SpDef,
        evolution = Evolution.Baltoy,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Claydol = new()
    {
        speciesName = "Claydol",
        type1 = Ground,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 70,
        baseDefense = 105,
        baseSpAtk = 70,
        baseSpDef = 120,
        baseSpeed = 75,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Lileep = new()
    {
        speciesName = "Lileep",
        type1 = Rock,
        type2 = Grass,
        baseHP = 66,
        baseAttack = 41,
        baseDefense = 77,
        baseSpAtk = 61,
        baseSpDef = 87,
        baseSpeed = 23,
        evYield = SpDef,
        evolution = Evolution.Lileep,
        xpClass = Erratic,
        xpYield = 71,
        learnset = EmptyLearnset, //Not done
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
            SuctionCups,
            SuctionCups,
            StormDrain,
        },
    };
    public static SpeciesData Cradily = new()
    {
        speciesName = "Cradily",
        type1 = Rock,
        type2 = Grass,
        baseHP = 86,
        baseAttack = 81,
        baseDefense = 97,
        baseSpAtk = 81,
        baseSpDef = 107,
        baseSpeed = 43,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            SuctionCups,
            SuctionCups,
            StormDrain,
        },
    };
    public static SpeciesData Anorith = new()
    {
        speciesName = "Anorith",
        type1 = Rock,
        type2 = Bug,
        baseHP = 45,
        baseAttack = 95,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = Attack,
        evolution = Evolution.Anorith,
        xpClass = Erratic,
        xpYield = 71,
        learnset = EmptyLearnset, //Not done
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
            BattleArmor,
            BattleArmor,
            SwiftSwim,
        },
    };
    public static SpeciesData Armaldo = new()
    {
        speciesName = "Armaldo",
        type1 = Rock,
        type2 = Bug,
        baseHP = 75,
        baseAttack = 125,
        baseDefense = 100,
        baseSpAtk = 70,
        baseSpDef = 80,
        baseSpeed = 45,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
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
            BattleArmor,
            BattleArmor,
            SwiftSwim,
        },
    };
    public static SpeciesData Feebas = new()
    {
        speciesName = "Feebas",
        type1 = Water,
        type2 = Water,
        baseHP = 20,
        baseAttack = 15,
        baseDefense = 20,
        baseSpAtk = 10,
        baseSpDef = 55,
        baseSpeed = 80,
        evYield = Speed,
        evolution = Evolution.Feebas,
        xpClass = Erratic,
        xpYield = 40,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            Oblivious,
            Adaptability,
        },
    };
    public static SpeciesData Milotic = new()
    {
        speciesName = "Milotic",
        type1 = Water,
        type2 = Water,
        baseHP = 95,
        baseAttack = 60,
        baseDefense = 79,
        baseSpAtk = 100,
        baseSpDef = 125,
        baseSpeed = 81,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 189,
        learnset = EmptyLearnset, //Not done
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
            MarvelScale,
            Competitive,
            CuteCharm,
        },
    };

    public static SpeciesData Castform = Castform(
        Normal, "castform/normal", 0);

    public static SpeciesData Kecleon = new()
    {
        speciesName = "Kecleon",
        type1 = Normal,
        type2 = Normal,
        baseHP = 60,
        baseAttack = 90,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 120,
        baseSpeed = 40,
        evYield = SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
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
            ColorChange,
            ColorChange,
            Protean,
        },
    };
    public static SpeciesData Shuppet = new()
    {
        speciesName = "Shuppet",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 44,
        baseAttack = 75,
        baseDefense = 35,
        baseSpAtk = 63,
        baseSpDef = 33,
        baseSpeed = 45,
        evYield = Attack,
        evolution = Evolution.Shuppet,
        xpClass = Fast,
        xpYield = 59,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            Frisk,
            CursedBody,
        },
    };
    public static SpeciesData Banette = new()
    {
        speciesName = "Banette",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 64,
        baseAttack = 115,
        baseDefense = 65,
        baseSpAtk = 83,
        baseSpDef = 63,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Insomnia,
            Frisk,
            CursedBody,
        },
    };
    public static SpeciesData Duskull = new()
    {
        speciesName = "Duskull",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 20,
        baseAttack = 40,
        baseDefense = 90,
        baseSpAtk = 30,
        baseSpDef = 90,
        baseSpeed = 25,
        evYield = SpDef,
        evolution = Evolution.Duskull,
        xpClass = Fast,
        xpYield = 59,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Frisk,
        },
    };
    public static SpeciesData Dusclops = new()
    {
        speciesName = "Dusclops",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 40,
        baseAttack = 70,
        baseDefense = 130,
        baseSpAtk = 60,
        baseSpDef = 130,
        baseSpeed = 25,
        evYield = Defense + SpDef,
        evolution = Evolution.Dusclops, //Not done
        xpClass = Fast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Pressure,
            Pressure,
            Frisk,
        },
    };
    public static SpeciesData Tropius = new()
    {
        speciesName = "Tropius",
        type1 = Grass,
        type2 = Flying,
        baseHP = 99,
        baseAttack = 68,
        baseDefense = 83,
        baseSpAtk = 72,
        baseSpDef = 87,
        baseSpeed = 51,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
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
            Chlorophyll,
            SolarPower,
            Harvest,
        },
    };
    public static SpeciesData Chimecho = new()
    {
        speciesName = "Chimecho",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 75,
        baseAttack = 50,
        baseDefense = 80,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 65,
        evYield = SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Absol = new()
    {
        speciesName = "Absol",
        type1 = Dark,
        type2 = Dark,
        baseHP = 65,
        baseAttack = 130,
        baseDefense = 60,
        baseSpAtk = 75,
        baseSpDef = 60,
        baseSpeed = 75,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 163,
        learnset = EmptyLearnset, //Not done
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
            Pressure,
            SuperLuck,
            Justified,
        },
    };
    public static SpeciesData Wynaut = new()
    {
        speciesName = "Wynaut",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 95,
        baseAttack = 23,
        baseDefense = 48,
        baseSpAtk = 23,
        baseSpDef = 48,
        baseSpeed = 23,
        evYield = HP,
        evolution = Evolution.Wynaut,
        xpClass = MediumFast,
        xpYield = 52,
        learnset = EmptyLearnset, //Not done
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
            ShadowTag,
            ShadowTag,
            Telepathy,
        },
    };
    public static SpeciesData Snorunt = new()
    {
        speciesName = "Snorunt",
        type1 = Ice,
        type2 = Ice,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 50,
        baseSpAtk = 50,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = HP,
        evolution = Evolution.Snorunt,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            IceBody,
            Moody,
        },
    };
    public static SpeciesData Glalie = new()
    {
        speciesName = "Glalie",
        type1 = Ice,
        type2 = Ice,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 80,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 168,
        learnset = EmptyLearnset, //Not done
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
            InnerFocus,
            IceBody,
            Moody,
        },
    };
    public static SpeciesData Spheal = new()
    {
        speciesName = "Spheal",
        type1 = Ice,
        type2 = Water,
        baseHP = 70,
        baseAttack = 40,
        baseDefense = 50,
        baseSpAtk = 55,
        baseSpDef = 50,
        baseSpeed = 25,
        evYield = HP,
        evolution = Evolution.Spheal,
        xpClass = MediumSlow,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            IceBody,
            Oblivious,
        },
    };
    public static SpeciesData Sealeo = new()
    {
        speciesName = "Sealeo",
        type1 = Ice,
        type2 = Water,
        baseHP = 90,
        baseAttack = 60,
        baseDefense = 70,
        baseSpAtk = 75,
        baseSpDef = 70,
        baseSpeed = 45,
        evYield = 2 * HP,
        evolution = Evolution.Sealeo,
        xpClass = MediumSlow,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            IceBody,
            Oblivious,
        },
    };
    public static SpeciesData Walrein = new()
    {
        speciesName = "Walrein",
        type1 = Ice,
        type2 = Water,
        baseHP = 110,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 65,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
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
            ThickFat,
            IceBody,
            Oblivious,
        },
    };
    public static SpeciesData Clamperl = new()
    {
        speciesName = "Clamperl",
        type1 = Water,
        type2 = Water,
        baseHP = 35,
        baseAttack = 64,
        baseDefense = 85,
        baseSpAtk = 74,
        baseSpDef = 55,
        baseSpeed = 32,
        evYield = Defense,
        evolution = Evolution.Clamperl,
        xpClass = Erratic,
        xpYield = 69,
        learnset = EmptyLearnset, //Not done
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
            ShellArmor,
            ShellArmor,
            Rattled,
        },
    };
    public static SpeciesData Huntail = new()
    {
        speciesName = "Huntail",
        type1 = Water,
        type2 = Water,
        baseHP = 55,
        baseAttack = 104,
        baseDefense = 105,
        baseSpAtk = 94,
        baseSpDef = 75,
        baseSpeed = 52,
        evYield = Attack + Defense,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        },
    };
    public static SpeciesData Gorebyss = new()
    {
        speciesName = "Gorebyss",
        type1 = Water,
        type2 = Water,
        baseHP = 55,
        baseAttack = 84,
        baseDefense = 105,
        baseSpAtk = 114,
        baseSpDef = 75,
        baseSpeed = 52,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            SwiftSwim,
            Hydration,
        },
    };
    public static SpeciesData Relicanth = new()
    {
        speciesName = "Relicanth",
        type1 = Water,
        type2 = Rock,
        baseHP = 100,
        baseAttack = 90,
        baseDefense = 130,
        baseSpAtk = 45,
        baseSpDef = 65,
        baseSpeed = 55,
        evYield = HP + Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            RockHead,
            Sturdy,
        },
    };
    public static SpeciesData Luvdisc = new()
    {
        speciesName = "Luvdisc",
        type1 = Water,
        type2 = Water,
        baseHP = 43,
        baseAttack = 30,
        baseDefense = 55,
        baseSpAtk = 40,
        baseSpDef = 65,
        baseSpeed = 97,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 116,
        learnset = EmptyLearnset, //Not done
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
            SwiftSwim,
            SwiftSwim,
            Hydration,
        },
    };
    public static SpeciesData Bagon = new()
    {
        speciesName = "Bagon",
        type1 = Dragon,
        type2 = Dragon,
        baseHP = 45,
        baseAttack = 75,
        baseDefense = 60,
        baseSpAtk = 40,
        baseSpDef = 30,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Bagon,
        xpClass = Slow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            RockHead,
            SheerForce,
        },
    };
    public static SpeciesData Shelgon = new()
    {
        speciesName = "Shelgon",
        type1 = Dragon,
        type2 = Dragon,
        baseHP = 65,
        baseAttack = 95,
        baseDefense = 100,
        baseSpAtk = 60,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = 2 * Defense,
        evolution = Evolution.Shelgon,
        xpClass = Slow,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
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
            RockHead,
            RockHead,
            Overcoat,
        },
    };
    public static SpeciesData Salamence = new()
    {
        speciesName = "Salamence",
        type1 = Dragon,
        type2 = Flying,
        baseHP = 95,
        baseAttack = 135,
        baseDefense = 80,
        baseSpAtk = 110,
        baseSpDef = 80,
        baseSpeed = 100,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
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
            Intimidate,
            Intimidate,
            Moxie,
        },
    };
    public static SpeciesData Beldum = new()
    {
        speciesName = "Beldum",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 40,
        baseAttack = 55,
        baseDefense = 80,
        baseSpAtk = 35,
        baseSpDef = 60,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.Beldum,
        xpClass = Slow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            LightMetal,
        },
    };
    public static SpeciesData Metang = new()
    {
        speciesName = "Metang",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 60,
        baseAttack = 75,
        baseDefense = 100,
        baseSpAtk = 55,
        baseSpDef = 80,
        baseSpeed = 50,
        evYield = 2 * Defense,
        evolution = Evolution.Metang,
        xpClass = Slow,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            LightMetal,
        },
    };
    public static SpeciesData Metagross = new()
    {
        speciesName = "Metagross",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 80,
        baseAttack = 135,
        baseDefense = 130,
        baseSpAtk = 95,
        baseSpDef = 90,
        baseSpeed = 70,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            LightMetal,
        },
    };
    public static SpeciesData Regirock = new()
    {
        speciesName = "Regirock",
        type1 = Rock,
        type2 = Rock,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 200,
        baseSpAtk = 50,
        baseSpDef = 100,
        baseSpeed = 50,
        evYield = 3 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            Sturdy,
        },
    };
    public static SpeciesData Regice = new()
    {
        speciesName = "Regice",
        type1 = Ice,
        type2 = Ice,
        baseHP = 80,
        baseAttack = 50,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 200,
        baseSpeed = 50,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            IceBody,
        },
    };
    public static SpeciesData Registeel = new()
    {
        speciesName = "Registeel",
        type1 = Steel,
        type2 = Steel,
        baseHP = 80,
        baseAttack = 75,
        baseDefense = 150,
        baseSpAtk = 75,
        baseSpDef = 150,
        baseSpeed = 50,
        evYield = 2 * Defense + SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            ClearBody,
            ClearBody,
            LightMetal,
        },
    };
    public static SpeciesData Latias = new()
    {
        speciesName = "Latias",
        type1 = Dragon,
        type2 = Psychic,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 90,
        baseSpAtk = 110,
        baseSpDef = 130,
        baseSpeed = 110,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Latios = new()
    {
        speciesName = "Latios",
        type1 = Dragon,
        type2 = Psychic,
        baseHP = 80,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 130,
        baseSpDef = 110,
        baseSpeed = 110,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
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
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Kyogre = new()
    {
        speciesName = "Kyogre",
        type1 = Water,
        type2 = Water,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 90,
        baseSpAtk = 150,
        baseSpDef = 140,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 302,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Drizzle,
            Drizzle,
            Drizzle,
        },
    };
    public static SpeciesData Groudon = new()
    {
        speciesName = "Groudon",
        type1 = Ground,
        type2 = Ground,
        baseHP = 100,
        baseAttack = 150,
        baseDefense = 140,
        baseSpAtk = 100,
        baseSpDef = 90,
        baseSpeed = 90,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 302,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            Drought,
            Drought,
            Drought,
        },
    };
    public static SpeciesData Rayquaza = new()
    {
        speciesName = "Rayquaza",
        type1 = Dragon,
        type2 = Flying,
        baseHP = 105,
        baseAttack = 150,
        baseDefense = 90,
        baseSpAtk = 150,
        baseSpDef = 90,
        baseSpeed = 95,
        evYield = 2 * Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 306,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            AirLock,
            AirLock,
            AirLock,
        },
    };
    public static SpeciesData Jirachi = new()
    {
        speciesName = "Jirachi",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
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
            SereneGrace,
            SereneGrace,
            SereneGrace,
        },
    };

    public static SpeciesData Deoxys =
        Deoxys(
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

    //Gen 4

    public static SpeciesData Turtwig = new()
    {
        speciesName = "Turtwig",
        type1 = Grass,
        type2 = Grass,
        baseHP = 55,
        baseAttack = 68,
        baseDefense = 64,
        baseSpAtk = 45,
        baseSpDef = 55,
        baseSpeed = 31,
        evYield = Attack,
        evolution = Evolution.Turtwig,
        xpClass = MediumSlow,
        xpYield = 64,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "turtwig", //Verify
        graphicsLocation = "turtwig", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        },
    };
    public static SpeciesData Grotle = new()
    {
        speciesName = "Grotle",
        type1 = Grass,
        type2 = Grass,
        baseHP = 75,
        baseAttack = 89,
        baseDefense = 85,
        baseSpAtk = 55,
        baseSpDef = 65,
        baseSpeed = 36,
        evYield = Attack + Defense,
        evolution = Evolution.Grotle,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "grotle", //Verify
        graphicsLocation = "grotle", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        },
    };
    public static SpeciesData Torterra = new()
    {
        speciesName = "Torterra",
        type1 = Grass,
        type2 = Ground,
        baseHP = 95,
        baseAttack = 109,
        baseDefense = 105,
        baseSpAtk = 75,
        baseSpDef = 85,
        baseSpeed = 56,
        evYield = 2 * Attack + Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 236,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "torterra", //Verify
        graphicsLocation = "torterra", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        },
    };
    public static SpeciesData Chimchar = new()
    {
        speciesName = "Chimchar",
        type1 = Fire,
        type2 = Fire,
        baseHP = 44,
        baseAttack = 58,
        baseDefense = 44,
        baseSpAtk = 58,
        baseSpDef = 44,
        baseSpeed = 61,
        evYield = Speed,
        evolution = Evolution.Chimchar,
        xpClass = MediumSlow,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "chimchar", //Verify
        graphicsLocation = "chimchar", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        },
    };
    public static SpeciesData Monferno = new()
    {
        speciesName = "Monferno",
        type1 = Fire,
        type2 = Fighting,
        baseHP = 64,
        baseAttack = 78,
        baseDefense = 52,
        baseSpAtk = 78,
        baseSpDef = 52,
        baseSpeed = 81,
        evYield = Speed + SpAtk,
        evolution = Evolution.Monferno,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "monferno", //Verify
        graphicsLocation = "monferno", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        },
    };
    public static SpeciesData Infernape = new()
    {
        speciesName = "Infernape",
        type1 = Fire,
        type2 = Fighting,
        baseHP = 76,
        baseAttack = 104,
        baseDefense = 71,
        baseSpAtk = 104,
        baseSpDef = 71,
        baseSpeed = 108,
        evYield = Attack + Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 240,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "infernape", //Verify
        graphicsLocation = "infernape", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        },
    };
    public static SpeciesData Piplup = new()
    {
        speciesName = "Piplup",
        type1 = Water,
        type2 = Water,
        baseHP = 53,
        baseAttack = 51,
        baseDefense = 53,
        baseSpAtk = 61,
        baseSpDef = 56,
        baseSpeed = 40,
        evYield = SpAtk,
        evolution = Evolution.Piplup,
        xpClass = MediumSlow,
        xpYield = 63,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "piplup", //Verify
        graphicsLocation = "piplup", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        },
    };
    public static SpeciesData Prinplup = new()
    {
        speciesName = "Prinplup",
        type1 = Water,
        type2 = Water,
        baseHP = 64,
        baseAttack = 66,
        baseDefense = 68,
        baseSpAtk = 81,
        baseSpDef = 76,
        baseSpeed = 50,
        evYield = 2 * SpAtk,
        evolution = Evolution.Prinplup,
        xpClass = MediumSlow,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "prinplup", //Verify
        graphicsLocation = "prinplup", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        },
    };
    public static SpeciesData Empoleon = new()
    {
        speciesName = "Empoleon",
        type1 = Water,
        type2 = Steel,
        baseHP = 84,
        baseAttack = 86,
        baseDefense = 88,
        baseSpAtk = 111,
        baseSpDef = 101,
        baseSpeed = 60,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "empoleon", //Verify
        graphicsLocation = "empoleon", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        },
    };
    public static SpeciesData Starly = new()
    {
        speciesName = "Starly",
        type1 = Normal,
        type2 = Flying,
        baseHP = 40,
        baseAttack = 55,
        baseDefense = 30,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 60,
        evYield = Speed,
        evolution = Evolution.Starly,
        xpClass = MediumSlow,
        xpYield = 49,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "starly", //Verify
        graphicsLocation = "starly", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            KeenEye,
            KeenEye,
            Reckless,
        },
    };
    public static SpeciesData Staravia = new()
    {
        speciesName = "Staravia",
        type1 = Normal,
        type2 = Flying,
        baseHP = 55,
        baseAttack = 75,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 40,
        baseSpeed = 80,
        evYield = 2 * Speed,
        evolution = Evolution.Staravia,
        xpClass = MediumSlow,
        xpYield = 119,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "staravia", //Verify
        graphicsLocation = "staravia", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Intimidate,
            Intimidate,
            Reckless,
        },
    };
    public static SpeciesData Staraptor = new()
    {
        speciesName = "Staraptor",
        type1 = Normal,
        type2 = Flying,
        baseHP = 85,
        baseAttack = 120,
        baseDefense = 70,
        baseSpAtk = 50,
        baseSpDef = 60,
        baseSpeed = 100,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 218,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "staraptor", //Verify
        graphicsLocation = "staraptor", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Intimidate,
            Intimidate,
            Reckless,
        },
    };
    public static SpeciesData Bidoof = new()
    {
        speciesName = "Bidoof",
        type1 = Normal,
        type2 = Normal,
        baseHP = 59,
        baseAttack = 45,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 40,
        baseSpeed = 31,
        evYield = HP,
        evolution = Evolution.Bidoof,
        xpClass = MediumFast,
        xpYield = 50,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "bidoof", //Verify
        graphicsLocation = "bidoof", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Simple,
            Unaware,
            Moody,
        },
    };
    public static SpeciesData Bibarel = new()
    {
        speciesName = "Bibarel",
        type1 = Normal,
        type2 = Water,
        baseHP = 79,
        baseAttack = 85,
        baseDefense = 60,
        baseSpAtk = 55,
        baseSpDef = 60,
        baseSpeed = 71,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 127,
        baseFriendship = 70,
        cryLocation = "bibarel", //Verify
        graphicsLocation = "bibarel", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Simple,
            Unaware,
            Moody,
        },
    };
    public static SpeciesData Kricketot = new()
    {
        speciesName = "Kricketot",
        type1 = Bug,
        type2 = Bug,
        baseHP = 37,
        baseAttack = 25,
        baseDefense = 41,
        baseSpAtk = 25,
        baseSpDef = 41,
        baseSpeed = 25,
        evYield = Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 39,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "kricketot", //Verify
        graphicsLocation = "kricketot", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            RunAway,
        },
    };
    public static SpeciesData Kricketune = new()
    {
        speciesName = "Kricketune",
        type1 = Bug,
        type2 = Bug,
        baseHP = 77,
        baseAttack = 85,
        baseDefense = 51,
        baseSpAtk = 55,
        baseSpDef = 51,
        baseSpeed = 65,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 134,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "kricketune", //Verify
        graphicsLocation = "kricketune", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Swarm,
            Swarm,
            Technician,
        },
    };
    public static SpeciesData Shinx = new()
    {
        speciesName = "Shinx",
        type1 = Electric,
        type2 = Electric,
        baseHP = 45,
        baseAttack = 65,
        baseDefense = 34,
        baseSpAtk = 40,
        baseSpDef = 34,
        baseSpeed = 45,
        evYield = Attack,
        evolution = Evolution.Shinx,
        xpClass = MediumSlow,
        xpYield = 53,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 235,
        baseFriendship = 70,
        cryLocation = "shinx", //Verify
        graphicsLocation = "shinx", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        },
    };
    public static SpeciesData Luxio = new()
    {
        speciesName = "Luxio",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 85,
        baseDefense = 49,
        baseSpAtk = 60,
        baseSpDef = 49,
        baseSpeed = 60,
        evYield = 2 * Attack,
        evolution = Evolution.Luxio,
        xpClass = MediumSlow,
        xpYield = 127,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 100,
        cryLocation = "luxio", //Verify
        graphicsLocation = "luxio", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        },
    };
    public static SpeciesData Luxray = new()
    {
        speciesName = "Luxray",
        type1 = Electric,
        type2 = Electric,
        baseHP = 80,
        baseAttack = 120,
        baseDefense = 79,
        baseSpAtk = 95,
        baseSpDef = 79,
        baseSpeed = 70,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 235,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "luxray", //Verify
        graphicsLocation = "luxray", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        },
    };
    public static SpeciesData Budew = new()
    {
        speciesName = "Budew",
        type1 = Grass,
        type2 = Poison,
        baseHP = 40,
        baseAttack = 30,
        baseDefense = 35,
        baseSpAtk = 50,
        baseSpDef = 70,
        baseSpeed = 55,
        evYield = SpAtk,
        evolution = Evolution.Budew,
        xpClass = MediumSlow,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "budew", //Verify
        graphicsLocation = "budew", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            NaturalCure,
            PoisonPoint,
            LeafGuard,
        },
    };
    public static SpeciesData Roserade = new()
    {
        speciesName = "Roserade",
        type1 = Grass,
        type2 = Poison,
        baseHP = 60,
        baseAttack = 70,
        baseDefense = 65,
        baseSpAtk = 125,
        baseSpDef = 105,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 232,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "roserade", //Verify
        graphicsLocation = "roserade", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            NaturalCure,
            PoisonPoint,
            Technician,
        },
    };
    public static SpeciesData Cranidos = new()
    {
        speciesName = "Cranidos",
        type1 = Rock,
        type2 = Rock,
        baseHP = 67,
        baseAttack = 125,
        baseDefense = 40,
        baseSpAtk = 30,
        baseSpDef = 30,
        baseSpeed = 58,
        evYield = Attack,
        evolution = Evolution.Cranidos,
        xpClass = Erratic,
        xpYield = 70,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "cranidos", //Verify
        graphicsLocation = "cranidos", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            MoldBreaker,
            MoldBreaker,
            SheerForce,
        },
    };
    public static SpeciesData Rampardos = new()
    {
        speciesName = "Rampardos",
        type1 = Rock,
        type2 = Rock,
        baseHP = 97,
        baseAttack = 165,
        baseDefense = 60,
        baseSpAtk = 65,
        baseSpDef = 50,
        baseSpeed = 58,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "rampardos", //Verify
        graphicsLocation = "rampardos", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            MoldBreaker,
            MoldBreaker,
            SheerForce,
        },
    };
    public static SpeciesData Shieldon = new()
    {
        speciesName = "Shieldon",
        type1 = Rock,
        type2 = Steel,
        baseHP = 30,
        baseAttack = 42,
        baseDefense = 118,
        baseSpAtk = 42,
        baseSpDef = 88,
        baseSpeed = 30,
        evYield = Defense,
        evolution = Evolution.Shieldon,
        xpClass = Erratic,
        xpYield = 70,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "shieldon", //Verify
        graphicsLocation = "shieldon", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Sturdy,
            Sturdy,
            Soundproof,
        },
    };
    public static SpeciesData Bastiodon = new()
    {
        speciesName = "Bastiodon",
        type1 = Rock,
        type2 = Steel,
        baseHP = 60,
        baseAttack = 52,
        baseDefense = 168,
        baseSpAtk = 47,
        baseSpDef = 138,
        baseSpeed = 30,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 30,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "bastiodon", //Verify
        graphicsLocation = "bastiodon", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Sturdy,
            Sturdy,
            Soundproof,
        },
    };

    public static SpeciesData Burmy = Burmy(
        graphics: "burmy",
        backSpriteHeight: 6,
        evolution: Evolution.Burmy
    );
    public static SpeciesData Wormadam = Wormadam(
        type2: Grass,
        baseHP: 60,
        baseAttack: 59,
        baseDefense: 85,
        baseSpAtk: 79,
        baseSpDef: 105,
        baseSpeed: 36,
        evYield: SpDef * 2,
        graphics: "wormadam",
        backSpriteHeight: 2
    );
    public static SpeciesData Mothim = new()
    {
        speciesName = "Mothim",
        type1 = Bug,
        type2 = Flying,
        baseHP = 70,
        baseAttack = 94,
        baseDefense = 50,
        baseSpAtk = 94,
        baseSpDef = 50,
        baseSpeed = 66,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 148,
        learnset = EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "mothim", //Verify
        graphicsLocation = "mothim", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Swarm,
            Swarm,
            TintedLens,
        },
    };
    public static SpeciesData Combee = new()
    {
        speciesName = "Combee",
        type1 = Bug,
        type2 = Flying,
        baseHP = 30,
        baseAttack = 30,
        baseDefense = 42,
        baseSpAtk = 30,
        baseSpDef = 42,
        baseSpeed = 70,
        evYield = Speed,
        evolution = Evolution.Combee,
        xpClass = MediumSlow,
        xpYield = 49,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "combee", //Verify
        graphicsLocation = "combee", //Verify
        backSpriteHeight = 22,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            HoneyGather,
            HoneyGather,
            Hustle,
        },
    };
    public static SpeciesData Vespiquen = new()
    {
        speciesName = "Vespiquen",
        type1 = Bug,
        type2 = Flying,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 102,
        baseSpAtk = 80,
        baseSpDef = 102,
        baseSpeed = 40,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "vespiquen", //Verify
        graphicsLocation = "vespiquen", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pressure,
            Pressure,
            Unnerve,
        },
    };
    public static SpeciesData Pachirisu = new()
    {
        speciesName = "Pachirisu",
        type1 = Electric,
        type2 = Electric,
        baseHP = 60,
        baseAttack = 45,
        baseDefense = 70,
        baseSpAtk = 45,
        baseSpDef = 90,
        baseSpeed = 95,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 142,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 200,
        baseFriendship = 100,
        cryLocation = "pachirisu", //Verify
        graphicsLocation = "pachirisu", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            RunAway,
            Pickup,
            VoltAbsorb,
        },
    };
    public static SpeciesData Buizel = new()
    {
        speciesName = "Buizel",
        type1 = Water,
        type2 = Water,
        baseHP = 55,
        baseAttack = 65,
        baseDefense = 35,
        baseSpAtk = 60,
        baseSpDef = 30,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Buizel,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "buizel", //Verify
        graphicsLocation = "buizel", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        },
    };
    public static SpeciesData Floatzel = new()
    {
        speciesName = "Floatzel",
        type1 = Water,
        type2 = Water,
        baseHP = 85,
        baseAttack = 105,
        baseDefense = 55,
        baseSpAtk = 85,
        baseSpDef = 50,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "floatzel", //Verify
        graphicsLocation = "floatzel", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        },
    };
    public static SpeciesData Cherubi = new()
    {
        speciesName = "Cherubi",
        type1 = Grass,
        type2 = Grass,
        baseHP = 45,
        baseAttack = 35,
        baseDefense = 45,
        baseSpAtk = 62,
        baseSpDef = 53,
        baseSpeed = 35,
        evYield = SpAtk,
        evolution = Evolution.Cherubi,
        xpClass = MediumFast,
        xpYield = 55,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "cherubi", //Verify
        graphicsLocation = "cherubi", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Chlorophyll,
        },
    };
    public static SpeciesData Cherrim = Cherrim("cherrim/normal", 9);
    public static SpeciesData Shellos = Shellos("shellos", 8,
        Evolution.Shellos);
    public static SpeciesData Gastrodon = Gastrodon("gastrodon", 3);
    public static SpeciesData Ambipom = new()
    {
        speciesName = "Ambipom",
        type1 = Normal,
        type2 = Normal,
        baseHP = 75,
        baseAttack = 100,
        baseDefense = 66,
        baseSpAtk = 60,
        baseSpDef = 66,
        baseSpeed = 115,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 169,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 100,
        cryLocation = "ambipom", //Verify
        graphicsLocation = "ambipom", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
    {
            Technician,
            Pickup,
            SkillLink,
    },
    };
    public static SpeciesData Drifloon = new()
    {
        speciesName = "Drifloon",
        type1 = Ghost,
        type2 = Flying,
        baseHP = 90,
        baseAttack = 50,
        baseDefense = 34,
        baseSpAtk = 60,
        baseSpDef = 44,
        baseSpeed = 70,
        evYield = HP,
        evolution = Evolution.Drifloon,
        xpClass = Fluctuating,
        xpYield = 70,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 30,
        catchRate = 125,
        baseFriendship = 70,
        cryLocation = "drifloon", //Verify
        graphicsLocation = "drifloon", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Aftermath,
            Unburden,
            FlareBoost,
        },
    };
    public static SpeciesData Drifblim = new()
    {
        speciesName = "Drifblim",
        type1 = Ghost,
        type2 = Flying,
        baseHP = 150,
        baseAttack = 80,
        baseDefense = 44,
        baseSpAtk = 90,
        baseSpDef = 54,
        baseSpeed = 80,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = Fluctuating,
        xpYield = 174,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 30,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "drifblim", //Verify
        graphicsLocation = "drifblim", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Aftermath,
            Unburden,
            FlareBoost,
        },
    };
    public static SpeciesData Buneary = new()
    {
        speciesName = "Buneary",
        type1 = Normal,
        type2 = Normal,
        baseHP = 55,
        baseAttack = 66,
        baseDefense = 44,
        baseSpAtk = 44,
        baseSpDef = 56,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Buneary,
        xpClass = MediumFast,
        xpYield = 70,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 0,
        cryLocation = "buneary", //Verify
        graphicsLocation = "buneary", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            RunAway,
            Klutz,
            Limber,
        },
    };
    public static SpeciesData Lopunny = new()
    {
        speciesName = "Lopunny",
        type1 = Normal,
        type2 = Normal,
        baseHP = 65,
        baseAttack = 76,
        baseDefense = 84,
        baseSpAtk = 54,
        baseSpDef = 96,
        baseSpeed = 105,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 168,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 140,
        cryLocation = "lopunny", //Verify
        graphicsLocation = "lopunny", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            CuteCharm,
            Klutz,
            Limber,
        },
    };
    public static SpeciesData Mismagius = new()
    {
        speciesName = "Mismagius",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 60,
        baseSpAtk = 105,
        baseSpDef = 105,
        baseSpeed = 105,
        evYield = SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "mismagius", //Verify
        graphicsLocation = "mismagius", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Honchkrow = new()
    {
        speciesName = "Honchkrow",
        type1 = Dark,
        type2 = Flying,
        baseHP = 100,
        baseAttack = 125,
        baseDefense = 52,
        baseSpAtk = 105,
        baseSpDef = 52,
        baseSpeed = 71,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 177,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 35,
        cryLocation = "honchkrow", //Verify
        graphicsLocation = "honchkrow", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Insomnia,
            SuperLuck,
            Moxie,
        },
    };
    public static SpeciesData Glameow = new()
    {
        speciesName = "Glameow",
        type1 = Normal,
        type2 = Normal,
        baseHP = 49,
        baseAttack = 55,
        baseDefense = 42,
        baseSpAtk = 42,
        baseSpDef = 37,
        baseSpeed = 85,
        evYield = Speed,
        evolution = Evolution.Glameow,
        xpClass = Fast,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "glameow", //Verify
        graphicsLocation = "glameow", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Limber,
            OwnTempo,
            KeenEye,
        },
    };
    public static SpeciesData Purugly = new()
    {
        speciesName = "Purugly",
        type1 = Normal,
        type2 = Normal,
        baseHP = 71,
        baseAttack = 82,
        baseDefense = 64,
        baseSpAtk = 64,
        baseSpDef = 59,
        baseSpeed = 112,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 158,
        learnset = EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "purugly", //Verify
        graphicsLocation = "purugly", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            ThickFat,
            OwnTempo,
            Defiant,
        },
    };
    public static SpeciesData Chingling = new()
    {
        speciesName = "Chingling",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 45,
        baseAttack = 30,
        baseDefense = 50,
        baseSpAtk = 65,
        baseSpDef = 50,
        baseSpeed = 45,
        evYield = SpAtk,
        evolution = Evolution.Chingling,
        xpClass = Fast,
        xpYield = 57,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "chingling", //Verify
        graphicsLocation = "chingling", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Stunky = new()
    {
        speciesName = "Stunky",
        type1 = Poison,
        type2 = Dark,
        baseHP = 63,
        baseAttack = 63,
        baseDefense = 47,
        baseSpAtk = 41,
        baseSpDef = 41,
        baseSpeed = 74,
        evYield = Speed,
        evolution = Evolution.Stunky,
        xpClass = MediumFast,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "stunky", //Verify
        graphicsLocation = "stunky", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Stench,
            Aftermath,
            KeenEye,
        },
    };
    public static SpeciesData Skuntank = new()
    {
        speciesName = "Skuntank",
        type1 = Poison,
        type2 = Dark,
        baseHP = 103,
        baseAttack = 93,
        baseDefense = 67,
        baseSpAtk = 71,
        baseSpDef = 61,
        baseSpeed = 84,
        evYield = 2 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 168,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "skuntank", //Verify
        graphicsLocation = "skuntank", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Stench,
            Aftermath,
            KeenEye,
        },
    };
    public static SpeciesData Bronzor = new()
    {
        speciesName = "Bronzor",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 57,
        baseAttack = 24,
        baseDefense = 86,
        baseSpAtk = 24,
        baseSpDef = 86,
        baseSpeed = 23,
        evYield = Defense,
        evolution = Evolution.Bronzor,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "bronzor", //Verify
        graphicsLocation = "bronzor", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Heatproof,
            HeavyMetal,
        },
    };
    public static SpeciesData Bronzong = new()
    {
        speciesName = "Bronzong",
        type1 = Steel,
        type2 = Psychic,
        baseHP = 67,
        baseAttack = 89,
        baseDefense = 116,
        baseSpAtk = 79,
        baseSpDef = 116,
        baseSpeed = 33,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 90,
        baseFriendship = 70,
        cryLocation = "bronzong", //Verify
        graphicsLocation = "bronzong", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Heatproof,
            HeavyMetal,
        },
    };
    public static SpeciesData Bonsly = new()
    {
        speciesName = "Bonsly",
        type1 = Rock,
        type2 = Rock,
        baseHP = 50,
        baseAttack = 80,
        baseDefense = 95,
        baseSpAtk = 10,
        baseSpDef = 45,
        baseSpeed = 10,
        evYield = Defense,
        evolution = Evolution.Bonsly,
        xpClass = MediumFast,
        xpYield = 58,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 20,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "bonsly", //Verify
        graphicsLocation = "bonsly", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Sturdy,
            RockHead,
            Rattled,
        },
    };
    public static SpeciesData MimeJr = new()
    {
        speciesName = "Mime Jr.",
        type1 = Psychic,
        type2 = Fairy,
        baseHP = 20,
        baseAttack = 25,
        baseDefense = 45,
        baseSpAtk = 70,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = SpDef,
        evolution = Evolution.MimeJr,
        xpClass = MediumFast,
        xpYield = 62,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 145,
        baseFriendship = 70,
        cryLocation = "mime_jr", //Verify
        graphicsLocation = "mime_jr", //Verify
        backSpriteHeight = 1,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Soundproof,
            Filter,
            Technician,
        },
    };
    public static SpeciesData Happiny = new()
    {
        speciesName = "Happiny",
        type1 = Normal,
        type2 = Normal,
        baseHP = 100,
        baseAttack = 5,
        baseDefense = 5,
        baseSpAtk = 15,
        baseSpDef = 65,
        baseSpeed = 30,
        evYield = HP,
        evolution = Evolution.Happiny,
        xpClass = Fast,
        xpYield = 110,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 40,
        catchRate = 130,
        baseFriendship = 140,
        cryLocation = "happiny", //Verify
        graphicsLocation = "happiny", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            NaturalCure,
            SereneGrace,
            FriendGuard,
        },
    };
    public static SpeciesData Chatot = new()
    {
        speciesName = "Chatot",
        type1 = Normal,
        type2 = Flying,
        baseHP = 76,
        baseAttack = 65,
        baseDefense = 45,
        baseSpAtk = 92,
        baseSpDef = 42,
        baseSpeed = 91,
        evYield = Attack,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 35,
        cryLocation = "chatot", //Verify
        graphicsLocation = "chatot", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            KeenEye,
            TangledFeet,
            BigPecks,
        },
    };
    public static SpeciesData Spiritomb = new()
    {
        speciesName = "Spiritomb",
        type1 = Ghost,
        type2 = Dark,
        baseHP = 50,
        baseAttack = 92,
        baseDefense = 108,
        baseSpAtk = 92,
        baseSpDef = 108,
        baseSpeed = 35,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 170,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 30,
        catchRate = 100,
        baseFriendship = 70,
        cryLocation = "spiritomb", //Verify
        graphicsLocation = "spiritomb", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pressure,
            Pressure,
            Infiltrator,
        },
    };
    public static SpeciesData Gible = new()
    {
        speciesName = "Gible",
        type1 = Dragon,
        type2 = Ground,
        baseHP = 58,
        baseAttack = 70,
        baseDefense = 45,
        baseSpAtk = 40,
        baseSpDef = 45,
        baseSpeed = 42,
        evYield = Attack,
        evolution = Evolution.Gible,
        xpClass = Slow,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "gible", //Verify
        graphicsLocation = "gible", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        },
    };
    public static SpeciesData Gabite = new()
    {
        speciesName = "Gabite",
        type1 = Dragon,
        type2 = Ground,
        baseHP = 68,
        baseAttack = 90,
        baseDefense = 65,
        baseSpAtk = 50,
        baseSpDef = 55,
        baseSpeed = 82,
        evYield = 2 * Attack,
        evolution = Evolution.Gabite,
        xpClass = Slow,
        xpYield = 144,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "gabite", //Verify
        graphicsLocation = "gabite", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        },
    };
    public static SpeciesData Garchomp = new()
    {
        speciesName = "Garchomp",
        type1 = Dragon,
        type2 = Ground,
        baseHP = 108,
        baseAttack = 130,
        baseDefense = 95,
        baseSpAtk = 80,
        baseSpDef = 85,
        baseSpeed = 102,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Dragon,
        eggCycles = 40,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "garchomp", //Verify
        graphicsLocation = "garchomp", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        },
    };
    public static SpeciesData Munchlax = new()
    {
        speciesName = "Munchlax",
        type1 = Normal,
        type2 = Normal,
        baseHP = 135,
        baseAttack = 85,
        baseDefense = 40,
        baseSpAtk = 40,
        baseSpDef = 85,
        baseSpeed = 5,
        evYield = HP,
        evolution = Evolution.Munchlax,
        xpClass = Slow,
        xpYield = 78,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 40,
        catchRate = 50,
        baseFriendship = 70,
        cryLocation = "munchlax", //Verify
        graphicsLocation = "munchlax", //Verify
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pickup,
            ThickFat,
            Gluttony,
        },
    };
    public static SpeciesData Riolu = new()
    {
        speciesName = "Riolu",
        type1 = Fighting,
        type2 = Fighting,
        baseHP = 40,
        baseAttack = 70,
        baseDefense = 40,
        baseSpAtk = 35,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = Attack,
        evolution = Evolution.Riolu,
        xpClass = MediumSlow,
        xpYield = 57,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "riolu", //Verify
        graphicsLocation = "riolu", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Steadfast,
            InnerFocus,
            Prankster,
        },
    };
    public static SpeciesData Lucario = new()
    {
        speciesName = "Lucario",
        type1 = Fighting,
        type2 = Steel,
        baseHP = 70,
        baseAttack = 110,
        baseDefense = 70,
        baseSpAtk = 115,
        baseSpDef = 70,
        baseSpeed = 90,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "lucario", //Verify
        graphicsLocation = "lucario", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Steadfast,
            InnerFocus,
            Justified,
        },
    };
    public static SpeciesData Hippopotas = new()
    {
        speciesName = "Hippopotas",
        type1 = Ground,
        type2 = Ground,
        baseHP = 68,
        baseAttack = 72,
        baseDefense = 78,
        baseSpAtk = 38,
        baseSpDef = 42,
        baseSpeed = 32,
        evYield = Defense,
        evolution = Evolution.Hippopotas,
        xpClass = Slow,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 30,
        catchRate = 140,
        baseFriendship = 70,
        cryLocation = "hippopotas", //Verify
        graphicsLocation = "hippopotas", //Verify
        backSpriteHeight = 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SandStream,
            SandStream,
            SandForce,
        },
    };
    public static SpeciesData Hippowdon = new()
    {
        speciesName = "Hippowdon",
        type1 = Ground,
        type2 = Ground,
        baseHP = 108,
        baseAttack = 112,
        baseDefense = 118,
        baseSpAtk = 68,
        baseSpDef = 72,
        baseSpeed = 47,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 30,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "hippowdon", //Verify
        graphicsLocation = "hippowdon", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SandStream,
            SandStream,
            SandForce,
        },
    };
    public static SpeciesData Skorupi = new()
    {
        speciesName = "Skorupi",
        type1 = Poison,
        type2 = Bug,
        baseHP = 40,
        baseAttack = 50,
        baseDefense = 90,
        baseSpAtk = 30,
        baseSpDef = 55,
        baseSpeed = 65,
        evYield = Defense,
        evolution = Evolution.Skorupi,
        xpClass = Slow,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "skorupi", //Verify
        graphicsLocation = "skorupi", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            BattleArmor,
            Sniper,
            KeenEye,
        },
    };
    public static SpeciesData Drapion = new()
    {
        speciesName = "Drapion",
        type1 = Poison,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 110,
        baseSpAtk = 60,
        baseSpDef = 75,
        baseSpeed = 95,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 175,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Water3,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "drapion", //Verify
        graphicsLocation = "drapion", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            BattleArmor,
            Sniper,
            KeenEye,
        },
    };
    public static SpeciesData Croagunk = new()
    {
        speciesName = "Croagunk",
        type1 = Poison,
        type2 = Fighting,
        baseHP = 48,
        baseAttack = 61,
        baseDefense = 40,
        baseSpAtk = 61,
        baseSpDef = 40,
        baseSpeed = 50,
        evYield = Attack,
        evolution = Evolution.Croagunk,
        xpClass = MediumFast,
        xpYield = 60,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 10,
        catchRate = 140,
        baseFriendship = 100,
        cryLocation = "croagunk", //Verify
        graphicsLocation = "croagunk", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Anticipation,
            DrySkin,
            PoisonTouch,
        },
    };
    public static SpeciesData Toxicroak = new()
    {
        speciesName = "Toxicroak",
        type1 = Poison,
        type2 = Fighting,
        baseHP = 83,
        baseAttack = 106,
        baseDefense = 65,
        baseSpAtk = 86,
        baseSpDef = 65,
        baseSpeed = 85,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 172,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "toxicroak", //Verify
        graphicsLocation = "toxicroak", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Anticipation,
            DrySkin,
            PoisonTouch,
        },
    };
    public static SpeciesData Carnivine = new()
    {
        speciesName = "Carnivine",
        type1 = Grass,
        type2 = Grass,
        baseHP = 74,
        baseAttack = 100,
        baseDefense = 72,
        baseSpAtk = 90,
        baseSpDef = 72,
        baseSpeed = 46,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 159,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 25,
        catchRate = 200,
        baseFriendship = 70,
        cryLocation = "carnivine", //Verify
        graphicsLocation = "carnivine", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Finneon = new()
    {
        speciesName = "Finneon",
        type1 = Water,
        type2 = Water,
        baseHP = 49,
        baseAttack = 49,
        baseDefense = 56,
        baseSpAtk = 49,
        baseSpDef = 61,
        baseSpeed = 66,
        evYield = Speed,
        evolution = Evolution.Finneon,
        xpClass = Erratic,
        xpYield = 66,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "finneon", //Verify
        graphicsLocation = "finneon", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SwiftSwim,
            StormDrain,
            WaterVeil,
        },
    };
    public static SpeciesData Lumineon = new()
    {
        speciesName = "Lumineon",
        type1 = Water,
        type2 = Water,
        baseHP = 69,
        baseAttack = 69,
        baseDefense = 76,
        baseSpAtk = 69,
        baseSpDef = 86,
        baseSpeed = 91,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = Erratic,
        xpYield = 161,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Water2,
        eggGroup2 = EggGroup.Water2,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "lumineon", //Verify
        graphicsLocation = "lumineon", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SwiftSwim,
            StormDrain,
            WaterVeil,
        },
    };
    public static SpeciesData Mantyke = new()
    {
        speciesName = "Mantyke",
        type1 = Water,
        type2 = Flying,
        baseHP = 45,
        baseAttack = 20,
        baseDefense = 50,
        baseSpAtk = 60,
        baseSpDef = 120,
        baseSpeed = 50,
        evYield = SpDef,
        evolution = Evolution.Mantyke,
        xpClass = Slow,
        xpYield = 69,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 25,
        catchRate = 25,
        baseFriendship = 70,
        cryLocation = "mantyke", //Verify
        graphicsLocation = "mantyke", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SwiftSwim,
            WaterAbsorb,
            WaterVeil,
        },
    };
    public static SpeciesData Snover = new()
    {
        speciesName = "Snover",
        type1 = Grass,
        type2 = Ice,
        baseHP = 60,
        baseAttack = 62,
        baseDefense = 50,
        baseSpAtk = 62,
        baseSpDef = 60,
        baseSpeed = 40,
        evYield = Attack,
        evolution = Evolution.Snover,
        xpClass = Slow,
        xpYield = 67,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "snover", //Verify
        graphicsLocation = "snover", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SnowWarning,
            SnowWarning,
            Soundproof,
        },
    };
    public static SpeciesData Abomasnow = new()
    {
        speciesName = "Abomasnow",
        type1 = Grass,
        type2 = Ice,
        baseHP = 90,
        baseAttack = 92,
        baseDefense = 75,
        baseSpAtk = 92,
        baseSpDef = 85,
        baseSpeed = 60,
        evYield = Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "abomasnow", //Verify
        graphicsLocation = "abomasnow", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SnowWarning,
            SnowWarning,
            Soundproof,
        },
    };
    public static SpeciesData Weavile = new()
    {
        speciesName = "Weavile",
        type1 = Dark,
        type2 = Ice,
        baseHP = 70,
        baseAttack = 120,
        baseDefense = 65,
        baseSpAtk = 45,
        baseSpDef = 85,
        baseSpeed = 125,
        evYield = Attack + Speed,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 179,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "weavile", //Verify
        graphicsLocation = "weavile", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pressure,
            Pressure,
            Pickpocket,
        },
    };
    public static SpeciesData Magnezone = new()
    {
        speciesName = "Magnezone",
        type1 = Electric,
        type2 = Steel,
        baseHP = 70,
        baseAttack = 70,
        baseDefense = 115,
        baseSpAtk = 130,
        baseSpDef = 90,
        baseSpeed = 60,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 241,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "magnezone", //Verify
        graphicsLocation = "magnezone", //Verify
        backSpriteHeight = 12,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Analytic,
        },
    };
    public static SpeciesData Lickilicky = new()
    {
        speciesName = "Lickilicky",
        type1 = Normal,
        type2 = Normal,
        baseHP = 110,
        baseAttack = 85,
        baseDefense = 95,
        baseSpAtk = 80,
        baseSpDef = 95,
        baseSpeed = 50,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 180,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Monster,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "lickilicky", //Verify
        graphicsLocation = "lickilicky", //Verify
        backSpriteHeight = 2,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            OwnTempo,
            Oblivious,
            CloudNine,
        },
    };
    public static SpeciesData Rhyperior = new()
    {
        speciesName = "Rhyperior",
        type1 = Ground,
        type2 = Rock,
        baseHP = 115,
        baseAttack = 140,
        baseDefense = 130,
        baseSpAtk = 55,
        baseSpDef = 55,
        baseSpeed = 40,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 241,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Monster,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "rhyperior", //Verify
        graphicsLocation = "rhyperior", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            LightningRod,
            SolidRock,
            Reckless,
        },
    };
    public static SpeciesData Tangrowth = new()
    {
        speciesName = "Tangrowth",
        type1 = Grass,
        type2 = Grass,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 125,
        baseSpAtk = 110,
        baseSpDef = 50,
        baseSpeed = 50,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 187,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Grass,
        eggGroup2 = EggGroup.Grass,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "tangrowth", //Verify
        graphicsLocation = "tangrowth", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Regenerator,
        },
    };
    public static SpeciesData Electivire = new()
    {
        speciesName = "Electivire",
        type1 = Electric,
        type2 = Electric,
        baseHP = 75,
        baseAttack = 123,
        baseDefense = 67,
        baseSpAtk = 95,
        baseSpDef = 85,
        baseSpeed = 95,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 243,
        learnset = EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "electivire", //Verify
        graphicsLocation = "electivire", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            MotorDrive,
            MotorDrive,
            VitalSpirit,
        },
    };
    public static SpeciesData Magmortar = new()
    {
        speciesName = "Magmortar",
        type1 = Fire,
        type2 = Fire,
        baseHP = 75,
        baseAttack = 95,
        baseDefense = 67,
        baseSpAtk = 125,
        baseSpDef = 95,
        baseSpeed = 83,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 243,
        learnset = EmptyLearnset, //Not done
        malePercent = 75,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.HumanLike,
        eggCycles = 25,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "magmortar", //Verify
        graphicsLocation = "magmortar", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            FlameBody,
            FlameBody,
            VitalSpirit,
        },
    };
    public static SpeciesData Togekiss = new()
    {
        speciesName = "Togekiss",
        type1 = Fairy,
        type2 = Flying,
        baseHP = 85,
        baseAttack = 50,
        baseDefense = 95,
        baseSpAtk = 120,
        baseSpDef = 115,
        baseSpeed = 80,
        evYield = 2 * SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 245,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "togekiss", //Verify
        graphicsLocation = "togekiss", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Hustle,
            SereneGrace,
            SuperLuck,
        },
    };
    public static SpeciesData Yanmega = new()
    {
        speciesName = "Yanmega",
        type1 = Bug,
        type2 = Flying,
        baseHP = 86,
        baseAttack = 76,
        baseDefense = 86,
        baseSpAtk = 116,
        baseSpDef = 56,
        baseSpeed = 95,
        evYield = 2 * Attack,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 180,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "yanmega", //Verify
        graphicsLocation = "yanmega", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SpeedBoost,
            TintedLens,
            Frisk,
        },
    };
    public static SpeciesData Leafeon = new()
    {
        speciesName = "Leafeon",
        type1 = Grass,
        type2 = Grass,
        baseHP = 65,
        baseAttack = 110,
        baseDefense = 130,
        baseSpAtk = 60,
        baseSpDef = 65,
        baseSpeed = 95,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "leafeon", //Verify
        graphicsLocation = "leafeon", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            LeafGuard,
            LeafGuard,
            Chlorophyll,
        },
    };
    public static SpeciesData Glaceon = new()
    {
        speciesName = "Glaceon",
        type1 = Ice,
        type2 = Ice,
        baseHP = 65,
        baseAttack = 60,
        baseDefense = 110,
        baseSpAtk = 130,
        baseSpDef = 95,
        baseSpeed = 65,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
        malePercent = 87,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 35,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "glaceon", //Verify
        graphicsLocation = "glaceon", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            IceBody,
        },
    };
    public static SpeciesData Gliscor = new()
    {
        speciesName = "Gliscor",
        type1 = Ground,
        type2 = Flying,
        baseHP = 75,
        baseAttack = 95,
        baseDefense = 125,
        baseSpAtk = 45,
        baseSpDef = 75,
        baseSpeed = 95,
        evYield = 2 * Defense,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 179,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "gliscor", //Verify
        graphicsLocation = "gliscor", //Verify
        backSpriteHeight = 11,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            HyperCutter,
            SandVeil,
            PoisonHeal,
        },
    };
    public static SpeciesData Mamoswine = new()
    {
        speciesName = "Mamoswine",
        type1 = Ice,
        type2 = Ground,
        baseHP = 110,
        baseAttack = 130,
        baseDefense = 80,
        baseSpAtk = 70,
        baseSpDef = 60,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 239,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 50,
        baseFriendship = 70,
        cryLocation = "mamoswine", //Verify
        graphicsLocation = "mamoswine", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Oblivious,
            SnowCloak,
            ThickFat,
        },
    };
    public static SpeciesData PorygonZ = new()
    {
        speciesName = "Porygon-Z",
        type1 = Normal,
        type2 = Normal,
        baseHP = 85,
        baseAttack = 80,
        baseDefense = 70,
        baseSpAtk = 135,
        baseSpDef = 75,
        baseSpeed = 90,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 241,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "porygon_z", //Verify
        graphicsLocation = "porygon_z", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Adaptability,
            Download,
            Analytic,
        },
    };
    public static SpeciesData Gallade = new()
    {
        speciesName = "Gallade",
        type1 = Psychic,
        type2 = Fighting,
        baseHP = 68,
        baseAttack = 125,
        baseDefense = 65,
        baseSpAtk = 65,
        baseSpDef = 115,
        baseSpeed = 80,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 233,
        learnset = EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.HumanLike,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "gallade", //Verify
        graphicsLocation = "gallade", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Steadfast,
            Steadfast,
            Justified,
        },
    };
    public static SpeciesData Probopass = new()
    {
        speciesName = "Probopass",
        type1 = Rock,
        type2 = Steel,
        baseHP = 60,
        baseAttack = 55,
        baseDefense = 145,
        baseSpAtk = 75,
        baseSpDef = 150,
        baseSpeed = 40,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 184,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "probopass", //Verify
        graphicsLocation = "probopass", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Sturdy,
            MagnetPull,
            SandForce,
        },
    };
    public static SpeciesData Dusknoir = new()
    {
        speciesName = "Dusknoir",
        type1 = Ghost,
        type2 = Ghost,
        baseHP = 45,
        baseAttack = 100,
        baseDefense = 135,
        baseSpAtk = 65,
        baseSpDef = 135,
        baseSpeed = 45,
        evYield = Defense + 2 * SpDef,
        evolution = Evolution.None,
        xpClass = Fast,
        xpYield = 236,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        catchRate = 45,
        baseFriendship = 35,
        cryLocation = "dusknoir", //Verify
        graphicsLocation = "dusknoir", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Pressure,
            Pressure,
            Frisk,
        },
    };
    public static SpeciesData Froslass = new()
    {
        speciesName = "Froslass",
        type1 = Ice,
        type2 = Ghost,
        baseHP = 70,
        baseAttack = 80,
        baseDefense = 70,
        baseSpAtk = 80,
        baseSpDef = 70,
        baseSpeed = 110,
        evYield = 2 * Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 168,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "froslass", //Verify
        graphicsLocation = "froslass", //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            CursedBody,
        },
    };
    public static SpeciesData Rotom = new()
    {
        speciesName = "Rotom",
        type1 = Electric,
        type2 = Ghost,
        baseHP = 50,
        baseAttack = 50,
        baseDefense = 77,
        baseSpAtk = 95,
        baseSpDef = 77,
        baseSpeed = 91,
        evYield = Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "rotom", //Verify
        graphicsLocation = "rotom", //Verify
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Uxie = new()
    {
        speciesName = "Uxie",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 75,
        baseAttack = 75,
        baseDefense = 130,
        baseSpAtk = 75,
        baseSpDef = 130,
        baseSpeed = 95,
        evYield = 2 * Defense + SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 140,
        cryLocation = "uxie", //Verify
        graphicsLocation = "uxie", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Mesprit = new()
    {
        speciesName = "Mesprit",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 80,
        baseAttack = 105,
        baseDefense = 105,
        baseSpAtk = 105,
        baseSpDef = 105,
        baseSpeed = 80,
        evYield = Attack + SpAtk + SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 140,
        cryLocation = "mesprit", //Verify
        graphicsLocation = "mesprit", //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Azelf = new()
    {
        speciesName = "Azelf",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 75,
        baseAttack = 125,
        baseDefense = 70,
        baseSpAtk = 125,
        baseSpDef = 70,
        baseSpeed = 115,
        evYield = 2 * Attack + SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 140,
        cryLocation = "azelf", //Verify
        graphicsLocation = "azelf", //Verify
        backSpriteHeight = 6,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Dialga = Dialga(
        baseAttack: 120,
        baseSpDef: 100,
        graphics: "dialga",
        backSpriteHeight: 0
    );
    public static SpeciesData Palkia = Palkia(
        baseAttack: 120,
        baseSpeed: 100,
        graphics: "palkia",
        backSpriteHeight: 6
    );
    public static SpeciesData Heatran = new()
    {
        speciesName = "Heatran",
        type1 = Fire,
        type2 = Steel,
        baseHP = 91,
        baseAttack = 90,
        baseDefense = 106,
        baseSpAtk = 130,
        baseSpDef = 106,
        baseSpeed = 77,
        evYield = 3 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 3,
        baseFriendship = 100,
        cryLocation = "heatran", //Verify
        graphicsLocation = "heatran", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            FlashFire,
            FlashFire,
            FlameBody,
        },
    };
    public static SpeciesData Regigigas = new()
    {
        speciesName = "Regigigas",
        type1 = Normal,
        type2 = Normal,
        baseHP = 110,
        baseAttack = 160,
        baseDefense = 110,
        baseSpAtk = 80,
        baseSpDef = 110,
        baseSpeed = 100,
        evYield = 3 * Attack,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 302,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "regigigas", //Verify
        graphicsLocation = "regigigas", //Verify
        backSpriteHeight = 13,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            SlowStart,
            SlowStart,
            SlowStart,
        },
    };
    public static SpeciesData Giratina = Giratina(
        baseAttack: 100,
        baseSpAtk: 100,
        baseDefense: 120,
        baseSpDef: 120,
        graphics: "giratina",
        backSpriteHeight: 4
    );
    public static SpeciesData Cresselia = new()
    {
        speciesName = "Cresselia",
        type1 = Psychic,
        type2 = Psychic,
        baseHP = 120,
        baseAttack = 70,
        baseDefense = 120,
        baseSpAtk = 75,
        baseSpDef = 130,
        baseSpeed = 85,
        evYield = 3 * SpDef,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 100,
        cryLocation = "cresselia", //Verify
        graphicsLocation = "cresselia", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };
    public static SpeciesData Phione = new()
    {
        speciesName = "Phione",
        type1 = Water,
        type2 = Water,
        baseHP = 80,
        baseAttack = 80,
        baseDefense = 80,
        baseSpAtk = 80,
        baseSpDef = 80,
        baseSpeed = 80,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 216,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 40,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "phione", //Verify
        graphicsLocation = "phione", //Verify
        backSpriteHeight = 9,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Hydration,
            Hydration,
            Hydration,
        },
    };
    public static SpeciesData Manaphy = new()
    {
        speciesName = "Manaphy",
        type1 = Water,
        type2 = Water,
        baseHP = 100,
        baseAttack = 100,
        baseDefense = 100,
        baseSpAtk = 100,
        baseSpDef = 100,
        baseSpeed = 100,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Water1,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 10,
        catchRate = 3,
        baseFriendship = 70,
        cryLocation = "manaphy", //Verify
        graphicsLocation = "manaphy", //Verify
        backSpriteHeight = 10,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            Hydration,
            Hydration,
            Hydration,
        },
    };
    public static SpeciesData Darkrai = new()
    {
        speciesName = "Darkrai",
        type1 = Dark,
        type2 = Dark,
        baseHP = 70,
        baseAttack = 90,
        baseDefense = 90,
        baseSpAtk = 135,
        baseSpDef = 90,
        baseSpeed = 125,
        evYield = Speed + 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 270,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "darkrai", //Verify
        graphicsLocation = "darkrai", //Verify
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new Ability[3]
        {
            BadDreams,
            BadDreams,
            BadDreams,
        },
    };
    public static SpeciesData Shaymin = Shaymin(
        type2: Grass,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        ability: NaturalCure,
        cry: "shaymin",
        graphics: "shaymin",
        backSpriteHeight: 15
    );
    public static SpeciesData Arceus = Arceus(Normal, "arceus");




    //Forms

    //Megas

    public static SpeciesData VenusaurMega = Mega(
            baseSpecies: Venusaur,
            baseAttack: 100,
            baseDefense: 123,
            baseSpAtk: 122,
            baseSpDef: 120,
            baseSpeed: 80,
            backSpriteHeight: 8,
            pokedexData: Pokedex.Venusaur, //Not done
            ability: ThickFat
        );

    public static SpeciesData CharizardMegaX = Mega(
        baseSpecies: Charizard,
        name: "Mega Charizard X",
        type2: Dragon,
        baseAttack: 130,
        baseDefense: 111,
        baseSpAtk: 130,
        baseSpDef: 85,
        baseSpeed: 100,
        cry: "mega_charizard_x",
        graphics: "charizard/mega_x",
        backSpriteHeight: 1,
        pokedexData: Pokedex.Charizard, //Not done
        ability: ToughClaws
    );

    public static SpeciesData CharizardMegaY = Mega(
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
        ability: Drought
    );

    public static SpeciesData BlastoiseMega = Mega(
        baseSpecies: Blastoise,
        baseAttack: 103,
        baseDefense: 120,
        baseSpAtk: 135,
        baseSpDef: 115,
        baseSpeed: 78,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Blastoise, //Not done
        ability: MegaLauncher
    );

    public static SpeciesData BeedrillMega = Mega(
        baseSpecies: Beedrill,
        baseAttack: 150,
        baseDefense: 40,
        baseSpAtk: 15,
        baseSpDef: 80,
        baseSpeed: 145,
        backSpriteHeight: 5,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Adaptability
    );

    public static SpeciesData PidgeotMega = Mega(
        baseSpecies: Pidgeot,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 121,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: NoGuard
    );

    public static SpeciesData AlakazamMega = Mega(
        baseSpecies: Alakazam,
        baseAttack: 50,
        baseDefense: 65,
        baseSpAtk: 175,
        baseSpDef: 105,
        baseSpeed: 150,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Trace
    );

    public static SpeciesData SlowbroMega = Mega(
        baseSpecies: Slowbro,
        baseAttack: 75,
        baseDefense: 180,
        baseSpAtk: 130,
        baseSpDef: 80,
        baseSpeed: 30,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: ShellArmor
    );

    public static SpeciesData GengarMega = Mega(
        baseSpecies: Gengar,
        baseAttack: 65,
        baseDefense: 80,
        baseSpAtk: 170,
        baseSpDef: 95,
        baseSpeed: 130,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: ShadowTag
    );

    public static SpeciesData KangaskhanMega = Mega(
        baseSpecies: Kangaskhan,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 100,
        baseSpeed: 100,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: ParentalBond
    );

    public static SpeciesData PinsirMega = Mega(
        baseSpecies: Pinsir,
        type2: Flying,
        baseAttack: 155,
        baseDefense: 120,
        baseSpAtk: 65,
        baseSpDef: 90,
        baseSpeed: 105,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Aerilate
    );

    public static SpeciesData GyaradosMega = Mega(
        baseSpecies: Gyarados,
        type2: Dark,
        baseAttack: 155,
        baseDefense: 109,
        baseSpAtk: 70,
        baseSpDef: 130,
        baseSpeed: 81,
        backSpriteHeight: 2,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: MoldBreaker
    );

    public static SpeciesData AerodactylMega = Mega(
        baseSpecies: Aerodactyl,
        baseAttack: 135,
        baseDefense: 85,
        baseSpAtk: 70,
        baseSpDef: 95,
        baseSpeed: 150,
        backSpriteHeight: 8,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: ToughClaws
    );

    public static SpeciesData MewtwoMegaX = Mega(
        baseSpecies: Mewtwo,
        name: "Mega Mewtwo X",
        type2: Fighting,
        baseAttack: 190,
        baseDefense: 100,
        baseSpAtk: 154,
        baseSpDef: 100,
        baseSpeed: 130,
        backSpriteHeight: 1,
        cry: "mega_mewtwo_x",
        graphics: "mewtwo/mega_x",
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Steadfast
     );

    public static SpeciesData MewtwoMegaY = Mega(
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
        ability: Insomnia
    );

    public static SpeciesData AmpharosMega = Mega(
        baseSpecies: Ampharos,
        type2: Dragon,
        baseAttack: 95,
        baseDefense: 105,
        baseSpAtk: 165,
        baseSpDef: 110,
        baseSpeed: 45,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: MoldBreaker
    );

    public static SpeciesData SteelixMega = Mega(
        baseSpecies: Steelix,
        baseAttack: 125,
        baseDefense: 230,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 30,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done,
        ability: SandForce
    );

    public static SpeciesData ScizorMega = Mega(
        baseSpecies: Scizor,
        baseAttack: 150,
        baseDefense: 140,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 75,
        backSpriteHeight: 4,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Technician
    );

    public static SpeciesData HeracrossMega = Mega(
        baseSpecies: Heracross,
        baseAttack: 185,
        baseDefense: 115,
        baseSpAtk: 40,
        baseSpDef: 105,
        baseSpeed: 75,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SkillLink
    );

    public static SpeciesData HoundoomMega = Mega(
        baseSpecies: Houndoom,
        baseAttack: 90,
        baseDefense: 90,
        baseSpAtk: 140,
        baseSpDef: 90,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SolarPower
    );

    public static SpeciesData TyranitarMega = Mega(
        baseSpecies: Tyranitar,
        baseAttack: 164,
        baseDefense: 150,
        baseSpAtk: 95,
        baseSpDef: 120,
        baseSpeed: 71,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SandStream
    );

    public static SpeciesData SceptileMega = Mega(
        baseSpecies: Sceptile,
        type2: Dragon,
        baseAttack: 110,
        baseDefense: 75,
        baseSpAtk: 145,
        baseSpDef: 85,
        baseSpeed: 145,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: LightningRod
    );

    public static SpeciesData BlazikenMega = Mega(
        baseSpecies: Blaziken,
        baseAttack: 160,
        baseDefense: 80,
        baseSpAtk: 130,
        baseSpDef: 80,
        baseSpeed: 100,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SpeedBoost
    );

    public static SpeciesData SwampertMega = Mega(
        baseSpecies: Swampert,
        baseAttack: 150,
        baseDefense: 110,
        baseSpAtk: 95,
        baseSpDef: 110,
        baseSpeed: 70,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SwiftSwim
    );

    public static SpeciesData GardevoirMega = Mega(
        baseSpecies: Gardevoir,
        baseAttack: 85,
        baseDefense: 65,
        baseSpAtk: 165,
        baseSpDef: 135,
        baseSpeed: 100,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Pixilate
    );

    public static SpeciesData SableyeMega = Mega(
        baseSpecies: Sableye,
        baseAttack: 85,
        baseDefense: 125,
        baseSpAtk: 85,
        baseSpDef: 115,
        baseSpeed: 20,
        backSpriteHeight: 13,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: MagicBounce
    );

    public static SpeciesData MawileMega = Mega(
        baseSpecies: Mawile,
        baseAttack: 105,
        baseDefense: 125,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 50,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: HugePower
    );

    public static SpeciesData AggronMega = Mega(
        baseSpecies: Aggron,
        type2: Steel,
        baseAttack: 140,
        baseDefense: 230,
        baseSpAtk: 60,
        baseSpDef: 80,
        baseSpeed: 50,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Filter
    );

    public static SpeciesData MedichamMega = Mega(
        baseSpecies: Medicham,
        baseAttack: 100,
        baseDefense: 85,
        baseSpAtk: 80,
        baseSpDef: 85,
        baseSpeed: 100,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: PurePower
    );

    public static SpeciesData ManectricMega = Mega(
        baseSpecies: Manectric,
        baseAttack: 75,
        baseDefense: 80,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 135,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Intimidate
    );

    public static SpeciesData SharpedoMega = Mega(
        baseSpecies: Sharpedo,
        baseAttack: 140,
        baseDefense: 70,
        baseSpAtk: 110,
        baseSpDef: 65,
        baseSpeed: 105,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: StrongJaw
    );

    public static SpeciesData CameruptMega = Mega(
        baseSpecies: Camerupt,
        baseAttack: 120,
        baseDefense: 100,
        baseSpAtk: 145,
        baseSpDef: 105,
        baseSpeed: 20,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SheerForce
    );

    public static SpeciesData AltariaMega = Mega(
        baseSpecies: Altaria,
        type2: Fairy,
        baseAttack: 110,
        baseDefense: 110,
        baseSpAtk: 110,
        baseSpDef: 105,
        baseSpeed: 80,
        backSpriteHeight: 10,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Pixilate
    );

    public static SpeciesData BanetteMega = Mega(
        baseSpecies: Banette,
        baseAttack: 165,
        baseDefense: 75,
        baseSpAtk: 93,
        baseSpDef: 83,
        baseSpeed: 75,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Prankster
    );

    public static SpeciesData AbsolMega = Mega(
        baseSpecies: Absol,
        baseAttack: 150,
        baseDefense: 60,
        baseSpAtk: 115,
        baseSpDef: 60,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: MagicBounce
    );

    public static SpeciesData GlalieMega = Mega(
        baseSpecies: Glalie,
        baseAttack: 120,
        baseDefense: 80,
        baseSpAtk: 120,
        baseSpDef: 80,
        baseSpeed: 100,
        backSpriteHeight: 10,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Refrigerate
    );

    public static SpeciesData SalamenceMega = Mega(
        baseSpecies: Salamence,
        baseAttack: 145,
        baseDefense: 130,
        baseSpAtk: 120,
        baseSpDef: 90,
        baseSpeed: 120,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Aerilate
    );

    public static SpeciesData MetagrossMega = Mega(
        baseSpecies: Metagross,
        baseAttack: 145,
        baseDefense: 150,
        baseSpAtk: 105,
        baseSpDef: 110,
        baseSpeed: 110,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: ToughClaws
    );

    public static SpeciesData LatiasMega = Mega(
        baseSpecies: Latias,
        baseAttack: 100,
        baseDefense: 120,
        baseSpAtk: 140,
        baseSpDef: 150,
        baseSpeed: 110,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Levitate
    );

    public static SpeciesData LatiosMega = Mega(
        baseSpecies: Latios,
        baseAttack: 130,
        baseDefense: 100,
        baseSpAtk: 160,
        baseSpDef: 120,
        baseSpeed: 110,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Levitate
    );

    public static SpeciesData RayquazaMega = Mega(
        baseSpecies: Rayquaza,
        baseAttack: 180,
        baseDefense: 100,
        baseSpAtk: 180,
        baseSpDef: 100,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: DeltaStream
    );

    public static SpeciesData LopunnyMega = Mega(
        baseSpecies: Lopunny,
        type2: Fighting,
        baseAttack: 136,
        baseDefense: 94,
        baseSpAtk: 54,
        baseSpDef: 96,
        baseSpeed: 135,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Scrappy
    );

    public static SpeciesData GarchompMega = Mega(
        baseSpecies: Garchomp,
        baseAttack: 170,
        baseDefense: 115,
        baseSpAtk: 120,
        baseSpDef: 95,
        baseSpeed: 92,
        backSpriteHeight: 4,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SandForce
    );

    public static SpeciesData LucarioMega = Mega(
        baseSpecies: Lucario,
        baseAttack: 145,
        baseDefense: 88,
        baseSpAtk: 140,
        baseSpDef: 70,
        baseSpeed: 112,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: Adaptability
    );

    public static SpeciesData AbomasnowMega = Mega(
        baseSpecies: Abomasnow,
        baseAttack: 132,
        baseDefense: 105,
        baseSpAtk: 132,
        baseSpDef: 105,
        baseSpeed: 30,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: SnowWarning
    );

    public static SpeciesData GalladeMega = Mega(
        baseSpecies: Gallade,
        baseAttack: 165,
        baseDefense: 95,
        baseSpAtk: 65,
        baseSpDef: 115,
        baseSpeed: 110,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Bulbasaur, //Not done
        ability: InnerFocus
    );
    //Unown forms

    public static SpeciesData Unown_B
        = Unown("unown/b", 9);
    public static SpeciesData Unown_C
        = Unown("unown/c", 6);
    public static SpeciesData Unown_D
        = Unown("unown/d", 8);
    public static SpeciesData Unown_E
        = Unown("unown/e", 10);
    public static SpeciesData Unown_F
        = Unown("unown/f", 10);
    public static SpeciesData Unown_G
        = Unown("unown/g", 5);
    public static SpeciesData Unown_H
        = Unown("unown/h", 8);
    public static SpeciesData Unown_I
        = Unown("unown/i", 7);
    public static SpeciesData Unown_J
        = Unown("unown/j", 9);
    public static SpeciesData Unown_K
        = Unown("unown/k", 7);
    public static SpeciesData Unown_L
        = Unown("unown/l", 10);
    public static SpeciesData Unown_M
        = Unown("unown/m", 13);
    public static SpeciesData Unown_N
        = Unown("unown/n", 13);
    public static SpeciesData Unown_O
        = Unown("unown/o", 8);
    public static SpeciesData Unown_P
        = Unown("unown/p", 10);
    public static SpeciesData Unown_Q
        = Unown("unown/q", 15);
    public static SpeciesData Unown_R
        = Unown("unown/r", 12);
    public static SpeciesData Unown_S
        = Unown("unown/s", 4);
    public static SpeciesData Unown_T
        = Unown("unown/t", 13);
    public static SpeciesData Unown_U
        = Unown("unown/u", 13);
    public static SpeciesData Unown_V
        = Unown("unown/v", 11);
    public static SpeciesData Unown_W
        = Unown("unown/w", 13);
    public static SpeciesData Unown_X
        = Unown("unown/x", 15);
    public static SpeciesData Unown_Y
        = Unown("unown/y", 10);
    public static SpeciesData Unown_Z
        = Unown("unown/z", 10);

    //Castform forms

    public static SpeciesData CastformSunny =
        Castform(Fire, "castform/sunny", 0);
    public static SpeciesData CastformRainy =
        Castform(Water, "castform/rainy", 0);
    public static SpeciesData CastformSnowy =
        Castform(Ice, "castform/snowy", 0);

    //Deoxys forms

    public static SpeciesData DeoxysAttack =
        Deoxys(
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
        Deoxys(
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
        Deoxys(
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

    // Burmy forms

    public static SpeciesData BurmySand =
        Burmy("burmy/sandy_cloak", 7, Evolution.BurmySand);
    public static SpeciesData BurmyTrash =
        Burmy("burmy/trash_cloak", 0, Evolution.BurmyTrash);
    public static SpeciesData WormadamSand = Wormadam(
        type2: Ground,
        baseHP: 60,
        baseAttack: 79,
        baseDefense: 105,
        baseSpAtk: 59,
        baseSpDef: 85,
        baseSpeed: 36,
        evYield: Defense * 2,
        graphics: "wormadam/sandy_cloak",
        backSpriteHeight: 2
    );
    public static SpeciesData WormadamTrash = Wormadam(
        type2: Steel,
        baseHP: 60,
        baseAttack: 69,
        baseDefense: 95,
        baseSpAtk: 69,
        baseSpDef: 95,
        baseSpeed: 36,
        evYield: Defense + SpDef,
        graphics: "wormadam/trash_cloak",
        backSpriteHeight: 2
    );

    public static SpeciesData CherrimSunshine = Cherrim("cherrim/sunshine", 6);

    public static SpeciesData ShellosEast = Shellos("shellos/east_sea", 8, Evolution.ShellosEast);
    public static SpeciesData GastrodonEast = Gastrodon("gastrodon/east_sea", 3);

    public static SpeciesData RotomHeat = RotomForm(Fire, "rotom/heat", 12);
    public static SpeciesData RotomWash = RotomForm(Water, "rotom/wash", 11);
    public static SpeciesData RotomFrost = RotomForm(Ice, "rotom/frost", 7);
    public static SpeciesData RotomFan = RotomForm(Flying, "rotom/fan", 8);
    public static SpeciesData RotomMow = RotomForm(Grass, "rotom/mow", 10);

    public static SpeciesData ArceusFire = Arceus(Fire, "arceus/fire");
    public static SpeciesData ArceusWater = Arceus(Water, "arceus/water");
    public static SpeciesData ArceusGrass = Arceus(Grass, "arceus/grass");
    public static SpeciesData ArceusElectric = Arceus(Electric, "arceus/electric");
    public static SpeciesData ArceusIce = Arceus(Ice, "arceus/ice");
    public static SpeciesData ArceusGround = Arceus(Ground, "arceus/ground");
    public static SpeciesData ArceusFighting = Arceus(Fighting, "arceus/fighting");
    public static SpeciesData ArceusFlying = Arceus(Flying, "arceus.flying");
    public static SpeciesData ArceusRock = Arceus(Rock, "arceus/rock");
    public static SpeciesData ArceusPoison = Arceus(Poison, "arceus/poison");
    public static SpeciesData ArceusBug = Arceus(Bug, "arceus/bug");
    public static SpeciesData ArceusPsychic = Arceus(Psychic, "arceus/psychic");
    public static SpeciesData ArceusGhost = Arceus(Ghost, "arceus/ghost");
    public static SpeciesData ArceusDragon = Arceus(Dragon, "arceus/dragon");
    public static SpeciesData ArceusDark = Arceus(Dark, "arceus/dark");
    public static SpeciesData ArceusSteel = Arceus(Steel, "arceus/steel");
    public static SpeciesData ArceusFairy = Arceus(Fairy, "arceus/fairy");

    public static SpeciesData DialgaOrigin = Dialga(
        baseAttack: 100,
        baseSpDef: 120,
        graphics: "dialga/origin",
        backSpriteHeight: 0
    );

    public static SpeciesData PalkiaOrigin = Palkia(
        baseAttack: 100,
        baseSpeed: 120,
        graphics: "palkia/origin",
        backSpriteHeight: 3
    );

    public static SpeciesData GiratinaOrigin = Giratina(
        baseAttack: 120,
        baseSpAtk: 120,
        baseDefense: 100,
        baseSpDef: 100,
        graphics: "giratina/origin",
        backSpriteHeight: 4
    );

    public static SpeciesData ShayminSky = Shaymin(
        type2: Flying,
        baseHP: 100,
        baseAttack: 103,
        baseDefense: 75,
        baseSpAtk: 120,
        baseSpDef: 75,
        baseSpeed: 127,
        ability: SereneGrace,
        cry: "shaymin_sky",
        graphics: "shaymin/sky",
        backSpriteHeight: 2
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

            //Gen 4
        Turtwig,
        Grotle,
        Torterra,
        Chimchar,
        Monferno,
        Infernape,
        Piplup,
        Prinplup,
        Empoleon,
        Starly,
        Staravia,
        Staraptor,
        Bidoof,
        Bibarel,
        Kricketot,
        Kricketune,
        Shinx,
        Luxio,
        Luxray,
        Budew,
        Roserade,
        Cranidos,
        Rampardos,
        Shieldon,
        Bastiodon,
        Burmy,
        Wormadam,
        Mothim,
        Combee,
        Vespiquen,
        Pachirisu,
        Buizel,
        Floatzel,
        Cherubi,
        Cherrim,
        Shellos,
        Gastrodon,
        Ambipom,
        Drifloon,
        Drifblim,
        Buneary,
        Lopunny,
        Mismagius,
        Honchkrow,
        Glameow,
        Purugly,
        Chingling,
        Stunky,
        Skuntank,
        Bronzor,
        Bronzong,
        Bonsly,
        MimeJr,
        Happiny,
        Chatot,
        Spiritomb,
        Gible,
        Gabite,
        Garchomp,
        Munchlax,
        Riolu,
        Lucario,
        Hippopotas,
        Hippowdon,
        Skorupi,
        Drapion,
        Croagunk,
        Toxicroak,
        Carnivine,
        Finneon,
        Lumineon,
        Mantyke,
        Snover,
        Abomasnow,
        Weavile,
        Magnezone,
        Lickilicky,
        Rhyperior,
        Tangrowth,
        Electivire,
        Magmortar,
        Togekiss,
        Yanmega,
        Leafeon,
        Glaceon,
        Gliscor,
        Mamoswine,
        PorygonZ,
        Gallade,
        Probopass,
        Dusknoir,
        Froslass,
        Rotom,
        Uxie,
        Mesprit,
        Azelf,
        Dialga,
        Palkia,
        Heatran,
        Regigigas,
        Giratina,
        Cresselia,
        Phione,
        Manaphy,
        Darkrai,
        Shaymin,
        Arceus,

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

        BurmySand,
        BurmyTrash,
        WormadamSand,
        WormadamTrash,

        CherrimSunshine,

        ShellosEast,
        GastrodonEast,

        RotomHeat,
        RotomWash,
        RotomFrost,
        RotomFan,
        RotomMow,

        DialgaOrigin,
        PalkiaOrigin,
        GiratinaOrigin,

        ShayminSky,

        ArceusFighting,
        ArceusFlying,
        ArceusPoison,
        ArceusGround,
        ArceusRock,
        ArceusBug,
        ArceusGhost,
        ArceusSteel,
        ArceusFire,
        ArceusWater,
        ArceusGrass,
        ArceusElectric,
        ArceusIce,
        ArceusDragon,
        ArceusDark,
        ArceusFairy,

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
        SceptileMega,
        BlazikenMega,
        SwampertMega,
        GardevoirMega,
        SableyeMega,
        MawileMega,
        AggronMega,
        MedichamMega,
        ManectricMega,
        SharpedoMega,
        CameruptMega,
        AltariaMega,
        BanetteMega,
        AbsolMega,
        GlalieMega,
        SalamenceMega,
        MetagrossMega,
        LatiasMega,
        LatiosMega,
        RayquazaMega,
        LopunnyMega,
        GarchompMega,
        LucarioMega,
        AbomasnowMega,
        GalladeMega,
    };
}