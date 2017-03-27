namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_configuration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.configurations", "RiskOfStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.configurations", "RiskOfStock", c => c.Single(nullable: false));
        }
    }
}
