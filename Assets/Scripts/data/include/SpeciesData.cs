using System;
using System.Drawing;
using Unity.VisualScripting;
using static EvYield;
using static Type;
using static XPClass;
using static Ability;
using static Learnset;
using UnityEngine;

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
    public byte baseFriendship;

    public string cryLocation;

    public string graphicsLocation;
    public int backSpriteHeight;

    public bool genderDifferences;

    public PokedexData pokedexData;

    public Ability[] abilities;


    public Sprite BackSprite => Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/back"),
        new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);

    public Sprite FrontSprite1
    {
        get
        {
            Texture2D test = Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/anim_front");
            if (test == null)
            {
                return Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/front"),
                    new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            }
            else
            {
                return Sprite.Create(test, new Rect(0.0f, 64.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            }
        }
    }

    public Sprite FrontSprite2
    {
        get
        {
            Texture2D test = Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/anim_front");
            if (test == null)
            {
                return Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/front"),
                    new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            }
            else
            {
                return Sprite.Create(test, new Rect(0.0f, 0.0f, 64.0f, 64.0f), StaticValues.defPivot, 64.0f);
            }
        }
    }

    public Sprite Icon => Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + graphicsLocation + "/icon"),
        new Rect(0.0f, 0.0f, 16.0f, 16.0f), StaticValues.defPivot, 64.0f);

    public AudioClip Cry => Resources.Load<AudioClip>("Sound/Cries/" + cryLocation);

    public static SpeciesData OverwriteAbility(SpeciesData baseSpecies, Ability ability)
    {
        SpeciesData copy = baseSpecies;
        copy.abilities = new[] { ability, ability, ability };
        return copy;
    }

    //Pikachu forms
    public static SpeciesData PikachuCap(string capName) => new()
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
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 112,
        learnset = EmptyLearnset, //Not done
        malePercent = 100,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "pikachu", //Verify
        graphicsLocation = "pikachu/" + capName + "_cap", //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Pikachu,
        abilities = new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        },
    };

    public static SpeciesData PikachuCosplay(string graphicsSubfolder) => new()
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
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 112,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 10,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "pikachu", //Verify
        graphicsLocation = "pikachu/" + graphicsSubfolder, //Verify
        backSpriteHeight = 4,
        pokedexData = Pokedex.Pikachu,
        abilities = new Ability[3]
        {
            Static,
            Static,
            LightningRod,
        },
    };

    //Pichu constructor
    public static SpeciesData Pichu(bool spikyEared) => new()
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
        evolution = spikyEared ? Evolution.None : Evolution.Pichu,
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
        graphicsLocation = "pichu" + (spikyEared ? "/spiky_eared" : string.Empty), //Verify
        backSpriteHeight = 8,
        pokedexData = Pokedex.Pichu,
        abilities = new Ability[3]
    {
            Static,
            Static,
            LightningRod,
    },
    };

    //Unown constructor
    public static SpeciesData Unown(string path, int backSpriteHeight) => new()
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
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 40,
        catchRate = 225,
        baseFriendship = 50,
        cryLocation = "unown",
        graphicsLocation = path,
        backSpriteHeight = backSpriteHeight,
        pokedexData = Pokedex.Unown,
        abilities = new[]
        {
            Levitate,
            Levitate,
            Levitate,
        },
    };

    //Castform constructor

    public static SpeciesData Castform(Type type, string path, int backSpriteHeight) => new()
    {
        speciesName = "Castform",
        type1 = type,
        type2 = type,
        baseHP = 70,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 70,
        baseSpDef = 70,
        baseSpeed = 70,
        evYield = HP,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 147,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 25,
        baseFriendship = 70,
        cryLocation = "castform",
        graphicsLocation = path,
        backSpriteHeight = backSpriteHeight,
        pokedexData = Pokedex.Castform,
        abilities = new[]
        {
            Forecast,
            Forecast,
            Forecast
        }
    };

    //Deoxys constructor
    public static SpeciesData Deoxys(int baseHP, int baseAttack,
        int baseDefense, int baseSpAtk, int baseSpDef, int baseSpeed,
        short evYield, string graphics, int backSpriteHeight) => new()
        {
            speciesName = "Deoxys",
            type1 = Psychic,
            type2 = Psychic,
            baseHP = baseHP,
            baseAttack = baseAttack,
            baseDefense = baseDefense,
            baseSpAtk = baseSpAtk,
            baseSpDef = baseSpDef,
            baseSpeed = baseSpeed,
            evYield = evYield,
            evolution = Evolution.None,
            xpClass = Slow,
            xpYield = 270,
            learnset = EmptyLearnset, //Not done
            malePercent = Genderless,
            eggGroup1 = EggGroup.Undiscovered,
            eggGroup2 = EggGroup.Undiscovered,
            eggCycles = 120,
            baseFriendship = 0,
            cryLocation = "deoxys",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Deoxys,
            abilities = new[]
            {
                Pressure,
                Pressure,
                Pressure
            }
        };

    //Burmy constructor
    public static SpeciesData Burmy(string graphics,
        int backSpriteHeight, EvolutionData[] evolution) => new()
        {
            speciesName = "Burmy",
            type1 = Bug,
            type2 = Bug,
            baseHP = 40,
            baseAttack = 29,
            baseDefense = 45,
            baseSpAtk = 29,
            baseSpDef = 45,
            baseSpeed = 36,
            evYield = SpDef,
            evolution = evolution,
            xpClass = MediumFast,
            xpYield = 45,
            learnset = EmptyLearnset, //Todo: Burmy's learnset
            malePercent = 50,
            eggGroup1 = EggGroup.Bug,
            eggGroup2 = EggGroup.Bug,
            eggCycles = 15,
            baseFriendship = 70,
            cryLocation = "burmy",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Burmy,
            abilities = new[]
        {
            ShedSkin,
            ShedSkin,
            Overcoat
        }
        };

    //Shellos constructor
    public static SpeciesData Shellos(string graphics,
        int backSpriteHeight, EvolutionData[] evolution) => new()
        {
            speciesName = "Shellos",
            type1 = Water,
            type2 = Water,
            baseHP = 76,
            baseAttack = 48,
            baseDefense = 48,
            baseSpAtk = 57,
            baseSpDef = 62,
            baseSpeed = 34,
            evYield = HP,
            evolution = evolution,
            xpClass = MediumFast,
            xpYield = 65,
            learnset = EmptyLearnset, //Todo: Shellos's learnset
            malePercent = 50,
            eggGroup1 = EggGroup.Water1,
            eggGroup2 = EggGroup.Amorphous,
            eggCycles = 20,
            baseFriendship = 70,
            cryLocation = "shellos",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Shellos,
            abilities = new[]
            {
                StickyHold,
                StormDrain,
                SandForce,
            }
        };
    //Gastrodon constructor
    public static SpeciesData Gastrodon(string graphics,
        int backSpriteHeight) => new()
        {
            speciesName = "Gastrodon",
            type1 = Water,
            type2 = Ground,
            baseHP = 111,
            baseAttack = 83,
            baseDefense = 68,
            baseSpAtk = 92,
            baseSpDef = 82,
            baseSpeed = 39,
            evYield = HP * 2,
            evolution = Evolution.None,
            xpClass = MediumFast,
            xpYield = 166,
            learnset = EmptyLearnset, //Todo: Gastrodon's learnset
            malePercent = 50,
            eggGroup1 = EggGroup.Water1,
            eggGroup2 = EggGroup.Amorphous,
            eggCycles = 20,
            baseFriendship = 70,
            cryLocation = "gastrodon",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Gastrodon,
            abilities = new[]
            {
                StickyHold,
                StormDrain,
                SandForce,
            }
        };

    public static SpeciesData Wormadam(string graphics,
        Type type2, int baseHP, int baseAttack, int baseDefense,
        int baseSpAtk, int baseSpDef, int baseSpeed,
        short evYield, int backSpriteHeight) => new()
        {
            speciesName = "Wormadam",
            type1 = Bug,
            type2 = type2,
            baseHP = baseHP,
            baseAttack = baseAttack,
            baseDefense = baseDefense,
            baseSpAtk = baseSpAtk,
            baseSpDef = baseSpDef,
            baseSpeed = baseSpeed,
            evYield = evYield,
            evolution = Evolution.None, //Not done
            xpClass = MediumFast,
            xpYield = 148,
            learnset = EmptyLearnset, //Todo: Wormadam's learnset
            malePercent = 0,
            eggGroup1 = EggGroup.Bug,
            eggGroup2 = EggGroup.Bug,
            eggCycles = 15,
            catchRate = 45,
            baseFriendship = 70,
            cryLocation = "wormadam", //Verify
            graphicsLocation = graphics, //Verify
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Wormadam,
            abilities = new[]
            {
                Anticipation,
                Anticipation,
                Overcoat,
            },
        };

    //Cherrim constructor
    public static SpeciesData Cherrim(string graphics,
        int backSpriteHeight) => new()
        {
            speciesName = "Cherrim",
            type1 = Grass,
            type2 = Grass,
            baseHP = 70,
            baseAttack = 60,
            baseDefense = 70,
            baseSpAtk = 87,
            baseSpDef = 78,
            baseSpeed = 85,
            evYield = SpAtk * 2,
            evolution = Evolution.None,
            xpClass = MediumFast,
            xpYield = 158,
            learnset = EmptyLearnset, //Not done
            malePercent = 50,
            eggGroup1 = EggGroup.Fairy,
            eggGroup2 = EggGroup.Grass,
            eggCycles = 20,
            catchRate = 75,
            baseFriendship = 70,
            cryLocation = "cherrim",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Cherrim,
            abilities = new[]
            {
                FlowerGift,
                FlowerGift,
                FlowerGift,
            }
        };

    //Rotom constructor
    public static SpeciesData RotomForm(Type type2, string graphics,
        int backSpriteHeight) => new()
        {
            speciesName = "Rotom",
            type1 = Electric,
            type2 = type2,
            baseHP = 50,
            baseAttack = 65,
            baseDefense = 107,
            baseSpAtk = 105,
            baseSpDef = 107,
            baseSpeed = 86,
            evYield = Speed + SpAtk,
            evolution = Evolution.None,
            xpClass = MediumFast,
            xpYield = 182,
            learnset = EmptyLearnset, //Todo: Rotom's learnset
            malePercent = Genderless,
            eggGroup1 = EggGroup.Amorphous,
            eggGroup2 = EggGroup.Amorphous,
            eggCycles = 20,
            catchRate = 45,
            baseFriendship = 70,
            cryLocation = "rotom",
            graphicsLocation = graphics,
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Rotom,
            abilities = new[]
            {
            Levitate,
            Levitate,
            Levitate,
            }
        };

    //Arceus constructor
    public static SpeciesData Arceus(Type type, string graphics) => new()
    {
        speciesName = "Arceus",
        type1 = type,
        type2 = type,
        baseHP = 120,
        baseAttack = 120,
        baseDefense = 120,
        baseSpAtk = 120,
        baseSpDef = 120,
        baseSpeed = 120,
        evYield = 3 * HP,
        evolution = Evolution.None, //Not done
        xpClass = Slow,
        xpYield = 324,
        learnset = EmptyLearnset, //Todo: Arceus's learnset
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "arceus", //Verify
        graphicsLocation = graphics, //Verify
        backSpriteHeight = 3,
        pokedexData = Pokedex.Arceus,
        abilities = new[]
        {
            Multitype,
            Multitype,
            Multitype,
        },
    };

    //Gen 4 constructors for Origin forms

    public static SpeciesData Dialga(
        int baseAttack, int baseSpDef,
        string graphics, int backSpriteHeight) => new()
        {
            speciesName = "Dialga",
            type1 = Steel,
            type2 = Dragon,
            baseHP = 100,
            baseAttack = baseAttack,
            baseDefense = 120,
            baseSpAtk = 150,
            baseSpDef = baseSpDef,
            baseSpeed = 90,
            evYield = 3 * SpAtk,
            evolution = Evolution.None, //Not done
            xpClass = Slow,
            xpYield = 306,
            learnset = EmptyLearnset, //Not done
            malePercent = Genderless,
            eggGroup1 = EggGroup.Undiscovered,
            eggGroup2 = EggGroup.Undiscovered,
            eggCycles = 120,
            catchRate = 3,
            baseFriendship = 0,
            cryLocation = "dialga", //Verify
            graphicsLocation = graphics, //Verify
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Dialga,
            abilities = new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            },
        };
    public static SpeciesData Palkia(
        int baseAttack, int baseSpeed,
        string graphics, int backSpriteHeight) => new()
        {
            speciesName = "Palkia",
            type1 = Water,
            type2 = Dragon,
            baseHP = 90,
            baseAttack = baseAttack,
            baseDefense = 100,
            baseSpAtk = 150,
            baseSpDef = 120,
            baseSpeed = baseSpeed,
            evYield = 3 * SpAtk,
            evolution = Evolution.None, //Not done
            xpClass = Slow,
            xpYield = 306,
            learnset = EmptyLearnset, //Not done
            malePercent = Genderless,
            eggGroup1 = EggGroup.Undiscovered,
            eggGroup2 = EggGroup.Undiscovered,
            eggCycles = 120,
            catchRate = 3,
            baseFriendship = 0,
            cryLocation = "palkia", //Verify
            graphicsLocation = graphics, //Verify
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Palkia,
            abilities = new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            },
        };
    public static SpeciesData Giratina(
        int baseAttack, int baseSpAtk,
        int baseDefense, int baseSpDef,
        string graphics, int backSpriteHeight) => new()
        {
            speciesName = "Giratina",
            type1 = Ghost,
            type2 = Dragon,
            baseHP = 150,
            baseAttack = baseAttack,
            baseDefense = baseDefense,
            baseSpAtk = baseSpAtk,
            baseSpDef = baseSpDef,
            baseSpeed = 90,
            evYield = 3 * HP,
            evolution = Evolution.None, //Not done
            xpClass = Slow,
            xpYield = 306,
            learnset = EmptyLearnset, //Not done
            malePercent = Genderless,
            eggGroup1 = EggGroup.Undiscovered,
            eggGroup2 = EggGroup.Undiscovered,
            eggCycles = 120,
            catchRate = 3,
            baseFriendship = 0,
            cryLocation = "giratina", //Verify
            graphicsLocation = graphics, //Verify
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Giratina,
            abilities = new[]
            {
                Pressure,
                Pressure,
                Telepathy,
            },
        };

    //Shaymin constructor
    public static SpeciesData Shaymin(
        Type type2, Ability ability,
        int baseHP, int baseAttack, int baseDefense,
        int baseSpAtk, int baseSpDef, int baseSpeed,
        string cry, string graphics, int backSpriteHeight) => new()
        {
            speciesName = "Shaymin",
            type1 = Grass,
            type2 = type2,
            baseHP = baseHP,
            baseAttack = baseAttack,
            baseDefense = baseDefense,
            baseSpAtk = baseSpAtk,
            baseSpDef = baseSpDef,
            baseSpeed = baseSpeed,
            evYield = 3 * HP,
            evolution = Evolution.None, //Not done
            xpClass = MediumSlow,
            xpYield = 270,
            learnset = EmptyLearnset, //Not done
            malePercent = Genderless,
            eggGroup1 = EggGroup.Undiscovered,
            eggGroup2 = EggGroup.Undiscovered,
            eggCycles = 120,
            catchRate = 45,
            baseFriendship = 100,
            cryLocation = cry, //Verify
            graphicsLocation = graphics, //Verify
            backSpriteHeight = backSpriteHeight,
            pokedexData = Pokedex.Shaymin,
            abilities = new[]
            {
                ability,
                ability,
                ability,
            },
        };

    //Basculin constructor

    public static SpeciesData Basculin(string graphics, Ability firstAbility,
        EvolutionData[] evolution) => new()
        {
            speciesName = "Basculin",
            type1 = Water,
            type2 = Water,
            baseHP = 70,
            baseAttack = 92,
            baseDefense = 65,
            baseSpAtk = 80,
            baseSpDef = 55,
            baseSpeed = 98,
            evYield = 2 * Speed,
            evolution = evolution, //Not done
            xpClass = MediumFast,
            xpYield = 161,
            learnset = EmptyLearnset, //Not done
            malePercent = 50,
            eggGroup1 = EggGroup.Water2,
            eggGroup2 = EggGroup.Water2,
            eggCycles = 40,
            catchRate = 25,
            baseFriendship = 70,
            cryLocation = "basculin", //Verify
            graphicsLocation = graphics,
            backSpriteHeight = 16, //Not done
            pokedexData = Pokedex.Basculin, //Not done
            abilities = new[]
            {
                firstAbility,
                Adaptability,
                MoldBreaker,
            },
        };

    //Deerling constructor
    public static SpeciesData Deerling(string graphics, EvolutionData[] evolution) => new()
    {
        speciesName = "Deerling",
        type1 = Grass,
        type2 = Grass,
        baseHP = 60,
        baseAttack = 60,
        baseDefense = 50,
        baseSpAtk = 40,
        baseSpDef = 50,
        baseSpeed = 75,
        evYield = Speed,
        evolution = evolution,
        xpClass = MediumFast,
        xpYield = 67,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "deerling",
        graphicsLocation = graphics,
        backSpriteHeight = 9,
        pokedexData = Pokedex.Deerling, //Not done
        abilities = new[]
        {
            Chlorophyll,
            SapSipper,
            SereneGrace,
        }
    };

    //Sawsbuck constructor
    public static SpeciesData Sawsbuck(string graphics) => new()
    {
        speciesName = "Sawsbuck",
        type1 = Grass,
        type2 = Grass,
        baseHP = 80,
        baseAttack = 100,
        baseDefense = 70,
        baseSpAtk = 60,
        baseSpDef = 70,
        baseSpeed = 95,
        evYield = Attack * 2,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 166,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 75,
        baseFriendship = 70,
        cryLocation = "sawsbuck",
        graphicsLocation = graphics,
        backSpriteHeight = 5,
        pokedexData = Pokedex.Sawsbuck, //Not done
        abilities = new[]
        {
            Chlorophyll,
            SapSipper,
            SereneGrace
        }
    };

    //Keldeo constructor
    public static SpeciesData Keldeo(string graphics) => new()
    {
        speciesName = "Keldeo",
        type1 = Water,
        type2 = Fighting,
        baseHP = 91,
        baseAttack = 72,
        baseDefense = 90,
        baseSpAtk = 129,
        baseSpDef = 90,
        baseSpeed = 108,
        evYield = 3 * SpAtk,
        evolution = Evolution.None, //Not done
        xpClass = Slow,
        xpYield = 261,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 80,
        catchRate = 3,
        baseFriendship = 35,
        cryLocation = "keldeo", //Verify
        graphicsLocation = graphics, //Verify
        backSpriteHeight = 0, //Not done
        pokedexData = Pokedex.Keldeo, //Not done
        abilities = new[]
        {
            Justified,
            Justified,
            Justified,
        },
    };

    //Genesect constructor
    public static SpeciesData Genesect(string graphics) => new()
    {
        speciesName = "Genesect",
        type1 = Bug,
        type2 = Steel,
        baseHP = 71,
        baseAttack = 120,
        baseDefense = 95,
        baseSpAtk = 120,
        baseSpDef = 95,
        baseSpeed = 99,
        evYield = Attack + SpAtk + Speed,
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
        cryLocation = "genesect",
        graphicsLocation = graphics,
        backSpriteHeight = 8,
        pokedexData = Pokedex.Genesect,
        abilities = new[]
        {
            Download,
            Download,
            Download
        }
    };

    //Scatterbug line constructors

    public static SpeciesData Scatterbug(SpeciesID nextEvo) => new()
    {
        speciesName = "Scatterbug",
        type1 = Bug,
        type2 = Bug,
        baseHP = 38,
        baseAttack = 35,
        baseDefense = 40,
        baseSpAtk = 27,
        baseSpDef = 25,
        baseSpeed = 35,
        evYield = Defense,
        evolution = EvolutionData.LevelEvolution(9, nextEvo), //Not done
        xpClass = MediumFast,
        xpYield = 40,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 255,
        baseFriendship = 70,
        cryLocation = "scatterbug", //Verify
        graphicsLocation = "scatterbug", //Verify
        backSpriteHeight = 0, //Not done
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            ShieldDust,
            CompoundEyes,
            FriendGuard,
        },
    };

    public static SpeciesData Spewpa(SpeciesID nextEvo) => new()
    {
        speciesName = "Spewpa",
        type1 = Bug,
        type2 = Bug,
        baseHP = 45,
        baseAttack = 22,
        baseDefense = 60,
        baseSpAtk = 27,
        baseSpDef = 30,
        baseSpeed = 29,
        evYield = 2 * Defense,
        evolution = EvolutionData.LevelEvolution(12, nextEvo), //Not done
        xpClass = MediumFast,
        xpYield = 75,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "spewpa", //Verify
        graphicsLocation = "spewpa", //Verify
        backSpriteHeight = 0, //Not done
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            ShedSkin,
            ShedSkin,
            FriendGuard,
        },
    };

    public static SpeciesData Vivillon(string graphicsSubfolder) => new()
    {
        speciesName = "Vivillon",
        type1 = Bug,
        type2 = Flying,
        baseHP = 80,
        baseAttack = 52,
        baseDefense = 50,
        baseSpAtk = 90,
        baseSpDef = 50,
        baseSpeed = 89,
        evYield = HP + Speed + SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 185,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Bug,
        eggGroup2 = EggGroup.Bug,
        eggCycles = 15,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "vivillon",
        graphicsLocation = "vivillon/" + graphicsSubfolder,
        backSpriteHeight = 0,
        pokedexData = Pokedex.Vivillon,
        abilities = new[]
        {
            ShieldDust,
            CompoundEyes,
            FriendGuard
        }
    };

    //Flabébé line constructors
    public static SpeciesData Flabebe(SpeciesID nextEvo, string graphicsSubfolder) => new()
    {
        speciesName = "Flabébé",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 44,
        baseAttack = 38,
        baseDefense = 39,
        baseSpAtk = 61,
        baseSpDef = 79,
        baseSpeed = 42,
        evYield = SpDef,
        evolution = EvolutionData.LevelEvolution(19, nextEvo),
        xpClass = MediumFast,
        xpYield = 61,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 225,
        baseFriendship = 70,
        cryLocation = "flabebe",
        graphicsLocation = "flabebe/" + graphicsSubfolder,
        backSpriteHeight = 12,
        pokedexData = Pokedex.Flabebe,
        abilities = new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
        }
    };

    public static SpeciesData Floette(SpeciesID nextEvo, string graphicsSubfolder, bool eternal = false) => new()
    {
        speciesName = "Floette",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 54,
        baseAttack = 45,
        baseDefense = 47,
        baseSpAtk = 75,
        baseSpDef = 98,
        baseSpeed = 52,
        evYield = SpDef * 2,
        evolution = eternal ? Evolution.None :
            EvolutionData.ItemEvolution(ItemID.ShinyStone, nextEvo),
        xpClass = MediumFast,
        xpYield = 130,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "floette",
        graphicsLocation = "floette/" + graphicsSubfolder,
        backSpriteHeight = 2,
        pokedexData = Pokedex.Floette,
        abilities = new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
        }
    };

    public static SpeciesData Florges(string graphicsSubfolder) => new()
    {
        speciesName = "Florges",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 78,
        baseAttack = 65,
        baseDefense = 68,
        baseSpAtk = 112,
        baseSpDef = 154,
        baseSpeed = 75,
        evYield = SpDef * 3,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 248,
        learnset = EmptyLearnset, //Not done
        malePercent = 0,
        eggGroup1 = EggGroup.Fairy,
        eggGroup2 = EggGroup.Fairy,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "florges",
        graphicsLocation = "florges/" + graphicsSubfolder,
        backSpriteHeight = 9,
        pokedexData = Pokedex.Florges,
        abilities = new[]
        {
            FlowerVeil,
            FlowerVeil,
            Symbiosis
        }
    };

    public static SpeciesData Furfrou(string graphicsSubfolder, bool backSprite0 = false) => new()
    {
        speciesName = "Furfrou",
        type1 = Normal,
        type2 = Normal,
        baseHP = 75,
        baseAttack = 80,
        baseDefense = 60,
        baseSpAtk = 65,
        baseSpDef = 90,
        baseSpeed = 102,
        evYield = Speed,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 165,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 20,
        catchRate = 160,
        baseFriendship = 70,
        cryLocation = "furfrou",
        graphicsLocation = "furfrou/" + graphicsSubfolder,
        backSpriteHeight = backSprite0 ? 0 : 1,
        pokedexData = Pokedex.Furfrou,
        abilities = new[]
        {
            FurCoat,
            FurCoat,
            FurCoat
        }
    };

    //Aegislash constructor
    public static SpeciesData Aegislash(bool blade) => new()
    {
        speciesName = "Aegislash",
        type1 = Steel,
        type2 = Ghost,
        baseHP = 60,
        baseAttack = blade ? 140 : 50,
        baseDefense = blade ? 50 : 140,
        baseSpAtk = blade ? 140 : 50,
        baseSpDef = blade ? 50 : 140,
        baseSpeed = 60,
        evYield = 2 * Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 234,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "aegislash",
        graphicsLocation = "aegislash" + (blade ? "/blade" : string.Empty),
        backSpriteHeight = 9,
        pokedexData = Pokedex.Aegislash,
        abilities = new[]
        {
            StanceChange,
            StanceChange,
            StanceChange
        }
    };

    //Pumpkaboo line constructors

    public static SpeciesData Pumpkaboo(int baseHP, int baseSpeed, SpeciesID nextEvo,
    string graphicsSubfolder, int backSpriteHeight) => new()
    {
        speciesName = "Pumpkaboo",
        type1 = Ghost,
        type2 = Grass,
        baseHP = baseHP,
        baseAttack = 66,
        baseDefense = 70,
        baseSpAtk = 44,
        baseSpDef = 55,
        baseSpeed = baseSpeed,
        evYield = Defense,
        evolution = EvolutionData.TradeEvolution(nextEvo),
        xpClass = MediumFast,
        xpYield = 67,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 120,
        baseFriendship = 70,
        cryLocation = "pumpkaboo",
        graphicsLocation = "pumpkaboo/" + graphicsSubfolder,
        backSpriteHeight = backSpriteHeight,
        pokedexData = Pokedex.Pumpkaboo,
        abilities = new[]
        {
            Pickup,
            Frisk,
            Insomnia,
        }
    };

    public static SpeciesData Gourgeist(int baseHP, int baseAttack, int baseSpeed,
    string graphicsSubfolder, int backSpriteHeight) => new()
    {
        speciesName = "Pumpkaboo",
        type1 = Ghost,
        type2 = Grass,
        baseHP = baseHP,
        baseAttack = baseAttack,
        baseDefense = 122,
        baseSpAtk = 58,
        baseSpDef = 75,
        baseSpeed = baseSpeed,
        evYield = Defense * 2,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 173,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 60,
        baseFriendship = 70,
        cryLocation = "gourgeist",
        graphicsLocation = "gourgeist/" + graphicsSubfolder,
        backSpriteHeight = backSpriteHeight,
        pokedexData = Pokedex.Gourgeist,
        abilities = new[]
        {
                Pickup,
                Frisk,
                Insomnia,
        }
    };

    //Xerneas constructor
    public static SpeciesData Xerneas(string graphics) => new()
    {
        speciesName = "Xerneas",
        type1 = Fairy,
        type2 = Fairy,
        baseHP = 126,
        baseAttack = 131,
        baseDefense = 95,
        baseSpAtk = 131,
        baseSpDef = 98,
        baseSpeed = 99,
        evYield = 3 * HP,
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
        cryLocation = "xerneas",
        graphicsLocation = graphics,
        backSpriteHeight = 0,
        pokedexData = Pokedex.Xerneas,
        abilities = new[]
        {
            FairyAura,
            FairyAura,
            FairyAura
        }
    };

    //Oricorio constructor
    public static SpeciesData Oricorio(Type type1, string graphicsSubfolder) => new()
    {
        speciesName = "Oricorio",
        type1 = type1,
        type2 = Flying,
        baseHP = 75,
        baseAttack = 70,
        baseDefense = 70,
        baseSpAtk = 98,
        baseSpDef = 70,
        baseSpeed = 93,
        evYield = 2 * SpAtk,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 167,
        learnset = EmptyLearnset, //Not done
        malePercent = 25,
        eggGroup1 = EggGroup.Flying,
        eggGroup2 = EggGroup.Flying,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "oricorio_" + graphicsSubfolder,
        graphicsLocation = "oricorio/" + graphicsSubfolder,
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            Dancer,
            Dancer,
            Dancer
        }
    };

    //Rockruff constructor
    public static SpeciesData Rockruff(Ability[] abilities, EvolutionData[] evolution) => new()
    {
        speciesName = "Rockruff",
        type1 = Rock,
        type2 = Rock,
        baseHP = 45,
        baseAttack = 65,
        baseDefense = 40,
        baseSpAtk = 30,
        baseSpDef = 40,
        baseSpeed = 60,
        evYield = Attack,
        evolution = evolution,
        xpClass = MediumFast,
        xpYield = 56,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Field,
        eggGroup2 = EggGroup.Field,
        eggCycles = 15,
        catchRate = 190,
        baseFriendship = 70,
        cryLocation = "rockruff",
        graphicsLocation = "rockruff",
        backSpriteHeight = 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = abilities
    };

    //Silvally constructor
    public static SpeciesData Silvally(Type type, string graphicsSubfolder) => new()
    {
        speciesName = "Silvally",
        type1 = type,
        type2 = type,
        baseHP = 95,
        baseAttack = 95,
        baseDefense = 95,
        baseSpAtk = 95,
        baseSpDef = 95,
        baseSpeed = 95,
        evYield = 3 * HP,
        evolution = Evolution.None,
        xpClass = Slow,
        xpYield = 257,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Undiscovered,
        eggGroup2 = EggGroup.Undiscovered,
        eggCycles = 120,
        catchRate = 3,
        baseFriendship = 0,
        cryLocation = "silvally",
        graphicsLocation = "silvally/" + graphicsSubfolder,
        backSpriteHeight = 0,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            RKSSystem,
            RKSSystem,
            RKSSystem
        }
    };

    //Minior constructor
    public static SpeciesData Minior(bool core, string graphicsSubfolder = "") => new()
    {
        speciesName = "Minior",
        type1 = Rock,
        type2 = Flying,
        baseHP = 60,
        baseAttack = core ? 100 : 60,
        baseDefense = core ? 60 : 100,
        baseSpAtk = core ? 100 : 60,
        baseSpDef = core ? 60 : 100,
        baseSpeed = core ? 120 : 60,
        evYield = Defense + SpDef,
        evolution = Evolution.None,
        xpClass = MediumSlow,
        xpYield = 154,
        learnset = EmptyLearnset, //Not done
        malePercent = Genderless,
        eggGroup1 = EggGroup.Mineral,
        eggGroup2 = EggGroup.Mineral,
        eggCycles = 25,
        catchRate = 30,
        baseFriendship = 70,
        cryLocation = "minior",
        graphicsLocation = core ? "minior/core/" + graphicsSubfolder : "minior",
        backSpriteHeight = core ? 15 : 14,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            ShieldsDown,
            ShieldsDown,
            ShieldsDown
        }
    };

    public static SpeciesData Mimikyu(bool busted) => new()
    {
        speciesName = "Mimikyu",
        type1 = Ghost,
        type2 = Fairy,
        baseHP = 55,
        baseAttack = 90,
        baseDefense = 80,
        baseSpAtk = 50,
        baseSpDef = 105,
        baseSpeed = 96,
        evYield = 2 * SpDef,
        evolution = Evolution.None,
        xpClass = MediumFast,
        xpYield = 167,
        learnset = EmptyLearnset, //Not done
        malePercent = 50,
        eggGroup1 = EggGroup.Amorphous,
        eggGroup2 = EggGroup.Amorphous,
        eggCycles = 20,
        catchRate = 45,
        baseFriendship = 70,
        cryLocation = "mimikyu",
        graphicsLocation = "mimikyu" + (busted ? "/busted" : string.Empty),
        backSpriteHeight = busted ? 15 : 7,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            Disguise,
            Disguise,
            Disguise
        }
    };

    public static SpeciesData Magearna(bool original) => new()
    {
        speciesName = "Magearna",
        type1 = Steel,
        type2 = Fairy,
        baseHP = 80,
        baseAttack = 95,
        baseDefense = 115,
        baseSpAtk = 130,
        baseSpDef = 115,
        baseSpeed = 65,
        evYield = 3 * SpAtk,
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
        cryLocation = "magearna",
        graphicsLocation = "magearna" + (original ? "/original_color" : string.Empty),
        backSpriteHeight = 5,
        pokedexData = Pokedex.Bulbasaur, //Not done
        abilities = new[]
        {
            SoulHeart,
            SoulHeart,
            SoulHeart
        }
    };

    //Mega constructor

    public static SpeciesData Mega(SpeciesData baseSpecies,
    int baseAttack, int baseDefense, int baseSpAtk, int baseSpDef, int baseSpeed,
    int backSpriteHeight, PokedexData pokedexData, Ability ability,
     Type type1 = Typeless, Type type2 = Typeless,
     string cry = "", string graphics = "", string name = "") => new()
     {
         speciesName = name == string.Empty ? "Mega " + baseSpecies.speciesName : name,
         type1 = type1 == Typeless ? baseSpecies.type1 : type1,
         type2 = type2 == Typeless ? baseSpecies.type2 : type2,
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
         cryLocation = cry == string.Empty ? "mega_" + baseSpecies.cryLocation : cry,
         graphicsLocation = graphics == string.Empty ? baseSpecies.graphicsLocation + "/mega" : graphics,
         backSpriteHeight = backSpriteHeight,
         pokedexData = pokedexData,
         abilities = new[]
         {
                 ability,
                 ability,
                 ability,
         }
     };

    public static SpeciesData[] SingleSpecies(SpeciesData species) =>
        new SpeciesData[1] { species };
}