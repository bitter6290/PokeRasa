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
    public byte index;

    private float basePosition;


    public SpriteManager(Battle battle, SpriteRenderer sprite)
    {
        this.battle = battle;
        this.sprite = sprite;

    }

    private void updateSpecies()
    {
        Texture2D[] allTextures = Resources.LoadAll<Texture2D>("Sprites/Pokemon/" + Species.SpeciesTable[(int)currentMon].graphicsLocation);
        foreach (Texture2D i in allTextures)
        {
            if (isBack)
            {
                if (i.name == "back")
                {
                    Sprite1 = Sprite.Create(i, new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                    hasSecondFrame = false;
                }
            }
            else
            {
                if (i.name == "front_1")
                {
                    Sprite1 = Sprite.Create(i, new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                    hasSecondFrame = true;
                }
                if (i.name == "front_2")
                {
                    Sprite2 = Sprite.Create(i, new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                    hasSecondFrame = true;
                }
                if (i.name == "front")
                {
                    Sprite1 = Sprite.Create(i, new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                    hasSecondFrame = false;
                }
            }
        }
        if (isBack)
        {
            position.position = new Vector3(position.position.x, basePosition - (3 * Species.SpeciesTable[(int)currentMon].backSpriteHeight / 64.0F), position.position.z);
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
        if (currentMon != battle.PokemonOnField[index].PokemonData.species)
        {
            currentMon = battle.PokemonOnField[index].PokemonData.species;
            updateSpecies();
        }
        sprite.sprite = hasSecondFrame && secondFrame ? Sprite2 : Sprite1;
        sprite.enabled = battle.PokemonOnField[index].exists;
    }
}
