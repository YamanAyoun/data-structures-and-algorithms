namespace linked_list_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedListReverse list = new linkedListReverse();

            list.Append("A");
            list.Append("B");
            list.Append("C");

            Console.WriteLine("Original list: " + list.ToString());

            list.Reverse();

            Console.WriteLine("Reversed list: " + list.ToString());
        }
    }
}