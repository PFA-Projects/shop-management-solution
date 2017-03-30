namespace App.Migrations
{
    using Gwin;
    using Gwin.Application.BAL;
    using Gwin.Entities.Secrurity.Autorizations;
    using ShopManagement.BLL;
    using ShopManagement.Entities;
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ShopManagement";
        }
        ModelContext db = new ModelContext();
        protected override void Seed(App.ModelContext context)
        {
            //Default Articles Category
            context.ArticleCategories.AddOrUpdate(
                ac => ac.Reference,
                new ArticleCategory() { Id = 1 , Name = "n_ac1", Description = "dec_ac1", Ordre = 1, DateCreation = DateTime.Now },
                new ArticleCategory() {  Id = 2,Name = "n_ac2", Description = "dec_ac2", Ordre = 2, DateCreation = DateTime.Now }
                );
            //Default providers
            //context.Providers.AddOrUpdate(
            //    p => p.Reference,
            //    new Provider {Id=1, Reference = "ref_p1", LastName = "ln_p1" , FirstName= "fn_p1" , Ordre = 1 , DateCreation = DateTime.Now},
            //    new Provider {Id=2 , Reference = "ref_p2", LastName = "ln_p2", FirstName = "fn_p2", Ordre = 2, DateCreation = DateTime.Now }
            //    );
            
        }
        
    }
}
