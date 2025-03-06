using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Matieres
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomMatiere { get; set; }

        public virtual ICollection<Cours> Cours { get; set; } = new List<Cours>();
    }
}
