using UnityEngine;

public class HealthTest : MonoBehaviour
{
    public Battle battle;
    public int index;

    public HealthBarManager healthBar;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            battle.PokemonOnField[index].pokemon.hp -= 10;
        }
    }
}
