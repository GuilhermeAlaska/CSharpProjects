using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_DouglasMaioli
{

    class Pilha 
    {

        //public int TipoItem { get; protected set; }
        const int max_itens = 10;
        private int Tamanho { get; set; }
        private int[] estrutura { get;}


        public Pilha() {
            Tamanho = 0;
            estrutura = new int[max_itens];
        
        } 

        public virtual void DestruirPilha()
        {
            if(estrutura != null)
            {
                Remover();
            }

            Console.WriteLine("\nPilha zerada.");
        }

        public virtual bool EstaCheia() {

            return (Tamanho == max_itens);
        }

        public virtual bool EstaVazia() {
            
            return (Tamanho == 0);
        }


        public virtual void Inserir(int item) {

            if (EstaCheia())
            {
                Console.WriteLine("A pilha está cheia.");
                Console.WriteLine("Não é possível inserir elemento");
            }
            else
            {
                estrutura[Tamanho] = item;
                Tamanho++;
            }
        }

        public virtual int Remover() {

            if (EstaVazia())
            {
                Console.WriteLine("A pilha está vazia.");
                Console.WriteLine("Não há elementos na pilha.");
                return 0;
            }
            else
            {
                Tamanho--;
                return estrutura[Tamanho];
            }
        }

        public virtual void Imprimir() {

            Console.Write("\nPilha: [");
            for(int i = 0; i < Tamanho; i++)
            {
                Console.Write(estrutura[i] + " ");
            }

            Console.Write("]\n");
            TamanhoTotal();
        }

        public virtual void TamanhoTotal() {

            Console.WriteLine($"\nTamanho da pilha: {Tamanho} itens.");
        }

        public virtual void IndexOfNumber(int numberSearch)
        {
            bool numberFound = false;
            int index = 0;
            foreach (var numbers in estrutura)
            {
                if(numbers == numberSearch)
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
