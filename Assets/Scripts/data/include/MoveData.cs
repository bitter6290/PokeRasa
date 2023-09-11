using System.Collections;

public readonly struct MoveData
{
    public readonly string name;

    public readonly byte type;
    public readonly byte power;
    public readonly byte accuracy;
    public readonly sbyte priority;

    public readonly MoveEffect effect;
    public readonly byte effectChance;
    public readonly bool physical;

    public readonly byte targets;

    public readonly byte pp;

    public readonly int moveFlags;


    public MoveData(string Name, byte thisType, byte Power, byte Accuracy, sbyte Priority, MoveEffect Effect, byte EffectChance, bool IsPhysical, byte Targets, byte PP, int MoveFlags = 0)
    {
        name = Name;
        type = thisType;
        power = Power;
        accuracy = Accuracy;
        priority = Priority;
        effect = Effect;
        effectChance = EffectChance;
        physical = IsPhysical;
        targets = Targets;
        pp = PP;
        moveFlags = MoveFlags;

    }

    public static MoveData SingleTargetStatusMove(string name, byte type, byte accuracy, sbyte priority, MoveEffect effect, byte pp, int moveFlags = 0)
        => new MoveData(name, type, 0, accuracy, priority, effect, 101, false, Target.Opponent + Target.Ally, pp, moveFlags);

    public static MoveData SelfTargetingMove(string name, byte type, sbyte priority, MoveEffect effect, byte pp, int moveFlags = 0)
        => new MoveData(name, type, 0, 101, priority, effect, 101, false, Target.Self, pp, moveFlags);

    public static MoveData FieldMove(string name, byte type, sbyte priority, MoveEffect effect, byte pp, int moveFlags = 0)
        => new(name, type, 0, 101, priority, effect, 101, false, Target.Field, pp, moveFlags);

    public static MoveData FakeMove => new("Error 106", Type.Typeless, 0, 0, 0, MoveEffect.None, 0, false, Target.None, 0);
}