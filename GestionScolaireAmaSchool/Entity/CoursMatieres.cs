using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class CoursMatieres
    {
        
        [Key, Column(Order = 1)]
        [Required]
        [ForeignKey("Cours")]
        public int IdCours { get; set; }
        public virtual Cours Cours { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        [ForeignKey("Matieres")]
        public int IdMatiere { get; set; }
        public virtual Matieres Matieres { get; set; }
    }
}

