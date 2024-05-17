using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate IEnumerator ObjectScript(Player p);
public delegate IEnumerator CharScript(Player p, LoadedChar c);

public static class ScriptUtils
{
    public static Dictionary<string, ObjectScript> ObjScripts = new()
    {
        {"NoScript", NoObjectScript }
    };
    public static Dictionary<string, CharScript> CharScripts = new()
    {
        {"NoScript", NoCharScript }
    };
    public static T GetRandom<T>(this List<T> list)
    {
        var random = new System.Random();
        return list[(int)(random.NextDouble() * list.Count)];
    }

    public static void Set<T>(ref T field, T toSet) => field = toSet;

    public static IEnumerator Wait(float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    public static IEnumerator DoAtEnd(this IEnumerator ienum, MovementHandler action)
    {
        yield return ienum;
        action();
    }

    public static IEnumerator Join(this IEnumerator first, IEnumerator second)
    {
        yield return first;
        yield return second;
    }

    public static IEnumerator Repeat(this IEnumerator ienum, byte times) //byte = failsafe: only accept positive numbers, and should never go above 255
    {
        for (int i = 0; i < times; i++)
        {
            yield return ienum;
        }
    }

    public static IEnumerator DoNothing()
    {
        yield break;
    }


    public static void HealAll(Player p)
    {
        foreach (Pokemon i in p.Party)
        {
            if (i.exists)
            {
                i.FullHeal();
            }
        }
    }

    public static void RestoreAllPP(Player p)
    {
        foreach (Pokemon i in p.Party)
        {
            if (i.exists)
            {
                i.pp1 = i.maxPp1;
                i.pp2 = i.maxPp2;
                i.pp3 = i.maxPp3;
                i.pp4 = i.maxPp4;
            }
        }
    }

    public static IEnumerator NoObjectScript(Player p)
    {
        yield break;
    }

    public static IEnumerator NoCharScript(Player p, LoadedChar c)
    {
        yield break;
    }

    public static IEnumerator TrainerSeeSingle(Player p, LoadedChar c, TeamData team, List<string> beforeText, bool dynamaxEnabled = false, bool teraEnabled = false)
    {
        p.locked = true;
        if (p.state != PlayerState.Moving) p.state = PlayerState.Locked;
        while (c.moving && !c.paused) yield return null;
        c.breakPause = c.paused;
        c.FaceAndLock();
        switch (c.facing)
        {
            case Direction.N: p.StartCoroutine(p.playerGraphics.FaceSouth(p, 0.05F)); break;
            case Direction.S: p.StartCoroutine(p.playerGraphics.FaceNorth(p, 0.05F)); break;
            case Direction.W: p.StartCoroutine(p.playerGraphics.FaceEast(p, 0.05F)); break;
            case Direction.E: p.StartCoroutine(p.playerGraphics.FaceWest(p, 0.05F)); break;
        }
        yield return FieldAnim.ExclamBubble(c.charObject);
        int distance = System.Math.Abs(p.pos.x - c.pos.x + p.pos.y - c.pos.y);
        for (int i = 1; i < distance; i++) yield return c.WalkInDirection();
        yield return p.DoAnnouncements(beforeText);
        p.StartCoroutine(p.StartSingleTrainerBattle(c, team, dynamaxEnabled, teraEnabled));
        yield break;
    }

    public static IEnumerator MartScript(Player p, ItemID[] items)
    {
        const int Sell = 2;
        const int Buy = 1;
        List<(string, int)> menuChoices = new() { ("Cancel", 0), ("Sell", Sell), ("Buy", Buy) };
        p.locked = true;
        if (p.state != PlayerState.Moving) p.state = PlayerState.Locked;
        if (p.loadedChars.ContainsKey("martemployee"))
        {
            if (p.facing is Direction.N) p.StartCoroutine(p.loadedChars["martemployee"].chara.FaceSouth());
            else p.StartCoroutine(p.loadedChars["martemployee"].chara.FaceEast());
        }
        yield return p.announcer.AnnouncementUp();
        yield return p.announcer.Announce("Welcome!\nWhat do you need?", persist: true);
        DataStore<int> menuChoice = new();
        while (true)
        {
            yield return p.DoChoiceMenu(menuChoice, menuChoices, 0);
            if (menuChoice.Data == 0) break;
            if (menuChoice.Data == Buy)
            {
                yield return p.announcer.AnnouncementDown();
                yield return MartMenu.DoMartMenu(p, items);
            }
            if (menuChoice.Data == Sell)
            {
                yield return p.DoBagPrompt();
                if (p.bagResult != ItemID.None)
                    yield return MartQuantity.DoQuantityScreen(p, p.bagResult, true);
            }
            yield return p.announcer.AnnouncementUp();
            yield return p.announcer.Announce("Is there anything else we can do for you?", persist: true);
        }
        yield return p.announcer.AnnouncementDown();
        p.locked = false;
        p.state = PlayerState.Free;
    }

    public static readonly List<(string, int)> binaryChoice = new()
        {
            ("No", 0),
            ("Yes", 1),
        };
}