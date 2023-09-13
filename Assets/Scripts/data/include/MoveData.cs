using System.Collections;

public readonly struct MoveData
{
    public readonly string name;

    public readonly Type type;
    public readonly int power;
    public readonly int accuracy;
    public readonly int priority;

    public readonly MoveEffect effect;
    public readonly int effectChance;
    public readonly bool physical;

    public readonly int targets;

    public readonly int pp;

    public readonly int moveFlags;


    public MoveData(string Name, Type thisType, int Power, int Accuracy, int Priority, MoveEffect Effect, int EffectChance, bool IsPhysical, int Targets, int PP, int MoveFlags = 0)
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

    public static MoveData SingleTargetStatusMove(string name, Type type, int accuracy, int priority, MoveEffect effect, int pp, int moveFlags = 0)
        => new(name, type, 0, accuracy, priority, effect, 101, false, Target.Opponent + Target.Ally, pp, moveFlags);

    public static MoveData SelfTargetingMove(string name, Type type, int priority, MoveEffect effect, int pp, int moveFlags = 0)
        => new(name, type, 0, 101, priority, effect, 101, false, Target.Self, pp, moveFlags);

    public static MoveData FieldMove(string name, Type type, int priority, MoveEffect effect, int pp, int moveFlags = 0)
        => new(name, type, 0, 101, priority, effect, 101, false, Target.Field, pp, moveFlags);

    public static MoveData FakeMove => new("Error 106", Type.Typeless, 0, 0, 0, MoveEffect.None, 0, false, Target.None, 0);

    public static MoveData SingleTargetNoEffect(string name, Type type, int power, int accuracy, int priority, bool physical, int pp, int moveFlags = 0)
        => new(name, type, power, accuracy, priority, MoveEffect.None, 0, physical, Target.Opponent + Target.Ally, pp, moveFlags);
}