using System.Collections;
using static ScriptUtils;

public static class TestMapdata
{
    const MapID thisMap = MapID.Test;

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
            pos = new(3,2),
            hasCollision = true,
            hasSeeScript = true,
            loadedByDefault = true,
            sightRadius = 3,
            graphics = CharacterGraphicsStructs.mayWalk,
            GetMovement = t =>
            {
                t.Actions.Enqueue(t.TryWalkNorth);
                t.Actions.Enqueue(() => t.Pause(1.0F));
            },
            OnInteract = (p, c) =>
            {
                c.FaceAndLock();
                p.StartCoroutine(TrainerFlag.MayTest.Get(p) ?
                p.DoAnnouncements(new(){"I shouldn't be fighting with baby Pokémon anyway..."})
                    .DoAtEnd(() => c.free = true) :
                p.DoAnnouncements(new(){"Hello!"})
                    .DoAtEnd(() => c.free = true)
                );
            },
            OnSee = (p, c) =>
            {
                if (TrainerFlag.MayTest.Get(p))
                    p.StartCoroutine(
                        TrainerSeeSingle(p, c,
                        Team.mayTestTeam, new(){"Boo!"}));
            },
            OnWin = (p,c) => p.StartCoroutine(p.DoAnnouncements(new(){"You win!","Good job!"}).
                DoAtEnd( () =>
            {
                p.state = PlayerState.Free;
                TrainerFlag.MayTest.Set(p);
                c.doMove = false;
                c.free = true;
            }
            )),
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