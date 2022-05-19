using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    public static class Product
    {

        public static void ShowProductList()
        {
            int[] productNumber = { 1, 2, 3, 4, 5, 6, 7 };
            int selectedProduct;


            Console.WriteLine("\nLista de Produtos:\n\n1- Fone Bluetooth\n2- Mouse Gamer\n3- Teclado Gamer\n4- Monitor 120hz\n5- SSD 120gb\n6- Mousepad Razer\n7- HD 1TB\n8-Voltar ao menu principal.\n\n0- Sair.\n");

            selectedProduct = Convert.ToInt32(Console.ReadLine());


            if (productNumber.Contains(selectedProduct))
            {
                Cart.InsertItemOnCart(selectedProduct);
                ShowProductList();
            }
            else if (selectedProduct == 8)
            {
                Menu.ShowMenu();
            }
            else if (selectedProduct == 0)
            {
                Console.WriteLine("\nAdeus!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.\n");
                ShowProductList();
            }

        }

        public static string ShowProductName(int productId)
        {
            string returnPhrase = String.Empty;

            switch (productId)
            {
                case 1:

                    returnPhrase = "1- Fone Bluetooth\n";
                    break;

                case 2:
                    returnPhrase = "2- Mouse Gamer\n";
                    break;

                case 3:

                    returnPhrase = "3- Teclado Gamer\n";
                    break;

                case 4:
                    returnPhrase = "4- Monitor 120hz\n";
                    break;

                case 5:

                    returnPhrase = "5- SSD 120gb\n";
                    break;

                case 6:

                    returnPhrase = "6- Mousepad Razer\n";
                    break;

                case 7:

                    returnPhrase = "7- HD 1TB\n";
                    break;
            }

            return returnPhrase;

        }

        public static void ShowProductInfo(int id)
        {
            //int[] productId = {1, 2, 3, 4, 5, 6, 7};
            string[] productName = { "Fone Bluetooth\n", "Mouse Gamer\n", "Teclado Gamer\n", "Monitor 120hz\n", "SSD 120gb\n", "Mousepad Razer\n", "HD 1TB\n" };
            decimal[] productValue = { 129.90m, 119.90m, 209.99m, 549.99m, 139.90m, 59.90m, 210.90m };



            Console.WriteLine($"Produto: {id} {productName[id - 1]}Preço: R$ {productValue[id - 1]}\n");


            //for (int i = 0; i < productId.Length;)
            //{
            //    if(i == id)
            //    {
            //        //List[] product1Info = new { productId[i], productName[i], productValue[i] };
            //        Console.WriteLine($"Produto: {productId[i]} {productName[i]}\nPreço: R$ {productValue[i]}");
            //        break;
            //    }
            //    else
            //    {
            //        i++;
            //    }

            //}


        }


    }
}
