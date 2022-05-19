using System;
using System.Linq;

namespace MyLinkedList4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new(1, 10);
            //list.AddHead(5);
            list.AddTail(99);
            //list.RemoveHead();
            list.RemoveTail();
            //list.Find(1002);
            //list.Clear();
            //list.AddTail(2);
            //list.Find(100);
            list.Remove(99);
            list.Print();
            //list.ReversePrint();

            //Queue q = new(1, 2);
            //q.AddTail(34);
            //q.AddTail(22);
            //q.Print();
            //q.Clear();
            //q.Print();

            //Stack s = new(01, 02);
            //s.AddTail(9);
            //s.AddTail(3);
            //s.Peek();
            //s.Print();

            Console.ReadKey();

        }
    }
}
