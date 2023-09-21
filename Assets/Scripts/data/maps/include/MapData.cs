public class MapData
{
    public string path;
    public int height;
    public int width;
    public Connection[] connection = new Connection[0];

    public TileTrigger[] triggers = new TileTrigger[0];
    public TileTrigger[] signposts = new TileTrigger[0];
    public CharData[] chars = new CharData[0];
    public WildDataset[] grassData = new WildDataset[9];

    public ObjectScript BeforeLoad = p => { return; }; /*
                   * Executes *before* chars are unloaded; use this script to 
                   * preserve chars which would otherwise be unloaded
                   */
    public ObjectScript OnLoad = p => { return; };     /*
                   * Executes after chars are loaded; use this script to
                   * make changes to tile triggers, signposts and chars
                   */

}