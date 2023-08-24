using System.Collections;

public readonly struct MoveData
{
    public readonly string name;

    public readonly byte type;
    public readonly byte power;
    public readonly byte accuracy;
    public readonly sbyte priority;

    public readonly ushort effect;
    public readonly byte effectChance;
    public readonly bool physical;

    public readonly byte targets;

    public readonly byte pp;

    public readonly int moveFlags;


    public MoveData(string Name, byte thisType, byte Power, byte Accuracy, sbyte Priority, ushort Effect, byte EffectChance, bool IsPhysical, byte Targets, byte PP, int MoveFlags = 0)
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
}