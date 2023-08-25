using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallTest : MonoBehaviour
{
    public Battle battle;
    Pokemon testPokemon = Pokemon.WildPokemon(SpeciesID.Ivysaur, 10);
    Pokemon testPokemon2 = Pokemon.WildPokemon(SpeciesID.Ivysaur, 10);
    Pokemon testPokemon3 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 10);
    // Start is called before the first frame update
    void Start()
    {
        testPokemon2.item = ItemID.Venusaurite;
        battle.PlayerPokemon[0] = testPokemon2;
        battle.OpponentPokemon[0] = testPokemon;
        battle.OpponentPokemon[1] = testPokemon3;
        battle.StartBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
