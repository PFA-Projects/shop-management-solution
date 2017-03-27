namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Table_configuration : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Configurations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Configurations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RiskOfStock = c.Single(nullable: false),
                        TVA = c.Single(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
