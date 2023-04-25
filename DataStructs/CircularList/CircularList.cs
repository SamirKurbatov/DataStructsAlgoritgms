using DataStructs.DuplexList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs.CircularList
{
    public class CircularList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }

        public int Count { get; set; }

        public CircularList() { }

        public CircularList(T data)
        {
            SetHeadItem(data);
        }
        
        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new DuplexItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }

            var current = Head;

            for (int i = Count; i >= 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                }
                current = current.Next;
            }

        }

        private void RemoveItem(DuplexItem<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }

        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
