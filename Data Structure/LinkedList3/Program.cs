using System;

namespace LinkedList3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new(3);

            list.AddHead(4);
            list.AddHead(3);
            list.AddHead(1);
            Console.WriteLine(list.tail);
            list.Print();
        }
    }
}
