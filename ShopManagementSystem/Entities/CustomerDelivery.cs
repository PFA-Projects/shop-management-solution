//Mariam Ait Al
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class CustomerDelivery:BaseEntity
    {
        public DateTime DeliveryDate { get; set; }

        //Initiaiser Datetime
        public CustomerDelivery()
        {
            DeliveryDate = DateTime.Now;
        }
    }
}
