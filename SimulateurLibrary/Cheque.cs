using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Cheque : Compte
    {
        const decimal fraisPaiementFacture = 1.25m;
        const decimal montantFactureMaximum = 10000;

        public Cheque(string numeroNIP, int numeroCompte, decimal soldeCompte) 
            : base(numeroNIP, numeroCompte, soldeCompte)
        {
           
        }

        public decimal PaiementFacture(decimal montant)
        {
            if (montant > montantFactureMaximum)
                throw new Exception($"Le montant excède la valeur maximum permis {montantFactureMaximum}.");

            return Retrait(montant + fraisPaiementFacture);
            
        }
    }
}

