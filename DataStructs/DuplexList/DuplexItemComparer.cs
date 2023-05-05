namespace DataStructs.DuplexList
{
    public class DuplexItemComparer<T> : IComparer<DuplexItem<T>> where T : IComparable
    {
        public int Compare(DuplexItem<T>? x, DuplexItem<T>? y)
        {
            return x.Data.CompareTo(y.Data);
        }
    }
}
