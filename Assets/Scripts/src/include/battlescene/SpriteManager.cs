using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Transform position;
    public bool isBack;
    public bool secondFrame;

    [SerializeField]
    private SpeciesData.PokemonGraphics graphics;
    private bool hasSecondFrame;

    private Sprite Sprite1;
    private Sprite Sprite2;

    public Battle battle;
    public int index;
    public Battle.BattlePokemon TrackedMon => battle.PokemonOnField[index];

    private float basePosition;

    private void UpdateSpecies()
    {
        if (isBack)
        {
            Sprite1 = graphics.backSprite;
            hasSecondFrame = false;
        }
        else
        {
            Sprite1 = graphics.frontSprite1;
            Sprite2 = graphics.frontSprite2;
        }
        if (isBack)
        {
            position.position = new Vector3(position.position.x, basePosition - (3 * graphics.backSpriteHeight / 64.0F), position.position.z);
        }
    }
    // Start is called before the first frame update
    public void Start()
    {
        basePosition = position.position.y;
        UpdateSpecies();
    }

    // Update is called once per frame
    public void Update()
    {
        if (graphics != TrackedMon.Graphics)
        {
            graphics = TrackedMon.Graphics;
            UpdateSpecies();
        }
        sprite.sprite = hasSecondFrame && secondFrame ? Sprite2 : Sprite1;
        sprite.enabled = TrackedMon.exists;
    }
}
