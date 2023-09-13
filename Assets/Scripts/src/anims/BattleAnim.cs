using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static System.Math;

public static class BattleAnim
{
    //Audio functions
    public static void Cry(SpeciesID species, AudioSource audioSource)
    {
        AudioClip cry = Resources.Load("Sound/Cries/" + Species.SpeciesTable[(ushort)species].cryLocation) as AudioClip;
        audioSource.volume = 1.0F;
        audioSource.PlayOneShot(cry);
    }
    public static AudioClip G4MoveFX(string path)
    {
        return Resources.Load<AudioClip>("Sound/G4 MoveFX/" + path);
    }
    public static AudioClip BattleFX(string path)
    {
        return Resources.Load<AudioClip>("Sound/Battle SFX/" + path);
    }

    //Sprite constructors
    public static GameObject NewSpriteFromTexture(string path, Transform parent, Vector2 scale, Vector2 location, int order = 1)
    {
        GameObject result = new();
        result.GetComponent<Transform>().parent = parent;
        result.GetComponent<Transform>().localScale = new Vector3(scale.x, scale.y, 1);
        result.GetComponent<Transform>().position = new Vector3(location.x + parent.position.x, location.y + parent.position.y, 0);
        SpriteRenderer sprite = result.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        Texture2D image = Resources.Load<Texture2D>(path);
        sprite.sprite = Sprite.Create(image, new Rect(0.0F, 0.0F, image.width, image.height), new Vector2(0.5F, 0.5F));
        sprite.sortingOrder = order;
        return result;
    }

    public static GameObject NewSpriteFromTexturePart(string path, Transform parent, Vector2 scale, Vector2 location, Rect rect, int order = 1)
    {
        GameObject result = new();
        result.GetComponent<Transform>().parent = parent;
        result.GetComponent<Transform>().localScale = new Vector3(scale.x, scale.y, 1);
        result.GetComponent<Transform>().position = new Vector3(location.x + parent.position.x, location.y + parent.position.y, 0);
        SpriteRenderer sprite = result.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        Texture2D image = Resources.Load<Texture2D>(path);
        sprite.sprite = Sprite.Create(image, rect, new Vector2(0.5F, 0.5F));
        sprite.sortingOrder = order;
        return result;
    }

    //Meta-functions
    public static IEnumerator Delay(IEnumerator enumerator, float delay)
    {
        yield return new WaitForSeconds(delay);
        yield return enumerator;
    }

    public static IEnumerator Concurrent(Battle battle, IEnumerator enumerator1, IEnumerator enumerator2)
    {
        battle.StartCoroutine(enumerator1);
        yield return enumerator2;
    }

    public static IEnumerator Sequential(IEnumerator enumerator1, IEnumerator enumerator2)
    {
        yield return enumerator1;
        yield return enumerator2;
    }

    public static int GetSideModifier(int index)
    {
        return index switch
        {
            < 3 => 1,
            _ => -1
        };
    }

    //Visual animations
    public static IEnumerator Sway(Transform sprite, float amplitude, float endTime, float middleTime, int middles)
    {
        float startTime = Time.time;
        float targetTime = Time.time + endTime;
        Vector3 initialPosition = sprite.position;
        while (Time.time < targetTime)
        {
            sprite.position = new Vector3((float)(initialPosition.x + ((Cos((((Time.time - startTime) / endTime) - 1) * PI) + 1) / 2 * amplitude)),
                initialPosition.y,
                initialPosition.z);
            yield return null;
        }
        for (int i = 0; i < middles; i++)
        {
            startTime = Time.time;
            targetTime = Time.time + middleTime;
            while (Time.time < targetTime)
            {
                sprite.position = new Vector3((float)(initialPosition.x + (Cos((Time.time - startTime) / middleTime * 2 * PI) * amplitude)),
                    initialPosition.y, initialPosition.z);
                yield return null;
            }
        }
        startTime = Time.time;
        targetTime = Time.time + endTime;
        while (Time.time < targetTime)
        {
            sprite.position = new Vector3((float)(initialPosition.x + ((Cos((Time.time - startTime) / endTime * PI) + 1) / 2 * amplitude)),
                initialPosition.y,
                initialPosition.z);
            yield return null;
        }
        sprite.position = initialPosition;
    }

    public static IEnumerator Grow(Transform sprite, float scale, float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 firstScale = sprite.localScale;
        while (Time.time < endTime)
        {
            float timeScale = (endTime - Time.time + (scale * (Time.time - baseTime))) / duration;
            sprite.localScale = new Vector3(firstScale.x * timeScale, firstScale.y * timeScale, firstScale.z);
            yield return null;
        }
        sprite.localScale = new Vector3(firstScale.x * scale, firstScale.y * scale, firstScale.z);
    }

    public static IEnumerator FadeDelete(SpriteRenderer sprite, float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Color firstColor = new(sprite.color[0], sprite.color[1], sprite.color[2], sprite.color[3]);
        while (Time.time < endTime)
        {
            sprite.color = new(firstColor[0], firstColor[1], firstColor[2], firstColor[3] * (endTime - Time.time) / duration);
            yield return null;
        }
        UnityEngine.Object.Destroy(sprite.gameObject);
    }

    public static IEnumerator Ellipse(Transform sprite, float depth, float width, float duration, bool smooth)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        float coeff = depth / 2.0F;
        while (Time.time < endTime)
        {
            sprite.position = new Vector3(
                (float)(initialPosition.x + (width * -Sin(2 * PI * (!smooth ? (Time.time - baseTime) / duration
                : (Cos((((Time.time - baseTime) / duration) - 1) * PI) / 2) + 1)))),
                (float)(initialPosition.y + (coeff * (-Cos(2 * PI * (!smooth ? (Time.time - baseTime) / duration
                : (Cos((((Time.time - baseTime) / duration) - 1) * PI) / 2) + 1)) - 1))),
                initialPosition.z);
            yield return null;
        }
        sprite.position = initialPosition;
    }

    public static IEnumerator EllipseMove(Transform sprite, float depth, float width, float duration, bool smooth, Vector2 translation)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        float coeff = depth / 2.0F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            sprite.position = new Vector3(
                (float)(initialPosition.x
                + (width * Sin(2 * PI * (!smooth ? progress : Cos((progress - 1) * PI))))
                + (progress * translation.x)),
                (float)(initialPosition.y
                + (coeff * (Cos(2 * PI * (!smooth ? progress : Cos((progress - 1) * PI))) - 1))
                + (progress * translation.y)),
                initialPosition.z);
            yield return null;
        }
        sprite.position = initialPosition;
    }

    public static IEnumerator EllipseSmart(Transform sprite, float depth, float width, float duration, bool smooth,
        float initialAngle, float angleRange, Vector2 translation)
    {
        Vector3 originPosition = new(
            (float)(sprite.position.x - (width * Sin(initialAngle * PI / 180.0F))),
            (float)(sprite.position.y - (depth * Cos(initialAngle * PI / 180.0F) / 2)),
            sprite.position.z);
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        float coeff = depth / 2.0F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            double angle = (initialAngle + ((!smooth ? progress : Cos((progress - 1) * PI)) * angleRange)) * PI / 180.0F;
            sprite.position = new Vector3(
                (float)(originPosition.x
                + (width * Sin(angle))
                + (progress * translation.x)),
                (float)(originPosition.y
                + (coeff * Cos(angle))
                + (progress * translation.y)),
                originPosition.z);
            yield return null;
        }
    }

    public static IEnumerator Slide(Transform sprite, Vector2 translation, float duration)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            sprite.position = new Vector3(
                initialPosition.x + (translation.x * (Time.time - baseTime) / duration),
                initialPosition.y + (translation.y * (Time.time - baseTime) / duration),
                initialPosition.z
                );
            yield return null;
        }
    }

    public static IEnumerator SmoothSlide(Transform sprite, Vector2 translation, float duration)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            sprite.position = new Vector3(
                initialPosition.x + (translation.x * (1 + (float)Cos((((Time.time - baseTime) / duration) - 1) * PI)) / 2),
                initialPosition.y + (translation.y * (1 + (float)Cos((((Time.time - baseTime) / duration) - 1) * PI)) / 2),
                initialPosition.z
                );
            yield return null;
        }
    }

    public static IEnumerator Swing(Transform sprite, Vector2 translation, float swingDepth, float duration)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            sprite.position = new Vector3(
                initialPosition.x + (translation.x * (1 + (float)Cos((progress - 1) * PI)) / 2),
                initialPosition.y + (translation.y * (1 + (float)Cos((progress - 1) * PI)) / 2)
                - ((progress - (progress * progress)) * swingDepth * 4),
                initialPosition.z
                );
            yield return null;
        }
    }

    public static IEnumerator Fall(Transform sprite, float rate, Vector2 initialMomentum, float duration)
    {
        Vector2 momentum = new(initialMomentum.x, initialMomentum.y);
        float updateTime = Time.time;
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            sprite.position = new Vector3(
                sprite.position.x + ((Time.time - updateTime) * momentum.x),
                sprite.position.y + ((Time.time - updateTime) * momentum.y),
                sprite.position.z);
            momentum.y -= (Time.time - updateTime) * rate;
            updateTime = Time.time;
            yield return null;
        }
    }

    public static IEnumerator Sinusoidal(Transform sprite, Vector3 translation, float amplitude, int halfPeriods, float duration, bool smooth)
    {
        float xComponent = translation.x / translation.magnitude;
        float yComponent = translation.y / translation.magnitude;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = sprite.position;
        float progress;
        float sinAtTime;
        while (Time.time < endTime)
        {
            progress = (Time.time - baseTime) / duration;
            if (smooth) { progress = 2 * (float)Cos((progress - 1) * PI) - 1; }
            sinAtTime = amplitude * (float)Sin(progress * halfPeriods * PI);
            sprite.position = new Vector3(
                initialPosition.x + progress * translation.x - yComponent * sinAtTime,
                initialPosition.y + progress * translation.y + xComponent * sinAtTime,
                initialPosition.z);
            yield return null;
        }
        sprite.position = initialPosition + translation;
    }

    public static IEnumerator DoubleSinusoidal(Transform sprite, Vector3 translation, float amplitude, int halfPeriods,
        float oscillationFrequency, float oscillationOffset, float duration, bool smooth)
    {
        float xComponent = translation.x / translation.magnitude;
        float yComponent = translation.y / translation.magnitude;
        float baseTime = Time.time;
        float oscZero = baseTime - oscillationOffset;
        float endTime = baseTime + duration;
        Vector3 initialPosition = sprite.position;
        float progress;
        float sinAtTime;
        float oscillationAtTime;
        while (Time.time < endTime)
        {
            progress = (Time.time - baseTime) / duration;
            if (smooth) { progress = 2 * (float)Cos((progress - 1) * PI) - 1; }
            sinAtTime = amplitude * (float)Sin(progress * halfPeriods * PI);
            oscillationAtTime = (float)Sin((Time.time - oscZero) / oscillationFrequency * 2 * PI);
            sprite.position = new Vector3(
                initialPosition.x + progress * translation.x - yComponent * sinAtTime * oscillationAtTime,
                initialPosition.y + progress * translation.y + xComponent * sinAtTime * oscillationAtTime,
                initialPosition.z);
            yield return null;
        }
        sprite.position = initialPosition + translation;
    }

    public static IEnumerator AcceleratingSlide(Transform sprite, Vector3 translation, float duration, float sharpness, bool smooth)
    {
        Vector3 initialPosition = sprite.position;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        float progress;
        while (Time.time < endTime)
        {
            progress = (Time.time - baseTime) / duration;
            if (smooth) { progress = 2 * (float)Cos((progress - 1) * PI) - 1; }
            progress = (float)Pow(progress, 1 + sharpness);
            sprite.position = new Vector3(
                initialPosition.x + translation.x * progress,
                initialPosition.y + translation.y * progress,
                initialPosition.z);
            yield return null;
        }
        sprite.position = sprite.position + translation;
    }

    public static IEnumerator Rotate(Transform sprite, float degrees, float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        float initialAngle = sprite.localEulerAngles.z;
        while (Time.time < endTime)
        {
            sprite.localEulerAngles = new Vector3(
                0, 0, initialAngle + degrees * (Time.time - baseTime) / duration);
            yield return null;
        }
        sprite.localEulerAngles = new Vector3(0, 0, initialAngle + degrees);
    }

    public static IEnumerator DoublePower(Transform sprite, Vector2 translation, float powerX, float powerY, float duration)
    {
        float baseTime = Time.time;
        float endTime = Time.time + duration;
        float progress;
        Vector3 initialPosition = sprite.position;
        while (Time.time < endTime)
        {
            progress = (Time.time - baseTime) / duration;
            float progressX = Mathf.Pow(progress, powerX);
            float progressY = Mathf.Pow(progress, powerY);
            sprite.position = new Vector3(
                initialPosition.x + translation.x * progressX,
                initialPosition.y + translation.y * progressY,
                initialPosition.z);
            yield return null;
        }
    }

    public static IEnumerator FadeIn(SpriteRenderer sprite, float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Color initialColor = sprite.color;
        while (Time.time < endTime)
        {
            sprite.color = new Color(initialColor.r, initialColor.g, initialColor.b,
                (Time.time - baseTime) / duration);
            yield return null;
        }
    }

    public static Vector2 SpriteDistance(Transform sprite1, Transform sprite2)
    {
        return sprite2.position - sprite1.position;
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
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public static IEnumerator ShowToxicPoison(Battle battle, int index)
    {
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 200.0F / 255.0F, TypeUtils.typeColor[(int)Type.Poison]);
    }

    public static IEnumerator ShowParalysis(Battle battle, int index)
    {
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(1, 1, 0));
    }

    public static IEnumerator ShowFreeze(Battle battle, int index)
    {
        yield return battle.maskManager[index].MaskColor(0.2F, 0.6F, 160.0F / 255.0F, new Color(0, 1, 1));
    }

    public static IEnumerator HealStar(Battle battle, int index, Vector2 location, float translationRate) //0.60
    {
        GameObject healStar = NewSpriteFromTexturePart("Sprites/Battle/green_star", battle.spriteTransform[index],
    new Vector2(1.0F, 1.0F), location, new Rect(0.0F, 32.0F, 16.0F, 16.0F));
        battle.StartCoroutine(SmoothSlide(healStar.transform, new Vector2(0.0F, 1.4F * translationRate), 0.6F));
        yield return new WaitForSeconds(0.5F); //0.50
        yield return FadeDelete(healStar.GetComponent<SpriteRenderer>(), 0.1F); //0.60
    }

    public static IEnumerator Heal(Battle battle, int index)
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

    public static IEnumerator Faint(Battle battle, int index)
    {
        Vector3 initialPosition = battle.spriteTransform[index].position;
        battle.audioSource0.pitch = 0.7F;
        Cry(battle.PokemonOnField[index].PokemonData.species, battle.audioSource0);
        yield return new WaitForSeconds(1.3F);
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
        yield return Slide(battle.spriteTransform[index], new Vector3(0.0F, -3.0F, 0.0F), 0.3F);
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
                AudioClip swordsDanceClangClip = Resources.Load<AudioClip>("Sound/Battle SFX/Clang");
                battle.StartCoroutine(Ellipse(battle.spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                battle.audioSource0.PlayOneShot(swordsDanceClangClip);
                battle.StartCoroutine(SwordsDanceSword(battle, index, 0)); //0.00 - 3.40
                yield return new WaitForSeconds(0.2F);
                battle.StartCoroutine(SwordsDanceSword(battle, index, 1)); //0.20 - 3.40
                yield return new WaitForSeconds(0.2F);
                battle.StartCoroutine(SwordsDanceSword(battle, index, 2)); //0.40 - 3.40
                yield return new WaitForSeconds(0.2F);
                battle.StartCoroutine(SwordsDanceSword(battle, index, 3)); //0.60 - 3.40
                yield return new WaitForSeconds(0.2F);
                battle.StartCoroutine(Ellipse(battle.spriteTransform[index], 0.2F, 0.5F, 0.4F, true));
                battle.audioSource0.PlayOneShot(swordsDanceClangClip);
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
                battle.audioSource0.PlayOneShot(G4MoveFX("Karate_Chop"));
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
