namespace Amazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class créa_visu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Description", c => c.String());
            AddColumn("dbo.Articles", "PrixU", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "Nom", c => c.String());
            AddColumn("dbo.Articles", "EstVendable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "EstVendable");
            DropColumn("dbo.Articles", "Nom");
            DropColumn("dbo.Articles", "PrixU");
            DropColumn("dbo.Articles", "Description");
        }
    }
}
