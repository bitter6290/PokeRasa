using TMPro;
using Unity.VisualScripting;

public enum TMID : byte
{
    SwordsDance,

    //HM moves
    HM_Cut,
    HM_RockSmash,
    HM_Surf,
    Count,

    HMStart = HM_Cut,
    Close = Count
}

public static class TMUtils
{
    public static MoveID Move(this TMID id) => 
        id switch
        {
            TMID.SwordsDance => MoveID.SwordsDance,
            TMID.HM_Cut => MoveID.Cut,
            TMID.HM_RockSmash => MoveID.RockSmash,
            TMID.HM_Surf => MoveID.Surf,
            _ => MoveID.None
        };
    public static void Set(this TMID id) => Player.player.TM[(int)id] = true;
    public static bool Get(this TMID id) => Player.player.TM[(int)id];
}