using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    public static class Order
    {
        static public int clientId;
        static public string clientName;
        static public string clientAddress;

        static public int productId;
        static public string productName;
        static public decimal productPrice;


        //public Order(int clientIdC, string clientNameC, string clientAddressC)
        //{
        //    clientName = clientNameC;
        //    clientId = clientIdC;
        //    clientAddress = clientAddressC;
        //}

        public static void ReceiveClientInfo(int clientIdC, string clientNameC, string clientAddressC)
        {
            clientId = clientIdC;
            clientName = clientNameC;
            clientAddress = clientAddressC;
        }




        public static void ReceiveProductInfo(int productIdC, string productNameC, decimal productPriceC)
        {
            productId = productIdC;
            productName = productNameC;
            productPrice = productPriceC;
        }
        public static void RreceiveProductInfo()
        {
            Cart.ProductInfoToOrder();
        }

        public static void GenerateOrder()
        {

            Cart.ProductInfoToOrder();


        }

    }
}
