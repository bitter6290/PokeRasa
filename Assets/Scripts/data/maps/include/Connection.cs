[System.Serializable]
public struct Connection
{
    public MapData map;
    public Direction direction;
    public int offset;
    public Connection(MapData map, Direction direction, int offset)
    { this.map = map; this.direction = direction; this.offset = offset; }
    //With an offset of n, maps will load with x/y=0 aligned with the base map's x/y=n
}