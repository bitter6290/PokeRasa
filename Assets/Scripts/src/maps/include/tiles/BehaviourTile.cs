using UnityEngine;

[CreateAssetMenu(fileName = "BehaviourTile", menuName = "ScriptableObjects/BehaviourTile", order = 1)]
public class BehaviourTile : UnityEngine.Tilemaps.Tile, IBehaviourObject
{
    [SerializeField]
    private TileBehaviour behaviour;
    public TileBehaviour Behaviour => behaviour;
}