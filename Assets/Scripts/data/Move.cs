using System.Reflection;
using System.Threading;
using UnityEngine;
using static Type;
using static MoveData;
using static MoveFlags;

public static class Move
{
    public const int AlwaysHit = 101;
    public static MoveData None = FakeMove;
    public static MoveData Pound = new(
        "Pound", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 35,
        makesContact); //Done
    public static MoveData KarateChop = new(
        "Karate Chop", Fighting,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 25,
        highCrit + makesContact); //Done
    public static MoveData DoubleSlap = new(
        "Double Slap", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 10,
        makesContact); //Done
    public static MoveData CometPunch = new(
        "Comet Punch", Normal,
        18, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 15,
         makesContact); //Needs anim
    public static MoveData MegaPunch = new(
        "Mega Punch", Normal,
        80, 85, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20,
         makesContact); //Needs anim
    public static MoveData PayDay = new(
        "Pay Day", Normal,
        40, 100, 0,
        MoveEffect.PayDay, 101,
        true, Target.Single, 20); //Needs anim and money implementation
    public static MoveData FirePunch = new(
        "Fire Punch", Fire,
        75, 100, 0,
        MoveEffect.Burn, 10,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData IcePunch = new(
        "Ice Punch", Ice,
        75, 100, 0,
        MoveEffect.Freeze, 10,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData ThunderPunch = new(
        "Thunder Punch", Electric,
        75, 100, 0,
        MoveEffect.Paralyze, 10,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Scratch = new(
        "Scratch", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 35,
        makesContact); //Needs anim
    public static MoveData ViceGrip = new(
        "Vice Grip", Normal,
        55, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData Guillotine = new(
        "Guillotine", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Target.Single, 5,
        makesContact); //Needs anim
    public static MoveData RazorWind = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Target.Opponent + Target.Spread, 10); //Needs anim
    public static MoveData SwordsDance = new(
        "Swords Dance", Normal,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp2, 0,
        false, Target.Self, 20); //Needs anim
    public static MoveData Cut = new(
        "Cut", Normal,
        50, 95, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData Gust = new(
        "Gust", Flying,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 35,
        hitFlyingMon); //Needs anim
    public static MoveData WingAttack = new(
        "Wing Attack", Flying,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 35,
        makesContact); //Needs anim
    public static MoveData Whirlwind = new(
        "Whirlwind", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Fly = new(
        "Fly", Flying,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Target.Single, 15); //Needs anim
    public static MoveData Bind = new(
        "Bind", Normal,
        15, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Slam = new(
        "Slam", Normal,
        80, 75, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData VineWhip = new(
        "Vine Whip", Grass,
        45, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 25,
        makesContact); //Needs anim
    public static MoveData Stomp = new(
        "Stomp", Normal,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData DoubleKick = new(
        "Double Kick", Fighting,
        30, 100, 0,
        MoveEffect.MultiHit2, 0,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData MegaKick = new(
        "Mega Kick", Normal,
        120, 75, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 5,
        makesContact); //Needs anim
    public static MoveData JumpKick = new(
        "Jump Kick", Fighting,
        100, 20, 0,
        MoveEffect.Crash50Max, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData RollingKick = new(
        "Rolling Kick", Fighting,
        60, 85, 0,
        MoveEffect.Flinch, 30,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData SandAttack = new(
        "Sand Attack", Ground,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Target.Single, 15); //Needs anim
    public static MoveData Headbutt = new(
        "Headbutt", Normal,
        70, 100, 0,
        MoveEffect.Flinch, 30,
        true, Target.Single, 15,
        makesContact); //Needs field effect and anim
    public static MoveData HornAttack = new(
        "Horn Attack", Normal,
        65, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 25,
        makesContact); //Needs anim
    public static MoveData FuryAttack = new(
        "Fury Attack", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData HornDrill = new(
        "Horn Drill", Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Target.Single, 5,
        makesContact); //Needs anim
    public static MoveData Tackle = new(
        "Tackle", Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 35,
        makesContact); //Needs anim
    public static MoveData BodySlam = new(
        "Body Slam", Normal,
        85, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Wrap = new(
        "Wrap", Normal,
        15, 90, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData TakeDown = new(
        "Take Down", Normal,
        90, 85, 0,
        MoveEffect.Recoil25, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Thrash = new(
        "Thrash", Normal,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Target.Self, 10,
        makesContact); //Needs anim
    public static MoveData DoubleEdge = new(
        "Double Edge", Normal,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData TailWhip = new(
        "Tail Whip", Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, Target.Opponent + Target.Spread, 30); //Needs anim
    public static MoveData PoisonSting = new(
        "Poison Sting", Poison,
        15, 100, 0,
        MoveEffect.Poison, 30,
        true, Target.Single, 35); //Needs anim
    public static MoveData Twineedle = new(
        "Twineedle", Bug,
        25, 100, 0,
        MoveEffect.Twineedle, 20,
        true, Target.Single, 20); //Needs anim
    public static MoveData PinMissile = new(
        "Pin Missile", Bug,
        25, 95, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 20); //Needs anim
    public static MoveData Leer = new(
        "Leer", Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, Target.Opponent + Target.Spread, 30); //Needs anim
    public static MoveData Bite = new(
        "Bite", Dark,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, Target.Single, 25,
        makesContact); //Needs anim
    public static MoveData Growl = new(
        "Growl", Normal,
        0, 100, 0,
        MoveEffect.AttackDown1, 100,
        false, Target.Opponent + Target.Spread, 40,
        soundMove);
    public static MoveData Roar = new(
        "Roar", Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, Target.Single, 20,
        soundMove); //Needs anim
    public static MoveData Sing = new(
        "Sing", Normal,
        0, 55, 0,
        MoveEffect.Sleep, 100,
        false, Target.Single, 15,
        soundMove); //Needs anim
    public static MoveData Supersonic = new(
        "Supersonic", Normal,
        0, 55, 0,
        MoveEffect.Confuse, 100,
        false, Target.Single, 20,
        soundMove); //Needs anim
    public static MoveData SonicBoom = new(
        "Sonic Boom", Normal,
        1, 90, 0,
        MoveEffect.Direct20, 0,
        false, Target.Single, 20); //Needs anim
    public static MoveData Disable = new(
        "Disable", Normal,
        0, 100, 0,
        MoveEffect.Disable, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Acid = new(
        "Acid", Poison,
        40, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, Target.Opponent + Target.Spread, 30); //Needs anim
    public static MoveData Ember = new(
        "Ember", Fire,
        40, 100, 0,
        MoveEffect.Burn, 10,
        false, Target.Single, 25); //Needs anim
    public static MoveData Flamethrower = new(
        "Flamethrower", Fire,
        90, 100, 0,
        MoveEffect.Burn, 10,
        false, Target.Single, 15); //Needs anim
    public static MoveData Mist = new(
        "Mist", Ice,
        0, AlwaysHit, 0,
        MoveEffect.Mist, 100,
        false, Target.Field, 30); //Needs anim
    public static MoveData WaterGun = new(
        "Water Gun", Water,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 25); //Needs anim
    public static MoveData HydroPump = new(
        "Hydro Pump", Water,
        110, 80, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 5); //Needs anim
    public static MoveData Surf = new(
        "Surf", Water,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Surrounding, 15); //Needs anim
    public static MoveData IceBeam = new(
        "Ice Beam", Ice,
        90, 100, 0,
        MoveEffect.Freeze, 10,
        false, Target.Single, 10); //Needs anim
    public static MoveData Blizzard = new(
        "Blizzard", Ice,
        110, 70, 0,
        MoveEffect.Freeze, 10,
        false, Target.Opponent + Target.Spread, 5); //Needs anim
    public static MoveData Psybeam = new(
        "Psybeam", Type.Psychic,
        65, 100, 0,
        MoveEffect.Confuse, 10,
        false, Target.Single, 20); //Needs anim
    public static MoveData BubbleBeam = new(
        "Bubble Beam", Water,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 20); //Needs anim
    public static MoveData AuroraBeam = new(
        "Aurora Beam", Ice,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 20); //Needs anim
    public static MoveData HyperBeam = new(
        "Hyper Beam", Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, Target.Single, 5); //Needs anim
    public static MoveData Peck = new(
        "Peck", Flying,
        35, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 35,
        makesContact); //Needs anim
    public static MoveData DrillPeck = new(
        "Drill Peck", Flying,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Submission = new(
        "Submission", Fighting,
        80, 80, 0,
        MoveEffect.Recoil25, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData LowKick = new(
        "Low Kick", Fighting,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Counter = new(
        "Counter", Fighting,
        1, 100, -5,
        MoveEffect.Counter, 0,
        true, Target.None, 20,
        makesContact); //Needs anim
    public static MoveData SeismicToss = new(
        "Seismic Toss", Fighting,
        0, 100, 0,
        MoveEffect.DirectLevel, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Strength = new(
        "Strength", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Absorb = new(
        "Absorb", Grass,
        20, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Target.Single, 25,
        effectOnSelfOnly); //Needs anim
    public static MoveData MegaDrain = new(
        "Mega Drain", Grass,
        40, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Target.Single, 15,
        effectOnSelfOnly); //Needs anim
    public static MoveData LeechSeed = new(
        "Leech Seed", Grass,
        0, 90, 0,
        MoveEffect.LeechSeed, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Growth = new(
        "Growth", Normal,
        0, AlwaysHit, 0,
        MoveEffect.Growth, 100,
        false, Target.Self, 20); //Needs anim
    public static MoveData RazorLeaf = new(
        "Razor Leaf", Grass,
        55, 95, 0,
        MoveEffect.Hit, 0,
        true, Target.Opponent + Target.Spread, 25, highCrit); //Needs anim
    public static MoveData SolarBeam = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Target.Single, 10); //Needs anim
    public static MoveData PoisonPowder = new(
        "Poison Powder", Poison,
        0, 75, 0,
        MoveEffect.Poison, 100,
        false, Target.Single, 35,
        powderMove); //Needs anim
    public static MoveData StunSpore = new(
        "Stun Spore", Grass,
        0, 75, 0,
        MoveEffect.Paralyze, 100,
        false, Target.Single, 30,
        powderMove); //Needs anim
    public static MoveData SleepPowder = new(
        "Sleep Powder", Grass,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, Target.Single, 15,
        powderMove); //Needs anim
    public static MoveData PetalDance = new(
        "Petal Dance", Grass,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        false, Target.Self, 10,
        makesContact); //Needs anim
    public static MoveData StringShot = new(
        "String Shot", Bug,
        0, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, Target.Opponent + Target.Spread, 40); //Needs anim
    public static MoveData DragonRage = new(
        "Dragon Rage", Dragon,
        1, 100, 0,
        MoveEffect.Direct40, 0,
        false, Target.Single, 10); //Needs anim
    public static MoveData FireSpin = new(
        "Fire Spin", Fire,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Target.Single, 15); //Needs anim
    public static MoveData ThunderShock = new(
        "Thunder Shock", Electric,
        40, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Target.Single, 30); //Needs anim
    public static MoveData Thunderbolt = new(
        "Thunderbolt", Electric,
        90, 100, 0,
        MoveEffect.Paralyze, 10,
        false, Target.Single, 15); //Needs anim
    public static MoveData ThunderWave = new(
        "Thunder Wave", Electric,
        0, 90, 0,
        MoveEffect.Paralyze, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Thunder = new(
        "Thunder", Electric,
        110, 70, 0,
        MoveEffect.Paralyze, 30,
        false, Target.Single, 10, alwaysHitsInRain); //Needs anim
    public static MoveData RockThrow = new(
        "Rock Throw", Rock,
        50, 90, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 15); //Needs anim
    public static MoveData Earthquake = new(
        "Earthquake", Ground,
        100, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 10, hitDiggingMon); //Needs anim
    public static MoveData Fissure = new(
        "Fissure", Ground,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, Target.Single, 5); //Needs anim
    public static MoveData Dig = new(
        "Dig", Ground,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Target.Single, 10); //Needs anim
    public static MoveData Toxic = new(
        "Toxic", Poison,
        0, 90, 0,
        MoveEffect.Toxic, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Confusion = new(
        "Confusion", Type.Psychic,
        50, 100, 0,
        MoveEffect.Confuse, 10,
        false, Target.Single, 25); //Needs anim
    public static MoveData Psychic = new(
        "Psychic", Type.Psychic,
        90, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Target.Single, 10); //Needs anim
    public static MoveData Hypnosis = new(
        "Hypnosis", Type.Psychic,
        0, 60, 0,
        MoveEffect.Sleep, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Meditate = new(
        "Meditate", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp1, 0,
        false, Target.Self, 40); //Needs anim
    public static MoveData Agility = new(
        "Agility", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.SpeedUp2, 100,
        false, Target.Self, 30); //Needs anim
    public static MoveData QuickAttack = new(
        "Quick Attack", Normal,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData Rage = new(
        "Rage", Normal,
        20, 100, 0,
        MoveEffect.Rage, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim and test
    public static MoveData Teleport = new(
        "Teleport", Type.Psychic,
        0, AlwaysHit, -6,
        MoveEffect.Teleport, 0,
        false, Target.Self, 20); //Needs anim
    public static MoveData NightShade = new(
        "Night Shade", Ghost,
        1, 100, 0,
        MoveEffect.DirectLevel, 0,
        false, Target.Single, 15); //Needs anim
    public static MoveData Mimic = new(
        "Mimic", Normal,
        0, 101, 0,
        MoveEffect.Mimic, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Screech = new(
        "Screech", Normal,
        0, 85, 0,
        MoveEffect.DefenseDown2, 100,
        false, Target.Single, 40,
        soundMove); //Needs anim
    public static MoveData DoubleTeam = new(
        "Double Team", Normal,
        0, 101, 0,
        MoveEffect.EvasionUp1, 100,
        false, Target.Self, 15); //Needs anim
    public static MoveData Recover = new(
        "Recover", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Target.Self, 10); //Needs anim
    public static MoveData Harden = new(
        "Harden", Normal,
        0, 101, 0,
        MoveEffect.DefenseUp1, 0,
        false, Target.Self, 30); //Needs anim
    public static MoveData Minimize = new(
        "Minimize", Normal,
        0, 101, 0,
        MoveEffect.Minimize, 100,
        false, Target.Self, 10); //Needs anim
    public static MoveData Smokescreen = new(
        "Smokescreen", Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData ConfuseRay = new(
        "Confuse Ray", Ghost,
        0, 100, 0,
        MoveEffect.Confuse, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Withdraw = new(
        "Withdraw", Water,
        0, 101, 0,
        MoveEffect.DefenseUp1, 100,
        false, Target.Self, 40); //Needs anim
    public static MoveData DefenseCurl = new(
        "Defense Curl", Normal,
        0, 101, 0,
        MoveEffect.DefenseCurl, 100,
        false, Target.Self, 40); //Needs anim
    public static MoveData Barrier = new(
        "Barrier", Type.Psychic,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, Target.Self, 20); //Needs anim
    public static MoveData LightScreen = new(
        "Light Screen", Type.Psychic,
        0, 101, 0,
        MoveEffect.LightScreen, 0,
        false, Target.Field, 30); //Needs anim
    public static MoveData Haze = new(
        "Haze", Ice,
        0, 101, 0,
        MoveEffect.Haze, 0,
        false, Target.Field, 30); //Needs anim
    public static MoveData Reflect = new(
        "Reflect", Type.Psychic,
        0, 101, 0,
        MoveEffect.Reflect, 0,
        false, Target.Field, 20); //Needs anim
    public static MoveData FocusEnergy = new(
        "Focus Energy", Normal,
        0, 101, 0,
        MoveEffect.CritRateUp2, 0,
        false, Target.Self, 30); //Needs anim
    public static MoveData Bide = new(
        "Bide", Normal,
        0, 101, 1,
        MoveEffect.ChargingAttack, 0,
        true, Target.Self, 10); //Needs anim
    public static MoveData Metronome = new(
        "Metronome", Normal,
        0, 101, 0,
        MoveEffect.Metronome, 0,
        false, Target.Self, 10,
        cannotMimic); //Needs anim
    public static MoveData MirrorMove = new(
        "Mirror Move", Flying,
        0, 101, 0,
        MoveEffect.MirrorMove, 0,
        false, Target.Single, 20); //Needs anim
    public static MoveData SelfDestruct = new(
        "Self Destruct", Normal,
        200, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Target.Single, 5); //Needs anim
    public static MoveData EggBomb = new(
        "Egg Bomb", Normal,
        100, 75, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 10); //Needs anim
    public static MoveData Lick = new(
        "Lick", Ghost,
        30, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData Smog = new(
        "Smog", Poison,
        30, 70, 0,
        MoveEffect.Poison, 40,
        false, Target.Single, 20); //Needs anim
    public static MoveData Sludge = new(
        "Sludge", Poison,
        65, 100, 0,
        MoveEffect.Poison, 30,
        false, Target.Single, 20); //Needs anim
    public static MoveData BoneClub = new(
        "Bone Club", Ground,
        65, 85, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20); //Needs anim
    public static MoveData FireBlast = new(
        "Fire Blast", Fire,
        110, 85, 0,
        MoveEffect.Burn, 30,
        false, Target.Single, 5); //Needs anim
    public static MoveData Waterfall = new(
        "Waterfall", Water,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Clamp = new(
        "Clamp", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Swift = new(
        "Swift", Normal,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, Target.Opponent + Target.Spread, 20); //Needs anim
    public static MoveData SkullBash = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData SpikeCannon = new(
        "Spike Cannon", Normal,
        20, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 15); //Needs anim
    public static MoveData Constrict = new(
        "Constrict", Normal,
        10, 100, 0,
        MoveEffect.SpeedDown1, 10,
        true, Target.Single, 35,
        makesContact); //Needs anim
    public static MoveData Amnesia = new(
        "Amnesia", Type.Psychic,
        0, 101, 0,
        MoveEffect.SpDefUp2, 100,
        false, Target.Self, 20); //Needs anim
    public static MoveData Kinesis = new(
        "Kinesis", Type.Psychic,
        0, 80, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Target.Single, 15); //Needs anim
    public static MoveData SoftBoiled = new(
        "Soft Boiled", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Target.Self, 10); //Needs anim
    public static MoveData HighJumpKick = new(
        "High Jump Kick", Fighting,
        130, 90, 0,
        MoveEffect.Crash50Max, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData Glare = new(
        "Glare", Normal,
        0, 100, 0,
        MoveEffect.Paralyze, 100,
        false, Target.Single, 30); //Needs anim
    public static MoveData DreamEater = new(
        "Dream Eater", Type.Psychic,
        100, 100, 0,
        MoveEffect.DreamEater, 0,
        false, Target.Single, 15); //Needs anim
    public static MoveData PoisonGas = new(
        "Poison Gas", Poison,
        0, 90, 0,
        MoveEffect.Poison, 100,
        false, Target.Opponent + Target.Spread, 40); //Needs anim
    public static MoveData Barrage = new(
        "Barrage", Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 20); //Needs anim
    public static MoveData LeechLife = new(
        "Leech Life", Bug,
        80, 100, 0,
        MoveEffect.Absorb50, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData LovelyKiss = new(
        "Lovely Kiss", Normal,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData SkyAttack = new(
        "Sky Attack", Flying,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, Target.Single, 5); //Needs anim
    public static MoveData Transform = new(
        "Transform", Normal,
        0, 101, 0,
        MoveEffect.Transform, 0,
        false, Target.Single, 10,
        cannotMimic); //Needs anim
    public static MoveData Bubble = new(
        "Bubble", Water,
        40, 100, 0,
        MoveEffect.SpeedDown1, 10,
        false, Target.Opponent + Target.Spread, 30); //Needs anim
    public static MoveData DizzyPunch = new(
        "Dizzy Punch", Normal,
        70, 100, 0,
        MoveEffect.Confuse, 20,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData Spore = new(
        "Spore", Grass,
        0, 100, 0,
        MoveEffect.Sleep, 100,
        false, Target.Single, 15,
        powderMove); //Needs anim
    public static MoveData Flash = new(
        "Flash", Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Psywave = new(
        "Psywave", Type.Psychic,
        1, 100, 0,
        MoveEffect.Psywave, 0,
        false, Target.Single, 15); //Needs anim
    public static MoveData Splash = new(
        "Splash", Normal,
        0, 101, 0,
        MoveEffect.None, 0,
        false, Target.Self, 40); //Needs anim
    public static MoveData AcidArmor = new(
        "Acid Armor", Poison,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, Target.Self, 20); //Needs anim
    public static MoveData Crabhammer = new(
        "Crabhammer", Water,
        100, 90, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 10,
        highCrit + makesContact); //Needs anim
    public static MoveData Explosion = new(
        "Explosion", Normal,
        250, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, Target.Single
        + Target.Spread, 5); //Needs anim
    public static MoveData FurySwipes = new(
        "Fury Swipes", Normal,
        18, 80, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Bonemerang = new(
        "Bonemerang", Ground,
        50, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, Target.Single, 10); //Needs anim
    public static MoveData Rest = new(
        "Rest", Type.Psychic,
        0, 101, 0,
        MoveEffect.Rest, 0,
        false, Target.Self, 10); //Needs anim
    public static MoveData RockSlide = new(
        "Rock Slide", Rock,
        75, 90, 0,
        MoveEffect.Flinch, 30,
        true, Target.Opponent + Target.Spread, 10); //Needs anim
    public static MoveData HyperFang = new(
        "Hyper Fang", Normal,
        80, 90, 0,
        MoveEffect.Flinch, 10,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Sharpen = new(
        "Sharpen", Normal,
        0, 101, 0,
        MoveEffect.AttackUp1, 100,
        false, Target.Self, 30); //Needs anim
    public static MoveData Conversion = new(
        "Conversion", Normal,
        0, 101, 0,
        MoveEffect.Conversion, 101,
        false, Target.Self, 30); //Needs anim
    public static MoveData TriAttack = new(
        "Tri Attack", Normal,
        80, 100, 0,
        MoveEffect.TriAttack, 20,
        false, Target.Single, 10); //Needs anim
    public static MoveData SuperFang = new(
        "Super Fang", Normal,
        0, 90, 0,
        MoveEffect.SuperFang, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData Slash = new(
        "Slash", Normal,
        70, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20,
        highCrit + makesContact); //Needs anim
    public static MoveData Substitute = new(
        "Substitute", Normal,
        0, 101, 0,
        MoveEffect.Substitute, 100,
        false, Target.Self, 10); //Needs anim

    //Gen 2

    public static MoveData Sketch = new(
         "Sketch", Normal,
         0, 101, 0,
         MoveEffect.Sketch, 0,
         false, Target.Single, 1); //Needs anim
    public static MoveData TripleKick = new(
        "Triple Kick", Fighting,
        10, 90, 0,
        MoveEffect.TripleHit, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData Thief = new(
        "Thief", Dark,
        60, 100, 0,
        MoveEffect.Thief, 100,
        true, Target.Single, 25,
        makesContact); //Needs anim
    public static MoveData SpiderWeb = new(
        "Spider Web", Bug,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData MindReader = new(
        "Mind Reader", Normal,
        0, 101, 0,
        MoveEffect.MindReader, 100,
        false, Target.Single, 5); //Needs testing and anim
    public static MoveData Nightmare = new(
        "Nightmare", Ghost,
        0, 100, 0,
        MoveEffect.Nightmare, 101,
        false, Target.Single, 15); //Needs anim
    public static MoveData FlameWheel = new(
        "Flame Wheel", Fire,
        60, 100, 0,
        MoveEffect.Burn, 10,
        true, Target.Single, 25,
        makesContact); //Needs anim
    public static MoveData Snore = new(
        "Snore", Normal,
        50, 100, 0,
        MoveEffect.Snore, 30,
        false, Target.Single, 15); //Needs anim
    public static MoveData Curse = new(
        "Curse", Ghost,
        0, 100, 0,
        MoveEffect.Curse, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Flail = new(
        "Flail", Normal,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Conversion2 = new(
        "Conversion 2", Normal,
        0, 101, 0,
        MoveEffect.Conversion2, 101,
        false, Target.Single, 30,
        effectOnSelfOnly); //Needs anim
    public static MoveData Aeroblast = new(
        "Aeroblast", Flying,
        100, 95, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 5,
        highCrit); //Needs anim
    public static MoveData CottonSpore = new(
        "Cotton Spore", Grass,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, Target.Opponent + Target.Spread, 40); //Needs anim
    public static MoveData Reversal = new(
        "Reversal", Fighting,
        1, 100, 0,
        MoveEffect.Reversal, 0,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Spite = new(
        "Spite", Ghost,
        0, 100, 0,
        MoveEffect.Spite, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData PowderSnow = new(
        "Powder Snow", Ice,
        40, 100, 0,
        MoveEffect.Freeze, 10,
        false, Target.Opponent + Target.Spread, 25); //Needs anim
    public static MoveData Protect = new(
        "Protect", Normal,
        0, 101, 4,
        MoveEffect.Protect, 100,
        false, Target.Self, 10,
        usesProtectCounter); //Needs anim
    public static MoveData MachPunch = new(
        "Mach Punch", Fighting,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, Target.Single, 30,
        makesContact); //Needs anim
    public static MoveData ScaryFace = new(
        "Scary Face", Normal,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData FeintAttack = new(
        "Feint Attack", Dark,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData SweetKiss = new(
        "Sweet Kiss", Fairy,
        0, 75, 0,
        MoveEffect.Confuse, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData BellyDrum = new(
        "Belly Drum", Normal,
        0, 101, 0,
        MoveEffect.BellyDrum, 100,
        false, Target.Self, 10); //Needs anim
    public static MoveData SludgeBomb = new(
        "Sludge Bomb", Poison,
        90, 100, 0,
        MoveEffect.Poison, 30,
        false, Target.Single, 10,
        bulletMove); //Needs anim
    public static MoveData MudSlap = new(
        "Mud Slap", Ground,
        20, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Octazooka = new(
        "Octazooka", Water,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 50,
        false, Target.Single, 10); //Needs anim
    public static MoveData Spikes = new(
        "Spikes", Ground,
        0, 101, 0,
        MoveEffect.Spikes, 100,
        false, Target.Field, 20); //Needs anim
    public static MoveData ZapCannon = new(
        "Zap Cannon", Electric,
        120, 50, 0,
        MoveEffect.Paralyze, 100,
        false, Target.Single, 5,
        bulletMove); //Needs anim
    public static MoveData Foresight = new(
        "Foresight", Normal,
        0, 101, 0,
        MoveEffect.Foresight, 100,
        false, Target.Single, 40); //Needs anim
    public static MoveData DestinyBond = new(
        "Destiny Bond", Ghost,
        0, 101, 0,
        MoveEffect.DestinyBond, 101,
        false, Target.Self, 5); //Needs anim
    public static MoveData PerishSong = new(
        "Perish Song", Normal,
        0, 101, 0,
        MoveEffect.PerishSong, 100,
        false, Target.All, 5,
        soundMove
        ); //Needs anim
    public static MoveData IcyWind = new(
        "Icy Wind", Ice,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, Target.Opponent + Target.Spread, 15); //Needs anim
    public static MoveData Detect = new(
        "Detect", Fighting,
        0, 101, 4,
        MoveEffect.Protect, 100,
        false, Target.Self, 5,
        usesProtectCounter); //Needs anim
    public static MoveData BoneRush = new(
        "Bone Rush", Ground,
        25, 90, 0,
        MoveEffect.MultiHit2to5, 0,
        true, Target.Single, 10); //Needs anim
    public static MoveData LockOn = new(
        "Lock On", Normal,
        0, 101, 0,
        MoveEffect.MindReader, 100,
        false, Target.Single, 5); //Needs anim
    public static MoveData Outrage = new(
        "Outrage", Dragon,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, Target.Self, 10,
        makesContact); //Needs anim
    public static MoveData Sandstorm = new(
        "Sandstorm", Rock,
        0, 101, 0,
        MoveEffect.Weather, 100,
        false, Target.Field, 10); //Needs anim
    public static MoveData GigaDrain = new(
        "Giga Drain", Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData Endure = new(
        "Endure", Normal,
        0, 101, 4,
        MoveEffect.Endure, 101,
        false, Target.Self, 10,
        usesProtectCounter); //Needs anim
    public static MoveData Charm = new(
        "Charm", Fairy,
        0, 100, 0,
        MoveEffect.AttackDown2, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData Rollout = new(
        "Rollout", Rock,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, Target.Single, 20,
        effectOnSelfOnly + makesContact); //Needs anim
    public static MoveData FalseSwipe = new(
        "False Swipe", Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, Target.Single, 40,
        makesContact); //Needs anim
    public static MoveData Swagger = new(
        "Swagger", Normal,
        0, 85, 0,
        MoveEffect.Swagger, 0,
        false, Target.Single, 15); //Needs anim
    public static MoveData MilkDrink = new(
        "Milk Drink", Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, Target.Self, 10); //Needs anim
    public static MoveData Spark = new(
        "Spark", Electric,
        65, 100, 0,
        MoveEffect.Paralyze, 30,
        true, Target.Single, 20,
        makesContact); //Need anim
    public static MoveData FuryCutter = new(
        "Fury Cutter", Bug,
        40, 95, 0,
        MoveEffect.FuryCutter, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData SteelWing = new(
        "Steel Wing", Steel,
        70, 90, 0,
        MoveEffect.DefenseUp1, 10,
        true, Target.Single, 25,
        effectOnSelfOnly + makesContact); //Needs anim
    public static MoveData MeanLook = new(
        "Mean Look", Normal,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, Target.Single, 5); //Needs anim
    public static MoveData Attract = new(
        "Attract", Normal,
        0, 100, 0,
        MoveEffect.Attract, 100,
        false, Target.Single, 15); //Needs anim
    public static MoveData SleepTalk = new(
        "Sleep Talk", Normal,
        0, 101, 0,
        MoveEffect.SleepTalk, 100,
        false, Target.Self, 10); //Needs testing and anim
    public static MoveData HealBell = new(
        "Heal Bell", Normal,
        0, 101, 0,
        MoveEffect.HealBell, 100,
        false, Target.Field, 5); //Needs anim
    public static MoveData Return = new(
        "Return", Normal,
        1, 100, 0,
        MoveEffect.Return, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Present = new(
        "Present", Normal,
        1, 90, 0,
        MoveEffect.Present, 0,
        true, Target.Single, 15); //Needs anim
    public static MoveData Frustration = new(
        "Frustration", Normal,
        0, 100, 0,
        MoveEffect.Frustration, 0,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData Safeguard = new(
        "Safeguard", Normal,
        0, 101, 0,
        MoveEffect.Safeguard, 100,
        false, Target.Field, 25); //Needs anim
    public static MoveData PainSplit = new(
        "Pain Split", Normal,
        0, 101, 0,
        MoveEffect.PainSplit, 100,
        false, Target.Single, 20); //Needs anim
    public static MoveData SacredFire = new(
        "Sacred Fire", Fire,
        100, 95, 0,
        MoveEffect.Burn, 50,
        true, Target.Single, 5); //Needs anim
    public static MoveData Magnitude = new(
        "Magnitude", Ground,
        1, 100, 0,
        MoveEffect.Magnitude, 0,
        true, Target.Single, 30); //Needs anim
    public static MoveData DynamicPunch = new(
        "Dynamic Punch", Fighting,
        100, 50, 0,
        MoveEffect.Confuse, 100,
        true, Target.Single, 5,
        makesContact); //Needs anim
    public static MoveData Megahorn = new(
        "Megahorn", Bug,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData DragonBreath = new(
        "Dragon Breath", Dragon,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        false, Target.Single, 20); //Needs anim
    public static MoveData BatonPass = new(
        "Baton Pass", Normal,
        0, 101, 0,
        MoveEffect.BatonPass, 100,
        false, Target.Self, 40); //Needs testing and anim
    public static MoveData Encore = new(
        "Encore", Normal,
        0, 100, 0,
        MoveEffect.Encore, 100,
        false, Target.Single, 5); //Needs testing and anim
    public static MoveData Pursuit = new(
        "Pursuit", Dark,
        40, 100, 0,
        MoveEffect.Pursuit, 100,
        true, Target.Single, 20,
        makesContact); //Needs anim
    public static MoveData RapidSpin = new(
        "Rapid Spin", Normal,
        50, 100, 0,
        MoveEffect.RapidSpin, 100,
        true, Target.Single, 40,
        effectOnSelfOnly + makesContact); //Needs anim
    public static MoveData SweetScent = new(
        "Sweet Scent", Normal,
        0, 100, 0,
        MoveEffect.EvasionDown2, 100,
        false, Target.Opponent + Target.Spread, 20); //Needs anim
    public static MoveData IronTail = new(
        "Iron Tail", Steel,
        100, 75, 0,
        MoveEffect.DefenseDown1, 30,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData MetalClaw = new(
        "Metal Claw", Steel,
        50, 95, 0,
        MoveEffect.AttackUp1, 10,
        true, Target.Single, 35,
        effectOnSelfOnly + makesContact); //Needs anim
    public static MoveData VitalThrow = new(
        "Vital Throw", Fighting,
        70, 101, -1,
        MoveEffect.Hit, 0,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData MorningSun = new(
        "Morning Sun", Normal,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Target.Self, 5); //Needs anim
    public static MoveData Synthesis = new(
        "Synthesis", Grass,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Target.Self, 5); //Needs anim
    public static MoveData Moonlight = new(
        "Moonlight", Fairy,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, Target.Self, 5); //Needs anim
    public static MoveData HiddenPower = new(
        "Hidden Power", Normal,
        60, 100, 0,
        MoveEffect.HiddenPower, 0,
        false, Target.Single, 15); //Needs anim
    public static MoveData CrossChop = new(
        "Cross Chop", Fighting,
        100, 80, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 5,
        highCrit + makesContact); //Needs anim
    public static MoveData Twister = new(
        "Twister", Dragon,
        40, 100, 0,
        MoveEffect.Flinch, 20,
        false, Target.Opponent + Target.Spread, 20,
        hitFlyingMon); //Needs anim
    public static MoveData RainDance = new(
        "Rain Dance", Water,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, Target.Field, 5); //Needs anim
    public static MoveData SunnyDay = new(
        "Sunny Day", Fire,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, Target.Field, 5); //Needs anim
    public static MoveData Crunch = new(
        "Crunch", Dark,
        80, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData MirrorCoat = new(
        "Mirror Coat", Type.Psychic,
        0, 100, -5,
        MoveEffect.Counter, 0,
        false, Target.Self, 20); //Needs testing and anim
    public static MoveData PsychUp = new(
        "Psych Up", Normal,
        0, 101, 0,
        MoveEffect.PsychUp, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData ExtremeSpeed = new(
        "Extreme Speed", Normal,
        80, 100, 2,
        MoveEffect.Hit, 0,
        true, Target.Single, 5,
        makesContact); //Needs anim
    public static MoveData AncientPower = new(
        "Ancient Power", Rock,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, Target.Single, 5); //Needs anim
    public static MoveData ShadowBall = new(
        "Shadow Ball", Ghost,
        80, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, Target.Single, 15,
        bulletMove); //Needs anim
    public static MoveData FutureSight = new(
        "Future Sight", Type.Psychic,
        120, 100, 0,
        MoveEffect.FutureSight, 100,
        false, Target.Single, 10); //Needs anim
    public static MoveData RockSmash = new(
        "Rock Smash", Fighting,
        40, 100, 0,
        MoveEffect.DefenseDown1, 50,
        true, Target.Single, 15,
        makesContact); //Needs anim
    public static MoveData Whirlpool = new(
        "Whirlpool", Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, Target.Single, 15); //Needs anim
    public static MoveData BeatUp = new(
        "Beat Up", Dark,
        1, 100, 0,
        MoveEffect.BeatUp, 0,
        true, Target.Single, 10); //Needs anim

    //Gen 3

    public static MoveData FakeOut = new(
        "Fake Out", Normal,
        40, 100, 3,
        MoveEffect.FakeOut, 100,
        true, Target.Single, 10,
        makesContact); //Needs anim
    public static MoveData Uproar = new(
        "Uproar", Normal,
        90, 100, 0,
        MoveEffect.Uproar, 100,
        false, Target.Self, 10,
        soundMove + effectOnSelfOnly); //Needs anim
    public static MoveData Stockpile = SelfTargetingMove(
        "Stockpile", Normal, 0, MoveEffect.Stockpile, 20); //Needs anim
    public static MoveData SpitUp = new(
        "Spit Up", Normal,
        1, 100, 0,
        MoveEffect.SpitUp, 0,
        false, Target.Single, 10); //Needs anim
    public static MoveData Swallow = SelfTargetingMove(
        "Swallow", Normal, 0, MoveEffect.Swallow, 10); //Needs anim
    public static MoveData HeatWave = new(
        "Heat Wave", Fire,
        95, 90, 0,
        MoveEffect.Burn, 10,
        false, Target.Opponent + Target.Spread, 10); //Needs anim
    public static MoveData Hail = FieldMove(
        "Hail", Ice, 0, MoveEffect.Weather, 10); //Needs anim
    public static MoveData Torment = SingleTargetStatusMove(
        "Torment", Dark, 100, 0, MoveEffect.Torment, 15); //Needs anim
    public static MoveData Flatter = SingleTargetStatusMove(
        "Flatter", Dark, 100, 0, MoveEffect.Flatter, 15); //Needs anim
    public static MoveData WillOWisp = SingleTargetStatusMove(
        "Will-O-Wisp", Fire, 85, 0, MoveEffect.Burn, 15); //Needs anim
    public static MoveData Memento = SingleTargetStatusMove(
        "Memento", Dark, 100, 0, MoveEffect.Memento, 10); //Needs anim
    public static MoveData Facade = new(
        "Facade", Normal,
        70, 100, 0,
        MoveEffect.Facade, 0,
        true, Target.Single, 20,
        makesContact);
    public static MoveData FocusPunch = new(
        "Focus Punch", Fighting,
        150, 100, 9,
        MoveEffect.FocusPunchWindup, 100,
        true, Target.Single, 20,
        effectOnSelfOnly);
    public static MoveData SmellingSalts = new(
        "Smelling Salts", Normal,
        70, 100, 0,
        MoveEffect.SmellingSalts, 100,
        true, Target.Single, 10,
        makesContact);
    public static MoveData FollowMe = SelfTargetingMove(
        "Follow Me", Normal, 2, MoveEffect.FollowMe, 20);
    public static MoveData NaturePower = new(
        "Nature Power", Normal,
        1, 100, 0,
        MoveEffect.NaturePower, 0,
        false, Target.Single, 20);
    public static MoveData Charge = SelfTargetingMove(
        "Charge", Electric, 0, MoveEffect.Charge, 20);
    public static MoveData Taunt = SingleTargetStatusMove(
        "Taunt", Dark, 100, 0, MoveEffect.Taunt, 20);
    public static MoveData HelpingHand = new(
        "Helping Hand", Normal,
        0, 100, 5,
        MoveEffect.HelpingHand, 100,
        false, Target.Ally, 20);
    public static MoveData Trick = SingleTargetStatusMove(
        "Trick", Type.Psychic, 100, 0, MoveEffect.Trick, 10);
    public static MoveData RolePlay = SingleTargetStatusMove(
        "Role Play", Type.Psychic, 100, 0, MoveEffect.RolePlay, 10);
    public static MoveData Wish = SelfTargetingMove(
        "Wish", Normal, 0, MoveEffect.Wish, 10);



    //Non-standard moves
    public static MoveData ConfusionHit = new(
        "a move it shouldn't be able to! (ConfusionHit) [Error 101]", Typeless,
        40, 101, 0,
        MoveEffect.Hit, 0,
        true, Target.Self, 0,
        mimicBypass);
    public static MoveData Recharge = new(
        "a move it shouldn't be able to! (Recharge) [Error 101]", Typeless,
        0, 0, 0,
        MoveEffect.None, 0,
        false, 0, 0,
        mimicBypass);
    public static MoveData RazorWindAttack = new(
        "Razor Wind", Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Opponent + Target.Spread, 0,
        mimicBypass); //Needs anim
    public static MoveData DigAttack = new(
        "Dig", Ground,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Opponent + Target.Spread, 0,
        mimicBypass + makesContact); //Needs anim
    public static MoveData FlyAttack = new(
        "Fly", Flying,
        90, 95, 0,
        MoveEffect.Hit, 0,
        false, Target.Opponent + Target.Spread, 0,
        mimicBypass + makesContact); //Needs anim
    public static MoveData SolarBeamAttack = new(
        "Solar Beam", Grass,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, Target.Single, 0,
        halfPowerInBadWeather + mimicBypass); //Needs anim
    public static MoveData SkyAttackAttack = new(
        "Sky Attack", Flying,
        140, 90, 0,
        MoveEffect.Flinch, 30,
        true, Target.Single, 5,
        highCrit + mimicBypass);
    public static MoveData SkullBashAttack = new(
        "Skull Bash", Normal,
        130, 100, 0,
        MoveEffect.Hit, 0,
        true, Target.Single, 10); //Needs anim
    public static MoveData BideMiddle = new(
        "Bide", Typeless,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, Target.None, 0,
        mimicBypass); //Needs anim);
    public static MoveData BideAttack = new(
        "Bide", Typeless,
        1, 100, 0,
        MoveEffect.BideHit, 0,
        false, Target.Opponent, 0,
        mimicBypass + makesContact); //Needs anim
    public static MoveData FocusPunchAttack = new(
        "Focus Punch", Fighting,
        150, 100, -3,
        MoveEffect.FocusPunchAttack, 0,
        true, Target.Single, 20,
        makesContact);
    public static MoveData Struggle = new(
        "Struggle", Typeless,
        50, 100, 0,
        MoveEffect.Recoil25Max, 100,
        true, Target.Single, 0,
        cannotMimic); //Meeds anim


    public static MoveData[] MoveTable = new MoveData[(int)MoveID.Count] {
        None,
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
        ViceGrip,
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
    };
}
