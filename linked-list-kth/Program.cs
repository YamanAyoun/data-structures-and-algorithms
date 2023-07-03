namespace linked_list_kth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linked_List_kth list = new Linked_List_kth();

            list.Append("2");
            list.Append("3");
            list.Append("5");
            list.Append("6");

            Console.WriteLine(list.ToString());
            Console.WriteLine(list.KthFromEnd(3));

        }
    }
}