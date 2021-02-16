using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class Client
    {
        private string _nom;
        private string _numeroNIP;

        public string GetNom() { return _nom; }
        public string GetNumeroNIP() { return _numeroNIP; }

        public Client(string nom, string numeroNIP)
        {
            _nom = nom;
            _numeroNIP = numeroNIP;
        }
    }

}
