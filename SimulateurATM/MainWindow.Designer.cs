namespace SimulateurATM
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.rbPaieFacture = new System.Windows.Forms.RadioButton();
            this.rbTransfert = new System.Windows.Forms.RadioButton();
            this.rbRetrait = new System.Windows.Forms.RadioButton();
            this.rbDepot = new System.Windows.Forms.RadioButton();
            this.rbEpargne = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.gbCompte = new System.Windows.Forms.GroupBox();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSoumettre = new System.Windows.Forms.Button();
            this.tbValeur = new System.Windows.Forms.TextBox();
            this.gbPaveNumerique = new System.Windows.Forms.GroupBox();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTransaction.SuspendLayout();
            this.gbCompte.SuspendLayout();
            this.gbPaveNumerique.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.rbPaieFacture);
            this.gbTransaction.Controls.Add(this.rbTransfert);
            this.gbTransaction.Controls.Add(this.rbRetrait);
            this.gbTransaction.Controls.Add(this.rbDepot);
            this.gbTransaction.Location = new System.Drawing.Point(408, 36);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(250, 205);
            this.gbTransaction.TabIndex = 0;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Transaction";
            // 
            // rbPaieFacture
            // 
            this.rbPaieFacture.AutoSize = true;
            this.rbPaieFacture.Location = new System.Drawing.Point(16, 165);
            this.rbPaieFacture.Name = "rbPaieFacture";
            this.rbPaieFacture.Size = new System.Drawing.Size(185, 24);
            this.rbPaieFacture.TabIndex = 3;
            this.rbPaieFacture.TabStop = true;
            this.rbPaieFacture.Text = "Paiement de factures";
            this.rbPaieFacture.UseVisualStyleBackColor = true;
            this.rbPaieFacture.CheckedChanged += new System.EventHandler(this.rbPaieFacture_CheckedChanged);
            // 
            // rbTransfert
            // 
            this.rbTransfert.AutoSize = true;
            this.rbTransfert.Location = new System.Drawing.Point(16, 123);
            this.rbTransfert.Name = "rbTransfert";
            this.rbTransfert.Size = new System.Drawing.Size(98, 24);
            this.rbTransfert.TabIndex = 2;
            this.rbTransfert.TabStop = true;
            this.rbTransfert.Text = "Transfert";
            this.rbTransfert.UseVisualStyleBackColor = true;
            this.rbTransfert.CheckedChanged += new System.EventHandler(this.rbTransaction_CheckedChanged);
            // 
            // rbRetrait
            // 
            this.rbRetrait.AutoSize = true;
            this.rbRetrait.Location = new System.Drawing.Point(16, 81);
            this.rbRetrait.Name = "rbRetrait";
            this.rbRetrait.Size = new System.Drawing.Size(82, 24);
            this.rbRetrait.TabIndex = 1;
            this.rbRetrait.TabStop = true;
            this.rbRetrait.Text = "Retrait";
            this.rbRetrait.UseVisualStyleBackColor = true;
            this.rbRetrait.CheckedChanged += new System.EventHandler(this.rbTransaction_CheckedChanged);
            // 
            // rbDepot
            // 
            this.rbDepot.AutoSize = true;
            this.rbDepot.Location = new System.Drawing.Point(16, 41);
            this.rbDepot.Name = "rbDepot";
            this.rbDepot.Size = new System.Drawing.Size(78, 24);
            this.rbDepot.TabIndex = 0;
            this.rbDepot.TabStop = true;
            this.rbDepot.Text = "Dépot";
            this.rbDepot.UseVisualStyleBackColor = true;
            this.rbDepot.CheckedChanged += new System.EventHandler(this.rbTransaction_CheckedChanged);
            // 
            // rbEpargne
            // 
            this.rbEpargne.AutoSize = true;
            this.rbEpargne.Location = new System.Drawing.Point(16, 81);
            this.rbEpargne.Name = "rbEpargne";
            this.rbEpargne.Size = new System.Drawing.Size(95, 24);
            this.rbEpargne.TabIndex = 1;
            this.rbEpargne.Text = "Épargne";
            this.rbEpargne.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Checked = true;
            this.rbCheque.Location = new System.Drawing.Point(16, 41);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(90, 24);
            this.rbCheque.TabIndex = 0;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // gbCompte
            // 
            this.gbCompte.Controls.Add(this.rbEpargne);
            this.gbCompte.Controls.Add(this.rbCheque);
            this.gbCompte.Location = new System.Drawing.Point(408, 261);
            this.gbCompte.Name = "gbCompte";
            this.gbCompte.Size = new System.Drawing.Size(250, 126);
            this.gbCompte.TabIndex = 1;
            this.gbCompte.TabStop = false;
            this.gbCompte.Text = "Compte";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(538, 412);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(120, 35);
            this.buttonFermer.TabIndex = 11;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSoumettre
            // 
            this.buttonSoumettre.Location = new System.Drawing.Point(408, 412);
            this.buttonSoumettre.Name = "buttonSoumettre";
            this.buttonSoumettre.Size = new System.Drawing.Size(120, 35);
            this.buttonSoumettre.TabIndex = 12;
            this.buttonSoumettre.Text = "Soumettre";
            this.buttonSoumettre.UseVisualStyleBackColor = true;
            this.buttonSoumettre.Click += new System.EventHandler(this.buttonSoumettre_Click);
            // 
            // tbValeur
            // 
            this.tbValeur.Location = new System.Drawing.Point(37, 319);
            this.tbValeur.Name = "tbValeur";
            this.tbValeur.Size = new System.Drawing.Size(224, 26);
            this.tbValeur.TabIndex = 13;
            // 
            // gbPaveNumerique
            // 
            this.gbPaveNumerique.Controls.Add(this.buttonEffacer);
            this.gbPaveNumerique.Controls.Add(this.buttonPoint);
            this.gbPaveNumerique.Controls.Add(this.button0);
            this.gbPaveNumerique.Controls.Add(this.button9);
            this.gbPaveNumerique.Controls.Add(this.button8);
            this.gbPaveNumerique.Controls.Add(this.button7);
            this.gbPaveNumerique.Controls.Add(this.button6);
            this.gbPaveNumerique.Controls.Add(this.button5);
            this.gbPaveNumerique.Controls.Add(this.button4);
            this.gbPaveNumerique.Controls.Add(this.button3);
            this.gbPaveNumerique.Controls.Add(this.button2);
            this.gbPaveNumerique.Controls.Add(this.button1);
            this.gbPaveNumerique.Controls.Add(this.tbValeur);
            this.gbPaveNumerique.Location = new System.Drawing.Point(49, 36);
            this.gbPaveNumerique.Name = "gbPaveNumerique";
            this.gbPaveNumerique.Size = new System.Drawing.Size(300, 351);
            this.gbPaveNumerique.TabIndex = 2;
            this.gbPaveNumerique.TabStop = false;
            this.gbPaveNumerique.Text = "Pavé Numérique";
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEffacer.Location = new System.Drawing.Point(37, 251);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(57, 49);
            this.buttonEffacer.TabIndex = 26;
            this.buttonEffacer.Text = "<--";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(204, 251);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(57, 49);
            this.buttonPoint.TabIndex = 25;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(120, 251);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(57, 49);
            this.button0.TabIndex = 24;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(204, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 49);
            this.button9.TabIndex = 22;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(120, 178);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 49);
            this.button8.TabIndex = 21;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(37, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 49);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(204, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 49);
            this.button6.TabIndex = 19;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(120, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 49);
            this.button5.TabIndex = 18;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(37, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 49);
            this.button4.TabIndex = 17;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(204, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonPaveNumerique_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 474);
            this.Controls.Add(this.buttonSoumettre);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.gbPaveNumerique);
            this.Controls.Add(this.gbCompte);
            this.Controls.Add(this.gbTransaction);
            this.Name = "MainWindow";
            this.Text = "Guichet automatique JAS";
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.gbCompte.ResumeLayout(false);
            this.gbCompte.PerformLayout();
            this.gbPaveNumerique.ResumeLayout(false);
            this.gbPaveNumerique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.RadioButton rbPaieFacture;
        private System.Windows.Forms.RadioButton rbTransfert;
        private System.Windows.Forms.RadioButton rbRetrait;
        private System.Windows.Forms.RadioButton rbDepot;
        private System.Windows.Forms.RadioButton rbEpargne;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.GroupBox gbCompte;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSoumettre;
        private System.Windows.Forms.TextBox tbValeur;
        private System.Windows.Forms.GroupBox gbPaveNumerique;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEffacer;
    }
}