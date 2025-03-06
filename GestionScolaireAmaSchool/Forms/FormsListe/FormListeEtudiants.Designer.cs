namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeEtudiants
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
            this.dtgvlisteEtudiant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlisteEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvlisteEtudiant
            // 
            this.dtgvlisteEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlisteEtudiant.Location = new System.Drawing.Point(95, 87);
            this.dtgvlisteEtudiant.Name = "dtgvlisteEtudiant";
            this.dtgvlisteEtudiant.RowHeadersWidth = 62;
            this.dtgvlisteEtudiant.RowTemplate.Height = 28;
            this.dtgvlisteEtudiant.Size = new System.Drawing.Size(931, 276);
            this.dtgvlisteEtudiant.TabIndex = 1;
            // 
            // FormListeEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.dtgvlisteEtudiant);
            this.Name = "FormListeEtudiants";
            this.Text = "FormListeEtudiants";
            this.Load += new System.EventHandler(this.FormListeEtudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlisteEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvlisteEtudiant;
    }
}