namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5_Table_CustomerOrderLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "CustomerOrderLine_Id", c => c.Long());
            CreateIndex("dbo.Articles", "CustomerOrderLine_Id");
            AddForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines");
            DropIndex("dbo.Articles", new[] { "CustomerOrderLine_Id" });
            DropColumn("dbo.Articles", "CustomerOrderLine_Id");
        }
    }
}
