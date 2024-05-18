using UnityEngine;
using UnityEngine.Tilemaps;

public class StatusManager : MonoBehaviour
{
    public SpriteRenderer statusbar;
    public TilemapRenderer bubbleRenderer;
    public Battle battle;
    public int index;
    [SerializeField]
    private Status currentStatus;

    public StatusManager(SpriteRenderer Statusbar, Battle Battle, int Index, Sprite[] sprites)
    {
        statusbar = Statusbar;
        battle = Battle;
        index = Index;
        currentStatus = Status.None;
    }

    // Update is called once per frame
    public void Update()
    {
        statusbar.enabled = battle.PokemonOnField[index].exists;
        bubbleRenderer.enabled = battle.PokemonOnField[index].exists;
        if (currentStatus != battle.PokemonOnField[index].pokemon.status)
        {
            currentStatus = battle.PokemonOnField[index].pokemon.status;
            statusbar.sprite = currentStatus.ToSprite();
            statusbar.color = currentStatus == Status.ToxicPoison
                ? new Color(180.0F / 255.0F, 180.0F / 255.0F, 180.0F / 255.0F)
                : new Color(1, 1, 1);

        }
    }
}
