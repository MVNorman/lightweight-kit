namespace Lightweight.Kit.Extensions
{
    public static class CollectionExtension
    {
        public static IEnumerable<T> OrEmpty<T>(this IEnumerable<T> array)
        {
            return array ?? Enumerable.Empty<T>();
        }

        public static void RemoveAll<T>(this ICollection<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                T element = collection.ElementAt(i);

                if (predicate(element))
                {
                    collection.Remove(element);
                    i--;
                }
            }
        }

        public static void ForEachElement<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
                action(item);
        }

        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> range)
        {
            foreach (T item in range)
                source.Add(item);
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> source, T item)
        {
            return source.Concat(new[] {item});
        }
        
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            HashSet<TKey> keys = new();

            foreach (TSource element in source)
            {
                if (keys.Add(selector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}