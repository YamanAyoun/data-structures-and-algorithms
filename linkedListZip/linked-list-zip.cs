using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListZip
{
    public class linked_list_zip
    {
        Node Head;
        public void Append(string newValue)
        {
            Node node = new Node(newValue);
            Node last = Head;
            if (Head == null)
            {
                Head = new Node(newValue);
                return;
            }
            else
            {
                while (last.Next != null)
                    last = last.Next;
                last.Next = node;
            }
        }

        public static linked_list_zip ZipList(linked_list_zip firstList, linked_list_zip secondList)
        {
            linked_list_zip zipList = new linked_list_zip();
            Node current1 = firstList.Head;
            Node current2 = secondList.Head;
            while (current1 != null && current2 != null)
            {
                zipList.Append(current1.Data);
                current1 = current1.Next;
                zipList.Append(current2.Data);
                current2 = current2.Next;
            }

            while (current1 != null)
            {
                zipList.Append(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                zipList.Append(current2.Data);
                current2 = current2.Next;
            }
            return zipList;
        }
        public string ToString()
        {
            string result = "";

            if (Head == null)
            {
                return "Nothing in the List";
            }
            else
            {
                Node current = Head;
                while (current != null)
                {
                    result += "{" + current.Data + "} -> ";
                    current = current.Next;
                }
            }

            return result + "NULL";
        }
    }
}
