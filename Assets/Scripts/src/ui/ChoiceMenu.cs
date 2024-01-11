using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class ChoiceMenu : MonoBehaviour
{
    private const int maxVisibleChoices = 6;

    private (string name, int result)[] choices;
    private int cachedCount;
    private int cancelChoice;
    private DataStore<int> dataStore;

    private List<TextMeshProUGUI> textBoxes;

    private int currentPosition;
    private int currentSelection;
    private int currentChoice => currentPosition + currentSelection;

    private GameObject selector;
    private RectTransform selectorTransform;

    private new AudioSource audio;

    private bool done;

    public static IEnumerator DoChoiceMenu(Player p, List<(string name, int result)> choices,
        int cancelChoice, DataStore<int> dataStore, Transform parent, Vector2 position, Vector2 pivot,
        GameObject newParent = null) // newParent should be high in the render hierarchy
                                     // (low on the inspector list) so that the menu
                                     // shows up above everything else
    {
        GameObject menu = new("Choice Menu", typeof(RectTransform));
        ChoiceMenu choiceMenu = menu.AddComponent<ChoiceMenu>();
        choiceMenu.choices = choices.ToArray();
        choiceMenu.cancelChoice = cancelChoice;
        choiceMenu.cachedCount = choices.Count;
        choiceMenu.dataStore = dataStore;
        RectTransform menuTransform = menu.GetComponent<RectTransform>();
        choiceMenu.audio = p.audioSource;
        RawImage image = menu.AddComponent<RawImage>();
        image.color = new(255, 255, 255, 144);
        menuTransform.SetParent(parent);
        menuTransform.pivot = pivot;
        menuTransform.localScale = Vector3.one;
        menuTransform.localPosition = position;
        menuTransform.sizeDelta = new(160, 40 * Mathf.Min(choiceMenu.cachedCount, maxVisibleChoices));
        menuTransform.SetPivot(new(1, 0));
        choiceMenu.currentPosition = 0;
        choiceMenu.currentSelection = 0;
        choiceMenu.textBoxes = new();
        for (int i = 0; i < Mathf.Min(choiceMenu.cachedCount, maxVisibleChoices); i++)
        {
            GameObject textObject = new();
            RectTransform objTransform = textObject.AddComponent<RectTransform>();
            objTransform.SetParent(menuTransform);
            objTransform.sizeDelta = new(120, 36);
            objTransform.localScale = Vector3.one;
            objTransform.pivot = new(1, 0);
            TextMeshProUGUI textMesh = textObject.AddComponent<TextMeshProUGUI>();
            textMesh.fontSize = 24;
            textMesh.color = Color.black;
            textMesh.verticalAlignment = VerticalAlignmentOptions.Middle;
            objTransform.localPosition = new(0, 40 * i + 2);
            choiceMenu.textBoxes.Add(textMesh);
        }
        choiceMenu.selector = new();
        choiceMenu.selectorTransform = choiceMenu.selector.AddComponent<RectTransform>();
        choiceMenu.selectorTransform.SetParent(menuTransform);
        choiceMenu.selectorTransform.pivot = new(1, 0);
        choiceMenu.selectorTransform.sizeDelta = new(40, 40);
        choiceMenu.selectorTransform.localScale = Vector3.one;
        RawImage selectorImage = choiceMenu.selector.AddComponent<RawImage>();
        selectorImage.texture = MenuGraphics.selectorArrow;
        choiceMenu.UpdateSelection();
        if (newParent != null) menuTransform.SetParent(newParent.transform, worldPositionStays: true);
        while (!choiceMenu.done) yield return null;
        Destroy(menu);
    }

    private void UpdateSelection()
    {
        int i = 0;
        foreach (TextMeshProUGUI textBox in textBoxes)
        {
            textBox.text = choices[currentPosition + i].name;
            i++;
        }
        selectorTransform.localPosition = new(-120, 40 * currentSelection);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && currentChoice > 0)
        {
            if (currentSelection == 0) currentPosition--;
            else currentSelection--;
            UpdateSelection();
            audio.PlayOneShot(SFX.MoveCursor);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && currentChoice + 1 < cachedCount)
        {
            if (currentSelection + 1 == maxVisibleChoices) currentPosition++;
            else currentSelection++;
            UpdateSelection();
            audio.PlayOneShot(SFX.MoveCursor);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            dataStore.Data = choices[currentChoice].result;
            audio.PlayOneShot(SFX.Select);
            done = true;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            dataStore.Data = cancelChoice;
            audio.PlayOneShot(SFX.Select);
            done = true;
        }
    }
}

