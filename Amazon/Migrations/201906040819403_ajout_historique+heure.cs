namespace Amazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_historiqueheure : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Historiques", "datetime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Historiques", "datetime");
        }
    }
}
