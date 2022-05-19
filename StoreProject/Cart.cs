using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    public static class Cart
    {
        const int maxItensCart = 5; // maxitens
        public static int ShoppingCartTotalSize = 0; // tamanho
        private static int[] shoppingCart = new int[maxItensCart]; // estrutura



        public static void InsertItemOnCart(int productNumber)
        {
            if (FullCart())
            {
                Console.WriteLine("Impossível adicionar.\nCarrinho cheio!");
            }
            else
            {
                shoppingCart[ShoppingCartTotalSize] = productNumber;
                ShoppingCartTotalSize++;
                Console.WriteLine($"\nProduto {productNumber} adicionado ao carrinho!");
            }

        }


        public static void RemoveItemFromCart()
        {

            if (EmptyCart())
            {
                Console.WriteLine("Não há itens no carrinho.");
            }
            else
            {
                ShoppingCartTotalSize--;

            }
        }

        public static bool FullCart()
        {
            return ShoppingCartTotalSize == maxItensCart;
        }
        public static bool EmptyCart()
        {
            return ShoppingCartTotalSize == 0;
        }


        public static void ShowProductsOnCart()
        {
            if (FullCart()) { }
            else if (EmptyCart())
            {
                Console.WriteLine("Não há itens no carrinho.");
            }
            else
            {
                foreach (var product in shoppingCart)
                {
                    Console.WriteLine(Product.ShowProductName(product));
                }
            }

        }

        public static void ProductInfoToOrder()
        {
            for (int i = 0; i < ShoppingCartTotalSize; i++)
            {
                Product.ShowProductInfo(i);
            }
        }


    }
}
