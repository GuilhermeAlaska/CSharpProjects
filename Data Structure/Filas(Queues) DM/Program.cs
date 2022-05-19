using System;

namespace Filas_Queues__DM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue fila1 = new();
            int opcao;

            Console.WriteLine("Programa gerador de filas.\n");

            do
            {
                Console.WriteLine("\nDigite 0 para parar o programa.");
                Console.WriteLine("Digite 1 para inserir um elemento.");
                Console.WriteLine("Digite 2 para remover um elemento.");
                Console.WriteLine("Digite 3 para imprimir a fila.");
                Console.WriteLine("Digite 4 para buscar um elemento na fila.");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    int item;
                    Console.WriteLine("\nDigite o elemento a ser inserido: \n");
                    item = Convert.ToInt32(Console.ReadLine());

                    fila1.Inserir(item);
                }
                else if (opcao == 2)
                {
                    fila1.Remover();
                    //Console.WriteLine($"Elemento removido: {fila1.Remover()}");
                    //if (fila1.Remover() != 0)
                    //{
                    //    Console.WriteLine($"Elemento removido: {fila1.Remover()}");
                    //}
                    // pilha1.Remover();
                }
                else if (opcao == 3)
                {
                    fila1.Imprimir();
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o número a ser procurado na pilha: ");
                    fila1.IndexOfNumber(Convert.ToInt32(Console.ReadLine()));
                }

            } while (opcao != 0);

            
        }
    }
}
