using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Banque : Compte
    {
        const decimal montantMaximum = 20000;
        const decimal montantRemplissage = 5000;

        public Banque(string numeroNIP, int numeroCompte, decimal soldeCompte)
            :base(numeroNIP, numeroCompte, soldeCompte)
        {

        }

        public decimal RemplirGuichet()
        {
            var soldeTemp = GetSoldeCompte + montantRemplissage;

            if (soldeTemp > montantMaximum)
                throw new Exception($"Le montant excède la valeur maximum permis {montantMaximum}.");

            return Depot(montantRemplissage);
        }
    }
}


