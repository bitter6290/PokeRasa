using System.Collections;
using UnityEngine;
using static AnimUtils;

public partial class Battle
{
    //Audio functions
    public void Cry(SpeciesID species, AudioSource audioSource)
    {
        AudioClip cry = Resources.Load("Sound/Cries/" + Species.SpeciesTable[(ushort)species].cryLocation) as AudioClip;
        audioSource.volume = 1.0F;
        audioSource.PlayOneShot(cry);
    }
    public AudioClip BattleFX(string path)
    {
        return Resources.Load<AudioClip>("Sound/Battle SFX/" + path);
    }

    //Specific procedures
    public IEnumerator StatUpAnim(int index)
    {
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/StatUp"));
        yield return maskManager[index].MaskAnimation(0.3F, 0.6F, 160.0F / 255.0F, "BattleMasks/Animations/StatUp_0");
    }

    public IEnumerator StatDownAnim(int index)
    {
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/StatDown"));
        yield return maskManager[index].MaskAnimation(0.3F, 0.6F, 160.0F / 255.0F, "BattleMasks/Animations/StatDown_0");
    }

    public IEnumerator ShowBurn(int index)
    {
        AudioClip burnSound = Resources.Load<AudioClip>("Sound/Battle SFX/Burn");
        audioSource0.PlayOneShot(burnSound);
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return maskManager[index].MaskColor(0.1F, 0.4F, 160.0F / 255.0F, new Color(200.0F / 255.0F, 0, 0));
    }

    public IEnumerator ShowPoison(int index)
    {
        AudioClip poisonSound = Resources.Load<AudioClip>("Sound/Battle SFX/Poison");
        audioSource0.PlayOneShot(poisonSound);
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public IEnumerator ShowToxicPoison(int index)
    {
        AudioClip poisonSound = Resources.Load<AudioClip>("Sound/Battle SFX/Poison");
        audioSource0.PlayOneShot(poisonSound);
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return maskManager[index].MaskColor(0.2F, 0.6F, 200.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public IEnumerator ShowParalysis(int index)
    {
        AudioClip paraSound = Resources.Load<AudioClip>("Sound/Battle SFX/Paralysis");
        audioSource0.PlayOneShot(paraSound);
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(1, 1, 0));
    }

    public IEnumerator ShowFreeze(int index)
    {
        AudioClip freezeSound = Resources.Load<AudioClip>("Sound/Battle SFX/Freeze");
        audioSource0.PlayOneShot(freezeSound);
        audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(0, 1, 1));
    }

    public IEnumerator HealStar(int index, Vector2 location, float translationRate) //duration 0..60
    {
        GameObject healStar = NewSpriteFromTexturePart("Sprites/Battle/green_star", spriteTransform[index],
    new Vector2(1.0F, 1.0F), location, new Rect(0.0F, 32.0F, 16.0F, 16.0F));
        StartCoroutine(SmoothSlide(healStar.transform, new Vector2(0.0F, 1.4F * translationRate), 0.6F));
        yield return new WaitForSeconds(0.5F); //0.50
        yield return FadeDelete(healStar.GetComponent<SpriteRenderer>(), 0.1F); //0.60
    }

    public IEnumerator Heal(int index) //duration 1.10
    {
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Heal"));
        StartCoroutine(maskManager[index].MaskColor(0.1F, 0.9F, 160.0F / 255.0F, new Color(80.0F / 255.0F, 1, 0))); //0.00 - 1.10
        StartCoroutine(HealStar(index, new Vector2(-1.0F, -0.6F), 1.0F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.1F); //0.10
        StartCoroutine(HealStar(index, new Vector2(0.1F, -0.8F), 0.9F)); //0.10 - 0.70
        yield return new WaitForSeconds(0.05F); //0.15
        StartCoroutine(HealStar(index, new Vector2(0.85F, -0.5F), 1.1F)); //0.15 - 0.75
        yield return new WaitForSeconds(0.15F); //0.30
        StartCoroutine(HealStar(index, new Vector2(-1.3F, -0.6F), 0.8F)); //0.30 - 0.90
        yield return new WaitForSeconds(0.10F); //0.40
        yield return HealStar(index, new Vector2(-0.5F, -0.8F), 0.9F); //1.00
        yield return new WaitForSeconds(0.10F); //1.10
    }

    public IEnumerator ItemRing(int index) //duration 0.40
    {
        GameObject ring = NewSpriteFromTexture("Sprites/Battle/thin_ring", spriteTransform[index],
            new Vector2(0.2F, 0.2F), new Vector2(0, 0));
        yield return Grow(ring.GetComponent<Transform>(), 5, 0.3F); //0.30
        yield return FadeDelete(ring.GetComponent<SpriteRenderer>(), 0.1F); //0.40
    }

    public IEnumerator UseItemAnim(int index) //duration 0.56
    {
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Item"));
        StartCoroutine(ItemRing(index)); //0.00 - 0.40
        yield return new WaitForSeconds(0.06F); //0.06
        yield return ItemRing(index); //0.46
        yield return new WaitForSeconds(0.1F); //0.56
    }

    public IEnumerator FaintAnim(int index) //duration 1.60
    {
        Vector3 initialPosition = spriteTransform[index].position;
        audioSource0.pitch = 0.7F;
        Cry(PokemonOnField[index].PokemonData.species, audioSource0);
        yield return new WaitForSeconds(1.3F); //1.30
        audioSource0.pitch = 1.0F;
        GameObject mask = new();
        mask.transform.parent = spriteTransform[index];
        mask.transform.localPosition = new Vector2(0.0F, 0.0F);
        mask.transform.localScale = new Vector3(1.0F, 1.0F, 1.0F);
        mask.transform.SetParent(null, true);
        SpriteMask faintMask = mask.AddComponent<SpriteMask>();
        faintMask.isCustomRangeActive = true;
        faintMask.backSortingOrder = -1;
        faintMask.frontSortingOrder = 1;
        faintMask.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Box"), new Rect(0.0F, 0.0F, 64.0F, 64.0F), StaticValues.defPivot);
        spriteRenderer[index].maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Faint"));
        yield return Slide(spriteTransform[index], new Vector3(0.0F, -3.0F, 0.0F), 0.3F); //1.60
        spriteTransform[index].position = initialPosition;
        Destroy(mask);
    }

    public IEnumerator AttractHeart(int index, float xDisplacement) //duration 0.60
    {
        GameObject heart = NewSpriteFromTexturePart("Sprites/Battle/pink_heart_2", spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 0.0F), new Rect(0.0F, 0.0F, 32.0F, 32.0F), 2);
        StartCoroutine(FadeIn(heart.GetComponent<SpriteRenderer>(), 0.2F)); //0.00 - 0.20
        StartCoroutine(DoublePower(heart.GetComponent<Transform>(), new Vector2(xDisplacement, 1.5F), 0.5F, 1.5F, 0.6F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.45F); //0.45
        yield return FadeDelete(heart.GetComponent<SpriteRenderer>(), 0.15F); //0.60
    }

    public IEnumerator Infatuated(int index)
    {
        AudioClip heartSound = Resources.Load<AudioClip>("Sound/Battle SFX/Charm");
        audioSource0.PlayOneShot(heartSound);
        audioSource0.panStereo = 0.2F;
        yield return null;
        StartCoroutine(AttractHeart(index, 0.9F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.5F); //0.60
        audioSource1.PlayOneShot(heartSound);
        audioSource1.panStereo = -0.2F;
        StartCoroutine(AttractHeart(index, -0.75F)); //0.60 - 1.20
        yield return new WaitForSeconds(0.2F); //0.80
        audioSource0.PlayOneShot(heartSound);
        audioSource0.panStereo = 0.06F;
        yield return AttractHeart(index, 0.3F); //1.40
    }

    public IEnumerator Transform(int index, SpeciesID destinationSpecies = SpeciesID.Missingno,
        bool untransform = false)
    {
        SpriteRenderer renderer = spriteRenderer[index];
        float alpha = renderer.color.a;
        yield return Fade(renderer, 0.0F, 0.5F);
        if (untransform)
            PokemonOnField[index].PokemonData.transformed = false;
        else
        {
            PokemonOnField[index].PokemonData.transformed = true;
            PokemonOnField[index].PokemonData.temporarySpecies = destinationSpecies;
        }
        yield return new WaitForSeconds(0.5F);
        yield return Fade(renderer, alpha, 0.5F);
    }

    public IEnumerator BallShake(Transform transform) //0.95
    {
        audioSource0.PlayOneShot(SFX.BallShake);
        yield return Rotate(transform, -45, 0.1f); //0.1
        yield return Rotate(transform, 90, 0.2f);  //0.3
        yield return Rotate(transform, -45, 0.1f); //0.4
        yield return new WaitForSeconds(0.55f); //0.95
    }

    public IEnumerator BallCatch(Transform transform, SpriteRenderer spriteRenderer) //0.70
    {
        //Todo: Add catch click
        spriteRenderer.color = Color.gray;
        StartCoroutine(CatchStar(transform, -1)); //0.00 - 0.70
        StartCoroutine(CatchStar(transform, 0)); //0.00 - 0.70
        yield return CatchStar(transform, 1); //0.70
    }

    public IEnumerator CatchStar(Transform parent, int xVelocity) //0.70
    {
        GameObject starObject = NewSpriteFromTexturePart("Sprites/Battle/gold_stars", parent, Vector2.one, Vector2.zero, new(0, 8, 16, 16));
        StartCoroutine(Fall(starObject.transform, 8, new(xVelocity, 4), 0.7F)); //0.00 - 0.70
        yield return new WaitForSeconds(0.5F); //0.50
        yield return FadeDelete(starObject.GetComponent<SpriteRenderer>(), 0.2F); //0.70

    }

    public IEnumerator MegaEvolution(int index) //3.90
    {
        GameObject megaCircle = NewSpriteFromTexture("Sprites/Battle/MegaCircle", spriteTransform[index],
            new Vector2(0.06F, 0.06F), new Vector2(0.0F, 0.0F));
        SpriteRenderer renderer = megaCircle.GetComponent<SpriteRenderer>();
        Transform transform = megaCircle.GetComponent<Transform>();
        StartCoroutine(FadeIn(renderer, 0.6F)); //0.00 - 0.60
        yield return Grow(transform, 10, 0.6F); //0.60
        StartCoroutine(Fade(renderer, 30, 0.45F)); //0.60 - 1.05
        yield return Grow(transform, 0.75F, 0.45F); //1.05
        StartCoroutine(Fade(renderer, 1, 0.6F)); //1.05 - 1.65
        yield return Grow(transform, 1.7F, 0.6F); //1.65
        yield return Grow(transform, 0.8F, 0.3F); //1.95
        yield return Grow(transform, 1.25F, 0.45F); //2.40
        GameObject megaStone = NewSpriteFromTexture("Sprites/Battle/mega_stone", spriteTransform[index],
            new Vector2(1.33F, 1.33F), new Vector2(0.0F, 0.0F), 2);
        StartCoroutine(FadeIn(megaStone.GetComponent<SpriteRenderer>(), 0.7F)); //2.40 - 3.10
        StartCoroutine(Grow(megaStone.GetComponent<Transform>(), 1.25F, 0.7F)); //2.40 - 3.10
        yield return Grow(transform, 0.8F, 0.7F); //3.10
        GameObject megaSymbol = NewSpriteFromTexture("Sprites/Battle/mega_symbol", spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 2.0F));
        StartCoroutine(FadeDelete(renderer, 0.1F)); //3.10 - 3.20
        StartCoroutine(Sinusoidal(megaSymbol.GetComponent<Transform>(), new Vector3(0.0F, 1.0F), 0.4F, 6, 0.8F, true)); //3.10 - 3.90
        StartCoroutine(FadeDelete(megaStone.GetComponent<SpriteRenderer>(), 0.5F)); //3.10 - 3.60
        yield return Grow(megaStone.GetComponent<Transform>(), 3.5F, 0.5F); //3.60
        yield return FadeDelete(megaSymbol.GetComponent<SpriteRenderer>(), 0.3F); //3.90
    }

    //Components

    public IEnumerator SwordsDanceSword(int index, int whichSword)
    {
        GameObject sword = NewSpriteFromTexture("Sprites/Battle/Sword_new", spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 1.0F));
        sword.transform.parent = null;
        yield return Ellipse(sword.transform, 0.7F, 2.5F, 1.0F, false); //1.00
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 1.0F - (whichSword * 0.20F), false, 0.0F,
            360.0F - (whichSword * 72.0F), new Vector2(0.0F, 0.0F)); //2.00 - 0.24 * whichSword
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.42F, false, 360.0F - (whichSword * 72.0F),
    180.0F, new Vector2(0.0F, 0.2F)); //up to 2.42
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.36F, false, 180.0F - (whichSword * 72.0F),
180.0F, new Vector2(0.0F, 0.2F)); //up to 2.80
        StartCoroutine(FadeDelete(sword.GetComponent<SpriteRenderer>(), 0.65F)); //up to 3.30-3.95
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.6F, false, 360.0F - (whichSword * 72.0F),
    360.0F, new Vector2(0.0F, 0.7F)); //up to 3.40
        yield return null;

    }


    //Move animation sequences
    public IEnumerator AttackerAnims(int index, MoveID move, int defender)
    {
        AudioClip cachedClip;
        switch (move)
        {
            case MoveID.Pound:
                yield return new WaitForSeconds(1.0F); //1.00
                break;
            case MoveID.KarateChop:
                yield return new WaitForSeconds(0.9F); //0.90
                break;
            case MoveID.Growl:
                Cry(PokemonOnField[index].PokemonData.species, audioSource0);
                yield return Sway(spriteTransform[index], 0.25F, 0.1F, 0.1F, 3); //0.30
                yield return new WaitForSeconds(0.5F); //0.80
                break;
            case MoveID.SwordsDance:
                cachedClip = Resources.Load<AudioClip>("Sound/Battle SFX/Clang");
                StartCoroutine(Ellipse(spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                audioSource0.PlayOneShot(cachedClip);
                StartCoroutine(SwordsDanceSword(index, 0)); //0.00 - 3.40
                yield return new WaitForSeconds(0.2F); //0.20
                StartCoroutine(SwordsDanceSword(index, 1)); //0.20 - 3.40
                yield return new WaitForSeconds(0.2F); //0.40
                StartCoroutine(SwordsDanceSword(index, 2)); //0.40 - 3.40
                yield return new WaitForSeconds(0.2F); //0.60
                StartCoroutine(SwordsDanceSword(index, 3)); //0.60 - 3.40
                yield return new WaitForSeconds(0.2F); //0.80
                StartCoroutine(Ellipse(spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                audioSource0.PlayOneShot(cachedClip);
                yield return SwordsDanceSword(index, 4); //3.40
                break;
            case MoveID.DoubleSlap:
                yield return new WaitForSeconds(0.6F); //0.60
                break;
            case MoveID.None:
            default:
                yield return null;
                break;
        }
    }


    public IEnumerator DefenderAnims(int index, MoveID move, int attacker)
    {
        switch (move)
        {
            case MoveID.Pound:
                audioSource0.volume = 1;
                audioSource0.PlayOneShot(BattleFX("Pound"));
                audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
                GameObject poundSprite = NewSpriteFromTexture("Sprites/Battle/impact", spriteTransform[index],
                    new Vector2(0.3F, 0.3F), new Vector2(0.0F, 0.0F));
                StartCoroutine(Sway(spriteTransform[index], 0.05F, 0.1F, 0.05F, 2)); //0.00 - 0.30
                yield return Grow(poundSprite.transform, 2, 0.1F); //0.10
                yield return new WaitForSeconds(0.3F); //0.40
                yield return FadeDelete(poundSprite.GetComponent<SpriteRenderer>(), 0.1F); //0.50
                break;
            case MoveID.KarateChop:
                audioSource0.volume = 1;
                audioSource0.PlayOneShot(BattleFX("Karate Chop"));
                GameObject karateChopSprite = NewSpriteFromTexturePart(
                    "Sprites/Battle/hands_and_feet", spriteTransform[index], new Vector2(1.0F, 1.0F),
                    new Vector2(0.0F, 1.0F), new Rect(0.0F, 0.0F, 32.0F, 32.0F));
                karateChopSprite.transform.Rotate(new Vector3(0, 0, -90));
                yield return SmoothSlide(karateChopSprite.transform, new Vector2(0.0F, 0.1F), 0.2F); //0.20
                StartCoroutine(Delay(Sway(spriteTransform[index], 0.05F, 0.05F, 0.03F, 2), 0.05F)); //0.25 - 0.41
                yield return SmoothSlide(karateChopSprite.transform, new Vector2(0.0F, -1.1F), 0.1F); //0.30
                yield return new WaitForSeconds(0.45F); //0.75
                yield return FadeDelete(karateChopSprite.GetComponent<SpriteRenderer>(), 0.05F); //0.80
                break;
            case MoveID.DoubleSlap:
                audioSource0.volume = 1;
                GameObject doubleSlapSprite = NewSpriteFromTexturePart(
                    "Sprites/Battle/hands_and_feet", spriteTransform[index], new Vector2(1.0F, 1.0F),
                    new Vector2(0.8F, 0.2F), new Rect(0.0F, 0.0F, 32.0F, 32.0F));
                doubleSlapSprite.transform.Rotate(new Vector3(0, 0, 90));
                StartCoroutine(Delay(Swing(doubleSlapSprite.transform, new Vector2(-1.6F, 0.0F), 0.2F, 0.3F), 0.1F)); //0.00 - 0.50
                yield return new WaitForSeconds(0.20F); //0.20
                StartCoroutine(RotateY(doubleSlapSprite.transform, 180, 0.1F)); //0.20 - 0.30
                yield return new WaitForSeconds(0.05F); //0.25
                audioSource0.PlayOneShot(BattleFX("Pound"));
                doubleSlapSprite.GetComponent<SpriteRenderer>().flipY = true;
                GameObject doubleSlapImpactSprite = NewSpriteFromTexture("Sprites/Battle/impact", spriteTransform[index],
                    new Vector2(0.2F, 0.2F), new Vector2(0.0F, 0.0F));
                yield return Grow(doubleSlapImpactSprite.transform, 2, 0.1F); //0.35
                yield return new WaitForSeconds(0.15F); //0.50
                StartCoroutine(FadeDelete(doubleSlapImpactSprite.GetComponent<SpriteRenderer>(), 0.10F)); //0.50 - 0.60
                yield return FadeDelete(doubleSlapSprite.GetComponent<SpriteRenderer>(), 0.10F); //0.60
                break;
            case MoveID.Growl:
                yield return new WaitForSeconds(0.35F); //0.35
                yield return Sway(spriteTransform[index], 0.1F, 0.05F, 0.05F, 3); //0.50
                break;
            case MoveID.None:
            default:
                yield return null;
                break;
        }
    }
}
