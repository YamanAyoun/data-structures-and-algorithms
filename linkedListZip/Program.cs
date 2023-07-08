namespace linkedListZip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linked_list_zip list1 = new();
            list1.Append("1");
            list1.Append("3");
            list1.Append("2");
            Console.WriteLine(list1.ToString());

            linked_list_zip list2 = new();
            list2.Append("5");
            list2.Append("9");
            list2.Append("4");
            Console.WriteLine(list2.ToString());

            linked_list_zip zippedList = linked_list_zip.ZipList(list1, list2);
            Console.WriteLine(zippedList.ToString());
        }
    }
}