using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class Utilisateurs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NomUtilisateur { get; set; }

        [Required]
        [MaxLength(255)]
        public string MotDePasse { get; set; } 

        [Required]
        [MaxLength(20)]
        public string Role { get; set; } 

        [MaxLength(15)]
        [Phone]
        //avec le telephone nous allons gere A2F
        public string Telephone { get; set; } 
    }
}
  
