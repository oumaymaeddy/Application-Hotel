using System;
using System.Collections;

namespace ApplicationGrestion_Hotels
{
    class Hotel
    {
        public ArrayList Clients { get; set; }

        public Hotel()
        {
            Clients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }
}

       
        
    

