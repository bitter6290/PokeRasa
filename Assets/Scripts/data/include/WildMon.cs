[System.Serializable]
public struct WildMon
{
    public SpeciesID species;
    public int freq;
    public int minLevel;
    public int maxLevel;
    public WildMon(SpeciesID species, int freq, int minLevel, int maxLevel)
    {
        this.species = species;
        this.freq = freq;
        this.minLevel = minLevel;
        this.maxLevel = maxLevel;
    }
}