public readonly struct EvolutionData
{
    public readonly EvolutionMethod Method;
    public readonly int Data;
    public readonly SpeciesID Destination;
    public EvolutionData(EvolutionMethod method, int data, SpeciesID destination)
    {
        this.Method = method;
        this.Data = data;
        this.Destination = destination;
    }
}