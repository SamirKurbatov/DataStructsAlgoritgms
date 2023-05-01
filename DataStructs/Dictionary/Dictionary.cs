
using DataStructs.Map;
using System.Collections;

namespace DataStructs.Dictionary
{
    public class Dict<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] items;
        private List<TKey> Keys = new();

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

            if (Keys.Contains(item.Key))
            {
                return;
            }

            if (items[hash] == null)
            {
                Keys.Add(item.Key);
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
                        Keys.Add(item.Key);
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
                            Keys.Add(item.Key);
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

            if (Keys.Contains(key) == false)
            {
                return;
            }

            if (items[hash] == null)
            {
                for (var i = 0; i < size; i++)
                {
                    if (items[i] != null && items[i].Key.Equals(key))
                    {
                        items[i] = null;
                        Keys.Remove(key);
                    }
                }
                return;
            }

            if (items[hash].Key.Equals(key))
            {
                items[hash] = null;
                Keys.Remove(key);
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
                        Keys.Remove(key);
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
                            items[i] = null;
                            Keys.Remove(key);
                            return;
                        }
                    }
                }
            }
        }

        public TValue? Search(TKey key)
        {
            var hash = GetHash(key);

            if (Keys.Contains(key) == false)
            {
                return default;
            }

            if (items[hash] == null)
            {
                foreach (var item in items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }

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
