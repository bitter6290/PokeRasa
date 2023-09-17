public struct Connection
{
    public MapID map;
    public Direction direction;
    public int offset; //With an offset of n, maps will load with x/y=0 aligned with the base map's x/y=n
}