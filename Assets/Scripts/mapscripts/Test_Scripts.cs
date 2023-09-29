using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Test_Scripts
{
    public static CharScripts[] charScripts = new CharScripts[]
    {
        May_CharScripts
    };

    public static Dictionary<string, ObjectScript> objectScripts = new()
    {
        {"Announcement", Trigger_Announcement },
        {"MayLoad", Trigger_MayLoad },
        {"SignpostTest", p => p.DoAnnouncements(new(){"Signpost","Does","This"}) },
    };

    public static MapScripts MapScripts = new();

    public static IEnumerator Trigger_Announcement(Player p)
        => p.DoAnnouncements(new() { "Testing 1", "Testing 2" });

    public static IEnumerator Trigger_MayLoad(Player p)
    {
        TestMapdata.charData[0].Load(p, p.currentMap);
        yield break;
    }

    public static CharScripts May_CharScripts => new()
    {
        OnInteract = May_OnInteract,
        SeeCheck = p => !TrainerFlag.MayTest.Get(p),
        OnSee = May_OnSee,
        OnWin = May_OnWin,
        GetMovement = May_GetMovement,
    };

    public static IEnumerator May_OnInteract(Player p, LoadedChar c)
    {
        c.FaceAndLock();
        if (TrainerFlag.MayTest.Get(p))
        {
            yield return p.DoAnnouncements(new()
            { "I shouldn't be fighting with baby Pokémon anyway..."});
        }
        else
        {
            yield return p.DoAnnouncements(new()
            { "Hello!"});
        }
        c.free = true;
    }
    public static IEnumerator May_OnSee(Player p, LoadedChar c)
    {
        Debug.Log(TrainerFlag.MayTest.Get(p));
        if (!TrainerFlag.MayTest.Get(p))
        {
            yield return ScriptUtils.TrainerSeeSingle(
                p, c, Team.mayTestTeam, new() { "Boo!" });
        }
    }
    public static IEnumerator May_OnWin(Player p, LoadedChar c)
    {
        yield return p.DoAnnouncements(new() { "Somehow you won..." });
        p.state = PlayerState.Free;
        TrainerFlag.MayTest.Set(p);
        c.doMove = false;
        c.free = true;
    }
    public static void May_GetMovement(LoadedChar c)
    {
        c.Actions.Enqueue(c.TryWalkNorth);
        c.Actions.Enqueue(() => c.Pause(1.0F));
    }
}