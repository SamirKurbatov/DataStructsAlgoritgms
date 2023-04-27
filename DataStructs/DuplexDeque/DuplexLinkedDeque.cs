namespace DataStructs.DuplexDeque
{
    public class DuplexLinkedDeque<T>
    {

        private DuplexItem<T> head;

        private DuplexItem<T> tail;

        public int Count { get; set; }

        public DuplexLinkedDeque() { }

        public DuplexLinkedDeque(T data)
        {
            SetHeadAndTailItems(data);
        }

        public void PushBack(T data)
        {
            InitHeadAndTailItems(data);

            var item = new DuplexItem<T>(data);
            item.Next = tail;
            tail.Previous = item;
            tail = item;
            Count++;
        }

        public void PushFront(T data)
        {
            InitHeadAndTailItems(data);

            var item = new DuplexItem<T>(data);
            item.Previous = head;
            head.Next = item;
            head = item;
            Count++;
        }


        public T PopBack()
        {
            if (Count > 0)
            {
                var result = tail.Data;
                var current = tail.Next;
                current.Previous = null;
                tail = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                var result = head.Data;
                var current = head.Previous;
                current.Next = null;
                head = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PeekBack()
        {
            return tail.Data;
        }

        public T PeekFront()
        {
            return head.Data;
        }

        private void InitHeadAndTailItems(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTailItems(data);
                return;
            }
        }

        private void SetHeadAndTailItems(T data)
        {
            var item = new DuplexItem<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }
    }
}
