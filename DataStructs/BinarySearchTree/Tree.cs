using System.Collections;

namespace DataStructs.BinarySearchTree
{
    public class Tree<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }

        private List<T> result = new List<T>();

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }

        public List<T> PreOrder()
        {
            result.Clear();
            PreOrder(Root);
            return result;
        }

        private void PreOrder(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            result.Add(node.Data);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public List<T> PostOrder()
        {
            result.Clear();
            PostOrder(Root);
            return result;
        }

        private void PostOrder(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            PostOrder(node.Left);
            PostOrder(node.Right);
            result.Add(node.Data);
        }

        public List<T> InfixOrder()
        {
            result.Clear();
            InfixOrder(Root);
            return result;
        }

        private void InfixOrder(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            InfixOrder(node.Left);
            result.Add(node.Data);
            InfixOrder(node.Right);
        }
    }
}
