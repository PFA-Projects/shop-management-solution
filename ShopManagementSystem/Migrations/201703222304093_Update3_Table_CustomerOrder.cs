namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3_Table_CustomerOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "CustomerOrder_Id", c => c.Long());
            CreateIndex("dbo.Articles", "CustomerOrder_Id");
            AddForeignKey("dbo.Articles", "CustomerOrder_Id", "dbo.CustomerOrders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "CustomerOrder_Id", "dbo.CustomerOrders");
            DropIndex("dbo.Articles", new[] { "CustomerOrder_Id" });
            DropColumn("dbo.Articles", "CustomerOrder_Id");
        }
    }
}
