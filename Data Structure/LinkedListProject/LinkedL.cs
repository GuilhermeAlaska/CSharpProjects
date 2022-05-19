using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class LinkedL
    {
        public LinkedL(string name)
        {
            Name = name;
            if(Name != null)
            {
                linkedList.AddLast(Name);
            }
        }

        public string Name { get; protected set; }

        LinkedList<string> linkedList = new();


        public virtual void PersonIn(string nome)
        {
            Name = nome;
            linkedList.AddLast(Name);
        }

        public virtual void PersonOut()
        {
            var s = linkedList.Last.Value;
            Console.WriteLine($"{s} saiu da fila.");
            linkedList.RemoveLast();
        }


        public virtual void PeopleInQueue()
        {
            foreach (string people in linkedList)
            {
                Console.WriteLine("{0}", people);
            }

        }

        public virtual void IndexPerson(string personName)
        {
            if (linkedList.Find(personName) == null)
            {
                Console.WriteLine("Nome não encontrado.");
            } else
            {
                var previousPerson = linkedList.FindLast(personName).Previous.Value;
                var totalPersonInList = linkedList.Count;
                Console.WriteLine($"Sua vez é depois de {previousPerson}.\nTotal de pessoas na fila: {totalPersonInList}\n");
            }

        }
    
    }
}
