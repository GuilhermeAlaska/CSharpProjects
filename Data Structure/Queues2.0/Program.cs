using System;

namespace Queues2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Fila minhafila = new();


            minhafila.InserirElemento("'Alo'");
            minhafila.InserirElemento("'Mundo'");
            minhafila.InserirElemento("'ad'");
            minhafila.InserirElemento("'dad'");
            minhafila.InserirElemento("'ff'");
            //minhafila.InserirElemento("'qw'");

            minhafila.RemoverElemento();

            minhafila.Imprimir();





        }
    }
}
