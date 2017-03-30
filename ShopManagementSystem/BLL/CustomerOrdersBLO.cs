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
    public class CustomerOrdersBLO:BaseBLO<CustomerOrder>
    {
        ModelContext db = new ModelContext();

        public CustomerOrdersBLO(DbContext context) : base(context)
        {
        }
    }
}
