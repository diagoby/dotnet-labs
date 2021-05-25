namespace Lab4.lib
{
    interface ISet<T>
    {
        int Count { get; }
        bool IsSingleTonSet { get; }
        bool Add(T value);
        bool Remove(T value);
        bool Contains(T value);
        T Find(T value);
        void Clear();
    }
}
