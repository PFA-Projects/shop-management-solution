namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_CustomerOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerOrders");
        }
    }
}
