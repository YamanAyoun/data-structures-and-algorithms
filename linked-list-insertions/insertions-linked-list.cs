using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_insertions
{
    public class insertions_linked_list
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

        public void InsertBefore(string value, string newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if (Head.Data == value)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine(value + " doesn't exist");
            }
        }

        public void InsertAfter(string value, string newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if (Head.Data == value)
            {
                newNode.Next = Head.Next;
                Head.Next = newNode;
                return;
            }

            while (current.Data != null)
            {
                if (current.Data == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine(value + " doesn't exist");
                    break;
                }
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
