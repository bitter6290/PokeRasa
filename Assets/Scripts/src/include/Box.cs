public class Box
{
    private string boxName;
    public string BoxName => boxName;

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

    public void Rename(string newName) => boxName = newName;

    public static Box newBox(string name) => new() { boxName = name };
}