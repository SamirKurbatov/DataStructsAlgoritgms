namespace DataStructs.Stack
{
    public class ArrayStack<T>
    {
        private int current = -1;
        private readonly int size = 10;
        private T[] items;

        public int MaxCount => items.Length;

        public int Count => current + 1;

        public ArrayStack(int size = 10)
        {
            this.size = size;
            items = new T[size];
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен");
            }
        }

        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                var item = items[current];
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
