using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PlaylistProjectWithDatabase
{
    class Menu
    {
        Database db = new();
        public Menu()
        {
            db.InitializeConnection();
            IniciarPrograma();
        }
        void IniciarPrograma()
        {
            Console.Clear();
            int opcao;
            Console.WriteLine("Bem vindo\nDigite sua opção:\n1- Inserir nova música.\n2- Mostrar lista completa de músicas.\n3- Atualizar um valor na tabela.\n4- Visualizar quantidade de itens na tabela.");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nDigite o nome da música:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("\nDigite o autor da música:");
                    string autor = Console.ReadLine();
                    Console.WriteLine("\nDigite o genêro da música:");
                    string genero = Console.ReadLine();

                    db.InsertInto(nome, autor, genero);
                    Console.WriteLine("Música inserida com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Lista de músicas:\n");
                    db.SelectAll();
                    break;
                case 3:
                    Console.WriteLine("\nQual campo vai ser atualizado?");
                    string columnToUpdate = Console.ReadLine();

                    Console.WriteLine("\nDigite o novo valor:");
                    string newValue = Console.ReadLine();

                    Console.WriteLine("\nQual a coluna de referência?");
                    string referenceColumn = Console.ReadLine();

                    Console.WriteLine("\nValor da referência:");
                    string referenceValueInTable = Console.ReadLine();

                    db.Update(columnToUpdate, newValue, referenceColumn, referenceValueInTable);
                    break;
                case 4:
                    Console.Write("Número de itens: ");
                    db.Count();
                    break;
            }
            //Thread.Sleep(10000);
            Console.ReadKey();
            IniciarPrograma();
        }

    }
}
