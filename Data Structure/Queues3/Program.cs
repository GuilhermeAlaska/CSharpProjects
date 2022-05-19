using System;
using System.Collections.Generic;

namespace Queues3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myqueue = new(5);

            myqueue.Enqueue(0);
            myqueue.Enqueue(10);
            myqueue.Enqueue(100);
            myqueue.Enqueue(1000);
            myqueue.Enqueue(10000);

            myqueue.Print();

            myqueue.Dequeue();
            myqueue.Dequeue();
            myqueue.Print();



            Queue<int> moqueue = new(3);
            moqueue.Enqueue(0);
            moqueue.Enqueue(10);
            moqueue.Enqueue(100);

            moqueue.Dequeue();

            foreach (var item in moqueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
