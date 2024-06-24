public class DataStore<T>
{
    public T Data { get; set; }
    public static implicit operator T(DataStore<T> store) => store.Data;
}