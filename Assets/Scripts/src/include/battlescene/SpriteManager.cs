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
        if (isBack)
        {
            Sprite1 = Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + Species.SpeciesTable[(int)currentMon].graphicsLocation +
                (TrackedMon.PokemonData.UsesFemaleSprites ? "/backf" : "/back")),
                new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
            hasSecondFrame = false;
        }
        else
        {
            Texture2D test = Resources.Load<Texture2D>("Sprites/Pokemon/" + Species.SpeciesTable[(int)currentMon].graphicsLocation +
                (TrackedMon.PokemonData.UsesFemaleSprites ? "/anim_frontf" : "/anim_front"));
            if (test == null)
            {
                Sprite1 = Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + Species.SpeciesTable[(int)currentMon].graphicsLocation +
                    (TrackedMon.PokemonData.UsesFemaleSprites ? "/frontf" : "/front")),
                    new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                hasSecondFrame = false;
            }
            else
            {
                Sprite1 = Sprite.Create(test, new Rect(0.0f, 64.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                Sprite2 = Sprite.Create(test, new Rect(0.0f, 0.0f, 64.0f, 64.0f), new Vector2(0.5f, 0.5f), 64.0f);
                hasSecondFrame = true;
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
        if (currentMon != TrackedMon.ApparentSpecies)
        {
            currentMon = TrackedMon.ApparentSpecies;
            updateSpecies();
        }
        sprite.sprite = hasSecondFrame && secondFrame ? Sprite2 : Sprite1;
        sprite.enabled = TrackedMon.exists;
    }
}
