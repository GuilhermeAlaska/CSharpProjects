using System;

namespace Monthly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert days to count: ");
            Monthly month = new(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
