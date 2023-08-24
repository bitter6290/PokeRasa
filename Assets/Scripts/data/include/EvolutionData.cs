public readonly struct EvolutionData
{
    public readonly byte Method;
    public readonly int Data;
    public readonly SpeciesID Destination;
    public EvolutionData(byte method, int data, SpeciesID destination)
    {
        this.Method = method;
        this.Data = data;
        this.Destination = destination;
    }
}