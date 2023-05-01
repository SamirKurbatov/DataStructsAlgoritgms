using System.Collections;
using System.Net;

namespace DataStructs.Map
{
    public class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> items = new();

        private List<TKey> keys = new();

        public int Count => items.Count;

        public EasyMap() { }

        public void Add(Item<TKey, TValue> item)
        {
            if (keys.Contains(item.Key) == false)
            {
                keys.Add(item.Key);
                items.Add(item);
            }
        }

        public TValue? Search(TKey key)
        {
            if (keys.Contains(key))
            {
                return items.Single(i => i.Key.Equals(key)).Value;
            }
            return default; // или исключение использовать
        }

        public void Remove(TKey key)
        {
            if (keys.Contains(key))
            {
                keys.Remove(key);
                items.Remove(items.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
