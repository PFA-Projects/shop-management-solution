namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Relation_Delivery_Order : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Deliveries", "order_Id", "dbo.Orders");
            DropIndex("dbo.Deliveries", new[] { "order_Id" });
            DropColumn("dbo.Deliveries", "order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Deliveries", "order_Id", c => c.Long());
            CreateIndex("dbo.Deliveries", "order_Id");
            AddForeignKey("dbo.Deliveries", "order_Id", "dbo.Orders", "Id");
        }
    }
}
