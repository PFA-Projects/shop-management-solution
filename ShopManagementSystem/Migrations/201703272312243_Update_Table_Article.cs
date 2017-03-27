namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Article : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "configurationArticle_Id", c => c.Long());
            CreateIndex("dbo.Articles", "configurationArticle_Id");
            AddForeignKey("dbo.Articles", "configurationArticle_Id", "dbo.configurations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "configurationArticle_Id", "dbo.configurations");
            DropIndex("dbo.Articles", new[] { "configurationArticle_Id" });
            DropColumn("dbo.Articles", "configurationArticle_Id");
        }
    }
}
