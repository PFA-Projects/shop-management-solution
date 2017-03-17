namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "BuyingPrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Articles", "SellPrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Articles", "QuantityInStock", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "QuantityInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Articles", "SellPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Articles", "BuyingPrice", c => c.Int(nullable: false));
        }
    }
}
