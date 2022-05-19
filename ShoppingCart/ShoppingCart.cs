using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class ShoppingCart
    {




        public void ShowProductList()
        {
            int[] productNumber = { 1, 2, 3, 4, 5, 6, 7 };
            int selectedProduct;

            do
            {
                Console.WriteLine($"Selecione o produto que deseja comprar:\n1- Fone Bluetooth\n2- Mouse Gamer\n3- Teclado Gamer\n4- Monitor 120hz\n5- SSD 120gb\n6- Mousepad Razer\n7- HD 1TB\n0- Sair.\n");
                selectedProduct = Convert.ToInt32(Console.ReadLine());

            }

            while (selectedProduct != 0);


            if (productNumber.Contains(selectedProduct))
            {
                AddItemOnShoppingCart(selectedProduct, ClientFund);
            }

            else if (selectedProduct == 0)
            {

            }

            else
            {
                Console.Write("NÃO DEVERIA APARECER");
            }

        }


        public void AddItemOnShoppingCart(int selectedProduct, decimal clientFund)
        {
            decimal productValue;
            decimal clientFundAfterPurchase;

            if (selectedProduct == 1)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 2)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 3)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 4)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 5)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 6)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
            else if (selectedProduct == 7)
            {
                productValue = 150m;
                clientFundAfterPurchase = clientFund - productValue;
            }
        }


    }
}
