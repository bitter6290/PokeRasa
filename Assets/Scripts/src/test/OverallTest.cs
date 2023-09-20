using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallTest : MonoBehaviour
{
    public Battle battle;
    public Player player;
    private Pokemon testPokemon = Pokemon.WildPokemon(SpeciesID.Marowak, 10);
    private Pokemon testPokemon2 = Pokemon.WildPokemon(SpeciesID.Venusaur, 10);
    private Pokemon testPokemon3 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 10);
    private Pokemon testPokemon4 = Pokemon.WildPokemon(SpeciesID.NidoranM, 10);
    private Pokemon testPokemon5 = Pokemon.WildPokemon(SpeciesID.Porygon, 10);
    private Pokemon testPokemon6 = Pokemon.WildPokemon(SpeciesID.Charizard, 10);

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
        testPokemon6.item = ItemID.CharizarditeY;
        player.EmptyParty();
        player.TryAddMon(testPokemon2);
        player.TryAddMon(testPokemon4);
        player.TryAddMon(testPokemon5);
        battle.OpponentPokemon = new Pokemon[] { testPokemon, testPokemon3, testPokemon6,
        Pokemon.MakeEmptyMon, Pokemon.MakeEmptyMon, Pokemon.MakeEmptyMon };
        battle.PlayerPokemon = new Pokemon[] { testPokemon2, testPokemon4, testPokemon5,
        Pokemon.MakeEmptyMon, Pokemon.MakeEmptyMon, Pokemon.MakeEmptyMon };
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
        if (Input.GetKeyDown(KeyCode.B))
        {
            Pokemon tester = battle.PokemonOnField[3].PokemonData;
            BattlePokemon defender = battle.PokemonOnField[0];
            battle.Moves[0] = MoveID.Splash;
            tester.move1 = MoveID.Flamethrower;
            tester.pp1 = 40;
            defender.typesOverriden = true;
            defender.newType1 = Type.Grass;
            defender.newType1 = Type.Grass;
            defender.PokemonData.item = ItemID.OccaBerry;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            BattlePokemon tester = battle.PokemonOnField[3];
            BattlePokemon defender = battle.PokemonOnField[0];
            tester.PokemonData.move1 = MoveID.Pluck;
            tester.PokemonData.pp1 = 40;
            defender.PokemonData.move1 = MoveID.Splash;
            defender.PokemonData.pp1 = 40;
            defender.PokemonData.item = ItemID.LiechiBerry;
            battle.Moves[0] = MoveID.Splash;
        }
    }
}
