using System;
public static class Item
{
    public static bool CanBeStolen(ItemID item) => ItemTable[(int)item].type is ItemType.FieldItem or ItemType.BattleItem or ItemType.Medicine;

    public static FieldItem None = new()
    {
        itemName = "Error 901",
        price = 100,
    };

    public static FieldItem FireStone = new()
    {
        itemName = "Fire Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "fire_stone",
    };

    public static FieldItem WaterStone = new()
    {
        itemName = "Water Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "water_stone",
    };

    public static FieldItem ThunderStone = new()
    {
        itemName = "Thunder Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "thunder_stone",
    };

    public static FieldItem LeafStone = new()
    {
        itemName = "Leaf Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "leaf_stone",
    };

    public static FieldItem MoonStone = new()
    {
        itemName = "Moon Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "moon_stone",
    };

    public static FieldItem SunStone = new()
    {
        itemName = "Sun Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "sun_stone",
    };

    public static FieldItem ShinyStone = new()
    {
        itemName = "Shiny Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "shiny_stone",
    };

    public static FieldItem DuskStone = new()
    {
        itemName = "Dusk Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "dusk_stone",
    };

    public static FieldItem DawnStone = new()
    {
        itemName = "Dawn Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "dawn_stone",
    };

    public static FieldItem IceStone = new()
    {
        itemName = "Ice Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "ice_stone",
    };

    //Held items

    public static HeldItem KingsRock = new()
    {
        itemName = "King's Rock",
        price = 15000,
        heldEffect = HeldEffect.KingsRock,
        graphicsPath = "kings_rock",
    };

    public static HeldItem MetalCoat = new()
    {
        itemName = "Metal Coat",
        price = 15000,
        heldEffect = HeldEffect.MetalCoat,
        graphicsPath = "metal_coat",
    };

    //Abstract items - only used for evolutions/specific item checks

    public static AbstractItem DragonScale = new()
    {
        itemName = "Dragon Scale",
        price = 10000,
        graphicsPath = "dragon_scale",
    };

    public static AbstractItem UpGrade = new()
    {
        itemName = "Up-Grade",
        price = 10000,
        graphicsPath = "upgrade",
    };

    //Mega stones

    public static MegaStone Venusaurite = new()
    {
        itemName = "Venusaurite",
        price = 40000,
        originalSpecies = SpeciesID.Venusaur,
        destinationSpecies = SpeciesID.VenusaurMega,
        graphicsPath = "venusaurite",
    };

    public static MegaStone CharizarditeX = new()
    {
        itemName = "Charizardite X",
        price = 40000,
        originalSpecies = SpeciesID.Charizard,
        destinationSpecies = SpeciesID.CharizardMegaX,
        graphicsPath = "charizardite_x",
    };

    public static MegaStone CharizarditeY = new()
    {
        itemName = "Charizardite Y",
        price = 40000,
        originalSpecies = SpeciesID.Charizard,
        destinationSpecies = SpeciesID.CharizardMegaY,
        graphicsPath = "charizardite_y",
    };

    public static MegaStone Blastoisinite = new()
    {
        itemName = "Blastoisinite",
        price = 40000,
        originalSpecies = SpeciesID.Blastoise,
        destinationSpecies = SpeciesID.BlastoiseMega,
        graphicsPath = "blastoisinite",
    };

    public static MegaStone Beedrillite = new()
    {
        itemName = "Beedrillite",
        price = 40000,
        originalSpecies = SpeciesID.Beedrill,
        destinationSpecies = SpeciesID.BeedrillMega,
        graphicsPath = "beedrillite",
    };

    public static MegaStone Pidgeotite = new()
    {
        itemName = "Pidgeotite",
        price = 40000,
        originalSpecies = SpeciesID.Pidgeot,
        destinationSpecies = SpeciesID.PidgeotMega,
        graphicsPath = "pidgeotite"
    };

    public static MegaStone Alakazite = new()
    {
        itemName = "Alakazite",
        price = 40000,
        originalSpecies = SpeciesID.Alakazam,
        destinationSpecies = SpeciesID.AlakazamMega,
        graphicsPath = "alakazite",
    };

    public static MegaStone Slowbronite = new()
    {
        itemName = "Slowbronite",
        price = 40000,
        originalSpecies = SpeciesID.Slowbro,
        destinationSpecies = SpeciesID.SlowbroMega,
        graphicsPath = "slowbronite",
    };

    public static ItemData[] ItemTable = new ItemData[(int)ItemID.Count]
    {
    None,
    //Evolution items
    FireStone,
    WaterStone,
    ThunderStone,
    LeafStone,
    MoonStone,
    SunStone,
    ShinyStone,
    DuskStone,
    DawnStone,
    IceStone,
    //Held items
    KingsRock,
    MetalCoat,
    //Abstract items
    DragonScale,
    UpGrade,
    //Mega stones
    Venusaurite,
    CharizarditeX,
    CharizarditeY,
    Blastoisinite,
    Beedrillite,
    Pidgeotite,
    Alakazite,
    Slowbronite,
    };
}

