using System.Collections.Generic;

namespace trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            // Add nodes and values to the tree

            int oddSum = SumOddNumbers(tree);
            Console.WriteLine("Sum of odd numbers: " + oddSum);
        }

        
    }
}