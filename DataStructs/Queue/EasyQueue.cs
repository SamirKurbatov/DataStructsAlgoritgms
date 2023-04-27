namespace DataStructs.Queue
{
    public class EasyQueue<T>
    {
        private List<T> items = new();

        private T Head => items.Last();

        private T Tail => items.First();

        public int Count => items.Count;

        public EasyQueue() { }

        public EasyQueue(T data)
        {
            if (items == null)
            {
                throw new NullReferenceException(nameof(items));
            }

            if (data != null)
            {
                items.Add(data);
            }
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
