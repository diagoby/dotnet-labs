using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4.lib
{
    abstract class AbstractSet<T> : ISet<T>, IEnumerable<T>, IEquatable<AbstractSet<T>>, ICloneable
    {
        private int _count = 0;
        public int Count 
        {
            get => _count;
            protected set
            {
                _count = value;

                IsSingleTonSet = Count == 1;
            }
        }
        public bool IsSingleTonSet { get; private set; }

        public abstract bool Add(T value);
        public abstract bool AddAll(IEnumerable<T> source);
        public abstract void Clear();

        public abstract bool Remove(T value);

        public abstract bool Contains(T value);

        public abstract T Find(T value);

        public abstract object Clone();

        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Equals(AbstractSet<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            using var thisIterator = GetEnumerator();
            using var otherIterator = other.GetEnumerator();

            while (thisIterator.MoveNext() && otherIterator.MoveNext())
            {
                if (!thisIterator.Current.Equals(otherIterator.Current))
                {
                    return false;
                }   
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((AbstractSet<T>) obj);
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }

        public override int GetHashCode()
        {
            int hash = 0;

            foreach (var item in this)
            {
                hash ^= item.GetHashCode();
            }

            return HashCode.Combine(Count, hash);
        }

        public static AbstractSet<T> operator +(AbstractSet<T> set1, AbstractSet<T> set2)
        {
            AbstractSet<T> resultSet = (AbstractSet<T>) set1.Clone();

            foreach (var item in set2)
            {
                if (!resultSet.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            return resultSet;
        }

        public static AbstractSet<T> operator -(AbstractSet<T> set1, AbstractSet<T> set2)
        {
            AbstractSet<T> resultSet = (AbstractSet<T>) set1.Clone();

            foreach (var item in resultSet)
            {
                if (set2.Contains(item))
                {
                    resultSet.Remove(item);
                }
            }

            return resultSet;
        }

        public static AbstractSet<T> operator *(AbstractSet<T> set1, AbstractSet<T> set2)
        {
            AbstractSet<T> resultSet = (AbstractSet<T>) set1.Clone();

            foreach (var item in resultSet)
            {
                if (!set2.Contains(item))
                {
                    resultSet.Remove(item);
                }
            }

            return resultSet;
        }
    }
}
