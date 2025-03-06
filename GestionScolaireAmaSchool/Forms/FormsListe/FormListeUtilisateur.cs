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

namespace GestionScolaireAmaSchool.Forms.FormsListe
{
    public partial class FormListeUtilisateur : Form
    {
        private DbContextAmaSchool Db;
        

        public FormListeUtilisateur()
        {
            InitializeComponent(); 
            Db = new DbContextAmaSchool();
        }

        private void FormListeUtilisateur_Load(object sender, EventArgs e)
        {
            var liste = Db.Utilisateur.ToList();
            dtgvUtilisateur.DataSource = null;

        }
    }
}
