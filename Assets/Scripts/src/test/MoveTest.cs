using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public Battle battle;
    public int index;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (MoveID)((int)(battle.PokemonOnField[index].PokemonData.move1 + (int)MoveID.StandardCount + 1) % (int)MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (MoveID)((int)(battle.PokemonOnField[index].PokemonData.move1 + (int)MoveID.StandardCount + 10) % (int)MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (MoveID)((int)(battle.PokemonOnField[index].PokemonData.move1 + (int)MoveID.StandardCount - 1) % (int)MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            battle.PokemonOnField[index].PokemonData.move1 = (MoveID)((int)(battle.PokemonOnField[index].PokemonData.move1 + (int)MoveID.StandardCount - 10) % (int)MoveID.StandardCount);
            battle.PokemonOnField[index].PokemonData.pp1 = 255;
        }
    }
}
