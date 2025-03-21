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
            this.panelNote = new System.Windows.Forms.Panel();
            this.panelConteneur = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAjoutEtud = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelReleverEtNote = new System.Windows.Forms.Panel();
            this.cmbMatiere1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse1 = new System.Windows.Forms.ComboBox();
            this.btnNote = new System.Windows.Forms.Button();
            this.cmbEtudiant1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAllEtudiant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.btnModi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldtgvNote = new System.Windows.Forms.Panel();
            this.dtgvNote = new System.Windows.Forms.DataGridView();
            this.btnSup = new System.Windows.Forms.Button();
            this.panelMoyene = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMGeneral = new System.Windows.Forms.TextBox();
            this.btnVoirNote = new System.Windows.Forms.Button();
            this.btnVoirRelever = new System.Windows.Forms.Button();
            this.btnVajout = new System.Windows.Forms.Button();
            this.panelNote.SuspendLayout();
            this.panelConteneur.SuspendLayout();
            this.panelAjoutEtud.SuspendLayout();
            this.panelReleverEtNote.SuspendLayout();
            this.paneldtgvNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNote)).BeginInit();
            this.panelMoyene.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(468, 15);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 28);
            this.cmbClasse.TabIndex = 1;
            this.cmbClasse.TextChanged += new System.EventHandler(this.cmbClasse_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(254, 228);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(127, 26);
            this.txtNote.TabIndex = 7;
            // 
            // panelNote
            // 
            this.panelNote.BackColor = System.Drawing.Color.LightGray;
            this.panelNote.Controls.Add(this.panelConteneur);
            this.panelNote.Controls.Add(this.paneldtgvNote);
            this.panelNote.Controls.Add(this.btnVoirNote);
            this.panelNote.Controls.Add(this.btnVoirRelever);
            this.panelNote.Controls.Add(this.btnVajout);
            this.panelNote.Location = new System.Drawing.Point(34, 26);
            this.panelNote.Name = "panelNote";
            this.panelNote.Size = new System.Drawing.Size(1491, 1044);
            this.panelNote.TabIndex = 1;
            // 
            // panelConteneur
            // 
            this.panelConteneur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelConteneur.Controls.Add(this.flowLayoutPanel1);
            this.panelConteneur.Controls.Add(this.panelReleverEtNote);
            this.panelConteneur.Controls.Add(this.panelAjoutEtud);
            this.panelConteneur.Location = new System.Drawing.Point(293, 25);
            this.panelConteneur.Name = "panelConteneur";
            this.panelConteneur.Size = new System.Drawing.Size(621, 520);
            this.panelConteneur.TabIndex = 36;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(237, 186);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelAjoutEtud
            // 
            this.panelAjoutEtud.BackColor = System.Drawing.Color.LightCyan;
            this.panelAjoutEtud.Controls.Add(this.txtId);
            this.panelAjoutEtud.Controls.Add(this.cmbMatiere);
            this.panelAjoutEtud.Controls.Add(this.txtNote);
            this.panelAjoutEtud.Controls.Add(this.label6);
            this.panelAjoutEtud.Controls.Add(this.label2);
            this.panelAjoutEtud.Controls.Add(this.btnAjouter);
            this.panelAjoutEtud.Controls.Add(this.btnAllEtudiant);
            this.panelAjoutEtud.Controls.Add(this.label5);
            this.panelAjoutEtud.Controls.Add(this.cmbEtudiant);
            this.panelAjoutEtud.Controls.Add(this.btnModi);
            this.panelAjoutEtud.Controls.Add(this.label1);
            this.panelAjoutEtud.Controls.Add(this.cmbClasse);
            this.panelAjoutEtud.Location = new System.Drawing.Point(77, 9);
            this.panelAjoutEtud.Name = "panelAjoutEtud";
            this.panelAjoutEtud.Size = new System.Drawing.Size(521, 488);
            this.panelAjoutEtud.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(202, 410);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 27;
            this.txtId.Visible = false;
            // 
            // panelReleverEtNote
            // 
            this.panelReleverEtNote.BackColor = System.Drawing.Color.LightCyan;
            this.panelReleverEtNote.Controls.Add(this.cmbMatiere1);
            this.panelReleverEtNote.Controls.Add(this.label7);
            this.panelReleverEtNote.Controls.Add(this.btnRe);
            this.panelReleverEtNote.Controls.Add(this.label4);
            this.panelReleverEtNote.Controls.Add(this.cmbClasse1);
            this.panelReleverEtNote.Controls.Add(this.btnNote);
            this.panelReleverEtNote.Controls.Add(this.cmbEtudiant1);
            this.panelReleverEtNote.Controls.Add(this.label3);
            this.panelReleverEtNote.Location = new System.Drawing.Point(77, 12);
            this.panelReleverEtNote.Name = "panelReleverEtNote";
            this.panelReleverEtNote.Size = new System.Drawing.Size(541, 462);
            this.panelReleverEtNote.TabIndex = 28;
            // 
            // cmbMatiere1
            // 
            this.cmbMatiere1.FormattingEnabled = true;
            this.cmbMatiere1.Location = new System.Drawing.Point(418, 96);
            this.cmbMatiere1.Name = "cmbMatiere1";
            this.cmbMatiere1.Size = new System.Drawing.Size(121, 28);
            this.cmbMatiere1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(423, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Matiere";
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe.Location = new System.Drawing.Point(429, 302);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(110, 48);
            this.btnRe.TabIndex = 30;
            this.btnRe.Text = "Relever";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(194, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Par Classe";
            // 
            // cmbClasse1
            // 
            this.cmbClasse1.FormattingEnabled = true;
            this.cmbClasse1.Location = new System.Drawing.Point(199, 96);
            this.cmbClasse1.Name = "cmbClasse1";
            this.cmbClasse1.Size = new System.Drawing.Size(121, 28);
            this.cmbClasse1.TabIndex = 28;
            this.cmbClasse1.TextChanged += new System.EventHandler(this.cmbClasse_TextChanged1);
            // 
            // btnNote
            // 
            this.btnNote.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.Location = new System.Drawing.Point(99, 284);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(110, 48);
            this.btnNote.TabIndex = 27;
            this.btnNote.Text = "Note";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // cmbEtudiant1
            // 
            this.cmbEtudiant1.FormattingEnabled = true;
            this.cmbEtudiant1.Location = new System.Drawing.Point(22, 96);
            this.cmbEtudiant1.Name = "cmbEtudiant1";
            this.cmbEtudiant1.Size = new System.Drawing.Size(121, 28);
            this.cmbEtudiant1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Etudiant";
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(254, 151);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(121, 28);
            this.cmbMatiere.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(81, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Etudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(81, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Note";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(297, 326);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 48);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAllEtudiant
            // 
            this.btnAllEtudiant.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEtudiant.Location = new System.Drawing.Point(116, 5);
            this.btnAllEtudiant.Name = "btnAllEtudiant";
            this.btnAllEtudiant.Size = new System.Drawing.Size(158, 48);
            this.btnAllEtudiant.TabIndex = 26;
            this.btnAllEtudiant.Text = "Tous les  Etudiant";
            this.btnAllEtudiant.UseVisualStyleBackColor = true;
            this.btnAllEtudiant.Click += new System.EventHandler(this.btnAllEtudiant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(81, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Matiere";
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.Location = new System.Drawing.Point(254, 91);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(121, 28);
            this.cmbEtudiant.TabIndex = 24;
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModi.Location = new System.Drawing.Point(30, 326);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(211, 48);
            this.btnModi.TabIndex = 21;
            this.btnModi.Text = "Modifier";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(304, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Par Classe";
            // 
            // paneldtgvNote
            // 
            this.paneldtgvNote.Controls.Add(this.dtgvNote);
            this.paneldtgvNote.Controls.Add(this.btnSup);
            this.paneldtgvNote.Controls.Add(this.panelMoyene);
            this.paneldtgvNote.Location = new System.Drawing.Point(920, 33);
            this.paneldtgvNote.Name = "paneldtgvNote";
            this.paneldtgvNote.Size = new System.Drawing.Size(568, 520);
            this.paneldtgvNote.TabIndex = 35;
            // 
            // dtgvNote
            // 
            this.dtgvNote.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNote.Location = new System.Drawing.Point(45, 15);
            this.dtgvNote.Name = "dtgvNote";
            this.dtgvNote.RowHeadersWidth = 62;
            this.dtgvNote.RowTemplate.Height = 28;
            this.dtgvNote.Size = new System.Drawing.Size(469, 379);
            this.dtgvNote.TabIndex = 27;
            this.dtgvNote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgvNote_MouseDoubleClick);
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(45, 425);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(142, 48);
            this.btnSup.TabIndex = 22;
            this.btnSup.Text = "Suprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // panelMoyene
            // 
            this.panelMoyene.Controls.Add(this.label8);
            this.panelMoyene.Controls.Add(this.txtMGeneral);
            this.panelMoyene.Location = new System.Drawing.Point(220, 425);
            this.panelMoyene.Name = "panelMoyene";
            this.panelMoyene.Size = new System.Drawing.Size(275, 87);
            this.panelMoyene.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "MOY: ";
            // 
            // txtMGeneral
            // 
            this.txtMGeneral.Location = new System.Drawing.Point(91, 30);
            this.txtMGeneral.Multiline = true;
            this.txtMGeneral.Name = "txtMGeneral";
            this.txtMGeneral.Size = new System.Drawing.Size(149, 46);
            this.txtMGeneral.TabIndex = 33;
            // 
            // btnVoirNote
            // 
            this.btnVoirNote.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirNote.Location = new System.Drawing.Point(26, 326);
            this.btnVoirNote.Name = "btnVoirNote";
            this.btnVoirNote.Size = new System.Drawing.Size(211, 48);
            this.btnVoirNote.TabIndex = 32;
            this.btnVoirNote.Text = "VoirNote";
            this.btnVoirNote.UseVisualStyleBackColor = true;
            this.btnVoirNote.Click += new System.EventHandler(this.btnVoirNote_Click);
            // 
            // btnVoirRelever
            // 
            this.btnVoirRelever.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirRelever.Location = new System.Drawing.Point(26, 202);
            this.btnVoirRelever.Name = "btnVoirRelever";
            this.btnVoirRelever.Size = new System.Drawing.Size(211, 48);
            this.btnVoirRelever.TabIndex = 31;
            this.btnVoirRelever.Text = "Voir Relever";
            this.btnVoirRelever.UseVisualStyleBackColor = true;
            this.btnVoirRelever.Click += new System.EventHandler(this.btnVoirRelever_Click);
            // 
            // btnVajout
            // 
            this.btnVajout.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVajout.Location = new System.Drawing.Point(17, 33);
            this.btnVajout.Name = "btnVajout";
            this.btnVajout.Size = new System.Drawing.Size(211, 48);
            this.btnVajout.TabIndex = 29;
            this.btnVajout.Text = "AjouterNote";
            this.btnVajout.UseVisualStyleBackColor = true;
            this.btnVajout.Click += new System.EventHandler(this.btnVajout_Click);
            // 
            // FormGestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1050);
            this.Controls.Add(this.panelNote);
            this.Name = "FormGestionNotes";
            this.Text = "FormGestionNotes";
            this.Load += new System.EventHandler(this.FormGestionNotes_Load);
            this.panelNote.ResumeLayout(false);
            this.panelConteneur.ResumeLayout(false);
            this.panelAjoutEtud.ResumeLayout(false);
            this.panelAjoutEtud.PerformLayout();
            this.panelReleverEtNote.ResumeLayout(false);
            this.panelReleverEtNote.PerformLayout();
            this.paneldtgvNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNote)).EndInit();
            this.panelMoyene.ResumeLayout(false);
            this.panelMoyene.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panelNote;
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
        private System.Windows.Forms.DataGridView dtgvNote;
        private System.Windows.Forms.Button btnVajout;
        private System.Windows.Forms.Panel panelReleverEtNote;
        private System.Windows.Forms.ComboBox cmbEtudiant1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAjoutEtud;
        private System.Windows.Forms.Button btnVoirNote;
        private System.Windows.Forms.Button btnVoirRelever;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasse1;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.ComboBox cmbMatiere1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMGeneral;
        private System.Windows.Forms.Panel panelMoyene;
        private System.Windows.Forms.Panel paneldtgvNote;
        private System.Windows.Forms.Panel panelConteneur;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtId;
    }
}