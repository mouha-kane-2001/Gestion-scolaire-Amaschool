namespace GestionScolaireAmaSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MIGRATIONpROFESSEURiD : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Utilisateurs", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Utilisateurs", new[] { "Utilisateur_Id" });
            AddColumn("dbo.Professeurs", "Utilisateur_Id", c => c.Int());
            CreateIndex("dbo.Professeurs", "Utilisateur_Id");
            AddForeignKey("dbo.Professeurs", "Utilisateur_Id", "dbo.Utilisateurs", "Id");
            DropColumn("dbo.Utilisateurs", "Utilisateur_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "Utilisateur_Id", c => c.Int());
            DropForeignKey("dbo.Professeurs", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Professeurs", new[] { "Utilisateur_Id" });
            DropColumn("dbo.Professeurs", "Utilisateur_Id");
            CreateIndex("dbo.Utilisateurs", "Utilisateur_Id");
            AddForeignKey("dbo.Utilisateurs", "Utilisateur_Id", "dbo.Utilisateurs", "Id");
        }
    }
}
