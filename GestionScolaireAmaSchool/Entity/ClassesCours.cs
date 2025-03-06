using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GestionScolaireAmaSchool.Entity
{
    internal class ClassesCours
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Classes")]
        public int IdClasse { get; set; }
        public virtual Classes Classes { get; set; }
        [Key, Column(Order = 2)]
        [ForeignKey("Cours")]
        public int IdCours { get; set; }
        public virtual Cours Cours { get; set; }
    }
}
