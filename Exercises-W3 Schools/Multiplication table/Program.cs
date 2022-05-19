using System;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiply = 0, total;
            
            Console.WriteLine("Input the number to see it's multiplication table:\n");
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                total = number* multiply;
                Console.WriteLine($"\n{number} * {multiply} = {total}");
                multiply++;
            } 
            while (multiply <= 10);
        }
    }
}
