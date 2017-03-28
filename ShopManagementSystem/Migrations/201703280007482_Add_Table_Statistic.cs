namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Statistic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Statistics");
        }
    }
}
