using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class CustomerOrderLine:BaseEntity
    {
        public float Quantity { get; set; }

        //Relations - OneToMany
        public Article article { get; set; }
        public CustomerOrder customerOrder { get; set; }
    }
}
