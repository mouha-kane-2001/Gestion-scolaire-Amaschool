namespace GestionScolaireAmaSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutMatiere : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "Classes_Id", c => c.Int());
            CreateIndex("dbo.Notes", "Classes_Id");
            AddForeignKey("dbo.Notes", "Classes_Id", "dbo.Classes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Classes_Id", "dbo.Classes");
            DropIndex("dbo.Notes", new[] { "Classes_Id" });
            DropColumn("dbo.Notes", "Classes_Id");
        }
    }
}
