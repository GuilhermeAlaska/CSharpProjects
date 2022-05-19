using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas_Queues__DM
{
    class Queue
    {
        const int MaxItens = 5;
        public int[] Estrutura { get; }
        private int Primeiro { get; set; }
        private int Ultimo { get; set; }

        private bool EstaCheia { get => Ultimo - Primeiro == MaxItens; }
        private bool EstaVazio { get => Primeiro == Ultimo; }

        public Queue() //Construtor 
        {
            Primeiro = 0;
            Ultimo = 0;
            Estrutura = new int[MaxItens];
        }


        public void Inserir(int item) // Push / Enqueue
        {
            if (EstaCheia)
            {
                Console.WriteLine("A fila está cheia!");
                Console.WriteLine("Não foi possível inserir elemento.\n");
            }
            else
            {
                Estrutura[Ultimo % MaxItens] = item;
                Ultimo++;
            }
        }

        public void Remover() // Pop / Dequeue
        {
            if (EstaVazio)
            {
                Console.WriteLine("A fila está vazia!");
                Console.WriteLine("Nenhum elemento foi removido.\n");
                return;
            }
            else
            {
                Primeiro++;

                Estrutura[Primeiro - 1] = 0;
                
                return;
                //int[] prop = new int[max_itens];
                //primeiro++;
                //int[] provisorio = new int[max_itens];

                //for (int index = 0; index < max_itens; index++)
                //    {
                //       provisorio[index] = this.estrutura[(primeiro - 1) % max_itens];
                //    }

                //this.estrutura[max_itens] = provisorio[max_itens];

                //return this.estrutura[max_itens];
            }
        }

        public void Imprimir() // Print
        {
            int i = 0;
            Console.Write($"Fila: [ ");
            for (i = 0; i < Ultimo; i++)
            {
                Console.Write(Estrutura[i % MaxItens] + " ");
            }
            Console.Write("]\n");
        }

        public virtual void IndexOfNumber(int numberSearch)
        {
            bool numberFound = false;
            int index = 0;
            foreach (var numbers in Estrutura)
            {
                if (numbers == numberSearch)
                {
                    Console.WriteLine($"Número {numberSearch} encontrado no index {index}.");
                    numberFound = true;
                    break;
                }

                index++;
            }
            if (numberFound == false)
            {
                Console.WriteLine($"Elemento {numberSearch} não encontrado na pilha.");
            }
        }

       
    }
}
