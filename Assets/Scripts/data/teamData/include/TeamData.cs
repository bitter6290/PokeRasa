using System;
public class TeamData
{
    public TeamPokemon[] Party;

    public string trainerName;

    public Pokemon[] GetParty()
    {
        Pokemon[] result = new Pokemon[6];
        for (int i = 0; i < 6; i++)
        {
            if (i < Party.Length) result[i] = Party[i].ToPokemon;
            else result[i] = Pokemon.EmptyMon;
        }
        return result;
    }
}
