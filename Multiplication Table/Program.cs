using System;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number to see it's multiplication table:\n");
            
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}