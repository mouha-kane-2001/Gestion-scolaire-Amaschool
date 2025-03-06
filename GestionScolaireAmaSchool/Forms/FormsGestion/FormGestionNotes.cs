using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;

namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class FormGestionNotes : Form
    {
        private DbContextAmaSchool Db;
        public FormGestionNotes()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
        }

        private void FormGestionNotes_Load(object sender, EventArgs e)
        {
            var etudiant = Db.Etudiant.ToList();
            var classe = Db.Classe.ToList();
            var matiere =  Db.Matiere.ToList();

            cmbClasse.DataSource = classe;
            cmbClasse.DisplayMember = "NomClasse";
            cmbClasse.ValueMember = "Id";

            cmbEtudiant.DataSource = etudiant;
            cmbEtudiant.DisplayMember = "Matricule";
            cmbEtudiant.ValueMember = "Id";

            cmbMatiere.DataSource = matiere;
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "Id";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int notedefaut = 0;
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("veuillez remplir tous les champs");
                return;
            }
            if (!int.TryParse(txtNote.Text, out notedefaut))
            {
                MessageBox.Show("erreur de conversion ");
                return;
            }
            
            
            int noteInt = int.Parse(txtNote.Text);
            if (char.IsDigit((char)noteInt)) {
                MessageBox.Show("pas de caractere dans le note");
                return;
            }

            if (noteInt < 0 || noteInt > 20)
            {
                MessageBox.Show("veuillez entrer un note  invalide compri entre 0 et 20");
                return;
            }


            string textMat = cmbMatiere.Text;
                int idMatiere = Db.Matiere.Where(c => c.NomMatiere == textMat).
                    Select(c => c.Id).FirstOrDefault();

                string  textEtu = cmbEtudiant.Text;
               int  idEtu = Db.Etudiant.Where(c => c.Matricule == textEtu).
                    Select(c => c.Id).FirstOrDefault();

                Notes notes = new Notes();
                notes.IdMatiere = idMatiere;
                notes.IdEtudiant = idEtu;
                notes.Valeur = (noteInt);
                Db.Note.Add(notes);
                Db.SaveChanges();
                MessageBox.Show("note ajouter avec succes");


            

        }

        private void cmbClasse_TextChanged(object sender, EventArgs e)
        {

            string nomclasse = cmbClasse.Text;
            int id = Db.Classe.Where(c=>c.NomClasse == nomclasse).
                Select(c=>c.Id).FirstOrDefault();
            var list = Db.Etudiant.Where(c=>c.IdClasse==id)
                .Select(c =>  new {c.Matricule,c.Id}).ToList();
            cmbEtudiant.DataSource = null;
            cmbEtudiant.DataSource = list;
            cmbEtudiant.ValueMember = "Id";
            cmbEtudiant.DisplayMember = "Matricule";

        }

        private void btnAllEtudiant_Click(object sender, EventArgs e)
        {
            var list = Db.Etudiant.Select(c => new {c.Id,c.Matricule}).ToList();
            cmbEtudiant.DataSource = null;
            cmbEtudiant.DataSource = list;
            cmbEtudiant.ValueMember = "Id";
            cmbEtudiant.DisplayMember = "Matricule";
        }
    }
}
