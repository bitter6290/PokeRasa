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

    public static IEnumerator Wait(float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    public static IEnumerator DoNothing()
    {
        yield break;
    }

    public static IEnumerator NoObjectScript(Player p)
    {
        yield break;
    }

    public static IEnumerator NoCharScript(Player p, LoadedChar c)
    {
        yield break;
    }

    public static IEnumerator TrainerSeeSingle(Player p, LoadedChar c, TeamData team, List<string> beforeText)
    {
        p.locked = true;
        if (p.state != PlayerState.Moving) p.state = PlayerState.Locked;
        c.free = false;
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
        p.StartCoroutine(p.StartSingleTrainerBattle(c, team));
        yield break;
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

    public static void HealAll(Player p)
    {
        foreach (Pokemon i in p.Party)
        {
            if (i.exists)
            {
                i.fainted = false;
                i.status = Status.None;
                i.HP = i.hpMax;
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
}