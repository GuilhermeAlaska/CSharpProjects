using System;
using System.Collections.Generic;

namespace QueuesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] vs = {"Carro", "Moto", "Navio", "Avião" };
            //Queue<string> veiculos = new Queue<string>(vs); // To create a queue already giving it values to start

            Queue<string> veiculos = new();

            veiculos.Enqueue("Carro");
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");

            string v = "Avião";

            if (veiculos.Contains(v))
            {
                Console.WriteLine("Veículo {0} encontrado.", v);
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }

            //veiculos.Clear();  Clear the queue
            //Console.WriteLine("Primeiro veículo: " + veiculos.Dequeue()); // Dequeue takes out the first element of the queue / FIFO

            //Console.WriteLine("Primeiro veículo: " + veiculos.Peek()); // Searchs for the first element, but does not take him out of the queue

            foreach(string ve in veiculos)
            {
                Console.WriteLine("Veículo " + ve); // It is not taking the vehicles out of the queue
            }

            while(veiculos.Count > 0)
            {
                Console.WriteLine(veiculos.Dequeue());
            }

            Console.WriteLine("Tamanho fila: " + veiculos.Count); // Count returns a int


        }
    }
}
