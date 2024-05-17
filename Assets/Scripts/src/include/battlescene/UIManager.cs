using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public BattleMonDisplay[] displays = new BattleMonDisplay[6];
    public TextMeshProUGUI hpBox;
    public Battle battle;

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].exists)
            {
                displays[i].Adopt(battle.PokemonOnField[i]);
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
                if (displays[i] == null) continue;
                displays[i].Disable();
                if (i == 3)
                {
                    hpBox.enabled = false;
                    battle.xpController.spriteRenderer.enabled = false;
                }
            }
        }
    }
}
