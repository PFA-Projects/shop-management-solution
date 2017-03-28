namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Article : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "providerorderline_Id", c => c.Long());
            CreateIndex("dbo.Articles", "providerorderline_Id");
            AddForeignKey("dbo.Articles", "providerorderline_Id", "dbo.ProviderOrderLines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "providerorderline_Id", "dbo.ProviderOrderLines");
            DropIndex("dbo.Articles", new[] { "providerorderline_Id" });
            DropColumn("dbo.Articles", "providerorderline_Id");
        }
    }
}
