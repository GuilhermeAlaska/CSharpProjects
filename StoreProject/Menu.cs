using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    class Menu
    {

        public static void ShowMenu()
        {
            Console.WriteLine($"Bem vindo(a).\n\nDigite a opção que você deseja:\n1- Ver lista de produtos.\n2-Ver carrinho.\n3-Gerar Pedido.\n\n0- Sair.\n");
            int menuOption = Convert.ToInt32(Console.ReadLine());

            switch (menuOption)
            {
                case 1:
                    Product.ShowProductList();                    
                    break;
                case 2:
                    Cart.ShowProductsOnCart();
                    break;
                case 3:
                    Order.GenerateOrder();
                    break;
            }
        }




    }
}
