using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues2._0
{
    class Fila
    {
        const int Capacidade = 5;
        public int Quantidade = 0;
        public int Inicio = 0;
        public int Fim = 0;
        public string[] Dados = new string[Capacidade];

        public int Tamanho()
        {
            return Quantidade;
        }

        public void InserirElemento(string valor)
        {
            if (Tamanho() == Capacidade)
            {
                int capacity = (int)((long)Capacidade * 200L / 100L);
                if (capacity < Dados.Length + 4)
                    capacity = Dados.Length + 4;
                //this.SetCapacity(capacity);
            }
            Dados[Fim] = valor;
            Fim = (Fim + 1) % Dados.Length;
            Quantidade++;
            //++this._version;

            //if(Tamanho() == Capacidade)
            //{
            //    Console.WriteLine("A Fila está cheia!");
            //}
            //else
            //{
            //    Dados[Fim] = valor;
            //    Fim = (Fim + 1) % Capacidade;
            //    Quantidade++;
            //}
        }


        public string RemoverElemento()
        {
            if (Tamanho() == 0)
                return "A Fila está vazia!";
            else
            {
                var obj = Dados[Inicio];
                Dados[Inicio] = Dados[Inicio + 1];
                Inicio = (Inicio + 1) % Capacidade;
                Quantidade--;
                
                // ++this._version;
                return obj;
            }

            //if (Tamanho() == 0)
            //{
            //    return "A Fila está vazia!";
            //}
            //else
            //{
            //    string valor = Dados[Inicio];
            //    Inicio = (Inicio + 1) % Capacidade;
            //    Quantidade--;
            //    return valor;
            //}
        }

        public void Imprimir() // Print
        {
            foreach (var item in Dados)
            {
                Console.WriteLine(item);
            }

            //int i = 0;
            //Console.Write($"Fila: [ ");
            //for (i = 0; i < Fim;)
            //{
            //    Console.Write(Dados[i % Capacidade] + " ");
            //    i++;
            //}
            //Console.Write("]\n");
        }



    }
}
