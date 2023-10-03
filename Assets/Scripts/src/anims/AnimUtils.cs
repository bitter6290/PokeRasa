using UnityEngine;
using System.Collections;
using static System.Math;

public static class AnimUtils
{
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
        Object.Destroy(sprite.gameObject);
    }

    public static IEnumerator ColorChange(SpriteRenderer sprite, Color oldColor, Color newColor, float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            sprite.color = new(
                (1 - progress) * oldColor.r + progress * newColor.r,
                (1 - progress) * oldColor.g + progress * newColor.g,
                (1 - progress) * oldColor.b + progress * newColor.b,
                (1 - progress) * oldColor.a + progress * newColor.a);
            yield return null;
        }
        sprite.color = newColor;
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

    public static IEnumerator Fade(SpriteRenderer sprite, float newAlpha, float duration)
    {
        {
            float baseTime = Time.time;
            float endTime = baseTime + duration;
            Color initialColor = sprite.color;
            while (Time.time < endTime)
            {
                sprite.color = new Color(initialColor.r, initialColor.g, initialColor.b,
                    ((endTime - Time.time) * initialColor.a + (Time.time - baseTime) * newAlpha) / duration);
                yield return null;
            }
        }
    }

    public static Vector2 SpriteDistance(Transform sprite1, Transform sprite2)
    {
        return sprite2.position - sprite1.position;
    }
}