namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_RelationArticleLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderLines", "order_Id", c => c.Long());
            CreateIndex("dbo.OrderLines", "order_Id");
            AddForeignKey("dbo.OrderLines", "order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "order_Id", "dbo.Orders");
            DropIndex("dbo.OrderLines", new[] { "order_Id" });
            DropColumn("dbo.OrderLines", "order_Id");
        }
    }
}
