﻿using static SpeciesData;

public static partial class Pokedex
{
    public static readonly PokedexData Bulbasaur = new()
    {
        number = 1,
        name = "Bulbasaur",
        category = "Seed",
        height = 70,
        weight = 6900,
        entry = BulbasaurDesc,
        forms = SingleSpecies(SpeciesID.Bulbasaur),
    };
    public static readonly PokedexData Ivysaur = new()
    {
        number = 2,
        name = "Ivysaur",
        category = "Seed",
        height = 100,
        weight = 13000,
        entry = IvysaurDesc,
        forms = SingleSpecies(SpeciesID.Ivysaur),
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
            SpeciesID.Venusaur,
            SpeciesID.VenusaurMega
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
        forms = SingleSpecies(SpeciesID.Charmander),
    };
    public static readonly PokedexData Charmeleon = new()
    {
        number = 5,
        name = "Charmeleon",
        category = "Flame",
        height = 110,
        weight = 19000,
        entry = CharmeleonDesc,
        forms = SingleSpecies(SpeciesID.Charmeleon),
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
            SpeciesID.Charizard,
            SpeciesID.CharizardMegaX,
            SpeciesID.CharizardMegaY
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
        forms = SingleSpecies(SpeciesID.Squirtle),
    };
    public static readonly PokedexData Wartortle = new()
    {
        number = 8,
        name = "Wartortle",
        category = "Turtle",
        height = 100,
        weight = 22500,
        entry = WartortleDesc,
        forms = SingleSpecies(SpeciesID.Wartortle),
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
            SpeciesID.Blastoise,
            SpeciesID.BlastoiseMega
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
        forms = SingleSpecies(SpeciesID.Caterpie),
    };
    public static readonly PokedexData Metapod = new()
    {
        number = 11,
        name = "Metapod",
        category = "Cocoon",
        height = 70,
        weight = 9900,
        entry = MetapodDesc,
        forms = SingleSpecies(SpeciesID.Metapod),
    };
    public static readonly PokedexData Butterfree = new()
    {
        number = 12,
        name = "Butterfree",
        category = "Butterfly",
        height = 110,
        weight = 32000,
        entry = ButterfreeDesc,
        forms = SingleSpecies(SpeciesID.Butterfree),
    };
    public static readonly PokedexData Weedle = new()
    {
        number = 13,
        name = "Weedle",
        category = "Hairy Bug",
        height = 30,
        weight = 3200,
        entry = WeedleDesc,
        forms = SingleSpecies(SpeciesID.Weedle),
    };
    public static readonly PokedexData Kakuna = new()
    {
        number = 14,
        name = "Kakuna",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = KakunaDesc,
        forms = SingleSpecies(SpeciesID.Kakuna),
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
            SpeciesID.Beedrill,
            SpeciesID.BeedrillMega
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
        forms = SingleSpecies(SpeciesID.Pidgey),
    };
    public static readonly PokedexData Pidgeotto = new()
    {
        number = 17,
        name = "Pidgeotto",
        category = "Bird",
        height = 110,
        weight = 30000,
        entry = PidgeottoDesc,
        forms = SingleSpecies(SpeciesID.Pidgeotto),
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
            SpeciesID.Pidgeot,
            SpeciesID.PidgeotMega
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
            SpeciesID.Rattata,
            SpeciesID.RattataAlola
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
            SpeciesID.Raticate,
            SpeciesID.RaticateAlola
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
        forms = SingleSpecies(SpeciesID.Spearow),
    };
    public static readonly PokedexData Fearow = new()
    {
        number = 22,
        name = "Fearow",
        category = "Beak",
        height = 120,
        weight = 38000,
        entry = FearowDesc,
        forms = SingleSpecies(SpeciesID.Fearow),
    };
    public static readonly PokedexData Ekans = new()
    {
        number = 23,
        name = "Ekans",
        category = "Snake",
        height = 200,
        weight = 6900,
        entry = EkansDesc,
        forms = SingleSpecies(SpeciesID.Ekans),
    };
    public static readonly PokedexData Arbok = new()
    {
        number = 24,
        name = "Arbok",
        category = "Cobra",
        height = 350,
        weight = 65000,
        entry = ArbokDesc,
        forms = SingleSpecies(SpeciesID.Arbok),
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
            SpeciesID.Pikachu,
            SpeciesID.PikachuCosplay,
            SpeciesID.PikachuRockStar,
            SpeciesID.PikachuBelle,
            SpeciesID.PikachuPopStar,
            SpeciesID.PikachuPhD,
            SpeciesID.PikachuLibre,
            SpeciesID.PikachuOriginal,
            SpeciesID.PikachuHoenn,
            SpeciesID.PikachuSinnoh,
            SpeciesID.PikachuUnova,
            SpeciesID.PikachuKalos,
            SpeciesID.PikachuAlolaCap,
            SpeciesID.PikachuPartnerCap,
            SpeciesID.PikachuWorld,
            SpeciesID.PikachuPartner
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
            SpeciesID.Raichu,
            SpeciesID.RaichuAlola
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
            SpeciesID.Sandshrew,
            SpeciesID.SandshrewAlola
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
            SpeciesID.Sandslash,
            SpeciesID.SandslashAlola
        }
    };
    public static readonly PokedexData NidoranF = new()
    {
        number = 29,
        name = "Nidoran",
        category = "Poison Pin",
        height = 40,
        weight = 7000,
        entry = NidoranFDesc,
        forms = SingleSpecies(SpeciesID.NidoranF),

    };
    public static readonly PokedexData Nidorina = new()
    {
        number = 30,
        name = "Nidorina",
        category = "Poison Pin",
        height = 80,
        weight = 20000,
        entry = NidorinaDesc,
        forms = SingleSpecies(SpeciesID.Nidorina),
    };
    public static readonly PokedexData Nidoqueen = new()
    {
        number = 31,
        name = "Nidoqueen",
        category = "Drill",
        height = 130,
        weight = 60000,
        entry = NidoqueenDesc,
        forms = SingleSpecies(SpeciesID.Nidoqueen),
    };
    public static readonly PokedexData NidoranM = new()
    {
        number = 32,
        name = "Nidoran",
        category = "Poison Pin",
        height = 50,
        weight = 9000,
        entry = NidoranMDesc,
        forms = SingleSpecies(SpeciesID.NidoranM),
    };
    public static readonly PokedexData Nidorino = new()
    {
        number = 33,
        name = "Nidorino",
        category = "Poison Pin",
        height = 90,
        weight = 19500,
        entry = NidorinoDesc,
        forms = SingleSpecies(SpeciesID.Nidorino),
    };
    public static readonly PokedexData Nidoking = new()
    {
        number = 34,
        name = "Nidoking",
        category = "Drill",
        height = 140,
        weight = 62000,
        entry = NidokingDesc,
        forms = SingleSpecies(SpeciesID.Nidoking),
    };
    public static readonly PokedexData Clefairy = new()
    {
        number = 35,
        name = "Clefairy",
        category = "Fairy",
        height = 60,
        weight = 7500,
        entry = ClefairyDesc,
        forms = SingleSpecies(SpeciesID.Clefairy),
    };
    public static readonly PokedexData Clefable = new()
    {
        number = 36,
        name = "Clefable",
        category = "Fairy",
        height = 130,
        weight = 40000,
        entry = ClefableDesc,
        forms = SingleSpecies(SpeciesID.Clefable),
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
            SpeciesID.Vulpix,
            SpeciesID.VulpixAlola
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
            SpeciesID.Ninetales,
            SpeciesID.NinetalesAlola
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
        forms = SingleSpecies(SpeciesID.Jigglypuff),
    };
    public static readonly PokedexData Wigglytuff = new()
    {
        number = 40,
        name = "Wigglytuff",
        category = "Balloon",
        height = 100,
        weight = 12000,
        entry = WigglytuffDesc,
        forms = SingleSpecies(SpeciesID.Wigglytuff),
    };
    public static readonly PokedexData Zubat = new()
    {
        number = 41,
        name = "Zubat",
        category = "Bat",
        height = 80,
        weight = 7500,
        entry = ZubatDesc,
        forms = SingleSpecies(SpeciesID.Zubat),
    };
    public static readonly PokedexData Golbat = new()
    {
        number = 42,
        name = "Golbat",
        category = "Bat",
        height = 160,
        weight = 55000,
        entry = GolbatDesc,
        forms = SingleSpecies(SpeciesID.Golbat),
    };
    public static readonly PokedexData Oddish = new()
    {
        number = 43,
        name = "Oddish",
        category = "Weed",
        height = 50,
        weight = 5400,
        entry = OddishDesc,
        forms = SingleSpecies(SpeciesID.Oddish),
    };
    public static readonly PokedexData Gloom = new()
    {
        number = 44,
        name = "Gloom",
        category = "Weed",
        height = 80,
        weight = 8600,
        entry = GloomDesc,
        forms = SingleSpecies(SpeciesID.Gloom),
    };
    public static readonly PokedexData Vileplume = new()
    {
        number = 45,
        name = "Vileplume",
        category = "Flower",
        height = 120,
        weight = 18600,
        entry = VileplumeDesc,
        forms = SingleSpecies(SpeciesID.Vileplume),
    };
    public static readonly PokedexData Paras = new()
    {
        number = 46,
        name = "Paras",
        category = "Mushroom",
        height = 30,
        weight = 5400,
        entry = ParasDesc,
        forms = SingleSpecies(SpeciesID.Paras),
    };
    public static readonly PokedexData Parasect = new()
    {
        number = 47,
        name = "Parasect",
        category = "Mushroom",
        height = 100,
        weight = 29500,
        entry = ParasectDesc,
        forms = SingleSpecies(SpeciesID.Parasect),
    };
    public static readonly PokedexData Venonat = new()
    {
        number = 48,
        name = "Venonat",
        category = "Insect",
        height = 100,
        weight = 30000,
        entry = VenonatDesc,
        forms = SingleSpecies(SpeciesID.Venonat),
    };
    public static readonly PokedexData Venomoth = new()
    {
        number = 49,
        name = "Venomoth",
        category = "Poison Moth",
        height = 150,
        weight = 12500,
        entry = VenomothDesc,
        forms = SingleSpecies(SpeciesID.Venomoth),
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
            SpeciesID.Diglett,
            SpeciesID.DiglettAlola
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
            SpeciesID.Dugtrio,
            SpeciesID.DugtrioAlola
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
            SpeciesID.Meowth,
            SpeciesID.MeowthAlola,
            SpeciesID.MeowthGalar
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
            SpeciesID.Persian,
            SpeciesID.PersianAlola
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
        forms = SingleSpecies(SpeciesID.Psyduck),
    };
    public static readonly PokedexData Golduck = new()
    {
        number = 55,
        name = "Golduck",
        category = "Duck",
        height = 170,
        weight = 76600,
        entry = GolduckDesc,
        forms = SingleSpecies(SpeciesID.Golduck),
    };
    public static readonly PokedexData Mankey = new()
    {
        number = 56,
        name = "Mankey",
        category = "Pig Monkey",
        height = 50,
        weight = 28000,
        entry = MankeyDesc,
        forms = SingleSpecies(SpeciesID.Mankey),
    };
    public static readonly PokedexData Primeape = new()
    {
        number = 57,
        name = "Primeape",
        category = "Pig Monkey",
        height = 100,
        weight = 32000,
        entry = PrimeapeDesc,
        forms = SingleSpecies(SpeciesID.Primeape),
    };
    public static readonly PokedexData Growlithe = new()
    {
        number = 58,
        name = "Growlithe",
        category = "Puppy",
        height = 70,
        weight = 19000,
        entry = GrowlitheDesc,
        forms = new[]
        {
            SpeciesID.Growlithe,
            SpeciesID.GrowlitheHisui
        }
    };
    public static readonly PokedexData Arcanine = new()
    {
        number = 59,
        name = "Arcanine",
        category = "Legendary",
        height = 190,
        weight = 155000,
        entry = ArcanineDesc,
        forms = new[]
        {
            SpeciesID.Arcanine,
            SpeciesID.ArcanineHisui
        }
    };
    public static readonly PokedexData Poliwag = new()
    {
        number = 60,
        name = "Poliwag",
        category = "Tadpole",
        height = 60,
        weight = 12400,
        entry = PoliwagDesc,
        forms = SingleSpecies(SpeciesID.Poliwag),
    };
    public static readonly PokedexData Poliwhirl = new()
    {
        number = 61,
        name = "Poliwhirl",
        category = "Tadpole",
        height = 100,
        weight = 20000,
        entry = PoliwhirlDesc,
        forms = SingleSpecies(SpeciesID.Poliwhirl),
    };
    public static readonly PokedexData Poliwrath = new()
    {
        number = 62,
        name = "Poliwrath",
        category = "Tadpole",
        height = 130,
        weight = 54000,
        entry = PoliwrathDesc,
        forms = SingleSpecies(SpeciesID.Poliwrath),
    };
    public static readonly PokedexData Abra = new()
    {
        number = 63,
        name = "Abra",
        category = "Psi",
        height = 90,
        weight = 19500,
        entry = AbraDesc,
        forms = SingleSpecies(SpeciesID.Abra),
    };
    public static readonly PokedexData Kadabra = new()
    {
        number = 64,
        name = "Kadabra",
        category = "Psi",
        height = 130,
        weight = 56500,
        entry = KadabraDesc,
        forms = SingleSpecies(SpeciesID.Kadabra),
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
            SpeciesID.Alakazam,
            SpeciesID.AlakazamMega
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
        forms = SingleSpecies(SpeciesID.Machop),
    };
    public static readonly PokedexData Machoke = new()
    {
        number = 67,
        name = "Machoke",
        category = "Superpower",
        height = 150,
        weight = 70500,
        entry = MachokeDesc,
        forms = SingleSpecies(SpeciesID.Machoke),
    };
    public static readonly PokedexData Machamp = new()
    {
        number = 68,
        name = "Machamp",
        category = "Superpower",
        height = 160,
        weight = 130000,
        entry = MachampDesc,
        forms = SingleSpecies(SpeciesID.Machamp),
    };
    public static readonly PokedexData Bellsprout = new()
    {
        number = 69,
        name = "Bellsprout",
        category = "Flower",
        height = 70,
        weight = 4000,
        entry = BellsproutDesc,
        forms = SingleSpecies(SpeciesID.Bellsprout),
    };
    public static readonly PokedexData Weepinbell = new()
    {
        number = 70,
        name = "Weepinbell",
        category = "Flycatcher",
        height = 100,
        weight = 6400,
        entry = WeepinbellDesc,
        forms = SingleSpecies(SpeciesID.Weepinbell),
    };
    public static readonly PokedexData Victreebel = new()
    {
        number = 71,
        name = "Victreebel",
        category = "Flycatcher",
        height = 170,
        weight = 15500,
        entry = VictreebelDesc,
        forms = SingleSpecies(SpeciesID.Victreebel),
    };
    public static readonly PokedexData Tentacool = new()
    {
        number = 72,
        name = "Tentacool",
        category = "Jellyfish",
        height = 90,
        weight = 45500,
        entry = TentacoolDesc,
        forms = SingleSpecies(SpeciesID.Tentacool),
    };
    public static readonly PokedexData Tentacruel = new()
    {
        number = 73,
        name = "Tentacruel",
        category = "Jellyfish",
        height = 160,
        weight = 55000,
        entry = TentacruelDesc,
        forms = SingleSpecies(SpeciesID.Tentacruel),
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
            SpeciesID.Geodude,
            SpeciesID.GeodudeAlola
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
            SpeciesID.Graveler,
            SpeciesID.GravelerAlola
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
            SpeciesID.Golem,
            SpeciesID.GolemAlola
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
        forms = new[]
        {
            SpeciesID.Ponyta,
            SpeciesID.PonytaGalar
        }
    };
    public static readonly PokedexData Rapidash = new()
    {
        number = 78,
        name = "Rapidash",
        category = "Fire Horse",
        height = 170,
        weight = 95000,
        entry = RapidashDesc,
        forms = new[]
        {
            SpeciesID.Rapidash,
            SpeciesID.RapidashGalar
        }
    };
    public static readonly PokedexData Slowpoke = new()
    {
        number = 79,
        name = "Slowpoke",
        category = "Dopey",
        height = 120,
        weight = 36000,
        entry = SlowpokeDesc,
        forms = new[]
        {
            SpeciesID.Slowpoke,
            SpeciesID.SlowpokeGalar
        }
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
            SpeciesID.Slowbro,
            SpeciesID.SlowbroMega,
            SpeciesID.SlowbroGalar
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
        forms = SingleSpecies(SpeciesID.Magnemite),
    };
    public static readonly PokedexData Magneton = new()
    {
        number = 82,
        name = "Magneton",
        category = "Magnet",
        height = 100,
        weight = 60000,
        entry = MagnetonDesc,
        forms = SingleSpecies(SpeciesID.Magneton),
    };
    public static readonly PokedexData Farfetchd = new()
    {
        number = 83,
        name = "Farfetchd",
        category = "Wild Duck",
        height = 80,
        weight = 15000,
        entry = FarfetchdDesc,
        forms = new[]
        {
            SpeciesID.Farfetchd,
            SpeciesID.FarfetchdGalar
        }
    };
    public static readonly PokedexData Doduo = new()
    {
        number = 84,
        name = "Doduo",
        category = "Twin Bird",
        height = 140,
        weight = 39200,
        entry = DoduoDesc,
        forms = SingleSpecies(SpeciesID.Doduo),
    };
    public static readonly PokedexData Dodrio = new()
    {
        number = 85,
        name = "Dodrio",
        category = "Triple Bird",
        height = 180,
        weight = 85200,
        entry = DodrioDesc,
        forms = SingleSpecies(SpeciesID.Dodrio),
    };
    public static readonly PokedexData Seel = new()
    {
        number = 86,
        name = "Seel",
        category = "SeaLion",
        height = 110,
        weight = 90000,
        entry = SeelDesc,
        forms = SingleSpecies(SpeciesID.Seel),
    };
    public static readonly PokedexData Dewgong = new()
    {
        number = 87,
        name = "Dewgong",
        category = "SeaLion",
        height = 170,
        weight = 120000,
        entry = DewgongDesc,
        forms = SingleSpecies(SpeciesID.Dewgong),
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
            SpeciesID.Grimer,
            SpeciesID.GrimerAlola
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
            SpeciesID.Muk,
            SpeciesID.MukAlola
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
        forms = SingleSpecies(SpeciesID.Shellder),
    };
    public static readonly PokedexData Cloyster = new()
    {
        number = 91,
        name = "Cloyster",
        category = "Bivalve",
        height = 150,
        weight = 132500,
        entry = CloysterDesc,
        forms = SingleSpecies(SpeciesID.Cloyster),
    };
    public static readonly PokedexData Gastly = new()
    {
        number = 92,
        name = "Gastly",
        category = "Gas",
        height = 130,
        weight = 100,
        entry = GastlyDesc,
        forms = SingleSpecies(SpeciesID.Gastly),
    };
    public static readonly PokedexData Haunter = new()
    {
        number = 93,
        name = "Haunter",
        category = "Gas",
        height = 160,
        weight = 100,
        entry = HaunterDesc,
        forms = SingleSpecies(SpeciesID.Haunter),
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
            SpeciesID.Gengar,
            SpeciesID.GengarMega
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
        forms = SingleSpecies(SpeciesID.Onix),
    };
    public static readonly PokedexData Drowzee = new()
    {
        number = 96,
        name = "Drowzee",
        category = "Hypnosis",
        height = 100,
        weight = 32400,
        entry = DrowzeeDesc,
        forms = SingleSpecies(SpeciesID.Drowzee),
    };
    public static readonly PokedexData Hypno = new()
    {
        number = 97,
        name = "Hypno",
        category = "Hypnosis",
        height = 160,
        weight = 75600,
        entry = HypnoDesc,
        forms = SingleSpecies(SpeciesID.Hypno),
    };
    public static readonly PokedexData Krabby = new()
    {
        number = 98,
        name = "Krabby",
        category = "River Crab",
        height = 40,
        weight = 6500,
        entry = KrabbyDesc,
        forms = SingleSpecies(SpeciesID.Krabby),
    };
    public static readonly PokedexData Kingler = new()
    {
        number = 99,
        name = "Kingler",
        category = "Pincer",
        height = 130,
        weight = 60000,
        entry = KinglerDesc,
        forms = SingleSpecies(SpeciesID.Kingler),
    };
    public static readonly PokedexData Voltorb = new()
    {
        number = 100,
        name = "Voltorb",
        category = "Ball",
        height = 50,
        weight = 10400,
        entry = VoltorbDesc,
        forms = new[]
        {
            SpeciesID.Voltorb,
            SpeciesID.VoltorbHisui
        }
    };
    public static readonly PokedexData Electrode = new()
    {
        number = 101,
        name = "Electrode",
        category = "Ball",
        height = 120,
        weight = 66600,
        entry = ElectrodeDesc,
        forms = SingleSpecies(SpeciesID.Electrode),
    };
    public static readonly PokedexData Exeggcute = new()
    {
        number = 102,
        name = "Exeggcute",
        category = "Egg",
        height = 40,
        weight = 2500,
        entry = ExeggcuteDesc,
        forms = SingleSpecies(SpeciesID.Exeggcute),
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
            SpeciesID.Exeggutor,
            SpeciesID.ExeggutorAlola
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
        forms = SingleSpecies(SpeciesID.Cubone),
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
            SpeciesID.Marowak,
            SpeciesID.MarowakAlola
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
        forms = SingleSpecies(SpeciesID.Hitmonlee),
    };
    public static readonly PokedexData Hitmonchan = new()
    {
        number = 107,
        name = "Hitmonchan",
        category = "Punching",
        height = 140,
        weight = 50200,
        entry = HitmonchanDesc,
        forms = SingleSpecies(SpeciesID.Hitmonchan),
    };
    public static readonly PokedexData Lickitung = new()
    {
        number = 108,
        name = "Lickitung",
        category = "Licking",
        height = 120,
        weight = 65500,
        entry = LickitungDesc,
        forms = SingleSpecies(SpeciesID.Lickitung),
    };
    public static readonly PokedexData Koffing = new()
    {
        number = 109,
        name = "Koffing",
        category = "PoisonGas",
        height = 60,
        weight = 1000,
        entry = KoffingDesc,
        forms = SingleSpecies(SpeciesID.Koffing),
    };
    public static readonly PokedexData Weezing = new()
    {
        number = 110,
        name = "Weezing",
        category = "PoisonGas",
        height = 120,
        weight = 9500,
        entry = WeezingDesc,
        forms = new[]
        {
            SpeciesID.Weezing,
            SpeciesID.WeezingGalar,
        }
    };
    public static readonly PokedexData Rhyhorn = new()
    {
        number = 111,
        name = "Rhyhorn",
        category = "Spikes",
        height = 100,
        weight = 115000,
        entry = RhyhornDesc,
        forms = SingleSpecies(SpeciesID.Rhyhorn),
    };
    public static readonly PokedexData Rhydon = new()
    {
        number = 112,
        name = "Rhydon",
        category = "Drill",
        height = 190,
        weight = 120000,
        entry = RhydonDesc,
        forms = SingleSpecies(SpeciesID.Rhydon),
    };
    public static readonly PokedexData Chansey = new()
    {
        number = 113,
        name = "Chansey",
        category = "Egg",
        height = 110,
        weight = 34600,
        entry = ChanseyDesc,
        forms = SingleSpecies(SpeciesID.Chansey),
    };
    public static readonly PokedexData Tangela = new()
    {
        number = 114,
        name = "Tangela",
        category = "Vine",
        height = 100,
        weight = 35000,
        entry = TangelaDesc,
        forms = SingleSpecies(SpeciesID.Tangela),
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
            SpeciesID.Kangaskhan,
            SpeciesID.KangaskhanMega
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
        forms = SingleSpecies(SpeciesID.Horsea),
    };
    public static readonly PokedexData Seadra = new()
    {
        number = 117,
        name = "Seadra",
        category = "Dragon",
        height = 120,
        weight = 25000,
        entry = SeadraDesc,
        forms = SingleSpecies(SpeciesID.Seadra),
    };
    public static readonly PokedexData Goldeen = new()
    {
        number = 118,
        name = "Goldeen",
        category = "Goldfish",
        height = 60,
        weight = 15000,
        entry = GoldeenDesc,
        forms = SingleSpecies(SpeciesID.Goldeen),
    };
    public static readonly PokedexData Seaking = new()
    {
        number = 119,
        name = "Seaking",
        category = "Goldfish",
        height = 130,
        weight = 39000,
        entry = SeakingDesc,
        forms = SingleSpecies(SpeciesID.Seaking),
    };
    public static readonly PokedexData Staryu = new()
    {
        number = 120,
        name = "Staryu",
        category = "StarShape",
        height = 80,
        weight = 34500,
        entry = StaryuDesc,
        forms = SingleSpecies(SpeciesID.Staryu),
    };
    public static readonly PokedexData Starmie = new()
    {
        number = 121,
        name = "Starmie",
        category = "Mysterious",
        height = 110,
        weight = 80000,
        entry = StarmieDesc,
        forms = SingleSpecies(SpeciesID.Starmie),
    };
    public static readonly PokedexData MrMime = new()
    {
        number = 122,
        name = "Mr. Mime",
        category = "Barrier",
        height = 130,
        weight = 54500,
        entry = MrMimeDesc,
        forms = new[]
        {
            SpeciesID.MrMime,
            SpeciesID.MrMimeGalar,
        }
    };
    public static readonly PokedexData Scyther = new()
    {
        number = 123,
        name = "Scyther",
        category = "Mantis",
        height = 150,
        weight = 56000,
        entry = ScytherDesc,
        forms = SingleSpecies(SpeciesID.Scyther),
    };
    public static readonly PokedexData Jynx = new()
    {
        number = 124,
        name = "Jynx",
        category = "HumanShape",
        height = 140,
        weight = 40600,
        entry = JynxDesc,
        forms = SingleSpecies(SpeciesID.Jynx),
    };
    public static readonly PokedexData Electabuzz = new()
    {
        number = 125,
        name = "Electabuzz",
        category = "Electric",
        height = 110,
        weight = 30000,
        entry = ElectabuzzDesc,
        forms = SingleSpecies(SpeciesID.Electabuzz),
    };
    public static readonly PokedexData Magmar = new()
    {
        number = 126,
        name = "Magmar",
        category = "Spitfire",
        height = 130,
        weight = 44500,
        entry = MagmarDesc,
        forms = SingleSpecies(SpeciesID.Magmar),
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
            SpeciesID.Pinsir,
            SpeciesID.PinsirMega
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
        forms = SingleSpecies(SpeciesID.Tauros),
    };
    public static readonly PokedexData Magikarp = new()
    {
        number = 129,
        name = "Magikarp",
        category = "Fish",
        height = 90,
        weight = 10000,
        entry = MagikarpDesc,
        forms = SingleSpecies(SpeciesID.Magikarp),
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
            SpeciesID.Gyarados,
            SpeciesID.GyaradosMega
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
        forms = SingleSpecies(SpeciesID.Lapras),
    };
    public static readonly PokedexData Ditto = new()
    {
        number = 132,
        name = "Ditto",
        category = "Transform",
        height = 30,
        weight = 4000,
        entry = DittoDesc,
        forms = SingleSpecies(SpeciesID.Ditto),
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
            SpeciesID.Eevee,
            SpeciesID.EeveePartner
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
        forms = SingleSpecies(SpeciesID.Vaporeon),
    };
    public static readonly PokedexData Jolteon = new()
    {
        number = 135,
        name = "Jolteon",
        category = "Lightning",
        height = 80,
        weight = 24500,
        entry = JolteonDesc,
        forms = SingleSpecies(SpeciesID.Jolteon),
    };
    public static readonly PokedexData Flareon = new()
    {
        number = 136,
        name = "Flareon",
        category = "Flame",
        height = 90,
        weight = 25000,
        entry = FlareonDesc,
        forms = SingleSpecies(SpeciesID.Flareon),
    };
    public static readonly PokedexData Porygon = new()
    {
        number = 137,
        name = "Porygon",
        category = "Virtual",
        height = 80,
        weight = 36500,
        entry = PorygonDesc,
        forms = SingleSpecies(SpeciesID.Porygon),
    };
    public static readonly PokedexData Omanyte = new()
    {
        number = 138,
        name = "Omanyte",
        category = "Spiral",
        height = 40,
        weight = 7500,
        entry = OmanyteDesc,
        forms = SingleSpecies(SpeciesID.Omanyte),
    };
    public static readonly PokedexData Omastar = new()
    {
        number = 139,
        name = "Omastar",
        category = "Spiral",
        height = 100,
        weight = 35000,
        entry = OmastarDesc,
        forms = SingleSpecies(SpeciesID.Omastar),
    };
    public static readonly PokedexData Kabuto = new()
    {
        number = 140,
        name = "Kabuto",
        category = "Shellfish",
        height = 50,
        weight = 11500,
        entry = KabutoDesc,
        forms = SingleSpecies(SpeciesID.Kabuto),
    };
    public static readonly PokedexData Kabutops = new()
    {
        number = 141,
        name = "Kabutops",
        category = "Shellfish",
        height = 130,
        weight = 40500,
        entry = KabutopsDesc,
        forms = SingleSpecies(SpeciesID.Kabutops),
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
            SpeciesID.Aerodactyl,
            SpeciesID.AerodactylMega
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
        forms = SingleSpecies(SpeciesID.Snorlax),
    };
    public static readonly PokedexData Articuno = new()
    {
        number = 144,
        name = "Articuno",
        category = "Freeze",
        height = 170,
        weight = 55400,
        entry = ArticunoDesc,
        forms = new[]
        {
            SpeciesID.Articuno,
            SpeciesID.ArticunoGalar
        }
    };
    public static readonly PokedexData Zapdos = new()
    {
        number = 145,
        name = "Zapdos",
        category = "Electric",
        height = 160,
        weight = 52600,
        entry = ZapdosDesc,
        forms = new[]
        {
            SpeciesID.Zapdos,
            SpeciesID.ZapdosGalar
        }
    };
    public static readonly PokedexData Moltres = new()
    {
        number = 146,
        name = "Moltres",
        category = "Flame",
        height = 200,
        weight = 60000,
        entry = MoltresDesc,
        forms = new[]
        {
            SpeciesID.Moltres,
            SpeciesID.MoltresGalar
        }
    };
    public static readonly PokedexData Dratini = new()
    {
        number = 147,
        name = "Dratini",
        category = "Dragon",
        height = 180,
        weight = 3300,
        entry = DratiniDesc,
        forms = SingleSpecies(SpeciesID.Dratini),
    };
    public static readonly PokedexData Dragonair = new()
    {
        number = 148,
        name = "Dragonair",
        category = "Dragon",
        height = 400,
        weight = 16500,
        entry = DragonairDesc,
        forms = SingleSpecies(SpeciesID.Dragonair),
    };
    public static readonly PokedexData Dragonite = new()
    {
        number = 149,
        name = "Dragonite",
        category = "Dragon",
        height = 220,
        weight = 210000,
        entry = DragoniteDesc,
        forms = SingleSpecies(SpeciesID.Dragonite),
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
            SpeciesID.Mewtwo,
            SpeciesID.MewtwoMegaX,
            SpeciesID.MewtwoMegaY
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
        forms = SingleSpecies(SpeciesID.Mew),
    };
    public static readonly PokedexData Chikorita = new()
    {
        number = 152,
        name = "Chikorita",
        category = "Leaf",
        height = 90,
        weight = 6400,
        entry = ChikoritaDesc,
        forms = SingleSpecies(SpeciesID.Chikorita),
    };
    public static readonly PokedexData Bayleef = new()
    {
        number = 153,
        name = "Bayleef",
        category = "Leaf",
        height = 120,
        weight = 15800,
        entry = BayleefDesc,
        forms = SingleSpecies(SpeciesID.Bayleef),
    };
    public static readonly PokedexData Meganium = new()
    {
        number = 154,
        name = "Meganium",
        category = "Herb",
        height = 180,
        weight = 100500,
        entry = MeganiumDesc,
        forms = SingleSpecies(SpeciesID.Meganium),
    };
    public static readonly PokedexData Cyndaquil = new()
    {
        number = 155,
        name = "Cyndaquil",
        category = "Fire Mouse",
        height = 50,
        weight = 7900,
        entry = CyndaquilDesc,
        forms = SingleSpecies(SpeciesID.Cyndaquil),
    };
    public static readonly PokedexData Quilava = new()
    {
        number = 156,
        name = "Quilava",
        category = "Volcano",
        height = 90,
        weight = 19000,
        entry = QuilavaDesc,
        forms = SingleSpecies(SpeciesID.Quilava),
    };
    public static readonly PokedexData Typhlosion = new()
    {
        number = 157,
        name = "Typhlosion",
        category = "Volcano",
        height = 170,
        weight = 79500,
        entry = TyphlosionDesc,
        forms = new[]
        {
            SpeciesID.Typhlosion,
            SpeciesID.TyphlosionHisui
        }
    };
    public static readonly PokedexData Totodile = new()
    {
        number = 158,
        name = "Totodile",
        category = "Big Jaw",
        height = 60,
        weight = 9500,
        entry = TotodileDesc,
        forms = SingleSpecies(SpeciesID.Totodile),
    };
    public static readonly PokedexData Croconaw = new()
    {
        number = 159,
        name = "Croconaw",
        category = "Big Jaw",
        height = 110,
        weight = 25000,
        entry = CroconawDesc,
        forms = SingleSpecies(SpeciesID.Croconaw),
    };
    public static readonly PokedexData Feraligatr = new()
    {
        number = 160,
        name = "Feraligatr",
        category = "Big Jaw",
        height = 230,
        weight = 88800,
        entry = FeraligatrDesc,
        forms = SingleSpecies(SpeciesID.Feraligatr),
    };
    public static readonly PokedexData Sentret = new()
    {
        number = 161,
        name = "Sentret",
        category = "Scout",
        height = 80,
        weight = 6000,
        entry = SentretDesc,
        forms = SingleSpecies(SpeciesID.Sentret),
    };
    public static readonly PokedexData Furret = new()
    {
        number = 162,
        name = "Furret",
        category = "Long Body",
        height = 180,
        weight = 32500,
        entry = FurretDesc,
        forms = SingleSpecies(SpeciesID.Furret),
    };
    public static readonly PokedexData Hoothoot = new()
    {
        number = 163,
        name = "Hoothoot",
        category = "Owl",
        height = 70,
        weight = 21200,
        entry = HoothootDesc,
        forms = SingleSpecies(SpeciesID.Hoothoot),
    };
    public static readonly PokedexData Noctowl = new()
    {
        number = 164,
        name = "Noctowl",
        category = "Owl",
        height = 160,
        weight = 40800,
        entry = NoctowlDesc,
        forms = SingleSpecies(SpeciesID.Noctowl),
    };
    public static readonly PokedexData Ledyba = new()
    {
        number = 165,
        name = "Ledyba",
        category = "Five Star",
        height = 100,
        weight = 10800,
        entry = LedybaDesc,
        forms = SingleSpecies(SpeciesID.Ledyba),
    };
    public static readonly PokedexData Ledian = new()
    {
        number = 166,
        name = "Ledian",
        category = "Five Star",
        height = 140,
        weight = 35600,
        entry = LedianDesc,
        forms = SingleSpecies(SpeciesID.Ledian),
    };
    public static readonly PokedexData Spinarak = new()
    {
        number = 167,
        name = "Spinarak",
        category = "String Spit",
        height = 50,
        weight = 8500,
        entry = SpinarakDesc,
        forms = SingleSpecies(SpeciesID.Spinarak),
    };
    public static readonly PokedexData Ariados = new()
    {
        number = 168,
        name = "Ariados",
        category = "Long Leg",
        height = 110,
        weight = 33500,
        entry = AriadosDesc,
        forms = SingleSpecies(SpeciesID.Ariados),
    };
    public static readonly PokedexData Crobat = new()
    {
        number = 169,
        name = "Crobat",
        category = "Bat",
        height = 180,
        weight = 75000,
        entry = CrobatDesc,
        forms = SingleSpecies(SpeciesID.Crobat),
    };
    public static readonly PokedexData Chinchou = new()
    {
        number = 170,
        name = "Chinchou",
        category = "Angler",
        height = 50,
        weight = 12000,
        entry = ChinchouDesc,
        forms = SingleSpecies(SpeciesID.Chinchou),
    };
    public static readonly PokedexData Lanturn = new()
    {
        number = 171,
        name = "Lanturn",
        category = "Light",
        height = 120,
        weight = 22500,
        entry = LanturnDesc,
        forms = SingleSpecies(SpeciesID.Lanturn),
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
            SpeciesID.Pichu,
            SpeciesID.PichuSpikyEared
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
        forms = SingleSpecies(SpeciesID.Cleffa),
    };
    public static readonly PokedexData Igglybuff = new()
    {
        number = 174,
        name = "Igglybuff",
        category = "Balloon",
        height = 30,
        weight = 1000,
        entry = IgglybuffDesc,
        forms = SingleSpecies(SpeciesID.Igglybuff),
    };
    public static readonly PokedexData Togepi = new()
    {
        number = 175,
        name = "Togepi",
        category = "Spike Ball",
        height = 30,
        weight = 1500,
        entry = TogepiDesc,
        forms = SingleSpecies(SpeciesID.Togepi),
    };
    public static readonly PokedexData Togetic = new()
    {
        number = 176,
        name = "Togetic",
        category = "Happiness",
        height = 60,
        weight = 3200,
        entry = TogeticDesc,
        forms = SingleSpecies(SpeciesID.Togetic),
    };
    public static readonly PokedexData Natu = new()
    {
        number = 177,
        name = "Natu",
        category = "Tiny Bird",
        height = 20,
        weight = 2000,
        entry = NatuDesc,
        forms = SingleSpecies(SpeciesID.Natu),
    };
    public static readonly PokedexData Xatu = new()
    {
        number = 178,
        name = "Xatu",
        category = "Mystic",
        height = 150,
        weight = 15000,
        entry = XatuDesc,
        forms = SingleSpecies(SpeciesID.Xatu),
    };
    public static readonly PokedexData Mareep = new()
    {
        number = 179,
        name = "Mareep",
        category = "Wool",
        height = 60,
        weight = 7800,
        entry = MareepDesc,
        forms = SingleSpecies(SpeciesID.Mareep),
    };
    public static readonly PokedexData Flaaffy = new()
    {
        number = 180,
        name = "Flaaffy",
        category = "Wool",
        height = 80,
        weight = 13300,
        entry = FlaaffyDesc,
        forms = SingleSpecies(SpeciesID.Flaaffy),
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
            SpeciesID.Ampharos,
            SpeciesID.AmpharosMega
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
        forms = SingleSpecies(SpeciesID.Bellossom),
    };
    public static readonly PokedexData Marill = new()
    {
        number = 183,
        name = "Marill",
        category = "Aqua Mouse",
        height = 40,
        weight = 8500,
        entry = MarillDesc,
        forms = SingleSpecies(SpeciesID.Marill),
    };
    public static readonly PokedexData Azumarill = new()
    {
        number = 184,
        name = "Azumarill",
        category = "Aqua Rabbit",
        height = 80,
        weight = 28500,
        entry = AzumarillDesc,
        forms = SingleSpecies(SpeciesID.Azumarill),
    };
    public static readonly PokedexData Sudowoodo = new()
    {
        number = 185,
        name = "Sudowoodo",
        category = "Imitation",
        height = 120,
        weight = 38000,
        entry = SudowoodoDesc,
        forms = SingleSpecies(SpeciesID.Sudowoodo),
    };
    public static readonly PokedexData Politoed = new()
    {
        number = 186,
        name = "Politoed",
        category = "Frog",
        height = 110,
        weight = 33900,
        entry = PolitoedDesc,
        forms = SingleSpecies(SpeciesID.Politoed),
    };
    public static readonly PokedexData Hoppip = new()
    {
        number = 187,
        name = "Hoppip",
        category = "Cottonweed",
        height = 40,
        weight = 500,
        entry = HoppipDesc,
        forms = SingleSpecies(SpeciesID.Hoppip),
    };
    public static readonly PokedexData Skiploom = new()
    {
        number = 188,
        name = "Skiploom",
        category = "Cottonweed",
        height = 60,
        weight = 1000,
        entry = SkiploomDesc,
        forms = SingleSpecies(SpeciesID.Skiploom),
    };
    public static readonly PokedexData Jumpluff = new()
    {
        number = 189,
        name = "Jumpluff",
        category = "Cottonweed",
        height = 80,
        weight = 3000,
        entry = JumpluffDesc,
        forms = SingleSpecies(SpeciesID.Jumpluff),
    };
    public static readonly PokedexData Aipom = new()
    {
        number = 190,
        name = "Aipom",
        category = "Long Tail",
        height = 80,
        weight = 11500,
        entry = AipomDesc,
        forms = SingleSpecies(SpeciesID.Aipom),
    };
    public static readonly PokedexData Sunkern = new()
    {
        number = 191,
        name = "Sunkern",
        category = "Seed",
        height = 30,
        weight = 1800,
        entry = SunkernDesc,
        forms = SingleSpecies(SpeciesID.Sunkern),
    };
    public static readonly PokedexData Sunflora = new()
    {
        number = 192,
        name = "Sunflora",
        category = "Sun",
        height = 80,
        weight = 8500,
        entry = SunfloraDesc,
        forms = SingleSpecies(SpeciesID.Sunflora),
    };
    public static readonly PokedexData Yanma = new()
    {
        number = 193,
        name = "Yanma",
        category = "Clear Wing",
        height = 120,
        weight = 38000,
        entry = YanmaDesc,
        forms = SingleSpecies(SpeciesID.Yanma),
    };
    public static readonly PokedexData Wooper = new()
    {
        number = 194,
        name = "Wooper",
        category = "Water Fish",
        height = 40,
        weight = 8500,
        entry = WooperDesc,
        forms = SingleSpecies(SpeciesID.Wooper),
    };
    public static readonly PokedexData Quagsire = new()
    {
        number = 195,
        name = "Quagsire",
        category = "Water Fish",
        height = 140,
        weight = 75000,
        entry = QuagsireDesc,
        forms = SingleSpecies(SpeciesID.Quagsire),
    };
    public static readonly PokedexData Espeon = new()
    {
        number = 196,
        name = "Espeon",
        category = "Sun",
        height = 90,
        weight = 26500,
        entry = EspeonDesc,
        forms = SingleSpecies(SpeciesID.Espeon),
    };
    public static readonly PokedexData Umbreon = new()
    {
        number = 197,
        name = "Umbreon",
        category = "Moonlight",
        height = 100,
        weight = 27000,
        entry = UmbreonDesc,
        forms = SingleSpecies(SpeciesID.Umbreon),
    };
    public static readonly PokedexData Murkrow = new()
    {
        number = 198,
        name = "Murkrow",
        category = "Darkness",
        height = 50,
        weight = 2100,
        entry = MurkrowDesc,
        forms = SingleSpecies(SpeciesID.Murkrow),
    };
    public static readonly PokedexData Slowking = new()
    {
        number = 199,
        name = "Slowking",
        category = "Royal",
        height = 200,
        weight = 79500,
        entry = SlowkingDesc,
        forms = new[]
        {
            SpeciesID.Slowking,
            SpeciesID.SlowkingGalar
        }
    };
    public static readonly PokedexData Misdreavus = new()
    {
        number = 200,
        name = "Misdreavus",
        category = "Screech",
        height = 70,
        weight = 1000,
        entry = MisdreavusDesc,
        forms = SingleSpecies(SpeciesID.Misdreavus),
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
            SpeciesID.Unown,
            SpeciesID.Unown_B,
            SpeciesID.Unown_C,
            SpeciesID.Unown_D,
            SpeciesID.Unown_E,
            SpeciesID.Unown_F,
            SpeciesID.Unown_G,
            SpeciesID.Unown_H,
            SpeciesID.Unown_I,
            SpeciesID.Unown_J,
            SpeciesID.Unown_K,
            SpeciesID.Unown_L,
            SpeciesID.Unown_M,
            SpeciesID.Unown_N,
            SpeciesID.Unown_O,
            SpeciesID.Unown_P,
            SpeciesID.Unown_Q,
            SpeciesID.Unown_R,
            SpeciesID.Unown_S,
            SpeciesID.Unown_T,
            SpeciesID.Unown_U,
            SpeciesID.Unown_V,
            SpeciesID.Unown_W,
            SpeciesID.Unown_X,
            SpeciesID.Unown_Y,
            SpeciesID.Unown_Z,
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
        forms = SingleSpecies(SpeciesID.Wobbuffet),
    };
    public static readonly PokedexData Girafarig = new()
    {
        number = 203,
        name = "Girafarig",
        category = "Long Neck",
        height = 150,
        weight = 41500,
        entry = GirafarigDesc,
        forms = SingleSpecies(SpeciesID.Girafarig),
    };
    public static readonly PokedexData Pineco = new()
    {
        number = 204,
        name = "Pineco",
        category = "Bagworm",
        height = 60,
        weight = 7200,
        entry = PinecoDesc,
        forms = SingleSpecies(SpeciesID.Pineco),
    };
    public static readonly PokedexData Forretress = new()
    {
        number = 205,
        name = "Forretress",
        category = "Bagworm",
        height = 120,
        weight = 125800,
        entry = ForretressDesc,
        forms = SingleSpecies(SpeciesID.Forretress),
    };
    public static readonly PokedexData Dunsparce = new()
    {
        number = 206,
        name = "Dunsparce",
        category = "Land Snake",
        height = 150,
        weight = 14000,
        entry = DunsparceDesc,
        forms = SingleSpecies(SpeciesID.Dunsparce),
    };
    public static readonly PokedexData Gligar = new()
    {
        number = 207,
        name = "Gligar",
        category = "Fly Scorpion",
        height = 110,
        weight = 64800,
        entry = GligarDesc,
        forms = SingleSpecies(SpeciesID.Gligar),
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
            SpeciesID.Steelix,
            SpeciesID.SteelixMega
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
        forms = SingleSpecies(SpeciesID.Snubbull),
    };
    public static readonly PokedexData Granbull = new()
    {
        number = 210,
        name = "Granbull",
        category = "Fairy",
        height = 140,
        weight = 48700,
        entry = GranbullDesc,
        forms = SingleSpecies(SpeciesID.Granbull),
    };
    public static readonly PokedexData Qwilfish = new()
    {
        number = 211,
        name = "Qwilfish",
        category = "Balloon",
        height = 50,
        weight = 3900,
        entry = QwilfishDesc,
        forms = new[]
        {
            SpeciesID.Qwilfish,
            SpeciesID.QwilfishHisui
        }
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
            SpeciesID.Scizor,
            SpeciesID.ScizorMega
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
        forms = SingleSpecies(SpeciesID.Shuckle),
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
            SpeciesID.Heracross,
            SpeciesID.HeracrossMega
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
        forms = new[]
        {
            SpeciesID.Sneasel,
            SpeciesID.SneaselHisui
        }
    };
    public static readonly PokedexData Teddiursa = new()
    {
        number = 216,
        name = "Teddiursa",
        category = "Little Bear",
        height = 60,
        weight = 8800,
        entry = TeddiursaDesc,
        forms = SingleSpecies(SpeciesID.Teddiursa),
    };
    public static readonly PokedexData Ursaring = new()
    {
        number = 217,
        name = "Ursaring",
        category = "Hibernator",
        height = 180,
        weight = 125800,
        entry = UrsaringDesc,
        forms = SingleSpecies(SpeciesID.Ursaring),
    };
    public static readonly PokedexData Slugma = new()
    {
        number = 218,
        name = "Slugma",
        category = "Lava",
        height = 70,
        weight = 35000,
        entry = SlugmaDesc,
        forms = SingleSpecies(SpeciesID.Slugma),
    };
    public static readonly PokedexData Magcargo = new()
    {
        number = 219,
        name = "Magcargo",
        category = "Lava",
        height = 80,
        weight = 55000,
        entry = MagcargoDesc,
        forms = SingleSpecies(SpeciesID.Magcargo),
    };
    public static readonly PokedexData Swinub = new()
    {
        number = 220,
        name = "Swinub",
        category = "Pig",
        height = 40,
        weight = 6500,
        entry = SwinubDesc,
        forms = SingleSpecies(SpeciesID.Swinub),
    };
    public static readonly PokedexData Piloswine = new()
    {
        number = 221,
        name = "Piloswine",
        category = "Swine",
        height = 110,
        weight = 55800,
        entry = PiloswineDesc,
        forms = SingleSpecies(SpeciesID.Piloswine),
    };
    public static readonly PokedexData Corsola = new()
    {
        number = 222,
        name = "Corsola",
        category = "Coral",
        height = 60,
        weight = 5000,
        entry = CorsolaDesc,
        forms = new[]
        {
            SpeciesID.Corsola,
            SpeciesID.CorsolaGalar
        }
    };
    public static readonly PokedexData Remoraid = new()
    {
        number = 223,
        name = "Remoraid",
        category = "Jet",
        height = 60,
        weight = 12000,
        entry = RemoraidDesc,
        forms = SingleSpecies(SpeciesID.Remoraid),
    };
    public static readonly PokedexData Octillery = new()
    {
        number = 224,
        name = "Octillery",
        category = "Jet",
        height = 90,
        weight = 28500,
        entry = OctilleryDesc,
        forms = SingleSpecies(SpeciesID.Octillery),
    };
    public static readonly PokedexData Delibird = new()
    {
        number = 225,
        name = "Delibird",
        category = "Delivery",
        height = 90,
        weight = 16000,
        entry = DelibirdDesc,
        forms = SingleSpecies(SpeciesID.Delibird),
    };
    public static readonly PokedexData Mantine = new()
    {
        number = 226,
        name = "Mantine",
        category = "Kite",
        height = 210,
        weight = 220000,
        entry = MantineDesc,
        forms = SingleSpecies(SpeciesID.Mantine),
    };
    public static readonly PokedexData Skarmory = new()
    {
        number = 227,
        name = "Skarmory",
        category = "Armor Bird",
        height = 170,
        weight = 50500,
        entry = SkarmoryDesc,
        forms = SingleSpecies(SpeciesID.Skarmory),
    };
    public static readonly PokedexData Houndour = new()
    {
        number = 228,
        name = "Houndour",
        category = "Dark",
        height = 60,
        weight = 10800,
        entry = HoundourDesc,
        forms = SingleSpecies(SpeciesID.Houndour),
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
            SpeciesID.Houndoom,
            SpeciesID.HoundoomMega
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
        forms = SingleSpecies(SpeciesID.Kingdra),
    };
    public static readonly PokedexData Phanpy = new()
    {
        number = 231,
        name = "Phanpy",
        category = "Long Nose",
        height = 50,
        weight = 33500,
        entry = PhanpyDesc,
        forms = SingleSpecies(SpeciesID.Phanpy),
    };
    public static readonly PokedexData Donphan = new()
    {
        number = 232,
        name = "Donphan",
        category = "Armor",
        height = 110,
        weight = 120000,
        entry = DonphanDesc,
        forms = SingleSpecies(SpeciesID.Donphan),
    };
    public static readonly PokedexData Porygon2 = new()
    {
        number = 233,
        name = "Porygon2",
        category = "Virtual",
        height = 60,
        weight = 32500,
        entry = Porygon2Desc,
        forms = SingleSpecies(SpeciesID.Porygon2),
    };
    public static readonly PokedexData Stantler = new()
    {
        number = 234,
        name = "Stantler",
        category = "Big Horn",
        height = 140,
        weight = 71200,
        entry = StantlerDesc,
        forms = SingleSpecies(SpeciesID.Stantler),
    };
    public static readonly PokedexData Smeargle = new()
    {
        number = 235,
        name = "Smeargle",
        category = "Painter",
        height = 120,
        weight = 58000,
        entry = SmeargleDesc,
        forms = SingleSpecies(SpeciesID.Smeargle),
    };
    public static readonly PokedexData Tyrogue = new()
    {
        number = 236,
        name = "Tyrogue",
        category = "Scuffle",
        height = 70,
        weight = 21000,
        entry = TyrogueDesc,
        forms = SingleSpecies(SpeciesID.Tyrogue),
    };
    public static readonly PokedexData Hitmontop = new()
    {
        number = 237,
        name = "Hitmontop",
        category = "Handstand",
        height = 140,
        weight = 48000,
        entry = HitmontopDesc,
        forms = SingleSpecies(SpeciesID.Hitmontop),
    };
    public static readonly PokedexData Smoochum = new()
    {
        number = 238,
        name = "Smoochum",
        category = "Kiss",
        height = 40,
        weight = 6000,
        entry = SmoochumDesc,
        forms = SingleSpecies(SpeciesID.Smoochum),
    };
    public static readonly PokedexData Elekid = new()
    {
        number = 239,
        name = "Elekid",
        category = "Electric",
        height = 60,
        weight = 23500,
        entry = ElekidDesc,
        forms = SingleSpecies(SpeciesID.Elekid),
    };
    public static readonly PokedexData Magby = new()
    {
        number = 240,
        name = "Magby",
        category = "Live Coal",
        height = 70,
        weight = 21400,
        entry = MagbyDesc,
        forms = SingleSpecies(SpeciesID.Magby),
    };
    public static readonly PokedexData Miltank = new()
    {
        number = 241,
        name = "Miltank",
        category = "Milk Cow",
        height = 120,
        weight = 75500,
        entry = MiltankDesc,
        forms = SingleSpecies(SpeciesID.Miltank),
    };
    public static readonly PokedexData Blissey = new()
    {
        number = 242,
        name = "Blissey",
        category = "Happiness",
        height = 150,
        weight = 46800,
        entry = BlisseyDesc,
        forms = SingleSpecies(SpeciesID.Blissey),
    };
    public static readonly PokedexData Raikou = new()
    {
        number = 243,
        name = "Raikou",
        category = "Thunder",
        height = 190,
        weight = 178000,
        entry = RaikouDesc,
        forms = SingleSpecies(SpeciesID.Raikou),
    };
    public static readonly PokedexData Entei = new()
    {
        number = 244,
        name = "Entei",
        category = "Volcano",
        height = 210,
        weight = 198000,
        entry = EnteiDesc,
        forms = SingleSpecies(SpeciesID.Entei),
    };
    public static readonly PokedexData Suicune = new()
    {
        number = 245,
        name = "Suicune",
        category = "Aurora",
        height = 200,
        weight = 187000,
        entry = SuicuneDesc,
        forms = SingleSpecies(SpeciesID.Suicune),
    };
    public static readonly PokedexData Larvitar = new()
    {
        number = 246,
        name = "Larvitar",
        category = "Rock Skin",
        height = 60,
        weight = 72000,
        entry = LarvitarDesc,
        forms = SingleSpecies(SpeciesID.Larvitar),
    };
    public static readonly PokedexData Pupitar = new()
    {
        number = 247,
        name = "Pupitar",
        category = "Hard Shell",
        height = 120,
        weight = 152000,
        entry = PupitarDesc,
        forms = SingleSpecies(SpeciesID.Pupitar),
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
            SpeciesID.Tyranitar,
            SpeciesID.TyranitarMega
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
        forms = SingleSpecies(SpeciesID.Lugia),
    };
    public static readonly PokedexData HoOh = new()
    {
        number = 250,
        name = "Ho Oh",
        category = "Rainbow",
        height = 380,
        weight = 199000,
        entry = HoOhDesc,
        forms = SingleSpecies(SpeciesID.HoOh),
    };
    public static readonly PokedexData Celebi = new()
    {
        number = 251,
        name = "Celebi",
        category = "Time Travel",
        height = 60,
        weight = 5000,
        entry = CelebiDesc,
        forms = SingleSpecies(SpeciesID.Celebi),
    };
    public static readonly PokedexData Treecko = new()
    {
        number = 252,
        name = "Treecko",
        category = "Wood Gecko",
        height = 50,
        weight = 5000,
        entry = TreeckoDesc,
        forms = SingleSpecies(SpeciesID.Treecko),
    };
    public static readonly PokedexData Grovyle = new()
    {
        number = 253,
        name = "Grovyle",
        category = "Wood Gecko",
        height = 90,
        weight = 21600,
        entry = GrovyleDesc,
        forms = SingleSpecies(SpeciesID.Grovyle),
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
            SpeciesID.Sceptile,
            SpeciesID.SceptileMega
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
        forms = SingleSpecies(SpeciesID.Torchic),
    };
    public static readonly PokedexData Combusken = new()
    {
        number = 256,
        name = "Combusken",
        category = "Young Fowl",
        height = 90,
        weight = 19500,
        entry = CombuskenDesc,
        forms = SingleSpecies(SpeciesID.Combusken),
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
            SpeciesID.Blaziken,
            SpeciesID.BlazikenMega
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
        forms = SingleSpecies(SpeciesID.Mudkip),
    };
    public static readonly PokedexData Marshtomp = new()
    {
        number = 259,
        name = "Marshtomp",
        category = "Mud Fish",
        height = 70,
        weight = 28000,
        entry = MarshtompDesc,
        forms = SingleSpecies(SpeciesID.Marshtomp),
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
            SpeciesID.Swampert,
            SpeciesID.SwampertMega
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
        forms = SingleSpecies(SpeciesID.Poochyena),
    };
    public static readonly PokedexData Mightyena = new()
    {
        number = 262,
        name = "Mightyena",
        category = "Bite",
        height = 100,
        weight = 37000,
        entry = MightyenaDesc,
        forms = SingleSpecies(SpeciesID.Mightyena),
    };
    public static readonly PokedexData Zigzagoon = new()
    {
        number = 263,
        name = "Zigzagoon",
        category = "Tiny Raccoon",
        height = 40,
        weight = 17500,
        entry = ZigzagoonDesc,
        forms = new[]
        {
            SpeciesID.Zigzagoon,
            SpeciesID.ZigzagoonGalar
        }
    };
    public static readonly PokedexData Linoone = new()
    {
        number = 264,
        name = "Linoone",
        category = "Rushing",
        height = 50,
        weight = 32500,
        entry = LinooneDesc,
        forms = new[]
        {
            SpeciesID.Linoone,
            SpeciesID.LinooneGalar
        }
    };
    public static readonly PokedexData Wurmple = new()
    {
        number = 265,
        name = "Wurmple",
        category = "Worm",
        height = 30,
        weight = 3600,
        entry = WurmpleDesc,
        forms = SingleSpecies(SpeciesID.Wurmple),
    };
    public static readonly PokedexData Silcoon = new()
    {
        number = 266,
        name = "Silcoon",
        category = "Cocoon",
        height = 60,
        weight = 10000,
        entry = SilcoonDesc,
        forms = SingleSpecies(SpeciesID.Silcoon),
    };
    public static readonly PokedexData Beautifly = new()
    {
        number = 267,
        name = "Beautifly",
        category = "Butterfly",
        height = 100,
        weight = 28400,
        entry = BeautiflyDesc,
        forms = SingleSpecies(SpeciesID.Beautifly),
    };
    public static readonly PokedexData Cascoon = new()
    {
        number = 268,
        name = "Cascoon",
        category = "Cocoon",
        height = 70,
        weight = 11500,
        entry = CascoonDesc,
        forms = SingleSpecies(SpeciesID.Cascoon),
    };
    public static readonly PokedexData Dustox = new()
    {
        number = 269,
        name = "Dustox",
        category = "Poison Moth",
        height = 120,
        weight = 31600,
        entry = DustoxDesc,
        forms = SingleSpecies(SpeciesID.Dustox),
    };
    public static readonly PokedexData Lotad = new()
    {
        number = 270,
        name = "Lotad",
        category = "WaterWeed",
        height = 50,
        weight = 2600,
        entry = LotadDesc,
        forms = SingleSpecies(SpeciesID.Lotad),
    };
    public static readonly PokedexData Lombre = new()
    {
        number = 271,
        name = "Lombre",
        category = "Jolly",
        height = 120,
        weight = 32500,
        entry = LombreDesc,
        forms = SingleSpecies(SpeciesID.Lombre),
    };
    public static readonly PokedexData Ludicolo = new()
    {
        number = 272,
        name = "Ludicolo",
        category = "Carefree",
        height = 150,
        weight = 55000,
        entry = LudicoloDesc,
        forms = SingleSpecies(SpeciesID.Ludicolo),
    };
    public static readonly PokedexData Seedot = new()
    {
        number = 273,
        name = "Seedot",
        category = "Acorn",
        height = 50,
        weight = 4000,
        entry = SeedotDesc,
        forms = SingleSpecies(SpeciesID.Seedot),
    };
    public static readonly PokedexData Nuzleaf = new()
    {
        number = 274,
        name = "Nuzleaf",
        category = "Wily",
        height = 100,
        weight = 28000,
        entry = NuzleafDesc,
        forms = SingleSpecies(SpeciesID.Nuzleaf),
    };
    public static readonly PokedexData Shiftry = new()
    {
        number = 275,
        name = "Shiftry",
        category = "Wicked",
        height = 130,
        weight = 59600,
        entry = ShiftryDesc,
        forms = SingleSpecies(SpeciesID.Shiftry),
    };
    public static readonly PokedexData Taillow = new()
    {
        number = 276,
        name = "Taillow",
        category = "Tiny Swallow",
        height = 30,
        weight = 2300,
        entry = TaillowDesc,
        forms = SingleSpecies(SpeciesID.Taillow),
    };
    public static readonly PokedexData Swellow = new()
    {
        number = 277,
        name = "Swellow",
        category = "Swallow",
        height = 70,
        weight = 19800,
        entry = SwellowDesc,
        forms = SingleSpecies(SpeciesID.Swellow),
    };
    public static readonly PokedexData Wingull = new()
    {
        number = 278,
        name = "Wingull",
        category = "Seagull",
        height = 60,
        weight = 9500,
        entry = WingullDesc,
        forms = SingleSpecies(SpeciesID.Wingull),
    };
    public static readonly PokedexData Pelipper = new()
    {
        number = 279,
        name = "Pelipper",
        category = "Water Bird",
        height = 120,
        weight = 28000,
        entry = PelipperDesc,
        forms = SingleSpecies(SpeciesID.Pelipper),
    };
    public static readonly PokedexData Ralts = new()
    {
        number = 280,
        name = "Ralts",
        category = "Feeling",
        height = 40,
        weight = 6600,
        entry = RaltsDesc,
        forms = SingleSpecies(SpeciesID.Ralts),
    };
    public static readonly PokedexData Kirlia = new()
    {
        number = 281,
        name = "Kirlia",
        category = "Emotion",
        height = 80,
        weight = 20200,
        entry = KirliaDesc,
        forms = SingleSpecies(SpeciesID.Kirlia),
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
            SpeciesID.Gardevoir,
            SpeciesID.GardevoirMega
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
        forms = SingleSpecies(SpeciesID.Surskit),
    };
    public static readonly PokedexData Masquerain = new()
    {
        number = 284,
        name = "Masquerain",
        category = "Eyeball",
        height = 80,
        weight = 3600,
        entry = MasquerainDesc,
        forms = SingleSpecies(SpeciesID.Masquerain),
    };
    public static readonly PokedexData Shroomish = new()
    {
        number = 285,
        name = "Shroomish",
        category = "Mushroom",
        height = 40,
        weight = 4500,
        entry = ShroomishDesc,
        forms = SingleSpecies(SpeciesID.Shroomish),
    };
    public static readonly PokedexData Breloom = new()
    {
        number = 286,
        name = "Breloom",
        category = "Mushroom",
        height = 120,
        weight = 39200,
        entry = BreloomDesc,
        forms = SingleSpecies(SpeciesID.Breloom),
    };
    public static readonly PokedexData Slakoth = new()
    {
        number = 287,
        name = "Slakoth",
        category = "Slacker",
        height = 80,
        weight = 24000,
        entry = SlakothDesc,
        forms = SingleSpecies(SpeciesID.Slakoth),
    };
    public static readonly PokedexData Vigoroth = new()
    {
        number = 288,
        name = "Vigoroth",
        category = "Wild Monkey",
        height = 140,
        weight = 46500,
        entry = VigorothDesc,
        forms = SingleSpecies(SpeciesID.Vigoroth),
    };
    public static readonly PokedexData Slaking = new()
    {
        number = 289,
        name = "Slaking",
        category = "Lazy",
        height = 200,
        weight = 130500,
        entry = SlakingDesc,
        forms = SingleSpecies(SpeciesID.Slaking),
    };
    public static readonly PokedexData Nincada = new()
    {
        number = 290,
        name = "Nincada",
        category = "Trainee",
        height = 50,
        weight = 5500,
        entry = NincadaDesc,
        forms = SingleSpecies(SpeciesID.Nincada),
    };
    public static readonly PokedexData Ninjask = new()
    {
        number = 291,
        name = "Ninjask",
        category = "Ninja",
        height = 80,
        weight = 12000,
        entry = NinjaskDesc,
        forms = SingleSpecies(SpeciesID.Ninjask),
    };
    public static readonly PokedexData Shedinja = new()
    {
        number = 292,
        name = "Shedinja",
        category = "Shed",
        height = 80,
        weight = 1200,
        entry = ShedinjaDesc,
        forms = SingleSpecies(SpeciesID.Shedinja),
    };
    public static readonly PokedexData Whismur = new()
    {
        number = 293,
        name = "Whismur",
        category = "Whisper",
        height = 60,
        weight = 16300,
        entry = WhismurDesc,
        forms = SingleSpecies(SpeciesID.Whismur),
    };
    public static readonly PokedexData Loudred = new()
    {
        number = 294,
        name = "Loudred",
        category = "Big Voice",
        height = 100,
        weight = 40500,
        entry = LoudredDesc,
        forms = SingleSpecies(SpeciesID.Loudred),
    };
    public static readonly PokedexData Exploud = new()
    {
        number = 295,
        name = "Exploud",
        category = "Loud Noise",
        height = 150,
        weight = 84000,
        entry = ExploudDesc,
        forms = SingleSpecies(SpeciesID.Exploud),
    };
    public static readonly PokedexData Makuhita = new()
    {
        number = 296,
        name = "Makuhita",
        category = "Guts",
        height = 100,
        weight = 86400,
        entry = MakuhitaDesc,
        forms = SingleSpecies(SpeciesID.Makuhita),
    };
    public static readonly PokedexData Hariyama = new()
    {
        number = 297,
        name = "Hariyama",
        category = "Arm Thrust",
        height = 230,
        weight = 253800,
        entry = HariyamaDesc,
        forms = SingleSpecies(SpeciesID.Hariyama),
    };
    public static readonly PokedexData Azurill = new()
    {
        number = 298,
        name = "Azurill",
        category = "Polka Dot",
        height = 20,
        weight = 2000,
        entry = AzurillDesc,
        forms = SingleSpecies(SpeciesID.Azurill),
    };
    public static readonly PokedexData Nosepass = new()
    {
        number = 299,
        name = "Nosepass",
        category = "Compass",
        height = 100,
        weight = 97000,
        entry = NosepassDesc,
        forms = SingleSpecies(SpeciesID.Nosepass),
    };
    public static readonly PokedexData Skitty = new()
    {
        number = 300,
        name = "Skitty",
        category = "Kitten",
        height = 60,
        weight = 11000,
        entry = SkittyDesc,
        forms = SingleSpecies(SpeciesID.Skitty),
    };
    public static readonly PokedexData Delcatty = new()
    {
        number = 301,
        name = "Delcatty",
        category = "Prim",
        height = 110,
        weight = 32600,
        entry = DelcattyDesc,
        forms = SingleSpecies(SpeciesID.Delcatty),
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
            SpeciesID.Sableye,
            SpeciesID.SableyeMega
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
        SpeciesID.Mawile,
        SpeciesID.MawileMega
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
        forms = SingleSpecies(SpeciesID.Aron),
    };
    public static readonly PokedexData Lairon = new()
    {
        number = 305,
        name = "Lairon",
        category = "Iron Armor",
        height = 90,
        weight = 120000,
        entry = LaironDesc,
        forms = SingleSpecies(SpeciesID.Lairon),
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
            SpeciesID.Aggron,
            SpeciesID.AggronMega
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
        forms = SingleSpecies(SpeciesID.Meditite),
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
            SpeciesID.Medicham,
            SpeciesID.MedichamMega
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
        forms = SingleSpecies(SpeciesID.Electrike),
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
            SpeciesID.Manectric,
            SpeciesID.ManectricMega
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
        forms = SingleSpecies(SpeciesID.Plusle),
    };
    public static readonly PokedexData Minun = new()
    {
        number = 312,
        name = "Minun",
        category = "Cheering",
        height = 40,
        weight = 4200,
        entry = MinunDesc,
        forms = SingleSpecies(SpeciesID.Minun),
    };
    public static readonly PokedexData Volbeat = new()
    {
        number = 313,
        name = "Volbeat",
        category = "Firefly",
        height = 70,
        weight = 17700,
        entry = VolbeatDesc,
        forms = SingleSpecies(SpeciesID.Volbeat),
    };
    public static readonly PokedexData Illumise = new()
    {
        number = 314,
        name = "Illumise",
        category = "Firefly",
        height = 60,
        weight = 17700,
        entry = IllumiseDesc,
        forms = SingleSpecies(SpeciesID.Illumise),
    };
    public static readonly PokedexData Roselia = new()
    {
        number = 315,
        name = "Roselia",
        category = "Thorn",
        height = 30,
        weight = 2000,
        entry = RoseliaDesc,
        forms = SingleSpecies(SpeciesID.Roselia),
    };
    public static readonly PokedexData Gulpin = new()
    {
        number = 316,
        name = "Gulpin",
        category = "Stomach",
        height = 40,
        weight = 10300,
        entry = GulpinDesc,
        forms = SingleSpecies(SpeciesID.Gulpin),
    };
    public static readonly PokedexData Swalot = new()
    {
        number = 317,
        name = "Swalot",
        category = "Poison Bag",
        height = 170,
        weight = 80000,
        entry = SwalotDesc,
        forms = SingleSpecies(SpeciesID.Swalot),
    };
    public static readonly PokedexData Carvanha = new()
    {
        number = 318,
        name = "Carvanha",
        category = "Savage",
        height = 80,
        weight = 20800,
        entry = CarvanhaDesc,
        forms = SingleSpecies(SpeciesID.Carvanha),
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
            SpeciesID.Sharpedo,
            SpeciesID.SharpedoMega
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
        forms = SingleSpecies(SpeciesID.Wailmer),
    };
    public static readonly PokedexData Wailord = new()
    {
        number = 321,
        name = "Wailord",
        category = "Float Whale",
        height = 1450,
        weight = 398000,
        entry = WailordDesc,
        forms = SingleSpecies(SpeciesID.Wailord),
    };
    public static readonly PokedexData Numel = new()
    {
        number = 322,
        name = "Numel",
        category = "Numb",
        height = 70,
        weight = 24000,
        entry = NumelDesc,
        forms = SingleSpecies(SpeciesID.Numel),
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
            SpeciesID.Camerupt,
            SpeciesID.CameruptMega
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
        forms = SingleSpecies(SpeciesID.Torkoal),
    };
    public static readonly PokedexData Spoink = new()
    {
        number = 325,
        name = "Spoink",
        category = "Bounce",
        height = 70,
        weight = 30600,
        entry = SpoinkDesc,
        forms = SingleSpecies(SpeciesID.Spoink),
    };
    public static readonly PokedexData Grumpig = new()
    {
        number = 326,
        name = "Grumpig",
        category = "Manipulate",
        height = 90,
        weight = 71500,
        entry = GrumpigDesc,
        forms = SingleSpecies(SpeciesID.Grumpig),
    };
    public static readonly PokedexData Spinda = new()
    {
        number = 327,
        name = "Spinda",
        category = "Spot Panda",
        height = 110,
        weight = 5000,
        entry = SpindaDesc,
        forms = SingleSpecies(SpeciesID.Spinda),
    };
    public static readonly PokedexData Trapinch = new()
    {
        number = 328,
        name = "Trapinch",
        category = "Ant Pit",
        height = 70,
        weight = 15000,
        entry = TrapinchDesc,
        forms = SingleSpecies(SpeciesID.Trapinch),
    };
    public static readonly PokedexData Vibrava = new()
    {
        number = 329,
        name = "Vibrava",
        category = "Vibration",
        height = 110,
        weight = 15300,
        entry = VibravaDesc,
        forms = SingleSpecies(SpeciesID.Vibrava),
    };
    public static readonly PokedexData Flygon = new()
    {
        number = 330,
        name = "Flygon",
        category = "Mystic",
        height = 200,
        weight = 82000,
        entry = FlygonDesc,
        forms = SingleSpecies(SpeciesID.Flygon),
    };
    public static readonly PokedexData Cacnea = new()
    {
        number = 331,
        name = "Cacnea",
        category = "Cactus",
        height = 40,
        weight = 51300,
        entry = CacneaDesc,
        forms = SingleSpecies(SpeciesID.Cacnea),
    };
    public static readonly PokedexData Cacturne = new()
    {
        number = 332,
        name = "Cacturne",
        category = "Scarecrow",
        height = 130,
        weight = 77400,
        entry = CacturneDesc,
        forms = SingleSpecies(SpeciesID.Cacturne),
    };
    public static readonly PokedexData Swablu = new()
    {
        number = 333,
        name = "Swablu",
        category = "Cotton Bird",
        height = 40,
        weight = 1200,
        entry = SwabluDesc,
        forms = SingleSpecies(SpeciesID.Swablu),
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
            SpeciesID.Altaria,
            SpeciesID.AltariaMega
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
        forms = SingleSpecies(SpeciesID.Zangoose),
    };
    public static readonly PokedexData Seviper = new()
    {
        number = 336,
        name = "Seviper",
        category = "Fang Snake",
        height = 270,
        weight = 52500,
        entry = SeviperDesc,
        forms = SingleSpecies(SpeciesID.Seviper),
    };
    public static readonly PokedexData Lunatone = new()
    {
        number = 337,
        name = "Lunatone",
        category = "Meteorite",
        height = 100,
        weight = 168000,
        entry = LunatoneDesc,
        forms = SingleSpecies(SpeciesID.Lunatone),
    };
    public static readonly PokedexData Solrock = new()
    {
        number = 338,
        name = "Solrock",
        category = "Meteorite",
        height = 120,
        weight = 154000,
        entry = SolrockDesc,
        forms = SingleSpecies(SpeciesID.Solrock),
    };
    public static readonly PokedexData Barboach = new()
    {
        number = 339,
        name = "Barboach",
        category = "Whiskers",
        height = 40,
        weight = 1900,
        entry = BarboachDesc,
        forms = SingleSpecies(SpeciesID.Barboach),
    };
    public static readonly PokedexData Whiscash = new()
    {
        number = 340,
        name = "Whiscash",
        category = "Whiskers",
        height = 90,
        weight = 23600,
        entry = WhiscashDesc,
        forms = SingleSpecies(SpeciesID.Whiscash),
    };
    public static readonly PokedexData Corphish = new()
    {
        number = 341,
        name = "Corphish",
        category = "Ruffian",
        height = 60,
        weight = 11500,
        entry = CorphishDesc,
        forms = SingleSpecies(SpeciesID.Corphish),
    };
    public static readonly PokedexData Crawdaunt = new()
    {
        number = 342,
        name = "Crawdaunt",
        category = "Rogue",
        height = 110,
        weight = 32800,
        entry = CrawdauntDesc,
        forms = SingleSpecies(SpeciesID.Crawdaunt),
    };
    public static readonly PokedexData Baltoy = new()
    {
        number = 343,
        name = "Baltoy",
        category = "Clay Doll",
        height = 50,
        weight = 21500,
        entry = BaltoyDesc,
        forms = SingleSpecies(SpeciesID.Baltoy),
    };
    public static readonly PokedexData Claydol = new()
    {
        number = 344,
        name = "Claydol",
        category = "Clay Doll",
        height = 150,
        weight = 108000,
        entry = ClaydolDesc,
        forms = SingleSpecies(SpeciesID.Claydol),
    };
    public static readonly PokedexData Lileep = new()
    {
        number = 345,
        name = "Lileep",
        category = "Sea Lily",
        height = 100,
        weight = 23800,
        entry = LileepDesc,
        forms = SingleSpecies(SpeciesID.Lileep),
    };
    public static readonly PokedexData Cradily = new()
    {
        number = 346,
        name = "Cradily",
        category = "Barnacle",
        height = 150,
        weight = 60400,
        entry = CradilyDesc,
        forms = SingleSpecies(SpeciesID.Cradily),
    };
    public static readonly PokedexData Anorith = new()
    {
        number = 347,
        name = "Anorith",
        category = "Old Shrimp",
        height = 70,
        weight = 12500,
        entry = AnorithDesc,
        forms = SingleSpecies(SpeciesID.Anorith),
    };
    public static readonly PokedexData Armaldo = new()
    {
        number = 348,
        name = "Armaldo",
        category = "Plate",
        height = 150,
        weight = 68200,
        entry = ArmaldoDesc,
        forms = SingleSpecies(SpeciesID.Armaldo),
    };
    public static readonly PokedexData Feebas = new()
    {
        number = 349,
        name = "Feebas",
        category = "Fish",
        height = 60,
        weight = 7400,
        entry = FeebasDesc,
        forms = SingleSpecies(SpeciesID.Feebas),
    };
    public static readonly PokedexData Milotic = new()
    {
        number = 350,
        name = "Milotic",
        category = "Tender",
        height = 620,
        weight = 162000,
        entry = MiloticDesc,
        forms = SingleSpecies(SpeciesID.Milotic),
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
            SpeciesID.Castform,
            SpeciesID.CastformSunny,
            SpeciesID.CastformRainy,
            SpeciesID.CastformSnowy
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
        forms = SingleSpecies(SpeciesID.Kecleon),
    };
    public static readonly PokedexData Shuppet = new()
    {
        number = 353,
        name = "Shuppet",
        category = "Puppet",
        height = 60,
        weight = 2300,
        entry = ShuppetDesc,
        forms = SingleSpecies(SpeciesID.Shuppet),
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
            SpeciesID.Banette,
            SpeciesID.BanetteMega
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
        forms = SingleSpecies(SpeciesID.Duskull),
    };
    public static readonly PokedexData Dusclops = new()
    {
        number = 356,
        name = "Dusclops",
        category = "Beckon",
        height = 160,
        weight = 30600,
        entry = DusclopsDesc,
        forms = SingleSpecies(SpeciesID.Dusclops),
    };
    public static readonly PokedexData Tropius = new()
    {
        number = 357,
        name = "Tropius",
        category = "Fruit",
        height = 200,
        weight = 100000,
        entry = TropiusDesc,
        forms = SingleSpecies(SpeciesID.Tropius),
    };
    public static readonly PokedexData Chimecho = new()
    {
        number = 358,
        name = "Chimecho",
        category = "Wind Chime",
        height = 60,
        weight = 1000,
        entry = ChimechoDesc,
        forms = SingleSpecies(SpeciesID.Chimecho),
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
            SpeciesID.Absol,
            SpeciesID.AbsolMega
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
        forms = SingleSpecies(SpeciesID.Wynaut),
    };
    public static readonly PokedexData Snorunt = new()
    {
        number = 361,
        name = "Snorunt",
        category = "Snow Hat",
        height = 70,
        weight = 16800,
        entry = SnoruntDesc,
        forms = SingleSpecies(SpeciesID.Snorunt),
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
            SpeciesID.Glalie,
            SpeciesID.GlalieMega
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
        forms = SingleSpecies(SpeciesID.Spheal),
    };
    public static readonly PokedexData Sealeo = new()
    {
        number = 364,
        name = "Sealeo",
        category = "Ball Roll",
        height = 110,
        weight = 87600,
        entry = SealeoDesc,
        forms = SingleSpecies(SpeciesID.Sealeo),
    };
    public static readonly PokedexData Walrein = new()
    {
        number = 365,
        name = "Walrein",
        category = "Ice Break",
        height = 140,
        weight = 150600,
        entry = WalreinDesc,
        forms = SingleSpecies(SpeciesID.Walrein),
    };
    public static readonly PokedexData Clamperl = new()
    {
        number = 366,
        name = "Clamperl",
        category = "Bivalve",
        height = 40,
        weight = 52500,
        entry = ClamperlDesc,
        forms = SingleSpecies(SpeciesID.Clamperl),
    };
    public static readonly PokedexData Huntail = new()
    {
        number = 367,
        name = "Huntail",
        category = "Deep Sea",
        height = 170,
        weight = 27000,
        entry = HuntailDesc,
        forms = SingleSpecies(SpeciesID.Huntail),
    };
    public static readonly PokedexData Gorebyss = new()
    {
        number = 368,
        name = "Gorebyss",
        category = "South Sea",
        height = 180,
        weight = 22600,
        entry = GorebyssDesc,
        forms = SingleSpecies(SpeciesID.Gorebyss),
    };
    public static readonly PokedexData Relicanth = new()
    {
        number = 369,
        name = "Relicanth",
        category = "Longevity",
        height = 100,
        weight = 23400,
        entry = RelicanthDesc,
        forms = SingleSpecies(SpeciesID.Relicanth),
    };
    public static readonly PokedexData Luvdisc = new()
    {
        number = 370,
        name = "Luvdisc",
        category = "Rendezvous",
        height = 60,
        weight = 8700,
        entry = LuvdiscDesc,
        forms = SingleSpecies(SpeciesID.Luvdisc),
    };
    public static readonly PokedexData Bagon = new()
    {
        number = 371,
        name = "Bagon",
        category = "Rock Head",
        height = 60,
        weight = 42100,
        entry = BagonDesc,
        forms = SingleSpecies(SpeciesID.Bagon),
    };
    public static readonly PokedexData Shelgon = new()
    {
        number = 372,
        name = "Shelgon",
        category = "Endurance",
        height = 110,
        weight = 110500,
        entry = ShelgonDesc,
        forms = SingleSpecies(SpeciesID.Shelgon),
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
            SpeciesID.Salamence,
            SpeciesID.SalamenceMega
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
        forms = SingleSpecies(SpeciesID.Beldum),
    };
    public static readonly PokedexData Metang = new()
    {
        number = 375,
        name = "Metang",
        category = "Iron Claw",
        height = 120,
        weight = 202500,
        entry = MetangDesc,
        forms = SingleSpecies(SpeciesID.Metang),
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
            SpeciesID.Metagross,
            SpeciesID.MetagrossMega
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
        forms = SingleSpecies(SpeciesID.Regirock),
    };
    public static readonly PokedexData Regice = new()
    {
        number = 378,
        name = "Regice",
        category = "Iceberg",
        height = 180,
        weight = 175000,
        entry = RegiceDesc,
        forms = SingleSpecies(SpeciesID.Regice),
    };
    public static readonly PokedexData Registeel = new()
    {
        number = 379,
        name = "Registeel",
        category = "Iron",
        height = 190,
        weight = 205000,
        entry = RegisteelDesc,
        forms = SingleSpecies(SpeciesID.Registeel),
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
            SpeciesID.Latias,
            SpeciesID.LatiasMega
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
            SpeciesID.Latios,
            SpeciesID.LatiosMega
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
        forms = SingleSpecies(SpeciesID.Kyogre),
    };
    public static readonly PokedexData Groudon = new()
    {
        number = 383,
        name = "Groudon",
        category = "Continent",
        height = 350,
        weight = 950000,
        entry = GroudonDesc,
        forms = SingleSpecies(SpeciesID.Groudon),
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
            SpeciesID.Rayquaza,
            SpeciesID.RayquazaMega
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
        forms = SingleSpecies(SpeciesID.Jirachi),
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
            SpeciesID.Deoxys,
            SpeciesID.DeoxysAttack,
            SpeciesID.DeoxysDefense,
            SpeciesID.DeoxysSpeed
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
        forms = SingleSpecies(SpeciesID.Turtwig),
    };
    public static readonly PokedexData Grotle = new()
    {
        number = 388,
        name = "Grotle",
        category = "Grove",
        height = 110,
        weight = 97000,
        entry = GrotleDesc,
        forms = SingleSpecies(SpeciesID.Grotle),
    };
    public static readonly PokedexData Torterra = new()
    {
        number = 389,
        name = "Torterra",
        category = "Continent",
        height = 220,
        weight = 310000,
        entry = TorterraDesc,
        forms = SingleSpecies(SpeciesID.Torterra),
    };
    public static readonly PokedexData Chimchar = new()
    {
        number = 390,
        name = "Chimchar",
        category = "Chimp",
        height = 50,
        weight = 6200,
        entry = ChimcharDesc,
        forms = SingleSpecies(SpeciesID.Chimchar),
    };
    public static readonly PokedexData Monferno = new()
    {
        number = 391,
        name = "Monferno",
        category = "Playful",
        height = 90,
        weight = 22000,
        entry = MonfernoDesc,
        forms = SingleSpecies(SpeciesID.Monferno),
    };
    public static readonly PokedexData Infernape = new()
    {
        number = 392,
        name = "Infernape",
        category = "Flame",
        height = 120,
        weight = 55000,
        entry = InfernapeDesc,
        forms = SingleSpecies(SpeciesID.Infernape),
    };
    public static readonly PokedexData Piplup = new()
    {
        number = 393,
        name = "Piplup",
        category = "Penguin",
        height = 40,
        weight = 5200,
        entry = PiplupDesc,
        forms = SingleSpecies(SpeciesID.Piplup),
    };
    public static readonly PokedexData Prinplup = new()
    {
        number = 394,
        name = "Prinplup",
        category = "Penguin",
        height = 80,
        weight = 23000,
        entry = PrinplupDesc,
        forms = SingleSpecies(SpeciesID.Prinplup),
    };
    public static readonly PokedexData Empoleon = new()
    {
        number = 395,
        name = "Empoleon",
        category = "Emperor",
        height = 170,
        weight = 84500,
        entry = EmpoleonDesc,
        forms = SingleSpecies(SpeciesID.Empoleon),
    };
    public static readonly PokedexData Starly = new()
    {
        number = 396,
        name = "Starly",
        category = "Starling",
        height = 30,
        weight = 2000,
        entry = StarlyDesc,
        forms = SingleSpecies(SpeciesID.Starly),
    };
    public static readonly PokedexData Staravia = new()
    {
        number = 397,
        name = "Staravia",
        category = "Starling",
        height = 60,
        weight = 15500,
        entry = StaraviaDesc,
        forms = SingleSpecies(SpeciesID.Staravia),
    };
    public static readonly PokedexData Staraptor = new()
    {
        number = 398,
        name = "Staraptor",
        category = "Predator",
        height = 120,
        weight = 24900,
        entry = StaraptorDesc,
        forms = SingleSpecies(SpeciesID.Staraptor),
    };
    public static readonly PokedexData Bidoof = new()
    {
        number = 399,
        name = "Bidoof",
        category = "Plump Mouse",
        height = 50,
        weight = 20000,
        entry = BidoofDesc,
        forms = SingleSpecies(SpeciesID.Bidoof),
    };
    public static readonly PokedexData Bibarel = new()
    {
        number = 400,
        name = "Bibarel",
        category = "Beaver",
        height = 100,
        weight = 31500,
        entry = BibarelDesc,
        forms = SingleSpecies(SpeciesID.Bibarel),
    };
    public static readonly PokedexData Kricketot = new()
    {
        number = 401,
        name = "Kricketot",
        category = "Cricket",
        height = 30,
        weight = 2200,
        entry = KricketotDesc,
        forms = SingleSpecies(SpeciesID.Kricketot),
    };
    public static readonly PokedexData Kricketune = new()
    {
        number = 402,
        name = "Kricketune",
        category = "Cricket",
        height = 100,
        weight = 25500,
        entry = KricketuneDesc,
        forms = SingleSpecies(SpeciesID.Kricketune),
    };
    public static readonly PokedexData Shinx = new()
    {
        number = 403,
        name = "Shinx",
        category = "Flash",
        height = 50,
        weight = 9500,
        entry = ShinxDesc,
        forms = SingleSpecies(SpeciesID.Shinx),
    };
    public static readonly PokedexData Luxio = new()
    {
        number = 404,
        name = "Luxio",
        category = "Spark",
        height = 90,
        weight = 30500,
        entry = LuxioDesc,
        forms = SingleSpecies(SpeciesID.Luxio),
    };
    public static readonly PokedexData Luxray = new()
    {
        number = 405,
        name = "Luxray",
        category = "Gleam Eyes",
        height = 140,
        weight = 42000,
        entry = LuxrayDesc,
        forms = SingleSpecies(SpeciesID.Luxray),
    };
    public static readonly PokedexData Budew = new()
    {
        number = 406,
        name = "Budew",
        category = "Bud",
        height = 20,
        weight = 1200,
        entry = BudewDesc,
        forms = SingleSpecies(SpeciesID.Budew),
    };
    public static readonly PokedexData Roserade = new()
    {
        number = 407,
        name = "Roserade",
        category = "Bouquet",
        height = 90,
        weight = 14500,
        entry = RoseradeDesc,
        forms = SingleSpecies(SpeciesID.Roserade),
    };
    public static readonly PokedexData Cranidos = new()
    {
        number = 408,
        name = "Cranidos",
        category = "Head Butt",
        height = 90,
        weight = 31500,
        entry = CranidosDesc,
        forms = SingleSpecies(SpeciesID.Cranidos),
    };
    public static readonly PokedexData Rampardos = new()
    {
        number = 409,
        name = "Rampardos",
        category = "Head Butt",
        height = 160,
        weight = 102500,
        entry = RampardosDesc,
        forms = SingleSpecies(SpeciesID.Rampardos),
    };
    public static readonly PokedexData Shieldon = new()
    {
        number = 410,
        name = "Shieldon",
        category = "Shield",
        height = 50,
        weight = 57000,
        entry = ShieldonDesc,
        forms = SingleSpecies(SpeciesID.Shieldon),
    };
    public static readonly PokedexData Bastiodon = new()
    {
        number = 411,
        name = "Bastiodon",
        category = "Shield",
        height = 130,
        weight = 149500,
        entry = BastiodonDesc,
        forms = SingleSpecies(SpeciesID.Bastiodon),
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
            SpeciesID.Burmy,
            SpeciesID.BurmySand,
            SpeciesID.BurmyTrash
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
            SpeciesID.Wormadam,
            SpeciesID.WormadamSand,
            SpeciesID.WormadamTrash
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
        forms = SingleSpecies(SpeciesID.Mothim),
    };
    public static readonly PokedexData Combee = new()
    {
        number = 415,
        name = "Combee",
        category = "Tiny Bee",
        height = 30,
        weight = 5500,
        entry = CombeeDesc,
        forms = SingleSpecies(SpeciesID.Combee),
    };
    public static readonly PokedexData Vespiquen = new()
    {
        number = 416,
        name = "Vespiquen",
        category = "Beehive",
        height = 120,
        weight = 38500,
        entry = VespiquenDesc,
        forms = SingleSpecies(SpeciesID.Vespiquen),
    };
    public static readonly PokedexData Pachirisu = new()
    {
        number = 417,
        name = "Pachirisu",
        category = "EleSquirrel",
        height = 40,
        weight = 3900,
        entry = PachirisuDesc,
        forms = SingleSpecies(SpeciesID.Pachirisu),
    };
    public static readonly PokedexData Buizel = new()
    {
        number = 418,
        name = "Buizel",
        category = "Sea Weasel",
        height = 70,
        weight = 29500,
        entry = BuizelDesc,
        forms = SingleSpecies(SpeciesID.Buizel),
    };
    public static readonly PokedexData Floatzel = new()
    {
        number = 419,
        name = "Floatzel",
        category = "Sea Weasel",
        height = 110,
        weight = 33500,
        entry = FloatzelDesc,
        forms = SingleSpecies(SpeciesID.Floatzel),
    };
    public static readonly PokedexData Cherubi = new()
    {
        number = 420,
        name = "Cherubi",
        category = "Cherry",
        height = 40,
        weight = 3300,
        entry = CherubiDesc,
        forms = SingleSpecies(SpeciesID.Cherubi),
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
            SpeciesID.Cherrim,
            SpeciesID.CherrimSunshine
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
            SpeciesID.Shellos,
            SpeciesID.ShellosEast
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
            SpeciesID.Gastrodon,
            SpeciesID.GastrodonEast
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
        forms = SingleSpecies(SpeciesID.Ambipom),
    };
    public static readonly PokedexData Drifloon = new()
    {
        number = 425,
        name = "Drifloon",
        category = "Balloon",
        height = 40,
        weight = 1200,
        entry = DrifloonDesc,
        forms = SingleSpecies(SpeciesID.Drifloon),
    };
    public static readonly PokedexData Drifblim = new()
    {
        number = 426,
        name = "Drifblim",
        category = "Blimp",
        height = 120,
        weight = 15000,
        entry = DrifblimDesc,
        forms = SingleSpecies(SpeciesID.Drifblim),
    };
    public static readonly PokedexData Buneary = new()
    {
        number = 427,
        name = "Buneary",
        category = "Rabbit",
        height = 40,
        weight = 5500,
        entry = BunearyDesc,
        forms = SingleSpecies(SpeciesID.Buneary),
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
            SpeciesID.Lopunny,
            SpeciesID.LopunnyMega
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
        forms = SingleSpecies(SpeciesID.Mismagius),
    };
    public static readonly PokedexData Honchkrow = new()
    {
        number = 430,
        name = "Honchkrow",
        category = "Big Boss",
        height = 90,
        weight = 27300,
        entry = HonchkrowDesc,
        forms = SingleSpecies(SpeciesID.Honchkrow),
    };
    public static readonly PokedexData Glameow = new()
    {
        number = 431,
        name = "Glameow",
        category = "Catty",
        height = 50,
        weight = 3900,
        entry = GlameowDesc,
        forms = SingleSpecies(SpeciesID.Glameow),
    };
    public static readonly PokedexData Purugly = new()
    {
        number = 432,
        name = "Purugly",
        category = "Tiger Cat",
        height = 100,
        weight = 43800,
        entry = PuruglyDesc,
        forms = SingleSpecies(SpeciesID.Purugly),
    };
    public static readonly PokedexData Chingling = new()
    {
        number = 433,
        name = "Chingling",
        category = "Bell",
        height = 20,
        weight = 600,
        entry = ChinglingDesc,
        forms = SingleSpecies(SpeciesID.Chingling),
    };
    public static readonly PokedexData Stunky = new()
    {
        number = 434,
        name = "Stunky",
        category = "Skunk",
        height = 40,
        weight = 19200,
        entry = StunkyDesc,
        forms = SingleSpecies(SpeciesID.Stunky),
    };
    public static readonly PokedexData Skuntank = new()
    {
        number = 435,
        name = "Skuntank",
        category = "Skunk",
        height = 100,
        weight = 38000,
        entry = SkuntankDesc,
        forms = SingleSpecies(SpeciesID.Skuntank),
    };
    public static readonly PokedexData Bronzor = new()
    {
        number = 436,
        name = "Bronzor",
        category = "Bronze",
        height = 50,
        weight = 60500,
        entry = BronzorDesc,
        forms = SingleSpecies(SpeciesID.Bronzor),
    };
    public static readonly PokedexData Bronzong = new()
    {
        number = 437,
        name = "Bronzong",
        category = "Bronze Bell",
        height = 130,
        weight = 187000,
        entry = BronzongDesc,
        forms = SingleSpecies(SpeciesID.Bronzong),
    };
    public static readonly PokedexData Bonsly = new()
    {
        number = 438,
        name = "Bonsly",
        category = "Bonsai",
        height = 50,
        weight = 15000,
        entry = BonslyDesc,
        forms = SingleSpecies(SpeciesID.Bonsly),
    };
    public static readonly PokedexData MimeJr = new()
    {
        number = 439,
        name = "Mime Jr",
        category = "Mime",
        height = 60,
        weight = 13000,
        entry = MimeJrDesc,
        forms = SingleSpecies(SpeciesID.MimeJr),

    };
    public static readonly PokedexData Happiny = new()
    {
        number = 440,
        name = "Happiny",
        category = "Playhouse",
        height = 60,
        weight = 24400,
        entry = HappinyDesc,
        forms = SingleSpecies(SpeciesID.Happiny),
    };
    public static readonly PokedexData Chatot = new()
    {
        number = 441,
        name = "Chatot",
        category = "Music Note",
        height = 50,
        weight = 1900,
        entry = ChatotDesc,
        forms = SingleSpecies(SpeciesID.Chatot),
    };
    public static readonly PokedexData Spiritomb = new()
    {
        number = 442,
        name = "Spiritomb",
        category = "Forbidden",
        height = 100,
        weight = 108000,
        entry = SpiritombDesc,
        forms = SingleSpecies(SpeciesID.Spiritomb),
    };
    public static readonly PokedexData Gible = new()
    {
        number = 443,
        name = "Gible",
        category = "Land Shark",
        height = 70,
        weight = 20500,
        entry = GibleDesc,
        forms = SingleSpecies(SpeciesID.Gible),
    };
    public static readonly PokedexData Gabite = new()
    {
        number = 444,
        name = "Gabite",
        category = "Cave",
        height = 140,
        weight = 56000,
        entry = GabiteDesc,
        forms = SingleSpecies(SpeciesID.Gabite),
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
            SpeciesID.Garchomp,
            SpeciesID.GarchompMega
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
        forms = SingleSpecies(SpeciesID.Munchlax),
    };
    public static readonly PokedexData Riolu = new()
    {
        number = 447,
        name = "Riolu",
        category = "Emanation",
        height = 70,
        weight = 20200,
        entry = RioluDesc,
        forms = SingleSpecies(SpeciesID.Riolu),
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
            SpeciesID.Lucario,
            SpeciesID.LucarioMega
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
        forms = SingleSpecies(SpeciesID.Hippopotas),
    };
    public static readonly PokedexData Hippowdon = new()
    {
        number = 450,
        name = "Hippowdon",
        category = "Heavyweight",
        height = 200,
        weight = 300000,
        entry = HippowdonDesc,
        forms = SingleSpecies(SpeciesID.Hippowdon),
    };
    public static readonly PokedexData Skorupi = new()
    {
        number = 451,
        name = "Skorupi",
        category = "Scorpion",
        height = 80,
        weight = 12000,
        entry = SkorupiDesc,
        forms = SingleSpecies(SpeciesID.Skorupi),
    };
    public static readonly PokedexData Drapion = new()
    {
        number = 452,
        name = "Drapion",
        category = "Ogre Scorpion",
        height = 130,
        weight = 61500,
        entry = DrapionDesc,
        forms = SingleSpecies(SpeciesID.Drapion),
    };
    public static readonly PokedexData Croagunk = new()
    {
        number = 453,
        name = "Croagunk",
        category = "Toxic Mouth",
        height = 70,
        weight = 23000,
        entry = CroagunkDesc,
        forms = SingleSpecies(SpeciesID.Croagunk),
    };
    public static readonly PokedexData Toxicroak = new()
    {
        number = 454,
        name = "Toxicroak",
        category = "Toxic Mouth",
        height = 130,
        weight = 44400,
        entry = ToxicroakDesc,
        forms = SingleSpecies(SpeciesID.Toxicroak),
    };
    public static readonly PokedexData Carnivine = new()
    {
        number = 455,
        name = "Carnivine",
        category = "Bug Catcher",
        height = 140,
        weight = 27000,
        entry = CarnivineDesc,
        forms = SingleSpecies(SpeciesID.Carnivine),
    };
    public static readonly PokedexData Finneon = new()
    {
        number = 456,
        name = "Finneon",
        category = "Wing Fish",
        height = 40,
        weight = 7000,
        entry = FinneonDesc,
        forms = SingleSpecies(SpeciesID.Finneon),
    };
    public static readonly PokedexData Lumineon = new()
    {
        number = 457,
        name = "Lumineon",
        category = "Neon",
        height = 120,
        weight = 24000,
        entry = LumineonDesc,
        forms = SingleSpecies(SpeciesID.Lumineon),
    };
    public static readonly PokedexData Mantyke = new()
    {
        number = 458,
        name = "Mantyke",
        category = "Kite",
        height = 100,
        weight = 65000,
        entry = MantykeDesc,
        forms = SingleSpecies(SpeciesID.Mantyke),
    };
    public static readonly PokedexData Snover = new()
    {
        number = 459,
        name = "Snover",
        category = "Frost Tree",
        height = 100,
        weight = 50500,
        entry = SnoverDesc,
        forms = SingleSpecies(SpeciesID.Snover),
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
            SpeciesID.Abomasnow,
            SpeciesID.AbomasnowMega
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
        forms = SingleSpecies(SpeciesID.Weavile),
    };
    public static readonly PokedexData Magnezone = new()
    {
        number = 462,
        name = "Magnezone",
        category = "Magnet Area",
        height = 120,
        weight = 180000,
        entry = MagnezoneDesc,
        forms = SingleSpecies(SpeciesID.Magnezone),
    };
    public static readonly PokedexData Lickilicky = new()
    {
        number = 463,
        name = "Lickilicky",
        category = "Licking",
        height = 170,
        weight = 140000,
        entry = LickilickyDesc,
        forms = SingleSpecies(SpeciesID.Lickilicky),
    };
    public static readonly PokedexData Rhyperior = new()
    {
        number = 464,
        name = "Rhyperior",
        category = "Drill",
        height = 240,
        weight = 282800,
        entry = RhyperiorDesc,
        forms = SingleSpecies(SpeciesID.Rhyperior),
    };
    public static readonly PokedexData Tangrowth = new()
    {
        number = 465,
        name = "Tangrowth",
        category = "Vine",
        height = 200,
        weight = 128600,
        entry = TangrowthDesc,
        forms = SingleSpecies(SpeciesID.Tangrowth),
    };
    public static readonly PokedexData Electivire = new()
    {
        number = 466,
        name = "Electivire",
        category = "Thunderbolt",
        height = 180,
        weight = 138600,
        entry = ElectivireDesc,
        forms = SingleSpecies(SpeciesID.Electivire),
    };
    public static readonly PokedexData Magmortar = new()
    {
        number = 467,
        name = "Magmortar",
        category = "Blast",
        height = 160,
        weight = 68000,
        entry = MagmortarDesc,
        forms = SingleSpecies(SpeciesID.Magmortar),
    };
    public static readonly PokedexData Togekiss = new()
    {
        number = 468,
        name = "Togekiss",
        category = "Jubilee",
        height = 150,
        weight = 38000,
        entry = TogekissDesc,
        forms = SingleSpecies(SpeciesID.Togekiss),
    };
    public static readonly PokedexData Yanmega = new()
    {
        number = 469,
        name = "Yanmega",
        category = "Ogre Darner",
        height = 190,
        weight = 51500,
        entry = YanmegaDesc,
        forms = SingleSpecies(SpeciesID.Yanmega),
    };
    public static readonly PokedexData Leafeon = new()
    {
        number = 470,
        name = "Leafeon",
        category = "Verdant",
        height = 100,
        weight = 25500,
        entry = LeafeonDesc,
        forms = SingleSpecies(SpeciesID.Leafeon),
    };
    public static readonly PokedexData Glaceon = new()
    {
        number = 471,
        name = "Glaceon",
        category = "Fresh Snow",
        height = 80,
        weight = 25900,
        entry = GlaceonDesc,
        forms = SingleSpecies(SpeciesID.Glaceon),
    };
    public static readonly PokedexData Gliscor = new()
    {
        number = 472,
        name = "Gliscor",
        category = "Fang Scorpion",
        height = 200,
        weight = 42500,
        entry = GliscorDesc,
        forms = SingleSpecies(SpeciesID.Gliscor),
    };
    public static readonly PokedexData Mamoswine = new()
    {
        number = 473,
        name = "Mamoswine",
        category = "Twin Tusk",
        height = 250,
        weight = 291000,
        entry = MamoswineDesc,
        forms = SingleSpecies(SpeciesID.Mamoswine),
    };
    public static readonly PokedexData PorygonZ = new()
    {
        number = 474,
        name = "Porygon Z",
        category = "Virtual",
        height = 90,
        weight = 34000,
        entry = PorygonZDesc,
        forms = SingleSpecies(SpeciesID.PorygonZ),
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
            SpeciesID.Gallade,
            SpeciesID.GalladeMega
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
        forms = SingleSpecies(SpeciesID.Probopass),
    };
    public static readonly PokedexData Dusknoir = new()
    {
        number = 477,
        name = "Dusknoir",
        category = "Gripper",
        height = 220,
        weight = 106600,
        entry = DusknoirDesc,
        forms = SingleSpecies(SpeciesID.Dusknoir),
    };
    public static readonly PokedexData Froslass = new()
    {
        number = 478,
        name = "Froslass",
        category = "Snow Land",
        height = 130,
        weight = 26600,
        entry = FroslassDesc,
        forms = SingleSpecies(SpeciesID.Froslass),
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
            SpeciesID.Rotom,
            SpeciesID.RotomHeat,
            SpeciesID.RotomWash,
            SpeciesID.RotomFrost,
            SpeciesID.RotomFan,
            SpeciesID.RotomMow
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
        forms = SingleSpecies(SpeciesID.Uxie),
    };
    public static readonly PokedexData Mesprit = new()
    {
        number = 481,
        name = "Mesprit",
        category = "Emotion",
        height = 30,
        weight = 300,
        entry = MespritDesc,
        forms = SingleSpecies(SpeciesID.Mesprit),
    };
    public static readonly PokedexData Azelf = new()
    {
        number = 482,
        name = "Azelf",
        category = "Willpower",
        height = 30,
        weight = 300,
        entry = AzelfDesc,
        forms = SingleSpecies(SpeciesID.Azelf),
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
            SpeciesID.Dialga,
            SpeciesID.DialgaOrigin
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
            SpeciesID.Palkia,
            SpeciesID.PalkiaOrigin
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
        forms = SingleSpecies(SpeciesID.Heatran),
    };
    public static readonly PokedexData Regigigas = new()
    {
        number = 486,
        name = "Regigigas",
        category = "Colossal",
        height = 370,
        weight = 420000,
        entry = RegigigasDesc,
        forms = SingleSpecies(SpeciesID.Regigigas),
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
            SpeciesID.Giratina,
            SpeciesID.GiratinaOrigin
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
        forms = SingleSpecies(SpeciesID.Cresselia),
    };
    public static readonly PokedexData Phione = new()
    {
        number = 489,
        name = "Phione",
        category = "Sea Drifter",
        height = 40,
        weight = 3100,
        entry = PhioneDesc,
        forms = SingleSpecies(SpeciesID.Phione),
    };
    public static readonly PokedexData Manaphy = new()
    {
        number = 490,
        name = "Manaphy",
        category = "Seafaring",
        height = 30,
        weight = 1400,
        entry = ManaphyDesc,
        forms = SingleSpecies(SpeciesID.Manaphy),
    };
    public static readonly PokedexData Darkrai = new()
    {
        number = 491,
        name = "Darkrai",
        category = "Pitch-Black",
        height = 150,
        weight = 50500,
        entry = DarkraiDesc,
        forms = SingleSpecies(SpeciesID.Darkrai),
    };
    public static readonly PokedexData Shaymin = new()
    {
        number = 492,
        name = "Shaymin",
        category = "Gratitude",
        height = 20,
        weight = 2100,
        entry = ShayminDesc,
        forms = SingleSpecies(SpeciesID.Shaymin),
    };
    public static readonly PokedexData Arceus = new()
    {
        number = 493,
        name = "Arceus",
        category = "Alpha",
        height = 320,
        weight = 320000,
        entry = ArceusDesc,
        forms = SingleSpecies(SpeciesID.Arceus),
    };
    public static readonly PokedexData Victini = new()
    {
        number = 494,
        name = "Victini",
        category = "Victory",
        height = 40,
        weight = 4000,
        entry = VictiniDesc,
        forms = SingleSpecies(SpeciesID.Victini),
    };
    public static readonly PokedexData Snivy = new()
    {
        number = 495,
        name = "Snivy",
        category = "Grass Snake",
        height = 60,
        weight = 8100,
        entry = SnivyDesc,
        forms = SingleSpecies(SpeciesID.Snivy),
    };
    public static readonly PokedexData Servine = new()
    {
        number = 496,
        name = "Servine",
        category = "Grass Snake",
        height = 80,
        weight = 16000,
        entry = ServineDesc,
        forms = SingleSpecies(SpeciesID.Servine),
    };
    public static readonly PokedexData Serperior = new()
    {
        number = 497,
        name = "Serperior",
        category = "Regal",
        height = 330,
        weight = 63000,
        entry = SerperiorDesc,
        forms = SingleSpecies(SpeciesID.Serperior),
    };
    public static readonly PokedexData Tepig = new()
    {
        number = 498,
        name = "Tepig",
        category = "Fire Pig",
        height = 50,
        weight = 9900,
        entry = TepigDesc,
        forms = SingleSpecies(SpeciesID.Tepig),
    };
    public static readonly PokedexData Pignite = new()
    {
        number = 499,
        name = "Pignite",
        category = "Fire Pig",
        height = 100,
        weight = 55500,
        entry = PigniteDesc,
        forms = SingleSpecies(SpeciesID.Pignite),
    };
    public static readonly PokedexData Emboar = new()
    {
        number = 500,
        name = "Emboar",
        category = "Fire Pig",
        height = 160,
        weight = 150000,
        entry = EmboarDesc,
        forms = SingleSpecies(SpeciesID.Emboar),
    };
    public static readonly PokedexData Oshawott = new()
    {
        number = 501,
        name = "Oshawott",
        category = "Sea Otter",
        height = 50,
        weight = 5900,
        entry = OshawottDesc,
        forms = SingleSpecies(SpeciesID.Oshawott),
    };
    public static readonly PokedexData Dewott = new()
    {
        number = 502,
        name = "Dewott",
        category = "Discipline",
        height = 80,
        weight = 24500,
        entry = DewottDesc,
        forms = SingleSpecies(SpeciesID.Dewott),
    };
    public static readonly PokedexData Samurott = new()
    {
        number = 503,
        name = "Samurott",
        category = "Formidable",
        height = 150,
        weight = 94600,
        entry = SamurottDesc,
        forms = new[]
        {
            SpeciesID.Samurott,
            SpeciesID.SamurottHisui
        }
    };
    public static readonly PokedexData Patrat = new()
    {
        number = 504,
        name = "Patrat",
        category = "Scout",
        height = 50,
        weight = 11600,
        entry = PatratDesc,
        forms = SingleSpecies(SpeciesID.Patrat),
    };
    public static readonly PokedexData Watchog = new()
    {
        number = 505,
        name = "Watchog",
        category = "Lookout",
        height = 110,
        weight = 27000,
        entry = WatchogDesc,
        forms = SingleSpecies(SpeciesID.Watchog),
    };
    public static readonly PokedexData Lillipup = new()
    {
        number = 506,
        name = "Lillipup",
        category = "Puppy",
        height = 40,
        weight = 4100,
        entry = LillipupDesc,
        forms = SingleSpecies(SpeciesID.Lillipup),
    };
    public static readonly PokedexData Herdier = new()
    {
        number = 507,
        name = "Herdier",
        category = "Loyal Dog",
        height = 90,
        weight = 14700,
        entry = HerdierDesc,
        forms = SingleSpecies(SpeciesID.Herdier),
    };
    public static readonly PokedexData Stoutland = new()
    {
        number = 508,
        name = "Stoutland",
        category = "Big-Hearted",
        height = 120,
        weight = 61000,
        entry = StoutlandDesc,
        forms = SingleSpecies(SpeciesID.Stoutland),
    };
    public static readonly PokedexData Purrloin = new()
    {
        number = 509,
        name = "Purrloin",
        category = "Devious",
        height = 40,
        weight = 10100,
        entry = PurrloinDesc,
        forms = SingleSpecies(SpeciesID.Purrloin),
    };
    public static readonly PokedexData Liepard = new()
    {
        number = 510,
        name = "Liepard",
        category = "Cruel",
        height = 110,
        weight = 37500,
        entry = LiepardDesc,
        forms = SingleSpecies(SpeciesID.Liepard),
    };
    public static readonly PokedexData Pansage = new()
    {
        number = 511,
        name = "Pansage",
        category = "Grass Monkey",
        height = 60,
        weight = 10500,
        entry = PansageDesc,
        forms = SingleSpecies(SpeciesID.Pansage),
    };
    public static readonly PokedexData Simisage = new()
    {
        number = 512,
        name = "Simisage",
        category = "Thorn Monkey",
        height = 110,
        weight = 30500,
        entry = SimisageDesc,
        forms = SingleSpecies(SpeciesID.Simisage),
    };
    public static readonly PokedexData Pansear = new()
    {
        number = 513,
        name = "Pansear",
        category = "High Temp",
        height = 60,
        weight = 11000,
        entry = PansearDesc,
        forms = SingleSpecies(SpeciesID.Pansear),
    };
    public static readonly PokedexData Simisear = new()
    {
        number = 514,
        name = "Simisear",
        category = "Ember",
        height = 100,
        weight = 28000,
        entry = SimisearDesc,
        forms = SingleSpecies(SpeciesID.Simisear),
    };
    public static readonly PokedexData Panpour = new()
    {
        number = 515,
        name = "Panpour",
        category = "Spray",
        height = 60,
        weight = 13500,
        entry = PanpourDesc,
        forms = SingleSpecies(SpeciesID.Panpour),
    };
    public static readonly PokedexData Simipour = new()
    {
        number = 516,
        name = "Simipour",
        category = "Geyser",
        height = 100,
        weight = 29000,
        entry = SimipourDesc,
        forms = SingleSpecies(SpeciesID.Simipour),
    };
    public static readonly PokedexData Munna = new()
    {
        number = 517,
        name = "Munna",
        category = "Dream Eater",
        height = 60,
        weight = 23300,
        entry = MunnaDesc,
        forms = SingleSpecies(SpeciesID.Munna),
    };
    public static readonly PokedexData Musharna = new()
    {
        number = 518,
        name = "Musharna",
        category = "Drowsing",
        height = 110,
        weight = 60500,
        entry = MusharnaDesc,
        forms = SingleSpecies(SpeciesID.Musharna),
    };
    public static readonly PokedexData Pidove = new()
    {
        number = 519,
        name = "Pidove",
        category = "Tiny Pigeon",
        height = 30,
        weight = 2100,
        entry = PidoveDesc,
        forms = SingleSpecies(SpeciesID.Pidove),
    };
    public static readonly PokedexData Tranquill = new()
    {
        number = 520,
        name = "Tranquill",
        category = "Wild Pigeon",
        height = 60,
        weight = 15000,
        entry = TranquillDesc,
        forms = SingleSpecies(SpeciesID.Tranquill),
    };
    public static readonly PokedexData Unfezant = new()
    {
        number = 521,
        name = "Unfezant",
        category = "Proud",
        height = 120,
        weight = 29000,
        entry = UnfezantDesc,
        forms = SingleSpecies(SpeciesID.Unfezant),
    };
    public static readonly PokedexData Blitzle = new()
    {
        number = 522,
        name = "Blitzle",
        category = "Electrified",
        height = 80,
        weight = 29800,
        entry = BlitzleDesc,
        forms = SingleSpecies(SpeciesID.Blitzle),
    };
    public static readonly PokedexData Zebstrika = new()
    {
        number = 523,
        name = "Zebstrika",
        category = "Thunderbolt",
        height = 160,
        weight = 79500,
        entry = ZebstrikaDesc,
        forms = SingleSpecies(SpeciesID.Zebstrika),
    };
    public static readonly PokedexData Roggenrola = new()
    {
        number = 524,
        name = "Roggenrola",
        category = "Mantle",
        height = 40,
        weight = 18000,
        entry = RoggenrolaDesc,
        forms = SingleSpecies(SpeciesID.Roggenrola),
    };
    public static readonly PokedexData Boldore = new()
    {
        number = 525,
        name = "Boldore",
        category = "Ore",
        height = 90,
        weight = 102000,
        entry = BoldoreDesc,
        forms = SingleSpecies(SpeciesID.Boldore),
    };
    public static readonly PokedexData Gigalith = new()
    {
        number = 526,
        name = "Gigalith",
        category = "Compressed",
        height = 170,
        weight = 260000,
        entry = GigalithDesc,
        forms = SingleSpecies(SpeciesID.Gigalith),
    };
    public static readonly PokedexData Woobat = new()
    {
        number = 527,
        name = "Woobat",
        category = "Bat",
        height = 40,
        weight = 2100,
        entry = WoobatDesc,
        forms = SingleSpecies(SpeciesID.Woobat),
    };
    public static readonly PokedexData Swoobat = new()
    {
        number = 528,
        name = "Swoobat",
        category = "Courting",
        height = 90,
        weight = 10500,
        entry = SwoobatDesc,
        forms = SingleSpecies(SpeciesID.Swoobat),
    };
    public static readonly PokedexData Drilbur = new()
    {
        number = 529,
        name = "Drilbur",
        category = "Mole",
        height = 30,
        weight = 8500,
        entry = DrilburDesc,
        forms = SingleSpecies(SpeciesID.Drilbur),
    };
    public static readonly PokedexData Excadrill = new()
    {
        number = 530,
        name = "Excadrill",
        category = "Subterrene",
        height = 70,
        weight = 40400,
        entry = ExcadrillDesc,
        forms = SingleSpecies(SpeciesID.Excadrill),
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
            SpeciesID.Audino,
            SpeciesID.AudinoMega
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
        forms = SingleSpecies(SpeciesID.Timburr),
    };
    public static readonly PokedexData Gurdurr = new()
    {
        number = 533,
        name = "Gurdurr",
        category = "Muscular",
        height = 120,
        weight = 40000,
        entry = GurdurrDesc,
        forms = SingleSpecies(SpeciesID.Gurdurr),
    };
    public static readonly PokedexData Conkeldurr = new()
    {
        number = 534,
        name = "Conkeldurr",
        category = "Muscular",
        height = 140,
        weight = 87000,
        entry = ConkeldurrDesc,
        forms = SingleSpecies(SpeciesID.Conkeldurr),
    };
    public static readonly PokedexData Tympole = new()
    {
        number = 535,
        name = "Tympole",
        category = "Tadpole",
        height = 50,
        weight = 4500,
        entry = TympoleDesc,
        forms = SingleSpecies(SpeciesID.Tympole),
    };
    public static readonly PokedexData Palpitoad = new()
    {
        number = 536,
        name = "Palpitoad",
        category = "Vibration",
        height = 80,
        weight = 17000,
        entry = PalpitoadDesc,
        forms = SingleSpecies(SpeciesID.Palpitoad),
    };
    public static readonly PokedexData Seismitoad = new()
    {
        number = 537,
        name = "Seismitoad",
        category = "Vibration",
        height = 150,
        weight = 62000,
        entry = SeismitoadDesc,
        forms = SingleSpecies(SpeciesID.Seismitoad),
    };
    public static readonly PokedexData Throh = new()
    {
        number = 538,
        name = "Throh",
        category = "Judo",
        height = 130,
        weight = 55500,
        entry = ThrohDesc,
        forms = SingleSpecies(SpeciesID.Throh),
    };
    public static readonly PokedexData Sawk = new()
    {
        number = 539,
        name = "Sawk",
        category = "Karate",
        height = 140,
        weight = 51000,
        entry = SawkDesc,
        forms = SingleSpecies(SpeciesID.Sawk),
    };
    public static readonly PokedexData Sewaddle = new()
    {
        number = 540,
        name = "Sewaddle",
        category = "Sewing",
        height = 30,
        weight = 2500,
        entry = SewaddleDesc,
        forms = SingleSpecies(SpeciesID.Sewaddle),
    };
    public static readonly PokedexData Swadloon = new()
    {
        number = 541,
        name = "Swadloon",
        category = "Leaf-Wrapped",
        height = 50,
        weight = 7300,
        entry = SwadloonDesc,
        forms = SingleSpecies(SpeciesID.Swadloon),
    };
    public static readonly PokedexData Leavanny = new()
    {
        number = 542,
        name = "Leavanny",
        category = "Nurturing",
        height = 120,
        weight = 20500,
        entry = LeavannyDesc,
        forms = SingleSpecies(SpeciesID.Leavanny),
    };
    public static readonly PokedexData Venipede = new()
    {
        number = 543,
        name = "Venipede",
        category = "Centipede",
        height = 40,
        weight = 5300,
        entry = VenipedeDesc,
        forms = SingleSpecies(SpeciesID.Venipede),
    };
    public static readonly PokedexData Whirlipede = new()
    {
        number = 544,
        name = "Whirlipede",
        category = "Curlipede",
        height = 120,
        weight = 58500,
        entry = WhirlipedeDesc,
        forms = SingleSpecies(SpeciesID.Whirlipede),
    };
    public static readonly PokedexData Scolipede = new()
    {
        number = 545,
        name = "Scolipede",
        category = "Megapede",
        height = 250,
        weight = 200500,
        entry = ScolipedeDesc,
        forms = SingleSpecies(SpeciesID.Scolipede),
    };
    public static readonly PokedexData Cottonee = new()
    {
        number = 546,
        name = "Cottonee",
        category = "Cotton Puff",
        height = 30,
        weight = 600,
        entry = CottoneeDesc,
        forms = SingleSpecies(SpeciesID.Cottonee),
    };
    public static readonly PokedexData Whimsicott = new()
    {
        number = 547,
        name = "Whimsicott",
        category = "Windveiled",
        height = 70,
        weight = 6600,
        entry = WhimsicottDesc,
        forms = SingleSpecies(SpeciesID.Whimsicott),
    };
    public static readonly PokedexData Petilil = new()
    {
        number = 548,
        name = "Petilil",
        category = "Bulb",
        height = 50,
        weight = 6600,
        entry = PetililDesc,
        forms = SingleSpecies(SpeciesID.Petilil),
    };
    public static readonly PokedexData Lilligant = new()
    {
        number = 549,
        name = "Lilligant",
        category = "Flowering",
        height = 110,
        weight = 16300,
        entry = LilligantDesc,
        forms = new[]
        {
            SpeciesID.Lilligant,
            SpeciesID.LilligantHisui
        }
    };
    public static readonly PokedexData Basculin = new()
    {
        number = 550,
        name = "Basculin",
        category = "Hostile",
        height = 100,
        weight = 18000,
        entry = BasculinDesc,
        forms = SingleSpecies(SpeciesID.BasculinRed),
    };
    public static readonly PokedexData Sandile = new()
    {
        number = 551,
        name = "Sandile",
        category = "DesertCroc",
        height = 70,
        weight = 15200,
        entry = SandileDesc,
        forms = SingleSpecies(SpeciesID.Sandile),
    };
    public static readonly PokedexData Krokorok = new()
    {
        number = 552,
        name = "Krokorok",
        category = "Desert Croc",
        height = 100,
        weight = 33400,
        entry = KrokorokDesc,
        forms = SingleSpecies(SpeciesID.Krokorok),
    };
    public static readonly PokedexData Krookodile = new()
    {
        number = 553,
        name = "Krookodile",
        category = "Intimidate",
        height = 150,
        weight = 96300,
        entry = KrookodileDesc,
        forms = SingleSpecies(SpeciesID.Krookodile),
    };
    public static readonly PokedexData Darumaka = new()
    {
        number = 554,
        name = "Darumaka",
        category = "Zen Charm",
        height = 60,
        weight = 37500,
        entry = DarumakaDesc,
        forms = new[]
        {
            SpeciesID.Darumaka,
            SpeciesID.DarumakaGalar
        }
    };
    public static readonly PokedexData Darmanitan = new()
    {
        number = 555,
        name = "Darmanitan",
        category = "Blazing",
        height = 130,
        weight = 92900,
        entry = DarmanitanDesc,
        forms = new[]
        {
            SpeciesID.Darmanitan,
            SpeciesID.DarmanitanZen,
            SpeciesID.DarmanitanGalar,
            SpeciesID.DarmanitanGalarZen
        }
    };
    public static readonly PokedexData Maractus = new()
    {
        number = 556,
        name = "Maractus",
        category = "Cactus",
        height = 100,
        weight = 28000,
        entry = MaractusDesc,
        forms = SingleSpecies(SpeciesID.Maractus),
    };
    public static readonly PokedexData Dwebble = new()
    {
        number = 557,
        name = "Dwebble",
        category = "Rock Inn",
        height = 30,
        weight = 14500,
        entry = DwebbleDesc,
        forms = SingleSpecies(SpeciesID.Dwebble),
    };
    public static readonly PokedexData Crustle = new()
    {
        number = 558,
        name = "Crustle",
        category = "Stone Home",
        height = 140,
        weight = 200000,
        entry = CrustleDesc,
        forms = SingleSpecies(SpeciesID.Crustle),
    };
    public static readonly PokedexData Scraggy = new()
    {
        number = 559,
        name = "Scraggy",
        category = "Shedding",
        height = 60,
        weight = 11800,
        entry = ScraggyDesc,
        forms = SingleSpecies(SpeciesID.Scraggy),
    };
    public static readonly PokedexData Scrafty = new()
    {
        number = 560,
        name = "Scrafty",
        category = "Hoodlum",
        height = 110,
        weight = 30000,
        entry = ScraftyDesc,
        forms = SingleSpecies(SpeciesID.Scrafty),
    };
    public static readonly PokedexData Sigilyph = new()
    {
        number = 561,
        name = "Sigilyph",
        category = "Avianoid",
        height = 140,
        weight = 14000,
        entry = SigilyphDesc,
        forms = SingleSpecies(SpeciesID.Sigilyph),
    };
    public static readonly PokedexData Yamask = new()
    {
        number = 562,
        name = "Yamask",
        category = "Spirit",
        height = 50,
        weight = 1500,
        entry = YamaskDesc,
        forms = new[]
        {
            SpeciesID.Yamask,
            SpeciesID.YamaskGalar
        }
    };
    public static readonly PokedexData Cofagrigus = new()
    {
        number = 563,
        name = "Cofagrigus",
        category = "Coffin",
        height = 170,
        weight = 76500,
        entry = CofagrigusDesc,
        forms = SingleSpecies(SpeciesID.Cofagrigus),
    };
    public static readonly PokedexData Tirtouga = new()
    {
        number = 564,
        name = "Tirtouga",
        category = "Prototurtle",
        height = 70,
        weight = 16500,
        entry = TirtougaDesc,
        forms = SingleSpecies(SpeciesID.Tirtouga),
    };
    public static readonly PokedexData Carracosta = new()
    {
        number = 565,
        name = "Carracosta",
        category = "Prototurtle",
        height = 120,
        weight = 81000,
        entry = CarracostaDesc,
        forms = SingleSpecies(SpeciesID.Carracosta),
    };
    public static readonly PokedexData Archen = new()
    {
        number = 566,
        name = "Archen",
        category = "First Bird",
        height = 50,
        weight = 9500,
        entry = ArchenDesc,
        forms = SingleSpecies(SpeciesID.Archen),
    };
    public static readonly PokedexData Archeops = new()
    {
        number = 567,
        name = "Archeops",
        category = "First Bird",
        height = 140,
        weight = 32000,
        entry = ArcheopsDesc,
        forms = SingleSpecies(SpeciesID.Archeops),
    };
    public static readonly PokedexData Trubbish = new()
    {
        number = 568,
        name = "Trubbish",
        category = "Trash Bag",
        height = 60,
        weight = 31000,
        entry = TrubbishDesc,
        forms = SingleSpecies(SpeciesID.Trubbish),
    };
    public static readonly PokedexData Garbodor = new()
    {
        number = 569,
        name = "Garbodor",
        category = "Trash Heap",
        height = 190,
        weight = 107300,
        entry = GarbodorDesc,
        forms = SingleSpecies(SpeciesID.Garbodor),
    };
    public static readonly PokedexData Zorua = new()
    {
        number = 570,
        name = "Zorua",
        category = "Tricky Fox",
        height = 70,
        weight = 12500,
        entry = ZoruaDesc,
        forms = new[]
        {
            SpeciesID.Zorua,
            SpeciesID.ZoruaHisui
        }
    };
    public static readonly PokedexData Zoroark = new()
    {
        number = 571,
        name = "Zoroark",
        category = "Illusion Fox",
        height = 160,
        weight = 81100,
        entry = ZoroarkDesc,
        forms = new[]
        {
            SpeciesID.Zoroark,
            SpeciesID.ZoroarkHisui
        }
    };
    public static readonly PokedexData Minccino = new()
    {
        number = 572,
        name = "Minccino",
        category = "Chinchilla",
        height = 40,
        weight = 5800,
        entry = MinccinoDesc,
        forms = SingleSpecies(SpeciesID.Minccino),
    };
    public static readonly PokedexData Cinccino = new()
    {
        number = 573,
        name = "Cinccino",
        category = "Scarf",
        height = 50,
        weight = 7500,
        entry = CinccinoDesc,
        forms = SingleSpecies(SpeciesID.Cinccino),
    };
    public static readonly PokedexData Gothita = new()
    {
        number = 574,
        name = "Gothita",
        category = "Fixation",
        height = 40,
        weight = 5800,
        entry = GothitaDesc,
        forms = SingleSpecies(SpeciesID.Gothita),
    };
    public static readonly PokedexData Gothorita = new()
    {
        number = 575,
        name = "Gothorita",
        category = "Manipulate",
        height = 70,
        weight = 18000,
        entry = GothoritaDesc,
        forms = SingleSpecies(SpeciesID.Gothorita),
    };
    public static readonly PokedexData Gothitelle = new()
    {
        number = 576,
        name = "Gothitelle",
        category = "Astral Body",
        height = 150,
        weight = 44000,
        entry = GothitelleDesc,
        forms = SingleSpecies(SpeciesID.Gothitelle),
    };
    public static readonly PokedexData Solosis = new()
    {
        number = 577,
        name = "Solosis",
        category = "Cell",
        height = 30,
        weight = 1000,
        entry = SolosisDesc,
        forms = SingleSpecies(SpeciesID.Solosis),
    };
    public static readonly PokedexData Duosion = new()
    {
        number = 578,
        name = "Duosion",
        category = "Mitosis",
        height = 60,
        weight = 8000,
        entry = DuosionDesc,
        forms = SingleSpecies(SpeciesID.Duosion),
    };
    public static readonly PokedexData Reuniclus = new()
    {
        number = 579,
        name = "Reuniclus",
        category = "Multiplying",
        height = 100,
        weight = 20100,
        entry = ReuniclusDesc,
        forms = SingleSpecies(SpeciesID.Reuniclus),
    };
    public static readonly PokedexData Ducklett = new()
    {
        number = 580,
        name = "Ducklett",
        category = "Water Bird",
        height = 50,
        weight = 5500,
        entry = DucklettDesc,
        forms = SingleSpecies(SpeciesID.Ducklett),
    };
    public static readonly PokedexData Swanna = new()
    {
        number = 581,
        name = "Swanna",
        category = "White Bird",
        height = 130,
        weight = 24200,
        entry = SwannaDesc,
        forms = SingleSpecies(SpeciesID.Swanna),
    };
    public static readonly PokedexData Vanillite = new()
    {
        number = 582,
        name = "Vanillite",
        category = "Fresh Snow",
        height = 40,
        weight = 5700,
        entry = VanilliteDesc,
        forms = SingleSpecies(SpeciesID.Vanillite),
    };
    public static readonly PokedexData Vanillish = new()
    {
        number = 583,
        name = "Vanillish",
        category = "Icy Snow",
        height = 110,
        weight = 41000,
        entry = VanillishDesc,
        forms = SingleSpecies(SpeciesID.Vanillish),
    };
    public static readonly PokedexData Vanilluxe = new()
    {
        number = 584,
        name = "Vanilluxe",
        category = "Snowstorm",
        height = 130,
        weight = 57500,
        entry = VanilluxeDesc,
        forms = SingleSpecies(SpeciesID.Vanilluxe),
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
            SpeciesID.DeerlingSpring,
            SpeciesID.DeerlingSummer,
            SpeciesID.DeerlingAutumn,
            SpeciesID.DeerlingWinter
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
            SpeciesID.SawsbuckSpring,
            SpeciesID.SawsbuckSummer,
            SpeciesID.SawsbuckAutumn,
            SpeciesID.SawsbuckWinter
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
        forms = SingleSpecies(SpeciesID.Emolga),
    };
    public static readonly PokedexData Karrablast = new()
    {
        number = 588,
        name = "Karrablast",
        category = "Clamping",
        height = 50,
        weight = 5900,
        entry = KarrablastDesc,
        forms = SingleSpecies(SpeciesID.Karrablast),
    };
    public static readonly PokedexData Escavalier = new()
    {
        number = 589,
        name = "Escavalier",
        category = "Cavalry",
        height = 100,
        weight = 33000,
        entry = EscavalierDesc,
        forms = SingleSpecies(SpeciesID.Escavalier),
    };
    public static readonly PokedexData Foongus = new()
    {
        number = 590,
        name = "Foongus",
        category = "Mushroom",
        height = 20,
        weight = 1000,
        entry = FoongusDesc,
        forms = SingleSpecies(SpeciesID.Foongus),
    };
    public static readonly PokedexData Amoonguss = new()
    {
        number = 591,
        name = "Amoonguss",
        category = "Mushroom",
        height = 60,
        weight = 10500,
        entry = AmoongussDesc,
        forms = SingleSpecies(SpeciesID.Amoonguss),
    };
    public static readonly PokedexData Frillish = new()
    {
        number = 592,
        name = "Frillish",
        category = "Floating",
        height = 120,
        weight = 33000,
        entry = FrillishDesc,
        forms = SingleSpecies(SpeciesID.Frillish),
    };
    public static readonly PokedexData Jellicent = new()
    {
        number = 593,
        name = "Jellicent",
        category = "Floating",
        height = 220,
        weight = 135000,
        entry = JellicentDesc,
        forms = SingleSpecies(SpeciesID.Jellicent),
    };
    public static readonly PokedexData Alomomola = new()
    {
        number = 594,
        name = "Alomomola",
        category = "Caring",
        height = 120,
        weight = 31600,
        entry = AlomomolaDesc,
        forms = SingleSpecies(SpeciesID.Alomomola),
    };
    public static readonly PokedexData Joltik = new()
    {
        number = 595,
        name = "Joltik",
        category = "Attaching",
        height = 10,
        weight = 600,
        entry = JoltikDesc,
        forms = SingleSpecies(SpeciesID.Joltik),
    };
    public static readonly PokedexData Galvantula = new()
    {
        number = 596,
        name = "Galvantula",
        category = "EleSpider",
        height = 80,
        weight = 14300,
        entry = GalvantulaDesc,
        forms = SingleSpecies(SpeciesID.Galvantula),
    };
    public static readonly PokedexData Ferroseed = new()
    {
        number = 597,
        name = "Ferroseed",
        category = "Thorn Seed",
        height = 60,
        weight = 18800,
        entry = FerroseedDesc,
        forms = SingleSpecies(SpeciesID.Ferroseed),
    };
    public static readonly PokedexData Ferrothorn = new()
    {
        number = 598,
        name = "Ferrothorn",
        category = "Thorn Pod",
        height = 100,
        weight = 110000,
        entry = FerrothornDesc,
        forms = SingleSpecies(SpeciesID.Ferrothorn),
    };
    public static readonly PokedexData Klink = new()
    {
        number = 599,
        name = "Klink",
        category = "Gear",
        height = 30,
        weight = 21000,
        entry = KlinkDesc,
        forms = SingleSpecies(SpeciesID.Klink),
    };
    public static readonly PokedexData Klang = new()
    {
        number = 600,
        name = "Klang",
        category = "Gear",
        height = 60,
        weight = 51000,
        entry = KlangDesc,
        forms = SingleSpecies(SpeciesID.Klang),
    };
    public static readonly PokedexData Klinklang = new()
    {
        number = 601,
        name = "Klinklang",
        category = "Gear",
        height = 60,
        weight = 81000,
        entry = KlinklangDesc,
        forms = SingleSpecies(SpeciesID.Klinklang),
    };
    public static readonly PokedexData Tynamo = new()
    {
        number = 602,
        name = "Tynamo",
        category = "EleFish",
        height = 20,
        weight = 300,
        entry = TynamoDesc,
        forms = SingleSpecies(SpeciesID.Tynamo),
    };
    public static readonly PokedexData Eelektrik = new()
    {
        number = 603,
        name = "Eelektrik",
        category = "EleFish",
        height = 120,
        weight = 22000,
        entry = EelektrikDesc,
        forms = SingleSpecies(SpeciesID.Eelektrik),
    };
    public static readonly PokedexData Eelektross = new()
    {
        number = 604,
        name = "Eelektross",
        category = "EleFish",
        height = 210,
        weight = 80500,
        entry = EelektrossDesc,
        forms = SingleSpecies(SpeciesID.Eelektross),
    };
    public static readonly PokedexData Elgyem = new()
    {
        number = 605,
        name = "Elgyem",
        category = "Cerebral",
        height = 50,
        weight = 9000,
        entry = ElgyemDesc,
        forms = SingleSpecies(SpeciesID.Elgyem),
    };
    public static readonly PokedexData Beheeyem = new()
    {
        number = 606,
        name = "Beheeyem",
        category = "Cerebral",
        height = 100,
        weight = 34500,
        entry = BeheeyemDesc,
        forms = SingleSpecies(SpeciesID.Beheeyem),
    };
    public static readonly PokedexData Litwick = new()
    {
        number = 607,
        name = "Litwick",
        category = "Candle",
        height = 30,
        weight = 3100,
        entry = LitwickDesc,
        forms = SingleSpecies(SpeciesID.Litwick),
    };
    public static readonly PokedexData Lampent = new()
    {
        number = 608,
        name = "Lampent",
        category = "Lamp",
        height = 60,
        weight = 13000,
        entry = LampentDesc,
        forms = SingleSpecies(SpeciesID.Lampent),
    };
    public static readonly PokedexData Chandelure = new()
    {
        number = 609,
        name = "Chandelure",
        category = "Luring",
        height = 100,
        weight = 34300,
        entry = ChandelureDesc,
        forms = SingleSpecies(SpeciesID.Chandelure),
    };
    public static readonly PokedexData Axew = new()
    {
        number = 610,
        name = "Axew",
        category = "Tusk",
        height = 60,
        weight = 18000,
        entry = AxewDesc,
        forms = SingleSpecies(SpeciesID.Axew),
    };
    public static readonly PokedexData Fraxure = new()
    {
        number = 611,
        name = "Fraxure",
        category = "Axe Jaw",
        height = 100,
        weight = 36000,
        entry = FraxureDesc,
        forms = SingleSpecies(SpeciesID.Fraxure),
    };
    public static readonly PokedexData Haxorus = new()
    {
        number = 612,
        name = "Haxorus",
        category = "Axe Jaw",
        height = 180,
        weight = 105500,
        entry = HaxorusDesc,
        forms = SingleSpecies(SpeciesID.Haxorus),
    };
    public static readonly PokedexData Cubchoo = new()
    {
        number = 613,
        name = "Cubchoo",
        category = "Chill",
        height = 50,
        weight = 8500,
        entry = CubchooDesc,
        forms = SingleSpecies(SpeciesID.Cubchoo),
    };
    public static readonly PokedexData Beartic = new()
    {
        number = 614,
        name = "Beartic",
        category = "Freezing",
        height = 260,
        weight = 260000,
        entry = BearticDesc,
        forms = SingleSpecies(SpeciesID.Beartic),
    };
    public static readonly PokedexData Cryogonal = new()
    {
        number = 615,
        name = "Cryogonal",
        category = "Crystallize",
        height = 110,
        weight = 148000,
        entry = CryogonalDesc,
        forms = SingleSpecies(SpeciesID.Cryogonal),
    };
    public static readonly PokedexData Shelmet = new()
    {
        number = 616,
        name = "Shelmet",
        category = "Snail",
        height = 40,
        weight = 7700,
        entry = ShelmetDesc,
        forms = SingleSpecies(SpeciesID.Shelmet),
    };
    public static readonly PokedexData Accelgor = new()
    {
        number = 617,
        name = "Accelgor",
        category = "Shell Out",
        height = 80,
        weight = 25300,
        entry = AccelgorDesc,
        forms = SingleSpecies(SpeciesID.Accelgor),
    };
    public static readonly PokedexData Stunfisk = new()
    {
        number = 618,
        name = "Stunfisk",
        category = "Trap",
        height = 70,
        weight = 11000,
        entry = StunfiskDesc,
        forms = new[]
        {
            SpeciesID.Stunfisk,
            SpeciesID.StunfiskGalar
        }
    };
    public static readonly PokedexData Mienfoo = new()
    {
        number = 619,
        name = "Mienfoo",
        category = "Martial Arts",
        height = 90,
        weight = 20000,
        entry = MienfooDesc,
        forms = SingleSpecies(SpeciesID.Mienfoo),
    };
    public static readonly PokedexData Mienshao = new()
    {
        number = 620,
        name = "Mienshao",
        category = "Martial Arts",
        height = 140,
        weight = 35500,
        entry = MienshaoDesc,
        forms = SingleSpecies(SpeciesID.Mienshao),
    };
    public static readonly PokedexData Druddigon = new()
    {
        number = 621,
        name = "Druddigon",
        category = "Cave",
        height = 160,
        weight = 139000,
        entry = DruddigonDesc,
        forms = SingleSpecies(SpeciesID.Druddigon),
    };
    public static readonly PokedexData Golett = new()
    {
        number = 622,
        name = "Golett",
        category = "Automaton",
        height = 100,
        weight = 92000,
        entry = GolettDesc,
        forms = SingleSpecies(SpeciesID.Golett),
    };
    public static readonly PokedexData Golurk = new()
    {
        number = 623,
        name = "Golurk",
        category = "Automaton",
        height = 280,
        weight = 330000,
        entry = GolurkDesc,
        forms = SingleSpecies(SpeciesID.Golurk),
    };
    public static readonly PokedexData Pawniard = new()
    {
        number = 624,
        name = "Pawniard",
        category = "Sharp Blade",
        height = 50,
        weight = 10200,
        entry = PawniardDesc,
        forms = SingleSpecies(SpeciesID.Pawniard),
    };
    public static readonly PokedexData Bisharp = new()
    {
        number = 625,
        name = "Bisharp",
        category = "Sword Blade",
        height = 160,
        weight = 70000,
        entry = BisharpDesc,
        forms = SingleSpecies(SpeciesID.Bisharp),
    };
    public static readonly PokedexData Bouffalant = new()
    {
        number = 626,
        name = "Bouffalant",
        category = "Bash Buffalo",
        height = 160,
        weight = 94600,
        entry = BouffalantDesc,
        forms = SingleSpecies(SpeciesID.Bouffalant),
    };
    public static readonly PokedexData Rufflet = new()
    {
        number = 627,
        name = "Rufflet",
        category = "Eaglet",
        height = 50,
        weight = 10500,
        entry = RuffletDesc,
        forms = SingleSpecies(SpeciesID.Rufflet),
    };
    public static readonly PokedexData Braviary = new()
    {
        number = 628,
        name = "Braviary",
        category = "Valiant",
        height = 150,
        weight = 41000,
        entry = BraviaryDesc,
        forms = new[]
        {
            SpeciesID.Braviary,
            SpeciesID.BraviaryHisui
        }
    };
    public static readonly PokedexData Vullaby = new()
    {
        number = 629,
        name = "Vullaby",
        category = "Diapered",
        height = 50,
        weight = 9000,
        entry = VullabyDesc,
        forms = SingleSpecies(SpeciesID.Vullaby),
    };
    public static readonly PokedexData Mandibuzz = new()
    {
        number = 630,
        name = "Mandibuzz",
        category = "Bone Vulture",
        height = 120,
        weight = 39500,
        entry = MandibuzzDesc,
        forms = SingleSpecies(SpeciesID.Mandibuzz),
    };
    public static readonly PokedexData Heatmor = new()
    {
        number = 631,
        name = "Heatmor",
        category = "Anteater",
        height = 140,
        weight = 58000,
        entry = HeatmorDesc,
        forms = SingleSpecies(SpeciesID.Heatmor),
    };
    public static readonly PokedexData Durant = new()
    {
        number = 632,
        name = "Durant",
        category = "Iron Ant",
        height = 30,
        weight = 33000,
        entry = DurantDesc,
        forms = SingleSpecies(SpeciesID.Durant),
    };
    public static readonly PokedexData Deino = new()
    {
        number = 633,
        name = "Deino",
        category = "Irate",
        height = 80,
        weight = 17300,
        entry = DeinoDesc,
        forms = SingleSpecies(SpeciesID.Deino),
    };
    public static readonly PokedexData Zweilous = new()
    {
        number = 634,
        name = "Zweilous",
        category = "Hostile",
        height = 140,
        weight = 50000,
        entry = ZweilousDesc,
        forms = SingleSpecies(SpeciesID.Zweilous),
    };
    public static readonly PokedexData Hydreigon = new()
    {
        number = 635,
        name = "Hydreigon",
        category = "Brutal",
        height = 180,
        weight = 160000,
        entry = HydreigonDesc,
        forms = SingleSpecies(SpeciesID.Hydreigon),
    };
    public static readonly PokedexData Larvesta = new()
    {
        number = 636,
        name = "Larvesta",
        category = "Torch",
        height = 110,
        weight = 28800,
        entry = LarvestaDesc,
        forms = SingleSpecies(SpeciesID.Larvesta),
    };
    public static readonly PokedexData Volcarona = new()
    {
        number = 637,
        name = "Volcarona",
        category = "Sun",
        height = 160,
        weight = 46000,
        entry = VolcaronaDesc,
        forms = SingleSpecies(SpeciesID.Volcarona),
    };
    public static readonly PokedexData Cobalion = new()
    {
        number = 638,
        name = "Cobalion",
        category = "Iron Will",
        height = 210,
        weight = 250000,
        entry = CobalionDesc,
        forms = SingleSpecies(SpeciesID.Cobalion),
    };
    public static readonly PokedexData Terrakion = new()
    {
        number = 639,
        name = "Terrakion",
        category = "Cavern",
        height = 190,
        weight = 260000,
        entry = TerrakionDesc,
        forms = SingleSpecies(SpeciesID.Terrakion),
    };
    public static readonly PokedexData Virizion = new()
    {
        number = 640,
        name = "Virizion",
        category = "Grassland",
        height = 200,
        weight = 200000,
        entry = VirizionDesc,
        forms = SingleSpecies(SpeciesID.Virizion),
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
            SpeciesID.TornadusI,
            SpeciesID.TornadusT
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
            SpeciesID.ThundurusI,
            SpeciesID.ThundurusT
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
        forms = SingleSpecies(SpeciesID.Reshiram),
    };
    public static readonly PokedexData Zekrom = new()
    {
        number = 644,
        name = "Zekrom",
        category = "Deep Black",
        height = 290,
        weight = 345000,
        entry = ZekromDesc,
        forms = SingleSpecies(SpeciesID.Zekrom),
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
            SpeciesID.LandorusI,
            SpeciesID.LandorusT
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
            SpeciesID.Kyurem,
            SpeciesID.KyuremWhite,
            SpeciesID.KyuremBlack
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
            SpeciesID.KeldeoOriginal,
            SpeciesID.KeldeoResolute
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
            SpeciesID.MeloettaAria,
            SpeciesID.MeloettaPirouette
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
            SpeciesID.GenesectNormal,
            SpeciesID.GenesectDouse,
            SpeciesID.GenesectShock,
            SpeciesID.GenesectBurn,
            SpeciesID.GenesectChill
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
        forms = SingleSpecies(SpeciesID.Chespin),
    };
    public static readonly PokedexData Quilladin = new()
    {
        number = 651,
        name = "Quilladin",
        category = "Spiny Armor",
        height = 70,
        weight = 29000,
        entry = QuilladinDesc,
        forms = SingleSpecies(SpeciesID.Quilladin),
    };
    public static readonly PokedexData Chesnaught = new()
    {
        number = 652,
        name = "Chesnaught",
        category = "Spiny Armor",
        height = 160,
        weight = 90000,
        entry = ChesnaughtDesc,
        forms = SingleSpecies(SpeciesID.Chesnaught),
    };
    public static readonly PokedexData Fennekin = new()
    {
        number = 653,
        name = "Fennekin",
        category = "Fox",
        height = 40,
        weight = 9400,
        entry = FennekinDesc,
        forms = SingleSpecies(SpeciesID.Fennekin),
    };
    public static readonly PokedexData Braixen = new()
    {
        number = 654,
        name = "Braixen",
        category = "Fox",
        height = 100,
        weight = 14500,
        entry = BraixenDesc,
        forms = SingleSpecies(SpeciesID.Braixen),
    };
    public static readonly PokedexData Delphox = new()
    {
        number = 655,
        name = "Delphox",
        category = "Fox",
        height = 150,
        weight = 39000,
        entry = DelphoxDesc,
        forms = SingleSpecies(SpeciesID.Delphox),
    };
    public static readonly PokedexData Froakie = new()
    {
        number = 656,
        name = "Froakie",
        category = "Bubble Frog",
        height = 30,
        weight = 7000,
        entry = FroakieDesc,
        forms = SingleSpecies(SpeciesID.Froakie),
    };
    public static readonly PokedexData Frogadier = new()
    {
        number = 657,
        name = "Frogadier",
        category = "Bubble Frog",
        height = 60,
        weight = 10900,
        entry = FrogadierDesc,
        forms = SingleSpecies(SpeciesID.Frogadier),
    };
    public static readonly PokedexData Greninja = new()
    {
        number = 658,
        name = "Greninja",
        category = "Ninja",
        height = 150,
        weight = 40000,
        entry = GreninjaDesc,
        forms = SingleSpecies(SpeciesID.Greninja),
    };
    public static readonly PokedexData Bunnelby = new()
    {
        number = 659,
        name = "Bunnelby",
        category = "Digging",
        height = 40,
        weight = 5000,
        entry = BunnelbyDesc,
        forms = SingleSpecies(SpeciesID.Bunnelby),
    };
    public static readonly PokedexData Diggersby = new()
    {
        number = 660,
        name = "Diggersby",
        category = "Digging",
        height = 100,
        weight = 42400,
        entry = DiggersbyDesc,
        forms = SingleSpecies(SpeciesID.Diggersby),
    };
    public static readonly PokedexData Fletchling = new()
    {
        number = 661,
        name = "Fletchling",
        category = "Tiny Robin",
        height = 30,
        weight = 1700,
        entry = FletchlingDesc,
        forms = SingleSpecies(SpeciesID.Fletchling),
    };
    public static readonly PokedexData Fletchinder = new()
    {
        number = 662,
        name = "Fletchinder",
        category = "Ember",
        height = 70,
        weight = 16000,
        entry = FletchinderDesc,
        forms = SingleSpecies(SpeciesID.Fletchinder),
    };
    public static readonly PokedexData Talonflame = new()
    {
        number = 663,
        name = "Talonflame",
        category = "Scorching",
        height = 120,
        weight = 24500,
        entry = TalonflameDesc,
        forms = SingleSpecies(SpeciesID.Talonflame),
    };
    public static readonly PokedexData Scatterbug = new()
    {
        number = 664,
        name = "Scatterbug",
        category = "Scatterdust",
        height = 30,
        weight = 2500,
        entry = ScatterbugDesc,
        forms = SingleSpecies(SpeciesID.ScatterbugMeadow),
    };
    public static readonly PokedexData Spewpa = new()
    {
        number = 665,
        name = "Spewpa",
        category = "Scatterdust",
        height = 30,
        weight = 8400,
        entry = SpewpaDesc,
        forms = SingleSpecies(SpeciesID.SpewpaMeadow),
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
            SpeciesID.VivillonMeadow,
            SpeciesID.VivillonArchipelago,
            SpeciesID.VivillonContinental,
            SpeciesID.VivillonElegant,
            SpeciesID.VivillonFancy,
            SpeciesID.VivillonGarden,
            SpeciesID.VivillonHighPlains,
            SpeciesID.VivillonIcySnow,
            SpeciesID.VivillonJungle,
            SpeciesID.VivillonMarine,
            SpeciesID.VivillonModern,
            SpeciesID.VivillonMonsoon,
            SpeciesID.VivillonOcean,
            SpeciesID.VivillonPokeBall,
            SpeciesID.VivillonPolar,
            SpeciesID.VivillonRiver,
            SpeciesID.VivillonSandstorm,
            SpeciesID.VivillonSavanna,
            SpeciesID.VivillonSun,
            SpeciesID.VivillonTundra,
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
        forms = SingleSpecies(SpeciesID.Litleo),
    };
    public static readonly PokedexData Pyroar = new()
    {
        number = 668,
        name = "Pyroar",
        category = "Royal",
        height = 150,
        weight = 81500,
        entry = PyroarDesc,
        forms = SingleSpecies(SpeciesID.Pyroar),
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
            SpeciesID.FlabebeRed,
            SpeciesID.FlabebeYellow,
            SpeciesID.FlabebeOrange,
            SpeciesID.FlabebeBlue,
            SpeciesID.FlabebeWhite
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
            SpeciesID.FloetteRed,
            SpeciesID.FloetteYellow,
            SpeciesID.FloetteOrange,
            SpeciesID.FloetteBlue,
            SpeciesID.FloetteWhite,
            SpeciesID.FloetteEternal
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
            SpeciesID.FlorgesRed,
            SpeciesID.FlorgesYellow,
            SpeciesID.FlorgesOrange,
            SpeciesID.FlorgesBlue,
            SpeciesID.FlorgesWhite
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
        forms = SingleSpecies(SpeciesID.Skiddo),
    };
    public static readonly PokedexData Gogoat = new()
    {
        number = 673,
        name = "Gogoat",
        category = "Mount",
        height = 170,
        weight = 91000,
        entry = GogoatDesc,
        forms = SingleSpecies(SpeciesID.Gogoat),
    };
    public static readonly PokedexData Pancham = new()
    {
        number = 674,
        name = "Pancham",
        category = "Playful",
        height = 60,
        weight = 8000,
        entry = PanchamDesc,
        forms = SingleSpecies(SpeciesID.Pancham),
    };
    public static readonly PokedexData Pangoro = new()
    {
        number = 675,
        name = "Pangoro",
        category = "Daunting",
        height = 210,
        weight = 136000,
        entry = PangoroDesc,
        forms = SingleSpecies(SpeciesID.Pangoro),
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
            SpeciesID.FurfrouNatural,
            SpeciesID.FurfrouHeart,
            SpeciesID.FurfrouStar,
            SpeciesID.FurfrouDiamond,
            SpeciesID.FurfrouDebutante,
            SpeciesID.FurfrouMatron,
            SpeciesID.FurfrouDandy,
            SpeciesID.FurfrouLaReine,
            SpeciesID.FurfrouKabuki,
            SpeciesID.FurfrouPharaoh
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
        forms = SingleSpecies(SpeciesID.Espurr),
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
            SpeciesID.MeowsticM,
            SpeciesID.MeowsticF
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
        forms = SingleSpecies(SpeciesID.Honedge),
    };
    public static readonly PokedexData Doublade = new()
    {
        number = 680,
        name = "Doublade",
        category = "Sword",
        height = 80,
        weight = 4500,
        entry = DoubladeDesc,
        forms = SingleSpecies(SpeciesID.Doublade),
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
            SpeciesID.AegislashShield,
            SpeciesID.AegislashBlade
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
        forms = SingleSpecies(SpeciesID.Spritzee),
    };
    public static readonly PokedexData Aromatisse = new()
    {
        number = 683,
        name = "Aromatisse",
        category = "Fragrance",
        height = 80,
        weight = 15500,
        entry = AromatisseDesc,
        forms = SingleSpecies(SpeciesID.Aromatisse),
    };
    public static readonly PokedexData Swirlix = new()
    {
        number = 684,
        name = "Swirlix",
        category = "Cotton Candy",
        height = 40,
        weight = 3500,
        entry = SwirlixDesc,
        forms = SingleSpecies(SpeciesID.Swirlix),
    };
    public static readonly PokedexData Slurpuff = new()
    {
        number = 685,
        name = "Slurpuff",
        category = "Meringue",
        height = 80,
        weight = 5000,
        entry = SlurpuffDesc,
        forms = SingleSpecies(SpeciesID.Slurpuff),
    };
    public static readonly PokedexData Inkay = new()
    {
        number = 686,
        name = "Inkay",
        category = "Revolving",
        height = 40,
        weight = 3500,
        entry = InkayDesc,
        forms = SingleSpecies(SpeciesID.Inkay),
    };
    public static readonly PokedexData Malamar = new()
    {
        number = 687,
        name = "Malamar",
        category = "Overturning",
        height = 150,
        weight = 47000,
        entry = MalamarDesc,
        forms = SingleSpecies(SpeciesID.Malamar),
    };
    public static readonly PokedexData Binacle = new()
    {
        number = 688,
        name = "Binacle",
        category = "Two-Handed",
        height = 50,
        weight = 31000,
        entry = BinacleDesc,
        forms = SingleSpecies(SpeciesID.Binacle),
    };
    public static readonly PokedexData Barbaracle = new()
    {
        number = 689,
        name = "Barbaracle",
        category = "Collective",
        height = 130,
        weight = 96000,
        entry = BarbaracleDesc,
        forms = SingleSpecies(SpeciesID.Barbaracle),
    };
    public static readonly PokedexData Skrelp = new()
    {
        number = 690,
        name = "Skrelp",
        category = "MockKelp",
        height = 50,
        weight = 7300,
        entry = SkrelpDesc,
        forms = SingleSpecies(SpeciesID.Skrelp),
    };
    public static readonly PokedexData Dragalge = new()
    {
        number = 691,
        name = "Dragalge",
        category = "Mock Kelp",
        height = 180,
        weight = 81500,
        entry = DragalgeDesc,
        forms = SingleSpecies(SpeciesID.Dragalge),
    };
    public static readonly PokedexData Clauncher = new()
    {
        number = 692,
        name = "Clauncher",
        category = "Water Gun",
        height = 50,
        weight = 8300,
        entry = ClauncherDesc,
        forms = SingleSpecies(SpeciesID.Clauncher),
    };
    public static readonly PokedexData Clawitzer = new()
    {
        number = 693,
        name = "Clawitzer",
        category = "Howitzer",
        height = 130,
        weight = 35300,
        entry = ClawitzerDesc,
        forms = SingleSpecies(SpeciesID.Clawitzer),
    };
    public static readonly PokedexData Helioptile = new()
    {
        number = 694,
        name = "Helioptile",
        category = "Generator",
        height = 50,
        weight = 6000,
        entry = HelioptileDesc,
        forms = SingleSpecies(SpeciesID.Helioptile),
    };
    public static readonly PokedexData Heliolisk = new()
    {
        number = 695,
        name = "Heliolisk",
        category = "Generator",
        height = 100,
        weight = 21000,
        entry = HelioliskDesc,
        forms = SingleSpecies(SpeciesID.Heliolisk),
    };
    public static readonly PokedexData Tyrunt = new()
    {
        number = 696,
        name = "Tyrunt",
        category = "Royal Heir",
        height = 80,
        weight = 26000,
        entry = TyruntDesc,
        forms = SingleSpecies(SpeciesID.Tyrunt),
    };
    public static readonly PokedexData Tyrantrum = new()
    {
        number = 697,
        name = "Tyrantrum",
        category = "Despot",
        height = 250,
        weight = 270000,
        entry = TyrantrumDesc,
        forms = SingleSpecies(SpeciesID.Tyrantrum),
    };
    public static readonly PokedexData Amaura = new()
    {
        number = 698,
        name = "Amaura",
        category = "Tundra",
        height = 130,
        weight = 25200,
        entry = AmauraDesc,
        forms = SingleSpecies(SpeciesID.Amaura),
    };
    public static readonly PokedexData Aurorus = new()
    {
        number = 699,
        name = "Aurorus",
        category = "Tundra",
        height = 270,
        weight = 225000,
        entry = AurorusDesc,
        forms = SingleSpecies(SpeciesID.Aurorus),
    };
    public static readonly PokedexData Sylveon = new()
    {
        number = 700,
        name = "Sylveon",
        category = "Intertwine",
        height = 100,
        weight = 23500,
        entry = SylveonDesc,
        forms = SingleSpecies(SpeciesID.Sylveon),
    };
    public static readonly PokedexData Hawlucha = new()
    {
        number = 701,
        name = "Hawlucha",
        category = "Wrestling",
        height = 80,
        weight = 21500,
        entry = HawluchaDesc,
        forms = SingleSpecies(SpeciesID.Hawlucha),
    };
    public static readonly PokedexData Dedenne = new()
    {
        number = 702,
        name = "Dedenne",
        category = "Antenna",
        height = 20,
        weight = 2200,
        entry = DedenneDesc,
        forms = SingleSpecies(SpeciesID.Dedenne),
    };
    public static readonly PokedexData Carbink = new()
    {
        number = 703,
        name = "Carbink",
        category = "Jewel",
        height = 30,
        weight = 5700,
        entry = CarbinkDesc,
        forms = SingleSpecies(SpeciesID.Carbink),
    };
    public static readonly PokedexData Goomy = new()
    {
        number = 704,
        name = "Goomy",
        category = "Soft Tissue",
        height = 30,
        weight = 2800,
        entry = GoomyDesc,
        forms = SingleSpecies(SpeciesID.Goomy),
    };
    public static readonly PokedexData Sliggoo = new()
    {
        number = 705,
        name = "Sliggoo",
        category = "Soft Tissue",
        height = 80,
        weight = 17500,
        entry = SliggooDesc,
        forms = new[]
        {
            SpeciesID.Sliggoo,
            SpeciesID.SliggooHisui
        }
    };
    public static readonly PokedexData Goodra = new()
    {
        number = 706,
        name = "Goodra",
        category = "Dragon",
        height = 200,
        weight = 150500,
        entry = GoodraDesc,
        forms = new[]
        {
            SpeciesID.Goodra,
            SpeciesID.GoodraHisui
        }
    };
    public static readonly PokedexData Klefki = new()
    {
        number = 707,
        name = "Klefki",
        category = "Key Ring",
        height = 20,
        weight = 3000,
        entry = KlefkiDesc,
        forms = SingleSpecies(SpeciesID.Klefki),
    };
    public static readonly PokedexData Phantump = new()
    {
        number = 708,
        name = "Phantump",
        category = "Stump",
        height = 40,
        weight = 7000,
        entry = PhantumpDesc,
        forms = SingleSpecies(SpeciesID.Phantump),
    };
    public static readonly PokedexData Trevenant = new()
    {
        number = 709,
        name = "Trevenant",
        category = "Elder Tree",
        height = 150,
        weight = 71000,
        entry = TrevenantDesc,
        forms = SingleSpecies(SpeciesID.Trevenant),
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
            SpeciesID.PumpkabooAverage,
            SpeciesID.PumpkabooSmall,
            SpeciesID.PumpkabooLarge,
            SpeciesID.PumpkabooSuper
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
            SpeciesID.GourgeistAverage,
            SpeciesID.GourgeistSmall,
            SpeciesID.GourgeistLarge,
            SpeciesID.GourgeistSuper
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
        forms = SingleSpecies(SpeciesID.Bergmite),
    };
    public static readonly PokedexData Avalugg = new()
    {
        number = 713,
        name = "Avalugg",
        category = "Iceberg",
        height = 200,
        weight = 505000,
        entry = AvaluggDesc,
        forms = new[]
        {
            SpeciesID.Avalugg,
            SpeciesID.AvaluggHisui
        }
    };
    public static readonly PokedexData Noibat = new()
    {
        number = 714,
        name = "Noibat",
        category = "Sound Wave",
        height = 50,
        weight = 8000,
        entry = NoibatDesc,
        forms = SingleSpecies(SpeciesID.Noibat),
    };
    public static readonly PokedexData Noivern = new()
    {
        number = 715,
        name = "Noivern",
        category = "Sound Wave",
        height = 150,
        weight = 85000,
        entry = NoivernDesc,
        forms = SingleSpecies(SpeciesID.Noivern),
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
            SpeciesID.XerneasInactive,
            SpeciesID.XerneasActive
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
        forms = SingleSpecies(SpeciesID.Yveltal),
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
            SpeciesID.Zygarde50,
            SpeciesID.Zygarde10,
            SpeciesID.ZygardeComplete
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
            SpeciesID.Diancie,
            SpeciesID.DiancieMega
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
            SpeciesID.Hoopa,
            SpeciesID.HoopaUnbound
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
        forms = SingleSpecies(SpeciesID.Volcanion),
    };
    public static readonly PokedexData Rowlet = new()
    {
        number = 722,
        name = "Rowlet",
        category = "Grass Quill",
        height = 30,
        weight = 1500,
        entry = RowletDesc,
        forms = SingleSpecies(SpeciesID.Rowlet),
    };
    public static readonly PokedexData Dartrix = new()
    {
        number = 723,
        name = "Dartrix",
        category = "Blade Quill",
        height = 70,
        weight = 16000,
        entry = DartrixDesc,
        forms = SingleSpecies(SpeciesID.Dartrix),
    };
    public static readonly PokedexData Decidueye = new()
    {
        number = 724,
        name = "Decidueye",
        category = "Arrow Quill",
        height = 160,
        weight = 36600,
        entry = DecidueyeDesc,
        forms = new[]
        {
            SpeciesID.Decidueye,
            SpeciesID.DecidueyeHisui
        }
    };
    public static readonly PokedexData Litten = new()
    {
        number = 725,
        name = "Litten",
        category = "Fire Cat",
        height = 40,
        weight = 4300,
        entry = LittenDesc,
        forms = SingleSpecies(SpeciesID.Litten),
    };
    public static readonly PokedexData Torracat = new()
    {
        number = 726,
        name = "Torracat",
        category = "Fire Cat",
        height = 70,
        weight = 25000,
        entry = TorracatDesc,
        forms = SingleSpecies(SpeciesID.Torracat),
    };
    public static readonly PokedexData Incineroar = new()
    {
        number = 727,
        name = "Incineroar",
        category = "Heel",
        height = 180,
        weight = 83000,
        entry = IncineroarDesc,
        forms = SingleSpecies(SpeciesID.Incineroar),
    };
    public static readonly PokedexData Popplio = new()
    {
        number = 728,
        name = "Popplio",
        category = "Sea Lion",
        height = 40,
        weight = 7500,
        entry = PopplioDesc,
        forms = SingleSpecies(SpeciesID.Popplio),
    };
    public static readonly PokedexData Brionne = new()
    {
        number = 729,
        name = "Brionne",
        category = "Pop Star",
        height = 60,
        weight = 17500,
        entry = BrionneDesc,
        forms = SingleSpecies(SpeciesID.Brionne),
    };
    public static readonly PokedexData Primarina = new()
    {
        number = 730,
        name = "Primarina",
        category = "Soloist",
        height = 180,
        weight = 44000,
        entry = PrimarinaDesc,
        forms = SingleSpecies(SpeciesID.Primarina),
    };
    public static readonly PokedexData Pikipek = new()
    {
        number = 731,
        name = "Pikipek",
        category = "Woodpecker",
        height = 30,
        weight = 1200,
        entry = PikipekDesc,
        forms = SingleSpecies(SpeciesID.Pikipek),
    };
    public static readonly PokedexData Trumbeak = new()
    {
        number = 732,
        name = "Trumbeak",
        category = "Bugle Beak",
        height = 60,
        weight = 14800,
        entry = TrumbeakDesc,
        forms = SingleSpecies(SpeciesID.Trumbeak),
    };
    public static readonly PokedexData Toucannon = new()
    {
        number = 733,
        name = "Toucannon",
        category = "Cannon",
        height = 110,
        weight = 26000,
        entry = ToucannonDesc,
        forms = SingleSpecies(SpeciesID.Toucannon),
    };
    public static readonly PokedexData Yungoos = new()
    {
        number = 734,
        name = "Yungoos",
        category = "Loitering",
        height = 40,
        weight = 6000,
        entry = YungoosDesc,
        forms = SingleSpecies(SpeciesID.Yungoos),
    };
    public static readonly PokedexData Gumshoos = new()
    {
        number = 735,
        name = "Gumshoos",
        category = "Stakeout",
        height = 70,
        weight = 14200,
        entry = GumshoosDesc,
        forms = SingleSpecies(SpeciesID.Gumshoos),
    };
    public static readonly PokedexData Grubbin = new()
    {
        number = 736,
        name = "Grubbin",
        category = "Larva",
        height = 40,
        weight = 4400,
        entry = GrubbinDesc,
        forms = SingleSpecies(SpeciesID.Grubbin),
    };
    public static readonly PokedexData Charjabug = new()
    {
        number = 737,
        name = "Charjabug",
        category = "Battery",
        height = 50,
        weight = 10500,
        entry = CharjabugDesc,
        forms = SingleSpecies(SpeciesID.Charjabug),
    };
    public static readonly PokedexData Vikavolt = new()
    {
        number = 738,
        name = "Vikavolt",
        category = "Stag Beetle",
        height = 150,
        weight = 45000,
        entry = VikavoltDesc,
        forms = SingleSpecies(SpeciesID.Vikavolt),
    };
    public static readonly PokedexData Crabrawler = new()
    {
        number = 739,
        name = "Crabrawler",
        category = "Boxing",
        height = 60,
        weight = 7000,
        entry = CrabrawlerDesc,
        forms = SingleSpecies(SpeciesID.Crabrawler),
    };
    public static readonly PokedexData Crabominable = new()
    {
        number = 740,
        name = "Crabominable",
        category = "Woolly Crab",
        height = 170,
        weight = 180000,
        entry = CrabominableDesc,
        forms = SingleSpecies(SpeciesID.Crabominable),
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
            SpeciesID.OricorioBaile,
            SpeciesID.OricorioPomPom,
            SpeciesID.OricorioPau,
            SpeciesID.OricorioSensu
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
        forms = SingleSpecies(SpeciesID.Cutiefly),
    };
    public static readonly PokedexData Ribombee = new()
    {
        number = 743,
        name = "Ribombee",
        category = "Bee Fly",
        height = 20,
        weight = 500,
        entry = RibombeeDesc,
        forms = SingleSpecies(SpeciesID.Ribombee),
    };
    public static readonly PokedexData Rockruff = new()
    {
        number = 744,
        name = "Rockruff",
        category = "Puppy",
        height = 50,
        weight = 9200,
        entry = RockruffDesc,
        forms = SingleSpecies(SpeciesID.RockruffNormal),
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
            SpeciesID.Lycanroc,
            SpeciesID.LycanrocMidnight,
            SpeciesID.LycanrocDusk
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
            SpeciesID.Wishiwashi,
            SpeciesID.WishiwashiSchool
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
        forms = SingleSpecies(SpeciesID.Mareanie),
    };
    public static readonly PokedexData Toxapex = new()
    {
        number = 748,
        name = "Toxapex",
        category = "Brutal Star",
        height = 70,
        weight = 14500,
        entry = ToxapexDesc,
        forms = SingleSpecies(SpeciesID.Toxapex),
    };
    public static readonly PokedexData Mudbray = new()
    {
        number = 749,
        name = "Mudbray",
        category = "Donkey",
        height = 100,
        weight = 110000,
        entry = MudbrayDesc,
        forms = SingleSpecies(SpeciesID.Mudbray),
    };
    public static readonly PokedexData Mudsdale = new()
    {
        number = 750,
        name = "Mudsdale",
        category = "Draft Horse",
        height = 250,
        weight = 920000,
        entry = MudsdaleDesc,
        forms = SingleSpecies(SpeciesID.Mudsdale),
    };
    public static readonly PokedexData Dewpider = new()
    {
        number = 751,
        name = "Dewpider",
        category = "Water Bubble",
        height = 30,
        weight = 4000,
        entry = DewpiderDesc,
        forms = SingleSpecies(SpeciesID.Dewpider),
    };
    public static readonly PokedexData Araquanid = new()
    {
        number = 752,
        name = "Araquanid",
        category = "Water Bubble",
        height = 180,
        weight = 82000,
        entry = AraquanidDesc,
        forms = SingleSpecies(SpeciesID.Araquanid),
    };
    public static readonly PokedexData Fomantis = new()
    {
        number = 753,
        name = "Fomantis",
        category = "Sickle Grass",
        height = 30,
        weight = 1500,
        entry = FomantisDesc,
        forms = SingleSpecies(SpeciesID.Fomantis),
    };
    public static readonly PokedexData Lurantis = new()
    {
        number = 754,
        name = "Lurantis",
        category = "Bloom Sickle",
        height = 90,
        weight = 18500,
        entry = LurantisDesc,
        forms = SingleSpecies(SpeciesID.Lurantis),
    };
    public static readonly PokedexData Morelull = new()
    {
        number = 755,
        name = "Morelull",
        category = "Illuminate",
        height = 20,
        weight = 1500,
        entry = MorelullDesc,
        forms = SingleSpecies(SpeciesID.Morelull),
    };
    public static readonly PokedexData Shiinotic = new()
    {
        number = 756,
        name = "Shiinotic",
        category = "Illuminate",
        height = 100,
        weight = 11500,
        entry = ShiinoticDesc,
        forms = SingleSpecies(SpeciesID.Shiinotic),
    };
    public static readonly PokedexData Salandit = new()
    {
        number = 757,
        name = "Salandit",
        category = "Toxic Lizard",
        height = 60,
        weight = 4800,
        entry = SalanditDesc,
        forms = SingleSpecies(SpeciesID.Salandit),
    };
    public static readonly PokedexData Salazzle = new()
    {
        number = 758,
        name = "Salazzle",
        category = "Toxic Lizard",
        height = 120,
        weight = 22200,
        entry = SalazzleDesc,
        forms = SingleSpecies(SpeciesID.Salazzle),
    };
    public static readonly PokedexData Stufful = new()
    {
        number = 759,
        name = "Stufful",
        category = "Flailing",
        height = 50,
        weight = 6800,
        entry = StuffulDesc,
        forms = SingleSpecies(SpeciesID.Stufful),
    };
    public static readonly PokedexData Bewear = new()
    {
        number = 760,
        name = "Bewear",
        category = "Strong Arm",
        height = 210,
        weight = 135000,
        entry = BewearDesc,
        forms = SingleSpecies(SpeciesID.Bewear),
    };
    public static readonly PokedexData Bounsweet = new()
    {
        number = 761,
        name = "Bounsweet",
        category = "Fruit",
        height = 30,
        weight = 3200,
        entry = BounsweetDesc,
        forms = SingleSpecies(SpeciesID.Bounsweet),
    };
    public static readonly PokedexData Steenee = new()
    {
        number = 762,
        name = "Steenee",
        category = "Fruit",
        height = 70,
        weight = 8200,
        entry = SteeneeDesc,
        forms = SingleSpecies(SpeciesID.Steenee),
    };
    public static readonly PokedexData Tsareena = new()
    {
        number = 763,
        name = "Tsareena",
        category = "Fruit",
        height = 120,
        weight = 21400,
        entry = TsareenaDesc,
        forms = SingleSpecies(SpeciesID.Tsareena),
    };
    public static readonly PokedexData Comfey = new()
    {
        number = 764,
        name = "Comfey",
        category = "Posy Picker",
        height = 10,
        weight = 300,
        entry = ComfeyDesc,
        forms = SingleSpecies(SpeciesID.Comfey),
    };
    public static readonly PokedexData Oranguru = new()
    {
        number = 765,
        name = "Oranguru",
        category = "Sage",
        height = 150,
        weight = 76000,
        entry = OranguruDesc,
        forms = SingleSpecies(SpeciesID.Oranguru),
    };
    public static readonly PokedexData Passimian = new()
    {
        number = 766,
        name = "Passimian",
        category = "Teamwork",
        height = 200,
        weight = 82800,
        entry = PassimianDesc,
        forms = SingleSpecies(SpeciesID.Passimian),
    };
    public static readonly PokedexData Wimpod = new()
    {
        number = 767,
        name = "Wimpod",
        category = "Turn Tail",
        height = 50,
        weight = 12000,
        entry = WimpodDesc,
        forms = SingleSpecies(SpeciesID.Wimpod),
    };
    public static readonly PokedexData Golisopod = new()
    {
        number = 768,
        name = "Golisopod",
        category = "Hard Scale",
        height = 200,
        weight = 108000,
        entry = GolisopodDesc,
        forms = SingleSpecies(SpeciesID.Golisopod),
    };
    public static readonly PokedexData Sandygast = new()
    {
        number = 769,
        name = "Sandygast",
        category = "Sand Heap",
        height = 50,
        weight = 70000,
        entry = SandygastDesc,
        forms = SingleSpecies(SpeciesID.Sandygast),
    };
    public static readonly PokedexData Palossand = new()
    {
        number = 770,
        name = "Palossand",
        category = "Sand Castle",
        height = 130,
        weight = 250000,
        entry = PalossandDesc,
        forms = SingleSpecies(SpeciesID.Palossand),
    };
    public static readonly PokedexData Pyukumuku = new()
    {
        number = 771,
        name = "Pyukumuku",
        category = "Sea Cucumber",
        height = 30,
        weight = 1200,
        entry = PyukumukuDesc,
        forms = SingleSpecies(SpeciesID.Pyukumuku),
    };
    public static readonly PokedexData TypeNull = new()
    {
        number = 772,
        name = "Type: Null",
        category = "Synthetic",
        height = 190,
        weight = 120500,
        entry = TypeNullDesc,
        forms = SingleSpecies(SpeciesID.TypeNull),

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
            SpeciesID.SilvallyNormal,
            SpeciesID.SilvallyFighting,
            SpeciesID.SilvallyFlying,
            SpeciesID.SilvallyPoison,
            SpeciesID.SilvallyGround,
            SpeciesID.SilvallyRock,
            SpeciesID.SilvallyBug,
            SpeciesID.SilvallyGhost,
            SpeciesID.SilvallySteel,
            SpeciesID.SilvallyFire,
            SpeciesID.SilvallyWater,
            SpeciesID.SilvallyGrass,
            SpeciesID.SilvallyElectric,
            SpeciesID.SilvallyPsychic,
            SpeciesID.SilvallyIce,
            SpeciesID.SilvallyDragon,
            SpeciesID.SilvallyDark,
            SpeciesID.SilvallyFairy
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
            SpeciesID.MiniorRedCore,
            SpeciesID.MiniorOrangeCore,
            SpeciesID.MiniorYellowCore,
            SpeciesID.MiniorGreenCore,
            SpeciesID.MiniorBlueCore,
            SpeciesID.MiniorIndigoCore,
            SpeciesID.MiniorVioletCore,
            SpeciesID.MiniorRedMeteor
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
        forms = SingleSpecies(SpeciesID.Komala),
    };
    public static readonly PokedexData Turtonator = new()
    {
        number = 776,
        name = "Turtonator",
        category = "Blast Turtle",
        height = 200,
        weight = 212000,
        entry = TurtonatorDesc,
        forms = SingleSpecies(SpeciesID.Turtonator),
    };
    public static readonly PokedexData Togedemaru = new()
    {
        number = 777,
        name = "Togedemaru",
        category = "Roly-Poly",
        height = 30,
        weight = 3300,
        entry = TogedemaruDesc,
        forms = SingleSpecies(SpeciesID.Togedemaru),
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
            SpeciesID.MimikyuBase,
            SpeciesID.MimikyuBusted
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
        forms = SingleSpecies(SpeciesID.Bruxish),
    };
    public static readonly PokedexData Drampa = new()
    {
        number = 780,
        name = "Drampa",
        category = "Placid",
        height = 300,
        weight = 185000,
        entry = DrampaDesc,
        forms = SingleSpecies(SpeciesID.Drampa),
    };
    public static readonly PokedexData Dhelmise = new()
    {
        number = 781,
        name = "Dhelmise",
        category = "Sea Creeper",
        height = 390,
        weight = 210000,
        entry = DhelmiseDesc,
        forms = SingleSpecies(SpeciesID.Dhelmise),
    };
    public static readonly PokedexData JangmoO = new()
    {
        number = 782,
        name = "Jangmo O",
        category = "Scaly",
        height = 60,
        weight = 29700,
        entry = JangmoODesc,
        forms = SingleSpecies(SpeciesID.JangmoO),
    };
    public static readonly PokedexData HakamoO = new()
    {
        number = 783,
        name = "Hakamo O",
        category = "Scaly",
        height = 120,
        weight = 47000,
        entry = HakamoODesc,
        forms = SingleSpecies(SpeciesID.HakamoO),
    };
    public static readonly PokedexData KommoO = new()
    {
        number = 784,
        name = "Kommo O",
        category = "Scaly",
        height = 160,
        weight = 78200,
        entry = KommoODesc,
        forms = SingleSpecies(SpeciesID.KommoO),
    };
    public static readonly PokedexData TapuKoko = new()
    {
        number = 785,
        name = "Tapu Koko",
        category = "Land Spirit",
        height = 180,
        weight = 20500,
        entry = TapuKokoDesc,
        forms = SingleSpecies(SpeciesID.TapuKoko),
    };
    public static readonly PokedexData TapuLele = new()
    {
        number = 786,
        name = "Tapu Lele",
        category = "Land Spirit",
        height = 120,
        weight = 18600,
        entry = TapuLeleDesc,
        forms = SingleSpecies(SpeciesID.TapuLele),
    };
    public static readonly PokedexData TapuBulu = new()
    {
        number = 787,
        name = "Tapu Bulu",
        category = "Land Spirit",
        height = 190,
        weight = 45500,
        entry = TapuBuluDesc,
        forms = SingleSpecies(SpeciesID.TapuBulu),
    };
    public static readonly PokedexData TapuFini = new()
    {
        number = 788,
        name = "Tapu Fini",
        category = "Land Spirit",
        height = 130,
        weight = 21200,
        entry = TapuFiniDesc,
        forms = SingleSpecies(SpeciesID.TapuFini),
    };
    public static readonly PokedexData Cosmog = new()
    {
        number = 789,
        name = "Cosmog",
        category = "Nebula",
        height = 20,
        weight = 100,
        entry = CosmogDesc,
        forms = SingleSpecies(SpeciesID.Cosmog),
    };
    public static readonly PokedexData Cosmoem = new()
    {
        number = 790,
        name = "Cosmoem",
        category = "Protostar",
        height = 10,
        weight = 999900,
        entry = CosmoemDesc,
        forms = SingleSpecies(SpeciesID.Cosmoem),
    };
    public static readonly PokedexData Solgaleo = new()
    {
        number = 791,
        name = "Solgaleo",
        category = "Sunne",
        height = 340,
        weight = 230000,
        entry = SolgaleoDesc,
        forms = SingleSpecies(SpeciesID.Solgaleo),
    };
    public static readonly PokedexData Lunala = new()
    {
        number = 792,
        name = "Lunala",
        category = "Moone",
        height = 400,
        weight = 120000,
        entry = LunalaDesc,
        forms = SingleSpecies(SpeciesID.Lunala),
    };
    public static readonly PokedexData Nihilego = new()
    {
        number = 793,
        name = "Nihilego",
        category = "Parasite",
        height = 120,
        weight = 55500,
        entry = NihilegoDesc,
        forms = SingleSpecies(SpeciesID.Nihilego),
    };
    public static readonly PokedexData Buzzwole = new()
    {
        number = 794,
        name = "Buzzwole",
        category = "Swollen",
        height = 240,
        weight = 333600,
        entry = BuzzwoleDesc,
        forms = SingleSpecies(SpeciesID.Buzzwole),
    };
    public static readonly PokedexData Pheromosa = new()
    {
        number = 795,
        name = "Pheromosa",
        category = "Lissome",
        height = 180,
        weight = 25000,
        entry = PheromosaDesc,
        forms = SingleSpecies(SpeciesID.Pheromosa),
    };
    public static readonly PokedexData Xurkitree = new()
    {
        number = 796,
        name = "Xurkitree",
        category = "Glowing",
        height = 380,
        weight = 100000,
        entry = XurkitreeDesc,
        forms = SingleSpecies(SpeciesID.Xurkitree),
    };
    public static readonly PokedexData Celesteela = new()
    {
        number = 797,
        name = "Celesteela",
        category = "Launch",
        height = 920,
        weight = 999900,
        entry = CelesteelaDesc,
        forms = SingleSpecies(SpeciesID.Celesteela),
    };
    public static readonly PokedexData Kartana = new()
    {
        number = 798,
        name = "Kartana",
        category = "Drawn Sword",
        height = 30,
        weight = 100,
        entry = KartanaDesc,
        forms = SingleSpecies(SpeciesID.Kartana),
    };
    public static readonly PokedexData Guzzlord = new()
    {
        number = 799,
        name = "Guzzlord",
        category = "Junkivore",
        height = 550,
        weight = 888000,
        entry = GuzzlordDesc,
        forms = SingleSpecies(SpeciesID.Guzzlord),
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
            SpeciesID.Necrozma,
            SpeciesID.NecrozmaDuskMane,
            SpeciesID.NecrozmaDawnWings,
            SpeciesID.NecrozmaUltra
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
            SpeciesID.MagearnaBase,
            SpeciesID.MagearnaOriginal
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
        forms = SingleSpecies(SpeciesID.Marshadow),
    };
    public static readonly PokedexData Poipole = new()
    {
        number = 803,
        name = "Poipole",
        category = "Poison Pin",
        height = 60,
        weight = 1800,
        entry = PoipoleDesc,
        forms = SingleSpecies(SpeciesID.Poipole),
    };
    public static readonly PokedexData Naganadel = new()
    {
        number = 804,
        name = "Naganadel",
        category = "Poison Pin",
        height = 360,
        weight = 150000,
        entry = NaganadelDesc,
        forms = SingleSpecies(SpeciesID.Naganadel),
    };
    public static readonly PokedexData Stakataka = new()
    {
        number = 805,
        name = "Stakataka",
        category = "Rampart",
        height = 550,
        weight = 820000,
        entry = StakatakaDesc,
        forms = SingleSpecies(SpeciesID.Stakataka),
    };
    public static readonly PokedexData Blacephalon = new()
    {
        number = 806,
        name = "Blacephalon",
        category = "Fireworks",
        height = 180,
        weight = 13000,
        entry = BlacephalonDesc,
        forms = SingleSpecies(SpeciesID.Blacephalon),
    };
    public static readonly PokedexData Zeraora = new()
    {
        number = 807,
        name = "Zeraora",
        category = "Thunderclap",
        height = 150,
        weight = 44500,
        entry = ZeraoraDesc,
        forms = SingleSpecies(SpeciesID.Zeraora),
    };
    public static readonly PokedexData Meltan = new()
    {
        number = 808,
        name = "Meltan",
        category = "Hex Nut",
        height = 20,
        weight = 8000,
        entry = MeltanDesc,
        forms = SingleSpecies(SpeciesID.Meltan),
    };
    public static readonly PokedexData Melmetal = new()
    {
        number = 809,
        name = "Melmetal",
        category = "Hex Nut",
        height = 250,
        weight = 80000,
        entry = MelmetalDesc,
        forms = SingleSpecies(SpeciesID.Melmetal),
    };
    public static PokedexData Grookey = new()
    {
        number = 810,
        name = "Grookey",
        category = "Chimp",
        height = 30,
        weight = 5000,
        entry = GrookeyDesc,
        forms = SingleSpecies(SpeciesID.Grookey),
    };
    public static PokedexData Thwackey = new()
    {
        number = 811,
        name = "Thwackey",
        category = "Beat",
        height = 70,
        weight = 14000,
        entry = ThwackeyDesc,
        forms = SingleSpecies(SpeciesID.Thwackey),
    };
    public static PokedexData Rillaboom = new()
    {
        number = 812,
        name = "Rillaboom",
        category = "Drummer",
        height = 210,
        weight = 90000,
        entry = RillaboomDesc,
        forms = SingleSpecies(SpeciesID.Rillaboom),
    };
    public static PokedexData Scorbunny = new()
    {
        number = 813,
        name = "Scorbunny",
        category = "Rabbit",
        height = 30,
        weight = 4500,
        entry = ScorbunnyDesc,
        forms = SingleSpecies(SpeciesID.Scorbunny),
    };
    public static PokedexData Raboot = new()
    {
        number = 814,
        name = "Raboot",
        category = "Rabbit",
        height = 60,
        weight = 9000,
        entry = RabootDesc,
        forms = SingleSpecies(SpeciesID.Raboot),
    };
    public static PokedexData Cinderace = new()
    {
        number = 815,
        name = "Cinderace",
        category = "Striker",
        height = 140,
        weight = 33000,
        entry = CinderaceDesc,
        forms = SingleSpecies(SpeciesID.Cinderace),
    };
    public static PokedexData Sobble = new()
    {
        number = 816,
        name = "Sobble",
        category = "WaterLizard",
        height = 30,
        weight = 4000,
        entry = SobbleDesc,
        forms = SingleSpecies(SpeciesID.Sobble),
    };
    public static PokedexData Drizzile = new()
    {
        number = 817,
        name = "Drizzile",
        category = "WaterLizard",
        height = 70,
        weight = 11500,
        entry = DrizzileDesc,
        forms = SingleSpecies(SpeciesID.Drizzile),
    };
    public static PokedexData Inteleon = new()
    {
        number = 818,
        name = "Inteleon",
        category = "SecretAgent",
        height = 190,
        weight = 45200,
        entry = InteleonDesc,
        forms = SingleSpecies(SpeciesID.Inteleon),
    };
    public static PokedexData Skwovet = new()
    {
        number = 819,
        name = "Skwovet",
        category = "Cheeky",
        height = 30,
        weight = 2500,
        entry = SkwovetDesc,
        forms = SingleSpecies(SpeciesID.Skwovet),
    };
    public static PokedexData Greedent = new()
    {
        number = 820,
        name = "Greedent",
        category = "Greedy",
        height = 60,
        weight = 6000,
        entry = GreedentDesc,
        forms = SingleSpecies(SpeciesID.Greedent),
    };
    public static PokedexData Rookidee = new()
    {
        number = 821,
        name = "Rookidee",
        category = "TinyBird",
        height = 20,
        weight = 1800,
        entry = RookideeDesc,
        forms = SingleSpecies(SpeciesID.Rookidee),
    };
    public static PokedexData Corvisquire = new()
    {
        number = 822,
        name = "Corvisquire",
        category = "Raven",
        height = 80,
        weight = 16000,
        entry = CorvisquireDesc,
        forms = SingleSpecies(SpeciesID.Corvisquire),
    };
    public static PokedexData Corviknight = new()
    {
        number = 823,
        name = "Corviknight",
        category = "Raven",
        height = 220,
        weight = 75000,
        entry = CorviknightDesc,
        forms = SingleSpecies(SpeciesID.Corviknight),
    };
    public static PokedexData Blipbug = new()
    {
        number = 824,
        name = "Blipbug",
        category = "Larva",
        height = 40,
        weight = 8000,
        entry = BlipbugDesc,
        forms = SingleSpecies(SpeciesID.Blipbug),
    };
    public static PokedexData Dottler = new()
    {
        number = 825,
        name = "Dottler",
        category = "Radome",
        height = 40,
        weight = 19500,
        entry = DottlerDesc,
        forms = SingleSpecies(SpeciesID.Dottler),
    };
    public static PokedexData Orbeetle = new()
    {
        number = 826,
        name = "Orbeetle",
        category = "SevenSpot",
        height = 40,
        weight = 40800,
        entry = OrbeetleDesc,
        forms = SingleSpecies(SpeciesID.Orbeetle),
    };
    public static PokedexData Nickit = new()
    {
        number = 827,
        name = "Nickit",
        category = "Fox",
        height = 60,
        weight = 8900,
        entry = NickitDesc,
        forms = SingleSpecies(SpeciesID.Nickit),
    };
    public static PokedexData Thievul = new()
    {
        number = 828,
        name = "Thievul",
        category = "Fox",
        height = 120,
        weight = 19900,
        entry = ThievulDesc,
        forms = SingleSpecies(SpeciesID.Thievul),
    };
    public static PokedexData Gossifleur = new()
    {
        number = 829,
        name = "Gossifleur",
        category = "Flowering",
        height = 40,
        weight = 2200,
        entry = GossifleurDesc,
        forms = SingleSpecies(SpeciesID.Gossifleur),
    };
    public static PokedexData Eldegoss = new()
    {
        number = 830,
        name = "Eldegoss",
        category = "CottonBloom",
        height = 50,
        weight = 2500,
        entry = EldegossDesc,
        forms = SingleSpecies(SpeciesID.Eldegoss),
    };
    public static PokedexData Wooloo = new()
    {
        number = 831,
        name = "Wooloo",
        category = "Sheep",
        height = 60,
        weight = 6000,
        entry = WoolooDesc,
        forms = SingleSpecies(SpeciesID.Wooloo),
    };
    public static PokedexData Dubwool = new()
    {
        number = 832,
        name = "Dubwool",
        category = "Sheep",
        height = 130,
        weight = 43000,
        entry = DubwoolDesc,
        forms = SingleSpecies(SpeciesID.Dubwool),
    };
    public static PokedexData Chewtle = new()
    {
        number = 833,
        name = "Chewtle",
        category = "Snapping",
        height = 30,
        weight = 8500,
        entry = ChewtleDesc,
        forms = SingleSpecies(SpeciesID.Chewtle),
    };
    public static PokedexData Drednaw = new()
    {
        number = 834,
        name = "Drednaw",
        category = "Bite",
        height = 100,
        weight = 115500,
        entry = DrednawDesc,
        forms = SingleSpecies(SpeciesID.Drednaw),
    };
    public static PokedexData Yamper = new()
    {
        number = 835,
        name = "Yamper",
        category = "Puppy",
        height = 30,
        weight = 13500,
        entry = YamperDesc,
        forms = SingleSpecies(SpeciesID.Yamper),
    };
    public static PokedexData Boltund = new()
    {
        number = 836,
        name = "Boltund",
        category = "Dog",
        height = 100,
        weight = 34000,
        entry = BoltundDesc,
        forms = SingleSpecies(SpeciesID.Boltund),
    };
    public static PokedexData Rolycoly = new()
    {
        number = 837,
        name = "Rolycoly",
        category = "Coal",
        height = 30,
        weight = 12000,
        entry = RolycolyDesc,
        forms = SingleSpecies(SpeciesID.Rolycoly),
    };
    public static PokedexData Carkol = new()
    {
        number = 838,
        name = "Carkol",
        category = "Coal",
        height = 110,
        weight = 78000,
        entry = CarkolDesc,
        forms = SingleSpecies(SpeciesID.Carkol),
    };
    public static PokedexData Coalossal = new()
    {
        number = 839,
        name = "Coalossal",
        category = "Coal",
        height = 280,
        weight = 310500,
        entry = CoalossalDesc,
        forms = SingleSpecies(SpeciesID.Coalossal),
    };
    public static PokedexData Applin = new()
    {
        number = 840,
        name = "Applin",
        category = "AppleCore",
        height = 20,
        weight = 500,
        entry = ApplinDesc,
        forms = SingleSpecies(SpeciesID.Applin),
    };
    public static PokedexData Flapple = new()
    {
        number = 841,
        name = "Flapple",
        category = "AppleWing",
        height = 30,
        weight = 1000,
        entry = FlappleDesc,
        forms = SingleSpecies(SpeciesID.Flapple),
    };
    public static PokedexData Appletun = new()
    {
        number = 842,
        name = "Appletun",
        category = "AppleNectar",
        height = 40,
        weight = 13000,
        entry = AppletunDesc,
        forms = SingleSpecies(SpeciesID.Appletun),
    };
    public static PokedexData Silicobra = new()
    {
        number = 843,
        name = "Silicobra",
        category = "SandSnake",
        height = 220,
        weight = 7600,
        entry = SilicobraDesc,
        forms = SingleSpecies(SpeciesID.Silicobra),
    };
    public static PokedexData Sandaconda = new()
    {
        number = 844,
        name = "Sandaconda",
        category = "SandSnake",
        height = 380,
        weight = 65500,
        entry = SandacondaDesc,
        forms = SingleSpecies(SpeciesID.Sandaconda),
    };
    public static PokedexData Cramorant = new()
    {
        number = 845,
        name = "Cramorant",
        category = "Gulp",
        height = 80,
        weight = 18000,
        entry = CramorantDesc,
        forms = SingleSpecies(SpeciesID.Cramorant),
    };
    public static PokedexData Arrokuda = new()
    {
        number = 846,
        name = "Arrokuda",
        category = "Rush",
        height = 50,
        weight = 1000,
        entry = ArrokudaDesc,
        forms = SingleSpecies(SpeciesID.Arrokuda),
    };
    public static PokedexData Barraskewda = new()
    {
        number = 847,
        name = "Barraskewda",
        category = "Skewer",
        height = 130,
        weight = 30000,
        entry = BarraskewdaDesc,
        forms = SingleSpecies(SpeciesID.Barraskewda),
    };
    public static PokedexData Toxel = new()
    {
        number = 848,
        name = "Toxel",
        category = "Baby",
        height = 40,
        weight = 11000,
        entry = ToxelDesc,
        forms = SingleSpecies(SpeciesID.Toxel),
    };
    public static PokedexData Toxtricity = new()
    {
        number = 849,
        name = "Toxtricity",
        category = "Punk",
        height = 160,
        weight = 40000,
        entry = ToxtricityDesc,
        forms = new[]
        {
            SpeciesID.Toxtricity,
            SpeciesID.ToxtricityLowKey
        }
    };
    public static PokedexData Sizzlipede = new()
    {
        number = 850,
        name = "Sizzlipede",
        category = "Radiator",
        height = 70,
        weight = 1000,
        entry = SizzlipedeDesc,
        forms = SingleSpecies(SpeciesID.Sizzlipede),
    };
    public static PokedexData Centiskorch = new()
    {
        number = 851,
        name = "Centiskorch",
        category = "Radiator",
        height = 300,
        weight = 120000,
        entry = CentiskorchDesc,
        forms = SingleSpecies(SpeciesID.Centiskorch),
    };
    public static PokedexData Clobbopus = new()
    {
        number = 852,
        name = "Clobbopus",
        category = "Tantrum",
        height = 60,
        weight = 4000,
        entry = ClobbopusDesc,
        forms = SingleSpecies(SpeciesID.Clobbopus),
    };
    public static PokedexData Grapploct = new()
    {
        number = 853,
        name = "Grapploct",
        category = "Jujitsu",
        height = 160,
        weight = 39000,
        entry = GrapploctDesc,
        forms = SingleSpecies(SpeciesID.Grapploct),
    };
    public static PokedexData Sinistea = new()
    {
        number = 854,
        name = "Sinistea",
        category = "BlackTea",
        height = 10,
        weight = 200,
        entry = SinisteaDesc,
        forms = new[]
        {
            SpeciesID.Sinistea,
            SpeciesID.SinisteaAntique
        }
    };
    public static PokedexData Polteageist = new()
    {
        number = 855,
        name = "Polteageist",
        category = "BlackTea",
        height = 20,
        weight = 400,
        entry = PolteageistDesc,
        forms = new[]
        {
            SpeciesID.Polteageist,
            SpeciesID.PolteageistAntique
        }
    };
    public static PokedexData Hatenna = new()
    {
        number = 856,
        name = "Hatenna",
        category = "Calm",
        height = 40,
        weight = 3400,
        entry = HatennaDesc,
        forms = SingleSpecies(SpeciesID.Hatenna),
    };
    public static PokedexData Hattrem = new()
    {
        number = 857,
        name = "Hattrem",
        category = "Serene",
        height = 60,
        weight = 4800,
        entry = HattremDesc,
        forms = SingleSpecies(SpeciesID.Hattrem),
    };
    public static PokedexData Hatterene = new()
    {
        number = 858,
        name = "Hatterene",
        category = "Silent",
        height = 210,
        weight = 5100,
        entry = HattereneDesc,
        forms = SingleSpecies(SpeciesID.Hatterene),
    };
    public static PokedexData Impidimp = new()
    {
        number = 859,
        name = "Impidimp",
        category = "Wily",
        height = 40,
        weight = 5500,
        entry = ImpidimpDesc,
        forms = SingleSpecies(SpeciesID.Impidimp),
    };
    public static PokedexData Morgrem = new()
    {
        number = 860,
        name = "Morgrem",
        category = "Devious",
        height = 80,
        weight = 12500,
        entry = MorgremDesc,
        forms = SingleSpecies(SpeciesID.Morgrem),
    };
    public static PokedexData Grimmsnarl = new()
    {
        number = 861,
        name = "Grimmsnarl",
        category = "BulkUp",
        height = 150,
        weight = 61000,
        entry = GrimmsnarlDesc,
        forms = SingleSpecies(SpeciesID.Grimmsnarl),
    };
    public static PokedexData Obstagoon = new()
    {
        number = 862,
        name = "Obstagoon",
        category = "Blocking",
        height = 160,
        weight = 46000,
        entry = ObstagoonDesc,
        forms = SingleSpecies(SpeciesID.Obstagoon),
    };
    public static PokedexData Perrserker = new()
    {
        number = 863,
        name = "Perrserker",
        category = "Viking",
        height = 80,
        weight = 28000,
        entry = PerrserkerDesc,
        forms = SingleSpecies(SpeciesID.Perrserker),
    };
    public static PokedexData Cursola = new()
    {
        number = 864,
        name = "Cursola",
        category = "Coral",
        height = 100,
        weight = 400,
        entry = CursolaDesc,
        forms = SingleSpecies(SpeciesID.Cursola),
    };
    public static PokedexData Sirfetchd = new()
    {
        number = 865,
        name = "Sirfetchd",
        category = "WildDuck",
        height = 80,
        weight = 117000,
        entry = SirfetchdDesc,
        forms = SingleSpecies(SpeciesID.Sirfetchd),
    };
    public static PokedexData MrRime = new()
    {
        number = 866,
        name = "Mr Rime",
        category = "Comedian",
        height = 150,
        weight = 58200,
        entry = MrRimeDesc,
        forms = SingleSpecies(SpeciesID.MrRime),

    };
    public static PokedexData Runerigus = new()
    {
        number = 867,
        name = "Runerigus",
        category = "Grudge",
        height = 160,
        weight = 66600,
        entry = RunerigusDesc,
        forms = SingleSpecies(SpeciesID.Runerigus),
    };
    public static PokedexData Milcery = new()
    {
        number = 868,
        name = "Milcery",
        category = "Cream",
        height = 20,
        weight = 300,
        entry = MilceryDesc,
        forms = SingleSpecies(SpeciesID.Milcery),
    };
    public static PokedexData Alcremie = new()
    {
        number = 869,
        name = "Alcremie",
        category = "Cream",
        height = 30,
        weight = 500,
        entry = AlcremieDesc,
        forms = new[]
        {
            SpeciesID.AlcremieRubyCream,
            SpeciesID.AlcremieMatchaCream,
            SpeciesID.AlcremieMintCream,
            SpeciesID.AlcremieLemonCream,
            SpeciesID.AlcremieSaltedCream,
            SpeciesID.AlcremieRubySwirl,
            SpeciesID.AlcremieCaramelSwirl,
            SpeciesID.AlcremieRainbowSwirl,
        }
    };
    public static PokedexData Falinks = new()
    {
        number = 870,
        name = "Falinks",
        category = "Formation",
        height = 300,
        weight = 62000,
        entry = FalinksDesc,
        forms = SingleSpecies(SpeciesID.Falinks),
    };
    public static PokedexData Pincurchin = new()
    {
        number = 871,
        name = "Pincurchin",
        category = "SeaUrchin",
        height = 30,
        weight = 1000,
        entry = PincurchinDesc,
        forms = SingleSpecies(SpeciesID.Pincurchin),
    };
    public static PokedexData Snom = new()
    {
        number = 872,
        name = "Snom",
        category = "Worm",
        height = 30,
        weight = 3800,
        entry = SnomDesc,
        forms = SingleSpecies(SpeciesID.Snom),
    };
    public static PokedexData Frosmoth = new()
    {
        number = 873,
        name = "Frosmoth",
        category = "FrostMoth",
        height = 130,
        weight = 42000,
        entry = FrosmothDesc,
        forms = SingleSpecies(SpeciesID.Frosmoth),
    };
    public static PokedexData Stonjourner = new()
    {
        number = 874,
        name = "Stonjourner",
        category = "BigRock",
        height = 250,
        weight = 520000,
        entry = StonjournerDesc,
        forms = SingleSpecies(SpeciesID.Stonjourner),
    };
    public static PokedexData Eiscue = new()
    {
        number = 875,
        name = "Eiscue",
        category = "Penguin",
        height = 140,
        weight = 89000,
        entry = EiscueDesc,
        forms = SingleSpecies(SpeciesID.Eiscue),
    };
    public static PokedexData Indeedee = new()
    {
        number = 876,
        name = "Indeedee",
        category = "Emotion",
        height = 90,
        weight = 28000,
        entry = IndeedeeDesc,
        forms = new[]
        {
            SpeciesID.Indeedee,
            SpeciesID.IndeedeeF
        }
    };
    public static PokedexData Morpeko = new()
    {
        number = 877,
        name = "Morpeko",
        category = "Two-Sided",
        height = 30,
        weight = 3000,
        entry = MorpekoDesc,
        forms = new[]
        {
            SpeciesID.Morpeko,
            SpeciesID.MorpekoHangry
        }
    };
    public static PokedexData Cufant = new()
    {
        number = 878,
        name = "Cufant",
        category = "Copperderm",
        height = 120,
        weight = 100000,
        entry = CufantDesc,
        forms = SingleSpecies(SpeciesID.Cufant),
    };
    public static PokedexData Copperajah = new()
    {
        number = 879,
        name = "Copperajah",
        category = "Copperderm",
        height = 300,
        weight = 650000,
        entry = CopperajahDesc,
        forms = SingleSpecies(SpeciesID.Copperajah),
    };
    public static PokedexData Dracozolt = new()
    {
        number = 880,
        name = "Dracozolt",
        category = "Fossil",
        height = 180,
        weight = 190000,
        entry = DracozoltDesc,
        forms = SingleSpecies(SpeciesID.Dracozolt),
    };
    public static PokedexData Arctozolt = new()
    {
        number = 881,
        name = "Arctozolt",
        category = "Fossil",
        height = 230,
        weight = 150000,
        entry = ArctozoltDesc,
        forms = SingleSpecies(SpeciesID.Arctozolt),
    };
    public static PokedexData Dracovish = new()
    {
        number = 882,
        name = "Dracovish",
        category = "Fossil",
        height = 230,
        weight = 215000,
        entry = DracovishDesc,
        forms = SingleSpecies(SpeciesID.Dracovish),
    };
    public static PokedexData Arctovish = new()
    {
        number = 883,
        name = "Arctovish",
        category = "Fossil",
        height = 200,
        weight = 175000,
        entry = ArctovishDesc,
        forms = SingleSpecies(SpeciesID.Arctovish),
    };
    public static PokedexData Duraludon = new()
    {
        number = 884,
        name = "Duraludon",
        category = "Alloy",
        height = 180,
        weight = 40000,
        entry = DuraludonDesc,
        forms = SingleSpecies(SpeciesID.Duraludon),
    };
    public static PokedexData Dreepy = new()
    {
        number = 885,
        name = "Dreepy",
        category = "Lingering",
        height = 50,
        weight = 2000,
        entry = DreepyDesc,
        forms = SingleSpecies(SpeciesID.Dreepy),
    };
    public static PokedexData Drakloak = new()
    {
        number = 886,
        name = "Drakloak",
        category = "Caretaker",
        height = 140,
        weight = 11000,
        entry = DrakloakDesc,
        forms = SingleSpecies(SpeciesID.Drakloak),
    };
    public static PokedexData Dragapult = new()
    {
        number = 887,
        name = "Dragapult",
        category = "Stealth",
        height = 300,
        weight = 50000,
        entry = DragapultDesc,
        forms = SingleSpecies(SpeciesID.Dragapult),
    };
    public static PokedexData Zacian = new()
    {
        number = 888,
        name = "Zacian",
        category = "Warrior",
        height = 280,
        weight = 110000,
        entry = ZacianDesc,
        forms = new[]
        {
            SpeciesID.Zacian,
            SpeciesID.ZacianCrowned
        }
    };
    public static PokedexData Zamazenta = new()
    {
        number = 889,
        name = "Zamazenta",
        category = "Warrior",
        height = 290,
        weight = 210000,
        entry = ZamazentaDesc,
        forms = new[]
        {
            SpeciesID.Zamazenta,
            SpeciesID.ZamazentaCrowned
        }
    };
    public static PokedexData Eternatus = new()
    {
        number = 890,
        name = "Eternatus",
        category = "Gigantic",
        height = 2000,
        weight = 950000,
        entry = EternatusDesc,
        forms = new[]
        {
            SpeciesID.Eternatus,
            SpeciesID.EternatusEternamax
        }
    };
    public static PokedexData Kubfu = new()
    {
        number = 891,
        name = "Kubfu",
        category = "Wushu",
        height = 60,
        weight = 12000,
        entry = KubfuDesc,
        forms = SingleSpecies(SpeciesID.Kubfu),
    };
    public static PokedexData Urshifu = new()
    {
        number = 892,
        name = "Urshifu",
        category = "Wushu",
        height = 190,
        weight = 105000,
        entry = UrshifuDesc,
        forms = new[]
        {
            SpeciesID.Urshifu,
            SpeciesID.UrshifuRapid
        }
    };
    public static PokedexData Zarude = new()
    {
        number = 893,
        name = "Zarude",
        category = "RogueMonkey",
        height = 180,
        weight = 70000,
        entry = ZarudeDesc,
        forms = new[]
        {
            SpeciesID.Zarude,
            SpeciesID.ZarudeDada
        }
    };
    public static PokedexData Regieleki = new()
    {
        number = 894,
        name = "Regieleki",
        category = "Electron",
        height = 120,
        weight = 145000,
        entry = RegielekiDesc,
        forms = SingleSpecies(SpeciesID.Regieleki),
    };
    public static PokedexData Regidrago = new()
    {
        number = 895,
        name = "Regidrago",
        category = "DragonOrb",
        height = 210,
        weight = 200000,
        entry = RegidragoDesc,
        forms = SingleSpecies(SpeciesID.Regidrago),
    };
    public static PokedexData Glastrier = new()
    {
        number = 896,
        name = "Glastrier",
        category = "WildHorse",
        height = 220,
        weight = 800000,
        entry = GlastrierDesc,
        forms = SingleSpecies(SpeciesID.Glastrier),
    };
    public static PokedexData Spectrier = new()
    {
        number = 897,
        name = "Spectrier",
        category = "SwiftHorse",
        height = 200,
        weight = 44500,
        entry = SpectrierDesc,
        forms = SingleSpecies(SpeciesID.Spectrier),
    };
    public static PokedexData Calyrex = new()
    {
        number = 898,
        name = "Calyrex",
        category = "King",
        height = 110,
        weight = 7700,
        entry = CalyrexDesc,
        forms = new[]
        {
            SpeciesID.Calyrex,
            SpeciesID.CalyrexIce,
            SpeciesID.CalyrexShadow
        }
    };
    public static PokedexData Wyrdeer = new()
    {
        number = 899,
        name = "Wyrdeer",
        category = "BigHorn",
        height = 180,
        weight = 95100,
        entry = WyrdeerDesc,
        forms = SingleSpecies(SpeciesID.Wyrdeer),
    };
    public static PokedexData Kleavor = new()
    {
        number = 900,
        name = "Kleavor",
        category = "Axe",
        height = 180,
        weight = 89000,
        entry = KleavorDesc,
        forms = SingleSpecies(SpeciesID.Kleavor),
    };
    public static PokedexData Ursaluna = new()
    {
        number = 901,
        name = "Ursaluna",
        category = "Peat",
        height = 240,
        weight = 290000,
        entry = UrsalunaDesc,
        forms = SingleSpecies(SpeciesID.Ursaluna),
    };
    public static PokedexData Basculegion = new()
    {
        number = 902,
        name = "Basculegion",
        category = "BigFish",
        height = 300,
        weight = 110000,
        entry = BasculegionDesc,
        forms = new[]
        {
            SpeciesID.Basculegion,
            SpeciesID.BasculegionF
        }
    };
    public static PokedexData Sneasler = new()
    {
        number = 903,
        name = "Sneasler",
        category = "FreeClimb",
        height = 130,
        weight = 43000,
        entry = SneaslerDesc,
        forms = SingleSpecies(SpeciesID.Sneasler),
    };
    public static PokedexData Overqwil = new()
    {
        number = 904,
        name = "Overqwil",
        category = "PinCluster",
        height = 250,
        weight = 60500,
        entry = OverqwilDesc,
        forms = SingleSpecies(SpeciesID.Overqwil),
    };
    public static PokedexData Enamorus = new()
    {
        number = 905,
        name = "Enamorus",
        category = "Love-Hate",
        height = 160,
        weight = 48000,
        entry = EnamorusDesc,
        forms = new[]
        {
            SpeciesID.Enamorus,
            SpeciesID.EnamorusT,
        }
    };

}