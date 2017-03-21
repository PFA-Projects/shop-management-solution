//Mariam Ait Al
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    public class Configuration:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float value { get; set; }
        public string TypeValue { get; set; }
    }
}
