namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update8_Table_Article : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "customerorderline_Id", c => c.Long());
            CreateIndex("dbo.Articles", "customerorderline_Id");
            AddForeignKey("dbo.Articles", "customerorderline_Id", "dbo.CustomerOrderLines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "customerorderline_Id", "dbo.CustomerOrderLines");
            DropIndex("dbo.Articles", new[] { "customerorderline_Id" });
            DropColumn("dbo.Articles", "customerorderline_Id");
        }
    }
}
