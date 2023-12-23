using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Transform position;
    public bool isBack;
    public bool secondFrame;

    [SerializeField]
    private SpeciesID currentMon;
    private bool hasSecondFrame;

    private Sprite Sprite1;
    private Sprite Sprite2;

    public Battle battle;
    public int index;
    public BattlePokemon TrackedMon => battle.PokemonOnField[index];

    private float basePosition;


    public SpriteManager(Battle battle, SpriteRenderer sprite)
    {
        this.battle = battle;
        this.sprite = sprite;

    }

    private void updateSpecies()
    {
        SpeciesData currentSpecies = currentMon.Data();
        if (isBack)
        {
            Sprite1 = currentSpecies.BackSprite;
            hasSecondFrame = false;
        }
        else
        {
            Sprite1 = currentSpecies.FrontSprite1;
            Sprite2 = currentSpecies.FrontSprite2;
        }
        if (isBack)
        {
            position.position = new Vector3(position.position.x, basePosition - (3 * currentSpecies.backSpriteHeight / 64.0F), position.position.z);
        }
    }
    // Start is called before the first frame update
    public void Start()
    {
        basePosition = position.position.y;
        updateSpecies();
    }

    // Update is called once per frame
    public void Update()
    {
        if (currentMon != TrackedMon.ApparentSpecies)
        {
            currentMon = TrackedMon.ApparentSpecies;
            updateSpecies();
        }
        sprite.sprite = hasSecondFrame && secondFrame ? Sprite2 : Sprite1;
        sprite.enabled = TrackedMon.exists;
    }
}
