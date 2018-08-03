namespace MyComparer
{
    using System.Collections.Generic;

    public interface IMyEqualityComparer<T>: IEqualityComparer<T>
    {
        IEnumerable<T> Equals(IEnumerable<T> items, T item);
        IEnumerable<T> Equals(T item, IEnumerable<T> items);
        IEnumerable<T> Duplicates(IEnumerable<T> items);
        IEnumerable<T> Distincts(IEnumerable<T> items);
    }
}
