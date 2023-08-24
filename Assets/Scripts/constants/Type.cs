using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Type
{
    public const byte Normal = 0;
    public const byte Fire = 1;
    public const byte Water = 2;
    public const byte Grass = 3;
    public const byte Electric = 4;
    public const byte Ice = 5;
    public const byte Ground = 6;
    public const byte Fighting = 7;
    public const byte Flying = 8;
    public const byte Rock = 9;
    public const byte Poison = 10;
    public const byte Bug = 11;
    public const byte Psychic = 12;
    public const byte Ghost = 13;
    public const byte Dragon = 14;
    public const byte Dark = 15;
    public const byte Steel = 16;
    public const byte Fairy = 17;
    public const byte Typeless = 255;
    private static readonly byte[,] typeChart = new byte[18, 18]
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
    
    public static float Effectiveness(byte Attacker, byte Defender)
    {
        if (Attacker < 18 && Defender < 18)
        {
            switch (typeChart[Attacker, Defender])
            {
                case 0: { return 0.0F; }
                case 1: { return 0.5F; }
                case 2: { return 1.0F; }
                case 3: { return 2.0F; }
            }
        }
        return 1.0F;
    }

    public static float GetTypeEffectiveness(ushort move, PokemonData defender)
    {
        return (defender.SpeciesData().type1 == defender.SpeciesData().type2) ?
            Effectiveness(Move.MoveTable[move].type, defender.SpeciesData().type1)
            : Effectiveness(Move.MoveTable[move].type, defender.SpeciesData().type1)
            * Effectiveness(Move.MoveTable[move].type, defender.SpeciesData().type2);
    }

    public static bool IsImmune(ushort move, PokemonData defender)
    {
        return GetTypeEffectiveness(move, defender) == 0;
    }
}