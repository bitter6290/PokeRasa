using UnityEngine;

public static class FieldMenuData
{
    public static Texture2D Close = Resources.Load<Texture2D>("Sprites/Menu/back");
    public static Texture2D Pokemon = Resources.Load<Texture2D>("Sprites/Menu/pokemon");
    public static Texture2D Bag = Resources.Load<Texture2D>("Sprites/Menu/bag");
    public static Texture2D Settings = Resources.Load<Texture2D>("Sprites/Menu/settings");
    public static Texture2D Save = Resources.Load<Texture2D>("Sprites/Menu/save");

    public static FieldMenu.MenuData[] menuItems = new FieldMenu.MenuData[]
    {
        new()
        {
            menuItem = Player.MenuItem.CloseMenu,
            name = "Close",
            icon = Close
        },
        new()
        {
            menuItem = Player.MenuItem.Pokemon,
            name = "Pokémon",
            icon = Pokemon
        },
        new()
        {
            menuItem = Player.MenuItem.Bag,
            name = "Bag",
            icon = Bag
        },
        new()
        {
            menuItem = Player.MenuItem.Save,
            name = "Save",
            icon = Save
        },
        new()
        {
            menuItem = Player.MenuItem.Settings,
            name = "Settings",
            icon = Settings
        }
    };
}