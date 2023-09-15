public enum BerryEffect //In-battle effects only
{
    None,
    //Status healing berries
    CureParalysis, //Cheri
    CureSleep, //Chesto
    CurePoison, //Pecha
    CureBurn, //Rawst
    CureFreeze, //Aspear
    CureConfusion, //Persim
    CureStatus, //Lum

    //HP restoring berries
    At50Restore10HP, //Oran
    At50Restore25, //Sitrus
    At25Restore33Spicy, //Figy
    At25Restore33Dry, //Wiki
    At25Restore33Sweet, //Mago
    At25Restore33Bitter, //Aguav
    At25Restore33Sour, //Iapapa
    OnSERestore25, //Enigma

    //Damage reducing berries
    ReduceFireDamage, //Occa
    ReduceWaterDamage, //Passho
    ReduceElectricDamage, //Wacan
    ReduceGrassDamage, //Rindo
    ReduceIceDamage, //Yache
    ReduceFightingDamage, //Chople
    ReducePoisonDamage, //Kebia
    ReduceGroundDamage, //Shuca
    ReduceFlyingDamage, //Coba
    ReducePsychicDamage, //Payapa
    ReduceBugDamage, //Tanga
    ReduceRockDamage, //Charti
    ReduceGhostDamage, //Kasib
    ReduceDragonDamage, //Haban
    ReduceDarkDamage, //Colbur
    ReduceSteelDamage, //Babiri
    ReduceFairyDamage, //Roseli
    ReduceNormalDamage, //Chilan

    //Stat raising berries
    At25RaiseAttack, //Liechi
    At25RaiseDefense, //Ganlon
    At25RaiseSpeed, //Salac
    At25RaiseSpAtk, //Petaya
    At25RaiseSpDef, //Apicot
    At25RaiseCrit, //Lansat
    At25RaiseRandom2, //Starf
    OnPhysRaiseDefense, //Kee
    OnSpecRaiseSpDef, //Maranga

    //Other pinch berries
    At25RaiseAccuracy20, //Micle
    At25GetPriority, //Custap

    //Other berries
    At0PPRestore10PP, //Leppa
    OnPhysHurt125, //Jaboca
    OnSpecHurt125, //Rowap

    //Fake effect
    NoneApply,
}