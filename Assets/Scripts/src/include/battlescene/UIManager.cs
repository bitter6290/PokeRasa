using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI[] textBoxes = new TextMeshProUGUI[6];
    public TextMeshProUGUI[] levelBoxes = new TextMeshProUGUI[6];
    public TextMeshProUGUI hpBox;
    public Battle battle;

    private string LeadingZero2(string input)
    {
        switch (input.Length)
        {
            case 1:
                return "00" + input;
            case 2:
                return "0" + input;
            default:
                return input;
        }
    }

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].exists)
            {
                textBoxes[i].enabled = true;
                textBoxes[i].text = battle.PokemonOnField[i].PokemonData.monName;
                levelBoxes[i].enabled = true;
                levelBoxes[i].text = "Lv. " + battle.PokemonOnField[i].PokemonData.level;
                if (i == 3)
                {
                    hpBox.enabled = battle.battleType == BattleType.Single;
                    hpBox.text = LeadingZero2(battle.PokemonOnField[3].PokemonData.HP.ToString()) + " / "
                        + LeadingZero2(battle.PokemonOnField[3].PokemonData.hpMax.ToString());
                }
            }
            else
            {
                textBoxes[i].enabled = false;
                levelBoxes[i].enabled = false;
                if (i == 3)
                {
                    hpBox.enabled = false;
                }
            }
        }
    }
}
