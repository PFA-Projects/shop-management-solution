namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_CustomerOrderLine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerOrderLines",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Quantity = c.Single(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        article_Id = c.Long(),
                        customerOrder_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.article_Id)
                .ForeignKey("dbo.CustomerOrders", t => t.customerOrder_Id)
                .Index(t => t.article_Id)
                .Index(t => t.customerOrder_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrderLines", "customerOrder_Id", "dbo.CustomerOrders");
            DropForeignKey("dbo.CustomerOrderLines", "article_Id", "dbo.Articles");
            DropIndex("dbo.CustomerOrderLines", new[] { "customerOrder_Id" });
            DropIndex("dbo.CustomerOrderLines", new[] { "article_Id" });
            DropTable("dbo.CustomerOrderLines");
        }
    }
}
