namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    partial class FormListeCours
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
            this.dtgvCour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCour)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCour
            // 
            this.dtgvCour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCour.Location = new System.Drawing.Point(124, 70);
            this.dtgvCour.Name = "dtgvCour";
            this.dtgvCour.RowHeadersWidth = 62;
            this.dtgvCour.RowTemplate.Height = 28;
            this.dtgvCour.Size = new System.Drawing.Size(814, 276);
            this.dtgvCour.TabIndex = 1;
            // 
            // FormListeCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.dtgvCour);
            this.Name = "FormListeCours";
            this.Text = "FormListeCours";
            this.Load += new System.EventHandler(this.FormListeCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCour;
    }
}