using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("Carro");
            transp.AddFirst("Avião");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");
            transp.AddLast("Bicicleta"); // Last item of the list

            LinkedListNode<string> no; // It's creating a separated node, to manipulate
            no=transp.FindLast("Navio"); // Finding the last position of Navio
            transp.AddAfter(no, "Patinete");
            transp.AddBefore(no, "Patins");

            // transp.Clear(); Deletes all elements

            transp.Remove("Carro");
            //transp.Find("Carro"); If the element is found, returns true
            if(transp.Find("Carro") == null)
            {
                Console.WriteLine("Elemento não encontrado.");
            }
            else
            {
                Console.WriteLine("O elemento foi encontrado.");
            }
            transp.RemoveFirst();
            transp.RemoveLast();


            foreach (string t in transp)
            {
                Console.WriteLine("Transporte: {0}", t);
            }


        }
    }
}
