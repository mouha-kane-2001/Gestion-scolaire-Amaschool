using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Forms.FormsAuthentification;
using GestionScolaireAmaSchool.Forms.FormsGestion;
using GestionScolaireAmaSchool.Forms.FormsListe;
using GestionScolaireAmaSchool.Forms.FormRapport;
using GestionScolaireAmaSchool.controls;

namespace GestionScolaireAmaSchool.Forms.FormsAcceuil
{
    public partial class FormDashbord : Form
    {
        private string roleUser;
        private DbContextAmaSchool Db;
        private int id;
        public FormDashbord(string role, int id)
        {
            InitializeComponent();
            roleUser = role;
            SessionManager.UserRole = role;
            SessionManager.IsAuthenticated();
            SessionManager.CheckAuthentication();
            gestionRole();
            Db = new DbContextAmaSchool();
            this.id = id;
        }

        private void gestionRole()
        {

            MessageBox.Show("Role reçu: " + roleUser);
            if (roleUser == "Administrateur")
            {
                MessageBox.Show("admin");

            }
            if (roleUser == "DirecteurEtude")
            {
                MessageBox.Show("De");
                pnlGestEtu.Enabled = false;
                pnlGestEtu.Visible = false;

                pnlGestNote.Enabled = false;
                pnlGestNote.Visible = false;

                pnlGestUser.Enabled = false;
                pnlGestUser.Visible = false;

                btnAllUser.Enabled = false;
                btnAllUser.Visible = false;

                btnAllEtudiant.Visible = false;
                btnAllEtudiant.Enabled = false;

            }


            if (roleUser == "DirecteurAgent")
            {
                MessageBox.Show("Dagent");
                pnlGestUser.Enabled = false;
                pnlGestUser.Visible = false;

                pnlGestProf.Enabled = false;
                pnlGestProf.Visible = false;

                pnlGestClasse.Enabled = false;
                pnlGestClasse.Visible = false;

                pnlGestCourMAtiere.Enabled = false;
                pnlGestCourMAtiere.Visible = false;

                btnAllClasse.Enabled = false;
                btnAllClasse.Visible = false;

                btnAllProf.Enabled = false;
                btnAllProf.Visible = false;

                btnAllMatiere.Enabled = false;
                btnAllMatiere.Visible = false;

                btnAllUser.Enabled = false;
                btnAllUser.Visible = false;

            }
            if (roleUser != "Administrateur" && roleUser != "DirecteurAgent" && roleUser != "DirecteurAgent"){
                SessionManager.LogoutAndRedirectToLogin();
                MessageBox.Show("acces interdite","interdit acces",MessageBoxButtons.OK);
            }


        

        }
        private void FormDashbord_Load(object sender, EventArgs e)
        {
            AfficherGraphique();
            pnlList.Hide();
            btnFermer.Enabled = false;
            btnFermer.Visible = false;
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
            btnFermer.Enabled = true;
            btnFermer.Visible = true;
        }

        private void bntFermer_Click(object sender, EventArgs e)
        {
            pnlList.Hide();
            btnFermer.Hide();
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
            FormListeClasses ges = new FormListeClasses();
            ges.Show();
        }

        private void btnAllMatiere_Click(object sender, EventArgs e)
        {
            FormListeMatieres ges = new FormListeMatieres();
            ges.Show();
        }
        private void AfficherGraphique()
        {
            var etudiantsParClasse = Db.Etudiant
                .GroupBy(e => e.Classes.NomClasse) 
                .Select(g => new
                {
                    Classe = g.Key,
                    NombreEtudiants = g.Count() 
                })
                .ToList();

         
            chartEtudiantParClasse.Series.Clear(); 
            chartEtudiantParClasse.Titles.Clear(); 

       
            chartEtudiantParClasse.Titles.Add("Nombre d'étudiants par classe");

          
            var series = new Series
            {
                Name = "EtudiantsParClasse",
                ChartType = SeriesChartType.Column 
            };

            foreach (var item in etudiantsParClasse)
            {
                var point = new DataPoint();
                point.SetValueXY(item.Classe, item.NombreEtudiants); 
                point.IsValueShownAsLabel = true; 
                point.Label = item.NombreEtudiants.ToString(); 
                series.Points.Add(point); 
            }

          
            chartEtudiantParClasse.Series.Add(series);

           
            chartEtudiantParClasse.ChartAreas[0].AxisX.Title = "Classe";
            chartEtudiantParClasse.ChartAreas[0].AxisY.Title = "Nombre d'étudiants";


            chartEtudiantParClasse.ChartAreas[0].AxisY.Interval = 1;
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            FormRapports formRaport = new FormRapports();
            formRaport.Show();

        }
    }
}
  