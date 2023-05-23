namespace ZedUtil;
public static class Extensions
{
    public static void ForEach<T>(this IEnumerable<T> i, Action<T> action)
    {
        foreach(T item in i)
        {
            action(item);
        }
    }
    public static void TryAdd<T>(this List<T> i, T item, Func<T, bool> function)
    {
        if(function(item)) i.Add(item);
    }
}
