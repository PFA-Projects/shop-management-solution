namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_RelationArtcileLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderLines", "article_Id", c => c.Long());
            CreateIndex("dbo.OrderLines", "article_Id");
            AddForeignKey("dbo.OrderLines", "article_Id", "dbo.Articles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "article_Id", "dbo.Articles");
            DropIndex("dbo.OrderLines", new[] { "article_Id" });
            DropColumn("dbo.OrderLines", "article_Id");
        }
    }
}
