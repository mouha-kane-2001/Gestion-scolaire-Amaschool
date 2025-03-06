using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GestionScolaireAmaSchool.Entity
{
    internal class ProfesseursClasses
    {
       
        [Required]
        [Key, Column(Order = 1)]
        [ForeignKey("Professeurs")]
        public int IdProfesseur { get; set; }
        public virtual Professeurs Professeurs { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        [ForeignKey("Classes")]
        public int IdClasse { get; set; }
        public virtual Classes Classes { get; set; }
    }
}

