using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs.DuplexList
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }

        public DuplexItem<T> Tail { get; set; }

        public int Count { get; set; }

        public DuplexLinkedList() { }

        public DuplexLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if (Count != 0)
            {
                var item = new DuplexItem<T>(data);
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }

            else
            {
                SetHeadAndTail(data);
                return;
            }
        }

        private void SetHeadAndTail(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Remove(T data)
        {
            if (Head == null)
            {
                throw new NullReferenceException(nameof(Head));
            }

            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }

        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();

            var current = Tail;

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
