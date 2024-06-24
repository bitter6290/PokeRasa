using Unity.VisualScripting;

public class TMLearnsetData
{
    public bool[] learnableTMs = new bool[(int)TMID.Count];
    public TMLearnsetData(TMID[] allowedTMs)
    {
        foreach (int i in allowedTMs)
        {
            learnableTMs[i] = true;
        }
    }
    public static implicit operator bool[](TMLearnsetData data) => data.learnableTMs;
}
