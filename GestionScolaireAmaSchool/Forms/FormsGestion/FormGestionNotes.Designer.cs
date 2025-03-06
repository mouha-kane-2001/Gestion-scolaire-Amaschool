namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    partial class FormGestionNotes
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
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAllEtudiant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(489, 66);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 28);
            this.cmbClasse.TabIndex = 1;
            this.cmbClasse.TextChanged += new System.EventHandler(this.cmbClasse_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(134, 170);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(127, 26);
            this.txtNote.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllEtudiant);
            this.panel1.Controls.Add(this.cmbMatiere);
            this.panel1.Controls.Add(this.cmbEtudiant);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnSup);
            this.panel1.Controls.Add(this.btnModi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.cmbClasse);
            this.panel1.Location = new System.Drawing.Point(138, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 488);
            this.panel1.TabIndex = 1;
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(134, 70);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(121, 28);
            this.cmbMatiere.TabIndex = 25;
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.Location = new System.Drawing.Point(134, 15);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(121, 28);
            this.cmbEtudiant.TabIndex = 24;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(59, 352);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 48);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(332, 352);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(211, 48);
            this.btnSup.TabIndex = 22;
            this.btnSup.Text = "Suprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModi.Location = new System.Drawing.Point(587, 352);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(211, 48);
            this.btnModi.TabIndex = 21;
            this.btnModi.Text = "Modifier";
            this.btnModi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Matiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(484, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Par Classe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Etudiant";
            // 
            // btnAllEtudiant
            // 
            this.btnAllEtudiant.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEtudiant.Location = new System.Drawing.Point(681, 46);
            this.btnAllEtudiant.Name = "btnAllEtudiant";
            this.btnAllEtudiant.Size = new System.Drawing.Size(211, 48);
            this.btnAllEtudiant.TabIndex = 26;
            this.btnAllEtudiant.Text = "Tous les  Etudiant";
            this.btnAllEtudiant.UseVisualStyleBackColor = true;
            this.btnAllEtudiant.Click += new System.EventHandler(this.btnAllEtudiant_Click);
            // 
            // FormGestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 658);
            this.Controls.Add(this.panel1);
            this.Name = "FormGestionNotes";
            this.Text = "FormGestionNotes";
            this.Load += new System.EventHandler(this.FormGestionNotes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.ComboBox cmbEtudiant;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAllEtudiant;
    }
}