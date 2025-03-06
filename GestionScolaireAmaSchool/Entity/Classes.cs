using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Classes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomClasse { get; set; }

        public virtual ICollection<Etudiants> Etudiants { get; set; } = new List<Etudiants>();
    }
}
