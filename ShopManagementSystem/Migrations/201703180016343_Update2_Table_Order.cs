namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2_Table_Order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "provider_Id", c => c.Long());
            CreateIndex("dbo.Orders", "provider_Id");
            AddForeignKey("dbo.Orders", "provider_Id", "dbo.Providers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "provider_Id", "dbo.Providers");
            DropIndex("dbo.Orders", new[] { "provider_Id" });
            DropColumn("dbo.Orders", "provider_Id");
        }
    }
}
