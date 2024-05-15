using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI[] textBoxes = new TextMeshProUGUI[6];
    public TextMeshProUGUI[] levelBoxes = new TextMeshProUGUI[6];
    public TextMeshProUGUI hpBox;
    public Battle battle;

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].exists)
            {
                textBoxes[i].enabled = true;
                textBoxes[i].text = battle.PokemonOnField[i].ApparentName;
                levelBoxes[i].enabled = true;
                levelBoxes[i].text = "Lv. " + battle.PokemonOnField[i].ApparentLevel;
                if (i == 3)
                {
                    if (battle.battleType == Battle.BattleType.Single)
                    {
                        hpBox.enabled = true;
                        hpBox.text = battle.PokemonOnField[3].HP.ToString().LeadingZero2() + " / "
                            + battle.PokemonOnField[3].HPMax.ToString().LeadingZero2();
                        battle.xpController.spriteRenderer.enabled = true;
                    }
                    else
                    {
                        hpBox.enabled = false;
                        battle.xpController.spriteRenderer.enabled = false;
                    }
                }
            }
            else
            {
                textBoxes[i].enabled = false;
                levelBoxes[i].enabled = false;
                if (i == 3)
                {
                    hpBox.enabled = false;
                    battle.xpController.spriteRenderer.enabled = false;
                }
            }
        }
    }
}
