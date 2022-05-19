using System;
using System.Collections.Generic;

namespace QueuesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue a = new("Luiza");
            //a.PersonIn("Yara");
            //a.PersonIn("Lara");
            //a.PersonIn("Bia");
            //a.PersonIn("Carla");
            //a.PersonIn("Leonardo");
            //a.PersonOut();
            //a.CountPerson();
            //a.IndexOfPerson("Carlos");
            //a.IndexOfPerson("Carla");

            Queue<int> b = new();
            b.Enqueue(3);
            b.Enqueue(34);
            b.Enqueue(32);
            
            Console.WriteLine(b.Contains(32));
            Console.WriteLine(b.Peek());
            Console.WriteLine(b);
        }
    }
}
