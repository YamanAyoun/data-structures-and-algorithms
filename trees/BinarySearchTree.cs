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

        public T FindMaximumValue()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Tree is empty!");
            }

            return FindMaximumValue(Root);
        }

        private T FindMaximumValue(Node<T> node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node.Value;
        }


        public List<T> BreadthFirst(BinarySearchTree<T> tree)
        {
            List<T> breadthFirst = new List<T>();

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(tree.Root);

            if (tree.Root == null)
                return breadthFirst;



            while (queue.Count > 0)
            {
                Node<T> front = queue.Dequeue();
                breadthFirst.Add(front.Value);

                if (front.Left != null)
                    queue.Enqueue(front.Left);

                if (front.Right != null)
                    queue.Enqueue(front.Right);
            }

            return breadthFirst;
        }


        public List<string> FizzBuzz(BinarySearchTree<int> root)
        {
            List<string> list = new List<string>();

            if (root.Root == null)

                return list;

            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(root.Root);

            while (queue.Count > 0)
            {
                Node<int> front = queue.Dequeue();


                if (front.Left != null)
                    queue.Enqueue(front.Left);

                if (front.Right != null)
                    queue.Enqueue(front.Right);

                if (front.Value % 15 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (front.Value % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (front.Value % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(front.Value.ToString());
                }
                
            }
            return list;
        }

    }

}
