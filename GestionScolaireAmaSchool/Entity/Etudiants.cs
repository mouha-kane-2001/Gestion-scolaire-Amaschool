using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Etudiants
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Matricule { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; }

        [Required]
        [MaxLength(100)]
        public string Prenom { get; set; }

        [Required]
        public DateTime DateNaissance { get; set; }

        [Required]
        [MaxLength(10)]
        public string Sexe { get; set; }

        [MaxLength(200)]
        public string Adresse { get; set; }

        [MaxLength(15)]
        public string Telephone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [ForeignKey("Classes")]
        public int IdClasse { get; set; }

        public virtual Classes Classes { get; set; }
    }
}
