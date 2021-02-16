using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class ComptesCheque
    {
        private List<Cheque> cheques = new List<Cheque>();

        public void AjouterCompteCheque(string numeroNIP, int numeroCompte, decimal soldeCompte)
        {
            var compte = new Cheque(numeroNIP, numeroCompte, soldeCompte);
            cheques.Add(compte);
        }

        public Cheque GetCompteCheque(string numeroNIP)
        {
            return cheques.FirstOrDefault(c => c.GetNumeroNIP == numeroNIP);
        }

        public List<Cheque> ListCompteCheque()
        {
            return cheques.ToList();
        }
    }
}
