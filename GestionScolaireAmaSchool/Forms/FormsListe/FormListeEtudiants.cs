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
    public partial class FormListeEtudiants : Form
    {
        private DbContextAmaSchool Db;
       
        public FormListeEtudiants()
        {      
            Db = new DbContextAmaSchool();

            InitializeComponent();
        }

        private void FormListeEtudiants_Load(object sender, EventArgs e)
        {
       dtgvlisteEtudiant.DataSource = null;
            var liste = Db.Etudiant.ToList();
        }
    }
}
