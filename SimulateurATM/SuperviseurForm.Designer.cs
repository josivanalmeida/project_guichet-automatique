namespace SimulateurATM
{
    partial class SuperviseurForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaiementInteretMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.RemettreArgentMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miseHorsServiceMI = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionRapportsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaiementInteretMI,
            this.toolStripSeparator,
            this.RemettreArgentMI,
            this.toolStripSeparator1,
            this.miseHorsServiceMI,
            this.impressionRapportsMI,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // PaiementInteretMI
            // 
            this.PaiementInteretMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaiementInteretMI.Name = "PaiementInteretMI";
            this.PaiementInteretMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.PaiementInteretMI.Size = new System.Drawing.Size(351, 30);
            this.PaiementInteretMI.Text = "&Paiement des intérêts";
            this.PaiementInteretMI.Click += new System.EventHandler(this.PaiementInteretMI_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(348, 6);
            // 
            // RemettreArgentMI
            // 
            this.RemettreArgentMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemettreArgentMI.Name = "RemettreArgentMI";
            this.RemettreArgentMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RemettreArgentMI.Size = new System.Drawing.Size(351, 30);
            this.RemettreArgentMI.Text = "&Remettre de l’argent";
            this.RemettreArgentMI.Click += new System.EventHandler(this.RemettreArgentMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(348, 6);
            // 
            // miseHorsServiceMI
            // 
            this.miseHorsServiceMI.Name = "miseHorsServiceMI";
            this.miseHorsServiceMI.Size = new System.Drawing.Size(351, 30);
            this.miseHorsServiceMI.Text = "Mise hors service";
            this.miseHorsServiceMI.Visible = false;
            // 
            // impressionRapportsMI
            // 
            this.impressionRapportsMI.Name = "impressionRapportsMI";
            this.impressionRapportsMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.impressionRapportsMI.Size = new System.Drawing.Size(351, 30);
            this.impressionRapportsMI.Text = "Impression des rapports";
            this.impressionRapportsMI.Visible = false;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(351, 30);
            this.exitMenuItem.Text = "&Quitter";
            // 
            // SuperviseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SuperviseurForm";
            this.Text = "Superviseur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaiementInteretMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem RemettreArgentMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseHorsServiceMI;
        private System.Windows.Forms.ToolStripMenuItem impressionRapportsMI;
    }
}