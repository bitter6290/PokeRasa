public struct TeamData
{
    public TeamPokemon[] Party;

    public string trainerName;
    public int prizeMoney;

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
