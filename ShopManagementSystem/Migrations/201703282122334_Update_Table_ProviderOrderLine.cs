namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_ProviderOrderLine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProviderOrderLines", "article_Id", "dbo.Articles");
            DropIndex("dbo.ProviderOrderLines", new[] { "article_Id" });
            DropColumn("dbo.ProviderOrderLines", "article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProviderOrderLines", "article_Id", c => c.Long());
            CreateIndex("dbo.ProviderOrderLines", "article_Id");
            AddForeignKey("dbo.ProviderOrderLines", "article_Id", "dbo.Articles", "Id");
        }
    }
}
