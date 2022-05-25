using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static void CreateFibonacciSequence(int numbers)
        {
            int previousNumber = 0;
            int nextNumber = 1;
            int fibonacciSequence;

            if (numbers > 45)
            {
                Console.WriteLine("The sequence can't be more than 45 because of the limitation of Type int");
                numbers = 45;
            }

            Console.Write("Sequência Fibonacci: { ");
            Console.Write(previousNumber + " " + nextNumber + " ");
            for (int i = 0; i < numbers; i++)
            {
                fibonacciSequence = nextNumber + previousNumber;
                previousNumber = nextNumber;
                nextNumber = fibonacciSequence;
                Console.Write(nextNumber + " ");
            }
            double proporcaoAurea = Convert.ToDouble(nextNumber) / Convert.ToDouble(previousNumber);
            Console.Write("}\n\nProporção Áurea: " + proporcaoAurea + "\n");
            Console.ReadKey();
        }
    }
}
