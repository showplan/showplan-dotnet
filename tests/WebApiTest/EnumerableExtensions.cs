namespace WebApiTest;

internal static class EnumerableExtensions
{
    public static IEnumerable<(int Index, bool First, bool Last, T Item)> Enumerate<T>(this IEnumerable<T> source)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return Enumerate(source.GetEnumerator());
    }

    public static IEnumerable<(int Index, bool First, bool Last, T Item)> Enumerate<T>(this IEnumerator<T> source)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        var first = true;
        var last = !source.MoveNext();
        T current;

        for (var index = 0; !last; index++)
        {
            current = source.Current;
            last = !source.MoveNext();
            yield return (index, first, last, current);
            first = false;
        }
    }

    internal static string Repeat(this string text, int count)
    {
        if (text is null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        if (count <= 0)
        {
            return string.Empty;
        }

        if (count == 1)
        {
            return text;
        }

        return string.Concat(Enumerable.Repeat(text, count));
    }
}
