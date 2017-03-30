namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_ProviderOrderLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProviderOrderLines", "LineState", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProviderOrderLines", "LineState");
        }
    }
}
