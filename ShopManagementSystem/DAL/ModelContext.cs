namespace App
{
    using ShopManagement.Entities;
    using Gwin.Entities.Application;
    using Gwin.Entities.ContactInformations;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using ShopManagement.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {

    // public ModelContext() : base(@"data source =.\SQLEXPRESS; initial catalog = shop_management_system1; integrated security =true ; MultipleActiveResultSets = True; App = EntityFramework")
       public ModelContext() : base(@"data source =.\SQLEXPRESS; initial catalog = shop_management_system1; user=sa;password=admintp4 ; MultipleActiveResultSets = True; App = EntityFramework")

        {
            // Integrated Security = true
            // 
        }

        public ModelContext(string connectionString):base(connectionString)
        {

        }

        //
        // Gwin : Entites
        //
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MenuItemApplication> MenuItemApplications { get; set; }
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        public virtual DbSet<ApplicationName> ApplicationNames { get; set; }

        //Shop Management System
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        /// <summary>
        /// trouver la liste des type des objets dans le context
        /// </summary>
        /// <returns></returns>
        public List<Type> GetTypesSets()
        {
            var sets = from p in typeof(ModelContext).GetProperties() where p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) let entityType = p.PropertyType.GetGenericArguments().First() select p.PropertyType.GetGenericArguments()[0];
            return sets.ToList<Type>();
        }

    }

    


}