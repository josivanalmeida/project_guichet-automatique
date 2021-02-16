using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class ComptesEpargne
    {
        private List<Epargne> listEpargnes = new List<Epargne>();

        public void AjouterCompteEpargne(string numeroNIP, int numeroCompte, decimal soldeCompte)
        {
            Epargne compte = new Epargne(numeroNIP, numeroCompte, soldeCompte);
            listEpargnes.Add(compte);
        }

        public Epargne GetCompteEpargne(string numeroNIP)
        {
            return listEpargnes.FirstOrDefault(c => c.GetNumeroNIP == numeroNIP);
        }

        public List<Epargne> ListCompteEpargne()
        {
            return listEpargnes.ToList();
        }
    }
}
