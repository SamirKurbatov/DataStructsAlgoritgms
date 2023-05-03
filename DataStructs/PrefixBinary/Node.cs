
namespace DataStructs.PrefixBinary
{
    internal class Node<T>
    {
        public char Symbol { get; set; }

        public T Data { get; set; }

        public bool IsWord { get; set; }

        public string Prefix { get; set; }

        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
        }

        public Node<T> TryFind(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] [{Prefix}]";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Node<T> item)
            {
                return Data.Equals(item);
            }

            return false;
        }
    }
}
