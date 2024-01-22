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

    public readonly MoveFlags moveFlags;

    public readonly string moveDesc;

    public readonly int zMovePower;
    public readonly ZMoveEffect zMoveEffect;

    public readonly int maxMovePower;


    public MoveData(string Name, Type thisType, int Power, int Accuracy,
        int Priority, MoveEffect Effect, int EffectChance, bool IsPhysical,
        int Targets, int PP, MoveFlags MoveFlags, string MoveDesc, int ZMovePower,
        ZMoveEffect ZMoveEffect = ZMoveEffect.None, int? MaxMovePower = null)
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
        moveDesc = MoveDesc;
        zMovePower = ZMovePower;
        zMoveEffect = ZMoveEffect;
        maxMovePower = MaxMovePower != null
            ? (int)MaxMovePower
            : thisType is Type.Fighting or Type.Poison
                ? Power switch
                {
                    0 => 0,
                    < 50 => 70,
                    < 60 => 75,
                    < 65 => 80,
                    < 75 => 85,
                    < 120 => 90,
                    < 150 => 95,
                    _ => 100
                }
                : Power switch
                {
                    0 => 0,
                    < 45 => 90,
                    < 55 => 100,
                    < 65 => 110,
                    < 75 => 120,
                    < 105 => 130,
                    < 150 => 140,
                    _ => 150
                };
    }

    public static MoveData SingleTargetStatusMove(string name, Type type, int accuracy, int priority, MoveEffect effect, int pp, MoveFlags moveFlags, ZMoveEffect zMoveEffect, string moveDesc)
        => new(name, type, 0, accuracy, priority, effect, 101, false, Target.Opponent + Target.Ally, pp, moveFlags, moveDesc, 0, zMoveEffect);

    public static MoveData SelfTargetingMove(string name, Type type, int priority, MoveEffect effect, int pp, MoveFlags moveFlags, ZMoveEffect zMoveEffect, string moveDesc)
        => new(name, type, 0, 101, priority, effect, 101, false, Target.Self, pp, moveFlags, moveDesc, 0, zMoveEffect);

    public static MoveData FieldMove(string name, Type type, int priority, MoveEffect effect, int pp, MoveFlags moveFlags, ZMoveEffect zMoveEffect, string moveDesc)
        => new(name, type, 0, 101, priority, effect, 101, false, Target.Field, pp, moveFlags, moveDesc, 0, zMoveEffect);

    public static MoveData FakeMove => new("Error 106", Type.Typeless, 0, 0, 0, MoveEffect.None, 0, false, Target.None, 0, 0, "This move should never be visible.", 0);

    public static MoveData SingleTargetNoAddedEffect(string name, Type type, int power, int accuracy, int priority, bool physical, int pp, MoveFlags moveFlags, int zMovePower, string moveDesc)
        => new(name, type, power, accuracy, priority, MoveEffect.None, 0, physical, Target.Opponent + Target.Ally, pp, moveFlags, moveDesc, zMovePower);

    public static MoveData ZMove(string name, Type type, bool physical, string desc) =>
        new(name, type, 1, 101, 0, MoveEffect.ZMove, 0, physical, Target.Single, 0, 0, desc, 1);

    public static MoveData MaxMove(string name, Type type, string desc) => new(
        name, type, 1, 101, 0, MoveEffect.MaxMove, 101, false, Target.Single, 0, MoveFlags.none, desc, 1, ZMoveEffect.None, 0);
}