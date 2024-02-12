using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Battle;

public class OverallTest : MonoBehaviour
{
    public Battle battle;
    public Player player;


    // Start is called before the first frame update
    public void Start()
    {
        Pokemon testPokemon = Pokemon.WildPokemon(SpeciesID.Gyarados, 10);
        Pokemon testPokemon2 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 15);
        Pokemon testPokemon3 = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 10);
        Pokemon testPokemon4 = Pokemon.WildPokemon(SpeciesID.NidoranM, 10);
        Pokemon testPokemon5 = Pokemon.WildPokemon(SpeciesID.Porygon, 10);
        Pokemon testPokemon6 = Pokemon.WildPokemon(SpeciesID.Charizard, 10);
        Pokemon testPokemon7 = Pokemon.WildPokemon(SpeciesID.Infernape, 10);
        Pokemon testPokemon8 = Pokemon.WildPokemon(SpeciesID.Huntail, 10);
        Pokemon testPokemon9 = Pokemon.WildPokemon(SpeciesID.Porygon2, 10);
        testPokemon.move1 = MoveID.Splash;
        testPokemon.whichAbility = 0;
        testPokemon.pp1 = 40;
        testPokemon2.item = ItemID.Venusaurite;
        testPokemon2.move1 = MoveID.Rollout;
        testPokemon2.pp2 = 40;
        testPokemon4.item = ItemID.NormaliumZ;
        testPokemon4.move2 = MoveID.Scratch;
        testPokemon4.pp1 = 10;
        testPokemon5.whichAbility = 0;
        testPokemon6.item = ItemID.CharizarditeY;
        player.EmptyParty();
        player.TryAddMon(testPokemon2);
        player.TryAddMon(testPokemon4);
        player.TryAddMon(testPokemon5);
        player.TryAddMon(testPokemon7);
        player.TryAddMon(testPokemon8);
        player.TryAddMon(testPokemon9);
        battle.opponentPokemon = new Pokemon[] { testPokemon, testPokemon3, testPokemon6,
        Pokemon.EmptyMon, Pokemon.EmptyMon, Pokemon.EmptyMon };
        battle.playerPokemon = player.Party;
        battle.StartCoroutine(battle.StartBattle());
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            battle.PokemonOnField[0].pokemon.gender = Gender.Female;
            battle.PokemonOnField[3].pokemon.gender = Gender.Male;
            battle.PokemonOnField[3].pokemon.move1 = MoveID.Attract;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Pokemon tester = battle.PokemonOnField[3].pokemon;
            BattlePokemon defender = battle.PokemonOnField[0];
            battle.Moves[0] = MoveID.Splash;
            tester.move1 = MoveID.Flamethrower;
            tester.pp1 = 40;
            defender.typesOverriden = true;
            defender.newType1 = Type.Grass;
            defender.newType1 = Type.Grass;
            defender.pokemon.item = ItemID.OccaBerry;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            BattlePokemon dummy = battle.PokemonOnField[0];
            dummy.pokemon.level = 100;
            dummy.pokemon.hp = dummy.pokemon.hpMax;
            dummy.pokemon.move1 = MoveID.Splash;
            dummy.pokemon.pp1 = 255;
            dummy.pokemon.item = ItemID.SitrusBerry;
            dummy.pokemon.itemChanged = false;
            battle.Moves[0] = MoveID.Splash;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            battle.PokemonOnField[0].pokemon.move1 = MoveID.Encore;
            battle.PokemonOnField[3].pokemon.move1 = MoveID.Pound;
            battle.PokemonOnField[3].pokemon.move2 = MoveID.Scratch;
            battle.PokemonOnField[3].pokemon.move3 = MoveID.Tackle;
            battle.PokemonOnField[3].pokemon.pp2 = 30;
            battle.PokemonOnField[3].pokemon.pp3 = 30;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            BattlePokemon tester = battle.PokemonOnField[3];
            BattlePokemon defender = battle.PokemonOnField[0];
            tester.pokemon.move1 = MoveID.Pluck;
            tester.pokemon.pp1 = 40;
            defender.pokemon.move1 = MoveID.Splash;
            defender.pokemon.pp1 = 40;
            defender.pokemon.item = ItemID.LiechiBerry;
            battle.Moves[0] = MoveID.Splash;
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.RightShift))
        {
            Pokemon tester = battle.PokemonOnField[3].pokemon;
            tester.move1 = MoveID.Stockpile;
            tester.move2 = MoveID.SpitUp;
            tester.move3 = MoveID.Swallow;
            tester.pp1 = 40;
            tester.pp2 = 40;
            tester.pp3 = 40;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.AddItem(ItemID.PokeBall, 1);
            battle.Moves[3] = MoveID.UseItem;
            battle.itemToUse[3] = ItemID.PokeBall;
            battle.PokemonOnField[3].done = false;
            battle.menuManager.menuMode = MenuManager.MenuMode.Main;
            battle.menuManager.GoToAnnounce();
            battle.menuManager.SetForTest();
            battle.menuManager.GetNextPokemon();
            battle.DoNextMove();
        }
    }
}
