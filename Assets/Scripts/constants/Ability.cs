using static Ability;
public enum Ability
{
    None,
    Stench,
    Drizzle,
    SpeedBoost,
    BattleArmor,
    Sturdy,
    Damp,
    Limber,
    SandVeil,
    Static,
    VoltAbsorb,
    WaterAbsorb,
    Oblivious,
    CloudNine,
    CompoundEyes,
    Insomnia,
    ColorChange, //Not done
    Immunity,
    FlashFire,
    ShieldDust,
    OwnTempo,
    SuctionCups,
    Intimidate,
    ShadowTag,
    RoughSkin,
    WonderGuard,
    Levitate,
    EffectSpore, //Not done
    Synchronize, //Not done
    ClearBody,
    NaturalCure,
    LightningRod, //Not done
    SereneGrace,
    SwiftSwim,
    Chlorophyll,
    Illuminate,
    Trace,
    HugePower,
    PoisonPoint,
    InnerFocus,
    MagmaArmor,
    WaterVeil,
    MagnetPull,
    Soundproof,
    RainDish,
    SandStream,
    Pressure,
    ThickFat,
    EarlyBird,
    FlameBody,
    RunAway,
    KeenEye,
    HyperCutter,
    Pickup, //Not done
    Truant, //Not done
    Hustle,
    CuteCharm, //Not done
    Plus, //Not done
    Minus, //Not done
    Forecast,
    StickyHold,
    ShedSkin, //Not done
    Guts,
    MarvelScale, //Not done
    LiquidOoze,
    Overgrow,
    Blaze,
    Torrent,
    Swarm,
    RockHead,
    Drought,
    ArenaTrap,
    VitalSpirit,
    WhiteSmoke,
    PurePower,
    ShellArmor,
    AirLock,
    TangledFeet, //Not done
    MotorDrive, //Not done
    Rivalry, //Not done
    Steadfast,
    SnowCloak,
    Gluttony,
    AngerPoint, //Not done
    Unburden, //Not done
    Heatproof,
    Simple,
    DrySkin,
    Download, //Not done
    IronFist,
    PoisonHeal,
    Adaptability,
    SkillLink,
    Hydration, //Not done
    SolarPower,
    QuickFeet, //Not done
    Normalize,
    Sniper,
    MagicGuard, //Will always need updating
    NoGuard,
    Stall,
    Technician,
    LeafGuard, //Not done
    Klutz,
    MoldBreaker, //Will always need updating
    SuperLuck,
    Aftermath, //Not done
    Anticipation, //Not done
    Forewarn, //Not done
    Unaware,
    TintedLens,
    Filter,
    SlowStart, //Not done
    Scrappy,
    StormDrain, //Not done
    IceBody,
    SolidRock,
    SnowWarning,
    HoneyGather, //Not done
    Frisk,
    Reckless,
    Multitype, //Not done
    FlowerGift, //Not done
    BadDreams, //Not done
    Pickpocket, //Not done
    SheerForce, //Not done
    Contrary,
    Unnerve, //Not done
    Defiant,
    Defeatist,
    CursedBody, //Not done
    Healer, //Not done
    FriendGuard, //Not done
    WeakArmor,
    HeavyMetal,
    LightMetal,
    Multiscale,
    ToxicBoost,
    FlareBoost,
    Harvest, //Not done
    Telepathy, //Not done
    Moody, //Not done
    Overcoat,
    PoisonTouch, //Not done
    Regenerator,
    BigPecks,
    SandRush,
    WonderSkin,
    Analytic, //Still doesn't handle fainting mons in multi battles correctly
    Illusion, //Not done
    Imposter, //Not done
    Infiltrator,
    Mummy,
    Moxie,
    Justified,
    Rattled,
    MagicBounce,
    SapSipper,
    Prankster,
    SandForce,
    IronBarbs,
    ZenMode, //Not done
    VictoryStar,
    Turboblaze, //Tied to Mold Breaker
    Teravolt, //Tied to Mold Breaker
    AromaVeil, //Not done
    FlowerVeil, //Not done
    CheekPouch, //Not done
    Protean,
    FurCoat,
    Magician, //Not done
    Bulletproof,
    Competitive,
    StrongJaw,
    Refrigerate,
    SweetVeil, //Not done
    StanceChange, //Not done
    GaleWings,
    MegaLauncher,
    GrassPelt, //Shouldn't be checked when dealing confusion damage (??)
    Symbiosis, //Not done
    ToughClaws,
    Pixilate,
    Gooey,
    Aerilate,
    ParentalBond,
    DarkAura,
    FairyAura,
    AuraBreak,
    PrimoridialSea, //Not done
    DesolateLand, //Not done
    DeltaStream, //Not done
    Stamina,
    WimpOut, //Not done
    EmergencyExit, //Not done
    WaterCompaction, //Not done
    Merciless,
    ShieldsDown, //Not done
    Stakeout, //Not done
    WaterBubble, //Not done
    Steelworker, //Not done
    Berserk, //Not done
    SlushRush,
    LongReach,
    LiquidVoice,
    Triage,
    Galvanize,
    SurgeSurfer, //Not done
    Schooling, //Not done
    Disguise, //Not done
    BattleBond, //Not done
    PowerConstruct, //Not done
    Corrosion, //Not done
    Comatose, //Not done
    QueenlyMajesty,
    InnardsOut, //Not done
    Dancer, //Not done
    Battery, //Not done
    Fluffy,
    Dazzling,
    SoulHeart, //Not done
    TanglingHair, //Not done
    Receiver, //Not done
    PowerOfAlchemy, //Not done
    BeastBoost, //Not done
    RKSSystem, //Not done
    ElectricSurge, //Not done
    PsychicSurge, //Not done
    MistySurge, //Not done
    GrassySurge, //Not done
    FullMetalBody, //Not done
    ShadowShield,
    PrismArmor,
    Neuroforce, //Not done
    IntrepidSword, //Not done
    DauntlessShield, //Not done
    Libero,
    BallFetch, //Not done
    CottonDown, //Not done
    PropellorTail, //Not done
    MirrorArmor, //Not done
    GulpMissile, //Not done
    Stalwart, //Not done
    SteamEngine,
    PunkRock,
    SandSpit, //Not done
    IceScales,
    Ripen, //Not done
    IceFace, //Not done
    PowerSpot, //Not done
    Mimicry, //Not done
    ScreenCleaner, //Not done
    SteelySpirit, //Not done
    PerishBody, //Not done
    WanderingSpirit, //Not done
    GorillaTactics, //Not done
    NeutralizingGas, //Not done
    PastelVeil, //Not done
    HungerSwitch, //Not done
    QuickDraw, //Not done
    UnseenFist, //Not done
    CuriousMedicine, //Not done
    Transistor, //Not done
    DragonsMaw, //Not done
    ChillingNeigh, //Not done
    GrimNeigh, //Not done
    AsOneGlastrier, //Not done
    AsOneSpectrier, //Not done
    LingeringAroma, //Not done
    SeedSower, //Not done
    ThermalExchange, //Not done
    AngerShell, //Not done
    PurifyingSalt, //Not done
    WellBakedBody, //Not done
    WindRider, //Not done
    GuardDog, //Not done
    RockyPayload, //Not done
    WindPower, //Not done
    ZeroToHero, //Not done
    Commander, //Not done
    Electromorphosis, //Not done
    Protosynthesis, //Not done
    QuarkDrive, //Not done
    GoodAsGold, //Not done
    VesselOfRuin, //Not done
    SwordOfRuin, //Not done
    TabletsOfRuin, //Not done
    BeadsOfRuin, //Not done
    OrichalcumPulse, //Not done
    HadronEngine, //Not done
    Opportunist, //Not done
    CudChew, //Not done
    Sharpness,
    SupremeOverlord,
    Costar, //Not done
    ToxicDebris,
    ArmorTail,
    EarthEater,
    MyceliumMight,
    Hospitality, //Not done
    MindsEye,
    EmbodyTeal,
    EmbodyFire,
    EmbodyWater,
    EmbodyRock,
    ToxicChain, //Not done
    SupersweetSyrup, //Not done


    Count

}

public static class AbilityUtils
{
    public static string Name(this Ability ability)
        => NameTable.Ability[(int)ability];
    public static bool Unchangeable(this Ability ability)
        => ability is AsOneGlastrier or AsOneSpectrier or BattleBond
        or Comatose or Commander or Disguise or GulpMissile or IceFace
        or Multitype or Protosynthesis or QuarkDrive or RKSSystem
        or Schooling or ShieldsDown or StanceChange or WonderGuard
        or ZenMode or ZeroToHero;
    public static string Description(this Ability ability) => ability switch
    {
        Stench => "By releasing a stench when attacking, the Pokémon may cause the target to flinch.",
        Drizzle => "The Pokémon makes it rain when it enters a battle.",
        SpeedBoost => "The Pokémon's Speed stat is boosted every turn.",
        BattleArmor => "Hard armor protects the Pokémon from critical hits.",
        Sturdy => "The Pokémon cannot be knocked out by a single hit as long as its HP is full. One-hit KO moves will also fail to knock it out.",
        Damp => "The Pokémon dampens its surroundings, preventing all Pokémon from using explosive moves such as Self-Destruct.",
        Limber => "The Pokémon's limber body prevents it from being paralyzed.",
        SandVeil => "Boosts the Pokémon's evasiveness in a sandstorm.",
        Static => "The Pokémon is charged with static electricity and may paralyze attackers that make direct contact with it.",
        VoltAbsorb => "If hit by an Electric-type move, the Pokémon has its HP restored instead of taking damage.",
        WaterAbsorb => "If hit by a Water-type move, the Pokémon has its HP restored instead of taking damage.",
        Oblivious => "The Pokémon is oblivious, keeping it from being infatuated, falling for taunts or being affected by Intimidate.",
        CloudNine => "Eliminates the effects of weather.",
        CompoundEyes => "The Pokémon's compound eyes boost its accuracy.",
        Insomnia => "The Pokémon's insomnia prevents it from falling asleep.",
        ColorChange => "The Pokémon's type becomes the type of the move used on it.",
        Immunity => "The Pokémon's immune system prevents it from being poisoned.",
        FlashFire => "If hit by a Fire-type move, the Pokémon absorbs the flames and uses them to power up its own Fire-type moves.",
        ShieldDust => "Protective dust shields the Pokémon from the additional effects of moves.",
        OwnTempo => "The Pokémon sticks to its own tempo, preventing it from becoming confused or being affected by Intimidate.",
        SuctionCups => "The Pokémon uses suction cups to stay in one spot. This protects it from moves and items that would force it to switch out.",
        Intimidate => "When the Pokémon enters a battle, it intimidates opposing Pokémon and makes them cower, lowering their Attack stats.",
        ShadowTag => "The Pokémon steps on the opposing Pokémon's shadows to prevent them from fleeing or switching out.",
        RoughSkin => "The Pokémon's rough skin damages attackers that make direct contact with it.",
        WonderGuard => "Its mysterious power only lets supereffective moves hit the Pokémon.",
        Levitate => "By floating in the air, the Pokémon receives full immunity to all Ground-type moves.",
        EffectSpore => "Contact with the Pokémon may inflict poison, sleep, or paralysis on the attacker.",
        Synchronize => "If the Pokémon is burned, paralyzed, or poisoned by another Pokémon, that Pokémon will be inflicted with the same status condition.",
        ClearBody => "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.",
        NaturalCure => "The Pokémon's status conditions are cured when it switches out.",
        LightningRod => "The Pokémon draws in all Electric-type moves. Instead of taking damage from them, its Sp. Atk stat is boosted.",
        SereneGrace => "Raises the likelihood of additional effects occurring when the Pokémon uses its moves.",
        SwiftSwim => "Boosts the Pokémon's Speed stat in rain.",
        Chlorophyll => "Boosts the Pokémon's Speed stat in harsh sunlight.",
        Illuminate => "Raises the likelihood of meeting wild Pokémon by illuminating the surroundings.",
        Trace => "When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.",
        HugePower => "Doubles the Pokémon's Attack stat.",
        PoisonPoint => "Contact with the Pokémon may poison the attacker.",
        InnerFocus => "The Pokémon's intense focus prevents it from flinching or being affected by Intimidate.",
        MagmaArmor => "The Pokémon's hot magma coating prevents it from being frozen.",
        WaterVeil => "The Pokémon's water veil prevents it from being burned.",
        MagnetPull => "Prevents Steel-type Pokémon from fleeing by pulling them in with magnetism.",
        Soundproof => "Soundproofing gives the Pokémon full immunity to all sound-based moves.",
        RainDish => "The Pokémon gradually regains HP in rain.",
        SandStream => "The Pokémon summons a sandstorm when it enters a battle.",
        Pressure => "Puts other Pokémon under pressure, causing them to expend more PP to use their moves.",
        ThickFat => "The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.",
        EarlyBird => "The Pokémon awakens from sleep twice as fast as other Pokémon.",
        FlameBody => "Contact with the Pokémon may burn the attacker.",
        RunAway => "Enables a sure getaway from wild Pokémon.",
        KeenEye => "The Pokémon's keen eyes prevent its accuracy from being lowered.",
        HyperCutter => "The Pokémon's prized, mighty pincers prevent other Pokémon from lowering its Attack stat.",
        Pickup => "The Pokémon may pick up an item another Pokémon used during a battle. It may pick up items outside of battle, too.",
        Truant => "Each time the Pokémon uses a move, it spends the next turn loafing around.",
        Hustle => "Boosts the Pokémon's Attack stat but lowers its accuracy.",
        CuteCharm => "The Pokémon may infatuate attackers that make direct contact with it.",
        Plus => "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.",
        Minus => "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.",
        Forecast => "The Pokémon transforms with the weather to change its type to Water, Fire, or Ice.",
        StickyHold => "The Pokémon's held items cling to its sticky body and cannot be removed by other Pokémon.",
        ShedSkin => "The Pokémon may cure its own status conditions by shedding its skin.",
        Guts => "It's so gutsy that having a status condition boosts the Pokémon's Attack stat.",
        MarvelScale => "The Pokémon's marvelous scales boost its Defense stat if it has a status condition.",
        LiquidOoze => "The strong stench of the Pokémon's oozed liquid damages attackers that use HP-draining moves.",
        Overgrow => "Powers up Grass-type moves when the Pokémon's HP is low.",
        Blaze => "Powers up Fire-type moves when the Pokémon's HP is low.",
        Torrent => "Powers up Water-type moves when the Pokémon's HP is low.",
        Swarm => "Powers up Bug-type moves when the Pokémon's HP is low.",
        RockHead => "Protects the Pokémon from recoil damage.",
        Drought => "Turns the sunlight harsh when the Pokémon enters a battle.",
        ArenaTrap => "Prevents opposing Pokémon from fleeing from battle.",
        VitalSpirit => "The Pokémon is full of vitality, and that prevents it from falling asleep.",
        WhiteSmoke => "The Pokémon is protected by its white smoke, which prevents other Pokémon from lowering its stats.",
        PurePower => "Using its pure power, the Pokémon doubles its Attack stat.",
        ShellArmor => "A hard shell protects the Pokémon from critical hits.",
        AirLock => "Eliminates the effects of weather.",
        TangledFeet => "Boosts the Pokémon's evasiveness if it is confused.",
        MotorDrive => "The Pokémon takes no damage when hit by Electric-type moves. Instead, its Speed stat is boosted.",
        Rivalry => "The Pokémon's competitive spirit makes it deal more damage to Pokémon of the same gender, but less damage to Pokémon of the opposite gender.",
        Steadfast => "The Pokémon's determination boosts its Speed stat every time it flinches.",
        SnowCloak => "Boosts the Pokémon's evasiveness in snow.",
        Gluttony => "If the Pokémon is holding a Berry to be eaten when its HP is low, it will instead eat the Berry when its HP drops to half or less.",
        AngerPoint => "The Pokémon is angered when it takes a critical hit, and that maxes its Attack stat.",
        Unburden => "Boosts the Speed stat if the Pokémon's held item is used or lost.",
        Heatproof => "The Pokémon's heatproof body halves the damage taken from Fire-type moves.",
        Simple => "Doubles the effects of the Pokémon's stat changes.",
        DrySkin => "Restores the Pokémon's HP in rain or when it is hit by Water-type moves. Reduces HP in harsh sunlight, and increases the damage received from Fire-type moves.",
        Download => "The Pokémon compares an opposing Pokémon's Defense and Sp. Def stats before raising its own Attack or Sp. Atk stat—whichever will be more effective.",
        IronFist => "Powers up punching moves.",
        PoisonHeal => "If poisoned, the Pokémon has its HP restored instead of taking damage.",
        Adaptability => "Powers up moves of the same type as the Pokémon.",
        SkillLink => "Maximizes the number of times multistrike moves hit.",
        Hydration => "Cures the Pokémon's status conditions in rain.",
        SolarPower => "In harsh sunlight, the Pokémon's Sp. Atk stat is boosted, but its HP decreases every turn.",
        QuickFeet => "Boosts the Speed stat if the Pokémon has a status condition.",
        Normalize => "All the Pokémon's moves become Normal type. The power of those moves is boosted a little.",
        Sniper => "If the Pokémon's attack lands a critical hit, the attack is powered up even further.",
        MagicGuard => "The Pokémon only takes damage from attacks.",
        NoGuard => "The Pokémon employs no-guard tactics to ensure incoming and outgoing attacks always land.",
        Stall => "The Pokémon is always the last to use its moves.",
        Technician => "Powers up weak moves so the Pokémon can deal more damage with them.",
        LeafGuard => "Prevents status conditions in harsh sunlight.",
        Klutz => "The Pokémon can't use any held items.",
        MoldBreaker => "The Pokémon's moves are unimpeded by the Ability of the target.",
        SuperLuck => "The Pokémon is so lucky that the critical-hit ratios of its moves are boosted.",
        Aftermath => "Damages the attacker if it knocks out the Pokémon with a move that makes direct contact.",
        Anticipation => "The Pokémon can sense an opposing Pokémon's dangerous moves.",
        Forewarn => "When it enters a battle, the Pokémon can tell one of the moves an opposing Pokémon has.",
        Unaware => "When attacking, the Pokémon ignores the target's stat changes.",
        TintedLens => "The Pokémon can use \"not very effective\" moves to deal regular damage.",
        Filter => "Reduces the power of supereffective attacks that hit the Pokémon.",
        SlowStart => "For five turns, the Pokémon's Attack and Speed stats are halved.",
        Scrappy => "The Pokémon can hit Ghost-type Pokémon with Normal- and Fighting-type moves. It is also unaffected by Intimidate.",
        StormDrain => "The Pokémon draws in all Water-type moves. Instead of taking damage from them, its Sp. Atk stat is boosted.",
        IceBody => "The Pokémon gradually regains HP in snow.",
        SolidRock => "Reduces the power of supereffective attacks that hit the Pokémon.",
        SnowWarning => "The Pokémon makes it snow when it enters a battle.",
        HoneyGather => "The Pokémon may gather Honey after a battle.",
        Frisk => "When it enters a battle, the Pokémon can check an opposing Pokémon's held item.",
        Reckless => "Powers up moves that have recoil damage.",
        Multitype => "Changes the Pokémon's type to match the plate it holds.",
        FlowerGift => "Boosts the Attack and Sp. Def stats of the Pokémon and its allies in harsh sunlight.",
        BadDreams => "Damages opposing Pokémon that are asleep.",
        Pickpocket => "The Pokémon steals the held item from attackers that make direct contact with it.",
        SheerForce => "Removes any additional effects from the Pokémon's moves, but increases the moves' power.",
        Contrary => "Reverses any stat changes affecting the Pokémon so that attempts to boost its stats instead lower them— and attempts to lower its stats will boost them.",
        Unnerve => "Unnerves opposing Pokémon and makes them unable to eat Berries.",
        Defiant => "If the Pokémon has any stat lowered by an opposing Pokémon, its Attack stat will be boosted sharply.",
        Defeatist => "Halves the Pokémon's Attack and Sp. Atk stats when its HP drops to half or less.",
        CursedBody => "May disable a move that has dealt damage to the Pokémon.",
        Healer => "Sometimes cures the status conditions of the Pokémon's allies.",
        FriendGuard => "Reduces damage dealt to allies.",
        WeakArmor => "The Pokémon's Defense stat is lowered when it takes damage from physical moves, but its Speed stat is sharply boosted.",
        HeavyMetal => "Doubles the Pokémon's weight.",
        LightMetal => "Halves the Pokémon's weight.",
        Multiscale => "Reduces the amount of damage the Pokémon takes while its HP is full.",
        ToxicBoost => "Powers up physical moves when the Pokémon is poisoned.",
        FlareBoost => "Powers up special moves when the Pokémon is burned.",
        Harvest => "May create another Berry after one is used.",
        Telepathy => "The Pokémon anticipates and dodges the attacks of its allies.",
        Moody => "Every turn, one of the Pokémon's stats will be boosted sharply but another stat will be lowered.",
        Overcoat => "The Pokémon takes no damage from sandstorms. It is also protected from the effects of powders and spores.",
        PoisonTouch => "May poison a target when the Pokémon makes contact.",
        Regenerator => "The Pokémon has a little of its HP restored when withdrawn from battle.",
        BigPecks => "Prevents the Pokémon from having its Defense stat lowered.",
        SandRush => "Boosts the Pokémon's Speed stat in a sandstorm.",
        WonderSkin => "Makes status moves more likely to miss the Pokémon.",
        Analytic => "Boosts the power of the Pokémon's move if it is the last to act that turn.",
        Illusion => "The Pokémon fools opponents by entering battle disguised as the last Pokémon in its Trainer's party.",
        Imposter => "The Pokémon transforms itself into the Pokémon it's facing.",
        Infiltrator => "The Pokémon's moves are unaffected by the target's barriers, substitutes, and the like.",
        Mummy => "Contact with the Pokémon changes the attacker's Ability to Mummy.",
        Moxie => "When the Pokémon knocks out a target, it shows moxie, which boosts its Attack stat.",
        Justified => "When the Pokémon is hit by a Dark-type attack, its Attack stat is boosted by its sense of justice.",
        Rattled => "The Pokémon gets scared when hit by a Dark-, Ghost-, or Bug-type attack or if intimidated, which boosts its Speed stat.",
        MagicBounce => "The Pokémon reflects status moves instead of getting hit by them.",
        SapSipper => "The Pokémon takes no damage when hit by Grass-type moves. Instead, its Attack stat is boosted.",
        Prankster => "Gives priority to the Pokémon's status moves.",
        SandForce => "Boosts the power of Rock-, Ground-, and Steel-type moves in a sandstorm.",
        IronBarbs => "The Pokémon's iron barbs damage the attacker if it makes direct contact.",
        ZenMode => "Changes the Pokémon's shape when its HP drops to half or less.",
        VictoryStar => "Boosts the accuracy of the Pokémon and its allies.",
        Turboblaze => "The Pokémon's moves are unimpeded by the Ability of the target.",
        Teravolt => "The Pokémon's moves are unimpeded by the Ability of the target.",
        AromaVeil => "Protects the Pokémon and its allies from effects that prevent the use of moves.",
        FlowerVeil => "Ally Grass-type Pokémon are protected from status conditions and the lowering of their stats.",
        CheekPouch => "The Pokémon's HP is restored when it eats any Berry, in addition to the Berry's usual effect.",
        Protean => "Changes the Pokémon's type to the type of the move it's about to use. This works only once each time the Pokémon enters battle.",
        FurCoat => "Halves the damage from physical moves.",
        Magician => "The Pokémon steals the held item from any target it hits with a move.",
        Bulletproof => "Protects the Pokémon from ball and bomb moves.",
        Competitive => "Boosts the Pokémon's Sp. Atk stat sharply when its stats are lowered by an opposing Pokémon.",
        StrongJaw => "The Pokémon's strong jaw boosts the power of its biting moves.",
        Refrigerate => "Normal-type moves become Ice-type moves. The power of those moves is boosted a little.",
        SweetVeil => "Prevents the Pokémon and its allies from falling asleep.",
        StanceChange => "The Pokémon changes its form to Blade Forme when it uses an attack move and changes to Shield Forme when it uses King's Shield.",
        GaleWings => "Gives priority to the Pokémon's Flying-type moves while its HP is full.",
        MegaLauncher => "Powers up pulse moves.",
        GrassPelt => "Boosts the Pokémon's Defense stat on Grassy Terrain.",
        Symbiosis => "The Pokémon passes its held item to an ally that has used up an item.",
        ToughClaws => "Powers up moves that make direct contact.",
        Pixilate => "Normal-type moves become Fairy-type moves. The power of those moves is boosted a little.",
        Gooey => "Contact with the Pokémon lowers the attacker's Speed stat.",
        Aerilate => "Normal-type moves become Flying-type moves. The power of those moves is boosted a little.",
        ParentalBond => "The parent and child attack one after the other.",
        DarkAura => "Powers up the Dark-type moves of all Pokémon on the field.",
        FairyAura => "Powers up the Fairy-type moves of all Pokémon on the field.",
        AuraBreak => "The effects of \"Aura\" Abilities are reversed to lower the power of affected moves.",
        PrimoridialSea => "The Pokémon changes the weather to nullify Fire-type attacks.",
        DesolateLand => "The Pokémon changes the weather to nullify Water-type attacks.",
        DeltaStream => "The Pokémon changes the weather so that no moves are supereffective against the Flying type.",
        Stamina => "Boosts the Defense stat when the Pokémon is hit by an attack.",
        WimpOut => "The Pokémon cowardly switches out when its HP drops to half or less.",
        EmergencyExit => "The Pokémon, sensing danger, switches out when its HP drops to half or less.",
        WaterCompaction => "Boosts the Defense stat sharply when the Pokémon is hit by a Water-type move.",
        Merciless => "The Pokémon's attacks become critical hits if the target is poisoned.",
        ShieldsDown => "When its HP drops to half or less, the Pokémon's shell breaks and it becomes aggressive.",
        Stakeout => "Doubles the damage dealt to a target that has just switched into battle.",
        WaterBubble => "Lowers the power of Fire-type moves that hit the Pokémon and prevents it from being burned.",
        Steelworker => "Powers up Steel-type moves.",
        Berserk => "Boosts the Pokémon's Sp. Atk stat when it takes a hit that causes its HP to drop to half or less.",
        SlushRush => "Boosts the Pokémon's Speed stat in snow.",
        LongReach => "The Pokémon uses its moves without making contact with the target.",
        LiquidVoice => "Sound-based moves become Water-type moves.",
        Triage => "Gives priority to the Pokémon's healing moves.",
        Galvanize => "Normal-type moves become Electric-type moves. The power of those moves is boosted a little.",
        SurgeSurfer => "Doubles the Pokémon's Speed stat on Electric Terrain.",
        Schooling => "When it has a lot of HP, the Pokémon forms a powerful school. It stops schooling when its HP is low.",
        Disguise => "Once per battle, the shroud that covers the Pokémon can protect it from an attack.",
        BattleBond => "When the Pokémon knocks out a target, its bond with its Trainer is strengthened, and its Attack, Sp. Atk, and Speed stats are boosted.",
        PowerConstruct => "Cells gather to aid the Pokémon when its HP drops to half or less, causing it to change into its Complete Forme.",
        Corrosion => "The Pokémon can poison the target even if it's a Steel or Poison type.",
        Comatose => "The Pokémon is always drowsing and will never wake up. It can attack while in its sleeping state.",
        QueenlyMajesty => "The Pokémon's majesty pressures opponents and makes them unable to use priority moves against the Pokémon or its allies.",
        InnardsOut => "When the Pokémon is knocked out, it damages its attacker by the amount equal to the HP it had left before it was hit.",
        Dancer => "Whenever a dance move is used in battle, the Pokémon will copy the user to immediately perform that dance move itself.",
        Battery => "Powers up ally Pokémon's special moves.",
        Fluffy => "Halves the damage taken from moves that make direct contact, but doubles that of Fire-type moves.",
        Dazzling => "The Pokémon dazzles its opponents, making them unable to use priority moves against the Pokémon or its allies.",
        SoulHeart => "Boosts the Pokémon's Sp. Atk stat every time another Pokémon faints.",
        TanglingHair => "Contact with the Pokémon lowers the attacker's Speed stat.",
        Receiver or PowerOfAlchemy => "The Pokémon copies the Ability of a defeated ally.",
        BeastBoost => "Boosts the Pokémon's most proficient stat every time it knocks out a target.",
        RKSSystem => "Changes the Pokémon's type to match the memory disc it holds.",
        ElectricSurge => "Turns the ground into Electric Terrain when the Pokémon enters a battle.",
        PsychicSurge => "Turns the ground into Psychic Terrain when the Pokémon enters a battle.",
        MistySurge => "Turns the ground into Misty Terrain when the Pokémon enters a battle.",
        GrassySurge => "Turns the ground into Grassy Terrain when the Pokémon enters a battle.",
        FullMetalBody => "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.",
        ShadowShield => "Reduces the amount of damage the Pokémon takes while its HP is full.",
        PrismArmor => "Reduces the power of supereffective attacks that hit the Pokémon.",
        Neuroforce => "Powers up the Pokémon's supereffective attacks even further.",
        IntrepidSword => "Boosts the Pokémon's Attack stat the first time the Pokémon enters a battle.",
        DauntlessShield => "Boosts the Pokémon's Defense stat the first time the Pokémon enters a battle.",
        Libero => "Changes the Pokémon's type to the type of the move it's about to use. This works only once each time the Pokémon enters battle.",
        BallFetch => "If the Pokémon is not holding an item, it will fetch the Poké Ball from the first failed throw of the battle.",
        CottonDown => "When the Pokémon is hit by an attack, it scatters cotton fluff around and lowers the Speed stats of all Pokémon except itself.",
        PropellorTail => "Ignores the effects of opposing Pokémon's Abilities and moves that draw in moves.",
        MirrorArmor => "Bounces back only the stat-lowering effects that the Pokémon receives.",
        GulpMissile => "When the Pokémon uses Surf or Dive, it will come back with prey. When it takes damage, it will spit out the prey to attack.",
        Stalwart => "Ignores the effects of opposing Pokémon's Abilities and moves that draw in moves.",
        SteamEngine => "Boosts the Speed stat drastically when the Pokémon is hit by a Fire- or Water-type move.",
        PunkRock => "Boosts the power of sound-based moves. The Pokémon also takes half the damage from these kinds of moves.",
        SandSpit => "The Pokémon creates a sandstorm when it's hit by an attack.",
        IceScales => "The Pokémon is protected by ice scales, which halve the damage taken from special moves.",
        Ripen => "Ripens Berries and doubles their effect.",
        IceFace => "The Pokémon's ice head can take a physical attack as a substitute, but the attack also changes the Pokémon's appearance. The ice will be restored when it snows.",
        PowerSpot => "Just being next to the Pokémon powers up moves.",
        Mimicry => "Changes the Pokémon's type depending on the terrain.",
        ScreenCleaner => "When the Pokémon enters a battle, the effects of Light Screen, Reflect, and Aurora Veil are nullified for both opposing and ally Pokémon.",
        SteelySpirit => "Powers up the Steel-type moves of the Pokémon and its allies.",
        PerishBody => "When hit by a move that makes direct contact, the Pokémon and the attacker will faint after three turns unless they switch out of battle.",
        WanderingSpirit => "The Pokémon exchanges Abilities with a Pokémon that hits it with a move that makes direct contact.",
        GorillaTactics => "Boosts the Pokémon's Attack stat but only allows the use of the first selected move.",
        NeutralizingGas => "While the Pokémon is in the battle, the effects of all other Pokémon's Abilities will be nullified or will not be triggered.",
        PastelVeil => "Prevents the Pokémon and its allies from being poisoned.",
        HungerSwitch => "The Pokémon changes its form, alternating between its Full Belly Mode and Hangry Mode after the end of every turn.",
        QuickDraw => "Enables the Pokémon to move first occasionally.",
        UnseenFist => "If the Pokémon uses moves that make direct contact, it can attack the target even if the target protects itself.",
        CuriousMedicine => "When the Pokémon enters a battle, it scatters medicine from its shell, which removes all stat changes from allies.",
        Transistor => "Powers up Electric-type moves.",
        DragonsMaw => "Powers up Dragon-type moves.",
        ChillingNeigh => "When the Pokémon knocks out a target, it utters a chilling neigh, which boosts its Attack stat.",
        GrimNeigh => "When the Pokémon knocks out a target, it utters a terrifying neigh, which boosts its Sp. Atk stat.",
        AsOneGlastrier => "This Ability combines the effects of both Calyrex's Unnerve Ability and Glastrier's Chilling Neigh Ability.",
        AsOneSpectrier => "This Ability combines the effects of both Calyrex's Unnerve Ability and Spectrier's Grim Neigh Ability.",
        LingeringAroma => "Contact with the Pokémon changes the attacker's Ability to Lingering Aroma.",
        SeedSower => "Turns the ground into Grassy Terrain when the Pokémon is hit by an attack.",
        ThermalExchange => "Boosts the Attack stat when the Pokémon is hit by a Fire-type move. The Pokémon also cannot be burned.",
        AngerShell => "When an attack causes its HP to drop to half or less, the Pokémon gets angry. This lowers its Defense and Sp. Def stats but boosts its Attack, Sp. Atk, and Speed stats.",
        PurifyingSalt => "The Pokémon's pure salt protects it from status conditions and halves the damage taken from Ghost-type moves.",
        WellBakedBody => "The Pokémon takes no damage when hit by Fire-type moves. Instead, its Defense stat is sharply boosted.",
        WindRider => "Boosts the Pokémon's Attack stat if Tailwind takes effect or if the Pokémon is hit by a wind move. The Pokémon also takes no damage from wind moves.",
        GuardDog => "Boosts the Pokémon's Attack stat if intimidated. Moves and items that would force the Pokémon to switch out also fail to work.",
        RockyPayload => "Powers up Rock-type moves.",
        WindPower => "The Pokémon becomes charged when it is hit by a wind move, boosting the power of the next Electric-type move the Pokémon uses.",
        ZeroToHero => "The Pokémon transforms into its Hero Form when it switches out.",
        Commander => "When the Pokémon enters a battle, it goes inside the mouth of an ally Dondozo if one is on the field. The Pokémon then issues commands from there.",
        Electromorphosis => "The Pokémon becomes charged when it takes damage, boosting the power of the next Electric-type move the Pokémon uses.",
        Protosynthesis => "Boosts the Pokémon's most proficient stat in harsh sunlight or if the Pokémon is holding Booster Energy.",
        QuarkDrive => "Boosts the Pokémon's most proficient stat on Electric Terrain or if the Pokémon is holding Booster Energy.",
        GoodAsGold => "A body of pure, solid gold gives the Pokémon full immunity to other Pokémon's status moves.",
        VesselOfRuin => "The power of the Pokémon's ruinous vessel lowers the Sp. Atk stats of all Pokémon except itself.",
        SwordOfRuin => "The power of the Pokémon's ruinous sword lowers the Defense stats of all Pokémon except itself.",
        TabletsOfRuin => "The power of the Pokémon's ruinous wooden tablets lowers the Attack stats of all Pokémon except itself.",
        BeadsOfRuin => "The power of the Pokémon's ruinous beads lowers the Sp. Def stats of all Pokémon except itself.",
        OrichalcumPulse => "Turns the sunlight harsh when the Pokémon enters a battle. The ancient pulse thrumming through the Pokémon also boosts its Attack stat in harsh sunlight.",
        HadronEngine => "Turns the ground into Electric Terrain when the Pokémon enters a battle. The futuristic engine within the Pokémon also boosts its Sp. Atk stat on Electric Terrain.",
        Opportunist => "If an opponent's stat is boosted, the Pokémon seizes the opportunity to boost the same stat for itself.",
        CudChew => "When the Pokémon eats a Berry, it will regurgitate that Berry at the end of the next turn and eat it one more time.",
        Sharpness => "Powers up slicing moves.",
        SupremeOverlord => "When the Pokémon enters a battle, its Attack and Sp. Atk stats are slightly boosted for each of the allies in its party that have already been defeated.",
        Costar => "When the Pokémon enters a battle, it copies an ally's stat changes.",
        ToxicDebris => "Scatters poison spikes at the feet of the opposing team when the Pokémon takes damage from physical moves.",
        ArmorTail => "The mysterious tail covering the Pokémon's head makes opponents unable to use priority moves against the Pokémon or its allies.",
        EarthEater => "If hit by a Ground-type move, the Pokémon has its HP restored instead of taking damage.",
        MyceliumMight => "The Pokémon will always act more slowly when using status moves, but these moves will be unimpeded by the Ability of the target.",
        Hospitality => "When the Pokémon enters a battle, it showers its ally with hospitality, restoring a small amount of the ally's HP.",
        MindsEye => "The Pokémon ignores changes to opponents' evasiveness, its accuracy can't be lowered, and it can hit Ghost types with Normal- and Fighting-type moves.",
        EmbodyTeal => "The Pokémon's heart fills with memories, causing the Teal Mask to shine and the Pokémon's Speed stat to be boosted.",
        EmbodyFire => "The Pokémon's heart fills with memories, causing the Hearthflame Mask to shine and the Pokémon's Attack stat to be boosted.",
        EmbodyWater => "The Pokémon's heart fills with memories, causing the Wellspring Mask to shine and the Pokémon's Sp. Def stat to be boosted.",
        EmbodyRock => "The Pokémon's heart fills with memories, causing the Cornerstone Mask to shine and the Pokémon's Defense stat to be boosted.",
        ToxicChain => "The power of the Pokémon's toxic chain may badly poison any target the Pokémon hits with a move.",
        SupersweetSyrup => "A sickly sweet scent spreads across the field the first time the Pokémon enters a battle, lowering the evasiveness of opposing Pokémon.",
        _ => "Description not done yet"
    };
}