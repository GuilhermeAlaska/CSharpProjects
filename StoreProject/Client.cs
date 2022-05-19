using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject
{
    class Client
    {
        private string clientName;
        private int clientId;
        private string clientAddress;



        public Client(int clientId)
        {
            this.clientId = clientId;
            ValidateClientId();
            Menu.ShowMenu();
            
        }

        public void ValidateClientId()
        {
            switch (clientId)
            {
                case 1:
                    clientName = "João";
                    clientAddress = "Av. Brasil 1200";
                    Order.ReceiveClientInfo(clientId, clientName, clientAddress);

                    break;

                case 2:
                    clientName = "Maria";
                    clientAddress = "Av. Havaí 123";
                    Order.ReceiveClientInfo(clientId, clientName, clientAddress);
                    break;

                case 3:
                    clientName = "Larissa";
                    clientAddress = "Rua Quatro 44";
                    Order.ReceiveClientInfo(clientId, clientName, clientAddress);
                    break;

                case 4:
                    clientName = "Pedro";
                    clientAddress = "Rua Loop 120";
                    Order.ReceiveClientInfo(clientId, clientName, clientAddress);
                    break;

                case 5:
                    clientName = "Wilson";
                    clientAddress = "Rua do Orvalho 74";
                    Order.ReceiveClientInfo(clientId, clientName, clientAddress);
                    break;
            }



        }

        public void ClientInfoToOrder()
        {
            ValidateClientId();
        }


    }
}
