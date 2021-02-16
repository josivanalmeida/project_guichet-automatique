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
    public partial class SuperviseurForm : Form
    {
        GestionnaireGuichet guichet = new GestionnaireGuichet();

        public SuperviseurForm()
        {
            InitializeComponent();

            guichet.LireComptes();
        }

        private void PaiementInteretMI_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (guichet.PaiementInteret())
                {
                    MessageBox.Show("Paiement d'intérêt a été ajouté.");
                }
                else
                {
                    MessageBox.Show("Erreur pendant le paiement d'intérêt.");
                }
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemettreArgentMI_Click(object sender, EventArgs e)
        {
            try
            {

                if (guichet.RemplirGuichet())
                {
                    MessageBox.Show($"Remplissage du guichet a été effectué. Le solde courant est ${guichet.AfficherSoldeCompte()}");
                }
                else
                {
                    MessageBox.Show("Erreur pendant l'operation.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
