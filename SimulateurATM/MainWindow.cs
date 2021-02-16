using SimulateurLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulateurATM
{
    public partial class MainWindow : Form
    {
        GestionnaireGuichet guichet = new GestionnaireGuichet();

        string _compteur;
        string _nip;

        public MainWindow(string nip)
        {
            InitializeComponent();
            _nip = nip;

            guichet.LireComptes();
        }

        private void buttonPaveNumerique_Click(object sender, EventArgs e)
        {
            _compteur = _compteur + ((Button)sender).Text;

            tbValeur.Text = _compteur;
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            _compteur = string.Empty;
            tbValeur.Text = string.Empty;
        }
        
        private void rbPaieFacture_CheckedChanged(object sender, EventArgs e)
        {
            rbCheque.Checked = true;
            rbEpargne.Enabled = false;
        }

        private void rbTransaction_CheckedChanged(object sender, EventArgs e)
        {
            rbEpargne.Enabled = true;
        }

        private void buttonSoumettre_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbValeur.Text))
                {
                    MessageBox.Show("La valeur doit étrê plus grand que 0.");
                    return;
                }

                decimal montant = Convert.ToDecimal(tbValeur.Text.Replace(".", ","));

                bool compteCheque = rbCheque.Checked;
                bool compteEpargne = rbEpargne.Checked;

                bool transactionOK = false;

                if (rbDepot.Checked)
                {
                    if (compteCheque)
                    {
                        transactionOK = guichet.DepotCheque(_nip, montant);
                    }
                    else if (compteEpargne)
                    {
                        transactionOK = guichet.DepotEpargne(_nip, montant);
                    }
                }

                else if (rbRetrait.Checked)
                {
                    if (compteCheque)
                    {
                        transactionOK = guichet.RetraitCheque(_nip, montant);
                    }
                    else if (compteEpargne)
                    {
                        transactionOK = guichet.RetraitEpargne(_nip, montant);
                    }
                }

                else if (rbTransfert.Checked)
                {
                    guichet.TransfertFonds(_nip, montant, compteCheque ? "C" : "S");
                    transactionOK = true;
                }

                else if (rbPaieFacture.Checked)
                {
                    transactionOK = guichet.PaiementFacture(_nip, montant);
                }

                if (!transactionOK)
                {
                    MessageBox.Show("Erreur pendant l'operation." , "Erreur");
                }
                else
                {
                    //metre à jour le fichier
                    guichet.EcrireComptes();

                    var solde = guichet.AfficherSoldeCompte();
                    var descriptionCompte = compteCheque ? rbCheque.Text : rbEpargne.Text;
                    MessageBox.Show($"L'operation a été effectué avec succès. Le solde de la compte {descriptionCompte} est ${solde}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }
              
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
