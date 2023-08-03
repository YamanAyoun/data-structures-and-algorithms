using System.Collections.Generic;

namespace trees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new BinarySearchTree<int>();
            list.Add(2);
            list.Add(7);
            list.Add(5);
            list.Add(2);
            list.Add(6);
            list.Add(9);
            list.Add(5);
            list.Add(11);
            list.Add(4);

            List<int> result = list.BreadthFirst(list);
            Console.WriteLine(string.Join(", ", result));
        }

    
    }
}