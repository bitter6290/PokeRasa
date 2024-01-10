[System.Serializable]
public class Box
{
    public string boxName;

    public Pokemon[] pokemon = new Pokemon[42];

    public int nextSlot
    {
        get
        {
            for (int i = 0; i < 42; i++)
            {
                if (!pokemon[i].exists) return i;
            }
            return 255;
        }
    }

    public Box(string name) { boxName = name; for (int i = 0; i < 42; i++) pokemon[i] = Pokemon.EmptyMon; }
}