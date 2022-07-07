
class Program
{

    static void Main(string[] args)
    {
        // ATM Project
        Console.WriteLine("Bem-vindo ao Rachadinha Bank!\nPor favor digite o número de sua conta:\n");

        string accountNumber = Console.ReadLine();

        decimal accountGui = 17872.83m;
        decimal accountLouis = 9826.45m;
        decimal accountIara = 10372.67m;
        decimal accountArthur = 27928.91m;

        

        if (accountNumber == "1")
        {
            Console.WriteLine($"\nBem-vindo Guilherme, seu saldo é R$ {accountGui} .");
            Power(17872.83m, 0m);
            
            
        } 
        
        else if (accountNumber == "2") {
            Console.WriteLine($"\nBem-vindo Louis, seu saldo é R$ {accountLouis} .");
        }

        else if (accountNumber == "3") {
            Console.WriteLine($"\nBem-vinda Iara, seu saldo é R$ {accountIara} .");
        }

        else if (accountNumber == "4") {
            Console.WriteLine($"\nBem-vindo Arthur, seu saldo é R$ {accountArthur} .");
        } 

        else
        {
            Console.WriteLine("\nDigite um número de conta válido.");
        }
        
        //accountGui == Power(newFunds);
        


        //switch (accountNumber)
        //{
        //    case "1":
        //        Console.WriteLine($"\nBem-vindo Guilherme, seu saldo é R$ {accountGui} .");
        //        break;
        //    case "2":
        //        Console.WriteLine($"\nBem-vindo Louis, seu saldo é R$ {accountLouis} .");
        //        break;
        //    case "3":
        //        Console.WriteLine($"\nBem-vinda Iara, seu saldo é R$ {accountIara} .");
        //        break;
        //    case "4":
        //        Console.WriteLine($"\nBem-vindo Arthur, seu saldo é R$ {accountArthur} .");
        //        break;

        //    default:
        //        Console.WriteLine("\nDigite um número de conta válido.");
        //        break;
        //}



        //Console.WriteLine("\nO que você deseja? \n1 - Sacar\n2 - Transferência\n3 - Depositar\n4 - Sair\n ");
        //string accountMovement = Console.ReadLine();




        Console.ReadKey();
    }

    //static void Power(string[] args)
    static void Power(decimal accountFunds, decimal newFunds)
    {
        Console.WriteLine("\nO que você deseja? \n1 - Sacar\n2 - Transferência\n3 - Depositar\n4 - Sair\n ");
        string accountMovement = Console.ReadLine();

        if (accountMovement == "1")
        {

            Console.WriteLine("\nQuanto você deseja sacar?\n");
            decimal saque = Convert.ToDecimal(Console.ReadLine());

            //double saque = Convert.ToDouble(Console.ReadLine());
            //int saque = Convert.ToInt32(Console.ReadLine());
            newFunds = accountFunds - saque;
           // decimal novoSaldo = accountFunds - saque;
            Console.WriteLine($"\nSeu novo saldo é: R$ {newFunds}.\n\nAperte qualquer botão para sair.\n\nRachadinha Bank agradece seu uso!");
           // Power(newFunds) == novoSaldo;

        }
        else if (accountMovement == "2") {

            Console.WriteLine("\nQuanto você deseja sacar?\n");
            decimal transfer = Convert.ToDecimal(Console.ReadLine());




        }



    }
}