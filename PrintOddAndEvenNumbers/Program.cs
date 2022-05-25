using System;
using System.Collections.Generic;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Until wich number do you want to see? ");
            var quantity = Convert.ToInt32(Console.ReadLine());

            var oddList = new List<int>();
            var evenList = new List<int>();

            for (int number = 1; number <= quantity; number++)
            {
                if (isEven(number))
                    evenList.Add(number);

                else
                    oddList.Add(number);
            }

            PrintList("Even numbers:", evenList);
            PrintList("Odd numbers:", oddList);
        }

        static bool isEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        static void PrintList(string message, List<int> numberList)
        {
            Console.Write("\n" + message);

            Console.Write("[ ");

            foreach (var number in numberList)
            {
                Console.Write(number + " ");
            }

            Console.Write("]\n\n");
        }
    }
}
