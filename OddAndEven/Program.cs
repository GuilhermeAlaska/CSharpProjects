using System;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max_itens = 2;
            int[] sampleNumber = new int[max_itens];


            //for (int index = 0; index < max_itens; index++)
            //{
            //    Console.Write("Digite o número a ser verificado: ");
            //    sampleNumber[index] = Convert.ToInt32(Console.ReadLine());
            //}
            
            //foreach (var number in sampleNumber)
            //{

            //    if ((number % 2) == 0)
            //    {
            //        Console.WriteLine($"O número {number} é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"O número {number} é ímpar.");
            //    }

            //}
            var x = 100;
            int contador = 0;

            for (int i = 0; i < x; i++)
            {
                contador++;
                if((contador %2) == 0)
                {
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
