using System;
using Unity.VisualScripting;
using static SpeciesID;

public static class Item
{
    public static bool CanBeStolen(ItemID item) => ItemTable[(int)item].type is ItemType.FieldItem or ItemType.BattleItem or ItemType.Medicine;

    public static AbstractItem None = new()
    {
        itemName = "Error 901",
        price = 100,
    };

    public static Berry OccaBerry = new()
    {
        itemName = "Occa Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceFireDamage,
        graphicsPath = "occa_berry"
    };

    public static Berry PasshoBerry = new()
    {
        itemName = "Passho Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceWaterDamage,
        graphicsPath = "passho_berry"
    };

    public static Berry WacanBerry = new()
    {
        itemName = "Wacan Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceElectricDamage,
        graphicsPath = "wacan_berry"
    };

    public static Berry RindoBerry = new()
    {
        itemName = "Rindo Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceGrassDamage,
        graphicsPath = "rindo_berry"
    };

    public static Berry YacheBerry = new()
    {
        itemName = "Yache Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceIceDamage,
        graphicsPath = "yache_berry"
    };

    public static Berry ChopleBerry = new()
    {
        itemName = "Chople Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceFightingDamage,
        graphicsPath = "chople_berry"
    };

    public static Berry KebiaBerry = new()
    {
        itemName = "Kebia Berry",
        price = 2500,
        berryEffect = BerryEffect.ReducePoisonDamage,
        graphicsPath = "kebia_berry"
    };

    public static Berry ShucaBerry = new()
    {
        itemName = "Shuca Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceGroundDamage,
        graphicsPath = "shuca_berry"
    };

    public static Berry CobaBerry = new()
    {
        itemName = "Coba Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceFlyingDamage,
        graphicsPath = "coba_berry"
    };

    public static Berry PayapaBerry = new()
    {
        itemName = "Payapa Berry",
        price = 2500,
        berryEffect = BerryEffect.ReducePsychicDamage,
        graphicsPath = "payapa_berry"
    };

    public static Berry TangaBerry = new()
    {
        itemName = "Tanga Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceBugDamage,
        graphicsPath = "tanga_berry"
    };

    public static Berry ChartiBerry = new()
    {
        itemName = "Charti Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceRockDamage,
        graphicsPath = "charti_berry"
    };

    public static Berry KasibBerry = new()
    {
        itemName = "Kasib Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceGhostDamage,
        graphicsPath = "kasib_berry"
    };

    public static Berry HabanBerry = new()
    {
        itemName = "Haban Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceDragonDamage,
        graphicsPath = "haban_berry"
    };

    public static Berry ColburBerry = new()
    {
        itemName = "Colbur Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceDarkDamage,
        graphicsPath = "colbur_berry"
    };

    public static Berry BabiriBerry = new()
    {
        itemName = "Babiri Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceSteelDamage,
        graphicsPath = "babiri_berry"
    };

    public static Berry RoseliBerry = new()
    {
        itemName = "Roseli Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceFairyDamage,
        graphicsPath = "roseli_berry"
    };

    public static Berry ChilanBerry = new()
    {
        itemName = "Chilan Berry",
        price = 2500,
        berryEffect = BerryEffect.ReduceNormalDamage,
        graphicsPath = "chilan_bery"
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

    public static HeldItem DeepSeaTooth = new()
    {
        itemName = "Deep Sea Tooth",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaTooth,
        graphicsPath = "deep_sea_tooth"
    };

    public static HeldItem DeepSeaScale = new()
    {
        itemName = "Deep Sea Scale",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaScale,
        graphicsPath = "deep_sea_scale"
    };

    //Abstract items - only used for evolutions/specific item checks

    public static AbstractItem DragonScale = new()
    {
        itemName = "Dragon Scale",
        price = 10000,
        graphicsPath = "dragon_scale",
    };

    public static AbstractItem PrismScale = new()
    {
        itemName = "Prism Scale",
        price = 10000,
        graphicsPath = "prism_scale"
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
        originalSpecies = Venusaur,
        destinationSpecies = VenusaurMega,
        graphicsPath = "venusaurite",
    };

    public static MegaStone CharizarditeX = new()
    {
        itemName = "Charizardite X",
        price = 40000,
        originalSpecies = Charizard,
        destinationSpecies = CharizardMegaX,
        graphicsPath = "charizardite_x",
    };

    public static MegaStone CharizarditeY = new()
    {
        itemName = "Charizardite Y",
        price = 40000,
        originalSpecies = Charizard,
        destinationSpecies = CharizardMegaY,
        graphicsPath = "charizardite_y",
    };

    public static MegaStone Blastoisinite = new()
    {
        itemName = "Blastoisinite",
        price = 40000,
        originalSpecies = Blastoise,
        destinationSpecies = BlastoiseMega,
        graphicsPath = "blastoisinite",
    };

    public static MegaStone Beedrillite = new()
    {
        itemName = "Beedrillite",
        price = 40000,
        originalSpecies = Beedrill,
        destinationSpecies = BeedrillMega,
        graphicsPath = "beedrillite",
    };

    public static MegaStone Pidgeotite = new()
    {
        itemName = "Pidgeotite",
        price = 40000,
        originalSpecies = Pidgeot,
        destinationSpecies = PidgeotMega,
        graphicsPath = "pidgeotite"
    };

    public static MegaStone Alakazite = new()
    {
        itemName = "Alakazite",
        price = 40000,
        originalSpecies = Alakazam,
        destinationSpecies = AlakazamMega,
        graphicsPath = "alakazite",
    };

    public static MegaStone Slowbronite = new()
    {
        itemName = "Slowbronite",
        price = 40000,
        originalSpecies = Slowbro,
        destinationSpecies = SlowbroMega,
        graphicsPath = "slowbronite",
    };

    public static MegaStone Gengarite = new()
    {
        itemName = "Gengarite",
        price = 40000,
        originalSpecies = Gengar,
        destinationSpecies = GengarMega,
        graphicsPath = "gengarite",
    };

    public static MegaStone Kangaskhanite = new()
    {
        itemName = "Kangaskhanite",
        price = 40000,
        originalSpecies = Kangaskhan,
        destinationSpecies = KangaskhanMega,
        graphicsPath = "kangaskhanite",
    };

    public static MegaStone Pinsirite = new()
    {
        itemName = "Pinsirite",
        price = 40000,
        originalSpecies = Pinsir,
        destinationSpecies = PinsirMega,
        graphicsPath = "pinsirite",
    };

    public static MegaStone Gyaradosite = new()
    {
        itemName = "Gyaradosite",
        price = 40000,
        originalSpecies = Gyarados,
        destinationSpecies = GyaradosMega,
        graphicsPath = "gyaradosite"
    };

    public static MegaStone Aerodactylite = new()
    {
        itemName = "Aerodactylite",
        price = 40000,
        originalSpecies = Aerodactyl,
        destinationSpecies = AerodactylMega,
        graphicsPath = "aerodactylite",
    };

    public static MegaStone MewtwoniteX = new()
    {
        itemName = "Mewtwonite X",
        price = 40000,
        originalSpecies = Mewtwo,
        destinationSpecies = MewtwoMegaX,
        graphicsPath = "mewtwonite_x"
    };

    public static MegaStone MewtwoniteY = new()
    {
        itemName = "Mewtwonite Y",
        price = 40000,
        originalSpecies = Mewtwo,
        destinationSpecies = MewtwoMegaY,
        graphicsPath = "mewtwonite_y"
    };

    public static MegaStone Ampharosite = new()
    {
        itemName = "Ampharosite",
        price = 40000,
        originalSpecies = Ampharos,
        destinationSpecies = AmpharosMega,
        graphicsPath = "ampharosite",
    };

    public static MegaStone Steelixite = new()
    {
        itemName = "Steelixite",
        price = 40000,
        originalSpecies = Steelix,
        destinationSpecies = SteelixMega,
        graphicsPath = "steelixite",
    };

    public static MegaStone Scizorite = new()
    {
        itemName = "Scizorite",
        price = 40000,
        originalSpecies = Scizor,
        destinationSpecies = ScizorMega,
        graphicsPath = "scizorite",
    };

    public static MegaStone Heracronite = new()
    {
        itemName = "Heracronite",
        price = 40000,
        originalSpecies = Heracross,
        destinationSpecies = HeracrossMega,
        graphicsPath = "heracronite",
    };

    public static MegaStone Houndoominite = new()
    {
        itemName = "Houndoominite",
        price = 40000,
        originalSpecies = Houndoom,
        destinationSpecies = HoundoomMega,
        graphicsPath = "houndoominite",
    };

    public static MegaStone Tyranitarite = new()
    {
        itemName = "Tyranitarite",
        price = 40000,
        originalSpecies = Tyranitar,
        destinationSpecies = TyranitarMega,
        graphicsPath = "tyranitarite",
    };

    public static MegaStone Sceptilite = new()
    {
        itemName = "Sceptilite",
        price = 40000,
        originalSpecies = Sceptile,
        destinationSpecies = SceptileMega,
        graphicsPath = "sceptilite"
    };

    public static MegaStone Blazikenite = new()
    {
        itemName = "Blazikenite",
        price = 40000,
        originalSpecies = Blaziken,
        destinationSpecies = BlazikenMega,
        graphicsPath = "blazikenite"
    };

    public static MegaStone Swampertite = new()
    {
        itemName = "Swampertite",
        price = 40000,
        originalSpecies = Swampert,
        destinationSpecies = SwampertMega,
        graphicsPath = "swampertite"
    };

    public static MegaStone Gardevoirite = new()
    {
        itemName = "Gardevoirite",
        price = 40000,
        originalSpecies = Gardevoir,
        destinationSpecies = GardevoirMega,
        graphicsPath = "gardevoirite"
    };

    public static MegaStone Sablenite = new()
    {
        itemName = "Sablenite",
        price = 40000,
        originalSpecies = Sableye,
        destinationSpecies = SableyeMega,
        graphicsPath = "sablenite"
    };

    public static MegaStone Mawilite = new()
    {
        itemName = "Mawilite",
        price = 40000,
        originalSpecies = Mawile,
        destinationSpecies = MawileMega,
        graphicsPath = "mawilite"
    };

    public static MegaStone Aggronite = new()
    {
        itemName = "Aggronite",
        price = 40000,
        originalSpecies = Aggron,
        destinationSpecies = AggronMega,
        graphicsPath = "aggron"
    };

    public static MegaStone Medichamite = new()
    {
        itemName = "Medichamite",
        price = 40000,
        originalSpecies = Medicham,
        destinationSpecies = MedichamMega,
        graphicsPath = "medichamite"
    };

    public static MegaStone Manectrite = new()
    {
        itemName = "Manectite",
        price = 40000,
        originalSpecies = Manectric,
        destinationSpecies = ManectricMega,
        graphicsPath = "manectite"
    };

    public static MegaStone Sharpedonite = new()
    {
        itemName = "Sharpedonite",
        price = 40000,
        originalSpecies = Sharpedo,
        destinationSpecies = SharpedoMega,
        graphicsPath = "sharpedonite"
    };

    public static MegaStone Cameruptite = new()
    {
        itemName = "Cameruptite",
        price = 40000,
        originalSpecies = Camerupt,
        destinationSpecies = CameruptMega,
        graphicsPath = "cameruptite"
    };

    public static MegaStone Altarianite = new()
    {
        itemName = "Altarianite",
        price = 40000,
        originalSpecies = Altaria,
        destinationSpecies = AltariaMega,
        graphicsPath = "altarianite"
    };

    public static MegaStone Banettite = new()
    {
        itemName = "Banettite",
        price = 40000,
        originalSpecies = Banette,
        destinationSpecies = BanetteMega,
        graphicsPath = "banettite"
    };

    public static MegaStone Absolite = new()
    {
        itemName = "Absolite",
        price = 40000,
        originalSpecies = Absol,
        destinationSpecies = AbsolMega,
        graphicsPath = "absolite"
    };

    public static MegaStone Glalitite = new()
    {
        itemName = "Glalitite",
        price = 40000,
        originalSpecies = Glalie,
        destinationSpecies = GlalieMega,
        graphicsPath = "glalitite"
    };

    public static MegaStone Salamencite = new()
    {
        itemName = "Salamencite",
        price = 40000,
        originalSpecies = Salamence,
        destinationSpecies = SalamenceMega,
        graphicsPath = "salamencite"
    };

    public static MegaStone Metagrossite = new()
    {
        itemName = "Metagrossite",
        price = 40000,
        originalSpecies = Metagross,
        destinationSpecies = MetagrossMega,
        graphicsPath = "metagrossite"
    };

    public static MegaStone Latiasite = new()
    {
        itemName = "Latiasite",
        price = 40000,
        originalSpecies = Latias,
        destinationSpecies = LatiasMega,
        graphicsPath = "latiasite"
    };

    public static MegaStone Latiosite = new()
    {
        itemName = "Latiosite",
        price = 40000,
        originalSpecies = Latios,
        destinationSpecies = LatiosMega,
        graphicsPath = "latiosite"
    };

    public static ItemData[] ItemTable = new ItemData[(int)ItemID.Count]
    {
    None,
    //Berries
    OccaBerry,
    PasshoBerry,
    RindoBerry,
    WacanBerry,
    YacheBerry,
    ChopleBerry,
    KebiaBerry,
    ShucaBerry,
    CobaBerry,
    PayapaBerry,
    TangaBerry,
    ChartiBerry,
    KasibBerry,
    HabanBerry,
    ColburBerry,
    BabiriBerry,
    RoseliBerry,
    ChilanBerry,
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
    DeepSeaTooth,
    DeepSeaScale,
    //Abstract items
    DragonScale,
    PrismScale,
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
    Gengarite,
    Kangaskhanite,
    Pinsirite,
    Gyaradosite,
    Aerodactylite,
    MewtwoniteX,
    MewtwoniteY,
    Ampharosite,
    Steelixite,
    Scizorite,
    Heracronite,
    Houndoominite,
    Tyranitarite,
    Sceptilite,
    Blazikenite,
    Swampertite,
    Gardevoirite,
    Sablenite,
    Mawilite,
    Aggronite,
    Medichamite,
    Manectrite,
    Sharpedonite,
    Cameruptite,
    Altarianite,
    Banettite,
    Absolite,
    Glalitite,
    Salamencite,
    Metagrossite,
    Latiasite,
    Latiosite,
    };
}

