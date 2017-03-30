namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_Article4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Articles", "LineState");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "LineState", c => c.String());
        }
    }
}
