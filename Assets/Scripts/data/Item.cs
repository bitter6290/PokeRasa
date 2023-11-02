using System;
using Unity.VisualScripting;
using static SpeciesID;
using static BerryEffect;
using static FieldEffect;
using static HeldEffect;

public static class Item
{
    public static bool CanBeStolen(ItemID item) =>
        ItemTable[(int)item].type is ItemType.FieldItem or ItemType.BattleItem or ItemType.Medicine;

    public static AbstractItem None = new()
    {
        itemName = "Error 901",
        price = 100,
    };

    public static Berry CheriBerry = new()
    {
        itemName = "Cheri Berry",
        price = 1000,
        berryEffect = CureParalysis,
        graphicsPath = "cheri_berry"
    };

    public static Berry ChestoBerry = new()
    {
        itemName = "Chesto Berry",
        price = 1000,
        berryEffect = CureSleep,
        graphicsPath = "chesto_berry"
    };

    public static Berry PechaBerry = new()
    {
        itemName = "Pecha Berry",
        price = 1000,
        berryEffect = CurePoison,
        graphicsPath = "pecha_berry"
    };

    public static Berry RawstBerry = new()
    {
        itemName = "Rawst Berry",
        price = 1000,
        berryEffect = CureBurn,
        graphicsPath = "rawst_berry"
    };

    public static Berry AspearBerry = new()
    {
        itemName = "Aspear Berry",
        price = 1000,
        berryEffect = CureFreeze,
        graphicsPath = "aspear_berry"
    };

    public static Berry PersimBerry = new()
    {
        itemName = "Persim Berry",
        price = 1000,
        berryEffect = CureConfusion,
        graphicsPath = "persim_berry"
    };

    public static Berry LumBerry = new()
    {
        itemName = "Lum Berry",
        price = 2000,
        berryEffect = CureStatus,
        graphicsPath = "lum_berry"
    };

    public static Berry OranBerry = new()
    {
        itemName = "Oran Berry",
        price = 500,
        berryEffect = At50Restore10HP,
        graphicsPath = "oran_berry"
    };

    public static Berry SitrusBerry = new()
    {
        itemName = "Sitrus Berry",
        price = 1500,
        berryEffect = At50Restore25,
        graphicsPath = "sitrus_berry"
    };

    public static Berry FigyBerry = new()
    {
        itemName = "Figy Berry",
        price = 2500,
        berryEffect = At25Restore33Spicy,
        graphicsPath = "figy_berry"
    };

    public static Berry WikiBerry = new()
    {
        itemName = "Wiki Berry",
        price = 2500,
        berryEffect = At25Restore33Dry,
        graphicsPath = "wiki_berry"
    };

    public static Berry MagoBerry = new()
    {
        itemName = "Mago Berry",
        price = 2500,
        berryEffect = At25Restore33Sweet,
        graphicsPath = "mago_berry"
    };

    public static Berry AguavBerry = new()
    {
        itemName = "Aguav Berry",
        price = 2500,
        berryEffect = At25Restore33Bitter,
        graphicsPath = "aguav_berry"
    };

    public static Berry IapapaBerry = new()
    {
        itemName = "Iapapa Berry",
        price = 2500,
        berryEffect = At25Restore33Sour,
        graphicsPath = "iapapa_berry"
    };

    public static Berry EnigmaBerry = new()
    {
        itemName = "Enigma Berry",
        price = 3000,
        berryEffect = OnSERestore25,
        graphicsPath = "enigma_berry"
    };

    public static Berry LeppaBerry = new()
    {
        itemName = "Leppa Berry",
        price = 2000,
        berryEffect = At0PPRestore10PP,
        graphicsPath = "leppa_berry"
    };

    public static Berry RazzBerry = new()
    {
        itemName = "Razz Berry",
        price = 1000,
        graphicsPath = "razz_berry"
    };

    public static Berry BlukBerry = new()
    {
        itemName = "Bluk Berry",
        price = 1000,
        graphicsPath = "bluk_berry"
    };

    public static Berry NanabBerry = new()
    {
        itemName = "Nanab Berry",
        price = 1000,
        graphicsPath = "nanab_berry"
    };

    public static Berry WepearBerry = new()
    {
        itemName = "Wepear Berry",
        price = 1000,
        graphicsPath = "wepear_berry"
    };

    public static Berry PinapBerry = new()
    {
        itemName = "Pinap Berry",
        price = 1000,
        graphicsPath = "pinap_berry"
    };

    public static Berry PomegBerry = new()
    {
        itemName = "Pomeg Berry",
        price = 5000,
        fieldEffect = HPEVDown10,
        graphicsPath = "pomeg_berry"
    };

    public static Berry KelpsyBerry = new()
    {
        itemName = "Kelpsy Berry",
        price = 5000,
        fieldEffect = AttackEVDown10,
        graphicsPath = "kelpsy_berry"
    };

    public static Berry QualotBerry = new()
    {
        itemName = "Qualot Berry",
        price = 5000,
        fieldEffect = DefenseEVDown10,
        graphicsPath = "qualot_berry"
    };

    public static Berry HondewBerry = new()
    {
        itemName = "Hondew Berry",
        price = 5000,
        fieldEffect = SpAtkEVDown10,
        graphicsPath = "hondew_berry"
    };

    public static Berry GrepaBerry = new()
    {
        itemName = "Grepa Berry",
        price = 5000,
        fieldEffect = SpDefEVDown10,
        graphicsPath = "grepa_berry"
    };

    public static Berry TamatoBerry = new()
    {
        itemName = "Tamato Berry",
        price = 5000,
        fieldEffect = SpeedEVDown10,
        graphicsPath = "tamato_berry"
    };

    public static Berry CornnBerry = new()
    {
        itemName = "Cornn Berry",
        price = 1000,
        graphicsPath = "cornn_Berry"
    };

    public static Berry MagostBerry = new()
    {
        itemName = "Magost Berry",
        price = 1000,
        graphicsPath = "magost_berry"
    };

    public static Berry RabutaBerry = new()
    {
        itemName = "Rabuta Berry",
        price = 1000,
        graphicsPath = "rabuta_berry"
    };

    public static Berry NomelBerry = new()
    {
        itemName = "Nomel Berry",
        price = 1000,
        graphicsPath = "nomel_berry",
    };

    public static Berry SpelonBerry = new()
    {
        itemName = "Spelon Berry",
        price = 1000,
        graphicsPath = "spelon_berry"
    };

    public static Berry PamtreBerry = new()
    {
        itemName = "Pamtre Berry",
        price = 1000,
        graphicsPath = "pamtre_berry"
    };

    public static Berry WatmelBerry = new()
    {
        itemName = "Watmel Berry",
        price = 1000,
        graphicsPath = "watmel_berry"
    };

    public static Berry DurinBerry = new()
    {
        itemName = "Durin Berry",
        price = 1000,
        graphicsPath = "durin_berry"
    };

    public static Berry BelueBerry = new()
    {
        itemName = "Belue Berry",
        price = 1000,
        graphicsPath = "belue_berry"
    };

    public static Berry OccaBerry = new()
    {
        itemName = "Occa Berry",
        price = 2500,
        berryEffect = ReduceFireDamage,
        graphicsPath = "occa_berry"
    };

    public static Berry PasshoBerry = new()
    {
        itemName = "Passho Berry",
        price = 2500,
        berryEffect = ReduceWaterDamage,
        graphicsPath = "passho_berry"
    };

    public static Berry WacanBerry = new()
    {
        itemName = "Wacan Berry",
        price = 2500,
        berryEffect = ReduceElectricDamage,
        graphicsPath = "wacan_berry"
    };

    public static Berry RindoBerry = new()
    {
        itemName = "Rindo Berry",
        price = 2500,
        berryEffect = ReduceGrassDamage,
        graphicsPath = "rindo_berry"
    };

    public static Berry YacheBerry = new()
    {
        itemName = "Yache Berry",
        price = 2500,
        berryEffect = ReduceIceDamage,
        graphicsPath = "yache_berry"
    };

    public static Berry ChopleBerry = new()
    {
        itemName = "Chople Berry",
        price = 2500,
        berryEffect = ReduceFightingDamage,
        graphicsPath = "chople_berry"
    };

    public static Berry KebiaBerry = new()
    {
        itemName = "Kebia Berry",
        price = 2500,
        berryEffect = ReducePoisonDamage,
        graphicsPath = "kebia_berry"
    };

    public static Berry ShucaBerry = new()
    {
        itemName = "Shuca Berry",
        price = 2500,
        berryEffect = ReduceGroundDamage,
        graphicsPath = "shuca_berry"
    };

    public static Berry CobaBerry = new()
    {
        itemName = "Coba Berry",
        price = 2500,
        berryEffect = ReduceFlyingDamage,
        graphicsPath = "coba_berry"
    };

    public static Berry PayapaBerry = new()
    {
        itemName = "Payapa Berry",
        price = 2500,
        berryEffect = ReducePsychicDamage,
        graphicsPath = "payapa_berry"
    };

    public static Berry TangaBerry = new()
    {
        itemName = "Tanga Berry",
        price = 2500,
        berryEffect = ReduceBugDamage,
        graphicsPath = "tanga_berry"
    };

    public static Berry ChartiBerry = new()
    {
        itemName = "Charti Berry",
        price = 2500,
        berryEffect = ReduceRockDamage,
        graphicsPath = "charti_berry"
    };

    public static Berry KasibBerry = new()
    {
        itemName = "Kasib Berry",
        price = 2500,
        berryEffect = ReduceGhostDamage,
        graphicsPath = "kasib_berry"
    };

    public static Berry HabanBerry = new()
    {
        itemName = "Haban Berry",
        price = 2500,
        berryEffect = ReduceDragonDamage,
        graphicsPath = "haban_berry"
    };

    public static Berry ColburBerry = new()
    {
        itemName = "Colbur Berry",
        price = 2500,
        berryEffect = ReduceDarkDamage,
        graphicsPath = "colbur_berry"
    };

    public static Berry BabiriBerry = new()
    {
        itemName = "Babiri Berry",
        price = 2500,
        berryEffect = ReduceSteelDamage,
        graphicsPath = "babiri_berry"
    };


    public static Berry ChilanBerry = new()
    {
        itemName = "Chilan Berry",
        price = 2500,
        berryEffect = ReduceNormalDamage,
        graphicsPath = "chilan_bery"
    };

    public static Berry LiechiBerry = new()
    {
        itemName = "Liechi Berry",
        price = 5000,
        berryEffect = At25RaiseAttack,
        graphicsPath = "liechi_berry"
    };

    public static Berry GanlonBerry = new()
    {
        itemName = "Ganlon Berry",
        price = 5000,
        berryEffect = At25RaiseDefense,
        graphicsPath = "ganlon_berry"
    };

    public static Berry SalacBerry = new()
    {
        itemName = "Salac Berry",
        price = 5000,
        berryEffect = At25RaiseSpeed,
        graphicsPath = "salac_berry"
    };

    public static Berry PetayaBerry = new()
    {
        itemName = "Petaya Berry",
        price = 5000,
        berryEffect = At25RaiseSpAtk,
        graphicsPath = "petaya_berry"
    };

    public static Berry ApicotBerry = new()
    {
        itemName = "Apicot Berry",
        price = 5000,
        berryEffect = At25RaiseSpDef,
        graphicsPath = "apicot_berry"
    };

    public static Berry LansatBerry = new()
    {
        itemName = "Lansat Berry",
        price = 5000,
        berryEffect = At25RaiseCrit,
        graphicsPath = "lansat_berry"
    };

    public static Berry StarfBerry = new()
    {
        itemName = "Starf Berry",
        price = 5000,
        berryEffect = At25RaiseRandom2,
        graphicsPath = "starf_berry"
    };

    public static Berry KeeBerry = new()
    {
        itemName = "Kee Berry",
        price = 2500,
        berryEffect = OnPhysRaiseDefense,
        graphicsPath = "kee_berry"
    };

    public static Berry MarangaBerry = new()
    {
        itemName = "Maranga Berry",
        price = 2500,
        berryEffect = OnSpecRaiseSpDef,
        graphicsPath = "maranga_berry"
    };

    public static Berry MicleBerry = new()
    {
        itemName = "Micle Berry",
        price = 3000,
        berryEffect = At25RaiseAccuracy20,
        graphicsPath = "micle_berry"
    };

    public static Berry CustapBerry = new()
    {
        itemName = "Custap Berry",
        price = 3000,
        berryEffect = At25GetPriority,
        graphicsPath = "custap_berry"
    };

    public static Berry JabocaBerry = new()
    {
        itemName = "Jaboca Berry",
        price = 4000,
        berryEffect = OnPhysHurt125,
        graphicsPath = "jaboca_berry"
    };

    public static Berry RowapBerry = new()
    {
        itemName = "Rowap Berry",
        price = 4000,
        berryEffect = OnSpecHurt125,
        graphicsPath = "rowap_berry"
    };

    public static Berry HopoBerry = new()
    {
        itemName = "Hopo Berry",
        price = 3000,
        berryEffect = At0PPRestore10PP,
        graphicsPath = "hopo_berry"
    };

    public static Berry RoseliBerry = new()
    {
        itemName = "Roseli Berry",
        price = 2500,
        berryEffect = ReduceFairyDamage,
        graphicsPath = "roseli_berry"
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
        heldEffect = HeldEffect.Flinch10,
        graphicsPath = "kings_rock",
        flingEffect = MoveEffect.Flinch,
    };

    public static HeldItem MetalCoat = new()
    {
        itemName = "Metal Coat",
        price = 15000,
        heldEffect = SteelPowerUp20,
        graphicsPath = "metal_coat",
    };

    public static HeldItem DeepSeaTooth = new()
    {
        itemName = "Deep Sea Tooth",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaTooth,
        graphicsPath = "deep_sea_tooth",
        flingPower = 90,
    };

    public static HeldItem DeepSeaScale = new()
    {
        itemName = "Deep Sea Scale",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaScale,
        graphicsPath = "deep_sea_scale"
    };

    public static HeldItem RazorClaw = new()
    {
        itemName = "Razor Claw",
        price = 10000,
        heldEffect = CritRateUp1,
        graphicsPath = "razor_claw"
    };

    public static HeldItem RazorFang = new()
    {
        itemName = "Razor Fang",
        price = 10000,
        heldEffect = Flinch10,
        graphicsPath = "razor_fang"
    };

    public static HeldItem UtilityUmbrella = new()
    {
        itemName = "Utility Umbrella",
        price = 10000,
        heldEffect = ProtectFromWeather,
        graphicsPath = "utility_umbrella"
    };

    //Plates

    public static PlateItem BlankPlate = new()
    {
        itemName = "Blank Plate",
        price = 0,
        heldEffect = NormalPowerUp20,
        plateType = Type.Normal,
        graphicsPath = "blank_plate"
    };

    public static PlateItem FlamePlate = new()
    {
        itemName = "Flame Plate",
        price = 0,
        heldEffect = FirePowerUp20,
        plateType = Type.Fire,
        graphicsPath = "flame_plate"
    };

    public static PlateItem SplashPlate = new()
    {
        itemName = "Splash Plate",
        price = 0,
        heldEffect = WaterPowerUp20,
        plateType = Type.Water,
        graphicsPath = "water_plate"
    };

    public static PlateItem MeadowPlate = new()
    {
        itemName = "Meadow Plate",
        price = 0,
        heldEffect = GrassPowerUp20,
        plateType = Type.Grass,
        graphicsPath = "meadow_plate"
    };

    public static PlateItem ZapPlate = new()
    {
        itemName = "Zap Plate",
        price = 0,
        heldEffect = ElectricPowerUp20,
        plateType = Type.Electric,
        graphicsPath = "zap_plate"
    };

    public static PlateItem IciclePlate = new()
    {
        itemName = "Icicle Plate",
        price = 0,
        heldEffect = IcePowerUp20,
        plateType = Type.Ice,
        graphicsPath = "icicle_plate"
    };

    public static PlateItem EarthPlate = new()
    {
        itemName = "Earth Plate",
        price = 0,
        heldEffect = GroundPowerUp20,
        plateType = Type.Ground,
        graphicsPath = "earth_plate"
    };

    public static PlateItem StonePlate = new()
    {
        itemName = "Stone Plate",
        price = 0,
        heldEffect = RockPowerUp20,
        plateType = Type.Rock,
        graphicsPath = "stone_plate"
    };

    public static PlateItem SkyPlate = new()
    {
        itemName = "Sky Plate",
        price = 0,
        heldEffect = FlyingPowerUp20,
        plateType = Type.Flying,
        graphicsPath = "sky_plate"
    };

    public static PlateItem FistPlate = new()
    {
        itemName = "Fist Plate",
        price = 0,
        heldEffect = FightingPowerUp20,
        plateType = Type.Fighting,
        graphicsPath = "fist_plate"
    };

    public static PlateItem InsectPlate = new()
    {
        itemName = "Insect Plate",
        price = 0,
        heldEffect = BugPowerUp20,
        plateType = Type.Bug,
        graphicsPath = "insect_plate"
    };

    public static PlateItem MindPlate = new()
    {
        itemName = "Mind Plate",
        price = 0,
        heldEffect = PsychicPowerUp20,
        plateType = Type.Psychic,
        graphicsPath = "mind_plate"
    };

    public static PlateItem SpookyPlate = new()
    {
        itemName = "Spooky Plate",
        price = 0,
        heldEffect = GhostPowerUp20,
        plateType = Type.Ghost,
        graphicsPath = "spooky_plate"
    };

    public static PlateItem ToxicPlate = new()
    {
        itemName = "Toxic Plate",
        price = 0,
        heldEffect = PoisonPowerUp20,
        plateType = Type.Poison,
        graphicsPath = "toxic_plate"
    };

    public static PlateItem DracoPlate = new()
    {
        itemName = "Draco Plate",
        price = 0,
        heldEffect = DragonPowerUp20,
        plateType = Type.Dragon,
        graphicsPath = "draco_plate"
    };

    public static PlateItem DreadPlate = new()
    {
        itemName = "Dread Plate",
        price = 0,
        heldEffect = DarkPowerUp20,
        plateType = Type.Dark,
        graphicsPath = "dread_plate"
    };

    public static PlateItem IronPlate = new()
    {
        itemName = "Iron Plate",
        price = 0,
        heldEffect = SteelPowerUp20,
        plateType = Type.Steel,
        graphicsPath = "iron_plate"
    };

    public static PlateItem PixiePlate = new()
    {
        itemName = "Pixie Plate",
        price = 0,
        heldEffect = FairyPowerUp20,
        plateType = Type.Fairy,
        graphicsPath = "pixie_plate"
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

    public static AbstractItem ReaperCloth = new()
    {
        itemName = "Reaper Cloth",
        price = 10000,
        graphicsPath = "reaper_cloth"
    };

    public static AbstractItem Protector = new()
    {
        itemName = "Protector",
        price = 10000,
        graphicsPath = "protector"
    };

    public static AbstractItem Electrizer = new()
    {
        itemName = "Electrizer",
        price = 10000,
        graphicsPath = "electrizer"
    };

    public static AbstractItem Magmarizer = new()
    {
        itemName = "Magmarizer",
        price = 10000,
        graphicsPath = "magmarizer"
    };

    public static AbstractItem DubiousDisk = new()
    {
        itemName = "Dubious Disk",
        price = 10000,
        graphicsPath = "dubious_disk"
    };

    public static AbstractItem OvalStone = new()
    {
        itemName = "Oval Stone",
        price = 10000,
        graphicsPath = "oval_stone"
    };

    public static AbstractItem ShockDrive = new()
    {
        itemName = "Shock Drive",
        price = 100000,
        graphicsPath = "shock_drive"
    };

    public static AbstractItem BurnDrive = new()
    {
        itemName = "Burn Drive",
        price = 100000,
        graphicsPath = "burn_drive"
    };

    public static AbstractItem ChillDrive = new()
    {
        itemName = "Chill Drive",
        price = 100000,
        graphicsPath = "chill_drive"
    };

    public static AbstractItem DouseDrive = new()
    {
        itemName = "Douse Drive",
        price = 100000,
        graphicsPath = "douse_drive"
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

    public static MegaStone Lopunnite = new()
    {
        itemName = "Lopunnite",
        price = 40000,
        originalSpecies = Lopunny,
        destinationSpecies = LopunnyMega,
        graphicsPath = "lopunnite"
    };

    public static MegaStone Garchompite = new()
    {
        itemName = "Garchompite",
        price = 40000,
        originalSpecies = Garchomp,
        destinationSpecies = GarchompMega,
        graphicsPath = "garchompite"
    };

    public static MegaStone Lucarionite = new()
    {
        itemName = "Lucarionite",
        price = 40000,
        originalSpecies = Lucario,
        destinationSpecies = LucarioMega,
        graphicsPath = "lucarionite"
    };

    public static MegaStone Abomasite = new()
    {
        itemName = "Abomasite",
        price = 40000,
        originalSpecies = Abomasnow,
        destinationSpecies = AbomasnowMega,
        graphicsPath = "abomasite"
    };

    public static MegaStone Galladite = new()
    {
        itemName = "Galladite",
        price = 40000,
        originalSpecies = Gallade,
        destinationSpecies = GalladeMega,
        graphicsPath = "galladite"
    };

    public static MegaStone Audinite = new()
    {
        itemName = "Audinite",
        price = 40000,
        originalSpecies = Audino,
        destinationSpecies = AudinoMega,
        graphicsPath = "audinite"
    };

    public static ItemData[] ItemTable = new ItemData[(int)ItemID.Count]
    {
        None,
        //Berries
        CheriBerry,
        ChestoBerry,
        PechaBerry,
        RawstBerry,
        AspearBerry,
        LeppaBerry,
        OranBerry,
        PersimBerry,
        LumBerry,
        SitrusBerry,
        FigyBerry,
        WikiBerry,
        MagoBerry,
        AguavBerry,
        IapapaBerry,
        RazzBerry,
        BlukBerry,
        NanabBerry,
        WepearBerry,
        PinapBerry,
        PomegBerry,
        KelpsyBerry,
        QualotBerry,
        HondewBerry,
        GrepaBerry,
        TamatoBerry,
        CornnBerry,
        MagostBerry,
        RabutaBerry,
        NomelBerry,
        SpelonBerry,
        PamtreBerry,
        WatmelBerry,
        DurinBerry,
        BelueBerry,
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
        ChilanBerry,
        LiechiBerry,
        GanlonBerry,
        SalacBerry,
        PetayaBerry,
        ApicotBerry,
        LansatBerry,
        StarfBerry,
        EnigmaBerry,
        MicleBerry,
        CustapBerry,
        JabocaBerry,
        RowapBerry,
        RoseliBerry,
        KeeBerry,
        MarangaBerry,
        HopoBerry,
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
        RazorClaw,
        RazorFang,
        //Plates
        BlankPlate,
        FlamePlate,
        SplashPlate,
        MeadowPlate,
        ZapPlate,
        IciclePlate,
        EarthPlate,
        SkyPlate,
        FistPlate,
        ToxicPlate,
        InsectPlate,
        StonePlate,
        MindPlate,
        SpookyPlate,
        DracoPlate,
        DreadPlate,
        IronPlate,
        PixiePlate,
        //Abstract items
        DragonScale,
        PrismScale,
        UpGrade,
        ReaperCloth,
        Protector,
        Electrizer,
        Magmarizer,
        DubiousDisk,
        OvalStone,
        ShockDrive,
        BurnDrive,
        ChillDrive,
        DouseDrive,
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
        Lopunnite,
        Garchompite,
        Lucarionite,
        Abomasite,
        Galladite,
        Audinite
    };
}

