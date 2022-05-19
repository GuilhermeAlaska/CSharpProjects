using System;

namespace OOP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;
            msg1 = new Mensagem(); // It's creating a method inside message class.
            msg1.TextoMensagem = "Hello World";

            
            Console.ReadKey();
        }
    }
}
