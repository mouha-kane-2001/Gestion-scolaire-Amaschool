namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeUtilisateur
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
            this.dtgvUtilisateur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUtilisateur
            // 
            this.dtgvUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUtilisateur.Location = new System.Drawing.Point(86, 87);
            this.dtgvUtilisateur.Name = "dtgvUtilisateur";
            this.dtgvUtilisateur.RowHeadersWidth = 62;
            this.dtgvUtilisateur.RowTemplate.Height = 28;
            this.dtgvUtilisateur.Size = new System.Drawing.Size(745, 276);
            this.dtgvUtilisateur.TabIndex = 1;
            // 
            // FormListeUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.dtgvUtilisateur);
            this.Name = "FormListeUtilisateur";
            this.Text = "FormListeUtilisateur";
            this.Load += new System.EventHandler(this.FormListeUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUtilisateur;
    }
}