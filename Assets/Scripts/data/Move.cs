using static Type;
using static MoveData;
using static MoveFlags;
using static MoveDesc;
using static Target;
using static ZMoveEffect;

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
        makesContact, PoundDesc, 100); //Done
    public static MoveData KarateChop = new(
        "Karate Chop", Fighting,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        highCrit + makesContact, KarateChopDesc, 100); //Done
    public static MoveData DoubleSlap = new(
        "Double Slap", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        makesContact, DoubleSlapDesc, 100); //Done
    public static MoveData CometPunch = new(
        "Comet Punch", Normal,
        18, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15,
         makesContact + punchMove, CometPunchDesc, 100); //Needs anim
    public static MoveData MegaPunch = new(
        "Mega Punch", Normal,
        80, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
         makesContact + punchMove, MegaPunchDesc, 160); //Needs anim
    public static MoveData PayDay = new(
        "Pay Day", Normal,
        40, 100, 0,
        MoveEffect.PayDay, 101,
        true, Single, 20, noFlag, PayDayDesc, 100); //Needs anim and money implementation
    public static MoveData FirePunch = new(
        "Fire Punch", Fire,
        75, 100, 0,
        MoveEffect.Burn, 10,
        true, Single, 15,
        makesContact + punchMove, FirePunchDesc, 140); //Needs anim
    public static MoveData IcePunch = new(
        "Ice Punch", Ice,
        75, 100, 0,
        MoveEffect.Freeze, 10,
        true, Single, 15,
        makesContact + punchMove, IcePunchDesc, 140); //Needs anim
    public static MoveData ThunderPunch = new(
        "Thunder Punch", Electric,
        75, 100, 0,
        MoveEffect.Paralyze, 10,
        true, Single, 15,
        makesContact + punchMove, ThunderPunchDesc, 140); //Needs anim
    public static MoveData Scratch = new(
        "Scratch", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, ScratchDesc, 100); //Needs anim
    public static MoveData ViseGrip = new(
        "Vise Grip", Normal,
        55, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact, ViseGripDesc, 100); //Needs anim
    public static MoveData Guillotine = new(
        "Guillotine", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5,
        makesContact, GuillotineDesc, 180); //Needs anim
    public static MoveData RazorWind = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, SpreadMove, 10,
        noFlag, RazorWindDesc, 160); //Needs anim
    public static MoveData SwordsDance = SelfTargetingMove(
        "Swords Dance", Normal, 0, MoveEffect.AttackUp2,
        20, snatchAffected, NormalizeDebuffs, SwordsDanceDesc);
    public static MoveData Cut = new(
        "Cut", Normal,
        50, 95, 0,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact + sharpnessBoosted, CutDesc, 100); //Needs anim
    public static MoveData Gust = new(
        "Gust", Flying,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 35,
        hitFlyingMon + windMove, GustDesc, 100); //Needs anim
    public static MoveData WingAttack = new(
        "Wing Attack", Flying,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, WingAttackDesc, 120); //Needs anim
    public static MoveData Whirlwind = new(
        "Whirlwind", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Single, 20,
        magicBounceAffected + windMove, WhirlwindDesc,
        0, SpDefUp1); //Needs anim
    public static MoveData Fly = new(
        "Fly", Flying,
        90, 95, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 15,
        gravityDisabled, FlyDesc, 175); //Needs anim
    public static MoveData Bind = new(
        "Bind", Normal,
        15, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 20,
        makesContact, BindDesc, 100); //Needs anim
    public static MoveData Slam = new(
        "Slam", Normal,
        80, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, SlamDesc, 160); //Needs anim
    public static MoveData VineWhip = new(
        "Vine Whip", Grass,
        45, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        makesContact, VineWhipDesc, 100); //Needs anim
    public static MoveData Stomp = new(
        "Stomp", Normal,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 20,
        makesContact, StompDesc, 120); //Needs anim
    public static MoveData DoubleKick = new(
        "Double Kick", Fighting,
        30, 100, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 30,
        makesContact, DoubleKickDesc, 100); //Needs anim
    public static MoveData MegaKick = new(
        "Mega Kick", Normal,
        120, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 5,
        makesContact, MegaKickDesc, 190); //Needs anim
    public static MoveData JumpKick = new(
        "Jump Kick", Fighting,
        100, 20, 0,
        MoveEffect.Crash50Max, 0,
        true, Single, 10,
        makesContact + gravityDisabled, JumpKickDesc, 180); //Needs anim
    public static MoveData RollingKick = new(
        "Rolling Kick", Fighting,
        60, 85, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, RollingKickDesc, 120); //Needs anim
    public static MoveData SandAttack = SingleTargetStatusMove(
        "Sand Attack", Ground, 100, 0, MoveEffect.AccuracyDown1, 15,
        magicBounceAffected, EvasionUp1, SandAttackDesc); //Needs anim
    public static MoveData Headbutt = new(
        "Headbutt", Normal,
        70, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, HeadbuttDesc, 140); //Needs field effect and anim
    public static MoveData HornAttack = new(
        "Horn Attack", Normal,
        65, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 25,
        makesContact, HornAttackDesc, 120); //Needs anim
    public static MoveData FuryAttack = new(
        "Fury Attack", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20,
        makesContact, FuryAttackDesc, 100); //Needs anim
    public static MoveData HornDrill = new(
        "Horn Drill", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5,
        makesContact, HornDrillDesc, 180); //Needs anim
    public static MoveData Tackle = new(
        "Tackle", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, TackleDesc, 100); //Needs anim
    public static MoveData BodySlam = new(
        "Body Slam", Normal,
        85, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 15,
        makesContact, BodySlamDesc, 160); //Needs anim
    public static MoveData Wrap = new(
        "Wrap", Normal,
        15, 90, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 20,
        makesContact, WrapDesc, 100); //Needs anim
    public static MoveData TakeDown = new(
        "Take Down", Normal,
        90, 85, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 20,
        makesContact, TakeDownDesc, 175); //Needs anim
    public static MoveData Thrash = new(
        "Thrash", Normal,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Self, 10,
        makesContact, ThrashDesc, 190); //Needs anim
    public static MoveData DoubleEdge = new(
        "Double Edge", Normal,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, DoubleEdgeDesc, 190); //Needs anim
    public static MoveData TailWhip = SingleTargetStatusMove(
        "Tail Whip", Normal, 100, 0, MoveEffect.DefenseDown1,
        30, magicBounceAffected, AttackUp1, TailWhipDesc); //Needs anim
    public static MoveData PoisonSting = new(
        "Poison Sting", Poison,
        15, 100, 0,
        MoveEffect.Poison, 30,
        true, Single, 35, noFlag, PoisonStingDesc, 100); //Needs anim
    public static MoveData Twineedle = new(
        "Twineedle", Bug,
        25, 100, 0,
        MoveEffect.Twineedle, 20,
        true, Single, 20, noFlag, TwineedleDesc, 100); //Needs anim
    public static MoveData PinMissile = new(
        "Pin Missile", Bug,
        25, 95, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20, noFlag, PinMissileDesc, 140); //Needs anim
    public static MoveData Leer = new(
        "Leer", Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, SpreadMove, 30,
        magicBounceAffected, LeerDesc,
        0, AttackUp1); //Needs anim
    public static MoveData Bite = new(
        "Bite", Dark,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 25,
        makesContact, BiteDesc, 120); //Needs anim
    public static MoveData Growl = new(
        "Growl", Normal,
        0, 100, 0,
        MoveEffect.AttackDown1, 100,
        false, SpreadMove, 40,
        soundMove + magicBounceAffected, GrowlDesc,
        0, DefenseUp1);
    public static MoveData Roar = new(
        "Roar", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Single, 20,
        soundMove + magicBounceAffected, RoarDesc,
        0, DefenseUp1); //Needs anim
    public static MoveData Sing = SingleTargetStatusMove(
        "Sing", Normal, 55, 0, MoveEffect.Sleep, 15,
        soundMove + magicBounceAffected, SpeedUp1, SingDesc); //Needs anim
    public static MoveData Supersonic = SingleTargetStatusMove(
        "Supersonic", Normal, 55, 0, MoveEffect.Confuse, 20,
        soundMove + magicBounceAffected, SpeedUp1, SupersonicDesc); //Needs anim
    public static MoveData SonicBoom = new(
        "Sonic Boom", Normal,
        1, 90, 0,
        MoveEffect.Direct20, 0,
        false, Single, 20, noFlag, SonicBoomDesc, 100); //Needs anim
    public static MoveData Disable = SingleTargetStatusMove(
        "Disable", Normal, 100, 0, MoveEffect.Disable, 20,
        magicBounceAffected, NormalizeDebuffs, DisableDesc); //Needs anim
    public static MoveData Acid = new(
        "Acid", Poison,
        40, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, SpreadMove, 30,
        noFlag, AcidDesc, 100); //Needs anim
    public static MoveData Ember = new(
        "Ember", Fire,
        40, 100, 0,
        MoveEffect.Burn, 10,
        false, Single, 25,
        noFlag, EmberDesc, 100); //Needs anim
    public static MoveData Flamethrower = new(
        "Flamethrower", Fire,
        90, 100, 0,
        MoveEffect.Burn, 10,
        false, Single, 15,
        noFlag, FlamethrowerDesc, 175); //Needs anim
    public static MoveData Mist = FieldMove(
        "Mist", Ice, 0, MoveEffect.Mist, 30, snatchAffected, Heal100, MistDesc); //Needs anim
    public static MoveData WaterGun = new(
        "Water Gun", Water,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 25,
        noFlag, WaterGunDesc, 100); //Needs anim
    public static MoveData HydroPump = new(
        "Hydro Pump", Water,
        110, 80, 0,
        MoveEffect.Hit, 0,
        false, Single, 5,
        noFlag, HydroPumpDesc, 185); //Needs anim
    public static MoveData Surf = new(
        "Surf", Water,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, Surrounding, 15,
        noFlag, SurfDesc, 175); //Needs anim
    public static MoveData IceBeam = new(
        "Ice Beam", Ice,
        90, 100, 0,
        MoveEffect.Freeze, 10,
        false, Single, 10,
        noFlag, IceBeamDesc, 175); //Needs anim
    public static MoveData Blizzard = new(
        "Blizzard", Ice,
        110, 70, 0,
        MoveEffect.Freeze, 10,
        false, SpreadMove, 5,
        windMove, BlizzardDesc, 185); //Needs anim
    public static MoveData Psybeam = new(
        "Psybeam", Type.Psychic,
        65, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 20,
        noFlag, PsybeamDesc, 120); //Needs anim
    public static MoveData BubbleBeam = new(
        "Bubble Beam", Water,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, BubbleBeamDesc, 120); //Needs anim
    public static MoveData AuroraBeam = new(
        "Aurora Beam", Ice,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, AuroraBeamDesc, 120); //Needs anim
    public static MoveData HyperBeam = new(
        "Hyper Beam", Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, Single, 5,
        noFlag, HyperBeamDesc, 200); //Needs anim
    public static MoveData Peck = new(
        "Peck", Flying,
        35, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 35,
        makesContact, PeckDesc, 100); //Needs anim
    public static MoveData DrillPeck = new(
        "Drill Peck", Flying,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, DrillPeckDesc, 160); //Needs anim
    public static MoveData Submission = new(
        "Submission", Fighting,
        80, 80, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 20,
        makesContact, SubmissionDesc, 160); //Needs anim
    public static MoveData LowKick = new(
        "Low Kick", Fighting,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        true, Single, 20,
        makesContact, LowKickDesc, 160); //Needs anim
    public static MoveData Counter = new(
        "Counter", Fighting,
        1, 100, -5,
        MoveEffect.Counter, 0,
        true, Target.None, 20,
        makesContact, CounterDesc, 100); //Needs anim
    public static MoveData SeismicToss = new(
        "Seismic Toss", Fighting,
        0, 100, 0,
        MoveEffect.DirectLevel, 0,
        true, Single, 20,
        makesContact, SeismicTossDesc, 100); //Needs anim
    public static MoveData Strength = new(
        "Strength", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        makesContact, StrengthDesc, 160); //Needs anim
    public static MoveData Absorb = new(
        "Absorb", Grass,
        20, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 25,
        effectOnSelfOnly, AbsorbDesc, 100); //Needs anim
    public static MoveData MegaDrain = new(
        "Mega Drain", Grass,
        40, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 15,
        effectOnSelfOnly, MegaDrainDesc, 120); //Needs anim
    public static MoveData LeechSeed = SingleTargetStatusMove(
        "Leech Seed", Grass, 90, 0, MoveEffect.LeechSeed, 10,
        magicBounceAffected, NormalizeDebuffs, LeechSeedDesc); //Needs anim
    public static MoveData Growth = SelfTargetingMove(
        "Growth", Normal, 0, MoveEffect.Growth, 20, snatchAffected,
        SpAtkUp1, GrowthDesc); //Needs anim
    public static MoveData RazorLeaf = new(
        "Razor Leaf", Grass,
        55, 95, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 25,
        highCrit + sharpnessBoosted, RazorLeafDesc, 100); //Needs anim
    public static MoveData SolarBeam = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Single, 10, noFlag, SolarBeamDesc, 190); //Needs anim
    public static MoveData PoisonPowder = SingleTargetStatusMove(
        "Poison Powder", Poison, 75, 0, MoveEffect.Poison, 35,
        powderMove + magicBounceAffected, DefenseUp1, PoisonPowderDesc); //Needs anim
    public static MoveData StunSpore = SingleTargetStatusMove(
        "Stun Spore", Grass, 75, 0, MoveEffect.Paralyze, 30,
        powderMove + magicBounceAffected, SpDefUp1, StunSporeDesc); //Needs anim
    public static MoveData SleepPowder = SingleTargetStatusMove(
        "Sleep Powder", Grass, 75, 0, MoveEffect.Sleep, 15,
        powderMove + magicBounceAffected, SpeedUp1, SleepPowderDesc); //Needs anim
    public static MoveData PetalDance = new(
        "Petal Dance", Grass,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        false, Self, 10,
        makesContact, PetalDanceDesc, 190); //Needs anim
    public static MoveData StringShot = new(
        "String Shot", Bug,
        0, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, SpreadMove, 40,
        magicBounceAffected, StringShotDesc,
        0, SpeedUp1); //Needs anim
    public static MoveData DragonRage = new(
        "Dragon Rage", Dragon,
        1, 100, 0,
        MoveEffect.Direct40, 0,
        false, Single, 10, noFlag, DragonRageDesc, 100); //Needs anim
    public static MoveData FireSpin = new(
        "Fire Spin", Fire,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 15, noFlag, FireSpinDesc, 100); //Needs anim
    public static MoveData ThunderShock = new(
        "Thunder Shock", Electric,
        40, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Single, 30, noFlag, ThunderShockDesc, 100); //Needs anim
    public static MoveData Thunderbolt = new(
        "Thunderbolt", Electric,
        90, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Single, 15, noFlag, ThunderboltDesc, 175); //Needs anim
    public static MoveData ThunderWave = SingleTargetStatusMove(
        "Thunder Wave", Electric, 90, 0, MoveEffect.Paralyze, 20,
        magicBounceAffected, SpDefUp1, ThunderWaveDesc); //Needs anim
    public static MoveData Thunder = new(
        "Thunder", Electric,
        110, 70, 0,
        MoveEffect.Paralyze, 30,
        false, Single, 10,
        alwaysHitsInRain, ThunderDesc, 185); //Needs anim
    public static MoveData RockThrow = new(
        "Rock Throw", Rock,
        50, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 15, noFlag, RockThrowDesc, 100); //Needs anim
    public static MoveData Earthquake = new(
        "Earthquake", Ground,
        100, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10, hitDiggingMon, EarthquakeDesc, 180); //Needs anim
    public static MoveData Fissure = new(
        "Fissure", Ground,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Single, 5, noFlag, FissureDesc, 180); //Needs anim
    public static MoveData Dig = new(
        "Dig", Ground,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10, noFlag, DigDesc, 160); //Needs anim
    public static MoveData Toxic = SingleTargetStatusMove(
        "Toxic", Poison, 90, 0, MoveEffect.Toxic, 10,
        magicBounceAffected, DefenseUp1, ToxicDesc); //Needs anim
    public static MoveData Confusion = new(
        "Confusion", Type.Psychic,
        50, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 25, noFlag, ConfusionDesc, 100); //Needs anim
    public static MoveData Psychic = new(
        "Psychic", Type.Psychic,
        90, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Single, 10, noFlag, PsychicDesc, 175); //Needs anim
    public static MoveData Hypnosis = SingleTargetStatusMove(
        "Hypnosis", Type.Psychic, 60, 0,
        MoveEffect.Sleep, 20,
        magicBounceAffected, SpeedUp1, HypnosisDesc); //Needs anim
    public static MoveData Meditate = SelfTargetingMove(
        "Meditate", Type.Psychic, 0, MoveEffect.AttackUp1, 40,
        snatchAffected, AttackUp1, MeditateDesc); //Needs anim
    public static MoveData Agility = SelfTargetingMove(
        "Agility", Type.Psychic, 0, MoveEffect.SpeedUp2, 30,
        snatchAffected, NormalizeDebuffs, AgilityDesc); //Needs anim
    public static MoveData QuickAttack = new(
        "Quick Attack", Normal,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact, QuickAttackDesc, 100); //Needs anim
    public static MoveData Rage = new(
        "Rage", Normal,
        20, 100, 0,
        MoveEffect.Rage, 0,
        true, Single, 20,
        makesContact, RageDesc, 100); //Needs anim and test
    public static MoveData Teleport = SelfTargetingMove(
        "Teleport", Type.Psychic, -6, MoveEffect.Teleport, 20,
        noFlag, Heal100, TeleportDesc); //Needs anim
    public static MoveData NightShade = new(
        "Night Shade", Ghost,
        1, 100, 0,
        MoveEffect.DirectLevel, 0,
        false, Single, 15, noFlag, NightShadeDesc, 100); //Needs anim
    public static MoveData Mimic = SingleTargetStatusMove(
        "Mimic", Normal, 101, 0, MoveEffect.Mimic, 10,
        noFlag, AccuracyUp1, MimicDesc); //Needs anim
    public static MoveData Screech = SingleTargetStatusMove(
        "Screech", Normal, 85, 0, MoveEffect.DefenseDown2, 40,
        soundMove + magicBounceAffected, AttackUp1, ScreechDesc); //Needs anim
    public static MoveData DoubleTeam = SelfTargetingMove(
        "Double Team", Normal, 0, MoveEffect.EvasionUp1, 15,
        snatchAffected, NormalizeDebuffs, DoubleTeamDesc); //Needs anim
    public static MoveData Recover = SelfTargetingMove(
        "Recover", Normal, 0, MoveEffect.Heal50, 10,
        snatchAffected + healBlockAffected, NormalizeDebuffs, RecoverDesc); //Needs anim
    public static MoveData Harden = SelfTargetingMove(
        "Harden", Normal, 0, MoveEffect.DefenseUp1, 30,
        snatchAffected, DefenseUp1, HardenDesc); //Needs anim
    public static MoveData Minimize = SelfTargetingMove(
        "Minimize", Normal, 0, MoveEffect.Minimize, 10,
        snatchAffected, NormalizeDebuffs, MinimizeDesc); //Needs anim
    public static MoveData Smokescreen = SingleTargetStatusMove(
        "Smokescreen", Normal, 100, 0, MoveEffect.AccuracyDown1, 20,
        magicBounceAffected, EvasionUp1, SmokescreenDesc); //Needs anim
    public static MoveData ConfuseRay = SingleTargetStatusMove(
        "Confuse Ray", Ghost, 100, 0, MoveEffect.Confuse, 10,
        magicBounceAffected, SpAtkUp1, ConfuseRayDesc); //Needs anim
    public static MoveData Withdraw = SelfTargetingMove(
        "Withdraw", Water, 0, MoveEffect.DefenseUp1, 40,
        snatchAffected, DefenseUp1, WithdrawDesc); //Needs anim
    public static MoveData DefenseCurl = SelfTargetingMove(
        "Defense Curl", Normal, 0, MoveEffect.DefenseCurl, 40,
        snatchAffected, AccuracyUp1, DefenseCurlDesc); //Needs anim
    public static MoveData Barrier = SelfTargetingMove(
        "Barrier", Type.Psychic, 0, MoveEffect.DefenseUp2, 20,
        snatchAffected, NormalizeDebuffs, BarrierDesc); //Needs anim
    public static MoveData LightScreen = FieldMove(
        "Light Screen", Type.Psychic, 0, MoveEffect.LightScreen, 30,
        snatchAffected, SpDefUp1, LightScreenDesc); //Needs anim
    public static MoveData Haze = FieldMove(
        "Haze", Ice, 0, MoveEffect.Haze, 30, noFlag, Heal100, HazeDesc); //Needs anim
    public static MoveData Reflect = FieldMove(
        "Reflect", Type.Psychic, 0, MoveEffect.Reflect, 20,
        snatchAffected, DefenseUp1, ReflectDesc); //Needs anim
    public static MoveData FocusEnergy = SelfTargetingMove(
        "Focus Energy", Normal, 0, MoveEffect.CritRateUp2, 30,
        snatchAffected, AccuracyUp1, FocusEnergyDesc); //Needs anim
    public static MoveData Bide = new(
        "Bide", Normal,
        1, 101, 1,
        MoveEffect.ChargingAttack, 0,
        true, Self, 10, noFlag, BideDesc, 100); //Needs anim
    public static MoveData Metronome = SelfTargetingMove(
        "Metronome", Normal, 0, MoveEffect.Metronome, 10,
        cannotMimic, 0, MetronomeDesc); //Needs anim
    public static MoveData MirrorMove = new(
        "Mirror Move", Flying,
        0, 101, 0,
        MoveEffect.MirrorMove, 0,
        false, Single, 20, noFlag, MirrorMoveDesc,
        0, AttackUp2); //Needs anim
    //Todo: Define which moves are affected by Mirror Move
    public static MoveData SelfDestruct = new(
        "Self Destruct", Normal,
        200, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Single, 5, noFlag, SelfDestructDesc, 200); //Needs anim
    public static MoveData EggBomb = new(
        "Egg Bomb", Normal,
        100, 75, 0,
        MoveEffect.Hit, 0,
        true, Single, 10, noFlag, EggBombDesc, 180); //Needs anim
    public static MoveData Lick = new(
        "Lick", Ghost,
        30, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 30,
        makesContact, LickDesc, 100); //Needs anim
    public static MoveData Smog = new(
        "Smog", Poison,
        30, 70, 0,
        MoveEffect.Poison, 40,
        false, Single, 20, noFlag, SmogDesc, 100); //Needs anim
    public static MoveData Sludge = new(
        "Sludge", Poison,
        65, 100, 0,
        MoveEffect.Poison, 30,
        false, Single, 20, noFlag, SludgeDesc, 120); //Needs anim
    public static MoveData BoneClub = new(
        "Bone Club", Ground,
        65, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 20, noFlag, BoneClubDesc, 120); //Needs anim
    public static MoveData FireBlast = new(
        "Fire Blast", Fire,
        110, 85, 0,
        MoveEffect.Burn, 30,
        false, Single, 5, noFlag, FireBlastDesc, 185); //Needs anim
    public static MoveData Waterfall = new(
        "Waterfall", Water,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        true, Single, 15,
        makesContact, WaterfallDesc, 160); //Needs anim
    public static MoveData Clamp = new(
        "Clamp", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 15,
        makesContact, ClampDesc, 100); //Needs anim
    public static MoveData Swift = new(
        "Swift", Normal,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 20,
        noFlag, SwiftDesc, 120); //Needs anim
    public static MoveData SkullBash = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        makesContact, SkullBashDesc, 195); //Needs anim
    public static MoveData SpikeCannon = new(
        "Spike Cannon", Normal,
        20, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15, noFlag, SpikeCannonDesc, 100); //Needs anim
    public static MoveData Constrict = new(
        "Constrict", Normal,
        10, 100, 0,
        MoveEffect.SpeedDown1, 10,
        true, Single, 35,
        makesContact, ConstrictDesc, 100); //Needs anim
    public static MoveData Amnesia = SelfTargetingMove(
        "Amnesia", Type.Psychic, 0, MoveEffect.SpDefUp2, 20,
        snatchAffected, NormalizeDebuffs, AmnesiaDesc); //Needs anim
    public static MoveData Kinesis = SingleTargetStatusMove(
        "Kinesis", Type.Psychic, 80, 0, MoveEffect.AccuracyDown1, 15,
        magicBounceAffected, EvasionUp1, KinesisDesc); //Needs anim
    public static MoveData SoftBoiled = SelfTargetingMove(
        "Soft-Boiled", Normal, 0, MoveEffect.Heal50, 10,
        snatchAffected + healBlockAffected, NormalizeDebuffs, SoftBoiledDesc); //Needs anim
    public static MoveData HighJumpKick = new(
        "High Jump Kick", Fighting,
        130, 90, 0,
        MoveEffect.Crash50Max, 0,
        true, Single, 10,
        makesContact + gravityDisabled, HighJumpKickDesc, 195); //Needs anim
    public static MoveData Glare = SingleTargetStatusMove(
        "Glare", Normal, 100, 0, MoveEffect.Paralyze, 30,
        magicBounceAffected, SpDefUp1, GlareDesc); //Needs anim
    public static MoveData DreamEater = new(
        "Dream Eater", Type.Psychic,
        100, 100, 0,
        MoveEffect.DreamEater, 0,
        false, Single, 15, noFlag, DreamEaterDesc, 180); //Needs anim
    public static MoveData PoisonGas = new(
        "Poison Gas", Poison,
        0, 90, 0,
        MoveEffect.Poison, 100,
        false, SpreadMove, 40,
        magicBounceAffected, PoisonGasDesc,
        0, DefenseUp1); //Needs anim
    public static MoveData Barrage = new(
        "Barrage", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20, noFlag, BarrageDesc, 100); //Needs anim
    public static MoveData LeechLife = new(
        "Leech Life", Bug,
        80, 100, 0,
        MoveEffect.Absorb50, 0,
        true, Single, 10,
        makesContact, LeechLifeDesc, 160); //Needs anim
    public static MoveData LovelyKiss = SingleTargetStatusMove(
        "Lovely Kiss", Normal, 75, 0, MoveEffect.Sleep, 10,
        magicBounceAffected, SpeedUp1, LovelyKissDesc); //Needs anim
    public static MoveData SkyAttack = new(
        "Sky Attack", Flying,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5, noFlag, SkyAttackDesc, 200); //Needs anim
    public static MoveData Transform = SingleTargetStatusMove(
        "Transform", Normal, 101, 0, MoveEffect.Transform, 10,
        cannotMimic, Heal100, TransformDesc); //Needs anim
    public static MoveData Bubble = new(
        "Bubble", Water,
        40, 100, 0,
        MoveEffect.SpeedDown1, 10,
        false, SpreadMove, 30,
        noFlag, BubbleDesc, 100); //Needs anim
    public static MoveData DizzyPunch = new(
        "Dizzy Punch", Normal,
        70, 100, 0,
        MoveEffect.Confuse, 20,
        true, Single, 10,
        makesContact + punchMove, DizzyPunchDesc, 140); //Needs anim
    public static MoveData Spore = SingleTargetStatusMove(
        "Spore", Grass, 100, 0, MoveEffect.Sleep, 15,
        powderMove + magicBounceAffected, NormalizeDebuffs, SporeDesc); //Needs anim
    public static MoveData Flash = SingleTargetStatusMove(
        "Flash", Normal, 100, 0, MoveEffect.AccuracyDown1, 20,
        magicBounceAffected, EvasionUp1, FlashDesc); //Needs anim
    public static MoveData Psywave = new(
        "Psywave", Type.Psychic,
        1, 100, 0,
        MoveEffect.Psywave, 0,
        false, Single, 15,
        noFlag, PsywaveDesc, 100); //Needs anim
    public static MoveData Splash = SelfTargetingMove(
        "Splash", Normal, 0, MoveEffect.None, 40,
        gravityDisabled, AttackUp3, SplashDesc); //Needs anim
    public static MoveData AcidArmor = SelfTargetingMove(
        "Acid Armor", Poison, 0, MoveEffect.DefenseUp2, 20,
        snatchAffected, NormalizeDebuffs, AcidArmorDesc); //Needs anim
    public static MoveData Crabhammer = new(
        "Crabhammer", Water,
        100, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        highCrit + makesContact, CrabhammerDesc, 180); //Needs anim
    public static MoveData Explosion = new(
        "Explosion", Normal,
        250, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Surrounding, 5, noFlag, ExplosionDesc, 200); //Needs anim
    public static MoveData FurySwipes = new(
        "Fury Swipes", Normal,
        18, 80, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 15,
        makesContact, FurySwipesDesc, 100); //Needs anim
    public static MoveData Bonemerang = new(
        "Bonemerang", Ground,
        50, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 10, noFlag, BonemerangDesc, 100); //Needs anim
    public static MoveData Rest = SelfTargetingMove(
        "Rest", Type.Psychic, 0, MoveEffect.Rest, 10,
        snatchAffected, NormalizeDebuffs, RestDesc); //Needs anim
    public static MoveData RockSlide = new(
        "Rock Slide", Rock,
        75, 90, 0,
        MoveEffect.Flinch, 30,
        true, SpreadMove, 10,
        noFlag, RockSlideDesc, 140); //Needs anim
    public static MoveData HyperFang = new(
        "Hyper Fang", Normal,
        80, 90, 0,
        MoveEffect.Flinch, 10,
        true, Single, 15,
        makesContact, HyperFangDesc, 160); //Needs anim
    public static MoveData Sharpen = SelfTargetingMove(
        "Sharpen", Normal, 0, MoveEffect.AttackUp1, 30,
        snatchAffected, AttackUp1, SharpenDesc); //Needs anim
    public static MoveData Conversion = SelfTargetingMove(
        "Conversion", Normal, 0, MoveEffect.Conversion, 30,
        snatchAffected, AllUp1, ConversionDesc); //Needs anim
    public static MoveData TriAttack = new(
        "Tri Attack", Normal,
        80, 100, 0,
        MoveEffect.TriAttack, 20,
        false, Single, 10, noFlag, TriAttackDesc, 160); //Needs anim
    public static MoveData SuperFang = new(
        "Super Fang", Normal,
        0, 90, 0,
        MoveEffect.SuperFang, 0,
        true, Single, 10,
        makesContact, SuperFangDesc, 100); //Needs anim
    public static MoveData Slash = new(
        "Slash", Normal,
        70, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        highCrit + makesContact + sharpnessBoosted, SlashDesc, 140); //Needs anim
    public static MoveData Substitute = SelfTargetingMove(
        "Substitute", Normal, 0, MoveEffect.Substitute, 10,
        snatchAffected, NormalizeDebuffs, SubstituteDesc); //Needs anim

    //Gen 2

    public static MoveData Sketch = SingleTargetStatusMove(
         "Sketch", Normal, 101, 0, MoveEffect.Sketch, 1,
         noFlag, AllUp1, SketchDesc); //Needs anim
    public static MoveData TripleKick = new(
        "Triple Kick", Fighting,
        10, 90, 0,
        MoveEffect.TripleHit, 0,
        true, Single, 10,
        makesContact, TripleKickDesc, 120); //Needs anim
    public static MoveData Thief = new(
        "Thief", Dark,
        60, 100, 0,
        MoveEffect.Thief, 100,
        true, Single, 25,
        makesContact, ThiefDesc, 120); //Needs anim
    public static MoveData SpiderWeb = SingleTargetStatusMove(
        "Spider Web", Bug, 101, 0, MoveEffect.Trap, 10,
        magicBounceAffected, DefenseUp1, SpiderWebDesc); //Needs anim
    public static MoveData MindReader = SingleTargetStatusMove(
        "Mind Reader", Normal, 101, 0, MoveEffect.MindReader, 5,
        noFlag, SpAtkUp1, MindReaderDesc); //Needs testing and anim
    public static MoveData Nightmare = SingleTargetStatusMove(
        "Nightmare", Ghost, 100, 0, MoveEffect.Nightmare, 15,
        noFlag, SpAtkUp1, NightmareDesc); //Needs anim
    public static MoveData FlameWheel = new(
        "Flame Wheel", Fire,
        60, 100, 0,
        MoveEffect.Burn, 10,
        true, Single, 25,
        makesContact, FlameWheelDesc, 120); //Needs anim
    public static MoveData Snore = new(
        "Snore", Normal,
        50, 100, 0,
        MoveEffect.Snore, 30,
        false, Single, 15,
        noFlag, SnoreDesc, 100); //Needs anim
    public static MoveData Curse = SelfTargetingMove(
        "Curse", Ghost, 0,
        MoveEffect.Curse, 10,
        noFlag, ZMoveEffect.Curse, CurseDesc); //Needs anim
    public static MoveData Flail = new(
        "Flail", Normal,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Single, 15,
        makesContact, FlailDesc, 160); //Needs anim
    public static MoveData Conversion2 = SelfTargetingMove(
        "Conversion 2", Normal, 0, MoveEffect.Conversion2, 30,
        effectOnSelfOnly, Heal100, Conversion2Desc); //Needs anim
    public static MoveData Aeroblast = new(
        "Aeroblast", Flying,
        100, 95, 0,
        MoveEffect.Hit, 0,
        false, Single, 5,
        highCrit, AeroblastDesc, 180); //Needs anim
    public static MoveData CottonSpore = SingleTargetStatusMove(
        "Cotton Spore", Grass, 100, 0, MoveEffect.SpeedDown2, 40,
        magicBounceAffected, NormalizeDebuffs, CottonSporeDesc); //Needs anim
    public static MoveData Reversal = new(
        "Reversal", Fighting,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Single, 15,
        makesContact, ReversalDesc, 160); //Needs anim
    public static MoveData Spite = SingleTargetStatusMove(
        "Spite", Ghost, 100, 0, MoveEffect.Spite, 10,
        magicBounceAffected, Heal100, SpiteDesc); //Needs anim
    public static MoveData PowderSnow = new(
        "Powder Snow", Ice,
        40, 100, 0,
        MoveEffect.Freeze, 10,
        false, SpreadMove, 25,
        noFlag, PowderSnowDesc, 100); //Needs anim
    public static MoveData Protect = SelfTargetingMove(
        "Protect", Normal, 4, MoveEffect.Protect, 10,
        usesProtectCounter, NormalizeDebuffs, ProtectDesc); //Needs anim
    public static MoveData MachPunch = new(
        "Mach Punch", Fighting,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Single, 30,
        makesContact + punchMove, MachPunchDesc, 100); //Needs anim
    public static MoveData ScaryFace = SingleTargetStatusMove(
        "Scary Face", Normal, 100, 0, MoveEffect.SpeedDown2, 10,
        magicBounceAffected, SpeedUp1, ScaryFaceDesc); //Needs anim
    public static MoveData FeintAttack = new(
        "Feint Attack", Dark,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact, FeintAttackDesc, 120); //Needs anim
    public static MoveData SweetKiss = SingleTargetStatusMove(
        "Sweet Kiss", Fairy, 75, 0, MoveEffect.Confuse, 10,
        magicBounceAffected, SpAtkUp1, SweetKissDesc); //Needs anim
    public static MoveData BellyDrum = SelfTargetingMove(
        "Belly Drum", Normal, 0, MoveEffect.BellyDrum, 10,
        snatchAffected, Heal100, BellyDrumDesc); //Needs anim
    public static MoveData SludgeBomb = new(
        "Sludge Bomb", Poison,
        90, 100, 0,
        MoveEffect.Poison, 30,
        false, Single, 10,
        bulletMove, SludgeBombDesc, 175); //Needs anim
    public static MoveData MudSlap = new(
        "Mud Slap", Ground,
        20, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Single, 10,
        noFlag, MudSlapDesc, 100); //Needs anim
    public static MoveData Octazooka = new(
        "Octazooka", Water,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 50,
        false, Single, 10,
        bulletMove, OctazookaDesc, 120); //Needs anim
    public static MoveData Spikes = FieldMove(
        "Spikes", Ground, 0, MoveEffect.Spikes, 20,
        magicBounceAffected, DefenseUp1, SpikesDesc); //Needs anim
    public static MoveData ZapCannon = new(
        "Zap Cannon", Electric,
        120, 50, 0,
        MoveEffect.Paralyze, 100,
        false, Single, 5,
        bulletMove, ZapCannonDesc, 190); //Needs anim
    public static MoveData Foresight = SingleTargetStatusMove(
        "Foresight", Normal, 101, 0, MoveEffect.Foresight, 40,
        magicBounceAffected, CritRateUp2, ForesightDesc); //Needs anim
    public static MoveData DestinyBond = SelfTargetingMove(
        "Destiny Bond", Ghost, 0, MoveEffect.DestinyBond, 5,
        noFlag, ZMoveEffect.FollowMe, DestinyBondDesc); //Needs anim
    public static MoveData PerishSong = FieldMove(
        "Perish Song", Normal, 0, MoveEffect.PerishSong, 5,
        soundMove, NormalizeDebuffs, PerishSongDesc); //Needs anim
    public static MoveData IcyWind = new(
        "Icy Wind", Ice,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, SpreadMove, 15,
        windMove, IcyWindDesc, 100); //Needs anim
    public static MoveData Detect = SelfTargetingMove(
        "Detect", Fighting, 4, MoveEffect.Protect, 5,
        usesProtectCounter, EvasionUp1, DetectDesc); //Needs anim
    public static MoveData BoneRush = new(
        "Bone Rush", Ground,
        25, 90, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        noFlag, BoneRushDesc, 140); //Needs anim
    public static MoveData LockOn = SingleTargetStatusMove(
        "Lock On", Normal, 101, 0, MoveEffect.MindReader, 5,
        noFlag, SpeedUp1, LockOnDesc); //Needs anim
    public static MoveData Outrage = new(
        "Outrage", Dragon,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Self, 10,
        makesContact, OutrageDesc, 190); //Needs anim
    public static MoveData Sandstorm = FieldMove(
        "Sandstorm", Rock, 0, MoveEffect.Weather, 10,
        noFlag, SpeedUp1, SandstormDesc); //Needs anim
    public static MoveData GigaDrain = new(
        "Giga Drain", Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Single, 10,
        noFlag, GigaDrainDesc, 140); //Needs anim
    public static MoveData Endure = SelfTargetingMove(
        "Endure", Normal, 4, MoveEffect.Endure, 10,
        usesProtectCounter, NormalizeDebuffs, EndureDesc); //Needs anim
    public static MoveData Charm = SingleTargetStatusMove(
        "Charm", Fairy, 100, 0, MoveEffect.AttackDown2, 20,
        magicBounceAffected, DefenseUp1, CharmDesc); //Needs anim
    public static MoveData Rollout = new(
        "Rollout", Rock,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact, RolloutDesc, 100); //Needs anim
    public static MoveData FalseSwipe = new(
        "False Swipe", Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, Single, 40,
        makesContact, FalseSwipeDesc, 100); //Needs anim
    public static MoveData Swagger = SingleTargetStatusMove(
        "Swagger", Normal, 85, 0, MoveEffect.Swagger, 15,
        magicBounceAffected, NormalizeDebuffs, SwaggerDesc); //Needs anim
    public static MoveData MilkDrink = SelfTargetingMove(
        "Milk Drink", Normal, 0, MoveEffect.Heal50, 10,
        snatchAffected + healBlockAffected, NormalizeDebuffs, MilkDrinkDesc); //Needs anim
    public static MoveData Spark = new(
        "Spark", Electric,
        65, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 20,
        makesContact, SparkDesc, 120); //Need anim
    public static MoveData FuryCutter = new(
        "Fury Cutter", Bug,
        40, 95, 0,
        MoveEffect.FuryCutter, 0,
        true, Single, 20,
        makesContact + sharpnessBoosted, FuryCutterDesc, 100); //Needs anim
    public static MoveData SteelWing = new(
        "Steel Wing", Steel,
        70, 90, 0,
        MoveEffect.DefenseUp1, 10,
        true, Single, 25,
        effectOnSelfOnly + makesContact, SteelWingDesc, 140); //Needs anim
    public static MoveData MeanLook = SingleTargetStatusMove(
        "Mean Look", Normal, 101, 0, MoveEffect.Trap, 5,
        magicBounceAffected, SpDefUp1, MeanLookDesc); //Needs anim
    public static MoveData Attract = SingleTargetStatusMove(
        "Attract", Normal, 100, 0, MoveEffect.Attract, 15,
        magicBounceAffected, NormalizeDebuffs, AttractDesc); //Needs anim
    public static MoveData SleepTalk = SelfTargetingMove(
        "Sleep Talk", Normal, 0, MoveEffect.SleepTalk, 10,
        noFlag, CritRateUp2, SleepTalkDesc); //Needs testing and anim
    public static MoveData HealBell = FieldMove(
        "Heal Bell", Normal, 0, MoveEffect.HealBell, 5,
        snatchAffected, Heal100, HealBellDesc); //Needs anim
    public static MoveData Return = new(
        "Return", Normal,
        1, 100, 0,
        MoveEffect.Return, 0,
        true, Single, 20,
        makesContact, ReturnDesc, 160); //Needs anim
    public static MoveData Present = new(
        "Present", Normal,
        1, 90, 0,
        MoveEffect.Present, 0,
        true, Single, 15, noFlag, PresentDesc, 100); //Needs anim
    public static MoveData Frustration = new(
        "Frustration", Normal,
        0, 100, 0,
        MoveEffect.Frustration, 0,
        true, Single, 20,
        makesContact, FrustrationDesc, 160); //Needs anim
    public static MoveData Safeguard = FieldMove(
        "Safeguard", Normal, 0, MoveEffect.Safeguard, 25,
        snatchAffected, SpeedUp1, SafeguardDesc); //Needs anim
    public static MoveData PainSplit = SingleTargetStatusMove(
        "Pain Split", Normal, 101, 0, MoveEffect.PainSplit, 20,
        noFlag, DefenseUp1, PainSplitDesc); //Needs anim
    public static MoveData SacredFire = new(
        "Sacred Fire", Fire,
        100, 95, 0,
        MoveEffect.Burn, 50,
        true, Single, 5, noFlag, SacredFireDesc, 180); //Needs anim
    public static MoveData Magnitude = new(
        "Magnitude", Ground,
        1, 100, 0,
        MoveEffect.Magnitude, 0,
        true, Single, 30, noFlag, MagnitudeDesc, 140); //Needs anim
    public static MoveData DynamicPunch = new(
        "Dynamic Punch", Fighting,
        100, 50, 0,
        MoveEffect.Confuse, 100,
        true, Single, 5,
        makesContact + punchMove, DynamicPunchDesc, 180); //Needs anim
    public static MoveData Megahorn = new(
        "Megahorn", Bug,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, MegahornDesc, 190); //Needs anim
    public static MoveData DragonBreath = new(
        "Dragon Breath", Dragon,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Single, 20, noFlag, DragonBreathDesc, 120); //Needs anim
    public static MoveData BatonPass = SelfTargetingMove(
        "Baton Pass", Normal, 0, MoveEffect.BatonPass, 40,
        noFlag, NormalizeDebuffs, BatonPassDesc); //Needs testing and anim
    public static MoveData Encore = SingleTargetStatusMove(
        "Encore", Normal, 100, 0, MoveEffect.Encore, 5,
        magicBounceAffected, SpeedUp1, EncoreDesc); //Needs testing and anim
    public static MoveData Pursuit = new(
        "Pursuit", Dark,
        40, 100, 0,
        MoveEffect.Pursuit, 100,
        true, Single, 20,
        makesContact, PursuitDesc, 100); //Needs anim
    public static MoveData RapidSpin = new(
        "Rapid Spin", Normal,
        50, 100, 0,
        MoveEffect.RapidSpin, 100,
        true, Single, 40,
        effectOnSelfOnly + makesContact, RapidSpinDesc, 100); //Needs anim
    public static MoveData SweetScent = new(
        "Sweet Scent", Normal,
        0, 100, 0,
        MoveEffect.EvasionDown2, 100,
        false, SpreadMove, 20,
        magicBounceAffected, SweetScentDesc,
        0, AccuracyUp1); //Needs anim
    public static MoveData IronTail = new(
        "Iron Tail", Steel,
        100, 75, 0,
        MoveEffect.DefenseDown1, 30,
        true, Single, 15,
        makesContact, IronTailDesc, 180); //Needs anim
    public static MoveData MetalClaw = new(
        "Metal Claw", Steel,
        50, 95, 0,
        MoveEffect.AttackUp1, 10,
        true, Single, 35,
        effectOnSelfOnly + makesContact, MetalClawDesc, 100); //Needs anim
    public static MoveData VitalThrow = new(
        "Vital Throw", Fighting,
        70, 101, -1,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, VitalThrowDesc, 140); //Needs anim
    public static MoveData MorningSun = SelfTargetingMove(
        "Morning Sun", Normal, 0, MoveEffect.HealWeather, 5,
        snatchAffected, NormalizeDebuffs, MorningSunDesc); //Needs anim
    public static MoveData Synthesis = SelfTargetingMove(
        "Synthesis", Grass, 0, MoveEffect.HealWeather, 5,
        snatchAffected, NormalizeDebuffs, SynthesisDesc); //Needs anim
    public static MoveData Moonlight = SelfTargetingMove(
        "Moonlight", Fairy, 0, MoveEffect.HealWeather, 5,
        snatchAffected, NormalizeDebuffs, MoonlightDesc); //Needs anim
    public static MoveData HiddenPower = new(
        "Hidden Power", Normal,
        60, 100, 0,
        MoveEffect.HiddenPower, 0,
        false, Single, 15, noFlag, HiddenPowerDesc, 120); //Needs anim
    public static MoveData CrossChop = new(
        "Cross Chop", Fighting,
        100, 80, 0,
        MoveEffect.Hit, 0,
        true, Single, 5,
        highCrit + makesContact, CrossChopDesc, 180); //Needs anim
    public static MoveData Twister = new(
        "Twister", Dragon,
        40, 100, 0,
        MoveEffect.Flinch, 20,
        false, SpreadMove, 20,
        hitFlyingMon + windMove, TwisterDesc, 100); //Needs anim
    public static MoveData RainDance = FieldMove(
        "Rain Dance", Water, 0, MoveEffect.Weather, 5,
        noFlag, SpeedUp1, RainDanceDesc); //Needs anim
    public static MoveData SunnyDay = FieldMove(
        "Sunny Day", Fire, 0, MoveEffect.Weather, 5,
        noFlag, SpeedUp1, SunnyDayDesc); //Needs anim
    public static MoveData Crunch = new(
        "Crunch", Dark,
        80, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, Single, 15,
        makesContact, CrunchDesc, 160); //Needs anim
    public static MoveData MirrorCoat = new(
        "Mirror Coat", Type.Psychic,
        0, 100, -5,
        MoveEffect.Counter, 0,
        false, Target.None, 20, noFlag, MirrorCoatDesc, 100); //Needs testing and anim
    public static MoveData PsychUp = SingleTargetStatusMove(
        "Psych Up", Normal, 101, 0, MoveEffect.PsychUp, 10,
        snatchAffected, Heal100, PsychUpDesc); //Needs anim
    public static MoveData ExtremeSpeed = new(
        "Extreme Speed", Normal,
        80, 100, 2,
        MoveEffect.Hit, 0,
        true, Single, 5,
        makesContact, ExtremeSpeedDesc, 160); //Needs anim
    public static MoveData AncientPower = new(
        "Ancient Power", Rock,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5, noFlag, AncientPowerDesc, 120); //Needs anim
    public static MoveData ShadowBall = new(
        "Shadow Ball", Ghost,
        80, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Single, 15,
        bulletMove, ShadowBallDesc, 160); //Needs anim
    public static MoveData FutureSight = new(
        "Future Sight", Type.Psychic,
        120, 100, 0,
        MoveEffect.FutureSight, 100,
        false, Single, 10, noFlag, FutureSightDesc, 190); //Needs anim
    public static MoveData RockSmash = new(
        "Rock Smash", Fighting,
        40, 100, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 15,
        makesContact, RockSmashDesc, 100); //Needs anim
    public static MoveData Whirlpool = new(
        "Whirlpool", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 15, noFlag, WhirlpoolDesc, 100); //Needs anim
    public static MoveData BeatUp = new(
        "Beat Up", Dark,
        1, 100, 0,
        MoveEffect.BeatUp, 0,
        true, Single, 10, noFlag, BeatUpDesc, 100); //Needs anim

    //Gen 3

    public static MoveData FakeOut = new(
        "Fake Out", Normal,
        40, 100, 3,
        MoveEffect.FakeOut, 100,
        true, Single, 10,
        makesContact, FakeOutDesc, 100); //Needs anim
    public static MoveData Uproar = new(
        "Uproar", Normal,
        90, 100, 0,
        MoveEffect.Uproar, 100,
        false, Self, 10,
        soundMove + effectOnSelfOnly, UproarDesc, 175); //Needs anim
    public static MoveData Stockpile = SelfTargetingMove(
        "Stockpile", Normal, 0, MoveEffect.Stockpile, 20,
        snatchAffected, Heal100, StockpileDesc); //Needs anim
    public static MoveData SpitUp = new(
        "Spit Up", Normal,
        1, 100, 0,
        MoveEffect.SpitUp, 0,
        false, Single, 10, noFlag, SpitUpDesc, 100); //Needs anim
    public static MoveData Swallow = SelfTargetingMove(
        "Swallow", Normal, 0, MoveEffect.Swallow, 10,
        snatchAffected, NormalizeDebuffs, SwallowDesc); //Needs anim
    public static MoveData HeatWave = new(
        "Heat Wave", Fire,
        95, 90, 0,
        MoveEffect.Burn, 10,
        false, SpreadMove, 10,
        windMove, HeatWaveDesc, 175); //Needs anim
    public static MoveData Hail = FieldMove(
        "Hail", Ice, 0, MoveEffect.Weather, 10, noFlag, SpeedUp1, HailDesc); //Needs anim
    public static MoveData Torment = SingleTargetStatusMove(
        "Torment", Dark, 100, 0, MoveEffect.Torment, 15,
        magicBounceAffected, DefenseUp1, TormentDesc); //Needs anim
    public static MoveData Flatter = SingleTargetStatusMove(
        "Flatter", Dark, 100, 0, MoveEffect.Flatter, 15,
        magicBounceAffected, SpDefUp1, FlatterDesc); //Needs anim
    public static MoveData WillOWisp = SingleTargetStatusMove(
        "Will-O-Wisp", Fire, 85, 0, MoveEffect.Burn, 15,
        magicBounceAffected, AttackUp1, WillOWispDesc); //Needs anim
    public static MoveData Memento = SingleTargetStatusMove(
        "Memento", Dark, 100, 0, MoveEffect.Memento, 10,
        noFlag, HealSwitchedMon100, MementoDesc); //Needs anim
    public static MoveData Facade = new(
        "Facade", Normal,
        70, 100, 0,
        MoveEffect.Facade, 0,
        true, Single, 20,
        makesContact, FacadeDesc, 140); //Needs anim
    public static MoveData FocusPunch = new(
        "Focus Punch", Fighting,
        150, 100, 9,
        MoveEffect.FocusPunchWindup, 100,
        true, Single, 20,
        effectOnSelfOnly, FocusPunchDesc, 200); //Needs anim
    public static MoveData SmellingSalts = new(
        "Smelling Salts", Normal,
        70, 100, 0,
        MoveEffect.SmellingSalts, 100,
        true, Single, 10,
        makesContact, SmellingSaltsDesc, 140); //Needs anim
    public static MoveData FollowMe = SelfTargetingMove(
        "Follow Me", Normal, 2, MoveEffect.FollowMe, 20,
        noFlag, NormalizeDebuffs, FollowMeDesc); //Needs anim
    public static MoveData NaturePower = new(
        "Nature Power", Normal,
        1, 100, 0,
        MoveEffect.NaturePower, 0,
        false, Single, 20,
        noFlag, NaturePowerDesc, 0); //Needs anim
    public static MoveData Charge = SelfTargetingMove(
        "Charge", Electric, 0, MoveEffect.Charge, 20,
        snatchAffected, SpDefUp1, ChargeDesc); //Needs anim
    public static MoveData Taunt = SingleTargetStatusMove(
        "Taunt", Dark, 100, 0, MoveEffect.Taunt, 20,
        magicBounceAffected, AttackUp1, TauntDesc); //Needs anim
    public static MoveData HelpingHand = new(
        "Helping Hand", Normal,
        0, 100, 5,
        MoveEffect.HelpingHand, 100,
        false, Ally, 20,
        noFlag, HelpingHandDesc,
        0, NormalizeDebuffs); //Needs anim
    public static MoveData Trick = SingleTargetStatusMove(
        "Trick", Type.Psychic, 100, 0, MoveEffect.Trick, 10,
        noFlag, SpeedUp2, TrickDesc); //Needs anim
    public static MoveData RolePlay = SingleTargetStatusMove(
        "Role Play", Type.Psychic, 100, 0, MoveEffect.RolePlay, 10,
        noFlag, SpeedUp1, RolePlayDesc); //Needs anim
    public static MoveData Wish = SelfTargetingMove(
        "Wish", Normal, 0, MoveEffect.Wish, 10,
        snatchAffected + healBlockAffected, SpDefUp1, WishDesc); //Needs anim
    public static MoveData Assist = SelfTargetingMove(
        "Assist", Normal, 0, MoveEffect.Assist, 20,
        noFlag, 0, AssistDesc); //Needs anim
    public static MoveData Ingrain = SelfTargetingMove(
        "Ingrain", Grass, 0, MoveEffect.Ingrain, 20,
        snatchAffected, SpDefUp1, IngrainDesc); //Needs anim
    public static MoveData Superpower = new(
        "Superpower", Fighting,
        120, 100, 0,
        MoveEffect.AttackDefenseDown1, 100,
        true, Single, 5,
        effectOnSelfOnly + makesContact, SuperpowerDesc, 190); //Needs anim
    public static MoveData MagicCoat = SelfTargetingMove(
        "Magic Coat", Type.Psychic, 4, MoveEffect.MagicCoat, 15,
        noFlag, SpDefUp2, MagicCoatDesc); //Needs anim
    public static MoveData Recycle = SelfTargetingMove(
        "Recycle", Normal, 0, MoveEffect.Recycle, 10,
        snatchAffected, SpeedUp2, RecycleDesc); //Needs anim
    public static MoveData Revenge = new(
        "Revenge", Fighting,
        60, 100, -4,
        MoveEffect.Revenge, 0,
        true, Single, 10,
        makesContact, RevengeDesc, 120); //Needs anim
    public static MoveData BrickBreak = new(
        "Brick Break", Fighting,
        75, 100, 0,
        MoveEffect.BreakScreens, 100,
        true, Single, 15,
        makesContact, BrickBreakDesc, 140); //Needs anim
    public static MoveData Yawn = SingleTargetStatusMove(
        "Yawn", Normal, 100, 0, MoveEffect.Yawn, 10,
        magicBounceAffected, SpeedUp1, YawnDesc); //Needs anim
    public static MoveData KnockOff = new(
        "Knock Off", Dark,
        65, 100, 0,
        MoveEffect.KnockOff, 100,
        true, Single, 20,
        makesContact, KnockOffDesc, 120); //Needs anim
    public static MoveData Endeavor = new(
        "Endeavor", Normal,
        1, 100, 0,
        MoveEffect.Endeavor, 0,
        true, Single, 5,
        makesContact, EndeavorDesc, 160); //Needs anim
    public static MoveData Eruption = new(
        "Eruption", Fire,
        150, 100, 0,
        MoveEffect.HealthPower, 0,
        false, SpreadMove, 5,
        noFlag, EruptionDesc, 200); //Needs anim
    public static MoveData SkillSwap = SingleTargetStatusMove(
        "Skill Swap", Type.Psychic, 100, 0, MoveEffect.SkillSwap, 10,
        noFlag, SpeedUp1, SkillSwapDesc); //Needs anim
    public static MoveData Imprison = SelfTargetingMove(
        "Imprison", Type.Psychic, 0, MoveEffect.Imprison, 10,
        snatchAffected, SpDefUp2, ImprisonDesc); //Needs anim
    public static MoveData Refresh = SelfTargetingMove(
        "Refresh", Normal, 0, MoveEffect.HealStatus, 20,
        snatchAffected, Heal100, RefreshDesc); //Needs anim
    public static MoveData Grudge = SelfTargetingMove(
        "Grudge", Ghost, 0, MoveEffect.Grudge, 5,
        noFlag, ZMoveEffect.FollowMe, GrudgeDesc); //Needs anim
    public static MoveData Snatch = SelfTargetingMove(
        "Snatch", Dark, 4, MoveEffect.Snatch, 10,
        noFlag, SpeedUp2, SnatchDesc); //Needs anim
    public static MoveData SecretPower = new(
        "Secret Power", Normal,
        70, 100, 0,
        MoveEffect.SecretPower, 30,
        true, Single, 20,
        noFlag, SecretPowerDesc, 140); //Needs anim, including different anims based on terrain
    public static MoveData Dive = new(
        "Dive", Water,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        noFlag, DiveDesc, 160); //Needs anim
    public static MoveData ArmThrust = new(
        "Arm Thrust", Fighting,
        15, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 20,
        makesContact, ArmThrustDesc, 100); //Needs anim
    public static MoveData Camouflage = SelfTargetingMove(
        "Camouflage", Normal, 0, MoveEffect.Camouflage, 20,
        snatchAffected, EvasionUp1, CamouflageDesc); //Needs anim
    public static MoveData TailGlow = SelfTargetingMove(
        "Tail Glow", Bug, 0, MoveEffect.SpAtkUp3, 20,
        snatchAffected, NormalizeDebuffs, TailGlowDesc); //Needs anim
    public static MoveData LusterPurge = new(
        "Luster Purge", Type.Psychic,
        70, 100, 0,
        MoveEffect.SpDefDown1, 50,
        false, Single, 5,
        noFlag, LusterPurgeDesc, 140); //Needs anim
    public static MoveData MistBall = new(
        "Mist Ball", Type.Psychic,
        70, 100, 0,
        MoveEffect.SpAtkDown1, 50,
        false, Single, 5,
        bulletMove, MistBallDesc, 140); //Needs anim
    public static MoveData FeatherDance = SingleTargetStatusMove(
        "Feather Dance", Flying, 100, 0, MoveEffect.AttackDown2, 15,
        magicBounceAffected, DefenseUp1, FeatherDanceDesc); //Needs anim
    public static MoveData TeeterDance = new(
        "Teeter Dance", Normal,
        0, 100, 0,
        MoveEffect.Confuse, 100,
        false, Surrounding, 20,
        noFlag, TeeterDanceDesc,
        0, SpAtkUp1); //Needs anim
    public static MoveData BlazeKick = new(
        "Blaze Kick", Fire,
        85, 90, 0,
        MoveEffect.Burn, 10,
        true, Single, 10,
        makesContact + highCrit, BlazeKickDesc, 160); //Needs anim
    public static MoveData MudSport = FieldMove(
        "Mud Sport", Ground, 0, MoveEffect.MudSport, 15,
        noFlag, SpDefUp1, MudSportDesc); //Needs anim
    public static MoveData IceBall = new(
        "Ice Ball", Ice,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact + bulletMove, IceBallDesc, 100); //Needs anim
    public static MoveData NeedleArm = new(
        "Needle Arm", Grass,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, NeedleArmDesc, 120); //Needs anim
    public static MoveData SlackOff = SelfTargetingMove(
        "Slack Off", Normal, 0, MoveEffect.Heal50, 5,
        snatchAffected + healBlockAffected, NormalizeDebuffs, SlackOffDesc); //Needs anim
    public static MoveData HyperVoice = new(
        "Hyper Voice", Normal,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        soundMove, HyperVoiceDesc, 175); //Needs anim
    public static MoveData PoisonFang = new(
        "Poison Fang", Poison,
        50, 100, 0,
        MoveEffect.Toxic, 50,
        true, Single, 15,
        makesContact, PoisonFangDesc, 100); //Needs anim
    public static MoveData CrushClaw = new(
        "Crush Claw", Normal,
        75, 95, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 10,
        makesContact, CrushClawDesc, 140); //Needs anim
    public static MoveData BlastBurn = new(
        "Blast Burn", Fire,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, BlastBurnDesc, 200); //Needs anim
    public static MoveData HydroCannon = new(
        "Hydro Cannon", Water,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, HydroCannonDesc, 200); //Needs anim
    public static MoveData MeteorMash = new(
        "Meteor Mash", Steel,
        90, 90, 0,
        MoveEffect.AttackUp1, 20,
        true, Single, 10,
        makesContact + effectOnSelfOnly, MeteorMashDesc, 175); //Needs anim
    public static MoveData Astonish = new(
        "Astonish", Ghost,
        30, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, AstonishDesc, 100); //Needs anim
    public static MoveData WeatherBall = new(
        "Weather Ball", Normal,
        50, 100, 0,
        MoveEffect.WeatherBall, 0,
        false, Single, 10,
        bulletMove, WeatherBallDesc, 160); //Needs anim
    public static MoveData Aromatherapy = FieldMove(
        "Aromatherapy", Grass, 0, MoveEffect.HealBell, 5,
        snatchAffected, Heal100, AromatherapyDesc); //Needs anim
    public static MoveData FakeTears = SingleTargetStatusMove(
        "Fake Tears", Dark, 100, 0, MoveEffect.SpDefDown2, 20,
        magicBounceAffected, SpAtkUp1, FakeTearsDesc); //Needs anim
    public static MoveData AirCutter = new(
        "Air Cutter", Flying,
        60, 95, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 25,
        highCrit + sharpnessBoosted + windMove, AirCutterDesc, 120); //Needs anim
    public static MoveData Overheat = new(
        "Overheat", Fire,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, OverheatDesc, 195); //Needs anim
    public static MoveData OdorSleuth = SingleTargetStatusMove(
        "Odor Sleuth", Normal, 101, 0,
        MoveEffect.Foresight, 40,
        magicBounceAffected, AttackUp1, OdorSleuthDesc); //Needs anim
    public static MoveData RockTomb = new(
        "Rock Tomb", Rock,
        60, 95, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 15,
        noFlag, RockTombDesc, 120); //Needs anim
    public static MoveData SilverWind = new(
        "Silver Wind", Bug,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5,
        effectOnSelfOnly, SilverWindDesc, 120); //Needs anim
    public static MoveData MetalSound = SingleTargetStatusMove(
        "Metal Sound", Steel, 85, 0, MoveEffect.SpDefDown2, 40,
        soundMove + magicBounceAffected, SpAtkUp1, MetalSoundDesc); //Needs anim
    public static MoveData GrassWhistle = SingleTargetStatusMove(
        "Grass Whistle", Grass, 55, 0, MoveEffect.Sleep, 15,
        soundMove + magicBounceAffected, SpeedUp1, GrassWhistleDesc); //Needs anim
    public static MoveData Tickle = SingleTargetStatusMove(
        "Tickle", Normal, 100, 0, MoveEffect.AttackDefenseDown1, 20,
        magicBounceAffected, DefenseUp1, TickleDesc); //Needs anim
    public static MoveData CosmicPower = SelfTargetingMove(
        "Cosmic Power", Type.Psychic, 0, MoveEffect.DefenseSpDefUp1, 20,
        snatchAffected, SpDefUp1, CosmicPowerDesc); //Needs anim
    public static MoveData WaterSpout = new(
        "Water Spout", Water,
        150, 100, 0,
        MoveEffect.HealthPower, 0,
        false, SpreadMove, 5,
        noFlag, WaterSpoutDesc, 200); //Needs anim
    public static MoveData SignalBeam = new(
        "Signal Beam", Bug,
        75, 100, 0,
        MoveEffect.Confuse, 10,
        false, Single, 15,
        noFlag, SignalBeamDesc, 140); //Needs anim
    public static MoveData ShadowPunch = new(
        "Shadow Punch", Ghost,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact + punchMove, ShadowPunchDesc, 120); //Needs anim
    public static MoveData Extrasensory = new(
        "Extrasensory", Type.Psychic,
        80, 100, 0,
        MoveEffect.Flinch, 10,
        false, Single, 20,
        noFlag, ExtrasensoryDesc, 160); //Needs anim
    public static MoveData SkyUppercut = new(
        "Sky Uppercut", Fighting,
        85, 90, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        hitFlyingMon + makesContact + punchMove, SkyUppercutDesc, 160); //Needs anim
    public static MoveData SandTomb = new(
        "Sand Tomb", Ground,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Single, 15,
        noFlag, SandTombDesc, 100); //Needs anim
    public static MoveData SheerCold = new(
        "Sheer Cold", Ice,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        false, Single, 5,
        noFlag, SheerColdDesc, 180); //Needs anim
    public static MoveData MuddyWater = new(
        "Muddy Water", Water,
        90, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, SpreadMove, 10,
        noFlag, MuddyWaterDesc, 175); //Needs anim
    public static MoveData BulletSeed = new(
        "Bullet Seed", Grass,
        25, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 30,
        bulletMove, BulletSeedDesc, 140); //Needs anim
    public static MoveData AerialAce = new(
        "Aerial Ace", Flying,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Single, 20,
        makesContact + sharpnessBoosted, AerialAceDesc, 120); //Needs anim
    public static MoveData IcicleSpear = new(
        "Icicle Spear", Ice,
        25, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 30,
        noFlag, IcicleSpearDesc, 140); //Needs anim
    public static MoveData IronDefense = SelfTargetingMove(
        "Iron Defense", Steel, 0, MoveEffect.DefenseUp2, 15,
        snatchAffected, NormalizeDebuffs, IronDefenseDesc); //Needs anim
    public static MoveData Block = SingleTargetStatusMove(
        "Block", Normal, 101, 0, MoveEffect.Trap, 5,
        magicBounceAffected, DefenseUp1, BlockDesc); //Needs anim
    public static MoveData Howl = new(
        "Howl", Normal,
        0, 101, 0,
        MoveEffect.AttackUp1, 100,
        false, Ally + Self + Spread + Ranged, 40,
        soundMove + snatchAffected, HowlDesc,
        0, AttackUp1); //Needs anim
    public static MoveData DragonClaw = new(
        "Dragon Claw", Dragon,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        makesContact, DragonClawDesc, 160); //Needs anim
    public static MoveData FrenzyPlant = new(
        "Frenzy Plant", Grass,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        false, Single, 5,
        noFlag, FrenzyPlantDesc, 200); //Needs anim
    public static MoveData BulkUp = SelfTargetingMove(
        "Bulk Up", Fighting, 0, MoveEffect.AttackDefenseUp1, 20,
        snatchAffected, AttackUp1, BulkUpDesc); //Needs anim
    public static MoveData Bounce = new(
        "Bounce", Flying,
        85, 85, 0,
        MoveEffect.ChargingAttack, 100,
        true, Single, 5,
        gravityDisabled, BounceDesc, 160); //Needs anim
    public static MoveData MudShot = new(
        "Mud Shot", Ground,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, Single, 15,
        noFlag, MudShotDesc, 100); //Needs anim
    public static MoveData PoisonTail = new(
        "Poison Tail", Poison,
        50, 100, 0,
        MoveEffect.Poison, 10,
        true, Single, 25,
        highCrit + makesContact, PoisonTailDesc, 100); //Needs anim
    public static MoveData Covet = new(
        "Covet", Normal,
        60, 100, 0,
        MoveEffect.Thief, 100,
        true, Single, 25,
        makesContact, CovetDesc, 120); //Needs anim
    public static MoveData VoltTackle = new(
        "Volt Tackle", Electric,
        120, 100, 0,
        MoveEffect.VoltTackle, 10,
        true, Single, 15,
        makesContact, VoltTackleDesc, 190); //Needs anim
    public static MoveData MagicalLeaf = new(
        "Magical Leaf", Grass,
        60, 101, 0,
        MoveEffect.Hit, 20,
        false, Single, 20,
        noFlag, MagicalLeafDesc, 120); //Needs anim
    public static MoveData WaterSport = FieldMove(
        "Water Sport", Water, 0, MoveEffect.WaterSport, 15,
        noFlag, SpDefUp1, WaterSpoutDesc); //Needs anim
    public static MoveData CalmMind = SelfTargetingMove(
        "Calm Mind", Type.Psychic, 0, MoveEffect.SpAtkSpDefUp1, 20,
        snatchAffected, NormalizeDebuffs, CalmMindDesc); //Needs anim
    public static MoveData LeafBlade = new(
        "Leaf Blade", Grass,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 15,
        highCrit + sharpnessBoosted, LeafBladeDesc, 175); //Needs anim
    public static MoveData DragonDance = SelfTargetingMove(
        "Dragon Dance", Dragon, 0, MoveEffect.AttackSpeedUp1, 20,
        snatchAffected, NormalizeDebuffs, DragonDanceDesc); //Needs anim
    public static MoveData RockBlast = new(
        "Rock Blast", Rock,
        25, 90, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        bulletMove, RockBlastDesc, 140); //Needs anim
    public static MoveData ShockWave = new(
        "Shock Wave", Electric,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, Single, 20,
        noFlag, ShockWaveDesc, 120); //Needs anim
    public static MoveData WaterPulse = new(
        "Water Pulse", Water,
        60, 100, 0,
        MoveEffect.Confuse, 30,
        false, Single + Ranged, 20,
        megaLauncherBoosted, WaterPulseDesc, 120); //Needs anim
    public static MoveData DoomDesire = new(
        "Doom Desire", Steel,
        140, 100, 0,
        MoveEffect.FutureSight, 100,
        false, Single, 5,
        noFlag, DoomDesireDesc, 200); //Needs anim
    public static MoveData PsychoBoost = new(
        "Psycho Boost", Type.Psychic,
        140, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, PsychoBoostDesc, 200); //Needs anim

    //Gen 4

    public static MoveData Roost = SelfTargetingMove(
        "Roost", Flying, 0, MoveEffect.Roost, 5,
        snatchAffected, NormalizeDebuffs, RoostDesc); //Needs anim
    public static MoveData Gravity = FieldMove(
        "Gravity", Type.Psychic, 0, MoveEffect.Gravity, 5,
        noFlag, SpAtkUp1, GravityDesc); //Needs anim
    public static MoveData MiracleEye = SingleTargetStatusMove(
        "Miracle Eye", Type.Psychic, 101, 0, MoveEffect.MiracleEye, 40,
        magicBounceAffected, SpAtkUp1, MiracleEyeDesc); //Needs anim
    public static MoveData WakeUpSlap = new(
        "Wake-Up Slap", Fighting,
        70, 100, 0,
        MoveEffect.WakeUpSlap, 100,
        true, Single, 10,
        makesContact, WakeUpSlapDesc, 140); //Needs anim
    public static MoveData HammerArm = new(
        "Hammer Arm", Fighting,
        100, 100, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 10,
        makesContact + punchMove + effectOnSelfOnly, HammerArmDesc, 180); //Needs anim
    public static MoveData GyroBall = new(
        "Gyro Ball", Steel,
        1, 100, 0,
        MoveEffect.LowSpeedPower, 0,
        true, Single, 5,
        makesContact, GyroBallDesc, 160); //Needs anim
    public static MoveData HealingWish = SelfTargetingMove(
        "Healing Wish", Type.Psychic, 0, MoveEffect.HealingWish, 10,
        snatchAffected + healBlockAffected, 0, HealingWishDesc); //Needs anim
    public static MoveData Brine = new(
        "Brine", Water,
        65, 100, 0,
        MoveEffect.Brine, 100,
        false, Single, 10,
        noFlag, BrineDesc, 120); //Needs anim
    public static MoveData NaturalGift = new(
        "Natural Gift", Normal,
        1, 100, 0,
        MoveEffect.NaturalGift, 0,
        true, Single, 15,
        noFlag, NaturalGiftDesc, 160); //Needs anim
    public static MoveData Feint = new(
        "Feint", Normal,
        30, 100, 2,
        MoveEffect.Feint, 100,
        true, Single, 10,
        makesContact, FeintDesc, 100); //Needs anim
    public static MoveData Pluck = new(
        "Pluck", Flying,
        60, 100, 0,
        MoveEffect.Pluck, 100,
        true, Single, 20,
        makesContact, PluckDesc, 120); //Needs anim
    public static MoveData Tailwind = FieldMove(
        "Tailwind", Flying, 0, MoveEffect.Tailwind, 15,
        snatchAffected + windMove, CritRateUp2, TailwindDesc); //Needs anim
    public static MoveData Acupressure = new(
        "Acupressure", Normal,
        0, 101, 0,
        MoveEffect.Acupressure, 100,
        false, Ally + Self, 30,
        noFlag, AssuranceDesc,
        0, CritRateUp2); //Needs anim
    public static MoveData MetalBurst = new(
        "Metal Burst", Steel,
        1, 100, 0,
        MoveEffect.MetalBurst, 0,
        true, Target.None, 10,
        noFlag, MetalBurstDesc, 100); //Needs anim
    public static MoveData UTurn = new(
        "U-Turn", Bug,
        70, 100, 0,
        MoveEffect.SwitchHit, 100,
        true, Single, 20,
        effectOnSelfOnly + makesContact, UTurnDesc, 140); //Needs anim
    public static MoveData CloseCombat = new(
        "Close Combat", Fighting,
        120, 100, 0,
        MoveEffect.DefenseSpDefDown1, 100,
        true, Single, 5,
        effectOnSelfOnly + makesContact, CloseCombatDesc, 190); //Needs anim
    public static MoveData Payback = new(
        "Payback", Dark,
        50, 100, 0,
        MoveEffect.Payback, 0,
        true, Single, 10,
        makesContact, PaybackDesc, 100); //Needs anim
    public static MoveData Assurance = new(
        "Assurance", Dark,
        60, 100, 0,
        MoveEffect.Assurance, 0,
        true, Single, 15,
        makesContact, AssuranceDesc, 120); //Needs anim
    public static MoveData Embargo = SingleTargetStatusMove(
        "Embargo", Dark, 100, 0, MoveEffect.Embargo, 15,
        magicBounceAffected, SpAtkUp1, EmbargoDesc);
    public static MoveData Fling = new(
        "Fling", Dark,
        1, 100, 0,
        MoveEffect.Fling, 100,
        true, Single, 10,
        noFlag, FlingDesc, 100); //Needs anim
    public static MoveData PsychoShift = SingleTargetStatusMove(
        "Psycho Shift", Type.Psychic, 100, 0, MoveEffect.PsychoShift, 10,
        noFlag, SpAtkUp2, PsychoShiftDesc); //Needs anim
    public static MoveData TrumpCard = new(
        "Trump Card", Normal,
        1, 100, 0,
        MoveEffect.TrumpCard, 0,
        false, Single, 5,
        noFlag, TrumpCardDesc, 160); //Needs anim
    public static MoveData HealBlock = new(
        "Heal Block", Type.Psychic,
        0, 100, 0,
        MoveEffect.HealBlock, 100,
        false, SpreadMove, 15,
        magicBounceAffected, HealBlockDesc,
        0, SpAtkUp2); //Needs anim
    public static MoveData WringOut = new(
        "Wring Out", Normal,
        120, 100, 0,
        MoveEffect.TargetHealthPower, 0,
        false, Single, 5,
        noFlag, WringOutDesc, 190); //Needs anim
    public static MoveData PowerTrick = SelfTargetingMove(
        "Power Trick", Type.Psychic, 0, MoveEffect.PowerTrick, 10,
        snatchAffected, AttackUp1, PowerTrickDesc); //Needs anim
    public static MoveData GastroAcid = SingleTargetStatusMove(
        "Gastro Acid", Poison, 100, 0, MoveEffect.SuppressAbility, 10,
        magicBounceAffected, SpeedUp1, GastroAcidDesc); //Needs anim
    public static MoveData LuckyChant = FieldMove(
        "Lucky Chant", Normal, 0, MoveEffect.LuckyChant, 30,
        snatchAffected, EvasionUp1, LuckyChantDesc); //Needs anim
    public static MoveData MeFirst = SingleTargetStatusMove(
        "Me First", Normal, 101, 0, MoveEffect.MeFirst, 20,
        noFlag, SpeedUp2, MeFirstDesc); //Needs anim
    public static MoveData Copycat = SelfTargetingMove(
        "Copycat", Normal, 0, MoveEffect.Copycat, 20,
        noFlag, AccuracyUp1, CopycatDesc); //Needs anim
    public static MoveData PowerSwap = SingleTargetStatusMove(
        "Power Swap", Type.Psychic, 101, 0, MoveEffect.PowerSwap, 10,
        noFlag, SpeedUp1, PowerSwapDesc); //Needs anim
    public static MoveData GuardSwap = SingleTargetStatusMove(
        "Guard Swap", Type.Psychic, 101, 0, MoveEffect.GuardSwap, 10,
        noFlag, SpeedUp1, GuardSwapDesc); //Needs anim
    public static MoveData Punishment = new(
        "Punishment", Dark,
        60, 100, 0,
        MoveEffect.TargetStatPower, 0,
        true, Single, 5,
        makesContact, PunishmentDesc, 160); //Needs anim
    public static MoveData LastResort = new(
        "Last Resort", Normal,
        140, 100, 0,
        MoveEffect.LastResort, 0,
        true, Single, 5,
        makesContact, LastResortDesc, 200); //Needs anim
    public static MoveData WorrySeed = SingleTargetStatusMove(
        "Worry Seed", Grass, 100, 0, MoveEffect.WorrySeed, 10,
        magicBounceAffected, SpeedUp1, WorrySeedDesc); //Needs anim
    public static MoveData SuckerPunch = new(
        "Sucker Punch", Dark,
        70, 100, 1,
        MoveEffect.SuckerPunch, 0,
        true, Single, 5,
        makesContact, SuckerPunchDesc, 140); //Needs anim
    public static MoveData ToxicSpikes = FieldMove(
        "Toxic Spikes", Poison, 0, MoveEffect.ToxicSpikes, 20,
        magicBounceAffected, DefenseUp1, ToxicSpikesDesc); //Needs anim
    public static MoveData HeartSwap = SingleTargetStatusMove(
        "Heart Swap", Type.Psychic, 101, 0, MoveEffect.HeartSwap, 10,
        noFlag, CritRateUp2, HeartSwapDesc); //Needs anim
    public static MoveData AquaRing = SelfTargetingMove(
        "Aqua Ring", Water, 0, MoveEffect.AquaRing, 20,
        snatchAffected, DefenseUp1, AquaRingDesc); //Needs anim
    public static MoveData MagnetRise = SelfTargetingMove(
        "Magnet Rise", Electric, 0, MoveEffect.MagnetRise, 10,
        snatchAffected, EvasionUp1, MagnetRiseDesc); //Needs anim
    public static MoveData FlareBlitz = new(
        "Flare Blitz", Fire,
        120, 100, 0,
        MoveEffect.FlareBlitz, 10,
        true, Single, 15,
        makesContact, FlareBlitzDesc, 190); //Needs anim
    public static MoveData ForcePalm = new(
        "Force Palm", Fighting,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 10,
        makesContact, ForcePalmDesc, 120); //Needs anim
    public static MoveData AuraSphere = SingleTargetNoAddedEffect(
        "Aura Sphere", Fighting, 80, 101, 0, false, 20,
        megaLauncherBoosted + bulletMove, 160, AuraSphereDesc); //Needs anim
    public static MoveData RockPolish = SelfTargetingMove(
        "Rock Polish", Rock, 0, MoveEffect.SpeedUp2, 20,
        snatchAffected, NormalizeDebuffs, RockPolishDesc); //Needs anim
    public static MoveData PoisonJab = new(
        "Poison Jab", Poison,
        80, 100, 0,
        MoveEffect.Poison, 30,
        true, Single, 20,
        makesContact, PoisonJabDesc, 160); //Needs anim
    public static MoveData DarkPulse = new(
        "Dark Pulse", Dark,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        false, Single + Ranged, 15,
        megaLauncherBoosted, DarkPulseDesc, 160); //Needs anim
    public static MoveData NightSlash = SingleTargetNoAddedEffect(
        "Night Slash", Dark, 70, 100, 0, true, 15,
        highCrit + sharpnessBoosted + makesContact, 140, NightSlashDesc); //Needs anim
    public static MoveData AquaTail = SingleTargetNoAddedEffect(
        "Aqua Tail", Water, 90, 90, 0, true, 10,
        makesContact, 175, AquaTailDesc); //Needs anim
    public static MoveData SeedBomb = SingleTargetNoAddedEffect(
        "Seed Bomb", Grass, 80, 100, 0, true, 15,
        bulletMove,160, SeedBombDesc); //Needs anim
    public static MoveData AirSlash = new(
        "Air Slash", Flying,
        75, 95, 0,
        MoveEffect.Flinch, 30,
        false, Single, 15,
        noFlag, AirSlashDesc, 140); //Needs anim
    public static MoveData XScissor = SingleTargetNoAddedEffect(
        "X-Scissor", Bug, 80, 100, 0, true, 15,
        makesContact + sharpnessBoosted, 160, XScissorDesc); //Needs anim
    public static MoveData BugBuzz = new(
        "Bug Buzz", Bug,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        soundMove, BugBuzzDesc, 175); //Needs anim
    public static MoveData DragonPulse = new(
        "Dragon Pulse", Dragon,
        85, 100, 0,
        MoveEffect.Hit, 0,
        false, Single + Ranged, 10,
        megaLauncherBoosted, DragonPulseDesc, 160); //Needs anim
    public static MoveData DragonRush = new(
        "Dragon Rush", Dragon,
        100, 75, 0,
        MoveEffect.Flinch, 20,
        true, Single, 10,
        makesContact + alwaysHitsMinimized, DragonRushDesc, 180); //Needs anim
    public static MoveData PowerGem = SingleTargetNoAddedEffect(
        "Power Gem", Rock, 80, 100, 0, false, 20,
        noFlag, 160, PowerGemDesc); //Needs anim
    public static MoveData DrainPunch = new(
        "Drain Punch", Fighting,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        true, Single, 10,
        makesContact + effectOnSelfOnly + healBlockAffected
        + punchMove, DrainPunchDesc, 140); //Needs anim
    public static MoveData VacuumWave = SingleTargetNoAddedEffect(
        "Vacuum Wave", Fighting, 40, 100, 1, false, 30,
        noFlag, 100, VacuumWaveDesc); //Needs anim
    public static MoveData FocusBlast = new(
        "Focus Blast", Fighting,
        120, 70, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 5,
        bulletMove, FocusBlastDesc, 190); //Needs anim
    public static MoveData EnergyBall = new(
        "Energy Ball", Grass,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        bulletMove, EnergyBallDesc, 175); //Needs anim
    public static MoveData BraveBird = new(
        "Brave Bird", Flying,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, BraveBirdDesc, 190); //Needs anim
    public static MoveData EarthPower = new(
        "Earth Power", Ground,
        90, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        noFlag, EarthPowerDesc, 175); //Needs anim
    public static MoveData Switcheroo = SingleTargetStatusMove(
        "Switcheroo", Dark, 100, 0, MoveEffect.Trick, 10,
        noFlag, SpeedUp2, SwitcherooDesc); //Needs anim
    public static MoveData GigaImpact = new(
        "Giga Impact", Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        true, Single, 5,
        makesContact, GigaImpactDesc, 200); //Needs anim
    public static MoveData NastyPlot = SelfTargetingMove(
        "Nasty Plot", Dark, 0, MoveEffect.SpAtkUp2, 20,
        snatchAffected, NormalizeDebuffs, NastyPlotDesc); //Needs anim
    public static MoveData BulletPunch = SingleTargetNoAddedEffect(
        "Bullet Punch", Steel, 40, 100, 1, true, 30,
        makesContact + punchMove, 100, BulletPunchDesc); //Needs anim
    public static MoveData Avalanche = new(
        "Avalanche", Ice,
        60, 100, -4,
        MoveEffect.Revenge, 0,
        true, Single, 10,
        makesContact, AvalancheDesc, 120); //Needs anim
    public static MoveData IceShard = SingleTargetNoAddedEffect(
        "Ice Shard", Ice, 40, 100, 1, true, 30,
        noFlag, 100, IceShardDesc); //Needs anim
    public static MoveData ShadowClaw = SingleTargetNoAddedEffect(
        "Shadow Claw", Ghost, 70, 100, 0, true, 15,
        highCrit, 140, ShadowClawDesc); //Needs anim
    public static MoveData ThunderFang = new(
        "Thunder Fang", Electric,
        65, 95, 0,
        MoveEffect.Paralyze, 10,
        true, Single, 15,
        makesContact + extraFlinch10, ThunderFangDesc, 120); //Needs anim
    public static MoveData IceFang = new(
        "Ice Fang", Ice,
        65, 95, 0,
        MoveEffect.Freeze, 10,
        true, Single, 15,
        makesContact + extraFlinch10, IceFangDesc, 120); //Needs anim
    public static MoveData FireFang = new(
        "Fire Fang", Fire,
        65, 95, 0,
        MoveEffect.Burn, 10,
        true, Single, 15,
        makesContact + extraFlinch10, FireFangDesc, 120); //Needs anim
    public static MoveData ShadowSneak = SingleTargetNoAddedEffect(
        "Shadow Sneak", Ghost, 40, 100, 0, true, 30,
        makesContact, 100, ShadowSneakDesc); //Needs anim
    public static MoveData MudBomb = new(
        "Mud Bomb", Ground,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, Single, 10,
        bulletMove, MudBombDesc, 120); //Needs anim
    public static MoveData PsychoCut = SingleTargetNoAddedEffect(
        "Psycho Cut", Type.Psychic, 70, 100, 0, true, 20,
        highCrit + sharpnessBoosted, 140, PsychoCutDesc); //Needs anim
    public static MoveData ZenHeadbutt = new(
        "Zen Headbutt", Type.Psychic,
        80, 90, 0,
        MoveEffect.Flinch, 20,
        true, Single, 15,
        makesContact, ZenHeadbuttDesc, 160); //Needs anim
    public static MoveData MirrorShot = new(
        "Mirror Shot", Steel,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 30,
        false, Single, 10,
        noFlag, MirrorShotDesc, 120); //Needs anim
    public static MoveData FlashCannon = new(
        "Flash Cannon", Steel,
        80, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Single, 10,
        noFlag, FlashCannonDesc, 160); //Needs anim
    public static MoveData RockClimb = new(
        "Rock Climb", Normal,
        90, 85, 0,
        MoveEffect.Confuse, 20,
        true, Single, 20,
        noFlag, RockClimbDesc, 175); //Needs anim
    public static MoveData Defog = SingleTargetStatusMove(
        "Defog", Flying, 100, 0, MoveEffect.Defog, 15,
        noFlag, AccuracyUp1, DefogDesc); //Needs anim
    public static MoveData TrickRoom = FieldMove(
        "Trick Room", Type.Psychic, -7, MoveEffect.TrickRoom, 5,
        noFlag, AccuracyUp1, TrickRoomDesc); //Neeeds anim
    public static MoveData DracoMeteor = new(
        "Draco Meteor", Dragon,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, DracoMeteorDesc, 195); //Needs anim
    public static MoveData Discharge = new(
        "Discharge", Electric,
        80, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Surrounding, 15,
        noFlag, DischargeDesc, 160); //Needs anim
    public static MoveData LavaPlume = new(
        "Lava Plume", Fire,
        80, 100, 0,
        MoveEffect.Burn, 30,
        false, Surrounding, 15,
        noFlag, LavaPlumeDesc, 160); //Needs anim
    public static MoveData LeafStorm = new(
        "Leaf Storm", Grass,
        130, 90, 0,
        MoveEffect.SpAtkDown2, 100,
        false, Single, 5,
        effectOnSelfOnly, LeafStormDesc, 195); //Needs anim
    public static MoveData PowerWhip = SingleTargetNoAddedEffect(
        "Power Whip", Grass, 120, 85, 0, true, 10,
        makesContact, 190, PowerWhipDesc); //Needs anim
    public static MoveData RockWrecker = new(
        "Rock Wrecker", Rock,
        150, 90, 0,
        MoveEffect.Recharge, 100,
        true, Single, 5,
        bulletMove, RockWreckerDesc, 200); //Needs anim
    public static MoveData CrossPoison = new(
        "Cross Poison", Poison,
        70, 100, 0,
        MoveEffect.Poison, 10,
        true, Single, 20,
        makesContact + highCrit, CrossPoisonDesc, 140); //Needs anim
    public static MoveData GunkShot = new(
        "Gunk Shot", Poison,
        120, 80, 0,
        MoveEffect.Poison, 30,
        true, Single, 5,
        noFlag, GunkShotDesc, 190); //Needs anim
    public static MoveData IronHead = new(
        "Iron Head", Steel,
        80, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, IronHeadDesc, 160); //Needs anim
    public static MoveData MagnetBomb = SingleTargetNoAddedEffect(
        "Magnet Bomb", Steel, 60, 101, 0, true, 20,
        bulletMove, 120, MagnetBombDesc); //Needs anim
    public static MoveData StoneEdge = SingleTargetNoAddedEffect(
        "Stone Edge", Rock, 100, 80, 0, true, 5,
        highCrit, 180, StoneEdgeDesc); //Needs anim
    public static MoveData Captivate = SingleTargetStatusMove(
        "Captivate", Normal, 100, 0, MoveEffect.Captivate, 20,
        noFlag, SpDefUp2, CaptivateDesc); //Needs anim
    public static MoveData StealthRock = FieldMove(
        "Stealth Rock", Rock, 0, MoveEffect.StealthRock, 20,
        magicBounceAffected, DefenseUp1, StealthRockDesc); //Needs anim 
    public static MoveData GrassKnot = new(
        "Grass Knot", Grass,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        false, Single, 20,
        makesContact, GrassKnotDesc, 160); //Needs anim
    public static MoveData Chatter = new(
        "Chatter", Flying,
        65, 100, 0,
        MoveEffect.Confuse, 100,
        false, Single + Ranged, 20,
        soundMove, ChatterDesc, 120); //Needs anim
    public static MoveData Judgment = new(
        "Judgment", Normal,
        100, 100, 0,
        MoveEffect.Judgement, 0,
        false, Single, 10,
        noFlag, JudgmentDesc, 180); //Needs anim
    public static MoveData BugBite = new(
        "Bug Bite", Bug,
        60, 100, 0,
        MoveEffect.Pluck, 100,
        true, Single, 20,
        makesContact, BugBiteDesc, 120); //Needs anim
    public static MoveData ChargeBeam = new(
        "Charge Beam", Electric,
        50, 90, 0,
        MoveEffect.SpAtkUp1, 70,
        false, Single, 10,
        makesContact, ChargeBeamDesc, 100); //Needs anim
    public static MoveData WoodHammer = new(
        "Wood Hammer", Grass,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 15,
        makesContact, WoodHammerDesc, 190); //Needs anim
    public static MoveData AquaJet = SingleTargetNoAddedEffect(
        "Aqua Jet", Water, 40, 100, 0, true, 20,
        makesContact, 100, AquaJetDesc); //Needs anim
    public static MoveData AttackOrder = SingleTargetNoAddedEffect(
        "Attack Order", Bug, 90, 100, 0, true, 15,
        noFlag, 175, AttackOrderDesc); //Needs anim
    public static MoveData DefendOrder = SelfTargetingMove(
        "Defend Order", Bug, 0, MoveEffect.DefenseSpDefUp1, 10,
        noFlag, DefenseUp1, DefendOrderDesc); //Needs anim
    public static MoveData HealOrder = SelfTargetingMove(
        "Heal Order", Bug, 0, MoveEffect.Heal50, 10,
        healBlockAffected, NormalizeDebuffs, HealOrderDesc); //Needs anim. May also be lowered to 5 PP to match Recover
    public static MoveData HeadSmash = new(
        "Head Smash", Rock,
        150, 80, 0,
        MoveEffect.Recoil33, 0,
        true, Single, 5,
        makesContact, HeadSmashDesc, 200); //Needs anim
    public static MoveData DoubleHit = new(
        "Double Hit", Normal,
        35, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 10,
        makesContact, DoubleHitDesc, 140); //Needs anim
    public static MoveData RoarOfTime = new(
        "Roar of Time", Dragon,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, Single, 5,
        noFlag, RoarOfTimeDesc, 200); //Needs anim
    public static MoveData SpacialRend = SingleTargetNoAddedEffect(
        "Spacial Rend", Dragon, 100, 95, 0, false, 5,
        highCrit, 180, SpacialRendDesc); //Needs anim
    public static MoveData LunarDance = SelfTargetingMove(
        "Lunar Dance", Type.Psychic, 0, MoveEffect.HealingWish, 10,
        snatchAffected + healBlockAffected, 0, LunarDanceDesc); //Needs anim
    public static MoveData CrushGrip = new(
        "Crush Grip", Normal,
        120, 100, 0,
        MoveEffect.TargetHealthPower, 0,
        true, Single, 5,
        makesContact, CrushGripDesc, 190); //Needs anim
    public static MoveData MagmaStorm = new(
        "Magma Storm", Fire,
        100, 75, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Single, 5,
        noFlag, MagmaStormDesc, 180); //Needs anim
    public static MoveData DarkVoid = new(
        "Dark Void", Dark,
        0, 50, 0,
        MoveEffect.Sleep, 100,
        false, SpreadMove, 10,
        magicBounceAffected, DarkVoidDesc,
        0, NormalizeDebuffs); //Needs anim
    public static MoveData SeedFlare = new(
        "Seed Flare", Grass,
        120, 85, 0,
        MoveEffect.SpDefDown2, 40,
        false, Single, 5,
        noFlag, SeedFlareDesc, 190); //Needs anim
    public static MoveData OminousWind = new(
        "Ominous Wind", Ghost,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Single, 5,
        effectOnSelfOnly, OminousWindDesc, 120); //Needs anim
    public static MoveData ShadowForce = new(
        "Shadow Force", Ghost,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5,
        noFlag, ShadowForceDesc, 190); //Needs anim

    //Gen 5
    public static MoveData HoneClaws = SelfTargetingMove(
        "Hone Claws", Dark, 0, MoveEffect.AttackAccuracyUp1, 15,
        snatchAffected, AttackUp1, HoneClawsDesc); //Needs anim
    public static MoveData WideGuard = SelfTargetingMove(
        "Wide Guard", Rock, 3, MoveEffect.WideGuard, 10,
        snatchAffected + incrementsProtectCounter, DefenseUp1, WideGuardDesc); //Needs anim
    public static MoveData GuardSplit = SingleTargetStatusMove(
        "Guard Split", Type.Psychic, 101, 0, MoveEffect.GuardSplit, 10,
        noFlag, SpeedUp1, GuardSplitDesc); //Needs anim
    public static MoveData PowerSplit = SingleTargetStatusMove(
        "Power Split", Type.Psychic, 101, 0, MoveEffect.PowerSplit, 10,
        noFlag, SpeedUp1, PowerSplitDesc); //Needs anim
    public static MoveData WonderRoom = FieldMove(
        "Wonder Room", Type.Psychic, 0, MoveEffect.WonderRoom, 10,
        noFlag, SpDefUp1, WonderRoomDesc); //Needs anim
    public static MoveData Psyshock = new(
        "Psyshock", Type.Psychic,
        80, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, PsyshockDesc, 160); //Needs anim
    public static MoveData Venoshock = new(
        "Venoshock", Poison,
        65, 100, 0,
        MoveEffect.Venoshock, 0,
        false, Single, 10,
        noFlag, VenoshockDesc, 120); //Needs anim
    public static MoveData Autotomize = SelfTargetingMove(
        "Autotomize", Steel, 0, MoveEffect.Autotomize, 15,
        snatchAffected, NormalizeDebuffs, AutotomizeDesc); //Needs anim
    public static MoveData RagePowder = SelfTargetingMove(
        "Rage Powder", Bug, 2, MoveEffect.RagePowder, 20,
        noFlag, NormalizeDebuffs, RagePowderDesc); //Needs anim; the powder move check is handled in Battle.cs
    public static MoveData Telekinesis = SingleTargetStatusMove(
        "Telekinesis", Type.Psychic, 101, 0, MoveEffect.Telekinesis, 15,
        magicBounceAffected, SpAtkUp1, TelekinesisDesc); //Needs anim
    public static MoveData MagicRoom = FieldMove(
        "Magic Room", Type.Psychic, 0, MoveEffect.MagicRoom, 10,
        noFlag, SpDefUp1, MagicRoomDesc); //Needs anim
    public static MoveData SmackDown = new(
        "Smack Down", Rock,
        50, 100, 0,
        MoveEffect.SmackDown, 100,
        true, Single, 15,
        noFlag, SmackDownDesc, 100); //Needs anim
    public static MoveData StormThrow = new(
        "Storm Throw", Fighting,
        60, 100, 0,
        MoveEffect.AlwaysCrit, 0,
        true, Single, 10,
        makesContact, StormThrowDesc, 120); //Needs anim
    public static MoveData FlameBurst = new(
        "Flame Burst", Fire,
        70, 100, 0,
        MoveEffect.FlameBurst, 100,
        false, Single, 15,
        noFlag, FlameBurstDesc, 140); //Needs anim
    public static MoveData SludgeWave = new(
        "Sludge Wave", Poison,
        95, 100, 0,
        MoveEffect.Poison, 10,
        false, Surrounding, 10,
        noFlag, SludgeWaveDesc, 175); //Needs anim
    public static MoveData QuiverDance = SelfTargetingMove(
        "Quiver Dance", Bug, 0, MoveEffect.SpAtkSpDefSpeedUp1, 20,
        snatchAffected, NormalizeDebuffs, QuiverDanceDesc); //Needs anim
    public static MoveData HeavySlam = new(
        "Heavy Slam", Steel,
        1, 100, 0,
        MoveEffect.RelativeWeightPower, 0,
        true, Single, 10,
        makesContact, HeavySlamDesc, 160); //Needs anim
    public static MoveData Synchronoise = new(
        "Synchronoise", Type.Psychic,
        120, 100, 0,
        MoveEffect.Synchronoise, 0,
        false, Surrounding, 10,
        noFlag, SynchronoiseDesc, 190); //Needs anim
    public static MoveData ElectroBall = new(
        "Electro Ball", Electric,
        1, 100, 0,
        MoveEffect.HighSpeedPower, 0,
        false, Single, 10,
        noFlag, ElectroBallDesc, 160); //Needs anim
    public static MoveData Soak = SingleTargetStatusMove(
        "Soak", Water, 100, 0, MoveEffect.Soak, 20,
        magicBounceAffected, SpAtkUp1, SoakDesc); //Needs anim
    public static MoveData FlameCharge = new(
        "Flame Charge", Fire,
        50, 100, 0,
        MoveEffect.SpeedUp1, 100,
        true, Single, 20,
        makesContact + effectOnSelfOnly, FlameChargeDesc, 100); //Needs anim
    public static MoveData Coil = SelfTargetingMove(
        "Coil", Poison, 0, MoveEffect.AttackDefAccUp1, 20,
        snatchAffected, NormalizeDebuffs, CoilDesc); //Needs anim
    public static MoveData LowSweep = new(
        "Low Sweep", Fighting,
        65, 100, 0,
        MoveEffect.SpeedDown1, 100,
        true, Single, 20,
        makesContact, LowSweepDesc, 120); //Needs anim
    public static MoveData AcidSpray = new(
        "Acid Spray", Poison,
        40, 100, 0,
        MoveEffect.SpDefDown2, 101,
        false, Single, 20,
        bulletMove, AcidSprayDesc, 100); //Needs anim
    public static MoveData FoulPlay = new(
        "Foul Play", Dark,
        95, 100, 0,
        MoveEffect.FoulPlay, 0,
        true, Single, 15,
        makesContact, FoulPlayDesc, 175); //Needs anim
    public static MoveData SimpleBeam = SingleTargetStatusMove(
        "Simple Beam", Normal, 100, 0, MoveEffect.SimpleBeam, 15,
        magicBounceAffected, SpAtkUp1, SimpleBeamDesc); //Needs anim
    public static MoveData Entrainment = SingleTargetStatusMove(
        "Entrainment", Normal, 100, 0, MoveEffect.Entrainment, 15,
        magicBounceAffected, SpDefUp1, EntrainmentDesc); //Needs anim
    public static MoveData AfterYou = SingleTargetStatusMove(
        "After You", Normal, 101, 0, MoveEffect.AfterYou, 15,
        noFlag, SpeedUp1, AfterYouDesc); //Needs anim
    public static MoveData Round = new(
        "Round", Normal,
        60, 100, 0,
        MoveEffect.Round, 101,
        false, Single, 15,
        soundMove, RoundDesc, 120); //Needs anim
    public static MoveData EchoedVoice = new(
        "Echoed Voice", Normal,
        40, 100, 0,
        MoveEffect.EchoedVoice, 0,
        false, Single, 15,
        soundMove, EchoedVoiceDesc, 100); //Needs anim
    public static MoveData ChipAway = new(
        "Chip Away", Normal,
        70, 100, 0,
        MoveEffect.IgnoreDefenseStage, 0,
        true, Single, 20,
        makesContact, ChipAwayDesc, 140); //Needs anim
    public static MoveData ClearSmog = new(
        "Clear Smog", Poison,
        50, 101, 0,
        MoveEffect.ClearStats, 100,
        false, Single, 15,
        noFlag, ClearSmogDesc, 100); //Needs anim
    public static MoveData StoredPower = new(
        "Stored Power", Type.Psychic,
        20, 100, 0,
        MoveEffect.UserStatPower, 0,
        false, Single, 10,
        noFlag, StoredPowerDesc, 160); //Needs anim
    public static MoveData QuickGuard = SelfTargetingMove(
        "Quick Guard", Fighting, 3, MoveEffect.QuickGuard, 15,
        snatchAffected, DefenseUp1, QuickGuardDesc); //Needs anim
    public static MoveData AllySwitch = new(
        "Ally Switch", Type.Psychic,
        0, 101, 0,
        MoveEffect.AllySwitch, 101,
        false, Ally, 15,
        usesProtectCounter, AllySwitchDesc,
        0, SpeedUp2); //Needs anim
    public static MoveData Scald = new(
        "Scald", Water,
        80, 100, 0,
        MoveEffect.Burn, 30,
        false, Single, 15,
        noFlag, ScaldDesc, 160); //Needs anim
    public static MoveData ShellSmash = SelfTargetingMove(
        "Shell Smash", Normal, 0, MoveEffect.ShellSmash, 15,
        snatchAffected, NormalizeDebuffs, ShellSmashDesc); //Needs anim
    public static MoveData HealPulse = SingleTargetStatusMove(
        "Heal Pulse", Type.Psychic, 101, 0, MoveEffect.HealPulse, 10,
        healBlockAffected, NormalizeDebuffs, HealPulseDesc); //Needs anim
    public static MoveData Hex = new(
        "Hex", Ghost,
        65, 100, 0,
        MoveEffect.Hex, 0,
        false, Single, 10,
        noFlag, HexDesc, 160); //Needs anim
    public static MoveData SkyDrop = new(
        "Sky Drop", Flying,
        60, 101, 0,
        MoveEffect.SkyDrop, 101,
        true, Single, 10,
        noFlag, SkyDropDesc, 120); //Needs anim
    public static MoveData ShiftGear = SelfTargetingMove(
        "Shift Gear", Steel, 0, MoveEffect.AttackUp1SpeedUp2, 10,
        snatchAffected, NormalizeDebuffs, ShiftGearDesc); //Needs anim
    public static MoveData CircleThrow = new(
        "Circle Throw", Fighting,
        60, 90, -6,
        MoveEffect.ForcedSwitch, 101,
        true, Single, 10,
        makesContact, CircleThrowDesc, 120); //Needs anim
    public static MoveData Incinerate = new(
        "Incinerate", Fire,
        60, 100, 0,
        MoveEffect.Incinerate, 100,
        false, Spread + Opponent, 15,
        noFlag, IncinerateDesc, 120); //Needs anim
    public static MoveData Quash = SingleTargetStatusMove(
        "Quash", Dark, 100, 0, MoveEffect.Quash, 15,
        noFlag, SpeedUp1, QuashDesc); //Needs anim
    public static MoveData Acrobatics = new(
        "Acrobatics", Flying,
        55, 100, 0,
        MoveEffect.Acrobatics, 0,
        true, Single, 15,
        makesContact, AcrobaticsDesc, 100); //Needs anim
    public static MoveData ReflectType = SingleTargetStatusMove(
        "Reflect Type", Normal, 101, 0, MoveEffect.ReflectType, 15,
        noFlag, SpAtkUp1, ReflectTypeDesc); //Needs anim
    public static MoveData Retaliate = new(
        "Retaliate", Normal,
        70, 100, 0,
        MoveEffect.Retaliate, 0,
        true, Single, 5,
        makesContact, RetaliateDesc,140); //Needs anim
    public static MoveData FinalGambit = new(
        "Final Gambit", Fighting,
        1, 100, 0,
        MoveEffect.FinalGambit, 0,
        false, Single, 5,
        noFlag, FinalGambitDesc, 180); //Needs anim
    public static MoveData Bestow = SingleTargetStatusMove(
        "Bestow", Normal, 101, 0, MoveEffect.Bestow, 15,
        noFlag, SpeedUp2, BestowDesc); //Needs anim
    public static MoveData Inferno = new(
        "Inferno", Fire,
        100, 50, 0,
        MoveEffect.Burn, 100,
        false, Single, 5,
        noFlag, InfernoDesc, 180); //Needs anim
    public static MoveData WaterPledge = new(
        "Water Pledge", Water,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, WaterPledgeDesc, 160); //Needs anim
    public static MoveData FirePledge = new(
        "Fire Pledge", Fire,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, FirePledgeDesc, 160); //Needs anim
    public static MoveData GrassPledge = new(
        "Grass Pledge", Grass,
        80, 100, 0,
        MoveEffect.Pledge, 0,
        false, Single, 10,
        noFlag, GrassPledgeDesc, 160); //Needs anim
    //Todo: Test Pledge moves once double battles are working
    public static MoveData VoltSwitch = new(
        "Volt Switch", Electric,
        70, 100, 0,
        MoveEffect.SwitchHit, 100,
        false, Single, 20,
        noFlag, VoltSwitchDesc, 140); //Needs anim
    public static MoveData StruggleBug = new(
        "Struggle Bug", Bug,
        50, 100, 0,
        MoveEffect.SpAtkDown1, 101,
        false, SpreadMove, 20,
        noFlag, StruggleBugDesc, 100); //Needs anim
    public static MoveData Bulldoze = new(
        "Bulldoze", Ground,
        60, 100, 0,
        MoveEffect.SpeedDown1, 101,
        true, Surrounding, 20,
        noFlag, BulldozeDesc, 120); //Needs anim
    public static MoveData FrostBreath = new(
        "Frost Breath", Ice,
        60, 90, 0,
        MoveEffect.AlwaysCrit, 0,
        false, Single, 10,
        noFlag, FrostBreathDesc, 120); //Needs anim
    public static MoveData DragonTail = new(
        "Dragon Tail", Dragon,
        60, 90, -6,
        MoveEffect.ForcedSwitch, 101,
        true, Single, 10,
        makesContact, DragonTailDesc, 120); //Needs anim
    public static MoveData WorkUp = SelfTargetingMove(
        "Work Up", Normal, 0, MoveEffect.AttackSpAtkUp1, 30,
        snatchAffected, AttackUp1, WorkUpDesc); //Needs anim
    public static MoveData Electroweb = new(
        "Electroweb", Electric,
        55, 95, 0,
        MoveEffect.SpeedDown1, 101,
        false, SpreadMove, 15,
        noFlag, ElectrowebDesc, 100); //Needs anim
    public static MoveData WildCharge = new(
        "Wild Charge", Electric,
        90, 100, 0,
        MoveEffect.Recoil25, 101,
        true, Single, 15,
        makesContact, WildChargeDesc, 175); //Needs anim
    public static MoveData DrillRun = new(
        "Drill Run", Ground,
        80, 95, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact + highCrit, DrillRunDesc, 160); //Needs anim
    public static MoveData DualChop = new(
        "Dual Chop", Dragon,
        40, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 15,
        makesContact, DualChopDesc, 100); //Needs anim
    public static MoveData HeartStamp = new(
        "Heart Stamp", Type.Psychic,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 25,
        makesContact, HeartStampDesc, 120); //Needs anim
    public static MoveData HornLeech = new(
        "Horn Leech", Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        true, Single, 10,
        makesContact + healBlockAffected, HornLeechDesc, 140); //Needs anim
    public static MoveData SacredSword = new(
        "Sacred Sword", Fighting,
        90, 100, 0,
        MoveEffect.IgnoreDefenseStage, 0,
        true, Single, 15,
        makesContact + sharpnessBoosted, SacredSwordDesc, 175); //Needs anim
    public static MoveData RazorShell = new(
        "Razor Shell", Water,
        75, 95, 0,
        MoveEffect.DefenseDown1, 50,
        true, Single, 10,
        makesContact + sharpnessBoosted, RazorShellDesc, 140); //Needs anim
    public static MoveData HeatCrash = new(
        "Heat Crash", Fire,
        1, 100, 0,
        MoveEffect.RelativeWeightPower, 0,
        true, Single, 10,
        makesContact, HeatCrashDesc, 160); //Needs anim
    public static MoveData LeafTornado = new(
        "Leaf Tornado", Grass,
        65, 90, 0,
        MoveEffect.AccuracyDown1, 50,
        false, Single, 10,
        noFlag, LeafTornadoDesc, 120); //Needs anim
    public static MoveData Steamroller = new(
        "Steamroller", Bug,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 20,
        makesContact, SteamrollerDesc, 120); //Needs anim
    public static MoveData CottonGuard = SelfTargetingMove(
        "Cotton Guard", Grass, 0, MoveEffect.DefenseUp3, 10,
        snatchAffected, NormalizeDebuffs, CottonGuardDesc); //Needs anim
    public static MoveData NightDaze = new(
        "Night Daze", Dark,
        85, 95, 0,
        MoveEffect.AccuracyDown1, 40,
        false, Single, 10,
        noFlag, NightDazeDesc, 160); //Needs anim
    public static MoveData Psystrike = new(
        "Psystrike", Type.Psychic,
        100, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, PsystrikeDesc, 180); //Needs anim
    public static MoveData TailSlap = new(
        "Tail Slap", Normal,
        25, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Single, 10,
        makesContact, TailSlapDesc, 140); //Needs anim
    public static MoveData Hurricane = new(
        "Hurricane", Flying,
        110, 70, 0,
        MoveEffect.Confuse, 30,
        false, Single + Ranged, 10,
        alwaysHitsInRain + windMove, HurricaneDesc, 185); //Needs anim
    public static MoveData HeadCharge = new(
        "Head Charge", Normal,
        120, 100, 0,
        MoveEffect.Recoil25, 0,
        true, Single, 15,
        makesContact, HeadChargeDesc, 190); //Needs anim
    public static MoveData GearGrind = new(
        "Gear Grind", Steel,
        50, 85, 0,
        MoveEffect.MultiHit2, 0,
        true, Single, 15,
        makesContact, GearGrindDesc, 180); //Needs anim
    public static MoveData SearingShot = new(
        "Searing Shot", Fire,
        100, 100, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        bulletMove, SearingShotDesc, 180); //Needs anim
    public static MoveData TechnoBlast = new(
        "Techno Blast", Normal,
        120, 100, 0,
        MoveEffect.TechnoBlast, 0,
        false, Single, 5,
        noFlag, TechnoBlastDesc, 190); //Needs anim
    public static MoveData RelicSong = new(
        "Relic Song", Normal,
        75, 100, 0,
        MoveEffect.Sleep, 10,
        false, SpreadMove, 10,
        soundMove, RelicSongDesc, 140); //Needs anim; Todo: Meloetta's form change
    public static MoveData SecretSword = new(
        "Secret Sword", Fighting,
        85, 100, 0,
        MoveEffect.Psyshock, 0,
        false, Single, 10,
        noFlag, SecretSwordDesc, 160); //Needs anim; Todo: Keldeo's form change
    public static MoveData Glaciate = new(
        "Glaciate", Ice,
        65, 95, 0,
        MoveEffect.SpeedDown1, 101,
        false, SpreadMove, 10,
        noFlag, GlaciateDesc, 120); //Needs anim
    public static MoveData BoltStrike = new(
        "Bolt Strike", Electric,
        130, 85, 0,
        MoveEffect.Paralyze, 20,
        true, Single, 5,
        makesContact, BoltStrikeDesc, 195); //Needs anim
    public static MoveData BlueFlare = new(
        "Blue Flare", Fire,
        130, 85, 0,
        MoveEffect.Burn, 20,
        false, Single, 5,
        noFlag, BlueFlareDesc, 195); //Needs anim
    public static MoveData FieryDance = new(
        "Fiery Dance", Fire,
        80, 100, 0,
        MoveEffect.SpAtkUp1, 50,
        false, Single, 10,
        effectOnSelfOnly, FieryDanceDesc, 160); //Needs anim
    public static MoveData FreezeShock = new(
        "Freeze Shock", Ice,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 5,
        noFlag, FreezeShockDesc, 200); //Needs anim
    public static MoveData IceBurn = new(
        "Ice Burn", Ice,
        140, 90, 0,
        MoveEffect.ChargingAttack, 0,
        false, Single, 5,
        noFlag, IceBurnDesc, 200); //Needs anim
    public static MoveData Snarl = new(
        "Snarl", Dark,
        55, 95, 0,
        MoveEffect.SpAtkDown1, 101,
        false, SpreadMove, 15,
        soundMove, SnarlDesc, 100); //Needs anim
    public static MoveData IcicleCrash = new(
        "Icicle Crash", Ice,
        85, 90, 0,
        MoveEffect.Flinch, 30,
        true, Single, 10,
        noFlag, IcicleCrashDesc, 160); //Needs anim
    public static MoveData VCreate = new(
        "V-Create", Fire,
        180, 95, 0,
        MoveEffect.DefSpDefSpeedDown1, 101,
        true, Single, 5,
        effectOnSelfOnly + makesContact, VCreateDesc, 220); //Needs anim
    public static MoveData FusionFlare = new(
        "Fusion Flare", Fire,
        100, 100, 0,
        MoveEffect.FusionFlare, 0,
        false, Single, 5,
        noFlag, FusionFlareDesc, 180); //Needs anims (with check for Fusion Bolt)
    public static MoveData FusionBolt = new(
        "Fusion Bolt", Electric,
        100, 100, 0,
        MoveEffect.FusionBolt, 0,
        true, Single, 5,
        noFlag, FusionBoltDesc, 180); //Needs anims (with check for Fusion Flare)
    public static MoveData FlyingPress = new(
        "Flying Press", Fighting,
        100, 95, 0,
        MoveEffect.FlyingPress, 0,
        true, Single, 10,
        gravityDisabled + makesContact, FlyingPressDesc, 170); //Needs anim
    public static MoveData MatBlock = SelfTargetingMove(
        "Mat Block", Fighting, 0, MoveEffect.MatBlock, 10,
        snatchAffected, DefenseUp1, MatBlockDesc); //Needs anim
    public static MoveData Belch = new(
        "Belch", Poison,
        120, 90, 0,
        MoveEffect.Belch, 0,
        false, Single, 10,
        noFlag, BelchDesc, 190); //Needs anim
    public static MoveData Rototiller = new(
        "Rototiller", Ground,
        0, 101, 0,
        MoveEffect.Rototiller, 101,
        false, All, 10,
        noFlag, RototillerDesc,
        0, AttackUp1); //Needs anim
    public static MoveData StickyWeb = FieldMove(
        "Sticky Web", Bug, 0, MoveEffect.StickyWeb, 20,
        magicBounceAffected, SpeedUp1, StickyWebDesc); //Needs anim
    public static MoveData FellStinger = new(
        "Fell Stinger", Bug,
        50, 100, 0,
        MoveEffect.FellStinger, 0,
        true, Single, 25, //Fell Stinger doesn't have effectOnSelfOnly because it's handled at end of move like recoil
        makesContact, FellStingerDesc, 100); //Needs anim
    public static MoveData PhantomForce = new(
        "Phantom Force", Ghost,
        90, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        noFlag, PhantomForceDesc, 175); //Needs anim
    public static MoveData TrickOrTreat = SingleTargetStatusMove(
        "Trick-or-Treat", Ghost, 100, 0, MoveEffect.TrickOrTreat, 20,
        magicBounceAffected, AllUp1, TrickOrTreatDesc); //Needs anim
    public static MoveData NobleRoar = SingleTargetStatusMove(
        "Noble Roar", Normal, 100, 0, MoveEffect.AttackSpAtkDown1, 30,
        soundMove + magicBounceAffected, DefenseUp1, NobleRoarDesc); //Needs anim
    public static MoveData IonDeluge = FieldMove(
        "Ion Deluge", Electric, 1, MoveEffect.IonDeluge, 25,
        noFlag, SpAtkUp1, IonDelugeDesc); //Needs anim
    public static MoveData ParabolicCharge = new(
        "Parabolic Charge", Electric,
        65, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Surrounding, 20,
        noFlag, ParabolicChargeDesc, 120); //Needs anim
    public static MoveData ForestsCurse = SingleTargetStatusMove(
        "Forest's Curse", Grass, 100, 0, MoveEffect.ForestsCurse, 20,
        magicBounceAffected, AllUp1, ForestsCurseDesc); //Needs anim
    public static MoveData PetalBlizzard = new(
        "Petal Blizzard", Grass,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, Surrounding, 15,
        windMove, PetalBlizzardDesc, 175); //Needs anim
    public static MoveData FreezeDry = new(
        "Freeze-Dry", Ice,
        70, 100, 0,
        MoveEffect.FreezeDry, 10,
        false, Single, 20,
        noFlag, FreezeShockDesc, 140); //Needs anim
    public static MoveData DisarmingVoice = new(
        "Disarming Voice", Fairy,
        40, 101, 0,
        MoveEffect.Hit, 0,
        false, Spread + Opponent, 15,
        soundMove, DisarmingVoiceDesc, 100); //Needs anim
    public static MoveData PartingShot = SingleTargetStatusMove(
        "Parting Shot", Dark, 100, 0, MoveEffect.PartingShot, 20,
        soundMove + magicBounceAffected, HealSwitchedMon100, PartingShotDesc); //Needs anim
    public static MoveData TopsyTurvy = SingleTargetStatusMove(
        "Topsy-Turvy", Dark, 101, 0, MoveEffect.TopsyTurvy, 20,
        magicBounceAffected, AttackUp1, TopsyTurvyDesc); //Needs anim
    public static MoveData DrainingKiss = new(
        "Draining Kiss", Fairy,
        50, 100, 0,
        MoveEffect.Absorb75, 100,
        false, Single, 10,
        makesContact, DrainingKissDesc, 100); //Needs anim
    public static MoveData CraftyShield = SelfTargetingMove(
        "Crafty Shield", Fairy, 3, MoveEffect.CraftyShield, 10,
        noFlag, SpDefUp1, CraftyShieldDesc); //Needs anim
    public static MoveData FlowerShield = new(
        "Flower Shield", Fairy,
        0, 101, 0,
        MoveEffect.FlowerShield, 101,
        false, All, 10,
        noFlag, FlowerShieldDesc,
        0, DefenseUp1); //Needs anim
    public static MoveData GrassyTerrain = FieldMove(
        "Grassy Terrain", Grass, 0, MoveEffect.GrassyTerrain, 10,
        noFlag, DefenseUp1, GrassyTerrainDesc); //Needs anim
    public static MoveData MistyTerrain = FieldMove(
        "Misty Terrain", Fairy, 0, MoveEffect.MistyTerrain, 10,
        noFlag, SpDefUp1, MistyTerrainDesc); //Needs anim
    public static MoveData Electrify = SingleTargetStatusMove(
        "Electrify", Electric, 101, 0, MoveEffect.Electrify, 20,
        noFlag, SpAtkUp1, ElectrifyDesc); //Needs anim
    public static MoveData PlayRough = new(
        "Play Rough", Fairy,
        90, 90, 0,
        MoveEffect.AttackDown1, 10,
        true, Single, 10,
        makesContact, PlayRoughDesc, 175); //Needs anim
    public static MoveData FairyWind = SingleTargetNoAddedEffect(
        "Fairy Wind", Fairy, 40, 100, 0, false, 30, windMove, 100, FairyWindDesc); //Needs anim
    public static MoveData Moonblast = new(
        "Moonblast", Fairy,
        95, 100, 0,
        MoveEffect.SpAtkDown1, 30,
        false, Single, 15,
        noFlag, MoonblastDesc, 175); //Needs anim
    public static MoveData Boomburst = new(
        "Boomburst", Normal,
        140, 100, 0,
        MoveEffect.Hit, 0,
        false, Surrounding, 10,
        soundMove, BoomburstDesc, 200); //Needs anim
    public static MoveData FairyLock = FieldMove(
        "Fairy Lock", Fairy, 0, MoveEffect.FairyLock, 10,
        noFlag, DefenseUp1, FairyLockDesc); //Needs anim
    public static MoveData KingsShield = SelfTargetingMove(
        "King's Shield", Steel, 4, MoveEffect.KingsShield, 10,
        usesProtectCounter, NormalizeDebuffs, KingsShieldDesc); //Needs anim
    public static MoveData PlayNice = SingleTargetStatusMove(
        "Play Nice", Normal, 101, 0, MoveEffect.AttackDown1, 20,
        magicBounceAffected, DefenseUp1, PlayNiceDesc); //Needs anim
    public static MoveData Confide = SingleTargetStatusMove(
        "Confide", Normal, 101, 0, MoveEffect.SpAtkDown1, 20,
        magicBounceAffected + soundMove, SpDefUp1, ConfideDesc); //Needs anim
    public static MoveData DiamondStorm = new(
        "Diamond Storm", Rock,
        100, 95, 0,
        MoveEffect.DiamondStorm, 100,
        true, SpreadMove, 5,
        effectOnSelfOnly, DiamondStormDesc, 180); //Needs anim
    public static MoveData SteamEruption = new(
        "Steam Eruption", Water,
        110, 95, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        noFlag, SteamEruptionDesc, 185); //Needs anim
    public static MoveData HyperspaceHole = new(
        "Hyperspace Hole", Type.Psychic,
        80, 101, 0,
        MoveEffect.Feint, 100,
        false, Single, 5,
        noFlag, HyperspaceHoleDesc, 160); //Needs anim
    public static MoveData WaterShuriken = new(
        "Water Shuriken", Water,
        15, 100, 1,
        MoveEffect.MultiHit2to5, 0,
        false, Single, 20,
        noFlag, WaterShurikenDesc, 100); //Needs anim
    public static MoveData MysticalFire = new(
        "Mystical Fire", Fire,
        75, 100, 0,
        MoveEffect.SpAtkDown1, 101,
        false, Single, 10,
        noFlag, MysticalFireDesc, 140); //Needs anim
    public static MoveData SpikyShield = SelfTargetingMove(
        "Spiky Shield", Grass, 4, MoveEffect.SpikyShield, 10,
        noFlag, DefenseUp1, SpikyShieldDesc); //Needs anim
    public static MoveData AromaticMist = new(
        "Aromatic Mist", Fairy,
        0, 101, 0,
        MoveEffect.SpDefUp1, 101,
        false, Ally, 20,
        noFlag, AromaticMistDesc,
        0, SpDefUp2); //Needs anim
    public static MoveData EerieImpulse = SingleTargetStatusMove(
        "Eerie Impulse", Electric, 100, 0, MoveEffect.SpAtkDown2, 15,
        magicBounceAffected, SpDefUp1, EerieImpulseDesc); //Needs anim
    public static MoveData VenomDrench = new(
        "VenomDrench", Poison,
        0, 100, 0,
        MoveEffect.VenomDrench, 101,
        false, SpreadMove, 20,
        magicBounceAffected, VenomDrenchDesc,
        0, DefenseUp1); //Needs anim
    public static MoveData Powder = SingleTargetStatusMove(
        "Powder", Bug, 100, 1, MoveEffect.Powder, 20,
        magicBounceAffected + powderMove, SpDefUp2, PowderDesc); //Needs anim
    public static MoveData Geomancy = SelfTargetingMove(
        "Geomancy", Fairy, 0, MoveEffect.ChargingAttack, 10,
        noFlag, AllUp1, GeomancyDesc); //Needs anim
    public static MoveData MagneticFlux = new(
        "Magnetic Flux", Electric,
        0, 101, 0,
        MoveEffect.MagneticFlux, 101,
        false, Self + Ally + Ranged, 20,
        snatchAffected, MagneticFluxDesc,
        0, SpDefUp1); //Needs anim
    public static MoveData HappyHour = FieldMove(
        "Happy Hour", Normal, 0, MoveEffect.HappyHour, 30,
        noFlag, AllUp1, HappyHourDesc); //Needs anim
    public static MoveData ElectricTerrain = FieldMove(
        "Electric Terrain", Electric, 0, MoveEffect.ElectricTerrain, 10,
        noFlag, SpeedUp1, ElectricTerrainDesc); //Needs anim
    public static MoveData DazzlingGleam = new(
        "Dazzling Gleam", Fairy,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        noFlag, DazzlingGleamDesc, 160); //Needs anim
    public static MoveData Celebrate = SelfTargetingMove(
        "Celebrate", Normal, 0, MoveEffect.None, 40,
        noFlag, AllUp1, CelebrateDesc); //Needs anim
    public static MoveData HoldHands = new(
        "Hold Hands", Normal,
        0, 101, 0,
        MoveEffect.None, 101,
        false, Ally, 40,
        noFlag, HoldHandsDesc,
        0, AllUp1); //Needs anim
    public static MoveData BabyDollEyes = SingleTargetStatusMove(
        "Baby-Doll Eyed", Fairy, 100, 1, MoveEffect.AttackDown1, 30,
        magicBounceAffected, DefenseUp1, BabyDollEyesDesc); //Needs anim
    public static MoveData Nuzzle = new(
        "Nuzzle", Electric,
        20, 100, 0,
        MoveEffect.Paralyze, 101,
        true, Single, 20,
        makesContact, NuzzleDesc, 100); //Needs anim
    public static MoveData HoldBack = new(
        "Hold Back", Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, Single, 40,
        makesContact, HoldBackDesc, 100); //Needs anim
    public static MoveData Infestation = new(
        "Infestation", Bug,
        20, 100, 0,
        MoveEffect.ContinuousDamage, 101,
        false, Single, 20,
        makesContact, InfestationDesc, 100); //Needs anim
    public static MoveData PowerUpPunch = new(
        "Power-Up Punch", Fighting,
        40, 100, 0,
        MoveEffect.AttackUp1, 101,
        true, Single, 20,
        makesContact + effectOnSelfOnly, PowerUpPunchDesc, 100); //Needs anim
    public static MoveData OblivionWing = new(
        "Oblivion Wing", Flying,
        80, 100, 0,
        MoveEffect.Absorb75, 101,
        false, Single + Ranged, 10,
        healBlockAffected, OblivionWingDesc, 160); //Needs anim
    public static MoveData ThousandArrows = new(
        "Thousand Arrows", Ground,
        90, 100, 0,
        MoveEffect.ThousandArrows, 101,
        true, SpreadMove, 10,
        noFlag, ThousandArrowsDesc, 180); //Needs anim
    public static MoveData ThousandWaves = new(
        "Thousand Waves", Ground,
        90, 100, 0,
        MoveEffect.Trap, 101,
        true, SpreadMove, 10,
        noFlag, ThousandWavesDesc, 175); //Needs anim
    public static MoveData LandsWrath = new(
        "Land's Wrath", Ground,
        90, 100, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 10,
        noFlag, LandsWrathDesc, 185); //Needs anim
    public static MoveData LightOfRuin = new(
        "Light of Ruin", Fairy,
        140, 90, 0,
        MoveEffect.Recoil50, 0,
        false, Single, 5,
        noFlag, LightOfRuinDesc, 200); //Needs anim
    public static MoveData OriginPulse = new(
        "Origin Pulse", Water,
        110, 85, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 10,
        megaLauncherBoosted, OriginPulseDesc, 185); //Needs anim
    public static MoveData PrecipiceBlades = new(
        "Precipice Blades", Ground,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, SpreadMove, 10,
        noFlag, PrecipiceBladesDesc, 190); //Needs anim
    public static MoveData DragonAscent = new(
        "Dragon Ascent", Flying,
        120, 100, 0,
        MoveEffect.DefenseSpDefDown1, 101,
        true, Single, 5,
        effectOnSelfOnly, DragonAscentDesc, 190); //Needs anim
    public static MoveData HyperspaceFury = new(
        "Hyperspace Fury", Dark,
        100, 101, 0,
        MoveEffect.HyperspaceFury, 101,
        true, Single, 5,
        noFlag, HyperspaceFuryDesc, 180); //Needs anim

    //Gen 7
    public static MoveData BreakneckBlitzPhysical =
        ZMove("Breakneck Blitz", Normal, true, BreakneckBlitzDesc); //Needs anim
    public static MoveData BreakneckBlitzSpecial =
        ZMove("Breakneck Blitz", Normal, false, BreakneckBlitzDesc); //Needs anim
    public static MoveData AllOutPummelingPhysical =
        ZMove("All-Out Pummeling", Fighting, true, AllOutPummelingDesc); //Needs anim
    public static MoveData AllOutPummelingSpecial =
        ZMove("All-Out Pummeling", Fighting, false, AllOutPummelingDesc); //Needs anim
    public static MoveData SupersonicSkystrikePhysical =
        ZMove("Supersonic Skystrike", Flying, true, SupersonicSkystrikeDesc); //Needs anim
    public static MoveData SupersonicSkystrikeSpecial =
        ZMove("Supersonic Skystrike", Flying, false, SupersonicSkystrikeDesc); //Needs anim
    public static MoveData AcidDownpourPhysical =
        ZMove("Acid Downpour", Poison, true, AcidDownpourDesc); //Needs anim
    public static MoveData AcidDownpourSpecial =
        ZMove("Acid Downpour", Poison, false, AcidDownpourDesc); //Needs anim
    public static MoveData TectonicRagePhysical =
        ZMove("Tectonic Rage", Ground, true, TectonicRageDesc); //Needs anim
    public static MoveData TectonicRageSpecial =
        ZMove("Tectonic Rage", Ground, false, TectonicRageDesc); //Needs anim
    public static MoveData ContinentalCrushPhysical =
        ZMove("Continental Crush", Rock, true, ContinentalCrushDesc); //Needs anim
    public static MoveData ContinentalCrushSpecial =
        ZMove("Continental Crush", Rock, false, ContinentalCrushDesc); //Needs anim
    public static MoveData SavageSpinOutPhysical =
        ZMove("Savage Spin-Out", Bug, true, SavageSpinOutDesc); //Needs anim
    public static MoveData SavageSpinOutSpecial =
        ZMove("Savage Spin-Out", Bug, false, SavageSpinOutDesc); //Needs anim
    public static MoveData NeverEndingNightmarePhysical =
        ZMove("Never-Ending Nightmare", Ghost, true, NeverEndingNightmareDesc); //Needs anim
    public static MoveData NeverEndingNightmareSpecial =
        ZMove("Never-Ending Nightmare", Ghost, false, NeverEndingNightmareDesc); //Needs anim
    public static MoveData CorkscrewCrashPhysical =
        ZMove("Corkscrew Crash", Steel, true, CorkscrewCrashDesc); //Needs anim
    public static MoveData CorkscrewCrashSpecial =
        ZMove("Corkscrew Crash", Steel, false, CorkscrewCrashDesc); //Needs anim
    public static MoveData InfernoOverdrivePhysical =
        ZMove("Inferno Overdrive", Fire, true, InfernoOverdriveDesc); //Needs anim
    public static MoveData InfernoOverdriveSpecial =
        ZMove("Inferno Overdrive", Fire, false, InfernoOverdriveDesc); //Needs anim
    public static MoveData HydroVortexPhysical =
        ZMove("Hydro Vortex", Water, true, HydroVortexDesc); //Needs anim
    public static MoveData HydroVortexSpecial =
        ZMove("Hydro Vortex", Water, false, HydroVortexDesc); //Needs anim
    public static MoveData BloomDoomPhysical =
        ZMove("Bloom Doom", Grass, true, BloomDoomDesc); //Needs anim
    public static MoveData BloomDoomSpecial =
        ZMove("Bloom Doom", Grass, false, BloomDoomDesc); //Needs anim
    public static MoveData GigavoltHavocPhysical =
        ZMove("Gigavolt Havoc", Electric, true, GigavoltHavocDesc); //Needs anim
    public static MoveData GigavoltHavocSpecial =
        ZMove("Gigavolt Havoc", Electric, false, GigavoltHavocDesc); //Needs anim
    public static MoveData ShatteredPsychePhysical =
        ZMove("Shattered Psyche", Type.Psychic, true, ShatteredPsycheDesc); //Needs anim
    public static MoveData ShatteredPsycheSpecial =
        ZMove("Shattered Psyche", Type.Psychic, false, ShatteredPsycheDesc); //Needs anim
    public static MoveData SubzeroSlammerPhysical =
        ZMove("Subzero Slammer", Ice, true, SubzeroSlammerDesc); //Needs anim
    public static MoveData SubzeroSlammerSpecial =
        ZMove("Subzero Slammer", Ice, false, SubzeroSlammerDesc); //Needs anim
    public static MoveData DevastatingDrakePhysical =
        ZMove("Devastating Drake", Dragon, true, DevastatingDrakeDesc); //Needs anim
    public static MoveData DevastatingDrakeSpecial =
        ZMove("Devastating Drake", Dragon, false, DevastatingDrakeDesc); //Needs anim
    public static MoveData BlackHoleEclipsePhysical =
        ZMove("Black Hole Eclipse", Dark, true, BlackHoleEclipseDesc); //Needs anim
    public static MoveData BlackHoleEclipseSpecial =
        ZMove("Black Hole Eclipse", Dark, false, BlackHoleEclipseDesc); //Needs anim
    public static MoveData TwinkleTacklePhysical =
        ZMove("Twinkle Tackle", Fairy, true, TwinkleTackleDesc); //Needs anim
    public static MoveData TwinkleTackleSpecial =
        ZMove("Twinkle Tackle", Fairy, false, TwinkleTackleDesc); //Needs anim
    public static MoveData Catastropika = new(
        "Catastropika", Electric,
        210, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        makesContact, CatastropikaDesc, 0); //Needs anim
    public static MoveData ShoreUp = SelfTargetingMove(
        "Shore Up", Ground, 0, MoveEffect.ShoreUp, 5,
        snatchAffected, NormalizeDebuffs, ShoreUpDesc); //Needs anim
    public static MoveData FirstImpression = new(
        "First Impression", Bug,
        90, 100, 2,
        MoveEffect.FirstImpression, 0,
        true, Single, 10,
        makesContact, FirstImpressionDesc, 175); //Needs anim
    public static MoveData BanefulBunker = SelfTargetingMove(
        "Baneful Bunker", Poison, 4, MoveEffect.BanefulBunker, 10,
        usesProtectCounter, DefenseUp1, BanefulBunkerDesc); //Needs anim
    public static MoveData SpiritShackle = new(
        "Spirit Shackle", Ghost,
        80, 100, 0,
        MoveEffect.Trap, 101,
        true, Single, 10,
        noFlag, SpiritShackleDesc, 160); //Needs anim
    public static MoveData DarkestLariat = new(
        "Darkest Lariat", Dark,
        85, 100, 0,
        MoveEffect.IgnoreDefenseStage, 0,
        true, Single, 10,
        makesContact, DarkestLariatDesc, 160); //Needs anim
    public static MoveData SparklingAria = new(
        "Sparkling Aria", Water,
        90, 100, 0,
        MoveEffect.CureBurn, 101,
        false, Surrounding, 10,
        soundMove, SparklingAriaDesc, 175); //Needs anim
    public static MoveData IceHammer = new(
        "Ice Hammer", Ice,
        100, 90, 0,
        MoveEffect.SpeedDown1, 101,
        true, Single, 10,
        makesContact + effectOnSelfOnly, IceHammerDesc, 180); //Needs anim
    public static MoveData FloralHealing = SingleTargetStatusMove(
        "Floral Healing", Fairy, 101, 0, MoveEffect.FloralHealing, 10,
        magicBounceAffected, NormalizeDebuffs, FloralHealingDesc); //Needs anim
    public static MoveData HighHorsepower = SingleTargetNoAddedEffect(
        "High Horsepower", Ground, 95, 95, 0, true, 10,
        makesContact, 175, HighHorsepowerDesc); //Needs anim
    public static MoveData StrengthSap = SingleTargetStatusMove(
        "Strength Sap", Grass, 100, 0, MoveEffect.StrengthSap, 10,
        magicBounceAffected, DefenseUp1, StrengthSapDesc); //Needs anim
    public static MoveData SolarBlade = new(
        "Solar Blade", Grass,
        125, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Single, 10,
        noFlag, SolarBladeDesc, 190); //Needs anim
    public static MoveData Leafage = SingleTargetNoAddedEffect(
        "Leafage", Grass, 40, 100, 0, true, 40, noFlag, 100, LeafageDesc); //Needs anim
    public static MoveData Spotlight = SingleTargetStatusMove(
        "Spotlight", Normal, 101, 3, MoveEffect.Spotlight, 15,
        magicBounceAffected, SpDefUp1, SpotlightDesc); //Needs anim
    public static MoveData ToxicThread = SingleTargetStatusMove(
        "Toxic Thread", Poison, 100, 0, MoveEffect.ToxicThread, 20,
        magicBounceAffected, SpeedUp1, ToxicThreadDesc); //Needs anim
    public static MoveData LaserFocus = SelfTargetingMove(
        "Laser Focus", Normal, 0, MoveEffect.LaserFocus, 30,
        snatchAffected, AttackUp1, LaserFocusDesc); //Needs anim
    public static MoveData GearUp = new(
        "Gear Up", Steel,
        0, 101, 0,
        MoveEffect.GearUp, 101,
        false, Ally + Self + Spread + Ranged, 20,
        snatchAffected, GearUpDesc, 0, SpAtkUp1); //Needs anim
    public static MoveData ThroatChop = new(
        "Throat Chop", Dark,
        80, 100, 0,
        MoveEffect.ThroatChop, 101,
        true, Single, 15,
        makesContact, ThroatChopDesc, 160); //Needs anim
    public static MoveData PollenPuff = new(
        "Pollen Puff", Bug,
        90, 100, 0,
        MoveEffect.PollenPuff, 0,
        false, Single, 15,
        noFlag, PollenPuffDesc, 175); //Needs anim
    public static MoveData AnchorShot = new(
        "Anchor Shot", Steel,
        80, 100, 0,
        MoveEffect.Trap, 101,
        true, Single, 20,
        makesContact, AnchorShotDesc, 160); //Needs anim
    public static MoveData PsychicTerrain = FieldMove(
        "Psychic Terrain", Type.Psychic, 0, MoveEffect.PsychicTerrain, 10,
        noFlag, SpAtkUp1, PsychicTerrainDesc); //Needs anim
    public static MoveData Lunge = new(
        "Lunge", Bug,
        80, 100, 0,
        MoveEffect.AttackDown1, 101,
        true, Single, 15,
        makesContact, LungeDesc, 160); //Needs anim
    public static MoveData FireLash = new(
        "Fire Lash", Fire,
        80, 100, 0,
        MoveEffect.DefenseDown1, 101,
        true, Single, 15,
        makesContact, FireLashDesc, 160); //Needs anim
    public static MoveData PowerTrip = new(
        "Power Trip", Dark,
        20, 100, 0,
        MoveEffect.UserStatPower, 0,
        true, Single, 10,
        makesContact, PowerTripDesc, 160); //Needs anim
    public static MoveData BurnUp = new(
        "Burn Up", Fire,
        130, 100, 0,
        MoveEffect.BurnUp, 101,
        false, Single, 5,
        effectOnSelfOnly, BurnUpDesc, 195); //Needs anim
    public static MoveData SpeedSwap = SingleTargetStatusMove(
        "Speed Swap", Type.Psychic, 101, 0, MoveEffect.SpeedSwap, 10,
        noFlag, SpeedUp1, SpeedSwapDesc); //Needs anim
    public static MoveData SmartStrike = SingleTargetNoAddedEffect(
        "Smart Strike", Steel, 70, 101, 0, true, 10, makesContact, 140, SmartStrikeDesc); //Needs anim
    public static MoveData Purify = SingleTargetStatusMove(
        "Purify", Poison, 101, 0, MoveEffect.Purify, 20,
        magicBounceAffected, AllUp1, PurifyDesc); //Needs anim
    public static MoveData RevelationDance = new(
        "Revelation Dance", Normal,
        90, 100, 0,
        MoveEffect.RevelationDance, 0,
        false, Single, 15,
        noFlag, RevelationDanceDesc, 175); //Needs anim
    public static MoveData CoreEnforcer = new(
        "Core Enforcer", Dragon,
        100, 100, 0,
        MoveEffect.CoreEnforcer, 101,
        false, Opponent, 10,
        noFlag, CoreEnforcerDesc, 140); //Needs anim
    public static MoveData TropKick = new(
        "Trop Kick", Grass,
        70, 100, 0,
        MoveEffect.AttackDown1, 101,
        true, Single, 15,
        noFlag, TropKickDesc, 140); //Needs anim
    public static MoveData Instruct = SingleTargetStatusMove(
        "Instruct", Type.Psychic, 101, 0, MoveEffect.Instruct, 15,
        noFlag, SpAtkUp1, InstructDesc); //Needs anim
    public static MoveData BeakBlast = new(
        "Beak Blast", Flying,
        100, 100, 9,
        MoveEffect.BeakBlastWindup, 0,
        true, Single, 15,
        noFlag, BeakBlastDesc, 180); //Needs anim
    public static MoveData ClangingScales = new(
        "Clanging Scales", Dragon,
        110, 100, 0,
        MoveEffect.DefenseDown1, 101,
        false, Spread, 5,
        effectOnSelfOnly + soundMove, ClangingScalesDesc, 185); //Needs anim
    public static MoveData DragonHammer = SingleTargetNoAddedEffect(
        "Dragon Hammer", Dragon, 90, 100, 0, true, 15,
        makesContact, 175, DragonHammerDesc); //Needs anim
    public static MoveData BrutalSwing = new(
        "Brutal Swing", Dark,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, Surrounding, 20,
        makesContact, BrutalSwingDesc, 120); //Needs anim
    public static MoveData AuroraVeil = FieldMove(
        "Aurora Veil", Ice, 0, MoveEffect.AuroraVeil, 20,
        snatchAffected, SpeedUp1, AuroraVeilDesc); //Needs anim
    public static MoveData SinisterArrowRaid = new(
        "Sinister Arrow Raid", Ghost,
        180, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        noFlag, SinisterArrowRaidDesc, 0); //Needs anim
    public static MoveData MaliciousMoonsault = new(
        "Malicious Moonsault", Dark,
        180, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        makesContact, MaliciousMoonsaultDesc, 0); //Needs anim
    public static MoveData OceanicOperetta = new(
        "Oceanic Operetta", Water,
        195, 101, 0,
        MoveEffect.ZMove, 0,
        false, Single, 1,
        noFlag, OceanicOperettaDesc, 0); //Needs anim
    public static MoveData GuardianOfAlola = new(
        "Guardian of Alola", Fairy,
        1, 101, 0,
        MoveEffect.GuardianOfAlola, 0,
        false, Single, 1,
        noFlag, GuardianOfAlolaDesc, 0); //Needs anim
    public static MoveData SoulStealingSevenStarStrike = new(
        "Soul-Stealing 7-Star Strike", Ghost,
        195, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        makesContact, SoulStealingSevenStarStrikeDesc, 0); //Needs anim
    public static MoveData StokedSparksurfer = new(
        "Stoked Sparksurfer", Electric,
        175, 101, 0,
        MoveEffect.ZMove, 0,
        false, Single, 1,
        noFlag, StokedSparksurferDesc, 0); //Needs anim
    public static MoveData PulverizingPancake = new(
        "Pulverizing Pancake", Normal,
        210, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        makesContact, PulverizingPancakeDesc, 0); //Needs anim
    public static MoveData ExtremeEvoboost = SelfTargetingMove(
        "Extreme Evoboost", Normal, 0, MoveEffect.AllUp2, 1,
        noFlag, 0, ExtremeEvoboostDesc); //Needs anim
    public static MoveData GenesisSupernova = new(
        "Genesis Supernova", Type.Psychic,
        185, 101, 0,
        MoveEffect.GenesisSupernova, 101,
        false, Single, 1,
        noFlag, GenesisSupernovaDesc, 0); //Needs anim
    public static MoveData ShellTrap = new(
        "Shell Trap", Fire,
        150, 100, 9,
        MoveEffect.ShellTrapSet, 100,
        false, Spread, 5,
        noFlag, ShellTrapDesc, 200); //Needs anim
    public static MoveData FleurCannon = new(
        "Fleur Cannon", Fairy,
        130, 90, 0,
        MoveEffect.SpDefDown2, 101,
        false, Single, 5,
        effectOnSelfOnly, FleurCannonDesc, 195); //Needs anim
    public static MoveData PsychicFangs = new(
        "Psychic Fangs", Type.Psychic,
        85, 100, 0,
        MoveEffect.BreakScreens, 101,
        true, Single, 10,
        makesContact, PsychicFangsDesc, 160); //Needs anim
    public static MoveData StompingTantrum = new(
        "Stomping Tantrum", Ground,
        75, 100, 0,
        MoveEffect.StompingTantrum, 0,
        true, Single, 10,
        makesContact, StompingTantrumDesc, 140); //Needs anim
    public static MoveData ShadowBone = new(
        "Shadow Bone", Ghost,
        85, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, Single, 10,
        noFlag, ShadowBoneDesc, 160); //Needs anim
    public static MoveData Accelerock = SingleTargetNoAddedEffect(
        "Accelerock", Rock, 40, 100, 1, true, 20, makesContact, 100, AccelerockDesc); //Needs anim
    public static MoveData Liquidation = new(
        "Liquidation", Water,
        85, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, Single, 10,
        makesContact, LiquidationDesc, 160); //Needs anim
    public static MoveData PrismaticLaser = new(
        "Prismatic Laser", Type.Psychic,
        160, 100, 0,
        MoveEffect.Recharge, 101,
        false, Single, 10,
        noFlag, PrismaticLaserDesc, 200); //Needs anim
    public static MoveData SpectralThief = new(
        "Spectral Thief", Ghost,
        90, 100, 0,
        MoveEffect.SpectralThief, 101,
        true, Single, 10,
        makesContact, SpectralThiefDesc, 175); //Needs anim
    public static MoveData SunsteelStrike = new(
        "Sunsteel Strike", Steel,
        100, 100, 0,
        MoveEffect.IgnoreAbility, 101,
        true, Single, 5,
        makesContact, SunsteelStrikeDesc, 180); //Needs anim
    public static MoveData MoongeistBeam = new(
        "Moongeist Beam", Ghost,
        100, 100, 0,
        MoveEffect.IgnoreAbility, 101,
        false, Single, 5,
        noFlag, MoongeistBeamDesc, 180); //Needs anim
    public static MoveData TearfulLook = SingleTargetStatusMove(
        "Tearful Look", Normal, 101, 0, MoveEffect.AttackSpAtkDown1, 20,
        magicBounceAffected, DefenseUp1, TearfulLookDesc); //Needs anim
    public static MoveData ZingZap = new(
        "Zing Zap", Electric,
        80, 100, 0,
        MoveEffect.Flinch, 30,
        true, Single, 10,
        makesContact, ZingZapDesc, 160); //Needs anim
    public static MoveData NaturesMadness = new(
        "Nature's Madness", Fairy,
        1, 90, 0,
        MoveEffect.SuperFang, 0,
        false, Single, 10,
        noFlag, NaturesMadnessDesc, 100); //Needs anim
    public static MoveData MultiAttack = new(
        "Multi-Attack", Normal,
        120, 100, 0,
        MoveEffect.MultiAttack, 0,
        true, Single, 10,
        makesContact, MultiAttackDesc, 185); //Needs anim
    public static MoveData TenMillionVoltThunderbolt = new(
        "10,000,000 Volt Thunderbolt", Electric,
        195, 101, 0,
        MoveEffect.ZMove, 0,
        false, Single, 1,
        highCrit, TenMillionVoltThunderboltDesc, 0); //Needs anim
    public static MoveData MindBlown = new(
        "Mind Blown", Fire,
        150, 100, 0,
        MoveEffect.Recoil50Max, 0,
        false, Surrounding, 5,
        noFlag, MindBlownDesc, 200); //Needs anim
    public static MoveData PlasmaFists = new(
        "Plasma Fists", Electric,
        100, 100, 0,
        MoveEffect.IonDeluge, 101,
        true, Single, 15,
        makesContact, PlasmaFistsDesc, 180); //Needs anim
    public static MoveData PhotonGeyser = new(
        "Photon Geyser", Type.Psychic,
        100, 100, 0,
        MoveEffect.PhotonGeyser, 0,
        false, Single, 5, noFlag, PhotonGeyserDesc, 180); //Needs anim
    public static MoveData LightThatBurnsTheSky = new(
        "Light That Burns the Sky", Type.Psychic,
        200, 101, 0,
        MoveEffect.LightThatBurnsTheSky, 0,
        false, Single, 1,
        noFlag, LightThatBurnsTheSkyDesc, 0); //Needs anim
    public static MoveData SearingSunrazeSmash = new(
        "Searing Sunraze Smash", Steel,
        200, 101, 0,
        MoveEffect.ZMoveIgnoreAbility, 0,
        true, Single, 1,
        makesContact, SearingSunrazeSmashDesc, 0); //Needs anim
    public static MoveData MenacingMoonrazeMaelstrom = new(
        "Menacing Moonraze Maelstrom", Ghost,
        200, 101, 0,
        MoveEffect.ZMoveIgnoreAbility, 0,
        false, Single, 1,
        noFlag, MenacingMoonrazeMaelstromDesc, 0); //Needs anim
    public static MoveData LetsSnuggleForever = new(
        "Let's Snuggle Forever", Fairy,
        190, 101, 0,
        MoveEffect.ZMove, 0,
        true, Single, 1,
        makesContact, LetsSnuggleForeverDesc, 0); //Needs anim
    public static MoveData SplinteredStormshards = new(
        "Splintered Stormshards", Rock,
        190, 101, 0,
        MoveEffect.ZMove, 101,
        true, Single, 1,
        noFlag, SplinteredStormshardsDesc, 0); //Needs anim
    public static MoveData ClangorousSoulblaze = new(
        "Clangorous Soulblaze", Dragon,
        185, 101, 0,
        MoveEffect.ClangorousSoulblaze, 101,
        false, Spread, 1,
        soundMove + effectOnSelfOnly, ClangorousSoulblazeDesc, 0); //Needs anim
    public static MoveData ZippyZap = new(
        "Zippy Zap", Electric,
        80, 100, 2,
        MoveEffect.EvasionUp1, 101,
        true, Single, 10,
        makesContact + effectOnSelfOnly, ZippyZapDesc, 160); //Needs anim
    public static MoveData SplishySplash = new(
        "Splishy Splash", Water,
        90, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Spread, 15,
        noFlag, SplishySplashDesc, 175); //Needs anim
    public static MoveData FloatyFall = new(
        "Floaty Fall", Flying,
        90, 95, 0,
        MoveEffect.Flinch, 30,
        true, Single, 15,
        makesContact, FloatyFallDesc, 175); //Needs anim
    public static MoveData PikaPapow = new(
        "Pika Papow", Electric,
        1, 101, 0,
        MoveEffect.Return, 0,
        false, Single, 20,
        noFlag, PikaPapowDesc, 100); //Needs anim
    public static MoveData BouncyBubble = new(
        "Bouncy Bubble", Water,
        60, 100, 0,
        MoveEffect.Absorb100, 101,
        false, Spread, 20,
        healBlockAffected, BouncyBubbleDesc, 120); //Needs anim
    public static MoveData BuzzyBuzz = new(
        "Buzzy Buzz", Electric,
        60, 100, 0,
        MoveEffect.Paralyze, 101,
        false, Single, 15,
        noFlag, BuzzyBuzzDesc, 120); //Needs anim
    public static MoveData SizzlySlide = new(
        "Sizzly Slide", Fire,
        60, 100, 0,
        MoveEffect.Burn, 101,
        true, Single, 15,
        makesContact, SizzlySlideDesc, 120); //Needs anim
    public static MoveData GlitzyGlow = new(
        "Glitzy Glow", Type.Psychic,
        80, 95, 0,
        MoveEffect.LightScreen, 101,
        false, Single, 15,
        noFlag, GlitzyGlowDesc, 160); //Needs anim
    public static MoveData BaddyBad = new(
        "Baddy Bad", Dark,
        80, 95, 0,
        MoveEffect.Reflect, 101,
        false, Single, 15,
        noFlag, BaddyBadDesc, 160); //Needs anim
    public static MoveData SappySeed = new(
        "Sappy Seed", Grass,
        100, 90, 0,
        MoveEffect.LeechSeed, 101,
        true, Single, 10,
        magicBounceAffected, SappySeedDesc, 180); //Needs anim
    public static MoveData FreezyFrost = new(
        "Freezy Frost", Ice,
        100, 90, 0,
        MoveEffect.Haze, 101,
        false, Single, 10,
        noFlag, FreezyFrostDesc, 180); //Needs anim
    public static MoveData SparklySwirl = new(
        "Sparkly Swirl", Fairy,
        120, 85, 0,
        MoveEffect.HealBell, 101,
        false, Single, 15,
        noFlag, SparklySwirlDesc, 190); //Needs anim
    public static MoveData VeeveeVolley = new(
        "Veevee Volley", Normal,
        1, 101, 0,
        MoveEffect.Return, 0,
        true, Single, 20,
        makesContact, VeeveeVolleyDesc, 100); //Needs anim
    public static MoveData DoubleIronBash = new(
        "Double Iron Bash", Steel,
        60, 100, 0,
        MoveEffect.DoubleIronBash, 30,
        true, Single, 5,
        makesContact, DoubleIronBashDesc, 120); //Needs anim

    //Non-standard moves
    public static MoveData ConfusionHit = new(
        "a move it shouldn't be able to! (ConfusionHit) [Error 101]", Typeless,
        40, 101, 0,
        MoveEffect.Hit, 0,
        true, Self, 0,
        mimicBypass, InvalidMove, 0);
    public static MoveData Recharge = new(
        "a move it shouldn't be able to! (Recharge) [Error 101]", Typeless,
        0, 0, 0,
        MoveEffect.None, 0,
        false, 0, 0,
        mimicBypass, InvalidMove, 0);
    public static MoveData RazorWindAttack = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass, InvalidMove, 0); //Needs anim
    public static MoveData DigAttack = new(
        "Dig", Ground,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass + makesContact, InvalidMove, 0); //Needs anim
    public static MoveData FlyAttack = new(
        "Fly", Flying,
        90, 95, 0,
        MoveEffect.Hit, 0,
        false, SpreadMove, 0,
        mimicBypass + makesContact, InvalidMove, 0); //Needs anim
    public static MoveData SolarBeamAttack = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, Single, 0,
        halfPowerInBadWeather + mimicBypass, InvalidMove, 0); //Needs anim
    public static MoveData SkyAttackAttack = new(
        "Sky Attack", Flying,
        140, 90, 0,
        MoveEffect.Flinch, 30,
        true, Single, 5,
        highCrit + mimicBypass, InvalidMove, 0);
    public static MoveData SkullBashAttack = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, InvalidMove, 0); //Needs anim
    public static MoveData BideMiddle = new(
        "Bide", Typeless,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Target.None, 0,
        mimicBypass, InvalidMove, 0); //Needs anim);
    public static MoveData BideAttack = new(
        "Bide", Typeless,
        1, 100, 0,
        MoveEffect.BideHit, 0,
        false, Opponent, 0,
        mimicBypass + makesContact, InvalidMove, 0); //Needs anim
    public static MoveData FocusPunchAttack = new(
        "Focus Punch", Fighting,
        150, 100, -3,
        MoveEffect.FocusPunchAttack, 0,
        true, Single, 20,
        makesContact + punchMove, InvalidMove, 0); //Needs anim
    public static MoveData DiveAttack = new(
        "Dive", Water,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Single, 10,
        makesContact, InvalidMove, 0); //Needs anim
    public static MoveData BounceAttack = new(
        "Bounce", Flying,
        85, 85, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 5,
        makesContact, InvalidMove, 0); //Needs anim
    public static MoveData ShadowForceAttack = new(
        "Shadow Force", Ghost,
        120, 100, 0,
        MoveEffect.Feint, 100,
        true, Single, 5,
        mimicBypass + makesContact, InvalidMove, 0); //Needs anim
    public static MoveData SkyDropAttack = new(
        "Sky Drop", Flying,
        60, 100, 0,
        MoveEffect.SkyDropHit, 0,
        true, Single, 10,
        makesContact, InvalidMove, 0); //Needs anim
    public static MoveData RainbowPledge = new(
        "Water Pledge", Water,
        150, 100, 0,
        MoveEffect.Rainbow, 100,
        false, Single, 10,
        effectOnSelfOnly, InvalidMove, 0); //Needs anim
    public static MoveData SwampPledge = new(
        "Grass Pledge", Grass,
        150, 100, 0,
        MoveEffect.Swamp, 100,
        false, Single, 10,
        noFlag, InvalidMove, 0); //Needs anim
    public static MoveData BurningFieldPledge = new(
        "Fire Pledge", Fire,
        150, 100, 0,
        MoveEffect.BurningField, 100,
        false, Single, 10,
        noFlag, InvalidMove, 0); //Needs anim
    public static MoveData FreezeShockAttack = new(
        "Freeze Shock", Ice,
        140, 90, 0,
        MoveEffect.Paralyze, 30,
        true, Single, 5,
        noFlag, InvalidMove, 0); //Needs anim
    public static MoveData IceBurnAttack = new(
        "Ice Burn", Ice,
        140, 90, 0,
        MoveEffect.Burn, 30,
        false, Single, 5,
        noFlag, InvalidMove, 0); //Needs anim
    public static MoveData PhantomForceAttack = new(
        "Phantom Force", Ghost,
        90, 100, 0,
        MoveEffect.Feint, 100,
        true, Single, 5,
        mimicBypass + makesContact, InvalidMove, 0); //Needs anim
    public static MoveData GeomancyExecution = SelfTargetingMove(
        "Geomancy", Fairy, 0, MoveEffect.SpAtkSpDefSpeedUp2, 10,
        noFlag, 0, InvalidMove); //Needs anim
    public static MoveData SolarBladeAttack = SingleTargetNoAddedEffect(
        "Solar Blade", Grass, 125, 100, 0, true, 10, makesContact, 0, InvalidMove); //Needs anim
    public static MoveData PollenPuffHeal = SingleTargetStatusMove(
        "Pollen Puff", Bug, 100, 0, MoveEffect.Heal50, 0,
        healBlockAffected, 0, InvalidMove); //Needs anim
    public static MoveData BeakBlastAttack = SingleTargetNoAddedEffect(
        "Beak Blast", Flying, 100, 100, -3, true, 15,
        bulletMove, 0, InvalidMove); //Needs anim
    public static MoveData ShellTrapAttack = new(
        "Shell Trap", Fire,
        150, 100, -3,
        MoveEffect.ShellTrapAttack, 100,
        false, Spread, 5,
        noFlag, InvalidMove, 0); //Needs anim
    public static MoveData Struggle = new(
        "Struggle", Typeless,
        50, 100, 0,
        MoveEffect.Recoil25Max, 100,
        true, Single, 0,
        cannotMimic, StruggleDesc, 0);


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

        //Gen 7
        BreakneckBlitzPhysical,
        BreakneckBlitzSpecial,
        AllOutPummelingPhysical,
        AllOutPummelingSpecial,
        SupersonicSkystrikePhysical,
        SupersonicSkystrikeSpecial,
        AcidDownpourPhysical,
        AcidDownpourSpecial,
        TectonicRagePhysical,
        TectonicRageSpecial,
        ContinentalCrushPhysical,
        ContinentalCrushSpecial,
        SavageSpinOutPhysical,
        SavageSpinOutSpecial,
        NeverEndingNightmarePhysical,
        NeverEndingNightmareSpecial,
        CorkscrewCrashPhysical,
        CorkscrewCrashSpecial,
        InfernoOverdrivePhysical,
        InfernoOverdriveSpecial,
        HydroVortexPhysical,
        HydroVortexSpecial,
        BloomDoomPhysical,
        BloomDoomSpecial,
        GigavoltHavocPhysical,
        GigavoltHavocSpecial,
        ShatteredPsychePhysical,
        ShatteredPsycheSpecial,
        SubzeroSlammerPhysical,
        SubzeroSlammerSpecial,
        DevastatingDrakePhysical,
        DevastatingDrakeSpecial,
        BlackHoleEclipsePhysical,
        BlackHoleEclipseSpecial,
        TwinkleTacklePhysical,
        TwinkleTackleSpecial,
        Catastropika,
        ShoreUp,
        FirstImpression,
        BanefulBunker,
        SpiritShackle,
        DarkestLariat,
        SparklingAria,
        IceHammer,
        FloralHealing,
        HighHorsepower,
        StrengthSap,
        SolarBlade,
        Leafage,
        Spotlight,
        ToxicThread,
        LaserFocus,
        GearUp,
        ThroatChop,
        PollenPuff,
        AnchorShot,
        PsychicTerrain,
        Lunge,
        FireLash,
        PowerTrip,
        BurnUp,
        SpeedSwap,
        SmartStrike,
        Purify,
        RevelationDance,
        CoreEnforcer,
        TropKick,
        Instruct,
        BeakBlast,
        ClangingScales,
        DragonHammer,
        BrutalSwing,
        AuroraVeil,
        SinisterArrowRaid,
        MaliciousMoonsault,
        OceanicOperetta,
        GuardianOfAlola,
        SoulStealingSevenStarStrike,
        StokedSparksurfer,
        PulverizingPancake,
        ExtremeEvoboost,
        GenesisSupernova,
        ShellTrap,
        FleurCannon,
        PsychicFangs,
        StompingTantrum,
        ShadowBone,
        Accelerock,
        Liquidation,
        PrismaticLaser,
        SpectralThief,
        SunsteelStrike,
        MoongeistBeam,
        TearfulLook,
        ZingZap,
        NaturesMadness,
        MultiAttack,
        TenMillionVoltThunderbolt,
        MindBlown,
        PlasmaFists,
        PhotonGeyser,
        LightThatBurnsTheSky,
        SearingSunrazeSmash,
        MenacingMoonrazeMaelstrom,
        LetsSnuggleForever,
        SplinteredStormshards,
        ClangorousSoulblaze,
        ZippyZap,
        SplishySplash,
        FloatyFall,
        PikaPapow,
        BouncyBubble,
        BuzzyBuzz,
        SizzlySlide,
        GlitzyGlow,
        BaddyBad,
        SappySeed,
        FreezyFrost,
        SparklySwirl,
        VeeveeVolley,
        DoubleIronBash,

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
        SolarBladeAttack,
        PollenPuffHeal,
        BeakBlastAttack,
        ShellTrapAttack,
    };
}
