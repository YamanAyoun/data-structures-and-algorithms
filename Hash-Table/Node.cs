using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Node
    {
        public string key { get; set; }
        public string value { get; set; }
        public Node Next { get; set; }

        public Node(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
