using System.Reflection;
using System.Threading;
using UnityEngine;

public static class Move
{
    public const byte AlwaysHit = 101;
    public static MoveData None = new("Error 10", Type.Normal, 0,
            0, 0, 0, 0, false, 0, 0);
    public static MoveData Pound = new(
        "Pound", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Done
    public static MoveData KarateChop = new(
        "Karate Chop", Type.Fighting,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.highCrit + MoveFlags.makesContact); //Done
    public static MoveData DoubleSlap = new(
        "Double Slap", Type.Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Done
    public static MoveData CometPunch = new(
        "Comet Punch", Type.Normal,
        18, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 15,
         MoveFlags.makesContact); //Needs anim
    public static MoveData MegaPunch = new(
        "Mega Punch", Type.Normal,
        80, 85, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
         MoveFlags.makesContact); //Needs anim
    public static MoveData PayDay = new(
        "Pay Day", Type.Normal,
        40, 100, 0,
        MoveEffect.PayDay, 101,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim and money implementation
    public static MoveData FirePunch = new(
        "Fire Punch", Type.Fire,
        75, 100, 0,
        MoveEffect.Burn, 10,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData IcePunch = new(
        "Ice Punch", Type.Ice,
        75, 100, 0,
        MoveEffect.Freeze, 10,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData ThunderPunch = new(
        "Thunder Punch", Type.Electric,
        75, 100, 0,
        MoveEffect.Paralyze, 10,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Scratch = new(
        "Scratch", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Needs anim
    public static MoveData ViceGrip = new(
        "Vice Grip", Type.Normal,
        55, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Guillotine = new(
        "Guillotine", Type.Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.makesContact); //Needs anim
    public static MoveData RazorWind = new(
        "Razor Wind", Type.Normal,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, TargetID.Opponent + TargetID.Spread, 10); //Needs anim
    public static MoveData SwordsDance = new(
        "Swords Dance", Type.Normal,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp2, 0,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData Cut = new(
        "Cut", Type.Normal,
        50, 95, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Gust = new(
        "Gust", Type.Flying,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.hitFlyingMon); //Needs anim
    public static MoveData WingAttack = new(
        "Wing Attack", Type.Flying,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Whirlwind = new(
        "Whirlwind", Type.Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Fly = new(
        "Fly", Type.Flying,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Bind = new(
        "Bind", Type.Normal,
        15, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Slam = new(
        "Slam", Type.Normal,
        80, 75, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData VineWhip = new(
        "Vine Whip", Type.Grass,
        45, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Stomp = new(
        "Stomp", Type.Normal,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData DoubleKick = new(
        "Double Kick", Type.Fighting,
        30, 100, 0,
        MoveEffect.MultiHit2, 0,
        true, TargetID.Opponent + TargetID.Ally, 30,
        MoveFlags.makesContact); //Needs anim
    public static MoveData MegaKick = new(
        "Mega Kick", Type.Normal,
        120, 75, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.makesContact); //Needs anim
    public static MoveData JumpKick = new(
        "Jump Kick", Type.Fighting,
        100, 20, 0,
        MoveEffect.Crash50Max, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData RollingKick = new(
        "Rolling Kick", Type.Fighting,
        60, 85, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData SandAttack = new(
        "Sand Attack", Type.Ground,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Headbutt = new(
        "Headbutt", Type.Normal,
        70, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs field effect and anim
    public static MoveData HornAttack = new(
        "Horn Attack", Type.Normal,
        65, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.makesContact); //Needs anim
    public static MoveData FuryAttack = new(
        "Fury Attack", Type.Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData HornDrill = new(
        "Horn Drill", Type.Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Tackle = new(
        "Tackle", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Needs anim
    public static MoveData BodySlam = new(
        "Body Slam", Type.Normal,
        85, 100, 0,
        MoveEffect.Paralyze, 30,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Wrap = new(
        "Wrap", Type.Normal,
        15, 90, 0,
        MoveEffect.ContinuousDamage, 100,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData TakeDown = new(
        "Take Down", Type.Normal,
        90, 85, 0,
        MoveEffect.Recoil25, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Thrash = new(
        "Thrash", Type.Normal,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, TargetID.Self, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData DoubleEdge = new(
        "Double Edge", Type.Normal,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData TailWhip = new(
        "Tail Whip", Type.Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData PoisonSting = new(
        "Poison Sting", Type.Poison,
        15, 100, 0,
        MoveEffect.Poison, 30,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData Twineedle = new(
        "Twineedle", Type.Bug,
        25, 100, 0,
        MoveEffect.Twineedle, 20,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData PinMissile = new(
        "Pin Missile", Type.Bug,
        25, 95, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Leer = new(
        "Leer", Type.Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData Bite = new(
        "Bite", Type.Dark,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Growl = new(
        "Growl", Type.Normal,
        0, 100, 0,
        MoveEffect.AttackDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 40,
        MoveFlags.soundMove);
    public static MoveData Roar = new(
        "Roar", Type.Normal,
        0, AlwaysHit, -6,
        MoveEffect.ForcedSwitch, 100,
        false, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.soundMove); //Needs anim
    public static MoveData Sing = new(
        "Sing", Type.Normal,
        0, 55, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.soundMove); //Needs anim
    public static MoveData Supersonic = new(
        "Supersonic", Type.Normal,
        0, 55, 0,
        MoveEffect.Confuse, 100,
        false, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.soundMove); //Needs anim
    public static MoveData SonicBoom = new(
        "Sonic Boom", Type.Normal,
        1, 90, 0,
        MoveEffect.Direct20, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Disable = new(
        "Disable", Type.Normal,
        0, 100, 0,
        MoveEffect.Disable, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Acid = new(
        "Acid", Type.Poison,
        40, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData Ember = new(
        "Ember", Type.Fire,
        40, 100, 0,
        MoveEffect.Burn, 10,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Flamethrower = new(
        "Flamethrower", Type.Fire,
        90, 100, 0,
        MoveEffect.Burn, 10,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Mist = new(
        "Mist", Type.Ice,
        0, AlwaysHit, 0,
        MoveEffect.Mist, 100,
        false, TargetID.Field, 30); //Needs anim
    public static MoveData WaterGun = new(
        "Water Gun", Type.Water,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData HydroPump = new(
        "Hydro Pump", Type.Water,
        110, 80, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Surf = new(
        "Surf", Type.Water,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally + TargetID.Spread, 15); //Needs anim
    public static MoveData IceBeam = new(
        "Ice Beam", Type.Ice,
        90, 100, 0,
        MoveEffect.Freeze, 10,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Blizzard = new(
        "Blizzard", Type.Ice,
        110, 70, 0,
        MoveEffect.Freeze, 10,
        false, TargetID.Opponent + TargetID.Spread, 5); //Needs anim
    public static MoveData Psybeam = new(
        "Psybeam", Type.Psychic,
        65, 100, 0,
        MoveEffect.Confuse, 10,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData BubbleBeam = new(
        "Bubble Beam", Type.Water,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData AuroraBeam = new(
        "Aurora Beam", Type.Ice,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData HyperBeam = new(
        "Hyper Beam", Type.Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Peck = new(
        "Peck", Type.Flying,
        35, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Needs anim
    public static MoveData DrillPeck = new(
        "Drill Peck", Type.Flying,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Submission = new(
        "Submission", Type.Fighting,
        80, 80, 0,
        MoveEffect.Recoil25, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData LowKick = new(
        "Low Kick", Type.Fighting,
        1, 100, 0,
        MoveEffect.WeightPower, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Counter = new(
        "Counter", Type.Fighting,
        1, 100, -5,
        MoveEffect.Counter, 0,
        true, TargetID.None, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData SeismicToss = new(
        "Seismic Toss", Type.Fighting,
        0, 100, 0,
        MoveEffect.DirectLevel, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Strength = new(
        "Strength", Type.Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Absorb = new(
        "Absorb", Type.Grass,
        20, 100, 0,
        MoveEffect.Absorb50, 100,
        false, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData MegaDrain = new(
        "Mega Drain", Type.Grass,
        40, 100, 0,
        MoveEffect.Absorb50, 100,
        false, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData LeechSeed = new(
        "Leech Seed", Type.Grass,
        0, 90, 0,
        MoveEffect.LeechSeed, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Growth = new(
        "Growth", Type.Normal,
        0, AlwaysHit, 0,
        MoveEffect.Growth, 100,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData RazorLeaf = new(
        "Razor Leaf", Type.Grass,
        55, 95, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Spread, 25, MoveFlags.highCrit); //Needs anim
    public static MoveData SolarBeam = new(
        "Solar Beam", Type.Grass,
        120, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData PoisonPowder = new(
        "Poison Powder", Type.Poison,
        0, 75, 0,
        MoveEffect.Poison, 100,
        false, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData StunSpore = new(
        "Stun Spore", Type.Grass,
        0, 75, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData SleepPowder = new(
        "Sleep Powder", Type.Grass,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData PetalDance = new(
        "Petal Dance", Type.Grass,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        false, TargetID.Self, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData StringShot = new(
        "String Shot", Type.Bug,
        0, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 40); //Needs anim
    public static MoveData DragonRage = new(
        "Dragon Rage", Type.Dragon,
        1, 100, 0,
        MoveEffect.Direct40, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData FireSpin = new(
        "Fire Spin", Type.Fire,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData ThunderShock = new(
        "Thunder Shock", Type.Electric,
        40, 100, 0,
        MoveEffect.Paralyze, 10,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData Thunderbolt = new(
        "Thunderbolt", Type.Electric,
        90, 100, 0,
        MoveEffect.Paralyze, 10,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData ThunderWave = new(
        "Thunder Wave", Type.Electric,
        0, 90, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Thunder = new(
        "Thunder", Type.Electric,
        110, 70, 0,
        MoveEffect.Paralyze, 30,
        false, TargetID.Opponent + TargetID.Ally, 10, MoveFlags.alwaysHitsInRain); //Needs anim
    public static MoveData RockThrow = new(
        "Rock Throw", Type.Rock,
        50, 90, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Earthquake = new(
        "Earthquake", Type.Ground,
        100, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10, MoveFlags.hitDiggingMon); //Needs anim
    public static MoveData Fissure = new(
        "Fissure", Type.Ground,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Dig = new(
        "Dig", Type.Ground,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Toxic = new(
        "Toxic", Type.Poison,
        0, 90, 0,
        MoveEffect.Toxic, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Confusion = new(
        "Confusion", Type.Psychic,
        50, 100, 0,
        MoveEffect.Confuse, 10,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Psychic = new(
        "Psychic", Type.Psychic,
        90, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Hypnosis = new(
        "Hypnosis", Type.Psychic,
        0, 60, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Meditate = new(
        "Meditate", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp1, 0,
        false, TargetID.Self, 40); //Needs anim
    public static MoveData Agility = new(
        "Agility", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.SpeedUp2, 100,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData QuickAttack = new(
        "Quick Attack", Type.Normal,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Rage = new(
        "Rage", Type.Normal,
        20, 100, 0,
        MoveEffect.Rage, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.makesContact); //Needs anim and test
    public static MoveData Teleport = new(
        "Teleport", Type.Psychic,
        0, AlwaysHit, -6,
        MoveEffect.Teleport, 0,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData NightShade = new(
        "Night Shade", Type.Ghost,
        1, 100, 0,
        MoveEffect.DirectLevel, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Mimic = new(
        "Mimic", Type.Normal,
        0, 101, 0,
        MoveEffect.Mimic, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Screech = new(
        "Screech", Type.Normal,
        0, 85, 0,
        MoveEffect.DefenseDown2, 100,
        false, TargetID.Opponent + TargetID.Ally, 40,
        MoveFlags.soundMove); //Needs anim
    public static MoveData DoubleTeam = new(
        "Double Team", Type.Normal,
        0, 101, 0,
        MoveEffect.EvasionUp1, 100,
        false, TargetID.Self, 15); //Needs anim
    public static MoveData Recover = new(
        "Recover", Type.Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData Harden = new(
        "Harden", Type.Normal,
        0, 101, 0,
        MoveEffect.DefenseUp1, 0,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData Minimize = new(
        "Minimize", Type.Normal,
        0, 101, 0,
        MoveEffect.Minimize, 100,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData Smokescreen = new(
        "Smokescreen", Type.Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData ConfuseRay = new(
        "Confuse Ray", Type.Ghost,
        0, 100, 0,
        MoveEffect.Confuse, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Withdraw = new(
        "Withdraw", Type.Water,
        0, 101, 0,
        MoveEffect.DefenseUp1, 100,
        false, TargetID.Self, 40); //Needs anim
    public static MoveData DefenseCurl = new(
        "Defense Curl", Type.Normal,
        0, 101, 0,
        MoveEffect.DefenseCurl, 100,
        false, TargetID.Self, 40); //Needs anim
    public static MoveData Barrier = new(
        "Barrier", Type.Psychic,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData LightScreen = new(
        "Light Screen", Type.Psychic,
        0, 101, 0,
        MoveEffect.LightScreen, 0,
        false, TargetID.Field, 30); //Needs anim
    public static MoveData Haze = new(
        "Haze", Type.Ice,
        0, 101, 0,
        MoveEffect.Haze, 0,
        false, TargetID.Field, 30); //Needs anim
    public static MoveData Reflect = new(
        "Reflect", Type.Psychic,
        0, 101, 0,
        MoveEffect.Reflect, 0,
        false, TargetID.Field, 20); //Needs anim
    public static MoveData FocusEnergy = new(
        "Focus Energy", Type.Normal,
        0, 101, 0,
        MoveEffect.CritRateUp2, 0,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData Bide = new(
        "Bide", Type.Normal,
        0, 101, 1,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Self, 10); //Needs anim
    public static MoveData Metronome = new(
        "Metronome", Type.Normal,
        0, 101, 0,
        MoveEffect.Metronome, 0,
        false, TargetID.Self, 10,
        MoveFlags.cannotMimic); //Needs anim
    public static MoveData MirrorMove = new(
        "Mirror Move", Type.Flying,
        0, 101, 0,
        MoveEffect.MirrorMove, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData SelfDestruct = new(
        "Self Destruct", Type.Normal,
        200, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData EggBomb = new(
        "Egg Bomb", Type.Normal,
        100, 75, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Lick = new(
        "Lick", Type.Ghost,
        30, 100, 0,
        MoveEffect.Paralyze, 30,
        true, TargetID.Opponent + TargetID.Ally, 30,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Smog = new(
        "Smog", Type.Poison,
        30, 70, 0,
        MoveEffect.Poison, 40,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Sludge = new(
        "Sludge", Type.Poison,
        65, 100, 0,
        MoveEffect.Poison, 30,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData BoneClub = new(
        "Bone Club", Type.Ground,
        65, 85, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData FireBlast = new(
        "Fire Blast", Type.Fire,
        110, 85, 0,
        MoveEffect.Burn, 30,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Waterfall = new(
        "Waterfall", Type.Water,
        80, 100, 0,
        MoveEffect.Flinch, 20,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Clamp = new(
        "Clamp", Type.Water,
        35, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Swift = new(
        "Swift", Type.Normal,
        60, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 20); //Needs anim
    public static MoveData SkullBash = new(
        "Skull Bash", Type.Normal,
        130, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData SpikeCannon = new(
        "Spike Cannon", Type.Normal,
        20, 100, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Constrict = new(
        "Constrict", Type.Normal,
        10, 100, 0,
        MoveEffect.SpeedDown1, 10,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Amnesia = new(
        "Amnesia", Type.Psychic,
        0, 101, 0,
        MoveEffect.SpDefUp2, 100,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData Kinesis = new(
        "Kinesis", Type.Psychic,
        0, 80, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData SoftBoiled = new(
        "Soft Boiled", Type.Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData HighJumpKick = new(
        "High Jump Kick", Type.Fighting,
        130, 90, 0,
        MoveEffect.Crash50Max, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Glare = new(
        "Glare", Type.Normal,
        0, 100, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData DreamEater = new(
        "Dream Eater", Type.Psychic,
        100, 100, 0,
        MoveEffect.DreamEater, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData PoisonGas = new(
        "Poison Gas", Type.Poison,
        0, 90, 0,
        MoveEffect.Poison, 100,
        false, TargetID.Opponent + TargetID.Spread, 40); //Needs anim
    public static MoveData Barrage = new(
        "Barrage", Type.Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData LeechLife = new(
        "Leech Life", Type.Bug,
        80, 100, 0,
        MoveEffect.Absorb50, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData LovelyKiss = new(
        "Lovely Kiss", Type.Normal,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData SkyAttack = new(
        "Sky Attack", Type.Flying,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Transform = new(
        "Transform", Type.Normal,
        0, 101, 0,
        MoveEffect.Transform, 0,
        false, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.cannotMimic); //Needs anim
    public static MoveData Bubble = new(
        "Bubble", Type.Water,
        40, 100, 0,
        MoveEffect.SpeedDown1, 10,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData DizzyPunch = new(
        "Dizzy Punch", Type.Normal,
        70, 100, 0,
        MoveEffect.Confuse, 20,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Spore = new(
        "Spore", Type.Grass,
        0, 100, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Flash = new(
        "Flash", Type.Normal,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Psywave = new(
        "Psywave", Type.Psychic,
        1, 100, 0,
        MoveEffect.Psywave, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Splash = new(
        "Splash", Type.Normal,
        0, 101, 0,
        MoveEffect.None, 0,
        false, TargetID.Self, 40); //Needs anim
    public static MoveData AcidArmor = new(
        "Acid Armor", Type.Poison,
        0, 101, 0,
        MoveEffect.DefenseUp2, 100,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData Crabhammer = new(
        "Crabhammer", Type.Water,
        100, 90, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.highCrit + MoveFlags.makesContact); //Needs anim
    public static MoveData Explosion = new(
        "Explosion", Type.Normal,
        250, 100, 0,
        MoveEffect.SelfDestruct, 0,
        true, TargetID.Opponent + TargetID.Ally
        + TargetID.Spread, 5); //Needs anim
    public static MoveData FurySwipes = new(
        "Fury Swipes", Type.Normal,
        18, 80, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Bonemerang = new(
        "Bonemerang", Type.Ground,
        50, 90, 0,
        MoveEffect.MultiHit2, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Rest = new(
        "Rest", Type.Psychic,
        0, 101, 0,
        MoveEffect.Rest, 0,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData RockSlide = new(
        "Rock Slide", Type.Rock,
        75, 90, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Spread, 10); //Needs anim
    public static MoveData HyperFang = new(
        "Hyper Fang", Type.Normal,
        80, 90, 0,
        MoveEffect.Flinch, 10,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Sharpen = new(
        "Sharpen", Type.Normal,
        0, 101, 0,
        MoveEffect.AttackUp1, 100,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData Conversion = new(
        "Conversion", Type.Normal,
        0, 101, 0,
        MoveEffect.Conversion, 101,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData TriAttack = new(
        "Tri Attack", Type.Normal,
        80, 100, 0,
        MoveEffect.TriAttack, 20,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData SuperFang = new(
        "Super Fang", Type.Normal,
        0, 90, 0,
        MoveEffect.SuperFang, 0,
        true, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Slash = new(
        "Slash", Type.Normal,
        70, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.highCrit + MoveFlags.makesContact); //Needs anim
    public static MoveData Substitute = new(
        "Substitute", Type.Normal,
        0, 101, 0,
        MoveEffect.Substitute, 100,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData Sketch = new(
         "Sketch", Type.Normal,
         0, 101, 0,
         MoveEffect.Sketch, 0,
         false, TargetID.Opponent + TargetID.Ally, 1); //Needs anim
    public static MoveData TripleKick = new(
        "Triple Kick", Type.Fighting,
        10, 90, 0,
        MoveEffect.TripleHit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Thief = new(
        "Thief", Type.Dark,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25); //Needs effect and anim
    public static MoveData SpiderWeb = new(
        "Spider Web", Type.Bug,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData MindReader = new(
        "Mind Reader", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs effect and anim
    public static MoveData Nightmare = new(
        "Nightmare", Type.Ghost,
        0, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData FlameWheel = new(
        "Flame Wheel", Type.Fire,
        60, 100, 0,
        MoveEffect.Burn, 10,
        true, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Snore = new(
        "Snore", Type.Normal,
        50, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData Curse = new(
        "Curse", Type.Ghost,
        0, 100, 0,
        MoveEffect.Curse, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData Flail = new(
        "Flail", Type.Normal,
        0, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData Conversion2 = new(
        "Conversion 2", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs effect and anim
    public static MoveData Aeroblast = new(
        "Aeroblast", Type.Flying,
        100, 95, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.highCrit); //Needs anim
    public static MoveData CottonSpore = new(
        "Cotton Spore", Type.Grass,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, TargetID.Opponent + TargetID.Spread, 40); //Needs anim
    public static MoveData Reversal = new(
        "Reversal", Type.Fighting,
        0, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData Spite = new(
        "Spite", Type.Ghost,
        0, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData PowderSnow = new(
        "Powder Snow", Type.Ice,
        40, 100, 0,
        MoveEffect.Freeze, 10,
        false, TargetID.Opponent + TargetID.Spread, 25); //Needs anim
    public static MoveData Protect = new(
        "Protect", Type.Normal,
        0, 101, 4,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 10); //Needs effect and anim
    public static MoveData MachPunch = new(
        "Mach Punch", Type.Fighting,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData ScaryFace = new(
        "Scary Face", Type.Normal,
        0, 100, 0,
        MoveEffect.SpeedDown2, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData FeintAttack = new(
        "Feint Attack", Type.Dark,
        60, 101, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData SweetKiss = new(
        "Sweet Kiss", Type.Fairy,
        0, 75, 0,
        MoveEffect.Confuse, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData BellyDrum = new(
        "Belly Drum", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 10); //Needs effect and anim
    public static MoveData SludgeBomb = new(
        "Sludge Bomb", Type.Poison,
        90, 100, 0,
        MoveEffect.Poison, 30,
        false, TargetID.Opponent + TargetID.Ally, 10,
        MoveFlags.bulletMove); //Needs anim
    public static MoveData MudSlap = new(
        "Mud Slap", Type.Ground,
        20, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Octazooka = new(
        "Octazooka", Type.Water,
        65, 85, 0,
        MoveEffect.AccuracyDown1, 50,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Spikes = new(
        "Spikes", Type.Ground,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Field, 20); //Needs effect and anim
    public static MoveData ZapCannon = new(
        "Zap Cannon", Type.Electric,
        120, 50, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.bulletMove); //Needs anim
    public static MoveData Foresight = new(
        "Foresight", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 40); //Needs effect and anim
    public static MoveData DestinyBond = new(
        "Destiny Bond", Type.Ghost,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 5); //Needs effect and anim
    public static MoveData PerishSong = new(
        "Perish Song", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Self + TargetID.Ally + TargetID.Spread + TargetID.Ranged, 5,
        MoveFlags.soundMove
        ); //Needs effect and anim
    public static MoveData IcyWind = new(
        "Icy Wind", Type.Ice,
        55, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 15); //Needs anim
    public static MoveData Detect = new(
        "Detect", Type.Fighting,
        0, 101, 4,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 5); //Needs effect and anim
    public static MoveData BoneRush = new(
        "Bone Rush", Type.Ground,
        25, 90, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData LockOn = new(
        "Lock On", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs effect and anim
    public static MoveData Outrage = new(
        "Outrage", Type.Dragon,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, TargetID.Self, 10,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Sandstorm = new(
        "Sandstorm", Type.Rock,
        0, 101, 0,
        MoveEffect.Weather, 100,
        false, TargetID.Field, 10); //Needs anim
    public static MoveData GigaDrain = new(
        "Giga Drain", Type.Grass,
        75, 100, 0,
        MoveEffect.Absorb50, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Endure = new(
        "Endure", Type.Normal,
        0, 101, 4,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 10); //Needs effect and anim
    public static MoveData Charm = new(
        "Charm", Type.Fairy,
        0, 100, 0,
        MoveEffect.AttackDown2, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Rollout = new(
        "Rollout", Type.Rock,
        30, 90, 0,
        MoveEffect.Rollout, 100,
        true, TargetID.Opponent + TargetID.Ally, 20,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData FalseSwipe = new(
        "False Swipe", Type.Normal,
        40, 100, 0,
        MoveEffect.FalseSwipe, 0,
        true, TargetID.Opponent + TargetID.Ally, 40); //Needs anim
    public static MoveData Swagger = new(
        "Swagger", Type.Normal,
        0, 85, 0,
        MoveEffect.Swagger, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData MilkDrink = new(
        "Milk Drink", Type.Normal,
        0, 101, 0,
        MoveEffect.Heal50, 100,
        false, TargetID.Self, 10); //Needs anim
    public static MoveData Spark = new(
        "Spark", Type.Electric,
        65, 100, 0,
        MoveEffect.Paralyze, 30,
        true, TargetID.Opponent + TargetID.Ally, 20); //Need anim
    public static MoveData FuryCutter = new(
        "Fury Cutter", Type.Bug,
        40, 95, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData SteelWing = new(
        "Steel Wing", Type.Steel,
        70, 90, 0,
        MoveEffect.DefenseUp1, 10,
        true, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData MeanLook = new(
        "Mean Look", Type.Normal,
        0, 101, 0,
        MoveEffect.Trap, 100,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Attract = new(
        "Attract", Type.Normal,
        0, 100, 0,
        MoveEffect.Attract, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData SleepTalk = new(
        "Sleep Talk", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 10); //Needs effect and anim
    public static MoveData HealBell = new(
        "Heal Bell", Type.Normal,
        0, 101, 0,
        MoveEffect.HealBell, 100,
        false, TargetID.Field, 5); //Needs anim
    public static MoveData Return = new(
        "Return", Type.Normal,
        1, 100, 0,
        MoveEffect.Return, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Present = new(
        "Present", Type.Normal,
        0, 90, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData Frustration = new(
        "Frustration", Type.Normal,
        0, 100, 0,
        MoveEffect.Frustration, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Safeguard = new(
        "Safeguard", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Field, 25); //Needs effect and anim
    public static MoveData PainSplit = new(
        "Pain Split", Type.Normal,
        0, 101, 0,
        MoveEffect.PainSplit, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData SacredFire = new(
        "Sacred Fire", Type.Fire,
        100, 95, 0,
        MoveEffect.Burn, 50,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Magnitude = new(
        "Magnitude", Type.Ground,
        0, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs effect and anim
    public static MoveData DynamicPunch = new(
        "Dynamic Punch", Type.Fighting,
        100, 50, 0,
        MoveEffect.Confuse, 100,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Megahorn = new(
        "Megahorn", Type.Bug,
        120, 85, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData DragonBreath = new(
        "Dragon Breath", Type.Dragon,
        60, 100, 0,
        MoveEffect.Paralyze, 30,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData BatonPass = new(
        "Baton Pass", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 40); //Needs effect and anim
    public static MoveData Encore = new(
        "Encore", Type.Normal,
        0, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs effect and anim
    public static MoveData Pursuit = new(
        "Pursuit", Type.Dark,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData RapidSpin = new(
        "Rapid Spin", Type.Normal,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 40); //Needs effect and anim
    public static MoveData SweetScent = new(
        "Sweet Scent", Type.Normal,
        0, 100, 0,
        MoveEffect.EvasionDown2, 100,
        false, TargetID.Opponent + TargetID.Spread, 20); //Needs anim
    public static MoveData IronTail = new(
        "Iron Tail", Type.Steel,
        100, 75, 0,
        MoveEffect.DefenseDown1, 30,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData MetalClaw = new(
        "Metal Claw", Type.Steel,
        50, 95, 0,
        MoveEffect.AttackUp1, 10,
        true, TargetID.Opponent + TargetID.Ally, 35,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData VitalThrow = new(
        "Vital Throw", Type.Fighting,
        70, 101, -1,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData MorningSun = new(
        "Morning Sun", Type.Normal,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, TargetID.Self, 5); //Needs anim
    public static MoveData Synthesis = new(
        "Synthesis", Type.Grass,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, TargetID.Self, 5); //Needs anim
    public static MoveData Moonlight = new(
        "Moonlight", Type.Fairy,
        0, 101, 0,
        MoveEffect.HealWeather, 100,
        false, TargetID.Self, 5); //Needs anim
    public static MoveData HiddenPower = new(
        "Hidden Power", Type.Normal,
        60, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData CrossChop = new(
        "Cross Chop", Type.Fighting,
        100, 80, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.highCrit); //Needs anim
    public static MoveData Twister = new(
        "Twister", Type.Dragon,
        40, 100, 0,
        MoveEffect.Flinch, 20,
        false, TargetID.Opponent + TargetID.Spread, 20,
        MoveFlags.hitFlyingMon); //Needs anim
    public static MoveData RainDance = new(
        "Rain Dance", Type.Water,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, TargetID.Field, 5); //Needs anim
    public static MoveData SunnyDay = new(
        "Sunny Day", Type.Fire,
        0, 101, 0,
        MoveEffect.Weather, 0,
        false, TargetID.Field, 5); //Needs anim
    public static MoveData Crunch = new(
        "Crunch", Type.Dark,
        80, 100, 0,
        MoveEffect.DefenseDown1, 20,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData MirrorCoat = new(
        "Mirror Coat", Type.Psychic,
        0, 100, -5,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 20); //Needs effect and anim
    public static MoveData PsychUp = new(
        "Psych Up", Type.Normal,
        0, 101, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData ExtremeSpeed = new(
        "Extreme Speed", Type.Normal,
        80, 100, 2,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData AncientPower = new(
        "Ancient Power", Type.Rock,
        60, 100, 0,
        MoveEffect.AllUp1, 10,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData ShadowBall = new(
        "Shadow Ball", Type.Ghost,
        80, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.bulletMove); //Needs anim
    public static MoveData FutureSight = new(
        "Future Sight", Type.Psychic,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData RockSmash = new(
        "Rock Smash", Type.Fighting,
        40, 100, 0,
        MoveEffect.DefenseDown1, 50,
        true, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.makesContact); //Needs anim
    public static MoveData Whirlpool = new(
        "Whirlpool", Type.Water,
        35, 85, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData BeatUp = new(
        "Beat Up", Type.Dark,
        0, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim


    //Non-standard moves
    public static MoveData ConfusionHit = new(
        "a move it shouldn't be able to! (ConfusionHit) [Error 101]", Type.Typeless,
        40, 101, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Self, 0,
        MoveFlags.mimicBypass);
    public static MoveData Recharge = new(
        "a move it shouldn't be able to! (Recharge) [Error 101]", Type.Typeless,
        0, 0, 0,
        MoveEffect.None, 0,
        false, 0, 0,
        MoveFlags.mimicBypass);
    public static MoveData RazorWindAttack = new(
        "Razor Wind", Type.Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0,
        MoveFlags.mimicBypass); //Needs anim
    public static MoveData DigAttack = new(
        "Dig", Type.Ground,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0,
        MoveFlags.mimicBypass + MoveFlags.makesContact); //Needs anim
    public static MoveData FlyAttack = new(
        "Fly", Type.Flying,
        90, 95, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0,
        MoveFlags.mimicBypass + MoveFlags.makesContact); //Needs anim
    public static MoveData SolarBeamAttack = new(
        "Solar Beam", Type.Grass,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 0,
        MoveFlags.halfPowerInBadWeather + MoveFlags.mimicBypass); //Needs anim
    public static MoveData SkyAttackAttack = new(
        "Sky Attack", Type.Flying,
        140, 90, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 5,
        MoveFlags.highCrit + MoveFlags.mimicBypass);
    public static MoveData SkullBashAttack = new(
        "Skull Bash", Type.Normal,
        130, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData BideMiddle = new(
        "Bide", Type.Typeless,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, TargetID.None, 0,
        MoveFlags.mimicBypass); //Needs anim);
    public static MoveData BideAttack = new(
        "Bide", Type.Typeless,
        1, 100, 0,
        MoveEffect.BideHit, 0,
        false, TargetID.Opponent, 0,
        MoveFlags.mimicBypass + MoveFlags.makesContact); //Needs anim
    public static MoveData Struggle = new(
        "Struggle", Type.Typeless,
        50, 100, 0,
        MoveEffect.Recoil25Max, 100,
        true, TargetID.Opponent + TargetID.Ally, 0,
        MoveFlags.cannotMimic); //Meeds anim


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
    };
}
