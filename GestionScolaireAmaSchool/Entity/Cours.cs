using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Cours
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomCours { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public virtual ICollection<ClassesCours> ClassesCours { get; set; } = new List<ClassesCours>();
    }
}
