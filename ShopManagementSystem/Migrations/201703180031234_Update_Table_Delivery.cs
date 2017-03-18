namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Delivery : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Deliveries", "DeliveryDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Deliveries", "DeliveryDate", c => c.String());
        }
    }
}
