using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Epargne : Compte
    {
        const decimal tauxInteret = 0.01m;

        public Epargne(string numeroNIP, int numeroCompte, decimal soldeCompte)
            : base(numeroNIP, numeroCompte, soldeCompte)
        {

        }

        public decimal PaiementInteret()
        {
            var interet = GetSoldeCompte * tauxInteret / 365 / 100;

            return Depot(interet);
        }
    }
}

