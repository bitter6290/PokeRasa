using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void MovementHandler(Player p, LoadedChar charToMove);

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

    public Player p;

    public int index;
    public MapID mapID;
    public int CharID => index + ((int)mapID << 16);

    public Vector2Int pos;
    public Vector2Int moveTarget;
    public Direction facing;

    public CharData charData;

    public bool hasCollision;
    public bool hasSeeScript;
    public int sightRadius;

    public Queue<MovementHandler> Actions;
    public bool Busy => Actions.Count > 0;
    public bool moving = false;
    public bool active;
    public bool free;
    public bool keepOnLoad;

    public GameObject charObject;
    public Transform charTransform => charObject.transform;
    public SpriteRenderer charRenderer;

    public void AlignObject() => charObject.transform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F, pos.y);

    public void MapChance(Vector2Int offset)
    {
        pos += offset;
        AlignObject();
    }

    public void Unload()
    {
        Destroy(charObject);
        Destroy(this);
    }

    public void Update()
    {
        if (active && free && !moving && !Busy)
        {
            Actions.Dequeue()(p, this);
        }
    }
}