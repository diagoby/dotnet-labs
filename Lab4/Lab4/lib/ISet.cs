using System.Collections.Generic;

namespace Lab4.lib
{
    public interface ISet<T>
    {
        int Count { get; }
        bool IsSingleTonSet { get; }
        bool Add(T value);
        bool AddAll(IEnumerable<T> source);
        bool Remove(T value);
        bool Contains(T value);
        T Find(T value);
        void Clear();
    }
}
