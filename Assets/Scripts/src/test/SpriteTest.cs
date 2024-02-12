using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTest : MonoBehaviour
{
    public Battle battle;
    public int index;
    public SpeciesID species;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightCommand))
        {
            species++;
            if (species >= SpeciesID.Count) species = SpeciesID.Missingno;
        }
        if (Input.GetKeyDown(KeyCode.LeftCommand))
        {
            species--;
            if (species < 0) species = SpeciesID.Count - 1;
        }
        battle.PokemonOnField[index].pokemon.species = species;
    }
}
