using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void MovementHandler();

public abstract class LoadedChar : MonoBehaviour
{
    public abstract IEnumerator FaceNorth();
    public abstract IEnumerator FaceSouth();
    public abstract IEnumerator FaceEast();
    public abstract IEnumerator FaceWest();
    public abstract IEnumerator BumpNorth();
    public abstract IEnumerator BumpSouth();
    public abstract IEnumerator BumpEast();
    public abstract IEnumerator BumpWest();
    public abstract IEnumerator WalkNorth();
    public abstract IEnumerator WalkSouth();
    public abstract IEnumerator WalkEast();
    public abstract IEnumerator WalkWest();
    public abstract IEnumerator RunNorth();
    public abstract IEnumerator RunSouth();
    public abstract IEnumerator RunEast();
    public abstract IEnumerator RunWest();

    public IEnumerator DoPause(float duration)
    {
        moving = true;
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            AlignObject();
            yield return null;
        }
        moving = false;
    }

    public Player p;

    public System.Random random = new();

    public MapData currentMap;
    public Vector2Int pos;
    public CollisionID currentHeight;
    public Vector2Int moveTarget;
    public Direction facing;

    public CharData charData;

    public bool hasCollision;

    public Queue<MovementHandler> Actions;
    public bool Busy => Actions.Count > 0;
    public bool moving = false;
    public bool active;
    public bool free;
    public bool available;
    public bool doMove = true;
    public bool keepOnLoad;

    public GameObject charObject;
    public Transform charTransform => charObject.transform;
    public SpriteRenderer charRenderer;

    public Vector2Int GetFacingTile()
    {
        return facing switch
        {
            Direction.N => new Vector2Int(pos.x, pos.y + 1),
            Direction.S => new Vector2Int(pos.x, pos.y - 1),
            Direction.E => new Vector2Int(pos.x + 1, pos.y),
            Direction.W => new Vector2Int(pos.x - 1, pos.y),
            _ => new Vector2Int(pos.x, pos.y)
        };
    }

    public void UpdateCollision() => currentHeight = p.CheckCollision(pos, false);
    public void AlignObject() => charObject.transform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F, pos.y);

    public void MapChance(Vector2Int offset)
    {
        pos += offset;
        AlignObject();
    }

    public bool CheckForSight(LoadedChar c)
    {
        Vector2Int comparisonPos = p.pos - pos;
        switch (facing)
        {
            case Direction.N:
                if (comparisonPos.x == 0 && comparisonPos.y > 0 &&
                    comparisonPos.y <= charData.sightRadius)
                {
                    p.StartCoroutine(charData.OnSee(p, c));
                    return true;
                }
                break;
            case Direction.S:
                if (comparisonPos.x == 0 && comparisonPos.y < 0 &&
                    comparisonPos.y >= -charData.sightRadius)
                {
                    p.StartCoroutine(charData.OnSee(p, c));
                    return true;
                }
                break;
            case Direction.E:
                if (comparisonPos.y == 0 && comparisonPos.x > 0 &&
                    comparisonPos.x <= charData.sightRadius)
                {
                    p.StartCoroutine(charData.OnSee(p, c));
                    return true;
                }
                break;
            case Direction.W:
                if (comparisonPos.y == 0 && comparisonPos.x < 0 &&
                    comparisonPos.x >= -charData.sightRadius)
                {
                    p.StartCoroutine(charData.OnSee(p, c));
                    return true;
                }
                break;
        }
        return false;
    }

    public IEnumerator Unload()
    {
        yield return null;
        Debug.Log("Deleting" + charData.id);
        p.loadedChars.Remove(charData.id);
        Destroy(charObject);
        Destroy(this);
    }

    public void FacePlayer()
    {
        Vector2Int comparisonPos = p.pos - pos;
        if (comparisonPos == Vector2Int.up)
            StartCoroutine(FaceNorth());
        else if (comparisonPos == Vector2Int.down)
            StartCoroutine(FaceSouth());
        else if (comparisonPos == Vector2Int.left)
            StartCoroutine(FaceWest());
        else if (comparisonPos == Vector2Int.right)
            StartCoroutine(FaceEast());
    }

    public void FaceAndLock()
    {
        FacePlayer();
        free = false;
    }


    public void CheckTileBehavior(Vector2Int pos)
    {
        if (p.mapManager.level1.GetTile(new Vector3Int(2 * pos.x, 2 * pos.y, 0)) is IBehaviourObject)
            switch (((IBehaviourObject)p.mapManager.level1.GetTile(new Vector3Int(2 * pos.x, 2 * pos.y, 0))).Behaviour)
            {
                case TileBehaviour.StartGrassAnimation:
                    p.StartCoroutine(TriggeredTileAnim.TallGrassShake(pos, this));
                    break;
            }
    }

    public IEnumerator WalkInDirection()
    {
        switch (facing)
        {
            case Direction.N: yield return WalkNorth(); break;
            case Direction.S: yield return WalkSouth(); break;
            case Direction.W: yield return WalkWest(); break;
            case Direction.E: yield return WalkEast(); break;
        }
    }

    public void TryWalkNorth()
    {
        facing = Direction.N;
        if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            Actions.Dequeue();
            StartCoroutine(WalkNorth());
        }
        else
        {
            if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight, false))
                Actions.Dequeue();
            StartCoroutine(BumpNorth());
        }
    }

    public void TryWalkSouth()
    {
        facing = Direction.S;
        if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            Actions.Dequeue();
            StartCoroutine(WalkSouth());
        }
        else
        {
            if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight, false))
                Actions.Dequeue();
            StartCoroutine(BumpSouth());
        }
    }

    public void TryWalkWest()
    {
        facing = Direction.W;
        if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            Actions.Dequeue();
            StartCoroutine(WalkWest());
        }
        else
        {
            if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight, false))
                Actions.Dequeue();
            StartCoroutine(BumpWest());
        }
    }

    public void TryWalkEast()
    {
        facing = Direction.E;
        if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            Actions.Dequeue();
            StartCoroutine(WalkEast());
        }
        else
        {
            if (p.CheckCollisionAllowed(GetFacingTile(), currentHeight, false))
                Actions.Dequeue();
            StartCoroutine(BumpEast());
        }
    }

    public void Deactivate()
    {
        charRenderer.enabled = false;
        active = false;
    }

    public void Activate()
    {
        charRenderer.enabled = true;
        active = true;
    }

    public void Pause(float time) { StartCoroutine(DoPause(time)); Actions.Dequeue(); }

    public void Update()
    {
        if (active && free && !moving)
        {
            if (charData.hasSeeScript)
            {
                if (charData.SeeCheck(p))
                {
                    if (CheckForSight(this)) return;
                }
            }
            if (Busy)
                Actions.Peek()();
            else if (doMove)
                AlignObject();
                charData.GetMovement(this);
        }
    }
}