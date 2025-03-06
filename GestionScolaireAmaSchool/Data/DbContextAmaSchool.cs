using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GestionScolaireAmaSchool.Entity;

namespace GestionScolaireAmaSchool.Data
{
    internal class DbContextAmaSchool : DbContext
    {
        public DbContextAmaSchool() : base("ecolConnect"){ }
            public DbSet<Etudiants> Etudiant { get; set; }
            public DbSet<Classes> Classe { get; set; }
            public DbSet<Cours> Cour { get; set; }
        public DbSet<Matieres> Matiere { get; set; }
        public DbSet<Professeurs> Professeur { get; set; }
        public DbSet<Notes> Note { get; set; }
        public DbSet<Utilisateurs> Utilisateur { get; set; }
        public DbSet<OTPCodes> OTPCode { get; set; }
        public DbSet<ClassesCours> ClassesCour { get; set; }
        public DbSet<CoursMatieres> coursMatiere { get; set; }
        public DbSet<ProfesseursClasses> ProfesseursClasse { get; set; }
        public DbSet<ProfesseursMatieres> ProfesseursMatiere { get; set; }
    }
    }

