public static class TMLearnset
{
    public static TMLearnsetData NoTMs = new(new TMID[0]);

    public static TMLearnsetData CutOnly = new(new TMID[]{TMID.HM_Cut});
    public static TMLearnsetData CutDance = new(new TMID[]{TMID.HM_Cut, TMID.SwordsDance});
}