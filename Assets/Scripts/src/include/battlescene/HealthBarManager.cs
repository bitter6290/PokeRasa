using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using static System.Convert;

public class HealthBarManager : MonoBehaviour
{
    public Slider healthSlider;
    public Image healthBar;
    [SerializeField]
    private double duration;
    [SerializeField]
    private float interval;
    public bool changed = false;
    private float nextTime;

    public Battle battle;
    public int index;

    public void SetParameters(ushort HP, ushort maxHP)
    {
        healthSlider.minValue = -0.85F * maxHP;
        healthSlider.maxValue = maxHP;
        healthSlider.value = HP;
        UpdateColor();
    }
    public void SetSpeed()
    {
        duration = Sqrt(Abs(healthSlider.value - battle.PokemonOnField[index].PokemonData.HP) / 4.0F);
        interval = (float)Abs((healthSlider.value - battle.PokemonOnField[index].PokemonData.HP) / duration / 10.0F);
        changed = true;
    }
    public void UpdateColor()
    {
        switch (Floor(healthSlider.value * 4 / healthSlider.maxValue))
        {
            case 0:
                healthBar.color = HealthBarColors.Red;
                return;
            case 1:
                healthBar.color = HealthBarColors.Amber;
                return;
            case 2:
            case 3:
            case 4:
                healthBar.color = HealthBarColors.Green;
                return;
        }
    }
    public void Start()
    {
        UpdateColor();
    }
    public void Update()
    {
        healthSlider.minValue = -0.85F * battle.PokemonOnField[index].PokemonData.hpMax;
        healthSlider.maxValue = battle.PokemonOnField[index].PokemonData.hpMax;
        if (healthSlider.value == battle.PokemonOnField[index].PokemonData.HP)
        {
            changed = false;
            return;
        }
        else if (changed == false)
        {
            changed = true;
            SetSpeed();
        }
        else if (Time.time > nextTime)
        {
            healthSlider.value = Mathf.MoveTowards(healthSlider.value, battle.PokemonOnField[index].PokemonData.HP, interval);
            nextTime += 0.1F;
            UpdateColor();
        }

    }
}
