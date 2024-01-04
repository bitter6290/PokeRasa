using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using static Player.MenuItem;
using System.Collections;

public class FieldMenu : MonoBehaviour
{
    [SerializeField] private RawImage menu1;
    [SerializeField] private RawImage menu2;
    [SerializeField] private RawImage menu3;
    [SerializeField] private RawImage menu4;
    [SerializeField] private RawImage menu5;
    [SerializeField] private RawImage menu6;
    [SerializeField] private RawImage currentMenu;
    [SerializeField] private TextMeshProUGUI menuName;

    private RawImage images(int index) => index switch
    {
        0 => menu1,
        1 => menu2,
        2 => menu3,
        3 => currentMenu,
        4 => menu4,
        5 => menu5,
        6 => menu6,
        _ => throw new System.Exception("Passed bad argument to FieldMenu.images")
    };

    public bool active;

    public Player player;

    private int currentItem;
    private bool chosen;

    private MenuData[] menu;

    public void Update()
    {
        if (!active) return;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            player.audioSource.PlayOneShot(SFX.Select);
            chosen = true;
            active = false;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && currentItem > 0)
        {
            player.audioSource.PlayOneShot(SFX.MoveCursor);
            currentItem--;
            RefreshMenu();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentItem + 1 < menu.Length)
        {
            player.audioSource.PlayOneShot(SFX.MoveCursor);
            currentItem++;
            RefreshMenu();
        }
    }

    public struct MenuData
    {
        public Player.MenuItem menuItem;
        public string name;
        public Texture2D icon;
    }

    public void ClearName() => menuName.text = string.Empty;

    public void OpenMenu(Player.MenuItem menuItem = CloseMenu)
    {
        active = true;
        chosen = false;
        List<MenuData> menuData = new();
        currentItem = 0;
        foreach (MenuData data in FieldMenuData.menuItems)
        {
            if (IsEnabled(data.menuItem))
            {
                menuData.Add(data);
                if (menuItem == data.menuItem)
                    currentItem = menuData.Count - 1;
            }
        }
        menu = menuData.ToArray();
        RefreshMenu();
    }

    private void RefreshMenu()
    {
        for (int i = 0; i < 7; i++)
        {
            int j = currentItem - 3 + i;
            if (j < 0 || j >= menu.Length)
            {
                images(i).enabled = false;
            }
            else
            {
                images(i).enabled = true;
                images(i).texture = menu[j].icon;
            }
        }
        menuName.text = menu[currentItem].name;
    }

    public IEnumerator DoMenu()
    {
        chosen = false;
        while (!chosen) yield return null;
        player.cachedMenuItem = menu[currentItem].menuItem;
    }

    private bool IsEnabled(Player.MenuItem menuItem)
    {
        switch (menuItem)
        {
            case Player.MenuItem.Pokemon: return player.monsInParty > 0;
            default: return true;
        }
    }
}