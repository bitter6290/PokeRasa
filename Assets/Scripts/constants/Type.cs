using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Ground,
    Fighting,
    Flying,
    Rock,
    Poison,
    Bug,
    Psychic,
    Ghost,
    Dragon,
    Dark,
    Steel,
    Fairy,

    Typeless = 63
}

public static class TypeUtils
{
    private static readonly int[,] typeChart = new int[18, 18]
        {{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 0, 2, 2, 1, 2 }, //Normal
         { 2, 1, 1, 3, 2, 3, 2, 2, 2, 1, 2, 3, 2, 2, 1, 2, 3, 2 }, //Fire
         { 2, 3, 1, 1, 2, 2, 3, 2, 2, 3, 2, 2, 2, 2, 1, 2, 2, 2 }, //Water
         { 2, 1, 3, 1, 2, 2, 3, 2, 1, 3, 1, 1, 2, 2, 1, 2, 1, 2 }, //Grass
         { 2, 2, 3, 1, 1, 2, 0, 2, 3, 2, 2, 2, 2, 2, 1, 2, 2, 2 }, //Electric
         { 2, 1, 1, 3, 2, 1, 3, 2, 3, 2, 2, 2, 2, 2, 3, 2, 1, 2 }, //Ice
         { 2, 3, 2, 1, 3, 2, 2, 2, 0, 3, 3, 1, 2, 2, 2, 2, 3, 2 }, //Ground
         { 3, 2, 2, 2, 2, 3, 2, 2, 1, 3, 1, 1, 1, 0, 2, 3, 3, 1 }, //Fighting
         { 2, 2, 2, 3, 1, 2, 2, 3, 2, 1, 2, 3, 2, 2, 2, 2, 1, 2 }, //Flying
         { 2, 3, 2, 2, 2, 3, 1, 1, 3, 2, 2, 3, 2, 2, 2, 2, 1, 2 }, //Rock
         { 2, 2, 2, 3, 2, 2, 1, 2, 2, 1, 1, 2, 2, 1, 2, 2, 0, 3 }, //Poison
         { 2, 1, 2, 3, 2, 2, 2, 1, 1, 2, 1, 2, 3, 1, 2, 3, 1, 1 }, //Bug
         { 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 3, 2, 1, 2, 2, 0, 1, 2 }, //Psychic
         { 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 1, 2, 2 }, //Ghost
         { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 1, 0 }, //Dragon
         { 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 3, 3, 2, 1, 2, 1 }, //Dark
         { 2, 1, 1, 2, 1, 3, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 1, 3 }, //Steel
         { 2, 1, 2, 2, 2, 2, 2, 3, 2, 2, 1, 2, 2, 2, 3, 3, 1, 2 }  //Fairy
        };

    public static readonly string[] typeName = new string[18]
    {
        "Normal",
        "Fire",
        "Water",
        "Grass",
        "Electric",
        "Ice",
        "Ground",
        "Fighting",
        "Flying",
        "Rock",
        "Poison",
        "Bug",
        "Psychic",
        "Ghost",
        "Dragon",
        "Dark",
        "Steel",
        "Fairy"
    };

    public static readonly Color[] typeColor = new Color[18]
    {
        new Color(242F/255F, 242F/255F, 242F/255F), //Normal
        new Color(1, 110F/255F, 43F/255F),          //Fire
        new Color(45F/255F, 51F/255F, 224F/255F),   //Water
        new Color(44F/255F, 176F/255F, 57F/255F),   //Grass
        new Color(1, 1, 0),                         //Electric
        new Color(82F/255F, 1, 1),                  //Ice
        new Color(232F/255F, 205F/255F, 130F/255F), //Ground
        new Color(184F/255F, 30F/255F, 28F/255F),   //Fighting
        new Color(201F/255F, 157F/255F, 250F/255F), //Flying
        new Color(156F/255F, 96F/255F, 36F/255F),   //Rock
        new Color(133F/255F, 27F/255F, 166F/255F),  //Poison
        new Color(183F/255F, 250/255F, 40F/255F),   //Bug
        new Color(252F/255F, 43F/255F, 137F/255F),  //Psychic
        new Color(117F/255F, 64F/255F, 135F/255F),  //Ghost
        new Color(147F/255F, 27F/255F, 245F/255F),  //Dragon
        new Color(64F/255F, 64F/255F, 64F/255F),    //Dark
        new Color(176F/255F, 180F/255F, 181F/255F), //Steel
        new Color(247F/255F, 195F/255F, 232F/255F), //Fairy

    };

    public static float Effectiveness(Type Attacker, Type Defender)
    {
        if ((int)Attacker < 18 && (int)Defender < 18)
        {
            switch (typeChart[(int)Attacker, (int)Defender])
            {
                case 0: { return 0.0F; }
                case 1: { return 0.5F; }
                case 2: { return 1.0F; }
                case 3: { return 2.0F; }
            }
        }
        return 1.0F;
    }

}