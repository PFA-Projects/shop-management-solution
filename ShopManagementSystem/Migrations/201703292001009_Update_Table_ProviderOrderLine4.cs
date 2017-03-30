namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_ProviderOrderLine4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProviderOrderLines", "Quantity", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProviderOrderLines", "Quantity", c => c.Int(nullable: false));
        }
    }
}
