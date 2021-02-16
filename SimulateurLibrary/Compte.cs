using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Compte
    {
        private string _numeroNIP;
        private int _numeroCompte;
        private decimal _soldeCompte;
        private decimal _retraitMaximum = 1000;
        private decimal _montantTransfertMaximum = 100000;

        public string GetNumeroNIP => _numeroNIP;
        public int GetNumeroCompte => _numeroCompte;
        public decimal GetSoldeCompte => _soldeCompte;

        public Compte(string numeroNIP, int numeroCompte, decimal soldeCompte)
        {
            _numeroNIP = numeroNIP;
            _numeroCompte = numeroCompte;
            _soldeCompte = soldeCompte;
        
        }

        public decimal Retrait(decimal montant)
        {
            if (_soldeCompte < montant)
                throw new Exception($"Solde compte courant est plus petit que le montant saisi. Solde courant: $ {_soldeCompte}");

            return _soldeCompte = _soldeCompte - montant;
        }

        public decimal Depot(decimal montant)
        {
            return _soldeCompte = _soldeCompte + montant;
        }
    }
}


 
