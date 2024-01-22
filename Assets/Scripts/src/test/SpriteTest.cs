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
            species = (SpeciesID)((int)(species + 1) % 3);
        }
        battle.PokemonOnField[index].pokemon.species = species;
    }
}
