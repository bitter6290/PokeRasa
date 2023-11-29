using static Type;
using static MoveData;
using static MoveFlags;
using static MoveDesc;
using static Target;

public static class Move
{
    public const int AlwaysHit = 101;
    public const int noFlag = 0;

    public static MoveData None = FakeMove;
    public static MoveData Pound = new(
        "Pound", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, PoundDesc); //Done
    public static MoveData KarateChop = new(
        "Karate Chop", Fighting,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        highCrit + makesContact, KarateChopDesc); //Done
    public static MoveData DoubleSlap = new(
        "Double Slap", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        makesContact, DoubleSlapDesc); //Done
    public static MoveData CometPunch = new(
        "Comet Punch", Normal,
        18, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15,
         makesContact + punchMove, CometPunchDesc); //Needs anim
    public static MoveData MegaPunch = new(
        "Mega Punch", Normal,
        80, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
         makesContact + punchMove, MegaPunchDesc); //Needs anim
    public static MoveData PayDay = new(
        "Pay Day", Normal,
        40, 100, 0,
        MoveEffect.PayDay, 101,
        true, Single, 20, noFlag, PayDayDesc); //Needs anim and money implementation
    public static MoveData FirePunch = new(
        "Fire Punch", Fire,
        75, 100, 0,
        MoveEffect.Burn, 10,
        true, Single, 15,
        makesContact + punchMove, FirePunchDesc); //Needs anim
    public static MoveData IcePunch = new(
        "Ice Punch", Ice,
        75, 100, 0,
        MoveEffect.Freeze, 10,
        true, Single, 15,
        makesContact + punchMove, IcePunchDesc); //Needs anim
    public static MoveData ThunderPunch = new(
        "Thunder Punch", Electric,
        75, 100, 0,
        MoveEffect.Paralyze, 10,
        true, Single, 15,
        makesContact + punchMove, ThunderPunchDesc); //Needs anim
    public static MoveData Scratch = new(
        "Scratch", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, ScratchDesc); //Needs anim
    public static MoveData ViseGrip = new(
        "Vise Grip", Normal,
        55, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact, ViseGripDesc); //Needs anim
    public static MoveData Guillotine = new(
        "Guillotine", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5,
        makesContact, GuillotineDesc); //Needs anim
    public static MoveData RazorWind = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, SpreadMove, 10,
        noFlag, RazorWindDesc); //Needs anim
    public static MoveData SwordsDance = new(
        "Swords Dance", Normal,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp2, 0,
        false, Self, 20, snatchAffected, SwordsDanceDesc);
    public static MoveData Cut = new(
        "Cut", Normal,
        50, 95, 0,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact + sharpnessBoosted, CutDesc); //Needs anim
    public static MoveData Gust = new(
        "Gust", Flying,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 35,
        hitFlyingMon + windMove, GustDesc); //Needs anim
    public static MoveData WingAttack = new(
        "Wing Attack", Flying,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, WingAttackDesc); //Needs anim
    public static MoveData Whirlwind = new(
        "Whirlwind", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Single, 20,
        magicBounceAffected + windMove, WhirlwindDesc); //Needs anim
    public static MoveData Fly = new(
        "Fly", Flying,
        90, 95, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 15,
        gravityDisabled, FlyDesc); //Needs anim
    public static MoveData Bind = new(
        "Bind", Normal,
        15, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 20,
        makesContact, BindDesc); //Needs anim
    public static MoveData Slam = new(
        "Slam", Normal,
        80, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, SlamDesc); //Needs anim
    public static MoveData VineWhip = new(
        "Vine Whip", Grass,
        45, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        makesContact, VineWhipDesc); //Needs anim
    public static MoveData Stomp = new(
        "Stomp", Normal,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 20,
        makesContact, StompDesc); //Needs anim
    public static MoveData DoubleKick = new(
        "Double Kick", Fighting,
        30, 100, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 30,
        makesContact, DoubleKickDesc); //Needs anim
    public static MoveData MegaKick = new(
        "Mega Kick", Normal,
        120, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 5,
        makesContact, MegaKickDesc); //Needs anim
    public static MoveData JumpKick = new(
        "Jump Kick", Fighting,
        100, 20, 0,
        MoveEffect.Crash50Max, 0,
        true, Single, 10,
        makesContact + gravityDisabled, JumpKickDesc); //Needs anim
    public static MoveData RollingKick = new(
        "Rolling Kick", Fighting,
        60, 85, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, RollingKickDesc); //Needs anim
    public static MoveData SandAttack = new(
        "Sand Attack", Ground,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 15,
        magicBounceAffected, SandAttackDesc); //Needs anim
    public static MoveData Headbutt = new(
        "Headbutt", Normal,
        70, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, HeadbuttDesc); //Needs field effect and anim
    public static MoveData HornAttack = new(
        "Horn Attack", Normal,
        65, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        makesContact, HornAttackDesc); //Needs anim
    public static MoveData FuryAttack = new(
        "Fury Attack", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20,
        makesContact, FuryAttackDesc); //Needs anim
    public static MoveData HornDrill = new(
        "Horn Drill", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5,
        makesContact, HornDrillDesc); //Needs anim
    public static MoveData Tackle = new(
        "Tackle", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, TackleDesc); //Needs anim
    public static MoveData BodySlam = new(
        "Body Slam", Normal,
        85, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 15,
        makesContact, BodySlamDesc); //Needs anim
    public static MoveData Wrap = new(
        "Wrap", Normal,
        15, 90, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 20,
        makesContact, WrapDesc); //Needs anim
    public static MoveData TakeDown = new(
        "Take Down", Normal,
        90, 85, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 20,
        makesContact, TakeDownDesc); //Needs anim
    public static MoveData Thrash = new(
        "Thrash", Normal,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Self, 10,
        makesContact, ThrashDesc); //Needs anim
    public static MoveData DoubleEdge = new(
        "Double Edge", Normal,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, DoubleEdgeDesc); //Needs anim
    public static MoveData TailWhip = new(
        "Tail Whip", Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, SpreadMove, 30,
        magicBounceAffected, TailWhipDesc); //Needs anim
    public static MoveData PoisonSting = new(
        "Poison Sting", Poison,
        15, 100, 0,
        MoveEffect.Poison, 30,
        true, Single, 35, noFlag, PoisonStingDesc); //Needs anim
    public static MoveData Twineedle = new(
        "Twineedle", Bug,
        25, 100, 0,
        MoveEffect.Twineedle, 20,
        true, Single, 20, noFlag, TwineedleDesc); //Needs anim
    public static MoveData PinMissile = new(
        "Pin Missile", Bug,
        25, 95, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20, noFlag, PinMissileDesc); //Needs anim
    public static MoveData Leer = new(
        "Leer", Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, SpreadMove, 30,
        magicBounceAffected, LeerDesc); //Needs anim
    public static MoveData Bite = new(
        "Bite", Dark,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 25,
        makesContact, BiteDesc); //Needs anim
    public static MoveData Growl = new(
        "Growl", Normal,
        0, 100, 0,
        MoveEffect.AttackDown1, 100,
        false, SpreadMove, 40,
        soundMove + magicBounceAffected, GrowlDesc);
    public static MoveData Roar = new(
        "Roar", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Single, 20,
        soundMove + magicBounceAffected, RoarDesc); //Needs anim
    public static MoveData Sing = new(
        "Sing", Normal,
        0, 55, 0,
        MoveEffect.Sleep, 100,
        false, Single, 15,
        soundMove + magicBounceAffected, SingDesc); //Needs anim
    public static MoveData Supersonic = new(
        "Supersonic", Normal,
        0, 55, 0,
        MoveEffect.Confuse, 100,
        false, Single, 20,
        soundMove + magicBounceAffected, SupersonicDesc); //Needs anim
    public static MoveData SonicBoom = new(
        "Sonic Boom", Normal,
        1, 90, 0,
        MoveEffect.Direct20, 0,
        false, Single, 20, noFlag, SonicBoomDesc); //Needs anim
    public static MoveData Disable = new(
        "Disable", Normal,
        0, 100, 0,
        MoveEffect.Disable, 100,
        false, Single, 20,
        magicBounceAffected, DisableDesc); //Needs anim
    public static MoveData Acid = new(
        "Acid", Poison,
        40, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, SpreadMove, 30,
        noFlag, AcidDesc); //Needs anim
    public static MoveData Ember = new(
        "Ember", Fire,
        40, 100, 0,
        MoveEffect.Burn, 10,
        false, Single, 25,
        noFlag, EmberDesc); //Needs anim
    public static MoveData Flamethrower = new(
        "Flamethrower", Fire,
        90, 100, 0,
        MoveEffect.Burn, 10,
        false, Single, 15,
        noFlag, FlamethrowerDesc); //Needs anim
    public static MoveData Mist = new(
        "Mist", Ice,
        0, AlwaysHit, 0,
        MoveEffect.Mist, 100,
        false, Field, 30, snatchAffected,
        MistDesc); //Needs anim
    public static MoveData WaterGun = new(
        "Water Gun", Water,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 25,
        noFlag, WaterGunDesc); //Needs anim
    public static MoveData HydroPump = new(
        "Hydro Pump", Water,
        110, 80, 0,
        MoveEffect.Hit, 0,
        false, Single, 5,
        noFlag, HydroPumpDesc); //Needs anim
    public static MoveData Surf = new(
        "Surf", Water,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, Surrounding, 15,
        noFlag, SurfDesc); //Needs anim
    public static MoveData IceBeam = new(
        "Ice Beam", Ice,
        90, 100, 0,
        MoveEffect.Freeze, 10,
        false, Single, 10,
        noFlag, IceBeamDesc); //Needs anim
    public static MoveData Blizzard = new(
        "Blizzard", Ice,
        110, 70, 0,
        MoveEffect.Freeze, 10,
        false, SpreadMove, 5,
        windMove, BlizzardDesc); //Needs anim
    public static MoveData Psybeam = new(
        "Psybeam", Type.Psychic,
        65, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 20,
        noFlag, PsybeamDesc); //Needs anim
    public static MoveData BubbleBeam = new(
        "Bubble Beam", Water,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, BubbleBeamDesc); //Needs anim
    public static MoveData AuroraBeam = new(
        "Aurora Beam", Ice,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, AuroraBeamDesc); //Needs anim
    public static MoveData HyperBeam = new(
        "Hyper Beam", Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, Single, 5,
        noFlag, HyperBeamDesc); //Needs anim
    public static MoveData Peck = new(
        "Peck", Flying,
        35, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, PeckDesc); //Needs anim
    public static MoveData DrillPeck = new(
        "Drill Peck", Flying,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, DrillPeckDesc); //Needs anim
    public static MoveData Submission = new(
        "Submission", Fighting,
        80, 80, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 20,
        makesContact, SubmissionDesc); //Needs anim
    public static MoveData LowKick = new(
        "Low Kick", Fighting,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        true, Single, 20,
        makesContact, LowKickDesc); //Needs anim
    public static MoveData Counter = new(
        "Counter", Fighting,
        1, 100, -5,
        MoveEffect.Counter, 0,
        true, Target.None, 20,
        makesContact, CounterDesc); //Needs anim
    public static MoveData SeismicToss = new(
        "Seismic Toss", Fighting,
        0, 100, 0,
        MoveEffect.DirectLevel, 0,
        true, Single, 20,
        makesContact, SeismicTossDesc); //Needs anim
    public static MoveData Strength = new(
        "Strength", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        makesContact, StrengthDesc); //Needs anim
    public static MoveData Absorb = new(
        "Absorb", Grass,
        20, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 25,
        effectOnSelfOnly, AbsorbDesc); //Needs anim
    public static MoveData MegaDrain = new(
        "Mega Drain", Grass,
        40, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 15,
        effectOnSelfOnly, MegaDrainDesc); //Needs anim
    public static MoveData LeechSeed = new(
        "Leech Seed", Grass,
        0, 90, 0,
        MoveEffect.LeechSeed, 100,
        false, Single, 10,
        magicBounceAffected, LeechSeedDesc); //Needs anim
    public static MoveData Growth = new(
        "Growth", Normal,
        0, AlwaysHit, 0,
        MoveEffect.Growth, 100,
        false, Self, 20,
        snatchAffected, GrowthDesc); //Needs anim
    public static MoveData RazorLeaf = new(
        "Razor Leaf", Grass,
        55, 95, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 25,
        highCrit + sharpnessBoosted, RazorLeafDesc); //Needs anim
    public static MoveData SolarBeam = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Single, 10, noFlag, SolarBeamDesc); //Needs anim
    public static MoveData PoisonPowder = new(
        "Poison Powder", Poison,
        0, 75, 0,
        MoveEffect.Poison, 100,
        false, Single, 35,
        powderMove + magicBounceAffected, PoisonPowderDesc); //Needs anim
    public static MoveData StunSpore = new(
        "Stun Spore", Grass,
        0, 75, 0,
        MoveEffect.Paralyze, 100,
        false, Single, 30,
        powderMove + magicBounceAffected, StunSporeDesc); //Needs anim
    public static MoveData SleepPowder = new(
        "Sleep Powder", Grass,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, Single, 15,
        powderMove + magicBounceAffected, SleepPowderDesc); //Needs anim
    public static MoveData PetalDance = new(
        "Petal Dance", Grass,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        false, Self, 10,
        makesContact, PetalDanceDesc); //Needs anim
    public static MoveData StringShot = new(
        "String Shot", Bug,
        0, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, SpreadMove, 40,
        magicBounceAffected, StringShotDesc); //Needs anim
    public static MoveData DragonRage = new(
        "Dragon Rage", Dragon,
        1, 100, 0,
        MoveEffect.Direct40, 0,
        false, Single, 10, noFlag, DragonRageDesc); //Needs anim
    public static MoveData FireSpin = new(
        "Fire Spin", Fire,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 15, noFlag, FireSpinDesc); //Needs anim
    public static MoveData ThunderShock = new(
        "Thunder Shock", Electric,
        40, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Single, 30, noFlag, ThunderShockDesc); //Needs anim
    public static MoveData Thunderbolt = new(
        "Thunderbolt", Electric,
        90, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Single, 15, noFlag, ThunderboltDesc); //Needs anim
    public static MoveData ThunderWave = new(
        "Thunder Wave", Electric,
        0, 90, 0,
        MoveEffect.Paralyze, 100,
        false, Single, 20,
        magicBounceAffected, ThunderWaveDesc); //Needs anim
    public static MoveData Thunder = new(
        "Thunder", Electric,
        110, 70, 0,
        MoveEffect.Paralyze, 30,
        false, Single, 10,
        alwaysHitsInRain, ThunderDesc); //Needs anim
    public static MoveData RockThrow = new(
        "Rock Throw", Rock,
        50, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 15, noFlag, RockThrowDesc); //Needs anim
    public static MoveData Earthquake = new(
        "Earthquake", Ground,
        100, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10, hitDiggingMon, EarthquakeDesc); //Needs anim
    public static MoveData Fissure = new(
        "Fissure", Ground,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5, noFlag, FissureDesc); //Needs anim
    public static MoveData Dig = new(
        "Dig", Ground,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10, noFlag, DigDesc); //Needs anim
    public static MoveData Toxic = new(
        "Toxic", Poison,
        0, 90, 0,
        MoveEffect.Toxic, 100,
        false, Single, 10,
        magicBounceAffected, ToxicDesc); //Needs anim
    public static MoveData Confusion = new(
        "Confusion", Type.Psychic,
        50, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 25, noFlag, ConfusionDesc); //Needs anim
    public static MoveData Psychic = new(
        "Psychic", Type.Psychic,
        90, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Single, 10, noFlag, PsychicDesc); //Needs anim
    public static MoveData Hypnosis = new(
        "Hypnosis", Type.Psychic,
        0, 60, 0,
        MoveEffect.Sleep, 100,
        false, Single, 20,
        magicBounceAffected, HypnosisDesc); //Needs anim
    public static MoveData Meditate = new(
        "Meditate", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp1, 0,
        false, Self, 40,
        snatchAffected, MeditateDesc); //Needs anim
    public static MoveData Agility = new(
        "Agility", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.SpeedUp2, 100,
        false, Self, 30,
        snatchAffected, AgilityDesc); //Needs anim
    public static MoveData QuickAttack = new(
        "Quick Attack", Normal,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact, QuickAttackDesc); //Needs anim
    public static MoveData Rage = new(
        "Rage", Normal,
        20, 100, 0,
        MoveEffect.Rage, 0,
        true, Single, 20,
        makesContact, RageDesc); //Needs anim and test
    public static MoveData Teleport = new(
        "Teleport", Type.Psychic,
        0, AlwaysHit, -6,
        MoveEffect.Teleport, 0,
        false, Self, 20, noFlag, TeleportDesc); //Needs anim
    public static MoveData NightShade = new(
        "Night Shade", Ghost,
        1, 100, 0,
        MoveEffect.DirectLevel, 0,
        false, Single, 15, noFlag, NightShadeDesc); //Needs anim
    public static MoveData Mimic = new(
        "Mimic", Normal,
        0, 101, 0,
        MoveEffect.Mimic, 100,
        false, Single, 10, noFlag, MimicDesc); //Needs anim
    public static MoveData Screech = new(
        "Screech", Normal,
        0, 85, 0,
        MoveEffect.DefenseDown2, 100,
        false, Single, 40,
        soundMove + magicBounceAffected, ScreechDesc); //Needs anim
    public static MoveData DoubleTeam = new(
        "Double Team", Normal,
        0, 101, 0,
        MoveEffect.EvasionUp1, 100,
        false, Self, 15,
        snatchAffected, DoubleTeamDesc); //Needs anim
    public static MoveData Recover = new(
        "Recover", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Self, 10,
        snatchAffected + healBlockAffected, RecoverDesc); //Needs anim
    public static MoveData Harden = new(
        "Harden", Normal,
        0, 101, 0,
        MoveEffect.DefenseUp1, 0,
        false, Self, 30,
        snatchAffected, HardenDesc); //Needs anim
    public static MoveData Minimize = new(
        "Minimize", Normal,
        0, 101, 0,
        MoveEffect.Minimize, 100,
        false, Self, 10, snatchAffected, MinimizeDesc); //Needs anim
    public static MoveData Smokescreen = new(
        "Smokescreen", Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 20,
        magicBounceAffected, SmokescreenDesc); //Needs anim
    public static MoveData ConfuseRay = new(
        "Confuse Ray", Ghost,
        0, 100, 0,
        MoveEffect.Confuse, 100,
        false, Single, 10,
        magicBounceAffected, ConfuseRayDesc); //Needs anim
    public static MoveData Withdraw = new(
        "Withdraw", Water,
        0, 101, 0,
        MoveEffect.DefenseUp1, 100,
        false, Self, 40,
        snatchAffected, WithdrawDesc); //Needs anim
    public static MoveData DefenseCurl = new(
        "Defense Curl", Normal,
        0, 101, 0,
        MoveEffect.DefenseCurl, 100,
        false, Self, 40, snatchAffected,
        DefenseCurlDesc); //Needs anim
    public static MoveData Barrier = new(
        "Barrier", Type.Psychic,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, Self, 20,
        snatchAffected, BarrierDesc); //Needs anim
    public static MoveData LightScreen = new(
        "Light Screen", Type.Psychic,
        0, 101, 0,
        MoveEffect.LightScreen, 0,
        false, Field, 30, snatchAffected,
        LightScreenDesc); //Needs anim
    public static MoveData Haze = new(
        "Haze", Ice,
        0, 101, 0,
        MoveEffect.Haze, 0,
        false, Field, 30, noFlag, HazeDesc); //Needs anim
    public static MoveData Reflect = new(
        "Reflect", Type.Psychic,
        0, 101, 0,
        MoveEffect.Reflect, 0,
        false, Field, 20,
        snatchAffected, ReflectDesc); //Needs anim
    public static MoveData FocusEnergy = new(
        "Focus Energy", Normal,
        0, 101, 0,
        MoveEffect.CritRateUp2, 0,
        false, Self, 30,
        snatchAffected, FocusEnergyDesc); //Needs anim
    public static MoveData Bide = new(
        "Bide", Normal,
        1, 101, 1,
        MoveEffect.ChargingAttack, 0,
        true, Self, 10, noFlag, BideDesc); //Needs anim
    public static MoveData Metronome = new(
        "Metronome", Normal,
        0, 101, 0,
        MoveEffect.Metronome, 0,
        false, Self, 10,
        cannotMimic, MetronomeDesc); //Needs anim
    public static MoveData MirrorMove = new(
        "Mirror Move", Flying,
        0, 101, 0,
        MoveEffect.MirrorMove, 0,
        false, Single, 20, noFlag, MirrorMoveDesc); //Needs anim
    //Todo: Define which moves are affected by Mirror Move
    public static MoveData SelfDestruct = new(
        "Self Destruct", Normal,
        200, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Single, 5, noFlag, SelfDestructDesc); //Needs anim
    public static MoveData EggBomb = new(
        "Egg Bomb", Normal,
        100, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 10, noFlag, EggBombDesc); //Needs anim
    public static MoveData Lick = new(
        "Lick", Ghost,
        30, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 30,
        makesContact, LickDesc); //Needs anim
    public static MoveData Smog = new(
        "Smog", Poison,
        30, 70, 0,
        MoveEffect.Poison, 40,
        false, Single, 20, noFlag, SmogDesc); //Needs anim
    public static MoveData Sludge = new(
        "Sludge", Poison,
        65, 100, 0,
        MoveEffect.Poison, 30,
        false, Single, 20, noFlag, SludgeDesc); //Needs anim
    public static MoveData BoneClub = new(
        "Bone Club", Ground,
        65, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 20, noFlag, BoneClubDesc); //Needs anim
    public static MoveData FireBlast = new(
        "Fire Blast", Fire,
        110, 85, 0,
        MoveEffect.Burn, 30,
        false, Single, 5, noFlag, FireBlastDesc); //Needs anim
    public static MoveData Waterfall = new(
        "Waterfall", Water,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        true, Single, 15,
        makesContact, WaterfallDesc); //Needs anim
    public static MoveData Clamp = new(
        "Clamp", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 15,
        makesContact, ClampDesc); //Needs anim
    public static MoveData Swift = new(
        "Swift", Normal,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 20,
        noFlag, SwiftDesc); //Needs anim
    public static MoveData SkullBash = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        makesContact, SkullBashDesc); //Needs anim
    public static MoveData SpikeCannon = new(
        "Spike Cannon", Normal,
        20, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15, noFlag, SpikeCannonDesc); //Needs anim
    public static MoveData Constrict = new(
        "Constrict", Normal,
        10, 100, 0,
        MoveEffect.SpeedDown1, 10,
        true, Single, 35,
        makesContact, ConstrictDesc); //Needs anim
    public static MoveData Amnesia = new(
        "Amnesia", Type.Psychic,
        0, 101, 0,
        MoveEffect.SpDefUp2, 100,
        false, Self, 20,
        snatchAffected, AmnesiaDesc); //Needs anim
    public static MoveData Kinesis = new(
        "Kinesis", Type.Psychic,
        0, 80, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 15,
        magicBounceAffected, KinesisDesc); //Needs anim
    public static MoveData SoftBoiled = new(
        "Soft-Boiled", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Self, 10,
        snatchAffected + healBlockAffected, SoftBoiledDesc); //Needs anim
    public static MoveData HighJumpKick = new(
        "High Jump Kick", Fighting,
        130, 90, 0,
        MoveEffect.Crash50Max, 0,
        true, Single, 10,
        makesContact + gravityDisabled, HighJumpKickDesc); //Needs anim
    public static MoveData Glare = new(
        "Glare", Normal,
        0, 100, 0,
        MoveEffect.Paralyze, 100,
        false, Single, 30,
        magicBounceAffected, GlareDesc); //Needs anim
    public static MoveData DreamEater = new(
        "Dream Eater", Type.Psychic,
        100, 100, 0,
        MoveEffect.DreamEater, 0,
        false, Single, 15, noFlag, DreamEaterDesc); //Needs anim
    public static MoveData PoisonGas = new(
        "Poison Gas", Poison,
        0, 90, 0,
        MoveEffect.Poison, 100,
        false, SpreadMove, 40,
        magicBounceAffected, PoisonGasDesc); //Needs anim
    public static MoveData Barrage = new(
        "Barrage", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20, noFlag, BarrageDesc); //Needs anim
    public static MoveData LeechLife = new(
        "Leech Life", Bug,
        80, 100, 0,
        MoveEffect.Absorb50, 0,
        true, Single, 10,
        makesContact, LeechLifeDesc); //Needs anim
    public static MoveData LovelyKiss = new(
        "Lovely Kiss", Normal,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, Single, 10,
        magicBounceAffected, LovelyKissDesc); //Needs anim
    public static MoveData SkyAttack = new(
        "Sky Attack", Flying,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5, noFlag, SkyAttackDesc); //Needs anim
    public static MoveData Transform = new(
        "Transform", Normal,
        0, 101, 0,
        MoveEffect.Transform, 0,
        false, Single, 10,
        cannotMimic, TransformDesc); //Needs anim
    public static MoveData Bubble = new(
        "Bubble", Water,
        40, 100, 0,
        MoveEffect.SpeedDown1, 10,
        false, SpreadMove, 30,
        noFlag, BubbleDesc); //Needs anim
    public static MoveData DizzyPunch = new(
        "Dizzy Punch", Normal,
        70, 100, 0,
        MoveEffect.Confuse, 20,
        true, Single, 10,
        makesContact + punchMove, DizzyPunchDesc); //Needs anim
    public static MoveData Spore = new(
        "Spore", Grass,
        0, 100, 0,
        MoveEffect.Sleep, 100,
        false, Single, 15,
        powderMove + magicBounceAffected, SporeDesc); //Needs anim
    public static MoveData Flash = new(
        "Flash", Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 20,
        magicBounceAffected, FlashDesc); //Needs anim
    public static MoveData Psywave = new(
        "Psywave", Type.Psychic,
        1, 100, 0,
        MoveEffect.Psywave, 0,
        false, Single, 15,
        noFlag, PsywaveDesc); //Needs anim
    public static MoveData Splash = new(
        "Splash", Normal,
        0, 101, 0,
        MoveEffect.None, 0,
        false, Self, 40,
        gravityDisabled, SplashDesc); //Needs anim
    public static MoveData AcidArmor = new(
        "Acid Armor", Poison,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, Self, 20,
        snatchAffected, AcidArmorDesc); //Needs anim
    public static MoveData Crabhammer = new(
        "Crabhammer", Water,
        100, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        highCrit + makesContact, CrabhammerDesc); //Needs anim
    public static MoveData Explosion = new(
        "Explosion", Normal,
        250, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Surrounding, 5, noFlag, ExplosionDesc); //Needs anim
    public static MoveData FurySwipes = new(
        "Fury Swipes", Normal,
        18, 80, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15,
        makesContact, FurySwipesDesc); //Needs anim
    public static MoveData Bonemerang = new(
        "Bonemerang", Ground,
        50, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 10, noFlag, BonemerangDesc); //Needs anim
    public static MoveData Rest = new(
        "Rest", Type.Psychic,
        0, 101, 0,
        MoveEffect.Rest, 0,
        false, Self, 10,
        snatchAffected, RestDesc); //Needs anim
    public static MoveData RockSlide = new(
        "Rock Slide", Rock,
        75, 90, 0,
        MoveEffect.Flinch, 30,
        true, SpreadMove, 10,
        noFlag, RockSlideDesc); //Needs anim
    public static MoveData HyperFang = new(
        "Hyper Fang", Normal,
        80, 90, 0,
        MoveEffect.Flinch, 10,
        true, Single, 15,
        makesContact, HyperFangDesc); //Needs anim
    public static MoveData Sharpen = new(
        "Sharpen", Normal,
        0, 101, 0,
        MoveEffect.AttackUp1, 100,
        false, Self, 30,
        snatchAffected, SharpenDesc); //Needs anim
    public static MoveData Conversion = new(
        "Conversion", Normal,
        0, 101, 0,
        MoveEffect.Conversion, 101,
        false, Self, 30, snatchAffected, ConversionDesc); //Needs anim
    public static MoveData TriAttack = new(
        "Tri Attack", Normal,
        80, 100, 0,
        MoveEffect.TriAttack, 20,
        false, Single, 10, noFlag, TriAttackDesc); //Needs anim
    public static MoveData SuperFang = new(
        "Super Fang", Normal,
        0, 90, 0,
        MoveEffect.SuperFang, 0,
        true, Single, 10,
        makesContact, SuperFangDesc); //Needs anim
    public static MoveData Slash = new(
        "Slash", Normal,
        70, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        highCrit + makesContact + sharpnessBoosted, SlashDesc); //Needs anim
    public static MoveData Substitute = new(
        "Substitute", Normal,
        0, 101, 0,
        MoveEffect.Substitute, 100,
        false, Self, 10,
        snatchAffected, SubstituteDesc); //Needs anim

    //Gen 2

    public static MoveData Sketch = new(
         "Sketch", Normal,
         0, 101, 0,
         MoveEffect.Sketch, 0,
         false, Single, 1,
         noFlag, SketchDesc); //Needs anim
    public static MoveData TripleKick = new(
        "Triple Kick", Fighting,
        10, 90, 0,
        MoveEffect.TripleHit, 0,
        true, Single, 10,
        makesContact, TripleKickDesc); //Needs anim
    public static MoveData Thief = new(
        "Thief", Dark,
        60, 100, 0,
        MoveEffect.Thief, 100,
        true, Single, 25,
        makesContact, ThiefDesc); //Needs anim
    public static MoveData SpiderWeb = new(
        "Spider Web", Bug,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, Single, 10,
        magicBounceAffected, SpiderWebDesc); //Needs anim
    public static MoveData MindReader = new(
        "Mind Reader", Normal,
        0, 101, 0,
        MoveEffect.MindReader, 100,
        false, Single, 5, noFlag, MindReaderDesc); //Needs testing and anim
    public static MoveData Nightmare = new(
        "Nightmare", Ghost,
        0, 100, 0,
        MoveEffect.Nightmare, 101,
        false, Single, 15, noFlag, NightmareDesc); //Needs anim
    public static MoveData FlameWheel = new(
        "Flame Wheel", Fire,
        60, 100, 0,
        MoveEffect.Burn, 10,
        true, Single, 25,
        makesContact, FlameWheelDesc); //Needs anim
    public static MoveData Snore = new(
        "Snore", Normal,
        50, 100, 0,
        MoveEffect.Snore, 30,
        false, Single, 15,
        noFlag, SnoreDesc); //Needs anim
    public static MoveData Curse = new(
        "Curse", Ghost,
        0, 100, 0,
        MoveEffect.Curse, 100,
        false, Single, 10,
        noFlag, CurseDesc); //Needs anim
    public static MoveData Flail = new(
        "Flail", Normal,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Single, 15,
        makesContact, FlailDesc); //Needs anim
    public static MoveData Conversion2 = new(
        "Conversion 2", Normal,
        0, 101, 0,
        MoveEffect.Conversion2, 101,
        false, Single, 30,
        effectOnSelfOnly, Conversion2Desc); //Needs anim
    public static MoveData Aeroblast = new(
        "Aeroblast", Flying,
        100, 95, 0,
        MoveEffect.Hit, 0,
        false, Single, 5,
        highCrit, AeroblastDesc); //Needs anim
    public static MoveData CottonSpore = new(
        "Cotton Spore", Grass,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, SpreadMove, 40,
        magicBounceAffected, CottonSporeDesc); //Needs anim
    public static MoveData Reversal = new(
        "Reversal", Fighting,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Single, 15,
        makesContact, ReversalDesc); //Needs anim
    public static MoveData Spite = new(
        "Spite", Ghost,
        0, 100, 0,
        MoveEffect.Spite, 100,
        false, Single, 10,
        magicBounceAffected, SpiteDesc); //Needs anim
    public static MoveData PowderSnow = new(
        "Powder Snow", Ice,
        40, 100, 0,
        MoveEffect.Freeze, 10,
        false, SpreadMove, 25,
        noFlag, PowderSnowDesc); //Needs anim
    public static MoveData Protect = new(
        "Protect", Normal,
        0, 101, 4,
        MoveEffect.Protect, 100,
        false, Self, 10,
        usesProtectCounter, ProtectDesc); //Needs anim
    public static MoveData MachPunch = new(
        "Mach Punch", Fighting,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact + punchMove, MachPunchDesc); //Needs anim
    public static MoveData ScaryFace = new(
        "Scary Face", Normal,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, Single, 10,
        magicBounceAffected, ScaryFaceDesc); //Needs anim
    public static MoveData FeintAttack = new(
        "Feint Attack", Dark,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, FeintAttackDesc); //Needs anim
    public static MoveData SweetKiss = new(
        "Sweet Kiss", Fairy,
        0, 75, 0,
        MoveEffect.Confuse, 100,
        false, Single, 10,
        magicBounceAffected, SweetKissDesc); //Needs anim
    public static MoveData BellyDrum = new(
        "Belly Drum", Normal,
        0, 101, 0,
        MoveEffect.BellyDrum, 100,
        false, Self, 10,
        snatchAffected, BellyDrumDesc); //Needs anim
    public static MoveData SludgeBomb = new(
        "Sludge Bomb", Poison,
        90, 100, 0,
        MoveEffect.Poison, 30,
        false, Single, 10,
        bulletMove, SludgeBombDesc); //Needs anim
    public static MoveData MudSlap = new(
        "Mud Slap", Ground,
        20, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 10,
        noFlag, MudSlapDesc); //Needs anim
    public static MoveData Octazooka = new(
        "Octazooka", Water,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 50,
        false, Single, 10,
        bulletMove, OctazookaDesc); //Needs anim
    public static MoveData Spikes = new(
        "Spikes", Ground,
        0, 101, 0,
        MoveEffect.Spikes, 100,
        false, Field, 20,
        magicBounceAffected, SpikesDesc); //Needs anim
    public static MoveData ZapCannon = new(
        "Zap Cannon", Electric,
        120, 50, 0,
        MoveEffect.Paralyze, 100,
        false, Single, 5,
        bulletMove, ZapCannonDesc); //Needs anim
    public static MoveData Foresight = new(
        "Foresight", Normal,
        0, 101, 0,
        MoveEffect.Foresight, 100,
        false, Single, 40,
        magicBounceAffected, ForesightDesc); //Needs anim
    public static MoveData DestinyBond = new(
        "Destiny Bond", Ghost,
        0, 101, 0,
        MoveEffect.DestinyBond, 101,
        false, Self, 5,
        noFlag, DestinyBondDesc); //Needs anim
    public static MoveData PerishSong = new(
        "Perish Song", Normal,
        0, 101, 0,
        MoveEffect.PerishSong, 100,
        false, All, 5,
        soundMove, PerishSongDesc); //Needs anim
    public static MoveData IcyWind = new(
        "Icy Wind", Ice,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, SpreadMove, 15,
        windMove, IcyWindDesc); //Needs anim
    public static MoveData Detect = new(
        "Detect", Fighting,
        0, 101, 4,
        MoveEffect.Protect, 100,
        false, Self, 5,
        usesProtectCounter, DetectDesc); //Needs anim
    public static MoveData BoneRush = new(
        "Bone Rush", Ground,
        25, 90, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        noFlag, BoneRushDesc); //Needs anim
    public static MoveData LockOn = new(
        "Lock On", Normal,
        0, 101, 0,
        MoveEffect.MindReader, 100,
        false, Single, 5,
        noFlag, LockOnDesc); //Needs anim
    public static MoveData Outrage = new(
        "Outrage", Dragon,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Self, 10,
        makesContact, OutrageDesc); //Needs anim
    public static MoveData Sandstorm = new(
        "Sandstorm", Rock,
        0, 101, 0,
        MoveEffect.Weather, 100,
        false, Field, 10,
        noFlag, SandstormDesc); //Needs anim
    public static MoveData GigaDrain = new(
        "Giga Drain", Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 10,
        noFlag, GigaDrainDesc); //Needs anim
    public static MoveData Endure = new(
        "Endure", Normal,
        0, 101, 4,
        MoveEffect.Endure, 101,
        false, Self, 10,
        usesProtectCounter, EndureDesc); //Needs anim
    public static MoveData Charm = new(
        "Charm", Fairy,
        0, 100, 0,
        MoveEffect.AttackDown2, 100,
        false, Single, 20,
        magicBounceAffected, CharmDesc); //Needs anim
    public static MoveData Rollout = new(
        "Rollout", Rock,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact, RolloutDesc); //Needs anim
    public static MoveData FalseSwipe = new(
        "False Swipe", Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, Single, 40,
        makesContact, FalseSwipeDesc); //Needs anim
    public static MoveData Swagger = new(
        "Swagger", Normal,
        0, 85, 0,
        MoveEffect.Swagger, 0,
        false, Single, 15,
        magicBounceAffected, SwaggerDesc); //Needs anim
    public static MoveData MilkDrink = new(
        "Milk Drink", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Self, 10,
        snatchAffected + healBlockAffected, MilkDrinkDesc); //Needs anim
    public static MoveData Spark = new(
        "Spark", Electric,
        65, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 20,
        makesContact, SparkDesc); //Need anim
    public static MoveData FuryCutter = new(
        "Fury Cutter", Bug,
        40, 95, 0,
        MoveEffect.FuryCutter, 0,
        true, Single, 20,
        makesContact + sharpnessBoosted, FuryCutterDesc); //Needs anim
    public static MoveData SteelWing = new(
        "Steel Wing", Steel,
        70, 90, 0,
        MoveEffect.DefenseUp1, 10,
        true, Single, 25,
        effectOnSelfOnly + makesContact, SteelWingDesc); //Needs anim
    public static MoveData MeanLook = new(
        "Mean Look", Normal,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, Single, 5,
        magicBounceAffected, MeanLookDesc); //Needs anim
    public static MoveData Attract = new(
        "Attract", Normal,
        0, 100, 0,
        MoveEffect.Attract, 100,
        false, Single, 15,
        magicBounceAffected, AttractDesc); //Needs anim
    public static MoveData SleepTalk = new(
        "Sleep Talk", Normal,
        0, 101, 0,
        MoveEffect.SleepTalk, 100,
        false, Self, 10, noFlag, SleepTalkDesc); //Needs testing and anim
    public static MoveData HealBell = new(
        "Heal Bell", Normal,
        0, 101, 0,
        MoveEffect.HealBell, 100,
        false, Field, 5,
        snatchAffected, HealBellDesc); //Needs anim
    public static MoveData Return = new(
        "Return", Normal,
        1, 100, 0,
        MoveEffect.Return, 0,
        true, Single, 20,
        makesContact, ReturnDesc); //Needs anim
    public static MoveData Present = new(
        "Present", Normal,
        1, 90, 0,
        MoveEffect.Present, 0,
        true, Single, 15, noFlag, PresentDesc); //Needs anim
    public static MoveData Frustration = new(
        "Frustration", Normal,
        0, 100, 0,
        MoveEffect.Frustration, 0,
        true, Single, 20,
        makesContact, FrustrationDesc); //Needs anim
    public static MoveData Safeguard = new(
        "Safeguard", Normal,
        0, 101, 0,
        MoveEffect.Safeguard, 100,
        false, Field, 25,
        snatchAffected, SafeguardDesc); //Needs anim
    public static MoveData PainSplit = new(
        "Pain Split", Normal,
        0, 101, 0,
        MoveEffect.PainSplit, 100,
        false, Single, 20, noFlag, PainSplitDesc); //Needs anim
    public static MoveData SacredFire = new(
        "Sacred Fire", Fire,
        100, 95, 0,
        MoveEffect.Burn, 50,
        true, Single, 5, noFlag, SacredFireDesc); //Needs anim
    public static MoveData Magnitude = new(
        "Magnitude", Ground,
        1, 100, 0,
        MoveEffect.Magnitude, 0,
        true, Single, 30, noFlag, MagnitudeDesc); //Needs anim
    public static MoveData DynamicPunch = new(
        "Dynamic Punch", Fighting,
        100, 50, 0,
        MoveEffect.Confuse, 100,
        true, Single, 5,
        makesContact + punchMove, DynamicPunchDesc); //Needs anim
    public static MoveData Megahorn = new(
        "Megahorn", Bug,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, MegahornDesc); //Needs anim
    public static MoveData DragonBreath = new(
        "Dragon Breath", Dragon,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Single, 20, noFlag, DragonBreathDesc); //Needs anim
    public static MoveData BatonPass = new(
        "Baton Pass", Normal,
        0, 101, 0,
        MoveEffect.BatonPass, 100,
        false, Self, 40, noFlag, BatonPassDesc); //Needs testing and anim
    public static MoveData Encore = new(
        "Encore", Normal,
        0, 100, 0,
        MoveEffect.Encore, 100,
        false, Single, 5,
        magicBounceAffected, EncoreDesc); //Needs testing and anim
    public static MoveData Pursuit = new(
        "Pursuit", Dark,
        40, 100, 0,
        MoveEffect.Pursuit, 100,
        true, Single, 20,
        makesContact, PursuitDesc); //Needs anim
    public static MoveData RapidSpin = new(
        "Rapid Spin", Normal,
        50, 100, 0,
        MoveEffect.RapidSpin, 100,
        true, Single, 40,
        effectOnSelfOnly + makesContact, RapidSpinDesc); //Needs anim
    public static MoveData SweetScent = new(
        "Sweet Scent", Normal,
        0, 100, 0,
        MoveEffect.EvasionDown2, 100,
        false, SpreadMove, 20,
        magicBounceAffected, SweetScentDesc); //Needs anim
    public static MoveData IronTail = new(
        "Iron Tail", Steel,
        100, 75, 0,
        MoveEffect.DefenseDown1, 30,
        true, Single, 15,
        makesContact, IronTailDesc); //Needs anim
    public static MoveData MetalClaw = new(
        "Metal Claw", Steel,
        50, 95, 0,
        MoveEffect.AttackUp1, 10,
        true, Single, 35,
        effectOnSelfOnly + makesContact, MetalClawDesc); //Needs anim
    public static MoveData VitalThrow = new(
        "Vital Throw", Fighting,
        70, 101, -1,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, VitalThrowDesc); //Needs anim
    public static MoveData MorningSun = new(
        "Morning Sun", Normal,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Self, 5,
        snatchAffected, MorningSunDesc); //Needs anim
    public static MoveData Synthesis = new(
        "Synthesis", Grass,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Self, 5,
        snatchAffected, SynthesisDesc); //Needs anim
    public static MoveData Moonlight = new(
        "Moonlight", Fairy,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Self, 5,
        snatchAffected, MoonlightDesc); //Needs anim
    public static MoveData HiddenPower = new(
        "Hidden Power", Normal,
        60, 100, 0,
        MoveEffect.HiddenPower, 0,
        false, Single, 15, noFlag, HiddenPowerDesc); //Needs anim
    public static MoveData CrossChop = new(
        "Cross Chop", Fighting,
        100, 80, 0,
        MoveEffect.Hit, 0,
        true, Single, 5,
        highCrit + makesContact, CrossChopDesc); //Needs anim
    public static MoveData Twister = new(
        "Twister", Dragon,
        40, 100, 0,
        MoveEffect.Flinch, 20,
        false, SpreadMove, 20,
        hitFlyingMon + windMove, TwisterDesc); //Needs anim
    public static MoveData RainDance = new(
        "Rain Dance", Water,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, Field, 5, noFlag, RainDanceDesc); //Needs anim
    public static MoveData SunnyDay = new(
        "Sunny Day", Fire,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, Field, 5, noFlag, SunnyDayDesc); //Needs anim
    public static MoveData Crunch = new(
        "Crunch", Dark,
        80, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, Single, 15,
        makesContact, CrunchDesc); //Needs anim
    public static MoveData MirrorCoat = new(
        "Mirror Coat", Type.Psychic,
        0, 100, -5,
        MoveEffect.Counter, 0,
        false, Target.None, 20, noFlag, MirrorCoatDesc); //Needs testing and anim
    public static MoveData PsychUp = new(
        "Psych Up", Normal,
        0, 101, 0,
        MoveEffect.PsychUp, 100,
        false, Single, 10,
        snatchAffected, PsychUpDesc); //Needs anim
    public static MoveData ExtremeSpeed = new(
        "Extreme Speed", Normal,
        80, 100, 2,
        MoveEffect.Hit, 0,
        true, Single, 5,
        makesContact, ExtremeSpeedDesc); //Needs anim
    public static MoveData AncientPower = new(
        "Ancient Power", Rock,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5, noFlag, AncientPowerDesc); //Needs anim
    public static MoveData ShadowBall = new(
        "Shadow Ball", Ghost,
        80, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Single, 15,
        bulletMove, ShadowBallDesc); //Needs anim
    public static MoveData FutureSight = new(
        "Future Sight", Type.Psychic,
        120, 100, 0,
        MoveEffect.FutureSight, 100,
        false, Single, 10, noFlag, FutureSightDesc); //Needs anim
    public static MoveData RockSmash = new(
        "Rock Smash", Fighting,
        40, 100, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 15,
        makesContact, RockSmashDesc); //Needs anim
    public static MoveData Whirlpool = new(
        "Whirlpool", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 15, noFlag, WhirlpoolDesc); //Needs anim
    public static MoveData BeatUp = new(
        "Beat Up", Dark,
        1, 100, 0,
        MoveEffect.BeatUp, 0,
        true, Single, 10, noFlag, BeatUpDesc); //Needs anim

    //Gen 3

    public static MoveData FakeOut = new(
        "Fake Out", Normal,
        40, 100, 3,
        MoveEffect.FakeOut, 100,
        true, Single, 10,
        makesContact, FakeOutDesc); //Needs anim
    public static MoveData Uproar = new(
        "Uproar", Normal,
        90, 100, 0,
        MoveEffect.Uproar, 100,
        false, Self, 10,
        soundMove + effectOnSelfOnly, UproarDesc); //Needs anim
    public static MoveData Stockpile = SelfTargetingMove(
        "Stockpile", Normal, 0, MoveEffect.Stockpile, 20,
        snatchAffected, StockpileDesc); //Needs anim
    public static MoveData SpitUp = new(
        "Spit Up", Normal,
        1, 100, 0,
        MoveEffect.SpitUp, 0,
        false, Single, 10, noFlag, SpitUpDesc); //Needs anim
    public static MoveData Swallow = SelfTargetingMove(
        "Swallow", Normal, 0, MoveEffect.Swallow, 10,
        snatchAffected, SwallowDesc); //Needs anim
    public static MoveData HeatWave = new(
        "Heat Wave", Fire,
        95, 90, 0,
        MoveEffect.Burn, 10,
        false, SpreadMove, 10,
        windMove, HeatWaveDesc); //Needs anim
    public static MoveData Hail = FieldMove(
        "Hail", Ice, 0, MoveEffect.Weather, 10, noFlag, HailDesc); //Needs anim
    public static MoveData Torment = SingleTargetStatusMove(
        "Torment", Dark, 100, 0, MoveEffect.Torment, 15,
        magicBounceAffected, TormentDesc); //Needs anim
    public static MoveData Flatter = SingleTargetStatusMove(
        "Flatter", Dark, 100, 0, MoveEffect.Flatter, 15,
        magicBounceAffected, FlatterDesc); //Needs anim
    public static MoveData WillOWisp = SingleTargetStatusMove(
        "Will-O-Wisp", Fire, 85, 0, MoveEffect.Burn, 15,
        magicBounceAffected, WillOWispDesc); //Needs anim
    public static MoveData Memento = SingleTargetStatusMove(
        "Memento", Dark, 100, 0, MoveEffect.Memento, 10,
        noFlag, MementoDesc); //Needs anim
    public static MoveData Facade = new(
        "Facade", Normal,
        70, 100, 0,
        MoveEffect.Facade, 0,
        true, Single, 20,
        makesContact, FacadeDesc); //Needs anim
    public static MoveData FocusPunch = new(
        "Focus Punch", Fighting,
        150, 100, 9,
        MoveEffect.FocusPunchWindup, 100,
        true, Single, 20,
        effectOnSelfOnly, FocusPunchDesc); //Needs anim
    public static MoveData SmellingSalts = new(
        "Smelling Salts", Normal,
        70, 100, 0,
        MoveEffect.SmellingSalts, 100,
        true, Single, 10,
        makesContact, SmellingSaltsDesc); //Needs anim
    public static MoveData FollowMe = SelfTargetingMove(
        "Follow Me", Normal, 2, MoveEffect.FollowMe, 20,
        noFlag, FollowMeDesc); //Needs anim
    public static MoveData NaturePower = new(
        "Nature Power", Normal,
        1, 100, 0,
        MoveEffect.NaturePower, 0,
        false, Single, 20,
        noFlag, NaturePowerDesc); //Needs anim
    public static MoveData Charge = SelfTargetingMove(
        "Charge", Electric, 0, MoveEffect.Charge, 20,
        snatchAffected, ChargeDesc); //Needs anim
    public static MoveData Taunt = SingleTargetStatusMove(
        "Taunt", Dark, 100, 0, MoveEffect.Taunt, 20,
        magicBounceAffected, TauntDesc); //Needs anim
    public static MoveData HelpingHand = new(
        "Helping Hand", Normal,
        0, 100, 5,
        MoveEffect.HelpingHand, 100,
        false, Ally, 20,
        noFlag, HelpingHandDesc); //Needs anim
    public static MoveData Trick = SingleTargetStatusMove(
        "Trick", Type.Psychic, 100, 0, MoveEffect.Trick, 10,
        noFlag, TrickDesc); //Needs anim
    public static MoveData RolePlay = SingleTargetStatusMove(
        "Role Play", Type.Psychic, 100, 0, MoveEffect.RolePlay, 10,
        noFlag, RolePlayDesc); //Needs anim
    public static MoveData Wish = SelfTargetingMove(
        "Wish", Normal, 0, MoveEffect.Wish, 10,
        snatchAffected + healBlockAffected, WishDesc); //Needs anim
    public static MoveData Assist = SelfTargetingMove(
        "Assist", Normal, 0, MoveEffect.Assist, 20,
        noFlag, AssistDesc); //Needs anim
    public static MoveData Ingrain = SelfTargetingMove(
        "Ingrain", Grass, 0, MoveEffect.Ingrain, 20,
        snatchAffected, IngrainDesc); //Needs anim
    public static MoveData Superpower = new(
        "Superpower", Fighting,
        120, 100, 0,
        MoveEffect.AttackDefenseDown1, 100,
        true, Single, 5,
        effectOnSelfOnly + makesContact, SuperpowerDesc); //Needs anim
    public static MoveData MagicCoat = SelfTargetingMove(
        "Magic Coat", Type.Psychic, 4, MoveEffect.MagicCoat, 15,
        noFlag, MagicCoatDesc); //Needs anim
    public static MoveData Recycle = SelfTargetingMove(
        "Recycle", Normal, 0, MoveEffect.Recycle, 10,
        snatchAffected, RecycleDesc); //Needs anim
    public static MoveData Revenge = new(
        "Revenge", Fighting,
        60, 100, -4,
        MoveEffect.Revenge, 0,
        true, Single, 10,
        makesContact, RevengeDesc); //Needs anim
    public static MoveData BrickBreak = new(
        "Brick Break", Fighting,
        75, 100, 0,
        MoveEffect.BreakScreens, 100,
        true, Single, 15,
        makesContact, BrickBreakDesc); //Needs anim
    public static MoveData Yawn = SingleTargetStatusMove(
        "Yawn", Normal, 100, 0, MoveEffect.Yawn, 10,
        magicBounceAffected, YawnDesc); //Needs anim
    public static MoveData KnockOff = new(
        "Knock Off", Dark,
        65, 100, 0,
        MoveEffect.KnockOff, 100,
        true, Single, 20,
        makesContact, KnockOffDesc); //Needs anim
    public static MoveData Endeavor = new(
        "Endeavor", Normal,
        1, 100, 0,
        MoveEffect.Endeavor, 0,
        true, Single, 5,
        makesContact, EndeavorDesc); //Needs anim
    public static MoveData Eruption = new(
        "Eruption", Fire,
        150, 100, 0,
        MoveEffect.HealthPower, 0,
        false, SpreadMove, 5,
        noFlag, EruptionDesc); //Needs anim
    public static MoveData SkillSwap = SingleTargetStatusMove(
        "Skill Swap", Type.Psychic, 100, 0, MoveEffect.SkillSwap, 10,
        noFlag, SkillSwapDesc); //Needs anim
    public static MoveData Imprison = SelfTargetingMove(
        "Imprison", Type.Psychic, 0, MoveEffect.Imprison, 10,
        snatchAffected, ImprisonDesc); //Needs anim
    public static MoveData Refresh = SelfTargetingMove(
        "Refresh", Normal, 0, MoveEffect.HealStatus, 20,
        snatchAffected, RefreshDesc); //Needs anim
    public static MoveData Grudge = SelfTargetingMove(
        "Grudge", Ghost, 0, MoveEffect.Grudge, 5,
        noFlag, GrudgeDesc); //Needs anim
    public static MoveData Snatch = SelfTargetingMove(
        "Snatch", Dark, 4, MoveEffect.Snatch, 10,
        noFlag, SnatchDesc); //Needs anim
    public static MoveData SecretPower = new(
        "Secret Power", Normal,
        70, 100, 0,
        MoveEffect.SecretPower, 30,
        true, Single, 20,
        noFlag, SecretPowerDesc); //Needs anim, including different anims based on terrain
    public static MoveData Dive = new(
        "Dive", Water,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        noFlag, DiveDesc); //Needs anim
    public static MoveData ArmThrust = new(
        "Arm Thrust", Fighting,
        15, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20,
        makesContact, ArmThrustDesc); //Needs anim
    public static MoveData Camouflage = SelfTargetingMove(
        "Camouflage", Normal, 0, MoveEffect.Camouflage, 20,
        snatchAffected, CamouflageDesc); //Needs anim
    public static MoveData TailGlow = SelfTargetingMove(
        "Tail Glow", Bug, 0, MoveEffect.SpAtkUp3, 20,
        snatchAffected, TailGlowDesc); //Needs anim
    public static MoveData LusterPurge = new(
        "Luster Purge", Type.Psychic,
        70, 100, 0,
        MoveEffect.SpDefDown1, 50,
        false, Single, 5,
        noFlag, LusterPurgeDesc); //Needs anim
    public static MoveData MistBall = new(
        "Mist Ball", Type.Psychic,
        70, 100, 0,
        MoveEffect.SpAtkDown1, 50,
        false, Single, 5,
        bulletMove, MistBallDesc); //Needs anim
    public static MoveData FeatherDance = SingleTargetStatusMove(
        "Feather Dance", Flying, 100, 0, MoveEffect.AttackDown2, 15,
        magicBounceAffected, FeatherDanceDesc); //Needs anim
    public static MoveData TeeterDance = new(
        "Teeter Dance", Normal,
        0, 100, 0,
        MoveEffect.Confuse, 100,
        false, Surrounding, 20,
        noFlag, TeeterDanceDesc); //Needs anim
    public static MoveData BlazeKick = new(
        "Blaze Kick", Fire,
        85, 90, 0,
        MoveEffect.Burn, 10,
        true, Single, 10,
        makesContact + highCrit, BlazeKickDesc); //Needs anim
    public static MoveData MudSport = FieldMove(
        "Mud Sport", Ground, 0, MoveEffect.MudSport, 15,
        noFlag, MudSportDesc); //Needs anim
    public static MoveData IceBall = new(
        "Ice Ball", Ice,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact + bulletMove, IceBallDesc); //Needs anim
    public static MoveData NeedleArm = new(
        "Needle Arm", Grass,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, NeedleArmDesc); //Needs anim
    public static MoveData SlackOff = SelfTargetingMove(
        "Slack Off", Normal, 0, MoveEffect.Heal50, 5,
        snatchAffected + healBlockAffected, SlackOffDesc); //Needs anim
    public static MoveData HyperVoice = new(
        "Hyper Voice", Normal,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        soundMove, HyperVoiceDesc); //Needs anim
    public static MoveData PoisonFang = new(
        "Poison Fang", Poison,
        50, 100, 0,
        MoveEffect.Toxic, 50,
        true, Single, 15,
        makesContact, PoisonFangDesc); //Needs anim
    public static MoveData CrushClaw = new(
        "Crush Claw", Normal,
        75, 95, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 10,
        makesContact, CrushClawDesc); //Needs anim
    public static MoveData BlastBurn = new(
        "Blast Burn", Fire,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, BlastBurnDesc); //Needs anim
    public static MoveData HydroCannon = new(
        "Hydro Cannon", Water,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, HydroCannonDesc); //Needs anim
    public static MoveData MeteorMash = new(
        "Meteor Mash", Steel,
        90, 90, 0,
        MoveEffect.AttackUp1, 20,
        true, Single, 10,
        makesContact + effectOnSelfOnly, MeteorMashDesc); //Needs anim
    public static MoveData Astonish = new(
        "Astonish", Ghost,
        30, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, AstonishDesc); //Needs anim
    public static MoveData WeatherBall = new(
        "Weather Ball", Normal,
        50, 100, 0,
        MoveEffect.WeatherBall, 0,
        false, Single, 10,
        bulletMove, WeatherBallDesc); //Needs anim
    public static MoveData Aromatherapy = FieldMove(
        "Aromatherapy", Grass, 0, MoveEffect.HealBell, 5,
        snatchAffected, AromatherapyDesc); //Needs anim
    public static MoveData FakeTears = SingleTargetStatusMove(
        "Fake Tears", Dark, 100, 0, MoveEffect.SpDefDown2, 20,
        magicBounceAffected, FakeTearsDesc); //Needs anim
    public static MoveData AirCutter = new(
        "Air Cutter", Flying,
        60, 95, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 25,
        highCrit + sharpnessBoosted + windMove, AirCutterDesc); //Needs anim
    public static MoveData Overheat = new(
        "Overheat", Fire,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, OverheatDesc); //Needs anim
    public static MoveData OdorSleuth = new(
        "Odor Sleuth", Normal,
        0, 101, 0,
        MoveEffect.Foresight, 100,
        false, Single, 40,
        magicBounceAffected, OdorSleuthDesc); //Needs anim
    public static MoveData RockTomb = new(
        "Rock Tomb", Rock,
        60, 95, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 15,
        noFlag, RockTombDesc); //Needs anim
    public static MoveData SilverWind = new(
        "Silver Wind", Bug,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5,
        effectOnSelfOnly, SilverWindDesc); //Needs anim
    public static MoveData MetalSound = SingleTargetStatusMove(
        "Metal Sound", Steel, 85, 0, MoveEffect.SpDefDown2, 40,
        soundMove + magicBounceAffected, MetalSoundDesc); //Needs anim
    public static MoveData GrassWhistle = SingleTargetStatusMove(
        "Grass Whistle", Grass, 55, 0, MoveEffect.Sleep, 15,
        soundMove + magicBounceAffected, GrassWhistleDesc); //Needs anim
    public static MoveData Tickle = SingleTargetStatusMove(
        "Tickle", Normal, 100, 0, MoveEffect.AttackDefenseDown1, 20,
        magicBounceAffected, TickleDesc); //Needs anim
    public static MoveData CosmicPower = SelfTargetingMove(
        "Cosmic Power", Type.Psychic, 0, MoveEffect.DefenseSpDefUp1, 20,
        snatchAffected, CosmicPowerDesc); //Needs anim
    public static MoveData WaterSpout = new(
        "Water Spout", Water,
        150, 100, 0,
        MoveEffect.HealthPower, 0,
        false, SpreadMove, 5,
        noFlag, WaterSpoutDesc); //Needs anim
    public static MoveData SignalBeam = new(
        "Signal Beam", Bug,
        75, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 15,
        noFlag, SignalBeamDesc); //Needs anim
    public static MoveData ShadowPunch = new(
        "Shadow Punch", Ghost,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact + punchMove, ShadowPunchDesc); //Needs anim
    public static MoveData Extrasensory = new(
        "Extrasensory", Type.Psychic,
        80, 100, 0,
        MoveEffect.Flinch, 10,
        false, Single, 20,
        noFlag, ExtrasensoryDesc); //Needs anim
    public static MoveData SkyUppercut = new(
        "Sky Uppercut", Fighting,
        85, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        hitFlyingMon + makesContact + punchMove, SkyUppercutDesc); //Needs anim
    public static MoveData SandTomb = new(
        "Sand Tomb", Ground,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 15,
        noFlag, SandTombDesc); //Needs anim
    public static MoveData SheerCold = new(
        "Sheer Cold", Ice,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        false, Single, 5,
        noFlag, SheerColdDesc); //Needs anim
    public static MoveData MuddyWater = new(
        "Muddy Water", Water,
        90, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, SpreadMove, 10,
        noFlag, MuddyWaterDesc); //Needs anim
    public static MoveData BulletSeed = new(
        "Bullet Seed", Grass,
        25, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 30,
        bulletMove, BulletSeedDesc); //Needs anim
    public static MoveData AerialAce = new(
        "Aerial Ace", Flying,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact + sharpnessBoosted, AerialAceDesc); //Needs anim
    public static MoveData IcicleSpear = new(
        "Icicle Spear", Ice,
        25, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 30,
        noFlag, IcicleSpearDesc); //Needs anim
    public static MoveData IronDefense = SelfTargetingMove(
        "Iron Defense", Steel, 0, MoveEffect.DefenseUp2, 15,
        snatchAffected, IronDefenseDesc); //Needs anim
    public static MoveData Block = SingleTargetStatusMove(
        "Block", Normal, 101, 0, MoveEffect.Trap, 5,
        magicBounceAffected, BlockDesc); //Needs anim
    public static MoveData Howl = new(
        "Howl", Normal,
        0, 101, 0,
        MoveEffect.AttackUp1, 100,
        false, Ally + Self + Spread + Ranged, 40,
        soundMove + snatchAffected, HowlDesc); //Needs anim
    public static MoveData DragonClaw = new(
        "Dragon Claw", Dragon,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        makesContact, DragonClawDesc); //Needs anim
    public static MoveData FrenzyPlant = new(
        "Frenzy Plant", Grass,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, FrenzyPlantDesc); //Needs anim
    public static MoveData BulkUp = SelfTargetingMove(
        "Bulk Up", Fighting, 0, MoveEffect.AttackDefenseUp1, 20,
        snatchAffected, BulkUpDesc); //Needs anim
    public static MoveData Bounce = new(
        "Bounce", Flying,
        85, 85, 0,
        MoveEffect.ChargingAttack, 100,
        true, Single, 5,
        gravityDisabled, BounceDesc); //Needs anim
    public static MoveData MudShot = new(
        "Mud Shot", Ground,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, Single, 15,
        noFlag, MudShotDesc); //Needs anim
    public static MoveData PoisonTail = new(
        "Poison Tail", Poison,
        50, 100, 0,
        MoveEffect.Poison, 10,
        true, Single, 25,
        highCrit + makesContact, PoisonTailDesc); //Needs anim
    public static MoveData Covet = new(
        "Covet", Normal,
        60, 100, 0,
        MoveEffect.Thief, 100,
        true, Single, 25,
        makesContact, CovetDesc); //Needs anim
    public static MoveData VoltTackle = new(
        "Volt Tackle", Electric,
        120, 100, 0,
        MoveEffect.VoltTackle, 10,
        true, Single, 15,
        makesContact, VoltTackleDesc); //Needs anim
    public static MoveData MagicalLeaf = new(
        "Magical Leaf", Grass,
        60, 101, 0,
        MoveEffect.Hit, 20,
        false, Single, 20,
        noFlag, MagicalLeafDesc); //Needs anim
    public static MoveData WaterSport = FieldMove(
        "Water Sport", Water, 0, MoveEffect.WaterSport, 15,
        noFlag, WaterSpoutDesc); //Needs anim
    public static MoveData CalmMind = SelfTargetingMove(
        "Calm Mind", Type.Psychic, 0, MoveEffect.SpAtkSpDefUp1, 20,
        snatchAffected, CalmMindDesc); //Needs anim
    public static MoveData LeafBlade = new(
        "Leaf Blade", Grass,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        highCrit + sharpnessBoosted, LeafBladeDesc); //Needs anim
    public static MoveData DragonDance = SelfTargetingMove(
        "Dragon Dance", Dragon, 0, MoveEffect.AttackSpeedUp1, 20,
        snatchAffected, DragonDanceDesc); //Needs anim
    public static MoveData RockBlast = new(
        "Rock Blast", Rock,
        25, 90, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        bulletMove, RockBlastDesc); //Needs anim
    public static MoveData ShockWave = new(
        "Shock Wave", Electric,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, ShockWaveDesc); //Needs anim
    public static MoveData WaterPulse = new(
        "Water Pulse", Water,
        60, 100, 0,
        MoveEffect.Confuse, 30,
        false, Single + Ranged, 20,
        megaLauncherBoosted, WaterPulseDesc); //Needs anim
    public static MoveData DoomDesire = new(
        "Doom Desire", Steel,
        140, 100, 0,
        MoveEffect.FutureSight, 100,
        false, Single, 5,
        noFlag, DoomDesireDesc); //Needs anim
    public static MoveData PsychoBoost = new(
        "Psycho Boost", Type.Psychic,
        140, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, PsychoBoostDesc); //Needs anim

    //Gen 4

    public static MoveData Roost = SelfTargetingMove(
        "Roost", Flying, 0, MoveEffect.Roost, 5,
        snatchAffected, RoostDesc); //Needs anim
    public static MoveData Gravity = FieldMove(
        "Gravity", Type.Psychic, 0, MoveEffect.Gravity, 5,
        noFlag, GravityDesc); //Needs anim
    public static MoveData MiracleEye = SingleTargetStatusMove(
        "Miracle Eye", Type.Psychic, 101, 0, MoveEffect.MiracleEye, 40,
        magicBounceAffected, MiracleEyeDesc); //Needs anim
    public static MoveData WakeUpSlap = new(
        "Wake-Up Slap", Fighting,
        70, 100, 0,
        MoveEffect.WakeUpSlap, 100,
        true, Single, 10,
        makesContact, WakeUpSlapDesc); //Needs anim
    public static MoveData HammerArm = new(
        "Hammer Arm", Fighting,
        100, 100, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 10,
        makesContact + punchMove + effectOnSelfOnly, HammerArmDesc); //Needs anim
    public static MoveData GyroBall = new(
        "Gyro Ball", Steel,
        1, 100, 0,
        MoveEffect.LowSpeedPower, 0,
        true, Single, 5,
        makesContact, GyroBallDesc); //Needs anim
    public static MoveData HealingWish = SelfTargetingMove(
        "Healing Wish", Type.Psychic, 0, MoveEffect.HealingWish, 10,
        snatchAffected + healBlockAffected, HealingWishDesc); //Needs anim
    public static MoveData Brine = new(
        "Brine", Water,
        65, 100, 0,
        MoveEffect.Brine, 100,
        false, Single, 10,
        noFlag, BrineDesc); //Needs anim
    public static MoveData NaturalGift = new(
        "Natural Gift", Normal,
        1, 100, 0,
        MoveEffect.NaturalGift, 0,
        true, Single, 15,
        noFlag, NaturalGiftDesc); //Needs anim
    public static MoveData Feint = new(
        "Feint", Normal,
        30, 100, 2,
        MoveEffect.Feint, 100,
        true, Single, 10,
        makesContact, FeintDesc); //Needs anim
    public static MoveData Pluck = new(
        "Pluck", Flying,
        60, 100, 0,
        MoveEffect.Pluck, 100,
        true, Single, 20,
        makesContact, PluckDesc); //Needs anim
    public static MoveData Tailwind = FieldMove(
        "Tailwind", Flying, 0, MoveEffect.Tailwind, 15,
        snatchAffected + windMove, TailwindDesc); //Needs anim
    public static MoveData Acupressure = new(
        "Acupressure", Normal,
        0, 101, 0,
        MoveEffect.Acupressure, 100,
        false, Ally + Self, 30,
        noFlag, AssuranceDesc); //Needs anim
    public static MoveData MetalBurst = new(
        "Metal Burst", Steel,
        1, 100, 0,
        MoveEffect.MetalBurst, 0,
        true, Target.None, 10,
        noFlag, MetalBurstDesc); //Needs anim
    public static MoveData UTurn = new(
        "U-Turn", Bug,
        70, 100, 0,
        MoveEffect.SwitchHit, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact, UTurnDesc); //Needs anim
    public static MoveData CloseCombat = new(
        "Close Combat", Fighting,
        120, 100, 0,
        MoveEffect.DefenseSpDefDown1, 100,
        true, Single, 5,
        effectOnSelfOnly + makesContact, CloseCombatDesc); //Needs anim
    public static MoveData Payback = new(
        "Payback", Dark,
        50, 100, 0,
        MoveEffect.Payback, 0,
        true, Single, 10,
        makesContact, PaybackDesc); //Needs anim
    public static MoveData Assurance = new(
        "Assurance", Dark,
        60, 100, 0,
        MoveEffect.Assurance, 0,
        true, Single, 15,
        makesContact, AssuranceDesc); //Needs anim
    public static MoveData Embargo = SingleTargetStatusMove(
        "Embargo", Dark, 100, 0, MoveEffect.Embargo, 15,
        magicBounceAffected, EmbargoDesc);
    public static MoveData Fling = new(
        "Fling", Dark,
        1, 100, 0,
        MoveEffect.Fling, 100,
        true, Single, 10,
        noFlag, FlingDesc); //Needs anim
    public static MoveData PsychoShift = SingleTargetStatusMove(
        "Psycho Shift", Type.Psychic, 100, 0, MoveEffect.PsychoShift, 10,
        noFlag, PsychoShiftDesc); //Needs anim
    public static MoveData TrumpCard = new(
        "Trump Card", Normal,
        1, 100, 0,
        MoveEffect.TrumpCard, 0,
        false, Single, 5,
        noFlag, TrumpCardDesc); //Needs anim
    public static MoveData HealBlock = new(
        "Heal Block", Type.Psychic,
        0, 100, 0,
        MoveEffect.HealBlock, 100,
        false, SpreadMove, 15,
        magicBounceAffected, HealBlockDesc); //Needs anim
    public static MoveData WringOut = new(
        "Wring Out", Normal,
        120, 100, 0,
        MoveEffect.TargetHealthPower, 0,
        false, Single, 5,
        noFlag, WringOutDesc); //Needs anim
    public static MoveData PowerTrick = SelfTargetingMove(
        "Power Trick", Type.Psychic, 0, MoveEffect.PowerTrick, 10,
        snatchAffected, PowerTrickDesc); //Needs anim
    public static MoveData GastroAcid = SingleTargetStatusMove(
        "Gastro Acid", Poison, 100, 0, MoveEffect.SuppressAbility, 10,
        magicBounceAffected, GastroAcidDesc); //Needs anim
    public static MoveData LuckyChant = FieldMove(
        "Lucky Chant", Normal, 0, MoveEffect.LuckyChant, 30,
        snatchAffected, LuckyChantDesc); //Needs anim
    public static MoveData MeFirst = SingleTargetStatusMove(
        "Me First", Normal, 101, 0, MoveEffect.MeFirst, 20,
        noFlag, MeFirstDesc); //Needs anim
    public static MoveData Copycat = SelfTargetingMove(
        "Copycat", Normal, 0, MoveEffect.Copycat, 20,
        noFlag, CopycatDesc); //Needs anim
    public static MoveData PowerSwap = SingleTargetStatusMove(
        "Power Swap", Type.Psychic, 101, 0, MoveEffect.PowerSwap, 10,
        noFlag, PowerSwapDesc); //Needs anim
    public static MoveData GuardSwap = SingleTargetStatusMove(
        "Guard Swap", Type.Psychic, 101, 0, MoveEffect.GuardSwap, 10,
        noFlag, GuardSwapDesc); //Needs anim
    public static MoveData Punishment = new(
        "Punishment", Dark,
        60, 100, 0,
        MoveEffect.TargetStatPower, 0,
        true, Single, 5,
        makesContact, PunishmentDesc); //Needs anim
    public static MoveData LastResort = new(
        "Last Resort", Normal,
        140, 100, 0,
        MoveEffect.LastResort, 0,
        true, Single, 5,
        makesContact, LastResortDesc); //Needs anim
    public static MoveData WorrySeed = SingleTargetStatusMove(
        "Worry Seed", Grass, 100, 0, MoveEffect.WorrySeed, 10,
        magicBounceAffected, WorrySeedDesc); //Needs anim
    public static MoveData SuckerPunch = new(
        "Sucker Punch", Dark,
        70, 100, 1,
        MoveEffect.SuckerPunch, 0,
        true, Single, 5,
        makesContact, SuckerPunchDesc); //Needs anim
    public static MoveData ToxicSpikes = FieldMove(
        "Toxic Spikes", Poison, 0, MoveEffect.ToxicSpikes, 20,
        magicBounceAffected, ToxicSpikesDesc); //Needs anim
    public static MoveData HeartSwap = SingleTargetStatusMove(
        "Heart Swap", Type.Psychic, 101, 0, MoveEffect.HeartSwap, 10,
        noFlag, HeartSwapDesc); //Needs anim
    public static MoveData AquaRing = SelfTargetingMove(
        "Aqua Ring", Water, 0, MoveEffect.AquaRing, 20,
        snatchAffected, AquaRingDesc); //Needs anim
    public static MoveData MagnetRise = SelfTargetingMove(
        "Magnet Rise", Electric, 0, MoveEffect.MagnetRise, 10,
        snatchAffected, MagnetRiseDesc); //Needs anim
    public static MoveData FlareBlitz = new(
        "Flare Blitz", Fire,
        120, 100, 0,
        MoveEffect.FlareBlitz, 10,
        true, Single, 15,
        makesContact, FlareBlitzDesc); //Needs anim
    public static MoveData ForcePalm = new(
        "Force Palm", Fighting,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 10,
        makesContact, ForcePalmDesc); //Needs anim
    public static MoveData AuraSphere = SingleTargetNoEffect(
        "Aura Sphere", Fighting, 80, 101, 0, false, 20,
        megaLauncherBoosted + bulletMove, AuraSphereDesc); //Needs anim
    public static MoveData RockPolish = SelfTargetingMove(
        "Rock Polish", Rock, 0, MoveEffect.SpeedUp2, 20,
        snatchAffected, RockPolishDesc); //Needs anim
    public static MoveData PoisonJab = new(
        "Poison Jab", Poison,
        80, 100, 0,
        MoveEffect.Poison, 30,
        true, Single, 20,
        makesContact, PoisonJabDesc); //Needs anim
    public static MoveData DarkPulse = new(
        "Dark Pulse", Dark,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        false, Single + Ranged, 15,
        megaLauncherBoosted, DarkPulseDesc); //Needs anim
    public static MoveData NightSlash = SingleTargetNoEffect(
        "Night Slash", Dark, 70, 100, 0, true, 15,
        highCrit + sharpnessBoosted + makesContact, NightSlashDesc); //Needs anim
    public static MoveData AquaTail = SingleTargetNoEffect(
        "Aqua Tail", Water, 90, 90, 0, true, 10,
        makesContact, AquaTailDesc); //Needs anim
    public static MoveData SeedBomb = SingleTargetNoEffect(
        "Seed Bomb", Grass, 80, 100, 0, true, 15,
        bulletMove, SeedBombDesc); //Needs anim
    public static MoveData AirSlash = new(
        "Air Slash", Flying,
        75, 95, 0,
        MoveEffect.Flinch, 30,
        false, Single, 15,
        noFlag, AirSlashDesc); //Needs anim
    public static MoveData XScissor = SingleTargetNoEffect(
        "X-Scissor", Bug, 80, 100, 0, true, 15,
        makesContact + sharpnessBoosted, XScissorDesc); //Needs anim
    public static MoveData BugBuzz = new(
        "Bug Buzz", Bug,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        soundMove, BugBuzzDesc); //Needs anim
    public static MoveData DragonPulse = new(
        "Dragon Pulse", Dragon,
        85, 100, 0,
        MoveEffect.Hit, 0,
        false, Single + Ranged, 10,
        megaLauncherBoosted, DragonPulseDesc); //Needs anim
    public static MoveData DragonRush = new(
        "Dragon Rush", Dragon,
        100, 75, 0,
        MoveEffect.Flinch, 20,
        true, Single, 10,
        makesContact + alwaysHitsMinimized, DragonRushDesc); //Needs anim
    public static MoveData PowerGem = SingleTargetNoEffect(
        "Power Gem", Rock, 80, 100, 0, false, 20,
        noFlag, PowerGemDesc); //Needs anim
    public static MoveData DrainPunch = new(
        "Drain Punch", Fighting,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        true, Single, 10,
        makesContact + effectOnSelfOnly + healBlockAffected
        + punchMove, DrainPunchDesc); //Needs anim
    public static MoveData VacuumWave = SingleTargetNoEffect(
        "Vacuum Wave", Fighting, 40, 100, 1, false, 30,
        noFlag, VacuumWaveDesc); //Needs anim
    public static MoveData FocusBlast = new(
        "Focus Blast", Fighting,
        120, 70, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 5,
        bulletMove, FocusBlastDesc); //Needs anim
    public static MoveData EnergyBall = new(
        "Energy Ball", Grass,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        bulletMove, EnergyBallDesc); //Needs anim
    public static MoveData BraveBird = new(
        "Brave Bird", Flying,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, BraveBirdDesc); //Needs anim
    public static MoveData EarthPower = new(
        "Earth Power", Ground,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        noFlag, EarthPowerDesc); //Needs anim
    public static MoveData Switcheroo = SingleTargetStatusMove(
        "Switcheroo", Dark, 100, 0, MoveEffect.Trick, 10,
        noFlag, SwitcherooDesc); //Needs anim
    public static MoveData GigaImpact = new(
        "Giga Impact", Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        true, Single, 5,
        makesContact, GigaImpactDesc); //Needs anim
    public static MoveData NastyPlot = SelfTargetingMove(
        "Nasty Plot", Dark, 0, MoveEffect.SpAtkUp2, 20,
        snatchAffected, NastyPlotDesc); //Needs anim
    public static MoveData BulletPunch = SingleTargetNoEffect(
        "Bullet Punch", Steel, 40, 100, 1, true, 30,
        makesContact + punchMove, BulletPunchDesc); //Needs anim
    public static MoveData Avalanche = new(
        "Avalanche", Ice,
        60, 100, -4,
        MoveEffect.Revenge, 0,
        true, Single, 10,
        makesContact, AvalancheDesc); //Needs anim
    public static MoveData IceShard = SingleTargetNoEffect(
        "Ice Shard", Ice, 40, 100, 1, true, 30,
        noFlag, IceShardDesc); //Needs anim
    public static MoveData ShadowClaw = SingleTargetNoEffect(
        "Shadow Claw", Ghost, 70, 100, 0, true, 15,
        highCrit, ShadowClawDesc); //Needs anim
    public static MoveData ThunderFang = new(
        "Thunder Fang", Electric,
        65, 95, 0,
        MoveEffect.Paralyze, 10,
        true, Single, 15,
        makesContact + extraFlinch10, ThunderFangDesc); //Needs anim
    public static MoveData IceFang = new(
        "Ice Fang", Ice,
        65, 95, 0,
        MoveEffect.Freeze, 10,
        true, Single, 15,
        makesContact + extraFlinch10, IceFangDesc); //Needs anim
    public static MoveData FireFang = new(
        "Fire Fang", Fire,
        65, 95, 0,
        MoveEffect.Burn, 10,
        true, Single, 15,
        makesContact + extraFlinch10, FireFangDesc); //Needs anim
    public static MoveData ShadowSneak = SingleTargetNoEffect(
        "Shadow Sneak", Ghost, 40, 100, 0, true, 30,
        makesContact, ShadowSneakDesc); //Needs anim
    public static MoveData MudBomb = new(
        "Mud Bomb", Ground,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, Single, 10,
        bulletMove, MudBombDesc); //Needs anim
    public static MoveData PsychoCut = SingleTargetNoEffect(
        "Psycho Cut", Type.Psychic, 70, 100, 0, true, 20,
        highCrit + sharpnessBoosted, PsychoCutDesc); //Needs anim
    public static MoveData ZenHeadbutt = new(
        "Zen Headbutt", Type.Psychic,
        80, 90, 0,
        MoveEffect.Flinch, 20,
        true, Single, 15,
        makesContact, ZenHeadbuttDesc); //Needs anim
    public static MoveData MirrorShot = new(
        "Mirror Shot", Steel,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, Single, 10,
        noFlag, MirrorShotDesc); //Needs anim
    public static MoveData FlashCannon = new(
        "Flash Cannon", Steel,
        80, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        noFlag, FlashCannonDesc); //Needs anim
    public static MoveData RockClimb = new(
        "Rock Climb", Normal,
        90, 85, 0,
        MoveEffect.Confuse, 20,
        true, Single, 20,
        noFlag, RockClimbDesc); //Needs anim
    public static MoveData Defog = SingleTargetStatusMove(
        "Defog", Flying, 100, 0, MoveEffect.Defog, 15,
        noFlag, DefogDesc); //Needs anim
    public static MoveData TrickRoom = FieldMove(
        "Trick Room", Type.Psychic, -7, MoveEffect.TrickRoom, 5,
        noFlag, TrickRoomDesc); //Neeeds anim
    public static MoveData DracoMeteor = new(
        "Draco Meteor", Dragon,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, DracoMeteorDesc); //Needs anim
    public static MoveData Discharge = new(
        "Discharge", Electric,
        80, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Surrounding, 15,
        noFlag, DischargeDesc); //Needs anim
    public static MoveData LavaPlume = new(
        "Lava Plume", Fire,
        80, 100, 0,
        MoveEffect.Burn, 30,
        false, Surrounding, 15,
        noFlag, LavaPlumeDesc); //Needs anim
    public static MoveData LeafStorm = new(
        "Leaf Storm", Grass,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, LeafStormDesc); //Needs anim
    public static MoveData PowerWhip = SingleTargetNoEffect(
        "Power Whip", Grass, 120, 85, 0, true, 10,
        makesContact, PowerWhipDesc); //Needs anim
    public static MoveData RockWrecker = new(
        "Rock Wrecker", Rock,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        true, Single, 5,
        bulletMove, RockWreckerDesc); //Needs anim
    public static MoveData CrossPoison = new(
        "Cross Poison", Poison,
        70, 100, 0,
        MoveEffect.Poison, 10,
        true, Single, 20,
        makesContact + highCrit, CrossPoisonDesc); //Needs anim
    public static MoveData GunkShot = new(
        "Gunk Shot", Poison,
        120, 80, 0,
        MoveEffect.Poison, 30,
        true, Single, 5,
        noFlag, GunkShotDesc); //Needs anim
    public static MoveData IronHead = new(
        "Iron Head", Steel,
        80, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, IronHeadDesc); //Needs anim
    public static MoveData MagnetBomb = SingleTargetNoEffect(
        "Magnet Bomb", Steel, 60, 101, 0, true, 20,
        bulletMove, MagnetBombDesc); //Needs anim
    public static MoveData StoneEdge = SingleTargetNoEffect(
        "Stone Edge", Rock, 100, 80, 0, true, 5,
        highCrit, StoneEdgeDesc); //Needs anim
    public static MoveData Captivate = SingleTargetStatusMove(
        "Captivate", Normal, 100, 0, MoveEffect.Captivate, 20,
        noFlag, CaptivateDesc); //Needs anim
    public static MoveData StealthRock = FieldMove(
        "Stealth Rock", Rock, 0, MoveEffect.StealthRock, 20,
        magicBounceAffected, StealthRockDesc); //Needs anim 
    public static MoveData GrassKnot = new(
        "Grass Knot", Grass,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        false, Single, 20,
        makesContact, GrassKnotDesc); //Needs anim
    public static MoveData Chatter = new(
        "Chatter", Flying,
        65, 100, 0,
        MoveEffect.Confuse, 100,
        false, Single + Ranged, 20,
        soundMove, ChatterDesc); //Needs anim
    public static MoveData Judgment = new(
        "Judgment", Normal,
        100, 100, 0,
        MoveEffect.Judgement, 0,
        false, Single, 10,
        noFlag, JudgmentDesc); //Needs anim
    public static MoveData BugBite = new(
        "Bug Bite", Bug,
        60, 100, 0,
        MoveEffect.Pluck, 100,
        true, Single, 20,
        makesContact, BugBiteDesc); //Needs anim
    public static MoveData ChargeBeam = new(
        "Charge Beam", Electric,
        50, 90, 0,
        MoveEffect.SpAtkUp1, 70,
        false, Single, 10,
        makesContact, ChargeBeamDesc); //Needs anim
    public static MoveData WoodHammer = new(
        "Wood Hammer", Grass,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, WoodHammerDesc); //Needs anim
    public static MoveData AquaJet = SingleTargetNoEffect(
        "Aqua Jet", Water, 40, 100, 0, true, 20,
        makesContact, AquaJetDesc); //Needs anim
    public static MoveData AttackOrder = SingleTargetNoEffect(
        "Attack Order", Bug, 90, 100, 0, true, 15,
        noFlag, AttackOrderDesc); //Needs anim
    public static MoveData DefendOrder = SelfTargetingMove(
        "Defend Order", Bug, 0, MoveEffect.DefenseSpDefUp1, 10,
        noFlag, DefendOrderDesc); //Needs anim
    public static MoveData HealOrder = SelfTargetingMove(
        "Heal Order", Bug, 0, MoveEffect.Heal50, 10,
        healBlockAffected, HealOrderDesc); //Needs anim. May also be lowered to 5 PP to match Recover
    public static MoveData HeadSmash = new(
        "Head Smash", Rock,
        150, 80, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 5,
        makesContact, HeadSmashDesc); //Needs anim
    public static MoveData DoubleHit = new(
        "Double Hit", Normal,
        35, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 10,
        makesContact, DoubleHitDesc); //Needs anim
    public static MoveData RoarOfTime = new(
        "Roar of Time", Dragon,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, Single, 5,
        noFlag, RoarOfTimeDesc); //Needs anim
    public static MoveData SpacialRend = SingleTargetNoEffect(
        "Spacial Rend", Dragon, 100, 95, 0, false, 5,
        highCrit, SpacialRendDesc); //Needs anim
    public static MoveData LunarDance = SelfTargetingMove(
        "Lunar Dance", Type.Psychic, 0, MoveEffect.HealingWish, 10,
        snatchAffected + healBlockAffected, LunarDanceDesc); //Needs anim
    public static MoveData CrushGrip = new(
        "Crush Grip", Normal,
        120, 100, 0,
        MoveEffect.TargetHealthPower, 0,
        true, Single, 5,
        makesContact, LunarDanceDesc); //Needs anim
    public static MoveData MagmaStorm = new(
        "Magma Storm", Fire,
        100, 75, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 5,
        noFlag, MagmaStormDesc); //Needs anim
    public static MoveData DarkVoid = new(
        "Dark Void", Dark,
        0, 50, 0,
        MoveEffect.Sleep, 100,
        false, SpreadMove, 10,
        magicBounceAffected, DarkVoidDesc); //Needs anim
    public static MoveData SeedFlare = new(
        "Seed Flare", Grass,
        120, 85, 0,
        MoveEffect.SpDefDown2, 40,
        false, Single, 5,
        noFlag, SeedFlareDesc); //Needs anim
    public static MoveData OminousWind = new(
        "Ominous Wind", Ghost,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5,
        effectOnSelfOnly, OminousWindDesc); //Needs anim
    public static MoveData ShadowForce = new(
        "Shadow Force", Ghost,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5,
        noFlag, ShadowForceDesc); //Needs anim

    //Gen 5
    public static MoveData HoneClaws = SelfTargetingMove(
        "Hone Claws", Dark, 0, MoveEffect.AttackAccuracyUp1, 15,
        snatchAffected, HoneClawsDesc); //Needs anim
    public static MoveData WideGuard = SelfTargetingMove(
        "Wide Guard", Rock, 3, MoveEffect.WideGuard, 10,
        snatchAffected + incrementsProtectCounter, WideGuardDesc); //Needs anim
    public static MoveData GuardSplit = SingleTargetStatusMove(
        "Guard Split", Type.Psychic, 101, 0, MoveEffect.GuardSplit, 10,
        noFlag, GuardSplitDesc); //Needs anim
    public static MoveData PowerSplit = SingleTargetStatusMove(
        "Power Split", Type.Psychic, 101, 0, MoveEffect.PowerSplit, 10,
        noFlag, PowerSplitDesc); //Needs anim
    public static MoveData WonderRoom = FieldMove(
        "Wonder Room", Type.Psychic, 0, MoveEffect.WonderRoom, 10,
        noFlag, WonderRoomDesc); //Needs anim
    public static MoveData Psyshock = new(
        "Psyshock", Type.Psychic,
        80, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, PsyshockDesc); //Needs anim
    public static MoveData Venoshock = new(
        "Venoshock", Poison,
        65, 100, 0,
        MoveEffect.Venoshock, 0,
        false, Single, 10,
        noFlag, VenoshockDesc); //Needs anim
    public static MoveData Autotomize = SelfTargetingMove(
        "Autotomize", Steel, 0, MoveEffect.Autotomize, 15,
        snatchAffected, AutotomizeDesc); //Needs anim
    public static MoveData RagePowder = SelfTargetingMove(
        "Rage Powder", Bug, 2, MoveEffect.RagePowder, 20,
        noFlag, RagePowderDesc); //Needs anim; the powder move check is handled in Battle.cs
    public static MoveData Telekinesis = SingleTargetStatusMove(
        "Telekinesis", Type.Psychic, 101, 0, MoveEffect.Telekinesis, 15,
        magicBounceAffected, TelekinesisDesc); //Needs anim
    public static MoveData MagicRoom = FieldMove(
        "Magic Room", Type.Psychic, 0, MoveEffect.MagicRoom, 10,
        noFlag, MagicRoomDesc); //Needs anim
    public static MoveData SmackDown = new(
        "Smack Down", Rock,
        50, 100, 0,
        MoveEffect.SmackDown, 100,
        true, Single, 15,
        noFlag, SmackDownDesc); //Needs anim
    public static MoveData StormThrow = new(
        "Storm Throw", Fighting,
        60, 100, 0,
        MoveEffect.AlwaysCrit, 0,
        true, Single, 10,
        makesContact, StormThrowDesc); //Needs anim
    public static MoveData FlameBurst = new(
        "Flame Burst", Fire,
        70, 100, 0,
        MoveEffect.FlameBurst, 100,
        false, Single, 15,
        noFlag, FlameBurstDesc); //Needs anim
    public static MoveData SludgeWave = new(
        "Sludge Wave", Poison,
        95, 100, 0,
        MoveEffect.Poison, 10,
        false, Surrounding, 10,
        noFlag, SludgeWaveDesc); //Needs anim
    public static MoveData QuiverDance = SelfTargetingMove(
        "Quiver Dance", Bug, 0, MoveEffect.SpAtkSpDefSpeedUp1, 20,
        snatchAffected, QuiverDanceDesc); //Needs anim
    public static MoveData HeavySlam = new(
        "Heavy Slam", Steel,
        1, 100, 0,
        MoveEffect.RelativeWeightPower, 0,
        true, Single, 10,
        makesContact, HeavySlamDesc); //Needs anim
    public static MoveData Synchronoise = new(
        "Synchronoise", Type.Psychic,
        120, 100, 0,
        MoveEffect.Synchronoise, 0,
        false, Surrounding, 10,
        noFlag, SynchronoiseDesc); //Needs anim
    public static MoveData ElectroBall = new(
        "Electro Ball", Electric,
        1, 100, 0,
        MoveEffect.HighSpeedPower, 0,
        false, Single, 10,
        noFlag, ElectroBallDesc); //Needs anim
    public static MoveData Soak = SingleTargetStatusMove(
        "Soak", Water, 100, 0, MoveEffect.Soak, 20,
        magicBounceAffected, SoakDesc); //Needs anim
    public static MoveData FlameCharge = new(
        "Flame Charge", Fire,
        50, 100, 0,
        MoveEffect.SpeedUp1, 100,
        true, Single, 20,
        makesContact + effectOnSelfOnly, FlameChargeDesc); //Needs anim
    public static MoveData Coil = SelfTargetingMove(
        "Coil", Poison, 0, MoveEffect.AttackDefAccUp1, 20,
        snatchAffected, CoilDesc); //Needs anim
    public static MoveData LowSweep = new(
        "Low Sweep", Fighting,
        65, 100, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 20,
        makesContact, LowSweepDesc); //Needs anim
    public static MoveData AcidSpray = new(
        "Acid Spray", Poison,
        40, 100, 0,
        MoveEffect.SpDefDown2, 101,
        false, Single, 20,
        bulletMove, AcidSprayDesc); //Needs anim
    public static MoveData FoulPlay = new(
        "Foul Play", Dark,
        95, 100, 0,
        MoveEffect.FoulPlay, 0,
        true, Single, 15,
        makesContact, FoulPlayDesc); //Needs anim
    public static MoveData SimpleBeam = SingleTargetStatusMove(
        "Simple Beam", Normal, 100, 0, MoveEffect.SimpleBeam, 15,
        magicBounceAffected, SimpleBeamDesc); //Needs anim
    public static MoveData Entrainment = SingleTargetStatusMove(
        "Entrainment", Normal, 100, 0, MoveEffect.Entrainment, 15,
        magicBounceAffected, EntrainmentDesc); //Needs anim
    public static MoveData AfterYou = SingleTargetStatusMove(
        "After You", Normal, 101, 0, MoveEffect.AfterYou, 15,
        noFlag, AfterYouDesc); //Needs anim
    public static MoveData Round = new(
        "Round", Normal,
        60, 100, 0,
        MoveEffect.Round, 101,
        false, Single, 15,
        soundMove, RoundDesc); //Needs anim
    public static MoveData EchoedVoice = new(
        "Echoed Voice", Normal,
        40, 100, 0,
        MoveEffect.EchoedVoice, 0,
        false, Single, 15,
        soundMove, EchoedVoiceDesc); //Needs anim
    public static MoveData ChipAway = new(
        "Chip Away", Normal,
        70, 100, 0,
        MoveEffect.IgnoreDefenseStage, 0,
        true, Single, 20,
        makesContact, ChipAwayDesc); //Needs anim
    public static MoveData ClearSmog = new(
        "Clear Smog", Poison,
        50, 101, 0,
        MoveEffect.ClearStats, 100,
        false, Single, 15,
        noFlag, ClearSmogDesc); //Needs anim
    public static MoveData StoredPower = new(
        "Stored Power", Type.Psychic,
        20, 100, 0,
        MoveEffect.UserStatPower, 0,
        false, Single, 10,
        noFlag, StoredPowerDesc); //Needs anim
    public static MoveData QuickGuard = SelfTargetingMove(
        "Quick Guard", Fighting, 3, MoveEffect.QuickGuard, 15,
        snatchAffected, QuickGuardDesc); //Needs anim
    public static MoveData AllySwitch = new(
        "Ally Switch", Type.Psychic,
        0, 101, 0,
        MoveEffect.AllySwitch, 101,
        false, Ally, 15,
        usesProtectCounter, AllySwitchDesc); //Needs anim
    public static MoveData Scald = new(
        "Scald", Water,
        80, 100, 0,
        MoveEffect.Burn, 30,
        false, Single, 15,
        noFlag, ScaldDesc); //Needs anim
    public static MoveData ShellSmash = SelfTargetingMove(
        "Shell Smash", Normal, 0, MoveEffect.ShellSmash, 15,
        snatchAffected, ShellSmashDesc); //Needs anim
    public static MoveData HealPulse = SingleTargetStatusMove(
        "Heal Pulse", Type.Psychic, 101, 0, MoveEffect.HealPulse, 10,
        healBlockAffected, HealPulseDesc); //Needs anim
    public static MoveData Hex = new(
        "Hex", Ghost,
        65, 100, 0,
        MoveEffect.Hex, 0,
        false, Single, 10,
        noFlag, HexDesc); //Needs anim
    public static MoveData SkyDrop = new(
        "Sky Drop", Flying,
        60, 101, 0,
        MoveEffect.SkyDrop, 101,
        true, Single, 10,
        noFlag, SkyDropDesc); //Needs anim
    public static MoveData ShiftGear = SelfTargetingMove(
        "Shift Gear", Steel, 0, MoveEffect.AttackUp1SpeedUp2, 10,
        snatchAffected, ShiftGearDesc); //Needs anim
    public static MoveData CircleThrow = new(
        "Circle Throw", Fighting,
        60, 90, -6,
        MoveEffect.ForcedSwitch, 101,
        true, Single, 10,
        makesContact, CircleThrowDesc); //Needs anim
    public static MoveData Incinerate = new(
        "Incinerate", Fire,
        60, 100, 0,
        MoveEffect.Incinerate, 100,
        false, Spread + Opponent, 15,
        noFlag, IncinerateDesc); //Needs anim
    public static MoveData Quash = SingleTargetStatusMove(
        "Quash", Dark, 100, 0, MoveEffect.Quash, 15,
        noFlag, QuashDesc); //Needs anim
    public static MoveData Acrobatics = new(
        "Acrobatics", Flying,
        55, 100, 0,
        MoveEffect.Acrobatics, 0,
        true, Single, 15,
        makesContact, AcrobaticsDesc); //Needs anim
    public static MoveData ReflectType = SingleTargetStatusMove(
        "Reflect Type", Normal, 101, 0, MoveEffect.ReflectType, 15,
        noFlag, ReflectTypeDesc); //Needs anim
    public static MoveData Retaliate = new(
        "Retaliate", Normal,
        70, 100, 0,
        MoveEffect.Retaliate, 0,
        true, Single, 5,
        makesContact, RetaliateDesc); //Needs anim
    public static MoveData FinalGambit = new(
        "Final Gambit", Fighting,
        1, 100, 0,
        MoveEffect.FinalGambit, 0,
        false, Single, 5,
        noFlag, FinalGambitDesc); //Needs anim
    public static MoveData Bestow = SingleTargetStatusMove(
        "Bestow", Normal, 101, 0, MoveEffect.Bestow, 15, noFlag, BestowDesc); //Needs anim
    public static MoveData Inferno = new(
        "Inferno", Fire,
        100, 50, 0,
        MoveEffect.Burn, 100,
        false, Single, 5,
        noFlag, InfernoDesc); //Needs anim
    public static MoveData WaterPledge = new(
        "Water Pledge", Water,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, WaterPledgeDesc); //Needs anim
    public static MoveData FirePledge = new(
        "Fire Pledge", Fire,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, FirePledgeDesc); //Needs anim
    public static MoveData GrassPledge = new(
        "Grass Pledge", Grass,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, GrassPledgeDesc); //Needs anim
    //Todo: Test Pledge moves once double battles are working
    public static MoveData VoltSwitch = new(
        "Volt Switch", Electric,
        70, 100, 0,
        MoveEffect.SwitchHit, 100,
        false, Single, 20,
        noFlag, VoltSwitchDesc); //Needs anim
    public static MoveData StruggleBug = new(
        "Struggle Bug", Bug,
        50, 100, 0,
        MoveEffect.SpAtkDown1, 101,
        false, SpreadMove, 20,
        noFlag, StruggleBugDesc); //Needs anim
    public static MoveData Bulldoze = new(
        "Bulldoze", Ground,
        60, 100, 0,
        MoveEffect.SpeedDown1, 101,
        true, Surrounding, 20,
        noFlag, BulldozeDesc); //Needs anim
    public static MoveData FrostBreath = new(
        "Frost Breath", Ice,
        60, 90, 0,
        MoveEffect.AlwaysCrit, 0,
        false, Single, 10,
        noFlag, FrostBreathDesc); //Needs anim
    public static MoveData DragonTail = new(
        "Dragon Tail", Dragon,
        60, 90, -6,
        MoveEffect.ForcedSwitch, 101,
        true, Single, 10,
        makesContact, DragonTailDesc); //Needs anim
    public static MoveData WorkUp = SelfTargetingMove(
        "Work Up", Normal, 0, MoveEffect.AttackSpAtkUp1, 30,
        snatchAffected, WorkUpDesc); //Needs anim
    public static MoveData Electroweb = new(
        "Electroweb", Electric,
        55, 95, 0,
        MoveEffect.SpeedDown1, 101,
        false, SpreadMove, 15,
        noFlag, ElectrowebDesc); //Needs anim
    public static MoveData WildCharge = new(
        "Wild Charge", Electric,
        90, 100, 0,
        MoveEffect.Recoil25, 101,
        true, Single, 15,
        makesContact, WildChargeDesc); //Needs anim
    public static MoveData DrillRun = new(
        "Drill Run", Ground,
        80, 95, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact + highCrit, DrillRunDesc); //Needs anim
    public static MoveData DualChop = new(
        "Dual Chop", Dragon,
        40, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 15,
        makesContact, DualChopDesc); //Needs anim
    public static MoveData HeartStamp = new(
        "Heart Stamp", Type.Psychic,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 25,
        makesContact, HeartStampDesc); //Needs anim
    public static MoveData HornLeech = new(
        "Horn Leech", Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        true, Single, 10,
        makesContact + healBlockAffected, HornLeechDesc); //Needs anim
    public static MoveData SacredSword = new(
        "Sacred Sword", Fighting,
        90, 100, 0,
        MoveEffect.IgnoreDefenseStage, 0,
        true, Single, 15,
        makesContact + sharpnessBoosted, SacredSwordDesc); //Needs anim
    public static MoveData RazorShell = new(
        "Razor Shell", Water,
        75, 95, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 10,
        makesContact + sharpnessBoosted, RazorShellDesc); //Needs anim
    public static MoveData HeatCrash = new(
        "Heat Crash", Fire,
        1, 100, 0,
        MoveEffect.RelativeWeightPower, 0,
        true, Single, 10,
        makesContact, HeatCrashDesc); //Needs anim
    public static MoveData LeafTornado = new(
        "Leaf Tornado", Grass,
        65, 90, 0,
        MoveEffect.AccuracyDown1, 50,
        false, Single, 10,
        noFlag, LeafTornadoDesc); //Needs anim
    public static MoveData Steamroller = new(
        "Steamroller", Bug,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 20,
        makesContact, SteamrollerDesc); //Needs anim
    public static MoveData CottonGuard = SelfTargetingMove(
        "Cotton Guard", Grass, 0, MoveEffect.DefenseUp3, 10,
        snatchAffected, CottonGuardDesc); //Needs anim
    public static MoveData NightDaze = new(
        "Night Daze", Dark,
        85, 95, 0,
        MoveEffect.AccuracyDown1, 40,
        false, Single, 10,
        noFlag, NightDazeDesc); //Needs anim
    public static MoveData Psystrike = new(
        "Psystrike", Type.Psychic,
        100, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, PsystrikeDesc); //Needs anim
    public static MoveData TailSlap = new(
        "Tail Slap", Normal,
        25, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        makesContact, TailSlapDesc); //Needs anim
    public static MoveData Hurricane = new(
        "Hurricane", Flying,
        110, 70, 0,
        MoveEffect.Confuse, 30,
        false, Single + Ranged, 10,
        alwaysHitsInRain + windMove, HurricaneDesc); //Needs anim
    public static MoveData HeadCharge = new(
        "Head Charge", Normal,
        120, 100, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 15,
        makesContact, HeadChargeDesc); //Needs anim
    public static MoveData GearGrind = new(
        "Gear Grind", Steel,
        50, 85, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 15,
        makesContact, GearGrindDesc); //Needs anim
    public static MoveData SearingShot = new(
        "Searing Shot", Fire,
        100, 100, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        bulletMove, SearingShotDesc); //Needs anim
    public static MoveData TechnoBlast = new(
        "Techno Blast", Normal,
        120, 100, 0,
        MoveEffect.TechnoBlast, 0,
        false, Single, 5,
        noFlag, TechnoBlastDesc); //Needs anim
    public static MoveData RelicSong = new(
        "Relic Song", Normal,
        75, 100, 0,
        MoveEffect.Sleep, 10,
        false, SpreadMove, 10,
        soundMove, RelicSongDesc); //Needs anim; Todo: Meloetta's form change
    public static MoveData SecretSword = new(
        "Secret Sword", Fighting,
        85, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, SecretSwordDesc); //Needs anim; Todo: Keldeo's form change
    public static MoveData Glaciate = new(
        "Glaciate", Ice,
        65, 95, 0,
        MoveEffect.SpeedDown1, 101,
        false, SpreadMove, 10,
        noFlag, GlaciateDesc); //Needs anim
    public static MoveData BoltStrike = new(
        "Bolt Strike", Electric,
        130, 85, 0,
        MoveEffect.Paralyze, 20,
        true, Single, 5,
        makesContact, BoltStrikeDesc); //Needs anim
    public static MoveData BlueFlare = new(
        "Blue Flare", Fire,
        130, 85, 0,
        MoveEffect.Burn, 20,
        false, Single, 5,
        noFlag, BlueFlareDesc); //Needs anim
    public static MoveData FieryDance = new(
        "Fiery Dance", Fire,
        80, 100, 0,
        MoveEffect.SpAtkUp1, 50,
        false, Single, 10,
        effectOnSelfOnly, FieryDanceDesc); //Needs anim
    public static MoveData FreezeShock = new(
        "Freeze Shock", Ice,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5,
        noFlag, FreezeShockDesc); //Needs anim
    public static MoveData IceBurn = new(
        "Ice Burn", Ice,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        false, Single, 5,
        noFlag, IceBurnDesc); //Needs anim
    public static MoveData Snarl = new(
        "Snarl", Dark,
        55, 95, 0,
        MoveEffect.SpAtkDown1, 101,
        false, SpreadMove, 15,
        soundMove, SnarlDesc); //Needs anim
    public static MoveData IcicleCrash = new(
        "Icicle Crash", Ice,
        85, 90, 0,
        MoveEffect.Flinch, 30,
        true, Single, 10,
        noFlag, IcicleCrashDesc); //Needs anim
    public static MoveData VCreate = new(
        "V-Create", Fire,
        180, 95, 0,
        MoveEffect.DefSpDefSpeedDown1, 101,
        true, Single, 5,
        effectOnSelfOnly + makesContact, VCreateDesc); //Needs anim
    public static MoveData FusionFlare = new(
        "Fusion Flare", Fire,
        100, 100, 0,
        MoveEffect.FusionFlare, 0,
        false, Single, 5,
        noFlag, FusionFlareDesc); //Needs anims (with check for Fusion Bolt)
    public static MoveData FusionBolt = new(
        "Fusion Bolt", Electric,
        100, 100, 0,
        MoveEffect.FusionBolt, 0,
        true, Single, 5,
        noFlag, FusionBoltDesc); //Needs anims (with check for Fusion Flare)
    public static MoveData FlyingPress = new(
        "Flying Press", Fighting,
        100, 95, 0,
        MoveEffect.FlyingPress, 0,
        true, Single, 10,
        gravityDisabled + makesContact, FlyingPressDesc); //Needs anim
    public static MoveData MatBlock = SelfTargetingMove(
        "Mat Block", Fighting, 0, MoveEffect.MatBlock, 10, snatchAffected, MatBlockDesc); //Needs anim
    public static MoveData Belch = new(
        "Belch", Poison,
        120, 90, 0,
        MoveEffect.Belch, 0,
        false, Single, 10,
        noFlag, BelchDesc); //Needs anim
    public static MoveData Rototiller = new(
        "Rototiller", Ground,
        0, 101, 0,
        MoveEffect.Rototiller, 101,
        false, All, 10,
        noFlag, RototillerDesc); //Needs anim
    public static MoveData StickyWeb = FieldMove(
        "Sticky Web", Bug, 0, MoveEffect.StickyWeb, 20, magicBounceAffected, StickyWebDesc); //Needs anim
    public static MoveData FellStinger = new(
        "Fell Stinger", Bug,
        50, 100, 0,
        MoveEffect.FellStinger, 0,
        true, Single, 25, //Fell Stinger doesn't have effectOnSelfOnly because it's handled at end of move like recoil
        makesContact, FellStingerDesc); //Needs anim
    public static MoveData PhantomForce = new(
        "Phantom Force", Ghost,
        90, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        noFlag, PhantomForceDesc); //Needs anim
    public static MoveData TrickOrTreat = SingleTargetStatusMove(
        "Trick-or-Treat", Ghost, 100, 0, MoveEffect.TrickOrTreat, 20, magicBounceAffected,
        TrickOrTreatDesc); //Needs anim
    public static MoveData NobleRoar = SingleTargetStatusMove(
        "Noble Roar", Normal, 100, 0, MoveEffect.AttackSpAtkDown1, 30,
        soundMove + magicBounceAffected, NobleRoarDesc); //Needs anim
    public static MoveData IonDeluge = FieldMove(
        "Ion Deluge", Electric, 1, MoveEffect.IonDeluge, 25, noFlag, IonDelugeDesc); //Needs anim
    public static MoveData ParabolicCharge = new(
        "Parabolic Charge", Electric,
        65, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Surrounding, 20,
        noFlag, ParabolicChargeDesc); //Needs anim
    public static MoveData ForestsCurse = SingleTargetStatusMove(
        "Forest's Curse", Grass, 100, 0, MoveEffect.ForestsCurse, 20, magicBounceAffected,
        ForestsCurseDesc); //Needs anim
    public static MoveData PetalBlizzard = new(
        "Petal Blizzard", Grass,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, Surrounding, 15,
        windMove, PetalBlizzardDesc); //Needs anim
    public static MoveData FreezeDry = new(
        "Freeze-Dry", Ice,
        70, 100, 0,
        MoveEffect.FreezeDry, 10,
        false, Single, 20,
        noFlag, FreezeShockDesc); //Needs anim
    public static MoveData DisarmingVoice = new(
        "Disarming Voice", Fairy,
        40, 101, 0,
        MoveEffect.Hit, 0,
        false, Spread + Opponent, 15,
        soundMove, DisarmingVoiceDesc); //Needs anim
    public static MoveData PartingShot = SingleTargetStatusMove(
        "Parting Shot", Dark, 100, 0, MoveEffect.PartingShot, 20,
        soundMove + magicBounceAffected, PartingShotDesc); //Needs anim
    public static MoveData TopsyTurvy = SingleTargetStatusMove(
        "Topsy-Turvy", Dark, 101, 0, MoveEffect.TopsyTurvy, 20,
        magicBounceAffected, TopsyTurvyDesc); //Needs anim
    public static MoveData DrainingKiss = new(
        "Draining Kiss", Fairy,
        50, 100, 0,
        MoveEffect.Absorb75, 100,
        false, Single, 10,
        makesContact, DrainingKissDesc); //Needs anim
    public static MoveData CraftyShield = SelfTargetingMove(
        "Crafty Shield", Fairy, 3, MoveEffect.CraftyShield, 10, noFlag,
        CraftyShieldDesc); //Needs anim
    public static MoveData FlowerShield = new(
        "Flower Shield", Fairy,
        0, 101, 0,
        MoveEffect.FlowerShield, 101,
        false, All, 10,
        noFlag, FlowerShieldDesc); //Needs anim
    public static MoveData GrassyTerrain = FieldMove(
        "Grassy Terrain", Grass, 0, MoveEffect.GrassyTerrain, 10,
        noFlag, GrassyTerrainDesc); //Needs anim
    public static MoveData MistyTerrain = FieldMove(
        "Misty Terrain", Fairy, 0, MoveEffect.MistyTerrain, 10,
        noFlag, MistyTerrainDesc); //Needs anim
    public static MoveData Electrify = SingleTargetStatusMove(
        "Electrify", Electric, 101, 0, MoveEffect.Electrify, 20, noFlag, ElectrifyDesc); //Needs anim
    public static MoveData PlayRough = new(
        "Play Rough", Fairy,
        90, 90, 0,
        MoveEffect.AttackDown1, 10,
        true, Single, 10,
        makesContact, PlayRoughDesc); //Needs anim
    public static MoveData FairyWind = SingleTargetNoEffect(
        "Fairy Wind", Fairy, 40, 100, 0, false, 30, windMove, FairyWindDesc); //Needs anim
    public static MoveData Moonblast = new(
        "Moonblast", Fairy,
        95, 100, 0,
        MoveEffect.SpAtkDown1, 30,
        false, Single, 15,
        noFlag, MoonblastDesc); //Needs anim
    public static MoveData Boomburst = new(
        "Boomburst", Normal,
        140, 100, 0,
        MoveEffect.Hit, 0,
        false, Surrounding, 10,
        soundMove, BoomburstDesc); //Needs anim
    public static MoveData FairyLock = FieldMove(
        "Fairy Lock", Fairy, 0, MoveEffect.FairyLock, 10, noFlag, FairyLockDesc); //Needs anim
    public static MoveData KingsShield = SelfTargetingMove(
        "King's Shield", Steel, 4, MoveEffect.KingsShield, 10,
        usesProtectCounter, KingsShieldDesc); //Needs anim
    public static MoveData PlayNice = SingleTargetStatusMove(
        "Play Nice", Normal, 101, 0, MoveEffect.AttackDown1, 20,
        magicBounceAffected, PlayNiceDesc); //Needs anim
    public static MoveData Confide = SingleTargetStatusMove(
        "Confide", Normal, 101, 0, MoveEffect.SpAtkDown1, 20,
        magicBounceAffected + soundMove, ConfideDesc); //Needs anim
    public static MoveData DiamondStorm = new(
        "Diamond Storm", Rock,
        100, 95, 0,
        MoveEffect.DiamondStorm, 100,
        true, SpreadMove, 5,
        effectOnSelfOnly, DiamondStormDesc); //Needs anim
    public static MoveData SteamEruption = new(
        "Steam Eruption", Water,
        110, 95, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        noFlag, SteamEruptionDesc); //Needs anim
    public static MoveData HyperspaceHole = new(
        "Hyperspace Hole", Type.Psychic,
        80, 101, 0,
        MoveEffect.Feint, 100,
        false, Single, 5,
        noFlag, HyperspaceHoleDesc); //Needs anim
    public static MoveData WaterShuriken = new(
        "Water Shuriken", Water,
        15, 100, 1,
        MoveEffect.MultiHit2to5, 0,
        false, Single, 20,
        noFlag, WaterShurikenDesc); //Needs anim
    public static MoveData MysticalFire = new(
        "Mystical Fire", Fire,
        75, 100, 0,
        MoveEffect.SpAtkDown1, 101,
        false, Single, 10,
        noFlag, MysticalFireDesc); //Needs anim
    public static MoveData SpikyShield = SelfTargetingMove(
        "Spiky Shield", Grass, 4, MoveEffect.SpikyShield, 10,
        noFlag, SpikyShieldDesc); //Needs anim
    public static MoveData AromaticMist = new(
        "Aromatic Mist", Fairy,
        0, 101, 0,
        MoveEffect.SpDefUp1, 101,
        false, Ally, 20,
        noFlag, AromaticMistDesc); //Needs anim
    public static MoveData EerieImpulse = SingleTargetStatusMove(
        "Eerie Impulse", Electric, 100, 0, MoveEffect.SpAtkDown2, 15,
        magicBounceAffected, EerieImpulseDesc); //Needs anim
    public static MoveData VenomDrench = new(
        "VenomDrench", Poison,
        0, 100, 0,
        MoveEffect.VenomDrench, 101,
        false, SpreadMove, 20,
        magicBounceAffected, VenomDrenchDesc); //Needs anim
    public static MoveData Powder = SingleTargetStatusMove(
        "Powder", Bug, 100, 1, MoveEffect.Powder, 20,
        magicBounceAffected + powderMove, PowderDesc); //Needs anim
    public static MoveData Geomancy = SelfTargetingMove(
        "Geomancy", Fairy, 0, MoveEffect.ChargingAttack, 10,
        noFlag, GeomancyDesc); //Needs anim
    public static MoveData MagneticFlux = new(
        "Magnetic Flux", Electric,
        0, 101, 0,
        MoveEffect.MagneticFlux, 101,
        false, Self + Ally + Ranged, 20,
        snatchAffected, MagneticFluxDesc); //Needs anim
    public static MoveData HappyHour = FieldMove(
        "Happy Hour", Normal, 0, MoveEffect.HappyHour, 30,
        noFlag, HappyHourDesc); //Needs anim
    public static MoveData ElectricTerrain = FieldMove(
        "Electric Terrain", Electric, 0, MoveEffect.ElectricTerrain, 10,
        noFlag, ElectricTerrainDesc); //Needs anim
    public static MoveData DazzlingGleam = new(
        "Dazzling Gleam", Fairy,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        noFlag, DazzlingGleamDesc); //Needs anim
    public static MoveData Celebrate = SelfTargetingMove(
        "Celebrate", Normal, 0, MoveEffect.None, 40, noFlag, CelebrateDesc); //Needs anim
    public static MoveData HoldHands = new(
        "Hold Hands", Normal,
        0, 101, 0,
        MoveEffect.None, 101,
        false, Ally, 40,
        noFlag, HoldHandsDesc); //Needs anim
    public static MoveData BabyDollEyes = SingleTargetStatusMove(
        "Baby-Doll Eyed", Fairy, 100, 1, MoveEffect.AttackDown1, 30,
        magicBounceAffected, BabyDollEyesDesc); //Needs anim
    public static MoveData Nuzzle = new(
        "Nuzzle", Electric,
        20, 100, 0,
        MoveEffect.Paralyze, 101,
        true, Single, 20,
        makesContact, NuzzleDesc); //Needs anim
    public static MoveData HoldBack = new(
        "Hold Back", Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, Single, 40,
        makesContact, HoldBackDesc); //Needs anim
    public static MoveData Infestation = new(
        "Infestation", Bug,
        20, 100, 0,
        MoveEffect.ContinuousDamage, 101,
        false, Single, 20,
        makesContact, InfestationDesc); //Needs anim
    public static MoveData PowerUpPunch = new(
        "Power-Up Punch", Fighting,
        40, 100, 0,
        MoveEffect.AttackUp1, 101,
        true, Single, 20,
        makesContact + effectOnSelfOnly, PowerUpPunchDesc); //Needs anim
    public static MoveData OblivionWing = new(
        "Oblivion Wing", Flying,
        80, 100, 0,
        MoveEffect.Absorb75, 101,
        false, Single + Ranged, 10,
        healBlockAffected, OblivionWingDesc); //Needs anim
    public static MoveData ThousandArrows = new(
        "Thousand Arrows", Ground,
        90, 100, 0,
        MoveEffect.ThousandArrows, 101,
        true, SpreadMove, 10,
        noFlag, ThousandArrowsDesc); //Needs anim
    public static MoveData ThousandWaves = new(
        "Thousand Waves", Ground,
        90, 100, 0,
        MoveEffect.Trap, 101,
        true, SpreadMove, 10,
        noFlag, ThousandWavesDesc); //Needs anim
    public static MoveData LandsWrath = new(
        "Land's Wrath", Ground,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 10,
        noFlag, LandsWrathDesc); //Needs anim
    public static MoveData LightOfRuin = new(
        "Light of Ruin", Fairy,
        140, 90, 0,
        MoveEffect.Recoil50, 0,
        false, Single, 5,
        noFlag, LightOfRuinDesc); //Needs anim
    public static MoveData OriginPulse = new(
        "Origin Pulse", Water,
        110, 85, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        megaLauncherBoosted, OriginPulseDesc); //Needs anim
    public static MoveData PrecipiceBlades = new(
        "Precipice Blades", Ground,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 10,
        noFlag, PrecipiceBladesDesc); //Needs anim
    public static MoveData DragonAscent = new(
        "Dragon Ascent", Flying,
        120, 100, 0,
        MoveEffect.DefenseSpDefDown1, 101,
        true, Single, 5,
        effectOnSelfOnly, DragonAscentDesc); //Needs anim
    public static MoveData HyperspaceFury = new(
        "Hyperspace Fury", Dark,
        100, 101, 0,
        MoveEffect.HyperspaceFury, 101,
        true, Single, 5,
        noFlag, HyperspaceFuryDesc); //Needs anim


    //Non-standard moves
    public static MoveData ConfusionHit = new(
        "a move it shouldn't be able to! (ConfusionHit) [Error 101]", Typeless,
        40, 101, 0,
        MoveEffect.Hit, 0,
        true, Self, 0,
        mimicBypass, InvalidMove);
    public static MoveData Recharge = new(
        "a move it shouldn't be able to! (Recharge) [Error 101]", Typeless,
        0, 0, 0,
        MoveEffect.None, 0,
        false, 0, 0,
        mimicBypass, InvalidMove);
    public static MoveData RazorWindAttack = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass, InvalidMove); //Needs anim
    public static MoveData DigAttack = new(
        "Dig", Ground,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass + makesContact, InvalidMove); //Needs anim
    public static MoveData FlyAttack = new(
        "Fly", Flying,
        90, 95, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass + makesContact, InvalidMove); //Needs anim
    public static MoveData SolarBeamAttack = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 0,
        halfPowerInBadWeather + mimicBypass, InvalidMove); //Needs anim
    public static MoveData SkyAttackAttack = new(
        "Sky Attack", Flying,
        140, 90, 0,
        MoveEffect.Flinch, 30,
        true, Single, 5,
        highCrit + mimicBypass, InvalidMove);
    public static MoveData SkullBashAttack = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, InvalidMove); //Needs anim
    public static MoveData BideMiddle = new(
        "Bide", Typeless,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Target.None, 0,
        mimicBypass, InvalidMove); //Needs anim);
    public static MoveData BideAttack = new(
        "Bide", Typeless,
        1, 100, 0,
        MoveEffect.BideHit, 0,
        false, Opponent, 0,
        mimicBypass + makesContact, InvalidMove); //Needs anim
    public static MoveData FocusPunchAttack = new(
        "Focus Punch", Fighting,
        150, 100, -3,
        MoveEffect.FocusPunchAttack, 0,
        true, Single, 20,
        makesContact + punchMove, InvalidMove); //Needs anim
    public static MoveData DiveAttack = new(
        "Dive", Water,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, InvalidMove); //Needs anim
    public static MoveData BounceAttack = new(
        "Bounce", Flying,
        85, 85, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 5,
        makesContact, InvalidMove); //Needs anim
    public static MoveData ShadowForceAttack = new(
        "Shadow Force", Ghost,
        120, 100, 0,
        MoveEffect.Feint, 100,
        true, Single, 5,
        mimicBypass + makesContact, InvalidMove); //Needs anim
    public static MoveData SkyDropAttack = new(
        "Sky Drop", Flying,
        60, 100, 0,
        MoveEffect.SkyDropHit, 0,
        true, Single, 10,
        makesContact, InvalidMove); //Needs anim
    public static MoveData RainbowPledge = new(
        "Water Pledge", Water,
        150, 100, 0,
        MoveEffect.Rainbow, 100,
        false, Single, 10,
        effectOnSelfOnly, InvalidMove); //Needs anim
    public static MoveData SwampPledge = new(
        "Grass Pledge", Grass,
        150, 100, 0,
        MoveEffect.Swamp, 100,
        false, Single, 10,
        noFlag, InvalidMove); //Needs anim
    public static MoveData BurningFieldPledge = new(
        "Fire Pledge", Fire,
        150, 100, 0,
        MoveEffect.BurningField, 100,
        false, Single, 10,
        noFlag, InvalidMove); //Needs anim
    public static MoveData FreezeShockAttack = new(
        "Freeze Shock", Ice,
        140, 90, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 5,
        noFlag, InvalidMove); //Needs anim
    public static MoveData IceBurnAttack = new(
        "Ice Burn", Ice,
        140, 90, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        noFlag, InvalidMove); //Needs anim
    public static MoveData PhantomForceAttack = new(
        "Phantom Force", Ghost,
        90, 100, 0,
        MoveEffect.Feint, 100,
        true, Single, 5,
        mimicBypass + makesContact, InvalidMove); //Needs anim
    public static MoveData GeomancyExecution = SelfTargetingMove(
        "Geomancy", Fairy, 0, MoveEffect.SpAtkSpDefSpeedUp2, 10,
        noFlag, InvalidMove); //Needs anim
    public static MoveData Struggle = new(
        "Struggle", Typeless,
        50, 100, 0,
        MoveEffect.Recoil25Max, 100,
        true, Single, 0,
        cannotMimic, StruggleDesc);


    public static MoveData[] MoveTable = new MoveData[(int)MoveID.Count] {
        None,

        //Gen 1
        Pound,
        KarateChop,
        DoubleSlap,
        CometPunch,
        MegaPunch,
        PayDay,
        FirePunch,
        IcePunch,
        ThunderPunch,
        Scratch,
        ViseGrip,
        Guillotine,
        RazorWind,
        SwordsDance,
        Cut,
        Gust,
        WingAttack,
        Whirlwind,
        Fly,
        Bind,
        Slam,
        VineWhip,
        Stomp,
        DoubleKick,
        MegaKick,
        JumpKick,
        RollingKick,
        SandAttack,
        Headbutt,
        HornAttack,
        FuryAttack,
        HornDrill,
        Tackle,
        BodySlam,
        Wrap,
        TakeDown,
        Thrash,
        DoubleEdge,
        TailWhip,
        PoisonSting,
        Twineedle,
        PinMissile,
        Leer,
        Bite,
        Growl,
        Roar,
        Sing,
        Supersonic,
        SonicBoom,
        Disable,
        Acid,
        Ember,
        Flamethrower,
        Mist,
        WaterGun,
        HydroPump,
        Surf,
        IceBeam,
        Blizzard,
        Psybeam,
        BubbleBeam,
        AuroraBeam,
        HyperBeam,
        Peck,
        DrillPeck,
        Submission,
        LowKick,
        Counter,
        SeismicToss,
        Strength,
        Absorb,
        MegaDrain,
        LeechSeed,
        Growth,
        RazorLeaf,
        SolarBeam,
        PoisonPowder,
        StunSpore,
        SleepPowder,
        PetalDance,
        StringShot,
        DragonRage,
        FireSpin,
        ThunderShock,
        Thunderbolt,
        ThunderWave,
        Thunder,
        RockThrow,
        Earthquake,
        Fissure,
        Dig,
        Toxic,
        Confusion,
        Psychic,
        Hypnosis,
        Meditate,
        Agility,
        QuickAttack,
        Rage,
        Teleport,
        NightShade,
        Mimic,
        Screech,
        DoubleTeam,
        Recover,
        Harden,
        Minimize,
        Smokescreen,
        ConfuseRay,
        Withdraw,
        DefenseCurl,
        Barrier,
        LightScreen,
        Haze,
        Reflect,
        FocusEnergy,
        Bide,
        Metronome,
        MirrorMove,
        SelfDestruct,
        EggBomb,
        Lick,
        Smog,
        Sludge,
        BoneClub,
        FireBlast,
        Waterfall,
        Clamp,
        Swift,
        SkullBash,
        SpikeCannon,
        Constrict,
        Amnesia,
        Kinesis,
        SoftBoiled,
        HighJumpKick,
        Glare,
        DreamEater,
        PoisonGas,
        Barrage,
        LeechLife,
        LovelyKiss,
        SkyAttack,
        Transform,
        Bubble,
        DizzyPunch,
        Spore,
        Flash,
        Psywave,
        Splash,
        AcidArmor,
        Crabhammer,
        Explosion,
        FurySwipes,
        Bonemerang,
        Rest,
        RockSlide,
        HyperFang,
        Sharpen,
        Conversion,
        TriAttack,
        SuperFang,
        Slash,
        Substitute,
        Struggle,

        //Gen 2
        Sketch,
        TripleKick,
        Thief,
        SpiderWeb,
        MindReader,
        Nightmare,
        FlameWheel,
        Snore,
        Curse,
        Flail,
        Conversion2,
        Aeroblast,
        CottonSpore,
        Reversal,
        Spite,
        PowderSnow,
        Protect,
        MachPunch,
        ScaryFace,
        FeintAttack,
        SweetKiss,
        BellyDrum,
        SludgeBomb,
        MudSlap,
        Octazooka,
        Spikes,
        ZapCannon,
        Foresight,
        DestinyBond,
        PerishSong,
        IcyWind,
        Detect,
        BoneRush,
        LockOn,
        Outrage,
        Sandstorm,
        GigaDrain,
        Endure,
        Charm,
        Rollout,
        FalseSwipe,
        Swagger,
        MilkDrink,
        Spark,
        FuryCutter,
        SteelWing,
        MeanLook,
        Attract,
        SleepTalk,
        HealBell,
        Return,
        Present,
        Frustration,
        Safeguard,
        PainSplit,
        SacredFire,
        Magnitude,
        DynamicPunch,
        Megahorn,
        DragonBreath,
        BatonPass,
        Encore,
        Pursuit,
        RapidSpin,
        SweetScent,
        IronTail,
        MetalClaw,
        VitalThrow,
        MorningSun,
        Synthesis,
        Moonlight,
        HiddenPower,
        CrossChop,
        Twister,
        RainDance,
        SunnyDay,
        Crunch,
        MirrorCoat,
        PsychUp,
        ExtremeSpeed,
        AncientPower,
        ShadowBall,
        FutureSight,
        RockSmash,
        Whirlpool,
        BeatUp,

        //Gen 3
        FakeOut,
        Uproar,
        Stockpile,
        SpitUp,
        Swallow,
        HeatWave,
        Hail,
        Torment,
        Flatter,
        WillOWisp,
        Memento,
        Facade,
        FocusPunch,
        SmellingSalts,
        FollowMe,
        NaturePower,
        Charge,
        Taunt,
        HelpingHand,
        Trick,
        RolePlay,
        Wish,
        Assist,
        Ingrain,
        Superpower,
        MagicCoat,
        Recycle,
        Revenge,
        BrickBreak,
        Yawn,
        KnockOff,
        Endeavor,
        Eruption,
        SkillSwap,
        Imprison,
        Refresh,
        Grudge,
        Snatch,
        SecretPower,
        Dive,
        ArmThrust,
        Camouflage,
        TailGlow,
        LusterPurge,
        MistBall,
        FeatherDance,
        TeeterDance,
        BlazeKick,
        MudSport,
        IceBall,
        NeedleArm,
        SlackOff,
        HyperVoice,
        PoisonFang,
        CrushClaw,
        BlastBurn,
        HydroCannon,
        MeteorMash,
        Astonish,
        WeatherBall,
        Aromatherapy,
        FakeTears,
        AirCutter,
        Overheat,
        OdorSleuth,
        RockTomb,
        SilverWind,
        MetalSound,
        GrassWhistle,
        Tickle,
        CosmicPower,
        WaterSpout,
        SignalBeam,
        ShadowPunch,
        Extrasensory,
        SkyUppercut,
        SandTomb,
        SheerCold,
        MuddyWater,
        BulletSeed,
        AerialAce,
        IcicleSpear,
        IronDefense,
        Block,
        Howl,
        DragonClaw,
        FrenzyPlant,
        BulkUp,
        Bounce,
        MudShot,
        PoisonTail,
        Covet,
        VoltTackle,
        MagicalLeaf,
        WaterSport,
        CalmMind,
        LeafBlade,
        DragonDance,
        RockBlast,
        ShockWave,
        WaterPulse,
        DoomDesire,
        PsychoBoost,

        //Gen 4
        Roost,
        Gravity,
        MiracleEye,
        WakeUpSlap,
        HammerArm,
        GyroBall,
        HealingWish,
        Brine,
        NaturalGift,
        Feint,
        Pluck,
        Tailwind,
        Acupressure,
        MetalBurst,
        UTurn,
        CloseCombat,
        Payback,
        Assurance,
        Embargo,
        Fling,
        PsychoShift,
        TrumpCard,
        HealBlock,
        WringOut,
        PowerTrick,
        GastroAcid,
        LuckyChant,
        MeFirst,
        Copycat,
        PowerSwap,
        GuardSwap,
        Punishment,
        LastResort,
        WorrySeed,
        SuckerPunch,
        ToxicSpikes,
        HeartSwap,
        AquaRing,
        MagnetRise,
        FlareBlitz,
        ForcePalm,
        AuraSphere,
        RockPolish,
        PoisonJab,
        DarkPulse,
        NightSlash,
        AquaTail,
        SeedBomb,
        AirSlash,
        XScissor,
        BugBuzz,
        DragonPulse,
        DragonRush,
        PowerGem,
        DrainPunch,
        VacuumWave,
        FocusBlast,
        EnergyBall,
        BraveBird,
        EarthPower,
        Switcheroo,
        GigaImpact,
        NastyPlot,
        BulletPunch,
        Avalanche,
        IceShard,
        ShadowClaw,
        ThunderFang,
        IceFang,
        FireFang,
        ShadowSneak,
        MudBomb,
        PsychoCut,
        ZenHeadbutt,
        MirrorShot,
        FlashCannon,
        RockClimb,
        Defog,
        TrickRoom,
        DracoMeteor,
        Discharge,
        LavaPlume,
        LeafStorm,
        PowerWhip,
        RockWrecker,
        CrossPoison,
        GunkShot,
        IronHead,
        MagnetBomb,
        StoneEdge,
        Captivate,
        StealthRock,
        GrassKnot,
        Chatter,
        Judgment,
        BugBite,
        ChargeBeam,
        WoodHammer,
        AquaJet,
        AttackOrder,
        DefendOrder,
        HealOrder,
        HeadSmash,
        DoubleHit,
        RoarOfTime,
        SpacialRend,
        LunarDance,
        CrushGrip,
        MagmaStorm,
        DarkVoid,
        SeedFlare,
        OminousWind,
        ShadowForce,
        
        //Gen 5
        HoneClaws,
        WideGuard,
        GuardSplit,
        PowerSplit,
        WonderRoom,
        Psyshock,
        Venoshock,
        Autotomize,
        RagePowder,
        Telekinesis,
        MagicRoom,
        SmackDown,
        StormThrow,
        FlameBurst,
        SludgeWave,
        QuiverDance,
        HeavySlam,
        Synchronoise,
        ElectroBall,
        Soak,
        FlameCharge,
        Coil,
        LowSweep,
        AcidSpray,
        FoulPlay,
        SimpleBeam,
        Entrainment,
        AfterYou,
        Round,
        EchoedVoice,
        ChipAway,
        ClearSmog,
        StoredPower,
        QuickGuard,
        AllySwitch,
        Scald,
        ShellSmash,
        HealPulse,
        Hex,
        SkyDrop,
        ShiftGear,
        CircleThrow,
        Incinerate,
        Quash,
        Acrobatics,
        ReflectType,
        Retaliate,
        FinalGambit,
        Bestow,
        Inferno,
        WaterPledge,
        FirePledge,
        GrassPledge,
        VoltSwitch,
        StruggleBug,
        Bulldoze,
        FrostBreath,
        DragonTail,
        WorkUp,
        Electroweb,
        WildCharge,
        DrillRun,
        DualChop,
        HeartStamp,
        HornLeech,
        SacredSword,
        RazorShell,
        HeatCrash,
        LeafTornado,
        Steamroller,
        CottonGuard,
        NightDaze,
        Psystrike,
        TailSlap,
        Hurricane,
        HeadCharge,
        GearGrind,
        SearingShot,
        TechnoBlast,
        RelicSong,
        SecretSword,
        Glaciate,
        BoltStrike,
        BlueFlare,
        FieryDance,
        FreezeShock,
        IceBurn,
        Snarl,
        IcicleCrash,
        VCreate,
        FusionFlare,
        FusionBolt,

        //Gen 6
        FlyingPress,
        MatBlock,
        Belch,
        Rototiller,
        StickyWeb,
        FellStinger,
        PhantomForce,
        TrickOrTreat,
        NobleRoar,
        IonDeluge,
        ParabolicCharge,
        ForestsCurse,
        PetalBlizzard,
        FreezeDry,
        DisarmingVoice,
        PartingShot,
        TopsyTurvy,
        DrainingKiss,
        CraftyShield,
        FlowerShield,
        GrassyTerrain,
        MistyTerrain,
        Electrify,
        PlayRough,
        FairyWind,
        Moonblast,
        Boomburst,
        FairyLock,
        KingsShield,
        PlayNice,
        Confide,
        DiamondStorm,
        SteamEruption,
        HyperspaceHole,
        WaterShuriken,
        MysticalFire,
        SpikyShield,
        AromaticMist,
        EerieImpulse,
        VenomDrench,
        Powder,
        Geomancy,
        MagneticFlux,
        HappyHour,
        ElectricTerrain,
        DazzlingGleam,
        Celebrate,
        HoldHands,
        BabyDollEyes,
        Nuzzle,
        HoldBack,
        Infestation,
        PowerUpPunch,
        OblivionWing,
        ThousandArrows,
        ThousandWaves,
        LandsWrath,
        LightOfRuin,
        OriginPulse,
        PrecipiceBlades,
        DragonAscent,
        HyperspaceFury,

        //Nonstandard moves

        ConfusionHit,
        Recharge,
        RazorWindAttack,
        DigAttack,
        FlyAttack,
        SolarBeamAttack,
        SkyAttackAttack,
        SkullBashAttack,
        BideMiddle,
        BideAttack,
        FocusPunchAttack,
        DiveAttack,
        BounceAttack,
        ShadowForceAttack,
        SkyDropAttack,
        RainbowPledge,
        SwampPledge,
        BurningFieldPledge,
        FreezeShockAttack,
        IceBurnAttack,
        PhantomForceAttack,
        GeomancyExecution,
    };
}
