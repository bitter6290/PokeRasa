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
        moveTarget = pos + Vector2Int.up;
        available = false;
        facing = Direction.N;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillNorth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkNorthL : graphics.walkNorthR;
            charTransform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F + progress, pos.y);
            yield return null;
        }
        pos.y++;
        UpdateCollision();
        AlignObject();
        moving = false;
        available = true;
    }
    public override IEnumerator WalkSouth()
    {
        moving = true;
        moveTarget = pos + Vector2Int.down;
        available = false;
        facing = Direction.S;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillSouth;
            else charRenderer.sprite = whichStep
                    ? graphics.walkSouthL : graphics.walkSouthR;
            charTransform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F - progress, pos.y);
            yield return null;
        }
        pos.y--;
        UpdateCollision();
        AlignObject();
        moving = false;
        available = true;
    }
    public override IEnumerator WalkWest()
    {
        moving = true;
        moveTarget = pos + Vector2Int.left;
        available = false;
        facing = Direction.W;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillWest;
            else charRenderer.sprite = whichStep
                    ? graphics.walkWestL : graphics.walkWestR;
            charTransform.position = new Vector3(pos.x + 0.5F - progress, pos.y + 0.5F, pos.y);
            yield return null;
        }
        pos.x--;
        UpdateCollision();
        AlignObject();
        moving = false;
        available = true;
    }
    public override IEnumerator WalkEast()
    {
        moving = true;
        moveTarget = pos + Vector2Int.right;
        available = false;
        facing = Direction.E;
        whichStep = !whichStep;
        charRenderer.flipX = graphics.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / 0.3F;
            if (progress > 0.5F)
                charRenderer.sprite = graphics.stillEast;
            else charRenderer.sprite = whichStep
                    ? graphics.walkEastL : graphics.walkEastR;
            charTransform.position = new Vector3(pos.x + 0.5F + progress, pos.y + 0.5F, pos.y);
            yield return null;
        }
        pos.x++;
        UpdateCollision();
        AlignObject();
        moving = false;
        available = true;
    }
    public override IEnumerator BumpNorth()
    {
        moving = true;
        available = true;
        facing = Direction.N;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
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
        available = true;
        facing = Direction.S;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
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
        available = true;
        facing = Direction.W;
        whichStep = !whichStep;
        charRenderer.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
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
        available = true;
        facing = Direction.E;
        whichStep = !whichStep;
        charRenderer.flipX = graphics.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + 0.3F;
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
        charRenderer.flipX = false;
        facing = Direction.N;
        moving = false;
        available = true;
        yield break;
    }
    public override IEnumerator FaceSouth()
    {
        charRenderer.sprite = graphics.stillSouth;
        charRenderer.flipX = false;
        facing = Direction.S;
        moving = false;
        available = true;
        yield break;
    }
    public override IEnumerator FaceWest()
    {
        charRenderer.sprite = graphics.stillWest;
        charRenderer.flipX = false;
        facing = Direction.W;
        moving = false;
        available = true;
        yield break;
    }
    public override IEnumerator FaceEast()
    {
        charRenderer.sprite = graphics.stillEast;
        charRenderer.flipX = graphics.flipOnWalkEast;
        facing = Direction.E;
        moving = false;
        available = true;
        yield break;
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