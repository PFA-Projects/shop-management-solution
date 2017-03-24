namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_CustomerOrderLine2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerOrderLines", "article_Id", "dbo.Articles");
            DropIndex("dbo.CustomerOrderLines", new[] { "article_Id" });
            AddColumn("dbo.Articles", "CustomerOrderLine_Id", c => c.Long());
            CreateIndex("dbo.Articles", "CustomerOrderLine_Id");
            AddForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines", "Id");
            DropColumn("dbo.CustomerOrderLines", "article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerOrderLines", "article_Id", c => c.Long());
            DropForeignKey("dbo.Articles", "CustomerOrderLine_Id", "dbo.CustomerOrderLines");
            DropIndex("dbo.Articles", new[] { "CustomerOrderLine_Id" });
            DropColumn("dbo.Articles", "CustomerOrderLine_Id");
            CreateIndex("dbo.CustomerOrderLines", "article_Id");
            AddForeignKey("dbo.CustomerOrderLines", "article_Id", "dbo.Articles", "Id");
        }
    }
}
