using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList3
{
    class Node
    {
        public Node prev;
        public Node next;
        public int Value;


        public Node(int value)
        {
            prev = null;
            next = null;

            Value = value;
            
        }

    }
    class LinkedList
    {
        public Node head;
        public Node tail;
        public int Length;


        public LinkedList(int firstValue)
        {
            Node firstElement = new(firstValue);
            this.head = firstElement;
            this.tail = this.head;
            Length = 1;
        }

        public void AddHead(int element)
        {
            Node newHead = new(element);
            if (Length >= 1)
            {
                newHead.next = this.head;
                this.head.prev = newHead;
                this.head = newHead;
                this.Length++;
            }
        }

        public void Print()
        {
            Node element = this.head;
            for (int i = 0; i < this.Length; i++)
            {
                Console.WriteLine(element.Value);

                element = element.next;
            }

        }
        

    }
}
