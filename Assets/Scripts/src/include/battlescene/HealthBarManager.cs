using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using static System.Convert;

public class HealthBarManager : MonoBehaviour
{
    public RawImage healthBar;
    [SerializeField]
    private double duration;
    [SerializeField]
    private float interval;
    [SerializeField]
    private GameObject wholeBar;
    public bool changed = false;
    private float nextTime;

    public Battle battle;
    public int index;

    private Pokemon Mon => battle.PokemonOnField[index].PokemonData;

    public void Update()
    {
        wholeBar.SetActive(battle.PokemonOnField[index].exists);
        healthBar.transform.localScale = new((float)Mon.HP / Mon.hpMax, 1, 1);
        switch (((Mon.HP * 4) - 1) / Mon.hpMax)
        {
            case 0:
                healthBar.color = HealthBarColors.Red;
                return;
            case 1:
                healthBar.color = HealthBarColors.Amber;
                return;
            default:
                healthBar.color = HealthBarColors.Green;
                return;
        }
    }
}
