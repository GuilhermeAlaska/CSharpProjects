using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesProject
{
    class Queue
    {
        public string Name { get; protected set; }
        public int QueueLength { get; set; }

        Queue<string> queue = new();

        
        public Queue(string name)
        {

            Name = name;
            if(Name != null)
            {
                queue.Enqueue(Name);
                QueueLength = 1;
            }

        }


        public virtual void PersonIn(string name)
        {
            queue.Enqueue(name);
        }

        public virtual void PersonOut()
        {
            var s = queue.Peek();
            Console.WriteLine($"A pessoa \"{s}\" saiu.\n");
            queue.Dequeue();
        }


        public virtual void CountPerson()
        {
            int index = 0;
            foreach (string name in queue)
            {
                
                Console.WriteLine("Nome: " + name + ". Posição na fila: " + index + ".\n");
                index++;
            }
        }

        public virtual void IndexOfPerson(string name)
        {
            int index = 0;
            bool personFound = false;

            foreach (string person in queue)
            {
                if(name == person)
                {
                    Console.WriteLine($"\"{name}\" foi encontrado(a) na posição {index}.");
                    personFound = true;
                    break;
                }

            index++;
            }

            if(!personFound)
            {
                Console.WriteLine($"A pessoa \"{name}\" não foi encontrada.");
            }

        }


    }
}
