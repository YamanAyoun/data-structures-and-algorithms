﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    public class Node
    {
        public string Data { get; set; }
        public Node Next;

        public Node(string Data)
        {
            this.Data = Data;
            Next = null;
        }
    }
}
