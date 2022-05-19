using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Implement
{
    public class Array
    {
        public int[] myArray = { -20, -23, 2, -1, 30, 19, 20 };
        public int[] y;
        int count = 1;

        public void ShowArray()
        {
            if(count == 1) {

                Console.Write($"Itens do Array: [ ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + "  ");
                }
                Console.Write("]\n");
            }

            else if(count > 1)
            {
                Console.Write($"Itens do Array Ordenado: [ ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + "  ");
                }
                Console.Write("]\n");
            }
            count++;
        }
        public void BubbleSort()
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if(myArray[j] > myArray[j + 1])
                    {
                        Troca(myArray, j);
                    }
                }
            }
        }
        public void Troca(int[] g, int primeiro)
        {
            int auxiliar = g[primeiro];

            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = auxiliar;

        }
    }
}
