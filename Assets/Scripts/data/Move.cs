public static class Move
{
    public const byte AlwaysHit = 101;
    public static MoveData None = new MoveData("Error 10", Type.Normal, 0,
            0, 0, 0, 0, false, 0, 0);
    public static MoveData Pound = new MoveData(
        "Pound", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35); //Done
    public static MoveData KarateChop = new MoveData(
        "Karate Chop", Type.Fighting,
        50, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25, MoveFlags.highCrit); //Done
    public static MoveData DoubleSlap = new MoveData(
        "Double Slap", Type.Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Done
    public static MoveData CometPunch = new MoveData(
        "Comet Punch", Type.Normal,
        18, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData MegaPunch = new MoveData(
        "Mega Punch", Type.Normal,
        80, 85, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData PayDay = new MoveData(
        "Pay Day", Type.Normal,
        40, 100, 0,
        MoveEffect.PayDay, 101,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim and money implementation
    public static MoveData FirePunch = new MoveData(
        "Fire Punch", Type.Fire,
        75, 100, 0,
        MoveEffect.Burn, 10,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData IcePunch = new MoveData(
        "Ice Punch", Type.Ice,
        75, 100, 0,
        MoveEffect.Freeze, 10,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData ThunderPunch = new MoveData(
        "Thunder Punch", Type.Electric,
        75, 100, 0,
        MoveEffect.Paralyze, 10,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Scratch = new MoveData(
        "Scratch", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData ViceGrip = new MoveData(
        "Vice Grip", Type.Normal,
        55, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData Guillotine = new MoveData(
        "Guillotine", Type.Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData RazorWind = new MoveData(
        "Razor Wind", Type.Normal,
        80, 100, 0,
        MoveEffect.ChargingAttack, 0,
        false, TargetID.Opponent + TargetID.Spread, 10); //Needs anim
    public static MoveData SwordsDance = new MoveData(
        "Swords Dance", Type.Normal,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp2, 0,
        false, TargetID.Self, 20); //Needs anim
    public static MoveData Cut = new MoveData(
        "Cut", Type.Normal,
        50, 95, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData Gust = new MoveData(
        "Gust", Type.Flying,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 35); //Needs effect (hits mons in air) and anim
    public static MoveData WingAttack = new MoveData(
        "Wing Attack", Type.Flying,
        60, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData Whirlwind = new MoveData(
        "Whirlwind", Type.Normal,
        0, AlwaysHit, -6,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData Fly = new MoveData(
        "Fly", Type.Flying,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData Bind = new MoveData(
        "Bind", Type.Normal,
        15, 85, 0,
        MoveEffect.ContinuousDamage, 100,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Slam = new MoveData(
        "Slam", Type.Normal,
        80, 75, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData VineWhip = new MoveData(
        "Vine Whip", Type.Grass,
        45, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Stomp = new MoveData(
        "Stomp", Type.Normal,
        65, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData DoubleKick = new MoveData(
        "Double Kick", Type.Fighting,
        30, 100, 0,
        MoveEffect.MultiHit2, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData MegaKick = new MoveData(
        "Mega Kick", Type.Normal,
        120, 75, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData JumpKick = new MoveData(
        "Jump Kick", Type.Fighting,
        100, 20, 0,
        MoveEffect.Crash50, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData RollingKick = new MoveData(
        "Rolling Kick", Type.Fighting,
        60, 85, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData SandAttack = new MoveData(
        "Sand Attack", Type.Ground,
        0, 100, 0,
        MoveEffect.AccuracyDown1, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Headbutt = new MoveData(
        "Headbutt", Type.Normal,
        70, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs field effect and anim
    public static MoveData HornAttack = new MoveData(
        "Horn Attack", Type.Normal,
        65, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData FuryAttack = new MoveData(
        "Fury Attack", Type.Normal,
        15, 85, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData HornDrill = new MoveData(
        "Horn Drill", Type.Normal,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Tackle = new MoveData(
        "Tackle", Type.Normal,
        40, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData BodySlam = new MoveData(
        "Body Slam", Type.Normal,
        85, 100, 0,
        MoveEffect.Paralyze, 30,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Wrap = new MoveData(
        "Wrap", Type.Normal,
        15, 90, 0,
        MoveEffect.ContinuousDamage, 100,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData TakeDown = new MoveData(
        "Take Down", Type.Normal,
        90, 85, 0,
        MoveEffect.Recoil25, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Thrash = new MoveData(
        "Thrash", Type.Normal,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        true, TargetID.Self, 10); //Needs anim
    public static MoveData DoubleEdge = new MoveData(
        "Double Edge", Type.Normal,
        120, 100, 0,
        MoveEffect.Recoil33, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData TailWhip = new MoveData(
        "Tail Whip", Type.Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData PoisonSting = new MoveData(
        "Poison Sting", Type.Poison,
        15, 100, 0,
        MoveEffect.Poison, 30,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData Twineedle = new MoveData(
        "Twineedle", Type.Bug,
        25, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData PinMissile = new MoveData(
        "Pin Missile", Type.Bug,
        25, 95, 0,
        MoveEffect.MultiHit2to5, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Leer = new MoveData(
        "Leer", Type.Normal,
        0, 100, 0,
        MoveEffect.DefenseDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData Bite = new MoveData(
        "Bite", Type.Dark,
        60, 100, 0,
        MoveEffect.Flinch, 30,
        true, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Growl = new MoveData(
        "Growl", Type.Normal,
        0, 100, 0,
        MoveEffect.AttackDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 40);
    public static MoveData Roar = new MoveData(
        "Roar", Type.Normal,
        0, AlwaysHit, -6,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData Sing = new MoveData(
        "Sing", Type.Normal,
        0, 55, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Supersonic = new MoveData(
        "Supersonic", Type.Normal,
        0, 55, 0,
        MoveEffect.Confuse, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData SonicBoom = new MoveData(
        "Sonic Boom", Type.Normal,
        1, 90, 0,
        MoveEffect.Direct20, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Disable = new MoveData(
        "Disable", Type.Normal,
        0, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData Acid = new MoveData(
        "Acid", Type.Poison,
        40, 100, 0,
        MoveEffect.SpDefDown1, 10,
        false, TargetID.Opponent + TargetID.Spread, 30); //Needs anim
    public static MoveData Ember = new MoveData(
        "Ember", Type.Fire,
        40, 100, 0,
        MoveEffect.Burn, 10,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Flamethrower = new MoveData(
        "Flamethrower", Type.Fire,
        90, 100, 0,
        MoveEffect.Burn, 10,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Mist = new MoveData(
        "Mist", Type.Ice,
        0, AlwaysHit, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Field, 30); //Needs effect and anim
    public static MoveData WaterGun = new MoveData(
        "Water Gun", Type.Water,
        40, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData HydroPump = new MoveData(
        "Hydro Pump", Type.Water,
        110, 80, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Surf = new MoveData(
        "Surf", Type.Water,
        90, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally + TargetID.Spread, 15); //Needs anim
    public static MoveData IceBeam = new MoveData(
        "Ice Beam", Type.Ice,
        90, 100, 0,
        MoveEffect.Freeze, 10,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Blizzard = new MoveData(
        "Blizzard", Type.Ice,
        110, 70, 0,
        MoveEffect.Freeze, 10,
        false, TargetID.Opponent + TargetID.Spread, 5); //Needs anim
    public static MoveData Psybeam = new MoveData(
        "Psybeam", Type.Psychic,
        65, 100, 0,
        MoveEffect.Confuse, 10,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData BubbleBeam = new MoveData(
        "Bubble Beam", Type.Water,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData AuroraBeam = new MoveData(
        "Aurora Beam", Type.Ice,
        65, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData HyperBeam = new MoveData(
        "Hyper Beam", Type.Normal,
        150, 90, 0,
        MoveEffect.Recharge, 0,
        false, TargetID.Opponent + TargetID.Ally, 5); //Needs effect and anim
    public static MoveData Peck = new MoveData(
        "Peck", Type.Flying,
        35, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData DrillPeck = new MoveData(
        "Drill Peck", Type.Flying,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Submission = new MoveData(
        "Submission", Type.Fighting,
        80, 80, 0,
        MoveEffect.Recoil25, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData LowKick = new MoveData(
        "Low Kick", Type.Fighting,
        0, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData Counter = new MoveData(
        "Counter", Type.Fighting,
        0, 100, -5,
        MoveEffect.Hit, 0,
        true, TargetID.Self, 20); //Needs effect and anim
    public static MoveData SeismicToss = new MoveData(
        "Seismic Toss", Type.Fighting,
        0, 100, 0,
        MoveEffect.DirectLevel, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Strength = new MoveData(
        "Strength", Type.Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Absorb = new MoveData(
        "Absorb", Type.Grass,
        20, 100, 0,
        MoveEffect.Absorb50, 100,
        false, TargetID.Opponent + TargetID.Ally, 25,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData MegaDrain = new MoveData(
        "Mega Drain", Type.Grass,
        40, 100, 0,
        MoveEffect.Absorb50, 100,
        false, TargetID.Opponent + TargetID.Ally, 15,
        MoveFlags.effectOnSelfOnly); //Needs anim
    public static MoveData LeechSeed = new MoveData(
        "Leech Seed", Type.Grass,
        0, 90, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData Growth = new MoveData(
        "Growth", Type.Normal,
        0, AlwaysHit, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 20); //Needs effect and anim
    public static MoveData RazorLeaf = new MoveData(
        "Razor Leaf", Type.Grass,
        55, 95, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Spread, 25, MoveFlags.highCrit); //Needs anim
    public static MoveData SolarBeam = new MoveData(
        "Solar Beam", Type.Grass,
        120, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect and anim
    public static MoveData PoisonPowder = new MoveData(
        "Poison Powder", Type.Poison,
        0, 75, 0,
        MoveEffect.Poison, 100,
        false, TargetID.Opponent + TargetID.Ally, 35); //Needs anim
    public static MoveData StunSpore = new MoveData(
        "Stun Spore", Type.Grass,
        0, 75, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData SleepPowder = new MoveData(
        "Sleep Powder", Type.Grass,
        0, 75, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData PetalDance = new MoveData(
        "Petal Dance", Type.Grass,
        120, 100, 0,
        MoveEffect.Thrash, 0,
        false, TargetID.Self, 10); //Needs effect and anim
    public static MoveData StringShot = new MoveData(
        "String Shot", Type.Bug,
        0, 95, 0,
        MoveEffect.SpeedDown1, 100,
        false, TargetID.Opponent + TargetID.Spread, 40); //Needs anim
    public static MoveData DragonRage = new MoveData(
        "Dragon Rage", Type.Dragon,
        1, 100, 0,
        MoveEffect.Direct20, 0,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData FireSpin = new MoveData(
        "Fire Spin", Type.Fire,
        35, 85, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs effect and anim
    public static MoveData ThunderShock = new MoveData(
        "Thunder Shock", Type.Electric,
        40, 100, 0,
        MoveEffect.Paralyze, 10,
        false, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData Thunderbolt = new MoveData(
        "Thunderbolt", Type.Electric,
        90, 100, 0,
        MoveEffect.Paralyze, 10,
        false, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData ThunderWave = new MoveData(
        "Thunder Wave", Type.Electric,
        0, 90, 0,
        MoveEffect.Paralyze, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Thunder = new MoveData(
        "Thunder", Type.Electric,
        110, 70, 0,
        MoveEffect.Paralyze, 30,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs effect (weather) and anim
    public static MoveData RockThrow = new MoveData(
        "Rock Throw", Type.Rock,
        50, 90, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 15); //Needs anim
    public static MoveData Earthquake = new MoveData(
        "Earthquake", Type.Ground,
        100, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 10, MoveFlags.hitDiggingMon); //Needs anim
    public static MoveData Fissure = new MoveData(
        "Fissure", Type.Ground,
        1, 30, 0,
        MoveEffect.OHKO, 0,
        true, TargetID.Opponent + TargetID.Ally, 5); //Needs anim
    public static MoveData Dig = new MoveData(
        "Dig", Type.Ground,
        0, 100, 0,
        MoveEffect.ChargingAttack, 0,
        true, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Toxic = new MoveData(
        "Toxic", Type.Poison,
        0, 90, 0,
        MoveEffect.Toxic, 100,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Confusion = new MoveData(
        "Confusion", Type.Psychic,
        50, 100, 0,
        MoveEffect.Confuse, 10,
        false, TargetID.Opponent + TargetID.Ally, 25); //Needs anim
    public static MoveData Psychic = new MoveData(
        "Psychic", Type.Psychic,
        90, 100, 0,
        MoveEffect.SpDefDown1, 20,
        false, TargetID.Opponent + TargetID.Ally, 10); //Needs anim
    public static MoveData Hypnosis = new MoveData(
        "Hypnosis", Type.Psychic,
        0, 60, 0,
        MoveEffect.Sleep, 100,
        false, TargetID.Opponent + TargetID.Ally, 20); //Needs anim
    public static MoveData Meditate = new MoveData(
        "Meditate", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.AttackUp1, 0,
        false, TargetID.Self, 40); //Needs anim
    public static MoveData Agility = new MoveData(
        "Agility", Type.Psychic,
        0, AlwaysHit, 0,
        MoveEffect.SpeedUp2, 100,
        false, TargetID.Self, 30); //Needs anim
    public static MoveData QuickAttack = new MoveData(
        "Quick Attack", Type.Normal,
        40, 100, 1,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 30); //Needs anim
    public static MoveData Rage = new MoveData(
        "Rage", Type.Normal,
        20, 100, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Opponent + TargetID.Ally, 20); //Needs effect and anim
    public static MoveData Teleport = new MoveData(
        "Teleport", Type.Psychic,
        0, AlwaysHit, -6,
        MoveEffect.Hit, 0,
        false, TargetID.Self, 20); //Needs effect and anim

    //Non-standard moves
    public static MoveData ConfusionHit = new MoveData("Null", Type.Typeless,
        40, 101, 0,
        MoveEffect.Hit, 0,
        true, TargetID.Self, 0);
    public static MoveData Recharge = new MoveData(
        "Null", Type.Typeless,
        0, 0, 0,
        MoveEffect.Recharge, 0,
        false, 0, 0);
    public static MoveData RazorWindAttack = new MoveData(
        "Razor Wind", Type.Normal,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0); //Needs anim
    public static MoveData DigAttack = new MoveData(
        "Dig", Type.Ground,
        80, 100, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0); //Needs anim
    public static MoveData FlyAttack = new MoveData(
        "Fly", Type.Flying,
        90, 95, 0,
        MoveEffect.Hit, 0,
        false, TargetID.Opponent + TargetID.Spread, 0); //Needs anim

    public static MoveData[] MoveTable = new MoveData[MoveID.Count] {
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
        //Nonstandard moves
        ConfusionHit,
        Recharge,
        RazorWindAttack,
        DigAttack,
        FlyAttack,
    };
}
