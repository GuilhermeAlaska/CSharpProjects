using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree3
{
    class Node
    {
        public Node right;
        public Node left;
        public int Value;

        public Node(int value)
        {
            right = null;
            left = null;
            Value = value;
        }

    }
}
