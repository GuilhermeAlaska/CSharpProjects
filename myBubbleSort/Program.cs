using System;
using System.Collections.Generic;

namespace myBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = GetUserInputsIntoArray();

            PrintArray("Array original", myArray);

            BubbleSort(myArray);

            PrintArray("Array ordenado", myArray);
        }

        static int[] GetUserInputsIntoArray()
        {
            Console.WriteLine("Digite os itens para serem ordenados depois digite 'ok' para confirmar.");

            string input;

            var inputList = new List<int>();

            do
            {
                input = Console.ReadLine();

                if (CanParseToInt(input))
                    inputList.Add(Convert.ToInt32(input));

                else if (input != "ok")
                    Console.WriteLine($"{input} não é um número válido");

            }
            while (input != "ok");

            return inputList.ToArray();
        }

        static bool CanParseToInt(string input)
        {
            if (Int32.TryParse(input, out int number))
                return true;
            else
                return false;
        }

        static void BubbleSort(int[] myArray)
        {
            int temp;

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[i])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
        }

        static void PrintArray(string arrayName, int[] myArray)
        {
            Console.Write($"{arrayName}: [ ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.Write("]\n");
        }
    }
}
