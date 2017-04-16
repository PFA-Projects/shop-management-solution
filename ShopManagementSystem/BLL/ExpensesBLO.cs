using App;
using ShopManagement.BAL;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.BLL
{
    public class ExpensesBLO : BaseBLO<Expense>
    {
        ModelContext db = new ModelContext();

        public ExpensesBLO() : base()
        {
        }

        public ExpensesBLO(DbContext context) : base(context)
        {
        }

        //Get Expenses By Start Date  and EndDate 
        public List<Object> GetExpByStartDate_Ed(DateTime StartDate , DateTime EndDate)
        {
            var query = from e in db.Expenses
                        join ce in db.ExpensesCategories
                        on e.expenseCategory.Id equals ce.Id
                        where e.ExpenseDate.Day >= StartDate.Day
                        && e.ExpenseDate.Month >= StartDate.Month
                        && e.ExpenseDate.Year >= StartDate.Year
                        && e.ExpenseDate.Day <= EndDate.Day
                        && e.ExpenseDate.Month <= EndDate.Month
                        && e.ExpenseDate.Year <= EndDate.Year
                        && e.ExpenseDate.Day <= EndDate.Day
                        select new
                        {
                            ExpencesDescription = e.Description,
                            ExpensePrice = e.price,
                            ExpenseCategory = ce.Name
                        };
            return query.ToList<Object>();
        }

        //Get List Expences By StartDate , EndDate
        public List<Expense> GetExpBySD_ES(DateTime StartDate , DateTime EndDate)
        {
            var query = from e in db.Expenses
                        where e.ExpenseDate.Day >= StartDate.Day
                        && e.ExpenseDate.Month >= StartDate.Month
                        && e.ExpenseDate.Year >= StartDate.Year
                        && e.ExpenseDate.Day <= EndDate.Day
                        && e.ExpenseDate.Month <= EndDate.Month
                        && e.ExpenseDate.Year <= EndDate.Year
                        && e.ExpenseDate.Day <= EndDate.Day
                        select e;
            return query.ToList<Expense>();
        }
    }
}
