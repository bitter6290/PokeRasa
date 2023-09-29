public class CharScripts
{
    public CharScript OnInteract = (p, c) => ScriptUtils.DoNothing();
    public SeeCondition SeeCheck = p => { return false; };
    public CharScript OnSee = (p, c) => ScriptUtils.DoNothing();
    public CharScript OnWin = (p, c) => ScriptUtils.DoNothing().DoAtEnd(
    () => {
        p.state = PlayerState.Free;
    });

    public ObjectMovement GetMovement;
}