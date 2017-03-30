namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_table_providerorderline6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProviderOrderLines", "LineState");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProviderOrderLines", "LineState", c => c.String());
        }
    }
}
