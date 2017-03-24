namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update4_Table_CustomerOrderLine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines");
            DropIndex("dbo.Articles", new[] { "CustomerOrderLine_Id" });
            DropColumn("dbo.Articles", "CustomerOrderLine_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "CustomerOrderLine_Id", c => c.Long());
            CreateIndex("dbo.Articles", "CustomerOrderLine_Id");
            AddForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines", "Id");
        }
    }
}
