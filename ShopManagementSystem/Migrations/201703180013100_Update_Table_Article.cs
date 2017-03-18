namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Article : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "articleCategory_Id", c => c.Long());
            CreateIndex("dbo.Articles", "articleCategory_Id");
            AddForeignKey("dbo.Articles", "articleCategory_Id", "dbo.ArticleCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "articleCategory_Id", "dbo.ArticleCategories");
            DropIndex("dbo.Articles", new[] { "articleCategory_Id" });
            DropColumn("dbo.Articles", "articleCategory_Id");
        }
    }
}
