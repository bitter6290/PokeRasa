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
    public static EvolutionData[] Bulbasaur = SingleEvolution(LevelUp, 16, SpeciesID.Ivysaur);
    public static EvolutionData[] Ivysaur = SingleEvolution(LevelUp, 32, SpeciesID.Venusaur);
    public static EvolutionData[] Charmander = SingleEvolution(LevelUp, 16, SpeciesID.Charmeleon);
    public static EvolutionData[] Charmeleon = SingleEvolution(LevelUp, 36, SpeciesID.Charizard);
    public static EvolutionData[] Squirtle = SingleEvolution(LevelUp, 16, SpeciesID.Wartortle);
    public static EvolutionData[] Wartortle = SingleEvolution(LevelUp, 36, SpeciesID.Blastoise);
    public static EvolutionData[] Caterpie = SingleEvolution(LevelUp, 7, SpeciesID.Metapod);
    public static EvolutionData[] Metapod = SingleEvolution(LevelUp, 10, SpeciesID.Butterfree);
    public static EvolutionData[] Weedle = SingleEvolution(LevelUp, 7, SpeciesID.Kakuna);
    public static EvolutionData[] Kakuna = SingleEvolution(LevelUp, 10, SpeciesID.Beedrill);
    public static EvolutionData[] Pidgey = SingleEvolution(LevelUp, 18, SpeciesID.Pidgeotto);
    public static EvolutionData[] Pidgeotto = SingleEvolution(LevelUp, 36, SpeciesID.Pidgeot);
    public static EvolutionData[] Rattata = SingleEvolution(LevelUp, 20, SpeciesID.Raticate);
    public static EvolutionData[] Spearow = SingleEvolution(LevelUp, 20, SpeciesID.Fearow);
    public static EvolutionData[] Ekans = SingleEvolution(LevelUp, 22, SpeciesID.Arbok);
    public static EvolutionData[] Pikachu = SingleEvolution(EvolutionItem, ThunderStone, SpeciesID.Raichu);
    public static EvolutionData[] Sandshrew = SingleEvolution(LevelUp, 22, SpeciesID.Sandslash);
    public static EvolutionData[] NidoranF = SingleEvolution(LevelUp, 16, SpeciesID.Nidorina);
    public static EvolutionData[] Nidorina = SingleEvolution(EvolutionItem, MoonStone, SpeciesID.Nidoqueen);
    public static EvolutionData[] NidoranM = SingleEvolution(LevelUp, 16, SpeciesID.Nidorino);
    public static EvolutionData[] Nidorino = SingleEvolution(EvolutionItem, MoonStone, SpeciesID.Nidoking);
    public static EvolutionData[] Clefairy = SingleEvolution(EvolutionItem, MoonStone, SpeciesID.Clefable);
    public static EvolutionData[] Vulpix = SingleEvolution(EvolutionItem, FireStone, SpeciesID.Ninetales);
    public static EvolutionData[] Jigglypuff = SingleEvolution(EvolutionItem, MoonStone, SpeciesID.Wigglytuff);
    public static EvolutionData[] Zubat = SingleEvolution(LevelUp, 22, SpeciesID.Golbat);
    public static EvolutionData[] Golbat = SingleEvolution(Friendship, 220, SpeciesID.Crobat);
    public static EvolutionData[] Oddish = SingleEvolution(LevelUp, 21, SpeciesID.Gloom);
    public static EvolutionData[] Gloom = SingleEvolution(EvolutionItem, LeafStone, SpeciesID.Vileplume);
    public static EvolutionData[] Paras = SingleEvolution(LevelUp, 24, SpeciesID.Parasect);
    public static EvolutionData[] Venonat = SingleEvolution(LevelUp, 31, SpeciesID.Venomoth);
    public static EvolutionData[] Diglett = SingleEvolution(LevelUp, 26, SpeciesID.Dugtrio);
    public static EvolutionData[] Meowth = SingleEvolution(LevelUp, 28, SpeciesID.Persian);
    public static EvolutionData[] Psyduck = SingleEvolution(LevelUp, 33, SpeciesID.Golduck);
    public static EvolutionData[] Mankey = SingleEvolution(LevelUp, 28, SpeciesID.Primeape);
    public static EvolutionData[] Growlithe = SingleEvolution(EvolutionItem, FireStone, SpeciesID.Arcanine);
    public static EvolutionData[] Poliwag = SingleEvolution(LevelUp, 25, SpeciesID.Poliwhirl);
    public static EvolutionData[] Poliwhirl = new EvolutionData[]{
        new(EvolutionItem, WaterStone, SpeciesID.Poliwrath),
        new(TradeItem, KingsRock, SpeciesID.Politoed),
    };
    public static EvolutionData[] Abra = SingleEvolution(LevelUp, 16, SpeciesID.Kadabra);
    public static EvolutionData[] Kadabra = SingleEvolution(Trade, 0, SpeciesID.Alakazam);
    public static EvolutionData[] Machop = SingleEvolution(LevelUp, 28, SpeciesID.Machoke);
    public static EvolutionData[] Machoke = SingleEvolution(Trade, 0, SpeciesID.Machamp);
    public static EvolutionData[] Bellsprout = SingleEvolution(LevelUp, 21, SpeciesID.Weepinbell);
    public static EvolutionData[] Weepinbell = SingleEvolution(EvolutionItem, LeafStone, SpeciesID.Victreebel);
    public static EvolutionData[] Tentacool = SingleEvolution(LevelUp, 30, SpeciesID.Tentacruel);
    public static EvolutionData[] Geodude = SingleEvolution(LevelUp, 25, SpeciesID.Graveler);
    public static EvolutionData[] Graveler = SingleEvolution(Trade, 0, SpeciesID.Golem);
    public static EvolutionData[] Ponyta = SingleEvolution(LevelUp, 40, SpeciesID.Rapidash);
    public static EvolutionData[] Slowpoke = new EvolutionData[]{
        new(LevelUp, 37, SpeciesID.Slowbro),
        new(TradeItem, KingsRock, SpeciesID.Slowking),
    };
    public static EvolutionData[] Magnemite = SingleEvolution(LevelUp, 30, SpeciesID.Magneton);
    public static EvolutionData[] Doduo = SingleEvolution(LevelUp, 31, SpeciesID.Dodrio);
    public static EvolutionData[] Seel = SingleEvolution(LevelUp, 34, SpeciesID.Dewgong);
    public static EvolutionData[] Grimer = SingleEvolution(LevelUp, 38, SpeciesID.Muk);
    public static EvolutionData[] Shellder = SingleEvolution(EvolutionItem, WaterStone, SpeciesID.Cloyster);
    public static EvolutionData[] Gastly = SingleEvolution(LevelUp, 25, SpeciesID.Haunter);
    public static EvolutionData[] Haunter = SingleEvolution(Trade, 0, SpeciesID.Gengar);
    public static EvolutionData[] Onix = SingleEvolution(TradeItem, MetalCoat, SpeciesID.Steelix);
    public static EvolutionData[] Drowzee = SingleEvolution(LevelUp, 26, SpeciesID.Hypno);
    public static EvolutionData[] Krabby = SingleEvolution(LevelUp, 28, SpeciesID.Kingler);
    public static EvolutionData[] Voltorb = SingleEvolution(LevelUp, 30, SpeciesID.Electrode);
    public static EvolutionData[] Exeggcute = SingleEvolution(EvolutionItem, LeafStone, SpeciesID.Exeggutor);
    public static EvolutionData[] Cubone = SingleEvolution(LevelUp, 28, SpeciesID.Marowak);
    public static EvolutionData[] Koffing = SingleEvolution(LevelUp, 35, SpeciesID.Weezing);
    public static EvolutionData[] Rhyhorn = SingleEvolution(LevelUp, 42, SpeciesID.Rhydon);
    public static EvolutionData[] Chansey = SingleEvolution(Friendship, 220, SpeciesID.Blissey);
    public static EvolutionData[] Horsea = SingleEvolution(LevelUp, 32, SpeciesID.Seadra);
    public static EvolutionData[] Seadra = SingleEvolution(TradeItem, DragonScale, SpeciesID.Kingdra);
    public static EvolutionData[] Goldeen = SingleEvolution(LevelUp, 33, SpeciesID.Seaking);
    public static EvolutionData[] Staryu = SingleEvolution(EvolutionItem, WaterStone, SpeciesID.Starmie);
    public static EvolutionData[] Scyther = SingleEvolution(TradeItem, MetalCoat, SpeciesID.Scizor);
    public static EvolutionData[] Magikarp = SingleEvolution(LevelUp, 20, SpeciesID.Gyarados);
    public static EvolutionData[] Eevee = new EvolutionData[]
    {
        new(EvolutionItem, FireStone, SpeciesID.Flareon),
        new(EvolutionItem, WaterStone, SpeciesID.Vaporeon),
        new(EvolutionItem, ThunderStone, SpeciesID.Jolteon),
        new(FriendshipDay, 220, SpeciesID.Espeon),
        new(FriendshipNight, 220, SpeciesID.Umbreon),
    };
    public static EvolutionData[] Porygon = SingleEvolution(TradeItem, UpGrade, SpeciesID.Porygon2);
    public static EvolutionData[] Omanyte = SingleEvolution(LevelUp, 40, SpeciesID.Omastar);
    public static EvolutionData[] Kabuto = SingleEvolution(LevelUp, 40, SpeciesID.Kabutops);
    public static EvolutionData[] Dratini = SingleEvolution(LevelUp, 30, SpeciesID.Dragonair);
    public static EvolutionData[] Dragonair = SingleEvolution(LevelUp, 55, SpeciesID.Dragonite);

    //Gen 2
    public static EvolutionData[] Chikorita = SingleEvolution(LevelUp, 16, SpeciesID.Bayleef);
    public static EvolutionData[] Bayleef = SingleEvolution(LevelUp, 32, SpeciesID.Meganium);
    public static EvolutionData[] Cyndaquil = SingleEvolution(LevelUp, 14, SpeciesID.Quilava);
    public static EvolutionData[] Quilava = SingleEvolution(LevelUp, 36, SpeciesID.Typhlosion);
    public static EvolutionData[] Totodile = SingleEvolution(LevelUp, 18, SpeciesID.Croconaw);
    public static EvolutionData[] Croconaw = SingleEvolution(LevelUp, 30, SpeciesID.Feraligatr);
    public static EvolutionData[] Sentret = SingleEvolution(LevelUp, 15, SpeciesID.Furret);
    public static EvolutionData[] Hoothoot = SingleEvolution(LevelUp, 20, SpeciesID.Noctowl);
    public static EvolutionData[] Ledyba = SingleEvolution(LevelUp, 18, SpeciesID.Ledian);
    public static EvolutionData[] Spinarak = SingleEvolution(LevelUp, 22, SpeciesID.Ariados);
    public static EvolutionData[] Chinchou = SingleEvolution(LevelUp, 27, SpeciesID.Lanturn);
    public static EvolutionData[] Pichu = SingleEvolution(Friendship, 220, SpeciesID.Pikachu);
    public static EvolutionData[] Cleffa = SingleEvolution(Friendship, 220, SpeciesID.Clefairy);
    public static EvolutionData[] Igglybuff = SingleEvolution(Friendship, 220, SpeciesID.Jigglypuff);
    public static EvolutionData[] Togepi = SingleEvolution(Friendship, 220, SpeciesID.Togetic);
    //public static EvolutionData[] Togetic = SingleEvolution(EvolutionItem, ShinyStone, SpeciesID.Togekiss);
    public static EvolutionData[] Natu = SingleEvolution(LevelUp, 25, SpeciesID.Xatu);
    public static EvolutionData[] Mareep = SingleEvolution(LevelUp, 15, SpeciesID.Flaaffy);
    public static EvolutionData[] Flaaffy = SingleEvolution(LevelUp, 30, SpeciesID.Ampharos);
    public static EvolutionData[] Marill = SingleEvolution(LevelUp, 18, SpeciesID.Azumarill);
    public static EvolutionData[] Hoppip = SingleEvolution(LevelUp, 18, SpeciesID.Skiploom);
    public static EvolutionData[] Skiploom = SingleEvolution(LevelUp, 27, SpeciesID.Jumpluff);
    public static EvolutionData[] Sunkern = SingleEvolution(EvolutionItem, SunStone, SpeciesID.Sunflora);
    public static EvolutionData[] Wooper = SingleEvolution(LevelUp, 20, SpeciesID.Quagsire);
    public static EvolutionData[] Pineco = SingleEvolution(LevelUp, 31, SpeciesID.Forretress);
    public static EvolutionData[] Snubbull = SingleEvolution(LevelUp, 23, SpeciesID.Granbull);
    public static EvolutionData[] Teddiursa = SingleEvolution(LevelUp, 30, SpeciesID.Ursaring);
    public static EvolutionData[] Slugma = SingleEvolution(LevelUp, 38, SpeciesID.Magcargo);
    public static EvolutionData[] Swinub = SingleEvolution(LevelUp, 33, SpeciesID.Piloswine);
    public static EvolutionData[] Remoraid = SingleEvolution(LevelUp, 25, SpeciesID.Octillery);
    public static EvolutionData[] Houndour = SingleEvolution(LevelUp, 24, SpeciesID.Houndoom);
    public static EvolutionData[] Phanpy = SingleEvolution(LevelUp, 25, SpeciesID.Donphan);
    public static EvolutionData[] Tyrogue = new EvolutionData[]
    {
        new(LevelUpHighAttack, 20, SpeciesID.Hitmonlee),
        new(LevelUpHighDefense, 20, SpeciesID.Hitmonchan),
        new(LevelUpEqualAttackDefense, 20, SpeciesID.Hitmontop)
    };
    public static EvolutionData[] Smoochum = SingleEvolution(LevelUp, 30, SpeciesID.Jynx);
    public static EvolutionData[] Elekid = SingleEvolution(LevelUp, 30, SpeciesID.Electabuzz);
    public static EvolutionData[] Magby = SingleEvolution(LevelUp, 30, SpeciesID.Magmar);
    public static EvolutionData[] Larvitar = SingleEvolution(LevelUp, 30, SpeciesID.Pupitar);
    public static EvolutionData[] Pupitar = SingleEvolution(LevelUp, 55, SpeciesID.Tyranitar);

    public static EvolutionData[] Treecko = SingleEvolution(LevelUp, 16, SpeciesID.Grovyle);
    public static EvolutionData[] Grovyle = SingleEvolution(LevelUp, 36, SpeciesID.Sceptile);
    public static EvolutionData[] Torchic = SingleEvolution(LevelUp, 16, SpeciesID.Combusken);
    public static EvolutionData[] Combusken = SingleEvolution(LevelUp, 36, SpeciesID.Blaziken);
    public static EvolutionData[] Mudkip = SingleEvolution(LevelUp, 16, SpeciesID.Marshtomp);
    public static EvolutionData[] Marshtomp = SingleEvolution(LevelUp, 36, SpeciesID.Swampert);
    public static EvolutionData[] Poochyena = SingleEvolution(LevelUp, 18, SpeciesID.Mightyena);
    public static EvolutionData[] Zigzagoon = SingleEvolution(LevelUp, 20, SpeciesID.Linoone);
    public static EvolutionData[] Wurmple = new EvolutionData[]
        {
            new(LevelUpOddID, 7, SpeciesID.Silcoon),
            new(LevelUpEvenID, 7, SpeciesID.Cascoon)
        };
    public static EvolutionData[] Silcoon = SingleEvolution(LevelUp, 10, SpeciesID.Beautifly);
    public static EvolutionData[] Cascoon = SingleEvolution(LevelUp, 10, SpeciesID.Dustox);
    public static EvolutionData[] Lotad = SingleEvolution(LevelUp, 14, SpeciesID.Lombre);
    public static EvolutionData[] Lombre = SingleEvolution(EvolutionItem, WaterStone, SpeciesID.Ludicolo);
    public static EvolutionData[] Seedot = SingleEvolution(LevelUp, 14, SpeciesID.Nuzleaf);
    public static EvolutionData[] Nuzleaf = SingleEvolution(EvolutionItem, LeafStone, SpeciesID.Shiftry);
    public static EvolutionData[] Taillow = SingleEvolution(LevelUp, 22, SpeciesID.Swellow);
    public static EvolutionData[] Wingull = SingleEvolution(LevelUp, 25, SpeciesID.Pelipper);
    public static EvolutionData[] Ralts = SingleEvolution(LevelUp, 20, SpeciesID.Kirlia);
    public static EvolutionData[] Kirlia = new EvolutionData[]
    {
        new(LevelUp, 30, SpeciesID.Gardevoir),
        //new(EvolutionItem, DawnStone, SpeciesID.Gallade),
    };
    public static EvolutionData[] Surskit = SingleEvolution(LevelUp, 22, SpeciesID.Masquerain);
    public static EvolutionData[] Shroomish = SingleEvolution(LevelUp, 23, SpeciesID.Breloom);
    public static EvolutionData[] Slakoth = SingleEvolution(LevelUp, 18, SpeciesID.Vigoroth);
    public static EvolutionData[] Vigoroth = SingleEvolution(LevelUp, 36, SpeciesID.Slaking);
    public static EvolutionData[] Nincada = new EvolutionData[]
    {
        new(LevelUp, 20, SpeciesID.Ninjask),
        new(Incidental, 0, SpeciesID.Shedinja)
    };
    public static EvolutionData[] Whismur = SingleEvolution(LevelUp, 20, SpeciesID.Loudred);
    public static EvolutionData[] Loudred = SingleEvolution(LevelUp, 40, SpeciesID.Exploud);
    public static EvolutionData[] Makuhita = SingleEvolution(LevelUp, 24, SpeciesID.Hariyama);
    public static EvolutionData[] Azurill = SingleEvolution(Friendship, 220, SpeciesID.Marill);
    //public static EvolutionData[] Nosepass = SingleEvolution(LevelUpMagneticField, 0, SpeciesID.Probopass);
    public static EvolutionData[] Skitty = SingleEvolution(EvolutionItem, MoonStone, SpeciesID.Delcatty);
    public static EvolutionData[] Aron = SingleEvolution(LevelUp, 32, SpeciesID.Lairon);
    public static EvolutionData[] Lairon = SingleEvolution(LevelUp, 42, SpeciesID.Aggron);
    public static EvolutionData[] Meditite = SingleEvolution(LevelUp, 37, SpeciesID.Medicham);
    public static EvolutionData[] Electrike = SingleEvolution(LevelUp, 26, SpeciesID.Manectric);
    //public static EvolutionData[] Roselia = SingleEvolution(EvolutionItem, ShinyStone, SpeciesID.Roserade);
    public static EvolutionData[] Gulpin = SingleEvolution(LevelUp, 26, SpeciesID.Swalot);
    public static EvolutionData[] Carvanha = SingleEvolution(LevelUp, 30, SpeciesID.Sharpedo);
    public static EvolutionData[] Wailmer = SingleEvolution(LevelUp, 40, SpeciesID.Wailord);
    public static EvolutionData[] Numel = SingleEvolution(LevelUp, 33, SpeciesID.Camerupt);
    public static EvolutionData[] Spoink = SingleEvolution(LevelUp, 32, SpeciesID.Grumpig);
    public static EvolutionData[] Trapinch = SingleEvolution(LevelUp, 35, SpeciesID.Vibrava);
    public static EvolutionData[] Vibrava = SingleEvolution(LevelUp, 45, SpeciesID.Flygon);
    public static EvolutionData[] Cacnea = SingleEvolution(LevelUp, 32, SpeciesID.Cacturne);
    public static EvolutionData[] Swablu = SingleEvolution(LevelUp, 35, SpeciesID.Altaria);
    public static EvolutionData[] Barboach = SingleEvolution(LevelUp, 30, SpeciesID.Whiscash);
    public static EvolutionData[] Corphish = SingleEvolution(LevelUp, 30, SpeciesID.Crawdaunt);
    public static EvolutionData[] Baltoy = SingleEvolution(LevelUp, 36, SpeciesID.Claydol);
    public static EvolutionData[] Lileep = SingleEvolution(LevelUp, 40, SpeciesID.Cradily);
    public static EvolutionData[] Anorith = SingleEvolution(LevelUp, 40, SpeciesID.Armaldo);
    public static EvolutionData[] Feebas = new EvolutionData[]
    {
        new(LevelUpMaxBeauty, 0, SpeciesID.Milotic),
        new(TradeItem, PrismScale, SpeciesID.Milotic)
    };
    public static EvolutionData[] Shuppet = SingleEvolution(LevelUp, 37, SpeciesID.Banette);
    public static EvolutionData[] Duskull = SingleEvolution(LevelUp, 37, SpeciesID.Dusclops);
    //public static EvolutionData[] Dusclops = SingleEvolution(TradeItem, ReaperCloth, SpeciesID.Dusknoir);
    public static EvolutionData[] Wynaut = SingleEvolution(LevelUp, 15, SpeciesID.Wobbuffet);
    public static EvolutionData[] Snorunt = new EvolutionData[]
    {
        new(LevelUp, 42, SpeciesID.Glalie),
        //new(ItemFemaleOnly, DawnStone, SpeciesID.Froslass)
    };
    public static EvolutionData[] Spheal = SingleEvolution(LevelUp, 32, SpeciesID.Sealeo);
    public static EvolutionData[] Sealeo = SingleEvolution(LevelUp, 44, SpeciesID.Walrein);
    public static EvolutionData[] Clamperl = new EvolutionData[]
    {
        new(TradeItem, DeepSeaTooth, SpeciesID.Huntail),
        new(TradeItem, DeepSeaScale, SpeciesID.Gorebyss)
    };
    public static EvolutionData[] Bagon = SingleEvolution(LevelUp, 30, SpeciesID.Shelgon);
    public static EvolutionData[] Shelgon = SingleEvolution(LevelUp, 50, SpeciesID.Salamence);
    public static EvolutionData[] Beldum = SingleEvolution(LevelUp, 20, SpeciesID.Metang);
    public static EvolutionData[] Metang = SingleEvolution(LevelUp, 45, SpeciesID.Metagross);

}