using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public SpriteRenderer statusbar;
    public Battle battle;
    public int index;
    public Sprite[] sprites = new Sprite[6];
    [SerializeField]
    private byte currentStatus;

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
        if (currentStatus != battle.PokemonOnField[index].PokemonData.status)
        {
            currentStatus = battle.PokemonOnField[index].PokemonData.status;
            switch (currentStatus)
            {
                case Status.None:
                    statusbar.sprite = sprites[0];
                    break;
                case Status.Poison:
                case Status.ToxicPoison:
                    statusbar.sprite = sprites[1];
                    break;
                case Status.Paralysis:
                    statusbar.sprite = sprites[2];
                    break;
                case Status.Sleep:
                    statusbar.sprite = sprites[3];
                    break;
                case Status.Freeze:
                    statusbar.sprite = sprites[4];
                    break;
                case Status.Burn:
                    statusbar.sprite = sprites[5];
                    break;
            }
            statusbar.color = currentStatus == Status.ToxicPoison
                ? new Color(180.0F / 255.0F, 180.0F / 255.0F, 180.0F / 255.0F)
                : new Color(1, 1, 1);

        }
    }
}
