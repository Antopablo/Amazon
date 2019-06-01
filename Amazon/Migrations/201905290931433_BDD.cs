namespace Amazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BDD : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UTILISATEUR", name: "Right", newName: "Droit");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.UTILISATEUR", name: "Droit", newName: "Right");
        }
    }
}
