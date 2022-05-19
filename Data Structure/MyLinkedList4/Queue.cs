using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList4
{
    class Queue : LinkedList
    {
        public Queue(int firstValue, int secondValue) : base(firstValue, secondValue)
        {
            this.head = new(firstValue);
            this.tail = new(secondValue);

            this.head.next = this.tail;
            this.tail.prev = this.head;
            Length = 2;
        }

        public override void AddTail(int element) //Enqueue()
        {
            base.AddTail(element);

        } 
        public override void AddHead(int element)
        {
            Console.WriteLine("Você não pode adicionar itens no ínicio da fila!");
            
        }
        public override void RemoveHead() //Dequeue()
        {
            base.RemoveHead();
        } 
        public override void RemoveTail()   
        {
            Console.WriteLine("Você não pode remover itens no final da fila!");

        }
        public override void Remove(int number)
        {
            Console.WriteLine("Você não pode remover em qualquer lugar da fila!");
        }
        public override void Clear()
        {
            Console.WriteLine("Você não pode apagar a fila!");
        }
        public override void Find(int number) //Contains
        {
            bool numberFound = false;
            Node element = head;
            for (int i = 0; i < Length; i++)
            {
                if (element.Value == number)
                {
                    Console.WriteLine($"Elemento {number} encontrado no index {i + 1}.");
                    numberFound = true;
                    break;
                }
                else
                {
                    element = element.next;
                }
            }
            if (numberFound == false)
            {
                Console.WriteLine($"Elemento {number} não encontrado.");
            }
        }
        public override void Print()
        {
            Node element = this.head;
            Console.Write("Elementos na fila: [ ");
            for (int i = 0; i < this.Length; i++)
            {
                if (element != null)
                {
                    Console.Write(element.Value + " ");

                    element = element.next;
                }
            }
            Console.Write("]\n");
        }
        public override void ReversePrint()
        {
            Node element = this.tail;
            Console.Write("Fila invertida: [ ");
            for (int i = 0; i < this.Length; i++)
            {
                if (element != null)
                {
                    Console.Write(element.Value + " ");

                    element = element.prev;
                }
            }
            Console.Write("]\n");
        }
        public void Peek()
        {
            Console.WriteLine($"Elemento no início da fila: {head.Value}");
        } //Peek()
    }
}
