using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList5
{
    class Queue : LinkedList
    {
        public Queue(int firstValue, int secondValue) : base(firstValue, secondValue)
        {
            head = new(firstValue);
            tail = new(secondValue);

            head.next = tail;
            tail.prev = head;
        }

        public override void AddHead(int element)
        {
            Console.WriteLine("Você não pode adicionar no início da fila.");
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
        public override void RemoveHead()
        {
            base.RemoveHead();
        }
        public override void RemoveTail()
        {
            Console.WriteLine("Você só pode remover elementos que estão no início da fila.");
        }
    }
}
