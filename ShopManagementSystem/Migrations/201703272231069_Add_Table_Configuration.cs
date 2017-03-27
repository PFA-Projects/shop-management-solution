namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Configuration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.configurations",
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
        
        public override void Down()
        {
            DropTable("dbo.configurations");
        }
    }
}
