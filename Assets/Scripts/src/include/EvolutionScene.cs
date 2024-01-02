using System.Collections;
using TMPro;
using UnityEngine;

public class EvolutionScene : MonoBehaviour
{
    public Pokemon mon;
    public SpeciesID originalSpecies;
    public SpeciesID destinationSpecies;
    public Transform monTransform;
    public SpriteRenderer monSprite;
    public SpriteRenderer overlay;
    public SpriteMask mask;

    public TextMeshProUGUI text;

    public AudioSource audioSource;

    private Sprite originalSprite;
    private Sprite destinationSprite;

    private static float[] animDurations = new float[]
    {
        0.5f,
        0.45f,
        0.41f,
        0.375f,
        0.338f,
        0.3f,
        0.282f,
        0.275f,
        0.27f,
        0.267f,
        0.265f,
        0.26f,
        0.25f,
        0.24f,
        0.23f,
        0.22f,
        0.21f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.2f,
        0.4f
    };
    private bool newSprite;

    public IEnumerator PrepareScene(Pokemon mon)
    {
        this.mon = mon;
        overlay.color = new(1, 1, 1, 0);
        originalSpecies = mon.species;
        destinationSpecies = mon.destinationSpecies;
        yield return originalSprite = originalSpecies.Data().FrontSprite1;
        yield return destinationSprite = destinationSpecies.Data().FrontSprite1;
        monSprite.sprite = originalSprite;
        mask.sprite = originalSprite;
    }

    public IEnumerator Announce(string announcement)
    {
        float targetTime;
        for (int i = 1; i <= announcement.Length; i++)
        {
            text.text = announcement[..i];
            targetTime = Time.time + 0.04F;
            while (Time.time < targetTime)
            {
                if (Input.GetKey(KeyCode.Return))
                    i = Mathf.Min(i + 1, announcement.Length - 1);
                yield return null;
            }
        }
        targetTime = Time.time + 3.0F;
        while (Time.time < targetTime)
        {
            if (Input.GetKeyDown(KeyCode.Return))
                break;
            yield return null;
        }
        text.text = "";
    }

    private void SwitchSprites()
    {
        if (newSprite)
        {
            monSprite.sprite = originalSprite;
            mask.sprite = originalSprite;
        }
        else
        {
            monSprite.sprite = destinationSprite;
            mask.sprite = destinationSprite;
        }
        newSprite = !newSprite;
    }

    public IEnumerator DoGrowShrinks()
    {
        yield return AnimUtils.Grow(monTransform, 0.4F, 0.3f);
        foreach (float dur in animDurations)
        {
            yield return GrowShrink(dur);
            SwitchSprites();
        }
    }

    public IEnumerator DoAnimation()
    {
        //Todo: sparks at beginning/end
        yield return AnimUtils.Fade(overlay, 1.0F, 0.6F);
        yield return DoGrowShrinks();
        StartCoroutine(AnimUtils.Grow(monTransform, 2.5F, 0.4F));
        yield return AnimUtils.Fade(overlay, 0, 0.4F);
    }

    public IEnumerator DoEvolutionScene()
    {
        string oldName = mon.MonName;
        if (!mon.shouldEvolve) yield break;
        yield return Announce("What?");
        //Todo: mon ETF animation
        audioSource.PlayOneShot(originalSpecies.Data().Cry);
        while (audioSource.isPlaying) yield return null;
        yield return Announce(oldName + " is evolving!");
        yield return DoAnimation();
        yield return new WaitForSeconds(0.5F);
        int hpMaxBefore = mon.hpMax;
        mon.species = destinationSpecies;
        mon.HP += mon.hpMax - hpMaxBefore;
        mon.shouldEvolve = false;
        audioSource.PlayOneShot(destinationSpecies.Data().Cry);
        while (audioSource.isPlaying) yield return null;
        yield return Announce("Congratulations! Your " + oldName +
            " evolved into " + mon.species.Data().speciesName + "!");
    }

    private IEnumerator GrowShrink(float duration)
    {
        yield return AnimUtils.Grow(monTransform, 2.5F, duration / 2);
        yield return AnimUtils.Grow(monTransform, 0.4F, duration / 2);
    }


}