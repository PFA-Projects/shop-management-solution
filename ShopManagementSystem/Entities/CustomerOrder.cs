//Mariam Ait Al
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class CustomerOrder:BaseEntity
    {
        public DateTime OrderDate { get; set; }


        //Initialiser DateTime
        public CustomerOrder()
        {
            OrderDate = DateTime.Now;
        }
    }
}
