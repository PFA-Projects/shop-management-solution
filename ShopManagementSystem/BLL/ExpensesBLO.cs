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
    }
}
