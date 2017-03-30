namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_ProviderOrderLine3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProviderOrderLines", "providerorderLine_Id", c => c.Long());
            CreateIndex("dbo.ProviderOrderLines", "providerorderLine_Id");
            AddForeignKey("dbo.ProviderOrderLines", "providerorderLine_Id", "dbo.ProviderOrderLines", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProviderOrderLines", "providerorderLine_Id", "dbo.ProviderOrderLines");
            DropIndex("dbo.ProviderOrderLines", new[] { "providerorderLine_Id" });
            DropColumn("dbo.ProviderOrderLines", "providerorderLine_Id");
        }
    }
}
