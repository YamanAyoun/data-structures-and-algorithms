namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Insertion");
            LinkedList list = new();
            list.Insert("lastHead");
            list.Insert("NewHead");
            Console.WriteLine("This is my list");
            Console.WriteLine(list.ToString());
        }
    }
}