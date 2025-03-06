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
    public partial class FormListeProfesseur : Form
    {
        private DbContextAmaSchool Db;
        
              
        public FormListeProfesseur()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
        }

        private void FormListeProfesseur_Load(object sender, EventArgs e)
        {
            dtgvProfesseur.DataSource = null;
            var liste = Db.Professeur.ToList();
            
        }
    }
}
