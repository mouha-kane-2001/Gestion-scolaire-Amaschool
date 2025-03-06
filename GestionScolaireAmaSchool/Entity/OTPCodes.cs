using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaireAmaSchool.Entity
{
    internal class OTPCodes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Utilisateurs")]
        public int IdUtilisateur { get; set; }
        public virtual Utilisateurs Utilisateurs { get; set; }

        [Required]
        [MaxLength(10)]
        public string Code { get; set; } // C et le code Otp a envoyer par sms

        [Required]
        public DateTime DateExpiration { get; set; } //c est la date d expiration d code
    }
}

