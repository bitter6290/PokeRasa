using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTest : MonoBehaviour
{
    public Battle battle;
    public int index;
    public SpeciesID species;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightCommand))
        {
            species = (SpeciesID)((int)(species + 1) % 3);
        }
        battle.PokemonOnField[index].PokemonData.species = species;
    }
}
