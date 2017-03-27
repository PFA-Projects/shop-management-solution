namespace App.Migrations
{
    using Gwin;
    using Gwin.Application.BAL;
    using Gwin.Entities.Secrurity.Autorizations;
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

        protected override void Seed(App.ModelContext context)
        {
            //Default Deponses Category
            context.DeponseCategories.AddOrUpdate(
                d => d.Reference,
                new DeponseCategory() { Id = 1, Name = "n_dc" , Description = "desc_dc"} ,
                new DeponseCategory() { Id = 2, Name = "n_dc2", Description = "desc_dc2" },
                new DeponseCategory() { Id = 3, Name = "n_dc3", Description = "desc_dc3" },
                new DeponseCategory() { Id = 1, Name = "n_dc4", Description = "desc_dc4" }
            );

            //Default Deponses
            context.Deponses.AddOrUpdate(
                d => d.Reference,
                new Deponse() { Nom = "n_dep1", Description = "desc_dep1", deponseDate = DateTime.Now, prix = 12 },
                new Deponse() { Nom = "n_dep2", Description = "desc_dep2", deponseDate = DateTime.Now, prix = 14 },
                new Deponse() { Nom = "n_dep3", Description = "desc_dep3", deponseDate = DateTime.Now, prix = 18 },
                new Deponse() { Nom = "n_dep4", Description = "desc_dep4", deponseDate = DateTime.Now, prix = 22 }
                );
        }
    }
}
