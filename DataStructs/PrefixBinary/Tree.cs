using System;
namespace DataStructs.PrefixBinary
{
    internal class Tree<T>
    {
        private Node<T> root;

        public int Count { get; private set; }

        public Tree()
        {
            root = new Node<T>('\0', default(T));
            Count = 1;
        }

        public void Add(string key, T data)
        {
            AddNode(key, data, root);
        }

        public void Search(string key, out T value)
        {
            SearchNode(key, root, out value);
        }

        public void Remove(string key)
        {
            RemoveNode(key, root);
        }
  

        private bool SearchNode(string key, Node<T> node, out T value)
        {
            value = default(T);
            var result = false;
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    value = node.Data;
                    result = true;
                }
            }
            else
            {
                var subnode = node.TryFind(key[0]);
                if (subnode != null)
                {
                    result = SearchNode(key.Substring(1), node, out value);
                }
            }
            return result;
        }

       
        private void RemoveNode(string key, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                }
            }
            else
            {
                var subnode = node.TryFind(key[0]);
                if (subnode != null)
                {
                    RemoveNode(key.Substring(1), node);
                }
            }
        }

        private void AddNode(string key, T data, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord == false)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
            }
            else
            {
                var symbol = key[0];
                var subnode = node.TryFind(symbol);
                if (subnode != null)
                {
                    AddNode(key.Substring(1), data, subnode);
                }
                else
                {
                    var newNode = new Node<T>(key[0], data);
                    node.SubNodes.Add(key[0], newNode);
                    AddNode(key.Substring(1), data, newNode);
                }
            }
        }
    }
}
