public static class Map
{

    public static MapData Test = new()
    {
        path = "test",
        height = 30,
        width = 30,
        connection = new Connection[0],
    };
    public static MapData[] MapTable = new MapData[]
    {
        Test
    };
}