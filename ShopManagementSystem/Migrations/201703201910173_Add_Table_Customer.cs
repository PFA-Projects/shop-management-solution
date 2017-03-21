namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Adress = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Deliveries", "Name", c => c.String());
            AddColumn("dbo.Orders", "Name", c => c.String());
            DropColumn("dbo.Deliveries", "DeliveryName");
            DropColumn("dbo.Orders", "OrderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderName", c => c.String());
            AddColumn("dbo.Deliveries", "DeliveryName", c => c.String());
            DropColumn("dbo.Orders", "Name");
            DropColumn("dbo.Deliveries", "Name");
            DropTable("dbo.Customers");
        }
    }
}
