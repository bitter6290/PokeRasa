using System.Collections;

public static class TestMapdata
{
    public static WildDataset TestGrass = new()
    {
        encounterPercent = 5,
        wildMons = new WildMon[]
        {
            new(SpeciesID.Weedle, 12, 3, 5),
            new(SpeciesID.Caterpie, 12, 3, 5),
            new(SpeciesID.Pikachu, 1, 4, 6)
        }
    };

    public static WildDataset[] grassTables = new WildDataset[10]
    {
        TestGrass,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
        WildDataset.Empty,
    };

    public static TileTrigger[] triggers =
    {
        new()
        {
            map = MapID.Test,
            x = 15,
            y = 2,
            index = 1,
            script = p => p.DoAnnouncements(new(){"Testing 1","Testing 2"}),
        }
    };

    public static IEnumerator OnInteract(Player p, byte index)
    {
        switch(index)
        {
            case 1: yield return null; yield break;
            default: yield break;
        }
    }
    public static IEnumerator OnSight(Player p,byte index)
    {
        switch(index)
        {
            case 1: yield return null; yield break;
            default: yield break;
        }
    }

    public static IEnumerator TestTrigger(Player p)
    {
        yield return p.DoAnnouncements(new() { "Testing" });
        yield break;
    }
}