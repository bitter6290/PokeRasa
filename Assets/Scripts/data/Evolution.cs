using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Evolution
{
    public static EvolutionData[] None = new EvolutionData[] { new EvolutionData(EvolutionMethod.Never, 0, SpeciesID.Missingno) };
    public static EvolutionData[] Bulbasaur = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Ivysaur) };
    public static EvolutionData[] Ivysaur = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 32, SpeciesID.Venusaur) };
    public static EvolutionData[] Charmander = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Charmeleon) };
    public static EvolutionData[] Charmeleon = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 36, SpeciesID.Charizard) };
    public static EvolutionData[] Squirtle = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Wartortle) };
    public static EvolutionData[] Wartortle = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 36, SpeciesID.Blastoise) };
    public static EvolutionData[] Caterpie = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 7, SpeciesID.Metapod) };
    public static EvolutionData[] Metapod = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 10, SpeciesID.Butterfree) };
    public static EvolutionData[] Weedle = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 7, SpeciesID.Kakuna) };
    public static EvolutionData[] Kakuna = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 10, SpeciesID.Beedrill) };
    public static EvolutionData[] Pidgey = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 18, SpeciesID.Pidgeotto) };
    public static EvolutionData[] Pidgeotto = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 36, SpeciesID.Pidgeot) };
    public static EvolutionData[] Rattata = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 20, SpeciesID.Raticate) };
    public static EvolutionData[] Spearow = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 20, SpeciesID.Fearow) };
    public static EvolutionData[] Ekans = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 22, SpeciesID.Arbok) };
    public static EvolutionData[] Pikachu = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.ThunderStone, SpeciesID.Raichu) };
    public static EvolutionData[] Sandshrew = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 22, SpeciesID.Sandslash) };
    public static EvolutionData[] NidoranF = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Nidorina) };
    public static EvolutionData[] Nidorina = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.MoonStone, SpeciesID.Nidoqueen) };
    public static EvolutionData[] NidoranM = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Nidorino) };
    public static EvolutionData[] Nidorino = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.MoonStone, SpeciesID.Nidoking) };
    public static EvolutionData[] Clefairy = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.MoonStone, SpeciesID.Clefable) };
    public static EvolutionData[] Vulpix = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.FireStone, SpeciesID.Ninetales) };
    public static EvolutionData[] Jigglypuff = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.MoonStone, SpeciesID.Wigglytuff) };
    public static EvolutionData[] Zubat = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 22, SpeciesID.Golbat) };
    public static EvolutionData[] Oddish = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 21, SpeciesID.Gloom) };
    public static EvolutionData[] Gloom = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.LeafStone, SpeciesID.Vileplume) };
    public static EvolutionData[] Paras = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 24, SpeciesID.Parasect) };
    public static EvolutionData[] Venonat = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 31, SpeciesID.Venomoth) };
    public static EvolutionData[] Diglett = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 26, SpeciesID.Dugtrio) };
    public static EvolutionData[] Meowth = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 28, SpeciesID.Persian) };
    public static EvolutionData[] Psyduck = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 33, SpeciesID.Golduck) };
    public static EvolutionData[] Mankey = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 28, SpeciesID.Primeape) };
    public static EvolutionData[] Growlithe = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.FireStone, SpeciesID.Arcanine) };
    public static EvolutionData[] Poliwag = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 25, SpeciesID.Poliwhirl) };
    public static EvolutionData[] Poliwhirl = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.WaterStone, SpeciesID.Poliwrath) };
    public static EvolutionData[] Abra = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 16, SpeciesID.Kadabra) };
    public static EvolutionData[] Kadabra = new EvolutionData[] { new EvolutionData(EvolutionMethod.Trade, 0, SpeciesID.Alakazam) };
    public static EvolutionData[] Machop = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 28, SpeciesID.Machoke) };
    public static EvolutionData[] Machoke = new EvolutionData[] { new EvolutionData(EvolutionMethod.Trade, 0, SpeciesID.Machamp) };
    public static EvolutionData[] Bellsprout = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 21, SpeciesID.Weepinbell) };
    public static EvolutionData[] Weepinbell = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.LeafStone, SpeciesID.Victreebel) };
    public static EvolutionData[] Tentacool = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 30, SpeciesID.Tentacruel) };
    public static EvolutionData[] Geodude = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 25, SpeciesID.Graveler) };
    public static EvolutionData[] Graveler = new EvolutionData[] { new EvolutionData(EvolutionMethod.Trade, 0, SpeciesID.Golem) };
    public static EvolutionData[] Ponyta = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 40, SpeciesID.Rapidash) };
    public static EvolutionData[] Slowpoke = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 37, SpeciesID.Slowbro) };
    public static EvolutionData[] Magnemite = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 30, SpeciesID.Magneton) };
    public static EvolutionData[] Doduo = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 31, SpeciesID.Dodrio) };
    public static EvolutionData[] Seel = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 34, SpeciesID.Dewgong) };
    public static EvolutionData[] Grimer = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 38, SpeciesID.Muk) };
    public static EvolutionData[] Shellder = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.WaterStone, SpeciesID.Cloyster) };
    public static EvolutionData[] Gastly = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 25, SpeciesID.Haunter) };
    public static EvolutionData[] Haunter = new EvolutionData[] { new EvolutionData(EvolutionMethod.Trade, 0, SpeciesID.Gengar) };
    public static EvolutionData[] Drowzee = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 26, SpeciesID.Hypno) };
    public static EvolutionData[] Krabby = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 28, SpeciesID.Kingler) };
    public static EvolutionData[] Voltorb = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 30, SpeciesID.Electrode) };
    public static EvolutionData[] Exeggcute = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.LeafStone, SpeciesID.Exeggutor) };
    public static EvolutionData[] Cubone = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 28, SpeciesID.Marowak) };
    public static EvolutionData[] Koffing = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 35, SpeciesID.Weezing) };
    public static EvolutionData[] Rhyhorn = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 42, SpeciesID.Rhydon) };
    public static EvolutionData[] Horsea = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 32, SpeciesID.Seadra) };
    public static EvolutionData[] Goldeen = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 33, SpeciesID.Seaking) };
    public static EvolutionData[] Staryu = new EvolutionData[] { new EvolutionData(EvolutionMethod.Item, (int)ItemID.WaterStone, SpeciesID.Starmie) };
    public static EvolutionData[] Magikarp = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 20, SpeciesID.Gyarados) };
    public static EvolutionData[] Eevee = new EvolutionData[]
    {
        new EvolutionData(EvolutionMethod.Item, (int)ItemID.FireStone, SpeciesID.Flareon),
        new EvolutionData(EvolutionMethod.Item, (int)ItemID.WaterStone, SpeciesID.Vaporeon),
        new EvolutionData(EvolutionMethod.Item, (int)ItemID.ThunderStone, SpeciesID.Jolteon)
    };
    public static EvolutionData[] Omanyte = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 40, SpeciesID.Omastar) };
    public static EvolutionData[] Kabuto = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 40, SpeciesID.Kabutops) };
    public static EvolutionData[] Dratini = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 30, SpeciesID.Dragonair) };
    public static EvolutionData[] Dragonair = new EvolutionData[] { new EvolutionData(EvolutionMethod.LevelUp, 55, SpeciesID.Dragonite) };
}