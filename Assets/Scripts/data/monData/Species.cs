using static EvYield;
using static Ability;
using static Type;
using static SpeciesData;
using static XPClass;
using static Learnset;
using Unity.VisualScripting;

public static class Species
{
    public static readonly SpeciesData Missingno = new(
        speciesName: "Missingno",
        type1: Typeless,
        type2: Typeless,
        baseHP: 0,
        baseAttack: 0,
        baseDefense: 0,
        baseSpAtk: 0,
        baseSpDef: 0,
        baseSpeed: 0,
        evYield: 0,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 0,
        learnset: EmptyLearnset,
        cryLocation: "pikachu",
        graphicsLocation: "question_mark/circled",
        backSpriteHeight: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 1,
        catchRate: 0,
        pokedexData: Pokedex.Bulbasaur,
        malePercent: Genderless,
        abilities: new Ability[3]
        {
            None,
            None,
            None,
        }
    );
    public static readonly SpeciesData Bulbasaur = new(
        speciesName: "Bulbasaur",
        type1: Grass,
        type2: Poison,
        baseHP: 45,
        baseAttack: 49,
        baseDefense: 49,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: SpAtk,
        evolution: Evolution.Bulbasaur,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: BulbasaurLearnset,
        catchRate: 45,
        baseFriendship: 70,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        malePercent: 87,
        cryLocation: "bulbasaur",
        graphicsLocation: "bulbasaur",
        backSpriteHeight: 13,
        pokedexData: Pokedex.Bulbasaur,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Ivysaur = new(
        speciesName: "Ivysaur",
        type1: Grass,
        type2: Poison,
        baseHP: 60,
        baseAttack: 62,
        baseDefense: 63,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 60,
        evYield: SpAtk + SpDef,
        evolution: Evolution.Ivysaur,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: IvysaurLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "ivysaur", //Verify
        graphicsLocation: "ivysaur", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Ivysaur,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Venusaur = new(
        speciesName: "Venusaur",
        type1: Grass,
        type2: Poison,
        baseHP: 80,
        baseAttack: 82,
        baseDefense: 83,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 80,
        evYield: 2 * SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 236,
        learnset: VenusaurLearnset,
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "venusaur", //Verify
        graphicsLocation: "venusaur", //Verify
        backSpriteHeight: 10,
        gMaxPath: "venusaur/gmax",
        gMaxBackHeight: 11,
        pokedexData: Pokedex.Venusaur,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Charmander = new(
        speciesName: "Charmander",
        type1: Fire,
        type2: Fire,
        baseHP: 39,
        baseAttack: 52,
        baseDefense: 43,
        baseSpAtk: 60,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Charmander,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "charmander", //Verify
        graphicsLocation: "charmander", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Charmander,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SolarPower,
        }
    );
    public static readonly SpeciesData Charmeleon = new(
        speciesName: "Charmeleon",
        type1: Fire,
        type2: Fire,
        baseHP: 58,
        baseAttack: 64,
        baseDefense: 58,
        baseSpAtk: 80,
        baseSpDef: 65,
        baseSpeed: 80,
        evYield: Speed + SpAtk,
        evolution: Evolution.Charmeleon,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "charmeleon", //Verify
        graphicsLocation: "charmeleon", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Charmeleon,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SolarPower,
        }
    );
    public static readonly SpeciesData Charizard = new(
        speciesName: "Charizard",
        type1: Fire,
        type2: Flying,
        baseHP: 78,
        baseAttack: 84,
        baseDefense: 78,
        baseSpAtk: 109,
        baseSpDef: 85,
        baseSpeed: 100,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 240,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "charizard", //Verify
        graphicsLocation: "charizard", //Verify
        backSpriteHeight: 1,
        gMaxPath: "charizard/gmax",
        gMaxBackHeight: 1,
        pokedexData: Pokedex.Charizard,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SolarPower,
        }
    );
    public static readonly SpeciesData Squirtle = new(
        speciesName: "Squirtle",
        type1: Water,
        type2: Water,
        baseHP: 44,
        baseAttack: 48,
        baseDefense: 65,
        baseSpAtk: 50,
        baseSpDef: 64,
        baseSpeed: 43,
        evYield: Defense,
        evolution: Evolution.Squirtle,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "squirtle", //Verify
        graphicsLocation: "squirtle", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Squirtle,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            RainDish,
        }
    );
    public static readonly SpeciesData Wartortle = new(
        speciesName: "Wartortle",
        type1: Water,
        type2: Water,
        baseHP: 59,
        baseAttack: 63,
        baseDefense: 80,
        baseSpAtk: 65,
        baseSpDef: 80,
        baseSpeed: 58,
        evYield: Defense + SpDef,
        evolution: Evolution.Wartortle,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "wartortle", //Verify
        graphicsLocation: "wartortle", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Wartortle,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            RainDish,
        }
    );
    public static readonly SpeciesData Blastoise = new(
        speciesName: "Blastoise",
        type1: Water,
        type2: Water,
        baseHP: 79,
        baseAttack: 83,
        baseDefense: 100,
        baseSpAtk: 85,
        baseSpDef: 105,
        baseSpeed: 78,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "blastoise", //Verify
        graphicsLocation: "blastoise", //Verify
        backSpriteHeight: 7,
        gMaxPath: "blastoise/gmax",
        gMaxBackHeight: 5,
        pokedexData: Pokedex.Blastoise,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            RainDish,
        }
    );
    public static readonly SpeciesData Caterpie = new(
        speciesName: "Caterpie",
        type1: Bug,
        type2: Bug,
        baseHP: 45,
        baseAttack: 30,
        baseDefense: 35,
        baseSpAtk: 20,
        baseSpDef: 20,
        baseSpeed: 45,
        evYield: HP,
        evolution: Evolution.Caterpie,
        xpClass: MediumFast,
        xpYield: 39,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "caterpie", //Verify
        graphicsLocation: "caterpie", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Caterpie,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            RunAway,
        }
    );
    public static readonly SpeciesData Metapod = new(
        speciesName: "Metapod",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 20,
        baseDefense: 55,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.Metapod,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "metapod", //Verify
        graphicsLocation: "metapod", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Metapod,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            ShedSkin,
        }
    );
    public static readonly SpeciesData Butterfree = new(
        speciesName: "Butterfree",
        type1: Bug,
        type2: Flying,
        baseHP: 60,
        baseAttack: 45,
        baseDefense: 50,
        baseSpAtk: 90,
        baseSpDef: 80,
        baseSpeed: 70,
        evYield: 2 * SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 178,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "butterfree", //Verify
        graphicsLocation: "butterfree", //Verify
        backSpriteHeight: 5,
        gMaxPath: "butterfree/gmax",
        gMaxBackHeight: 3,
        pokedexData: Pokedex.Butterfree,
        abilities: new Ability[3]
        {
            CompoundEyes,
            CompoundEyes,
            TintedLens,
        }
    );
    public static readonly SpeciesData Weedle = new(
        speciesName: "Weedle",
        type1: Bug,
        type2: Poison,
        baseHP: 40,
        baseAttack: 35,
        baseDefense: 30,
        baseSpAtk: 20,
        baseSpDef: 20,
        baseSpeed: 50,
        evYield: Speed,
        evolution: Evolution.Weedle,
        xpClass: MediumFast,
        xpYield: 39,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "weedle", //Verify
        graphicsLocation: "weedle", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Weedle,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            RunAway,
        }
    );
    public static readonly SpeciesData Kakuna = new(
        speciesName: "Kakuna",
        type1: Bug,
        type2: Poison,
        baseHP: 45,
        baseAttack: 25,
        baseDefense: 50,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.Kakuna,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "kakuna", //Verify
        graphicsLocation: "kakuna", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Kakuna,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            ShedSkin,
        }
    );
    public static readonly SpeciesData Beedrill = new(
        speciesName: "Beedrill",
        type1: Bug,
        type2: Poison,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 40,
        baseSpAtk: 45,
        baseSpDef: 80,
        baseSpeed: 75,
        evYield: 2 * Attack + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 178,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "beedrill", //Verify
        graphicsLocation: "beedrill", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Beedrill,
        abilities: new Ability[3]
        {
            Swarm,
            Swarm,
            Sniper,
        }
    );
    public static readonly SpeciesData Pidgey = new(
        speciesName: "Pidgey",
        type1: Normal,
        type2: Flying,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 40,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 56,
        evYield: Speed,
        evolution: Evolution.Pidgey,
        xpClass: MediumSlow,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "pidgey", //Verify
        graphicsLocation: "pidgey", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Pidgey,
        abilities: new Ability[3]
        {
            KeenEye,
            TangledFeet,
            BigPecks,
        }
    );
    public static readonly SpeciesData Pidgeotto = new(
        speciesName: "Pidgeotto",
        type1: Normal,
        type2: Flying,
        baseHP: 63,
        baseAttack: 60,
        baseDefense: 55,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 71,
        evYield: 2 * Speed,
        evolution: Evolution.Pidgeotto,
        xpClass: MediumSlow,
        xpYield: 122,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "pidgeotto", //Verify
        graphicsLocation: "pidgeotto", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Pidgeotto,
        abilities: new Ability[3]
        {
            KeenEye,
            TangledFeet,
            BigPecks,
        }
    );
    public static readonly SpeciesData Pidgeot = new(
        speciesName: "Pidgeot",
        type1: Normal,
        type2: Flying,
        baseHP: 83,
        baseAttack: 80,
        baseDefense: 75,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 101,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 216,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "pidgeot", //Verify
        graphicsLocation: "pidgeot", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Pidgeot,
        abilities: new Ability[3]
        {
            KeenEye,
            TangledFeet,
            BigPecks,
        }
    );
    public static readonly SpeciesData Rattata = new(
        speciesName: "Rattata",
        type1: Normal,
        type2: Normal,
        baseHP: 30,
        baseAttack: 56,
        baseDefense: 35,
        baseSpAtk: 25,
        baseSpDef: 35,
        baseSpeed: 72,
        evYield: Speed,
        evolution: Evolution.Rattata,
        xpClass: MediumFast,
        xpYield: 51,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "rattata", //Verify
        graphicsLocation: "rattata", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Rattata,
        abilities: new Ability[3]
        {
            RunAway,
            Guts,
            Hustle,
        }
    );
    public static readonly SpeciesData Raticate = new(
        speciesName: "Raticate",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 81,
        baseDefense: 60,
        baseSpAtk: 50,
        baseSpDef: 70,
        baseSpeed: 97,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "raticate", //Verify
        graphicsLocation: "raticate", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Raticate,
        abilities: new Ability[3]
        {
            RunAway,
            Guts,
            Hustle,
        }
    );
    public static readonly SpeciesData Spearow = new(
        speciesName: "Spearow",
        type1: Normal,
        type2: Flying,
        baseHP: 40,
        baseAttack: 60,
        baseDefense: 30,
        baseSpAtk: 31,
        baseSpDef: 31,
        baseSpeed: 70,
        evYield: Speed,
        evolution: Evolution.Spearow,
        xpClass: MediumFast,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "spearow", //Verify
        graphicsLocation: "spearow", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Spearow,
        abilities: new Ability[3]
        {
            KeenEye,
            KeenEye,
            Sniper,
        }
    );
    public static readonly SpeciesData Fearow = new(
        speciesName: "Fearow",
        type1: Normal,
        type2: Flying,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 65,
        baseSpAtk: 61,
        baseSpDef: 61,
        baseSpeed: 100,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 155,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "fearow", //Verify
        graphicsLocation: "fearow", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Fearow,
        abilities: new Ability[3]
        {
            KeenEye,
            KeenEye,
            Sniper,
        }
    );
    public static readonly SpeciesData Ekans = new(
        speciesName: "Ekans",
        type1: Poison,
        type2: Poison,
        baseHP: 35,
        baseAttack: 60,
        baseDefense: 44,
        baseSpAtk: 40,
        baseSpDef: 54,
        baseSpeed: 55,
        evYield: Attack,
        evolution: Evolution.Ekans,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "ekans", //Verify
        graphicsLocation: "ekans", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Ekans,
        abilities: new Ability[3]
        {
            Intimidate,
            ShedSkin,
            Unnerve,
        }
    );
    public static readonly SpeciesData Arbok = new(
        speciesName: "Arbok",
        type1: Poison,
        type2: Poison,
        baseHP: 60,
        baseAttack: 95,
        baseDefense: 69,
        baseSpAtk: 65,
        baseSpDef: 79,
        baseSpeed: 80,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 157,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "arbok", //Verify
        graphicsLocation: "arbok", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Arbok,
        abilities: new Ability[3]
        {
            Intimidate,
            ShedSkin,
            Unnerve,
        }
    );
    public static readonly SpeciesData Pikachu = new(
        speciesName: "Pikachu",
        type1: Electric,
        type2: Electric,
        baseHP: 35,
        baseAttack: 55,
        baseDefense: 40,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.Pikachu,
        xpClass: MediumFast,
        xpYield: 112,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pikachu", //Verify
        graphicsLocation: "pikachu", //Verify
        backSpriteHeight: 4,
        gMaxPath: "pikachu/gmax",
        gMaxBackHeight: 0,
        pokedexData: Pokedex.Pikachu,
        abilities: new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        }
    );
    public static readonly SpeciesData Raichu = new(
        speciesName: "Raichu",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 90,
        baseDefense: 55,
        baseSpAtk: 90,
        baseSpDef: 80,
        baseSpeed: 110,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 218,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "raichu", //Verify
        graphicsLocation: "raichu", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Raichu,
        abilities: new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        }
    );
    public static readonly SpeciesData Sandshrew = new(
        speciesName: "Sandshrew",
        type1: Ground,
        type2: Ground,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 85,
        baseSpAtk: 20,
        baseSpDef: 30,
        baseSpeed: 40,
        evYield: Defense,
        evolution: Evolution.Sandshrew,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "sandshrew", //Verify
        graphicsLocation: "sandshrew", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sandshrew,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            SandRush,
        }
    );
    public static readonly SpeciesData Sandslash = new(
        speciesName: "Sandslash",
        type1: Ground,
        type2: Ground,
        baseHP: 75,
        baseAttack: 100,
        baseDefense: 110,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 65,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "sandslash", //Verify
        graphicsLocation: "sandslash", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Sandslash,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            SandRush,
        }
    );
    public static readonly SpeciesData NidoranF = new(
        speciesName: "Nidoran",
        type1: Poison,
        type2: Poison,
        baseHP: 55,
        baseAttack: 47,
        baseDefense: 52,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 41,
        evYield: HP,
        evolution: Evolution.NidoranF,
        xpClass: MediumSlow,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "nidoran_f", //Verify
        graphicsLocation: "nidoran_f", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.NidoranF,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            Hustle,
        }

    );
    public static readonly SpeciesData Nidorina = new(
        speciesName: "Nidorina",
        type1: Poison,
        type2: Poison,
        baseHP: 70,
        baseAttack: 62,
        baseDefense: 67,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 56,
        evYield: 2 * HP,
        evolution: Evolution.Nidorina,
        xpClass: MediumSlow,
        xpYield: 128,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "nidorina", //Verify
        graphicsLocation: "nidorina", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Nidorina,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            Hustle,
        }
    );
    public static readonly SpeciesData Nidoqueen = new(
        speciesName: "Nidoqueen",
        type1: Poison,
        type2: Ground,
        baseHP: 90,
        baseAttack: 92,
        baseDefense: 87,
        baseSpAtk: 75,
        baseSpDef: 85,
        baseSpeed: 76,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 227,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "nidoqueen", //Verify
        graphicsLocation: "nidoqueen", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Nidoqueen,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            SheerForce,
        }
    );
    public static readonly SpeciesData NidoranM = new(
        speciesName: "Nidoran",
        type1: Poison,
        type2: Poison,
        baseHP: 46,
        baseAttack: 57,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.NidoranM,
        xpClass: MediumSlow,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "nidoran_m", //Verify
        graphicsLocation: "nidoran_m", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.NidoranM,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            Hustle,
        }
    );
    public static readonly SpeciesData Nidorino = new(
        speciesName: "Nidorino",
        type1: Poison,
        type2: Poison,
        baseHP: 61,
        baseAttack: 72,
        baseDefense: 57,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.Nidorino,
        xpClass: MediumSlow,
        xpYield: 128,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "nidorino", //Verify
        graphicsLocation: "nidorino", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Nidorino,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            Hustle,
        }
    );
    public static readonly SpeciesData Nidoking = new(
        speciesName: "Nidoking",
        type1: Poison,
        type2: Ground,
        baseHP: 81,
        baseAttack: 102,
        baseDefense: 77,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 85,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 227,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "nidoking", //Verify
        graphicsLocation: "nidoking", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Nidoking,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Rivalry,
            SheerForce,
        }
    );
    public static readonly SpeciesData Clefairy = new(
        speciesName: "Clefairy",
        type1: Fairy,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 45,
        baseDefense: 48,
        baseSpAtk: 60,
        baseSpDef: 65,
        baseSpeed: 35,
        evYield: 2 * HP,
        evolution: Evolution.Clefairy,
        xpClass: Fast,
        xpYield: 113,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 150,
        baseFriendship: 140,
        cryLocation: "clefairy", //Verify
        graphicsLocation: "clefairy", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Clefairy,
        abilities: new Ability[3]
        {
            CuteCharm,
            MagicGuard,
            FriendGuard,
        }
    );
    public static readonly SpeciesData Clefable = new(
        speciesName: "Clefable",
        type1: Fairy,
        type2: Fairy,
        baseHP: 95,
        baseAttack: 70,
        baseDefense: 73,
        baseSpAtk: 95,
        baseSpDef: 90,
        baseSpeed: 60,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 217,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 25,
        baseFriendship: 140,
        cryLocation: "clefable", //Verify
        graphicsLocation: "clefable", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Clefable,
        abilities: new Ability[3]
        {
            CuteCharm,
            MagicGuard,
            Unaware,
        }
    );
    public static readonly SpeciesData Vulpix = new(
        speciesName: "Vulpix",
        type1: Fire,
        type2: Fire,
        baseHP: 38,
        baseAttack: 41,
        baseDefense: 40,
        baseSpAtk: 50,
        baseSpDef: 65,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Vulpix,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "vulpix", //Verify
        graphicsLocation: "vulpix", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Vulpix,
        abilities: new Ability[3]
        {
            FlashFire,
            FlashFire,
            Drought,
        }
    );
    public static readonly SpeciesData Ninetales = new(
        speciesName: "Ninetales",
        type1: Fire,
        type2: Fire,
        baseHP: 73,
        baseAttack: 76,
        baseDefense: 75,
        baseSpAtk: 81,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: Speed + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "ninetales", //Verify
        graphicsLocation: "ninetales", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Ninetales,
        abilities: new Ability[3]
        {
            FlashFire,
            FlashFire,
            Drought,
        }
    );
    public static readonly SpeciesData Jigglypuff = new(
        speciesName: "Jigglypuff",
        type1: Normal,
        type2: Fairy,
        baseHP: 115,
        baseAttack: 45,
        baseDefense: 20,
        baseSpAtk: 45,
        baseSpDef: 25,
        baseSpeed: 20,
        evYield: 2 * HP,
        evolution: Evolution.Jigglypuff,
        xpClass: Fast,
        xpYield: 95,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 170,
        baseFriendship: 70,
        cryLocation: "jigglypuff", //Verify
        graphicsLocation: "jigglypuff", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Jigglypuff,
        abilities: new Ability[3]
        {
            CuteCharm,
            Competitive,
            FriendGuard,
        }
    );
    public static readonly SpeciesData Wigglytuff = new(
        speciesName: "Wigglytuff",
        type1: Normal,
        type2: Fairy,
        baseHP: 140,
        baseAttack: 70,
        baseDefense: 45,
        baseSpAtk: 85,
        baseSpDef: 50,
        baseSpeed: 45,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 196,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "wigglytuff", //Verify
        graphicsLocation: "wigglytuff", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Wigglytuff,
        abilities: new Ability[3]
        {
            CuteCharm,
            Competitive,
            Frisk,
        }
    );
    public static readonly SpeciesData Zubat = new(
        speciesName: "Zubat",
        type1: Poison,
        type2: Flying,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 35,
        baseSpAtk: 30,
        baseSpDef: 40,
        baseSpeed: 55,
        evYield: Speed,
        evolution: Evolution.Zubat,
        xpClass: MediumFast,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "zubat", //Verify
        graphicsLocation: "zubat", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Zubat,
        abilities: new Ability[3]
        {
            InnerFocus,
            InnerFocus,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Golbat = new(
        speciesName: "Golbat",
        type1: Poison,
        type2: Flying,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 75,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.Golbat,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "golbat", //Verify
        graphicsLocation: "golbat", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Golbat,
        abilities: new Ability[3]
        {
            InnerFocus,
            InnerFocus,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Oddish = new(
        speciesName: "Oddish",
        type1: Grass,
        type2: Poison,
        baseHP: 45,
        baseAttack: 50,
        baseDefense: 55,
        baseSpAtk: 75,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: SpAtk,
        evolution: Evolution.Oddish,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "oddish", //Verify
        graphicsLocation: "oddish", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Oddish,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            RunAway,
        }
    );
    public static readonly SpeciesData Gloom = new(
        speciesName: "Gloom",
        type1: Grass,
        type2: Poison,
        baseHP: 60,
        baseAttack: 65,
        baseDefense: 70,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 40,
        evYield: 2 * SpAtk,
        evolution: Evolution.Gloom,
        xpClass: MediumSlow,
        xpYield: 138,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "gloom", //Verify
        graphicsLocation: "gloom", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Gloom,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Stench,
        }
    );
    public static readonly SpeciesData Vileplume = new(
        speciesName: "Vileplume",
        type1: Grass,
        type2: Poison,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 85,
        baseSpAtk: 110,
        baseSpDef: 90,
        baseSpeed: 50,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vileplume", //Verify
        graphicsLocation: "vileplume", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Vileplume,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            EffectSpore,
        }
    );
    public static readonly SpeciesData Paras = new(
        speciesName: "Paras",
        type1: Bug,
        type2: Grass,
        baseHP: 35,
        baseAttack: 70,
        baseDefense: 55,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 25,
        evYield: Attack,
        evolution: Evolution.Paras,
        xpClass: MediumFast,
        xpYield: 57,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "paras", //Verify
        graphicsLocation: "paras", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Paras,
        abilities: new Ability[3]
        {
            EffectSpore,
            DrySkin,
            Damp,
        }
    );
    public static readonly SpeciesData Parasect = new(
        speciesName: "Parasect",
        type1: Bug,
        type2: Grass,
        baseHP: 60,
        baseAttack: 95,
        baseDefense: 80,
        baseSpAtk: 60,
        baseSpDef: 80,
        baseSpeed: 30,
        evYield: 2 * Attack + Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "parasect", //Verify
        graphicsLocation: "parasect", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Parasect,
        abilities: new Ability[3]
        {
            EffectSpore,
            DrySkin,
            Damp,
        }
    );
    public static readonly SpeciesData Venonat = new(
        speciesName: "Venonat",
        type1: Bug,
        type2: Poison,
        baseHP: 60,
        baseAttack: 55,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 55,
        baseSpeed: 45,
        evYield: SpDef,
        evolution: Evolution.Venonat,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "venonat", //Verify
        graphicsLocation: "venonat", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Venonat,
        abilities: new Ability[3]
        {
            CompoundEyes,
            TintedLens,
            RunAway,
        }
    );
    public static readonly SpeciesData Venomoth = new(
        speciesName: "Venomoth",
        type1: Bug,
        type2: Poison,
        baseHP: 70,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 90,
        baseSpDef: 75,
        baseSpeed: 90,
        evYield: Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "venomoth", //Verify
        graphicsLocation: "venomoth", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Venomoth,
        abilities: new Ability[3]
        {
            ShieldDust,
            TintedLens,
            WonderSkin,
        }
    );
    public static readonly SpeciesData Diglett = new(
        speciesName: "Diglett",
        type1: Ground,
        type2: Ground,
        baseHP: 10,
        baseAttack: 55,
        baseDefense: 25,
        baseSpAtk: 35,
        baseSpDef: 45,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.Diglett,
        xpClass: MediumFast,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "diglett", //Verify
        graphicsLocation: "diglett", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Diglett,
        abilities: new Ability[3]
        {
            SandVeil,
            ArenaTrap,
            SandForce,
        }
    );
    public static readonly SpeciesData Dugtrio = new(
        speciesName: "Dugtrio",
        type1: Ground,
        type2: Ground,
        baseHP: 35,
        baseAttack: 100,
        baseDefense: 50,
        baseSpAtk: 50,
        baseSpDef: 70,
        baseSpeed: 120,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "dugtrio", //Verify
        graphicsLocation: "dugtrio", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Dugtrio,
        abilities: new Ability[3]
        {
            SandVeil,
            ArenaTrap,
            SandForce,
        }
    );
    public static readonly SpeciesData Meowth = new(
        speciesName: "Meowth",
        type1: Normal,
        type2: Normal,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 35,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.Meowth,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "meowth", //Verify
        graphicsLocation: "meowth", //Verify
        backSpriteHeight: 6,
        gMaxPath: "meowth/gmax",
        gMaxBackHeight: 5,
        pokedexData: Pokedex.Meowth,
        abilities: new Ability[3]
        {
            Pickup,
            Technician,
            Unnerve,
        }
    );
    public static readonly SpeciesData Persian = new(
        speciesName: "Persian",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 70,
        baseDefense: 60,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "persian", //Verify
        graphicsLocation: "persian", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Persian,
        abilities: new Ability[3]
        {
            Limber,
            Technician,
            Unnerve,
        }
    );
    public static readonly SpeciesData Psyduck = new(
        speciesName: "Psyduck",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 52,
        baseDefense: 48,
        baseSpAtk: 65,
        baseSpDef: 50,
        baseSpeed: 55,
        evYield: SpAtk,
        evolution: Evolution.Psyduck,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "psyduck", //Verify
        graphicsLocation: "psyduck", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Psyduck,
        abilities: new Ability[3]
        {
            Damp,
            CloudNine,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Golduck = new(
        speciesName: "Golduck",
        type1: Water,
        type2: Water,
        baseHP: 80,
        baseAttack: 82,
        baseDefense: 78,
        baseSpAtk: 95,
        baseSpDef: 80,
        baseSpeed: 85,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "golduck", //Verify
        graphicsLocation: "golduck", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Golduck,
        abilities: new Ability[3]
        {
            Damp,
            CloudNine,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Mankey = new(
        speciesName: "Mankey",
        type1: Fighting,
        type2: Fighting,
        baseHP: 40,
        baseAttack: 80,
        baseDefense: 35,
        baseSpAtk: 35,
        baseSpDef: 45,
        baseSpeed: 70,
        evYield: Attack,
        evolution: Evolution.Mankey,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "mankey", //Verify
        graphicsLocation: "mankey", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Mankey,
        abilities: new Ability[3]
        {
            VitalSpirit,
            AngerPoint,
            Defiant,
        }
    );
    public static readonly SpeciesData Primeape = new(
        speciesName: "Primeape",
        type1: Fighting,
        type2: Fighting,
        baseHP: 65,
        baseAttack: 105,
        baseDefense: 60,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "primeape", //Verify
        graphicsLocation: "primeape", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Primeape,
        abilities: new Ability[3]
        {
            VitalSpirit,
            AngerPoint,
            Defiant,
        }
    );
    public static readonly SpeciesData Growlithe = new(
        speciesName: "Growlithe",
        type1: Fire,
        type2: Fire,
        baseHP: 55,
        baseAttack: 70,
        baseDefense: 45,
        baseSpAtk: 70,
        baseSpDef: 50,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Growlithe,
        xpClass: Slow,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "growlithe", //Verify
        graphicsLocation: "growlithe", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Growlithe,
        abilities: new Ability[3]
        {
            Intimidate,
            FlashFire,
            Justified,
        }
    );
    public static readonly SpeciesData Arcanine = new(
        speciesName: "Arcanine",
        type1: Fire,
        type2: Fire,
        baseHP: 90,
        baseAttack: 110,
        baseDefense: 80,
        baseSpAtk: 100,
        baseSpDef: 80,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 194,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "arcanine", //Verify
        graphicsLocation: "arcanine", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Arcanine,
        abilities: new Ability[3]
        {
            Intimidate,
            FlashFire,
            Justified,
        }
    );
    public static readonly SpeciesData Poliwag = new(
        speciesName: "Poliwag",
        type1: Water,
        type2: Water,
        baseHP: 40,
        baseAttack: 50,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.Poliwag,
        xpClass: MediumSlow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "poliwag", //Verify
        graphicsLocation: "poliwag", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Poliwag,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            Damp,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Poliwhirl = new(
        speciesName: "Poliwhirl",
        type1: Water,
        type2: Water,
        baseHP: 65,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.Poliwhirl,
        xpClass: MediumSlow,
        xpYield: 135,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "poliwhirl", //Verify
        graphicsLocation: "poliwhirl", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Poliwhirl,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            Damp,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Poliwrath = new(
        speciesName: "Poliwrath",
        type1: Water,
        type2: Fighting,
        baseHP: 90,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 70,
        baseSpDef: 90,
        baseSpeed: 70,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 230,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "poliwrath", //Verify
        graphicsLocation: "poliwrath", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Poliwrath,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            Damp,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Abra = new(
        speciesName: "Abra",
        type1: Psychic,
        type2: Psychic,
        baseHP: 25,
        baseAttack: 20,
        baseDefense: 15,
        baseSpAtk: 105,
        baseSpDef: 55,
        baseSpeed: 90,
        evYield: SpAtk,
        evolution: Evolution.Abra,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "abra", //Verify
        graphicsLocation: "abra", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Abra,
        abilities: new Ability[3]
        {
            Synchronize,
            InnerFocus,
            MagicGuard,
        }
    );
    public static readonly SpeciesData Kadabra = new(
        speciesName: "Kadabra",
        type1: Psychic,
        type2: Psychic,
        baseHP: 40,
        baseAttack: 35,
        baseDefense: 30,
        baseSpAtk: 120,
        baseSpDef: 70,
        baseSpeed: 105,
        evYield: 2 * SpAtk,
        evolution: Evolution.Kadabra,
        xpClass: MediumSlow,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "kadabra", //Verify
        graphicsLocation: "kadabra", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Kadabra,
        abilities: new Ability[3]
        {
            Synchronize,
            InnerFocus,
            MagicGuard,
        }
    );
    public static readonly SpeciesData Alakazam = new(
        speciesName: "Alakazam",
        type1: Psychic,
        type2: Psychic,
        baseHP: 55,
        baseAttack: 50,
        baseDefense: 45,
        baseSpAtk: 135,
        baseSpDef: 95,
        baseSpeed: 120,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "alakazam", //Verify
        graphicsLocation: "alakazam", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Alakazam,
        abilities: new Ability[3]
        {
            Synchronize,
            InnerFocus,
            MagicGuard,
        }
    );
    public static readonly SpeciesData Machop = new(
        speciesName: "Machop",
        type1: Fighting,
        type2: Fighting,
        baseHP: 70,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Machop,
        xpClass: MediumSlow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "machop", //Verify
        graphicsLocation: "machop", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Machop,
        abilities: new Ability[3]
        {
            Guts,
            NoGuard,
            Steadfast,
        }
    );
    public static readonly SpeciesData Machoke = new(
        speciesName: "Machoke",
        type1: Fighting,
        type2: Fighting,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 50,
        baseSpDef: 60,
        baseSpeed: 45,
        evYield: 2 * Attack,
        evolution: Evolution.Machoke,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "machoke", //Verify
        graphicsLocation: "machoke", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Machoke,
        abilities: new Ability[3]
        {
            Guts,
            NoGuard,
            Steadfast,
        }
    );
    public static readonly SpeciesData Machamp = new(
        speciesName: "Machamp",
        type1: Fighting,
        type2: Fighting,
        baseHP: 90,
        baseAttack: 130,
        baseDefense: 80,
        baseSpAtk: 65,
        baseSpDef: 85,
        baseSpeed: 55,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 227,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "machamp", //Verify
        graphicsLocation: "machamp", //Verify
        backSpriteHeight: 7,
        gMaxPath: "machamp/gmax",
        gMaxBackHeight: 3,
        pokedexData: Pokedex.Machamp,
        abilities: new Ability[3]
        {
            Guts,
            NoGuard,
            Steadfast,
        }
    );
    public static readonly SpeciesData Bellsprout = new(
        speciesName: "Bellsprout",
        type1: Grass,
        type2: Poison,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 35,
        baseSpAtk: 70,
        baseSpDef: 30,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Bellsprout,
        xpClass: MediumSlow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "bellsprout", //Verify
        graphicsLocation: "bellsprout", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Bellsprout,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        }
    );
    public static readonly SpeciesData Weepinbell = new(
        speciesName: "Weepinbell",
        type1: Grass,
        type2: Poison,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 50,
        baseSpAtk: 85,
        baseSpDef: 45,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.Weepinbell,
        xpClass: MediumSlow,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "weepinbell", //Verify
        graphicsLocation: "weepinbell", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Weepinbell,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        }
    );
    public static readonly SpeciesData Victreebel = new(
        speciesName: "Victreebel",
        type1: Grass,
        type2: Poison,
        baseHP: 80,
        baseAttack: 105,
        baseDefense: 65,
        baseSpAtk: 100,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "victreebel", //Verify
        graphicsLocation: "victreebel", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Victreebel,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Gluttony,
        }
    );
    public static readonly SpeciesData Tentacool = new(
        speciesName: "Tentacool",
        type1: Water,
        type2: Poison,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 35,
        baseSpAtk: 50,
        baseSpDef: 100,
        baseSpeed: 70,
        evYield: SpDef,
        evolution: Evolution.Tentacool,
        xpClass: Slow,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "tentacool", //Verify
        graphicsLocation: "tentacool", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Tentacool,
        abilities: new Ability[3]
        {
            ClearBody,
            LiquidOoze,
            RainDish,
        }
    );
    public static readonly SpeciesData Tentacruel = new(
        speciesName: "Tentacruel",
        type1: Water,
        type2: Poison,
        baseHP: 80,
        baseAttack: 70,
        baseDefense: 65,
        baseSpAtk: 80,
        baseSpDef: 120,
        baseSpeed: 100,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "tentacruel", //Verify
        graphicsLocation: "tentacruel", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Tentacruel,
        abilities: new Ability[3]
        {
            ClearBody,
            LiquidOoze,
            RainDish,
        }
    );
    public static readonly SpeciesData Geodude = new(
        speciesName: "Geodude",
        type1: Rock,
        type2: Ground,
        baseHP: 40,
        baseAttack: 80,
        baseDefense: 100,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 20,
        evYield: Defense,
        evolution: Evolution.Geodude,
        xpClass: MediumSlow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "geodude", //Verify
        graphicsLocation: "geodude", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Geodude,
        abilities: new Ability[3]
        {
            RockHead,
            Sturdy,
            SandVeil,
        }
    );
    public static readonly SpeciesData Graveler = new(
        speciesName: "Graveler",
        type1: Rock,
        type2: Ground,
        baseHP: 55,
        baseAttack: 95,
        baseDefense: 115,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.Graveler,
        xpClass: MediumSlow,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "graveler", //Verify
        graphicsLocation: "graveler", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Graveler,
        abilities: new Ability[3]
        {
            RockHead,
            Sturdy,
            SandVeil,
        }
    );
    public static readonly SpeciesData Golem = new(
        speciesName: "Golem",
        type1: Rock,
        type2: Ground,
        baseHP: 80,
        baseAttack: 120,
        baseDefense: 130,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 223,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "golem", //Verify
        graphicsLocation: "golem", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Golem,
        abilities: new Ability[3]
        {
            RockHead,
            Sturdy,
            SandVeil,
        }
    );
    public static readonly SpeciesData Ponyta = new(
        speciesName: "Ponyta",
        type1: Fire,
        type2: Fire,
        baseHP: 50,
        baseAttack: 85,
        baseDefense: 55,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.Ponyta,
        xpClass: MediumFast,
        xpYield: 82,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "ponyta", //Verify
        graphicsLocation: "ponyta", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Ponyta,
        abilities: new Ability[3]
        {
            RunAway,
            FlashFire,
            FlameBody,
        }
    );
    public static readonly SpeciesData Rapidash = new(
        speciesName: "Rapidash",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 105,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "rapidash", //Verify
        graphicsLocation: "rapidash", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Rapidash,
        abilities: new Ability[3]
        {
            RunAway,
            FlashFire,
            FlameBody,
        }
    );
    public static readonly SpeciesData Slowpoke = new(
        speciesName: "Slowpoke",
        type1: Water,
        type2: Psychic,
        baseHP: 90,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 15,
        evYield: HP,
        evolution: Evolution.Slowpoke,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "slowpoke", //Verify
        graphicsLocation: "slowpoke", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Slowpoke,
        abilities: new Ability[3]
        {
            Oblivious,
            OwnTempo,
            Regenerator,
        }
    );
    public static readonly SpeciesData Slowbro = new(
        speciesName: "Slowbro",
        type1: Water,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 75,
        baseDefense: 110,
        baseSpAtk: 100,
        baseSpDef: 80,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "slowbro", //Verify
        graphicsLocation: "slowbro", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Slowbro,
        abilities: new Ability[3]
        {
            Oblivious,
            OwnTempo,
            Regenerator,
        }
    );
    public static readonly SpeciesData Magnemite = new(
        speciesName: "Magnemite",
        type1: Electric,
        type2: Steel,
        baseHP: 25,
        baseAttack: 35,
        baseDefense: 70,
        baseSpAtk: 95,
        baseSpDef: 55,
        baseSpeed: 45,
        evYield: SpAtk,
        evolution: Evolution.Magnemite,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "magnemite", //Verify
        graphicsLocation: "magnemite", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Magnemite,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Analytic,
        }
    );
    public static readonly SpeciesData Magneton = new(
        speciesName: "Magneton",
        type1: Electric,
        type2: Steel,
        baseHP: 50,
        baseAttack: 60,
        baseDefense: 95,
        baseSpAtk: 120,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 2 * SpAtk,
        evolution: Evolution.Magneton,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "magneton", //Verify
        graphicsLocation: "magneton", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Magneton,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Analytic,
        }
    );
    public static readonly SpeciesData Farfetchd = new(
        speciesName: "Farfetchd",
        type1: Normal,
        type2: Flying,
        baseHP: 52,
        baseAttack: 90,
        baseDefense: 55,
        baseSpAtk: 58,
        baseSpDef: 62,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 132,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "farfetchd", //Verify
        graphicsLocation: "farfetchd", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Farfetchd,
        abilities: new Ability[3]
        {
            KeenEye,
            InnerFocus,
            Defiant,
        }
    );
    public static readonly SpeciesData Doduo = new(
        speciesName: "Doduo",
        type1: Normal,
        type2: Flying,
        baseHP: 35,
        baseAttack: 85,
        baseDefense: 45,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 75,
        evYield: Attack,
        evolution: Evolution.Doduo,
        xpClass: MediumFast,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "doduo", //Verify
        graphicsLocation: "doduo", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Doduo,
        abilities: new Ability[3]
        {
            RunAway,
            EarlyBird,
            TangledFeet,
        }
    );
    public static readonly SpeciesData Dodrio = new(
        speciesName: "Dodrio",
        type1: Normal,
        type2: Flying,
        baseHP: 60,
        baseAttack: 110,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 110,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dodrio", //Verify
        graphicsLocation: "dodrio", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Dodrio,
        abilities: new Ability[3]
        {
            RunAway,
            EarlyBird,
            TangledFeet,
        }
    );
    public static readonly SpeciesData Seel = new(
        speciesName: "Seel",
        type1: Water,
        type2: Water,
        baseHP: 65,
        baseAttack: 45,
        baseDefense: 55,
        baseSpAtk: 45,
        baseSpDef: 70,
        baseSpeed: 45,
        evYield: SpDef,
        evolution: Evolution.Seel,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "seel", //Verify
        graphicsLocation: "seel", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Seel,
        abilities: new Ability[3]
        {
            ThickFat,
            Hydration,
            IceBody,
        }
    );
    public static readonly SpeciesData Dewgong = new(
        speciesName: "Dewgong",
        type1: Water,
        type2: Ice,
        baseHP: 90,
        baseAttack: 70,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 95,
        baseSpeed: 70,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "dewgong", //Verify
        graphicsLocation: "dewgong", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Dewgong,
        abilities: new Ability[3]
        {
            ThickFat,
            Hydration,
            IceBody,
        }
    );
    public static readonly SpeciesData Grimer = new(
        speciesName: "Grimer",
        type1: Poison,
        type2: Poison,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 25,
        evYield: HP,
        evolution: Evolution.Grimer,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "grimer", //Verify
        graphicsLocation: "grimer", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Grimer,
        abilities: new Ability[3]
        {
            Stench,
            StickyHold,
            PoisonTouch,
        }
    );
    public static readonly SpeciesData Muk = new(
        speciesName: "Muk",
        type1: Poison,
        type2: Poison,
        baseHP: 105,
        baseAttack: 105,
        baseDefense: 75,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 50,
        evYield: HP + Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "muk", //Verify
        graphicsLocation: "muk", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Muk,
        abilities: new Ability[3]
        {
            Stench,
            StickyHold,
            PoisonTouch,
        }
    );
    public static readonly SpeciesData Shellder = new(
        speciesName: "Shellder",
        type1: Water,
        type2: Water,
        baseHP: 30,
        baseAttack: 65,
        baseDefense: 100,
        baseSpAtk: 45,
        baseSpDef: 25,
        baseSpeed: 40,
        evYield: Defense,
        evolution: Evolution.Shellder,
        xpClass: Slow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "shellder", //Verify
        graphicsLocation: "shellder", //Verify
        backSpriteHeight: 21,
        pokedexData: Pokedex.Shellder,
        abilities: new Ability[3]
        {
            ShellArmor,
            SkillLink,
            Overcoat,
        }
    );
    public static readonly SpeciesData Cloyster = new(
        speciesName: "Cloyster",
        type1: Water,
        type2: Ice,
        baseHP: 50,
        baseAttack: 95,
        baseDefense: 180,
        baseSpAtk: 85,
        baseSpDef: 45,
        baseSpeed: 70,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "cloyster", //Verify
        graphicsLocation: "cloyster", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Cloyster,
        abilities: new Ability[3]
        {
            ShellArmor,
            SkillLink,
            Overcoat,
        }
    );
    public static readonly SpeciesData Gastly = new(
        speciesName: "Gastly",
        type1: Ghost,
        type2: Poison,
        baseHP: 30,
        baseAttack: 35,
        baseDefense: 30,
        baseSpAtk: 100,
        baseSpDef: 35,
        baseSpeed: 80,
        evYield: SpAtk,
        evolution: Evolution.Gastly,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "gastly", //Verify
        graphicsLocation: "gastly", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Gastly,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Haunter = new(
        speciesName: "Haunter",
        type1: Ghost,
        type2: Poison,
        baseHP: 45,
        baseAttack: 50,
        baseDefense: 45,
        baseSpAtk: 115,
        baseSpDef: 55,
        baseSpeed: 95,
        evYield: 2 * SpAtk,
        evolution: Evolution.Haunter,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "haunter", //Verify
        graphicsLocation: "haunter", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Haunter,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Gengar = new(
        speciesName: "Gengar",
        type1: Ghost,
        type2: Poison,
        baseHP: 60,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 130,
        baseSpDef: 75,
        baseSpeed: 110,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gengar", //Verify
        graphicsLocation: "gengar", //Verify
        backSpriteHeight: 8,
        gMaxPath: "gengar/gmax",
        gMaxBackHeight: 6,
        pokedexData: Pokedex.Gengar,
        abilities: new Ability[3]
        {
            CursedBody,
            CursedBody,
            CursedBody,
        }
    );
    public static readonly SpeciesData Onix = new(
        speciesName: "Onix",
        type1: Rock,
        type2: Ground,
        baseHP: 35,
        baseAttack: 45,
        baseDefense: 160,
        baseSpAtk: 30,
        baseSpDef: 45,
        baseSpeed: 70,
        evYield: Defense,
        evolution: Evolution.Onix,
        xpClass: MediumFast,
        xpYield: 77,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "onix", //Verify
        graphicsLocation: "onix", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Onix,
        abilities: new Ability[3]
        {
            RockHead,
            Sturdy,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Drowzee = new(
        speciesName: "Drowzee",
        type1: Psychic,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 48,
        baseDefense: 45,
        baseSpAtk: 43,
        baseSpDef: 90,
        baseSpeed: 42,
        evYield: SpDef,
        evolution: Evolution.Drowzee,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "drowzee", //Verify
        graphicsLocation: "drowzee", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Drowzee,
        abilities: new Ability[3]
        {
            Insomnia,
            Forewarn,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Hypno = new(
        speciesName: "Hypno",
        type1: Psychic,
        type2: Psychic,
        baseHP: 85,
        baseAttack: 73,
        baseDefense: 70,
        baseSpAtk: 73,
        baseSpDef: 115,
        baseSpeed: 67,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "hypno", //Verify
        graphicsLocation: "hypno", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Hypno,
        abilities: new Ability[3]
        {
            Insomnia,
            Forewarn,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Krabby = new(
        speciesName: "Krabby",
        type1: Water,
        type2: Water,
        baseHP: 30,
        baseAttack: 105,
        baseDefense: 90,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Krabby,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "krabby", //Verify
        graphicsLocation: "krabby", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Krabby,
        abilities: new Ability[3]
        {
            HyperCutter,
            ShellArmor,
            SheerForce,
        }
    );
    public static readonly SpeciesData Kingler = new(
        speciesName: "Kingler",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 130,
        baseDefense: 115,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 75,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "kingler", //Verify
        graphicsLocation: "kingler", //Verify
        backSpriteHeight: 5,
        gMaxPath: "kingler/gmax",
        gMaxBackHeight: 5,
        pokedexData: Pokedex.Kingler,
        abilities: new Ability[3]
        {
            HyperCutter,
            ShellArmor,
            SheerForce,
        }
    );
    public static readonly SpeciesData Voltorb = new(
        speciesName: "Voltorb",
        type1: Electric,
        type2: Electric,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 100,
        evYield: Speed,
        evolution: Evolution.Voltorb,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "voltorb", //Verify
        graphicsLocation: "voltorb", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Voltorb,
        abilities: new Ability[3]
        {
            Soundproof,
            Static,
            Aftermath,
        }
    );
    public static readonly SpeciesData Electrode = new(
        speciesName: "Electrode",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 150,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "electrode", //Verify
        graphicsLocation: "electrode", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Electrode,
        abilities: new Ability[3]
        {
            Soundproof,
            Static,
            Aftermath,
        }
    );
    public static readonly SpeciesData Exeggcute = new(
        speciesName: "Exeggcute",
        type1: Grass,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 40,
        baseDefense: 80,
        baseSpAtk: 60,
        baseSpDef: 45,
        baseSpeed: 40,
        evYield: Defense,
        evolution: Evolution.Exeggcute,
        xpClass: Slow,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "exeggcute", //Verify
        graphicsLocation: "exeggcute", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Exeggcute,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Harvest,
        }
    );
    public static readonly SpeciesData Exeggutor = new(
        speciesName: "Exeggutor",
        type1: Grass,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 95,
        baseDefense: 85,
        baseSpAtk: 125,
        baseSpDef: 75,
        baseSpeed: 55,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "exeggutor", //Verify
        graphicsLocation: "exeggutor", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Exeggutor,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Harvest,
        }
    );
    public static readonly SpeciesData Cubone = new(
        speciesName: "Cubone",
        type1: Ground,
        type2: Ground,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 95,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 35,
        evYield: Defense,
        evolution: Evolution.Cubone,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "cubone", //Verify
        graphicsLocation: "cubone", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Cubone,
        abilities: new Ability[3]
        {
            RockHead,
            LightningRod,
            BattleArmor,
        }
    );
    public static readonly SpeciesData Marowak = new(
        speciesName: "Marowak",
        type1: Ground,
        type2: Ground,
        baseHP: 60,
        baseAttack: 80,
        baseDefense: 110,
        baseSpAtk: 50,
        baseSpDef: 80,
        baseSpeed: 45,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "marowak", //Verify
        graphicsLocation: "marowak", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Marowak,
        abilities: new Ability[3]
        {
            RockHead,
            LightningRod,
            BattleArmor,
        }
    );
    public static readonly SpeciesData Hitmonlee = new(
        speciesName: "Hitmonlee",
        type1: Fighting,
        type2: Fighting,
        baseHP: 50,
        baseAttack: 120,
        baseDefense: 53,
        baseSpAtk: 35,
        baseSpDef: 110,
        baseSpeed: 87,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "hitmonlee", //Verify
        graphicsLocation: "hitmonlee", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Hitmonlee,
        abilities: new Ability[3]
        {
            Limber,
            Reckless,
            Unburden,
        }
    );
    public static readonly SpeciesData Hitmonchan = new(
        speciesName: "Hitmonchan",
        type1: Fighting,
        type2: Fighting,
        baseHP: 50,
        baseAttack: 105,
        baseDefense: 79,
        baseSpAtk: 35,
        baseSpDef: 110,
        baseSpeed: 76,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "hitmonchan", //Verify
        graphicsLocation: "hitmonchan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Hitmonchan,
        abilities: new Ability[3]
        {
            KeenEye,
            IronFist,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Lickitung = new(
        speciesName: "Lickitung",
        type1: Normal,
        type2: Normal,
        baseHP: 90,
        baseAttack: 55,
        baseDefense: 75,
        baseSpAtk: 60,
        baseSpDef: 75,
        baseSpeed: 30,
        evYield: 2 * HP,
        evolution: Evolution.Lickitung,
        xpClass: MediumFast,
        xpYield: 77,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "lickitung", //Verify
        graphicsLocation: "lickitung", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Lickitung,
        abilities: new Ability[3]
        {
            OwnTempo,
            Oblivious,
            CloudNine,
        }
    );
    public static readonly SpeciesData Koffing = new(
        speciesName: "Koffing",
        type1: Poison,
        type2: Poison,
        baseHP: 40,
        baseAttack: 65,
        baseDefense: 95,
        baseSpAtk: 60,
        baseSpDef: 45,
        baseSpeed: 35,
        evYield: Defense,
        evolution: Evolution.Koffing,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "koffing", //Verify
        graphicsLocation: "koffing", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Koffing,
        abilities: new Ability[3]
        {
            Levitate,
            NeutralizingGas,
            Stench,
        }
    );
    public static readonly SpeciesData Weezing = new(
        speciesName: "Weezing",
        type1: Poison,
        type2: Poison,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 120,
        baseSpAtk: 85,
        baseSpDef: 70,
        baseSpeed: 60,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "weezing", //Verify
        graphicsLocation: "weezing", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Weezing,
        abilities: new Ability[3]
        {
            Levitate,
            NeutralizingGas,
            Stench,
        }
    );
    public static readonly SpeciesData Rhyhorn = new(
        speciesName: "Rhyhorn",
        type1: Ground,
        type2: Rock,
        baseHP: 80,
        baseAttack: 85,
        baseDefense: 95,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 25,
        evYield: Defense,
        evolution: Evolution.Rhyhorn,
        xpClass: Slow,
        xpYield: 69,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "rhyhorn", //Verify
        graphicsLocation: "rhyhorn", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Rhyhorn,
        abilities: new Ability[3]
        {
            LightningRod,
            RockHead,
            Reckless,
        }
    );
    public static readonly SpeciesData Rhydon = new(
        speciesName: "Rhydon",
        type1: Ground,
        type2: Rock,
        baseHP: 105,
        baseAttack: 130,
        baseDefense: 120,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 40,
        evYield: 2 * Attack,
        evolution: Evolution.Rhydon,
        xpClass: Slow,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "rhydon", //Verify
        graphicsLocation: "rhydon", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Rhydon,
        abilities: new Ability[3]
        {
            LightningRod,
            RockHead,
            Reckless,
        }
    );
    public static readonly SpeciesData Chansey = new(
        speciesName: "Chansey",
        type1: Normal,
        type2: Normal,
        baseHP: 250,
        baseAttack: 5,
        baseDefense: 5,
        baseSpAtk: 35,
        baseSpDef: 105,
        baseSpeed: 50,
        evYield: 2 * HP,
        evolution: Evolution.Chansey,
        xpClass: Fast,
        xpYield: 395,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 40,
        catchRate: 30,
        baseFriendship: 140,
        cryLocation: "chansey", //Verify
        graphicsLocation: "chansey", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Chansey,
        abilities: new Ability[3]
        {
            NaturalCure,
            SereneGrace,
            Healer,
        }
    );
    public static readonly SpeciesData Tangela = new(
        speciesName: "Tangela",
        type1: Grass,
        type2: Grass,
        baseHP: 65,
        baseAttack: 55,
        baseDefense: 115,
        baseSpAtk: 100,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: Defense,
        evolution: Evolution.Tangela,
        xpClass: MediumFast,
        xpYield: 87,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tangela", //Verify
        graphicsLocation: "tangela", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Tangela,
        abilities: new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Regenerator,
        }
    );
    public static readonly SpeciesData Kangaskhan = new(
        speciesName: "Kangaskhan",
        type1: Normal,
        type2: Normal,
        baseHP: 105,
        baseAttack: 95,
        baseDefense: 80,
        baseSpAtk: 40,
        baseSpDef: 80,
        baseSpeed: 90,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kangaskhan", //Verify
        graphicsLocation: "kangaskhan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kangaskhan,
        abilities: new Ability[3]
        {
            EarlyBird,
            Scrappy,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Horsea = new(
        speciesName: "Horsea",
        type1: Water,
        type2: Water,
        baseHP: 30,
        baseAttack: 40,
        baseDefense: 70,
        baseSpAtk: 70,
        baseSpDef: 25,
        baseSpeed: 60,
        evYield: SpAtk,
        evolution: Evolution.Horsea,
        xpClass: MediumFast,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "horsea", //Verify
        graphicsLocation: "horsea", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Horsea,
        abilities: new Ability[3]
        {
            SwiftSwim,
            Sniper,
            Damp,
        }
    );
    public static readonly SpeciesData Seadra = new(
        speciesName: "Seadra",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 65,
        baseDefense: 95,
        baseSpAtk: 95,
        baseSpDef: 45,
        baseSpeed: 85,
        evYield: Defense + SpAtk,
        evolution: Evolution.Seadra,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "seadra", //Verify
        graphicsLocation: "seadra", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Seadra,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Sniper,
            Damp,
        }
    );
    public static readonly SpeciesData Goldeen = new(
        speciesName: "Goldeen",
        type1: Water,
        type2: Water,
        baseHP: 45,
        baseAttack: 67,
        baseDefense: 60,
        baseSpAtk: 35,
        baseSpDef: 50,
        baseSpeed: 63,
        evYield: Attack,
        evolution: Evolution.Goldeen,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "goldeen", //Verify
        graphicsLocation: "goldeen", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Goldeen,
        abilities: new Ability[3]
        {
            SwiftSwim,
            WaterVeil,
            LightningRod,
        }
    );
    public static readonly SpeciesData Seaking = new(
        speciesName: "Seaking",
        type1: Water,
        type2: Water,
        baseHP: 80,
        baseAttack: 92,
        baseDefense: 65,
        baseSpAtk: 65,
        baseSpDef: 80,
        baseSpeed: 68,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "seaking", //Verify
        graphicsLocation: "seaking", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Seaking,
        abilities: new Ability[3]
        {
            SwiftSwim,
            WaterVeil,
            LightningRod,
        }
    );
    public static readonly SpeciesData Staryu = new(
        speciesName: "Staryu",
        type1: Water,
        type2: Water,
        baseHP: 30,
        baseAttack: 45,
        baseDefense: 55,
        baseSpAtk: 70,
        baseSpDef: 55,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Staryu,
        xpClass: Slow,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "staryu", //Verify
        graphicsLocation: "staryu", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Staryu,
        abilities: new Ability[3]
        {
            Illuminate,
            NaturalCure,
            Analytic,
        }
    );
    public static readonly SpeciesData Starmie = new(
        speciesName: "Starmie",
        type1: Water,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 75,
        baseDefense: 85,
        baseSpAtk: 100,
        baseSpDef: 85,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 182,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "starmie", //Verify
        graphicsLocation: "starmie", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Starmie,
        abilities: new Ability[3]
        {
            Illuminate,
            NaturalCure,
            Analytic,
        }
    );
    public static readonly SpeciesData MrMime = new(
        speciesName: "Mr. Mime",
        type1: Psychic,
        type2: Fairy,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 65,
        baseSpAtk: 100,
        baseSpDef: 120,
        baseSpeed: 90,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mr_mime", //Verify
        graphicsLocation: "mr_mime", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.MrMime,
        abilities: new Ability[3]
        {
            Soundproof,
            Filter,
            Technician,
        }
    );
    public static readonly SpeciesData Scyther = new(
        speciesName: "Scyther",
        type1: Bug,
        type2: Flying,
        baseHP: 70,
        baseAttack: 110,
        baseDefense: 80,
        baseSpAtk: 55,
        baseSpDef: 80,
        baseSpeed: 105,
        evYield: Attack,
        evolution: Evolution.Scyther,
        xpClass: MediumFast,
        xpYield: 100,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "scyther", //Verify
        graphicsLocation: "scyther", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Scyther,
        abilities: new Ability[3]
        {
            Swarm,
            Technician,
            Steadfast,
        }
    );
    public static readonly SpeciesData Jynx = new(
        speciesName: "Jynx",
        type1: Ice,
        type2: Psychic,
        baseHP: 65,
        baseAttack: 50,
        baseDefense: 35,
        baseSpAtk: 115,
        baseSpDef: 95,
        baseSpeed: 95,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "jynx", //Verify
        graphicsLocation: "jynx", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Jynx,
        abilities: new Ability[3]
        {
            Oblivious,
            Forewarn,
            DrySkin,
        }
    );
    public static readonly SpeciesData Electabuzz = new(
        speciesName: "Electabuzz",
        type1: Electric,
        type2: Electric,
        baseHP: 65,
        baseAttack: 83,
        baseDefense: 57,
        baseSpAtk: 95,
        baseSpDef: 85,
        baseSpeed: 105,
        evYield: 2 * Speed,
        evolution: Evolution.Electabuzz,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "electabuzz", //Verify
        graphicsLocation: "electabuzz", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Electabuzz,
        abilities: new Ability[3]
        {
            Static,
            Static,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Magmar = new(
        speciesName: "Magmar",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 95,
        baseDefense: 57,
        baseSpAtk: 100,
        baseSpDef: 85,
        baseSpeed: 93,
        evYield: 2 * SpAtk,
        evolution: Evolution.Magmar,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "magmar", //Verify
        graphicsLocation: "magmar", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Magmar,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Pinsir = new(
        speciesName: "Pinsir",
        type1: Bug,
        type2: Bug,
        baseHP: 65,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 55,
        baseSpDef: 70,
        baseSpeed: 85,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "pinsir", //Verify
        graphicsLocation: "pinsir", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Pinsir,
        abilities: new Ability[3]
        {
            HyperCutter,
            MoldBreaker,
            Moxie,
        }
    );
    public static readonly SpeciesData Tauros = new(
        speciesName: "Tauros",
        type1: Normal,
        type2: Normal,
        baseHP: 75,
        baseAttack: 100,
        baseDefense: 95,
        baseSpAtk: 40,
        baseSpDef: 70,
        baseSpeed: 110,
        evYield: Attack + Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tauros", //Verify
        graphicsLocation: "tauros", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Tauros,
        abilities: new Ability[3]
        {
            Intimidate,
            AngerPoint,
            SheerForce,
        }
    );
    public static readonly SpeciesData Magikarp = new(
        speciesName: "Magikarp",
        type1: Water,
        type2: Water,
        baseHP: 20,
        baseAttack: 10,
        baseDefense: 55,
        baseSpAtk: 15,
        baseSpDef: 20,
        baseSpeed: 80,
        evYield: Speed,
        evolution: Evolution.Magikarp,
        xpClass: Slow,
        xpYield: 40,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 5,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "magikarp", //Verify
        graphicsLocation: "magikarp", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Magikarp,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            Rattled,
        }
    );
    public static readonly SpeciesData Gyarados = new(
        speciesName: "Gyarados",
        type1: Water,
        type2: Flying,
        baseHP: 95,
        baseAttack: 125,
        baseDefense: 79,
        baseSpAtk: 60,
        baseSpDef: 100,
        baseSpeed: 81,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 5,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gyarados", //Verify
        graphicsLocation: "gyarados", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Gyarados,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Moxie,
        }
    );
    public static readonly SpeciesData Lapras = new(
        speciesName: "Lapras",
        type1: Water,
        type2: Ice,
        baseHP: 130,
        baseAttack: 85,
        baseDefense: 80,
        baseSpAtk: 85,
        baseSpDef: 95,
        baseSpeed: 60,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 187,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "lapras", //Verify
        graphicsLocation: "lapras", //Verify
        backSpriteHeight: 3,
        gMaxPath: "lapras/gmax",
        gMaxBackHeight: 1,
        pokedexData: Pokedex.Lapras,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            ShellArmor,
            Hydration,
        }
    );
    public static readonly SpeciesData Ditto = new(
        speciesName: "Ditto",
        type1: Normal,
        type2: Normal,
        baseHP: 48,
        baseAttack: 48,
        baseDefense: 48,
        baseSpAtk: 48,
        baseSpDef: 48,
        baseSpeed: 48,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 101,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Ditto,
        eggGroup2: EggGroup.Ditto,
        eggCycles: 20,
        catchRate: 35,
        baseFriendship: 70,
        cryLocation: "ditto", //Verify
        graphicsLocation: "ditto", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Ditto,
        abilities: new Ability[3]
        {
            Limber,
            Limber,
            Imposter,
        }
    );
    public static readonly SpeciesData Eevee = new(
        speciesName: "Eevee",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 55,
        baseDefense: 50,
        baseSpAtk: 45,
        baseSpDef: 65,
        baseSpeed: 55,
        evYield: SpDef,
        evolution: Evolution.Eevee,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "eevee", //Verify
        graphicsLocation: "eevee", //Verify
        backSpriteHeight: 10,
        gMaxPath: "eevee/gmax",
        gMaxBackHeight: 7,
        pokedexData: Pokedex.Eevee,
        abilities: new Ability[3]
        {
            RunAway,
            Adaptability,
            Anticipation,
        }
    );
    public static readonly SpeciesData Vaporeon = new(
        speciesName: "Vaporeon",
        type1: Water,
        type2: Water,
        baseHP: 130,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 110,
        baseSpDef: 95,
        baseSpeed: 65,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vaporeon", //Verify
        graphicsLocation: "vaporeon", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Vaporeon,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            WaterAbsorb,
            Hydration,
        }
    );
    public static readonly SpeciesData Jolteon = new(
        speciesName: "Jolteon",
        type1: Electric,
        type2: Electric,
        baseHP: 65,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 110,
        baseSpDef: 95,
        baseSpeed: 130,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "jolteon", //Verify
        graphicsLocation: "jolteon", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Jolteon,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            VoltAbsorb,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Flareon = new(
        speciesName: "Flareon",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 130,
        baseDefense: 60,
        baseSpAtk: 95,
        baseSpDef: 110,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "flareon", //Verify
        graphicsLocation: "flareon", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Flareon,
        abilities: new Ability[3]
        {
            FlashFire,
            FlashFire,
            Guts,
        }
    );
    public static readonly SpeciesData Porygon = new(
        speciesName: "Porygon",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 70,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 40,
        evYield: SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 79,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "porygon", //Verify
        graphicsLocation: "porygon", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Porygon,
        abilities: new Ability[3]
        {
            Trace,
            Download,
            Analytic,
        }
    );
    public static readonly SpeciesData Omanyte = new(
        speciesName: "Omanyte",
        type1: Rock,
        type2: Water,
        baseHP: 35,
        baseAttack: 40,
        baseDefense: 100,
        baseSpAtk: 90,
        baseSpDef: 55,
        baseSpeed: 35,
        evYield: Defense,
        evolution: Evolution.Omanyte,
        xpClass: MediumFast,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "omanyte", //Verify
        graphicsLocation: "omanyte", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Omanyte,
        abilities: new Ability[3]
        {
            SwiftSwim,
            ShellArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Omastar = new(
        speciesName: "Omastar",
        type1: Rock,
        type2: Water,
        baseHP: 70,
        baseAttack: 60,
        baseDefense: 125,
        baseSpAtk: 115,
        baseSpDef: 70,
        baseSpeed: 55,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "omastar", //Verify
        graphicsLocation: "omastar", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Omastar,
        abilities: new Ability[3]
        {
            SwiftSwim,
            ShellArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Kabuto = new(
        speciesName: "Kabuto",
        type1: Rock,
        type2: Water,
        baseHP: 30,
        baseAttack: 80,
        baseDefense: 90,
        baseSpAtk: 55,
        baseSpDef: 45,
        baseSpeed: 55,
        evYield: Defense,
        evolution: Evolution.Kabuto,
        xpClass: MediumFast,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kabuto", //Verify
        graphicsLocation: "kabuto", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Kabuto,
        abilities: new Ability[3]
        {
            SwiftSwim,
            BattleArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Kabutops = new(
        speciesName: "Kabutops",
        type1: Rock,
        type2: Water,
        baseHP: 60,
        baseAttack: 115,
        baseDefense: 105,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 80,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kabutops", //Verify
        graphicsLocation: "kabutops", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kabutops,
        abilities: new Ability[3]
        {
            SwiftSwim,
            BattleArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Aerodactyl = new(
        speciesName: "Aerodactyl",
        type1: Rock,
        type2: Flying,
        baseHP: 80,
        baseAttack: 105,
        baseDefense: 65,
        baseSpAtk: 60,
        baseSpDef: 75,
        baseSpeed: 130,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "aerodactyl", //Verify
        graphicsLocation: "aerodactyl", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Aerodactyl,
        abilities: new Ability[3]
        {
            RockHead,
            Pressure,
            Unnerve,
        }
    );
    public static readonly SpeciesData Snorlax = new(
        speciesName: "Snorlax",
        type1: Normal,
        type2: Normal,
        baseHP: 160,
        baseAttack: 110,
        baseDefense: 65,
        baseSpAtk: 65,
        baseSpDef: 110,
        baseSpeed: 30,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 40,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "snorlax", //Verify
        graphicsLocation: "snorlax", //Verify
        backSpriteHeight: 13,
        gMaxPath: "snorlax/gmax",
        gMaxBackHeight: 5,
        pokedexData: Pokedex.Snorlax,
        abilities: new Ability[3]
        {
            Immunity,
            ThickFat,
            Gluttony,
        }
    );
    public static readonly SpeciesData Articuno = new(
        speciesName: "Articuno",
        type1: Ice,
        type2: Flying,
        baseHP: 90,
        baseAttack: 85,
        baseDefense: 100,
        baseSpAtk: 95,
        baseSpDef: 125,
        baseSpeed: 85,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "articuno", //Verify
        graphicsLocation: "articuno", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Articuno,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            SnowCloak,
        }
    );
    public static readonly SpeciesData Zapdos = new(
        speciesName: "Zapdos",
        type1: Electric,
        type2: Flying,
        baseHP: 90,
        baseAttack: 90,
        baseDefense: 85,
        baseSpAtk: 125,
        baseSpDef: 90,
        baseSpeed: 100,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "zapdos", //Verify
        graphicsLocation: "zapdos", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Zapdos,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Static,
        }
    );
    public static readonly SpeciesData Moltres = new(
        speciesName: "Moltres",
        type1: Fire,
        type2: Flying,
        baseHP: 90,
        baseAttack: 100,
        baseDefense: 90,
        baseSpAtk: 125,
        baseSpDef: 85,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "moltres", //Verify
        graphicsLocation: "moltres", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Moltres,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            FlameBody,
        }
    );
    public static readonly SpeciesData Dratini = new(
        speciesName: "Dratini",
        type1: Dragon,
        type2: Dragon,
        baseHP: 41,
        baseAttack: 64,
        baseDefense: 45,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Dratini,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "dratini", //Verify
        graphicsLocation: "dratini", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Dratini,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            MarvelScale,
        }
    );
    public static readonly SpeciesData Dragonair = new(
        speciesName: "Dragonair",
        type1: Dragon,
        type2: Dragon,
        baseHP: 61,
        baseAttack: 84,
        baseDefense: 65,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.Dragonair,
        xpClass: Slow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "dragonair", //Verify
        graphicsLocation: "dragonair", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Dragonair,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            MarvelScale,
        }
    );
    public static readonly SpeciesData Dragonite = new(
        speciesName: "Dragonite",
        type1: Dragon,
        type2: Flying,
        baseHP: 91,
        baseAttack: 134,
        baseDefense: 95,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "dragonite", //Verify
        graphicsLocation: "dragonite", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Dragonite,
        abilities: new Ability[3]
        {
            InnerFocus,
            InnerFocus,
            Multiscale,
        }
    );
    public static readonly SpeciesData Mewtwo = new(
        speciesName: "Mewtwo",
        type1: Psychic,
        type2: Psychic,
        baseHP: 106,
        baseAttack: 110,
        baseDefense: 90,
        baseSpAtk: 154,
        baseSpDef: 90,
        baseSpeed: 130,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "mewtwo", //Verify
        graphicsLocation: "mewtwo", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Mewtwo,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Unnerve,
        }
    );
    public static readonly SpeciesData Mew = new(
        speciesName: "Mew",
        type1: Psychic,
        type2: Psychic,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 100,
        cryLocation: "mew", //Verify
        graphicsLocation: "mew", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Mew,
        abilities: new Ability[3]
        {
            Synchronize,
            Synchronize,
            Synchronize,
        }
    );
    public static readonly SpeciesData Chikorita = new(
        speciesName: "Chikorita",
        type1: Grass,
        type2: Grass,
        baseHP: 45,
        baseAttack: 49,
        baseDefense: 65,
        baseSpAtk: 49,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: SpDef,
        evolution: Evolution.Chikorita,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chikorita", //Verify
        graphicsLocation: "chikorita", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Chikorita,
        abilities: new Ability[3]
    {
            Overgrow,
            Overgrow,
            LeafGuard,
    }
    );
    public static readonly SpeciesData Bayleef = new(
        speciesName: "Bayleef",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 62,
        baseDefense: 80,
        baseSpAtk: 63,
        baseSpDef: 80,
        baseSpeed: 60,
        evYield: Defense + SpDef,
        evolution: Evolution.Bayleef,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "bayleef", //Verify
        graphicsLocation: "bayleef", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Bayleef,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LeafGuard,
        }
    );
    public static readonly SpeciesData Meganium = new(
        speciesName: "Meganium",
        type1: Grass,
        type2: Grass,
        baseHP: 80,
        baseAttack: 82,
        baseDefense: 100,
        baseSpAtk: 83,
        baseSpDef: 100,
        baseSpeed: 80,
        evYield: Defense + 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 236,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "meganium", //Verify
        graphicsLocation: "meganium", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Meganium,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LeafGuard,
        }
    );
    public static readonly SpeciesData Cyndaquil = new(
        speciesName: "Cyndaquil",
        type1: Fire,
        type2: Fire,
        baseHP: 39,
        baseAttack: 52,
        baseDefense: 43,
        baseSpAtk: 60,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Cyndaquil,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "cyndaquil", //Verify
        graphicsLocation: "cyndaquil", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Cyndaquil,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            FlashFire,
        }
    );
    public static readonly SpeciesData Quilava = new(
        speciesName: "Quilava",
        type1: Fire,
        type2: Fire,
        baseHP: 58,
        baseAttack: 64,
        baseDefense: 58,
        baseSpAtk: 80,
        baseSpDef: 65,
        baseSpeed: 80,
        evYield: Speed + SpAtk,
        evolution: Evolution.Quilava,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "quilava", //Verify
        graphicsLocation: "quilava", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Quilava,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            FlashFire,
        }
    );
    public static readonly SpeciesData Typhlosion = new(
        speciesName: "Typhlosion",
        type1: Fire,
        type2: Fire,
        baseHP: 78,
        baseAttack: 84,
        baseDefense: 78,
        baseSpAtk: 109,
        baseSpDef: 85,
        baseSpeed: 100,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 240,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "typhlosion", //Verify
        graphicsLocation: "typhlosion", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Typhlosion,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            FlashFire,
        }
    );
    public static readonly SpeciesData Totodile = new(
        speciesName: "Totodile",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 64,
        baseSpAtk: 44,
        baseSpDef: 48,
        baseSpeed: 43,
        evYield: Attack,
        evolution: Evolution.Totodile,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "totodile", //Verify
        graphicsLocation: "totodile", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Totodile,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            SheerForce,
        }
    );
    public static readonly SpeciesData Croconaw = new(
        speciesName: "Croconaw",
        type1: Water,
        type2: Water,
        baseHP: 65,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 59,
        baseSpDef: 63,
        baseSpeed: 58,
        evYield: Attack + Defense,
        evolution: Evolution.Croconaw,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "croconaw", //Verify
        graphicsLocation: "croconaw", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Croconaw,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            SheerForce,
        }
    );
    public static readonly SpeciesData Feraligatr = new(
        speciesName: "Feraligatr",
        type1: Water,
        type2: Water,
        baseHP: 85,
        baseAttack: 105,
        baseDefense: 100,
        baseSpAtk: 79,
        baseSpDef: 83,
        baseSpeed: 78,
        evYield: 2 * Attack + Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "feraligatr", //Verify
        graphicsLocation: "feraligatr", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Feraligatr,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            SheerForce,
        }
    );
    public static readonly SpeciesData Sentret = new(
        speciesName: "Sentret",
        type1: Normal,
        type2: Normal,
        baseHP: 35,
        baseAttack: 46,
        baseDefense: 34,
        baseSpAtk: 35,
        baseSpDef: 45,
        baseSpeed: 20,
        evYield: Attack,
        evolution: Evolution.Sentret,
        xpClass: MediumFast,
        xpYield: 43,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "sentret", //Verify
        graphicsLocation: "sentret", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Sentret,
        abilities: new Ability[3]
        {
            RunAway,
            KeenEye,
            Frisk,
        }
    );
    public static readonly SpeciesData Furret = new(
        speciesName: "Furret",
        type1: Normal,
        type2: Normal,
        baseHP: 85,
        baseAttack: 76,
        baseDefense: 64,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "furret", //Verify
        graphicsLocation: "furret", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Furret,
        abilities: new Ability[3]
        {
            RunAway,
            KeenEye,
            Frisk,
        }
    );
    public static readonly SpeciesData Hoothoot = new(
        speciesName: "Hoothoot",
        type1: Normal,
        type2: Flying,
        baseHP: 60,
        baseAttack: 30,
        baseDefense: 30,
        baseSpAtk: 36,
        baseSpDef: 56,
        baseSpeed: 50,
        evYield: HP,
        evolution: Evolution.Hoothoot,
        xpClass: MediumFast,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "hoothoot", //Verify
        graphicsLocation: "hoothoot", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Hoothoot,
        abilities: new Ability[3]
        {
            Insomnia,
            KeenEye,
            TintedLens,
        }
    );
    public static readonly SpeciesData Noctowl = new(
        speciesName: "Noctowl",
        type1: Normal,
        type2: Flying,
        baseHP: 100,
        baseAttack: 50,
        baseDefense: 50,
        baseSpAtk: 86,
        baseSpDef: 96,
        baseSpeed: 70,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "noctowl", //Verify
        graphicsLocation: "noctowl", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Noctowl,
        abilities: new Ability[3]
        {
            Insomnia,
            KeenEye,
            TintedLens,
        }
    );
    public static readonly SpeciesData Ledyba = new(
        speciesName: "Ledyba",
        type1: Bug,
        type2: Flying,
        baseHP: 40,
        baseAttack: 20,
        baseDefense: 30,
        baseSpAtk: 40,
        baseSpDef: 80,
        baseSpeed: 55,
        evYield: SpDef,
        evolution: Evolution.Ledyba,
        xpClass: Fast,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "ledyba", //Verify
        graphicsLocation: "ledyba", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Ledyba,
        abilities: new Ability[3]
        {
            Swarm,
            EarlyBird,
            Rattled,
        }
    );
    public static readonly SpeciesData Ledian = new(
        speciesName: "Ledian",
        type1: Bug,
        type2: Flying,
        baseHP: 55,
        baseAttack: 35,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 110,
        baseSpeed: 85,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "ledian", //Verify
        graphicsLocation: "ledian", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Ledian,
        abilities: new Ability[3]
        {
            Swarm,
            EarlyBird,
            IronFist,
        }
    );
    public static readonly SpeciesData Spinarak = new(
        speciesName: "Spinarak",
        type1: Bug,
        type2: Poison,
        baseHP: 40,
        baseAttack: 60,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 30,
        evYield: Attack,
        evolution: Evolution.Spinarak,
        xpClass: Fast,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "spinarak", //Verify
        graphicsLocation: "spinarak", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Spinarak,
        abilities: new Ability[3]
        {
            Swarm,
            Insomnia,
            Sniper,
        }
    );
    public static readonly SpeciesData Ariados = new(
        speciesName: "Ariados",
        type1: Bug,
        type2: Poison,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 40,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "ariados", //Verify
        graphicsLocation: "ariados", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Ariados,
        abilities: new Ability[3]
        {
            Swarm,
            Insomnia,
            Sniper,
        }
    );
    public static readonly SpeciesData Crobat = new(
        speciesName: "Crobat",
        type1: Poison,
        type2: Flying,
        baseHP: 85,
        baseAttack: 90,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 130,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "crobat", //Verify
        graphicsLocation: "crobat", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Crobat,
        abilities: new Ability[3]
        {
            InnerFocus,
            InnerFocus,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Chinchou = new(
        speciesName: "Chinchou",
        type1: Water,
        type2: Electric,
        baseHP: 75,
        baseAttack: 38,
        baseDefense: 38,
        baseSpAtk: 56,
        baseSpDef: 56,
        baseSpeed: 67,
        evYield: HP,
        evolution: Evolution.Chinchou,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "chinchou", //Verify
        graphicsLocation: "chinchou", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Chinchou,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            Illuminate,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Lanturn = new(
        speciesName: "Lanturn",
        type1: Water,
        type2: Electric,
        baseHP: 125,
        baseAttack: 58,
        baseDefense: 58,
        baseSpAtk: 76,
        baseSpDef: 76,
        baseSpeed: 67,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "lanturn", //Verify
        graphicsLocation: "lanturn", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Lanturn,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            Illuminate,
            WaterAbsorb,
        }
    );

    public static readonly SpeciesData Pichu = Pichu(false);

    public static readonly SpeciesData Cleffa = new(
        speciesName: "Cleffa",
        type1: Fairy,
        type2: Fairy,
        baseHP: 50,
        baseAttack: 25,
        baseDefense: 28,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 15,
        evYield: SpDef,
        evolution: Evolution.Cleffa,
        xpClass: Fast,
        xpYield: 44,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 150,
        baseFriendship: 140,
        cryLocation: "cleffa", //Verify
        graphicsLocation: "cleffa", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Cleffa,
        abilities: new Ability[3]
        {
            CuteCharm,
            MagicGuard,
            FriendGuard,
        }
    );
    public static readonly SpeciesData Igglybuff = new(
        speciesName: "Igglybuff",
        type1: Normal,
        type2: Fairy,
        baseHP: 90,
        baseAttack: 30,
        baseDefense: 15,
        baseSpAtk: 40,
        baseSpDef: 20,
        baseSpeed: 15,
        evYield: HP,
        evolution: Evolution.Igglybuff,
        xpClass: Fast,
        xpYield: 42,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 170,
        baseFriendship: 70,
        cryLocation: "igglybuff", //Verify
        graphicsLocation: "igglybuff", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Igglybuff,
        abilities: new Ability[3]
        {
            CuteCharm,
            Competitive,
            FriendGuard,
        }
    );
    public static readonly SpeciesData Togepi = new(
        speciesName: "Togepi",
        type1: Fairy,
        type2: Fairy,
        baseHP: 35,
        baseAttack: 20,
        baseDefense: 65,
        baseSpAtk: 40,
        baseSpDef: 65,
        baseSpeed: 20,
        evYield: SpDef,
        evolution: Evolution.Togepi,
        xpClass: Fast,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "togepi", //Verify
        graphicsLocation: "togepi", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Togepi,
        abilities: new Ability[3]
        {
            Hustle,
            SereneGrace,
            SuperLuck,
        }
    );
    public static readonly SpeciesData Togetic = new(
        speciesName: "Togetic",
        type1: Fairy,
        type2: Flying,
        baseHP: 55,
        baseAttack: 40,
        baseDefense: 85,
        baseSpAtk: 80,
        baseSpDef: 105,
        baseSpeed: 40,
        evYield: 2 * SpDef,
        evolution: Evolution.Togetic,
        xpClass: Fast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "togetic", //Verify
        graphicsLocation: "togetic", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Togetic,
        abilities: new Ability[3]
        {
            Hustle,
            SereneGrace,
            SuperLuck,
        }
    );
    public static readonly SpeciesData Natu = new(
        speciesName: "Natu",
        type1: Psychic,
        type2: Flying,
        baseHP: 40,
        baseAttack: 50,
        baseDefense: 45,
        baseSpAtk: 70,
        baseSpDef: 45,
        baseSpeed: 70,
        evYield: SpAtk,
        evolution: Evolution.Natu,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "natu", //Verify
        graphicsLocation: "natu", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Natu,
        abilities: new Ability[3]
        {
            Synchronize,
            EarlyBird,
            MagicBounce,
        }
    );
    public static readonly SpeciesData Xatu = new(
        speciesName: "Xatu",
        type1: Psychic,
        type2: Flying,
        baseHP: 65,
        baseAttack: 75,
        baseDefense: 70,
        baseSpAtk: 95,
        baseSpDef: 70,
        baseSpeed: 95,
        evYield: Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "xatu", //Verify
        graphicsLocation: "xatu", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Xatu,
        abilities: new Ability[3]
        {
            Synchronize,
            EarlyBird,
            MagicBounce,
        }
    );
    public static readonly SpeciesData Mareep = new(
        speciesName: "Mareep",
        type1: Electric,
        type2: Electric,
        baseHP: 55,
        baseAttack: 40,
        baseDefense: 40,
        baseSpAtk: 65,
        baseSpDef: 45,
        baseSpeed: 35,
        evYield: SpAtk,
        evolution: Evolution.Mareep,
        xpClass: MediumSlow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "mareep", //Verify
        graphicsLocation: "mareep", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Mareep,
        abilities: new Ability[3]
        {
            Static,
            Static,
            Plus,
        }
    );
    public static readonly SpeciesData Flaaffy = new(
        speciesName: "Flaaffy",
        type1: Electric,
        type2: Electric,
        baseHP: 70,
        baseAttack: 55,
        baseDefense: 55,
        baseSpAtk: 80,
        baseSpDef: 60,
        baseSpeed: 45,
        evYield: 2 * SpAtk,
        evolution: Evolution.Flaaffy,
        xpClass: MediumSlow,
        xpYield: 128,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "flaaffy", //Verify
        graphicsLocation: "flaaffy", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Flaaffy,
        abilities: new Ability[3]
        {
            Static,
            Static,
            Plus,
        }
    );
    public static readonly SpeciesData Ampharos = new(
        speciesName: "Ampharos",
        type1: Electric,
        type2: Electric,
        baseHP: 90,
        baseAttack: 75,
        baseDefense: 85,
        baseSpAtk: 115,
        baseSpDef: 90,
        baseSpeed: 55,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 230,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "ampharos", //Verify
        graphicsLocation: "ampharos", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Ampharos,
        abilities: new Ability[3]
        {
            Static,
            Static,
            Plus,
        }
    );
    public static readonly SpeciesData Bellossom = new(
        speciesName: "Bellossom",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 95,
        baseSpAtk: 90,
        baseSpDef: 100,
        baseSpeed: 50,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "bellossom", //Verify
        graphicsLocation: "bellossom", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Bellossom,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Healer,
        }
    );
    public static readonly SpeciesData Marill = new(
        speciesName: "Marill",
        type1: Water,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 20,
        baseDefense: 50,
        baseSpAtk: 20,
        baseSpDef: 50,
        baseSpeed: 40,
        evYield: 2 * HP,
        evolution: Evolution.Marill,
        xpClass: Fast,
        xpYield: 88,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "marill", //Verify
        graphicsLocation: "marill", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Marill,
        abilities: new Ability[3]
        {
            ThickFat,
            HugePower,
            SapSipper,
        }
    );
    public static readonly SpeciesData Azumarill = new(
        speciesName: "Azumarill",
        type1: Water,
        type2: Fairy,
        baseHP: 100,
        baseAttack: 50,
        baseDefense: 80,
        baseSpAtk: 60,
        baseSpDef: 80,
        baseSpeed: 50,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "azumarill", //Verify
        graphicsLocation: "azumarill", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Azumarill,
        abilities: new Ability[3]
        {
            ThickFat,
            HugePower,
            SapSipper,
        }
    );
    public static readonly SpeciesData Sudowoodo = new(
        speciesName: "Sudowoodo",
        type1: Rock,
        type2: Rock,
        baseHP: 70,
        baseAttack: 100,
        baseDefense: 115,
        baseSpAtk: 30,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 65,
        baseFriendship: 70,
        cryLocation: "sudowoodo", //Verify
        graphicsLocation: "sudowoodo", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Sudowoodo,
        abilities: new Ability[3]
        {
            Sturdy,
            RockHead,
            Rattled,
        }
    );
    public static readonly SpeciesData Politoed = new(
        speciesName: "Politoed",
        type1: Water,
        type2: Water,
        baseHP: 90,
        baseAttack: 75,
        baseDefense: 75,
        baseSpAtk: 90,
        baseSpDef: 100,
        baseSpeed: 70,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "politoed", //Verify
        graphicsLocation: "politoed", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Politoed,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            Damp,
            Drizzle,
        }
    );
    public static readonly SpeciesData Hoppip = new(
        speciesName: "Hoppip",
        type1: Grass,
        type2: Flying,
        baseHP: 35,
        baseAttack: 35,
        baseDefense: 40,
        baseSpAtk: 35,
        baseSpDef: 55,
        baseSpeed: 50,
        evYield: SpDef,
        evolution: Evolution.Hoppip,
        xpClass: MediumSlow,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "hoppip", //Verify
        graphicsLocation: "hoppip", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Hoppip,
        abilities: new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Skiploom = new(
        speciesName: "Skiploom",
        type1: Grass,
        type2: Flying,
        baseHP: 55,
        baseAttack: 45,
        baseDefense: 50,
        baseSpAtk: 45,
        baseSpDef: 65,
        baseSpeed: 80,
        evYield: 2 * Speed,
        evolution: Evolution.Skiploom,
        xpClass: MediumSlow,
        xpYield: 119,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "skiploom", //Verify
        graphicsLocation: "skiploom", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Skiploom,
        abilities: new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Jumpluff = new(
        speciesName: "Jumpluff",
        type1: Grass,
        type2: Flying,
        baseHP: 75,
        baseAttack: 55,
        baseDefense: 70,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 110,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 207,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "jumpluff", //Verify
        graphicsLocation: "jumpluff", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Jumpluff,
        abilities: new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Aipom = new(
        speciesName: "Aipom",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 70,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 55,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Aipom,
        xpClass: Fast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "aipom", //Verify
        graphicsLocation: "aipom", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Aipom,
        abilities: new Ability[3]
        {
            RunAway,
            Pickup,
            SkillLink,
        }
    );
    public static readonly SpeciesData Sunkern = new(
        speciesName: "Sunkern",
        type1: Grass,
        type2: Grass,
        baseHP: 30,
        baseAttack: 30,
        baseDefense: 30,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 30,
        evYield: SpAtk,
        evolution: Evolution.Sunkern,
        xpClass: MediumSlow,
        xpYield: 36,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "sunkern", //Verify
        graphicsLocation: "sunkern", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Sunkern,
        abilities: new Ability[3]
        {
            Chlorophyll,
            SolarPower,
            EarlyBird,
        }
    );
    public static readonly SpeciesData Sunflora = new(
        speciesName: "Sunflora",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 75,
        baseDefense: 55,
        baseSpAtk: 105,
        baseSpDef: 85,
        baseSpeed: 30,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "sunflora", //Verify
        graphicsLocation: "sunflora", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Sunflora,
        abilities: new Ability[3]
        {
            Chlorophyll,
            SolarPower,
            EarlyBird,
        }
    );
    public static readonly SpeciesData Yanma = new(
        speciesName: "Yanma",
        type1: Bug,
        type2: Flying,
        baseHP: 65,
        baseAttack: 65,
        baseDefense: 45,
        baseSpAtk: 75,
        baseSpDef: 45,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.Yanma,
        xpClass: MediumFast,
        xpYield: 78,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "yanma", //Verify
        graphicsLocation: "yanma", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Yanma,
        abilities: new Ability[3]
        {
            SpeedBoost,
            CompoundEyes,
            Frisk,
        }
    );
    public static readonly SpeciesData Wooper = new(
        speciesName: "Wooper",
        type1: Water,
        type2: Ground,
        baseHP: 55,
        baseAttack: 45,
        baseDefense: 45,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 15,
        evYield: HP,
        evolution: Evolution.Wooper,
        xpClass: MediumFast,
        xpYield: 42,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "wooper", //Verify
        graphicsLocation: "wooper", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Wooper,
        abilities: new Ability[3]
        {
            Damp,
            WaterAbsorb,
            Unaware,
        }
    );
    public static readonly SpeciesData Quagsire = new(
        speciesName: "Quagsire",
        type1: Water,
        type2: Ground,
        baseHP: 95,
        baseAttack: 85,
        baseDefense: 85,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 35,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "quagsire", //Verify
        graphicsLocation: "quagsire", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Quagsire,
        abilities: new Ability[3]
        {
            Damp,
            WaterAbsorb,
            Unaware,
        }
    );
    public static readonly SpeciesData Espeon = new(
        speciesName: "Espeon",
        type1: Psychic,
        type2: Psychic,
        baseHP: 65,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 130,
        baseSpDef: 95,
        baseSpeed: 110,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "espeon", //Verify
        graphicsLocation: "espeon", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Espeon,
        abilities: new Ability[3]
        {
            Synchronize,
            Synchronize,
            MagicBounce,
        }
    );
    public static readonly SpeciesData Umbreon = new(
        speciesName: "Umbreon",
        type1: Dark,
        type2: Dark,
        baseHP: 95,
        baseAttack: 65,
        baseDefense: 110,
        baseSpAtk: 60,
        baseSpDef: 130,
        baseSpeed: 65,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "umbreon", //Verify
        graphicsLocation: "umbreon", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Umbreon,
        abilities: new Ability[3]
        {
            Synchronize,
            Synchronize,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Murkrow = new(
        speciesName: "Murkrow",
        type1: Dark,
        type2: Flying,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 42,
        baseSpAtk: 85,
        baseSpDef: 42,
        baseSpeed: 91,
        evYield: Speed,
        evolution: Evolution.Murkrow,
        xpClass: MediumSlow,
        xpYield: 81,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 35,
        cryLocation: "murkrow", //Verify
        graphicsLocation: "murkrow", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Murkrow,
        abilities: new Ability[3]
        {
            Insomnia,
            SuperLuck,
            Prankster,
        }
    );
    public static readonly SpeciesData Slowking = new(
        speciesName: "Slowking",
        type1: Water,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 75,
        baseDefense: 80,
        baseSpAtk: 100,
        baseSpDef: 110,
        baseSpeed: 30,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 70,
        baseFriendship: 70,
        cryLocation: "slowking", //Verify
        graphicsLocation: "slowking", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Slowking,
        abilities: new Ability[3]
        {
            Oblivious,
            OwnTempo,
            Regenerator,
        }
    );
    public static readonly SpeciesData Misdreavus = new(
        speciesName: "Misdreavus",
        type1: Ghost,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 85,
        baseSpDef: 85,
        baseSpeed: 85,
        evYield: SpDef,
        evolution: Evolution.Misdreavus,
        xpClass: Fast,
        xpYield: 87,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "misdreavus", //Verify
        graphicsLocation: "misdreavus", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Misdreavus,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Unown = new(
        speciesName: "Unown",
        type1: Psychic,
        type2: Psychic,
        baseHP: 48,
        baseAttack: 72,
        baseDefense: 48,
        baseSpAtk: 72,
        baseSpDef: 48,
        baseSpeed: 48,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 118,
        learnset: EmptyLearnset,
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 40,
        catchRate: 225,
        baseFriendship: 50,
        cryLocation: "unown",
        graphicsLocation: "unown", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Unown,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Wobbuffet = new(
        speciesName: "Wobbuffet",
        type1: Psychic,
        type2: Psychic,
        baseHP: 190,
        baseAttack: 33,
        baseDefense: 58,
        baseSpAtk: 33,
        baseSpDef: 58,
        baseSpeed: 33,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "wobbuffet", //Verify
        graphicsLocation: "wobbuffet", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Wobbuffet,
        abilities: new Ability[3]
        {
            ShadowTag,
            ShadowTag,
            Telepathy,
        }
    );
    public static readonly SpeciesData Girafarig = new(
        speciesName: "Girafarig",
        type1: Normal,
        type2: Psychic,
        baseHP: 70,
        baseAttack: 80,
        baseDefense: 65,
        baseSpAtk: 90,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "girafarig", //Verify
        graphicsLocation: "girafarig", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Girafarig,
        abilities: new Ability[3]
        {
            InnerFocus,
            EarlyBird,
            SapSipper,
        }
    );
    public static readonly SpeciesData Pineco = new(
        speciesName: "Pineco",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 90,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 15,
        evYield: Defense,
        evolution: Evolution.Pineco,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pineco", //Verify
        graphicsLocation: "pineco", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Pineco,
        abilities: new Ability[3]
        {
            Sturdy,
            Sturdy,
            Overcoat,
        }
    );
    public static readonly SpeciesData Forretress = new(
        speciesName: "Forretress",
        type1: Bug,
        type2: Steel,
        baseHP: 75,
        baseAttack: 90,
        baseDefense: 140,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 40,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "forretress", //Verify
        graphicsLocation: "forretress", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Forretress,
        abilities: new Ability[3]
        {
            Sturdy,
            Sturdy,
            Overcoat,
        }
    );
    public static readonly SpeciesData Dunsparce = new(
        speciesName: "Dunsparce",
        type1: Normal,
        type2: Normal,
        baseHP: 100,
        baseAttack: 70,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "dunsparce", //Verify
        graphicsLocation: "dunsparce", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Dunsparce,
        abilities: new Ability[3]
        {
            SereneGrace,
            RunAway,
            Rattled,
        }
    );
    public static readonly SpeciesData Gligar = new(
        speciesName: "Gligar",
        type1: Ground,
        type2: Flying,
        baseHP: 65,
        baseAttack: 75,
        baseDefense: 105,
        baseSpAtk: 35,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: Defense,
        evolution: Evolution.Gligar,
        xpClass: MediumSlow,
        xpYield: 86,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "gligar", //Verify
        graphicsLocation: "gligar", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Gligar,
        abilities: new Ability[3]
        {
            HyperCutter,
            SandVeil,
            Immunity,
        }
    );
    public static readonly SpeciesData Steelix = new(
        speciesName: "Steelix",
        type1: Steel,
        type2: Ground,
        baseHP: 75,
        baseAttack: 85,
        baseDefense: 200,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "steelix", //Verify
        graphicsLocation: "steelix", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Steelix,
        abilities: new Ability[3]
        {
            RockHead,
            Sturdy,
            SheerForce,
        }
    );
    public static readonly SpeciesData Snubbull = new(
        speciesName: "Snubbull",
        type1: Fairy,
        type2: Fairy,
        baseHP: 60,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 30,
        evYield: Attack,
        evolution: Evolution.Snubbull,
        xpClass: Fast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "snubbull", //Verify
        graphicsLocation: "snubbull", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Snubbull,
        abilities: new Ability[3]
        {
            Intimidate,
            RunAway,
            Rattled,
        }
    );
    public static readonly SpeciesData Granbull = new(
        speciesName: "Granbull",
        type1: Fairy,
        type2: Fairy,
        baseHP: 90,
        baseAttack: 120,
        baseDefense: 75,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 45,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "granbull", //Verify
        graphicsLocation: "granbull", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Granbull,
        abilities: new Ability[3]
        {
            Intimidate,
            QuickFeet,
            Rattled,
        }
    );
    public static readonly SpeciesData Qwilfish = new(
        speciesName: "Qwilfish",
        type1: Water,
        type2: Poison,
        baseHP: 65,
        baseAttack: 95,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 85,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 88,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "qwilfish", //Verify
        graphicsLocation: "qwilfish", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Qwilfish,
        abilities: new Ability[3]
        {
            PoisonPoint,
            SwiftSwim,
            Intimidate,
        }
    );
    public static readonly SpeciesData Scizor = new(
        speciesName: "Scizor",
        type1: Bug,
        type2: Steel,
        baseHP: 70,
        baseAttack: 130,
        baseDefense: 100,
        baseSpAtk: 55,
        baseSpDef: 80,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "scizor", //Verify
        graphicsLocation: "scizor", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Scizor,
        abilities: new Ability[3]
        {
            Swarm,
            Technician,
            LightMetal,
        }
    );
    public static readonly SpeciesData Shuckle = new(
        speciesName: "Shuckle",
        type1: Bug,
        type2: Rock,
        baseHP: 20,
        baseAttack: 10,
        baseDefense: 230,
        baseSpAtk: 10,
        baseSpDef: 230,
        baseSpeed: 5,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "shuckle", //Verify
        graphicsLocation: "shuckle", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Shuckle,
        abilities: new Ability[3]
        {
            Sturdy,
            Gluttony,
            Contrary,
        }
    );
    public static readonly SpeciesData Heracross = new(
        speciesName: "Heracross",
        type1: Bug,
        type2: Fighting,
        baseHP: 80,
        baseAttack: 125,
        baseDefense: 75,
        baseSpAtk: 40,
        baseSpDef: 95,
        baseSpeed: 85,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "heracross", //Verify
        graphicsLocation: "heracross", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Heracross,
        abilities: new Ability[3]
        {
            Swarm,
            Guts,
            Moxie,
        }
    );
    public static readonly SpeciesData Sneasel = new(
        speciesName: "Sneasel",
        type1: Dark,
        type2: Ice,
        baseHP: 55,
        baseAttack: 95,
        baseDefense: 55,
        baseSpAtk: 35,
        baseSpDef: 75,
        baseSpeed: 115,
        evYield: Speed,
        evolution: Evolution.Sneasel,
        xpClass: MediumSlow,
        xpYield: 86,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "sneasel", //Verify
        graphicsLocation: "sneasel", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Sneasel,
        abilities: new Ability[3]
        {
            InnerFocus,
            KeenEye,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Teddiursa = new(
        speciesName: "Teddiursa",
        type1: Normal,
        type2: Normal,
        baseHP: 60,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Teddiursa,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "teddiursa", //Verify
        graphicsLocation: "teddiursa", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Teddiursa,
        abilities: new Ability[3]
        {
            Pickup,
            QuickFeet,
            HoneyGather,
        }
    );
    public static readonly SpeciesData Ursaring = new(
        speciesName: "Ursaring",
        type1: Normal,
        type2: Normal,
        baseHP: 90,
        baseAttack: 130,
        baseDefense: 75,
        baseSpAtk: 75,
        baseSpDef: 75,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "ursaring", //Verify
        graphicsLocation: "ursaring", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Ursaring,
        abilities: new Ability[3]
        {
            Guts,
            QuickFeet,
            Unnerve,
        }
    );
    public static readonly SpeciesData Slugma = new(
        speciesName: "Slugma",
        type1: Fire,
        type2: Fire,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 40,
        baseSpAtk: 70,
        baseSpDef: 40,
        baseSpeed: 20,
        evYield: SpAtk,
        evolution: Evolution.Slugma,
        xpClass: MediumFast,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "slugma", //Verify
        graphicsLocation: "slugma", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Slugma,
        abilities: new Ability[3]
        {
            MagmaArmor,
            FlameBody,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Magcargo = new(
        speciesName: "Magcargo",
        type1: Fire,
        type2: Rock,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 120,
        baseSpAtk: 90,
        baseSpDef: 80,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "magcargo", //Verify
        graphicsLocation: "magcargo", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Magcargo,
        abilities: new Ability[3]
        {
            MagmaArmor,
            FlameBody,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Swinub = new(
        speciesName: "Swinub",
        type1: Ice,
        type2: Ground,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 40,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Swinub,
        xpClass: Slow,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "swinub", //Verify
        graphicsLocation: "swinub", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Swinub,
        abilities: new Ability[3]
        {
            Oblivious,
            SnowCloak,
            ThickFat,
        }
    );
    public static readonly SpeciesData Piloswine = new(
        speciesName: "Piloswine",
        type1: Ice,
        type2: Ground,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 80,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 50,
        evYield: HP + Attack,
        evolution: Evolution.Piloswine,
        xpClass: Slow,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "piloswine", //Verify
        graphicsLocation: "piloswine", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Piloswine,
        abilities: new Ability[3]
        {
            Oblivious,
            SnowCloak,
            ThickFat,
        }
    );
    public static readonly SpeciesData Corsola = new(
        speciesName: "Corsola",
        type1: Water,
        type2: Rock,
        baseHP: 65,
        baseAttack: 55,
        baseDefense: 95,
        baseSpAtk: 65,
        baseSpDef: 95,
        baseSpeed: 35,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "corsola", //Verify
        graphicsLocation: "corsola", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Corsola,
        abilities: new Ability[3]
        {
            Hustle,
            NaturalCure,
            Regenerator,
        }
    );
    public static readonly SpeciesData Remoraid = new(
        speciesName: "Remoraid",
        type1: Water,
        type2: Water,
        baseHP: 35,
        baseAttack: 65,
        baseDefense: 35,
        baseSpAtk: 65,
        baseSpDef: 35,
        baseSpeed: 65,
        evYield: SpAtk,
        evolution: Evolution.Remoraid,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "remoraid", //Verify
        graphicsLocation: "remoraid", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Remoraid,
        abilities: new Ability[3]
        {
            Hustle,
            Sniper,
            Moody,
        }
    );
    public static readonly SpeciesData Octillery = new(
        speciesName: "Octillery",
        type1: Water,
        type2: Water,
        baseHP: 75,
        baseAttack: 105,
        baseDefense: 75,
        baseSpAtk: 105,
        baseSpDef: 75,
        baseSpeed: 45,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "octillery", //Verify
        graphicsLocation: "octillery", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Octillery,
        abilities: new Ability[3]
        {
            SuctionCups,
            Sniper,
            Moody,
        }
    );
    public static readonly SpeciesData Delibird = new(
        speciesName: "Delibird",
        type1: Ice,
        type2: Flying,
        baseHP: 45,
        baseAttack: 55,
        baseDefense: 45,
        baseSpAtk: 65,
        baseSpDef: 45,
        baseSpeed: 75,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 116,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "delibird", //Verify
        graphicsLocation: "delibird", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Delibird,
        abilities: new Ability[3]
        {
            VitalSpirit,
            Hustle,
            Insomnia,
        }
    );
    public static readonly SpeciesData Mantine = new(
        speciesName: "Mantine",
        type1: Water,
        type2: Flying,
        baseHP: 85,
        baseAttack: 40,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 140,
        baseSpeed: 70,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "mantine", //Verify
        graphicsLocation: "mantine", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Mantine,
        abilities: new Ability[3]
        {
            SwiftSwim,
            WaterAbsorb,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Skarmory = new(
        speciesName: "Skarmory",
        type1: Steel,
        type2: Flying,
        baseHP: 65,
        baseAttack: 80,
        baseDefense: 140,
        baseSpAtk: 40,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "skarmory", //Verify
        graphicsLocation: "skarmory", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Skarmory,
        abilities: new Ability[3]
        {
            KeenEye,
            Sturdy,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Houndour = new(
        speciesName: "Houndour",
        type1: Dark,
        type2: Fire,
        baseHP: 45,
        baseAttack: 60,
        baseDefense: 30,
        baseSpAtk: 80,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: SpAtk,
        evolution: Evolution.Houndour,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 35,
        cryLocation: "houndour", //Verify
        graphicsLocation: "houndour", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Houndour,
        abilities: new Ability[3]
        {
            EarlyBird,
            FlashFire,
            Unnerve,
        }
    );
    public static readonly SpeciesData Houndoom = new(
        speciesName: "Houndoom",
        type1: Dark,
        type2: Fire,
        baseHP: 75,
        baseAttack: 90,
        baseDefense: 50,
        baseSpAtk: 110,
        baseSpDef: 80,
        baseSpeed: 95,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "houndoom", //Verify
        graphicsLocation: "houndoom", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Houndoom,
        abilities: new Ability[3]
        {
            EarlyBird,
            FlashFire,
            Unnerve,
        }
    );
    public static readonly SpeciesData Kingdra = new(
        speciesName: "Kingdra",
        type1: Water,
        type2: Dragon,
        baseHP: 75,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 95,
        baseSpDef: 95,
        baseSpeed: 85,
        evYield: Attack + SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 243,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kingdra", //Verify
        graphicsLocation: "kingdra", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Kingdra,
        abilities: new Ability[3]
        {
            SwiftSwim,
            Sniper,
            Damp,
        }
    );
    public static readonly SpeciesData Phanpy = new(
        speciesName: "Phanpy",
        type1: Ground,
        type2: Ground,
        baseHP: 90,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 40,
        evYield: HP,
        evolution: Evolution.Phanpy,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "phanpy", //Verify
        graphicsLocation: "phanpy", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Phanpy,
        abilities: new Ability[3]
        {
            Pickup,
            Pickup,
            SandVeil,
        }
    );
    public static readonly SpeciesData Donphan = new(
        speciesName: "Donphan",
        type1: Ground,
        type2: Ground,
        baseHP: 90,
        baseAttack: 120,
        baseDefense: 120,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 50,
        evYield: Attack + Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "donphan", //Verify
        graphicsLocation: "donphan", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Donphan,
        abilities: new Ability[3]
        {
            Sturdy,
            Sturdy,
            SandVeil,
        }
    );
    public static readonly SpeciesData Porygon2 = new(
        speciesName: "Porygon2",
        type1: Normal,
        type2: Normal,
        baseHP: 85,
        baseAttack: 80,
        baseDefense: 90,
        baseSpAtk: 105,
        baseSpDef: 95,
        baseSpeed: 60,
        evYield: 2 * SpAtk,
        evolution: Evolution.Porygon2,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "porygon2", //Verify
        graphicsLocation: "porygon2", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Porygon2,
        abilities: new Ability[3]
        {
            Trace,
            Download,
            Analytic,
        }
    );
    public static readonly SpeciesData Stantler = new(
        speciesName: "Stantler",
        type1: Normal,
        type2: Normal,
        baseHP: 73,
        baseAttack: 95,
        baseDefense: 62,
        baseSpAtk: 85,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "stantler", //Verify
        graphicsLocation: "stantler", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Stantler,
        abilities: new Ability[3]
        {
            Intimidate,
            Frisk,
            SapSipper,
        }
    );
    public static readonly SpeciesData Smeargle = new(
        speciesName: "Smeargle",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 20,
        baseDefense: 35,
        baseSpAtk: 20,
        baseSpDef: 45,
        baseSpeed: 75,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 88,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "smeargle", //Verify
        graphicsLocation: "smeargle", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Smeargle,
        abilities: new Ability[3]
        {
            OwnTempo,
            Technician,
            Moody,
        }
    );
    public static readonly SpeciesData Tyrogue = new(
        speciesName: "Tyrogue",
        type1: Fighting,
        type2: Fighting,
        baseHP: 35,
        baseAttack: 35,
        baseDefense: 35,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Tyrogue,
        xpClass: MediumFast,
        xpYield: 42,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "tyrogue", //Verify
        graphicsLocation: "tyrogue", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Tyrogue,
        abilities: new Ability[3]
        {
            Guts,
            Steadfast,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Hitmontop = new(
        speciesName: "Hitmontop",
        type1: Fighting,
        type2: Fighting,
        baseHP: 50,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 35,
        baseSpDef: 110,
        baseSpeed: 70,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "hitmontop", //Verify
        graphicsLocation: "hitmontop", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Hitmontop,
        abilities: new Ability[3]
        {
            Intimidate,
            Technician,
            Steadfast,
        }
    );
    public static readonly SpeciesData Smoochum = new(
        speciesName: "Smoochum",
        type1: Ice,
        type2: Psychic,
        baseHP: 45,
        baseAttack: 30,
        baseDefense: 15,
        baseSpAtk: 85,
        baseSpDef: 65,
        baseSpeed: 65,
        evYield: SpAtk,
        evolution: Evolution.Smoochum,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "smoochum", //Verify
        graphicsLocation: "smoochum", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Smoochum,
        abilities: new Ability[3]
        {
            Oblivious,
            Forewarn,
            Hydration,
        }
    );
    public static readonly SpeciesData Elekid = new(
        speciesName: "Elekid",
        type1: Electric,
        type2: Electric,
        baseHP: 45,
        baseAttack: 63,
        baseDefense: 37,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.Elekid,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "elekid", //Verify
        graphicsLocation: "elekid", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Elekid,
        abilities: new Ability[3]
        {
            Static,
            Static,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Magby = new(
        speciesName: "Magby",
        type1: Fire,
        type2: Fire,
        baseHP: 45,
        baseAttack: 75,
        baseDefense: 37,
        baseSpAtk: 70,
        baseSpDef: 55,
        baseSpeed: 83,
        evYield: Speed,
        evolution: Evolution.Magby,
        xpClass: MediumFast,
        xpYield: 73,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "magby", //Verify
        graphicsLocation: "magby", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Magby,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Miltank = new(
        speciesName: "Miltank",
        type1: Normal,
        type2: Normal,
        baseHP: 95,
        baseAttack: 80,
        baseDefense: 105,
        baseSpAtk: 40,
        baseSpDef: 70,
        baseSpeed: 100,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "miltank", //Verify
        graphicsLocation: "miltank", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Miltank,
        abilities: new Ability[3]
        {
            ThickFat,
            Scrappy,
            SapSipper,
        }
    );
    public static readonly SpeciesData Blissey = new(
        speciesName: "Blissey",
        type1: Normal,
        type2: Normal,
        baseHP: 255,
        baseAttack: 10,
        baseDefense: 10,
        baseSpAtk: 75,
        baseSpDef: 135,
        baseSpeed: 55,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 608,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 40,
        catchRate: 30,
        baseFriendship: 140,
        cryLocation: "blissey", //Verify
        graphicsLocation: "blissey", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Blissey,
        abilities: new Ability[3]
        {
            NaturalCure,
            SereneGrace,
            Healer,
        }
    );
    public static readonly SpeciesData Raikou = new(
        speciesName: "Raikou",
        type1: Electric,
        type2: Electric,
        baseHP: 90,
        baseAttack: 85,
        baseDefense: 75,
        baseSpAtk: 115,
        baseSpDef: 100,
        baseSpeed: 115,
        evYield: 2 * Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "raikou", //Verify
        graphicsLocation: "raikou", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Raikou,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Entei = new(
        speciesName: "Entei",
        type1: Fire,
        type2: Fire,
        baseHP: 115,
        baseAttack: 115,
        baseDefense: 85,
        baseSpAtk: 90,
        baseSpDef: 75,
        baseSpeed: 100,
        evYield: HP + 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "entei", //Verify
        graphicsLocation: "entei", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Entei,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Suicune = new(
        speciesName: "Suicune",
        type1: Water,
        type2: Water,
        baseHP: 100,
        baseAttack: 75,
        baseDefense: 115,
        baseSpAtk: 90,
        baseSpDef: 115,
        baseSpeed: 85,
        evYield: Defense + 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "suicune", //Verify
        graphicsLocation: "suicune", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Suicune,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Larvitar = new(
        speciesName: "Larvitar",
        type1: Rock,
        type2: Ground,
        baseHP: 50,
        baseAttack: 64,
        baseDefense: 50,
        baseSpAtk: 45,
        baseSpDef: 50,
        baseSpeed: 41,
        evYield: Attack,
        evolution: Evolution.Larvitar,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "larvitar", //Verify
        graphicsLocation: "larvitar", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Larvitar,
        abilities: new Ability[3]
        {
            Guts,
            Guts,
            SandVeil,
        }
    );
    public static readonly SpeciesData Pupitar = new(
        speciesName: "Pupitar",
        type1: Rock,
        type2: Ground,
        baseHP: 70,
        baseAttack: 84,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 51,
        evYield: 2 * Attack,
        evolution: Evolution.Pupitar,
        xpClass: Slow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "pupitar", //Verify
        graphicsLocation: "pupitar", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Pupitar,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            ShedSkin,
        }
    );
    public static readonly SpeciesData Tyranitar = new(
        speciesName: "Tyranitar",
        type1: Rock,
        type2: Dark,
        baseHP: 100,
        baseAttack: 134,
        baseDefense: 110,
        baseSpAtk: 95,
        baseSpDef: 100,
        baseSpeed: 61,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "tyranitar", //Verify
        graphicsLocation: "tyranitar", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Tyranitar,
        abilities: new Ability[3]
        {
            SandStream,
            SandStream,
            Unnerve,
        }
    );
    public static readonly SpeciesData Lugia = new(
        speciesName: "Lugia",
        type1: Psychic,
        type2: Flying,
        baseHP: 106,
        baseAttack: 90,
        baseDefense: 130,
        baseSpAtk: 90,
        baseSpDef: 154,
        baseSpeed: 110,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "lugia", //Verify
        graphicsLocation: "lugia", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Lugia,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Multiscale,
        }
    );
    public static readonly SpeciesData HoOh = new(
        speciesName: "Ho Oh",
        type1: Fire,
        type2: Flying,
        baseHP: 106,
        baseAttack: 130,
        baseDefense: 90,
        baseSpAtk: 110,
        baseSpDef: 154,
        baseSpeed: 90,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "ho_oh", //Verify
        graphicsLocation: "ho_oh", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.HoOh,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Regenerator,
        }

    );
    public static readonly SpeciesData Celebi = new(
        speciesName: "Celebi",
        type1: Psychic,
        type2: Grass,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 100,
        cryLocation: "celebi", //Verify
        graphicsLocation: "celebi", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Celebi,
        abilities: new Ability[3]
        {
            NaturalCure,
            NaturalCure,
            NaturalCure,
        }
    );

    public static readonly SpeciesData Treecko = new(
        speciesName: "Treecko",
        type1: Grass,
        type2: Grass,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 35,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 70,
        evYield: Speed,
        evolution: Evolution.Treecko,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "treecko", //Verify
        graphicsLocation: "treecko", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Treecko,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Unburden,
        }
    );
    public static readonly SpeciesData Grovyle = new(
        speciesName: "Grovyle",
        type1: Grass,
        type2: Grass,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 45,
        baseSpAtk: 85,
        baseSpDef: 65,
        baseSpeed: 95,
        evYield: 2 * Speed,
        evolution: Evolution.Grovyle,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "grovyle", //Verify
        graphicsLocation: "grovyle", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Grovyle,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Unburden,
        }
    );
    public static readonly SpeciesData Sceptile = new(
        speciesName: "Sceptile",
        type1: Grass,
        type2: Grass,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 65,
        baseSpAtk: 105,
        baseSpDef: 85,
        baseSpeed: 120,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sceptile", //Verify
        graphicsLocation: "sceptile", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Sceptile,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Unburden,
        }
    );
    public static readonly SpeciesData Torchic = new(
        speciesName: "Torchic",
        type1: Fire,
        type2: Fire,
        baseHP: 45,
        baseAttack: 60,
        baseDefense: 40,
        baseSpAtk: 70,
        baseSpDef: 50,
        baseSpeed: 45,
        evYield: SpAtk,
        evolution: Evolution.Torchic,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "torchic", //Verify
        graphicsLocation: "torchic", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Torchic,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SpeedBoost,
        }
    );
    public static readonly SpeciesData Combusken = new(
        speciesName: "Combusken",
        type1: Fire,
        type2: Fighting,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 60,
        baseSpAtk: 85,
        baseSpDef: 60,
        baseSpeed: 55,
        evYield: Attack + SpAtk,
        evolution: Evolution.Combusken,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "combusken", //Verify
        graphicsLocation: "combusken", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Combusken,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SpeedBoost,
        }
    );
    public static readonly SpeciesData Blaziken = new(
        speciesName: "Blaziken",
        type1: Fire,
        type2: Fighting,
        baseHP: 80,
        baseAttack: 120,
        baseDefense: 70,
        baseSpAtk: 110,
        baseSpDef: 70,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "blaziken", //Verify
        graphicsLocation: "blaziken", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Blaziken,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            SpeedBoost,
        }
    );
    public static readonly SpeciesData Mudkip = new(
        speciesName: "Mudkip",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 70,
        baseDefense: 50,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Mudkip,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mudkip", //Verify
        graphicsLocation: "mudkip", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Mudkip,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Damp,
        }
    );
    public static readonly SpeciesData Marshtomp = new(
        speciesName: "Marshtomp",
        type1: Water,
        type2: Ground,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 50,
        evYield: 2 * Attack,
        evolution: Evolution.Marshtomp,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "marshtomp", //Verify
        graphicsLocation: "marshtomp", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Marshtomp,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Damp,
        }
    );
    public static readonly SpeciesData Swampert = new(
        speciesName: "Swampert",
        type1: Water,
        type2: Ground,
        baseHP: 100,
        baseAttack: 110,
        baseDefense: 90,
        baseSpAtk: 85,
        baseSpDef: 90,
        baseSpeed: 60,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "swampert", //Verify
        graphicsLocation: "swampert", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Swampert,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Damp,
        }
    );
    public static readonly SpeciesData Poochyena = new(
        speciesName: "Poochyena",
        type1: Dark,
        type2: Dark,
        baseHP: 35,
        baseAttack: 55,
        baseDefense: 35,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Poochyena,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "poochyena", //Verify
        graphicsLocation: "poochyena", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Poochyena,
        abilities: new Ability[3]
        {
            RunAway,
            QuickFeet,
            Rattled,
        }
    );
    public static readonly SpeciesData Mightyena = new(
        speciesName: "Mightyena",
        type1: Dark,
        type2: Dark,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "mightyena", //Verify
        graphicsLocation: "mightyena", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Mightyena,
        abilities: new Ability[3]
        {
            Intimidate,
            QuickFeet,
            Moxie,
        }
    );
    public static readonly SpeciesData Zigzagoon = new(
        speciesName: "Zigzagoon",
        type1: Normal,
        type2: Normal,
        baseHP: 38,
        baseAttack: 30,
        baseDefense: 41,
        baseSpAtk: 30,
        baseSpDef: 41,
        baseSpeed: 60,
        evYield: Speed,
        evolution: Evolution.Zigzagoon,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "zigzagoon", //Verify
        graphicsLocation: "zigzagoon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Zigzagoon,
        abilities: new Ability[3]
        {
            Pickup,
            Gluttony,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Linoone = new(
        speciesName: "Linoone",
        type1: Normal,
        type2: Normal,
        baseHP: 78,
        baseAttack: 70,
        baseDefense: 61,
        baseSpAtk: 50,
        baseSpDef: 61,
        baseSpeed: 100,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "linoone", //Verify
        graphicsLocation: "linoone", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Linoone,
        abilities: new Ability[3]
        {
            Pickup,
            Gluttony,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Wurmple = new(
        speciesName: "Wurmple",
        type1: Bug,
        type2: Bug,
        baseHP: 45,
        baseAttack: 45,
        baseDefense: 35,
        baseSpAtk: 20,
        baseSpDef: 30,
        baseSpeed: 20,
        evYield: HP,
        evolution: Evolution.Wurmple,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "wurmple", //Verify
        graphicsLocation: "wurmple", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Wurmple,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            RunAway,
        }
    );
    public static readonly SpeciesData Silcoon = new(
        speciesName: "Silcoon",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 35,
        baseDefense: 55,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 15,
        evYield: 2 * Defense,
        evolution: Evolution.Silcoon,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "silcoon", //Verify
        graphicsLocation: "silcoon", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Silcoon,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            ShedSkin,
        }
    );
    public static readonly SpeciesData Beautifly = new(
        speciesName: "Beautifly",
        type1: Bug,
        type2: Flying,
        baseHP: 60,
        baseAttack: 70,
        baseDefense: 50,
        baseSpAtk: 100,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 178,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "beautifly", //Verify
        graphicsLocation: "beautifly", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Beautifly,
        abilities: new Ability[3]
        {
            Swarm,
            Swarm,
            Rivalry,
        }
    );
    public static readonly SpeciesData Cascoon = new(
        speciesName: "Cascoon",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 35,
        baseDefense: 55,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 15,
        evYield: 2 * Defense,
        evolution: Evolution.Cascoon,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "cascoon", //Verify
        graphicsLocation: "cascoon", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Cascoon,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            ShedSkin,
        }
    );
    public static readonly SpeciesData Dustox = new(
        speciesName: "Dustox",
        type1: Bug,
        type2: Poison,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 70,
        baseSpAtk: 50,
        baseSpDef: 90,
        baseSpeed: 65,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dustox", //Verify
        graphicsLocation: "dustox", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Dustox,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            CompoundEyes,
        }
    );
    public static readonly SpeciesData Lotad = new(
        speciesName: "Lotad",
        type1: Water,
        type2: Grass,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 30,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 30,
        evYield: SpDef,
        evolution: Evolution.Lotad,
        xpClass: MediumSlow,
        xpYield: 44,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "lotad", //Verify
        graphicsLocation: "lotad", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Lotad,
        abilities: new Ability[3]
        {
            SwiftSwim,
            RainDish,
            OwnTempo,
        }
    );
    public static readonly SpeciesData Lombre = new(
        speciesName: "Lombre",
        type1: Water,
        type2: Grass,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 50,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 50,
        evYield: 2 * SpDef,
        evolution: Evolution.Lombre,
        xpClass: MediumSlow,
        xpYield: 119,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "lombre", //Verify
        graphicsLocation: "lombre", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Lombre,
        abilities: new Ability[3]
        {
            SwiftSwim,
            RainDish,
            OwnTempo,
        }
    );
    public static readonly SpeciesData Ludicolo = new(
        speciesName: "Ludicolo",
        type1: Water,
        type2: Grass,
        baseHP: 80,
        baseAttack: 70,
        baseDefense: 70,
        baseSpAtk: 90,
        baseSpDef: 100,
        baseSpeed: 70,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 216,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "ludicolo", //Verify
        graphicsLocation: "ludicolo", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Ludicolo,
        abilities: new Ability[3]
        {
            SwiftSwim,
            RainDish,
            OwnTempo,
        }
    );
    public static readonly SpeciesData Seedot = new(
        speciesName: "Seedot",
        type1: Grass,
        type2: Grass,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Seedot,
        xpClass: MediumSlow,
        xpYield: 44,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "seedot", //Verify
        graphicsLocation: "seedot", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Seedot,
        abilities: new Ability[3]
        {
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Nuzleaf = new(
        speciesName: "Nuzleaf",
        type1: Grass,
        type2: Dark,
        baseHP: 70,
        baseAttack: 70,
        baseDefense: 40,
        baseSpAtk: 60,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: 2 * Attack,
        evolution: Evolution.Nuzleaf,
        xpClass: MediumSlow,
        xpYield: 119,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "nuzleaf", //Verify
        graphicsLocation: "nuzleaf", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Nuzleaf,
        abilities: new Ability[3]
        {
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Shiftry = new(
        speciesName: "Shiftry",
        type1: Grass,
        type2: Dark,
        baseHP: 90,
        baseAttack: 100,
        baseDefense: 60,
        baseSpAtk: 90,
        baseSpDef: 60,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 216,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "shiftry", //Verify
        graphicsLocation: "shiftry", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Shiftry,
        abilities: new Ability[3]
        {
            Chlorophyll,
            EarlyBird,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Taillow = new(
        speciesName: "Taillow",
        type1: Normal,
        type2: Flying,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 30,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Taillow,
        xpClass: MediumSlow,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "taillow", //Verify
        graphicsLocation: "taillow", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Taillow,
        abilities: new Ability[3]
        {
            Guts,
            Guts,
            Scrappy,
        }
    );
    public static readonly SpeciesData Swellow = new(
        speciesName: "Swellow",
        type1: Normal,
        type2: Flying,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 60,
        baseSpAtk: 75,
        baseSpDef: 50,
        baseSpeed: 125,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "swellow", //Verify
        graphicsLocation: "swellow", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Swellow,
        abilities: new Ability[3]
        {
            Guts,
            Guts,
            Scrappy,
        }
    );
    public static readonly SpeciesData Wingull = new(
        speciesName: "Wingull",
        type1: Water,
        type2: Flying,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 30,
        baseSpAtk: 55,
        baseSpDef: 30,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Wingull,
        xpClass: MediumFast,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "wingull", //Verify
        graphicsLocation: "wingull", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Wingull,
        abilities: new Ability[3]
        {
            KeenEye,
            Hydration,
            RainDish,
        }
    );
    public static readonly SpeciesData Pelipper = new(
        speciesName: "Pelipper",
        type1: Water,
        type2: Flying,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 100,
        baseSpAtk: 95,
        baseSpDef: 70,
        baseSpeed: 65,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "pelipper", //Verify
        graphicsLocation: "pelipper", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Pelipper,
        abilities: new Ability[3]
        {
            KeenEye,
            Drizzle,
            RainDish,
        }
    );
    public static readonly SpeciesData Ralts = new(
        speciesName: "Ralts",
        type1: Psychic,
        type2: Fairy,
        baseHP: 28,
        baseAttack: 25,
        baseDefense: 25,
        baseSpAtk: 45,
        baseSpDef: 35,
        baseSpeed: 40,
        evYield: SpAtk,
        evolution: Evolution.Ralts,
        xpClass: Slow,
        xpYield: 40,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 35,
        cryLocation: "ralts", //Verify
        graphicsLocation: "ralts", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Ralts,
        abilities: new Ability[3]
        {
            Synchronize,
            Trace,
            Telepathy,
        }
    );
    public static readonly SpeciesData Kirlia = new(
        speciesName: "Kirlia",
        type1: Psychic,
        type2: Fairy,
        baseHP: 38,
        baseAttack: 35,
        baseDefense: 35,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 50,
        evYield: 2 * SpAtk,
        evolution: Evolution.Kirlia,
        xpClass: Slow,
        xpYield: 97,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 35,
        cryLocation: "kirlia", //Verify
        graphicsLocation: "kirlia", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kirlia,
        abilities: new Ability[3]
        {
            Synchronize,
            Trace,
            Telepathy,
        }
    );
    public static readonly SpeciesData Gardevoir = new(
        speciesName: "Gardevoir",
        type1: Psychic,
        type2: Fairy,
        baseHP: 68,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 125,
        baseSpDef: 115,
        baseSpeed: 80,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 233,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "gardevoir", //Verify
        graphicsLocation: "gardevoir", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Gardevoir,
        abilities: new Ability[3]
        {
            Synchronize,
            Trace,
            Telepathy,
        }
    );
    public static readonly SpeciesData Surskit = new(
        speciesName: "Surskit",
        type1: Bug,
        type2: Water,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 32,
        baseSpAtk: 50,
        baseSpDef: 52,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Surskit,
        xpClass: MediumFast,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "surskit", //Verify
        graphicsLocation: "surskit", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Surskit,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            RainDish,
        }
    );
    public static readonly SpeciesData Masquerain = new(
        speciesName: "Masquerain",
        type1: Bug,
        type2: Flying,
        baseHP: 70,
        baseAttack: 60,
        baseDefense: 62,
        baseSpAtk: 100,
        baseSpDef: 82,
        baseSpeed: 80,
        evYield: SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "masquerain", //Verify
        graphicsLocation: "masquerain", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Masquerain,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Unnerve,
        }
    );
    public static readonly SpeciesData Shroomish = new(
        speciesName: "Shroomish",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 40,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 60,
        baseSpeed: 35,
        evYield: HP,
        evolution: Evolution.Shroomish,
        xpClass: Fluctuating,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "shroomish", //Verify
        graphicsLocation: "shroomish", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Shroomish,
        abilities: new Ability[3]
        {
            EffectSpore,
            PoisonHeal,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Breloom = new(
        speciesName: "Breloom",
        type1: Grass,
        type2: Fighting,
        baseHP: 60,
        baseAttack: 130,
        baseDefense: 80,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "breloom", //Verify
        graphicsLocation: "breloom", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Breloom,
        abilities: new Ability[3]
        {
            EffectSpore,
            PoisonHeal,
            Technician,
        }
    );
    public static readonly SpeciesData Slakoth = new(
        speciesName: "Slakoth",
        type1: Normal,
        type2: Normal,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 30,
        evYield: HP,
        evolution: Evolution.Slakoth,
        xpClass: Slow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "slakoth", //Verify
        graphicsLocation: "slakoth", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Slakoth,
        abilities: new Ability[3]
        {
            Truant,
            Truant,
            Truant,
        }
    );
    public static readonly SpeciesData Vigoroth = new(
        speciesName: "Vigoroth",
        type1: Normal,
        type2: Normal,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.Vigoroth,
        xpClass: Slow,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "vigoroth", //Verify
        graphicsLocation: "vigoroth", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Vigoroth,
        abilities: new Ability[3]
        {
            VitalSpirit,
            VitalSpirit,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Slaking = new(
        speciesName: "Slaking",
        type1: Normal,
        type2: Normal,
        baseHP: 150,
        baseAttack: 160,
        baseDefense: 100,
        baseSpAtk: 95,
        baseSpDef: 65,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 252,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "slaking", //Verify
        graphicsLocation: "slaking", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Slaking,
        abilities: new Ability[3]
        {
            Truant,
            Truant,
            Truant,
        }
    );
    public static readonly SpeciesData Nincada = new(
        speciesName: "Nincada",
        type1: Bug,
        type2: Ground,
        baseHP: 31,
        baseAttack: 45,
        baseDefense: 90,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 40,
        evYield: Defense,
        evolution: Evolution.Nincada,
        xpClass: Erratic,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "nincada", //Verify
        graphicsLocation: "nincada", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Nincada,
        abilities: new Ability[3]
        {
            CompoundEyes,
            CompoundEyes,
            RunAway,
        }
    );
    public static readonly SpeciesData Ninjask = new(
        speciesName: "Ninjask",
        type1: Bug,
        type2: Flying,
        baseHP: 61,
        baseAttack: 90,
        baseDefense: 45,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 160,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 160,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "ninjask", //Verify
        graphicsLocation: "ninjask", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Ninjask,
        abilities: new Ability[3]
        {
            SpeedBoost,
            SpeedBoost,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Shedinja = new(
        speciesName: "Shedinja",
        type1: Bug,
        type2: Ghost,
        baseHP: 1,
        baseAttack: 90,
        baseDefense: 45,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 40,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 83,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "shedinja", //Verify
        graphicsLocation: "shedinja", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Shedinja,
        abilities: new Ability[3]
        {
            WonderGuard,
            WonderGuard,
            WonderGuard,
        }
    );
    public static readonly SpeciesData Whismur = new(
        speciesName: "Whismur",
        type1: Normal,
        type2: Normal,
        baseHP: 64,
        baseAttack: 51,
        baseDefense: 23,
        baseSpAtk: 51,
        baseSpDef: 23,
        baseSpeed: 28,
        evYield: HP,
        evolution: Evolution.Whismur,
        xpClass: MediumSlow,
        xpYield: 48,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "whismur", //Verify
        graphicsLocation: "whismur", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Whismur,
        abilities: new Ability[3]
        {
            Soundproof,
            Soundproof,
            Rattled,
        }
    );
    public static readonly SpeciesData Loudred = new(
        speciesName: "Loudred",
        type1: Normal,
        type2: Normal,
        baseHP: 84,
        baseAttack: 71,
        baseDefense: 43,
        baseSpAtk: 71,
        baseSpDef: 43,
        baseSpeed: 48,
        evYield: 2 * HP,
        evolution: Evolution.Loudred,
        xpClass: MediumSlow,
        xpYield: 126,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "loudred", //Verify
        graphicsLocation: "loudred", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Loudred,
        abilities: new Ability[3]
        {
            Soundproof,
            Soundproof,
            Scrappy,
        }
    );
    public static readonly SpeciesData Exploud = new(
        speciesName: "Exploud",
        type1: Normal,
        type2: Normal,
        baseHP: 104,
        baseAttack: 91,
        baseDefense: 63,
        baseSpAtk: 91,
        baseSpDef: 73,
        baseSpeed: 68,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "exploud", //Verify
        graphicsLocation: "exploud", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Exploud,
        abilities: new Ability[3]
        {
            Soundproof,
            Soundproof,
            Scrappy,
        }
    );
    public static readonly SpeciesData Makuhita = new(
        speciesName: "Makuhita",
        type1: Fighting,
        type2: Fighting,
        baseHP: 72,
        baseAttack: 60,
        baseDefense: 30,
        baseSpAtk: 20,
        baseSpDef: 30,
        baseSpeed: 25,
        evYield: HP,
        evolution: Evolution.Makuhita,
        xpClass: Fluctuating,
        xpYield: 47,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "makuhita", //Verify
        graphicsLocation: "makuhita", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Makuhita,
        abilities: new Ability[3]
        {
            ThickFat,
            Guts,
            SheerForce,
        }
    );
    public static readonly SpeciesData Hariyama = new(
        speciesName: "Hariyama",
        type1: Fighting,
        type2: Fighting,
        baseHP: 144,
        baseAttack: 120,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 60,
        baseSpeed: 50,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "hariyama", //Verify
        graphicsLocation: "hariyama", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Hariyama,
        abilities: new Ability[3]
        {
            ThickFat,
            Guts,
            SheerForce,
        }
    );
    public static readonly SpeciesData Azurill = new(
        speciesName: "Azurill",
        type1: Normal,
        type2: Fairy,
        baseHP: 50,
        baseAttack: 20,
        baseDefense: 40,
        baseSpAtk: 20,
        baseSpDef: 40,
        baseSpeed: 20,
        evYield: HP,
        evolution: Evolution.Azurill,
        xpClass: Fast,
        xpYield: 38,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 150,
        baseFriendship: 70,
        cryLocation: "azurill", //Verify
        graphicsLocation: "azurill", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Azurill,
        abilities: new Ability[3]
        {
            ThickFat,
            HugePower,
            SapSipper,
        }
    );
    public static readonly SpeciesData Nosepass = new(
        speciesName: "Nosepass",
        type1: Rock,
        type2: Rock,
        baseHP: 30,
        baseAttack: 45,
        baseDefense: 135,
        baseSpAtk: 45,
        baseSpDef: 90,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Nosepass, //Not done
        xpClass: MediumFast,
        xpYield: 75,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "nosepass", //Verify
        graphicsLocation: "nosepass", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Nosepass,
        abilities: new Ability[3]
        {
            Sturdy,
            MagnetPull,
            SandForce,
        }
    );
    public static readonly SpeciesData Skitty = new(
        speciesName: "Skitty",
        type1: Normal,
        type2: Normal,
        baseHP: 50,
        baseAttack: 45,
        baseDefense: 45,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 50,
        evYield: Speed,
        evolution: Evolution.Skitty,
        xpClass: Fast,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "skitty", //Verify
        graphicsLocation: "skitty", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Skitty,
        abilities: new Ability[3]
        {
            CuteCharm,
            Normalize,
            WonderSkin,
        }
    );
    public static readonly SpeciesData Delcatty = new(
        speciesName: "Delcatty",
        type1: Normal,
        type2: Normal,
        baseHP: 70,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 90,
        evYield: HP + Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "delcatty", //Verify
        graphicsLocation: "delcatty", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Delcatty,
        abilities: new Ability[3]
        {
            CuteCharm,
            Normalize,
            WonderSkin,
        }
    );
    public static readonly SpeciesData Sableye = new(
        speciesName: "Sableye",
        type1: Dark,
        type2: Ghost,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 75,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 50,
        evYield: Attack + Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 133,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "sableye", //Verify
        graphicsLocation: "sableye", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sableye,
        abilities: new Ability[3]
        {
            KeenEye,
            Stall,
            Prankster,
        }
    );
    public static readonly SpeciesData Mawile = new(
        speciesName: "Mawile",
        type1: Steel,
        type2: Fairy,
        baseHP: 50,
        baseAttack: 85,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 50,
        evYield: Attack + Defense,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 133,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mawile", //Verify
        graphicsLocation: "mawile", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Mawile,
        abilities: new Ability[3]
        {
            HyperCutter,
            Intimidate,
            SheerForce,
        }
    );
    public static readonly SpeciesData Aron = new(
        speciesName: "Aron",
        type1: Steel,
        type2: Rock,
        baseHP: 50,
        baseAttack: 70,
        baseDefense: 100,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Aron,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 35,
        catchRate: 180,
        baseFriendship: 35,
        cryLocation: "aron", //Verify
        graphicsLocation: "aron", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Aron,
        abilities: new Ability[3]
        {
            Sturdy,
            RockHead,
            HeavyMetal,
        }
    );
    public static readonly SpeciesData Lairon = new(
        speciesName: "Lairon",
        type1: Steel,
        type2: Rock,
        baseHP: 60,
        baseAttack: 90,
        baseDefense: 140,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 40,
        evYield: 2 * Defense,
        evolution: Evolution.Lairon,
        xpClass: Slow,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 35,
        catchRate: 90,
        baseFriendship: 35,
        cryLocation: "lairon", //Verify
        graphicsLocation: "lairon", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Lairon,
        abilities: new Ability[3]
        {
            Sturdy,
            RockHead,
            HeavyMetal,
        }
    );
    public static readonly SpeciesData Aggron = new(
        speciesName: "Aggron",
        type1: Steel,
        type2: Rock,
        baseHP: 70,
        baseAttack: 110,
        baseDefense: 180,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 50,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "aggron", //Verify
        graphicsLocation: "aggron", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Aggron,
        abilities: new Ability[3]
        {
            Sturdy,
            RockHead,
            HeavyMetal,
        }
    );
    public static readonly SpeciesData Meditite = new(
        speciesName: "Meditite",
        type1: Fighting,
        type2: Psychic,
        baseHP: 30,
        baseAttack: 40,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 55,
        baseSpeed: 60,
        evYield: Speed,
        evolution: Evolution.Meditite,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "meditite", //Verify
        graphicsLocation: "meditite", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Meditite,
        abilities: new Ability[3]
        {
            PurePower,
            PurePower,
            Telepathy,
        }
    );
    public static readonly SpeciesData Medicham = new(
        speciesName: "Medicham",
        type1: Fighting,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 75,
        baseSpAtk: 60,
        baseSpDef: 75,
        baseSpeed: 80,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "medicham", //Verify
        graphicsLocation: "medicham", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Medicham,
        abilities: new Ability[3]
        {
            PurePower,
            PurePower,
            Telepathy,
        }
    );
    public static readonly SpeciesData Electrike = new(
        speciesName: "Electrike",
        type1: Electric,
        type2: Electric,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 40,
        baseSpAtk: 65,
        baseSpDef: 40,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Electrike,
        xpClass: Slow,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "electrike", //Verify
        graphicsLocation: "electrike", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Electrike,
        abilities: new Ability[3]
        {
            Static,
            LightningRod,
            Minus,
        }
    );
    public static readonly SpeciesData Manectric = new(
        speciesName: "Manectric",
        type1: Electric,
        type2: Electric,
        baseHP: 70,
        baseAttack: 75,
        baseDefense: 60,
        baseSpAtk: 105,
        baseSpDef: 60,
        baseSpeed: 105,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "manectric", //Verify
        graphicsLocation: "manectric", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Manectric,
        abilities: new Ability[3]
        {
            Static,
            LightningRod,
            Minus,
        }
    );
    public static readonly SpeciesData Plusle = new(
        speciesName: "Plusle",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 40,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "plusle", //Verify
        graphicsLocation: "plusle", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Plusle,
        abilities: new Ability[3]
        {
            Plus,
            Plus,
            LightningRod,
        }
    );
    public static readonly SpeciesData Minun = new(
        speciesName: "Minun",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 75,
        baseSpDef: 85,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "minun", //Verify
        graphicsLocation: "minun", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Minun,
        abilities: new Ability[3]
        {
            Minus,
            Minus,
            VoltAbsorb,
        }
    );
    public static readonly SpeciesData Volbeat = new(
        speciesName: "Volbeat",
        type1: Bug,
        type2: Bug,
        baseHP: 65,
        baseAttack: 73,
        baseDefense: 75,
        baseSpAtk: 47,
        baseSpDef: 85,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 15,
        catchRate: 150,
        baseFriendship: 70,
        cryLocation: "volbeat", //Verify
        graphicsLocation: "volbeat", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Volbeat,
        abilities: new Ability[3]
        {
            Illuminate,
            Swarm,
            Prankster,
        }
    );
    public static readonly SpeciesData Illumise = new(
        speciesName: "Illumise",
        type1: Bug,
        type2: Bug,
        baseHP: 65,
        baseAttack: 47,
        baseDefense: 75,
        baseSpAtk: 73,
        baseSpDef: 85,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 15,
        catchRate: 150,
        baseFriendship: 70,
        cryLocation: "illumise", //Verify
        graphicsLocation: "illumise", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Illumise,
        abilities: new Ability[3]
        {
            Oblivious,
            TintedLens,
            Prankster,
        }
    );
    public static readonly SpeciesData Roselia = new(
        speciesName: "Roselia",
        type1: Grass,
        type2: Poison,
        baseHP: 50,
        baseAttack: 60,
        baseDefense: 45,
        baseSpAtk: 100,
        baseSpDef: 80,
        baseSpeed: 65,
        evYield: 2 * SpAtk,
        evolution: Evolution.Roselia, //Not done
        xpClass: MediumSlow,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 150,
        baseFriendship: 70,
        cryLocation: "roselia", //Verify
        graphicsLocation: "roselia", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Roselia,
        abilities: new Ability[3]
        {
            NaturalCure,
            PoisonPoint,
            LeafGuard,
        }
    );
    public static readonly SpeciesData Gulpin = new(
        speciesName: "Gulpin",
        type1: Poison,
        type2: Poison,
        baseHP: 70,
        baseAttack: 43,
        baseDefense: 53,
        baseSpAtk: 43,
        baseSpDef: 53,
        baseSpeed: 40,
        evYield: HP,
        evolution: Evolution.Gulpin,
        xpClass: Fluctuating,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "gulpin", //Verify
        graphicsLocation: "gulpin", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Gulpin,
        abilities: new Ability[3]
        {
            LiquidOoze,
            StickyHold,
            Gluttony,
        }
    );
    public static readonly SpeciesData Swalot = new(
        speciesName: "Swalot",
        type1: Poison,
        type2: Poison,
        baseHP: 100,
        baseAttack: 73,
        baseDefense: 83,
        baseSpAtk: 73,
        baseSpDef: 83,
        baseSpeed: 55,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "swalot", //Verify
        graphicsLocation: "swalot", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Swalot,
        abilities: new Ability[3]
        {
            LiquidOoze,
            StickyHold,
            Gluttony,
        }
    );
    public static readonly SpeciesData Carvanha = new(
        speciesName: "Carvanha",
        type1: Water,
        type2: Dark,
        baseHP: 45,
        baseAttack: 90,
        baseDefense: 20,
        baseSpAtk: 65,
        baseSpDef: 20,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.Carvanha,
        xpClass: Slow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 35,
        cryLocation: "carvanha", //Verify
        graphicsLocation: "carvanha", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Carvanha,
        abilities: new Ability[3]
        {
            RoughSkin,
            RoughSkin,
            SpeedBoost,
        }
    );
    public static readonly SpeciesData Sharpedo = new(
        speciesName: "Sharpedo",
        type1: Water,
        type2: Dark,
        baseHP: 70,
        baseAttack: 120,
        baseDefense: 40,
        baseSpAtk: 95,
        baseSpDef: 40,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "sharpedo", //Verify
        graphicsLocation: "sharpedo", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Sharpedo,
        abilities: new Ability[3]
        {
            RoughSkin,
            RoughSkin,
            SpeedBoost,
        }
    );
    public static readonly SpeciesData Wailmer = new(
        speciesName: "Wailmer",
        type1: Water,
        type2: Water,
        baseHP: 130,
        baseAttack: 70,
        baseDefense: 35,
        baseSpAtk: 70,
        baseSpDef: 35,
        baseSpeed: 60,
        evYield: HP,
        evolution: Evolution.Wailmer,
        xpClass: Fluctuating,
        xpYield: 80,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 125,
        baseFriendship: 70,
        cryLocation: "wailmer", //Verify
        graphicsLocation: "wailmer", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Wailmer,
        abilities: new Ability[3]
        {
            WaterVeil,
            Oblivious,
            Pressure,
        }
    );
    public static readonly SpeciesData Wailord = new(
        speciesName: "Wailord",
        type1: Water,
        type2: Water,
        baseHP: 170,
        baseAttack: 90,
        baseDefense: 45,
        baseSpAtk: 90,
        baseSpDef: 45,
        baseSpeed: 60,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "wailord", //Verify
        graphicsLocation: "wailord", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Wailord,
        abilities: new Ability[3]
        {
            WaterVeil,
            Oblivious,
            Pressure,
        }
    );
    public static readonly SpeciesData Numel = new(
        speciesName: "Numel",
        type1: Fire,
        type2: Ground,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 40,
        baseSpAtk: 65,
        baseSpDef: 45,
        baseSpeed: 35,
        evYield: SpAtk,
        evolution: Evolution.Numel,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "numel", //Verify
        graphicsLocation: "numel", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Numel,
        abilities: new Ability[3]
        {
            Oblivious,
            Simple,
            OwnTempo,
        }
    );
    public static readonly SpeciesData Camerupt = new(
        speciesName: "Camerupt",
        type1: Fire,
        type2: Ground,
        baseHP: 70,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 105,
        baseSpDef: 75,
        baseSpeed: 40,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 150,
        baseFriendship: 70,
        cryLocation: "camerupt", //Verify
        graphicsLocation: "camerupt", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Camerupt,
        abilities: new Ability[3]
        {
            MagmaArmor,
            SolidRock,
            AngerPoint,
        }
    );
    public static readonly SpeciesData Torkoal = new(
        speciesName: "Torkoal",
        type1: Fire,
        type2: Fire,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 140,
        baseSpAtk: 85,
        baseSpDef: 70,
        baseSpeed: 20,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "torkoal", //Verify
        graphicsLocation: "torkoal", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Torkoal,
        abilities: new Ability[3]
        {
            WhiteSmoke,
            Drought,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Spoink = new(
        speciesName: "Spoink",
        type1: Psychic,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 25,
        baseDefense: 35,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 60,
        evYield: SpDef,
        evolution: Evolution.Spoink,
        xpClass: Fast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "spoink", //Verify
        graphicsLocation: "spoink", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Spoink,
        abilities: new Ability[3]
        {
            ThickFat,
            OwnTempo,
            Gluttony,
        }
    );
    public static readonly SpeciesData Grumpig = new(
        speciesName: "Grumpig",
        type1: Psychic,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 45,
        baseDefense: 65,
        baseSpAtk: 90,
        baseSpDef: 110,
        baseSpeed: 80,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "grumpig", //Verify
        graphicsLocation: "grumpig", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Grumpig,
        abilities: new Ability[3]
        {
            ThickFat,
            OwnTempo,
            Gluttony,
        }
    );
    public static readonly SpeciesData Spinda = new(
        speciesName: "Spinda",
        type1: Normal,
        type2: Normal,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 60,
        evYield: SpAtk,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 126,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "spinda", //Verify
        graphicsLocation: "spinda", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Spinda,
        abilities: new Ability[3]
        {
            OwnTempo,
            TangledFeet,
            Contrary,
        }
    );
    public static readonly SpeciesData Trapinch = new(
        speciesName: "Trapinch",
        type1: Ground,
        type2: Ground,
        baseHP: 45,
        baseAttack: 100,
        baseDefense: 45,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 10,
        evYield: Attack,
        evolution: Evolution.Trapinch,
        xpClass: MediumSlow,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "trapinch", //Verify
        graphicsLocation: "trapinch", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Trapinch,
        abilities: new Ability[3]
        {
            HyperCutter,
            ArenaTrap,
            SheerForce,
        }
    );
    public static readonly SpeciesData Vibrava = new(
        speciesName: "Vibrava",
        type1: Ground,
        type2: Dragon,
        baseHP: 50,
        baseAttack: 70,
        baseDefense: 50,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 70,
        evYield: Attack + Speed,
        evolution: Evolution.Vibrava,
        xpClass: MediumSlow,
        xpYield: 119,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "vibrava", //Verify
        graphicsLocation: "vibrava", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Vibrava,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Flygon = new(
        speciesName: "Flygon",
        type1: Ground,
        type2: Dragon,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 80,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 100,
        evYield: Attack + 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 234,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "flygon", //Verify
        graphicsLocation: "flygon", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Flygon,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Cacnea = new(
        speciesName: "Cacnea",
        type1: Grass,
        type2: Grass,
        baseHP: 50,
        baseAttack: 85,
        baseDefense: 40,
        baseSpAtk: 85,
        baseSpDef: 40,
        baseSpeed: 35,
        evYield: SpAtk,
        evolution: Evolution.Cacnea,
        xpClass: MediumSlow,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 35,
        cryLocation: "cacnea", //Verify
        graphicsLocation: "cacnea", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Cacnea,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Cacturne = new(
        speciesName: "Cacturne",
        type1: Grass,
        type2: Dark,
        baseHP: 70,
        baseAttack: 115,
        baseDefense: 60,
        baseSpAtk: 115,
        baseSpDef: 60,
        baseSpeed: 55,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "cacturne", //Verify
        graphicsLocation: "cacturne", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Cacturne,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Swablu = new(
        speciesName: "Swablu",
        type1: Normal,
        type2: Flying,
        baseHP: 45,
        baseAttack: 40,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 75,
        baseSpeed: 50,
        evYield: SpDef,
        evolution: Evolution.Swablu,
        xpClass: Erratic,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "swablu", //Verify
        graphicsLocation: "swablu", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Swablu,
        abilities: new Ability[3]
        {
            NaturalCure,
            NaturalCure,
            CloudNine,
        }
    );
    public static readonly SpeciesData Altaria = new(
        speciesName: "Altaria",
        type1: Dragon,
        type2: Flying,
        baseHP: 75,
        baseAttack: 70,
        baseDefense: 90,
        baseSpAtk: 70,
        baseSpDef: 105,
        baseSpeed: 80,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "altaria", //Verify
        graphicsLocation: "altaria", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Altaria,
        abilities: new Ability[3]
        {
            NaturalCure,
            NaturalCure,
            CloudNine,
        }
    );
    public static readonly SpeciesData Zangoose = new(
        speciesName: "Zangoose",
        type1: Normal,
        type2: Normal,
        baseHP: 73,
        baseAttack: 115,
        baseDefense: 60,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 90,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 160,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "zangoose", //Verify
        graphicsLocation: "zangoose", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Zangoose,
        abilities: new Ability[3]
        {
            Immunity,
            Immunity,
            ToxicBoost,
        }
    );
    public static readonly SpeciesData Seviper = new(
        speciesName: "Seviper",
        type1: Poison,
        type2: Poison,
        baseHP: 73,
        baseAttack: 100,
        baseDefense: 60,
        baseSpAtk: 100,
        baseSpDef: 60,
        baseSpeed: 65,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 160,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "seviper", //Verify
        graphicsLocation: "seviper", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Seviper,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Lunatone = new(
        speciesName: "Lunatone",
        type1: Rock,
        type2: Psychic,
        baseHP: 90,
        baseAttack: 55,
        baseDefense: 65,
        baseSpAtk: 95,
        baseSpDef: 85,
        baseSpeed: 70,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "lunatone", //Verify
        graphicsLocation: "lunatone", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Lunatone,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Solrock = new(
        speciesName: "Solrock",
        type1: Rock,
        type2: Psychic,
        baseHP: 90,
        baseAttack: 95,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "solrock", //Verify
        graphicsLocation: "solrock", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Solrock,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Barboach = new(
        speciesName: "Barboach",
        type1: Water,
        type2: Ground,
        baseHP: 50,
        baseAttack: 48,
        baseDefense: 43,
        baseSpAtk: 46,
        baseSpDef: 41,
        baseSpeed: 60,
        evYield: HP,
        evolution: Evolution.Barboach,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "barboach", //Verify
        graphicsLocation: "barboach", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Barboach,
        abilities: new Ability[3]
        {
            Oblivious,
            Anticipation,
            Hydration,
        }
    );
    public static readonly SpeciesData Whiscash = new(
        speciesName: "Whiscash",
        type1: Water,
        type2: Ground,
        baseHP: 110,
        baseAttack: 78,
        baseDefense: 73,
        baseSpAtk: 76,
        baseSpDef: 71,
        baseSpeed: 60,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 164,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "whiscash", //Verify
        graphicsLocation: "whiscash", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Whiscash,
        abilities: new Ability[3]
        {
            Oblivious,
            Anticipation,
            Hydration,
        }
    );
    public static readonly SpeciesData Corphish = new(
        speciesName: "Corphish",
        type1: Water,
        type2: Water,
        baseHP: 43,
        baseAttack: 80,
        baseDefense: 65,
        baseSpAtk: 50,
        baseSpDef: 35,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Corphish,
        xpClass: Fluctuating,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 15,
        catchRate: 205,
        baseFriendship: 70,
        cryLocation: "corphish", //Verify
        graphicsLocation: "corphish", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Corphish,
        abilities: new Ability[3]
        {
            HyperCutter,
            ShellArmor,
            Adaptability,
        }
    );
    public static readonly SpeciesData Crawdaunt = new(
        speciesName: "Crawdaunt",
        type1: Water,
        type2: Dark,
        baseHP: 63,
        baseAttack: 120,
        baseDefense: 85,
        baseSpAtk: 90,
        baseSpDef: 55,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 164,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 15,
        catchRate: 155,
        baseFriendship: 70,
        cryLocation: "crawdaunt", //Verify
        graphicsLocation: "crawdaunt", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Crawdaunt,
        abilities: new Ability[3]
        {
            HyperCutter,
            ShellArmor,
            Adaptability,
        }
    );
    public static readonly SpeciesData Baltoy = new(
        speciesName: "Baltoy",
        type1: Ground,
        type2: Psychic,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 70,
        baseSpeed: 55,
        evYield: SpDef,
        evolution: Evolution.Baltoy,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "baltoy", //Verify
        graphicsLocation: "baltoy", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Baltoy,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Claydol = new(
        speciesName: "Claydol",
        type1: Ground,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 70,
        baseDefense: 105,
        baseSpAtk: 70,
        baseSpDef: 120,
        baseSpeed: 75,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "claydol", //Verify
        graphicsLocation: "claydol", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Claydol,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Lileep = new(
        speciesName: "Lileep",
        type1: Rock,
        type2: Grass,
        baseHP: 66,
        baseAttack: 41,
        baseDefense: 77,
        baseSpAtk: 61,
        baseSpDef: 87,
        baseSpeed: 23,
        evYield: SpDef,
        evolution: Evolution.Lileep,
        xpClass: Erratic,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "lileep", //Verify
        graphicsLocation: "lileep", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Lileep,
        abilities: new Ability[3]
        {
            SuctionCups,
            SuctionCups,
            StormDrain,
        }
    );
    public static readonly SpeciesData Cradily = new(
        speciesName: "Cradily",
        type1: Rock,
        type2: Grass,
        baseHP: 86,
        baseAttack: 81,
        baseDefense: 97,
        baseSpAtk: 81,
        baseSpDef: 107,
        baseSpeed: 43,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "cradily", //Verify
        graphicsLocation: "cradily", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Cradily,
        abilities: new Ability[3]
        {
            SuctionCups,
            SuctionCups,
            StormDrain,
        }
    );
    public static readonly SpeciesData Anorith = new(
        speciesName: "Anorith",
        type1: Rock,
        type2: Bug,
        baseHP: 45,
        baseAttack: 95,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 75,
        evYield: Attack,
        evolution: Evolution.Anorith,
        xpClass: Erratic,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "anorith", //Verify
        graphicsLocation: "anorith", //Verify
        backSpriteHeight: 19,
        pokedexData: Pokedex.Anorith,
        abilities: new Ability[3]
        {
            BattleArmor,
            BattleArmor,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Armaldo = new(
        speciesName: "Armaldo",
        type1: Rock,
        type2: Bug,
        baseHP: 75,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 45,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "armaldo", //Verify
        graphicsLocation: "armaldo", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Armaldo,
        abilities: new Ability[3]
        {
            BattleArmor,
            BattleArmor,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Feebas = new(
        speciesName: "Feebas",
        type1: Water,
        type2: Water,
        baseHP: 20,
        baseAttack: 15,
        baseDefense: 20,
        baseSpAtk: 10,
        baseSpDef: 55,
        baseSpeed: 80,
        evYield: Speed,
        evolution: Evolution.Feebas,
        xpClass: Erratic,
        xpYield: 40,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "feebas", //Verify
        graphicsLocation: "feebas", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Feebas,
        abilities: new Ability[3]
        {
            SwiftSwim,
            Oblivious,
            Adaptability,
        }
    );
    public static readonly SpeciesData Milotic = new(
        speciesName: "Milotic",
        type1: Water,
        type2: Water,
        baseHP: 95,
        baseAttack: 60,
        baseDefense: 79,
        baseSpAtk: 100,
        baseSpDef: 125,
        baseSpeed: 81,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "milotic", //Verify
        graphicsLocation: "milotic", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Milotic,
        abilities: new Ability[3]
        {
            MarvelScale,
            Competitive,
            CuteCharm,
        }
    );

    public static readonly SpeciesData Castform = Castform(
        Normal, "castform/normal", 0);

    public static readonly SpeciesData Kecleon = new(
        speciesName: "Kecleon",
        type1: Normal,
        type2: Normal,
        baseHP: 60,
        baseAttack: 90,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 120,
        baseSpeed: 40,
        evYield: SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "kecleon", //Verify
        graphicsLocation: "kecleon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kecleon,
        abilities: new Ability[3]
        {
            ColorChange,
            ColorChange,
            Protean,
        }
    );
    public static readonly SpeciesData Shuppet = new(
        speciesName: "Shuppet",
        type1: Ghost,
        type2: Ghost,
        baseHP: 44,
        baseAttack: 75,
        baseDefense: 35,
        baseSpAtk: 63,
        baseSpDef: 33,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Shuppet,
        xpClass: Fast,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 225,
        baseFriendship: 35,
        cryLocation: "shuppet", //Verify
        graphicsLocation: "shuppet", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Shuppet,
        abilities: new Ability[3]
        {
            Insomnia,
            Frisk,
            CursedBody,
        }
    );
    public static readonly SpeciesData Banette = new(
        speciesName: "Banette",
        type1: Ghost,
        type2: Ghost,
        baseHP: 64,
        baseAttack: 115,
        baseDefense: 65,
        baseSpAtk: 83,
        baseSpDef: 63,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "banette", //Verify
        graphicsLocation: "banette", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Banette,
        abilities: new Ability[3]
        {
            Insomnia,
            Frisk,
            CursedBody,
        }
    );
    public static readonly SpeciesData Duskull = new(
        speciesName: "Duskull",
        type1: Ghost,
        type2: Ghost,
        baseHP: 20,
        baseAttack: 40,
        baseDefense: 90,
        baseSpAtk: 30,
        baseSpDef: 90,
        baseSpeed: 25,
        evYield: SpDef,
        evolution: Evolution.Duskull,
        xpClass: Fast,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 190,
        baseFriendship: 35,
        cryLocation: "duskull", //Verify
        graphicsLocation: "duskull", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Duskull,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Frisk,
        }
    );
    public static readonly SpeciesData Dusclops = new(
        speciesName: "Dusclops",
        type1: Ghost,
        type2: Ghost,
        baseHP: 40,
        baseAttack: 70,
        baseDefense: 130,
        baseSpAtk: 60,
        baseSpDef: 130,
        baseSpeed: 25,
        evYield: Defense + SpDef,
        evolution: Evolution.Dusclops, //Not done
        xpClass: Fast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 90,
        baseFriendship: 35,
        cryLocation: "dusclops", //Verify
        graphicsLocation: "dusclops", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Dusclops,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Frisk,
        }
    );
    public static readonly SpeciesData Tropius = new(
        speciesName: "Tropius",
        type1: Grass,
        type2: Flying,
        baseHP: 99,
        baseAttack: 68,
        baseDefense: 83,
        baseSpAtk: 72,
        baseSpDef: 87,
        baseSpeed: 51,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 25,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "tropius", //Verify
        graphicsLocation: "tropius", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Tropius,
        abilities: new Ability[3]
        {
            Chlorophyll,
            SolarPower,
            Harvest,
        }
    );
    public static readonly SpeciesData Chimecho = new(
        speciesName: "Chimecho",
        type1: Psychic,
        type2: Psychic,
        baseHP: 75,
        baseAttack: 50,
        baseDefense: 80,
        baseSpAtk: 95,
        baseSpDef: 90,
        baseSpeed: 65,
        evYield: SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chimecho", //Verify
        graphicsLocation: "chimecho", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Chimecho,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Absol = new(
        speciesName: "Absol",
        type1: Dark,
        type2: Dark,
        baseHP: 65,
        baseAttack: 130,
        baseDefense: 60,
        baseSpAtk: 75,
        baseSpDef: 60,
        baseSpeed: 75,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 25,
        catchRate: 30,
        baseFriendship: 35,
        cryLocation: "absol", //Verify
        graphicsLocation: "absol", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Absol,
        abilities: new Ability[3]
        {
            Pressure,
            SuperLuck,
            Justified,
        }
    );
    public static readonly SpeciesData Wynaut = new(
        speciesName: "Wynaut",
        type1: Psychic,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 23,
        baseDefense: 48,
        baseSpAtk: 23,
        baseSpDef: 48,
        baseSpeed: 23,
        evYield: HP,
        evolution: Evolution.Wynaut,
        xpClass: MediumFast,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 20,
        catchRate: 125,
        baseFriendship: 70,
        cryLocation: "wynaut", //Verify
        graphicsLocation: "wynaut", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Wynaut,
        abilities: new Ability[3]
        {
            ShadowTag,
            ShadowTag,
            Telepathy,
        }
    );
    public static readonly SpeciesData Snorunt = new(
        speciesName: "Snorunt",
        type1: Ice,
        type2: Ice,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 50,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 50,
        evYield: HP,
        evolution: Evolution.Snorunt,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "snorunt", //Verify
        graphicsLocation: "snorunt", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Snorunt,
        abilities: new Ability[3]
        {
            InnerFocus,
            IceBody,
            Moody,
        }
    );
    public static readonly SpeciesData Glalie = new(
        speciesName: "Glalie",
        type1: Ice,
        type2: Ice,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 80,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "glalie", //Verify
        graphicsLocation: "glalie", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Glalie,
        abilities: new Ability[3]
        {
            InnerFocus,
            IceBody,
            Moody,
        }
    );
    public static readonly SpeciesData Spheal = new(
        speciesName: "Spheal",
        type1: Ice,
        type2: Water,
        baseHP: 70,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 50,
        baseSpeed: 25,
        evYield: HP,
        evolution: Evolution.Spheal,
        xpClass: MediumSlow,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "spheal", //Verify
        graphicsLocation: "spheal", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Spheal,
        abilities: new Ability[3]
        {
            ThickFat,
            IceBody,
            Oblivious,
        }
    );
    public static readonly SpeciesData Sealeo = new(
        speciesName: "Sealeo",
        type1: Ice,
        type2: Water,
        baseHP: 90,
        baseAttack: 60,
        baseDefense: 70,
        baseSpAtk: 75,
        baseSpDef: 70,
        baseSpeed: 45,
        evYield: 2 * HP,
        evolution: Evolution.Sealeo,
        xpClass: MediumSlow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "sealeo", //Verify
        graphicsLocation: "sealeo", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Sealeo,
        abilities: new Ability[3]
        {
            ThickFat,
            IceBody,
            Oblivious,
        }
    );
    public static readonly SpeciesData Walrein = new(
        speciesName: "Walrein",
        type1: Ice,
        type2: Water,
        baseHP: 110,
        baseAttack: 80,
        baseDefense: 90,
        baseSpAtk: 95,
        baseSpDef: 90,
        baseSpeed: 65,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "walrein", //Verify
        graphicsLocation: "walrein", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Walrein,
        abilities: new Ability[3]
        {
            ThickFat,
            IceBody,
            Oblivious,
        }
    );
    public static readonly SpeciesData Clamperl = new(
        speciesName: "Clamperl",
        type1: Water,
        type2: Water,
        baseHP: 35,
        baseAttack: 64,
        baseDefense: 85,
        baseSpAtk: 74,
        baseSpDef: 55,
        baseSpeed: 32,
        evYield: Defense,
        evolution: Evolution.Clamperl,
        xpClass: Erratic,
        xpYield: 69,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "clamperl", //Verify
        graphicsLocation: "clamperl", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Clamperl,
        abilities: new Ability[3]
        {
            ShellArmor,
            ShellArmor,
            Rattled,
        }
    );
    public static readonly SpeciesData Huntail = new(
        speciesName: "Huntail",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 104,
        baseDefense: 105,
        baseSpAtk: 94,
        baseSpDef: 75,
        baseSpeed: 52,
        evYield: Attack + Defense,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "huntail", //Verify
        graphicsLocation: "huntail", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Huntail,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Gorebyss = new(
        speciesName: "Gorebyss",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 84,
        baseDefense: 105,
        baseSpAtk: 114,
        baseSpDef: 75,
        baseSpeed: 52,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "gorebyss", //Verify
        graphicsLocation: "gorebyss", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Gorebyss,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            Hydration,
        }
    );
    public static readonly SpeciesData Relicanth = new(
        speciesName: "Relicanth",
        type1: Water,
        type2: Rock,
        baseHP: 100,
        baseAttack: 90,
        baseDefense: 130,
        baseSpAtk: 45,
        baseSpDef: 65,
        baseSpeed: 55,
        evYield: HP + Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "relicanth", //Verify
        graphicsLocation: "relicanth", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Relicanth,
        abilities: new Ability[3]
        {
            SwiftSwim,
            RockHead,
            Sturdy,
        }
    );
    public static readonly SpeciesData Luvdisc = new(
        speciesName: "Luvdisc",
        type1: Water,
        type2: Water,
        baseHP: 43,
        baseAttack: 30,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 65,
        baseSpeed: 97,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 116,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "luvdisc", //Verify
        graphicsLocation: "luvdisc", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Luvdisc,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            Hydration,
        }
    );
    public static readonly SpeciesData Bagon = new(
        speciesName: "Bagon",
        type1: Dragon,
        type2: Dragon,
        baseHP: 45,
        baseAttack: 75,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 30,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Bagon,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "bagon", //Verify
        graphicsLocation: "bagon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bagon,
        abilities: new Ability[3]
        {
            RockHead,
            RockHead,
            SheerForce,
        }
    );
    public static readonly SpeciesData Shelgon = new(
        speciesName: "Shelgon",
        type1: Dragon,
        type2: Dragon,
        baseHP: 65,
        baseAttack: 95,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 50,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.Shelgon,
        xpClass: Slow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "shelgon", //Verify
        graphicsLocation: "shelgon", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Shelgon,
        abilities: new Ability[3]
        {
            RockHead,
            RockHead,
            Overcoat,
        }
    );
    public static readonly SpeciesData Salamence = new(
        speciesName: "Salamence",
        type1: Dragon,
        type2: Flying,
        baseHP: 95,
        baseAttack: 135,
        baseDefense: 80,
        baseSpAtk: 110,
        baseSpDef: 80,
        baseSpeed: 100,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "salamence", //Verify
        graphicsLocation: "salamence", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Salamence,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Moxie,
        }
    );
    public static readonly SpeciesData Beldum = new(
        speciesName: "Beldum",
        type1: Steel,
        type2: Psychic,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 80,
        baseSpAtk: 35,
        baseSpDef: 60,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Beldum,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 40,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "beldum", //Verify
        graphicsLocation: "beldum", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Beldum,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            LightMetal,
        }
    );
    public static readonly SpeciesData Metang = new(
        speciesName: "Metang",
        type1: Steel,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 75,
        baseDefense: 100,
        baseSpAtk: 55,
        baseSpDef: 80,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.Metang,
        xpClass: Slow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 40,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "metang", //Verify
        graphicsLocation: "metang", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Metang,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            LightMetal,
        }
    );
    public static readonly SpeciesData Metagross = new(
        speciesName: "Metagross",
        type1: Steel,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 135,
        baseDefense: 130,
        baseSpAtk: 95,
        baseSpDef: 90,
        baseSpeed: 70,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 40,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "metagross", //Verify
        graphicsLocation: "metagross", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Metagross,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            LightMetal,
        }
    );
    public static readonly SpeciesData Regirock = new(
        speciesName: "Regirock",
        type1: Rock,
        type2: Rock,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 200,
        baseSpAtk: 50,
        baseSpDef: 100,
        baseSpeed: 50,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "regirock", //Verify
        graphicsLocation: "regirock", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Regirock,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            Sturdy,
        }
    );
    public static readonly SpeciesData Regice = new(
        speciesName: "Regice",
        type1: Ice,
        type2: Ice,
        baseHP: 80,
        baseAttack: 50,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 200,
        baseSpeed: 50,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "regice", //Verify
        graphicsLocation: "regice", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Regice,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            IceBody,
        }
    );
    public static readonly SpeciesData Registeel = new(
        speciesName: "Registeel",
        type1: Steel,
        type2: Steel,
        baseHP: 80,
        baseAttack: 75,
        baseDefense: 150,
        baseSpAtk: 75,
        baseSpDef: 150,
        baseSpeed: 50,
        evYield: 2 * Defense + SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "registeel", //Verify
        graphicsLocation: "registeel", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Registeel,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            LightMetal,
        }
    );
    public static readonly SpeciesData Latias = new(
        speciesName: "Latias",
        type1: Dragon,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 90,
        baseSpAtk: 110,
        baseSpDef: 130,
        baseSpeed: 110,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "latias", //Verify
        graphicsLocation: "latias", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Latias,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Latios = new(
        speciesName: "Latios",
        type1: Dragon,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 90,
        baseDefense: 80,
        baseSpAtk: 130,
        baseSpDef: 110,
        baseSpeed: 110,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "latios", //Verify
        graphicsLocation: "latios", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Latios,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Kyogre = new(
        speciesName: "Kyogre",
        type1: Water,
        type2: Water,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 90,
        baseSpAtk: 150,
        baseSpDef: 140,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 302,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "kyogre", //Verify
        graphicsLocation: "kyogre", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Kyogre,
        abilities: new Ability[3]
        {
            Drizzle,
            Drizzle,
            Drizzle,
        }
    );
    public static readonly SpeciesData Groudon = new(
        speciesName: "Groudon",
        type1: Ground,
        type2: Ground,
        baseHP: 100,
        baseAttack: 150,
        baseDefense: 140,
        baseSpAtk: 100,
        baseSpDef: 90,
        baseSpeed: 90,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 302,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "groudon", //Verify
        graphicsLocation: "groudon", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Groudon,
        abilities: new Ability[3]
        {
            Drought,
            Drought,
            Drought,
        }
    );
    public static readonly SpeciesData Rayquaza = new(
        speciesName: "Rayquaza",
        type1: Dragon,
        type2: Flying,
        baseHP: 105,
        baseAttack: 150,
        baseDefense: 90,
        baseSpAtk: 150,
        baseSpDef: 90,
        baseSpeed: 95,
        evYield: 2 * Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "rayquaza", //Verify
        graphicsLocation: "rayquaza", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Rayquaza,
        abilities: new Ability[3]
        {
            AirLock,
            AirLock,
            AirLock,
        }
    );
    public static readonly SpeciesData Jirachi = new(
        speciesName: "Jirachi",
        type1: Steel,
        type2: Psychic,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "jirachi", //Verify
        graphicsLocation: "jirachi", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Jirachi,
        abilities: new Ability[3]
        {
            SereneGrace,
            SereneGrace,
            SereneGrace,
        }
    );

    public static readonly SpeciesData Deoxys =
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

    public static readonly SpeciesData Turtwig = new(
        speciesName: "Turtwig",
        type1: Grass,
        type2: Grass,
        baseHP: 55,
        baseAttack: 68,
        baseDefense: 64,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 31,
        evYield: Attack,
        evolution: Evolution.Turtwig,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "turtwig", //Verify
        graphicsLocation: "turtwig", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Turtwig,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Grotle = new(
        speciesName: "Grotle",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 89,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 36,
        evYield: Attack + Defense,
        evolution: Evolution.Grotle,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "grotle", //Verify
        graphicsLocation: "grotle", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Grotle,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Torterra = new(
        speciesName: "Torterra",
        type1: Grass,
        type2: Ground,
        baseHP: 95,
        baseAttack: 109,
        baseDefense: 105,
        baseSpAtk: 75,
        baseSpDef: 85,
        baseSpeed: 56,
        evYield: 2 * Attack + Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 236,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "torterra", //Verify
        graphicsLocation: "torterra", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Torterra,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Chimchar = new(
        speciesName: "Chimchar",
        type1: Fire,
        type2: Fire,
        baseHP: 44,
        baseAttack: 58,
        baseDefense: 44,
        baseSpAtk: 58,
        baseSpDef: 44,
        baseSpeed: 61,
        evYield: Speed,
        evolution: Evolution.Chimchar,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chimchar", //Verify
        graphicsLocation: "chimchar", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Chimchar,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        }
    );
    public static readonly SpeciesData Monferno = new(
        speciesName: "Monferno",
        type1: Fire,
        type2: Fighting,
        baseHP: 64,
        baseAttack: 78,
        baseDefense: 52,
        baseSpAtk: 78,
        baseSpDef: 52,
        baseSpeed: 81,
        evYield: Speed + SpAtk,
        evolution: Evolution.Monferno,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "monferno", //Verify
        graphicsLocation: "monferno", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Monferno,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        }
    );
    public static readonly SpeciesData Infernape = new(
        speciesName: "Infernape",
        type1: Fire,
        type2: Fighting,
        baseHP: 76,
        baseAttack: 104,
        baseDefense: 71,
        baseSpAtk: 104,
        baseSpDef: 71,
        baseSpeed: 108,
        evYield: Attack + Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 240,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "infernape", //Verify
        graphicsLocation: "infernape", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Infernape,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            IronFist,
        }
    );
    public static readonly SpeciesData Piplup = new(
        speciesName: "Piplup",
        type1: Water,
        type2: Water,
        baseHP: 53,
        baseAttack: 51,
        baseDefense: 53,
        baseSpAtk: 61,
        baseSpDef: 56,
        baseSpeed: 40,
        evYield: SpAtk,
        evolution: Evolution.Piplup,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "piplup", //Verify
        graphicsLocation: "piplup", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Piplup,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        }
    );
    public static readonly SpeciesData Prinplup = new(
        speciesName: "Prinplup",
        type1: Water,
        type2: Water,
        baseHP: 64,
        baseAttack: 66,
        baseDefense: 68,
        baseSpAtk: 81,
        baseSpDef: 76,
        baseSpeed: 50,
        evYield: 2 * SpAtk,
        evolution: Evolution.Prinplup,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "prinplup", //Verify
        graphicsLocation: "prinplup", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Prinplup,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        }
    );
    public static readonly SpeciesData Empoleon = new(
        speciesName: "Empoleon",
        type1: Water,
        type2: Steel,
        baseHP: 84,
        baseAttack: 86,
        baseDefense: 88,
        baseSpAtk: 111,
        baseSpDef: 101,
        baseSpeed: 60,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "empoleon", //Verify
        graphicsLocation: "empoleon", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Empoleon,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Defiant,
        }
    );
    public static readonly SpeciesData Starly = new(
        speciesName: "Starly",
        type1: Normal,
        type2: Flying,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 30,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 60,
        evYield: Speed,
        evolution: Evolution.Starly,
        xpClass: MediumSlow,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "starly", //Verify
        graphicsLocation: "starly", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Starly,
        abilities: new Ability[3]
        {
            KeenEye,
            KeenEye,
            Reckless,
        }
    );
    public static readonly SpeciesData Staravia = new(
        speciesName: "Staravia",
        type1: Normal,
        type2: Flying,
        baseHP: 55,
        baseAttack: 75,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 80,
        evYield: 2 * Speed,
        evolution: Evolution.Staravia,
        xpClass: MediumSlow,
        xpYield: 119,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "staravia", //Verify
        graphicsLocation: "staravia", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Staravia,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Reckless,
        }
    );
    public static readonly SpeciesData Staraptor = new(
        speciesName: "Staraptor",
        type1: Normal,
        type2: Flying,
        baseHP: 85,
        baseAttack: 120,
        baseDefense: 70,
        baseSpAtk: 50,
        baseSpDef: 60,
        baseSpeed: 100,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 218,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "staraptor", //Verify
        graphicsLocation: "staraptor", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Staraptor,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Reckless,
        }
    );
    public static readonly SpeciesData Bidoof = new(
        speciesName: "Bidoof",
        type1: Normal,
        type2: Normal,
        baseHP: 59,
        baseAttack: 45,
        baseDefense: 40,
        baseSpAtk: 35,
        baseSpDef: 40,
        baseSpeed: 31,
        evYield: HP,
        evolution: Evolution.Bidoof,
        xpClass: MediumFast,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "bidoof", //Verify
        graphicsLocation: "bidoof", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Bidoof,
        abilities: new Ability[3]
        {
            Simple,
            Unaware,
            Moody,
        }
    );
    public static readonly SpeciesData Bibarel = new(
        speciesName: "Bibarel",
        type1: Normal,
        type2: Water,
        baseHP: 79,
        baseAttack: 85,
        baseDefense: 60,
        baseSpAtk: 55,
        baseSpDef: 60,
        baseSpeed: 71,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "bibarel", //Verify
        graphicsLocation: "bibarel", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bibarel,
        abilities: new Ability[3]
        {
            Simple,
            Unaware,
            Moody,
        }
    );
    public static readonly SpeciesData Kricketot = new(
        speciesName: "Kricketot",
        type1: Bug,
        type2: Bug,
        baseHP: 37,
        baseAttack: 25,
        baseDefense: 41,
        baseSpAtk: 25,
        baseSpDef: 41,
        baseSpeed: 25,
        evYield: Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 39,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "kricketot", //Verify
        graphicsLocation: "kricketot", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kricketot,
        abilities: new Ability[3]
        {
            ShedSkin,
            ShedSkin,
            RunAway,
        }
    );
    public static readonly SpeciesData Kricketune = new(
        speciesName: "Kricketune",
        type1: Bug,
        type2: Bug,
        baseHP: 77,
        baseAttack: 85,
        baseDefense: 51,
        baseSpAtk: 55,
        baseSpDef: 51,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 134,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kricketune", //Verify
        graphicsLocation: "kricketune", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Kricketune,
        abilities: new Ability[3]
        {
            Swarm,
            Swarm,
            Technician,
        }
    );
    public static readonly SpeciesData Shinx = new(
        speciesName: "Shinx",
        type1: Electric,
        type2: Electric,
        baseHP: 45,
        baseAttack: 65,
        baseDefense: 34,
        baseSpAtk: 40,
        baseSpDef: 34,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Shinx,
        xpClass: MediumSlow,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "shinx", //Verify
        graphicsLocation: "shinx", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Shinx,
        abilities: new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        }
    );
    public static readonly SpeciesData Luxio = new(
        speciesName: "Luxio",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 49,
        baseSpAtk: 60,
        baseSpDef: 49,
        baseSpeed: 60,
        evYield: 2 * Attack,
        evolution: Evolution.Luxio,
        xpClass: MediumSlow,
        xpYield: 127,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 100,
        cryLocation: "luxio", //Verify
        graphicsLocation: "luxio", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Luxio,
        abilities: new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        }
    );
    public static readonly SpeciesData Luxray = new(
        speciesName: "Luxray",
        type1: Electric,
        type2: Electric,
        baseHP: 80,
        baseAttack: 120,
        baseDefense: 79,
        baseSpAtk: 95,
        baseSpDef: 79,
        baseSpeed: 70,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 235,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "luxray", //Verify
        graphicsLocation: "luxray", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Luxray,
        abilities: new Ability[3]
        {
            Rivalry,
            Intimidate,
            Guts,
        }
    );
    public static readonly SpeciesData Budew = new(
        speciesName: "Budew",
        type1: Grass,
        type2: Poison,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 35,
        baseSpAtk: 50,
        baseSpDef: 70,
        baseSpeed: 55,
        evYield: SpAtk,
        evolution: Evolution.Budew,
        xpClass: MediumSlow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "budew", //Verify
        graphicsLocation: "budew", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Budew,
        abilities: new Ability[3]
        {
            NaturalCure,
            PoisonPoint,
            LeafGuard,
        }
    );
    public static readonly SpeciesData Roserade = new(
        speciesName: "Roserade",
        type1: Grass,
        type2: Poison,
        baseHP: 60,
        baseAttack: 70,
        baseDefense: 65,
        baseSpAtk: 125,
        baseSpDef: 105,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 232,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "roserade", //Verify
        graphicsLocation: "roserade", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Roserade,
        abilities: new Ability[3]
        {
            NaturalCure,
            PoisonPoint,
            Technician,
        }
    );
    public static readonly SpeciesData Cranidos = new(
        speciesName: "Cranidos",
        type1: Rock,
        type2: Rock,
        baseHP: 67,
        baseAttack: 125,
        baseDefense: 40,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 58,
        evYield: Attack,
        evolution: Evolution.Cranidos,
        xpClass: Erratic,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "cranidos", //Verify
        graphicsLocation: "cranidos", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Cranidos,
        abilities: new Ability[3]
        {
            MoldBreaker,
            MoldBreaker,
            SheerForce,
        }
    );
    public static readonly SpeciesData Rampardos = new(
        speciesName: "Rampardos",
        type1: Rock,
        type2: Rock,
        baseHP: 97,
        baseAttack: 165,
        baseDefense: 60,
        baseSpAtk: 65,
        baseSpDef: 50,
        baseSpeed: 58,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "rampardos", //Verify
        graphicsLocation: "rampardos", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Rampardos,
        abilities: new Ability[3]
        {
            MoldBreaker,
            MoldBreaker,
            SheerForce,
        }
    );
    public static readonly SpeciesData Shieldon = new(
        speciesName: "Shieldon",
        type1: Rock,
        type2: Steel,
        baseHP: 30,
        baseAttack: 42,
        baseDefense: 118,
        baseSpAtk: 42,
        baseSpDef: 88,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Shieldon,
        xpClass: Erratic,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "shieldon", //Verify
        graphicsLocation: "shieldon", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Shieldon,
        abilities: new Ability[3]
        {
            Sturdy,
            Sturdy,
            Soundproof,
        }
    );
    public static readonly SpeciesData Bastiodon = new(
        speciesName: "Bastiodon",
        type1: Rock,
        type2: Steel,
        baseHP: 60,
        baseAttack: 52,
        baseDefense: 168,
        baseSpAtk: 47,
        baseSpDef: 138,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "bastiodon", //Verify
        graphicsLocation: "bastiodon", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bastiodon,
        abilities: new Ability[3]
        {
            Sturdy,
            Sturdy,
            Soundproof,
        }
    );

    public static readonly SpeciesData Burmy = Burmy(
        graphics: "burmy",
        backSpriteHeight: 6,
        evolution: Evolution.Burmy
    );
    public static readonly SpeciesData Wormadam = Wormadam(
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
    public static readonly SpeciesData Mothim = new(
        speciesName: "Mothim",
        type1: Bug,
        type2: Flying,
        baseHP: 70,
        baseAttack: 94,
        baseDefense: 50,
        baseSpAtk: 94,
        baseSpDef: 50,
        baseSpeed: 66,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 148,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mothim", //Verify
        graphicsLocation: "mothim", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Mothim,
        abilities: new Ability[3]
        {
            Swarm,
            Swarm,
            TintedLens,
        }
    );
    public static readonly SpeciesData Combee = new(
        speciesName: "Combee",
        type1: Bug,
        type2: Flying,
        baseHP: 30,
        baseAttack: 30,
        baseDefense: 42,
        baseSpAtk: 30,
        baseSpDef: 42,
        baseSpeed: 70,
        evYield: Speed,
        evolution: Evolution.Combee,
        xpClass: MediumSlow,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "combee", //Verify
        graphicsLocation: "combee", //Verify
        backSpriteHeight: 22,
        pokedexData: Pokedex.Combee,
        abilities: new Ability[3]
        {
            HoneyGather,
            HoneyGather,
            Hustle,
        }
    );
    public static readonly SpeciesData Vespiquen = new(
        speciesName: "Vespiquen",
        type1: Bug,
        type2: Flying,
        baseHP: 70,
        baseAttack: 80,
        baseDefense: 102,
        baseSpAtk: 80,
        baseSpDef: 102,
        baseSpeed: 40,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vespiquen", //Verify
        graphicsLocation: "vespiquen", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Vespiquen,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Unnerve,
        }
    );
    public static readonly SpeciesData Pachirisu = new(
        speciesName: "Pachirisu",
        type1: Electric,
        type2: Electric,
        baseHP: 60,
        baseAttack: 45,
        baseDefense: 70,
        baseSpAtk: 45,
        baseSpDef: 90,
        baseSpeed: 95,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 200,
        baseFriendship: 100,
        cryLocation: "pachirisu", //Verify
        graphicsLocation: "pachirisu", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Pachirisu,
        abilities: new Ability[3]
        {
            RunAway,
            Pickup,
            VoltAbsorb,
        }
    );
    public static readonly SpeciesData Buizel = new(
        speciesName: "Buizel",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 65,
        baseDefense: 35,
        baseSpAtk: 60,
        baseSpDef: 30,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Buizel,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "buizel", //Verify
        graphicsLocation: "buizel", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Buizel,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Floatzel = new(
        speciesName: "Floatzel",
        type1: Water,
        type2: Water,
        baseHP: 85,
        baseAttack: 105,
        baseDefense: 55,
        baseSpAtk: 85,
        baseSpDef: 50,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "floatzel", //Verify
        graphicsLocation: "floatzel", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Floatzel,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Cherubi = new(
        speciesName: "Cherubi",
        type1: Grass,
        type2: Grass,
        baseHP: 45,
        baseAttack: 35,
        baseDefense: 45,
        baseSpAtk: 62,
        baseSpDef: 53,
        baseSpeed: 35,
        evYield: SpAtk,
        evolution: Evolution.Cherubi,
        xpClass: MediumFast,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "cherubi", //Verify
        graphicsLocation: "cherubi", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Cherubi,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Chlorophyll,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Cherrim = Cherrim("cherrim/normal", 9);
    public static readonly SpeciesData Shellos = Shellos("shellos", 8,
        Evolution.Shellos);
    public static readonly SpeciesData Gastrodon = Gastrodon("gastrodon", 3);
    public static readonly SpeciesData Ambipom = new(
        speciesName: "Ambipom",
        type1: Normal,
        type2: Normal,
        baseHP: 75,
        baseAttack: 100,
        baseDefense: 66,
        baseSpAtk: 60,
        baseSpDef: 66,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 100,
        cryLocation: "ambipom", //Verify
        graphicsLocation: "ambipom", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Ambipom,
        abilities: new Ability[3]
    {
            Technician,
            Pickup,
            SkillLink,
    }
    );
    public static readonly SpeciesData Drifloon = new(
        speciesName: "Drifloon",
        type1: Ghost,
        type2: Flying,
        baseHP: 90,
        baseAttack: 50,
        baseDefense: 34,
        baseSpAtk: 60,
        baseSpDef: 44,
        baseSpeed: 70,
        evYield: HP,
        evolution: Evolution.Drifloon,
        xpClass: Fluctuating,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 30,
        catchRate: 125,
        baseFriendship: 70,
        cryLocation: "drifloon", //Verify
        graphicsLocation: "drifloon", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Drifloon,
        abilities: new Ability[3]
        {
            Aftermath,
            Unburden,
            FlareBoost,
        }
    );
    public static readonly SpeciesData Drifblim = new(
        speciesName: "Drifblim",
        type1: Ghost,
        type2: Flying,
        baseHP: 150,
        baseAttack: 80,
        baseDefense: 44,
        baseSpAtk: 90,
        baseSpDef: 54,
        baseSpeed: 80,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fluctuating,
        xpYield: 174,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 30,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "drifblim", //Verify
        graphicsLocation: "drifblim", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Drifblim,
        abilities: new Ability[3]
        {
            Aftermath,
            Unburden,
            FlareBoost,
        }
    );
    public static readonly SpeciesData Buneary = new(
        speciesName: "Buneary",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 66,
        baseDefense: 44,
        baseSpAtk: 44,
        baseSpDef: 56,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Buneary,
        xpClass: MediumFast,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 0,
        cryLocation: "buneary", //Verify
        graphicsLocation: "buneary", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Buneary,
        abilities: new Ability[3]
        {
            RunAway,
            Klutz,
            Limber,
        }
    );
    public static readonly SpeciesData Lopunny = new(
        speciesName: "Lopunny",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 76,
        baseDefense: 84,
        baseSpAtk: 54,
        baseSpDef: 96,
        baseSpeed: 105,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 140,
        cryLocation: "lopunny", //Verify
        graphicsLocation: "lopunny", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Lopunny,
        abilities: new Ability[3]
        {
            CuteCharm,
            Klutz,
            Limber,
        }
    );
    public static readonly SpeciesData Mismagius = new(
        speciesName: "Mismagius",
        type1: Ghost,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 105,
        baseSpDef: 105,
        baseSpeed: 105,
        evYield: SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "mismagius", //Verify
        graphicsLocation: "mismagius", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Mismagius,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Honchkrow = new(
        speciesName: "Honchkrow",
        type1: Dark,
        type2: Flying,
        baseHP: 100,
        baseAttack: 125,
        baseDefense: 52,
        baseSpAtk: 105,
        baseSpDef: 52,
        baseSpeed: 71,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 35,
        cryLocation: "honchkrow", //Verify
        graphicsLocation: "honchkrow", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Honchkrow,
        abilities: new Ability[3]
        {
            Insomnia,
            SuperLuck,
            Moxie,
        }
    );
    public static readonly SpeciesData Glameow = new(
        speciesName: "Glameow",
        type1: Normal,
        type2: Normal,
        baseHP: 49,
        baseAttack: 55,
        baseDefense: 42,
        baseSpAtk: 42,
        baseSpDef: 37,
        baseSpeed: 85,
        evYield: Speed,
        evolution: Evolution.Glameow,
        xpClass: Fast,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "glameow", //Verify
        graphicsLocation: "glameow", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Glameow,
        abilities: new Ability[3]
        {
            Limber,
            OwnTempo,
            KeenEye,
        }
    );
    public static readonly SpeciesData Purugly = new(
        speciesName: "Purugly",
        type1: Normal,
        type2: Normal,
        baseHP: 71,
        baseAttack: 82,
        baseDefense: 64,
        baseSpAtk: 64,
        baseSpDef: 59,
        baseSpeed: 112,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "purugly", //Verify
        graphicsLocation: "purugly", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Purugly,
        abilities: new Ability[3]
        {
            ThickFat,
            OwnTempo,
            Defiant,
        }
    );
    public static readonly SpeciesData Chingling = new(
        speciesName: "Chingling",
        type1: Psychic,
        type2: Psychic,
        baseHP: 45,
        baseAttack: 30,
        baseDefense: 50,
        baseSpAtk: 65,
        baseSpDef: 50,
        baseSpeed: 45,
        evYield: SpAtk,
        evolution: Evolution.Chingling,
        xpClass: Fast,
        xpYield: 57,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "chingling", //Verify
        graphicsLocation: "chingling", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Chingling,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Stunky = new(
        speciesName: "Stunky",
        type1: Poison,
        type2: Dark,
        baseHP: 63,
        baseAttack: 63,
        baseDefense: 47,
        baseSpAtk: 41,
        baseSpDef: 41,
        baseSpeed: 74,
        evYield: Speed,
        evolution: Evolution.Stunky,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "stunky", //Verify
        graphicsLocation: "stunky", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Stunky,
        abilities: new Ability[3]
        {
            Stench,
            Aftermath,
            KeenEye,
        }
    );
    public static readonly SpeciesData Skuntank = new(
        speciesName: "Skuntank",
        type1: Poison,
        type2: Dark,
        baseHP: 103,
        baseAttack: 93,
        baseDefense: 67,
        baseSpAtk: 71,
        baseSpDef: 61,
        baseSpeed: 84,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "skuntank", //Verify
        graphicsLocation: "skuntank", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Skuntank,
        abilities: new Ability[3]
        {
            Stench,
            Aftermath,
            KeenEye,
        }
    );
    public static readonly SpeciesData Bronzor = new(
        speciesName: "Bronzor",
        type1: Steel,
        type2: Psychic,
        baseHP: 57,
        baseAttack: 24,
        baseDefense: 86,
        baseSpAtk: 24,
        baseSpDef: 86,
        baseSpeed: 23,
        evYield: Defense,
        evolution: Evolution.Bronzor,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "bronzor", //Verify
        graphicsLocation: "bronzor", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Bronzor,
        abilities: new Ability[3]
        {
            Levitate,
            Heatproof,
            HeavyMetal,
        }
    );
    public static readonly SpeciesData Bronzong = new(
        speciesName: "Bronzong",
        type1: Steel,
        type2: Psychic,
        baseHP: 67,
        baseAttack: 89,
        baseDefense: 116,
        baseSpAtk: 79,
        baseSpDef: 116,
        baseSpeed: 33,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "bronzong", //Verify
        graphicsLocation: "bronzong", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bronzong,
        abilities: new Ability[3]
        {
            Levitate,
            Heatproof,
            HeavyMetal,
        }
    );
    public static readonly SpeciesData Bonsly = new(
        speciesName: "Bonsly",
        type1: Rock,
        type2: Rock,
        baseHP: 50,
        baseAttack: 80,
        baseDefense: 95,
        baseSpAtk: 10,
        baseSpDef: 45,
        baseSpeed: 10,
        evYield: Defense,
        evolution: Evolution.Bonsly,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "bonsly", //Verify
        graphicsLocation: "bonsly", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Bonsly,
        abilities: new Ability[3]
        {
            Sturdy,
            RockHead,
            Rattled,
        }
    );
    public static readonly SpeciesData MimeJr = new(
        speciesName: "Mime Jr.",
        type1: Psychic,
        type2: Fairy,
        baseHP: 20,
        baseAttack: 25,
        baseDefense: 45,
        baseSpAtk: 70,
        baseSpDef: 90,
        baseSpeed: 60,
        evYield: SpDef,
        evolution: Evolution.MimeJr,
        xpClass: MediumFast,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 145,
        baseFriendship: 70,
        cryLocation: "mime_jr", //Verify
        graphicsLocation: "mime_jr", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.MimeJr,
        abilities: new Ability[3]
        {
            Soundproof,
            Filter,
            Technician,
        }
    );
    public static readonly SpeciesData Happiny = new(
        speciesName: "Happiny",
        type1: Normal,
        type2: Normal,
        baseHP: 100,
        baseAttack: 5,
        baseDefense: 5,
        baseSpAtk: 15,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: HP,
        evolution: Evolution.Happiny,
        xpClass: Fast,
        xpYield: 110,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 40,
        catchRate: 130,
        baseFriendship: 140,
        cryLocation: "happiny", //Verify
        graphicsLocation: "happiny", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Happiny,
        abilities: new Ability[3]
        {
            NaturalCure,
            SereneGrace,
            FriendGuard,
        }
    );
    public static readonly SpeciesData Chatot = new(
        speciesName: "Chatot",
        type1: Normal,
        type2: Flying,
        baseHP: 76,
        baseAttack: 65,
        baseDefense: 45,
        baseSpAtk: 92,
        baseSpDef: 42,
        baseSpeed: 91,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 35,
        cryLocation: "chatot", //Verify
        graphicsLocation: "chatot", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Chatot,
        abilities: new Ability[3]
        {
            KeenEye,
            TangledFeet,
            BigPecks,
        }
    );
    public static readonly SpeciesData Spiritomb = new(
        speciesName: "Spiritomb",
        type1: Ghost,
        type2: Dark,
        baseHP: 50,
        baseAttack: 92,
        baseDefense: 108,
        baseSpAtk: 92,
        baseSpDef: 108,
        baseSpeed: 35,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 30,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "spiritomb", //Verify
        graphicsLocation: "spiritomb", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Spiritomb,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Gible = new(
        speciesName: "Gible",
        type1: Dragon,
        type2: Ground,
        baseHP: 58,
        baseAttack: 70,
        baseDefense: 45,
        baseSpAtk: 40,
        baseSpDef: 45,
        baseSpeed: 42,
        evYield: Attack,
        evolution: Evolution.Gible,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gible", //Verify
        graphicsLocation: "gible", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Gible,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        }
    );
    public static readonly SpeciesData Gabite = new(
        speciesName: "Gabite",
        type1: Dragon,
        type2: Ground,
        baseHP: 68,
        baseAttack: 90,
        baseDefense: 65,
        baseSpAtk: 50,
        baseSpDef: 55,
        baseSpeed: 82,
        evYield: 2 * Attack,
        evolution: Evolution.Gabite,
        xpClass: Slow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gabite", //Verify
        graphicsLocation: "gabite", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Gabite,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        }
    );
    public static readonly SpeciesData Garchomp = new(
        speciesName: "Garchomp",
        type1: Dragon,
        type2: Ground,
        baseHP: 108,
        baseAttack: 130,
        baseDefense: 95,
        baseSpAtk: 80,
        baseSpDef: 85,
        baseSpeed: 102,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "garchomp", //Verify
        graphicsLocation: "garchomp", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Garchomp,
        abilities: new Ability[3]
        {
            SandVeil,
            SandVeil,
            RoughSkin,
        }
    );
    public static readonly SpeciesData Munchlax = new(
        speciesName: "Munchlax",
        type1: Normal,
        type2: Normal,
        baseHP: 135,
        baseAttack: 85,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 85,
        baseSpeed: 5,
        evYield: HP,
        evolution: Evolution.Munchlax,
        xpClass: Slow,
        xpYield: 78,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 40,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "munchlax", //Verify
        graphicsLocation: "munchlax", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Munchlax,
        abilities: new Ability[3]
        {
            Pickup,
            ThickFat,
            Gluttony,
        }
    );
    public static readonly SpeciesData Riolu = new(
        speciesName: "Riolu",
        type1: Fighting,
        type2: Fighting,
        baseHP: 40,
        baseAttack: 70,
        baseDefense: 40,
        baseSpAtk: 35,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Riolu,
        xpClass: MediumSlow,
        xpYield: 57,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "riolu", //Verify
        graphicsLocation: "riolu", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Riolu,
        abilities: new Ability[3]
        {
            Steadfast,
            InnerFocus,
            Prankster,
        }
    );
    public static readonly SpeciesData Lucario = new(
        speciesName: "Lucario",
        type1: Fighting,
        type2: Steel,
        baseHP: 70,
        baseAttack: 110,
        baseDefense: 70,
        baseSpAtk: 115,
        baseSpDef: 70,
        baseSpeed: 90,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "lucario", //Verify
        graphicsLocation: "lucario", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Lucario,
        abilities: new Ability[3]
        {
            Steadfast,
            InnerFocus,
            Justified,
        }
    );
    public static readonly SpeciesData Hippopotas = new(
        speciesName: "Hippopotas",
        type1: Ground,
        type2: Ground,
        baseHP: 68,
        baseAttack: 72,
        baseDefense: 78,
        baseSpAtk: 38,
        baseSpDef: 42,
        baseSpeed: 32,
        evYield: Defense,
        evolution: Evolution.Hippopotas,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 30,
        catchRate: 140,
        baseFriendship: 70,
        cryLocation: "hippopotas", //Verify
        graphicsLocation: "hippopotas", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Hippopotas,
        abilities: new Ability[3]
        {
            SandStream,
            SandStream,
            SandForce,
        }
    );
    public static readonly SpeciesData Hippowdon = new(
        speciesName: "Hippowdon",
        type1: Ground,
        type2: Ground,
        baseHP: 108,
        baseAttack: 112,
        baseDefense: 118,
        baseSpAtk: 68,
        baseSpDef: 72,
        baseSpeed: 47,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 30,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "hippowdon", //Verify
        graphicsLocation: "hippowdon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Hippowdon,
        abilities: new Ability[3]
        {
            SandStream,
            SandStream,
            SandForce,
        }
    );
    public static readonly SpeciesData Skorupi = new(
        speciesName: "Skorupi",
        type1: Poison,
        type2: Bug,
        baseHP: 40,
        baseAttack: 50,
        baseDefense: 90,
        baseSpAtk: 30,
        baseSpDef: 55,
        baseSpeed: 65,
        evYield: Defense,
        evolution: Evolution.Skorupi,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "skorupi", //Verify
        graphicsLocation: "skorupi", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Skorupi,
        abilities: new Ability[3]
        {
            BattleArmor,
            Sniper,
            KeenEye,
        }
    );
    public static readonly SpeciesData Drapion = new(
        speciesName: "Drapion",
        type1: Poison,
        type2: Dark,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 110,
        baseSpAtk: 60,
        baseSpDef: 75,
        baseSpeed: 95,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "drapion", //Verify
        graphicsLocation: "drapion", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Drapion,
        abilities: new Ability[3]
        {
            BattleArmor,
            Sniper,
            KeenEye,
        }
    );
    public static readonly SpeciesData Croagunk = new(
        speciesName: "Croagunk",
        type1: Poison,
        type2: Fighting,
        baseHP: 48,
        baseAttack: 61,
        baseDefense: 40,
        baseSpAtk: 61,
        baseSpDef: 40,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Croagunk,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 10,
        catchRate: 140,
        baseFriendship: 100,
        cryLocation: "croagunk", //Verify
        graphicsLocation: "croagunk", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Croagunk,
        abilities: new Ability[3]
        {
            Anticipation,
            DrySkin,
            PoisonTouch,
        }
    );
    public static readonly SpeciesData Toxicroak = new(
        speciesName: "Toxicroak",
        type1: Poison,
        type2: Fighting,
        baseHP: 83,
        baseAttack: 106,
        baseDefense: 65,
        baseSpAtk: 86,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "toxicroak", //Verify
        graphicsLocation: "toxicroak", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Toxicroak,
        abilities: new Ability[3]
        {
            Anticipation,
            DrySkin,
            PoisonTouch,
        }
    );
    public static readonly SpeciesData Carnivine = new(
        speciesName: "Carnivine",
        type1: Grass,
        type2: Grass,
        baseHP: 74,
        baseAttack: 100,
        baseDefense: 72,
        baseSpAtk: 90,
        baseSpDef: 72,
        baseSpeed: 46,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 25,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "carnivine", //Verify
        graphicsLocation: "carnivine", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Carnivine,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Finneon = new(
        speciesName: "Finneon",
        type1: Water,
        type2: Water,
        baseHP: 49,
        baseAttack: 49,
        baseDefense: 56,
        baseSpAtk: 49,
        baseSpDef: 61,
        baseSpeed: 66,
        evYield: Speed,
        evolution: Evolution.Finneon,
        xpClass: Erratic,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "finneon", //Verify
        graphicsLocation: "finneon", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Finneon,
        abilities: new Ability[3]
        {
            SwiftSwim,
            StormDrain,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Lumineon = new(
        speciesName: "Lumineon",
        type1: Water,
        type2: Water,
        baseHP: 69,
        baseAttack: 69,
        baseDefense: 76,
        baseSpAtk: 69,
        baseSpDef: 86,
        baseSpeed: 91,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "lumineon", //Verify
        graphicsLocation: "lumineon", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Lumineon,
        abilities: new Ability[3]
        {
            SwiftSwim,
            StormDrain,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Mantyke = new(
        speciesName: "Mantyke",
        type1: Water,
        type2: Flying,
        baseHP: 45,
        baseAttack: 20,
        baseDefense: 50,
        baseSpAtk: 60,
        baseSpDef: 120,
        baseSpeed: 50,
        evYield: SpDef,
        evolution: Evolution.Mantyke,
        xpClass: Slow,
        xpYield: 69,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "mantyke", //Verify
        graphicsLocation: "mantyke", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Mantyke,
        abilities: new Ability[3]
        {
            SwiftSwim,
            WaterAbsorb,
            WaterVeil,
        }
    );
    public static readonly SpeciesData Snover = new(
        speciesName: "Snover",
        type1: Grass,
        type2: Ice,
        baseHP: 60,
        baseAttack: 62,
        baseDefense: 50,
        baseSpAtk: 62,
        baseSpDef: 60,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Snover,
        xpClass: Slow,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "snover", //Verify
        graphicsLocation: "snover", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Snover,
        abilities: new Ability[3]
        {
            SnowWarning,
            SnowWarning,
            Soundproof,
        }
    );
    public static readonly SpeciesData Abomasnow = new(
        speciesName: "Abomasnow",
        type1: Grass,
        type2: Ice,
        baseHP: 90,
        baseAttack: 92,
        baseDefense: 75,
        baseSpAtk: 92,
        baseSpDef: 85,
        baseSpeed: 60,
        evYield: Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "abomasnow", //Verify
        graphicsLocation: "abomasnow", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Abomasnow,
        abilities: new Ability[3]
        {
            SnowWarning,
            SnowWarning,
            Soundproof,
        }
    );
    public static readonly SpeciesData Weavile = new(
        speciesName: "Weavile",
        type1: Dark,
        type2: Ice,
        baseHP: 70,
        baseAttack: 120,
        baseDefense: 65,
        baseSpAtk: 45,
        baseSpDef: 85,
        baseSpeed: 125,
        evYield: Attack + Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "weavile", //Verify
        graphicsLocation: "weavile", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Weavile,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Magnezone = new(
        speciesName: "Magnezone",
        type1: Electric,
        type2: Steel,
        baseHP: 70,
        baseAttack: 70,
        baseDefense: 115,
        baseSpAtk: 130,
        baseSpDef: 90,
        baseSpeed: 60,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "magnezone", //Verify
        graphicsLocation: "magnezone", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Magnezone,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Analytic,
        }
    );
    public static readonly SpeciesData Lickilicky = new(
        speciesName: "Lickilicky",
        type1: Normal,
        type2: Normal,
        baseHP: 110,
        baseAttack: 85,
        baseDefense: 95,
        baseSpAtk: 80,
        baseSpDef: 95,
        baseSpeed: 50,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "lickilicky", //Verify
        graphicsLocation: "lickilicky", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Lickilicky,
        abilities: new Ability[3]
        {
            OwnTempo,
            Oblivious,
            CloudNine,
        }
    );
    public static readonly SpeciesData Rhyperior = new(
        speciesName: "Rhyperior",
        type1: Ground,
        type2: Rock,
        baseHP: 115,
        baseAttack: 140,
        baseDefense: 130,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 40,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "rhyperior", //Verify
        graphicsLocation: "rhyperior", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Rhyperior,
        abilities: new Ability[3]
        {
            LightningRod,
            SolidRock,
            Reckless,
        }
    );
    public static readonly SpeciesData Tangrowth = new(
        speciesName: "Tangrowth",
        type1: Grass,
        type2: Grass,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 125,
        baseSpAtk: 110,
        baseSpDef: 50,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 187,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "tangrowth", //Verify
        graphicsLocation: "tangrowth", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Tangrowth,
        abilities: new Ability[3]
        {
            Chlorophyll,
            LeafGuard,
            Regenerator,
        }
    );
    public static readonly SpeciesData Electivire = new(
        speciesName: "Electivire",
        type1: Electric,
        type2: Electric,
        baseHP: 75,
        baseAttack: 123,
        baseDefense: 67,
        baseSpAtk: 95,
        baseSpDef: 85,
        baseSpeed: 95,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 243,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "electivire", //Verify
        graphicsLocation: "electivire", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Electivire,
        abilities: new Ability[3]
        {
            MotorDrive,
            MotorDrive,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Magmortar = new(
        speciesName: "Magmortar",
        type1: Fire,
        type2: Fire,
        baseHP: 75,
        baseAttack: 95,
        baseDefense: 67,
        baseSpAtk: 125,
        baseSpDef: 95,
        baseSpeed: 83,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 243,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "magmortar", //Verify
        graphicsLocation: "magmortar", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Magmortar,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            VitalSpirit,
        }
    );
    public static readonly SpeciesData Togekiss = new(
        speciesName: "Togekiss",
        type1: Fairy,
        type2: Flying,
        baseHP: 85,
        baseAttack: 50,
        baseDefense: 95,
        baseSpAtk: 120,
        baseSpDef: 115,
        baseSpeed: 80,
        evYield: 2 * SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 245,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "togekiss", //Verify
        graphicsLocation: "togekiss", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Togekiss,
        abilities: new Ability[3]
        {
            Hustle,
            SereneGrace,
            SuperLuck,
        }
    );
    public static readonly SpeciesData Yanmega = new(
        speciesName: "Yanmega",
        type1: Bug,
        type2: Flying,
        baseHP: 86,
        baseAttack: 76,
        baseDefense: 86,
        baseSpAtk: 116,
        baseSpDef: 56,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "yanmega", //Verify
        graphicsLocation: "yanmega", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Yanmega,
        abilities: new Ability[3]
        {
            SpeedBoost,
            TintedLens,
            Frisk,
        }
    );
    public static readonly SpeciesData Leafeon = new(
        speciesName: "Leafeon",
        type1: Grass,
        type2: Grass,
        baseHP: 65,
        baseAttack: 110,
        baseDefense: 130,
        baseSpAtk: 60,
        baseSpDef: 65,
        baseSpeed: 95,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "leafeon", //Verify
        graphicsLocation: "leafeon", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Leafeon,
        abilities: new Ability[3]
        {
            LeafGuard,
            LeafGuard,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Glaceon = new(
        speciesName: "Glaceon",
        type1: Ice,
        type2: Ice,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 110,
        baseSpAtk: 130,
        baseSpDef: 95,
        baseSpeed: 65,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "glaceon", //Verify
        graphicsLocation: "glaceon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Glaceon,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            IceBody,
        }
    );
    public static readonly SpeciesData Gliscor = new(
        speciesName: "Gliscor",
        type1: Ground,
        type2: Flying,
        baseHP: 75,
        baseAttack: 95,
        baseDefense: 125,
        baseSpAtk: 45,
        baseSpDef: 75,
        baseSpeed: 95,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "gliscor", //Verify
        graphicsLocation: "gliscor", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Gliscor,
        abilities: new Ability[3]
        {
            HyperCutter,
            SandVeil,
            PoisonHeal,
        }
    );
    public static readonly SpeciesData Mamoswine = new(
        speciesName: "Mamoswine",
        type1: Ice,
        type2: Ground,
        baseHP: 110,
        baseAttack: 130,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 60,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "mamoswine", //Verify
        graphicsLocation: "mamoswine", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Mamoswine,
        abilities: new Ability[3]
        {
            Oblivious,
            SnowCloak,
            ThickFat,
        }
    );
    public static readonly SpeciesData PorygonZ = new(
        speciesName: "Porygon-Z",
        type1: Normal,
        type2: Normal,
        baseHP: 85,
        baseAttack: 80,
        baseDefense: 70,
        baseSpAtk: 135,
        baseSpDef: 75,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "porygon_z", //Verify
        graphicsLocation: "porygon_z", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.PorygonZ,
        abilities: new Ability[3]
        {
            Adaptability,
            Download,
            Analytic,
        }
    );
    public static readonly SpeciesData Gallade = new(
        speciesName: "Gallade",
        type1: Psychic,
        type2: Fighting,
        baseHP: 68,
        baseAttack: 125,
        baseDefense: 65,
        baseSpAtk: 65,
        baseSpDef: 115,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 233,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "gallade", //Verify
        graphicsLocation: "gallade", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Gallade,
        abilities: new Ability[3]
        {
            Steadfast,
            Steadfast,
            Justified,
        }
    );
    public static readonly SpeciesData Probopass = new(
        speciesName: "Probopass",
        type1: Rock,
        type2: Steel,
        baseHP: 60,
        baseAttack: 55,
        baseDefense: 145,
        baseSpAtk: 75,
        baseSpDef: 150,
        baseSpeed: 40,
        evYield: Defense + 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "probopass", //Verify
        graphicsLocation: "probopass", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Probopass,
        abilities: new Ability[3]
        {
            Sturdy,
            MagnetPull,
            SandForce,
        }
    );
    public static readonly SpeciesData Dusknoir = new(
        speciesName: "Dusknoir",
        type1: Ghost,
        type2: Ghost,
        baseHP: 45,
        baseAttack: 100,
        baseDefense: 135,
        baseSpAtk: 65,
        baseSpDef: 135,
        baseSpeed: 45,
        evYield: Defense + 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 236,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "dusknoir", //Verify
        graphicsLocation: "dusknoir", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Dusknoir,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Frisk,
        }
    );
    public static readonly SpeciesData Froslass = new(
        speciesName: "Froslass",
        type1: Ice,
        type2: Ghost,
        baseHP: 70,
        baseAttack: 80,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 70,
        baseSpeed: 110,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "froslass", //Verify
        graphicsLocation: "froslass", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Froslass,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            CursedBody,
        }
    );
    public static readonly SpeciesData Rotom = new(
        speciesName: "Rotom",
        type1: Electric,
        type2: Ghost,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 77,
        baseSpAtk: 95,
        baseSpDef: 77,
        baseSpeed: 91,
        evYield: Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "rotom", //Verify
        graphicsLocation: "rotom", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Rotom,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Uxie = new(
        speciesName: "Uxie",
        type1: Psychic,
        type2: Psychic,
        baseHP: 75,
        baseAttack: 75,
        baseDefense: 130,
        baseSpAtk: 75,
        baseSpDef: 130,
        baseSpeed: 95,
        evYield: 2 * Defense + SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 140,
        cryLocation: "uxie", //Verify
        graphicsLocation: "uxie", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Uxie,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Mesprit = new(
        speciesName: "Mesprit",
        type1: Psychic,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 105,
        baseDefense: 105,
        baseSpAtk: 105,
        baseSpDef: 105,
        baseSpeed: 80,
        evYield: Attack + SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 140,
        cryLocation: "mesprit", //Verify
        graphicsLocation: "mesprit", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Mesprit,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Azelf = new(
        speciesName: "Azelf",
        type1: Psychic,
        type2: Psychic,
        baseHP: 75,
        baseAttack: 125,
        baseDefense: 70,
        baseSpAtk: 125,
        baseSpDef: 70,
        baseSpeed: 115,
        evYield: 2 * Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 140,
        cryLocation: "azelf", //Verify
        graphicsLocation: "azelf", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Azelf,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Dialga = Dialga(
        baseAttack: 120,
        baseSpDef: 100,
        graphics: "dialga",
        backSpriteHeight: 0
    );
    public static readonly SpeciesData Palkia = Palkia(
        baseAttack: 120,
        baseSpeed: 100,
        graphics: "palkia",
        backSpriteHeight: 6
    );
    public static readonly SpeciesData Heatran = new(
        speciesName: "Heatran",
        type1: Fire,
        type2: Steel,
        baseHP: 91,
        baseAttack: 90,
        baseDefense: 106,
        baseSpAtk: 130,
        baseSpDef: 106,
        baseSpeed: 77,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "heatran", //Verify
        graphicsLocation: "heatran", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Heatran,
        abilities: new Ability[3]
        {
            FlashFire,
            FlashFire,
            FlameBody,
        }
    );
    public static readonly SpeciesData Regigigas = new(
        speciesName: "Regigigas",
        type1: Normal,
        type2: Normal,
        baseHP: 110,
        baseAttack: 160,
        baseDefense: 110,
        baseSpAtk: 80,
        baseSpDef: 110,
        baseSpeed: 100,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 302,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "regigigas", //Verify
        graphicsLocation: "regigigas", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Regigigas,
        abilities: new Ability[3]
        {
            SlowStart,
            SlowStart,
            SlowStart,
        }
    );
    public static readonly SpeciesData Giratina = Giratina(
        baseAttack: 100,
        baseSpAtk: 100,
        baseDefense: 120,
        baseSpDef: 120,
        graphics: "giratina",
        backSpriteHeight: 4
    );
    public static readonly SpeciesData Cresselia = new(
        speciesName: "Cresselia",
        type1: Psychic,
        type2: Psychic,
        baseHP: 120,
        baseAttack: 70,
        baseDefense: 120,
        baseSpAtk: 75,
        baseSpDef: 130,
        baseSpeed: 85,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "cresselia", //Verify
        graphicsLocation: "cresselia", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Cresselia,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Phione = new(
        speciesName: "Phione",
        type1: Water,
        type2: Water,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 80,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 216,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 40,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "phione", //Verify
        graphicsLocation: "phione", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Phione,
        abilities: new Ability[3]
        {
            Hydration,
            Hydration,
            Hydration,
        }
    );
    public static readonly SpeciesData Manaphy = new(
        speciesName: "Manaphy",
        type1: Water,
        type2: Water,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "manaphy", //Verify
        graphicsLocation: "manaphy", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Manaphy,
        abilities: new Ability[3]
        {
            Hydration,
            Hydration,
            Hydration,
        }
    );
    public static readonly SpeciesData Darkrai = new(
        speciesName: "Darkrai",
        type1: Dark,
        type2: Dark,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 90,
        baseSpAtk: 135,
        baseSpDef: 90,
        baseSpeed: 125,
        evYield: Speed + 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "darkrai", //Verify
        graphicsLocation: "darkrai", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Darkrai,
        abilities: new Ability[3]
        {
            BadDreams,
            BadDreams,
            BadDreams,
        }
    );
    public static readonly SpeciesData Shaymin = Shaymin(
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
    public static readonly SpeciesData Arceus = Arceus(Normal, "arceus");

    public static readonly SpeciesData Victini = new(
        speciesName: "Victini",
        type1: Psychic,
        type2: Fire,
        baseHP: 100,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 100,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "victini", //Verify
        graphicsLocation: "victini", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Victini,
        abilities: new Ability[3]
        {
            VictoryStar,
            VictoryStar,
            VictoryStar,
        }
    );
    public static readonly SpeciesData Snivy = new(
        speciesName: "Snivy",
        type1: Grass,
        type2: Grass,
        baseHP: 45,
        baseAttack: 45,
        baseDefense: 55,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 63,
        evYield: Speed,
        evolution: Evolution.Snivy,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "snivy", //Verify
        graphicsLocation: "snivy", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Snivy,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Contrary,
        }
    );
    public static readonly SpeciesData Servine = new(
        speciesName: "Servine",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 75,
        baseSpAtk: 60,
        baseSpDef: 75,
        baseSpeed: 83,
        evYield: 2 * Speed,
        evolution: Evolution.Servine,
        xpClass: MediumSlow,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "servine", //Verify
        graphicsLocation: "servine", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Servine,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Contrary,
        }
    );
    public static readonly SpeciesData Serperior = new(
        speciesName: "Serperior",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 75,
        baseDefense: 95,
        baseSpAtk: 75,
        baseSpDef: 95,
        baseSpeed: 113,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 238,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "serperior", //Verify
        graphicsLocation: "serperior", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Serperior,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Contrary,
        }
    );
    public static readonly SpeciesData Tepig = new(
        speciesName: "Tepig",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 63,
        baseDefense: 45,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 45,
        evYield: HP,
        evolution: Evolution.Tepig,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tepig", //Verify
        graphicsLocation: "tepig", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Tepig,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            ThickFat,
        }
    );
    public static readonly SpeciesData Pignite = new(
        speciesName: "Pignite",
        type1: Fire,
        type2: Fighting,
        baseHP: 90,
        baseAttack: 93,
        baseDefense: 55,
        baseSpAtk: 70,
        baseSpDef: 55,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.Pignite,
        xpClass: MediumSlow,
        xpYield: 146,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "pignite", //Verify
        graphicsLocation: "pignite", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Pignite,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            ThickFat,
        }
    );
    public static readonly SpeciesData Emboar = new(
        speciesName: "Emboar",
        type1: Fire,
        type2: Fighting,
        baseHP: 110,
        baseAttack: 123,
        baseDefense: 65,
        baseSpAtk: 100,
        baseSpDef: 65,
        baseSpeed: 65,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 238,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "emboar", //Verify
        graphicsLocation: "emboar", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Emboar,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Reckless,
        }
    );
    public static readonly SpeciesData Oshawott = new(
        speciesName: "Oshawott",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 55,
        baseDefense: 45,
        baseSpAtk: 63,
        baseSpDef: 45,
        baseSpeed: 45,
        evYield: SpAtk,
        evolution: Evolution.Oshawott,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "oshawott", //Verify
        graphicsLocation: "oshawott", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Oshawott,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Dewott = new(
        speciesName: "Dewott",
        type1: Water,
        type2: Water,
        baseHP: 75,
        baseAttack: 75,
        baseDefense: 60,
        baseSpAtk: 83,
        baseSpDef: 60,
        baseSpeed: 60,
        evYield: 2 * SpAtk,
        evolution: Evolution.Dewott,
        xpClass: MediumSlow,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dewott", //Verify
        graphicsLocation: "dewott", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Dewott,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Samurott = new(
        speciesName: "Samurott",
        type1: Water,
        type2: Water,
        baseHP: 95,
        baseAttack: 100,
        baseDefense: 85,
        baseSpAtk: 108,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 238,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "samurott", //Verify
        graphicsLocation: "samurott", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Samurott,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Patrat = new(
        speciesName: "Patrat",
        type1: Normal,
        type2: Normal,
        baseHP: 45,
        baseAttack: 55,
        baseDefense: 39,
        baseSpAtk: 35,
        baseSpDef: 39,
        baseSpeed: 42,
        evYield: Attack,
        evolution: Evolution.Patrat,
        xpClass: MediumFast,
        xpYield: 51,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "patrat", //Verify
        graphicsLocation: "patrat", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Patrat,
        abilities: new Ability[3]
        {
            RunAway,
            KeenEye,
            Analytic,
        }
    );
    public static readonly SpeciesData Watchog = new(
        speciesName: "Watchog",
        type1: Normal,
        type2: Normal,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 69,
        baseSpAtk: 60,
        baseSpDef: 69,
        baseSpeed: 77,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "watchog", //Verify
        graphicsLocation: "watchog", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Watchog,
        abilities: new Ability[3]
        {
            Illuminate,
            KeenEye,
            Analytic,
        }
    );
    public static readonly SpeciesData Lillipup = new(
        speciesName: "Lillipup",
        type1: Normal,
        type2: Normal,
        baseHP: 45,
        baseAttack: 60,
        baseDefense: 45,
        baseSpAtk: 25,
        baseSpDef: 45,
        baseSpeed: 55,
        evYield: Attack,
        evolution: Evolution.Lillipup,
        xpClass: MediumSlow,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "lillipup", //Verify
        graphicsLocation: "lillipup", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Lillipup,
        abilities: new Ability[3]
        {
            VitalSpirit,
            Pickup,
            RunAway,
        }
    );
    public static readonly SpeciesData Herdier = new(
        speciesName: "Herdier",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 80,
        baseDefense: 65,
        baseSpAtk: 35,
        baseSpDef: 65,
        baseSpeed: 60,
        evYield: 2 * Attack,
        evolution: Evolution.Herdier,
        xpClass: MediumSlow,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "herdier", //Verify
        graphicsLocation: "herdier", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Herdier,
        abilities: new Ability[3]
        {
            Intimidate,
            SandRush,
            Scrappy,
        }
    );
    public static readonly SpeciesData Stoutland = new(
        speciesName: "Stoutland",
        type1: Normal,
        type2: Normal,
        baseHP: 85,
        baseAttack: 100,
        baseDefense: 90,
        baseSpAtk: 45,
        baseSpDef: 90,
        baseSpeed: 80,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "stoutland", //Verify
        graphicsLocation: "stoutland", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Stoutland,
        abilities: new Ability[3]
        {
            Intimidate,
            SandRush,
            Scrappy,
        }
    );
    public static readonly SpeciesData Purrloin = new(
        speciesName: "Purrloin",
        type1: Dark,
        type2: Dark,
        baseHP: 41,
        baseAttack: 50,
        baseDefense: 37,
        baseSpAtk: 50,
        baseSpDef: 37,
        baseSpeed: 66,
        evYield: Speed,
        evolution: Evolution.Purrloin,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "purrloin", //Verify
        graphicsLocation: "purrloin", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Purrloin,
        abilities: new Ability[3]
        {
            Limber,
            Unburden,
            Prankster,
        }
    );
    public static readonly SpeciesData Liepard = new(
        speciesName: "Liepard",
        type1: Dark,
        type2: Dark,
        baseHP: 64,
        baseAttack: 88,
        baseDefense: 50,
        baseSpAtk: 88,
        baseSpDef: 50,
        baseSpeed: 106,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 156,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "liepard", //Verify
        graphicsLocation: "liepard", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Liepard,
        abilities: new Ability[3]
        {
            Limber,
            Unburden,
            Prankster,
        }
    );
    public static readonly SpeciesData Pansage = new(
        speciesName: "Pansage",
        type1: Grass,
        type2: Grass,
        baseHP: 50,
        baseAttack: 53,
        baseDefense: 48,
        baseSpAtk: 53,
        baseSpDef: 48,
        baseSpeed: 64,
        evYield: Speed,
        evolution: Evolution.Pansage,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pansage", //Verify
        graphicsLocation: "pansage", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Pansage,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Overgrow,
        }
    );
    public static readonly SpeciesData Simisage = new(
        speciesName: "Simisage",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 98,
        baseDefense: 63,
        baseSpAtk: 98,
        baseSpDef: 63,
        baseSpeed: 101,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 174,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "simisage", //Verify
        graphicsLocation: "simisage", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Simisage,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Overgrow,
        }
    );
    public static readonly SpeciesData Pansear = new(
        speciesName: "Pansear",
        type1: Fire,
        type2: Fire,
        baseHP: 50,
        baseAttack: 53,
        baseDefense: 48,
        baseSpAtk: 53,
        baseSpDef: 48,
        baseSpeed: 64,
        evYield: Speed,
        evolution: Evolution.Pansear,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pansear", //Verify
        graphicsLocation: "pansear", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Pansear,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Blaze,
        }
    );
    public static readonly SpeciesData Simisear = new(
        speciesName: "Simisear",
        type1: Fire,
        type2: Fire,
        baseHP: 75,
        baseAttack: 98,
        baseDefense: 63,
        baseSpAtk: 98,
        baseSpDef: 63,
        baseSpeed: 101,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 174,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "simisear", //Verify
        graphicsLocation: "simisear", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Simisear,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Blaze,
        }
    );
    public static readonly SpeciesData Panpour = new(
        speciesName: "Panpour",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 53,
        baseDefense: 48,
        baseSpAtk: 53,
        baseSpDef: 48,
        baseSpeed: 64,
        evYield: Speed,
        evolution: Evolution.Panpour,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "panpour", //Verify
        graphicsLocation: "panpour", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Panpour,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Torrent,
        }
    );
    public static readonly SpeciesData Simipour = new(
        speciesName: "Simipour",
        type1: Water,
        type2: Water,
        baseHP: 75,
        baseAttack: 98,
        baseDefense: 63,
        baseSpAtk: 98,
        baseSpDef: 63,
        baseSpeed: 101,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 174,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "simipour", //Verify
        graphicsLocation: "simipour", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Simipour,
        abilities: new Ability[3]
        {
            Gluttony,
            Gluttony,
            Torrent,
        }
    );
    public static readonly SpeciesData Munna = new(
        speciesName: "Munna",
        type1: Psychic,
        type2: Psychic,
        baseHP: 76,
        baseAttack: 25,
        baseDefense: 45,
        baseSpAtk: 67,
        baseSpDef: 55,
        baseSpeed: 24,
        evYield: HP,
        evolution: Evolution.Munna,
        xpClass: Fast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "munna", //Verify
        graphicsLocation: "munna", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Munna,
        abilities: new Ability[3]
        {
            Forewarn,
            Synchronize,
            Telepathy,
        }
    );
    public static readonly SpeciesData Musharna = new(
        speciesName: "Musharna",
        type1: Psychic,
        type2: Psychic,
        baseHP: 116,
        baseAttack: 55,
        baseDefense: 85,
        baseSpAtk: 107,
        baseSpDef: 95,
        baseSpeed: 29,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 10,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "musharna", //Verify
        graphicsLocation: "musharna", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Musharna,
        abilities: new Ability[3]
        {
            Forewarn,
            Synchronize,
            Telepathy,
        }
    );
    public static readonly SpeciesData Pidove = new(
        speciesName: "Pidove",
        type1: Normal,
        type2: Flying,
        baseHP: 50,
        baseAttack: 55,
        baseDefense: 50,
        baseSpAtk: 36,
        baseSpDef: 30,
        baseSpeed: 43,
        evYield: Attack,
        evolution: Evolution.Pidove,
        xpClass: MediumSlow,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "pidove", //Verify
        graphicsLocation: "pidove", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Pidove,
        abilities: new Ability[3]
        {
            BigPecks,
            SuperLuck,
            Rivalry,
        }
    );
    public static readonly SpeciesData Tranquill = new(
        speciesName: "Tranquill",
        type1: Normal,
        type2: Flying,
        baseHP: 62,
        baseAttack: 77,
        baseDefense: 62,
        baseSpAtk: 50,
        baseSpDef: 42,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.Tranquill,
        xpClass: MediumSlow,
        xpYield: 125,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "tranquill", //Verify
        graphicsLocation: "tranquill", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Tranquill,
        abilities: new Ability[3]
        {
            BigPecks,
            SuperLuck,
            Rivalry,
        }
    );
    public static readonly SpeciesData Unfezant = new(
        speciesName: "Unfezant",
        type1: Normal,
        type2: Flying,
        baseHP: 80,
        baseAttack: 105,
        baseDefense: 80,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 93,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 220,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "unfezant", //Verify
        graphicsLocation: "unfezant", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Unfezant,
        abilities: new Ability[3]
        {
            BigPecks,
            SuperLuck,
            Rivalry,
        }
    );
    public static readonly SpeciesData Blitzle = new(
        speciesName: "Blitzle",
        type1: Electric,
        type2: Electric,
        baseHP: 45,
        baseAttack: 60,
        baseDefense: 32,
        baseSpAtk: 50,
        baseSpDef: 32,
        baseSpeed: 76,
        evYield: Speed,
        evolution: Evolution.Blitzle,
        xpClass: MediumFast,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "blitzle", //Verify
        graphicsLocation: "blitzle", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Blitzle,
        abilities: new Ability[3]
        {
            LightningRod,
            MotorDrive,
            SapSipper,
        }
    );
    public static readonly SpeciesData Zebstrika = new(
        speciesName: "Zebstrika",
        type1: Electric,
        type2: Electric,
        baseHP: 75,
        baseAttack: 100,
        baseDefense: 63,
        baseSpAtk: 80,
        baseSpDef: 63,
        baseSpeed: 116,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 174,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "zebstrika", //Verify
        graphicsLocation: "zebstrika", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Zebstrika,
        abilities: new Ability[3]
        {
            LightningRod,
            MotorDrive,
            SapSipper,
        }
    );
    public static readonly SpeciesData Roggenrola = new(
        speciesName: "Roggenrola",
        type1: Rock,
        type2: Rock,
        baseHP: 55,
        baseAttack: 75,
        baseDefense: 85,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 15,
        evYield: Defense,
        evolution: Evolution.Roggenrola,
        xpClass: MediumSlow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "roggenrola", //Verify
        graphicsLocation: "roggenrola", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Roggenrola,
        abilities: new Ability[3]
        {
            Sturdy,
            WeakArmor,
            SandForce,
        }
    );
    public static readonly SpeciesData Boldore = new(
        speciesName: "Boldore",
        type1: Rock,
        type2: Rock,
        baseHP: 70,
        baseAttack: 105,
        baseDefense: 105,
        baseSpAtk: 50,
        baseSpDef: 40,
        baseSpeed: 20,
        evYield: Attack + Defense,
        evolution: Evolution.Boldore,
        xpClass: MediumSlow,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "boldore", //Verify
        graphicsLocation: "boldore", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Boldore,
        abilities: new Ability[3]
        {
            Sturdy,
            WeakArmor,
            SandForce,
        }
    );
    public static readonly SpeciesData Gigalith = new(
        speciesName: "Gigalith",
        type1: Rock,
        type2: Rock,
        baseHP: 85,
        baseAttack: 135,
        baseDefense: 130,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 25,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 232,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gigalith", //Verify
        graphicsLocation: "gigalith", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Gigalith,
        abilities: new Ability[3]
        {
            Sturdy,
            SandStream,
            SandForce,
        }
    );
    public static readonly SpeciesData Woobat = new(
        speciesName: "Woobat",
        type1: Psychic,
        type2: Flying,
        baseHP: 55,
        baseAttack: 45,
        baseDefense: 43,
        baseSpAtk: 55,
        baseSpDef: 43,
        baseSpeed: 72,
        evYield: Speed,
        evolution: Evolution.Woobat,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "woobat", //Verify
        graphicsLocation: "woobat", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Woobat,
        abilities: new Ability[3]
        {
            Unaware,
            Klutz,
            Simple,
        }
    );
    public static readonly SpeciesData Swoobat = new(
        speciesName: "Swoobat",
        type1: Psychic,
        type2: Flying,
        baseHP: 67,
        baseAttack: 57,
        baseDefense: 55,
        baseSpAtk: 77,
        baseSpDef: 55,
        baseSpeed: 114,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "swoobat", //Verify
        graphicsLocation: "swoobat", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Swoobat,
        abilities: new Ability[3]
        {
            Unaware,
            Klutz,
            Simple,
        }
    );
    public static readonly SpeciesData Drilbur = new(
        speciesName: "Drilbur",
        type1: Ground,
        type2: Ground,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 40,
        baseSpAtk: 30,
        baseSpDef: 45,
        baseSpeed: 68,
        evYield: Attack,
        evolution: Evolution.Drilbur,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "drilbur", //Verify
        graphicsLocation: "drilbur", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Drilbur,
        abilities: new Ability[3]
        {
            SandRush,
            SandForce,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Excadrill = new(
        speciesName: "Excadrill",
        type1: Ground,
        type2: Steel,
        baseHP: 110,
        baseAttack: 135,
        baseDefense: 60,
        baseSpAtk: 50,
        baseSpDef: 65,
        baseSpeed: 88,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 178,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "excadrill", //Verify
        graphicsLocation: "excadrill", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Excadrill,
        abilities: new Ability[3]
        {
            SandRush,
            SandForce,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Audino = new(
        speciesName: "Audino",
        type1: Normal,
        type2: Normal,
        baseHP: 103,
        baseAttack: 60,
        baseDefense: 86,
        baseSpAtk: 60,
        baseSpDef: 86,
        baseSpeed: 50,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 390,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "audino", //Verify
        graphicsLocation: "audino", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Audino,
        abilities: new Ability[3]
        {
            Healer,
            Regenerator,
            Klutz,
        }
    );
    public static readonly SpeciesData Timburr = new(
        speciesName: "Timburr",
        type1: Fighting,
        type2: Fighting,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 55,
        baseSpAtk: 25,
        baseSpDef: 35,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Timburr,
        xpClass: MediumSlow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "timburr", //Verify
        graphicsLocation: "timburr", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Timburr,
        abilities: new Ability[3]
        {
            Guts,
            SheerForce,
            IronFist,
        }
    );
    public static readonly SpeciesData Gurdurr = new(
        speciesName: "Gurdurr",
        type1: Fighting,
        type2: Fighting,
        baseHP: 85,
        baseAttack: 105,
        baseDefense: 85,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 40,
        evYield: 2 * Attack,
        evolution: Evolution.Gurdurr,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "gurdurr", //Verify
        graphicsLocation: "gurdurr", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Gurdurr,
        abilities: new Ability[3]
        {
            Guts,
            SheerForce,
            IronFist,
        }
    );
    public static readonly SpeciesData Conkeldurr = new(
        speciesName: "Conkeldurr",
        type1: Fighting,
        type2: Fighting,
        baseHP: 105,
        baseAttack: 140,
        baseDefense: 95,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 227,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "conkeldurr", //Verify
        graphicsLocation: "conkeldurr", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Conkeldurr,
        abilities: new Ability[3]
        {
            Guts,
            SheerForce,
            IronFist,
        }
    );
    public static readonly SpeciesData Tympole = new(
        speciesName: "Tympole",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 40,
        baseSpAtk: 50,
        baseSpDef: 40,
        baseSpeed: 64,
        evYield: Speed,
        evolution: Evolution.Tympole,
        xpClass: MediumSlow,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "tympole", //Verify
        graphicsLocation: "tympole", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Tympole,
        abilities: new Ability[3]
        {
            SwiftSwim,
            Hydration,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Palpitoad = new(
        speciesName: "Palpitoad",
        type1: Water,
        type2: Ground,
        baseHP: 75,
        baseAttack: 65,
        baseDefense: 55,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 69,
        evYield: 2 * HP,
        evolution: Evolution.Palpitoad,
        xpClass: MediumSlow,
        xpYield: 134,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "palpitoad", //Verify
        graphicsLocation: "palpitoad", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Palpitoad,
        abilities: new Ability[3]
        {
            SwiftSwim,
            Hydration,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Seismitoad = new(
        speciesName: "Seismitoad",
        type1: Water,
        type2: Ground,
        baseHP: 105,
        baseAttack: 85,
        baseDefense: 75,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 74,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 229,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "seismitoad", //Verify
        graphicsLocation: "seismitoad", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Seismitoad,
        abilities: new Ability[3]
        {
            SwiftSwim,
            PoisonTouch,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Throh = new(
        speciesName: "Throh",
        type1: Fighting,
        type2: Fighting,
        baseHP: 120,
        baseAttack: 100,
        baseDefense: 85,
        baseSpAtk: 30,
        baseSpDef: 85,
        baseSpeed: 45,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "throh", //Verify
        graphicsLocation: "throh", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Throh,
        abilities: new Ability[3]
        {
            Guts,
            InnerFocus,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Sawk = new(
        speciesName: "Sawk",
        type1: Fighting,
        type2: Fighting,
        baseHP: 75,
        baseAttack: 125,
        baseDefense: 75,
        baseSpAtk: 30,
        baseSpDef: 75,
        baseSpeed: 85,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sawk", //Verify
        graphicsLocation: "sawk", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sawk,
        abilities: new Ability[3]
        {
            Sturdy,
            InnerFocus,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Sewaddle = new(
        speciesName: "Sewaddle",
        type1: Bug,
        type2: Grass,
        baseHP: 45,
        baseAttack: 53,
        baseDefense: 70,
        baseSpAtk: 40,
        baseSpDef: 60,
        baseSpeed: 42,
        evYield: Defense,
        evolution: Evolution.Sewaddle,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "sewaddle", //Verify
        graphicsLocation: "sewaddle", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sewaddle,
        abilities: new Ability[3]
        {
            Swarm,
            Chlorophyll,
            Overcoat,
        }
    );
    public static readonly SpeciesData Swadloon = new(
        speciesName: "Swadloon",
        type1: Bug,
        type2: Grass,
        baseHP: 55,
        baseAttack: 63,
        baseDefense: 90,
        baseSpAtk: 50,
        baseSpDef: 80,
        baseSpeed: 42,
        evYield: 2 * Defense,
        evolution: Evolution.Swadloon,
        xpClass: MediumSlow,
        xpYield: 133,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "swadloon", //Verify
        graphicsLocation: "swadloon", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Swadloon,
        abilities: new Ability[3]
        {
            LeafGuard,
            Chlorophyll,
            Overcoat,
        }
    );
    public static readonly SpeciesData Leavanny = new(
        speciesName: "Leavanny",
        type1: Bug,
        type2: Grass,
        baseHP: 75,
        baseAttack: 103,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 92,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "leavanny", //Verify
        graphicsLocation: "leavanny", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Leavanny,
        abilities: new Ability[3]
        {
            Swarm,
            Chlorophyll,
            Overcoat,
        }
    );
    public static readonly SpeciesData Venipede = new(
        speciesName: "Venipede",
        type1: Bug,
        type2: Poison,
        baseHP: 30,
        baseAttack: 45,
        baseDefense: 59,
        baseSpAtk: 30,
        baseSpDef: 39,
        baseSpeed: 57,
        evYield: Defense,
        evolution: Evolution.Venipede,
        xpClass: MediumSlow,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "venipede", //Verify
        graphicsLocation: "venipede", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Venipede,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Swarm,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Whirlipede = new(
        speciesName: "Whirlipede",
        type1: Bug,
        type2: Poison,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 99,
        baseSpAtk: 40,
        baseSpDef: 79,
        baseSpeed: 47,
        evYield: 2 * Defense,
        evolution: Evolution.Whirlipede,
        xpClass: MediumSlow,
        xpYield: 126,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "whirlipede", //Verify
        graphicsLocation: "whirlipede", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Whirlipede,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Swarm,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Scolipede = new(
        speciesName: "Scolipede",
        type1: Bug,
        type2: Poison,
        baseHP: 60,
        baseAttack: 90,
        baseDefense: 89,
        baseSpAtk: 55,
        baseSpDef: 69,
        baseSpeed: 112,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 218,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "scolipede", //Verify
        graphicsLocation: "scolipede", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Scolipede,
        abilities: new Ability[3]
        {
            PoisonPoint,
            Swarm,
            QuickFeet,
        }
    );
    public static readonly SpeciesData Cottonee = new(
        speciesName: "Cottonee",
        type1: Grass,
        type2: Grass,
        baseHP: 40,
        baseAttack: 27,
        baseDefense: 60,
        baseSpAtk: 37,
        baseSpDef: 50,
        baseSpeed: 66,
        evYield: Speed,
        evolution: Evolution.Cottonee,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "cottonee", //Verify
        graphicsLocation: "cottonee", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Cottonee,
        abilities: new Ability[3]
        {
            Prankster,
            Infiltrator,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Whimsicott = new(
        speciesName: "Whimsicott",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 67,
        baseDefense: 85,
        baseSpAtk: 77,
        baseSpDef: 75,
        baseSpeed: 116,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "whimsicott", //Verify
        graphicsLocation: "whimsicott", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Whimsicott,
        abilities: new Ability[3]
        {
            Prankster,
            Infiltrator,
            Chlorophyll,
        }
    );
    public static readonly SpeciesData Petilil = new(
        speciesName: "Petilil",
        type1: Grass,
        type2: Grass,
        baseHP: 45,
        baseAttack: 35,
        baseDefense: 50,
        baseSpAtk: 70,
        baseSpDef: 50,
        baseSpeed: 30,
        evYield: SpAtk,
        evolution: Evolution.Petilil,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "petilil", //Verify
        graphicsLocation: "petilil", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Petilil,
        abilities: new Ability[3]
        {
            Chlorophyll,
            OwnTempo,
            LeafGuard,
        }
    );
    public static readonly SpeciesData Lilligant = new(
        speciesName: "Lilligant",
        type1: Grass,
        type2: Grass,
        baseHP: 70,
        baseAttack: 60,
        baseDefense: 75,
        baseSpAtk: 110,
        baseSpDef: 75,
        baseSpeed: 90,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "lilligant", //Verify
        graphicsLocation: "lilligant", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Lilligant,
        abilities: new Ability[3]
        {
            Chlorophyll,
            OwnTempo,
            LeafGuard,
        }
    );
    public static readonly SpeciesData BasculinRed = Basculin(
        "basculin", Reckless, Evolution.None);
    public static readonly SpeciesData Sandile = new(
        speciesName: "Sandile",
        type1: Ground,
        type2: Dark,
        baseHP: 50,
        baseAttack: 72,
        baseDefense: 35,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.Sandile,
        xpClass: MediumSlow,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "sandile", //Verify
        graphicsLocation: "sandile", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Sandile,
        abilities: new Ability[3]
        {
            Intimidate,
            Moxie,
            AngerPoint,
        }
    );
    public static readonly SpeciesData Krokorok = new(
        speciesName: "Krokorok",
        type1: Ground,
        type2: Dark,
        baseHP: 60,
        baseAttack: 82,
        baseDefense: 45,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 74,
        evYield: 2 * Attack,
        evolution: Evolution.Krokorok,
        xpClass: MediumSlow,
        xpYield: 123,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "krokorok", //Verify
        graphicsLocation: "krokorok", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Krokorok,
        abilities: new Ability[3]
        {
            Intimidate,
            Moxie,
            AngerPoint,
        }
    );
    public static readonly SpeciesData Krookodile = new(
        speciesName: "Krookodile",
        type1: Ground,
        type2: Dark,
        baseHP: 95,
        baseAttack: 117,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 92,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 234,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "krookodile", //Verify
        graphicsLocation: "krookodile", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Krookodile,
        abilities: new Ability[3]
        {
            Intimidate,
            Moxie,
            AngerPoint,
        }
    );
    public static readonly SpeciesData Darumaka = new(
        speciesName: "Darumaka",
        type1: Fire,
        type2: Fire,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 45,
        baseSpAtk: 15,
        baseSpDef: 45,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Darumaka,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "darumaka", //Verify
        graphicsLocation: "darumaka", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Darumaka,
        abilities: new Ability[3]
        {
            Hustle,
            Hustle,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Darmanitan = new(
        speciesName: "Darmanitan",
        type1: Fire,
        type2: Fire,
        baseHP: 105,
        baseAttack: 140,
        baseDefense: 55,
        baseSpAtk: 30,
        baseSpDef: 55,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "darmanitan", //Verify
        graphicsLocation: "darmanitan", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Darmanitan,
        abilities: new Ability[3]
        {
            SheerForce,
            SheerForce,
            ZenMode,
        }
    );
    public static readonly SpeciesData Maractus = new(
        speciesName: "Maractus",
        type1: Grass,
        type2: Grass,
        baseHP: 75,
        baseAttack: 86,
        baseDefense: 67,
        baseSpAtk: 106,
        baseSpDef: 67,
        baseSpeed: 60,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "maractus", //Verify
        graphicsLocation: "maractus", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Maractus,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            Chlorophyll,
            StormDrain,
        }
    );
    public static readonly SpeciesData Dwebble = new(
        speciesName: "Dwebble",
        type1: Bug,
        type2: Rock,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 85,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 55,
        evYield: Defense,
        evolution: Evolution.Dwebble,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "dwebble", //Verify
        graphicsLocation: "dwebble", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Dwebble,
        abilities: new Ability[3]
        {
            Sturdy,
            ShellArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Crustle = new(
        speciesName: "Crustle",
        type1: Bug,
        type2: Rock,
        baseHP: 70,
        baseAttack: 95,
        baseDefense: 125,
        baseSpAtk: 65,
        baseSpDef: 75,
        baseSpeed: 45,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "crustle", //Verify
        graphicsLocation: "crustle", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Crustle,
        abilities: new Ability[3]
        {
            Sturdy,
            ShellArmor,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Scraggy = new(
        speciesName: "Scraggy",
        type1: Dark,
        type2: Fighting,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 70,
        baseSpAtk: 35,
        baseSpDef: 70,
        baseSpeed: 48,
        evYield: Attack,
        evolution: Evolution.Scraggy,
        xpClass: MediumFast,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 15,
        catchRate: 180,
        baseFriendship: 35,
        cryLocation: "scraggy", //Verify
        graphicsLocation: "scraggy", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Scraggy,
        abilities: new Ability[3]
        {
            ShedSkin,
            Moxie,
            Intimidate,
        }
    );
    public static readonly SpeciesData Scrafty = new(
        speciesName: "Scrafty",
        type1: Dark,
        type2: Fighting,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 115,
        baseSpAtk: 45,
        baseSpDef: 115,
        baseSpeed: 58,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 171,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "scrafty", //Verify
        graphicsLocation: "scrafty", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Scrafty,
        abilities: new Ability[3]
        {
            ShedSkin,
            Moxie,
            Intimidate,
        }
    );
    public static readonly SpeciesData Sigilyph = new(
        speciesName: "Sigilyph",
        type1: Psychic,
        type2: Flying,
        baseHP: 72,
        baseAttack: 58,
        baseDefense: 80,
        baseSpAtk: 103,
        baseSpDef: 80,
        baseSpeed: 97,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sigilyph", //Verify
        graphicsLocation: "sigilyph", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Sigilyph,
        abilities: new Ability[3]
        {
            WonderSkin,
            MagicGuard,
            TintedLens,
        }
    );
    public static readonly SpeciesData Yamask = new(
        speciesName: "Yamask",
        type1: Ghost,
        type2: Ghost,
        baseHP: 38,
        baseAttack: 30,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Yamask,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "yamask", //Verify
        graphicsLocation: "yamask", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Yamask,
        abilities: new Ability[3]
        {
            Mummy,
            Mummy,
            Mummy,
        }
    );
    public static readonly SpeciesData Cofagrigus = new(
        speciesName: "Cofagrigus",
        type1: Ghost,
        type2: Ghost,
        baseHP: 58,
        baseAttack: 50,
        baseDefense: 145,
        baseSpAtk: 95,
        baseSpDef: 105,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "cofagrigus", //Verify
        graphicsLocation: "cofagrigus", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Cofagrigus,
        abilities: new Ability[3]
        {
            Mummy,
            Mummy,
            Mummy,
        }
    );
    public static readonly SpeciesData Tirtouga = new(
        speciesName: "Tirtouga",
        type1: Water,
        type2: Rock,
        baseHP: 54,
        baseAttack: 78,
        baseDefense: 103,
        baseSpAtk: 53,
        baseSpDef: 45,
        baseSpeed: 22,
        evYield: Defense,
        evolution: Evolution.Tirtouga,
        xpClass: MediumFast,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tirtouga", //Verify
        graphicsLocation: "tirtouga", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Tirtouga,
        abilities: new Ability[3]
        {
            SolidRock,
            Sturdy,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Carracosta = new(
        speciesName: "Carracosta",
        type1: Water,
        type2: Rock,
        baseHP: 74,
        baseAttack: 108,
        baseDefense: 133,
        baseSpAtk: 83,
        baseSpDef: 65,
        baseSpeed: 32,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "carracosta", //Verify
        graphicsLocation: "carracosta", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Carracosta,
        abilities: new Ability[3]
        {
            SolidRock,
            Sturdy,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Archen = new(
        speciesName: "Archen",
        type1: Rock,
        type2: Flying,
        baseHP: 55,
        baseAttack: 112,
        baseDefense: 45,
        baseSpAtk: 74,
        baseSpDef: 45,
        baseSpeed: 70,
        evYield: Attack,
        evolution: Evolution.Archen,
        xpClass: MediumFast,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "archen", //Verify
        graphicsLocation: "archen", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Archen,
        abilities: new Ability[3]
        {
            Defeatist,
            Defeatist,
            Defeatist,
        }
    );
    public static readonly SpeciesData Archeops = new(
        speciesName: "Archeops",
        type1: Rock,
        type2: Flying,
        baseHP: 75,
        baseAttack: 140,
        baseDefense: 65,
        baseSpAtk: 112,
        baseSpDef: 65,
        baseSpeed: 110,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Water3,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "archeops", //Verify
        graphicsLocation: "archeops", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Archeops,
        abilities: new Ability[3]
        {
            Defeatist,
            Defeatist,
            Defeatist,
        }
    );
    public static readonly SpeciesData Trubbish = new(
        speciesName: "Trubbish",
        type1: Poison,
        type2: Poison,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 62,
        baseSpAtk: 40,
        baseSpDef: 62,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Trubbish,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "trubbish", //Verify
        graphicsLocation: "trubbish", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Trubbish,
        abilities: new Ability[3]
        {
            Stench,
            StickyHold,
            Aftermath,
        }
    );
    public static readonly SpeciesData Garbodor = new(
        speciesName: "Garbodor",
        type1: Poison,
        type2: Poison,
        baseHP: 80,
        baseAttack: 95,
        baseDefense: 82,
        baseSpAtk: 60,
        baseSpDef: 82,
        baseSpeed: 75,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "garbodor", //Verify
        graphicsLocation: "garbodor", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Garbodor,
        abilities: new Ability[3]
        {
            Stench,
            WeakArmor,
            Aftermath,
        }
    );
    public static readonly SpeciesData Zorua = new(
        speciesName: "Zorua",
        type1: Dark,
        type2: Dark,
        baseHP: 40,
        baseAttack: 65,
        baseDefense: 40,
        baseSpAtk: 80,
        baseSpDef: 40,
        baseSpeed: 65,
        evYield: SpAtk,
        evolution: Evolution.Zorua,
        xpClass: MediumSlow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 25,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "zorua", //Verify
        graphicsLocation: "zorua", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Zorua,
        abilities: new Ability[3]
        {
            Illusion,
            Illusion,
            Illusion,
        }
    );
    public static readonly SpeciesData Zoroark = new(
        speciesName: "Zoroark",
        type1: Dark,
        type2: Dark,
        baseHP: 60,
        baseAttack: 105,
        baseDefense: 60,
        baseSpAtk: 120,
        baseSpDef: 60,
        baseSpeed: 105,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "zoroark", //Verify
        graphicsLocation: "zoroark", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Zoroark,
        abilities: new Ability[3]
        {
            Illusion,
            Illusion,
            Illusion,
        }
    );
    public static readonly SpeciesData Minccino = new(
        speciesName: "Minccino",
        type1: Normal,
        type2: Normal,
        baseHP: 55,
        baseAttack: 50,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 75,
        evYield: Speed,
        evolution: Evolution.Minccino,
        xpClass: Fast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "minccino", //Verify
        graphicsLocation: "minccino", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Minccino,
        abilities: new Ability[3]
        {
            CuteCharm,
            Technician,
            SkillLink,
        }
    );
    public static readonly SpeciesData Cinccino = new(
        speciesName: "Cinccino",
        type1: Normal,
        type2: Normal,
        baseHP: 75,
        baseAttack: 95,
        baseDefense: 60,
        baseSpAtk: 65,
        baseSpDef: 60,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "cinccino", //Verify
        graphicsLocation: "cinccino", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Cinccino,
        abilities: new Ability[3]
        {
            CuteCharm,
            Technician,
            SkillLink,
        }
    );
    public static readonly SpeciesData Gothita = new(
        speciesName: "Gothita",
        type1: Psychic,
        type2: Psychic,
        baseHP: 45,
        baseAttack: 30,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: SpDef,
        evolution: Evolution.Gothita,
        xpClass: MediumSlow,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "gothita", //Verify
        graphicsLocation: "gothita", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Gothita,
        abilities: new Ability[3]
        {
            Frisk,
            Competitive,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Gothorita = new(
        speciesName: "Gothorita",
        type1: Psychic,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 45,
        baseDefense: 70,
        baseSpAtk: 75,
        baseSpDef: 85,
        baseSpeed: 55,
        evYield: 2 * SpDef,
        evolution: Evolution.Gothorita,
        xpClass: MediumSlow,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "gothorita", //Verify
        graphicsLocation: "gothorita", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Gothorita,
        abilities: new Ability[3]
        {
            Frisk,
            Competitive,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Gothitelle = new(
        speciesName: "Gothitelle",
        type1: Psychic,
        type2: Psychic,
        baseHP: 70,
        baseAttack: 55,
        baseDefense: 95,
        baseSpAtk: 95,
        baseSpDef: 110,
        baseSpeed: 65,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "gothitelle", //Verify
        graphicsLocation: "gothitelle", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Gothitelle,
        abilities: new Ability[3]
        {
            Frisk,
            Competitive,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Solosis = new(
        speciesName: "Solosis",
        type1: Psychic,
        type2: Psychic,
        baseHP: 45,
        baseAttack: 30,
        baseDefense: 40,
        baseSpAtk: 105,
        baseSpDef: 50,
        baseSpeed: 20,
        evYield: SpAtk,
        evolution: Evolution.Solosis,
        xpClass: MediumSlow,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "solosis", //Verify
        graphicsLocation: "solosis", //Verify
        backSpriteHeight: 19,
        pokedexData: Pokedex.Solosis,
        abilities: new Ability[3]
        {
            Overcoat,
            MagicGuard,
            Regenerator,
        }
    );
    public static readonly SpeciesData Duosion = new(
        speciesName: "Duosion",
        type1: Psychic,
        type2: Psychic,
        baseHP: 65,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 125,
        baseSpDef: 60,
        baseSpeed: 30,
        evYield: 2 * SpAtk,
        evolution: Evolution.Duosion,
        xpClass: MediumSlow,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "duosion", //Verify
        graphicsLocation: "duosion", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Duosion,
        abilities: new Ability[3]
        {
            Overcoat,
            MagicGuard,
            Regenerator,
        }
    );
    public static readonly SpeciesData Reuniclus = new(
        speciesName: "Reuniclus",
        type1: Psychic,
        type2: Psychic,
        baseHP: 110,
        baseAttack: 65,
        baseDefense: 75,
        baseSpAtk: 125,
        baseSpDef: 85,
        baseSpeed: 30,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 221,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "reuniclus", //Verify
        graphicsLocation: "reuniclus", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Reuniclus,
        abilities: new Ability[3]
        {
            Overcoat,
            MagicGuard,
            Regenerator,
        }
    );
    public static readonly SpeciesData Ducklett = new(
        speciesName: "Ducklett",
        type1: Water,
        type2: Flying,
        baseHP: 62,
        baseAttack: 44,
        baseDefense: 50,
        baseSpAtk: 44,
        baseSpDef: 50,
        baseSpeed: 55,
        evYield: HP,
        evolution: Evolution.Ducklett,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "ducklett", //Verify
        graphicsLocation: "ducklett", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Ducklett,
        abilities: new Ability[3]
        {
            KeenEye,
            BigPecks,
            Hydration,
        }
    );
    public static readonly SpeciesData Swanna = new(
        speciesName: "Swanna",
        type1: Water,
        type2: Flying,
        baseHP: 75,
        baseAttack: 87,
        baseDefense: 63,
        baseSpAtk: 87,
        baseSpDef: 63,
        baseSpeed: 98,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "swanna", //Verify
        graphicsLocation: "swanna", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Swanna,
        abilities: new Ability[3]
        {
            KeenEye,
            BigPecks,
            Hydration,
        }
    );
    public static readonly SpeciesData Vanillite = new(
        speciesName: "Vanillite",
        type1: Ice,
        type2: Ice,
        baseHP: 36,
        baseAttack: 50,
        baseDefense: 50,
        baseSpAtk: 65,
        baseSpDef: 60,
        baseSpeed: 44,
        evYield: SpAtk,
        evolution: Evolution.Vanillite,
        xpClass: Slow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "vanillite", //Verify
        graphicsLocation: "vanillite", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Vanillite,
        abilities: new Ability[3]
        {
            IceBody,
            SnowCloak,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Vanillish = new(
        speciesName: "Vanillish",
        type1: Ice,
        type2: Ice,
        baseHP: 51,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 80,
        baseSpDef: 75,
        baseSpeed: 59,
        evYield: 2 * SpAtk,
        evolution: Evolution.Vanillish,
        xpClass: Slow,
        xpYield: 138,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "vanillish", //Verify
        graphicsLocation: "vanillish", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Vanillish,
        abilities: new Ability[3]
        {
            IceBody,
            SnowCloak,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Vanilluxe = new(
        speciesName: "Vanilluxe",
        type1: Ice,
        type2: Ice,
        baseHP: 71,
        baseAttack: 95,
        baseDefense: 85,
        baseSpAtk: 110,
        baseSpDef: 95,
        baseSpeed: 79,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 241,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vanilluxe", //Verify
        graphicsLocation: "vanilluxe", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Vanilluxe,
        abilities: new Ability[3]
        {
            IceBody,
            SnowWarning,
            WeakArmor,
        }
    );

    public static readonly SpeciesData DeerlingSpring = Deerling("deerling", Evolution.DeerlingSpring);
    public static readonly SpeciesData SawsbuckSpring = Sawsbuck("sawsbuck");

    public static readonly SpeciesData Emolga = new(
        speciesName: "Emolga",
        type1: Electric,
        type2: Flying,
        baseHP: 55,
        baseAttack: 75,
        baseDefense: 60,
        baseSpAtk: 75,
        baseSpDef: 60,
        baseSpeed: 103,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 150,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "emolga", //Verify
        graphicsLocation: "emolga", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Emolga,
        abilities: new Ability[3]
        {
            Static,
            Static,
            MotorDrive,
        }
    );
    public static readonly SpeciesData Karrablast = new(
        speciesName: "Karrablast",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 45,
        baseSpAtk: 40,
        baseSpDef: 45,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Karrablast,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "karrablast", //Verify
        graphicsLocation: "karrablast", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Karrablast,
        abilities: new Ability[3]
        {
            Swarm,
            ShedSkin,
            NoGuard,
        }
    );
    public static readonly SpeciesData Escavalier = new(
        speciesName: "Escavalier",
        type1: Bug,
        type2: Steel,
        baseHP: 70,
        baseAttack: 135,
        baseDefense: 105,
        baseSpAtk: 60,
        baseSpDef: 105,
        baseSpeed: 20,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "escavalier", //Verify
        graphicsLocation: "escavalier", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Escavalier,
        abilities: new Ability[3]
        {
            Swarm,
            ShellArmor,
            Overcoat,
        }
    );
    public static readonly SpeciesData Foongus = new(
        speciesName: "Foongus",
        type1: Grass,
        type2: Poison,
        baseHP: 69,
        baseAttack: 55,
        baseDefense: 45,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 15,
        evYield: HP,
        evolution: Evolution.Foongus,
        xpClass: MediumFast,
        xpYield: 59,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "foongus", //Verify
        graphicsLocation: "foongus", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Foongus,
        abilities: new Ability[3]
        {
            EffectSpore,
            EffectSpore,
            Regenerator,
        }
    );
    public static readonly SpeciesData Amoonguss = new(
        speciesName: "Amoonguss",
        type1: Grass,
        type2: Poison,
        baseHP: 114,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 85,
        baseSpDef: 80,
        baseSpeed: 30,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 162,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "amoonguss", //Verify
        graphicsLocation: "amoonguss", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Amoonguss,
        abilities: new Ability[3]
        {
            EffectSpore,
            EffectSpore,
            Regenerator,
        }
    );
    public static readonly SpeciesData Frillish = new(
        speciesName: "Frillish",
        type1: Water,
        type2: Ghost,
        baseHP: 55,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 65,
        baseSpDef: 85,
        baseSpeed: 40,
        evYield: SpDef,
        evolution: Evolution.Frillish,
        xpClass: MediumFast,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "frillish", //Verify
        graphicsLocation: "frillish", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Frillish,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            CursedBody,
            Damp,
        }
    );
    public static readonly SpeciesData Jellicent = new(
        speciesName: "Jellicent",
        type1: Water,
        type2: Ghost,
        baseHP: 100,
        baseAttack: 60,
        baseDefense: 70,
        baseSpAtk: 85,
        baseSpDef: 105,
        baseSpeed: 60,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "jellicent", //Verify
        graphicsLocation: "jellicent", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Jellicent,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            CursedBody,
            Damp,
        }
    );
    public static readonly SpeciesData Alomomola = new(
        speciesName: "Alomomola",
        type1: Water,
        type2: Water,
        baseHP: 165,
        baseAttack: 75,
        baseDefense: 80,
        baseSpAtk: 40,
        baseSpDef: 45,
        baseSpeed: 65,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "alomomola", //Verify
        graphicsLocation: "alomomola", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Alomomola,
        abilities: new Ability[3]
        {
            Healer,
            Hydration,
            Regenerator,
        }
    );
    public static readonly SpeciesData Joltik = new(
        speciesName: "Joltik",
        type1: Bug,
        type2: Electric,
        baseHP: 50,
        baseAttack: 47,
        baseDefense: 50,
        baseSpAtk: 57,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.Joltik,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "joltik", //Verify
        graphicsLocation: "joltik", //Verify
        backSpriteHeight: 19,
        pokedexData: Pokedex.Joltik,
        abilities: new Ability[3]
        {
            CompoundEyes,
            Unnerve,
            Swarm,
        }
    );
    public static readonly SpeciesData Galvantula = new(
        speciesName: "Galvantula",
        type1: Bug,
        type2: Electric,
        baseHP: 70,
        baseAttack: 77,
        baseDefense: 60,
        baseSpAtk: 97,
        baseSpDef: 60,
        baseSpeed: 108,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "galvantula", //Verify
        graphicsLocation: "galvantula", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Galvantula,
        abilities: new Ability[3]
        {
            CompoundEyes,
            Unnerve,
            Swarm,
        }
    );
    public static readonly SpeciesData Ferroseed = new(
        speciesName: "Ferroseed",
        type1: Grass,
        type2: Steel,
        baseHP: 44,
        baseAttack: 50,
        baseDefense: 91,
        baseSpAtk: 24,
        baseSpDef: 86,
        baseSpeed: 10,
        evYield: Defense,
        evolution: Evolution.Ferroseed,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "ferroseed", //Verify
        graphicsLocation: "ferroseed", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Ferroseed,
        abilities: new Ability[3]
        {
            IronBarbs,
            IronBarbs,
            IronBarbs,
        }
    );
    public static readonly SpeciesData Ferrothorn = new(
        speciesName: "Ferrothorn",
        type1: Grass,
        type2: Steel,
        baseHP: 74,
        baseAttack: 94,
        baseDefense: 131,
        baseSpAtk: 54,
        baseSpDef: 116,
        baseSpeed: 20,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 171,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "ferrothorn", //Verify
        graphicsLocation: "ferrothorn", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Ferrothorn,
        abilities: new Ability[3]
        {
            IronBarbs,
            IronBarbs,
            Anticipation,
        }
    );
    public static readonly SpeciesData Klink = new(
        speciesName: "Klink",
        type1: Steel,
        type2: Steel,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 70,
        baseSpAtk: 45,
        baseSpDef: 60,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Klink,
        xpClass: MediumSlow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 130,
        baseFriendship: 70,
        cryLocation: "klink", //Verify
        graphicsLocation: "klink", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Klink,
        abilities: new Ability[3]
        {
            Plus,
            Minus,
            ClearBody,
        }
    );
    public static readonly SpeciesData Klang = new(
        speciesName: "Klang",
        type1: Steel,
        type2: Steel,
        baseHP: 60,
        baseAttack: 80,
        baseDefense: 95,
        baseSpAtk: 70,
        baseSpDef: 85,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.Klang,
        xpClass: MediumSlow,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "klang", //Verify
        graphicsLocation: "klang", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Klang,
        abilities: new Ability[3]
        {
            Plus,
            Minus,
            ClearBody,
        }
    );
    public static readonly SpeciesData Klinklang = new(
        speciesName: "Klinklang",
        type1: Steel,
        type2: Steel,
        baseHP: 60,
        baseAttack: 100,
        baseDefense: 115,
        baseSpAtk: 70,
        baseSpDef: 85,
        baseSpeed: 90,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 234,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "klinklang", //Verify
        graphicsLocation: "klinklang", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Klinklang,
        abilities: new Ability[3]
        {
            Plus,
            Minus,
            ClearBody,
        }
    );
    public static readonly SpeciesData Tynamo = new(
        speciesName: "Tynamo",
        type1: Electric,
        type2: Electric,
        baseHP: 35,
        baseAttack: 55,
        baseDefense: 40,
        baseSpAtk: 45,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: Speed,
        evolution: Evolution.Tynamo,
        xpClass: Slow,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "tynamo", //Verify
        graphicsLocation: "tynamo", //Verify
        backSpriteHeight: 21,
        pokedexData: Pokedex.Tynamo,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Eelektrik = new(
        speciesName: "Eelektrik",
        type1: Electric,
        type2: Electric,
        baseHP: 65,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 75,
        baseSpDef: 70,
        baseSpeed: 40,
        evYield: 2 * Attack,
        evolution: Evolution.Eelektrik,
        xpClass: Slow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "eelektrik", //Verify
        graphicsLocation: "eelektrik", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Eelektrik,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Eelektross = new(
        speciesName: "Eelektross",
        type1: Electric,
        type2: Electric,
        baseHP: 85,
        baseAttack: 115,
        baseDefense: 80,
        baseSpAtk: 105,
        baseSpDef: 80,
        baseSpeed: 50,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 232,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "eelektross", //Verify
        graphicsLocation: "eelektross", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Eelektross,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Elgyem = new(
        speciesName: "Elgyem",
        type1: Psychic,
        type2: Psychic,
        baseHP: 55,
        baseAttack: 55,
        baseDefense: 55,
        baseSpAtk: 85,
        baseSpDef: 55,
        baseSpeed: 30,
        evYield: SpAtk,
        evolution: Evolution.Elgyem,
        xpClass: MediumFast,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "elgyem", //Verify
        graphicsLocation: "elgyem", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Elgyem,
        abilities: new Ability[3]
        {
            Telepathy,
            Synchronize,
            Analytic,
        }
    );
    public static readonly SpeciesData Beheeyem = new(
        speciesName: "Beheeyem",
        type1: Psychic,
        type2: Psychic,
        baseHP: 75,
        baseAttack: 75,
        baseDefense: 75,
        baseSpAtk: 125,
        baseSpDef: 95,
        baseSpeed: 40,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "beheeyem", //Verify
        graphicsLocation: "beheeyem", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Beheeyem,
        abilities: new Ability[3]
        {
            Telepathy,
            Synchronize,
            Analytic,
        }
    );
    public static readonly SpeciesData Litwick = new(
        speciesName: "Litwick",
        type1: Ghost,
        type2: Fire,
        baseHP: 50,
        baseAttack: 30,
        baseDefense: 55,
        baseSpAtk: 65,
        baseSpDef: 55,
        baseSpeed: 20,
        evYield: SpAtk,
        evolution: Evolution.Litwick,
        xpClass: MediumSlow,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "litwick", //Verify
        graphicsLocation: "litwick", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Litwick,
        abilities: new Ability[3]
        {
            FlashFire,
            FlameBody,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Lampent = new(
        speciesName: "Lampent",
        type1: Ghost,
        type2: Fire,
        baseHP: 60,
        baseAttack: 40,
        baseDefense: 60,
        baseSpAtk: 95,
        baseSpDef: 60,
        baseSpeed: 55,
        evYield: 2 * SpAtk,
        evolution: Evolution.Lampent,
        xpClass: MediumSlow,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "lampent", //Verify
        graphicsLocation: "lampent", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Lampent,
        abilities: new Ability[3]
        {
            FlashFire,
            FlameBody,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Chandelure = new(
        speciesName: "Chandelure",
        type1: Ghost,
        type2: Fire,
        baseHP: 60,
        baseAttack: 55,
        baseDefense: 90,
        baseSpAtk: 145,
        baseSpDef: 90,
        baseSpeed: 80,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 234,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chandelure", //Verify
        graphicsLocation: "chandelure", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Chandelure,
        abilities: new Ability[3]
        {
            FlashFire,
            FlameBody,
            ShadowTag,
        }
    );
    public static readonly SpeciesData Axew = new(
        speciesName: "Axew",
        type1: Dragon,
        type2: Dragon,
        baseHP: 46,
        baseAttack: 87,
        baseDefense: 60,
        baseSpAtk: 30,
        baseSpDef: 40,
        baseSpeed: 57,
        evYield: Attack,
        evolution: Evolution.Axew,
        xpClass: Slow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 75,
        baseFriendship: 35,
        cryLocation: "axew", //Verify
        graphicsLocation: "axew", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Axew,
        abilities: new Ability[3]
        {
            Rivalry,
            MoldBreaker,
            Unnerve,
        }
    );
    public static readonly SpeciesData Fraxure = new(
        speciesName: "Fraxure",
        type1: Dragon,
        type2: Dragon,
        baseHP: 66,
        baseAttack: 117,
        baseDefense: 70,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 67,
        evYield: 2 * Attack,
        evolution: Evolution.Fraxure,
        xpClass: Slow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "fraxure", //Verify
        graphicsLocation: "fraxure", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Fraxure,
        abilities: new Ability[3]
        {
            Rivalry,
            MoldBreaker,
            Unnerve,
        }
    );
    public static readonly SpeciesData Haxorus = new(
        speciesName: "Haxorus",
        type1: Dragon,
        type2: Dragon,
        baseHP: 76,
        baseAttack: 147,
        baseDefense: 90,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 97,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 243,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "haxorus", //Verify
        graphicsLocation: "haxorus", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Haxorus,
        abilities: new Ability[3]
        {
            Rivalry,
            MoldBreaker,
            Unnerve,
        }
    );
    public static readonly SpeciesData Cubchoo = new(
        speciesName: "Cubchoo",
        type1: Ice,
        type2: Ice,
        baseHP: 55,
        baseAttack: 70,
        baseDefense: 40,
        baseSpAtk: 60,
        baseSpDef: 40,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Cubchoo,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "cubchoo", //Verify
        graphicsLocation: "cubchoo", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Cubchoo,
        abilities: new Ability[3]
        {
            SnowCloak,
            SlushRush,
            Rattled,
        }
    );
    public static readonly SpeciesData Beartic = new(
        speciesName: "Beartic",
        type1: Ice,
        type2: Ice,
        baseHP: 95,
        baseAttack: 110,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 50,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "beartic", //Verify
        graphicsLocation: "beartic", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Beartic,
        abilities: new Ability[3]
        {
            SnowCloak,
            SlushRush,
            SwiftSwim,
        }
    );
    public static readonly SpeciesData Cryogonal = new(
        speciesName: "Cryogonal",
        type1: Ice,
        type2: Ice,
        baseHP: 70,
        baseAttack: 50,
        baseDefense: 30,
        baseSpAtk: 95,
        baseSpDef: 135,
        baseSpeed: 105,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "cryogonal", //Verify
        graphicsLocation: "cryogonal", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Cryogonal,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Shelmet = new(
        speciesName: "Shelmet",
        type1: Bug,
        type2: Bug,
        baseHP: 50,
        baseAttack: 40,
        baseDefense: 85,
        baseSpAtk: 40,
        baseSpDef: 65,
        baseSpeed: 25,
        evYield: Defense,
        evolution: Evolution.Shelmet,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "shelmet", //Verify
        graphicsLocation: "shelmet", //Verify
        backSpriteHeight: 19,
        pokedexData: Pokedex.Shelmet,
        abilities: new Ability[3]
        {
            Hydration,
            ShellArmor,
            Overcoat,
        }
    );
    public static readonly SpeciesData Accelgor = new(
        speciesName: "Accelgor",
        type1: Bug,
        type2: Bug,
        baseHP: 80,
        baseAttack: 70,
        baseDefense: 40,
        baseSpAtk: 100,
        baseSpDef: 60,
        baseSpeed: 145,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "accelgor", //Verify
        graphicsLocation: "accelgor", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Accelgor,
        abilities: new Ability[3]
        {
            Hydration,
            StickyHold,
            Unburden,
        }
    );
    public static readonly SpeciesData Stunfisk = new(
        speciesName: "Stunfisk",
        type1: Ground,
        type2: Electric,
        baseHP: 109,
        baseAttack: 66,
        baseDefense: 84,
        baseSpAtk: 81,
        baseSpDef: 99,
        baseSpeed: 32,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "stunfisk", //Verify
        graphicsLocation: "stunfisk", //Verify
        backSpriteHeight: 22,
        pokedexData: Pokedex.Stunfisk,
        abilities: new Ability[3]
        {
            Static,
            Limber,
            SandVeil,
        }
    );
    public static readonly SpeciesData Mienfoo = new(
        speciesName: "Mienfoo",
        type1: Fighting,
        type2: Fighting,
        baseHP: 45,
        baseAttack: 85,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 50,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.Mienfoo,
        xpClass: MediumSlow,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "mienfoo", //Verify
        graphicsLocation: "mienfoo", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Mienfoo,
        abilities: new Ability[3]
        {
            InnerFocus,
            Regenerator,
            Reckless,
        }
    );
    public static readonly SpeciesData Mienshao = new(
        speciesName: "Mienshao",
        type1: Fighting,
        type2: Fighting,
        baseHP: 65,
        baseAttack: 125,
        baseDefense: 60,
        baseSpAtk: 95,
        baseSpDef: 60,
        baseSpeed: 105,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mienshao", //Verify
        graphicsLocation: "mienshao", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Mienshao,
        abilities: new Ability[3]
        {
            InnerFocus,
            Regenerator,
            Reckless,
        }
    );
    public static readonly SpeciesData Druddigon = new(
        speciesName: "Druddigon",
        type1: Dragon,
        type2: Dragon,
        baseHP: 77,
        baseAttack: 120,
        baseDefense: 90,
        baseSpAtk: 60,
        baseSpDef: 90,
        baseSpeed: 48,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "druddigon", //Verify
        graphicsLocation: "druddigon", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Druddigon,
        abilities: new Ability[3]
        {
            RoughSkin,
            SheerForce,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Golett = new(
        speciesName: "Golett",
        type1: Ground,
        type2: Ghost,
        baseHP: 59,
        baseAttack: 74,
        baseDefense: 50,
        baseSpAtk: 35,
        baseSpDef: 50,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Golett,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "golett", //Verify
        graphicsLocation: "golett", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Golett,
        abilities: new Ability[3]
        {
            IronFist,
            Klutz,
            NoGuard,
        }
    );
    public static readonly SpeciesData Golurk = new(
        speciesName: "Golurk",
        type1: Ground,
        type2: Ghost,
        baseHP: 89,
        baseAttack: 124,
        baseDefense: 80,
        baseSpAtk: 55,
        baseSpDef: 80,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "golurk", //Verify
        graphicsLocation: "golurk", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Golurk,
        abilities: new Ability[3]
        {
            IronFist,
            Klutz,
            NoGuard,
        }
    );
    public static readonly SpeciesData Pawniard = new(
        speciesName: "Pawniard",
        type1: Dark,
        type2: Steel,
        baseHP: 45,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Pawniard,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 35,
        cryLocation: "pawniard", //Verify
        graphicsLocation: "pawniard", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Pawniard,
        abilities: new Ability[3]
        {
            Defiant,
            InnerFocus,
            Pressure,
        }
    );
    public static readonly SpeciesData Bisharp = new(
        speciesName: "Bisharp",
        type1: Dark,
        type2: Steel,
        baseHP: 65,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.None, //Not done
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "bisharp", //Verify
        graphicsLocation: "bisharp", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Bisharp,
        abilities: new Ability[3]
        {
            Defiant,
            InnerFocus,
            Pressure,
        }
    );
    public static readonly SpeciesData Bouffalant = new(
        speciesName: "Bouffalant",
        type1: Normal,
        type2: Normal,
        baseHP: 95,
        baseAttack: 110,
        baseDefense: 95,
        baseSpAtk: 40,
        baseSpDef: 95,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "bouffalant", //Verify
        graphicsLocation: "bouffalant", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Bouffalant,
        abilities: new Ability[3]
        {
            Reckless,
            SapSipper,
            Soundproof,
        }
    );
    public static readonly SpeciesData Rufflet = new(
        speciesName: "Rufflet",
        type1: Normal,
        type2: Flying,
        baseHP: 70,
        baseAttack: 83,
        baseDefense: 50,
        baseSpAtk: 37,
        baseSpDef: 50,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Rufflet,
        xpClass: Slow,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "rufflet", //Verify
        graphicsLocation: "rufflet", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Rufflet,
        abilities: new Ability[3]
        {
            KeenEye,
            SheerForce,
            Hustle,
        }
    );
    public static readonly SpeciesData Braviary = new(
        speciesName: "Braviary",
        type1: Normal,
        type2: Flying,
        baseHP: 100,
        baseAttack: 123,
        baseDefense: 75,
        baseSpAtk: 57,
        baseSpDef: 75,
        baseSpeed: 80,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "braviary", //Verify
        graphicsLocation: "braviary", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Braviary,
        abilities: new Ability[3]
        {
            KeenEye,
            SheerForce,
            Defiant,
        }
    );
    public static readonly SpeciesData Vullaby = new(
        speciesName: "Vullaby",
        type1: Dark,
        type2: Flying,
        baseHP: 70,
        baseAttack: 55,
        baseDefense: 75,
        baseSpAtk: 45,
        baseSpDef: 65,
        baseSpeed: 60,
        evYield: Defense,
        evolution: Evolution.Vullaby,
        xpClass: Slow,
        xpYield: 74,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 35,
        cryLocation: "vullaby", //Verify
        graphicsLocation: "vullaby", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Vullaby,
        abilities: new Ability[3]
        {
            BigPecks,
            Overcoat,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Mandibuzz = new(
        speciesName: "Mandibuzz",
        type1: Dark,
        type2: Flying,
        baseHP: 110,
        baseAttack: 65,
        baseDefense: 105,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 80,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "mandibuzz", //Verify
        graphicsLocation: "mandibuzz", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Mandibuzz,
        abilities: new Ability[3]
        {
            BigPecks,
            Overcoat,
            WeakArmor,
        }
    );
    public static readonly SpeciesData Heatmor = new(
        speciesName: "Heatmor",
        type1: Fire,
        type2: Fire,
        baseHP: 85,
        baseAttack: 97,
        baseDefense: 66,
        baseSpAtk: 105,
        baseSpDef: 66,
        baseSpeed: 65,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "heatmor", //Verify
        graphicsLocation: "heatmor", //Verify
        backSpriteHeight: 21,
        pokedexData: Pokedex.Heatmor,
        abilities: new Ability[3]
        {
            Gluttony,
            FlashFire,
            WhiteSmoke,
        }
    );
    public static readonly SpeciesData Durant = new(
        speciesName: "Durant",
        type1: Bug,
        type2: Steel,
        baseHP: 58,
        baseAttack: 109,
        baseDefense: 112,
        baseSpAtk: 48,
        baseSpDef: 48,
        baseSpeed: 109,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "durant", //Verify
        graphicsLocation: "durant", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Durant,
        abilities: new Ability[3]
        {
            Swarm,
            Hustle,
            Truant,
        }
    );
    public static readonly SpeciesData Deino = new(
        speciesName: "Deino",
        type1: Dark,
        type2: Dragon,
        baseHP: 52,
        baseAttack: 65,
        baseDefense: 50,
        baseSpAtk: 45,
        baseSpDef: 50,
        baseSpeed: 38,
        evYield: Attack,
        evolution: Evolution.Deino,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "deino", //Verify
        graphicsLocation: "deino", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Deino,
        abilities: new Ability[3]
        {
            Hustle,
            Hustle,
            Hustle,
        }
    );
    public static readonly SpeciesData Zweilous = new(
        speciesName: "Zweilous",
        type1: Dark,
        type2: Dragon,
        baseHP: 72,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 58,
        evYield: 2 * Attack,
        evolution: Evolution.Zweilous,
        xpClass: Slow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "zweilous", //Verify
        graphicsLocation: "zweilous", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Zweilous,
        abilities: new Ability[3]
        {
            Hustle,
            Hustle,
            Hustle,
        }
    );
    public static readonly SpeciesData Hydreigon = new(
        speciesName: "Hydreigon",
        type1: Dark,
        type2: Dragon,
        baseHP: 92,
        baseAttack: 105,
        baseDefense: 90,
        baseSpAtk: 125,
        baseSpDef: 90,
        baseSpeed: 98,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "hydreigon", //Verify
        graphicsLocation: "hydreigon", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Hydreigon,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Larvesta = new(
        speciesName: "Larvesta",
        type1: Bug,
        type2: Fire,
        baseHP: 55,
        baseAttack: 85,
        baseDefense: 55,
        baseSpAtk: 50,
        baseSpDef: 55,
        baseSpeed: 60,
        evYield: Attack,
        evolution: Evolution.Larvesta,
        xpClass: Slow,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "larvesta", //Verify
        graphicsLocation: "larvesta", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Larvesta,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            Swarm,
        }
    );
    public static readonly SpeciesData Volcarona = new(
        speciesName: "Volcarona",
        type1: Bug,
        type2: Fire,
        baseHP: 85,
        baseAttack: 60,
        baseDefense: 65,
        baseSpAtk: 135,
        baseSpDef: 105,
        baseSpeed: 100,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 248,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 40,
        catchRate: 15,
        baseFriendship: 70,
        cryLocation: "volcarona", //Verify
        graphicsLocation: "volcarona", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Volcarona,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            Swarm,
        }
    );
    public static readonly SpeciesData Cobalion = new(
        speciesName: "Cobalion",
        type1: Steel,
        type2: Fighting,
        baseHP: 91,
        baseAttack: 90,
        baseDefense: 129,
        baseSpAtk: 90,
        baseSpDef: 72,
        baseSpeed: 108,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "cobalion", //Verify
        graphicsLocation: "cobalion", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Cobalion,
        abilities: new Ability[3]
        {
            Justified,
            Justified,
            Justified,
        }
    );
    public static readonly SpeciesData Terrakion = new(
        speciesName: "Terrakion",
        type1: Rock,
        type2: Fighting,
        baseHP: 91,
        baseAttack: 129,
        baseDefense: 90,
        baseSpAtk: 72,
        baseSpDef: 90,
        baseSpeed: 108,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "terrakion", //Verify
        graphicsLocation: "terrakion", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Terrakion,
        abilities: new Ability[3]
        {
            Justified,
            Justified,
            Justified,
        }
    );
    public static readonly SpeciesData Virizion = new(
        speciesName: "Virizion",
        type1: Grass,
        type2: Fighting,
        baseHP: 91,
        baseAttack: 90,
        baseDefense: 72,
        baseSpAtk: 90,
        baseSpDef: 129,
        baseSpeed: 108,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "virizion", //Verify
        graphicsLocation: "virizion", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Virizion,
        abilities: new Ability[3]
        {
            Justified,
            Justified,
            Justified,
        }
    );
    public static readonly SpeciesData TornadusI = new(
        speciesName: "Tornadus",
        type1: Flying,
        type2: Flying,
        baseHP: 79,
        baseAttack: 115,
        baseDefense: 70,
        baseSpAtk: 125,
        baseSpDef: 80,
        baseSpeed: 111,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "tornadus", //Verify
        graphicsLocation: "tornadus", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Tornadus,
        abilities: new Ability[3]
        {
            Prankster,
            Prankster,
            Defiant,
        }
    );
    public static readonly SpeciesData ThundurusI = new(
        speciesName: "Thundurus",
        type1: Electric,
        type2: Flying,
        baseHP: 79,
        baseAttack: 115,
        baseDefense: 70,
        baseSpAtk: 125,
        baseSpDef: 80,
        baseSpeed: 111,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "thundurus", //Verify
        graphicsLocation: "thundurus", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Thundurus,
        abilities: new Ability[3]
        {
            Prankster,
            Prankster,
            Defiant,
        }
    );
    public static readonly SpeciesData Reshiram = new(
        speciesName: "Reshiram",
        type1: Dragon,
        type2: Fire,
        baseHP: 100,
        baseAttack: 120,
        baseDefense: 100,
        baseSpAtk: 150,
        baseSpDef: 120,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "reshiram", //Verify
        graphicsLocation: "reshiram", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Reshiram,
        abilities: new Ability[3]
        {
            Turboblaze,
            Turboblaze,
            Turboblaze,
        }
    );
    public static readonly SpeciesData Zekrom = new(
        speciesName: "Zekrom",
        type1: Dragon,
        type2: Electric,
        baseHP: 100,
        baseAttack: 150,
        baseDefense: 120,
        baseSpAtk: 120,
        baseSpDef: 100,
        baseSpeed: 90,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "zekrom", //Verify
        graphicsLocation: "zekrom", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Zekrom,
        abilities: new Ability[3]
        {
            Teravolt,
            Teravolt,
            Teravolt,
        }
    );
    public static readonly SpeciesData LandorusI = new(
        speciesName: "Landorus",
        type1: Ground,
        type2: Flying,
        baseHP: 89,
        baseAttack: 125,
        baseDefense: 90,
        baseSpAtk: 115,
        baseSpDef: 80,
        baseSpeed: 101,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "landorus", //Verify
        graphicsLocation: "landorus", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Landorus,
        abilities: new Ability[3]
        {
            SandForce,
            SandForce,
            SheerForce,
        }
    );
    public static readonly SpeciesData Kyurem = new(
        speciesName: "Kyurem",
        type1: Dragon,
        type2: Ice,
        baseHP: 125,
        baseAttack: 130,
        baseDefense: 90,
        baseSpAtk: 130,
        baseSpDef: 90,
        baseSpeed: 95,
        evYield: HP + Attack + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 297,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "kyurem", //Verify
        graphicsLocation: "kyurem", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Kyurem,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Pressure,
        }
    );
    public static readonly SpeciesData KeldeoOriginal = Keldeo(false);
    public static readonly SpeciesData MeloettaAria = new(
        speciesName: "Meloetta",
        type1: Normal,
        type2: Psychic,
        baseHP: 100,
        baseAttack: 77,
        baseDefense: 77,
        baseSpAtk: 128,
        baseSpDef: 128,
        baseSpeed: 90,
        evYield: Speed + SpAtk + SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "meloetta", //Verify
        graphicsLocation: "meloetta", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Meloetta,
        abilities: new Ability[3]
        {
            SereneGrace,
            SereneGrace,
            SereneGrace,
        }
    );

    public static readonly SpeciesData GenesectNormal = Genesect("genesect");

    public static readonly SpeciesData Chespin = new(
        speciesName: "Chespin",
        type1: Grass,
        type2: Grass,
        baseHP: 56,
        baseAttack: 61,
        baseDefense: 65,
        baseSpAtk: 48,
        baseSpDef: 45,
        baseSpeed: 38,
        evYield: Defense,
        evolution: Evolution.Chespin,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chespin", //Verify
        graphicsLocation: "chespin", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Chespin,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Bulletproof,
        }
    );
    public static readonly SpeciesData Quilladin = new(
        speciesName: "Quilladin",
        type1: Grass,
        type2: Grass,
        baseHP: 61,
        baseAttack: 78,
        baseDefense: 95,
        baseSpAtk: 56,
        baseSpDef: 58,
        baseSpeed: 57,
        evYield: 2 * Defense,
        evolution: Evolution.Quilladin,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "quilladin", //Verify
        graphicsLocation: "quilladin", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Quilladin,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Bulletproof,
        }
    );
    public static readonly SpeciesData Chesnaught = new(
        speciesName: "Chesnaught",
        type1: Grass,
        type2: Fighting,
        baseHP: 88,
        baseAttack: 107,
        baseDefense: 122,
        baseSpAtk: 74,
        baseSpDef: 75,
        baseSpeed: 64,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "chesnaught", //Verify
        graphicsLocation: "chesnaught", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Chesnaught,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            Bulletproof,
        }
    );
    public static readonly SpeciesData Fennekin = new(
        speciesName: "Fennekin",
        type1: Fire,
        type2: Fire,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 40,
        baseSpAtk: 62,
        baseSpDef: 60,
        baseSpeed: 60,
        evYield: SpAtk,
        evolution: Evolution.Fennekin,
        xpClass: MediumSlow,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "fennekin", //Verify
        graphicsLocation: "fennekin", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Fennekin,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Magician,
        }
    );
    public static readonly SpeciesData Braixen = new(
        speciesName: "Braixen",
        type1: Fire,
        type2: Fire,
        baseHP: 59,
        baseAttack: 59,
        baseDefense: 58,
        baseSpAtk: 90,
        baseSpDef: 70,
        baseSpeed: 73,
        evYield: 2 * SpAtk,
        evolution: Evolution.Braixen,
        xpClass: MediumSlow,
        xpYield: 143,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "braixen", //Verify
        graphicsLocation: "braixen", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Braixen,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Magician,
        }
    );
    public static readonly SpeciesData Delphox = new(
        speciesName: "Delphox",
        type1: Fire,
        type2: Psychic,
        baseHP: 75,
        baseAttack: 69,
        baseDefense: 72,
        baseSpAtk: 114,
        baseSpDef: 100,
        baseSpeed: 104,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 240,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "delphox", //Verify
        graphicsLocation: "delphox", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Delphox,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Magician,
        }
    );
    public static readonly SpeciesData Froakie = new(
        speciesName: "Froakie",
        type1: Water,
        type2: Water,
        baseHP: 41,
        baseAttack: 56,
        baseDefense: 40,
        baseSpAtk: 62,
        baseSpDef: 44,
        baseSpeed: 71,
        evYield: Speed,
        evolution: Evolution.Froakie,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "froakie", //Verify
        graphicsLocation: "froakie", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Froakie,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Protean,
        }
    );
    public static readonly SpeciesData Frogadier = new(
        speciesName: "Frogadier",
        type1: Water,
        type2: Water,
        baseHP: 54,
        baseAttack: 63,
        baseDefense: 52,
        baseSpAtk: 83,
        baseSpDef: 56,
        baseSpeed: 97,
        evYield: 2 * Speed,
        evolution: Evolution.Frogadier,
        xpClass: MediumSlow,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "frogadier", //Verify
        graphicsLocation: "frogadier", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Frogadier,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Protean,
        }
    );
    public static readonly SpeciesData Greninja = new(
        speciesName: "Greninja",
        type1: Water,
        type2: Dark,
        baseHP: 72,
        baseAttack: 95,
        baseDefense: 67,
        baseSpAtk: 103,
        baseSpDef: 71,
        baseSpeed: 122,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "greninja", //Verify
        graphicsLocation: "greninja", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Greninja,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Protean,
        }
    );
    public static readonly SpeciesData Bunnelby = new(
        speciesName: "Bunnelby",
        type1: Normal,
        type2: Normal,
        baseHP: 38,
        baseAttack: 36,
        baseDefense: 38,
        baseSpAtk: 32,
        baseSpDef: 36,
        baseSpeed: 57,
        evYield: Speed,
        evolution: Evolution.Bunnelby,
        xpClass: MediumFast,
        xpYield: 47,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "bunnelby", //Verify
        graphicsLocation: "bunnelby", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Bunnelby,
        abilities: new Ability[3]
        {
            Pickup,
            CheekPouch,
            HugePower,
        }
    );
    public static readonly SpeciesData Diggersby = new(
        speciesName: "Diggersby",
        type1: Normal,
        type2: Ground,
        baseHP: 85,
        baseAttack: 56,
        baseDefense: 77,
        baseSpAtk: 50,
        baseSpDef: 77,
        baseSpeed: 78,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 148,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "diggersby", //Verify
        graphicsLocation: "diggersby", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Diggersby,
        abilities: new Ability[3]
        {
            Pickup,
            CheekPouch,
            HugePower,
        }
    );
    public static readonly SpeciesData Fletchling = new(
        speciesName: "Fletchling",
        type1: Normal,
        type2: Flying,
        baseHP: 45,
        baseAttack: 50,
        baseDefense: 43,
        baseSpAtk: 40,
        baseSpDef: 38,
        baseSpeed: 62,
        evYield: Speed,
        evolution: Evolution.Fletchling,
        xpClass: MediumSlow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "fletchling", //Verify
        graphicsLocation: "fletchling", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Fletchling,
        abilities: new Ability[3]
        {
            BigPecks,
            BigPecks,
            GaleWings,
        }
    );
    public static readonly SpeciesData Fletchinder = new(
        speciesName: "Fletchinder",
        type1: Fire,
        type2: Flying,
        baseHP: 62,
        baseAttack: 73,
        baseDefense: 55,
        baseSpAtk: 56,
        baseSpDef: 52,
        baseSpeed: 84,
        evYield: 2 * Speed,
        evolution: Evolution.Fletchinder,
        xpClass: MediumSlow,
        xpYield: 134,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "fletchinder", //Verify
        graphicsLocation: "fletchinder", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Fletchinder,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            GaleWings,
        }
    );
    public static readonly SpeciesData Talonflame = new(
        speciesName: "Talonflame",
        type1: Fire,
        type2: Flying,
        baseHP: 78,
        baseAttack: 81,
        baseDefense: 71,
        baseSpAtk: 74,
        baseSpDef: 69,
        baseSpeed: 126,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "talonflame", //Verify
        graphicsLocation: "talonflame", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Talonflame,
        abilities: new Ability[3]
        {
            FlameBody,
            FlameBody,
            GaleWings,
        }
    );

    public static readonly SpeciesData ScatterbugMeadow = Scatterbug(SpeciesID.SpewpaMeadow);

    public static readonly SpeciesData SpewpaMeadow = Spewpa(SpeciesID.VivillonMeadow);

    public static readonly SpeciesData VivillonMeadow = Vivillon("meadow");

    public static readonly SpeciesData Litleo = new(
        speciesName: "Litleo",
        type1: Fire,
        type2: Normal,
        baseHP: 62,
        baseAttack: 50,
        baseDefense: 58,
        baseSpAtk: 73,
        baseSpDef: 54,
        baseSpeed: 72,
        evYield: SpAtk,
        evolution: Evolution.Litleo,
        xpClass: MediumSlow,
        xpYield: 74,
        learnset: EmptyLearnset, //Not done
        malePercent: 13,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 220,
        baseFriendship: 70,
        cryLocation: "litleo", //Verify
        graphicsLocation: "litleo", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Litleo,
        abilities: new Ability[3]
        {
            Rivalry,
            Unnerve,
            Moxie,
        }
    );
    public static readonly SpeciesData Pyroar = new(
        speciesName: "Pyroar",
        type1: Fire,
        type2: Normal,
        baseHP: 86,
        baseAttack: 68,
        baseDefense: 72,
        baseSpAtk: 109,
        baseSpDef: 66,
        baseSpeed: 106,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 13,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 65,
        baseFriendship: 70,
        cryLocation: "pyroar", //Verify
        graphicsLocation: "pyroar", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Pyroar,
        abilities: new Ability[3]
        {
            Rivalry,
            Unnerve,
            Moxie,
        }
    );

    public static readonly SpeciesData FlabebeRed = Flabebe(SpeciesID.FloetteRed, "red");

    public static readonly SpeciesData FloetteRed = Floette(SpeciesID.FlorgesRed, "red");

    public static readonly SpeciesData FlorgesRed = Florges("red");

    public static readonly SpeciesData Skiddo = new(
        speciesName: "Skiddo",
        type1: Grass,
        type2: Grass,
        baseHP: 66,
        baseAttack: 65,
        baseDefense: 48,
        baseSpAtk: 62,
        baseSpDef: 57,
        baseSpeed: 52,
        evYield: HP,
        evolution: Evolution.Skiddo,
        xpClass: MediumFast,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "skiddo", //Verify
        graphicsLocation: "skiddo", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Skiddo,
        abilities: new Ability[3]
        {
            SapSipper,
            SapSipper,
            GrassPelt,
        }
    );
    public static readonly SpeciesData Gogoat = new(
        speciesName: "Gogoat",
        type1: Grass,
        type2: Grass,
        baseHP: 123,
        baseAttack: 100,
        baseDefense: 62,
        baseSpAtk: 97,
        baseSpDef: 81,
        baseSpeed: 68,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "gogoat", //Verify
        graphicsLocation: "gogoat", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Gogoat,
        abilities: new Ability[3]
        {
            SapSipper,
            SapSipper,
            GrassPelt,
        }
    );
    public static readonly SpeciesData Pancham = new(
        speciesName: "Pancham",
        type1: Fighting,
        type2: Fighting,
        baseHP: 67,
        baseAttack: 82,
        baseDefense: 62,
        baseSpAtk: 46,
        baseSpDef: 48,
        baseSpeed: 43,
        evYield: Attack,
        evolution: Evolution.Pancham,
        xpClass: MediumFast,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 220,
        baseFriendship: 70,
        cryLocation: "pancham", //Verify
        graphicsLocation: "pancham", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Pancham,
        abilities: new Ability[3]
        {
            IronFist,
            MoldBreaker,
            Scrappy,
        }
    );
    public static readonly SpeciesData Pangoro = new(
        speciesName: "Pangoro",
        type1: Fighting,
        type2: Dark,
        baseHP: 95,
        baseAttack: 124,
        baseDefense: 78,
        baseSpAtk: 69,
        baseSpDef: 71,
        baseSpeed: 58,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 65,
        baseFriendship: 70,
        cryLocation: "pangoro", //Verify
        graphicsLocation: "pangoro", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Pangoro,
        abilities: new Ability[3]
        {
            IronFist,
            MoldBreaker,
            Scrappy,
        }
    );

    public static readonly SpeciesData FurfrouNatural = Furfrou("natural", true);

    public static readonly SpeciesData Espurr = new(
        speciesName: "Espurr",
        type1: Psychic,
        type2: Psychic,
        baseHP: 62,
        baseAttack: 48,
        baseDefense: 54,
        baseSpAtk: 63,
        baseSpDef: 60,
        baseSpeed: 68,
        evYield: Speed,
        evolution: Evolution.Espurr,
        xpClass: MediumFast,
        xpYield: 71,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "espurr", //Verify
        graphicsLocation: "espurr", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Espurr,
        abilities: new Ability[3]
        {
            KeenEye,
            Infiltrator,
            OwnTempo,
        }
    );
    public static readonly SpeciesData MeowsticM = new(
        speciesName: "Meowstic",
        type1: Psychic,
        type2: Psychic,
        baseHP: 74,
        baseAttack: 48,
        baseDefense: 76,
        baseSpAtk: 83,
        baseSpDef: 81,
        baseSpeed: 104,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "meowstic", //Verify
        graphicsLocation: "meowstic", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Meowstic,
        abilities: new Ability[3]
        {
            KeenEye,
            Infiltrator,
            Prankster,
        }
    );
    public static readonly SpeciesData Honedge = new(
        speciesName: "Honedge",
        type1: Steel,
        type2: Ghost,
        baseHP: 45,
        baseAttack: 80,
        baseDefense: 100,
        baseSpAtk: 35,
        baseSpDef: 37,
        baseSpeed: 28,
        evYield: Defense,
        evolution: Evolution.Honedge,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "honedge", //Verify
        graphicsLocation: "honedge", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Honedge,
        abilities: new Ability[3]
        {
            NoGuard,
            NoGuard,
            NoGuard,
        }
    );
    public static readonly SpeciesData Doublade = new(
        speciesName: "Doublade",
        type1: Steel,
        type2: Ghost,
        baseHP: 59,
        baseAttack: 110,
        baseDefense: 150,
        baseSpAtk: 45,
        baseSpDef: 49,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.Doublade,
        xpClass: MediumFast,
        xpYield: 157,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "doublade", //Verify
        graphicsLocation: "doublade", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Doublade,
        abilities: new Ability[3]
        {
            NoGuard,
            NoGuard,
            NoGuard,
        }
    );
    public static readonly SpeciesData AegislashShield = Aegislash(blade: false);
    public static readonly SpeciesData Spritzee = new(
        speciesName: "Spritzee",
        type1: Fairy,
        type2: Fairy,
        baseHP: 78,
        baseAttack: 52,
        baseDefense: 60,
        baseSpAtk: 63,
        baseSpDef: 65,
        baseSpeed: 23,
        evYield: HP,
        evolution: Evolution.Spritzee,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "spritzee", //Verify
        graphicsLocation: "spritzee", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Spritzee,
        abilities: new Ability[3]
        {
            Healer,
            Healer,
            AromaVeil,
        }
    );
    public static readonly SpeciesData Aromatisse = new(
        speciesName: "Aromatisse",
        type1: Fairy,
        type2: Fairy,
        baseHP: 101,
        baseAttack: 72,
        baseDefense: 72,
        baseSpAtk: 99,
        baseSpDef: 89,
        baseSpeed: 29,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 162,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 140,
        baseFriendship: 70,
        cryLocation: "aromatisse", //Verify
        graphicsLocation: "aromatisse", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Aromatisse,
        abilities: new Ability[3]
        {
            Healer,
            Healer,
            AromaVeil,
        }
    );
    public static readonly SpeciesData Swirlix = new(
        speciesName: "Swirlix",
        type1: Fairy,
        type2: Fairy,
        baseHP: 62,
        baseAttack: 48,
        baseDefense: 66,
        baseSpAtk: 59,
        baseSpDef: 57,
        baseSpeed: 49,
        evYield: Defense,
        evolution: Evolution.Swirlix,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "swirlix", //Verify
        graphicsLocation: "swirlix", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Swirlix,
        abilities: new Ability[3]
        {
            SweetVeil,
            SweetVeil,
            Unburden,
        }
    );
    public static readonly SpeciesData Slurpuff = new(
        speciesName: "Slurpuff",
        type1: Fairy,
        type2: Fairy,
        baseHP: 82,
        baseAttack: 80,
        baseDefense: 86,
        baseSpAtk: 85,
        baseSpDef: 75,
        baseSpeed: 72,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 140,
        baseFriendship: 70,
        cryLocation: "slurpuff", //Verify
        graphicsLocation: "slurpuff", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Slurpuff,
        abilities: new Ability[3]
        {
            SweetVeil,
            SweetVeil,
            Unburden,
        }
    );
    public static readonly SpeciesData Inkay = new(
        speciesName: "Inkay",
        type1: Dark,
        type2: Psychic,
        baseHP: 53,
        baseAttack: 54,
        baseDefense: 53,
        baseSpAtk: 37,
        baseSpDef: 46,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Inkay,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "inkay", //Verify
        graphicsLocation: "inkay", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Inkay,
        abilities: new Ability[3]
        {
            Contrary,
            SuctionCups,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Malamar = new(
        speciesName: "Malamar",
        type1: Dark,
        type2: Psychic,
        baseHP: 86,
        baseAttack: 92,
        baseDefense: 88,
        baseSpAtk: 68,
        baseSpDef: 75,
        baseSpeed: 73,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 80,
        baseFriendship: 70,
        cryLocation: "malamar", //Verify
        graphicsLocation: "malamar", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Malamar,
        abilities: new Ability[3]
        {
            Contrary,
            SuctionCups,
            Infiltrator,
        }
    );
    public static readonly SpeciesData Binacle = new(
        speciesName: "Binacle",
        type1: Rock,
        type2: Water,
        baseHP: 42,
        baseAttack: 52,
        baseDefense: 67,
        baseSpAtk: 39,
        baseSpDef: 56,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Binacle,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "binacle", //Verify
        graphicsLocation: "binacle", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Binacle,
        abilities: new Ability[3]
        {
            ToughClaws,
            Sniper,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Barbaracle = new(
        speciesName: "Barbaracle",
        type1: Rock,
        type2: Water,
        baseHP: 72,
        baseAttack: 105,
        baseDefense: 115,
        baseSpAtk: 54,
        baseSpDef: 86,
        baseSpeed: 68,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "barbaracle", //Verify
        graphicsLocation: "barbaracle", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Barbaracle,
        abilities: new Ability[3]
        {
            ToughClaws,
            Sniper,
            Pickpocket,
        }
    );
    public static readonly SpeciesData Skrelp = new(
        speciesName: "Skrelp",
        type1: Poison,
        type2: Water,
        baseHP: 50,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 60,
        baseSpDef: 60,
        baseSpeed: 30,
        evYield: SpDef,
        evolution: Evolution.Skrelp,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "skrelp", //Verify
        graphicsLocation: "skrelp", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Skrelp,
        abilities: new Ability[3]
        {
            PoisonPoint,
            PoisonTouch,
            Adaptability,
        }
    );
    public static readonly SpeciesData Dragalge = new(
        speciesName: "Dragalge",
        type1: Poison,
        type2: Dragon,
        baseHP: 65,
        baseAttack: 75,
        baseDefense: 90,
        baseSpAtk: 97,
        baseSpDef: 123,
        baseSpeed: 44,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 55,
        baseFriendship: 70,
        cryLocation: "dragalge", //Verify
        graphicsLocation: "dragalge", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Dragalge,
        abilities: new Ability[3]
        {
            PoisonPoint,
            PoisonTouch,
            Adaptability,
        }
    );
    public static readonly SpeciesData Clauncher = new(
        speciesName: "Clauncher",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 53,
        baseDefense: 62,
        baseSpAtk: 58,
        baseSpDef: 63,
        baseSpeed: 44,
        evYield: SpAtk,
        evolution: Evolution.Clauncher,
        xpClass: Slow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 15,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "clauncher", //Verify
        graphicsLocation: "clauncher", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Clauncher,
        abilities: new Ability[3]
        {
            MegaLauncher,
            MegaLauncher,
            MegaLauncher,
        }
    );
    public static readonly SpeciesData Clawitzer = new(
        speciesName: "Clawitzer",
        type1: Water,
        type2: Water,
        baseHP: 71,
        baseAttack: 73,
        baseDefense: 88,
        baseSpAtk: 120,
        baseSpDef: 89,
        baseSpeed: 59,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 100,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 15,
        catchRate: 55,
        baseFriendship: 70,
        cryLocation: "clawitzer", //Verify
        graphicsLocation: "clawitzer", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Clawitzer,
        abilities: new Ability[3]
        {
            MegaLauncher,
            MegaLauncher,
            MegaLauncher,
        }
    );
    public static readonly SpeciesData Helioptile = new(
        speciesName: "Helioptile",
        type1: Electric,
        type2: Normal,
        baseHP: 44,
        baseAttack: 38,
        baseDefense: 33,
        baseSpAtk: 61,
        baseSpDef: 43,
        baseSpeed: 70,
        evYield: Speed,
        evolution: Evolution.Helioptile,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "helioptile", //Verify
        graphicsLocation: "helioptile", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Helioptile,
        abilities: new Ability[3]
        {
            DrySkin,
            SandVeil,
            SolarPower,
        }
    );
    public static readonly SpeciesData Heliolisk = new(
        speciesName: "Heliolisk",
        type1: Electric,
        type2: Normal,
        baseHP: 62,
        baseAttack: 55,
        baseDefense: 52,
        baseSpAtk: 109,
        baseSpDef: 94,
        baseSpeed: 109,
        evYield: Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "heliolisk", //Verify
        graphicsLocation: "heliolisk", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Heliolisk,
        abilities: new Ability[3]
        {
            DrySkin,
            SandVeil,
            SolarPower,
        }
    );
    public static readonly SpeciesData Tyrunt = new(
        speciesName: "Tyrunt",
        type1: Rock,
        type2: Dragon,
        baseHP: 58,
        baseAttack: 89,
        baseDefense: 77,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 48,
        evYield: Attack,
        evolution: Evolution.Tyrunt,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tyrunt", //Verify
        graphicsLocation: "tyrunt", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Tyrunt,
        abilities: new Ability[3]
        {
            StrongJaw,
            StrongJaw,
            Sturdy,
        }
    );
    public static readonly SpeciesData Tyrantrum = new(
        speciesName: "Tyrantrum",
        type1: Rock,
        type2: Dragon,
        baseHP: 82,
        baseAttack: 121,
        baseDefense: 119,
        baseSpAtk: 69,
        baseSpDef: 59,
        baseSpeed: 71,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 182,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tyrantrum", //Verify
        graphicsLocation: "tyrantrum", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Tyrantrum,
        abilities: new Ability[3]
        {
            StrongJaw,
            StrongJaw,
            RockHead,
        }
    );
    public static readonly SpeciesData Amaura = new(
        speciesName: "Amaura",
        type1: Rock,
        type2: Ice,
        baseHP: 77,
        baseAttack: 59,
        baseDefense: 50,
        baseSpAtk: 67,
        baseSpDef: 63,
        baseSpeed: 46,
        evYield: HP,
        evolution: Evolution.Amaura,
        xpClass: MediumFast,
        xpYield: 72,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "amaura", //Verify
        graphicsLocation: "amaura", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Amaura,
        abilities: new Ability[3]
        {
            Refrigerate,
            Refrigerate,
            SnowWarning,
        }
    );
    public static readonly SpeciesData Aurorus = new(
        speciesName: "Aurorus",
        type1: Rock,
        type2: Ice,
        baseHP: 123,
        baseAttack: 77,
        baseDefense: 72,
        baseSpAtk: 99,
        baseSpDef: 92,
        baseSpeed: 58,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 104,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "aurorus", //Verify
        graphicsLocation: "aurorus", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Aurorus,
        abilities: new Ability[3]
        {
            Refrigerate,
            Refrigerate,
            SnowWarning,
        }
    );
    public static readonly SpeciesData Sylveon = new(
        speciesName: "Sylveon",
        type1: Fairy,
        type2: Fairy,
        baseHP: 95,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 110,
        baseSpDef: 130,
        baseSpeed: 60,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sylveon", //Verify
        graphicsLocation: "sylveon", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Sylveon,
        abilities: new Ability[3]
        {
            CuteCharm,
            CuteCharm,
            Pixilate,
        }
    );
    public static readonly SpeciesData Hawlucha = new(
        speciesName: "Hawlucha",
        type1: Fighting,
        type2: Flying,
        baseHP: 78,
        baseAttack: 92,
        baseDefense: 75,
        baseSpAtk: 74,
        baseSpDef: 63,
        baseSpeed: 118,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "hawlucha", //Verify
        graphicsLocation: "hawlucha", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Hawlucha,
        abilities: new Ability[3]
        {
            Limber,
            Unburden,
            MoldBreaker,
        }
    );
    public static readonly SpeciesData Dedenne = new(
        speciesName: "Dedenne",
        type1: Electric,
        type2: Fairy,
        baseHP: 67,
        baseAttack: 58,
        baseDefense: 57,
        baseSpAtk: 81,
        baseSpDef: 67,
        baseSpeed: 101,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 151,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "dedenne", //Verify
        graphicsLocation: "dedenne", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Dedenne,
        abilities: new Ability[3]
        {
            CheekPouch,
            Pickup,
            Plus,
        }
    );
    public static readonly SpeciesData Carbink = new(
        speciesName: "Carbink",
        type1: Rock,
        type2: Fairy,
        baseHP: 50,
        baseAttack: 50,
        baseDefense: 150,
        baseSpAtk: 50,
        baseSpDef: 150,
        baseSpeed: 50,
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 100,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "carbink", //Verify
        graphicsLocation: "carbink", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Carbink,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            Sturdy,
        }
    );
    public static readonly SpeciesData Goomy = new(
        speciesName: "Goomy",
        type1: Dragon,
        type2: Dragon,
        baseHP: 45,
        baseAttack: 50,
        baseDefense: 35,
        baseSpAtk: 55,
        baseSpDef: 75,
        baseSpeed: 40,
        evYield: SpDef,
        evolution: Evolution.Goomy,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "goomy", //Verify
        graphicsLocation: "goomy", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Goomy,
        abilities: new Ability[3]
        {
            SapSipper,
            Hydration,
            Gooey,
        }
    );
    public static readonly SpeciesData Sliggoo = new(
        speciesName: "Sliggoo",
        type1: Dragon,
        type2: Dragon,
        baseHP: 68,
        baseAttack: 75,
        baseDefense: 53,
        baseSpAtk: 83,
        baseSpDef: 113,
        baseSpeed: 60,
        evYield: 2 * SpDef,
        evolution: Evolution.Sliggoo,
        xpClass: Slow,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "sliggoo", //Verify
        graphicsLocation: "sliggoo", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Sliggoo,
        abilities: new Ability[3]
        {
            SapSipper,
            Hydration,
            Gooey,
        }
    );
    public static readonly SpeciesData Goodra = new(
        speciesName: "Goodra",
        type1: Dragon,
        type2: Dragon,
        baseHP: 90,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 110,
        baseSpDef: 150,
        baseSpeed: 80,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "goodra", //Verify
        graphicsLocation: "goodra", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Goodra,
        abilities: new Ability[3]
        {
            SapSipper,
            Hydration,
            Gooey,
        }
    );
    public static readonly SpeciesData Klefki = new(
        speciesName: "Klefki",
        type1: Steel,
        type2: Fairy,
        baseHP: 57,
        baseAttack: 80,
        baseDefense: 91,
        baseSpAtk: 80,
        baseSpDef: 87,
        baseSpeed: 75,
        evYield: Defense,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "klefki", //Verify
        graphicsLocation: "klefki", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Klefki,
        abilities: new Ability[3]
        {
            Prankster,
            Prankster,
            Magician,
        }
    );
    public static readonly SpeciesData Phantump = new(
        speciesName: "Phantump",
        type1: Ghost,
        type2: Grass,
        baseHP: 43,
        baseAttack: 70,
        baseDefense: 48,
        baseSpAtk: 50,
        baseSpDef: 60,
        baseSpeed: 38,
        evYield: Attack,
        evolution: Evolution.Phantump,
        xpClass: MediumFast,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "phantump", //Verify
        graphicsLocation: "phantump", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Phantump,
        abilities: new Ability[3]
        {
            NaturalCure,
            Frisk,
            Harvest,
        }
    );
    public static readonly SpeciesData Trevenant = new(
        speciesName: "Trevenant",
        type1: Ghost,
        type2: Grass,
        baseHP: 85,
        baseAttack: 110,
        baseDefense: 76,
        baseSpAtk: 65,
        baseSpDef: 82,
        baseSpeed: 56,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "trevenant", //Verify
        graphicsLocation: "trevenant", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Trevenant,
        abilities: new Ability[3]
        {
            NaturalCure,
            Frisk,
            Harvest,
        }
    );

    public static readonly SpeciesData PumpkabooAverage = Pumpkaboo(
        baseHP: 49,
        baseSpeed: 51,
        nextEvo: SpeciesID.GourgeistAverage,
        graphicsSubfolder: "average",
        backSpriteHeight: 13
    );

    public static readonly SpeciesData GourgeistAverage = Gourgeist(
        baseHP: 65,
        baseAttack: 90,
        baseSpeed: 84,
        graphicsSubfolder: "average",
        backSpriteHeight: 3
    );

    public static readonly SpeciesData Bergmite = new(
        speciesName: "Bergmite",
        type1: Ice,
        type2: Ice,
        baseHP: 55,
        baseAttack: 69,
        baseDefense: 85,
        baseSpAtk: 32,
        baseSpDef: 35,
        baseSpeed: 28,
        evYield: Defense,
        evolution: Evolution.Bergmite,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "bergmite", //Verify
        graphicsLocation: "bergmite", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Bergmite,
        abilities: new Ability[3]
        {
            OwnTempo,
            IceBody,
            Sturdy,
        }
    );
    public static readonly SpeciesData Avalugg = new(
        speciesName: "Avalugg",
        type1: Ice,
        type2: Ice,
        baseHP: 95,
        baseAttack: 117,
        baseDefense: 184,
        baseSpAtk: 44,
        baseSpDef: 46,
        baseSpeed: 28,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 55,
        baseFriendship: 70,
        cryLocation: "avalugg", //Verify
        graphicsLocation: "avalugg", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Avalugg,
        abilities: new Ability[3]
        {
            OwnTempo,
            IceBody,
            Sturdy,
        }
    );
    public static readonly SpeciesData Noibat = new(
        speciesName: "Noibat",
        type1: Flying,
        type2: Dragon,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 35,
        baseSpAtk: 45,
        baseSpDef: 40,
        baseSpeed: 55,
        evYield: Speed,
        evolution: Evolution.Noibat,
        xpClass: MediumFast,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "noibat", //Verify
        graphicsLocation: "noibat", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Noibat,
        abilities: new Ability[3]
        {
            Frisk,
            Infiltrator,
            Telepathy,
        }
    );
    public static readonly SpeciesData Noivern = new(
        speciesName: "Noivern",
        type1: Flying,
        type2: Dragon,
        baseHP: 85,
        baseAttack: 70,
        baseDefense: 80,
        baseSpAtk: 97,
        baseSpDef: 80,
        baseSpeed: 123,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 187,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "noivern", //Verify
        graphicsLocation: "noivern", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Noivern,
        abilities: new Ability[3]
        {
            Frisk,
            Infiltrator,
            Telepathy,
        }
    );

    public static readonly SpeciesData AegislashBlade = Aegislash(blade: true);

    public static readonly SpeciesData XerneasInactive = Xerneas("xerneas");

    public static readonly SpeciesData Yveltal = new(
        speciesName: "Yveltal",
        type1: Dark,
        type2: Flying,
        baseHP: 126,
        baseAttack: 131,
        baseDefense: 95,
        baseSpAtk: 131,
        baseSpDef: 98,
        baseSpeed: 99,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "yveltal", //Verify
        graphicsLocation: "yveltal", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Yveltal,
        abilities: new Ability[3]
        {
                DarkAura,
                DarkAura,
                DarkAura,
        }
    );

    public static readonly SpeciesData Zygarde50 = new(
        speciesName: "Zygarde",
        type1: Dragon,
        type2: Ground,
        baseHP: 108,
        baseAttack: 100,
        baseDefense: 121,
        baseSpAtk: 81,
        baseSpDef: 95,
        baseSpeed: 95,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "zygarde",
        graphicsLocation: "zygarde",
        backSpriteHeight: 4,
        pokedexData: Pokedex.Zygarde,
        abilities: new Ability[3]
        {
            AuraBreak,
            AuraBreak,
            AuraBreak
        }
    );

    public static readonly SpeciesData Diancie = new(
        speciesName: "Diancie",
        type1: Rock,
        type2: Fairy,
        baseHP: 50,
        baseAttack: 100,
        baseDefense: 150,
        baseSpAtk: 100,
        baseSpDef: 150,
        baseSpeed: 50,
        evYield: Defense + 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "diancie", //Verify
        graphicsLocation: "diancie", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Diancie,
        abilities: new Ability[3]
        {
            ClearBody,
            ClearBody,
            ClearBody,
        }
    );
    public static readonly SpeciesData Hoopa = new(
        speciesName: "Hoopa",
        type1: Psychic,
        type2: Ghost,
        baseHP: 80,
        baseAttack: 110,
        baseDefense: 60,
        baseSpAtk: 150,
        baseSpDef: 130,
        baseSpeed: 70,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "hoopa", //Verify
        graphicsLocation: "hoopa", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Hoopa,
        abilities: new Ability[3]
        {
            Magician,
            Magician,
            Magician,
        }
    );
    public static readonly SpeciesData Volcanion = new(
        speciesName: "Volcanion",
        type1: Fire,
        type2: Water,
        baseHP: 80,
        baseAttack: 110,
        baseDefense: 120,
        baseSpAtk: 130,
        baseSpDef: 90,
        baseSpeed: 70,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "volcanion", //Verify
        graphicsLocation: "volcanion", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Volcanion,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            WaterAbsorb,
            WaterAbsorb,
        }
    );

    //Gen 7

    public static readonly SpeciesData Rowlet = new(
        speciesName: "Rowlet",
        type1: Grass,
        type2: Flying,
        baseHP: 68,
        baseAttack: 55,
        baseDefense: 55,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 42,
        evYield: HP,
        evolution: Evolution.Rowlet,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "rowlet", //Verify
        graphicsLocation: "rowlet", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Rowlet,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LongReach,
        }
    );
    public static readonly SpeciesData Dartrix = new(
        speciesName: "Dartrix",
        type1: Grass,
        type2: Flying,
        baseHP: 78,
        baseAttack: 75,
        baseDefense: 75,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 52,
        evYield: 2 * HP,
        evolution: Evolution.Dartrix,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dartrix", //Verify
        graphicsLocation: "dartrix", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Dartrix,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LongReach,
        }
    );
    public static readonly SpeciesData Decidueye = new(
        speciesName: "Decidueye",
        type1: Grass,
        type2: Ghost,
        baseHP: 78,
        baseAttack: 107,
        baseDefense: 75,
        baseSpAtk: 100,
        baseSpDef: 100,
        baseSpeed: 70,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "decidueye", //Verify
        graphicsLocation: "decidueye", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Decidueye,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LongReach,
        }
    );
    public static readonly SpeciesData Litten = new(
        speciesName: "Litten",
        type1: Fire,
        type2: Fire,
        baseHP: 45,
        baseAttack: 65,
        baseDefense: 40,
        baseSpAtk: 60,
        baseSpDef: 40,
        baseSpeed: 70,
        evYield: Speed,
        evolution: Evolution.Litten,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "litten", //Verify
        graphicsLocation: "litten", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Litten,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Intimidate,
        }
    );
    public static readonly SpeciesData Torracat = new(
        speciesName: "Torracat",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 85,
        baseDefense: 50,
        baseSpAtk: 80,
        baseSpDef: 50,
        baseSpeed: 90,
        evYield: 2 * Speed,
        evolution: Evolution.Torracat,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "torracat", //Verify
        graphicsLocation: "torracat", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Torracat,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Intimidate,
        }
    );
    public static readonly SpeciesData Incineroar = new(
        speciesName: "Incineroar",
        type1: Fire,
        type2: Dark,
        baseHP: 95,
        baseAttack: 115,
        baseDefense: 90,
        baseSpAtk: 80,
        baseSpDef: 90,
        baseSpeed: 60,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "incineroar", //Verify
        graphicsLocation: "incineroar", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Incineroar,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Intimidate,
        }
    );
    public static readonly SpeciesData Popplio = new(
        speciesName: "Popplio",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 54,
        baseDefense: 54,
        baseSpAtk: 66,
        baseSpDef: 56,
        baseSpeed: 40,
        evYield: SpAtk,
        evolution: Evolution.Popplio,
        xpClass: MediumSlow,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "popplio", //Verify
        graphicsLocation: "popplio", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Popplio,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            LiquidVoice,
        }
    );
    public static readonly SpeciesData Brionne = new(
        speciesName: "Brionne",
        type1: Water,
        type2: Water,
        baseHP: 60,
        baseAttack: 69,
        baseDefense: 69,
        baseSpAtk: 91,
        baseSpDef: 81,
        baseSpeed: 50,
        evYield: 2 * SpAtk,
        evolution: Evolution.Brionne,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "brionne", //Verify
        graphicsLocation: "brionne", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Brionne,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            LiquidVoice,
        }
    );
    public static readonly SpeciesData Primarina = new(
        speciesName: "Primarina",
        type1: Water,
        type2: Fairy,
        baseHP: 80,
        baseAttack: 74,
        baseDefense: 74,
        baseSpAtk: 126,
        baseSpDef: 116,
        baseSpeed: 60,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "primarina", //Verify
        graphicsLocation: "primarina", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Primarina,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            LiquidVoice,
        }
    );
    public static readonly SpeciesData Pikipek = new(
        speciesName: "Pikipek",
        type1: Normal,
        type2: Flying,
        baseHP: 35,
        baseAttack: 75,
        baseDefense: 30,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.Pikipek,
        xpClass: MediumFast,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "pikipek", //Verify
        graphicsLocation: "pikipek", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Pikipek,
        abilities: new Ability[3]
        {
            KeenEye,
            SkillLink,
            Pickup,
        }
    );
    public static readonly SpeciesData Trumbeak = new(
        speciesName: "Trumbeak",
        type1: Normal,
        type2: Flying,
        baseHP: 55,
        baseAttack: 85,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 75,
        evYield: 2 * Attack,
        evolution: Evolution.Trumbeak,
        xpClass: MediumFast,
        xpYield: 124,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "trumbeak", //Verify
        graphicsLocation: "trumbeak", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Trumbeak,
        abilities: new Ability[3]
        {
            KeenEye,
            SkillLink,
            Pickup,
        }
    );
    public static readonly SpeciesData Toucannon = new(
        speciesName: "Toucannon",
        type1: Normal,
        type2: Flying,
        baseHP: 80,
        baseAttack: 120,
        baseDefense: 75,
        baseSpAtk: 75,
        baseSpDef: 75,
        baseSpeed: 60,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 218,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "toucannon", //Verify
        graphicsLocation: "toucannon", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Toucannon,
        abilities: new Ability[3]
        {
            KeenEye,
            SkillLink,
            SheerForce,
        }
    );
    public static readonly SpeciesData Yungoos = new(
        speciesName: "Yungoos",
        type1: Normal,
        type2: Normal,
        baseHP: 48,
        baseAttack: 70,
        baseDefense: 30,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Yungoos,
        xpClass: MediumFast,
        xpYield: 51,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "yungoos", //Verify
        graphicsLocation: "yungoos", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Yungoos,
        abilities: new Ability[3]
        {
            Stakeout,
            StrongJaw,
            Adaptability,
        }
    );
    public static readonly SpeciesData Gumshoos = new(
        speciesName: "Gumshoos",
        type1: Normal,
        type2: Normal,
        baseHP: 88,
        baseAttack: 110,
        baseDefense: 60,
        baseSpAtk: 55,
        baseSpDef: 60,
        baseSpeed: 45,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 146,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "gumshoos", //Verify
        graphicsLocation: "gumshoos", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Gumshoos,
        abilities: new Ability[3]
        {
            Stakeout,
            StrongJaw,
            Adaptability,
        }
    );
    public static readonly SpeciesData Grubbin = new(
        speciesName: "Grubbin",
        type1: Bug,
        type2: Bug,
        baseHP: 47,
        baseAttack: 62,
        baseDefense: 45,
        baseSpAtk: 55,
        baseSpDef: 45,
        baseSpeed: 46,
        evYield: Attack,
        evolution: Evolution.Grubbin,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "grubbin", //Verify
        graphicsLocation: "grubbin", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Grubbin,
        abilities: new Ability[3]
        {
            Swarm,
            Swarm,
            Swarm,
        }
    );
    public static readonly SpeciesData Charjabug = new(
        speciesName: "Charjabug",
        type1: Bug,
        type2: Electric,
        baseHP: 57,
        baseAttack: 82,
        baseDefense: 95,
        baseSpAtk: 55,
        baseSpDef: 75,
        baseSpeed: 36,
        evYield: 2 * Defense,
        evolution: Evolution.Charjabug,
        xpClass: MediumFast,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "charjabug", //Verify
        graphicsLocation: "charjabug", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Charjabug,
        abilities: new Ability[3]
        {
            Battery,
            Battery,
            Battery,
        }
    );
    public static readonly SpeciesData Vikavolt = new(
        speciesName: "Vikavolt",
        type1: Bug,
        type2: Electric,
        baseHP: 77,
        baseAttack: 70,
        baseDefense: 90,
        baseSpAtk: 145,
        baseSpDef: 75,
        baseSpeed: 43,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 225,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vikavolt", //Verify
        graphicsLocation: "vikavolt", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Vikavolt,
        abilities: new Ability[3]
        {
            Levitate,
            Levitate,
            Levitate,
        }
    );
    public static readonly SpeciesData Crabrawler = new(
        speciesName: "Crabrawler",
        type1: Fighting,
        type2: Fighting,
        baseHP: 47,
        baseAttack: 82,
        baseDefense: 57,
        baseSpAtk: 42,
        baseSpDef: 47,
        baseSpeed: 63,
        evYield: Attack,
        evolution: Evolution.Crabrawler,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "crabrawler", //Verify
        graphicsLocation: "crabrawler", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Crabrawler,
        abilities: new Ability[3]
        {
            HyperCutter,
            IronFist,
            AngerPoint,
        }
    );
    public static readonly SpeciesData Crabominable = new(
        speciesName: "Crabominable",
        type1: Fighting,
        type2: Ice,
        baseHP: 97,
        baseAttack: 132,
        baseDefense: 77,
        baseSpAtk: 62,
        baseSpDef: 67,
        baseSpeed: 43,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 167,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water3,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "crabominable", //Verify
        graphicsLocation: "crabominable", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Crabominable,
        abilities: new Ability[3]
        {
            HyperCutter,
            IronFist,
            AngerPoint,
        }
    );
    public static readonly SpeciesData OricorioBaile = Oricorio(Fire, "baile");
    public static readonly SpeciesData Cutiefly = new(
        speciesName: "Cutiefly",
        type1: Bug,
        type2: Fairy,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 40,
        baseSpAtk: 55,
        baseSpDef: 40,
        baseSpeed: 84,
        evYield: Speed,
        evolution: Evolution.Cutiefly,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "cutiefly", //Verify
        graphicsLocation: "cutiefly", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Cutiefly,
        abilities: new Ability[3]
        {
            HoneyGather,
            ShieldDust,
            SweetVeil,
        }
    );
    public static readonly SpeciesData Ribombee = new(
        speciesName: "Ribombee",
        type1: Bug,
        type2: Fairy,
        baseHP: 60,
        baseAttack: 55,
        baseDefense: 60,
        baseSpAtk: 95,
        baseSpDef: 70,
        baseSpeed: 124,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 162,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "ribombee", //Verify
        graphicsLocation: "ribombee", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Ribombee,
        abilities: new Ability[3]
        {
            HoneyGather,
            ShieldDust,
            SweetVeil,
        }
    );
    public static readonly SpeciesData RockruffNormal = Rockruff(
        new[] { KeenEye, VitalSpirit, Steadfast }, Evolution.RockruffNormal);
    public static readonly SpeciesData Lycanroc = new(
        speciesName: "Lycanroc",
        type1: Rock,
        type2: Rock,
        baseHP: 75,
        baseAttack: 115,
        baseDefense: 65,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 112,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "lycanroc", //Verify
        graphicsLocation: "lycanroc", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Lycanroc,
        abilities: new Ability[3]
            {
            KeenEye,
            SandRush,
            Steadfast,
            }
    );
    public static readonly SpeciesData Wishiwashi = new(
        speciesName: "Wishiwashi",
        type1: Water,
        type2: Water,
        baseHP: 45,
        baseAttack: 20,
        baseDefense: 20,
        baseSpAtk: 25,
        baseSpDef: 25,
        baseSpeed: 40,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "wishiwashi", //Verify
        graphicsLocation: "wishiwashi", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Wishiwashi,
        abilities: new Ability[3]
        {
            Schooling,
            Schooling,
            Schooling,
        }
    );
    public static readonly SpeciesData Mareanie = new(
        speciesName: "Mareanie",
        type1: Poison,
        type2: Water,
        baseHP: 50,
        baseAttack: 53,
        baseDefense: 62,
        baseSpAtk: 43,
        baseSpDef: 52,
        baseSpeed: 45,
        evYield: Defense,
        evolution: Evolution.Mareanie,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "mareanie", //Verify
        graphicsLocation: "mareanie", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Mareanie,
        abilities: new Ability[3]
        {
            Merciless,
            Limber,
            Regenerator,
        }
    );
    public static readonly SpeciesData Toxapex = new(
        speciesName: "Toxapex",
        type1: Poison,
        type2: Water,
        baseHP: 50,
        baseAttack: 63,
        baseDefense: 152,
        baseSpAtk: 53,
        baseSpDef: 142,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "toxapex", //Verify
        graphicsLocation: "toxapex", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Toxapex,
        abilities: new Ability[3]
        {
            Merciless,
            Limber,
            Regenerator,
        }
    );
    public static readonly SpeciesData Mudbray = new(
        speciesName: "Mudbray",
        type1: Ground,
        type2: Ground,
        baseHP: 70,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 45,
        baseSpDef: 55,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Mudbray,
        xpClass: MediumFast,
        xpYield: 77,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "mudbray", //Verify
        graphicsLocation: "mudbray", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Mudbray,
        abilities: new Ability[3]
        {
            OwnTempo,
            Stamina,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Mudsdale = new(
        speciesName: "Mudsdale",
        type1: Ground,
        type2: Ground,
        baseHP: 100,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 55,
        baseSpDef: 85,
        baseSpeed: 35,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "mudsdale", //Verify
        graphicsLocation: "mudsdale", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Mudsdale,
        abilities: new Ability[3]
        {
            OwnTempo,
            Stamina,
            InnerFocus,
        }
    );
    public static readonly SpeciesData Dewpider = new(
        speciesName: "Dewpider",
        type1: Water,
        type2: Bug,
        baseHP: 38,
        baseAttack: 40,
        baseDefense: 52,
        baseSpAtk: 40,
        baseSpDef: 72,
        baseSpeed: 27,
        evYield: SpDef,
        evolution: Evolution.Dewpider,
        xpClass: MediumFast,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "dewpider", //Verify
        graphicsLocation: "dewpider", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Dewpider,
        abilities: new Ability[3]
        {
            WaterBubble,
            WaterBubble,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Araquanid = new(
        speciesName: "Araquanid",
        type1: Water,
        type2: Bug,
        baseHP: 68,
        baseAttack: 70,
        baseDefense: 92,
        baseSpAtk: 50,
        baseSpDef: 132,
        baseSpeed: 42,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 100,
        baseFriendship: 70,
        cryLocation: "araquanid", //Verify
        graphicsLocation: "araquanid", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Araquanid,
        abilities: new Ability[3]
        {
            WaterBubble,
            WaterBubble,
            WaterAbsorb,
        }
    );
    public static readonly SpeciesData Fomantis = new(
        speciesName: "Fomantis",
        type1: Grass,
        type2: Grass,
        baseHP: 40,
        baseAttack: 55,
        baseDefense: 35,
        baseSpAtk: 50,
        baseSpDef: 35,
        baseSpeed: 35,
        evYield: Attack,
        evolution: Evolution.Fomantis,
        xpClass: MediumFast,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "fomantis", //Verify
        graphicsLocation: "fomantis", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Fomantis,
        abilities: new Ability[3]
        {
            LeafGuard,
            LeafGuard,
            Contrary,
        }
    );
    public static readonly SpeciesData Lurantis = new(
        speciesName: "Lurantis",
        type1: Grass,
        type2: Grass,
        baseHP: 70,
        baseAttack: 105,
        baseDefense: 90,
        baseSpAtk: 80,
        baseSpDef: 90,
        baseSpeed: 45,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "lurantis", //Verify
        graphicsLocation: "lurantis", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Lurantis,
        abilities: new Ability[3]
        {
            LeafGuard,
            LeafGuard,
            Contrary,
        }
    );
    public static readonly SpeciesData Morelull = new(
        speciesName: "Morelull",
        type1: Grass,
        type2: Fairy,
        baseHP: 40,
        baseAttack: 35,
        baseDefense: 55,
        baseSpAtk: 65,
        baseSpDef: 75,
        baseSpeed: 15,
        evYield: SpDef,
        evolution: Evolution.Morelull,
        xpClass: MediumFast,
        xpYield: 57,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "morelull", //Verify
        graphicsLocation: "morelull", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Morelull,
        abilities: new Ability[3]
        {
            Illuminate,
            EffectSpore,
            RainDish,
        }
    );
    public static readonly SpeciesData Shiinotic = new(
        speciesName: "Shiinotic",
        type1: Grass,
        type2: Fairy,
        baseHP: 60,
        baseAttack: 45,
        baseDefense: 80,
        baseSpAtk: 90,
        baseSpDef: 100,
        baseSpeed: 30,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 142,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "shiinotic", //Verify
        graphicsLocation: "shiinotic", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Shiinotic,
        abilities: new Ability[3]
        {
            Illuminate,
            EffectSpore,
            RainDish,
        }
    );
    public static readonly SpeciesData Salandit = new(
        speciesName: "Salandit",
        type1: Poison,
        type2: Fire,
        baseHP: 48,
        baseAttack: 44,
        baseDefense: 40,
        baseSpAtk: 71,
        baseSpDef: 40,
        baseSpeed: 77,
        evYield: Speed,
        evolution: Evolution.Salandit,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "salandit", //Verify
        graphicsLocation: "salandit", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Salandit,
        abilities: new Ability[3]
        {
            Corrosion,
            Corrosion,
            Oblivious,
        }
    );
    public static readonly SpeciesData Salazzle = new(
        speciesName: "Salazzle",
        type1: Poison,
        type2: Fire,
        baseHP: 68,
        baseAttack: 64,
        baseDefense: 60,
        baseSpAtk: 111,
        baseSpDef: 60,
        baseSpeed: 117,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "salazzle", //Verify
        graphicsLocation: "salazzle", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Salazzle,
        abilities: new Ability[3]
        {
            Corrosion,
            Corrosion,
            Oblivious,
        }
    );
    public static readonly SpeciesData Stufful = new(
        speciesName: "Stufful",
        type1: Normal,
        type2: Fighting,
        baseHP: 70,
        baseAttack: 75,
        baseDefense: 50,
        baseSpAtk: 45,
        baseSpDef: 50,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.Stufful,
        xpClass: MediumFast,
        xpYield: 68,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 140,
        baseFriendship: 70,
        cryLocation: "stufful", //Verify
        graphicsLocation: "stufful", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Stufful,
        abilities: new Ability[3]
        {
            Fluffy,
            Klutz,
            CuteCharm,
        }
    );
    public static readonly SpeciesData Bewear = new(
        speciesName: "Bewear",
        type1: Normal,
        type2: Fighting,
        baseHP: 120,
        baseAttack: 125,
        baseDefense: 80,
        baseSpAtk: 55,
        baseSpDef: 60,
        baseSpeed: 60,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 70,
        baseFriendship: 70,
        cryLocation: "bewear", //Verify
        graphicsLocation: "bewear", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Bewear,
        abilities: new Ability[3]
        {
            Fluffy,
            Klutz,
            Unnerve,
        }
    );
    public static readonly SpeciesData Bounsweet = new(
        speciesName: "Bounsweet",
        type1: Grass,
        type2: Grass,
        baseHP: 42,
        baseAttack: 30,
        baseDefense: 38,
        baseSpAtk: 30,
        baseSpDef: 38,
        baseSpeed: 32,
        evYield: HP,
        evolution: Evolution.Bounsweet,
        xpClass: MediumSlow,
        xpYield: 42,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "bounsweet", //Verify
        graphicsLocation: "bounsweet", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Bounsweet,
        abilities: new Ability[3]
        {
            LeafGuard,
            Oblivious,
            SweetVeil,
        }
    );
    public static readonly SpeciesData Steenee = new(
        speciesName: "Steenee",
        type1: Grass,
        type2: Grass,
        baseHP: 52,
        baseAttack: 40,
        baseDefense: 48,
        baseSpAtk: 40,
        baseSpDef: 48,
        baseSpeed: 62,
        evYield: 2 * Speed,
        evolution: Evolution.Steenee,
        xpClass: MediumSlow,
        xpYield: 102,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "steenee", //Verify
        graphicsLocation: "steenee", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Steenee,
        abilities: new Ability[3]
        {
            LeafGuard,
            Oblivious,
            SweetVeil,
        }
    );
    public static readonly SpeciesData Tsareena = new(
        speciesName: "Tsareena",
        type1: Grass,
        type2: Grass,
        baseHP: 72,
        baseAttack: 120,
        baseDefense: 98,
        baseSpAtk: 50,
        baseSpDef: 98,
        baseSpeed: 72,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 230,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "tsareena", //Verify
        graphicsLocation: "tsareena", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Tsareena,
        abilities: new Ability[3]
        {
            LeafGuard,
            QueenlyMajesty,
            SweetVeil,
        }
    );
    public static readonly SpeciesData Comfey = new(
        speciesName: "Comfey",
        type1: Fairy,
        type2: Fairy,
        baseHP: 51,
        baseAttack: 52,
        baseDefense: 90,
        baseSpAtk: 82,
        baseSpDef: 110,
        baseSpeed: 100,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "comfey", //Verify
        graphicsLocation: "comfey", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Comfey,
        abilities: new Ability[3]
        {
            FlowerVeil,
            Triage,
            NaturalCure,
        }
    );
    public static readonly SpeciesData Oranguru = new(
        speciesName: "Oranguru",
        type1: Normal,
        type2: Psychic,
        baseHP: 90,
        baseAttack: 60,
        baseDefense: 80,
        baseSpAtk: 90,
        baseSpDef: 110,
        baseSpeed: 60,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "oranguru", //Verify
        graphicsLocation: "oranguru", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Oranguru,
        abilities: new Ability[3]
        {
            InnerFocus,
            Telepathy,
            Symbiosis,
        }
    );
    public static readonly SpeciesData Passimian = new(
        speciesName: "Passimian",
        type1: Fighting,
        type2: Fighting,
        baseHP: 100,
        baseAttack: 120,
        baseDefense: 90,
        baseSpAtk: 40,
        baseSpDef: 60,
        baseSpeed: 80,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "passimian", //Verify
        graphicsLocation: "passimian", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Passimian,
        abilities: new Ability[3]
        {
            Receiver,
            Receiver,
            Defiant,
        }
    );
    public static readonly SpeciesData Wimpod = new(
        speciesName: "Wimpod",
        type1: Bug,
        type2: Water,
        baseHP: 25,
        baseAttack: 35,
        baseDefense: 40,
        baseSpAtk: 20,
        baseSpDef: 30,
        baseSpeed: 80,
        evYield: Speed,
        evolution: Evolution.Wimpod,
        xpClass: MediumFast,
        xpYield: 46,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "wimpod", //Verify
        graphicsLocation: "wimpod", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Wimpod,
        abilities: new Ability[3]
        {
            WimpOut,
            WimpOut,
            WimpOut,
        }
    );
    public static readonly SpeciesData Golisopod = new(
        speciesName: "Golisopod",
        type1: Bug,
        type2: Water,
        baseHP: 75,
        baseAttack: 125,
        baseDefense: 140,
        baseSpAtk: 60,
        baseSpDef: 90,
        baseSpeed: 40,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "golisopod", //Verify
        graphicsLocation: "golisopod", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Golisopod,
        abilities: new Ability[3]
        {
            EmergencyExit,
            EmergencyExit,
            EmergencyExit,
        }
    );
    public static readonly SpeciesData Sandygast = new(
        speciesName: "Sandygast",
        type1: Ghost,
        type2: Ground,
        baseHP: 55,
        baseAttack: 55,
        baseDefense: 80,
        baseSpAtk: 70,
        baseSpDef: 45,
        baseSpeed: 15,
        evYield: Defense,
        evolution: Evolution.Sandygast,
        xpClass: MediumFast,
        xpYield: 64,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 15,
        catchRate: 140,
        baseFriendship: 70,
        cryLocation: "sandygast", //Verify
        graphicsLocation: "sandygast", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Sandygast,
        abilities: new Ability[3]
        {
            WaterCompaction,
            WaterCompaction,
            SandVeil,
        }
    );
    public static readonly SpeciesData Palossand = new(
        speciesName: "Palossand",
        type1: Ghost,
        type2: Ground,
        baseHP: 85,
        baseAttack: 75,
        baseDefense: 110,
        baseSpAtk: 100,
        baseSpDef: 75,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "palossand", //Verify
        graphicsLocation: "palossand", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Palossand,
        abilities: new Ability[3]
        {
            WaterCompaction,
            WaterCompaction,
            SandVeil,
        }
    );
    public static readonly SpeciesData Pyukumuku = new(
        speciesName: "Pyukumuku",
        type1: Water,
        type2: Water,
        baseHP: 55,
        baseAttack: 60,
        baseDefense: 130,
        baseSpAtk: 30,
        baseSpDef: 130,
        baseSpeed: 5,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water1,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "pyukumuku", //Verify
        graphicsLocation: "pyukumuku", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Pyukumuku,
        abilities: new Ability[3]
        {
            InnardsOut,
            InnardsOut,
            Unaware,
        }
    );
    public static readonly SpeciesData TypeNull = new(
        speciesName: "Type: Null",
        type1: Normal,
        type2: Normal,
        baseHP: 95,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 95,
        baseSpDef: 95,
        baseSpeed: 59,
        evYield: 2 * HP,
        evolution: Evolution.TypeNull,
        xpClass: Slow,
        xpYield: 107,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "type_null", //Verify
        graphicsLocation: "type_null", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.TypeNull,
        abilities: new Ability[3]
        {
            BattleArmor,
            BattleArmor,
            BattleArmor,
        }
    );
    public static readonly SpeciesData SilvallyNormal = Silvally(Normal, "normal");
    public static readonly SpeciesData MiniorRedMeteor = Minior(false);
    public static readonly SpeciesData Komala = new(
        speciesName: "Komala",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 115,
        baseDefense: 65,
        baseSpAtk: 75,
        baseSpDef: 95,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "komala", //Verify
        graphicsLocation: "komala", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Komala,
        abilities: new Ability[3]
        {
            Comatose,
            Comatose,
            Comatose,
        }
    );
    public static readonly SpeciesData Turtonator = new(
        speciesName: "Turtonator",
        type1: Fire,
        type2: Dragon,
        baseHP: 60,
        baseAttack: 78,
        baseDefense: 135,
        baseSpAtk: 91,
        baseSpDef: 85,
        baseSpeed: 36,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 70,
        baseFriendship: 70,
        cryLocation: "turtonator", //Verify
        graphicsLocation: "turtonator", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Turtonator,
        abilities: new Ability[3]
        {
            ShellArmor,
            ShellArmor,
            ShellArmor,
        }
    );
    public static readonly SpeciesData Togedemaru = new(
        speciesName: "Togedemaru",
        type1: Electric,
        type2: Steel,
        baseHP: 65,
        baseAttack: 98,
        baseDefense: 63,
        baseSpAtk: 40,
        baseSpDef: 73,
        baseSpeed: 96,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 152,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "togedemaru", //Verify
        graphicsLocation: "togedemaru", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Togedemaru,
        abilities: new Ability[3]
        {
            IronBarbs,
            LightningRod,
            Sturdy,
        }
    );
    public static readonly SpeciesData MimikyuBase = Mimikyu(false);
    public static readonly SpeciesData Bruxish = new(
        speciesName: "Bruxish",
        type1: Water,
        type2: Psychic,
        baseHP: 68,
        baseAttack: 105,
        baseDefense: 70,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 92,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 15,
        catchRate: 80,
        baseFriendship: 70,
        cryLocation: "bruxish", //Verify
        graphicsLocation: "bruxish", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Bruxish,
        abilities: new Ability[3]
        {
            Dazzling,
            StrongJaw,
            WonderSkin,
        }
    );
    public static readonly SpeciesData Drampa = new(
        speciesName: "Drampa",
        type1: Normal,
        type2: Dragon,
        baseHP: 78,
        baseAttack: 60,
        baseDefense: 85,
        baseSpAtk: 135,
        baseSpDef: 91,
        baseSpeed: 36,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 70,
        baseFriendship: 70,
        cryLocation: "drampa", //Verify
        graphicsLocation: "drampa", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Drampa,
        abilities: new Ability[3]
        {
            Berserk,
            SapSipper,
            CloudNine,
        }
    );
    public static readonly SpeciesData Dhelmise = new(
        speciesName: "Dhelmise",
        type1: Ghost,
        type2: Grass,
        baseHP: 70,
        baseAttack: 131,
        baseDefense: 100,
        baseSpAtk: 86,
        baseSpDef: 90,
        baseSpeed: 40,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 181,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "dhelmise", //Verify
        graphicsLocation: "dhelmise", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Dhelmise,
        abilities: new Ability[3]
        {
            Steelworker,
            Steelworker,
            Steelworker,
        }
    );
    public static readonly SpeciesData JangmoO = new(
        speciesName: "Jangmo-O",
        type1: Dragon,
        type2: Dragon,
        baseHP: 45,
        baseAttack: 55,
        baseDefense: 65,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 45,
        evYield: Defense,
        evolution: Evolution.JangmoO,
        xpClass: Slow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "jangmo_o", //Verify
        graphicsLocation: "jangmo_o", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.JangmoO,
        abilities: new Ability[3]
        {
            Bulletproof,
            Soundproof,
            Overcoat,
        }
    );
    public static readonly SpeciesData HakamoO = new(
        speciesName: "Hakamo-O",
        type1: Dragon,
        type2: Fighting,
        baseHP: 55,
        baseAttack: 75,
        baseDefense: 90,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 65,
        evYield: 2 * Defense,
        evolution: Evolution.HakamoO,
        xpClass: Slow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "hakamo_o", //Verify
        graphicsLocation: "hakamo_o", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.HakamoO,
        abilities: new Ability[3]
        {
            Bulletproof,
            Soundproof,
            Overcoat,
        }
    );
    public static readonly SpeciesData KommoO = new(
        speciesName: "Kommo-O",
        type1: Dragon,
        type2: Fighting,
        baseHP: 75,
        baseAttack: 110,
        baseDefense: 125,
        baseSpAtk: 100,
        baseSpDef: 105,
        baseSpeed: 85,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "kommo_o", //Verify
        graphicsLocation: "kommo_o", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.KommoO,
        abilities: new Ability[3]
        {
                Bulletproof,
                Soundproof,
                Overcoat,
        }
    );
    public static readonly SpeciesData TapuKoko = new(
        speciesName: "Tapu Koko",
        type1: Electric,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 115,
        baseDefense: 85,
        baseSpAtk: 95,
        baseSpDef: 75,
        baseSpeed: 130,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 15,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "tapu_koko", //Verify
        graphicsLocation: "tapu_koko", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.TapuKoko,
        abilities: new Ability[3]
        {
                ElectricSurge,
                ElectricSurge,
                Telepathy,
        }
    );
    public static readonly SpeciesData TapuLele = new(
        speciesName: "Tapu Lele",
        type1: Psychic,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 75,
        baseSpAtk: 130,
        baseSpDef: 115,
        baseSpeed: 95,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 15,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "tapu_lele", //Verify
        graphicsLocation: "tapu_lele", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.TapuLele,
        abilities: new Ability[3]
        {
                PsychicSurge,
                PsychicSurge,
                Telepathy,
        }
    );
    public static readonly SpeciesData TapuBulu = new(
        speciesName: "Tapu Bulu",
        type1: Grass,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 130,
        baseDefense: 115,
        baseSpAtk: 85,
        baseSpDef: 95,
        baseSpeed: 75,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 15,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "tapu_bulu", //Verify
        graphicsLocation: "tapu_bulu", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.TapuBulu,
        abilities: new Ability[3]
        {
                GrassySurge,
                GrassySurge,
                Telepathy,
        }
    );
    public static readonly SpeciesData TapuFini = new(
        speciesName: "Tapu Fini",
        type1: Water,
        type2: Fairy,
        baseHP: 70,
        baseAttack: 75,
        baseDefense: 115,
        baseSpAtk: 95,
        baseSpDef: 130,
        baseSpeed: 85,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 15,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "tapu_fini", //Verify
        graphicsLocation: "tapu_fini", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.TapuFini,
        abilities: new Ability[3]
        {
                MistySurge,
                MistySurge,
                Telepathy,
        }
    );
    public static readonly SpeciesData Cosmog = new(
        speciesName: "Cosmog",
        type1: Psychic,
        type2: Psychic,
        baseHP: 43,
        baseAttack: 29,
        baseDefense: 31,
        baseSpAtk: 29,
        baseSpDef: 31,
        baseSpeed: 37,
        evYield: HP,
        evolution: Evolution.Cosmog,
        xpClass: Slow,
        xpYield: 40,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "cosmog", //Verify
        graphicsLocation: "cosmog", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Cosmog,
        abilities: new Ability[3]
        {
                Unaware,
                Unaware,
                Unaware,
        }
    );
    public static readonly SpeciesData Cosmoem = new(
        speciesName: "Cosmoem",
        type1: Psychic,
        type2: Psychic,
        baseHP: 43,
        baseAttack: 29,
        baseDefense: 131,
        baseSpAtk: 29,
        baseSpDef: 131,
        baseSpeed: 37,
        evYield: Defense + SpDef,
        evolution: Evolution.Cosmoem,
        xpClass: Slow,
        xpYield: 140,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "cosmoem", //Verify
        graphicsLocation: "cosmoem", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Cosmoem,
        abilities: new Ability[3]
        {
                Sturdy,
                Sturdy,
                Sturdy,
        }
    );
    public static readonly SpeciesData Solgaleo = new(
        speciesName: "Solgaleo",
        type1: Psychic,
        type2: Steel,
        baseHP: 137,
        baseAttack: 137,
        baseDefense: 107,
        baseSpAtk: 113,
        baseSpDef: 89,
        baseSpeed: 97,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "solgaleo", //Verify
        graphicsLocation: "solgaleo", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Solgaleo,
        abilities: new Ability[3]
        {
                FullMetalBody,
                FullMetalBody,
                FullMetalBody,
        }
    );
    public static readonly SpeciesData Lunala = new(
        speciesName: "Lunala",
        type1: Psychic,
        type2: Ghost,
        baseHP: 137,
        baseAttack: 113,
        baseDefense: 89,
        baseSpAtk: 137,
        baseSpDef: 107,
        baseSpeed: 97,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "lunala", //Verify
        graphicsLocation: "lunala", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Lunala,
        abilities: new Ability[3]
        {
                ShadowShield,
                ShadowShield,
                ShadowShield,
        }
    );
    public static readonly SpeciesData Nihilego = new(
        speciesName: "Nihilego",
        type1: Rock,
        type2: Poison,
        baseHP: 109,
        baseAttack: 53,
        baseDefense: 47,
        baseSpAtk: 127,
        baseSpDef: 131,
        baseSpeed: 103,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "nihilego", //Verify
        graphicsLocation: "nihilego", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Nihilego,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Buzzwole = new(
        speciesName: "Buzzwole",
        type1: Bug,
        type2: Fighting,
        baseHP: 107,
        baseAttack: 139,
        baseDefense: 139,
        baseSpAtk: 53,
        baseSpDef: 53,
        baseSpeed: 79,
        evYield: Attack + 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "buzzwole", //Verify
        graphicsLocation: "buzzwole", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Buzzwole,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Pheromosa = new(
        speciesName: "Pheromosa",
        type1: Bug,
        type2: Fighting,
        baseHP: 71,
        baseAttack: 137,
        baseDefense: 37,
        baseSpAtk: 137,
        baseSpDef: 37,
        baseSpeed: 151,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "pheromosa", //Verify
        graphicsLocation: "pheromosa", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Pheromosa,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Xurkitree = new(
        speciesName: "Xurkitree",
        type1: Electric,
        type2: Electric,
        baseHP: 83,
        baseAttack: 89,
        baseDefense: 71,
        baseSpAtk: 173,
        baseSpDef: 71,
        baseSpeed: 83,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "xurkitree", //Verify
        graphicsLocation: "xurkitree", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Xurkitree,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Celesteela = new(
        speciesName: "Celesteela",
        type1: Steel,
        type2: Flying,
        baseHP: 97,
        baseAttack: 101,
        baseDefense: 103,
        baseSpAtk: 107,
        baseSpDef: 101,
        baseSpeed: 61,
        evYield: Attack + Defense + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "celesteela", //Verify
        graphicsLocation: "celesteela", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Celesteela,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Kartana = new(
        speciesName: "Kartana",
        type1: Grass,
        type2: Steel,
        baseHP: 59,
        baseAttack: 181,
        baseDefense: 131,
        baseSpAtk: 59,
        baseSpDef: 31,
        baseSpeed: 109,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "kartana", //Verify
        graphicsLocation: "kartana", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Kartana,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Guzzlord = new(
        speciesName: "Guzzlord",
        type1: Dark,
        type2: Dragon,
        baseHP: 223,
        baseAttack: 101,
        baseDefense: 53,
        baseSpAtk: 97,
        baseSpDef: 53,
        baseSpeed: 43,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "guzzlord", //Verify
        graphicsLocation: "guzzlord", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Guzzlord,
        abilities: new Ability[3]
        {
                BeastBoost,
                BeastBoost,
                BeastBoost,
        }
    );
    public static readonly SpeciesData Necrozma = new(
        speciesName: "Necrozma",
        type1: Psychic,
        type2: Psychic,
        baseHP: 97,
        baseAttack: 107,
        baseDefense: 101,
        baseSpAtk: 127,
        baseSpDef: 89,
        baseSpeed: 79,
        evYield: Attack + 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "necrozma", //Verify
        graphicsLocation: "necrozma", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Necrozma,
        abilities: new Ability[3]
        {
                PrismArmor,
                PrismArmor,
                PrismArmor,
        }
    );
    public static readonly SpeciesData MagearnaBase = Magearna(false);
    public static readonly SpeciesData Marshadow = new(
        speciesName: "Marshadow",
        type1: Fighting,
        type2: Ghost,
        baseHP: 90,
        baseAttack: 125,
        baseDefense: 80,
        baseSpAtk: 90,
        baseSpDef: 90,
        baseSpeed: 125,
        evYield: 2 * Attack + Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "marshadow", //Verify
        graphicsLocation: "marshadow", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Marshadow,
        abilities: new Ability[3]
        {
            Technician,
            Technician,
            Technician,
        }
    );
    public static readonly SpeciesData Poipole = new(
        speciesName: "Poipole",
        type1: Poison,
        type2: Poison,
        baseHP: 67,
        baseAttack: 73,
        baseDefense: 67,
        baseSpAtk: 73,
        baseSpDef: 67,
        baseSpeed: 73,
        evYield: Speed,
        evolution: Evolution.Poipole,
        xpClass: Slow,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "poipole", //Verify
        graphicsLocation: "poipole", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Poipole,
        abilities: new Ability[3]
        {
            BeastBoost,
            BeastBoost,
            BeastBoost,
        }
    );
    public static readonly SpeciesData Naganadel = new(
        speciesName: "Naganadel",
        type1: Poison,
        type2: Dragon,
        baseHP: 73,
        baseAttack: 73,
        baseDefense: 73,
        baseSpAtk: 127,
        baseSpDef: 73,
        baseSpeed: 121,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 243,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "naganadel", //Verify
        graphicsLocation: "naganadel", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Naganadel,
        abilities: new Ability[3]
        {
            BeastBoost,
            BeastBoost,
            BeastBoost,
        }
    );
    public static readonly SpeciesData Stakataka = new(
        speciesName: "Stakataka",
        type1: Rock,
        type2: Steel,
        baseHP: 61,
        baseAttack: 131,
        baseDefense: 211,
        baseSpAtk: 53,
        baseSpDef: 101,
        baseSpeed: 13,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 30,
        baseFriendship: 0,
        cryLocation: "stakataka", //Verify
        graphicsLocation: "stakataka", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Stakataka,
        abilities: new Ability[3]
        {
            BeastBoost,
            BeastBoost,
            BeastBoost,
        }
    );
    public static readonly SpeciesData Blacephalon = new(
        speciesName: "Blacephalon",
        type1: Fire,
        type2: Ghost,
        baseHP: 53,
        baseAttack: 127,
        baseDefense: 53,
        baseSpAtk: 151,
        baseSpDef: 79,
        baseSpeed: 107,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 30,
        baseFriendship: 0,
        cryLocation: "blacephalon", //Verify
        graphicsLocation: "blacephalon", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Blacephalon,
        abilities: new Ability[3]
        {
            BeastBoost,
            BeastBoost,
            BeastBoost,
        }
    );
    public static readonly SpeciesData Zeraora = new(
        speciesName: "Zeraora",
        type1: Electric,
        type2: Electric,
        baseHP: 88,
        baseAttack: 112,
        baseDefense: 75,
        baseSpAtk: 102,
        baseSpDef: 80,
        baseSpeed: 143,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "zeraora", //Verify
        graphicsLocation: "zeraora", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Zeraora,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            VoltAbsorb,
            VoltAbsorb,
        }
    );
    public static readonly SpeciesData Meltan = new(
        speciesName: "Meltan",
        type1: Steel,
        type2: Steel,
        baseHP: 46,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 55,
        baseSpDef: 35,
        baseSpeed: 34,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 135,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "meltan", //Verify
        graphicsLocation: "meltan", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Meltan,
        abilities: new Ability[3]
        {
            MagnetPull,
            MagnetPull,
            MagnetPull,
        }
    );
    public static readonly SpeciesData Melmetal = new(
        speciesName: "Melmetal",
        type1: Steel,
        type2: Steel,
        baseHP: 135,
        baseAttack: 143,
        baseDefense: 143,
        baseSpAtk: 80,
        baseSpDef: 65,
        baseSpeed: 34,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "melmetal", //Verify
        graphicsLocation: "melmetal", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Melmetal,
        abilities: new Ability[3]
        {
            IronFist,
            IronFist,
            IronFist,
        }
    );

    //Gen 8

    public static SpeciesData Grookey = new(
        speciesName: "Grookey",
        type1: Grass,
        type2: Grass,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.Grookey,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "grookey", //Verify
        graphicsLocation: "grookey", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Grookey,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            GrassySurge,
        }
    );
    public static SpeciesData Thwackey = new(
        speciesName: "Thwackey",
        type1: Grass,
        type2: Grass,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 70,
        baseSpAtk: 55,
        baseSpDef: 60,
        baseSpeed: 80,
        evYield: 2 * Attack,
        evolution: Evolution.Thwackey,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "thwackey", //Verify
        graphicsLocation: "thwackey", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Thwackey,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            GrassySurge,
        }
    );
    public static SpeciesData Rillaboom = new(
        speciesName: "Rillaboom",
        type1: Grass,
        type2: Grass,
        baseHP: 100,
        baseAttack: 125,
        baseDefense: 90,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 85,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 265,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "rillaboom", //Verify
        graphicsLocation: "rillaboom", //Verify
        backSpriteHeight: 4,
        gMaxPath: "rillaboom/gmax",
        gMaxBackHeight: 4,
        pokedexData: Pokedex.Rillaboom,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            GrassySurge,
        }
    );
    public static SpeciesData Scorbunny = new(
        speciesName: "Scorbunny",
        type1: Fire,
        type2: Fire,
        baseHP: 50,
        baseAttack: 71,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 69,
        evYield: Speed,
        evolution: Evolution.Scorbunny,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "scorbunny", //Verify
        graphicsLocation: "scorbunny", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Scorbunny,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Libero,
        }
    );
    public static SpeciesData Raboot = new(
        speciesName: "Raboot",
        type1: Fire,
        type2: Fire,
        baseHP: 65,
        baseAttack: 86,
        baseDefense: 60,
        baseSpAtk: 55,
        baseSpDef: 60,
        baseSpeed: 94,
        evYield: 2 * Speed,
        evolution: Evolution.Raboot,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "raboot", //Verify
        graphicsLocation: "raboot", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Raboot,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Libero,
        }
    );
    public static SpeciesData Cinderace = new(
        speciesName: "Cinderace",
        type1: Fire,
        type2: Fire,
        baseHP: 80,
        baseAttack: 116,
        baseDefense: 75,
        baseSpAtk: 65,
        baseSpDef: 75,
        baseSpeed: 119,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 265,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "cinderace", //Verify
        graphicsLocation: "cinderace", //Verify
        backSpriteHeight: 4,
        gMaxPath: "cinderace/gmax",
        gMaxBackHeight: 4,
        pokedexData: Pokedex.Cinderace,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            Libero,
        }
    );
    public static SpeciesData Sobble = new(
        speciesName: "Sobble",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 40,
        baseDefense: 40,
        baseSpAtk: 70,
        baseSpDef: 40,
        baseSpeed: 70,
        evYield: Speed + SpDef,
        evolution: Evolution.Sobble,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sobble", //Verify
        graphicsLocation: "sobble", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Sobble,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Sniper,
        }
    );
    public static SpeciesData Drizzile = new(
        speciesName: "Drizzile",
        type1: Water,
        type2: Water,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 55,
        baseSpAtk: 95,
        baseSpDef: 55,
        baseSpeed: 90,
        evYield: 2 * SpAtk,
        evolution: Evolution.Drizzile,
        xpClass: MediumSlow,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "drizzile", //Verify
        graphicsLocation: "drizzile", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Drizzile,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Sniper,
        }
    );
    public static SpeciesData Inteleon = new(
        speciesName: "Inteleon",
        type1: Water,
        type2: Water,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 65,
        baseSpAtk: 125,
        baseSpDef: 65,
        baseSpeed: 120,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 265,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "inteleon", //Verify
        graphicsLocation: "inteleon", //Verify
        backSpriteHeight: 4,
        gMaxPath: "inteleon/gmax",
        gMaxBackHeight: 4,
        pokedexData: Pokedex.Inteleon,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            Sniper,
        }
    );
    public static SpeciesData Skwovet = new(
        speciesName: "Skwovet",
        type1: Normal,
        type2: Normal,
        baseHP: 70,
        baseAttack: 55,
        baseDefense: 55,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 25,
        evYield: HP,
        evolution: Evolution.Skwovet,
        xpClass: MediumFast,
        xpYield: 55,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "skwovet", //Verify
        graphicsLocation: "skwovet", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Skwovet,
        abilities: new Ability[3]
        {
            CheekPouch,
            CheekPouch,
            Gluttony,
        }
    );
    public static SpeciesData Greedent = new(
        speciesName: "Greedent",
        type1: Normal,
        type2: Normal,
        baseHP: 120,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 55,
        baseSpDef: 75,
        baseSpeed: 20,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "greedent", //Verify
        graphicsLocation: "greedent", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Greedent,
        abilities: new Ability[3]
        {
            CheekPouch,
            CheekPouch,
            Gluttony,
        }
    );
    public static SpeciesData Rookidee = new(
        speciesName: "Rookidee",
        type1: Flying,
        type2: Flying,
        baseHP: 38,
        baseAttack: 47,
        baseDefense: 35,
        baseSpAtk: 33,
        baseSpDef: 35,
        baseSpeed: 57,
        evYield: Speed,
        evolution: Evolution.Rookidee,
        xpClass: MediumSlow,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "rookidee", //Verify
        graphicsLocation: "rookidee", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Rookidee,
        abilities: new Ability[3]
        {
            KeenEye,
            Unnerve,
            BigPecks,
        }
    );
    public static SpeciesData Corvisquire = new(
        speciesName: "Corvisquire",
        type1: Flying,
        type2: Flying,
        baseHP: 68,
        baseAttack: 67,
        baseDefense: 55,
        baseSpAtk: 43,
        baseSpDef: 55,
        baseSpeed: 77,
        evYield: 2 * Speed,
        evolution: Evolution.Corvisquire,
        xpClass: MediumSlow,
        xpYield: 128,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "corvisquire", //Verify
        graphicsLocation: "corvisquire", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Corvisquire,
        abilities: new Ability[3]
        {
            KeenEye,
            Unnerve,
            BigPecks,
        }
    );
    public static SpeciesData Corviknight = new(
        speciesName: "Corviknight",
        type1: Flying,
        type2: Steel,
        baseHP: 98,
        baseAttack: 87,
        baseDefense: 105,
        baseSpAtk: 53,
        baseSpDef: 85,
        baseSpeed: 67,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 248,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "corviknight", //Verify
        graphicsLocation: "corviknight", //Verify
        backSpriteHeight: 3,
        gMaxPath: "corviknight/gmax",
        gMaxBackHeight: 3,
        pokedexData: Pokedex.Corviknight,
        abilities: new Ability[3]
        {
            Pressure,
            Unnerve,
            MirrorArmor,
        }
    );
    public static SpeciesData Blipbug = new(
        speciesName: "Blipbug",
        type1: Bug,
        type2: Bug,
        baseHP: 25,
        baseAttack: 20,
        baseDefense: 20,
        baseSpAtk: 25,
        baseSpDef: 45,
        baseSpeed: 45,
        evYield: SpDef,
        evolution: Evolution.Blipbug,
        xpClass: MediumFast,
        xpYield: 36,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "blipbug", //Verify
        graphicsLocation: "blipbug", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Blipbug,
        abilities: new Ability[3]
        {
            Swarm,
            CompoundEyes,
            Telepathy,
        }
    );
    public static SpeciesData Dottler = new(
        speciesName: "Dottler",
        type1: Bug,
        type2: Psychic,
        baseHP: 50,
        baseAttack: 35,
        baseDefense: 80,
        baseSpAtk: 50,
        baseSpDef: 90,
        baseSpeed: 30,
        evYield: 2 * SpDef,
        evolution: Evolution.Dottler,
        xpClass: MediumFast,
        xpYield: 117,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "dottler", //Verify
        graphicsLocation: "dottler", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Dottler,
        abilities: new Ability[3]
        {
            Swarm,
            CompoundEyes,
            Telepathy,
        }
    );
    public static SpeciesData Orbeetle = new(
        speciesName: "Orbeetle",
        type1: Bug,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 45,
        baseDefense: 110,
        baseSpAtk: 80,
        baseSpDef: 120,
        baseSpeed: 90,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 253,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "orbeetle", //Verify
        graphicsLocation: "orbeetle", //Verify
        backSpriteHeight: 6,
        gMaxPath: "orbeetle/gmax",
        gMaxBackHeight: 6,
        pokedexData: Pokedex.Orbeetle,
        abilities: new Ability[3]
        {
            Swarm,
            Frisk,
            Telepathy,
        }
    );
    public static SpeciesData Nickit = new(
        speciesName: "Nickit",
        type1: Dark,
        type2: Dark,
        baseHP: 40,
        baseAttack: 28,
        baseDefense: 28,
        baseSpAtk: 47,
        baseSpDef: 52,
        baseSpeed: 50,
        evYield: SpDef,
        evolution: Evolution.Nickit,
        xpClass: Fast,
        xpYield: 49,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "nickit", //Verify
        graphicsLocation: "nickit", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Nickit,
        abilities: new Ability[3]
        {
            RunAway,
            Unburden,
            Stakeout,
        }
    );
    public static SpeciesData Thievul = new(
        speciesName: "Thievul",
        type1: Dark,
        type2: Dark,
        baseHP: 70,
        baseAttack: 58,
        baseDefense: 58,
        baseSpAtk: 87,
        baseSpDef: 92,
        baseSpeed: 90,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 159,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "thievul", //Verify
        graphicsLocation: "thievul", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Thievul,
        abilities: new Ability[3]
        {
            RunAway,
            Unburden,
            Stakeout,
        }
    );
    public static SpeciesData Gossifleur = new(
        speciesName: "Gossifleur",
        type1: Grass,
        type2: Grass,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 60,
        baseSpeed: 10,
        evYield: SpDef,
        evolution: Evolution.Gossifleur,
        xpClass: MediumFast,
        xpYield: 50,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "gossifleur", //Verify
        graphicsLocation: "gossifleur", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Gossifleur,
        abilities: new Ability[3]
        {
            CottonDown,
            Regenerator,
            EffectSpore,
        }
    );
    public static SpeciesData Eldegoss = new(
        speciesName: "Eldegoss",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 90,
        baseSpAtk: 80,
        baseSpDef: 120,
        baseSpeed: 60,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "eldegoss", //Verify
        graphicsLocation: "eldegoss", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Eldegoss,
        abilities: new Ability[3]
        {
            CottonDown,
            Regenerator,
            EffectSpore,
        }
    );
    public static SpeciesData Wooloo = new(
        speciesName: "Wooloo",
        type1: Normal,
        type2: Normal,
        baseHP: 42,
        baseAttack: 40,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 45,
        baseSpeed: 48,
        evYield: Defense,
        evolution: Evolution.Wooloo,
        xpClass: MediumFast,
        xpYield: 122,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "wooloo", //Verify
        graphicsLocation: "wooloo", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Wooloo,
        abilities: new Ability[3]
        {
            Fluffy,
            RunAway,
            Bulletproof,
        }
    );
    public static SpeciesData Dubwool = new(
        speciesName: "Dubwool",
        type1: Normal,
        type2: Normal,
        baseHP: 72,
        baseAttack: 80,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 90,
        baseSpeed: 88,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "dubwool", //Verify
        graphicsLocation: "dubwool", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Dubwool,
        abilities: new Ability[3]
        {
            Fluffy,
            Steadfast,
            Bulletproof,
        }
    );
    public static SpeciesData Chewtle = new(
        speciesName: "Chewtle",
        type1: Water,
        type2: Water,
        baseHP: 50,
        baseAttack: 64,
        baseDefense: 50,
        baseSpAtk: 38,
        baseSpDef: 38,
        baseSpeed: 44,
        evYield: Attack,
        evolution: Evolution.Chewtle,
        xpClass: MediumFast,
        xpYield: 57,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "chewtle", //Verify
        graphicsLocation: "chewtle", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Chewtle,
        abilities: new Ability[3]
        {
            StrongJaw,
            ShellArmor,
            SwiftSwim,
        }
    );
    public static SpeciesData Drednaw = new(
        speciesName: "Drednaw",
        type1: Water,
        type2: Rock,
        baseHP: 90,
        baseAttack: 115,
        baseDefense: 90,
        baseSpAtk: 48,
        baseSpDef: 68,
        baseSpeed: 74,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "drednaw", //Verify
        graphicsLocation: "drednaw", //Verify
        backSpriteHeight: 18,
        gMaxPath: "drednaw/gmax",
        gMaxBackHeight: 12,
        pokedexData: Pokedex.Drednaw,
        abilities: new Ability[3]
        {
            StrongJaw,
            ShellArmor,
            SwiftSwim,
        }
    );
    public static SpeciesData Yamper = new(
        speciesName: "Yamper",
        type1: Electric,
        type2: Electric,
        baseHP: 59,
        baseAttack: 45,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 26,
        evYield: HP,
        evolution: Evolution.Yamper,
        xpClass: Fast,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "yamper", //Verify
        graphicsLocation: "yamper", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Yamper,
        abilities: new Ability[3]
        {
            BallFetch,
            BallFetch,
            Rattled,
        }
    );
    public static SpeciesData Boltund = new(
        speciesName: "Boltund",
        type1: Electric,
        type2: Electric,
        baseHP: 69,
        baseAttack: 90,
        baseDefense: 60,
        baseSpAtk: 90,
        baseSpDef: 60,
        baseSpeed: 121,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "boltund", //Verify
        graphicsLocation: "boltund", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Boltund,
        abilities: new Ability[3]
        {
            StrongJaw,
            StrongJaw,
            Competitive,
        }
    );
    public static SpeciesData Rolycoly = new(
        speciesName: "Rolycoly",
        type1: Rock,
        type2: Rock,
        baseHP: 30,
        baseAttack: 40,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.Rolycoly,
        xpClass: MediumSlow,
        xpYield: 48,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "rolycoly", //Verify
        graphicsLocation: "rolycoly", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Rolycoly,
        abilities: new Ability[3]
        {
            SteamEngine,
            Heatproof,
            FlashFire,
        }
    );
    public static SpeciesData Carkol = new(
        speciesName: "Carkol",
        type1: Rock,
        type2: Fire,
        baseHP: 80,
        baseAttack: 60,
        baseDefense: 90,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.Carkol,
        xpClass: MediumSlow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "carkol", //Verify
        graphicsLocation: "carkol", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Carkol,
        abilities: new Ability[3]
        {
            SteamEngine,
            FlameBody,
            FlashFire,
        }
    );
    public static SpeciesData Coalossal = new(
        speciesName: "Coalossal",
        type1: Rock,
        type2: Fire,
        baseHP: 110,
        baseAttack: 80,
        baseDefense: 120,
        baseSpAtk: 80,
        baseSpDef: 90,
        baseSpeed: 30,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 255,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "coalossal", //Verify
        graphicsLocation: "coalossal", //Verify
        backSpriteHeight: 11,
        gMaxPath: "coalossal/gmax",
        gMaxBackHeight: 8,
        pokedexData: Pokedex.Coalossal,
        abilities: new Ability[3]
        {
            SteamEngine,
            FlameBody,
            FlashFire,
        }
    );
    public static SpeciesData Applin = new(
        speciesName: "Applin",
        type1: Grass,
        type2: Dragon,
        baseHP: 40,
        baseAttack: 40,
        baseDefense: 80,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 20,
        evYield: Defense,
        evolution: Evolution.Applin,
        xpClass: Erratic,
        xpYield: 52,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "applin", //Verify
        graphicsLocation: "applin", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Applin,
        abilities: new Ability[3]
        {
            Ripen,
            Gluttony,
            Bulletproof,
        }
    );
    public static SpeciesData Flapple = new(
        speciesName: "Flapple",
        type1: Grass,
        type2: Dragon,
        baseHP: 70,
        baseAttack: 110,
        baseDefense: 80,
        baseSpAtk: 95,
        baseSpDef: 60,
        baseSpeed: 70,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "flapple", //Verify
        graphicsLocation: "flapple", //Verify
        backSpriteHeight: 8,
        gMaxPath: "flapple/gmax",
        gMaxBackHeight: 2,
        pokedexData: Pokedex.Flapple,
        abilities: new Ability[3]
        {
            Ripen,
            Gluttony,
            Hustle,
        }
    );
    public static SpeciesData Appletun = new(
        speciesName: "Appletun",
        type1: Grass,
        type2: Dragon,
        baseHP: 110,
        baseAttack: 85,
        baseDefense: 80,
        baseSpAtk: 100,
        baseSpDef: 80,
        baseSpeed: 30,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: Erratic,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "appletun", //Verify
        graphicsLocation: "appletun", //Verify
        backSpriteHeight: 11,
        gMaxPath: "appletun/gmax", //Could use Flapple
        gMaxBackHeight: 2,
        pokedexData: Pokedex.Appletun,
        abilities: new Ability[3]
        {
            Ripen,
            Gluttony,
            ThickFat,
        }
    );
    public static SpeciesData Silicobra = new(
        speciesName: "Silicobra",
        type1: Ground,
        type2: Ground,
        baseHP: 52,
        baseAttack: 57,
        baseDefense: 75,
        baseSpAtk: 35,
        baseSpDef: 50,
        baseSpeed: 46,
        evYield: Defense,
        evolution: Evolution.Silicobra,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "silicobra", //Verify
        graphicsLocation: "silicobra", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Silicobra,
        abilities: new Ability[3]
        {
            SandSpit,
            ShedSkin,
            SandVeil,
        }
    );
    public static SpeciesData Sandaconda = new(
        speciesName: "Sandaconda",
        type1: Ground,
        type2: Ground,
        baseHP: 72,
        baseAttack: 107,
        baseDefense: 125,
        baseSpAtk: 65,
        baseSpDef: 70,
        baseSpeed: 71,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "sandaconda", //Verify
        graphicsLocation: "sandaconda", //Verify
        backSpriteHeight: 13,
        gMaxPath: "sandaconda/gmax",
        gMaxBackHeight: 5,
        pokedexData: Pokedex.Sandaconda,
        abilities: new Ability[3]
        {
            SandSpit,
            ShedSkin,
            SandVeil,
        }
    );

    public static SpeciesData Cramorant = Cramorant(0);

    public static SpeciesData Arrokuda = new(
        speciesName: "Arrokuda",
        type1: Water,
        type2: Water,
        baseHP: 41,
        baseAttack: 63,
        baseDefense: 40,
        baseSpAtk: 40,
        baseSpDef: 30,
        baseSpeed: 66,
        evYield: Speed,
        evolution: Evolution.Arrokuda,
        xpClass: Slow,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "arrokuda", //Verify
        graphicsLocation: "arrokuda", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Arrokuda,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            PropellerTail,
        }
    );
    public static SpeciesData Barraskewda = new(
        speciesName: "Barraskewda",
        type1: Water,
        type2: Water,
        baseHP: 61,
        baseAttack: 123,
        baseDefense: 60,
        baseSpAtk: 60,
        baseSpDef: 50,
        baseSpeed: 136,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "barraskewda", //Verify
        graphicsLocation: "barraskewda", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Barraskewda,
        abilities: new Ability[3]
        {
            SwiftSwim,
            SwiftSwim,
            PropellerTail,
        }
    );
    public static SpeciesData Toxel = new(
        speciesName: "Toxel",
        type1: Electric,
        type2: Poison,
        baseHP: 40,
        baseAttack: 38,
        baseDefense: 35,
        baseSpAtk: 54,
        baseSpDef: 35,
        baseSpeed: 40,
        evYield: SpAtk,
        evolution: Evolution.Toxel,
        xpClass: MediumSlow,
        xpYield: 48,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 25,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "toxel", //Verify
        graphicsLocation: "toxel", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Toxel,
        abilities: new Ability[3]
        {
            Rattled,
            Static,
            Klutz,
        }
    );
    public static SpeciesData Toxtricity = Toxtricity(false);
    public static SpeciesData Sizzlipede = new(
        speciesName: "Sizzlipede",
        type1: Fire,
        type2: Bug,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 45,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 45,
        evYield: Attack,
        evolution: Evolution.Sizzlipede,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "sizzlipede", //Verify
        graphicsLocation: "sizzlipede", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Sizzlipede,
        abilities: new Ability[3]
        {
            FlashFire,
            WhiteSmoke,
            FlameBody,
        }
    );
    public static SpeciesData Centiskorch = new(
        speciesName: "Centiskorch",
        type1: Fire,
        type2: Bug,
        baseHP: 100,
        baseAttack: 115,
        baseDefense: 65,
        baseSpAtk: 90,
        baseSpDef: 90,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "centiskorch", //Verify
        graphicsLocation: "centiskorch", //Verify
        backSpriteHeight: 2,
        gMaxPath: "centiskorch/gmax",
        gMaxBackHeight: 1,
        pokedexData: Pokedex.Centiskorch,
        abilities: new Ability[3]
        {
            FlashFire,
            WhiteSmoke,
            FlameBody,
        }
    );
    public static SpeciesData Clobbopus = new(
        speciesName: "Clobbopus",
        type1: Fighting,
        type2: Fighting,
        baseHP: 50,
        baseAttack: 68,
        baseDefense: 60,
        baseSpAtk: 50,
        baseSpDef: 50,
        baseSpeed: 32,
        evYield: Attack,
        evolution: Evolution.Clobbopus,
        xpClass: MediumSlow,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 180,
        baseFriendship: 70,
        cryLocation: "clobbopus", //Verify
        graphicsLocation: "clobbopus", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Clobbopus,
        abilities: new Ability[3]
        {
            Limber,
            Limber,
            Technician,
        }
    );
    public static SpeciesData Grapploct = new(
        speciesName: "Grapploct",
        type1: Fighting,
        type2: Fighting,
        baseHP: 80,
        baseAttack: 118,
        baseDefense: 90,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 42,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "grapploct", //Verify
        graphicsLocation: "grapploct", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Grapploct,
        abilities: new Ability[3]
        {
            Limber,
            Limber,
            Technician,
        }
    );

    public static SpeciesData Sinistea = Sinistea(false);
    public static SpeciesData Polteageist = Polteageist(false);

    public static SpeciesData Hatenna = new(
        speciesName: "Hatenna",
        type1: Psychic,
        type2: Psychic,
        baseHP: 42,
        baseAttack: 30,
        baseDefense: 45,
        baseSpAtk: 56,
        baseSpDef: 53,
        baseSpeed: 39,
        evYield: SpAtk,
        evolution: Evolution.Hatenna,
        xpClass: Slow,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 235,
        baseFriendship: 70,
        cryLocation: "hatenna", //Verify
        graphicsLocation: "hatenna", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Hatenna,
        abilities: new Ability[3]
        {
            Healer,
            Anticipation,
            MagicBounce,
        }
    );
    public static SpeciesData Hattrem = new(
        speciesName: "Hattrem",
        type1: Psychic,
        type2: Psychic,
        baseHP: 57,
        baseAttack: 40,
        baseDefense: 65,
        baseSpAtk: 86,
        baseSpDef: 73,
        baseSpeed: 49,
        evYield: 2 * SpAtk,
        evolution: Evolution.Hattrem,
        xpClass: Slow,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "hattrem", //Verify
        graphicsLocation: "hattrem", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Hattrem,
        abilities: new Ability[3]
        {
            Healer,
            Anticipation,
            MagicBounce,
        }
    );
    public static SpeciesData Hatterene = new(
        speciesName: "Hatterene",
        type1: Psychic,
        type2: Fairy,
        baseHP: 57,
        baseAttack: 90,
        baseDefense: 95,
        baseSpAtk: 136,
        baseSpDef: 103,
        baseSpeed: 29,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 255,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "hatterene", //Verify
        graphicsLocation: "hatterene", //Verify
        backSpriteHeight: 3,
        gMaxPath: "hatterene/gmax",
        gMaxBackHeight: 3,
        pokedexData: Pokedex.Hatterene,
        abilities: new Ability[3]
        {
            Healer,
            Anticipation,
            MagicBounce,
        }
    );
    public static SpeciesData Impidimp = new(
        speciesName: "Impidimp",
        type1: Dark,
        type2: Fairy,
        baseHP: 45,
        baseAttack: 45,
        baseDefense: 30,
        baseSpAtk: 55,
        baseSpDef: 40,
        baseSpeed: 50,
        evYield: SpAtk,
        evolution: Evolution.Impidimp,
        xpClass: MediumFast,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "impidimp", //Verify
        graphicsLocation: "impidimp", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Impidimp,
        abilities: new Ability[3]
        {
            Prankster,
            Frisk,
            Pickpocket,
        }
    );
    public static SpeciesData Morgrem = new(
        speciesName: "Morgrem",
        type1: Dark,
        type2: Fairy,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 45,
        baseSpAtk: 75,
        baseSpDef: 55,
        baseSpeed: 70,
        evYield: 2 * SpAtk,
        evolution: Evolution.Morgrem,
        xpClass: MediumFast,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "morgrem", //Verify
        graphicsLocation: "morgrem", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Morgrem,
        abilities: new Ability[3]
        {
            Prankster,
            Frisk,
            Pickpocket,
        }
    );
    public static SpeciesData Grimmsnarl = new(
        speciesName: "Grimmsnarl",
        type1: Dark,
        type2: Fairy,
        baseHP: 95,
        baseAttack: 120,
        baseDefense: 65,
        baseSpAtk: 95,
        baseSpDef: 75,
        baseSpeed: 60,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 255,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "grimmsnarl", //Verify
        graphicsLocation: "grimmsnarl", //Verify
        backSpriteHeight: 10,
        gMaxPath: "grimmsnarl/gmax",
        gMaxBackHeight: 10,
        pokedexData: Pokedex.Grimmsnarl,
        abilities: new Ability[3]
        {
            Prankster,
            Frisk,
            Pickpocket,
        }
    );
    public static SpeciesData Obstagoon = new(
        speciesName: "Obstagoon",
        type1: Dark,
        type2: Normal,
        baseHP: 93,
        baseAttack: 90,
        baseDefense: 101,
        baseSpAtk: 60,
        baseSpDef: 81,
        baseSpeed: 95,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 260,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "obstagoon", //Verify
        graphicsLocation: "obstagoon", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Obstagoon,
        abilities: new Ability[3]
        {
            Reckless,
            Guts,
            Defiant,
        }
    );
    public static SpeciesData Perrserker = new(
        speciesName: "Perrserker",
        type1: Steel,
        type2: Steel,
        baseHP: 70,
        baseAttack: 110,
        baseDefense: 100,
        baseSpAtk: 50,
        baseSpDef: 60,
        baseSpeed: 50,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "perrserker", //Verify
        graphicsLocation: "perrserker", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Perrserker,
        abilities: new Ability[3]
        {
            BattleArmor,
            ToughClaws,
            SteelySpirit,
        }
    );
    public static SpeciesData Cursola = new(
        speciesName: "Cursola",
        type1: Ghost,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 95,
        baseDefense: 50,
        baseSpAtk: 145,
        baseSpDef: 130,
        baseSpeed: 30,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "cursola", //Verify
        graphicsLocation: "cursola", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Cursola,
        abilities: new Ability[3]
        {
            WeakArmor,
            WeakArmor,
            PerishBody,
        }
    );
    public static SpeciesData Sirfetchd = new(
        speciesName: "Sirfetchd",
        type1: Fighting,
        type2: Fighting,
        baseHP: 62,
        baseAttack: 135,
        baseDefense: 95,
        baseSpAtk: 68,
        baseSpDef: 82,
        baseSpeed: 65,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "sirfetchd", //Verify
        graphicsLocation: "sirfetchd", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Sirfetchd,
        abilities: new Ability[3]
        {
            Steadfast,
            Steadfast,
            Scrappy,
        }
    );
    public static SpeciesData MrRime = new(
        speciesName: "Mr. Rime",
        type1: Ice,
        type2: Psychic,
        baseHP: 80,
        baseAttack: 85,
        baseDefense: 75,
        baseSpAtk: 110,
        baseSpDef: 100,
        baseSpeed: 70,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 182,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mr_rime", //Verify
        graphicsLocation: "mr_rime", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.MrRime,
        abilities: new Ability[3]
        {
            TangledFeet,
            ScreenCleaner,
            IceBody,
        }
    );
    public static SpeciesData Runerigus = new(
        speciesName: "Runerigus",
        type1: Ground,
        type2: Ghost,
        baseHP: 58,
        baseAttack: 95,
        baseDefense: 145,
        baseSpAtk: 50,
        baseSpDef: 105,
        baseSpeed: 30,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 169,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "runerigus", //Verify
        graphicsLocation: "runerigus", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Runerigus,
        abilities: new Ability[3]
        {
            WanderingSpirit,
            WanderingSpirit,
            WanderingSpirit,
        }
    );
    public static SpeciesData Milcery = new(
        speciesName: "Milcery",
        type1: Fairy,
        type2: Fairy,
        baseHP: 45,
        baseAttack: 40,
        baseDefense: 40,
        baseSpAtk: 50,
        baseSpDef: 61,
        baseSpeed: 34,
        evYield: SpDef,
        evolution: Evolution.None, //Not done
        xpClass: MediumFast,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 200,
        baseFriendship: 70,
        cryLocation: "milcery", //Verify
        graphicsLocation: "milcery", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Milcery,
        abilities: new Ability[3]
        {
            SweetVeil,
            SweetVeil,
            AromaVeil,
        }
    );
    public static SpeciesData Alcremie = Alcremie();

    public static SpeciesData Falinks = new(
        speciesName: "Falinks",
        type1: Fighting,
        type2: Fighting,
        baseHP: 65,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 70,
        baseSpDef: 60,
        baseSpeed: 75,
        evYield: 2 * Attack + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "falinks", //Verify
        graphicsLocation: "falinks", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Falinks,
        abilities: new Ability[3]
        {
            BattleArmor,
            BattleArmor,
            Defiant,
        }
    );
    public static SpeciesData Pincurchin = new(
        speciesName: "Pincurchin",
        type1: Electric,
        type2: Electric,
        baseHP: 48,
        baseAttack: 101,
        baseDefense: 95,
        baseSpAtk: 91,
        baseSpDef: 85,
        baseSpeed: 15,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 152,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "pincurchin", //Verify
        graphicsLocation: "pincurchin", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Pincurchin,
        abilities: new Ability[3]
        {
            LightningRod,
            LightningRod,
            ElectricSurge,
        }
    );
    public static SpeciesData Snom = new(
        speciesName: "Snom",
        type1: Ice,
        type2: Bug,
        baseHP: 30,
        baseAttack: 25,
        baseDefense: 35,
        baseSpAtk: 45,
        baseSpDef: 30,
        baseSpeed: 20,
        evYield: SpAtk,
        evolution: Evolution.Snom,
        xpClass: MediumFast,
        xpYield: 37,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "snom", //Verify
        graphicsLocation: "snom", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Snom,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            IceScales,
        }
    );
    public static SpeciesData Frosmoth = new(
        speciesName: "Frosmoth",
        type1: Ice,
        type2: Bug,
        baseHP: 70,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 125,
        baseSpDef: 90,
        baseSpeed: 65,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "frosmoth", //Verify
        graphicsLocation: "frosmoth", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Frosmoth,
        abilities: new Ability[3]
        {
            ShieldDust,
            ShieldDust,
            IceScales,
        }
    );
    public static SpeciesData Stonjourner = new(
        speciesName: "Stonjourner",
        type1: Rock,
        type2: Rock,
        baseHP: 100,
        baseAttack: 125,
        baseDefense: 135,
        baseSpAtk: 20,
        baseSpDef: 20,
        baseSpeed: 70,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "stonjourner", //Verify
        graphicsLocation: "stonjourner", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Stonjourner,
        abilities: new Ability[3]
        {
            PowerSpot,
            PowerSpot,
            PowerSpot,
        }
    );
    public static SpeciesData Eiscue = new(
        speciesName: "Eiscue",
        type1: Ice,
        type2: Ice,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 110,
        baseSpAtk: 65,
        baseSpDef: 90,
        baseSpeed: 50,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 25,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "eiscue", //Verify
        graphicsLocation: "eiscue", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Eiscue,
        abilities: new Ability[3]
        {
            IceFace,
            IceFace,
            IceFace,
        }
    );
    public static SpeciesData Indeedee = new(
        speciesName: "Indeedee",
        type1: Psychic,
        type2: Normal,
        baseHP: 60,
        baseAttack: 65,
        baseDefense: 55,
        baseSpAtk: 105,
        baseSpDef: 95,
        baseSpeed: 95,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 40,
        catchRate: 30,
        baseFriendship: 140,
        cryLocation: "indeedee", //Verify
        graphicsLocation: "indeedee", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Indeedee,
        abilities: new Ability[3]
        {
            InnerFocus,
            Synchronize,
            PsychicSurge,
        }
    );
    public static SpeciesData Morpeko = Morpeko(false);

    public static SpeciesData Cufant = new(
        speciesName: "Cufant",
        type1: Steel,
        type2: Steel,
        baseHP: 72,
        baseAttack: 80,
        baseDefense: 49,
        baseSpAtk: 40,
        baseSpDef: 49,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.Cufant,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "cufant", //Verify
        graphicsLocation: "cufant", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Cufant,
        abilities: new Ability[3]
        {
            SheerForce,
            SheerForce,
            HeavyMetal,
        }
    );
    public static SpeciesData Copperajah = new(
        speciesName: "Copperajah",
        type1: Steel,
        type2: Steel,
        baseHP: 122,
        baseAttack: 130,
        baseDefense: 69,
        baseSpAtk: 80,
        baseSpDef: 69,
        baseSpeed: 30,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "copperajah", //Verify
        graphicsLocation: "copperajah", //Verify
        backSpriteHeight: 16,
        gMaxPath: "copperajah/gmax",
        gMaxBackHeight: 7,
        pokedexData: Pokedex.Copperajah,
        abilities: new Ability[3]
        {
            SheerForce,
            SheerForce,
            HeavyMetal,
        }
    );
    public static SpeciesData Dracozolt = new(
        speciesName: "Dracozolt",
        type1: Electric,
        type2: Dragon,
        baseHP: 90,
        baseAttack: 100,
        baseDefense: 90,
        baseSpAtk: 80,
        baseSpDef: 70,
        baseSpeed: 75,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dracozolt", //Verify
        graphicsLocation: "dracozolt", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Dracozolt,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            Hustle,
            SandRush,
        }
    );
    public static SpeciesData Arctozolt = new(
        speciesName: "Arctozolt",
        type1: Electric,
        type2: Ice,
        baseHP: 90,
        baseAttack: 100,
        baseDefense: 90,
        baseSpAtk: 90,
        baseSpDef: 80,
        baseSpeed: 55,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "arctozolt", //Verify
        graphicsLocation: "arctozolt", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Arctozolt,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            Static,
            SlushRush,
        }
    );
    public static SpeciesData Dracovish = new(
        speciesName: "Dracovish",
        type1: Water,
        type2: Dragon,
        baseHP: 90,
        baseAttack: 90,
        baseDefense: 100,
        baseSpAtk: 70,
        baseSpDef: 80,
        baseSpeed: 75,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dracovish", //Verify
        graphicsLocation: "dracovish", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Dracovish,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            StrongJaw,
            SandRush,
        }
    );
    public static SpeciesData Arctovish = new(
        speciesName: "Arctovish",
        type1: Water,
        type2: Ice,
        baseHP: 90,
        baseAttack: 90,
        baseDefense: 100,
        baseSpAtk: 80,
        baseSpDef: 90,
        baseSpeed: 55,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "arctovish", //Verify
        graphicsLocation: "arctovish", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Arctovish,
        abilities: new Ability[3]
        {
            WaterAbsorb,
            IceBody,
            SlushRush,
        }
    );
    public static SpeciesData Duraludon = new(
        speciesName: "Duraludon",
        type1: Steel,
        type2: Dragon,
        baseHP: 70,
        baseAttack: 95,
        baseDefense: 115,
        baseSpAtk: 120,
        baseSpDef: 50,
        baseSpeed: 85,
        evYield: 2 * SpAtk,
        evolution: Evolution.None, //Not done
        xpClass: MediumFast,
        xpYield: 187,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 30,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "duraludon", //Verify
        graphicsLocation: "duraludon", //Verify
        backSpriteHeight: 1,
        gMaxPath: "duraludon/gmax",
        gMaxBackHeight: 0,
        pokedexData: Pokedex.Duraludon,
        abilities: new Ability[3]
        {
            LightMetal,
            HeavyMetal,
            Stalwart,
        }
    );
    public static SpeciesData Dreepy = new(
        speciesName: "Dreepy",
        type1: Dragon,
        type2: Ghost,
        baseHP: 28,
        baseAttack: 60,
        baseDefense: 30,
        baseSpAtk: 40,
        baseSpDef: 30,
        baseSpeed: 82,
        evYield: Speed,
        evolution: Evolution.Dreepy,
        xpClass: Slow,
        xpYield: 54,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dreepy", //Verify
        graphicsLocation: "dreepy", //Verify
        backSpriteHeight: 15,
        pokedexData: Pokedex.Dreepy,
        abilities: new Ability[3]
        {
            ClearBody,
            Infiltrator,
            CursedBody,
        }
    );
    public static SpeciesData Drakloak = new(
        speciesName: "Drakloak",
        type1: Dragon,
        type2: Ghost,
        baseHP: 68,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 60,
        baseSpDef: 50,
        baseSpeed: 102,
        evYield: 2 * Speed,
        evolution: Evolution.Drakloak,
        xpClass: Slow,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "drakloak", //Verify
        graphicsLocation: "drakloak", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Drakloak,
        abilities: new Ability[3]
        {
            ClearBody,
            Infiltrator,
            CursedBody,
        }
    );
    public static SpeciesData Dragapult = new(
        speciesName: "Dragapult",
        type1: Dragon,
        type2: Ghost,
        baseHP: 88,
        baseAttack: 120,
        baseDefense: 75,
        baseSpAtk: 100,
        baseSpDef: 75,
        baseSpeed: 142,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 300,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "dragapult", //Verify
        graphicsLocation: "dragapult", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Dragapult,
        abilities: new Ability[3]
        {
            ClearBody,
            Infiltrator,
            CursedBody,
        }
    );
    public static SpeciesData Zacian = new(
        speciesName: "Zacian",
        type1: Fairy,
        type2: Fairy,
        baseHP: 92,
        baseAttack: 130,
        baseDefense: 115,
        baseSpAtk: 80,
        baseSpDef: 115,
        baseSpeed: 138,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 335,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 10,
        baseFriendship: 0,
        cryLocation: "zacian", //Verify
        graphicsLocation: "zacian", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Zacian,
        abilities: new Ability[3]
        {
            IntrepidSword,
            IntrepidSword,
            IntrepidSword,
        }
    );
    public static SpeciesData Zamazenta = new(
        speciesName: "Zamazenta",
        type1: Fighting,
        type2: Fighting,
        baseHP: 92,
        baseAttack: 130,
        baseDefense: 115,
        baseSpAtk: 80,
        baseSpDef: 115,
        baseSpeed: 138,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 335,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 10,
        baseFriendship: 0,
        cryLocation: "zamazenta", //Verify
        graphicsLocation: "zamazenta", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Zamazenta,
        abilities: new Ability[3]
        {
            DauntlessShield,
            DauntlessShield,
            DauntlessShield,
        }
    );
    public static SpeciesData Eternatus = new(
        speciesName: "Eternatus",
        type1: Poison,
        type2: Dragon,
        baseHP: 140,
        baseAttack: 85,
        baseDefense: 95,
        baseSpAtk: 145,
        baseSpDef: 95,
        baseSpeed: 130,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 345,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "eternatus", //Verify
        graphicsLocation: "eternatus", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Eternatus,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Pressure,
        }
    );
    public static SpeciesData Kubfu = new(
        speciesName: "Kubfu",
        type1: Fighting,
        type2: Fighting,
        baseHP: 60,
        baseAttack: 90,
        baseDefense: 60,
        baseSpAtk: 53,
        baseSpDef: 50,
        baseSpeed: 72,
        evYield: Attack,
        evolution: Evolution.Kubfu,
        xpClass: Slow,
        xpYield: 77,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "kubfu", //Verify
        graphicsLocation: "kubfu", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Kubfu,
        abilities: new Ability[3]
        {
            InnerFocus,
            InnerFocus,
            InnerFocus,
        }
    );
    public static SpeciesData Urshifu = new(
        speciesName: "Urshifu",
        type1: Fighting,
        type2: Dark,
        baseHP: 100,
        baseAttack: 130,
        baseDefense: 100,
        baseSpAtk: 63,
        baseSpDef: 60,
        baseSpeed: 97,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 275,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "urshifu", //Verify
        graphicsLocation: "urshifu", //Verify
        backSpriteHeight: 4,
        gMaxPath: "urshifu/gmax_single",
        gMaxBackHeight: 4,
        pokedexData: Pokedex.Urshifu,
        abilities: new Ability[3]
        {
            UnseenFist,
            UnseenFist,
            UnseenFist,
        }
    );

    public static SpeciesData Zarude = Zarude(false);

    public static SpeciesData Regieleki = new(
        speciesName: "Regieleki",
        type1: Electric,
        type2: Electric,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 50,
        baseSpAtk: 100,
        baseSpDef: 50,
        baseSpeed: 200,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "regieleki", //Verify
        graphicsLocation: "regieleki", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Regieleki,
        abilities: new Ability[3]
        {
            Transistor,
            Transistor,
            Transistor,
        }
    );
    public static SpeciesData Regidrago = new(
        speciesName: "Regidrago",
        type1: Dragon,
        type2: Dragon,
        baseHP: 200,
        baseAttack: 100,
        baseDefense: 50,
        baseSpAtk: 100,
        baseSpDef: 50,
        baseSpeed: 80,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "regidrago", //Verify
        graphicsLocation: "regidrago", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Regidrago,
        abilities: new Ability[3]
        {
            DragonsMaw,
            DragonsMaw,
            DragonsMaw,
        }
    );
    public static SpeciesData Glastrier = new(
        speciesName: "Glastrier",
        type1: Ice,
        type2: Ice,
        baseHP: 100,
        baseAttack: 145,
        baseDefense: 130,
        baseSpAtk: 65,
        baseSpDef: 110,
        baseSpeed: 30,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "glastrier", //Verify
        graphicsLocation: "glastrier", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Glastrier,
        abilities: new Ability[3]
        {
            ChillingNeigh,
            ChillingNeigh,
            ChillingNeigh,
        }
    );
    public static SpeciesData Spectrier = new(
        speciesName: "Spectrier",
        type1: Ghost,
        type2: Ghost,
        baseHP: 100,
        baseAttack: 65,
        baseDefense: 60,
        baseSpAtk: 145,
        baseSpDef: 80,
        baseSpeed: 130,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "spectrier", //Verify
        graphicsLocation: "spectrier", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Spectrier,
        abilities: new Ability[3]
        {
            GrimNeigh,
            GrimNeigh,
            GrimNeigh,
        }
    );
    public static SpeciesData Calyrex = new(
        speciesName: "Calyrex",
        type1: Psychic,
        type2: Grass,
        baseHP: 100,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 80,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 250,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "calyrex", //Verify
        graphicsLocation: "calyrex", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Calyrex,
        abilities: new Ability[3]
        {
            Unnerve,
            Unnerve,
            Unnerve,
        }
    );
    public static SpeciesData Wyrdeer = new(
        speciesName: "Wyrdeer",
        type1: Normal,
        type2: Psychic,
        baseHP: 103,
        baseAttack: 105,
        baseDefense: 72,
        baseSpAtk: 105,
        baseSpDef: 75,
        baseSpeed: 65,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 184,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "wyrdeer", //Verify
        graphicsLocation: "wyrdeer", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Wyrdeer,
        abilities: new Ability[3]
        {
            Intimidate,
            Frisk,
            SapSipper,
        }
    );
    public static SpeciesData Kleavor = new(
        speciesName: "Kleavor",
        type1: Bug,
        type2: Rock,
        baseHP: 70,
        baseAttack: 135,
        baseDefense: 95,
        baseSpAtk: 45,
        baseSpDef: 70,
        baseSpeed: 85,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 25,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "kleavor", //Verify
        graphicsLocation: "kleavor", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Kleavor,
        abilities: new Ability[3]
        {
            Swarm,
            SheerForce,
            Steadfast,
        }
    );
    public static SpeciesData Ursaluna = new(
        speciesName: "Ursaluna",
        type1: Ground,
        type2: Normal,
        baseHP: 130,
        baseAttack: 140,
        baseDefense: 105,
        baseSpAtk: 45,
        baseSpDef: 80,
        baseSpeed: 50,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 194,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "ursaluna", //Verify
        graphicsLocation: "ursaluna", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Ursaluna,
        abilities: new Ability[3]
        {
            Guts,
            Bulletproof,
            Unnerve,
        }
    );
    public static SpeciesData Basculegion = new(
        speciesName: "Basculegion",
        type1: Water,
        type2: Ghost,
        baseHP: 120,
        baseAttack: 112,
        baseDefense: 65,
        baseSpAtk: 80,
        baseSpDef: 75,
        baseSpeed: 78,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "basculegion", //Verify
        graphicsLocation: "basculegion", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Basculegion,
        abilities: new Ability[3]
        {
            Rattled,
            Adaptability,
            MoldBreaker,
        }
    );



    public static SpeciesData Sneasler = new(
        speciesName: "Sneasler",
        type1: Fighting,
        type2: Poison,
        baseHP: 80,
        baseAttack: 130,
        baseDefense: 60,
        baseSpAtk: 40,
        baseSpDef: 80,
        baseSpeed: 120,
        evYield: Attack + Speed,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 135,
        baseFriendship: 35,
        cryLocation: "sneasler", //Verify
        graphicsLocation: "sneasler", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Sneasler,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            PoisonTouch,
        }
    );
    public static SpeciesData Overqwil = new(
        speciesName: "Overqwil",
        type1: Dark,
        type2: Poison,
        baseHP: 85,
        baseAttack: 115,
        baseDefense: 95,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 135,
        baseFriendship: 70,
        cryLocation: "overqwil", //Verify
        graphicsLocation: "overqwil", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Overqwil,
        abilities: new Ability[3]
        {
            PoisonPoint,
            SwiftSwim,
            Intimidate,
        }
    );
    public static SpeciesData Enamorus = new(
        speciesName: "Enamorus",
        type1: Fairy,
        type2: Flying,
        baseHP: 74,
        baseAttack: 115,
        baseDefense: 70,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 106,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "enamorus", //Verify
        graphicsLocation: "enamorus", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Enamorus,
        abilities: new Ability[3]
        {
            Healer,
            Healer,
            Contrary,
        }
    );
    //Forms

    //Regional forms
    //Alola
    public static readonly SpeciesData RattataAlola = new(
        speciesName: "Rattata",
        type1: Dark,
        type2: Normal,
        baseHP: 30,
        baseAttack: 56,
        baseDefense: 35,
        baseSpAtk: 25,
        baseSpDef: 35,
        baseSpeed: 72,
        evYield: Speed,
        evolution: Evolution.RattataAlola,
        xpClass: MediumFast,
        xpYield: 51,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "rattata", //Verify
        graphicsLocation: "rattata/alolan", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Rattata,
        abilities: new Ability[3]
            {
            Gluttony,
            Hustle,
            ThickFat,
            }
    );
    public static readonly SpeciesData RaticateAlola = new(
        speciesName: "Raticate",
        type1: Dark,
        type2: Normal,
        baseHP: 75,
        baseAttack: 71,
        baseDefense: 70,
        baseSpAtk: 40,
        baseSpDef: 80,
        baseSpeed: 77,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 145,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 127,
        baseFriendship: 70,
        cryLocation: "raticate", //Verify
        graphicsLocation: "raticate/alolan", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Raticate,
        abilities: new Ability[3]
        {
            Gluttony,
            Hustle,
            ThickFat,
        }
    );
    public static readonly SpeciesData RaichuAlola = new(
        speciesName: "Raichu",
        type1: Electric,
        type2: Psychic,
        baseHP: 60,
        baseAttack: 85,
        baseDefense: 50,
        baseSpAtk: 95,
        baseSpDef: 85,
        baseSpeed: 110,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 218,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "raichu", //Verify
        graphicsLocation: "raichu/alolan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Raichu,
        abilities: new Ability[3]
        {
            SurgeSurfer,
            SurgeSurfer,
            SurgeSurfer,
        }
    );
    public static readonly SpeciesData SandshrewAlola = new(
        speciesName: "Sandshrew",
        type1: Ice,
        type2: Steel,
        baseHP: 50,
        baseAttack: 75,
        baseDefense: 90,
        baseSpAtk: 10,
        baseSpDef: 35,
        baseSpeed: 40,
        evYield: Defense,
        evolution: Evolution.SandshrewAlola,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "sandshrew", //Verify
        graphicsLocation: "sandshrew/alolan", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sandshrew,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            SlushRush,
        }
    );
    public static readonly SpeciesData SandslashAlola = new(
        speciesName: "Sandslash",
        type1: Ice,
        type2: Steel,
        baseHP: 75,
        baseAttack: 100,
        baseDefense: 120,
        baseSpAtk: 25,
        baseSpDef: 65,
        baseSpeed: 65,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "sandslash", //Verify
        graphicsLocation: "sandslash/alolan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Sandslash,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            SlushRush,
        }
    );
    public static readonly SpeciesData VulpixAlola = new(
        speciesName: "Vulpix",
        type1: Ice,
        type2: Ice,
        baseHP: 38,
        baseAttack: 41,
        baseDefense: 40,
        baseSpAtk: 50,
        baseSpDef: 65,
        baseSpeed: 65,
        evYield: Speed,
        evolution: Evolution.VulpixAlola,
        xpClass: MediumFast,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "vulpix", //Verify
        graphicsLocation: "vulpix/alolan", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Vulpix,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            SnowWarning,
        }
    );
    public static readonly SpeciesData NinetalesAlola = new(
        speciesName: "Ninetales",
        type1: Ice,
        type2: Fairy,
        baseHP: 73,
        baseAttack: 67,
        baseDefense: 75,
        baseSpAtk: 81,
        baseSpDef: 100,
        baseSpeed: 109,
        evYield: Speed + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 177,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "ninetales", //Verify
        graphicsLocation: "ninetales/alolan", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Ninetales,
        abilities: new Ability[3]
        {
            SnowCloak,
            SnowCloak,
            SnowWarning,
        }
    );
    public static readonly SpeciesData DiglettAlola = new(
        speciesName: "Diglett",
        type1: Ground,
        type2: Steel,
        baseHP: 10,
        baseAttack: 55,
        baseDefense: 30,
        baseSpAtk: 35,
        baseSpDef: 45,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.DiglettAlola,
        xpClass: MediumFast,
        xpYield: 53,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "diglett", //Verify
        graphicsLocation: "diglett/alolan", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Diglett,
        abilities: new Ability[3]
        {
            SandVeil,
            TanglingHair,
            SandForce,
        }
    );
    public static readonly SpeciesData DugtrioAlola = new(
        speciesName: "Dugtrio",
        type1: Ground,
        type2: Steel,
        baseHP: 35,
        baseAttack: 100,
        baseDefense: 60,
        baseSpAtk: 50,
        baseSpDef: 70,
        baseSpeed: 110,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 50,
        baseFriendship: 70,
        cryLocation: "dugtrio", //Verify
        graphicsLocation: "dugtrio/alolan", //Verify
        backSpriteHeight: 17,
        pokedexData: Pokedex.Dugtrio,
        abilities: new Ability[3]
        {
            SandVeil,
            TanglingHair,
            SandForce,
        }
    );
    public static readonly SpeciesData MeowthAlola = new(
        speciesName: "Meowth",
        type1: Dark,
        type2: Dark,
        baseHP: 40,
        baseAttack: 35,
        baseDefense: 35,
        baseSpAtk: 50,
        baseSpDef: 40,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.MeowthAlola,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "meowth", //Verify
        graphicsLocation: "meowth/alolan", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Meowth,
        abilities: new Ability[3]
        {
            Pickup,
            Technician,
            Rattled,
        }
    );
    public static readonly SpeciesData PersianAlola = new(
        speciesName: "Persian",
        type1: Dark,
        type2: Dark,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 60,
        baseSpAtk: 75,
        baseSpDef: 65,
        baseSpeed: 115,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "persian", //Verify
        graphicsLocation: "persian/alolan", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Persian,
        abilities: new Ability[3]
        {
            FurCoat,
            Technician,
            Rattled,
        }
    );
    public static readonly SpeciesData GeodudeAlola = new(
        speciesName: "Geodude",
        type1: Rock,
        type2: Electric,
        baseHP: 40,
        baseAttack: 80,
        baseDefense: 100,
        baseSpAtk: 30,
        baseSpDef: 30,
        baseSpeed: 20,
        evYield: Defense,
        evolution: Evolution.GeodudeAlola,
        xpClass: MediumSlow,
        xpYield: 60,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "geodude", //Verify
        graphicsLocation: "geodude/alolan", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Geodude,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Galvanize,
        }
    );
    public static readonly SpeciesData GravelerAlola = new(
        speciesName: "Graveler",
        type1: Rock,
        type2: Electric,
        baseHP: 55,
        baseAttack: 95,
        baseDefense: 115,
        baseSpAtk: 45,
        baseSpDef: 45,
        baseSpeed: 35,
        evYield: 2 * Defense,
        evolution: Evolution.GravelerAlola,
        xpClass: MediumSlow,
        xpYield: 137,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "graveler", //Verify
        graphicsLocation: "graveler/alolan", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Graveler,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Galvanize,
        }
    );
    public static readonly SpeciesData GolemAlola = new(
        speciesName: "Golem",
        type1: Rock,
        type2: Electric,
        baseHP: 80,
        baseAttack: 120,
        baseDefense: 130,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 45,
        evYield: 3 * Defense,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 223,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "golem", //Verify
        graphicsLocation: "golem/alolan", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Golem,
        abilities: new Ability[3]
        {
            MagnetPull,
            Sturdy,
            Galvanize,
        }
    );
    public static readonly SpeciesData GrimerAlola = new(
        speciesName: "Grimer",
        type1: Poison,
        type2: Dark,
        baseHP: 80,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 25,
        evYield: HP,
        evolution: Evolution.GrimerAlola,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "grimer", //Verify
        graphicsLocation: "grimer/alolan", //Verify
        backSpriteHeight: 14,
        pokedexData: Pokedex.Grimer,
        abilities: new Ability[3]
        {
            PoisonTouch,
            Gluttony,
            PowerOfAlchemy,
        }
    );
    public static readonly SpeciesData MukAlola = new(
        speciesName: "Muk",
        type1: Poison,
        type2: Dark,
        baseHP: 105,
        baseAttack: 105,
        baseDefense: 75,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 50,
        evYield: HP + Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "muk", //Verify
        graphicsLocation: "muk/alolan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Muk,
        abilities: new Ability[3]
        {
            PoisonTouch,
            Gluttony,
            PowerOfAlchemy,
        }
    );
    public static readonly SpeciesData ExeggutorAlola = new(
        speciesName: "Exeggutor",
        type1: Grass,
        type2: Dragon,
        baseHP: 95,
        baseAttack: 105,
        baseDefense: 85,
        baseSpAtk: 125,
        baseSpDef: 75,
        baseSpeed: 45,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "exeggutor", //Verify
        graphicsLocation: "exeggutor/alolan", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Exeggutor,
        abilities: new Ability[3]
        {
            Frisk,
            Frisk,
            Harvest,
        }
    );
    public static readonly SpeciesData MarowakAlola = new(
        speciesName: "Marowak",
        type1: Fire,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 80,
        baseDefense: 110,
        baseSpAtk: 50,
        baseSpDef: 80,
        baseSpeed: 45,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 149,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Monster,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "marowak", //Verify
        graphicsLocation: "marowak/alolan", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Marowak,
        abilities: new Ability[3]
        {
            CursedBody,
            LightningRod,
            RockHead,
        }
    );

    //Galarian forms

    public static SpeciesData MeowthGalar = new(
        speciesName: "Meowth",
        type1: Steel,
        type2: Steel,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 55,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 40,
        evYield: Attack,
        evolution: Evolution.MeowthGalar,
        xpClass: MediumFast,
        xpYield: 58,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "meowth", //Verify
        graphicsLocation: "meowth/galarian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Meowth,
        abilities: new Ability[3]
        {
            Pickup,
            ToughClaws,
            Unnerve,
        }
    );
    public static SpeciesData PonytaGalar = new(
        speciesName: "Ponyta",
        type1: Psychic,
        type2: Psychic,
        baseHP: 50,
        baseAttack: 85,
        baseDefense: 55,
        baseSpAtk: 65,
        baseSpDef: 65,
        baseSpeed: 90,
        evYield: Speed,
        evolution: Evolution.PonytaGalar,
        xpClass: MediumFast,
        xpYield: 82,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "ponyta", //Verify
        graphicsLocation: "ponyta/galarian", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Ponyta,
        abilities: new Ability[3]
        {
            RunAway,
            PastelVeil,
            Anticipation,
        }
    );
    public static SpeciesData RapidashGalar = new(
        speciesName: "Rapidash",
        type1: Psychic,
        type2: Fairy,
        baseHP: 65,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 105,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 175,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "rapidash", //Verify
        graphicsLocation: "rapidash/galarian", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Rapidash,
        abilities: new Ability[3]
        {
            RunAway,
            PastelVeil,
            Anticipation,
        }
    );
    public static SpeciesData SlowpokeGalar = new(
        speciesName: "Slowpoke",
        type1: Psychic,
        type2: Psychic,
        baseHP: 90,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 40,
        baseSpDef: 40,
        baseSpeed: 15,
        evYield: HP,
        evolution: Evolution.SlowpokeGalar,
        xpClass: MediumFast,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "slowpoke_galarian", //Verify
        graphicsLocation: "slowpoke/galarian", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Slowpoke,
        abilities: new Ability[3]
        {
            Gluttony,
            OwnTempo,
            Regenerator,
        }
    );
    public static SpeciesData SlowbroGalar = new(
        speciesName: "Slowbro",
        type1: Poison,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 100,
        baseDefense: 95,
        baseSpAtk: 100,
        baseSpDef: 70,
        baseSpeed: 30,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "slowbro", //Verify
        graphicsLocation: "slowbro/galarian", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Slowbro,
        abilities: new Ability[3]
        {
            QuickDraw,
            OwnTempo,
            Regenerator,
        }
    );
    public static SpeciesData FarfetchdGalar = new(
        speciesName: "Farfetchd",
        type1: Fighting,
        type2: Fighting,
        baseHP: 52,
        baseAttack: 95,
        baseDefense: 55,
        baseSpAtk: 58,
        baseSpDef: 62,
        baseSpeed: 55,
        evYield: Attack,
        evolution: Evolution.FarfetchdGalar,
        xpClass: MediumFast,
        xpYield: 132,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "farfetchd", //Verify
        graphicsLocation: "farfetchd/galarian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Farfetchd,
        abilities: new Ability[3]
        {
            Steadfast,
            Steadfast,
            Scrappy,
        }
    );
    public static SpeciesData WeezingGalar = new(
        speciesName: "Weezing",
        type1: Poison,
        type2: Fairy,
        baseHP: 65,
        baseAttack: 90,
        baseDefense: 120,
        baseSpAtk: 85,
        baseSpDef: 70,
        baseSpeed: 60,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "weezing", //Verify
        graphicsLocation: "weezing/galarian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Weezing,
        abilities: new Ability[3]
        {
            Levitate,
            NeutralizingGas,
            MistySurge,
        }
    );
    public static SpeciesData MrMimeGalar = new(
        speciesName: "Mr. Mime",
        type1: Ice,
        type2: Psychic,
        baseHP: 50,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 90,
        baseSpDef: 90,
        baseSpeed: 100,
        evYield: 2 * Speed,
        evolution: Evolution.MrMimeGalar,
        xpClass: MediumFast,
        xpYield: 161,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mr_mime", //Verify
        graphicsLocation: "mr_mime/galarian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.MrMime,
        abilities: new Ability[3]
        {
            VitalSpirit,
            ScreenCleaner,
            IceBody,
        }
    );
    public static SpeciesData ArticunoGalar = new(
        speciesName: "Articuno",
        type1: Psychic,
        type2: Flying,
        baseHP: 90,
        baseAttack: 85,
        baseDefense: 85,
        baseSpAtk: 125,
        baseSpDef: 100,
        baseSpeed: 95,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "articuno", //Verify
        graphicsLocation: "articuno/galarian", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Articuno,
        abilities: new Ability[3]
        {
            Competitive,
            Competitive,
            Competitive,
        }
    );
    public static SpeciesData ZapdosGalar = new(
        speciesName: "Zapdos",
        type1: Fighting,
        type2: Flying,
        baseHP: 90,
        baseAttack: 125,
        baseDefense: 90,
        baseSpAtk: 85,
        baseSpDef: 90,
        baseSpeed: 100,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "zapdos", //Verify
        graphicsLocation: "zapdos/galarian", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Zapdos,
        abilities: new Ability[3]
        {
            Defiant,
            Defiant,
            Defiant,
        }
    );
    public static SpeciesData MoltresGalar = new(
        speciesName: "Moltres",
        type1: Dark,
        type2: Flying,
        baseHP: 90,
        baseAttack: 85,
        baseDefense: 90,
        baseSpAtk: 100,
        baseSpDef: 125,
        baseSpeed: 90,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 290,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "moltres", //Verify
        graphicsLocation: "moltres/galarian", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Moltres,
        abilities: new Ability[3]
        {
            Berserk,
            Berserk,
            Berserk,
        }
    );
    public static SpeciesData SlowkingGalar = new(
        speciesName: "Slowking",
        type1: Poison,
        type2: Psychic,
        baseHP: 95,
        baseAttack: 65,
        baseDefense: 80,
        baseSpAtk: 110,
        baseSpDef: 110,
        baseSpeed: 30,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Water1,
        eggCycles: 20,
        catchRate: 70,
        baseFriendship: 70,
        cryLocation: "slowking", //Verify
        graphicsLocation: "slowking/galarian", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Slowking,
        abilities: new Ability[3]
        {
            CuriousMedicine,
            OwnTempo,
            Regenerator,
        }
    );
    public static SpeciesData CorsolaGalar = new(
        speciesName: "Corsola",
        type1: Ghost,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 55,
        baseDefense: 100,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 30,
        evYield: SpDef,
        evolution: Evolution.CorsolaGalar,
        xpClass: Fast,
        xpYield: 144,
        learnset: EmptyLearnset, //Not done
        malePercent: 25,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Water3,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "corsola", //Verify
        graphicsLocation: "corsola/galarian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Corsola,
        abilities: new Ability[3]
        {
            WeakArmor,
            WeakArmor,
            CursedBody,
        }
    );
    public static SpeciesData ZigzagoonGalar = new(
        speciesName: "Zigzagoon",
        type1: Dark,
        type2: Normal,
        baseHP: 38,
        baseAttack: 30,
        baseDefense: 41,
        baseSpAtk: 30,
        baseSpDef: 41,
        baseSpeed: 60,
        evYield: Speed,
        evolution: Evolution.ZigzagoonGalar,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "zigzagoon", //Verify
        graphicsLocation: "zigzagoon/galarian", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Zigzagoon,
        abilities: new Ability[3]
        {
            Pickup,
            Gluttony,
            QuickFeet,
        }
    );
    public static SpeciesData LinooneGalar = new(
        speciesName: "Linoone",
        type1: Dark,
        type2: Normal,
        baseHP: 78,
        baseAttack: 70,
        baseDefense: 61,
        baseSpAtk: 50,
        baseSpDef: 61,
        baseSpeed: 100,
        evYield: 2 * Speed,
        evolution: Evolution.LinooneGalar,
        xpClass: MediumFast,
        xpYield: 147,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "linoone", //Verify
        graphicsLocation: "linoone/galarian", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Linoone,
        abilities: new Ability[3]
        {
            Pickup,
            Gluttony,
            QuickFeet,
        }
    );
    public static SpeciesData DarumakaGalar = new(
        speciesName: "Darumaka",
        type1: Ice,
        type2: Ice,
        baseHP: 70,
        baseAttack: 90,
        baseDefense: 45,
        baseSpAtk: 15,
        baseSpDef: 45,
        baseSpeed: 50,
        evYield: Attack,
        evolution: Evolution.DarumakaGalar,
        xpClass: MediumSlow,
        xpYield: 63,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "darumaka", //Verify
        graphicsLocation: "darumaka/galarian", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Darumaka,
        abilities: new Ability[3]
        {
            Hustle,
            Hustle,
            InnerFocus,
        }
    );
    public static SpeciesData DarmanitanGalar = new(
        speciesName: "Darmanitan",
        type1: Ice,
        type2: Ice,
        baseHP: 105,
        baseAttack: 140,
        baseDefense: 55,
        baseSpAtk: 30,
        baseSpDef: 55,
        baseSpeed: 95,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "darmanitan", //Verify
        graphicsLocation: "darmanitan/galarian", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Darmanitan,
        abilities: new Ability[3]
        {
            GorillaTactics,
            GorillaTactics,
            ZenMode,
        }
    );
    public static SpeciesData YamaskGalar = new(
        speciesName: "Yamask",
        type1: Ground,
        type2: Ghost,
        baseHP: 38,
        baseAttack: 55,
        baseDefense: 85,
        baseSpAtk: 30,
        baseSpDef: 65,
        baseSpeed: 30,
        evYield: Defense,
        evolution: Evolution.YamaskGalar,
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "yamask", //Verify
        graphicsLocation: "yamask/galarian", //Verify
        backSpriteHeight: 13,
        pokedexData: Pokedex.Yamask,
        abilities: new Ability[3]
        {
            WanderingSpirit,
            WanderingSpirit,
            WanderingSpirit,
        }
    );
    public static SpeciesData StunfiskGalar = new(
        speciesName: "Stunfisk",
        type1: Ground,
        type2: Steel,
        baseHP: 109,
        baseAttack: 81,
        baseDefense: 99,
        baseSpAtk: 66,
        baseSpDef: 84,
        baseSpeed: 32,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "stunfisk", //Verify
        graphicsLocation: "stunfisk/galarian", //Verify
        backSpriteHeight: 23,
        pokedexData: Pokedex.Stunfisk,
        abilities: new Ability[3]
        {
            Mimicry,
            Mimicry,
            Mimicry,
        }
    );

    //Hisuian forms

    public static SpeciesData GrowlitheHisui = new(
        speciesName: "Growlithe",
        type1: Fire,
        type2: Rock,
        baseHP: 60,
        baseAttack: 75,
        baseDefense: 45,
        baseSpAtk: 65,
        baseSpDef: 50,
        baseSpeed: 55,
        evYield: Attack,
        evolution: Evolution.GrowlitheHisui,
        xpClass: Slow,
        xpYield: 70,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "growlithe", //Verify
        graphicsLocation: "growlithe/hisuian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Growlithe,
        abilities: new Ability[3]
        {
            Intimidate,
            FlashFire,
            Justified,
        }
    );
    public static SpeciesData ArcanineHisui = new(
        speciesName: "Arcanine",
        type1: Fire,
        type2: Rock,
        baseHP: 95,
        baseAttack: 115,
        baseDefense: 80,
        baseSpAtk: 95,
        baseSpDef: 80,
        baseSpeed: 90,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 194,
        learnset: EmptyLearnset, //Not done
        malePercent: 75,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "arcanine", //Verify
        graphicsLocation: "arcanine/hisuian", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Arcanine,
        abilities: new Ability[3]
        {
            Intimidate,
            FlashFire,
            Justified,
        }
    );
    public static SpeciesData VoltorbHisui = new(
        speciesName: "Voltorb",
        type1: Electric,
        type2: Grass,
        baseHP: 40,
        baseAttack: 30,
        baseDefense: 50,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 100,
        evYield: Speed,
        evolution: Evolution.VoltorbHisui,
        xpClass: MediumFast,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "voltorb", //Verify
        graphicsLocation: "voltorb/hisuian", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Voltorb,
        abilities: new Ability[3]
        {
            Soundproof,
            Static,
            Aftermath,
        }
    );
    public static SpeciesData ElectrodeHisui = new(
        speciesName: "Electrode",
        type1: Electric,
        type2: Grass,
        baseHP: 60,
        baseAttack: 50,
        baseDefense: 70,
        baseSpAtk: 80,
        baseSpDef: 80,
        baseSpeed: 150,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 172,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "electrode", //Verify
        graphicsLocation: "electrode/hisuian", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Electrode,
        abilities: new Ability[3]
        {
            Soundproof,
            Static,
            Aftermath,
        }
    );
    public static SpeciesData TyphlosionHisui = new(
        speciesName: "Typhlosion",
        type1: Fire,
        type2: Ghost,
        baseHP: 73,
        baseAttack: 84,
        baseDefense: 78,
        baseSpAtk: 119,
        baseSpDef: 85,
        baseSpeed: 95,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 240,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "typhlosion", //Verify
        graphicsLocation: "typhlosion/hisuian", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Typhlosion,
        abilities: new Ability[3]
        {
            Blaze,
            Blaze,
            FlashFire,
        }
    );
    public static SpeciesData QwilfishHisui = new(
        speciesName: "Qwilfish",
        type1: Dark,
        type2: Poison,
        baseHP: 65,
        baseAttack: 95,
        baseDefense: 85,
        baseSpAtk: 55,
        baseSpDef: 55,
        baseSpeed: 85,
        evYield: Attack,
        evolution: Evolution.QwilfishHisui,
        xpClass: MediumFast,
        xpYield: 88,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "qwilfish", //Verify
        graphicsLocation: "qwilfish/hisuian", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Qwilfish,
        abilities: new Ability[3]
        {
            PoisonPoint,
            SwiftSwim,
            Intimidate,
        }
    );
    public static SpeciesData SneaselHisui = new(
        speciesName: "Sneasel",
        type1: Poison,
        type2: Fighting,
        baseHP: 55,
        baseAttack: 95,
        baseDefense: 55,
        baseSpAtk: 35,
        baseSpDef: 75,
        baseSpeed: 115,
        evYield: Speed,
        evolution: Evolution.SneaselHisui,
        xpClass: MediumSlow,
        xpYield: 86,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 35,
        cryLocation: "sneasel", //Verify
        graphicsLocation: "sneasel/hisuian", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Sneasel,
        abilities: new Ability[3]
        {
            InnerFocus,
            KeenEye,
            PoisonTouch,
        }
    );
    public static SpeciesData SamurottHisui = new(
        speciesName: "Samurott",
        type1: Water,
        type2: Dark,
        baseHP: 90,
        baseAttack: 108,
        baseDefense: 80,
        baseSpAtk: 100,
        baseSpDef: 65,
        baseSpeed: 85,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 238,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "samurott", //Verify
        graphicsLocation: "samurott/hisuian", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Samurott,
        abilities: new Ability[3]
        {
            Torrent,
            Torrent,
            ShellArmor,
        }
    );
    public static SpeciesData LilligantHisui = new(
        speciesName: "Lilligant",
        type1: Grass,
        type2: Fighting,
        baseHP: 70,
        baseAttack: 105,
        baseDefense: 75,
        baseSpAtk: 50,
        baseSpDef: 75,
        baseSpeed: 105,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 168,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Grass,
        eggGroup2: EggGroup.Grass,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "lilligant", //Verify
        graphicsLocation: "lilligant/hisuian", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Lilligant,
        abilities: new Ability[3]
        {
            Chlorophyll,
            Hustle,
            LeafGuard,
        }
    );
    public static SpeciesData ZoruaHisui = new(
        speciesName: "Zorua",
        type1: Normal,
        type2: Ghost,
        baseHP: 35,
        baseAttack: 60,
        baseDefense: 40,
        baseSpAtk: 85,
        baseSpDef: 40,
        baseSpeed: 70,
        evYield: SpAtk,
        evolution: Evolution.ZoruaHisui,
        xpClass: MediumSlow,
        xpYield: 66,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 25,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "zorua", //Verify
        graphicsLocation: "zorua/hisuian", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Zorua,
        abilities: new Ability[3]
        {
            Illusion,
            Illusion,
            Illusion,
        }
    );
    public static SpeciesData ZoroarkHisui = new(
        speciesName: "Zoroark",
        type1: Normal,
        type2: Ghost,
        baseHP: 55,
        baseAttack: 100,
        baseDefense: 60,
        baseSpAtk: 125,
        baseSpDef: 60,
        baseSpeed: 110,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "zoroark", //Verify
        graphicsLocation: "zoroark/hisuian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Zoroark,
        abilities: new Ability[3]
        {
            Illusion,
            Illusion,
            Illusion,
        }
    );
    public static SpeciesData BraviaryHisui = new(
        speciesName: "Braviary",
        type1: Psychic,
        type2: Flying,
        baseHP: 110,
        baseAttack: 83,
        baseDefense: 70,
        baseSpAtk: 112,
        baseSpDef: 70,
        baseSpeed: 65,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 179,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "braviary", //Verify
        graphicsLocation: "braviary/hisuian", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Braviary,
        abilities: new Ability[3]
        {
            KeenEye,
            SheerForce,
            Defiant,
        }
    );
    public static SpeciesData SliggooHisui = new(
        speciesName: "Sliggoo",
        type1: Dragon,
        type2: Steel,
        baseHP: 58,
        baseAttack: 75,
        baseDefense: 83,
        baseSpAtk: 83,
        baseSpDef: 113,
        baseSpeed: 40,
        evYield: 2 * SpDef,
        evolution: Evolution.SliggooHisui,
        xpClass: Slow,
        xpYield: 158,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "sliggoo", //Verify
        graphicsLocation: "sliggoo/hisuian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Sliggoo,
        abilities: new Ability[3]
        {
            SapSipper,
            Overcoat,
            Gooey,
        }
    );
    public static SpeciesData GoodraHisui = new(
        speciesName: "Goodra",
        type1: Dragon,
        type2: Steel,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 100,
        baseSpAtk: 110,
        baseSpDef: 150,
        baseSpeed: 60,
        evYield: 3 * SpDef,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Dragon,
        eggGroup2: EggGroup.Dragon,
        eggCycles: 40,
        catchRate: 45,
        baseFriendship: 35,
        cryLocation: "goodra", //Verify
        graphicsLocation: "goodra/hisuian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Goodra,
        abilities: new Ability[3]
        {
            SapSipper,
            Overcoat,
            Gooey,
        }
    );
    public static SpeciesData AvaluggHisui = new(
        speciesName: "Avalugg",
        type1: Ice,
        type2: Rock,
        baseHP: 95,
        baseAttack: 127,
        baseDefense: 184,
        baseSpAtk: 34,
        baseSpDef: 36,
        baseSpeed: 38,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 180,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Monster,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 55,
        baseFriendship: 70,
        cryLocation: "avalugg", //Verify
        graphicsLocation: "avalugg/hisuian", //Verify
        backSpriteHeight: 16,
        pokedexData: Pokedex.Avalugg,
        abilities: new Ability[3]
        {
            StrongJaw,
            IceBody,
            Sturdy,
        }
    );
    public static SpeciesData DecidueyeHisui = new(
        speciesName: "Decidueye",
        type1: Grass,
        type2: Fighting,
        baseHP: 88,
        baseAttack: 112,
        baseDefense: 80,
        baseSpAtk: 95,
        baseSpDef: 95,
        baseSpeed: 60,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 239,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "decidueye", //Verify
        graphicsLocation: "decidueye/hisuian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Decidueye,
        abilities: new Ability[3]
        {
            Overgrow,
            Overgrow,
            LongReach,
        }
    );

    //Megas

    public static readonly SpeciesData VenusaurMega = Mega(
            baseSpecies: Venusaur,
            baseAttack: 100,
            baseDefense: 123,
            baseSpAtk: 122,
            baseSpDef: 120,
            baseSpeed: 80,
            cry: "mega_venusaur",
            graphics: "venusaur/mega",
            backSpriteHeight: 8,
            pokedexData: Pokedex.Venusaur, //Not done
            ability: ThickFat
        );

    public static readonly SpeciesData CharizardMegaX = Mega(
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

    public static readonly SpeciesData CharizardMegaY = Mega(
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

    public static readonly SpeciesData BlastoiseMega = Mega(
        baseSpecies: Blastoise,
        baseAttack: 103,
        baseDefense: 120,
        baseSpAtk: 135,
        baseSpDef: 115,
        baseSpeed: 78,
        cry: "mega_blastoise",
        graphics: "blastoise/mega",
        backSpriteHeight: 0,
        pokedexData: Pokedex.Blastoise, //Not done
        ability: MegaLauncher
    );

    public static readonly SpeciesData BeedrillMega = Mega(
        baseSpecies: Beedrill,
        baseAttack: 150,
        baseDefense: 40,
        baseSpAtk: 15,
        baseSpDef: 80,
        baseSpeed: 145,
        backSpriteHeight: 5,
        pokedexData: Pokedex.Beedrill,
        ability: Adaptability
    );

    public static readonly SpeciesData PidgeotMega = Mega(
        baseSpecies: Pidgeot,
        baseAttack: 80,
        baseDefense: 80,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 121,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Pidgeot,
        ability: NoGuard
    );

    public static readonly SpeciesData AlakazamMega = Mega(
        baseSpecies: Alakazam,
        baseAttack: 50,
        baseDefense: 65,
        baseSpAtk: 175,
        baseSpDef: 105,
        baseSpeed: 150,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Alakazam,
        ability: Trace
    );

    public static readonly SpeciesData SlowbroMega = Mega(
        baseSpecies: Slowbro,
        baseAttack: 75,
        baseDefense: 180,
        baseSpAtk: 130,
        baseSpDef: 80,
        baseSpeed: 30,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Slowbro,
        ability: ShellArmor
    );

    public static readonly SpeciesData GengarMega = Mega(
        baseSpecies: Gengar,
        baseAttack: 65,
        baseDefense: 80,
        baseSpAtk: 170,
        baseSpDef: 95,
        baseSpeed: 130,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Gengar,
        ability: ShadowTag
    );

    public static readonly SpeciesData KangaskhanMega = Mega(
        baseSpecies: Kangaskhan,
        baseAttack: 125,
        baseDefense: 100,
        baseSpAtk: 60,
        baseSpDef: 100,
        baseSpeed: 100,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Kangaskhan,
        ability: ParentalBond
    );

    public static readonly SpeciesData PinsirMega = Mega(
        baseSpecies: Pinsir,
        type2: Flying,
        baseAttack: 155,
        baseDefense: 120,
        baseSpAtk: 65,
        baseSpDef: 90,
        baseSpeed: 105,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Pinsir,
        ability: Aerilate
    );

    public static readonly SpeciesData GyaradosMega = Mega(
        baseSpecies: Gyarados,
        type2: Dark,
        baseAttack: 155,
        baseDefense: 109,
        baseSpAtk: 70,
        baseSpDef: 130,
        baseSpeed: 81,
        backSpriteHeight: 2,
        pokedexData: Pokedex.Gyarados,
        ability: MoldBreaker
    );

    public static readonly SpeciesData AerodactylMega = Mega(
        baseSpecies: Aerodactyl,
        baseAttack: 135,
        baseDefense: 85,
        baseSpAtk: 70,
        baseSpDef: 95,
        baseSpeed: 150,
        backSpriteHeight: 8,
        pokedexData: Pokedex.Aerodactyl,
        ability: ToughClaws
    );

    public static readonly SpeciesData MewtwoMegaX = Mega(
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
        pokedexData: Pokedex.Mewtwo,
        ability: Steadfast
     );

    public static readonly SpeciesData MewtwoMegaY = Mega(
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
        pokedexData: Pokedex.Mewtwo,
        ability: Insomnia
    );

    public static readonly SpeciesData AmpharosMega = Mega(
        baseSpecies: Ampharos,
        type2: Dragon,
        baseAttack: 95,
        baseDefense: 105,
        baseSpAtk: 165,
        baseSpDef: 110,
        baseSpeed: 45,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Ampharos,
        ability: MoldBreaker
    );

    public static readonly SpeciesData SteelixMega = Mega(
        baseSpecies: Steelix,
        baseAttack: 125,
        baseDefense: 230,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 30,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Steelix,
        ability: SandForce
    );

    public static readonly SpeciesData ScizorMega = Mega(
        baseSpecies: Scizor,
        baseAttack: 150,
        baseDefense: 140,
        baseSpAtk: 65,
        baseSpDef: 100,
        baseSpeed: 75,
        backSpriteHeight: 4,
        pokedexData: Pokedex.Scizor,
        ability: Technician
    );

    public static readonly SpeciesData HeracrossMega = Mega(
        baseSpecies: Heracross,
        baseAttack: 185,
        baseDefense: 115,
        baseSpAtk: 40,
        baseSpDef: 105,
        baseSpeed: 75,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Heracross,
        ability: SkillLink
    );

    public static readonly SpeciesData HoundoomMega = Mega(
        baseSpecies: Houndoom,
        baseAttack: 90,
        baseDefense: 90,
        baseSpAtk: 140,
        baseSpDef: 90,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Houndoom,
        ability: SolarPower
    );

    public static readonly SpeciesData TyranitarMega = Mega(
        baseSpecies: Tyranitar,
        baseAttack: 164,
        baseDefense: 150,
        baseSpAtk: 95,
        baseSpDef: 120,
        baseSpeed: 71,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Tyranitar,
        ability: SandStream
    );

    public static readonly SpeciesData SceptileMega = Mega(
        baseSpecies: Sceptile,
        type2: Dragon,
        baseAttack: 110,
        baseDefense: 75,
        baseSpAtk: 145,
        baseSpDef: 85,
        baseSpeed: 145,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Sceptile,
        ability: LightningRod
    );

    public static readonly SpeciesData BlazikenMega = Mega(
        baseSpecies: Blaziken,
        baseAttack: 160,
        baseDefense: 80,
        baseSpAtk: 130,
        baseSpDef: 80,
        baseSpeed: 100,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Blaziken,
        ability: SpeedBoost
    );

    public static readonly SpeciesData SwampertMega = Mega(
        baseSpecies: Swampert,
        baseAttack: 150,
        baseDefense: 110,
        baseSpAtk: 95,
        baseSpDef: 110,
        baseSpeed: 70,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Swampert,
        ability: SwiftSwim
    );

    public static readonly SpeciesData GardevoirMega = Mega(
        baseSpecies: Gardevoir,
        baseAttack: 85,
        baseDefense: 65,
        baseSpAtk: 165,
        baseSpDef: 135,
        baseSpeed: 100,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Gardevoir,
        ability: Pixilate
    );

    public static readonly SpeciesData SableyeMega = Mega(
        baseSpecies: Sableye,
        baseAttack: 85,
        baseDefense: 125,
        baseSpAtk: 85,
        baseSpDef: 115,
        baseSpeed: 20,
        backSpriteHeight: 13,
        pokedexData: Pokedex.Sableye,
        ability: MagicBounce
    );

    public static readonly SpeciesData MawileMega = Mega(
        baseSpecies: Mawile,
        baseAttack: 105,
        baseDefense: 125,
        baseSpAtk: 55,
        baseSpDef: 95,
        baseSpeed: 50,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Mawile,
        ability: HugePower
    );

    public static readonly SpeciesData AggronMega = Mega(
        baseSpecies: Aggron,
        type2: Steel,
        baseAttack: 140,
        baseDefense: 230,
        baseSpAtk: 60,
        baseSpDef: 80,
        baseSpeed: 50,
        backSpriteHeight: 7,
        pokedexData: Pokedex.Aggron,
        ability: Filter
    );

    public static readonly SpeciesData MedichamMega = Mega(
        baseSpecies: Medicham,
        baseAttack: 100,
        baseDefense: 85,
        baseSpAtk: 80,
        baseSpDef: 85,
        baseSpeed: 100,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Medicham,
        ability: PurePower
    );

    public static readonly SpeciesData ManectricMega = Mega(
        baseSpecies: Manectric,
        baseAttack: 75,
        baseDefense: 80,
        baseSpAtk: 135,
        baseSpDef: 80,
        baseSpeed: 135,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Manectric,
        ability: Intimidate
    );

    public static readonly SpeciesData SharpedoMega = Mega(
        baseSpecies: Sharpedo,
        baseAttack: 140,
        baseDefense: 70,
        baseSpAtk: 110,
        baseSpDef: 65,
        baseSpeed: 105,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Sharpedo,
        ability: StrongJaw
    );

    public static readonly SpeciesData CameruptMega = Mega(
        baseSpecies: Camerupt,
        baseAttack: 120,
        baseDefense: 100,
        baseSpAtk: 145,
        baseSpDef: 105,
        baseSpeed: 20,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Camerupt,
        ability: SheerForce
    );

    public static readonly SpeciesData AltariaMega = Mega(
        baseSpecies: Altaria,
        type2: Fairy,
        baseAttack: 110,
        baseDefense: 110,
        baseSpAtk: 110,
        baseSpDef: 105,
        baseSpeed: 80,
        backSpriteHeight: 10,
        pokedexData: Pokedex.Altaria,
        ability: Pixilate
    );

    public static readonly SpeciesData BanetteMega = Mega(
        baseSpecies: Banette,
        baseAttack: 165,
        baseDefense: 75,
        baseSpAtk: 93,
        baseSpDef: 83,
        baseSpeed: 75,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Banette,
        ability: Prankster
    );

    public static readonly SpeciesData AbsolMega = Mega(
        baseSpecies: Absol,
        baseAttack: 150,
        baseDefense: 60,
        baseSpAtk: 115,
        baseSpDef: 60,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Absol,
        ability: MagicBounce
    );

    public static readonly SpeciesData GlalieMega = Mega(
        baseSpecies: Glalie,
        baseAttack: 120,
        baseDefense: 80,
        baseSpAtk: 120,
        baseSpDef: 80,
        baseSpeed: 100,
        backSpriteHeight: 10,
        pokedexData: Pokedex.Glalie,
        ability: Refrigerate
    );

    public static readonly SpeciesData SalamenceMega = Mega(
        baseSpecies: Salamence,
        baseAttack: 145,
        baseDefense: 130,
        baseSpAtk: 120,
        baseSpDef: 90,
        baseSpeed: 120,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Salamence,
        ability: Aerilate
    );

    public static readonly SpeciesData MetagrossMega = Mega(
        baseSpecies: Metagross,
        baseAttack: 145,
        baseDefense: 150,
        baseSpAtk: 105,
        baseSpDef: 110,
        baseSpeed: 110,
        backSpriteHeight: 6,
        pokedexData: Pokedex.Metagross,
        ability: ToughClaws
    );

    public static readonly SpeciesData LatiasMega = Mega(
        baseSpecies: Latias,
        baseAttack: 100,
        baseDefense: 120,
        baseSpAtk: 140,
        baseSpDef: 150,
        baseSpeed: 110,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Latias,
        ability: Levitate
    );

    public static readonly SpeciesData LatiosMega = Mega(
        baseSpecies: Latios,
        baseAttack: 130,
        baseDefense: 100,
        baseSpAtk: 160,
        baseSpDef: 120,
        baseSpeed: 110,
        backSpriteHeight: 1,
        pokedexData: Pokedex.Latios,
        ability: Levitate
    );

    public static readonly SpeciesData RayquazaMega = Mega(
        baseSpecies: Rayquaza,
        baseAttack: 180,
        baseDefense: 100,
        baseSpAtk: 180,
        baseSpDef: 100,
        baseSpeed: 115,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Rayquaza,
        ability: DeltaStream
    );

    public static readonly SpeciesData LopunnyMega = Mega(
        baseSpecies: Lopunny,
        type2: Fighting,
        baseAttack: 136,
        baseDefense: 94,
        baseSpAtk: 54,
        baseSpDef: 96,
        baseSpeed: 135,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Lopunny,
        ability: Scrappy
    );

    public static readonly SpeciesData GarchompMega = Mega(
        baseSpecies: Garchomp,
        baseAttack: 170,
        baseDefense: 115,
        baseSpAtk: 120,
        baseSpDef: 95,
        baseSpeed: 92,
        backSpriteHeight: 4,
        pokedexData: Pokedex.Garchomp,
        ability: SandForce
    );

    public static readonly SpeciesData LucarioMega = Mega(
        baseSpecies: Lucario,
        baseAttack: 145,
        baseDefense: 88,
        baseSpAtk: 140,
        baseSpDef: 70,
        baseSpeed: 112,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Lucario,
        ability: Adaptability
    );

    public static readonly SpeciesData AbomasnowMega = Mega(
        baseSpecies: Abomasnow,
        baseAttack: 132,
        baseDefense: 105,
        baseSpAtk: 132,
        baseSpDef: 105,
        baseSpeed: 30,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Abomasnow,
        ability: SnowWarning
    );

    public static readonly SpeciesData GalladeMega = Mega(
        baseSpecies: Gallade,
        baseAttack: 165,
        baseDefense: 95,
        baseSpAtk: 65,
        baseSpDef: 115,
        baseSpeed: 110,
        backSpriteHeight: 3,
        pokedexData: Pokedex.Gallade,
        ability: InnerFocus
    );

    public static readonly SpeciesData AudinoMega = Mega(
        baseSpecies: Audino,
        type2: Fairy,
        baseAttack: 60,
        baseDefense: 126,
        baseSpAtk: 80,
        baseSpDef: 126,
        baseSpeed: 50,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Audino,
        ability: Healer
    );

    public static readonly SpeciesData DiancieMega = Mega(
        baseSpecies: Diancie,
        baseAttack: 160,
        baseDefense: 110,
        baseSpAtk: 160,
        baseSpDef: 110,
        baseSpeed: 110,
        backSpriteHeight: 5,
        pokedexData: Pokedex.Diancie,
        ability: MagicBounce
    );

    //Other forms

    public static readonly SpeciesData PikachuCosplay = PikachuCosplay("cosplay");
    public static readonly SpeciesData PikachuRockStar = PikachuCosplay("rock_star");
    public static readonly SpeciesData PikachuBelle = PikachuCosplay("belle");
    public static readonly SpeciesData PikachuPopStar = PikachuCosplay("pop_star");
    public static readonly SpeciesData PikachuPhD = PikachuCosplay("ph_d");
    public static readonly SpeciesData PikachuLibre = PikachuCosplay("libre");
    public static readonly SpeciesData PikachuOriginal = PikachuCap("original");
    public static readonly SpeciesData PikachuHoenn = PikachuCap("hoenn");
    public static readonly SpeciesData PikachuSinnoh = PikachuCap("sinnoh");
    public static readonly SpeciesData PikachuUnova = PikachuCap("unova");
    public static readonly SpeciesData PikachuKalos = PikachuCap("kalos");
    public static readonly SpeciesData PikachuAlolaCap = PikachuCap("alola");
    public static readonly SpeciesData PikachuPartnerCap = PikachuCap("partner");
    public static readonly SpeciesData PikachuWorld = PikachuCap("world");

    public static readonly SpeciesData PikachuPartner = new(
        speciesName: "Pikachu",
        type1: Electric,
        type2: Electric,
        baseHP: 45,
        baseAttack: 80,
        baseDefense: 50,
        baseSpAtk: 75,
        baseSpDef: 60,
        baseSpeed: 120,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 112,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Undiscovered, //Just to be safe
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pikachu", //Verify
        graphicsLocation: "pikachu", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Pikachu,
        abilities: new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        }
    );

    public static readonly SpeciesData EeveePartner = new(
        speciesName: "Eevee",
        type1: Normal,
        type2: Normal,
        baseHP: 65,
        baseAttack: 75,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 85,
        baseSpeed: 75,
        evYield: SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 65,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 35,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "eevee", //Verify
        graphicsLocation: "eevee", //Verify
        backSpriteHeight: 10,
        pokedexData: Pokedex.Eevee,
        abilities: new Ability[3]
        {
            RunAway,
            Adaptability,
            Anticipation,
        }
    );

    public static readonly SpeciesData PichuSpikyEared = Pichu(true);

    public static readonly SpeciesData Unown_B
       = Unown("unown/b", 9);
    public static readonly SpeciesData Unown_C
       = Unown("unown/c", 6);
    public static readonly SpeciesData Unown_D
       = Unown("unown/d", 8);
    public static readonly SpeciesData Unown_E
       = Unown("unown/e", 10);
    public static readonly SpeciesData Unown_F
       = Unown("unown/f", 10);
    public static readonly SpeciesData Unown_G
       = Unown("unown/g", 5);
    public static readonly SpeciesData Unown_H
       = Unown("unown/h", 8);
    public static readonly SpeciesData Unown_I
       = Unown("unown/i", 7);
    public static readonly SpeciesData Unown_J
       = Unown("unown/j", 9);
    public static readonly SpeciesData Unown_K
       = Unown("unown/k", 7);
    public static readonly SpeciesData Unown_L
       = Unown("unown/l", 10);
    public static readonly SpeciesData Unown_M
       = Unown("unown/m", 13);
    public static readonly SpeciesData Unown_N
       = Unown("unown/n", 13);
    public static readonly SpeciesData Unown_O
       = Unown("unown/o", 8);
    public static readonly SpeciesData Unown_P
       = Unown("unown/p", 10);
    public static readonly SpeciesData Unown_Q
       = Unown("unown/q", 15);
    public static readonly SpeciesData Unown_R
       = Unown("unown/r", 12);
    public static readonly SpeciesData Unown_S
       = Unown("unown/s", 4);
    public static readonly SpeciesData Unown_T
       = Unown("unown/t", 13);
    public static readonly SpeciesData Unown_U
       = Unown("unown/u", 13);
    public static readonly SpeciesData Unown_V
       = Unown("unown/v", 11);
    public static readonly SpeciesData Unown_W
       = Unown("unown/w", 13);
    public static readonly SpeciesData Unown_X
       = Unown("unown/x", 15);
    public static readonly SpeciesData Unown_Y
       = Unown("unown/y", 10);
    public static readonly SpeciesData Unown_Z
       = Unown("unown/z", 10);
    public static readonly SpeciesData UnownQuestion
       = Unown("unown/question_mark", 6);
    public static readonly SpeciesData UnownExclamation
       = Unown("unown/exclamation_mark", 6);

    //Castform forms

    public static readonly SpeciesData CastformSunny =
        Castform(Fire, "castform/sunny", 0);
    public static readonly SpeciesData CastformRainy =
        Castform(Water, "castform/rainy", 0);
    public static readonly SpeciesData CastformSnowy =
        Castform(Ice, "castform/snowy", 0);

    //Primals

    public static readonly SpeciesData KyogrePrimal = new(
        speciesName: "Kyogre",
        type1: Water,
        type2: Water,
        baseHP: 100,
        baseAttack: 150,
        baseDefense: 90,
        baseSpAtk: 180,
        baseSpDef: 160,
        baseSpeed: 90,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 302,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "primal_kyogre", //Verify
        graphicsLocation: "kyogre/primal", //Verify
        backSpriteHeight: 18,
        pokedexData: Pokedex.Kyogre,
        abilities: new Ability[3]
        {
            PrimoridialSea,
            PrimoridialSea,
            PrimoridialSea
        }
    );

    public static readonly SpeciesData GroudonPrimal = new(
        speciesName: "Groudon",
        type1: Ground,
        type2: Fire,
        baseHP: 100,
        baseAttack: 180,
        baseDefense: 160,
        baseSpAtk: 150,
        baseSpDef: 90,
        baseSpeed: 90,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 302,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "primal_groudon", //Verify
        graphicsLocation: "groudon/primal", //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Groudon,
        abilities: new Ability[3]
            {
                DesolateLand,
                DesolateLand,
                DesolateLand
            }
    );

    //Deoxys forms

    public static readonly SpeciesData DeoxysAttack =
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

    public static readonly SpeciesData DeoxysDefense =
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

    public static readonly SpeciesData DeoxysSpeed =
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

    public static readonly SpeciesData BurmySand =
        Burmy("burmy/sandy_cloak", 7, Evolution.BurmySand);
    public static readonly SpeciesData BurmyTrash =
        Burmy("burmy/trash_cloak", 0, Evolution.BurmyTrash);
    public static readonly SpeciesData WormadamSand = Wormadam(
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
    public static readonly SpeciesData WormadamTrash = Wormadam(
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

    public static readonly SpeciesData CherrimSunshine = Cherrim("cherrim/sunshine", 6);

    public static readonly SpeciesData ShellosEast = Shellos("shellos/east_sea", 8, Evolution.ShellosEast);
    public static readonly SpeciesData GastrodonEast = Gastrodon("gastrodon/east_sea", 3);

    public static readonly SpeciesData RotomHeat = RotomForm(Fire, "rotom/heat", 12);
    public static readonly SpeciesData RotomWash = RotomForm(Water, "rotom/wash", 11);
    public static readonly SpeciesData RotomFrost = RotomForm(Ice, "rotom/frost", 7);
    public static readonly SpeciesData RotomFan = RotomForm(Flying, "rotom/fan", 8);
    public static readonly SpeciesData RotomMow = RotomForm(Grass, "rotom/mow", 10);

    public static readonly SpeciesData ArceusFire = Arceus(Fire, "arceus/fire");
    public static readonly SpeciesData ArceusWater = Arceus(Water, "arceus/water");
    public static readonly SpeciesData ArceusGrass = Arceus(Grass, "arceus/grass");
    public static readonly SpeciesData ArceusElectric = Arceus(Electric, "arceus/electric");
    public static readonly SpeciesData ArceusIce = Arceus(Ice, "arceus/ice");
    public static readonly SpeciesData ArceusGround = Arceus(Ground, "arceus/ground");
    public static readonly SpeciesData ArceusFighting = Arceus(Fighting, "arceus/fighting");
    public static readonly SpeciesData ArceusFlying = Arceus(Flying, "arceus/flying");
    public static readonly SpeciesData ArceusRock = Arceus(Rock, "arceus/rock");
    public static readonly SpeciesData ArceusPoison = Arceus(Poison, "arceus/poison");
    public static readonly SpeciesData ArceusBug = Arceus(Bug, "arceus/bug");
    public static readonly SpeciesData ArceusPsychic = Arceus(Psychic, "arceus/psychic");
    public static readonly SpeciesData ArceusGhost = Arceus(Ghost, "arceus/ghost");
    public static readonly SpeciesData ArceusDragon = Arceus(Dragon, "arceus/dragon");
    public static readonly SpeciesData ArceusDark = Arceus(Dark, "arceus/dark");
    public static readonly SpeciesData ArceusSteel = Arceus(Steel, "arceus/steel");
    public static readonly SpeciesData ArceusFairy = Arceus(Fairy, "arceus/fairy");

    public static readonly SpeciesData DialgaOrigin = Dialga(
        baseAttack: 100,
        baseSpDef: 120,
        graphics: "dialga/origin",
        backSpriteHeight: 0
    );

    public static readonly SpeciesData PalkiaOrigin = Palkia(
        baseAttack: 100,
        baseSpeed: 120,
        graphics: "palkia/origin",
        backSpriteHeight: 3
    );

    public static readonly SpeciesData GiratinaOrigin = Giratina(
        baseAttack: 120,
        baseSpAtk: 120,
        baseDefense: 100,
        baseSpDef: 100,
        graphics: "giratina/origin",
        backSpriteHeight: 4
    );

    public static readonly SpeciesData ShayminSky = Shaymin(
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

    public static readonly SpeciesData BasculinBlue = Basculin(
    "basculin/blue_striped", RockHead, Evolution.None);

    public static readonly SpeciesData BasculinWhite = Basculin(
        "basculin/white_striped", Rattled, Evolution.BasculinWhite);

    public static readonly SpeciesData DarmanitanZen = new(
        speciesName: "Darmanitan",
        type1: Fire,
        type2: Psychic,
        baseHP: 105,
        baseAttack: 30,
        baseDefense: 105,
        baseSpAtk: 140,
        baseSpDef: 105,
        baseSpeed: 55,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "darmanitan", //Verify
        graphicsLocation: "darmanitan/zen_mode", //Verify
        backSpriteHeight: 11,
        pokedexData: Pokedex.Darmanitan,
        abilities: new Ability[3]
        {
            SheerForce,
            SheerForce,
            ZenMode,
        }
    );

    public static SpeciesData DarmanitanGalarZen = new(
        speciesName: "Darmanitan",
        type1: Ice,
        type2: Fire,
        baseHP: 105,
        baseAttack: 160,
        baseDefense: 55,
        baseSpAtk: 30,
        baseSpDef: 55,
        baseSpeed: 135,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 189,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "darmanitan", //Verify
        graphicsLocation: "darmanitan/zen_mode/galarian", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Darmanitan,
        abilities: new Ability[3]
        {
            GorillaTactics,
            GorillaTactics,
            ZenMode,
        }
    );

    public static readonly SpeciesData DeerlingSummer = Deerling("deerling/summer", Evolution.DeerlingSummer);
    public static readonly SpeciesData DeerlingAutumn = Deerling("deerling/autumn", Evolution.DeerlingAutumn);
    public static readonly SpeciesData DeerlingWinter = Deerling("deerling/winter", Evolution.DeerlingWinter);

    public static readonly SpeciesData SawsbuckSummer = Sawsbuck("sawsbuck/summer");
    public static readonly SpeciesData SawsbuckAutumn = Sawsbuck("sawsbuck/autumn");
    public static readonly SpeciesData SawsbuckWinter = Sawsbuck("sawsbuck/winter");

    public static readonly SpeciesData TornadusT = new(
        speciesName: "Tornadus",
        type1: Flying,
        type2: Flying,
        baseHP: 79,
        baseAttack: 100,
        baseDefense: 80,
        baseSpAtk: 110,
        baseSpDef: 90,
        baseSpeed: 121,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "tornadus_therian", //Verify
        graphicsLocation: "tornadus/therian", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Tornadus,
        abilities: new Ability[3]
        {
            Regenerator,
            Regenerator,
            Regenerator,
        }
    );
    public static readonly SpeciesData ThundurusT = new(
        speciesName: "Thundurus",
        type1: Electric,
        type2: Flying,
        baseHP: 79,
        baseAttack: 105,
        baseDefense: 70,
        baseSpAtk: 145,
        baseSpDef: 80,
        baseSpeed: 101,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "thundurus_therian", //Verify
        graphicsLocation: "thundurus/therian", //Verify
        backSpriteHeight: 5,
        pokedexData: Pokedex.Thundurus,
        abilities: new Ability[3]
        {
            VoltAbsorb,
            VoltAbsorb,
            VoltAbsorb,
        }
    );

    public static readonly SpeciesData LandorusT = new(
        speciesName: "Landorus",
        type1: Ground,
        type2: Flying,
        baseHP: 89,
        baseAttack: 145,
        baseDefense: 90,
        baseSpAtk: 105,
        baseSpDef: 80,
        baseSpeed: 91,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "landorus_therian", //Verify
        graphicsLocation: "landorus/therian", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Landorus,
        abilities: new Ability[3]
        {
            Intimidate,
            Intimidate,
            Intimidate,
        }
    );

    public static readonly SpeciesData KyuremWhite = new(
        speciesName: "Kyurem",
        type1: Dragon,
        type2: Ice,
        baseHP: 125,
        baseAttack: 120,
        baseDefense: 90,
        baseSpAtk: 170,
        baseSpDef: 100,
        baseSpeed: 95,
        evYield: SpAtk * 3,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 315,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "kyurem_white", //Verify
        graphicsLocation: "kyurem/white", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Kyurem,
        abilities: new Ability[3]
        {
            Turboblaze,
            Turboblaze,
            Turboblaze,
        }
    );

    public static readonly SpeciesData KyuremBlack = new(
        speciesName: "Kyurem",
        type1: Dragon,
        type2: Ice,
        baseHP: 125,
        baseAttack: 170,
        baseDefense: 100,
        baseSpAtk: 120,
        baseSpDef: 90,
        baseSpeed: 95,
        evYield: Attack * 3,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 315,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "kyurem_black", //Verify
        graphicsLocation: "kyurem/black", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Kyurem,
        abilities: new Ability[3]
        {
            Teravolt,
            Teravolt,
            Teravolt,
        }
    );

    public static readonly SpeciesData KeldeoResolute = Keldeo(true);
    public static readonly SpeciesData MeloettaPirouette = new(
        speciesName: "Meloetta",
        type1: Normal,
        type2: Fighting,
        baseHP: 100,
        baseAttack: 128,
        baseDefense: 90,
        baseSpAtk: 77,
        baseSpDef: 77,
        baseSpeed: 128,
        evYield: Speed + Attack + Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "meloetta", //Verify
        graphicsLocation: "meloetta/pirouette", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Meloetta,
        abilities: new Ability[3]
        {
            SereneGrace,
            SereneGrace,
            SereneGrace,
        }
    );

    public static readonly SpeciesData GenesectDouse = Genesect("genesect/douse");
    public static readonly SpeciesData GenesectShock = Genesect("genesect/shock");
    public static readonly SpeciesData GenesectBurn = Genesect("genesect/burn");
    public static readonly SpeciesData GenesectChill = Genesect("genesect/chill");

    public static readonly SpeciesData GreninjaBB = OverwriteAbility(Greninja, BattleBond);

    public static readonly SpeciesData ScatterbugPolar = Scatterbug(SpeciesID.SpewpaPolar);
    public static readonly SpeciesData ScatterbugTundra = Scatterbug(SpeciesID.SpewpaTundra);
    public static readonly SpeciesData ScatterbugContinental = Scatterbug(SpeciesID.SpewpaContinental);
    public static readonly SpeciesData ScatterbugGarden = Scatterbug(SpeciesID.SpewpaGarden);
    public static readonly SpeciesData ScatterbugElegant = Scatterbug(SpeciesID.SpewpaElegant);
    public static readonly SpeciesData ScatterbugIcySnow = Scatterbug(SpeciesID.SpewpaIcySnow);
    public static readonly SpeciesData ScatterbugModern = Scatterbug(SpeciesID.SpewpaModern);
    public static readonly SpeciesData ScatterbugMarine = Scatterbug(SpeciesID.SpewpaMarine);
    public static readonly SpeciesData ScatterbugArchipelago = Scatterbug(SpeciesID.SpewpaArchipelago);
    public static readonly SpeciesData ScatterbugHighPlains = Scatterbug(SpeciesID.SpewpaHighPlains);
    public static readonly SpeciesData ScatterbugSandstorm = Scatterbug(SpeciesID.SpewpaSandstorm);
    public static readonly SpeciesData ScatterbugRiver = Scatterbug(SpeciesID.SpewpaRiver);
    public static readonly SpeciesData ScatterbugMonsoon = Scatterbug(SpeciesID.SpewpaMonsoon);
    public static readonly SpeciesData ScatterbugSavanna = Scatterbug(SpeciesID.SpewpaSavanna);
    public static readonly SpeciesData ScatterbugSun = Scatterbug(SpeciesID.SpewpaSun);
    public static readonly SpeciesData ScatterbugOcean = Scatterbug(SpeciesID.SpewpaOcean);
    public static readonly SpeciesData ScatterbugJungle = Scatterbug(SpeciesID.SpewpaJungle);
    public static readonly SpeciesData ScatterbugFancy = Scatterbug(SpeciesID.SpewpaFancy);
    public static readonly SpeciesData ScatterbugPokeBall = Scatterbug(SpeciesID.SpewpaPokeBall);

    public static readonly SpeciesData SpewpaPolar = Spewpa(SpeciesID.VivillonPolar);
    public static readonly SpeciesData SpewpaTundra = Spewpa(SpeciesID.VivillonTundra);
    public static readonly SpeciesData SpewpaContinental = Spewpa(SpeciesID.VivillonContinental);
    public static readonly SpeciesData SpewpaGarden = Spewpa(SpeciesID.VivillonGarden);
    public static readonly SpeciesData SpewpaElegant = Spewpa(SpeciesID.VivillonElegant);
    public static readonly SpeciesData SpewpaIcySnow = Spewpa(SpeciesID.VivillonIcySnow);
    public static readonly SpeciesData SpewpaModern = Spewpa(SpeciesID.VivillonModern);
    public static readonly SpeciesData SpewpaMarine = Spewpa(SpeciesID.VivillonMarine);
    public static readonly SpeciesData SpewpaArchipelago = Spewpa(SpeciesID.VivillonArchipelago);
    public static readonly SpeciesData SpewpaHighPlains = Spewpa(SpeciesID.VivillonHighPlains);
    public static readonly SpeciesData SpewpaSandstorm = Spewpa(SpeciesID.VivillonSandstorm);
    public static readonly SpeciesData SpewpaRiver = Spewpa(SpeciesID.VivillonRiver);
    public static readonly SpeciesData SpewpaMonsoon = Spewpa(SpeciesID.VivillonMonsoon);
    public static readonly SpeciesData SpewpaSavanna = Spewpa(SpeciesID.VivillonSavanna);
    public static readonly SpeciesData SpewpaSun = Spewpa(SpeciesID.VivillonSun);
    public static readonly SpeciesData SpewpaOcean = Spewpa(SpeciesID.VivillonOcean);
    public static readonly SpeciesData SpewpaJungle = Spewpa(SpeciesID.VivillonJungle);
    public static readonly SpeciesData SpewpaFancy = Spewpa(SpeciesID.VivillonFancy);
    public static readonly SpeciesData SpewpaPokeBall = Spewpa(SpeciesID.VivillonPokeBall);

    public static readonly SpeciesData VivillonPolar = Vivillon("polar");
    public static readonly SpeciesData VivillonTundra = Vivillon("tundra");
    public static readonly SpeciesData VivillonContinental = Vivillon("continental");
    public static readonly SpeciesData VivillonGarden = Vivillon("garden");
    public static readonly SpeciesData VivillonElegant = Vivillon("elegant");
    public static readonly SpeciesData VivillonIcySnow = Vivillon("icy_snow");
    public static readonly SpeciesData VivillonModern = Vivillon("modern");
    public static readonly SpeciesData VivillonMarine = Vivillon("marine");
    public static readonly SpeciesData VivillonArchipelago = Vivillon("archipelago");
    public static readonly SpeciesData VivillonHighPlains = Vivillon("high_plains");
    public static readonly SpeciesData VivillonSandstorm = Vivillon("sandstorm");
    public static readonly SpeciesData VivillonRiver = Vivillon("river");
    public static readonly SpeciesData VivillonMonsoon = Vivillon("monsoon");
    public static readonly SpeciesData VivillonSavanna = Vivillon("savanna");
    public static readonly SpeciesData VivillonSun = Vivillon("sun");
    public static readonly SpeciesData VivillonOcean = Vivillon("ocean");
    public static readonly SpeciesData VivillonJungle = Vivillon("jungle");
    public static readonly SpeciesData VivillonFancy = Vivillon("fancy");
    public static readonly SpeciesData VivillonPokeBall = Vivillon("poke_ball");

    public static readonly SpeciesData FlabebeYellow = Flabebe(SpeciesID.FloetteYellow, "yellow");
    public static readonly SpeciesData FlabebeOrange = Flabebe(SpeciesID.FloetteOrange, "orange");
    public static readonly SpeciesData FlabebeBlue = Flabebe(SpeciesID.FloetteBlue, "blue");
    public static readonly SpeciesData FlabebeWhite = Flabebe(SpeciesID.FloetteWhite, "white");

    public static readonly SpeciesData FloetteYellow = Floette(SpeciesID.FlorgesYellow, "yellow");
    public static readonly SpeciesData FloetteOrange = Floette(SpeciesID.FlorgesOrange, "orange");
    public static readonly SpeciesData FloetteBlue = Floette(SpeciesID.FlorgesBlue, "blue");
    public static readonly SpeciesData FloetteWhite = Floette(SpeciesID.FlorgesWhite, "white");
    public static readonly SpeciesData FloetteEternal = Floette(SpeciesID.Missingno, "eternal", eternal: true);

    public static readonly SpeciesData FlorgesYellow = Florges("yellow");
    public static readonly SpeciesData FlorgesOrange = Florges("orange");
    public static readonly SpeciesData FlorgesBlue = Florges("blue");
    public static readonly SpeciesData FlorgesWhite = Florges("white");

    public static readonly SpeciesData FurfrouHeart = Furfrou("heart_trim");
    public static readonly SpeciesData FurfrouStar = Furfrou("star_trim");
    public static readonly SpeciesData FurfrouDiamond = Furfrou("diamond_trim");
    public static readonly SpeciesData FurfrouDebutante = Furfrou("debutante_trim");
    public static readonly SpeciesData FurfrouMatron = Furfrou("matron_trim");
    public static readonly SpeciesData FurfrouDandy = Furfrou("dandy_trim");
    public static readonly SpeciesData FurfrouLaReine = Furfrou("la_reine_trim");
    public static readonly SpeciesData FurfrouKabuki = Furfrou("kabuki_trim");
    public static readonly SpeciesData FurfrouPharaoh = Furfrou("pharaoh_trim");

    public static readonly SpeciesData MeowsticF = new(
        speciesName: "Meowstic",
        type1: Psychic,
        type2: Psychic,
        baseHP: 74,
        baseAttack: 48,
        baseDefense: 76,
        baseSpAtk: 83,
        baseSpDef: 81,
        baseSpeed: 104,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 163,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "meowstic", //Verify
        graphicsLocation: "meowstic/female", //Verify
        backSpriteHeight: 9,
        pokedexData: Pokedex.Meowstic,
        abilities: new Ability[3]
        {
            KeenEye,
            Infiltrator,
            Competitive,
        }
    );

    public static readonly SpeciesData PumpkabooSmall = Pumpkaboo(
        baseHP: 44,
        baseSpeed: 56,
        nextEvo: SpeciesID.GourgeistSmall,
        graphicsSubfolder: "small",
        backSpriteHeight: 14
    );

    public static readonly SpeciesData PumpkabooLarge = Pumpkaboo(
        baseHP: 54,
        baseSpeed: 46,
        nextEvo: SpeciesID.GourgeistLarge,
        graphicsSubfolder: "large",
        backSpriteHeight: 13
    );

    public static readonly SpeciesData PumpkabooSuper = Pumpkaboo(
        baseHP: 59,
        baseSpeed: 41,
        nextEvo: SpeciesID.GourgeistSuper,
        graphicsSubfolder: "super",
        backSpriteHeight: 12
    );

    public static readonly SpeciesData GourgeistSmall = Gourgeist(
        baseHP: 55,
        baseAttack: 85,
        baseSpeed: 99,
        graphicsSubfolder: "small",
        backSpriteHeight: 4
    );

    public static readonly SpeciesData GourgeistLarge = Gourgeist(
        baseHP: 75,
        baseAttack: 95,
        baseSpeed: 69,
        graphicsSubfolder: "large",
        backSpriteHeight: 2
    );

    public static readonly SpeciesData GourgeistSuper = Gourgeist(
        baseHP: 85,
        baseAttack: 100,
        baseSpeed: 54,
        graphicsSubfolder: "super",
        backSpriteHeight: 1
    );

    public static readonly SpeciesData XerneasActive = Xerneas("xerneas/active");

    public static readonly SpeciesData Zygarde10 = new(
        speciesName: "Zygarde",
        type1: Dragon,
        type2: Ground,
        baseHP: 54,
        baseAttack: 100,
        baseDefense: 71,
        baseSpAtk: 61,
        baseSpDef: 85,
        baseSpeed: 115,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 219,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "zygarde_10",
        graphicsLocation: "zygarde/10_percent",
        backSpriteHeight: 8,
        pokedexData: Pokedex.Zygarde,
        abilities: new Ability[3]
        {
            AuraBreak,
            AuraBreak,
            AuraBreak
        }
    );
    public static readonly SpeciesData Zygarde10PC = OverwriteAbility(Zygarde10, PowerConstruct);
    public static readonly SpeciesData Zygarde50PC = OverwriteAbility(Zygarde50, PowerConstruct);
    public static readonly SpeciesData ZygardeComplete = new(
        speciesName: "Zygarde",
        type1: Dragon,
        type2: Ground,
        baseHP: 216,
        baseAttack: 100,
        baseDefense: 121,
        baseSpAtk: 91,
        baseSpDef: 95,
        baseSpeed: 85,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 319,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "zygarde_complete", //Verify
        graphicsLocation: "zygarde/complete", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Zygarde,
        abilities: new Ability[3]
        {
            PowerConstruct,
            PowerConstruct,
            PowerConstruct,
        }
    );

    public static readonly SpeciesData HoopaUnbound = new(
        speciesName: "Hoopa",
        type1: Psychic,
        type2: Dark,
        baseHP: 80,
        baseAttack: 160,
        baseDefense: 60,
        baseSpAtk: 170,
        baseSpDef: 130,
        baseSpeed: 80,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "hoopa_unbound", //Verify
        graphicsLocation: "hoopa/unbound", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Hoopa,
        abilities: new Ability[3]
        {
            Magician,
            Magician,
            Magician,
        }
    );

    public static readonly SpeciesData OricorioPomPom = Oricorio(Electric, "pom_pom");
    public static readonly SpeciesData OricorioPau = Oricorio(Psychic, "pau");
    public static readonly SpeciesData OricorioSensu = Oricorio(Ghost, "sensu");

    public static readonly SpeciesData RockruffOwnTempo = Rockruff(
        new[] { OwnTempo, OwnTempo, OwnTempo }, Evolution.RockruffOwnTempo);

    public static readonly SpeciesData LycanrocMidnight = new(
        speciesName: "Lycanroc",
        type1: Rock,
        type2: Rock,
        baseHP: 85,
        baseAttack: 115,
        baseDefense: 75,
        baseSpAtk: 55,
        baseSpDef: 75,
        baseSpeed: 82,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "lycanroc_midnight",
        graphicsLocation: "lycanroc/midnight",
        backSpriteHeight: 7,
        pokedexData: Pokedex.Lycanroc,
        abilities: new Ability[3]
        {
            KeenEye,
            VitalSpirit,
            NoGuard,
        }
    );
    public static readonly SpeciesData LycanrocDusk = new(
        speciesName: "Lycanroc",
        type1: Rock,
        type2: Rock,
        baseHP: 75,
        baseAttack: 117,
        baseDefense: 65,
        baseSpAtk: 55,
        baseSpDef: 65,
        baseSpeed: 110,
        evYield: 2 * Attack,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 170,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 90,
        baseFriendship: 70,
        cryLocation: "lycanroc_dusk", //Verify
        graphicsLocation: "lycanroc/dusk", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Lycanroc,
        abilities: new Ability[3]
        {
            ToughClaws,
            ToughClaws,
            ToughClaws,
        }
    );
    public static readonly SpeciesData WishiwashiSchool = new(
        speciesName: "Wishiwashi",
        type1: Water,
        type2: Water,
        baseHP: 45,
        baseAttack: 140,
        baseDefense: 130,
        baseSpAtk: 140,
        baseSpDef: 135,
        baseSpeed: 30,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 15,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "wishiwashi_school",
        graphicsLocation: "wishiwashi/school",
        backSpriteHeight: 5,
        pokedexData: Pokedex.Wishiwashi,
        abilities: new Ability[3]
        {
            Schooling,
            Schooling,
            Schooling,
        }
    );

    public static readonly SpeciesData SilvallyFighting = Silvally(Fighting, "fighting");
    public static readonly SpeciesData SilvallyFlying = Silvally(Flying, "flying");
    public static readonly SpeciesData SilvallyPoison = Silvally(Poison, "poison");
    public static readonly SpeciesData SilvallyGround = Silvally(Ground, "ground");
    public static readonly SpeciesData SilvallyRock = Silvally(Rock, "rock");
    public static readonly SpeciesData SilvallyBug = Silvally(Bug, "bug");
    public static readonly SpeciesData SilvallyGhost = Silvally(Ghost, "ghost");
    public static readonly SpeciesData SilvallySteel = Silvally(Steel, "steel");
    public static readonly SpeciesData SilvallyFire = Silvally(Fire, "fire");
    public static readonly SpeciesData SilvallyWater = Silvally(Water, "water");
    public static readonly SpeciesData SilvallyGrass = Silvally(Grass, "grass");
    public static readonly SpeciesData SilvallyElectric = Silvally(Electric, "electric");
    public static readonly SpeciesData SilvallyPsychic = Silvally(Psychic, "psychic");
    public static readonly SpeciesData SilvallyIce = Silvally(Ice, "ice");
    public static readonly SpeciesData SilvallyDragon = Silvally(Dragon, "dragon");
    public static readonly SpeciesData SilvallyDark = Silvally(Dark, "dark");
    public static readonly SpeciesData SilvallyFairy = Silvally(Fairy, "fairy");

    public static readonly SpeciesData MiniorOrangeMeteor = Minior(false);
    public static readonly SpeciesData MiniorYellowMeteor = Minior(false);
    public static readonly SpeciesData MiniorGreenMeteor = Minior(false);
    public static readonly SpeciesData MiniorBlueMeteor = Minior(false);
    public static readonly SpeciesData MiniorIndigoMeteor = Minior(false);
    public static readonly SpeciesData MiniorVioletMeteor = Minior(false);
    public static readonly SpeciesData MiniorRedCore = Minior(true, "red");
    public static readonly SpeciesData MiniorOrangeCore = Minior(true, "orange");
    public static readonly SpeciesData MiniorYellowCore = Minior(true, "yellow");
    public static readonly SpeciesData MiniorGreenCore = Minior(true, "green");
    public static readonly SpeciesData MiniorBlueCore = Minior(true, "blue");
    public static readonly SpeciesData MiniorIndigoCore = Minior(true, "indigo");
    public static readonly SpeciesData MiniorVioletCore = Minior(true, "violet");

    public static readonly SpeciesData MimikyuBusted = Mimikyu(true);

    public static readonly SpeciesData MagearnaOriginal = Magearna(true);

    public static readonly SpeciesData NecrozmaDuskMane = new(
        speciesName: "Necrozma",
        type1: Psychic,
        type2: Steel,
        baseHP: 97,
        baseAttack: 157,
        baseDefense: 127,
        baseSpAtk: 113,
        baseSpDef: 109,
        baseSpeed: 77,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "necrozma_dusk_mane", //Verify
        graphicsLocation: "necrozma/dusk_mane", //Verify
        backSpriteHeight: 1,
        pokedexData: Pokedex.Necrozma,
        abilities: new Ability[3]
        {
            PrismArmor,
            PrismArmor,
            PrismArmor,
        }
    );
    public static readonly SpeciesData NecrozmaDawnWings = new(
        speciesName: "Necrozma",
        type1: Psychic,
        type2: Ghost,
        baseHP: 97,
        baseAttack: 113,
        baseDefense: 109,
        baseSpAtk: 157,
        baseSpDef: 127,
        baseSpeed: 77,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 306,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "necrozma_dawn_wings", //Verify
        graphicsLocation: "necrozma/dawn_wings", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Necrozma,
        abilities: new Ability[3]
        {
            PrismArmor,
            PrismArmor,
            PrismArmor,
        }
    );
    public static readonly SpeciesData NecrozmaUltra = new(
        speciesName: "Necrozma",
        type1: Psychic,
        type2: Dragon,
        baseHP: 97,
        baseAttack: 167,
        baseDefense: 97,
        baseSpAtk: 167,
        baseSpDef: 97,
        baseSpeed: 129,
        evYield: Attack + Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 339,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "necrozma_ultra", //Verify
        graphicsLocation: "necrozma/ultra", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Necrozma,
        abilities: new Ability[3]
        {
            Neuroforce,
            Neuroforce,
            Neuroforce,
        }
    );

    public static readonly SpeciesData CramorantGulping = Cramorant(1);
    public static readonly SpeciesData CramorantGorging = Cramorant(2);

    public static readonly SpeciesData ToxtricityLowKey = Toxtricity(true);

    public static readonly SpeciesData SinisteaAntique = Sinistea(true);

    public static readonly SpeciesData PolteageistAntique = Polteageist(true);

    public static readonly SpeciesData AlcremieRubyCream = Alcremie("ruby_cream");
    public static readonly SpeciesData AlcremieMatchaCream = Alcremie("matcha_cream");
    public static readonly SpeciesData AlcremieMintCream = Alcremie("mint_cream");
    public static readonly SpeciesData AlcremieLemonCream = Alcremie("lemon_cream");
    public static readonly SpeciesData AlcremieSaltedCream = Alcremie("salted_cream");
    public static readonly SpeciesData AlcremieRubySwirl = Alcremie("ruby_swirl");
    public static readonly SpeciesData AlcremieCaramelSwirl = Alcremie("caramel_swirl");
    public static readonly SpeciesData AlcremieRainbowSwirl = Alcremie("rainbow_swirl");


    public static SpeciesData EiscueNoice = new(
        speciesName: "Eiscue",
        type1: Ice,
        type2: Ice,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 70,
        baseSpAtk: 65,
        baseSpDef: 50,
        baseSpeed: 130,
        evYield: 2 * Defense,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Field,
        eggCycles: 25,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "eiscue_noice_face", //Verify
        graphicsLocation: "eiscue/noice_face", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Eiscue,
        abilities: new Ability[3]
        {
            IceFace,
            IceFace,
            IceFace,
        }
    );
    public static SpeciesData IndeedeeF = new(
        speciesName: "Indeedee",
        type1: Psychic,
        type2: Normal,
        baseHP: 70,
        baseAttack: 55,
        baseDefense: 65,
        baseSpAtk: 95,
        baseSpDef: 105,
        baseSpeed: 85,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: Fast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 40,
        catchRate: 30,
        baseFriendship: 140,
        cryLocation: "indeedee_female", //Verify
        graphicsLocation: "indeedee/female", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Indeedee,
        abilities: new Ability[3]
        {
            OwnTempo,
            Synchronize,
            PsychicSurge,
        }
    );

    public static SpeciesData MorpekoHangry = Morpeko(true);

    public static SpeciesData ZacianCrowned = new(
        speciesName: "Zacian",
        type1: Fairy,
        type2: Steel,
        baseHP: 92,
        baseAttack: 170,
        baseDefense: 115,
        baseSpAtk: 80,
        baseSpDef: 115,
        baseSpeed: 148,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 360,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 10,
        baseFriendship: 0,
        cryLocation: "zacian_crowned_sword", //Verify
        graphicsLocation: "zacian/crowned_sword", //Verify
        backSpriteHeight: 6,
        pokedexData: Pokedex.Zacian,
        abilities: new Ability[3]
        {
            IntrepidSword,
            IntrepidSword,
            IntrepidSword,
        }
    );
    public static SpeciesData ZamazentaCrowned = new(
        speciesName: "Zamazenta",
        type1: Fighting,
        type2: Steel,
        baseHP: 92,
        baseAttack: 130,
        baseDefense: 145,
        baseSpAtk: 80,
        baseSpDef: 145,
        baseSpeed: 128,
        evYield: 3 * Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 360,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 10,
        baseFriendship: 0,
        cryLocation: "zamazenta_crowned_shield", //Verify
        graphicsLocation: "zamazenta/crowned_shield", //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Zamazenta,
        abilities: new Ability[3]
        {
            DauntlessShield,
            DauntlessShield,
            DauntlessShield,
        }
    );
    public static SpeciesData EternatusEternamax = new(
        speciesName: "Eternatus",
        type1: Poison,
        type2: Dragon,
        baseHP: 255,
        baseAttack: 115,
        baseDefense: 250,
        baseSpAtk: 125,
        baseSpDef: 250,
        baseSpeed: 130,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 563,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 255,
        baseFriendship: 0,
        cryLocation: "eternatus_eternamax", //Verify
        graphicsLocation: "eternatus/eternamax", //Verify
        backSpriteHeight: 7,
        pokedexData: Pokedex.Eternatus,
        abilities: new Ability[3]
        {
            Pressure,
            Pressure,
            Pressure,
        }
    );
    public static SpeciesData UrshifuRapid = new(
        speciesName: "Urshifu",
        type1: Fighting,
        type2: Water,
        baseHP: 100,
        baseAttack: 130,
        baseDefense: 100,
        baseSpAtk: 63,
        baseSpDef: 60,
        baseSpeed: 97,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 275,
        learnset: EmptyLearnset, //Not done
        malePercent: 87,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 70,
        cryLocation: "urshifu_rapid_strike_style", //Verify
        graphicsLocation: "urshifu/rapid_strike_style", //Verify
        backSpriteHeight: 4,
        gMaxPath: "urshifu/gmax_rapid",
        gMaxBackHeight: 4,
        pokedexData: Pokedex.Urshifu,
        abilities: new Ability[3]
        {
            UnseenFist,
            UnseenFist,
            UnseenFist,
        }
    );

    public static readonly SpeciesData ZarudeDada = Zarude(true);

    public static SpeciesData CalyrexIce = new(
        speciesName: "Calyrex",
        type1: Psychic,
        type2: Ice,
        baseHP: 100,
        baseAttack: 165,
        baseDefense: 150,
        baseSpAtk: 85,
        baseSpDef: 130,
        baseSpeed: 50,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 340,
        learnset: EmptyLearnset, //Not done
        malePercent: SpeciesData.Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "calyrex_ice_rider", //Verify
        graphicsLocation: "calyrex/ice_rider", //Verify
        backSpriteHeight: 7, //Not done
        pokedexData: Pokedex.Calyrex,
        abilities: new Ability[3]
        {
            AsOneGlastrier,
            AsOneGlastrier,
            AsOneGlastrier,
        }
    );
    public static SpeciesData CalyrexShadow = new(
        speciesName: "Calyrex",
        type1: Psychic,
        type2: Ghost,
        baseHP: 100,
        baseAttack: 85,
        baseDefense: 80,
        baseSpAtk: 165,
        baseSpDef: 100,
        baseSpeed: 150,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 340,
        learnset: EmptyLearnset, //Not done
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 100,
        cryLocation: "calyrex_shadow_rider", //Verify
        graphicsLocation: "calyrex/shadow_rider", //Verify
        backSpriteHeight: 7, //Not done
        pokedexData: Pokedex.Calyrex,
        abilities: new Ability[3]
        {
            AsOneSpectrier,
            AsOneSpectrier,
            AsOneSpectrier,
        }
    );

    public static SpeciesData EnamorusT = new(
        speciesName: "Enamorus",
        type1: Fairy,
        type2: Flying,
        baseHP: 74,
        baseAttack: 115,
        baseDefense: 110,
        baseSpAtk: 135,
        baseSpDef: 100,
        baseSpeed: 46,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 90,
        cryLocation: "enamorus_therian", //Verify
        graphicsLocation: "enamorus/therian", //Verify
        backSpriteHeight: 2,
        pokedexData: Pokedex.Enamorus,
        abilities: new Ability[3]
        {
            Overcoat,
            Overcoat,
            Overcoat,
        }
    );

    public static SpeciesData BasculegionF = new(
        speciesName: "Basculegion",
        type1: Water,
        type2: Ghost,
        baseHP: 120,
        baseAttack: 92,
        baseDefense: 65,
        baseSpAtk: 100,
        baseSpDef: 75,
        baseSpeed: 78,
        evYield: 2 * HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 186,
        learnset: EmptyLearnset, //Not done
        malePercent: 0,
        eggGroup1: EggGroup.Water2,
        eggGroup2: EggGroup.Water2,
        eggCycles: 40,
        catchRate: 25,
        baseFriendship: 70,
        cryLocation: "basculegion", //Verify
        graphicsLocation: "basculegion/female", //Verify
        backSpriteHeight: 0,
        pokedexData: Pokedex.Basculegion,
        abilities: new Ability[3]
        {
            Rattled,
            Adaptability,
            MoldBreaker,
        }
    );

    public static readonly SpeciesData[] SpeciesTable = new SpeciesData[(int)SpeciesID.Count] { //Todo: Change TempCount to Count
        //Gen 1
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

        //Gen 5
        Victini,
        Snivy,
        Servine,
        Serperior,
        Tepig,
        Pignite,
        Emboar,
        Oshawott,
        Dewott,
        Samurott,
        Patrat,
        Watchog,
        Lillipup,
        Herdier,
        Stoutland,
        Purrloin,
        Liepard,
        Pansage,
        Simisage,
        Pansear,
        Simisear,
        Panpour,
        Simipour,
        Munna,
        Musharna,
        Pidove,
        Tranquill,
        Unfezant,
        Blitzle,
        Zebstrika,
        Roggenrola,
        Boldore,
        Gigalith,
        Woobat,
        Swoobat,
        Drilbur,
        Excadrill,
        Audino,
        Timburr,
        Gurdurr,
        Conkeldurr,
        Tympole,
        Palpitoad,
        Seismitoad,
        Throh,
        Sawk,
        Sewaddle,
        Swadloon,
        Leavanny,
        Venipede,
        Whirlipede,
        Scolipede,
        Cottonee,
        Whimsicott,
        Petilil,
        Lilligant,
        BasculinRed,
        Sandile,
        Krokorok,
        Krookodile,
        Darumaka,
        Darmanitan,
        Maractus,
        Dwebble,
        Crustle,
        Scraggy,
        Scrafty,
        Sigilyph,
        Yamask,
        Cofagrigus,
        Tirtouga,
        Carracosta,
        Archen,
        Archeops,
        Trubbish,
        Garbodor,
        Zorua,
        Zoroark,
        Minccino,
        Cinccino,
        Gothita,
        Gothorita,
        Gothitelle,
        Solosis,
        Duosion,
        Reuniclus,
        Ducklett,
        Swanna,
        Vanillite,
        Vanillish,
        Vanilluxe,
        DeerlingSpring,
        SawsbuckSpring,
        Emolga,
        Karrablast,
        Escavalier,
        Foongus,
        Amoonguss,
        Frillish,
        Jellicent,
        Alomomola,
        Joltik,
        Galvantula,
        Ferroseed,
        Ferrothorn,
        Klink,
        Klang,
        Klinklang,
        Tynamo,
        Eelektrik,
        Eelektross,
        Elgyem,
        Beheeyem,
        Litwick,
        Lampent,
        Chandelure,
        Axew,
        Fraxure,
        Haxorus,
        Cubchoo,
        Beartic,
        Cryogonal,
        Shelmet,
        Accelgor,
        Stunfisk,
        Mienfoo,
        Mienshao,
        Druddigon,
        Golett,
        Golurk,
        Pawniard,
        Bisharp,
        Bouffalant,
        Rufflet,
        Braviary,
        Vullaby,
        Mandibuzz,
        Heatmor,
        Durant,
        Deino,
        Zweilous,
        Hydreigon,
        Larvesta,
        Volcarona,
        Cobalion,
        Terrakion,
        Virizion,
        TornadusI,
        ThundurusI,
        Reshiram,
        Zekrom,
        LandorusI,
        Kyurem,
        KeldeoOriginal,
        MeloettaAria,
        GenesectNormal,

        //Gen 6
        Chespin,
        Quilladin,
        Chesnaught,
        Fennekin,
        Braixen,
        Delphox,
        Froakie,
        Frogadier,
        Greninja,
        Bunnelby,
        Diggersby,
        Fletchling,
        Fletchinder,
        Talonflame,
        ScatterbugMeadow,
        SpewpaMeadow,
        VivillonMeadow,
        Litleo,
        Pyroar,
        FlabebeRed,
        FloetteRed,
        FlorgesRed,
        Skiddo,
        Gogoat,
        Pancham,
        Pangoro,
        FurfrouNatural,
        Espurr,
        MeowsticM,
        Honedge,
        Doublade,
        AegislashShield,
        Spritzee,
        Aromatisse,
        Swirlix,
        Slurpuff,
        Inkay,
        Malamar,
        Binacle,
        Barbaracle,
        Skrelp,
        Dragalge,
        Clauncher,
        Clawitzer,
        Helioptile,
        Heliolisk,
        Tyrunt,
        Tyrantrum,
        Amaura,
        Aurorus,
        Sylveon,
        Hawlucha,
        Dedenne,
        Carbink,
        Goomy,
        Sliggoo,
        Goodra,
        Klefki,
        Phantump,
        Trevenant,
        PumpkabooAverage,
        GourgeistAverage,
        Bergmite,
        Avalugg,
        Noibat,
        Noivern,
        XerneasInactive,
        Yveltal,
        Zygarde50,
        Diancie,
        Hoopa,
        Volcanion,

        //Gen 7
        Rowlet,
        Dartrix,
        Decidueye,
        Litten,
        Torracat,
        Incineroar,
        Popplio,
        Brionne,
        Primarina,
        Pikipek,
        Trumbeak,
        Toucannon,
        Yungoos,
        Gumshoos,
        Grubbin,
        Charjabug,
        Vikavolt,
        Crabrawler,
        Crabominable,
        OricorioBaile,
        Cutiefly,
        Ribombee,
        RockruffNormal,
        Lycanroc,
        Wishiwashi,
        Mareanie,
        Toxapex,
        Mudbray,
        Mudsdale,
        Dewpider,
        Araquanid,
        Fomantis,
        Lurantis,
        Morelull,
        Shiinotic,
        Salandit,
        Salazzle,
        Stufful,
        Bewear,
        Bounsweet,
        Steenee,
        Tsareena,
        Comfey,
        Oranguru,
        Passimian,
        Wimpod,
        Golisopod,
        Sandygast,
        Palossand,
        Pyukumuku,
        TypeNull,
        SilvallyNormal,
        MiniorRedMeteor,
        Komala,
        Turtonator,
        Togedemaru,
        MimikyuBase,
        Bruxish,
        Drampa,
        Dhelmise,
        JangmoO,
        HakamoO,
        KommoO,
        TapuKoko,
        TapuLele,
        TapuBulu,
        TapuFini,
        Cosmog,
        Cosmoem,
        Solgaleo,
        Lunala,
        Nihilego,
        Buzzwole,
        Pheromosa,
        Xurkitree,
        Celesteela,
        Kartana,
        Guzzlord,
        Necrozma,
        MagearnaBase,
        Marshadow,
        Poipole,
        Naganadel,
        Stakataka,
        Blacephalon,
        Zeraora,
        Meltan,
        Melmetal,

        //Gen 8
        Grookey,
        Thwackey,
        Rillaboom,
        Scorbunny,
        Raboot,
        Cinderace,
        Sobble,
        Drizzile,
        Inteleon,
        Skwovet,
        Greedent,
        Rookidee,
        Corvisquire,
        Corviknight,
        Blipbug,
        Dottler,
        Orbeetle,
        Nickit,
        Thievul,
        Gossifleur,
        Eldegoss,
        Wooloo,
        Dubwool,
        Chewtle,
        Drednaw,
        Yamper,
        Boltund,
        Rolycoly,
        Carkol,
        Coalossal,
        Applin,
        Flapple,
        Appletun,
        Silicobra,
        Sandaconda,
        Cramorant,
        Arrokuda,
        Barraskewda,
        Toxel,
        Toxtricity,
        Sizzlipede,
        Centiskorch,
        Clobbopus,
        Grapploct,
        Sinistea,
        Polteageist,
        Hatenna,
        Hattrem,
        Hatterene,
        Impidimp,
        Morgrem,
        Grimmsnarl,
        Obstagoon,
        Perrserker,
        Cursola,
        Sirfetchd,
        MrRime,
        Runerigus,
        Milcery,
        Alcremie,
        Falinks,
        Pincurchin,
        Snom,
        Frosmoth,
        Stonjourner,
        Eiscue,
        Indeedee,
        Morpeko,
        Cufant,
        Copperajah,
        Dracozolt,
        Arctozolt,
        Dracovish,
        Arctovish,
        Duraludon,
        Dreepy,
        Drakloak,
        Dragapult,
        Zacian,
        Zamazenta,
        Eternatus,
        Kubfu,
        Urshifu,
        Zarude,
        Regieleki,
        Regidrago,
        Glastrier,
        Spectrier,
        Calyrex,
        Wyrdeer,
        Kleavor,
        Ursaluna,
        Basculegion,
        Sneasler,
        Overqwil,
        Enamorus,

        //Forms

        //Regional forms
        //Alola
        RattataAlola,
        RaticateAlola,
        RaichuAlola,
        SandshrewAlola,
        SandslashAlola,
        VulpixAlola,
        NinetalesAlola,
        DiglettAlola,
        DugtrioAlola,
        MeowthAlola,
        PersianAlola,
        GeodudeAlola,
        GravelerAlola,
        GolemAlola,
        GrimerAlola,
        MukAlola,
        ExeggutorAlola,
        MarowakAlola,
        //Galar
        MeowthGalar,
        PonytaGalar,
        RapidashGalar,
        SlowpokeGalar,
        SlowbroGalar,
        FarfetchdGalar,
        WeezingGalar,
        MrMimeGalar,
        ArticunoGalar,
        ZapdosGalar,
        MoltresGalar,
        SlowkingGalar,
        CorsolaGalar,
        ZigzagoonGalar,
        LinooneGalar,
        DarumakaGalar,
        DarmanitanGalar,
        YamaskGalar,
        StunfiskGalar,
        //Hisui
        GrowlitheHisui,
        ArcanineHisui,
        VoltorbHisui,
        ElectrodeHisui,
        TyphlosionHisui,
        QwilfishHisui,
        SneaselHisui,
        SamurottHisui,
        LilligantHisui,
        ZoruaHisui,
        ZoroarkHisui,
        BraviaryHisui,
        SliggooHisui,
        GoodraHisui,
        AvaluggHisui,
        DecidueyeHisui,

        //Other forms

        PikachuCosplay,
        PikachuRockStar,
        PikachuBelle,
        PikachuPopStar,
        PikachuPhD,
        PikachuLibre,
        PikachuOriginal,
        PikachuHoenn,
        PikachuSinnoh,
        PikachuUnova,
        PikachuKalos,
        PikachuAlolaCap,
        PikachuPartnerCap,
        PikachuWorld,
        PikachuPartner,

        EeveePartner,

        PichuSpikyEared,

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
        UnownQuestion,
        UnownExclamation,

        CastformSunny,
        CastformRainy,
        CastformSnowy,

        KyogrePrimal,
        GroudonPrimal,

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
        ArceusPsychic,
        ArceusDragon,
        ArceusDark,
        ArceusFairy,

        BasculinBlue,
        BasculinWhite,

        DarmanitanZen,
        DarmanitanGalarZen,

        DeerlingSummer,
        DeerlingAutumn,
        DeerlingWinter,

        SawsbuckSummer,
        SawsbuckAutumn,
        SawsbuckWinter,

        TornadusT,

        ThundurusT,

        LandorusT,

        KyuremWhite,
        KyuremBlack,

        KeldeoResolute,

        MeloettaPirouette,

        GenesectDouse,
        GenesectShock,
        GenesectBurn,
        GenesectChill,

        GreninjaBB,

        ScatterbugArchipelago,
        ScatterbugContinental,
        ScatterbugElegant,
        ScatterbugGarden,
        ScatterbugHighPlains,
        ScatterbugIcySnow,
        ScatterbugJungle,
        ScatterbugMarine,
        ScatterbugModern,
        ScatterbugMonsoon,
        ScatterbugOcean,
        ScatterbugPolar,
        ScatterbugRiver,
        ScatterbugSandstorm,
        ScatterbugSavanna,
        ScatterbugSun,
        ScatterbugTundra,
        ScatterbugFancy,
        ScatterbugPokeBall,

        SpewpaArchipelago,
        SpewpaContinental,
        SpewpaElegant,
        SpewpaGarden,
        SpewpaHighPlains,
        SpewpaIcySnow,
        SpewpaJungle,
        SpewpaMarine,
        SpewpaModern,
        SpewpaMonsoon,
        SpewpaOcean,
        SpewpaPolar,
        SpewpaRiver,
        SpewpaSandstorm,
        SpewpaSavanna,
        SpewpaSun,
        SpewpaTundra,
        SpewpaFancy,
        SpewpaPokeBall,

        VivillonArchipelago,
        VivillonContinental,
        VivillonElegant,
        VivillonGarden,
        VivillonHighPlains,
        VivillonIcySnow,
        VivillonJungle,
        VivillonMarine,
        VivillonModern,
        VivillonMonsoon,
        VivillonOcean,
        VivillonPolar,
        VivillonRiver,
        VivillonSandstorm,
        VivillonSavanna,
        VivillonSun,
        VivillonTundra,
        VivillonFancy,
        VivillonPokeBall,

        FlabebeYellow,
        FlabebeOrange,
        FlabebeBlue,
        FlabebeWhite,

        FloetteYellow,
        FloetteOrange,
        FloetteBlue,
        FloetteWhite,
        FloetteEternal,

        FlorgesYellow,
        FlorgesOrange,
        FlorgesBlue,
        FlorgesWhite,

        FurfrouHeart,
        FurfrouStar,
        FurfrouDiamond,
        FurfrouDebutante,
        FurfrouMatron,
        FurfrouDandy,
        FurfrouLaReine,
        FurfrouKabuki,
        FurfrouPharaoh,

        MeowsticF,

        AegislashBlade,

        PumpkabooSmall,
        PumpkabooLarge,
        PumpkabooSuper,

        GourgeistSmall,
        GourgeistLarge,
        GourgeistSuper,

        XerneasActive,

        Zygarde10,
        Zygarde10PC,
        Zygarde50PC,
        ZygardeComplete,

        HoopaUnbound,

        OricorioPomPom,
        OricorioPau,
        OricorioSensu,

        RockruffOwnTempo,

        LycanrocMidnight,
        LycanrocDusk,

        WishiwashiSchool,

        SilvallyFighting,
        SilvallyFlying,
        SilvallyPoison,
        SilvallyGround,
        SilvallyRock,
        SilvallyBug,
        SilvallyGhost,
        SilvallySteel,
        SilvallyFire,
        SilvallyWater,
        SilvallyGrass,
        SilvallyElectric,
        SilvallyPsychic,
        SilvallyIce,
        SilvallyDragon,
        SilvallyDark,
        SilvallyFairy,

        MiniorOrangeMeteor,
        MiniorYellowMeteor,
        MiniorGreenMeteor,
        MiniorBlueMeteor,
        MiniorIndigoMeteor,
        MiniorVioletMeteor,
        MiniorRedCore,
        MiniorOrangeCore,
        MiniorYellowCore,
        MiniorGreenCore,
        MiniorBlueCore,
        MiniorIndigoCore,
        MiniorVioletCore,

        MimikyuBusted,

        NecrozmaDuskMane,
        NecrozmaDawnWings,
        NecrozmaUltra,

        MagearnaOriginal,

        CramorantGulping,
        CramorantGorging,

        ToxtricityLowKey,

        SinisteaAntique,

        PolteageistAntique,

        AlcremieRubyCream,
        AlcremieMatchaCream,
        AlcremieMintCream,
        AlcremieLemonCream,
        AlcremieSaltedCream,
        AlcremieRubySwirl,
        AlcremieCaramelSwirl,
        AlcremieRainbowSwirl,

        EiscueNoice,

        IndeedeeF,

        MorpekoHangry,

        ZacianCrowned,

        ZamazentaCrowned,

        EternatusEternamax,

        UrshifuRapid,

        ZarudeDada,

        CalyrexIce,
        CalyrexShadow,

        BasculegionF,

        EnamorusT,

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
        AudinoMega,
        DiancieMega,
    };
}