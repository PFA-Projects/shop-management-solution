namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "configurationArticle_Id", "dbo.configurations");
            DropIndex("dbo.Articles", new[] { "configurationArticle_Id" });
            AddColumn("dbo.configurations", "article_Id", c => c.Long());
            CreateIndex("dbo.configurations", "article_Id");
            AddForeignKey("dbo.configurations", "article_Id", "dbo.Articles", "Id");
            DropColumn("dbo.Articles", "configurationArticle_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "configurationArticle_Id", c => c.Long());
            DropForeignKey("dbo.configurations", "article_Id", "dbo.Articles");
            DropIndex("dbo.configurations", new[] { "article_Id" });
            DropColumn("dbo.configurations", "article_Id");
            CreateIndex("dbo.Articles", "configurationArticle_Id");
            AddForeignKey("dbo.Articles", "configurationArticle_Id", "dbo.configurations", "Id");
        }
    }
}
