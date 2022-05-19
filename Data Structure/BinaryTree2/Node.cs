using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree2
{
    class Node
    {
        public Node right;
        public Node left;
        public Node prev;
        public int Value;

        public Node(int value)
        {
            Value = value;
            right = null;
            left = null;
        }



    }
}
