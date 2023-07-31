namespace trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Add elements to the tree
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);

            // Find the maximum value in the tree
            int maxValue = bst.FindMaximumValue();

            // Print the result
            Console.WriteLine("Maximum value in the tree: " + maxValue);
        }
    }
}