namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_data_EStock : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "providerorderline_Id", "dbo.ProviderOrderLines");
            DropIndex("dbo.Articles", new[] { "providerorderline_Id" });
            AddColumn("dbo.ProviderOrderLines", "article_Id", c => c.Long());
            AddColumn("dbo.ProviderOrders", "OrderState", c => c.String());
            CreateIndex("dbo.ProviderOrderLines", "article_Id");
            AddForeignKey("dbo.ProviderOrderLines", "article_Id", "dbo.Articles", "Id");
            DropColumn("dbo.Articles", "providerorderline_Id");
            DropColumn("dbo.ProviderOrderLines", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProviderOrderLines", "TotalPrice", c => c.Single(nullable: false));
            AddColumn("dbo.Articles", "providerorderline_Id", c => c.Long());
            DropForeignKey("dbo.ProviderOrderLines", "article_Id", "dbo.Articles");
            DropIndex("dbo.ProviderOrderLines", new[] { "article_Id" });
            DropColumn("dbo.ProviderOrders", "OrderState");
            DropColumn("dbo.ProviderOrderLines", "article_Id");
            CreateIndex("dbo.Articles", "providerorderline_Id");
            AddForeignKey("dbo.Articles", "providerorderline_Id", "dbo.ProviderOrderLines", "Id");
        }
    }
}
