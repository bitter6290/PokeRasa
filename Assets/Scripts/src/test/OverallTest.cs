using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallTest : MonoBehaviour
{
    public Battle battle;
    private readonly Pokemon testPokemon = Pokemon.WildPokemon(SpeciesID.Ivysaur, 10);
    private readonly Pokemon testPokemon2 = Pokemon.WildPokemon(SpeciesID.Ivysaur, 10);
    private readonly Pokemon testPokemon3 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 10);
    private readonly Pokemon testPokemon4 = Pokemon.WildPokemon(SpeciesID.NidoranM, 10);
    // Start is called before the first frame update
    public void Start()
    {
        testPokemon2.item = ItemID.Venusaurite;
        testPokemon.move1 = MoveID.Splash;
        testPokemon.pp1 = 40;
        testPokemon.maxPp1 = 40;
        battle.PlayerPokemon[0] = testPokemon2;
        battle.PlayerPokemon[1] = testPokemon4;
        battle.OpponentPokemon[0] = testPokemon;
        battle.OpponentPokemon[1] = testPokemon3;
        battle.StartCoroutine(battle.StartBattle());
    }

    // Update is called once per frame
    public void Update()
    {

    }
}
