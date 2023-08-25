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
    //Stat changes
    AttackUp1,
    AttackUp2,
    DefenseUp1,
    SpeedUp2,
    EvasionUp1,
    AttackDown1,
    DefenseDown1,
    DefenseDown2,
    SpDefDown1,
    SpeedDown1,
    AccuracyDown1,
    Growth,
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
    //Special attack types
    ChargingAttack,
    RechargeAttack,
    ContinuousDamage,
    Thrash,
    Counter,
    OHKO,
    //Self-targeting effects
    Heal50,
    //Nonstandard effects
    Recharge,
}