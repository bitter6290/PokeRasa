using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement
{
    public HumanoidGraphics movementSprites;
    public GameObject playerObject;
    public Transform playerTransform => playerObject.GetComponent<Transform>();
    public SpriteRenderer playerSprite => playerObject.GetComponent<SpriteRenderer>();
    public PlayerMovement(Player p, HumanoidGraphics graphics)
    {
        playerObject = new("Player Graphics");
        playerObject.AddComponent<SpriteRenderer>();
        playerSprite.enabled = true;
        playerSprite.sortingLayerID = 0;
        playerSprite.sortingOrder = 0;
        SwitchGraphics(graphics);
        playerSprite.sprite = p.facing switch
        {
            Direction.S => movementSprites.stillSouth,
            Direction.N => movementSprites.stillNorth,
            Direction.E => movementSprites.stillEast,
            Direction.W => movementSprites.stillWest,
            _ => movementSprites.stillWest,
        };
    }
    public void SwitchGraphics(HumanoidGraphics graphics)
    {
        movementSprites = graphics;
    }
    public IEnumerator WalkNorth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.N;
        p.moveTarget = p.GetFacingTile();
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillNorth;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkNorthL : movementSprites.walkNorthR;
            playerTransform.position = new Vector3(initialPosition.x, initialPosition.y + progress, initialPosition.z);
            yield return null;
        }
        p.pos.y++;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkSouth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.S;
        p.moveTarget = p.GetFacingTile();
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillSouth;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkSouthL : movementSprites.walkSouthR;
            playerTransform.position = new Vector3(initialPosition.x, initialPosition.y - progress, initialPosition.z);
            yield return null;
        }
        p.pos.y--;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkWest(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.W;
        p.moveTarget = p.GetFacingTile();
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillWest;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkWestL : movementSprites.walkWestR;
            playerTransform.position = new Vector3(initialPosition.x - progress, initialPosition.y, initialPosition.z);
            yield return null;
        }
        p.pos.x--;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkEast(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.E;
        p.moveTarget = p.GetFacingTile();
        p.whichStep = !p.whichStep;
        playerSprite.flipX = movementSprites.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillEast;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkEastL : movementSprites.walkEastR;
            playerTransform.position = new Vector3(initialPosition.x + progress, initialPosition.y, initialPosition.z);
            yield return null;
        }
        p.pos.x++;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator BumpNorth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.N;
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillNorth;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkNorthL : movementSprites.walkNorthR;
            yield return null;
        }
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator BumpSouth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.S;
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillSouth;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkSouthL : movementSprites.walkSouthR;
            yield return null;
        }
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator BumpWest(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.W;
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillWest;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkWestL : movementSprites.walkWestR;
            yield return null;
        }
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator BumpEast(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.facing = Direction.E;
        p.whichStep = !p.whichStep;
        playerSprite.flipX = movementSprites.flipOnWalkEast;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillEast;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkEastL : movementSprites.walkEastR;
            yield return null;
        }
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator FaceNorth(Player p, float duration)
    {
        playerSprite.sprite = movementSprites.stillNorth;
        playerSprite.flipX = false;
        p.state = PlayerState.Moving;
        p.facing = Direction.N;
        yield return new WaitForSeconds(duration);
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator FaceSouth(Player p, float duration)
    {
        playerSprite.sprite = movementSprites.stillSouth;
        playerSprite.flipX = false;
        p.state = PlayerState.Moving;
        p.facing = Direction.S;
        yield return new WaitForSeconds(duration);
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator FaceWest(Player p, float duration)
    {
        playerSprite.sprite = movementSprites.stillWest;
        playerSprite.flipX = false;
        p.state = PlayerState.Moving;
        p.facing = Direction.W;
        yield return new WaitForSeconds(duration);
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator FaceEast(Player p, float duration)
    {
        playerSprite.sprite = movementSprites.stillEast;
        playerSprite.flipX = movementSprites.flipOnWalkEast;
        p.state = PlayerState.Moving;
        p.facing = Direction.E;
        yield return new WaitForSeconds(duration);
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
}