public class Box
{
    private string boxName;
    public string BoxName => boxName;

    public Pokemon[] pokemon = new Pokemon[30];

    public void Rename(string newName) => boxName = newName;
}