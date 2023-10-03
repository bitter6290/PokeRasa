using System;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "BehaviourTile", menuName = "ScriptableObjects/BehaviourTile", order = 1)]
public class BehaviourTile : Tile, IBehaviourObject
{
	[SerializeField]
	private TileBehaviour behaviour;
	public TileBehaviour Behaviour => behaviour;
}

