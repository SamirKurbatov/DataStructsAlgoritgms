namespace DataStructs.HashTable
{
    public class HashTable<T>
    {
        private Item<T>[] items;

        public HashTable(int size)
        {
            items = new Item<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHashCode(item);
            items[key].Nodes.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHashCode(item);
            return items[key].Nodes.Contains(item);
        }

        private int GetHashCode(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }

    public record Item<T>(int Key, List<T> Nodes)
    {
        public Item(int key) : this(key, new List<T>()) { }
    }
}
