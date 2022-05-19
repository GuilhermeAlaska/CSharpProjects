using System;

namespace myBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 7, 4, 8, 2, 1 };

            Console.Write("Itens: [ ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.Write("]\n");


            int temp;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if(myArray[j] < myArray[i])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            Console.Write("Itens: [ ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.Write("]");
        }

    }
}
