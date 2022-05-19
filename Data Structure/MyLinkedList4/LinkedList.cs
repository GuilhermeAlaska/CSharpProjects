using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList4
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
        
        public virtual void AddHead(int element)    //AddFirst()
        {
            Node newHead = new(element);
            if (Length >= 2)
            {
                newHead.next = this.head;
                this.head.prev = newHead;
                this.head = newHead;
                this.Length++;
            }
        }
        public virtual void AddTail(int element)    //AddLast()
        {
            Node newTail = new(element);
            if (Length >= 2)
            {
                newTail.prev = this.tail;
                this.tail.next = newTail;
                this.tail = newTail;
                this.Length++;
            }
        }
        public virtual void RemoveHead()    //RemoveFirst()
        {
            if (Length > 2)
            {
                Node oldHead = this.head;
                this.head = oldHead.next;
                this.head.prev = null;
                Length--;
            }
        }
        public virtual void RemoveTail()    //RemoveLast()
        {
            if (Length > 2)
            {
                Node oldTail = this.tail;
                this.tail = oldTail.prev;
                this.tail.next = null;
                Length--;
            }

        }
        public virtual void Remove(int number)
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
                            this.RemoveHead();
                        }
                        else if (i == (Length - 1))
                        {
                            this.RemoveTail();
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
            }
            Console.WriteLine("Teste");
        }
        public virtual void Clear()
        {
            this.head = null;
            this.tail = null;
        }
        public virtual void Find(int number)
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
        public virtual void Print()
        {
            Node element = this.head;
            Console.Write("Elementos linkados com next: [ ");
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
        public virtual void ReversePrint()
        {
            Node element = this.tail;
            Console.Write("Elementos linkados com prev: [ ");
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
    }
}
