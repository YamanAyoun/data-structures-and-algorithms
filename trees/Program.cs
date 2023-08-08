using System.Collections.Generic;

namespace trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> intTree = new BinarySearchTree<int>();
            
            intTree.Add(5);
            intTree.Add(15);
            intTree.Add(3);
            intTree.Add(7);
            


            Console.WriteLine("FizzBuzz:");
            List<string> fizzBuzzResult = intTree.FizzBuzz(intTree);
            foreach (string value in fizzBuzzResult)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

        
    }

        
    }
}