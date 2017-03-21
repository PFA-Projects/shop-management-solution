namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_CustomerDelivery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerDeliveries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DeliveryDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerDeliveries");
        }
    }
}
