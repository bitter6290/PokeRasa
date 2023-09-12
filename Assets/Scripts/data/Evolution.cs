using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EvolutionData;
using static EvolutionMethod;

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
    public static EvolutionData[] Pikachu = SingleEvolution(EvolutionItem, ItemID.ThunderStone, SpeciesID.Raichu);
    public static EvolutionData[] Sandshrew = SingleEvolution(LevelUp, 22, SpeciesID.Sandslash);
    public static EvolutionData[] NidoranF = SingleEvolution(LevelUp, 16, SpeciesID.Nidorina);
    public static EvolutionData[] Nidorina = SingleEvolution(EvolutionItem, ItemID.MoonStone, SpeciesID.Nidoqueen);
    public static EvolutionData[] NidoranM = SingleEvolution(LevelUp, 16, SpeciesID.Nidorino);
    public static EvolutionData[] Nidorino = SingleEvolution(EvolutionItem, ItemID.MoonStone, SpeciesID.Nidoking);
    public static EvolutionData[] Clefairy = SingleEvolution(EvolutionItem, ItemID.MoonStone, SpeciesID.Clefable);
    public static EvolutionData[] Vulpix = SingleEvolution(EvolutionItem, ItemID.FireStone, SpeciesID.Ninetales);
    public static EvolutionData[] Jigglypuff = SingleEvolution(EvolutionItem, ItemID.MoonStone, SpeciesID.Wigglytuff);
    public static EvolutionData[] Zubat = SingleEvolution(LevelUp, 22, SpeciesID.Golbat);
    public static EvolutionData[] Golbat = SingleEvolution(Friendship, 220, SpeciesID.Crobat);
    public static EvolutionData[] Oddish = SingleEvolution(LevelUp, 21, SpeciesID.Gloom);
    public static EvolutionData[] Gloom = SingleEvolution(EvolutionItem, ItemID.LeafStone, SpeciesID.Vileplume);
    public static EvolutionData[] Paras = SingleEvolution(LevelUp, 24, SpeciesID.Parasect);
    public static EvolutionData[] Venonat = SingleEvolution(LevelUp, 31, SpeciesID.Venomoth);
    public static EvolutionData[] Diglett = SingleEvolution(LevelUp, 26, SpeciesID.Dugtrio);
    public static EvolutionData[] Meowth = SingleEvolution(LevelUp, 28, SpeciesID.Persian);
    public static EvolutionData[] Psyduck = SingleEvolution(LevelUp, 33, SpeciesID.Golduck);
    public static EvolutionData[] Mankey = SingleEvolution(LevelUp, 28, SpeciesID.Primeape);
    public static EvolutionData[] Growlithe = SingleEvolution(EvolutionItem, ItemID.FireStone, SpeciesID.Arcanine);
    public static EvolutionData[] Poliwag = SingleEvolution(LevelUp, 25, SpeciesID.Poliwhirl);
    public static EvolutionData[] Poliwhirl = new EvolutionData[]{
        new(EvolutionItem, ItemID.WaterStone, SpeciesID.Poliwrath),
        new(TradeItem, ItemID.KingsRock, SpeciesID.Politoed),
    };
    public static EvolutionData[] Abra = SingleEvolution(LevelUp, 16, SpeciesID.Kadabra);
    public static EvolutionData[] Kadabra = SingleEvolution(Trade, 0, SpeciesID.Alakazam);
    public static EvolutionData[] Machop = SingleEvolution(LevelUp, 28, SpeciesID.Machoke);
    public static EvolutionData[] Machoke = SingleEvolution(Trade, 0, SpeciesID.Machamp);
    public static EvolutionData[] Bellsprout = SingleEvolution(LevelUp, 21, SpeciesID.Weepinbell);
    public static EvolutionData[] Weepinbell = SingleEvolution(EvolutionItem, ItemID.LeafStone, SpeciesID.Victreebel);
    public static EvolutionData[] Tentacool = SingleEvolution(LevelUp, 30, SpeciesID.Tentacruel);
    public static EvolutionData[] Geodude = SingleEvolution(LevelUp, 25, SpeciesID.Graveler);
    public static EvolutionData[] Graveler = SingleEvolution(Trade, 0, SpeciesID.Golem);
    public static EvolutionData[] Ponyta = SingleEvolution(LevelUp, 40, SpeciesID.Rapidash);
    public static EvolutionData[] Slowpoke = new EvolutionData[]{
        new(LevelUp, 37, SpeciesID.Slowbro),
        new(TradeItem, ItemID.KingsRock, SpeciesID.Slowking),
    };
    public static EvolutionData[] Magnemite = SingleEvolution(LevelUp, 30, SpeciesID.Magneton);
    public static EvolutionData[] Doduo = SingleEvolution(LevelUp, 31, SpeciesID.Dodrio);
    public static EvolutionData[] Seel = SingleEvolution(LevelUp, 34, SpeciesID.Dewgong);
    public static EvolutionData[] Grimer = SingleEvolution(LevelUp, 38, SpeciesID.Muk);
    public static EvolutionData[] Shellder = SingleEvolution(EvolutionItem, ItemID.WaterStone, SpeciesID.Cloyster);
    public static EvolutionData[] Gastly = SingleEvolution(LevelUp, 25, SpeciesID.Haunter);
    public static EvolutionData[] Haunter = SingleEvolution(Trade, 0, SpeciesID.Gengar);
    public static EvolutionData[] Onix = SingleEvolution(TradeItem, ItemID.MetalCoat, SpeciesID.Steelix);
    public static EvolutionData[] Drowzee = SingleEvolution(LevelUp, 26, SpeciesID.Hypno);
    public static EvolutionData[] Krabby = SingleEvolution(LevelUp, 28, SpeciesID.Kingler);
    public static EvolutionData[] Voltorb = SingleEvolution(LevelUp, 30, SpeciesID.Electrode);
    public static EvolutionData[] Exeggcute = SingleEvolution(EvolutionItem, ItemID.LeafStone, SpeciesID.Exeggutor);
    public static EvolutionData[] Cubone = SingleEvolution(LevelUp, 28, SpeciesID.Marowak);
    public static EvolutionData[] Koffing = SingleEvolution(LevelUp, 35, SpeciesID.Weezing);
    public static EvolutionData[] Rhyhorn = SingleEvolution(LevelUp, 42, SpeciesID.Rhydon);
    public static EvolutionData[] Chansey = SingleEvolution(Friendship, 220, SpeciesID.Blissey);
    public static EvolutionData[] Horsea = SingleEvolution(LevelUp, 32, SpeciesID.Seadra);
    public static EvolutionData[] Seadra = SingleEvolution(TradeItem, ItemID.DragonScale, SpeciesID.Kingdra);
    public static EvolutionData[] Goldeen = SingleEvolution(LevelUp, 33, SpeciesID.Seaking);
    public static EvolutionData[] Staryu = SingleEvolution(EvolutionItem, ItemID.WaterStone, SpeciesID.Starmie);
    public static EvolutionData[] Scyther = SingleEvolution(TradeItem, ItemID.MetalCoat, SpeciesID.Scizor);
    public static EvolutionData[] Magikarp = SingleEvolution(LevelUp, 20, SpeciesID.Gyarados);
    public static EvolutionData[] Eevee = new EvolutionData[]
    {
        new(EvolutionItem, ItemID.FireStone, SpeciesID.Flareon),
        new(EvolutionItem, ItemID.WaterStone, SpeciesID.Vaporeon),
        new(EvolutionItem, ItemID.ThunderStone, SpeciesID.Jolteon),
        new(FriendshipDay, 220, SpeciesID.Espeon),
        new(FriendshipNight, 220, SpeciesID.Umbreon),
    };
    public static EvolutionData[] Porygon = SingleEvolution(TradeItem, ItemID.UpGrade, SpeciesID.Porygon2);
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
    //public static EvolutionData[] Togetic = SingleEvolution(EvolutionItem, ItemID.ShinyStone, SpeciesID.Togekiss);
    public static EvolutionData[] Natu = SingleEvolution(LevelUp, 25, SpeciesID.Xatu);
    public static EvolutionData[] Mareep = SingleEvolution(LevelUp, 15, SpeciesID.Flaaffy);
    public static EvolutionData[] Flaaffy = SingleEvolution(LevelUp, 30, SpeciesID.Ampharos);
    //public static EvolutionData[] Azurill = SingleEvolution(Friendship, 220, SpeciesID.Marill);
    public static EvolutionData[] Marill = SingleEvolution(LevelUp, 18, SpeciesID.Azumarill);
    public static EvolutionData[] Hoppip = SingleEvolution(LevelUp, 18, SpeciesID.Skiploom);
    public static EvolutionData[] Skiploom = SingleEvolution(LevelUp, 27, SpeciesID.Jumpluff);
    public static EvolutionData[] Sunkern = SingleEvolution(EvolutionItem, ItemID.SunStone, SpeciesID.Sunflora);
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

}