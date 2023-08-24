using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Species
{
    public static SpeciesData Missingno = new(
        SpeciesID.Missingno, "Error 01", Type.Typeless, Type.Typeless,
        0, 0, 0, 0, 0, 0,
        0, Evolution.NoEvolution,
        XPClassID.Erratic, 0, Learnset.EmptyLearnset,
        new ushort[] {Ability.None, Ability.None, Ability.None},
        "pikachu", "question_mark/circled", 0);
    public static SpeciesData Bulbasaur = new(
        SpeciesID.Bulbasaur, "Bulbasaur", Type.Grass, Type.Poison,
        45, 49, 49, 65, 65, 45,
        EvYield.SpAtk, Evolution.BulbasaurEvolution,
        XPClassID.MediumSlow, 64, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Overgrow, Ability.Overgrow, Ability.Chlorophyll },
        "bulbasaur", "bulbasaur", 13);
    public static SpeciesData Ivysaur = new(
        SpeciesID.Ivysaur, "Ivysaur", Type.Grass, Type.Poison,
        60, 62, 63, 80, 80, 60,
        EvYield.SpAtk + EvYield.SpDef, Evolution.IvysaurEvolution,
        XPClassID.MediumSlow, 142, Learnset.IvysaurLearnset,
        new ushort[] { Ability.Overgrow, Ability.Overgrow, Ability.Chlorophyll },
        "ivysaur", "ivysaur", 9);
    public static SpeciesData Venusaur = new(
        SpeciesID.Venusaur, "Venusaur", Type.Grass, Type.Poison,
        80, 82, 83, 100, 100, 80,
        EvYield.SpAtk * 2 + EvYield.SpDef, Evolution.NoEvolution,
        XPClassID.MediumSlow, 236, Learnset.IvysaurLearnset,
        new ushort[] { Ability.Overgrow, Ability.Overgrow, Ability.Chlorophyll },
        "venusaur", "venusaur", 10);
    public static SpeciesData Charmander = new(
        SpeciesID.Charmander, "Charmander", Type.Fire, Type.Fire,
        39, 52, 43, 65, 60, 50,
        EvYield.Speed, Evolution.CharmanderEvolution,
        XPClassID.MediumSlow, 62, Learnset.CharmanderLearnset,
        new ushort[] { Ability.Blaze, Ability.Blaze, Ability.SolarPower },
        "charmander", "charmander", 9);
    public static SpeciesData Charmeleon = new(
        SpeciesID.Charmeleon, "Charmander", Type.Fire, Type.Fire,
        58, 64, 58, 80, 65, 80,
        EvYield.Speed + EvYield.SpAtk, Evolution.CharmeleonEvolution,
        XPClassID.MediumSlow, 142, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Blaze, Ability.Blaze, Ability.SolarPower },
        "charmeleon", "charmeleon", 8);
    public static SpeciesData Charizard = new(
        SpeciesID.Charizard, "Charmander", Type.Fire, Type.Flying,
        39, 52, 43, 65, 60, 50,
        EvYield.SpAtk * 3, Evolution.NoEvolution,
        XPClassID.MediumSlow, 240, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Blaze, Ability.Blaze, Ability.SolarPower },
        "charizard", "charizard", 1);
    public static SpeciesData Squirtle = new(
        SpeciesID.Squirtle, "Squirtle", Type.Water, Type.Water,
        44, 48, 65, 50, 64, 43,
        EvYield.Defense, Evolution.SquirtleEvolution,
        XPClassID.MediumSlow, 63, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Torrent, Ability.Torrent, Ability.RainDish },
        "squirtle", "squirtle", 9);
    public static SpeciesData Wartortle = new(
        SpeciesID.Wartortle, "Wartortle", Type.Water, Type.Water,
        59, 63, 80, 65, 80, 58,
        EvYield.Defense + EvYield.SpDef, Evolution.WartortleEvolution,
        XPClassID.MediumSlow, 142, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Torrent, Ability.Torrent, Ability.RainDish },
        "wartortle", "wartortle", 7);
    public static SpeciesData Blastoise = new(
        SpeciesID.Blastoise, "Blastoise", Type.Water, Type.Water,
        79, 83, 100, 78, 85, 105,
        EvYield.Defense * 3, Evolution.NoEvolution,
        XPClassID.MediumSlow, 239, Learnset.BulbusaurLearnset,
        new ushort[] { Ability.Torrent, Ability.Torrent, Ability.RainDish },
        "blastoise", "blastoise", 7);
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
    };
}