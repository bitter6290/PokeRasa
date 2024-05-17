using static SpeciesID;
using static BerryEffect;
using static FieldEffect;
using static HeldEffect;
using System.Threading;
using System.Security.Authentication.ExtendedProtection;


public static class Item
{
    public static readonly AbstractItem None = new()
    {
        itemName = "Error 901",
        price = 100,
    };

    public static readonly Berry CheriBerry = new()
    {
        itemName = "Cheri Berry",
        price = 1000,
        berryEffect = CureParalysis,
        graphicsPath = "cheri_berry"
    };

    public static readonly Berry ChestoBerry = new()
    {
        itemName = "Chesto Berry",
        price = 1000,
        berryEffect = CureSleep,
        graphicsPath = "chesto_berry"
    };

    public static readonly Berry PechaBerry = new()
    {
        itemName = "Pecha Berry",
        price = 1000,
        berryEffect = CurePoison,
        graphicsPath = "pecha_berry"
    };

    public static readonly Berry RawstBerry = new()
    {
        itemName = "Rawst Berry",
        price = 1000,
        berryEffect = CureBurn,
        graphicsPath = "rawst_berry"
    };

    public static readonly Berry AspearBerry = new()
    {
        itemName = "Aspear Berry",
        price = 1000,
        berryEffect = CureFreeze,
        graphicsPath = "aspear_berry"
    };

    public static readonly Berry PersimBerry = new()
    {
        itemName = "Persim Berry",
        price = 1000,
        berryEffect = CureConfusion,
        graphicsPath = "persim_berry"
    };

    public static readonly Berry LumBerry = new()
    {
        itemName = "Lum Berry",
        price = 2000,
        berryEffect = CureStatus,
        graphicsPath = "lum_berry"
    };

    public static readonly Berry OranBerry = new()
    {
        itemName = "Oran Berry",
        price = 500,
        berryEffect = At50Restore10HP,
        graphicsPath = "oran_berry"
    };

    public static readonly Berry SitrusBerry = new()
    {
        itemName = "Sitrus Berry",
        price = 1500,
        berryEffect = At50Restore25,
        graphicsPath = "sitrus_berry"
    };

    public static readonly Berry FigyBerry = new()
    {
        itemName = "Figy Berry",
        price = 2500,
        berryEffect = At25Restore33Spicy,
        graphicsPath = "figy_berry"
    };

    public static readonly Berry WikiBerry = new()
    {
        itemName = "Wiki Berry",
        price = 2500,
        berryEffect = At25Restore33Dry,
        graphicsPath = "wiki_berry"
    };

    public static readonly Berry MagoBerry = new()
    {
        itemName = "Mago Berry",
        price = 2500,
        berryEffect = At25Restore33Sweet,
        graphicsPath = "mago_berry"
    };

    public static readonly Berry AguavBerry = new()
    {
        itemName = "Aguav Berry",
        price = 2500,
        berryEffect = At25Restore33Bitter,
        graphicsPath = "aguav_berry"
    };

    public static readonly Berry IapapaBerry = new()
    {
        itemName = "Iapapa Berry",
        price = 2500,
        berryEffect = At25Restore33Sour,
        graphicsPath = "iapapa_berry"
    };

    public static readonly Berry EnigmaBerry = new()
    {
        itemName = "Enigma Berry",
        price = 3000,
        berryEffect = OnSERestore25,
        graphicsPath = "enigma_berry"
    };

    public static readonly Berry LeppaBerry = new()
    {
        itemName = "Leppa Berry",
        price = 2000,
        berryEffect = At0PPRestore10PP,
        graphicsPath = "leppa_berry"
    };

    public static readonly Berry RazzBerry = new()
    {
        itemName = "Razz Berry",
        price = 1000,
        graphicsPath = "razz_berry"
    };

    public static readonly Berry BlukBerry = new()
    {
        itemName = "Bluk Berry",
        price = 1000,
        graphicsPath = "bluk_berry"
    };

    public static readonly Berry NanabBerry = new()
    {
        itemName = "Nanab Berry",
        price = 1000,
        graphicsPath = "nanab_berry"
    };

    public static readonly Berry WepearBerry = new()
    {
        itemName = "Wepear Berry",
        price = 1000,
        graphicsPath = "wepear_berry"
    };

    public static readonly Berry PinapBerry = new()
    {
        itemName = "Pinap Berry",
        price = 1000,
        graphicsPath = "pinap_berry"
    };

    public static readonly Berry PomegBerry = new()
    {
        itemName = "Pomeg Berry",
        price = 5000,
        fieldEffect = HPEVDown10,
        graphicsPath = "pomeg_berry"
    };

    public static readonly Berry KelpsyBerry = new()
    {
        itemName = "Kelpsy Berry",
        price = 5000,
        fieldEffect = AttackEVDown10,
        graphicsPath = "kelpsy_berry"
    };

    public static readonly Berry QualotBerry = new()
    {
        itemName = "Qualot Berry",
        price = 5000,
        fieldEffect = DefenseEVDown10,
        graphicsPath = "qualot_berry"
    };

    public static readonly Berry HondewBerry = new()
    {
        itemName = "Hondew Berry",
        price = 5000,
        fieldEffect = SpAtkEVDown10,
        graphicsPath = "hondew_berry"
    };

    public static readonly Berry GrepaBerry = new()
    {
        itemName = "Grepa Berry",
        price = 5000,
        fieldEffect = SpDefEVDown10,
        graphicsPath = "grepa_berry"
    };

    public static readonly Berry TamatoBerry = new()
    {
        itemName = "Tamato Berry",
        price = 5000,
        fieldEffect = SpeedEVDown10,
        graphicsPath = "tamato_berry"
    };

    public static readonly Berry CornnBerry = new()
    {
        itemName = "Cornn Berry",
        price = 1000,
        graphicsPath = "cornn_Berry"
    };

    public static readonly Berry MagostBerry = new()
    {
        itemName = "Magost Berry",
        price = 1000,
        graphicsPath = "magost_berry"
    };

    public static readonly Berry RabutaBerry = new()
    {
        itemName = "Rabuta Berry",
        price = 1000,
        graphicsPath = "rabuta_berry"
    };

    public static readonly Berry NomelBerry = new()
    {
        itemName = "Nomel Berry",
        price = 1000,
        graphicsPath = "nomel_berry",
    };

    public static readonly Berry SpelonBerry = new()
    {
        itemName = "Spelon Berry",
        price = 1000,
        graphicsPath = "spelon_berry"
    };

    public static readonly Berry PamtreBerry = new()
    {
        itemName = "Pamtre Berry",
        price = 1000,
        graphicsPath = "pamtre_berry"
    };

    public static readonly Berry WatmelBerry = new()
    {
        itemName = "Watmel Berry",
        price = 1000,
        graphicsPath = "watmel_berry"
    };

    public static readonly Berry DurinBerry = new()
    {
        itemName = "Durin Berry",
        price = 1000,
        graphicsPath = "durin_berry"
    };

    public static readonly Berry BelueBerry = new()
    {
        itemName = "Belue Berry",
        price = 1000,
        graphicsPath = "belue_berry"
    };

    public static readonly Berry OccaBerry = new()
    {
        itemName = "Occa Berry",
        price = 2500,
        berryEffect = ReduceFireDamage,
        graphicsPath = "occa_berry"
    };

    public static readonly Berry PasshoBerry = new()
    {
        itemName = "Passho Berry",
        price = 2500,
        berryEffect = ReduceWaterDamage,
        graphicsPath = "passho_berry"
    };

    public static readonly Berry WacanBerry = new()
    {
        itemName = "Wacan Berry",
        price = 2500,
        berryEffect = ReduceElectricDamage,
        graphicsPath = "wacan_berry"
    };

    public static readonly Berry RindoBerry = new()
    {
        itemName = "Rindo Berry",
        price = 2500,
        berryEffect = ReduceGrassDamage,
        graphicsPath = "rindo_berry"
    };

    public static readonly Berry YacheBerry = new()
    {
        itemName = "Yache Berry",
        price = 2500,
        berryEffect = ReduceIceDamage,
        graphicsPath = "yache_berry"
    };

    public static readonly Berry ChopleBerry = new()
    {
        itemName = "Chople Berry",
        price = 2500,
        berryEffect = ReduceFightingDamage,
        graphicsPath = "chople_berry"
    };

    public static readonly Berry KebiaBerry = new()
    {
        itemName = "Kebia Berry",
        price = 2500,
        berryEffect = ReducePoisonDamage,
        graphicsPath = "kebia_berry"
    };

    public static readonly Berry ShucaBerry = new()
    {
        itemName = "Shuca Berry",
        price = 2500,
        berryEffect = ReduceGroundDamage,
        graphicsPath = "shuca_berry"
    };

    public static readonly Berry CobaBerry = new()
    {
        itemName = "Coba Berry",
        price = 2500,
        berryEffect = ReduceFlyingDamage,
        graphicsPath = "coba_berry"
    };

    public static readonly Berry PayapaBerry = new()
    {
        itemName = "Payapa Berry",
        price = 2500,
        berryEffect = ReducePsychicDamage,
        graphicsPath = "payapa_berry"
    };

    public static readonly Berry TangaBerry = new()
    {
        itemName = "Tanga Berry",
        price = 2500,
        berryEffect = ReduceBugDamage,
        graphicsPath = "tanga_berry"
    };

    public static readonly Berry ChartiBerry = new()
    {
        itemName = "Charti Berry",
        price = 2500,
        berryEffect = ReduceRockDamage,
        graphicsPath = "charti_berry"
    };

    public static readonly Berry KasibBerry = new()
    {
        itemName = "Kasib Berry",
        price = 2500,
        berryEffect = ReduceGhostDamage,
        graphicsPath = "kasib_berry"
    };

    public static readonly Berry HabanBerry = new()
    {
        itemName = "Haban Berry",
        price = 2500,
        berryEffect = ReduceDragonDamage,
        graphicsPath = "haban_berry"
    };

    public static readonly Berry ColburBerry = new()
    {
        itemName = "Colbur Berry",
        price = 2500,
        berryEffect = ReduceDarkDamage,
        graphicsPath = "colbur_berry"
    };

    public static readonly Berry BabiriBerry = new()
    {
        itemName = "Babiri Berry",
        price = 2500,
        berryEffect = ReduceSteelDamage,
        graphicsPath = "babiri_berry"
    };


    public static readonly Berry ChilanBerry = new()
    {
        itemName = "Chilan Berry",
        price = 2500,
        berryEffect = ReduceNormalDamage,
        graphicsPath = "chilan_bery"
    };

    public static readonly Berry LiechiBerry = new()
    {
        itemName = "Liechi Berry",
        price = 5000,
        berryEffect = At25RaiseAttack,
        graphicsPath = "liechi_berry"
    };

    public static readonly Berry GanlonBerry = new()
    {
        itemName = "Ganlon Berry",
        price = 5000,
        berryEffect = At25RaiseDefense,
        graphicsPath = "ganlon_berry"
    };

    public static readonly Berry SalacBerry = new()
    {
        itemName = "Salac Berry",
        price = 5000,
        berryEffect = At25RaiseSpeed,
        graphicsPath = "salac_berry"
    };

    public static readonly Berry PetayaBerry = new()
    {
        itemName = "Petaya Berry",
        price = 5000,
        berryEffect = At25RaiseSpAtk,
        graphicsPath = "petaya_berry"
    };

    public static readonly Berry ApicotBerry = new()
    {
        itemName = "Apicot Berry",
        price = 5000,
        berryEffect = At25RaiseSpDef,
        graphicsPath = "apicot_berry"
    };

    public static readonly Berry LansatBerry = new()
    {
        itemName = "Lansat Berry",
        price = 5000,
        berryEffect = At25RaiseCrit,
        graphicsPath = "lansat_berry"
    };

    public static readonly Berry StarfBerry = new()
    {
        itemName = "Starf Berry",
        price = 5000,
        berryEffect = At25RaiseRandom2,
        graphicsPath = "starf_berry"
    };

    public static readonly Berry KeeBerry = new()
    {
        itemName = "Kee Berry",
        price = 2500,
        berryEffect = OnPhysRaiseDefense,
        graphicsPath = "kee_berry"
    };

    public static readonly Berry MarangaBerry = new()
    {
        itemName = "Maranga Berry",
        price = 2500,
        berryEffect = OnSpecRaiseSpDef,
        graphicsPath = "maranga_berry"
    };

    public static readonly Berry MicleBerry = new()
    {
        itemName = "Micle Berry",
        price = 3000,
        berryEffect = At25RaiseAccuracy20,
        graphicsPath = "micle_berry"
    };

    public static readonly Berry CustapBerry = new()
    {
        itemName = "Custap Berry",
        price = 3000,
        berryEffect = At25GetPriority,
        graphicsPath = "custap_berry"
    };

    public static readonly Berry JabocaBerry = new()
    {
        itemName = "Jaboca Berry",
        price = 4000,
        berryEffect = OnPhysHurt125,
        graphicsPath = "jaboca_berry"
    };

    public static readonly Berry RowapBerry = new()
    {
        itemName = "Rowap Berry",
        price = 4000,
        berryEffect = OnSpecHurt125,
        graphicsPath = "rowap_berry"
    };

    public static readonly Berry HopoBerry = new()
    {
        itemName = "Hopo Berry",
        price = 3000,
        berryEffect = At0PPRestore10PP,
        graphicsPath = "hopo_berry"
    };

    public static readonly Berry RoseliBerry = new()
    {
        itemName = "Roseli Berry",
        price = 2500,
        berryEffect = ReduceFairyDamage,
        graphicsPath = "roseli_berry"
    };

    //Medicine

    public static readonly Medicine Potion = new()
    {
        itemName = "Potion",
        price = 200,
        fieldEffect = Heal,
        fieldEffectIntensity = 20,
        battleEffect = BattleEffect.Heal,
        battleEffectIntensity = 20,
        graphicsPath = "potion"
    };

    public static readonly Medicine SuperPotion = new()
    {
        itemName = "Super Potion",
        price = 700,
        fieldEffect = Heal,
        fieldEffectIntensity = 60,
        battleEffect = BattleEffect.Heal,
        battleEffectIntensity = 60,
        graphicsPath = "super_potion"
    };

    public static readonly Medicine HyperPotion = new()
    {
        itemName = "Hyper Potion",
        price = 1500,
        fieldEffect = Heal,
        fieldEffectIntensity = 120,
        battleEffect = BattleEffect.Heal,
        battleEffectIntensity = 120,
        graphicsPath = "hyper_potion"
    };

    public static readonly Medicine MaxPotion = new()
    {
        itemName = "Hyper Potion",
        price = 2500,
        fieldEffect = Heal,
        fieldEffectIntensity = 10000,
        battleEffect = BattleEffect.Heal,
        battleEffectIntensity = 10000,
        graphicsPath = "hyper_potion"
    };

    public static readonly Medicine Antidote = new()
    {
        itemName = "Antidote",
        price = 200,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Poison,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Poison,
        graphicsPath = "antidote"
    };

    public static readonly Medicine ParalyzeHeal = new()
    {
        itemName = "Paralyze Heal",
        price = 200,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Paralysis,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Paralysis,
        graphicsPath = "paralyze_heal"
    };

    public static readonly Medicine Awakening = new()
    {
        itemName = "Awakening",
        price = 200,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Sleep,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Sleep,
        graphicsPath = "awakening"
    };

    public static readonly Medicine BurnHeal = new()
    {
        itemName = "Burn Heal",
        price = 200,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Burn,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Burn,
        graphicsPath = "burn_heal"
    };

    public static readonly Medicine IceHeal = new()
    {
        itemName = "Ice Heal",
        price = 200,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Freeze,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Freeze,
        graphicsPath = "ice_heal"
    };

    public static readonly Medicine FullHeal = new()
    {
        itemName = "Full Heal",
        price = 400,
        fieldEffect = HealStatus,
        fieldEffectIntensity = (int)Status.Any,
        battleEffect = BattleEffect.HealStatus,
        battleEffectIntensity = (int)Status.Any,
        graphicsPath = "full_heal"
    };

    public static readonly Medicine FullRestore = new()
    {
        itemName = "Full Restore",
        price = 3000,
        fieldEffect = FieldEffect.FullRestore,
        fieldEffectIntensity = 0,
        battleEffect = BattleEffect.FullRestore,
        battleEffectIntensity = 0,
        graphicsPath = "full_restore"
    };

    public static readonly Medicine BerryJuice = new()
    {
        itemName = "Berry Juice",
        price = 1500,
        fieldEffect = Heal,
        fieldEffectIntensity = 20,
        battleEffect = BattleEffect.Heal,
        battleEffectIntensity = 20,
        graphicsPath = "berry_juice"
    };

    //Evolution items

    public static readonly FieldItem FireStone = new()
    {
        itemName = "Fire Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "fire_stone",
    };

    public static readonly FieldItem WaterStone = new()
    {
        itemName = "Water Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "water_stone",
    };

    public static readonly FieldItem ThunderStone = new()
    {
        itemName = "Thunder Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "thunder_stone",
    };

    public static readonly FieldItem LeafStone = new()
    {
        itemName = "Leaf Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "leaf_stone",
    };

    public static readonly FieldItem MoonStone = new()
    {
        itemName = "Moon Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "moon_stone",
    };

    public static readonly FieldItem SunStone = new()
    {
        itemName = "Sun Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "sun_stone",
    };

    public static readonly FieldItem ShinyStone = new()
    {
        itemName = "Shiny Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "shiny_stone",
    };

    public static readonly FieldItem DuskStone = new()
    {
        itemName = "Dusk Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "dusk_stone",
    };

    public static readonly FieldItem DawnStone = new()
    {
        itemName = "Dawn Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "dawn_stone",
    };

    public static readonly FieldItem IceStone = new()
    {
        itemName = "Ice Stone",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "ice_stone",
    };

    public static readonly FieldItem TartApple = new()
    {
        itemName = "Tart Apple",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "tart_apple"
    };

    public static readonly FieldItem SweetApple = new()
    {
        itemName = "Sweet Apple",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "sweet_apple"
    };

    public static readonly FieldItem CrackedPot = new()
    {
        itemName = "Cracked Pot",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "cracked_pot"
    };

    public static readonly FieldItem ChippedPot = new()
    {
        itemName = "Chipped Pot",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "chipped_pot"
    };

    public static readonly FieldItem ScrollOfDarkness = new()
    {
        itemName = "Scroll of Darkness",
        price = 20000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "comet_shard" //Todo
    };

    public static readonly FieldItem ScrollOfWaters = new()
    {
        itemName = "Scroll of Waters",
        price = 20000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "comet_shard" //Todo
    };

    public static readonly FieldItem GalaricaCuff = new()
    {
        itemName = "Galarica Cuff",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "galarica_cuff"
    };

    public static readonly FieldItem GalaricaWreath = new()
    {
        itemName = "Galarica Wreath",
        price = 10000,
        fieldEffect = FieldEffect.Evolution,
        graphicsPath = "galarica_wreath"
    };

    //Mints

    public static readonly FieldItem LonelyMint = new()
    {
        itemName = "Lonely Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Lonely,
        graphicsPath = "mint_attack"
    };

    public static readonly FieldItem AdamantMint = new()
    {
        itemName = "Adamant Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Adamant,
        graphicsPath = "mint_attack"
    };

    public static readonly FieldItem NaughtyMint = new()
    {
        itemName = "Naughty Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Naughty,
        graphicsPath = "mint_attack"
    };

    public static readonly FieldItem BraveMint = new()
    {
        itemName = "Brave Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Brave,
        graphicsPath = "mint_attack"
    };

    public static readonly FieldItem BoldMint = new()
    {
        itemName = "Bold Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Bold,
        graphicsPath = "mint_defense"
    };

    public static readonly FieldItem ImpishMint = new()
    {
        itemName = "Impish Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Impish,
        graphicsPath = "mint_defense"
    };

    public static readonly FieldItem LaxMint = new()
    {
        itemName = "Lax Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Lax,
        graphicsPath = "mint_defense"
    };

    public static readonly FieldItem RelaxedMint = new()
    {
        itemName = "Relaxed Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Relaxed,
        graphicsPath = "mint_defense"
    };

    public static readonly FieldItem ModestMint = new()
    {
        itemName = "Modest Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Modest,
        graphicsPath = "mint_sp_atk"
    };

    public static readonly FieldItem MildMint = new()
    {
        itemName = "Mild Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Mild,
        graphicsPath = "mint_sp_atk"
    };

    public static readonly FieldItem RashMint = new()
    {
        itemName = "Rash Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Rash,
        graphicsPath = "mint_sp_atk"
    };

    public static readonly FieldItem QuietMint = new()
    {
        itemName = "Quiet Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Quiet,
        graphicsPath = "mint_sp_atk"
    };

    public static readonly FieldItem CalmMint = new()
    {
        itemName = "Calm Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Calm,
        graphicsPath = "mint_sp_def"
    };

    public static readonly FieldItem GentleMint = new()
    {
        itemName = "Gentle Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Gentle,
        graphicsPath = "mint_sp_def"
    };

    public static readonly FieldItem CarefulMint = new()
    {
        itemName = "Careful Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Careful,
        graphicsPath = "mint_sp_def"
    };

    public static readonly FieldItem SassyMint = new()
    {
        itemName = "Sassy Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Sassy,
        graphicsPath = "mint_sp_def"
    };

    public static readonly FieldItem TimidMint = new()
    {
        itemName = "Timid Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Timid,
        graphicsPath = "mint_speed"
    };

    public static readonly FieldItem HastyMint = new()
    {
        itemName = "Hasty Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Hasty,
        graphicsPath = "mint_speed"
    };

    public static readonly FieldItem JollyMint = new()
    {
        itemName = "Jolly Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Jolly,
        graphicsPath = "mint_speed"
    };

    public static readonly FieldItem NaiveMint = new()
    {
        itemName = "Naive Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Naive,
        graphicsPath = "mint_speed"
    };

    public static readonly FieldItem SeriousMint = new()
    {
        itemName = "Serious Mint",
        price = 20000,
        fieldEffect = Mint,
        fieldEffectIntensity = (int)Nature.Serious,
        graphicsPath = "serious_mint"
    };

    //Feathers and vitamins

    public static readonly FieldItem HealthFeather = new()
    {
        itemName = "Health Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.HP,
        graphicsPath = "health_feather"
    };

    public static readonly FieldItem MuscleFeather = new()
    {
        itemName = "Muscle Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.Attack,
        graphicsPath = "muscle_feather"
    };

    public static readonly FieldItem ResistFeather = new()
    {
        itemName = "Resist Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.Defense,
        graphicsPath = "resist_feather"
    };

    public static readonly FieldItem GeniusFeather = new()
    {
        itemName = "Genius Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.SpAtk,
        graphicsPath = "genius_feather"
    };

    public static readonly FieldItem CleverFeather = new()
    {
        itemName = "Clever Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.SpDef,
        graphicsPath = "clever_feather"
    };

    public static readonly FieldItem SwiftFeather = new()
    {
        itemName = "Swift Feather",
        price = 100,
        fieldEffect = Feather,
        fieldEffectIntensity = (int)Stat.Speed,
        graphicsPath = "swift_feather"
    };

    public static readonly FieldItem HPUp = new()
    {
        itemName = "HP Up",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.HP,
        graphicsPath = "hp_up"
    };

    public static readonly FieldItem Protein = new()
    {
        itemName = "Protein",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.Attack,
        graphicsPath = "protein"
    };

    public static readonly FieldItem Iron = new()
    {
        itemName = "Iron",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.Defense,
        graphicsPath = "iron"
    };

    public static readonly FieldItem Calcium = new()
    {
        itemName = "Calcium",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.SpAtk,
        graphicsPath = "calcium"
    };

    public static readonly FieldItem Zinc = new()
    {
        itemName = "Zinc",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.SpDef,
        graphicsPath = "zinc"
    };

    public static readonly FieldItem Carbos = new()
    {
        itemName = "Carbos",
        price = 10000,
        fieldEffect = Vitamin,
        fieldEffectIntensity = (int)Stat.Speed,
        graphicsPath = "carbos"
    };

    public static readonly FieldItem PPUp = new()
    {
        itemName = "PP Up",
        price = 10000,
        fieldEffect = FieldEffect.PPUp,
        fieldEffectIntensity = 0,
        graphicsPath = "pp_up"
    };

    public static readonly FieldItem PPMax = new()
    {
        itemName = "PP Max",
        price = 25000,
        fieldEffect = FieldEffect.PPMax,
        fieldEffectIntensity = 0,
        graphicsPath = "pp_max"
    };

    //Other field items

    public static readonly FieldItem Honey = new()
    {
        itemName = "Honey",
        price = 300,
        fieldEffect = FieldEffect.None, //Todo: honey encounter effect
        graphicsPath = "honey",
    };

    public static readonly FieldItem AbilityCapsule = new()
    {
        itemName = "Ability Capsule",
        price = 100000,
        fieldEffect = FieldEffect.AbilityCapsule,
        graphicsPath = "ability_capsule"
    };

    public static readonly FieldItem AbilityPatch = new()
    {
        itemName = "Ability Patch",
        price = 250000,
        fieldEffect = FieldEffect.AbilityPatch,
        graphicsPath = "ability_patch"
    };

    public static readonly FieldItem Repel = new()
    {
        itemName = "Repel",
        price = 400,
        fieldEffect = FieldEffect.Repel,
        fieldEffectIntensity = 100,
        graphicsPath = "repel"
    };

    public static readonly FieldItem SuperRepel = new()
    {
        itemName = "Super Repel",
        price = 700,
        fieldEffect = FieldEffect.Repel,
        fieldEffectIntensity = 200,
        graphicsPath = "super_repel"
    };

    public static readonly FieldItem MaxRepel = new()
    {
        itemName = "Max Repel",
        price = 900,
        fieldEffect = FieldEffect.Repel,
        fieldEffectIntensity = 250,
        graphicsPath = "max_repel"
    };

    //Held items

    public static readonly HeldItem KingsRock = new()
    {
        itemName = "King's Rock",
        price = 15000,
        heldEffect = Flinch10,
        graphicsPath = "kings_rock",
        flingEffect = MoveEffect.Flinch,
    };

    public static readonly HeldItem MetalCoat = new()
    {
        itemName = "Metal Coat",
        price = 15000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Steel,
        graphicsPath = "metal_coat",
    };

    public static readonly HeldItem DeepSeaTooth = new()
    {
        itemName = "Deep Sea Tooth",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaTooth,
        graphicsPath = "deep_sea_tooth",
        flingPower = 90,
    };

    public static readonly HeldItem DeepSeaScale = new()
    {
        itemName = "Deep Sea Scale",
        price = 20000,
        heldEffect = HeldEffect.DeepSeaScale,
        graphicsPath = "deep_sea_scale",
    };

    public static readonly HeldItem RazorClaw = new()
    {
        itemName = "Razor Claw",
        price = 10000,
        heldEffect = CritRateUp1,
        graphicsPath = "razor_claw",
        flingPower = 80
    };

    public static readonly HeldItem RazorFang = new()
    {
        itemName = "Razor Fang",
        price = 10000,
        heldEffect = Flinch10,
        graphicsPath = "razor_fang",
        flingEffect = MoveEffect.Flinch
    };

    public static readonly HeldItem UtilityUmbrella = new()
    {
        itemName = "Utility Umbrella",
        price = 10000,
        heldEffect = ProtectFromWeather,
        graphicsPath = "utility_umbrella",
        flingPower = 60,
    };

    public static readonly HeldItem ChoiceBand = new()
    {
        itemName = "Choice Band",
        price = 250000,
        heldEffect = ChoiceItem,
        graphicsPath = "choice_band",
        flingPower = 10,
    };

    public static readonly HeldItem ChoiceSpecs = new()
    {
        itemName = "Choice Specs",
        price = 250000,
        heldEffect = ChoiceItem,
        graphicsPath = "choice_specs",
        flingPower = 10,
    };

    public static readonly HeldItem ChoiceScarf = new()
    {
        itemName = "Choice Scarf",
        price = 250000,
        heldEffect = ChoiceItem,
        graphicsPath = "choice_scarf",
        flingPower = 10,
    };

    public static readonly HeldItem Leftovers = new()
    {
        itemName = "Leftovers",
        price = 50000,
        heldEffect = HeldEffect.Leftovers,
        graphicsPath = "leftovers",
        flingPower = 10,
    };

    public static readonly HeldItem ToxicOrb = new()
    {
        itemName = "Toxic Orb",
        price = 100000,
        heldEffect = HeldEffect.ToxicOrb,
        graphicsPath = "toxic_orb",
        flingEffect = MoveEffect.Toxic,
    };

    public static readonly HeldItem FlameOrb = new()
    {
        itemName = "Flame Orb",
        price = 100000,
        heldEffect = HeldEffect.FlameOrb,
        graphicsPath = "flame_orb",
        flingEffect = MoveEffect.Burn,
    };

    public static readonly HeldItem AbsorbBulb = new()
    {
        itemName = "Absorb Bulb",
        price = 20000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "absorb_bulb"
    };

    public static readonly HeldItem LuminousMoss = new()
    {
        itemName = "Luminous Moss",
        price = 20000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "luminous_moss"
    };

    public static readonly HeldItem CellBattery = new()
    {
        itemName = "Cell Battery",
        price = 20000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "cell_battery"
    };

    public static readonly HeldItem Snowball = new()
    {
        itemName = "Snowball",
        price = 20000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "snowball"
    };

    public static readonly HeldItem WeaknessPolicy = new()
    {
        itemName = "Weakness Policy",
        price = 20000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "weakness_policy",
        flingPower = 80
    };

    public static readonly HeldItem AbilityShield = new()
    {
        itemName = "Ability Shield",
        price = 20000,
        heldEffect = HeldEffect.AbilityShield,
        graphicsPath = "ability_shield",
        flingPower = 30
    };

    public static readonly HeldItem AdrenalineOrb = new()
    {
        itemName = "Adrenaline Orb",
        price = 5000,
        heldEffect = HeldEffect.AdrenalineOrb,
        graphicsPath = "adrenaline_orb",
        flingPower = 30
    };


    public static readonly HeldItem AirBalloon = new()
    {
        itemName = "Air Balloon",
        price = 15000,
        heldEffect = ActivateOnAttack,
        graphicsPath = "air_balloon",
        flingPower = 10
    };

    public static readonly HeldItem AssaultVest = new()
    {
        itemName = "Assault Vest",
        price = 50000,
        heldEffect = Abstract,
        graphicsPath = "assault_vest",
        flingPower = 80
    };

    public static readonly HeldItem ClearAmulet = new()
    {
        itemName = "Clear Amulet",
        price = 30000,
        heldEffect = Abstract,
        graphicsPath = "clear_amulet",
        flingPower = 30
    };

    public static readonly HeldItem BindingBand = new()
    {
        itemName = "Binding Band",
        price = 20000,
        heldEffect = Abstract,
        graphicsPath = "binding_band",
        flingPower = 30
    };

    //Weather rocks

    public static readonly HeldItem DampRock = new()
    {
        itemName = "Damp Rock",
        price = 8000,
        heldEffect = Abstract,
        graphicsPath = "damp_rock",
        flingPower = 60
    };
    public static readonly HeldItem HeatRock = new()
    {
        itemName = "Heat Rock",
        price = 8000,
        heldEffect = Abstract,
        graphicsPath = "heat_rock",
        flingPower = 60
    };
    public static readonly HeldItem IcyRock = new()
    {
        itemName = "Icy Rock",
        price = 8000,
        heldEffect = Abstract,
        graphicsPath = "icy_rock",
        flingPower = 60
    };
    public static readonly HeldItem SmoothRock = new()
    {
        itemName = "Smooth Rock",
        price = 8000,
        heldEffect = Abstract,
        graphicsPath = "smooth_rock",
        flingPower = 60
    };

    //Gems

    public static readonly HeldItem NormalGem = new()
    {
        itemName = "Normal Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Normal,
        graphicsPath = "normal_gem",
        flingPower = 0
    };

    public static readonly HeldItem FireGem = new()
    {
        itemName = "Fire Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Fire,
        graphicsPath = "fire_gem",
        flingPower = 0
    };

    public static readonly HeldItem WaterGem = new()
    {
        itemName = "Water Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Water,
        graphicsPath = "water_gem",
        flingPower = 0
    };

    public static readonly HeldItem GrassGem = new()
    {
        itemName = "Grass Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Grass,
        graphicsPath = "grass_gem",
        flingPower = 0
    };

    public static readonly HeldItem ElectricGem = new()
    {
        itemName = "Electric Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Electric,
        graphicsPath = "electric_gem",
        flingPower = 0
    };

    public static readonly HeldItem IceGem = new()
    {
        itemName = "Ice Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Ice,
        graphicsPath = "ice_gem",
        flingPower = 0
    };

    public static readonly HeldItem GroundGem = new()
    {
        itemName = "Ground Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Ground,
        graphicsPath = "ground_gem",
        flingPower = 0
    };

    public static readonly HeldItem FightingGem = new()
    {
        itemName = "Fighting Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Fighting,
        graphicsPath = "fighting_gem",
        flingPower = 0
    };

    public static readonly HeldItem FlyingGem = new()
    {
        itemName = "Flying Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Flying,
        graphicsPath = "flying_gem",
        flingPower = 0
    };

    public static readonly HeldItem RockGem = new()
    {
        itemName = "Rock Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Rock,
        graphicsPath = "rock_gem",
        flingPower = 0
    };

    public static readonly HeldItem PoisonGem = new()
    {
        itemName = "Poison Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Poison,
        graphicsPath = "poison_gem",
        flingPower = 0
    };
    public static readonly HeldItem BugGem = new()
    {
        itemName = "Bug Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Bug,
        graphicsPath = "bug_gem",
        flingPower = 0
    };

    public static readonly HeldItem PsychicGem = new()
    {
        itemName = "Psychic Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Psychic,
        graphicsPath = "psychic_gem",
        flingPower = 0
    };

    public static readonly HeldItem GhostGem = new()
    {
        itemName = "Ghost Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Ghost,
        graphicsPath = "ghost_gem",
        flingPower = 0
    };

    public static readonly HeldItem DragonGem = new()
    {
        itemName = "Dragon Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Dragon,
        graphicsPath = "dragon_gem",
        flingPower = 0
    };

    public static readonly HeldItem DarkGem = new()
    {
        itemName = "Dark Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Dark,
        graphicsPath = "dark_gem",
        flingPower = 0
    };

    public static readonly HeldItem SteelGem = new()
    {
        itemName = "Steel Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Steel,
        graphicsPath = "steel_gem",
        flingPower = 0
    };

    public static readonly HeldItem FairyGem = new()
    {
        itemName = "Fairy Gem",
        price = 10000,
        heldEffect = Gem,
        heldEffectIntensity = (int)Type.Fairy,
        graphicsPath = "fairy_gem",
        flingPower = 0
    };

    //Type-boosting items
    public static readonly HeldItem BrightPowder = new()
    {
        itemName = "Bright Powder",
        price = 30000,
        heldEffect = Abstract,
        graphicsPath = "bright_powder",
        flingPower = 10
    };

    //Type-boosting items

    public static readonly HeldItem SilkScarf = new()
    {
        itemName = "Silk Scarf",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Normal,
        graphicsPath = "silk_scarf",
        flingPower = 10
    };

    public static readonly HeldItem Charcoal = new()
    {
        itemName = "Charcoal",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Fire,
        graphicsPath = "charcoal",
        flingPower = 30
    };

    public static readonly HeldItem MysticWater = new()
    {
        itemName = "Mystic Water",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Water,
        graphicsPath = "mystic_water",
        flingPower = 30
    };

    public static readonly HeldItem MiracleSeed = new()
    {
        itemName = "Miracle Seed",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Grass,
        graphicsPath = "miracle_seed",
        flingPower = 30
    };

    public static readonly HeldItem Magnet = new()
    {
        itemName = "Magnet",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Electric,
        graphicsPath = "magnet",
        flingPower = 30
    };

    public static readonly HeldItem NeverMeltIce = new()
    {
        itemName = "Never-Melt Ice",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Ice,
        graphicsPath = "never_melt_ice",
        flingPower = 30
    };

    public static readonly HeldItem SoftSand = new()
    {
        itemName = "Soft Sand",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Ground,
        graphicsPath = "soft_sand",
        flingPower = 10
    };

    public static readonly HeldItem BlackBelt = new()
    {
        itemName = "Black Belt",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Fighting,
        graphicsPath = "black_belt",
        flingPower = 30
    };

    public static readonly HeldItem SharpBeak = new()
    {
        itemName = "Sharp Beak",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Flying,
        graphicsPath = "sharp_beak",
        flingPower = 50
    };

    public static readonly HeldItem HardStone = new()
    {
        itemName = "Hard Stone",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Rock,
        graphicsPath = "hard_stone",
        flingPower = 100
    };

    public static readonly HeldItem PoisonBarb = new()
    {
        itemName = "Poison Barb",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Poison,
        graphicsPath = "poison_barb",
        flingPower = 70,
        flingEffect = MoveEffect.Poison
    };

    public static readonly HeldItem SilverPowder = new()
    {
        itemName = "Silver Powder",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Bug,
        graphicsPath = "silver_powder",
        flingPower = 10
    };

    public static readonly HeldItem TwistedSpoon = new()
    {
        itemName = "Twisted Spoon",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Psychic,
        graphicsPath = "twisted_spoon",
        flingPower = 30
    };

    public static readonly HeldItem SpellTag = new()
    {
        itemName = "Spell Tag",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Ghost,
        graphicsPath = "spell_tag",
        flingPower = 30
    };

    public static readonly HeldItem DragonFang = new()
    {
        itemName = "Dragon Fang",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Dragon,
        graphicsPath = "dragon_fang",
        flingPower = 70
    };

    public static readonly HeldItem BlackGlasses = new()
    {
        itemName = "Black Glasses",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Dark,
        graphicsPath = "black_glasses",
        flingPower = 30
    };

    public static readonly HeldItem FairyFeather = new()
    {
        itemName = "Fairy Feather",
        price = 3000,
        heldEffect = BoostMoves20,
        heldEffectIntensity = (int)Type.Fairy,
        graphicsPath = "fairy_feather",
        flingPower = 20 //Based on other Feather items
    };


    //Plates

    public static readonly PlateItem BlankPlate = new()
    {
        itemName = "Blank Plate",
        price = 0,
        plateType = Type.Normal,
        destinationSpecies = Arceus,
        graphicsPath = "blank_plate"
    };

    public static readonly PlateItem FlamePlate = new()
    {
        itemName = "Flame Plate",
        price = 0,
        plateType = Type.Fire,
        destinationSpecies = ArceusFire,
        graphicsPath = "flame_plate"
    };

    public static readonly PlateItem SplashPlate = new()
    {
        itemName = "Splash Plate",
        price = 0,
        plateType = Type.Water,
        destinationSpecies = ArceusWater,
        graphicsPath = "water_plate"
    };

    public static readonly PlateItem MeadowPlate = new()
    {
        itemName = "Meadow Plate",
        price = 0,
        plateType = Type.Grass,
        destinationSpecies = ArceusGrass,
        graphicsPath = "meadow_plate"
    };

    public static readonly PlateItem ZapPlate = new()
    {
        itemName = "Zap Plate",
        price = 0,
        plateType = Type.Electric,
        destinationSpecies = ArceusElectric,
        graphicsPath = "zap_plate"
    };

    public static readonly PlateItem IciclePlate = new()
    {
        itemName = "Icicle Plate",
        price = 0,
        plateType = Type.Ice,
        destinationSpecies = ArceusIce,
        graphicsPath = "icicle_plate"
    };

    public static readonly PlateItem EarthPlate = new()
    {
        itemName = "Earth Plate",
        price = 0,
        plateType = Type.Ground,
        destinationSpecies = ArceusGround,
        graphicsPath = "earth_plate"
    };

    public static readonly PlateItem StonePlate = new()
    {
        itemName = "Stone Plate",
        price = 0,
        plateType = Type.Rock,
        destinationSpecies = ArceusRock,
        graphicsPath = "stone_plate"
    };

    public static readonly PlateItem SkyPlate = new()
    {
        itemName = "Sky Plate",
        price = 0,
        plateType = Type.Flying,
        destinationSpecies = ArceusFlying,
        graphicsPath = "sky_plate"
    };

    public static readonly PlateItem FistPlate = new()
    {
        itemName = "Fist Plate",
        price = 0,
        plateType = Type.Fighting,
        destinationSpecies = ArceusFighting,
        graphicsPath = "fist_plate"
    };

    public static readonly PlateItem InsectPlate = new()
    {
        itemName = "Insect Plate",
        price = 0,
        plateType = Type.Bug,
        destinationSpecies = ArceusBug,
        graphicsPath = "insect_plate"
    };

    public static readonly PlateItem MindPlate = new()
    {
        itemName = "Mind Plate",
        price = 0,
        plateType = Type.Psychic,
        destinationSpecies = ArceusPsychic,
        graphicsPath = "mind_plate"
    };

    public static readonly PlateItem SpookyPlate = new()
    {
        itemName = "Spooky Plate",
        price = 0,
        plateType = Type.Ghost,
        destinationSpecies = ArceusGhost,
        graphicsPath = "spooky_plate"
    };

    public static readonly PlateItem ToxicPlate = new()
    {
        itemName = "Toxic Plate",
        price = 0,
        plateType = Type.Poison,
        destinationSpecies = ArceusPoison,
        graphicsPath = "toxic_plate"
    };

    public static readonly PlateItem DracoPlate = new()
    {
        itemName = "Draco Plate",
        price = 0,
        plateType = Type.Dragon,
        destinationSpecies = ArceusDragon,
        graphicsPath = "draco_plate"
    };

    public static readonly PlateItem DreadPlate = new()
    {
        itemName = "Dread Plate",
        price = 0,
        plateType = Type.Dark,
        destinationSpecies = ArceusDark,
        graphicsPath = "dread_plate"
    };

    public static readonly PlateItem IronPlate = new()
    {
        itemName = "Iron Plate",
        price = 0,
        plateType = Type.Steel,
        destinationSpecies = ArceusSteel,
        graphicsPath = "iron_plate"
    };

    public static readonly PlateItem PixiePlate = new()
    {
        itemName = "Pixie Plate",
        price = 0,
        plateType = Type.Fairy,
        destinationSpecies = ArceusFairy,
        graphicsPath = "pixie_plate"
    };

    //Abstract items - only used for evolutions/specific item checks

    public static readonly AbstractItem DragonScale = new()
    {
        itemName = "Dragon Scale",
        price = 10000,
        graphicsPath = "dragon_scale",
    };

    public static readonly AbstractItem PrismScale = new()
    {
        itemName = "Prism Scale",
        price = 10000,
        graphicsPath = "prism_scale"
    };

    public static readonly AbstractItem UpGrade = new()
    {
        itemName = "Up-Grade",
        price = 10000,
        graphicsPath = "upgrade",
    };

    public static readonly AbstractItem ReaperCloth = new()
    {
        itemName = "Reaper Cloth",
        price = 10000,
        graphicsPath = "reaper_cloth"
    };

    public static readonly AbstractItem Protector = new()
    {
        itemName = "Protector",
        price = 10000,
        graphicsPath = "protector"
    };

    public static readonly AbstractItem Electrizer = new()
    {
        itemName = "Electrizer",
        price = 10000,
        graphicsPath = "electrizer"
    };

    public static readonly AbstractItem Magmarizer = new()
    {
        itemName = "Magmarizer",
        price = 10000,
        graphicsPath = "magmarizer"
    };

    public static readonly AbstractItem DubiousDisk = new()
    {
        itemName = "Dubious Disk",
        price = 10000,
        graphicsPath = "dubious_disk"
    };

    public static readonly AbstractItem OvalStone = new()
    {
        itemName = "Oval Stone",
        price = 10000,
        graphicsPath = "oval_stone"
    };

    public static readonly AbstractItem ShockDrive = new()
    {
        itemName = "Shock Drive",
        price = 100000,
        graphicsPath = "shock_drive"
    };

    public static readonly AbstractItem BurnDrive = new()
    {
        itemName = "Burn Drive",
        price = 100000,
        graphicsPath = "burn_drive"
    };

    public static readonly AbstractItem ChillDrive = new()
    {
        itemName = "Chill Drive",
        price = 100000,
        graphicsPath = "chill_drive"
    };

    public static readonly AbstractItem DouseDrive = new()
    {
        itemName = "Douse Drive",
        price = 100000,
        graphicsPath = "douse_drive"
    };

    public static readonly AbstractItem Satchet = new()
    {
        itemName = "Satchet",
        price = 20000,
        graphicsPath = "satchet"
    };

    public static readonly AbstractItem WhippedDream = new()
    {
        itemName = "Whipped Dream",
        price = 20000,
        graphicsPath = "whipped_dream"
    };

    public static readonly AbstractItem BoosterEnergy = new()
    {
        itemName = "Booster Energy",
        price = 20000,
        graphicsPath = "booster_energy"
    };


    //Poké balls

    public static readonly PokeBall PokeBall = new()
    {
        itemName = "Poké Ball",
        price = 200,
        ballType = BallCatchType.Normal,
        catchRateModifier = 10,
        graphicsPath = "poke_ball"
    };

    public static readonly PokeBall GreatBall = new()
    {
        itemName = "Great Ball",
        price = 600,
        ballType = BallCatchType.Normal,
        catchRateModifier = 15,
        graphicsPath = "great_ball"
    };

    public static readonly PokeBall UltraBall = new()
    {
        itemName = "Ultra Ball",
        price = 1000,
        ballType = BallCatchType.Normal,
        catchRateModifier = 20,
        graphicsPath = "ultra_ball"
    };

    public static readonly PokeBall MasterBall = new()
    {
        itemName = "Master Ball",
        price = 1000000,
        ballType = BallCatchType.Master,
        catchRateModifier = 1,
        graphicsPath = "master_ball"
    };

    //Mega stones

    public static readonly MegaStone Venusaurite = new()
    {
        itemName = "Venusaurite",
        price = 40000,
        originalSpecies = Venusaur,
        destinationSpecies = VenusaurMega,
        graphicsPath = "venusaurite",
    };

    public static readonly MegaStone CharizarditeX = new()
    {
        itemName = "Charizardite X",
        price = 40000,
        originalSpecies = Charizard,
        destinationSpecies = CharizardMegaX,
        graphicsPath = "charizardite_x",
    };

    public static readonly MegaStone CharizarditeY = new()
    {
        itemName = "Charizardite Y",
        price = 40000,
        originalSpecies = Charizard,
        destinationSpecies = CharizardMegaY,
        graphicsPath = "charizardite_y",
    };

    public static readonly MegaStone Blastoisinite = new()
    {
        itemName = "Blastoisinite",
        price = 40000,
        originalSpecies = Blastoise,
        destinationSpecies = BlastoiseMega,
        graphicsPath = "blastoisinite",
    };

    public static readonly MegaStone Beedrillite = new()
    {
        itemName = "Beedrillite",
        price = 40000,
        originalSpecies = Beedrill,
        destinationSpecies = BeedrillMega,
        graphicsPath = "beedrillite",
    };

    public static readonly MegaStone Pidgeotite = new()
    {
        itemName = "Pidgeotite",
        price = 40000,
        originalSpecies = Pidgeot,
        destinationSpecies = PidgeotMega,
        graphicsPath = "pidgeotite"
    };

    public static readonly MegaStone Alakazite = new()
    {
        itemName = "Alakazite",
        price = 40000,
        originalSpecies = Alakazam,
        destinationSpecies = AlakazamMega,
        graphicsPath = "alakazite",
    };

    public static readonly MegaStone Slowbronite = new()
    {
        itemName = "Slowbronite",
        price = 40000,
        originalSpecies = Slowbro,
        destinationSpecies = SlowbroMega,
        graphicsPath = "slowbronite",
    };

    public static readonly MegaStone Gengarite = new()
    {
        itemName = "Gengarite",
        price = 40000,
        originalSpecies = Gengar,
        destinationSpecies = GengarMega,
        graphicsPath = "gengarite",
    };

    public static readonly MegaStone Kangaskhanite = new()
    {
        itemName = "Kangaskhanite",
        price = 40000,
        originalSpecies = Kangaskhan,
        destinationSpecies = KangaskhanMega,
        graphicsPath = "kangaskhanite",
    };

    public static readonly MegaStone Pinsirite = new()
    {
        itemName = "Pinsirite",
        price = 40000,
        originalSpecies = Pinsir,
        destinationSpecies = PinsirMega,
        graphicsPath = "pinsirite",
    };

    public static readonly MegaStone Gyaradosite = new()
    {
        itemName = "Gyaradosite",
        price = 40000,
        originalSpecies = Gyarados,
        destinationSpecies = GyaradosMega,
        graphicsPath = "gyaradosite"
    };

    public static readonly MegaStone Aerodactylite = new()
    {
        itemName = "Aerodactylite",
        price = 40000,
        originalSpecies = Aerodactyl,
        destinationSpecies = AerodactylMega,
        graphicsPath = "aerodactylite",
    };

    public static readonly MegaStone MewtwoniteX = new()
    {
        itemName = "Mewtwonite X",
        price = 40000,
        originalSpecies = Mewtwo,
        destinationSpecies = MewtwoMegaX,
        graphicsPath = "mewtwonite_x"
    };

    public static readonly MegaStone MewtwoniteY = new()
    {
        itemName = "Mewtwonite Y",
        price = 40000,
        originalSpecies = Mewtwo,
        destinationSpecies = MewtwoMegaY,
        graphicsPath = "mewtwonite_y"
    };

    public static readonly MegaStone Ampharosite = new()
    {
        itemName = "Ampharosite",
        price = 40000,
        originalSpecies = Ampharos,
        destinationSpecies = AmpharosMega,
        graphicsPath = "ampharosite",
    };

    public static readonly MegaStone Steelixite = new()
    {
        itemName = "Steelixite",
        price = 40000,
        originalSpecies = Steelix,
        destinationSpecies = SteelixMega,
        graphicsPath = "steelixite",
    };

    public static readonly MegaStone Scizorite = new()
    {
        itemName = "Scizorite",
        price = 40000,
        originalSpecies = Scizor,
        destinationSpecies = ScizorMega,
        graphicsPath = "scizorite",
    };

    public static readonly MegaStone Heracronite = new()
    {
        itemName = "Heracronite",
        price = 40000,
        originalSpecies = Heracross,
        destinationSpecies = HeracrossMega,
        graphicsPath = "heracronite",
    };

    public static readonly MegaStone Houndoominite = new()
    {
        itemName = "Houndoominite",
        price = 40000,
        originalSpecies = Houndoom,
        destinationSpecies = HoundoomMega,
        graphicsPath = "houndoominite",
    };

    public static readonly MegaStone Tyranitarite = new()
    {
        itemName = "Tyranitarite",
        price = 40000,
        originalSpecies = Tyranitar,
        destinationSpecies = TyranitarMega,
        graphicsPath = "tyranitarite",
    };

    public static readonly MegaStone Sceptilite = new()
    {
        itemName = "Sceptilite",
        price = 40000,
        originalSpecies = Sceptile,
        destinationSpecies = SceptileMega,
        graphicsPath = "sceptilite"
    };

    public static readonly MegaStone Blazikenite = new()
    {
        itemName = "Blazikenite",
        price = 40000,
        originalSpecies = Blaziken,
        destinationSpecies = BlazikenMega,
        graphicsPath = "blazikenite"
    };

    public static readonly MegaStone Swampertite = new()
    {
        itemName = "Swampertite",
        price = 40000,
        originalSpecies = Swampert,
        destinationSpecies = SwampertMega,
        graphicsPath = "swampertite"
    };

    public static readonly MegaStone Gardevoirite = new()
    {
        itemName = "Gardevoirite",
        price = 40000,
        originalSpecies = Gardevoir,
        destinationSpecies = GardevoirMega,
        graphicsPath = "gardevoirite"
    };

    public static readonly MegaStone Sablenite = new()
    {
        itemName = "Sablenite",
        price = 40000,
        originalSpecies = Sableye,
        destinationSpecies = SableyeMega,
        graphicsPath = "sablenite"
    };

    public static readonly MegaStone Mawilite = new()
    {
        itemName = "Mawilite",
        price = 40000,
        originalSpecies = Mawile,
        destinationSpecies = MawileMega,
        graphicsPath = "mawilite"
    };

    public static readonly MegaStone Aggronite = new()
    {
        itemName = "Aggronite",
        price = 40000,
        originalSpecies = Aggron,
        destinationSpecies = AggronMega,
        graphicsPath = "aggron"
    };

    public static readonly MegaStone Medichamite = new()
    {
        itemName = "Medichamite",
        price = 40000,
        originalSpecies = Medicham,
        destinationSpecies = MedichamMega,
        graphicsPath = "medichamite"
    };

    public static readonly MegaStone Manectrite = new()
    {
        itemName = "Manectite",
        price = 40000,
        originalSpecies = Manectric,
        destinationSpecies = ManectricMega,
        graphicsPath = "manectite"
    };

    public static readonly MegaStone Sharpedonite = new()
    {
        itemName = "Sharpedonite",
        price = 40000,
        originalSpecies = Sharpedo,
        destinationSpecies = SharpedoMega,
        graphicsPath = "sharpedonite"
    };

    public static readonly MegaStone Cameruptite = new()
    {
        itemName = "Cameruptite",
        price = 40000,
        originalSpecies = Camerupt,
        destinationSpecies = CameruptMega,
        graphicsPath = "cameruptite"
    };

    public static readonly MegaStone Altarianite = new()
    {
        itemName = "Altarianite",
        price = 40000,
        originalSpecies = Altaria,
        destinationSpecies = AltariaMega,
        graphicsPath = "altarianite"
    };

    public static readonly MegaStone Banettite = new()
    {
        itemName = "Banettite",
        price = 40000,
        originalSpecies = Banette,
        destinationSpecies = BanetteMega,
        graphicsPath = "banettite"
    };

    public static readonly MegaStone Absolite = new()
    {
        itemName = "Absolite",
        price = 40000,
        originalSpecies = Absol,
        destinationSpecies = AbsolMega,
        graphicsPath = "absolite"
    };

    public static readonly MegaStone Glalitite = new()
    {
        itemName = "Glalitite",
        price = 40000,
        originalSpecies = Glalie,
        destinationSpecies = GlalieMega,
        graphicsPath = "glalitite"
    };

    public static readonly MegaStone Salamencite = new()
    {
        itemName = "Salamencite",
        price = 40000,
        originalSpecies = Salamence,
        destinationSpecies = SalamenceMega,
        graphicsPath = "salamencite"
    };

    public static readonly MegaStone Metagrossite = new()
    {
        itemName = "Metagrossite",
        price = 40000,
        originalSpecies = Metagross,
        destinationSpecies = MetagrossMega,
        graphicsPath = "metagrossite"
    };

    public static readonly MegaStone Latiasite = new()
    {
        itemName = "Latiasite",
        price = 40000,
        originalSpecies = Latias,
        destinationSpecies = LatiasMega,
        graphicsPath = "latiasite"
    };

    public static readonly MegaStone Latiosite = new()
    {
        itemName = "Latiosite",
        price = 40000,
        originalSpecies = Latios,
        destinationSpecies = LatiosMega,
        graphicsPath = "latiosite"
    };

    public static readonly MegaStone Lopunnite = new()
    {
        itemName = "Lopunnite",
        price = 40000,
        originalSpecies = Lopunny,
        destinationSpecies = LopunnyMega,
        graphicsPath = "lopunnite"
    };

    public static readonly MegaStone Garchompite = new()
    {
        itemName = "Garchompite",
        price = 40000,
        originalSpecies = Garchomp,
        destinationSpecies = GarchompMega,
        graphicsPath = "garchompite"
    };

    public static readonly MegaStone Lucarionite = new()
    {
        itemName = "Lucarionite",
        price = 40000,
        originalSpecies = Lucario,
        destinationSpecies = LucarioMega,
        graphicsPath = "lucarionite"
    };

    public static readonly MegaStone Abomasite = new()
    {
        itemName = "Abomasite",
        price = 40000,
        originalSpecies = Abomasnow,
        destinationSpecies = AbomasnowMega,
        graphicsPath = "abomasite"
    };

    public static readonly MegaStone Galladite = new()
    {
        itemName = "Galladite",
        price = 40000,
        originalSpecies = Gallade,
        destinationSpecies = GalladeMega,
        graphicsPath = "galladite"
    };

    public static readonly MegaStone Audinite = new()
    {
        itemName = "Audinite",
        price = 40000,
        originalSpecies = Audino,
        destinationSpecies = AudinoMega,
        graphicsPath = "audinite"
    };

    public static readonly MegaStone Diancite = new()
    {
        itemName = "Diancite",
        price = 40000,
        originalSpecies = Diancie,
        destinationSpecies = DiancieMega,
        graphicsPath = "diancite"
    };

    public static readonly ZCrystalGeneric NormaliumZ = new()
    {
        itemName = "Normalium Z",
        price = 100000,
        moveType = Type.Normal,
        zMovePhysical = MoveID.BreakneckBlitzPhysical,
        zMoveSpecial = MoveID.BreakneckBlitzSpecial,
        graphicsPath = "normalium_z"
    };

    public static readonly ZCrystalGeneric FightiniumZ = new()
    {
        itemName = "Fightinium Z",
        price = 100000,
        moveType = Type.Fighting,
        zMovePhysical = MoveID.AllOutPummelingPhysical,
        zMoveSpecial = MoveID.AllOutPummelingSpecial,
        graphicsPath = "fightinium_z"
    };

    public static readonly ZCrystalGeneric FlyiniumZ = new()
    {
        itemName = "Flyinium Z",
        price = 100000,
        moveType = Type.Flying,
        zMovePhysical = MoveID.SupersonicSkystrikePhysical,
        zMoveSpecial = MoveID.SupersonicSkystrikeSpecial,
        graphicsPath = "flyinium_z"
    };

    public static readonly ZCrystalGeneric PoisoniumZ = new()
    {
        itemName = "Poisonium Z",
        price = 100000,
        moveType = Type.Poison,
        zMovePhysical = MoveID.AcidDownpourPhysical,
        zMoveSpecial = MoveID.AcidDownpourSpecial,
        graphicsPath = "poisonium_z"
    };

    public static readonly ZCrystalGeneric GroundiumZ = new()
    {
        itemName = "Groundium Z",
        price = 100000,
        moveType = Type.Ground,
        zMovePhysical = MoveID.TectonicRagePhysical,
        zMoveSpecial = MoveID.TectonicRageSpecial,
        graphicsPath = "groundium_z"
    };

    public static readonly ZCrystalGeneric RockiumZ = new()
    {
        itemName = "Rockium Z",
        price = 100000,
        moveType = Type.Rock,
        zMovePhysical = MoveID.ContinentalCrushPhysical,
        zMoveSpecial = MoveID.ContinentalCrushSpecial,
        graphicsPath = "rockium_z"
    };

    public static readonly ZCrystalGeneric BuginiumZ = new()
    {
        itemName = "Buginium Z",
        price = 100000,
        moveType = Type.Bug,
        zMovePhysical = MoveID.SavageSpinOutPhysical,
        zMoveSpecial = MoveID.SavageSpinOutSpecial,
        graphicsPath = "buginium_z"
    };
    public static readonly ZCrystalGeneric GhostiumZ = new()
    {
        itemName = "Ghostium Z",
        price = 100000,
        moveType = Type.Ghost,
        zMovePhysical = MoveID.NeverEndingNightmarePhysical,
        zMoveSpecial = MoveID.NeverEndingNightmareSpecial,
        graphicsPath = "ghostium_z"
    };
    public static readonly ZCrystalGeneric SteeliumZ = new()
    {
        itemName = "Steelium Z",
        price = 100000,
        moveType = Type.Steel,
        zMovePhysical = MoveID.CorkscrewCrashPhysical,
        zMoveSpecial = MoveID.CorkscrewCrashSpecial,
        graphicsPath = "steelium_z"
    };
    public static readonly ZCrystalGeneric FiriumZ = new()
    {
        itemName = "Firium Z",
        price = 100000,
        moveType = Type.Fire,
        zMovePhysical = MoveID.InfernoOverdrivePhysical,
        zMoveSpecial = MoveID.InfernoOverdriveSpecial,
        graphicsPath = "firium_z"
    };
    public static readonly ZCrystalGeneric WateriumZ = new()
    {
        itemName = "Waterium Z",
        price = 100000,
        moveType = Type.Water,
        zMovePhysical = MoveID.HydroVortexPhysical,
        zMoveSpecial = MoveID.HydroVortexSpecial,
        graphicsPath = "waterium_z"
    };
    public static readonly ZCrystalGeneric GrassiumZ = new()
    {
        itemName = "Grassium Z",
        price = 100000,
        moveType = Type.Grass,
        zMovePhysical = MoveID.BloomDoomPhysical,
        zMoveSpecial = MoveID.BloomDoomSpecial,
        graphicsPath = "grassium_z"
    };
    public static readonly ZCrystalGeneric ElectriumZ = new()
    {
        itemName = "Electrium Z",
        price = 100000,
        moveType = Type.Electric,
        zMovePhysical = MoveID.GigavoltHavocPhysical,
        zMoveSpecial = MoveID.GigavoltHavocSpecial,
        graphicsPath = "electrium_z"
    };
    public static readonly ZCrystalGeneric PsychiumZ = new()
    {
        itemName = "Psychium Z",
        price = 100000,
        moveType = Type.Psychic,
        zMovePhysical = MoveID.ShatteredPsychePhysical,
        zMoveSpecial = MoveID.ShatteredPsycheSpecial,
        graphicsPath = "psychium_z"
    };
    public static readonly ZCrystalGeneric IciumZ = new()
    {
        itemName = "Icium Z",
        price = 100000,
        moveType = Type.Ice,
        zMovePhysical = MoveID.SubzeroSlammerPhysical,
        zMoveSpecial = MoveID.SubzeroSlammerSpecial,
        graphicsPath = "icium_z"
    };
    public static readonly ZCrystalGeneric DragoniumZ = new()
    {
        itemName = "Dragonium Z",
        price = 100000,
        moveType = Type.Dragon,
        zMovePhysical = MoveID.DevastatingDrakePhysical,
        zMoveSpecial = MoveID.DevastatingDrakeSpecial,
        graphicsPath = "dragonium_z"
    };
    public static readonly ZCrystalGeneric DarkiniumZ = new()
    {
        itemName = "Darkinium Z",
        price = 100000,
        moveType = Type.Dark,
        zMovePhysical = MoveID.BlackHoleEclipsePhysical,
        zMoveSpecial = MoveID.BlackHoleEclipseSpecial,
        graphicsPath = "darkinium_z"
    };
    public static readonly ZCrystalGeneric FairiumZ = new()
    {
        itemName = "Fairium Z",
        price = 100000,
        moveType = Type.Fairy,
        zMovePhysical = MoveID.TwinkleTacklePhysical,
        zMoveSpecial = MoveID.TwinkleTackleSpecial,
        graphicsPath = "fairium_z"
    };

    public static readonly ZCrystalMultipleSpecies PikaniumZ = new()
    {
        itemName = "Pikanium Z",
        price = 200000,
        users = new[]
        {
            Pikachu,
            PikachuCosplay,
            PikachuRockStar,
            PikachuBelle,
            PikachuPopStar,
            PikachuPhD,
            PikachuLibre,
            PikachuOriginal,
            PikachuHoenn,
            PikachuSinnoh,
            PikachuUnova,
            PikachuKalos,
            PikachuAlolaCap,
            PikachuPartnerCap,
            PikachuWorld,
            PikachuPartner,
        },
        baseMove = MoveID.VoltTackle,
        zMove = MoveID.Catastropika,
        graphicsPath = "pikanium_z"
    };
    public static readonly ZCrystalSpecific DecidiumZ = new()
    {
        itemName = "Decidium Z",
        price = 200000,
        user = Decidueye,
        baseMove = MoveID.SpiritShackle,
        zMove = MoveID.SinisterArrowRaid,
        graphicsPath = "decidium_z"
    };
    public static readonly ZCrystalSpecific InciniumZ = new()
    {
        itemName = "Incinium Z",
        price = 200000,
        user = Incineroar,
        baseMove = MoveID.DarkestLariat,
        zMove = MoveID.MaliciousMoonsault,
        graphicsPath = "incinium_z"
    };
    public static readonly ZCrystalSpecific PrimariumZ = new()
    {
        itemName = "Primarium Z",
        price = 200000,
        user = Primarina,
        baseMove = MoveID.SparklingAria,
        zMove = MoveID.OceanicOperetta,
        graphicsPath = "primarium_z"
    };
    public static readonly ZCrystalMultipleSpecies TapuniumZ = new()
    {
        itemName = "Tapunium Z",
        price = 200000,
        baseMove = MoveID.NaturesMadness,
        zMove = MoveID.GuardianOfAlola,
        users = new[]
        {
            TapuKoko,
            TapuLele,
            TapuBulu,
            TapuFini
        },
        graphicsPath = "tapunium_z"
    };
    public static readonly ZCrystalSpecific MarshadiumZ = new()
    {
        itemName = "Marshadium Z",
        price = 200000,
        user = Marshadow,
        baseMove = MoveID.SpectralThief,
        zMove = MoveID.SoulStealingSevenStarStrike,
        graphicsPath = "marshadium_z"
    };
    public static readonly ZCrystalSpecific AloraichiumZ = new()
    {
        itemName = "Aloraichium Z",
        price = 200000,
        user = RaichuAlola,
        baseMove = MoveID.Thunderbolt,
        zMove = MoveID.StokedSparksurfer,
        graphicsPath = "aloraichium_z"
    };
    public static readonly ZCrystalSpecific SnorliumZ = new()
    {
        itemName = "Snorlium Z",
        price = 200000,
        user = Snorlax,
        baseMove = MoveID.GigaImpact,
        zMove = MoveID.PulverizingPancake,
        graphicsPath = "snorlium_z"
    };
    public static readonly ZCrystalMultipleSpecies EeviumZ = new()
    {
        itemName = "Eevium Z",
        price = 200000,
        users = new[]
        {
            Eevee,
            EeveePartner
        },
        baseMove = MoveID.LastResort,
        zMove = MoveID.ExtremeEvoboost,
        graphicsPath = "eevium_z"
    };
    public static readonly ZCrystalSpecific MewniumZ = new()
    {
        itemName = "Mewnium Z",
        price = 200000,
        user = Mew,
        baseMove = MoveID.Psychic,
        zMove = MoveID.GenesisSupernova,
        graphicsPath = "mewnium_z"
    };
    public static readonly ZCrystalMultipleSpecies PikashuniumZ = new()
    {
        itemName = "Pikashunium Z",
        price = 200000,
        baseMove = MoveID.Thunderbolt,
        zMove = MoveID.TenMillionVoltThunderbolt,
        users = new[]
        {
            PikachuOriginal,
            PikachuHoenn,
            PikachuSinnoh,
            PikachuUnova,
            PikachuKalos,
            PikachuAlolaCap,
            PikachuPartnerCap,
            PikachuWorld
        },
        graphicsPath = "pikashunium_z"
    };
    public static readonly ZCrystalSpecific UltranecrozmiumZ = new()
    {
        itemName = "Ultranecrozmium Z",
        price = 200000,
        user = NecrozmaUltra,
        baseMove = MoveID.PhotonGeyser,
        zMove = MoveID.LightThatBurnsTheSky,
        graphicsPath = "ultranecrozmium_z"
    };
    public static readonly ZCrystalMultipleSpecies SolganiumZ = new()
    {
        itemName = "Solganium Z",
        price = 200000,
        baseMove = MoveID.SunsteelStrike,
        zMove = MoveID.SearingSunrazeSmash,
        users = new[]
        {
            Solgaleo,
            NecrozmaDuskMane
        },
        graphicsPath = "solganium_z"
    };
    public static readonly ZCrystalMultipleSpecies LunaliumZ = new()
    {
        itemName = "Lunalium Z",
        price = 200000,
        baseMove = MoveID.MoongeistBeam,
        zMove = MoveID.MenacingMoonrazeMaelstrom,
        users = new[]
        {
            Lunala,
            NecrozmaDawnWings
        },
        graphicsPath = "lunalium_z"
    };
    public static readonly ZCrystalMultipleSpecies MimikiumZ = new()
    {
        itemName = "Mimikium Z",
        price = 200000,
        users = new[]
        {
            MimikyuBase,
            MimikyuBusted
        },
        baseMove = MoveID.PlayRough,
        zMove = MoveID.LetsSnuggleForever,
        graphicsPath = "mimikium_z"
    };
    public static readonly ZCrystalMultipleSpecies LycaniumZ = new()
    {
        itemName = "Lycanium Z",
        price = 200000,
        users = new[]
        {
            Lycanroc,
            LycanrocDusk,
            LycanrocMidnight
        },
        baseMove = MoveID.StoneEdge,
        zMove = MoveID.SplinteredStormshards,
        graphicsPath = "lycanium_z"
    };
    public static readonly ZCrystalSpecific KommoniumZ = new()
    {
        itemName = "Kommonium Z",
        price = 200000,
        user = KommoO,
        baseMove = MoveID.ClangingScales,
        zMove = MoveID.ClangorousSoulblaze,
        graphicsPath = "kommonium_z"
    };

    public static readonly HoldToTransform AdamantCrystal = new()
    {
        itemName = "Adamant Crystal",
        price = 1000000,
        baseSpecies = Dialga,
        transformedSpecies = DialgaOrigin,
        graphicsPath = "adamant_crystal"
    };
    public static readonly HoldToTransform LustrousGlobe = new()
    {
        itemName = "Lustrous Globe",
        price = 1000000,
        baseSpecies = Palkia,
        transformedSpecies = PalkiaOrigin,
        graphicsPath = "lustrous_globe"
    };
    public static readonly HoldToTransform GriseousOrb = new()
    {
        itemName = "Griseous Orb",
        price = 1000000,
        baseSpecies = Giratina,
        transformedSpecies = GiratinaOrigin,
        graphicsPath = "griseous_orb"
    };
    public static readonly HoldToTransform FightingMemory = new()
    {
        itemName = "Fighting Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyFighting,
        graphicsPath = "fighting_memory"
    };
    public static readonly HoldToTransform FlyingMemory = new()
    {
        itemName = "Flying Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyFlying,
        graphicsPath = "flying_memory"
    };
    public static readonly HoldToTransform PoisonMemory = new()
    {
        itemName = "Poison Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyPoison,
        graphicsPath = "poison_memory"
    };
    public static readonly HoldToTransform GroundMemory = new()
    {
        itemName = "Ground Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyGround,
        graphicsPath = "ground_memory"
    };
    public static readonly HoldToTransform RockMemory = new()
    {
        itemName = "Rock Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyRock,
        graphicsPath = "rock_memory"
    };
    public static readonly HoldToTransform BugMemory = new()
    {
        itemName = "Bug Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyBug,
        graphicsPath = "bug_memory"
    };
    public static readonly HoldToTransform GhostMemory = new()
    {
        itemName = "Ghost Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyGhost,
        graphicsPath = "ghost_memory"
    };
    public static readonly HoldToTransform SteelMemory = new()
    {
        itemName = "Steel Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallySteel,
        graphicsPath = "steel_memory"
    };
    public static readonly HoldToTransform FireMemory = new()
    {
        itemName = "Fire Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyFire,
        graphicsPath = "fire_memory"
    };
    public static readonly HoldToTransform WaterMemory = new()
    {
        itemName = "Water Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyWater,
        graphicsPath = "water_memory"
    };
    public static readonly HoldToTransform GrassMemory = new()
    {
        itemName = "Grass Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyGrass,
        graphicsPath = "grass_memory"
    };
    public static readonly HoldToTransform ElectricMemory = new()
    {
        itemName = "Electric Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyElectric,
        graphicsPath = "electric_memory"
    };
    public static readonly HoldToTransform PsychicMemory = new()
    {
        itemName = "Psychic Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyPsychic,
        graphicsPath = "psychic_memory"
    };
    public static readonly HoldToTransform IceMemory = new()
    {
        itemName = "Ice Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyIce,
        graphicsPath = "ice_memory"
    };
    public static readonly HoldToTransform DragonMemory = new()
    {
        itemName = "Dragon Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyDragon,
        graphicsPath = "dragon_memory"
    };
    public static readonly HoldToTransform DarkMemory = new()
    {
        itemName = "Dark Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyDark,
        graphicsPath = "dark_memory"
    };
    public static readonly HoldToTransform FairyMemory = new()
    {
        itemName = "Fairy Memory",
        price = 100000,
        baseSpecies = SilvallyNormal,
        transformedSpecies = SilvallyFairy,
        graphicsPath = "fairy_memory"
    };


    public static readonly ItemData[] ItemTable = new ItemData[(int)ItemID.Count]
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
        //Medicine
        Potion,
        SuperPotion,
        HyperPotion,
        MaxPotion,
        Antidote,
        ParalyzeHeal,
        Awakening,
        BurnHeal,
        IceHeal,
        FullHeal,
        FullRestore,
        BerryJuice,
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
        TartApple,
        SweetApple,
        CrackedPot,
        ChippedPot,
        ScrollOfDarkness,
        ScrollOfWaters,
        GalaricaCuff,
        GalaricaWreath,
        //Mints
        LonelyMint,
        AdamantMint,
        NaughtyMint,
        BraveMint,
        BoldMint,
        ImpishMint,
        LaxMint,
        RelaxedMint,
        ModestMint,
        MildMint,
        RashMint,
        QuietMint,
        CalmMint,
        GentleMint,
        CarefulMint,
        SassyMint,
        TimidMint,
        HastyMint,
        JollyMint,
        NaiveMint,
        SeriousMint,
        //Feathers and vitamins
        HealthFeather,
        MuscleFeather,
        ResistFeather,
        GeniusFeather,
        CleverFeather,
        SwiftFeather,
        HPUp,
        Protein,
        Iron,
        Calcium,
        Zinc,
        Carbos,
        PPUp,
        PPMax,
        //Other field items
        Honey,
        AbilityCapsule,
        AbilityPatch,
        Repel,
        SuperRepel,
        MaxRepel,
        //Held items
        KingsRock,
        DeepSeaTooth,
        DeepSeaScale,
        RazorClaw,
        RazorFang,
        UtilityUmbrella,
        ChoiceBand,
        ChoiceSpecs,
        ChoiceScarf,
        Leftovers,
        ToxicOrb,
        FlameOrb,
        AbsorbBulb,
        LuminousMoss,
        CellBattery,
        Snowball,
        WeaknessPolicy,
        AbilityShield,
        AdrenalineOrb,
        AirBalloon,
        AssaultVest,
        ClearAmulet,
        BindingBand,
        BrightPowder,
        DampRock,
        HeatRock,
        IcyRock,
        SmoothRock,
        //Gems
        NormalGem,
        FireGem,
        WaterGem,
        GrassGem,
        ElectricGem,
        IceGem,
        GroundGem,
        FightingGem,
        FlyingGem,
        RockGem,
        PoisonGem,
        BugGem,
        PsychicGem,
        GhostGem,
        DragonGem,
        DarkGem,
        SteelGem,
        FairyGem,
        //Type boosting items
        SilkScarf,
        Charcoal,
        MysticWater,
        MiracleSeed,
        Magnet,
        NeverMeltIce,
        SoftSand,
        BlackBelt,
        SharpBeak,
        HardStone,
        PoisonBarb,
        SilverPowder,
        TwistedSpoon,
        SpellTag,
        DragonFang,
        BlackGlasses,
        MetalCoat,
        FairyFeather,
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
        Satchet,
        WhippedDream,
        BoosterEnergy,
        //Poké balls
        PokeBall,
        GreatBall,
        UltraBall,
        MasterBall,
        //Hold-to-transform items
            //Orbs
        AdamantCrystal,
        LustrousGlobe,
        GriseousOrb,
            //Memories
        FightingMemory,
        FlyingMemory,
        PoisonMemory,
        GroundMemory,
        RockMemory,
        BugMemory,
        GhostMemory,
        SteelMemory,
        FireMemory,
        WaterMemory,
        GrassMemory,
        ElectricMemory,
        PsychicMemory,
        IceMemory,
        DragonMemory,
        DarkMemory,
        FairyMemory,
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
        Audinite,
        Diancite,
        //Z-Crystals
        NormaliumZ,
        FightiniumZ,
        FlyiniumZ,
        PoisoniumZ,
        GroundiumZ,
        RockiumZ,
        BuginiumZ,
        GhostiumZ,
        SteeliumZ,
        FiriumZ,
        WateriumZ,
        GrassiumZ,
        ElectriumZ,
        PsychiumZ,
        IciumZ,
        DragoniumZ,
        DarkiniumZ,
        FairiumZ,
        PikaniumZ,
        DecidiumZ,
        InciniumZ,
        PrimariumZ,
        TapuniumZ,
        MarshadiumZ,
        AloraichiumZ,
        SnorliumZ,
        MewniumZ,
        PikashuniumZ,
        UltranecrozmiumZ,
        SolganiumZ,
        LunaliumZ,
        MimikiumZ,
        LycaniumZ,
        KommoniumZ,
    };
}

