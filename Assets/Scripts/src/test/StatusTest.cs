using UnityEngine;

public class StatusTest : MonoBehaviour
{
    public Battle battle;
    public Status status;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            status = (Status)(((int)status + 1) % 7);
        }
        battle.PokemonOnField[3].pokemon.status = status;
    }
}
