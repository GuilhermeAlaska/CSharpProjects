using System;
using System.Collections;

namespace Stacks_DouglasMaioli
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new();
            int opcao;

            Console.WriteLine("Programa gerador de pilhas.\n");
            do
            {
                Console.WriteLine("\nDigite 0 para parar o programa.");
                Console.WriteLine("Digite 1 para inserir um elemento.");
                Console.WriteLine("Digite 2 para remover um elemento.");
                Console.WriteLine("Digite 3 para imprimir a pilha.");
                Console.WriteLine("Digite 4 para buscar um elemento na pilha.");
                Console.WriteLine("Digite 5 para apagar a pilha.\n");

                opcao = Convert.ToInt32(Console.ReadLine());

                if(opcao == 1)
                {
                    int item;
                    Console.WriteLine("\nDigite o elemento a ser inserido: \n");
                    item = Convert.ToInt32(Console.ReadLine());

                    pilha1.Inserir(item);
                }
                else if(opcao == 2)
                {
                    if (pilha1.Remover() != 0)
                    {
                        Console.WriteLine($"Elemento removido: {pilha1.Remover()}");
                    }
                   // pilha1.Remover();
                } 
                else if(opcao == 3)
                {
                    pilha1.Imprimir();
                } 
                else if(opcao == 4)
                {
                    Console.Write("Digite o número a ser procurado na pilha: ");
                    pilha1.IndexOfNumber(Convert.ToInt32(Console.ReadLine()));
                }
                else if (opcao == 5)
                {
                    pilha1.DestruirPilha();
                }

            }
            while (opcao != 0);
            
        }
    }
}
