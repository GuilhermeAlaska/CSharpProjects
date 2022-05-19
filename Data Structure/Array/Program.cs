using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = { 1, 3, 4, 8 }
            //for(int i= 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]); > To see every number inside the array
            //}

            //int[] array = { 1, 3, 5, 7, 9 };
            //int number;
            //bool found = false;

            //Console.WriteLine("Qual número deseja procurar de 1 a 10?\n");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == number)
            //    {
            //        Console.WriteLine($"\nNumber {number} was found at {i} index.");
            //        found = true;
            //        break;
            //    }
            //}

            //if (found == false)
            //{
            //    Console.WriteLine("\nNumber was not found.");
            //} else
            //{
            //    Console.WriteLine("\nCongrats, your query has succeed!");
            //}


            //string[] nomes = { "Andre", "Bruna", "Cassio", "Deise", "Pedro" };
            //double[] altura = { 1.71, 1.78, 1.75, 1.87, 1.71 };

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(nomes[i] + "\t" + altura[i]);

            //}



            int[,] m = new int[2, 4];   // Does not use 0 index as a line / 4*2 = 8 values total

        //  10  20  30  40  
        //  50  60  80  90

            m[0, 0] = 10;   m[0, 1] = 20;    m[0, 2] = 30;   m[0, 3] = 40;
            m[1, 0] = 50;   m[1, 1] = 60;    m[1, 2] = 70;   m[1, 3] = 80;


            Console.WriteLine(m[1, 3]);
        }
    }
}
