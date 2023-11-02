using UnityEngine;
using static PokedexDesc;
using static SpeciesData;

public static class Pokedex
{
    public static PokedexData Bulbasaur = new()
    {
        number = 1,
        name = "Bulbasaur",
        category = "Seed",
        height = 70,
        weight = 6900,
        entry = BulbasaurDesc,
        forms = SingleSpecies(Species.Bulbasaur),
    };
    public static PokedexData Ivysaur = new()
    {
        number = 2,
        name = "Ivysaur",
        category = "Seed",
        height = 100,
        weight = 13000,
        entry = IvysaurDesc,
        forms = SingleSpecies(Species.Ivysaur),
    };
    public static PokedexData Venusaur = new()
    {
        number = 3,
        name = "Venusaur",
        category = "Seed",
        height = 200,
        weight = 100000,
        entry = VenusaurDesc,
        forms = new[]
        {
            Species.Venusaur,
            Species.VenusaurMega
        }
    };
    public static PokedexData Charmander = new()
    {
        number = 4,
        name = "Charmander",
        category = "Lizard",
        height = 60,
        weight = 8500,
        entry = CharmanderDesc,
        forms = SingleSpecies(Species.Charmander),
    };
    public static PokedexData Charmeleon = new()
    {
        number = 5,
        name = "Charmeleon",
        category = "Flame",
        height = 110,
        weight = 19000,
        entry = CharmeleonDesc,
        forms = SingleSpecies(Species.Charmeleon),
    };
    public static PokedexData Charizard = new()
    {
        number = 6,
        name = "Charizard",
        category = "Flame",
        height = 170,
        weight = 90500,
        entry = CharizardDesc,
        forms = new[]
        {
            Species.Charizard,
            Species.CharizardMegaX,
            Species.CharizardMegaY
        }
    };
    public static PokedexData Squirtle = new()
    {
        number = 7,
        name = "Squirtle",
        category = "TinyTurtle",
        height = 50,
        weight = 9000,
        entry = SquirtleDesc,
        forms = SingleSpecies(Species.Squirtle),
    };
    public static PokedexData Wartortle = new()
    {
        number = 8,
        name = "Wartortle",
        category = "Turtle",
        height = 100,
        weight = 22500,
        entry = WartortleDesc,
        forms = SingleSpecies(Species.Wartortle),
    };
    public static PokedexData Blastoise = new()
    {
        number = 9,
        name = "Blastoise",
        category = "Shellfish",
        height = 160,
        weight = 85500,
        entry = BlastoiseDesc,
        forms = new[]
        {
            Species.Blastoise,
            Species.BlastoiseMega
        }
    };
    public static PokedexData Caterpie = new()
    {
        number = 10,
        name = "Caterpie",
        category = "Worm",
        height = 30,
        weight = 2900,
        entry = CaterpieDesc,
        forms = SingleSpecies(Species.Caterpie),
    };
    public static PokedexData Metapod = new()
    {
        number = 11,
        name = "Metapod",
        category = "Cocoon",
        height = 70,
        weight = 9900,
        entry = MetapodDesc,
        forms = SingleSpecies(Species.Metapod),
    };
    public static PokedexData Butterfree = new()
    {
        number = 12,
        name = "Butterfree",
        category = "Butterfly",
        height = 110,
        weight = 32000,
        entry = ButterfreeDesc,
        forms = SingleSpecies(Species.Butterfree),
    };
    public static PokedexData Weedle = new()
    {
        number = 13,
        name = "Weedle",
        category = "HairyBug",
        height = 30,
        weight = 3200,
        entry = WeedleDesc,
        forms = SingleSpecies(Species.Weedle),
    };
    public static PokedexData Kakuna = new()
    {
        number = 14,
        name = "Kakuna",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = KakunaDesc,
        forms = SingleSpecies(Species.Kakuna),
    };
    public static PokedexData Beedrill = new()
    {
        number = 15,
        name = "Beedrill",
        category = "PoisonBee",
        height = 100,
        weight = 29500,
        entry = BeedrillDesc,
        forms = new[]
        {
            Species.Beedrill,
            Species.BeedrillMega
        }
    };
    public static PokedexData Pidgey = new()
    {
        number = 16,
        name = "Pidgey",
        category = "TinyBird",
        height = 30,
        weight = 1800,
        entry = PidgeyDesc,
        forms = SingleSpecies(Species.Pidgey),
    };
    public static PokedexData Pidgeotto = new()
    {
        number = 17,
        name = "Pidgeotto",
        category = "Bird",
        height = 110,
        weight = 30000,
        entry = PidgeottoDesc,
        forms = SingleSpecies(Species.Pidgeotto),
    };
    public static PokedexData Pidgeot = new()
    {
        number = 18,
        name = "Pidgeot",
        category = "Bird",
        height = 150,
        weight = 39500,
        entry = PidgeotDesc,
        forms = new[]
        {
            Species.Pidgeot,
            Species.PidgeotMega
        }
    };
    public static PokedexData Rattata = new()
    {
        number = 19,
        name = "Rattata",
        category = "Mouse",
        height = 30,
        weight = 3500,
        entry = RattataDesc,
        forms = SingleSpecies(Species.Rattata),
    };
    public static PokedexData Raticate = new()
    {
        number = 20,
        name = "Raticate",
        category = "Mouse",
        height = 70,
        weight = 18500,
        entry = RaticateDesc,
        forms = SingleSpecies(Species.Raticate),
    };
    public static PokedexData Spearow = new()
    {
        number = 21,
        name = "Spearow",
        category = "TinyBird",
        height = 30,
        weight = 2000,
        entry = SpearowDesc,
        forms = SingleSpecies(Species.Spearow),
    };
    public static PokedexData Fearow = new()
    {
        number = 22,
        name = "Fearow",
        category = "Beak",
        height = 120,
        weight = 38000,
        entry = FearowDesc,
        forms = SingleSpecies(Species.Fearow),
    };
    public static PokedexData Ekans = new()
    {
        number = 23,
        name = "Ekans",
        category = "Snake",
        height = 200,
        weight = 6900,
        entry = EkansDesc,
        forms = SingleSpecies(Species.Ekans),
    };
    public static PokedexData Arbok = new()
    {
        number = 24,
        name = "Arbok",
        category = "Cobra",
        height = 350,
        weight = 65000,
        entry = ArbokDesc,
        forms = SingleSpecies(Species.Arbok),
    };
    public static PokedexData Pikachu = new()
    {
        number = 25,
        name = "Pikachu",
        category = "Mouse",
        height = 40,
        weight = 6000,
        entry = PikachuDesc,
        forms = SingleSpecies(Species.Pikachu),
    };
    public static PokedexData Raichu = new()
    {
        number = 26,
        name = "Raichu",
        category = "Mouse",
        height = 80,
        weight = 30000,
        entry = RaichuDesc,
        forms = SingleSpecies(Species.Raichu),
    };
    public static PokedexData Sandshrew = new()
    {
        number = 27,
        name = "Sandshrew",
        category = "Mouse",
        height = 60,
        weight = 12000,
        entry = SandshrewDesc,
        forms = SingleSpecies(Species.Sandshrew),
    };
    public static PokedexData Sandslash = new()
    {
        number = 28,
        name = "Sandslash",
        category = "Mouse",
        height = 100,
        weight = 29500,
        entry = SandslashDesc,
        forms = SingleSpecies(Species.Sandslash),
    };
    public static PokedexData NidoranF = new ()
	{
		number = 29,
		name = "Nidoran",
		category = "PoisonPin",
		height = 40,
		weight = 7000,
		entry = NidoranFDesc,
        forms = SingleSpecies(Species.NidoranF),

    };
    public static PokedexData Nidorina = new()
    {
        number = 30,
        name = "Nidorina",
        category = "PoisonPin",
        height = 80,
        weight = 20000,
        entry = NidorinaDesc,
        forms = SingleSpecies(Species.Nidorina),
    };
    public static PokedexData Nidoqueen = new()
    {
        number = 31,
        name = "Nidoqueen",
        category = "Drill",
        height = 130,
        weight = 60000,
        entry = NidoqueenDesc,
        forms = SingleSpecies(Species.Nidoqueen),
    };
    public static PokedexData NidoranM = new()
    {
        number = 32,
        name = "Nidoran",
        category = "PoisonPin",
        height = 50,
        weight = 9000,
        entry = NidoranMDesc,
        forms = SingleSpecies(Species.NidoranM),
    };
    public static PokedexData Nidorino = new()
    {
        number = 33,
        name = "Nidorino",
        category = "PoisonPin",
        height = 90,
        weight = 19500,
        entry = NidorinoDesc,
        forms = SingleSpecies(Species.Nidorino),
    };
    public static PokedexData Nidoking = new()
    {
        number = 34,
        name = "Nidoking",
        category = "Drill",
        height = 140,
        weight = 62000,
        entry = NidokingDesc,
        forms = SingleSpecies(Species.Nidoking),
    };
    public static PokedexData Clefairy = new()
    {
        number = 35,
        name = "Clefairy",
        category = "Fairy",
        height = 60,
        weight = 7500,
        entry = ClefairyDesc,
        forms = SingleSpecies(Species.Clefairy),
    };
    public static PokedexData Clefable = new()
    {
        number = 36,
        name = "Clefable",
        category = "Fairy",
        height = 130,
        weight = 40000,
        entry = ClefableDesc,
        forms = SingleSpecies(Species.Clefable),
    };
    public static PokedexData Vulpix = new()
    {
        number = 37,
        name = "Vulpix",
        category = "Fox",
        height = 60,
        weight = 9900,
        entry = VulpixDesc,
        forms = SingleSpecies(Species.Vulpix),
    };
    public static PokedexData Ninetales = new()
    {
        number = 38,
        name = "Ninetales",
        category = "Fox",
        height = 110,
        weight = 19900,
        entry = NinetalesDesc,
        forms = SingleSpecies(Species.Ninetales),
    };
    public static PokedexData Jigglypuff = new()
    {
        number = 39,
        name = "Jigglypuff",
        category = "Balloon",
        height = 50,
        weight = 5500,
        entry = JigglypuffDesc,
        forms = SingleSpecies(Species.Jigglypuff),
    };
    public static PokedexData Wigglytuff = new()
    {
        number = 40,
        name = "Wigglytuff",
        category = "Balloon",
        height = 100,
        weight = 12000,
        entry = WigglytuffDesc,
        forms = SingleSpecies(Species.Wigglytuff),
    };
    public static PokedexData Zubat = new()
    {
        number = 41,
        name = "Zubat",
        category = "Bat",
        height = 80,
        weight = 7500,
        entry = ZubatDesc,
        forms = SingleSpecies(Species.Zubat),
    };
    public static PokedexData Golbat = new()
    {
        number = 42,
        name = "Golbat",
        category = "Bat",
        height = 160,
        weight = 55000,
        entry = GolbatDesc,
        forms = SingleSpecies(Species.Golbat),
    };
    public static PokedexData Oddish = new()
    {
        number = 43,
        name = "Oddish",
        category = "Weed",
        height = 50,
        weight = 5400,
        entry = OddishDesc,
        forms = SingleSpecies(Species.Oddish),
    };
    public static PokedexData Gloom = new()
    {
        number = 44,
        name = "Gloom",
        category = "Weed",
        height = 80,
        weight = 8600,
        entry = GloomDesc,
        forms = SingleSpecies(Species.Gloom),
    };
    public static PokedexData Vileplume = new()
    {
        number = 45,
        name = "Vileplume",
        category = "Flower",
        height = 120,
        weight = 18600,
        entry = VileplumeDesc,
        forms = SingleSpecies(Species.Vileplume),
    };
    public static PokedexData Paras = new()
    {
        number = 46,
        name = "Paras",
        category = "Mushroom",
        height = 30,
        weight = 5400,
        entry = ParasDesc,
        forms = SingleSpecies(Species.Paras),
    };
    public static PokedexData Parasect = new()
    {
        number = 47,
        name = "Parasect",
        category = "Mushroom",
        height = 100,
        weight = 29500,
        entry = ParasectDesc,
        forms = SingleSpecies(Species.Parasect),
    };
    public static PokedexData Venonat = new()
    {
        number = 48,
        name = "Venonat",
        category = "Insect",
        height = 100,
        weight = 30000,
        entry = VenonatDesc,
        forms = SingleSpecies(Species.Venonat),
    };
    public static PokedexData Venomoth = new()
    {
        number = 49,
        name = "Venomoth",
        category = "PoisonMoth",
        height = 150,
        weight = 12500,
        entry = VenomothDesc,
        forms = SingleSpecies(Species.Venomoth),
    };
    public static PokedexData Diglett = new()
    {
        number = 50,
        name = "Diglett",
        category = "Mole",
        height = 20,
        weight = 800,
        entry = DiglettDesc,
        forms = SingleSpecies(Species.Diglett),
    };
    public static PokedexData Dugtrio = new()
    {
        number = 51,
        name = "Dugtrio",
        category = "Mole",
        height = 70,
        weight = 33300,
        entry = DugtrioDesc,
        forms = SingleSpecies(Species.Dugtrio),
    };
    public static PokedexData Meowth = new()
    {
        number = 52,
        name = "Meowth",
        category = "ScratchCat",
        height = 40,
        weight = 4200,
        entry = MeowthDesc,
        forms = SingleSpecies(Species.Meowth),
    };
    public static PokedexData Persian = new()
    {
        number = 53,
        name = "Persian",
        category = "ClassyCat",
        height = 100,
        weight = 32000,
        entry = PersianDesc,
        forms = SingleSpecies(Species.Persian),
    };
    public static PokedexData Psyduck = new()
    {
        number = 54,
        name = "Psyduck",
        category = "Duck",
        height = 80,
        weight = 19600,
        entry = PsyduckDesc,
        forms = SingleSpecies(Species.Psyduck),
    };
    public static PokedexData Golduck = new()
    {
        number = 55,
        name = "Golduck",
        category = "Duck",
        height = 170,
        weight = 76600,
        entry = GolduckDesc,
        forms = SingleSpecies(Species.Golduck),
    };
    public static PokedexData Mankey = new()
    {
        number = 56,
        name = "Mankey",
        category = "PigMonkey",
        height = 50,
        weight = 28000,
        entry = MankeyDesc,
        forms = SingleSpecies(Species.Mankey),
    };
    public static PokedexData Primeape = new()
    {
        number = 57,
        name = "Primeape",
        category = "PigMonkey",
        height = 100,
        weight = 32000,
        entry = PrimeapeDesc,
        forms = SingleSpecies(Species.Primeape),
    };
    public static PokedexData Growlithe = new()
    {
        number = 58,
        name = "Growlithe",
        category = "Puppy",
        height = 70,
        weight = 19000,
        entry = GrowlitheDesc,
        forms = SingleSpecies(Species.Growlithe),
    };
    public static PokedexData Arcanine = new()
    {
        number = 59,
        name = "Arcanine",
        category = "Legendary",
        height = 190,
        weight = 155000,
        entry = ArcanineDesc,
        forms = SingleSpecies(Species.Arcanine),
    };
    public static PokedexData Poliwag = new()
    {
        number = 60,
        name = "Poliwag",
        category = "Tadpole",
        height = 60,
        weight = 12400,
        entry = PoliwagDesc,
        forms = SingleSpecies(Species.Poliwag),
    };
    public static PokedexData Poliwhirl = new()
    {
        number = 61,
        name = "Poliwhirl",
        category = "Tadpole",
        height = 100,
        weight = 20000,
        entry = PoliwhirlDesc,
        forms = SingleSpecies(Species.Poliwhirl),
    };
    public static PokedexData Poliwrath = new()
    {
        number = 62,
        name = "Poliwrath",
        category = "Tadpole",
        height = 130,
        weight = 54000,
        entry = PoliwrathDesc,
        forms = SingleSpecies(Species.Poliwrath),
    };
    public static PokedexData Abra = new()
    {
        number = 63,
        name = "Abra",
        category = "Psi",
        height = 90,
        weight = 19500,
        entry = AbraDesc,
        forms = SingleSpecies(Species.Abra),
    };
    public static PokedexData Kadabra = new()
    {
        number = 64,
        name = "Kadabra",
        category = "Psi",
        height = 130,
        weight = 56500,
        entry = KadabraDesc,
        forms = SingleSpecies(Species.Kadabra),
    };
    public static PokedexData Alakazam = new()
    {
        number = 65,
        name = "Alakazam",
        category = "Psi",
        height = 150,
        weight = 48000,
        entry = AlakazamDesc,
        forms = new[]
        {
            Species.Alakazam,
            Species.AlakazamMega
        }
    };
    public static PokedexData Machop = new()
    {
        number = 66,
        name = "Machop",
        category = "Superpower",
        height = 80,
        weight = 19500,
        entry = MachopDesc,
        forms = SingleSpecies(Species.Machop),
    };
    public static PokedexData Machoke = new()
    {
        number = 67,
        name = "Machoke",
        category = "Superpower",
        height = 150,
        weight = 70500,
        entry = MachokeDesc,
        forms = SingleSpecies(Species.Machoke),
    };
    public static PokedexData Machamp = new()
    {
        number = 68,
        name = "Machamp",
        category = "Superpower",
        height = 160,
        weight = 130000,
        entry = MachampDesc,
        forms = SingleSpecies(Species.Machamp),
    };
    public static PokedexData Bellsprout = new()
    {
        number = 69,
        name = "Bellsprout",
        category = "Flower",
        height = 70,
        weight = 4000,
        entry = BellsproutDesc,
        forms = SingleSpecies(Species.Bellsprout),
    };
    public static PokedexData Weepinbell = new()
    {
        number = 70,
        name = "Weepinbell",
        category = "Flycatcher",
        height = 100,
        weight = 6400,
        entry = WeepinbellDesc,
        forms = SingleSpecies(Species.Weepinbell),
    };
    public static PokedexData Victreebel = new()
    {
        number = 71,
        name = "Victreebel",
        category = "Flycatcher",
        height = 170,
        weight = 15500,
        entry = VictreebelDesc,
        forms = SingleSpecies(Species.Victreebel),
    };
    public static PokedexData Tentacool = new()
    {
        number = 72,
        name = "Tentacool",
        category = "Jellyfish",
        height = 90,
        weight = 45500,
        entry = TentacoolDesc,
        forms = SingleSpecies(Species.Tentacool),
    };
    public static PokedexData Tentacruel = new()
    {
        number = 73,
        name = "Tentacruel",
        category = "Jellyfish",
        height = 160,
        weight = 55000,
        entry = TentacruelDesc,
        forms = SingleSpecies(Species.Tentacruel),
    };
    public static PokedexData Geodude = new()
    {
        number = 74,
        name = "Geodude",
        category = "Rock",
        height = 40,
        weight = 20000,
        entry = GeodudeDesc,
        forms = SingleSpecies(Species.Geodude),
    };
    public static PokedexData Graveler = new()
    {
        number = 75,
        name = "Graveler",
        category = "Rock",
        height = 100,
        weight = 105000,
        entry = GravelerDesc,
        forms = SingleSpecies(Species.Graveler),
    };
    public static PokedexData Golem = new()
    {
        number = 76,
        name = "Golem",
        category = "Megaton",
        height = 140,
        weight = 300000,
        entry = GolemDesc,
        forms = SingleSpecies(Species.Golem),
    };
    public static PokedexData Ponyta = new()
    {
        number = 77,
        name = "Ponyta",
        category = "FireHorse",
        height = 100,
        weight = 30000,
        entry = PonytaDesc,
        forms = SingleSpecies(Species.Ponyta),
    };
    public static PokedexData Rapidash = new()
    {
        number = 78,
        name = "Rapidash",
        category = "FireHorse",
        height = 170,
        weight = 95000,
        entry = RapidashDesc,
        forms = SingleSpecies(Species.Rapidash),
    };
    public static PokedexData Slowpoke = new()
    {
        number = 79,
        name = "Slowpoke",
        category = "Dopey",
        height = 120,
        weight = 36000,
        entry = SlowpokeDesc,
        forms = SingleSpecies(Species.Slowpoke),
    };
    public static PokedexData Slowbro = new()
    {
        number = 80,
        name = "Slowbro",
        category = "HermitCrab",
        height = 160,
        weight = 78500,
        entry = SlowbroDesc,
        forms = new[]
        {
            Species.Slowbro,
            Species.SlowbroMega
        }
    };
    public static PokedexData Magnemite = new()
    {
        number = 81,
        name = "Magnemite",
        category = "Magnet",
        height = 30,
        weight = 6000,
        entry = MagnemiteDesc,
        forms = SingleSpecies(Species.Magnemite),
    };
    public static PokedexData Magneton = new()
    {
        number = 82,
        name = "Magneton",
        category = "Magnet",
        height = 100,
        weight = 60000,
        entry = MagnetonDesc,
        forms = SingleSpecies(Species.Magneton),
    };
    public static PokedexData Farfetchd = new()
    {
        number = 83,
        name = "Farfetchd",
        category = "WildDuck",
        height = 80,
        weight = 15000,
        entry = FarfetchdDesc,
        forms = SingleSpecies(Species.Farfetchd),
    };
    public static PokedexData Doduo = new()
    {
        number = 84,
        name = "Doduo",
        category = "TwinBird",
        height = 140,
        weight = 39200,
        entry = DoduoDesc,
        forms = SingleSpecies(Species.Doduo),
    };
    public static PokedexData Dodrio = new()
    {
        number = 85,
        name = "Dodrio",
        category = "TripleBird",
        height = 180,
        weight = 85200,
        entry = DodrioDesc,
        forms = SingleSpecies(Species.Dodrio),
    };
    public static PokedexData Seel = new()
    {
        number = 86,
        name = "Seel",
        category = "SeaLion",
        height = 110,
        weight = 90000,
        entry = SeelDesc,
        forms = SingleSpecies(Species.Seel),
    };
    public static PokedexData Dewgong = new()
    {
        number = 87,
        name = "Dewgong",
        category = "SeaLion",
        height = 170,
        weight = 120000,
        entry = DewgongDesc,
        forms = SingleSpecies(Species.Dewgong),
    };
    public static PokedexData Grimer = new()
    {
        number = 88,
        name = "Grimer",
        category = "Sludge",
        height = 90,
        weight = 30000,
        entry = GrimerDesc,
        forms = SingleSpecies(Species.Grimer),
    };
    public static PokedexData Muk = new()
    {
        number = 89,
        name = "Muk",
        category = "Sludge",
        height = 120,
        weight = 30000,
        entry = MukDesc,
        forms = SingleSpecies(Species.Muk),
    };
    public static PokedexData Shellder = new()
    {
        number = 90,
        name = "Shellder",
        category = "Bivalve",
        height = 30,
        weight = 4000,
        entry = ShellderDesc,
        forms = SingleSpecies(Species.Shellder),
    };
    public static PokedexData Cloyster = new()
    {
        number = 91,
        name = "Cloyster",
        category = "Bivalve",
        height = 150,
        weight = 132500,
        entry = CloysterDesc,
        forms = SingleSpecies(Species.Cloyster),
    };
    public static PokedexData Gastly = new()
    {
        number = 92,
        name = "Gastly",
        category = "Gas",
        height = 130,
        weight = 100,
        entry = GastlyDesc,
        forms = SingleSpecies(Species.Gastly),
    };
    public static PokedexData Haunter = new()
    {
        number = 93,
        name = "Haunter",
        category = "Gas",
        height = 160,
        weight = 100,
        entry = HaunterDesc,
        forms = SingleSpecies(Species.Haunter),
    };
    public static PokedexData Gengar = new()
    {
        number = 94,
        name = "Gengar",
        category = "Shadow",
        height = 150,
        weight = 40500,
        entry = GengarDesc,
        forms = new[]
        {
            Species.Gengar,
            Species.GengarMega
        }
    };
    public static PokedexData Onix = new()
    {
        number = 95,
        name = "Onix",
        category = "RockSnake",
        height = 880,
        weight = 210000,
        entry = OnixDesc,
        forms = SingleSpecies(Species.Onix),
    };
    public static PokedexData Drowzee = new()
    {
        number = 96,
        name = "Drowzee",
        category = "Hypnosis",
        height = 100,
        weight = 32400,
        entry = DrowzeeDesc,
        forms = SingleSpecies(Species.Drowzee),
    };
    public static PokedexData Hypno = new()
    {
        number = 97,
        name = "Hypno",
        category = "Hypnosis",
        height = 160,
        weight = 75600,
        entry = HypnoDesc,
        forms = SingleSpecies(Species.Hypno),
    };
    public static PokedexData Krabby = new()
    {
        number = 98,
        name = "Krabby",
        category = "RiverCrab",
        height = 40,
        weight = 6500,
        entry = KrabbyDesc,
        forms = SingleSpecies(Species.Krabby),
    };
    public static PokedexData Kingler = new()
    {
        number = 99,
        name = "Kingler",
        category = "Pincer",
        height = 130,
        weight = 60000,
        entry = KinglerDesc,
        forms = SingleSpecies(Species.Kingler),
    };
    public static PokedexData Voltorb = new()
    {
        number = 100,
        name = "Voltorb",
        category = "Ball",
        height = 50,
        weight = 10400,
        entry = VoltorbDesc,
        forms = SingleSpecies(Species.Voltorb),
    };
    public static PokedexData Electrode = new()
    {
        number = 101,
        name = "Electrode",
        category = "Ball",
        height = 120,
        weight = 66600,
        entry = ElectrodeDesc,
        forms = SingleSpecies(Species.Electrode),
    };
    public static PokedexData Exeggcute = new()
    {
        number = 102,
        name = "Exeggcute",
        category = "Egg",
        height = 40,
        weight = 2500,
        entry = ExeggcuteDesc,
        forms = SingleSpecies(Species.Exeggcute),
    };
    public static PokedexData Exeggutor = new()
    {
        number = 103,
        name = "Exeggutor",
        category = "Coconut",
        height = 200,
        weight = 120000,
        entry = ExeggutorDesc,
        forms = SingleSpecies(Species.Exeggutor),
    };
    public static PokedexData Cubone = new()
    {
        number = 104,
        name = "Cubone",
        category = "Lonely",
        height = 40,
        weight = 6500,
        entry = CuboneDesc,
        forms = SingleSpecies(Species.Cubone),
    };
    public static PokedexData Marowak = new()
    {
        number = 105,
        name = "Marowak",
        category = "BoneKeeper",
        height = 100,
        weight = 45000,
        entry = MarowakDesc,
        forms = SingleSpecies(Species.Marowak),
    };
    public static PokedexData Hitmonlee = new()
    {
        number = 106,
        name = "Hitmonlee",
        category = "Kicking",
        height = 150,
        weight = 49800,
        entry = HitmonleeDesc,
        forms = SingleSpecies(Species.Hitmonlee),
    };
    public static PokedexData Hitmonchan = new()
    {
        number = 107,
        name = "Hitmonchan",
        category = "Punching",
        height = 140,
        weight = 50200,
        entry = HitmonchanDesc,
        forms = SingleSpecies(Species.Hitmonchan),
    };
    public static PokedexData Lickitung = new()
    {
        number = 108,
        name = "Lickitung",
        category = "Licking",
        height = 120,
        weight = 65500,
        entry = LickitungDesc,
        forms = SingleSpecies(Species.Lickitung),
    };
    public static PokedexData Koffing = new()
    {
        number = 109,
        name = "Koffing",
        category = "PoisonGas",
        height = 60,
        weight = 1000,
        entry = KoffingDesc,
        forms = SingleSpecies(Species.Koffing),
    };
    public static PokedexData Weezing = new()
    {
        number = 110,
        name = "Weezing",
        category = "PoisonGas",
        height = 120,
        weight = 9500,
        entry = WeezingDesc,
        forms = SingleSpecies(Species.Weezing),
    };
    public static PokedexData Rhyhorn = new()
    {
        number = 111,
        name = "Rhyhorn",
        category = "Spikes",
        height = 100,
        weight = 115000,
        entry = RhyhornDesc,
        forms = SingleSpecies(Species.Rhyhorn),
    };
    public static PokedexData Rhydon = new()
    {
        number = 112,
        name = "Rhydon",
        category = "Drill",
        height = 190,
        weight = 120000,
        entry = RhydonDesc,
        forms = SingleSpecies(Species.Rhydon),
    };
    public static PokedexData Chansey = new()
    {
        number = 113,
        name = "Chansey",
        category = "Egg",
        height = 110,
        weight = 34600,
        entry = ChanseyDesc,
        forms = SingleSpecies(Species.Chansey),
    };
    public static PokedexData Tangela = new()
    {
        number = 114,
        name = "Tangela",
        category = "Vine",
        height = 100,
        weight = 35000,
        entry = TangelaDesc,
        forms = SingleSpecies(Species.Tangela),
    };
    public static PokedexData Kangaskhan = new()
    {
        number = 115,
        name = "Kangaskhan",
        category = "Parent",
        height = 220,
        weight = 80000,
        entry = KangaskhanDesc,
        forms = new[]
        {
            Species.Kangaskhan,
            Species.KangaskhanMega
        }
    };
    public static PokedexData Horsea = new()
    {
        number = 116,
        name = "Horsea",
        category = "Dragon",
        height = 40,
        weight = 8000,
        entry = HorseaDesc,
        forms = SingleSpecies(Species.Horsea),
    };
    public static PokedexData Seadra = new()
    {
        number = 117,
        name = "Seadra",
        category = "Dragon",
        height = 120,
        weight = 25000,
        entry = SeadraDesc,
        forms = SingleSpecies(Species.Seadra),
    };
    public static PokedexData Goldeen = new()
    {
        number = 118,
        name = "Goldeen",
        category = "Goldfish",
        height = 60,
        weight = 15000,
        entry = GoldeenDesc,
        forms = SingleSpecies(Species.Goldeen),
    };
    public static PokedexData Seaking = new()
    {
        number = 119,
        name = "Seaking",
        category = "Goldfish",
        height = 130,
        weight = 39000,
        entry = SeakingDesc,
        forms = SingleSpecies(Species.Seaking),
    };
    public static PokedexData Staryu = new()
    {
        number = 120,
        name = "Staryu",
        category = "StarShape",
        height = 80,
        weight = 34500,
        entry = StaryuDesc,
        forms = SingleSpecies(Species.Staryu),
    };
    public static PokedexData Starmie = new()
    {
        number = 121,
        name = "Starmie",
        category = "Mysterious",
        height = 110,
        weight = 80000,
        entry = StarmieDesc,
        forms = SingleSpecies(Species.Starmie),
    };
    public static PokedexData MrMime = new()
    {
        number = 122,
        name = "Mr. Mime",
        category = "Barrier",
        height = 130,
        weight = 54500,
        entry = MrMimeDesc,
        forms = SingleSpecies(Species.MrMime),
    };
    public static PokedexData Scyther = new()
    {
        number = 123,
        name = "Scyther",
        category = "Mantis",
        height = 150,
        weight = 56000,
        entry = ScytherDesc,
        forms = SingleSpecies(Species.Scyther),
    };
    public static PokedexData Jynx = new()
    {
        number = 124,
        name = "Jynx",
        category = "HumanShape",
        height = 140,
        weight = 40600,
        entry = JynxDesc,
        forms = SingleSpecies(Species.Jynx),
    };
    public static PokedexData Electabuzz = new()
    {
        number = 125,
        name = "Electabuzz",
        category = "Electric",
        height = 110,
        weight = 30000,
        entry = ElectabuzzDesc,
        forms = SingleSpecies(Species.Electabuzz),
    };
    public static PokedexData Magmar = new()
    {
        number = 126,
        name = "Magmar",
        category = "Spitfire",
        height = 130,
        weight = 44500,
        entry = MagmarDesc,
        forms = SingleSpecies(Species.Magmar),
    };
    public static PokedexData Pinsir = new()
    {
        number = 127,
        name = "Pinsir",
        category = "StagBeetle",
        height = 150,
        weight = 55000,
        entry = PinsirDesc,
        forms = new[]
        {
            Species.Pinsir,
            Species.PinsirMega
        }
    };
    public static PokedexData Tauros = new()
    {
        number = 128,
        name = "Tauros",
        category = "WildBull",
        height = 140,
        weight = 88400,
        entry = TaurosDesc,
        forms = SingleSpecies(Species.Tauros),
    };
    public static PokedexData Magikarp = new()
    {
        number = 129,
        name = "Magikarp",
        category = "Fish",
        height = 90,
        weight = 10000,
        entry = MagikarpDesc,
        forms = SingleSpecies(Species.Magikarp),
    };
    public static PokedexData Gyarados = new()
    {
        number = 130,
        name = "Gyarados",
        category = "Atrocious",
        height = 650,
        weight = 235000,
        entry = GyaradosDesc,
        forms = new[]
        {
            Species.Gyarados,
            Species.GyaradosMega
        }
    };
    public static PokedexData Lapras = new()
    {
        number = 131,
        name = "Lapras",
        category = "Transport",
        height = 250,
        weight = 220000,
        entry = LaprasDesc,
        forms = SingleSpecies(Species.Lapras),
    };
    public static PokedexData Ditto = new()
    {
        number = 132,
        name = "Ditto",
        category = "Transform",
        height = 30,
        weight = 4000,
        entry = DittoDesc,
        forms = SingleSpecies(Species.Ditto),
    };
    public static PokedexData Eevee = new()
    {
        number = 133,
        name = "Eevee",
        category = "Evolution",
        height = 30,
        weight = 6500,
        entry = EeveeDesc,
        forms = SingleSpecies(Species.Eevee),
    };
    public static PokedexData Vaporeon = new()
    {
        number = 134,
        name = "Vaporeon",
        category = "BubbleJet",
        height = 100,
        weight = 29000,
        entry = VaporeonDesc,
        forms = SingleSpecies(Species.Vaporeon),
    };
    public static PokedexData Jolteon = new()
    {
        number = 135,
        name = "Jolteon",
        category = "Lightning",
        height = 80,
        weight = 24500,
        entry = JolteonDesc,
        forms = SingleSpecies(Species.Jolteon),
    };
    public static PokedexData Flareon = new()
    {
        number = 136,
        name = "Flareon",
        category = "Flame",
        height = 90,
        weight = 25000,
        entry = FlareonDesc,
        forms = SingleSpecies(Species.Flareon),
    };
    public static PokedexData Porygon = new()
    {
        number = 137,
        name = "Porygon",
        category = "Virtual",
        height = 80,
        weight = 36500,
        entry = PorygonDesc,
        forms = SingleSpecies(Species.Porygon),
    };
    public static PokedexData Omanyte = new()
    {
        number = 138,
        name = "Omanyte",
        category = "Spiral",
        height = 40,
        weight = 7500,
        entry = OmanyteDesc,
        forms = SingleSpecies(Species.Omanyte),
    };
    public static PokedexData Omastar = new()
    {
        number = 139,
        name = "Omastar",
        category = "Spiral",
        height = 100,
        weight = 35000,
        entry = OmastarDesc,
        forms = SingleSpecies(Species.Omastar),
    };
    public static PokedexData Kabuto = new()
    {
        number = 140,
        name = "Kabuto",
        category = "Shellfish",
        height = 50,
        weight = 11500,
        entry = KabutoDesc,
        forms = SingleSpecies(Species.Kabuto),
    };
    public static PokedexData Kabutops = new()
    {
        number = 141,
        name = "Kabutops",
        category = "Shellfish",
        height = 130,
        weight = 40500,
        entry = KabutopsDesc,
        forms = SingleSpecies(Species.Kabutops),
    };
    public static PokedexData Aerodactyl = new()
    {
        number = 142,
        name = "Aerodactyl",
        category = "Fossil",
        height = 180,
        weight = 59000,
        entry = AerodactylDesc,
        forms = new[]
        {
            Species.Aerodactyl,
            Species.AerodactylMega
        }
    };
    public static PokedexData Snorlax = new()
    {
        number = 143,
        name = "Snorlax",
        category = "Sleeping",
        height = 210,
        weight = 460000,
        entry = SnorlaxDesc,
        forms = SingleSpecies(Species.Snorlax),
    };
    public static PokedexData Articuno = new()
    {
        number = 144,
        name = "Articuno",
        category = "Freeze",
        height = 170,
        weight = 55400,
        entry = ArticunoDesc,
        forms = SingleSpecies(Species.Articuno),
    };
    public static PokedexData Zapdos = new()
    {
        number = 145,
        name = "Zapdos",
        category = "Electric",
        height = 160,
        weight = 52600,
        entry = ZapdosDesc,
        forms = SingleSpecies(Species.Zapdos),
    };
    public static PokedexData Moltres = new()
    {
        number = 146,
        name = "Moltres",
        category = "Flame",
        height = 200,
        weight = 60000,
        entry = MoltresDesc,
        forms = SingleSpecies(Species.Moltres),
    };
    public static PokedexData Dratini = new()
    {
        number = 147,
        name = "Dratini",
        category = "Dragon",
        height = 180,
        weight = 3300,
        entry = DratiniDesc,
        forms = SingleSpecies(Species.Dratini),
    };
    public static PokedexData Dragonair = new()
    {
        number = 148,
        name = "Dragonair",
        category = "Dragon",
        height = 400,
        weight = 16500,
        entry = DragonairDesc,
        forms = SingleSpecies(Species.Dragonair),
    };
    public static PokedexData Dragonite = new()
    {
        number = 149,
        name = "Dragonite",
        category = "Dragon",
        height = 220,
        weight = 210000,
        entry = DragoniteDesc,
        forms = SingleSpecies(Species.Dragonite),
    };
    public static PokedexData Mewtwo = new()
    {
        number = 150,
        name = "Mewtwo",
        category = "Genetic",
        height = 200,
        weight = 122000,
        entry = MewtwoDesc,
        forms = new[]
        {
            Species.Mewtwo,
            Species.MewtwoMegaX,
            Species.MewtwoMegaY
        }
    };
    public static PokedexData Mew = new()
    {
        number = 151,
        name = "Mew",
        category = "NewSpecies",
        height = 40,
        weight = 4000,
        entry = MewDesc,
        forms = SingleSpecies(Species.Mew),
    };
    public static PokedexData Chikorita = new()
    {
        number = 152,
        name = "Chikorita",
        category = "Leaf",
        height = 90,
        weight = 6400,
        entry = ChikoritaDesc,
        forms = SingleSpecies(Species.Chikorita),
    };
    public static PokedexData Bayleef = new()
    {
        number = 153,
        name = "Bayleef",
        category = "Leaf",
        height = 120,
        weight = 15800,
        entry = BayleefDesc,
        forms = SingleSpecies(Species.Bayleef),
    };
    public static PokedexData Meganium = new()
    {
        number = 154,
        name = "Meganium",
        category = "Herb",
        height = 180,
        weight = 100500,
        entry = MeganiumDesc,
        forms = SingleSpecies(Species.Meganium),
    };
    public static PokedexData Cyndaquil = new()
    {
        number = 155,
        name = "Cyndaquil",
        category = "FireMouse",
        height = 50,
        weight = 7900,
        entry = CyndaquilDesc,
        forms = SingleSpecies(Species.Cyndaquil),
    };
    public static PokedexData Quilava = new()
    {
        number = 156,
        name = "Quilava",
        category = "Volcano",
        height = 90,
        weight = 19000,
        entry = QuilavaDesc,
        forms = SingleSpecies(Species.Quilava),
    };
    public static PokedexData Typhlosion = new()
    {
        number = 157,
        name = "Typhlosion",
        category = "Volcano",
        height = 170,
        weight = 79500,
        entry = TyphlosionDesc,
        forms = SingleSpecies(Species.Typhlosion),
    };
    public static PokedexData Totodile = new()
    {
        number = 158,
        name = "Totodile",
        category = "BigJaw",
        height = 60,
        weight = 9500,
        entry = TotodileDesc,
        forms = SingleSpecies(Species.Totodile),
    };
    public static PokedexData Croconaw = new()
    {
        number = 159,
        name = "Croconaw",
        category = "BigJaw",
        height = 110,
        weight = 25000,
        entry = CroconawDesc,
        forms = SingleSpecies(Species.Croconaw),
    };
    public static PokedexData Feraligatr = new()
    {
        number = 160,
        name = "Feraligatr",
        category = "BigJaw",
        height = 230,
        weight = 88800,
        entry = FeraligatrDesc,
        forms = SingleSpecies(Species.Feraligatr),
    };
    public static PokedexData Sentret = new()
    {
        number = 161,
        name = "Sentret",
        category = "Scout",
        height = 80,
        weight = 6000,
        entry = SentretDesc,
        forms = SingleSpecies(Species.Sentret),
    };
    public static PokedexData Furret = new()
    {
        number = 162,
        name = "Furret",
        category = "LongBody",
        height = 180,
        weight = 32500,
        entry = FurretDesc,
        forms = SingleSpecies(Species.Furret),
    };
    public static PokedexData Hoothoot = new()
    {
        number = 163,
        name = "Hoothoot",
        category = "Owl",
        height = 70,
        weight = 21200,
        entry = HoothootDesc,
        forms = SingleSpecies(Species.Hoothoot),
    };
    public static PokedexData Noctowl = new()
    {
        number = 164,
        name = "Noctowl",
        category = "Owl",
        height = 160,
        weight = 40800,
        entry = NoctowlDesc,
        forms = SingleSpecies(Species.Noctowl),
    };
    public static PokedexData Ledyba = new()
    {
        number = 165,
        name = "Ledyba",
        category = "FiveStar",
        height = 100,
        weight = 10800,
        entry = LedybaDesc,
        forms = SingleSpecies(Species.Ledyba),
    };
    public static PokedexData Ledian = new()
    {
        number = 166,
        name = "Ledian",
        category = "FiveStar",
        height = 140,
        weight = 35600,
        entry = LedianDesc,
        forms = SingleSpecies(Species.Ledian),
    };
    public static PokedexData Spinarak = new()
    {
        number = 167,
        name = "Spinarak",
        category = "StringSpit",
        height = 50,
        weight = 8500,
        entry = SpinarakDesc,
        forms = SingleSpecies(Species.Spinarak),
    };
    public static PokedexData Ariados = new()
    {
        number = 168,
        name = "Ariados",
        category = "LongLeg",
        height = 110,
        weight = 33500,
        entry = AriadosDesc,
        forms = SingleSpecies(Species.Ariados),
    };
    public static PokedexData Crobat = new()
    {
        number = 169,
        name = "Crobat",
        category = "Bat",
        height = 180,
        weight = 75000,
        entry = CrobatDesc,
        forms = SingleSpecies(Species.Crobat),
    };
    public static PokedexData Chinchou = new()
    {
        number = 170,
        name = "Chinchou",
        category = "Angler",
        height = 50,
        weight = 12000,
        entry = ChinchouDesc,
        forms = SingleSpecies(Species.Chinchou),
    };
    public static PokedexData Lanturn = new()
    {
        number = 171,
        name = "Lanturn",
        category = "Light",
        height = 120,
        weight = 22500,
        entry = LanturnDesc,
        forms = SingleSpecies(Species.Lanturn),
    };
    public static PokedexData Pichu = new()
    {
        number = 172,
        name = "Pichu",
        category = "TinyMouse",
        height = 30,
        weight = 2000,
        entry = PichuDesc,
        forms = SingleSpecies(Species.Pichu),
    };
    public static PokedexData Cleffa = new()
    {
        number = 173,
        name = "Cleffa",
        category = "StarShape",
        height = 30,
        weight = 3000,
        entry = CleffaDesc,
        forms = SingleSpecies(Species.Cleffa),
    };
    public static PokedexData Igglybuff = new()
    {
        number = 174,
        name = "Igglybuff",
        category = "Balloon",
        height = 30,
        weight = 1000,
        entry = IgglybuffDesc,
        forms = SingleSpecies(Species.Igglybuff),
    };
    public static PokedexData Togepi = new()
    {
        number = 175,
        name = "Togepi",
        category = "SpikeBall",
        height = 30,
        weight = 1500,
        entry = TogepiDesc,
        forms = SingleSpecies(Species.Togepi),
    };
    public static PokedexData Togetic = new()
    {
        number = 176,
        name = "Togetic",
        category = "Happiness",
        height = 60,
        weight = 3200,
        entry = TogeticDesc,
        forms = SingleSpecies(Species.Togetic),
    };
    public static PokedexData Natu = new()
    {
        number = 177,
        name = "Natu",
        category = "TinyBird",
        height = 20,
        weight = 2000,
        entry = NatuDesc,
        forms = SingleSpecies(Species.Natu),
    };
    public static PokedexData Xatu = new()
    {
        number = 178,
        name = "Xatu",
        category = "Mystic",
        height = 150,
        weight = 15000,
        entry = XatuDesc,
        forms = SingleSpecies(Species.Xatu),
    };
    public static PokedexData Mareep = new()
    {
        number = 179,
        name = "Mareep",
        category = "Wool",
        height = 60,
        weight = 7800,
        entry = MareepDesc,
        forms = SingleSpecies(Species.Mareep),
    };
    public static PokedexData Flaaffy = new()
    {
        number = 180,
        name = "Flaaffy",
        category = "Wool",
        height = 80,
        weight = 13300,
        entry = FlaaffyDesc,
        forms = SingleSpecies(Species.Flaaffy),
    };
    public static PokedexData Ampharos = new()
    {
        number = 181,
        name = "Ampharos",
        category = "Light",
        height = 140,
        weight = 61500,
        entry = AmpharosDesc,
        forms = new[]
        {
            Species.Ampharos,
            Species.AmpharosMega
        }
    };
    public static PokedexData Bellossom = new()
    {
        number = 182,
        name = "Bellossom",
        category = "Flower",
        height = 40,
        weight = 5800,
        entry = BellossomDesc,
        forms = SingleSpecies(Species.Bellossom),
    };
    public static PokedexData Marill = new()
    {
        number = 183,
        name = "Marill",
        category = "AquaMouse",
        height = 40,
        weight = 8500,
        entry = MarillDesc,
        forms = SingleSpecies(Species.Marill),
    };
    public static PokedexData Azumarill = new()
    {
        number = 184,
        name = "Azumarill",
        category = "AquaRabbit",
        height = 80,
        weight = 28500,
        entry = AzumarillDesc,
        forms = SingleSpecies(Species.Azumarill),
    };
    public static PokedexData Sudowoodo = new()
    {
        number = 185,
        name = "Sudowoodo",
        category = "Imitation",
        height = 120,
        weight = 38000,
        entry = SudowoodoDesc,
        forms = SingleSpecies(Species.Sudowoodo),
    };
    public static PokedexData Politoed = new()
    {
        number = 186,
        name = "Politoed",
        category = "Frog",
        height = 110,
        weight = 33900,
        entry = PolitoedDesc,
        forms = SingleSpecies(Species.Politoed),
    };
    public static PokedexData Hoppip = new()
    {
        number = 187,
        name = "Hoppip",
        category = "Cottonweed",
        height = 40,
        weight = 500,
        entry = HoppipDesc,
        forms = SingleSpecies(Species.Hoppip),
    };
    public static PokedexData Skiploom = new()
    {
        number = 188,
        name = "Skiploom",
        category = "Cottonweed",
        height = 60,
        weight = 1000,
        entry = SkiploomDesc,
        forms = SingleSpecies(Species.Skiploom),
    };
    public static PokedexData Jumpluff = new()
    {
        number = 189,
        name = "Jumpluff",
        category = "Cottonweed",
        height = 80,
        weight = 3000,
        entry = JumpluffDesc,
        forms = SingleSpecies(Species.Jumpluff),
    };
    public static PokedexData Aipom = new()
    {
        number = 190,
        name = "Aipom",
        category = "LongTail",
        height = 80,
        weight = 11500,
        entry = AipomDesc,
        forms = SingleSpecies(Species.Aipom),
    };
    public static PokedexData Sunkern = new()
    {
        number = 191,
        name = "Sunkern",
        category = "Seed",
        height = 30,
        weight = 1800,
        entry = SunkernDesc,
        forms = SingleSpecies(Species.Sunkern),
    };
    public static PokedexData Sunflora = new()
    {
        number = 192,
        name = "Sunflora",
        category = "Sun",
        height = 80,
        weight = 8500,
        entry = SunfloraDesc,
        forms = SingleSpecies(Species.Sunflora),
    };
    public static PokedexData Yanma = new()
    {
        number = 193,
        name = "Yanma",
        category = "ClearWing",
        height = 120,
        weight = 38000,
        entry = YanmaDesc,
        forms = SingleSpecies(Species.Yanma),
    };
    public static PokedexData Wooper = new()
    {
        number = 194,
        name = "Wooper",
        category = "WaterFish",
        height = 40,
        weight = 8500,
        entry = WooperDesc,
        forms = SingleSpecies(Species.Wooper),
    };
    public static PokedexData Quagsire = new()
    {
        number = 195,
        name = "Quagsire",
        category = "WaterFish",
        height = 140,
        weight = 75000,
        entry = QuagsireDesc,
        forms = SingleSpecies(Species.Quagsire),
    };
    public static PokedexData Espeon = new()
    {
        number = 196,
        name = "Espeon",
        category = "Sun",
        height = 90,
        weight = 26500,
        entry = EspeonDesc,
        forms = SingleSpecies(Species.Espeon),
    };
    public static PokedexData Umbreon = new()
    {
        number = 197,
        name = "Umbreon",
        category = "Moonlight",
        height = 100,
        weight = 27000,
        entry = UmbreonDesc,
        forms = SingleSpecies(Species.Umbreon),
    };
    public static PokedexData Murkrow = new()
    {
        number = 198,
        name = "Murkrow",
        category = "Darkness",
        height = 50,
        weight = 2100,
        entry = MurkrowDesc,
        forms = SingleSpecies(Species.Murkrow),
    };
    public static PokedexData Slowking = new()
    {
        number = 199,
        name = "Slowking",
        category = "Royal",
        height = 200,
        weight = 79500,
        entry = SlowkingDesc,
        forms = SingleSpecies(Species.Slowking),
    };
    public static PokedexData Misdreavus = new()
    {
        number = 200,
        name = "Misdreavus",
        category = "Screech",
        height = 70,
        weight = 1000,
        entry = MisdreavusDesc,
        forms = SingleSpecies(Species.Misdreavus),
    };
    public static PokedexData Unown = new()
    {
        number = 201,
        name = "Unown",
        category = "Symbol",
        height = 50,
        weight = 5000,
        entry = UnownDesc,
        forms = new[]
        {
            Species.Unown,
            Species.Unown_B,
            Species.Unown_C,
            Species.Unown_D,
            Species.Unown_E,
            Species.Unown_F,
            Species.Unown_G,
            Species.Unown_H,
            Species.Unown_I,
            Species.Unown_J,
            Species.Unown_K,
            Species.Unown_L,
            Species.Unown_M,
            Species.Unown_N,
            Species.Unown_O,
            Species.Unown_P,
            Species.Unown_Q,
            Species.Unown_R,
            Species.Unown_S,
            Species.Unown_T,
            Species.Unown_U,
            Species.Unown_V,
            Species.Unown_W,
            Species.Unown_X,
            Species.Unown_Y,
            Species.Unown_Z,
        }
    };
    public static PokedexData Wobbuffet = new()
    {
        number = 202,
        name = "Wobbuffet",
        category = "Patient",
        height = 130,
        weight = 28500,
        entry = WobbuffetDesc,
        forms = SingleSpecies(Species.Wobbuffet),
    };
    public static PokedexData Girafarig = new()
    {
        number = 203,
        name = "Girafarig",
        category = "LongNeck",
        height = 150,
        weight = 41500,
        entry = GirafarigDesc,
        forms = SingleSpecies(Species.Girafarig),
    };
    public static PokedexData Pineco = new()
    {
        number = 204,
        name = "Pineco",
        category = "Bagworm",
        height = 60,
        weight = 7200,
        entry = PinecoDesc,
        forms = SingleSpecies(Species.Pineco),
    };
    public static PokedexData Forretress = new()
    {
        number = 205,
        name = "Forretress",
        category = "Bagworm",
        height = 120,
        weight = 125800,
        entry = ForretressDesc,
        forms = SingleSpecies(Species.Forretress),
    };
    public static PokedexData Dunsparce = new()
    {
        number = 206,
        name = "Dunsparce",
        category = "LandSnake",
        height = 150,
        weight = 14000,
        entry = DunsparceDesc,
        forms = SingleSpecies(Species.Dunsparce),
    };
    public static PokedexData Gligar = new()
    {
        number = 207,
        name = "Gligar",
        category = "FlyScorpion",
        height = 110,
        weight = 64800,
        entry = GligarDesc,
        forms = SingleSpecies(Species.Gligar),
    };
    public static PokedexData Steelix = new()
    {
        number = 208,
        name = "Steelix",
        category = "IronSnake",
        height = 920,
        weight = 400000,
        entry = SteelixDesc,
        forms = new[]
        {
            Species.Steelix,
            Species.SteelixMega
        }
    };
    public static PokedexData Snubbull = new()
    {
        number = 209,
        name = "Snubbull",
        category = "Fairy",
        height = 60,
        weight = 7800,
        entry = SnubbullDesc,
        forms = SingleSpecies(Species.Snubbull),
    };
    public static PokedexData Granbull = new()
    {
        number = 210,
        name = "Granbull",
        category = "Fairy",
        height = 140,
        weight = 48700,
        entry = GranbullDesc,
        forms = SingleSpecies(Species.Granbull),
    };
    public static PokedexData Qwilfish = new()
    {
        number = 211,
        name = "Qwilfish",
        category = "Balloon",
        height = 50,
        weight = 3900,
        entry = QwilfishDesc,
        forms = SingleSpecies(Species.Qwilfish),
    };
    public static PokedexData Scizor = new()
    {
        number = 212,
        name = "Scizor",
        category = "Pincer",
        height = 180,
        weight = 118000,
        entry = ScizorDesc,
        forms = new[]
        {
            Species.Scizor,
            Species.ScizorMega
        }
    };
    public static PokedexData Shuckle = new()
    {
        number = 213,
        name = "Shuckle",
        category = "Mold",
        height = 60,
        weight = 20500,
        entry = ShuckleDesc,
        forms = SingleSpecies(Species.Shuckle),
    };
    public static PokedexData Heracross = new()
    {
        number = 214,
        name = "Heracross",
        category = "SingleHorn",
        height = 150,
        weight = 54000,
        entry = HeracrossDesc,
        forms = new[]
        {
            Species.Heracross,
            Species.HeracrossMega
        }
    };
    public static PokedexData Sneasel = new()
    {
        number = 215,
        name = "Sneasel",
        category = "SharpClaw",
        height = 90,
        weight = 28000,
        entry = SneaselDesc,
        forms = SingleSpecies(Species.Sneasel),
    };
    public static PokedexData Teddiursa = new()
    {
        number = 216,
        name = "Teddiursa",
        category = "LittleBear",
        height = 60,
        weight = 8800,
        entry = TeddiursaDesc,
        forms = SingleSpecies(Species.Teddiursa),
    };
    public static PokedexData Ursaring = new()
    {
        number = 217,
        name = "Ursaring",
        category = "Hibernator",
        height = 180,
        weight = 125800,
        entry = UrsaringDesc,
        forms = SingleSpecies(Species.Ursaring),
    };
    public static PokedexData Slugma = new()
    {
        number = 218,
        name = "Slugma",
        category = "Lava",
        height = 70,
        weight = 35000,
        entry = SlugmaDesc,
        forms = SingleSpecies(Species.Slugma),
    };
    public static PokedexData Magcargo = new()
    {
        number = 219,
        name = "Magcargo",
        category = "Lava",
        height = 80,
        weight = 55000,
        entry = MagcargoDesc,
        forms = SingleSpecies(Species.Magcargo),
    };
    public static PokedexData Swinub = new()
    {
        number = 220,
        name = "Swinub",
        category = "Pig",
        height = 40,
        weight = 6500,
        entry = SwinubDesc,
        forms = SingleSpecies(Species.Swinub),
    };
    public static PokedexData Piloswine = new()
    {
        number = 221,
        name = "Piloswine",
        category = "Swine",
        height = 110,
        weight = 55800,
        entry = PiloswineDesc,
        forms = SingleSpecies(Species.Piloswine),
    };
    public static PokedexData Corsola = new()
    {
        number = 222,
        name = "Corsola",
        category = "Coral",
        height = 60,
        weight = 5000,
        entry = CorsolaDesc,
        forms = SingleSpecies(Species.Corsola),
    };
    public static PokedexData Remoraid = new()
    {
        number = 223,
        name = "Remoraid",
        category = "Jet",
        height = 60,
        weight = 12000,
        entry = RemoraidDesc,
        forms = SingleSpecies(Species.Remoraid),
    };
    public static PokedexData Octillery = new()
    {
        number = 224,
        name = "Octillery",
        category = "Jet",
        height = 90,
        weight = 28500,
        entry = OctilleryDesc,
        forms = SingleSpecies(Species.Octillery),
    };
    public static PokedexData Delibird = new()
    {
        number = 225,
        name = "Delibird",
        category = "Delivery",
        height = 90,
        weight = 16000,
        entry = DelibirdDesc,
        forms = SingleSpecies(Species.Delibird),
    };
    public static PokedexData Mantine = new()
    {
        number = 226,
        name = "Mantine",
        category = "Kite",
        height = 210,
        weight = 220000,
        entry = MantineDesc,
        forms = SingleSpecies(Species.Mantine),
    };
    public static PokedexData Skarmory = new()
    {
        number = 227,
        name = "Skarmory",
        category = "ArmorBird",
        height = 170,
        weight = 50500,
        entry = SkarmoryDesc,
        forms = SingleSpecies(Species.Skarmory),
    };
    public static PokedexData Houndour = new()
    {
        number = 228,
        name = "Houndour",
        category = "Dark",
        height = 60,
        weight = 10800,
        entry = HoundourDesc,
        forms = SingleSpecies(Species.Houndour),
    };
    public static PokedexData Houndoom = new()
    {
        number = 229,
        name = "Houndoom",
        category = "Dark",
        height = 140,
        weight = 35000,
        entry = HoundoomDesc,
        forms = new[]
        {
            Species.Houndoom,
            Species.HoundoomMega
        }
    };
    public static PokedexData Kingdra = new()
    {
        number = 230,
        name = "Kingdra",
        category = "Dragon",
        height = 180,
        weight = 152000,
        entry = KingdraDesc,
        forms = SingleSpecies(Species.Kingdra),
    };
    public static PokedexData Phanpy = new()
    {
        number = 231,
        name = "Phanpy",
        category = "LongNose",
        height = 50,
        weight = 33500,
        entry = PhanpyDesc,
        forms = SingleSpecies(Species.Phanpy),
    };
    public static PokedexData Donphan = new()
    {
        number = 232,
        name = "Donphan",
        category = "Armor",
        height = 110,
        weight = 120000,
        entry = DonphanDesc,
        forms = SingleSpecies(Species.Donphan),
    };
    public static PokedexData Porygon2 = new()
    {
        number = 233,
        name = "Porygon2",
        category = "Virtual",
        height = 60,
        weight = 32500,
        entry = Porygon2Desc,
        forms = SingleSpecies(Species.Porygon2),
    };
    public static PokedexData Stantler = new()
    {
        number = 234,
        name = "Stantler",
        category = "BigHorn",
        height = 140,
        weight = 71200,
        entry = StantlerDesc,
        forms = SingleSpecies(Species.Stantler),
    };
    public static PokedexData Smeargle = new()
    {
        number = 235,
        name = "Smeargle",
        category = "Painter",
        height = 120,
        weight = 58000,
        entry = SmeargleDesc,
        forms = SingleSpecies(Species.Smeargle),
    };
    public static PokedexData Tyrogue = new()
    {
        number = 236,
        name = "Tyrogue",
        category = "Scuffle",
        height = 70,
        weight = 21000,
        entry = TyrogueDesc,
        forms = SingleSpecies(Species.Tyrogue),
    };
    public static PokedexData Hitmontop = new()
    {
        number = 237,
        name = "Hitmontop",
        category = "Handstand",
        height = 140,
        weight = 48000,
        entry = HitmontopDesc,
        forms = SingleSpecies(Species.Hitmontop),
    };
    public static PokedexData Smoochum = new()
    {
        number = 238,
        name = "Smoochum",
        category = "Kiss",
        height = 40,
        weight = 6000,
        entry = SmoochumDesc,
        forms = SingleSpecies(Species.Smoochum),
    };
    public static PokedexData Elekid = new()
    {
        number = 239,
        name = "Elekid",
        category = "Electric",
        height = 60,
        weight = 23500,
        entry = ElekidDesc,
        forms = SingleSpecies(Species.Elekid),
    };
    public static PokedexData Magby = new()
    {
        number = 240,
        name = "Magby",
        category = "LiveCoal",
        height = 70,
        weight = 21400,
        entry = MagbyDesc,
        forms = SingleSpecies(Species.Magby),
    };
    public static PokedexData Miltank = new()
    {
        number = 241,
        name = "Miltank",
        category = "MilkCow",
        height = 120,
        weight = 75500,
        entry = MiltankDesc,
        forms = SingleSpecies(Species.Miltank),
    };
    public static PokedexData Blissey = new()
    {
        number = 242,
        name = "Blissey",
        category = "Happiness",
        height = 150,
        weight = 46800,
        entry = BlisseyDesc,
        forms = SingleSpecies(Species.Blissey),
    };
    public static PokedexData Raikou = new()
    {
        number = 243,
        name = "Raikou",
        category = "Thunder",
        height = 190,
        weight = 178000,
        entry = RaikouDesc,
        forms = SingleSpecies(Species.Raikou),
    };
    public static PokedexData Entei = new()
    {
        number = 244,
        name = "Entei",
        category = "Volcano",
        height = 210,
        weight = 198000,
        entry = EnteiDesc,
        forms = SingleSpecies(Species.Entei),
    };
    public static PokedexData Suicune = new()
    {
        number = 245,
        name = "Suicune",
        category = "Aurora",
        height = 200,
        weight = 187000,
        entry = SuicuneDesc,
        forms = SingleSpecies(Species.Suicune),
    };
    public static PokedexData Larvitar = new()
    {
        number = 246,
        name = "Larvitar",
        category = "RockSkin",
        height = 60,
        weight = 72000,
        entry = LarvitarDesc,
        forms = SingleSpecies(Species.Larvitar),
    };
    public static PokedexData Pupitar = new()
    {
        number = 247,
        name = "Pupitar",
        category = "HardShell",
        height = 120,
        weight = 152000,
        entry = PupitarDesc,
        forms = SingleSpecies(Species.Pupitar),
    };
    public static PokedexData Tyranitar = new()
    {
        number = 248,
        name = "Tyranitar",
        category = "Armor",
        height = 200,
        weight = 202000,
        entry = TyranitarDesc,
        forms = new[]
        {
            Species.Tyranitar,
            Species.TyranitarMega
        }
    };
    public static PokedexData Lugia = new()
    {
        number = 249,
        name = "Lugia",
        category = "Diving",
        height = 520,
        weight = 216000,
        entry = LugiaDesc,
        forms = SingleSpecies(Species.Lugia),
    };
    public static PokedexData HoOh = new()
    {
        number = 250,
        name = "Ho Oh",
        category = "Rainbow",
        height = 380,
        weight = 199000,
        entry = HoOhDesc,
        forms = SingleSpecies(Species.HoOh),
    };
    public static PokedexData Celebi = new()
    {
        number = 251,
        name = "Celebi",
        category = "TimeTravel",
        height = 60,
        weight = 5000,
        entry = CelebiDesc,
        forms = SingleSpecies(Species.Celebi),
    };
    public static PokedexData Treecko = new()
    {
        number = 252,
        name = "Treecko",
        category = "WoodGecko",
        height = 50,
        weight = 5000,
        entry = TreeckoDesc,
        forms = SingleSpecies(Species.Treecko),
    };
    public static PokedexData Grovyle = new()
    {
        number = 253,
        name = "Grovyle",
        category = "WoodGecko",
        height = 90,
        weight = 21600,
        entry = GrovyleDesc,
        forms = SingleSpecies(Species.Grovyle),
    };
    public static PokedexData Sceptile = new()
    {
        number = 254,
        name = "Sceptile",
        category = "Forest",
        height = 170,
        weight = 52200,
        entry = SceptileDesc,
        forms = new[]
        {
            Species.Sceptile,
            Species.SceptileMega
        }
    };
    public static PokedexData Torchic = new()
    {
        number = 255,
        name = "Torchic",
        category = "Chick",
        height = 40,
        weight = 2500,
        entry = TorchicDesc,
        forms = SingleSpecies(Species.Torchic),
    };
    public static PokedexData Combusken = new()
    {
        number = 256,
        name = "Combusken",
        category = "YoungFowl",
        height = 90,
        weight = 19500,
        entry = CombuskenDesc,
        forms = SingleSpecies(Species.Combusken),
    };
    public static PokedexData Blaziken = new()
    {
        number = 257,
        name = "Blaziken",
        category = "Blaze",
        height = 190,
        weight = 52000,
        entry = BlazikenDesc,
        forms = new[]
        {
            Species.Blaziken,
            Species.BlazikenMega
        }
    };
    public static PokedexData Mudkip = new()
    {
        number = 258,
        name = "Mudkip",
        category = "MudFish",
        height = 40,
        weight = 7600,
        entry = MudkipDesc,
        forms = SingleSpecies(Species.Mudkip),
    };
    public static PokedexData Marshtomp = new()
    {
        number = 259,
        name = "Marshtomp",
        category = "MudFish",
        height = 70,
        weight = 28000,
        entry = MarshtompDesc,
        forms = SingleSpecies(Species.Marshtomp),
    };
    public static PokedexData Swampert = new()
    {
        number = 260,
        name = "Swampert",
        category = "MudFish",
        height = 150,
        weight = 81900,
        entry = SwampertDesc,
        forms = new[]
        {
            Species.Swampert,
            Species.SwampertMega
        }
    };
    public static PokedexData Poochyena = new()
    {
        number = 261,
        name = "Poochyena",
        category = "Bite",
        height = 50,
        weight = 13600,
        entry = PoochyenaDesc,
        forms = SingleSpecies(Species.Poochyena),
    };
    public static PokedexData Mightyena = new()
    {
        number = 262,
        name = "Mightyena",
        category = "Bite",
        height = 100,
        weight = 37000,
        entry = MightyenaDesc,
        forms = SingleSpecies(Species.Mightyena),
    };
    public static PokedexData Zigzagoon = new()
    {
        number = 263,
        name = "Zigzagoon",
        category = "TinyRaccoon",
        height = 40,
        weight = 17500,
        entry = ZigzagoonDesc,
        forms = SingleSpecies(Species.Zigzagoon),
    };
    public static PokedexData Linoone = new()
    {
        number = 264,
        name = "Linoone",
        category = "Rushing",
        height = 50,
        weight = 32500,
        entry = LinooneDesc,
        forms = SingleSpecies(Species.Linoone),
    };
    public static PokedexData Wurmple = new()
    {
        number = 265,
        name = "Wurmple",
        category = "Worm",
        height = 30,
        weight = 3600,
        entry = WurmpleDesc,
        forms = SingleSpecies(Species.Wurmple),
    };
    public static PokedexData Silcoon = new()
    {
        number = 266,
        name = "Silcoon",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = SilcoonDesc,
        forms = SingleSpecies(Species.Silcoon),
    };
    public static PokedexData Beautifly = new()
    {
        number = 267,
        name = "Beautifly",
        category = "Butterfly",
        height = 100,
        weight = 28400,
        entry = BeautiflyDesc,
        forms = SingleSpecies(Species.Beautifly),
    };
    public static PokedexData Cascoon = new()
    {
        number = 268,
        name = "Cascoon",
        category = "Cocoon",
        height = 70,
        weight = 11500,
        entry = CascoonDesc,
        forms = SingleSpecies(Species.Cascoon),
    };
    public static PokedexData Dustox = new()
    {
        number = 269,
        name = "Dustox",
        category = "PoisonMoth",
        height = 120,
        weight = 31600,
        entry = DustoxDesc,
        forms = SingleSpecies(Species.Dustox),
    };
    public static PokedexData Lotad = new()
    {
        number = 270,
        name = "Lotad",
        category = "WaterWeed",
        height = 50,
        weight = 2600,
        entry = LotadDesc,
        forms = SingleSpecies(Species.Lotad),
    };
    public static PokedexData Lombre = new()
    {
        number = 271,
        name = "Lombre",
        category = "Jolly",
        height = 120,
        weight = 32500,
        entry = LombreDesc,
        forms = SingleSpecies(Species.Lombre),
    };
    public static PokedexData Ludicolo = new()
    {
        number = 272,
        name = "Ludicolo",
        category = "Carefree",
        height = 150,
        weight = 55000,
        entry = LudicoloDesc,
        forms = SingleSpecies(Species.Ludicolo),
    };
    public static PokedexData Seedot = new()
    {
        number = 273,
        name = "Seedot",
        category = "Acorn",
        height = 50,
        weight = 4000,
        entry = SeedotDesc,
        forms = SingleSpecies(Species.Seedot),
    };
    public static PokedexData Nuzleaf = new()
    {
        number = 274,
        name = "Nuzleaf",
        category = "Wily",
        height = 100,
        weight = 28000,
        entry = NuzleafDesc,
        forms = SingleSpecies(Species.Nuzleaf),
    };
    public static PokedexData Shiftry = new()
    {
        number = 275,
        name = "Shiftry",
        category = "Wicked",
        height = 130,
        weight = 59600,
        entry = ShiftryDesc,
        forms = SingleSpecies(Species.Shiftry),
    };
    public static PokedexData Taillow = new()
    {
        number = 276,
        name = "Taillow",
        category = "TinySwallow",
        height = 30,
        weight = 2300,
        entry = TaillowDesc,
        forms = SingleSpecies(Species.Taillow),
    };
    public static PokedexData Swellow = new()
    {
        number = 277,
        name = "Swellow",
        category = "Swallow",
        height = 70,
        weight = 19800,
        entry = SwellowDesc,
        forms = SingleSpecies(Species.Swellow),
    };
    public static PokedexData Wingull = new()
    {
        number = 278,
        name = "Wingull",
        category = "Seagull",
        height = 60,
        weight = 9500,
        entry = WingullDesc,
        forms = SingleSpecies(Species.Wingull),
    };
    public static PokedexData Pelipper = new()
    {
        number = 279,
        name = "Pelipper",
        category = "WaterBird",
        height = 120,
        weight = 28000,
        entry = PelipperDesc,
        forms = SingleSpecies(Species.Pelipper),
    };
    public static PokedexData Ralts = new()
    {
        number = 280,
        name = "Ralts",
        category = "Feeling",
        height = 40,
        weight = 6600,
        entry = RaltsDesc,
        forms = SingleSpecies(Species.Ralts),
    };
    public static PokedexData Kirlia = new()
    {
        number = 281,
        name = "Kirlia",
        category = "Emotion",
        height = 80,
        weight = 20200,
        entry = KirliaDesc,
        forms = SingleSpecies(Species.Kirlia),
    };
    public static PokedexData Gardevoir = new()
    {
        number = 282,
        name = "Gardevoir",
        category = "Embrace",
        height = 160,
        weight = 48400,
        entry = GardevoirDesc,
        forms = new[]
        {
            Species.Gardevoir,
            Species.GardevoirMega
        }
    };
    public static PokedexData Surskit = new()
    {
        number = 283,
        name = "Surskit",
        category = "PondSkater",
        height = 50,
        weight = 1700,
        entry = SurskitDesc,
        forms = SingleSpecies(Species.Surskit),
    };
    public static PokedexData Masquerain = new()
    {
        number = 284,
        name = "Masquerain",
        category = "Eyeball",
        height = 80,
        weight = 3600,
        entry = MasquerainDesc,
        forms = SingleSpecies(Species.Masquerain),
    };
    public static PokedexData Shroomish = new()
    {
        number = 285,
        name = "Shroomish",
        category = "Mushroom",
        height = 40,
        weight = 4500,
        entry = ShroomishDesc,
        forms = SingleSpecies(Species.Shroomish),
    };
    public static PokedexData Breloom = new()
    {
        number = 286,
        name = "Breloom",
        category = "Mushroom",
        height = 120,
        weight = 39200,
        entry = BreloomDesc,
        forms = SingleSpecies(Species.Breloom),
    };
    public static PokedexData Slakoth = new()
    {
        number = 287,
        name = "Slakoth",
        category = "Slacker",
        height = 80,
        weight = 24000,
        entry = SlakothDesc,
        forms = SingleSpecies(Species.Slakoth),
    };
    public static PokedexData Vigoroth = new()
    {
        number = 288,
        name = "Vigoroth",
        category = "WildMonkey",
        height = 140,
        weight = 46500,
        entry = VigorothDesc,
        forms = SingleSpecies(Species.Vigoroth),
    };
    public static PokedexData Slaking = new()
    {
        number = 289,
        name = "Slaking",
        category = "Lazy",
        height = 200,
        weight = 130500,
        entry = SlakingDesc,
        forms = SingleSpecies(Species.Slaking),
    };
    public static PokedexData Nincada = new()
    {
        number = 290,
        name = "Nincada",
        category = "Trainee",
        height = 50,
        weight = 5500,
        entry = NincadaDesc,
        forms = SingleSpecies(Species.Nincada),
    };
    public static PokedexData Ninjask = new()
    {
        number = 291,
        name = "Ninjask",
        category = "Ninja",
        height = 80,
        weight = 12000,
        entry = NinjaskDesc,
        forms = SingleSpecies(Species.Ninjask),
    };
    public static PokedexData Shedinja = new()
    {
        number = 292,
        name = "Shedinja",
        category = "Shed",
        height = 80,
        weight = 1200,
        entry = ShedinjaDesc,
        forms = SingleSpecies(Species.Shedinja),
    };
    public static PokedexData Whismur = new()
    {
        number = 293,
        name = "Whismur",
        category = "Whisper",
        height = 60,
        weight = 16300,
        entry = WhismurDesc,
        forms = SingleSpecies(Species.Whismur),
    };
    public static PokedexData Loudred = new()
    {
        number = 294,
        name = "Loudred",
        category = "BigVoice",
        height = 100,
        weight = 40500,
        entry = LoudredDesc,
        forms = SingleSpecies(Species.Loudred),
    };
    public static PokedexData Exploud = new()
    {
        number = 295,
        name = "Exploud",
        category = "LoudNoise",
        height = 150,
        weight = 84000,
        entry = ExploudDesc,
        forms = SingleSpecies(Species.Exploud),
    };
    public static PokedexData Makuhita = new()
    {
        number = 296,
        name = "Makuhita",
        category = "Guts",
        height = 100,
        weight = 86400,
        entry = MakuhitaDesc,
        forms = SingleSpecies(Species.Makuhita),
    };
    public static PokedexData Hariyama = new()
    {
        number = 297,
        name = "Hariyama",
        category = "ArmThrust",
        height = 230,
        weight = 253800,
        entry = HariyamaDesc,
        forms = SingleSpecies(Species.Hariyama),
    };
    public static PokedexData Azurill = new()
    {
        number = 298,
        name = "Azurill",
        category = "PolkaDot",
        height = 20,
        weight = 2000,
        entry = AzurillDesc,
        forms = SingleSpecies(Species.Azurill),
    };
    public static PokedexData Nosepass = new()
    {
        number = 299,
        name = "Nosepass",
        category = "Compass",
        height = 100,
        weight = 97000,
        entry = NosepassDesc,
        forms = SingleSpecies(Species.Nosepass),
    };
    public static PokedexData Skitty = new()
    {
        number = 300,
        name = "Skitty",
        category = "Kitten",
        height = 60,
        weight = 11000,
        entry = SkittyDesc,
        forms = SingleSpecies(Species.Skitty),
    };
    public static PokedexData Delcatty = new()
    {
        number = 301,
        name = "Delcatty",
        category = "Prim",
        height = 110,
        weight = 32600,
        entry = DelcattyDesc,
        forms = SingleSpecies(Species.Delcatty),
    };
    public static PokedexData Sableye = new()
    {
        number = 302,
        name = "Sableye",
        category = "Darkness",
        height = 50,
        weight = 11000,
        entry = SableyeDesc,
        forms = new[]
        {
            Species.Sableye,
            Species.SableyeMega
        }
    };
    public static PokedexData Mawile = new()
    {
        number = 303,
        name = "Mawile",
        category = "Deceiver",
        height = 60,
        weight = 11500,
        entry = MawileDesc,
        forms = new[]
        {
        Species.Mawile,
        Species.MawileMega
    }
    };
    public static PokedexData Aron = new()
    {
        number = 304,
        name = "Aron",
        category = "IronArmor",
        height = 40,
        weight = 60000,
        entry = AronDesc,
        forms = SingleSpecies(Species.Aron),
    };
    public static PokedexData Lairon = new()
    {
        number = 305,
        name = "Lairon",
        category = "IronArmor",
        height = 90,
        weight = 120000,
        entry = LaironDesc,
        forms = SingleSpecies(Species.Lairon),
    };
    public static PokedexData Aggron = new()
    {
        number = 306,
        name = "Aggron",
        category = "IronArmor",
        height = 210,
        weight = 360000,
        entry = AggronDesc,
        forms = new[]
        {
            Species.Aggron,
            Species.AggronMega
        }
    };
    public static PokedexData Meditite = new()
    {
        number = 307,
        name = "Meditite",
        category = "Meditate",
        height = 60,
        weight = 11200,
        entry = MedititeDesc,
        forms = SingleSpecies(Species.Meditite),
    };
    public static PokedexData Medicham = new()
    {
        number = 308,
        name = "Medicham",
        category = "Meditate",
        height = 130,
        weight = 31500,
        entry = MedichamDesc,
        forms = new[]
        {
            Species.Medicham,
            Species.MedichamMega
        }
    };
    public static PokedexData Electrike = new()
    {
        number = 309,
        name = "Electrike",
        category = "Lightning",
        height = 60,
        weight = 15200,
        entry = ElectrikeDesc,
        forms = SingleSpecies(Species.Electrike),
    };
    public static PokedexData Manectric = new()
    {
        number = 310,
        name = "Manectric",
        category = "Discharge",
        height = 150,
        weight = 40200,
        entry = ManectricDesc,
        forms = new[]
        {
            Species.Manectric,
            Species.ManectricMega
        }
    };
    public static PokedexData Plusle = new()
    {
        number = 311,
        name = "Plusle",
        category = "Cheering",
        height = 40,
        weight = 4200,
        entry = PlusleDesc,
        forms = SingleSpecies(Species.Plusle),
    };
    public static PokedexData Minun = new()
    {
        number = 312,
        name = "Minun",
        category = "Cheering",
        height = 40,
        weight = 4200,
        entry = MinunDesc,
        forms = SingleSpecies(Species.Minun),
    };
    public static PokedexData Volbeat = new()
    {
        number = 313,
        name = "Volbeat",
        category = "Firefly",
        height = 70,
        weight = 17700,
        entry = VolbeatDesc,
        forms = SingleSpecies(Species.Volbeat),
    };
    public static PokedexData Illumise = new()
    {
        number = 314,
        name = "Illumise",
        category = "Firefly",
        height = 60,
        weight = 17700,
        entry = IllumiseDesc,
        forms = SingleSpecies(Species.Illumise),
    };
    public static PokedexData Roselia = new()
    {
        number = 315,
        name = "Roselia",
        category = "Thorn",
        height = 30,
        weight = 2000,
        entry = RoseliaDesc,
        forms = SingleSpecies(Species.Roselia),
    };
    public static PokedexData Gulpin = new()
    {
        number = 316,
        name = "Gulpin",
        category = "Stomach",
        height = 40,
        weight = 10300,
        entry = GulpinDesc,
        forms = SingleSpecies(Species.Gulpin),
    };
    public static PokedexData Swalot = new()
    {
        number = 317,
        name = "Swalot",
        category = "PoisonBag",
        height = 170,
        weight = 80000,
        entry = SwalotDesc,
        forms = SingleSpecies(Species.Swalot),
    };
    public static PokedexData Carvanha = new()
    {
        number = 318,
        name = "Carvanha",
        category = "Savage",
        height = 80,
        weight = 20800,
        entry = CarvanhaDesc,
        forms = SingleSpecies(Species.Carvanha),
    };
    public static PokedexData Sharpedo = new()
    {
        number = 319,
        name = "Sharpedo",
        category = "Brutal",
        height = 180,
        weight = 88800,
        entry = SharpedoDesc,
        forms = new[]
        {
            Species.Sharpedo,
            Species.SharpedoMega
        }
    };
    public static PokedexData Wailmer = new()
    {
        number = 320,
        name = "Wailmer",
        category = "BallWhale",
        height = 200,
        weight = 130000,
        entry = WailmerDesc,
        forms = SingleSpecies(Species.Wailmer),
    };
    public static PokedexData Wailord = new()
    {
        number = 321,
        name = "Wailord",
        category = "FloatWhale",
        height = 1450,
        weight = 398000,
        entry = WailordDesc,
        forms = SingleSpecies(Species.Wailord),
    };
    public static PokedexData Numel = new()
    {
        number = 322,
        name = "Numel",
        category = "Numb",
        height = 70,
        weight = 24000,
        entry = NumelDesc,
        forms = SingleSpecies(Species.Numel),
    };
    public static PokedexData Camerupt = new()
    {
        number = 323,
        name = "Camerupt",
        category = "Eruption",
        height = 190,
        weight = 220000,
        entry = CameruptDesc,
        forms = new[]
        {
            Species.Camerupt,
            Species.CameruptMega
        }
    };
    public static PokedexData Torkoal = new()
    {
        number = 324,
        name = "Torkoal",
        category = "Coal",
        height = 50,
        weight = 80400,
        entry = TorkoalDesc,
        forms = SingleSpecies(Species.Torkoal),
    };
    public static PokedexData Spoink = new()
    {
        number = 325,
        name = "Spoink",
        category = "Bounce",
        height = 70,
        weight = 30600,
        entry = SpoinkDesc,
        forms = SingleSpecies(Species.Spoink),
    };
    public static PokedexData Grumpig = new()
    {
        number = 326,
        name = "Grumpig",
        category = "Manipulate",
        height = 90,
        weight = 71500,
        entry = GrumpigDesc,
        forms = SingleSpecies(Species.Grumpig),
    };
    public static PokedexData Spinda = new()
    {
        number = 327,
        name = "Spinda",
        category = "SpotPanda",
        height = 110,
        weight = 5000,
        entry = SpindaDesc,
        forms = SingleSpecies(Species.Spinda),
    };
    public static PokedexData Trapinch = new()
    {
        number = 328,
        name = "Trapinch",
        category = "AntPit",
        height = 70,
        weight = 15000,
        entry = TrapinchDesc,
        forms = SingleSpecies(Species.Trapinch),
    };
    public static PokedexData Vibrava = new()
    {
        number = 329,
        name = "Vibrava",
        category = "Vibration",
        height = 110,
        weight = 15300,
        entry = VibravaDesc,
        forms = SingleSpecies(Species.Vibrava),
    };
    public static PokedexData Flygon = new()
    {
        number = 330,
        name = "Flygon",
        category = "Mystic",
        height = 200,
        weight = 82000,
        entry = FlygonDesc,
        forms = SingleSpecies(Species.Flygon),
    };
    public static PokedexData Cacnea = new()
    {
        number = 331,
        name = "Cacnea",
        category = "Cactus",
        height = 40,
        weight = 51300,
        entry = CacneaDesc,
        forms = SingleSpecies(Species.Cacnea),
    };
    public static PokedexData Cacturne = new()
    {
        number = 332,
        name = "Cacturne",
        category = "Scarecrow",
        height = 130,
        weight = 77400,
        entry = CacturneDesc,
        forms = SingleSpecies(Species.Cacturne),
    };
    public static PokedexData Swablu = new()
    {
        number = 333,
        name = "Swablu",
        category = "CottonBird",
        height = 40,
        weight = 1200,
        entry = SwabluDesc,
        forms = SingleSpecies(Species.Swablu),
    };
    public static PokedexData Altaria = new()
    {
        number = 334,
        name = "Altaria",
        category = "Humming",
        height = 110,
        weight = 20600,
        entry = AltariaDesc,
        forms = new[]
        {
            Species.Altaria,
            Species.AltariaMega
        }
    };
    public static PokedexData Zangoose = new()
    {
        number = 335,
        name = "Zangoose",
        category = "CatFerret",
        height = 130,
        weight = 40300,
        entry = ZangooseDesc,
        forms = SingleSpecies(Species.Zangoose),
    };
    public static PokedexData Seviper = new()
    {
        number = 336,
        name = "Seviper",
        category = "FangSnake",
        height = 270,
        weight = 52500,
        entry = SeviperDesc,
        forms = SingleSpecies(Species.Seviper),
    };
    public static PokedexData Lunatone = new()
    {
        number = 337,
        name = "Lunatone",
        category = "Meteorite",
        height = 100,
        weight = 168000,
        entry = LunatoneDesc,
        forms = SingleSpecies(Species.Lunatone),
    };
    public static PokedexData Solrock = new()
    {
        number = 338,
        name = "Solrock",
        category = "Meteorite",
        height = 120,
        weight = 154000,
        entry = SolrockDesc,
        forms = SingleSpecies(Species.Solrock),
    };
    public static PokedexData Barboach = new()
    {
        number = 339,
        name = "Barboach",
        category = "Whiskers",
        height = 40,
        weight = 1900,
        entry = BarboachDesc,
        forms = SingleSpecies(Species.Barboach),
    };
    public static PokedexData Whiscash = new()
    {
        number = 340,
        name = "Whiscash",
        category = "Whiskers",
        height = 90,
        weight = 23600,
        entry = WhiscashDesc,
        forms = SingleSpecies(Species.Whiscash),
    };
    public static PokedexData Corphish = new()
    {
        number = 341,
        name = "Corphish",
        category = "Ruffian",
        height = 60,
        weight = 11500,
        entry = CorphishDesc,
        forms = SingleSpecies(Species.Corphish),
    };
    public static PokedexData Crawdaunt = new()
    {
        number = 342,
        name = "Crawdaunt",
        category = "Rogue",
        height = 110,
        weight = 32800,
        entry = CrawdauntDesc,
        forms = SingleSpecies(Species.Crawdaunt),
    };
    public static PokedexData Baltoy = new()
    {
        number = 343,
        name = "Baltoy",
        category = "ClayDoll",
        height = 50,
        weight = 21500,
        entry = BaltoyDesc,
        forms = SingleSpecies(Species.Baltoy),
    };
    public static PokedexData Claydol = new()
    {
        number = 344,
        name = "Claydol",
        category = "ClayDoll",
        height = 150,
        weight = 108000,
        entry = ClaydolDesc,
        forms = SingleSpecies(Species.Claydol),
    };
    public static PokedexData Lileep = new()
    {
        number = 345,
        name = "Lileep",
        category = "SeaLily",
        height = 100,
        weight = 23800,
        entry = LileepDesc,
        forms = SingleSpecies(Species.Lileep),
    };
    public static PokedexData Cradily = new()
    {
        number = 346,
        name = "Cradily",
        category = "Barnacle",
        height = 150,
        weight = 60400,
        entry = CradilyDesc,
        forms = SingleSpecies(Species.Cradily),
    };
    public static PokedexData Anorith = new()
    {
        number = 347,
        name = "Anorith",
        category = "OldShrimp",
        height = 70,
        weight = 12500,
        entry = AnorithDesc,
        forms = SingleSpecies(Species.Anorith),
    };
    public static PokedexData Armaldo = new()
    {
        number = 348,
        name = "Armaldo",
        category = "Plate",
        height = 150,
        weight = 68200,
        entry = ArmaldoDesc,
        forms = SingleSpecies(Species.Armaldo),
    };
    public static PokedexData Feebas = new()
    {
        number = 349,
        name = "Feebas",
        category = "Fish",
        height = 60,
        weight = 7400,
        entry = FeebasDesc,
        forms = SingleSpecies(Species.Feebas),
    };
    public static PokedexData Milotic = new()
    {
        number = 350,
        name = "Milotic",
        category = "Tender",
        height = 620,
        weight = 162000,
        entry = MiloticDesc,
        forms = SingleSpecies(Species.Milotic),
    };
    public static PokedexData Castform = new()
    {
        number = 351,
        name = "Castform",
        category = "Weather",
        height = 30,
        weight = 800,
        entry = CastformDesc,
        forms = new[]
        {
            Species.Castform,
            Species.CastformSunny,
            Species.CastformRainy,
            Species.CastformSnowy
        }
    };
    public static PokedexData Kecleon = new()
    {
        number = 352,
        name = "Kecleon",
        category = "ColorSwap",
        height = 100,
        weight = 22000,
        entry = KecleonDesc,
        forms = SingleSpecies(Species.Kecleon),
    };
    public static PokedexData Shuppet = new()
    {
        number = 353,
        name = "Shuppet",
        category = "Puppet",
        height = 60,
        weight = 2300,
        entry = ShuppetDesc,
        forms = SingleSpecies(Species.Shuppet),
    };
    public static PokedexData Banette = new()
    {
        number = 354,
        name = "Banette",
        category = "Marionette",
        height = 110,
        weight = 12500,
        entry = BanetteDesc,
        forms = new[]
        {
            Species.Banette,
            Species.BanetteMega
        }
    };
    public static PokedexData Duskull = new()
    {
        number = 355,
        name = "Duskull",
        category = "Requiem",
        height = 80,
        weight = 15000,
        entry = DuskullDesc,
        forms = SingleSpecies(Species.Duskull),
    };
    public static PokedexData Dusclops = new()
    {
        number = 356,
        name = "Dusclops",
        category = "Beckon",
        height = 160,
        weight = 30600,
        entry = DusclopsDesc,
        forms = SingleSpecies(Species.Dusclops),
    };
    public static PokedexData Tropius = new()
    {
        number = 357,
        name = "Tropius",
        category = "Fruit",
        height = 200,
        weight = 100000,
        entry = TropiusDesc,
        forms = SingleSpecies(Species.Tropius),
    };
    public static PokedexData Chimecho = new()
    {
        number = 358,
        name = "Chimecho",
        category = "WindChime",
        height = 60,
        weight = 1000,
        entry = ChimechoDesc,
        forms = SingleSpecies(Species.Chimecho),
    };
    public static PokedexData Absol = new()
    {
        number = 359,
        name = "Absol",
        category = "Disaster",
        height = 120,
        weight = 47000,
        entry = AbsolDesc,
        forms = new[]
        {
            Species.Absol,
            Species.AbsolMega
        }
    };
    public static PokedexData Wynaut = new()
    {
        number = 360,
        name = "Wynaut",
        category = "Bright",
        height = 60,
        weight = 14000,
        entry = WynautDesc,
        forms = SingleSpecies(Species.Wynaut),
    };
    public static PokedexData Snorunt = new()
    {
        number = 361,
        name = "Snorunt",
        category = "SnowHat",
        height = 70,
        weight = 16800,
        entry = SnoruntDesc,
        forms = SingleSpecies(Species.Snorunt),
    };
    public static PokedexData Glalie = new()
    {
        number = 362,
        name = "Glalie",
        category = "Face",
        height = 150,
        weight = 256500,
        entry = GlalieDesc,
        forms = new[]
        {
            Species.Glalie,
            Species.GlalieMega
        }
    };
    public static PokedexData Spheal = new()
    {
        number = 363,
        name = "Spheal",
        category = "Clap",
        height = 80,
        weight = 39500,
        entry = SphealDesc,
        forms = SingleSpecies(Species.Spheal),
    };
    public static PokedexData Sealeo = new()
    {
        number = 364,
        name = "Sealeo",
        category = "BallRoll",
        height = 110,
        weight = 87600,
        entry = SealeoDesc,
        forms = SingleSpecies(Species.Sealeo),
    };
    public static PokedexData Walrein = new()
    {
        number = 365,
        name = "Walrein",
        category = "IceBreak",
        height = 140,
        weight = 150600,
        entry = WalreinDesc,
        forms = SingleSpecies(Species.Walrein),
    };
    public static PokedexData Clamperl = new()
    {
        number = 366,
        name = "Clamperl",
        category = "Bivalve",
        height = 40,
        weight = 52500,
        entry = ClamperlDesc,
        forms = SingleSpecies(Species.Clamperl),
    };
    public static PokedexData Huntail = new()
    {
        number = 367,
        name = "Huntail",
        category = "DeepSea",
        height = 170,
        weight = 27000,
        entry = HuntailDesc,
        forms = SingleSpecies(Species.Huntail),
    };
    public static PokedexData Gorebyss = new()
    {
        number = 368,
        name = "Gorebyss",
        category = "SouthSea",
        height = 180,
        weight = 22600,
        entry = GorebyssDesc,
        forms = SingleSpecies(Species.Gorebyss),
    };
    public static PokedexData Relicanth = new()
    {
        number = 369,
        name = "Relicanth",
        category = "Longevity",
        height = 100,
        weight = 23400,
        entry = RelicanthDesc,
        forms = SingleSpecies(Species.Relicanth),
    };
    public static PokedexData Luvdisc = new()
    {
        number = 370,
        name = "Luvdisc",
        category = "Rendezvous",
        height = 60,
        weight = 8700,
        entry = LuvdiscDesc,
        forms = SingleSpecies(Species.Luvdisc),
    };
    public static PokedexData Bagon = new()
    {
        number = 371,
        name = "Bagon",
        category = "RockHead",
        height = 60,
        weight = 42100,
        entry = BagonDesc,
        forms = SingleSpecies(Species.Bagon),
    };
    public static PokedexData Shelgon = new()
    {
        number = 372,
        name = "Shelgon",
        category = "Endurance",
        height = 110,
        weight = 110500,
        entry = ShelgonDesc,
        forms = SingleSpecies(Species.Shelgon),
    };
    public static PokedexData Salamence = new()
    {
        number = 373,
        name = "Salamence",
        category = "Dragon",
        height = 150,
        weight = 102600,
        entry = SalamenceDesc,
        forms = new[]
        {
            Species.Salamence,
            Species.SalamenceMega
        }
    };
    public static PokedexData Beldum = new()
    {
        number = 374,
        name = "Beldum",
        category = "IronBall",
        height = 60,
        weight = 95200,
        entry = BeldumDesc,
        forms = SingleSpecies(Species.Beldum),
    };
    public static PokedexData Metang = new()
    {
        number = 375,
        name = "Metang",
        category = "IronClaw",
        height = 120,
        weight = 202500,
        entry = MetangDesc,
        forms = SingleSpecies(Species.Metang),
    };
    public static PokedexData Metagross = new()
    {
        number = 376,
        name = "Metagross",
        category = "IronLeg",
        height = 160,
        weight = 550000,
        entry = MetagrossDesc,
        forms = new[]
        {
            Species.Metagross,
            Species.MetagrossMega
        }
    };
    public static PokedexData Regirock = new()
    {
        number = 377,
        name = "Regirock",
        category = "RockPeak",
        height = 170,
        weight = 230000,
        entry = RegirockDesc,
        forms = SingleSpecies(Species.Regirock),
    };
    public static PokedexData Regice = new()
    {
        number = 378,
        name = "Regice",
        category = "Iceberg",
        height = 180,
        weight = 175000,
        entry = RegiceDesc,
        forms = SingleSpecies(Species.Regice),
    };
    public static PokedexData Registeel = new()
    {
        number = 379,
        name = "Registeel",
        category = "Iron",
        height = 190,
        weight = 205000,
        entry = RegisteelDesc,
        forms = SingleSpecies(Species.Registeel),
    };
    public static PokedexData Latias = new()
    {
        number = 380,
        name = "Latias",
        category = "Eon",
        height = 140,
        weight = 40000,
        entry = LatiasDesc,
        forms = new[]
        {
            Species.Latias,
            Species.LatiasMega
        }
    };
    public static PokedexData Latios = new()
    {
        number = 381,
        name = "Latios",
        category = "Eon",
        height = 200,
        weight = 60000,
        entry = LatiosDesc,
        forms = new[]
        {
            Species.Latios,
            Species.LatiosMega
        }
    };
    public static PokedexData Kyogre = new()
    {
        number = 382,
        name = "Kyogre",
        category = "SeaBasin",
        height = 450,
        weight = 352000,
        entry = KyogreDesc,
        forms = SingleSpecies(Species.Kyogre),
    };
    public static PokedexData Groudon = new()
    {
        number = 383,
        name = "Groudon",
        category = "Continent",
        height = 350,
        weight = 950000,
        entry = GroudonDesc,
        forms = SingleSpecies(Species.Groudon),
    };
    public static PokedexData Rayquaza = new()
    {
        number = 384,
        name = "Rayquaza",
        category = "SkyHigh",
        height = 700,
        weight = 206500,
        entry = RayquazaDesc,
        forms = new[]
        {
            Species.Rayquaza,
            Species.RayquazaMega
        }
    };
    public static PokedexData Jirachi = new()
    {
        number = 385,
        name = "Jirachi",
        category = "Wish",
        height = 30,
        weight = 1100,
        entry = JirachiDesc,
        forms = SingleSpecies(Species.Jirachi),
    };
    public static PokedexData Deoxys = new()
    {
        number = 386,
        name = "Deoxys",
        category = "DNA",
        height = 170,
        weight = 60800,
        entry = DeoxysDesc,
        forms = new[]
        {
            Species.Deoxys,
            Species.DeoxysAttack,
            Species.DeoxysDefense,
            Species.DeoxysSpeed
        }
    };

    //Gen 4
    public static PokedexData Turtwig = new()
    {
        number = 387,
        name = "Turtwig",
        category = "TinyLeaf",
        height = 40,
        weight = 10200,
        entry = TurtwigDesc,
        forms = SingleSpecies(Species.Turtwig),
    };
    public static PokedexData Grotle = new()
    {
        number = 388,
        name = "Grotle",
        category = "Grove",
        height = 110,
        weight = 97000,
        entry = GrotleDesc,
        forms = SingleSpecies(Species.Grotle),
    };
    public static PokedexData Torterra = new()
    {
        number = 389,
        name = "Torterra",
        category = "Continent",
        height = 220,
        weight = 310000,
        entry = TorterraDesc,
        forms = SingleSpecies(Species.Torterra),
    };
    public static PokedexData Chimchar = new()
    {
        number = 390,
        name = "Chimchar",
        category = "Chimp",
        height = 50,
        weight = 6200,
        entry = ChimcharDesc,
        forms = SingleSpecies(Species.Chimchar),
    };
    public static PokedexData Monferno = new()
    {
        number = 391,
        name = "Monferno",
        category = "Playful",
        height = 90,
        weight = 22000,
        entry = MonfernoDesc,
        forms = SingleSpecies(Species.Monferno),
    };
    public static PokedexData Infernape = new()
    {
        number = 392,
        name = "Infernape",
        category = "Flame",
        height = 120,
        weight = 55000,
        entry = InfernapeDesc,
        forms = SingleSpecies(Species.Infernape),
    };
    public static PokedexData Piplup = new()
    {
        number = 393,
        name = "Piplup",
        category = "Penguin",
        height = 40,
        weight = 5200,
        entry = PiplupDesc,
        forms = SingleSpecies(Species.Piplup),
    };
    public static PokedexData Prinplup = new()
    {
        number = 394,
        name = "Prinplup",
        category = "Penguin",
        height = 80,
        weight = 23000,
        entry = PrinplupDesc,
        forms = SingleSpecies(Species.Prinplup),
    };
    public static PokedexData Empoleon = new()
    {
        number = 395,
        name = "Empoleon",
        category = "Emperor",
        height = 170,
        weight = 84500,
        entry = EmpoleonDesc,
        forms = SingleSpecies(Species.Empoleon),
    };
    public static PokedexData Starly = new()
    {
        number = 396,
        name = "Starly",
        category = "Starling",
        height = 30,
        weight = 2000,
        entry = StarlyDesc,
        forms = SingleSpecies(Species.Starly),
    };
    public static PokedexData Staravia = new()
    {
        number = 397,
        name = "Staravia",
        category = "Starling",
        height = 60,
        weight = 15500,
        entry = StaraviaDesc,
        forms = SingleSpecies(Species.Staravia),
    };
    public static PokedexData Staraptor = new()
    {
        number = 398,
        name = "Staraptor",
        category = "Predator",
        height = 120,
        weight = 24900,
        entry = StaraptorDesc,
        forms = SingleSpecies(Species.Staraptor),
    };
    public static PokedexData Bidoof = new()
    {
        number = 399,
        name = "Bidoof",
        category = "PlumpMouse",
        height = 50,
        weight = 20000,
        entry = BidoofDesc,
        forms = SingleSpecies(Species.Bidoof),
    };
    public static PokedexData Bibarel = new()
    {
        number = 400,
        name = "Bibarel",
        category = "Beaver",
        height = 100,
        weight = 31500,
        entry = BibarelDesc,
        forms = SingleSpecies(Species.Bibarel),
    };
    public static PokedexData Kricketot = new()
    {
        number = 401,
        name = "Kricketot",
        category = "Cricket",
        height = 30,
        weight = 2200,
        entry = KricketotDesc,
        forms = SingleSpecies(Species.Kricketot),
    };
    public static PokedexData Kricketune = new()
    {
        number = 402,
        name = "Kricketune",
        category = "Cricket",
        height = 100,
        weight = 25500,
        entry = KricketuneDesc,
        forms = SingleSpecies(Species.Kricketune),
    };
    public static PokedexData Shinx = new()
    {
        number = 403,
        name = "Shinx",
        category = "Flash",
        height = 50,
        weight = 9500,
        entry = ShinxDesc,
        forms = SingleSpecies(Species.Shinx),
    };
    public static PokedexData Luxio = new()
    {
        number = 404,
        name = "Luxio",
        category = "Spark",
        height = 90,
        weight = 30500,
        entry = LuxioDesc,
        forms = SingleSpecies(Species.Luxio),
    };
    public static PokedexData Luxray = new()
    {
        number = 405,
        name = "Luxray",
        category = "GleamEyes",
        height = 140,
        weight = 42000,
        entry = LuxrayDesc,
        forms = SingleSpecies(Species.Luxray),
    };
    public static PokedexData Budew = new()
    {
        number = 406,
        name = "Budew",
        category = "Bud",
        height = 20,
        weight = 1200,
        entry = BudewDesc,
        forms = SingleSpecies(Species.Budew),
    };
    public static PokedexData Roserade = new()
    {
        number = 407,
        name = "Roserade",
        category = "Bouquet",
        height = 90,
        weight = 14500,
        entry = RoseradeDesc,
        forms = SingleSpecies(Species.Roserade),
    };
    public static PokedexData Cranidos = new()
    {
        number = 408,
        name = "Cranidos",
        category = "HeadButt",
        height = 90,
        weight = 31500,
        entry = CranidosDesc,
        forms = SingleSpecies(Species.Cranidos),
    };
    public static PokedexData Rampardos = new()
    {
        number = 409,
        name = "Rampardos",
        category = "HeadButt",
        height = 160,
        weight = 102500,
        entry = RampardosDesc,
        forms = SingleSpecies(Species.Rampardos),
    };
    public static PokedexData Shieldon = new()
    {
        number = 410,
        name = "Shieldon",
        category = "Shield",
        height = 50,
        weight = 57000,
        entry = ShieldonDesc,
        forms = SingleSpecies(Species.Shieldon),
    };
    public static PokedexData Bastiodon = new()
    {
        number = 411,
        name = "Bastiodon",
        category = "Shield",
        height = 130,
        weight = 149500,
        entry = BastiodonDesc,
        forms = SingleSpecies(Species.Bastiodon),
    };
    public static PokedexData Burmy = new()
    {
        number = 412,
        name = "Burmy",
        category = "Bagworm",
        height = 20,
        weight = 3400,
        entry = BurmyDesc,
        forms = new[]
        {
            Species.Burmy,
            Species.BurmySand,
            Species.BurmyTrash
        }
    };
    public static PokedexData Wormadam = new()
    {
        number = 413,
        name = "Wormadam",
        category = "Bagworm",
        height = 50,
        weight = 6500,
        entry = WormadamDesc,
        forms = new[]
        {
            Species.Wormadam,
            Species.WormadamSand,
            Species.WormadamTrash
        }
    };
    public static PokedexData Mothim = new()
    {
        number = 414,
        name = "Mothim",
        category = "Moth",
        height = 90,
        weight = 23300,
        entry = MothimDesc,
        forms = SingleSpecies(Species.Mothim),
    };
    public static PokedexData Combee = new()
    {
        number = 415,
        name = "Combee",
        category = "TinyBee",
        height = 30,
        weight = 5500,
        entry = CombeeDesc,
        forms = SingleSpecies(Species.Combee),
    };
    public static PokedexData Vespiquen = new()
    {
        number = 416,
        name = "Vespiquen",
        category = "Beehive",
        height = 120,
        weight = 38500,
        entry = VespiquenDesc,
        forms = SingleSpecies(Species.Vespiquen),
    };
    public static PokedexData Pachirisu = new()
    {
        number = 417,
        name = "Pachirisu",
        category = "EleSquirrel",
        height = 40,
        weight = 3900,
        entry = PachirisuDesc,
        forms = SingleSpecies(Species.Pachirisu),
    };
    public static PokedexData Buizel = new()
    {
        number = 418,
        name = "Buizel",
        category = "SeaWeasel",
        height = 70,
        weight = 29500,
        entry = BuizelDesc,
        forms = SingleSpecies(Species.Buizel),
    };
    public static PokedexData Floatzel = new()
    {
        number = 419,
        name = "Floatzel",
        category = "SeaWeasel",
        height = 110,
        weight = 33500,
        entry = FloatzelDesc,
        forms = SingleSpecies(Species.Floatzel),
    };
    public static PokedexData Cherubi = new()
    {
        number = 420,
        name = "Cherubi",
        category = "Cherry",
        height = 40,
        weight = 3300,
        entry = CherubiDesc,
        forms = SingleSpecies(Species.Cherubi),
    };
    public static PokedexData Cherrim = new()
    {
        number = 421,
        name = "Cherrim",
        category = "Blossom",
        height = 50,
        weight = 9300,
        entry = CherrimDesc,
        forms = new[]
        {
            Species.Cherrim,
            Species.CherrimSunshine
        }
    };
    public static PokedexData Shellos = new()
    {
        number = 422,
        name = "Shellos",
        category = "SeaSlug",
        height = 30,
        weight = 6300,
        entry = ShellosDesc,
        forms = new[]
        {
            Species.Shellos,
            Species.ShellosEast
        }
    };
    public static PokedexData Gastrodon = new()
    {
        number = 423,
        name = "Gastrodon",
        category = "SeaSlug",
        height = 90,
        weight = 29900,
        entry = GastrodonDesc,
        forms = new[]
        {
            Species.Gastrodon,
            Species.GastrodonEast
        }
    };
    public static PokedexData Ambipom = new()
    {
        number = 424,
        name = "Ambipom",
        category = "LongTail",
        height = 120,
        weight = 20300,
        entry = AmbipomDesc,
        forms = SingleSpecies(Species.Ambipom),
    };
    public static PokedexData Drifloon = new()
    {
        number = 425,
        name = "Drifloon",
        category = "Balloon",
        height = 40,
        weight = 1200,
        entry = DrifloonDesc,
        forms = SingleSpecies(Species.Drifloon),
    };
    public static PokedexData Drifblim = new()
    {
        number = 426,
        name = "Drifblim",
        category = "Blimp",
        height = 120,
        weight = 15000,
        entry = DrifblimDesc,
        forms = SingleSpecies(Species.Drifblim),
    };
    public static PokedexData Buneary = new()
    {
        number = 427,
        name = "Buneary",
        category = "Rabbit",
        height = 40,
        weight = 5500,
        entry = BunearyDesc,
        forms = SingleSpecies(Species.Buneary),
    };
    public static PokedexData Lopunny = new()
    {
        number = 428,
        name = "Lopunny",
        category = "Rabbit",
        height = 120,
        weight = 33300,
        entry = LopunnyDesc,
        forms = new[]
        {
            Species.Lopunny,
            Species.LopunnyMega
        }
    };
    public static PokedexData Mismagius = new()
    {
        number = 429,
        name = "Mismagius",
        category = "Magical",
        height = 90,
        weight = 4400,
        entry = MismagiusDesc,
        forms = SingleSpecies(Species.Mismagius),
    };
    public static PokedexData Honchkrow = new()
    {
        number = 430,
        name = "Honchkrow",
        category = "BigBoss",
        height = 90,
        weight = 27300,
        entry = HonchkrowDesc,
        forms = SingleSpecies(Species.Honchkrow),
    };
    public static PokedexData Glameow = new()
    {
        number = 431,
        name = "Glameow",
        category = "Catty",
        height = 50,
        weight = 3900,
        entry = GlameowDesc,
        forms = SingleSpecies(Species.Glameow),
    };
    public static PokedexData Purugly = new()
    {
        number = 432,
        name = "Purugly",
        category = "TigerCat",
        height = 100,
        weight = 43800,
        entry = PuruglyDesc,
        forms = SingleSpecies(Species.Purugly),
    };
    public static PokedexData Chingling = new()
    {
        number = 433,
        name = "Chingling",
        category = "Bell",
        height = 20,
        weight = 600,
        entry = ChinglingDesc,
        forms = SingleSpecies(Species.Chingling),
    };
    public static PokedexData Stunky = new()
    {
        number = 434,
        name = "Stunky",
        category = "Skunk",
        height = 40,
        weight = 19200,
        entry = StunkyDesc,
        forms = SingleSpecies(Species.Stunky),
    };
    public static PokedexData Skuntank = new()
    {
        number = 435,
        name = "Skuntank",
        category = "Skunk",
        height = 100,
        weight = 38000,
        entry = SkuntankDesc,
        forms = SingleSpecies(Species.Skuntank),
    };
    public static PokedexData Bronzor = new()
    {
        number = 436,
        name = "Bronzor",
        category = "Bronze",
        height = 50,
        weight = 60500,
        entry = BronzorDesc,
        forms = SingleSpecies(Species.Bronzor),
    };
    public static PokedexData Bronzong = new()
    {
        number = 437,
        name = "Bronzong",
        category = "BronzeBell",
        height = 130,
        weight = 187000,
        entry = BronzongDesc,
        forms = SingleSpecies(Species.Bronzong),
    };
    public static PokedexData Bonsly = new()
    {
        number = 438,
        name = "Bonsly",
        category = "Bonsai",
        height = 50,
        weight = 15000,
        entry = BonslyDesc,
        forms = SingleSpecies(Species.Bonsly),
    };
    public static PokedexData MimeJr = new ()
	{
		number = 439,
		name = "Mime Jr",
		category = "Mime",
		height = 60,
		weight = 13000,
		entry = MimeJrDesc,
        forms = SingleSpecies(Species.MimeJr),

    };
    public static PokedexData Happiny = new()
    {
        number = 440,
        name = "Happiny",
        category = "Playhouse",
        height = 60,
        weight = 24400,
        entry = HappinyDesc,
        forms = SingleSpecies(Species.Happiny),
    };
    public static PokedexData Chatot = new()
    {
        number = 441,
        name = "Chatot",
        category = "MusicNote",
        height = 50,
        weight = 1900,
        entry = ChatotDesc,
        forms = SingleSpecies(Species.Chatot),
    };
    public static PokedexData Spiritomb = new()
    {
        number = 442,
        name = "Spiritomb",
        category = "Forbidden",
        height = 100,
        weight = 108000,
        entry = SpiritombDesc,
        forms = SingleSpecies(Species.Spiritomb),
    };
    public static PokedexData Gible = new()
    {
        number = 443,
        name = "Gible",
        category = "LandShark",
        height = 70,
        weight = 20500,
        entry = GibleDesc,
        forms = SingleSpecies(Species.Gible),
    };
    public static PokedexData Gabite = new()
    {
        number = 444,
        name = "Gabite",
        category = "Cave",
        height = 140,
        weight = 56000,
        entry = GabiteDesc,
        forms = SingleSpecies(Species.Gabite),
    };
    public static PokedexData Garchomp = new()
    {
        number = 445,
        name = "Garchomp",
        category = "Mach",
        height = 190,
        weight = 95000,
        entry = GarchompDesc,
        forms = new[]
        {
            Species.Garchomp,
            Species.GarchompMega
        }
    };
    public static PokedexData Munchlax = new()
    {
        number = 446,
        name = "Munchlax",
        category = "BigEater",
        height = 60,
        weight = 105000,
        entry = MunchlaxDesc,
        forms = SingleSpecies(Species.Munchlax),
    };
    public static PokedexData Riolu = new()
    {
        number = 447,
        name = "Riolu",
        category = "Emanation",
        height = 70,
        weight = 20200,
        entry = RioluDesc,
        forms = SingleSpecies(Species.Riolu),
    };
    public static PokedexData Lucario = new()
    {
        number = 448,
        name = "Lucario",
        category = "Aura",
        height = 120,
        weight = 54000,
        entry = LucarioDesc,
        forms = new[]
        {
            Species.Lucario,
            Species.LucarioMega
        }
    };
    public static PokedexData Hippopotas = new()
    {
        number = 449,
        name = "Hippopotas",
        category = "Hippo",
        height = 80,
        weight = 49500,
        entry = HippopotasDesc,
        forms = SingleSpecies(Species.Hippopotas),
    };
    public static PokedexData Hippowdon = new()
    {
        number = 450,
        name = "Hippowdon",
        category = "Heavyweight",
        height = 200,
        weight = 300000,
        entry = HippowdonDesc,
        forms = SingleSpecies(Species.Hippowdon),
    };
    public static PokedexData Skorupi = new()
    {
        number = 451,
        name = "Skorupi",
        category = "Scorpion",
        height = 80,
        weight = 12000,
        entry = SkorupiDesc,
        forms = SingleSpecies(Species.Skorupi),
    };
    public static PokedexData Drapion = new()
    {
        number = 452,
        name = "Drapion",
        category = "OgreScorp",
        height = 130,
        weight = 61500,
        entry = DrapionDesc,
        forms = SingleSpecies(Species.Drapion),
    };
    public static PokedexData Croagunk = new()
    {
        number = 453,
        name = "Croagunk",
        category = "ToxicMouth",
        height = 70,
        weight = 23000,
        entry = CroagunkDesc,
        forms = SingleSpecies(Species.Croagunk),
    };
    public static PokedexData Toxicroak = new()
    {
        number = 454,
        name = "Toxicroak",
        category = "ToxicMouth",
        height = 130,
        weight = 44400,
        entry = ToxicroakDesc,
        forms = SingleSpecies(Species.Toxicroak),
    };
    public static PokedexData Carnivine = new()
    {
        number = 455,
        name = "Carnivine",
        category = "BugCatcher",
        height = 140,
        weight = 27000,
        entry = CarnivineDesc,
        forms = SingleSpecies(Species.Carnivine),
    };
    public static PokedexData Finneon = new()
    {
        number = 456,
        name = "Finneon",
        category = "WingFish",
        height = 40,
        weight = 7000,
        entry = FinneonDesc,
        forms = SingleSpecies(Species.Finneon),
    };
    public static PokedexData Lumineon = new()
    {
        number = 457,
        name = "Lumineon",
        category = "Neon",
        height = 120,
        weight = 24000,
        entry = LumineonDesc,
        forms = SingleSpecies(Species.Lumineon),
    };
    public static PokedexData Mantyke = new()
    {
        number = 458,
        name = "Mantyke",
        category = "Kite",
        height = 100,
        weight = 65000,
        entry = MantykeDesc,
        forms = SingleSpecies(Species.Mantyke),
    };
    public static PokedexData Snover = new()
    {
        number = 459,
        name = "Snover",
        category = "FrostTree",
        height = 100,
        weight = 50500,
        entry = SnoverDesc,
        forms = SingleSpecies(Species.Snover),
    };
    public static PokedexData Abomasnow = new()
    {
        number = 460,
        name = "Abomasnow",
        category = "FrostTree",
        height = 220,
        weight = 135500,
        entry = AbomasnowDesc,
        forms = new[]
        {
            Species.Abomasnow,
            Species.AbomasnowMega
        }
    };
    public static PokedexData Weavile = new()
    {
        number = 461,
        name = "Weavile",
        category = "SharpClaw",
        height = 110,
        weight = 34000,
        entry = WeavileDesc,
        forms = SingleSpecies(Species.Weavile),
    };
    public static PokedexData Magnezone = new()
    {
        number = 462,
        name = "Magnezone",
        category = "MagnetArea",
        height = 120,
        weight = 180000,
        entry = MagnezoneDesc,
        forms = SingleSpecies(Species.Magnezone),
    };
    public static PokedexData Lickilicky = new()
    {
        number = 463,
        name = "Lickilicky",
        category = "Licking",
        height = 170,
        weight = 140000,
        entry = LickilickyDesc,
        forms = SingleSpecies(Species.Lickilicky),
    };
    public static PokedexData Rhyperior = new()
    {
        number = 464,
        name = "Rhyperior",
        category = "Drill",
        height = 240,
        weight = 282800,
        entry = RhyperiorDesc,
        forms = SingleSpecies(Species.Rhyperior),
    };
    public static PokedexData Tangrowth = new()
    {
        number = 465,
        name = "Tangrowth",
        category = "Vine",
        height = 200,
        weight = 128600,
        entry = TangrowthDesc,
        forms = SingleSpecies(Species.Tangrowth),
    };
    public static PokedexData Electivire = new()
    {
        number = 466,
        name = "Electivire",
        category = "Thunderbolt",
        height = 180,
        weight = 138600,
        entry = ElectivireDesc,
        forms = SingleSpecies(Species.Electivire),
    };
    public static PokedexData Magmortar = new()
    {
        number = 467,
        name = "Magmortar",
        category = "Blast",
        height = 160,
        weight = 68000,
        entry = MagmortarDesc,
        forms = SingleSpecies(Species.Magmortar),
    };
    public static PokedexData Togekiss = new()
    {
        number = 468,
        name = "Togekiss",
        category = "Jubilee",
        height = 150,
        weight = 38000,
        entry = TogekissDesc,
        forms = SingleSpecies(Species.Togekiss),
    };
    public static PokedexData Yanmega = new()
    {
        number = 469,
        name = "Yanmega",
        category = "OgreDarner",
        height = 190,
        weight = 51500,
        entry = YanmegaDesc,
        forms = SingleSpecies(Species.Yanmega),
    };
    public static PokedexData Leafeon = new()
    {
        number = 470,
        name = "Leafeon",
        category = "Verdant",
        height = 100,
        weight = 25500,
        entry = LeafeonDesc,
        forms = SingleSpecies(Species.Leafeon),
    };
    public static PokedexData Glaceon = new()
    {
        number = 471,
        name = "Glaceon",
        category = "FreshSnow",
        height = 80,
        weight = 25900,
        entry = GlaceonDesc,
        forms = SingleSpecies(Species.Glaceon),
    };
    public static PokedexData Gliscor = new()
    {
        number = 472,
        name = "Gliscor",
        category = "FangScorp",
        height = 200,
        weight = 42500,
        entry = GliscorDesc,
        forms = SingleSpecies(Species.Gliscor),
    };
    public static PokedexData Mamoswine = new()
    {
        number = 473,
        name = "Mamoswine",
        category = "TwinTusk",
        height = 250,
        weight = 291000,
        entry = MamoswineDesc,
        forms = SingleSpecies(Species.Mamoswine),
    };
    public static PokedexData PorygonZ = new()
    {
        number = 474,
        name = "Porygon Z",
        category = "Virtual",
        height = 90,
        weight = 34000,
        entry = PorygonZDesc,
        forms = SingleSpecies(Species.PorygonZ),
    };
    public static PokedexData Gallade = new()
    {
        number = 475,
        name = "Gallade",
        category = "Blade",
        height = 160,
        weight = 52000,
        entry = GalladeDesc,
        forms = new[]
        {
            Species.Gallade,
            Species.GalladeMega
        }
    };
    public static PokedexData Probopass = new()
    {
        number = 476,
        name = "Probopass",
        category = "Compass",
        height = 140,
        weight = 340000,
        entry = ProbopassDesc,
        forms = SingleSpecies(Species.Probopass),
    };
    public static PokedexData Dusknoir = new()
    {
        number = 477,
        name = "Dusknoir",
        category = "Gripper",
        height = 220,
        weight = 106600,
        entry = DusknoirDesc,
        forms = SingleSpecies(Species.Dusknoir),
    };
    public static PokedexData Froslass = new()
    {
        number = 478,
        name = "Froslass",
        category = "SnowLand",
        height = 130,
        weight = 26600,
        entry = FroslassDesc,
        forms = SingleSpecies(Species.Froslass),
    };
    public static PokedexData Rotom = new()
    {
        number = 479,
        name = "Rotom",
        category = "Plasma",
        height = 30,
        weight = 300,
        entry = RotomDesc,
        forms = new[]
        {
            Species.Rotom,
            Species.RotomHeat,
            Species.RotomWash,
            Species.RotomFrost,
            Species.RotomFan,
            Species.RotomMow
        }
    };
    public static PokedexData Uxie = new()
    {
        number = 480,
        name = "Uxie",
        category = "Knowledge",
        height = 30,
        weight = 300,
        entry = UxieDesc,
        forms = SingleSpecies(Species.Uxie),
    };
    public static PokedexData Mesprit = new()
    {
        number = 481,
        name = "Mesprit",
        category = "Emotion",
        height = 30,
        weight = 300,
        entry = MespritDesc,
        forms = SingleSpecies(Species.Mesprit),
    };
    public static PokedexData Azelf = new()
    {
        number = 482,
        name = "Azelf",
        category = "Willpower",
        height = 30,
        weight = 300,
        entry = AzelfDesc,
        forms = SingleSpecies(Species.Azelf),
    };
    public static PokedexData Dialga = new()
    {
        number = 483,
        name = "Dialga",
        category = "Temporal",
        height = 540,
        weight = 683000,
        entry = DialgaDesc,
        forms = new[]
        {
            Species.Dialga,
            Species.DialgaOrigin
        }
    };
    public static PokedexData Palkia = new()
    {
        number = 484,
        name = "Palkia",
        category = "Spatial",
        height = 420,
        weight = 336000,
        entry = PalkiaDesc,
        forms = new[]
        {
            Species.Palkia,
            Species.PalkiaOrigin
        }
    };
    public static PokedexData Heatran = new()
    {
        number = 485,
        name = "Heatran",
        category = "LavaDome",
        height = 170,
        weight = 430000,
        entry = HeatranDesc,
        forms = SingleSpecies(Species.Heatran),
    };
    public static PokedexData Regigigas = new()
    {
        number = 486,
        name = "Regigigas",
        category = "Colossal",
        height = 370,
        weight = 420000,
        entry = RegigigasDesc,
        forms = SingleSpecies(Species.Regigigas),
    };
    public static PokedexData Giratina = new()
    {
        number = 487,
        name = "Giratina",
        category = "Renegade",
        height = 450,
        weight = 750000,
        entry = GiratinaDesc,
        forms = new[]
        {
            Species.Giratina,
            Species.GiratinaOrigin
        }
    };
    public static PokedexData Cresselia = new()
    {
        number = 488,
        name = "Cresselia",
        category = "Lunar",
        height = 150,
        weight = 85600,
        entry = CresseliaDesc,
        forms = SingleSpecies(Species.Cresselia),
    };
    public static PokedexData Phione = new()
    {
        number = 489,
        name = "Phione",
        category = "SeaDrifter",
        height = 40,
        weight = 3100,
        entry = PhioneDesc,
        forms = SingleSpecies(Species.Phione),
    };
    public static PokedexData Manaphy = new()
    {
        number = 490,
        name = "Manaphy",
        category = "Seafaring",
        height = 30,
        weight = 1400,
        entry = ManaphyDesc,
        forms = SingleSpecies(Species.Manaphy),
    };
    public static PokedexData Darkrai = new()
    {
        number = 491,
        name = "Darkrai",
        category = "Pitch-Black",
        height = 150,
        weight = 50500,
        entry = DarkraiDesc,
        forms = SingleSpecies(Species.Darkrai),
    };
    public static PokedexData Shaymin = new()
    {
        number = 492,
        name = "Shaymin",
        category = "Gratitude",
        height = 20,
        weight = 2100,
        entry = ShayminDesc,
        forms = SingleSpecies(Species.Shaymin),
    };
    public static PokedexData Arceus = new()
    {
        number = 493,
        name = "Arceus",
        category = "Alpha",
        height = 320,
        weight = 320000,
        entry = ArceusDesc,
        forms = SingleSpecies(Species.Arceus),
    };
    public static PokedexData Victini = new()
    {
        number = 494,
        name = "Victini",
        category = "Victory",
        height = 40,
        weight = 4000,
        entry = VictiniDesc,
        forms = SingleSpecies(Species.Victini),
    };
    public static PokedexData Snivy = new()
    {
        number = 495,
        name = "Snivy",
        category = "GrassSnake",
        height = 60,
        weight = 8100,
        entry = SnivyDesc,
        forms = SingleSpecies(Species.Snivy),
    };
    public static PokedexData Servine = new()
    {
        number = 496,
        name = "Servine",
        category = "GrassSnake",
        height = 80,
        weight = 16000,
        entry = ServineDesc,
        forms = SingleSpecies(Species.Servine),
    };
    public static PokedexData Serperior = new()
    {
        number = 497,
        name = "Serperior",
        category = "Regal",
        height = 330,
        weight = 63000,
        entry = SerperiorDesc,
        forms = SingleSpecies(Species.Serperior),
    };
    public static PokedexData Tepig = new()
    {
        number = 498,
        name = "Tepig",
        category = "FirePig",
        height = 50,
        weight = 9900,
        entry = TepigDesc,
        forms = SingleSpecies(Species.Tepig),
    };
    public static PokedexData Pignite = new()
    {
        number = 499,
        name = "Pignite",
        category = "FirePig",
        height = 100,
        weight = 55500,
        entry = PigniteDesc,
        forms = SingleSpecies(Species.Pignite),
    };
    public static PokedexData Emboar = new()
    {
        number = 500,
        name = "Emboar",
        category = "FirePig",
        height = 160,
        weight = 150000,
        entry = EmboarDesc,
        forms = SingleSpecies(Species.Emboar),
    };
    public static PokedexData Oshawott = new()
    {
        number = 501,
        name = "Oshawott",
        category = "SeaOtter",
        height = 50,
        weight = 5900,
        entry = OshawottDesc,
        forms = SingleSpecies(Species.Oshawott),
    };
    public static PokedexData Dewott = new()
    {
        number = 502,
        name = "Dewott",
        category = "Discipline",
        height = 80,
        weight = 24500,
        entry = DewottDesc,
        forms = SingleSpecies(Species.Dewott),
    };
    public static PokedexData Samurott = new()
    {
        number = 503,
        name = "Samurott",
        category = "Formidable",
        height = 150,
        weight = 94600,
        entry = SamurottDesc,
        forms = SingleSpecies(Species.Samurott),
    };
    public static PokedexData Patrat = new()
    {
        number = 504,
        name = "Patrat",
        category = "Scout",
        height = 50,
        weight = 11600,
        entry = PatratDesc,
        forms = SingleSpecies(Species.Patrat),
    };
    public static PokedexData Watchog = new()
    {
        number = 505,
        name = "Watchog",
        category = "Lookout",
        height = 110,
        weight = 27000,
        entry = WatchogDesc,
        forms = SingleSpecies(Species.Watchog),
    };
    public static PokedexData Lillipup = new()
    {
        number = 506,
        name = "Lillipup",
        category = "Puppy",
        height = 40,
        weight = 4100,
        entry = LillipupDesc,
        forms = SingleSpecies(Species.Lillipup),
    };
    public static PokedexData Herdier = new()
    {
        number = 507,
        name = "Herdier",
        category = "LoyalDog",
        height = 90,
        weight = 14700,
        entry = HerdierDesc,
        forms = SingleSpecies(Species.Herdier),
    };
    public static PokedexData Stoutland = new()
    {
        number = 508,
        name = "Stoutland",
        category = "Big-Hearted",
        height = 120,
        weight = 61000,
        entry = StoutlandDesc,
        forms = SingleSpecies(Species.Stoutland),
    };
    public static PokedexData Purrloin = new()
    {
        number = 509,
        name = "Purrloin",
        category = "Devious",
        height = 40,
        weight = 10100,
        entry = PurrloinDesc,
        forms = SingleSpecies(Species.Purrloin),
    };
    public static PokedexData Liepard = new()
    {
        number = 510,
        name = "Liepard",
        category = "Cruel",
        height = 110,
        weight = 37500,
        entry = LiepardDesc,
        forms = SingleSpecies(Species.Liepard),
    };
    public static PokedexData Pansage = new()
    {
        number = 511,
        name = "Pansage",
        category = "GrassMonkey",
        height = 60,
        weight = 10500,
        entry = PansageDesc,
        forms = SingleSpecies(Species.Pansage),
    };
    public static PokedexData Simisage = new()
    {
        number = 512,
        name = "Simisage",
        category = "ThornMonkey",
        height = 110,
        weight = 30500,
        entry = SimisageDesc,
        forms = SingleSpecies(Species.Simisage),
    };
    public static PokedexData Pansear = new()
    {
        number = 513,
        name = "Pansear",
        category = "HighTemp",
        height = 60,
        weight = 11000,
        entry = PansearDesc,
        forms = SingleSpecies(Species.Pansear),
    };
    public static PokedexData Simisear = new()
    {
        number = 514,
        name = "Simisear",
        category = "Ember",
        height = 100,
        weight = 28000,
        entry = SimisearDesc,
        forms = SingleSpecies(Species.Simisear),
    };
    public static PokedexData Panpour = new()
    {
        number = 515,
        name = "Panpour",
        category = "Spray",
        height = 60,
        weight = 13500,
        entry = PanpourDesc,
        forms = SingleSpecies(Species.Panpour),
    };
    public static PokedexData Simipour = new()
    {
        number = 516,
        name = "Simipour",
        category = "Geyser",
        height = 100,
        weight = 29000,
        entry = SimipourDesc,
        forms = SingleSpecies(Species.Simipour),
    };
    public static PokedexData Munna = new()
    {
        number = 517,
        name = "Munna",
        category = "DreamEater",
        height = 60,
        weight = 23300,
        entry = MunnaDesc,
        forms = SingleSpecies(Species.Munna),
    };
    public static PokedexData Musharna = new()
    {
        number = 518,
        name = "Musharna",
        category = "Drowsing",
        height = 110,
        weight = 60500,
        entry = MusharnaDesc,
        forms = SingleSpecies(Species.Musharna),
    };
    public static PokedexData Pidove = new()
    {
        number = 519,
        name = "Pidove",
        category = "TinyPigeon",
        height = 30,
        weight = 2100,
        entry = PidoveDesc,
        forms = SingleSpecies(Species.Pidove),
    };
    public static PokedexData Tranquill = new()
    {
        number = 520,
        name = "Tranquill",
        category = "WildPigeon",
        height = 60,
        weight = 15000,
        entry = TranquillDesc,
        forms = SingleSpecies(Species.Tranquill),
    };
    public static PokedexData Unfezant = new()
    {
        number = 521,
        name = "Unfezant",
        category = "Proud",
        height = 120,
        weight = 29000,
        entry = UnfezantDesc,
        forms = SingleSpecies(Species.Unfezant),
    };
    public static PokedexData Blitzle = new()
    {
        number = 522,
        name = "Blitzle",
        category = "Electrified",
        height = 80,
        weight = 29800,
        entry = BlitzleDesc,
        forms = SingleSpecies(Species.Blitzle),
    };
    public static PokedexData Zebstrika = new()
    {
        number = 523,
        name = "Zebstrika",
        category = "Thunderbolt",
        height = 160,
        weight = 79500,
        entry = ZebstrikaDesc,
        forms = SingleSpecies(Species.Zebstrika),
    };
    public static PokedexData Roggenrola = new()
    {
        number = 524,
        name = "Roggenrola",
        category = "Mantle",
        height = 40,
        weight = 18000,
        entry = RoggenrolaDesc,
        forms = SingleSpecies(Species.Roggenrola),
    };
    public static PokedexData Boldore = new()
    {
        number = 525,
        name = "Boldore",
        category = "Ore",
        height = 90,
        weight = 102000,
        entry = BoldoreDesc,
        forms = SingleSpecies(Species.Boldore),
    };
    public static PokedexData Gigalith = new()
    {
        number = 526,
        name = "Gigalith",
        category = "Compressed",
        height = 170,
        weight = 260000,
        entry = GigalithDesc,
        forms = SingleSpecies(Species.Gigalith),
    };
    public static PokedexData Woobat = new()
    {
        number = 527,
        name = "Woobat",
        category = "Bat",
        height = 40,
        weight = 2100,
        entry = WoobatDesc,
        forms = SingleSpecies(Species.Woobat),
    };
    public static PokedexData Swoobat = new()
    {
        number = 528,
        name = "Swoobat",
        category = "Courting",
        height = 90,
        weight = 10500,
        entry = SwoobatDesc,
        forms = SingleSpecies(Species.Swoobat),
    };
    public static PokedexData Drilbur = new()
    {
        number = 529,
        name = "Drilbur",
        category = "Mole",
        height = 30,
        weight = 8500,
        entry = DrilburDesc,
        forms = SingleSpecies(Species.Drilbur),
    };
    public static PokedexData Excadrill = new()
    {
        number = 530,
        name = "Excadrill",
        category = "Subterrene",
        height = 70,
        weight = 40400,
        entry = ExcadrillDesc,
        forms = SingleSpecies(Species.Excadrill),
    };
    public static PokedexData Audino = new()
    {
        number = 531,
        name = "Audino",
        category = "Hearing",
        height = 110,
        weight = 31000,
        entry = AudinoDesc,
        forms = new[]
        {
            Species.Audino,
            Species.AudinoMega
        }
    };
    public static PokedexData Timburr = new()
    {
        number = 532,
        name = "Timburr",
        category = "Muscular",
        height = 60,
        weight = 12500,
        entry = TimburrDesc,
        forms = SingleSpecies(Species.Timburr),
    };
    public static PokedexData Gurdurr = new()
    {
        number = 533,
        name = "Gurdurr",
        category = "Muscular",
        height = 120,
        weight = 40000,
        entry = GurdurrDesc,
        forms = SingleSpecies(Species.Gurdurr),
    };
    public static PokedexData Conkeldurr = new()
    {
        number = 534,
        name = "Conkeldurr",
        category = "Muscular",
        height = 140,
        weight = 87000,
        entry = ConkeldurrDesc,
        forms = SingleSpecies(Species.Conkeldurr),
    };
    public static PokedexData Tympole = new()
    {
        number = 535,
        name = "Tympole",
        category = "Tadpole",
        height = 50,
        weight = 4500,
        entry = TympoleDesc,
        forms = SingleSpecies(Species.Tympole),
    };
    public static PokedexData Palpitoad = new()
    {
        number = 536,
        name = "Palpitoad",
        category = "Vibration",
        height = 80,
        weight = 17000,
        entry = PalpitoadDesc,
        forms = SingleSpecies(Species.Palpitoad),
    };
    public static PokedexData Seismitoad = new()
    {
        number = 537,
        name = "Seismitoad",
        category = "Vibration",
        height = 150,
        weight = 62000,
        entry = SeismitoadDesc,
        forms = SingleSpecies(Species.Seismitoad),
    };
    public static PokedexData Throh = new()
    {
        number = 538,
        name = "Throh",
        category = "Judo",
        height = 130,
        weight = 55500,
        entry = ThrohDesc,
        forms = SingleSpecies(Species.Throh),
    };
    public static PokedexData Sawk = new()
    {
        number = 539,
        name = "Sawk",
        category = "Karate",
        height = 140,
        weight = 51000,
        entry = SawkDesc,
        forms = SingleSpecies(Species.Sawk),
    };
    public static PokedexData Sewaddle = new()
    {
        number = 540,
        name = "Sewaddle",
        category = "Sewing",
        height = 30,
        weight = 2500,
        entry = SewaddleDesc,
        forms = SingleSpecies(Species.Sewaddle),
    };
    public static PokedexData Swadloon = new()
    {
        number = 541,
        name = "Swadloon",
        category = "Leaf-Wrapped",
        height = 50,
        weight = 7300,
        entry = SwadloonDesc,
        forms = SingleSpecies(Species.Swadloon),
    };
    public static PokedexData Leavanny = new()
    {
        number = 542,
        name = "Leavanny",
        category = "Nurturing",
        height = 120,
        weight = 20500,
        entry = LeavannyDesc,
        forms = SingleSpecies(Species.Leavanny),
    };
    public static PokedexData Venipede = new()
    {
        number = 543,
        name = "Venipede",
        category = "Centipede",
        height = 40,
        weight = 5300,
        entry = VenipedeDesc,
        forms = SingleSpecies(Species.Venipede),
    };
    public static PokedexData Whirlipede = new()
    {
        number = 544,
        name = "Whirlipede",
        category = "Curlipede",
        height = 120,
        weight = 58500,
        entry = WhirlipedeDesc,
        forms = SingleSpecies(Species.Whirlipede),
    };
    public static PokedexData Scolipede = new()
    {
        number = 545,
        name = "Scolipede",
        category = "Megapede",
        height = 250,
        weight = 200500,
        entry = ScolipedeDesc,
        forms = SingleSpecies(Species.Scolipede),
    };
    public static PokedexData Cottonee = new()
    {
        number = 546,
        name = "Cottonee",
        category = "CottonPuff",
        height = 30,
        weight = 600,
        entry = CottoneeDesc,
        forms = SingleSpecies(Species.Cottonee),
    };
    public static PokedexData Whimsicott = new()
    {
        number = 547,
        name = "Whimsicott",
        category = "Windveiled",
        height = 70,
        weight = 6600,
        entry = WhimsicottDesc,
        forms = SingleSpecies(Species.Whimsicott),
    };
    public static PokedexData Petilil = new()
    {
        number = 548,
        name = "Petilil",
        category = "Bulb",
        height = 50,
        weight = 6600,
        entry = PetililDesc,
        forms = SingleSpecies(Species.Petilil),
    };
    public static PokedexData Lilligant = new()
    {
        number = 549,
        name = "Lilligant",
        category = "Flowering",
        height = 110,
        weight = 16300,
        entry = LilligantDesc,
        forms = SingleSpecies(Species.Lilligant),
    };
    public static PokedexData Basculin = new()
    {
        number = 550,
        name = "Basculin",
        category = "Hostile",
        height = 100,
        weight = 18000,
        entry = BasculinDesc,
        forms = SingleSpecies(Species.BasculinRed),
    };
    public static PokedexData Sandile = new()
    {
        number = 551,
        name = "Sandile",
        category = "DesertCroc",
        height = 70,
        weight = 15200,
        entry = SandileDesc,
        forms = SingleSpecies(Species.Sandile),
    };
    public static PokedexData Krokorok = new()
    {
        number = 552,
        name = "Krokorok",
        category = "DesertCroc",
        height = 100,
        weight = 33400,
        entry = KrokorokDesc,
        forms = SingleSpecies(Species.Krokorok),
    };
    public static PokedexData Krookodile = new()
    {
        number = 553,
        name = "Krookodile",
        category = "Intimidate",
        height = 150,
        weight = 96300,
        entry = KrookodileDesc,
        forms = SingleSpecies(Species.Krookodile),
    };
    public static PokedexData Darumaka = new()
    {
        number = 554,
        name = "Darumaka",
        category = "ZenCharm",
        height = 60,
        weight = 37500,
        entry = DarumakaDesc,
        forms = SingleSpecies(Species.Darumaka),
    };
    public static PokedexData Darmanitan = new()
    {
        number = 555,
        name = "Darmanitan",
        category = "Blazing",
        height = 130,
        weight = 92900,
        entry = DarmanitanDesc,
        forms = SingleSpecies(Species.Darmanitan),
    };
    public static PokedexData Maractus = new()
    {
        number = 556,
        name = "Maractus",
        category = "Cactus",
        height = 100,
        weight = 28000,
        entry = MaractusDesc,
        forms = SingleSpecies(Species.Maractus),
    };
    public static PokedexData Dwebble = new()
    {
        number = 557,
        name = "Dwebble",
        category = "RockInn",
        height = 30,
        weight = 14500,
        entry = DwebbleDesc,
        forms = SingleSpecies(Species.Dwebble),
    };
    public static PokedexData Crustle = new()
    {
        number = 558,
        name = "Crustle",
        category = "StoneHome",
        height = 140,
        weight = 200000,
        entry = CrustleDesc,
        forms = SingleSpecies(Species.Crustle),
    };
    public static PokedexData Scraggy = new()
    {
        number = 559,
        name = "Scraggy",
        category = "Shedding",
        height = 60,
        weight = 11800,
        entry = ScraggyDesc,
        forms = SingleSpecies(Species.Scraggy),
    };
    public static PokedexData Scrafty = new()
    {
        number = 560,
        name = "Scrafty",
        category = "Hoodlum",
        height = 110,
        weight = 30000,
        entry = ScraftyDesc,
        forms = SingleSpecies(Species.Scrafty),
    };
    public static PokedexData Sigilyph = new()
    {
        number = 561,
        name = "Sigilyph",
        category = "Avianoid",
        height = 140,
        weight = 14000,
        entry = SigilyphDesc,
        forms = SingleSpecies(Species.Sigilyph),
    };
    public static PokedexData Yamask = new()
    {
        number = 562,
        name = "Yamask",
        category = "Spirit",
        height = 50,
        weight = 1500,
        entry = YamaskDesc,
        forms = SingleSpecies(Species.Yamask),
    };
    public static PokedexData Cofagrigus = new()
    {
        number = 563,
        name = "Cofagrigus",
        category = "Coffin",
        height = 170,
        weight = 76500,
        entry = CofagrigusDesc,
        forms = SingleSpecies(Species.Cofagrigus),
    };
    public static PokedexData Tirtouga = new()
    {
        number = 564,
        name = "Tirtouga",
        category = "Prototurtle",
        height = 70,
        weight = 16500,
        entry = TirtougaDesc,
        forms = SingleSpecies(Species.Tirtouga),
    };
    public static PokedexData Carracosta = new()
    {
        number = 565,
        name = "Carracosta",
        category = "Prototurtle",
        height = 120,
        weight = 81000,
        entry = CarracostaDesc,
        forms = SingleSpecies(Species.Carracosta),
    };
    public static PokedexData Archen = new()
    {
        number = 566,
        name = "Archen",
        category = "FirstBird",
        height = 50,
        weight = 9500,
        entry = ArchenDesc,
        forms = SingleSpecies(Species.Archen),
    };
    public static PokedexData Archeops = new()
    {
        number = 567,
        name = "Archeops",
        category = "FirstBird",
        height = 140,
        weight = 32000,
        entry = ArcheopsDesc,
        forms = SingleSpecies(Species.Archeops),
    };
    public static PokedexData Trubbish = new()
    {
        number = 568,
        name = "Trubbish",
        category = "TrashBag",
        height = 60,
        weight = 31000,
        entry = TrubbishDesc,
        forms = SingleSpecies(Species.Trubbish),
    };
    public static PokedexData Garbodor = new()
    {
        number = 569,
        name = "Garbodor",
        category = "TrashHeap",
        height = 190,
        weight = 107300,
        entry = GarbodorDesc,
        forms = SingleSpecies(Species.Garbodor),
    };
    public static PokedexData Zorua = new()
    {
        number = 570,
        name = "Zorua",
        category = "TrickyFox",
        height = 70,
        weight = 12500,
        entry = ZoruaDesc,
        forms = SingleSpecies(Species.Zorua),
    };
    public static PokedexData Zoroark = new()
    {
        number = 571,
        name = "Zoroark",
        category = "IllusionFox",
        height = 160,
        weight = 81100,
        entry = ZoroarkDesc,
        forms = SingleSpecies(Species.Zoroark),
    };
    public static PokedexData Minccino = new()
    {
        number = 572,
        name = "Minccino",
        category = "Chinchilla",
        height = 40,
        weight = 5800,
        entry = MinccinoDesc,
        forms = SingleSpecies(Species.Minccino),
    };
    public static PokedexData Cinccino = new()
    {
        number = 573,
        name = "Cinccino",
        category = "Scarf",
        height = 50,
        weight = 7500,
        entry = CinccinoDesc,
        forms = SingleSpecies(Species.Cinccino),
    };
    public static PokedexData Gothita = new()
    {
        number = 574,
        name = "Gothita",
        category = "Fixation",
        height = 40,
        weight = 5800,
        entry = GothitaDesc,
        forms = SingleSpecies(Species.Gothita),
    };
    public static PokedexData Gothorita = new()
    {
        number = 575,
        name = "Gothorita",
        category = "Manipulate",
        height = 70,
        weight = 18000,
        entry = GothoritaDesc,
        forms = SingleSpecies(Species.Gothorita),
    };
    public static PokedexData Gothitelle = new()
    {
        number = 576,
        name = "Gothitelle",
        category = "AstralBody",
        height = 150,
        weight = 44000,
        entry = GothitelleDesc,
        forms = SingleSpecies(Species.Gothitelle),
    };
    public static PokedexData Solosis = new()
    {
        number = 577,
        name = "Solosis",
        category = "Cell",
        height = 30,
        weight = 1000,
        entry = SolosisDesc,
        forms = SingleSpecies(Species.Solosis),
    };
    public static PokedexData Duosion = new()
    {
        number = 578,
        name = "Duosion",
        category = "Mitosis",
        height = 60,
        weight = 8000,
        entry = DuosionDesc,
        forms = SingleSpecies(Species.Duosion),
    };
    public static PokedexData Reuniclus = new()
    {
        number = 579,
        name = "Reuniclus",
        category = "Multiplying",
        height = 100,
        weight = 20100,
        entry = ReuniclusDesc,
        forms = SingleSpecies(Species.Reuniclus),
    };
    public static PokedexData Ducklett = new()
    {
        number = 580,
        name = "Ducklett",
        category = "WaterBird",
        height = 50,
        weight = 5500,
        entry = DucklettDesc,
        forms = SingleSpecies(Species.Ducklett),
    };
    public static PokedexData Swanna = new()
    {
        number = 581,
        name = "Swanna",
        category = "WhiteBird",
        height = 130,
        weight = 24200,
        entry = SwannaDesc,
        forms = SingleSpecies(Species.Swanna),
    };
    public static PokedexData Vanillite = new()
    {
        number = 582,
        name = "Vanillite",
        category = "FreshSnow",
        height = 40,
        weight = 5700,
        entry = VanilliteDesc,
        forms = SingleSpecies(Species.Vanillite),
    };
    public static PokedexData Vanillish = new()
    {
        number = 583,
        name = "Vanillish",
        category = "IcySnow",
        height = 110,
        weight = 41000,
        entry = VanillishDesc,
        forms = SingleSpecies(Species.Vanillish),
    };
    public static PokedexData Vanilluxe = new()
    {
        number = 584,
        name = "Vanilluxe",
        category = "Snowstorm",
        height = 130,
        weight = 57500,
        entry = VanilluxeDesc,
        forms = SingleSpecies(Species.Vanilluxe),
    };
    public static PokedexData Deerling = new()
    {
        number = 585,
        name = "Deerling",
        category = "Season",
        height = 60,
        weight = 19500,
        entry = DeerlingSpringDesc,
        forms = new[]
        {
            Species.DeerlingSpring,
            Species.DeerlingSummer,
            Species.DeerlingAutumn,
            Species.DeerlingWinter
        }
    };
    public static PokedexData Sawsbuck = new()
    {
        number = 586,
        name = "Sawsbuck",
        category = "Season",
        height = 190,
        weight = 92500,
        entry = SawsbuckSpringDesc,
        forms = new[]
        {
            Species.SawsbuckSpring,
            Species.SawsbuckSummer,
            Species.SawsbuckAutumn,
            Species.SawsbuckWinter
        }
    };
    public static PokedexData Emolga = new()
    {
        number = 587,
        name = "Emolga",
        category = "SkySquirrel",
        height = 40,
        weight = 5000,
        entry = EmolgaDesc,
        forms = SingleSpecies(Species.Emolga),
    };
    public static PokedexData Karrablast = new()
    {
        number = 588,
        name = "Karrablast",
        category = "Clamping",
        height = 50,
        weight = 5900,
        entry = KarrablastDesc,
        forms = SingleSpecies(Species.Karrablast),
    };
    public static PokedexData Escavalier = new()
    {
        number = 589,
        name = "Escavalier",
        category = "Cavalry",
        height = 100,
        weight = 33000,
        entry = EscavalierDesc,
        forms = SingleSpecies(Species.Escavalier),
    };
    public static PokedexData Foongus = new()
    {
        number = 590,
        name = "Foongus",
        category = "Mushroom",
        height = 20,
        weight = 1000,
        entry = FoongusDesc,
        forms = SingleSpecies(Species.Foongus),
    };
    public static PokedexData Amoonguss = new()
    {
        number = 591,
        name = "Amoonguss",
        category = "Mushroom",
        height = 60,
        weight = 10500,
        entry = AmoongussDesc,
        forms = SingleSpecies(Species.Amoonguss),
    };
    public static PokedexData Frillish = new()
    {
        number = 592,
        name = "Frillish",
        category = "Floating",
        height = 120,
        weight = 33000,
        entry = FrillishDesc,
        forms = SingleSpecies(Species.Frillish),
    };
    public static PokedexData Jellicent = new()
    {
        number = 593,
        name = "Jellicent",
        category = "Floating",
        height = 220,
        weight = 135000,
        entry = JellicentDesc,
        forms = SingleSpecies(Species.Jellicent),
    };
    public static PokedexData Alomomola = new()
    {
        number = 594,
        name = "Alomomola",
        category = "Caring",
        height = 120,
        weight = 31600,
        entry = AlomomolaDesc,
        forms = SingleSpecies(Species.Alomomola),
    };
    public static PokedexData Joltik = new()
    {
        number = 595,
        name = "Joltik",
        category = "Attaching",
        height = 10,
        weight = 600,
        entry = JoltikDesc,
        forms = SingleSpecies(Species.Joltik),
    };
    public static PokedexData Galvantula = new()
    {
        number = 596,
        name = "Galvantula",
        category = "EleSpider",
        height = 80,
        weight = 14300,
        entry = GalvantulaDesc,
        forms = SingleSpecies(Species.Galvantula),
    };
    public static PokedexData Ferroseed = new()
    {
        number = 597,
        name = "Ferroseed",
        category = "ThornSeed",
        height = 60,
        weight = 18800,
        entry = FerroseedDesc,
        forms = SingleSpecies(Species.Ferroseed),
    };
    public static PokedexData Ferrothorn = new()
    {
        number = 598,
        name = "Ferrothorn",
        category = "ThornPod",
        height = 100,
        weight = 110000,
        entry = FerrothornDesc,
        forms = SingleSpecies(Species.Ferrothorn),
    };
    public static PokedexData Klink = new()
    {
        number = 599,
        name = "Klink",
        category = "Gear",
        height = 30,
        weight = 21000,
        entry = KlinkDesc,
        forms = SingleSpecies(Species.Klink),
    };
    public static PokedexData Klang = new()
    {
        number = 600,
        name = "Klang",
        category = "Gear",
        height = 60,
        weight = 51000,
        entry = KlangDesc,
        forms = SingleSpecies(Species.Klang),
    };
    public static PokedexData Klinklang = new()
    {
        number = 601,
        name = "Klinklang",
        category = "Gear",
        height = 60,
        weight = 81000,
        entry = KlinklangDesc,
        forms = SingleSpecies(Species.Klinklang),
    };
    public static PokedexData Tynamo = new()
    {
        number = 602,
        name = "Tynamo",
        category = "EleFish",
        height = 20,
        weight = 300,
        entry = TynamoDesc,
        forms = SingleSpecies(Species.Tynamo),
    };
    public static PokedexData Eelektrik = new()
    {
        number = 603,
        name = "Eelektrik",
        category = "EleFish",
        height = 120,
        weight = 22000,
        entry = EelektrikDesc,
        forms = SingleSpecies(Species.Eelektrik),
    };
    public static PokedexData Eelektross = new()
    {
        number = 604,
        name = "Eelektross",
        category = "EleFish",
        height = 210,
        weight = 80500,
        entry = EelektrossDesc,
        forms = SingleSpecies(Species.Eelektross),
    };
    public static PokedexData Elgyem = new()
    {
        number = 605,
        name = "Elgyem",
        category = "Cerebral",
        height = 50,
        weight = 9000,
        entry = ElgyemDesc,
        forms = SingleSpecies(Species.Elgyem),
    };
    public static PokedexData Beheeyem = new()
    {
        number = 606,
        name = "Beheeyem",
        category = "Cerebral",
        height = 100,
        weight = 34500,
        entry = BeheeyemDesc,
        forms = SingleSpecies(Species.Beheeyem),
    };
    public static PokedexData Litwick = new()
    {
        number = 607,
        name = "Litwick",
        category = "Candle",
        height = 30,
        weight = 3100,
        entry = LitwickDesc,
        forms = SingleSpecies(Species.Litwick),
    };
    public static PokedexData Lampent = new()
    {
        number = 608,
        name = "Lampent",
        category = "Lamp",
        height = 60,
        weight = 13000,
        entry = LampentDesc,
        forms = SingleSpecies(Species.Lampent),
    };
    public static PokedexData Chandelure = new()
    {
        number = 609,
        name = "Chandelure",
        category = "Luring",
        height = 100,
        weight = 34300,
        entry = ChandelureDesc,
        forms = SingleSpecies(Species.Chandelure),
    };
    public static PokedexData Axew = new()
    {
        number = 610,
        name = "Axew",
        category = "Tusk",
        height = 60,
        weight = 18000,
        entry = AxewDesc,
        forms = SingleSpecies(Species.Axew),
    };
    public static PokedexData Fraxure = new()
    {
        number = 611,
        name = "Fraxure",
        category = "AxeJaw",
        height = 100,
        weight = 36000,
        entry = FraxureDesc,
        forms = SingleSpecies(Species.Fraxure),
    };
    public static PokedexData Haxorus = new()
    {
        number = 612,
        name = "Haxorus",
        category = "AxeJaw",
        height = 180,
        weight = 105500,
        entry = HaxorusDesc,
        forms = SingleSpecies(Species.Haxorus),
    };
    public static PokedexData Cubchoo = new()
    {
        number = 613,
        name = "Cubchoo",
        category = "Chill",
        height = 50,
        weight = 8500,
        entry = CubchooDesc,
        forms = SingleSpecies(Species.Cubchoo),
    };
    public static PokedexData Beartic = new()
    {
        number = 614,
        name = "Beartic",
        category = "Freezing",
        height = 260,
        weight = 260000,
        entry = BearticDesc,
        forms = SingleSpecies(Species.Beartic),
    };
    public static PokedexData Cryogonal = new()
    {
        number = 615,
        name = "Cryogonal",
        category = "Crystallize",
        height = 110,
        weight = 148000,
        entry = CryogonalDesc,
        forms = SingleSpecies(Species.Cryogonal),
    };
    public static PokedexData Shelmet = new()
    {
        number = 616,
        name = "Shelmet",
        category = "Snail",
        height = 40,
        weight = 7700,
        entry = ShelmetDesc,
        forms = SingleSpecies(Species.Shelmet),
    };
    public static PokedexData Accelgor = new()
    {
        number = 617,
        name = "Accelgor",
        category = "ShellOut",
        height = 80,
        weight = 25300,
        entry = AccelgorDesc,
        forms = SingleSpecies(Species.Accelgor),
    };
    public static PokedexData Stunfisk = new()
    {
        number = 618,
        name = "Stunfisk",
        category = "Trap",
        height = 70,
        weight = 11000,
        entry = StunfiskDesc,
        forms = SingleSpecies(Species.Stunfisk),
    };
    public static PokedexData Mienfoo = new()
    {
        number = 619,
        name = "Mienfoo",
        category = "MartialArts",
        height = 90,
        weight = 20000,
        entry = MienfooDesc,
        forms = SingleSpecies(Species.Mienfoo),
    };
    public static PokedexData Mienshao = new()
    {
        number = 620,
        name = "Mienshao",
        category = "MartialArts",
        height = 140,
        weight = 35500,
        entry = MienshaoDesc,
        forms = SingleSpecies(Species.Mienshao),
    };
    public static PokedexData Druddigon = new()
    {
        number = 621,
        name = "Druddigon",
        category = "Cave",
        height = 160,
        weight = 139000,
        entry = DruddigonDesc,
        forms = SingleSpecies(Species.Druddigon),
    };
    public static PokedexData Golett = new()
    {
        number = 622,
        name = "Golett",
        category = "Automaton",
        height = 100,
        weight = 92000,
        entry = GolettDesc,
        forms = SingleSpecies(Species.Golett),
    };
    public static PokedexData Golurk = new()
    {
        number = 623,
        name = "Golurk",
        category = "Automaton",
        height = 280,
        weight = 330000,
        entry = GolurkDesc,
        forms = SingleSpecies(Species.Golurk),
    };
    public static PokedexData Pawniard = new()
    {
        number = 624,
        name = "Pawniard",
        category = "SharpBlade",
        height = 50,
        weight = 10200,
        entry = PawniardDesc,
        forms = SingleSpecies(Species.Pawniard),
    };
    public static PokedexData Bisharp = new()
    {
        number = 625,
        name = "Bisharp",
        category = "SwordBlade",
        height = 160,
        weight = 70000,
        entry = BisharpDesc,
        forms = SingleSpecies(Species.Bisharp),
    };
    public static PokedexData Bouffalant = new()
    {
        number = 626,
        name = "Bouffalant",
        category = "BashBuffalo",
        height = 160,
        weight = 94600,
        entry = BouffalantDesc,
        forms = SingleSpecies(Species.Bouffalant),
    };
    public static PokedexData Rufflet = new()
    {
        number = 627,
        name = "Rufflet",
        category = "Eaglet",
        height = 50,
        weight = 10500,
        entry = RuffletDesc,
        forms = SingleSpecies(Species.Rufflet),
    };
    public static PokedexData Braviary = new()
    {
        number = 628,
        name = "Braviary",
        category = "Valiant",
        height = 150,
        weight = 41000,
        entry = BraviaryDesc,
        forms = SingleSpecies(Species.Braviary),
    };
    public static PokedexData Vullaby = new()
    {
        number = 629,
        name = "Vullaby",
        category = "Diapered",
        height = 50,
        weight = 9000,
        entry = VullabyDesc,
        forms = SingleSpecies(Species.Vullaby),
    };
    public static PokedexData Mandibuzz = new()
    {
        number = 630,
        name = "Mandibuzz",
        category = "BoneVulture",
        height = 120,
        weight = 39500,
        entry = MandibuzzDesc,
        forms = SingleSpecies(Species.Mandibuzz),
    };
    public static PokedexData Heatmor = new()
    {
        number = 631,
        name = "Heatmor",
        category = "Anteater",
        height = 140,
        weight = 58000,
        entry = HeatmorDesc,
        forms = SingleSpecies(Species.Heatmor),
    };
    public static PokedexData Durant = new()
    {
        number = 632,
        name = "Durant",
        category = "IronAnt",
        height = 30,
        weight = 33000,
        entry = DurantDesc,
        forms = SingleSpecies(Species.Durant),
    };
    public static PokedexData Deino = new()
    {
        number = 633,
        name = "Deino",
        category = "Irate",
        height = 80,
        weight = 17300,
        entry = DeinoDesc,
        forms = SingleSpecies(Species.Deino),
    };
    public static PokedexData Zweilous = new()
    {
        number = 634,
        name = "Zweilous",
        category = "Hostile",
        height = 140,
        weight = 50000,
        entry = ZweilousDesc,
        forms = SingleSpecies(Species.Zweilous),
    };
    public static PokedexData Hydreigon = new()
    {
        number = 635,
        name = "Hydreigon",
        category = "Brutal",
        height = 180,
        weight = 160000,
        entry = HydreigonDesc,
        forms = SingleSpecies(Species.Hydreigon),
    };
    public static PokedexData Larvesta = new()
    {
        number = 636,
        name = "Larvesta",
        category = "Torch",
        height = 110,
        weight = 28800,
        entry = LarvestaDesc,
        forms = SingleSpecies(Species.Larvesta),
    };
    public static PokedexData Volcarona = new()
    {
        number = 637,
        name = "Volcarona",
        category = "Sun",
        height = 160,
        weight = 46000,
        entry = VolcaronaDesc,
        forms = SingleSpecies(Species.Volcarona),
    };
    public static PokedexData Cobalion = new()
    {
        number = 638,
        name = "Cobalion",
        category = "IronWill",
        height = 210,
        weight = 250000,
        entry = CobalionDesc,
        forms = SingleSpecies(Species.Cobalion),
    };
    public static PokedexData Terrakion = new()
    {
        number = 639,
        name = "Terrakion",
        category = "Cavern",
        height = 190,
        weight = 260000,
        entry = TerrakionDesc,
        forms = SingleSpecies(Species.Terrakion),
    };
    public static PokedexData Virizion = new()
    {
        number = 640,
        name = "Virizion",
        category = "Grassland",
        height = 200,
        weight = 200000,
        entry = VirizionDesc,
        forms = SingleSpecies(Species.Virizion),
    };
    public static PokedexData Tornadus = new()
    {
        number = 641,
        name = "Tornadus",
        category = "Cyclone",
        height = 150,
        weight = 63000,
        entry = TornadusDesc,
        forms = new[]
        {
            Species.TornadusI,
            Species.TornadusT
        }
    };
    public static PokedexData Thundurus = new()
    {
        number = 642,
        name = "Thundurus",
        category = "BoltStrike",
        height = 150,
        weight = 61000,
        entry = ThundurusDesc,
        forms = new[]
        {
            Species.ThundurusI,
            Species.ThundurusT
        }
    };
    public static PokedexData Reshiram = new()
    {
        number = 643,
        name = "Reshiram",
        category = "VastWhite",
        height = 320,
        weight = 330000,
        entry = ReshiramDesc,
        forms = SingleSpecies(Species.Reshiram),
    };
    public static PokedexData Zekrom = new()
    {
        number = 644,
        name = "Zekrom",
        category = "DeepBlack",
        height = 290,
        weight = 345000,
        entry = ZekromDesc,
        forms = SingleSpecies(Species.Zekrom),
    };
    public static PokedexData Landorus = new()
    {
        number = 645,
        name = "Landorus",
        category = "Abundance",
        height = 150,
        weight = 68000,
        entry = LandorusDesc,
        forms = new[]
        {
            Species.LandorusI,
            Species.LandorusT
        }
    };
    public static PokedexData Kyurem = new()
    {
        number = 646,
        name = "Kyurem",
        category = "Boundary",
        height = 300,
        weight = 325000,
        entry = KyuremDesc,
        forms = new[]
        {
            Species.Kyurem,
            Species.KyuremWhite,
            Species.KyuremBlack
        }
    };
    public static PokedexData Keldeo = new()
    {
        number = 647,
        name = "Keldeo",
        category = "Colt",
        height = 140,
        weight = 48500,
        entry = KeldeoDesc,
        forms = new[]
        {
            Species.KeldeoOriginal,
            Species.KeldeoResolute
        }
    };
    public static PokedexData Meloetta = new()
    {
        number = 648,
        name = "Meloetta",
        category = "Melody",
        height = 60,
        weight = 6500,
        entry = MeloettaDesc,
        forms = new[]
        {
            Species.MeloettaAria,
            Species.MeloettaPirouette
        }
    };
    public static PokedexData Genesect = new()
    {
        number = 649,
        name = "Genesect",
        category = "Paleozoic",
        height = 150,
        weight = 82500,
        entry = GenesectDesc,
        forms = new[]
        {
            Species.GenesectNormal,
            Species.GenesectDouse,
            Species.GenesectShock,
            Species.GenesectBurn,
            Species.GenesectChill
        }
    };


}