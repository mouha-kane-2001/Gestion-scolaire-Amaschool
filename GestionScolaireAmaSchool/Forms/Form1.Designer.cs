namespace GestionScolaireAmaSchool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouveuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashbordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nouveuToolStripMenuItem
            // 
            this.nouveuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashbordToolStripMenuItem,
            this.gestionUToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.noteGestionToolStripMenuItem});
            this.nouveuToolStripMenuItem.Name = "nouveuToolStripMenuItem";
            this.nouveuToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.nouveuToolStripMenuItem.Text = "Nouveu";
            // 
            // dashbordToolStripMenuItem
            // 
            this.dashbordToolStripMenuItem.Name = "dashbordToolStripMenuItem";
            this.dashbordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dashbordToolStripMenuItem.Text = "dashbord";
            this.dashbordToolStripMenuItem.Click += new System.EventHandler(this.dashbordToolStripMenuItem_Click);
            // 
            // gestionUToolStripMenuItem
            // 
            this.gestionUToolStripMenuItem.Name = "gestionUToolStripMenuItem";
            this.gestionUToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionUToolStripMenuItem.Text = "GestionU";
            this.gestionUToolStripMenuItem.Click += new System.EventHandler(this.gestionUToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // noteGestionToolStripMenuItem
            // 
            this.noteGestionToolStripMenuItem.Name = "noteGestionToolStripMenuItem";
            this.noteGestionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.noteGestionToolStripMenuItem.Text = "NoteGestion";
            this.noteGestionToolStripMenuItem.Click += new System.EventHandler(this.noteGestionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashbordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteGestionToolStripMenuItem;
    }
}

