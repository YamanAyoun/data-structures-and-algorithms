﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    public class Stack
    {
        public Node top = null;

        public void Push(string value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.Next = top;
                top = node;
            }
        }

        public string Pop()
        {
            Node temp = top;
            if (IsEmpty())
            {
                throw new Exception("The Stack is Empty");
            }

            top = top.Next;
            temp.Next = null;
            return temp.Data;
        }

        public string Peek()
        {
            if (top == null)
            {
                throw new Exception("The Stack is Empty");
            }
            else
                return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public String ToString()
        {
            string result = "";

            if (top == null)
            {
                return "The Stack is Empty";
            }
            else
            {
                Node current = top;
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
