public enum MapID : ushort
{
    None,
    Test,
    Test2,
    Count
}

public static class MapIDUtils
{
    public static int ObjID(this MapID map, int index) => (ushort)map << 16 + index;
}