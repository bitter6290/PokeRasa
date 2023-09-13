using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallTest : MonoBehaviour
{
    public Battle battle;
    private readonly Pokemon testPokemon = Pokemon.WildPokemon(SpeciesID.Marowak, 10);
    private readonly Pokemon testPokemon2 = Pokemon.WildPokemon(SpeciesID.Ivysaur, 10);
    private readonly Pokemon testPokemon3 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 10);
    private readonly Pokemon testPokemon4 = Pokemon.WildPokemon(SpeciesID.NidoranM, 10);
    private readonly Pokemon testPokemon5 = Pokemon.WildPokemon(SpeciesID.Porygon, 10);
    // Start is called before the first frame update
    public void Start()
    {
        testPokemon2.item = ItemID.Venusaurite;
        testPokemon.move1 = MoveID.Splash;
        testPokemon.pp1 = 40;
        testPokemon.maxPp1 = 40;
        testPokemon2.move1 = MoveID.Rollout;
        testPokemon2.pp1 = 40;
        testPokemon2.maxPp1 = 40;
        testPokemon5.whichAbility = 0;
        battle.PlayerPokemon[0] = testPokemon2;
        battle.PlayerPokemon[1] = testPokemon4;
        battle.PlayerPokemon[2] = testPokemon5;
        battle.OpponentPokemon[0] = testPokemon;
        battle.OpponentPokemon[1] = testPokemon3;
        battle.StartCoroutine(battle.StartBattle());
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            battle.PokemonOnField[0].PokemonData.gender = Gender.Female;
            battle.PokemonOnField[3].PokemonData.gender = Gender.Male;
            battle.PokemonOnField[3].PokemonData.move1 = MoveID.Attract;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            battle.PokemonOnField[0].PokemonData.move1 = MoveID.Encore;
            battle.PokemonOnField[3].PokemonData.move1 = MoveID.Pound;
            battle.PokemonOnField[3].PokemonData.move2 = MoveID.Scratch;
            battle.PokemonOnField[3].PokemonData.move3 = MoveID.Tackle;
            battle.PokemonOnField[3].PokemonData.pp2 = 30;
            battle.PokemonOnField[3].PokemonData.pp3 = 30;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Pokemon tester = battle.PokemonOnField[3].PokemonData;
            tester.move1 = MoveID.Stockpile;
            tester.move2 = MoveID.SpitUp;
            tester.move3 = MoveID.Swallow;
            tester.pp1 = 40;
            tester.pp2 = 40;
            tester.pp3 = 40;
        }
    }
}
