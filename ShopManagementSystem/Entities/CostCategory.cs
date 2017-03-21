//Mariam Ait Al
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class CostCategory:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
