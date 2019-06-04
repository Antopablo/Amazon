namespace Amazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajout_historique : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Historiques",
                c => new
                    {
                        _key = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t._key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Historiques");
        }
    }
}
