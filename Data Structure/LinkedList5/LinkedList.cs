using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList5
{
    class LinkedList
    {
        public Node head;
        public Node tail;
        public int Length;
        public LinkedList(int firstValue, int secondValue)
        {
            this.head = new(firstValue);
            this.tail = new(secondValue);

            this.head.next = this.tail;
            this.tail.prev = this.head;
            Length = 2;
        }

        public virtual void AddHead(int element)
        {
            Node newHead = new(element);

            if (Length >= 2)
            {
                newHead.next = this.head;
                this.head.prev = newHead;
                this.head = newHead;
                Length++;
            }
        }
        public virtual void AddTail(int element)
        {
            Node newTail = new(element);
            if(Length >= 2)
            {
                newTail.prev = this.tail;
                this.tail.next = newTail;
                this.tail = newTail;
                Length++;
            }
        }
        public virtual void Clear()
        {
            Console.WriteLine("Após usar o clear não será possível usar a lista, deseja mesmo apaga-lá?\n1-Sim\n2-Não");
            string opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.WriteLine("Lista apagada!");
                tail = null;
                this.head = this.tail;
            }
        }
        public virtual void Contains(int number)
        {
            Node element = head;
            bool numberFound = false;
            for (int i = 0; i < Length; i++)
            {
                if (number == element.Value)
                {
                    Console.WriteLine($"Número {number} encontrado no index {i}.");
                    numberFound = true;
                    break;
                }
                else
                {
                    element = element.next;
                }
            }
            if (!numberFound)
            {
                Console.WriteLine("Número não encontrado.");
            }

        }
        public virtual void Print()
        {
            Node element = this.head;

            Console.Write("Elementos na lista linkada: [ ");
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
        private void Remove(int number)
        {
            Node element = head;
            if (Length > 2)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (number == element.Value)
                    {
                        if (i == 0)
                        {
                            RemoveHead();
                        }
                        else if (i == (Length - 1))
                        {
                            RemoveTail();
                        }
                        else
                        {
                            element.next.prev = element.prev;
                            element.prev.next = element.next;
                            Length--;
                        }
                        break;
                    }
                    else
                    {
                        element = element.next;
                    }
                }
                if (element == null)
                {
                    Console.WriteLine("Elemento não removido pois não está na lista.");
                }
            }
            
        }
        public virtual void RemoveHead()
        {
            if(Length <= 2)
            {
                Console.WriteLine("Não é possível remover elemento.");
            }
            else
            {
                this.head = this.head.next;
                Length--;
            }
        }
        public virtual void RemoveTail()
        {
         if(Length <= 2)
            {
                Console.WriteLine("Não é possível remover elemento.");
            }
            else
            {
                this.tail = this.tail.prev;
                Length--;
            }
        }
    }
}
