namespace GestionScolaireAmaSchool.Forms.FormRapport
{
    partial class FormRapports
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnAllMatiere1 = new System.Windows.Forms.Button();
            this.btnAllEtudiant1 = new System.Windows.Forms.Button();
            this.btnAllClasse1 = new System.Windows.Forms.Button();
            this.btnAllProf1 = new System.Windows.Forms.Button();
            this.btnAllUser1 = new System.Windows.Forms.Button();
            this.btnExporterExcel = new System.Windows.Forms.Button();
            this.btnExporterPdf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvRapport = new System.Windows.Forms.DataGridView();
            this.pnlList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnAllMatiere1);
            this.pnlList.Controls.Add(this.btnAllEtudiant1);
            this.pnlList.Controls.Add(this.btnAllClasse1);
            this.pnlList.Controls.Add(this.btnAllProf1);
            this.pnlList.Controls.Add(this.btnAllUser1);
            this.pnlList.Location = new System.Drawing.Point(51, 101);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(325, 512);
            this.pnlList.TabIndex = 35;
            // 
            // btnAllMatiere1
            // 
            this.btnAllMatiere1.Location = new System.Drawing.Point(48, 324);
            this.btnAllMatiere1.Name = "btnAllMatiere1";
            this.btnAllMatiere1.Size = new System.Drawing.Size(246, 71);
            this.btnAllMatiere1.TabIndex = 6;
            this.btnAllMatiere1.Text = "Tous les Matieres";
            this.btnAllMatiere1.UseVisualStyleBackColor = true;
            this.btnAllMatiere1.Click += new System.EventHandler(this.btnAllMatiere1_Click_1);
            // 
            // btnAllEtudiant1
            // 
            this.btnAllEtudiant1.Location = new System.Drawing.Point(48, 24);
            this.btnAllEtudiant1.Name = "btnAllEtudiant1";
            this.btnAllEtudiant1.Size = new System.Drawing.Size(246, 71);
            this.btnAllEtudiant1.TabIndex = 5;
            this.btnAllEtudiant1.Text = "Tous les Etudiant";
            this.btnAllEtudiant1.UseVisualStyleBackColor = true;
            this.btnAllEtudiant1.Click += new System.EventHandler(this.btnAllEtudiant1_Click_1);
            // 
            // btnAllClasse1
            // 
            this.btnAllClasse1.Location = new System.Drawing.Point(48, 230);
            this.btnAllClasse1.Name = "btnAllClasse1";
            this.btnAllClasse1.Size = new System.Drawing.Size(246, 71);
            this.btnAllClasse1.TabIndex = 4;
            this.btnAllClasse1.Text = "Tous les Classes";
            this.btnAllClasse1.UseVisualStyleBackColor = true;
            this.btnAllClasse1.Click += new System.EventHandler(this.btnAllClasse1_Click_1);
            // 
            // btnAllProf1
            // 
            this.btnAllProf1.Location = new System.Drawing.Point(48, 115);
            this.btnAllProf1.Name = "btnAllProf1";
            this.btnAllProf1.Size = new System.Drawing.Size(246, 71);
            this.btnAllProf1.TabIndex = 3;
            this.btnAllProf1.Text = "Tous les Proffesseur";
            this.btnAllProf1.UseVisualStyleBackColor = true;
            this.btnAllProf1.Click += new System.EventHandler(this.btnAllProf1_Click_1);
            // 
            // btnAllUser1
            // 
            this.btnAllUser1.Location = new System.Drawing.Point(48, 412);
            this.btnAllUser1.Name = "btnAllUser1";
            this.btnAllUser1.Size = new System.Drawing.Size(246, 71);
            this.btnAllUser1.TabIndex = 2;
            this.btnAllUser1.Text = "Tous les Utilisateur";
            this.btnAllUser1.UseVisualStyleBackColor = true;
            this.btnAllUser1.Click += new System.EventHandler(this.btnAllUser1_Click_1);
            // 
            // btnExporterExcel
            // 
            this.btnExporterExcel.Location = new System.Drawing.Point(904, 607);
            this.btnExporterExcel.Name = "btnExporterExcel";
            this.btnExporterExcel.Size = new System.Drawing.Size(97, 38);
            this.btnExporterExcel.TabIndex = 34;
            this.btnExporterExcel.Text = "Excel";
            this.btnExporterExcel.UseVisualStyleBackColor = true;
            this.btnExporterExcel.Click += new System.EventHandler(this.btnExporterExcel_Click);
            // 
            // btnExporterPdf
            // 
            this.btnExporterPdf.Location = new System.Drawing.Point(590, 607);
            this.btnExporterPdf.Name = "btnExporterPdf";
            this.btnExporterPdf.Size = new System.Drawing.Size(95, 38);
            this.btnExporterPdf.TabIndex = 33;
            this.btnExporterPdf.Text = "PDF";
            this.btnExporterPdf.UseVisualStyleBackColor = true;
            this.btnExporterPdf.Click += new System.EventHandler(this.btnExporterPdf_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvRapport);
            this.panel1.Location = new System.Drawing.Point(417, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 483);
            this.panel1.TabIndex = 32;
            // 
            // dtgvRapport
            // 
            this.dtgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRapport.Location = new System.Drawing.Point(64, 42);
            this.dtgvRapport.Name = "dtgvRapport";
            this.dtgvRapport.RowHeadersWidth = 62;
            this.dtgvRapport.RowTemplate.Height = 28;
            this.dtgvRapport.Size = new System.Drawing.Size(620, 387);
            this.dtgvRapport.TabIndex = 0;
            // 
            // FormRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 747);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnExporterExcel);
            this.Controls.Add(this.btnExporterPdf);
            this.Controls.Add(this.panel1);
            this.Name = "FormRapports";
            this.Text = "FormRapports";
            this.Load += new System.EventHandler(this.FormRapports_Load);
            this.pnlList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnAllMatiere1;
        private System.Windows.Forms.Button btnAllEtudiant1;
        private System.Windows.Forms.Button btnAllClasse1;
        private System.Windows.Forms.Button btnAllProf1;
        private System.Windows.Forms.Button btnAllUser1;
        private System.Windows.Forms.Button btnExporterExcel;
        private System.Windows.Forms.Button btnExporterPdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvRapport;
    }
}