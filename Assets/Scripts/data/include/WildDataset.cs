public struct WildDataset
{
    public readonly WildMon[] wildMons;
    public readonly int encounterPercent;
    public int TotalFreq
    {
        get
        {
            int total = 0;
            foreach (WildMon i in wildMons)
            {
                total += i.freq;
            }
            return total;
        }
    }
    public Pokemon GetWildMon()
    {
        var random = new System.Random();
        int i = random.Next() % TotalFreq;
        SpeciesID species = SpeciesID.Missingno;
        int level = 10;
        foreach (WildMon mon in wildMons)
        {
            i -= mon.freq;
            if (i < 0)
            {
                species = mon.species;
                level = (mon.minLevel + (random.Next() % (mon.maxLevel - mon.minLevel + 1)));
                break;
            }
        }
        return Pokemon.WildPokemon(species, level);
    }
}