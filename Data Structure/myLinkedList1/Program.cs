using System;

namespace myLinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList mylist = new();
            mylist.AddNodeToFront(5);
            mylist.AddNode(3);

            mylist.PrintList();

        }

    }
}
