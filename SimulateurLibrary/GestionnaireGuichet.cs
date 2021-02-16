using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateurLibrary
{
    public class GestionnaireGuichet
    {
        Banque banque;
        Clients clients;
        ComptesCheque comptesCheque;
        ComptesEpargne comptesEpargne;
        decimal _soldeCompteCourant;

        public ComptesEpargne GetComptesEpargne => comptesEpargne;

        const string typeCompteBanque = "B";
        const string typeCompteCheque = "C";
        const string typeCompteEpargne = "S";

        public GestionnaireGuichet()
        {
            clients = new Clients();
            comptesCheque = new ComptesCheque();
            comptesEpargne = new ComptesEpargne();
        }

        public bool ValiderUtilisateur(string nom, string nip)
        {
            bool lecture = LireClients();

            if (lecture)
            {
                var client = clients.GetClient(nom, nip);

                if (client != null)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RetraitCheque(string nip, decimal montant)
        {
            var compte = comptesCheque.GetCompteCheque(nip);

            if (compte != null)
            {
                if(banque.GetSoldeCompte < montant)
                    throw new Exception($"Le solde du guichet est plus petit que le montant saisi. Solde disponible: $ {banque.GetSoldeCompte}");

                _soldeCompteCourant = compte.Retrait(montant);
                banque.Retrait(montant);

                return true;
            }
            return false;
        }

        public bool RetraitEpargne(string nip, decimal montant)
        {
            var compte = comptesEpargne.GetCompteEpargne(nip);

            if (compte != null)
            {
                if (banque.GetSoldeCompte < montant)
                    throw new Exception($"Le solde du guichet est plus petit que le montant saisi. Solde disponible: $ {banque.GetSoldeCompte}");

                _soldeCompteCourant = compte.Retrait(montant);
                banque.Retrait(montant);
                return true;
            }
            return false;
        }

        public bool DepotCheque(string nip, decimal montant)
        {
            var compte = comptesCheque.GetCompteCheque(nip);

            if (compte != null)
            {
                _soldeCompteCourant = compte.Depot(montant);
                return true;
            }
            return false;
        }

        public bool DepotEpargne(string nip, decimal montant)
        {
            var compte = comptesEpargne.GetCompteEpargne(nip);

            if (compte != null)
            {
                _soldeCompteCourant = compte.Depot(montant);
                return true;
            }
            return false;
        }

        public bool PaiementFacture(string nip, decimal montant)
        {
            var compte = comptesCheque.GetCompteCheque(nip);

            if (compte != null)
            {
                _soldeCompteCourant = compte.PaiementFacture(montant);
                return true;
            }
            return false;

        }

        public void TransfertFonds(string nip, decimal montant, string typeCompte)
        {
            var compteC = comptesCheque.GetCompteCheque(nip);
            var compteE = comptesEpargne.GetCompteEpargne(nip);

            if (compteC == null)
                throw new Exception("Compte cheque n'a pas été trouvée.");

            if (compteE == null)
                throw new Exception("Compte épargne n'a pas été trouvée.");

            if (typeCompte == typeCompteCheque)
            {
                compteE.Depot(montant);
                _soldeCompteCourant = compteC.Retrait(montant);
            }
            else if (typeCompte == typeCompteEpargne)
            {
                compteC.Depot(montant);
                _soldeCompteCourant = compteE.Retrait(montant);
            }
        }

        public decimal AfficherSoldeCompte()
        {
            return _soldeCompteCourant;
        }

        public bool LireClients()
        {
            char[] separateur = new char[] { ',' };
            string ligneactuelle;

            string nom;
            string numeroNIP;

            bool lecture = false;

            try
            {
                string appDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName;
                string filePath;

                if (appDir != null)
                    filePath = Path.Combine(appDir, @"Files\Clients.txt");
                else
                    throw new Exception("Répertoire de fichiers introuvable!");

                StreamReader str = new StreamReader(filePath);

                ligneactuelle = str.ReadLine();

                while (ligneactuelle != null)
                {
                    string[] ligneactuellesplit = ligneactuelle.Split(separateur);
                    nom = ligneactuellesplit[0].ToString();
                    numeroNIP = ligneactuellesplit[1].ToString();

                    clients.AjouterClient(nom, numeroNIP);

                    ligneactuelle = str.ReadLine();
                }

                lecture = true;
                str.Close();

            }
            catch (IOException e)
            {

                throw new Exception(e.ToString());
            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }

            return lecture;
        }

        public bool LireComptes()
        {
            char[] separateur = new char[] { ',' };
            string ligneactuelle;

            string typeCompte;
            string numeroNIP;
            int numeroCompte;
            decimal soldeCompte;

            bool lecture = false;

            try
            {
                string appDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName;
                string filePath;

                if (appDir != null)
                    filePath = Path.Combine(appDir, @"Files\Comptes.txt");
                else
                    throw new Exception("Répertoire de fichiers introuvable!");

                StreamReader str = new StreamReader(filePath);

                ligneactuelle = str.ReadLine();

                while (ligneactuelle != null)
                {
                    string[] ligneactuellesplit = ligneactuelle.Split(separateur);
                    typeCompte = ligneactuellesplit[0];
                    numeroNIP = ligneactuellesplit[1];
                    numeroCompte = ligneactuellesplit[2] != null ? Convert.ToInt32(ligneactuellesplit[2]) : 0;
                    ligneactuellesplit[3] = ligneactuellesplit[3].Replace(',', '.');
                    decimal.TryParse(ligneactuellesplit[3], NumberStyles.Any, CultureInfo.InvariantCulture, out soldeCompte);

                    switch (typeCompte)
                    {
                        case typeCompteCheque:
                            comptesCheque.AjouterCompteCheque(numeroNIP, numeroCompte, soldeCompte);
                            break;
                        case typeCompteEpargne:
                            comptesEpargne.AjouterCompteEpargne(numeroNIP, numeroCompte, soldeCompte);
                            break;
                        case typeCompteBanque:
                            banque = new Banque(numeroNIP, numeroCompte, soldeCompte);
                            break;
                    }
                    ligneactuelle = str.ReadLine();
                }

                lecture = true;
                str.Close();

            }
            catch (IOException e)
            {

                throw new Exception(e.ToString());
            }

            return lecture;
        }

        public bool EcrireComptes()
        {
            bool ecriture = false;
            try
            {
                string appDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName;
                string filePath;

                if (appDir != null)
                    filePath = Path.Combine(appDir, @"Files\Comptes.txt");
                else
                    throw new Exception("Répertoire de fichiers introuvable!");

                StreamWriter stw = new StreamWriter(filePath, false);

                if (banque != null)
                {
                    stw.WriteLine($"{typeCompteBanque},{banque.GetNumeroNIP},{banque.GetNumeroCompte},{banque.GetSoldeCompte.ToString().Replace(",", ".")}");

                    ecriture = true;
                }

                foreach (var cheque in comptesCheque.ListCompteCheque())
                {
                    stw.WriteLine($"{typeCompteCheque},{cheque.GetNumeroNIP},{cheque.GetNumeroCompte},{cheque.GetSoldeCompte.ToString().Replace(",", ".")}");

                    ecriture = true;
                }

                foreach (var epargne in comptesEpargne.ListCompteEpargne())
                {
                    stw.WriteLine($"{typeCompteEpargne},{epargne.GetNumeroNIP},{epargne.GetNumeroCompte},{epargne.GetSoldeCompte.ToString().Replace(",", ".")}");

                    ecriture = true;
                }

                stw.Close();
            }
            catch (IOException e)
            {
                throw new Exception(e.ToString());
            }
            return ecriture;

        }

        public bool PaiementInteret()
        {
            bool success = false;

            var listEpargne = comptesEpargne.ListCompteEpargne();

            if (!listEpargne.Any())
                throw new Exception("Compte épargne n'a pas été trouvée.");

            foreach (var compte in listEpargne)
            {
                compte.PaiementInteret();
                success = true;
            }

            return success;
        }

        public bool RemplirGuichet()
        {
            if (banque == null)
                throw new Exception("Compte banque n'a pas été trouvée.");
            
            _soldeCompteCourant = banque.RemplirGuichet();
            return true;

        }
    }
}
