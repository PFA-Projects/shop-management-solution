namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update6_Table_Article : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "customerOrderLine_Id", "dbo.CustomerOrderLines");
            DropIndex("dbo.Articles", new[] { "customerOrderLine_Id" });
            DropColumn("dbo.Articles", "customerOrderLine_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "customerOrderLine_Id", c => c.Long());
            CreateIndex("dbo.Articles", "customerOrderLine_Id");
            AddForeignKey("dbo.Articles", "customerOrderLine_Id", "dbo.CustomerOrderLines", "Id");
        }
    }
}
