public class MapData
{
    public string path;
    public int height;
    public int width;
    public Connection[] connection;

    public TileTrigger[] triggers;
    public WildDataset[] grassData = new WildDataset[9];
}