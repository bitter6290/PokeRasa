using System.Collections.Generic;

public class TeamPokemon
{
    public SpeciesID species;
    public EvIvSpread evIv;
    public Nature nature = Nature.Any;
    public int level;
    public Gender gender = Gender.Any;
    public List<MoveID> moves = new(); /*Supplying an array with fewer than 4 moves 
                            * will only overwrite as many moves as you supply;
                            * to create a Pokemon with fewer than 4 moves,
                            * fill out the array with Move.None.
                            */
    public Pokemon ToPokemon
    {
        get
        {
            Pokemon initialPokemon = Pokemon.WildPokemon(species, level);
            if (nature != Nature.Any) initialPokemon.SetNature(nature);
            if (evIv.real) initialPokemon.SetEvIv(evIv);
            if (gender != Gender.Any) initialPokemon.gender = gender;
            for (int i = 0; i < moves.Count; i++)
            {
                switch (i)
                {
                    case 0: initialPokemon.move1 = moves[0]; break;
                    case 1: initialPokemon.move2 = moves[1]; break;
                    case 2: initialPokemon.move3 = moves[2]; break;
                    case 3: initialPokemon.move4 = moves[3]; break;
                    default: break;
                }
            }
            return initialPokemon;
        }
    }
}