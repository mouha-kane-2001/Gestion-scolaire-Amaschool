using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.controls;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;
using GestionScolaireAmaSchool.Forms.FormsGestion;

namespace GestionScolaireAmaSchool.Forms.FormsDashbord
{
    public partial class FormDashbordProfesseur : Form
    {
        private DbContextAmaSchool Db;
        private string role;
        private int id;
        public FormDashbordProfesseur(string role, int id)
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
            this.role = role;
            this.id = id;
        }

        private void FormDashbordProfesseur_Load(object sender, EventArgs e)
        {
            int idClasseProf = Db.ProfesseursClasse
                .Where(c => c.IdProfesseur == this.id)
                .Select(c => c.IdClasse)
                .FirstOrDefault();

            int idMatiereProf = Db.ProfesseursMatiere
                .Where(c => c.IdProfesseur == this.id)
                .Select(c => c.IdMatiere)
                .FirstOrDefault();



            int totalMatiere = Db.Matiere.Where(c => c.Id == idMatiereProf).Count();
            int totalClasse = Db.Classe.Where(c => c.Id == idClasseProf).Count();
            int totalEtudiant  = Db.Etudiant.Where(c=>c.IdClasse == idClasseProf).Count();

            txtEtudiant.Text = (totalEtudiant).ToString();
            txtClasse.Text = (totalClasse).ToString();
            txtMatiere.Text = (totalMatiere).ToString();
        }

        private void btnMatiere_Click(object sender, EventArgs e)
        {
            int idMatiereProf = Db.ProfesseursMatiere
                .Where(c => c.IdProfesseur == this.id)
                .Select(c => c.IdMatiere)
                .FirstOrDefault();
            var listmatiere = Db.Matiere.Where(c => c.Id == idMatiereProf).ToList();
            Validation.chargerGridvies(dtgvProfClasse,listmatiere);
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            int idClasseProf = Db.ProfesseursClasse
               .Where(c => c.IdProfesseur == this.id)
               .Select(c => c.IdClasse)
               .FirstOrDefault();
            var listClasse = Db.Classe.Where(c => c.Id == idClasseProf).ToList();
            Validation.chargerGridvies(dtgvProfClasse, listClasse);
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            FormGestionNotes form = new FormGestionNotes();
            form.Show();
            this.Hide();
        }
    }
}
