using static Direction;
using static MapID;

public static class Map
{
    public static MapData none = new()
    {
        path = "none",
        height = 1,
        width = 1,
        connection = new Connection[0]
    };
    public static MapData test = new()
    {
        path = "test",
        height = 30,
        width = 30,
        connection = new Connection[1]
        {
            new(Test2,S,-5)
        },
    };

    public static MapData test2 = new()
    {
        path = "test2",
        height = 20,
        width = 20,
        connection = new Connection[1]
        {
            new(Test,N,5)
        }
    };
    public static MapData[] MapTable = new MapData[(int)Count]
    {
        none,
        test,
        test2,
    };

    public static MapData Data(this MapID id) => MapTable[(int)id];
}