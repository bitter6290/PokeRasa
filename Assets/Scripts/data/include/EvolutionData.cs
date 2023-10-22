public readonly struct EvolutionData
{
    public readonly EvolutionMethod Method;
    public readonly int Data;
    public readonly SpeciesID Destination;
    public EvolutionData(EvolutionMethod method, int data, SpeciesID destination)
    {
        Method = method;
        Data = data;
        Destination = destination;
    }
    public EvolutionData(EvolutionMethod method, ItemID data, SpeciesID destination)
    {
        Method = method;
        Data = (int)data;
        Destination = destination;
    }
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, int data, SpeciesID destination) =>
        new EvolutionData[1] { new(method, data, destination) };
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, ItemID item, SpeciesID destination) =>
        new EvolutionData[1] { new(method, (int)item, destination) };
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, MoveID move, SpeciesID destination) =>
        new EvolutionData[1] { new(method, (int)move, destination) };
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, SpeciesID species, SpeciesID destination) =>
        new EvolutionData[1] { new(method, (int)species, destination) };

    public static EvolutionData[] LevelEvolution(int level, SpeciesID destination) =>
        new EvolutionData[1] { new(EvolutionMethod.LevelUp, level, destination) };
    public static EvolutionData[] ItemEvolution(ItemID item, SpeciesID destination) =>
        new EvolutionData[1] { new(EvolutionMethod.EvolutionItem, (int)item, destination) };
    public static EvolutionData[] TradeEvolution(SpeciesID destination) =>
        new EvolutionData[1] { new(EvolutionMethod.Trade, 0, destination) };
    public static EvolutionData[] Friendship220Evolution(SpeciesID destination) =>
        new EvolutionData[1] { new(EvolutionMethod.Friendship, 220, destination) };
}