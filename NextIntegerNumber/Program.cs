using System;

namespace NextIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int nextInteger = (number + 1);

            Console.WriteLine($"The next integer after {number} is {nextInteger}.");
        }
    }
}
