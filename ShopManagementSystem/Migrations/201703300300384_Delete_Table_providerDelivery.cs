namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Table_providerDelivery : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ProviderDeliveries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProviderDeliveries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DeliveryDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
