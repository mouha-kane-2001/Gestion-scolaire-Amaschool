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
using GestionScolaireAmaSchool.Forms.FormsGestion;
using GestionScolaireAmaSchool.Forms.FormsListe;

namespace GestionScolaireAmaSchool.Forms.FormsAcceuil
{
    public partial class FormDashbord : Form
    {
        private  string roleUser;
        private DbContextAmaSchool Db;
        public FormDashbord(string role)
        {
            InitializeComponent();
            roleUser = role;
            gestionRole();
            Db = new DbContextAmaSchool();
        }

        private void gestionRole()
        {
            if (roleUser == "administrateur")
            {
                MessageBox.Show("admin");
            }
            else if (roleUser == "directeur agent")
            {
                MessageBox.Show("De");
            }
            else
            {
                MessageBox.Show("Dagent");
            }
        }
        private void FormDashbord_Load(object sender, EventArgs e)
        {
            pnlList.Hide();
            int totalUser = Db.Utilisateur.Count();
            int totalProf = Db.Professeur.Count();
            int totalEtudiant = Db.Etudiant.Count();
            int totalMatiere = Db.Matiere.Count();
            int totalClasse = Db.Classe.Count();
            int totalCourMatiere = Db.coursMatiere.Count();

            txtCourClasse.Text = (totalCourMatiere).ToString();
            txtEtudiant.Text = (totalEtudiant).ToString();
            txtProfesseur.Text = (totalProf).ToString();
            txtUser.Text = (totalUser).ToString();
            txtClasse.Text = (totalClasse).ToString();
            txtMatiere.Text = (totalMatiere).ToString();


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pnlList.Show();
        }

        private void bntFermer_Click(object sender, EventArgs e)
        {
            pnlList.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GestionUtilisateur ges = new GestionUtilisateur();
            ges.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GestionProfesseurs ges = new GestionProfesseurs();
            ges.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormGestionEtudiant ges = new FormGestionEtudiant();
            ges.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormGestionCoursMatiere ges = new FormGestionCoursMatiere();
            ges.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormGestionClasse ges = new FormGestionClasse();
            ges.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormGestionNotes ges = new FormGestionNotes();
            ges.Show();
            this.Close();
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            FormListeUtilisateur ges = new FormListeUtilisateur();
            ges.Show();
        }

        private void btnAllEtudiant_Click(object sender, EventArgs e)
        {
            FormListeEtudiants ges = new FormListeEtudiants();
            ges.Show();

        }

        private void btnAllProf_Click(object sender, EventArgs e)
        {
            FormListeProfesseur ges = new FormListeProfesseur();
            ges.Show();
        }

        private void btnAllClasse_Click(object sender, EventArgs e)
        {
           FormListeClasses  ges = new FormListeClasses();
            ges.Show();
        }

        private void btnAllMatiere_Click(object sender, EventArgs e)
        {
            FormListeMatieres ges = new FormListeMatieres();
            ges.Show();
        }
    }
}
