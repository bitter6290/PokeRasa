public enum FieldEffect : ushort
{
    None,
    // Party menu effects go under here
    Heal,
    HealStatus,
    FullRestore,
    TM,
    Evolution,
    AbilityCapsule,
    AbilityPatch,
    Mint,
    Feather,
    Vitamin,
    PPUp,
    PPMax,
    // EV-reducing berries
    HPEVDown10,
    AttackEVDown10,
    DefenseEVDown10,
    SpAtkEVDown10,
    SpDefEVDown10,
    SpeedEVDown10,


    PartyMenuEffects = Heal - 1
}