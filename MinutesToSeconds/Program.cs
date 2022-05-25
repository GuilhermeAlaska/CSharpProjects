using System;

namespace MinutesToSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input how many minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int seconds = (minutes * 60);

            Console.WriteLine($"{minutes} minutes in seconds are {seconds} seconds.");
        }
    }
}
