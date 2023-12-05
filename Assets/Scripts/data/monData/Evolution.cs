using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EvolutionData;
using static EvolutionMethod;
using static ItemID;

public static class Evolution
{
    //Gen 1
    public static EvolutionData[] None = SingleEvolution(Never, 0, SpeciesID.Missingno);
    public static EvolutionData[] Bulbasaur = LevelEvolution(16, SpeciesID.Ivysaur);
    public static EvolutionData[] Ivysaur = LevelEvolution(32, SpeciesID.Venusaur);
    public static EvolutionData[] Charmander = LevelEvolution(16, SpeciesID.Charmeleon);
    public static EvolutionData[] Charmeleon = LevelEvolution(36, SpeciesID.Charizard);
    public static EvolutionData[] Squirtle = LevelEvolution(16, SpeciesID.Wartortle);
    public static EvolutionData[] Wartortle = LevelEvolution(36, SpeciesID.Blastoise);
    public static EvolutionData[] Caterpie = LevelEvolution(7, SpeciesID.Metapod);
    public static EvolutionData[] Metapod = LevelEvolution(10, SpeciesID.Butterfree);
    public static EvolutionData[] Weedle = LevelEvolution(7, SpeciesID.Kakuna);
    public static EvolutionData[] Kakuna = LevelEvolution(10, SpeciesID.Beedrill);
    public static EvolutionData[] Pidgey = LevelEvolution(18, SpeciesID.Pidgeotto);
    public static EvolutionData[] Pidgeotto = LevelEvolution(36, SpeciesID.Pidgeot);
    public static EvolutionData[] Rattata = LevelEvolution(20, SpeciesID.Raticate);
    public static EvolutionData[] Spearow = LevelEvolution(20, SpeciesID.Fearow);
    public static EvolutionData[] Ekans = LevelEvolution(22, SpeciesID.Arbok);
    public static EvolutionData[] Pikachu = ItemEvolution(ThunderStone, SpeciesID.Raichu);
    public static EvolutionData[] Sandshrew = LevelEvolution(22, SpeciesID.Sandslash);
    public static EvolutionData[] NidoranF = LevelEvolution(16, SpeciesID.Nidorina);
    public static EvolutionData[] Nidorina = ItemEvolution(MoonStone, SpeciesID.Nidoqueen);
    public static EvolutionData[] NidoranM = LevelEvolution(16, SpeciesID.Nidorino);
    public static EvolutionData[] Nidorino = ItemEvolution(MoonStone, SpeciesID.Nidoking);
    public static EvolutionData[] Clefairy = ItemEvolution(MoonStone, SpeciesID.Clefable);
    public static EvolutionData[] Vulpix = ItemEvolution(FireStone, SpeciesID.Ninetales);
    public static EvolutionData[] Jigglypuff = ItemEvolution(MoonStone, SpeciesID.Wigglytuff);
    public static EvolutionData[] Zubat = LevelEvolution(22, SpeciesID.Golbat);
    public static EvolutionData[] Golbat = Friendship220Evolution(SpeciesID.Crobat);
    public static EvolutionData[] Oddish = LevelEvolution(21, SpeciesID.Gloom);
    public static EvolutionData[] Gloom = ItemEvolution(LeafStone, SpeciesID.Vileplume);
    public static EvolutionData[] Paras = LevelEvolution(24, SpeciesID.Parasect);
    public static EvolutionData[] Venonat = LevelEvolution(31, SpeciesID.Venomoth);
    public static EvolutionData[] Diglett = LevelEvolution(26, SpeciesID.Dugtrio);
    public static EvolutionData[] Meowth = LevelEvolution(28, SpeciesID.Persian);
    public static EvolutionData[] Psyduck = LevelEvolution(33, SpeciesID.Golduck);
    public static EvolutionData[] Mankey = LevelEvolution(28, SpeciesID.Primeape);
    public static EvolutionData[] Growlithe = ItemEvolution(FireStone, SpeciesID.Arcanine);
    public static EvolutionData[] Poliwag = LevelEvolution(25, SpeciesID.Poliwhirl);
    public static EvolutionData[] Poliwhirl = new EvolutionData[]{
        new(EvolutionItem, WaterStone, SpeciesID.Poliwrath),
        new(TradeItem, KingsRock, SpeciesID.Politoed),
    };
    public static EvolutionData[] Abra = LevelEvolution(16, SpeciesID.Kadabra);
    public static EvolutionData[] Kadabra = TradeEvolution(SpeciesID.Alakazam);
    public static EvolutionData[] Machop = LevelEvolution(28, SpeciesID.Machoke);
    public static EvolutionData[] Machoke = TradeEvolution(SpeciesID.Machamp);
    public static EvolutionData[] Bellsprout = LevelEvolution(21, SpeciesID.Weepinbell);
    public static EvolutionData[] Weepinbell = ItemEvolution(LeafStone, SpeciesID.Victreebel);
    public static EvolutionData[] Tentacool = LevelEvolution(30, SpeciesID.Tentacruel);
    public static EvolutionData[] Geodude = LevelEvolution(25, SpeciesID.Graveler);
    public static EvolutionData[] Graveler = TradeEvolution(SpeciesID.Golem);
    public static EvolutionData[] Ponyta = LevelEvolution(40, SpeciesID.Rapidash);
    public static EvolutionData[] Slowpoke = new EvolutionData[]{
        new(LevelUp, 37, SpeciesID.Slowbro),
        new(TradeItem, KingsRock, SpeciesID.Slowking),
    };
    public static EvolutionData[] Magnemite = LevelEvolution(30, SpeciesID.Magneton);
    public static EvolutionData[] Magneton = SingleEvolution(LevelUpMagneticField, 0, SpeciesID.Magnezone);
    public static EvolutionData[] Doduo = LevelEvolution(31, SpeciesID.Dodrio);
    public static EvolutionData[] Seel = LevelEvolution(34, SpeciesID.Dewgong);
    public static EvolutionData[] Grimer = LevelEvolution(38, SpeciesID.Muk);
    public static EvolutionData[] Shellder = ItemEvolution(WaterStone, SpeciesID.Cloyster);
    public static EvolutionData[] Gastly = LevelEvolution(25, SpeciesID.Haunter);
    public static EvolutionData[] Haunter = TradeEvolution(SpeciesID.Gengar);
    public static EvolutionData[] Onix = SingleEvolution(TradeItem, MetalCoat, SpeciesID.Steelix);
    public static EvolutionData[] Drowzee = LevelEvolution(26, SpeciesID.Hypno);
    public static EvolutionData[] Krabby = LevelEvolution(28, SpeciesID.Kingler);
    public static EvolutionData[] Voltorb = LevelEvolution(30, SpeciesID.Electrode);
    public static EvolutionData[] Exeggcute = ItemEvolution(LeafStone, SpeciesID.Exeggutor);
    public static EvolutionData[] Cubone = LevelEvolution(28, SpeciesID.Marowak);
    public static EvolutionData[] Lickitung = SingleEvolution(LevelUpWithMove, MoveID.Rollout, SpeciesID.Lickilicky);
    public static EvolutionData[] Koffing = LevelEvolution(35, SpeciesID.Weezing);
    public static EvolutionData[] Rhyhorn = LevelEvolution(42, SpeciesID.Rhydon);
    public static EvolutionData[] Rhydon = SingleEvolution(TradeItem, ItemID.Protector, SpeciesID.Rhyperior);
    public static EvolutionData[] Chansey = Friendship220Evolution(SpeciesID.Blissey);
    public static EvolutionData[] Tangela = SingleEvolution(LevelUpWithMove, MoveID.AncientPower, SpeciesID.Tangrowth);
    public static EvolutionData[] Horsea = LevelEvolution(32, SpeciesID.Seadra);
    public static EvolutionData[] Seadra = SingleEvolution(TradeItem, DragonScale, SpeciesID.Kingdra);
    public static EvolutionData[] Goldeen = LevelEvolution(33, SpeciesID.Seaking);
    public static EvolutionData[] Staryu = ItemEvolution(WaterStone, SpeciesID.Starmie);
    public static EvolutionData[] Scyther = SingleEvolution(TradeItem, MetalCoat, SpeciesID.Scizor);
    public static EvolutionData[] Electabuzz = SingleEvolution(TradeItem, Electrizer, SpeciesID.Electivire);
    public static EvolutionData[] Magmar = SingleEvolution(TradeItem, Magmarizer, SpeciesID.Magmortar);
    public static EvolutionData[] Magikarp = LevelEvolution(20, SpeciesID.Gyarados);
    public static EvolutionData[] Eevee = new EvolutionData[]
    {
        new(EvolutionItem, FireStone, SpeciesID.Flareon),
        new(EvolutionItem, WaterStone, SpeciesID.Vaporeon),
        new(EvolutionItem, ThunderStone, SpeciesID.Jolteon),
        new(FriendshipDay, 220, SpeciesID.Espeon),
        new(FriendshipNight, 220, SpeciesID.Umbreon),
        new(EvolutionItem, LeafStone, SpeciesID.Leafeon),
        new(EvolutionItem, IceStone, SpeciesID.Glaceon),
    };
    public static EvolutionData[] Porygon = SingleEvolution(TradeItem, UpGrade, SpeciesID.Porygon2);
    public static EvolutionData[] Omanyte = LevelEvolution(40, SpeciesID.Omastar);
    public static EvolutionData[] Kabuto = LevelEvolution(40, SpeciesID.Kabutops);
    public static EvolutionData[] Dratini = LevelEvolution(30, SpeciesID.Dragonair);
    public static EvolutionData[] Dragonair = LevelEvolution(55, SpeciesID.Dragonite);

    //Gen 2
    public static EvolutionData[] Chikorita = LevelEvolution(16, SpeciesID.Bayleef);
    public static EvolutionData[] Bayleef = LevelEvolution(32, SpeciesID.Meganium);
    public static EvolutionData[] Cyndaquil = LevelEvolution(14, SpeciesID.Quilava);
    public static EvolutionData[] Quilava = LevelEvolution(36, SpeciesID.Typhlosion);
    public static EvolutionData[] Totodile = LevelEvolution(18, SpeciesID.Croconaw);
    public static EvolutionData[] Croconaw = LevelEvolution(30, SpeciesID.Feraligatr);
    public static EvolutionData[] Sentret = LevelEvolution(15, SpeciesID.Furret);
    public static EvolutionData[] Hoothoot = LevelEvolution(20, SpeciesID.Noctowl);
    public static EvolutionData[] Ledyba = LevelEvolution(18, SpeciesID.Ledian);
    public static EvolutionData[] Spinarak = LevelEvolution(22, SpeciesID.Ariados);
    public static EvolutionData[] Chinchou = LevelEvolution(27, SpeciesID.Lanturn);
    public static EvolutionData[] Pichu = Friendship220Evolution(SpeciesID.Pikachu);
    public static EvolutionData[] Cleffa = Friendship220Evolution(SpeciesID.Clefairy);
    public static EvolutionData[] Igglybuff = Friendship220Evolution(SpeciesID.Jigglypuff);
    public static EvolutionData[] Togepi = Friendship220Evolution(SpeciesID.Togetic);
    public static EvolutionData[] Togetic = ItemEvolution(ShinyStone, SpeciesID.Togekiss);
    public static EvolutionData[] Natu = LevelEvolution(25, SpeciesID.Xatu);
    public static EvolutionData[] Mareep = LevelEvolution(15, SpeciesID.Flaaffy);
    public static EvolutionData[] Flaaffy = LevelEvolution(30, SpeciesID.Ampharos);
    public static EvolutionData[] Marill = LevelEvolution(18, SpeciesID.Azumarill);
    public static EvolutionData[] Hoppip = LevelEvolution(18, SpeciesID.Skiploom);
    public static EvolutionData[] Skiploom = LevelEvolution(27, SpeciesID.Jumpluff);
    public static EvolutionData[] Aipom = SingleEvolution(LevelUpWithMove, MoveID.DoubleHit, SpeciesID.Ambipom);
    public static EvolutionData[] Sunkern = ItemEvolution(SunStone, SpeciesID.Sunflora);
    public static EvolutionData[] Yanma = SingleEvolution(LevelUpWithMove, MoveID.AncientPower, SpeciesID.Yanmega);
    public static EvolutionData[] Wooper = LevelEvolution(20, SpeciesID.Quagsire);
    public static EvolutionData[] Murkrow = ItemEvolution(DuskStone, SpeciesID.Honchkrow);
    public static EvolutionData[] Misdreavus = ItemEvolution(DuskStone, SpeciesID.Mismagius);
    public static EvolutionData[] Pineco = LevelEvolution(31, SpeciesID.Forretress);
    public static EvolutionData[] Gligar = SingleEvolution(LevelUpWithItemNight, RazorFang, SpeciesID.Gliscor);
    public static EvolutionData[] Snubbull = LevelEvolution(23, SpeciesID.Granbull);
    public static EvolutionData[] Sneasel = SingleEvolution(LevelUpWithItemNight, RazorClaw, SpeciesID.Weavile);
    public static EvolutionData[] Teddiursa = LevelEvolution(30, SpeciesID.Ursaring);
    public static EvolutionData[] Slugma = LevelEvolution(38, SpeciesID.Magcargo);
    public static EvolutionData[] Swinub = LevelEvolution(33, SpeciesID.Piloswine);
    public static EvolutionData[] Piloswine = SingleEvolution(LevelUpWithMove, MoveID.AncientPower, SpeciesID.Mamoswine);
    public static EvolutionData[] Remoraid = LevelEvolution(25, SpeciesID.Octillery);
    public static EvolutionData[] Houndour = LevelEvolution(24, SpeciesID.Houndoom);
    public static EvolutionData[] Phanpy = LevelEvolution(25, SpeciesID.Donphan);
    public static EvolutionData[] Porygon2 = SingleEvolution(TradeItem, DubiousDisk, SpeciesID.PorygonZ);
    public static EvolutionData[] Tyrogue = new EvolutionData[]
    {
        new(LevelUpHighAttack, 20, SpeciesID.Hitmonlee),
        new(LevelUpHighDefense, 20, SpeciesID.Hitmonchan),
        new(LevelUpEqualAttackDefense, 20, SpeciesID.Hitmontop)
    };
    public static EvolutionData[] Smoochum = LevelEvolution(30, SpeciesID.Jynx);
    public static EvolutionData[] Elekid = LevelEvolution(30, SpeciesID.Electabuzz);
    public static EvolutionData[] Magby = LevelEvolution(30, SpeciesID.Magmar);
    public static EvolutionData[] Larvitar = LevelEvolution(30, SpeciesID.Pupitar);
    public static EvolutionData[] Pupitar = LevelEvolution(55, SpeciesID.Tyranitar);

    //Gen 3
    public static EvolutionData[] Treecko = LevelEvolution(16, SpeciesID.Grovyle);
    public static EvolutionData[] Grovyle = LevelEvolution(36, SpeciesID.Sceptile);
    public static EvolutionData[] Torchic = LevelEvolution(16, SpeciesID.Combusken);
    public static EvolutionData[] Combusken = LevelEvolution(36, SpeciesID.Blaziken);
    public static EvolutionData[] Mudkip = LevelEvolution(16, SpeciesID.Marshtomp);
    public static EvolutionData[] Marshtomp = LevelEvolution(36, SpeciesID.Swampert);
    public static EvolutionData[] Poochyena = LevelEvolution(18, SpeciesID.Mightyena);
    public static EvolutionData[] Zigzagoon = LevelEvolution(20, SpeciesID.Linoone);
    public static EvolutionData[] Wurmple = new EvolutionData[]
        {
            new(LevelUpOddID, 7, SpeciesID.Silcoon),
            new(LevelUpEvenID, 7, SpeciesID.Cascoon)
        };
    public static EvolutionData[] Silcoon = LevelEvolution(10, SpeciesID.Beautifly);
    public static EvolutionData[] Cascoon = LevelEvolution(10, SpeciesID.Dustox);
    public static EvolutionData[] Lotad = LevelEvolution(14, SpeciesID.Lombre);
    public static EvolutionData[] Lombre = ItemEvolution(WaterStone, SpeciesID.Ludicolo);
    public static EvolutionData[] Seedot = LevelEvolution(14, SpeciesID.Nuzleaf);
    public static EvolutionData[] Nuzleaf = ItemEvolution(LeafStone, SpeciesID.Shiftry);
    public static EvolutionData[] Taillow = LevelEvolution(22, SpeciesID.Swellow);
    public static EvolutionData[] Wingull = LevelEvolution(25, SpeciesID.Pelipper);
    public static EvolutionData[] Ralts = LevelEvolution(20, SpeciesID.Kirlia);
    public static EvolutionData[] Kirlia = new EvolutionData[]
    {
        new(LevelUp, 30, SpeciesID.Gardevoir),
        new(ItemMaleOnly, DawnStone, SpeciesID.Gallade),
    };
    public static EvolutionData[] Surskit = LevelEvolution(22, SpeciesID.Masquerain);
    public static EvolutionData[] Shroomish = LevelEvolution(23, SpeciesID.Breloom);
    public static EvolutionData[] Slakoth = LevelEvolution(18, SpeciesID.Vigoroth);
    public static EvolutionData[] Vigoroth = LevelEvolution(36, SpeciesID.Slaking);
    public static EvolutionData[] Nincada = new EvolutionData[]
    {
        new(LevelUpMakeShedinja, 20, SpeciesID.Ninjask),
        new(Incidental, 0, SpeciesID.Shedinja)
    };
    public static EvolutionData[] Whismur = LevelEvolution(20, SpeciesID.Loudred);
    public static EvolutionData[] Loudred = LevelEvolution(40, SpeciesID.Exploud);
    public static EvolutionData[] Makuhita = LevelEvolution(24, SpeciesID.Hariyama);
    public static EvolutionData[] Azurill = Friendship220Evolution(SpeciesID.Marill);
    public static EvolutionData[] Nosepass = SingleEvolution(LevelUpMagneticField, 0, SpeciesID.Probopass);
    public static EvolutionData[] Skitty = ItemEvolution(MoonStone, SpeciesID.Delcatty);
    public static EvolutionData[] Aron = LevelEvolution(32, SpeciesID.Lairon);
    public static EvolutionData[] Lairon = LevelEvolution(42, SpeciesID.Aggron);
    public static EvolutionData[] Meditite = LevelEvolution(37, SpeciesID.Medicham);
    public static EvolutionData[] Electrike = LevelEvolution(26, SpeciesID.Manectric);
    public static EvolutionData[] Roselia = ItemEvolution(ShinyStone, SpeciesID.Roserade);
    public static EvolutionData[] Gulpin = LevelEvolution(26, SpeciesID.Swalot);
    public static EvolutionData[] Carvanha = LevelEvolution(30, SpeciesID.Sharpedo);
    public static EvolutionData[] Wailmer = LevelEvolution(40, SpeciesID.Wailord);
    public static EvolutionData[] Numel = LevelEvolution(33, SpeciesID.Camerupt);
    public static EvolutionData[] Spoink = LevelEvolution(32, SpeciesID.Grumpig);
    public static EvolutionData[] Trapinch = LevelEvolution(35, SpeciesID.Vibrava);
    public static EvolutionData[] Vibrava = LevelEvolution(45, SpeciesID.Flygon);
    public static EvolutionData[] Cacnea = LevelEvolution(32, SpeciesID.Cacturne);
    public static EvolutionData[] Swablu = LevelEvolution(35, SpeciesID.Altaria);
    public static EvolutionData[] Barboach = LevelEvolution(30, SpeciesID.Whiscash);
    public static EvolutionData[] Corphish = LevelEvolution(30, SpeciesID.Crawdaunt);
    public static EvolutionData[] Baltoy = LevelEvolution(36, SpeciesID.Claydol);
    public static EvolutionData[] Lileep = LevelEvolution(40, SpeciesID.Cradily);
    public static EvolutionData[] Anorith = LevelEvolution(40, SpeciesID.Armaldo);
    public static EvolutionData[] Feebas = new EvolutionData[]
    {
        new(LevelUpMaxBeauty, 0, SpeciesID.Milotic),
        new(TradeItem, PrismScale, SpeciesID.Milotic)
    };
    public static EvolutionData[] Shuppet = LevelEvolution(37, SpeciesID.Banette);
    public static EvolutionData[] Duskull = LevelEvolution(37, SpeciesID.Dusclops);
    public static EvolutionData[] Dusclops = SingleEvolution(TradeItem, ReaperCloth, SpeciesID.Dusknoir);
    public static EvolutionData[] Wynaut = LevelEvolution(15, SpeciesID.Wobbuffet);
    public static EvolutionData[] Snorunt = new EvolutionData[]
    {
        new(LevelUp, 42, SpeciesID.Glalie),
        new(ItemFemaleOnly, DawnStone, SpeciesID.Froslass)
    };
    public static EvolutionData[] Spheal = LevelEvolution(32, SpeciesID.Sealeo);
    public static EvolutionData[] Sealeo = LevelEvolution(44, SpeciesID.Walrein);
    public static EvolutionData[] Clamperl = new EvolutionData[]
    {
        new(TradeItem, DeepSeaTooth, SpeciesID.Huntail),
        new(TradeItem, DeepSeaScale, SpeciesID.Gorebyss)
    };
    public static EvolutionData[] Bagon = LevelEvolution(30, SpeciesID.Shelgon);
    public static EvolutionData[] Shelgon = LevelEvolution(50, SpeciesID.Salamence);
    public static EvolutionData[] Beldum = LevelEvolution(20, SpeciesID.Metang);
    public static EvolutionData[] Metang = LevelEvolution(45, SpeciesID.Metagross);

    //Gen 4

    public static EvolutionData[] Turtwig = LevelEvolution(18, SpeciesID.Grotle);
    public static EvolutionData[] Grotle = LevelEvolution(32, SpeciesID.Torterra);
    public static EvolutionData[] Chimchar = LevelEvolution(14, SpeciesID.Monferno);
    public static EvolutionData[] Monferno = LevelEvolution(36, SpeciesID.Infernape);
    public static EvolutionData[] Piplup = LevelEvolution(16, SpeciesID.Prinplup);
    public static EvolutionData[] Prinplup = LevelEvolution(36, SpeciesID.Empoleon);
    public static EvolutionData[] Starly = LevelEvolution(14, SpeciesID.Staravia);
    public static EvolutionData[] Staravia = LevelEvolution(34, SpeciesID.Staraptor);
    public static EvolutionData[] Bidoof = LevelEvolution(15, SpeciesID.Bibarel);
    public static EvolutionData[] Kricketot = LevelEvolution(10, SpeciesID.Kricketune);
    public static EvolutionData[] Shinx = LevelEvolution(15, SpeciesID.Luxio);
    public static EvolutionData[] Luxio = LevelEvolution(30, SpeciesID.Luxray);
    public static EvolutionData[] Budew = SingleEvolution(FriendshipDay, 220, SpeciesID.Roselia);
    public static EvolutionData[] Cranidos = LevelEvolution(30, SpeciesID.Rampardos);
    public static EvolutionData[] Shieldon = LevelEvolution(30, SpeciesID.Bastiodon);
    public static EvolutionData[] Burmy = new EvolutionData[]
    {
        new(LevelUpFemaleOnly, 20, SpeciesID.Wormadam),
        new(LevelUpMaleOnly, 20, SpeciesID.Mothim)
    };
    public static EvolutionData[] Combee = SingleEvolution(LevelUpFemaleOnly, 21, SpeciesID.Vespiquen);
    public static EvolutionData[] Buizel = LevelEvolution(26, SpeciesID.Floatzel);
    public static EvolutionData[] Cherubi = LevelEvolution(25, SpeciesID.Cherrim);
    public static EvolutionData[] Shellos = LevelEvolution(30, SpeciesID.Gastrodon);
    public static EvolutionData[] Drifloon = LevelEvolution(28, SpeciesID.Drifblim);
    public static EvolutionData[] Buneary = Friendship220Evolution(SpeciesID.Lopunny);
    public static EvolutionData[] Glameow = LevelEvolution(38, SpeciesID.Purugly);
    public static EvolutionData[] Chingling = SingleEvolution(FriendshipNight, 220, SpeciesID.Chimecho);
    public static EvolutionData[] Stunky = LevelEvolution(34, SpeciesID.Skuntank);
    public static EvolutionData[] Bronzor = LevelEvolution(33, SpeciesID.Bronzong);
    public static EvolutionData[] Bonsly = SingleEvolution(LevelUpWithMove, MoveID.Mimic, SpeciesID.Sudowoodo);
    public static EvolutionData[] MimeJr = SingleEvolution(LevelUpWithMove, MoveID.Mimic, SpeciesID.MrMime);
    public static EvolutionData[] Happiny = SingleEvolution(LevelUpWithItemDay, OvalStone, SpeciesID.Chansey);
    public static EvolutionData[] Gible = LevelEvolution(24, SpeciesID.Gabite);
    public static EvolutionData[] Gabite = LevelEvolution(48, SpeciesID.Garchomp);
    public static EvolutionData[] Munchlax = Friendship220Evolution(SpeciesID.Snorlax);
    public static EvolutionData[] Riolu = Friendship220Evolution(SpeciesID.Lucario);
    public static EvolutionData[] Hippopotas = LevelEvolution(34, SpeciesID.Hippowdon);
    public static EvolutionData[] Skorupi = LevelEvolution(40, SpeciesID.Drapion);
    public static EvolutionData[] Croagunk = LevelEvolution(37, SpeciesID.Toxicroak);
    public static EvolutionData[] Finneon = LevelEvolution(31, SpeciesID.Lumineon);
    public static EvolutionData[] Mantyke = SingleEvolution(LevelUpWithMonInParty, (int)SpeciesID.Remoraid, SpeciesID.Mantine);
    public static EvolutionData[] Snover = LevelEvolution(40, SpeciesID.Abomasnow);


    public static EvolutionData[] BurmySand = new EvolutionData[]
    {
        new(LevelUpFemaleOnly, 20, SpeciesID.WormadamSand),
        new(LevelUpMaleOnly, 20, SpeciesID.Mothim)
    };
    public static EvolutionData[] BurmyTrash = new EvolutionData[]
    {
        new(LevelUpFemaleOnly, 20, SpeciesID.WormadamTrash),
        new(LevelUpMaleOnly, 20, SpeciesID.Mothim)
    };
    public static EvolutionData[] ShellosEast = LevelEvolution(30, SpeciesID.GastrodonEast);


    //Gen 5

    public static EvolutionData[] Snivy = LevelEvolution(17, SpeciesID.Servine);
    public static EvolutionData[] Servine = LevelEvolution(36, SpeciesID.Serperior);
    public static EvolutionData[] Tepig = LevelEvolution(17, SpeciesID.Pignite);
    public static EvolutionData[] Pignite = LevelEvolution(36, SpeciesID.Emboar);
    public static EvolutionData[] Oshawott = LevelEvolution(17, SpeciesID.Dewott);
    public static EvolutionData[] Dewott =
    {
        new(LevelUp, 36, SpeciesID.Samurott),
        //new(???, ???, SpeciesID.SamurottHisui)
    };
    public static EvolutionData[] Patrat = LevelEvolution(20, SpeciesID.Watchog);
    public static EvolutionData[] Lillipup = LevelEvolution(16, SpeciesID.Herdier);
    public static EvolutionData[] Herdier = LevelEvolution(32, SpeciesID.Stoutland);
    public static EvolutionData[] Purrloin = LevelEvolution(20, SpeciesID.Liepard);
    public static EvolutionData[] Pansage = ItemEvolution(LeafStone, SpeciesID.Simisage);
    public static EvolutionData[] Pansear = ItemEvolution(FireStone, SpeciesID.Simisear);
    public static EvolutionData[] Panpour = ItemEvolution(WaterStone, SpeciesID.Simipour);
    public static EvolutionData[] Munna = ItemEvolution(MoonStone, SpeciesID.Musharna);
    public static EvolutionData[] Pidove = LevelEvolution(21, SpeciesID.Tranquill);
    public static EvolutionData[] Tranquill = LevelEvolution(32, SpeciesID.Unfezant);
    public static EvolutionData[] Blitzle = LevelEvolution(27, SpeciesID.Zebstrika);
    public static EvolutionData[] Roggenrola = LevelEvolution(25, SpeciesID.Boldore);
    public static EvolutionData[] Boldore = TradeEvolution(SpeciesID.Gigalith);
    public static EvolutionData[] Woobat = Friendship220Evolution(SpeciesID.Swoobat);
    public static EvolutionData[] Drilbur = LevelEvolution(31, SpeciesID.Excadrill);
    public static EvolutionData[] Timburr = LevelEvolution(25, SpeciesID.Gurdurr);
    public static EvolutionData[] Gurdurr = TradeEvolution(SpeciesID.Conkeldurr);
    public static EvolutionData[] Tympole = LevelEvolution(25, SpeciesID.Palpitoad);
    public static EvolutionData[] Palpitoad = LevelEvolution(36, SpeciesID.Seismitoad);
    public static EvolutionData[] Sewaddle = LevelEvolution(20, SpeciesID.Swadloon);
    public static EvolutionData[] Swadloon = Friendship220Evolution(SpeciesID.Leavanny);
    public static EvolutionData[] Venipede = LevelEvolution(22, SpeciesID.Whirlipede);
    public static EvolutionData[] Whirlipede = LevelEvolution(30, SpeciesID.Scolipede);
    public static EvolutionData[] Cottonee = ItemEvolution(SunStone, SpeciesID.Whimsicott);
    public static EvolutionData[] Petilil = new EvolutionData[]
    {
        new(EvolutionItem, SunStone, SpeciesID.Lilligant),
        //new(???, ???, SpeciesID.LilligantHisui)
    };
    public static EvolutionData[] Sandile = LevelEvolution(29, SpeciesID.Krokorok);
    public static EvolutionData[] Krokorok = LevelEvolution(40, SpeciesID.Krookodile);
    public static EvolutionData[] Darumaka = LevelEvolution(35, SpeciesID.Darmanitan);
    public static EvolutionData[] Dwebble = LevelEvolution(34, SpeciesID.Crustle);
    public static EvolutionData[] Scraggy = LevelEvolution(39, SpeciesID.Scrafty);
    public static EvolutionData[] Yamask = LevelEvolution(34, SpeciesID.Cofagrigus);
    public static EvolutionData[] Tirtouga = LevelEvolution(37, SpeciesID.Carracosta);
    public static EvolutionData[] Archen = LevelEvolution(37, SpeciesID.Archeops);
    public static EvolutionData[] Trubbish = LevelEvolution(36, SpeciesID.Garbodor);
    public static EvolutionData[] Zorua = LevelEvolution(30, SpeciesID.Zoroark);
    public static EvolutionData[] Minccino = ItemEvolution(ShinyStone, SpeciesID.Cinccino);
    public static EvolutionData[] Gothita = LevelEvolution(32, SpeciesID.Duosion);
    public static EvolutionData[] Gothorita = LevelEvolution(41, SpeciesID.Gothitelle);
    public static EvolutionData[] Solosis = LevelEvolution(32, SpeciesID.Duosion);
    public static EvolutionData[] Duosion = LevelEvolution(41, SpeciesID.Reuniclus);
    public static EvolutionData[] Ducklett = LevelEvolution(35, SpeciesID.Swanna);
    public static EvolutionData[] Vanillite = LevelEvolution(35, SpeciesID.Vanillish);
    public static EvolutionData[] Vanillish = LevelEvolution(47, SpeciesID.Vanilluxe);
    public static EvolutionData[] DeerlingSpring = LevelEvolution(34, SpeciesID.SawsbuckSpring);
    public static EvolutionData[] Karrablast = SingleEvolution(TradeForMon, SpeciesID.Shelmet, SpeciesID.Escavalier);
    public static EvolutionData[] Foongus = LevelEvolution(39, SpeciesID.Amoonguss);
    public static EvolutionData[] Frillish = LevelEvolution(40, SpeciesID.Jellicent);
    public static EvolutionData[] Joltik = LevelEvolution(36, SpeciesID.Galvantula);
    public static EvolutionData[] Ferroseed = LevelEvolution(40, SpeciesID.Ferrothorn);
    public static EvolutionData[] Klink = LevelEvolution(38, SpeciesID.Klang);
    public static EvolutionData[] Klang = LevelEvolution(49, SpeciesID.Klinklang);
    public static EvolutionData[] Tynamo = LevelEvolution(39, SpeciesID.Eelektrik);
    public static EvolutionData[] Eelektrik = ItemEvolution(ThunderStone, SpeciesID.Eelektross);
    public static EvolutionData[] Elgyem = LevelEvolution(42, SpeciesID.Beheeyem);
    public static EvolutionData[] Litwick = LevelEvolution(41, SpeciesID.Lampent);
    public static EvolutionData[] Lampent = ItemEvolution(DuskStone, SpeciesID.Chandelure);
    public static EvolutionData[] Axew = LevelEvolution(38, SpeciesID.Fraxure);
    public static EvolutionData[] Fraxure = LevelEvolution(48, SpeciesID.Haxorus);
    public static EvolutionData[] Cubchoo = LevelEvolution(37, SpeciesID.Beartic);
    public static EvolutionData[] Shelmet = SingleEvolution(TradeForMon, SpeciesID.Karrablast, SpeciesID.Accelgor);
    public static EvolutionData[] Mienfoo = LevelEvolution(50, SpeciesID.Mienshao);
    public static EvolutionData[] Golett = LevelEvolution(43, SpeciesID.Golurk);
    public static EvolutionData[] Pawniard = LevelEvolution(52, SpeciesID.Bisharp);
    //public static EvolutionData[] Bisharp = SingleEvolution(???, ???, SpeciesID.Kingambit); //Levels up upon defeating 3 Bisharp holding a Leader's Crest
    public static EvolutionData[] Rufflet = new EvolutionData[]
    {
        new(LevelUp, 54, SpeciesID.Braviary),
        //new(???, ???, SpeciesID.BraviaryHisui)
    };
    public static EvolutionData[] Vullaby = LevelEvolution(54, SpeciesID.Mandibuzz);
    public static EvolutionData[] Deino = LevelEvolution(50, SpeciesID.Zweilous);
    public static EvolutionData[] Zweilous = LevelEvolution(64, SpeciesID.Hydreigon);
    public static EvolutionData[] Larvesta = LevelEvolution(59, SpeciesID.Volcarona);

    //Gen 6

    public static EvolutionData[] Chespin = LevelEvolution(16, SpeciesID.Quilladin);
    public static EvolutionData[] Quilladin = LevelEvolution(36, SpeciesID.Chesnaught);
    public static EvolutionData[] Fennekin = LevelEvolution(16, SpeciesID.Braixen);
    public static EvolutionData[] Braixen = LevelEvolution(36, SpeciesID.Delphox);
    public static EvolutionData[] Froakie = LevelEvolution(16, SpeciesID.Frogadier);
    public static EvolutionData[] Frogadier = LevelEvolution(26, SpeciesID.Greninja);
    public static EvolutionData[] Bunnelby = LevelEvolution(20, SpeciesID.Diggersby);
    public static EvolutionData[] Fletchling = LevelEvolution(17, SpeciesID.Fletchinder);
    public static EvolutionData[] Fletchinder = LevelEvolution(35, SpeciesID.Talonflame);



    public static EvolutionData[] DeerlingSummer = LevelEvolution(34, SpeciesID.SawsbuckSummer);
    public static EvolutionData[] DeerlingAutumn = LevelEvolution(34, SpeciesID.SawsbuckAutumn);
    public static EvolutionData[] DeerlingWinter = LevelEvolution(34, SpeciesID.SawsbuckWinter);
}