using System.Collections;

namespace DataStructs.Hash
{
    public class EasyHashSet<T> : IEnumerable
    {
        private List<T> items = new();

        public int Count => items.Count;

        public EasyHashSet() { }

        public EasyHashSet(T item)
        {
            items.Add(item);
        }

        public EasyHashSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        private void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }

            items.Add(item);
        }

        private void Remove(T item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Объединение
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>

        public EasyHashSet<T> Union(EasyHashSet<T> set)
        {
            // return new EasyHashSet<T>(items.Union(set.items));

            var result = new EasyHashSet<T>();

            if (Count >= set.Count)
            {
                foreach (var item1 in items)
                {
                    result.Add(item1);
                }

                foreach (var item in set.items)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// Пересечение
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>

        public EasyHashSet<T> Intersect(EasyHashSet<T> set)
        {
            // return new EasyHashSet<T>(items.Intersect(set.items));

            EasyHashSet<T> big;
            EasyHashSet<T> small;

            if (Count >= set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                small = this;
                big = set;
            }

            var result = new EasyHashSet<T>();

            foreach (var item1 in big.items)
            {
                foreach (var item2 in small.items)
                {
                    if (item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        public EasyHashSet<T> Difference(EasyHashSet<T> set)
        {
            var result = new EasyHashSet<T>();

            foreach (var item in items)
            {
                result.Remove(item);
            }

            return result;
        }

        public bool Subset(EasyHashSet<T> set)
        {
            foreach (var item in items)
            {
                bool equals = false;
                foreach (var item1 in set.items)
                {
                    if (item.Equals(item1))
                    {
                        equals = true;
                        break;
                    }
                }

                if (equals == false)
                {
                    return false;
                }
            }

            return true;
        }

        public EasyHashSet<T> SymmetricDifference(EasyHashSet<T> set)
        {
            var result = new EasyHashSet<T>();

            foreach (var item in items)
            {
                bool equals = false;
                foreach (var item1 in set.items)
                {
                    if (item1.Equals(item))
                    {
                        equals = true;
                        break;
                    }
                }

                if (equals == false)
                {
                    result.Add(item);
                }
            }

            foreach (var item in set.items)
            {
                bool equals = false;
                foreach (var item1 in items)
                {
                    if (item1.Equals(item))
                    {
                        equals = true;
                        break;
                    }
                }

                if (equals == false)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
