[System.Serializable]
public class Box
{
    public string boxName;

    public Pokemon[] pokemon = new Pokemon[30];

    public int nextSlot
    {
        get
        {
            for (int i = 0; i < 30; i++)
            {
                if (!pokemon[i].exists) return i;
            }
            return 255;
        }
    }

    public static Box newBox(string name) => new() { boxName = name };
}