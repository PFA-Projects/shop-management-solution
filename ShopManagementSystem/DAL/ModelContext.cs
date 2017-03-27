﻿namespace App
{
    using ShopManagement.Entities;
    using Gwin.Entities.Application;
    using Gwin.Entities.ContactInformations;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;

    public class ModelContext : DbContext
    {

     public ModelContext() : base(@"data source =DELL-PC; initial catalog = shop_management_system1; Integrated Security = true ; MultipleActiveResultSets = True; App = EntityFramework")


        {
            // Integrated Security = true
            // user = sa;password=admintp4
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
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<ArticleCategory> ArticleCategories { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDelivery> CustomerDeliveries { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<CustomerOrderLine> CustomerOrderLines { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<ExpenseCategory> ExpensesCategories { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<configuration> configurations { get; set; }
        public virtual DbSet<ProviderDelivery> ProviderDeliveries { get; set; }
        public virtual DbSet<ProviderOrderLine> ProviderOrderLines { get; set; }

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