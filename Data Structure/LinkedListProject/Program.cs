using System;
using System.Collections.Generic;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedL a = new("Marcus");
            a.PersonIn("Leon");
            a.PersonIn("Potter");
            a.PersonOut();
            
            a.IndexPerson("Leon");

            a.PeopleInQueue();


        }
    }
}
