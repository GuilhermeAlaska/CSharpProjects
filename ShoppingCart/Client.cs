using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Client
    {
        const int maxItensCart = 10; // maxitens
        public int ShoppingCartTotalSize; // tamanho
        private int[] ShoppingCart; // estrutura

        private decimal ClientFund;

        public Client(string clientName)
        {
            ShoppingCartTotalSize = 0;
            ShoppingCart = new int[maxItensCart];

            ShowMenu(clientName);
            
        }

        public void ShowMenu(string clientName)
        {
            int menuChoice;
            Console.WriteLine($"Bem-vindo(a) {clientName}. Como podemos te ajudar?\n1- Mostrar saldo da conta\n2- Mostrar lista de produtos\n3- Mostrar itens no carrinho");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            if(menuChoice == 1)
            {
                ShowAccountFunds(clientName);
            } 
            else if(menuChoice == 2)
            {
                ShowProductList();
            }
            else if(menuChoice == 3)
            {

            }
            else
            {

            }

        }

        public void ShowAccountFunds(string clientName)
        {
            decimal accountFund;

            if (clientName == "j")
            {
                accountFund = 1000.74m;
                ClientFund = accountFund;
                Console.WriteLine($"{clientName} seu saldo é R$ {accountFund}.");
            }

            else if (clientName == "")
            {
                accountFund = 1200.91m;
                ClientFund = accountFund;
                Console.WriteLine($"{clientName} seu saldo é R$ {accountFund}.");
            }

            else if (clientName == "")
            {
                accountFund = 1430.54m;
                ClientFund = accountFund;
                Console.WriteLine($"{clientName} seu saldo é R$ {accountFund}.");
            }

            else if (clientName == "")
            {
                accountFund = 980.72m;
                ClientFund = accountFund;
                Console.WriteLine($"{clientName} seu saldo é R$ {accountFund}."); 
            }

            else if (clientName == "")
            {
                accountFund = 846.15m;
                ClientFund = accountFund;
                Console.WriteLine($"{clientName} seu saldo é R$ {accountFund}.");
            }
            else
            {
                Console.WriteLine($"Nome \"{clientName}\" não encontrado no banco de dados");
            }
        }


       

       


        public void InsertItemOnCart(int productNumber)
        {
            if (FullCart())
            {
                Console.WriteLine("Impossível adicionar.\nCarrinho cheio!");
            }
            else
            {
                ShoppingCart[ShoppingCartTotalSize] = productNumber;
                ShoppingCartTotalSize++;
            }

        }
        public virtual void RemoveItemFromCart()
        {

            if (EmptyCart())
            {
                Console.WriteLine("Não há itens no carrinho.");
            }
            else
            {
                ShoppingCartTotalSize--;
                //return ShoppingCart[ShoppingCartTotalSize];
            }
        }


        public virtual bool FullCart()
        {
            return (ShoppingCartTotalSize == maxItensCart);
        }
        public virtual bool EmptyCart()
        {
            return (ShoppingCartTotalSize == 0);
        }




        public void ShowProductOrder()
        {

        }

    }
}
