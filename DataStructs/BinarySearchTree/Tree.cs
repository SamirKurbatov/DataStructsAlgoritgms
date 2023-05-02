using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructs.BinarySearchTree
{
    internal class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }

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
            if (Root == null)
            {
                return new List<T>();
            }

            return PreOrder(Root);
        }

        private List<T> PreOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(PreOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PreOrder(node.Right));
                }

            }
            return list;
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PostOrder(Root);
        }

        private List<T> PostOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(PostOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostOrder(node.Right));
                }

                list.Add(node.Data);
            }
            return list;
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return InOrder(Root);
        }

        private List<T> InOrder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }
            return list;
        }
    }
}
