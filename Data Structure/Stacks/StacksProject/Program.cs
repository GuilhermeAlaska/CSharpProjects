using System;
using System.Collections;
using System.Collections.Generic;

namespace StacksProject
{
    class Program
    {
        static void Main(string[] args)     // LIFO - Last In First Out
        {
            Stack<string> myStack = new();

            myStack.Push("Primeiro");
            myStack.Push("8918");
            myStack.Push("UASdk");
            myStack.Push("agp8hujnv");
            myStack.Push("aouwjnfqc");
            myStack.Push("góepivjn");
            Console.WriteLine(myStack.Peek());

            foreach (var itemInStack in myStack)
            {
                Console.WriteLine($"Item: {itemInStack}");
            }



        }
        
    }
}
