using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList4
{
    class Node
    {
        public Node prev;
        public Node next;
        public int Value;

        public Node(int value)
        {
            prev = null;
            next = null;

            Value = value;
        }
    }
}
