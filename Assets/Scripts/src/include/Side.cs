public class Side
{
    public bool lightScreen = false;
    public byte lightScreenTurns = 0;
    public bool reflect = false;
    public byte reflectTurns = 0;
    public bool auroraVeil = false;
    public byte auroraVeilTurns = 0;
    public bool mist = false;
    public byte mistTurns = 0;
    public int spikes = 0;
    public readonly bool whichSide;
    public Side(bool side)
    {
        whichSide = side;
    }

}
