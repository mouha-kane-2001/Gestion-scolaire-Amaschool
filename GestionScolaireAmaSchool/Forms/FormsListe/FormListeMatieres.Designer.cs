namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeMatieres
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
            this.dtgvMatiere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMatiere
            // 
            this.dtgvMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatiere.Location = new System.Drawing.Point(148, 87);
            this.dtgvMatiere.Name = "dtgvMatiere";
            this.dtgvMatiere.RowHeadersWidth = 62;
            this.dtgvMatiere.RowTemplate.Height = 28;
            this.dtgvMatiere.Size = new System.Drawing.Size(802, 276);
            this.dtgvMatiere.TabIndex = 1;
            // 
            // FormListeMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.dtgvMatiere);
            this.Name = "FormListeMatieres";
            this.Text = "FormListeMatieres";
            this.Load += new System.EventHandler(this.FormListeMatieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMatiere;
    }
}