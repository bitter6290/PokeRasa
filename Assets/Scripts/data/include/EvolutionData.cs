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
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, int data, SpeciesID destination)
        => new EvolutionData[1] { new(method, data, destination) };
    public static EvolutionData[] SingleEvolution(EvolutionMethod method, ItemID data, SpeciesID destination)
        => new EvolutionData[1] { new(method, (int)data, destination) };
}