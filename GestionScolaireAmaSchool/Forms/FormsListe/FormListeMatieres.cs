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
    public partial class FormListeMatieres : Form
    {
        private DbContextAmaSchool Db;
        
        public FormListeMatieres()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
        }

        private void FormListeMatieres_Load(object sender, EventArgs e)
        {
            dtgvMatiere.DataSource = null;
            var liste = Db.Matiere.ToList();
        }
    }
}
