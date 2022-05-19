using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList5
{
    class Node
    {
        public Node next;
        public Node prev;
        public int Value;

        public Node(int value)
        {
            next = null;
            prev = null;
            Value = value;
        }

    }
}
