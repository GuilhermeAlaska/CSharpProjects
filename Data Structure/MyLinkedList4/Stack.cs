using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList4
{
    class Stack : LinkedList
    {
        public Stack(int firstValue, int secondValue) : base(firstValue, secondValue)
        {
            this.head = new(firstValue);
            this.tail = new(secondValue);

            this.head.next = this.tail;
            this.tail.prev = this.head;
            Length = 2;

        }

        public override void AddTail(int element) //Push()
        {
            base.AddTail(element);
        }
        public override void AddHead(int element)
        {
            Console.WriteLine("Você só pode adicionar elementos no topo da pilha!");
        }
        public override void RemoveTail() //Pop()
        {
            base.RemoveTail();
        }
        public override void RemoveHead()
        {
            Console.WriteLine("Você não pode remover o elemento no início da pilha. Remova no final da pilha.");
        }
        public override void Remove(int number)
        {
            Console.WriteLine("Só é possível remover o item no topo da pilha.");
        }
        public override void Clear()
        {
            Console.WriteLine("Não é possível apagar a pilha.");
        }
        public override void Find(int number)
        {
            base.Find(number);
        }
        public override void Print()
        {
            Node element = this.head;
            Console.Write("Elementos na pilha: [ ");
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
            Console.Write("Pilha invertida: [ ");
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
            Console.WriteLine($"Elemento no topo da pilha: {tail.Value}");
        }
    }
}
