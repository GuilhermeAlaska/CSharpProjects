using System;

namespace TwoEqualValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, total;
            Console.WriteLine("Welcome, please input the first value:\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease input the second value:\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            SumTriple(number1, number2);

            //if (number1 == number2)
            //{
            //    total = (number1 + number2) * 3;
            //    Console.WriteLine($"Because the two inputs are equal, we add them, then multiply by 3. So the total is: {total}");
            //} else
            //{
            //    total = number1 + number2;
            //    Console.WriteLine($"Since they're not equal, heres the sum of the two inputs: {total}");
            //}
        }

        public static int SumTriple(int a, int b)
        {
            Console.WriteLine(a == b ? (a + b) * 3 : a + b);
            return a == b ? (a + b) * 3 : a + b;
            
        }
    }
}
