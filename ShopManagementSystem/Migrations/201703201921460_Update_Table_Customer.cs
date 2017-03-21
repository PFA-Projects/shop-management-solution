namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "customerDelivery_Id", c => c.Long());
            CreateIndex("dbo.Customers", "customerDelivery_Id");
            AddForeignKey("dbo.Customers", "customerDelivery_Id", "dbo.CustomerDeliveries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "customerDelivery_Id", "dbo.CustomerDeliveries");
            DropIndex("dbo.Customers", new[] { "customerDelivery_Id" });
            DropColumn("dbo.Customers", "customerDelivery_Id");
        }
    }
}
