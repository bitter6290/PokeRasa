using System.Collections;
using System.Collections.Generic;

public delegate void ObjectScript(Player p);
public delegate void CharScript(Player p, LoadedChar c);

public static class ScriptUtils
{
    public static IEnumerator DoNothing(Player p)
    {
        yield break;
    }

    public static IEnumerator TrainerSeeSingle(Player p, LoadedChar c, TeamData team, List<string> beforeText)
    {
        p.state = PlayerState.Locked;
        c.free = false;
        switch(c.facing)
        {
            case Direction.N: p.StartCoroutine(p.playerGraphics.FaceSouth(p, 0.05F)); break;
            case Direction.S: p.StartCoroutine(p.playerGraphics.FaceNorth(p, 0.05F)); break;
            case Direction.W: p.StartCoroutine(p.playerGraphics.FaceEast(p, 0.05F)); break;
            case Direction.E: p.StartCoroutine(p.playerGraphics.FaceWest(p, 0.05F)); break;
        }
        yield return FieldAnim.ExclamBubble(c.charObject);
        int distance = System.Math.Abs((p.pos.x - c.pos.x) + (p.pos.y - c.pos.y));
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
}