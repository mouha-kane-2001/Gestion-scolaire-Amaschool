using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Forms.FormsAcceuil;
using GestionScolaireAmaSchool.Forms.FormsAuthentification;
using GestionScolaireAmaSchool.Forms.FormsGestion;

namespace GestionScolaireAmaSchool
{
    public partial class Form1 : Form
    {
        private string role;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dashbordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDashbord formDashbord = new FormDashbord(role);
           formDashbord.Show();
           formDashbord.MdiParent = this;
        }

        private void gestionUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUtilisateur formDashbord = new GestionUtilisateur();
            formDashbord.Show();
            formDashbord.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormLogin formDashbord = new FormLogin();
            formDashbord.Show();
            formDashbord.MdiParent = this;
        }

        private void noteGestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionNotes formDashbord = new FormGestionNotes();
            formDashbord.Show();
            formDashbord.MdiParent = this;
        }
    }
}
