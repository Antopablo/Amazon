namespace Amazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test_panier : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "Utilisateur_Id", "dbo.UTILISATEUR");
            DropIndex("dbo.Articles", new[] { "Utilisateur_Id" });
            DropColumn("dbo.Articles", "Utilisateur_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Utilisateur_Id", c => c.Int());
            CreateIndex("dbo.Articles", "Utilisateur_Id");
            AddForeignKey("dbo.Articles", "Utilisateur_Id", "dbo.UTILISATEUR", "Id");
        }
    }
}
