using DataStructs.DuplexList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs.CircularList
{
    public class CircularList<T>
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

        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }
    }
}
