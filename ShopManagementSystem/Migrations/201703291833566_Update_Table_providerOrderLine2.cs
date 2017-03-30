namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_providerOrderLine2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProviderOrderLines", "TotalPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProviderOrderLines", "TotalPrice");
        }
    }
}
