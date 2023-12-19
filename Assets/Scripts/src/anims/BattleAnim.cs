using System.Collections;
using UnityEngine;
using static AnimUtils;

public static class BattleAnim
{
    //Audio functions
    public static void Cry(SpeciesID species, AudioSource audioSource)
    {
        AudioClip cry = Resources.Load("Sound/Cries/" + Species.SpeciesTable[(ushort)species].cryLocation) as AudioClip;
        audioSource.volume = 1.0F;
        audioSource.PlayOneShot(cry);
    }
    public static AudioClip BattleFX(string path)
    {
        return Resources.Load<AudioClip>("Sound/Battle SFX/" + path);
    }

    //Specific procedures
    public static IEnumerator StatUp(Battle battle, int index)
    {
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/StatUp"));
        yield return battle.maskManager[index].MaskAnimation(0.3F, 0.6F, 160.0F / 255.0F, "BattleMasks/Animations/StatUp_0");
    }

    public static IEnumerator StatDown(Battle battle, int index)
    {
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/StatDown"));
        yield return battle.maskManager[index].MaskAnimation(0.3F, 0.6F, 160.0F / 255.0F, "BattleMasks/Animations/StatDown_0");
    }

    public static IEnumerator ShowBurn(Battle battle, int index)
    {
        AudioClip burnSound = Resources.Load<AudioClip>("Sound/Battle SFX/Burn");
        battle.audioSource0.PlayOneShot(burnSound);
        battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return battle.maskManager[index].MaskColor(0.1F, 0.4F, 160.0F / 255.0F, new Color(200.0F / 255.0F, 0, 0));
    }

    public static IEnumerator ShowPoison(Battle battle, int index)
    {
        AudioClip poisonSound = Resources.Load<AudioClip>("Sound/Battle SFX/Poison");
        battle.audioSource0.PlayOneShot(poisonSound);
        battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public static IEnumerator ShowToxicPoison(Battle battle, int index)
    {
        AudioClip poisonSound = Resources.Load<AudioClip>("Sound/Battle SFX/Poison");
        battle.audioSource0.PlayOneShot(poisonSound);
        battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 200.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public static IEnumerator ShowParalysis(Battle battle, int index)
    {
        AudioClip paraSound = Resources.Load<AudioClip>("Sound/Battle SFX/Paralysis");
        battle.audioSource0.PlayOneShot(paraSound);
        battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(1, 1, 0));
    }

    public static IEnumerator ShowFreeze(Battle battle, int index)
    {
        AudioClip freezeSound = Resources.Load<AudioClip>("Sound/Battle SFX/Freeze");
        battle.audioSource0.PlayOneShot(freezeSound);
        battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(0, 1, 1));
    }

    public static IEnumerator HealStar(Battle battle, int index, Vector2 location, float translationRate) //duration 0..60
    {
        GameObject healStar = NewSpriteFromTexturePart("Sprites/Battle/green_star", battle.spriteTransform[index],
    new Vector2(1.0F, 1.0F), location, new Rect(0.0F, 32.0F, 16.0F, 16.0F));
        battle.StartCoroutine(SmoothSlide(healStar.transform, new Vector2(0.0F, 1.4F * translationRate), 0.6F));
        yield return new WaitForSeconds(0.5F); //0.50
        yield return FadeDelete(healStar.GetComponent<SpriteRenderer>(), 0.1F); //0.60
    }

    public static IEnumerator Heal(Battle battle, int index) //duration 1.10
    {
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Heal"));
        battle.StartCoroutine(battle.maskManager[index].MaskColor(0.1F, 0.9F, 160.0F / 255.0F, new Color(80.0F / 255.0F, 1, 0))); //0.00 - 1.10
        battle.StartCoroutine(HealStar(battle, index, new Vector2(-1.0F, -0.6F), 1.0F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.1F); //0.10
        battle.StartCoroutine(HealStar(battle, index, new Vector2(0.1F, -0.8F), 0.9F)); //0.10 - 0.70
        yield return new WaitForSeconds(0.05F); //0.15
        battle.StartCoroutine(HealStar(battle, index, new Vector2(0.85F, -0.5F), 1.1F)); //0.15 - 0.75
        yield return new WaitForSeconds(0.15F); //0.30
        battle.StartCoroutine(HealStar(battle, index, new Vector2(-1.3F, -0.6F), 0.8F)); //0.30 - 0.90
        yield return new WaitForSeconds(0.10F); //0.40
        yield return HealStar(battle, index, new Vector2(-0.5F, -0.8F), 0.9F); //1.00
        yield return new WaitForSeconds(0.10F); //1.10
    }

    public static IEnumerator ItemRing(Battle battle, int index) //duration 0.40
    {
        GameObject ring = NewSpriteFromTexture("Sprites/Battle/thin_ring", battle.spriteTransform[index],
            new Vector2(0.2F, 0.2F), new Vector2(0, 0));
        yield return Grow(ring.GetComponent<Transform>(), 5, 0.3F); //0.30
        yield return FadeDelete(ring.GetComponent<SpriteRenderer>(), 0.1F); //0.40
    }

    public static IEnumerator UseItem(Battle battle, int index) //duration 0.56
    {
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Item"));
        battle.StartCoroutine(ItemRing(battle, index)); //0.00 - 0.40
        yield return new WaitForSeconds(0.06F); //0.06
        yield return ItemRing(battle, index); //0.46
        yield return new WaitForSeconds(0.1F); //0.56
    }

    public static IEnumerator Faint(Battle battle, int index) //duration 1.60
    {
        Vector3 initialPosition = battle.spriteTransform[index].position;
        battle.audioSource0.pitch = 0.7F;
        Cry(battle.PokemonOnField[index].PokemonData.species, battle.audioSource0);
        yield return new WaitForSeconds(1.3F); //1.30
        battle.audioSource0.pitch = 1.0F;
        GameObject mask = new();
        mask.transform.parent = battle.spriteTransform[index];
        mask.transform.localPosition = new Vector2(0.0F, 0.0F);
        mask.transform.localScale = new Vector3(1.0F, 1.0F, 1.0F);
        mask.transform.SetParent(null, true);
        SpriteMask faintMask = mask.AddComponent<SpriteMask>();
        faintMask.isCustomRangeActive = true;
        faintMask.backSortingOrder = -1;
        faintMask.frontSortingOrder = 1;
        faintMask.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Box"), new Rect(0.0F, 0.0F, 64.0F, 64.0F), new Vector2(0.5F, 0.5F));
        battle.spriteRenderer[index].maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Faint"));
        yield return Slide(battle.spriteTransform[index], new Vector3(0.0F, -3.0F, 0.0F), 0.3F); //1.60
        battle.spriteTransform[index].position = initialPosition;
        UnityEngine.Object.Destroy(mask);
    }

    public static IEnumerator AttractHeart(Battle battle, int index, float xDisplacement) //duration 0.60
    {
        GameObject heart = NewSpriteFromTexturePart("Sprites/Battle/pink_heart_2", battle.spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 0.0F), new Rect(0.0F, 0.0F, 32.0F, 32.0F), 2);
        battle.StartCoroutine(FadeIn(heart.GetComponent<SpriteRenderer>(), 0.2F)); //0.00 - 0.20
        battle.StartCoroutine(DoublePower(heart.GetComponent<Transform>(), new Vector2(xDisplacement, 1.5F), 0.5F, 1.5F, 0.6F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.45F); //0.45
        yield return FadeDelete(heart.GetComponent<SpriteRenderer>(), 0.15F); //0.60
    }

    public static IEnumerator Infatuated(Battle battle, int index)
    {
        AudioClip heartSound = Resources.Load<AudioClip>("Sound/Battle SFX/Charm");
        battle.audioSource0.PlayOneShot(heartSound);
        battle.audioSource0.panStereo = 0.2F;
        yield return null;
        battle.StartCoroutine(AttractHeart(battle, index, 0.9F)); //0.00 - 0.60
        yield return new WaitForSeconds(0.5F); //0.60
        battle.audioSource1.PlayOneShot(heartSound);
        battle.audioSource1.panStereo = -0.2F;
        battle.StartCoroutine(AttractHeart(battle, index, -0.75F)); //0.60 - 1.20
        yield return new WaitForSeconds(0.2F); //0.80
        battle.audioSource0.PlayOneShot(heartSound);
        battle.audioSource0.panStereo = 0.06F;
        yield return AttractHeart(battle, index, 0.3F); //1.40
    }

    public static IEnumerator Transform(Battle battle, int index, SpeciesID destinationSpecies = SpeciesID.Missingno,
        bool untransform = false)
    {
        SpriteRenderer renderer = battle.spriteRenderer[index];
        float alpha = renderer.color.a;
        yield return Fade(renderer, 0.0F, 0.5F);
        if (untransform)
            battle.PokemonOnField[index].PokemonData.transformed = false;
        else
        {
            battle.PokemonOnField[index].PokemonData.transformed = true;
            battle.PokemonOnField[index].PokemonData.temporarySpecies = destinationSpecies;
        }
        yield return new WaitForSeconds(0.5F);
        yield return Fade(renderer, alpha, 0.5F);
    }

    public static IEnumerator BallShake(Battle battle, Transform transform) //0.95
    {
        battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/BallShake"));
        yield return Rotate(transform, -45, 0.15f); //0.15
        yield return Rotate(transform, 90, 0.3f);  //0.45
        yield return Rotate(transform, -45, 0.15f); //0.60
        yield return new WaitForSeconds(0.35f); //0.95
    }

    public static IEnumerator MegaEvolution(Battle battle, int index) //3.90
    {
        GameObject megaCircle = NewSpriteFromTexture("Sprites/Battle/MegaCircle", battle.spriteTransform[index],
            new Vector2(0.06F, 0.06F), new Vector2(0.0F, 0.0F));
        SpriteRenderer renderer = megaCircle.GetComponent<SpriteRenderer>();
        Transform transform = megaCircle.GetComponent<Transform>();
        battle.StartCoroutine(FadeIn(renderer, 0.6F)); //0.00 - 0.60
        yield return Grow(transform, 10, 0.6F); //0.60
        battle.StartCoroutine(Fade(renderer, 30, 0.45F)); //0.60 - 1.05
        yield return Grow(transform, 0.75F, 0.45F); //1.05
        battle.StartCoroutine(Fade(renderer, 1, 0.6F)); //1.05 - 1.65
        yield return Grow(transform, 1.7F, 0.6F); //1.65
        yield return Grow(transform, 0.8F, 0.3F); //1.95
        yield return Grow(transform, 1.25F, 0.45F); //2.40
        GameObject megaStone = NewSpriteFromTexture("Sprites/Battle/mega_stone", battle.spriteTransform[index],
            new Vector2(1.33F, 1.33F), new Vector2(0.0F, 0.0F), 2);
        battle.StartCoroutine(FadeIn(megaStone.GetComponent<SpriteRenderer>(), 0.7F)); //2.40 - 3.10
        battle.StartCoroutine(Grow(megaStone.GetComponent<Transform>(), 1.25F, 0.7F)); //2.40 - 3.10
        yield return Grow(transform, 0.8F, 0.7F); //3.10
        GameObject megaSymbol = NewSpriteFromTexture("Sprites/Battle/mega_symbol", battle.spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 2.0F));
        battle.StartCoroutine(FadeDelete(renderer, 0.1F)); //3.10 - 3.20
        battle.StartCoroutine(Sinusoidal(megaSymbol.GetComponent<Transform>(), new Vector3(0.0F, 1.0F), 0.4F, 6, 0.8F, true)); //3.10 - 3.90
        battle.StartCoroutine(FadeDelete(megaStone.GetComponent<SpriteRenderer>(), 0.5F)); //3.10 - 3.60
        yield return Grow(megaStone.GetComponent<Transform>(), 3.5F, 0.5F); //3.60
        yield return FadeDelete(megaSymbol.GetComponent<SpriteRenderer>(), 0.3F); //3.90
    }

    //Components

    public static IEnumerator SwordsDanceSword(Battle battle, int index, int whichSword)
    {
        GameObject sword = NewSpriteFromTexture("Sprites/Battle/Sword_new", battle.spriteTransform[index],
            new Vector2(1.0F, 1.0F), new Vector2(0.0F, 1.0F));
        sword.transform.parent = null;
        yield return Ellipse(sword.transform, 0.7F, 2.5F, 1.0F, false); //1.00
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 1.0F - (whichSword * 0.20F), false, 0.0F,
            360.0F - (whichSword * 72.0F), new Vector2(0.0F, 0.0F)); //2.00 - 0.24 * whichSword
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.42F, false, 360.0F - (whichSword * 72.0F),
    180.0F, new Vector2(0.0F, 0.2F)); //up to 2.42
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.36F, false, 180.0F - (whichSword * 72.0F),
180.0F, new Vector2(0.0F, 0.2F)); //up to 2.80
        battle.StartCoroutine(FadeDelete(sword.GetComponent<SpriteRenderer>(), 0.65F)); //up to 3.30-3.95
        yield return EllipseSmart(sword.transform, 0.7F, 2.5F, 0.6F, false, 360.0F - (whichSword * 72.0F),
    360.0F, new Vector2(0.0F, 0.7F)); //up to 3.40
        yield return null;

    }


    //Move animation sequences
    public static IEnumerator AttackerAnims(Battle battle, int index, MoveID move, int defender)
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
                Cry(battle.PokemonOnField[index].PokemonData.species, battle.audioSource0);
                yield return Sway(battle.spriteTransform[index], 0.25F, 0.1F, 0.1F, 3); //0.30
                yield return new WaitForSeconds(0.5F); //0.80
                break;
            case MoveID.SwordsDance:
                cachedClip = Resources.Load<AudioClip>("Sound/Battle SFX/Clang");
                battle.StartCoroutine(Ellipse(battle.spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                battle.audioSource0.PlayOneShot(cachedClip);
                battle.StartCoroutine(SwordsDanceSword(battle, index, 0)); //0.00 - 3.40
                yield return new WaitForSeconds(0.2F); //0.20
                battle.StartCoroutine(SwordsDanceSword(battle, index, 1)); //0.20 - 3.40
                yield return new WaitForSeconds(0.2F); //0.40
                battle.StartCoroutine(SwordsDanceSword(battle, index, 2)); //0.40 - 3.40
                yield return new WaitForSeconds(0.2F); //0.60
                battle.StartCoroutine(SwordsDanceSword(battle, index, 3)); //0.60 - 3.40
                yield return new WaitForSeconds(0.2F); //0.80
                battle.StartCoroutine(Ellipse(battle.spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                battle.audioSource0.PlayOneShot(cachedClip);
                yield return SwordsDanceSword(battle, index, 4); //3.40
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


    public static IEnumerator DefenderAnims(Battle battle, int index, MoveID move, int attacker)
    {
        switch (move)
        {
            case MoveID.Pound:
                battle.audioSource0.volume = 1;
                battle.audioSource0.PlayOneShot(BattleFX("Pound"));
                battle.audioSource0.panStereo = index < 3 ? 0.5F : -0.5F;
                GameObject poundSprite = NewSpriteFromTexture("Sprites/Battle/impact", battle.spriteTransform[index],
                    new Vector2(0.3F, 0.3F), new Vector2(0.0F, 0.0F));
                battle.StartCoroutine(Sway(battle.spriteTransform[index], 0.05F, 0.1F, 0.05F, 2)); //0.00 - 0.30
                yield return Grow(poundSprite.transform, 2, 0.1F); //0.10
                yield return new WaitForSeconds(0.3F); //0.40
                yield return FadeDelete(poundSprite.GetComponent<SpriteRenderer>(), 0.1F); //0.50
                break;
            case MoveID.KarateChop:
                battle.audioSource0.volume = 1;
                battle.audioSource0.PlayOneShot(BattleFX("Karate Chop"));
                GameObject karateChopSprite = NewSpriteFromTexturePart(
                    "Sprites/Battle/hands_and_feet", battle.spriteTransform[index], new Vector2(1.0F, 1.0F),
                    new Vector2(0.0F, 1.0F), new Rect(0.0F, 0.0F, 32.0F, 32.0F));
                karateChopSprite.transform.Rotate(new Vector3(0, 0, -90));
                yield return SmoothSlide(karateChopSprite.transform, new Vector2(0.0F, 0.1F), 0.2F); //0.20
                battle.StartCoroutine(Delay(Sway(battle.spriteTransform[index], 0.05F, 0.05F, 0.03F, 2), 0.05F)); //0.25 - 0.41
                yield return SmoothSlide(karateChopSprite.transform, new Vector2(0.0F, -1.1F), 0.1F); //0.30
                yield return new WaitForSeconds(0.45F); //0.75
                yield return FadeDelete(karateChopSprite.GetComponent<SpriteRenderer>(), 0.05F); //0.80
                break;
            case MoveID.DoubleSlap:
                battle.audioSource0.volume = 1;
                GameObject doubleSlapSprite = NewSpriteFromTexturePart(
                    "Sprites/Battle/hands_and_feet", battle.spriteTransform[index], new Vector2(1.0F, 1.0F),
                    new Vector2(0.8F, 0.2F), new Rect(0.0F, 0.0F, 32.0F, 32.0F));
                doubleSlapSprite.transform.Rotate(new Vector3(0, 0, 90));
                battle.StartCoroutine(Delay(Swing(doubleSlapSprite.transform, new Vector2(-1.6F, 0.0F), 0.2F, 0.3F), 0.1F)); //0.00 - 0.50
                yield return new WaitForSeconds(0.25F); //0.25
                battle.audioSource0.PlayOneShot(BattleFX("Pound"));
                doubleSlapSprite.GetComponent<SpriteRenderer>().flipY = true;
                GameObject doubleSlapImpactSprite = NewSpriteFromTexture("Sprites/Battle/impact", battle.spriteTransform[index],
                    new Vector2(0.2F, 0.2F), new Vector2(0.0F, 0.0F));
                yield return Grow(doubleSlapImpactSprite.transform, 2, 0.1F); //0.35
                yield return new WaitForSeconds(0.15F); //0.50
                battle.StartCoroutine(FadeDelete(doubleSlapImpactSprite.GetComponent<SpriteRenderer>(), 0.10F)); //0.50 - 0.60
                yield return FadeDelete(doubleSlapSprite.GetComponent<SpriteRenderer>(), 0.10F); //0.60
                break;
            case MoveID.Growl:
                yield return new WaitForSeconds(0.35F); //0.35
                yield return Sway(battle.spriteTransform[index], 0.1F, 0.05F, 0.05F, 3); //0.50
                break;
            case MoveID.None:
            default:
                yield return null;
                break;
        }
    }
}
