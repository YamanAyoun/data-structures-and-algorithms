using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_kth
{
    public class Linked_List_kth
    {
        Node Head;
        public string KthFromEnd(int k)
        {
            if (Head == null)
                return "List is Empty!";
            Node current = Head;
            Node node = Head;
            int counter = 0;
            while (current.Next != null)
            {
                counter++;
                current = current.Next;
            }

            while (node != null)
            {
                if (counter == k)
                {
                    return node.Data;
                }
                counter--;
                node = node.Next;
            }
            return "Exception";
        }

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
