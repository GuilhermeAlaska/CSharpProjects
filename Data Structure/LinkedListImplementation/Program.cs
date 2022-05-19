using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new();
            linkedList.AddNodeToFront(5);

            linkedList.PrintList();
        }
    }
}
