using UnityEngine;
using UnityEngine.Tilemaps;
using static TileConfig;

public class AnimatedIndexedTile : AnimatedTile, IIndexedObject, IBehaviourObject
{
    public TileID tileID;
    public int Index => (int)tileID;
    public TileBehaviour tileBehaviour;
    public TileBehaviour Behaviour => tileBehaviour;


    public static AnimatedIndexedTile Create(TileID id, Sprite[] sprites, float speed, TileBehaviour behaviour = TileBehaviour.None)
    {
        AnimatedIndexedTile tile = CreateInstance<AnimatedIndexedTile>();
        tile.m_AnimatedSprites = sprites;
        tile.tileID = id;
        tile.tileBehaviour = behaviour;
        tile.m_MaxSpeed = speed;
        tile.m_MinSpeed = speed;
        return tile;
    }
}