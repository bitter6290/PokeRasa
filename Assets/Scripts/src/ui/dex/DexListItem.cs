using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DexListItem : MonoBehaviour
{
    [SerializeField]
    private Image caughtImage;
    [SerializeField]
    private TextMeshProUGUI monName;

    public void Adopt(Player p, SpeciesID species)
    {
        gameObject.SetActive(true);
        if (species.Data().pokedexData.ShowEntry(p))
        {
            monName.text = ((int)species).LeadingZero4() + " " + species.Data().speciesName;
            caughtImage.enabled = species.Data().pokedexData.ShowCaught(p);
        }
        else
        {
            monName.text = ((int)species).LeadingZero4() + " -----";
            caughtImage.enabled = false;
        }
    }

    public void Disable() => gameObject.SetActive(false);
}
