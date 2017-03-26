namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationNames",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Tel = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(),
                        Name = c.String(),
                        BuyingPrice = c.Single(nullable: false),
                        SellingPrice = c.Single(nullable: false),
                        Quantity = c.Single(nullable: false),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        articleCategory_Id = c.Long(),
                        customerorderline_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleCategories", t => t.articleCategory_Id)
                .ForeignKey("dbo.CustomerOrderLines", t => t.customerorderline_Id)
                .Index(t => t.articleCategory_Id)
                .Index(t => t.customerorderline_Id);
            
            CreateTable(
                "dbo.CustomerOrderLines",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Quantity = c.Single(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        customerOrder_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerOrders", t => t.customerOrder_Id)
                .Index(t => t.customerOrder_Id);
            
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        customer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.customer_Id)
                .Index(t => t.customer_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Adress = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        customerDelivery_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerDeliveries", t => t.customerDelivery_Id)
                .Index(t => t.customerDelivery_Id);
            
            CreateTable(
                "dbo.CustomerDeliveries",
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
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Country_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Configurations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        value = c.Single(nullable: false),
                        TypeValue = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.CostCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DeliveryDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeponseCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deponses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nom = c.String(),
                        Description = c.String(),
                        deponseDate = c.DateTime(nullable: false),
                        prix = c.Single(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        deponseCategory_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeponseCategories", t => t.deponseCategory_Id)
                .Index(t => t.deponseCategory_Id);
            
            CreateTable(
                "dbo.MenuItemApplications",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 65),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Title_French = c.String(),
                        Title_English = c.String(),
                        Title_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Hidden = c.Boolean(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        BusinessEntity = c.String(),
                        ActionsNamesAsString = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        creationDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        article_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.article_Id)
                .Index(t => t.article_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        orderDate = c.DateTime(nullable: false),
                        DeliveryDateExpected = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        provider_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Providers", t => t.provider_Id)
                .Index(t => t.provider_Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Adresse = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Language = c.Int(nullable: false),
                        Name = c.String(),
                        FirstName = c.String(),
                        CIN = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        ProfilePhoto = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.AuthorizationRoles",
                c => new
                    {
                        Authorization_Id = c.Long(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Authorization_Id, t.Role_Id })
                .ForeignKey("dbo.Authorizations", t => t.Authorization_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Authorization_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.RoleMenuItemApplications",
                c => new
                    {
                        Role_Id = c.Long(nullable: false),
                        MenuItemApplication_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.MenuItemApplication_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.MenuItemApplications", t => t.MenuItemApplication_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.MenuItemApplication_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Orders", "provider_Id", "dbo.Providers");
            DropForeignKey("dbo.OrderLines", "article_Id", "dbo.Articles");
            DropForeignKey("dbo.RoleMenuItemApplications", "MenuItemApplication_Id", "dbo.MenuItemApplications");
            DropForeignKey("dbo.RoleMenuItemApplications", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.AuthorizationRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.AuthorizationRoles", "Authorization_Id", "dbo.Authorizations");
            DropForeignKey("dbo.Deponses", "deponseCategory_Id", "dbo.DeponseCategories");
            DropForeignKey("dbo.Costs", "costcategory_Id", "dbo.CostCategories");
            DropForeignKey("dbo.ContactInformations", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Articles", "customerorderline_Id", "dbo.CustomerOrderLines");
            DropForeignKey("dbo.CustomerOrderLines", "customerOrder_Id", "dbo.CustomerOrders");
            DropForeignKey("dbo.CustomerOrders", "customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "customerDelivery_Id", "dbo.CustomerDeliveries");
            DropForeignKey("dbo.Articles", "articleCategory_Id", "dbo.ArticleCategories");
            DropIndex("dbo.RoleMenuItemApplications", new[] { "MenuItemApplication_Id" });
            DropIndex("dbo.RoleMenuItemApplications", new[] { "Role_Id" });
            DropIndex("dbo.AuthorizationRoles", new[] { "Role_Id" });
            DropIndex("dbo.AuthorizationRoles", new[] { "Authorization_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropIndex("dbo.Orders", new[] { "provider_Id" });
            DropIndex("dbo.OrderLines", new[] { "article_Id" });
            DropIndex("dbo.Roles", new[] { "User_Id" });
            DropIndex("dbo.MenuItemApplications", new[] { "Code" });
            DropIndex("dbo.Deponses", new[] { "deponseCategory_Id" });
            DropIndex("dbo.Costs", new[] { "costcategory_Id" });
            DropIndex("dbo.ContactInformations", new[] { "City_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropIndex("dbo.Customers", new[] { "customerDelivery_Id" });
            DropIndex("dbo.CustomerOrders", new[] { "customer_Id" });
            DropIndex("dbo.CustomerOrderLines", new[] { "customerOrder_Id" });
            DropIndex("dbo.Articles", new[] { "customerorderline_Id" });
            DropIndex("dbo.Articles", new[] { "articleCategory_Id" });
            DropTable("dbo.RoleMenuItemApplications");
            DropTable("dbo.AuthorizationRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Providers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLines");
            DropTable("dbo.Notifications");
            DropTable("dbo.Authorizations");
            DropTable("dbo.Roles");
            DropTable("dbo.MenuItemApplications");
            DropTable("dbo.Deponses");
            DropTable("dbo.DeponseCategories");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Costs");
            DropTable("dbo.CostCategories");
            DropTable("dbo.ContactInformations");
            DropTable("dbo.Configurations");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.CustomerDeliveries");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerOrders");
            DropTable("dbo.CustomerOrderLines");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleCategories");
            DropTable("dbo.AppUsers");
            DropTable("dbo.ApplicationNames");
        }
    }
}
