using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkedList1
{
    class SinglyLinkedList
    {
        private Node start;

        public SinglyLinkedList()
        {
            start = null;
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new(data);

            if(start == null)
            {
                start = temp;
                return;
            }

            p = start;

            while (p.link != null)
                p = p.link;
            p.link = temp;

        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }


        }

    }
}
