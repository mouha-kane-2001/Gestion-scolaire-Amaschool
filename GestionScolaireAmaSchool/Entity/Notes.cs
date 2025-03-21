using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Notes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Etudiants")]
        public int IdEtudiant { get; set; }
        public virtual Etudiants Etudiants { get; set; }
        public virtual Classes Classes { get; set; }


        [Required]
        [ForeignKey("Matieres")]
        public int IdMatiere { get; set; }
        public virtual Matieres Matieres { get; set; }

        [Required]
        [Range(0, 20)]
        public float Valeur { get; set; }
    }
}

