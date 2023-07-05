using System.Collections.Generic;

namespace linked_list_insertions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            insertions_linked_list list = new();
            list.Append("1");
            list.Append("4");
            list.Append("2");
            list.Append("7");
            Console.WriteLine("I want to Insert '5' After '4'");
            list.InsertAfter("4", "5");
            Console.WriteLine(list.ToString());
            Console.WriteLine("I want to Insert '0' before '1'");
            list.InsertBefore("1", "0");
            Console.WriteLine(list.ToString());
        }
    }
}