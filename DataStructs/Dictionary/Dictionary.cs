
using DataStructs.Map;
using System.Collections;

namespace DataStructs.Dictionary
{
    public class Dict<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] items;

        public Dict()
        {
            items = new Item<TKey, TValue>[size];
        }

        public void Add(Item<TKey, TValue> item)
        {
            if (item.Key is null)
            {
                throw new NullReferenceException(nameof(item.Key));
            }

            var hash = GetHash(item.Key);
            if (items[hash] == null)
            {
                items[hash] = item;
            }
            else
            {
                bool placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (items[i].Key.Equals(item.Key))
                    {
                        return;
                    }

                    if (items[i] == null)
                    {
                        items[i] = item;
                        placed = true;
                        break;
                    }
                }

                if (placed == false)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (items[i].Key.Equals(item.Key))
                        {
                            return;
                        }

                        if (items[i] == null)
                        {
                            items[i] = item;
                            break;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Словарь заполнен");
                }
            }
        }

    

        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (items[hash] == null)
            {
                return;
            }

            if (items[hash].Key.Equals(key))
            {
                items[hash] = null;
            }

            else
            {
                bool placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (items[i] == null)
                    {
                        return;
                    }

                    if (items[i].Key.Equals(key))
                    {
                        items[i] = null;
                        return;
                    }
                }

                if (placed == false)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (items[i] == null)
                        {
                            return;
                        }

                        if (items[i].Key.Equals(key))
                        {
                            return;
                        }
                    }
                }
            }
        }

        public TValue? Search(TKey key)
        {
            var hash = GetHash(key);

            if (items[hash] == null)
            {
                return default;
            }

            if (items[hash].Key.Equals(key))
            {
                return items[hash].Value;
            }

            else
            {
                var placed = false;

                for (int i = hash; i < size; i++)
                {

                    if (items[i] == null)
                    {
                        return default;
                    }

                    if (items[i].Key.Equals(key))
                    {
                        return items[i].Value;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (items[i] == null)
                        {
                            return default;
                        }

                        if (items[i].Key.Equals(key))
                        {
                            return items[i].Value;
                        }

                    }
                }
            }

            return default;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}
