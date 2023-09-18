using System;
using System.Collections;
using UnityEngine;

public class PlayerGraphics
{
    public HumanoidGraphics movementSprites;
    public GameObject playerObject;
    public Transform playerTransform => playerObject.GetComponent<Transform>();
    public SpriteRenderer playerSprite => playerObject.GetComponent<SpriteRenderer>();
    public PlayerGraphics(Player p, HumanoidGraphicsID graphicsID)
    {
        playerObject = new("Player Graphics");
        playerObject.AddComponent<SpriteRenderer>();
        playerSprite.enabled = true;
        playerSprite.sortingLayerID = 0;
        playerSprite.sortingOrder = 0;
        SwitchGraphics(graphicsID);
        playerSprite.sprite = movementSprites.stillSouth;
    }
    public void SwitchGraphics(HumanoidGraphicsID id)
    {
        movementSprites = id.Graphics();
    }
    public IEnumerator WalkNorth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
        p.whichStep = !p.whichStep;
        playerSprite.flipX = false;
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        Vector3 initialPosition = playerTransform.position;
        while(Time.time < endTime)
        {
            float progress = (Time.time - baseTime) / duration;
            if (progress > 0.5F)
                playerSprite.sprite = movementSprites.stillNorth;
            else playerSprite.sprite = p.whichStep
                    ? movementSprites.walkNorthL : movementSprites.walkNorthR;
            playerTransform.position = new Vector3(initialPosition.x, initialPosition.y + progress, initialPosition.z);
            yield return null;
        }
        p.yPos++;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkSouth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
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
        p.yPos--;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkWest(Player p, float duration)
    {
        p.state = PlayerState.Moving;
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
        p.xPos--;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator WalkEast(Player p, float duration)
    {
        p.state = PlayerState.Moving;
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
        p.xPos++;
        p.state = p.locked ? PlayerState.Locked : PlayerState.Free;
    }
    public IEnumerator BumpNorth(Player p, float duration)
    {
        p.state = PlayerState.Moving;
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
}