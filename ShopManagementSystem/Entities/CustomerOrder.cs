//Mariam Ait Al
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "Id")]
    [Menu]
    public class CustomerOrder:BaseEntity
    {
        [DisplayProperty(Titre = "OrderDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime OrderDate { get; set; }


        //Initialiser DateTime
        public CustomerOrder()
        {
            OrderDate = DateTime.Now;
        }

        //Relation One To Many Between Customer and CustomerOrder
        public Customer customer { get; set; }

        
        
    }
}
