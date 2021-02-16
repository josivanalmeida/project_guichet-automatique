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
    public partial class AuthentificationForm : Form
    {
        GestionnaireGuichet guichet = new GestionnaireGuichet();

        const string admin = "KORBEN DALLAS";
        int essaiLogin = 0;

        public AuthentificationForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string nip = textBoxMot.Text;

            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Le nom d'utilisateur est obligatoire", "Attention");
                textBoxNom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nip))
            {
                MessageBox.Show("Le NIP est obligatoire", "Attention");
                textBoxMot.Focus();
                return;
            }

            essaiLogin++;

            if (essaiLogin > 3)
            {
                MessageBox.Show("Vous avez dépassé la limite de tentatives!", "Attention", MessageBoxButtons.OK);
                Application.Exit();
            }

            if (guichet.ValiderUtilisateur(nom, nip))
            {
                if (nom.ToUpper() == admin)
                {
                    SuperviseurForm formSuper = new SuperviseurForm();
                    formSuper.Visible = true;
                    formSuper.Activate();
                }
                else
                {
                    MainWindow form = new MainWindow(nip);
                    form.Visible = true;
                    form.Activate();
                }

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("L'information de login est invalide.", "Attention");
                textBoxNom.Focus();
                return;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
