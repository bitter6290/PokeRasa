public struct TMLearnsetData
{
    public static bool[] learnableTMs = new bool[(int)TMID.Count];
    public TMLearnsetData(byte[] allowedTMs)
    {
        foreach (byte i in allowedTMs){
            learnableTMs[i] = true;
        }
    }
}
