namespace App.Migrations
{
    using Gwin;
    using Gwin.Application.BAL;
    using Gwin.Entities.Secrurity.Autorizations;
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
     
           
        }
    }
}
