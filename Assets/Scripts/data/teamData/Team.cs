public static class Team
{
    public static TeamData mayTestTeam = new()
    {
        trainerName = "Pokémon Trainer May",
        Party = new TeamPokemon[]
        {
            new()
            {
                species = SpeciesID.Blissey,
                gender = Gender.Any,
                nature = Nature.Any,
                evIv = Spreads.random,
                level = 20,
            }
        }
    };
}