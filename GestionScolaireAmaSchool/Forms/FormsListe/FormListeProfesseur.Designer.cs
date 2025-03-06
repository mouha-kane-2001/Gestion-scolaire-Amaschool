namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeProfesseur
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
            this.dtgvProfesseur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvProfesseur
            // 
            this.dtgvProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProfesseur.Location = new System.Drawing.Point(106, 78);
            this.dtgvProfesseur.Name = "dtgvProfesseur";
            this.dtgvProfesseur.RowHeadersWidth = 62;
            this.dtgvProfesseur.RowTemplate.Height = 28;
            this.dtgvProfesseur.Size = new System.Drawing.Size(814, 276);
            this.dtgvProfesseur.TabIndex = 0;
            // 
            // FormListeProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.dtgvProfesseur);
            this.Name = "FormListeProfesseur";
            this.Text = "FormListeProfesseur";
            this.Load += new System.EventHandler(this.FormListeProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProfesseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProfesseur;
    }
}