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
using GestionScolaireAmaSchool.Forms.FormsAcceuil;

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
                    FormDashbord form = new FormDashbord(roleUser);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("erreur de connexion", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        } 
        
    }
}
