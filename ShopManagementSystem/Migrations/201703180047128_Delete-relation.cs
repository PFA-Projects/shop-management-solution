namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleterelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLines", "order_Id", "dbo.Orders");
            DropIndex("dbo.OrderLines", new[] { "order_Id" });
            DropColumn("dbo.OrderLines", "order_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderLines", "order_Id", c => c.Long());
            CreateIndex("dbo.OrderLines", "order_Id");
            AddForeignKey("dbo.OrderLines", "order_Id", "dbo.Orders", "Id");
        }
    }
}
