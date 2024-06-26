using System;
using static EvYield;
using static Type;
using static XPClass;
using static Ability;
using static Learnset;
using static TMLearnset;
using UnityEngine;

public class SpeciesData
{
    public const int Genderless = 255;

    public string speciesName;

    public Type type1;
    public Type type2;

    public byte baseHP;
    public byte baseAttack;
    public byte baseDefense;
    public byte baseSpAtk;
    public byte baseSpDef;
    public byte baseSpeed;

    public ushort evYield;

    public EvolutionData[] evolution;
    public XPClass xpClass;
    public int xpYield;

    public LearnsetMove[] learnset;

    public int malePercent;

    public int eggCycles;
    public EggGroup eggGroup1;
    public EggGroup eggGroup2;

    public int catchRate;
    public byte baseFriendship;

    public SpeciesID dexRedirect;

    public SpeciesFlags speciesFlags;

    public class PokemonGraphics
    {
        public Sprite backSprite;
        public int backSpriteHeight;
        public Sprite frontSprite1;
        public Sprite frontSprite2;
        public Sprite icon1;
        public Sprite icon2;

        public PokemonGraphics(string path, int backSpriteHeight)
        {
            backSprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + path + "/back"),
                new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            {
                Texture2D test = Resources.Load<Texture2D>("Sprites/Pokemon/" + path + "/anim_front");
                test ??= Resources.Load<Texture2D>("Sprites/Pokemon/" + path + "/front");
                bool anim = test != null && test.height > 64;
                frontSprite1 = Sprite.Create(test, new Rect(0.0f, anim ? 64.0f : 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
                frontSprite2 = Sprite.Create(test, new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            }
            {
                Texture2D test = Resources.Load<Texture2D>("Sprites/Pokemon/" + path + "/icon");
                test ??= Resources.Load<Texture2D>("Sprites/Pokemon/" + Strip(path) + "/icon");
                icon1 = Sprite.Create(test, new Rect(0.0f, 32.0f, 32.0f, 32.0f), StaticValues.defPivot, 64.0f);
                icon2 = Sprite.Create(test, new Rect(0.0f, 0.0f, 32.0f, 32.0f), StaticValues.defPivot, 64.0f);
            }
            this.backSpriteHeight = backSpriteHeight;
        }
    }
    public PokemonGraphics graphics;
    public PokemonGraphics gMaxGraphics;

    public AudioClip Cry;

    public bool genderDifferences;

    public PokedexData pokedexData;

    public Ability[] abilities;
    public TMLearnsetData tmLearnset;

    private static string Strip(string path) => path.Split(new char[] { '/' })[0];

    public static SpeciesData OverwriteAbility(SpeciesData baseSpecies, Ability ability)
    {
        SpeciesData copy = baseSpecies;
        copy.abilities = new[] { ability, ability, ability };
        return copy;
    }

    public SpeciesData(string speciesName, Type type1, Type type2,
        byte baseHP, byte baseAttack, byte baseDefense, byte baseSpAtk,
        byte baseSpDef, byte baseSpeed, ushort evYield, EvolutionData[] evolution,
        XPClass xpClass, int xpYield, LearnsetMove[] learnset, TMLearnsetData tmLearnset, int malePercent,
        EggGroup eggGroup1, EggGroup eggGroup2, int eggCycles, int catchRate,
        string graphicsLocation, string cryLocation, int backSpriteHeight,
        PokedexData pokedexData, Ability[] abilities, bool genderDifferences = false,
        byte baseFriendship = 70, SpeciesID redirect = SpeciesID.Missingno, string gMaxPath = "",
        int gMaxBackHeight = 0, SpeciesFlags flags = SpeciesFlags.None)
    {
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
        this.malePercent = malePercent;
        this.eggGroup1 = eggGroup1;
        this.eggGroup2 = eggGroup2;
        this.eggCycles = eggCycles;
        this.catchRate = catchRate;
        this.tmLearnset = tmLearnset;
        graphics = new(graphicsLocation, backSpriteHeight);
        if (gMaxPath == "") gMaxGraphics = graphics;
        else gMaxGraphics = new(gMaxPath, gMaxBackHeight);
        Cry = Resources.Load<AudioClip>("Sound/Cries/" + cryLocation);
        this.genderDifferences = genderDifferences;
        this.pokedexData = pokedexData;
        this.abilities = abilities;
        this.baseFriendship = baseFriendship;
        dexRedirect = redirect;
        if (flags == SpeciesFlags.None)
        {
            speciesFlags = evolution == Evolution.None ? SpeciesFlags.None : SpeciesFlags.NotFullyEvolved;
        }
        else speciesFlags = flags;
    }

    //Pikachu forms
    public static SpeciesData PikachuCap(string capName) => new(
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
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 112,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs,
        malePercent: 100,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pikachu", //Verify
        graphicsLocation: "pikachu/" + capName + "_cap", //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Pikachu,
        abilities: new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        }
    );

    public static SpeciesData PikachuCosplay(string graphicsSubfolder) => new
    (
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
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 112,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs,
        malePercent: 0,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pikachu", //Verify
        graphicsLocation: "pikachu/" + graphicsSubfolder, //Verify
        backSpriteHeight: 4,
        pokedexData: Pokedex.Pikachu,
        abilities: new[]
        {
            Static,
            Static,
            LightningRod,
        }
    );

    //Pichu constructor
    public static SpeciesData Pichu(bool spikyEared) => new
    (
        speciesName: "Pichu",
        type1: Electric,
        type2: Electric,
        baseHP: 20,
        baseAttack: 40,
        baseDefense: 15,
        baseSpAtk: 35,
        baseSpDef: 35,
        baseSpeed: 60,
        evYield: Speed,
        evolution: spikyEared ? Evolution.None : Evolution.Pichu,
        xpClass: MediumFast,
        xpYield: 41,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs,
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "pichu", //Verify
        graphicsLocation: "pichu" + (spikyEared ? "/spiky_eared" : string.Empty), //Verify
        backSpriteHeight: 8,
        pokedexData: Pokedex.Pichu,
        abilities: new[]
    {
            Static,
            Static,
            LightningRod,
    }
    );

    //Unown constructor
    public static SpeciesData Unown(string path, int backSpriteHeight) => new
    (
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
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs,
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 40,
        catchRate: 225,
        baseFriendship: 50,
        cryLocation: "unown",
        graphicsLocation: path,
        backSpriteHeight: backSpriteHeight,
        pokedexData: Pokedex.Unown,
        abilities: new[]
        {
            Levitate,
            Levitate,
            Levitate,
    }
    );

    //Castform constructor

    public static SpeciesData Castform(Type type, string path, int backSpriteHeight) => new
    (
        speciesName: "Castform",
        type1: type,
        type2: type,
        baseHP: 70,
        baseAttack: 70,
        baseDefense: 70,
        baseSpAtk: 70,
        baseSpDef: 70,
        baseSpeed: 70,
        evYield: HP,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 147,
        catchRate: 45,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs,
        malePercent: 50,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 25,
        baseFriendship: 70,
        cryLocation: "castform",
        graphicsLocation: path,
        backSpriteHeight: backSpriteHeight,
        pokedexData: Pokedex.Castform,
        abilities: new[]
        {
            Forecast,
            Forecast,
            Forecast
    }
    );

    //Deoxys constructor
    public static SpeciesData Deoxys(byte baseHP, byte baseAttack,
        byte baseDefense, byte baseSpAtk, byte baseSpDef, byte baseSpeed,
        ushort evYield, string graphics, int backSpriteHeight) => new
        (
            speciesName: "Deoxys",
            type1: Psychic,
            type2: Psychic,
            baseHP: baseHP,
            baseAttack: baseAttack,
            baseDefense: baseDefense,
            baseSpAtk: baseSpAtk,
            baseSpDef: baseSpDef,
            baseSpeed: baseSpeed,
            evYield: evYield,
            evolution: Evolution.None,
            xpClass: Slow,
            xpYield: 270,
            catchRate: 3,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs,
            malePercent: Genderless,
            eggGroup1: EggGroup.Undiscovered,
            eggGroup2: EggGroup.Undiscovered,
            eggCycles: 120,
            baseFriendship: 0,
            cryLocation: "deoxys",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Deoxys,
            abilities: new[]
            {
                Pressure,
                Pressure,
                Pressure
            }
        );

    //Burmy constructor
    public static SpeciesData Burmy(string graphics,
        int backSpriteHeight, EvolutionData[] evolution) => new
        (
            speciesName: "Burmy",
            type1: Bug,
            type2: Bug,
            baseHP: 40,
            baseAttack: 29,
            baseDefense: 45,
            baseSpAtk: 29,
            baseSpDef: 45,
            baseSpeed: 36,
            evYield: SpDef,
            evolution: evolution,
            xpClass: MediumFast,
            xpYield: 45,
            learnset: EmptyLearnset, //Todo: Burmy's learnset
            tmLearnset: NoTMs, //Todo
            malePercent: 50,
            eggGroup1: EggGroup.Bug,
            eggGroup2: EggGroup.Bug,
            eggCycles: 15,
            catchRate: 120,
            baseFriendship: 70,
            cryLocation: "burmy",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Burmy,
            abilities: new[]
        {
            ShedSkin,
            ShedSkin,
            Overcoat
        }
        );

    //Shellos constructor
    public static SpeciesData Shellos(string graphics,
        int backSpriteHeight, EvolutionData[] evolution) => new
        (
            speciesName: "Shellos",
            type1: Water,
            type2: Water,
            baseHP: 76,
            baseAttack: 48,
            baseDefense: 48,
            baseSpAtk: 57,
            baseSpDef: 62,
            baseSpeed: 34,
            evYield: HP,
            evolution: evolution,
            xpClass: MediumFast,
            xpYield: 65,
            learnset: EmptyLearnset, //Todo: Shellos's learnset
            tmLearnset: NoTMs, //Todo
            malePercent: 50,
            eggGroup1: EggGroup.Water1,
            eggGroup2: EggGroup.Amorphous,
            eggCycles: 20,
            catchRate: 190,
            baseFriendship: 70,
            cryLocation: "shellos",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Shellos,
            abilities: new[]
            {
                StickyHold,
                StormDrain,
                SandForce,
            }
        );
    //Gastrodon constructor
    public static SpeciesData Gastrodon(string graphics,
        int backSpriteHeight) => new
        (
            speciesName: "Gastrodon",
            type1: Water,
            type2: Ground,
            baseHP: 111,
            baseAttack: 83,
            baseDefense: 68,
            baseSpAtk: 92,
            baseSpDef: 82,
            baseSpeed: 39,
            evYield: HP * 2,
            evolution: Evolution.None,
            xpClass: MediumFast,
            xpYield: 166,
            learnset: EmptyLearnset, //Todo: Gastrodon's learnset
            tmLearnset: NoTMs, //Todo
            malePercent: 50,
            eggGroup1: EggGroup.Water1,
            eggGroup2: EggGroup.Amorphous,
            eggCycles: 20,
            catchRate: 75,
            baseFriendship: 70,
            cryLocation: "gastrodon",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Gastrodon,
            abilities: new[]
            {
                StickyHold,
                StormDrain,
                SandForce,
            }
        );

    public static SpeciesData Wormadam(string graphics,
        Type type2, byte baseHP, byte baseAttack, byte baseDefense,
        byte baseSpAtk, byte baseSpDef, byte baseSpeed,
        ushort evYield, int backSpriteHeight) => new
        (
            speciesName: "Wormadam",
            type1: Bug,
            type2: type2,
            baseHP: baseHP,
            baseAttack: baseAttack,
            baseDefense: baseDefense,
            baseSpAtk: baseSpAtk,
            baseSpDef: baseSpDef,
            baseSpeed: baseSpeed,
            evYield: evYield,
            evolution: Evolution.None, //Not done
            xpClass: MediumFast,
            xpYield: 148,
            learnset: EmptyLearnset, //Todo: Wormadam's learnset
            tmLearnset: NoTMs, //Todo
            malePercent: 0,
            eggGroup1: EggGroup.Bug,
            eggGroup2: EggGroup.Bug,
            eggCycles: 15,
            catchRate: 45,
            baseFriendship: 70,
            cryLocation: "wormadam", //Verify
            graphicsLocation: graphics, //Verify
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Wormadam,
            abilities: new[]
            {
                Anticipation,
                Anticipation,
                Overcoat,
            }
        );

    //Cherrim constructor
    public static SpeciesData Cherrim(string graphics,
        int backSpriteHeight) => new
        (
            speciesName: "Cherrim",
            type1: Grass,
            type2: Grass,
            baseHP: 70,
            baseAttack: 60,
            baseDefense: 70,
            baseSpAtk: 87,
            baseSpDef: 78,
            baseSpeed: 85,
            evYield: SpAtk * 2,
            evolution: Evolution.None,
            xpClass: MediumFast,
            xpYield: 158,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs,
            malePercent: 50,
            eggGroup1: EggGroup.Fairy,
            eggGroup2: EggGroup.Grass,
            eggCycles: 20,
            catchRate: 75,
            baseFriendship: 70,
            cryLocation: "cherrim",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Cherrim,
            abilities: new[]
            {
                FlowerGift,
                FlowerGift,
                FlowerGift,
            }
        );

    //Rotom constructor
    public static SpeciesData RotomForm(Type type2, string graphics,
        int backSpriteHeight) => new
        (
            speciesName: "Rotom",
            type1: Electric,
            type2: type2,
            baseHP: 50,
            baseAttack: 65,
            baseDefense: 107,
            baseSpAtk: 105,
            baseSpDef: 107,
            baseSpeed: 86,
            evYield: Speed + SpAtk,
            evolution: Evolution.None,
            xpClass: MediumFast,
            xpYield: 182,
            learnset: EmptyLearnset, //Todo: Rotom's learnset
            tmLearnset: NoTMs, //Todo
            malePercent: Genderless,
            eggGroup1: EggGroup.Amorphous,
            eggGroup2: EggGroup.Amorphous,
            eggCycles: 20,
            catchRate: 45,
            baseFriendship: 70,
            cryLocation: "rotom",
            graphicsLocation: graphics,
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Rotom,
            abilities: new[]
            {
            Levitate,
            Levitate,
            Levitate,
            }
        );

    //Arceus constructor
    public static SpeciesData Arceus(Type type, string graphics) => new
    (
        speciesName: "Arceus",
        type1: type,
        type2: type,
        baseHP: 120,
        baseAttack: 120,
        baseDefense: 120,
        baseSpAtk: 120,
        baseSpDef: 120,
        baseSpeed: 120,
        evYield: 3 * HP,
        evolution: Evolution.None, //Not done
        xpClass: Slow,
        xpYield: 324,
        learnset: EmptyLearnset, //Todo: Arceus's learnset
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "arceus", //Verify
        graphicsLocation: graphics, //Verify
        backSpriteHeight: 3,
        pokedexData: Pokedex.Arceus,
        abilities: new[]
        {
            Multitype,
            Multitype,
            Multitype,
    }
    );

    //Gen 4 constructors for Origin forms

    public static SpeciesData Dialga(
        byte baseAttack, byte baseSpDef,
        string graphics, int backSpriteHeight) => new
        (
            speciesName: "Dialga",
            type1: Steel,
            type2: Dragon,
            baseHP: 100,
            baseAttack: baseAttack,
            baseDefense: 120,
            baseSpAtk: 150,
            baseSpDef: baseSpDef,
            baseSpeed: 90,
            evYield: 3 * SpAtk,
            evolution: Evolution.None, //Not done
            xpClass: Slow,
            xpYield: 306,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs, //Todo
            malePercent: Genderless,
            eggGroup1: EggGroup.Undiscovered,
            eggGroup2: EggGroup.Undiscovered,
            eggCycles: 120,
            catchRate: 3,
            baseFriendship: 0,
            cryLocation: "dialga", //Verify
            graphicsLocation: graphics, //Verify
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Dialga,
            abilities: new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            }
        );
    public static SpeciesData Palkia(
        byte baseAttack, byte baseSpeed,
        string graphics, int backSpriteHeight) => new
        (
            speciesName: "Palkia",
            type1: Water,
            type2: Dragon,
            baseHP: 90,
            baseAttack: baseAttack,
            baseDefense: 100,
            baseSpAtk: 150,
            baseSpDef: 120,
            baseSpeed: baseSpeed,
            evYield: 3 * SpAtk,
            evolution: Evolution.None, //Not done
            xpClass: Slow,
            xpYield: 306,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs, //Todo
            malePercent: Genderless,
            eggGroup1: EggGroup.Undiscovered,
            eggGroup2: EggGroup.Undiscovered,
            eggCycles: 120,
            catchRate: 3,
            baseFriendship: 0,
            cryLocation: "palkia", //Verify
            graphicsLocation: graphics, //Verify
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Palkia,
            abilities: new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            }
        );
    public static SpeciesData Giratina(
        byte baseAttack, byte baseSpAtk,
        byte baseDefense, byte baseSpDef,
        string graphics, int backSpriteHeight) => new
        (
            speciesName: "Giratina",
            type1: Ghost,
            type2: Dragon,
            baseHP: 150,
            baseAttack: baseAttack,
            baseDefense: baseDefense,
            baseSpAtk: baseSpAtk,
            baseSpDef: baseSpDef,
            baseSpeed: 90,
            evYield: 3 * HP,
            evolution: Evolution.None, //Not done
            xpClass: Slow,
            xpYield: 306,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs,
            malePercent: Genderless,
            eggGroup1: EggGroup.Undiscovered,
            eggGroup2: EggGroup.Undiscovered,
            eggCycles: 120,
            catchRate: 3,
            baseFriendship: 0,
            cryLocation: "giratina", //Verify
            graphicsLocation: graphics, //Verify
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Giratina,
            abilities: new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            }
        );

    //Shaymin constructor
    public static SpeciesData Shaymin(
        Type type2, Ability ability,
        byte baseHP, byte baseAttack, byte baseDefense,
        byte baseSpAtk, byte baseSpDef, byte baseSpeed,
        string cry, string graphics, int backSpriteHeight) => new
        (
            speciesName: "Shaymin",
            type1: Grass,
            type2: type2,
            baseHP: baseHP,
            baseAttack: baseAttack,
            baseDefense: baseDefense,
            baseSpAtk: baseSpAtk,
            baseSpDef: baseSpDef,
            baseSpeed: baseSpeed,
            evYield: 3 * HP,
            evolution: Evolution.None, //Not done
            xpClass: MediumSlow,
            xpYield: 270,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs, //Todo
            malePercent: Genderless,
            eggGroup1: EggGroup.Undiscovered,
            eggGroup2: EggGroup.Undiscovered,
            eggCycles: 120,
            catchRate: 45,
            baseFriendship: 100,
            cryLocation: cry, //Verify
            graphicsLocation: graphics, //Verify
            backSpriteHeight: backSpriteHeight,
            pokedexData: Pokedex.Shaymin,
            abilities: new[]
            {
                ability,
                ability,
                ability,
            }
        );

    //Basculin constructor

    public static SpeciesData Basculin(string graphics, Ability firstAbility,
        EvolutionData[] evolution) => new
        (
            speciesName: "Basculin",
            type1: Water,
            type2: Water,
            baseHP: 70,
            baseAttack: 92,
            baseDefense: 65,
            baseSpAtk: 80,
            baseSpDef: 55,
            baseSpeed: 98,
            evYield: 2 * Speed,
            evolution: evolution, //Not done
            xpClass: MediumFast,
            xpYield: 161,
            learnset: EmptyLearnset, //Not done
            tmLearnset: NoTMs, //Todo
            malePercent: 50,
            eggGroup1: EggGroup.Water2,
            eggGroup2: EggGroup.Water2,
            eggCycles: 40,
            catchRate: 25,
            baseFriendship: 70,
            cryLocation: "basculin", //Verify
            graphicsLocation: graphics,
            backSpriteHeight: 16, //Not done
            pokedexData: Pokedex.Basculin, //Not done
            abilities: new[]
            {
                firstAbility,
                Adaptability,
                MoldBreaker,
            }
        );

    //Deerling constructor
    public static SpeciesData Deerling(string graphics, EvolutionData[] evolution) => new
    (
        speciesName: "Deerling",
        type1: Grass,
        type2: Grass,
        baseHP: 60,
        baseAttack: 60,
        baseDefense: 50,
        baseSpAtk: 40,
        baseSpDef: 50,
        baseSpeed: 75,
        evYield: Speed,
        evolution: evolution,
        xpClass: MediumFast,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "deerling",
        graphicsLocation: graphics,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Deerling, //Not done
        abilities: new[]
        {
            Chlorophyll,
            SapSipper,
            SereneGrace,
    }
    );

    //Sawsbuck constructor
    public static SpeciesData Sawsbuck(string graphics) => new
    (
        speciesName: "Sawsbuck",
        type1: Grass,
        type2: Grass,
        baseHP: 80,
        baseAttack: 100,
        baseDefense: 70,
        baseSpAtk: 60,
        baseSpDef: 70,
        baseSpeed: 95,
        evYield: Attack * 2,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 75,
        baseFriendship: 70,
        cryLocation: "sawsbuck",
        graphicsLocation: graphics,
        backSpriteHeight: 5,
        pokedexData: Pokedex.Sawsbuck, //Not done
        abilities: new[]
        {
            Chlorophyll,
            SapSipper,
            SereneGrace
    }
    );

    //Keldeo constructor
    public static SpeciesData Keldeo(bool resolute) => new
    (
        speciesName: "Keldeo",
        type1: Water,
        type2: Fighting,
        baseHP: 91,
        baseAttack: 72,
        baseDefense: 90,
        baseSpAtk: 129,
        baseSpDef: 90,
        baseSpeed: 108,
        evYield: 3 * SpAtk,
        evolution: Evolution.None, //Not done
        xpClass: Slow,
        xpYield: 261,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 80,
        catchRate: 3,
        baseFriendship: 35,
        cryLocation: "keldeo", //Verify
        graphicsLocation: resolute ? "keldeo/resolute" : "keldeo", //Verify
        backSpriteHeight: resolute ? 3 : 4,
        pokedexData: Pokedex.Keldeo, //Not done
        abilities: new[]
        {
            Justified,
            Justified,
            Justified,
    }
    );

    //Genesect constructor
    public static SpeciesData Genesect(string graphics) => new
    (
        speciesName: "Genesect",
        type1: Bug,
        type2: Steel,
        baseHP: 71,
        baseAttack: 120,
        baseDefense: 95,
        baseSpAtk: 120,
        baseSpDef: 95,
        baseSpeed: 99,
        evYield: Attack + SpAtk + Speed,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "genesect",
        graphicsLocation: graphics,
        backSpriteHeight: 8,
        pokedexData: Pokedex.Genesect,
        abilities: new[]
        {
            Download,
            Download,
            Download
    }
    );

    //Scatterbug line constructors

    public static SpeciesData Scatterbug(SpeciesID nextEvo) => new
    (
        speciesName: "Scatterbug",
        type1: Bug,
        type2: Bug,
        baseHP: 38,
        baseAttack: 35,
        baseDefense: 40,
        baseSpAtk: 27,
        baseSpDef: 25,
        baseSpeed: 35,
        evYield: Defense,
        evolution: EvolutionData.LevelEvolution(9, nextEvo), //Not done
        xpClass: MediumFast,
        xpYield: 40,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 255,
        baseFriendship: 70,
        cryLocation: "scatterbug", //Verify
        graphicsLocation: "scatterbug", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Scatterbug, //Not done
        abilities: new[]
        {
            ShieldDust,
            CompoundEyes,
            FriendGuard,
    },
        redirect: SpeciesID.ScatterbugArchipelago
    );

    public static SpeciesData Spewpa(SpeciesID nextEvo) => new
    (
        speciesName: "Spewpa",
        type1: Bug,
        type2: Bug,
        baseHP: 45,
        baseAttack: 22,
        baseDefense: 60,
        baseSpAtk: 27,
        baseSpDef: 30,
        baseSpeed: 29,
        evYield: 2 * Defense,
        evolution: EvolutionData.LevelEvolution(12, nextEvo), //Not done
        xpClass: MediumFast,
        xpYield: 75,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "spewpa", //Verify
        graphicsLocation: "spewpa", //Verify
        backSpriteHeight: 12,
        pokedexData: Pokedex.Spewpa,
        abilities: new[]
        {
            ShedSkin,
            ShedSkin,
            FriendGuard,
    },
        redirect: SpeciesID.ScatterbugArchipelago
    );

    public static SpeciesData Vivillon(string graphicsSubfolder) => new
    (
        speciesName: "Vivillon",
        type1: Bug,
        type2: Flying,
        baseHP: 80,
        baseAttack: 52,
        baseDefense: 50,
        baseSpAtk: 90,
        baseSpDef: 50,
        baseSpeed: 89,
        evYield: HP + Speed + SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 185,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Bug,
        eggGroup2: EggGroup.Bug,
        eggCycles: 15,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "vivillon",
        graphicsLocation: "vivillon/" + graphicsSubfolder,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Vivillon,
        abilities: new[]
        {
            ShieldDust,
            CompoundEyes,
            FriendGuard
    }
    );

    //Flabébé line constructors
    public static SpeciesData Flabebe(SpeciesID nextEvo, string graphicsSubfolder) => new
    (
        speciesName: "Flabébé",
        type1: Fairy,
        type2: Fairy,
        baseHP: 44,
        baseAttack: 38,
        baseDefense: 39,
        baseSpAtk: 61,
        baseSpDef: 79,
        baseSpeed: 42,
        evYield: SpDef,
        evolution: EvolutionData.LevelEvolution(19, nextEvo),
        xpClass: MediumFast,
        xpYield: 61,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 225,
        baseFriendship: 70,
        cryLocation: "flabebe",
        graphicsLocation: "flabebe/" + graphicsSubfolder,
        backSpriteHeight: 12,
        pokedexData: Pokedex.Flabebe,
        abilities: new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
    }
    );

    public static SpeciesData Floette(SpeciesID nextEvo, string graphicsSubfolder, bool eternal = false) => new
    (
        speciesName: "Floette",
        type1: Fairy,
        type2: Fairy,
        baseHP: 54,
        baseAttack: 45,
        baseDefense: 47,
        baseSpAtk: 75,
        baseSpDef: 98,
        baseSpeed: 52,
        evYield: SpDef * 2,
        evolution: eternal ? Evolution.None :
            EvolutionData.ItemEvolution(ItemID.ShinyStone, nextEvo),
        xpClass: MediumFast,
        xpYield: 130,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "floette",
        graphicsLocation: "floette/" + graphicsSubfolder,
        backSpriteHeight: 2,
        pokedexData: Pokedex.Floette,
        abilities: new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
    }
    );

    public static SpeciesData Florges(string graphicsSubfolder) => new
    (
        speciesName: "Florges",
        type1: Fairy,
        type2: Fairy,
        baseHP: 78,
        baseAttack: 65,
        baseDefense: 68,
        baseSpAtk: 112,
        baseSpDef: 154,
        baseSpeed: 75,
        evYield: SpDef * 3,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 248,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "florges",
        graphicsLocation: "florges/" + graphicsSubfolder,
        backSpriteHeight: 9,
        pokedexData: Pokedex.Florges,
        abilities: new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
    }
    );

    public static SpeciesData Furfrou(string graphicsSubfolder, bool backSprite0 = false) => new
    (
        speciesName: "Furfrou",
        type1: Normal,
        type2: Normal,
        baseHP: 75,
        baseAttack: 80,
        baseDefense: 60,
        baseSpAtk: 65,
        baseSpDef: 90,
        baseSpeed: 102,
        evYield: Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 165,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 20,
        catchRate: 160,
        baseFriendship: 70,
        cryLocation: "furfrou",
        graphicsLocation: "furfrou/" + graphicsSubfolder,
        backSpriteHeight: backSprite0 ? 0 : 1,
        pokedexData: Pokedex.Furfrou,
        abilities: new[]
        {
            FurCoat,
            FurCoat,
            FurCoat
    }
    );

    //Aegislash constructor
    public static SpeciesData Aegislash(bool blade) => new
    (
        speciesName: "Aegislash",
        type1: Steel,
        type2: Ghost,
        baseHP: 60,
        baseAttack: (byte)(blade ? 140 : 50),
        baseDefense: (byte)(blade ? 50 : 140),
        baseSpAtk: (byte)(blade ? 140 : 50),
        baseSpDef: (byte)(blade ? 50 : 140),
        baseSpeed: 60,
        evYield: 2 * Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 234,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "aegislash",
        graphicsLocation: "aegislash" + (blade ? "/blade" : string.Empty),
        backSpriteHeight: 9,
        pokedexData: Pokedex.Aegislash,
        abilities: new[]
        {
            StanceChange,
            StanceChange,
            StanceChange
    }
    );

    //Pumpkaboo line constructors

    public static SpeciesData Pumpkaboo(byte baseHP, byte baseSpeed, SpeciesID nextEvo,
    string graphicsSubfolder, int backSpriteHeight) => new
    (
        speciesName: "Pumpkaboo",
        type1: Ghost,
        type2: Grass,
        baseHP: baseHP,
        baseAttack: 66,
        baseDefense: 70,
        baseSpAtk: 44,
        baseSpDef: 55,
        baseSpeed: baseSpeed,
        evYield: Defense,
        evolution: EvolutionData.TradeEvolution(nextEvo),
        xpClass: MediumFast,
        xpYield: 67,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 120,
        baseFriendship: 70,
        cryLocation: "pumpkaboo",
        graphicsLocation: "pumpkaboo/" + graphicsSubfolder,
        backSpriteHeight: backSpriteHeight,
        pokedexData: Pokedex.Pumpkaboo,
        abilities: new[]
        {
            Pickup,
            Frisk,
            Insomnia,
        }
    );

    public static SpeciesData Gourgeist(byte baseHP, byte baseAttack, byte baseSpeed,
    string graphicsSubfolder, int backSpriteHeight) => new
    (
        speciesName: "Gourgeist",
        type1: Ghost,
        type2: Grass,
        baseHP: baseHP,
        baseAttack: baseAttack,
        baseDefense: 122,
        baseSpAtk: 58,
        baseSpDef: 75,
        baseSpeed: baseSpeed,
        evYield: Defense * 2,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        baseFriendship: 70,
        cryLocation: "gourgeist",
        graphicsLocation: "gourgeist/" + graphicsSubfolder,
        backSpriteHeight: backSpriteHeight,
        pokedexData: Pokedex.Gourgeist,
        abilities: new[]
        {
                Pickup,
                Frisk,
                Insomnia,
        }
    );

    //Xerneas constructor
    public static SpeciesData Xerneas(string graphics) => new
    (
        speciesName: "Xerneas",
        type1: Fairy,
        type2: Fairy,
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
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 45,
        baseFriendship: 0,
        cryLocation: "xerneas",
        graphicsLocation: graphics,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Xerneas,
        abilities: new[]
        {
            FairyAura,
            FairyAura,
            FairyAura
    }
    );

    //Oricorio constructor
    public static SpeciesData Oricorio(Type type1, string graphicsSubfolder) => new
    (
        speciesName: "Oricorio",
        type1: type1,
        type2: Flying,
        baseHP: 75,
        baseAttack: 70,
        baseDefense: 70,
        baseSpAtk: 98,
        baseSpDef: 70,
        baseSpeed: 93,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 167,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 25,
        eggGroup1: EggGroup.Flying,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "oricorio_" + graphicsSubfolder,
        graphicsLocation: "oricorio/" + graphicsSubfolder,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Oricorio,
        abilities: new[]
        {
            Dancer,
            Dancer,
            Dancer
    }
    );

    //Rockruff constructor
    public static SpeciesData Rockruff(Ability[] abilities, EvolutionData[] evolution) => new
    (
        speciesName: "Rockruff",
        type1: Rock,
        type2: Rock,
        baseHP: 45,
        baseAttack: 65,
        baseDefense: 40,
        baseSpAtk: 30,
        baseSpDef: 40,
        baseSpeed: 60,
        evYield: Attack,
        evolution: evolution,
        xpClass: MediumFast,
        xpYield: 56,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Field,
        eggCycles: 15,
        catchRate: 190,
        baseFriendship: 70,
        cryLocation: "rockruff",
        graphicsLocation: "rockruff",
        backSpriteHeight: 7,
        pokedexData: Pokedex.Rockruff,
        abilities: abilities,
        redirect: SpeciesID.RockruffNormal
    );

    //Silvally constructor
    public static SpeciesData Silvally(Type type, string graphicsSubfolder) => new
    (
        speciesName: "Silvally",
        type1: type,
        type2: type,
        baseHP: 95,
        baseAttack: 95,
        baseDefense: 95,
        baseSpAtk: 95,
        baseSpDef: 95,
        baseSpeed: 95,
        evYield: 3 * HP,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 257,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "silvally",
        graphicsLocation: "silvally/" + graphicsSubfolder,
        backSpriteHeight: 0,
        pokedexData: Pokedex.Silvally,
        abilities: new[]
        {
            RKSSystem,
            RKSSystem,
            RKSSystem
    }
    );

    //Minior constructor
    public static SpeciesData Minior(bool core, string graphicsSubfolder = "") => new
    (
        speciesName: "Minior",
        type1: Rock,
        type2: Flying,
        baseHP: 60,
        baseAttack: (byte)(core ? 100 : 60),
        baseDefense: (byte)(core ? 60 : 100),
        baseSpAtk: (byte)(core ? 100 : 60),
        baseSpDef: (byte)(core ? 60 : 100),
        baseSpeed: (byte)(core ? 120 : 60),
        evYield: Defense + SpDef,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 154,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Mineral,
        eggCycles: 25,
        catchRate: 30,
        baseFriendship: 70,
        cryLocation: "minior",
        graphicsLocation: core ? "minior/core/" + graphicsSubfolder : "minior",
        backSpriteHeight: core ? 15 : 14,
        pokedexData: Pokedex.Minior,
        abilities: new[]
        {
            ShieldsDown,
            ShieldsDown,
            ShieldsDown
    }
    );

    //Mimikyu constructor
    public static SpeciesData Mimikyu(bool busted) => new
    (
        speciesName: "Mimikyu",
        type1: Ghost,
        type2: Fairy,
        baseHP: 55,
        baseAttack: 90,
        baseDefense: 80,
        baseSpAtk: 50,
        baseSpDef: 105,
        baseSpeed: 96,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 167,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Amorphous,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 45,
        baseFriendship: 70,
        cryLocation: "mimikyu",
        graphicsLocation: "mimikyu" + (busted ? "/busted" : string.Empty),
        backSpriteHeight: busted ? 15 : 7,
        pokedexData: Pokedex.Mimikyu,
        abilities: new[]
        {
            Disguise,
            Disguise,
            Disguise
    }
    );

    //Magearna constructor
    public static SpeciesData Magearna(bool original) => new
    (
        speciesName: "Magearna",
        type1: Steel,
        type2: Fairy,
        baseHP: 80,
        baseAttack: 95,
        baseDefense: 115,
        baseSpAtk: 130,
        baseSpDef: 115,
        baseSpeed: 65,
        evYield: 3 * SpAtk,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 270,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        baseFriendship: 0,
        cryLocation: "magearna",
        graphicsLocation: "magearna" + (original ? "/original_color" : string.Empty),
        backSpriteHeight: 5,
        pokedexData: Pokedex.Magearna,
        abilities: new[]
        {
            SoulHeart,
            SoulHeart,
            SoulHeart
    }
    );

    //Cramorant constructor
    public static SpeciesData Cramorant(int whichForm) => new
    (
        speciesName: "Cramorant",
        type1: Flying,
        type2: Water,
        baseHP: 70,
        baseAttack: 85,
        baseDefense: 55,
        baseSpAtk: 85,
        baseSpDef: 95,
        baseSpeed: 85,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 166,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Water1,
        eggGroup2: EggGroup.Flying,
        eggCycles: 20,
        catchRate: 45,
        cryLocation: "cramorant",
        graphicsLocation: "cramorant" + whichForm switch
        {
            0 => string.Empty,
            1 => "/gulping",
            2 => "/gorging",
            _ => throw new Exception("Passed bad argument to Cramorant constructor")
        },
        backSpriteHeight: 1,
        pokedexData: Pokedex.Cramorant,
        abilities: new[]
        {
            GulpMissile,
            GulpMissile,
            GulpMissile
    }
    );

    //Toxtricity constructor
    public static SpeciesData Toxtricity(bool lowKey) => new
    (
        speciesName: "Toxtricity",
        type1: Electric,
        type2: Poison,
        baseHP: 75,
        baseAttack: 98,
        baseDefense: 70,
        baseSpAtk: 114,
        baseSpDef: 70,
        baseSpeed: 75,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumSlow,
        xpYield: 176,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.HumanLike,
        eggGroup2: EggGroup.HumanLike,
        eggCycles: 25,
        catchRate: 45,
        cryLocation: "toxtricity",
        graphicsLocation: "toxtricity" + (lowKey ? "/low_key" : string.Empty),
        backSpriteHeight: 0,
        gMaxPath: "toxtricity/gmax",
        gMaxBackHeight: 0,
        pokedexData: Pokedex.Toxtricity,
        abilities: new[]
        {
            lowKey ? Minus : Plus,
            lowKey ? Minus : Plus,
            lowKey ? Minus : Plus
    }
    );

    //Sinistea constructor
    public static SpeciesData Sinistea(bool genuine) => new
    (
        speciesName: "Sinistea",
        type1: Ghost,
        type2: Ghost,
        baseHP: 40,
        baseAttack: 45,
        baseDefense: 45,
        baseSpAtk: 74,
        baseSpDef: 54,
        baseSpeed: 50,
        evYield: SpAtk,
        evolution: genuine ?
            EvolutionData.ItemEvolution(ItemID.ChippedPot, SpeciesID.PolteageistAntique) :
            EvolutionData.ItemEvolution(ItemID.CrackedPot, SpeciesID.Polteageist),
        xpClass: MediumFast,
        xpYield: 62,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 120,
        cryLocation: "sinistea",
        graphicsLocation: "sinistea",
        backSpriteHeight: 16,
        pokedexData: Pokedex.Sinistea,
        abilities: new[]
        {
            WeakArmor,
            WeakArmor,
            CursedBody
    },
        redirect: SpeciesID.Sinistea
    );

    //Polteageist constructor
    public static SpeciesData Polteageist(bool genuine) => new
    (
        speciesName: "Polteageist",
        type1: Ghost,
        type2: Ghost,
        baseHP: 60,
        baseAttack: 65,
        baseDefense: 65,
        baseSpAtk: 134,
        baseSpDef: 114,
        baseSpeed: 70,
        evYield: 2 * SpAtk,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 178,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Mineral,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 60,
        cryLocation: "polteageist",
        graphicsLocation: "polteageist",
        backSpriteHeight: 13,
        pokedexData: Pokedex.Polteageist,
        abilities: new[]
        {
            WeakArmor,
            WeakArmor,
            CursedBody
    },
        redirect: SpeciesID.Polteageist
    );

    //Alcremie constructor
    public static SpeciesData Alcremie(string path = "") => new
    (
        speciesName: "Alcremie",
        type1: Fairy,
        type2: Fairy,
        baseHP: 65,
        baseAttack: 60,
        baseDefense: 75,
        baseSpAtk: 110,
        baseSpDef: 121,
        baseSpeed: 64,
        evYield: 2 * SpDef,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 173,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 0,
        eggGroup1: EggGroup.Fairy,
        eggGroup2: EggGroup.Amorphous,
        eggCycles: 20,
        catchRate: 100,
        cryLocation: "alcremie",
        graphicsLocation: path is "" ? "alcremie" : "alcremie/" + path,
        backSpriteHeight: 9,
        gMaxPath: "alcremie/gmax",
        gMaxBackHeight: 9,
        pokedexData: Pokedex.Alcremie, //Not done
        abilities: new[]
        {
            SweetVeil,
            SweetVeil,
            AromaVeil
    }
    );

    //Morpeko constructor
    public static SpeciesData Morpeko(bool hangry) => new
    (
        speciesName: "Morpeko",
        type1: Electric,
        type2: Dark,
        baseHP: 58,
        baseAttack: 95,
        baseDefense: 58,
        baseSpAtk: 70,
        baseSpDef: 58,
        baseSpeed: 97,
        evYield: 2 * Speed,
        evolution: Evolution.None,
        xpClass: MediumFast,
        xpYield: 153,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: 50,
        eggGroup1: EggGroup.Field,
        eggGroup2: EggGroup.Fairy,
        eggCycles: 10,
        catchRate: 180,
        cryLocation: "morpeko",
        graphicsLocation: "morpeko" + (hangry ? "/hangry" : string.Empty),
        backSpriteHeight: 8,
        pokedexData: Pokedex.Morpeko, //Not done
        abilities: new[]
        {
            HungerSwitch,
            HungerSwitch,
            HungerSwitch
    }
    );

    //Zarude constructor
    public static SpeciesData Zarude(bool dada) => new
    (
        speciesName: "Zarude",
        type1: Dark,
        type2: Grass,
        baseHP: 105,
        baseAttack: 120,
        baseDefense: 105,
        baseSpAtk: 70,
        baseSpDef: 95,
        baseSpeed: 105,
        evYield: 3 * Attack,
        evolution: Evolution.None,
        xpClass: Slow,
        xpYield: 300,
        learnset: EmptyLearnset, //Not done
        tmLearnset: NoTMs, //Todo
        malePercent: Genderless,
        eggGroup1: EggGroup.Undiscovered,
        eggGroup2: EggGroup.Undiscovered,
        eggCycles: 120,
        catchRate: 3,
        cryLocation: "zarude",
        graphicsLocation: "zarude" + (dada ? "/dada" : string.Empty),
        backSpriteHeight: 5,
        pokedexData: Pokedex.Zarude, //Not done
        abilities: new[]
        {
            LeafGuard,
            LeafGuard,
            LeafGuard
        }
    );

    //Mega constructor

    public static SpeciesData Mega(SpeciesData baseSpecies,
    byte baseAttack, byte baseDefense, byte baseSpAtk, byte baseSpDef, byte baseSpeed,
    int backSpriteHeight, PokedexData pokedexData, Ability ability,
    string cry = "", string graphics = "",
    Type type1 = Typeless, Type type2 = Typeless, string name = "") => new
     (
         speciesName: name == string.Empty ? "Mega " + baseSpecies.speciesName : name,
         type1: type1 == Typeless ? baseSpecies.type1 : type1,
         type2: type2 == Typeless ? baseSpecies.type2 : type2,
         baseHP: baseSpecies.baseHP,
         baseAttack: baseAttack,
         baseDefense: baseDefense,
         baseSpAtk: baseSpAtk,
         baseSpDef: baseSpDef,
         baseSpeed: baseSpeed,
         evYield: baseSpecies.evYield,
         evolution: baseSpecies.evolution,
         xpClass: baseSpecies.xpClass,
         xpYield: baseSpecies.xpYield,
         learnset: baseSpecies.learnset,
         tmLearnset: baseSpecies.tmLearnset,
         malePercent: baseSpecies.malePercent,
         eggGroup1: baseSpecies.eggGroup1,
         eggGroup2: baseSpecies.eggGroup2,
         eggCycles: baseSpecies.eggCycles,
         catchRate: baseSpecies.catchRate,
         baseFriendship: baseSpecies.baseFriendship,
         cryLocation: cry == "" ? "mega_" + baseSpecies.speciesName.ToLower() : cry,
         graphicsLocation: graphics == "" ? baseSpecies.speciesName.ToLower() + "/mega" : graphics,
         backSpriteHeight: backSpriteHeight,
         pokedexData: pokedexData,
         abilities: new[]
         {
                 ability,
                 ability,
                 ability,
         },
         flags: SpeciesFlags.MegaEvolved
     );

    public static SpeciesID[] SingleSpecies(SpeciesID species) =>
        new SpeciesID[1] { species };
}