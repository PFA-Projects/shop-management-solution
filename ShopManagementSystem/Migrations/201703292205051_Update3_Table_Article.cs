namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3_Table_Article : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "LineState", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "LineState");
        }
    }
}
