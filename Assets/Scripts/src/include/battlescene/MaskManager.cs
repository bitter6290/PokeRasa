using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public Battle battle;
    public int index;
    [SerializeField]
    private SpriteMask mask;
    [SerializeField]
    private SpriteRenderer maskRenderer;
    [SerializeField]
    private Animator anim;

    public SpriteRenderer baseSprite;

    public IEnumerator MaskAnimation(float fadeTime, float plateauTime, float maxAlpha, string animPath)
    {
        Debug.Log("Starting mask animation");
        anim.runtimeAnimatorController = Resources.Load(animPath) as RuntimeAnimatorController;
        float initTime = Time.time;
        for (int i = 0; i < 10; i++)
        {
            float targetTime = initTime + i * fadeTime / 10.0F;
            maskRenderer.color = new Color(1, 1, 1, i * maxAlpha / 10.0F);
            while (Time.time < targetTime)
            {
                yield return null;
            }
        }
        float plateauTargetTime = Time.time + plateauTime;
        while(Time.time < plateauTargetTime)
        {
            yield return null;
        }
        for (int i = 0; i < 10; i++)
        {
            float targetTime = initTime + i * fadeTime / 10.0F;
            maskRenderer.color = new Color(1, 1, 1, (10 - i) * maxAlpha / 10.0F);
            while (Time.time < targetTime)
            {
                yield return null;
            }
        }
        maskRenderer.color = new Color(1, 1, 1, 0);
    }

    public IEnumerator MaskColor(float fadeTime, float plateauTime, float maxAlpha, Color color)
    {
        Debug.Log("Starting mask animation");
        anim.runtimeAnimatorController = null;
        maskRenderer.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Box"),
            new Rect(0.0F, 0.0F, 96.0F, 96.0F), new Vector2(0.5F, 0.5F));
        maskRenderer.color = color;
        float initTime = Time.time;
        for (int i = 0; i < 10; i++)
        {
            float targetTime = initTime + i * fadeTime / 10.0F;
            maskRenderer.color = new Color(color.r, color.g, color.b, i * maxAlpha / 10.0F);
            while (Time.time < targetTime)
            {
                yield return null;
            }
        }
        float plateauTargetTime = Time.time + plateauTime;
        while (Time.time < plateauTargetTime)
        {
            yield return null;
        }
        for (int i = 0; i < 10; i++)
        {
            float targetTime = initTime + i * fadeTime / 10.0F;
            maskRenderer.color = new Color(color.r, color.g, color.b, (10 - i) * maxAlpha / 10.0F);
            while (Time.time < targetTime)
            {
                yield return null;
            }
        }
        maskRenderer.color = new Color(1, 1, 1, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        maskRenderer.color = new Color(1.0F, 1.0F, 1.0F, 0.0F);
    }

    // Update is called once per frame
    void Update()
    {
        mask.enabled = !battle.PokemonOnField[index].PokemonData.fainted;
        mask.sprite = baseSprite.sprite;
    }
}
