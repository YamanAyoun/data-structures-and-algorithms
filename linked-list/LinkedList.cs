using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    public class LinkedList
    {
        public Node Head;

        public void Insert(string value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public bool Includes(string value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
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
