namespace ZedUtil;
public static class Extensions
{
    /// <summary>
    /// Executes an action using each item of the collection
    /// </summary>
    public static void ForEach<T>(this IEnumerable<T> i, Action<T> action)
    {
        foreach(T item in i)
        {
            action(item);
        }
    }
    /// <summary>
    /// Executes a function using the input <c>item</c>. If true, adds the item to the collection
    /// </summary>
    public static void TryAdd<T>(this List<T> i, T item, Func<T, bool> function)
    {
        if(function(item)) i.Add(item);
    }
}
