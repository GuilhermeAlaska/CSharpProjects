using System;

namespace GG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
        }
    }
}
