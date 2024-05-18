using System.Collections;
using UnityEngine;
public class XPController : MonoBehaviour
{
    public Battle battle;
    public SpriteRenderer spriteRenderer;

    public Color defaultColor;
    public Color flashColor;

    private bool doAlignment = true;

    public void AlignBar()
    {
        if (battle.PokemonOnField[3].exists)
            gameObject.transform.localScale = new(Mathf.Min(2, 2 * battle.PokemonOnField[3].pokemon.LevelProgress), 0.0625F, 1);
    }

    public IEnumerator GainXP(int XP)
    {
        doAlignment = false;
        Pokemon mon = battle.PokemonOnField[3].pokemon;
        if (mon.level >= PokemonConst.maxLevel) yield break;
        int baseXP = mon.xp;
        float baseTime = Time.time;
        float duration = Mathf.Pow(XP, 0.33F) * 0.2F;
        float endTime = baseTime + duration;
        while (Time.time <= endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            mon.xp = (int)(baseXP + progress * XP);
            AlignBar();
            if (mon.ShouldLevelUp())
            {
                float currentTime = Time.time;
                yield return AnnounceLevelUp();
                baseTime += Time.time - currentTime;
                endTime += Time.time - currentTime;
            }
            yield return null;
        }
        mon.xp = baseXP + XP;
        AlignBar();
        if (mon.ShouldLevelUp())
        {
            yield return AnnounceLevelUp();
            AlignBar();
        }
        doAlignment = true;
    }

    public IEnumerator AnnounceLevelUp()
    {
        Pokemon mon = battle.PokemonOnField[3].pokemon;
        mon.LevelUp();
        yield return AnimUtils.ColorChange(spriteRenderer, defaultColor, flashColor, 0.3F);
        yield return AnimUtils.ColorChange(spriteRenderer, flashColor, defaultColor, 0.3F);
        yield return battle.Announce(battle.MonNameWithPrefix(3, true) + " grew to level "
            + mon.level + "!");
        yield return mon.CheckLevelUpMoves(battle.Announce, battle.player, battle.announcer.transform, 1.2F, new(-500, 100), false);
        AlignBar();
    }

    public void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (doAlignment)
        {
            AlignBar();
            spriteRenderer.color = defaultColor;
        }
    }
}