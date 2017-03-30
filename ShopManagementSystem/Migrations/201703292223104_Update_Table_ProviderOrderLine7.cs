namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_ProviderOrderLine7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProviderOrderLines", "providerorderLine_Id", "dbo.ProviderOrderLines");
            DropIndex("dbo.ProviderOrderLines", new[] { "providerorderLine_Id" });
            AddColumn("dbo.ProviderOrderLines", "providerOrder_Id", c => c.Long());
            CreateIndex("dbo.ProviderOrderLines", "providerOrder_Id");
            AddForeignKey("dbo.ProviderOrderLines", "providerOrder_Id", "dbo.ProviderOrders", "Id");
            DropColumn("dbo.ProviderOrderLines", "providerorderLine_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProviderOrderLines", "providerorderLine_Id", c => c.Long());
            DropForeignKey("dbo.ProviderOrderLines", "providerOrder_Id", "dbo.ProviderOrders");
            DropIndex("dbo.ProviderOrderLines", new[] { "providerOrder_Id" });
            DropColumn("dbo.ProviderOrderLines", "providerOrder_Id");
            CreateIndex("dbo.ProviderOrderLines", "providerorderLine_Id");
            AddForeignKey("dbo.ProviderOrderLines", "providerorderLine_Id", "dbo.ProviderOrderLines", "Id");
        }
    }
}
