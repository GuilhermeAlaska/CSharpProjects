using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList5
{
    class Stack : LinkedList
    {
        public Stack(int firstValue, int secondValue) : base(firstValue, secondValue)
        {
            head = new(firstValue);
            tail = new(secondValue);

            head.next = tail;
            tail.prev = head;
        }
       
        public override void AddHead(int element)
        {
            Console.WriteLine("Você só pode adicionar itens no fim da pilha.");
        }

        public override void AddTail(int element)
        {
            base.AddTail(element);
        }
        public override void Clear()
        {
            base.Clear();
        }
        public override void Contains(int number)
        {
            base.Contains(number);
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
        public override void RemoveHead()
        {
            Console.WriteLine("Você só pode remover itens no fim da pilha.");
        }
        public override void RemoveTail()
        {
            base.RemoveTail();
        }
    }
}
