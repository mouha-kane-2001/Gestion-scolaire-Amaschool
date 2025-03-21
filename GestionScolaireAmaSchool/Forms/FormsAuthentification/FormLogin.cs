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
using GestionScolaireAmaSchool.Forms.FormsAcceuil;
using GestionScolaireAmaSchool.Forms.FormsDashbord;

namespace GestionScolaireAmaSchool.Forms.FormsAuthentification
{
    public partial class FormLogin : Form
    {
        private DbContextAmaSchool Db;
        public FormLogin()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
        }


       

        private void btnConnextion_Click(object sender, EventArgs e)
        {
            string usn = txtUserName.Text;
            string pswd = txtPasseword.Text;
            if (string.IsNullOrEmpty(pswd) || string.IsNullOrEmpty(usn))
            {
                MessageBox.Show("Veuillez remplir tous les champs ");
            }
            else
            {
                Utilisateurs user = Db.Utilisateur.FirstOrDefault(c => c.NomUtilisateur == usn);
                if (user != null &&
                    BCrypt.Net.BCrypt.Verify(pswd, user.MotDePasse))
                {
                    MessageBox.Show("connexion reussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPasseword.Text = "";
                    txtUserName.Text = "";
                    string roleUser = user.Role;
                    int idUser = user.Id;
                    if (string.IsNullOrEmpty(roleUser)) {
                        MessageBox.Show("role vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    FormDashbordProfesseur formpro = new FormDashbordProfesseur(roleUser, idUser);
                    if ((roleUser == "professeur")) { 
                         
                        formpro.Show();
                        this.Hide();
                        return;

                    }
                    FormDashbord form = new FormDashbord(roleUser, idUser);
                    form.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("erreur de connexion", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
