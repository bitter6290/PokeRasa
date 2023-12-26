using static PokedexDesc;
using static SpeciesData;

public static class Pokedex
{
    public static readonly PokedexData Bulbasaur = new()
    {
        number = 1,
        name = "Bulbasaur",
        category = "Seed",
        height = 70,
        weight = 6900,
        entry = BulbasaurDesc,
        forms = SingleSpecies(Species.Bulbasaur),
    };
    public static readonly PokedexData Ivysaur = new()
    {
        number = 2,
        name = "Ivysaur",
        category = "Seed",
        height = 100,
        weight = 13000,
        entry = IvysaurDesc,
        forms = SingleSpecies(Species.Ivysaur),
    };
    public static readonly PokedexData Venusaur = new()
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
    public static readonly PokedexData Charmander = new()
    {
        number = 4,
        name = "Charmander",
        category = "Lizard",
        height = 60,
        weight = 8500,
        entry = CharmanderDesc,
        forms = SingleSpecies(Species.Charmander),
    };
    public static readonly PokedexData Charmeleon = new()
    {
        number = 5,
        name = "Charmeleon",
        category = "Flame",
        height = 110,
        weight = 19000,
        entry = CharmeleonDesc,
        forms = SingleSpecies(Species.Charmeleon),
    };
    public static readonly PokedexData Charizard = new()
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
    public static readonly PokedexData Squirtle = new()
    {
        number = 7,
        name = "Squirtle",
        category = "TinyTurtle",
        height = 50,
        weight = 9000,
        entry = SquirtleDesc,
        forms = SingleSpecies(Species.Squirtle),
    };
    public static readonly PokedexData Wartortle = new()
    {
        number = 8,
        name = "Wartortle",
        category = "Turtle",
        height = 100,
        weight = 22500,
        entry = WartortleDesc,
        forms = SingleSpecies(Species.Wartortle),
    };
    public static readonly PokedexData Blastoise = new()
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
    public static readonly PokedexData Caterpie = new()
    {
        number = 10,
        name = "Caterpie",
        category = "Worm",
        height = 30,
        weight = 2900,
        entry = CaterpieDesc,
        forms = SingleSpecies(Species.Caterpie),
    };
    public static readonly PokedexData Metapod = new()
    {
        number = 11,
        name = "Metapod",
        category = "Cocoon",
        height = 70,
        weight = 9900,
        entry = MetapodDesc,
        forms = SingleSpecies(Species.Metapod),
    };
    public static readonly PokedexData Butterfree = new()
    {
        number = 12,
        name = "Butterfree",
        category = "Butterfly",
        height = 110,
        weight = 32000,
        entry = ButterfreeDesc,
        forms = SingleSpecies(Species.Butterfree),
    };
    public static readonly PokedexData Weedle = new()
    {
        number = 13,
        name = "Weedle",
        category = "Hairy Bug",
        height = 30,
        weight = 3200,
        entry = WeedleDesc,
        forms = SingleSpecies(Species.Weedle),
    };
    public static readonly PokedexData Kakuna = new()
    {
        number = 14,
        name = "Kakuna",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = KakunaDesc,
        forms = SingleSpecies(Species.Kakuna),
    };
    public static readonly PokedexData Beedrill = new()
    {
        number = 15,
        name = "Beedrill",
        category = "Poison Bee",
        height = 100,
        weight = 29500,
        entry = BeedrillDesc,
        forms = new[]
        {
            Species.Beedrill,
            Species.BeedrillMega
        }
    };
    public static readonly PokedexData Pidgey = new()
    {
        number = 16,
        name = "Pidgey",
        category = "Tiny Bird",
        height = 30,
        weight = 1800,
        entry = PidgeyDesc,
        forms = SingleSpecies(Species.Pidgey),
    };
    public static readonly PokedexData Pidgeotto = new()
    {
        number = 17,
        name = "Pidgeotto",
        category = "Bird",
        height = 110,
        weight = 30000,
        entry = PidgeottoDesc,
        forms = SingleSpecies(Species.Pidgeotto),
    };
    public static readonly PokedexData Pidgeot = new()
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
    public static readonly PokedexData Rattata = new()
    {
        number = 19,
        name = "Rattata",
        category = "Mouse",
        height = 30,
        weight = 3500,
        entry = RattataDesc,
        forms = new[]
        {
            Species.Rattata,
            Species.RattataAlola
        }
    };
    public static readonly PokedexData Raticate = new()
    {
        number = 20,
        name = "Raticate",
        category = "Mouse",
        height = 70,
        weight = 18500,
        entry = RaticateDesc,
        forms = new[]
        {
            Species.Raticate,
            Species.RaticateAlola
        }
    };
    public static readonly PokedexData Spearow = new()
    {
        number = 21,
        name = "Spearow",
        category = "Tiny Bird",
        height = 30,
        weight = 2000,
        entry = SpearowDesc,
        forms = SingleSpecies(Species.Spearow),
    };
    public static readonly PokedexData Fearow = new()
    {
        number = 22,
        name = "Fearow",
        category = "Beak",
        height = 120,
        weight = 38000,
        entry = FearowDesc,
        forms = SingleSpecies(Species.Fearow),
    };
    public static readonly PokedexData Ekans = new()
    {
        number = 23,
        name = "Ekans",
        category = "Snake",
        height = 200,
        weight = 6900,
        entry = EkansDesc,
        forms = SingleSpecies(Species.Ekans),
    };
    public static readonly PokedexData Arbok = new()
    {
        number = 24,
        name = "Arbok",
        category = "Cobra",
        height = 350,
        weight = 65000,
        entry = ArbokDesc,
        forms = SingleSpecies(Species.Arbok),
    };
    public static readonly PokedexData Pikachu = new()
    {
        number = 25,
        name = "Pikachu",
        category = "Mouse",
        height = 40,
        weight = 6000,
        entry = PikachuDesc,
        forms = new[]
        {
            Species.Pikachu,
            Species.PikachuCosplay,
            Species.PikachuRockStar,
            Species.PikachuBelle,
            Species.PikachuPopStar,
            Species.PikachuPhD,
            Species.PikachuLibre,
            Species.PikachuOriginal,
            Species.PikachuHoenn,
            Species.PikachuSinnoh,
            Species.PikachuUnova,
            Species.PikachuKalos,
            Species.PikachuAlolaCap,
            Species.PikachuPartnerCap,
            Species.PikachuWorld,
            Species.PikachuPartner
        }
    };
    public static readonly PokedexData Raichu = new()
    {
        number = 26,
        name = "Raichu",
        category = "Mouse",
        height = 80,
        weight = 30000,
        entry = RaichuDesc,
        forms = new[]
        {
            Species.Raichu,
            Species.RaichuAlola
        }
    };
    public static readonly PokedexData Sandshrew = new()
    {
        number = 27,
        name = "Sandshrew",
        category = "Mouse",
        height = 60,
        weight = 12000,
        entry = SandshrewDesc,
        forms = new[]
        {
            Species.Sandshrew,
            Species.SandshrewAlola
        }
    };
    public static readonly PokedexData Sandslash = new()
    {
        number = 28,
        name = "Sandslash",
        category = "Mouse",
        height = 100,
        weight = 29500,
        entry = SandslashDesc,
        forms = new[]
        {
            Species.Sandslash,
            Species.SandslashAlola
        }
    };
    public static readonly PokedexData NidoranF = new ()
	{
		number = 29,
		name = "Nidoran",
		category = "Poison Pin",
		height = 40,
		weight = 7000,
		entry = NidoranFDesc,
        forms = SingleSpecies(Species.NidoranF),

    };
    public static readonly PokedexData Nidorina = new()
    {
        number = 30,
        name = "Nidorina",
        category = "Poison Pin",
        height = 80,
        weight = 20000,
        entry = NidorinaDesc,
        forms = SingleSpecies(Species.Nidorina),
    };
    public static readonly PokedexData Nidoqueen = new()
    {
        number = 31,
        name = "Nidoqueen",
        category = "Drill",
        height = 130,
        weight = 60000,
        entry = NidoqueenDesc,
        forms = SingleSpecies(Species.Nidoqueen),
    };
    public static readonly PokedexData NidoranM = new()
    {
        number = 32,
        name = "Nidoran",
        category = "Poison Pin",
        height = 50,
        weight = 9000,
        entry = NidoranMDesc,
        forms = SingleSpecies(Species.NidoranM),
    };
    public static readonly PokedexData Nidorino = new()
    {
        number = 33,
        name = "Nidorino",
        category = "Poison Pin",
        height = 90,
        weight = 19500,
        entry = NidorinoDesc,
        forms = SingleSpecies(Species.Nidorino),
    };
    public static readonly PokedexData Nidoking = new()
    {
        number = 34,
        name = "Nidoking",
        category = "Drill",
        height = 140,
        weight = 62000,
        entry = NidokingDesc,
        forms = SingleSpecies(Species.Nidoking),
    };
    public static readonly PokedexData Clefairy = new()
    {
        number = 35,
        name = "Clefairy",
        category = "Fairy",
        height = 60,
        weight = 7500,
        entry = ClefairyDesc,
        forms = SingleSpecies(Species.Clefairy),
    };
    public static readonly PokedexData Clefable = new()
    {
        number = 36,
        name = "Clefable",
        category = "Fairy",
        height = 130,
        weight = 40000,
        entry = ClefableDesc,
        forms = SingleSpecies(Species.Clefable),
    };
    public static readonly PokedexData Vulpix = new()
    {
        number = 37,
        name = "Vulpix",
        category = "Fox",
        height = 60,
        weight = 9900,
        entry = VulpixDesc,
        forms = new[]
        {
            Species.Vulpix,
            Species.VulpixAlola
        }
    };
    public static readonly PokedexData Ninetales = new()
    {
        number = 38,
        name = "Ninetales",
        category = "Fox",
        height = 110,
        weight = 19900,
        entry = NinetalesDesc,
        forms = new[]
        {
            Species.Ninetales,
            Species.NinetalesAlola
        }
    };
    public static readonly PokedexData Jigglypuff = new()
    {
        number = 39,
        name = "Jigglypuff",
        category = "Balloon",
        height = 50,
        weight = 5500,
        entry = JigglypuffDesc,
        forms = SingleSpecies(Species.Jigglypuff),
    };
    public static readonly PokedexData Wigglytuff = new()
    {
        number = 40,
        name = "Wigglytuff",
        category = "Balloon",
        height = 100,
        weight = 12000,
        entry = WigglytuffDesc,
        forms = SingleSpecies(Species.Wigglytuff),
    };
    public static readonly PokedexData Zubat = new()
    {
        number = 41,
        name = "Zubat",
        category = "Bat",
        height = 80,
        weight = 7500,
        entry = ZubatDesc,
        forms = SingleSpecies(Species.Zubat),
    };
    public static readonly PokedexData Golbat = new()
    {
        number = 42,
        name = "Golbat",
        category = "Bat",
        height = 160,
        weight = 55000,
        entry = GolbatDesc,
        forms = SingleSpecies(Species.Golbat),
    };
    public static readonly PokedexData Oddish = new()
    {
        number = 43,
        name = "Oddish",
        category = "Weed",
        height = 50,
        weight = 5400,
        entry = OddishDesc,
        forms = SingleSpecies(Species.Oddish),
    };
    public static readonly PokedexData Gloom = new()
    {
        number = 44,
        name = "Gloom",
        category = "Weed",
        height = 80,
        weight = 8600,
        entry = GloomDesc,
        forms = SingleSpecies(Species.Gloom),
    };
    public static readonly PokedexData Vileplume = new()
    {
        number = 45,
        name = "Vileplume",
        category = "Flower",
        height = 120,
        weight = 18600,
        entry = VileplumeDesc,
        forms = SingleSpecies(Species.Vileplume),
    };
    public static readonly PokedexData Paras = new()
    {
        number = 46,
        name = "Paras",
        category = "Mushroom",
        height = 30,
        weight = 5400,
        entry = ParasDesc,
        forms = SingleSpecies(Species.Paras),
    };
    public static readonly PokedexData Parasect = new()
    {
        number = 47,
        name = "Parasect",
        category = "Mushroom",
        height = 100,
        weight = 29500,
        entry = ParasectDesc,
        forms = SingleSpecies(Species.Parasect),
    };
    public static readonly PokedexData Venonat = new()
    {
        number = 48,
        name = "Venonat",
        category = "Insect",
        height = 100,
        weight = 30000,
        entry = VenonatDesc,
        forms = SingleSpecies(Species.Venonat),
    };
    public static readonly PokedexData Venomoth = new()
    {
        number = 49,
        name = "Venomoth",
        category = "Poison Moth",
        height = 150,
        weight = 12500,
        entry = VenomothDesc,
        forms = SingleSpecies(Species.Venomoth),
    };
    public static readonly PokedexData Diglett = new()
    {
        number = 50,
        name = "Diglett",
        category = "Mole",
        height = 20,
        weight = 800,
        entry = DiglettDesc,
        forms = new[]
        {
            Species.Diglett,
            Species.DiglettAlola
        }
    };
    public static readonly PokedexData Dugtrio = new()
    {
        number = 51,
        name = "Dugtrio",
        category = "Mole",
        height = 70,
        weight = 33300,
        entry = DugtrioDesc,
        forms = new[]
        {
            Species.Dugtrio,
            Species.DugtrioAlola
        }
    };
    public static readonly PokedexData Meowth = new()
    {
        number = 52,
        name = "Meowth",
        category = "Scratch Cat",
        height = 40,
        weight = 4200,
        entry = MeowthDesc,
        forms = new[]
        {
            Species.Meowth,
            Species.MeowthAlola
        }
    };
    public static readonly PokedexData Persian = new()
    {
        number = 53,
        name = "Persian",
        category = "Classy Cat",
        height = 100,
        weight = 32000,
        entry = PersianDesc,
        forms = new[]
        {
            Species.Persian,
            Species.PersianAlola
        }
    };
    public static readonly PokedexData Psyduck = new()
    {
        number = 54,
        name = "Psyduck",
        category = "Duck",
        height = 80,
        weight = 19600,
        entry = PsyduckDesc,
        forms = SingleSpecies(Species.Psyduck),
    };
    public static readonly PokedexData Golduck = new()
    {
        number = 55,
        name = "Golduck",
        category = "Duck",
        height = 170,
        weight = 76600,
        entry = GolduckDesc,
        forms = SingleSpecies(Species.Golduck),
    };
    public static readonly PokedexData Mankey = new()
    {
        number = 56,
        name = "Mankey",
        category = "Pig Monkey",
        height = 50,
        weight = 28000,
        entry = MankeyDesc,
        forms = SingleSpecies(Species.Mankey),
    };
    public static readonly PokedexData Primeape = new()
    {
        number = 57,
        name = "Primeape",
        category = "Pig Monkey",
        height = 100,
        weight = 32000,
        entry = PrimeapeDesc,
        forms = SingleSpecies(Species.Primeape),
    };
    public static readonly PokedexData Growlithe = new()
    {
        number = 58,
        name = "Growlithe",
        category = "Puppy",
        height = 70,
        weight = 19000,
        entry = GrowlitheDesc,
        forms = SingleSpecies(Species.Growlithe),
    };
    public static readonly PokedexData Arcanine = new()
    {
        number = 59,
        name = "Arcanine",
        category = "Legendary",
        height = 190,
        weight = 155000,
        entry = ArcanineDesc,
        forms = SingleSpecies(Species.Arcanine),
    };
    public static readonly PokedexData Poliwag = new()
    {
        number = 60,
        name = "Poliwag",
        category = "Tadpole",
        height = 60,
        weight = 12400,
        entry = PoliwagDesc,
        forms = SingleSpecies(Species.Poliwag),
    };
    public static readonly PokedexData Poliwhirl = new()
    {
        number = 61,
        name = "Poliwhirl",
        category = "Tadpole",
        height = 100,
        weight = 20000,
        entry = PoliwhirlDesc,
        forms = SingleSpecies(Species.Poliwhirl),
    };
    public static readonly PokedexData Poliwrath = new()
    {
        number = 62,
        name = "Poliwrath",
        category = "Tadpole",
        height = 130,
        weight = 54000,
        entry = PoliwrathDesc,
        forms = SingleSpecies(Species.Poliwrath),
    };
    public static readonly PokedexData Abra = new()
    {
        number = 63,
        name = "Abra",
        category = "Psi",
        height = 90,
        weight = 19500,
        entry = AbraDesc,
        forms = SingleSpecies(Species.Abra),
    };
    public static readonly PokedexData Kadabra = new()
    {
        number = 64,
        name = "Kadabra",
        category = "Psi",
        height = 130,
        weight = 56500,
        entry = KadabraDesc,
        forms = SingleSpecies(Species.Kadabra),
    };
    public static readonly PokedexData Alakazam = new()
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
    public static readonly PokedexData Machop = new()
    {
        number = 66,
        name = "Machop",
        category = "Superpower",
        height = 80,
        weight = 19500,
        entry = MachopDesc,
        forms = SingleSpecies(Species.Machop),
    };
    public static readonly PokedexData Machoke = new()
    {
        number = 67,
        name = "Machoke",
        category = "Superpower",
        height = 150,
        weight = 70500,
        entry = MachokeDesc,
        forms = SingleSpecies(Species.Machoke),
    };
    public static readonly PokedexData Machamp = new()
    {
        number = 68,
        name = "Machamp",
        category = "Superpower",
        height = 160,
        weight = 130000,
        entry = MachampDesc,
        forms = SingleSpecies(Species.Machamp),
    };
    public static readonly PokedexData Bellsprout = new()
    {
        number = 69,
        name = "Bellsprout",
        category = "Flower",
        height = 70,
        weight = 4000,
        entry = BellsproutDesc,
        forms = SingleSpecies(Species.Bellsprout),
    };
    public static readonly PokedexData Weepinbell = new()
    {
        number = 70,
        name = "Weepinbell",
        category = "Flycatcher",
        height = 100,
        weight = 6400,
        entry = WeepinbellDesc,
        forms = SingleSpecies(Species.Weepinbell),
    };
    public static readonly PokedexData Victreebel = new()
    {
        number = 71,
        name = "Victreebel",
        category = "Flycatcher",
        height = 170,
        weight = 15500,
        entry = VictreebelDesc,
        forms = SingleSpecies(Species.Victreebel),
    };
    public static readonly PokedexData Tentacool = new()
    {
        number = 72,
        name = "Tentacool",
        category = "Jellyfish",
        height = 90,
        weight = 45500,
        entry = TentacoolDesc,
        forms = SingleSpecies(Species.Tentacool),
    };
    public static readonly PokedexData Tentacruel = new()
    {
        number = 73,
        name = "Tentacruel",
        category = "Jellyfish",
        height = 160,
        weight = 55000,
        entry = TentacruelDesc,
        forms = SingleSpecies(Species.Tentacruel),
    };
    public static readonly PokedexData Geodude = new()
    {
        number = 74,
        name = "Geodude",
        category = "Rock",
        height = 40,
        weight = 20000,
        entry = GeodudeDesc,
        forms = new[]
        {
            Species.Geodude,
            Species.GeodudeAlola
        }
    };
    public static readonly PokedexData Graveler = new()
    {
        number = 75,
        name = "Graveler",
        category = "Rock",
        height = 100,
        weight = 105000,
        entry = GravelerDesc,
        forms = new[]
        {
            Species.Graveler,
            Species.GravelerAlola
        }
    };
    public static readonly PokedexData Golem = new()
    {
        number = 76,
        name = "Golem",
        category = "Megaton",
        height = 140,
        weight = 300000,
        entry = GolemDesc,
        forms = new[]
        {
            Species.Golem,
            Species.GolemAlola
        }
    };
    public static readonly PokedexData Ponyta = new()
    {
        number = 77,
        name = "Ponyta",
        category = "Fire Horse",
        height = 100,
        weight = 30000,
        entry = PonytaDesc,
        forms = SingleSpecies(Species.Ponyta),
    };
    public static readonly PokedexData Rapidash = new()
    {
        number = 78,
        name = "Rapidash",
        category = "Fire Horse",
        height = 170,
        weight = 95000,
        entry = RapidashDesc,
        forms = SingleSpecies(Species.Rapidash),
    };
    public static readonly PokedexData Slowpoke = new()
    {
        number = 79,
        name = "Slowpoke",
        category = "Dopey",
        height = 120,
        weight = 36000,
        entry = SlowpokeDesc,
        forms = SingleSpecies(Species.Slowpoke),
    };
    public static readonly PokedexData Slowbro = new()
    {
        number = 80,
        name = "Slowbro",
        category = "Hermit Crab",
        height = 160,
        weight = 78500,
        entry = SlowbroDesc,
        forms = new[]
        {
            Species.Slowbro,
            Species.SlowbroMega
        }
    };
    public static readonly PokedexData Magnemite = new()
    {
        number = 81,
        name = "Magnemite",
        category = "Magnet",
        height = 30,
        weight = 6000,
        entry = MagnemiteDesc,
        forms = SingleSpecies(Species.Magnemite),
    };
    public static readonly PokedexData Magneton = new()
    {
        number = 82,
        name = "Magneton",
        category = "Magnet",
        height = 100,
        weight = 60000,
        entry = MagnetonDesc,
        forms = SingleSpecies(Species.Magneton),
    };
    public static readonly PokedexData Farfetchd = new()
    {
        number = 83,
        name = "Farfetchd",
        category = "Wild Duck",
        height = 80,
        weight = 15000,
        entry = FarfetchdDesc,
        forms = SingleSpecies(Species.Farfetchd),
    };
    public static readonly PokedexData Doduo = new()
    {
        number = 84,
        name = "Doduo",
        category = "Twin Bird",
        height = 140,
        weight = 39200,
        entry = DoduoDesc,
        forms = SingleSpecies(Species.Doduo),
    };
    public static readonly PokedexData Dodrio = new()
    {
        number = 85,
        name = "Dodrio",
        category = "Triple Bird",
        height = 180,
        weight = 85200,
        entry = DodrioDesc,
        forms = SingleSpecies(Species.Dodrio),
    };
    public static readonly PokedexData Seel = new()
    {
        number = 86,
        name = "Seel",
        category = "SeaLion",
        height = 110,
        weight = 90000,
        entry = SeelDesc,
        forms = SingleSpecies(Species.Seel),
    };
    public static readonly PokedexData Dewgong = new()
    {
        number = 87,
        name = "Dewgong",
        category = "SeaLion",
        height = 170,
        weight = 120000,
        entry = DewgongDesc,
        forms = SingleSpecies(Species.Dewgong),
    };
    public static readonly PokedexData Grimer = new()
    {
        number = 88,
        name = "Grimer",
        category = "Sludge",
        height = 90,
        weight = 30000,
        entry = GrimerDesc,
        forms = new[]
        {
            Species.Grimer,
            Species.GrimerAlola
        }
    };
    public static readonly PokedexData Muk = new()
    {
        number = 89,
        name = "Muk",
        category = "Sludge",
        height = 120,
        weight = 30000,
        entry = MukDesc,
        forms = new[]
        {
            Species.Muk,
            Species.MukAlola
        }
    };
    public static readonly PokedexData Shellder = new()
    {
        number = 90,
        name = "Shellder",
        category = "Bivalve",
        height = 30,
        weight = 4000,
        entry = ShellderDesc,
        forms = SingleSpecies(Species.Shellder),
    };
    public static readonly PokedexData Cloyster = new()
    {
        number = 91,
        name = "Cloyster",
        category = "Bivalve",
        height = 150,
        weight = 132500,
        entry = CloysterDesc,
        forms = SingleSpecies(Species.Cloyster),
    };
    public static readonly PokedexData Gastly = new()
    {
        number = 92,
        name = "Gastly",
        category = "Gas",
        height = 130,
        weight = 100,
        entry = GastlyDesc,
        forms = SingleSpecies(Species.Gastly),
    };
    public static readonly PokedexData Haunter = new()
    {
        number = 93,
        name = "Haunter",
        category = "Gas",
        height = 160,
        weight = 100,
        entry = HaunterDesc,
        forms = SingleSpecies(Species.Haunter),
    };
    public static readonly PokedexData Gengar = new()
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
    public static readonly PokedexData Onix = new()
    {
        number = 95,
        name = "Onix",
        category = "Rock Snake",
        height = 880,
        weight = 210000,
        entry = OnixDesc,
        forms = SingleSpecies(Species.Onix),
    };
    public static readonly PokedexData Drowzee = new()
    {
        number = 96,
        name = "Drowzee",
        category = "Hypnosis",
        height = 100,
        weight = 32400,
        entry = DrowzeeDesc,
        forms = SingleSpecies(Species.Drowzee),
    };
    public static readonly PokedexData Hypno = new()
    {
        number = 97,
        name = "Hypno",
        category = "Hypnosis",
        height = 160,
        weight = 75600,
        entry = HypnoDesc,
        forms = SingleSpecies(Species.Hypno),
    };
    public static readonly PokedexData Krabby = new()
    {
        number = 98,
        name = "Krabby",
        category = "River Crab",
        height = 40,
        weight = 6500,
        entry = KrabbyDesc,
        forms = SingleSpecies(Species.Krabby),
    };
    public static readonly PokedexData Kingler = new()
    {
        number = 99,
        name = "Kingler",
        category = "Pincer",
        height = 130,
        weight = 60000,
        entry = KinglerDesc,
        forms = SingleSpecies(Species.Kingler),
    };
    public static readonly PokedexData Voltorb = new()
    {
        number = 100,
        name = "Voltorb",
        category = "Ball",
        height = 50,
        weight = 10400,
        entry = VoltorbDesc,
        forms = SingleSpecies(Species.Voltorb),
    };
    public static readonly PokedexData Electrode = new()
    {
        number = 101,
        name = "Electrode",
        category = "Ball",
        height = 120,
        weight = 66600,
        entry = ElectrodeDesc,
        forms = SingleSpecies(Species.Electrode),
    };
    public static readonly PokedexData Exeggcute = new()
    {
        number = 102,
        name = "Exeggcute",
        category = "Egg",
        height = 40,
        weight = 2500,
        entry = ExeggcuteDesc,
        forms = SingleSpecies(Species.Exeggcute),
    };
    public static readonly PokedexData Exeggutor = new()
    {
        number = 103,
        name = "Exeggutor",
        category = "Coconut",
        height = 200,
        weight = 120000,
        entry = ExeggutorDesc,
        forms = new[]
        {
            Species.Exeggutor,
            Species.ExeggutorAlola
        }
    };
    public static readonly PokedexData Cubone = new()
    {
        number = 104,
        name = "Cubone",
        category = "Lonely",
        height = 40,
        weight = 6500,
        entry = CuboneDesc,
        forms = SingleSpecies(Species.Cubone),
    };
    public static readonly PokedexData Marowak = new()
    {
        number = 105,
        name = "Marowak",
        category = "Bone Keeper",
        height = 100,
        weight = 45000,
        entry = MarowakDesc,
        forms = new[]
        {
            Species.Marowak,
            Species.MarowakAlola
        }
    };
    public static readonly PokedexData Hitmonlee = new()
    {
        number = 106,
        name = "Hitmonlee",
        category = "Kicking",
        height = 150,
        weight = 49800,
        entry = HitmonleeDesc,
        forms = SingleSpecies(Species.Hitmonlee),
    };
    public static readonly PokedexData Hitmonchan = new()
    {
        number = 107,
        name = "Hitmonchan",
        category = "Punching",
        height = 140,
        weight = 50200,
        entry = HitmonchanDesc,
        forms = SingleSpecies(Species.Hitmonchan),
    };
    public static readonly PokedexData Lickitung = new()
    {
        number = 108,
        name = "Lickitung",
        category = "Licking",
        height = 120,
        weight = 65500,
        entry = LickitungDesc,
        forms = SingleSpecies(Species.Lickitung),
    };
    public static readonly PokedexData Koffing = new()
    {
        number = 109,
        name = "Koffing",
        category = "PoisonGas",
        height = 60,
        weight = 1000,
        entry = KoffingDesc,
        forms = SingleSpecies(Species.Koffing),
    };
    public static readonly PokedexData Weezing = new()
    {
        number = 110,
        name = "Weezing",
        category = "PoisonGas",
        height = 120,
        weight = 9500,
        entry = WeezingDesc,
        forms = SingleSpecies(Species.Weezing),
    };
    public static readonly PokedexData Rhyhorn = new()
    {
        number = 111,
        name = "Rhyhorn",
        category = "Spikes",
        height = 100,
        weight = 115000,
        entry = RhyhornDesc,
        forms = SingleSpecies(Species.Rhyhorn),
    };
    public static readonly PokedexData Rhydon = new()
    {
        number = 112,
        name = "Rhydon",
        category = "Drill",
        height = 190,
        weight = 120000,
        entry = RhydonDesc,
        forms = SingleSpecies(Species.Rhydon),
    };
    public static readonly PokedexData Chansey = new()
    {
        number = 113,
        name = "Chansey",
        category = "Egg",
        height = 110,
        weight = 34600,
        entry = ChanseyDesc,
        forms = SingleSpecies(Species.Chansey),
    };
    public static readonly PokedexData Tangela = new()
    {
        number = 114,
        name = "Tangela",
        category = "Vine",
        height = 100,
        weight = 35000,
        entry = TangelaDesc,
        forms = SingleSpecies(Species.Tangela),
    };
    public static readonly PokedexData Kangaskhan = new()
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
    public static readonly PokedexData Horsea = new()
    {
        number = 116,
        name = "Horsea",
        category = "Dragon",
        height = 40,
        weight = 8000,
        entry = HorseaDesc,
        forms = SingleSpecies(Species.Horsea),
    };
    public static readonly PokedexData Seadra = new()
    {
        number = 117,
        name = "Seadra",
        category = "Dragon",
        height = 120,
        weight = 25000,
        entry = SeadraDesc,
        forms = SingleSpecies(Species.Seadra),
    };
    public static readonly PokedexData Goldeen = new()
    {
        number = 118,
        name = "Goldeen",
        category = "Goldfish",
        height = 60,
        weight = 15000,
        entry = GoldeenDesc,
        forms = SingleSpecies(Species.Goldeen),
    };
    public static readonly PokedexData Seaking = new()
    {
        number = 119,
        name = "Seaking",
        category = "Goldfish",
        height = 130,
        weight = 39000,
        entry = SeakingDesc,
        forms = SingleSpecies(Species.Seaking),
    };
    public static readonly PokedexData Staryu = new()
    {
        number = 120,
        name = "Staryu",
        category = "StarShape",
        height = 80,
        weight = 34500,
        entry = StaryuDesc,
        forms = SingleSpecies(Species.Staryu),
    };
    public static readonly PokedexData Starmie = new()
    {
        number = 121,
        name = "Starmie",
        category = "Mysterious",
        height = 110,
        weight = 80000,
        entry = StarmieDesc,
        forms = SingleSpecies(Species.Starmie),
    };
    public static readonly PokedexData MrMime = new()
    {
        number = 122,
        name = "Mr. Mime",
        category = "Barrier",
        height = 130,
        weight = 54500,
        entry = MrMimeDesc,
        forms = SingleSpecies(Species.MrMime),
    };
    public static readonly PokedexData Scyther = new()
    {
        number = 123,
        name = "Scyther",
        category = "Mantis",
        height = 150,
        weight = 56000,
        entry = ScytherDesc,
        forms = SingleSpecies(Species.Scyther),
    };
    public static readonly PokedexData Jynx = new()
    {
        number = 124,
        name = "Jynx",
        category = "HumanShape",
        height = 140,
        weight = 40600,
        entry = JynxDesc,
        forms = SingleSpecies(Species.Jynx),
    };
    public static readonly PokedexData Electabuzz = new()
    {
        number = 125,
        name = "Electabuzz",
        category = "Electric",
        height = 110,
        weight = 30000,
        entry = ElectabuzzDesc,
        forms = SingleSpecies(Species.Electabuzz),
    };
    public static readonly PokedexData Magmar = new()
    {
        number = 126,
        name = "Magmar",
        category = "Spitfire",
        height = 130,
        weight = 44500,
        entry = MagmarDesc,
        forms = SingleSpecies(Species.Magmar),
    };
    public static readonly PokedexData Pinsir = new()
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
    public static readonly PokedexData Tauros = new()
    {
        number = 128,
        name = "Tauros",
        category = "WildBull",
        height = 140,
        weight = 88400,
        entry = TaurosDesc,
        forms = SingleSpecies(Species.Tauros),
    };
    public static readonly PokedexData Magikarp = new()
    {
        number = 129,
        name = "Magikarp",
        category = "Fish",
        height = 90,
        weight = 10000,
        entry = MagikarpDesc,
        forms = SingleSpecies(Species.Magikarp),
    };
    public static readonly PokedexData Gyarados = new()
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
    public static readonly PokedexData Lapras = new()
    {
        number = 131,
        name = "Lapras",
        category = "Transport",
        height = 250,
        weight = 220000,
        entry = LaprasDesc,
        forms = SingleSpecies(Species.Lapras),
    };
    public static readonly PokedexData Ditto = new()
    {
        number = 132,
        name = "Ditto",
        category = "Transform",
        height = 30,
        weight = 4000,
        entry = DittoDesc,
        forms = SingleSpecies(Species.Ditto),
    };
    public static readonly PokedexData Eevee = new()
    {
        number = 133,
        name = "Eevee",
        category = "Evolution",
        height = 30,
        weight = 6500,
        entry = EeveeDesc,
        forms = new[]
        {
            Species.Eevee,
            Species.EeveePartner
        }
    };
    public static readonly PokedexData Vaporeon = new()
    {
        number = 134,
        name = "Vaporeon",
        category = "BubbleJet",
        height = 100,
        weight = 29000,
        entry = VaporeonDesc,
        forms = SingleSpecies(Species.Vaporeon),
    };
    public static readonly PokedexData Jolteon = new()
    {
        number = 135,
        name = "Jolteon",
        category = "Lightning",
        height = 80,
        weight = 24500,
        entry = JolteonDesc,
        forms = SingleSpecies(Species.Jolteon),
    };
    public static readonly PokedexData Flareon = new()
    {
        number = 136,
        name = "Flareon",
        category = "Flame",
        height = 90,
        weight = 25000,
        entry = FlareonDesc,
        forms = SingleSpecies(Species.Flareon),
    };
    public static readonly PokedexData Porygon = new()
    {
        number = 137,
        name = "Porygon",
        category = "Virtual",
        height = 80,
        weight = 36500,
        entry = PorygonDesc,
        forms = SingleSpecies(Species.Porygon),
    };
    public static readonly PokedexData Omanyte = new()
    {
        number = 138,
        name = "Omanyte",
        category = "Spiral",
        height = 40,
        weight = 7500,
        entry = OmanyteDesc,
        forms = SingleSpecies(Species.Omanyte),
    };
    public static readonly PokedexData Omastar = new()
    {
        number = 139,
        name = "Omastar",
        category = "Spiral",
        height = 100,
        weight = 35000,
        entry = OmastarDesc,
        forms = SingleSpecies(Species.Omastar),
    };
    public static readonly PokedexData Kabuto = new()
    {
        number = 140,
        name = "Kabuto",
        category = "Shellfish",
        height = 50,
        weight = 11500,
        entry = KabutoDesc,
        forms = SingleSpecies(Species.Kabuto),
    };
    public static readonly PokedexData Kabutops = new()
    {
        number = 141,
        name = "Kabutops",
        category = "Shellfish",
        height = 130,
        weight = 40500,
        entry = KabutopsDesc,
        forms = SingleSpecies(Species.Kabutops),
    };
    public static readonly PokedexData Aerodactyl = new()
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
    public static readonly PokedexData Snorlax = new()
    {
        number = 143,
        name = "Snorlax",
        category = "Sleeping",
        height = 210,
        weight = 460000,
        entry = SnorlaxDesc,
        forms = SingleSpecies(Species.Snorlax),
    };
    public static readonly PokedexData Articuno = new()
    {
        number = 144,
        name = "Articuno",
        category = "Freeze",
        height = 170,
        weight = 55400,
        entry = ArticunoDesc,
        forms = SingleSpecies(Species.Articuno),
    };
    public static readonly PokedexData Zapdos = new()
    {
        number = 145,
        name = "Zapdos",
        category = "Electric",
        height = 160,
        weight = 52600,
        entry = ZapdosDesc,
        forms = SingleSpecies(Species.Zapdos),
    };
    public static readonly PokedexData Moltres = new()
    {
        number = 146,
        name = "Moltres",
        category = "Flame",
        height = 200,
        weight = 60000,
        entry = MoltresDesc,
        forms = SingleSpecies(Species.Moltres),
    };
    public static readonly PokedexData Dratini = new()
    {
        number = 147,
        name = "Dratini",
        category = "Dragon",
        height = 180,
        weight = 3300,
        entry = DratiniDesc,
        forms = SingleSpecies(Species.Dratini),
    };
    public static readonly PokedexData Dragonair = new()
    {
        number = 148,
        name = "Dragonair",
        category = "Dragon",
        height = 400,
        weight = 16500,
        entry = DragonairDesc,
        forms = SingleSpecies(Species.Dragonair),
    };
    public static readonly PokedexData Dragonite = new()
    {
        number = 149,
        name = "Dragonite",
        category = "Dragon",
        height = 220,
        weight = 210000,
        entry = DragoniteDesc,
        forms = SingleSpecies(Species.Dragonite),
    };
    public static readonly PokedexData Mewtwo = new()
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
    public static readonly PokedexData Mew = new()
    {
        number = 151,
        name = "Mew",
        category = "New Species",
        height = 40,
        weight = 4000,
        entry = MewDesc,
        forms = SingleSpecies(Species.Mew),
    };
    public static readonly PokedexData Chikorita = new()
    {
        number = 152,
        name = "Chikorita",
        category = "Leaf",
        height = 90,
        weight = 6400,
        entry = ChikoritaDesc,
        forms = SingleSpecies(Species.Chikorita),
    };
    public static readonly PokedexData Bayleef = new()
    {
        number = 153,
        name = "Bayleef",
        category = "Leaf",
        height = 120,
        weight = 15800,
        entry = BayleefDesc,
        forms = SingleSpecies(Species.Bayleef),
    };
    public static readonly PokedexData Meganium = new()
    {
        number = 154,
        name = "Meganium",
        category = "Herb",
        height = 180,
        weight = 100500,
        entry = MeganiumDesc,
        forms = SingleSpecies(Species.Meganium),
    };
    public static readonly PokedexData Cyndaquil = new()
    {
        number = 155,
        name = "Cyndaquil",
        category = "Fire Mouse",
        height = 50,
        weight = 7900,
        entry = CyndaquilDesc,
        forms = SingleSpecies(Species.Cyndaquil),
    };
    public static readonly PokedexData Quilava = new()
    {
        number = 156,
        name = "Quilava",
        category = "Volcano",
        height = 90,
        weight = 19000,
        entry = QuilavaDesc,
        forms = SingleSpecies(Species.Quilava),
    };
    public static readonly PokedexData Typhlosion = new()
    {
        number = 157,
        name = "Typhlosion",
        category = "Volcano",
        height = 170,
        weight = 79500,
        entry = TyphlosionDesc,
        forms = SingleSpecies(Species.Typhlosion),
    };
    public static readonly PokedexData Totodile = new()
    {
        number = 158,
        name = "Totodile",
        category = "Big Jaw",
        height = 60,
        weight = 9500,
        entry = TotodileDesc,
        forms = SingleSpecies(Species.Totodile),
    };
    public static readonly PokedexData Croconaw = new()
    {
        number = 159,
        name = "Croconaw",
        category = "Big Jaw",
        height = 110,
        weight = 25000,
        entry = CroconawDesc,
        forms = SingleSpecies(Species.Croconaw),
    };
    public static readonly PokedexData Feraligatr = new()
    {
        number = 160,
        name = "Feraligatr",
        category = "Big Jaw",
        height = 230,
        weight = 88800,
        entry = FeraligatrDesc,
        forms = SingleSpecies(Species.Feraligatr),
    };
    public static readonly PokedexData Sentret = new()
    {
        number = 161,
        name = "Sentret",
        category = "Scout",
        height = 80,
        weight = 6000,
        entry = SentretDesc,
        forms = SingleSpecies(Species.Sentret),
    };
    public static readonly PokedexData Furret = new()
    {
        number = 162,
        name = "Furret",
        category = "Long Body",
        height = 180,
        weight = 32500,
        entry = FurretDesc,
        forms = SingleSpecies(Species.Furret),
    };
    public static readonly PokedexData Hoothoot = new()
    {
        number = 163,
        name = "Hoothoot",
        category = "Owl",
        height = 70,
        weight = 21200,
        entry = HoothootDesc,
        forms = SingleSpecies(Species.Hoothoot),
    };
    public static readonly PokedexData Noctowl = new()
    {
        number = 164,
        name = "Noctowl",
        category = "Owl",
        height = 160,
        weight = 40800,
        entry = NoctowlDesc,
        forms = SingleSpecies(Species.Noctowl),
    };
    public static readonly PokedexData Ledyba = new()
    {
        number = 165,
        name = "Ledyba",
        category = "Five Star",
        height = 100,
        weight = 10800,
        entry = LedybaDesc,
        forms = SingleSpecies(Species.Ledyba),
    };
    public static readonly PokedexData Ledian = new()
    {
        number = 166,
        name = "Ledian",
        category = "Five Star",
        height = 140,
        weight = 35600,
        entry = LedianDesc,
        forms = SingleSpecies(Species.Ledian),
    };
    public static readonly PokedexData Spinarak = new()
    {
        number = 167,
        name = "Spinarak",
        category = "String Spit",
        height = 50,
        weight = 8500,
        entry = SpinarakDesc,
        forms = SingleSpecies(Species.Spinarak),
    };
    public static readonly PokedexData Ariados = new()
    {
        number = 168,
        name = "Ariados",
        category = "Long Leg",
        height = 110,
        weight = 33500,
        entry = AriadosDesc,
        forms = SingleSpecies(Species.Ariados),
    };
    public static readonly PokedexData Crobat = new()
    {
        number = 169,
        name = "Crobat",
        category = "Bat",
        height = 180,
        weight = 75000,
        entry = CrobatDesc,
        forms = SingleSpecies(Species.Crobat),
    };
    public static readonly PokedexData Chinchou = new()
    {
        number = 170,
        name = "Chinchou",
        category = "Angler",
        height = 50,
        weight = 12000,
        entry = ChinchouDesc,
        forms = SingleSpecies(Species.Chinchou),
    };
    public static readonly PokedexData Lanturn = new()
    {
        number = 171,
        name = "Lanturn",
        category = "Light",
        height = 120,
        weight = 22500,
        entry = LanturnDesc,
        forms = SingleSpecies(Species.Lanturn),
    };
    public static readonly PokedexData Pichu = new()
    {
        number = 172,
        name = "Pichu",
        category = "Tiny Mouse",
        height = 30,
        weight = 2000,
        entry = PichuDesc,
        forms = new[]
        {
            Species.Pichu,
            Species.PichuSpikyEared
        }
    };
    public static readonly PokedexData Cleffa = new()
    {
        number = 173,
        name = "Cleffa",
        category = "Star Shape",
        height = 30,
        weight = 3000,
        entry = CleffaDesc,
        forms = SingleSpecies(Species.Cleffa),
    };
    public static readonly PokedexData Igglybuff = new()
    {
        number = 174,
        name = "Igglybuff",
        category = "Balloon",
        height = 30,
        weight = 1000,
        entry = IgglybuffDesc,
        forms = SingleSpecies(Species.Igglybuff),
    };
    public static readonly PokedexData Togepi = new()
    {
        number = 175,
        name = "Togepi",
        category = "Spike Ball",
        height = 30,
        weight = 1500,
        entry = TogepiDesc,
        forms = SingleSpecies(Species.Togepi),
    };
    public static readonly PokedexData Togetic = new()
    {
        number = 176,
        name = "Togetic",
        category = "Happiness",
        height = 60,
        weight = 3200,
        entry = TogeticDesc,
        forms = SingleSpecies(Species.Togetic),
    };
    public static readonly PokedexData Natu = new()
    {
        number = 177,
        name = "Natu",
        category = "Tiny Bird",
        height = 20,
        weight = 2000,
        entry = NatuDesc,
        forms = SingleSpecies(Species.Natu),
    };
    public static readonly PokedexData Xatu = new()
    {
        number = 178,
        name = "Xatu",
        category = "Mystic",
        height = 150,
        weight = 15000,
        entry = XatuDesc,
        forms = SingleSpecies(Species.Xatu),
    };
    public static readonly PokedexData Mareep = new()
    {
        number = 179,
        name = "Mareep",
        category = "Wool",
        height = 60,
        weight = 7800,
        entry = MareepDesc,
        forms = SingleSpecies(Species.Mareep),
    };
    public static readonly PokedexData Flaaffy = new()
    {
        number = 180,
        name = "Flaaffy",
        category = "Wool",
        height = 80,
        weight = 13300,
        entry = FlaaffyDesc,
        forms = SingleSpecies(Species.Flaaffy),
    };
    public static readonly PokedexData Ampharos = new()
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
    public static readonly PokedexData Bellossom = new()
    {
        number = 182,
        name = "Bellossom",
        category = "Flower",
        height = 40,
        weight = 5800,
        entry = BellossomDesc,
        forms = SingleSpecies(Species.Bellossom),
    };
    public static readonly PokedexData Marill = new()
    {
        number = 183,
        name = "Marill",
        category = "Aqua Mouse",
        height = 40,
        weight = 8500,
        entry = MarillDesc,
        forms = SingleSpecies(Species.Marill),
    };
    public static readonly PokedexData Azumarill = new()
    {
        number = 184,
        name = "Azumarill",
        category = "Aqua Rabbit",
        height = 80,
        weight = 28500,
        entry = AzumarillDesc,
        forms = SingleSpecies(Species.Azumarill),
    };
    public static readonly PokedexData Sudowoodo = new()
    {
        number = 185,
        name = "Sudowoodo",
        category = "Imitation",
        height = 120,
        weight = 38000,
        entry = SudowoodoDesc,
        forms = SingleSpecies(Species.Sudowoodo),
    };
    public static readonly PokedexData Politoed = new()
    {
        number = 186,
        name = "Politoed",
        category = "Frog",
        height = 110,
        weight = 33900,
        entry = PolitoedDesc,
        forms = SingleSpecies(Species.Politoed),
    };
    public static readonly PokedexData Hoppip = new()
    {
        number = 187,
        name = "Hoppip",
        category = "Cottonweed",
        height = 40,
        weight = 500,
        entry = HoppipDesc,
        forms = SingleSpecies(Species.Hoppip),
    };
    public static readonly PokedexData Skiploom = new()
    {
        number = 188,
        name = "Skiploom",
        category = "Cottonweed",
        height = 60,
        weight = 1000,
        entry = SkiploomDesc,
        forms = SingleSpecies(Species.Skiploom),
    };
    public static readonly PokedexData Jumpluff = new()
    {
        number = 189,
        name = "Jumpluff",
        category = "Cottonweed",
        height = 80,
        weight = 3000,
        entry = JumpluffDesc,
        forms = SingleSpecies(Species.Jumpluff),
    };
    public static readonly PokedexData Aipom = new()
    {
        number = 190,
        name = "Aipom",
        category = "Long Tail",
        height = 80,
        weight = 11500,
        entry = AipomDesc,
        forms = SingleSpecies(Species.Aipom),
    };
    public static readonly PokedexData Sunkern = new()
    {
        number = 191,
        name = "Sunkern",
        category = "Seed",
        height = 30,
        weight = 1800,
        entry = SunkernDesc,
        forms = SingleSpecies(Species.Sunkern),
    };
    public static readonly PokedexData Sunflora = new()
    {
        number = 192,
        name = "Sunflora",
        category = "Sun",
        height = 80,
        weight = 8500,
        entry = SunfloraDesc,
        forms = SingleSpecies(Species.Sunflora),
    };
    public static readonly PokedexData Yanma = new()
    {
        number = 193,
        name = "Yanma",
        category = "Clear Wing",
        height = 120,
        weight = 38000,
        entry = YanmaDesc,
        forms = SingleSpecies(Species.Yanma),
    };
    public static readonly PokedexData Wooper = new()
    {
        number = 194,
        name = "Wooper",
        category = "Water Fish",
        height = 40,
        weight = 8500,
        entry = WooperDesc,
        forms = SingleSpecies(Species.Wooper),
    };
    public static readonly PokedexData Quagsire = new()
    {
        number = 195,
        name = "Quagsire",
        category = "Water Fish",
        height = 140,
        weight = 75000,
        entry = QuagsireDesc,
        forms = SingleSpecies(Species.Quagsire),
    };
    public static readonly PokedexData Espeon = new()
    {
        number = 196,
        name = "Espeon",
        category = "Sun",
        height = 90,
        weight = 26500,
        entry = EspeonDesc,
        forms = SingleSpecies(Species.Espeon),
    };
    public static readonly PokedexData Umbreon = new()
    {
        number = 197,
        name = "Umbreon",
        category = "Moonlight",
        height = 100,
        weight = 27000,
        entry = UmbreonDesc,
        forms = SingleSpecies(Species.Umbreon),
    };
    public static readonly PokedexData Murkrow = new()
    {
        number = 198,
        name = "Murkrow",
        category = "Darkness",
        height = 50,
        weight = 2100,
        entry = MurkrowDesc,
        forms = SingleSpecies(Species.Murkrow),
    };
    public static readonly PokedexData Slowking = new()
    {
        number = 199,
        name = "Slowking",
        category = "Royal",
        height = 200,
        weight = 79500,
        entry = SlowkingDesc,
        forms = SingleSpecies(Species.Slowking),
    };
    public static readonly PokedexData Misdreavus = new()
    {
        number = 200,
        name = "Misdreavus",
        category = "Screech",
        height = 70,
        weight = 1000,
        entry = MisdreavusDesc,
        forms = SingleSpecies(Species.Misdreavus),
    };
    public static readonly PokedexData Unown = new()
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
    public static readonly PokedexData Wobbuffet = new()
    {
        number = 202,
        name = "Wobbuffet",
        category = "Patient",
        height = 130,
        weight = 28500,
        entry = WobbuffetDesc,
        forms = SingleSpecies(Species.Wobbuffet),
    };
    public static readonly PokedexData Girafarig = new()
    {
        number = 203,
        name = "Girafarig",
        category = "Long Neck",
        height = 150,
        weight = 41500,
        entry = GirafarigDesc,
        forms = SingleSpecies(Species.Girafarig),
    };
    public static readonly PokedexData Pineco = new()
    {
        number = 204,
        name = "Pineco",
        category = "Bagworm",
        height = 60,
        weight = 7200,
        entry = PinecoDesc,
        forms = SingleSpecies(Species.Pineco),
    };
    public static readonly PokedexData Forretress = new()
    {
        number = 205,
        name = "Forretress",
        category = "Bagworm",
        height = 120,
        weight = 125800,
        entry = ForretressDesc,
        forms = SingleSpecies(Species.Forretress),
    };
    public static readonly PokedexData Dunsparce = new()
    {
        number = 206,
        name = "Dunsparce",
        category = "Land Snake",
        height = 150,
        weight = 14000,
        entry = DunsparceDesc,
        forms = SingleSpecies(Species.Dunsparce),
    };
    public static readonly PokedexData Gligar = new()
    {
        number = 207,
        name = "Gligar",
        category = "Fly Scorpion",
        height = 110,
        weight = 64800,
        entry = GligarDesc,
        forms = SingleSpecies(Species.Gligar),
    };
    public static readonly PokedexData Steelix = new()
    {
        number = 208,
        name = "Steelix",
        category = "Iron Snake",
        height = 920,
        weight = 400000,
        entry = SteelixDesc,
        forms = new[]
        {
            Species.Steelix,
            Species.SteelixMega
        }
    };
    public static readonly PokedexData Snubbull = new()
    {
        number = 209,
        name = "Snubbull",
        category = "Fairy",
        height = 60,
        weight = 7800,
        entry = SnubbullDesc,
        forms = SingleSpecies(Species.Snubbull),
    };
    public static readonly PokedexData Granbull = new()
    {
        number = 210,
        name = "Granbull",
        category = "Fairy",
        height = 140,
        weight = 48700,
        entry = GranbullDesc,
        forms = SingleSpecies(Species.Granbull),
    };
    public static readonly PokedexData Qwilfish = new()
    {
        number = 211,
        name = "Qwilfish",
        category = "Balloon",
        height = 50,
        weight = 3900,
        entry = QwilfishDesc,
        forms = SingleSpecies(Species.Qwilfish),
    };
    public static readonly PokedexData Scizor = new()
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
    public static readonly PokedexData Shuckle = new()
    {
        number = 213,
        name = "Shuckle",
        category = "Mold",
        height = 60,
        weight = 20500,
        entry = ShuckleDesc,
        forms = SingleSpecies(Species.Shuckle),
    };
    public static readonly PokedexData Heracross = new()
    {
        number = 214,
        name = "Heracross",
        category = "Single Horn",
        height = 150,
        weight = 54000,
        entry = HeracrossDesc,
        forms = new[]
        {
            Species.Heracross,
            Species.HeracrossMega
        }
    };
    public static readonly PokedexData Sneasel = new()
    {
        number = 215,
        name = "Sneasel",
        category = "Sharp Claw",
        height = 90,
        weight = 28000,
        entry = SneaselDesc,
        forms = SingleSpecies(Species.Sneasel),
    };
    public static readonly PokedexData Teddiursa = new()
    {
        number = 216,
        name = "Teddiursa",
        category = "Little Bear",
        height = 60,
        weight = 8800,
        entry = TeddiursaDesc,
        forms = SingleSpecies(Species.Teddiursa),
    };
    public static readonly PokedexData Ursaring = new()
    {
        number = 217,
        name = "Ursaring",
        category = "Hibernator",
        height = 180,
        weight = 125800,
        entry = UrsaringDesc,
        forms = SingleSpecies(Species.Ursaring),
    };
    public static readonly PokedexData Slugma = new()
    {
        number = 218,
        name = "Slugma",
        category = "Lava",
        height = 70,
        weight = 35000,
        entry = SlugmaDesc,
        forms = SingleSpecies(Species.Slugma),
    };
    public static readonly PokedexData Magcargo = new()
    {
        number = 219,
        name = "Magcargo",
        category = "Lava",
        height = 80,
        weight = 55000,
        entry = MagcargoDesc,
        forms = SingleSpecies(Species.Magcargo),
    };
    public static readonly PokedexData Swinub = new()
    {
        number = 220,
        name = "Swinub",
        category = "Pig",
        height = 40,
        weight = 6500,
        entry = SwinubDesc,
        forms = SingleSpecies(Species.Swinub),
    };
    public static readonly PokedexData Piloswine = new()
    {
        number = 221,
        name = "Piloswine",
        category = "Swine",
        height = 110,
        weight = 55800,
        entry = PiloswineDesc,
        forms = SingleSpecies(Species.Piloswine),
    };
    public static readonly PokedexData Corsola = new()
    {
        number = 222,
        name = "Corsola",
        category = "Coral",
        height = 60,
        weight = 5000,
        entry = CorsolaDesc,
        forms = SingleSpecies(Species.Corsola),
    };
    public static readonly PokedexData Remoraid = new()
    {
        number = 223,
        name = "Remoraid",
        category = "Jet",
        height = 60,
        weight = 12000,
        entry = RemoraidDesc,
        forms = SingleSpecies(Species.Remoraid),
    };
    public static readonly PokedexData Octillery = new()
    {
        number = 224,
        name = "Octillery",
        category = "Jet",
        height = 90,
        weight = 28500,
        entry = OctilleryDesc,
        forms = SingleSpecies(Species.Octillery),
    };
    public static readonly PokedexData Delibird = new()
    {
        number = 225,
        name = "Delibird",
        category = "Delivery",
        height = 90,
        weight = 16000,
        entry = DelibirdDesc,
        forms = SingleSpecies(Species.Delibird),
    };
    public static readonly PokedexData Mantine = new()
    {
        number = 226,
        name = "Mantine",
        category = "Kite",
        height = 210,
        weight = 220000,
        entry = MantineDesc,
        forms = SingleSpecies(Species.Mantine),
    };
    public static readonly PokedexData Skarmory = new()
    {
        number = 227,
        name = "Skarmory",
        category = "Armor Bird",
        height = 170,
        weight = 50500,
        entry = SkarmoryDesc,
        forms = SingleSpecies(Species.Skarmory),
    };
    public static readonly PokedexData Houndour = new()
    {
        number = 228,
        name = "Houndour",
        category = "Dark",
        height = 60,
        weight = 10800,
        entry = HoundourDesc,
        forms = SingleSpecies(Species.Houndour),
    };
    public static readonly PokedexData Houndoom = new()
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
    public static readonly PokedexData Kingdra = new()
    {
        number = 230,
        name = "Kingdra",
        category = "Dragon",
        height = 180,
        weight = 152000,
        entry = KingdraDesc,
        forms = SingleSpecies(Species.Kingdra),
    };
    public static readonly PokedexData Phanpy = new()
    {
        number = 231,
        name = "Phanpy",
        category = "Long Nose",
        height = 50,
        weight = 33500,
        entry = PhanpyDesc,
        forms = SingleSpecies(Species.Phanpy),
    };
    public static readonly PokedexData Donphan = new()
    {
        number = 232,
        name = "Donphan",
        category = "Armor",
        height = 110,
        weight = 120000,
        entry = DonphanDesc,
        forms = SingleSpecies(Species.Donphan),
    };
    public static readonly PokedexData Porygon2 = new()
    {
        number = 233,
        name = "Porygon2",
        category = "Virtual",
        height = 60,
        weight = 32500,
        entry = Porygon2Desc,
        forms = SingleSpecies(Species.Porygon2),
    };
    public static readonly PokedexData Stantler = new()
    {
        number = 234,
        name = "Stantler",
        category = "Big Horn",
        height = 140, 
        weight = 71200,
        entry = StantlerDesc,
        forms = SingleSpecies(Species.Stantler),
    };
    public static readonly PokedexData Smeargle = new()
    {
        number = 235,
        name = "Smeargle",
        category = "Painter",
        height = 120,
        weight = 58000,
        entry = SmeargleDesc,
        forms = SingleSpecies(Species.Smeargle),
    };
    public static readonly PokedexData Tyrogue = new()
    {
        number = 236,
        name = "Tyrogue",
        category = "Scuffle",
        height = 70,
        weight = 21000,
        entry = TyrogueDesc,
        forms = SingleSpecies(Species.Tyrogue),
    };
    public static readonly PokedexData Hitmontop = new()
    {
        number = 237,
        name = "Hitmontop",
        category = "Handstand",
        height = 140,
        weight = 48000,
        entry = HitmontopDesc,
        forms = SingleSpecies(Species.Hitmontop),
    };
    public static readonly PokedexData Smoochum = new()
    {
        number = 238,
        name = "Smoochum",
        category = "Kiss",
        height = 40,
        weight = 6000,
        entry = SmoochumDesc,
        forms = SingleSpecies(Species.Smoochum),
    };
    public static readonly PokedexData Elekid = new()
    {
        number = 239,
        name = "Elekid",
        category = "Electric",
        height = 60,
        weight = 23500,
        entry = ElekidDesc,
        forms = SingleSpecies(Species.Elekid),
    };
    public static readonly PokedexData Magby = new()
    {
        number = 240,
        name = "Magby",
        category = "Live Coal",
        height = 70,
        weight = 21400,
        entry = MagbyDesc,
        forms = SingleSpecies(Species.Magby),
    };
    public static readonly PokedexData Miltank = new()
    {
        number = 241,
        name = "Miltank",
        category = "Milk Cow",
        height = 120,
        weight = 75500,
        entry = MiltankDesc,
        forms = SingleSpecies(Species.Miltank),
    };
    public static readonly PokedexData Blissey = new()
    {
        number = 242,
        name = "Blissey",
        category = "Happiness",
        height = 150,
        weight = 46800,
        entry = BlisseyDesc,
        forms = SingleSpecies(Species.Blissey),
    };
    public static readonly PokedexData Raikou = new()
    {
        number = 243,
        name = "Raikou",
        category = "Thunder",
        height = 190,
        weight = 178000,
        entry = RaikouDesc,
        forms = SingleSpecies(Species.Raikou),
    };
    public static readonly PokedexData Entei = new()
    {
        number = 244,
        name = "Entei",
        category = "Volcano",
        height = 210,
        weight = 198000,
        entry = EnteiDesc,
        forms = SingleSpecies(Species.Entei),
    };
    public static readonly PokedexData Suicune = new()
    {
        number = 245,
        name = "Suicune",
        category = "Aurora",
        height = 200,
        weight = 187000,
        entry = SuicuneDesc,
        forms = SingleSpecies(Species.Suicune),
    };
    public static readonly PokedexData Larvitar = new()
    {
        number = 246,
        name = "Larvitar",
        category = "Rock Skin",
        height = 60,
        weight = 72000,
        entry = LarvitarDesc,
        forms = SingleSpecies(Species.Larvitar),
    };
    public static readonly PokedexData Pupitar = new()
    {
        number = 247,
        name = "Pupitar",
        category = "Hard Shell",
        height = 120,
        weight = 152000,
        entry = PupitarDesc,
        forms = SingleSpecies(Species.Pupitar),
    };
    public static readonly PokedexData Tyranitar = new()
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
    public static readonly PokedexData Lugia = new()
    {
        number = 249,
        name = "Lugia",
        category = "Diving",
        height = 520,
        weight = 216000,
        entry = LugiaDesc,
        forms = SingleSpecies(Species.Lugia),
    };
    public static readonly PokedexData HoOh = new()
    {
        number = 250,
        name = "Ho Oh",
        category = "Rainbow",
        height = 380,
        weight = 199000,
        entry = HoOhDesc,
        forms = SingleSpecies(Species.HoOh),
    };
    public static readonly PokedexData Celebi = new()
    {
        number = 251,
        name = "Celebi",
        category = "Time Travel",
        height = 60,
        weight = 5000,
        entry = CelebiDesc,
        forms = SingleSpecies(Species.Celebi),
    };
    public static readonly PokedexData Treecko = new()
    {
        number = 252,
        name = "Treecko",
        category = "Wood Gecko",
        height = 50,
        weight = 5000,
        entry = TreeckoDesc,
        forms = SingleSpecies(Species.Treecko),
    };
    public static readonly PokedexData Grovyle = new()
    {
        number = 253,
        name = "Grovyle",
        category = "Wood Gecko",
        height = 90,
        weight = 21600,
        entry = GrovyleDesc,
        forms = SingleSpecies(Species.Grovyle),
    };
    public static readonly PokedexData Sceptile = new()
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
    public static readonly PokedexData Torchic = new()
    {
        number = 255,
        name = "Torchic",
        category = "Chick",
        height = 40,
        weight = 2500,
        entry = TorchicDesc,
        forms = SingleSpecies(Species.Torchic),
    };
    public static readonly PokedexData Combusken = new()
    {
        number = 256,
        name = "Combusken",
        category = "Young Fowl",
        height = 90,
        weight = 19500,
        entry = CombuskenDesc,
        forms = SingleSpecies(Species.Combusken),
    };
    public static readonly PokedexData Blaziken = new()
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
    public static readonly PokedexData Mudkip = new()
    {
        number = 258,
        name = "Mudkip",
        category = "Mud Fish",
        height = 40,
        weight = 7600,
        entry = MudkipDesc,
        forms = SingleSpecies(Species.Mudkip),
    };
    public static readonly PokedexData Marshtomp = new()
    {
        number = 259,
        name = "Marshtomp",
        category = "Mud Fish",
        height = 70,
        weight = 28000,
        entry = MarshtompDesc,
        forms = SingleSpecies(Species.Marshtomp),
    };
    public static readonly PokedexData Swampert = new()
    {
        number = 260,
        name = "Swampert",
        category = "Mud Fish",
        height = 150,
        weight = 81900,
        entry = SwampertDesc,
        forms = new[]
        {
            Species.Swampert,
            Species.SwampertMega
        }
    };
    public static readonly PokedexData Poochyena = new()
    {
        number = 261,
        name = "Poochyena",
        category = "Bite",
        height = 50,
        weight = 13600,
        entry = PoochyenaDesc,
        forms = SingleSpecies(Species.Poochyena),
    };
    public static readonly PokedexData Mightyena = new()
    {
        number = 262,
        name = "Mightyena",
        category = "Bite",
        height = 100,
        weight = 37000,
        entry = MightyenaDesc,
        forms = SingleSpecies(Species.Mightyena),
    };
    public static readonly PokedexData Zigzagoon = new()
    {
        number = 263,
        name = "Zigzagoon",
        category = "Tiny Raccoon",
        height = 40,
        weight = 17500,
        entry = ZigzagoonDesc,
        forms = SingleSpecies(Species.Zigzagoon),
    };
    public static readonly PokedexData Linoone = new()
    {
        number = 264,
        name = "Linoone",
        category = "Rushing",
        height = 50,
        weight = 32500,
        entry = LinooneDesc,
        forms = SingleSpecies(Species.Linoone),
    };
    public static readonly PokedexData Wurmple = new()
    {
        number = 265,
        name = "Wurmple",
        category = "Worm",
        height = 30,
        weight = 3600,
        entry = WurmpleDesc,
        forms = SingleSpecies(Species.Wurmple),
    };
    public static readonly PokedexData Silcoon = new()
    {
        number = 266,
        name = "Silcoon",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = SilcoonDesc,
        forms = SingleSpecies(Species.Silcoon),
    };
    public static readonly PokedexData Beautifly = new()
    {
        number = 267,
        name = "Beautifly",
        category = "Butterfly",
        height = 100,
        weight = 28400,
        entry = BeautiflyDesc,
        forms = SingleSpecies(Species.Beautifly),
    };
    public static readonly PokedexData Cascoon = new()
    {
        number = 268,
        name = "Cascoon",
        category = "Cocoon",
        height = 70,
        weight = 11500,
        entry = CascoonDesc,
        forms = SingleSpecies(Species.Cascoon),
    };
    public static readonly PokedexData Dustox = new()
    {
        number = 269,
        name = "Dustox",
        category = "Poison Moth",
        height = 120,
        weight = 31600,
        entry = DustoxDesc,
        forms = SingleSpecies(Species.Dustox),
    };
    public static readonly PokedexData Lotad = new()
    {
        number = 270,
        name = "Lotad",
        category = "WaterWeed",
        height = 50,
        weight = 2600,
        entry = LotadDesc,
        forms = SingleSpecies(Species.Lotad),
    };
    public static readonly PokedexData Lombre = new()
    {
        number = 271,
        name = "Lombre",
        category = "Jolly",
        height = 120,
        weight = 32500,
        entry = LombreDesc,
        forms = SingleSpecies(Species.Lombre),
    };
    public static readonly PokedexData Ludicolo = new()
    {
        number = 272,
        name = "Ludicolo",
        category = "Carefree",
        height = 150,
        weight = 55000,
        entry = LudicoloDesc,
        forms = SingleSpecies(Species.Ludicolo),
    };
    public static readonly PokedexData Seedot = new()
    {
        number = 273,
        name = "Seedot",
        category = "Acorn",
        height = 50,
        weight = 4000,
        entry = SeedotDesc,
        forms = SingleSpecies(Species.Seedot),
    };
    public static readonly PokedexData Nuzleaf = new()
    {
        number = 274,
        name = "Nuzleaf",
        category = "Wily",
        height = 100,
        weight = 28000,
        entry = NuzleafDesc,
        forms = SingleSpecies(Species.Nuzleaf),
    };
    public static readonly PokedexData Shiftry = new()
    {
        number = 275,
        name = "Shiftry",
        category = "Wicked",
        height = 130,
        weight = 59600,
        entry = ShiftryDesc,
        forms = SingleSpecies(Species.Shiftry),
    };
    public static readonly PokedexData Taillow = new()
    {
        number = 276,
        name = "Taillow",
        category = "Tiny Swallow",
        height = 30,
        weight = 2300,
        entry = TaillowDesc,
        forms = SingleSpecies(Species.Taillow),
    };
    public static readonly PokedexData Swellow = new()
    {
        number = 277,
        name = "Swellow",
        category = "Swallow",
        height = 70,
        weight = 19800,
        entry = SwellowDesc,
        forms = SingleSpecies(Species.Swellow),
    };
    public static readonly PokedexData Wingull = new()
    {
        number = 278,
        name = "Wingull",
        category = "Seagull",
        height = 60,
        weight = 9500,
        entry = WingullDesc,
        forms = SingleSpecies(Species.Wingull),
    };
    public static readonly PokedexData Pelipper = new()
    {
        number = 279,
        name = "Pelipper",
        category = "Water Bird",
        height = 120,
        weight = 28000,
        entry = PelipperDesc,
        forms = SingleSpecies(Species.Pelipper),
    };
    public static readonly PokedexData Ralts = new()
    {
        number = 280,
        name = "Ralts",
        category = "Feeling",
        height = 40,
        weight = 6600,
        entry = RaltsDesc,
        forms = SingleSpecies(Species.Ralts),
    };
    public static readonly PokedexData Kirlia = new()
    {
        number = 281,
        name = "Kirlia",
        category = "Emotion",
        height = 80,
        weight = 20200,
        entry = KirliaDesc,
        forms = SingleSpecies(Species.Kirlia),
    };
    public static readonly PokedexData Gardevoir = new()
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
    public static readonly PokedexData Surskit = new()
    {
        number = 283,
        name = "Surskit",
        category = "Pond Skater",
        height = 50,
        weight = 1700,
        entry = SurskitDesc,
        forms = SingleSpecies(Species.Surskit),
    };
    public static readonly PokedexData Masquerain = new()
    {
        number = 284,
        name = "Masquerain",
        category = "Eyeball",
        height = 80,
        weight = 3600,
        entry = MasquerainDesc,
        forms = SingleSpecies(Species.Masquerain),
    };
    public static readonly PokedexData Shroomish = new()
    {
        number = 285,
        name = "Shroomish",
        category = "Mushroom",
        height = 40,
        weight = 4500,
        entry = ShroomishDesc,
        forms = SingleSpecies(Species.Shroomish),
    };
    public static readonly PokedexData Breloom = new()
    {
        number = 286,
        name = "Breloom",
        category = "Mushroom",
        height = 120,
        weight = 39200,
        entry = BreloomDesc,
        forms = SingleSpecies(Species.Breloom),
    };
    public static readonly PokedexData Slakoth = new()
    {
        number = 287,
        name = "Slakoth",
        category = "Slacker",
        height = 80,
        weight = 24000,
        entry = SlakothDesc,
        forms = SingleSpecies(Species.Slakoth),
    };
    public static readonly PokedexData Vigoroth = new()
    {
        number = 288,
        name = "Vigoroth",
        category = "Wild Monkey",
        height = 140,
        weight = 46500,
        entry = VigorothDesc,
        forms = SingleSpecies(Species.Vigoroth),
    };
    public static readonly PokedexData Slaking = new()
    {
        number = 289,
        name = "Slaking",
        category = "Lazy",
        height = 200,
        weight = 130500,
        entry = SlakingDesc,
        forms = SingleSpecies(Species.Slaking),
    };
    public static readonly PokedexData Nincada = new()
    {
        number = 290,
        name = "Nincada",
        category = "Trainee",
        height = 50,
        weight = 5500,
        entry = NincadaDesc,
        forms = SingleSpecies(Species.Nincada),
    };
    public static readonly PokedexData Ninjask = new()
    {
        number = 291,
        name = "Ninjask",
        category = "Ninja",
        height = 80,
        weight = 12000,
        entry = NinjaskDesc,
        forms = SingleSpecies(Species.Ninjask),
    };
    public static readonly PokedexData Shedinja = new()
    {
        number = 292,
        name = "Shedinja",
        category = "Shed",
        height = 80,
        weight = 1200,
        entry = ShedinjaDesc,
        forms = SingleSpecies(Species.Shedinja),
    };
    public static readonly PokedexData Whismur = new()
    {
        number = 293,
        name = "Whismur",
        category = "Whisper",
        height = 60,
        weight = 16300,
        entry = WhismurDesc,
        forms = SingleSpecies(Species.Whismur),
    };
    public static readonly PokedexData Loudred = new()
    {
        number = 294,
        name = "Loudred",
        category = "Big Voice",
        height = 100,
        weight = 40500,
        entry = LoudredDesc,
        forms = SingleSpecies(Species.Loudred),
    };
    public static readonly PokedexData Exploud = new()
    {
        number = 295,
        name = "Exploud",
        category = "Loud Noise",
        height = 150,
        weight = 84000,
        entry = ExploudDesc,
        forms = SingleSpecies(Species.Exploud),
    };
    public static readonly PokedexData Makuhita = new()
    {
        number = 296,
        name = "Makuhita",
        category = "Guts",
        height = 100,
        weight = 86400,
        entry = MakuhitaDesc,
        forms = SingleSpecies(Species.Makuhita),
    };
    public static readonly PokedexData Hariyama = new()
    {
        number = 297,
        name = "Hariyama",
        category = "Arm Thrust",
        height = 230,
        weight = 253800,
        entry = HariyamaDesc,
        forms = SingleSpecies(Species.Hariyama),
    };
    public static readonly PokedexData Azurill = new()
    {
        number = 298,
        name = "Azurill",
        category = "Polka Dot",
        height = 20,
        weight = 2000,
        entry = AzurillDesc,
        forms = SingleSpecies(Species.Azurill),
    };
    public static readonly PokedexData Nosepass = new()
    {
        number = 299,
        name = "Nosepass",
        category = "Compass",
        height = 100,
        weight = 97000,
        entry = NosepassDesc,
        forms = SingleSpecies(Species.Nosepass),
    };
    public static readonly PokedexData Skitty = new()
    {
        number = 300,
        name = "Skitty",
        category = "Kitten",
        height = 60,
        weight = 11000,
        entry = SkittyDesc,
        forms = SingleSpecies(Species.Skitty),
    };
    public static readonly PokedexData Delcatty = new()
    {
        number = 301,
        name = "Delcatty",
        category = "Prim",
        height = 110,
        weight = 32600,
        entry = DelcattyDesc,
        forms = SingleSpecies(Species.Delcatty),
    };
    public static readonly PokedexData Sableye = new()
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
    public static readonly PokedexData Mawile = new()
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
    public static readonly PokedexData Aron = new()
    {
        number = 304,
        name = "Aron",
        category = "Iron Armor",
        height = 40,
        weight = 60000,
        entry = AronDesc,
        forms = SingleSpecies(Species.Aron),
    };
    public static readonly PokedexData Lairon = new()
    {
        number = 305,
        name = "Lairon",
        category = "Iron Armor",
        height = 90,
        weight = 120000,
        entry = LaironDesc,
        forms = SingleSpecies(Species.Lairon),
    };
    public static readonly PokedexData Aggron = new()
    {
        number = 306,
        name = "Aggron",
        category = "Iron Armor",
        height = 210,
        weight = 360000,
        entry = AggronDesc,
        forms = new[]
        {
            Species.Aggron,
            Species.AggronMega
        }
    };
    public static readonly PokedexData Meditite = new()
    {
        number = 307,
        name = "Meditite",
        category = "Meditate",
        height = 60,
        weight = 11200,
        entry = MedititeDesc,
        forms = SingleSpecies(Species.Meditite),
    };
    public static readonly PokedexData Medicham = new()
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
    public static readonly PokedexData Electrike = new()
    {
        number = 309,
        name = "Electrike",
        category = "Lightning",
        height = 60,
        weight = 15200,
        entry = ElectrikeDesc,
        forms = SingleSpecies(Species.Electrike),
    };
    public static readonly PokedexData Manectric = new()
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
    public static readonly PokedexData Plusle = new()
    {
        number = 311,
        name = "Plusle",
        category = "Cheering",
        height = 40,
        weight = 4200,
        entry = PlusleDesc,
        forms = SingleSpecies(Species.Plusle),
    };
    public static readonly PokedexData Minun = new()
    {
        number = 312,
        name = "Minun",
        category = "Cheering",
        height = 40,
        weight = 4200,
        entry = MinunDesc,
        forms = SingleSpecies(Species.Minun),
    };
    public static readonly PokedexData Volbeat = new()
    {
        number = 313,
        name = "Volbeat",
        category = "Firefly",
        height = 70,
        weight = 17700,
        entry = VolbeatDesc,
        forms = SingleSpecies(Species.Volbeat),
    };
    public static readonly PokedexData Illumise = new()
    {
        number = 314,
        name = "Illumise",
        category = "Firefly",
        height = 60,
        weight = 17700,
        entry = IllumiseDesc,
        forms = SingleSpecies(Species.Illumise),
    };
    public static readonly PokedexData Roselia = new()
    {
        number = 315,
        name = "Roselia",
        category = "Thorn",
        height = 30,
        weight = 2000,
        entry = RoseliaDesc,
        forms = SingleSpecies(Species.Roselia),
    };
    public static readonly PokedexData Gulpin = new()
    {
        number = 316,
        name = "Gulpin",
        category = "Stomach",
        height = 40,
        weight = 10300,
        entry = GulpinDesc,
        forms = SingleSpecies(Species.Gulpin),
    };
    public static readonly PokedexData Swalot = new()
    {
        number = 317,
        name = "Swalot",
        category = "Poison Bag",
        height = 170,
        weight = 80000,
        entry = SwalotDesc,
        forms = SingleSpecies(Species.Swalot),
    };
    public static readonly PokedexData Carvanha = new()
    {
        number = 318,
        name = "Carvanha",
        category = "Savage",
        height = 80,
        weight = 20800,
        entry = CarvanhaDesc,
        forms = SingleSpecies(Species.Carvanha),
    };
    public static readonly PokedexData Sharpedo = new()
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
    public static readonly PokedexData Wailmer = new()
    {
        number = 320,
        name = "Wailmer",
        category = "Ball Whale",
        height = 200,
        weight = 130000,
        entry = WailmerDesc,
        forms = SingleSpecies(Species.Wailmer),
    };
    public static readonly PokedexData Wailord = new()
    {
        number = 321,
        name = "Wailord",
        category = "Float Whale",
        height = 1450,
        weight = 398000,
        entry = WailordDesc,
        forms = SingleSpecies(Species.Wailord),
    };
    public static readonly PokedexData Numel = new()
    {
        number = 322,
        name = "Numel",
        category = "Numb",
        height = 70,
        weight = 24000,
        entry = NumelDesc,
        forms = SingleSpecies(Species.Numel),
    };
    public static readonly PokedexData Camerupt = new()
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
    public static readonly PokedexData Torkoal = new()
    {
        number = 324,
        name = "Torkoal",
        category = "Coal",
        height = 50,
        weight = 80400,
        entry = TorkoalDesc,
        forms = SingleSpecies(Species.Torkoal),
    };
    public static readonly PokedexData Spoink = new()
    {
        number = 325,
        name = "Spoink",
        category = "Bounce",
        height = 70,
        weight = 30600,
        entry = SpoinkDesc,
        forms = SingleSpecies(Species.Spoink),
    };
    public static readonly PokedexData Grumpig = new()
    {
        number = 326,
        name = "Grumpig",
        category = "Manipulate",
        height = 90,
        weight = 71500,
        entry = GrumpigDesc,
        forms = SingleSpecies(Species.Grumpig),
    };
    public static readonly PokedexData Spinda = new()
    {
        number = 327,
        name = "Spinda",
        category = "Spot Panda",
        height = 110,
        weight = 5000,
        entry = SpindaDesc,
        forms = SingleSpecies(Species.Spinda),
    };
    public static readonly PokedexData Trapinch = new()
    {
        number = 328,
        name = "Trapinch",
        category = "Ant Pit",
        height = 70,
        weight = 15000,
        entry = TrapinchDesc,
        forms = SingleSpecies(Species.Trapinch),
    };
    public static readonly PokedexData Vibrava = new()
    {
        number = 329,
        name = "Vibrava",
        category = "Vibration",
        height = 110,
        weight = 15300,
        entry = VibravaDesc,
        forms = SingleSpecies(Species.Vibrava),
    };
    public static readonly PokedexData Flygon = new()
    {
        number = 330,
        name = "Flygon",
        category = "Mystic",
        height = 200,
        weight = 82000,
        entry = FlygonDesc,
        forms = SingleSpecies(Species.Flygon),
    };
    public static readonly PokedexData Cacnea = new()
    {
        number = 331,
        name = "Cacnea",
        category = "Cactus",
        height = 40,
        weight = 51300,
        entry = CacneaDesc,
        forms = SingleSpecies(Species.Cacnea),
    };
    public static readonly PokedexData Cacturne = new()
    {
        number = 332,
        name = "Cacturne",
        category = "Scarecrow",
        height = 130,
        weight = 77400,
        entry = CacturneDesc,
        forms = SingleSpecies(Species.Cacturne),
    };
    public static readonly PokedexData Swablu = new()
    {
        number = 333,
        name = "Swablu",
        category = "Cotton Bird",
        height = 40,
        weight = 1200,
        entry = SwabluDesc,
        forms = SingleSpecies(Species.Swablu),
    };
    public static readonly PokedexData Altaria = new()
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
    public static readonly PokedexData Zangoose = new()
    {
        number = 335,
        name = "Zangoose",
        category = "Cat Ferret",
        height = 130,
        weight = 40300,
        entry = ZangooseDesc,
        forms = SingleSpecies(Species.Zangoose),
    };
    public static readonly PokedexData Seviper = new()
    {
        number = 336,
        name = "Seviper",
        category = "Fang Snake",
        height = 270,
        weight = 52500,
        entry = SeviperDesc,
        forms = SingleSpecies(Species.Seviper),
    };
    public static readonly PokedexData Lunatone = new()
    {
        number = 337,
        name = "Lunatone",
        category = "Meteorite",
        height = 100,
        weight = 168000,
        entry = LunatoneDesc,
        forms = SingleSpecies(Species.Lunatone),
    };
    public static readonly PokedexData Solrock = new()
    {
        number = 338,
        name = "Solrock",
        category = "Meteorite",
        height = 120,
        weight = 154000,
        entry = SolrockDesc,
        forms = SingleSpecies(Species.Solrock),
    };
    public static readonly PokedexData Barboach = new()
    {
        number = 339,
        name = "Barboach",
        category = "Whiskers",
        height = 40,
        weight = 1900,
        entry = BarboachDesc,
        forms = SingleSpecies(Species.Barboach),
    };
    public static readonly PokedexData Whiscash = new()
    {
        number = 340,
        name = "Whiscash",
        category = "Whiskers",
        height = 90,
        weight = 23600,
        entry = WhiscashDesc,
        forms = SingleSpecies(Species.Whiscash),
    };
    public static readonly PokedexData Corphish = new()
    {
        number = 341,
        name = "Corphish",
        category = "Ruffian",
        height = 60,
        weight = 11500,
        entry = CorphishDesc,
        forms = SingleSpecies(Species.Corphish),
    };
    public static readonly PokedexData Crawdaunt = new()
    {
        number = 342,
        name = "Crawdaunt",
        category = "Rogue",
        height = 110,
        weight = 32800,
        entry = CrawdauntDesc,
        forms = SingleSpecies(Species.Crawdaunt),
    };
    public static readonly PokedexData Baltoy = new()
    {
        number = 343,
        name = "Baltoy",
        category = "Clay Doll",
        height = 50,
        weight = 21500,
        entry = BaltoyDesc,
        forms = SingleSpecies(Species.Baltoy),
    };
    public static readonly PokedexData Claydol = new()
    {
        number = 344,
        name = "Claydol",
        category = "Clay Doll",
        height = 150,
        weight = 108000,
        entry = ClaydolDesc,
        forms = SingleSpecies(Species.Claydol),
    };
    public static readonly PokedexData Lileep = new()
    {
        number = 345,
        name = "Lileep",
        category = "Sea Lily",
        height = 100,
        weight = 23800,
        entry = LileepDesc,
        forms = SingleSpecies(Species.Lileep),
    };
    public static readonly PokedexData Cradily = new()
    {
        number = 346,
        name = "Cradily",
        category = "Barnacle",
        height = 150,
        weight = 60400,
        entry = CradilyDesc,
        forms = SingleSpecies(Species.Cradily),
    };
    public static readonly PokedexData Anorith = new()
    {
        number = 347,
        name = "Anorith",
        category = "Old Shrimp",
        height = 70,
        weight = 12500,
        entry = AnorithDesc,
        forms = SingleSpecies(Species.Anorith),
    };
    public static readonly PokedexData Armaldo = new()
    {
        number = 348,
        name = "Armaldo",
        category = "Plate",
        height = 150,
        weight = 68200,
        entry = ArmaldoDesc,
        forms = SingleSpecies(Species.Armaldo),
    };
    public static readonly PokedexData Feebas = new()
    {
        number = 349,
        name = "Feebas",
        category = "Fish",
        height = 60,
        weight = 7400,
        entry = FeebasDesc,
        forms = SingleSpecies(Species.Feebas),
    };
    public static readonly PokedexData Milotic = new()
    {
        number = 350,
        name = "Milotic",
        category = "Tender",
        height = 620,
        weight = 162000,
        entry = MiloticDesc,
        forms = SingleSpecies(Species.Milotic),
    };
    public static readonly PokedexData Castform = new()
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
    public static readonly PokedexData Kecleon = new()
    {
        number = 352,
        name = "Kecleon",
        category = "Color Swap",
        height = 100,
        weight = 22000,
        entry = KecleonDesc,
        forms = SingleSpecies(Species.Kecleon),
    };
    public static readonly PokedexData Shuppet = new()
    {
        number = 353,
        name = "Shuppet",
        category = "Puppet",
        height = 60,
        weight = 2300,
        entry = ShuppetDesc,
        forms = SingleSpecies(Species.Shuppet),
    };
    public static readonly PokedexData Banette = new()
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
    public static readonly PokedexData Duskull = new()
    {
        number = 355,
        name = "Duskull",
        category = "Requiem",
        height = 80,
        weight = 15000,
        entry = DuskullDesc,
        forms = SingleSpecies(Species.Duskull),
    };
    public static readonly PokedexData Dusclops = new()
    {
        number = 356,
        name = "Dusclops",
        category = "Beckon",
        height = 160,
        weight = 30600,
        entry = DusclopsDesc,
        forms = SingleSpecies(Species.Dusclops),
    };
    public static readonly PokedexData Tropius = new()
    {
        number = 357,
        name = "Tropius",
        category = "Fruit",
        height = 200,
        weight = 100000,
        entry = TropiusDesc,
        forms = SingleSpecies(Species.Tropius),
    };
    public static readonly PokedexData Chimecho = new()
    {
        number = 358,
        name = "Chimecho",
        category = "Wind Chime",
        height = 60,
        weight = 1000,
        entry = ChimechoDesc,
        forms = SingleSpecies(Species.Chimecho),
    };
    public static readonly PokedexData Absol = new()
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
    public static readonly PokedexData Wynaut = new()
    {
        number = 360,
        name = "Wynaut",
        category = "Bright",
        height = 60,
        weight = 14000,
        entry = WynautDesc,
        forms = SingleSpecies(Species.Wynaut),
    };
    public static readonly PokedexData Snorunt = new()
    {
        number = 361,
        name = "Snorunt",
        category = "Snow Hat",
        height = 70,
        weight = 16800,
        entry = SnoruntDesc,
        forms = SingleSpecies(Species.Snorunt),
    };
    public static readonly PokedexData Glalie = new()
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
    public static readonly PokedexData Spheal = new()
    {
        number = 363,
        name = "Spheal",
        category = "Clap",
        height = 80,
        weight = 39500,
        entry = SphealDesc,
        forms = SingleSpecies(Species.Spheal),
    };
    public static readonly PokedexData Sealeo = new()
    {
        number = 364,
        name = "Sealeo",
        category = "Ball Roll",
        height = 110,
        weight = 87600,
        entry = SealeoDesc,
        forms = SingleSpecies(Species.Sealeo),
    };
    public static readonly PokedexData Walrein = new()
    {
        number = 365,
        name = "Walrein",
        category = "Ice Break",
        height = 140,
        weight = 150600,
        entry = WalreinDesc,
        forms = SingleSpecies(Species.Walrein),
    };
    public static readonly PokedexData Clamperl = new()
    {
        number = 366,
        name = "Clamperl",
        category = "Bivalve",
        height = 40,
        weight = 52500,
        entry = ClamperlDesc,
        forms = SingleSpecies(Species.Clamperl),
    };
    public static readonly PokedexData Huntail = new()
    {
        number = 367,
        name = "Huntail",
        category = "Deep Sea",
        height = 170,
        weight = 27000,
        entry = HuntailDesc,
        forms = SingleSpecies(Species.Huntail),
    };
    public static readonly PokedexData Gorebyss = new()
    {
        number = 368,
        name = "Gorebyss",
        category = "South Sea",
        height = 180,
        weight = 22600,
        entry = GorebyssDesc,
        forms = SingleSpecies(Species.Gorebyss),
    };
    public static readonly PokedexData Relicanth = new()
    {
        number = 369,
        name = "Relicanth",
        category = "Longevity",
        height = 100,
        weight = 23400,
        entry = RelicanthDesc,
        forms = SingleSpecies(Species.Relicanth),
    };
    public static readonly PokedexData Luvdisc = new()
    {
        number = 370,
        name = "Luvdisc",
        category = "Rendezvous",
        height = 60,
        weight = 8700,
        entry = LuvdiscDesc,
        forms = SingleSpecies(Species.Luvdisc),
    };
    public static readonly PokedexData Bagon = new()
    {
        number = 371,
        name = "Bagon",
        category = "Rock Head",
        height = 60,
        weight = 42100,
        entry = BagonDesc,
        forms = SingleSpecies(Species.Bagon),
    };
    public static readonly PokedexData Shelgon = new()
    {
        number = 372,
        name = "Shelgon",
        category = "Endurance",
        height = 110,
        weight = 110500,
        entry = ShelgonDesc,
        forms = SingleSpecies(Species.Shelgon),
    };
    public static readonly PokedexData Salamence = new()
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
    public static readonly PokedexData Beldum = new()
    {
        number = 374,
        name = "Beldum",
        category = "Iron Ball",
        height = 60,
        weight = 95200,
        entry = BeldumDesc,
        forms = SingleSpecies(Species.Beldum),
    };
    public static readonly PokedexData Metang = new()
    {
        number = 375,
        name = "Metang",
        category = "Iron Claw",
        height = 120,
        weight = 202500,
        entry = MetangDesc,
        forms = SingleSpecies(Species.Metang),
    };
    public static readonly PokedexData Metagross = new()
    {
        number = 376,
        name = "Metagross",
        category = "Iron Leg",
        height = 160,
        weight = 550000,
        entry = MetagrossDesc,
        forms = new[]
        {
            Species.Metagross,
            Species.MetagrossMega
        }
    };
    public static readonly PokedexData Regirock = new()
    {
        number = 377,
        name = "Regirock",
        category = "Rock Peak",
        height = 170,
        weight = 230000,
        entry = RegirockDesc,
        forms = SingleSpecies(Species.Regirock),
    };
    public static readonly PokedexData Regice = new()
    {
        number = 378,
        name = "Regice",
        category = "Iceberg",
        height = 180,
        weight = 175000,
        entry = RegiceDesc,
        forms = SingleSpecies(Species.Regice),
    };
    public static readonly PokedexData Registeel = new()
    {
        number = 379,
        name = "Registeel",
        category = "Iron",
        height = 190,
        weight = 205000,
        entry = RegisteelDesc,
        forms = SingleSpecies(Species.Registeel),
    };
    public static readonly PokedexData Latias = new()
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
    public static readonly PokedexData Latios = new()
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
    public static readonly PokedexData Kyogre = new()
    {
        number = 382,
        name = "Kyogre",
        category = "Sea Basin",
        height = 450,
        weight = 352000,
        entry = KyogreDesc,
        forms = SingleSpecies(Species.Kyogre),
    };
    public static readonly PokedexData Groudon = new()
    {
        number = 383,
        name = "Groudon",
        category = "Continent",
        height = 350,
        weight = 950000,
        entry = GroudonDesc,
        forms = SingleSpecies(Species.Groudon),
    };
    public static readonly PokedexData Rayquaza = new()
    {
        number = 384,
        name = "Rayquaza",
        category = "Sky High",
        height = 700,
        weight = 206500,
        entry = RayquazaDesc,
        forms = new[]
        {
            Species.Rayquaza,
            Species.RayquazaMega
        }
    };
    public static readonly PokedexData Jirachi = new()
    {
        number = 385,
        name = "Jirachi",
        category = "Wish",
        height = 30,
        weight = 1100,
        entry = JirachiDesc,
        forms = SingleSpecies(Species.Jirachi),
    };
    public static readonly PokedexData Deoxys = new()
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
    public static readonly PokedexData Turtwig = new()
    {
        number = 387,
        name = "Turtwig",
        category = "Tiny Leaf",
        height = 40,
        weight = 10200,
        entry = TurtwigDesc,
        forms = SingleSpecies(Species.Turtwig),
    };
    public static readonly PokedexData Grotle = new()
    {
        number = 388,
        name = "Grotle",
        category = "Grove",
        height = 110,
        weight = 97000,
        entry = GrotleDesc,
        forms = SingleSpecies(Species.Grotle),
    };
    public static readonly PokedexData Torterra = new()
    {
        number = 389,
        name = "Torterra",
        category = "Continent",
        height = 220,
        weight = 310000,
        entry = TorterraDesc,
        forms = SingleSpecies(Species.Torterra),
    };
    public static readonly PokedexData Chimchar = new()
    {
        number = 390,
        name = "Chimchar",
        category = "Chimp",
        height = 50,
        weight = 6200,
        entry = ChimcharDesc,
        forms = SingleSpecies(Species.Chimchar),
    };
    public static readonly PokedexData Monferno = new()
    {
        number = 391,
        name = "Monferno",
        category = "Playful",
        height = 90,
        weight = 22000,
        entry = MonfernoDesc,
        forms = SingleSpecies(Species.Monferno),
    };
    public static readonly PokedexData Infernape = new()
    {
        number = 392,
        name = "Infernape",
        category = "Flame",
        height = 120,
        weight = 55000,
        entry = InfernapeDesc,
        forms = SingleSpecies(Species.Infernape),
    };
    public static readonly PokedexData Piplup = new()
    {
        number = 393,
        name = "Piplup",
        category = "Penguin",
        height = 40,
        weight = 5200,
        entry = PiplupDesc,
        forms = SingleSpecies(Species.Piplup),
    };
    public static readonly PokedexData Prinplup = new()
    {
        number = 394,
        name = "Prinplup",
        category = "Penguin",
        height = 80,
        weight = 23000,
        entry = PrinplupDesc,
        forms = SingleSpecies(Species.Prinplup),
    };
    public static readonly PokedexData Empoleon = new()
    {
        number = 395,
        name = "Empoleon",
        category = "Emperor",
        height = 170,
        weight = 84500,
        entry = EmpoleonDesc,
        forms = SingleSpecies(Species.Empoleon),
    };
    public static readonly PokedexData Starly = new()
    {
        number = 396,
        name = "Starly",
        category = "Starling",
        height = 30,
        weight = 2000,
        entry = StarlyDesc,
        forms = SingleSpecies(Species.Starly),
    };
    public static readonly PokedexData Staravia = new()
    {
        number = 397,
        name = "Staravia",
        category = "Starling",
        height = 60,
        weight = 15500,
        entry = StaraviaDesc,
        forms = SingleSpecies(Species.Staravia),
    };
    public static readonly PokedexData Staraptor = new()
    {
        number = 398,
        name = "Staraptor",
        category = "Predator",
        height = 120,
        weight = 24900,
        entry = StaraptorDesc,
        forms = SingleSpecies(Species.Staraptor),
    };
    public static readonly PokedexData Bidoof = new()
    {
        number = 399,
        name = "Bidoof",
        category = "Plump Mouse",
        height = 50,
        weight = 20000,
        entry = BidoofDesc,
        forms = SingleSpecies(Species.Bidoof),
    };
    public static readonly PokedexData Bibarel = new()
    {
        number = 400,
        name = "Bibarel",
        category = "Beaver",
        height = 100,
        weight = 31500,
        entry = BibarelDesc,
        forms = SingleSpecies(Species.Bibarel),
    };
    public static readonly PokedexData Kricketot = new()
    {
        number = 401,
        name = "Kricketot",
        category = "Cricket",
        height = 30,
        weight = 2200,
        entry = KricketotDesc,
        forms = SingleSpecies(Species.Kricketot),
    };
    public static readonly PokedexData Kricketune = new()
    {
        number = 402,
        name = "Kricketune",
        category = "Cricket",
        height = 100,
        weight = 25500,
        entry = KricketuneDesc,
        forms = SingleSpecies(Species.Kricketune),
    };
    public static readonly PokedexData Shinx = new()
    {
        number = 403,
        name = "Shinx",
        category = "Flash",
        height = 50,
        weight = 9500,
        entry = ShinxDesc,
        forms = SingleSpecies(Species.Shinx),
    };
    public static readonly PokedexData Luxio = new()
    {
        number = 404,
        name = "Luxio",
        category = "Spark",
        height = 90,
        weight = 30500,
        entry = LuxioDesc,
        forms = SingleSpecies(Species.Luxio),
    };
    public static readonly PokedexData Luxray = new()
    {
        number = 405,
        name = "Luxray",
        category = "Gleam Eyes",
        height = 140,
        weight = 42000,
        entry = LuxrayDesc,
        forms = SingleSpecies(Species.Luxray),
    };
    public static readonly PokedexData Budew = new()
    {
        number = 406,
        name = "Budew",
        category = "Bud",
        height = 20,
        weight = 1200,
        entry = BudewDesc,
        forms = SingleSpecies(Species.Budew),
    };
    public static readonly PokedexData Roserade = new()
    {
        number = 407,
        name = "Roserade",
        category = "Bouquet",
        height = 90,
        weight = 14500,
        entry = RoseradeDesc,
        forms = SingleSpecies(Species.Roserade),
    };
    public static readonly PokedexData Cranidos = new()
    {
        number = 408,
        name = "Cranidos",
        category = "Head Butt",
        height = 90,
        weight = 31500,
        entry = CranidosDesc,
        forms = SingleSpecies(Species.Cranidos),
    };
    public static readonly PokedexData Rampardos = new()
    {
        number = 409,
        name = "Rampardos",
        category = "Head Butt",
        height = 160,
        weight = 102500,
        entry = RampardosDesc,
        forms = SingleSpecies(Species.Rampardos),
    };
    public static readonly PokedexData Shieldon = new()
    {
        number = 410,
        name = "Shieldon",
        category = "Shield",
        height = 50,
        weight = 57000,
        entry = ShieldonDesc,
        forms = SingleSpecies(Species.Shieldon),
    };
    public static readonly PokedexData Bastiodon = new()
    {
        number = 411,
        name = "Bastiodon",
        category = "Shield",
        height = 130,
        weight = 149500,
        entry = BastiodonDesc,
        forms = SingleSpecies(Species.Bastiodon),
    };
    public static readonly PokedexData Burmy = new()
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
    public static readonly PokedexData Wormadam = new()
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
    public static readonly PokedexData Mothim = new()
    {
        number = 414,
        name = "Mothim",
        category = "Moth",
        height = 90,
        weight = 23300,
        entry = MothimDesc,
        forms = SingleSpecies(Species.Mothim),
    };
    public static readonly PokedexData Combee = new()
    {
        number = 415,
        name = "Combee",
        category = "Tiny Bee",
        height = 30,
        weight = 5500,
        entry = CombeeDesc,
        forms = SingleSpecies(Species.Combee),
    };
    public static readonly PokedexData Vespiquen = new()
    {
        number = 416,
        name = "Vespiquen",
        category = "Beehive",
        height = 120,
        weight = 38500,
        entry = VespiquenDesc,
        forms = SingleSpecies(Species.Vespiquen),
    };
    public static readonly PokedexData Pachirisu = new()
    {
        number = 417,
        name = "Pachirisu",
        category = "EleSquirrel",
        height = 40,
        weight = 3900,
        entry = PachirisuDesc,
        forms = SingleSpecies(Species.Pachirisu),
    };
    public static readonly PokedexData Buizel = new()
    {
        number = 418,
        name = "Buizel",
        category = "Sea Weasel",
        height = 70,
        weight = 29500,
        entry = BuizelDesc,
        forms = SingleSpecies(Species.Buizel),
    };
    public static readonly PokedexData Floatzel = new()
    {
        number = 419,
        name = "Floatzel",
        category = "Sea Weasel",
        height = 110,
        weight = 33500,
        entry = FloatzelDesc,
        forms = SingleSpecies(Species.Floatzel),
    };
    public static readonly PokedexData Cherubi = new()
    {
        number = 420,
        name = "Cherubi",
        category = "Cherry",
        height = 40,
        weight = 3300,
        entry = CherubiDesc,
        forms = SingleSpecies(Species.Cherubi),
    };
    public static readonly PokedexData Cherrim = new()
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
    public static readonly PokedexData Shellos = new()
    {
        number = 422,
        name = "Shellos",
        category = "Sea Slug",
        height = 30,
        weight = 6300,
        entry = ShellosDesc,
        forms = new[]
        {
            Species.Shellos,
            Species.ShellosEast
        }
    };
    public static readonly PokedexData Gastrodon = new()
    {
        number = 423,
        name = "Gastrodon",
        category = "Sea Slug",
        height = 90,
        weight = 29900,
        entry = GastrodonDesc,
        forms = new[]
        {
            Species.Gastrodon,
            Species.GastrodonEast
        }
    };
    public static readonly PokedexData Ambipom = new()
    {
        number = 424,
        name = "Ambipom",
        category = "Long Tail",
        height = 120,
        weight = 20300,
        entry = AmbipomDesc,
        forms = SingleSpecies(Species.Ambipom),
    };
    public static readonly PokedexData Drifloon = new()
    {
        number = 425,
        name = "Drifloon",
        category = "Balloon",
        height = 40,
        weight = 1200,
        entry = DrifloonDesc,
        forms = SingleSpecies(Species.Drifloon),
    };
    public static readonly PokedexData Drifblim = new()
    {
        number = 426,
        name = "Drifblim",
        category = "Blimp",
        height = 120,
        weight = 15000,
        entry = DrifblimDesc,
        forms = SingleSpecies(Species.Drifblim),
    };
    public static readonly PokedexData Buneary = new()
    {
        number = 427,
        name = "Buneary",
        category = "Rabbit",
        height = 40,
        weight = 5500,
        entry = BunearyDesc,
        forms = SingleSpecies(Species.Buneary),
    };
    public static readonly PokedexData Lopunny = new()
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
    public static readonly PokedexData Mismagius = new()
    {
        number = 429,
        name = "Mismagius",
        category = "Magical",
        height = 90,
        weight = 4400,
        entry = MismagiusDesc,
        forms = SingleSpecies(Species.Mismagius),
    };
    public static readonly PokedexData Honchkrow = new()
    {
        number = 430,
        name = "Honchkrow",
        category = "Big Boss",
        height = 90,
        weight = 27300,
        entry = HonchkrowDesc,
        forms = SingleSpecies(Species.Honchkrow),
    };
    public static readonly PokedexData Glameow = new()
    {
        number = 431,
        name = "Glameow",
        category = "Catty",
        height = 50,
        weight = 3900,
        entry = GlameowDesc,
        forms = SingleSpecies(Species.Glameow),
    };
    public static readonly PokedexData Purugly = new()
    {
        number = 432,
        name = "Purugly",
        category = "Tiger Cat",
        height = 100,
        weight = 43800,
        entry = PuruglyDesc,
        forms = SingleSpecies(Species.Purugly),
    };
    public static readonly PokedexData Chingling = new()
    {
        number = 433,
        name = "Chingling",
        category = "Bell",
        height = 20,
        weight = 600,
        entry = ChinglingDesc,
        forms = SingleSpecies(Species.Chingling),
    };
    public static readonly PokedexData Stunky = new()
    {
        number = 434,
        name = "Stunky",
        category = "Skunk",
        height = 40,
        weight = 19200,
        entry = StunkyDesc,
        forms = SingleSpecies(Species.Stunky),
    };
    public static readonly PokedexData Skuntank = new()
    {
        number = 435,
        name = "Skuntank",
        category = "Skunk",
        height = 100,
        weight = 38000,
        entry = SkuntankDesc,
        forms = SingleSpecies(Species.Skuntank),
    };
    public static readonly PokedexData Bronzor = new()
    {
        number = 436,
        name = "Bronzor",
        category = "Bronze",
        height = 50,
        weight = 60500,
        entry = BronzorDesc,
        forms = SingleSpecies(Species.Bronzor),
    };
    public static readonly PokedexData Bronzong = new()
    {
        number = 437,
        name = "Bronzong",
        category = "Bronze Bell",
        height = 130,
        weight = 187000,
        entry = BronzongDesc,
        forms = SingleSpecies(Species.Bronzong),
    };
    public static readonly PokedexData Bonsly = new()
    {
        number = 438,
        name = "Bonsly",
        category = "Bonsai",
        height = 50,
        weight = 15000,
        entry = BonslyDesc,
        forms = SingleSpecies(Species.Bonsly),
    };
    public static readonly PokedexData MimeJr = new ()
	{
		number = 439,
		name = "Mime Jr",
		category = "Mime",
		height = 60,
		weight = 13000,
		entry = MimeJrDesc,
        forms = SingleSpecies(Species.MimeJr),

    };
    public static readonly PokedexData Happiny = new()
    {
        number = 440,
        name = "Happiny",
        category = "Playhouse",
        height = 60,
        weight = 24400,
        entry = HappinyDesc,
        forms = SingleSpecies(Species.Happiny),
    };
    public static readonly PokedexData Chatot = new()
    {
        number = 441,
        name = "Chatot",
        category = "Music Note",
        height = 50,
        weight = 1900,
        entry = ChatotDesc,
        forms = SingleSpecies(Species.Chatot),
    };
    public static readonly PokedexData Spiritomb = new()
    {
        number = 442,
        name = "Spiritomb",
        category = "Forbidden",
        height = 100,
        weight = 108000,
        entry = SpiritombDesc,
        forms = SingleSpecies(Species.Spiritomb),
    };
    public static readonly PokedexData Gible = new()
    {
        number = 443,
        name = "Gible",
        category = "Land Shark",
        height = 70,
        weight = 20500,
        entry = GibleDesc,
        forms = SingleSpecies(Species.Gible),
    };
    public static readonly PokedexData Gabite = new()
    {
        number = 444,
        name = "Gabite",
        category = "Cave",
        height = 140,
        weight = 56000,
        entry = GabiteDesc,
        forms = SingleSpecies(Species.Gabite),
    };
    public static readonly PokedexData Garchomp = new()
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
    public static readonly PokedexData Munchlax = new()
    {
        number = 446,
        name = "Munchlax",
        category = "BigEater",
        height = 60,
        weight = 105000,
        entry = MunchlaxDesc,
        forms = SingleSpecies(Species.Munchlax),
    };
    public static readonly PokedexData Riolu = new()
    {
        number = 447,
        name = "Riolu",
        category = "Emanation",
        height = 70,
        weight = 20200,
        entry = RioluDesc,
        forms = SingleSpecies(Species.Riolu),
    };
    public static readonly PokedexData Lucario = new()
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
    public static readonly PokedexData Hippopotas = new()
    {
        number = 449,
        name = "Hippopotas",
        category = "Hippo",
        height = 80,
        weight = 49500,
        entry = HippopotasDesc,
        forms = SingleSpecies(Species.Hippopotas),
    };
    public static readonly PokedexData Hippowdon = new()
    {
        number = 450,
        name = "Hippowdon",
        category = "Heavyweight",
        height = 200,
        weight = 300000,
        entry = HippowdonDesc,
        forms = SingleSpecies(Species.Hippowdon),
    };
    public static readonly PokedexData Skorupi = new()
    {
        number = 451,
        name = "Skorupi",
        category = "Scorpion",
        height = 80,
        weight = 12000,
        entry = SkorupiDesc,
        forms = SingleSpecies(Species.Skorupi),
    };
    public static readonly PokedexData Drapion = new()
    {
        number = 452,
        name = "Drapion",
        category = "Ogre Scorpion",
        height = 130,
        weight = 61500,
        entry = DrapionDesc,
        forms = SingleSpecies(Species.Drapion),
    };
    public static readonly PokedexData Croagunk = new()
    {
        number = 453,
        name = "Croagunk",
        category = "Toxic Mouth",
        height = 70,
        weight = 23000,
        entry = CroagunkDesc,
        forms = SingleSpecies(Species.Croagunk),
    };
    public static readonly PokedexData Toxicroak = new()
    {
        number = 454,
        name = "Toxicroak",
        category = "Toxic Mouth",
        height = 130,
        weight = 44400,
        entry = ToxicroakDesc,
        forms = SingleSpecies(Species.Toxicroak),
    };
    public static readonly PokedexData Carnivine = new()
    {
        number = 455,
        name = "Carnivine",
        category = "Bug Catcher",
        height = 140,
        weight = 27000,
        entry = CarnivineDesc,
        forms = SingleSpecies(Species.Carnivine),
    };
    public static readonly PokedexData Finneon = new()
    {
        number = 456,
        name = "Finneon",
        category = "Wing Fish",
        height = 40,
        weight = 7000,
        entry = FinneonDesc,
        forms = SingleSpecies(Species.Finneon),
    };
    public static readonly PokedexData Lumineon = new()
    {
        number = 457,
        name = "Lumineon",
        category = "Neon",
        height = 120,
        weight = 24000,
        entry = LumineonDesc,
        forms = SingleSpecies(Species.Lumineon),
    };
    public static readonly PokedexData Mantyke = new()
    {
        number = 458,
        name = "Mantyke",
        category = "Kite",
        height = 100,
        weight = 65000,
        entry = MantykeDesc,
        forms = SingleSpecies(Species.Mantyke),
    };
    public static readonly PokedexData Snover = new()
    {
        number = 459,
        name = "Snover",
        category = "Frost Tree",
        height = 100,
        weight = 50500,
        entry = SnoverDesc,
        forms = SingleSpecies(Species.Snover),
    };
    public static readonly PokedexData Abomasnow = new()
    {
        number = 460,
        name = "Abomasnow",
        category = "Frost Tree",
        height = 220,
        weight = 135500,
        entry = AbomasnowDesc,
        forms = new[]
        {
            Species.Abomasnow,
            Species.AbomasnowMega
        }
    };
    public static readonly PokedexData Weavile = new()
    {
        number = 461,
        name = "Weavile",
        category = "Sharp Claw",
        height = 110,
        weight = 34000,
        entry = WeavileDesc,
        forms = SingleSpecies(Species.Weavile),
    };
    public static readonly PokedexData Magnezone = new()
    {
        number = 462,
        name = "Magnezone",
        category = "Magnet Area",
        height = 120,
        weight = 180000,
        entry = MagnezoneDesc,
        forms = SingleSpecies(Species.Magnezone),
    };
    public static readonly PokedexData Lickilicky = new()
    {
        number = 463,
        name = "Lickilicky",
        category = "Licking",
        height = 170,
        weight = 140000,
        entry = LickilickyDesc,
        forms = SingleSpecies(Species.Lickilicky),
    };
    public static readonly PokedexData Rhyperior = new()
    {
        number = 464,
        name = "Rhyperior",
        category = "Drill",
        height = 240,
        weight = 282800,
        entry = RhyperiorDesc,
        forms = SingleSpecies(Species.Rhyperior),
    };
    public static readonly PokedexData Tangrowth = new()
    {
        number = 465,
        name = "Tangrowth",
        category = "Vine",
        height = 200,
        weight = 128600,
        entry = TangrowthDesc,
        forms = SingleSpecies(Species.Tangrowth),
    };
    public static readonly PokedexData Electivire = new()
    {
        number = 466,
        name = "Electivire",
        category = "Thunderbolt",
        height = 180,
        weight = 138600,
        entry = ElectivireDesc,
        forms = SingleSpecies(Species.Electivire),
    };
    public static readonly PokedexData Magmortar = new()
    {
        number = 467,
        name = "Magmortar",
        category = "Blast",
        height = 160,
        weight = 68000,
        entry = MagmortarDesc,
        forms = SingleSpecies(Species.Magmortar),
    };
    public static readonly PokedexData Togekiss = new()
    {
        number = 468,
        name = "Togekiss",
        category = "Jubilee",
        height = 150,
        weight = 38000,
        entry = TogekissDesc,
        forms = SingleSpecies(Species.Togekiss),
    };
    public static readonly PokedexData Yanmega = new()
    {
        number = 469,
        name = "Yanmega",
        category = "Ogre Darner",
        height = 190,
        weight = 51500,
        entry = YanmegaDesc,
        forms = SingleSpecies(Species.Yanmega),
    };
    public static readonly PokedexData Leafeon = new()
    {
        number = 470,
        name = "Leafeon",
        category = "Verdant",
        height = 100,
        weight = 25500,
        entry = LeafeonDesc,
        forms = SingleSpecies(Species.Leafeon),
    };
    public static readonly PokedexData Glaceon = new()
    {
        number = 471,
        name = "Glaceon",
        category = "Fresh Snow",
        height = 80,
        weight = 25900,
        entry = GlaceonDesc,
        forms = SingleSpecies(Species.Glaceon),
    };
    public static readonly PokedexData Gliscor = new()
    {
        number = 472,
        name = "Gliscor",
        category = "Fang Scorpion",
        height = 200,
        weight = 42500,
        entry = GliscorDesc,
        forms = SingleSpecies(Species.Gliscor),
    };
    public static readonly PokedexData Mamoswine = new()
    {
        number = 473,
        name = "Mamoswine",
        category = "Twin Tusk",
        height = 250,
        weight = 291000,
        entry = MamoswineDesc,
        forms = SingleSpecies(Species.Mamoswine),
    };
    public static readonly PokedexData PorygonZ = new()
    {
        number = 474,
        name = "Porygon Z",
        category = "Virtual",
        height = 90,
        weight = 34000,
        entry = PorygonZDesc,
        forms = SingleSpecies(Species.PorygonZ),
    };
    public static readonly PokedexData Gallade = new()
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
    public static readonly PokedexData Probopass = new()
    {
        number = 476,
        name = "Probopass",
        category = "Compass",
        height = 140,
        weight = 340000,
        entry = ProbopassDesc,
        forms = SingleSpecies(Species.Probopass),
    };
    public static readonly PokedexData Dusknoir = new()
    {
        number = 477,
        name = "Dusknoir",
        category = "Gripper",
        height = 220,
        weight = 106600,
        entry = DusknoirDesc,
        forms = SingleSpecies(Species.Dusknoir),
    };
    public static readonly PokedexData Froslass = new()
    {
        number = 478,
        name = "Froslass",
        category = "Snow Land",
        height = 130,
        weight = 26600,
        entry = FroslassDesc,
        forms = SingleSpecies(Species.Froslass),
    };
    public static readonly PokedexData Rotom = new()
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
    public static readonly PokedexData Uxie = new()
    {
        number = 480,
        name = "Uxie",
        category = "Knowledge",
        height = 30,
        weight = 300,
        entry = UxieDesc,
        forms = SingleSpecies(Species.Uxie),
    };
    public static readonly PokedexData Mesprit = new()
    {
        number = 481,
        name = "Mesprit",
        category = "Emotion",
        height = 30,
        weight = 300,
        entry = MespritDesc,
        forms = SingleSpecies(Species.Mesprit),
    };
    public static readonly PokedexData Azelf = new()
    {
        number = 482,
        name = "Azelf",
        category = "Willpower",
        height = 30,
        weight = 300,
        entry = AzelfDesc,
        forms = SingleSpecies(Species.Azelf),
    };
    public static readonly PokedexData Dialga = new()
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
    public static readonly PokedexData Palkia = new()
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
    public static readonly PokedexData Heatran = new()
    {
        number = 485,
        name = "Heatran",
        category = "Lava Dome",
        height = 170,
        weight = 430000,
        entry = HeatranDesc,
        forms = SingleSpecies(Species.Heatran),
    };
    public static readonly PokedexData Regigigas = new()
    {
        number = 486,
        name = "Regigigas",
        category = "Colossal",
        height = 370,
        weight = 420000,
        entry = RegigigasDesc,
        forms = SingleSpecies(Species.Regigigas),
    };
    public static readonly PokedexData Giratina = new()
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
    public static readonly PokedexData Cresselia = new()
    {
        number = 488,
        name = "Cresselia",
        category = "Lunar",
        height = 150,
        weight = 85600,
        entry = CresseliaDesc,
        forms = SingleSpecies(Species.Cresselia),
    };
    public static readonly PokedexData Phione = new()
    {
        number = 489,
        name = "Phione",
        category = "Sea Drifter",
        height = 40,
        weight = 3100,
        entry = PhioneDesc,
        forms = SingleSpecies(Species.Phione),
    };
    public static readonly PokedexData Manaphy = new()
    {
        number = 490,
        name = "Manaphy",
        category = "Seafaring",
        height = 30,
        weight = 1400,
        entry = ManaphyDesc,
        forms = SingleSpecies(Species.Manaphy),
    };
    public static readonly PokedexData Darkrai = new()
    {
        number = 491,
        name = "Darkrai",
        category = "Pitch-Black",
        height = 150,
        weight = 50500,
        entry = DarkraiDesc,
        forms = SingleSpecies(Species.Darkrai),
    };
    public static readonly PokedexData Shaymin = new()
    {
        number = 492,
        name = "Shaymin",
        category = "Gratitude",
        height = 20,
        weight = 2100,
        entry = ShayminDesc,
        forms = SingleSpecies(Species.Shaymin),
    };
    public static readonly PokedexData Arceus = new()
    {
        number = 493,
        name = "Arceus",
        category = "Alpha",
        height = 320,
        weight = 320000,
        entry = ArceusDesc,
        forms = SingleSpecies(Species.Arceus),
    };
    public static readonly PokedexData Victini = new()
    {
        number = 494,
        name = "Victini",
        category = "Victory",
        height = 40,
        weight = 4000,
        entry = VictiniDesc,
        forms = SingleSpecies(Species.Victini),
    };
    public static readonly PokedexData Snivy = new()
    {
        number = 495,
        name = "Snivy",
        category = "Grass Snake",
        height = 60,
        weight = 8100,
        entry = SnivyDesc,
        forms = SingleSpecies(Species.Snivy),
    };
    public static readonly PokedexData Servine = new()
    {
        number = 496,
        name = "Servine",
        category = "Grass Snake",
        height = 80,
        weight = 16000,
        entry = ServineDesc,
        forms = SingleSpecies(Species.Servine),
    };
    public static readonly PokedexData Serperior = new()
    {
        number = 497,
        name = "Serperior",
        category = "Regal",
        height = 330,
        weight = 63000,
        entry = SerperiorDesc,
        forms = SingleSpecies(Species.Serperior),
    };
    public static readonly PokedexData Tepig = new()
    {
        number = 498,
        name = "Tepig",
        category = "Fire Pig",
        height = 50,
        weight = 9900,
        entry = TepigDesc,
        forms = SingleSpecies(Species.Tepig),
    };
    public static readonly PokedexData Pignite = new()
    {
        number = 499,
        name = "Pignite",
        category = "Fire Pig",
        height = 100,
        weight = 55500,
        entry = PigniteDesc,
        forms = SingleSpecies(Species.Pignite),
    };
    public static readonly PokedexData Emboar = new()
    {
        number = 500,
        name = "Emboar",
        category = "Fire Pig",
        height = 160,
        weight = 150000,
        entry = EmboarDesc,
        forms = SingleSpecies(Species.Emboar),
    };
    public static readonly PokedexData Oshawott = new()
    {
        number = 501,
        name = "Oshawott",
        category = "Sea Otter",
        height = 50,
        weight = 5900,
        entry = OshawottDesc,
        forms = SingleSpecies(Species.Oshawott),
    };
    public static readonly PokedexData Dewott = new()
    {
        number = 502,
        name = "Dewott",
        category = "Discipline",
        height = 80,
        weight = 24500,
        entry = DewottDesc,
        forms = SingleSpecies(Species.Dewott),
    };
    public static readonly PokedexData Samurott = new()
    {
        number = 503,
        name = "Samurott",
        category = "Formidable",
        height = 150,
        weight = 94600,
        entry = SamurottDesc,
        forms = SingleSpecies(Species.Samurott),
    };
    public static readonly PokedexData Patrat = new()
    {
        number = 504,
        name = "Patrat",
        category = "Scout",
        height = 50,
        weight = 11600,
        entry = PatratDesc,
        forms = SingleSpecies(Species.Patrat),
    };
    public static readonly PokedexData Watchog = new()
    {
        number = 505,
        name = "Watchog",
        category = "Lookout",
        height = 110,
        weight = 27000,
        entry = WatchogDesc,
        forms = SingleSpecies(Species.Watchog),
    };
    public static readonly PokedexData Lillipup = new()
    {
        number = 506,
        name = "Lillipup",
        category = "Puppy",
        height = 40,
        weight = 4100,
        entry = LillipupDesc,
        forms = SingleSpecies(Species.Lillipup),
    };
    public static readonly PokedexData Herdier = new()
    {
        number = 507,
        name = "Herdier",
        category = "Loyal Dog",
        height = 90,
        weight = 14700,
        entry = HerdierDesc,
        forms = SingleSpecies(Species.Herdier),
    };
    public static readonly PokedexData Stoutland = new()
    {
        number = 508,
        name = "Stoutland",
        category = "Big-Hearted",
        height = 120,
        weight = 61000,
        entry = StoutlandDesc,
        forms = SingleSpecies(Species.Stoutland),
    };
    public static readonly PokedexData Purrloin = new()
    {
        number = 509,
        name = "Purrloin",
        category = "Devious",
        height = 40,
        weight = 10100,
        entry = PurrloinDesc,
        forms = SingleSpecies(Species.Purrloin),
    };
    public static readonly PokedexData Liepard = new()
    {
        number = 510,
        name = "Liepard",
        category = "Cruel",
        height = 110,
        weight = 37500,
        entry = LiepardDesc,
        forms = SingleSpecies(Species.Liepard),
    };
    public static readonly PokedexData Pansage = new()
    {
        number = 511,
        name = "Pansage",
        category = "Grass Monkey",
        height = 60,
        weight = 10500,
        entry = PansageDesc,
        forms = SingleSpecies(Species.Pansage),
    };
    public static readonly PokedexData Simisage = new()
    {
        number = 512,
        name = "Simisage",
        category = "Thorn Monkey",
        height = 110,
        weight = 30500,
        entry = SimisageDesc,
        forms = SingleSpecies(Species.Simisage),
    };
    public static readonly PokedexData Pansear = new()
    {
        number = 513,
        name = "Pansear",
        category = "High Temp",
        height = 60,
        weight = 11000,
        entry = PansearDesc,
        forms = SingleSpecies(Species.Pansear),
    };
    public static readonly PokedexData Simisear = new()
    {
        number = 514,
        name = "Simisear",
        category = "Ember",
        height = 100,
        weight = 28000,
        entry = SimisearDesc,
        forms = SingleSpecies(Species.Simisear),
    };
    public static readonly PokedexData Panpour = new()
    {
        number = 515,
        name = "Panpour",
        category = "Spray",
        height = 60,
        weight = 13500,
        entry = PanpourDesc,
        forms = SingleSpecies(Species.Panpour),
    };
    public static readonly PokedexData Simipour = new()
    {
        number = 516,
        name = "Simipour",
        category = "Geyser",
        height = 100,
        weight = 29000,
        entry = SimipourDesc,
        forms = SingleSpecies(Species.Simipour),
    };
    public static readonly PokedexData Munna = new()
    {
        number = 517,
        name = "Munna",
        category = "Dream Eater",
        height = 60,
        weight = 23300,
        entry = MunnaDesc,
        forms = SingleSpecies(Species.Munna),
    };
    public static readonly PokedexData Musharna = new()
    {
        number = 518,
        name = "Musharna",
        category = "Drowsing",
        height = 110,
        weight = 60500,
        entry = MusharnaDesc,
        forms = SingleSpecies(Species.Musharna),
    };
    public static readonly PokedexData Pidove = new()
    {
        number = 519,
        name = "Pidove",
        category = "Tiny Pigeon",
        height = 30,
        weight = 2100,
        entry = PidoveDesc,
        forms = SingleSpecies(Species.Pidove),
    };
    public static readonly PokedexData Tranquill = new()
    {
        number = 520,
        name = "Tranquill",
        category = "Wild Pigeon",
        height = 60,
        weight = 15000,
        entry = TranquillDesc,
        forms = SingleSpecies(Species.Tranquill),
    };
    public static readonly PokedexData Unfezant = new()
    {
        number = 521,
        name = "Unfezant",
        category = "Proud",
        height = 120,
        weight = 29000,
        entry = UnfezantDesc,
        forms = SingleSpecies(Species.Unfezant),
    };
    public static readonly PokedexData Blitzle = new()
    {
        number = 522,
        name = "Blitzle",
        category = "Electrified",
        height = 80,
        weight = 29800,
        entry = BlitzleDesc,
        forms = SingleSpecies(Species.Blitzle),
    };
    public static readonly PokedexData Zebstrika = new()
    {
        number = 523,
        name = "Zebstrika",
        category = "Thunderbolt",
        height = 160,
        weight = 79500,
        entry = ZebstrikaDesc,
        forms = SingleSpecies(Species.Zebstrika),
    };
    public static readonly PokedexData Roggenrola = new()
    {
        number = 524,
        name = "Roggenrola",
        category = "Mantle",
        height = 40,
        weight = 18000,
        entry = RoggenrolaDesc,
        forms = SingleSpecies(Species.Roggenrola),
    };
    public static readonly PokedexData Boldore = new()
    {
        number = 525,
        name = "Boldore",
        category = "Ore",
        height = 90,
        weight = 102000,
        entry = BoldoreDesc,
        forms = SingleSpecies(Species.Boldore),
    };
    public static readonly PokedexData Gigalith = new()
    {
        number = 526,
        name = "Gigalith",
        category = "Compressed",
        height = 170,
        weight = 260000,
        entry = GigalithDesc,
        forms = SingleSpecies(Species.Gigalith),
    };
    public static readonly PokedexData Woobat = new()
    {
        number = 527,
        name = "Woobat",
        category = "Bat",
        height = 40,
        weight = 2100,
        entry = WoobatDesc,
        forms = SingleSpecies(Species.Woobat),
    };
    public static readonly PokedexData Swoobat = new()
    {
        number = 528,
        name = "Swoobat",
        category = "Courting",
        height = 90,
        weight = 10500,
        entry = SwoobatDesc,
        forms = SingleSpecies(Species.Swoobat),
    };
    public static readonly PokedexData Drilbur = new()
    {
        number = 529,
        name = "Drilbur",
        category = "Mole",
        height = 30,
        weight = 8500,
        entry = DrilburDesc,
        forms = SingleSpecies(Species.Drilbur),
    };
    public static readonly PokedexData Excadrill = new()
    {
        number = 530,
        name = "Excadrill",
        category = "Subterrene",
        height = 70,
        weight = 40400,
        entry = ExcadrillDesc,
        forms = SingleSpecies(Species.Excadrill),
    };
    public static readonly PokedexData Audino = new()
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
    public static readonly PokedexData Timburr = new()
    {
        number = 532,
        name = "Timburr",
        category = "Muscular",
        height = 60,
        weight = 12500,
        entry = TimburrDesc,
        forms = SingleSpecies(Species.Timburr),
    };
    public static readonly PokedexData Gurdurr = new()
    {
        number = 533,
        name = "Gurdurr",
        category = "Muscular",
        height = 120,
        weight = 40000,
        entry = GurdurrDesc,
        forms = SingleSpecies(Species.Gurdurr),
    };
    public static readonly PokedexData Conkeldurr = new()
    {
        number = 534,
        name = "Conkeldurr",
        category = "Muscular",
        height = 140,
        weight = 87000,
        entry = ConkeldurrDesc,
        forms = SingleSpecies(Species.Conkeldurr),
    };
    public static readonly PokedexData Tympole = new()
    {
        number = 535,
        name = "Tympole",
        category = "Tadpole",
        height = 50,
        weight = 4500,
        entry = TympoleDesc,
        forms = SingleSpecies(Species.Tympole),
    };
    public static readonly PokedexData Palpitoad = new()
    {
        number = 536,
        name = "Palpitoad",
        category = "Vibration",
        height = 80,
        weight = 17000,
        entry = PalpitoadDesc,
        forms = SingleSpecies(Species.Palpitoad),
    };
    public static readonly PokedexData Seismitoad = new()
    {
        number = 537,
        name = "Seismitoad",
        category = "Vibration",
        height = 150,
        weight = 62000,
        entry = SeismitoadDesc,
        forms = SingleSpecies(Species.Seismitoad),
    };
    public static readonly PokedexData Throh = new()
    {
        number = 538,
        name = "Throh",
        category = "Judo",
        height = 130,
        weight = 55500,
        entry = ThrohDesc,
        forms = SingleSpecies(Species.Throh),
    };
    public static readonly PokedexData Sawk = new()
    {
        number = 539,
        name = "Sawk",
        category = "Karate",
        height = 140,
        weight = 51000,
        entry = SawkDesc,
        forms = SingleSpecies(Species.Sawk),
    };
    public static readonly PokedexData Sewaddle = new()
    {
        number = 540,
        name = "Sewaddle",
        category = "Sewing",
        height = 30,
        weight = 2500,
        entry = SewaddleDesc,
        forms = SingleSpecies(Species.Sewaddle),
    };
    public static readonly PokedexData Swadloon = new()
    {
        number = 541,
        name = "Swadloon",
        category = "Leaf-Wrapped",
        height = 50,
        weight = 7300,
        entry = SwadloonDesc,
        forms = SingleSpecies(Species.Swadloon),
    };
    public static readonly PokedexData Leavanny = new()
    {
        number = 542,
        name = "Leavanny",
        category = "Nurturing",
        height = 120,
        weight = 20500,
        entry = LeavannyDesc,
        forms = SingleSpecies(Species.Leavanny),
    };
    public static readonly PokedexData Venipede = new()
    {
        number = 543,
        name = "Venipede",
        category = "Centipede",
        height = 40,
        weight = 5300,
        entry = VenipedeDesc,
        forms = SingleSpecies(Species.Venipede),
    };
    public static readonly PokedexData Whirlipede = new()
    {
        number = 544,
        name = "Whirlipede",
        category = "Curlipede",
        height = 120,
        weight = 58500,
        entry = WhirlipedeDesc,
        forms = SingleSpecies(Species.Whirlipede),
    };
    public static readonly PokedexData Scolipede = new()
    {
        number = 545,
        name = "Scolipede",
        category = "Megapede",
        height = 250,
        weight = 200500,
        entry = ScolipedeDesc,
        forms = SingleSpecies(Species.Scolipede),
    };
    public static readonly PokedexData Cottonee = new()
    {
        number = 546,
        name = "Cottonee",
        category = "Cotton Puff",
        height = 30,
        weight = 600,
        entry = CottoneeDesc,
        forms = SingleSpecies(Species.Cottonee),
    };
    public static readonly PokedexData Whimsicott = new()
    {
        number = 547,
        name = "Whimsicott",
        category = "Windveiled",
        height = 70,
        weight = 6600,
        entry = WhimsicottDesc,
        forms = SingleSpecies(Species.Whimsicott),
    };
    public static readonly PokedexData Petilil = new()
    {
        number = 548,
        name = "Petilil",
        category = "Bulb",
        height = 50,
        weight = 6600,
        entry = PetililDesc,
        forms = SingleSpecies(Species.Petilil),
    };
    public static readonly PokedexData Lilligant = new()
    {
        number = 549,
        name = "Lilligant",
        category = "Flowering",
        height = 110,
        weight = 16300,
        entry = LilligantDesc,
        forms = SingleSpecies(Species.Lilligant),
    };
    public static readonly PokedexData Basculin = new()
    {
        number = 550,
        name = "Basculin",
        category = "Hostile",
        height = 100,
        weight = 18000,
        entry = BasculinDesc,
        forms = SingleSpecies(Species.BasculinRed),
    };
    public static readonly PokedexData Sandile = new()
    {
        number = 551,
        name = "Sandile",
        category = "DesertCroc",
        height = 70,
        weight = 15200,
        entry = SandileDesc,
        forms = SingleSpecies(Species.Sandile),
    };
    public static readonly PokedexData Krokorok = new()
    {
        number = 552,
        name = "Krokorok",
        category = "Desert Croc",
        height = 100,
        weight = 33400,
        entry = KrokorokDesc,
        forms = SingleSpecies(Species.Krokorok),
    };
    public static readonly PokedexData Krookodile = new()
    {
        number = 553,
        name = "Krookodile",
        category = "Intimidate",
        height = 150,
        weight = 96300,
        entry = KrookodileDesc,
        forms = SingleSpecies(Species.Krookodile),
    };
    public static readonly PokedexData Darumaka = new()
    {
        number = 554,
        name = "Darumaka",
        category = "Zen Charm",
        height = 60,
        weight = 37500,
        entry = DarumakaDesc,
        forms = SingleSpecies(Species.Darumaka),
    };
    public static readonly PokedexData Darmanitan = new()
    {
        number = 555,
        name = "Darmanitan",
        category = "Blazing",
        height = 130,
        weight = 92900,
        entry = DarmanitanDesc,
        forms = SingleSpecies(Species.Darmanitan),
    };
    public static readonly PokedexData Maractus = new()
    {
        number = 556,
        name = "Maractus",
        category = "Cactus",
        height = 100,
        weight = 28000,
        entry = MaractusDesc,
        forms = SingleSpecies(Species.Maractus),
    };
    public static readonly PokedexData Dwebble = new()
    {
        number = 557,
        name = "Dwebble",
        category = "Rock Inn",
        height = 30,
        weight = 14500,
        entry = DwebbleDesc,
        forms = SingleSpecies(Species.Dwebble),
    };
    public static readonly PokedexData Crustle = new()
    {
        number = 558,
        name = "Crustle",
        category = "Stone Home",
        height = 140,
        weight = 200000,
        entry = CrustleDesc,
        forms = SingleSpecies(Species.Crustle),
    };
    public static readonly PokedexData Scraggy = new()
    {
        number = 559,
        name = "Scraggy",
        category = "Shedding",
        height = 60,
        weight = 11800,
        entry = ScraggyDesc,
        forms = SingleSpecies(Species.Scraggy),
    };
    public static readonly PokedexData Scrafty = new()
    {
        number = 560,
        name = "Scrafty",
        category = "Hoodlum",
        height = 110,
        weight = 30000,
        entry = ScraftyDesc,
        forms = SingleSpecies(Species.Scrafty),
    };
    public static readonly PokedexData Sigilyph = new()
    {
        number = 561,
        name = "Sigilyph",
        category = "Avianoid",
        height = 140,
        weight = 14000,
        entry = SigilyphDesc,
        forms = SingleSpecies(Species.Sigilyph),
    };
    public static readonly PokedexData Yamask = new()
    {
        number = 562,
        name = "Yamask",
        category = "Spirit",
        height = 50,
        weight = 1500,
        entry = YamaskDesc,
        forms = SingleSpecies(Species.Yamask),
    };
    public static readonly PokedexData Cofagrigus = new()
    {
        number = 563,
        name = "Cofagrigus",
        category = "Coffin",
        height = 170,
        weight = 76500,
        entry = CofagrigusDesc,
        forms = SingleSpecies(Species.Cofagrigus),
    };
    public static readonly PokedexData Tirtouga = new()
    {
        number = 564,
        name = "Tirtouga",
        category = "Prototurtle",
        height = 70,
        weight = 16500,
        entry = TirtougaDesc,
        forms = SingleSpecies(Species.Tirtouga),
    };
    public static readonly PokedexData Carracosta = new()
    {
        number = 565,
        name = "Carracosta",
        category = "Prototurtle",
        height = 120,
        weight = 81000,
        entry = CarracostaDesc,
        forms = SingleSpecies(Species.Carracosta),
    };
    public static readonly PokedexData Archen = new()
    {
        number = 566,
        name = "Archen",
        category = "First Bird",
        height = 50,
        weight = 9500,
        entry = ArchenDesc,
        forms = SingleSpecies(Species.Archen),
    };
    public static readonly PokedexData Archeops = new()
    {
        number = 567,
        name = "Archeops",
        category = "First Bird",
        height = 140,
        weight = 32000,
        entry = ArcheopsDesc,
        forms = SingleSpecies(Species.Archeops),
    };
    public static readonly PokedexData Trubbish = new()
    {
        number = 568,
        name = "Trubbish",
        category = "Trash Bag",
        height = 60,
        weight = 31000,
        entry = TrubbishDesc,
        forms = SingleSpecies(Species.Trubbish),
    };
    public static readonly PokedexData Garbodor = new()
    {
        number = 569,
        name = "Garbodor",
        category = "Trash Heap",
        height = 190,
        weight = 107300,
        entry = GarbodorDesc,
        forms = SingleSpecies(Species.Garbodor),
    };
    public static readonly PokedexData Zorua = new()
    {
        number = 570,
        name = "Zorua",
        category = "Tricky Fox",
        height = 70,
        weight = 12500,
        entry = ZoruaDesc,
        forms = SingleSpecies(Species.Zorua),
    };
    public static readonly PokedexData Zoroark = new()
    {
        number = 571,
        name = "Zoroark",
        category = "Illusion Fox",
        height = 160,
        weight = 81100,
        entry = ZoroarkDesc,
        forms = SingleSpecies(Species.Zoroark),
    };
    public static readonly PokedexData Minccino = new()
    {
        number = 572,
        name = "Minccino",
        category = "Chinchilla",
        height = 40,
        weight = 5800,
        entry = MinccinoDesc,
        forms = SingleSpecies(Species.Minccino),
    };
    public static readonly PokedexData Cinccino = new()
    {
        number = 573,
        name = "Cinccino",
        category = "Scarf",
        height = 50,
        weight = 7500,
        entry = CinccinoDesc,
        forms = SingleSpecies(Species.Cinccino),
    };
    public static readonly PokedexData Gothita = new()
    {
        number = 574,
        name = "Gothita",
        category = "Fixation",
        height = 40,
        weight = 5800,
        entry = GothitaDesc,
        forms = SingleSpecies(Species.Gothita),
    };
    public static readonly PokedexData Gothorita = new()
    {
        number = 575,
        name = "Gothorita",
        category = "Manipulate",
        height = 70,
        weight = 18000,
        entry = GothoritaDesc,
        forms = SingleSpecies(Species.Gothorita),
    };
    public static readonly PokedexData Gothitelle = new()
    {
        number = 576,
        name = "Gothitelle",
        category = "Astral Body",
        height = 150,
        weight = 44000,
        entry = GothitelleDesc,
        forms = SingleSpecies(Species.Gothitelle),
    };
    public static readonly PokedexData Solosis = new()
    {
        number = 577,
        name = "Solosis",
        category = "Cell",
        height = 30,
        weight = 1000,
        entry = SolosisDesc,
        forms = SingleSpecies(Species.Solosis),
    };
    public static readonly PokedexData Duosion = new()
    {
        number = 578,
        name = "Duosion",
        category = "Mitosis",
        height = 60,
        weight = 8000,
        entry = DuosionDesc,
        forms = SingleSpecies(Species.Duosion),
    };
    public static readonly PokedexData Reuniclus = new()
    {
        number = 579,
        name = "Reuniclus",
        category = "Multiplying",
        height = 100,
        weight = 20100,
        entry = ReuniclusDesc,
        forms = SingleSpecies(Species.Reuniclus),
    };
    public static readonly PokedexData Ducklett = new()
    {
        number = 580,
        name = "Ducklett",
        category = "Water Bird",
        height = 50,
        weight = 5500,
        entry = DucklettDesc,
        forms = SingleSpecies(Species.Ducklett),
    };
    public static readonly PokedexData Swanna = new()
    {
        number = 581,
        name = "Swanna",
        category = "White Bird",
        height = 130,
        weight = 24200,
        entry = SwannaDesc,
        forms = SingleSpecies(Species.Swanna),
    };
    public static readonly PokedexData Vanillite = new()
    {
        number = 582,
        name = "Vanillite",
        category = "Fresh Snow",
        height = 40,
        weight = 5700,
        entry = VanilliteDesc,
        forms = SingleSpecies(Species.Vanillite),
    };
    public static readonly PokedexData Vanillish = new()
    {
        number = 583,
        name = "Vanillish",
        category = "Icy Snow",
        height = 110,
        weight = 41000,
        entry = VanillishDesc,
        forms = SingleSpecies(Species.Vanillish),
    };
    public static readonly PokedexData Vanilluxe = new()
    {
        number = 584,
        name = "Vanilluxe",
        category = "Snowstorm",
        height = 130,
        weight = 57500,
        entry = VanilluxeDesc,
        forms = SingleSpecies(Species.Vanilluxe),
    };
    public static readonly PokedexData Deerling = new()
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
    public static readonly PokedexData Sawsbuck = new()
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
    public static readonly PokedexData Emolga = new()
    {
        number = 587,
        name = "Emolga",
        category = "Sky Squirrel",
        height = 40,
        weight = 5000,
        entry = EmolgaDesc,
        forms = SingleSpecies(Species.Emolga),
    };
    public static readonly PokedexData Karrablast = new()
    {
        number = 588,
        name = "Karrablast",
        category = "Clamping",
        height = 50,
        weight = 5900,
        entry = KarrablastDesc,
        forms = SingleSpecies(Species.Karrablast),
    };
    public static readonly PokedexData Escavalier = new()
    {
        number = 589,
        name = "Escavalier",
        category = "Cavalry",
        height = 100,
        weight = 33000,
        entry = EscavalierDesc,
        forms = SingleSpecies(Species.Escavalier),
    };
    public static readonly PokedexData Foongus = new()
    {
        number = 590,
        name = "Foongus",
        category = "Mushroom",
        height = 20,
        weight = 1000,
        entry = FoongusDesc,
        forms = SingleSpecies(Species.Foongus),
    };
    public static readonly PokedexData Amoonguss = new()
    {
        number = 591,
        name = "Amoonguss",
        category = "Mushroom",
        height = 60,
        weight = 10500,
        entry = AmoongussDesc,
        forms = SingleSpecies(Species.Amoonguss),
    };
    public static readonly PokedexData Frillish = new()
    {
        number = 592,
        name = "Frillish",
        category = "Floating",
        height = 120,
        weight = 33000,
        entry = FrillishDesc,
        forms = SingleSpecies(Species.Frillish),
    };
    public static readonly PokedexData Jellicent = new()
    {
        number = 593,
        name = "Jellicent",
        category = "Floating",
        height = 220,
        weight = 135000,
        entry = JellicentDesc,
        forms = SingleSpecies(Species.Jellicent),
    };
    public static readonly PokedexData Alomomola = new()
    {
        number = 594,
        name = "Alomomola",
        category = "Caring",
        height = 120,
        weight = 31600,
        entry = AlomomolaDesc,
        forms = SingleSpecies(Species.Alomomola),
    };
    public static readonly PokedexData Joltik = new()
    {
        number = 595,
        name = "Joltik",
        category = "Attaching",
        height = 10,
        weight = 600,
        entry = JoltikDesc,
        forms = SingleSpecies(Species.Joltik),
    };
    public static readonly PokedexData Galvantula = new()
    {
        number = 596,
        name = "Galvantula",
        category = "EleSpider",
        height = 80,
        weight = 14300,
        entry = GalvantulaDesc,
        forms = SingleSpecies(Species.Galvantula),
    };
    public static readonly PokedexData Ferroseed = new()
    {
        number = 597,
        name = "Ferroseed",
        category = "Thorn Seed",
        height = 60,
        weight = 18800,
        entry = FerroseedDesc,
        forms = SingleSpecies(Species.Ferroseed),
    };
    public static readonly PokedexData Ferrothorn = new()
    {
        number = 598,
        name = "Ferrothorn",
        category = "Thorn Pod",
        height = 100,
        weight = 110000,
        entry = FerrothornDesc,
        forms = SingleSpecies(Species.Ferrothorn),
    };
    public static readonly PokedexData Klink = new()
    {
        number = 599,
        name = "Klink",
        category = "Gear",
        height = 30,
        weight = 21000,
        entry = KlinkDesc,
        forms = SingleSpecies(Species.Klink),
    };
    public static readonly PokedexData Klang = new()
    {
        number = 600,
        name = "Klang",
        category = "Gear",
        height = 60,
        weight = 51000,
        entry = KlangDesc,
        forms = SingleSpecies(Species.Klang),
    };
    public static readonly PokedexData Klinklang = new()
    {
        number = 601,
        name = "Klinklang",
        category = "Gear",
        height = 60,
        weight = 81000,
        entry = KlinklangDesc,
        forms = SingleSpecies(Species.Klinklang),
    };
    public static readonly PokedexData Tynamo = new()
    {
        number = 602,
        name = "Tynamo",
        category = "EleFish",
        height = 20,
        weight = 300,
        entry = TynamoDesc,
        forms = SingleSpecies(Species.Tynamo),
    };
    public static readonly PokedexData Eelektrik = new()
    {
        number = 603,
        name = "Eelektrik",
        category = "EleFish",
        height = 120,
        weight = 22000,
        entry = EelektrikDesc,
        forms = SingleSpecies(Species.Eelektrik),
    };
    public static readonly PokedexData Eelektross = new()
    {
        number = 604,
        name = "Eelektross",
        category = "EleFish",
        height = 210,
        weight = 80500,
        entry = EelektrossDesc,
        forms = SingleSpecies(Species.Eelektross),
    };
    public static readonly PokedexData Elgyem = new()
    {
        number = 605,
        name = "Elgyem",
        category = "Cerebral",
        height = 50,
        weight = 9000,
        entry = ElgyemDesc,
        forms = SingleSpecies(Species.Elgyem),
    };
    public static readonly PokedexData Beheeyem = new()
    {
        number = 606,
        name = "Beheeyem",
        category = "Cerebral",
        height = 100,
        weight = 34500,
        entry = BeheeyemDesc,
        forms = SingleSpecies(Species.Beheeyem),
    };
    public static readonly PokedexData Litwick = new()
    {
        number = 607,
        name = "Litwick",
        category = "Candle",
        height = 30,
        weight = 3100,
        entry = LitwickDesc,
        forms = SingleSpecies(Species.Litwick),
    };
    public static readonly PokedexData Lampent = new()
    {
        number = 608,
        name = "Lampent",
        category = "Lamp",
        height = 60,
        weight = 13000,
        entry = LampentDesc,
        forms = SingleSpecies(Species.Lampent),
    };
    public static readonly PokedexData Chandelure = new()
    {
        number = 609,
        name = "Chandelure",
        category = "Luring",
        height = 100,
        weight = 34300,
        entry = ChandelureDesc,
        forms = SingleSpecies(Species.Chandelure),
    };
    public static readonly PokedexData Axew = new()
    {
        number = 610,
        name = "Axew",
        category = "Tusk",
        height = 60,
        weight = 18000,
        entry = AxewDesc,
        forms = SingleSpecies(Species.Axew),
    };
    public static readonly PokedexData Fraxure = new()
    {
        number = 611,
        name = "Fraxure",
        category = "Axe Jaw",
        height = 100,
        weight = 36000,
        entry = FraxureDesc,
        forms = SingleSpecies(Species.Fraxure),
    };
    public static readonly PokedexData Haxorus = new()
    {
        number = 612,
        name = "Haxorus",
        category = "Axe Jaw",
        height = 180,
        weight = 105500,
        entry = HaxorusDesc,
        forms = SingleSpecies(Species.Haxorus),
    };
    public static readonly PokedexData Cubchoo = new()
    {
        number = 613,
        name = "Cubchoo",
        category = "Chill",
        height = 50,
        weight = 8500,
        entry = CubchooDesc,
        forms = SingleSpecies(Species.Cubchoo),
    };
    public static readonly PokedexData Beartic = new()
    {
        number = 614,
        name = "Beartic",
        category = "Freezing",
        height = 260,
        weight = 260000,
        entry = BearticDesc,
        forms = SingleSpecies(Species.Beartic),
    };
    public static readonly PokedexData Cryogonal = new()
    {
        number = 615,
        name = "Cryogonal",
        category = "Crystallize",
        height = 110,
        weight = 148000,
        entry = CryogonalDesc,
        forms = SingleSpecies(Species.Cryogonal),
    };
    public static readonly PokedexData Shelmet = new()
    {
        number = 616,
        name = "Shelmet",
        category = "Snail",
        height = 40,
        weight = 7700,
        entry = ShelmetDesc,
        forms = SingleSpecies(Species.Shelmet),
    };
    public static readonly PokedexData Accelgor = new()
    {
        number = 617,
        name = "Accelgor",
        category = "Shell Out",
        height = 80,
        weight = 25300,
        entry = AccelgorDesc,
        forms = SingleSpecies(Species.Accelgor),
    };
    public static readonly PokedexData Stunfisk = new()
    {
        number = 618,
        name = "Stunfisk",
        category = "Trap",
        height = 70,
        weight = 11000,
        entry = StunfiskDesc,
        forms = SingleSpecies(Species.Stunfisk),
    };
    public static readonly PokedexData Mienfoo = new()
    {
        number = 619,
        name = "Mienfoo",
        category = "Martial Arts",
        height = 90,
        weight = 20000,
        entry = MienfooDesc,
        forms = SingleSpecies(Species.Mienfoo),
    };
    public static readonly PokedexData Mienshao = new()
    {
        number = 620,
        name = "Mienshao",
        category = "Martial Arts",
        height = 140,
        weight = 35500,
        entry = MienshaoDesc,
        forms = SingleSpecies(Species.Mienshao),
    };
    public static readonly PokedexData Druddigon = new()
    {
        number = 621,
        name = "Druddigon",
        category = "Cave",
        height = 160,
        weight = 139000,
        entry = DruddigonDesc,
        forms = SingleSpecies(Species.Druddigon),
    };
    public static readonly PokedexData Golett = new()
    {
        number = 622,
        name = "Golett",
        category = "Automaton",
        height = 100,
        weight = 92000,
        entry = GolettDesc,
        forms = SingleSpecies(Species.Golett),
    };
    public static readonly PokedexData Golurk = new()
    {
        number = 623,
        name = "Golurk",
        category = "Automaton",
        height = 280,
        weight = 330000,
        entry = GolurkDesc,
        forms = SingleSpecies(Species.Golurk),
    };
    public static readonly PokedexData Pawniard = new()
    {
        number = 624,
        name = "Pawniard",
        category = "Sharp Blade",
        height = 50,
        weight = 10200,
        entry = PawniardDesc,
        forms = SingleSpecies(Species.Pawniard),
    };
    public static readonly PokedexData Bisharp = new()
    {
        number = 625,
        name = "Bisharp",
        category = "Sword Blade",
        height = 160,
        weight = 70000,
        entry = BisharpDesc,
        forms = SingleSpecies(Species.Bisharp),
    };
    public static readonly PokedexData Bouffalant = new()
    {
        number = 626,
        name = "Bouffalant",
        category = "Bash Buffalo",
        height = 160,
        weight = 94600,
        entry = BouffalantDesc,
        forms = SingleSpecies(Species.Bouffalant),
    };
    public static readonly PokedexData Rufflet = new()
    {
        number = 627,
        name = "Rufflet",
        category = "Eaglet",
        height = 50,
        weight = 10500,
        entry = RuffletDesc,
        forms = SingleSpecies(Species.Rufflet),
    };
    public static readonly PokedexData Braviary = new()
    {
        number = 628,
        name = "Braviary",
        category = "Valiant",
        height = 150,
        weight = 41000,
        entry = BraviaryDesc,
        forms = SingleSpecies(Species.Braviary),
    };
    public static readonly PokedexData Vullaby = new()
    {
        number = 629,
        name = "Vullaby",
        category = "Diapered",
        height = 50,
        weight = 9000,
        entry = VullabyDesc,
        forms = SingleSpecies(Species.Vullaby),
    };
    public static readonly PokedexData Mandibuzz = new()
    {
        number = 630,
        name = "Mandibuzz",
        category = "Bone Vulture",
        height = 120,
        weight = 39500,
        entry = MandibuzzDesc,
        forms = SingleSpecies(Species.Mandibuzz),
    };
    public static readonly PokedexData Heatmor = new()
    {
        number = 631,
        name = "Heatmor",
        category = "Anteater",
        height = 140,
        weight = 58000,
        entry = HeatmorDesc,
        forms = SingleSpecies(Species.Heatmor),
    };
    public static readonly PokedexData Durant = new()
    {
        number = 632,
        name = "Durant",
        category = "Iron Ant",
        height = 30,
        weight = 33000,
        entry = DurantDesc,
        forms = SingleSpecies(Species.Durant),
    };
    public static readonly PokedexData Deino = new()
    {
        number = 633,
        name = "Deino",
        category = "Irate",
        height = 80,
        weight = 17300,
        entry = DeinoDesc,
        forms = SingleSpecies(Species.Deino),
    };
    public static readonly PokedexData Zweilous = new()
    {
        number = 634,
        name = "Zweilous",
        category = "Hostile",
        height = 140,
        weight = 50000,
        entry = ZweilousDesc,
        forms = SingleSpecies(Species.Zweilous),
    };
    public static readonly PokedexData Hydreigon = new()
    {
        number = 635,
        name = "Hydreigon",
        category = "Brutal",
        height = 180,
        weight = 160000,
        entry = HydreigonDesc,
        forms = SingleSpecies(Species.Hydreigon),
    };
    public static readonly PokedexData Larvesta = new()
    {
        number = 636,
        name = "Larvesta",
        category = "Torch",
        height = 110,
        weight = 28800,
        entry = LarvestaDesc,
        forms = SingleSpecies(Species.Larvesta),
    };
    public static readonly PokedexData Volcarona = new()
    {
        number = 637,
        name = "Volcarona",
        category = "Sun",
        height = 160,
        weight = 46000,
        entry = VolcaronaDesc,
        forms = SingleSpecies(Species.Volcarona),
    };
    public static readonly PokedexData Cobalion = new()
    {
        number = 638,
        name = "Cobalion",
        category = "Iron Will",
        height = 210,
        weight = 250000,
        entry = CobalionDesc,
        forms = SingleSpecies(Species.Cobalion),
    };
    public static readonly PokedexData Terrakion = new()
    {
        number = 639,
        name = "Terrakion",
        category = "Cavern",
        height = 190,
        weight = 260000,
        entry = TerrakionDesc,
        forms = SingleSpecies(Species.Terrakion),
    };
    public static readonly PokedexData Virizion = new()
    {
        number = 640,
        name = "Virizion",
        category = "Grassland",
        height = 200,
        weight = 200000,
        entry = VirizionDesc,
        forms = SingleSpecies(Species.Virizion),
    };
    public static readonly PokedexData Tornadus = new()
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
    public static readonly PokedexData Thundurus = new()
    {
        number = 642,
        name = "Thundurus",
        category = "Bolt Strike",
        height = 150,
        weight = 61000,
        entry = ThundurusDesc,
        forms = new[]
        {
            Species.ThundurusI,
            Species.ThundurusT
        }
    };
    public static readonly PokedexData Reshiram = new()
    {
        number = 643,
        name = "Reshiram",
        category = "Vast White",
        height = 320,
        weight = 330000,
        entry = ReshiramDesc,
        forms = SingleSpecies(Species.Reshiram),
    };
    public static readonly PokedexData Zekrom = new()
    {
        number = 644,
        name = "Zekrom",
        category = "Deep Black",
        height = 290,
        weight = 345000,
        entry = ZekromDesc,
        forms = SingleSpecies(Species.Zekrom),
    };
    public static readonly PokedexData Landorus = new()
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
    public static readonly PokedexData Kyurem = new()
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
    public static readonly PokedexData Keldeo = new()
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
    public static readonly PokedexData Meloetta = new()
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
    public static readonly PokedexData Genesect = new()
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
    public static readonly PokedexData Chespin = new()
    {
        number = 650,
        name = "Chespin",
        category = "Spiny Nut",
        height = 40,
        weight = 9000,
        entry = ChespinDesc,
        forms = SingleSpecies(Species.Chespin),
    };
    public static readonly PokedexData Quilladin = new()
    {
        number = 651,
        name = "Quilladin",
        category = "Spiny Armor",
        height = 70,
        weight = 29000,
        entry = QuilladinDesc,
        forms = SingleSpecies(Species.Quilladin),
    };
    public static readonly PokedexData Chesnaught = new()
    {
        number = 652,
        name = "Chesnaught",
        category = "Spiny Armor",
        height = 160,
        weight = 90000,
        entry = ChesnaughtDesc,
        forms = SingleSpecies(Species.Chesnaught),
    };
    public static readonly PokedexData Fennekin = new()
    {
        number = 653,
        name = "Fennekin",
        category = "Fox",
        height = 40,
        weight = 9400,
        entry = FennekinDesc,
        forms = SingleSpecies(Species.Fennekin),
    };
    public static readonly PokedexData Braixen = new()
    {
        number = 654,
        name = "Braixen",
        category = "Fox",
        height = 100,
        weight = 14500,
        entry = BraixenDesc,
        forms = SingleSpecies(Species.Braixen),
    };
    public static readonly PokedexData Delphox = new()
    {
        number = 655,
        name = "Delphox",
        category = "Fox",
        height = 150,
        weight = 39000,
        entry = DelphoxDesc,
        forms = SingleSpecies(Species.Delphox),
    };
    public static readonly PokedexData Froakie = new()
    {
        number = 656,
        name = "Froakie",
        category = "Bubble Frog",
        height = 30,
        weight = 7000,
        entry = FroakieDesc,
        forms = SingleSpecies(Species.Froakie),
    };
    public static readonly PokedexData Frogadier = new()
    {
        number = 657,
        name = "Frogadier",
        category = "Bubble Frog",
        height = 60,
        weight = 10900,
        entry = FrogadierDesc,
        forms = SingleSpecies(Species.Frogadier),
    };
    public static readonly PokedexData Greninja = new()
    {
        number = 658,
        name = "Greninja",
        category = "Ninja",
        height = 150,
        weight = 40000,
        entry = GreninjaDesc,
        forms = SingleSpecies(Species.Greninja),
    };
    public static readonly PokedexData Bunnelby = new()
    {
        number = 659,
        name = "Bunnelby",
        category = "Digging",
        height = 40,
        weight = 5000,
        entry = BunnelbyDesc,
        forms = SingleSpecies(Species.Bunnelby),
    };
    public static readonly PokedexData Diggersby = new()
    {
        number = 660,
        name = "Diggersby",
        category = "Digging",
        height = 100,
        weight = 42400,
        entry = DiggersbyDesc,
        forms = SingleSpecies(Species.Diggersby),
    };
    public static readonly PokedexData Fletchling = new()
    {
        number = 661,
        name = "Fletchling",
        category = "Tiny Robin",
        height = 30,
        weight = 1700,
        entry = FletchlingDesc,
        forms = SingleSpecies(Species.Fletchling),
    };
    public static readonly PokedexData Fletchinder = new()
    {
        number = 662,
        name = "Fletchinder",
        category = "Ember",
        height = 70,
        weight = 16000,
        entry = FletchinderDesc,
        forms = SingleSpecies(Species.Fletchinder),
    };
    public static readonly PokedexData Talonflame = new()
    {
        number = 663,
        name = "Talonflame",
        category = "Scorching",
        height = 120,
        weight = 24500,
        entry = TalonflameDesc,
        forms = SingleSpecies(Species.Talonflame),
    };
    public static readonly PokedexData Scatterbug = new()
    {
        number = 664,
        name = "Scatterbug",
        category = "Scatterdust",
        height = 30,
        weight = 2500,
        entry = ScatterbugDesc,
        forms = SingleSpecies(Species.ScatterbugMeadow),
    };
    public static readonly PokedexData Spewpa = new()
    {
        number = 665,
        name = "Spewpa",
        category = "Scatterdust",
        height = 30,
        weight = 8400,
        entry = SpewpaDesc,
        forms = SingleSpecies(Species.SpewpaMeadow),
    };
    public static readonly PokedexData Vivillon = new()
    {
        number = 666,
        name = "Vivillon",
        category = "Scale",
        height = 120,
        weight = 17000,
        entry = VivillonDesc,
        forms = new[]
        {
            Species.VivillonMeadow,
            Species.VivillonArchipelago,
            Species.VivillonContinental,
            Species.VivillonElegant,
            Species.VivillonFancy,
            Species.VivillonGarden,
            Species.VivillonHighPlains,
            Species.VivillonIcySnow,
            Species.VivillonJungle,
            Species.VivillonMarine,
            Species.VivillonModern,
            Species.VivillonMonsoon,
            Species.VivillonOcean,
            Species.VivillonPokeBall,
            Species.VivillonPolar,
            Species.VivillonRiver,
            Species.VivillonSandstorm,
            Species.VivillonSavanna,
            Species.VivillonSun,
            Species.VivillonTundra,
        }
    };
    public static readonly PokedexData Litleo = new()
    {
        number = 667,
        name = "Litleo",
        category = "Lion Cub",
        height = 60,
        weight = 13500,
        entry = LitleoDesc,
        forms = SingleSpecies(Species.Litleo),
    };
    public static readonly PokedexData Pyroar = new()
    {
        number = 668,
        name = "Pyroar",
        category = "Royal",
        height = 150,
        weight = 81500,
        entry = PyroarDesc,
        forms = SingleSpecies(Species.Pyroar),
    };
    public static readonly PokedexData Flabebe = new()
    {
        number = 669,
        name = "Flabebe",
        category = "Single Bloom",
        height = 10,
        weight = 100,
        entry = FlabebeRedDesc,
        forms = new[]
        {
            Species.FlabebeRed,
            Species.FlabebeYellow,
            Species.FlabebeOrange,
            Species.FlabebeBlue,
            Species.FlabebeWhite
        }
    };
    public static readonly PokedexData Floette = new()
    {
        number = 670,
        name = "Floette",
        category = "Single Bloom",
        height = 20,
        weight = 900,
        entry = FloetteRedDesc,
        forms = new[]
        {
            Species.FloetteRed,
            Species.FloetteYellow,
            Species.FloetteOrange,
            Species.FloetteBlue,
            Species.FloetteWhite,
            Species.FloetteEternal
        }
    };
    public static readonly PokedexData Florges = new()
    {
        number = 671,
        name = "Florges",
        category = "Garden",
        height = 110,
        weight = 10000,
        entry = FlorgesRedDesc,
        forms = new[]
        {
            Species.FlorgesRed,
            Species.FlorgesYellow,
            Species.FlorgesOrange,
            Species.FlorgesBlue,
            Species.FlorgesWhite
        }
    };
    public static readonly PokedexData Skiddo = new()
    {
        number = 672,
        name = "Skiddo",
        category = "Mount",
        height = 90,
        weight = 31000,
        entry = SkiddoDesc,
        forms = SingleSpecies(Species.Skiddo),
    };
    public static readonly PokedexData Gogoat = new()
    {
        number = 673,
        name = "Gogoat",
        category = "Mount",
        height = 170,
        weight = 91000,
        entry = GogoatDesc,
        forms = SingleSpecies(Species.Gogoat),
    };
    public static readonly PokedexData Pancham = new()
    {
        number = 674,
        name = "Pancham",
        category = "Playful",
        height = 60,
        weight = 8000,
        entry = PanchamDesc,
        forms = SingleSpecies(Species.Pancham),
    };
    public static readonly PokedexData Pangoro = new()
    {
        number = 675,
        name = "Pangoro",
        category = "Daunting",
        height = 210,
        weight = 136000,
        entry = PangoroDesc,
        forms = SingleSpecies(Species.Pangoro),
    };
    public static readonly PokedexData Furfrou = new()
    {
        number = 676,
        name = "Furfrou",
        category = "Poodle",
        height = 120,
        weight = 28000,
        entry = FurfrouDesc,
        forms = new[]
        {
            Species.FurfrouNatural,
            Species.FurfrouHeart,
            Species.FurfrouStar,
            Species.FurfrouDiamond,
            Species.FurfrouDebutante,
            Species.FurfrouMatron,
            Species.FurfrouDandy,
            Species.FurfrouLaReine,
            Species.FurfrouKabuki,
            Species.FurfrouPharaoh
        }
    };
    public static readonly PokedexData Espurr = new()
    {
        number = 677,
        name = "Espurr",
        category = "Restraint",
        height = 30,
        weight = 3500,
        entry = EspurrDesc,
        forms = SingleSpecies(Species.Espurr),
    };
    public static readonly PokedexData Meowstic = new()
    {
        number = 678,
        name = "Meowstic",
        category = "Constraint",
        height = 60,
        weight = 8500,
        entry = MeowsticMDesc,
        forms = new[]
        {
            Species.MeowsticM,
            Species.MeowsticF
        },
    };
    public static readonly PokedexData Honedge = new()
    {
        number = 679,
        name = "Honedge",
        category = "Sword",
        height = 80,
        weight = 2000,
        entry = HonedgeDesc,
        forms = SingleSpecies(Species.Honedge),
    };
    public static readonly PokedexData Doublade = new()
    {
        number = 680,
        name = "Doublade",
        category = "Sword",
        height = 80,
        weight = 4500,
        entry = DoubladeDesc,
        forms = SingleSpecies(Species.Doublade),
    };
    public static readonly PokedexData Aegislash = new()
    {
        number = 681,
        name = "Aegislash",
        category = "Royal Sword",
        height = 170,
        weight = 53000,
        entry = AegislashShieldDesc,
        forms = new[]
        {
            Species.AegislashShield,
            Species.AegislashBlade
        },
    };
    public static readonly PokedexData Spritzee = new()
    {
        number = 682,
        name = "Spritzee",
        category = "Perfume",
        height = 20,
        weight = 500,
        entry = SpritzeeDesc,
        forms = SingleSpecies(Species.Spritzee),
    };
    public static readonly PokedexData Aromatisse = new()
    {
        number = 683,
        name = "Aromatisse",
        category = "Fragrance",
        height = 80,
        weight = 15500,
        entry = AromatisseDesc,
        forms = SingleSpecies(Species.Aromatisse),
    };
    public static readonly PokedexData Swirlix = new()
    {
        number = 684,
        name = "Swirlix",
        category = "Cotton Candy",
        height = 40,
        weight = 3500,
        entry = SwirlixDesc,
        forms = SingleSpecies(Species.Swirlix),
    };
    public static readonly PokedexData Slurpuff = new()
    {
        number = 685,
        name = "Slurpuff",
        category = "Meringue",
        height = 80,
        weight = 5000,
        entry = SlurpuffDesc,
        forms = SingleSpecies(Species.Slurpuff),
    };
    public static readonly PokedexData Inkay = new()
    {
        number = 686,
        name = "Inkay",
        category = "Revolving",
        height = 40,
        weight = 3500,
        entry = InkayDesc,
        forms = SingleSpecies(Species.Inkay),
    };
    public static readonly PokedexData Malamar = new()
    {
        number = 687,
        name = "Malamar",
        category = "Overturning",
        height = 150,
        weight = 47000,
        entry = MalamarDesc,
        forms = SingleSpecies(Species.Malamar),
    };
    public static readonly PokedexData Binacle = new()
    {
        number = 688,
        name = "Binacle",
        category = "Two-Handed",
        height = 50,
        weight = 31000,
        entry = BinacleDesc,
        forms = SingleSpecies(Species.Binacle),
    };
    public static readonly PokedexData Barbaracle = new()
    {
        number = 689,
        name = "Barbaracle",
        category = "Collective",
        height = 130,
        weight = 96000,
        entry = BarbaracleDesc,
        forms = SingleSpecies(Species.Barbaracle),
    };
    public static readonly PokedexData Skrelp = new()
    {
        number = 690,
        name = "Skrelp",
        category = "MockKelp",
        height = 50,
        weight = 7300,
        entry = SkrelpDesc,
        forms = SingleSpecies(Species.Skrelp),
    };
    public static readonly PokedexData Dragalge = new()
    {
        number = 691,
        name = "Dragalge",
        category = "Mock Kelp",
        height = 180,
        weight = 81500,
        entry = DragalgeDesc,
        forms = SingleSpecies(Species.Dragalge),
    };
    public static readonly PokedexData Clauncher = new()
    {
        number = 692,
        name = "Clauncher",
        category = "Water Gun",
        height = 50,
        weight = 8300,
        entry = ClauncherDesc,
        forms = SingleSpecies(Species.Clauncher),
    };
    public static readonly PokedexData Clawitzer = new()
    {
        number = 693,
        name = "Clawitzer",
        category = "Howitzer",
        height = 130,
        weight = 35300,
        entry = ClawitzerDesc,
        forms = SingleSpecies(Species.Clawitzer),
    };
    public static readonly PokedexData Helioptile = new()
    {
        number = 694,
        name = "Helioptile",
        category = "Generator",
        height = 50,
        weight = 6000,
        entry = HelioptileDesc,
        forms = SingleSpecies(Species.Helioptile),
    };
    public static readonly PokedexData Heliolisk = new()
    {
        number = 695,
        name = "Heliolisk",
        category = "Generator",
        height = 100,
        weight = 21000,
        entry = HelioliskDesc,
        forms = SingleSpecies(Species.Heliolisk),
    };
    public static readonly PokedexData Tyrunt = new()
    {
        number = 696,
        name = "Tyrunt",
        category = "Royal Heir",
        height = 80,
        weight = 26000,
        entry = TyruntDesc,
        forms = SingleSpecies(Species.Tyrunt),
    };
    public static readonly PokedexData Tyrantrum = new()
    {
        number = 697,
        name = "Tyrantrum",
        category = "Despot",
        height = 250,
        weight = 270000,
        entry = TyrantrumDesc,
        forms = SingleSpecies(Species.Tyrantrum),
    };
    public static readonly PokedexData Amaura = new()
    {
        number = 698,
        name = "Amaura",
        category = "Tundra",
        height = 130,
        weight = 25200,
        entry = AmauraDesc,
        forms = SingleSpecies(Species.Amaura),
    };
    public static readonly PokedexData Aurorus = new()
    {
        number = 699,
        name = "Aurorus",
        category = "Tundra",
        height = 270,
        weight = 225000,
        entry = AurorusDesc,
        forms = SingleSpecies(Species.Aurorus),
    };
    public static readonly PokedexData Sylveon = new()
    {
        number = 700,
        name = "Sylveon",
        category = "Intertwine",
        height = 100,
        weight = 23500,
        entry = SylveonDesc,
        forms = SingleSpecies(Species.Sylveon),
    };
    public static readonly PokedexData Hawlucha = new()
    {
        number = 701,
        name = "Hawlucha",
        category = "Wrestling",
        height = 80,
        weight = 21500,
        entry = HawluchaDesc,
        forms = SingleSpecies(Species.Hawlucha),
    };
    public static readonly PokedexData Dedenne = new()
    {
        number = 702,
        name = "Dedenne",
        category = "Antenna",
        height = 20,
        weight = 2200,
        entry = DedenneDesc,
        forms = SingleSpecies(Species.Dedenne),
    };
    public static readonly PokedexData Carbink = new()
    {
        number = 703,
        name = "Carbink",
        category = "Jewel",
        height = 30,
        weight = 5700,
        entry = CarbinkDesc,
        forms = SingleSpecies(Species.Carbink),
    };
    public static readonly PokedexData Goomy = new()
    {
        number = 704,
        name = "Goomy",
        category = "Soft Tissue",
        height = 30,
        weight = 2800,
        entry = GoomyDesc,
        forms = SingleSpecies(Species.Goomy),
    };
    public static readonly PokedexData Sliggoo = new()
    {
        number = 705,
        name = "Sliggoo",
        category = "Soft Tissue",
        height = 80,
        weight = 17500,
        entry = SliggooDesc,
        forms = SingleSpecies(Species.Sliggoo),
    };
    public static readonly PokedexData Goodra = new()
    {
        number = 706,
        name = "Goodra",
        category = "Dragon",
        height = 200,
        weight = 150500,
        entry = GoodraDesc,
        forms = SingleSpecies(Species.Goodra),
    };
    public static readonly PokedexData Klefki = new()
    {
        number = 707,
        name = "Klefki",
        category = "Key Ring",
        height = 20,
        weight = 3000,
        entry = KlefkiDesc,
        forms = SingleSpecies(Species.Klefki),
    };
    public static readonly PokedexData Phantump = new()
    {
        number = 708,
        name = "Phantump",
        category = "Stump",
        height = 40,
        weight = 7000,
        entry = PhantumpDesc,
        forms = SingleSpecies(Species.Phantump),
    };
    public static readonly PokedexData Trevenant = new()
    {
        number = 709,
        name = "Trevenant",
        category = "Elder Tree",
        height = 150,
        weight = 71000,
        entry = TrevenantDesc,
        forms = SingleSpecies(Species.Trevenant),
    };
    public static readonly PokedexData Pumpkaboo = new()
    {
        number = 710,
        name = "Pumpkaboo",
        category = "Pumpkin",
        height = 40,
        weight = 5000,
        entry = PumpkabooDesc,
        forms = new[]
        {
            Species.PumpkabooAverage,
            Species.PumpkabooSmall,
            Species.PumpkabooLarge,
            Species.PumpkabooSuper
        }
    };
    public static readonly PokedexData Gourgeist = new()
    {
        number = 711,
        name = "Gourgeist",
        category = "Pumpkin",
        height = 90,
        weight = 12500,
        entry = GourgeistDesc,
        forms = new[]
        {
            Species.GourgeistAverage,
            Species.GourgeistSmall,
            Species.GourgeistLarge,
            Species.GourgeistSuper
        }
    };
    public static readonly PokedexData Bergmite = new()
    {
        number = 712,
        name = "Bergmite",
        category = "Ice Chunk",
        height = 100,
        weight = 99500,
        entry = BergmiteDesc,
        forms = SingleSpecies(Species.Bergmite),
    };
    public static readonly PokedexData Avalugg = new()
    {
        number = 713,
        name = "Avalugg",
        category = "Iceberg",
        height = 200,
        weight = 505000,
        entry = AvaluggDesc,
        forms = SingleSpecies(Species.Avalugg),
    };
    public static readonly PokedexData Noibat = new()
    {
        number = 714,
        name = "Noibat",
        category = "Sound Wave",
        height = 50,
        weight = 8000,
        entry = NoibatDesc,
        forms = SingleSpecies(Species.Noibat),
    };
    public static readonly PokedexData Noivern = new()
    {
        number = 715,
        name = "Noivern",
        category = "Sound Wave",
        height = 150,
        weight = 85000,
        entry = NoivernDesc,
        forms = SingleSpecies(Species.Noivern),
    };
    public static readonly PokedexData Xerneas = new()
    {
        number = 716,
        name = "Xerneas",
        category = "Life",
        height = 300,
        weight = 215000,
        entry = XerneasDesc,
        forms = new[]
        {
            Species.XerneasInactive,
            Species.XerneasActive
        },
    };
    public static readonly PokedexData Yveltal = new()
    {
        number = 717,
        name = "Yveltal",
        category = "Destruction",
        height = 580,
        weight = 203000,
        entry = YveltalDesc,
        forms = SingleSpecies(Species.Yveltal),
    };
    public static readonly PokedexData Zygarde = new()
    {
        number = 718,
        name = "Zygarde",
        category = "Order",
        height = 500,
        weight = 305000,
        entry = Zygarde50Desc,
        forms = new[]
        {
            Species.Zygarde50,
            Species.Zygarde10,
            Species.ZygardeComplete
        }
    };
    public static readonly PokedexData Diancie = new()
    {
        number = 719,
        name = "Diancie",
        category = "Jewel",
        height = 70,
        weight = 8800,
        entry = DiancieDesc,
        forms = new[]
        {
            Species.Diancie,
            Species.DiancieMega
        }
    };
    public static readonly PokedexData Hoopa = new()
    {
        number = 720,
        name = "Hoopa",
        category = "Mischief",
        height = 50,
        weight = 9000,
        entry = HoopaDesc,
        forms = new[]
        {
            Species.Hoopa,
            Species.HoopaUnbound
        }
    };
    public static readonly PokedexData Volcanion = new()
    {
        number = 721,
        name = "Volcanion",
        category = "Steam",
        height = 170,
        weight = 195000,
        entry = VolcanionDesc,
        forms = SingleSpecies(Species.Volcanion),
    };
    public static readonly PokedexData Rowlet = new()
    {
        number = 722,
        name = "Rowlet",
        category = "Grass Quill",
        height = 30,
        weight = 1500,
        entry = RowletDesc,
        forms = SingleSpecies(Species.Rowlet),
    };
    public static readonly PokedexData Dartrix = new()
    {
        number = 723,
        name = "Dartrix",
        category = "Blade Quill",
        height = 70,
        weight = 16000,
        entry = DartrixDesc,
        forms = SingleSpecies(Species.Dartrix),
    };
    public static readonly PokedexData Decidueye = new()
    {
        number = 724,
        name = "Decidueye",
        category = "Arrow Quill",
        height = 160,
        weight = 36600,
        entry = DecidueyeDesc,
        forms = SingleSpecies(Species.Decidueye),
    };
    public static readonly PokedexData Litten = new()
    {
        number = 725,
        name = "Litten",
        category = "Fire Cat",
        height = 40,
        weight = 4300,
        entry = LittenDesc,
        forms = SingleSpecies(Species.Litten),
    };
    public static readonly PokedexData Torracat = new()
    {
        number = 726,
        name = "Torracat",
        category = "Fire Cat",
        height = 70,
        weight = 25000,
        entry = TorracatDesc,
        forms = SingleSpecies(Species.Torracat),
    };
    public static readonly PokedexData Incineroar = new()
    {
        number = 727,
        name = "Incineroar",
        category = "Heel",
        height = 180,
        weight = 83000,
        entry = IncineroarDesc,
        forms = SingleSpecies(Species.Incineroar),
    };
    public static readonly PokedexData Popplio = new()
    {
        number = 728,
        name = "Popplio",
        category = "Sea Lion",
        height = 40,
        weight = 7500,
        entry = PopplioDesc,
        forms = SingleSpecies(Species.Popplio),
    };
    public static readonly PokedexData Brionne = new()
    {
        number = 729,
        name = "Brionne",
        category = "Pop Star",
        height = 60,
        weight = 17500,
        entry = BrionneDesc,
        forms = SingleSpecies(Species.Brionne),
    };
    public static readonly PokedexData Primarina = new()
    {
        number = 730,
        name = "Primarina",
        category = "Soloist",
        height = 180,
        weight = 44000,
        entry = PrimarinaDesc,
        forms = SingleSpecies(Species.Primarina),
    };
    public static readonly PokedexData Pikipek = new()
    {
        number = 731,
        name = "Pikipek",
        category = "Woodpecker",
        height = 30,
        weight = 1200,
        entry = PikipekDesc,
        forms = SingleSpecies(Species.Pikipek),
    };
    public static readonly PokedexData Trumbeak = new()
    {
        number = 732,
        name = "Trumbeak",
        category = "Bugle Beak",
        height = 60,
        weight = 14800,
        entry = TrumbeakDesc,
        forms = SingleSpecies(Species.Trumbeak),
    };
    public static readonly PokedexData Toucannon = new()
    {
        number = 733,
        name = "Toucannon",
        category = "Cannon",
        height = 110,
        weight = 26000,
        entry = ToucannonDesc,
        forms = SingleSpecies(Species.Toucannon),
    };
    public static readonly PokedexData Yungoos = new()
    {
        number = 734,
        name = "Yungoos",
        category = "Loitering",
        height = 40,
        weight = 6000,
        entry = YungoosDesc,
        forms = SingleSpecies(Species.Yungoos),
    };
    public static readonly PokedexData Gumshoos = new()
    {
        number = 735,
        name = "Gumshoos",
        category = "Stakeout",
        height = 70,
        weight = 14200,
        entry = GumshoosDesc,
        forms = SingleSpecies(Species.Gumshoos),
    };
    public static readonly PokedexData Grubbin = new()
    {
        number = 736,
        name = "Grubbin",
        category = "Larva",
        height = 40,
        weight = 4400,
        entry = GrubbinDesc,
        forms = SingleSpecies(Species.Grubbin),
    };
    public static readonly PokedexData Charjabug = new()
    {
        number = 737,
        name = "Charjabug",
        category = "Battery",
        height = 50,
        weight = 10500,
        entry = CharjabugDesc,
        forms = SingleSpecies(Species.Charjabug),
    };
    public static readonly PokedexData Vikavolt = new()
    {
        number = 738,
        name = "Vikavolt",
        category = "Stag Beetle",
        height = 150,
        weight = 45000,
        entry = VikavoltDesc,
        forms = SingleSpecies(Species.Vikavolt),
    };
    public static readonly PokedexData Crabrawler = new()
    {
        number = 739,
        name = "Crabrawler",
        category = "Boxing",
        height = 60,
        weight = 7000,
        entry = CrabrawlerDesc,
        forms = SingleSpecies(Species.Crabrawler),
    };
    public static readonly PokedexData Crabominable = new()
    {
        number = 740,
        name = "Crabominable",
        category = "Woolly Crab",
        height = 170,
        weight = 180000,
        entry = CrabominableDesc,
        forms = SingleSpecies(Species.Crabominable),
    };
    public static readonly PokedexData Oricorio = new()
    {
        number = 741,
        name = "Oricorio",
        category = "Dancing",
        height = 60,
        weight = 3400,
        entry = OricorioBaileDesc,
        forms = new[]
        {
            Species.OricorioBaile,
            Species.OricorioPomPom,
            Species.OricorioPau,
            Species.OricorioSensu
        },
    };
    public static readonly PokedexData Cutiefly = new()
    {
        number = 742,
        name = "Cutiefly",
        category = "Bee Fly",
        height = 10,
        weight = 200,
        entry = CutieflyDesc,
        forms = SingleSpecies(Species.Cutiefly),
    };
    public static readonly PokedexData Ribombee = new()
    {
        number = 743,
        name = "Ribombee",
        category = "Bee Fly",
        height = 20,
        weight = 500,
        entry = RibombeeDesc,
        forms = SingleSpecies(Species.Ribombee),
    };
    public static readonly PokedexData Rockruff = new()
    {
        number = 744,
        name = "Rockruff",
        category = "Puppy",
        height = 50,
        weight = 9200,
        entry = RockruffDesc,
        forms = SingleSpecies(Species.RockruffNormal),
    };
    public static readonly PokedexData Lycanroc = new()
    {
        number = 745,
        name = "Lycanroc",
        category = "Wolf",
        height = 80,
        weight = 25000,
        entry = LycanrocMiddayDesc,
        forms = new[]
        {
            Species.Lycanroc,
            Species.LycanrocMidnight,
            Species.LycanrocDusk
        },
    };
    public static readonly PokedexData Wishiwashi = new()
    {
        number = 746,
        name = "Wishiwashi",
        category = "Small Fry",
        height = 20,
        weight = 300,
        entry = WishiwashiBaseDesc,
        forms = new[]
        {
            Species.Wishiwashi,
            Species.WishiwashiSchool
        }
    };
    public static readonly PokedexData Mareanie = new()
    {
        number = 747,
        name = "Mareanie",
        category = "Brutal Star",
        height = 40,
        weight = 8000,
        entry = MareanieDesc,
        forms = SingleSpecies(Species.Mareanie),
    };
    public static readonly PokedexData Toxapex = new()
    {
        number = 748,
        name = "Toxapex",
        category = "Brutal Star",
        height = 70,
        weight = 14500,
        entry = ToxapexDesc,
        forms = SingleSpecies(Species.Toxapex),
    };
    public static readonly PokedexData Mudbray = new()
    {
        number = 749,
        name = "Mudbray",
        category = "Donkey",
        height = 100,
        weight = 110000,
        entry = MudbrayDesc,
        forms = SingleSpecies(Species.Mudbray),
    };
    public static readonly PokedexData Mudsdale = new()
    {
        number = 750,
        name = "Mudsdale",
        category = "Draft Horse",
        height = 250,
        weight = 920000,
        entry = MudsdaleDesc,
        forms = SingleSpecies(Species.Mudsdale),
    };
    public static readonly PokedexData Dewpider = new()
    {
        number = 751,
        name = "Dewpider",
        category = "Water Bubble",
        height = 30,
        weight = 4000,
        entry = DewpiderDesc,
        forms = SingleSpecies(Species.Dewpider),
    };
    public static readonly PokedexData Araquanid = new()
    {
        number = 752,
        name = "Araquanid",
        category = "Water Bubble",
        height = 180,
        weight = 82000,
        entry = AraquanidDesc,
        forms = SingleSpecies(Species.Araquanid),
    };
    public static readonly PokedexData Fomantis = new()
    {
        number = 753,
        name = "Fomantis",
        category = "Sickle Grass",
        height = 30,
        weight = 1500,
        entry = FomantisDesc,
        forms = SingleSpecies(Species.Fomantis),
    };
    public static readonly PokedexData Lurantis = new()
    {
        number = 754,
        name = "Lurantis",
        category = "Bloom Sickle",
        height = 90,
        weight = 18500,
        entry = LurantisDesc,
        forms = SingleSpecies(Species.Lurantis),
    };
    public static readonly PokedexData Morelull = new()
    {
        number = 755,
        name = "Morelull",
        category = "Illuminate",
        height = 20,
        weight = 1500,
        entry = MorelullDesc,
        forms = SingleSpecies(Species.Morelull),
    };
    public static readonly PokedexData Shiinotic = new()
    {
        number = 756,
        name = "Shiinotic",
        category = "Illuminate",
        height = 100,
        weight = 11500,
        entry = ShiinoticDesc,
        forms = SingleSpecies(Species.Shiinotic),
    };
    public static readonly PokedexData Salandit = new()
    {
        number = 757,
        name = "Salandit",
        category = "Toxic Lizard",
        height = 60,
        weight = 4800,
        entry = SalanditDesc,
        forms = SingleSpecies(Species.Salandit),
    };
    public static readonly PokedexData Salazzle = new()
    {
        number = 758,
        name = "Salazzle",
        category = "Toxic Lizard",
        height = 120,
        weight = 22200,
        entry = SalazzleDesc,
        forms = SingleSpecies(Species.Salazzle),
    };
    public static readonly PokedexData Stufful = new()
    {
        number = 759,
        name = "Stufful",
        category = "Flailing",
        height = 50,
        weight = 6800,
        entry = StuffulDesc,
        forms = SingleSpecies(Species.Stufful),
    };
    public static readonly PokedexData Bewear = new()
    {
        number = 760,
        name = "Bewear",
        category = "Strong Arm",
        height = 210,
        weight = 135000,
        entry = BewearDesc,
        forms = SingleSpecies(Species.Bewear),
    };
    public static readonly PokedexData Bounsweet = new()
    {
        number = 761,
        name = "Bounsweet",
        category = "Fruit",
        height = 30,
        weight = 3200,
        entry = BounsweetDesc,
        forms = SingleSpecies(Species.Bounsweet),
    };
    public static readonly PokedexData Steenee = new()
    {
        number = 762,
        name = "Steenee",
        category = "Fruit",
        height = 70,
        weight = 8200,
        entry = SteeneeDesc,
        forms = SingleSpecies(Species.Steenee),
    };
    public static readonly PokedexData Tsareena = new()
    {
        number = 763,
        name = "Tsareena",
        category = "Fruit",
        height = 120,
        weight = 21400,
        entry = TsareenaDesc,
        forms = SingleSpecies(Species.Tsareena),
    };
    public static readonly PokedexData Comfey = new()
    {
        number = 764,
        name = "Comfey",
        category = "Posy Picker",
        height = 10,
        weight = 300,
        entry = ComfeyDesc,
        forms = SingleSpecies(Species.Comfey),
    };
    public static readonly PokedexData Oranguru = new()
    {
        number = 765,
        name = "Oranguru",
        category = "Sage",
        height = 150,
        weight = 76000,
        entry = OranguruDesc,
        forms = SingleSpecies(Species.Oranguru),
    };
    public static readonly PokedexData Passimian = new()
    {
        number = 766,
        name = "Passimian",
        category = "Teamwork",
        height = 200,
        weight = 82800,
        entry = PassimianDesc,
        forms = SingleSpecies(Species.Passimian),
    };
    public static readonly PokedexData Wimpod = new()
    {
        number = 767,
        name = "Wimpod",
        category = "Turn Tail",
        height = 50,
        weight = 12000,
        entry = WimpodDesc,
        forms = SingleSpecies(Species.Wimpod),
    };
    public static readonly PokedexData Golisopod = new()
    {
        number = 768,
        name = "Golisopod",
        category = "Hard Scale",
        height = 200,
        weight = 108000,
        entry = GolisopodDesc,
        forms = SingleSpecies(Species.Golisopod),
    };
    public static readonly PokedexData Sandygast = new()
    {
        number = 769,
        name = "Sandygast",
        category = "Sand Heap",
        height = 50,
        weight = 70000,
        entry = SandygastDesc,
        forms = SingleSpecies(Species.Sandygast),
    };
    public static readonly PokedexData Palossand = new()
    {
        number = 770,
        name = "Palossand",
        category = "Sand Castle",
        height = 130,
        weight = 250000,
        entry = PalossandDesc,
        forms = SingleSpecies(Species.Palossand),
    };
    public static readonly PokedexData Pyukumuku = new()
    {
        number = 771,
        name = "Pyukumuku",
        category = "Sea Cucumber",
        height = 30,
        weight = 1200,
        entry = PyukumukuDesc,
        forms = SingleSpecies(Species.Pyukumuku),
    };
    public static readonly PokedexData TypeNull = new ()
	{
		number = 772,
		name = "Type: Null",
		category = "Synthetic",
		height = 190,
		weight = 120500,
		entry = TypeNullDesc,
        forms = SingleSpecies(Species.TypeNull),

    };
    public static readonly PokedexData Silvally = new()
    {
        number = 773,
        name = "Silvally",
        category = "Synthetic",
        height = 230,
        weight = 100500,
        entry = SilvallyDesc,
        forms = new[]
        {
            Species.SilvallyNormal,
            Species.SilvallyFighting,
            Species.SilvallyFlying,
            Species.SilvallyPoison,
            Species.SilvallyGround,
            Species.SilvallyRock,
            Species.SilvallyBug,
            Species.SilvallyGhost,
            Species.SilvallySteel,
            Species.SilvallyFire,
            Species.SilvallyWater,
            Species.SilvallyGrass,
            Species.SilvallyElectric,
            Species.SilvallyPsychic,
            Species.SilvallyIce,
            Species.SilvallyDragon,
            Species.SilvallyDark,
            Species.SilvallyFairy
        },
    };
    public static readonly PokedexData Minior = new()
    {
        number = 774,
        name = "Minior",
        category = "Meteor",
        height = 30,
        weight = 40000,
        entry = MiniorMeteorDesc,
        forms = new[]
        {
            Species.MiniorRedCore,
            Species.MiniorOrangeCore,
            Species.MiniorYellowCore,
            Species.MiniorGreenCore,
            Species.MiniorBlueCore,
            Species.MiniorIndigoCore,
            Species.MiniorVioletCore,
            Species.MiniorRedMeteor
        },
    };
    public static readonly PokedexData Komala = new()
    {
        number = 775,
        name = "Komala",
        category = "Drowsing",
        height = 40,
        weight = 19900,
        entry = KomalaDesc,
        forms = SingleSpecies(Species.Komala),
    };
    public static readonly PokedexData Turtonator = new()
    {
        number = 776,
        name = "Turtonator",
        category = "Blast Turtle",
        height = 200,
        weight = 212000,
        entry = TurtonatorDesc,
        forms = SingleSpecies(Species.Turtonator),
    };
    public static readonly PokedexData Togedemaru = new()
    {
        number = 777,
        name = "Togedemaru",
        category = "Roly-Poly",
        height = 30,
        weight = 3300,
        entry = TogedemaruDesc,
        forms = SingleSpecies(Species.Togedemaru),
    };
    public static readonly PokedexData Mimikyu = new()
    {
        number = 778,
        name = "Mimikyu",
        category = "Disguise",
        height = 20,
        weight = 700,
        entry = MimikyuDesc,
        forms = new[]
        {
            Species.MimikyuBase,
            Species.MimikyuBusted
        }
    };
    public static readonly PokedexData Bruxish = new()
    {
        number = 779,
        name = "Bruxish",
        category = "Gnash Teeth",
        height = 90,
        weight = 19000,
        entry = BruxishDesc,
        forms = SingleSpecies(Species.Bruxish),
    };
    public static readonly PokedexData Drampa = new()
    {
        number = 780,
        name = "Drampa",
        category = "Placid",
        height = 300,
        weight = 185000,
        entry = DrampaDesc,
        forms = SingleSpecies(Species.Drampa),
    };
    public static readonly PokedexData Dhelmise = new()
    {
        number = 781,
        name = "Dhelmise",
        category = "Sea Creeper",
        height = 390,
        weight = 210000,
        entry = DhelmiseDesc,
        forms = SingleSpecies(Species.Dhelmise),
    };
    public static readonly PokedexData JangmoO = new()
    {
        number = 782,
        name = "Jangmo O",
        category = "Scaly",
        height = 60,
        weight = 29700,
        entry = JangmoODesc,
        forms = SingleSpecies(Species.JangmoO),
    };
    public static readonly PokedexData HakamoO = new()
    {
        number = 783,
        name = "Hakamo O",
        category = "Scaly",
        height = 120,
        weight = 47000,
        entry = HakamoODesc,
        forms = SingleSpecies(Species.HakamoO),
    };
    public static readonly PokedexData KommoO = new()
    {
        number = 784,
        name = "Kommo O",
        category = "Scaly",
        height = 160,
        weight = 78200,
        entry = KommoODesc,
        forms = SingleSpecies(Species.KommoO),
    };
    public static readonly PokedexData TapuKoko = new()
    {
        number = 785,
        name = "Tapu Koko",
        category = "Land Spirit",
        height = 180,
        weight = 20500,
        entry = TapuKokoDesc,
        forms = SingleSpecies(Species.TapuKoko),
    };
    public static readonly PokedexData TapuLele = new()
    {
        number = 786,
        name = "Tapu Lele",
        category = "Land Spirit",
        height = 120,
        weight = 18600,
        entry = TapuLeleDesc,
        forms = SingleSpecies(Species.TapuLele),
    };
    public static readonly PokedexData TapuBulu = new()
    {
        number = 787,
        name = "Tapu Bulu",
        category = "Land Spirit",
        height = 190,
        weight = 45500,
        entry = TapuBuluDesc,
        forms = SingleSpecies(Species.TapuBulu),
    };
    public static readonly PokedexData TapuFini = new()
    {
        number = 788,
        name = "Tapu Fini",
        category = "Land Spirit",
        height = 130,
        weight = 21200,
        entry = TapuFiniDesc,
        forms = SingleSpecies(Species.TapuFini),
    };
    public static readonly PokedexData Cosmog = new()
    {
        number = 789,
        name = "Cosmog",
        category = "Nebula",
        height = 20,
        weight = 100,
        entry = CosmogDesc,
        forms = SingleSpecies(Species.Cosmog),
    };
    public static readonly PokedexData Cosmoem = new()
    {
        number = 790,
        name = "Cosmoem",
        category = "Protostar",
        height = 10,
        weight = 999900,
        entry = CosmoemDesc,
        forms = SingleSpecies(Species.Cosmoem),
    };
    public static readonly PokedexData Solgaleo = new()
    {
        number = 791,
        name = "Solgaleo",
        category = "Sunne",
        height = 340,
        weight = 230000,
        entry = SolgaleoDesc,
        forms = SingleSpecies(Species.Solgaleo),
    };
    public static readonly PokedexData Lunala = new()
    {
        number = 792,
        name = "Lunala",
        category = "Moone",
        height = 400,
        weight = 120000,
        entry = LunalaDesc,
        forms = SingleSpecies(Species.Lunala),
    };
    public static readonly PokedexData Nihilego = new()
    {
        number = 793,
        name = "Nihilego",
        category = "Parasite",
        height = 120,
        weight = 55500,
        entry = NihilegoDesc,
        forms = SingleSpecies(Species.Nihilego),
    };
    public static readonly PokedexData Buzzwole = new()
    {
        number = 794,
        name = "Buzzwole",
        category = "Swollen",
        height = 240,
        weight = 333600,
        entry = BuzzwoleDesc,
        forms = SingleSpecies(Species.Buzzwole),
    };
    public static readonly PokedexData Pheromosa = new()
    {
        number = 795,
        name = "Pheromosa",
        category = "Lissome",
        height = 180,
        weight = 25000,
        entry = PheromosaDesc,
        forms = SingleSpecies(Species.Pheromosa),
    };
    public static readonly PokedexData Xurkitree = new()
    {
        number = 796,
        name = "Xurkitree",
        category = "Glowing",
        height = 380,
        weight = 100000,
        entry = XurkitreeDesc,
        forms = SingleSpecies(Species.Xurkitree),
    };
    public static readonly PokedexData Celesteela = new()
    {
        number = 797,
        name = "Celesteela",
        category = "Launch",
        height = 920,
        weight = 999900,
        entry = CelesteelaDesc,
        forms = SingleSpecies(Species.Celesteela),
    };
    public static readonly PokedexData Kartana = new()
    {
        number = 798,
        name = "Kartana",
        category = "Drawn Sword",
        height = 30,
        weight = 100,
        entry = KartanaDesc,
        forms = SingleSpecies(Species.Kartana),
    };
    public static readonly PokedexData Guzzlord = new()
    {
        number = 799,
        name = "Guzzlord",
        category = "Junkivore",
        height = 550,
        weight = 888000,
        entry = GuzzlordDesc,
        forms = SingleSpecies(Species.Guzzlord),
    };
    public static readonly PokedexData Necrozma = new()
    {
        number = 800,
        name = "Necrozma",
        category = "Prism",
        height = 240,
        weight = 230000,
        entry = NecrozmaDesc,
        forms = new[]
        {
            Species.Necrozma,
            Species.NecrozmaDuskMane,
            Species.NecrozmaDawnWings,
            Species.NecrozmaUltra
        }
    };
    public static readonly PokedexData Magearna = new()
    {
        number = 801,
        name = "Magearna",
        category = "Artificial",
        height = 100,
        weight = 80500,
        entry = MagearnaDesc,
        forms = new[]
        {
            Species.MagearnaBase,
            Species.MagearnaOriginal
        },
    };
    public static readonly PokedexData Marshadow = new()
    {
        number = 802,
        name = "Marshadow",
        category = "Gloomdweller",
        height = 70,
        weight = 22200,
        entry = MarshadowDesc,
        forms = SingleSpecies(Species.Marshadow),
    };
    public static readonly PokedexData Poipole = new()
    {
        number = 803,
        name = "Poipole",
        category = "Poison Pin",
        height = 60,
        weight = 1800,
        entry = PoipoleDesc,
        forms = SingleSpecies(Species.Poipole),
    };
    public static readonly PokedexData Naganadel = new()
    {
        number = 804,
        name = "Naganadel",
        category = "Poison Pin",
        height = 360,
        weight = 150000,
        entry = NaganadelDesc,
        forms = SingleSpecies(Species.Naganadel),
    };
    public static readonly PokedexData Stakataka = new()
    {
        number = 805,
        name = "Stakataka",
        category = "Rampart",
        height = 550,
        weight = 820000,
        entry = StakatakaDesc,
        forms = SingleSpecies(Species.Stakataka),
    };
    public static readonly PokedexData Blacephalon = new()
    {
        number = 806,
        name = "Blacephalon",
        category = "Fireworks",
        height = 180,
        weight = 13000,
        entry = BlacephalonDesc,
        forms = SingleSpecies(Species.Blacephalon),
    };
    public static readonly PokedexData Zeraora = new()
    {
        number = 807,
        name = "Zeraora",
        category = "Thunderclap",
        height = 150,
        weight = 44500,
        entry = ZeraoraDesc,
        forms = SingleSpecies(Species.Zeraora),
    };
    public static readonly PokedexData Meltan = new()
    {
        number = 808,
        name = "Meltan",
        category = "Hex Nut",
        height = 20,
        weight = 8000,
        entry = MeltanDesc,
        forms = SingleSpecies(Species.Meltan),
    };
    public static readonly PokedexData Melmetal = new()
    {
        number = 809,
        name = "Melmetal",
        category = "Hex Nut",
        height = 250,
        weight = 80000,
        entry = MelmetalDesc,
        forms = SingleSpecies(Species.Melmetal),
    };

}