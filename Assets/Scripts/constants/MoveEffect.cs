public enum MoveEffect
{
    //No added effect
    None,
    Hit,
    //Multi-hit moves
    MultiHit2,
    MultiHit2to5,
    //Status
    Burn,
    Paralyze,
    Poison,
    Toxic,
    Freeze,
    Sleep,
    Confuse,
    TriAttack,
    //Non-status status moves
    LeechSeed,
    Disable,
    //Stat changes
    AttackUp1,
    AttackUp2,
    DefenseUp1,
    DefenseUp2,
    SpDefUp2,
    SpeedUp2,
    EvasionUp1,
    EvasionUp2,
    CritRateUp2,
    AttackDown1,
    DefenseDown1,
    DefenseDown2,
    SpDefDown1,
    SpeedDown1,
    AccuracyDown1,
    Growth,
    Minimize,
    DefenseCurl,
    //Direct damage
    Direct20,
    DirectLevel,
    //Recoil
    Recoil33,
    Recoil25,
    Recoil25Max,
    Crash50,
    //Other added effects
    Flinch,
    Absorb50,
    PayDay,
    ForcedSwitch,
    //Special attack types
    ChargingAttack,
    RechargeAttack,
    ContinuousDamage,
    Thrash,
    Counter,
    SelfDestruct,
    DreamEater,
    OHKO,
    Psywave,
    SuperFang,
    //Field effects
    Mist,
    //Self-targeting effects
    Rest,
    Heal50,
    //Nonstandard effects
    Recharge,
}