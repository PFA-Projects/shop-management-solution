namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Cost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        costcategory_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CostCategories", t => t.costcategory_Id)
                .Index(t => t.costcategory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Costs", "costcategory_Id", "dbo.CostCategories");
            DropIndex("dbo.Costs", new[] { "costcategory_Id" });
            DropTable("dbo.Costs");
        }
    }
}
