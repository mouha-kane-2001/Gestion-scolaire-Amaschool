namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeClasses
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
            this.dtgvListeClasse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListeClasse
            // 
            this.dtgvListeClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListeClasse.Location = new System.Drawing.Point(106, 87);
            this.dtgvListeClasse.Name = "dtgvListeClasse";
            this.dtgvListeClasse.RowHeadersWidth = 62;
            this.dtgvListeClasse.RowTemplate.Height = 28;
            this.dtgvListeClasse.Size = new System.Drawing.Size(814, 276);
            this.dtgvListeClasse.TabIndex = 1;
            // 
            // FormListeClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.dtgvListeClasse);
            this.Name = "FormListeClasses";
            this.Text = "FormListeClasses";
            this.Load += new System.EventHandler(this.FormListeClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListeClasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListeClasse;
    }
}