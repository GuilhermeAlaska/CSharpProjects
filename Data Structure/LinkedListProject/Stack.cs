using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListProject
{
    class Stack : LinkedL
    {
        public string Name { get; protected set; }

        //public Stack MyStack(int inicialCapacity)
        //{

        //}

        public System.Collections.Stack myStack = new();
        

        public Stack(string firstName) : base(firstName)
        {
            Name = firstName;
            if (Name != null)
            {
               
            }
        }
        public virtual void PersonIn(string nome)
        {

            Name = nome;
            myStack.Push(Name);
        }


    }
}
