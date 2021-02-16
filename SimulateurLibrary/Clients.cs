using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Clients
    {
        private List<Client> listClients = new List<Client>();

        public void AjouterClient(string nom, string numeroNIP)
        {
            Client client = new Client(nom, numeroNIP);
            listClients.Add(client);
        }

        public Client GetClient(string nom, string numeroNIP)
        {
            return listClients.FirstOrDefault(c => c.GetNom() == nom && c.GetNumeroNIP() == numeroNIP);
        }


        public List<Client> ListClients()
        {
            return listClients.ToList();
        }
    }
}
