namespace DataStructs.Queue
{
    public class LinkedQueue<T>
    {
        private Item<T> head;

        private Item<T> tail;

        public int Count { get; private set; }

        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            SetHeadItem(data);

        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            if (item == null)
            {
                throw new NullReferenceException(nameof(item));
            }

            head = item;
            tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data);

            item.Next = tail;
            tail = item;
            Count++;
        }

        public T Dequeue()
        {
            var data = head.Data;

            var current = tail.Next;

            var previous = tail;

            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            return head.Data;
        }
    }

    public record class Item<T>(T Data)
    {
        public Item<T> Next { get; set; }
    }
}
