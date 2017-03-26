//Mariam Ait Al
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
    public class CustomersBLO: BaseBLO<Customer>
    {
        ModelContext db = new ModelContext();

        public CustomersBLO(DbContext context) : base(context)
        {
        }
    }
}
