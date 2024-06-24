using static Spread;
using static MoveID;
using static Nature;
using static SpeciesID;
public static class Team
{
    public static TeamData mayTestTeam = new()
    {
        trainerName = "Pokémon Trainer May",
        prizeMoney = 5000,
        Party = new TeamPokemon[]
        {
            new()
            {
                species = Blissey,
                gender = Gender.Any,
                nature = Any,
                evIv = random,
                level = 20,
                moves = {Pound}
            }
        }
    };

    public static TeamData cutTrainerTeam = new()
    {
        trainerName = "Gardener Neil",
        prizeMoney = 800,
        Party = new TeamPokemon[]
        {
            new()
            {
                species = Farfetchd,
                gender = Gender.Any,
                nature = Adamant,
                evIv = random,
                level = 15,
                moves = {Cut, AerialAce, RazorLeaf, FuryCutter}
            },
            new()
            {
                species = Gloom,
                gender = Gender.Any,
                nature = Timid,
                evIv = random,
                level = 15,
                moves = {PoisonPowder, MegaDrain, SunnyDay, Infestation},
                ability = Ability.Chlorophyll
            },
            new()
            {
                species = Weepinbell,
                gender = Gender.Any,
                nature = Adamant,
                evIv = random,
                level = 17,
                moves = {Cut, MagicalLeaf, Acid, Swift}
            }
        }
    };

    public static TeamData macieTeam = new()
    {
        trainerName = "Gym Leader Macie",
        prizeMoney = 10000,
        Party = new TeamPokemon[]
        {
            new()
            {
                species = Sudowoodo,
                gender = Gender.Female,
                nature = Adamant,
                evIv = attackHP128,
                level = 18,
                moves = {Curse, RockThrow, SuckerPunch, DrainPunch}
            },
            new()
            {
                species = FloetteRed,
                gender = Gender.Female,
                nature = Timid,
                evIv = spAtkSpeed128,
                level = 18,
                moves = {GrassKnot, DrainingKiss, StoredPower, CalmMind}
            },
            new()
            {
                species = Lurantis,
                gender = Gender.Female,
                nature = Adamant,
                evIv = attackHP128,
                level = 18,
                moves = {LeechLife, PsychoCut, BrickBreak, SwordsDance}
            },
            new()
            {
                species = Dhelmise,
                gender = Gender.Genderless,
                nature = Modest,
                evIv = spAtkHP128,
                level = 20,
                moves = {FlashCannon, ShadowBall, Surf, AnchorShot}
            }
        }
    };
}