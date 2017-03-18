namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_Table_Order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CommandName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CommandName");
        }
    }
}
