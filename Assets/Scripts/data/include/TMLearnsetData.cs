public struct TMLearnsetData
{
    public static bool[] learnableTMs = new bool[(int)TMID.Count];
    public TMLearnsetData(int[] allowedTMs)
    {
        foreach (int i in allowedTMs)
        {
            learnableTMs[i] = true;
        }
    }
}
