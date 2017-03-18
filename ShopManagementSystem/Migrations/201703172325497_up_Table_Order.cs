namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up_Table_Order : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderName", c => c.String());
            DropColumn("dbo.Orders", "CommandName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "CommandName", c => c.String());
            DropColumn("dbo.Orders", "OrderName");
        }
    }
}
