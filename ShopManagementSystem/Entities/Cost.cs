//Mariam Ait Al
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class Cost:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Relation - One To Many
        public CostCategory costcategory { get; set; }

    }
}
