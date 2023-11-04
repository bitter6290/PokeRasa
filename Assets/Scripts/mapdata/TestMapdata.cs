using System.Collections;
using static ScriptUtils;
using static Test_Scripts;

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
    };

    public static TileTrigger[] triggers =
    {
        new()
        {
            pos = new(15,2),
           // script = Trigger_Announcement,
        },
        new()
        {
            pos = new(17,2),
            //script = Trigger_MayLoad
        } //index 1
    };

    public static TileTrigger[] signposts =
    {
        new()
        {
            pos = new(16,2),
            //script = p => p.DoAnnouncements(new(){"Signpost","Does","This"}),
        } //index 0
    };

    public static IEnumerator TestTrigger(Player p)
    {
        yield return p.DoAnnouncements(new() { "Testing" });
        yield break;
    }
}