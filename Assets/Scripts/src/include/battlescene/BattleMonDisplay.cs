using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BattleMonDisplay : MonoBehaviour
{
    public TextMeshProUGUI monName;
    public RawImage megaBox;
    public TextMeshProUGUI levelText;

    public void Adopt(Battle.BattlePokemon mon)
    {
        monName.enabled = true;
        monName.text = mon.ApparentName +
            mon.ApparentGender switch
            {
                Gender.Male => "<color=#A2CFFE><b>♂</b></color>",
                Gender.Female => "<color=#FFC0CB><b>♀</b></color>",
                _ => string.Empty
            };
        levelText.enabled = true;
        levelText.text = "Lv. " + mon.ApparentLevel;
        if (mon.ApparentSpecies.Data().speciesFlags.HasFlag(SpeciesFlags.MegaEvolved))
        {
            megaBox.enabled = true;
            megaBox.texture = BMDTextures.megaSymbol;
        }
        else if (mon.dynamaxed)
        {
            megaBox.enabled = true;
            megaBox.texture = BMDTextures.dynaSymbol;
        }
        else if (mon.pokemon.terastalized)
        {
            megaBox.enabled = true;
            megaBox.texture = mon.pokemon.TeraSymbol;
        }
        else megaBox.enabled = false;
    }

    public void Disable()
    {
        monName.enabled = false;
        levelText.enabled = false;
        megaBox.enabled = false;
    }
}

public static class BMDTextures
{
    public static Texture2D megaSymbol = Resources.Load<Texture2D>("Sprites/Battle/mega_symbol");
    public static Texture2D dynaSymbol = Resources.Load<Texture2D>("Sprites/Battle/dynamax");
}