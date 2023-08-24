using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public Battle battle;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Equals)){
            battle.PokemonOnField[index].PokemonData.move1 = (ushort)((battle.PokemonOnField[index].PokemonData.move1 + 1) % MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (ushort)((battle.PokemonOnField[index].PokemonData.move1 + 10) % MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (ushort)((battle.PokemonOnField[index].PokemonData.move1 - 1) % MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (ushort)((battle.PokemonOnField[index].PokemonData.move1 - 10) % MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
    }
}
