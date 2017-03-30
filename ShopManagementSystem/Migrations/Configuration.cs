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
            ////Default Providers
            //context.Providers.AddOrUpdate(
            //    p => p.Reference,
            //    new Provider() { LastName = "ln_p1", Adresse = "ad_p1" , Reference = "ref_p1"},
            //    new Provider() { LastName = "ln_p2", Adresse = "ad_p2", Reference = "ref_p2" }
            //    );
            ////Default Article Categories
            //context.ArticleCategories.AddOrUpdate(
            //    ac => ac.Reference,
            //    new ArticleCategory() { Reference = "ref_ac1",Name = "n_ac1", Description = "dec_ac1"},
            //    new ArticleCategory() { Reference = "ref_ac2", Name = "n_ac2", Description = "dec_ac2" },
            //    new ArticleCategory() { Reference = "ref_ac3", Name = "n_ac3", Description = "dec_ac3" },
            //    new ArticleCategory() { Reference = "ref_ac4", Name = "n_ac4", Description = "dec_ac4" }
            //    );
            
        }
        
    }
}
