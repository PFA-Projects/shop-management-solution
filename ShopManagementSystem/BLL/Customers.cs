//Mariam Ait Al
using App;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Operations
{
    public class Customers
    {
        ModelContext db = new ModelContext();
        // Customers
        public List<Customer> ListCustomers()
        {
            var query = from a in db.Customers
                        select a;
            return query.ToList<Customer>();
        }
    }
}
