// Mariam Ait Al
using App;
using ShopManagement.BAL;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.BLL
{
    public class ExpenseCategoryBLO : BaseBLO<ExpenseCategory>
    {
        ModelContext db = new ModelContext();

        public ExpenseCategoryBLO() : base()
        {
        }

        public ExpenseCategoryBLO(DbContext context) : base(context)
        {
        }
    }
}
