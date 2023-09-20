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

    public static CharData[] charData =
    {
        new HumanoidCharData
        {
            index = 0,
            mapID = MapID.Test,
            pos = new(15,5),
            hasCollision = true,
            graphics = CharacterGraphicsStructs.brendanWalk,
            OnInteract = p => p.StartCoroutine(p.DoAnnouncements(new(){"Hello!"})),
        }
    };

    public static TileTrigger[] triggers =
    {
        new()
        {
            pos = new(15,2),
            script = p => p.StartCoroutine(p.DoAnnouncements(new(){"Testing 1","Testing 2"})),
        }, //index 0
        new()
        {
            pos = new(17,2),
            script = p => charData[0].Load(p),
        } //index 1
    };

    public static TileTrigger[] signposts =
    {
        new()
        {
            pos = new(16,2),
            script = p => p.DoAnnouncements(new(){"Signpost","Does","This"}),
        } //index 0
    };

    public static IEnumerator TestTrigger(Player p)
    {
        yield return p.DoAnnouncements(new() { "Testing" });
        yield break;
    }
}