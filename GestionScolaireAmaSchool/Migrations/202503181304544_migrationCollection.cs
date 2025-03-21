namespace GestionScolaireAmaSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationCollection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cours", "Matieres_Id", "dbo.Matieres");
            DropForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs");
            DropIndex("dbo.Cours", new[] { "Matieres_Id" });
            DropIndex("dbo.Cours", new[] { "Professeurs_Id" });
            AddColumn("dbo.Utilisateurs", "Utilisateur_Id", c => c.Int());
            CreateIndex("dbo.Utilisateurs", "Utilisateur_Id");
            AddForeignKey("dbo.Utilisateurs", "Utilisateur_Id", "dbo.Utilisateurs", "Id");
            DropColumn("dbo.Cours", "Matieres_Id");
            DropColumn("dbo.Cours", "Professeurs_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cours", "Professeurs_Id", c => c.Int());
            AddColumn("dbo.Cours", "Matieres_Id", c => c.Int());
            DropForeignKey("dbo.Utilisateurs", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Utilisateurs", new[] { "Utilisateur_Id" });
            DropColumn("dbo.Utilisateurs", "Utilisateur_Id");
            CreateIndex("dbo.Cours", "Professeurs_Id");
            CreateIndex("dbo.Cours", "Matieres_Id");
            AddForeignKey("dbo.Cours", "Professeurs_Id", "dbo.Professeurs", "Id");
            AddForeignKey("dbo.Cours", "Matieres_Id", "dbo.Matieres", "Id");
        }
    }
}
