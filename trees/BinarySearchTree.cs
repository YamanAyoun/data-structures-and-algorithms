using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        
        public void Add(T value)
        {
            Root = AddNode(Root, value);
        }
        private Node<T> AddNode(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);


            if (value.CompareTo(node.Value) < 0)
                node.Left = AddNode(node.Left, value);

            else if (value.CompareTo(node.Value) > 0)
                node.Right = AddNode(node.Right, value);

            return node;
        }

        public bool Contains(T value)
        {
            return Contains(Root!, value);
        }

        private bool Contains(Node<T> node, T value)
        {
            if (node == null)
                return false;

            int compareResult = value.CompareTo(node.Value);

            if (compareResult == 0)
                return true;
            else if (compareResult < 0)
                return Contains(node.Left!, value);
            else
                return Contains(node.Right!, value);
        }
    }

}
