namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2_Table_Customer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Articles", new[] { "Customer_Id" });
            DropColumn("dbo.Articles", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Customer_Id", c => c.Long());
            CreateIndex("dbo.Articles", "Customer_Id");
            AddForeignKey("dbo.Articles", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
