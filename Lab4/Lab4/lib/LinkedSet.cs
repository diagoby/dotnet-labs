using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.lib
{
    class LinkedSet<T> : AbstractSet<T>
    {
        private Node Head;

        public LinkedSet() { }

        public LinkedSet(IEnumerable<T> source)
        {
            AddAll(source);
        }

        public override bool Add(T value)
        {
            if (value != null && !Contains(value))
            {
                Head = new Node { Value = value, Next = Head };
                Count += 1;

                return true;
            }

            return false;
        }

        public override bool AddAll(IEnumerable<T> source)
        {
            bool changed = false;

            foreach (var item in source)
            {
                bool added = Add(item);

                if(!changed)
                {
                    changed = added;
                }
            }

            return changed;
        }

        public override bool Remove(T value)
        {
            if (value == null) return false;

            Node targetNode = Head;
            Node previousNode = null;

            while (!targetNode.Value.Equals(value))
            {
                previousNode = targetNode;
                targetNode = targetNode.Next;

                // End of collection
                if(targetNode == null) return false;
            }

            if(previousNode == null)
            {
                // Head item needs to be removed
                Head = targetNode.Next;
            }
            else
            {
                previousNode.Next = targetNode.Next;
            }

            Count -= 1;

            return true;
        }

        public override bool Contains(T value)
        {
            foreach (var item in this)
            {
                if (item.Equals(value)) return true;
            }

            return false;
        }

        public override T Find(T value)
        {
            return Contains(value) ? value : default(T);
        }

        public override object Clone()
        {
            var clone = new LinkedSet<T>();

            foreach (var item in this)
            {
                clone.Add(item);
            }

            return clone;
        }

        public override void Clear()
        {
            Head = null;
            Count = 0;
        }

        public static LinkedSet<T> Of(IEnumerable<T> source) => new LinkedSet<T>(source);

        public override IEnumerator<T> GetEnumerator() => new LinkedSetIterator(this);

        class LinkedSetIterator : IEnumerator<T>
        {
            private readonly LinkedSet<T> set;
            private Node current;

            public LinkedSetIterator(LinkedSet<T> set)
            {
                this.set = set;

                Reset();
            }

            public T Current => current.Value;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (current.Next != null)
                {
                    current = current.Next;

                    return true;
                }

                return false;
            }

            public void Reset()
            {
                current = new Node { Next = set.Head };
            }

            public void Dispose() { }
        }

        class Node
        {
            public Node Next;
            public T Value;
        }
    }
}
