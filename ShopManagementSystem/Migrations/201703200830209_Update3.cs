namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationNames", "Reference", c => c.String());
            AddColumn("dbo.AppUsers", "Reference", c => c.String());
            AddColumn("dbo.ArticleCategories", "Reference", c => c.String());
            AddColumn("dbo.Cities", "Reference", c => c.String());
            AddColumn("dbo.Countries", "Reference", c => c.String());
            AddColumn("dbo.ContactInformations", "Reference", c => c.String());
            AddColumn("dbo.Deliveries", "Reference", c => c.String());
            AddColumn("dbo.MenuItemApplications", "Reference", c => c.String());
            AddColumn("dbo.Roles", "Name_French", c => c.String());
            AddColumn("dbo.Roles", "Name_English", c => c.String());
            AddColumn("dbo.Roles", "Name_Arab", c => c.String());
            AddColumn("dbo.Roles", "Description_French", c => c.String());
            AddColumn("dbo.Roles", "Description_English", c => c.String());
            AddColumn("dbo.Roles", "Description_Arab", c => c.String());
            AddColumn("dbo.Roles", "Reference", c => c.String());
            AddColumn("dbo.Authorizations", "Reference", c => c.String());
            AddColumn("dbo.OrderLines", "Reference", c => c.String());
            AddColumn("dbo.Orders", "Reference", c => c.String());
            AddColumn("dbo.Providers", "Reference", c => c.String());
            AddColumn("dbo.Users", "Reference", c => c.String());
            DropColumn("dbo.Roles", "Name");
            DropColumn("dbo.Roles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Description", c => c.String());
            AddColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Reference");
            DropColumn("dbo.Providers", "Reference");
            DropColumn("dbo.Orders", "Reference");
            DropColumn("dbo.OrderLines", "Reference");
            DropColumn("dbo.Authorizations", "Reference");
            DropColumn("dbo.Roles", "Reference");
            DropColumn("dbo.Roles", "Description_Arab");
            DropColumn("dbo.Roles", "Description_English");
            DropColumn("dbo.Roles", "Description_French");
            DropColumn("dbo.Roles", "Name_Arab");
            DropColumn("dbo.Roles", "Name_English");
            DropColumn("dbo.Roles", "Name_French");
            DropColumn("dbo.MenuItemApplications", "Reference");
            DropColumn("dbo.Deliveries", "Reference");
            DropColumn("dbo.ContactInformations", "Reference");
            DropColumn("dbo.Countries", "Reference");
            DropColumn("dbo.Cities", "Reference");
            DropColumn("dbo.ArticleCategories", "Reference");
            DropColumn("dbo.AppUsers", "Reference");
            DropColumn("dbo.ApplicationNames", "Reference");
        }
    }
}
