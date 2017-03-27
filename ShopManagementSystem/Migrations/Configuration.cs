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
            
            //Default Customers
            context.Customers.AddOrUpdate(
                c=>c.Reference,
                new Customer() { Adress = "ad_c1" , Email = "em_c1" , Phone = "061",FirstName ="fn_c1" , LastName = "ln_c1" },
                new Customer() { Adress = "ad_c2", Email = "em_c2", Phone = "062", FirstName = "fn_c2", LastName = "ln_c2" },
                new Customer() { Adress = "ad_c3", Email = "em_c3", Phone = "063", FirstName = "fn_c3", LastName = "ln_c3" },
                new Customer() { Adress = "ad_c4", Email = "em_c4", Phone = "064", FirstName = "fn_c4", LastName = "ln_c4" }
                );
            //Default ExpensesCategories
            context.ExpensesCategories.AddOrUpdate(
                ec=>ec.Reference,
                new ExpenseCategory() { Name = "n_ec1" , Description="des_ec1"},
                new ExpenseCategory() { Name = "n_ec2", Description = "des_ec2" },
                new ExpenseCategory() { Name = "n_ec3", Description = "des_ec3" },
                new ExpenseCategory() { Name = "n_ec4", Description = "des_ec4" }
                );
            //Default Expenses
            context.Expenses.AddOrUpdate(
                e=>e.Reference,
                new Expense() { Name ="n_e1",Description="d_e1",ExpenseDate = DateTime.Now ,price = 16},
                new Expense() { Name = "n_e2", Description = "d_e2", ExpenseDate = DateTime.Now, price = 18 },
                new Expense() { Name = "n_e3", Description = "d_e3", ExpenseDate = DateTime.Now, price = 189 },
                new Expense() { Name = "n_e4", Description = "d_e4", ExpenseDate = DateTime.Now, price = 197 }
                );
            //Deafult Configurations
            context.configurations.AddOrUpdate(
                c => c.Reference,
                new configuration() { RiskOfStock = 15 , TVA = 5}
                );
        }
    }
}
