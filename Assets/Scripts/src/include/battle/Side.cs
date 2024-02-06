using System.Collections.Generic;

public partial class Battle {
    private class Side
    {
        public bool lightScreen = false;
        public int lightScreenTurns = 0;
        public bool reflect = false;
        public int reflectTurns = 0;
        public bool auroraVeil = false;
        public int auroraVeilTurns = 0;
        public bool mist = false;
        public int mistTurns = 0;
        public int spikes = 0;
        public bool safeguard = false;
        public int safeguardTurns = 0;
        public bool tailwind = false;
        public int tailwindTurns = 0;
        public bool luckyChant = false;
        public int luckyChantTurns = 0;
        public int toxicSpikes = 0;
        public bool stealthRock = false;
        public bool steelsurge = false;
        public bool stickyWeb = false;
        public bool wideGuard = false;
        public bool quickGuard = false;
        public bool matBlock = false;
        public bool craftyShield = false;
        public bool allySwitchUsed = false;

        public GMaxContinuousDamage gMaxContinuousDamage = None;
        public int gMaxDamageTurns = 0;

        //Pledge effects
        public bool rainbow = false;
        public int rainbowTurns = 0;
        public bool swamp = false;
        public int swampTurns = 0;
        public bool burningField = false;
        public int burningFieldTurns = 0;
        public Pledge currentPledge = Pledge.None;

        public bool retaliateNext = false;
        public bool retaliateNow = false;

        public readonly Battle battle;
        public bool whichSide;

        public List<Battle.BattlePokemon> Mons =>
            whichSide ? new()
            {
            battle.PokemonOnField[3],
            battle.PokemonOnField[4],
            battle.PokemonOnField[5],
            }
            : new()
            {
            battle.PokemonOnField[0],
            battle.PokemonOnField[1],
            battle.PokemonOnField[2],
            };

        public Side(bool side, Battle battle)
        {
            whichSide = side;
            this.battle = battle;
        }
    }
}