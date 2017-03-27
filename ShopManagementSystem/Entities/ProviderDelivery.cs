//Mariam Ait Al

using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class ProviderDelivery: BaseEntity
    {
        public DateTime DeliveryDate { get; set; }

        //Initialize the DateTime
        public ProviderDelivery()
        {
            DeliveryDate = DateTime.Now;
        }
    }
}
