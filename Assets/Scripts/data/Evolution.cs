using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Evolution
{
    public static EvolutionData[] NoEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.Never, 0, SpeciesID.Missingno) };
    public static EvolutionData[] BulbasaurEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Ivysaur) };
    public static EvolutionData[] IvysaurEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 32, SpeciesID.Venusaur) };
    public static EvolutionData[] CharmanderEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Charmeleon) };
    public static EvolutionData[] CharmeleonEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 36, SpeciesID.Charizard) };
    public static EvolutionData[] SquirtleEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Wartortle) };
    public static EvolutionData[] WartortleEvolution = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 36, SpeciesID.Blastoise) };
}