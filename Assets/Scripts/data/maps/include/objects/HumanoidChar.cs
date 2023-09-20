using System;
using System.Collections;
using UnityEngine;

public class HumanoidChar : LoadedChar
{
    public bool whichStep;

    public HumanoidGraphics graphics;

    public override IEnumerator WalkNorth()
    {
        moving = true;
        facing = Direction.N;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillNorth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkNorthL : graphics.walkNorthR;
            charTransform.position = new Vector3(initialPosition.x, initialPosition.y + progress, initialPosition.z);
            yield return null;
        }
        pos.y++;
        moving = false;
    }
    public override IEnumerator WalkSouth()
    {
        moving = true;
        facing = Direction.S;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillSouth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkSouthL : graphics.walkSouthR;
            charTransform.position = new Vector3(initialPosition.x, initialPosition.y - progress, initialPosition.z);
            yield return null;
        }
        pos.y--;
        moving = false;
    }
    public override IEnumerator WalkWest()
    {
        moving = true;
        facing = Direction.W;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillWest;
            else charRenderer.sprite = whichStep
                    ? graphics.walkWestL : graphics.walkWestR;
            charTransform.position = new Vector3(initialPosition.x - progress, initialPosition.y, initialPosition.z);
            yield return null;
        }
        pos.x--;
        moving = false;
    }
    public override IEnumerator WalkEast()
    {
        moving = true;
        facing = Direction.E;
        whichStep = !whichStep;
        charRenderer.flipX = graphics.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillEast;
            else charRenderer.sprite = whichStep
                    ? graphics.walkEastL : graphics.walkEastR;
            charTransform.position = new Vector3(initialPosition.x + progress, initialPosition.y, initialPosition.z);
            yield return null;
        }
        pos.x++;
        moving = false;
    }
    public override IEnumerator BumpNorth()
    {
        moving = true;
        facing = Direction.N;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillNorth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkNorthL : graphics.walkNorthR;
            yield return null;
        }
        moving = false;
    }
    public override IEnumerator BumpSouth()
    {
        moving = true;
        facing = Direction.S;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillSouth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkSouthL : graphics.walkSouthR;
            yield return null;
        }
        moving = false;
    }
    public override IEnumerator BumpWest()
    {
        moving = true;
        facing = Direction.W;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillWest;
            else charRenderer.sprite = whichStep
                    ? graphics.walkWestL : graphics.walkWestR;
            yield return null;
        }
        moving = false;
    }
    public override IEnumerator BumpEast()
    {
        moving = true;
        facing = Direction.E;
        whichStep = !whichStep;
        charRenderer.flipX = graphics.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        Vector3 initialPosition = charTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillEast;
            else charRenderer.sprite = whichStep
                    ? graphics.walkEastL : graphics.walkEastR;
            yield return null;
        }
        moving = false;
    }
    public override IEnumerator FaceNorth()
    {
        charRenderer.sprite = graphics.stillNorth;
        moving = true;
        facing = Direction.N;
        yield return new WaitForSeconds(0.3F);
        moving = false;
    }
    public override IEnumerator FaceSouth()
    {
        charRenderer.sprite = graphics.stillSouth;
        moving = true;
        facing = Direction.S;
        yield return new WaitForSeconds(0.3F);
        moving = false;
    }
    public override IEnumerator FaceWest()
    {
        charRenderer.sprite = graphics.stillWest;
        moving = true;
        facing = Direction.W;
        yield return new WaitForSeconds(0.3F);
        moving = false;
    }
    public override IEnumerator FaceEast()
    {
        charRenderer.sprite = graphics.stillEast;
        charRenderer.flipX = graphics.flipOnWalkEast;
        moving = true;
        facing = Direction.E;
        yield return new WaitForSeconds(0.3F);
        moving = false;
    }
    public override IEnumerator RunNorth()
    {
        yield break;
    }
    public override IEnumerator RunSouth()
    {
        yield break;
    }
    public override IEnumerator RunEast()
    {
        yield break;
    }
    public override IEnumerator RunWest()
    {
        yield break;
    }
}