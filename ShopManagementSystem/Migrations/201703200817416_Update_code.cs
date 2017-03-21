namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_code : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.customerDeliveries");
            DropTable("dbo.CustomerOrders");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CNE = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        NumberOrders = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.customerDeliveries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
