public struct PokedexData
{
    public int number;
    public string name;
    public string entry;
    public string category;
    //Todo: add form tables for regional/mega/other forms
    public int weight; //in g
    public int height; //in cm
    public SpeciesID[] forms;

    public bool ShowEntry(Player p)
    {
        foreach (SpeciesID id in forms)
        {
            if (p.seenFlags[(int)id]) return true;
        }
        return false;
    }
    public bool ShowCaught(Player p)
    {
        foreach (SpeciesID id in forms)
        {
            if (p.caughtFlags[(int)id]) return true;
        }
        return false;
    }
    public SpeciesID GetFirstSpecies(Player p)
    {
        foreach (SpeciesID id in forms)
        {
            if (p.seenFlags[(int)id]) return id;
        }
        return SpeciesID.Missingno;
    }
}