namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_CustomerOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerOrders", "customer_Id", c => c.Long());
            CreateIndex("dbo.CustomerOrders", "customer_Id");
            AddForeignKey("dbo.CustomerOrders", "customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrders", "customer_Id", "dbo.Customers");
            DropIndex("dbo.CustomerOrders", new[] { "customer_Id" });
            DropColumn("dbo.CustomerOrders", "customer_Id");
        }
    }
}
